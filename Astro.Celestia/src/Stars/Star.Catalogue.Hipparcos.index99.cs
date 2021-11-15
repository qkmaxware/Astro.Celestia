using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_99() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42200",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42200"},
    },
    visualMagnitude: 10.74,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.07223795),
        dec: Angle.Degrees(+43.61747038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90561",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90561"},
        {"Smithsonian Astrophysical Observation", "SAO 47525"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.19018317),
        dec: Angle.Degrees(+43.61888413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44885",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44885"},
    },
    visualMagnitude: 10.86,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.18065544),
        dec: Angle.Degrees(+43.61957304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7067",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1192 AB"},
        {"Henry Draper", "HD 9169"},
        {"Hipparcos Number", "HIP 7067"},
        {"Smithsonian Astrophysical Observation", "SAO 37289"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.77081137),
        dec: Angle.Degrees(+43.62076417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11951"},
        {"Hipparcos Number", "HIP 9194"},
        {"Smithsonian Astrophysical Observation", "SAO 37662"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.59396733),
        dec: Angle.Degrees(+43.62200310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17316"},
        {"Hipparcos Number", "HIP 13086"},
        {"Smithsonian Astrophysical Observation", "SAO 38346"},
        {"Wilson Evans Batten Catalogue", "WEB 2640"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.05865719),
        dec: Angle.Degrees(+43.62255815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110215",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110215"},
    },
    visualMagnitude: 9.46,
    bvColour: 1.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.88675804),
        dec: Angle.Degrees(+43.62337617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41917",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41917"},
        {"Smithsonian Astrophysical Observation", "SAO 42418"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.18676173),
        dec: Angle.Degrees(+43.62491294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101107"},
        {"Hipparcos Number", "HIP 56770"},
        {"Geneva Identification System", "GEN# +1.00101107"},
        {"Smithsonian Astrophysical Observation", "SAO 43837"},
        {"Wilson Evans Batten Catalogue", "WEB 10215"},
    },
    visualMagnitude: 5.56,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.58619878),
        dec: Angle.Degrees(+43.62551361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -146.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96561",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96561"},
        {"Smithsonian Astrophysical Observation", "SAO 48664"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.845,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.46536935),
        dec: Angle.Degrees(+43.62596023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -214.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100616"},
        {"Hipparcos Number", "HIP 56502"},
        {"Smithsonian Astrophysical Observation", "SAO 43814"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.75125446),
        dec: Angle.Degrees(+43.62634570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67396",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67396"},
    },
    visualMagnitude: 11.65,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.18812306),
        dec: Angle.Degrees(+43.63320311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108675",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15547 AB"},
        {"Henry Draper", "HD 209246"},
        {"Hipparcos Number", "HIP 108675"},
        {"Geneva Identification System", "GEN# +1.00209246J"},
        {"Smithsonian Astrophysical Observation", "SAO 51552"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.23192699),
        dec: Angle.Degrees(+43.63516661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74463"},
        {"Hipparcos Number", "HIP 42998"},
        {"Smithsonian Astrophysical Observation", "SAO 42536"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.45066016),
        dec: Angle.Degrees(+43.63597901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3639"},
        {"Hipparcos Number", "HIP 3112"},
        {"Geneva Identification System", "GEN# +1.00003639"},
        {"Smithsonian Astrophysical Observation", "SAO 36557"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.90356414),
        dec: Angle.Degrees(+43.63680510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76955",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76955"},
        {"Smithsonian Astrophysical Observation", "SAO 45693"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.70424352),
        dec: Angle.Degrees(+43.63684080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83747"},
        {"Hipparcos Number", "HIP 47560"},
        {"Smithsonian Astrophysical Observation", "SAO 42983"},
        {"Wilson Evans Batten Catalogue", "WEB 8919"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.45472169),
        dec: Angle.Degrees(+43.63727076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10363"},
        {"Hipparcos Number", "HIP 7944"},
        {"Smithsonian Astrophysical Observation", "SAO 37443"},
        {"Wilson Evans Batten Catalogue", "WEB 1697"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.51615666),
        dec: Angle.Degrees(+43.63999415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12895"},
        {"Hipparcos Number", "HIP 9893"},
        {"Smithsonian Astrophysical Observation", "SAO 37782"},
    },
    visualMagnitude: 8.20,
    bvColour: -0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.82913473),
        dec: Angle.Degrees(+43.64192856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128902"},
        {"Hipparcos Number", "HIP 71568"},
        {"Geneva Identification System", "GEN# +1.00128902"},
        {"Smithsonian Astrophysical Observation", "SAO 45145"},
        {"Wilson Evans Batten Catalogue", "WEB 12342"},
    },
    visualMagnitude: 5.74,
    bvColour: 1.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.55279962),
        dec: Angle.Degrees(+43.64205288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -102.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3669",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3669"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.843,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.73612983),
        dec: Angle.Degrees(+43.64718619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -296.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63297"},
        {"Hipparcos Number", "HIP 38248"},
        {"Smithsonian Astrophysical Observation", "SAO 42025"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.53017566),
        dec: Angle.Degrees(+43.64718641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1904"},
        {"Hipparcos Number", "HIP 1871"},
        {"Smithsonian Astrophysical Observation", "SAO 36319"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.709,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.91313965),
        dec: Angle.Degrees(+43.64723639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 180.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 102.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99861",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13611 D"},
        {"Hipparcos Number", "HIP 99861"},
    },
    visualMagnitude: 9.53,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)15, 38.5300),
        dec: Angle.DegreesMinutesSeconds((int)+43, (int)38, 54.000)
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
    primaryId: "HIP 112020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214992"},
        {"Hipparcos Number", "HIP 112020"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.35505557),
        dec: Angle.Degrees(+43.64865499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3680",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3680"},
    },
    visualMagnitude: 10.60,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.77166866),
        dec: Angle.Degrees(+43.64920084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74361"},
        {"Hipparcos Number", "HIP 42941"},
        {"Geneva Identification System", "GEN# +1.00074361"},
        {"Smithsonian Astrophysical Observation", "SAO 42525"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.29587832),
        dec: Angle.Degrees(+43.64925829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146099"},
        {"Hipparcos Number", "HIP 79434"},
        {"Geneva Identification System", "GEN# +1.00146099"},
        {"Smithsonian Astrophysical Observation", "SAO 45966"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.17941690),
        dec: Angle.Degrees(+43.64957745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 118.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99862",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13611 ABC"},
        {"Henry Draper", "HD 192911"},
        {"Hipparcos Number", "HIP 99862"},
        {"Smithsonian Astrophysical Observation", "SAO 49388"},
        {"Wilson Evans Batten Catalogue", "WEB 17959"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.91773482),
        dec: Angle.Degrees(+43.64988840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9450",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9450"},
        {"Smithsonian Astrophysical Observation", "SAO 37703"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.37999977),
        dec: Angle.Degrees(+43.65069852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70420",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70420"},
        {"Smithsonian Astrophysical Observation", "SAO 45039"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.09515692),
        dec: Angle.Degrees(+44.39253272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21192"},
        {"Hipparcos Number", "HIP 16061"},
        {"Smithsonian Astrophysical Observation", "SAO 38837"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.72387331),
        dec: Angle.Degrees(+43.65578755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218878"},
        {"Hipparcos Number", "HIP 114476"},
        {"Smithsonian Astrophysical Observation", "SAO 52769"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.75575382),
        dec: Angle.Degrees(+43.65596082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90093",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90093"},
        {"Smithsonian Astrophysical Observation", "SAO 47449"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.77514392),
        dec: Angle.Degrees(+43.65647858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127286"},
        {"Hipparcos Number", "HIP 70848"},
        {"Smithsonian Astrophysical Observation", "SAO 45072"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.32768252),
        dec: Angle.Degrees(+43.65676985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15221",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15221"},
        {"Smithsonian Astrophysical Observation", "SAO 38690"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.706,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.05830537),
        dec: Angle.Degrees(+43.65715628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102857"},
        {"Hipparcos Number", "HIP 57748"},
        {"Geneva Identification System", "GEN# +1.00102857"},
        {"Smithsonian Astrophysical Observation", "SAO 43909"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.65096372),
        dec: Angle.Degrees(+43.65898753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29373"},
        {"Hipparcos Number", "HIP 21700"},
        {"Smithsonian Astrophysical Observation", "SAO 39673"},
        {"Wilson Evans Batten Catalogue", "WEB 4170"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.88746412),
        dec: Angle.Degrees(+43.65920394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187878"},
        {"Hipparcos Number", "HIP 97617"},
        {"Smithsonian Astrophysical Observation", "SAO 48891"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.60626765),
        dec: Angle.Degrees(+43.66113624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211179"},
        {"Hipparcos Number", "HIP 109806"},
        {"Smithsonian Astrophysical Observation", "SAO 51789"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.61023418),
        dec: Angle.Degrees(+43.66197635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84800"},
        {"Hipparcos Number", "HIP 48129"},
        {"Geneva Identification System", "GEN# +1.00084800"},
        {"Smithsonian Astrophysical Observation", "SAO 43050"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.18610887),
        dec: Angle.Degrees(+43.66551877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3022"},
        {"Hipparcos Number", "HIP 2668"},
        {"Smithsonian Astrophysical Observation", "SAO 36468"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.45380998),
        dec: Angle.Degrees(+43.66669610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49709"},
        {"Hipparcos Number", "HIP 32954"},
        {"Geneva Identification System", "GEN# +1.00049709"},
        {"Smithsonian Astrophysical Observation", "SAO 41393"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.96103479),
        dec: Angle.Degrees(+43.66875456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21727"},
        {"Hipparcos Number", "HIP 16467"},
        {"Geneva Identification System", "GEN# +1.00021727"},
        {"Smithsonian Astrophysical Observation", "SAO 38921"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.02023522),
        dec: Angle.Degrees(+43.67016156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 298.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59858",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59858"},
        {"Geneva Identification System", "GEN# +0.04402176"},
        {"Smithsonian Astrophysical Observation", "SAO 44099"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.13039411),
        dec: Angle.Degrees(+43.67186488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24095"},
        {"Hipparcos Number", "HIP 18099"},
        {"Smithsonian Astrophysical Observation", "SAO 39160"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.02879711),
        dec: Angle.Degrees(+43.67217254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82733"},
        {"Hipparcos Number", "HIP 47033"},
        {"Geneva Identification System", "GEN# +1.00082733"},
        {"Smithsonian Astrophysical Observation", "SAO 42929"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.78540741),
        dec: Angle.Degrees(+43.67326888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43862",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7092 AB"},
        {"Henry Draper", "HD 76171"},
        {"Hipparcos Number", "HIP 43862"},
        {"Smithsonian Astrophysical Observation", "SAO 42605"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.03004451),
        dec: Angle.Degrees(+43.67758248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100749",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100749"},
        {"Smithsonian Astrophysical Observation", "SAO 49605"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.40105552),
        dec: Angle.Degrees(+43.67782570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52307",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52307"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.32262362),
        dec: Angle.Degrees(+43.67813297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15451"},
        {"Hipparcos Number", "HIP 11680"},
        {"Geneva Identification System", "GEN# +1.00015451"},
        {"Smithsonian Astrophysical Observation", "SAO 38078"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.66362447),
        dec: Angle.Degrees(+43.67886586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223137"},
        {"Hipparcos Number", "HIP 117278"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.71678490),
        dec: Angle.Degrees(+43.67958470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214098"},
        {"Hipparcos Number", "HIP 111491"},
        {"Smithsonian Astrophysical Observation", "SAO 52163"},
    },
    visualMagnitude: 8.33,
    bvColour: -0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.82545684),
        dec: Angle.Degrees(+43.68108282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77051"},
        {"Hipparcos Number", "HIP 44321"},
        {"Smithsonian Astrophysical Observation", "SAO 42646"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.38987640),
        dec: Angle.Degrees(+43.68123903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38984",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38984"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.66151156),
        dec: Angle.Degrees(+43.68197715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83945",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83945"},
    },
    visualMagnitude: 11.77,
    bvColour: 1.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.38030802),
        dec: Angle.Degrees(+43.68202643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 333.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -278.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193115"},
        {"Hipparcos Number", "HIP 99960"},
        {"Smithsonian Astrophysical Observation", "SAO 49413"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.21573833),
        dec: Angle.Degrees(+43.68331306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153399"},
        {"Hipparcos Number", "HIP 82974"},
        {"Geneva Identification System", "GEN# +1.00153399"},
        {"Smithsonian Astrophysical Observation", "SAO 46393"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.33897357),
        dec: Angle.Degrees(+43.68372395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25973"},
        {"Hipparcos Number", "HIP 19346"},
        {"Smithsonian Astrophysical Observation", "SAO 39338"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.17208513),
        dec: Angle.Degrees(+43.68414577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27004"},
        {"Hipparcos Number", "HIP 20053"},
        {"Celescope Catalog", "CEL 379"},
        {"Geneva Identification System", "GEN# +1.00027004"},
        {"Smithsonian Astrophysical Observation", "SAO 39445"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.50500115),
        dec: Angle.Degrees(+43.68427955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38850"},
        {"Hipparcos Number", "HIP 27608"},
        {"Smithsonian Astrophysical Observation", "SAO 40644"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.68672536),
        dec: Angle.Degrees(+43.68937678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 276391"},
        {"Hipparcos Number", "HIP 20947"},
        {"Smithsonian Astrophysical Observation", "SAO 39563"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.36650919),
        dec: Angle.Degrees(+43.68992895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214179"},
        {"Hipparcos Number", "HIP 111552"},
        {"Smithsonian Astrophysical Observation", "SAO 52170"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.97700739),
        dec: Angle.Degrees(+43.69066984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8710"},
        {"Hipparcos Number", "HIP 6733"},
        {"Geneva Identification System", "GEN# +1.00008710"},
        {"Smithsonian Astrophysical Observation", "SAO 37214"},
        {"Wilson Evans Batten Catalogue", "WEB 1469"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.67921463),
        dec: Angle.Degrees(+43.69197059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 134.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1615"},
        {"Hipparcos Number", "HIP 1641"},
        {"Smithsonian Astrophysical Observation", "SAO 36279"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.13260063),
        dec: Angle.Degrees(+43.69432614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99633"},
        {"Hipparcos Number", "HIP 55965"},
        {"Smithsonian Astrophysical Observation", "SAO 43753"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.02819406),
        dec: Angle.Degrees(+43.69558820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44297"},
        {"Hipparcos Number", "HIP 30370"},
        {"Geneva Identification System", "GEN# +1.00044297"},
        {"Smithsonian Astrophysical Observation", "SAO 41057"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.80319587),
        dec: Angle.Degrees(+43.69767318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219306"},
        {"Hipparcos Number", "HIP 114729"},
        {"Geneva Identification System", "GEN# +1.00219306"},
        {"Smithsonian Astrophysical Observation", "SAO 52829"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.60819484),
        dec: Angle.Degrees(+43.69830564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22720"},
        {"Hipparcos Number", "HIP 17193"},
        {"Geneva Identification System", "GEN# +1.00022720"},
        {"Smithsonian Astrophysical Observation", "SAO 39035"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.23118053),
        dec: Angle.Degrees(+43.70198948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14402",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2334 AB"},
        {"Henry Draper", "HD 19092"},
        {"Henry Draper 2", "HD 19091"},
        {"Hipparcos Number", "HIP 14402"},
        {"Smithsonian Astrophysical Observation", "SAO 38564"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.44331353),
        dec: Angle.Degrees(+43.70247904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205601"},
        {"Hipparcos Number", "HIP 106578"},
        {"Celescope Catalog", "CEL 5345"},
        {"Geneva Identification System", "GEN# +1.00205601"},
        {"Smithsonian Astrophysical Observation", "SAO 51058"},
    },
    visualMagnitude: 6.81,
    bvColour: -0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.78599476),
        dec: Angle.Degrees(+43.70328887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105924"},
        {"Hipparcos Number", "HIP 59427"},
        {"Geneva Identification System", "GEN# +1.00105924"},
        {"Smithsonian Astrophysical Observation", "SAO 44068"},
    },
    visualMagnitude: 9.50,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.84908189),
        dec: Angle.Degrees(+43.70415207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66905",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66905"},
        {"Smithsonian Astrophysical Observation", "SAO 44721"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.67038663),
        dec: Angle.Degrees(+43.70516277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -314.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10773"},
        {"Hipparcos Number", "HIP 8257"},
        {"Wilson Evans Batten Catalogue", "WEB 1759"},
    },
    visualMagnitude: 7.48,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.57969549),
        dec: Angle.Degrees(+43.70570255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46493"},
        {"Hipparcos Number", "HIP 31511"},
        {"Geneva Identification System", "GEN# +1.00046493"},
        {"Smithsonian Astrophysical Observation", "SAO 41198"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.97795947),
        dec: Angle.Degrees(+43.70587267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185286"},
        {"Hipparcos Number", "HIP 96449"},
        {"Smithsonian Astrophysical Observation", "SAO 48642"},
    },
    visualMagnitude: 6.60,
    bvColour: 1.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.13508267),
        dec: Angle.Degrees(+43.70612391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8169",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1374 A"},
        {"Henry Draper", "HD 10673"},
        {"Henry Draper 2", "HD 10673A"},
        {"Hipparcos Number", "HIP 8169"},
        {"Smithsonian Astrophysical Observation", "SAO 37481"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.26043725),
        dec: Angle.Degrees(+43.70637137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61445",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61445"},
        {"Geneva Identification System", "GEN# +0.04402208"},
    },
    visualMagnitude: 10.49,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.87612003),
        dec: Angle.Degrees(+43.70750233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26607",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4236 AB"},
        {"Henry Draper", "HD 37265"},
        {"Hipparcos Number", "HIP 26607"},
        {"Smithsonian Astrophysical Observation", "SAO 40513"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.84396192),
        dec: Angle.Degrees(+43.70930011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77229",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77229"},
        {"Smithsonian Astrophysical Observation", "SAO 45716"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.52895105),
        dec: Angle.Degrees(+43.70944015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175226"},
        {"Hipparcos Number", "HIP 92615"},
        {"Geneva Identification System", "GEN# +1.00175226"},
        {"Smithsonian Astrophysical Observation", "SAO 47879"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.06884202),
        dec: Angle.Degrees(+43.70992236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57707",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57707"},
    },
    visualMagnitude: 10.39,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.51627063),
        dec: Angle.Degrees(+43.71003249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2837"},
        {"Hipparcos Number", "HIP 2534"},
        {"Renson", "Renson 670"},
        {"Smithsonian Astrophysical Observation", "SAO 36450"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.03729873),
        dec: Angle.Degrees(+43.71164016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130213"},
        {"Hipparcos Number", "HIP 72156"},
        {"Smithsonian Astrophysical Observation", "SAO 45210"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.37891591),
        dec: Angle.Degrees(+43.71205479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 109.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1681",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 288 A"},
        {"Henry Draper", "HD 1649"},
        {"Hipparcos Number", "HIP 1681"},
        {"Smithsonian Astrophysical Observation", "SAO 36288"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.25471548),
        dec: Angle.Degrees(+43.71306723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175370"},
        {"Hipparcos Number", "HIP 92668"},
        {"Smithsonian Astrophysical Observation", "SAO 47888"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.24893354),
        dec: Angle.Degrees(+43.71355449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45799"},
        {"Hipparcos Number", "HIP 31112"},
        {"Geneva Identification System", "GEN# +1.00045799"},
        {"Smithsonian Astrophysical Observation", "SAO 41151"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.92398167),
        dec: Angle.Degrees(+43.71446066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144722"},
        {"Hipparcos Number", "HIP 78823"},
        {"Smithsonian Astrophysical Observation", "SAO 45885"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.36408290),
        dec: Angle.Degrees(+43.71908174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129900"},
        {"Hipparcos Number", "HIP 72016"},
        {"Smithsonian Astrophysical Observation", "SAO 45193"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.94477730),
        dec: Angle.Degrees(+43.72089852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176626"},
        {"Hipparcos Number", "HIP 93204"},
        {"Geneva Identification System", "GEN# +1.00176626"},
        {"Smithsonian Astrophysical Observation", "SAO 47971"},
        {"Wilson Evans Batten Catalogue", "WEB 16158"},
    },
    visualMagnitude: 6.86,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.77396809),
        dec: Angle.Degrees(+43.72098335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 276481"},
        {"Hipparcos Number", "HIP 21175"},
        {"Smithsonian Astrophysical Observation", "SAO 39588"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.09396996),
        dec: Angle.Degrees(+43.72128130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95526"},
        {"Hipparcos Number", "HIP 53933"},
        {"Smithsonian Astrophysical Observation", "SAO 43583"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.53615209),
        dec: Angle.Degrees(+43.72135993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -121.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200311"},
        {"Hipparcos Number", "HIP 103736"},
        {"Celescope Catalog", "CEL 5231"},
        {"Geneva Identification System", "GEN# +1.00200311"},
        {"Renson", "Renson 55810"},
        {"Smithsonian Astrophysical Observation", "SAO 50358"},
    },
    visualMagnitude: 7.70,
    bvColour: -0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.30964370),
        dec: Angle.Degrees(+43.72178206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113241"},
        {"Hipparcos Number", "HIP 63590"},
        {"Geneva Identification System", "GEN# +1.00113241"},
        {"Smithsonian Astrophysical Observation", "SAO 44432"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.46602592),
        dec: Angle.Degrees(+43.72633894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75506"},
        {"Hipparcos Number", "HIP 43531"},
        {"Fundamental Katalog 5th Edition", "FK5 2700"},
        {"Geneva Identification System", "GEN# +1.00075506"},
        {"Smithsonian Astrophysical Observation", "SAO 42576"},
        {"Wilson Evans Batten Catalogue", "WEB 8389"},
    },
    visualMagnitude: 5.15,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.98684264),
        dec: Angle.Degrees(+43.72649196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27044"},
        {"Hipparcos Number", "HIP 20096"},
        {"Smithsonian Astrophysical Observation", "SAO 39452"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.62865806),
        dec: Angle.Degrees(+43.72710452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32328"},
        {"Hipparcos Number", "HIP 23603"},
        {"Celescope Catalog", "CEL 522"},
        {"Geneva Identification System", "GEN# +1.00032328"},
        {"Smithsonian Astrophysical Observation", "SAO 39995"},
        {"Wilson Evans Batten Catalogue", "WEB 4600"},
    },
    visualMagnitude: 7.64,
    bvColour: -0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.13634736),
        dec: Angle.Degrees(+43.72770666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80468",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80468"},
    },
    visualMagnitude: 11.87,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.37191811),
        dec: Angle.Degrees(+43.72996989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 119.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106326",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106326"},
        {"Smithsonian Astrophysical Observation", "SAO 50992"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.02329127),
        dec: Angle.Degrees(+43.73213830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93236",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11922 A"},
        {"Henry Draper", "HD 176694"},
        {"Hipparcos Number", "HIP 93236"},
        {"Smithsonian Astrophysical Observation", "SAO 47982"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.86953361),
        dec: Angle.Degrees(+43.73324719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174621"},
        {"Hipparcos Number", "HIP 92352"},
        {"Geneva Identification System", "GEN# +1.00174621"},
        {"Smithsonian Astrophysical Observation", "SAO 47831"},
        {"Wilson Evans Batten Catalogue", "WEB 15948"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.33611447),
        dec: Angle.Degrees(+43.73429004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97582",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97582"},
        {"Smithsonian Astrophysical Observation", "SAO 48882"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.51398514),
        dec: Angle.Degrees(+43.73447305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155921"},
        {"Hipparcos Number", "HIP 84169"},
        {"Geneva Identification System", "GEN# +1.00155921"},
        {"Smithsonian Astrophysical Observation", "SAO 46565"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.09548004),
        dec: Angle.Degrees(+43.73681612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 179.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82246"},
        {"Hipparcos Number", "HIP 46805"},
        {"Geneva Identification System", "GEN# +1.00082246"},
        {"Smithsonian Astrophysical Observation", "SAO 42907"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.06039316),
        dec: Angle.Degrees(+43.73887233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -129.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123876"},
        {"Hipparcos Number", "HIP 69131"},
        {"Smithsonian Astrophysical Observation", "SAO 44911"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.26109817),
        dec: Angle.Degrees(+43.74283616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118085",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118085"},
    },
    visualMagnitude: 10.67,
    bvColour: 0.718,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.30580741),
        dec: Angle.Degrees(+43.74350822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212247"},
        {"Hipparcos Number", "HIP 110421"},
        {"Smithsonian Astrophysical Observation", "SAO 51922"},
        {"Wilson Evans Batten Catalogue", "WEB 19803"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.49284090),
        dec: Angle.Degrees(+43.74498470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156403"},
        {"Hipparcos Number", "HIP 84396"},
        {"Smithsonian Astrophysical Observation", "SAO 46585"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.81793889),
        dec: Angle.Degrees(+43.74519356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222922"},
        {"Hipparcos Number", "HIP 117129"},
        {"Smithsonian Astrophysical Observation", "SAO 53337"},
        {"Wilson Evans Batten Catalogue", "WEB 20645"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.18915952),
        dec: Angle.Degrees(+43.74623851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201456"},
        {"Hipparcos Number", "HIP 104344"},
        {"Geneva Identification System", "GEN# +1.00201456"},
        {"Smithsonian Astrophysical Observation", "SAO 50487"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.07113060),
        dec: Angle.Degrees(+43.74758718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211338"},
        {"Hipparcos Number", "HIP 109893"},
        {"Smithsonian Astrophysical Observation", "SAO 51814"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.87157046),
        dec: Angle.Degrees(+43.74814907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94217"},
        {"Hipparcos Number", "HIP 53224"},
        {"Smithsonian Astrophysical Observation", "SAO 43504"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.29975876),
        dec: Angle.Degrees(+43.75357887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21377"},
        {"Hipparcos Number", "HIP 16188"},
        {"Smithsonian Astrophysical Observation", "SAO 38860"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.13801726),
        dec: Angle.Degrees(+43.75360781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76036",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76036"},
    },
    visualMagnitude: 10.73,
    bvColour: 1.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.93748571),
        dec: Angle.Degrees(+43.75368601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134111"},
        {"Hipparcos Number", "HIP 73946"},
        {"Smithsonian Astrophysical Observation", "SAO 45378"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.66029657),
        dec: Angle.Degrees(+43.75610747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102990",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14382 A"},
        {"Henry Draper", "HD 198896"},
        {"Hipparcos Number", "HIP 102990"},
        {"Wilson Evans Batten Catalogue", "WEB 18692"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.99430943),
        dec: Angle.Degrees(+43.75798134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15080"},
        {"Hipparcos Number", "HIP 11414"},
        {"Smithsonian Astrophysical Observation", "SAO 38032"},
    },
    visualMagnitude: 9.17,
    bvColour: -0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.77538412),
        dec: Angle.Degrees(+43.75909311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49197"},
        {"Hipparcos Number", "HIP 32702"},
        {"Geneva Identification System", "GEN# +1.00049197"},
        {"Smithsonian Astrophysical Observation", "SAO 41363"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.33902006),
        dec: Angle.Degrees(+43.75922967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89206"},
        {"Hipparcos Number", "HIP 50475"},
        {"Geneva Identification System", "GEN# +1.00089206"},
        {"Smithsonian Astrophysical Observation", "SAO 43275"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.59839297),
        dec: Angle.Degrees(+43.75924233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187139"},
        {"Hipparcos Number", "HIP 97315"},
        {"Celescope Catalog", "CEL 4842"},
        {"Geneva Identification System", "GEN# +1.00187139"},
        {"Smithsonian Astrophysical Observation", "SAO 48825"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.65232020),
        dec: Angle.Degrees(+43.76334429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17146"},
        {"Hipparcos Number", "HIP 12948"},
        {"Geneva Identification System", "GEN# +1.00017146"},
        {"Smithsonian Astrophysical Observation", "SAO 38320"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.63345749),
        dec: Angle.Degrees(+43.76511516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8939",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8939"},
    },
    visualMagnitude: 12.37,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.78455829),
        dec: Angle.Degrees(+43.76569619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111958"},
        {"Hipparcos Number", "HIP 62833"},
        {"Geneva Identification System", "GEN# +1.00111958"},
        {"Smithsonian Astrophysical Observation", "SAO 44366"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.14032506),
        dec: Angle.Degrees(+43.77097551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102794",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102794"},
        {"Geneva Identification System", "GEN# +0.04303732"},
        {"Smithsonian Astrophysical Observation", "SAO 50113"},
        {"Wilson Evans Batten Catalogue", "WEB 18642"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.38244505),
        dec: Angle.Degrees(+43.77269246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87556",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87556"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.30306364),
        dec: Angle.Degrees(+43.77314004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13931"},
        {"Hipparcos Number", "HIP 10626"},
        {"Geneva Identification System", "GEN# +1.00013931"},
        {"Smithsonian Astrophysical Observation", "SAO 37918"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.19708067),
        dec: Angle.Degrees(+43.77344263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -183.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211274"},
        {"Hipparcos Number", "HIP 109862"},
        {"Smithsonian Astrophysical Observation", "SAO 51806"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.76469855),
        dec: Angle.Degrees(+43.77344795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215271"},
        {"Hipparcos Number", "HIP 112182"},
    },
    visualMagnitude: 10.50,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.81340309),
        dec: Angle.Degrees(+43.77369854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5515",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5515"},
        {"Smithsonian Astrophysical Observation", "SAO 36990"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.64895626),
        dec: Angle.Degrees(+43.77536002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201232"},
        {"Hipparcos Number", "HIP 104208"},
        {"Smithsonian Astrophysical Observation", "SAO 50458"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.68792504),
        dec: Angle.Degrees(+43.78182622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165"},
        {"Hipparcos Number", "HIP 539"},
        {"Smithsonian Astrophysical Observation", "SAO 36064"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.64150277),
        dec: Angle.Degrees(+43.78227474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208023"},
        {"Hipparcos Number", "HIP 107953"},
        {"Smithsonian Astrophysical Observation", "SAO 51389"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.05600330),
        dec: Angle.Degrees(+43.78369075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152813"},
        {"Hipparcos Number", "HIP 82646"},
        {"Smithsonian Astrophysical Observation", "SAO 46354"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.40678274),
        dec: Angle.Degrees(+43.78372964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41522"},
        {"Hipparcos Number", "HIP 29059"},
        {"Smithsonian Astrophysical Observation", "SAO 40870"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.95092833),
        dec: Angle.Degrees(+43.78657203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101716"},
        {"Hipparcos Number", "HIP 57117"},
        {"Geneva Identification System", "GEN# +1.00101716"},
        {"Smithsonian Astrophysical Observation", "SAO 43871"},
        {"Wilson Evans Batten Catalogue", "WEB 10282"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.64425647),
        dec: Angle.Degrees(+43.78949357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117588"},
        {"Hipparcos Number", "HIP 65907"},
        {"Geneva Identification System", "GEN# +1.00117588"},
        {"Smithsonian Astrophysical Observation", "SAO 44632"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.65309973),
        dec: Angle.Degrees(+43.79030032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199373"},
        {"Hipparcos Number", "HIP 103268"},
        {"Geneva Identification System", "GEN# +1.00199373"},
        {"Smithsonian Astrophysical Observation", "SAO 50228"},
        {"Wilson Evans Batten Catalogue", "WEB 18765"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.81939687),
        dec: Angle.Degrees(+43.79063474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58600",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8392 AB"},
        {"Henry Draper", "HD 104334"},
        {"Hipparcos Number", "HIP 58600"},
        {"Smithsonian Astrophysical Observation", "SAO 43996"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.24758248),
        dec: Angle.Degrees(+43.79102072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1501",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 254 A"},
        {"Henry Draper", "HD 1438"},
        {"Hipparcos Number", "HIP 1501"},
        {"Geneva Identification System", "GEN# +1.00001438J"},
        {"Smithsonian Astrophysical Observation", "SAO 36256"},
        {"Wilson Evans Batten Catalogue", "WEB 277"},
    },
    visualMagnitude: 6.10,
    bvColour: -0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.67562512),
        dec: Angle.Degrees(+43.79114781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136136"},
        {"Hipparcos Number", "HIP 74817"},
        {"Smithsonian Astrophysical Observation", "SAO 45471"},
        {"Wilson Evans Batten Catalogue", "WEB 12762"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.34375743),
        dec: Angle.Degrees(+43.79358577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61995"},
        {"Hipparcos Number", "HIP 37674"},
        {"Fundamental Katalog 5th Edition", "FK5 2598"},
        {"Geneva Identification System", "GEN# +1.00061995"},
        {"Smithsonian Astrophysical Observation", "SAO 41963"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.94705092),
        dec: Angle.Degrees(+43.79469157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135046"},
        {"Hipparcos Number", "HIP 74322"},
        {"Smithsonian Astrophysical Observation", "SAO 45421"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.86252087),
        dec: Angle.Degrees(+43.79535683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172148"},
        {"Hipparcos Number", "HIP 91213"},
        {"Smithsonian Astrophysical Observation", "SAO 47641"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.11049216),
        dec: Angle.Degrees(+43.79675308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42195"},
        {"Hipparcos Number", "HIP 29378"},
        {"Smithsonian Astrophysical Observation", "SAO 40929"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.88361880),
        dec: Angle.Degrees(+43.79919305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56064",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56064"},
        {"Smithsonian Astrophysical Observation", "SAO 43773"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.35978910),
        dec: Angle.Degrees(+43.80102940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69142",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69142"},
        {"Smithsonian Astrophysical Observation", "SAO 44912"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.30288801),
        dec: Angle.Degrees(+43.80130812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85688"},
        {"Hipparcos Number", "HIP 48593"},
        {"Smithsonian Astrophysical Observation", "SAO 43096"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.64487685),
        dec: Angle.Degrees(+43.80164459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104928",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104928"},
        {"Smithsonian Astrophysical Observation", "SAO 50619"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.82134481),
        dec: Angle.Degrees(+43.80339460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116770",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116770"},
        {"Smithsonian Astrophysical Observation", "SAO 53256"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.98513962),
        dec: Angle.Degrees(+43.80622090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18285",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18285"},
        {"Smithsonian Astrophysical Observation", "SAO 39186"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.65583740),
        dec: Angle.Degrees(+43.80662739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107762"},
        {"Hipparcos Number", "HIP 60380"},
        {"Geneva Identification System", "GEN# +1.00107762"},
        {"Smithsonian Astrophysical Observation", "SAO 44147"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.70675763),
        dec: Angle.Degrees(+43.80832012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192496"},
        {"Hipparcos Number", "HIP 99654"},
        {"Celescope Catalog", "CEL 4979"},
        {"Geneva Identification System", "GEN# +1.00192496"},
        {"Smithsonian Astrophysical Observation", "SAO 49331"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.34913296),
        dec: Angle.Degrees(+43.81120304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154713"},
        {"Hipparcos Number", "HIP 83593"},
        {"Fundamental Katalog 5th Edition", "FK5 1448"},
        {"Geneva Identification System", "GEN# +1.00154713"},
        {"Smithsonian Astrophysical Observation", "SAO 46478"},
        {"Wilson Evans Batten Catalogue", "WEB 14133"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.27058505),
        dec: Angle.Degrees(+43.81223885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204375"},
        {"Hipparcos Number", "HIP 105893"},
        {"Smithsonian Astrophysical Observation", "SAO 50859"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.69403010),
        dec: Angle.Degrees(+43.81234319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95127"},
        {"Hipparcos Number", "HIP 53733"},
        {"Smithsonian Astrophysical Observation", "SAO 43558"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.89624364),
        dec: Angle.Degrees(+43.81449287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53704",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53704"},
        {"Smithsonian Astrophysical Observation", "SAO 43554"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.81800907),
        dec: Angle.Degrees(+43.81776906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14502"},
        {"Hipparcos Number", "HIP 11003"},
        {"Geneva Identification System", "GEN# +1.00014502"},
        {"Smithsonian Astrophysical Observation", "SAO 37973"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.44276440),
        dec: Angle.Degrees(+43.81812892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 775"},
        {"Hipparcos Number", "HIP 988"},
        {"Smithsonian Astrophysical Observation", "SAO 36153"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.06581410),
        dec: Angle.Degrees(+43.81821229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145675"},
        {"Hipparcos Number", "HIP 79248"},
        {"Geneva Identification System", "GEN# +1.00145675"},
        {"Smithsonian Astrophysical Observation", "SAO 45933"},
        {"Wilson Evans Batten Catalogue", "WEB 13400"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.877,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.60086331),
        dec: Angle.Degrees(+43.81836990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 132.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -298.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147639"},
        {"Hipparcos Number", "HIP 80113"},
        {"Geneva Identification System", "GEN# +1.00147639"},
        {"Smithsonian Astrophysical Observation", "SAO 46044"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.29963436),
        dec: Angle.Degrees(+43.81976382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112610"},
        {"Hipparcos Number", "HIP 63241"},
        {"Geneva Identification System", "GEN# +1.00112610"},
        {"Smithsonian Astrophysical Observation", "SAO 44401"},
        {"Wilson Evans Batten Catalogue", "WEB 11208"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.37286724),
        dec: Angle.Degrees(+43.82212333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116153",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16818 AB"},
        {"Henry Draper", "HD 221460"},
        {"Hipparcos Number", "HIP 116153"},
        {"Smithsonian Astrophysical Observation", "SAO 53124"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.00550220),
        dec: Angle.Degrees(+43.82237410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23416",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Almaaz"},
        {"Aitken", "ADS 3605 A"},
        {"Henry Draper", "HD 31964"},
        {"Hipparcos Number", "HIP 23416"},
        {"Fundamental Katalog 5th Edition", "FK5 183"},
        {"Geneva Identification System", "GEN# +1.00031964J"},
        {"Smithsonian Astrophysical Observation", "SAO 39955"},
        {"Wilson Evans Batten Catalogue", "WEB 4548"},
    },
    visualMagnitude: 3.03,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.49222507),
        dec: Angle.Degrees(+43.82331397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79143"},
        {"Hipparcos Number", "HIP 45281"},
        {"Smithsonian Astrophysical Observation", "SAO 42757"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.43151874),
        dec: Angle.Degrees(+43.82784955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110437",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110437"},
        {"Smithsonian Astrophysical Observation", "SAO 51925"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.53713943),
        dec: Angle.Degrees(+43.82850775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17825"},
        {"Hipparcos Number", "HIP 13450"},
        {"Smithsonian Astrophysical Observation", "SAO 38417"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.29882797),
        dec: Angle.Degrees(+43.82882898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201504"},
        {"Hipparcos Number", "HIP 104372"},
        {"Celescope Catalog", "CEL 5250"},
        {"Geneva Identification System", "GEN# +1.00201504"},
        {"Smithsonian Astrophysical Observation", "SAO 50491"},
    },
    visualMagnitude: 8.09,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.16518597),
        dec: Angle.Degrees(+43.82904796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34278",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34278"},
    },
    visualMagnitude: 11.12,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.59217586),
        dec: Angle.Degrees(+43.83096675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215508"},
        {"Hipparcos Number", "HIP 112318"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.25112368),
        dec: Angle.Degrees(+43.83143865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173701"},
        {"Hipparcos Number", "HIP 91949"},
        {"Cincinnati Publication", "Ci 18 2455"},
        {"Geneva Identification System", "GEN# +1.00173701"},
        {"Smithsonian Astrophysical Observation", "SAO 47755"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.843,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.14668506),
        dec: Angle.Degrees(+43.83327937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -106.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49083"},
        {"Hipparcos Number", "HIP 32665"},
        {"Geneva Identification System", "GEN# +1.00049083"},
        {"Smithsonian Astrophysical Observation", "SAO 41357"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.20445088),
        dec: Angle.Degrees(+43.83484049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102113",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14176 A"},
        {"Henry Draper", "HD 197374"},
        {"Hipparcos Number", "HIP 102113"},
        {"Celescope Catalog", "CEL 5145"},
        {"Geneva Identification System", "GEN# +1.00197374"},
        {"Renson", "Renson 55020"},
        {"Wilson Evans Batten Catalogue", "WEB 18473"},
    },
    visualMagnitude: 8.36,
    bvColour: -0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.40443596),
        dec: Angle.Degrees(+43.83675851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46539",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46539"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.37827849),
        dec: Angle.Degrees(+43.83743004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217227"},
        {"Hipparcos Number", "HIP 113469"},
        {"Geneva Identification System", "GEN# +1.00217227"},
        {"Smithsonian Astrophysical Observation", "SAO 52551"},
        {"Wilson Evans Batten Catalogue", "WEB 20177"},
    },
    visualMagnitude: 7.18,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.69058555),
        dec: Angle.Degrees(+43.83876646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115460"},
        {"Hipparcos Number", "HIP 64785"},
        {"Geneva Identification System", "GEN# +1.00115460"},
        {"Smithsonian Astrophysical Observation", "SAO 44542"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.16996716),
        dec: Angle.Degrees(+43.83933119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66113"},
        {"Hipparcos Number", "HIP 39463"},
        {"Geneva Identification System", "GEN# +1.00066113"},
        {"Smithsonian Astrophysical Observation", "SAO 42148"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.98940941),
        dec: Angle.Degrees(+43.83943463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185835"},
        {"Hipparcos Number", "HIP 96661"},
        {"Celescope Catalog", "CEL 4809"},
        {"Geneva Identification System", "GEN# +1.00185835"},
        {"Smithsonian Astrophysical Observation", "SAO 48684"},
    },
    visualMagnitude: 7.97,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.79244645),
        dec: Angle.Degrees(+43.83951325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89655",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11247 ABC"},
        {"Hipparcos Number", "HIP 89655"},
        {"Smithsonian Astrophysical Observation", "SAO 47365"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.45638032),
        dec: Angle.Degrees(+43.84224659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54715"},
        {"Hipparcos Number", "HIP 34778"},
        {"Geneva Identification System", "GEN# +1.00054715"},
        {"Smithsonian Astrophysical Observation", "SAO 41614"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.00455795),
        dec: Angle.Degrees(+43.84304281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216108"},
        {"Hipparcos Number", "HIP 112707"},
        {"Smithsonian Astrophysical Observation", "SAO 52397"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.36816375),
        dec: Angle.Degrees(+43.84355740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184104"},
        {"Hipparcos Number", "HIP 95970"},
        {"Smithsonian Astrophysical Observation", "SAO 48537"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.73848316),
        dec: Angle.Degrees(+43.84498194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1152",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 179 AB"},
        {"Henry Draper", "HD 982"},
        {"Hipparcos Number", "HIP 1152"},
        {"Wilson Evans Batten Catalogue", "WEB 202"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.59842420),
        dec: Angle.Degrees(+43.84587555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177198"},
        {"Hipparcos Number", "HIP 93426"},
        {"Geneva Identification System", "GEN# +1.00177198"},
        {"Smithsonian Astrophysical Observation", "SAO 48014"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.41365057),
        dec: Angle.Degrees(+43.84595055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140139"},
        {"Hipparcos Number", "HIP 76752"},
        {"Geneva Identification System", "GEN# +1.00140139"},
        {"Smithsonian Astrophysical Observation", "SAO 45672"},
        {"Wilson Evans Batten Catalogue", "WEB 13027"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.08933806),
        dec: Angle.Degrees(+43.84621826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16200",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16200"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.17710469),
        dec: Angle.Degrees(+43.84827000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123657"},
        {"Hipparcos Number", "HIP 69038"},
        {"Fundamental Katalog 5th Edition", "FK5 1368"},
        {"Geneva Identification System", "GEN# +1.00123657"},
        {"Smithsonian Astrophysical Observation", "SAO 44901"},
        {"Wilson Evans Batten Catalogue", "WEB 12058"},
    },
    visualMagnitude: 5.13,
    bvColour: 1.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.98227724),
        dec: Angle.Degrees(+43.85452480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100287",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13736 AB"},
        {"Henry Draper", "HD 193793"},
        {"Hipparcos Number", "HIP 100287"},
        {"Celescope Catalog", "CEL 5033"},
        {"Smithsonian Astrophysical Observation", "SAO 49491"},
        {"Wilson Evans Batten Catalogue", "WEB 18089"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.11658414),
        dec: Angle.Degrees(+43.85452638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71048"},
        {"Hipparcos Number", "HIP 41434"},
        {"Smithsonian Astrophysical Observation", "SAO 42362"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.75966191),
        dec: Angle.Degrees(+43.85827221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5573"},
        {"Hipparcos Number", "HIP 4535"},
        {"Smithsonian Astrophysical Observation", "SAO 36803"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.51321114),
        dec: Angle.Degrees(+43.85884362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19769"},
        {"Hipparcos Number", "HIP 14922"},
        {"Geneva Identification System", "GEN# +1.00019769"},
        {"Smithsonian Astrophysical Observation", "SAO 38642"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.12615771),
        dec: Angle.Degrees(+43.86062966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 173.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19942"},
        {"Hipparcos Number", "HIP 15041"},
        {"Geneva Identification System", "GEN# +1.00019942"},
        {"Smithsonian Astrophysical Observation", "SAO 38659"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.46328043),
        dec: Angle.Degrees(+43.86318563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224601"},
        {"Hipparcos Number", "HIP 118263"},
        {"Geneva Identification System", "GEN# +1.00224601"},
        {"Smithsonian Astrophysical Observation", "SAO 53551"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.81021303),
        dec: Angle.Degrees(+43.86359533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220910"},
        {"Hipparcos Number", "HIP 115775"},
        {"Fundamental Katalog 5th Edition", "FK5 6072"},
        {"Geneva Identification System", "GEN# +1.00220910"},
        {"Smithsonian Astrophysical Observation", "SAO 53043"},
        {"Wilson Evans Batten Catalogue", "WEB 20487"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.83148153),
        dec: Angle.Degrees(+43.86366532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139907"},
        {"Hipparcos Number", "HIP 76641"},
        {"Smithsonian Astrophysical Observation", "SAO 45660"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.76365906),
        dec: Angle.Degrees(+43.86643673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114299",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114299"},
        {"Smithsonian Astrophysical Observation", "SAO 52736"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.22968315),
        dec: Angle.Degrees(+43.87061695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95088"},
        {"Hipparcos Number", "HIP 53707"},
        {"Geneva Identification System", "GEN# +1.00095088"},
        {"Smithsonian Astrophysical Observation", "SAO 43555"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.82491322),
        dec: Angle.Degrees(+43.87344552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202253"},
        {"Hipparcos Number", "HIP 104742"},
        {"Geneva Identification System", "GEN# +1.00202253"},
        {"Smithsonian Astrophysical Observation", "SAO 50583"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.28922330),
        dec: Angle.Degrees(+43.87378439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96634",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96634"},
        {"Smithsonian Astrophysical Observation", "SAO 48680"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.805,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.71318301),
        dec: Angle.Degrees(+43.87449867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -322.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8855"},
        {"Hipparcos Number", "HIP 6848"},
        {"Renson", "Renson 2140"},
        {"Smithsonian Astrophysical Observation", "SAO 37238"},
    },
    visualMagnitude: 8.20,
    bvColour: -0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.02358893),
        dec: Angle.Degrees(+43.87747074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93656",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12016 AB"},
        {"Henry Draper", "HD 177829"},
        {"Hipparcos Number", "HIP 93656"},
        {"Smithsonian Astrophysical Observation", "SAO 48054"},
        {"Wilson Evans Batten Catalogue", "WEB 16272"},
    },
    visualMagnitude: 6.99,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.06552332),
        dec: Angle.Degrees(+43.88037616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45637"},
        {"Hipparcos Number", "HIP 31035"},
        {"Smithsonian Astrophysical Observation", "SAO 41138"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.68804980),
        dec: Angle.Degrees(+43.88081618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4278"},
        {"Hipparcos Number", "HIP 3565"},
        {"Geneva Identification System", "GEN# +1.00004278"},
        {"Smithsonian Astrophysical Observation", "SAO 36630"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.39316410),
        dec: Angle.Degrees(+43.88310811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218220"},
        {"Hipparcos Number", "HIP 114048"},
        {"Smithsonian Astrophysical Observation", "SAO 52672"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.44715292),
        dec: Angle.Degrees(+43.88479129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216961"},
        {"Hipparcos Number", "HIP 113300"},
        {"Smithsonian Astrophysical Observation", "SAO 52521"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.17543168),
        dec: Angle.Degrees(+43.88750391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207754"},
        {"Hipparcos Number", "HIP 107792"},
        {"Smithsonian Astrophysical Observation", "SAO 51353"},
        {"Wilson Evans Batten Catalogue", "WEB 19440"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.54552746),
        dec: Angle.Degrees(+43.88829356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106885",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106885"},
        {"Smithsonian Astrophysical Observation", "SAO 51140"},
    },
    visualMagnitude: 9.38,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.73880592),
        dec: Angle.Degrees(+43.88992713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81388",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81388"},
        {"Smithsonian Astrophysical Observation", "SAO 46195"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.32089010),
        dec: Angle.Degrees(+43.89012822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209318"},
        {"Hipparcos Number", "HIP 108728"},
        {"Geneva Identification System", "GEN# +1.00209318"},
        {"Smithsonian Astrophysical Observation", "SAO 51563"},
        {"Wilson Evans Batten Catalogue", "WEB 19565"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.37789344),
        dec: Angle.Degrees(+43.89040436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179817"},
        {"Hipparcos Number", "HIP 94324"},
        {"Smithsonian Astrophysical Observation", "SAO 48183"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.98545713),
        dec: Angle.Degrees(+43.89052495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110702",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110702"},
        {"Smithsonian Astrophysical Observation", "SAO 51982"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.43587637),
        dec: Angle.Degrees(+43.89478498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9393"},
        {"Hipparcos Number", "HIP 7234"},
        {"Renson", "Renson 2270"},
        {"Smithsonian Astrophysical Observation", "SAO 37305"},
    },
    visualMagnitude: 8.63,
    bvColour: -0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.31458203),
        dec: Angle.Degrees(+43.89588355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130407"},
        {"Hipparcos Number", "HIP 72263"},
        {"Smithsonian Astrophysical Observation", "SAO 45214"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.765,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.65973442),
        dec: Angle.Degrees(+43.89882227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -111.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -134.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223129"},
        {"Hipparcos Number", "HIP 117273"},
        {"Smithsonian Astrophysical Observation", "SAO 53365"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.70377990),
        dec: Angle.Degrees(+43.89951608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199547"},
        {"Hipparcos Number", "HIP 103356"},
        {"Fundamental Katalog 5th Edition", "FK5 5842"},
        {"Geneva Identification System", "GEN# +1.00199547"},
        {"Smithsonian Astrophysical Observation", "SAO 50260"},
        {"Wilson Evans Batten Catalogue", "WEB 18789"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.10188647),
        dec: Angle.Degrees(+43.90070600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109919",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15794 AB"},
        {"Henry Draper", "HD 211405"},
        {"Hipparcos Number", "HIP 109919"},
        {"Geneva Identification System", "GEN# +1.00211405J"},
        {"Smithsonian Astrophysical Observation", "SAO 51815"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.95249099),
        dec: Angle.Degrees(+43.90076000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73023",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73023"},
    },
    visualMagnitude: 10.97,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.85800699),
        dec: Angle.Degrees(+43.90170739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116303"},
        {"Hipparcos Number", "HIP 65230"},
        {"Geneva Identification System", "GEN# +1.00116303"},
        {"Renson", "Renson 33560"},
        {"Smithsonian Astrophysical Observation", "SAO 44582"},
        {"Wilson Evans Batten Catalogue", "WEB 11513"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.51654896),
        dec: Angle.Degrees(+43.90333351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221681"},
        {"Hipparcos Number", "HIP 116312"},
        {"Smithsonian Astrophysical Observation", "SAO 53151"},
    },
    visualMagnitude: 6.93,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.49244036),
        dec: Angle.Degrees(+43.90421322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172242"},
        {"Hipparcos Number", "HIP 91274"},
        {"Geneva Identification System", "GEN# +1.00172242"},
        {"Smithsonian Astrophysical Observation", "SAO 47654"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.26641112),
        dec: Angle.Degrees(+43.90525009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50766",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7737 AB"},
        {"Henry Draper", "HD 89686"},
        {"Hipparcos Number", "HIP 50766"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.50232078),
        dec: Angle.Degrees(+43.90538177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44882"},
        {"Hipparcos Number", "HIP 30654"},
        {"Smithsonian Astrophysical Observation", "SAO 41100"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.61455294),
        dec: Angle.Degrees(+43.90614246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67634",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67634"},
        {"Smithsonian Astrophysical Observation", "SAO 44779"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.87032051),
        dec: Angle.Degrees(+43.90626601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105442"},
        {"Hipparcos Number", "HIP 59193"},
        {"Geneva Identification System", "GEN# +1.00105442"},
        {"Smithsonian Astrophysical Observation", "SAO 44047"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.08585165),
        dec: Angle.Degrees(+43.90709433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169746"},
        {"Hipparcos Number", "HIP 90170"},
        {"Smithsonian Astrophysical Observation", "SAO 47462"},
        {"Wilson Evans Batten Catalogue", "WEB 15418"},
    },
    visualMagnitude: 6.63,
    bvColour: 1.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.99976776),
        dec: Angle.Degrees(+43.90774346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59189",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59189"},
    },
    visualMagnitude: 9.21,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)08, 18.8700),
        dec: Angle.DegreesMinutesSeconds((int)+43, (int)54, 28.000)
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
    primaryId: "HIP 64694",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64694"},
        {"Geneva Identification System", "GEN# +0.04402259"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.89564207),
        dec: Angle.Degrees(+43.90834983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50420"},
        {"Hipparcos Number", "HIP 33269"},
        {"Geneva Identification System", "GEN# +1.00050420"},
        {"Renson", "Renson 13800"},
        {"Smithsonian Astrophysical Observation", "SAO 41429"},
        {"Wilson Evans Batten Catalogue", "WEB 6689"},
    },
    visualMagnitude: 6.16,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.81106808),
        dec: Angle.Degrees(+43.91004808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95295"},
        {"Hipparcos Number", "HIP 53831"},
        {"Smithsonian Astrophysical Observation", "SAO 43566"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.20138569),
        dec: Angle.Degrees(+43.91196559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9059",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9059"},
        {"Geneva Identification System", "GEN# +0.04300395"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.16018885),
        dec: Angle.Degrees(+43.91300620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -201.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217335"},
        {"Hipparcos Number", "HIP 113524"},
        {"Smithsonian Astrophysical Observation", "SAO 52567"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.87685302),
        dec: Angle.Degrees(+43.91383036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177932"},
        {"Hipparcos Number", "HIP 93679"},
        {"Smithsonian Astrophysical Observation", "SAO 48059"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.15698612),
        dec: Angle.Degrees(+43.91453878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60984"},
        {"Hipparcos Number", "HIP 37259"},
        {"Smithsonian Astrophysical Observation", "SAO 41911"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.77569758),
        dec: Angle.Degrees(+43.91566940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96992"},
        {"Hipparcos Number", "HIP 54595"},
        {"Smithsonian Astrophysical Observation", "SAO 43634"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.59698301),
        dec: Angle.Degrees(+43.91897305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 276575"},
        {"Hipparcos Number", "HIP 21671"},
    },
    visualMagnitude: 10.19,
    bvColour: 1.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.78395494),
        dec: Angle.Degrees(+43.92218154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170594"},
        {"Hipparcos Number", "HIP 90517"},
        {"Smithsonian Astrophysical Observation", "SAO 47517"},
        {"Wilson Evans Batten Catalogue", "WEB 15503"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.04443172),
        dec: Angle.Degrees(+43.92614383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93582"},
        {"Hipparcos Number", "HIP 52881"},
        {"Geneva Identification System", "GEN# +1.00093582"},
        {"Smithsonian Astrophysical Observation", "SAO 43480"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.23868686),
        dec: Angle.Degrees(+43.92746583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200905"},
        {"Hipparcos Number", "HIP 104060"},
        {"Fundamental Katalog 5th Edition", "FK5 792"},
        {"Geneva Identification System", "GEN# +1.00200905"},
        {"Smithsonian Astrophysical Observation", "SAO 50424"},
        {"Wilson Evans Batten Catalogue", "WEB 18956"},
    },
    visualMagnitude: 3.72,
    bvColour: 1.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.23273251),
        dec: Angle.Degrees(+43.92785122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219652"},
        {"Hipparcos Number", "HIP 114963"},
        {"Smithsonian Astrophysical Observation", "SAO 52859"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.27343503),
        dec: Angle.Degrees(+43.92819883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191377"},
        {"Hipparcos Number", "HIP 99156"},
        {"Geneva Identification System", "GEN# +1.00191377"},
        {"Smithsonian Astrophysical Observation", "SAO 49209"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.786,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.95388675),
        dec: Angle.Degrees(+43.92968412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169510"},
        {"Hipparcos Number", "HIP 90072"},
        {"Geneva Identification System", "GEN# +1.00169510"},
        {"Smithsonian Astrophysical Observation", "SAO 47442"},
        {"Wilson Evans Batten Catalogue", "WEB 15397"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.71717465),
        dec: Angle.Degrees(+43.93232007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94806"},
        {"Hipparcos Number", "HIP 53553"},
        {"Geneva Identification System", "GEN# +1.00094806"},
        {"Smithsonian Astrophysical Observation", "SAO 43543"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.33129207),
        dec: Angle.Degrees(+43.93626410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3934"},
        {"Hipparcos Number", "HIP 3324"},
        {"Smithsonian Astrophysical Observation", "SAO 36588"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.59105968),
        dec: Angle.Degrees(+43.93744053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36468"},
        {"Hipparcos Number", "HIP 26116"},
        {"Celescope Catalog", "CEL 780"},
        {"Geneva Identification System", "GEN# +1.00036468"},
        {"Smithsonian Astrophysical Observation", "SAO 40434"},
        {"Wilson Evans Batten Catalogue", "WEB 5085"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.53966205),
        dec: Angle.Degrees(+43.93752054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45595"},
        {"Hipparcos Number", "HIP 31013"},
        {"Geneva Identification System", "GEN# +1.00045595"},
        {"Smithsonian Astrophysical Observation", "SAO 41133"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.61774375),
        dec: Angle.Degrees(+43.93788237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170778"},
        {"Hipparcos Number", "HIP 90586"},
        {"Geneva Identification System", "GEN# +1.00170778"},
        {"Smithsonian Astrophysical Observation", "SAO 47529"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.26613300),
        dec: Angle.Degrees(+43.93890985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 155.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221234"},
        {"Hipparcos Number", "HIP 115977"},
        {"Smithsonian Astrophysical Observation", "SAO 53083"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.46193735),
        dec: Angle.Degrees(+43.94067008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6658"},
        {"Hipparcos Number", "HIP 5317"},
        {"Fundamental Katalog 5th Edition", "FK5 2071"},
        {"Geneva Identification System", "GEN# +1.00006658"},
        {"Renson", "Renson 1720"},
        {"Smithsonian Astrophysical Observation", "SAO 36950"},
        {"Wilson Evans Batten Catalogue", "WEB 1140"},
    },
    visualMagnitude: 5.04,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.00299391),
        dec: Angle.Degrees(+43.94224107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 160.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99376",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13461 AB"},
        {"Henry Draper", "HD 191854"},
        {"Hipparcos Number", "HIP 99376"},
        {"Geneva Identification System", "GEN# +1.00191854"},
        {"Smithsonian Astrophysical Observation", "SAO 49262"},
        {"Wilson Evans Batten Catalogue", "WEB 17736"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.55547863),
        dec: Angle.Degrees(+43.94538133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 78.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184905"},
        {"Hipparcos Number", "HIP 96292"},
        {"Celescope Catalog", "CEL 4790"},
        {"Geneva Identification System", "GEN# +1.00184905"},
        {"Renson", "Renson 51000"},
        {"Smithsonian Astrophysical Observation", "SAO 48604"},
        {"Wilson Evans Batten Catalogue", "WEB 16881"},
    },
    visualMagnitude: 6.64,
    bvColour: -0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.68297212),
        dec: Angle.Degrees(+43.94585769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175865"},
        {"Hipparcos Number", "HIP 92862"},
        {"Fundamental Katalog 5th Edition", "FK5 711"},
        {"Geneva Identification System", "GEN# +1.00175865"},
        {"Smithsonian Astrophysical Observation", "SAO 47919"},
        {"Wilson Evans Batten Catalogue", "WEB 16075"},
    },
    visualMagnitude: 4.08,
    bvColour: 1.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.83368820),
        dec: Angle.Degrees(+43.94589260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 80.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203064"},
        {"Hipparcos Number", "HIP 105186"},
        {"Celescope Catalog", "CEL 5290"},
        {"Fundamental Katalog 5th Edition", "FK5 3701"},
        {"Geneva Identification System", "GEN# +1.00203064"},
        {"Smithsonian Astrophysical Observation", "SAO 50690"},
        {"Wilson Evans Batten Catalogue", "WEB 19103"},
    },
    visualMagnitude: 5.04,
    bvColour: -0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.61325695),
        dec: Angle.Degrees(+43.94596690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2739"},
        {"Hipparcos Number", "HIP 2455"},
        {"Smithsonian Astrophysical Observation", "SAO 36436"},
        {"Wilson Evans Batten Catalogue", "WEB 447"},
    },
    visualMagnitude: 6.76,
    bvColour: -0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.80376689),
        dec: Angle.Degrees(+43.94655192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187091"},
        {"Hipparcos Number", "HIP 97279"},
        {"Smithsonian Astrophysical Observation", "SAO 48816"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.56465463),
        dec: Angle.Degrees(+43.94758352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83086",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83086"},
        {"Smithsonian Astrophysical Observation", "SAO 46418"},
    },
    visualMagnitude: 9.59,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.66320895),
        dec: Angle.Degrees(+43.94924949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41401",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41401"},
    },
    visualMagnitude: 11.61,
    bvColour: 1.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.68715375),
        dec: Angle.Degrees(+43.94989173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -117.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70733"},
        {"Hipparcos Number", "HIP 41284"},
        {"Smithsonian Astrophysical Observation", "SAO 42350"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.33877967),
        dec: Angle.Degrees(+43.95062245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5064"},
        {"Hipparcos Number", "HIP 4143"},
        {"Smithsonian Astrophysical Observation", "SAO 36742"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.24299155),
        dec: Angle.Degrees(+43.95164894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61954",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61954"},
        {"Smithsonian Astrophysical Observation", "SAO 44290"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.45855531),
        dec: Angle.Degrees(+43.95234251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6247",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1079 AB"},
        {"Henry Draper", "HD 7995"},
        {"Hipparcos Number", "HIP 6247"},
        {"Smithsonian Astrophysical Observation", "SAO 37125"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.748,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.03419280),
        dec: Angle.Degrees(+43.95263283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18400"},
        {"Hipparcos Number", "HIP 13903"},
        {"Smithsonian Astrophysical Observation", "SAO 38487"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.74777916),
        dec: Angle.Degrees(+43.95551089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174880"},
        {"Hipparcos Number", "HIP 92472"},
        {"Geneva Identification System", "GEN# +1.00174880"},
        {"Smithsonian Astrophysical Observation", "SAO 47847"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.68002787),
        dec: Angle.Degrees(+43.95737720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15797",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15797"},
        {"Smithsonian Astrophysical Observation", "SAO 38775"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.88912681),
        dec: Angle.Degrees(+43.95809928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 120.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -334.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102359",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102359"},
        {"Geneva Identification System", "GEN# +0.04303701"},
        {"Smithsonian Astrophysical Observation", "SAO 50008"},
        {"Wilson Evans Batten Catalogue", "WEB 18531"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.09358525),
        dec: Angle.Degrees(+43.95936281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108240",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108240"},
        {"Smithsonian Astrophysical Observation", "SAO 51451"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.92171663),
        dec: Angle.Degrees(+43.96141137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39494",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39494"},
        {"Geneva Identification System", "GEN# +0.04401710"},
        {"Wilson Evans Batten Catalogue", "WEB 7722"},
    },
    visualMagnitude: 9.83,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.09423113),
        dec: Angle.Degrees(+43.96171622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 147.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23728"},
        {"Hipparcos Number", "HIP 17846"},
        {"Geneva Identification System", "GEN# +1.00023728"},
        {"Smithsonian Astrophysical Observation", "SAO 39128"},
        {"Wilson Evans Batten Catalogue", "WEB 3424"},
    },
    visualMagnitude: 5.95,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.28384500),
        dec: Angle.Degrees(+43.96302293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99706"},
        {"Hipparcos Number", "HIP 55994"},
        {"Smithsonian Astrophysical Observation", "SAO 43758"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.12573643),
        dec: Angle.Degrees(+43.96679183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178821"},
        {"Hipparcos Number", "HIP 93971"},
        {"Geneva Identification System", "GEN# +1.00178821"},
        {"Smithsonian Astrophysical Observation", "SAO 48120"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.00270123),
        dec: Angle.Degrees(+43.96708056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100753",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100753"},
        {"Smithsonian Astrophysical Observation", "SAO 49607"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.41507178),
        dec: Angle.Degrees(+43.96757246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7690",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7690"},
        {"Smithsonian Astrophysical Observation", "SAO 37401"},
    },
    visualMagnitude: 9.65,
    bvColour: 1.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.74640107),
        dec: Angle.Degrees(+43.96787025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159001"},
        {"Hipparcos Number", "HIP 85650"},
        {"Smithsonian Astrophysical Observation", "SAO 46754"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.55931690),
        dec: Angle.Degrees(+43.96900145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -224.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -288.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40441",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40441"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.86528536),
        dec: Angle.Degrees(+43.96983657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 391",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 39 AB"},
        {"Henry Draper", "HD 225258"},
        {"Hipparcos Number", "HIP 391"},
        {"Smithsonian Astrophysical Observation", "SAO 36039"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.21196013),
        dec: Angle.Degrees(+43.97079063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221303"},
        {"Hipparcos Number", "HIP 116031"},
        {"Smithsonian Astrophysical Observation", "SAO 53100"},
        {"Wilson Evans Batten Catalogue", "WEB 20518"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.66654372),
        dec: Angle.Degrees(+43.97577145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64958"},
        {"Hipparcos Number", "HIP 38959"},
        {"Fundamental Katalog 5th Edition", "FK5 1209"},
        {"Geneva Identification System", "GEN# +1.00064958"},
        {"Smithsonian Astrophysical Observation", "SAO 42097"},
        {"Wilson Evans Batten Catalogue", "WEB 7639"},
    },
    visualMagnitude: 6.36,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.56888565),
        dec: Angle.Degrees(+43.97736214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58682"},
        {"Hipparcos Number", "HIP 36343"},
        {"Smithsonian Astrophysical Observation", "SAO 41798"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.19806434),
        dec: Angle.Degrees(+43.97839755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20616"},
        {"Hipparcos Number", "HIP 15591"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.731,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.20298395),
        dec: Angle.Degrees(+43.97907506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 134.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49447",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49447"},
    },
    visualMagnitude: 10.69,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.42943409),
        dec: Angle.Degrees(+43.98029322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215972"},
        {"Hipparcos Number", "HIP 112597"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.07160999),
        dec: Angle.Degrees(+43.98069378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135200"},
        {"Hipparcos Number", "HIP 74394"},
        {"Geneva Identification System", "GEN# +1.00135200"},
        {"Smithsonian Astrophysical Observation", "SAO 45430"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.06558858),
        dec: Angle.Degrees(+43.98098331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165094"},
        {"Hipparcos Number", "HIP 88321"},
        {"Smithsonian Astrophysical Observation", "SAO 47159"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.56497031),
        dec: Angle.Degrees(+43.98152758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85973"},
        {"Hipparcos Number", "HIP 48746"},
        {"Smithsonian Astrophysical Observation", "SAO 43107"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.14079551),
        dec: Angle.Degrees(+43.98220943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21588"},
        {"Hipparcos Number", "HIP 16367"},
        {"Smithsonian Astrophysical Observation", "SAO 38899"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.71458749),
        dec: Angle.Degrees(+43.98489850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31691"},
        {"Hipparcos Number", "HIP 23240"},
        {"Geneva Identification System", "GEN# +1.00031691"},
        {"Smithsonian Astrophysical Observation", "SAO 39925"},
        {"Wilson Evans Batten Catalogue", "WEB 4516"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.00751450),
        dec: Angle.Degrees(+43.98561904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43506",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43506"},
        {"Smithsonian Astrophysical Observation", "SAO 42573"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.93080993),
        dec: Angle.Degrees(+43.98582267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180185"},
        {"Hipparcos Number", "HIP 94461"},
        {"Smithsonian Astrophysical Observation", "SAO 48218"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.38965441),
        dec: Angle.Degrees(+43.98784132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25389"},
        {"Hipparcos Number", "HIP 18979"},
        {"Smithsonian Astrophysical Observation", "SAO 39286"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.99634050),
        dec: Angle.Degrees(+43.98874985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54822"},
        {"Hipparcos Number", "HIP 34829"},
        {"Smithsonian Astrophysical Observation", "SAO 41619"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.12498223),
        dec: Angle.Degrees(+43.98889812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122715"},
        {"Hipparcos Number", "HIP 68590"},
        {"Smithsonian Astrophysical Observation", "SAO 44861"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.62140738),
        dec: Angle.Degrees(+43.98923976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116127"},
        {"Hipparcos Number", "HIP 65135"},
        {"Fundamental Katalog 5th Edition", "FK5 3066"},
        {"Geneva Identification System", "GEN# +1.00116127"},
        {"Smithsonian Astrophysical Observation", "SAO 44573"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.21303444),
        dec: Angle.Degrees(+43.99011862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -147.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83601"},
        {"Hipparcos Number", "HIP 47494"},
        {"Geneva Identification System", "GEN# +1.00083601"},
        {"Smithsonian Astrophysical Observation", "SAO 42975"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.23212049),
        dec: Angle.Degrees(+43.99248290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129781"},
        {"Hipparcos Number", "HIP 71961"},
        {"Smithsonian Astrophysical Observation", "SAO 45184"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.76897832),
        dec: Angle.Degrees(+43.99425970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64253"},
        {"Hipparcos Number", "HIP 38659"},
        {"Geneva Identification System", "GEN# +1.00064253"},
        {"Smithsonian Astrophysical Observation", "SAO 42062"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.72862015),
        dec: Angle.Degrees(+43.99444131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153625"},
        {"Hipparcos Number", "HIP 83076"},
        {"Geneva Identification System", "GEN# +1.00153625"},
        {"Smithsonian Astrophysical Observation", "SAO 46414"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.63495166),
        dec: Angle.Degrees(+43.99591543)
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
    primaryId: "HIP 70198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126007"},
        {"Hipparcos Number", "HIP 70198"},
        {"Smithsonian Astrophysical Observation", "SAO 45009"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.43587340),
        dec: Angle.Degrees(+43.99663592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192868"},
        {"Hipparcos Number", "HIP 99840"},
        {"Geneva Identification System", "GEN# +1.00192868"},
        {"Smithsonian Astrophysical Observation", "SAO 49377"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.84891802),
        dec: Angle.Degrees(+44.00065715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163674"},
        {"Hipparcos Number", "HIP 87734"},
        {"Geneva Identification System", "GEN# +1.00163674"},
        {"Smithsonian Astrophysical Observation", "SAO 47068"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.81698797),
        dec: Angle.Degrees(+44.00110928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160740"},
        {"Hipparcos Number", "HIP 86422"},
        {"Smithsonian Astrophysical Observation", "SAO 46871"},
        {"Wilson Evans Batten Catalogue", "WEB 14580"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.87729918),
        dec: Angle.Degrees(+44.00118805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9346"},
        {"Hipparcos Number", "HIP 7203"},
        {"Smithsonian Astrophysical Observation", "SAO 37301"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.20828969),
        dec: Angle.Degrees(+44.00145868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215040"},
        {"Hipparcos Number", "HIP 112047"},
        {"Smithsonian Astrophysical Observation", "SAO 52277"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.42387233),
        dec: Angle.Degrees(+44.00165460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75580",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9639 AB"},
        {"Henry Draper", "HD 137805"},
        {"Hipparcos Number", "HIP 75580"},
        {"Smithsonian Astrophysical Observation", "SAO 45541"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.61065181),
        dec: Angle.Degrees(+44.00365574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20498"},
        {"Hipparcos Number", "HIP 15476"},
        {"Geneva Identification System", "GEN# +1.00020498"},
        {"Smithsonian Astrophysical Observation", "SAO 38720"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.88836493),
        dec: Angle.Degrees(+44.00450026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35476"},
        {"Hipparcos Number", "HIP 25503"},
        {"Geneva Identification System", "GEN# +1.00035476"},
        {"Smithsonian Astrophysical Observation", "SAO 40340"},
        {"Wilson Evans Batten Catalogue", "WEB 4946"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.80791077),
        dec: Angle.Degrees(+44.00556346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191333"},
        {"Hipparcos Number", "HIP 99138"},
        {"Celescope Catalog", "CEL 4940"},
        {"Geneva Identification System", "GEN# +1.00191333"},
        {"Smithsonian Astrophysical Observation", "SAO 49204"},
    },
    visualMagnitude: 8.28,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.89773426),
        dec: Angle.Degrees(+44.00746019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101549"},
        {"Hipparcos Number", "HIP 57014"},
        {"Geneva Identification System", "GEN# +1.00101549"},
        {"Smithsonian Astrophysical Observation", "SAO 43861"},
        {"Wilson Evans Batten Catalogue", "WEB 10263"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.33558865),
        dec: Angle.Degrees(+44.00757954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207431"},
        {"Hipparcos Number", "HIP 107604"},
        {"Smithsonian Astrophysical Observation", "SAO 51309"},
        {"Wilson Evans Batten Catalogue", "WEB 19418"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.92148512),
        dec: Angle.Degrees(+44.01107269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97856"},
        {"Hipparcos Number", "HIP 55032"},
        {"Smithsonian Astrophysical Observation", "SAO 43669"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.98705084),
        dec: Angle.Degrees(+44.01142677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38817"},
        {"Hipparcos Number", "HIP 27598"},
        {"Geneva Identification System", "GEN# +1.00038817"},
        {"Renson", "Renson 10430"},
        {"Smithsonian Astrophysical Observation", "SAO 40642"},
        {"Wilson Evans Batten Catalogue", "WEB 5418"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.65556493),
        dec: Angle.Degrees(+44.01149832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51339",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51339"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.30119722),
        dec: Angle.Degrees(+44.01225088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47270"},
        {"Hipparcos Number", "HIP 31889"},
        {"Smithsonian Astrophysical Observation", "SAO 41245"},
        {"Wilson Evans Batten Catalogue", "WEB 6409"},
    },
    visualMagnitude: 6.35,
    bvColour: 1.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.99111506),
        dec: Angle.Degrees(+44.01410409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54426"},
        {"Hipparcos Number", "HIP 34678"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.72715839),
        dec: Angle.Degrees(+44.01486018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128590"},
        {"Hipparcos Number", "HIP 71432"},
        {"Smithsonian Astrophysical Observation", "SAO 45131"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.10600856),
        dec: Angle.Degrees(+44.01594574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81145"},
        {"Hipparcos Number", "HIP 46210"},
        {"Smithsonian Astrophysical Observation", "SAO 42849"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.32236060),
        dec: Angle.Degrees(+44.01712395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56448",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56448"},
        {"Smithsonian Astrophysical Observation", "SAO 43807"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.60049845),
        dec: Angle.Degrees(+44.01845416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106885"},
        {"Hipparcos Number", "HIP 59917"},
        {"Geneva Identification System", "GEN# +1.00106885"},
        {"Smithsonian Astrophysical Observation", "SAO 44108"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.36417743),
        dec: Angle.Degrees(+44.01948664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171243"},
        {"Hipparcos Number", "HIP 90819"},
        {"Smithsonian Astrophysical Observation", "SAO 47567"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.90068248),
        dec: Angle.Degrees(+44.02023043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50957",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50957"},
        {"Smithsonian Astrophysical Observation", "SAO 43323"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.10530858),
        dec: Angle.Degrees(+44.02143923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186428"},
        {"Hipparcos Number", "HIP 96941"},
        {"Celescope Catalog", "CEL 4821"},
        {"Geneva Identification System", "GEN# +1.00186428"},
        {"Smithsonian Astrophysical Observation", "SAO 48749"},
    },
    visualMagnitude: 8.09,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.60722714),
        dec: Angle.Degrees(+44.02176355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1475",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 246 A"},
        {"Henry Draper", "HD 1326"},
        {"Hipparcos Number", "HIP 1475"},
        {"Cincinnati Publication", "Ci 20 19"},
        {"Geneva Identification System", "GEN# +1.10001326"},
        {"Smithsonian Astrophysical Observation", "SAO 36248"},
        {"Wilson Evans Batten Catalogue", "WEB 265"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.58559067),
        dec: Angle.Degrees(+44.02195597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2888.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 410.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65788"},
        {"Hipparcos Number", "HIP 39312"},
        {"Geneva Identification System", "GEN# +1.00065788"},
        {"Smithsonian Astrophysical Observation", "SAO 42136"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.56680553),
        dec: Angle.Degrees(+44.02211620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103519"},
        {"Hipparcos Number", "HIP 58120"},
    },
    visualMagnitude: 10.08,
    bvColour: 1.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.81343028),
        dec: Angle.Degrees(+44.02287323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111851"},
        {"Hipparcos Number", "HIP 62764"},
        {"Smithsonian Astrophysical Observation", "SAO 44359"},
        {"Wilson Evans Batten Catalogue", "WEB 11129"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.92805675),
        dec: Angle.Degrees(+44.02338338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20315"},
        {"Hipparcos Number", "HIP 15338"},
        {"Geneva Identification System", "GEN# +1.00020315"},
        {"Smithsonian Astrophysical Observation", "SAO 38704"},
        {"Wilson Evans Batten Catalogue", "WEB 2950"},
    },
    visualMagnitude: 5.49,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.44721595),
        dec: Angle.Degrees(+44.02508193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32048",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5319 AB"},
        {"Henry Draper", "HD 47627"},
        {"Hipparcos Number", "HIP 32048"},
        {"Geneva Identification System", "GEN# +1.00047627J"},
        {"Smithsonian Astrophysical Observation", "SAO 41271"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.43773159),
        dec: Angle.Degrees(+44.02557937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150663"},
        {"Hipparcos Number", "HIP 81628"},
        {"Geneva Identification System", "GEN# +1.00150663"},
        {"Smithsonian Astrophysical Observation", "SAO 46220"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.10756301),
        dec: Angle.Degrees(+44.02886959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55433",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55433"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.28236534),
        dec: Angle.Degrees(+44.02967198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7705",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7705"},
        {"Smithsonian Astrophysical Observation", "SAO 37404"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.79540677),
        dec: Angle.Degrees(+44.03015883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 148.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -165.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3241"},
        {"Hipparcos Number", "HIP 2837"},
        {"Smithsonian Astrophysical Observation", "SAO 36501"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.99680401),
        dec: Angle.Degrees(+44.03204317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85415"},
        {"Hipparcos Number", "HIP 48453"},
        {"Smithsonian Astrophysical Observation", "SAO 43084"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.18820093),
        dec: Angle.Degrees(+44.03448399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178847"},
        {"Hipparcos Number", "HIP 93983"},
        {"Smithsonian Astrophysical Observation", "SAO 48123"},
    },
    visualMagnitude: 7.89,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.03474638),
        dec: Angle.Degrees(+44.03635787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67254"},
        {"Hipparcos Number", "HIP 39892"},
        {"Geneva Identification System", "GEN# +1.00067254"},
        {"Smithsonian Astrophysical Observation", "SAO 42192"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.22068379),
        dec: Angle.Degrees(+44.03983823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53685"},
        {"Hipparcos Number", "HIP 34416"},
        {"Fundamental Katalog 5th Edition", "FK5 2548"},
        {"Geneva Identification System", "GEN# +1.00053685"},
        {"Smithsonian Astrophysical Observation", "SAO 41579"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.02626651),
        dec: Angle.Degrees(+44.03999642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52231",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52231"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.06280840),
        dec: Angle.Degrees(+44.04273761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132563"},
        {"Hipparcos Number", "HIP 73261"},
        {"Smithsonian Astrophysical Observation", "SAO 45312"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.58985599),
        dec: Angle.Degrees(+44.04331493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108137",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15435 AB"},
        {"Henry Draper", "HD 208341"},
        {"Hipparcos Number", "HIP 108137"},
        {"Smithsonian Astrophysical Observation", "SAO 51422"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.63142253),
        dec: Angle.Degrees(+44.04796669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89269"},
        {"Hipparcos Number", "HIP 50505"},
        {"Fundamental Katalog 5th Edition", "FK5 2826"},
        {"Geneva Identification System", "GEN# +1.00089269"},
        {"Smithsonian Astrophysical Observation", "SAO 43279"},
        {"Wilson Evans Batten Catalogue", "WEB 9264"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.71624039),
        dec: Angle.Degrees(+44.04905044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -299.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8862"},
        {"Hipparcos Number", "HIP 6858"},
        {"Geneva Identification System", "GEN# +1.00008862"},
        {"Renson", "Renson 2143"},
        {"Smithsonian Astrophysical Observation", "SAO 37241"},
        {"Wilson Evans Batten Catalogue", "WEB 1493"},
    },
    visualMagnitude: 6.65,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.05156434),
        dec: Angle.Degrees(+44.04926440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47772",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47772"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.764,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.09865049),
        dec: Angle.Degrees(+44.05044589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79371"},
        {"Hipparcos Number", "HIP 45401"},
        {"Geneva Identification System", "GEN# +1.00079371"},
        {"Smithsonian Astrophysical Observation", "SAO 42766"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.78365383),
        dec: Angle.Degrees(+44.05059148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -279.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78314"},
        {"Hipparcos Number", "HIP 44913"},
        {"Smithsonian Astrophysical Observation", "SAO 42719"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.25198503),
        dec: Angle.Degrees(+44.05321135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66650",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66650"},
        {"Smithsonian Astrophysical Observation", "SAO 44700"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.93893072),
        dec: Angle.Degrees(+44.05544067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44091"},
        {"Hipparcos Number", "HIP 30267"},
        {"Fundamental Katalog 5th Edition", "FK5 2485"},
        {"Geneva Identification System", "GEN# +1.00044091"},
        {"Smithsonian Astrophysical Observation", "SAO 41044"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.50540380),
        dec: Angle.Degrees(+44.05856803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217811"},
        {"Hipparcos Number", "HIP 113802"},
        {"Smithsonian Astrophysical Observation", "SAO 52626"},
        {"Wilson Evans Batten Catalogue", "WEB 20219"},
    },
    visualMagnitude: 6.37,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.68811495),
        dec: Angle.Degrees(+44.05876504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36037",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36037"},
    },
    visualMagnitude: 10.95,
    bvColour: 1.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.40208368),
        dec: Angle.Degrees(+44.05889452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198639"},
        {"Hipparcos Number", "HIP 102843"},
        {"Celescope Catalog", "CEL 5182"},
        {"Fundamental Katalog 5th Edition", "FK5 3666"},
        {"Geneva Identification System", "GEN# +1.00198639"},
        {"Renson", "Renson 55270"},
        {"Smithsonian Astrophysical Observation", "SAO 50121"},
        {"Wilson Evans Batten Catalogue", "WEB 18657"},
    },
    visualMagnitude: 5.06,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.52013154),
        dec: Angle.Degrees(+44.05898220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 122.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 132.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4712"},
        {"Hipparcos Number", "HIP 3857"},
        {"Geneva Identification System", "GEN# +1.00004712"},
        {"Smithsonian Astrophysical Observation", "SAO 36695"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.38642207),
        dec: Angle.Degrees(+44.05939726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49581"},
        {"Hipparcos Number", "HIP 32891"},
        {"Geneva Identification System", "GEN# +1.00049581"},
        {"Renson", "Renson 13420"},
        {"Smithsonian Astrophysical Observation", "SAO 41384"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.79889166),
        dec: Angle.Degrees(+44.05965811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145625"},
        {"Hipparcos Number", "HIP 79224"},
        {"Smithsonian Astrophysical Observation", "SAO 45928"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.52595586),
        dec: Angle.Degrees(+44.06035249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199956"},
        {"Hipparcos Number", "HIP 103559"},
        {"Geneva Identification System", "GEN# +1.00199956"},
        {"Smithsonian Astrophysical Observation", "SAO 50313"},
    },
    visualMagnitude: 6.65,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.73177460),
        dec: Angle.Degrees(+44.06041057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31069"},
        {"Hipparcos Number", "HIP 22842"},
        {"Celescope Catalog", "CEL 481"},
        {"Geneva Identification System", "GEN# +1.00031069"},
        {"Smithsonian Astrophysical Observation", "SAO 39851"},
        {"Wilson Evans Batten Catalogue", "WEB 4423"},
    },
    visualMagnitude: 6.06,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.71343607),
        dec: Angle.Degrees(+44.06099850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109020",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109020"},
        {"Smithsonian Astrophysical Observation", "SAO 51630"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.29405069),
        dec: Angle.Degrees(+44.06460738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86453",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86453"},
        {"Smithsonian Astrophysical Observation", "SAO 46878"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.97975275),
        dec: Angle.Degrees(+44.06581758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -185.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143368"},
        {"Hipparcos Number", "HIP 78200"},
        {"Smithsonian Astrophysical Observation", "SAO 45808"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.801,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.52631170),
        dec: Angle.Degrees(+44.06603753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6201"},
        {"Hipparcos Number", "HIP 4970"},
        {"Celescope Catalog", "CEL 112"},
        {"Geneva Identification System", "GEN# +1.00006201"},
        {"Smithsonian Astrophysical Observation", "SAO 36887"},
    },
    visualMagnitude: 8.69,
    bvColour: -0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.92223780),
        dec: Angle.Degrees(+44.06639237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47181",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47181"},
    },
    visualMagnitude: 11.31,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.22153363),
        dec: Angle.Degrees(+44.06680765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139133"},
        {"Hipparcos Number", "HIP 76274"},
        {"Smithsonian Astrophysical Observation", "SAO 45620"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.69732104),
        dec: Angle.Degrees(+44.06747555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202164"},
        {"Hipparcos Number", "HIP 104711"},
        {"Smithsonian Astrophysical Observation", "SAO 50572"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.16354693),
        dec: Angle.Degrees(+44.06875433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102252",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102252"},
        {"Smithsonian Astrophysical Observation", "SAO 49979"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.78634679),
        dec: Angle.Degrees(+44.07006383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36947"},
        {"Henry Draper 2", "HD 36948"},
        {"Hipparcos Number", "HIP 26413"},
        {"Fundamental Katalog 5th Edition", "FK5 4509"},
        {"Geneva Identification System", "GEN# +1.00036947"},
        {"Smithsonian Astrophysical Observation", "SAO 40487"},
        {"Wilson Evans Batten Catalogue", "WEB 5209"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.32018967),
        dec: Angle.Degrees(+44.07088599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22626"},
        {"Hipparcos Number", "HIP 17127"},
        {"Smithsonian Astrophysical Observation", "SAO 39027"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.02102063),
        dec: Angle.Degrees(+44.07145922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221422"},
        {"Hipparcos Number", "HIP 116127"},
        {"Smithsonian Astrophysical Observation", "SAO 53118"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.95951922),
        dec: Angle.Degrees(+44.07282717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23477"},
        {"Hipparcos Number", "HIP 17681"},
        {"Geneva Identification System", "GEN# +1.00023477"},
        {"Smithsonian Astrophysical Observation", "SAO 39101"},
        {"Wilson Evans Batten Catalogue", "WEB 3373"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.81708620),
        dec: Angle.Degrees(+44.07381817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105745",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105745"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.27024474),
        dec: Angle.Degrees(+44.07465235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102667",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102667"},
        {"Smithsonian Astrophysical Observation", "SAO 50079"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.06796971),
        dec: Angle.Degrees(+44.07661301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22268"},
        {"Hipparcos Number", "HIP 16844"},
        {"Smithsonian Astrophysical Observation", "SAO 38984"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.19548895),
        dec: Angle.Degrees(+44.07713510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119245"},
        {"Hipparcos Number", "HIP 66779"},
        {"Smithsonian Astrophysical Observation", "SAO 44712"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.30286350),
        dec: Angle.Degrees(+44.07717439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105044"},
        {"Hipparcos Number", "HIP 58994"},
        {"Smithsonian Astrophysical Observation", "SAO 44028"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.43327802),
        dec: Angle.Degrees(+44.07847910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -167.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195015"},
        {"Hipparcos Number", "HIP 100865"},
        {"Celescope Catalog", "CEL 5067"},
        {"Geneva Identification System", "GEN# +1.00195015"},
        {"Smithsonian Astrophysical Observation", "SAO 49637"},
    },
    visualMagnitude: 8.28,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.77792535),
        dec: Angle.Degrees(+44.07918458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147924"},
        {"Hipparcos Number", "HIP 80231"},
        {"Smithsonian Astrophysical Observation", "SAO 46056"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.69127072),
        dec: Angle.Degrees(+44.08364655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161369"},
        {"Hipparcos Number", "HIP 86713"},
        {"Fundamental Katalog 5th Edition", "FK5 3408"},
        {"Geneva Identification System", "GEN# +1.00161369"},
        {"Smithsonian Astrophysical Observation", "SAO 46906"},
        {"Wilson Evans Batten Catalogue", "WEB 14621"},
    },
    visualMagnitude: 6.38,
    bvColour: 1.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.77325256),
        dec: Angle.Degrees(+44.08423552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112836",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16311 AB"},
        {"Henry Draper", "HD 216283"},
        {"Hipparcos Number", "HIP 112836"},
        {"Smithsonian Astrophysical Observation", "SAO 52423"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.76976348),
        dec: Angle.Degrees(+44.08490557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56788",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56788"},
        {"Smithsonian Astrophysical Observation", "SAO 43838"},
        {"Wilson Evans Batten Catalogue", "WEB 10221"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.63691716),
        dec: Angle.Degrees(+44.08947218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16545"},
        {"Hipparcos Number", "HIP 12478"},
        {"Renson", "Renson 4120"},
        {"Smithsonian Astrophysical Observation", "SAO 38212"},
        {"Wilson Evans Batten Catalogue", "WEB 2549"},
    },
    visualMagnitude: 7.37,
    bvColour: -0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.15384938),
        dec: Angle.Degrees(+44.09123456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13703",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13703"},
        {"Smithsonian Astrophysical Observation", "SAO 38454"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.11024582),
        dec: Angle.Degrees(+44.09136783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7313",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1222 A"},
        {"Henry Draper", "HD 9492"},
        {"Hipparcos Number", "HIP 7313"},
        {"Renson", "Renson 2300"},
        {"Smithsonian Astrophysical Observation", "SAO 37317"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.53361602),
        dec: Angle.Degrees(+44.09398251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38245"},
        {"Hipparcos Number", "HIP 27248"},
        {"Geneva Identification System", "GEN# +1.00038245"},
        {"Smithsonian Astrophysical Observation", "SAO 40595"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.62523123),
        dec: Angle.Degrees(+44.09598199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109344"},
        {"Hipparcos Number", "HIP 61310"},
        {"Geneva Identification System", "GEN# +1.00109344"},
        {"Smithsonian Astrophysical Observation", "SAO 44229"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.41330708),
        dec: Angle.Degrees(+44.09640322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29487"},
        {"Hipparcos Number", "HIP 21774"},
        {"Celescope Catalog", "CEL 452"},
        {"Geneva Identification System", "GEN# +1.00029487"},
        {"Smithsonian Astrophysical Observation", "SAO 39683"},
        {"Wilson Evans Batten Catalogue", "WEB 4187"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.15063307),
        dec: Angle.Degrees(+44.09709049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220182"},
        {"Hipparcos Number", "HIP 115331"},
        {"Cincinnati Publication", "Ci 18 3059"},
        {"Cincinnati Publication 2", "Ci 20 1421"},
        {"Geneva Identification System", "GEN# +1.00220182"},
        {"Smithsonian Astrophysical Observation", "SAO 52935"},
        {"Wilson Evans Batten Catalogue", "WEB 20427"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.801,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.39998343),
        dec: Angle.Degrees(+44.09735013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 636.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 219.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12137"},
        {"Hipparcos Number", "HIP 9367"},
        {"Geneva Identification System", "GEN# +1.00012137"},
        {"Smithsonian Astrophysical Observation", "SAO 37692"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.08935270),
        dec: Angle.Degrees(+44.10274273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110834"},
        {"Hipparcos Number", "HIP 62172"},
        {"Geneva Identification System", "GEN# +1.00110834"},
        {"Smithsonian Astrophysical Observation", "SAO 44307"},
        {"Wilson Evans Batten Catalogue", "WEB 11048"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.11301998),
        dec: Angle.Degrees(+44.10299667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93213"},
        {"Hipparcos Number", "HIP 52702"},
        {"Geneva Identification System", "GEN# +1.00093213"},
        {"Smithsonian Astrophysical Observation", "SAO 43467"},
        {"Wilson Evans Batten Catalogue", "WEB 9596"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.62549929),
        dec: Angle.Degrees(+44.10329251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -141.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109953"},
        {"Hipparcos Number", "HIP 61661"},
        {"Geneva Identification System", "GEN# +1.00109953"},
        {"Smithsonian Astrophysical Observation", "SAO 44262"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.60426031),
        dec: Angle.Degrees(+44.10387160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209219"},
        {"Hipparcos Number", "HIP 108645"},
        {"Smithsonian Astrophysical Observation", "SAO 51542"},
        {"Wilson Evans Batten Catalogue", "WEB 19549"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.15223347),
        dec: Angle.Degrees(+44.10516607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162261"},
        {"Hipparcos Number", "HIP 87124"},
        {"Geneva Identification System", "GEN# +1.00162261"},
        {"Smithsonian Astrophysical Observation", "SAO 46963"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.844,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.00594543),
        dec: Angle.Degrees(+44.10689471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 541"},
        {"Hipparcos Number", "HIP 812"},
        {"Smithsonian Astrophysical Observation", "SAO 36117"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.50683340),
        dec: Angle.Degrees(+44.10967471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101289",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101289"},
        {"Smithsonian Astrophysical Observation", "SAO 49751"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.96719059),
        dec: Angle.Degrees(+44.11198042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64363",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64363"},
        {"Smithsonian Astrophysical Observation", "SAO 44500"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.87717299),
        dec: Angle.Degrees(+44.11218033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166409"},
        {"Hipparcos Number", "HIP 88852"},
        {"Geneva Identification System", "GEN# +1.00166409"},
        {"Smithsonian Astrophysical Observation", "SAO 47250"},
        {"Wilson Evans Batten Catalogue", "WEB 15064"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.09081862),
        dec: Angle.Degrees(+44.11251946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18908"},
        {"Hipparcos Number", "HIP 14278"},
        {"Smithsonian Astrophysical Observation", "SAO 38545"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.01337111),
        dec: Angle.Degrees(+44.11295248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151407"},
        {"Hipparcos Number", "HIP 82006"},
        {"Smithsonian Astrophysical Observation", "SAO 46261"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.28545976),
        dec: Angle.Degrees(+44.11336946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96327"},
        {"Hipparcos Number", "HIP 54323"},
        {"Geneva Identification System", "GEN# +1.00096327"},
        {"Smithsonian Astrophysical Observation", "SAO 43612"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.69148179),
        dec: Angle.Degrees(+44.11540363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90153"},
        {"Hipparcos Number", "HIP 51016"},
        {"Smithsonian Astrophysical Observation", "SAO 43330"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.33396725),
        dec: Angle.Degrees(+44.11540804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115261",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16685 A"},
        {"Henry Draper", "HD 220105"},
        {"Hipparcos Number", "HIP 115261"},
        {"Geneva Identification System", "GEN# +1.00220105"},
        {"Smithsonian Astrophysical Observation", "SAO 52927"},
        {"Wilson Evans Batten Catalogue", "WEB 20417"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.18377590),
        dec: Angle.Degrees(+44.11625675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190149"},
        {"Hipparcos Number", "HIP 98610"},
        {"Geneva Identification System", "GEN# +1.00190149"},
        {"Smithsonian Astrophysical Observation", "SAO 49105"},
        {"Wilson Evans Batten Catalogue", "WEB 17439"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.43848268),
        dec: Angle.Degrees(+44.11907982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32948"},
        {"Hipparcos Number", "HIP 23956"},
        {"Geneva Identification System", "GEN# +1.00032948"},
        {"Smithsonian Astrophysical Observation", "SAO 40053"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.23030197),
        dec: Angle.Degrees(+44.11975786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110896",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15968 A"},
        {"Henry Draper", "HD 213061"},
        {"Hipparcos Number", "HIP 110896"},
        {"Smithsonian Astrophysical Observation", "SAO 52028"},
    },
    visualMagnitude: 6.56,
    bvColour: 1.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.01461817),
        dec: Angle.Degrees(+44.12054910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113578"},
        {"Hipparcos Number", "HIP 63759"},
        {"Fundamental Katalog 5th Edition", "FK5 5156"},
        {"Geneva Identification System", "GEN# +1.00113578"},
        {"Smithsonian Astrophysical Observation", "SAO 44448"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.03328046),
        dec: Angle.Degrees(+44.12118809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -308.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34300"},
        {"Hipparcos Number", "HIP 24775"},
        {"Smithsonian Astrophysical Observation", "SAO 40219"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.67393768),
        dec: Angle.Degrees(+44.12190357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221849"},
        {"Hipparcos Number", "HIP 116409"},
        {"Smithsonian Astrophysical Observation", "SAO 53166"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.84419224),
        dec: Angle.Degrees(+44.12309796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52038",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52038"},
        {"Smithsonian Astrophysical Observation", "SAO 43412"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.48717946),
        dec: Angle.Degrees(+44.12461978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175490"},
        {"Hipparcos Number", "HIP 92714"},
        {"Geneva Identification System", "GEN# +1.00175490"},
        {"Smithsonian Astrophysical Observation", "SAO 47896"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.37090887),
        dec: Angle.Degrees(+44.12898274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4668"},
        {"Hipparcos Number", "HIP 3824"},
        {"Geneva Identification System", "GEN# +1.00004668"},
        {"Smithsonian Astrophysical Observation", "SAO 36686"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.27585080),
        dec: Angle.Degrees(+44.12948081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117935"},
        {"Hipparcos Number", "HIP 66093"},
        {"Geneva Identification System", "GEN# +1.00117935"},
        {"Smithsonian Astrophysical Observation", "SAO 44649"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.22417890),
        dec: Angle.Degrees(+44.13024422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170616"},
        {"Hipparcos Number", "HIP 90520"},
        {"Geneva Identification System", "GEN# +1.00170616"},
        {"Smithsonian Astrophysical Observation", "SAO 47518"},
    },
    visualMagnitude: 8.41,
    bvColour: -0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.06349421),
        dec: Angle.Degrees(+44.13097898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84715",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10474 AB"},
        {"Henry Draper", "HD 157046"},
        {"Henry Draper 2", "HD 157047"},
        {"Hipparcos Number", "HIP 84715"},
        {"Renson", "Renson 44153"},
        {"Smithsonian Astrophysical Observation", "SAO 46631"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.74458475),
        dec: Angle.Degrees(+44.13178601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42173"},
        {"Hipparcos Number", "HIP 29375"},
        {"Smithsonian Astrophysical Observation", "SAO 40927"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.87698895),
        dec: Angle.Degrees(+44.13462543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173978"},
        {"Hipparcos Number", "HIP 92096"},
        {"Geneva Identification System", "GEN# +1.00173978"},
        {"Smithsonian Astrophysical Observation", "SAO 47781"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.55089583),
        dec: Angle.Degrees(+44.13562520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143240"},
        {"Hipparcos Number", "HIP 78147"},
        {"Smithsonian Astrophysical Observation", "SAO 45803"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.36222752),
        dec: Angle.Degrees(+44.13573047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55025",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55025"},
        {"Smithsonian Astrophysical Observation", "SAO 43668"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.97665032),
        dec: Angle.Degrees(+44.13827938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192867"},
        {"Hipparcos Number", "HIP 99846"},
        {"Fundamental Katalog 5th Edition", "FK5 5783"},
        {"Geneva Identification System", "GEN# +1.00192867"},
        {"Smithsonian Astrophysical Observation", "SAO 49379"},
        {"Wilson Evans Batten Catalogue", "WEB 17950"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.86214380),
        dec: Angle.Degrees(+44.13883695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98793",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98793"},
        {"Geneva Identification System", "GEN# +2.68660005"},
        {"New General Catalogue", "NGC 6866 5"},
    },
    visualMagnitude: 11.64,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.97986582),
        dec: Angle.Degrees(+44.14006263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76191"},
        {"Hipparcos Number", "HIP 43874"},
        {"Smithsonian Astrophysical Observation", "SAO 42607"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.06963428),
        dec: Angle.Degrees(+44.14024906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9736",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9736"},
        {"Smithsonian Astrophysical Observation", "SAO 37750"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.31788609),
        dec: Angle.Degrees(+44.14061585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101674"},
        {"Hipparcos Number", "HIP 57089"},
        {"Smithsonian Astrophysical Observation", "SAO 43866"},
        {"Wilson Evans Batten Catalogue", "WEB 10276"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.55548256),
        dec: Angle.Degrees(+44.14173981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48270",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48270"},
    },
    visualMagnitude: 11.83,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.62298839),
        dec: Angle.Degrees(+50.71845751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -139.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10014"},
        {"Hipparcos Number", "HIP 7663"},
        {"Geneva Identification System", "GEN# +1.00010014"},
        {"Smithsonian Astrophysical Observation", "SAO 37396"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.66154576),
        dec: Angle.Degrees(+44.14443503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208916"},
        {"Hipparcos Number", "HIP 108465"},
        {"Smithsonian Astrophysical Observation", "SAO 51501"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.59674145),
        dec: Angle.Degrees(+44.14574494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200509"},
        {"Hipparcos Number", "HIP 103838"},
        {"Smithsonian Astrophysical Observation", "SAO 50382"},
    },
    visualMagnitude: 9.00,
    bvColour: -0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.61812677),
        dec: Angle.Degrees(+44.14717967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65189",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65189"},
        {"Geneva Identification System", "GEN# +0.04402268"},
        {"Smithsonian Astrophysical Observation", "SAO 44579"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.38620708),
        dec: Angle.Degrees(+44.15151368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111422"},
        {"Hipparcos Number", "HIP 62529"},
        {"Geneva Identification System", "GEN# +1.00111422"},
        {"Wilson Evans Batten Catalogue", "WEB 11099"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.20836879),
        dec: Angle.Degrees(+44.15419451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15887",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15887"},
        {"Smithsonian Astrophysical Observation", "SAO 38793"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.15701829),
        dec: Angle.Degrees(+44.15495724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95098",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95098"},
        {"Smithsonian Astrophysical Observation", "SAO 48357"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.19963565),
        dec: Angle.Degrees(+44.15519466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15376"},
        {"Hipparcos Number", "HIP 11615"},
        {"Smithsonian Astrophysical Observation", "SAO 38068"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.45593178),
        dec: Angle.Degrees(+44.15584854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62200",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62200"},
        {"Smithsonian Astrophysical Observation", "SAO 44314"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.22656892),
        dec: Angle.Degrees(+44.15629414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26445"},
        {"Hipparcos Number", "HIP 19681"},
        {"Renson", "Renson 6700"},
        {"Smithsonian Astrophysical Observation", "SAO 39388"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.24641435),
        dec: Angle.Degrees(+44.15911688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98797",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98797"},
        {"Geneva Identification System", "GEN# +2.68660004"},
        {"New General Catalogue", "NGC 6866 4"},
    },
    visualMagnitude: 11.30,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.98895387),
        dec: Angle.Degrees(+44.15932381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152425"},
        {"Hipparcos Number", "HIP 82470"},
        {"Geneva Identification System", "GEN# +1.00152425"},
        {"Smithsonian Astrophysical Observation", "SAO 46326"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.80816208),
        dec: Angle.Degrees(+44.16093624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163417"},
        {"Hipparcos Number", "HIP 87623"},
        {"Fundamental Katalog 5th Edition", "FK5 5572"},
        {"Geneva Identification System", "GEN# +1.00163417"},
        {"Renson", "Renson 46215"},
        {"Smithsonian Astrophysical Observation", "SAO 47042"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.49208179),
        dec: Angle.Degrees(+44.16472754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81384"},
        {"Hipparcos Number", "HIP 46310"},
        {"Smithsonian Astrophysical Observation", "SAO 42858"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.65738999),
        dec: Angle.Degrees(+44.16579202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35573"},
        {"Hipparcos Number", "HIP 25560"},
        {"Smithsonian Astrophysical Observation", "SAO 40349"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.94708400),
        dec: Angle.Degrees(+44.16591581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33746",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33746"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.15342316),
        dec: Angle.Degrees(+44.16672126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155208"},
        {"Hipparcos Number", "HIP 83835"},
        {"Smithsonian Astrophysical Observation", "SAO 46509"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.00358941),
        dec: Angle.Degrees(+44.16941779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41678",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41678"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.45078955),
        dec: Angle.Degrees(+44.17014787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7266"},
        {"Hipparcos Number", "HIP 5716"},
        {"Smithsonian Astrophysical Observation", "SAO 37034"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.38578747),
        dec: Angle.Degrees(+44.17236114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2059",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 348 AB"},
        {"Henry Draper", "HD 2171"},
        {"Hipparcos Number", "HIP 2059"},
        {"Smithsonian Astrophysical Observation", "SAO 36361"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.51722596),
        dec: Angle.Degrees(+44.17663905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21280"},
        {"Hipparcos Number", "HIP 16126"},
        {"Geneva Identification System", "GEN# +1.00021280"},
        {"Wilson Evans Batten Catalogue", "WEB 3073"},
    },
    visualMagnitude: 9.15,
    bvColour: 2.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.92665199),
        dec: Angle.Degrees(+44.17678863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109417",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109417"},
        {"Smithsonian Astrophysical Observation", "SAO 51716"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.51676575),
        dec: Angle.Degrees(+44.18128602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91181"},
        {"Hipparcos Number", "HIP 51603"},
        {"Geneva Identification System", "GEN# +1.00091181"},
        {"Renson", "Renson 26217"},
        {"Smithsonian Astrophysical Observation", "SAO 43375"},
        {"Wilson Evans Batten Catalogue", "WEB 9415"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.11956679),
        dec: Angle.Degrees(+44.18177145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9759",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9759"},
        {"Smithsonian Astrophysical Observation", "SAO 37756"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.706,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.37476801),
        dec: Angle.Degrees(+44.18419526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74327"},
        {"Hipparcos Number", "HIP 42934"},
        {"Geneva Identification System", "GEN# +1.00074327"},
        {"Smithsonian Astrophysical Observation", "SAO 42524"},
        {"Wilson Evans Batten Catalogue", "WEB 8299"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.26098554),
        dec: Angle.Degrees(+44.18448951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103779",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14560 A"},
        {"Henry Draper", "HD 200407"},
        {"Hipparcos Number", "HIP 103779"},
        {"Geneva Identification System", "GEN# +1.00200407"},
        {"Renson", "Renson 55840"},
        {"Smithsonian Astrophysical Observation", "SAO 50368"},
        {"Wilson Evans Batten Catalogue", "WEB 18886"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.44768153),
        dec: Angle.Degrees(+44.18711714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61057",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61057"},
        {"Geneva Identification System", "GEN# +0.04402196"},
        {"Smithsonian Astrophysical Observation", "SAO 44207"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.72079211),
        dec: Angle.Degrees(+44.18871243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69388",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9159 AB"},
        {"Henry Draper", "HD 124399"},
        {"Hipparcos Number", "HIP 69388"},
        {"Geneva Identification System", "GEN# +1.00124399J"},
        {"Smithsonian Astrophysical Observation", "SAO 44933"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.06108569),
        dec: Angle.Degrees(+44.18957573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12077",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1962 AB"},
        {"Henry Draper", "HD 16013"},
        {"Hipparcos Number", "HIP 12077"},
        {"Smithsonian Astrophysical Observation", "SAO 38151"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.92587132),
        dec: Angle.Degrees(+44.19002002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65464",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8897 AB"},
        {"Hipparcos Number", "HIP 65464"},
    },
    visualMagnitude: 10.54,
    bvColour: 0.878,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.27226677),
        dec: Angle.Degrees(+44.19077630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111156",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111156"},
        {"Smithsonian Astrophysical Observation", "SAO 52099"},
    },
    visualMagnitude: 10.80,
    bvColour: 0.849,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.79694241),
        dec: Angle.Degrees(+44.19079369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194133"},
        {"Hipparcos Number", "HIP 100440"},
        {"Smithsonian Astrophysical Observation", "SAO 49532"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.53777492),
        dec: Angle.Degrees(+44.19116603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157326"},
        {"Hipparcos Number", "HIP 84850"},
        {"Smithsonian Astrophysical Observation", "SAO 46647"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.12575107),
        dec: Angle.Degrees(+44.19202452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103040",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103040"},
        {"Geneva Identification System", "GEN# +0.04303751"},
        {"Smithsonian Astrophysical Observation", "SAO 50164"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.13900200),
        dec: Angle.Degrees(+44.19505245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101585"},
        {"Hipparcos Number", "HIP 57038"},
        {"Geneva Identification System", "GEN# +1.00101585"},
        {"Smithsonian Astrophysical Observation", "SAO 43863"},
        {"Wilson Evans Batten Catalogue", "WEB 10266"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.41717167),
        dec: Angle.Degrees(+44.19507586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118295"},
        {"Hipparcos Number", "HIP 66294"},
        {"Fundamental Katalog 5th Edition", "FK5 1353"},
        {"Geneva Identification System", "GEN# +1.00118295"},
        {"Smithsonian Astrophysical Observation", "SAO 44675"},
        {"Wilson Evans Batten Catalogue", "WEB 11713"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.80880055),
        dec: Angle.Degrees(+44.19701325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217587"},
        {"Hipparcos Number", "HIP 113665"},
        {"Geneva Identification System", "GEN# +1.00217587"},
        {"Smithsonian Astrophysical Observation", "SAO 52599"},
        {"Wilson Evans Batten Catalogue", "WEB 20198"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.31419569),
        dec: Angle.Degrees(+44.19860780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53033",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53033"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.76391050),
        dec: Angle.Degrees(+44.19871696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201702"},
        {"Hipparcos Number", "HIP 104479"},
        {"Smithsonian Astrophysical Observation", "SAO 50519"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.46983102),
        dec: Angle.Degrees(+44.20033779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1233",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 197 AB"},
        {"Henry Draper", "HD 1082"},
        {"Hipparcos Number", "HIP 1233"},
        {"Smithsonian Astrophysical Observation", "SAO 36202"},
    },
    visualMagnitude: 6.76,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.82428012),
        dec: Angle.Degrees(+44.20339841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19343"},
        {"Hipparcos Number", "HIP 14582"},
        {"Geneva Identification System", "GEN# +1.00019343"},
        {"Smithsonian Astrophysical Observation", "SAO 38594"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.06622707),
        dec: Angle.Degrees(+44.20598652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210222"},
        {"Hipparcos Number", "HIP 109247"},
        {"Smithsonian Astrophysical Observation", "SAO 51674"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.97249696),
        dec: Angle.Degrees(+44.20618393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17280"},
        {"Hipparcos Number", "HIP 13062"},
        {"Renson", "Renson 4340"},
        {"Smithsonian Astrophysical Observation", "SAO 38341"},
    },
    visualMagnitude: 7.84,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.97855538),
        dec: Angle.Degrees(+44.20630944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86372",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86372"},
        {"Smithsonian Astrophysical Observation", "SAO 46863"},
    },
    visualMagnitude: 9.56,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.74063671),
        dec: Angle.Degrees(+44.20690079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83697"},
        {"Hipparcos Number", "HIP 47542"},
        {"Smithsonian Astrophysical Observation", "SAO 42979"},
        {"Wilson Evans Batten Catalogue", "WEB 8916"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.39226127),
        dec: Angle.Degrees(+44.20711424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20200",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20200"},
        {"Smithsonian Astrophysical Observation", "SAO 39465"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.94313483),
        dec: Angle.Degrees(+44.20725374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77732",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77732"},
        {"Smithsonian Astrophysical Observation", "SAO 45768"},
    },
    visualMagnitude: 9.72,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.06064049),
        dec: Angle.Degrees(+44.21098394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76068"},
        {"Hipparcos Number", "HIP 43824"},
        {"Smithsonian Astrophysical Observation", "SAO 42597"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.87762875),
        dec: Angle.Degrees(+44.21114954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66084"},
        {"Hipparcos Number", "HIP 39449"},
        {"Smithsonian Astrophysical Observation", "SAO 42146"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.96298817),
        dec: Angle.Degrees(+44.21640829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104655"},
        {"Hipparcos Number", "HIP 58767"},
    },
    visualMagnitude: 10.72,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.79867725),
        dec: Angle.Degrees(+44.21735532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17844",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17844"},
        {"Smithsonian Astrophysical Observation", "SAO 39127"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.27614577),
        dec: Angle.Degrees(+44.21760837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75013",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75013"},
        {"Smithsonian Astrophysical Observation", "SAO 45487"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.91890068),
        dec: Angle.Degrees(+44.21898707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83174"},
        {"Hipparcos Number", "HIP 47256"},
        {"Smithsonian Astrophysical Observation", "SAO 42953"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.48327952),
        dec: Angle.Degrees(+44.21908070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113950",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113950"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.14771273),
        dec: Angle.Degrees(+44.21948387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37531",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6280 AB"},
        {"Hipparcos Number", "HIP 37531"},
        {"Smithsonian Astrophysical Observation", "SAO 41944"},
    },
    visualMagnitude: 9.81,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.54287515),
        dec: Angle.Degrees(+44.22266552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131447"},
        {"Henry Draper 2", "HD 131447A"},
        {"Hipparcos Number", "HIP 72737"},
        {"Smithsonian Astrophysical Observation", "SAO 45247"},
        {"Wilson Evans Batten Catalogue", "WEB 12502"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.877,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.06288995),
        dec: Angle.Degrees(+44.22482375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107141",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15242 AB"},
        {"Hipparcos Number", "HIP 107141"},
        {"Smithsonian Astrophysical Observation", "SAO 51202"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.53511330),
        dec: Angle.Degrees(+44.22625064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49713",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49713"},
        {"Smithsonian Astrophysical Observation", "SAO 43211"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.24886716),
        dec: Angle.Degrees(+44.22672322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -187.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92926",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11863 ABC"},
        {"Henry Draper", "HD 176003"},
        {"Hipparcos Number", "HIP 92926"},
        {"Renson", "Renson 49130"},
        {"Smithsonian Astrophysical Observation", "SAO 47928"},
        {"Wilson Evans Batten Catalogue", "WEB 16091"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.98808843),
        dec: Angle.Degrees(+44.22830892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78007",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78007"},
        {"Geneva Identification System", "GEN# +0.04402522"},
        {"Smithsonian Astrophysical Observation", "SAO 45792"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.93797277),
        dec: Angle.Degrees(+44.23100976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -198.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13520"},
        {"Hipparcos Number", "HIP 10340"},
        {"Fundamental Katalog 5th Edition", "FK5 2153"},
        {"Geneva Identification System", "GEN# +1.00013520"},
        {"Smithsonian Astrophysical Observation", "SAO 37867"},
        {"Wilson Evans Batten Catalogue", "WEB 2162"},
    },
    visualMagnitude: 4.84,
    bvColour: 1.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.30558667),
        dec: Angle.Degrees(+44.23168903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215288"},
        {"Hipparcos Number", "HIP 112195"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.85442908),
        dec: Angle.Degrees(+44.23237379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214346"},
        {"Hipparcos Number", "HIP 111624"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.19742637),
        dec: Angle.Degrees(+44.23248005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48410"},
        {"Hipparcos Number", "HIP 32382"},
        {"Geneva Identification System", "GEN# +1.00048410"},
        {"Smithsonian Astrophysical Observation", "SAO 41315"},
        {"Wilson Evans Batten Catalogue", "WEB 6530"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.37025783),
        dec: Angle.Degrees(+44.23384716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 143.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -189.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88350",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11010 AB"},
        {"Henry Draper", "HD 165170"},
        {"Hipparcos Number", "HIP 88350"},
        {"Smithsonian Astrophysical Observation", "SAO 47163"},
        {"Wilson Evans Batten Catalogue", "WEB 14934"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.62871133),
        dec: Angle.Degrees(+44.23405115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50273",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50273"},
        {"Smithsonian Astrophysical Observation", "SAO 43250"},
    },
    visualMagnitude: 10.48,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.97325278),
        dec: Angle.Degrees(+44.23808122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202710"},
        {"Hipparcos Number", "HIP 105017"},
        {"Smithsonian Astrophysical Observation", "SAO 50651"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.07131871),
        dec: Angle.Degrees(+44.23819662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203095"},
        {"Hipparcos Number", "HIP 105210"},
        {"Smithsonian Astrophysical Observation", "SAO 50697"},
    },
    visualMagnitude: 9.18,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.67045373),
        dec: Angle.Degrees(+44.23895929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30409"},
        {"Hipparcos Number", "HIP 22415"},
        {"Celescope Catalog", "CEL 468"},
        {"Geneva Identification System", "GEN# +1.00030409"},
        {"Smithsonian Astrophysical Observation", "SAO 39778"},
        {"Wilson Evans Batten Catalogue", "WEB 4323"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.36051565),
        dec: Angle.Degrees(+44.23967345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82289"},
        {"Hipparcos Number", "HIP 46820"},
        {"Geneva Identification System", "GEN# +1.00082289"},
        {"Smithsonian Astrophysical Observation", "SAO 42910"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.11925666),
        dec: Angle.Degrees(+44.24248318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188482"},
        {"Hipparcos Number", "HIP 97893"},
        {"Smithsonian Astrophysical Observation", "SAO 48945"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.39774111),
        dec: Angle.Degrees(+44.24332089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73277"},
        {"Hipparcos Number", "HIP 42447"},
        {"Smithsonian Astrophysical Observation", "SAO 42471"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.81671526),
        dec: Angle.Degrees(+44.24410770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76239"},
        {"Hipparcos Number", "HIP 43892"},
        {"Geneva Identification System", "GEN# +1.00076239"},
        {"Smithsonian Astrophysical Observation", "SAO 42609"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.12184849),
        dec: Angle.Degrees(+44.25117434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80232",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80232"},
        {"Smithsonian Astrophysical Observation", "SAO 46057"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.757,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.69529320),
        dec: Angle.Degrees(+44.25296082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -162.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155059"},
        {"Hipparcos Number", "HIP 83763"},
        {"Geneva Identification System", "GEN# +1.00155059"},
        {"Smithsonian Astrophysical Observation", "SAO 46496"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.78391029),
        dec: Angle.Degrees(+44.25552303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79466"},
        {"Hipparcos Number", "HIP 45450"},
        {"Smithsonian Astrophysical Observation", "SAO 42770"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.94279502),
        dec: Angle.Degrees(+44.25664690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170615"},
        {"Hipparcos Number", "HIP 90524"},
        {"Smithsonian Astrophysical Observation", "SAO 47519"},
        {"Wilson Evans Batten Catalogue", "WEB 15504"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.07849917),
        dec: Angle.Degrees(+44.25673300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75195",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75195"},
        {"Smithsonian Astrophysical Observation", "SAO 45509"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.49213812),
        dec: Angle.Degrees(+44.25744874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20750",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20750"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.69920441),
        dec: Angle.Degrees(+44.25746481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63127",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63127"},
        {"Geneva Identification System", "GEN# +0.04502074"},
        {"Smithsonian Astrophysical Observation", "SAO 44390"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.01381338),
        dec: Angle.Degrees(+44.25784016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53924"},
        {"Hipparcos Number", "HIP 34514"},
        {"Geneva Identification System", "GEN# +1.00053924"},
        {"Smithsonian Astrophysical Observation", "SAO 41586"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.27362570),
        dec: Angle.Degrees(+44.25985492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50858",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50858"},
        {"Smithsonian Astrophysical Observation", "SAO 43313"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.77407808),
        dec: Angle.Degrees(+44.25988699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40979"},
        {"Hipparcos Number", "HIP 28767"},
        {"Geneva Identification System", "GEN# +1.00040979"},
        {"Smithsonian Astrophysical Observation", "SAO 40830"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.12444026),
        dec: Angle.Degrees(+44.26081415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -152.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98190",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13167 A"},
        {"Henry Draper", "HD 189256"},
        {"Hipparcos Number", "HIP 98190"},
        {"Geneva Identification System", "GEN# +1.00189256"},
        {"Wilson Evans Batten Catalogue", "WEB 17315"},
    },
    visualMagnitude: 8.02,
    bvColour: 3.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.30212811),
        dec: Angle.Degrees(+44.26115564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12544",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12544"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.35091970),
        dec: Angle.Degrees(+44.26136978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127285"},
        {"Hipparcos Number", "HIP 70844"},
        {"Smithsonian Astrophysical Observation", "SAO 45071"},
    },
    visualMagnitude: 6.52,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.31267845),
        dec: Angle.Degrees(+44.26212143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149304"},
        {"Hipparcos Number", "HIP 80963"},
        {"Geneva Identification System", "GEN# +1.00149304"},
        {"Smithsonian Astrophysical Observation", "SAO 46148"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.98373239),
        dec: Angle.Degrees(+44.26418187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1952"},
        {"Hipparcos Number", "HIP 1905"},
        {"Geneva Identification System", "GEN# +1.00001952"},
        {"Smithsonian Astrophysical Observation", "SAO 36330"},
        {"Wilson Evans Batten Catalogue", "WEB 345"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.02196922),
        dec: Angle.Degrees(+44.26474444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16655",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16655"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.57565491),
        dec: Angle.Degrees(+44.26994916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7799"},
        {"Hipparcos Number", "HIP 6102"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.58759387),
        dec: Angle.Degrees(+44.27088388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -238.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 227.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172976"},
        {"Hipparcos Number", "HIP 91615"},
        {"Geneva Identification System", "GEN# +1.00172976"},
        {"Renson", "Renson 48500"},
        {"Smithsonian Astrophysical Observation", "SAO 47702"},
        {"Wilson Evans Batten Catalogue", "WEB 15756"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.26454297),
        dec: Angle.Degrees(+44.27110186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189160"},
        {"Hipparcos Number", "HIP 98156"},
        {"Celescope Catalog", "CEL 4887"},
        {"Geneva Identification System", "GEN# +1.00189160A"},
        {"Renson", "Renson 52370"},
        {"Smithsonian Astrophysical Observation", "SAO 49005"},
    },
    visualMagnitude: 7.91,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.20896759),
        dec: Angle.Degrees(+44.27111359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74440",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74440"},
        {"Smithsonian Astrophysical Observation", "SAO 45435"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.19493529),
        dec: Angle.Degrees(+44.27146075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17246"},
        {"Henry Draper 2", "HD 17245"},
        {"Hipparcos Number", "HIP 13036"},
        {"Geneva Identification System", "GEN# +1.00017245"},
        {"Smithsonian Astrophysical Observation", "SAO 38335"},
        {"Wilson Evans Batten Catalogue", "WEB 2632"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.87980947),
        dec: Angle.Degrees(+44.27221537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39250"},
        {"Hipparcos Number", "HIP 27848"},
        {"Geneva Identification System", "GEN# +1.00039250"},
        {"Smithsonian Astrophysical Observation", "SAO 40681"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.37834649),
        dec: Angle.Degrees(+44.27345873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173289"},
        {"Hipparcos Number", "HIP 91739"},
        {"Geneva Identification System", "GEN# +1.00173289"},
        {"Smithsonian Astrophysical Observation", "SAO 47724"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.61526390),
        dec: Angle.Degrees(+44.27357631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14531"},
        {"Hipparcos Number", "HIP 11031"},
        {"Geneva Identification System", "GEN# +1.00014531"},
        {"Smithsonian Astrophysical Observation", "SAO 37976"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.51946714),
        dec: Angle.Degrees(+44.27511839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214868"},
        {"Hipparcos Number", "HIP 111944"},
        {"Geneva Identification System", "GEN# +1.00214868"},
        {"Smithsonian Astrophysical Observation", "SAO 52251"},
        {"Wilson Evans Batten Catalogue", "WEB 19989"},
    },
    visualMagnitude: 4.50,
    bvColour: 1.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.12825981),
        dec: Angle.Degrees(+44.27628068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68832"},
        {"Hipparcos Number", "HIP 40481"},
        {"Geneva Identification System", "GEN# +1.00068832"},
        {"Smithsonian Astrophysical Observation", "SAO 42255"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.98718956),
        dec: Angle.Degrees(+44.27732308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21680",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21680"},
        {"Smithsonian Astrophysical Observation", "SAO 39668"},
        {"Wilson Evans Batten Catalogue", "WEB 4165"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.867,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.81137498),
        dec: Angle.Degrees(+44.27774525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 109.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -184.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25517"},
        {"Hipparcos Number", "HIP 19064"},
        {"Geneva Identification System", "GEN# +1.00025517"},
        {"Smithsonian Astrophysical Observation", "SAO 39298"},
        {"Wilson Evans Batten Catalogue", "WEB 3663"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.28270170),
        dec: Angle.Degrees(+44.27824436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143722"},
        {"Hipparcos Number", "HIP 78387"},
        {"Smithsonian Astrophysical Observation", "SAO 45829"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.04920313),
        dec: Angle.Degrees(+44.27961736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18321",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18321"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.74979274),
        dec: Angle.Degrees(+44.28119726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121825"},
        {"Hipparcos Number", "HIP 68134"},
        {"Fundamental Katalog 5th Edition", "FK5 5229"},
        {"Geneva Identification System", "GEN# +1.00121825"},
        {"Smithsonian Astrophysical Observation", "SAO 44813"},
        {"Wilson Evans Batten Catalogue", "WEB 11958"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.22920557),
        dec: Angle.Degrees(+44.28251174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62380"},
        {"Hipparcos Number", "HIP 37873"},
        {"Geneva Identification System", "GEN# +1.00062380"},
        {"Smithsonian Astrophysical Observation", "SAO 41984"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.44329181),
        dec: Angle.Degrees(+44.28486168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110542",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110542"},
        {"Smithsonian Astrophysical Observation", "SAO 51956"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.89495029),
        dec: Angle.Degrees(+44.28593367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216450"},
        {"Hipparcos Number", "HIP 112937"},
        {"Smithsonian Astrophysical Observation", "SAO 52439"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.10410655),
        dec: Angle.Degrees(+44.28699267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14969",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2397 AB"},
        {"Henry Draper", "HD 19822"},
        {"Hipparcos Number", "HIP 14969"},
        {"Smithsonian Astrophysical Observation", "SAO 38648"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.23759846),
        dec: Angle.Degrees(+44.28738022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107376",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107376"},
        {"Cincinnati Publication", "Ci 20 1310"},
    },
    visualMagnitude: 11.43,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.22544265),
        dec: Angle.Degrees(+44.28740017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -652.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209933"},
        {"Hipparcos Number", "HIP 109092"},
        {"Smithsonian Astrophysical Observation", "SAO 51644"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.47687747),
        dec: Angle.Degrees(+44.28759060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48195",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48195"},
        {"Geneva Identification System", "GEN# +0.04401910"},
        {"Wilson Evans Batten Catalogue", "WEB 8998"},
    },
    visualMagnitude: 10.95,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.37764529),
        dec: Angle.Degrees(+44.28915429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -201.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112297"},
        {"Hipparcos Number", "HIP 63053"},
        {"Geneva Identification System", "GEN# +1.00112297"},
        {"Smithsonian Astrophysical Observation", "SAO 44386"},
        {"Wilson Evans Batten Catalogue", "WEB 11180"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.79285505),
        dec: Angle.Degrees(+44.29151373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73310"},
        {"Hipparcos Number", "HIP 42468"},
        {"Smithsonian Astrophysical Observation", "SAO 42474"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.87397169),
        dec: Angle.Degrees(+44.29180736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204050"},
        {"Hipparcos Number", "HIP 105709"},
        {"Geneva Identification System", "GEN# +1.00204050"},
        {"Smithsonian Astrophysical Observation", "SAO 50807"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.16483597),
        dec: Angle.Degrees(+44.29184043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220597"},
        {"Hipparcos Number", "HIP 115586"},
        {"Smithsonian Astrophysical Observation", "SAO 52990"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.19399194),
        dec: Angle.Degrees(+44.29240367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117997"},
        {"Hipparcos Number", "HIP 66124"},
        {"Geneva Identification System", "GEN# +1.00117997"},
        {"Smithsonian Astrophysical Observation", "SAO 44654"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.33236493),
        dec: Angle.Degrees(+44.29282125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157993"},
        {"Hipparcos Number", "HIP 85190"},
        {"Smithsonian Astrophysical Observation", "SAO 46696"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.14843165),
        dec: Angle.Degrees(+44.29441692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48991",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48991"},
        {"Smithsonian Astrophysical Observation", "SAO 43131"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.93050107),
        dec: Angle.Degrees(+44.29556055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16901"},
        {"Hipparcos Number", "HIP 12768"},
        {"Fundamental Katalog 5th Edition", "FK5 1077"},
        {"Geneva Identification System", "GEN# +1.00016901"},
        {"Smithsonian Astrophysical Observation", "SAO 38289"},
        {"Wilson Evans Batten Catalogue", "WEB 2594"},
    },
    visualMagnitude: 5.43,
    bvColour: 0.904,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.02149224),
        dec: Angle.Degrees(+44.29705480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222959"},
        {"Hipparcos Number", "HIP 117167"},
        {"Smithsonian Astrophysical Observation", "SAO 53347"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.31763258),
        dec: Angle.Degrees(+44.29795889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156631"},
        {"Hipparcos Number", "HIP 84518"},
        {"Smithsonian Astrophysical Observation", "SAO 46600"},
    },
    visualMagnitude: 9.51,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.16105836),
        dec: Angle.Degrees(+44.29938738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50514",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50514"},
        {"Smithsonian Astrophysical Observation", "SAO 43282"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.74922800),
        dec: Angle.Degrees(+44.29948184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11095"},
        {"Hipparcos Number", "HIP 8535"},
        {"Geneva Identification System", "GEN# +1.00011095"},
        {"Smithsonian Astrophysical Observation", "SAO 37548"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.51301940),
        dec: Angle.Degrees(+44.30068021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96127"},
        {"Hipparcos Number", "HIP 54232"},
        {"Smithsonian Astrophysical Observation", "SAO 43608"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.44142475),
        dec: Angle.Degrees(+44.30156309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137719"},
        {"Hipparcos Number", "HIP 75541"},
        {"Geneva Identification System", "GEN# +1.00137719"},
        {"Smithsonian Astrophysical Observation", "SAO 45538"},
        {"Wilson Evans Batten Catalogue", "WEB 12873"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.49613314),
        dec: Angle.Degrees(+44.30223303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110196",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110196"},
        {"Smithsonian Astrophysical Observation", "SAO 51873"},
    },
    visualMagnitude: 10.03,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.83054939),
        dec: Angle.Degrees(+44.30279308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114399"},
        {"Hipparcos Number", "HIP 64215"},
        {"Smithsonian Astrophysical Observation", "SAO 44491"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.41975167),
        dec: Angle.Degrees(+44.30333551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14028"},
        {"Hipparcos Number", "HIP 10687"},
        {"Wilson Evans Batten Catalogue", "WEB 2253"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.38733784),
        dec: Angle.Degrees(+44.30494266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101227"},
        {"Hipparcos Number", "HIP 56837"},
        {"Cincinnati Publication", "Ci 18 1437"},
        {"Geneva Identification System", "GEN# +1.00101227"},
        {"Smithsonian Astrophysical Observation", "SAO 43848"},
        {"Wilson Evans Batten Catalogue", "WEB 10235"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.77670975),
        dec: Angle.Degrees(+44.30551792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -234.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23887",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23887"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.00109471),
        dec: Angle.Degrees(+44.30728971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 195.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216850"},
        {"Hipparcos Number", "HIP 113227"},
        {"Smithsonian Astrophysical Observation", "SAO 52498"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.94591303),
        dec: Angle.Degrees(+44.30825168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40562"},
        {"Hipparcos Number", "HIP 28570"},
        {"Renson", "Renson 10840"},
        {"Smithsonian Astrophysical Observation", "SAO 40793"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.44616193),
        dec: Angle.Degrees(+44.30870528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145800"},
        {"Hipparcos Number", "HIP 79295"},
        {"Smithsonian Astrophysical Observation", "SAO 45944"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.74173189),
        dec: Angle.Degrees(+44.30949473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140025"},
        {"Hipparcos Number", "HIP 76704"},
        {"Geneva Identification System", "GEN# +1.00140025"},
        {"Smithsonian Astrophysical Observation", "SAO 45667"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.771,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.93842505),
        dec: Angle.Degrees(+44.31133550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46981"},
        {"Hipparcos Number", "HIP 31743"},
        {"Geneva Identification System", "GEN# +1.00046981"},
        {"Smithsonian Astrophysical Observation", "SAO 41227"},
        {"Wilson Evans Batten Catalogue", "WEB 6367"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.60922268),
        dec: Angle.Degrees(+44.31310877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111805",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16138"},
        {"Aitken 2", "ADS 16138 AB"},
        {"Henry Draper", "HD 214608"},
        {"Hipparcos Number", "HIP 111805"},
        {"Geneva Identification System", "GEN# +1.00214608J"},
        {"Smithsonian Astrophysical Observation", "SAO 52218"},
        {"Wilson Evans Batten Catalogue", "WEB 19971"},
        {"Wilson Evans Batten Catalogue 2", "WEB 19972"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.69700074),
        dec: Angle.Degrees(+44.31373917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 234.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 65.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195592"},
        {"Hipparcos Number", "HIP 101186"},
        {"Geneva Identification System", "GEN# +1.00195592"},
        {"Smithsonian Astrophysical Observation", "SAO 49724"},
        {"Wilson Evans Batten Catalogue", "WEB 18278"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.847,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.64571234),
        dec: Angle.Degrees(+44.31523646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 802"},
        {"Hipparcos Number", "HIP 1011"},
        {"Smithsonian Astrophysical Observation", "SAO 36158"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.14910495),
        dec: Angle.Degrees(+44.31628232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55554",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55554"},
        {"Smithsonian Astrophysical Observation", "SAO 43718"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.69060962),
        dec: Angle.Degrees(+44.31762848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77733",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77733"},
        {"Smithsonian Astrophysical Observation", "SAO 45769"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.06119109),
        dec: Angle.Degrees(+44.32121701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210954"},
        {"Hipparcos Number", "HIP 109665"},
        {"Smithsonian Astrophysical Observation", "SAO 51768"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.23241887),
        dec: Angle.Degrees(+44.32135628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216609"},
        {"Hipparcos Number", "HIP 113049"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.41759495),
        dec: Angle.Degrees(+44.32354749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218364"},
        {"Hipparcos Number", "HIP 114134"},
        {"Smithsonian Astrophysical Observation", "SAO 52691"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.72479594),
        dec: Angle.Degrees(+44.32400079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2091"},
        {"Hipparcos Number", "HIP 2004"},
        {"Smithsonian Astrophysical Observation", "SAO 36353"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.35098620),
        dec: Angle.Degrees(+44.32441992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36756"},
        {"Hipparcos Number", "HIP 26310"},
        {"Geneva Identification System", "GEN# +1.00036756"},
        {"Smithsonian Astrophysical Observation", "SAO 40468"},
        {"Wilson Evans Batten Catalogue", "WEB 5172"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.04681515),
        dec: Angle.Degrees(+44.32641882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95768"},
        {"Hipparcos Number", "HIP 54053"},
        {"Geneva Identification System", "GEN# +1.00095768A"},
        {"Smithsonian Astrophysical Observation", "SAO 43594"},
        {"Wilson Evans Batten Catalogue", "WEB 9777"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.91368918),
        dec: Angle.Degrees(+44.32978050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -164.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128039"},
        {"Hipparcos Number", "HIP 71172"},
        {"Geneva Identification System", "GEN# +1.00128039"},
        {"Smithsonian Astrophysical Observation", "SAO 45112"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.34773376),
        dec: Angle.Degrees(+44.33161452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196833"},
        {"Hipparcos Number", "HIP 101838"},
        {"Celescope Catalog", "CEL 5134"},
        {"Geneva Identification System", "GEN# +1.00196833"},
        {"Smithsonian Astrophysical Observation", "SAO 49885"},
        {"Wilson Evans Batten Catalogue", "WEB 18400"},
    },
    visualMagnitude: 6.68,
    bvColour: -0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.56558958),
        dec: Angle.Degrees(+44.33269926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47335"},
        {"Hipparcos Number", "HIP 31916"},
        {"Geneva Identification System", "GEN# +1.00047335"},
        {"Smithsonian Astrophysical Observation", "SAO 41251"},
        {"Wilson Evans Batten Catalogue", "WEB 6412"},
    },
    visualMagnitude: 6.75,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.05371550),
        dec: Angle.Degrees(+44.33290142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116805",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16916 A"},
        {"Henry Draper", "HD 222439"},
        {"Hipparcos Number", "HIP 116805"},
        {"Fundamental Katalog 5th Edition", "FK5 1619"},
        {"Geneva Identification System", "GEN# +1.00222439"},
        {"Smithsonian Astrophysical Observation", "SAO 53264"},
        {"Wilson Evans Batten Catalogue", "WEB 20610"},
    },
    visualMagnitude: 4.15,
    bvColour: -0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.10184089),
        dec: Angle.Degrees(+44.33397776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112460",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112460"},
        {"Cincinnati Publication", "Ci 20 1382"},
        {"Geneva Identification System", "GEN# +0.04304305A"},
        {"Wilson Evans Batten Catalogue", "WEB 20058"},
    },
    visualMagnitude: 10.29,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.70961216),
        dec: Angle.Degrees(+44.33510774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -704.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -459.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218983"},
        {"Hipparcos Number", "HIP 114535"},
        {"Smithsonian Astrophysical Observation", "SAO 52783"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.99054047),
        dec: Angle.Degrees(+44.33617884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204722"},
        {"Hipparcos Number", "HIP 106079"},
        {"Celescope Catalog", "CEL 5323"},
        {"Geneva Identification System", "GEN# +1.00204722"},
        {"Smithsonian Astrophysical Observation", "SAO 50930"},
    },
    visualMagnitude: 7.62,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.31183901),
        dec: Angle.Degrees(+44.33813048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112465",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112465"},
        {"Geneva Identification System", "GEN# +0.04304305B"},
    },
    visualMagnitude: 11.59,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)46, 51.6800),
        dec: Angle.DegreesMinutesSeconds((int)+44, (int)20, 22.300)
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
    primaryId: "HIP 68828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123279"},
        {"Hipparcos Number", "HIP 68828"},
        {"Smithsonian Astrophysical Observation", "SAO 44880"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.39846243),
        dec: Angle.Degrees(+44.34038315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189159"},
        {"Hipparcos Number", "HIP 98160"},
        {"Geneva Identification System", "GEN# +1.00189159"},
        {"Smithsonian Astrophysical Observation", "SAO 49007"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.23052172),
        dec: Angle.Degrees(+44.34184063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63528",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63528"},
    },
    visualMagnitude: 10.85,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.26952673),
        dec: Angle.Degrees(+44.34190496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209393"},
        {"Hipparcos Number", "HIP 108774"},
        {"Geneva Identification System", "GEN# +1.00209393"},
        {"Smithsonian Astrophysical Observation", "SAO 51578"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.52232491),
        dec: Angle.Degrees(+44.34309517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207487"},
        {"Hipparcos Number", "HIP 107634"},
        {"Smithsonian Astrophysical Observation", "SAO 51313"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.01862815),
        dec: Angle.Degrees(+44.34434068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209679"},
        {"Hipparcos Number", "HIP 108933"},
        {"Smithsonian Astrophysical Observation", "SAO 51614"},
        {"Wilson Evans Batten Catalogue", "WEB 19594"},
    },
    visualMagnitude: 6.56,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.02799508),
        dec: Angle.Degrees(+44.34512451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48509",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48509"},
    },
    visualMagnitude: 12.02,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.39169496),
        dec: Angle.Degrees(+50.75104725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -529.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187160"},
        {"Hipparcos Number", "HIP 97321"},
        {"Geneva Identification System", "GEN# +1.00187160"},
        {"Smithsonian Astrophysical Observation", "SAO 48827"},
        {"Wilson Evans Batten Catalogue", "WEB 17103"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.67168193),
        dec: Angle.Degrees(+44.34852564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 133.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23118"},
        {"Hipparcos Number", "HIP 17450"},
        {"Smithsonian Astrophysical Observation", "SAO 39070"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.10796315),
        dec: Angle.Degrees(+44.35720092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197291"},
        {"Hipparcos Number", "HIP 102074"},
        {"Geneva Identification System", "GEN# +1.00197291"},
        {"Smithsonian Astrophysical Observation", "SAO 49938"},
        {"Wilson Evans Batten Catalogue", "WEB 18457"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.28528188),
        dec: Angle.Degrees(+44.35772986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124896"},
        {"Hipparcos Number", "HIP 69624"},
        {"Smithsonian Astrophysical Observation", "SAO 44953"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.75545873),
        dec: Angle.Degrees(+44.35865003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17568"},
        {"Hipparcos Number", "HIP 13266"},
        {"Renson", "Renson 4390"},
        {"Smithsonian Astrophysical Observation", "SAO 38387"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.66963795),
        dec: Angle.Degrees(+44.35883020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91990",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11654 A"},
        {"Henry Draper", "HD 173760"},
        {"Hipparcos Number", "HIP 91990"},
        {"Smithsonian Astrophysical Observation", "SAO 47764"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.23991456),
        dec: Angle.Degrees(+44.35901548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36245"},
        {"Hipparcos Number", "HIP 25974"},
        {"Celescope Catalog", "CEL 756"},
        {"Geneva Identification System", "GEN# +1.00036245"},
        {"Smithsonian Astrophysical Observation", "SAO 40408"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.14780342),
        dec: Angle.Degrees(+44.36015516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66344",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66344"},
        {"Geneva Identification System", "GEN# +0.04502119"},
        {"Smithsonian Astrophysical Observation", "SAO 44678"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.96582892),
        dec: Angle.Degrees(+44.36053332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12941"},
        {"Hipparcos Number", "HIP 9929"},
        {"Geneva Identification System", "GEN# +1.00012941"},
        {"Smithsonian Astrophysical Observation", "SAO 37787"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.95857945),
        dec: Angle.Degrees(+44.36195218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26276"},
        {"Hipparcos Number", "HIP 19559"},
        {"Smithsonian Astrophysical Observation", "SAO 39364"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.84390821),
        dec: Angle.Degrees(+44.36215981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61691"},
        {"Hipparcos Number", "HIP 37568"},
        {"Smithsonian Astrophysical Observation", "SAO 41952"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.66018975),
        dec: Angle.Degrees(+44.36312207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53578",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53578"},
        {"Smithsonian Astrophysical Observation", "SAO 43545"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.40903722),
        dec: Angle.Degrees(+44.36361033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95484"},
        {"Hipparcos Number", "HIP 53914"},
        {"Smithsonian Astrophysical Observation", "SAO 43581"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.47919958),
        dec: Angle.Degrees(+44.36385623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27784"},
        {"Hipparcos Number", "HIP 20624"},
        {"Smithsonian Astrophysical Observation", "SAO 39517"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.28963157),
        dec: Angle.Degrees(+44.36480337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50454"},
        {"Hipparcos Number", "HIP 33293"},
        {"Smithsonian Astrophysical Observation", "SAO 41433"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.88492116),
        dec: Angle.Degrees(+44.36781770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67584",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9035 AB"},
        {"Hipparcos Number", "HIP 67584"},
        {"Wilson Evans Batten Catalogue", "WEB 11884"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.72498124),
        dec: Angle.Degrees(+44.36979435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199479"},
        {"Hipparcos Number", "HIP 103322"},
        {"Celescope Catalog", "CEL 5209"},
        {"Geneva Identification System", "GEN# +1.00199479"},
        {"Smithsonian Astrophysical Observation", "SAO 50247"},
        {"Wilson Evans Batten Catalogue", "WEB 18779"},
    },
    visualMagnitude: 6.83,
    bvColour: -0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.99584901),
        dec: Angle.Degrees(+44.37392295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105099"},
        {"Hipparcos Number", "HIP 59020"},
        {"Smithsonian Astrophysical Observation", "SAO 44029"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.51292045),
        dec: Angle.Degrees(+44.37604038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21346"},
        {"Hipparcos Number", "HIP 16165"},
        {"Smithsonian Astrophysical Observation", "SAO 38855"},
    },
    visualMagnitude: 6.52,
    bvColour: 1.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.07596439),
        dec: Angle.Degrees(+44.37725441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71825",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9349 A"},
        {"Henry Draper", "HD 129514"},
        {"Henry Draper 2", "HD 129514A"},
        {"Hipparcos Number", "HIP 71825"},
        {"Smithsonian Astrophysical Observation", "SAO 45175"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.38854626),
        dec: Angle.Degrees(+44.37810106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148050"},
        {"Hipparcos Number", "HIP 80298"},
        {"Geneva Identification System", "GEN# +1.00148050"},
        {"Smithsonian Astrophysical Observation", "SAO 46060"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.88654024),
        dec: Angle.Degrees(+44.37837108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89540",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11229 A"},
        {"Henry Draper", "HD 168153"},
        {"Hipparcos Number", "HIP 89540"},
        {"Smithsonian Astrophysical Observation", "SAO 47348"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.05649388),
        dec: Angle.Degrees(+44.37904073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187613"},
        {"Hipparcos Number", "HIP 97498"},
        {"Celescope Catalog", "CEL 4853"},
        {"Smithsonian Astrophysical Observation", "SAO 48866"},
        {"Wilson Evans Batten Catalogue", "WEB 17143"},
    },
    visualMagnitude: 7.16,
    bvColour: -0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.25373790),
        dec: Angle.Degrees(+44.37920008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110835",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110835"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.82210344),
        dec: Angle.Degrees(+44.37932056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14675"},
        {"Hipparcos Number", "HIP 11142"},
        {"Geneva Identification System", "GEN# +1.00014675"},
        {"Smithsonian Astrophysical Observation", "SAO 37996"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.84596782),
        dec: Angle.Degrees(+44.38022023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10072"},
        {"Hipparcos Number", "HIP 7719"},
        {"Fundamental Katalog 5th Edition", "FK5 2112"},
        {"Geneva Identification System", "GEN# +1.00010072"},
        {"Smithsonian Astrophysical Observation", "SAO 37406"},
        {"Wilson Evans Batten Catalogue", "WEB 1656"},
    },
    visualMagnitude: 5.01,
    bvColour: 0.883,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.83757938),
        dec: Angle.Degrees(+44.38612827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199178"},
        {"Hipparcos Number", "HIP 103144"},
        {"Geneva Identification System", "GEN# +1.00199178"},
        {"Smithsonian Astrophysical Observation", "SAO 50198"},
        {"Wilson Evans Batten Catalogue", "WEB 18733"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.785,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.47346043),
        dec: Angle.Degrees(+44.38641349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177152"},
        {"Hipparcos Number", "HIP 93401"},
        {"Smithsonian Astrophysical Observation", "SAO 48008"},
        {"Wilson Evans Batten Catalogue", "WEB 16203"},
    },
    visualMagnitude: 7.57,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.34075441),
        dec: Angle.Degrees(+44.38650935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89863"},
        {"Hipparcos Number", "HIP 50871"},
        {"Smithsonian Astrophysical Observation", "SAO 43314"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.81771173),
        dec: Angle.Degrees(+44.38685660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199081"},
        {"Hipparcos Number", "HIP 103089"},
        {"Celescope Catalog", "CEL 5194"},
        {"Geneva Identification System", "GEN# +1.00199081"},
        {"Smithsonian Astrophysical Observation", "SAO 50180"},
        {"Wilson Evans Batten Catalogue", "WEB 18716"},
    },
    visualMagnitude: 4.80,
    bvColour: -0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.31143866),
        dec: Angle.Degrees(+44.38726652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79922",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79922"},
        {"Smithsonian Astrophysical Observation", "SAO 46021"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.69961849),
        dec: Angle.Degrees(+44.38846833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21312"},
        {"Hipparcos Number", "HIP 16146"},
        {"Smithsonian Astrophysical Observation", "SAO 38850"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.01211324),
        dec: Angle.Degrees(+44.39024194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67095",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67095"},
    },
    visualMagnitude: 10.44,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.28298471),
        dec: Angle.Degrees(+44.39397250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2421"},
        {"Hipparcos Number", "HIP 2225"},
        {"Fundamental Katalog 5th Edition", "FK5 2027"},
        {"Geneva Identification System", "GEN# +1.00002421"},
        {"Smithsonian Astrophysical Observation", "SAO 36390"},
        {"Wilson Evans Batten Catalogue", "WEB 413"},
    },
    visualMagnitude: 5.18,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.05660466),
        dec: Angle.Degrees(+44.39448925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204262"},
        {"Hipparcos Number", "HIP 105826"},
        {"Geneva Identification System", "GEN# +1.00204262"},
        {"Renson", "Renson 56890"},
        {"Smithsonian Astrophysical Observation", "SAO 50840"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.50502218),
        dec: Angle.Degrees(+44.39454574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223361"},
        {"Hipparcos Number", "HIP 117442"},
        {"Geneva Identification System", "GEN# +1.00223361"},
        {"Smithsonian Astrophysical Observation", "SAO 53396"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.19698229),
        dec: Angle.Degrees(+44.39718299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70792",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70792"},
        {"Geneva Identification System", "GEN# +0.04502184"},
        {"Smithsonian Astrophysical Observation", "SAO 45065"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.15892576),
        dec: Angle.Degrees(+44.39781686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -144.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 220.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31866"},
        {"Hipparcos Number", "HIP 23369"},
        {"Geneva Identification System", "GEN# +1.00031866"},
        {"Smithsonian Astrophysical Observation", "SAO 39948"},
        {"Wilson Evans Batten Catalogue", "WEB 4539"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.36815897),
        dec: Angle.Degrees(+44.39812579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64476",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64476"},
        {"Geneva Identification System", "GEN# +0.04502094"},
        {"Smithsonian Astrophysical Observation", "SAO 44511"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.22725331),
        dec: Angle.Degrees(+44.40088117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106783"},
        {"Hipparcos Number", "HIP 59870"},
        {"Geneva Identification System", "GEN# +1.00106783"},
        {"Smithsonian Astrophysical Observation", "SAO 44102"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.18040758),
        dec: Angle.Degrees(+44.40205564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82584",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10246 A"},
        {"Henry Draper", "HD 152733"},
        {"Hipparcos Number", "HIP 82584"},
        {"Geneva Identification System", "GEN# +1.00152733"},
        {"Smithsonian Astrophysical Observation", "SAO 46344"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.23842971),
        dec: Angle.Degrees(+44.40223173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129002"},
        {"Hipparcos Number", "HIP 71618"},
        {"Fundamental Katalog 5th Edition", "FK5 540"},
        {"Geneva Identification System", "GEN# +1.00129002"},
        {"Smithsonian Astrophysical Observation", "SAO 45153"},
        {"Wilson Evans Batten Catalogue", "WEB 12345"},
    },
    visualMagnitude: 5.39,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.70950726),
        dec: Angle.Degrees(+44.40454503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130303"},
        {"Hipparcos Number", "HIP 72187"},
        {"Geneva Identification System", "GEN# +1.00130303"},
        {"Smithsonian Astrophysical Observation", "SAO 45212"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.47260154),
        dec: Angle.Degrees(+44.40816342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 200.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196359"},
        {"Hipparcos Number", "HIP 101581"},
        {"Geneva Identification System", "GEN# +1.00196359"},
        {"Smithsonian Astrophysical Observation", "SAO 49836"},
        {"Wilson Evans Batten Catalogue", "WEB 18355"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.81031730),
        dec: Angle.Degrees(+44.40917685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76348"},
        {"Hipparcos Number", "HIP 43954"},
        {"Geneva Identification System", "GEN# +1.00076348"},
        {"Smithsonian Astrophysical Observation", "SAO 42613"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.917,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.28103241),
        dec: Angle.Degrees(+44.40927697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19070"},
        {"Hipparcos Number", "HIP 14385"},
        {"Smithsonian Astrophysical Observation", "SAO 38562"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.39609751),
        dec: Angle.Degrees(+44.40984128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44125"},
        {"Hipparcos Number", "HIP 30290"},
        {"Geneva Identification System", "GEN# +1.00044125"},
        {"Smithsonian Astrophysical Observation", "SAO 41047"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.57611003),
        dec: Angle.Degrees(+44.41214411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116685",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116685"},
        {"Smithsonian Astrophysical Observation", "SAO 53233"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.70296575),
        dec: Angle.Degrees(+44.41256900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91249",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91249"},
        {"Smithsonian Astrophysical Observation", "SAO 47648"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.18872466),
        dec: Angle.Degrees(+44.41323140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105474"},
        {"Hipparcos Number", "HIP 59211"},
        {"Geneva Identification System", "GEN# +1.00105474"},
        {"Smithsonian Astrophysical Observation", "SAO 44051"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.15626317),
        dec: Angle.Degrees(+44.41339736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199939"},
        {"Hipparcos Number", "HIP 103546"},
        {"Geneva Identification System", "GEN# +1.00199939"},
        {"Smithsonian Astrophysical Observation", "SAO 50310"},
        {"Wilson Evans Batten Catalogue", "WEB 18840"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.68123629),
        dec: Angle.Degrees(+44.41462786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92640",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92640"},
        {"Smithsonian Astrophysical Observation", "SAO 47881"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.13659820),
        dec: Angle.Degrees(+44.41522039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208472"},
        {"Hipparcos Number", "HIP 108198"},
        {"Smithsonian Astrophysical Observation", "SAO 51437"},
        {"Wilson Evans Batten Catalogue", "WEB 19500"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.81021841),
        dec: Angle.Degrees(+44.41863271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84219"},
        {"Hipparcos Number", "HIP 47820"},
        {"Geneva Identification System", "GEN# +1.00084219"},
        {"Smithsonian Astrophysical Observation", "SAO 43012"},
        {"Wilson Evans Batten Catalogue", "WEB 8950"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.22096145),
        dec: Angle.Degrees(+44.41878161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12131"},
        {"Hipparcos Number", "HIP 9359"},
        {"Geneva Identification System", "GEN# +1.00012131"},
        {"Smithsonian Astrophysical Observation", "SAO 37690"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.06249937),
        dec: Angle.Degrees(+44.42010272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27068",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27068"},
        {"Smithsonian Astrophysical Observation", "SAO 40571"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.10450710),
        dec: Angle.Degrees(+44.42022540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33282",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33282"},
    },
    visualMagnitude: 11.30,
    bvColour: 1.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.84764153),
        dec: Angle.Degrees(+44.42255362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -219.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14776",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14776"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.68414661),
        dec: Angle.Degrees(+44.42323572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76617"},
        {"Hipparcos Number", "HIP 44103"},
        {"Geneva Identification System", "GEN# +1.00076617"},
        {"Smithsonian Astrophysical Observation", "SAO 42627"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.74173900),
        dec: Angle.Degrees(+44.42519486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34498"},
        {"Hipparcos Number", "HIP 24881"},
        {"Smithsonian Astrophysical Observation", "SAO 40242"},
        {"Wilson Evans Batten Catalogue", "WEB 4818"},
    },
    visualMagnitude: 6.49,
    bvColour: 1.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.00965884),
        dec: Angle.Degrees(+44.42542990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205742"},
        {"Hipparcos Number", "HIP 106656"},
        {"Smithsonian Astrophysical Observation", "SAO 51085"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.04737507),
        dec: Angle.Degrees(+44.42718465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86856",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86856"},
        {"Smithsonian Astrophysical Observation", "SAO 46926"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.19128350),
        dec: Angle.Degrees(+44.42729078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10953"},
        {"Hipparcos Number", "HIP 8424"},
        {"Smithsonian Astrophysical Observation", "SAO 37526"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.16182516),
        dec: Angle.Degrees(+44.42764268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224970"},
        {"Hipparcos Number", "HIP 176"},
        {"Smithsonian Astrophysical Observation", "SAO 53591"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.55333411),
        dec: Angle.Degrees(+44.42827722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116582",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16877 AB"},
        {"Henry Draper", "HD 222109"},
        {"Hipparcos Number", "HIP 116582"},
        {"Geneva Identification System", "GEN# +1.00222109J"},
        {"Renson", "Renson 60860"},
        {"Smithsonian Astrophysical Observation", "SAO 53202"},
        {"Wilson Evans Batten Catalogue", "WEB 20582"},
    },
    visualMagnitude: 5.81,
    bvColour: -0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.38346323),
        dec: Angle.Degrees(+44.42903532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50216",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50216"},
    },
    visualMagnitude: 12.10,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.77395781),
        dec: Angle.Degrees(+44.42922017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 248.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206280"},
        {"Hipparcos Number", "HIP 106970"},
        {"Celescope Catalog", "CEL 5362"},
        {"Geneva Identification System", "GEN# +1.00206280"},
        {"Smithsonian Astrophysical Observation", "SAO 51161"},
        {"Wilson Evans Batten Catalogue", "WEB 19328"},
    },
    visualMagnitude: 6.77,
    bvColour: -0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.97484826),
        dec: Angle.Degrees(+44.43214467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72623",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72623"},
    },
    visualMagnitude: 10.92,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.71984459),
        dec: Angle.Degrees(+44.43452216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -206.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198931"},
        {"Hipparcos Number", "HIP 103007"},
        {"Geneva Identification System", "GEN# +1.00198931"},
        {"Smithsonian Astrophysical Observation", "SAO 50153"},
        {"Wilson Evans Batten Catalogue", "WEB 18700"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.04049511),
        dec: Angle.Degrees(+44.43462249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136751"},
        {"Hipparcos Number", "HIP 75093"},
        {"Geneva Identification System", "GEN# +1.00136751"},
        {"Smithsonian Astrophysical Observation", "SAO 45497"},
        {"Wilson Evans Batten Catalogue", "WEB 12806"},
    },
    visualMagnitude: 6.14,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.17352678),
        dec: Angle.Degrees(+44.43462734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33459"},
        {"Hipparcos Number", "HIP 24279"},
        {"Geneva Identification System", "GEN# +1.00033459"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.15730039),
        dec: Angle.Degrees(+44.43517629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61427",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61427"},
        {"Geneva Identification System", "GEN# +0.04502048"},
        {"Smithsonian Astrophysical Observation", "SAO 44238"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.81623721),
        dec: Angle.Degrees(+44.43522055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221254"},
        {"Hipparcos Number", "HIP 115997"},
        {"Geneva Identification System", "GEN# +1.00221254"},
        {"Smithsonian Astrophysical Observation", "SAO 53089"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.53872369),
        dec: Angle.Degrees(+44.43561361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185871"},
        {"Hipparcos Number", "HIP 96679"},
        {"Geneva Identification System", "GEN# +1.00185871"},
        {"Smithsonian Astrophysical Observation", "SAO 48687"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.83005732),
        dec: Angle.Degrees(+44.43635713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213390"},
        {"Hipparcos Number", "HIP 111080"},
        {"Smithsonian Astrophysical Observation", "SAO 52074"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.55137324),
        dec: Angle.Degrees(+44.43836579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83143"},
        {"Hipparcos Number", "HIP 47239"},
        {"Smithsonian Astrophysical Observation", "SAO 42947"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.42119931),
        dec: Angle.Degrees(+44.43955069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48275",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48275"},
    },
    visualMagnitude: 10.89,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.62789890),
        dec: Angle.Degrees(+44.43992607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207899"},
        {"Hipparcos Number", "HIP 107866"},
        {"Smithsonian Astrophysical Observation", "SAO 51369"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.80122907),
        dec: Angle.Degrees(+44.44074176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64134",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64134"},
    },
    visualMagnitude: 10.57,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.16527537),
        dec: Angle.Degrees(+44.44645238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 196.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52099"},
        {"Hipparcos Number", "HIP 33885"},
        {"Smithsonian Astrophysical Observation", "SAO 41509"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.50509924),
        dec: Angle.Degrees(+44.44898758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215028"},
        {"Hipparcos Number", "HIP 112042"},
        {"Cincinnati Publication", "Ci 18 2954"},
        {"Geneva Identification System", "GEN# +1.00215028"},
        {"Smithsonian Astrophysical Observation", "SAO 52274"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.40790231),
        dec: Angle.Degrees(+44.45031421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 277.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 160.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104813"},
        {"Hipparcos Number", "HIP 58852"},
        {"Geneva Identification System", "GEN# +1.00104813"},
        {"Smithsonian Astrophysical Observation", "SAO 44017"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.05511878),
        dec: Angle.Degrees(+44.45038072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105741",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105741"},
        {"Geneva Identification System", "GEN# +0.04303913"},
        {"Smithsonian Astrophysical Observation", "SAO 50816"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.26018298),
        dec: Angle.Degrees(+44.45177828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110591",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110591"},
        {"Smithsonian Astrophysical Observation", "SAO 51966"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.06845721),
        dec: Angle.Degrees(+44.45226054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216766"},
        {"Hipparcos Number", "HIP 113175"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.76289849),
        dec: Angle.Degrees(+44.45757813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13013"},
        {"Hipparcos Number", "HIP 9983"},
        {"Geneva Identification System", "GEN# +1.00013013"},
        {"Smithsonian Astrophysical Observation", "SAO 37794"},
        {"Wilson Evans Batten Catalogue", "WEB 2091"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.13978347),
        dec: Angle.Degrees(+44.45954374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35100",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35100"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.797,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.87412766),
        dec: Angle.Degrees(+44.46148855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36382",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36382"},
        {"Smithsonian Astrophysical Observation", "SAO 41804"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.32308944),
        dec: Angle.Degrees(+44.46165067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8130",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8130"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.12328039),
        dec: Angle.Degrees(+44.46386755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 307.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79512",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79512"},
        {"Cincinnati Publication", "Ci 20 975"},
        {"Smithsonian Astrophysical Observation", "SAO 45973"},
        {"Wilson Evans Batten Catalogue", "WEB 13457"},
    },
    visualMagnitude: 9.62,
    bvColour: 1.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.37397919),
        dec: Angle.Degrees(+44.46541840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -109.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 389.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132445"},
        {"Hipparcos Number", "HIP 73206"},
        {"Smithsonian Astrophysical Observation", "SAO 45303"},
        {"Wilson Evans Batten Catalogue", "WEB 12548"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.42893558),
        dec: Angle.Degrees(+44.46631658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172084"},
        {"Hipparcos Number", "HIP 91178"},
        {"Smithsonian Astrophysical Observation", "SAO 47637"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.01518890),
        dec: Angle.Degrees(+44.46711689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72"},
        {"Hipparcos Number", "HIP 474"},
        {"Smithsonian Astrophysical Observation", "SAO 36049"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.42019898),
        dec: Angle.Degrees(+44.46868671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199870"},
        {"Hipparcos Number", "HIP 103519"},
        {"Geneva Identification System", "GEN# +1.00199870"},
        {"Smithsonian Astrophysical Observation", "SAO 50298"},
        {"Wilson Evans Batten Catalogue", "WEB 18830"},
    },
    visualMagnitude: 5.55,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.58075681),
        dec: Angle.Degrees(+44.47154114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 69.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67390"},
        {"Hipparcos Number", "HIP 39960"},
        {"Smithsonian Astrophysical Observation", "SAO 42201"},
        {"Wilson Evans Batten Catalogue", "WEB 7789"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.39898835),
        dec: Angle.Degrees(+44.47162355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58205"},
        {"Hipparcos Number", "HIP 36147"},
        {"Smithsonian Astrophysical Observation", "SAO 41767"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.69225095),
        dec: Angle.Degrees(+44.47870334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59782"},
        {"Hipparcos Number", "HIP 36768"},
        {"Smithsonian Astrophysical Observation", "SAO 41848"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.43741623),
        dec: Angle.Degrees(+44.47936600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24898"},
        {"Hipparcos Number", "HIP 18640"},
        {"Smithsonian Astrophysical Observation", "SAO 39228"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.85252200),
        dec: Angle.Degrees(+44.48179185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5032",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5032"},
        {"Smithsonian Astrophysical Observation", "SAO 36903"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.11193538),
        dec: Angle.Degrees(+44.48373472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47775",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47775"},
    },
    visualMagnitude: 10.36,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.10449585),
        dec: Angle.Degrees(+44.48605826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -187.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195478"},
        {"Hipparcos Number", "HIP 101121"},
        {"Celescope Catalog", "CEL 5085"},
        {"Geneva Identification System", "GEN# +1.00195478"},
        {"Smithsonian Astrophysical Observation", "SAO 49701"},
    },
    visualMagnitude: 8.27,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.46856756),
        dec: Angle.Degrees(+44.48727371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3346"},
        {"Hipparcos Number", "HIP 2900"},
        {"Geneva Identification System", "GEN# +1.00003346"},
        {"Smithsonian Astrophysical Observation", "SAO 36509"},
        {"Wilson Evans Batten Catalogue", "WEB 524"},
    },
    visualMagnitude: 5.14,
    bvColour: 1.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.19362920),
        dec: Angle.Degrees(+44.48850971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15580"},
        {"Hipparcos Number", "HIP 11755"},
        {"Smithsonian Astrophysical Observation", "SAO 38087"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.91493416),
        dec: Angle.Degrees(+44.48875810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162751"},
        {"Hipparcos Number", "HIP 87315"},
        {"Smithsonian Astrophysical Observation", "SAO 47003"},
        {"Wilson Evans Batten Catalogue", "WEB 14732"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.61883549),
        dec: Angle.Degrees(+44.48940775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101967"},
        {"Hipparcos Number", "HIP 57242"},
        {"Geneva Identification System", "GEN# +1.00101967"},
        {"Smithsonian Astrophysical Observation", "SAO 43879"},
        {"Wilson Evans Batten Catalogue", "WEB 10296"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.07004934),
        dec: Angle.Degrees(+44.49064101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -189.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65518",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8901 AB"},
        {"Henry Draper", "HD 116878"},
        {"Hipparcos Number", "HIP 65518"},
        {"Geneva Identification System", "GEN# +1.00116878J"},
        {"Smithsonian Astrophysical Observation", "SAO 44605"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.45050764),
        dec: Angle.Degrees(+44.49397128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102401",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102401"},
        {"Cincinnati Publication", "Ci 20 1228"},
        {"Geneva Identification System", "GEN# +6.10010806"},
        {"Wilson Evans Batten Catalogue", "WEB 18540"},
    },
    visualMagnitude: 10.79,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.26560137),
        dec: Angle.Degrees(+44.49840983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 433.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 272.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96833"},
        {"Hipparcos Number", "HIP 54539"},
        {"Fundamental Katalog 5th Edition", "FK5 420"},
        {"Geneva Identification System", "GEN# +1.00096833"},
        {"Smithsonian Astrophysical Observation", "SAO 43629"},
        {"Wilson Evans Batten Catalogue", "WEB 9845"},
    },
    visualMagnitude: 3.00,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.41608092),
        dec: Angle.Degrees(+44.49855337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44606",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44606"},
    },
    visualMagnitude: 10.50,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.32720551),
        dec: Angle.Degrees(+44.49903846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48270"},
        {"Hipparcos Number", "HIP 32315"},
        {"Geneva Identification System", "GEN# +1.00048270"},
        {"Smithsonian Astrophysical Observation", "SAO 41308"},
        {"Wilson Evans Batten Catalogue", "WEB 6516"},
    },
    visualMagnitude: 6.64,
    bvColour: 1.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.19415053),
        dec: Angle.Degrees(+44.50554219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51929",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7844 AB"},
        {"Henry Draper", "HD 91751"},
        {"Hipparcos Number", "HIP 51929"},
        {"Smithsonian Astrophysical Observation", "SAO 43402"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.12307503),
        dec: Angle.Degrees(+44.50652470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133350"},
        {"Hipparcos Number", "HIP 73581"},
        {"Smithsonian Astrophysical Observation", "SAO 45343"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.59696254),
        dec: Angle.Degrees(+44.50766644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 949"},
        {"Hipparcos Number", "HIP 1125"},
        {"Geneva Identification System", "GEN# +1.00000949"},
        {"Smithsonian Astrophysical Observation", "SAO 36186"},
        {"Wilson Evans Batten Catalogue", "WEB 196"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.51181531),
        dec: Angle.Degrees(+44.51203389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5492",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5492"},
        {"Smithsonian Astrophysical Observation", "SAO 36983"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.57567756),
        dec: Angle.Degrees(+44.51535731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112957"},
        {"Hipparcos Number", "HIP 63433"},
        {"Geneva Identification System", "GEN# +1.00112957"},
        {"Smithsonian Astrophysical Observation", "SAO 44420"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.98219053),
        dec: Angle.Degrees(+44.51654727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 147.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -165.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203840"},
        {"Hipparcos Number", "HIP 105602"},
        {"Smithsonian Astrophysical Observation", "SAO 50784"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.83709729),
        dec: Angle.Degrees(+44.51830646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101300"},
        {"Hipparcos Number", "HIP 56886"},
        {"Fundamental Katalog 5th Edition", "FK5 5027"},
        {"Geneva Identification System", "GEN# +1.00101300"},
        {"Smithsonian Astrophysical Observation", "SAO 43852"},
        {"Wilson Evans Batten Catalogue", "WEB 10242"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.93479795),
        dec: Angle.Degrees(+44.51903021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158972"},
        {"Hipparcos Number", "HIP 85639"},
        {"Smithsonian Astrophysical Observation", "SAO 46752"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.884,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.52226395),
        dec: Angle.Degrees(+44.51910030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 134.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77529",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9802 AB"},
        {"Henry Draper", "HD 141930"},
        {"Hipparcos Number", "HIP 77529"},
        {"Smithsonian Astrophysical Observation", "SAO 45752"},
        {"Wilson Evans Batten Catalogue", "WEB 13127"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.45820461),
        dec: Angle.Degrees(+44.52207239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13804",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2232 A"},
        {"Henry Draper", "HD 18282"},
        {"Hipparcos Number", "HIP 13804"},
        {"Smithsonian Astrophysical Observation", "SAO 38468"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.748,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.44158966),
        dec: Angle.Degrees(+44.52408691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47914"},
        {"Hipparcos Number", "HIP 32173"},
        {"Fundamental Katalog 5th Edition", "FK5 2517"},
        {"Geneva Identification System", "GEN# +1.00047914"},
        {"Smithsonian Astrophysical Observation", "SAO 41288"},
        {"Wilson Evans Batten Catalogue", "WEB 6489"},
    },
    visualMagnitude: 5.04,
    bvColour: 1.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.77086794),
        dec: Angle.Degrees(+44.52452351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1848"},
        {"Hipparcos Number", "HIP 1818"},
        {"Smithsonian Astrophysical Observation", "SAO 36309"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.76315495),
        dec: Angle.Degrees(+44.52523902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13802",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2232 B"},
        {"Henry Draper", "HD 18281"},
        {"Hipparcos Number", "HIP 13802"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.43634380),
        dec: Angle.Degrees(+44.52666024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214455"},
        {"Hipparcos Number", "HIP 111695"},
        {"Smithsonian Astrophysical Observation", "SAO 52198"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.39034030),
        dec: Angle.Degrees(+44.52836275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186140"},
        {"Hipparcos Number", "HIP 96816"},
        {"Geneva Identification System", "GEN# +1.00186140"},
        {"Smithsonian Astrophysical Observation", "SAO 48716"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.19338717),
        dec: Angle.Degrees(+44.52846130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101081",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101081"},
        {"Smithsonian Astrophysical Observation", "SAO 49694"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.36177359),
        dec: Angle.Degrees(+44.52961277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215335"},
        {"Hipparcos Number", "HIP 112217"},
        {"Smithsonian Astrophysical Observation", "SAO 52308"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.91204343),
        dec: Angle.Degrees(+44.53052062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24463",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3811 A"},
        {"Hipparcos Number", "HIP 24463"},
        {"Cincinnati Publication", "Ci 20 320"},
        {"Geneva Identification System", "GEN# +0.04401142"},
    },
    visualMagnitude: 10.33,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.74367484),
        dec: Angle.Degrees(+44.53070272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -694.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18367",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18367"},
    },
    visualMagnitude: 10.47,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.90599750),
        dec: Angle.Degrees(+44.53117147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202124"},
        {"Hipparcos Number", "HIP 104695"},
        {"Celescope Catalog", "CEL 5273"},
        {"Geneva Identification System", "GEN# +1.00202124"},
        {"Smithsonian Astrophysical Observation", "SAO 50567"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.11829160),
        dec: Angle.Degrees(+44.53171872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75687",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75687"},
        {"Smithsonian Astrophysical Observation", "SAO 45554"},
    },
    visualMagnitude: 9.81,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.94037298),
        dec: Angle.Degrees(+44.53454290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212668"},
        {"Hipparcos Number", "HIP 110664"},
        {"Smithsonian Astrophysical Observation", "SAO 51975"},
    },
    visualMagnitude: 8.10,
    bvColour: -0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.27492611),
        dec: Angle.Degrees(+44.53858395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98344"},
        {"Hipparcos Number", "HIP 55244"},
        {"Geneva Identification System", "GEN# +1.00098344"},
        {"Smithsonian Astrophysical Observation", "SAO 43691"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.70209595),
        dec: Angle.Degrees(+44.54516878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215664"},
        {"Hipparcos Number", "HIP 112417"},
        {"Geneva Identification System", "GEN# +1.00215664"},
        {"Smithsonian Astrophysical Observation", "SAO 52348"},
        {"Wilson Evans Batten Catalogue", "WEB 20052"},
    },
    visualMagnitude: 5.84,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.54210525),
        dec: Angle.Degrees(+44.54597654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 142.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216661"},
        {"Hipparcos Number", "HIP 113081"},
        {"Smithsonian Astrophysical Observation", "SAO 52472"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.52380567),
        dec: Angle.Degrees(+44.54600646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223627"},
        {"Hipparcos Number", "HIP 117615"},
        {"Smithsonian Astrophysical Observation", "SAO 53421"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.79441029),
        dec: Angle.Degrees(+44.54779653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25151"},
        {"Hipparcos Number", "HIP 18804"},
        {"Smithsonian Astrophysical Observation", "SAO 39252"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.44206367),
        dec: Angle.Degrees(+44.54876233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98246"},
        {"Hipparcos Number", "HIP 55227"},
        {"Smithsonian Astrophysical Observation", "SAO 43690"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.64645468),
        dec: Angle.Degrees(+44.55175853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209147"},
        {"Hipparcos Number", "HIP 108606"},
        {"Renson", "Renson 58170"},
        {"Smithsonian Astrophysical Observation", "SAO 51531"},
        {"Wilson Evans Batten Catalogue", "WEB 19544"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.01848393),
        dec: Angle.Degrees(+44.55214223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146696"},
        {"Hipparcos Number", "HIP 79678"},
        {"Smithsonian Astrophysical Observation", "SAO 45997"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.92727037),
        dec: Angle.Degrees(+44.55260799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114679",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114679"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.46998533),
        dec: Angle.Degrees(+44.55336495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113613",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113613"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.16495416),
        dec: Angle.Degrees(+44.55486963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223952"},
        {"Hipparcos Number", "HIP 117834"},
        {"Smithsonian Astrophysical Observation", "SAO 53459"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.46884644),
        dec: Angle.Degrees(+44.55580163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179259"},
        {"Hipparcos Number", "HIP 94145"},
        {"Geneva Identification System", "GEN# +1.00179259"},
        {"Renson", "Renson 49800"},
        {"Smithsonian Astrophysical Observation", "SAO 48140"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.45629630),
        dec: Angle.Degrees(+44.55746811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1392"},
        {"Hipparcos Number", "HIP 1474"},
        {"Smithsonian Astrophysical Observation", "SAO 36250"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.58239388),
        dec: Angle.Degrees(+44.55843929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179367"},
        {"Hipparcos Number", "HIP 94174"},
        {"Geneva Identification System", "GEN# +1.00179367"},
        {"Renson", "Renson 49810"},
        {"Smithsonian Astrophysical Observation", "SAO 48149"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.54979748),
        dec: Angle.Degrees(+44.55998015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218525"},
        {"Hipparcos Number", "HIP 114237"},
        {"Geneva Identification System", "GEN# +1.00218525"},
        {"Smithsonian Astrophysical Observation", "SAO 52717"},
        {"Wilson Evans Batten Catalogue", "WEB 20288"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.05163879),
        dec: Angle.Degrees(+44.56184215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181598"},
        {"Hipparcos Number", "HIP 94927"},
        {"Smithsonian Astrophysical Observation", "SAO 48321"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.74788514),
        dec: Angle.Degrees(+44.56216158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9128",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1554 AB"},
        {"Henry Draper", "HD 11869"},
        {"Hipparcos Number", "HIP 9128"},
        {"Smithsonian Astrophysical Observation", "SAO 37641"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.41926190),
        dec: Angle.Degrees(+44.56333244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187104"},
        {"Hipparcos Number", "HIP 97285"},
        {"Smithsonian Astrophysical Observation", "SAO 48819"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.57911171),
        dec: Angle.Degrees(+44.56502244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126006"},
        {"Hipparcos Number", "HIP 70200"},
        {"Smithsonian Astrophysical Observation", "SAO 45010"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.44301613),
        dec: Angle.Degrees(+44.56515533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55944",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8171 A"},
        {"Henry Draper", "HD 99607"},
        {"Hipparcos Number", "HIP 55944"},
        {"Smithsonian Astrophysical Observation", "SAO 43750"},
        {"Wilson Evans Batten Catalogue", "WEB 10044"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.98387186),
        dec: Angle.Degrees(+44.56584464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -137.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33542"},
        {"Hipparcos Number", "HIP 24319"},
        {"Celescope Catalog", "CEL 563"},
        {"Fundamental Katalog 5th Edition", "FK5 4476"},
        {"Geneva Identification System", "GEN# +1.00033542"},
        {"Smithsonian Astrophysical Observation", "SAO 40128"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.28364438),
        dec: Angle.Degrees(+44.56699299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115061",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115061"},
        {"Smithsonian Astrophysical Observation", "SAO 52880"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.57860906),
        dec: Angle.Degrees(+44.57281955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217731"},
        {"Hipparcos Number", "HIP 113750"},
        {"Smithsonian Astrophysical Observation", "SAO 52616"},
        {"Wilson Evans Batten Catalogue", "WEB 20211"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.959,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.54715241),
        dec: Angle.Degrees(+44.57290212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1350"},
        {"Hipparcos Number", "HIP 1434"},
        {"Smithsonian Astrophysical Observation", "SAO 36242"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.47002802),
        dec: Angle.Degrees(+44.57794715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86856"},
        {"Hipparcos Number", "HIP 49197"},
        {"Geneva Identification System", "GEN# +1.00086856"},
        {"Smithsonian Astrophysical Observation", "SAO 43151"},
        {"Wilson Evans Batten Catalogue", "WEB 9110"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.61908834),
        dec: Angle.Degrees(+44.57872903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -283.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135963"},
        {"Hipparcos Number", "HIP 74727"},
        {"Smithsonian Astrophysical Observation", "SAO 45459"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.08166020),
        dec: Angle.Degrees(+44.58056479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220104"},
        {"Hipparcos Number", "HIP 115258"},
        {"Smithsonian Astrophysical Observation", "SAO 52925"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.17577413),
        dec: Angle.Degrees(+44.58067663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56150"},
        {"Hipparcos Number", "HIP 35334"},
        {"Smithsonian Astrophysical Observation", "SAO 41672"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.47765867),
        dec: Angle.Degrees(+44.58189817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37087"},
        {"Hipparcos Number", "HIP 26491"},
        {"Geneva Identification System", "GEN# +1.00037087"},
        {"Smithsonian Astrophysical Observation", "SAO 40497"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.51647689),
        dec: Angle.Degrees(+44.58193944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117576"},
        {"Hipparcos Number", "HIP 65900"},
        {"Geneva Identification System", "GEN# +1.00117576"},
        {"Smithsonian Astrophysical Observation", "SAO 44631"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.62966590),
        dec: Angle.Degrees(+44.58291671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -131.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42757"},
        {"Hipparcos Number", "HIP 29633"},
        {"Geneva Identification System", "GEN# +1.00042757"},
        {"Smithsonian Astrophysical Observation", "SAO 40966"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.66616550),
        dec: Angle.Degrees(+44.58426428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44428",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44428"},
        {"Geneva Identification System", "GEN# +0.04501668"},
        {"Wilson Evans Batten Catalogue", "WEB 8517"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.78272968),
        dec: Angle.Degrees(+44.58569234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132892"},
        {"Hipparcos Number", "HIP 73404"},
        {"Smithsonian Astrophysical Observation", "SAO 45324"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.01515737),
        dec: Angle.Degrees(+44.58634245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191422"},
        {"Hipparcos Number", "HIP 99167"},
        {"Smithsonian Astrophysical Observation", "SAO 49218"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.99093555),
        dec: Angle.Degrees(+44.58971571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36973"},
        {"Hipparcos Number", "HIP 26430"},
        {"Geneva Identification System", "GEN# +1.00036973"},
        {"Smithsonian Astrophysical Observation", "SAO 40491"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.37278369),
        dec: Angle.Degrees(+44.58978876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7655",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7655"},
        {"Geneva Identification System", "GEN# +6.20030379"},
    },
    visualMagnitude: 10.74,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.64021928),
        dec: Angle.Degrees(+44.59018534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 157.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 109.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209640"},
        {"Hipparcos Number", "HIP 108922"},
        {"Smithsonian Astrophysical Observation", "SAO 51609"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.96613942),
        dec: Angle.Degrees(+44.59035677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 801"},
        {"Hipparcos Number", "HIP 1008"},
        {"Smithsonian Astrophysical Observation", "SAO 36156"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.14013701),
        dec: Angle.Degrees(+44.59075801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28438",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4576 AB"},
        {"Henry Draper", "HD 40325"},
        {"Hipparcos Number", "HIP 28438"},
        {"Smithsonian Astrophysical Observation", "SAO 40769"},
        {"Wilson Evans Batten Catalogue", "WEB 5557"},
    },
    visualMagnitude: 6.21,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.07885266),
        dec: Angle.Degrees(+44.59210690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219224"},
        {"Hipparcos Number", "HIP 114672"},
        {"Geneva Identification System", "GEN# +1.00219224"},
        {"Smithsonian Astrophysical Observation", "SAO 52813"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.45475944),
        dec: Angle.Degrees(+44.59793087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166955"},
        {"Hipparcos Number", "HIP 89082"},
        {"Smithsonian Astrophysical Observation", "SAO 47278"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.70835894),
        dec: Angle.Degrees(+44.59833352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141454"},
        {"Hipparcos Number", "HIP 77345"},
        {"Smithsonian Astrophysical Observation", "SAO 45729"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.84514971),
        dec: Angle.Degrees(+44.59875001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10985",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1795 AB"},
        {"Henry Draper", "HD 14477"},
        {"Hipparcos Number", "HIP 10985"},
        {"Renson", "Renson 3650"},
        {"Smithsonian Astrophysical Observation", "SAO 37971"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.39864603),
        dec: Angle.Degrees(+44.59999227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118282",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17147 AB"},
        {"Hipparcos Number", "HIP 118282"},
        {"Smithsonian Astrophysical Observation", "SAO 53554"},
    },
    visualMagnitude: 9.97,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.87345142),
        dec: Angle.Degrees(+44.60158794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 380.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 160.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28416"},
        {"Hipparcos Number", "HIP 21062"},
        {"Smithsonian Astrophysical Observation", "SAO 39575"},
        {"Wilson Evans Batten Catalogue", "WEB 4054"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.72035929),
        dec: Angle.Degrees(+44.60305620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81714",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81714"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.36244921),
        dec: Angle.Degrees(+44.60337021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21546",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21546"},
        {"Smithsonian Astrophysical Observation", "SAO 39652"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.39743881),
        dec: Angle.Degrees(+44.60792651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100341",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13744 AB"},
        {"Hipparcos Number", "HIP 100341"},
        {"Smithsonian Astrophysical Observation", "SAO 49503"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.864,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.24117884),
        dec: Angle.Degrees(+44.60823735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -157.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131316"},
        {"Hipparcos Number", "HIP 72662"},
        {"Wilson Evans Batten Catalogue", "WEB 12489"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.85417318),
        dec: Angle.Degrees(+44.60946982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24598"},
        {"Hipparcos Number", "HIP 18447"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.14748111),
        dec: Angle.Degrees(+44.61153533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186"},
        {"Hipparcos Number", "HIP 559"},
        {"Geneva Identification System", "GEN# +1.00000186"},
        {"Smithsonian Astrophysical Observation", "SAO 36068"},
    },
    visualMagnitude: 9.00,
    bvColour: -0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.69982422),
        dec: Angle.Degrees(+44.61284407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69286"},
        {"Hipparcos Number", "HIP 40674"},
        {"Smithsonian Astrophysical Observation", "SAO 42279"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.55882447),
        dec: Angle.Degrees(+44.61314724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -266.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6584"},
        {"Hipparcos Number", "HIP 5265"},
        {"Smithsonian Astrophysical Observation", "SAO 36938"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.81237346),
        dec: Angle.Degrees(+44.61668782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191943"},
        {"Hipparcos Number", "HIP 99395"},
        {"Smithsonian Astrophysical Observation", "SAO 49268"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.62019405),
        dec: Angle.Degrees(+44.61685584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21182",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21182"},
        {"Smithsonian Astrophysical Observation", "SAO 39589"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.12077166),
        dec: Angle.Degrees(+44.61840468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128730"},
        {"Hipparcos Number", "HIP 71491"},
        {"Smithsonian Astrophysical Observation", "SAO 45137"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.29926971),
        dec: Angle.Degrees(+44.62068241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37106",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6210 AB"},
        {"Henry Draper", "HD 60615"},
        {"Hipparcos Number", "HIP 37106"},
        {"Smithsonian Astrophysical Observation", "SAO 41890"},
    },
    visualMagnitude: 8.34,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.37686508),
        dec: Angle.Degrees(+44.62107597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104424"},
        {"Hipparcos Number", "HIP 58644"},
        {"Geneva Identification System", "GEN# +1.00104424"},
        {"Smithsonian Astrophysical Observation", "SAO 43999"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.38378830),
        dec: Angle.Degrees(+44.62428219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214957"},
        {"Hipparcos Number", "HIP 111997"},
    },
    visualMagnitude: 9.98,
    bvColour: -0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.28195743),
        dec: Angle.Degrees(+44.62493130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85233",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85233"},
    },
    visualMagnitude: 11.05,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.24406067),
        dec: Angle.Degrees(+44.62517821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81144"},
        {"Hipparcos Number", "HIP 46207"},
        {"Smithsonian Astrophysical Observation", "SAO 42848"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.31542698),
        dec: Angle.Degrees(+44.62551218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87002"},
        {"Hipparcos Number", "HIP 49263"},
        {"Geneva Identification System", "GEN# +1.00087002"},
        {"Smithsonian Astrophysical Observation", "SAO 43160"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.84605723),
        dec: Angle.Degrees(+44.62745001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37694"},
        {"Hipparcos Number", "HIP 26903"},
        {"Smithsonian Astrophysical Observation", "SAO 40548"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.67374741),
        dec: Angle.Degrees(+44.62945437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1448"},
        {"Hipparcos Number", "HIP 1496"},
        {"Smithsonian Astrophysical Observation", "SAO 36255"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.66966639),
        dec: Angle.Degrees(+44.63002263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104241"},
        {"Hipparcos Number", "HIP 58552"},
        {"Geneva Identification System", "GEN# +1.00104241"},
        {"Renson", "Renson 30150"},
        {"Smithsonian Astrophysical Observation", "SAO 43991"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.10183919),
        dec: Angle.Degrees(+44.63032987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7722"},
        {"Hipparcos Number", "HIP 6047"},
        {"Geneva Identification System", "GEN# +1.00007722"},
        {"Smithsonian Astrophysical Observation", "SAO 37086"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.42404629),
        dec: Angle.Degrees(+44.63191550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22675",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22675"},
    },
    visualMagnitude: 10.31,
    bvColour: 1.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.15214873),
        dec: Angle.Degrees(+44.63510763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154325"},
        {"Hipparcos Number", "HIP 83398"},
        {"Geneva Identification System", "GEN# +1.00154325"},
        {"Smithsonian Astrophysical Observation", "SAO 46453"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.67530875),
        dec: Angle.Degrees(+44.63676806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -111.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3291"},
        {"Hipparcos Number", "HIP 2866"},
        {"Smithsonian Astrophysical Observation", "SAO 36506"},
        {"Wilson Evans Batten Catalogue", "WEB 516"},
    },
    visualMagnitude: 7.31,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.08428111),
        dec: Angle.Degrees(+44.63890530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15992"},
        {"Hipparcos Number", "HIP 12064"},
        {"Fundamental Katalog 5th Edition", "FK5 4238"},
        {"Geneva Identification System", "GEN# +1.00015992"},
        {"Smithsonian Astrophysical Observation", "SAO 38147"},
        {"Wilson Evans Batten Catalogue", "WEB 2484"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.89135122),
        dec: Angle.Degrees(+44.64003434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133484"},
        {"Hipparcos Number", "HIP 73637"},
        {"Fundamental Katalog 5th Edition", "FK5 3192"},
        {"Geneva Identification System", "GEN# +1.00133484"},
        {"Smithsonian Astrophysical Observation", "SAO 45348"},
        {"Wilson Evans Batten Catalogue", "WEB 12592"},
    },
    visualMagnitude: 6.59,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.77762433),
        dec: Angle.Degrees(+44.64442878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60195",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60195"},
        {"Geneva Identification System", "GEN# +0.04502027"},
    },
    visualMagnitude: 10.08,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.16547718),
        dec: Angle.Degrees(+44.64465499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47881"},
        {"Hipparcos Number", "HIP 32163"},
        {"Smithsonian Astrophysical Observation", "SAO 41285"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.74465511),
        dec: Angle.Degrees(+44.64793090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31451",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31451"},
    },
    visualMagnitude: 10.17,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.83908080),
        dec: Angle.Degrees(+44.64916081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -186.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108845",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15578 AB"},
        {"Henry Draper", "HD 209515"},
        {"Hipparcos Number", "HIP 108845"},
        {"Celescope Catalog", "CEL 5424"},
        {"Geneva Identification System", "GEN# +1.00209515J"},
        {"Smithsonian Astrophysical Observation", "SAO 51595"},
        {"Wilson Evans Batten Catalogue", "WEB 19577"},
    },
    visualMagnitude: 5.57,
    bvColour: -0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.73615775),
        dec: Angle.Degrees(+44.64994158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38488",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38488"},
        {"Smithsonian Astrophysical Observation", "SAO 42044"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.23067149),
        dec: Angle.Degrees(+44.65149838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167780"},
        {"Hipparcos Number", "HIP 89403"},
        {"Geneva Identification System", "GEN# +1.00167780"},
        {"Smithsonian Astrophysical Observation", "SAO 47334"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.884,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.67227760),
        dec: Angle.Degrees(+44.65235029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110449",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110449"},
    },
    visualMagnitude: 10.50,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.57568034),
        dec: Angle.Degrees(+44.65237301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134110"},
        {"Hipparcos Number", "HIP 73936"},
        {"Smithsonian Astrophysical Observation", "SAO 45377"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.63616418),
        dec: Angle.Degrees(+44.65502818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65950",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65950"},
        {"Geneva Identification System", "GEN# +0.04502114"},
        {"Smithsonian Astrophysical Observation", "SAO 44638"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.81064022),
        dec: Angle.Degrees(+44.65504320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10270",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1693 A"},
        {"Hipparcos Number", "HIP 10270"},
    },
    visualMagnitude: 10.75,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)12, 13.7300),
        dec: Angle.DegreesMinutesSeconds((int)+44, (int)39, 23.600)
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
    primaryId: "HIP 108884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209570"},
        {"Hipparcos Number", "HIP 108884"},
        {"Smithsonian Astrophysical Observation", "SAO 51601"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.84780107),
        dec: Angle.Degrees(+44.65682075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221540"},
        {"Hipparcos Number", "HIP 116205"},
        {"Geneva Identification System", "GEN# +1.00221540"},
        {"Smithsonian Astrophysical Observation", "SAO 53135"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.17098440),
        dec: Angle.Degrees(+44.65728149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62694"},
        {"Hipparcos Number", "HIP 38001"},
        {"Smithsonian Astrophysical Observation", "SAO 41998"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.83283230),
        dec: Angle.Degrees(+44.65773364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -156.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89602"},
        {"Hipparcos Number", "HIP 50711"},
        {"Smithsonian Astrophysical Observation", "SAO 43300"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.32059170),
        dec: Angle.Degrees(+44.66023217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15688",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15688"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.823,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.52153995),
        dec: Angle.Degrees(+44.66167311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76116"},
        {"Hipparcos Number", "HIP 43843"},
        {"Geneva Identification System", "GEN# +1.00076116"},
        {"Smithsonian Astrophysical Observation", "SAO 42602"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.95478997),
        dec: Angle.Degrees(+44.66221512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41500",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41500"},
        {"Smithsonian Astrophysical Observation", "SAO 42373"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.882,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.96012998),
        dec: Angle.Degrees(+44.66242422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3565"},
        {"Hipparcos Number", "HIP 3071"},
        {"Smithsonian Astrophysical Observation", "SAO 36547"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.74415558),
        dec: Angle.Degrees(+44.66314452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25918"},
        {"Hipparcos Number", "HIP 19301"},
        {"Geneva Identification System", "GEN# +1.00025918"},
        {"Smithsonian Astrophysical Observation", "SAO 39329"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.06043794),
        dec: Angle.Degrees(+44.66316182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -298.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -135.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15712",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15712"},
        {"Smithsonian Astrophysical Observation", "SAO 38760"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.59999275),
        dec: Angle.Degrees(+44.66359985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69713"},
        {"Hipparcos Number", "HIP 40844"},
        {"Geneva Identification System", "GEN# +1.00069713"},
        {"Smithsonian Astrophysical Observation", "SAO 42292"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.01632903),
        dec: Angle.Degrees(+44.66400853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214588"},
        {"Hipparcos Number", "HIP 111789"},
        {"Smithsonian Astrophysical Observation", "SAO 52217"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.64048924),
        dec: Angle.Degrees(+44.66903574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163093"},
        {"Hipparcos Number", "HIP 87462"},
        {"Smithsonian Astrophysical Observation", "SAO 47028"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.06391931),
        dec: Angle.Degrees(+44.66918098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82755",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82755"},
        {"Smithsonian Astrophysical Observation", "SAO 46365"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.70814184),
        dec: Angle.Degrees(+44.67066764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5970",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5970"},
    },
    visualMagnitude: 11.97,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.18547637),
        dec: Angle.Degrees(+44.67133148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 211.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13127"},
        {"Hipparcos Number", "HIP 10082"},
        {"Geneva Identification System", "GEN# +1.00013127"},
        {"Smithsonian Astrophysical Observation", "SAO 37816"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.41081499),
        dec: Angle.Degrees(+44.67183048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 133.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183648"},
        {"Hipparcos Number", "HIP 95754"},
        {"Geneva Identification System", "GEN# +1.00183648"},
        {"Smithsonian Astrophysical Observation", "SAO 48493"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.13942058),
        dec: Angle.Degrees(+44.67271798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50813"},
        {"Hipparcos Number", "HIP 33409"},
        {"Smithsonian Astrophysical Observation", "SAO 41451"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.22406996),
        dec: Angle.Degrees(+44.67280010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104250",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14664 AB"},
        {"Henry Draper", "HD 201306"},
        {"Hipparcos Number", "HIP 104250"},
        {"Celescope Catalog", "CEL 5246"},
        {"Geneva Identification System", "GEN# +1.00201306J"},
        {"Smithsonian Astrophysical Observation", "SAO 50468"},
    },
    visualMagnitude: 7.38,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.81221011),
        dec: Angle.Degrees(+44.67407650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116253",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116253"},
        {"Smithsonian Astrophysical Observation", "SAO 53143"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.34396733),
        dec: Angle.Degrees(+44.67413434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224894"},
        {"Hipparcos Number", "HIP 119"},
        {"Smithsonian Astrophysical Observation", "SAO 53579"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.39020229),
        dec: Angle.Degrees(+44.67544581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46675",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7403 B"},
        {"Hipparcos Number", "HIP 46675"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.73683943),
        dec: Angle.Degrees(+44.67740102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169265"},
        {"Hipparcos Number", "HIP 90003"},
        {"Geneva Identification System", "GEN# +1.00169265"},
        {"Smithsonian Astrophysical Observation", "SAO 47419"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.45664816),
        dec: Angle.Degrees(+44.67769804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47172"},
        {"Hipparcos Number", "HIP 31847"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.87712648),
        dec: Angle.Degrees(+44.67799642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55307",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55307"},
        {"Smithsonian Astrophysical Observation", "SAO 43696"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.90112952),
        dec: Angle.Degrees(+44.67866006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52508",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52508"},
        {"Geneva Identification System", "GEN# +0.04501859"},
        {"Smithsonian Astrophysical Observation", "SAO 43453"},
        {"Wilson Evans Batten Catalogue", "WEB 9565"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.04699885),
        dec: Angle.Degrees(+44.67893489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80679",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80679"},
        {"Cincinnati Publication", "Ci 20 993"},
        {"Geneva Identification System", "GEN# +9.80180058"},
        {"Wilson Evans Batten Catalogue", "WEB 13645"},
    },
    visualMagnitude: 11.30,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.07121414),
        dec: Angle.Degrees(+44.67897403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -267.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -689.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51354",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51354"},
    },
    visualMagnitude: 10.76,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.34008129),
        dec: Angle.Degrees(+44.67934772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112841",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112841"},
    },
    visualMagnitude: 11.05,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.77961923),
        dec: Angle.Degrees(+44.68147500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 175.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57346",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57346"},
    },
    visualMagnitude: 11.17,
    bvColour: 1.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.36855739),
        dec: Angle.Degrees(+44.68333691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -234.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 126.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46673",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7403 A"},
        {"Henry Draper", "HD 82040"},
        {"Hipparcos Number", "HIP 46673"},
        {"Smithsonian Astrophysical Observation", "SAO 42901"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.73573214),
        dec: Angle.Degrees(+44.68392643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92132",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92132"},
        {"Fundamental Katalog 5th Edition", "FK5 5649"},
        {"Smithsonian Astrophysical Observation", "SAO 47794"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.864,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.67354674),
        dec: Angle.Degrees(+44.68519346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27025"},
        {"Hipparcos Number", "HIP 20080"},
        {"Celescope Catalog", "CEL 381"},
        {"Geneva Identification System", "GEN# +1.00027025"},
        {"Smithsonian Astrophysical Observation", "SAO 39450"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.57913777),
        dec: Angle.Degrees(+44.68539863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183955"},
        {"Hipparcos Number", "HIP 95876"},
        {"Geneva Identification System", "GEN# +1.00183955"},
        {"Smithsonian Astrophysical Observation", "SAO 48515"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.48621389),
        dec: Angle.Degrees(+44.68974976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148253"},
        {"Hipparcos Number", "HIP 80414"},
        {"Geneva Identification System", "GEN# +1.00148253"},
        {"Smithsonian Astrophysical Observation", "SAO 46073"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.20027383),
        dec: Angle.Degrees(+44.68992920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93703",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93703"},
        {"Smithsonian Astrophysical Observation", "SAO 48061"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.21099979),
        dec: Angle.Degrees(+44.69130233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85717"},
        {"Hipparcos Number", "HIP 48616"},
        {"Smithsonian Astrophysical Observation", "SAO 43099"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.71796734),
        dec: Angle.Degrees(+44.69340956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185351"},
        {"Hipparcos Number", "HIP 96459"},
        {"Geneva Identification System", "GEN# +1.00185351"},
        {"Smithsonian Astrophysical Observation", "SAO 48649"},
        {"Wilson Evans Batten Catalogue", "WEB 16922"},
    },
    visualMagnitude: 5.17,
    bvColour: 0.928,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.15856119),
        dec: Angle.Degrees(+44.69518822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57904",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57904"},
        {"Smithsonian Astrophysical Observation", "SAO 43926"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.15360670),
        dec: Angle.Degrees(+44.69558936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205939"},
        {"Hipparcos Number", "HIP 106752"},
        {"Geneva Identification System", "GEN# +1.00205939"},
        {"Smithsonian Astrophysical Observation", "SAO 51109"},
        {"Wilson Evans Batten Catalogue", "WEB 19300"},
    },
    visualMagnitude: 6.19,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.36614626),
        dec: Angle.Degrees(+44.69661451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213779"},
        {"Hipparcos Number", "HIP 111318"},
        {"Smithsonian Astrophysical Observation", "SAO 52132"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.27982571),
        dec: Angle.Degrees(+44.69759100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33842"},
        {"Hipparcos Number", "HIP 24491"},
        {"Smithsonian Astrophysical Observation", "SAO 40161"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.898,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.82157927),
        dec: Angle.Degrees(+44.69962478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194479"},
        {"Hipparcos Number", "HIP 100609"},
        {"Geneva Identification System", "GEN# +1.00194479"},
        {"Smithsonian Astrophysical Observation", "SAO 49582"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.02340472),
        dec: Angle.Degrees(+44.70098492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84059"},
        {"Hipparcos Number", "HIP 47725"},
        {"Geneva Identification System", "GEN# +1.00084059"},
        {"Smithsonian Astrophysical Observation", "SAO 43000"},
        {"Wilson Evans Batten Catalogue", "WEB 8940"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.93685218),
        dec: Angle.Degrees(+44.70131764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75135"},
        {"Hipparcos Number", "HIP 43345"},
        {"Smithsonian Astrophysical Observation", "SAO 42564"},
        {"Wilson Evans Batten Catalogue", "WEB 8348"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.44708360),
        dec: Angle.Degrees(+44.70429672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43147"},
        {"Hipparcos Number", "HIP 29824"},
        {"Cincinnati Publication", "Ci 20 382"},
        {"Geneva Identification System", "GEN# +1.00043147"},
        {"Smithsonian Astrophysical Observation", "SAO 40990"},
        {"Wilson Evans Batten Catalogue", "WEB 5897"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.21057254),
        dec: Angle.Degrees(+44.70653320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -255.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -333.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117122"},
        {"Hipparcos Number", "HIP 65641"},
        {"Geneva Identification System", "GEN# +1.00117122"},
        {"Smithsonian Astrophysical Observation", "SAO 44615"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.86477366),
        dec: Angle.Degrees(+44.70687862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 800"},
        {"Hipparcos Number", "HIP 1009"},
        {"Smithsonian Astrophysical Observation", "SAO 36157"},
    },
    visualMagnitude: 6.50,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.14201623),
        dec: Angle.Degrees(+44.70724772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1546"},
        {"Hipparcos Number", "HIP 1593"},
        {"Geneva Identification System", "GEN# +1.00001546"},
        {"Wilson Evans Batten Catalogue", "WEB 287"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.97513927),
        dec: Angle.Degrees(+44.70943858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145497"},
        {"Hipparcos Number", "HIP 79163"},
        {"Smithsonian Astrophysical Observation", "SAO 45916"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.35715841),
        dec: Angle.Degrees(+44.71111767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4675",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 824 A"},
        {"Henry Draper", "HD 5789"},
        {"Hipparcos Number", "HIP 4675"},
        {"Celescope Catalog", "CEL 105"},
        {"Geneva Identification System", "GEN# +1.00005789J"},
        {"Renson", "Renson 1510"},
        {"Smithsonian Astrophysical Observation", "SAO 36833"},
        {"Wilson Evans Batten Catalogue", "WEB 880"},
    },
    visualMagnitude: 5.69,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.01477994),
        dec: Angle.Degrees(+44.71330426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103053",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103053"},
        {"Smithsonian Astrophysical Observation", "SAO 50167"},
        {"Wilson Evans Batten Catalogue", "WEB 18707"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.18265611),
        dec: Angle.Degrees(+44.71484886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116405"},
        {"Hipparcos Number", "HIP 65280"},
        {"Geneva Identification System", "GEN# +1.00116405"},
        {"Smithsonian Astrophysical Observation", "SAO 44585"},
    },
    visualMagnitude: 8.34,
    bvColour: -0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.68798394),
        dec: Angle.Degrees(+44.71499317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100972"},
        {"Hipparcos Number", "HIP 56708"},
        {"Geneva Identification System", "GEN# +1.00100972"},
        {"Smithsonian Astrophysical Observation", "SAO 43831"},
        {"Wilson Evans Batten Catalogue", "WEB 10197"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.40318789),
        dec: Angle.Degrees(+44.71632323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164527"},
        {"Hipparcos Number", "HIP 88089"},
        {"Geneva Identification System", "GEN# +1.00164527"},
        {"Smithsonian Astrophysical Observation", "SAO 47112"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.86710431),
        dec: Angle.Degrees(+44.71813691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22995",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22995"},
        {"Wilson Evans Batten Catalogue", "WEB 4465"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.20617170),
        dec: Angle.Degrees(+44.71834938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20393"},
        {"Hipparcos Number", "HIP 15399"},
        {"Smithsonian Astrophysical Observation", "SAO 38709"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.63551029),
        dec: Angle.Degrees(+44.71961930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47529",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47529"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.35298734),
        dec: Angle.Degrees(+44.72168601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112148",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16212 AB"},
        {"Henry Draper", "HD 215227"},
        {"Hipparcos Number", "HIP 112148"},
        {"Geneva Identification System", "GEN# +1.00215227J"},
        {"Smithsonian Astrophysical Observation", "SAO 52294"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.73877444),
        dec: Angle.Degrees(+44.72174653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 747",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 108 A"},
        {"Henry Draper", "HD 460"},
        {"Hipparcos Number", "HIP 747"},
        {"Geneva Identification System", "GEN# +1.00000460"},
        {"Smithsonian Astrophysical Observation", "SAO 36106"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.29237517),
        dec: Angle.Degrees(+44.72184555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 750",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 108 B"},
        {"Hipparcos Number", "HIP 750"},
    },
    visualMagnitude: 10.63,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.29831313),
        dec: Angle.Degrees(+44.72276734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115402"},
        {"Hipparcos Number", "HIP 64758"},
        {"Geneva Identification System", "GEN# +1.00115402"},
        {"Smithsonian Astrophysical Observation", "SAO 44537"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.07335992),
        dec: Angle.Degrees(+44.72296309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160215"},
        {"Hipparcos Number", "HIP 86169"},
        {"Geneva Identification System", "GEN# +1.00160215"},
        {"Smithsonian Astrophysical Observation", "SAO 46833"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.13225916),
        dec: Angle.Degrees(+44.72322626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45294",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45294"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.45612936),
        dec: Angle.Degrees(+44.72359780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40332",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40332"},
        {"Smithsonian Astrophysical Observation", "SAO 42235"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.52459271),
        dec: Angle.Degrees(+44.72369592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67880",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67880"},
        {"Smithsonian Astrophysical Observation", "SAO 44792"},
        {"Wilson Evans Batten Catalogue", "WEB 11932"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.54158697),
        dec: Angle.Degrees(+44.72512770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 80.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103942"},
        {"Hipparcos Number", "HIP 58382"},
        {"Smithsonian Astrophysical Observation", "SAO 43976"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.57480293),
        dec: Angle.Degrees(+44.72757716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 119.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2600",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2600"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.25512792),
        dec: Angle.Degrees(+44.73019250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 223.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30987"},
        {"Hipparcos Number", "HIP 22803"},
        {"Geneva Identification System", "GEN# +1.00030987"},
        {"Smithsonian Astrophysical Observation", "SAO 39844"},
        {"Wilson Evans Batten Catalogue", "WEB 4413"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.58398743),
        dec: Angle.Degrees(+44.73151244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32619"},
        {"Hipparcos Number", "HIP 23778"},
        {"Geneva Identification System", "GEN# +1.00032619"},
        {"Smithsonian Astrophysical Observation", "SAO 40025"},
        {"Wilson Evans Batten Catalogue", "WEB 4638"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.65367936),
        dec: Angle.Degrees(+44.73185543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44832"},
        {"Hipparcos Number", "HIP 30628"},
        {"Smithsonian Astrophysical Observation", "SAO 41091"},
    },
    visualMagnitude: 8.20,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.54231064),
        dec: Angle.Degrees(+44.73256571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33307"},
        {"Hipparcos Number", "HIP 24175"},
        {"Geneva Identification System", "GEN# +1.00033307"},
        {"Smithsonian Astrophysical Observation", "SAO 40089"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.87075435),
        dec: Angle.Degrees(+44.73349166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46528"},
        {"Hipparcos Number", "HIP 31548"},
        {"Smithsonian Astrophysical Observation", "SAO 41204"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.05437155),
        dec: Angle.Degrees(+44.73368376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60643",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8546 AB"},
        {"Henry Draper", "HD 108224"},
        {"Hipparcos Number", "HIP 60643"},
        {"Smithsonian Astrophysical Observation", "SAO 44170"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.43775450),
        dec: Angle.Degrees(+44.73476174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103322"},
        {"Hipparcos Number", "HIP 58013"},
        {"Geneva Identification System", "GEN# +1.00103322"},
        {"Smithsonian Astrophysical Observation", "SAO 43940"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.48913766),
        dec: Angle.Degrees(+44.73488846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35979"},
        {"Hipparcos Number", "HIP 25803"},
        {"Smithsonian Astrophysical Observation", "SAO 40384"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.67098823),
        dec: Angle.Degrees(+44.73636462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125373"},
        {"Hipparcos Number", "HIP 69853"},
        {"Smithsonian Astrophysical Observation", "SAO 44978"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.43506288),
        dec: Angle.Degrees(+44.73701163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61632",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61632"},
    },
    visualMagnitude: 11.52,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.49144350),
        dec: Angle.Degrees(+44.73817691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44947",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44947"},
    },
    visualMagnitude: 10.64,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.34192763),
        dec: Angle.Degrees(+44.73830240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61633",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61633"},
    },
    visualMagnitude: 11.44,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.49535071),
        dec: Angle.Degrees(+44.73870458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86621",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86621"},
        {"Smithsonian Astrophysical Observation", "SAO 46895"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.49321940),
        dec: Angle.Degrees(+44.73918169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -126.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99"},
        {"Hipparcos Number", "HIP 498"},
        {"Smithsonian Astrophysical Observation", "SAO 36056"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.49280820),
        dec: Angle.Degrees(+44.73937991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170646"},
        {"Hipparcos Number", "HIP 90540"},
        {"Geneva Identification System", "GEN# +1.00170646"},
        {"Smithsonian Astrophysical Observation", "SAO 47522"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.10770516),
        dec: Angle.Degrees(+44.73950235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102673"},
        {"Hipparcos Number", "HIP 57652"},
        {"Smithsonian Astrophysical Observation", "SAO 43902"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.35119493),
        dec: Angle.Degrees(+44.74034416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70491"},
        {"Hipparcos Number", "HIP 41176"},
        {"Geneva Identification System", "GEN# +1.00070491"},
        {"Smithsonian Astrophysical Observation", "SAO 42335"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.878,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.03586509),
        dec: Angle.Degrees(+44.74221541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25182"},
        {"Hipparcos Number", "HIP 18827"},
        {"Smithsonian Astrophysical Observation", "SAO 39256"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.51968392),
        dec: Angle.Degrees(+44.74225702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1314"},
        {"Hipparcos Number", "HIP 1409"},
        {"Smithsonian Astrophysical Observation", "SAO 36241"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.41117033),
        dec: Angle.Degrees(+44.74490629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115374",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115374"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.57636926),
        dec: Angle.Degrees(+44.74599571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113048",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16345 AB"},
        {"Henry Draper", "HD 216608"},
        {"Hipparcos Number", "HIP 113048"},
        {"Geneva Identification System", "GEN# +1.00216608J"},
        {"Smithsonian Astrophysical Observation", "SAO 52465"},
        {"Wilson Evans Batten Catalogue", "WEB 20126"},
    },
    visualMagnitude: 5.79,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.41732810),
        dec: Angle.Degrees(+44.74920148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26587"},
        {"Hipparcos Number", "HIP 19761"},
        {"Geneva Identification System", "GEN# +1.00026587"},
        {"Smithsonian Astrophysical Observation", "SAO 39398"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.55340274),
        dec: Angle.Degrees(+44.74966973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69197"},
        {"Hipparcos Number", "HIP 40631"},
        {"Smithsonian Astrophysical Observation", "SAO 42271"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.42797928),
        dec: Angle.Degrees(+44.74992323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215566"},
        {"Hipparcos Number", "HIP 112351"},
        {"Smithsonian Astrophysical Observation", "SAO 52336"},
        {"Wilson Evans Batten Catalogue", "WEB 20041"},
    },
    visualMagnitude: 7.00,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.35196727),
        dec: Angle.Degrees(+44.75244939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144269"},
        {"Hipparcos Number", "HIP 78634"},
        {"Smithsonian Astrophysical Observation", "SAO 45870"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.79129452),
        dec: Angle.Degrees(+44.75271287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222642"},
        {"Hipparcos Number", "HIP 116940"},
        {"Geneva Identification System", "GEN# +1.00222642"},
        {"Smithsonian Astrophysical Observation", "SAO 53291"},
        {"Wilson Evans Batten Catalogue", "WEB 20628"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.55936311),
        dec: Angle.Degrees(+44.75547837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83386",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83386"},
        {"Smithsonian Astrophysical Observation", "SAO 46451"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.63648914),
        dec: Angle.Degrees(+44.75721323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156582"},
        {"Hipparcos Number", "HIP 84480"},
        {"Fundamental Katalog 5th Edition", "FK5 5523"},
        {"Geneva Identification System", "GEN# +1.00156582"},
        {"Smithsonian Astrophysical Observation", "SAO 46596"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.06467885),
        dec: Angle.Degrees(+44.76013601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106662",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106662"},
        {"Smithsonian Astrophysical Observation", "SAO 51088"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.05915257),
        dec: Angle.Degrees(+44.76250385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29882"},
        {"Hipparcos Number", "HIP 22054"},
        {"Fundamental Katalog 5th Edition", "FK5 4429"},
        {"Geneva Identification System", "GEN# +1.00029882"},
        {"Smithsonian Astrophysical Observation", "SAO 39716"},
        {"Wilson Evans Batten Catalogue", "WEB 4238"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.14601182),
        dec: Angle.Degrees(+44.76668669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102637",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102637"},
        {"Geneva Identification System", "GEN# +0.04403582"},
        {"Smithsonian Astrophysical Observation", "SAO 50069"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.95825871),
        dec: Angle.Degrees(+44.76690592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26686"},
        {"Hipparcos Number", "HIP 19843"},
        {"Smithsonian Astrophysical Observation", "SAO 39413"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.80865356),
        dec: Angle.Degrees(+44.76788056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181046"},
        {"Hipparcos Number", "HIP 94744"},
        {"Smithsonian Astrophysical Observation", "SAO 48274"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.959,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.18988423),
        dec: Angle.Degrees(+44.76889349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81995"},
        {"Hipparcos Number", "HIP 46642"},
        {"Geneva Identification System", "GEN# +1.00081995"},
        {"Smithsonian Astrophysical Observation", "SAO 42899"},
        {"Wilson Evans Batten Catalogue", "WEB 8799"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.65983304),
        dec: Angle.Degrees(+44.76947356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36755"},
        {"Hipparcos Number", "HIP 26316"},
        {"Smithsonian Astrophysical Observation", "SAO 40469"},
        {"Wilson Evans Batten Catalogue", "WEB 5177"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.07052845),
        dec: Angle.Degrees(+44.76996554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210942"},
        {"Hipparcos Number", "HIP 109660"},
        {"Geneva Identification System", "GEN# +1.00210942"},
        {"Smithsonian Astrophysical Observation", "SAO 51767"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.22253055),
        dec: Angle.Degrees(+44.77115825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112477",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16266 AB"},
        {"Henry Draper", "HD 215791"},
        {"Hipparcos Number", "HIP 112477"},
        {"Smithsonian Astrophysical Observation", "SAO 52360"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.74731518),
        dec: Angle.Degrees(+44.77295627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36819",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36819"},
        {"Smithsonian Astrophysical Observation", "SAO 41855"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.57910635),
        dec: Angle.Degrees(+44.77585282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38188"},
        {"Hipparcos Number", "HIP 27224"},
        {"Celescope Catalog", "CEL 962"},
        {"Geneva Identification System", "GEN# +1.00038188"},
        {"Smithsonian Astrophysical Observation", "SAO 40588"},
        {"Wilson Evans Batten Catalogue", "WEB 5352"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.54800764),
        dec: Angle.Degrees(+44.78326933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81459"},
        {"Hipparcos Number", "HIP 46356"},
        {"Geneva Identification System", "GEN# +1.00081459"},
        {"Smithsonian Astrophysical Observation", "SAO 42865"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.76885823),
        dec: Angle.Degrees(+44.78338818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -167.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200241"},
        {"Hipparcos Number", "HIP 103694"},
        {"Geneva Identification System", "GEN# +1.00200241"},
        {"Smithsonian Astrophysical Observation", "SAO 50349"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.18558528),
        dec: Angle.Degrees(+44.78532752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220949"},
        {"Hipparcos Number", "HIP 115808"},
        {"Geneva Identification System", "GEN# +1.00220949"},
        {"Smithsonian Astrophysical Observation", "SAO 53047"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.92343573),
        dec: Angle.Degrees(+44.78532805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127852"},
        {"Hipparcos Number", "HIP 71104"},
        {"Geneva Identification System", "GEN# +1.00127852"},
        {"Smithsonian Astrophysical Observation", "SAO 45097"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.10388928),
        dec: Angle.Degrees(+44.78533365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -158.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26088",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4137 AB"},
        {"Henry Draper", "HD 36422"},
        {"Hipparcos Number", "HIP 26088"},
        {"Smithsonian Astrophysical Observation", "SAO 40429"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.773,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.46210328),
        dec: Angle.Degrees(+44.78563235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8594"},
        {"Hipparcos Number", "HIP 6682"},
        {"Smithsonian Astrophysical Observation", "SAO 37196"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.42269821),
        dec: Angle.Degrees(+44.78657721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 140.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199799"},
        {"Hipparcos Number", "HIP 103476"},
        {"Geneva Identification System", "GEN# +1.00199799"},
        {"Smithsonian Astrophysical Observation", "SAO 50291"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.47161104),
        dec: Angle.Degrees(+44.78816980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186120"},
        {"Hipparcos Number", "HIP 96800"},
        {"Geneva Identification System", "GEN# +1.00186120"},
        {"Smithsonian Astrophysical Observation", "SAO 48715"},
        {"Wilson Evans Batten Catalogue", "WEB 16981"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.16127275),
        dec: Angle.Degrees(+44.78906673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200019"},
        {"Hipparcos Number", "HIP 103579"},
        {"Geneva Identification System", "GEN# +1.00200019"},
        {"Smithsonian Astrophysical Observation", "SAO 50318"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.79913166),
        dec: Angle.Degrees(+44.79044095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200527"},
        {"Hipparcos Number", "HIP 103828"},
        {"Geneva Identification System", "GEN# +1.00200527"},
        {"Smithsonian Astrophysical Observation", "SAO 50381"},
        {"Wilson Evans Batten Catalogue", "WEB 18904"},
    },
    visualMagnitude: 6.18,
    bvColour: 1.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.60085155),
        dec: Angle.Degrees(+44.79099018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60832",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8561 B"},
        {"Henry Draper", "HD 108575"},
        {"Hipparcos Number", "HIP 60832"},
        {"Geneva Identification System", "GEN# +1.00108575"},
        {"Smithsonian Astrophysical Observation", "SAO 44188"},
        {"Wilson Evans Batten Catalogue", "WEB 10825"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.02061250),
        dec: Angle.Degrees(+44.79180427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -178.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60831",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8561 A"},
        {"Henry Draper", "HD 108574"},
        {"Hipparcos Number", "HIP 60831"},
        {"Geneva Identification System", "GEN# +1.00108574"},
        {"Smithsonian Astrophysical Observation", "SAO 44187"},
        {"Wilson Evans Batten Catalogue", "WEB 10824"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.01914318),
        dec: Angle.Degrees(+44.79432132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -182.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6688"},
        {"Hipparcos Number", "HIP 5327"},
        {"Celescope Catalog", "CEL 119"},
        {"Geneva Identification System", "GEN# +1.00006688"},
        {"Smithsonian Astrophysical Observation", "SAO 36953"},
    },
    visualMagnitude: 7.46,
    bvColour: -0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.04397293),
        dec: Angle.Degrees(+44.79611256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48229",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48229"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.49632382),
        dec: Angle.Degrees(+44.79716901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57845",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8324 AB"},
        {"Henry Draper", "HD 103012"},
        {"Hipparcos Number", "HIP 57845"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.92980926),
        dec: Angle.Degrees(+44.79814228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22441"},
        {"Hipparcos Number", "HIP 16980"},
        {"Smithsonian Astrophysical Observation", "SAO 39007"},
        {"Wilson Evans Batten Catalogue", "WEB 3229"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.59444618),
        dec: Angle.Degrees(+44.80062003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63329",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63329"},
    },
    visualMagnitude: 10.29,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.67015769),
        dec: Angle.Degrees(+44.80066606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22428"},
        {"Hipparcos Number", "HIP 16972"},
        {"Smithsonian Astrophysical Observation", "SAO 39005"},
        {"Wilson Evans Batten Catalogue", "WEB 3228"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.57845789),
        dec: Angle.Degrees(+44.80181716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93471"},
        {"Hipparcos Number", "HIP 52831"},
        {"Geneva Identification System", "GEN# +1.00093471"},
        {"Smithsonian Astrophysical Observation", "SAO 43476"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.03182326),
        dec: Angle.Degrees(+44.80191848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22022"},
        {"Hipparcos Number", "HIP 16688"},
        {"Smithsonian Astrophysical Observation", "SAO 38959"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.67725080),
        dec: Angle.Degrees(+44.80313137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103895",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103895"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.77301575),
        dec: Angle.Degrees(+44.80460608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 287.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65556"},
        {"Hipparcos Number", "HIP 39208"},
        {"Geneva Identification System", "GEN# +1.00065556"},
        {"Smithsonian Astrophysical Observation", "SAO 42124"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.30423222),
        dec: Angle.Degrees(+44.80516558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21520",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21520"},
        {"Smithsonian Astrophysical Observation", "SAO 39645"},
        {"Wilson Evans Batten Catalogue", "WEB 4133"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.31665599),
        dec: Angle.Degrees(+44.80577081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80439"},
        {"Hipparcos Number", "HIP 45881"},
        {"Smithsonian Astrophysical Observation", "SAO 42819"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.33124873),
        dec: Angle.Degrees(+44.80603131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10694"},
        {"Hipparcos Number", "HIP 8204"},
        {"Fundamental Katalog 5th Edition", "FK5 4158"},
        {"Geneva Identification System", "GEN# +1.00010694"},
        {"Smithsonian Astrophysical Observation", "SAO 37484"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.37463948),
        dec: Angle.Degrees(+44.80637221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53104",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53104"},
        {"Smithsonian Astrophysical Observation", "SAO 43497"},
    },
    visualMagnitude: 9.95,
    bvColour: 1.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.96124768),
        dec: Angle.Degrees(+44.80829006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107256",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107256"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.86371389),
        dec: Angle.Degrees(+44.80906746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128749"},
        {"Hipparcos Number", "HIP 71499"},
        {"Geneva Identification System", "GEN# +1.00128749"},
        {"Smithsonian Astrophysical Observation", "SAO 45139"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.33178423),
        dec: Angle.Degrees(+44.80929802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68403",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68403"},
        {"Wilson Evans Batten Catalogue", "WEB 11994"},
    },
    visualMagnitude: 10.27,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.04646287),
        dec: Angle.Degrees(+44.81129351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -191.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96347",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96347"},
        {"Smithsonian Astrophysical Observation", "SAO 48616"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.83299690),
        dec: Angle.Degrees(+44.81187447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11336"},
        {"Hipparcos Number", "HIP 8747"},
        {"Renson", "Renson 2810"},
        {"Smithsonian Astrophysical Observation", "SAO 37578"},
        {"Wilson Evans Batten Catalogue", "WEB 1844"},
    },
    visualMagnitude: 7.71,
    bvColour: -0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.13910200),
        dec: Angle.Degrees(+44.81250738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105421",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105421"},
        {"Smithsonian Astrophysical Observation", "SAO 50744"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.29951041),
        dec: Angle.Degrees(+44.81276036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194057"},
        {"Hipparcos Number", "HIP 100409"},
        {"Geneva Identification System", "GEN# +1.00194057"},
        {"Smithsonian Astrophysical Observation", "SAO 49520"},
        {"Wilson Evans Batten Catalogue", "WEB 18127"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.729,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.41802431),
        dec: Angle.Degrees(+44.81423906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51831",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51831"},
        {"Smithsonian Astrophysical Observation", "SAO 43394"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.83884224),
        dec: Angle.Degrees(+44.81457201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3838"},
        {"Hipparcos Number", "HIP 3252"},
        {"Geneva Identification System", "GEN# +1.00003838"},
        {"Smithsonian Astrophysical Observation", "SAO 36576"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.36081766),
        dec: Angle.Degrees(+44.81461692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100127"},
        {"Hipparcos Number", "HIP 56230"},
        {"Geneva Identification System", "GEN# +1.00100127"},
        {"Smithsonian Astrophysical Observation", "SAO 43796"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.90520594),
        dec: Angle.Degrees(+44.81793105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78803"},
        {"Hipparcos Number", "HIP 45133"},
        {"Geneva Identification System", "GEN# +1.00078803"},
        {"Smithsonian Astrophysical Observation", "SAO 42735"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.94368527),
        dec: Angle.Degrees(+44.82411536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98880"},
        {"Hipparcos Number", "HIP 55565"},
        {"Geneva Identification System", "GEN# +1.00098880"},
        {"Renson", "Renson 28490"},
        {"Smithsonian Astrophysical Observation", "SAO 43720"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.71666239),
        dec: Angle.Degrees(+44.82451982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61058"},
        {"Hipparcos Number", "HIP 37301"},
        {"Smithsonian Astrophysical Observation", "SAO 41914"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.86987658),
        dec: Angle.Degrees(+44.82584275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81282",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81282"},
        {"Smithsonian Astrophysical Observation", "SAO 46182"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.02429535),
        dec: Angle.Degrees(+44.82683436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196144"},
        {"Hipparcos Number", "HIP 101470"},
        {"Smithsonian Astrophysical Observation", "SAO 49802"},
        {"Wilson Evans Batten Catalogue", "WEB 18336"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.46600821),
        dec: Angle.Degrees(+44.82844932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140138"},
        {"Hipparcos Number", "HIP 76745"},
        {"Geneva Identification System", "GEN# +1.00140138"},
        {"Smithsonian Astrophysical Observation", "SAO 45671"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.07378904),
        dec: Angle.Degrees(+44.83099633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162382"},
        {"Hipparcos Number", "HIP 87172"},
        {"Fundamental Katalog 5th Edition", "FK5 5564"},
        {"Geneva Identification System", "GEN# +1.00162382"},
        {"Smithsonian Astrophysical Observation", "SAO 46969"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.15516194),
        dec: Angle.Degrees(+44.83135293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21578"},
        {"Hipparcos Number", "HIP 16336"},
        {"Smithsonian Astrophysical Observation", "SAO 38896"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.64698699),
        dec: Angle.Degrees(+44.83305319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37997"},
        {"Hipparcos Number", "HIP 27095"},
        {"Smithsonian Astrophysical Observation", "SAO 40575"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.18256733),
        dec: Angle.Degrees(+44.83945963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49949"},
        {"Hipparcos Number", "HIP 33056"},
        {"Geneva Identification System", "GEN# +1.00049949"},
        {"Smithsonian Astrophysical Observation", "SAO 41406"},
        {"Wilson Evans Batten Catalogue", "WEB 6654"},
    },
    visualMagnitude: 6.24,
    bvColour: 0.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.28156090),
        dec: Angle.Degrees(+44.84008268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192601"},
        {"Hipparcos Number", "HIP 99698"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.791,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.46402861),
        dec: Angle.Degrees(+44.84044411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 172.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 84.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21771"},
        {"Henry Draper 2", "HD 21772"},
        {"Hipparcos Number", "HIP 16490"},
        {"Geneva Identification System", "GEN# +1.00021771"},
        {"Smithsonian Astrophysical Observation", "SAO 38923"},
        {"Wilson Evans Batten Catalogue", "WEB 3150"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.06843671),
        dec: Angle.Degrees(+44.84069992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93898",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12065 AB"},
        {"Henry Draper", "HD 178613"},
        {"Hipparcos Number", "HIP 93898"},
        {"Smithsonian Astrophysical Observation", "SAO 48104"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.80070205),
        dec: Angle.Degrees(+44.84172680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82353",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82353"},
        {"Smithsonian Astrophysical Observation", "SAO 46309"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.40052806),
        dec: Angle.Degrees(+44.84387450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109354",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15679 A"},
        {"Henry Draper", "HD 210405"},
        {"Hipparcos Number", "HIP 109354"},
        {"Geneva Identification System", "GEN# +1.00210405A"},
        {"Smithsonian Astrophysical Observation", "SAO 51698"},
        {"Wilson Evans Batten Catalogue", "WEB 19650"},
    },
    visualMagnitude: 6.73,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.31328315),
        dec: Angle.Degrees(+44.84647844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188629"},
        {"Hipparcos Number", "HIP 97936"},
        {"Smithsonian Astrophysical Observation", "SAO 48961"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.56134822),
        dec: Angle.Degrees(+44.84733864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92124"},
        {"Hipparcos Number", "HIP 52124"},
        {"Smithsonian Astrophysical Observation", "SAO 43417"},
        {"Wilson Evans Batten Catalogue", "WEB 9500"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.74534713),
        dec: Angle.Degrees(+44.84784559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37736"},
        {"Hipparcos Number", "HIP 26938"},
        {"Smithsonian Astrophysical Observation", "SAO 40552"},
        {"Wilson Evans Batten Catalogue", "WEB 5310"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.74933967),
        dec: Angle.Degrees(+44.85145772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65137"},
        {"Hipparcos Number", "HIP 39044"},
        {"Smithsonian Astrophysical Observation", "SAO 42104"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.82001858),
        dec: Angle.Degrees(+44.85157903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 81.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35978",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6044 AB"},
        {"Henry Draper", "HD 57790"},
        {"Hipparcos Number", "HIP 35978"},
        {"Smithsonian Astrophysical Observation", "SAO 41748"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.21758042),
        dec: Angle.Degrees(+44.85198125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109342",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15679 D"},
        {"Henry Draper", "HD 210387"},
        {"Hipparcos Number", "HIP 109342"},
        {"Geneva Identification System", "GEN# +1.00210387"},
        {"Smithsonian Astrophysical Observation", "SAO 51691"},
        {"Wilson Evans Batten Catalogue", "WEB 19648"},
    },
    visualMagnitude: 6.74,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.27178230),
        dec: Angle.Degrees(+44.85475545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21803"},
        {"Hipparcos Number", "HIP 16516"},
        {"Geneva Identification System", "GEN# +1.00021803"},
        {"Smithsonian Astrophysical Observation", "SAO 38927"},
        {"Wilson Evans Batten Catalogue", "WEB 3153"},
    },
    visualMagnitude: 6.42,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.16240380),
        dec: Angle.Degrees(+44.85577508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14668",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Misam"},
        {"Aitken", "ADS 2368 A"},
        {"Henry Draper", "HD 19476"},
        {"Hipparcos Number", "HIP 14668"},
        {"Geneva Identification System", "GEN# +1.00019476"},
        {"Smithsonian Astrophysical Observation", "SAO 38609"},
        {"Wilson Evans Batten Catalogue", "WEB 2846"},
    },
    visualMagnitude: 3.79,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.37345463),
        dec: Angle.Degrees(+44.85788896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 173.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -142.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104753"},
        {"Hipparcos Number", "HIP 58821"},
        {"Smithsonian Astrophysical Observation", "SAO 44016"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.96803641),
        dec: Angle.Degrees(+44.85888943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16430"},
        {"Hipparcos Number", "HIP 12398"},
        {"Smithsonian Astrophysical Observation", "SAO 38202"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.91128055),
        dec: Angle.Degrees(+44.86142019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4335"},
        {"Hipparcos Number", "HIP 3604"},
        {"Celescope Catalog", "CEL 88"},
        {"Geneva Identification System", "GEN# +1.00004335"},
        {"Renson", "Renson 1170"},
        {"Smithsonian Astrophysical Observation", "SAO 36640"},
        {"Wilson Evans Batten Catalogue", "WEB 641"},
    },
    visualMagnitude: 6.03,
    bvColour: -0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.54499561),
        dec: Angle.Degrees(+44.86150820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73759"},
        {"Hipparcos Number", "HIP 42666"},
        {"Geneva Identification System", "GEN# +1.00073759"},
        {"Smithsonian Astrophysical Observation", "SAO 42496"},
        {"Wilson Evans Batten Catalogue", "WEB 8238"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.44033561),
        dec: Angle.Degrees(+44.86324631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53129"},
        {"Hipparcos Number", "HIP 34257"},
        {"Smithsonian Astrophysical Observation", "SAO 41550"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.51364867),
        dec: Angle.Degrees(+44.86401720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22182",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22182"},
    },
    visualMagnitude: 11.55,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.58735870),
        dec: Angle.Degrees(+44.89037194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218740"},
        {"Hipparcos Number", "HIP 114374"},
        {"Smithsonian Astrophysical Observation", "SAO 52749"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.47820679),
        dec: Angle.Degrees(+44.86430816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223981"},
        {"Hipparcos Number", "HIP 117852"},
        {"Renson", "Renson 61375"},
        {"Smithsonian Astrophysical Observation", "SAO 53462"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.54741870),
        dec: Angle.Degrees(+44.86719397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134790"},
        {"Hipparcos Number", "HIP 74233"},
        {"Geneva Identification System", "GEN# +1.00134790"},
        {"Smithsonian Astrophysical Observation", "SAO 45408"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.55108040),
        dec: Angle.Degrees(+44.86963004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149043"},
        {"Hipparcos Number", "HIP 80812"},
        {"Smithsonian Astrophysical Observation", "SAO 46125"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.53265183),
        dec: Angle.Degrees(+44.87097371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204918"},
        {"Hipparcos Number", "HIP 106184"},
        {"Geneva Identification System", "GEN# +1.00204918"},
        {"Renson", "Renson 57080"},
        {"Smithsonian Astrophysical Observation", "SAO 50949"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.60764386),
        dec: Angle.Degrees(+44.87497899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77771"},
        {"Hipparcos Number", "HIP 44671"},
        {"Smithsonian Astrophysical Observation", "SAO 42689"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.55241550),
        dec: Angle.Degrees(+44.87617474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193551"},
        {"Hipparcos Number", "HIP 100163"},
        {"Geneva Identification System", "GEN# +1.00193551"},
        {"Smithsonian Astrophysical Observation", "SAO 49463"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.75866534),
        dec: Angle.Degrees(+44.87741382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99606"},
        {"Hipparcos Number", "HIP 55950"},
        {"Smithsonian Astrophysical Observation", "SAO 43751"},
    },
    visualMagnitude: 6.90,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.98707644),
        dec: Angle.Degrees(+44.87853551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45348",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45348"},
        {"Smithsonian Astrophysical Observation", "SAO 42761"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.61513139),
        dec: Angle.Degrees(+44.88012873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184482"},
        {"Hipparcos Number", "HIP 96125"},
        {"Smithsonian Astrophysical Observation", "SAO 48568"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.16828252),
        dec: Angle.Degrees(+44.88091906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61780",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61780"},
        {"Geneva Identification System", "GEN# +0.04502057"},
        {"Smithsonian Astrophysical Observation", "SAO 44272"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.93823596),
        dec: Angle.Degrees(+44.88201851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130988"},
        {"Hipparcos Number", "HIP 72520"},
        {"Geneva Identification System", "GEN# +1.00130988"},
        {"Smithsonian Astrophysical Observation", "SAO 45229"},
        {"Wilson Evans Batten Catalogue", "WEB 12467"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.40843972),
        dec: Angle.Degrees(+44.88212630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23082"},
        {"Hipparcos Number", "HIP 17434"},
        {"Fundamental Katalog 5th Edition", "FK5 4340"},
        {"Geneva Identification System", "GEN# +1.00023082"},
        {"Smithsonian Astrophysical Observation", "SAO 39066"},
        {"Wilson Evans Batten Catalogue", "WEB 3299"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.02403089),
        dec: Angle.Degrees(+44.88471439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16463"},
        {"Hipparcos Number", "HIP 12427"},
        {"Geneva Identification System", "GEN# +1.00016463"},
        {"Smithsonian Astrophysical Observation", "SAO 38206"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.846,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.98629426),
        dec: Angle.Degrees(+44.88520273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89810",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11269 A"},
        {"Henry Draper", "HD 168850"},
        {"Hipparcos Number", "HIP 89810"},
        {"Geneva Identification System", "GEN# +1.00168850"},
        {"Smithsonian Astrophysical Observation", "SAO 47393"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.92589871),
        dec: Angle.Degrees(+44.88810786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173666"},
        {"Hipparcos Number", "HIP 91927"},
        {"Geneva Identification System", "GEN# +1.00173666"},
        {"Smithsonian Astrophysical Observation", "SAO 47750"},
        {"Wilson Evans Batten Catalogue", "WEB 15832"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.09735075),
        dec: Angle.Degrees(+44.88994230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222717"},
        {"Hipparcos Number", "HIP 116983"},
        {"Geneva Identification System", "GEN# +1.00222717"},
        {"Smithsonian Astrophysical Observation", "SAO 53307"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.73093122),
        dec: Angle.Degrees(+44.89339814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45349"},
        {"Hipparcos Number", "HIP 30902"},
        {"Smithsonian Astrophysical Observation", "SAO 41124"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.29690762),
        dec: Angle.Degrees(+44.89411274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17689"},
        {"Hipparcos Number", "HIP 13360"},
        {"Smithsonian Astrophysical Observation", "SAO 38400"},
    },
    visualMagnitude: 6.56,
    bvColour: 1.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.97031647),
        dec: Angle.Degrees(+44.89423892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100019",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100019"},
        {"Smithsonian Astrophysical Observation", "SAO 49430"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.38155570),
        dec: Angle.Degrees(+44.89519454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118218",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118218"},
        {"Smithsonian Astrophysical Observation", "SAO 53543"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.69973715),
        dec: Angle.Degrees(+44.89594513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75555"},
        {"Hipparcos Number", "HIP 43567"},
        {"Geneva Identification System", "GEN# +1.00075555"},
        {"Smithsonian Astrophysical Observation", "SAO 42582"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.09091996),
        dec: Angle.Degrees(+44.89769082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61540",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61540"},
        {"Geneva Identification System", "GEN# +0.04502052"},
        {"Smithsonian Astrophysical Observation", "SAO 44247"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.12494361),
        dec: Angle.Degrees(+44.89950698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18669",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2912 AB"},
        {"Henry Draper", "HD 24943"},
        {"Hipparcos Number", "HIP 18669"},
        {"Smithsonian Astrophysical Observation", "SAO 39233"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.96887008),
        dec: Angle.Degrees(+44.89980266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54512",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54512"},
    },
    visualMagnitude: 10.41,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.30073116),
        dec: Angle.Degrees(+44.90043420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62038",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62038"},
    },
    visualMagnitude: 11.87,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.74677227),
        dec: Angle.Degrees(+44.90167473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -184.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7647"},
        {"Hipparcos Number", "HIP 5993"},
        {"Geneva Identification System", "GEN# +1.00007647"},
        {"Smithsonian Astrophysical Observation", "SAO 37077"},
        {"Wilson Evans Batten Catalogue", "WEB 1359"},
    },
    visualMagnitude: 6.11,
    bvColour: 1.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.27105871),
        dec: Angle.Degrees(+44.90209025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110870"},
        {"Hipparcos Number", "HIP 62197"},
        {"Smithsonian Astrophysical Observation", "SAO 44313"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.21961403),
        dec: Angle.Degrees(+44.90254711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28596"},
        {"Hipparcos Number", "HIP 21189"},
        {"Celescope Catalog", "CEL 425"},
        {"Geneva Identification System", "GEN# +1.00028596"},
        {"Smithsonian Astrophysical Observation", "SAO 39592"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.13645584),
        dec: Angle.Degrees(+44.90254811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8728",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8728"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.06478211),
        dec: Angle.Degrees(+44.90512047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 81.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42554",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42554"},
        {"Smithsonian Astrophysical Observation", "SAO 42480"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.10953058),
        dec: Angle.Degrees(+44.90521179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64283",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64283"},
        {"Geneva Identification System", "GEN# +0.04502090"},
        {"Smithsonian Astrophysical Observation", "SAO 44496"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.61739732),
        dec: Angle.Degrees(+44.90570799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139116"},
        {"Hipparcos Number", "HIP 76262"},
        {"Smithsonian Astrophysical Observation", "SAO 45617"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.66020512),
        dec: Angle.Degrees(+44.90703317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87377",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10849 AB"},
        {"Henry Draper", "HD 162880"},
        {"Hipparcos Number", "HIP 87377"},
        {"Smithsonian Astrophysical Observation", "SAO 47012"},
        {"Wilson Evans Batten Catalogue", "WEB 14741"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.79273259),
        dec: Angle.Degrees(+44.90771597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66185",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66185"},
        {"Geneva Identification System", "GEN# +0.04502118"},
    },
    visualMagnitude: 9.70,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.47642592),
        dec: Angle.Degrees(+44.90773511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48987",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48987"},
        {"Smithsonian Astrophysical Observation", "SAO 43129"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.91894458),
        dec: Angle.Degrees(+44.91024551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196604"},
        {"Hipparcos Number", "HIP 101703"},
        {"Geneva Identification System", "GEN# +1.00196604"},
        {"Renson", "Renson 54830"},
        {"Smithsonian Astrophysical Observation", "SAO 49857"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.21190911),
        dec: Angle.Degrees(+44.91116614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139101"},
        {"Hipparcos Number", "HIP 76255"},
        {"Smithsonian Astrophysical Observation", "SAO 45615"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.853,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.64395561),
        dec: Angle.Degrees(+44.91433927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
