using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_59() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202867"},
        {"Hipparcos Number", "HIP 105218"},
        {"Geneva Identification System", "GEN# +1.00202867"},
        {"Smithsonian Astrophysical Observation", "SAO 145287"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.68884388),
        dec: Angle.Degrees(-02.13684001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31858"},
        {"Hipparcos Number", "HIP 23173"},
        {"Geneva Identification System", "GEN# +1.00031858"},
        {"Smithsonian Astrophysical Observation", "SAO 131657"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.77438067),
        dec: Angle.Degrees(-02.13665869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39337",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39337"},
    },
    visualMagnitude: 9.14,
    bvColour: 2.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.62072765),
        dec: Angle.Degrees(-02.13564953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33345"},
        {"Hipparcos Number", "HIP 23995"},
        {"Geneva Identification System", "GEN# +1.00033345"},
        {"Smithsonian Astrophysical Observation", "SAO 131829"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.37394049),
        dec: Angle.Degrees(-02.13504160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195716"},
        {"Hipparcos Number", "HIP 101406"},
        {"Fundamental Katalog 5th Edition", "FK5 5810"},
        {"Smithsonian Astrophysical Observation", "SAO 144558"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.26416932),
        dec: Angle.Degrees(-02.13273541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94402"},
        {"Hipparcos Number", "HIP 53273"},
        {"Geneva Identification System", "GEN# +1.00094402"},
        {"Smithsonian Astrophysical Observation", "SAO 137871"},
        {"Wilson Evans Batten Catalogue", "WEB 9675"},
    },
    visualMagnitude: 5.45,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.43233719),
        dec: Angle.Degrees(-02.12924149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165609"},
        {"Hipparcos Number", "HIP 88741"},
        {"Smithsonian Astrophysical Observation", "SAO 142095"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.74210805),
        dec: Angle.Degrees(-02.12816183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100895",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13868 B"},
        {"Henry Draper", "HD 194766"},
        {"Hipparcos Number", "HIP 100895"},
        {"Geneva Identification System", "GEN# +1.00194766"},
        {"Smithsonian Astrophysical Observation", "SAO 144449"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.86237260),
        dec: Angle.Degrees(-02.11935082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150654"},
        {"Hipparcos Number", "HIP 81809"},
        {"Smithsonian Astrophysical Observation", "SAO 141324"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.64044301),
        dec: Angle.Degrees(-02.11499929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7396"},
        {"Hipparcos Number", "HIP 5771"},
        {"Smithsonian Astrophysical Observation", "SAO 129189"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.51986869),
        dec: Angle.Degrees(-02.11427685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131715"},
        {"Hipparcos Number", "HIP 73010"},
        {"Smithsonian Astrophysical Observation", "SAO 140224"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.81749338),
        dec: Angle.Degrees(-02.11406093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224679"},
        {"Hipparcos Number", "HIP 118312"},
        {"Geneva Identification System", "GEN# +1.00224679"},
        {"Smithsonian Astrophysical Observation", "SAO 147019"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.95443374),
        dec: Angle.Degrees(-02.11255241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69031",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69031"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.97018176),
        dec: Angle.Degrees(-02.11253632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14986"},
        {"Hipparcos Number", "HIP 11257"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.22402542),
        dec: Angle.Degrees(-02.11203485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96007",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12538 AB"},
        {"Henry Draper", "HD 183794"},
        {"Hipparcos Number", "HIP 96007"},
        {"Geneva Identification System", "GEN# +1.00183794"},
        {"Smithsonian Astrophysical Observation", "SAO 143494"},
        {"Wilson Evans Batten Catalogue", "WEB 16817"},
    },
    visualMagnitude: 7.09,
    bvColour: -0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.81576619),
        dec: Angle.Degrees(-02.11020565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53169",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53169"},
        {"Geneva Identification System", "GEN# -0.00102457"},
        {"Wilson Evans Batten Catalogue", "WEB 9656"},
    },
    visualMagnitude: 9.79,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.15212891),
        dec: Angle.Degrees(-02.10918139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -402.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -768.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83889",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83889"},
        {"Smithsonian Astrophysical Observation", "SAO 141533"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.18351923),
        dec: Angle.Degrees(-02.10857283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65397",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65397"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.05417751),
        dec: Angle.Degrees(-02.10826915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116532"},
        {"Hipparcos Number", "HIP 65399"},
        {"Geneva Identification System", "GEN# +1.00116532"},
        {"Smithsonian Astrophysical Observation", "SAO 139317"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.06107084),
        dec: Angle.Degrees(-02.10734001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96005",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12538 C"},
        {"Hipparcos Number", "HIP 96005"},
        {"Geneva Identification System", "GEN# +1.00183794C"},
    },
    visualMagnitude: 10.27,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)31, 14.3200),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)06, 24.800)
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
    primaryId: "HIP 114202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218383"},
        {"Hipparcos Number", "HIP 114202"},
        {"Smithsonian Astrophysical Observation", "SAO 146519"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.91888837),
        dec: Angle.Degrees(-02.10539636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100896",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13868 A"},
        {"Henry Draper", "HD 194765"},
        {"Hipparcos Number", "HIP 100896"},
        {"Geneva Identification System", "GEN# +1.00194765A"},
        {"Smithsonian Astrophysical Observation", "SAO 144450"},
        {"Wilson Evans Batten Catalogue", "WEB 18228"},
    },
    visualMagnitude: 6.71,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.86484323),
        dec: Angle.Degrees(-02.10290922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53238"},
        {"Hipparcos Number", "HIP 34100"},
        {"Smithsonian Astrophysical Observation", "SAO 134136"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.05971705),
        dec: Angle.Degrees(-02.10147215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9155",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1567 C"},
        {"Henry Draper", "HD 12021"},
        {"Hipparcos Number", "HIP 9155"},
        {"Geneva Identification System", "GEN# +1.00012021"},
        {"Smithsonian Astrophysical Observation", "SAO 129586"},
    },
    visualMagnitude: 8.89,
    bvColour: -0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.48391080),
        dec: Angle.Degrees(-02.09936317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40429"},
        {"Hipparcos Number", "HIP 28285"},
        {"Geneva Identification System", "GEN# +1.00040429"},
        {"Smithsonian Astrophysical Observation", "SAO 132708"},
    },
    visualMagnitude: 8.50,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.65023766),
        dec: Angle.Degrees(-02.09930734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25870",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4127 AB"},
        {"Henry Draper", "HD 36394"},
        {"Hipparcos Number", "HIP 25870"},
        {"Geneva Identification System", "GEN# +1.00036394J"},
        {"Smithsonian Astrophysical Observation", "SAO 132208"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.83836417),
        dec: Angle.Degrees(-02.09919920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125436"},
        {"Hipparcos Number", "HIP 69997"},
        {"Geneva Identification System", "GEN# +1.00125436"},
        {"Smithsonian Astrophysical Observation", "SAO 139864"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.85186243),
        dec: Angle.Degrees(-02.09840916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -109.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105427"},
        {"Hipparcos Number", "HIP 59191"},
        {"Geneva Identification System", "GEN# +1.00105427"},
        {"Smithsonian Astrophysical Observation", "SAO 138603"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.07954730),
        dec: Angle.Degrees(-02.09040281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55923"},
        {"Hipparcos Number", "HIP 35055"},
        {"Smithsonian Astrophysical Observation", "SAO 134406"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.73956706),
        dec: Angle.Degrees(-02.08959871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118580"},
        {"Hipparcos Number", "HIP 66499"},
        {"Smithsonian Astrophysical Observation", "SAO 139451"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.47171050),
        dec: Angle.Degrees(-02.08931008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18975"},
        {"Hipparcos Number", "HIP 14194"},
        {"Smithsonian Astrophysical Observation", "SAO 130256"},
        {"Wilson Evans Batten Catalogue", "WEB 2787"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.75719819),
        dec: Angle.Degrees(-02.08649510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 106.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62380",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62380"},
    },
    visualMagnitude: 10.79,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.76522750),
        dec: Angle.Degrees(-02.08533940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122230"},
        {"Hipparcos Number", "HIP 68440"},
        {"Fundamental Katalog 5th Edition", "FK5 5243"},
        {"Geneva Identification System", "GEN# +1.00122230"},
        {"Smithsonian Astrophysical Observation", "SAO 139673"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.16905798),
        dec: Angle.Degrees(-02.08285313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29082"},
        {"Hipparcos Number", "HIP 21316"},
        {"Celescope Catalog", "CEL 434"},
        {"Geneva Identification System", "GEN# +1.00029082"},
        {"Smithsonian Astrophysical Observation", "SAO 131322"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.64630229),
        dec: Angle.Degrees(-02.08273587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112739"},
        {"Hipparcos Number", "HIP 63361"},
        {"Geneva Identification System", "GEN# +1.00112739"},
        {"Smithsonian Astrophysical Observation", "SAO 139080"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.74790135),
        dec: Angle.Degrees(-02.08144854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212813"},
        {"Hipparcos Number", "HIP 110820"},
        {"Smithsonian Astrophysical Observation", "SAO 146091"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.77762834),
        dec: Angle.Degrees(-02.08069102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40750",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40750"},
        {"Smithsonian Astrophysical Observation", "SAO 135768"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.762,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.78082056),
        dec: Angle.Degrees(-02.08010320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147550"},
        {"Hipparcos Number", "HIP 80227"},
        {"Geneva Identification System", "GEN# +1.00147550"},
        {"Renson", "Renson 41660"},
        {"Smithsonian Astrophysical Observation", "SAO 141129"},
        {"Wilson Evans Batten Catalogue", "WEB 13580"},
    },
    visualMagnitude: 6.24,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.66212496),
        dec: Angle.Degrees(-02.07985224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39857",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39857"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.829,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.14135951),
        dec: Angle.Degrees(-02.07924567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23262"},
        {"Hipparcos Number", "HIP 17396"},
        {"Smithsonian Astrophysical Observation", "SAO 130687"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.90137213),
        dec: Angle.Degrees(-02.07783788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 665"},
        {"Hipparcos Number", "HIP 892"},
        {"Smithsonian Astrophysical Observation", "SAO 128626"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.73712261),
        dec: Angle.Degrees(-02.07451183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16567"},
        {"Hipparcos Number", "HIP 12377"},
        {"Geneva Identification System", "GEN# +1.00016567"},
        {"Smithsonian Astrophysical Observation", "SAO 130039"},
    },
    visualMagnitude: 7.84,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.83178127),
        dec: Angle.Degrees(-02.07277297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20683"},
        {"Hipparcos Number", "HIP 15500"},
        {"Smithsonian Astrophysical Observation", "SAO 130422"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.93484634),
        dec: Angle.Degrees(-02.07153313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75538",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75538"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.48198266),
        dec: Angle.Degrees(-02.07129541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 169.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -160.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30320"},
        {"Hipparcos Number", "HIP 22200"},
        {"Smithsonian Astrophysical Observation", "SAO 131483"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.61690097),
        dec: Angle.Degrees(-02.07077133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23223"},
        {"Hipparcos Number", "HIP 17383"},
        {"Geneva Identification System", "GEN# +1.00023223"},
        {"Smithsonian Astrophysical Observation", "SAO 130685"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.84328793),
        dec: Angle.Degrees(-02.06948021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41166"},
        {"Hipparcos Number", "HIP 28668"},
        {"Smithsonian Astrophysical Observation", "SAO 132776"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.79270542),
        dec: Angle.Degrees(-02.06947691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99916",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99916"},
    },
    visualMagnitude: 11.16,
    bvColour: 1.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.09098707),
        dec: Angle.Degrees(-02.06886921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 290.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96720"},
        {"Hipparcos Number", "HIP 54455"},
        {"Geneva Identification System", "GEN# +1.00096720"},
        {"Smithsonian Astrophysical Observation", "SAO 138006"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.12246826),
        dec: Angle.Degrees(-02.06816659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31919"},
        {"Hipparcos Number", "HIP 23194"},
        {"Geneva Identification System", "GEN# +1.00031919"},
        {"Smithsonian Astrophysical Observation", "SAO 131662"},
    },
    visualMagnitude: 8.92,
    bvColour: -0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.87163966),
        dec: Angle.Degrees(-02.06655126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138370"},
        {"Hipparcos Number", "HIP 76046"},
        {"Geneva Identification System", "GEN# +1.00138370"},
        {"Smithsonian Astrophysical Observation", "SAO 140585"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.95403126),
        dec: Angle.Degrees(-02.06637014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3231"},
        {"Hipparcos Number", "HIP 2786"},
        {"Smithsonian Astrophysical Observation", "SAO 128845"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.831,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.88589662),
        dec: Angle.Degrees(-02.06618283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 157.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32115"},
        {"Hipparcos Number", "HIP 23296"},
        {"Geneva Identification System", "GEN# +1.00032115"},
        {"Smithsonian Astrophysical Observation", "SAO 131684"},
    },
    visualMagnitude: 6.31,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.16589851),
        dec: Angle.Degrees(-02.06602481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192897"},
        {"Hipparcos Number", "HIP 100012"},
        {"Geneva Identification System", "GEN# +1.00192897"},
        {"Smithsonian Astrophysical Observation", "SAO 144253"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.861,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.35322984),
        dec: Angle.Degrees(-02.06318883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11272"},
        {"Hipparcos Number", "HIP 8580"},
        {"Smithsonian Astrophysical Observation", "SAO 129529"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.65687422),
        dec: Angle.Degrees(-02.06226306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114618",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114618"},
        {"Smithsonian Astrophysical Observation", "SAO 146567"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.30210307),
        dec: Angle.Degrees(-02.06222700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212417"},
        {"Hipparcos Number", "HIP 110582"},
        {"Smithsonian Astrophysical Observation", "SAO 146068"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.04338619),
        dec: Angle.Degrees(-02.06191179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203129"},
        {"Hipparcos Number", "HIP 105359"},
        {"Smithsonian Astrophysical Observation", "SAO 145306"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.712,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.10788303),
        dec: Angle.Degrees(-02.06132432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -263.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182623"},
        {"Hipparcos Number", "HIP 95511"},
        {"Geneva Identification System", "GEN# +1.00182623"},
        {"Smithsonian Astrophysical Observation", "SAO 143386"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.40872719),
        dec: Angle.Degrees(-02.06113144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6787"},
        {"Hipparcos Number", "HIP 5360"},
        {"Smithsonian Astrophysical Observation", "SAO 129141"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.13358347),
        dec: Angle.Degrees(-02.05990467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9165",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1567 A"},
        {"Henry Draper", "HD 12020"},
        {"Hipparcos Number", "HIP 9165"},
        {"Fundamental Katalog 5th Edition", "FK5 4177"},
        {"Smithsonian Astrophysical Observation", "SAO 129588"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.49745159),
        dec: Angle.Degrees(-02.05950108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20963"},
        {"Hipparcos Number", "HIP 15743"},
        {"Smithsonian Astrophysical Observation", "SAO 130452"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.71332023),
        dec: Angle.Degrees(-02.05911934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211126"},
        {"Hipparcos Number", "HIP 109860"},
        {"Smithsonian Astrophysical Observation", "SAO 145971"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.76336988),
        dec: Angle.Degrees(-02.05905447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40743"},
        {"Hipparcos Number", "HIP 28476"},
        {"Smithsonian Astrophysical Observation", "SAO 132743"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.18039633),
        dec: Angle.Degrees(-02.05871061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44176"},
        {"Hipparcos Number", "HIP 30118"},
        {"Celescope Catalog", "CEL 1184"},
        {"Geneva Identification System", "GEN# +1.00044176"},
        {"Smithsonian Astrophysical Observation", "SAO 133125"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.06779225),
        dec: Angle.Degrees(-02.05460124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12666"},
        {"Hipparcos Number", "HIP 9645"},
        {"Smithsonian Astrophysical Observation", "SAO 129671"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.99371542),
        dec: Angle.Degrees(-02.05446094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74327",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74327"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.87434011),
        dec: Angle.Degrees(-02.05434557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91786"},
        {"Hipparcos Number", "HIP 51872"},
        {"Smithsonian Astrophysical Observation", "SAO 137663"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.96761889),
        dec: Angle.Degrees(-02.05293814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112601"},
        {"Hipparcos Number", "HIP 63269"},
        {"Smithsonian Astrophysical Observation", "SAO 139068"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.47558464),
        dec: Angle.Degrees(-02.05293027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201120"},
        {"Hipparcos Number", "HIP 104293"},
        {"Smithsonian Astrophysical Observation", "SAO 145126"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.92669974),
        dec: Angle.Degrees(-02.05222029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73230"},
        {"Hipparcos Number", "HIP 42280"},
        {"Smithsonian Astrophysical Observation", "SAO 136098"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.31229495),
        dec: Angle.Degrees(-02.05198968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196125"},
        {"Hipparcos Number", "HIP 101598"},
        {"Geneva Identification System", "GEN# +1.00196125"},
        {"Smithsonian Astrophysical Observation", "SAO 144607"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.86219688),
        dec: Angle.Degrees(-02.05155752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25036",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3944 AB"},
        {"Henry Draper", "HD 35019"},
        {"Hipparcos Number", "HIP 25036"},
        {"Smithsonian Astrophysical Observation", "SAO 132026"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.41626724),
        dec: Angle.Degrees(-02.05130153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92185"},
        {"Hipparcos Number", "HIP 52080"},
        {"Geneva Identification System", "GEN# +1.00092185"},
        {"Smithsonian Astrophysical Observation", "SAO 137698"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.63385328),
        dec: Angle.Degrees(-02.05064450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74794"},
        {"Hipparcos Number", "HIP 43026"},
        {"Geneva Identification System", "GEN# +1.00074794"},
        {"Smithsonian Astrophysical Observation", "SAO 136254"},
        {"Wilson Evans Batten Catalogue", "WEB 8311"},
    },
    visualMagnitude: 5.70,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.51021822),
        dec: Angle.Degrees(-02.04876829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152986"},
        {"Hipparcos Number", "HIP 82935"},
        {"Geneva Identification System", "GEN# +1.00152986"},
        {"Smithsonian Astrophysical Observation", "SAO 141451"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.22368947),
        dec: Angle.Degrees(-02.04871417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218953"},
        {"Hipparcos Number", "HIP 114551"},
        {"Smithsonian Astrophysical Observation", "SAO 146560"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.05393051),
        dec: Angle.Degrees(-02.04688820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215057"},
        {"Hipparcos Number", "HIP 112115"},
        {"Smithsonian Astrophysical Observation", "SAO 146258"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.64994887),
        dec: Angle.Degrees(-02.04489291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171290"},
        {"Hipparcos Number", "HIP 91028"},
        {"Geneva Identification System", "GEN# +1.00171290"},
        {"Smithsonian Astrophysical Observation", "SAO 142392"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.53944569),
        dec: Angle.Degrees(-02.04454940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129231"},
        {"Hipparcos Number", "HIP 71820"},
        {"Smithsonian Astrophysical Observation", "SAO 140074"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.37599319),
        dec: Angle.Degrees(-02.04103379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14204"},
        {"Hipparcos Number", "HIP 10705"},
        {"Smithsonian Astrophysical Observation", "SAO 129802"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.44642860),
        dec: Angle.Degrees(-02.04029526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107136"},
        {"Hipparcos Number", "HIP 60077"},
        {"Smithsonian Astrophysical Observation", "SAO 138713"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.78118225),
        dec: Angle.Degrees(-02.04026314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85220"},
        {"Hipparcos Number", "HIP 48268"},
        {"Smithsonian Astrophysical Observation", "SAO 137175"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.60239481),
        dec: Angle.Degrees(-02.03874885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102084"},
        {"Hipparcos Number", "HIP 57295"},
        {"Smithsonian Astrophysical Observation", "SAO 138387"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.21738679),
        dec: Angle.Degrees(-02.03839137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12765"},
        {"Hipparcos Number", "HIP 9722"},
        {"Smithsonian Astrophysical Observation", "SAO 129679"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.26506376),
        dec: Angle.Degrees(-02.03836716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42131"},
        {"Hipparcos Number", "HIP 29149"},
        {"Geneva Identification System", "GEN# +1.00042131"},
        {"Smithsonian Astrophysical Observation", "SAO 132885"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.23619453),
        dec: Angle.Degrees(-02.03699828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37104",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6226 A"},
        {"Henry Draper", "HD 61095"},
        {"Hipparcos Number", "HIP 37104"},
        {"Fundamental Katalog 5th Edition", "FK5 4683"},
        {"Smithsonian Astrophysical Observation", "SAO 134902"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.37079186),
        dec: Angle.Degrees(-02.03684041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173553"},
        {"Hipparcos Number", "HIP 92091"},
        {"Smithsonian Astrophysical Observation", "SAO 142601"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.52432764),
        dec: Angle.Degrees(-02.03653970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8943"},
        {"Hipparcos Number", "HIP 6840"},
        {"Geneva Identification System", "GEN# +1.00008943"},
        {"Smithsonian Astrophysical Observation", "SAO 129315"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.00466431),
        dec: Angle.Degrees(-02.03528433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151842"},
        {"Hipparcos Number", "HIP 82382"},
        {"Geneva Identification System", "GEN# +1.00151842"},
        {"Smithsonian Astrophysical Observation", "SAO 141389"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.51317981),
        dec: Angle.Degrees(-02.03500371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40373"},
        {"Hipparcos Number", "HIP 28248"},
        {"Geneva Identification System", "GEN# +1.00040373"},
        {"Smithsonian Astrophysical Observation", "SAO 132701"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.54482056),
        dec: Angle.Degrees(-02.03481835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164376"},
        {"Hipparcos Number", "HIP 88223"},
        {"Smithsonian Astrophysical Observation", "SAO 142035"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.24482477),
        dec: Angle.Degrees(-02.03477133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183736"},
        {"Hipparcos Number", "HIP 95976"},
        {"Smithsonian Astrophysical Observation", "SAO 143489"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.877,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.74978867),
        dec: Angle.Degrees(-02.03473052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202278"},
        {"Hipparcos Number", "HIP 104893"},
        {"Geneva Identification System", "GEN# +1.00202278"},
        {"Smithsonian Astrophysical Observation", "SAO 145233"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.71051018),
        dec: Angle.Degrees(-02.03472401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60086"},
        {"Hipparcos Number", "HIP 36687"},
        {"Geneva Identification System", "GEN# +1.00060086"},
        {"Renson", "Renson 16410"},
        {"Smithsonian Astrophysical Observation", "SAO 134820"},
    },
    visualMagnitude: 6.82,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.20568960),
        dec: Angle.Degrees(-02.03434617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9671"},
        {"Hipparcos Number", "HIP 7354"},
        {"Geneva Identification System", "GEN# +1.00009671"},
        {"Smithsonian Astrophysical Observation", "SAO 129384"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.69429689),
        dec: Angle.Degrees(-02.03359617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168043"},
        {"Hipparcos Number", "HIP 89675"},
        {"Geneva Identification System", "GEN# +1.00168043"},
        {"Smithsonian Astrophysical Observation", "SAO 142204"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.50544376),
        dec: Angle.Degrees(-02.03327408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206581"},
        {"Hipparcos Number", "HIP 107229"},
        {"Smithsonian Astrophysical Observation", "SAO 145615"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.76488459),
        dec: Angle.Degrees(-02.03299356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169453"},
        {"Hipparcos Number", "HIP 90251"},
        {"Smithsonian Astrophysical Observation", "SAO 142293"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.22091946),
        dec: Angle.Degrees(-02.03111364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44501"},
        {"Hipparcos Number", "HIP 30266"},
        {"Smithsonian Astrophysical Observation", "SAO 133160"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.50517806),
        dec: Angle.Degrees(-02.02933779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85319"},
        {"Hipparcos Number", "HIP 48316"},
        {"Geneva Identification System", "GEN# +1.00085319"},
        {"Wilson Evans Batten Catalogue", "WEB 9011"},
    },
    visualMagnitude: 8.90,
    bvColour: 2.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.74271996),
        dec: Angle.Degrees(-02.02866264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148942"},
        {"Hipparcos Number", "HIP 80952"},
        {"Geneva Identification System", "GEN# +1.00148942"},
        {"Smithsonian Astrophysical Observation", "SAO 141225"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.94164350),
        dec: Angle.Degrees(-02.02537847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13486"},
        {"Hipparcos Number", "HIP 10237"},
        {"Smithsonian Astrophysical Observation", "SAO 129740"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.90666842),
        dec: Angle.Degrees(-02.02373756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197141"},
        {"Hipparcos Number", "HIP 102139"},
        {"Smithsonian Astrophysical Observation", "SAO 144717"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.45977633),
        dec: Angle.Degrees(-02.02185261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210314"},
        {"Hipparcos Number", "HIP 109382"},
        {"Smithsonian Astrophysical Observation", "SAO 145908"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.39783758),
        dec: Angle.Degrees(-02.02107962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182975"},
        {"Hipparcos Number", "HIP 95651"},
        {"Geneva Identification System", "GEN# +1.00182975"},
        {"Smithsonian Astrophysical Observation", "SAO 143416"},
        {"Wilson Evans Batten Catalogue", "WEB 16729"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.84512863),
        dec: Angle.Degrees(-02.02060682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173706"},
        {"Hipparcos Number", "HIP 92144"},
        {"Smithsonian Astrophysical Observation", "SAO 142611"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.69916891),
        dec: Angle.Degrees(-02.02039509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15823"},
        {"Hipparcos Number", "HIP 11826"},
        {"Geneva Identification System", "GEN# +1.00015823"},
        {"Smithsonian Astrophysical Observation", "SAO 129967"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.15655766),
        dec: Angle.Degrees(-02.01999242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4676",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 825 A"},
        {"Henry Draper", "HD 5861"},
        {"Hipparcos Number", "HIP 4676"},
        {"Smithsonian Astrophysical Observation", "SAO 129072"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.01520387),
        dec: Angle.Degrees(-02.01891577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115595",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115595"},
        {"Smithsonian Astrophysical Observation", "SAO 146695"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.22921065),
        dec: Angle.Degrees(-02.01844800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2794"},
        {"Hipparcos Number", "HIP 2471"},
        {"Smithsonian Astrophysical Observation", "SAO 128804"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.84983474),
        dec: Angle.Degrees(-02.01737471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206172"},
        {"Hipparcos Number", "HIP 107020"},
        {"Geneva Identification System", "GEN# +1.00206172"},
        {"Smithsonian Astrophysical Observation", "SAO 145579"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.11512132),
        dec: Angle.Degrees(-02.01730821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 221.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137857"},
        {"Hipparcos Number", "HIP 75747"},
        {"Smithsonian Astrophysical Observation", "SAO 140558"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.11850745),
        dec: Angle.Degrees(-02.01575490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205899"},
        {"Hipparcos Number", "HIP 106857"},
        {"Smithsonian Astrophysical Observation", "SAO 145552"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.63309569),
        dec: Angle.Degrees(-02.01517436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1421"},
        {"Hipparcos Number", "HIP 1470"},
        {"Geneva Identification System", "GEN# +1.00001421"},
        {"Smithsonian Astrophysical Observation", "SAO 128688"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.57707885),
        dec: Angle.Degrees(-02.01479919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105883"},
        {"Hipparcos Number", "HIP 59412"},
        {"Smithsonian Astrophysical Observation", "SAO 138635"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.81216610),
        dec: Angle.Degrees(-02.01386569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -147.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193640"},
        {"Hipparcos Number", "HIP 100375"},
        {"Smithsonian Astrophysical Observation", "SAO 144332"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.35052568),
        dec: Angle.Degrees(-02.01314005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73955"},
        {"Hipparcos Number", "HIP 42612"},
        {"Geneva Identification System", "GEN# +1.00073955"},
        {"Smithsonian Astrophysical Observation", "SAO 136175"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.26862174),
        dec: Angle.Degrees(-02.01252371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -176.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132974"},
        {"Hipparcos Number", "HIP 73570"},
        {"Smithsonian Astrophysical Observation", "SAO 140282"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.53156765),
        dec: Angle.Degrees(-02.01156097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14963"},
        {"Hipparcos Number", "HIP 11234"},
        {"Smithsonian Astrophysical Observation", "SAO 129881"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.15050685),
        dec: Angle.Degrees(-02.01049766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130640"},
        {"Hipparcos Number", "HIP 72498"},
        {"Smithsonian Astrophysical Observation", "SAO 140160"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.35711440),
        dec: Angle.Degrees(-02.01028822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57983",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57983"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.40555405),
        dec: Angle.Degrees(-02.00991747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42409"},
        {"Hipparcos Number", "HIP 29279"},
        {"Geneva Identification System", "GEN# +1.00042409"},
        {"Smithsonian Astrophysical Observation", "SAO 132912"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.869,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.59083951),
        dec: Angle.Degrees(-02.00727745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139841"},
        {"Hipparcos Number", "HIP 76771"},
        {"Smithsonian Astrophysical Observation", "SAO 140691"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.12034264),
        dec: Angle.Degrees(-02.00664082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186383"},
        {"Hipparcos Number", "HIP 97107"},
        {"Geneva Identification System", "GEN# +1.00186383"},
        {"Smithsonian Astrophysical Observation", "SAO 143740"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.02068316),
        dec: Angle.Degrees(-02.00614574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51343",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51343"},
    },
    visualMagnitude: 11.58,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.30711263),
        dec: Angle.Degrees(-01.99863109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -150.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 187.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24445"},
        {"Hipparcos Number", "HIP 18171"},
        {"Geneva Identification System", "GEN# +1.00024445"},
        {"Smithsonian Astrophysical Observation", "SAO 130795"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.29850798),
        dec: Angle.Degrees(-01.99781553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8251"},
        {"Hipparcos Number", "HIP 6368"},
        {"Geneva Identification System", "GEN# +1.00008251"},
        {"Renson", "Renson 2000"},
        {"Smithsonian Astrophysical Observation", "SAO 129253"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.45178809),
        dec: Angle.Degrees(-01.99703061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13800",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13800"},
        {"Geneva Identification System", "GEN# -0.00200524"},
        {"Wilson Evans Batten Catalogue", "WEB 2733"},
    },
    visualMagnitude: 10.33,
    bvColour: -0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.41531735),
        dec: Angle.Degrees(-01.99682284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95245"},
        {"Hipparcos Number", "HIP 53751"},
        {"Geneva Identification System", "GEN# +1.00095245"},
        {"Smithsonian Astrophysical Observation", "SAO 137932"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.95743253),
        dec: Angle.Degrees(-01.99509498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159272"},
        {"Hipparcos Number", "HIP 85941"},
        {"Smithsonian Astrophysical Observation", "SAO 141735"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.47226468),
        dec: Angle.Degrees(-01.99227173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8930"},
        {"Hipparcos Number", "HIP 6833"},
        {"Smithsonian Astrophysical Observation", "SAO 129314"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.98192045),
        dec: Angle.Degrees(-01.99114278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -167.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -144.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70929",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70929"},
        {"Smithsonian Astrophysical Observation", "SAO 139972"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.58235452),
        dec: Angle.Degrees(-01.99109241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203889"},
        {"Hipparcos Number", "HIP 105750"},
        {"Geneva Identification System", "GEN# +1.00203889"},
        {"Smithsonian Astrophysical Observation", "SAO 145381"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.27955052),
        dec: Angle.Degrees(-01.98862494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40963",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40963"},
        {"Smithsonian Astrophysical Observation", "SAO 135809"},
    },
    visualMagnitude: 9.61,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.39891050),
        dec: Angle.Degrees(-01.98834978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125817"},
        {"Hipparcos Number", "HIP 70220"},
        {"Geneva Identification System", "GEN# +1.00125817"},
        {"Smithsonian Astrophysical Observation", "SAO 139890"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.49420910),
        dec: Angle.Degrees(-01.98806836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141438"},
        {"Hipparcos Number", "HIP 77478"},
        {"Geneva Identification System", "GEN# +1.00141438"},
        {"Smithsonian Astrophysical Observation", "SAO 140781"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.29922194),
        dec: Angle.Degrees(-01.98795713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158558"},
        {"Hipparcos Number", "HIP 85638"},
        {"Smithsonian Astrophysical Observation", "SAO 141698"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.52033913),
        dec: Angle.Degrees(-01.98677704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133645"},
        {"Hipparcos Number", "HIP 73862"},
        {"Geneva Identification System", "GEN# +1.00133645"},
        {"Smithsonian Astrophysical Observation", "SAO 140318"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.42828825),
        dec: Angle.Degrees(-01.98537769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170474"},
        {"Hipparcos Number", "HIP 90642"},
        {"Fundamental Katalog 5th Edition", "FK5 1480"},
        {"Geneva Identification System", "GEN# +1.00170474"},
        {"Smithsonian Astrophysical Observation", "SAO 142348"},
        {"Wilson Evans Batten Catalogue", "WEB 15520"},
    },
    visualMagnitude: 5.38,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.42067689),
        dec: Angle.Degrees(-01.98522563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37173"},
        {"Hipparcos Number", "HIP 26334"},
        {"Celescope Catalog", "CEL 856"},
        {"Geneva Identification System", "GEN# +1.00037173"},
        {"Smithsonian Astrophysical Observation", "SAO 132353"},
    },
    visualMagnitude: 7.85,
    bvColour: -0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.12745073),
        dec: Angle.Degrees(-01.98382715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55132",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55132"},
        {"Cincinnati Publication", "Ci 20 626"},
        {"Geneva Identification System", "GEN# -0.00102505"},
        {"Smithsonian Astrophysical Observation", "SAO 138111"},
        {"Wilson Evans Batten Catalogue", "WEB 9942"},
    },
    visualMagnitude: 9.73,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.30831487),
        dec: Angle.Degrees(-01.98181942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -566.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224449"},
        {"Hipparcos Number", "HIP 118156"},
        {"Smithsonian Astrophysical Observation", "SAO 147003"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.723,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.51181351),
        dec: Angle.Degrees(-01.98003603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24924"},
        {"Hipparcos Number", "HIP 18519"},
        {"Smithsonian Astrophysical Observation", "SAO 130842"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.39807432),
        dec: Angle.Degrees(-01.97489454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124272"},
        {"Hipparcos Number", "HIP 69409"},
        {"Smithsonian Astrophysical Observation", "SAO 139789"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.17318545),
        dec: Angle.Degrees(-01.97452148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24255"},
        {"Hipparcos Number", "HIP 18051"},
        {"Smithsonian Astrophysical Observation", "SAO 130774"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.86962000),
        dec: Angle.Degrees(-01.97434946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113517"},
        {"Hipparcos Number", "HIP 63781"},
        {"Smithsonian Astrophysical Observation", "SAO 139137"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.09345059),
        dec: Angle.Degrees(-01.97371295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71276",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71276"},
        {"Geneva Identification System", "GEN# -0.00102966"},
    },
    visualMagnitude: 9.93,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.65612633),
        dec: Angle.Degrees(-01.97307905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -126.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103266",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103266"},
        {"Smithsonian Astrophysical Observation", "SAO 144944"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.785,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.81377235),
        dec: Angle.Degrees(-01.97306598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23315"},
        {"Hipparcos Number", "HIP 17438"},
        {"Smithsonian Astrophysical Observation", "SAO 130695"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.02841234),
        dec: Angle.Degrees(-01.97173956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17695",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17695"},
    },
    visualMagnitude: 11.59,
    bvColour: 1.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.84681692),
        dec: Angle.Degrees(-01.97154152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 186.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -271.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189359"},
        {"Hipparcos Number", "HIP 98406"},
        {"Geneva Identification System", "GEN# +1.00189359"},
        {"Smithsonian Astrophysical Observation", "SAO 143974"},
    },
    visualMagnitude: 6.71,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.92298332),
        dec: Angle.Degrees(-01.97032891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3652"},
        {"Hipparcos Number", "HIP 3090"},
        {"Geneva Identification System", "GEN# +1.00003652"},
        {"Smithsonian Astrophysical Observation", "SAO 128877"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.82855157),
        dec: Angle.Degrees(-01.96758430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165316"},
        {"Hipparcos Number", "HIP 88612"},
        {"Smithsonian Astrophysical Observation", "SAO 142075"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.38508388),
        dec: Angle.Degrees(-01.96553912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121218"},
        {"Hipparcos Number", "HIP 67875"},
        {"Geneva Identification System", "GEN# +1.00121218"},
        {"Smithsonian Astrophysical Observation", "SAO 139609"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.53064509),
        dec: Angle.Degrees(-01.96545436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34429"},
        {"Hipparcos Number", "HIP 24636"},
        {"Geneva Identification System", "GEN# +1.00034429"},
        {"Smithsonian Astrophysical Observation", "SAO 131946"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.29859697),
        dec: Angle.Degrees(-01.96253303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17107"},
        {"Hipparcos Number", "HIP 12812"},
        {"Smithsonian Astrophysical Observation", "SAO 130090"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.16616305),
        dec: Angle.Degrees(-01.96181652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186315"},
        {"Hipparcos Number", "HIP 97082"},
        {"Fundamental Katalog 5th Edition", "FK5 5741"},
        {"Smithsonian Astrophysical Observation", "SAO 143736"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.94220076),
        dec: Angle.Degrees(-01.95911136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93831"},
        {"Hipparcos Number", "HIP 52964"},
        {"Smithsonian Astrophysical Observation", "SAO 137818"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.48476258),
        dec: Angle.Degrees(-01.95899956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93655"},
        {"Hipparcos Number", "HIP 52863"},
        {"Geneva Identification System", "GEN# +1.00093655"},
        {"Smithsonian Astrophysical Observation", "SAO 137800"},
        {"Wilson Evans Batten Catalogue", "WEB 9625"},
    },
    visualMagnitude: 5.92,
    bvColour: 1.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.16902815),
        dec: Angle.Degrees(-01.95891494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172234"},
        {"Hipparcos Number", "HIP 91459"},
        {"Geneva Identification System", "GEN# +1.00172234"},
        {"Smithsonian Astrophysical Observation", "SAO 142471"},
        {"Wilson Evans Batten Catalogue", "WEB 15721"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.80575045),
        dec: Angle.Degrees(-01.95208440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41835"},
        {"Hipparcos Number", "HIP 29015"},
        {"Geneva Identification System", "GEN# +1.00041835"},
        {"Smithsonian Astrophysical Observation", "SAO 132853"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.83410372),
        dec: Angle.Degrees(-01.95121435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29735"},
        {"Hipparcos Number", "HIP 21796"},
        {"Geneva Identification System", "GEN# +1.00029735"},
        {"Smithsonian Astrophysical Observation", "SAO 131400"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.23794069),
        dec: Angle.Degrees(-01.95003276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142230"},
        {"Hipparcos Number", "HIP 77826"},
        {"Smithsonian Astrophysical Observation", "SAO 140824"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.37260109),
        dec: Angle.Degrees(-01.94992911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86342"},
        {"Hipparcos Number", "HIP 48847"},
        {"Smithsonian Astrophysical Observation", "SAO 137258"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.45270195),
        dec: Angle.Degrees(-01.94710444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180505"},
        {"Hipparcos Number", "HIP 94766"},
        {"Smithsonian Astrophysical Observation", "SAO 143217"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.24219994),
        dec: Angle.Degrees(-01.94707814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 290471"},
        {"Hipparcos Number", "HIP 25603"},
        {"Geneva Identification System", "GEN# +1.00290471"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.05613212),
        dec: Angle.Degrees(-01.94699320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182767"},
        {"Hipparcos Number", "HIP 95570"},
        {"Geneva Identification System", "GEN# +1.00182767"},
        {"Smithsonian Astrophysical Observation", "SAO 143398"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.59378673),
        dec: Angle.Degrees(-01.94632817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224037"},
        {"Hipparcos Number", "HIP 117881"},
        {"Fundamental Katalog 5th Edition", "FK5 6119"},
        {"Smithsonian Astrophysical Observation", "SAO 146971"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.66108913),
        dec: Angle.Degrees(-01.94620275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152116"},
        {"Hipparcos Number", "HIP 82487"},
        {"Smithsonian Astrophysical Observation", "SAO 141405"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.88162156),
        dec: Angle.Degrees(-01.94592620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222963"},
        {"Hipparcos Number", "HIP 117176"},
        {"Smithsonian Astrophysical Observation", "SAO 146888"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.35111630),
        dec: Angle.Degrees(-01.94541258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15286"},
        {"Hipparcos Number", "HIP 11442"},
        {"Smithsonian Astrophysical Observation", "SAO 129915"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.88468961),
        dec: Angle.Degrees(-01.94480563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26727",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Alnitak"},
        {"Aitken", "ADS 4263 AB"},
        {"Hipparcos Number", "HIP 26727"},
        {"Celescope Catalog", "CEL 921"},
        {"Geneva Identification System", "GEN# +1.00037742"},
        {"Smithsonian Astrophysical Observation", "SAO 132444"},
    },
    visualMagnitude: 1.74,
    bvColour: -0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.18968672),
        dec: Angle.Degrees(-01.94257841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108835"},
        {"Hipparcos Number", "HIP 61018"},
        {"Smithsonian Astrophysical Observation", "SAO 138820"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.58131416),
        dec: Angle.Degrees(-01.94246216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48839",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7596 AB"},
        {"Henry Draper", "HD 86341"},
        {"Hipparcos Number", "HIP 48839"},
        {"Smithsonian Astrophysical Observation", "SAO 137256"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.43290850),
        dec: Angle.Degrees(-01.94177088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16192"},
        {"Hipparcos Number", "HIP 12098"},
        {"Smithsonian Astrophysical Observation", "SAO 130000"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.97447954),
        dec: Angle.Degrees(-01.94136513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35957"},
        {"Hipparcos Number", "HIP 25600"},
        {"Geneva Identification System", "GEN# +1.00035957"},
        {"Smithsonian Astrophysical Observation", "SAO 132142"},
    },
    visualMagnitude: 8.51,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.05264185),
        dec: Angle.Degrees(-01.94125378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175927"},
        {"Hipparcos Number", "HIP 93093"},
        {"Smithsonian Astrophysical Observation", "SAO 142849"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.883,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.46434338),
        dec: Angle.Degrees(-01.93985361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168442"},
        {"Hipparcos Number", "HIP 89825"},
        {"Geneva Identification System", "GEN# +1.00168442"},
        {"Smithsonian Astrophysical Observation", "SAO 142227"},
        {"Wilson Evans Batten Catalogue", "WEB 15328"},
    },
    visualMagnitude: 9.66,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.96183965),
        dec: Angle.Degrees(-01.93861165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223619"},
        {"Hipparcos Number", "HIP 117612"},
        {"Smithsonian Astrophysical Observation", "SAO 146934"},
    },
    visualMagnitude: 9.71,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.78941876),
        dec: Angle.Degrees(-01.93612928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42016"},
        {"Hipparcos Number", "HIP 29105"},
        {"Geneva Identification System", "GEN# +1.00042016"},
        {"Smithsonian Astrophysical Observation", "SAO 132873"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.07533808),
        dec: Angle.Degrees(-01.93592794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98699"},
        {"Hipparcos Number", "HIP 55453"},
        {"Smithsonian Astrophysical Observation", "SAO 138155"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.35561614),
        dec: Angle.Degrees(-01.93380606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12956"},
        {"Hipparcos Number", "HIP 9855"},
        {"Smithsonian Astrophysical Observation", "SAO 129698"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.70062844),
        dec: Angle.Degrees(-01.93371400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206352"},
        {"Hipparcos Number", "HIP 107101"},
        {"Smithsonian Astrophysical Observation", "SAO 145593"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.41149293),
        dec: Angle.Degrees(-01.93202770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120408"},
        {"Hipparcos Number", "HIP 67439"},
        {"Geneva Identification System", "GEN# +1.00120408"},
        {"Smithsonian Astrophysical Observation", "SAO 139574"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.32141755),
        dec: Angle.Degrees(-01.92914074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39849"},
        {"Hipparcos Number", "HIP 27987"},
        {"Geneva Identification System", "GEN# +1.00039849"},
        {"Smithsonian Astrophysical Observation", "SAO 132645"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.78097104),
        dec: Angle.Degrees(-01.92680413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10816"},
        {"Hipparcos Number", "HIP 8218"},
        {"Geneva Identification System", "GEN# +1.00010816"},
        {"Smithsonian Astrophysical Observation", "SAO 129487"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.45907517),
        dec: Angle.Degrees(-01.92656191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51584",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51584"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.04861318),
        dec: Angle.Degrees(-01.92634063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41038",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41038"},
        {"Smithsonian Astrophysical Observation", "SAO 135830"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.63212131),
        dec: Angle.Degrees(-01.92616975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219788"},
        {"Hipparcos Number", "HIP 115091"},
        {"Smithsonian Astrophysical Observation", "SAO 146632"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.66240288),
        dec: Angle.Degrees(-01.92573384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16709"},
        {"Hipparcos Number", "HIP 12490"},
        {"Smithsonian Astrophysical Observation", "SAO 130052"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.17116506),
        dec: Angle.Degrees(-01.92506609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4873"},
        {"Hipparcos Number", "HIP 3957"},
        {"Smithsonian Astrophysical Observation", "SAO 128981"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.69794449),
        dec: Angle.Degrees(-01.92186850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104130"},
        {"Hipparcos Number", "HIP 58480"},
        {"Geneva Identification System", "GEN# +1.00104130"},
        {"Smithsonian Astrophysical Observation", "SAO 138521"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.89163658),
        dec: Angle.Degrees(-01.91856020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203718"},
        {"Hipparcos Number", "HIP 105661"},
        {"Smithsonian Astrophysical Observation", "SAO 145364"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.03143766),
        dec: Angle.Degrees(-01.91546168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 163.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13405"},
        {"Hipparcos Number", "HIP 10188"},
        {"Smithsonian Astrophysical Observation", "SAO 129733"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.74469045),
        dec: Angle.Degrees(-01.91473035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60410",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60410"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.809,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.79694637),
        dec: Angle.Degrees(-01.91452587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25980"},
        {"Hipparcos Number", "HIP 19184"},
        {"Smithsonian Astrophysical Observation", "SAO 130954"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.67376143),
        dec: Angle.Degrees(-01.91448854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84515"},
        {"Hipparcos Number", "HIP 47906"},
        {"Geneva Identification System", "GEN# +1.00084515"},
        {"Smithsonian Astrophysical Observation", "SAO 137107"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.44951178),
        dec: Angle.Degrees(-01.91341146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14904"},
        {"Hipparcos Number", "HIP 11208"},
        {"Smithsonian Astrophysical Observation", "SAO 129876"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.712,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.07250387),
        dec: Angle.Degrees(-01.91297807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171389"},
        {"Hipparcos Number", "HIP 91086"},
        {"Geneva Identification System", "GEN# +1.00171389"},
        {"Smithsonian Astrophysical Observation", "SAO 142402"},
        {"Smithsonian Astrophysical Observation 2", "SAO 142403"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.68575663),
        dec: Angle.Degrees(-01.91102794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84682"},
        {"Hipparcos Number", "HIP 47988"},
        {"Geneva Identification System", "GEN# +1.00084682"},
        {"Smithsonian Astrophysical Observation", "SAO 137121"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.791,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.71102702),
        dec: Angle.Degrees(-01.90641453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142072"},
        {"Hipparcos Number", "HIP 77749"},
        {"Geneva Identification System", "GEN# +1.00142072"},
        {"Smithsonian Astrophysical Observation", "SAO 140812"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.14090165),
        dec: Angle.Degrees(-01.90635471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -114.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59311"},
        {"Hipparcos Number", "HIP 36388"},
        {"Fundamental Katalog 5th Edition", "FK5 2578"},
        {"Geneva Identification System", "GEN# +1.00059311"},
        {"Smithsonian Astrophysical Observation", "SAO 134740"},
        {"Wilson Evans Batten Catalogue", "WEB 7243"},
    },
    visualMagnitude: 5.60,
    bvColour: 1.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.32781398),
        dec: Angle.Degrees(-01.90530704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113906"},
        {"Hipparcos Number", "HIP 64000"},
        {"Smithsonian Astrophysical Observation", "SAO 139162"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.72356291),
        dec: Angle.Degrees(-01.90469621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48103"},
        {"Hipparcos Number", "HIP 32042"},
        {"Smithsonian Astrophysical Observation", "SAO 133578"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.41123896),
        dec: Angle.Degrees(-01.90323616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12375",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2021 B"},
        {"Henry Draper", "HD 16560B"},
        {"Hipparcos Number", "HIP 12375"},
    },
    visualMagnitude: 10.13,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.82543236),
        dec: Angle.Degrees(-01.90314167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96694"},
        {"Hipparcos Number", "HIP 54432"},
        {"Geneva Identification System", "GEN# +1.00096694"},
        {"Smithsonian Astrophysical Observation", "SAO 138001"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.07058839),
        dec: Angle.Degrees(-01.90309069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19676",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19676"},
    },
    visualMagnitude: 10.59,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.22621390),
        dec: Angle.Degrees(-01.90260341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36811"},
        {"Hipparcos Number", "HIP 26117"},
        {"Geneva Identification System", "GEN# +9.00040004"},
        {"Renson", "Renson 9640"},
        {"Smithsonian Astrophysical Observation", "SAO 132272"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.54058426),
        dec: Angle.Degrees(-01.90186751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12376",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2021 A"},
        {"Henry Draper", "HD 16560"},
        {"Hipparcos Number", "HIP 12376"},
        {"Geneva Identification System", "GEN# +1.00016560"},
        {"Smithsonian Astrophysical Observation", "SAO 130038"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.82726739),
        dec: Angle.Degrees(-01.90099551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5104"},
        {"Hipparcos Number", "HIP 4125"},
        {"Smithsonian Astrophysical Observation", "SAO 129005"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.21252447),
        dec: Angle.Degrees(-01.90079276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217940"},
        {"Hipparcos Number", "HIP 113931"},
        {"Smithsonian Astrophysical Observation", "SAO 146487"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.07694891),
        dec: Angle.Degrees(-01.89985396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37764",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37764"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.16205609),
        dec: Angle.Degrees(-01.89981913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38914"},
        {"Hipparcos Number", "HIP 27470"},
        {"Smithsonian Astrophysical Observation", "SAO 132564"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.26498372),
        dec: Angle.Degrees(-01.89892994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 290935"},
        {"Hipparcos Number", "HIP 27689"},
        {"Smithsonian Astrophysical Observation", "SAO 132595"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.93615174),
        dec: Angle.Degrees(-01.89879215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219771"},
        {"Hipparcos Number", "HIP 115074"},
        {"Smithsonian Astrophysical Observation", "SAO 146631"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.61517831),
        dec: Angle.Degrees(-01.89847963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 102.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74988"},
        {"Hipparcos Number", "HIP 43142"},
        {"Fundamental Katalog 5th Edition", "FK5 2693"},
        {"Geneva Identification System", "GEN# +1.00074988"},
        {"Smithsonian Astrophysical Observation", "SAO 136276"},
        {"Wilson Evans Batten Catalogue", "WEB 8327"},
    },
    visualMagnitude: 5.28,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.81253189),
        dec: Angle.Degrees(-01.89705972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22853"},
        {"Hipparcos Number", "HIP 17132"},
        {"Geneva Identification System", "GEN# +1.00022853"},
        {"Smithsonian Astrophysical Observation", "SAO 130647"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.03897260),
        dec: Angle.Degrees(-01.89674759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188572"},
        {"Hipparcos Number", "HIP 98074"},
        {"Smithsonian Astrophysical Observation", "SAO 143923"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.98145273),
        dec: Angle.Degrees(-01.89525320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117419"},
        {"Hipparcos Number", "HIP 65879"},
        {"Geneva Identification System", "GEN# +1.00117419"},
        {"Smithsonian Astrophysical Observation", "SAO 139367"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.56198151),
        dec: Angle.Degrees(-01.89503537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137"},
        {"Hipparcos Number", "HIP 515"},
        {"Smithsonian Astrophysical Observation", "SAO 128583"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.55483056),
        dec: Angle.Degrees(-01.88705095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135205"},
        {"Hipparcos Number", "HIP 74558"},
        {"Geneva Identification System", "GEN# +1.00135205"},
        {"Smithsonian Astrophysical Observation", "SAO 140398"},
        {"Wilson Evans Batten Catalogue", "WEB 12723"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.50611501),
        dec: Angle.Degrees(-01.88637958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188082"},
        {"Hipparcos Number", "HIP 97887"},
        {"Smithsonian Astrophysical Observation", "SAO 143890"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.36799561),
        dec: Angle.Degrees(-01.88457551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42533"},
        {"Hipparcos Number", "HIP 29339"},
        {"Geneva Identification System", "GEN# +1.00042533"},
        {"Smithsonian Astrophysical Observation", "SAO 132925"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.77907695),
        dec: Angle.Degrees(-01.88379482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77472",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77472"},
        {"Smithsonian Astrophysical Observation", "SAO 140779"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.27553383),
        dec: Angle.Degrees(-01.87950531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38763",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38763"},
        {"Smithsonian Astrophysical Observation", "SAO 135273"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.03205137),
        dec: Angle.Degrees(-01.87619392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61605"},
        {"Hipparcos Number", "HIP 37350"},
        {"Geneva Identification System", "GEN# +1.00061605"},
        {"Smithsonian Astrophysical Observation", "SAO 134953"},
    },
    visualMagnitude: 7.60,
    bvColour: -0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.99783317),
        dec: Angle.Degrees(-01.87456526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9566",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9566"},
        {"Smithsonian Astrophysical Observation", "SAO 129651"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.72622610),
        dec: Angle.Degrees(-01.87394582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132587"},
        {"Hipparcos Number", "HIP 73401"},
        {"Smithsonian Astrophysical Observation", "SAO 140264"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.00909757),
        dec: Angle.Degrees(-01.87227193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131553"},
        {"Hipparcos Number", "HIP 72931"},
        {"Smithsonian Astrophysical Observation", "SAO 140212"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.58701775),
        dec: Angle.Degrees(-01.87219417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169436"},
        {"Hipparcos Number", "HIP 90240"},
        {"Geneva Identification System", "GEN# +1.00169436"},
        {"Smithsonian Astrophysical Observation", "SAO 142292"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.18035070),
        dec: Angle.Degrees(-01.87098277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22954",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3544 AB"},
        {"Henry Draper", "HD 31503"},
        {"Hipparcos Number", "HIP 22954"},
        {"Smithsonian Astrophysical Observation", "SAO 131613"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.07899205),
        dec: Angle.Degrees(-01.87014891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185785"},
        {"Hipparcos Number", "HIP 96834"},
        {"Geneva Identification System", "GEN# +1.00185785"},
        {"Smithsonian Astrophysical Observation", "SAO 143685"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.22903510),
        dec: Angle.Degrees(-01.86996181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 161.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133771"},
        {"Hipparcos Number", "HIP 73908"},
        {"Smithsonian Astrophysical Observation", "SAO 140322"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.56817725),
        dec: Angle.Degrees(-01.86983300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147294"},
        {"Hipparcos Number", "HIP 80120"},
        {"Smithsonian Astrophysical Observation", "SAO 141117"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.31723053),
        dec: Angle.Degrees(-01.86975828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151630"},
        {"Hipparcos Number", "HIP 82274"},
        {"Smithsonian Astrophysical Observation", "SAO 141371"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.16814265),
        dec: Angle.Degrees(-01.86942440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73413"},
        {"Hipparcos Number", "HIP 42360"},
        {"Geneva Identification System", "GEN# +1.00073413"},
        {"Smithsonian Astrophysical Observation", "SAO 136116"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.925,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.55221761),
        dec: Angle.Degrees(-01.86890878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30534"},
        {"Hipparcos Number", "HIP 22316"},
        {"Geneva Identification System", "GEN# +1.00030534"},
        {"Smithsonian Astrophysical Observation", "SAO 131501"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.09776934),
        dec: Angle.Degrees(-01.86645901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9539"},
        {"Hipparcos Number", "HIP 7267"},
        {"Smithsonian Astrophysical Observation", "SAO 129369"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.877,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.40193126),
        dec: Angle.Degrees(-01.86554789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29107"},
        {"Hipparcos Number", "HIP 21344"},
        {"Smithsonian Astrophysical Observation", "SAO 131324"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.70576092),
        dec: Angle.Degrees(-01.86472991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 120250",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 120250"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.50647873),
        dec: Angle.Degrees(-01.86446512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 226.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57678"},
        {"Hipparcos Number", "HIP 35718"},
        {"Cincinnati Publication", "Ci 20 422"},
        {"Geneva Identification System", "GEN# +1.00057678"},
        {"Smithsonian Astrophysical Observation", "SAO 134581"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.774,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.54129922),
        dec: Angle.Degrees(-01.86334762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -369.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 256.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1369"},
        {"Hipparcos Number", "HIP 1424"},
        {"Geneva Identification System", "GEN# +1.00001369"},
        {"Smithsonian Astrophysical Observation", "SAO 128685"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.45156753),
        dec: Angle.Degrees(-01.86274674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7320"},
        {"Hipparcos Number", "HIP 5697"},
        {"Geneva Identification System", "GEN# +1.00007320"},
        {"Smithsonian Astrophysical Observation", "SAO 129181"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.32891358),
        dec: Angle.Degrees(-01.86194506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -202.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22047"},
        {"Hipparcos Number", "HIP 16558"},
        {"Geneva Identification System", "GEN# +1.00022047"},
        {"Smithsonian Astrophysical Observation", "SAO 130565"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.30066512),
        dec: Angle.Degrees(-01.86062603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35107",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5935 AB"},
        {"Henry Draper", "HD 56083"},
        {"Hipparcos Number", "HIP 35107"},
        {"Smithsonian Astrophysical Observation", "SAO 134420"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.89299917),
        dec: Angle.Degrees(-01.86012633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85379"},
        {"Hipparcos Number", "HIP 48347"},
        {"Geneva Identification System", "GEN# +1.00085379"},
        {"Smithsonian Astrophysical Observation", "SAO 137184"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.83133561),
        dec: Angle.Degrees(-01.85817239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 290038"},
        {"Hipparcos Number", "HIP 24190"},
        {"Geneva Identification System", "GEN# +1.00290038"},
        {"Smithsonian Astrophysical Observation", "SAO 131858"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.925,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.90341683),
        dec: Angle.Degrees(-01.85571767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177207"},
        {"Hipparcos Number", "HIP 93614"},
        {"Geneva Identification System", "GEN# +1.00177207"},
        {"Smithsonian Astrophysical Observation", "SAO 142971"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.95931864),
        dec: Angle.Degrees(-01.85476380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39486",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6555 AB"},
        {"Henry Draper", "HD 66592"},
        {"Hipparcos Number", "HIP 39486"},
    },
    visualMagnitude: 8.04,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.05866407),
        dec: Angle.Degrees(-01.85281312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84123",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84123"},
    },
    visualMagnitude: 11.45,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.96906084),
        dec: Angle.Degrees(-01.85097191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -534.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -326.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224638"},
        {"Hipparcos Number", "HIP 118293"},
        {"Geneva Identification System", "GEN# +1.00224638"},
        {"Smithsonian Astrophysical Observation", "SAO 147016"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.89563887),
        dec: Angle.Degrees(-01.84999158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 150.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57838",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57838"},
    },
    visualMagnitude: 9.46,
    bvColour: 1.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.91719945),
        dec: Angle.Degrees(-01.84667881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 290931"},
        {"Hipparcos Number", "HIP 27797"},
        {"Smithsonian Astrophysical Observation", "SAO 132614"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.23616172),
        dec: Angle.Degrees(-01.84442787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54908"},
        {"Hipparcos Number", "HIP 34657"},
        {"Geneva Identification System", "GEN# +1.00054908"},
        {"Renson", "Renson 15000"},
        {"Smithsonian Astrophysical Observation", "SAO 134292"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.66247208),
        dec: Angle.Degrees(-01.84288405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181761"},
        {"Hipparcos Number", "HIP 95181"},
        {"Geneva Identification System", "GEN# +1.00181761"},
        {"Smithsonian Astrophysical Observation", "SAO 143312"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.44510561),
        dec: Angle.Degrees(-01.83932329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69524"},
        {"Hipparcos Number", "HIP 40598"},
        {"Smithsonian Astrophysical Observation", "SAO 135729"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.32921251),
        dec: Angle.Degrees(-01.83872759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65651",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65651"},
    },
    visualMagnitude: 10.79,
    bvColour: 1.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.89818317),
        dec: Angle.Degrees(-01.83782318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101461"},
        {"Hipparcos Number", "HIP 56952"},
        {"Smithsonian Astrophysical Observation", "SAO 138337"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.12582940),
        dec: Angle.Degrees(-01.83764863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102914",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102914"},
        {"Cincinnati Publication", "Ci 20 1234"},
    },
    visualMagnitude: 9.79,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.73985102),
        dec: Angle.Degrees(-01.83584525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -147.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -446.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179743"},
        {"Hipparcos Number", "HIP 94482"},
        {"Fundamental Katalog 5th Edition", "FK5 5691"},
        {"Smithsonian Astrophysical Observation", "SAO 143156"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.44886073),
        dec: Angle.Degrees(-01.83514792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28958"},
        {"Hipparcos Number", "HIP 21259"},
        {"Smithsonian Astrophysical Observation", "SAO 131299"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.41349182),
        dec: Angle.Degrees(-01.83126487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16191"},
        {"Hipparcos Number", "HIP 12090"},
        {"Smithsonian Astrophysical Observation", "SAO 129998"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.95667975),
        dec: Angle.Degrees(-01.83071142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137645"},
        {"Hipparcos Number", "HIP 75648"},
        {"Smithsonian Astrophysical Observation", "SAO 140542"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.82632591),
        dec: Angle.Degrees(-01.82998568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38315",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38315"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.75016188),
        dec: Angle.Degrees(-01.82966874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108460",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15498 AB"},
        {"Henry Draper", "HD 208719"},
        {"Hipparcos Number", "HIP 108460"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.58314160),
        dec: Angle.Degrees(-01.82956361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187168"},
        {"Hipparcos Number", "HIP 97466"},
        {"Geneva Identification System", "GEN# +1.00187168"},
        {"Smithsonian Astrophysical Observation", "SAO 143810"},
        {"Wilson Evans Batten Catalogue", "WEB 17129"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.16245704),
        dec: Angle.Degrees(-01.82646053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13468"},
        {"Hipparcos Number", "HIP 10234"},
        {"Fundamental Katalog 5th Edition", "FK5 2151"},
        {"Geneva Identification System", "GEN# +1.00013468"},
        {"Smithsonian Astrophysical Observation", "SAO 129739"},
        {"Wilson Evans Batten Catalogue", "WEB 2136"},
    },
    visualMagnitude: 5.94,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.89933984),
        dec: Angle.Degrees(-01.82534866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111593"},
        {"Hipparcos Number", "HIP 62664"},
        {"Fundamental Katalog 5th Edition", "FK5 5136"},
        {"Smithsonian Astrophysical Observation", "SAO 138987"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.59951793),
        dec: Angle.Degrees(-01.82503988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40067"},
        {"Hipparcos Number", "HIP 28109"},
        {"Smithsonian Astrophysical Observation", "SAO 132673"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.11082222),
        dec: Angle.Degrees(-01.82420931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106966"},
        {"Hipparcos Number", "HIP 59979"},
        {"Smithsonian Astrophysical Observation", "SAO 138702"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.51198739),
        dec: Angle.Degrees(-01.82387988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12974"},
        {"Hipparcos Number", "HIP 9865"},
        {"Geneva Identification System", "GEN# +1.00012974"},
        {"Smithsonian Astrophysical Observation", "SAO 129699"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.73363686),
        dec: Angle.Degrees(-01.82366231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42958"},
        {"Hipparcos Number", "HIP 29552"},
        {"Geneva Identification System", "GEN# +1.00042958"},
        {"Smithsonian Astrophysical Observation", "SAO 132987"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.40242788),
        dec: Angle.Degrees(-01.82261661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40283"},
        {"Hipparcos Number", "HIP 28213"},
        {"Smithsonian Astrophysical Observation", "SAO 132691"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.41617628),
        dec: Angle.Degrees(-01.82030820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49435"},
        {"Hipparcos Number", "HIP 32624"},
        {"Geneva Identification System", "GEN# +1.00049435"},
        {"Smithsonian Astrophysical Observation", "SAO 133690"},
        {"Wilson Evans Batten Catalogue", "WEB 6581"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.09172556),
        dec: Angle.Degrees(-01.81795586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170493"},
        {"Hipparcos Number", "HIP 90656"},
        {"Cincinnati Publication", "Ci 18 2425"},
        {"Geneva Identification System", "GEN# +1.00170493"},
        {"Smithsonian Astrophysical Observation", "SAO 142350"},
        {"Wilson Evans Batten Catalogue", "WEB 15524"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.46794575),
        dec: Angle.Degrees(-01.81763239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 172.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -193.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172029"},
        {"Hipparcos Number", "HIP 91358"},
        {"Smithsonian Astrophysical Observation", "SAO 142453"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.49254046),
        dec: Angle.Degrees(-01.81697726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4478",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4478"},
        {"Cincinnati Publication", "Ci 18 125"},
        {"Geneva Identification System", "GEN# -0.00200129"},
        {"Smithsonian Astrophysical Observation", "SAO 129047"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.854,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.33485355),
        dec: Angle.Degrees(-01.81556423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -249.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -182.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45196"},
        {"Hipparcos Number", "HIP 30611"},
        {"Geneva Identification System", "GEN# +1.00045196"},
        {"Smithsonian Astrophysical Observation", "SAO 133239"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.49571874),
        dec: Angle.Degrees(-01.81352974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35882"},
        {"Hipparcos Number", "HIP 25552"},
        {"Celescope Catalog", "CEL 717"},
        {"Geneva Identification System", "GEN# +1.00035882"},
        {"Smithsonian Astrophysical Observation", "SAO 132134"},
    },
    visualMagnitude: 7.82,
    bvColour: -0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.93631527),
        dec: Angle.Degrees(-01.81309533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216261"},
        {"Hipparcos Number", "HIP 112880"},
        {"Smithsonian Astrophysical Observation", "SAO 146358"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.88932082),
        dec: Angle.Degrees(-01.81285601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161903"},
        {"Hipparcos Number", "HIP 87149"},
        {"Geneva Identification System", "GEN# +1.00161903"},
        {"Smithsonian Astrophysical Observation", "SAO 141886"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.08008199),
        dec: Angle.Degrees(-01.80825699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97367",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12924 AB"},
        {"Henry Draper", "HD 186949"},
        {"Hipparcos Number", "HIP 97367"},
        {"Smithsonian Astrophysical Observation", "SAO 143800"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.84975147),
        dec: Angle.Degrees(-01.80799452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132426"},
        {"Hipparcos Number", "HIP 73338"},
        {"Smithsonian Astrophysical Observation", "SAO 140260"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.80262035),
        dec: Angle.Degrees(-01.80750327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161151"},
        {"Hipparcos Number", "HIP 86785"},
        {"Geneva Identification System", "GEN# +1.00161151"},
        {"Smithsonian Astrophysical Observation", "SAO 141839"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.00336991),
        dec: Angle.Degrees(-01.80707366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211788"},
        {"Hipparcos Number", "HIP 110228"},
        {"Smithsonian Astrophysical Observation", "SAO 146020"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.92243895),
        dec: Angle.Degrees(-01.80689961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18669"},
        {"Hipparcos Number", "HIP 13978"},
        {"Geneva Identification System", "GEN# +1.00018669"},
        {"Smithsonian Astrophysical Observation", "SAO 130231"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.01313639),
        dec: Angle.Degrees(-01.80454937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140873"},
        {"Hipparcos Number", "HIP 77227"},
        {"Geneva Identification System", "GEN# +1.00140873"},
        {"Smithsonian Astrophysical Observation", "SAO 140740"},
        {"Wilson Evans Batten Catalogue", "WEB 13085"},
    },
    visualMagnitude: 5.39,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.52354097),
        dec: Angle.Degrees(-01.80411556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69663"},
        {"Hipparcos Number", "HIP 40649"},
        {"Geneva Identification System", "GEN# +1.00069663"},
        {"Smithsonian Astrophysical Observation", "SAO 135745"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.855,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.46726220),
        dec: Angle.Degrees(-01.80349775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -224.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19411"},
        {"Hipparcos Number", "HIP 14494"},
        {"Fundamental Katalog 5th Edition", "FK5 4284"},
        {"Geneva Identification System", "GEN# +1.00019411"},
        {"Smithsonian Astrophysical Observation", "SAO 130294"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.80345232),
        dec: Angle.Degrees(-01.80271215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175640"},
        {"Hipparcos Number", "HIP 92963"},
        {"Fundamental Katalog 5th Edition", "FK5 3510"},
        {"Geneva Identification System", "GEN# +1.00175640"},
        {"Renson", "Renson 49060"},
        {"Smithsonian Astrophysical Observation", "SAO 142825"},
        {"Wilson Evans Batten Catalogue", "WEB 16100"},
    },
    visualMagnitude: 6.20,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.09442308),
        dec: Angle.Degrees(-01.79981538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78395",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78395"},
        {"Geneva Identification System", "GEN# -0.00103125"},
    },
    visualMagnitude: 10.28,
    bvColour: 1.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.06845385),
        dec: Angle.Degrees(-01.79844302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 118.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -150.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65717"},
        {"Hipparcos Number", "HIP 39104"},
        {"Geneva Identification System", "GEN# +1.00065717"},
        {"Smithsonian Astrophysical Observation", "SAO 135349"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.99595325),
        dec: Angle.Degrees(-01.79764968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98563"},
        {"Hipparcos Number", "HIP 55379"},
        {"Geneva Identification System", "GEN# +1.00098563"},
        {"Smithsonian Astrophysical Observation", "SAO 138141"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.09996947),
        dec: Angle.Degrees(-01.79701619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150653"},
        {"Hipparcos Number", "HIP 81802"},
        {"Smithsonian Astrophysical Observation", "SAO 141323"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.61939274),
        dec: Angle.Degrees(-01.79546325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27"},
        {"Hipparcos Number", "HIP 438"},
        {"Geneva Identification System", "GEN# +1.00000027"},
        {"Smithsonian Astrophysical Observation", "SAO 128571"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.32686621),
        dec: Angle.Degrees(-01.79412136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2830"},
        {"Hipparcos Number", "HIP 2496"},
        {"Geneva Identification System", "GEN# +1.00002830"},
        {"Smithsonian Astrophysical Observation", "SAO 128806"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.91974936),
        dec: Angle.Degrees(-01.79363321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221147"},
        {"Hipparcos Number", "HIP 115945"},
        {"Geneva Identification System", "GEN# +1.00221147"},
        {"Smithsonian Astrophysical Observation", "SAO 146733"},
        {"Wilson Evans Batten Catalogue", "WEB 20505"},
    },
    visualMagnitude: 6.35,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.36248095),
        dec: Angle.Degrees(-01.79115943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197123"},
        {"Hipparcos Number", "HIP 102116"},
        {"Geneva Identification System", "GEN# +1.00197123"},
        {"Smithsonian Astrophysical Observation", "SAO 144709"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.42037916),
        dec: Angle.Degrees(-01.79092279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124494"},
        {"Hipparcos Number", "HIP 69531"},
        {"Smithsonian Astrophysical Observation", "SAO 139801"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.51302628),
        dec: Angle.Degrees(-01.79091712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127541"},
        {"Hipparcos Number", "HIP 71073"},
        {"Geneva Identification System", "GEN# +1.00127541"},
        {"Smithsonian Astrophysical Observation", "SAO 139985"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.847,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.01327254),
        dec: Angle.Degrees(-01.78903284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13369",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13369"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.99705685),
        dec: Angle.Degrees(-01.78890358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215749"},
        {"Hipparcos Number", "HIP 112520"},
        {"Fundamental Katalog 5th Edition", "FK5 1598"},
        {"Geneva Identification System", "GEN# +1.00215749"},
        {"Smithsonian Astrophysical Observation", "SAO 146310"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.87397919),
        dec: Angle.Degrees(-01.78875792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139514"},
        {"Hipparcos Number", "HIP 76607"},
        {"Fundamental Katalog 5th Edition", "FK5 5382"},
        {"Geneva Identification System", "GEN# +1.00139514"},
        {"Smithsonian Astrophysical Observation", "SAO 140675"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.67412462),
        dec: Angle.Degrees(-01.78682196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38867"},
        {"Hipparcos Number", "HIP 27446"},
        {"Geneva Identification System", "GEN# +1.00038867"},
        {"Smithsonian Astrophysical Observation", "SAO 132556"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.17086970),
        dec: Angle.Degrees(-01.78556423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138470"},
        {"Hipparcos Number", "HIP 76091"},
        {"Smithsonian Astrophysical Observation", "SAO 140592"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.10105791),
        dec: Angle.Degrees(-01.78351665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100237"},
        {"Hipparcos Number", "HIP 56263"},
        {"Geneva Identification System", "GEN# +1.00100237"},
        {"Smithsonian Astrophysical Observation", "SAO 138252"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.99925302),
        dec: Angle.Degrees(-01.78239705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84652",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84652"},
    },
    visualMagnitude: 10.59,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.59025879),
        dec: Angle.Degrees(-01.78130155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21798"},
        {"Hipparcos Number", "HIP 16360"},
        {"Smithsonian Astrophysical Observation", "SAO 130531"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.69124030),
        dec: Angle.Degrees(-01.78045532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101574"},
        {"Hipparcos Number", "HIP 57011"},
        {"Geneva Identification System", "GEN# +1.00101574"},
        {"Smithsonian Astrophysical Observation", "SAO 138350"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.32800150),
        dec: Angle.Degrees(-01.77804685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55309"},
        {"Hipparcos Number", "HIP 34807"},
        {"Geneva Identification System", "GEN# +1.00055309"},
        {"Renson", "Renson 15040"},
        {"Smithsonian Astrophysical Observation", "SAO 134344"},
    },
    visualMagnitude: 8.78,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.07957072),
        dec: Angle.Degrees(-01.77770186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91857"},
        {"Hipparcos Number", "HIP 51919"},
        {"Smithsonian Astrophysical Observation", "SAO 137667"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.09531262),
        dec: Angle.Degrees(-01.77397410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109098"},
        {"Hipparcos Number", "HIP 61173"},
        {"Geneva Identification System", "GEN# +1.00109098"},
        {"Smithsonian Astrophysical Observation", "SAO 138836"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.01860305),
        dec: Angle.Degrees(-01.77245206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35948"},
        {"Hipparcos Number", "HIP 25594"},
        {"Geneva Identification System", "GEN# +1.00035948"},
        {"Smithsonian Astrophysical Observation", "SAO 132141"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.04358547),
        dec: Angle.Degrees(-01.77176994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3779"},
        {"Hipparcos Number", "HIP 3183"},
        {"Smithsonian Astrophysical Observation", "SAO 128889"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.13458835),
        dec: Angle.Degrees(-01.77086607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165651"},
        {"Hipparcos Number", "HIP 88753"},
        {"Geneva Identification System", "GEN# +1.00165651"},
        {"Smithsonian Astrophysical Observation", "SAO 142096"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.77534302),
        dec: Angle.Degrees(-01.77047754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126828"},
        {"Hipparcos Number", "HIP 70741"},
        {"Smithsonian Astrophysical Observation", "SAO 139946"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.99856510),
        dec: Angle.Degrees(-01.76898069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104356"},
        {"Hipparcos Number", "HIP 58603"},
        {"Geneva Identification System", "GEN# +1.00104356"},
        {"Smithsonian Astrophysical Observation", "SAO 138533"},
        {"Wilson Evans Batten Catalogue", "WEB 10457"},
    },
    visualMagnitude: 6.32,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.25729082),
        dec: Angle.Degrees(-01.76798636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5624"},
        {"Hipparcos Number", "HIP 4511"},
        {"Geneva Identification System", "GEN# +1.00005624"},
        {"Smithsonian Astrophysical Observation", "SAO 129050"},
    },
    visualMagnitude: 6.56,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.45917511),
        dec: Angle.Degrees(-01.76597097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163715"},
        {"Hipparcos Number", "HIP 87935"},
        {"Smithsonian Astrophysical Observation", "SAO 141987"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.44343050),
        dec: Angle.Degrees(-01.76506603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81643"},
        {"Hipparcos Number", "HIP 46338"},
        {"Smithsonian Astrophysical Observation", "SAO 136853"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.70516195),
        dec: Angle.Degrees(-01.76489651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173801"},
        {"Hipparcos Number", "HIP 92182"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.82085486),
        dec: Angle.Degrees(-01.76432608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24127",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3755 AB"},
        {"Henry Draper", "HD 33546"},
        {"Hipparcos Number", "HIP 24127"},
        {"Smithsonian Astrophysical Observation", "SAO 131846"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.73882250),
        dec: Angle.Degrees(-01.76392085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80069",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80069"},
    },
    visualMagnitude: 11.35,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.13981564),
        dec: Angle.Degrees(-01.76265176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159357"},
        {"Hipparcos Number", "HIP 85989"},
        {"Fundamental Katalog 5th Edition", "FK5 5544"},
        {"Geneva Identification System", "GEN# +1.00159357"},
        {"Smithsonian Astrophysical Observation", "SAO 141739"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.62225225),
        dec: Angle.Degrees(-01.76016941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 123.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -166.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174648"},
        {"Hipparcos Number", "HIP 92559"},
        {"Smithsonian Astrophysical Observation", "SAO 142714"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.92082997),
        dec: Angle.Degrees(-01.75975686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114782"},
        {"Hipparcos Number", "HIP 64460"},
        {"Smithsonian Astrophysical Observation", "SAO 139219"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.19086710),
        dec: Angle.Degrees(-01.75835898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150144"},
        {"Hipparcos Number", "HIP 81541"},
        {"Smithsonian Astrophysical Observation", "SAO 141295"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.81483978),
        dec: Angle.Degrees(-01.75797157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50820"},
        {"Hipparcos Number", "HIP 33210"},
        {"Geneva Identification System", "GEN# +1.00050820"},
        {"Smithsonian Astrophysical Observation", "SAO 133881"},
        {"Wilson Evans Batten Catalogue", "WEB 6678"},
    },
    visualMagnitude: 6.20,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.67517925),
        dec: Angle.Degrees(-01.75648542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11830",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1945 AB"},
        {"Henry Draper", "HD 15822"},
        {"Hipparcos Number", "HIP 11830"},
        {"Smithsonian Astrophysical Observation", "SAO 129968"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.17253661),
        dec: Angle.Degrees(-01.75647318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222401"},
        {"Hipparcos Number", "HIP 116796"},
        {"Geneva Identification System", "GEN# +1.00222401"},
        {"Smithsonian Astrophysical Observation", "SAO 146838"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.06564618),
        dec: Angle.Degrees(-01.75442723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11229",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1835 B"},
        {"Henry Draper", "HD 14937B"},
        {"Hipparcos Number", "HIP 11229"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.12812858),
        dec: Angle.Degrees(-01.75230909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11227",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1835 A"},
        {"Henry Draper", "HD 14937"},
        {"Henry Draper 2", "HD 14937A"},
        {"Hipparcos Number", "HIP 11227"},
        {"Smithsonian Astrophysical Observation", "SAO 129880"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.12577306),
        dec: Angle.Degrees(-01.74986187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36219"},
        {"Hipparcos Number", "HIP 25762"},
        {"Celescope Catalog", "CEL 739"},
        {"Geneva Identification System", "GEN# +1.00036219"},
        {"Smithsonian Astrophysical Observation", "SAO 132184"},
    },
    visualMagnitude: 7.65,
    bvColour: -0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.51824884),
        dec: Angle.Degrees(-01.74961025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115152"},
        {"Hipparcos Number", "HIP 64674"},
        {"Smithsonian Astrophysical Observation", "SAO 139245"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.83750805),
        dec: Angle.Degrees(-01.74601664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41661",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41661"},
        {"Geneva Identification System", "GEN# +9.80113040"},
    },
    visualMagnitude: 11.94,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.41873107),
        dec: Angle.Degrees(-01.74452437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 395.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -880.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36863"},
        {"Hipparcos Number", "HIP 26156"},
        {"Geneva Identification System", "GEN# +1.00036863"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.64309959),
        dec: Angle.Degrees(-01.74369191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43788",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43788"},
        {"Smithsonian Astrophysical Observation", "SAO 136402"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.77730399),
        dec: Angle.Degrees(-01.74323539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220554"},
        {"Hipparcos Number", "HIP 115572"},
        {"Geneva Identification System", "GEN# +1.00220554"},
        {"Smithsonian Astrophysical Observation", "SAO 146693"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.822,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.16189133),
        dec: Angle.Degrees(-01.74129125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 165.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92588"},
        {"Hipparcos Number", "HIP 52316"},
        {"Fundamental Katalog 5th Edition", "FK5 404"},
        {"Geneva Identification System", "GEN# +1.00092588"},
        {"Smithsonian Astrophysical Observation", "SAO 137728"},
        {"Wilson Evans Batten Catalogue", "WEB 9524"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.35111140),
        dec: Angle.Degrees(-01.74120123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -136.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182034"},
        {"Hipparcos Number", "HIP 95267"},
        {"Smithsonian Astrophysical Observation", "SAO 143339"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.73926320),
        dec: Angle.Degrees(-01.74056780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161271"},
        {"Hipparcos Number", "HIP 86845"},
        {"Smithsonian Astrophysical Observation", "SAO 141847"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.17418525),
        dec: Angle.Degrees(-01.74015566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20267",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20267"},
        {"Smithsonian Astrophysical Observation", "SAO 131128"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.17076745),
        dec: Angle.Degrees(-01.73971088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50580",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50580"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.97943478),
        dec: Angle.Degrees(-01.73748039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195005"},
        {"Hipparcos Number", "HIP 101022"},
        {"Geneva Identification System", "GEN# +1.00195005"},
        {"Smithsonian Astrophysical Observation", "SAO 144480"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.20807266),
        dec: Angle.Degrees(-01.73445970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177963"},
        {"Hipparcos Number", "HIP 93865"},
        {"Geneva Identification System", "GEN# +1.00177963"},
        {"Smithsonian Astrophysical Observation", "SAO 143032"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.73760327),
        dec: Angle.Degrees(-01.73409348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140347"},
        {"Hipparcos Number", "HIP 76991"},
        {"Smithsonian Astrophysical Observation", "SAO 140715"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.80653354),
        dec: Angle.Degrees(-01.73272489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204796"},
        {"Hipparcos Number", "HIP 106236"},
        {"Geneva Identification System", "GEN# +1.00204796"},
        {"Smithsonian Astrophysical Observation", "SAO 145449"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.76805350),
        dec: Angle.Degrees(-01.73224229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5253",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 923"},
        {"Henry Draper", "HD 6651"},
        {"Hipparcos Number", "HIP 5253"},
        {"Smithsonian Astrophysical Observation", "SAO 129128"},
        {"Wilson Evans Batten Catalogue", "WEB 1108"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.79562046),
        dec: Angle.Degrees(-01.73208324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58608",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58608"},
        {"Geneva Identification System", "GEN# +9.80011034"},
    },
    visualMagnitude: 10.90,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.28046501),
        dec: Angle.Degrees(-01.73203365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -462.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 198.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132212"},
        {"Hipparcos Number", "HIP 73225"},
        {"Smithsonian Astrophysical Observation", "SAO 140244"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.48404650),
        dec: Angle.Degrees(-01.73074497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204235"},
        {"Hipparcos Number", "HIP 105926"},
        {"Smithsonian Astrophysical Observation", "SAO 145408"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.81078923),
        dec: Angle.Degrees(-01.73042915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83752"},
        {"Hipparcos Number", "HIP 47463"},
        {"Geneva Identification System", "GEN# +1.00083752"},
        {"Smithsonian Astrophysical Observation", "SAO 137045"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.13257958),
        dec: Angle.Degrees(-01.73002620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5699",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5699"},
        {"Geneva Identification System", "GEN# +9.80070048"},
        {"Geneva Identification System 2", "GEN# -0.00200180"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.33688342),
        dec: Angle.Degrees(-01.72873164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 130.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -250.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31256"},
        {"Hipparcos Number", "HIP 22791"},
        {"Smithsonian Astrophysical Observation", "SAO 131582"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.55018141),
        dec: Angle.Degrees(-01.72587321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93461"},
        {"Hipparcos Number", "HIP 52767"},
        {"Smithsonian Astrophysical Observation", "SAO 137784"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.929,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.83993478),
        dec: Angle.Degrees(-01.72486853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28192"},
        {"Hipparcos Number", "HIP 20752"},
        {"Geneva Identification System", "GEN# +1.00028192"},
        {"Smithsonian Astrophysical Observation", "SAO 131211"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.70349435),
        dec: Angle.Degrees(-01.72469328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49540",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7643 AB"},
        {"Henry Draper", "HD 87719"},
        {"Hipparcos Number", "HIP 49540"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.72360348),
        dec: Angle.Degrees(-01.72385502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145774"},
        {"Hipparcos Number", "HIP 79443"},
        {"Geneva Identification System", "GEN# +1.00145774"},
        {"Smithsonian Astrophysical Observation", "SAO 141028"},
        {"Wilson Evans Batten Catalogue", "WEB 13433"},
    },
    visualMagnitude: 7.48,
    bvColour: -0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.19038969),
        dec: Angle.Degrees(-01.72189605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26016",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4150 CD"},
        {"Henry Draper", "HD 290609"},
        {"Hipparcos Number", "HIP 26016"},
        {"Geneva Identification System", "GEN# +1.00290609"},
        {"Smithsonian Astrophysical Observation", "SAO 132246"},
    },
    visualMagnitude: 8.60,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.27329815),
        dec: Angle.Degrees(-01.72099372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112282"},
        {"Hipparcos Number", "HIP 63098"},
        {"Smithsonian Astrophysical Observation", "SAO 139043"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.91874782),
        dec: Angle.Degrees(-01.71989941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166992"},
        {"Hipparcos Number", "HIP 89295"},
        {"Geneva Identification System", "GEN# +1.00166992"},
        {"Smithsonian Astrophysical Observation", "SAO 142161"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.31688485),
        dec: Angle.Degrees(-01.71957107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23434",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23434"},
        {"Smithsonian Astrophysical Observation", "SAO 131712"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.56291093),
        dec: Angle.Degrees(-01.71901632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190681"},
        {"Hipparcos Number", "HIP 99025"},
        {"Geneva Identification System", "GEN# +1.00190681"},
        {"Smithsonian Astrophysical Observation", "SAO 144065"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.55184965),
        dec: Angle.Degrees(-01.71873028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29645",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4850 AB"},
        {"Henry Draper", "HD 43192"},
        {"Hipparcos Number", "HIP 29645"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.70135212),
        dec: Angle.Degrees(-01.71841861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26020",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4150 AB"},
        {"Henry Draper", "HD 36646"},
        {"Hipparcos Number", "HIP 26020"},
        {"Celescope Catalog", "CEL 781"},
        {"Geneva Identification System", "GEN# +9.04000210"},
        {"Geneva Identification System 2", "GEN# +9.00040002"},
        {"Smithsonian Astrophysical Observation", "SAO 132247"},
        {"Wilson Evans Batten Catalogue", "WEB 5063"},
    },
    visualMagnitude: 6.53,
    bvColour: -0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.28060605),
        dec: Angle.Degrees(-01.71736064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169513"},
        {"Hipparcos Number", "HIP 90272"},
        {"Geneva Identification System", "GEN# +1.00169513"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.28834372),
        dec: Angle.Degrees(-01.71652160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9098",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9098"},
        {"Smithsonian Astrophysical Observation", "SAO 129577"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.29962472),
        dec: Angle.Degrees(-01.71576132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178575"},
        {"Hipparcos Number", "HIP 94092"},
        {"Smithsonian Astrophysical Observation", "SAO 143079"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.31548490),
        dec: Angle.Degrees(-01.71166077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77027",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77027"},
    },
    visualMagnitude: 10.48,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.90321791),
        dec: Angle.Degrees(-01.71048483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99651"},
        {"Hipparcos Number", "HIP 55941"},
        {"Geneva Identification System", "GEN# +1.00099651J"},
        {"Smithsonian Astrophysical Observation", "SAO 138216"},
        {"Wilson Evans Batten Catalogue", "WEB 10046"},
    },
    visualMagnitude: 6.23,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.97387788),
        dec: Angle.Degrees(-01.69995329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46404"},
        {"Hipparcos Number", "HIP 31234"},
        {"Smithsonian Astrophysical Observation", "SAO 133397"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.27028297),
        dec: Angle.Degrees(-01.69982925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72275",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72275"},
        {"Smithsonian Astrophysical Observation", "SAO 140133"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.70582231),
        dec: Angle.Degrees(-01.69516385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19712"},
        {"Hipparcos Number", "HIP 14736"},
        {"Geneva Identification System", "GEN# +1.00019712"},
        {"Renson", "Renson 4880"},
        {"Smithsonian Astrophysical Observation", "SAO 130319"},
    },
    visualMagnitude: 7.33,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.57538772),
        dec: Angle.Degrees(-01.69469345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197953"},
        {"Hipparcos Number", "HIP 102564"},
        {"Smithsonian Astrophysical Observation", "SAO 144803"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.76891845),
        dec: Angle.Degrees(-01.69369573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87329"},
        {"Hipparcos Number", "HIP 49335"},
        {"Smithsonian Astrophysical Observation", "SAO 137332"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.06914096),
        dec: Angle.Degrees(-01.69261805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130605"},
        {"Hipparcos Number", "HIP 72473"},
        {"Smithsonian Astrophysical Observation", "SAO 140155"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.28588389),
        dec: Angle.Degrees(-01.68891633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224510"},
        {"Hipparcos Number", "HIP 118199"},
        {"Smithsonian Astrophysical Observation", "SAO 147007"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.63040916),
        dec: Angle.Degrees(-01.68849841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153377"},
        {"Hipparcos Number", "HIP 83137"},
        {"Geneva Identification System", "GEN# +1.00153377"},
        {"Smithsonian Astrophysical Observation", "SAO 141470"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.83954458),
        dec: Angle.Degrees(-01.68766943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93351"},
        {"Hipparcos Number", "HIP 52720"},
        {"Smithsonian Astrophysical Observation", "SAO 137777"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.797,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.67733707),
        dec: Angle.Degrees(-01.68761578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -143.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43355",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43355"},
        {"Smithsonian Astrophysical Observation", "SAO 136318"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.47153612),
        dec: Angle.Degrees(-01.68649882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119291"},
        {"Hipparcos Number", "HIP 66886"},
        {"Cincinnati Publication", "Ci 18 1778"},
        {"Geneva Identification System", "GEN# +1.00119291"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.60917973),
        dec: Angle.Degrees(-01.68589553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -286.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -154.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48958"},
        {"Hipparcos Number", "HIP 32416"},
        {"Smithsonian Astrophysical Observation", "SAO 133650"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.51320872),
        dec: Angle.Degrees(-01.68534028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116790",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116790"},
        {"Smithsonian Astrophysical Observation", "SAO 146837"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.05710484),
        dec: Angle.Degrees(-01.68420485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78464"},
        {"Hipparcos Number", "HIP 44854"},
        {"Smithsonian Astrophysical Observation", "SAO 136599"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.08031848),
        dec: Angle.Degrees(-01.68351439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2413"},
        {"Hipparcos Number", "HIP 2208"},
        {"Smithsonian Astrophysical Observation", "SAO 128773"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.98034991),
        dec: Angle.Degrees(-01.68163568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63519"},
        {"Hipparcos Number", "HIP 38168"},
        {"Smithsonian Astrophysical Observation", "SAO 135134"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.31187788),
        dec: Angle.Degrees(-01.67938908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98833",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98833"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.844,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.05653114),
        dec: Angle.Degrees(-01.67904275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40901"},
        {"Hipparcos Number", "HIP 28567"},
        {"Smithsonian Astrophysical Observation", "SAO 132752"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.43638323),
        dec: Angle.Degrees(-01.67827664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15607"},
        {"Hipparcos Number", "HIP 11669"},
        {"Geneva Identification System", "GEN# +1.00015607"},
        {"Smithsonian Astrophysical Observation", "SAO 129947"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.63435416),
        dec: Angle.Degrees(-01.67144924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189739"},
        {"Hipparcos Number", "HIP 98597"},
        {"Smithsonian Astrophysical Observation", "SAO 143998"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.40408956),
        dec: Angle.Degrees(-01.67122245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88083"},
        {"Hipparcos Number", "HIP 49753"},
        {"Smithsonian Astrophysical Observation", "SAO 137376"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.34507483),
        dec: Angle.Degrees(-01.66821265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37272"},
        {"Hipparcos Number", "HIP 26405"},
        {"Celescope Catalog", "CEL 865"},
        {"Geneva Identification System", "GEN# +1.00037272"},
        {"Smithsonian Astrophysical Observation", "SAO 132369"},
    },
    visualMagnitude: 7.89,
    bvColour: -0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.31051387),
        dec: Angle.Degrees(-01.66772148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22008"},
        {"Hipparcos Number", "HIP 16519"},
        {"Geneva Identification System", "GEN# +1.00022008"},
        {"Smithsonian Astrophysical Observation", "SAO 130558"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.17424482),
        dec: Angle.Degrees(-01.66770419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74510",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74510"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.787,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.39469386),
        dec: Angle.Degrees(-01.66676972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29850"},
        {"Hipparcos Number", "HIP 21870"},
        {"Fundamental Katalog 5th Edition", "FK5 4420"},
        {"Smithsonian Astrophysical Observation", "SAO 131417"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.53618544),
        dec: Angle.Degrees(-01.66492738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49910",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49910"},
    },
    visualMagnitude: 11.82,
    bvColour: 1.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.84940322),
        dec: Angle.Degrees(-01.66237169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -254.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121909"},
        {"Hipparcos Number", "HIP 68258"},
        {"Geneva Identification System", "GEN# +1.00121909"},
        {"Wilson Evans Batten Catalogue", "WEB 11973"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.60357760),
        dec: Angle.Degrees(-01.66080600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223928"},
        {"Hipparcos Number", "HIP 117820"},
        {"Smithsonian Astrophysical Observation", "SAO 146960"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.42229309),
        dec: Angle.Degrees(-01.66074512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5919"},
        {"Hipparcos Number", "HIP 4726"},
        {"Fundamental Katalog 5th Edition", "FK5 4094"},
        {"Geneva Identification System", "GEN# +1.00005919"},
        {"Smithsonian Astrophysical Observation", "SAO 129076"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.16833516),
        dec: Angle.Degrees(-01.65857625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65083",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65083"},
        {"Geneva Identification System", "GEN# +9.80014047"},
    },
    visualMagnitude: 11.60,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.10360789),
        dec: Angle.Degrees(-01.65689717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 128.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -250.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83738",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10347 A"},
        {"Henry Draper", "HD 154660"},
        {"Hipparcos Number", "HIP 83738"},
        {"Geneva Identification System", "GEN# +1.00154660A"},
        {"Smithsonian Astrophysical Observation", "SAO 141522"},
        {"Wilson Evans Batten Catalogue", "WEB 14160"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.72057683),
        dec: Angle.Degrees(-01.65611713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56966"},
        {"Hipparcos Number", "HIP 35455"},
        {"Geneva Identification System", "GEN# +1.00056966"},
        {"Smithsonian Astrophysical Observation", "SAO 134504"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.79241282),
        dec: Angle.Degrees(-01.65577058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55288",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8131 AB"},
        {"Henry Draper", "HD 98427"},
        {"Hipparcos Number", "HIP 55288"},
        {"Wilson Evans Batten Catalogue", "WEB 9960"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.84486130),
        dec: Angle.Degrees(-01.65451504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -221.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -152.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210862"},
        {"Hipparcos Number", "HIP 109717"},
        {"Geneva Identification System", "GEN# +1.00210862"},
        {"Smithsonian Astrophysical Observation", "SAO 145948"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.35532362),
        dec: Angle.Degrees(-01.65365207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 122.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1293"},
        {"Hipparcos Number", "HIP 1365"},
        {"Geneva Identification System", "GEN# +1.00001293"},
        {"Smithsonian Astrophysical Observation", "SAO 128677"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.787,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.27306032),
        dec: Angle.Degrees(-01.65304096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157856"},
        {"Hipparcos Number", "HIP 85307"},
        {"Fundamental Katalog 5th Edition", "FK5 1458"},
        {"Geneva Identification System", "GEN# +1.00157856"},
        {"Smithsonian Astrophysical Observation", "SAO 141661"},
        {"Wilson Evans Batten Catalogue", "WEB 14403"},
    },
    visualMagnitude: 6.44,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.49100049),
        dec: Angle.Degrees(-01.65190384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79729",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9984 B"},
        {"Hipparcos Number", "HIP 79729"},
    },
    visualMagnitude: 8.61,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)16, 18.6900),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)39, 06.200)
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
    primaryId: "HIP 78613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143876"},
        {"Hipparcos Number", "HIP 78613"},
        {"Smithsonian Astrophysical Observation", "SAO 140917"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.74196913),
        dec: Angle.Degrees(-01.64949638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79730",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9984 A"},
        {"Henry Draper", "HD 146433"},
        {"Hipparcos Number", "HIP 79730"},
        {"Geneva Identification System", "GEN# +1.00146433"},
        {"Smithsonian Astrophysical Observation", "SAO 141069"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.08198666),
        dec: Angle.Degrees(-01.64820342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -123.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67208"},
        {"Hipparcos Number", "HIP 39701"},
        {"Smithsonian Astrophysical Observation", "SAO 135514"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.71613839),
        dec: Angle.Degrees(-01.64808028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173003"},
        {"Hipparcos Number", "HIP 91822"},
        {"Geneva Identification System", "GEN# +1.00173003"},
        {"Smithsonian Astrophysical Observation", "SAO 142542"},
        {"Wilson Evans Batten Catalogue", "WEB 15799"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.82477278),
        dec: Angle.Degrees(-01.64562819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50169"},
        {"Hipparcos Number", "HIP 32965"},
        {"Geneva Identification System", "GEN# +1.00050169"},
        {"Renson", "Renson 13700"},
        {"Smithsonian Astrophysical Observation", "SAO 133794"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.99679986),
        dec: Angle.Degrees(-01.64455410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24580",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3857 AB"},
        {"Henry Draper", "HD 34307"},
        {"Hipparcos Number", "HIP 24580"},
        {"Smithsonian Astrophysical Observation", "SAO 131929"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.10288595),
        dec: Angle.Degrees(-01.64202364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106352"},
        {"Hipparcos Number", "HIP 59669"},
        {"Geneva Identification System", "GEN# +1.00106352"},
        {"Smithsonian Astrophysical Observation", "SAO 138663"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.54388369),
        dec: Angle.Degrees(-01.64190476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18013"},
        {"Hipparcos Number", "HIP 13478"},
        {"Geneva Identification System", "GEN# +1.00018013"},
        {"Smithsonian Astrophysical Observation", "SAO 130171"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.39648960),
        dec: Angle.Degrees(-01.64103113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212875"},
        {"Hipparcos Number", "HIP 110848"},
        {"Smithsonian Astrophysical Observation", "SAO 146099"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.85939536),
        dec: Angle.Degrees(-01.64087935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116997",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116997"},
        {"Smithsonian Astrophysical Observation", "SAO 146859"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.77989563),
        dec: Angle.Degrees(-01.64015575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135105"},
        {"Hipparcos Number", "HIP 74502"},
        {"Smithsonian Astrophysical Observation", "SAO 140387"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.37411576),
        dec: Angle.Degrees(-01.63997004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 289905"},
        {"Hipparcos Number", "HIP 23503"},
        {"Smithsonian Astrophysical Observation", "SAO 131722"},
    },
    visualMagnitude: 10.79,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.80612021),
        dec: Angle.Degrees(-01.63916693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191316"},
        {"Hipparcos Number", "HIP 99300"},
        {"Smithsonian Astrophysical Observation", "SAO 144116"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.35043856),
        dec: Angle.Degrees(-01.63817183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37149"},
        {"Hipparcos Number", "HIP 26319"},
        {"Celescope Catalog", "CEL 854"},
        {"Geneva Identification System", "GEN# +9.00040010"},
        {"Renson", "Renson 9920"},
        {"Smithsonian Astrophysical Observation", "SAO 132350"},
    },
    visualMagnitude: 8.01,
    bvColour: -0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.07430320),
        dec: Angle.Degrees(-01.63532828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170818"},
        {"Hipparcos Number", "HIP 90810"},
        {"Geneva Identification System", "GEN# +1.00170818"},
        {"Smithsonian Astrophysical Observation", "SAO 142364"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.87074570),
        dec: Angle.Degrees(-01.63481332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125633"},
        {"Hipparcos Number", "HIP 70106"},
        {"Smithsonian Astrophysical Observation", "SAO 139877"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.18279634),
        dec: Angle.Degrees(-01.63290508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25414"},
        {"Hipparcos Number", "HIP 18837"},
        {"Geneva Identification System", "GEN# +1.00025414"},
        {"Smithsonian Astrophysical Observation", "SAO 130884"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.57144737),
        dec: Angle.Degrees(-01.63263279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5956",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5956"},
        {"Smithsonian Astrophysical Observation", "SAO 129205"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.15909268),
        dec: Angle.Degrees(-01.63142257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104676"},
        {"Hipparcos Number", "HIP 58773"},
        {"Smithsonian Astrophysical Observation", "SAO 138554"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.81436032),
        dec: Angle.Degrees(-01.62947743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102377"},
        {"Hipparcos Number", "HIP 57485"},
        {"Geneva Identification System", "GEN# +1.00102377"},
        {"Smithsonian Astrophysical Observation", "SAO 138402"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.75018327),
        dec: Angle.Degrees(-01.62939140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24313"},
        {"Hipparcos Number", "HIP 18092"},
        {"Geneva Identification System", "GEN# +1.00024313"},
        {"Smithsonian Astrophysical Observation", "SAO 130779"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.00407755),
        dec: Angle.Degrees(-01.62823318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4720"},
        {"Hipparcos Number", "HIP 3842"},
        {"Geneva Identification System", "GEN# +1.00004720"},
        {"Smithsonian Astrophysical Observation", "SAO 128968"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.32426163),
        dec: Angle.Degrees(-01.62599547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144706"},
        {"Hipparcos Number", "HIP 78972"},
        {"Smithsonian Astrophysical Observation", "SAO 140970"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.82128748),
        dec: Angle.Degrees(-01.62529799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12514"},
        {"Hipparcos Number", "HIP 9545"},
        {"Smithsonian Astrophysical Observation", "SAO 129646"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.66818025),
        dec: Angle.Degrees(-01.62449669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26083"},
        {"Hipparcos Number", "HIP 19260"},
        {"Smithsonian Astrophysical Observation", "SAO 130965"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.92390467),
        dec: Angle.Degrees(-01.62165658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149180"},
        {"Hipparcos Number", "HIP 81051"},
        {"Smithsonian Astrophysical Observation", "SAO 141236"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.30763820),
        dec: Angle.Degrees(-01.61928500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163015"},
        {"Hipparcos Number", "HIP 87633"},
        {"Geneva Identification System", "GEN# +1.00163015"},
        {"Smithsonian Astrophysical Observation", "SAO 141952"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.51539348),
        dec: Angle.Degrees(-01.61926406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94729"},
        {"Hipparcos Number", "HIP 53454"},
        {"Geneva Identification System", "GEN# +1.00094729"},
        {"Smithsonian Astrophysical Observation", "SAO 137895"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.02189120),
        dec: Angle.Degrees(-01.61806824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -123.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73836"},
        {"Hipparcos Number", "HIP 42547"},
        {"Smithsonian Astrophysical Observation", "SAO 136154"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.09210741),
        dec: Angle.Degrees(-01.61783425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181148"},
        {"Hipparcos Number", "HIP 94960"},
        {"Wilson Evans Batten Catalogue", "WEB 16582"},
    },
    visualMagnitude: 10.55,
    bvColour: 1.814,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.86041720),
        dec: Angle.Degrees(-01.61603693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 156.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 98.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65478"},
        {"Hipparcos Number", "HIP 38997"},
        {"Smithsonian Astrophysical Observation", "SAO 135323"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.71792203),
        dec: Angle.Degrees(-01.61550443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145247"},
        {"Hipparcos Number", "HIP 79206"},
        {"Geneva Identification System", "GEN# +1.00145247"},
        {"Smithsonian Astrophysical Observation", "SAO 141003"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.49531985),
        dec: Angle.Degrees(-01.61538321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38406"},
        {"Hipparcos Number", "HIP 27161"},
        {"Geneva Identification System", "GEN# +1.00038406"},
        {"Smithsonian Astrophysical Observation", "SAO 132512"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.36965210),
        dec: Angle.Degrees(-01.61496744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 134.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 290850"},
        {"Hipparcos Number", "HIP 27084"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.13865041),
        dec: Angle.Degrees(-01.61470728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38099"},
        {"Hipparcos Number", "HIP 26953"},
        {"Geneva Identification System", "GEN# +1.00038099"},
        {"Smithsonian Astrophysical Observation", "SAO 132480"},
        {"Wilson Evans Batten Catalogue", "WEB 5314"},
    },
    visualMagnitude: 6.31,
    bvColour: 1.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.78881564),
        dec: Angle.Degrees(-01.61317771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65176"},
        {"Hipparcos Number", "HIP 38882"},
        {"Geneva Identification System", "GEN# +1.00065176"},
        {"Smithsonian Astrophysical Observation", "SAO 135293"},
        {"Wilson Evans Batten Catalogue", "WEB 7617"},
    },
    visualMagnitude: 8.05,
    bvColour: -0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.35485365),
        dec: Angle.Degrees(-01.61288050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152569"},
        {"Hipparcos Number", "HIP 82693"},
        {"Geneva Identification System", "GEN# +1.00152569"},
        {"Smithsonian Astrophysical Observation", "SAO 141427"},
        {"Wilson Evans Batten Catalogue", "WEB 13969"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.54416698),
        dec: Angle.Degrees(-01.61210963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63778"},
        {"Hipparcos Number", "HIP 38280"},
        {"Geneva Identification System", "GEN# +1.00063778"},
        {"Smithsonian Astrophysical Observation", "SAO 135161"},
    },
    visualMagnitude: 7.99,
    bvColour: -0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.64273431),
        dec: Angle.Degrees(-01.60977064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205042"},
        {"Hipparcos Number", "HIP 106375"},
        {"Smithsonian Astrophysical Observation", "SAO 145475"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.16853732),
        dec: Angle.Degrees(-01.60823401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202554"},
        {"Hipparcos Number", "HIP 105046"},
        {"Geneva Identification System", "GEN# +1.00202554"},
        {"Smithsonian Astrophysical Observation", "SAO 145259"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.16440667),
        dec: Angle.Degrees(-01.60771816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75685"},
        {"Hipparcos Number", "HIP 43482"},
        {"Smithsonian Astrophysical Observation", "SAO 136340"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.85388283),
        dec: Angle.Degrees(-01.60617285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46721",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46721"},
        {"Smithsonian Astrophysical Observation", "SAO 136924"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.85783965),
        dec: Angle.Degrees(-01.60562236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159447"},
        {"Hipparcos Number", "HIP 86028"},
        {"Geneva Identification System", "GEN# +1.00159447"},
        {"Smithsonian Astrophysical Observation", "SAO 141741"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.71964154),
        dec: Angle.Degrees(-01.60518169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40941",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6762 AB"},
        {"Henry Draper", "HD 70340"},
        {"Hipparcos Number", "HIP 40941"},
        {"Geneva Identification System", "GEN# +1.00070340J"},
        {"Renson", "Renson 19430"},
        {"Smithsonian Astrophysical Observation", "SAO 135804"},
        {"Wilson Evans Batten Catalogue", "WEB 7936"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.33454006),
        dec: Angle.Degrees(-01.60196051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10276"},
        {"Hipparcos Number", "HIP 7810"},
        {"Geneva Identification System", "GEN# +1.00010276"},
        {"Smithsonian Astrophysical Observation", "SAO 129440"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.11233526),
        dec: Angle.Degrees(-01.60162886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101093"},
        {"Hipparcos Number", "HIP 56738"},
        {"Geneva Identification System", "GEN# +1.00101093"},
        {"Smithsonian Astrophysical Observation", "SAO 138313"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.49700761),
        dec: Angle.Degrees(-01.59975481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -305.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 131.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6967"},
        {"Hipparcos Number", "HIP 5474"},
        {"Smithsonian Astrophysical Observation", "SAO 129151"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.52465745),
        dec: Angle.Degrees(-01.59883915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19363"},
        {"Hipparcos Number", "HIP 14470"},
        {"Smithsonian Astrophysical Observation", "SAO 130287"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.68839417),
        dec: Angle.Degrees(-01.59881972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135993"},
        {"Hipparcos Number", "HIP 74889"},
        {"Smithsonian Astrophysical Observation", "SAO 140441"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.763,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.57182528),
        dec: Angle.Degrees(-01.59834866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89026"},
        {"Hipparcos Number", "HIP 50291"},
        {"Smithsonian Astrophysical Observation", "SAO 137448"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.03306886),
        dec: Angle.Degrees(-01.59777675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211356"},
        {"Hipparcos Number", "HIP 109984"},
        {"Geneva Identification System", "GEN# +1.00211356"},
        {"Smithsonian Astrophysical Observation", "SAO 145989"},
    },
    visualMagnitude: 6.16,
    bvColour: 0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.14029753),
        dec: Angle.Degrees(-01.59636796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35583",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6001 AB"},
        {"Henry Draper", "HD 57293"},
        {"Hipparcos Number", "HIP 35583"},
        {"Smithsonian Astrophysical Observation", "SAO 134537"},
    },
    visualMagnitude: 8.01,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.14824726),
        dec: Angle.Degrees(-01.59600821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66640"},
        {"Hipparcos Number", "HIP 39502"},
        {"Geneva Identification System", "GEN# +1.00066640"},
        {"Renson", "Renson 18415"},
        {"Smithsonian Astrophysical Observation", "SAO 135448"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.11528186),
        dec: Angle.Degrees(-01.59513293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115302",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115302"},
        {"Cincinnati Publication", "Ci 20 1420"},
    },
    visualMagnitude: 11.76,
    bvColour: 1.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.29716594),
        dec: Angle.Degrees(-01.59499067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -138.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -347.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156927"},
        {"Hipparcos Number", "HIP 84841"},
        {"Smithsonian Astrophysical Observation", "SAO 141616"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.09738416),
        dec: Angle.Degrees(-01.59288658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120352"},
        {"Hipparcos Number", "HIP 67412"},
        {"Smithsonian Astrophysical Observation", "SAO 139570"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.24280069),
        dec: Angle.Degrees(-01.59284811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -133.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136118"},
        {"Hipparcos Number", "HIP 74948"},
        {"Geneva Identification System", "GEN# +1.00136118"},
        {"Smithsonian Astrophysical Observation", "SAO 140452"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.73143435),
        dec: Angle.Degrees(-01.59244330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -124.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22797"},
        {"Hipparcos Number", "HIP 17097"},
        {"Geneva Identification System", "GEN# +1.00022797"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.93514197),
        dec: Angle.Degrees(-01.59240220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20703"},
        {"Hipparcos Number", "HIP 15524"},
        {"Geneva Identification System", "GEN# +1.00020703"},
        {"Smithsonian Astrophysical Observation", "SAO 130423"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.00916343),
        dec: Angle.Degrees(-01.59214588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25980",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4141 AB"},
        {"Henry Draper", "HD 36591"},
        {"Hipparcos Number", "HIP 25980"},
        {"Celescope Catalog", "CEL 776"},
        {"Geneva Identification System", "GEN# +1.00036591"},
        {"Geneva Identification System 2", "GEN# +9.00040001"},
        {"Geneva Identification System 3", "GEN# +9.04000110"},
        {"Geneva Identification System 4", "GEN# +9.00040001D"},
        {"Smithsonian Astrophysical Observation", "SAO 132234"},
        {"Wilson Evans Batten Catalogue", "WEB 5054"},
    },
    visualMagnitude: 5.34,
    bvColour: -0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.17231020),
        dec: Angle.Degrees(-01.59183293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106351"},
        {"Hipparcos Number", "HIP 59668"},
        {"Smithsonian Astrophysical Observation", "SAO 138662"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.54081284),
        dec: Angle.Degrees(-01.59083023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45655"},
        {"Hipparcos Number", "HIP 30832"},
        {"Geneva Identification System", "GEN# +1.00045655"},
        {"Smithsonian Astrophysical Observation", "SAO 133305"},
    },
    visualMagnitude: 7.78,
    bvColour: -0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.14974530),
        dec: Angle.Degrees(-01.58959148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78495",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78495"},
        {"Smithsonian Astrophysical Observation", "SAO 140901"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.36149928),
        dec: Angle.Degrees(-01.58938682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78610"},
        {"Hipparcos Number", "HIP 44931"},
        {"Geneva Identification System", "GEN# +1.00078610"},
        {"Smithsonian Astrophysical Observation", "SAO 136612"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.28595851),
        dec: Angle.Degrees(-01.58781930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79566"},
        {"Hipparcos Number", "HIP 45378"},
        {"Fundamental Katalog 5th Edition", "FK5 2732"},
        {"Geneva Identification System", "GEN# +1.00079566"},
        {"Smithsonian Astrophysical Observation", "SAO 136687"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.71662528),
        dec: Angle.Degrees(-01.58709449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114914",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16642 AB"},
        {"Henry Draper", "HD 219542"},
        {"Hipparcos Number", "HIP 114914"},
        {"Smithsonian Astrophysical Observation", "SAO 146605"},
        {"Wilson Evans Batten Catalogue", "WEB 20362"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.14642505),
        dec: Angle.Degrees(-01.58657079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 163.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27839"},
        {"Hipparcos Number", "HIP 20490"},
        {"Smithsonian Astrophysical Observation", "SAO 131172"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.87480944),
        dec: Angle.Degrees(-01.58570313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51106"},
        {"Hipparcos Number", "HIP 33328"},
        {"Geneva Identification System", "GEN# +1.00051106"},
        {"Renson", "Renson 14080"},
        {"Smithsonian Astrophysical Observation", "SAO 133907"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.97604267),
        dec: Angle.Degrees(-01.58541043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41381"},
        {"Hipparcos Number", "HIP 28792"},
        {"Geneva Identification System", "GEN# +1.00041381"},
        {"Smithsonian Astrophysical Observation", "SAO 132803"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.17853448),
        dec: Angle.Degrees(-01.58042231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200433"},
        {"Hipparcos Number", "HIP 103931"},
        {"Fundamental Katalog 5th Edition", "FK5 3678"},
        {"Geneva Identification System", "GEN# +1.00200433"},
        {"Smithsonian Astrophysical Observation", "SAO 145058"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.87289175),
        dec: Angle.Degrees(-01.57964646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90253",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11324 AB"},
        {"Henry Draper", "HD 169493"},
        {"Hipparcos Number", "HIP 90253"},
        {"Geneva Identification System", "GEN# +1.00169493J"},
        {"Smithsonian Astrophysical Observation", "SAO 142294"},
        {"Wilson Evans Batten Catalogue", "WEB 15437"},
    },
    visualMagnitude: 6.15,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.23835484),
        dec: Angle.Degrees(-01.57940317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120203"},
        {"Hipparcos Number", "HIP 67339"},
        {"Smithsonian Astrophysical Observation", "SAO 139557"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.02559541),
        dec: Angle.Degrees(-01.57851503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151123"},
        {"Hipparcos Number", "HIP 82040"},
        {"Smithsonian Astrophysical Observation", "SAO 141347"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.37987279),
        dec: Angle.Degrees(-01.57817901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110646"},
        {"Hipparcos Number", "HIP 62103"},
        {"Geneva Identification System", "GEN# +1.00110646"},
        {"Smithsonian Astrophysical Observation", "SAO 138933"},
        {"Wilson Evans Batten Catalogue", "WEB 11038"},
    },
    visualMagnitude: 5.91,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.90842535),
        dec: Angle.Degrees(-01.57681459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213789"},
        {"Hipparcos Number", "HIP 111394"},
        {"Geneva Identification System", "GEN# +1.00213789"},
        {"Smithsonian Astrophysical Observation", "SAO 146160"},
        {"Wilson Evans Batten Catalogue", "WEB 19920"},
    },
    visualMagnitude: 5.88,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.51203705),
        dec: Angle.Degrees(-01.57417924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18360"},
        {"Hipparcos Number", "HIP 13744"},
        {"Smithsonian Astrophysical Observation", "SAO 130203"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.23632405),
        dec: Angle.Degrees(-01.57307122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10213",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10213"},
        {"Smithsonian Astrophysical Observation", "SAO 129737"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.83947721),
        dec: Angle.Degrees(-01.57253587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18462",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2886 AB"},
        {"Henry Draper", "HD 24819"},
        {"Hipparcos Number", "HIP 18462"},
        {"Smithsonian Astrophysical Observation", "SAO 130832"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.17930749),
        dec: Angle.Degrees(-01.57183282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125962"},
        {"Hipparcos Number", "HIP 70285"},
        {"Smithsonian Astrophysical Observation", "SAO 139903"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.70445521),
        dec: Angle.Degrees(-01.57152861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 291763"},
        {"Hipparcos Number", "HIP 31085"},
        {"Cincinnati Publication", "Ci 20 391"},
        {"Geneva Identification System", "GEN# +1.00291763"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.849,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.84690517),
        dec: Angle.Degrees(-01.56986259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -248.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -342.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140893"},
        {"Hipparcos Number", "HIP 77234"},
        {"Smithsonian Astrophysical Observation", "SAO 140743"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.54924882),
        dec: Angle.Degrees(-01.56939508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22420"},
        {"Hipparcos Number", "HIP 16809"},
        {"Smithsonian Astrophysical Observation", "SAO 130603"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.09035767),
        dec: Angle.Degrees(-01.56850157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72659"},
        {"Hipparcos Number", "HIP 42030"},
        {"Geneva Identification System", "GEN# +1.00072659"},
        {"Smithsonian Astrophysical Observation", "SAO 136045"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.51356616),
        dec: Angle.Degrees(-01.56797850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68173"},
        {"Hipparcos Number", "HIP 40080"},
        {"Smithsonian Astrophysical Observation", "SAO 135599"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.80490061),
        dec: Angle.Degrees(-01.56635514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33819"},
        {"Hipparcos Number", "HIP 24297"},
        {"Smithsonian Astrophysical Observation", "SAO 131872"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.20839144),
        dec: Angle.Degrees(-01.56370000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10912",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10912"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.12032485),
        dec: Angle.Degrees(-01.56129999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1843",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1843"},
    },
    visualMagnitude: 9.99,
    bvColour: 1.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.82762106),
        dec: Angle.Degrees(-01.55953600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173074"},
        {"Hipparcos Number", "HIP 91855"},
        {"Geneva Identification System", "GEN# +1.00173074"},
        {"Smithsonian Astrophysical Observation", "SAO 142553"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.887,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.90570489),
        dec: Angle.Degrees(-01.55901096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194764"},
        {"Hipparcos Number", "HIP 100889"},
        {"Geneva Identification System", "GEN# +1.00194764"},
        {"Smithsonian Astrophysical Observation", "SAO 144448"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.85494780),
        dec: Angle.Degrees(-01.55852645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50922",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50922"},
    },
    visualMagnitude: 9.96,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.99136247),
        dec: Angle.Degrees(-01.55774456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173198"},
        {"Hipparcos Number", "HIP 91910"},
        {"Celescope Catalog", "CEL 4645"},
        {"Geneva Identification System", "GEN# +1.00173198"},
        {"Smithsonian Astrophysical Observation", "SAO 142563"},
        {"Wilson Evans Batten Catalogue", "WEB 15822"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.05328742),
        dec: Angle.Degrees(-01.55430855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174647"},
        {"Hipparcos Number", "HIP 92546"},
        {"Smithsonian Astrophysical Observation", "SAO 142710"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.88898975),
        dec: Angle.Degrees(-01.55298103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 99.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61726",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61726"},
    },
    visualMagnitude: 10.20,
    bvColour: 1.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.78601019),
        dec: Angle.Degrees(-01.55186691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -159.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56632"},
        {"Hipparcos Number", "HIP 35322"},
        {"Geneva Identification System", "GEN# +1.00056632"},
        {"Renson", "Renson 15450"},
        {"Smithsonian Astrophysical Observation", "SAO 134476"},
    },
    visualMagnitude: 8.48,
    bvColour: -0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.44095320),
        dec: Angle.Degrees(-01.54991377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25340"},
        {"Hipparcos Number", "HIP 18788"},
        {"Fundamental Katalog 5th Edition", "FK5 1111"},
        {"Geneva Identification System", "GEN# +1.00025340"},
        {"Smithsonian Astrophysical Observation", "SAO 130878"},
        {"Wilson Evans Batten Catalogue", "WEB 3617"},
    },
    visualMagnitude: 5.28,
    bvColour: -0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.38347446),
        dec: Angle.Degrees(-01.54962625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78971"},
        {"Hipparcos Number", "HIP 45087"},
        {"Geneva Identification System", "GEN# +1.00078971"},
        {"Smithsonian Astrophysical Observation", "SAO 136644"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.76974104),
        dec: Angle.Degrees(-01.54925125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175152"},
        {"Hipparcos Number", "HIP 92770"},
        {"Smithsonian Astrophysical Observation", "SAO 142776"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.55728223),
        dec: Angle.Degrees(-01.54672557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35008"},
        {"Hipparcos Number", "HIP 25025"},
        {"Geneva Identification System", "GEN# +1.00035008"},
        {"Renson", "Renson 8940"},
        {"Smithsonian Astrophysical Observation", "SAO 132023"},
    },
    visualMagnitude: 7.11,
    bvColour: -0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.36847503),
        dec: Angle.Degrees(-01.54623504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113068",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113068"},
        {"Smithsonian Astrophysical Observation", "SAO 146377"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.49870333),
        dec: Angle.Degrees(-01.54516203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 167.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64351",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64351"},
    },
    visualMagnitude: 10.18,
    bvColour: 1.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.85974437),
        dec: Angle.Degrees(-01.54339887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204951"},
        {"Hipparcos Number", "HIP 106325"},
        {"Geneva Identification System", "GEN# +1.00204951"},
        {"Smithsonian Astrophysical Observation", "SAO 145468"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.02164621),
        dec: Angle.Degrees(-01.54283241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13963",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13963"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.813,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.95341255),
        dec: Angle.Degrees(-01.54245917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61862"},
        {"Hipparcos Number", "HIP 37455"},
        {"Geneva Identification System", "GEN# +1.00061862"},
        {"Smithsonian Astrophysical Observation", "SAO 134985"},
    },
    visualMagnitude: 8.11,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.32740043),
        dec: Angle.Degrees(-01.54169540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75262",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9613 B"},
        {"Hipparcos Number", "HIP 75262"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.792,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.66757903),
        dec: Angle.Degrees(-01.54161016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194245"},
        {"Hipparcos Number", "HIP 100671"},
        {"Smithsonian Astrophysical Observation", "SAO 144397"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.17365389),
        dec: Angle.Degrees(-01.54125568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94253"},
        {"Hipparcos Number", "HIP 53180"},
        {"Smithsonian Astrophysical Observation", "SAO 137855"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.17413645),
        dec: Angle.Degrees(-01.53808821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168780"},
        {"Hipparcos Number", "HIP 89986"},
        {"Smithsonian Astrophysical Observation", "SAO 142245"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.738,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.39872971),
        dec: Angle.Degrees(-01.53732131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -147.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54054"},
        {"Hipparcos Number", "HIP 34363"},
        {"Smithsonian Astrophysical Observation", "SAO 134216"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.84643666),
        dec: Angle.Degrees(-01.53681119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23876"},
        {"Hipparcos Number", "HIP 17786"},
        {"Smithsonian Astrophysical Observation", "SAO 130736"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.10384962),
        dec: Angle.Degrees(-01.53648449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75261",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9613 A"},
        {"Henry Draper", "HD 136799"},
        {"Hipparcos Number", "HIP 75261"},
        {"Smithsonian Astrophysical Observation", "SAO 140492"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.66445615),
        dec: Angle.Degrees(-01.53579820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187694"},
        {"Hipparcos Number", "HIP 97704"},
        {"Smithsonian Astrophysical Observation", "SAO 143858"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.84296588),
        dec: Angle.Degrees(-01.53502145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 191.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204663"},
        {"Hipparcos Number", "HIP 106161"},
        {"Fundamental Katalog 5th Edition", "FK5 5898"},
        {"Geneva Identification System", "GEN# +1.00204663"},
        {"Smithsonian Astrophysical Observation", "SAO 145445"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.55904287),
        dec: Angle.Degrees(-01.53446540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202851"},
        {"Hipparcos Number", "HIP 105212"},
        {"Geneva Identification System", "GEN# +1.00202851"},
        {"Smithsonian Astrophysical Observation", "SAO 145286"},
    },
    visualMagnitude: 9.71,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.68119808),
        dec: Angle.Degrees(-01.53415586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11062"},
        {"Hipparcos Number", "HIP 8425"},
        {"Smithsonian Astrophysical Observation", "SAO 129510"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.16209329),
        dec: Angle.Degrees(-01.53102136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74164",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74164"},
    },
    visualMagnitude: 11.15,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.30571790),
        dec: Angle.Degrees(-01.52932379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -157.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 113.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55664",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Shama"},
        {"Henry Draper", "HD 99109"},
        {"Hipparcos Number", "HIP 55664"},
        {"Cincinnati Publication", "Ci 18 1395"},
        {"Smithsonian Astrophysical Observation", "SAO 138182"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.874,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.07276204),
        dec: Angle.Degrees(-01.52868584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -179.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -160.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22697"},
        {"Hipparcos Number", "HIP 17017"},
        {"Geneva Identification System", "GEN# +1.00022697"},
        {"Smithsonian Astrophysical Observation", "SAO 130631"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.72718695),
        dec: Angle.Degrees(-01.52542754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213949"},
        {"Hipparcos Number", "HIP 111474"},
        {"Geneva Identification System", "GEN# +1.00213949"},
        {"Smithsonian Astrophysical Observation", "SAO 146177"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.77560903),
        dec: Angle.Degrees(-01.52471520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38506"},
        {"Hipparcos Number", "HIP 27226"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.55180183),
        dec: Angle.Degrees(-01.52351310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1229"},
        {"Hipparcos Number", "HIP 1321"},
        {"Smithsonian Astrophysical Observation", "SAO 128673"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.14652083),
        dec: Angle.Degrees(-01.52310661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -102.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223083"},
        {"Hipparcos Number", "HIP 117261"},
        {"Smithsonian Astrophysical Observation", "SAO 146899"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.64473940),
        dec: Angle.Degrees(-01.52283144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24098"},
        {"Hipparcos Number", "HIP 17950"},
        {"Smithsonian Astrophysical Observation", "SAO 130762"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.56710121),
        dec: Angle.Degrees(-01.52263503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 102.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37335",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37335"},
        {"Cincinnati Publication", "Ci 18 917"},
        {"Geneva Identification System", "GEN# -0.00101792"},
        {"Smithsonian Astrophysical Observation", "SAO 134948"},
        {"Wilson Evans Batten Catalogue", "WEB 7388"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.95834583),
        dec: Angle.Degrees(-01.52173256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 186.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -243.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115012",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16649 AB"},
        {"Henry Draper", "HD 219657"},
        {"Hipparcos Number", "HIP 115012"},
        {"Cincinnati Publication", "Ci 18 3049"},
        {"Geneva Identification System", "GEN# +1.00219657"},
        {"Smithsonian Astrophysical Observation", "SAO 146617"},
        {"Wilson Evans Batten Catalogue", "WEB 20373"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.40611593),
        dec: Angle.Degrees(-01.52151756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 260.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222038"},
        {"Hipparcos Number", "HIP 116559"},
        {"Smithsonian Astrophysical Observation", "SAO 146807"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.783,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.32234779),
        dec: Angle.Degrees(-01.51980809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94500"},
        {"Hipparcos Number", "HIP 53342"},
        {"Geneva Identification System", "GEN# +1.00094500"},
        {"Smithsonian Astrophysical Observation", "SAO 137875"},
        {"Wilson Evans Batten Catalogue", "WEB 9685"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.64214568),
        dec: Angle.Degrees(-01.51860852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123693"},
        {"Hipparcos Number", "HIP 69145"},
    },
    visualMagnitude: 9.80,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.32499995),
        dec: Angle.Degrees(-01.51548187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177552"},
        {"Hipparcos Number", "HIP 93743"},
        {"Geneva Identification System", "GEN# +1.00177552"},
        {"Renson", "Renson 49513"},
        {"Smithsonian Astrophysical Observation", "SAO 143003"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.32740300),
        dec: Angle.Degrees(-01.51222647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53647"},
        {"Hipparcos Number", "HIP 34225"},
        {"Smithsonian Astrophysical Observation", "SAO 134176"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.43315637),
        dec: Angle.Degrees(-01.51154008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17548"},
        {"Hipparcos Number", "HIP 13128"},
        {"Geneva Identification System", "GEN# +1.00017548"},
        {"Smithsonian Astrophysical Observation", "SAO 130125"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.21603269),
        dec: Angle.Degrees(-01.51006676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 171.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156617"},
        {"Hipparcos Number", "HIP 84676"},
        {"Geneva Identification System", "GEN# +1.00156617"},
        {"Smithsonian Astrophysical Observation", "SAO 141601"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.66388167),
        dec: Angle.Degrees(-01.51002896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -102.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104988"},
        {"Hipparcos Number", "HIP 58949"},
        {"Cincinnati Publication", "Ci 20 681"},
        {"Fundamental Katalog 5th Edition", "FK5 5066"},
        {"Geneva Identification System", "GEN# +1.00104988"},
        {"Smithsonian Astrophysical Observation", "SAO 138576"},
        {"Wilson Evans Batten Catalogue", "WEB 10498"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.754,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.30345160),
        dec: Angle.Degrees(-01.50917766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -512.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223177"},
        {"Hipparcos Number", "HIP 117323"},
        {"Geneva Identification System", "GEN# +1.00223177"},
        {"Smithsonian Astrophysical Observation", "SAO 146905"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.84395924),
        dec: Angle.Degrees(-01.50880143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17855",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2792 AB"},
        {"Henry Draper", "HD 23977"},
        {"Hipparcos Number", "HIP 17855"},
        {"Smithsonian Astrophysical Observation", "SAO 130745"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.31838838),
        dec: Angle.Degrees(-01.50869930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28785"},
        {"Hipparcos Number", "HIP 21161"},
        {"Geneva Identification System", "GEN# +1.00028785"},
        {"Smithsonian Astrophysical Observation", "SAO 131275"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.05076457),
        dec: Angle.Degrees(-01.50747331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113325"},
        {"Hipparcos Number", "HIP 63670"},
        {"Smithsonian Astrophysical Observation", "SAO 139118"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.73810131),
        dec: Angle.Degrees(-01.50727967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45320"},
        {"Hipparcos Number", "HIP 30666"},
        {"Celescope Catalog", "CEL 1239"},
        {"Fundamental Katalog 5th Edition", "FK5 2493"},
        {"Geneva Identification System", "GEN# +1.00045320"},
        {"Renson", "Renson 12000"},
        {"Smithsonian Astrophysical Observation", "SAO 133260"},
        {"Wilson Evans Batten Catalogue", "WEB 6117"},
    },
    visualMagnitude: 5.87,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.66496281),
        dec: Angle.Degrees(-01.50726444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37776"},
        {"Hipparcos Number", "HIP 26742"},
        {"Celescope Catalog", "CEL 923"},
        {"Geneva Identification System", "GEN# +1.00037776"},
        {"Renson", "Renson 10190"},
        {"Smithsonian Astrophysical Observation", "SAO 132446"},
        {"Wilson Evans Batten Catalogue", "WEB 5274"},
    },
    visualMagnitude: 6.99,
    bvColour: -0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.23486904),
        dec: Angle.Degrees(-01.50718617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22075"},
        {"Hipparcos Number", "HIP 16578"},
        {"Smithsonian Astrophysical Observation", "SAO 130566"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.35278358),
        dec: Angle.Degrees(-01.50706079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120878"},
        {"Hipparcos Number", "HIP 67709"},
        {"Smithsonian Astrophysical Observation", "SAO 139596"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.06566785),
        dec: Angle.Degrees(-01.50595305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116359",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116359"},
        {"Smithsonian Astrophysical Observation", "SAO 146784"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.66613488),
        dec: Angle.Degrees(-01.50582431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105349",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14863 AB"},
        {"Henry Draper", "HD 203115"},
        {"Hipparcos Number", "HIP 105349"},
        {"Smithsonian Astrophysical Observation", "SAO 145305"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.07809372),
        dec: Angle.Degrees(-01.50499492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111383"},
        {"Hipparcos Number", "HIP 62549"},
        {"Smithsonian Astrophysical Observation", "SAO 138977"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.24101204),
        dec: Angle.Degrees(-01.50435456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5337"},
        {"Hipparcos Number", "HIP 4314"},
        {"Smithsonian Astrophysical Observation", "SAO 129026"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.80685557),
        dec: Angle.Degrees(-01.50328708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121299"},
        {"Hipparcos Number", "HIP 67929"},
        {"Fundamental Katalog 5th Edition", "FK5 3107"},
        {"Geneva Identification System", "GEN# +1.00121299"},
        {"Smithsonian Astrophysical Observation", "SAO 139613"},
        {"Wilson Evans Batten Catalogue", "WEB 11934"},
    },
    visualMagnitude: 5.16,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.67581845),
        dec: Angle.Degrees(-01.50307142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38866"},
        {"Hipparcos Number", "HIP 27451"},
        {"Geneva Identification System", "GEN# +1.00038866"},
        {"Smithsonian Astrophysical Observation", "SAO 132557"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.18943854),
        dec: Angle.Degrees(-01.50190400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222634"},
        {"Hipparcos Number", "HIP 116949"},
        {"Geneva Identification System", "GEN# +1.00222634"},
        {"Smithsonian Astrophysical Observation", "SAO 146852"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.59076137),
        dec: Angle.Degrees(-01.50123593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192717"},
        {"Hipparcos Number", "HIP 99925"},
        {"Geneva Identification System", "GEN# +1.00192717"},
        {"Smithsonian Astrophysical Observation", "SAO 144231"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.10832155),
        dec: Angle.Degrees(-01.49972862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186590"},
        {"Hipparcos Number", "HIP 97207"},
        {"Smithsonian Astrophysical Observation", "SAO 143768"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.34451239),
        dec: Angle.Degrees(-01.49902321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70804"},
        {"Hipparcos Number", "HIP 41166"},
        {"Fundamental Katalog 5th Edition", "FK5 4755"},
        {"Geneva Identification System", "GEN# +1.00070804"},
        {"Smithsonian Astrophysical Observation", "SAO 135861"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.98415044),
        dec: Angle.Degrees(-01.49796486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6243"},
        {"Hipparcos Number", "HIP 4944"},
        {"Smithsonian Astrophysical Observation", "SAO 129095"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.85721064),
        dec: Angle.Degrees(-01.49529224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87650"},
        {"Hipparcos Number", "HIP 49493"},
        {"Smithsonian Astrophysical Observation", "SAO 137350"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.56696953),
        dec: Angle.Degrees(-01.49141098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35575"},
        {"Hipparcos Number", "HIP 25368"},
        {"Geneva Identification System", "GEN# +1.00035575"},
        {"Renson", "Renson 9160"},
        {"Smithsonian Astrophysical Observation", "SAO 132088"},
        {"Wilson Evans Batten Catalogue", "WEB 4917"},
    },
    visualMagnitude: 6.44,
    bvColour: -0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.40207153),
        dec: Angle.Degrees(-01.49129225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33327"},
        {"Hipparcos Number", "HIP 23990"},
        {"Geneva Identification System", "GEN# +1.00033327"},
        {"Smithsonian Astrophysical Observation", "SAO 131827"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.35342381),
        dec: Angle.Degrees(-01.49099293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110779"},
        {"Hipparcos Number", "HIP 62166"},
        {"Smithsonian Astrophysical Observation", "SAO 138944"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.10519421),
        dec: Angle.Degrees(-01.48958957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164761"},
        {"Hipparcos Number", "HIP 88377"},
        {"Smithsonian Astrophysical Observation", "SAO 142047"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.70500959),
        dec: Angle.Degrees(-01.48872713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137298"},
        {"Hipparcos Number", "HIP 75500"},
        {"Smithsonian Astrophysical Observation", "SAO 140521"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.33407471),
        dec: Angle.Degrees(-01.48813343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95832"},
        {"Hipparcos Number", "HIP 54041"},
        {"Smithsonian Astrophysical Observation", "SAO 137967"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.87871233),
        dec: Angle.Degrees(-01.48556760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100995"},
        {"Hipparcos Number", "HIP 56691"},
        {"Geneva Identification System", "GEN# +1.00100995"},
        {"Smithsonian Astrophysical Observation", "SAO 138306"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.36251796),
        dec: Angle.Degrees(-01.48482620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101696",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101696"},
        {"Smithsonian Astrophysical Observation", "SAO 144625"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.19397351),
        dec: Angle.Degrees(-01.48447437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127934"},
        {"Hipparcos Number", "HIP 71241"},
        {"Smithsonian Astrophysical Observation", "SAO 140006"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.53615636),
        dec: Angle.Degrees(-01.48239791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3439",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3439"},
    },
    visualMagnitude: 10.02,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.96866247),
        dec: Angle.Degrees(-01.48186625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18061"},
        {"Hipparcos Number", "HIP 13516"},
        {"Smithsonian Astrophysical Observation", "SAO 130178"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.51964742),
        dec: Angle.Degrees(-01.47916980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195359"},
        {"Hipparcos Number", "HIP 101212"},
        {"Smithsonian Astrophysical Observation", "SAO 144522"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.73731175),
        dec: Angle.Degrees(-01.47903715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92827"},
        {"Hipparcos Number", "HIP 52429"},
        {"Smithsonian Astrophysical Observation", "SAO 137747"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.77506142),
        dec: Angle.Degrees(-01.47792380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77281"},
        {"Hipparcos Number", "HIP 44325"},
        {"Geneva Identification System", "GEN# +1.00077281"},
        {"Smithsonian Astrophysical Observation", "SAO 136505"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.40841312),
        dec: Angle.Degrees(-01.47629075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83409"},
        {"Hipparcos Number", "HIP 47285"},
        {"Geneva Identification System", "GEN# +1.00083409"},
        {"Smithsonian Astrophysical Observation", "SAO 137014"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.55114845),
        dec: Angle.Degrees(-01.47552504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145936"},
        {"Hipparcos Number", "HIP 79522"},
        {"Geneva Identification System", "GEN# +1.00145936"},
        {"Smithsonian Astrophysical Observation", "SAO 141040"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.41094585),
        dec: Angle.Degrees(-01.47514027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15263",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15263"},
    },
    visualMagnitude: 10.50,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.21881811),
        dec: Angle.Degrees(-01.47422332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112117"},
        {"Hipparcos Number", "HIP 62963"},
        {"Smithsonian Astrophysical Observation", "SAO 139032"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.53514187),
        dec: Angle.Degrees(-01.47138434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37225",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6244 D"},
        {"Hipparcos Number", "HIP 37225"},
    },
    visualMagnitude: 11.43,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.68818270),
        dec: Angle.Degrees(-01.47121238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221091"},
        {"Hipparcos Number", "HIP 115909"},
        {"Smithsonian Astrophysical Observation", "SAO 146730"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.25883882),
        dec: Angle.Degrees(-01.47030374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36780"},
        {"Hipparcos Number", "HIP 26108"},
        {"Geneva Identification System", "GEN# +1.00036780"},
        {"Smithsonian Astrophysical Observation", "SAO 132270"},
    },
    visualMagnitude: 5.92,
    bvColour: 1.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.51689842),
        dec: Angle.Degrees(-01.47020476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169933"},
        {"Hipparcos Number", "HIP 90438"},
        {"Geneva Identification System", "GEN# +1.00169933"},
        {"Smithsonian Astrophysical Observation", "SAO 142327"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.79047386),
        dec: Angle.Degrees(-01.47001474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50657",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "NC 26"},
        {"Henry Draper", "HD 89668"},
        {"Hipparcos Number", "HIP 50657"},
        {"Cincinnati Publication", "Ci 20 575"},
        {"Cincinnati Publication 2", "Ci 18 1246"},
        {"Geneva Identification System", "GEN# +1.00089668"},
        {"Smithsonian Astrophysical Observation", "SAO 137504"},
        {"Wilson Evans Batten Catalogue", "WEB 9285"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.18247306),
        dec: Angle.Degrees(-01.46941279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -664.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -171.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185484"},
        {"Hipparcos Number", "HIP 96684"},
        {"Geneva Identification System", "GEN# +1.00185484"},
        {"Smithsonian Astrophysical Observation", "SAO 143654"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.84701863),
        dec: Angle.Degrees(-01.46795876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199789"},
        {"Hipparcos Number", "HIP 103610"},
        {"Smithsonian Astrophysical Observation", "SAO 145011"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.88129603),
        dec: Angle.Degrees(-01.46790493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167968"},
        {"Hipparcos Number", "HIP 89649"},
        {"Geneva Identification System", "GEN# +1.00167968"},
        {"Smithsonian Astrophysical Observation", "SAO 142199"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.42846188),
        dec: Angle.Degrees(-01.46435703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81567"},
        {"Hipparcos Number", "HIP 46288"},
        {"Geneva Identification System", "GEN# +1.00081567"},
        {"Smithsonian Astrophysical Observation", "SAO 136844"},
        {"Wilson Evans Batten Catalogue", "WEB 8755"},
    },
    visualMagnitude: 6.01,
    bvColour: 1.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.59295700),
        dec: Angle.Degrees(-01.46406552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37674"},
        {"Hipparcos Number", "HIP 26683"},
        {"Celescope Catalog", "CEL 911"},
        {"Geneva Identification System", "GEN# +1.00037674"},
        {"Smithsonian Astrophysical Observation", "SAO 132436"},
        {"Wilson Evans Batten Catalogue", "WEB 5259"},
    },
    visualMagnitude: 7.67,
    bvColour: -0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.05641910),
        dec: Angle.Degrees(-01.46257379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171127"},
        {"Hipparcos Number", "HIP 90949"},
        {"Geneva Identification System", "GEN# +1.00171127"},
        {"Smithsonian Astrophysical Observation", "SAO 142381"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.28687864),
        dec: Angle.Degrees(-01.46230656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23992"},
        {"Hipparcos Number", "HIP 17856"},
        {"Smithsonian Astrophysical Observation", "SAO 130746"},
    },
    visualMagnitude: 6.55,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.32938456),
        dec: Angle.Degrees(-01.45315956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37219",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6244 AB"},
        {"Henry Draper", "HD 61343"},
        {"Hipparcos Number", "HIP 37219"},
        {"Smithsonian Astrophysical Observation", "SAO 134933"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.67894290),
        dec: Angle.Degrees(-01.45226338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36162",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36162"},
        {"Smithsonian Astrophysical Observation", "SAO 134679"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.74324206),
        dec: Angle.Degrees(-01.45181277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103459"},
        {"Hipparcos Number", "HIP 58093"},
        {"Geneva Identification System", "GEN# +1.00103459"},
        {"Smithsonian Astrophysical Observation", "SAO 138476"},
        {"Wilson Evans Batten Catalogue", "WEB 10400"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.71617750),
        dec: Angle.Degrees(-01.45074088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 128.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -306.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23377"},
        {"Hipparcos Number", "HIP 17479"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.17930693),
        dec: Angle.Degrees(-01.45047920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138807"},
        {"Hipparcos Number", "HIP 76246"},
        {"Smithsonian Astrophysical Observation", "SAO 140616"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.62268328),
        dec: Angle.Degrees(-01.45025292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121442"},
        {"Hipparcos Number", "HIP 67994"},
        {"Smithsonian Astrophysical Observation", "SAO 139623"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.86652917),
        dec: Angle.Degrees(-01.44998749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73038",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73038"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.89986921),
        dec: Angle.Degrees(-01.44993968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61941",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Porrima"},
        {"Aitken", "ADS 8630 AB"},
        {"Henry Draper", "HD 110379J"},
        {"Hipparcos Number", "HIP 61941"},
        {"Geneva Identification System", "GEN# +1.00110379"},
    },
    visualMagnitude: 2.74,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.41667557),
        dec: Angle.Degrees(-01.44952231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -616.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216221"},
        {"Hipparcos Number", "HIP 112845"},
        {"Smithsonian Astrophysical Observation", "SAO 146351"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.79065189),
        dec: Angle.Degrees(-01.44731100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212427"},
        {"Hipparcos Number", "HIP 110594"},
        {"Smithsonian Astrophysical Observation", "SAO 146070"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.07486486),
        dec: Angle.Degrees(-01.44695706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72243",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72243"},
        {"Smithsonian Astrophysical Observation", "SAO 140130"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.61276249),
        dec: Angle.Degrees(-01.44688301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40574"},
        {"Hipparcos Number", "HIP 28370"},
        {"Geneva Identification System", "GEN# +1.00040574"},
        {"Renson", "Renson 10850"},
        {"Smithsonian Astrophysical Observation", "SAO 132723"},
        {"Wilson Evans Batten Catalogue", "WEB 5546"},
    },
    visualMagnitude: 6.62,
    bvColour: -0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.90728043),
        dec: Angle.Degrees(-01.44405347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103631"},
        {"Hipparcos Number", "HIP 58191"},
        {"Smithsonian Astrophysical Observation", "SAO 138488"},
        {"Wilson Evans Batten Catalogue", "WEB 10415"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.00522611),
        dec: Angle.Degrees(-01.44213408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 290385"},
        {"Hipparcos Number", "HIP 25193"},
        {"Geneva Identification System", "GEN# +1.00290385"},
        {"Smithsonian Astrophysical Observation", "SAO 132050"},
    },
    visualMagnitude: 8.33,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.84556362),
        dec: Angle.Degrees(-01.44093613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21045",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21045"},
        {"Smithsonian Astrophysical Observation", "SAO 131257"},
    },
    visualMagnitude: 9.37,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.67385276),
        dec: Angle.Degrees(-01.43835340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64256"},
        {"Hipparcos Number", "HIP 38490"},
        {"Geneva Identification System", "GEN# +1.00064256"},
        {"Smithsonian Astrophysical Observation", "SAO 135208"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.24106164),
        dec: Angle.Degrees(-01.43732083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183994"},
        {"Hipparcos Number", "HIP 96097"},
        {"Geneva Identification System", "GEN# +1.00183994"},
        {"Smithsonian Astrophysical Observation", "SAO 143515"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.06643494),
        dec: Angle.Degrees(-01.43540587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72626",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72626"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.74311036),
        dec: Angle.Degrees(-01.43470126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214897"},
        {"Hipparcos Number", "HIP 112030"},
        {"Smithsonian Astrophysical Observation", "SAO 146248"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.719,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.36825449),
        dec: Angle.Degrees(-01.43432997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30113"},
        {"Hipparcos Number", "HIP 22058"},
        {"Geneva Identification System", "GEN# +1.00030113"},
        {"Smithsonian Astrophysical Observation", "SAO 131457"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.812,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.16181608),
        dec: Angle.Degrees(-01.43320010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162692"},
        {"Hipparcos Number", "HIP 87475"},
        {"Geneva Identification System", "GEN# +1.00162692"},
        {"Smithsonian Astrophysical Observation", "SAO 141921"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.09326447),
        dec: Angle.Degrees(-01.43020567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48886"},
        {"Hipparcos Number", "HIP 32384"},
        {"Geneva Identification System", "GEN# +1.00048886"},
        {"Smithsonian Astrophysical Observation", "SAO 133642"},
    },
    visualMagnitude: 7.82,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.37890923),
        dec: Angle.Degrees(-01.42998420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197719"},
        {"Hipparcos Number", "HIP 102451"},
        {"Smithsonian Astrophysical Observation", "SAO 144776"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.39835904),
        dec: Angle.Degrees(-01.42967585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27604",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4442 C"},
        {"Henry Draper", "HD 39170"},
        {"Hipparcos Number", "HIP 27604"},
        {"Geneva Identification System", "GEN# +1.00039170"},
        {"Smithsonian Astrophysical Observation", "SAO 132585"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.66464036),
        dec: Angle.Degrees(-01.42954755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 65.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27600",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4442 AB"},
        {"Henry Draper", "HD 39169"},
        {"Hipparcos Number", "HIP 27600"},
        {"Geneva Identification System", "GEN# +1.00039169J"},
        {"Smithsonian Astrophysical Observation", "SAO 132583"},
        {"Wilson Evans Batten Catalogue", "WEB 5419"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.65760537),
        dec: Angle.Degrees(-01.42943795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32854",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32854"},
        {"Geneva Identification System", "GEN# +6.00403658"},
        {"Wilson Evans Batten Catalogue", "WEB 6614"},
    },
    visualMagnitude: 10.92,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.71778506),
        dec: Angle.Degrees(-01.42922737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37660"},
        {"Hipparcos Number", "HIP 26668"},
        {"Geneva Identification System", "GEN# +1.00037660"},
        {"Smithsonian Astrophysical Observation", "SAO 132432"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.01662323),
        dec: Angle.Degrees(-01.42547903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209697"},
        {"Hipparcos Number", "HIP 109038"},
        {"Smithsonian Astrophysical Observation", "SAO 145859"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.33173639),
        dec: Angle.Degrees(-01.42419480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219461"},
        {"Hipparcos Number", "HIP 114864"},
        {"Geneva Identification System", "GEN# +1.00219461"},
        {"Smithsonian Astrophysical Observation", "SAO 146600"},
    },
    visualMagnitude: 6.93,
    bvColour: 1.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.99296394),
        dec: Angle.Degrees(-01.42387823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85219"},
        {"Hipparcos Number", "HIP 48267"},
        {"Geneva Identification System", "GEN# +1.00085219"},
        {"Smithsonian Astrophysical Observation", "SAO 137173"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.59977074),
        dec: Angle.Degrees(-01.42223155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26439",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4222 AB"},
        {"Henry Draper", "HD 37321"},
        {"Hipparcos Number", "HIP 26439"},
        {"Celescope Catalog", "CEL 868"},
        {"Geneva Identification System", "GEN# +9.00040011"},
        {"Smithsonian Astrophysical Observation", "SAO 132376"},
    },
    visualMagnitude: 7.11,
    bvColour: -0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.39501136),
        dec: Angle.Degrees(-01.42213120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109035",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109035"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.32569997),
        dec: Angle.Degrees(-01.42054310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30493",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5029 AB"},
        {"Henry Draper", "HD 44948"},
        {"Hipparcos Number", "HIP 30493"},
        {"Celescope Catalog", "CEL 1224"},
        {"Geneva Identification System", "GEN# +1.00044948J"},
        {"Renson", "Renson 11920"},
        {"Smithsonian Astrophysical Observation", "SAO 133215"},
    },
    visualMagnitude: 6.72,
    bvColour: -0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.14140212),
        dec: Angle.Degrees(-01.41820306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129902"},
        {"Hipparcos Number", "HIP 72122"},
        {"Geneva Identification System", "GEN# +1.00129902"},
        {"Smithsonian Astrophysical Observation", "SAO 140116"},
        {"Wilson Evans Batten Catalogue", "WEB 12409"},
    },
    visualMagnitude: 6.06,
    bvColour: 1.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.29891743),
        dec: Angle.Degrees(-01.41752729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50354",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50354"},
        {"Smithsonian Astrophysical Observation", "SAO 137459"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.23277081),
        dec: Angle.Degrees(-01.41706835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109597"},
        {"Hipparcos Number", "HIP 61491"},
        {"Smithsonian Astrophysical Observation", "SAO 138868"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.98366562),
        dec: Angle.Degrees(-01.41456417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70965",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70965"},
        {"Smithsonian Astrophysical Observation", "SAO 139979"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.73198027),
        dec: Angle.Degrees(-01.41246950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128044"},
        {"Hipparcos Number", "HIP 71292"},
        {"Smithsonian Astrophysical Observation", "SAO 140011"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.70042828),
        dec: Angle.Degrees(-01.41238140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64606"},
        {"Hipparcos Number", "HIP 38625"},
        {"Cincinnati Publication", "Ci 18 941"},
        {"Geneva Identification System", "GEN# +1.00064606"},
        {"Smithsonian Astrophysical Observation", "SAO 135239"},
        {"Wilson Evans Batten Catalogue", "WEB 7582"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.64302408),
        dec: Angle.Degrees(-01.41210730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -251.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34748"},
        {"Hipparcos Number", "HIP 24847"},
        {"Geneva Identification System", "GEN# +1.00034748"},
        {"Smithsonian Astrophysical Observation", "SAO 131983"},
        {"Wilson Evans Batten Catalogue", "WEB 4814"},
    },
    visualMagnitude: 6.33,
    bvColour: -0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.89701156),
        dec: Angle.Degrees(-01.41189590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23131",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23131"},
        {"Smithsonian Astrophysical Observation", "SAO 131647"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.65561556),
        dec: Angle.Degrees(-01.41137576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20667",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3217 C"},
        {"Henry Draper", "HD 28053"},
        {"Hipparcos Number", "HIP 20667"},
        {"Geneva Identification System", "GEN# +1.00028053"},
        {"Smithsonian Astrophysical Observation", "SAO 131200"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.41502213),
        dec: Angle.Degrees(-01.41086961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217131"},
        {"Hipparcos Number", "HIP 113433"},
        {"Geneva Identification System", "GEN# +1.00217131"},
        {"Smithsonian Astrophysical Observation", "SAO 146415"},
        {"Wilson Evans Batten Catalogue", "WEB 20172"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.59838162),
        dec: Angle.Degrees(-01.41019267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163403"},
        {"Hipparcos Number", "HIP 87797"},
        {"Fundamental Katalog 5th Edition", "FK5 5577"},
        {"Smithsonian Astrophysical Observation", "SAO 141966"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.03083397),
        dec: Angle.Degrees(-01.41001848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140190"},
        {"Hipparcos Number", "HIP 76921"},
        {"Smithsonian Astrophysical Observation", "SAO 140710"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.59097348),
        dec: Angle.Degrees(-01.40934250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97491"},
        {"Hipparcos Number", "HIP 54802"},
        {"Geneva Identification System", "GEN# +1.00097491"},
        {"Smithsonian Astrophysical Observation", "SAO 138069"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.28625218),
        dec: Angle.Degrees(-01.40925770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -145.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34180"},
        {"Hipparcos Number", "HIP 24493"},
        {"Geneva Identification System", "GEN# +1.00034180"},
        {"Smithsonian Astrophysical Observation", "SAO 131917"},
        {"Wilson Evans Batten Catalogue", "WEB 4745"},
    },
    visualMagnitude: 6.15,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.82717763),
        dec: Angle.Degrees(-01.40906138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102047"},
        {"Hipparcos Number", "HIP 57264"},
        {"Fundamental Katalog 5th Edition", "FK5 5040"},
        {"Smithsonian Astrophysical Observation", "SAO 138382"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.15024602),
        dec: Angle.Degrees(-01.38484119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12301",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2005 AB"},
        {"Henry Draper", "HD 16453"},
        {"Hipparcos Number", "HIP 12301"},
        {"Smithsonian Astrophysical Observation", "SAO 130029"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.60521519),
        dec: Angle.Degrees(-01.40860559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131251"},
        {"Hipparcos Number", "HIP 72771"},
        {"Smithsonian Astrophysical Observation", "SAO 140194"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.13510078),
        dec: Angle.Degrees(-01.40784902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109403"},
        {"Hipparcos Number", "HIP 61358"},
        {"Geneva Identification System", "GEN# +1.00109403"},
        {"Smithsonian Astrophysical Observation", "SAO 138853"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.59666853),
        dec: Angle.Degrees(-01.40764062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145853"},
        {"Hipparcos Number", "HIP 79486"},
        {"Geneva Identification System", "GEN# +1.00145853"},
        {"Smithsonian Astrophysical Observation", "SAO 141034"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.31127612),
        dec: Angle.Degrees(-01.40191122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43302"},
        {"Hipparcos Number", "HIP 29706"},
        {"Geneva Identification System", "GEN# +1.00043302"},
        {"Smithsonian Astrophysical Observation", "SAO 133025"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.86176921),
        dec: Angle.Degrees(-01.39980366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82869"},
        {"Hipparcos Number", "HIP 46995"},
        {"Smithsonian Astrophysical Observation", "SAO 136969"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.67730652),
        dec: Angle.Degrees(-01.39940172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179153"},
        {"Hipparcos Number", "HIP 94294"},
        {"Wilson Evans Batten Catalogue", "WEB 16423"},
    },
    visualMagnitude: 11.13,
    bvColour: 1.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.89709499),
        dec: Angle.Degrees(-01.39810393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117349"},
        {"Hipparcos Number", "HIP 65840"},
        {"Smithsonian Astrophysical Observation", "SAO 139365"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.44706503),
        dec: Angle.Degrees(-01.39689894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160622"},
        {"Hipparcos Number", "HIP 86539"},
        {"Smithsonian Astrophysical Observation", "SAO 141810"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.27373015),
        dec: Angle.Degrees(-01.39613099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97197"},
        {"Hipparcos Number", "HIP 54656"},
        {"Geneva Identification System", "GEN# +1.00097197"},
        {"Smithsonian Astrophysical Observation", "SAO 138039"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.83057878),
        dec: Angle.Degrees(-01.39461346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65953"},
        {"Hipparcos Number", "HIP 39211"},
        {"Fundamental Katalog 5th Edition", "FK5 2620"},
        {"Geneva Identification System", "GEN# +1.00065953"},
        {"Smithsonian Astrophysical Observation", "SAO 135380"},
        {"Wilson Evans Batten Catalogue", "WEB 7689"},
    },
    visualMagnitude: 4.69,
    bvColour: 1.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.30540155),
        dec: Angle.Degrees(-01.39242418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76691",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76691"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.709,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.90294551),
        dec: Angle.Degrees(-01.39211553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115308"},
        {"Hipparcos Number", "HIP 64769"},
        {"Fundamental Katalog 5th Edition", "FK5 3058"},
        {"Geneva Identification System", "GEN# +1.00115308"},
        {"Smithsonian Astrophysical Observation", "SAO 139254"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.10626257),
        dec: Angle.Degrees(-01.39046480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129249"},
        {"Hipparcos Number", "HIP 71829"},
        {"Smithsonian Astrophysical Observation", "SAO 140076"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.39967178),
        dec: Angle.Degrees(-01.38842328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110395",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Sadachbia"},
        {"Aitken", "ADS 15864 A"},
        {"Henry Draper", "HD 212061"},
        {"Hipparcos Number", "HIP 110395"},
        {"Fundamental Katalog 5th Edition", "FK5 842"},
        {"Geneva Identification System", "GEN# +1.00212061"},
        {"Smithsonian Astrophysical Observation", "SAO 146044"},
        {"Wilson Evans Batten Catalogue", "WEB 19798"},
    },
    visualMagnitude: 3.86,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.41374983),
        dec: Angle.Degrees(-01.38735315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 129.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85917"},
        {"Hipparcos Number", "HIP 48644"},
        {"Smithsonian Astrophysical Observation", "SAO 137226"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.852,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.77693350),
        dec: Angle.Degrees(-01.38615934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17295"},
        {"Hipparcos Number", "HIP 12950"},
        {"Smithsonian Astrophysical Observation", "SAO 130104"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.63668792),
        dec: Angle.Degrees(-01.38431677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3789",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3789"},
        {"Geneva Identification System", "GEN# +9.80070014"},
    },
    visualMagnitude: 10.88,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.17311028),
        dec: Angle.Degrees(-01.38402552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 202.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183369"},
        {"Hipparcos Number", "HIP 95814"},
        {"Smithsonian Astrophysical Observation", "SAO 143456"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.32947585),
        dec: Angle.Degrees(-01.38155735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11478"},
        {"Hipparcos Number", "HIP 8764"},
        {"Smithsonian Astrophysical Observation", "SAO 129547"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.19730998),
        dec: Angle.Degrees(-01.38082439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208898"},
        {"Hipparcos Number", "HIP 108550"},
        {"Smithsonian Astrophysical Observation", "SAO 145790"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.84270683),
        dec: Angle.Degrees(-01.38036235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47663"},
        {"Hipparcos Number", "HIP 31874"},
        {"Geneva Identification System", "GEN# +1.00047663"},
        {"Smithsonian Astrophysical Observation", "SAO 133536"},
    },
    visualMagnitude: 6.92,
    bvColour: 1.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.94386935),
        dec: Angle.Degrees(-01.38013436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186778"},
        {"Hipparcos Number", "HIP 97308"},
        {"Smithsonian Astrophysical Observation", "SAO 143786"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.64621056),
        dec: Angle.Degrees(-01.37683772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50846"},
        {"Hipparcos Number", "HIP 33237"},
        {"Geneva Identification System", "GEN# +1.00050846"},
        {"Smithsonian Astrophysical Observation", "SAO 133887"},
        {"Wilson Evans Batten Catalogue", "WEB 6683"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.72795573),
        dec: Angle.Degrees(-01.37579276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199085"},
        {"Hipparcos Number", "HIP 103237"},
        {"Geneva Identification System", "GEN# +1.00199085"},
        {"Smithsonian Astrophysical Observation", "SAO 144935"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.72561119),
        dec: Angle.Degrees(-01.37572910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35039",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35039"},
        {"Smithsonian Astrophysical Observation", "SAO 134404"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.818,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.70869742),
        dec: Angle.Degrees(-01.37570960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51473"},
        {"Hipparcos Number", "HIP 33471"},
        {"Smithsonian Astrophysical Observation", "SAO 133950"},
        {"Wilson Evans Batten Catalogue", "WEB 6731"},
    },
    visualMagnitude: 8.20,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.36475362),
        dec: Angle.Degrees(-01.37456595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199124"},
        {"Hipparcos Number", "HIP 103261"},
        {"Geneva Identification System", "GEN# +1.00199124"},
        {"Smithsonian Astrophysical Observation", "SAO 144941"},
    },
    visualMagnitude: 6.55,
    bvColour: 0.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.78442952),
        dec: Angle.Degrees(-01.37309042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 292630"},
        {"Hipparcos Number", "HIP 32915"},
        {"Wilson Evans Batten Catalogue", "WEB 6623"},
    },
    visualMagnitude: 10.29,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.86604014),
        dec: Angle.Degrees(-01.37109153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176219"},
        {"Hipparcos Number", "HIP 93219"},
        {"Fundamental Katalog 5th Edition", "FK5 5675"},
        {"Geneva Identification System", "GEN# +1.00176219"},
        {"Renson", "Renson 49157"},
        {"Smithsonian Astrophysical Observation", "SAO 142882"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.82653816),
        dec: Angle.Degrees(-01.36759824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35792"},
        {"Hipparcos Number", "HIP 25496"},
        {"Geneva Identification System", "GEN# +1.00035792"},
        {"Smithsonian Astrophysical Observation", "SAO 132121"},
    },
    visualMagnitude: 7.21,
    bvColour: -0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.78905283),
        dec: Angle.Degrees(-01.36734602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43988"},
        {"Hipparcos Number", "HIP 30027"},
        {"Geneva Identification System", "GEN# +1.00043988"},
        {"Smithsonian Astrophysical Observation", "SAO 133093"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.78315155),
        dec: Angle.Degrees(-01.36693180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44215"},
        {"Hipparcos Number", "HIP 30136"},
        {"Geneva Identification System", "GEN# +1.00044215"},
        {"Smithsonian Astrophysical Observation", "SAO 133131"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.13228939),
        dec: Angle.Degrees(-01.36660426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117267"},
        {"Hipparcos Number", "HIP 65796"},
        {"Geneva Identification System", "GEN# +1.00117267"},
        {"Smithsonian Astrophysical Observation", "SAO 139359"},
        {"Wilson Evans Batten Catalogue", "WEB 11642"},
    },
    visualMagnitude: 6.42,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.31225262),
        dec: Angle.Degrees(-01.36428430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27779"},
        {"Hipparcos Number", "HIP 20463"},
        {"Geneva Identification System", "GEN# +1.00027779"},
        {"Smithsonian Astrophysical Observation", "SAO 131160"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.76281976),
        dec: Angle.Degrees(-01.36238644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151258"},
        {"Hipparcos Number", "HIP 82114"},
        {"Geneva Identification System", "GEN# +1.00151258"},
        {"Smithsonian Astrophysical Observation", "SAO 141355"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.60224912),
        dec: Angle.Degrees(-01.36040877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30560"},
        {"Hipparcos Number", "HIP 22341"},
        {"Geneva Identification System", "GEN# +1.00030560"},
        {"Smithsonian Astrophysical Observation", "SAO 131503"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.16082549),
        dec: Angle.Degrees(-01.35634590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 290240"},
        {"Hipparcos Number", "HIP 24851"},
        {"Smithsonian Astrophysical Observation", "SAO 131985"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.91709963),
        dec: Angle.Degrees(-01.35620726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94372"},
        {"Hipparcos Number", "HIP 53267"},
        {"Geneva Identification System", "GEN# +1.00094372"},
        {"Smithsonian Astrophysical Observation", "SAO 137868"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.41592120),
        dec: Angle.Degrees(-01.35401507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28737"},
        {"Hipparcos Number", "HIP 21130"},
        {"Geneva Identification System", "GEN# +1.00028737"},
        {"Smithsonian Astrophysical Observation", "SAO 131268"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.93595680),
        dec: Angle.Degrees(-01.35253422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76601"},
        {"Hipparcos Number", "HIP 43961"},
        {"Geneva Identification System", "GEN# +1.00076601"},
        {"Smithsonian Astrophysical Observation", "SAO 136432"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.29392912),
        dec: Angle.Degrees(-01.35140807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74537",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9544 AB"},
        {"Henry Draper", "HD 135204"},
        {"Hipparcos Number", "HIP 74537"},
        {"Cincinnati Publication", "Ci 20 919"},
        {"Geneva Identification System", "GEN# +1.00135204"},
        {"Smithsonian Astrophysical Observation", "SAO 140392"},
        {"Wilson Evans Batten Catalogue", "WEB 12718"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.763,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.46514866),
        dec: Angle.Degrees(-01.35016449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1269.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -503.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67452"},
        {"Hipparcos Number", "HIP 39795"},
        {"Geneva Identification System", "GEN# +1.00067452"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.98458340),
        dec: Angle.Degrees(-01.34947157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62385"},
        {"Hipparcos Number", "HIP 37654"},
        {"Smithsonian Astrophysical Observation", "SAO 135031"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.90281524),
        dec: Angle.Degrees(-01.34818699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124998"},
        {"Hipparcos Number", "HIP 69777"},
        {"Smithsonian Astrophysical Observation", "SAO 139836"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.22836063),
        dec: Angle.Degrees(-01.34767320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155955"},
        {"Hipparcos Number", "HIP 84353"},
        {"Smithsonian Astrophysical Observation", "SAO 141571"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.68435295),
        dec: Angle.Degrees(-01.34722689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48497"},
        {"Hipparcos Number", "HIP 32221"},
        {"Geneva Identification System", "GEN# +1.00048497"},
        {"Smithsonian Astrophysical Observation", "SAO 133616"},
    },
    visualMagnitude: 7.53,
    bvColour: -0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.90037539),
        dec: Angle.Degrees(-01.34678154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93836",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12038 A"},
        {"Henry Draper", "HD 177880"},
        {"Hipparcos Number", "HIP 93836"},
        {"Fundamental Katalog 5th Edition", "FK5 1497"},
        {"Geneva Identification System", "GEN# +1.00177880J"},
        {"Smithsonian Astrophysical Observation", "SAO 143029"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.64631072),
        dec: Angle.Degrees(-01.34611038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52611"},
        {"Hipparcos Number", "HIP 33873"},
        {"Geneva Identification System", "GEN# +1.00052611"},
        {"Smithsonian Astrophysical Observation", "SAO 134073"},
    },
    visualMagnitude: 6.20,
    bvColour: 1.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.47045579),
        dec: Angle.Degrees(-01.34578762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93835",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12038 B"},
        {"Henry Draper", "HD 177880B"},
        {"Hipparcos Number", "HIP 93835"},
        {"Renson", "Renson 49570"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.64538451),
        dec: Angle.Degrees(-01.34267044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49713"},
        {"Hipparcos Number", "HIP 32745"},
        {"Geneva Identification System", "GEN# +1.00049713"},
        {"Renson", "Renson 13480"},
        {"Smithsonian Astrophysical Observation", "SAO 133730"},
    },
    visualMagnitude: 7.33,
    bvColour: -0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.43455644),
        dec: Angle.Degrees(-01.33995027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183130"},
        {"Hipparcos Number", "HIP 95707"},
        {"Geneva Identification System", "GEN# +1.00183130"},
        {"Smithsonian Astrophysical Observation", "SAO 143430"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.01149946),
        dec: Angle.Degrees(-01.33854734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171661"},
        {"Hipparcos Number", "HIP 91199"},
        {"Smithsonian Astrophysical Observation", "SAO 142419"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.06022611),
        dec: Angle.Degrees(-01.33657183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164760"},
        {"Hipparcos Number", "HIP 88376"},
        {"Geneva Identification System", "GEN# +1.00164760"},
        {"Smithsonian Astrophysical Observation", "SAO 142046"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.69775156),
        dec: Angle.Degrees(-01.33634749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222146"},
        {"Hipparcos Number", "HIP 116629"},
        {"Geneva Identification System", "GEN# +1.00222146"},
        {"Renson", "Renson 60880"},
        {"Smithsonian Astrophysical Observation", "SAO 146813"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.52672798),
        dec: Angle.Degrees(-01.33560915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107696",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107696"},
    },
    visualMagnitude: 11.14,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.23626037),
        dec: Angle.Degrees(-01.33557595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42789"},
        {"Hipparcos Number", "HIP 29476"},
        {"Geneva Identification System", "GEN# +1.00042789"},
        {"Smithsonian Astrophysical Observation", "SAO 132961"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.15978521),
        dec: Angle.Degrees(-01.33390186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96855"},
        {"Hipparcos Number", "HIP 54515"},
        {"Geneva Identification System", "GEN# +1.00096855"},
        {"Smithsonian Astrophysical Observation", "SAO 138015"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.30706960),
        dec: Angle.Degrees(-01.33324824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142071"},
        {"Hipparcos Number", "HIP 77751"},
        {"Smithsonian Astrophysical Observation", "SAO 140813"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.14409334),
        dec: Angle.Degrees(-01.33015275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168073"},
        {"Hipparcos Number", "HIP 89680"},
        {"Geneva Identification System", "GEN# +1.00168073"},
        {"Smithsonian Astrophysical Observation", "SAO 142206"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.52296003),
        dec: Angle.Degrees(-01.33015211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106498"},
        {"Hipparcos Number", "HIP 59732"},
        {"Smithsonian Astrophysical Observation", "SAO 138670"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.75017998),
        dec: Angle.Degrees(-01.32659257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37845"},
        {"Hipparcos Number", "HIP 26778"},
        {"Geneva Identification System", "GEN# +1.00037845"},
        {"Smithsonian Astrophysical Observation", "SAO 132457"},
    },
    visualMagnitude: 8.77,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.33333819),
        dec: Angle.Degrees(-01.32653870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11505"},
        {"Hipparcos Number", "HIP 8798"},
        {"Cincinnati Publication", "Ci 18 252"},
        {"Fundamental Katalog 5th Edition", "FK5 2126"},
        {"Geneva Identification System", "GEN# +1.00011505"},
        {"Smithsonian Astrophysical Observation", "SAO 129551"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.27628223),
        dec: Angle.Degrees(-01.32609412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -186.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -349.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42677"},
        {"Hipparcos Number", "HIP 29424"},
        {"Geneva Identification System", "GEN# +1.00042677"},
        {"Smithsonian Astrophysical Observation", "SAO 132943"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.98394949),
        dec: Angle.Degrees(-01.32362626)
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
    primaryId: "HIP 12644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16885"},
        {"Henry Draper 2", "HD 16885A"},
        {"Hipparcos Number", "HIP 12644"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.61233819),
        dec: Angle.Degrees(-01.32150166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49434"},
        {"Hipparcos Number", "HIP 32617"},
        {"Geneva Identification System", "GEN# +1.00049434"},
        {"Smithsonian Astrophysical Observation", "SAO 133687"},
    },
    visualMagnitude: 5.75,
    bvColour: 0.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.07953302),
        dec: Angle.Degrees(-01.31883901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138159"},
        {"Hipparcos Number", "HIP 75923"},
        {"Smithsonian Astrophysical Observation", "SAO 140573"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.60508260),
        dec: Angle.Degrees(-01.31873797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60442"},
        {"Hipparcos Number", "HIP 36821"},
        {"Geneva Identification System", "GEN# +1.00060442"},
        {"Smithsonian Astrophysical Observation", "SAO 134847"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.58154214),
        dec: Angle.Degrees(-01.31834249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19156"},
        {"Hipparcos Number", "HIP 14332"},
        {"Smithsonian Astrophysical Observation", "SAO 130272"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.20887366),
        dec: Angle.Degrees(-01.31661858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27516"},
        {"Hipparcos Number", "HIP 20257"},
        {"Smithsonian Astrophysical Observation", "SAO 131126"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.12046940),
        dec: Angle.Degrees(-01.31632000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133644"},
        {"Hipparcos Number", "HIP 73852"},
        {"Geneva Identification System", "GEN# +1.00133644"},
        {"Smithsonian Astrophysical Observation", "SAO 140314"},
        {"Wilson Evans Batten Catalogue", "WEB 12615"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.40153366),
        dec: Angle.Degrees(-01.31577499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32720"},
        {"Hipparcos Number", "HIP 23659"},
        {"Smithsonian Astrophysical Observation", "SAO 131747"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.26732193),
        dec: Angle.Degrees(-01.31134495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196396"},
        {"Hipparcos Number", "HIP 101724"},
        {"Geneva Identification System", "GEN# +1.00196396"},
        {"Smithsonian Astrophysical Observation", "SAO 144630"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.29511086),
        dec: Angle.Degrees(-01.31108077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8153"},
        {"Hipparcos Number", "HIP 6302"},
        {"Geneva Identification System", "GEN# +1.00008153"},
        {"Renson", "Renson 1987"},
        {"Smithsonian Astrophysical Observation", "SAO 129241"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.22110278),
        dec: Angle.Degrees(-01.31060594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3168"},
        {"Hipparcos Number", "HIP 2735"},
        {"Smithsonian Astrophysical Observation", "SAO 128837"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.73329134),
        dec: Angle.Degrees(-01.31018941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181420"},
        {"Hipparcos Number", "HIP 95055"},
        {"Geneva Identification System", "GEN# +1.00181420"},
        {"Smithsonian Astrophysical Observation", "SAO 143285"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.11262630),
        dec: Angle.Degrees(-01.30988396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212837"},
        {"Hipparcos Number", "HIP 110821"},
        {"Geneva Identification System", "GEN# +1.00212837"},
        {"Smithsonian Astrophysical Observation", "SAO 146092"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.77794758),
        dec: Angle.Degrees(-01.30913932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200356"},
        {"Hipparcos Number", "HIP 103899"},
        {"Geneva Identification System", "GEN# +1.00200356"},
        {"Smithsonian Astrophysical Observation", "SAO 145052"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.78166392),
        dec: Angle.Degrees(-01.30852206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39237",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39237"},
    },
    visualMagnitude: 9.94,
    bvColour: 1.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.37947945),
        dec: Angle.Degrees(-01.30797287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85630",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10586 A"},
        {"Henry Draper", "HD 158523"},
        {"Hipparcos Number", "HIP 85630"},
        {"Smithsonian Astrophysical Observation", "SAO 141697"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.48441301),
        dec: Angle.Degrees(-01.30636512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172850"},
        {"Hipparcos Number", "HIP 91743"},
        {"Geneva Identification System", "GEN# +1.00172850"},
        {"Smithsonian Astrophysical Observation", "SAO 142526"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.62454352),
        dec: Angle.Degrees(-01.30594670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106655",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106655"},
    },
    visualMagnitude: 9.95,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.04508719),
        dec: Angle.Degrees(-01.30508734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7596",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7596"},
        {"Smithsonian Astrophysical Observation", "SAO 129414"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.46319964),
        dec: Angle.Degrees(-01.30425839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105050",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105050"},
        {"Geneva Identification System", "GEN# +9.80025024"},
    },
    visualMagnitude: 12.10,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.17282372),
        dec: Angle.Degrees(-01.30183045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 267.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -252.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201717"},
        {"Hipparcos Number", "HIP 104616"},
        {"Geneva Identification System", "GEN# +1.00201717"},
        {"Smithsonian Astrophysical Observation", "SAO 145183"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.88776831),
        dec: Angle.Degrees(-01.30023770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3895"},
        {"Hipparcos Number", "HIP 3264"},
        {"Smithsonian Astrophysical Observation", "SAO 128901"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.38713275),
        dec: Angle.Degrees(-01.29967958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72443"},
        {"Hipparcos Number", "HIP 41922"},
        {"Smithsonian Astrophysical Observation", "SAO 136019"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.20726396),
        dec: Angle.Degrees(-01.29925903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22034"},
        {"Hipparcos Number", "HIP 16543"},
        {"Geneva Identification System", "GEN# +1.00022034"},
        {"Smithsonian Astrophysical Observation", "SAO 130563"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.26535490),
        dec: Angle.Degrees(-01.29543745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44175"},
        {"Hipparcos Number", "HIP 30127"},
        {"Geneva Identification System", "GEN# +1.00044175"},
        {"Smithsonian Astrophysical Observation", "SAO 133127"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.09604786),
        dec: Angle.Degrees(-01.29541942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84663"},
        {"Hipparcos Number", "HIP 47982"},
        {"Smithsonian Astrophysical Observation", "SAO 137119"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.70449854),
        dec: Angle.Degrees(-01.29522869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156113"},
        {"Hipparcos Number", "HIP 84436"},
        {"Smithsonian Astrophysical Observation", "SAO 141580"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.94077548),
        dec: Angle.Degrees(-01.29336013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209860"},
        {"Hipparcos Number", "HIP 109141"},
        {"Smithsonian Astrophysical Observation", "SAO 145868"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.62482462),
        dec: Angle.Degrees(-01.29306408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77977",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77977"},
    },
    visualMagnitude: 10.65,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.86193336),
        dec: Angle.Degrees(-01.29138052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172346"},
        {"Hipparcos Number", "HIP 91521"},
        {"Geneva Identification System", "GEN# +1.00172346"},
        {"Smithsonian Astrophysical Observation", "SAO 142479"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.95861988),
        dec: Angle.Degrees(-01.28908462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115752",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115752"},
        {"Geneva Identification System", "GEN# -0.00205958"},
        {"Wilson Evans Batten Catalogue", "WEB 20484"},
    },
    visualMagnitude: 10.37,
    bvColour: 1.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.76924410),
        dec: Angle.Degrees(-01.28679762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 374.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 215.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96468",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12663 A"},
        {"Henry Draper", "HD 184930"},
        {"Hipparcos Number", "HIP 96468"},
        {"Geneva Identification System", "GEN# +1.00184930"},
        {"Smithsonian Astrophysical Observation", "SAO 143597"},
        {"Wilson Evans Batten Catalogue", "WEB 16924"},
    },
    visualMagnitude: 4.36,
    bvColour: -0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.18031892),
        dec: Angle.Degrees(-01.28655047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207842"},
        {"Hipparcos Number", "HIP 107939"},
        {"Fundamental Katalog 5th Edition", "FK5 5930"},
        {"Smithsonian Astrophysical Observation", "SAO 145712"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.01970781),
        dec: Angle.Degrees(-01.28502027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156517"},
        {"Hipparcos Number", "HIP 84633"},
        {"Geneva Identification System", "GEN# +1.00156517A"},
        {"Smithsonian Astrophysical Observation", "SAO 141597"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.52096158),
        dec: Angle.Degrees(-01.28467189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -126.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -134.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4013",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4013"},
        {"Smithsonian Astrophysical Observation", "SAO 128990"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.86733647),
        dec: Angle.Degrees(-01.28441636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50845"},
        {"Hipparcos Number", "HIP 33225"},
        {"Smithsonian Astrophysical Observation", "SAO 133883"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.70381325),
        dec: Angle.Degrees(-01.28254719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95981"},
        {"Hipparcos Number", "HIP 54110"},
        {"Geneva Identification System", "GEN# +1.00095981"},
        {"Smithsonian Astrophysical Observation", "SAO 137974"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.08009599),
        dec: Angle.Degrees(-01.27819643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34238"},
        {"Hipparcos Number", "HIP 24531"},
        {"Geneva Identification System", "GEN# +1.00034238"},
        {"Smithsonian Astrophysical Observation", "SAO 131921"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.94332549),
        dec: Angle.Degrees(-01.27789642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 291907"},
        {"Hipparcos Number", "HIP 31537"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.03162328),
        dec: Angle.Degrees(-01.27747404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31125"},
        {"Hipparcos Number", "HIP 22716"},
        {"Geneva Identification System", "GEN# +1.00031125"},
        {"Smithsonian Astrophysical Observation", "SAO 131570"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.27003077),
        dec: Angle.Degrees(-01.27573807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7089"},
        {"Hipparcos Number", "HIP 5552"},
        {"Geneva Identification System", "GEN# +1.00007089"},
        {"Smithsonian Astrophysical Observation", "SAO 129164"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.80330589),
        dec: Angle.Degrees(-01.27429223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191315"},
        {"Hipparcos Number", "HIP 99298"},
        {"Smithsonian Astrophysical Observation", "SAO 144115"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.34695851),
        dec: Angle.Degrees(-01.27403326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85834"},
        {"Hipparcos Number", "HIP 48582"},
        {"Geneva Identification System", "GEN# +1.00085834"},
        {"Smithsonian Astrophysical Observation", "SAO 137215"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.62698995),
        dec: Angle.Degrees(-01.27075406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97716"},
        {"Hipparcos Number", "HIP 54910"},
        {"Geneva Identification System", "GEN# +1.00097716"},
        {"Smithsonian Astrophysical Observation", "SAO 138079"},
    },
    visualMagnitude: 6.63,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.65709631),
        dec: Angle.Degrees(-01.27075381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115724"},
        {"Hipparcos Number", "HIP 64968"},
        {"Fundamental Katalog 5th Edition", "FK5 5175"},
        {"Smithsonian Astrophysical Observation", "SAO 139275"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.74305008),
        dec: Angle.Degrees(-01.26934408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42905",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42905"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.15736003),
        dec: Angle.Degrees(-01.26747374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 97.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83073"},
        {"Hipparcos Number", "HIP 47099"},
        {"Smithsonian Astrophysical Observation", "SAO 136988"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.97977983),
        dec: Angle.Degrees(-01.26500671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31124"},
        {"Hipparcos Number", "HIP 22714"},
        {"Geneva Identification System", "GEN# +1.00031124"},
        {"Smithsonian Astrophysical Observation", "SAO 131569"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.26897483),
        dec: Angle.Degrees(-01.26439397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151169"},
        {"Hipparcos Number", "HIP 82070"},
        {"Smithsonian Astrophysical Observation", "SAO 141351"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.45490579),
        dec: Angle.Degrees(-01.26409399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18317",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2862 AB"},
        {"Henry Draper", "HD 24633"},
        {"Hipparcos Number", "HIP 18317"},
        {"Smithsonian Astrophysical Observation", "SAO 130816"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.828,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.74204809),
        dec: Angle.Degrees(-01.26342074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7687"},
        {"Hipparcos Number", "HIP 5961"},
        {"Smithsonian Astrophysical Observation", "SAO 129207"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.17426689),
        dec: Angle.Degrees(-01.26146561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118390"},
        {"Hipparcos Number", "HIP 66391"},
        {"Geneva Identification System", "GEN# +1.00118390"},
        {"Smithsonian Astrophysical Observation", "SAO 139440"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.18328160),
        dec: Angle.Degrees(-01.26056540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154636"},
        {"Hipparcos Number", "HIP 83732"},
        {"Smithsonian Astrophysical Observation", "SAO 141520"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.69888114),
        dec: Angle.Degrees(-01.25892556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46504",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7396 A"},
        {"Henry Draper", "HD 81980"},
        {"Hipparcos Number", "HIP 46504"},
        {"Geneva Identification System", "GEN# +1.00081980"},
        {"Smithsonian Astrophysical Observation", "SAO 136894"},
    },
    visualMagnitude: 6.27,
    bvColour: 0.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.25973472),
        dec: Angle.Degrees(-01.25691594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137373"},
        {"Hipparcos Number", "HIP 75521"},
        {"Geneva Identification System", "GEN# +1.00137373"},
        {"Smithsonian Astrophysical Observation", "SAO 140526"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.43517999),
        dec: Angle.Degrees(-01.25436894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75586",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75586"},
        {"Geneva Identification System", "GEN# +6.00277860"},
    },
    visualMagnitude: 10.69,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.63223011),
        dec: Angle.Degrees(-01.25310408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -114.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102843"},
        {"Hipparcos Number", "HIP 57735"},
        {"Cincinnati Publication", "Ci 20 664"},
        {"Geneva Identification System", "GEN# +1.00102843"},
        {"Smithsonian Astrophysical Observation", "SAO 138436"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.787,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.58819256),
        dec: Angle.Degrees(-01.25254660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -405.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3674",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 652 AB"},
        {"Henry Draper", "HD 4491"},
        {"Hipparcos Number", "HIP 3674"},
        {"Smithsonian Astrophysical Observation", "SAO 128954"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.75468518),
        dec: Angle.Degrees(-01.25245853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26472"},
        {"Hipparcos Number", "HIP 19540"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.78301293),
        dec: Angle.Degrees(-01.24905974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221675"},
        {"Hipparcos Number", "HIP 116323"},
        {"Fundamental Katalog 5th Edition", "FK5 3890"},
        {"Geneva Identification System", "GEN# +1.00221675"},
        {"Renson", "Renson 60750"},
        {"Smithsonian Astrophysical Observation", "SAO 146780"},
        {"Wilson Evans Batten Catalogue", "WEB 20555"},
    },
    visualMagnitude: 5.91,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.53731060),
        dec: Angle.Degrees(-01.24753498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69153"},
        {"Hipparcos Number", "HIP 40457"},
        {"Geneva Identification System", "GEN# +1.00069153"},
        {"Smithsonian Astrophysical Observation", "SAO 135689"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.91336971),
        dec: Angle.Degrees(-01.24735390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210632"},
        {"Hipparcos Number", "HIP 109571"},
        {"Smithsonian Astrophysical Observation", "SAO 145931"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.94860790),
        dec: Angle.Degrees(-01.24542700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35959",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35959"},
        {"Smithsonian Astrophysical Observation", "SAO 134630"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.748,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.19296981),
        dec: Angle.Degrees(-01.24473206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89322"},
        {"Hipparcos Number", "HIP 50466"},
        {"Geneva Identification System", "GEN# +1.00089322"},
        {"Smithsonian Astrophysical Observation", "SAO 137477"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.56644527),
        dec: Angle.Degrees(-01.24446475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32868"},
        {"Hipparcos Number", "HIP 23740"},
        {"Geneva Identification System", "GEN# +1.00032868"},
        {"Smithsonian Astrophysical Observation", "SAO 131763"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.959,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.54247780),
        dec: Angle.Degrees(-01.24391109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2005"},
        {"Hipparcos Number", "HIP 1927"},
        {"Smithsonian Astrophysical Observation", "SAO 128742"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.07679339),
        dec: Angle.Degrees(-01.24127587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36628"},
        {"Hipparcos Number", "HIP 26012"},
        {"Celescope Catalog", "CEL 778"},
        {"Geneva Identification System", "GEN# +9.00040027"},
        {"Smithsonian Astrophysical Observation", "SAO 132245"},
    },
    visualMagnitude: 7.97,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.26526435),
        dec: Angle.Degrees(-01.24104650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117634"},
        {"Hipparcos Number", "HIP 65987"},
        {"Smithsonian Astrophysical Observation", "SAO 139385"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.93763763),
        dec: Angle.Degrees(-01.23922943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146"},
        {"Hipparcos Number", "HIP 521"},
        {"Smithsonian Astrophysical Observation", "SAO 128584"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.57776022),
        dec: Angle.Degrees(-01.23801760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106268"},
        {"Hipparcos Number", "HIP 59621"},
        {"Geneva Identification System", "GEN# +1.00106268"},
        {"Smithsonian Astrophysical Observation", "SAO 138654"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.40103138),
        dec: Angle.Degrees(-01.23704087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162596"},
        {"Hipparcos Number", "HIP 87428"},
        {"Fundamental Katalog 5th Edition", "FK5 3418"},
        {"Geneva Identification System", "GEN# +1.00162596"},
        {"Smithsonian Astrophysical Observation", "SAO 141913"},
        {"Wilson Evans Batten Catalogue", "WEB 14745"},
    },
    visualMagnitude: 6.33,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.99769952),
        dec: Angle.Degrees(-01.23681150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11946",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11946"},
        {"Smithsonian Astrophysical Observation", "SAO 129980"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.53330333),
        dec: Angle.Degrees(-01.23523031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81524"},
        {"Hipparcos Number", "HIP 46273"},
        {"Geneva Identification System", "GEN# +1.00081524"},
        {"Smithsonian Astrophysical Observation", "SAO 136840"},
    },
    visualMagnitude: 6.58,
    bvColour: 1.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.51590601),
        dec: Angle.Degrees(-01.23493101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79840"},
        {"Hipparcos Number", "HIP 45504"},
        {"Smithsonian Astrophysical Observation", "SAO 136716"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.08699344),
        dec: Angle.Degrees(-01.23370222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108701"},
        {"Hipparcos Number", "HIP 60938"},
        {"Smithsonian Astrophysical Observation", "SAO 138814"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.723,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.34550216),
        dec: Angle.Degrees(-01.23301349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150050"},
        {"Hipparcos Number", "HIP 81484"},
        {"Geneva Identification System", "GEN# +1.00150050"},
        {"Smithsonian Astrophysical Observation", "SAO 141290"},
    },
    visualMagnitude: 6.73,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.63974583),
        dec: Angle.Degrees(-01.23148912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 820"},
        {"Hipparcos Number", "HIP 1018"},
        {"Fundamental Katalog 5th Edition", "FK5 4023"},
        {"Geneva Identification System", "GEN# +1.00000820"},
        {"Smithsonian Astrophysical Observation", "SAO 128639"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.16787813),
        dec: Angle.Degrees(-01.22719433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44354"},
        {"Hipparcos Number", "HIP 30210"},
        {"Geneva Identification System", "GEN# +1.00044354"},
        {"Smithsonian Astrophysical Observation", "SAO 133148"},
    },
    visualMagnitude: 7.57,
    bvColour: -0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.33457104),
        dec: Angle.Degrees(-01.22073679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167897"},
        {"Hipparcos Number", "HIP 89624"},
        {"Smithsonian Astrophysical Observation", "SAO 142195"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.35363516),
        dec: Angle.Degrees(-01.22019505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46487"},
        {"Hipparcos Number", "HIP 31278"},
        {"Fundamental Katalog 5th Edition", "FK5 1175"},
        {"Geneva Identification System", "GEN# +1.00046487"},
        {"Smithsonian Astrophysical Observation", "SAO 133404"},
        {"Wilson Evans Batten Catalogue", "WEB 6253"},
    },
    visualMagnitude: 5.09,
    bvColour: -0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.40800314),
        dec: Angle.Degrees(-01.22011054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71343"},
        {"Hipparcos Number", "HIP 41417"},
        {"Geneva Identification System", "GEN# +1.00071343"},
        {"Smithsonian Astrophysical Observation", "SAO 135921"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.71666181),
        dec: Angle.Degrees(-01.21555478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86995",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10781 A"},
        {"Henry Draper", "HD 161623"},
        {"Hipparcos Number", "HIP 86995"},
        {"Geneva Identification System", "GEN# +1.00161623"},
        {"Smithsonian Astrophysical Observation", "SAO 141866"},
        {"Wilson Evans Batten Catalogue", "WEB 14676"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.66416809),
        dec: Angle.Degrees(-01.21440794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192821"},
        {"Hipparcos Number", "HIP 99979"},
        {"Geneva Identification System", "GEN# +1.00192821"},
        {"Smithsonian Astrophysical Observation", "SAO 144242"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.24294179),
        dec: Angle.Degrees(-01.21172345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192148"},
        {"Hipparcos Number", "HIP 99665"},
        {"Smithsonian Astrophysical Observation", "SAO 144183"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.713,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.37590339),
        dec: Angle.Degrees(-01.21153762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217623"},
        {"Hipparcos Number", "HIP 113736"},
        {"Smithsonian Astrophysical Observation", "SAO 146459"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.51058671),
        dec: Angle.Degrees(-01.20927392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188805"},
        {"Hipparcos Number", "HIP 98161"},
        {"Smithsonian Astrophysical Observation", "SAO 143935"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.23592881),
        dec: Angle.Degrees(-01.20809757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119372"},
        {"Hipparcos Number", "HIP 66927"},
        {"Geneva Identification System", "GEN# +1.00119372"},
        {"Smithsonian Astrophysical Observation", "SAO 139503"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.74089625),
        dec: Angle.Degrees(-01.20800841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71673",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71673"},
        {"Geneva Identification System", "GEN# -0.00002851"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.763,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.90333261),
        dec: Angle.Degrees(-01.20768634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -333.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25037"},
        {"Hipparcos Number", "HIP 18582"},
        {"Geneva Identification System", "GEN# +1.00025037"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.65790868),
        dec: Angle.Degrees(-01.20674817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45156",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45156"},
        {"Smithsonian Astrophysical Observation", "SAO 136652"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.98872571),
        dec: Angle.Degrees(-01.20556042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168932"},
        {"Hipparcos Number", "HIP 90041"},
        {"Geneva Identification System", "GEN# +1.00168932"},
        {"Smithsonian Astrophysical Observation", "SAO 142253"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.59914581),
        dec: Angle.Degrees(-01.20229498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26311",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Alnilam"},
        {"Henry Draper", "HD 37128"},
        {"Hipparcos Number", "HIP 26311"},
        {"Celescope Catalog", "CEL 852"},
        {"Fundamental Katalog 5th Edition", "FK5 210"},
        {"Geneva Identification System", "GEN# +1.00037128"},
        {"Smithsonian Astrophysical Observation", "SAO 132346"},
        {"Wilson Evans Batten Catalogue", "WEB 5173"},
    },
    visualMagnitude: 1.69,
    bvColour: -0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.05338572),
        dec: Angle.Degrees(-01.20191725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10449",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10449"},
        {"Cincinnati Publication", "Ci 20 157"},
        {"Cincinnati Publication 2", "Ci 18 289"},
        {"Geneva Identification System", "GEN# -0.00100306"},
        {"Smithsonian Astrophysical Observation", "SAO 129772"},
        {"Wilson Evans Batten Catalogue", "WEB 2187"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.66549249),
        dec: Angle.Degrees(-01.20122826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 994.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29708"},
        {"Hipparcos Number", "HIP 21777"},
        {"Smithsonian Astrophysical Observation", "SAO 131398"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.17098490),
        dec: Angle.Degrees(-01.20032749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23441",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23441"},
    },
    visualMagnitude: 10.92,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.57934336),
        dec: Angle.Degrees(-01.19871699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61039"},
        {"Hipparcos Number", "HIP 37081"},
        {"Geneva Identification System", "GEN# +1.00061039"},
        {"Smithsonian Astrophysical Observation", "SAO 134897"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.30216767),
        dec: Angle.Degrees(-01.19869115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14954",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2406 A"},
        {"Aitken 2", "ADS 2406"},
        {"Henry Draper", "HD 19994"},
        {"Hipparcos Number", "HIP 14954"},
        {"Fundamental Katalog 5th Edition", "FK5 116"},
        {"Geneva Identification System", "GEN# +1.00019994"},
        {"Smithsonian Astrophysical Observation", "SAO 130355"},
        {"Wilson Evans Batten Catalogue", "WEB 2887"},
    },
    visualMagnitude: 5.07,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.19301506),
        dec: Angle.Degrees(-01.19593294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 193.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15780"},
        {"Hipparcos Number", "HIP 11789"},
        {"Smithsonian Astrophysical Observation", "SAO 129958"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.03606248),
        dec: Angle.Degrees(-01.19486160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116831"},
        {"Hipparcos Number", "HIP 65545"},
        {"Fundamental Katalog 5th Edition", "FK5 3074"},
        {"Geneva Identification System", "GEN# +1.00116831"},
        {"Smithsonian Astrophysical Observation", "SAO 139337"},
    },
    visualMagnitude: 5.97,
    bvColour: 0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.54783683),
        dec: Angle.Degrees(-01.19248368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -114.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100856",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100856"},
    },
    visualMagnitude: 10.12,
    bvColour: 1.775,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.74096286),
        dec: Angle.Degrees(-01.19229356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4641",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 822"},
        {"Henry Draper", "HD 5805"},
        {"Hipparcos Number", "HIP 4641"},
        {"Geneva Identification System", "GEN# +1.00005805J"},
        {"Smithsonian Astrophysical Observation", "SAO 129065"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.765,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.89611970),
        dec: Angle.Degrees(-01.19179977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 79.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82169",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82169"},
        {"Geneva Identification System", "GEN# +9.80019002"},
    },
    visualMagnitude: 10.76,
    bvColour: 1.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.82324937),
        dec: Angle.Degrees(-01.18832026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -242.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97356"},
        {"Hipparcos Number", "HIP 54728"},
        {"Geneva Identification System", "GEN# +1.00097356"},
        {"Smithsonian Astrophysical Observation", "SAO 138055"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.06786317),
        dec: Angle.Degrees(-01.18680321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -160.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212474"},
        {"Hipparcos Number", "HIP 110619"},
        {"Geneva Identification System", "GEN# +1.00212474"},
        {"Smithsonian Astrophysical Observation", "SAO 146074"},
        {"Wilson Evans Batten Catalogue", "WEB 19824"},
    },
    visualMagnitude: 6.74,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.14917543),
        dec: Angle.Degrees(-01.18676669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 113.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138562"},
        {"Hipparcos Number", "HIP 76133"},
        {"Fundamental Katalog 5th Edition", "FK5 3226"},
        {"Geneva Identification System", "GEN# +1.00138562"},
        {"Smithsonian Astrophysical Observation", "SAO 140596"},
        {"Wilson Evans Batten Catalogue", "WEB 12934"},
    },
    visualMagnitude: 5.50,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.24144948),
        dec: Angle.Degrees(-01.18629929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112916"},
        {"Hipparcos Number", "HIP 63453"},
        {"Geneva Identification System", "GEN# +1.00112916"},
        {"Smithsonian Astrophysical Observation", "SAO 139090"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.03189618),
        dec: Angle.Degrees(-01.18597686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4324"},
        {"Hipparcos Number", "HIP 3582"},
        {"Smithsonian Astrophysical Observation", "SAO 128940"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.43662200),
        dec: Angle.Degrees(-01.18477929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82446"},
        {"Hipparcos Number", "HIP 46776"},
        {"Geneva Identification System", "GEN# +1.00082446"},
        {"Smithsonian Astrophysical Observation", "SAO 136932"},
        {"Wilson Evans Batten Catalogue", "WEB 8823"},
    },
    visualMagnitude: 4.54,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.99556148),
        dec: Angle.Degrees(-01.18465438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1145",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1145"},
        {"Smithsonian Astrophysical Observation", "SAO 128653"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.794,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.58517481),
        dec: Angle.Degrees(-01.18463374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150066"},
        {"Hipparcos Number", "HIP 81491"},
        {"Geneva Identification System", "GEN# +1.00150066"},
        {"Smithsonian Astrophysical Observation", "SAO 141292"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.66960405),
        dec: Angle.Degrees(-01.18378735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217211"},
        {"Hipparcos Number", "HIP 113496"},
        {"Smithsonian Astrophysical Observation", "SAO 146423"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.78519405),
        dec: Angle.Degrees(-01.18229950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215462"},
        {"Hipparcos Number", "HIP 112344"},
        {"Geneva Identification System", "GEN# +1.00215462"},
        {"Smithsonian Astrophysical Observation", "SAO 146298"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.33361333),
        dec: Angle.Degrees(-01.17858031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20259"},
        {"Hipparcos Number", "HIP 15158"},
        {"Geneva Identification System", "GEN# +1.00020259A"},
        {"Smithsonian Astrophysical Observation", "SAO 130382"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.84328127),
        dec: Angle.Degrees(-01.17857232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 233.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181609"},
        {"Hipparcos Number", "HIP 95126"},
        {"Geneva Identification System", "GEN# +1.00181609"},
        {"Smithsonian Astrophysical Observation", "SAO 143303"},
        {"Wilson Evans Batten Catalogue", "WEB 16613"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.27844266),
        dec: Angle.Degrees(-01.17645148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25645"},
        {"Hipparcos Number", "HIP 18992"},
        {"Geneva Identification System", "GEN# +1.00025645"},
        {"Smithsonian Astrophysical Observation", "SAO 130911"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.04043084),
        dec: Angle.Degrees(-01.17507824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135439"},
        {"Hipparcos Number", "HIP 74645"},
        {"Smithsonian Astrophysical Observation", "SAO 140413"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.78105583),
        dec: Angle.Degrees(-01.17401945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126471"},
        {"Hipparcos Number", "HIP 70531"},
        {"Smithsonian Astrophysical Observation", "SAO 139924"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.43496868),
        dec: Angle.Degrees(-01.17289730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195256"},
        {"Hipparcos Number", "HIP 101155"},
        {"Smithsonian Astrophysical Observation", "SAO 144505"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.56201493),
        dec: Angle.Degrees(-01.17282314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18105",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18105"},
    },
    visualMagnitude: 10.19,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.04819330),
        dec: Angle.Degrees(-01.17280662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47735",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47735"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.97119855),
        dec: Angle.Degrees(-01.17116127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59518",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59518"},
        {"Smithsonian Astrophysical Observation", "SAO 138646"},
    },
    visualMagnitude: 10.03,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.09589323),
        dec: Angle.Degrees(-01.17037786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37397"},
        {"Hipparcos Number", "HIP 26508"},
        {"Celescope Catalog", "CEL 880"},
        {"Geneva Identification System", "GEN# +9.00040013"},
        {"Smithsonian Astrophysical Observation", "SAO 132390"},
        {"Wilson Evans Batten Catalogue", "WEB 5225"},
    },
    visualMagnitude: 6.84,
    bvColour: -0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.55723040),
        dec: Angle.Degrees(-01.16917313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51689",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51689"},
        {"Smithsonian Astrophysical Observation", "SAO 137638"},
    },
    visualMagnitude: 9.65,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.38705606),
        dec: Angle.Degrees(-01.16889164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94808"},
        {"Hipparcos Number", "HIP 53501"},
        {"Geneva Identification System", "GEN# +1.00094808"},
        {"Smithsonian Astrophysical Observation", "SAO 137898"},
        {"Wilson Evans Batten Catalogue", "WEB 9712"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.16868923),
        dec: Angle.Degrees(-01.16885277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68104"},
        {"Hipparcos Number", "HIP 40064"},
        {"Smithsonian Astrophysical Observation", "SAO 135591"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.76153630),
        dec: Angle.Degrees(-01.16816358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132848"},
        {"Hipparcos Number", "HIP 73498"},
        {"Geneva Identification System", "GEN# +1.00132848"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.33587658),
        dec: Angle.Degrees(-01.16634752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68667"},
        {"Hipparcos Number", "HIP 40263"},
        {"Fundamental Katalog 5th Edition", "FK5 2643"},
        {"Geneva Identification System", "GEN# +1.00068667"},
        {"Smithsonian Astrophysical Observation", "SAO 135643"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.34080229),
        dec: Angle.Degrees(-01.16589834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164142"},
        {"Hipparcos Number", "HIP 88121"},
        {"Smithsonian Astrophysical Observation", "SAO 142019"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.97484577),
        dec: Angle.Degrees(-01.16571073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134985"},
        {"Hipparcos Number", "HIP 74443"},
        {"Cincinnati Publication", "Ci 18 2023"},
        {"Geneva Identification System", "GEN# +1.00134985"},
        {"Smithsonian Astrophysical Observation", "SAO 140380"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.772,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.19897523),
        dec: Angle.Degrees(-01.16540113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -221.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -290.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113641"},
        {"Hipparcos Number", "HIP 63855"},
        {"Smithsonian Astrophysical Observation", "SAO 139141"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.29634725),
        dec: Angle.Degrees(-01.16525991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17807"},
        {"Hipparcos Number", "HIP 13320"},
        {"Smithsonian Astrophysical Observation", "SAO 130147"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.85832900),
        dec: Angle.Degrees(-01.16483085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28144",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4535 AB"},
        {"Henry Draper", "HD 40117"},
        {"Hipparcos Number", "HIP 28144"},
        {"Smithsonian Astrophysical Observation", "SAO 132677"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.21505994),
        dec: Angle.Degrees(-01.16467086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3618"},
        {"Hipparcos Number", "HIP 3072"},
        {"Smithsonian Astrophysical Observation", "SAO 128873"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.74595328),
        dec: Angle.Degrees(-01.16407340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 105.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23363"},
        {"Hipparcos Number", "HIP 17457"},
        {"Fundamental Katalog 5th Edition", "FK5 137"},
        {"Geneva Identification System", "GEN# +1.00023363"},
        {"Smithsonian Astrophysical Observation", "SAO 130698"},
        {"Wilson Evans Batten Catalogue", "WEB 3308"},
    },
    visualMagnitude: 5.24,
    bvColour: -0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.12711667),
        dec: Angle.Degrees(-01.16307844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18834"},
        {"Hipparcos Number", "HIP 14097"},
        {"Smithsonian Astrophysical Observation", "SAO 130246"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.45887220),
        dec: Angle.Degrees(-01.16255132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66428"},
        {"Hipparcos Number", "HIP 39417"},
        {"Cincinnati Publication", "Ci 18 954"},
        {"Geneva Identification System", "GEN# +1.00066428"},
        {"Smithsonian Astrophysical Observation", "SAO 135426"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.86960570),
        dec: Angle.Degrees(-01.16220401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -207.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33637"},
        {"Hipparcos Number", "HIP 24183"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.88953857),
        dec: Angle.Degrees(-01.16133798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12185",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12185"},
        {"Smithsonian Astrophysical Observation", "SAO 130014"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.24340302),
        dec: Angle.Degrees(-01.16122829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104909"},
        {"Hipparcos Number", "HIP 58904"},
        {"Smithsonian Astrophysical Observation", "SAO 138567"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.19357187),
        dec: Angle.Degrees(-01.16026270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144211"},
        {"Hipparcos Number", "HIP 78752"},
        {"Geneva Identification System", "GEN# +1.00144211"},
        {"Smithsonian Astrophysical Observation", "SAO 140934"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.17291009),
        dec: Angle.Degrees(-01.16008016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -145.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18512",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2894 A"},
        {"Henry Draper", "HD 24916"},
        {"Hipparcos Number", "HIP 18512"},
        {"Geneva Identification System", "GEN# +1.00024916"},
        {"Smithsonian Astrophysical Observation", "SAO 130840"},
        {"Wilson Evans Batten Catalogue", "WEB 3569"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.37003110),
        dec: Angle.Degrees(-01.15911386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -182.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -139.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37789"},
        {"Hipparcos Number", "HIP 26749"},
        {"Geneva Identification System", "GEN# +1.00037789"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.24955054),
        dec: Angle.Degrees(-01.15904003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108019",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108019"},
        {"Smithsonian Astrophysical Observation", "SAO 145728"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.25414770),
        dec: Angle.Degrees(-01.15790944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15955",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15955"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.35358554),
        dec: Angle.Degrees(-01.15767702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36695"},
        {"Hipparcos Number", "HIP 26063"},
        {"Celescope Catalog", "CEL 786"},
        {"Geneva Identification System", "GEN# +9.00040026V"},
        {"Geneva Identification System 2", "GEN# +9.00040026"},
        {"Geneva Identification System 3", "GEN# +9.04002610"},
        {"Smithsonian Astrophysical Observation", "SAO 132255"},
        {"Wilson Evans Batten Catalogue", "WEB 5069"},
        {"Wilson Evans Batten Catalogue 2", "WEB 5070"},
    },
    visualMagnitude: 5.36,
    bvColour: -0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.38102882),
        dec: Angle.Degrees(-01.15607162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21214"},
        {"Hipparcos Number", "HIP 15956"},
        {"Smithsonian Astrophysical Observation", "SAO 130477"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.35383894),
        dec: Angle.Degrees(-01.15293709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165512"},
        {"Hipparcos Number", "HIP 88698"},
        {"Fundamental Katalog 5th Edition", "FK5 5595"},
        {"Smithsonian Astrophysical Observation", "SAO 142089"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.61260216),
        dec: Angle.Degrees(-01.15268600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152832"},
        {"Hipparcos Number", "HIP 82849"},
        {"Smithsonian Astrophysical Observation", "SAO 141446"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.948,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.97243964),
        dec: Angle.Degrees(-01.15258488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159370"},
        {"Hipparcos Number", "HIP 85990"},
        {"Geneva Identification System", "GEN# +1.00159370"},
        {"Smithsonian Astrophysical Observation", "SAO 141740"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.62306753),
        dec: Angle.Degrees(-01.15225967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220291"},
        {"Hipparcos Number", "HIP 115403"},
        {"Smithsonian Astrophysical Observation", "SAO 146673"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.66267030),
        dec: Angle.Degrees(-01.15178341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161543"},
        {"Hipparcos Number", "HIP 86964"},
        {"Geneva Identification System", "GEN# +1.00161543"},
        {"Smithsonian Astrophysical Observation", "SAO 141858"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.56327634),
        dec: Angle.Degrees(-01.15005018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26739"},
        {"Hipparcos Number", "HIP 19725"},
        {"Fundamental Katalog 5th Edition", "FK5 2305"},
        {"Geneva Identification System", "GEN# +1.00026739"},
        {"Smithsonian Astrophysical Observation", "SAO 131041"},
        {"Wilson Evans Batten Catalogue", "WEB 3762"},
    },
    visualMagnitude: 6.45,
    bvColour: -0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.40894148),
        dec: Angle.Degrees(-01.14972570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160119"},
        {"Hipparcos Number", "HIP 86320"},
        {"Geneva Identification System", "GEN# +1.00160119"},
        {"Smithsonian Astrophysical Observation", "SAO 141779"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.56268458),
        dec: Angle.Degrees(-01.14963421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24325"},
        {"Hipparcos Number", "HIP 18104"},
        {"Geneva Identification System", "GEN# +1.00024325"},
        {"Smithsonian Astrophysical Observation", "SAO 130780"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.03619402),
        dec: Angle.Degrees(-01.14877013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70923"},
        {"Hipparcos Number", "HIP 41209"},
        {"Geneva Identification System", "GEN# +1.00070923J"},
        {"Smithsonian Astrophysical Observation", "SAO 135874"},
        {"Wilson Evans Batten Catalogue", "WEB 7971"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.13837425),
        dec: Angle.Degrees(-01.14795006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -188.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169225"},
        {"Hipparcos Number", "HIP 90150"},
        {"Geneva Identification System", "GEN# +1.00169225"},
        {"Smithsonian Astrophysical Observation", "SAO 142270"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.95663792),
        dec: Angle.Degrees(-01.14641060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5112"},
        {"Hipparcos Number", "HIP 4147"},
        {"Fundamental Katalog 5th Edition", "FK5 1022"},
        {"Geneva Identification System", "GEN# +1.00005112"},
        {"Smithsonian Astrophysical Observation", "SAO 129009"},
        {"Wilson Evans Batten Catalogue", "WEB 738"},
    },
    visualMagnitude: 4.78,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.25204382),
        dec: Angle.Degrees(-01.14422060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153212"},
        {"Hipparcos Number", "HIP 83031"},
        {"Geneva Identification System", "GEN# +1.00153212"},
        {"Smithsonian Astrophysical Observation", "SAO 141459"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.50850743),
        dec: Angle.Degrees(-01.14373996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27091"},
        {"Hipparcos Number", "HIP 19953"},
        {"Smithsonian Astrophysical Observation", "SAO 131085"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.18846691),
        dec: Angle.Degrees(-01.14363414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47431",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Ukdah"},
        {"Henry Draper", "HD 83618"},
        {"Hipparcos Number", "HIP 47431"},
        {"Fundamental Katalog 5th Edition", "FK5 1250"},
        {"Geneva Identification System", "GEN# +1.00083618"},
        {"Smithsonian Astrophysical Observation", "SAO 137035"},
        {"Wilson Evans Batten Catalogue", "WEB 8903"},
    },
    visualMagnitude: 3.90,
    bvColour: 1.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.96389156),
        dec: Angle.Degrees(-01.14265722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192426"},
        {"Hipparcos Number", "HIP 99797"},
        {"Smithsonian Astrophysical Observation", "SAO 144208"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.71545959),
        dec: Angle.Degrees(-01.14192314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179872"},
        {"Hipparcos Number", "HIP 94523"},
        {"Smithsonian Astrophysical Observation", "SAO 143168"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.57548605),
        dec: Angle.Degrees(-01.14089641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224909"},
        {"Hipparcos Number", "HIP 134"},
        {"Smithsonian Astrophysical Observation", "SAO 147039"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.42514055),
        dec: Angle.Degrees(-01.13997217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34595"},
        {"Hipparcos Number", "HIP 24758"},
        {"Smithsonian Astrophysical Observation", "SAO 131966"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.62489365),
        dec: Angle.Degrees(-01.13823895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114517",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114517"},
        {"Fundamental Katalog 5th Edition", "FK5 6050"},
        {"Smithsonian Astrophysical Observation", "SAO 146552"},
    },
    visualMagnitude: 9.50,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.92291416),
        dec: Angle.Degrees(-01.13456234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41420"},
        {"Hipparcos Number", "HIP 28811"},
        {"Geneva Identification System", "GEN# +1.00041420"},
        {"Smithsonian Astrophysical Observation", "SAO 132806"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.23815517),
        dec: Angle.Degrees(-01.13407350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52610"},
        {"Hipparcos Number", "HIP 33874"},
        {"Geneva Identification System", "GEN# +1.00052610"},
        {"Smithsonian Astrophysical Observation", "SAO 134074"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.47341805),
        dec: Angle.Degrees(-01.13096512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152449"},
        {"Hipparcos Number", "HIP 82629"},
        {"Geneva Identification System", "GEN# +1.00152449"},
        {"Smithsonian Astrophysical Observation", "SAO 141421"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.37140163),
        dec: Angle.Degrees(-01.13042584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29961",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29961"},
        {"Wilson Evans Batten Catalogue", "WEB 5945"},
    },
    visualMagnitude: 9.75,
    bvColour: 2.814,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.60772500),
        dec: Angle.Degrees(-01.12956021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201983"},
        {"Hipparcos Number", "HIP 104740"},
        {"Smithsonian Astrophysical Observation", "SAO 145209"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.28362689),
        dec: Angle.Degrees(-01.12951056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73317"},
        {"Hipparcos Number", "HIP 42325"},
        {"Smithsonian Astrophysical Observation", "SAO 136108"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.43519350),
        dec: Angle.Degrees(-01.12909695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142162"},
        {"Hipparcos Number", "HIP 77792"},
        {"Smithsonian Astrophysical Observation", "SAO 140818"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.27479365),
        dec: Angle.Degrees(-01.12889706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37756"},
        {"Hipparcos Number", "HIP 26736"},
        {"Celescope Catalog", "CEL 922"},
        {"Geneva Identification System", "GEN# +1.00037756"},
        {"Smithsonian Astrophysical Observation", "SAO 132445"},
        {"Wilson Evans Batten Catalogue", "WEB 5272"},
    },
    visualMagnitude: 4.95,
    bvColour: -0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.21131577),
        dec: Angle.Degrees(-01.12878569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209224"},
        {"Hipparcos Number", "HIP 108748"},
        {"Geneva Identification System", "GEN# +1.00209224"},
        {"Smithsonian Astrophysical Observation", "SAO 145817"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.44248847),
        dec: Angle.Degrees(-01.12838887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 165.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50747"},
        {"Hipparcos Number", "HIP 33184"},
        {"Fundamental Katalog 5th Edition", "FK5 2533"},
        {"Geneva Identification System", "GEN# +1.00050747"},
        {"Renson", "Renson 13940"},
        {"Smithsonian Astrophysical Observation", "SAO 133870"},
        {"Wilson Evans Batten Catalogue", "WEB 6672"},
    },
    visualMagnitude: 5.44,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.60273751),
        dec: Angle.Degrees(-01.12696090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88803"},
        {"Hipparcos Number", "HIP 50177"},
        {"Smithsonian Astrophysical Observation", "SAO 137434"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.63945186),
        dec: Angle.Degrees(-01.12694076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85990"},
        {"Hipparcos Number", "HIP 48671"},
        {"Geneva Identification System", "GEN# +1.00085990"},
        {"Smithsonian Astrophysical Observation", "SAO 137229"},
        {"Wilson Evans Batten Catalogue", "WEB 9055"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.89639123),
        dec: Angle.Degrees(-01.12614559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59726"},
        {"Hipparcos Number", "HIP 36565"},
        {"Geneva Identification System", "GEN# +1.00059726"},
        {"Smithsonian Astrophysical Observation", "SAO 134781"},
    },
    visualMagnitude: 6.57,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.82232417),
        dec: Angle.Degrees(-01.12585847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178131"},
        {"Hipparcos Number", "HIP 93919"},
        {"Smithsonian Astrophysical Observation", "SAO 143042"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.85996389),
        dec: Angle.Degrees(-01.12556594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77354"},
        {"Hipparcos Number", "HIP 44353"},
        {"Geneva Identification System", "GEN# +1.00077354"},
        {"Smithsonian Astrophysical Observation", "SAO 136509"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.48681509),
        dec: Angle.Degrees(-01.12523933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90710"},
        {"Hipparcos Number", "HIP 51274"},
        {"Geneva Identification System", "GEN# +1.00090710"},
        {"Smithsonian Astrophysical Observation", "SAO 137586"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.10073799),
        dec: Angle.Degrees(-01.12371980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 716"},
        {"Hipparcos Number", "HIP 925"},
        {"Smithsonian Astrophysical Observation", "SAO 128630"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.87910532),
        dec: Angle.Degrees(-01.12332479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211628"},
        {"Hipparcos Number", "HIP 110128"},
        {"Geneva Identification System", "GEN# +1.00211628"},
        {"Smithsonian Astrophysical Observation", "SAO 146010"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.62323757),
        dec: Angle.Degrees(-01.12302705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17914",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17914"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.46439382),
        dec: Angle.Degrees(-01.12243114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211567"},
        {"Hipparcos Number", "HIP 110097"},
        {"Smithsonian Astrophysical Observation", "SAO 146005"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.53804956),
        dec: Angle.Degrees(-01.12206446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 207.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9395",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9395"},
    },
    visualMagnitude: 9.61,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.18811484),
        dec: Angle.Degrees(-01.12165208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59625"},
        {"Hipparcos Number", "HIP 36519"},
        {"Geneva Identification System", "GEN# +1.00059625"},
        {"Smithsonian Astrophysical Observation", "SAO 134770"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.69101948),
        dec: Angle.Degrees(-01.12122813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22819"},
        {"Hipparcos Number", "HIP 17120"},
        {"Geneva Identification System", "GEN# +1.00022819"},
        {"Smithsonian Astrophysical Observation", "SAO 130645"},
    },
    visualMagnitude: 6.12,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.99812309),
        dec: Angle.Degrees(-01.12121089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2629"},
        {"Hipparcos Number", "HIP 2343"},
        {"Fundamental Katalog 5th Edition", "FK5 4047"},
        {"Geneva Identification System", "GEN# +1.00002629"},
        {"Smithsonian Astrophysical Observation", "SAO 128789"},
        {"Wilson Evans Batten Catalogue", "WEB 426"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.48020106),
        dec: Angle.Degrees(-01.11755497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 149.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130484"},
        {"Hipparcos Number", "HIP 72428"},
        {"Smithsonian Astrophysical Observation", "SAO 140148"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.14533426),
        dec: Angle.Degrees(-01.11754841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145464"},
        {"Hipparcos Number", "HIP 79307"},
        {"Geneva Identification System", "GEN# +1.00145464"},
        {"Smithsonian Astrophysical Observation", "SAO 141018"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.78343721),
        dec: Angle.Degrees(-01.11382948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -135.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172103"},
        {"Hipparcos Number", "HIP 91384"},
        {"Geneva Identification System", "GEN# +1.00172103"},
        {"Smithsonian Astrophysical Observation", "SAO 142460"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.57926259),
        dec: Angle.Degrees(-01.11298892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78664"},
        {"Hipparcos Number", "HIP 44951"},
        {"Geneva Identification System", "GEN# +1.00078664"},
        {"Smithsonian Astrophysical Observation", "SAO 136619"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.37259055),
        dec: Angle.Degrees(-01.11246701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29978"},
        {"Hipparcos Number", "HIP 21981"},
        {"Smithsonian Astrophysical Observation", "SAO 131441"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.87790737),
        dec: Angle.Degrees(-01.11136151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108202"},
        {"Hipparcos Number", "HIP 60648"},
        {"Geneva Identification System", "GEN# +1.00108202"},
    },
    visualMagnitude: 10.26,
    bvColour: 1.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.46340545),
        dec: Angle.Degrees(-01.11040161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -309.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34747"},
        {"Hipparcos Number", "HIP 24849"},
        {"Smithsonian Astrophysical Observation", "SAO 131984"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.91155345),
        dec: Angle.Degrees(-01.10849726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101847",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14081 A"},
        {"Henry Draper", "HD 196574"},
        {"Hipparcos Number", "HIP 101847"},
        {"Geneva Identification System", "GEN# +1.00196574"},
        {"Smithsonian Astrophysical Observation", "SAO 144649"},
        {"Wilson Evans Batten Catalogue", "WEB 18399"},
    },
    visualMagnitude: 4.31,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.58447294),
        dec: Angle.Degrees(-01.10507951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16045",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16045"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.64995559),
        dec: Angle.Degrees(-01.10407487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112477"},
        {"Hipparcos Number", "HIP 63201"},
        {"Smithsonian Astrophysical Observation", "SAO 139059"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.23557722),
        dec: Angle.Degrees(-01.10344796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102927",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102927"},
        {"Smithsonian Astrophysical Observation", "SAO 144873"},
    },
    visualMagnitude: 9.46,
    bvColour: 1.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.79635735),
        dec: Angle.Degrees(-01.10269708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146916"},
        {"Hipparcos Number", "HIP 79919"},
        {"Smithsonian Astrophysical Observation", "SAO 141092"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.68886386),
        dec: Angle.Degrees(-01.10106589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187350"},
        {"Hipparcos Number", "HIP 97545"},
        {"Geneva Identification System", "GEN# +1.00187350"},
        {"Smithsonian Astrophysical Observation", "SAO 143824"},
        {"Wilson Evans Batten Catalogue", "WEB 17155"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.38940530),
        dec: Angle.Degrees(-01.10101789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53116"},
        {"Hipparcos Number", "HIP 34049"},
        {"Fundamental Katalog 5th Edition", "FK5 4636"},
        {"Geneva Identification System", "GEN# +1.00053116"},
        {"Renson", "Renson 14620"},
        {"Smithsonian Astrophysical Observation", "SAO 134128"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.94797027),
        dec: Angle.Degrees(-01.09963605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172215"},
        {"Hipparcos Number", "HIP 91452"},
        {"Smithsonian Astrophysical Observation", "SAO 142469"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.78102221),
        dec: Angle.Degrees(-01.09949196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34672"},
        {"Hipparcos Number", "HIP 24811"},
        {"Geneva Identification System", "GEN# +1.00034672"},
        {"Smithsonian Astrophysical Observation", "SAO 131975"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.78112785),
        dec: Angle.Degrees(-01.09880445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116915",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116915"},
        {"Smithsonian Astrophysical Observation", "SAO 146851"},
    },
    visualMagnitude: 9.48,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.48200267),
        dec: Angle.Degrees(-01.09805941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106029"},
        {"Hipparcos Number", "HIP 59491"},
        {"Smithsonian Astrophysical Observation", "SAO 138642"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.00770703),
        dec: Angle.Degrees(-01.09777576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75013"},
        {"Hipparcos Number", "HIP 43161"},
        {"Smithsonian Astrophysical Observation", "SAO 136279"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.86692230),
        dec: Angle.Degrees(-01.09763892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46886"},
        {"Hipparcos Number", "HIP 31492"},
        {"Geneva Identification System", "GEN# +1.00046886"},
        {"Smithsonian Astrophysical Observation", "SAO 133448"},
    },
    visualMagnitude: 7.95,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.93670753),
        dec: Angle.Degrees(-01.09668682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170116"},
        {"Hipparcos Number", "HIP 90491"},
        {"Smithsonian Astrophysical Observation", "SAO 142333"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.97797293),
        dec: Angle.Degrees(-01.09344967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22867",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22867"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.78769616),
        dec: Angle.Degrees(-01.09273849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25737",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4097 A"},
        {"Henry Draper", "HD 36167"},
        {"Hipparcos Number", "HIP 25737"},
        {"Geneva Identification System", "GEN# +1.00036167A"},
        {"Geneva Identification System 2", "GEN# +1.00036167J"},
        {"Smithsonian Astrophysical Observation", "SAO 132176"},
        {"Wilson Evans Batten Catalogue", "WEB 4996"},
    },
    visualMagnitude: 4.71,
    bvColour: 1.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.43325647),
        dec: Angle.Degrees(-01.09217557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80502",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80502"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.856,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.49684319),
        dec: Angle.Degrees(-01.09122023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -169.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26033"},
        {"Hipparcos Number", "HIP 19227"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.81619866),
        dec: Angle.Degrees(-01.08878644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126613"},
        {"Hipparcos Number", "HIP 70611"},
        {"Smithsonian Astrophysical Observation", "SAO 139931"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.864,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.65689644),
        dec: Angle.Degrees(-01.08615948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221409"},
        {"Hipparcos Number", "HIP 116146"},
        {"Geneva Identification System", "GEN# +1.00221409"},
        {"Smithsonian Astrophysical Observation", "SAO 146756"},
        {"Wilson Evans Batten Catalogue", "WEB 20532"},
    },
    visualMagnitude: 6.39,
    bvColour: 1.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.98983817),
        dec: Angle.Degrees(-01.08592434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9591",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9591"},
        {"Smithsonian Astrophysical Observation", "SAO 129660"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.842,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.83701493),
        dec: Angle.Degrees(-01.08565537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 159.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -133.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22305",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22305"},
        {"Smithsonian Astrophysical Observation", "SAO 131497"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.06103553),
        dec: Angle.Degrees(-01.08453070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56677",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56677"},
        {"Smithsonian Astrophysical Observation", "SAO 138303"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.32009644),
        dec: Angle.Degrees(-01.08223536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -130.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64276"},
        {"Hipparcos Number", "HIP 38496"},
        {"Fundamental Katalog 5th Edition", "FK5 4709"},
        {"Smithsonian Astrophysical Observation", "SAO 135211"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.925,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.25753250),
        dec: Angle.Degrees(-01.08090012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83853",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10355 AB"},
        {"Henry Draper", "HD 154895"},
        {"Hipparcos Number", "HIP 83853"},
        {"Geneva Identification System", "GEN# +1.00154895"},
        {"Smithsonian Astrophysical Observation", "SAO 141528"},
        {"Wilson Evans Batten Catalogue", "WEB 14171"},
    },
    visualMagnitude: 6.06,
    bvColour: 0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.05690056),
        dec: Angle.Degrees(-01.07937767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224119"},
        {"Hipparcos Number", "HIP 117937"},
        {"Smithsonian Astrophysical Observation", "SAO 146979"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.84381455),
        dec: Angle.Degrees(-01.07929939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69866",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69866"},
    },
    visualMagnitude: 10.45,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.45957852),
        dec: Angle.Degrees(-01.07905916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193329"},
        {"Hipparcos Number", "HIP 100232"},
        {"Geneva Identification System", "GEN# +1.00193329"},
        {"Smithsonian Astrophysical Observation", "SAO 144296"},
    },
    visualMagnitude: 6.05,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.93016868),
        dec: Angle.Degrees(-01.07859255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99362"},
        {"Hipparcos Number", "HIP 55800"},
        {"Geneva Identification System", "GEN# +1.00099362"},
        {"Smithsonian Astrophysical Observation", "SAO 138203"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.49763859),
        dec: Angle.Degrees(-01.07835910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202605"},
        {"Hipparcos Number", "HIP 105066"},
        {"Fundamental Katalog 5th Edition", "FK5 5878"},
        {"Smithsonian Astrophysical Observation", "SAO 145264"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.25849385),
        dec: Angle.Degrees(-01.07736898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 160.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123410"},
        {"Hipparcos Number", "HIP 68997"},
        {"Smithsonian Astrophysical Observation", "SAO 139743"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.88936839),
        dec: Angle.Degrees(-01.07718910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39732"},
        {"Hipparcos Number", "HIP 27912"},
        {"Smithsonian Astrophysical Observation", "SAO 132630"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.758,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.59368263),
        dec: Angle.Degrees(-01.07649606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45972",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7329 AB"},
        {"Henry Draper", "HD 80916"},
        {"Hipparcos Number", "HIP 45972"},
        {"Smithsonian Astrophysical Observation", "SAO 136793"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.63353749),
        dec: Angle.Degrees(-01.07570985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78777"},
        {"Hipparcos Number", "HIP 45008"},
        {"Geneva Identification System", "GEN# +1.00078777"},
        {"Smithsonian Astrophysical Observation", "SAO 136629"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.50614006),
        dec: Angle.Degrees(-01.07465524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113909",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113909"},
        {"Smithsonian Astrophysical Observation", "SAO 146483"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.01258061),
        dec: Angle.Degrees(-01.07421178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45319"},
        {"Hipparcos Number", "HIP 30667"},
        {"Geneva Identification System", "GEN# +1.00045319"},
        {"Smithsonian Astrophysical Observation", "SAO 133259"},
    },
    visualMagnitude: 7.77,
    bvColour: -0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.66521205),
        dec: Angle.Degrees(-01.07344902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27406",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27406"},
    },
    visualMagnitude: 12.02,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.05026544),
        dec: Angle.Degrees(-01.07041406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -158.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108125"},
        {"Hipparcos Number", "HIP 60602"},
        {"Smithsonian Astrophysical Observation", "SAO 138768"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.32504788),
        dec: Angle.Degrees(-01.06991293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194077"},
        {"Hipparcos Number", "HIP 100572"},
        {"Geneva Identification System", "GEN# +1.00194077"},
        {"Smithsonian Astrophysical Observation", "SAO 144374"},
    },
    visualMagnitude: 8.29,
    bvColour: -0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.91328765),
        dec: Angle.Degrees(-01.06967202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87095"},
        {"Hipparcos Number", "HIP 49221"},
        {"Fundamental Katalog 5th Edition", "FK5 4890"},
        {"Geneva Identification System", "GEN# +1.00087095"},
        {"Smithsonian Astrophysical Observation", "SAO 137312"},
    },
    visualMagnitude: 6.70,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.70513833),
        dec: Angle.Degrees(-01.06762948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31623"},
        {"Hipparcos Number", "HIP 23041"},
        {"Fundamental Katalog 5th Edition", "FK5 2373"},
        {"Geneva Identification System", "GEN# +1.00031623"},
        {"Smithsonian Astrophysical Observation", "SAO 131625"},
        {"Wilson Evans Batten Catalogue", "WEB 4471"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.32171783),
        dec: Angle.Degrees(-01.06719185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20646"},
        {"Hipparcos Number", "HIP 15465"},
        {"Geneva Identification System", "GEN# +1.00020646"},
        {"Wilson Evans Batten Catalogue", "WEB 2973"},
    },
    visualMagnitude: 10.19,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.85857873),
        dec: Angle.Degrees(-01.06559345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74349"},
        {"Hipparcos Number", "HIP 42817"},
        {"Geneva Identification System", "GEN# +1.00074349"},
        {"Smithsonian Astrophysical Observation", "SAO 136215"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.86896185),
        dec: Angle.Degrees(-01.06526903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139672"},
        {"Hipparcos Number", "HIP 76681"},
        {"Smithsonian Astrophysical Observation", "SAO 140683"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.87939846),
        dec: Angle.Degrees(-01.06525028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169367"},
        {"Hipparcos Number", "HIP 90207"},
        {"Geneva Identification System", "GEN# +1.00169367"},
        {"Smithsonian Astrophysical Observation", "SAO 142282"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.09786779),
        dec: Angle.Degrees(-01.06380348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141105"},
        {"Hipparcos Number", "HIP 77348"},
        {"Geneva Identification System", "GEN# +1.00141105"},
        {"Smithsonian Astrophysical Observation", "SAO 140763"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.789,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.85070435),
        dec: Angle.Degrees(-01.06350545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199334"},
        {"Hipparcos Number", "HIP 103370"},
        {"Geneva Identification System", "GEN# +1.00199334"},
        {"Smithsonian Astrophysical Observation", "SAO 144964"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.14194673),
        dec: Angle.Degrees(-01.06346511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39908"},
        {"Hipparcos Number", "HIP 28014"},
        {"Smithsonian Astrophysical Observation", "SAO 132651"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.88295007),
        dec: Angle.Degrees(-01.06274753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85667",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10598 AB"},
        {"Henry Draper", "HD 158614"},
        {"Hipparcos Number", "HIP 85667"},
        {"Geneva Identification System", "GEN# +1.00158614"},
        {"Smithsonian Astrophysical Observation", "SAO 141702"},
        {"Wilson Evans Batten Catalogue", "WEB 14453"},
    },
    visualMagnitude: 5.31,
    bvColour: 0.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.59946496),
        dec: Angle.Degrees(-01.06250365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -126.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -172.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43002"},
        {"Hipparcos Number", "HIP 29571"},
        {"Geneva Identification System", "GEN# +1.00043002"},
        {"Smithsonian Astrophysical Observation", "SAO 132992"},
    },
    visualMagnitude: 7.97,
    bvColour: -0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.45903523),
        dec: Angle.Degrees(-01.06130690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137449"},
        {"Hipparcos Number", "HIP 75559"},
        {"Smithsonian Astrophysical Observation", "SAO 140528"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.53249198),
        dec: Angle.Degrees(-01.05958644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148408"},
        {"Hipparcos Number", "HIP 80630"},
        {"Geneva Identification System", "GEN# +1.00148408"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)27, 50.3300),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)03, 33.400)
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
    primaryId: "HIP 6639",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6639"},
        {"Cincinnati Publication", "Ci 18 190"},
        {"Geneva Identification System", "GEN# -0.00100184"},
        {"Smithsonian Astrophysical Observation", "SAO 129285"},
    },
    visualMagnitude: 9.48,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.29000636),
        dec: Angle.Degrees(-01.05897236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -194.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -291.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8161",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8161"},
        {"Smithsonian Astrophysical Observation", "SAO 129484"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.804,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.24581405),
        dec: Angle.Degrees(-01.05841728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 206.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86708"},
        {"Hipparcos Number", "HIP 49037"},
        {"Smithsonian Astrophysical Observation", "SAO 137280"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.07332145),
        dec: Angle.Degrees(-01.05722964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219313"},
        {"Hipparcos Number", "HIP 114770"},
        {"Smithsonian Astrophysical Observation", "SAO 146590"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.72896940),
        dec: Angle.Degrees(-01.05624973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132847"},
        {"Hipparcos Number", "HIP 73496"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.33140028),
        dec: Angle.Degrees(-01.05463096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9012"},
        {"Hipparcos Number", "HIP 6884"},
        {"Smithsonian Astrophysical Observation", "SAO 129318"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.16742207),
        dec: Angle.Degrees(-01.05460056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29610"},
        {"Hipparcos Number", "HIP 21718"},
        {"Geneva Identification System", "GEN# +1.00029610"},
        {"Smithsonian Astrophysical Observation", "SAO 131392"},
    },
    visualMagnitude: 6.11,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.94670263),
        dec: Angle.Degrees(-01.05243771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112665"},
        {"Hipparcos Number", "HIP 63309"},
        {"Geneva Identification System", "GEN# +1.00112665"},
        {"Smithsonian Astrophysical Observation", "SAO 139070"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.61508434),
        dec: Angle.Degrees(-01.05184009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53865",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53865"},
        {"Smithsonian Astrophysical Observation", "SAO 137939"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.29526606),
        dec: Angle.Degrees(-01.05008862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17079"},
        {"Hipparcos Number", "HIP 12801"},
        {"Smithsonian Astrophysical Observation", "SAO 130089"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.13428837),
        dec: Angle.Degrees(-01.04933352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216614"},
        {"Hipparcos Number", "HIP 113106"},
        {"Geneva Identification System", "GEN# +1.00216614"},
        {"Smithsonian Astrophysical Observation", "SAO 146381"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.57534286),
        dec: Angle.Degrees(-01.04916004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123509"},
        {"Hipparcos Number", "HIP 69058"},
        {"Smithsonian Astrophysical Observation", "SAO 139747"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.03117537),
        dec: Angle.Degrees(-01.04853454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75217"},
        {"Hipparcos Number", "HIP 43246"},
        {"Geneva Identification System", "GEN# +1.00075217"},
        {"Smithsonian Astrophysical Observation", "SAO 136294"},
    },
    visualMagnitude: 6.42,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.15617274),
        dec: Angle.Degrees(-01.04483247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174646"},
        {"Hipparcos Number", "HIP 92553"},
        {"Geneva Identification System", "GEN# +1.00174646"},
        {"Renson", "Renson 48910"},
        {"Smithsonian Astrophysical Observation", "SAO 142713"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.90805149),
        dec: Angle.Degrees(-01.04439301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197657"},
        {"Hipparcos Number", "HIP 102413"},
        {"Smithsonian Astrophysical Observation", "SAO 144766"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.30109771),
        dec: Angle.Degrees(-01.04292624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35153"},
        {"Hipparcos Number", "HIP 25121"},
        {"Smithsonian Astrophysical Observation", "SAO 132038"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.66173236),
        dec: Angle.Degrees(-01.04274481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103341"},
        {"Hipparcos Number", "HIP 58021"},
        {"Geneva Identification System", "GEN# +1.00103341"},
        {"Smithsonian Astrophysical Observation", "SAO 138467"},
        {"Wilson Evans Batten Catalogue", "WEB 10392"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.50911983),
        dec: Angle.Degrees(-01.03952673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158557"},
        {"Hipparcos Number", "HIP 85640"},
        {"Smithsonian Astrophysical Observation", "SAO 141699"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.52240700),
        dec: Angle.Degrees(-01.03781650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10505"},
        {"Hipparcos Number", "HIP 7972"},
        {"Geneva Identification System", "GEN# +1.00010505"},
        {"Smithsonian Astrophysical Observation", "SAO 129460"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.60491482),
        dec: Angle.Degrees(-01.03699313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144877"},
        {"Hipparcos Number", "HIP 79040"},
        {"Geneva Identification System", "GEN# +1.00144877"},
        {"Smithsonian Astrophysical Observation", "SAO 140979"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.00778980),
        dec: Angle.Degrees(-01.03621111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83685"},
        {"Hipparcos Number", "HIP 47444"},
        {"Geneva Identification System", "GEN# +1.00083685"},
        {"Smithsonian Astrophysical Observation", "SAO 137041"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.04086106),
        dec: Angle.Degrees(-01.03583853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221146"},
        {"Hipparcos Number", "HIP 115951"},
        {"Fundamental Katalog 5th Edition", "FK5 6076"},
        {"Geneva Identification System", "GEN# +1.00221146"},
        {"Smithsonian Astrophysical Observation", "SAO 146735"},
        {"Wilson Evans Batten Catalogue", "WEB 20507"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.37635363),
        dec: Angle.Degrees(-01.03582677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26106",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4159 A"},
        {"Henry Draper", "HD 36779"},
        {"Hipparcos Number", "HIP 26106"},
        {"Celescope Catalog", "CEL 792"},
        {"Geneva Identification System", "GEN# +9.00040025"},
        {"Geneva Identification System 2", "GEN# +9.04002510"},
        {"Smithsonian Astrophysical Observation", "SAO 132269"},
        {"Wilson Evans Batten Catalogue", "WEB 5084"},
    },
    visualMagnitude: 6.24,
    bvColour: -0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.51620482),
        dec: Angle.Degrees(-01.03571938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16021",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2533 A"},
        {"Henry Draper", "HD 21316"},
        {"Hipparcos Number", "HIP 16021"},
        {"Geneva Identification System", "GEN# +1.00021316"},
        {"Smithsonian Astrophysical Observation", "SAO 130487"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.57215089),
        dec: Angle.Degrees(-01.03502715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15779"},
        {"Hipparcos Number", "HIP 11791"},
        {"Geneva Identification System", "GEN# +1.00015779"},
        {"Smithsonian Astrophysical Observation", "SAO 129959"},
        {"Wilson Evans Batten Catalogue", "WEB 2445"},
    },
    visualMagnitude: 5.36,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.03931801),
        dec: Angle.Degrees(-01.03481751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185091"},
        {"Hipparcos Number", "HIP 96535"},
        {"Geneva Identification System", "GEN# +1.00185091"},
        {"Smithsonian Astrophysical Observation", "SAO 143611"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.39150086),
        dec: Angle.Degrees(-01.03404036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58425",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58425"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.69691691),
        dec: Angle.Degrees(-01.03318294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86259",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10676 AB"},
        {"Henry Draper", "HD 159973"},
        {"Hipparcos Number", "HIP 86259"},
        {"Smithsonian Astrophysical Observation", "SAO 141769"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.38958840),
        dec: Angle.Degrees(-01.03310937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55112"},
        {"Hipparcos Number", "HIP 34736"},
        {"Smithsonian Astrophysical Observation", "SAO 134322"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.87664943),
        dec: Angle.Degrees(-01.03138050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67548"},
        {"Hipparcos Number", "HIP 39844"},
        {"Smithsonian Astrophysical Observation", "SAO 135547"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.10906526),
        dec: Angle.Degrees(-01.03128961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142070"},
        {"Hipparcos Number", "HIP 77752"},
        {"Geneva Identification System", "GEN# +1.00142070"},
        {"Renson", "Renson 40330"},
        {"Smithsonian Astrophysical Observation", "SAO 140814"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.14614833),
        dec: Angle.Degrees(-01.03128517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11334",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11334"},
    },
    visualMagnitude: 10.64,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.45965267),
        dec: Angle.Degrees(-01.02735930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189357"},
        {"Hipparcos Number", "HIP 98410"},
        {"Smithsonian Astrophysical Observation", "SAO 143975"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.92610535),
        dec: Angle.Degrees(-01.02732704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200965"},
        {"Hipparcos Number", "HIP 104209"},
        {"Smithsonian Astrophysical Observation", "SAO 145105"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.69169013),
        dec: Angle.Degrees(-01.02516037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64985"},
        {"Hipparcos Number", "HIP 38801"},
        {"Smithsonian Astrophysical Observation", "SAO 135278"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.11263387),
        dec: Angle.Degrees(-01.02450902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15259"},
        {"Hipparcos Number", "HIP 11425"},
        {"Geneva Identification System", "GEN# +1.00015259"},
        {"Smithsonian Astrophysical Observation", "SAO 129912"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.84256954),
        dec: Angle.Degrees(-01.02423370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120282"},
        {"Hipparcos Number", "HIP 67373"},
        {"Geneva Identification System", "GEN# +1.00120282"},
        {"Smithsonian Astrophysical Observation", "SAO 139563"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.13705708),
        dec: Angle.Degrees(-01.02270366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137006"},
        {"Hipparcos Number", "HIP 75342"},
        {"Fundamental Katalog 5th Edition", "FK5 1406"},
        {"Geneva Identification System", "GEN# +1.00137006"},
        {"Smithsonian Astrophysical Observation", "SAO 140502"},
        {"Wilson Evans Batten Catalogue", "WEB 12852"},
    },
    visualMagnitude: 6.11,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.93194231),
        dec: Angle.Degrees(-01.02231511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5931"},
        {"Hipparcos Number", "HIP 4735"},
        {"Smithsonian Astrophysical Observation", "SAO 129077"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.20686420),
        dec: Angle.Degrees(-01.02189726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48808"},
        {"Hipparcos Number", "HIP 32345"},
        {"Geneva Identification System", "GEN# +1.00048808"},
        {"Smithsonian Astrophysical Observation", "SAO 133638"},
    },
    visualMagnitude: 7.45,
    bvColour: -0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.27791988),
        dec: Angle.Degrees(-01.02098594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203509"},
        {"Hipparcos Number", "HIP 105549"},
        {"Renson", "Renson 56640"},
        {"Smithsonian Astrophysical Observation", "SAO 145346"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.65419021),
        dec: Angle.Degrees(-01.02017539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53665"},
        {"Hipparcos Number", "HIP 34239"},
        {"Geneva Identification System", "GEN# +1.00053665"},
        {"Smithsonian Astrophysical Observation", "SAO 134179"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.46981020),
        dec: Angle.Degrees(-01.02001324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -186.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15430",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2464 AB"},
        {"Henry Draper", "HD 20601"},
        {"Hipparcos Number", "HIP 15430"},
        {"Geneva Identification System", "GEN# +1.00020601"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.72001033),
        dec: Angle.Degrees(-01.01937291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 180.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 93.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12203",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12203"},
        {"Smithsonian Astrophysical Observation", "SAO 130019"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.28518747),
        dec: Angle.Degrees(-01.01930358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86902"},
        {"Hipparcos Number", "HIP 49125"},
        {"Geneva Identification System", "GEN# +1.00086902"},
        {"Renson", "Renson 24820"},
        {"Smithsonian Astrophysical Observation", "SAO 137294"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.39758816),
        dec: Angle.Degrees(-01.01811964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161902"},
        {"Hipparcos Number", "HIP 87143"},
        {"Smithsonian Astrophysical Observation", "SAO 141884"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.06710818),
        dec: Angle.Degrees(-01.01655008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70397",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70397"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.04476510),
        dec: Angle.Degrees(-01.01504659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84765"},
        {"Hipparcos Number", "HIP 48026"},
        {"Geneva Identification System", "GEN# +1.00084765"},
        {"Smithsonian Astrophysical Observation", "SAO 137132"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.84633843),
        dec: Angle.Degrees(-01.01309971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25790"},
        {"Hipparcos Number", "HIP 19070"},
        {"Geneva Identification System", "GEN# +1.00025790"},
        {"Smithsonian Astrophysical Observation", "SAO 130932"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.752,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.30978837),
        dec: Angle.Degrees(-01.01173291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84184",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84184"},
        {"Smithsonian Astrophysical Observation", "SAO 141556"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.13677322),
        dec: Angle.Degrees(-01.01140361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
