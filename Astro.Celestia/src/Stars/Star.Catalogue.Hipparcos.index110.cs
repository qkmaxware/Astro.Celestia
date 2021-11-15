using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_110() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106524",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15113 B"},
        {"Henry Draper", "HD 239705"},
        {"Hipparcos Number", "HIP 106524"},
        {"Geneva Identification System", "GEN# +1.00239705"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.63664905),
        dec: Angle.Degrees(+59.10824796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26791"},
        {"Hipparcos Number", "HIP 20023"},
        {"Smithsonian Astrophysical Observation", "SAO 24519"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.42048987),
        dec: Angle.Degrees(+59.10872654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208915"},
        {"Hipparcos Number", "HIP 108398"},
        {"Smithsonian Astrophysical Observation", "SAO 33915"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.40845110),
        dec: Angle.Degrees(+59.11397764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211402"},
        {"Hipparcos Number", "HIP 109867"},
        {"Celescope Catalog", "CEL 5459"},
        {"Geneva Identification System", "GEN# +1.00211402"},
        {"Smithsonian Astrophysical Observation", "SAO 34231"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.77093269),
        dec: Angle.Degrees(+59.11447670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237793"},
        {"Hipparcos Number", "HIP 45149"},
        {"Smithsonian Astrophysical Observation", "SAO 27163"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.756,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.98121631),
        dec: Angle.Degrees(+59.11769884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -202.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239415"},
        {"Hipparcos Number", "HIP 100795"},
        {"Smithsonian Astrophysical Observation", "SAO 32589"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.56063205),
        dec: Angle.Degrees(+59.11776054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240425"},
        {"Hipparcos Number", "HIP 117624"},
        {"Geneva Identification System", "GEN# +1.00240425"},
        {"Smithsonian Astrophysical Observation", "SAO 35840"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.83083668),
        dec: Angle.Degrees(+59.11796546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31177"},
        {"Hipparcos Number", "HIP 23033"},
        {"Smithsonian Astrophysical Observation", "SAO 24927"},
    },
    visualMagnitude: 6.55,
    bvColour: 1.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.28982801),
        dec: Angle.Degrees(+59.12036441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97811"},
        {"Hipparcos Number", "HIP 55028"},
        {"Geneva Identification System", "GEN# +1.00097811"},
        {"Renson", "Renson 28200"},
        {"Smithsonian Astrophysical Observation", "SAO 27967"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.98363421),
        dec: Angle.Degrees(+59.12098497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56099"},
        {"Hipparcos Number", "HIP 35457"},
        {"Geneva Identification System", "GEN# +1.00056099"},
        {"Smithsonian Astrophysical Observation", "SAO 26269"},
        {"Wilson Evans Batten Catalogue", "WEB 7072"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.80044409),
        dec: Angle.Degrees(+59.12573885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238729"},
        {"Hipparcos Number", "HIP 86273"},
        {"Smithsonian Astrophysical Observation", "SAO 30492"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.42310681),
        dec: Angle.Degrees(+59.13598208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1486"},
        {"Hipparcos Number", "HIP 1550"},
        {"Geneva Identification System", "GEN# +1.00001486"},
        {"Smithsonian Astrophysical Observation", "SAO 21296"},
        {"Wilson Evans Batten Catalogue", "WEB 282"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.82793307),
        dec: Angle.Degrees(+59.13904402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97420"},
        {"Hipparcos Number", "HIP 54828"},
        {"Geneva Identification System", "GEN# +1.00097420"},
        {"Smithsonian Astrophysical Observation", "SAO 27956"},
        {"Wilson Evans Batten Catalogue", "WEB 9891"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.37788313),
        dec: Angle.Degrees(+59.13926722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239889"},
        {"Hipparcos Number", "HIP 109644"},
        {"Smithsonian Astrophysical Observation", "SAO 34175"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.17095711),
        dec: Angle.Degrees(+59.14097122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114107"},
        {"Hipparcos Number", "HIP 64040"},
        {"Smithsonian Astrophysical Observation", "SAO 28643"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.87523453),
        dec: Angle.Degrees(+59.14869122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 746",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Caph"},
        {"Aitken", "ADS 107 A"},
        {"Henry Draper", "HD 432"},
        {"Hipparcos Number", "HIP 746"},
        {"Celescope Catalog", "CEL 30"},
        {"Cincinnati Publication", "Ci 20 10"},
        {"Fundamental Katalog 5th Edition", "FK5 2"},
        {"Geneva Identification System", "GEN# +1.00000432"},
        {"Smithsonian Astrophysical Observation", "SAO 21133"},
        {"Wilson Evans Batten Catalogue", "WEB 125"},
    },
    visualMagnitude: 2.28,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.29204036),
        dec: Angle.Degrees(+59.15021814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 523.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -180.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18038"},
        {"Hipparcos Number", "HIP 13707"},
        {"Smithsonian Astrophysical Observation", "SAO 23713"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.12368102),
        dec: Angle.Degrees(+59.15063332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57925"},
        {"Hipparcos Number", "HIP 36158"},
        {"Smithsonian Astrophysical Observation", "SAO 26343"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.73824064),
        dec: Angle.Degrees(+59.15179970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90222"},
        {"Hipparcos Number", "HIP 51107"},
        {"Smithsonian Astrophysical Observation", "SAO 27641"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.874,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.62595407),
        dec: Angle.Degrees(+59.15333497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78249"},
        {"Hipparcos Number", "HIP 44990"},
        {"Geneva Identification System", "GEN# +1.00078249"},
        {"Smithsonian Astrophysical Observation", "SAO 27140"},
        {"Wilson Evans Batten Catalogue", "WEB 8591"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.45673704),
        dec: Angle.Degrees(+59.15394834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -169.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26011",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26011"},
        {"Geneva Identification System", "GEN# +0.05900886"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.26481073),
        dec: Angle.Degrees(+59.15435480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -214.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25291"},
        {"Hipparcos Number", "HIP 19018"},
        {"Fundamental Katalog 5th Edition", "FK5 2290"},
        {"Geneva Identification System", "GEN# +1.00025291"},
        {"Smithsonian Astrophysical Observation", "SAO 24384"},
        {"Wilson Evans Batten Catalogue", "WEB 3658"},
    },
    visualMagnitude: 5.00,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.11318196),
        dec: Angle.Degrees(+59.15550819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10757"},
        {"Hipparcos Number", "HIP 8288"},
        {"Geneva Identification System", "GEN# +1.00010757"},
        {"Smithsonian Astrophysical Observation", "SAO 22612"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.69694909),
        dec: Angle.Degrees(+59.15624217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98123",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98123"},
    },
    visualMagnitude: 10.06,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.14357171),
        dec: Angle.Degrees(+59.16180940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -433.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194837"},
        {"Hipparcos Number", "HIP 100701"},
        {"Smithsonian Astrophysical Observation", "SAO 32555"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.23958211),
        dec: Angle.Degrees(+59.16516527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221354"},
        {"Hipparcos Number", "HIP 116085"},
        {"Cincinnati Publication", "Ci 20 1431"},
        {"Geneva Identification System", "GEN# +1.00221354"},
        {"Smithsonian Astrophysical Observation", "SAO 35498"},
        {"Wilson Evans Batten Catalogue", "WEB 20521"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.839,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.83729145),
        dec: Angle.Degrees(+59.16524241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1106.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 112.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89062",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89062"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.66049950),
        dec: Angle.Degrees(+59.16649281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239722"},
        {"Hipparcos Number", "HIP 106830"},
        {"Geneva Identification System", "GEN# +4.35371293"},
        {"Smithsonian Astrophysical Observation", "SAO 33612"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.55858526),
        dec: Angle.Degrees(+59.16753469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20547"},
        {"Hipparcos Number", "HIP 15623"},
        {"Geneva Identification System", "GEN# +1.00020547J"},
        {"Wilson Evans Batten Catalogue", "WEB 2996"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.29795968),
        dec: Angle.Degrees(+59.16765921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41783"},
        {"Hipparcos Number", "HIP 29315"},
        {"Smithsonian Astrophysical Observation", "SAO 25603"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.72194295),
        dec: Angle.Degrees(+59.16933977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240255"},
        {"Hipparcos Number", "HIP 115104"},
        {"Geneva Identification System", "GEN# +1.00240255"},
        {"Smithsonian Astrophysical Observation", "SAO 35320"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.70944564),
        dec: Angle.Degrees(+59.17291838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240284"},
        {"Hipparcos Number", "HIP 115508"},
        {"Celescope Catalog", "CEL 5610"},
        {"Geneva Identification System", "GEN# +1.00240284"},
        {"Smithsonian Astrophysical Observation", "SAO 35384"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.97451674),
        dec: Angle.Degrees(+59.17514208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4422",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Castula"},
        {"Henry Draper", "HD 5395"},
        {"Hipparcos Number", "HIP 4422"},
        {"Geneva Identification System", "GEN# +1.00005395"},
        {"Smithsonian Astrophysical Observation", "SAO 21855"},
        {"Wilson Evans Batten Catalogue", "WEB 792"},
    },
    visualMagnitude: 4.62,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.16671042),
        dec: Angle.Degrees(+59.18116582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50521"},
        {"Hipparcos Number", "HIP 33459"},
        {"Smithsonian Astrophysical Observation", "SAO 26052"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.34077034),
        dec: Angle.Degrees(+59.18549663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86236"},
        {"Hipparcos Number", "HIP 48957"},
        {"Geneva Identification System", "GEN# +1.00086236"},
        {"Smithsonian Astrophysical Observation", "SAO 27455"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.80503290),
        dec: Angle.Degrees(+59.18705790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68771"},
        {"Hipparcos Number", "HIP 40570"},
        {"Geneva Identification System", "GEN# +1.00068771"},
        {"Smithsonian Astrophysical Observation", "SAO 26750"},
        {"Wilson Evans Batten Catalogue", "WEB 7893"},
    },
    visualMagnitude: 6.58,
    bvColour: 1.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.24200097),
        dec: Angle.Degrees(+59.18939505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67368"},
        {"Hipparcos Number", "HIP 40040"},
        {"Fundamental Katalog 5th Edition", "FK5 4736"},
        {"Smithsonian Astrophysical Observation", "SAO 26709"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.68580519),
        dec: Angle.Degrees(+59.19304307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21116"},
        {"Hipparcos Number", "HIP 16103"},
        {"Geneva Identification System", "GEN# +1.00021116"},
        {"Smithsonian Astrophysical Observation", "SAO 24040"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.86016231),
        dec: Angle.Degrees(+59.19561810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13437"},
        {"Hipparcos Number", "HIP 10354"},
        {"Geneva Identification System", "GEN# +4.31020043"},
        {"Smithsonian Astrophysical Observation", "SAO 23041"},
        {"Wilson Evans Batten Catalogue", "WEB 2167"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.36985918),
        dec: Angle.Degrees(+59.19603071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157579"},
        {"Hipparcos Number", "HIP 84845"},
        {"Geneva Identification System", "GEN# +1.00157579"},
        {"Smithsonian Astrophysical Observation", "SAO 30349"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.11345422),
        dec: Angle.Degrees(+59.19894280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87045"},
        {"Hipparcos Number", "HIP 49340"},
        {"Smithsonian Astrophysical Observation", "SAO 27500"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.09198111),
        dec: Angle.Degrees(+59.20364564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102282"},
        {"Hipparcos Number", "HIP 57446"},
        {"Geneva Identification System", "GEN# +1.00102282"},
        {"Smithsonian Astrophysical Observation", "SAO 28138"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.64445074),
        dec: Angle.Degrees(+59.20909452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15728"},
        {"Hipparcos Number", "HIP 11932"},
        {"Smithsonian Astrophysical Observation", "SAO 23430"},
        {"Wilson Evans Batten Catalogue", "WEB 2468"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.49435176),
        dec: Angle.Degrees(+59.21216442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196707"},
        {"Hipparcos Number", "HIP 101646"},
        {"Smithsonian Astrophysical Observation", "SAO 32729"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.06754370),
        dec: Angle.Degrees(+59.21310119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42721"},
        {"Hipparcos Number", "HIP 29763"},
        {"Geneva Identification System", "GEN# +1.00042721"},
        {"Smithsonian Astrophysical Observation", "SAO 25636"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.01662991),
        dec: Angle.Degrees(+59.21510140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96656"},
        {"Hipparcos Number", "HIP 54495"},
        {"Geneva Identification System", "GEN# +1.00096656"},
        {"Smithsonian Astrophysical Observation", "SAO 27923"},
        {"Wilson Evans Batten Catalogue", "WEB 9838"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.23989888),
        dec: Angle.Degrees(+59.21528387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109837"},
        {"Hipparcos Number", "HIP 61598"},
        {"Smithsonian Astrophysical Observation", "SAO 28452"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.33513523),
        dec: Angle.Degrees(+59.21674160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68683"},
        {"Hipparcos Number", "HIP 40535"},
        {"Smithsonian Astrophysical Observation", "SAO 26746"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.14595825),
        dec: Angle.Degrees(+59.22822234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9408"},
        {"Hipparcos Number", "HIP 7294"},
        {"Geneva Identification System", "GEN# +1.00009408"},
        {"Smithsonian Astrophysical Observation", "SAO 22397"},
        {"Wilson Evans Batten Catalogue", "WEB 1572"},
    },
    visualMagnitude: 4.68,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.48302496),
        dec: Angle.Degrees(+59.23209665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237471"},
        {"Hipparcos Number", "HIP 29584"},
        {"Smithsonian Astrophysical Observation", "SAO 25626"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.50636738),
        dec: Angle.Degrees(+59.23406602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6831",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6831"},
        {"Geneva Identification System", "GEN# +0.05800241"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.97865301),
        dec: Angle.Degrees(+59.23581166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17401"},
        {"Hipparcos Number", "HIP 13205"},
        {"Smithsonian Astrophysical Observation", "SAO 23641"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.48758418),
        dec: Angle.Degrees(+59.24008234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22303",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3436 A"},
        {"Henry Draper", "HD 30110"},
        {"Hipparcos Number", "HIP 22303"},
        {"Geneva Identification System", "GEN# +1.00030110"},
        {"Renson", "Renson 7750"},
        {"Smithsonian Astrophysical Observation", "SAO 24831"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.05164716),
        dec: Angle.Degrees(+59.24100265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236976"},
        {"Hipparcos Number", "HIP 12254"},
        {"Smithsonian Astrophysical Observation", "SAO 23479"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.44948046),
        dec: Angle.Degrees(+59.24207892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113392"},
        {"Hipparcos Number", "HIP 63625"},
        {"Geneva Identification System", "GEN# +1.00113392"},
        {"Smithsonian Astrophysical Observation", "SAO 28609"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.60047829),
        dec: Angle.Degrees(+59.24596100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212897"},
        {"Hipparcos Number", "HIP 110730"},
        {"Geneva Identification System", "GEN# +1.00212897"},
        {"Smithsonian Astrophysical Observation", "SAO 34448"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.51132855),
        dec: Angle.Degrees(+59.24706520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14346"},
        {"Hipparcos Number", "HIP 10969"},
        {"Smithsonian Astrophysical Observation", "SAO 23225"},
        {"Wilson Evans Batten Catalogue", "WEB 2306"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.31444136),
        dec: Angle.Degrees(+59.24794465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66286"},
        {"Hipparcos Number", "HIP 39639"},
        {"Geneva Identification System", "GEN# +1.00066286"},
        {"Smithsonian Astrophysical Observation", "SAO 26662"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.51060932),
        dec: Angle.Degrees(+59.24873620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56243"},
        {"Hipparcos Number", "HIP 35517"},
        {"Smithsonian Astrophysical Observation", "SAO 26274"},
        {"Wilson Evans Batten Catalogue", "WEB 7083"},
    },
    visualMagnitude: 6.75,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.97017445),
        dec: Angle.Degrees(+59.25293915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162363"},
        {"Hipparcos Number", "HIP 87036"},
        {"Smithsonian Astrophysical Observation", "SAO 30576"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.75426242),
        dec: Angle.Degrees(+59.25339500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 76.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238914"},
        {"Hipparcos Number", "HIP 91388"},
        {"Smithsonian Astrophysical Observation", "SAO 31085"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.58425946),
        dec: Angle.Degrees(+59.25384699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78364"},
        {"Hipparcos Number", "HIP 45040"},
        {"Geneva Identification System", "GEN# +1.00078364"},
        {"Smithsonian Astrophysical Observation", "SAO 27150"},
        {"Wilson Evans Batten Catalogue", "WEB 8598"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.60644472),
        dec: Angle.Degrees(+59.25464484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236427"},
        {"Hipparcos Number", "HIP 2339"},
        {"Smithsonian Astrophysical Observation", "SAO 21443"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.883,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.47524520),
        dec: Angle.Degrees(+59.25503629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76643"},
        {"Hipparcos Number", "HIP 44198"},
        {"Geneva Identification System", "GEN# +1.00076643"},
        {"Smithsonian Astrophysical Observation", "SAO 27074"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.04951022),
        dec: Angle.Degrees(+59.25714534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9057",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9057"},
        {"Wilson Evans Batten Catalogue", "WEB 1900"},
    },
    visualMagnitude: 9.74,
    bvColour: 2.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.15871252),
        dec: Angle.Degrees(+59.25937724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34804",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34804"},
        {"Wilson Evans Batten Catalogue", "WEB 6958"},
    },
    visualMagnitude: 10.67,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.07133080),
        dec: Angle.Degrees(+59.26516932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -302.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236915"},
        {"Hipparcos Number", "HIP 9211"},
        {"Geneva Identification System", "GEN# +1.00236915"},
        {"Smithsonian Astrophysical Observation", "SAO 22801"},
    },
    visualMagnitude: 8.47,
    bvColour: 2.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.62046939),
        dec: Angle.Degrees(+59.26910729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78184",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78184"},
    },
    visualMagnitude: 10.31,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.45817148),
        dec: Angle.Degrees(+59.27053295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -296.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 203.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206842"},
        {"Hipparcos Number", "HIP 107197"},
        {"Geneva Identification System", "GEN# +1.00206842"},
        {"Smithsonian Astrophysical Observation", "SAO 33683"},
        {"Wilson Evans Batten Catalogue", "WEB 19363"},
    },
    visualMagnitude: 6.10,
    bvColour: 1.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.68905006),
        dec: Angle.Degrees(+59.27084085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11606"},
        {"Hipparcos Number", "HIP 8980"},
        {"Celescope Catalog", "CEL 181"},
        {"Geneva Identification System", "GEN# +1.00011606"},
        {"Smithsonian Astrophysical Observation", "SAO 22753"},
        {"Wilson Evans Batten Catalogue", "WEB 1883"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.92855399),
        dec: Angle.Degrees(+59.27345434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34575"},
        {"Hipparcos Number", "HIP 25094"},
        {"Cincinnati Publication", "Ci 18 679"},
        {"Geneva Identification System", "GEN# +1.00034575"},
        {"Smithsonian Astrophysical Observation", "SAO 25144"},
        {"Wilson Evans Batten Catalogue", "WEB 4863"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.58127514),
        dec: Angle.Degrees(+59.27860298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 225.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -284.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94880"},
        {"Hipparcos Number", "HIP 53634"},
        {"Geneva Identification System", "GEN# +1.00094880"},
        {"Smithsonian Astrophysical Observation", "SAO 27853"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.58967116),
        dec: Angle.Degrees(+59.28164215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17114"},
        {"Hipparcos Number", "HIP 13016"},
        {"Geneva Identification System", "GEN# +1.00017114"},
        {"Smithsonian Astrophysical Observation", "SAO 23605"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.84304253),
        dec: Angle.Degrees(+59.28638550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145887"},
        {"Hipparcos Number", "HIP 79226"},
        {"Smithsonian Astrophysical Observation", "SAO 29829"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.52923776),
        dec: Angle.Degrees(+59.28645006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6027"},
        {"Hipparcos Number", "HIP 4871"},
        {"Smithsonian Astrophysical Observation", "SAO 21942"},
        {"Wilson Evans Batten Catalogue", "WEB 946"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.65480613),
        dec: Angle.Degrees(+59.28681145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61657"},
        {"Hipparcos Number", "HIP 37673"},
        {"Geneva Identification System", "GEN# +1.00061657"},
        {"Smithsonian Astrophysical Observation", "SAO 26483"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.94350273),
        dec: Angle.Degrees(+59.28907329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93775",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12055"},
        {"Henry Draper", "HD 178634"},
        {"Hipparcos Number", "HIP 93775"},
        {"Smithsonian Astrophysical Observation", "SAO 31384"},
        {"Wilson Evans Batten Catalogue", "WEB 16299"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.45847986),
        dec: Angle.Degrees(+59.29199044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5890",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1007 AB"},
        {"Henry Draper", "HD 7432"},
        {"Hipparcos Number", "HIP 5890"},
        {"Geneva Identification System", "GEN# +1.00007432"},
        {"Smithsonian Astrophysical Observation", "SAO 22132"},
        {"Wilson Evans Batten Catalogue", "WEB 1339"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.91997928),
        dec: Angle.Degrees(+59.29212326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131507"},
        {"Hipparcos Number", "HIP 72664"},
        {"Fundamental Katalog 5th Edition", "FK5 549"},
        {"Geneva Identification System", "GEN# +1.00131507"},
        {"Smithsonian Astrophysical Observation", "SAO 29315"},
        {"Wilson Evans Batten Catalogue", "WEB 12493"},
    },
    visualMagnitude: 5.48,
    bvColour: 1.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.86072795),
        dec: Angle.Degrees(+59.29365246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 136.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239676"},
        {"Hipparcos Number", "HIP 105960"},
        {"Geneva Identification System", "GEN# +1.00239676"},
        {"Smithsonian Astrophysical Observation", "SAO 33444"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.88586936),
        dec: Angle.Degrees(+59.29468609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115268"},
        {"Hipparcos Number", "HIP 64636"},
        {"Geneva Identification System", "GEN# +1.00115268"},
        {"Smithsonian Astrophysical Observation", "SAO 28690"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.72718442),
        dec: Angle.Degrees(+59.29560004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9869"},
        {"Hipparcos Number", "HIP 7605"},
        {"Smithsonian Astrophysical Observation", "SAO 22453"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.48813502),
        dec: Angle.Degrees(+59.29901849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84495"},
        {"Hipparcos Number", "HIP 48056"},
        {"Smithsonian Astrophysical Observation", "SAO 27381"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.94565235),
        dec: Angle.Degrees(+59.29921464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211093"},
        {"Hipparcos Number", "HIP 109692"},
        {"Geneva Identification System", "GEN# +1.00211093"},
        {"Smithsonian Astrophysical Observation", "SAO 34190"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.29111904),
        dec: Angle.Degrees(+59.29934144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125706"},
        {"Hipparcos Number", "HIP 69979"},
        {"Geneva Identification System", "GEN# +1.00125706"},
        {"Smithsonian Astrophysical Observation", "SAO 29100"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.78849142),
        dec: Angle.Degrees(+59.30199899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43607",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43607"},
    },
    visualMagnitude: 10.54,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.21771592),
        dec: Angle.Degrees(+59.30320320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90181"},
        {"Hipparcos Number", "HIP 51079"},
        {"Smithsonian Astrophysical Observation", "SAO 27640"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.54672740),
        dec: Angle.Degrees(+59.30539870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103130",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14412 AB"},
        {"Henry Draper", "HD 199306"},
        {"Henry Draper 2", "HD 199307"},
        {"Hipparcos Number", "HIP 103130"},
        {"Smithsonian Astrophysical Observation", "SAO 32976"},
        {"Wilson Evans Batten Catalogue", "WEB 18729"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.42210439),
        dec: Angle.Degrees(+59.30769640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14161"},
        {"Hipparcos Number", "HIP 10844"},
        {"Geneva Identification System", "GEN# +4.31020162"},
        {"Smithsonian Astrophysical Observation", "SAO 23191"},
        {"Wilson Evans Batten Catalogue", "WEB 2287"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.89571057),
        dec: Angle.Degrees(+59.30827223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152773"},
        {"Hipparcos Number", "HIP 82508"},
        {"Geneva Identification System", "GEN# +1.00152773"},
        {"Smithsonian Astrophysical Observation", "SAO 30133"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.849,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.95270810),
        dec: Angle.Degrees(+59.31044944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141398"},
        {"Hipparcos Number", "HIP 77200"},
        {"Geneva Identification System", "GEN# +1.00141398"},
        {"Smithsonian Astrophysical Observation", "SAO 29651"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.44950400),
        dec: Angle.Degrees(+59.31224310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236469"},
        {"Hipparcos Number", "HIP 2768"},
        {"Geneva Identification System", "GEN# +1.00236469"},
        {"Smithsonian Astrophysical Observation", "SAO 21536"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.887,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.82087362),
        dec: Angle.Degrees(+59.31228155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239020"},
        {"Hipparcos Number", "HIP 94439"},
        {"Smithsonian Astrophysical Observation", "SAO 31489"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.31499403),
        dec: Angle.Degrees(+59.31395674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238683"},
        {"Hipparcos Number", "HIP 85070"},
        {"Smithsonian Astrophysical Observation", "SAO 30365"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.78836554),
        dec: Angle.Degrees(+59.31810304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93875"},
        {"Hipparcos Number", "HIP 53064"},
        {"Fundamental Katalog 5th Edition", "FK5 2865"},
        {"Geneva Identification System", "GEN# +1.00093875"},
        {"Smithsonian Astrophysical Observation", "SAO 27793"},
        {"Wilson Evans Batten Catalogue", "WEB 9644"},
    },
    visualMagnitude: 5.57,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.84899001),
        dec: Angle.Degrees(+59.32024369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92153",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11697 AB"},
        {"Henry Draper", "HD 174455"},
        {"Hipparcos Number", "HIP 92153"},
        {"Smithsonian Astrophysical Observation", "SAO 31171"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.73552680),
        dec: Angle.Degrees(+59.33096969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114365",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16556 A"},
        {"Henry Draper", "HD 218753"},
        {"Hipparcos Number", "HIP 114365"},
        {"Celescope Catalog", "CEL 5570"},
        {"Geneva Identification System", "GEN# +1.00218753"},
        {"Renson", "Renson 60195"},
        {"Smithsonian Astrophysical Observation", "SAO 35186"},
        {"Wilson Evans Batten Catalogue", "WEB 20304"},
    },
    visualMagnitude: 5.68,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.43391042),
        dec: Angle.Degrees(+59.33268922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23813",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3673 AB"},
        {"Henry Draper", "HD 32478"},
        {"Hipparcos Number", "HIP 23813"},
        {"Geneva Identification System", "GEN# +1.00032478J"},
        {"Smithsonian Astrophysical Observation", "SAO 25015"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.76825418),
        dec: Angle.Degrees(+59.33299655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123977"},
        {"Hipparcos Number", "HIP 69107"},
        {"Fundamental Katalog 5th Edition", "FK5 3126"},
        {"Geneva Identification System", "GEN# +1.00123977"},
        {"Smithsonian Astrophysical Observation", "SAO 29019"},
        {"Wilson Evans Batten Catalogue", "WEB 12065"},
    },
    visualMagnitude: 6.47,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.19244711),
        dec: Angle.Degrees(+59.33769923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -123.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8396",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8396"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.08206400),
        dec: Angle.Degrees(+59.34207879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92320"},
        {"Hipparcos Number", "HIP 52278"},
        {"Geneva Identification System", "GEN# +1.00092320"},
        {"Smithsonian Astrophysical Observation", "SAO 27730"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.23723572),
        dec: Angle.Degrees(+59.34281425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77692"},
        {"Hipparcos Number", "HIP 44717"},
        {"Fundamental Katalog 5th Edition", "FK5 2716"},
        {"Geneva Identification System", "GEN# +1.00077692"},
        {"Smithsonian Astrophysical Observation", "SAO 27121"},
        {"Wilson Evans Batten Catalogue", "WEB 8552"},
    },
    visualMagnitude: 6.44,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.67982863),
        dec: Angle.Degrees(+59.34455497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239854"},
        {"Hipparcos Number", "HIP 109143"},
        {"Smithsonian Astrophysical Observation", "SAO 34066"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.62792986),
        dec: Angle.Degrees(+59.34737606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140553"},
        {"Hipparcos Number", "HIP 76830"},
        {"Smithsonian Astrophysical Observation", "SAO 29624"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.30690913),
        dec: Angle.Degrees(+59.34781625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111560"},
        {"Hipparcos Number", "HIP 62578"},
        {"Smithsonian Astrophysical Observation", "SAO 28528"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.32960696),
        dec: Angle.Degrees(+59.35199125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104289"},
        {"Hipparcos Number", "HIP 58572"},
        {"Geneva Identification System", "GEN# +1.00104289"},
        {"Smithsonian Astrophysical Observation", "SAO 28219"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.17186355),
        dec: Angle.Degrees(+59.35310145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19341"},
        {"Hipparcos Number", "HIP 14658"},
        {"Geneva Identification System", "GEN# +1.00019341"},
        {"Smithsonian Astrophysical Observation", "SAO 23837"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.34437927),
        dec: Angle.Degrees(+59.35749448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67030",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9009 AB"},
        {"Henry Draper", "HD 119864"},
        {"Hipparcos Number", "HIP 67030"},
        {"Smithsonian Astrophysical Observation", "SAO 28874"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.05129708),
        dec: Angle.Degrees(+59.35799131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88736"},
        {"Hipparcos Number", "HIP 50270"},
        {"Geneva Identification System", "GEN# +1.00088736"},
        {"Smithsonian Astrophysical Observation", "SAO 27579"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.96412514),
        dec: Angle.Degrees(+59.35812940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238428"},
        {"Hipparcos Number", "HIP 74153"},
        {"Smithsonian Astrophysical Observation", "SAO 29426"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.27402506),
        dec: Angle.Degrees(+59.36046993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36806"},
        {"Hipparcos Number", "HIP 26485"},
        {"Smithsonian Astrophysical Observation", "SAO 25281"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.50298772),
        dec: Angle.Degrees(+59.36445321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16303",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2563 AB"},
        {"Henry Draper", "HD 21427"},
        {"Hipparcos Number", "HIP 16303"},
        {"Geneva Identification System", "GEN# +1.00021427"},
        {"Smithsonian Astrophysical Observation", "SAO 24062"},
        {"Wilson Evans Batten Catalogue", "WEB 3110"},
    },
    visualMagnitude: 6.14,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.54554846),
        dec: Angle.Degrees(+59.36606884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21492",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21492"},
    },
    visualMagnitude: 12.35,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.24295431),
        dec: Angle.Degrees(+59.36696523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 124.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -139.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54012"},
        {"Hipparcos Number", "HIP 34681"},
        {"Smithsonian Astrophysical Observation", "SAO 26193"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.73452411),
        dec: Angle.Degrees(+59.36975421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22439"},
        {"Hipparcos Number", "HIP 17083"},
        {"Geneva Identification System", "GEN# +1.00022439"},
        {"Smithsonian Astrophysical Observation", "SAO 24141"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.90495230),
        dec: Angle.Degrees(+59.37010424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30272",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4950 AB"},
        {"Henry Draper", "HD 43812"},
        {"Hipparcos Number", "HIP 30272"},
        {"Smithsonian Astrophysical Observation", "SAO 25678"},
        {"Wilson Evans Batten Catalogue", "WEB 6019"},
    },
    visualMagnitude: 6.05,
    bvColour: 0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.51482583),
        dec: Angle.Degrees(+59.37209783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219287"},
        {"Hipparcos Number", "HIP 114695"},
        {"Celescope Catalog", "CEL 5583"},
        {"Geneva Identification System", "GEN# +1.00219287"},
        {"Smithsonian Astrophysical Observation", "SAO 35248"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.51469759),
        dec: Angle.Degrees(+59.37473246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88851"},
        {"Hipparcos Number", "HIP 50330"},
        {"Smithsonian Astrophysical Observation", "SAO 27585"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.16680937),
        dec: Angle.Degrees(+59.37909999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73105",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9450 AB"},
        {"Henry Draper", "HD 132422"},
        {"Hipparcos Number", "HIP 73105"},
        {"Smithsonian Astrophysical Observation", "SAO 29346"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.12344679),
        dec: Angle.Degrees(+59.37991155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20906",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20906"},
        {"Smithsonian Astrophysical Observation", "SAO 24636"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.21837143),
        dec: Angle.Degrees(+59.38622106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92512",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11779 A"},
        {"Henry Draper", "HD 175306"},
        {"Hipparcos Number", "HIP 92512"},
        {"Fundamental Katalog 5th Edition", "FK5 707"},
        {"Geneva Identification System", "GEN# +1.00175306"},
        {"Smithsonian Astrophysical Observation", "SAO 31219"},
        {"Smithsonian Astrophysical Observation 2", "SAO 31218"},
        {"Wilson Evans Batten Catalogue", "WEB 15998"},
    },
    visualMagnitude: 4.63,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.80002755),
        dec: Angle.Degrees(+59.38828895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236546"},
        {"Hipparcos Number", "HIP 3907"},
        {"Smithsonian Astrophysical Observation", "SAO 21751"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.53084012),
        dec: Angle.Degrees(+59.38838857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44808"},
        {"Hipparcos Number", "HIP 30742"},
        {"Geneva Identification System", "GEN# +1.00044808"},
        {"Smithsonian Astrophysical Observation", "SAO 25735"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.90059735),
        dec: Angle.Degrees(+59.39028995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116684",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116684"},
    },
    visualMagnitude: 11.24,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.70165825),
        dec: Angle.Degrees(+59.39183144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40827"},
        {"Hipparcos Number", "HIP 28829"},
        {"Geneva Identification System", "GEN# +1.00040827"},
        {"Smithsonian Astrophysical Observation", "SAO 25551"},
        {"Wilson Evans Batten Catalogue", "WEB 5639"},
    },
    visualMagnitude: 6.32,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.28427311),
        dec: Angle.Degrees(+59.39333079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39723"},
        {"Hipparcos Number", "HIP 28245"},
        {"Smithsonian Astrophysical Observation", "SAO 25488"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.53122191),
        dec: Angle.Degrees(+59.39358959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13591"},
        {"Hipparcos Number", "HIP 10452"},
        {"Geneva Identification System", "GEN# +4.31020074"},
        {"Smithsonian Astrophysical Observation", "SAO 23066"},
        {"Wilson Evans Batten Catalogue", "WEB 2188"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.67580214),
        dec: Angle.Degrees(+59.39473495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184903"},
        {"Hipparcos Number", "HIP 96163"},
        {"Geneva Identification System", "GEN# +1.00184903"},
        {"Renson", "Renson 50990"},
        {"Smithsonian Astrophysical Observation", "SAO 31771"},
    },
    visualMagnitude: 7.81,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.28782877),
        dec: Angle.Degrees(+59.39602382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236953"},
        {"Hipparcos Number", "HIP 10307"},
        {"Smithsonian Astrophysical Observation", "SAO 23028"},
    },
    visualMagnitude: 9.83,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.20654636),
        dec: Angle.Degrees(+59.39849016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88530"},
        {"Hipparcos Number", "HIP 50167"},
        {"Smithsonian Astrophysical Observation", "SAO 27571"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.60272092),
        dec: Angle.Degrees(+59.39974710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28793"},
        {"Hipparcos Number", "HIP 21410"},
        {"Smithsonian Astrophysical Observation", "SAO 24702"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.93139575),
        dec: Angle.Degrees(+59.40084643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70856"},
        {"Hipparcos Number", "HIP 41461"},
        {"Smithsonian Astrophysical Observation", "SAO 26838"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.85718462),
        dec: Angle.Degrees(+59.40220036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33618"},
        {"Hipparcos Number", "HIP 24479"},
        {"Geneva Identification System", "GEN# +1.00033618"},
        {"Smithsonian Astrophysical Observation", "SAO 25088"},
        {"Wilson Evans Batten Catalogue", "WEB 4741"},
    },
    visualMagnitude: 6.15,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.79741331),
        dec: Angle.Degrees(+59.40571797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113019"},
        {"Hipparcos Number", "HIP 63431"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.97846938),
        dec: Angle.Degrees(+59.40733696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144542"},
        {"Hipparcos Number", "HIP 78632"},
        {"Geneva Identification System", "GEN# +1.00144542"},
        {"Smithsonian Astrophysical Observation", "SAO 29777"},
        {"Wilson Evans Batten Catalogue", "WEB 13291"},
    },
    visualMagnitude: 6.19,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.78902902),
        dec: Angle.Degrees(+59.41081205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236496"},
        {"Hipparcos Number", "HIP 3250"},
        {"Smithsonian Astrophysical Observation", "SAO 21624"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.771,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.35041592),
        dec: Angle.Degrees(+59.41140497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58828"},
        {"Hipparcos Number", "HIP 36525"},
        {"Smithsonian Astrophysical Observation", "SAO 26378"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.71017233),
        dec: Angle.Degrees(+59.41295373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210839"},
        {"Hipparcos Number", "HIP 109556"},
        {"Celescope Catalog", "CEL 5453"},
        {"Geneva Identification System", "GEN# +1.00210839"},
        {"Smithsonian Astrophysical Observation", "SAO 34149"},
        {"Wilson Evans Batten Catalogue", "WEB 19682"},
    },
    visualMagnitude: 5.05,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.87743467),
        dec: Angle.Degrees(+59.41451451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224150"},
        {"Hipparcos Number", "HIP 117955"},
        {"Smithsonian Astrophysical Observation", "SAO 35898"},
        {"Wilson Evans Batten Catalogue", "WEB 20742"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.88604325),
        dec: Angle.Degrees(+59.41552515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76921"},
        {"Hipparcos Number", "HIP 44345"},
        {"Geneva Identification System", "GEN# +1.00076921"},
        {"Smithsonian Astrophysical Observation", "SAO 27089"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.47329131),
        dec: Angle.Degrees(+59.41628059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21742"},
        {"Hipparcos Number", "HIP 16581"},
        {"Smithsonian Astrophysical Observation", "SAO 24091"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.871,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.36098964),
        dec: Angle.Degrees(+59.41750910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 161.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -307.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205113"},
        {"Hipparcos Number", "HIP 106230"},
        {"Smithsonian Astrophysical Observation", "SAO 33495"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.75498966),
        dec: Angle.Degrees(+59.41806489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 137.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218376"},
        {"Hipparcos Number", "HIP 114104"},
        {"Geneva Identification System", "GEN# +1.00218376"},
        {"Smithsonian Astrophysical Observation", "SAO 35147"},
        {"Wilson Evans Batten Catalogue", "WEB 20263"},
    },
    visualMagnitude: 4.84,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.65337433),
        dec: Angle.Degrees(+59.41976474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171566"},
        {"Hipparcos Number", "HIP 90837"},
        {"Geneva Identification System", "GEN# +1.00171566"},
        {"Smithsonian Astrophysical Observation", "SAO 31034"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.97667812),
        dec: Angle.Degrees(+59.42001858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223847"},
        {"Hipparcos Number", "HIP 117772"},
        {"Geneva Identification System", "GEN# +1.00223847"},
        {"Smithsonian Astrophysical Observation", "SAO 35860"},
        {"Wilson Evans Batten Catalogue", "WEB 20724"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.25970691),
        dec: Angle.Degrees(+59.42161132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187748"},
        {"Hipparcos Number", "HIP 97438"},
        {"Geneva Identification System", "GEN# +1.00187748"},
        {"Smithsonian Astrophysical Observation", "SAO 32016"},
        {"Wilson Evans Batten Catalogue", "WEB 17124"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.06429046),
        dec: Angle.Degrees(+59.42261842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 116.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13379"},
        {"Hipparcos Number", "HIP 10316"},
        {"Geneva Identification System", "GEN# +4.31020028"},
        {"Smithsonian Astrophysical Observation", "SAO 23029"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.22310637),
        dec: Angle.Degrees(+59.42805021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183471"},
        {"Hipparcos Number", "HIP 95566"},
        {"Geneva Identification System", "GEN# +1.00183471"},
        {"Smithsonian Astrophysical Observation", "SAO 31662"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.58824561),
        dec: Angle.Degrees(+59.42827458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238494"},
        {"Hipparcos Number", "HIP 76721"},
        {"Smithsonian Astrophysical Observation", "SAO 29613"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.00590001),
        dec: Angle.Degrees(+59.43240744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20959"},
        {"Hipparcos Number", "HIP 15981"},
        {"Geneva Identification System", "GEN# +1.00020959"},
        {"Smithsonian Astrophysical Observation", "SAO 24021"},
        {"Wilson Evans Batten Catalogue", "WEB 3051"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.44988534),
        dec: Angle.Degrees(+59.43246314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95117",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95117"},
    },
    visualMagnitude: 10.89,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.25468293),
        dec: Angle.Degrees(+59.43322215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239787"},
        {"Hipparcos Number", "HIP 107978"},
        {"Smithsonian Astrophysical Observation", "SAO 33830"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.12863272),
        dec: Angle.Degrees(+59.43668046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200205"},
        {"Hipparcos Number", "HIP 103598"},
        {"Fundamental Katalog 5th Edition", "FK5 3676"},
        {"Geneva Identification System", "GEN# +1.00200205"},
        {"Smithsonian Astrophysical Observation", "SAO 33048"},
        {"Wilson Evans Batten Catalogue", "WEB 18848"},
    },
    visualMagnitude: 5.54,
    bvColour: 1.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.85555250),
        dec: Angle.Degrees(+59.43855678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85816"},
        {"Hipparcos Number", "HIP 48733"},
        {"Smithsonian Astrophysical Observation", "SAO 27433"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.09510556),
        dec: Angle.Degrees(+59.43927387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201344"},
        {"Hipparcos Number", "HIP 104176"},
        {"Smithsonian Astrophysical Observation", "SAO 33139"},
        {"Wilson Evans Batten Catalogue", "WEB 18976"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.60532264),
        dec: Angle.Degrees(+59.43928584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1128"},
        {"Hipparcos Number", "HIP 1259"},
        {"Celescope Catalog", "CEL 47"},
        {"Geneva Identification System", "GEN# +1.00001128"},
        {"Smithsonian Astrophysical Observation", "SAO 21256"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.95249176),
        dec: Angle.Degrees(+59.44026730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32438",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5400 AB"},
        {"Henry Draper", "HD 48250"},
        {"Hipparcos Number", "HIP 32438"},
        {"Geneva Identification System", "GEN# +1.00048250"},
        {"Smithsonian Astrophysical Observation", "SAO 25939"},
        {"Wilson Evans Batten Catalogue", "WEB 6539"},
    },
    visualMagnitude: 4.86,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.55896951),
        dec: Angle.Degrees(+59.44169108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31722",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31722"},
    },
    visualMagnitude: 10.78,
    bvColour: 0.795,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.53924749),
        dec: Angle.Degrees(+59.44209697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240059"},
        {"Hipparcos Number", "HIP 112430"},
        {"Geneva Identification System", "GEN# +1.00240059"},
        {"Smithsonian Astrophysical Observation", "SAO 34795"},
    },
    visualMagnitude: 9.59,
    bvColour: 1.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.60323173),
        dec: Angle.Degrees(+59.44220805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108111",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15436 A"},
        {"Henry Draper", "HD 239795"},
        {"Hipparcos Number", "HIP 108111"},
        {"Smithsonian Astrophysical Observation", "SAO 33854"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.55951278),
        dec: Angle.Degrees(+59.44247675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108115",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15436 B"},
        {"Hipparcos Number", "HIP 108115"},
    },
    visualMagnitude: 11.77,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.56640878),
        dec: Angle.Degrees(+59.44333074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177930"},
        {"Hipparcos Number", "HIP 93541"},
        {"Smithsonian Astrophysical Observation", "SAO 31352"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.77693967),
        dec: Angle.Degrees(+59.44489197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22427"},
        {"Hipparcos Number", "HIP 17075"},
        {"Geneva Identification System", "GEN# +1.00022427"},
        {"Smithsonian Astrophysical Observation", "SAO 24140"},
        {"Wilson Evans Batten Catalogue", "WEB 3243"},
    },
    visualMagnitude: 6.90,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.88600932),
        dec: Angle.Degrees(+59.44542159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146134"},
        {"Hipparcos Number", "HIP 79325"},
        {"Geneva Identification System", "GEN# +1.00146134"},
        {"Smithsonian Astrophysical Observation", "SAO 29840"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.84101322),
        dec: Angle.Degrees(+59.44803109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26251"},
        {"Hipparcos Number", "HIP 19645"},
        {"Smithsonian Astrophysical Observation", "SAO 24462"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.13758265),
        dec: Angle.Degrees(+59.44827370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33048",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5514 AB"},
        {"Henry Draper", "HD 49618"},
        {"Henry Draper 2", "HD 49619"},
        {"Hipparcos Number", "HIP 33048"},
        {"Geneva Identification System", "GEN# +1.00049618"},
        {"Smithsonian Astrophysical Observation", "SAO 26012"},
        {"Wilson Evans Batten Catalogue", "WEB 6653"},
    },
    visualMagnitude: 5.34,
    bvColour: 0.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.27109036),
        dec: Angle.Degrees(+59.44865494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32320",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5368 AB"},
        {"Henry Draper", "HD 47977"},
        {"Hipparcos Number", "HIP 32320"},
        {"Smithsonian Astrophysical Observation", "SAO 25925"},
        {"Wilson Evans Batten Catalogue", "WEB 6520"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.21513015),
        dec: Angle.Degrees(+59.44925274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46607"},
        {"Hipparcos Number", "HIP 31720"},
        {"Geneva Identification System", "GEN# +1.00046607"},
        {"Smithsonian Astrophysical Observation", "SAO 25844"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.52894592),
        dec: Angle.Degrees(+59.44942259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9666"},
        {"Hipparcos Number", "HIP 7475"},
        {"Geneva Identification System", "GEN# +1.00009666"},
        {"Geneva Identification System 2", "GEN# +6.91501208"},
        {"Smithsonian Astrophysical Observation", "SAO 22426"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.06774816),
        dec: Angle.Degrees(+59.45937565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11420",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11420"},
        {"Geneva Identification System", "GEN# +0.05800470"},
        {"Wilson Evans Batten Catalogue", "WEB 2384"},
    },
    visualMagnitude: 9.94,
    bvColour: 1.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.80736070),
        dec: Angle.Degrees(+59.46060551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221393"},
        {"Hipparcos Number", "HIP 116089"},
        {"Geneva Identification System", "GEN# +1.00221393"},
        {"Smithsonian Astrophysical Observation", "SAO 35503"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.84902058),
        dec: Angle.Degrees(+59.46243823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239327"},
        {"Hipparcos Number", "HIP 99064"},
        {"Smithsonian Astrophysical Observation", "SAO 32295"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.67929668),
        dec: Angle.Degrees(+59.46408892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205570"},
        {"Hipparcos Number", "HIP 106478"},
        {"Geneva Identification System", "GEN# +1.00205570"},
        {"Smithsonian Astrophysical Observation", "SAO 33536"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.48537598),
        dec: Angle.Degrees(+59.46421897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3681"},
        {"Hipparcos Number", "HIP 3166"},
        {"Geneva Identification System", "GEN# +1.00003681"},
        {"Smithsonian Astrophysical Observation", "SAO 21604"},
        {"Wilson Evans Batten Catalogue", "WEB 564"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.08336741),
        dec: Angle.Degrees(+59.46431559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237377"},
        {"Hipparcos Number", "HIP 25109"},
        {"Smithsonian Astrophysical Observation", "SAO 25148"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.854,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.63961651),
        dec: Angle.Degrees(+59.46508764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2506"},
        {"Hipparcos Number", "HIP 2289"},
        {"Geneva Identification System", "GEN# +1.00002506"},
        {"Smithsonian Astrophysical Observation", "SAO 21431"},
        {"Wilson Evans Batten Catalogue", "WEB 423"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.30959327),
        dec: Angle.Degrees(+59.46946689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60968",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60968"},
    },
    visualMagnitude: 10.46,
    bvColour: 0.718,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.47127079),
        dec: Angle.Degrees(+59.47264528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219854"},
        {"Hipparcos Number", "HIP 115070"},
        {"Geneva Identification System", "GEN# +1.00219854"},
        {"Smithsonian Astrophysical Observation", "SAO 35313"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.60221029),
        dec: Angle.Degrees(+59.47795890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28578"},
        {"Hipparcos Number", "HIP 21260"},
        {"Geneva Identification System", "GEN# +1.00028578"},
        {"Smithsonian Astrophysical Observation", "SAO 24683"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.41851539),
        dec: Angle.Degrees(+59.47813297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11480",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11480"},
    },
    visualMagnitude: 10.80,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.02080375),
        dec: Angle.Degrees(+59.47925009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12992",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12992"},
    },
    visualMagnitude: 11.62,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.76570549),
        dec: Angle.Degrees(+59.48056509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51417"},
        {"Hipparcos Number", "HIP 33790"},
        {"Smithsonian Astrophysical Observation", "SAO 26091"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.24828708),
        dec: Angle.Degrees(+59.48288842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238602"},
        {"Hipparcos Number", "HIP 81866"},
    },
    visualMagnitude: 10.05,
    bvColour: 1.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.81519067),
        dec: Angle.Degrees(+59.48314427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77353",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9794 AB"},
        {"Henry Draper", "HD 141730"},
        {"Hipparcos Number", "HIP 77353"},
        {"Smithsonian Astrophysical Observation", "SAO 29670"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.85849477),
        dec: Angle.Degrees(+59.48569046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109729"},
        {"Hipparcos Number", "HIP 61532"},
        {"Geneva Identification System", "GEN# +1.00109729"},
        {"Smithsonian Astrophysical Observation", "SAO 28444"},
        {"Wilson Evans Batten Catalogue", "WEB 10951"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.09784542),
        dec: Angle.Degrees(+59.48695691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101440",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14019 A"},
        {"Henry Draper", "HD 196294"},
        {"Hipparcos Number", "HIP 101440"},
        {"Smithsonian Astrophysical Observation", "SAO 32695"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.36690296),
        dec: Angle.Degrees(+59.48936889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121954"},
        {"Hipparcos Number", "HIP 68130"},
        {"Smithsonian Astrophysical Observation", "SAO 28943"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.20998124),
        dec: Angle.Degrees(+59.49252346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213730"},
        {"Hipparcos Number", "HIP 111241"},
        {"Geneva Identification System", "GEN# +1.00213730"},
        {"Smithsonian Astrophysical Observation", "SAO 34558"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.06693585),
        dec: Angle.Degrees(+59.49324829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 203.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30134"},
        {"Hipparcos Number", "HIP 22321"},
        {"Smithsonian Astrophysical Observation", "SAO 24837"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.748,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.12272729),
        dec: Angle.Degrees(+59.49791744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63385"},
        {"Hipparcos Number", "HIP 38404"},
        {"Smithsonian Astrophysical Observation", "SAO 26539"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.01636869),
        dec: Angle.Degrees(+59.50070518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239828"},
        {"Hipparcos Number", "HIP 108714"},
        {"Geneva Identification System", "GEN# +1.00239828"},
        {"Smithsonian Astrophysical Observation", "SAO 33976"},
        {"Wilson Evans Batten Catalogue", "WEB 19562"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.33312767),
        dec: Angle.Degrees(+59.50194638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160539"},
        {"Hipparcos Number", "HIP 86189"},
        {"Smithsonian Astrophysical Observation", "SAO 30485"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.17669153),
        dec: Angle.Degrees(+59.50245900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3930",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3930"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.61379631),
        dec: Angle.Degrees(+59.50273074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 161.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -161.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152274"},
        {"Hipparcos Number", "HIP 82291"},
        {"Smithsonian Astrophysical Observation", "SAO 30111"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.21882071),
        dec: Angle.Degrees(+59.50333168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12001",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12001"},
        {"Geneva Identification System", "GEN# +0.05800488"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.67501385),
        dec: Angle.Degrees(+59.50744142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153681"},
        {"Hipparcos Number", "HIP 82966"},
        {"Geneva Identification System", "GEN# +1.00153681"},
        {"Smithsonian Astrophysical Observation", "SAO 30177"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.31584469),
        dec: Angle.Degrees(+59.50816019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11543"},
        {"Hipparcos Number", "HIP 8941"},
        {"Geneva Identification System", "GEN# +1.00011543"},
        {"Renson", "Renson 2960"},
        {"Smithsonian Astrophysical Observation", "SAO 22744"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.78986874),
        dec: Angle.Degrees(+59.50841100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61693",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61693"},
    },
    visualMagnitude: 10.85,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.69459073),
        dec: Angle.Degrees(+59.51349903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -156.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3699"},
        {"Hipparcos Number", "HIP 3171"},
        {"Geneva Identification System", "GEN# +1.00003699"},
        {"Smithsonian Astrophysical Observation", "SAO 21608"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.10336259),
        dec: Angle.Degrees(+59.51381621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131969"},
        {"Hipparcos Number", "HIP 72912"},
        {"Smithsonian Astrophysical Observation", "SAO 29331"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.52729123),
        dec: Angle.Degrees(+59.51479268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238613"},
        {"Hipparcos Number", "HIP 82288"},
        {"Smithsonian Astrophysical Observation", "SAO 30110"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.21344543),
        dec: Angle.Degrees(+59.51616492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108056"},
        {"Hipparcos Number", "HIP 60528"},
        {"Geneva Identification System", "GEN# +1.00108056"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.12132000),
        dec: Angle.Degrees(+59.51749873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189843"},
        {"Hipparcos Number", "HIP 98349"},
        {"Smithsonian Astrophysical Observation", "SAO 32174"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.73250447),
        dec: Angle.Degrees(+59.51914614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104586"},
        {"Hipparcos Number", "HIP 58730"},
        {"Geneva Identification System", "GEN# +1.00104586"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.69455188),
        dec: Angle.Degrees(+59.52025085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136617"},
        {"Hipparcos Number", "HIP 74938"},
        {"Geneva Identification System", "GEN# +1.00136617"},
        {"Smithsonian Astrophysical Observation", "SAO 29480"},
        {"Wilson Evans Batten Catalogue", "WEB 12785"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.69780337),
        dec: Angle.Degrees(+59.52123453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21966",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3391 AB"},
        {"Henry Draper", "HD 29606"},
        {"Hipparcos Number", "HIP 21966"},
        {"Smithsonian Astrophysical Observation", "SAO 24777"},
        {"Wilson Evans Batten Catalogue", "WEB 4223"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.82400762),
        dec: Angle.Degrees(+59.52123474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36370"},
        {"Hipparcos Number", "HIP 26195"},
        {"Smithsonian Astrophysical Observation", "SAO 25264"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.74895943),
        dec: Angle.Degrees(+59.52399504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19441"},
        {"Hipparcos Number", "HIP 14738"},
        {"Geneva Identification System", "GEN# +1.00019441"},
        {"Smithsonian Astrophysical Observation", "SAO 23846"},
        {"Wilson Evans Batten Catalogue", "WEB 2854"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.57742399),
        dec: Angle.Degrees(+59.52463502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165006"},
        {"Hipparcos Number", "HIP 88133"},
        {"Smithsonian Astrophysical Observation", "SAO 30690"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.03160962),
        dec: Angle.Degrees(+59.52537026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110275"},
        {"Hipparcos Number", "HIP 61841"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.09952145),
        dec: Angle.Degrees(+59.52570397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112160"},
        {"Hipparcos Number", "HIP 62914"},
        {"Geneva Identification System", "GEN# +1.00112160"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.40893082),
        dec: Angle.Degrees(+59.52604376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239765"},
        {"Hipparcos Number", "HIP 107466"},
        {"Smithsonian Astrophysical Observation", "SAO 33736"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.50759202),
        dec: Angle.Degrees(+59.52634454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14183"},
        {"Hipparcos Number", "HIP 10867"},
        {"Geneva Identification System", "GEN# +4.31020164"},
        {"Smithsonian Astrophysical Observation", "SAO 23198"},
        {"Wilson Evans Batten Catalogue", "WEB 2291"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.96859781),
        dec: Angle.Degrees(+59.52780059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172957"},
        {"Hipparcos Number", "HIP 91469"},
        {"Smithsonian Astrophysical Observation", "SAO 31092"},
    },
    visualMagnitude: 6.92,
    bvColour: 1.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.83065241),
        dec: Angle.Degrees(+59.52804070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21960"},
        {"Hipparcos Number", "HIP 16749"},
        {"Smithsonian Astrophysical Observation", "SAO 24115"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.86885677),
        dec: Angle.Degrees(+59.52840803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59974"},
        {"Hipparcos Number", "HIP 36960"},
        {"Smithsonian Astrophysical Observation", "SAO 26416"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.97565740),
        dec: Angle.Degrees(+59.52910122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53927",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53927"},
        {"Geneva Identification System", "GEN# +0.06001302"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.51655569),
        dec: Angle.Degrees(+59.52972802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133909"},
        {"Hipparcos Number", "HIP 73730"},
        {"Geneva Identification System", "GEN# +1.00133909"},
        {"Smithsonian Astrophysical Observation", "SAO 29397"},
        {"Wilson Evans Batten Catalogue", "WEB 12606"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.07345860),
        dec: Angle.Degrees(+59.53505398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135741"},
        {"Hipparcos Number", "HIP 74543"},
        {"Smithsonian Astrophysical Observation", "SAO 29456"},
        {"Wilson Evans Batten Catalogue", "WEB 12719"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.47689009),
        dec: Angle.Degrees(+59.53558420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13402"},
        {"Hipparcos Number", "HIP 10323"},
        {"Geneva Identification System", "GEN# +4.31020031"},
        {"Smithsonian Astrophysical Observation", "SAO 23031"},
        {"Wilson Evans Batten Catalogue", "WEB 2154"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.23857759),
        dec: Angle.Degrees(+59.53855191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133816"},
        {"Hipparcos Number", "HIP 73684"},
        {"Smithsonian Astrophysical Observation", "SAO 29395"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.91947095),
        dec: Angle.Degrees(+59.54021709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 74.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5966"},
        {"Hipparcos Number", "HIP 4828"},
        {"Geneva Identification System", "GEN# +1.00005966"},
        {"Smithsonian Astrophysical Observation", "SAO 21935"},
        {"Wilson Evans Batten Catalogue", "WEB 923"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.50711321),
        dec: Angle.Degrees(+59.54579394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122636"},
        {"Hipparcos Number", "HIP 68487"},
        {"Smithsonian Astrophysical Observation", "SAO 28977"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.31974254),
        dec: Angle.Degrees(+59.54898325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170811"},
        {"Hipparcos Number", "HIP 90476"},
        {"Smithsonian Astrophysical Observation", "SAO 30990"},
        {"Wilson Evans Batten Catalogue", "WEB 15494"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.92538623),
        dec: Angle.Degrees(+59.54901845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8865",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8865"},
        {"Geneva Identification System", "GEN# +0.05800317"},
    },
    visualMagnitude: 9.70,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.50852660),
        dec: Angle.Degrees(+59.54916966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 191.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180712"},
        {"Hipparcos Number", "HIP 94501"},
        {"Geneva Identification System", "GEN# +1.00180712"},
        {"Smithsonian Astrophysical Observation", "SAO 31502"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.50587317),
        dec: Angle.Degrees(+59.55155246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 112.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89593"},
        {"Hipparcos Number", "HIP 50760"},
        {"Geneva Identification System", "GEN# +1.00089593"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.48076907),
        dec: Angle.Degrees(+59.55197550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238543"},
        {"Hipparcos Number", "HIP 79515"},
        {"Smithsonian Astrophysical Observation", "SAO 29847"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.38984819),
        dec: Angle.Degrees(+59.55419039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55885",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55885"},
        {"Cincinnati Publication", "Ci 20 638"},
    },
    visualMagnitude: 11.40,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.81485709),
        dec: Angle.Degrees(+59.55591113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -319.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -403.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58412",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58412"},
    },
    visualMagnitude: 11.03,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.64953541),
        dec: Angle.Degrees(+59.55616408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -738.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174220"},
        {"Hipparcos Number", "HIP 92064"},
        {"Smithsonian Astrophysical Observation", "SAO 31160"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.46657950),
        dec: Angle.Degrees(+59.55915655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43259"},
        {"Hipparcos Number", "HIP 30021"},
        {"Geneva Identification System", "GEN# +1.00043259"},
        {"Smithsonian Astrophysical Observation", "SAO 25660"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.76231506),
        dec: Angle.Degrees(+59.55948346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224784"},
        {"Hipparcos Number", "HIP 43"},
        {"Fundamental Katalog 5th Edition", "FK5 3928"},
        {"Geneva Identification System", "GEN# +1.00224784"},
        {"Smithsonian Astrophysical Observation", "SAO 35983"},
        {"Wilson Evans Batten Catalogue", "WEB 5"},
    },
    visualMagnitude: 6.18,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.12908900),
        dec: Angle.Degrees(+59.55973786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60844"},
        {"Hipparcos Number", "HIP 37346"},
        {"Smithsonian Astrophysical Observation", "SAO 26450"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.99420456),
        dec: Angle.Degrees(+59.56329867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19820"},
        {"Hipparcos Number", "HIP 15063"},
        {"Fundamental Katalog 5th Edition", "FK5 2227"},
        {"Geneva Identification System", "GEN# +1.00019820"},
        {"Smithsonian Astrophysical Observation", "SAO 23886"},
        {"Wilson Evans Batten Catalogue", "WEB 2898"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.52222780),
        dec: Angle.Degrees(+59.56347371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108200"},
        {"Hipparcos Number", "HIP 60609"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.33921597),
        dec: Angle.Degrees(+59.56514981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237320"},
        {"Hipparcos Number", "HIP 22434"},
        {"Smithsonian Astrophysical Observation", "SAO 24850"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.42159895),
        dec: Angle.Degrees(+59.56634226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141729"},
        {"Hipparcos Number", "HIP 77362"},
        {"Geneva Identification System", "GEN# +1.00141729"},
        {"Smithsonian Astrophysical Observation", "SAO 29671"},
    },
    visualMagnitude: 6.53,
    bvColour: 1.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.88317443),
        dec: Angle.Degrees(+59.56867488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236639"},
        {"Hipparcos Number", "HIP 5523"},
        {"Smithsonian Astrophysical Observation", "SAO 22059"},
        {"Wilson Evans Batten Catalogue", "WEB 1223"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.67763655),
        dec: Angle.Degrees(+59.57036230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 102.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68930"},
        {"Hipparcos Number", "HIP 40646"},
        {"Fundamental Katalog 5th Edition", "FK5 2645"},
        {"Geneva Identification System", "GEN# +1.00068930"},
        {"Smithsonian Astrophysical Observation", "SAO 26756"},
        {"Wilson Evans Batten Catalogue", "WEB 7898"},
    },
    visualMagnitude: 5.63,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.46008016),
        dec: Angle.Degrees(+59.57112846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205329"},
        {"Hipparcos Number", "HIP 106349"},
        {"Smithsonian Astrophysical Observation", "SAO 33516"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.08634967),
        dec: Angle.Degrees(+59.57254316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4362"},
        {"Hipparcos Number", "HIP 3649"},
        {"Fundamental Katalog 5th Edition", "FK5 4068"},
        {"Geneva Identification System", "GEN# +1.00004362"},
        {"Smithsonian Astrophysical Observation", "SAO 21693"},
        {"Wilson Evans Batten Catalogue", "WEB 650"},
    },
    visualMagnitude: 6.41,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.67694190),
        dec: Angle.Degrees(+59.57454122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40734",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6717 AB"},
        {"Hipparcos Number", "HIP 40734"},
        {"Smithsonian Astrophysical Observation", "SAO 26765"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.72111070),
        dec: Angle.Degrees(+59.57849594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239589"},
        {"Hipparcos Number", "HIP 104515"},
        {"Smithsonian Astrophysical Observation", "SAO 33189"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.56165221),
        dec: Angle.Degrees(+59.58282228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73252",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73252"},
    },
    visualMagnitude: 10.20,
    bvColour: 1.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.56583584),
        dec: Angle.Degrees(+59.58329977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -106.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22337"},
        {"Hipparcos Number", "HIP 17008"},
        {"Smithsonian Astrophysical Observation", "SAO 24135"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.69929256),
        dec: Angle.Degrees(+59.58409355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83451",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10329 A"},
        {"Henry Draper", "HD 154712"},
        {"Hipparcos Number", "HIP 83451"},
        {"Cincinnati Publication", "Ci 20 1019"},
        {"Geneva Identification System", "GEN# +1.00154712A"},
        {"Smithsonian Astrophysical Observation", "SAO 30220"},
        {"Wilson Evans Batten Catalogue", "WEB 14105"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.82945718),
        dec: Angle.Degrees(+59.58477314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -356.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 241.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239809"},
        {"Hipparcos Number", "HIP 108376"},
        {"Smithsonian Astrophysical Observation", "SAO 33908"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.33777859),
        dec: Angle.Degrees(+59.58478647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19009"},
        {"Hipparcos Number", "HIP 14431"},
        {"Geneva Identification System", "GEN# +1.00019009"},
        {"Smithsonian Astrophysical Observation", "SAO 23798"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.56821611),
        dec: Angle.Degrees(+59.58514690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73246"},
        {"Hipparcos Number", "HIP 42548"},
        {"Smithsonian Astrophysical Observation", "SAO 26951"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.09232775),
        dec: Angle.Degrees(+59.58543521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83454",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10329 B"},
        {"Henry Draper", "HD 154712B"},
        {"Hipparcos Number", "HIP 83454"},
        {"Geneva Identification System", "GEN# +1.00154712B"},
        {"Wilson Evans Batten Catalogue", "WEB 14106"},
    },
    visualMagnitude: 10.34,
    bvColour: 1.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.83413265),
        dec: Angle.Degrees(+59.58718409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -365.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 253.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18337"},
        {"Hipparcos Number", "HIP 13929"},
        {"Geneva Identification System", "GEN# +1.00018337"},
        {"Smithsonian Astrophysical Observation", "SAO 23748"},
        {"Wilson Evans Batten Catalogue", "WEB 2748"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.86138902),
        dec: Angle.Degrees(+59.59222378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236393"},
        {"Hipparcos Number", "HIP 1850"},
        {"Smithsonian Astrophysical Observation", "SAO 21348"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.84367462),
        dec: Angle.Degrees(+59.59526328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214418"},
        {"Hipparcos Number", "HIP 111612"},
        {"Geneva Identification System", "GEN# +1.00214418"},
        {"Smithsonian Astrophysical Observation", "SAO 34618"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.844,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.16544491),
        dec: Angle.Degrees(+59.59638254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90400"},
        {"Hipparcos Number", "HIP 51224"},
        {"Geneva Identification System", "GEN# +1.00090400"},
        {"Smithsonian Astrophysical Observation", "SAO 27648"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.94140432),
        dec: Angle.Degrees(+59.59729076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12416",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12416"},
        {"Geneva Identification System", "GEN# +0.05800501"},
    },
    visualMagnitude: 9.41,
    bvColour: 2.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.96016848),
        dec: Angle.Degrees(+59.59758213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114552",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114552"},
        {"Geneva Identification System", "GEN# +8.03590049"},
    },
    visualMagnitude: 10.79,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.05411289),
        dec: Angle.Degrees(+59.59976527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100714",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13850 AB"},
        {"Henry Draper", "HD 194882"},
        {"Hipparcos Number", "HIP 100714"},
        {"Celescope Catalog", "CEL 5059"},
        {"Geneva Identification System", "GEN# +1.00194882"},
        {"Smithsonian Astrophysical Observation", "SAO 32562"},
        {"Wilson Evans Batten Catalogue", "WEB 18200"},
    },
    visualMagnitude: 6.44,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.27084638),
        dec: Angle.Degrees(+59.60012111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236637"},
        {"Hipparcos Number", "HIP 5501"},
        {"Smithsonian Astrophysical Observation", "SAO 22052"},
    },
    visualMagnitude: 9.99,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.61063394),
        dec: Angle.Degrees(+59.60043922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240311"},
        {"Hipparcos Number", "HIP 115943"},
        {"Geneva Identification System", "GEN# +1.00240311"},
        {"Renson", "Renson 60650"},
        {"Smithsonian Astrophysical Observation", "SAO 35468"},
        {"Wilson Evans Batten Catalogue", "WEB 20506"},
    },
    visualMagnitude: 10.48,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.35898640),
        dec: Angle.Degrees(+59.60273224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108860",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108860"},
        {"Geneva Identification System", "GEN# +9.80232051"},
    },
    visualMagnitude: 10.93,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.79508007),
        dec: Angle.Degrees(+59.60297827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 155.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 139.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240312"},
        {"Hipparcos Number", "HIP 115950"},
        {"Celescope Catalog", "CEL 5622"},
        {"Geneva Identification System", "GEN# +1.00240312"},
        {"Smithsonian Astrophysical Observation", "SAO 35470"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.37549736),
        dec: Angle.Degrees(+59.60356773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217860"},
        {"Hipparcos Number", "HIP 113790"},
        {"Geneva Identification System", "GEN# +1.00217860"},
        {"Smithsonian Astrophysical Observation", "SAO 35090"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.65575971),
        dec: Angle.Degrees(+59.60506804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25537",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25537"},
    },
    visualMagnitude: 10.66,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.90531197),
        dec: Angle.Degrees(+59.60529978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107671"},
        {"Hipparcos Number", "HIP 60319"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.52807632),
        dec: Angle.Degrees(+59.60665416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223581"},
        {"Hipparcos Number", "HIP 117561"},
        {"Celescope Catalog", "CEL 5690"},
        {"Smithsonian Astrophysical Observation", "SAO 35826"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.61913292),
        dec: Angle.Degrees(+59.61021210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23983"},
        {"Hipparcos Number", "HIP 18128"},
        {"Smithsonian Astrophysical Observation", "SAO 24268"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.14508595),
        dec: Angle.Degrees(+59.61146347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240380"},
        {"Hipparcos Number", "HIP 117082"},
        {"Geneva Identification System", "GEN# +1.00240380"},
        {"Smithsonian Astrophysical Observation", "SAO 35717"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.03406130),
        dec: Angle.Degrees(+59.61494916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20456",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3146 A"},
        {"Henry Draper", "HD 27402"},
        {"Hipparcos Number", "HIP 20456"},
        {"Smithsonian Astrophysical Observation", "SAO 24577"},
        {"Wilson Evans Batten Catalogue", "WEB 3913"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.74128194),
        dec: Angle.Degrees(+59.61628914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115215"},
        {"Hipparcos Number", "HIP 64605"},
        {"Geneva Identification System", "GEN# +1.00115215"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.62149938),
        dec: Angle.Degrees(+59.61960488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217490"},
        {"Henry Draper 2", "HD 217507"},
        {"Hipparcos Number", "HIP 113565"},
        {"Geneva Identification System", "GEN# +1.00217490J"},
        {"Smithsonian Astrophysical Observation", "SAO 35043"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.738,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.03770936),
        dec: Angle.Degrees(+59.61989492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13036"},
        {"Hipparcos Number", "HIP 10078"},
        {"Geneva Identification System", "GEN# +4.31020001"},
        {"Smithsonian Astrophysical Observation", "SAO 22974"},
        {"Wilson Evans Batten Catalogue", "WEB 2111"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.40766175),
        dec: Angle.Degrees(+59.62039328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11540",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11540"},
    },
    visualMagnitude: 10.04,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.18897253),
        dec: Angle.Degrees(+59.62119521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237199"},
        {"Hipparcos Number", "HIP 18516"},
        {"Smithsonian Astrophysical Observation", "SAO 24316"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.38250798),
        dec: Angle.Degrees(+59.62215257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91772",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11632 B"},
        {"Henry Draper", "HD 173740"},
        {"Hipparcos Number", "HIP 91772"},
        {"Cincinnati Publication", "Ci 20 1106"},
        {"Smithsonian Astrophysical Observation", "SAO 31129"},
        {"Wilson Evans Batten Catalogue", "WEB 15793"},
    },
    visualMagnitude: 9.70,
    bvColour: 1.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.70212390),
        dec: Angle.Degrees(+59.62236064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1393.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1845.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112384"},
        {"Hipparcos Number", "HIP 63078"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.87016876),
        dec: Angle.Degrees(+59.62246627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101952"},
        {"Hipparcos Number", "HIP 57241"},
        {"Geneva Identification System", "GEN# +1.00101952"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.05974248),
        dec: Angle.Degrees(+59.62573078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11860"},
        {"Hipparcos Number", "HIP 9188"},
        {"Celescope Catalog", "CEL 182"},
        {"Fundamental Katalog 5th Edition", "FK5 2133"},
        {"Geneva Identification System", "GEN# +1.00011860"},
        {"Smithsonian Astrophysical Observation", "SAO 22793"},
        {"Wilson Evans Batten Catalogue", "WEB 1931"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.57705821),
        dec: Angle.Degrees(+59.62600215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91768",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11632 A"},
        {"Henry Draper", "HD 173739"},
        {"Hipparcos Number", "HIP 91768"},
        {"Cincinnati Publication", "Ci 20 1105"},
        {"Cincinnati Publication 2", "Ci 18 2456"},
        {"Geneva Identification System", "GEN# +1.00173739A"},
        {"Smithsonian Astrophysical Observation", "SAO 31128"},
        {"Wilson Evans Batten Catalogue", "WEB 15792"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.70090582),
        dec: Angle.Degrees(+59.62601593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1326.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1802.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9737"},
        {"Hipparcos Number", "HIP 7515"},
        {"Geneva Identification System", "GEN# +1.00009737"},
        {"Smithsonian Astrophysical Observation", "SAO 22429"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.20202950),
        dec: Angle.Degrees(+59.62606381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237054"},
        {"Hipparcos Number", "HIP 14133"},
        {"Geneva Identification System", "GEN# +1.00237054"},
        {"Smithsonian Astrophysical Observation", "SAO 23772"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.56624766),
        dec: Angle.Degrees(+59.62698963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12820"},
        {"Hipparcos Number", "HIP 9927"},
        {"Geneva Identification System", "GEN# +1.00012820"},
        {"Smithsonian Astrophysical Observation", "SAO 22942"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.94677688),
        dec: Angle.Degrees(+59.62928619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144302"},
        {"Hipparcos Number", "HIP 78524"},
        {"Geneva Identification System", "GEN# +1.00144302"},
        {"Smithsonian Astrophysical Observation", "SAO 29766"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.46609861),
        dec: Angle.Degrees(+59.63059463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -124.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10437"},
        {"Hipparcos Number", "HIP 8052"},
        {"Geneva Identification System", "GEN# +1.00010437"},
        {"Smithsonian Astrophysical Observation", "SAO 22541"},
    },
    visualMagnitude: 6.57,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.83906703),
        dec: Angle.Degrees(+59.63288280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220016"},
        {"Hipparcos Number", "HIP 115186"},
        {"Celescope Catalog", "CEL 5597"},
        {"Geneva Identification System", "GEN# +1.00220016"},
        {"Smithsonian Astrophysical Observation", "SAO 35331"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.95662090),
        dec: Angle.Degrees(+59.63335760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20295"},
        {"Hipparcos Number", "HIP 15424"},
        {"Geneva Identification System", "GEN# +1.00020295"},
        {"Smithsonian Astrophysical Observation", "SAO 23940"},
        {"Wilson Evans Batten Catalogue", "WEB 2967"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.69390407),
        dec: Angle.Degrees(+59.63448895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55280"},
        {"Hipparcos Number", "HIP 35146"},
        {"Fundamental Katalog 5th Edition", "FK5 2558"},
        {"Geneva Identification System", "GEN# +1.00055280"},
        {"Smithsonian Astrophysical Observation", "SAO 26248"},
        {"Wilson Evans Batten Catalogue", "WEB 7022"},
    },
    visualMagnitude: 5.20,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.97924939),
        dec: Angle.Degrees(+59.63809569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -258.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237536"},
        {"Hipparcos Number", "HIP 32305"},
        {"Geneva Identification System", "GEN# +1.00237536"},
        {"Smithsonian Astrophysical Observation", "SAO 25921"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.17577763),
        dec: Angle.Degrees(+59.64056409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24409"},
        {"Hipparcos Number", "HIP 18413"},
        {"Smithsonian Astrophysical Observation", "SAO 24307"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.04937079),
        dec: Angle.Degrees(+59.64150046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -284.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 159.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42024",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42024"},
        {"Smithsonian Astrophysical Observation", "SAO 26908"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.49635891),
        dec: Angle.Degrees(+59.64857052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236604"},
        {"Hipparcos Number", "HIP 4910"},
        {"Smithsonian Astrophysical Observation", "SAO 21947"},
        {"Wilson Evans Batten Catalogue", "WEB 972"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.74871006),
        dec: Angle.Degrees(+59.65646087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47538",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47538"},
    },
    visualMagnitude: 9.87,
    bvColour: 1.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.38107121),
        dec: Angle.Degrees(+59.65788435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14914"},
        {"Hipparcos Number", "HIP 11380"},
        {"Smithsonian Astrophysical Observation", "SAO 23327"},
        {"Wilson Evans Batten Catalogue", "WEB 2374"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.63999004),
        dec: Angle.Degrees(+59.65897576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238812"},
        {"Hipparcos Number", "HIP 88529"},
        {"Geneva Identification System", "GEN# +1.00238812"},
        {"Smithsonian Astrophysical Observation", "SAO 30737"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.17143185),
        dec: Angle.Degrees(+59.66115035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240422"},
        {"Hipparcos Number", "HIP 117590"},
        {"Smithsonian Astrophysical Observation", "SAO 35832"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.71051297),
        dec: Angle.Degrees(+59.66237129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99071"},
        {"Hipparcos Number", "HIP 55697"},
        {"Geneva Identification System", "GEN# +1.00099071"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.18667921),
        dec: Angle.Degrees(+59.66376753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46294"},
        {"Hipparcos Number", "HIP 31565"},
        {"Geneva Identification System", "GEN# +1.00046294"},
        {"Smithsonian Astrophysical Observation", "SAO 25833"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.10003157),
        dec: Angle.Degrees(+59.66451404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93253"},
        {"Hipparcos Number", "HIP 52772"},
        {"Geneva Identification System", "GEN# +1.00093253"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.85005455),
        dec: Angle.Degrees(+59.66548573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18473"},
        {"Hipparcos Number", "HIP 14049"},
        {"Geneva Identification System", "GEN# +1.00018473"},
        {"Renson", "Renson 4610"},
        {"Smithsonian Astrophysical Observation", "SAO 23761"},
        {"Wilson Evans Batten Catalogue", "WEB 2767"},
    },
    visualMagnitude: 7.35,
    bvColour: -0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.22409743),
        dec: Angle.Degrees(+59.66599593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220760"},
        {"Hipparcos Number", "HIP 115658"},
        {"Celescope Catalog", "CEL 5616"},
        {"Geneva Identification System", "GEN# +1.00220760"},
        {"Smithsonian Astrophysical Observation", "SAO 35411"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.45356358),
        dec: Angle.Degrees(+59.66698443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175511"},
        {"Hipparcos Number", "HIP 92594"},
        {"Smithsonian Astrophysical Observation", "SAO 31232"},
    },
    visualMagnitude: 6.96,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.00922026),
        dec: Angle.Degrees(+59.66701771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84192"},
        {"Hipparcos Number", "HIP 47894"},
        {"Geneva Identification System", "GEN# +1.00084192"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.42034513),
        dec: Angle.Degrees(+59.67046507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14242"},
        {"Hipparcos Number", "HIP 10904"},
        {"Geneva Identification System", "GEN# +1.00014242"},
        {"Smithsonian Astrophysical Observation", "SAO 23203"},
    },
    visualMagnitude: 8.22,
    bvColour: 2.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.09359884),
        dec: Angle.Degrees(+59.67136486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4768"},
        {"Hipparcos Number", "HIP 3932"},
        {"Geneva Identification System", "GEN# +1.00004768"},
        {"Smithsonian Astrophysical Observation", "SAO 21757"},
        {"Wilson Evans Batten Catalogue", "WEB 701"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.61635090),
        dec: Angle.Degrees(+59.67175306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237424"},
        {"Hipparcos Number", "HIP 27547"},
        {"Smithsonian Astrophysical Observation", "SAO 25395"},
    },
    visualMagnitude: 9.57,
    bvColour: 1.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.49902110),
        dec: Angle.Degrees(+59.67312410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 593"},
        {"Hipparcos Number", "HIP 860"},
        {"Celescope Catalog", "CEL 36"},
        {"Geneva Identification System", "GEN# +1.00000593"},
        {"Smithsonian Astrophysical Observation", "SAO 21164"},
        {"Wilson Evans Batten Catalogue", "WEB 147"},
    },
    visualMagnitude: 6.70,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.64438297),
        dec: Angle.Degrees(+59.67341444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103592"},
        {"Hipparcos Number", "HIP 58173"},
        {"Geneva Identification System", "GEN# +1.00103592"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.96633149),
        dec: Angle.Degrees(+59.67395918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14345"},
        {"Hipparcos Number", "HIP 10968"},
        {"Geneva Identification System", "GEN# +1.00014345"},
        {"Smithsonian Astrophysical Observation", "SAO 23223"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.31329013),
        dec: Angle.Degrees(+59.67516618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146044"},
        {"Hipparcos Number", "HIP 79276"},
        {"Geneva Identification System", "GEN# +1.00146044"},
        {"Smithsonian Astrophysical Observation", "SAO 29837"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.69706964),
        dec: Angle.Degrees(+59.67569027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49367",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7623 AB"},
        {"Henry Draper", "HD 87076"},
        {"Hipparcos Number", "HIP 49367"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.15924089),
        dec: Angle.Degrees(+59.67639570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64250"},
        {"Hipparcos Number", "HIP 38791"},
        {"Geneva Identification System", "GEN# +1.00064250"},
        {"Smithsonian Astrophysical Observation", "SAO 26574"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.09112850),
        dec: Angle.Degrees(+59.67652010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149843"},
        {"Hipparcos Number", "HIP 81091"},
        {"Smithsonian Astrophysical Observation", "SAO 29993"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.45162476),
        dec: Angle.Degrees(+59.67720146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139455"},
        {"Hipparcos Number", "HIP 76317"},
        {"Smithsonian Astrophysical Observation", "SAO 29585"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.83512460),
        dec: Angle.Degrees(+59.67891999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103308"},
        {"Hipparcos Number", "HIP 58017"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.49650166),
        dec: Angle.Degrees(+59.68046660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240060"},
        {"Hipparcos Number", "HIP 112437"},
        {"Smithsonian Astrophysical Observation", "SAO 34800"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.62768054),
        dec: Angle.Degrees(+59.68469216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174259"},
        {"Hipparcos Number", "HIP 92080"},
        {"Smithsonian Astrophysical Observation", "SAO 31162"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.50693290),
        dec: Angle.Degrees(+59.68684034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111964",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111964"},
        {"Geneva Identification System", "GEN# +0.05802468"},
        {"Smithsonian Astrophysical Observation", "SAO 34692"},
    },
    visualMagnitude: 10.32,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.19834788),
        dec: Angle.Degrees(+59.68718504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12302"},
        {"Hipparcos Number", "HIP 9538"},
        {"Celescope Catalog", "CEL 186"},
        {"Geneva Identification System", "GEN# +1.00012302"},
        {"Smithsonian Astrophysical Observation", "SAO 22861"},
        {"Wilson Evans Batten Catalogue", "WEB 1999"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.65178955),
        dec: Angle.Degrees(+59.68810154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159266"},
        {"Hipparcos Number", "HIP 85634"},
        {"Geneva Identification System", "GEN# +1.00159266"},
        {"Smithsonian Astrophysical Observation", "SAO 30431"},
        {"Wilson Evans Batten Catalogue", "WEB 14451"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.50651041),
        dec: Angle.Degrees(+59.68858569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65448",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65448"},
        {"Geneva Identification System", "GEN# +0.06001460"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.751,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.20119977),
        dec: Angle.Degrees(+59.68873536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180778"},
        {"Hipparcos Number", "HIP 94522"},
        {"Geneva Identification System", "GEN# +1.00180778"},
        {"Renson", "Renson 50150"},
        {"Smithsonian Astrophysical Observation", "SAO 31506"},
        {"Wilson Evans Batten Catalogue", "WEB 16475"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.57150894),
        dec: Angle.Degrees(+59.68924592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71315",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71315"},
        {"Geneva Identification System", "GEN# +0.06001552"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.75167511),
        dec: Angle.Degrees(+59.69110765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192490"},
        {"Hipparcos Number", "HIP 99530"},
        {"Fundamental Katalog 5th Edition", "FK5 5778"},
        {"Geneva Identification System", "GEN# +1.00192490"},
        {"Smithsonian Astrophysical Observation", "SAO 32350"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.99590407),
        dec: Angle.Degrees(+59.69135064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 86.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147427"},
        {"Hipparcos Number", "HIP 79906"},
        {"Geneva Identification System", "GEN# +1.00147427"},
        {"Smithsonian Astrophysical Observation", "SAO 29884"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.65540415),
        dec: Angle.Degrees(+59.69366132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56905",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56905"},
    },
    visualMagnitude: 11.59,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.97546957),
        dec: Angle.Degrees(+59.69456329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -147.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -252.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220999"},
        {"Hipparcos Number", "HIP 115824"},
        {"Celescope Catalog", "CEL 5620"},
        {"Geneva Identification System", "GEN# +1.00220999"},
        {"Smithsonian Astrophysical Observation", "SAO 35441"},
        {"Wilson Evans Batten Catalogue", "WEB 20493"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.97624105),
        dec: Angle.Degrees(+59.69532486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56242"},
        {"Hipparcos Number", "HIP 35525"},
        {"Smithsonian Astrophysical Observation", "SAO 26275"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.98274969),
        dec: Angle.Degrees(+59.69660754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106055"},
        {"Hipparcos Number", "HIP 59474"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.779,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.98224857),
        dec: Angle.Degrees(+59.69739275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -206.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47464"},
        {"Hipparcos Number", "HIP 32121"},
        {"Smithsonian Astrophysical Observation", "SAO 25882"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.63747755),
        dec: Angle.Degrees(+59.69750298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44229"},
        {"Hipparcos Number", "HIP 30491"},
        {"Renson", "Renson 11733"},
        {"Smithsonian Astrophysical Observation", "SAO 25707"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.13854947),
        dec: Angle.Degrees(+59.69940200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218997"},
        {"Hipparcos Number", "HIP 114515"},
        {"Geneva Identification System", "GEN# +1.00218997"},
        {"Wilson Evans Batten Catalogue", "WEB 20324"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.91958563),
        dec: Angle.Degrees(+59.69973074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207538"},
        {"Hipparcos Number", "HIP 107598"},
        {"Celescope Catalog", "CEL 5388"},
        {"Geneva Identification System", "GEN# +4.35371588"},
        {"Renson", "Renson 57740"},
        {"Smithsonian Astrophysical Observation", "SAO 33763"},
        {"Wilson Evans Batten Catalogue", "WEB 19419"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.91579939),
        dec: Angle.Degrees(+59.70038074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56205",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8191 B"},
        {"Henry Draper", "HD 100054B"},
        {"Hipparcos Number", "HIP 56205"},
        {"Renson", "Renson 28784"},
        {"Wilson Evans Batten Catalogue", "WEB 10099"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.83409010),
        dec: Angle.Degrees(+59.70087021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56202",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8191 A"},
        {"Henry Draper", "HD 100054"},
        {"Hipparcos Number", "HIP 56202"},
        {"Smithsonian Astrophysical Observation", "SAO 28043"},
        {"Wilson Evans Batten Catalogue", "WEB 10096"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.82733754),
        dec: Angle.Degrees(+59.70090598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118656"},
        {"Hipparcos Number", "HIP 66404"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.20638509),
        dec: Angle.Degrees(+59.70264804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197290"},
        {"Hipparcos Number", "HIP 101973"},
        {"Smithsonian Astrophysical Observation", "SAO 32785"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.97843428),
        dec: Angle.Degrees(+59.70298671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215939"},
        {"Hipparcos Number", "HIP 112536"},
        {"Geneva Identification System", "GEN# +1.00215939"},
        {"Smithsonian Astrophysical Observation", "SAO 34832"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.90257158),
        dec: Angle.Degrees(+59.70334857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37586"},
        {"Hipparcos Number", "HIP 26968"},
        {"Geneva Identification System", "GEN# +1.00037586"},
        {"Smithsonian Astrophysical Observation", "SAO 25335"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.84176438),
        dec: Angle.Degrees(+59.70385786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1543",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 263 AB"},
        {"Henry Draper", "HD 1479"},
        {"Hipparcos Number", "HIP 1543"},
        {"Celescope Catalog", "CEL 53"},
        {"Geneva Identification System", "GEN# +1.00001479J"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.80926863),
        dec: Angle.Degrees(+59.70496976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170614"},
        {"Hipparcos Number", "HIP 90394"},
        {"Smithsonian Astrophysical Observation", "SAO 30977"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.66146069),
        dec: Angle.Degrees(+59.70566116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70590"},
        {"Hipparcos Number", "HIP 41333"},
        {"Geneva Identification System", "GEN# +1.00070590"},
        {"Smithsonian Astrophysical Observation", "SAO 26830"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.49640463),
        dec: Angle.Degrees(+59.70707889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188793"},
        {"Hipparcos Number", "HIP 97892"},
        {"Celescope Catalog", "CEL 4875"},
        {"Geneva Identification System", "GEN# +1.00188793"},
        {"Smithsonian Astrophysical Observation", "SAO 32093"},
        {"Wilson Evans Batten Catalogue", "WEB 17225"},
    },
    visualMagnitude: 6.06,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.39741251),
        dec: Angle.Degrees(+59.70852496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237425"},
        {"Hipparcos Number", "HIP 27593"},
        {"Smithsonian Astrophysical Observation", "SAO 25402"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.64465090),
        dec: Angle.Degrees(+59.71010977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130684"},
        {"Hipparcos Number", "HIP 72293"},
        {"Geneva Identification System", "GEN# +1.00130684"},
        {"Smithsonian Astrophysical Observation", "SAO 29278"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.76030623),
        dec: Angle.Degrees(+59.71030379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239203"},
        {"Hipparcos Number", "HIP 97164"},
        {"Smithsonian Astrophysical Observation", "SAO 31958"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.23773786),
        dec: Angle.Degrees(+59.71328341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16507"},
        {"Hipparcos Number", "HIP 12537"},
        {"Smithsonian Astrophysical Observation", "SAO 23525"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.32626648),
        dec: Angle.Degrees(+59.71459262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113436"},
        {"Hipparcos Number", "HIP 63647"},
        {"Fundamental Katalog 5th Edition", "FK5 3041"},
        {"Geneva Identification System", "GEN# +1.00113436"},
        {"Renson", "Renson 32900"},
        {"Smithsonian Astrophysical Observation", "SAO 28613"},
        {"Wilson Evans Batten Catalogue", "WEB 11265"},
    },
    visualMagnitude: 6.50,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.66856739),
        dec: Angle.Degrees(+59.71632956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209889"},
        {"Hipparcos Number", "HIP 108997"},
        {"Smithsonian Astrophysical Observation", "SAO 34032"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.21274605),
        dec: Angle.Degrees(+59.71661832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224424"},
        {"Hipparcos Number", "HIP 118139"},
        {"Celescope Catalog", "CEL 5727"},
        {"Geneva Identification System", "GEN# +1.00224424"},
        {"Smithsonian Astrophysical Observation", "SAO 35928"},
        {"Wilson Evans Batten Catalogue", "WEB 20769"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.44874301),
        dec: Angle.Degrees(+59.72012208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106208"},
        {"Hipparcos Number", "HIP 59576"},
        {"Geneva Identification System", "GEN# +1.00106208"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.25780394),
        dec: Angle.Degrees(+59.72019879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138868"},
        {"Hipparcos Number", "HIP 76040"},
        {"Geneva Identification System", "GEN# +1.00138868"},
        {"Smithsonian Astrophysical Observation", "SAO 29562"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.94173530),
        dec: Angle.Degrees(+59.72035167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127164"},
        {"Hipparcos Number", "HIP 70700"},
        {"Geneva Identification System", "GEN# +1.00127164"},
        {"Smithsonian Astrophysical Observation", "SAO 29158"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.90158698),
        dec: Angle.Degrees(+59.72285671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218067"},
        {"Hipparcos Number", "HIP 113918"},
        {"Geneva Identification System", "GEN# +1.00218067"},
        {"Renson", "Renson 60100"},
        {"Smithsonian Astrophysical Observation", "SAO 35114"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.04371410),
        dec: Angle.Degrees(+59.72679511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218440"},
        {"Hipparcos Number", "HIP 114163"},
        {"Geneva Identification System", "GEN# +1.00218440"},
        {"Smithsonian Astrophysical Observation", "SAO 35152"},
        {"Wilson Evans Batten Catalogue", "WEB 20274"},
    },
    visualMagnitude: 6.41,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.79352112),
        dec: Angle.Degrees(+59.72739838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27464"},
        {"Hipparcos Number", "HIP 20495"},
        {"Geneva Identification System", "GEN# +1.00027464"},
        {"Smithsonian Astrophysical Observation", "SAO 24580"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.89452301),
        dec: Angle.Degrees(+59.73258997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10680"},
        {"Hipparcos Number", "HIP 8231"},
        {"Smithsonian Astrophysical Observation", "SAO 22600"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.49737342),
        dec: Angle.Degrees(+59.73301661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195391"},
        {"Hipparcos Number", "HIP 100944"},
        {"Celescope Catalog", "CEL 5076"},
        {"Geneva Identification System", "GEN# +1.00195391"},
        {"Smithsonian Astrophysical Observation", "SAO 32611"},
    },
    visualMagnitude: 7.98,
    bvColour: -0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.00093312),
        dec: Angle.Degrees(+59.73447950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236714"},
        {"Hipparcos Number", "HIP 6540"},
        {"Smithsonian Astrophysical Observation", "SAO 22236"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.00972188),
        dec: Angle.Degrees(+59.73481175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21843"},
        {"Hipparcos Number", "HIP 16656"},
        {"Geneva Identification System", "GEN# +1.00021843"},
        {"Smithsonian Astrophysical Observation", "SAO 24105"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.736,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.57976985),
        dec: Angle.Degrees(+59.73493440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61343",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61343"},
        {"Smithsonian Astrophysical Observation", "SAO 15827"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.53841101),
        dec: Angle.Degrees(+59.73633560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67573",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67573"},
    },
    visualMagnitude: 11.19,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.70240879),
        dec: Angle.Degrees(+59.73664600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236762"},
        {"Hipparcos Number", "HIP 7065"},
        {"Geneva Identification System", "GEN# +1.00236762"},
        {"Smithsonian Astrophysical Observation", "SAO 22348"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.76064267),
        dec: Angle.Degrees(+59.73720227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5410"},
        {"Hipparcos Number", "HIP 4438"},
        {"Geneva Identification System", "GEN# +1.00005410"},
        {"Smithsonian Astrophysical Observation", "SAO 21858"},
        {"Wilson Evans Batten Catalogue", "WEB 798"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.19149508),
        dec: Angle.Degrees(+59.73884201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189208"},
        {"Hipparcos Number", "HIP 98052"},
        {"Geneva Identification System", "GEN# +1.00189208"},
        {"Smithsonian Astrophysical Observation", "SAO 32117"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.89086093),
        dec: Angle.Degrees(+59.74067926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216573"},
        {"Hipparcos Number", "HIP 112988"},
        {"Smithsonian Astrophysical Observation", "SAO 34918"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.22753296),
        dec: Angle.Degrees(+59.74291340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101239",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13975 AB"},
        {"Henry Draper", "HD 195915"},
        {"Hipparcos Number", "HIP 101239"},
        {"Smithsonian Astrophysical Observation", "SAO 32659"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.81455012),
        dec: Angle.Degrees(+59.74487712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87510"},
        {"Hipparcos Number", "HIP 49588"},
        {"Geneva Identification System", "GEN# +1.00087510"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.847,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.84476103),
        dec: Angle.Degrees(+59.74655954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10808",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10808"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.78404641),
        dec: Angle.Degrees(+59.74790151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238698"},
        {"Hipparcos Number", "HIP 85374"},
        {"Geneva Identification System", "GEN# +1.00238698"},
        {"Smithsonian Astrophysical Observation", "SAO 30392"},
    },
    visualMagnitude: 9.71,
    bvColour: -0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.67370353),
        dec: Angle.Degrees(+59.74880910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110889",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110889"},
        {"Cincinnati Publication", "Ci 20 1365"},
    },
    visualMagnitude: 10.67,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.98729948),
        dec: Angle.Degrees(+59.74934473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 403.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 206.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110104"},
        {"Hipparcos Number", "HIP 61741"},
        {"Geneva Identification System", "GEN# +1.00110104"},
        {"Smithsonian Astrophysical Observation", "SAO 15856"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.81391596),
        dec: Angle.Degrees(+59.75008675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105949",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14998 A"},
        {"Henry Draper", "HD 204599"},
        {"Hipparcos Number", "HIP 105949"},
        {"Fundamental Katalog 5th Edition", "FK5 3717"},
        {"Geneva Identification System", "GEN# +1.00204599"},
        {"Smithsonian Astrophysical Observation", "SAO 33443"},
        {"Wilson Evans Batten Catalogue", "WEB 19210"},
    },
    visualMagnitude: 6.11,
    bvColour: 1.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.85542635),
        dec: Angle.Degrees(+59.75011387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143685"},
        {"Hipparcos Number", "HIP 78254"},
        {"Smithsonian Astrophysical Observation", "SAO 29738"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.65636156),
        dec: Angle.Degrees(+59.75106246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90875"},
        {"Hipparcos Number", "HIP 51468"},
        {"Smithsonian Astrophysical Observation", "SAO 15204"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.69791144),
        dec: Angle.Degrees(+59.75179697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -438.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -287.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7361"},
        {"Hipparcos Number", "HIP 5841"},
        {"Geneva Identification System", "GEN# +1.00007361"},
        {"Smithsonian Astrophysical Observation", "SAO 22124"},
        {"Wilson Evans Batten Catalogue", "WEB 1333"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.74246098),
        dec: Angle.Degrees(+59.75201341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236836"},
        {"Hipparcos Number", "HIP 8049"},
        {"Smithsonian Astrophysical Observation", "SAO 22540"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.83470632),
        dec: Angle.Degrees(+59.75247924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206536"},
        {"Hipparcos Number", "HIP 107026"},
        {"Fundamental Katalog 5th Edition", "FK5 5914"},
        {"Geneva Identification System", "GEN# +1.00206536"},
        {"Smithsonian Astrophysical Observation", "SAO 33657"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.13493173),
        dec: Angle.Degrees(+59.75269324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240308"},
        {"Hipparcos Number", "HIP 115912"},
        {"Celescope Catalog", "CEL 5621"},
        {"Geneva Identification System", "GEN# +1.00240308"},
        {"Smithsonian Astrophysical Observation", "SAO 35459"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.26686725),
        dec: Angle.Degrees(+59.75305442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147232"},
        {"Hipparcos Number", "HIP 79804"},
        {"Fundamental Katalog 5th Edition", "FK5 3291"},
        {"Geneva Identification System", "GEN# +1.00147232"},
        {"Smithsonian Astrophysical Observation", "SAO 29874"},
        {"Wilson Evans Batten Catalogue", "WEB 13510"},
    },
    visualMagnitude: 5.37,
    bvColour: 1.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.31391116),
        dec: Angle.Degrees(+59.75496116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172648"},
        {"Hipparcos Number", "HIP 91335"},
        {"Smithsonian Astrophysical Observation", "SAO 31078"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.43198447),
        dec: Angle.Degrees(+59.75846838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237341"},
        {"Hipparcos Number", "HIP 23507"},
        {"Smithsonian Astrophysical Observation", "SAO 24972"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.81607601),
        dec: Angle.Degrees(+59.75903520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68947",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68947"},
        {"Geneva Identification System", "GEN# +0.06001512"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.70620036),
        dec: Angle.Degrees(+59.75969532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239618"},
        {"Hipparcos Number", "HIP 104883"},
        {"Geneva Identification System", "GEN# +1.00239618"},
        {"Smithsonian Astrophysical Observation", "SAO 33258"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.68952674),
        dec: Angle.Degrees(+59.76103148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34129"},
        {"Hipparcos Number", "HIP 24788"},
        {"Geneva Identification System", "GEN# +1.00034129"},
        {"Smithsonian Astrophysical Observation", "SAO 25121"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.71798954),
        dec: Angle.Degrees(+59.76305270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36421"},
        {"Hipparcos Number", "HIP 26236"},
        {"Geneva Identification System", "GEN# +1.00036421"},
        {"Smithsonian Astrophysical Observation", "SAO 25269"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.84635287),
        dec: Angle.Degrees(+59.76340507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183968"},
        {"Hipparcos Number", "HIP 95762"},
        {"Smithsonian Astrophysical Observation", "SAO 31696"},
        {"Wilson Evans Batten Catalogue", "WEB 16756"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.16013997),
        dec: Angle.Degrees(+59.76402120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240335"},
        {"Hipparcos Number", "HIP 116412"},
        {"Geneva Identification System", "GEN# +1.00240335"},
        {"Smithsonian Astrophysical Observation", "SAO 35572"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.85126237),
        dec: Angle.Degrees(+59.76586962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224233"},
        {"Hipparcos Number", "HIP 118010"},
        {"Geneva Identification System", "GEN# +1.00224233"},
        {"Smithsonian Astrophysical Observation", "SAO 35900"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.04670933),
        dec: Angle.Degrees(+59.76692008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 195.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 282.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7103",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7103"},
        {"Geneva Identification System", "GEN# +0.05900266"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.88160122),
        dec: Angle.Degrees(+59.76876701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121921"},
        {"Hipparcos Number", "HIP 68105"},
        {"Smithsonian Astrophysical Observation", "SAO 16223"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.14517216),
        dec: Angle.Degrees(+59.76915731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -134.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147764"},
        {"Hipparcos Number", "HIP 80045"},
        {"Geneva Identification System", "GEN# +1.00147764"},
        {"Smithsonian Astrophysical Observation", "SAO 29901"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.08198042),
        dec: Angle.Degrees(+59.77084754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68944",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68944"},
        {"Smithsonian Astrophysical Observation", "SAO 16279"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.69308332),
        dec: Angle.Degrees(+59.77137411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55178"},
        {"Hipparcos Number", "HIP 35105"},
        {"Geneva Identification System", "GEN# +1.00055178"},
        {"Smithsonian Astrophysical Observation", "SAO 26245"},
        {"Wilson Evans Batten Catalogue", "WEB 7015"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.88437856),
        dec: Angle.Degrees(+59.77501114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38706",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38706"},
        {"Smithsonian Astrophysical Observation", "SAO 26569"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.86473851),
        dec: Angle.Degrees(+59.77670749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194557"},
        {"Hipparcos Number", "HIP 100545"},
        {"Smithsonian Astrophysical Observation", "SAO 32522"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.80814901),
        dec: Angle.Degrees(+59.77768596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54995",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8103 AB"},
        {"Henry Draper", "HD 97772"},
        {"Hipparcos Number", "HIP 54995"},
        {"Geneva Identification System", "GEN# +1.00097772J"},
        {"Smithsonian Astrophysical Observation", "SAO 15448"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.90301506),
        dec: Angle.Degrees(+59.77873244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126324"},
        {"Hipparcos Number", "HIP 70267"},
        {"Smithsonian Astrophysical Observation", "SAO 16356"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.65786166),
        dec: Angle.Degrees(+59.77958371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199921"},
        {"Hipparcos Number", "HIP 103448"},
        {"Smithsonian Astrophysical Observation", "SAO 33024"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.37299043),
        dec: Angle.Degrees(+59.77987573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80130"},
        {"Hipparcos Number", "HIP 45812"},
        {"Smithsonian Astrophysical Observation", "SAO 27213"},
        {"Wilson Evans Batten Catalogue", "WEB 8686"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.12257291),
        dec: Angle.Degrees(+59.78075124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80669",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80669"},
        {"Geneva Identification System", "GEN# +0.06001681"},
        {"Smithsonian Astrophysical Observation", "SAO 29955"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.05119297),
        dec: Angle.Degrees(+59.78090580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9022"},
        {"Hipparcos Number", "HIP 7013"},
        {"Geneva Identification System", "GEN# +1.00009022"},
        {"Smithsonian Astrophysical Observation", "SAO 22338"},
        {"Wilson Evans Batten Catalogue", "WEB 1517"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.57621517),
        dec: Angle.Degrees(+59.78202938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15862"},
        {"Hipparcos Number", "HIP 12062"},
        {"Cincinnati Publication", "Ci 18 330"},
        {"Geneva Identification System", "GEN# +1.00015862"},
        {"Smithsonian Astrophysical Observation", "SAO 23444"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.88553566),
        dec: Angle.Degrees(+59.79252581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 230.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100048",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100048"},
    },
    visualMagnitude: 9.98,
    bvColour: 1.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.47350606),
        dec: Angle.Degrees(+59.79261504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108301",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15481 AB"},
        {"Henry Draper", "HD 208744"},
        {"Hipparcos Number", "HIP 108301"},
        {"Geneva Identification System", "GEN# +1.00208744J"},
        {"Smithsonian Astrophysical Observation", "SAO 33894"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.11375056),
        dec: Angle.Degrees(+59.79510424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82975",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82975"},
        {"Smithsonian Astrophysical Observation", "SAO 30178"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.33996494),
        dec: Angle.Degrees(+59.79576067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83085",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83085"},
        {"Smithsonian Astrophysical Observation", "SAO 30188"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.66115133),
        dec: Angle.Degrees(+59.79764614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52708"},
        {"Hipparcos Number", "HIP 34250"},
        {"Fundamental Katalog 5th Edition", "FK5 4641"},
        {"Geneva Identification System", "GEN# +1.00052708"},
        {"Smithsonian Astrophysical Observation", "SAO 26141"},
        {"Wilson Evans Batten Catalogue", "WEB 6859"},
    },
    visualMagnitude: 6.40,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.50504379),
        dec: Angle.Degrees(+59.80185721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12184"},
        {"Hipparcos Number", "HIP 9451"},
        {"Geneva Identification System", "GEN# +1.00012184"},
        {"Smithsonian Astrophysical Observation", "SAO 22847"},
        {"Wilson Evans Batten Catalogue", "WEB 1980"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.38325926),
        dec: Angle.Degrees(+59.80314613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55376",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55376"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.08575641),
        dec: Angle.Degrees(+59.80377465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -138.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23242"},
        {"Hipparcos Number", "HIP 17636"},
        {"Geneva Identification System", "GEN# +1.00023242"},
        {"Smithsonian Astrophysical Observation", "SAO 24205"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.67952663),
        dec: Angle.Degrees(+59.80458312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77851",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77851"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.765,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.45314959),
        dec: Angle.Degrees(+59.80614189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -202.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108925",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15601 AG"},
        {"Henry Draper", "HD 209744"},
        {"Hipparcos Number", "HIP 108925"},
        {"Celescope Catalog", "CEL 5429"},
        {"Geneva Identification System", "GEN# +1.00209744J"},
        {"Geneva Identification System 2", "GEN# +1.00209744A"},
        {"Smithsonian Astrophysical Observation", "SAO 34016"},
        {"Wilson Evans Batten Catalogue", "WEB 19591"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.97442446),
        dec: Angle.Degrees(+59.81457919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217348"},
        {"Hipparcos Number", "HIP 113498"},
        {"Geneva Identification System", "GEN# +1.00217348"},
        {"Smithsonian Astrophysical Observation", "SAO 35026"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.78749556),
        dec: Angle.Degrees(+59.81465827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219286"},
        {"Hipparcos Number", "HIP 114685"},
        {"Celescope Catalog", "CEL 5581"},
        {"Geneva Identification System", "GEN# +1.00219286"},
        {"Smithsonian Astrophysical Observation", "SAO 35245"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.49363823),
        dec: Angle.Degrees(+59.82016934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16778"},
        {"Hipparcos Number", "HIP 12750"},
        {"Geneva Identification System", "GEN# +1.00016778"},
        {"Smithsonian Astrophysical Observation", "SAO 23564"},
        {"Wilson Evans Batten Catalogue", "WEB 2591"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.97371113),
        dec: Angle.Degrees(+59.82276417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119799"},
        {"Hipparcos Number", "HIP 66988"},
        {"Geneva Identification System", "GEN# +1.00119799"},
        {"Smithsonian Astrophysical Observation", "SAO 16152"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.92525230),
        dec: Angle.Degrees(+59.82434671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162523"},
        {"Hipparcos Number", "HIP 87086"},
        {"Geneva Identification System", "GEN# +1.00162523"},
        {"Smithsonian Astrophysical Observation", "SAO 30579"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.92438141),
        dec: Angle.Degrees(+59.82451232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134301"},
        {"Hipparcos Number", "HIP 73915"},
        {"Geneva Identification System", "GEN# +1.00134301"},
        {"Smithsonian Astrophysical Observation", "SAO 16594"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.57603421),
        dec: Angle.Degrees(+59.82524244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26498",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4206 A"},
        {"Henry Draper", "HD 237406"},
        {"Hipparcos Number", "HIP 26498"},
        {"Smithsonian Astrophysical Observation", "SAO 25283"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.53685010),
        dec: Angle.Degrees(+59.82560881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3519"},
        {"Hipparcos Number", "HIP 3058"},
        {"Fundamental Katalog 5th Edition", "FK5 2041"},
        {"Geneva Identification System", "GEN# +1.00003519"},
        {"Smithsonian Astrophysical Observation", "SAO 21592"},
    },
    visualMagnitude: 6.72,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.70521269),
        dec: Angle.Degrees(+59.82616136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238838"},
        {"Hipparcos Number", "HIP 89443"},
        {"Smithsonian Astrophysical Observation", "SAO 30847"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.81419724),
        dec: Angle.Degrees(+59.82672510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -130.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17911"},
        {"Hipparcos Number", "HIP 13597"},
        {"Geneva Identification System", "GEN# +1.00017911"},
        {"Smithsonian Astrophysical Observation", "SAO 23692"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.80267497),
        dec: Angle.Degrees(+59.82932370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57465",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8301 AB"},
        {"Henry Draper", "HD 102295"},
        {"Hipparcos Number", "HIP 57465"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.69184814),
        dec: Angle.Degrees(+59.83096972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33805",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33805"},
    },
    visualMagnitude: 10.93,
    bvColour: 1.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.27659697),
        dec: Angle.Degrees(+59.83325319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -166.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96093"},
        {"Hipparcos Number", "HIP 54254"},
        {"Smithsonian Astrophysical Observation", "SAO 15400"},
        {"Wilson Evans Batten Catalogue", "WEB 9801"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.48523393),
        dec: Angle.Degrees(+59.83566168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181675"},
        {"Hipparcos Number", "HIP 94835"},
        {"Geneva Identification System", "GEN# +1.00181675"},
        {"Smithsonian Astrophysical Observation", "SAO 31553"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.45526139),
        dec: Angle.Degrees(+59.83633690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59621"},
        {"Hipparcos Number", "HIP 36828"},
        {"Geneva Identification System", "GEN# +1.00059621"},
        {"Smithsonian Astrophysical Observation", "SAO 26408"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.61075192),
        dec: Angle.Degrees(+59.83728974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186253"},
        {"Hipparcos Number", "HIP 96742"},
        {"Fundamental Katalog 5th Edition", "FK5 5730"},
        {"Geneva Identification System", "GEN# +1.00186253"},
        {"Smithsonian Astrophysical Observation", "SAO 31881"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.98543645),
        dec: Angle.Degrees(+59.84100426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239185"},
        {"Hipparcos Number", "HIP 96927"},
        {"Smithsonian Astrophysical Observation", "SAO 31911"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.886,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.54714905),
        dec: Angle.Degrees(+59.84210819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95802"},
        {"Hipparcos Number", "HIP 54111"},
        {"Geneva Identification System", "GEN# +1.00095802"},
        {"Smithsonian Astrophysical Observation", "SAO 15388"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.08214948),
        dec: Angle.Degrees(+59.84359030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43278"},
        {"Hipparcos Number", "HIP 30043"},
        {"Smithsonian Astrophysical Observation", "SAO 25661"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.82698804),
        dec: Angle.Degrees(+59.84657317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81686"},
        {"Hipparcos Number", "HIP 46551"},
        {"Smithsonian Astrophysical Observation", "SAO 14896"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.40032975),
        dec: Angle.Degrees(+59.84716830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238749"},
        {"Hipparcos Number", "HIP 86870"},
        {"Smithsonian Astrophysical Observation", "SAO 30553"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.23237648),
        dec: Angle.Degrees(+59.84923869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239649"},
        {"Hipparcos Number", "HIP 105621"},
        {"Geneva Identification System", "GEN# +1.00239649"},
        {"Smithsonian Astrophysical Observation", "SAO 33384"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.89401527),
        dec: Angle.Degrees(+59.85151795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217817"},
        {"Hipparcos Number", "HIP 113772"},
        {"Geneva Identification System", "GEN# +1.00217817"},
        {"Smithsonian Astrophysical Observation", "SAO 35086"},
        {"Wilson Evans Batten Catalogue", "WEB 20212"},
    },
    visualMagnitude: 7.00,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.60486689),
        dec: Angle.Degrees(+59.85268648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56305",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56305"},
        {"Smithsonian Astrophysical Observation", "SAO 15546"},
    },
    visualMagnitude: 10.20,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.14585326),
        dec: Angle.Degrees(+59.85283399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198300"},
        {"Henry Draper 2", "HD 198300A"},
        {"Hipparcos Number", "HIP 102523"},
        {"Smithsonian Astrophysical Observation", "SAO 32884"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.64846816),
        dec: Angle.Degrees(+59.85333896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -132.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -289.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43420"},
        {"Hipparcos Number", "HIP 30096"},
        {"Geneva Identification System", "GEN# +1.00043420"},
        {"Smithsonian Astrophysical Observation", "SAO 25668"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.00618300),
        dec: Angle.Degrees(+59.85503755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75008",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75008"},
    },
    visualMagnitude: 10.92,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.90776239),
        dec: Angle.Degrees(+59.85666673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -171.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -151.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128422"},
        {"Hipparcos Number", "HIP 71265"},
        {"Smithsonian Astrophysical Observation", "SAO 16432"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.62452788),
        dec: Angle.Degrees(+59.85787313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6475"},
        {"Hipparcos Number", "HIP 5232"},
        {"Geneva Identification System", "GEN# +1.00006475"},
        {"Smithsonian Astrophysical Observation", "SAO 22012"},
        {"Wilson Evans Batten Catalogue", "WEB 1098"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.72503165),
        dec: Angle.Degrees(+59.85864267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240250"},
        {"Hipparcos Number", "HIP 115048"},
        {"Geneva Identification System", "GEN# +1.00240250"},
        {"Smithsonian Astrophysical Observation", "SAO 35307"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.51954441),
        dec: Angle.Degrees(+59.85920245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116091"},
        {"Hipparcos Number", "HIP 65057"},
        {"Geneva Identification System", "GEN# +1.00116091"},
        {"Smithsonian Astrophysical Observation", "SAO 16046"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.03249526),
        dec: Angle.Degrees(+59.86181793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237118"},
        {"Hipparcos Number", "HIP 15521"},
        {"Geneva Identification System", "GEN# +1.00237118"},
        {"Smithsonian Astrophysical Observation", "SAO 23954"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.00498323),
        dec: Angle.Degrees(+59.86410614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108938",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15601 E"},
        {"Henry Draper", "HD 209809"},
        {"Hipparcos Number", "HIP 108938"},
        {"Geneva Identification System", "GEN# +1.00209809"},
        {"Smithsonian Astrophysical Observation", "SAO 34019"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.05356215),
        dec: Angle.Degrees(+59.86715603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86964"},
        {"Hipparcos Number", "HIP 49303"},
        {"Smithsonian Astrophysical Observation", "SAO 15063"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.95045873),
        dec: Angle.Degrees(+59.87030678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -106.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28445"},
        {"Hipparcos Number", "HIP 21201"},
        {"Geneva Identification System", "GEN# +1.00028445"},
        {"Smithsonian Astrophysical Observation", "SAO 24676"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.18511855),
        dec: Angle.Degrees(+59.87170032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145886"},
        {"Hipparcos Number", "HIP 79204"},
        {"Geneva Identification System", "GEN# +1.00145886"},
        {"Smithsonian Astrophysical Observation", "SAO 16980"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.48469614),
        dec: Angle.Degrees(+59.87178614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29817"},
        {"Hipparcos Number", "HIP 22110"},
        {"Geneva Identification System", "GEN# +1.00029817"},
        {"Smithsonian Astrophysical Observation", "SAO 24799"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.37579465),
        dec: Angle.Degrees(+59.87198080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237451"},
        {"Hipparcos Number", "HIP 28751"},
        {"Geneva Identification System", "GEN# +1.00237451"},
        {"Smithsonian Astrophysical Observation", "SAO 25542"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.07355606),
        dec: Angle.Degrees(+59.87218402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195891"},
        {"Hipparcos Number", "HIP 101218"},
        {"Geneva Identification System", "GEN# +1.00195891"},
        {"Smithsonian Astrophysical Observation", "SAO 32652"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.75816378),
        dec: Angle.Degrees(+59.87595055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124863"},
        {"Hipparcos Number", "HIP 69519"},
        {"Smithsonian Astrophysical Observation", "SAO 16313"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.46597696),
        dec: Angle.Degrees(+59.87604817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29762"},
        {"Hipparcos Number", "HIP 22080"},
        {"Renson", "Renson 7630"},
        {"Smithsonian Astrophysical Observation", "SAO 24793"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.24097932),
        dec: Angle.Degrees(+59.87723375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112015"},
        {"Hipparcos Number", "HIP 62837"},
        {"Smithsonian Astrophysical Observation", "SAO 15925"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.14546241),
        dec: Angle.Degrees(+59.87738486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238992"},
        {"Hipparcos Number", "HIP 93782"},
        {"Smithsonian Astrophysical Observation", "SAO 31386"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.48326661),
        dec: Angle.Degrees(+59.87899500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12178",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1970 AB"},
        {"Henry Draper", "HD 16038"},
        {"Hipparcos Number", "HIP 12178"},
        {"Smithsonian Astrophysical Observation", "SAO 23467"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.23036631),
        dec: Angle.Degrees(+59.88363644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40082"},
        {"Hipparcos Number", "HIP 28468"},
        {"Smithsonian Astrophysical Observation", "SAO 25512"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.15354195),
        dec: Angle.Degrees(+59.88528392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236796"},
        {"Hipparcos Number", "HIP 7455"},
        {"Smithsonian Astrophysical Observation", "SAO 22420"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.01099177),
        dec: Angle.Degrees(+59.88757996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8614",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8614"},
        {"Wilson Evans Batten Catalogue", "WEB 1825"},
    },
    visualMagnitude: 10.59,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.77926783),
        dec: Angle.Degrees(+59.88821278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39220"},
        {"Hipparcos Number", "HIP 27971"},
        {"Fundamental Katalog 5th Edition", "FK5 2446"},
        {"Geneva Identification System", "GEN# +1.00039220"},
        {"Renson", "Renson 10520"},
        {"Smithsonian Astrophysical Observation", "SAO 25447"},
        {"Wilson Evans Batten Catalogue", "WEB 5480"},
    },
    visualMagnitude: 5.20,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.74093802),
        dec: Angle.Degrees(+59.88841219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238901"},
        {"Hipparcos Number", "HIP 90934"},
        {"Geneva Identification System", "GEN# +1.00238901"},
        {"Smithsonian Astrophysical Observation", "SAO 31045"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.25131409),
        dec: Angle.Degrees(+59.88852043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201429"},
        {"Hipparcos Number", "HIP 104223"},
        {"Smithsonian Astrophysical Observation", "SAO 33146"},
        {"Wilson Evans Batten Catalogue", "WEB 18985"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.72893591),
        dec: Angle.Degrees(+59.88975132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162789"},
        {"Hipparcos Number", "HIP 87200"},
        {"Smithsonian Astrophysical Observation", "SAO 30594"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.22189760),
        dec: Angle.Degrees(+59.89007492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239675"},
        {"Hipparcos Number", "HIP 105934"},
        {"Geneva Identification System", "GEN# +1.00239675"},
        {"Smithsonian Astrophysical Observation", "SAO 33442"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.82079065),
        dec: Angle.Degrees(+59.89160159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238778"},
        {"Hipparcos Number", "HIP 87666"},
        {"Smithsonian Astrophysical Observation", "SAO 30638"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.60459805),
        dec: Angle.Degrees(+59.89254838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11463"},
        {"Hipparcos Number", "HIP 8895"},
        {"Geneva Identification System", "GEN# +1.00011463"},
        {"Smithsonian Astrophysical Observation", "SAO 22726"},
        {"Wilson Evans Batten Catalogue", "WEB 1870"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.63243856),
        dec: Angle.Degrees(+59.89370223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81911"},
        {"Hipparcos Number", "HIP 46672"},
        {"Smithsonian Astrophysical Observation", "SAO 14905"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.73240167),
        dec: Angle.Degrees(+59.89381715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238843"},
        {"Hipparcos Number", "HIP 89581"},
        {"Smithsonian Astrophysical Observation", "SAO 30870"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.20366977),
        dec: Angle.Degrees(+59.89598630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40161",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40161"},
        {"Smithsonian Astrophysical Observation", "SAO 14457"},
    },
    visualMagnitude: 9.66,
    bvColour: 1.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.02850913),
        dec: Angle.Degrees(+59.89754142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27204"},
        {"Hipparcos Number", "HIP 20328"},
        {"Smithsonian Astrophysical Observation", "SAO 24551"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.32228607),
        dec: Angle.Degrees(+59.90125627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35735",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5995 A"},
        {"Henry Draper", "HD 56820"},
        {"Hipparcos Number", "HIP 35735"},
        {"Renson", "Renson 15490"},
        {"Smithsonian Astrophysical Observation", "SAO 26298"},
        {"Wilson Evans Batten Catalogue", "WEB 7120"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.57161024),
        dec: Angle.Degrees(+59.90195861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16183",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2540 AB"},
        {"Henry Draper", "HD 21224"},
        {"Hipparcos Number", "HIP 16183"},
        {"Geneva Identification System", "GEN# +1.00021224J"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.12106121),
        dec: Angle.Degrees(+59.90665623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12060"},
        {"Hipparcos Number", "HIP 9360"},
        {"Geneva Identification System", "GEN# +1.00012060"},
        {"Smithsonian Astrophysical Observation", "SAO 22828"},
        {"Wilson Evans Batten Catalogue", "WEB 1967"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.06452331),
        dec: Angle.Degrees(+59.90727111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25877"},
        {"Hipparcos Number", "HIP 19412"},
        {"Geneva Identification System", "GEN# +1.00025877"},
        {"Smithsonian Astrophysical Observation", "SAO 24436"},
        {"Wilson Evans Batten Catalogue", "WEB 3729"},
    },
    visualMagnitude: 6.29,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.36490050),
        dec: Angle.Degrees(+59.90807590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238839"},
        {"Hipparcos Number", "HIP 89464"},
        {"Geneva Identification System", "GEN# +1.00238839"},
        {"Smithsonian Astrophysical Observation", "SAO 30851"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.86600243),
        dec: Angle.Degrees(+59.90903755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237090"},
        {"Hipparcos Number", "HIP 15139"},
        {"Geneva Identification System", "GEN# +1.00237090"},
        {"Smithsonian Astrophysical Observation", "SAO 23895"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.79554101),
        dec: Angle.Degrees(+59.91189829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71534"},
        {"Hipparcos Number", "HIP 41775"},
        {"Geneva Identification System", "GEN# +1.00071534"},
        {"Renson", "Renson 19750"},
        {"Smithsonian Astrophysical Observation", "SAO 14576"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.78055808),
        dec: Angle.Degrees(+59.91266195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15150",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2412 AB"},
        {"Henry Draper", "HD 237091"},
        {"Hipparcos Number", "HIP 15150"},
        {"Geneva Identification System", "GEN# +1.00237091"},
        {"Smithsonian Astrophysical Observation", "SAO 23896"},
        {"Wilson Evans Batten Catalogue", "WEB 2919"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.81978471),
        dec: Angle.Degrees(+59.91365877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3881"},
        {"Hipparcos Number", "HIP 3289"},
        {"Smithsonian Astrophysical Observation", "SAO 21632"},
        {"Wilson Evans Batten Catalogue", "WEB 585"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.49081318),
        dec: Angle.Degrees(+59.91471055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55549"},
        {"Hipparcos Number", "HIP 35257"},
        {"Geneva Identification System", "GEN# +1.00055549"},
        {"Smithsonian Astrophysical Observation", "SAO 14136"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.27270619),
        dec: Angle.Degrees(+59.91655713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19644"},
        {"Hipparcos Number", "HIP 14936"},
        {"Geneva Identification System", "GEN# +1.00019644"},
        {"Smithsonian Astrophysical Observation", "SAO 23874"},
        {"Wilson Evans Batten Catalogue", "WEB 2885"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.14809677),
        dec: Angle.Degrees(+59.91969491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85501"},
        {"Hipparcos Number", "HIP 48563"},
        {"Smithsonian Astrophysical Observation", "SAO 15015"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.57315422),
        dec: Angle.Degrees(+59.92040338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44983",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44983"},
        {"Smithsonian Astrophysical Observation", "SAO 14786"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.44317438),
        dec: Angle.Degrees(+59.92315325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65756",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8919 AB"},
        {"Henry Draper", "HD 117433"},
        {"Hipparcos Number", "HIP 65756"},
        {"Smithsonian Astrophysical Observation", "SAO 16083"},
    },
    visualMagnitude: 7.94,
    bvColour: -0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.20795460),
        dec: Angle.Degrees(+59.92817032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208075"},
        {"Hipparcos Number", "HIP 107915"},
        {"Geneva Identification System", "GEN# +1.00208075"},
        {"Smithsonian Astrophysical Observation", "SAO 33816"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.95206876),
        dec: Angle.Degrees(+59.93053128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48801"},
        {"Hipparcos Number", "HIP 32680"},
        {"Smithsonian Astrophysical Observation", "SAO 25967"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.26086056),
        dec: Angle.Degrees(+59.93158797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215176"},
        {"Hipparcos Number", "HIP 112086"},
        {"Geneva Identification System", "GEN# +1.00215176"},
        {"Smithsonian Astrophysical Observation", "SAO 34710"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.53801521),
        dec: Angle.Degrees(+59.93214263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37613"},
        {"Hipparcos Number", "HIP 26996"},
        {"Geneva Identification System", "GEN# +1.00037613"},
        {"Smithsonian Astrophysical Observation", "SAO 25337"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.90677700),
        dec: Angle.Degrees(+59.93833889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73029"},
        {"Hipparcos Number", "HIP 42434"},
        {"Geneva Identification System", "GEN# +1.00073029"},
        {"Smithsonian Astrophysical Observation", "SAO 14612"},
        {"Wilson Evans Batten Catalogue", "WEB 8163"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.79210153),
        dec: Angle.Degrees(+59.93924272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224940"},
        {"Hipparcos Number", "HIP 164"},
        {"Geneva Identification System", "GEN# +1.00224940"},
        {"Smithsonian Astrophysical Observation", "SAO 35998"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.51857812),
        dec: Angle.Degrees(+59.94001211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16228",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2544 AB"},
        {"Henry Draper", "HD 21291"},
        {"Hipparcos Number", "HIP 16228"},
        {"Fundamental Katalog 5th Edition", "FK5 122"},
        {"Geneva Identification System", "GEN# +1.00021291J"},
        {"Smithsonian Astrophysical Observation", "SAO 24054"},
        {"Wilson Evans Batten Catalogue", "WEB 3092"},
    },
    visualMagnitude: 4.21,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.26722684),
        dec: Angle.Degrees(+59.94033461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26619"},
        {"Hipparcos Number", "HIP 19888"},
        {"Smithsonian Astrophysical Observation", "SAO 24505"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.99365503),
        dec: Angle.Degrees(+59.94090747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97889"},
        {"Hipparcos Number", "HIP 55060"},
        {"Fundamental Katalog 5th Edition", "FK5 2899"},
        {"Geneva Identification System", "GEN# +1.00097889"},
        {"Renson", "Renson 28216"},
        {"Smithsonian Astrophysical Observation", "SAO 15454"},
        {"Wilson Evans Batten Catalogue", "WEB 9931"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.07924878),
        dec: Angle.Degrees(+59.94318343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240371"},
        {"Hipparcos Number", "HIP 117004"},
        {"Geneva Identification System", "GEN# +1.00240371"},
        {"Smithsonian Astrophysical Observation", "SAO 35701"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.79322500),
        dec: Angle.Degrees(+59.94340908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117795",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117795"},
        {"Geneva Identification System", "GEN# +6.20030869"},
    },
    visualMagnitude: 10.47,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.33229563),
        dec: Angle.Degrees(+59.94503165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65728",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8919 C"},
        {"Henry Draper", "HD 117376"},
        {"Hipparcos Number", "HIP 65728"},
        {"Fundamental Katalog 5th Edition", "FK5 500"},
        {"Geneva Identification System", "GEN# +1.00117376"},
        {"Smithsonian Astrophysical Observation", "SAO 16080"},
        {"Wilson Evans Batten Catalogue", "WEB 11635"},
    },
    visualMagnitude: 5.40,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.11324210),
        dec: Angle.Degrees(+59.94570301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33955"},
        {"Hipparcos Number", "HIP 24678"},
        {"Smithsonian Astrophysical Observation", "SAO 25111"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.41469434),
        dec: Angle.Degrees(+59.94628230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127946"},
        {"Hipparcos Number", "HIP 71061"},
        {"Geneva Identification System", "GEN# +1.00127946"},
        {"Smithsonian Astrophysical Observation", "SAO 16412"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.97808913),
        dec: Angle.Degrees(+59.94707354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52215",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52215"},
        {"Smithsonian Astrophysical Observation", "SAO 15253"},
    },
    visualMagnitude: 9.52,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.03138871),
        dec: Angle.Degrees(+59.95001333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240375"},
        {"Hipparcos Number", "HIP 117040"},
        {"Smithsonian Astrophysical Observation", "SAO 35709"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.89245511),
        dec: Angle.Degrees(+59.95194128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112112"},
        {"Hipparcos Number", "HIP 62876"},
        {"Smithsonian Astrophysical Observation", "SAO 15930"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.29774277),
        dec: Angle.Degrees(+59.95218650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82124",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82124"},
        {"Smithsonian Astrophysical Observation", "SAO 17216"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.889,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.65471413),
        dec: Angle.Degrees(+59.95266491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12112"},
        {"Hipparcos Number", "HIP 9403"},
        {"Geneva Identification System", "GEN# +1.00012112"},
        {"Smithsonian Astrophysical Observation", "SAO 22835"},
        {"Wilson Evans Batten Catalogue", "WEB 1973"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.20180403),
        dec: Angle.Degrees(+59.95939566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217062"},
        {"Hipparcos Number", "HIP 113316"},
        {"Geneva Identification System", "GEN# +1.00217062"},
        {"Renson", "Renson 59915"},
        {"Smithsonian Astrophysical Observation", "SAO 34988"},
    },
    visualMagnitude: 7.21,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.23382915),
        dec: Angle.Degrees(+59.96169504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64500",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64500"},
        {"Smithsonian Astrophysical Observation", "SAO 16013"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.30593285),
        dec: Angle.Degrees(+59.96334971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151522"},
        {"Hipparcos Number", "HIP 81946"},
        {"Geneva Identification System", "GEN# +1.00151522"},
        {"Smithsonian Astrophysical Observation", "SAO 17203"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.08592131),
        dec: Angle.Degrees(+59.96370167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240475"},
        {"Hipparcos Number", "HIP 174"},
        {"Smithsonian Astrophysical Observation", "SAO 35999"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.55156687),
        dec: Angle.Degrees(+59.96533825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17342",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2691 A"},
        {"Henry Draper", "HD 22764"},
        {"Hipparcos Number", "HIP 17342"},
        {"Geneva Identification System", "GEN# +1.00022764A"},
        {"Smithsonian Astrophysical Observation", "SAO 24169"},
        {"Wilson Evans Batten Catalogue", "WEB 3277"},
    },
    visualMagnitude: 5.74,
    bvColour: 1.736,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.67805920),
        dec: Angle.Degrees(+59.96938466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137827"},
        {"Hipparcos Number", "HIP 75494"},
        {"Geneva Identification System", "GEN# +1.00137827"},
        {"Smithsonian Astrophysical Observation", "SAO 16729"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.32317097),
        dec: Angle.Degrees(+59.97589470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2377",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 412 AB"},
        {"Henry Draper", "HD 2626"},
        {"Hipparcos Number", "HIP 2377"},
        {"Geneva Identification System", "GEN# +2.01290201"},
        {"Smithsonian Astrophysical Observation", "SAO 21457"},
        {"Wilson Evans Batten Catalogue", "WEB 435"},
    },
    visualMagnitude: 5.94,
    bvColour: -0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.58297373),
        dec: Angle.Degrees(+59.97756400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223386"},
        {"Hipparcos Number", "HIP 117450"},
        {"Celescope Catalog", "CEL 5684"},
        {"Geneva Identification System", "GEN# +1.00223386"},
        {"Smithsonian Astrophysical Observation", "SAO 35794"},
        {"Wilson Evans Batten Catalogue", "WEB 20688"},
    },
    visualMagnitude: 6.33,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.22461721),
        dec: Angle.Degrees(+59.97893333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50016",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50016"},
    },
    visualMagnitude: 10.16,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.16482339),
        dec: Angle.Degrees(+59.97938915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -159.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -199.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13122"},
        {"Hipparcos Number", "HIP 10141"},
        {"Geneva Identification System", "GEN# +4.31020007"},
        {"Renson", "Renson 3405"},
        {"Smithsonian Astrophysical Observation", "SAO 22995"},
        {"Wilson Evans Batten Catalogue", "WEB 2117"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.60608495),
        dec: Angle.Degrees(+59.97995823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213461"},
        {"Hipparcos Number", "HIP 111069"},
        {"Geneva Identification System", "GEN# +1.00213461"},
        {"Smithsonian Astrophysical Observation", "SAO 34527"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.51498542),
        dec: Angle.Degrees(+59.98209837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240005"},
        {"Hipparcos Number", "HIP 111499"},
        {"Smithsonian Astrophysical Observation", "SAO 34595"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.85756503),
        dec: Angle.Degrees(+59.98433903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110438",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15885 AB"},
        {"Henry Draper", "HD 239937"},
        {"Hipparcos Number", "HIP 110438"},
        {"Smithsonian Astrophysical Observation", "SAO 34369"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.54603061),
        dec: Angle.Degrees(+59.98467437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236825"},
        {"Hipparcos Number", "HIP 7900"},
        {"Smithsonian Astrophysical Observation", "SAO 22509"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.39841363),
        dec: Angle.Degrees(+59.98515057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88651"},
        {"Hipparcos Number", "HIP 50222"},
        {"Fundamental Katalog 5th Edition", "FK5 2821"},
        {"Geneva Identification System", "GEN# +1.00088651"},
        {"Smithsonian Astrophysical Observation", "SAO 15129"},
        {"Wilson Evans Batten Catalogue", "WEB 9223"},
    },
    visualMagnitude: 6.18,
    bvColour: 1.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.78187716),
        dec: Angle.Degrees(+59.98552691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104642",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "PN Ou 4"},
        {"Aitken", "ADS 14749 AB"},
        {"Henry Draper", "HD 202214"},
        {"Hipparcos Number", "HIP 104642"},
        {"Celescope Catalog", "CEL 5272"},
        {"Geneva Identification System", "GEN# +1.00202214J"},
        {"Smithsonian Astrophysical Observation", "SAO 33210"},
        {"Wilson Evans Batten Catalogue", "WEB 19039"},
    },
    visualMagnitude: 5.64,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.95100195),
        dec: Angle.Degrees(+59.98661923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102111",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102111"},
    },
    visualMagnitude: 10.48,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.39445062),
        dec: Angle.Degrees(+59.98664047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239625"},
        {"Hipparcos Number", "HIP 105096"},
        {"Smithsonian Astrophysical Observation", "SAO 33292"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.33873921),
        dec: Angle.Degrees(+59.98721487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76837",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9756 AB"},
        {"Henry Draper", "HD 140590"},
        {"Hipparcos Number", "HIP 76837"},
        {"Smithsonian Astrophysical Observation", "SAO 16813"},
        {"Wilson Evans Batten Catalogue", "WEB 13034"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.733,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.31945537),
        dec: Angle.Degrees(+59.98772228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -228.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 150.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80914"},
        {"Hipparcos Number", "HIP 46170"},
        {"Geneva Identification System", "GEN# +1.00080914"},
        {"Smithsonian Astrophysical Observation", "SAO 14873"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.23463959),
        dec: Angle.Degrees(+59.99316730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208582"},
        {"Hipparcos Number", "HIP 108189"},
        {"Geneva Identification System", "GEN# +1.00208582"},
        {"Smithsonian Astrophysical Observation", "SAO 33872"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.78364849),
        dec: Angle.Degrees(+59.99832454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42633"},
        {"Hipparcos Number", "HIP 29730"},
        {"Geneva Identification System", "GEN# +1.00042633"},
        {"Smithsonian Astrophysical Observation", "SAO 13772"},
        {"Wilson Evans Batten Catalogue", "WEB 5862"},
    },
    visualMagnitude: 5.37,
    bvColour: 1.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.91878235),
        dec: Angle.Degrees(+59.99903422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 936"},
        {"Hipparcos Number", "HIP 1118"},
        {"Geneva Identification System", "GEN# +1.00000936"},
        {"Smithsonian Astrophysical Observation", "SAO 21224"},
        {"Wilson Evans Batten Catalogue", "WEB 193"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.48410150),
        dec: Angle.Degrees(+59.99934311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11878",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1932 AB"},
        {"Henry Draper", "HD 15640"},
        {"Hipparcos Number", "HIP 11878"},
        {"Celescope Catalog", "CEL 286"},
        {"Geneva Identification System", "GEN# +1.00015640J"},
        {"Smithsonian Astrophysical Observation", "SAO 23420"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.30641683),
        dec: Angle.Degrees(+59.99958508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117495"},
        {"Hipparcos Number", "HIP 65797"},
        {"Smithsonian Astrophysical Observation", "SAO 16084"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.31312892),
        dec: Angle.Degrees(+60.00191630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239875"},
        {"Hipparcos Number", "HIP 109431"},
        {"Smithsonian Astrophysical Observation", "SAO 34130"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.55733539),
        dec: Angle.Degrees(+60.00213380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14795"},
        {"Hipparcos Number", "HIP 11295"},
        {"Celescope Catalog", "CEL 271"},
        {"Geneva Identification System", "GEN# +1.00014795"},
        {"Smithsonian Astrophysical Observation", "SAO 23307"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.36087405),
        dec: Angle.Degrees(+60.00538063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11996"},
        {"Hipparcos Number", "HIP 9314"},
        {"Geneva Identification System", "GEN# +1.00011996"},
        {"Smithsonian Astrophysical Observation", "SAO 22813"},
        {"Wilson Evans Batten Catalogue", "WEB 1958"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.786,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.91375071),
        dec: Angle.Degrees(+60.00772478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240121"},
        {"Hipparcos Number", "HIP 113233"},
        {"Geneva Identification System", "GEN# +0.05902602"},
        {"Geneva Identification System 2", "GEN# +1.00240121"},
        {"Renson", "Renson 59870"},
        {"Smithsonian Astrophysical Observation", "SAO 34961"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.95973325),
        dec: Angle.Degrees(+60.00959484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86314",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86314"},
        {"Smithsonian Astrophysical Observation", "SAO 17578"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.54035505),
        dec: Angle.Degrees(+60.01086350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194933"},
        {"Hipparcos Number", "HIP 100727"},
        {"Smithsonian Astrophysical Observation", "SAO 32568"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.31934062),
        dec: Angle.Degrees(+60.01197397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14173"},
        {"Hipparcos Number", "HIP 10855"},
        {"Geneva Identification System", "GEN# +4.31020160"},
        {"Smithsonian Astrophysical Observation", "SAO 23192"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.92308614),
        dec: Angle.Degrees(+60.01307498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239806"},
        {"Hipparcos Number", "HIP 108313"},
        {"Smithsonian Astrophysical Observation", "SAO 33900"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.14411067),
        dec: Angle.Degrees(+60.01354464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59506"},
        {"Hipparcos Number", "HIP 36783"},
        {"Smithsonian Astrophysical Observation", "SAO 14236"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.48759702),
        dec: Angle.Degrees(+60.01654186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42958",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42958"},
    },
    visualMagnitude: 10.64,
    bvColour: 0.812,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.34972035),
        dec: Angle.Degrees(+60.01661672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -126.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68376"},
        {"Hipparcos Number", "HIP 40431"},
        {"Geneva Identification System", "GEN# +1.00068376"},
        {"Smithsonian Astrophysical Observation", "SAO 14474"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.83519347),
        dec: Angle.Degrees(+60.01720850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175863"},
        {"Hipparcos Number", "HIP 92729"},
        {"Fundamental Katalog 5th Edition", "FK5 5665"},
        {"Geneva Identification System", "GEN# +1.00175863"},
        {"Smithsonian Astrophysical Observation", "SAO 31253"},
        {"Wilson Evans Batten Catalogue", "WEB 16046"},
    },
    visualMagnitude: 7.05,
    bvColour: -0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.43622844),
        dec: Angle.Degrees(+60.01787758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199610"},
        {"Hipparcos Number", "HIP 103292"},
        {"Smithsonian Astrophysical Observation", "SAO 32999"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.856,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.89549945),
        dec: Angle.Degrees(+60.02194866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224404"},
        {"Hipparcos Number", "HIP 118116"},
        {"Celescope Catalog", "CEL 5724"},
        {"Geneva Identification System", "GEN# +1.00224404"},
        {"Smithsonian Astrophysical Observation", "SAO 35922"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.38965858),
        dec: Angle.Degrees(+60.02360903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133768"},
        {"Hipparcos Number", "HIP 73661"},
        {"Smithsonian Astrophysical Observation", "SAO 16586"},
    },
    visualMagnitude: 6.69,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.86144501),
        dec: Angle.Degrees(+60.02558711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 554"},
        {"Hipparcos Number", "HIP 836"},
        {"Smithsonian Astrophysical Observation", "SAO 21154"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.55874804),
        dec: Angle.Degrees(+60.02604910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14172"},
        {"Hipparcos Number", "HIP 10856"},
        {"Geneva Identification System", "GEN# +4.31020161"},
        {"Smithsonian Astrophysical Observation", "SAO 23194"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.93537926),
        dec: Angle.Degrees(+60.02956572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20508"},
        {"Hipparcos Number", "HIP 15600"},
        {"Geneva Identification System", "GEN# +1.00020508"},
        {"Smithsonian Astrophysical Observation", "SAO 23966"},
        {"Wilson Evans Batten Catalogue", "WEB 2994"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.22320444),
        dec: Angle.Degrees(+60.03035103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20688"},
        {"Hipparcos Number", "HIP 15742"},
        {"Smithsonian Astrophysical Observation", "SAO 23986"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.70667706),
        dec: Angle.Degrees(+60.03076527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239812"},
        {"Hipparcos Number", "HIP 108384"},
        {"Smithsonian Astrophysical Observation", "SAO 33910"},
        {"Wilson Evans Batten Catalogue", "WEB 19522"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.37119595),
        dec: Angle.Degrees(+60.03182079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5409"},
        {"Hipparcos Number", "HIP 4437"},
        {"Geneva Identification System", "GEN# +1.00005409"},
        {"Smithsonian Astrophysical Observation", "SAO 21857"},
        {"Wilson Evans Batten Catalogue", "WEB 797"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.19020063),
        dec: Angle.Degrees(+60.03317410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47236",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47236"},
        {"Smithsonian Astrophysical Observation", "SAO 14942"},
    },
    visualMagnitude: 9.92,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.41558583),
        dec: Angle.Degrees(+60.03377070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8906"},
        {"Hipparcos Number", "HIP 6927"},
        {"Geneva Identification System", "GEN# +1.00008906"},
        {"Smithsonian Astrophysical Observation", "SAO 22318"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.738,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.31378458),
        dec: Angle.Degrees(+60.03566996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129206"},
        {"Hipparcos Number", "HIP 71616"},
        {"Smithsonian Astrophysical Observation", "SAO 16448"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.70030474),
        dec: Angle.Degrees(+60.03769480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16712",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2612 AB"},
        {"Henry Draper", "HD 21903"},
        {"Hipparcos Number", "HIP 16712"},
        {"Geneva Identification System", "GEN# +1.00021903J"},
        {"Smithsonian Astrophysical Observation", "SAO 24111"},
        {"Wilson Evans Batten Catalogue", "WEB 3181"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.75431434),
        dec: Angle.Degrees(+60.04137677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144903"},
        {"Hipparcos Number", "HIP 78762"},
        {"Smithsonian Astrophysical Observation", "SAO 16945"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.20410252),
        dec: Angle.Degrees(+60.04472567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42264",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42264"},
        {"Smithsonian Astrophysical Observation", "SAO 14603"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.816,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.27282553),
        dec: Angle.Degrees(+60.04485052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27888",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27888"},
        {"Smithsonian Astrophysical Observation", "SAO 13645"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.52124588),
        dec: Angle.Degrees(+60.04534364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11859"},
        {"Hipparcos Number", "HIP 9192"},
        {"Geneva Identification System", "GEN# +1.00011859"},
        {"Smithsonian Astrophysical Observation", "SAO 22796"},
        {"Wilson Evans Batten Catalogue", "WEB 1933"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.58904172),
        dec: Angle.Degrees(+60.04591211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102030"},
        {"Hipparcos Number", "HIP 57284"},
        {"Smithsonian Astrophysical Observation", "SAO 15622"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.19210546),
        dec: Angle.Degrees(+60.04707564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158460"},
        {"Hipparcos Number", "HIP 85290"},
        {"Geneva Identification System", "GEN# +1.00158460"},
        {"Smithsonian Astrophysical Observation", "SAO 17472"},
        {"Wilson Evans Batten Catalogue", "WEB 14398"},
    },
    visualMagnitude: 5.65,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.42234840),
        dec: Angle.Degrees(+60.04834069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90662"},
        {"Hipparcos Number", "HIP 51378"},
        {"Smithsonian Astrophysical Observation", "SAO 15195"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.40669369),
        dec: Angle.Degrees(+60.04973075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41031",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41031"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.61161468),
        dec: Angle.Degrees(+60.05033612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221671"},
        {"Hipparcos Number", "HIP 116279"},
        {"Geneva Identification System", "GEN# +1.00221671"},
        {"Smithsonian Astrophysical Observation", "SAO 35546"},
        {"Wilson Evans Batten Catalogue", "WEB 20550"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.40057615),
        dec: Angle.Degrees(+60.05073039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130251"},
        {"Hipparcos Number", "HIP 72073"},
        {"Smithsonian Astrophysical Observation", "SAO 16481"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.14325499),
        dec: Angle.Degrees(+60.05377755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79674"},
        {"Hipparcos Number", "HIP 45632"},
        {"Geneva Identification System", "GEN# +1.00079674"},
        {"Smithsonian Astrophysical Observation", "SAO 14837"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.52594968),
        dec: Angle.Degrees(+60.05995901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44535"},
        {"Hipparcos Number", "HIP 30637"},
        {"Fundamental Katalog 5th Edition", "FK5 4585"},
        {"Smithsonian Astrophysical Observation", "SAO 13838"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.58345921),
        dec: Angle.Degrees(+60.06161137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196053"},
        {"Hipparcos Number", "HIP 101294"},
        {"Smithsonian Astrophysical Observation", "SAO 32668"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.97080594),
        dec: Angle.Degrees(+60.06324586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20134"},
        {"Hipparcos Number", "HIP 15270"},
        {"Geneva Identification System", "GEN# +1.00020134"},
        {"Smithsonian Astrophysical Observation", "SAO 23922"},
        {"Wilson Evans Batten Catalogue", "WEB 2942"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.24898483),
        dec: Angle.Degrees(+60.06749299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72691",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72691"},
    },
    visualMagnitude: 11.80,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.93600625),
        dec: Angle.Degrees(+60.06925908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82407",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82407"},
        {"Smithsonian Astrophysical Observation", "SAO 17240"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.59639445),
        dec: Angle.Degrees(+60.07666618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64532"},
        {"Hipparcos Number", "HIP 38912"},
        {"Smithsonian Astrophysical Observation", "SAO 14387"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.45300961),
        dec: Angle.Degrees(+60.07809675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26112"},
        {"Hipparcos Number", "HIP 19557"},
        {"Smithsonian Astrophysical Observation", "SAO 24456"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.83830330),
        dec: Angle.Degrees(+60.08223081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53789"},
        {"Hipparcos Number", "HIP 34610"},
        {"Geneva Identification System", "GEN# +1.00053789"},
        {"Smithsonian Astrophysical Observation", "SAO 14102"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.53153763),
        dec: Angle.Degrees(+60.08237141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44150"},
        {"Hipparcos Number", "HIP 30458"},
        {"Smithsonian Astrophysical Observation", "SAO 13826"},
    },
    visualMagnitude: 7.10,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.04423950),
        dec: Angle.Degrees(+60.08445206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69912",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69912"},
        {"Smithsonian Astrophysical Observation", "SAO 16332"},
    },
    visualMagnitude: 9.59,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.61515078),
        dec: Angle.Degrees(+60.08459232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52323",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52323"},
        {"Smithsonian Astrophysical Observation", "SAO 15259"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.37247989),
        dec: Angle.Degrees(+60.08593892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139477"},
        {"Hipparcos Number", "HIP 76315"},
        {"Smithsonian Astrophysical Observation", "SAO 16775"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.83267788),
        dec: Angle.Degrees(+60.08738787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 172.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -162.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16088"},
        {"Hipparcos Number", "HIP 12228"},
        {"Geneva Identification System", "GEN# +1.00016088"},
        {"Smithsonian Astrophysical Observation", "SAO 23474"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.35887338),
        dec: Angle.Degrees(+60.08844049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160078"},
        {"Hipparcos Number", "HIP 85964"},
        {"Geneva Identification System", "GEN# +1.00160078"},
        {"Smithsonian Astrophysical Observation", "SAO 17536"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.53802677),
        dec: Angle.Degrees(+60.08969563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -132.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4931"},
        {"Hipparcos Number", "HIP 4075"},
        {"Geneva Identification System", "GEN# +1.00004931"},
        {"Smithsonian Astrophysical Observation", "SAO 21782"},
        {"Wilson Evans Batten Catalogue", "WEB 729"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.06439416),
        dec: Angle.Degrees(+60.08995098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28973"},
        {"Hipparcos Number", "HIP 21544"},
        {"Smithsonian Astrophysical Observation", "SAO 24717"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.38508591),
        dec: Angle.Degrees(+60.09032400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59846",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59846"},
    },
    visualMagnitude: 10.88,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.08055942),
        dec: Angle.Degrees(+60.09375335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212152"},
        {"Hipparcos Number", "HIP 110320"},
        {"Smithsonian Astrophysical Observation", "SAO 34342"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.16995255),
        dec: Angle.Degrees(+60.09378110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46570"},
        {"Hipparcos Number", "HIP 31717"},
        {"Geneva Identification System", "GEN# +1.00046570"},
        {"Smithsonian Astrophysical Observation", "SAO 13904"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.52542957),
        dec: Angle.Degrees(+60.09576694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84633"},
        {"Hipparcos Number", "HIP 48140"},
        {"Smithsonian Astrophysical Observation", "SAO 14993"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.20887689),
        dec: Angle.Degrees(+60.09703026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202380"},
        {"Hipparcos Number", "HIP 104719"},
        {"Geneva Identification System", "GEN# +1.00202380"},
        {"Smithsonian Astrophysical Observation", "SAO 33232"},
        {"Wilson Evans Batten Catalogue", "WEB 19045"},
    },
    visualMagnitude: 6.91,
    bvColour: 2.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.19687474),
        dec: Angle.Degrees(+60.09801033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236580"},
        {"Hipparcos Number", "HIP 4429"},
        {"Smithsonian Astrophysical Observation", "SAO 21856"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.17947665),
        dec: Angle.Degrees(+60.09803503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136244"},
        {"Hipparcos Number", "HIP 74756"},
        {"Smithsonian Astrophysical Observation", "SAO 16666"},
        {"Wilson Evans Batten Catalogue", "WEB 12753"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.16753832),
        dec: Angle.Degrees(+60.09931791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178685"},
        {"Hipparcos Number", "HIP 93781"},
        {"Smithsonian Astrophysical Observation", "SAO 18148"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.48249942),
        dec: Angle.Degrees(+60.09939799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239626"},
        {"Hipparcos Number", "HIP 105113"},
        {"Geneva Identification System", "GEN# +1.00239626"},
        {"Smithsonian Astrophysical Observation", "SAO 33296"},
        {"Wilson Evans Batten Catalogue", "WEB 19093"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.38949072),
        dec: Angle.Degrees(+60.10046013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198386"},
        {"Hipparcos Number", "HIP 102566"},
        {"Smithsonian Astrophysical Observation", "SAO 32892"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.77978379),
        dec: Angle.Degrees(+60.10071185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107933"},
        {"Hipparcos Number", "HIP 60470"},
        {"Geneva Identification System", "GEN# +1.00107933"},
        {"Smithsonian Astrophysical Observation", "SAO 15793"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.95459487),
        dec: Angle.Degrees(+60.10098764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216595"},
        {"Hipparcos Number", "HIP 112998"},
        {"Fundamental Katalog 5th Edition", "FK5 3830"},
        {"Geneva Identification System", "GEN# +1.00216595"},
        {"Smithsonian Astrophysical Observation", "SAO 34921"},
        {"Wilson Evans Batten Catalogue", "WEB 20119"},
    },
    visualMagnitude: 6.01,
    bvColour: 1.748,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.26570720),
        dec: Angle.Degrees(+60.10102327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107792"},
        {"Hipparcos Number", "HIP 60381"},
        {"Smithsonian Astrophysical Observation", "SAO 15785"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.70676476),
        dec: Angle.Degrees(+60.10470542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101439"},
        {"Hipparcos Number", "HIP 56979"},
        {"Geneva Identification System", "GEN# +1.00101439"},
        {"Smithsonian Astrophysical Observation", "SAO 15594"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.21103899),
        dec: Angle.Degrees(+60.10643864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94778"},
        {"Hipparcos Number", "HIP 53569"},
        {"Geneva Identification System", "GEN# +1.00094778"},
        {"Smithsonian Astrophysical Observation", "SAO 15346"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.38058814),
        dec: Angle.Degrees(+60.11047834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237036"},
        {"Hipparcos Number", "HIP 13799"},
        {"Smithsonian Astrophysical Observation", "SAO 23728"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.41151270),
        dec: Angle.Degrees(+60.11250621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20040"},
        {"Hipparcos Number", "HIP 15217"},
        {"Smithsonian Astrophysical Observation", "SAO 23906"},
        {"Wilson Evans Batten Catalogue", "WEB 2932"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.04509334),
        dec: Angle.Degrees(+60.11594967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22535"},
        {"Hipparcos Number", "HIP 17179"},
        {"Smithsonian Astrophysical Observation", "SAO 24151"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.19095766),
        dec: Angle.Degrees(+60.11819773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17986",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2791 AB"},
        {"Henry Draper", "HD 23726"},
        {"Hipparcos Number", "HIP 17986"},
        {"Smithsonian Astrophysical Observation", "SAO 24253"},
        {"Wilson Evans Batten Catalogue", "WEB 3468"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.66339833),
        dec: Angle.Degrees(+60.12299571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54685"},
        {"Hipparcos Number", "HIP 34923"},
        {"Smithsonian Astrophysical Observation", "SAO 14117"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.38753096),
        dec: Angle.Degrees(+60.12387202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93286"},
        {"Hipparcos Number", "HIP 52786"},
        {"Geneva Identification System", "GEN# +1.00093286"},
        {"Smithsonian Astrophysical Observation", "SAO 15290"},
        {"Wilson Evans Batten Catalogue", "WEB 9607"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.87768956),
        dec: Angle.Degrees(+60.12403183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52064",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7855 A"},
        {"Henry Draper", "HD 91948"},
        {"Hipparcos Number", "HIP 52064"},
        {"Smithsonian Astrophysical Observation", "SAO 15243"},
        {"Wilson Evans Batten Catalogue", "WEB 9491"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.58289549),
        dec: Angle.Degrees(+60.12503008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -202.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6048"},
        {"Hipparcos Number", "HIP 4897"},
        {"Geneva Identification System", "GEN# +1.00006048"},
        {"Smithsonian Astrophysical Observation", "SAO 21945"},
        {"Wilson Evans Batten Catalogue", "WEB 960"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.71407750),
        dec: Angle.Degrees(+60.12680841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236542"},
        {"Hipparcos Number", "HIP 3886"},
        {"Smithsonian Astrophysical Observation", "SAO 21746"},
        {"Wilson Evans Batten Catalogue", "WEB 694"},
    },
    visualMagnitude: 9.93,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.47194180),
        dec: Angle.Degrees(+60.12738530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177696"},
        {"Hipparcos Number", "HIP 93462"},
        {"Smithsonian Astrophysical Observation", "SAO 18121"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.52080959),
        dec: Angle.Degrees(+60.12841273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38619",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38619"},
    },
    visualMagnitude: 10.88,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.61719852),
        dec: Angle.Degrees(+60.13322765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220369"},
        {"Hipparcos Number", "HIP 115395"},
        {"Fundamental Katalog 5th Edition", "FK5 3874"},
        {"Geneva Identification System", "GEN# +1.00220369"},
        {"Smithsonian Astrophysical Observation", "SAO 35361"},
        {"Wilson Evans Batten Catalogue", "WEB 20434"},
    },
    visualMagnitude: 5.56,
    bvColour: 1.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.63551965),
        dec: Angle.Degrees(+60.13348919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74428",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9545 AB"},
        {"Henry Draper", "HD 135529"},
        {"Hipparcos Number", "HIP 74428"},
        {"Smithsonian Astrophysical Observation", "SAO 16641"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.16923220),
        dec: Angle.Degrees(+60.13470744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6634"},
        {"Hipparcos Number", "HIP 5341"},
        {"Geneva Identification System", "GEN# +1.00006634"},
        {"Smithsonian Astrophysical Observation", "SAO 22028"},
        {"Wilson Evans Batten Catalogue", "WEB 1153"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.07237664),
        dec: Angle.Degrees(+60.13622638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152360"},
        {"Hipparcos Number", "HIP 82325"},
        {"Geneva Identification System", "GEN# +1.00152360"},
        {"Smithsonian Astrophysical Observation", "SAO 17235"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.31626549),
        dec: Angle.Degrees(+60.13632301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119842"},
        {"Hipparcos Number", "HIP 67002"},
        {"Smithsonian Astrophysical Observation", "SAO 16153"},
        {"Wilson Evans Batten Catalogue", "WEB 11808"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.96787498),
        dec: Angle.Degrees(+60.14554075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45271"},
        {"Hipparcos Number", "HIP 31002"},
        {"Smithsonian Astrophysical Observation", "SAO 13855"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.59401291),
        dec: Angle.Degrees(+60.14649955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211971"},
        {"Hipparcos Number", "HIP 110207"},
        {"Fundamental Katalog 5th Edition", "FK5 5969"},
        {"Geneva Identification System", "GEN# +1.00211971"},
        {"Smithsonian Astrophysical Observation", "SAO 34314"},
        {"Wilson Evans Batten Catalogue", "WEB 19779"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.866,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.85726480),
        dec: Angle.Degrees(+60.14778061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192513"},
        {"Hipparcos Number", "HIP 99538"},
        {"Celescope Catalog", "CEL 4974"},
        {"Geneva Identification System", "GEN# +1.00192513"},
        {"Smithsonian Astrophysical Observation", "SAO 32353"},
    },
    visualMagnitude: 7.89,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.01465414),
        dec: Angle.Degrees(+60.14880643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88759"},
        {"Hipparcos Number", "HIP 50286"},
        {"Geneva Identification System", "GEN# +1.00088759"},
        {"Smithsonian Astrophysical Observation", "SAO 15131"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.01306178),
        dec: Angle.Degrees(+60.15069868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236433"},
        {"Hipparcos Number", "HIP 2354"},
        {"Geneva Identification System", "GEN# +2.01290170"},
        {"Smithsonian Astrophysical Observation", "SAO 21450"},
        {"Wilson Evans Batten Catalogue", "WEB 433"},
        {"New General Catalogue", "NGC 129A"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.52502272),
        dec: Angle.Degrees(+60.15114261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114057"},
        {"Hipparcos Number", "HIP 63996"},
        {"Geneva Identification System", "GEN# +1.00114057"},
        {"Smithsonian Astrophysical Observation", "SAO 15986"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.71494092),
        dec: Angle.Degrees(+60.15491292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240489"},
        {"Hipparcos Number", "HIP 334"},
        {"Celescope Catalog", "CEL 11"},
        {"Geneva Identification System", "GEN# +1.00240489"},
        {"Smithsonian Astrophysical Observation", "SAO 21049"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.06385875),
        dec: Angle.Degrees(+60.15501928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184936"},
        {"Hipparcos Number", "HIP 96164"},
        {"Fundamental Katalog 5th Edition", "FK5 3563"},
        {"Geneva Identification System", "GEN# +1.00184936"},
        {"Smithsonian Astrophysical Observation", "SAO 18395"},
        {"Wilson Evans Batten Catalogue", "WEB 16850"},
    },
    visualMagnitude: 6.30,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.29193749),
        dec: Angle.Degrees(+60.15867782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104163"},
        {"Hipparcos Number", "HIP 58502"},
        {"Geneva Identification System", "GEN# +1.00104163"},
        {"Smithsonian Astrophysical Observation", "SAO 15681"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.96133500),
        dec: Angle.Degrees(+60.15871737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48893"},
        {"Hipparcos Number", "HIP 32725"},
        {"Geneva Identification System", "GEN# +1.00048893"},
        {"Smithsonian Astrophysical Observation", "SAO 13968"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.39991842),
        dec: Angle.Degrees(+60.16305971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184902"},
        {"Hipparcos Number", "HIP 96152"},
        {"Geneva Identification System", "GEN# +1.00184902"},
        {"Smithsonian Astrophysical Observation", "SAO 18393"},
        {"Wilson Evans Batten Catalogue", "WEB 16846"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.25154681),
        dec: Angle.Degrees(+60.16453931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67247",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67247"},
        {"Smithsonian Astrophysical Observation", "SAO 16174"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.73980968),
        dec: Angle.Degrees(+60.16737866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93846"},
        {"Hipparcos Number", "HIP 53045"},
        {"Smithsonian Astrophysical Observation", "SAO 15311"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.79981944),
        dec: Angle.Degrees(+60.16880310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2382",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2382"},
        {"Geneva Identification System", "GEN# +2.01290172"},
    },
    visualMagnitude: 10.90,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.60188723),
        dec: Angle.Degrees(+60.16923902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26077"},
        {"Hipparcos Number", "HIP 19537"},
        {"Smithsonian Astrophysical Observation", "SAO 13053"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.77254059),
        dec: Angle.Degrees(+60.17359046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54526",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54526"},
        {"Smithsonian Astrophysical Observation", "SAO 15413"},
    },
    visualMagnitude: 9.97,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.35868966),
        dec: Angle.Degrees(+60.17720278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100759",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13864 AB"},
        {"Henry Draper", "HD 195013"},
        {"Hipparcos Number", "HIP 100759"},
        {"Smithsonian Astrophysical Observation", "SAO 18858"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.42824880),
        dec: Angle.Degrees(+60.17757797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32186"},
        {"Hipparcos Number", "HIP 23648"},
        {"Smithsonian Astrophysical Observation", "SAO 13360"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.24081955),
        dec: Angle.Degrees(+60.17947852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207872"},
        {"Hipparcos Number", "HIP 107789"},
        {"Geneva Identification System", "GEN# +1.00207872"},
        {"Smithsonian Astrophysical Observation", "SAO 33799"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.53882565),
        dec: Angle.Degrees(+60.18002348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33924"},
        {"Hipparcos Number", "HIP 24658"},
        {"Geneva Identification System", "GEN# +1.00033924"},
        {"Smithsonian Astrophysical Observation", "SAO 13444"},
        {"Wilson Evans Batten Catalogue", "WEB 4771"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.36487564),
        dec: Angle.Degrees(+60.18200071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -132.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78297"},
        {"Hipparcos Number", "HIP 45011"},
        {"Smithsonian Astrophysical Observation", "SAO 14790"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.51612087),
        dec: Angle.Degrees(+60.19184075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84911"},
        {"Hipparcos Number", "HIP 48283"},
        {"Smithsonian Astrophysical Observation", "SAO 15001"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.66504285),
        dec: Angle.Degrees(+60.19717938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217711"},
        {"Hipparcos Number", "HIP 113700"},
        {"Smithsonian Astrophysical Observation", "SAO 35072"},
        {"Wilson Evans Batten Catalogue", "WEB 20203"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.42332111),
        dec: Angle.Degrees(+60.19723175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237097"},
        {"Hipparcos Number", "HIP 15202"},
        {"Geneva Identification System", "GEN# +1.00237097"},
        {"Smithsonian Astrophysical Observation", "SAO 12678"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.99473415),
        dec: Angle.Degrees(+60.20072218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107767",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107767"},
        {"Smithsonian Astrophysical Observation", "SAO 33798"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.47437638),
        dec: Angle.Degrees(+60.20266820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133388"},
        {"Hipparcos Number", "HIP 73507"},
        {"Fundamental Katalog 5th Edition", "FK5 3188"},
        {"Geneva Identification System", "GEN# +1.00133388"},
        {"Smithsonian Astrophysical Observation", "SAO 16574"},
        {"Wilson Evans Batten Catalogue", "WEB 12579"},
    },
    visualMagnitude: 5.91,
    bvColour: 0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.36295558),
        dec: Angle.Degrees(+60.20442421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142194"},
        {"Hipparcos Number", "HIP 77544"},
        {"Smithsonian Astrophysical Observation", "SAO 16865"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.49698494),
        dec: Angle.Degrees(+60.20472763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236429"},
        {"Hipparcos Number", "HIP 2347"},
        {"Geneva Identification System", "GEN# +2.01290120"},
        {"Geneva Identification System 2", "GEN# +2.01290200"},
        {"Smithsonian Astrophysical Observation", "SAO 21446"},
        {"Wilson Evans Batten Catalogue", "WEB 431"},
        {"New General Catalogue", "NGC 129 120"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.49413319),
        dec: Angle.Degrees(+60.21196536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9634"},
        {"Hipparcos Number", "HIP 7458"},
        {"Geneva Identification System", "GEN# +1.00009634"},
        {"Smithsonian Astrophysical Observation", "SAO 22421"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.02158864),
        dec: Angle.Degrees(+60.21280896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82969"},
        {"Hipparcos Number", "HIP 47231"},
        {"Geneva Identification System", "GEN# +1.00082969"},
        {"Smithsonian Astrophysical Observation", "SAO 14941"},
    },
    visualMagnitude: 6.41,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.40634808),
        dec: Angle.Degrees(+60.21376054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239595"},
        {"Hipparcos Number", "HIP 104567"},
        {"Geneva Identification System", "GEN# +1.00239595"},
        {"Smithsonian Astrophysical Observation", "SAO 19235"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.74026687),
        dec: Angle.Degrees(+60.22120841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54122"},
        {"Hipparcos Number", "HIP 34732"},
        {"Smithsonian Astrophysical Observation", "SAO 14109"},
        {"Wilson Evans Batten Catalogue", "WEB 6942"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.86932304),
        dec: Angle.Degrees(+60.22482780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127929"},
        {"Hipparcos Number", "HIP 71040"},
        {"Fundamental Katalog 5th Edition", "FK5 536"},
        {"Geneva Identification System", "GEN# +1.00127929"},
        {"Smithsonian Astrophysical Observation", "SAO 16411"},
        {"Wilson Evans Batten Catalogue", "WEB 12287"},
    },
    visualMagnitude: 6.26,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.92861754),
        dec: Angle.Degrees(+60.22558784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129865"},
        {"Hipparcos Number", "HIP 71911"},
        {"Geneva Identification System", "GEN# +1.00129865"},
        {"Smithsonian Astrophysical Observation", "SAO 16470"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.63171051),
        dec: Angle.Degrees(+60.23098624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6686",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Ruchbah"},
        {"Henry Draper", "HD 8538"},
        {"Hipparcos Number", "HIP 6686"},
        {"Celescope Catalog", "CEL 139"},
        {"Fundamental Katalog 5th Edition", "FK5 48"},
        {"Geneva Identification System", "GEN# +1.00008538"},
        {"Smithsonian Astrophysical Observation", "SAO 22268"},
        {"Wilson Evans Batten Catalogue", "WEB 1460"},
    },
    visualMagnitude: 2.66,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.45251267),
        dec: Angle.Degrees(+60.23540347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 297.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1844"},
        {"Hipparcos Number", "HIP 1840"},
        {"Geneva Identification System", "GEN# +1.00001844"},
        {"Smithsonian Astrophysical Observation", "SAO 21345"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.82445053),
        dec: Angle.Degrees(+60.23563853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237076"},
        {"Hipparcos Number", "HIP 14687"},
        {"Smithsonian Astrophysical Observation", "SAO 12629"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.43201069),
        dec: Angle.Degrees(+60.23856558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31732",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31732"},
        {"Smithsonian Astrophysical Observation", "SAO 13908"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.58487476),
        dec: Angle.Degrees(+60.24065822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -195.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12482"},
        {"Hipparcos Number", "HIP 9659"},
        {"Geneva Identification System", "GEN# +1.00012482"},
        {"Smithsonian Astrophysical Observation", "SAO 12103"},
        {"Wilson Evans Batten Catalogue", "WEB 2028"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.06948079),
        dec: Angle.Degrees(+60.24447153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34128"},
        {"Hipparcos Number", "HIP 24794"},
        {"Geneva Identification System", "GEN# +1.00034128J"},
        {"Smithsonian Astrophysical Observation", "SAO 13455"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.73144782),
        dec: Angle.Degrees(+60.24864279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50674",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50674"},
        {"Smithsonian Astrophysical Observation", "SAO 15149"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.21351469),
        dec: Angle.Degrees(+60.25037540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8965"},
        {"Hipparcos Number", "HIP 6979"},
        {"Celescope Catalog", "CEL 142"},
        {"Geneva Identification System", "GEN# +1.00008965"},
        {"Smithsonian Astrophysical Observation", "SAO 22327"},
        {"Wilson Evans Batten Catalogue", "WEB 1511"},
    },
    visualMagnitude: 7.29,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.46398653),
        dec: Angle.Degrees(+60.25127679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116203"},
        {"Hipparcos Number", "HIP 65134"},
        {"Geneva Identification System", "GEN# +1.00116203"},
        {"Smithsonian Astrophysical Observation", "SAO 16054"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.21128906),
        dec: Angle.Degrees(+60.25279552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139438"},
        {"Hipparcos Number", "HIP 76289"},
        {"Geneva Identification System", "GEN# +1.00139438"},
        {"Smithsonian Astrophysical Observation", "SAO 16772"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.75740420),
        dec: Angle.Degrees(+60.25488182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16177",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2538 AB"},
        {"Henry Draper", "HD 21203"},
        {"Hipparcos Number", "HIP 16177"},
        {"Geneva Identification System", "GEN# +1.00021203J"},
        {"Smithsonian Astrophysical Observation", "SAO 12770"},
        {"Wilson Evans Batten Catalogue", "WEB 3082"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.09818390),
        dec: Angle.Degrees(+60.25572630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27705"},
        {"Hipparcos Number", "HIP 20687"},
        {"Smithsonian Astrophysical Observation", "SAO 13142"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.46835524),
        dec: Angle.Degrees(+60.25587057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70426",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70426"},
    },
    visualMagnitude: 9.60,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.11306817),
        dec: Angle.Degrees(+60.25659088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -202.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 117.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201063"},
        {"Hipparcos Number", "HIP 104034"},
        {"Geneva Identification System", "GEN# +1.00201063"},
        {"Smithsonian Astrophysical Observation", "SAO 19174"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.14935062),
        dec: Angle.Degrees(+60.25665310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27167",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27167"},
    },
    visualMagnitude: 9.91,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.37385680),
        dec: Angle.Degrees(+60.26128464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118202"},
        {"Hipparcos Number", "HIP 66165"},
        {"Smithsonian Astrophysical Observation", "SAO 16109"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.44111044),
        dec: Angle.Degrees(+60.26206820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47632",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7484 AB"},
        {"Hipparcos Number", "HIP 47632"},
        {"Smithsonian Astrophysical Observation", "SAO 14969"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.67927568),
        dec: Angle.Degrees(+60.26747248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35607"},
        {"Hipparcos Number", "HIP 25748"},
        {"Geneva Identification System", "GEN# +1.00035607"},
        {"Smithsonian Astrophysical Observation", "SAO 13517"},
        {"Wilson Evans Batten Catalogue", "WEB 4999"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.46458685),
        dec: Angle.Degrees(+60.26859874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96215",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12637 B"},
        {"Henry Draper", "HD 185080"},
        {"Hipparcos Number", "HIP 96215"},
        {"Smithsonian Astrophysical Observation", "SAO 18399"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.48730629),
        dec: Angle.Degrees(+60.27144002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98054"},
        {"Hipparcos Number", "HIP 55148"},
        {"Smithsonian Astrophysical Observation", "SAO 15462"},
    },
    visualMagnitude: 6.65,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.36225765),
        dec: Angle.Degrees(+60.27178687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86042"},
        {"Hipparcos Number", "HIP 48870"},
        {"Smithsonian Astrophysical Observation", "SAO 15037"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.50885032),
        dec: Angle.Degrees(+60.27328719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220102"},
        {"Hipparcos Number", "HIP 115228"},
        {"Celescope Catalog", "CEL 5600"},
        {"Geneva Identification System", "GEN# +1.00220102"},
        {"Smithsonian Astrophysical Observation", "SAO 20568"},
        {"Wilson Evans Batten Catalogue", "WEB 20413"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.08675904),
        dec: Angle.Degrees(+60.27476942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7586"},
        {"Hipparcos Number", "HIP 6002"},
        {"Geneva Identification System", "GEN# +1.00007586"},
        {"Smithsonian Astrophysical Observation", "SAO 11676"},
        {"Wilson Evans Batten Catalogue", "WEB 1361"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.29959504),
        dec: Angle.Degrees(+60.27487577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96216",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12637 A"},
        {"Henry Draper", "HD 185081"},
        {"Hipparcos Number", "HIP 96216"},
        {"Smithsonian Astrophysical Observation", "SAO 18402"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.48993636),
        dec: Angle.Degrees(+60.27644064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12650"},
        {"Hipparcos Number", "HIP 9795"},
        {"Geneva Identification System", "GEN# +1.00012650"},
        {"Smithsonian Astrophysical Observation", "SAO 12124"},
        {"Wilson Evans Batten Catalogue", "WEB 2059"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.49374499),
        dec: Angle.Degrees(+60.27839900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3467",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3467"},
        {"Geneva Identification System", "GEN# +0.05900109"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.08432471),
        dec: Angle.Degrees(+60.27962495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48422",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48422"},
    },
    visualMagnitude: 12.56,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.06837823),
        dec: Angle.Degrees(+60.28076319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -384.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -368.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203012"},
        {"Hipparcos Number", "HIP 105070"},
        {"Smithsonian Astrophysical Observation", "SAO 19284"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.27039431),
        dec: Angle.Degrees(+60.28079862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86150",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86150"},
        {"Renson", "Renson 45200"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.07654219),
        dec: Angle.Degrees(+60.28122692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21014"},
        {"Hipparcos Number", "HIP 16040"},
        {"Geneva Identification System", "GEN# +1.00021014"},
        {"Smithsonian Astrophysical Observation", "SAO 12763"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.64272638),
        dec: Angle.Degrees(+60.28156089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106924",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106924"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.81916516),
        dec: Angle.Degrees(+60.28326733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -381.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 233.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6793",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1145 A"},
        {"Henry Draper", "HD 236740"},
        {"Hipparcos Number", "HIP 6793"},
        {"Geneva Identification System", "GEN# +1.00236740"},
        {"Smithsonian Astrophysical Observation", "SAO 11765"},
        {"Wilson Evans Batten Catalogue", "WEB 1483"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.85966642),
        dec: Angle.Degrees(+60.28448257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236382"},
        {"Hipparcos Number", "HIP 1637"},
        {"Celescope Catalog", "CEL 60"},
        {"Geneva Identification System", "GEN# +1.00236382"},
        {"Smithsonian Astrophysical Observation", "SAO 11122"},
        {"Wilson Evans Batten Catalogue", "WEB 299"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.12533855),
        dec: Angle.Degrees(+60.28545969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44601",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44601"},
        {"Smithsonian Astrophysical Observation", "SAO 14755"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.30994718),
        dec: Angle.Degrees(+60.28695606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239331"},
        {"Hipparcos Number", "HIP 99108"},
        {"Smithsonian Astrophysical Observation", "SAO 18719"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.81939330),
        dec: Angle.Degrees(+60.29041462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239662"},
        {"Hipparcos Number", "HIP 105751"},
        {"Smithsonian Astrophysical Observation", "SAO 19394"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.27982541),
        dec: Angle.Degrees(+60.29232088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240450"},
        {"Hipparcos Number", "HIP 118012"},
        {"Celescope Catalog", "CEL 5716"},
        {"Geneva Identification System", "GEN# +1.00240450"},
        {"Smithsonian Astrophysical Observation", "SAO 20944"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.06436204),
        dec: Angle.Degrees(+60.29254888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112858"},
        {"Hipparcos Number", "HIP 63338"},
        {"Smithsonian Astrophysical Observation", "SAO 15957"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.69075542),
        dec: Angle.Degrees(+60.29350579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12243"},
        {"Hipparcos Number", "HIP 9491"},
        {"Celescope Catalog", "CEL 185"},
        {"Geneva Identification System", "GEN# +1.00012243"},
        {"Smithsonian Astrophysical Observation", "SAO 12094"},
        {"Wilson Evans Batten Catalogue", "WEB 1990"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.52769622),
        dec: Angle.Degrees(+60.29488550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37607",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37607"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.836,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.73955386),
        dec: Angle.Degrees(+60.29563830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239743"},
        {"Hipparcos Number", "HIP 107199"},
        {"Geneva Identification System", "GEN# +1.00239743"},
        {"Smithsonian Astrophysical Observation", "SAO 19594"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.69430542),
        dec: Angle.Degrees(+60.29592590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38052",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6354 AB"},
        {"Henry Draper", "HD 62522"},
        {"Hipparcos Number", "HIP 38052"},
        {"Geneva Identification System", "GEN# +1.00062522J"},
        {"Smithsonian Astrophysical Observation", "SAO 14330"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.98852194),
        dec: Angle.Degrees(+60.29623846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209145"},
        {"Hipparcos Number", "HIP 108546"},
        {"Geneva Identification System", "GEN# +1.00209145"},
        {"Smithsonian Astrophysical Observation", "SAO 19778"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.83197301),
        dec: Angle.Degrees(+60.29766753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77212",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77212"},
        {"Smithsonian Astrophysical Observation", "SAO 16841"},
    },
    visualMagnitude: 10.16,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.47306624),
        dec: Angle.Degrees(+60.29925083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148509"},
        {"Hipparcos Number", "HIP 80429"},
        {"Geneva Identification System", "GEN# +1.00148509"},
        {"Smithsonian Astrophysical Observation", "SAO 17082"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.25569120),
        dec: Angle.Degrees(+60.30364144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239375"},
        {"Hipparcos Number", "HIP 100028"},
        {"Smithsonian Astrophysical Observation", "SAO 18794"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.41194948),
        dec: Angle.Degrees(+60.30652089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3513",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 621 AB"},
        {"Henry Draper", "HD 4173"},
        {"Hipparcos Number", "HIP 3513"},
        {"Smithsonian Astrophysical Observation", "SAO 11365"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.20975198),
        dec: Angle.Degrees(+60.30918398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236484"},
        {"Hipparcos Number", "HIP 2951"},
        {"Smithsonian Astrophysical Observation", "SAO 11300"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.37318404),
        dec: Angle.Degrees(+60.31050803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18766"},
        {"Hipparcos Number", "HIP 14254"},
        {"Geneva Identification System", "GEN# +1.00018766"},
        {"Smithsonian Astrophysical Observation", "SAO 12585"},
        {"Wilson Evans Batten Catalogue", "WEB 2793"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.95271042),
        dec: Angle.Degrees(+60.31243525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161990"},
        {"Hipparcos Number", "HIP 86855"},
        {"Geneva Identification System", "GEN# +1.00161990"},
        {"Smithsonian Astrophysical Observation", "SAO 17622"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.19094870),
        dec: Angle.Degrees(+60.31283383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 102.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236655"},
        {"Hipparcos Number", "HIP 5653"},
        {"Geneva Identification System", "GEN# +1.00236655"},
        {"Smithsonian Astrophysical Observation", "SAO 11633"},
        {"Wilson Evans Batten Catalogue", "WEB 1277"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.15845797),
        dec: Angle.Degrees(+60.31297387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223200"},
        {"Hipparcos Number", "HIP 117310"},
        {"Celescope Catalog", "CEL 5673"},
        {"Geneva Identification System", "GEN# +1.00223200"},
        {"Smithsonian Astrophysical Observation", "SAO 20846"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.80504254),
        dec: Angle.Degrees(+60.31467917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111456"},
        {"Hipparcos Number", "HIP 62512"},
        {"Geneva Identification System", "GEN# +1.00111456"},
        {"Smithsonian Astrophysical Observation", "SAO 15907"},
        {"Wilson Evans Batten Catalogue", "WEB 11095"},
    },
    visualMagnitude: 5.83,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.16390269),
        dec: Angle.Degrees(+60.31989667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176759"},
        {"Hipparcos Number", "HIP 93112"},
        {"Smithsonian Astrophysical Observation", "SAO 18087"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.52415683),
        dec: Angle.Degrees(+60.32238264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11188",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11188"},
    },
    visualMagnitude: 11.69,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.02359415),
        dec: Angle.Degrees(+60.32250761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237037"},
        {"Hipparcos Number", "HIP 13807"},
        {"Smithsonian Astrophysical Observation", "SAO 12537"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.44499508),
        dec: Angle.Degrees(+60.32412721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65339"},
        {"Hipparcos Number", "HIP 39261"},
        {"Fundamental Katalog 5th Edition", "FK5 302"},
        {"Geneva Identification System", "GEN# +1.00065339"},
        {"Renson", "Renson 17910"},
        {"Smithsonian Astrophysical Observation", "SAO 14402"},
        {"Wilson Evans Batten Catalogue", "WEB 7694"},
    },
    visualMagnitude: 6.02,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.42705665),
        dec: Angle.Degrees(+60.32440752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3489"},
        {"Hipparcos Number", "HIP 3030"},
        {"Geneva Identification System", "GEN# +1.00003489"},
        {"Smithsonian Astrophysical Observation", "SAO 11306"},
        {"Wilson Evans Batten Catalogue", "WEB 543"},
    },
    visualMagnitude: 6.77,
    bvColour: 1.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.63935774),
        dec: Angle.Degrees(+60.32478527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139282"},
        {"Hipparcos Number", "HIP 76214"},
        {"Smithsonian Astrophysical Observation", "SAO 16768"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.53143910),
        dec: Angle.Degrees(+60.32484883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56709"},
        {"Hipparcos Number", "HIP 35697"},
        {"Geneva Identification System", "GEN# +1.00056709"},
        {"Smithsonian Astrophysical Observation", "SAO 14166"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.48298950),
        dec: Angle.Degrees(+60.32592607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3283"},
        {"Hipparcos Number", "HIP 2876"},
        {"Geneva Identification System", "GEN# +1.00003283"},
        {"Smithsonian Astrophysical Observation", "SAO 11291"},
        {"Wilson Evans Batten Catalogue", "WEB 518"},
    },
    visualMagnitude: 5.78,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.11392475),
        dec: Angle.Degrees(+60.32621728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102416",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102416"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.30603503),
        dec: Angle.Degrees(+60.32660800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 75.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208173"},
        {"Hipparcos Number", "HIP 107967"},
        {"Smithsonian Astrophysical Observation", "SAO 19693"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.10394797),
        dec: Angle.Degrees(+60.32966190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 93.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67500"},
        {"Hipparcos Number", "HIP 40121"},
        {"Smithsonian Astrophysical Observation", "SAO 14455"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.93053656),
        dec: Angle.Degrees(+60.33035436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26685"},
        {"Hipparcos Number", "HIP 19965"},
        {"Smithsonian Astrophysical Observation", "SAO 13076"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.21774916),
        dec: Angle.Degrees(+60.33217820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48948"},
        {"Hipparcos Number", "HIP 32769"},
        {"Geneva Identification System", "GEN# +1.00048948"},
        {"Smithsonian Astrophysical Observation", "SAO 13971"},
        {"Wilson Evans Batten Catalogue", "WEB 6595"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.48636188),
        dec: Angle.Degrees(+60.33454634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 251.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 410.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213757"},
        {"Hipparcos Number", "HIP 111253"},
        {"Geneva Identification System", "GEN# +1.00213757"},
        {"Smithsonian Astrophysical Observation", "SAO 20135"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.08987596),
        dec: Angle.Degrees(+60.33458905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106450",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15094 AB"},
        {"Henry Draper", "HD 205522"},
        {"Hipparcos Number", "HIP 106450"},
        {"Smithsonian Astrophysical Observation", "SAO 19493"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.40988298),
        dec: Angle.Degrees(+60.33518380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1457"},
        {"Hipparcos Number", "HIP 1526"},
        {"Geneva Identification System", "GEN# +1.00001457"},
        {"Smithsonian Astrophysical Observation", "SAO 11104"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.75212096),
        dec: Angle.Degrees(+60.33529505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75973"},
        {"Hipparcos Number", "HIP 43863"},
        {"Smithsonian Astrophysical Observation", "SAO 14702"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.03405715),
        dec: Angle.Degrees(+60.33638284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23894"},
        {"Hipparcos Number", "HIP 18088"},
        {"Smithsonian Astrophysical Observation", "SAO 12939"},
        {"Wilson Evans Batten Catalogue", "WEB 3488"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.00027752),
        dec: Angle.Degrees(+60.33653242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136848"},
        {"Hipparcos Number", "HIP 75037"},
        {"Geneva Identification System", "GEN# +1.00136848"},
        {"Smithsonian Astrophysical Observation", "SAO 16692"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.99834666),
        dec: Angle.Degrees(+60.33964389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1222",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1222"},
    },
    visualMagnitude: 10.55,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.80972665),
        dec: Angle.Degrees(+60.34047401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1148",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 176 AB"},
        {"Henry Draper", "HD 236348"},
        {"Hipparcos Number", "HIP 1148"},
        {"Geneva Identification System", "GEN# +1.00236348J"},
        {"Smithsonian Astrophysical Observation", "SAO 11057"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.58886546),
        dec: Angle.Degrees(+60.34163069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 182.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62976"},
        {"Hipparcos Number", "HIP 38249"},
        {"Geneva Identification System", "GEN# +1.00062976"},
        {"Smithsonian Astrophysical Observation", "SAO 14338"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.53270188),
        dec: Angle.Degrees(+60.34208833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12569"},
        {"Hipparcos Number", "HIP 9726"},
        {"Geneva Identification System", "GEN# +1.00012569"},
        {"Smithsonian Astrophysical Observation", "SAO 12116"},
        {"Wilson Evans Batten Catalogue", "WEB 2045"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.27884572),
        dec: Angle.Degrees(+60.34576222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -159.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18869",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18869"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.67409282),
        dec: Angle.Degrees(+60.34883348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183077"},
        {"Hipparcos Number", "HIP 95375"},
        {"Geneva Identification System", "GEN# +1.00183077"},
        {"Smithsonian Astrophysical Observation", "SAO 18324"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.04077014),
        dec: Angle.Degrees(+60.34890266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173976"},
        {"Hipparcos Number", "HIP 91936"},
        {"Smithsonian Astrophysical Observation", "SAO 17999"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.12557428),
        dec: Angle.Degrees(+60.34909999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24151"},
        {"Hipparcos Number", "HIP 18242"},
        {"Smithsonian Astrophysical Observation", "SAO 12953"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.52664529),
        dec: Angle.Degrees(+60.35003891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23074"},
        {"Hipparcos Number", "HIP 17540"},
        {"Geneva Identification System", "GEN# +1.00023074"},
        {"Smithsonian Astrophysical Observation", "SAO 12889"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.33775642),
        dec: Angle.Degrees(+60.35094996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117587"},
        {"Hipparcos Number", "HIP 65858"},
        {"Geneva Identification System", "GEN# +1.00117587"},
        {"Smithsonian Astrophysical Observation", "SAO 16091"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.49505614),
        dec: Angle.Degrees(+60.35348526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8629",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1461 AB"},
        {"Henry Draper", "HD 11126"},
        {"Hipparcos Number", "HIP 8629"},
        {"Geneva Identification System", "GEN# +1.00011126J"},
        {"Smithsonian Astrophysical Observation", "SAO 12009"},
        {"Wilson Evans Batten Catalogue", "WEB 1826"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.83047207),
        dec: Angle.Degrees(+60.35362787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224855"},
        {"Hipparcos Number", "HIP 99"},
        {"Smithsonian Astrophysical Observation", "SAO 21002"},
        {"Wilson Evans Batten Catalogue", "WEB 10"},
    },
    visualMagnitude: 7.04,
    bvColour: 2.835,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.31601620),
        dec: Angle.Degrees(+60.35529798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107052"},
        {"Hipparcos Number", "HIP 60004"},
        {"Geneva Identification System", "GEN# +1.00107052"},
        {"Smithsonian Astrophysical Observation", "SAO 15765"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.59618408),
        dec: Angle.Degrees(+60.35618452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4755",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 832 AB"},
        {"Henry Draper", "HD 5851"},
        {"Hipparcos Number", "HIP 4755"},
        {"Geneva Identification System", "GEN# +1.00005851J"},
        {"Smithsonian Astrophysical Observation", "SAO 11523"},
        {"Wilson Evans Batten Catalogue", "WEB 901"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.27689948),
        dec: Angle.Degrees(+60.35850979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65863",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65863"},
    },
    visualMagnitude: 10.48,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)30, 00.4600),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)21, 32.500)
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
    primaryId: "HIP 112646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216091"},
        {"Hipparcos Number", "HIP 112646"},
        {"Smithsonian Astrophysical Observation", "SAO 20254"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.21935237),
        dec: Angle.Degrees(+60.36060738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153166"},
        {"Hipparcos Number", "HIP 82677"},
        {"Fundamental Katalog 5th Edition", "FK5 3344"},
        {"Geneva Identification System", "GEN# +1.00153166"},
        {"Smithsonian Astrophysical Observation", "SAO 17263"},
        {"Wilson Evans Batten Catalogue", "WEB 13964"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.50775234),
        dec: Angle.Degrees(+60.36229729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4440",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 784 AB"},
        {"Henry Draper", "HD 5408"},
        {"Hipparcos Number", "HIP 4440"},
        {"Geneva Identification System", "GEN# +1.00005408J"},
        {"Smithsonian Astrophysical Observation", "SAO 11484"},
        {"Wilson Evans Batten Catalogue", "WEB 796"},
    },
    visualMagnitude: 5.56,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.19558745),
        dec: Angle.Degrees(+60.36284769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46394",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46394"},
        {"Smithsonian Astrophysical Observation", "SAO 14881"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.887,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.90613330),
        dec: Angle.Degrees(+60.36807609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63130",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63130"},
        {"Smithsonian Astrophysical Observation", "SAO 15943"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.794,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.01863294),
        dec: Angle.Degrees(+60.36937103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -222.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236871"},
        {"Hipparcos Number", "HIP 8297"},
        {"Geneva Identification System", "GEN# +1.00236871"},
        {"Smithsonian Astrophysical Observation", "SAO 11978"},
    },
    visualMagnitude: 8.48,
    bvColour: 2.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.75005115),
        dec: Angle.Degrees(+60.37232732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204964"},
        {"Hipparcos Number", "HIP 106121"},
        {"Celescope Catalog", "CEL 5326"},
        {"Geneva Identification System", "GEN# +1.00204964"},
        {"Smithsonian Astrophysical Observation", "SAO 19452"},
        {"Wilson Evans Batten Catalogue", "WEB 19232"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.44337334),
        dec: Angle.Degrees(+60.37866179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39781"},
        {"Hipparcos Number", "HIP 28293"},
        {"Geneva Identification System", "GEN# +1.00039781"},
        {"Smithsonian Astrophysical Observation", "SAO 13668"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.69283221),
        dec: Angle.Degrees(+60.38012621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136882"},
        {"Hipparcos Number", "HIP 75042"},
        {"Smithsonian Astrophysical Observation", "SAO 16694"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.02133681),
        dec: Angle.Degrees(+60.38020814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40474",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6680 A"},
        {"Henry Draper", "HD 68457"},
        {"Hipparcos Number", "HIP 40474"},
        {"Geneva Identification System", "GEN# +1.00068457"},
        {"Renson", "Renson 18950"},
        {"Smithsonian Astrophysical Observation", "SAO 14479"},
        {"Wilson Evans Batten Catalogue", "WEB 7880"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.96049771),
        dec: Angle.Degrees(+60.38058320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239974"},
        {"Hipparcos Number", "HIP 111037"},
        {"Smithsonian Astrophysical Observation", "SAO 20103"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.42770019),
        dec: Angle.Degrees(+60.38096204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239692"},
        {"Hipparcos Number", "HIP 106202"},
        {"Smithsonian Astrophysical Observation", "SAO 19462"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.67464284),
        dec: Angle.Degrees(+60.38166201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73734",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73734"},
    },
    visualMagnitude: 11.00,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.08033108),
        dec: Angle.Degrees(+60.38415455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -654.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 177.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116109"},
        {"Hipparcos Number", "HIP 65065"},
        {"Geneva Identification System", "GEN# +1.00116109"},
        {"Smithsonian Astrophysical Observation", "SAO 16047"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.05056386),
        dec: Angle.Degrees(+60.38599384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13308",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2165 AB"},
        {"Henry Draper", "HD 17520"},
        {"Hipparcos Number", "HIP 13308"},
        {"Geneva Identification System", "GEN# +3.18480002"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.81020145),
        dec: Angle.Degrees(+60.38608060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127411"},
        {"Hipparcos Number", "HIP 70819"},
        {"Smithsonian Astrophysical Observation", "SAO 16394"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.24173143),
        dec: Angle.Degrees(+60.38640446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88973",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88973"},
        {"Smithsonian Astrophysical Observation", "SAO 17789"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.757,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.41133325),
        dec: Angle.Degrees(+60.39166471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26061"},
        {"Hipparcos Number", "HIP 19544"},
        {"Smithsonian Astrophysical Observation", "SAO 13054"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.78839446),
        dec: Angle.Degrees(+60.39591245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163466"},
        {"Hipparcos Number", "HIP 87478"},
        {"Geneva Identification System", "GEN# +1.00163466"},
        {"Smithsonian Astrophysical Observation", "SAO 17664"},
        {"Wilson Evans Batten Catalogue", "WEB 14754"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.10573350),
        dec: Angle.Degrees(+60.39627063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127822"},
        {"Hipparcos Number", "HIP 70982"},
        {"Smithsonian Astrophysical Observation", "SAO 16408"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.77521766),
        dec: Angle.Degrees(+60.39810730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76077"},
        {"Hipparcos Number", "HIP 43931"},
        {"Geneva Identification System", "GEN# +1.00076077"},
        {"Smithsonian Astrophysical Observation", "SAO 14708"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.23404643),
        dec: Angle.Degrees(+60.39826172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237007"},
        {"Hipparcos Number", "HIP 13255"},
        {"Geneva Identification System", "GEN# +3.18480003"},
        {"Smithsonian Astrophysical Observation", "SAO 12463"},
        {"Wilson Evans Batten Catalogue", "WEB 2660"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.64542969),
        dec: Angle.Degrees(+60.40186638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236416"},
        {"Hipparcos Number", "HIP 2131"},
        {"Geneva Identification System", "GEN# +1.00236416"},
        {"Smithsonian Astrophysical Observation", "SAO 11204"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.75751592),
        dec: Angle.Degrees(+60.40253424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 147.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 114.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45863",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45863"},
        {"Smithsonian Astrophysical Observation", "SAO 14853"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.847,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.27953377),
        dec: Angle.Degrees(+60.40336963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -205.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -153.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192017"},
        {"Hipparcos Number", "HIP 99321"},
        {"Geneva Identification System", "GEN# +1.00192017"},
        {"Smithsonian Astrophysical Observation", "SAO 18737"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.39748983),
        dec: Angle.Degrees(+60.40455728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21044"},
        {"Hipparcos Number", "HIP 16057"},
        {"Smithsonian Astrophysical Observation", "SAO 12764"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.70261568),
        dec: Angle.Degrees(+60.40505742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69294",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9151 A"},
        {"Henry Draper", "HD 124345"},
        {"Hipparcos Number", "HIP 69294"},
        {"Smithsonian Astrophysical Observation", "SAO 16299"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.75174115),
        dec: Angle.Degrees(+60.40747883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236815"},
        {"Hipparcos Number", "HIP 7720"},
        {"Geneva Identification System", "GEN# +1.00236815"},
        {"Smithsonian Astrophysical Observation", "SAO 11896"},
        {"Wilson Evans Batten Catalogue", "WEB 1657"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.83850269),
        dec: Angle.Degrees(+60.40842960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16630",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2598 AB"},
        {"Henry Draper", "HD 21801"},
        {"Hipparcos Number", "HIP 16630"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.49589401),
        dec: Angle.Degrees(+60.40890220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167387"},
        {"Hipparcos Number", "HIP 89104"},
        {"Fundamental Katalog 5th Edition", "FK5 3449"},
        {"Geneva Identification System", "GEN# +1.00167387"},
        {"Smithsonian Astrophysical Observation", "SAO 17803"},
        {"Wilson Evans Batten Catalogue", "WEB 15128"},
    },
    visualMagnitude: 6.50,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.77984068),
        dec: Angle.Degrees(+60.40952138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106222"},
        {"Hipparcos Number", "HIP 59577"},
        {"Smithsonian Astrophysical Observation", "SAO 15739"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.26171378),
        dec: Angle.Degrees(+60.40991751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17418",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17418"},
        {"Geneva Identification System", "GEN# +0.05900704"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.97885459),
        dec: Angle.Degrees(+60.41083811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 146.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -190.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221639"},
        {"Hipparcos Number", "HIP 116251"},
        {"Geneva Identification System", "GEN# +1.00221639"},
        {"Smithsonian Astrophysical Observation", "SAO 20699"},
        {"Wilson Evans Batten Catalogue", "WEB 20544"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.33593332),
        dec: Angle.Degrees(+60.41085235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 102.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65518"},
        {"Hipparcos Number", "HIP 39335"},
        {"Geneva Identification System", "GEN# +1.00065518"},
        {"Smithsonian Astrophysical Observation", "SAO 14410"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.61914266),
        dec: Angle.Degrees(+60.41595923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13296",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2161 AB"},
        {"Aitken 2", "ADS 2161"},
        {"Henry Draper", "HD 17505"},
        {"Hipparcos Number", "HIP 13296"},
        {"Geneva Identification System", "GEN# +3.18480001"},
        {"Smithsonian Astrophysical Observation", "SAO 12470"},
        {"Wilson Evans Batten Catalogue", "WEB 2666"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.78323435),
        dec: Angle.Degrees(+60.41774439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240211"},
        {"Hipparcos Number", "HIP 114438"},
        {"Smithsonian Astrophysical Observation", "SAO 20471"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.64321375),
        dec: Angle.Degrees(+60.42095715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9411",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1592 AB"},
        {"Henry Draper", "HD 12122"},
        {"Hipparcos Number", "HIP 9411"},
        {"Geneva Identification System", "GEN# +1.00012122J"},
        {"Smithsonian Astrophysical Observation", "SAO 12084"},
        {"Wilson Evans Batten Catalogue", "WEB 1974"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.22489796),
        dec: Angle.Degrees(+60.42162367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195607"},
        {"Hipparcos Number", "HIP 101065"},
        {"Smithsonian Astrophysical Observation", "SAO 18891"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.32869329),
        dec: Angle.Degrees(+60.42168211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6327"},
        {"Hipparcos Number", "HIP 5100"},
    },
    visualMagnitude: 11.16,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.34595814),
        dec: Angle.Degrees(+60.42191687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196085"},
        {"Hipparcos Number", "HIP 101307"},
        {"Geneva Identification System", "GEN# +1.00196085"},
        {"Smithsonian Astrophysical Observation", "SAO 18914"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.01853014),
        dec: Angle.Degrees(+60.42255356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62635",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62635"},
        {"Smithsonian Astrophysical Observation", "SAO 15915"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.52153382),
        dec: Angle.Degrees(+60.42981828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1263",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1263"},
    },
    visualMagnitude: 10.83,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.96484842),
        dec: Angle.Degrees(+60.43157000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175441"},
        {"Hipparcos Number", "HIP 92555"},
        {"Geneva Identification System", "GEN# +1.00175441"},
        {"Smithsonian Astrophysical Observation", "SAO 18049"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.90874786),
        dec: Angle.Degrees(+60.43420159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171007"},
        {"Hipparcos Number", "HIP 90542"},
        {"Geneva Identification System", "GEN# +1.00171007"},
        {"Smithsonian Astrophysical Observation", "SAO 17898"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.728,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.11750131),
        dec: Angle.Degrees(+60.43733400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 239.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55215",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55215"},
        {"Smithsonian Astrophysical Observation", "SAO 15468"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.61011885),
        dec: Angle.Degrees(+60.59709595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23522",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3615 A"},
        {"Henry Draper", "HD 31910"},
        {"Hipparcos Number", "HIP 23522"},
        {"Fundamental Katalog 5th Edition", "FK5 182"},
        {"Geneva Identification System", "GEN# +1.00031910"},
        {"Smithsonian Astrophysical Observation", "SAO 13351"},
        {"Wilson Evans Batten Catalogue", "WEB 4582"},
    },
    visualMagnitude: 4.03,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.85457200),
        dec: Angle.Degrees(+60.44228144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5797"},
        {"Hipparcos Number", "HIP 4717"},
        {"Geneva Identification System", "GEN# +1.00005797"},
        {"Renson", "Renson 1530"},
        {"Smithsonian Astrophysical Observation", "SAO 11520"},
        {"Wilson Evans Batten Catalogue", "WEB 892"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.13934836),
        dec: Angle.Degrees(+60.44470777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165028"},
        {"Hipparcos Number", "HIP 88124"},
        {"Smithsonian Astrophysical Observation", "SAO 17719"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.99114456),
        dec: Angle.Degrees(+60.44518806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113853",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16481 A"},
        {"Henry Draper", "HD 217943"},
        {"Hipparcos Number", "HIP 113853"},
        {"Geneva Identification System", "GEN# +1.00217943"},
        {"Smithsonian Astrophysical Observation", "SAO 20393"},
        {"Wilson Evans Batten Catalogue", "WEB 20224"},
    },
    visualMagnitude: 6.74,
    bvColour: -0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.84877697),
        dec: Angle.Degrees(+60.44540989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80783"},
        {"Hipparcos Number", "HIP 46108"},
        {"Geneva Identification System", "GEN# +1.00080783"},
        {"Smithsonian Astrophysical Observation", "SAO 14868"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.04887728),
        dec: Angle.Degrees(+60.44713079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237018"},
        {"Hipparcos Number", "HIP 13457"},
        {"Smithsonian Astrophysical Observation", "SAO 12491"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.32049416),
        dec: Angle.Degrees(+60.44729354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97330",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97330"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.71959897),
        dec: Angle.Degrees(+60.44875002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106382"},
        {"Hipparcos Number", "HIP 59661"},
        {"Smithsonian Astrophysical Observation", "SAO 15746"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.52870354),
        dec: Angle.Degrees(+60.44962521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88357",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88357"},
        {"Smithsonian Astrophysical Observation", "SAO 17732"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.65019634),
        dec: Angle.Degrees(+60.44969976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114791",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16651 AB"},
        {"Henry Draper", "HD 219460"},
        {"Hipparcos Number", "HIP 114791"},
        {"Celescope Catalog", "CEL 5586"},
        {"Smithsonian Astrophysical Observation", "SAO 20512"},
    },
    visualMagnitude: 9.58,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.80169682),
        dec: Angle.Degrees(+60.45052754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40615"},
        {"Hipparcos Number", "HIP 28713"},
        {"Smithsonian Astrophysical Observation", "SAO 13691"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.96731681),
        dec: Angle.Degrees(+60.45303314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1950"},
        {"Hipparcos Number", "HIP 1925"},
        {"Geneva Identification System", "GEN# +1.00001950"},
        {"Smithsonian Astrophysical Observation", "SAO 11167"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.07268469),
        dec: Angle.Degrees(+60.45306761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7155",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7155"},
    },
    visualMagnitude: 9.65,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.05732758),
        dec: Angle.Degrees(+60.45349336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41782"},
        {"Hipparcos Number", "HIP 29348"},
        {"Smithsonian Astrophysical Observation", "SAO 13746"},
    },
    visualMagnitude: 6.48,
    bvColour: 1.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.80680923),
        dec: Angle.Degrees(+60.45352679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82998",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82998"},
        {"Smithsonian Astrophysical Observation", "SAO 17291"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.40903592),
        dec: Angle.Degrees(+60.45563574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144541"},
        {"Hipparcos Number", "HIP 78612"},
        {"Smithsonian Astrophysical Observation", "SAO 16937"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.74018353),
        dec: Angle.Degrees(+60.45594115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239826"},
        {"Hipparcos Number", "HIP 108625"},
        {"Smithsonian Astrophysical Observation", "SAO 19790"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.09100163),
        dec: Angle.Degrees(+60.45664898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135"},
        {"Hipparcos Number", "HIP 526"},
        {"Celescope Catalog", "CEL 17"},
        {"Geneva Identification System", "GEN# +1.00000135"},
        {"Smithsonian Astrophysical Observation", "SAO 10977"},
        {"Wilson Evans Batten Catalogue", "WEB 89"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.58409669),
        dec: Angle.Degrees(+60.45712221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30279"},
        {"Hipparcos Number", "HIP 22450"},
        {"Smithsonian Astrophysical Observation", "SAO 13282"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.46685369),
        dec: Angle.Degrees(+60.45881519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205139"},
        {"Hipparcos Number", "HIP 106227"},
        {"Celescope Catalog", "CEL 5331"},
        {"Geneva Identification System", "GEN# +1.00205139"},
        {"Smithsonian Astrophysical Observation", "SAO 19466"},
        {"Wilson Evans Batten Catalogue", "WEB 19244"},
    },
    visualMagnitude: 5.53,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.74705697),
        dec: Angle.Degrees(+60.45944015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237019"},
        {"Hipparcos Number", "HIP 13468"},
        {"Geneva Identification System", "GEN# +1.00237019"},
        {"Smithsonian Astrophysical Observation", "SAO 12494"},
        {"Wilson Evans Batten Catalogue", "WEB 2690"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.36863101),
        dec: Angle.Degrees(+60.45971763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11960"},
        {"Hipparcos Number", "HIP 9287"},
        {"Geneva Identification System", "GEN# +1.00011960"},
        {"Smithsonian Astrophysical Observation", "SAO 12074"},
        {"Wilson Evans Batten Catalogue", "WEB 1949"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.83777601),
        dec: Angle.Degrees(+60.46114733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103887"},
        {"Hipparcos Number", "HIP 58338"},
        {"Smithsonian Astrophysical Observation", "SAO 15670"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.45405855),
        dec: Angle.Degrees(+60.46151280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117226",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16982 C"},
        {"Hipparcos Number", "HIP 117226"},
        {"Geneva Identification System", "GEN# +0.05902768"},
    },
    visualMagnitude: 9.75,
    bvColour: 2.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.53143116),
        dec: Angle.Degrees(+60.46537633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17656",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17656"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.815,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.72550035),
        dec: Angle.Degrees(+60.46539308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 224.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239887"},
        {"Hipparcos Number", "HIP 109626"},
        {"Smithsonian Astrophysical Observation", "SAO 19936"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.10979974),
        dec: Angle.Degrees(+60.46619140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236896"},
        {"Hipparcos Number", "HIP 8772"},
        {"Geneva Identification System", "GEN# +1.00236896"},
        {"Smithsonian Astrophysical Observation", "SAO 12019"},
        {"Wilson Evans Batten Catalogue", "WEB 1848"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.21207416),
        dec: Angle.Degrees(+60.46623137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150077"},
        {"Hipparcos Number", "HIP 81188"},
        {"Geneva Identification System", "GEN# +1.00150077"},
        {"Smithsonian Astrophysical Observation", "SAO 17155"},
        {"Wilson Evans Batten Catalogue", "WEB 13725"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.75326833),
        dec: Angle.Degrees(+60.46809935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221670"},
        {"Hipparcos Number", "HIP 116278"},
        {"Geneva Identification System", "GEN# +1.00221670"},
        {"Smithsonian Astrophysical Observation", "SAO 20701"},
        {"Wilson Evans Batten Catalogue", "WEB 20549"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.39856200),
        dec: Angle.Degrees(+60.46860986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239685"},
        {"Hipparcos Number", "HIP 106166"},
        {"Smithsonian Astrophysical Observation", "SAO 19459"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.57275949),
        dec: Angle.Degrees(+60.46868371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53425",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53425"},
        {"Smithsonian Astrophysical Observation", "SAO 15338"},
        {"Wilson Evans Batten Catalogue", "WEB 9697"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.93161863),
        dec: Angle.Degrees(+60.46938540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220167"},
        {"Hipparcos Number", "HIP 115297"},
        {"Geneva Identification System", "GEN# +1.00220167"},
        {"Smithsonian Astrophysical Observation", "SAO 20577"},
        {"Wilson Evans Batten Catalogue", "WEB 20423"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.28067973),
        dec: Angle.Degrees(+60.47102647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13431",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2184 A"},
        {"Henry Draper", "HD 17688"},
        {"Hipparcos Number", "HIP 13431"},
        {"Smithsonian Astrophysical Observation", "SAO 12485"},
        {"Wilson Evans Batten Catalogue", "WEB 2686"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.24002345),
        dec: Angle.Degrees(+60.47135291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117227",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16982 AB"},
        {"Henry Draper", "HD 223070"},
        {"Hipparcos Number", "HIP 117227"},
        {"Smithsonian Astrophysical Observation", "SAO 20832"},
        {"Wilson Evans Batten Catalogue", "WEB 20656"},
    },
    visualMagnitude: 7.02,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.53348979),
        dec: Angle.Degrees(+60.47317484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240282"},
        {"Hipparcos Number", "HIP 115485"},
        {"Geneva Identification System", "GEN# +1.00240282"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.91075469),
        dec: Angle.Degrees(+60.47388149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124473"},
        {"Hipparcos Number", "HIP 69353"},
        {"Geneva Identification System", "GEN# +1.00124473"},
        {"Smithsonian Astrophysical Observation", "SAO 16301"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.92940074),
        dec: Angle.Degrees(+60.47401084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149575"},
        {"Hipparcos Number", "HIP 80966"},
        {"Smithsonian Astrophysical Observation", "SAO 17129"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.99834626),
        dec: Angle.Degrees(+60.48019844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15941",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2510 AB"},
        {"Henry Draper", "HD 20898"},
        {"Hipparcos Number", "HIP 15941"},
        {"Geneva Identification System", "GEN# +1.00020898J"},
        {"Smithsonian Astrophysical Observation", "SAO 12750"},
        {"Wilson Evans Batten Catalogue", "WEB 3042"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.31776588),
        dec: Angle.Degrees(+60.48371886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10828",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1765 AB"},
        {"Henry Draper", "HD 14124"},
        {"Hipparcos Number", "HIP 10828"},
        {"Smithsonian Astrophysical Observation", "SAO 12220"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.84005562),
        dec: Angle.Degrees(+60.48625061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14537",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14537"},
        {"Geneva Identification System", "GEN# +0.05900594"},
    },
    visualMagnitude: 8.77,
    bvColour: 2.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.91877941),
        dec: Angle.Degrees(+60.48947767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239700"},
        {"Hipparcos Number", "HIP 106479"},
        {"Smithsonian Astrophysical Observation", "SAO 19497"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.48802899),
        dec: Angle.Degrees(+60.49019100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69135"},
        {"Hipparcos Number", "HIP 40737"},
        {"Geneva Identification System", "GEN# +1.00069135"},
        {"Smithsonian Astrophysical Observation", "SAO 14498"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.72530545),
        dec: Angle.Degrees(+60.49184379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104113",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14635 AB"},
        {"Henry Draper", "HD 239570"},
        {"Hipparcos Number", "HIP 104113"},
        {"Smithsonian Astrophysical Observation", "SAO 19186"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.39361621),
        dec: Angle.Degrees(+60.49263915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20105",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3105 AB"},
        {"Henry Draper", "HD 26882"},
        {"Hipparcos Number", "HIP 20105"},
        {"Smithsonian Astrophysical Observation", "SAO 13090"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.64920884),
        dec: Angle.Degrees(+60.49387611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37902",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37902"},
        {"Smithsonian Astrophysical Observation", "SAO 14317"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.50978890),
        dec: Angle.Degrees(+60.49446884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58965"},
        {"Hipparcos Number", "HIP 36590"},
        {"Geneva Identification System", "GEN# +1.00058965"},
        {"Smithsonian Astrophysical Observation", "SAO 14222"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.88016019),
        dec: Angle.Degrees(+60.49531695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114253",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114253"},
    },
    visualMagnitude: 11.62,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.08379823),
        dec: Angle.Degrees(+60.49633423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59178",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59178"},
    },
    visualMagnitude: 10.36,
    bvColour: 1.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.03832540),
        dec: Angle.Degrees(+60.49813987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239540"},
        {"Hipparcos Number", "HIP 103549"},
        {"Smithsonian Astrophysical Observation", "SAO 19132"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.68365781),
        dec: Angle.Degrees(+60.49902473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4005"},
        {"Hipparcos Number", "HIP 3403"},
        {"Smithsonian Astrophysical Observation", "SAO 11346"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.83156500),
        dec: Angle.Degrees(+60.50267004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97404"},
        {"Hipparcos Number", "HIP 54824"},
        {"Smithsonian Astrophysical Observation", "SAO 15440"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.34856248),
        dec: Angle.Degrees(+60.50383246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197373"},
        {"Hipparcos Number", "HIP 102011"},
        {"Fundamental Katalog 5th Edition", "FK5 3654"},
        {"Geneva Identification System", "GEN# +1.00197373"},
        {"Smithsonian Astrophysical Observation", "SAO 18979"},
        {"Wilson Evans Batten Catalogue", "WEB 18443"},
    },
    visualMagnitude: 6.02,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.07448978),
        dec: Angle.Degrees(+60.50481311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 185.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9704",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1632 AB"},
        {"Henry Draper", "HD 12529"},
        {"Hipparcos Number", "HIP 9704"},
        {"Geneva Identification System", "GEN# +1.00012529J"},
        {"Smithsonian Astrophysical Observation", "SAO 12109"},
        {"Wilson Evans Batten Catalogue", "WEB 2039"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.20297349),
        dec: Angle.Degrees(+60.50631390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96771",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12789 A"},
        {"Henry Draper", "HD 186340"},
        {"Hipparcos Number", "HIP 96771"},
        {"Smithsonian Astrophysical Observation", "SAO 18461"},
        {"Wilson Evans Batten Catalogue", "WEB 16975"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.05496723),
        dec: Angle.Degrees(+60.50713097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5747"},
        {"Hipparcos Number", "HIP 4674"},
        {"Geneva Identification System", "GEN# +1.00005747"},
        {"Smithsonian Astrophysical Observation", "SAO 11515"},
        {"Wilson Evans Batten Catalogue", "WEB 876"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.01152260),
        dec: Angle.Degrees(+60.51000064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96773",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12789 B"},
        {"Henry Draper", "HD 186340B"},
        {"Hipparcos Number", "HIP 96773"},
        {"Smithsonian Astrophysical Observation", "SAO 18462"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.05958202),
        dec: Angle.Degrees(+60.51165214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239763"},
        {"Hipparcos Number", "HIP 107435"},
        {"Smithsonian Astrophysical Observation", "SAO 19627"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.39774731),
        dec: Angle.Degrees(+60.51258981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2905",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2905"},
        {"Smithsonian Astrophysical Observation", "SAO 11298"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.20448694),
        dec: Angle.Degrees(+60.51554721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14794"},
        {"Hipparcos Number", "HIP 11294"},
        {"Smithsonian Astrophysical Observation", "SAO 12276"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.36067517),
        dec: Angle.Degrees(+60.51686803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7416"},
        {"Hipparcos Number", "HIP 5882"},
        {"Smithsonian Astrophysical Observation", "SAO 11659"},
        {"Wilson Evans Batten Catalogue", "WEB 1337"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.88265464),
        dec: Angle.Degrees(+60.51900718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120828"},
        {"Hipparcos Number", "HIP 67528"},
        {"Smithsonian Astrophysical Observation", "SAO 16190"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.53227294),
        dec: Angle.Degrees(+60.52035804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103718"},
        {"Hipparcos Number", "HIP 58243"},
        {"Geneva Identification System", "GEN# +1.00103718"},
        {"Smithsonian Astrophysical Observation", "SAO 15664"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.18384027),
        dec: Angle.Degrees(+60.52215102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77482",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9806 AB"},
        {"Henry Draper", "HD 142089"},
        {"Hipparcos Number", "HIP 77482"},
        {"Smithsonian Astrophysical Observation", "SAO 16860"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.31540722),
        dec: Angle.Degrees(+60.52735405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77726"},
        {"Hipparcos Number", "HIP 44741"},
        {"Smithsonian Astrophysical Observation", "SAO 14765"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.76878214),
        dec: Angle.Degrees(+60.52797446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221438"},
        {"Hipparcos Number", "HIP 116121"},
        {"Geneva Identification System", "GEN# +1.00221438"},
        {"Smithsonian Astrophysical Observation", "SAO 20681"},
        {"Wilson Evans Batten Catalogue", "WEB 20529"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.93116374),
        dec: Angle.Degrees(+60.52956079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50015",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7676 AB"},
        {"Henry Draper", "HD 88279"},
        {"Hipparcos Number", "HIP 50015"},
        {"Smithsonian Astrophysical Observation", "SAO 15116"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.16079560),
        dec: Angle.Degrees(+60.53328863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147187"},
        {"Hipparcos Number", "HIP 79776"},
        {"Geneva Identification System", "GEN# +1.00147187"},
        {"Smithsonian Astrophysical Observation", "SAO 17022"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.766,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.22081244),
        dec: Angle.Degrees(+60.53489947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49490",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49490"},
        {"Smithsonian Astrophysical Observation", "SAO 15078"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.55964404),
        dec: Angle.Degrees(+60.53597089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -130.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60293"},
        {"Hipparcos Number", "HIP 37111"},
        {"Smithsonian Astrophysical Observation", "SAO 14261"},
        {"Wilson Evans Batten Catalogue", "WEB 7357"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.38520502),
        dec: Angle.Degrees(+60.53860708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239579"},
        {"Hipparcos Number", "HIP 104247"},
        {"Smithsonian Astrophysical Observation", "SAO 19202"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.81052420),
        dec: Angle.Degrees(+60.54028093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44938",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7196 AB"},
        {"Henry Draper", "HD 78124"},
        {"Hipparcos Number", "HIP 44938"},
        {"Geneva Identification System", "GEN# +1.00078124J"},
        {"Renson", "Renson 22110"},
        {"Smithsonian Astrophysical Observation", "SAO 14778"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.30748821),
        dec: Angle.Degrees(+60.54390470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121681"},
        {"Hipparcos Number", "HIP 67966"},
        {"Smithsonian Astrophysical Observation", "SAO 16216"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.77467272),
        dec: Angle.Degrees(+60.54541392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57813"},
        {"Hipparcos Number", "HIP 36129"},
        {"Smithsonian Astrophysical Observation", "SAO 14193"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.845,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.63056893),
        dec: Angle.Degrees(+60.54663538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -145.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -476.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7989",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1337 A"},
        {"Henry Draper", "HD 10332"},
        {"Hipparcos Number", "HIP 7989"},
        {"Smithsonian Astrophysical Observation", "SAO 11927"},
        {"Wilson Evans Batten Catalogue", "WEB 1712"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.65348692),
        dec: Angle.Degrees(+60.54807263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2974"},
        {"Hipparcos Number", "HIP 2647"},
        {"Celescope Catalog", "CEL 79"},
        {"Geneva Identification System", "GEN# +1.00002974"},
        {"Smithsonian Astrophysical Observation", "SAO 11260"},
        {"Wilson Evans Batten Catalogue", "WEB 483"},
    },
    visualMagnitude: 7.89,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.39391816),
        dec: Angle.Degrees(+60.54865808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137687"},
        {"Hipparcos Number", "HIP 75389"},
        {"Cincinnati Publication", "Ci 20 931"},
        {"Cincinnati Publication 2", "Ci 18 2062"},
        {"Geneva Identification System", "GEN# +1.00137687"},
        {"Smithsonian Astrophysical Observation", "SAO 16722"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.794,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.07656947),
        dec: Angle.Degrees(+60.54896968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -357.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 176.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8046",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1344 A"},
        {"Henry Draper", "HD 10425"},
        {"Hipparcos Number", "HIP 8046"},
        {"Geneva Identification System", "GEN# +1.10010425"},
        {"Geneva Identification System 2", "GEN# +1.00010425"},
        {"Smithsonian Astrophysical Observation", "SAO 11941"},
        {"Wilson Evans Batten Catalogue", "WEB 1722"},
    },
    visualMagnitude: 5.78,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.83223958),
        dec: Angle.Degrees(+60.55137091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5316",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5316"},
        {"Geneva Identification System", "GEN# +0.05900186"},
        {"Wilson Evans Batten Catalogue", "WEB 1144"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.00235032),
        dec: Angle.Degrees(+60.55170248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40609",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40609"},
        {"Smithsonian Astrophysical Observation", "SAO 14489"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.36889461),
        dec: Angle.Degrees(+60.55179839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15785"},
        {"Hipparcos Number", "HIP 12009"},
        {"Geneva Identification System", "GEN# +1.00015785"},
        {"Smithsonian Astrophysical Observation", "SAO 12343"},
        {"Wilson Evans Batten Catalogue", "WEB 2475"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.70021626),
        dec: Angle.Degrees(+60.55206783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16506"},
        {"Hipparcos Number", "HIP 12543"},
        {"Smithsonian Astrophysical Observation", "SAO 12388"},
        {"Wilson Evans Batten Catalogue", "WEB 2562"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.35046713),
        dec: Angle.Degrees(+60.55327891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236722"},
        {"Hipparcos Number", "HIP 6635"},
        {"Geneva Identification System", "GEN# +1.00236722"},
        {"Smithsonian Astrophysical Observation", "SAO 11747"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.28266506),
        dec: Angle.Degrees(+60.55840870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123174"},
        {"Hipparcos Number", "HIP 68723"},
        {"Smithsonian Astrophysical Observation", "SAO 16270"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.02167458),
        dec: Angle.Degrees(+60.56256987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236810"},
        {"Hipparcos Number", "HIP 7640"},
        {"Geneva Identification System", "GEN# +1.00236810"},
        {"Smithsonian Astrophysical Observation", "SAO 11885"},
        {"Wilson Evans Batten Catalogue", "WEB 1634"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.60952019),
        dec: Angle.Degrees(+60.56296759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186672"},
        {"Hipparcos Number", "HIP 96933"},
        {"Smithsonian Astrophysical Observation", "SAO 18481"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.56000415),
        dec: Angle.Degrees(+60.56315212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18326"},
        {"Hipparcos Number", "HIP 13924"},
        {"Geneva Identification System", "GEN# +1.00018326"},
        {"Smithsonian Astrophysical Observation", "SAO 12552"},
        {"Wilson Evans Batten Catalogue", "WEB 2747"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.84654596),
        dec: Angle.Degrees(+60.56653260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37510",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37510"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.47479669),
        dec: Angle.Degrees(+60.56692812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -261.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -159.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38460"},
        {"Hipparcos Number", "HIP 27541"},
        {"Smithsonian Astrophysical Observation", "SAO 13625"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.48881372),
        dec: Angle.Degrees(+60.56884828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17086"},
        {"Hipparcos Number", "HIP 13004"},
        {"Geneva Identification System", "GEN# +1.00017086"},
        {"Smithsonian Astrophysical Observation", "SAO 12438"},
        {"Wilson Evans Batten Catalogue", "WEB 2627"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.79031337),
        dec: Angle.Degrees(+60.57076067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218941"},
        {"Hipparcos Number", "HIP 114490"},
        {"Geneva Identification System", "GEN# +2.75100003"},
        {"New General Catalogue", "NGC 7510 3"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.81175050),
        dec: Angle.Degrees(+60.57270809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86823",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86823"},
        {"Smithsonian Astrophysical Observation", "SAO 17621"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.11160609),
        dec: Angle.Degrees(+60.57386094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165565"},
        {"Hipparcos Number", "HIP 88372"},
        {"Smithsonian Astrophysical Observation", "SAO 17734"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.67983221),
        dec: Angle.Degrees(+60.57743552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155058"},
        {"Hipparcos Number", "HIP 83622"},
        {"Smithsonian Astrophysical Observation", "SAO 17342"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.35293562),
        dec: Angle.Degrees(+60.58442765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30768"},
        {"Hipparcos Number", "HIP 22793"},
        {"Smithsonian Astrophysical Observation", "SAO 13302"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.55682778),
        dec: Angle.Degrees(+60.58818726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42338",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42338"},
        {"Smithsonian Astrophysical Observation", "SAO 14606"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.782,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.47742036),
        dec: Angle.Degrees(+60.59005162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -122.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -142.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197734"},
        {"Hipparcos Number", "HIP 102216"},
        {"Celescope Catalog", "CEL 5154"},
        {"Geneva Identification System", "GEN# +1.00197734"},
        {"Smithsonian Astrophysical Observation", "SAO 18998"},
        {"Wilson Evans Batten Catalogue", "WEB 18498"},
    },
    visualMagnitude: 6.17,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.66538279),
        dec: Angle.Degrees(+60.60136196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102473",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102473"},
        {"Smithsonian Astrophysical Observation", "SAO 19025"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.48602796),
        dec: Angle.Degrees(+60.60213555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50113",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7686 AB"},
        {"Henry Draper", "HD 88445"},
        {"Hipparcos Number", "HIP 50113"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.46432298),
        dec: Angle.Degrees(+60.60450977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236989"},
        {"Hipparcos Number", "HIP 12729"},
        {"Smithsonian Astrophysical Observation", "SAO 12412"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.849,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.90510097),
        dec: Angle.Degrees(+60.60838783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93671"},
        {"Hipparcos Number", "HIP 52978"},
        {"Geneva Identification System", "GEN# +1.00093671"},
        {"Smithsonian Astrophysical Observation", "SAO 15307"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.55503708),
        dec: Angle.Degrees(+60.60912367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36639"},
        {"Hipparcos Number", "HIP 26391"},
        {"Smithsonian Astrophysical Observation", "SAO 13552"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.27984425),
        dec: Angle.Degrees(+60.61043288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215847"},
        {"Hipparcos Number", "HIP 112473"},
        {"Smithsonian Astrophysical Observation", "SAO 20240"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.72685832),
        dec: Angle.Degrees(+60.61137965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167471"},
        {"Hipparcos Number", "HIP 89138"},
        {"Geneva Identification System", "GEN# +1.00167471"},
        {"Smithsonian Astrophysical Observation", "SAO 17806"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.88153818),
        dec: Angle.Degrees(+60.61202929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189084"},
        {"Hipparcos Number", "HIP 97989"},
        {"Smithsonian Astrophysical Observation", "SAO 18590"},
        {"Wilson Evans Batten Catalogue", "WEB 17248"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.70860712),
        dec: Angle.Degrees(+60.61497488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48343",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7536 AB"},
        {"Henry Draper", "HD 84998"},
        {"Hipparcos Number", "HIP 48343"},
        {"Smithsonian Astrophysical Observation", "SAO 15002"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.81356249),
        dec: Angle.Degrees(+60.61679749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193792"},
        {"Hipparcos Number", "HIP 100150"},
        {"Celescope Catalog", "CEL 5027"},
        {"Smithsonian Astrophysical Observation", "SAO 18801"},
    },
    visualMagnitude: 8.00,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.72877781),
        dec: Angle.Degrees(+60.61794719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8125",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8125"},
        {"Geneva Identification System", "GEN# +8.01600177"},
    },
    visualMagnitude: 10.66,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.10387141),
        dec: Angle.Degrees(+60.62060633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37315"},
        {"Hipparcos Number", "HIP 26814"},
        {"Smithsonian Astrophysical Observation", "SAO 13568"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.40293321),
        dec: Angle.Degrees(+60.62301966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73293"},
        {"Hipparcos Number", "HIP 42573"},
        {"Geneva Identification System", "GEN# +1.00073293"},
        {"Smithsonian Astrophysical Observation", "SAO 14621"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.17009011),
        dec: Angle.Degrees(+60.62309471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9365"},
        {"Hipparcos Number", "HIP 7280"},
        {"Geneva Identification System", "GEN# +2.05810144"},
        {"Geneva Identification System 2", "GEN# +2.05810002"},
        {"Smithsonian Astrophysical Observation", "SAO 11829"},
        {"Wilson Evans Batten Catalogue", "WEB 1570"},
        {"New General Catalogue", "NGC 581 144"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.43935580),
        dec: Angle.Degrees(+60.62310179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214627"},
        {"Hipparcos Number", "HIP 111740"},
        {"Geneva Identification System", "GEN# +1.00214627"},
        {"Smithsonian Astrophysical Observation", "SAO 20185"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.52280501),
        dec: Angle.Degrees(+60.62389942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115704",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115704"},
        {"Geneva Identification System", "GEN# +0.05902723"},
        {"Wilson Evans Batten Catalogue", "WEB 20475"},
    },
    visualMagnitude: 10.49,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.63457146),
        dec: Angle.Degrees(+60.62843831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 455.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13734"},
        {"Hipparcos Number", "HIP 10575"},
        {"Smithsonian Astrophysical Observation", "SAO 12196"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.02946620),
        dec: Angle.Degrees(+60.63025325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105342",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14892 AB"},
        {"Henry Draper", "HD 203534"},
        {"Hipparcos Number", "HIP 105342"},
        {"Smithsonian Astrophysical Observation", "SAO 19323"},
        {"Wilson Evans Batten Catalogue", "WEB 19135"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.05841479),
        dec: Angle.Degrees(+60.63088203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69976"},
        {"Hipparcos Number", "HIP 41060"},
        {"Fundamental Katalog 5th Edition", "FK5 4752"},
        {"Geneva Identification System", "GEN# +1.00069976"},
        {"Smithsonian Astrophysical Observation", "SAO 14522"},
        {"Wilson Evans Batten Catalogue", "WEB 7953"},
    },
    visualMagnitude: 6.42,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.68357766),
        dec: Angle.Degrees(+60.63124111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100299"},
        {"Hipparcos Number", "HIP 56348"},
        {"Smithsonian Astrophysical Observation", "SAO 15550"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.26402121),
        dec: Angle.Degrees(+60.63181605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44671"},
        {"Hipparcos Number", "HIP 30688"},
        {"Geneva Identification System", "GEN# +1.00044671"},
        {"Smithsonian Astrophysical Observation", "SAO 13840"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.73204910),
        dec: Angle.Degrees(+60.63321580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7238",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7238"},
        {"Geneva Identification System", "GEN# +2.05810042"},
        {"Geneva Identification System 2", "GEN# +2.05810007"},
        {"New General Catalogue", "NGC 581 42"},
    },
    visualMagnitude: 11.25,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.31805629),
        dec: Angle.Degrees(+60.63373869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19536"},
        {"Hipparcos Number", "HIP 14833"},
        {"Fundamental Katalog 5th Edition", "FK5 4293"},
        {"Geneva Identification System", "GEN# +1.00019536"},
        {"Smithsonian Astrophysical Observation", "SAO 12644"},
        {"Wilson Evans Batten Catalogue", "WEB 2864"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.88209442),
        dec: Angle.Degrees(+60.63516858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155207"},
        {"Hipparcos Number", "HIP 83696"},
        {"Smithsonian Astrophysical Observation", "SAO 17348"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.58992543),
        dec: Angle.Degrees(+60.63609162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149118"},
        {"Hipparcos Number", "HIP 80742"},
        {"Geneva Identification System", "GEN# +1.00149118"},
        {"Smithsonian Astrophysical Observation", "SAO 17109"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.27675018),
        dec: Angle.Degrees(+60.63989348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192781"},
        {"Hipparcos Number", "HIP 99663"},
        {"Geneva Identification System", "GEN# +1.00192781"},
        {"Smithsonian Astrophysical Observation", "SAO 18766"},
        {"Wilson Evans Batten Catalogue", "WEB 17869"},
    },
    visualMagnitude: 5.81,
    bvColour: 1.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.36487180),
        dec: Angle.Degrees(+60.64043320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239982"},
        {"Hipparcos Number", "HIP 111089"},
        {"Geneva Identification System", "GEN# +1.00239982"},
        {"Smithsonian Astrophysical Observation", "SAO 20111"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.57793215),
        dec: Angle.Degrees(+60.64164913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59844"},
        {"Hipparcos Number", "HIP 36930"},
        {"Smithsonian Astrophysical Observation", "SAO 14246"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.87850273),
        dec: Angle.Degrees(+60.64169842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208266"},
        {"Hipparcos Number", "HIP 108017"},
        {"Geneva Identification System", "GEN# +1.00208266"},
        {"Renson", "Renson 57900"},
        {"Smithsonian Astrophysical Observation", "SAO 19702"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.25145156),
        dec: Angle.Degrees(+60.64241134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25868",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25868"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.83668010),
        dec: Angle.Degrees(+60.64278492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154391"},
        {"Hipparcos Number", "HIP 83289"},
        {"Geneva Identification System", "GEN# +1.00154391"},
        {"Smithsonian Astrophysical Observation", "SAO 17312"},
        {"Wilson Evans Batten Catalogue", "WEB 14076"},
    },
    visualMagnitude: 6.16,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.32074149),
        dec: Angle.Degrees(+60.64865840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94408",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94408"},
        {"Renson", "Renson 50092"},
        {"Smithsonian Astrophysical Observation", "SAO 18214"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.22167820),
        dec: Angle.Degrees(+60.65062146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61650",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61650"},
        {"Smithsonian Astrophysical Observation", "SAO 15848"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.57324784),
        dec: Angle.Degrees(+60.65191101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17201",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2664 AB"},
        {"Henry Draper", "HD 22577"},
        {"Hipparcos Number", "HIP 17201"},
        {"Smithsonian Astrophysical Observation", "SAO 12865"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)41, 05.8200),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)39, 26.100)
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
    primaryId: "HIP 11604",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1877 A"},
        {"Henry Draper", "HD 15239"},
        {"Hipparcos Number", "HIP 11604"},
        {"Celescope Catalog", "CEL 280"},
        {"Geneva Identification System", "GEN# +4.31070028"},
        {"Smithsonian Astrophysical Observation", "SAO 12303"},
        {"Wilson Evans Batten Catalogue", "WEB 2417"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.40728321),
        dec: Angle.Degrees(+60.65727656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116229",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116229"},
        {"Geneva Identification System", "GEN# +7.30191454"},
        {"Geneva Identification System 2", "GEN# +8.01600008"},
    },
    visualMagnitude: 10.94,
    bvColour: 0.728,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.23670860),
        dec: Angle.Degrees(+60.66213524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52093",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52093"},
        {"Smithsonian Astrophysical Observation", "SAO 15245"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.66139444),
        dec: Angle.Degrees(+60.66508548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5071"},
        {"Hipparcos Number", "HIP 4182"},
        {"Geneva Identification System", "GEN# +1.00005071"},
        {"Smithsonian Astrophysical Observation", "SAO 11449"},
        {"Wilson Evans Batten Catalogue", "WEB 752"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.36675196),
        dec: Angle.Degrees(+60.66562735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2291"},
        {"Hipparcos Number", "HIP 2146"},
        {"Smithsonian Astrophysical Observation", "SAO 11206"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.79581429),
        dec: Angle.Degrees(+60.66696958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53987",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53987"},
        {"Smithsonian Astrophysical Observation", "SAO 15372"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.66068880),
        dec: Angle.Degrees(+60.66722029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176893"},
        {"Hipparcos Number", "HIP 93161"},
        {"Smithsonian Astrophysical Observation", "SAO 18091"},
    },
    visualMagnitude: 6.91,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.64113204),
        dec: Angle.Degrees(+60.66724814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146868"},
        {"Hipparcos Number", "HIP 79629"},
        {"Cincinnati Publication", "Ci 18 2179"},
        {"Cincinnati Publication 2", "Ci 20 978"},
        {"Geneva Identification System", "GEN# +1.00146868"},
        {"Smithsonian Astrophysical Observation", "SAO 17004"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.73770117),
        dec: Angle.Degrees(+60.66870708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 438.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184168"},
        {"Hipparcos Number", "HIP 95830"},
        {"Geneva Identification System", "GEN# +1.00184168"},
        {"Smithsonian Astrophysical Observation", "SAO 18363"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.36658629),
        dec: Angle.Degrees(+60.66896269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91136",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91136"},
        {"Smithsonian Astrophysical Observation", "SAO 17937"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.86085393),
        dec: Angle.Degrees(+60.66920667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138265"},
        {"Hipparcos Number", "HIP 75696"},
        {"Geneva Identification System", "GEN# +1.00138265"},
        {"Smithsonian Astrophysical Observation", "SAO 16741"},
        {"Wilson Evans Batten Catalogue", "WEB 12889"},
    },
    visualMagnitude: 5.90,
    bvColour: 1.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.96434672),
        dec: Angle.Degrees(+60.67022438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156947"},
        {"Hipparcos Number", "HIP 84496"},
        {"Geneva Identification System", "GEN# +1.00156947"},
        {"Smithsonian Astrophysical Observation", "SAO 17414"},
        {"Wilson Evans Batten Catalogue", "WEB 14266"},
    },
    visualMagnitude: 6.32,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.12270011),
        dec: Angle.Degrees(+60.67057950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40859"},
        {"Hipparcos Number", "HIP 28860"},
        {"Smithsonian Astrophysical Observation", "SAO 13708"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.38573714),
        dec: Angle.Degrees(+60.67414070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58198",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58198"},
        {"Smithsonian Astrophysical Observation", "SAO 15661"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.03691596),
        dec: Angle.Degrees(+60.67537406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29021"},
        {"Hipparcos Number", "HIP 21571"},
        {"Geneva Identification System", "GEN# +1.00029021"},
        {"Smithsonian Astrophysical Observation", "SAO 13210"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.46728677),
        dec: Angle.Degrees(+60.67614221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15238"},
        {"Hipparcos Number", "HIP 11607"},
        {"Geneva Identification System", "GEN# +4.31070023"},
        {"Smithsonian Astrophysical Observation", "SAO 12304"},
        {"Wilson Evans Batten Catalogue", "WEB 2419"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.43141439),
        dec: Angle.Degrees(+60.67737043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80667",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10080 AB"},
        {"Henry Draper", "HD 148977"},
        {"Hipparcos Number", "HIP 80667"},
        {"Smithsonian Astrophysical Observation", "SAO 17100"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.04911731),
        dec: Angle.Degrees(+60.68027848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187034"},
        {"Hipparcos Number", "HIP 97120"},
        {"Geneva Identification System", "GEN# +1.00187034"},
        {"Smithsonian Astrophysical Observation", "SAO 18502"},
    },
    visualMagnitude: 8.95,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.07381073),
        dec: Angle.Degrees(+60.68416822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7232",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1209 A"},
        {"Henry Draper", "HD 9311"},
        {"Hipparcos Number", "HIP 7232"},
        {"Geneva Identification System", "GEN# +2.05810176"},
        {"Geneva Identification System 2", "GEN# +2.05810001"},
        {"Smithsonian Astrophysical Observation", "SAO 11822"},
        {"Wilson Evans Batten Catalogue", "WEB 1554"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.30836206),
        dec: Angle.Degrees(+60.68643905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105357",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14898 A"},
        {"Henry Draper", "HD 203551"},
        {"Hipparcos Number", "HIP 105357"},
        {"Smithsonian Astrophysical Observation", "SAO 19329"},
        {"Wilson Evans Batten Catalogue", "WEB 19136"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.10593109),
        dec: Angle.Degrees(+60.68726632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97763",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97763"},
        {"Smithsonian Astrophysical Observation", "SAO 18568"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.00371619),
        dec: Angle.Degrees(+60.68942607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66570"},
        {"Hipparcos Number", "HIP 39764"},
        {"Smithsonian Astrophysical Observation", "SAO 14436"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.91172605),
        dec: Angle.Degrees(+60.68942991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120379"},
        {"Hipparcos Number", "HIP 67287"},
        {"Smithsonian Astrophysical Observation", "SAO 16180"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.85067267),
        dec: Angle.Degrees(+60.69107028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207528"},
        {"Hipparcos Number", "HIP 107586"},
        {"Geneva Identification System", "GEN# +1.00207528"},
        {"Smithsonian Astrophysical Observation", "SAO 19642"},
        {"Wilson Evans Batten Catalogue", "WEB 19416"},
    },
    visualMagnitude: 5.53,
    bvColour: 1.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.85544759),
        dec: Angle.Degrees(+60.69269363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25055"},
        {"Hipparcos Number", "HIP 18836"},
        {"Smithsonian Astrophysical Observation", "SAO 12994"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.56929619),
        dec: Angle.Degrees(+60.69336122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240106"},
        {"Hipparcos Number", "HIP 113094"},
        {"Smithsonian Astrophysical Observation", "SAO 20308"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.55899588),
        dec: Angle.Degrees(+60.69556921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104723",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104723"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.20907749),
        dec: Angle.Degrees(+60.69579770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100561"},
        {"Hipparcos Number", "HIP 56488"},
        {"Smithsonian Astrophysical Observation", "SAO 15558"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.71061233),
        dec: Angle.Degrees(+60.69716632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108134"},
        {"Hipparcos Number", "HIP 60588"},
        {"Geneva Identification System", "GEN# +1.00108134"},
        {"Smithsonian Astrophysical Observation", "SAO 15800"},
        {"Wilson Evans Batten Catalogue", "WEB 10775"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.27068676),
        dec: Angle.Degrees(+60.69736907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 144.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105429",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14912 AB"},
        {"Henry Draper", "HD 203695"},
        {"Hipparcos Number", "HIP 105429"},
        {"Geneva Identification System", "GEN# +1.00203695J"},
        {"Smithsonian Astrophysical Observation", "SAO 19345"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.33369823),
        dec: Angle.Degrees(+60.69934716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81519",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10152 A"},
        {"Henry Draper", "HD 150708"},
        {"Hipparcos Number", "HIP 81519"},
        {"Geneva Identification System", "GEN# +1.00150708A"},
        {"Smithsonian Astrophysical Observation", "SAO 17176"},
        {"Wilson Evans Batten Catalogue", "WEB 13771"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.76646995),
        dec: Angle.Degrees(+60.69980455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239989"},
        {"Hipparcos Number", "HIP 111220"},
        {"Geneva Identification System", "GEN# +1.00239989"},
        {"Smithsonian Astrophysical Observation", "SAO 20131"},
        {"Wilson Evans Batten Catalogue", "WEB 19901"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.99656312),
        dec: Angle.Degrees(+60.70115635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224980"},
        {"Hipparcos Number", "HIP 181"},
        {"Geneva Identification System", "GEN# +1.00224980"},
        {"Smithsonian Astrophysical Observation", "SAO 21020"},
        {"Wilson Evans Batten Catalogue", "WEB 30"},
    },
    visualMagnitude: 6.77,
    bvColour: 1.832,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.57381667),
        dec: Angle.Degrees(+60.70319460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117775",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17080 A"},
        {"Henry Draper", "HD 223866"},
        {"Hipparcos Number", "HIP 117775"},
        {"Smithsonian Astrophysical Observation", "SAO 20915"},
    },
    visualMagnitude: 6.71,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.27014699),
        dec: Angle.Degrees(+60.70450215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15251"},
        {"Hipparcos Number", "HIP 11612"},
        {"Geneva Identification System", "GEN# +4.31070018"},
        {"Smithsonian Astrophysical Observation", "SAO 12307"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.44529216),
        dec: Angle.Degrees(+60.70534991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39755",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39755"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.88343196),
        dec: Angle.Degrees(+60.70904966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172825"},
        {"Hipparcos Number", "HIP 91397"},
        {"Geneva Identification System", "GEN# +1.00172825"},
        {"Smithsonian Astrophysical Observation", "SAO 17961"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.60132973),
        dec: Angle.Degrees(+60.71092469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15382"},
        {"Hipparcos Number", "HIP 11706"},
        {"Geneva Identification System", "GEN# +1.00015382"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.76239564),
        dec: Angle.Degrees(+60.71144510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13256"},
        {"Hipparcos Number", "HIP 10243"},
        {"Geneva Identification System", "GEN# +1.00013256"},
        {"Smithsonian Astrophysical Observation", "SAO 12165"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.93296053),
        dec: Angle.Degrees(+60.71236358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84465",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10448 A"},
        {"Henry Draper", "HD 156890"},
        {"Hipparcos Number", "HIP 84465"},
        {"Geneva Identification System", "GEN# +1.00156890"},
        {"Smithsonian Astrophysical Observation", "SAO 17410"},
        {"Wilson Evans Batten Catalogue", "WEB 14256"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.02035291),
        dec: Angle.Degrees(+60.71381295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4427",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 782 A"},
        {"Henry Draper", "HD 5394"},
        {"Hipparcos Number", "HIP 4427"},
        {"Fundamental Katalog 5th Edition", "FK5 32"},
        {"Geneva Identification System", "GEN# +1.00005394"},
        {"Smithsonian Astrophysical Observation", "SAO 11482"},
        {"Wilson Evans Batten Catalogue", "WEB 791"},
    },
    visualMagnitude: 2.15,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.17708808),
        dec: Angle.Degrees(+60.71674966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129226"},
        {"Hipparcos Number", "HIP 71623"},
        {"Geneva Identification System", "GEN# +1.00129226"},
        {"Smithsonian Astrophysical Observation", "SAO 16449"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.72960189),
        dec: Angle.Degrees(+60.71723412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41704",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Muscida"},
        {"Aitken", "ADS 6830 A"},
        {"Henry Draper", "HD 71369"},
        {"Hipparcos Number", "HIP 41704"},
        {"Fundamental Katalog 5th Edition", "FK5 317"},
        {"Geneva Identification System", "GEN# +1.00071369"},
        {"Smithsonian Astrophysical Observation", "SAO 14573"},
        {"Wilson Evans Batten Catalogue", "WEB 8042"},
    },
    visualMagnitude: 3.35,
    bvColour: 0.856,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.56679232),
        dec: Angle.Degrees(+60.71843110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -134.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13757"},
        {"Hipparcos Number", "HIP 10585"},
        {"Celescope Catalog", "CEL 233"},
        {"Geneva Identification System", "GEN# +1.00013757"},
        {"Smithsonian Astrophysical Observation", "SAO 12198"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.07326483),
        dec: Angle.Degrees(+60.71927980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100984",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100984"},
    },
    visualMagnitude: 11.47,
    bvColour: 0.775,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.11749606),
        dec: Angle.Degrees(+62.01489193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -207.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -146.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 962"},
        {"Hipparcos Number", "HIP 1132"},
        {"Celescope Catalog", "CEL 44"},
        {"Geneva Identification System", "GEN# +1.00000962"},
        {"Smithsonian Astrophysical Observation", "SAO 11054"},
        {"Wilson Evans Batten Catalogue", "WEB 199"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.52764749),
        dec: Angle.Degrees(+60.72036346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25229",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25229"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.93413448),
        dec: Angle.Degrees(+60.72110432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50877",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50877"},
        {"Smithsonian Astrophysical Observation", "SAO 15158"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.837,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.82720799),
        dec: Angle.Degrees(+60.72117296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -209.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94617",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94617"},
    },
    visualMagnitude: 10.62,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.81961600),
        dec: Angle.Degrees(+60.72448667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 230.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85144",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85144"},
        {"Geneva Identification System", "GEN# +0.06001751"},
        {"Smithsonian Astrophysical Observation", "SAO 17460"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.99916645),
        dec: Angle.Degrees(+60.72641951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31169",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5138 AB"},
        {"Henry Draper", "HD 45619"},
        {"Hipparcos Number", "HIP 31169"},
        {"Smithsonian Astrophysical Observation", "SAO 13875"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.10072850),
        dec: Angle.Degrees(+60.72932913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92149",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92149"},
        {"Smithsonian Astrophysical Observation", "SAO 18015"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.72057914),
        dec: Angle.Degrees(+60.72992173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27245"},
        {"Hipparcos Number", "HIP 20376"},
        {"Fundamental Katalog 5th Edition", "FK5 2317"},
        {"Geneva Identification System", "GEN# +1.00027245"},
        {"Smithsonian Astrophysical Observation", "SAO 13113"},
        {"Wilson Evans Batten Catalogue", "WEB 3892"},
    },
    visualMagnitude: 5.40,
    bvColour: 1.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.44826292),
        dec: Angle.Degrees(+60.73590167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3449",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3449"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.02464382),
        dec: Angle.Degrees(+60.74229459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34581",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5810 A"},
        {"Henry Draper", "HD 53683"},
        {"Hipparcos Number", "HIP 34581"},
        {"Smithsonian Astrophysical Observation", "SAO 14098"},
        {"Wilson Evans Batten Catalogue", "WEB 6919"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.43352092),
        dec: Angle.Degrees(+60.74323339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21384",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21384"},
    },
    visualMagnitude: 11.66,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.84091327),
        dec: Angle.Degrees(+60.74486147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -138.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115228"},
        {"Hipparcos Number", "HIP 64609"},
        {"Geneva Identification System", "GEN# +1.00115228"},
        {"Smithsonian Astrophysical Observation", "SAO 16021"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.64081328),
        dec: Angle.Degrees(+60.74852623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57220",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57220"},
        {"Smithsonian Astrophysical Observation", "SAO 15617"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.00060947),
        dec: Angle.Degrees(+60.74858929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70541",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70541"},
        {"Smithsonian Astrophysical Observation", "SAO 16376"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.46303840),
        dec: Angle.Degrees(+60.75103310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101794",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14102 AB"},
        {"Henry Draper", "HD 196988"},
        {"Hipparcos Number", "HIP 101794"},
        {"Smithsonian Astrophysical Observation", "SAO 18958"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.45049680),
        dec: Angle.Degrees(+60.75596393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203574"},
        {"Hipparcos Number", "HIP 105370"},
        {"Geneva Identification System", "GEN# +1.00203574"},
        {"Smithsonian Astrophysical Observation", "SAO 19333"},
        {"Wilson Evans Batten Catalogue", "WEB 19137"},
    },
    visualMagnitude: 6.11,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.13957891),
        dec: Angle.Degrees(+60.75645363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210939"},
        {"Hipparcos Number", "HIP 109592"},
        {"Geneva Identification System", "GEN# +1.00210939"},
        {"Smithsonian Astrophysical Observation", "SAO 19932"},
        {"Wilson Evans Batten Catalogue", "WEB 19692"},
    },
    visualMagnitude: 5.37,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.00839287),
        dec: Angle.Degrees(+60.75907189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3868",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 677 A"},
        {"Henry Draper", "HD 4674"},
        {"Hipparcos Number", "HIP 3868"},
        {"Geneva Identification System", "GEN# +1.00004674"},
        {"Smithsonian Astrophysical Observation", "SAO 11417"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.41460560),
        dec: Angle.Degrees(+60.75908220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4601"},
        {"Hipparcos Number", "HIP 3797"},
        {"Smithsonian Astrophysical Observation", "SAO 11407"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.19745483),
        dec: Angle.Degrees(+60.76650789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97710"},
        {"Hipparcos Number", "HIP 54964"},
        {"Smithsonian Astrophysical Observation", "SAO 15447"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.83108573),
        dec: Angle.Degrees(+60.76748203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214676"},
        {"Hipparcos Number", "HIP 111787"},
        {"Smithsonian Astrophysical Observation", "SAO 20187"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.63699759),
        dec: Angle.Degrees(+60.76948566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130236"},
        {"Hipparcos Number", "HIP 72064"},
        {"Smithsonian Astrophysical Observation", "SAO 16479"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.10900718),
        dec: Angle.Degrees(+60.77211910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6382"},
        {"Hipparcos Number", "HIP 5139"},
        {"Geneva Identification System", "GEN# +1.00006382"},
        {"Smithsonian Astrophysical Observation", "SAO 11566"},
        {"Wilson Evans Batten Catalogue", "WEB 1059"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.45472592),
        dec: Angle.Degrees(+60.77222108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127759"},
        {"Hipparcos Number", "HIP 70953"},
        {"Geneva Identification System", "GEN# +1.00127759"},
        {"Smithsonian Astrophysical Observation", "SAO 16405"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.69481526),
        dec: Angle.Degrees(+60.77618394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43771"},
        {"Hipparcos Number", "HIP 30275"},
        {"Smithsonian Astrophysical Observation", "SAO 13819"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.52010229),
        dec: Angle.Degrees(+60.77816518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145476"},
        {"Hipparcos Number", "HIP 79014"},
        {"Smithsonian Astrophysical Observation", "SAO 16967"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.92292592),
        dec: Angle.Degrees(+60.77828919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179332"},
        {"Hipparcos Number", "HIP 94012"},
        {"Smithsonian Astrophysical Observation", "SAO 18170"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.10656654),
        dec: Angle.Degrees(+60.77898713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96793"},
        {"Hipparcos Number", "HIP 54558"},
        {"Geneva Identification System", "GEN# +1.00096793"},
        {"Smithsonian Astrophysical Observation", "SAO 15419"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.46810619),
        dec: Angle.Degrees(+60.78257988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85847",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85847"},
        {"Smithsonian Astrophysical Observation", "SAO 17525"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.14272889),
        dec: Angle.Degrees(+60.78273954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45205"},
        {"Hipparcos Number", "HIP 30990"},
        {"Geneva Identification System", "GEN# +1.00045205"},
        {"Smithsonian Astrophysical Observation", "SAO 13854"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.56460664),
        dec: Angle.Degrees(+60.78472071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 136.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -247.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118178"},
        {"Hipparcos Number", "HIP 66158"},
        {"Geneva Identification System", "GEN# +1.00118178"},
        {"Smithsonian Astrophysical Observation", "SAO 16108"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.41242871),
        dec: Angle.Degrees(+60.78734917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50688"},
        {"Hipparcos Number", "HIP 33536"},
        {"Geneva Identification System", "GEN# +1.00050688"},
        {"Smithsonian Astrophysical Observation", "SAO 14024"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.54379749),
        dec: Angle.Degrees(+60.79030057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53633"},
        {"Hipparcos Number", "HIP 34572"},
        {"Smithsonian Astrophysical Observation", "SAO 14095"},
        {"Wilson Evans Batten Catalogue", "WEB 6916"},
    },
    visualMagnitude: 6.64,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.40743197),
        dec: Angle.Degrees(+60.79220478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27223"},
        {"Hipparcos Number", "HIP 20348"},
        {"Smithsonian Astrophysical Observation", "SAO 13110"},
    },
    visualMagnitude: 8.02,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.38082319),
        dec: Angle.Degrees(+60.79269834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8513",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8513"},
    },
    visualMagnitude: 10.64,
    bvColour: 0.761,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.45024897),
        dec: Angle.Degrees(+60.79356348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44492"},
        {"Hipparcos Number", "HIP 30617"},
        {"Smithsonian Astrophysical Observation", "SAO 13835"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.51151779),
        dec: Angle.Degrees(+60.79359558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68144",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68144"},
        {"Smithsonian Astrophysical Observation", "SAO 16228"},
    },
    visualMagnitude: 9.58,
    bvColour: 1.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.27292399),
        dec: Angle.Degrees(+60.79476485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134808"},
        {"Hipparcos Number", "HIP 74134"},
        {"Smithsonian Astrophysical Observation", "SAO 16613"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.24156956),
        dec: Angle.Degrees(+60.79631805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19653"},
        {"Hipparcos Number", "HIP 14953"},
        {"Geneva Identification System", "GEN# +1.00019653"},
        {"Renson", "Renson 4860"},
        {"Smithsonian Astrophysical Observation", "SAO 12656"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.19300789),
        dec: Angle.Degrees(+60.80101169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215575"},
        {"Hipparcos Number", "HIP 112304"},
        {"Geneva Identification System", "GEN# +1.00215575"},
        {"Smithsonian Astrophysical Observation", "SAO 20229"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.21385660),
        dec: Angle.Degrees(+60.81460101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110347"},
        {"Hipparcos Number", "HIP 61886"},
        {"Geneva Identification System", "GEN# +1.00110347"},
        {"Smithsonian Astrophysical Observation", "SAO 15867"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.21611625),
        dec: Angle.Degrees(+60.81465021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20475",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20475"},
        {"Smithsonian Astrophysical Observation", "SAO 13123"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.82737806),
        dec: Angle.Degrees(+60.81992538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111443"},
        {"Hipparcos Number", "HIP 62502"},
        {"Smithsonian Astrophysical Observation", "SAO 15906"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.11755162),
        dec: Angle.Degrees(+60.82021995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149650"},
        {"Hipparcos Number", "HIP 80991"},
        {"Fundamental Katalog 5th Edition", "FK5 1432"},
        {"Geneva Identification System", "GEN# +1.00149650"},
        {"Renson", "Renson 42340"},
        {"Smithsonian Astrophysical Observation", "SAO 17130"},
        {"Wilson Evans Batten Catalogue", "WEB 13697"},
    },
    visualMagnitude: 5.92,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.10689767),
        dec: Angle.Degrees(+60.82334694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189063"},
        {"Hipparcos Number", "HIP 97978"},
        {"Smithsonian Astrophysical Observation", "SAO 18589"},
        {"Wilson Evans Batten Catalogue", "WEB 17245"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.68309356),
        dec: Angle.Degrees(+60.82362382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214165"},
        {"Hipparcos Number", "HIP 111469"},
        {"Geneva Identification System", "GEN# +1.00214165"},
        {"Smithsonian Astrophysical Observation", "SAO 20161"},
        {"Wilson Evans Batten Catalogue", "WEB 19930"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.75177802),
        dec: Angle.Degrees(+60.82637321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22038",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22038"},
        {"Smithsonian Astrophysical Observation", "SAO 13246"},
    },
    visualMagnitude: 9.53,
    bvColour: 1.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.07553605),
        dec: Angle.Degrees(+60.82736282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151462"},
        {"Hipparcos Number", "HIP 81902"},
        {"Smithsonian Astrophysical Observation", "SAO 17202"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.93935310),
        dec: Angle.Degrees(+60.83107380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
