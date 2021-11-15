using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_106() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108271"},
        {"Hipparcos Number", "HIP 60678"},
        {"Fundamental Katalog 5th Edition", "FK5 5095"},
        {"Smithsonian Astrophysical Observation", "SAO 28383"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.53190601),
        dec: Angle.Degrees(+52.67662595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141174"},
        {"Hipparcos Number", "HIP 77161"},
        {"Smithsonian Astrophysical Observation", "SAO 29645"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.32623617),
        dec: Angle.Degrees(+52.67710917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79658"},
        {"Hipparcos Number", "HIP 45577"},
        {"Smithsonian Astrophysical Observation", "SAO 27200"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.33708279),
        dec: Angle.Degrees(+52.68043277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222141"},
        {"Hipparcos Number", "HIP 116607"},
        {"Smithsonian Astrophysical Observation", "SAO 35617"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.46730290),
        dec: Angle.Degrees(+52.68082552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14647"},
        {"Hipparcos Number", "HIP 11161"},
        {"Geneva Identification System", "GEN# +1.00014647"},
        {"Smithsonian Astrophysical Observation", "SAO 23281"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.90489611),
        dec: Angle.Degrees(+52.68185385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34434",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5796 A"},
        {"Henry Draper", "HD 53558"},
        {"Hipparcos Number", "HIP 34434"},
        {"Smithsonian Astrophysical Observation", "SAO 26170"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.08493670),
        dec: Angle.Degrees(+52.68577925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118575"},
        {"Hipparcos Number", "HIP 66380"},
        {"Smithsonian Astrophysical Observation", "SAO 28813"},
    },
    visualMagnitude: 6.93,
    bvColour: 1.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.13997837),
        dec: Angle.Degrees(+52.68759042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 120005",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7251 B"},
        {"Henry Draper", "HD 79211"},
        {"Hipparcos Number", "HIP 120005"},
        {"Geneva Identification System", "GEN# +1.00079211"},
        {"Smithsonian Astrophysical Observation", "SAO 27179"},
        {"Wilson Evans Batten Catalogue", "WEB 8638"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.60913008),
        dec: Angle.Degrees(+52.68797118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1551.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -656.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45343",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7251 A"},
        {"Henry Draper", "HD 79210"},
        {"Hipparcos Number", "HIP 45343"},
        {"Cincinnati Publication", "Ci 20 516"},
        {"Geneva Identification System", "GEN# +1.00079210A"},
        {"Smithsonian Astrophysical Observation", "SAO 27178"},
        {"Wilson Evans Batten Catalogue", "WEB 8637"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.60112218),
        dec: Angle.Degrees(+52.68799270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1533.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -562.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111334",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111334"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.34220746),
        dec: Angle.Degrees(+52.68818219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 132.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235543"},
        {"Hipparcos Number", "HIP 106466"},
        {"Smithsonian Astrophysical Observation", "SAO 33527"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.44906535),
        dec: Angle.Degrees(+52.68918250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4212",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 735 A"},
        {"Henry Draper", "HD 5128"},
        {"Henry Draper 2", "HD 5128A"},
        {"Hipparcos Number", "HIP 4212"},
        {"Geneva Identification System", "GEN# +1.00005128"},
        {"Renson", "Renson 1350"},
        {"Smithsonian Astrophysical Observation", "SAO 21814"},
        {"Wilson Evans Batten Catalogue", "WEB 757"},
    },
    visualMagnitude: 6.27,
    bvColour: 0.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.44802920),
        dec: Angle.Degrees(+52.68934453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2929"},
        {"Hipparcos Number", "HIP 2606"},
        {"Smithsonian Astrophysical Observation", "SAO 21511"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.27559666),
        dec: Angle.Degrees(+52.69333900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37838"},
        {"Hipparcos Number", "HIP 27060"},
        {"Geneva Identification System", "GEN# +1.00037838"},
        {"Smithsonian Astrophysical Observation", "SAO 25347"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.08028051),
        dec: Angle.Degrees(+52.69544780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207793"},
        {"Hipparcos Number", "HIP 107777"},
        {"Celescope Catalog", "CEL 5393"},
        {"Geneva Identification System", "GEN# +1.00207793"},
        {"Smithsonian Astrophysical Observation", "SAO 33794"},
        {"Wilson Evans Batten Catalogue", "WEB 19437"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.51035360),
        dec: Angle.Degrees(+52.69731937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216623"},
        {"Hipparcos Number", "HIP 113038"},
        {"Smithsonian Astrophysical Observation", "SAO 34930"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.39372583),
        dec: Angle.Degrees(+52.69833651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153345"},
        {"Hipparcos Number", "HIP 82884"},
        {"Smithsonian Astrophysical Observation", "SAO 30164"},
        {"Wilson Evans Batten Catalogue", "WEB 14011"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.07564850),
        dec: Angle.Degrees(+52.69843936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16577"},
        {"Hipparcos Number", "HIP 12536"},
        {"Smithsonian Astrophysical Observation", "SAO 23532"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.32469241),
        dec: Angle.Degrees(+52.70061008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175840"},
        {"Hipparcos Number", "HIP 92790"},
        {"Smithsonian Astrophysical Observation", "SAO 31259"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.62391264),
        dec: Angle.Degrees(+52.70123965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95397"},
        {"Hipparcos Number", "HIP 53890"},
        {"Smithsonian Astrophysical Observation", "SAO 27875"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.39811542),
        dec: Angle.Degrees(+52.70248695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35433",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35433"},
    },
    visualMagnitude: 9.75,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.72687398),
        dec: Angle.Degrees(+52.70322686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19031"},
        {"Hipparcos Number", "HIP 14406"},
        {"Geneva Identification System", "GEN# +1.00019031"},
        {"Smithsonian Astrophysical Observation", "SAO 23796"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.45055976),
        dec: Angle.Degrees(+52.70676251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14423"},
        {"Hipparcos Number", "HIP 10979"},
        {"Smithsonian Astrophysical Observation", "SAO 23233"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.35667683),
        dec: Angle.Degrees(+52.70715130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220498"},
        {"Hipparcos Number", "HIP 115489"},
        {"Geneva Identification System", "GEN# +1.00220498"},
        {"Smithsonian Astrophysical Observation", "SAO 35379"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.91782631),
        dec: Angle.Degrees(+52.70725891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208052"},
        {"Hipparcos Number", "HIP 107933"},
        {"Smithsonian Astrophysical Observation", "SAO 33815"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.00999193),
        dec: Angle.Degrees(+52.70855622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116171"},
        {"Hipparcos Number", "HIP 65139"},
        {"Geneva Identification System", "GEN# +1.00116171"},
        {"Smithsonian Astrophysical Observation", "SAO 28724"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.22935961),
        dec: Angle.Degrees(+52.71165442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73171"},
        {"Hipparcos Number", "HIP 42452"},
        {"Fundamental Katalog 5th Edition", "FK5 323"},
        {"Geneva Identification System", "GEN# +1.00073171"},
        {"Smithsonian Astrophysical Observation", "SAO 26946"},
        {"Wilson Evans Batten Catalogue", "WEB 8166"},
    },
    visualMagnitude: 5.91,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.82354649),
        dec: Angle.Degrees(+52.71169928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202443"},
        {"Hipparcos Number", "HIP 104805"},
        {"Smithsonian Astrophysical Observation", "SAO 33246"},
        {"Wilson Evans Batten Catalogue", "WEB 19060"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.50381154),
        dec: Angle.Degrees(+52.71198686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1874"},
        {"Hipparcos Number", "HIP 1851"},
        {"Geneva Identification System", "GEN# +1.00001874"},
        {"Smithsonian Astrophysical Observation", "SAO 21350"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.84382183),
        dec: Angle.Degrees(+52.71236934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235122"},
        {"Hipparcos Number", "HIP 99422"},
        {"Smithsonian Astrophysical Observation", "SAO 32337"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.69360252),
        dec: Angle.Degrees(+52.71447743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209663"},
        {"Hipparcos Number", "HIP 108906"},
        {"Smithsonian Astrophysical Observation", "SAO 34009"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.90884114),
        dec: Angle.Degrees(+52.71714234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106605"},
        {"Hipparcos Number", "HIP 59777"},
        {"Geneva Identification System", "GEN# +1.00106605"},
        {"Smithsonian Astrophysical Observation", "SAO 28316"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.86159776),
        dec: Angle.Degrees(+52.71721167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167426"},
        {"Hipparcos Number", "HIP 89204"},
        {"Smithsonian Astrophysical Observation", "SAO 30806"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.06249529),
        dec: Angle.Degrees(+52.71908217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13855"},
        {"Hipparcos Number", "HIP 10612"},
        {"Geneva Identification System", "GEN# +1.00013855"},
        {"Smithsonian Astrophysical Observation", "SAO 23112"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.15658705),
        dec: Angle.Degrees(+52.72176449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124585"},
        {"Hipparcos Number", "HIP 69426"},
        {"Smithsonian Astrophysical Observation", "SAO 29042"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.22090242),
        dec: Angle.Degrees(+52.72251409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233609"},
        {"Hipparcos Number", "HIP 45132"},
        {"Smithsonian Astrophysical Observation", "SAO 27164"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.93967656),
        dec: Angle.Degrees(+52.72822209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118429"},
        {"Hipparcos Number", "HIP 66340"},
        {"Smithsonian Astrophysical Observation", "SAO 28811"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.93192255),
        dec: Angle.Degrees(+52.72978375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235544"},
        {"Hipparcos Number", "HIP 106472"},
        {"Geneva Identification System", "GEN# +1.00235544"},
        {"Smithsonian Astrophysical Observation", "SAO 33530"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.47501341),
        dec: Angle.Degrees(+52.73056864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216596"},
        {"Hipparcos Number", "HIP 113023"},
        {"Smithsonian Astrophysical Observation", "SAO 34922"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.33506356),
        dec: Angle.Degrees(+52.73072117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20662"},
        {"Hipparcos Number", "HIP 15666"},
        {"Renson", "Renson 5180"},
        {"Smithsonian Astrophysical Observation", "SAO 23977"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.44330562),
        dec: Angle.Degrees(+52.73128564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4995"},
        {"Hipparcos Number", "HIP 4109"},
        {"Smithsonian Astrophysical Observation", "SAO 21793"},
    },
    visualMagnitude: 8.67,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.17458688),
        dec: Angle.Degrees(+52.73361012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224152"},
        {"Hipparcos Number", "HIP 117954"},
        {"Smithsonian Astrophysical Observation", "SAO 35897"},
        {"Wilson Evans Batten Catalogue", "WEB 20743"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.88566876),
        dec: Angle.Degrees(+52.73553412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8290"},
        {"Hipparcos Number", "HIP 6474"},
        {"Smithsonian Astrophysical Observation", "SAO 22231"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.81541988),
        dec: Angle.Degrees(+52.73745697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232605"},
        {"Hipparcos Number", "HIP 10058"},
        {"Smithsonian Astrophysical Observation", "SAO 22979"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.37248497),
        dec: Angle.Degrees(+52.73803635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234481"},
        {"Hipparcos Number", "HIP 86798"},
        {"Smithsonian Astrophysical Observation", "SAO 30540"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.04581661),
        dec: Angle.Degrees(+52.73904707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124331"},
        {"Hipparcos Number", "HIP 69335"},
        {"Smithsonian Astrophysical Observation", "SAO 29035"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.85731364),
        dec: Angle.Degrees(+52.74000097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112397"},
        {"Hipparcos Number", "HIP 63103"},
        {"Smithsonian Astrophysical Observation", "SAO 28568"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.92818951),
        dec: Angle.Degrees(+52.74263167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117242"},
        {"Hipparcos Number", "HIP 65678"},
        {"Geneva Identification System", "GEN# +1.00117242"},
        {"Smithsonian Astrophysical Observation", "SAO 28763"},
        {"Wilson Evans Batten Catalogue", "WEB 11623"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.99886524),
        dec: Angle.Degrees(+52.74564261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234347"},
        {"Hipparcos Number", "HIP 82090"},
        {"Smithsonian Astrophysical Observation", "SAO 30086"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.753,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.52390548),
        dec: Angle.Degrees(+52.74579820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105867",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14989 A"},
        {"Henry Draper", "HD 204401"},
        {"Hipparcos Number", "HIP 105867"},
        {"Smithsonian Astrophysical Observation", "SAO 33431"},
    },
    visualMagnitude: 7.60,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.62115552),
        dec: Angle.Degrees(+52.74796962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15179",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2423 A"},
        {"Henry Draper", "HD 20054"},
        {"Hipparcos Number", "HIP 15179"},
        {"Smithsonian Astrophysical Observation", "SAO 23904"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.90586479),
        dec: Angle.Degrees(+52.74983144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21015"},
        {"Hipparcos Number", "HIP 15976"},
        {"Smithsonian Astrophysical Observation", "SAO 24023"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.43144348),
        dec: Angle.Degrees(+52.75222935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123642"},
        {"Hipparcos Number", "HIP 68987"},
        {"Geneva Identification System", "GEN# +1.00123642"},
        {"Smithsonian Astrophysical Observation", "SAO 29013"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.85854567),
        dec: Angle.Degrees(+52.75306878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235069"},
        {"Hipparcos Number", "HIP 98491"},
        {"Smithsonian Astrophysical Observation", "SAO 32196"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.13888842),
        dec: Angle.Degrees(+52.75316646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65872"},
        {"Hipparcos Number", "HIP 39419"},
        {"Smithsonian Astrophysical Observation", "SAO 26641"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.87313141),
        dec: Angle.Degrees(+52.75729509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34217",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5746 AB"},
        {"Henry Draper", "HD 52859"},
        {"Hipparcos Number", "HIP 34217"},
        {"Geneva Identification System", "GEN# +1.00052859J"},
        {"Wilson Evans Batten Catalogue", "WEB 6851"},
    },
    visualMagnitude: 6.17,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.41594546),
        dec: Angle.Degrees(+52.75868505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178157"},
        {"Hipparcos Number", "HIP 93694"},
        {"Smithsonian Astrophysical Observation", "SAO 31366"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.19392960),
        dec: Angle.Degrees(+52.76090543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13531",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2202 A"},
        {"Henry Draper", "HD 17879"},
        {"Henry Draper 2", "HD 17878"},
        {"Hipparcos Number", "HIP 13531"},
        {"Celescope Catalog", "CEL 297"},
        {"Fundamental Katalog 5th Edition", "FK5 103"},
        {"Geneva Identification System", "GEN# +1.00017879"},
        {"Geneva Identification System 2", "GEN# +1.00017878"},
        {"Smithsonian Astrophysical Observation", "SAO 23685"},
        {"Wilson Evans Batten Catalogue", "WEB 2699"},
    },
    visualMagnitude: 3.93,
    bvColour: 0.758,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.56442700),
        dec: Angle.Degrees(+52.76248991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33134"},
        {"Hipparcos Number", "HIP 24135"},
        {"Smithsonian Astrophysical Observation", "SAO 25061"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.75046129),
        dec: Angle.Degrees(+52.76753408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236243"},
        {"Hipparcos Number", "HIP 117850"},
        {"Smithsonian Astrophysical Observation", "SAO 35876"},
    },
    visualMagnitude: 9.48,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.52871823),
        dec: Angle.Degrees(+52.76984232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235044"},
        {"Hipparcos Number", "HIP 98056"},
        {"Smithsonian Astrophysical Observation", "SAO 32115"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.90878518),
        dec: Angle.Degrees(+52.77024952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235637"},
        {"Hipparcos Number", "HIP 107784"},
        {"Smithsonian Astrophysical Observation", "SAO 33797"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.52749352),
        dec: Angle.Degrees(+52.77149427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119214"},
        {"Hipparcos Number", "HIP 66735"},
        {"Smithsonian Astrophysical Observation", "SAO 28842"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.18057277),
        dec: Angle.Degrees(+52.77188713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 622",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 81 AB"},
        {"Henry Draper", "HD 278"},
        {"Hipparcos Number", "HIP 622"},
        {"Smithsonian Astrophysical Observation", "SAO 21108"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.90590207),
        dec: Angle.Degrees(+52.77298980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55044",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8108 A"},
        {"Henry Draper", "HD 97855"},
        {"Henry Draper 2", "HD 97855A"},
        {"Hipparcos Number", "HIP 55044"},
        {"Geneva Identification System", "GEN# +1.00097855A"},
        {"Smithsonian Astrophysical Observation", "SAO 27970"},
        {"Wilson Evans Batten Catalogue", "WEB 9929"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.01615871),
        dec: Angle.Degrees(+52.77302271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 159.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55043",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8108 B"},
        {"Henry Draper", "HD 97855B"},
        {"Hipparcos Number", "HIP 55043"},
        {"Geneva Identification System", "GEN# +1.00097855B"},
        {"Geneva Identification System 2", "GEN# +1.20097855"},
        {"Smithsonian Astrophysical Observation", "SAO 27969"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.01457494),
        dec: Angle.Degrees(+52.77634695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 157.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29945"},
        {"Hipparcos Number", "HIP 22143"},
        {"Smithsonian Astrophysical Observation", "SAO 24806"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.47770328),
        dec: Angle.Degrees(+52.77809635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63888"},
        {"Hipparcos Number", "HIP 38566"},
        {"Smithsonian Astrophysical Observation", "SAO 26557"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.44138753),
        dec: Angle.Degrees(+52.77895906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60121",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60121"},
    },
    visualMagnitude: 11.12,
    bvColour: 1.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.95094646),
        dec: Angle.Degrees(+52.77946304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -169.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52826",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52826"},
    },
    visualMagnitude: 10.48,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.01766721),
        dec: Angle.Degrees(+52.78290624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45594"},
        {"Hipparcos Number", "HIP 31090"},
        {"Geneva Identification System", "GEN# +1.00045594"},
        {"Smithsonian Astrophysical Observation", "SAO 25784"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.86190372),
        dec: Angle.Degrees(+52.78434956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156772"},
        {"Hipparcos Number", "HIP 84511"},
        {"Smithsonian Astrophysical Observation", "SAO 30322"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.15001353),
        dec: Angle.Degrees(+52.78452777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56309",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56309"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.16004736),
        dec: Angle.Degrees(+52.78576021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233641"},
        {"Hipparcos Number", "HIP 46639"},
        {"Geneva Identification System", "GEN# +1.00233641"},
        {"Smithsonian Astrophysical Observation", "SAO 27275"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.65065571),
        dec: Angle.Degrees(+52.78999112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158259"},
        {"Hipparcos Number", "HIP 85268"},
        {"Geneva Identification System", "GEN# +1.00158259"},
        {"Smithsonian Astrophysical Observation", "SAO 30380"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.35059537),
        dec: Angle.Degrees(+52.79080663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84143"},
        {"Hipparcos Number", "HIP 47799"},
        {"Smithsonian Astrophysical Observation", "SAO 27369"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.16758205),
        dec: Angle.Degrees(+52.79353065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233911"},
        {"Hipparcos Number", "HIP 59524"},
        {"Smithsonian Astrophysical Observation", "SAO 28300"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.10246898),
        dec: Angle.Degrees(+52.79421558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75894"},
        {"Hipparcos Number", "HIP 43770"},
        {"Smithsonian Astrophysical Observation", "SAO 27044"},
    },
    visualMagnitude: 7.29,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.73939019),
        dec: Angle.Degrees(+52.79470478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55473",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55473"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.40634992),
        dec: Angle.Degrees(+52.79952124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183472"},
        {"Hipparcos Number", "HIP 95632"},
        {"Geneva Identification System", "GEN# +1.00183472"},
        {"Smithsonian Astrophysical Observation", "SAO 31668"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.77511450),
        dec: Angle.Degrees(+52.79959788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79590",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79590"},
    },
    visualMagnitude: 9.97,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.57013569),
        dec: Angle.Degrees(+52.80335717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196177"},
        {"Hipparcos Number", "HIP 101438"},
        {"Geneva Identification System", "GEN# +1.00196177"},
        {"Smithsonian Astrophysical Observation", "SAO 32687"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.36041378),
        dec: Angle.Degrees(+52.80405362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16461"},
        {"Hipparcos Number", "HIP 12454"},
        {"Geneva Identification System", "GEN# +1.00016461"},
        {"Smithsonian Astrophysical Observation", "SAO 23513"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.09077300),
        dec: Angle.Degrees(+52.80412000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28604"},
        {"Hipparcos Number", "HIP 21233"},
        {"Geneva Identification System", "GEN# +1.00028604"},
        {"Smithsonian Astrophysical Observation", "SAO 24682"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.32032554),
        dec: Angle.Degrees(+52.80500920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104377"},
        {"Hipparcos Number", "HIP 58617"},
        {"Smithsonian Astrophysical Observation", "SAO 28220"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.30934449),
        dec: Angle.Degrees(+52.80510572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8307"},
        {"Hipparcos Number", "HIP 6496"},
        {"Geneva Identification System", "GEN# +1.00008307"},
        {"Smithsonian Astrophysical Observation", "SAO 22232"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.85799392),
        dec: Angle.Degrees(+52.80701647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45465"},
        {"Hipparcos Number", "HIP 31023"},
        {"Geneva Identification System", "GEN# +1.00045465"},
        {"Smithsonian Astrophysical Observation", "SAO 25774"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.64301006),
        dec: Angle.Degrees(+52.80925355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23694",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23694"},
    },
    visualMagnitude: 10.02,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.37813786),
        dec: Angle.Degrees(+52.81038575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98663"},
        {"Hipparcos Number", "HIP 55472"},
        {"Smithsonian Astrophysical Observation", "SAO 27997"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.40254478),
        dec: Angle.Degrees(+52.81117617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36899",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36899"},
    },
    visualMagnitude: 11.06,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.79794321),
        dec: Angle.Degrees(+52.81323193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -239.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218416"},
        {"Hipparcos Number", "HIP 114162"},
        {"Geneva Identification System", "GEN# +1.00218416"},
        {"Smithsonian Astrophysical Observation", "SAO 35151"},
        {"Wilson Evans Batten Catalogue", "WEB 20273"},
    },
    visualMagnitude: 6.12,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.79188553),
        dec: Angle.Degrees(+52.81656940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236188"},
        {"Hipparcos Number", "HIP 116615"},
        {"Smithsonian Astrophysical Observation", "SAO 35623"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.50328104),
        dec: Angle.Degrees(+52.81758733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154731"},
        {"Hipparcos Number", "HIP 83536"},
        {"Geneva Identification System", "GEN# +1.00154731"},
        {"Smithsonian Astrophysical Observation", "SAO 30230"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.10688461),
        dec: Angle.Degrees(+52.81849076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22451"},
        {"Hipparcos Number", "HIP 17033"},
        {"Geneva Identification System", "GEN# +1.00022451"},
        {"Smithsonian Astrophysical Observation", "SAO 24139"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.77698266),
        dec: Angle.Degrees(+52.81912189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29331"},
        {"Hipparcos Number", "HIP 21729"},
        {"Smithsonian Astrophysical Observation", "SAO 24745"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.98783568),
        dec: Angle.Degrees(+52.81956309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96527"},
        {"Hipparcos Number", "HIP 54407"},
        {"Smithsonian Astrophysical Observation", "SAO 27918"},
        {"Wilson Evans Batten Catalogue", "WEB 9825"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.00049947),
        dec: Angle.Degrees(+52.82165393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222154"},
        {"Hipparcos Number", "HIP 116618"},
        {"Smithsonian Astrophysical Observation", "SAO 35621"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.49783947),
        dec: Angle.Degrees(+52.82194712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130651"},
        {"Hipparcos Number", "HIP 72331"},
        {"Geneva Identification System", "GEN# +1.00130651"},
        {"Smithsonian Astrophysical Observation", "SAO 29279"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.86865107),
        dec: Angle.Degrees(+52.82452021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196239"},
        {"Hipparcos Number", "HIP 101462"},
        {"Smithsonian Astrophysical Observation", "SAO 32693"},
    },
    visualMagnitude: 7.37,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.44231750),
        dec: Angle.Degrees(+52.82654421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103375",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14465 AB"},
        {"Henry Draper", "HD 235405"},
        {"Hipparcos Number", "HIP 103375"},
        {"Smithsonian Astrophysical Observation", "SAO 33007"},
    },
    visualMagnitude: 9.46,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.15706992),
        dec: Angle.Degrees(+52.82669227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 89.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58200",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58200"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.04678468),
        dec: Angle.Degrees(+52.83035899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24782",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3870 AB"},
        {"Henry Draper", "HD 34234"},
        {"Hipparcos Number", "HIP 24782"},
        {"Smithsonian Astrophysical Observation", "SAO 25124"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.69658088),
        dec: Angle.Degrees(+52.83094717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232673"},
        {"Hipparcos Number", "HIP 11951"},
        {"Smithsonian Astrophysical Observation", "SAO 23437"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.54490347),
        dec: Angle.Degrees(+52.83117046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23692",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23692"},
    },
    visualMagnitude: 11.86,
    bvColour: -0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.37752362),
        dec: Angle.Degrees(+52.83131630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7371"},
        {"Hipparcos Number", "HIP 5832"},
        {"Smithsonian Astrophysical Observation", "SAO 22123"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.70129565),
        dec: Angle.Degrees(+52.83203838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57129"},
        {"Hipparcos Number", "HIP 35766"},
        {"Geneva Identification System", "GEN# +1.00057129"},
        {"Smithsonian Astrophysical Observation", "SAO 26309"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.65849603),
        dec: Angle.Degrees(+52.83848988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2774"},
        {"Hipparcos Number", "HIP 2497"},
        {"Geneva Identification System", "GEN# +1.00002774"},
        {"Smithsonian Astrophysical Observation", "SAO 21486"},
        {"Wilson Evans Batten Catalogue", "WEB 457"},
    },
    visualMagnitude: 5.59,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.92171234),
        dec: Angle.Degrees(+52.83955844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121046"},
        {"Hipparcos Number", "HIP 67671"},
        {"Smithsonian Astrophysical Observation", "SAO 28909"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.959,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.96079722),
        dec: Angle.Degrees(+52.84063060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30752"},
        {"Hipparcos Number", "HIP 22720"},
        {"Geneva Identification System", "GEN# +1.00030752"},
        {"Smithsonian Astrophysical Observation", "SAO 24894"},
        {"Wilson Evans Batten Catalogue", "WEB 4393"},
    },
    visualMagnitude: 6.40,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.29081329),
        dec: Angle.Degrees(+52.84118516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50744"},
        {"Hipparcos Number", "HIP 33467"},
        {"Smithsonian Astrophysical Observation", "SAO 26062"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.35765339),
        dec: Angle.Degrees(+52.84545606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39402",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39402"},
        {"Geneva Identification System", "GEN# +9.80194007"},
    },
    visualMagnitude: 11.35,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.82992824),
        dec: Angle.Degrees(+52.84557072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 363.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -676.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234725"},
        {"Hipparcos Number", "HIP 92473"},
        {"Smithsonian Astrophysical Observation", "SAO 31202"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.68485208),
        dec: Angle.Degrees(+52.84906785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97456"},
        {"Hipparcos Number", "HIP 54837"},
        {"Smithsonian Astrophysical Observation", "SAO 27958"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.39683378),
        dec: Angle.Degrees(+52.85055460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6059"},
        {"Hipparcos Number", "HIP 4875"},
        {"Smithsonian Astrophysical Observation", "SAO 21943"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.66526465),
        dec: Angle.Degrees(+52.85092821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235680"},
        {"Hipparcos Number", "HIP 108489"},
        {"Smithsonian Astrophysical Observation", "SAO 33929"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.66798270),
        dec: Angle.Degrees(+52.85320863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88155",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10988 AB"},
        {"Henry Draper", "HD 164874"},
        {"Hipparcos Number", "HIP 88155"},
        {"Smithsonian Astrophysical Observation", "SAO 30686"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.07808960),
        dec: Angle.Degrees(+52.85427862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6810"},
        {"Hipparcos Number", "HIP 5451"},
        {"Smithsonian Astrophysical Observation", "SAO 22043"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.43917434),
        dec: Angle.Degrees(+52.85444690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27897"},
        {"Hipparcos Number", "HIP 20760"},
        {"Smithsonian Astrophysical Observation", "SAO 24616"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.71895566),
        dec: Angle.Degrees(+52.85815860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64517",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8825 AB"},
        {"Henry Draper", "HD 115002"},
        {"Hipparcos Number", "HIP 64517"},
        {"Smithsonian Astrophysical Observation", "SAO 28676"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.34914937),
        dec: Angle.Degrees(+52.86083556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 974"},
        {"Hipparcos Number", "HIP 1143"},
        {"Smithsonian Astrophysical Observation", "SAO 21232"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.58007313),
        dec: Angle.Degrees(+52.86097686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165460"},
        {"Hipparcos Number", "HIP 88416"},
        {"Geneva Identification System", "GEN# +1.00165460"},
        {"Smithsonian Astrophysical Observation", "SAO 30718"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.78735228),
        dec: Angle.Degrees(+52.86121401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204291"},
        {"Hipparcos Number", "HIP 105812"},
        {"Smithsonian Astrophysical Observation", "SAO 33423"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.44573977),
        dec: Angle.Degrees(+52.86184697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111252"},
        {"Hipparcos Number", "HIP 62405"},
        {"Smithsonian Astrophysical Observation", "SAO 28515"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.866,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.83302712),
        dec: Angle.Degrees(+52.86184912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194787"},
        {"Hipparcos Number", "HIP 100731"},
        {"Smithsonian Astrophysical Observation", "SAO 32556"},
    },
    visualMagnitude: 8.12,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.33099809),
        dec: Angle.Degrees(+52.86356925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46250"},
        {"Hipparcos Number", "HIP 31432"},
        {"Smithsonian Astrophysical Observation", "SAO 25822"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.79247356),
        dec: Angle.Degrees(+52.86393632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213188"},
        {"Hipparcos Number", "HIP 110931"},
        {"Smithsonian Astrophysical Observation", "SAO 34488"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.12440972),
        dec: Angle.Degrees(+52.86507437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233853"},
        {"Hipparcos Number", "HIP 57023"},
        {"Smithsonian Astrophysical Observation", "SAO 28096"},
    },
    visualMagnitude: 10.07,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.37232715),
        dec: Angle.Degrees(+52.86514197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3006"},
        {"Hipparcos Number", "HIP 2669"},
        {"Smithsonian Astrophysical Observation", "SAO 21520"},
    },
    visualMagnitude: 9.10,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.45446106),
        dec: Angle.Degrees(+52.86573860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234843"},
        {"Hipparcos Number", "HIP 94545"},
        {"Smithsonian Astrophysical Observation", "SAO 31504"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.64510858),
        dec: Angle.Degrees(+52.86609789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232362"},
        {"Hipparcos Number", "HIP 4992"},
        {"Smithsonian Astrophysical Observation", "SAO 21966"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.99924639),
        dec: Angle.Degrees(+52.86668640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168342"},
        {"Hipparcos Number", "HIP 89542"},
        {"Geneva Identification System", "GEN# +1.00168342"},
        {"Smithsonian Astrophysical Observation", "SAO 30857"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.06173595),
        dec: Angle.Degrees(+52.86886776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232285"},
        {"Hipparcos Number", "HIP 3877"},
        {"Renson", "Renson 1236"},
        {"Smithsonian Astrophysical Observation", "SAO 21745"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.44508731),
        dec: Angle.Degrees(+52.86896935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31134"},
        {"Hipparcos Number", "HIP 22936"},
        {"Geneva Identification System", "GEN# +1.00031134"},
        {"Smithsonian Astrophysical Observation", "SAO 24919"},
        {"Wilson Evans Batten Catalogue", "WEB 4454"},
    },
    visualMagnitude: 5.75,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.02948687),
        dec: Angle.Degrees(+52.86971717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214650"},
        {"Hipparcos Number", "HIP 111798"},
        {"Smithsonian Astrophysical Observation", "SAO 34650"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.66560199),
        dec: Angle.Degrees(+52.87382960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58982",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8416 AB"},
        {"Henry Draper", "HD 105030"},
        {"Hipparcos Number", "HIP 58982"},
        {"Smithsonian Astrophysical Observation", "SAO 28242"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.39679554),
        dec: Angle.Degrees(+52.87541426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19720"},
        {"Hipparcos Number", "HIP 14945"},
        {"Smithsonian Astrophysical Observation", "SAO 23877"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.16954007),
        dec: Angle.Degrees(+52.88051628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211972"},
        {"Hipparcos Number", "HIP 110230"},
        {"Geneva Identification System", "GEN# +1.00211972"},
        {"Smithsonian Astrophysical Observation", "SAO 34315"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.93583928),
        dec: Angle.Degrees(+52.88130319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209419"},
        {"Hipparcos Number", "HIP 108758"},
        {"Celescope Catalog", "CEL 5420"},
        {"Fundamental Katalog 5th Edition", "FK5 3763"},
        {"Geneva Identification System", "GEN# +1.00209419"},
        {"Smithsonian Astrophysical Observation", "SAO 33985"},
        {"Wilson Evans Batten Catalogue", "WEB 19566"},
    },
    visualMagnitude: 5.79,
    bvColour: -0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.46074194),
        dec: Angle.Degrees(+52.88224628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217509"},
        {"Hipparcos Number", "HIP 113599"},
        {"Smithsonian Astrophysical Observation", "SAO 35048"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.12689105),
        dec: Angle.Degrees(+52.88375356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50184",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50184"},
    },
    visualMagnitude: 10.64,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.66287865),
        dec: Angle.Degrees(+52.88436012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8066",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1354 AB"},
        {"Henry Draper", "HD 10497"},
        {"Hipparcos Number", "HIP 8066"},
        {"Geneva Identification System", "GEN# +1.00010497J"},
        {"Smithsonian Astrophysical Observation", "SAO 22552"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.91155778),
        dec: Angle.Degrees(+52.88578953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218942"},
        {"Hipparcos Number", "HIP 114507"},
        {"Wilson Evans Batten Catalogue", "WEB 20320"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.87531788),
        dec: Angle.Degrees(+52.88680919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233474"},
        {"Hipparcos Number", "HIP 38952"},
        {"Smithsonian Astrophysical Observation", "SAO 26594"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.54318217),
        dec: Angle.Degrees(+52.89003433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215633"},
        {"Hipparcos Number", "HIP 112369"},
        {"Smithsonian Astrophysical Observation", "SAO 34775"},
        {"Wilson Evans Batten Catalogue", "WEB 20046"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.40029897),
        dec: Angle.Degrees(+52.89034498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84868"},
        {"Hipparcos Number", "HIP 48211"},
        {"Smithsonian Astrophysical Observation", "SAO 27393"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.44048047),
        dec: Angle.Degrees(+52.89107450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233725"},
        {"Hipparcos Number", "HIP 50625"},
        {"Smithsonian Astrophysical Observation", "SAO 27608"},
    },
    visualMagnitude: 10.62,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.11315019),
        dec: Angle.Degrees(+52.89123593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232604"},
        {"Hipparcos Number", "HIP 9992"},
        {"Smithsonian Astrophysical Observation", "SAO 22962"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.17212323),
        dec: Angle.Degrees(+52.89275934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232979"},
        {"Hipparcos Number", "HIP 21553"},
        {"Cincinnati Publication", "Ci 18 594"},
        {"Cincinnati Publication 2", "Ci 20 298"},
        {"Geneva Identification System", "GEN# +1.00232979"},
        {"Smithsonian Astrophysical Observation", "SAO 24722"},
        {"Wilson Evans Batten Catalogue", "WEB 4137"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.41931771),
        dec: Angle.Degrees(+52.89476987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 305.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -475.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16316",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2566 A"},
        {"Henry Draper", "HD 21488"},
        {"Hipparcos Number", "HIP 16316"},
        {"Geneva Identification System", "GEN# +1.00021488A"},
        {"Smithsonian Astrophysical Observation", "SAO 24068"},
        {"Wilson Evans Batten Catalogue", "WEB 3114"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.57368101),
        dec: Angle.Degrees(+52.89489527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37216"},
        {"Hipparcos Number", "HIP 26653"},
        {"Geneva Identification System", "GEN# +1.00037216"},
        {"Smithsonian Astrophysical Observation", "SAO 25310"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.764,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.96816107),
        dec: Angle.Degrees(+52.89783269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -141.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204428"},
        {"Hipparcos Number", "HIP 105891"},
        {"Celescope Catalog", "CEL 5314"},
        {"Geneva Identification System", "GEN# +1.00204428"},
        {"Smithsonian Astrophysical Observation", "SAO 33434"},
    },
    visualMagnitude: 6.01,
    bvColour: -0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.68731183),
        dec: Angle.Degrees(+52.89852489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102870",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102870"},
        {"Cincinnati Publication", "Ci 20 1235"},
    },
    visualMagnitude: 9.69,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.63665925),
        dec: Angle.Degrees(+52.89852926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 288.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 441.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47727"},
        {"Hipparcos Number", "HIP 32169"},
        {"Smithsonian Astrophysical Observation", "SAO 25898"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.75773856),
        dec: Angle.Degrees(+52.89918995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81290",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10129 C"},
        {"Henry Draper", "HD 150100"},
        {"Hipparcos Number", "HIP 81290"},
        {"Geneva Identification System", "GEN# +1.00150100"},
        {"Smithsonian Astrophysical Observation", "SAO 30012"},
        {"Wilson Evans Batten Catalogue", "WEB 13737"},
    },
    visualMagnitude: 5.53,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.04763676),
        dec: Angle.Degrees(+52.89997858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232734"},
        {"Hipparcos Number", "HIP 13803"},
        {"Smithsonian Astrophysical Observation", "SAO 23732"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.812,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.44102177),
        dec: Angle.Degrees(+52.90107433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169412"},
        {"Hipparcos Number", "HIP 89982"},
        {"Smithsonian Astrophysical Observation", "SAO 30919"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.38934866),
        dec: Angle.Degrees(+52.90216743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53554",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53554"},
    },
    visualMagnitude: 11.88,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.33271543),
        dec: Angle.Degrees(+52.90347883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145604"},
        {"Hipparcos Number", "HIP 79157"},
        {"Smithsonian Astrophysical Observation", "SAO 29824"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.33950726),
        dec: Angle.Degrees(+52.90494851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223538"},
        {"Hipparcos Number", "HIP 117539"},
        {"Smithsonian Astrophysical Observation", "SAO 35819"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.55807095),
        dec: Angle.Degrees(+52.90502086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140965"},
        {"Hipparcos Number", "HIP 77062"},
        {"Smithsonian Astrophysical Observation", "SAO 29636"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.02420612),
        dec: Angle.Degrees(+52.90531465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233791"},
        {"Hipparcos Number", "HIP 53551"},
        {"Smithsonian Astrophysical Observation", "SAO 27842"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.32582809),
        dec: Angle.Degrees(+52.90683415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142282"},
        {"Hipparcos Number", "HIP 77652"},
        {"Smithsonian Astrophysical Observation", "SAO 29691"},
        {"Wilson Evans Batten Catalogue", "WEB 13139"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.79202537),
        dec: Angle.Degrees(+52.90699863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128165"},
        {"Hipparcos Number", "HIP 71181"},
        {"Geneva Identification System", "GEN# +1.00128165"},
        {"Smithsonian Astrophysical Observation", "SAO 29196"},
        {"Wilson Evans Batten Catalogue", "WEB 12304"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.37105398),
        dec: Angle.Degrees(+52.90818846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -192.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 247.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42365"},
        {"Hipparcos Number", "HIP 29532"},
        {"Smithsonian Astrophysical Observation", "SAO 25622"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.32565149),
        dec: Angle.Degrees(+52.91051665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234567"},
        {"Hipparcos Number", "HIP 88807"},
        {"Smithsonian Astrophysical Observation", "SAO 30764"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.93683274),
        dec: Angle.Degrees(+52.91123532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79657"},
        {"Hipparcos Number", "HIP 45575"},
        {"Geneva Identification System", "GEN# +1.00079657"},
        {"Smithsonian Astrophysical Observation", "SAO 27199"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.33145227),
        dec: Angle.Degrees(+52.91228849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144204"},
        {"Hipparcos Number", "HIP 78542"},
        {"Geneva Identification System", "GEN# +1.00144204"},
        {"Smithsonian Astrophysical Observation", "SAO 29763"},
        {"Wilson Evans Batten Catalogue", "WEB 13276"},
    },
    visualMagnitude: 5.93,
    bvColour: 1.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.52315266),
        dec: Angle.Degrees(+52.91600607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152223"},
        {"Hipparcos Number", "HIP 82332"},
        {"Fundamental Katalog 5th Edition", "FK5 3338"},
        {"Geneva Identification System", "GEN# +1.00152223"},
        {"Smithsonian Astrophysical Observation", "SAO 30112"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.34753031),
        dec: Angle.Degrees(+52.91687214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80565"},
        {"Hipparcos Number", "HIP 45978"},
        {"Smithsonian Astrophysical Observation", "SAO 27228"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.64488443),
        dec: Angle.Degrees(+52.92102023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119024"},
        {"Hipparcos Number", "HIP 66634"},
        {"Geneva Identification System", "GEN# +1.00119024"},
        {"Smithsonian Astrophysical Observation", "SAO 28832"},
        {"Wilson Evans Batten Catalogue", "WEB 11754"},
    },
    visualMagnitude: 5.46,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.87741499),
        dec: Angle.Degrees(+52.92107136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -136.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235757"},
        {"Hipparcos Number", "HIP 109679"},
        {"Smithsonian Astrophysical Observation", "SAO 34183"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.26516858),
        dec: Angle.Degrees(+52.92123920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81292",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10129 AB"},
        {"Hipparcos Number", "HIP 81292"},
        {"Smithsonian Astrophysical Observation", "SAO 30013"},
    },
    visualMagnitude: 5.07,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.05721668),
        dec: Angle.Degrees(+52.92435554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90697"},
        {"Hipparcos Number", "HIP 51369"},
        {"Smithsonian Astrophysical Observation", "SAO 27659"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.37718766),
        dec: Angle.Degrees(+52.92462344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73131"},
        {"Hipparcos Number", "HIP 42415"},
        {"Smithsonian Astrophysical Observation", "SAO 26940"},
        {"Wilson Evans Batten Catalogue", "WEB 8153"},
    },
    visualMagnitude: 6.34,
    bvColour: 1.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.74965355),
        dec: Angle.Degrees(+52.92514812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69011"},
        {"Hipparcos Number", "HIP 40602"},
        {"Geneva Identification System", "GEN# +1.00069011"},
        {"Smithsonian Astrophysical Observation", "SAO 26755"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.34377051),
        dec: Angle.Degrees(+52.92628596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74856"},
        {"Hipparcos Number", "HIP 43250"},
        {"Smithsonian Astrophysical Observation", "SAO 27002"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.16476229),
        dec: Angle.Degrees(+52.92895057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152761"},
        {"Hipparcos Number", "HIP 82556"},
        {"Smithsonian Astrophysical Observation", "SAO 30134"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.12279320),
        dec: Angle.Degrees(+52.92976339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122383"},
        {"Hipparcos Number", "HIP 68395"},
        {"Smithsonian Astrophysical Observation", "SAO 28969"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.01545616),
        dec: Angle.Degrees(+52.92990091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135339"},
        {"Hipparcos Number", "HIP 74411"},
        {"Smithsonian Astrophysical Observation", "SAO 29443"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.10900875),
        dec: Angle.Degrees(+52.93004654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22135"},
        {"Hipparcos Number", "HIP 16820"},
        {"Fundamental Katalog 5th Edition", "FK5 4321"},
        {"Geneva Identification System", "GEN# +1.00022135"},
        {"Smithsonian Astrophysical Observation", "SAO 24120"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.818,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.10907743),
        dec: Angle.Degrees(+52.93142880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234680"},
        {"Hipparcos Number", "HIP 91109"},
        {"Smithsonian Astrophysical Observation", "SAO 31061"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.892,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.77842076),
        dec: Angle.Degrees(+52.93355354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106132",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15035 A"},
        {"Henry Draper", "HD 204905"},
        {"Hipparcos Number", "HIP 106132"},
        {"Celescope Catalog", "CEL 5325"},
        {"Renson", "Renson 57070"},
        {"Smithsonian Astrophysical Observation", "SAO 33468"},
        {"Wilson Evans Batten Catalogue", "WEB 19234"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.47063093),
        dec: Angle.Degrees(+52.93383054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114014"},
        {"Hipparcos Number", "HIP 63997"},
        {"Smithsonian Astrophysical Observation", "SAO 28639"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.71556805),
        dec: Angle.Degrees(+52.93425291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106124",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15035 B"},
        {"Hipparcos Number", "HIP 106124"},
        {"Smithsonian Astrophysical Observation", "SAO 33464"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)29, 50.1900),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)56, 07.900)
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
    primaryId: "HIP 94018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179121"},
        {"Hipparcos Number", "HIP 94018"},
        {"Smithsonian Astrophysical Observation", "SAO 31418"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.12546138),
        dec: Angle.Degrees(+52.93768859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125178"},
        {"Hipparcos Number", "HIP 69712"},
        {"Smithsonian Astrophysical Observation", "SAO 29072"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.03969141),
        dec: Angle.Degrees(+52.93793885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79126",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79126"},
    },
    visualMagnitude: 10.24,
    bvColour: 1.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.26226340),
        dec: Angle.Degrees(+52.94372624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 203.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68458"},
        {"Hipparcos Number", "HIP 40402"},
        {"Smithsonian Astrophysical Observation", "SAO 26737"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.72480837),
        dec: Angle.Degrees(+52.94377919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97601"},
        {"Hipparcos Number", "HIP 54908"},
        {"Geneva Identification System", "GEN# +1.00097601"},
        {"Smithsonian Astrophysical Observation", "SAO 27961"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.881,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.63900665),
        dec: Angle.Degrees(+52.94697603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24942"},
        {"Hipparcos Number", "HIP 18712"},
        {"Smithsonian Astrophysical Observation", "SAO 24340"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.11955113),
        dec: Angle.Degrees(+52.94742030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55268",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55268"},
    },
    visualMagnitude: 9.68,
    bvColour: 1.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.78750400),
        dec: Angle.Degrees(+53.30930481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17507"},
        {"Hipparcos Number", "HIP 13251"},
        {"Smithsonian Astrophysical Observation", "SAO 23653"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.63813204),
        dec: Angle.Degrees(+52.95083247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4548"},
        {"Hipparcos Number", "HIP 3752"},
        {"Smithsonian Astrophysical Observation", "SAO 21721"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.04121293),
        dec: Angle.Degrees(+52.95113478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21807"},
        {"Hipparcos Number", "HIP 16575"},
        {"Geneva Identification System", "GEN# +1.00021807"},
        {"Smithsonian Astrophysical Observation", "SAO 24095"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.34457253),
        dec: Angle.Degrees(+52.95264124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2368"},
        {"Hipparcos Number", "HIP 2204"},
        {"Fundamental Katalog 5th Edition", "FK5 4046"},
        {"Geneva Identification System", "GEN# +1.00002368"},
        {"Smithsonian Astrophysical Observation", "SAO 21417"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.96686585),
        dec: Angle.Degrees(+52.95503628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96600",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96600"},
    },
    visualMagnitude: 11.30,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.55622807),
        dec: Angle.Degrees(+52.95542509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233582"},
        {"Hipparcos Number", "HIP 43767"},
        {"Fundamental Katalog 5th Edition", "FK5 4796"},
        {"Geneva Identification System", "GEN# +1.00233582"},
        {"Smithsonian Astrophysical Observation", "SAO 27042"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.73424027),
        dec: Angle.Degrees(+52.95643228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141654"},
        {"Hipparcos Number", "HIP 77380"},
        {"Smithsonian Astrophysical Observation", "SAO 29669"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.94154491),
        dec: Angle.Degrees(+52.95789842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204965"},
        {"Hipparcos Number", "HIP 106171"},
        {"Celescope Catalog", "CEL 5327"},
        {"Geneva Identification System", "GEN# +1.00204965"},
        {"Smithsonian Astrophysical Observation", "SAO 33477"},
        {"Wilson Evans Batten Catalogue", "WEB 19241"},
    },
    visualMagnitude: 6.02,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.58462074),
        dec: Angle.Degrees(+52.95795802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234088"},
        {"Hipparcos Number", "HIP 68049"},
        {"Smithsonian Astrophysical Observation", "SAO 28935"},
    },
    visualMagnitude: 10.64,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.99532739),
        dec: Angle.Degrees(+52.95865901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92408"},
        {"Hipparcos Number", "HIP 52309"},
        {"Geneva Identification System", "GEN# +1.00092408"},
        {"Smithsonian Astrophysical Observation", "SAO 27735"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.32435633),
        dec: Angle.Degrees(+52.97063112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196770"},
        {"Hipparcos Number", "HIP 101728"},
        {"Smithsonian Astrophysical Observation", "SAO 32737"},
    },
    visualMagnitude: 6.64,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.30284114),
        dec: Angle.Degrees(+52.97311663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26986"},
        {"Hipparcos Number", "HIP 20103"},
        {"Smithsonian Astrophysical Observation", "SAO 24532"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.64315876),
        dec: Angle.Degrees(+52.97413858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175225"},
        {"Hipparcos Number", "HIP 92549"},
        {"Geneva Identification System", "GEN# +1.00175225"},
        {"Smithsonian Astrophysical Observation", "SAO 31217"},
        {"Wilson Evans Batten Catalogue", "WEB 16012"},
    },
    visualMagnitude: 5.51,
    bvColour: 0.843,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.89583932),
        dec: Angle.Degrees(+52.97452091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 245.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116026"},
        {"Hipparcos Number", "HIP 65052"},
        {"Smithsonian Astrophysical Observation", "SAO 28718"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.01185550),
        dec: Angle.Degrees(+52.97697055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28034",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4494"},
        {"Henry Draper", "HD 39448"},
        {"Hipparcos Number", "HIP 28034"},
        {"Geneva Identification System", "GEN# +1.00039448"},
        {"Smithsonian Astrophysical Observation", "SAO 25457"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.92181026),
        dec: Angle.Degrees(+52.97785848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220719"},
        {"Hipparcos Number", "HIP 115643"},
        {"Smithsonian Astrophysical Observation", "SAO 35407"},
        {"Wilson Evans Batten Catalogue", "WEB 20466"},
    },
    visualMagnitude: 6.76,
    bvColour: 1.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.40044884),
        dec: Angle.Degrees(+52.97949951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232343"},
        {"Hipparcos Number", "HIP 4681"},
        {"Smithsonian Astrophysical Observation", "SAO 21907"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.04051311),
        dec: Angle.Degrees(+52.98013380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236207"},
        {"Hipparcos Number", "HIP 117047"},
        {"Smithsonian Astrophysical Observation", "SAO 35711"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.91450558),
        dec: Angle.Degrees(+52.98019744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77819"},
        {"Hipparcos Number", "HIP 44724"},
        {"Geneva Identification System", "GEN# +1.00077819"},
        {"Smithsonian Astrophysical Observation", "SAO 27125"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.928,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.69668789),
        dec: Angle.Degrees(+52.98116348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232996"},
        {"Hipparcos Number", "HIP 22020"},
        {"Smithsonian Astrophysical Observation", "SAO 24790"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.01473497),
        dec: Angle.Degrees(+52.98233482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -294.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141039"},
        {"Hipparcos Number", "HIP 77084"},
        {"Geneva Identification System", "GEN# +1.00141039"},
        {"Smithsonian Astrophysical Observation", "SAO 29638"},
        {"Wilson Evans Batten Catalogue", "WEB 13074"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.09117614),
        dec: Angle.Degrees(+52.98342391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -245.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96061",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12580 B"},
        {"Hipparcos Number", "HIP 96061"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.98496994),
        dec: Angle.Degrees(+52.98433795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96066",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12580 A"},
        {"Henry Draper", "HD 184468"},
        {"Hipparcos Number", "HIP 96066"},
        {"Smithsonian Astrophysical Observation", "SAO 31755"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.99009505),
        dec: Angle.Degrees(+52.98524271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174237"},
        {"Hipparcos Number", "HIP 92133"},
        {"Fundamental Katalog 5th Edition", "FK5 1492"},
        {"Geneva Identification System", "GEN# +1.00174237"},
        {"Smithsonian Astrophysical Observation", "SAO 31165"},
        {"Wilson Evans Batten Catalogue", "WEB 15885"},
    },
    visualMagnitude: 5.91,
    bvColour: -0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.67949234),
        dec: Angle.Degrees(+52.98797002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188056"},
        {"Hipparcos Number", "HIP 97635"},
        {"Fundamental Katalog 5th Edition", "FK5 3586"},
        {"Geneva Identification System", "GEN# +1.00188056"},
        {"Smithsonian Astrophysical Observation", "SAO 32042"},
        {"Wilson Evans Batten Catalogue", "WEB 17168"},
    },
    visualMagnitude: 5.03,
    bvColour: 1.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.65722388),
        dec: Angle.Degrees(+52.98816657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11308"},
        {"Hipparcos Number", "HIP 8740"},
        {"Smithsonian Astrophysical Observation", "SAO 22701"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.11137441),
        dec: Angle.Degrees(+52.98867529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80961",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10110 A"},
        {"Henry Draper", "HD 149419"},
        {"Hipparcos Number", "HIP 80961"},
        {"Smithsonian Astrophysical Observation", "SAO 29976"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.98176249),
        dec: Angle.Degrees(+52.99084625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70295"},
        {"Hipparcos Number", "HIP 41138"},
        {"Smithsonian Astrophysical Observation", "SAO 26816"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.90434077),
        dec: Angle.Degrees(+52.99121206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115164"},
        {"Hipparcos Number", "HIP 64608"},
        {"Smithsonian Astrophysical Observation", "SAO 28685"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.865,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.63028897),
        dec: Angle.Degrees(+52.99228385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234362"},
        {"Hipparcos Number", "HIP 82683"},
        {"Smithsonian Astrophysical Observation", "SAO 30146"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.51771923),
        dec: Angle.Degrees(+52.99232094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83963"},
        {"Hipparcos Number", "HIP 47705"},
        {"Smithsonian Astrophysical Observation", "SAO 27363"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.89990753),
        dec: Angle.Degrees(+52.99290200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134404"},
        {"Hipparcos Number", "HIP 74019"},
        {"Smithsonian Astrophysical Observation", "SAO 29415"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.89410087),
        dec: Angle.Degrees(+52.99355096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198181"},
        {"Hipparcos Number", "HIP 102499"},
        {"Fundamental Katalog 5th Edition", "FK5 1544"},
        {"Geneva Identification System", "GEN# +1.00198181"},
        {"Smithsonian Astrophysical Observation", "SAO 32877"},
        {"Wilson Evans Batten Catalogue", "WEB 18569"},
    },
    visualMagnitude: 6.34,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.58868245),
        dec: Angle.Degrees(+52.99555137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13424",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2185"},
        {"Henry Draper", "HD 17743"},
        {"Hipparcos Number", "HIP 13424"},
        {"Celescope Catalog", "CEL 296"},
        {"Geneva Identification System", "GEN# +1.00017743J"},
        {"Smithsonian Astrophysical Observation", "SAO 23674"},
        {"Wilson Evans Batten Catalogue", "WEB 2685"},
    },
    visualMagnitude: 6.35,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.21677622),
        dec: Angle.Degrees(+52.99738986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2826"},
        {"Hipparcos Number", "HIP 2531"},
        {"Smithsonian Astrophysical Observation", "SAO 21494"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.02932301),
        dec: Angle.Degrees(+53.00274865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232249"},
        {"Hipparcos Number", "HIP 3235"},
        {"Smithsonian Astrophysical Observation", "SAO 21620"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.29898242),
        dec: Angle.Degrees(+53.01250951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87228",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87228"},
    },
    visualMagnitude: 10.14,
    bvColour: 1.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.33687164),
        dec: Angle.Degrees(+53.01509876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102480"},
        {"Hipparcos Number", "HIP 57558"},
        {"Geneva Identification System", "GEN# +1.00102480"},
        {"Renson", "Renson 29560"},
        {"Smithsonian Astrophysical Observation", "SAO 28149"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.97034667),
        dec: Angle.Degrees(+53.01514464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7341"},
        {"Hipparcos Number", "HIP 5804"},
        {"Renson", "Renson 1820"},
        {"Smithsonian Astrophysical Observation", "SAO 22117"},
    },
    visualMagnitude: 9.48,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.61696172),
        dec: Angle.Degrees(+53.01842984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232156"},
        {"Hipparcos Number", "HIP 1548"},
        {"Smithsonian Astrophysical Observation", "SAO 21297"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.82316505),
        dec: Angle.Degrees(+53.02059150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76698",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76698"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.752,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.91562071),
        dec: Angle.Degrees(+53.02182222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17379"},
        {"Hipparcos Number", "HIP 13169"},
        {"Cincinnati Publication", "Ci 18 358"},
        {"Smithsonian Astrophysical Observation", "SAO 23635"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.845,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.33382090),
        dec: Angle.Degrees(+53.02355123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -205.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196087"},
        {"Hipparcos Number", "HIP 101372"},
        {"Smithsonian Astrophysical Observation", "SAO 32676"},
    },
    visualMagnitude: 7.76,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.18301422),
        dec: Angle.Degrees(+53.02510460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114484",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114484"},
        {"Wilson Evans Batten Catalogue", "WEB 20319"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.79210795),
        dec: Angle.Degrees(+53.02589520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216394"},
        {"Hipparcos Number", "HIP 112896"},
        {"Smithsonian Astrophysical Observation", "SAO 34883"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.93770237),
        dec: Angle.Degrees(+53.02849929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34757"},
        {"Hipparcos Number", "HIP 25126"},
        {"Smithsonian Astrophysical Observation", "SAO 25153"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.67519055),
        dec: Angle.Degrees(+53.02926658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32730",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5462 A"},
        {"Henry Draper", "HD 49082"},
        {"Hipparcos Number", "HIP 32730"},
        {"Geneva Identification System", "GEN# +1.00049082"},
        {"Smithsonian Astrophysical Observation", "SAO 25973"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.41234169),
        dec: Angle.Degrees(+53.03136244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17622"},
        {"Hipparcos Number", "HIP 13351"},
        {"Smithsonian Astrophysical Observation", "SAO 23665"},
        {"Wilson Evans Batten Catalogue", "WEB 2675"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.94740807),
        dec: Angle.Degrees(+53.03183247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9331"},
        {"Hipparcos Number", "HIP 7221"},
        {"Geneva Identification System", "GEN# +1.00009331"},
        {"Smithsonian Astrophysical Observation", "SAO 22381"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.25814289),
        dec: Angle.Degrees(+53.03372375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 220.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233732"},
        {"Hipparcos Number", "HIP 50917"},
        {"Smithsonian Astrophysical Observation", "SAO 27632"},
    },
    visualMagnitude: 9.70,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.96284238),
        dec: Angle.Degrees(+53.03787433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145832"},
        {"Hipparcos Number", "HIP 79255"},
        {"Smithsonian Astrophysical Observation", "SAO 29830"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.63437427),
        dec: Angle.Degrees(+53.04265252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31030"},
        {"Hipparcos Number", "HIP 22878"},
        {"Smithsonian Astrophysical Observation", "SAO 24912"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.81951757),
        dec: Angle.Degrees(+53.04277372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128953"},
        {"Hipparcos Number", "HIP 71541"},
        {"Smithsonian Astrophysical Observation", "SAO 29223"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.48798259),
        dec: Angle.Degrees(+53.04393366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114345",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114345"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.37514509),
        dec: Angle.Degrees(+53.04439659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154009"},
        {"Hipparcos Number", "HIP 83183"},
        {"Smithsonian Astrophysical Observation", "SAO 30195"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.01434070),
        dec: Angle.Degrees(+53.04448509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87835"},
        {"Hipparcos Number", "HIP 49731"},
        {"Smithsonian Astrophysical Observation", "SAO 27535"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.28833980),
        dec: Angle.Degrees(+53.04575121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2054"},
        {"Hipparcos Number", "HIP 1982"},
        {"Fundamental Katalog 5th Edition", "FK5 2022"},
        {"Geneva Identification System", "GEN# +1.00002054"},
        {"Renson", "Renson 490"},
        {"Smithsonian Astrophysical Observation", "SAO 21381"},
        {"Wilson Evans Batten Catalogue", "WEB 375"},
    },
    visualMagnitude: 5.72,
    bvColour: -0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.27660700),
        dec: Angle.Degrees(+53.04678501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182565"},
        {"Hipparcos Number", "HIP 95234"},
        {"Geneva Identification System", "GEN# +1.00182565"},
        {"Smithsonian Astrophysical Observation", "SAO 31611"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.63852176),
        dec: Angle.Degrees(+53.04694972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74502"},
        {"Hipparcos Number", "HIP 43096"},
        {"Renson", "Renson 20780"},
        {"Smithsonian Astrophysical Observation", "SAO 26993"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.65498487),
        dec: Angle.Degrees(+53.04789329)
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
    primaryId: "HIP 54389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96452"},
        {"Hipparcos Number", "HIP 54389"},
        {"Smithsonian Astrophysical Observation", "SAO 27915"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.91844703),
        dec: Angle.Degrees(+53.05218784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82206",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82206"},
    },
    visualMagnitude: 10.59,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.91177457),
        dec: Angle.Degrees(+53.05550482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 78.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203320"},
        {"Hipparcos Number", "HIP 105298"},
        {"Fundamental Katalog 5th Edition", "FK5 1560"},
        {"Geneva Identification System", "GEN# +1.00203320"},
        {"Smithsonian Astrophysical Observation", "SAO 33323"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.91984142),
        dec: Angle.Degrees(+53.05810785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218915"},
        {"Hipparcos Number", "HIP 114482"},
        {"Geneva Identification System", "GEN# +1.00218915"},
        {"Smithsonian Astrophysical Observation", "SAO 35206"},
        {"Wilson Evans Batten Catalogue", "WEB 20317"},
    },
    visualMagnitude: 7.23,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.77896077),
        dec: Angle.Degrees(+53.05825011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130894"},
        {"Hipparcos Number", "HIP 72434"},
        {"Smithsonian Astrophysical Observation", "SAO 29290"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.17652588),
        dec: Angle.Degrees(+53.05857185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13519"},
        {"Hipparcos Number", "HIP 10361"},
        {"Smithsonian Astrophysical Observation", "SAO 23046"},
    },
    visualMagnitude: 6.50,
    bvColour: 1.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.38962584),
        dec: Angle.Degrees(+53.05859199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76078"},
        {"Hipparcos Number", "HIP 43870"},
        {"Geneva Identification System", "GEN# +1.00076078"},
        {"Smithsonian Astrophysical Observation", "SAO 27048"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.05539286),
        dec: Angle.Degrees(+53.05871437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111949",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111949"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.15030617),
        dec: Angle.Degrees(+53.06098259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97098"},
        {"Hipparcos Number", "HIP 54662"},
        {"Smithsonian Astrophysical Observation", "SAO 27937"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.867,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.84322901),
        dec: Angle.Degrees(+53.06101183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15317"},
        {"Hipparcos Number", "HIP 11610"},
        {"Smithsonian Astrophysical Observation", "SAO 23373"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.43617264),
        dec: Angle.Degrees(+53.06116950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137027"},
        {"Hipparcos Number", "HIP 75150"},
        {"Smithsonian Astrophysical Observation", "SAO 29495"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.37445119),
        dec: Angle.Degrees(+53.06396888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72004",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72004"},
    },
    visualMagnitude: 10.58,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.88552372),
        dec: Angle.Degrees(+53.06517444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175307"},
        {"Hipparcos Number", "HIP 92578"},
        {"Smithsonian Astrophysical Observation", "SAO 31222"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.97258079),
        dec: Angle.Degrees(+53.06587583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15178"},
        {"Hipparcos Number", "HIP 11513"},
        {"Smithsonian Astrophysical Observation", "SAO 23363"},
        {"Wilson Evans Batten Catalogue", "WEB 2403"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.11788697),
        dec: Angle.Degrees(+53.06849046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187054"},
        {"Hipparcos Number", "HIP 97199"},
        {"Smithsonian Astrophysical Observation", "SAO 31957"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.31846951),
        dec: Angle.Degrees(+53.06919318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234334"},
        {"Hipparcos Number", "HIP 81739"},
        {"Smithsonian Astrophysical Observation", "SAO 30051"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.43501675),
        dec: Angle.Degrees(+53.07257095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1224",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1224"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.81061118),
        dec: Angle.Degrees(+53.07404693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 223.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87704"},
        {"Hipparcos Number", "HIP 49661"},
        {"Smithsonian Astrophysical Observation", "SAO 27531"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.06919505),
        dec: Angle.Degrees(+53.07579326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108954"},
        {"Hipparcos Number", "HIP 61053"},
        {"Geneva Identification System", "GEN# +1.00108954"},
        {"Smithsonian Astrophysical Observation", "SAO 28413"},
        {"Wilson Evans Batten Catalogue", "WEB 10870"},
    },
    visualMagnitude: 6.20,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.70882191),
        dec: Angle.Degrees(+53.07616553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 182.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44189"},
        {"Hipparcos Number", "HIP 30394"},
        {"Smithsonian Astrophysical Observation", "SAO 25699"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.87281981),
        dec: Angle.Degrees(+53.07736998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11922"},
        {"Hipparcos Number", "HIP 9212"},
        {"Geneva Identification System", "GEN# +1.00011922"},
        {"Smithsonian Astrophysical Observation", "SAO 22804"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.62133136),
        dec: Angle.Degrees(+53.07752626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234450"},
        {"Hipparcos Number", "HIP 85648"},
        {"Smithsonian Astrophysical Observation", "SAO 30428"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.755,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.55443718),
        dec: Angle.Degrees(+53.07844926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12351"},
        {"Hipparcos Number", "HIP 9542"},
        {"Smithsonian Astrophysical Observation", "SAO 22868"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.66299318),
        dec: Angle.Degrees(+53.07942562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21727",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3359 A"},
        {"Henry Draper", "HD 29317"},
        {"Hipparcos Number", "HIP 21727"},
        {"Geneva Identification System", "GEN# +1.00029317"},
        {"Smithsonian Astrophysical Observation", "SAO 24743"},
        {"Wilson Evans Batten Catalogue", "WEB 4174"},
    },
    visualMagnitude: 5.07,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.97786313),
        dec: Angle.Degrees(+53.07957406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106794",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106794"},
    },
    visualMagnitude: 10.57,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.45795858),
        dec: Angle.Degrees(+53.08015269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 311.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139043"},
        {"Hipparcos Number", "HIP 76179"},
        {"Smithsonian Astrophysical Observation", "SAO 29571"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.40141728),
        dec: Angle.Degrees(+53.08115020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170490"},
        {"Hipparcos Number", "HIP 90405"},
        {"Smithsonian Astrophysical Observation", "SAO 30976"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.70000756),
        dec: Angle.Degrees(+53.08195213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233338"},
        {"Hipparcos Number", "HIP 34492"},
        {"Smithsonian Astrophysical Observation", "SAO 26173"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.20905533),
        dec: Angle.Degrees(+53.08414658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48207"},
        {"Hipparcos Number", "HIP 32358"},
        {"Smithsonian Astrophysical Observation", "SAO 25932"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.31023315),
        dec: Angle.Degrees(+53.08611514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234400"},
        {"Hipparcos Number", "HIP 83939"},
        {"Smithsonian Astrophysical Observation", "SAO 30268"},
    },
    visualMagnitude: 10.48,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.35702566),
        dec: Angle.Degrees(+53.08693561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207543"},
        {"Hipparcos Number", "HIP 107643"},
        {"Celescope Catalog", "CEL 5389"},
        {"Geneva Identification System", "GEN# +1.00207543"},
        {"Smithsonian Astrophysical Observation", "SAO 33768"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.04597243),
        dec: Angle.Degrees(+53.08982659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233312"},
        {"Hipparcos Number", "HIP 33809"},
        {"Smithsonian Astrophysical Observation", "SAO 26096"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.28610634),
        dec: Angle.Degrees(+53.09228174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103737"},
        {"Hipparcos Number", "HIP 58252"},
        {"Smithsonian Astrophysical Observation", "SAO 28197"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.21028657),
        dec: Angle.Degrees(+53.09307099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234765"},
        {"Hipparcos Number", "HIP 93145"},
        {"Smithsonian Astrophysical Observation", "SAO 31298"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.61022711),
        dec: Angle.Degrees(+53.09317229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233977"},
        {"Hipparcos Number", "HIP 62244"},
        {"Smithsonian Astrophysical Observation", "SAO 28506"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.34965337),
        dec: Angle.Degrees(+53.09584793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10965"},
        {"Hipparcos Number", "HIP 8452"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.24298029),
        dec: Angle.Degrees(+53.10064332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232473"},
        {"Hipparcos Number", "HIP 7528"},
        {"Smithsonian Astrophysical Observation", "SAO 22437"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.23659906),
        dec: Angle.Degrees(+53.10572528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68304",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9077 AB"},
        {"Henry Draper", "HD 122200"},
        {"Hipparcos Number", "HIP 68304"},
        {"Smithsonian Astrophysical Observation", "SAO 28955"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.73081849),
        dec: Angle.Degrees(+53.10647480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77247"},
        {"Hipparcos Number", "HIP 44464"},
        {"Smithsonian Astrophysical Observation", "SAO 27101"},
        {"Wilson Evans Batten Catalogue", "WEB 8521"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.88445869),
        dec: Angle.Degrees(+53.10830868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233954"},
        {"Hipparcos Number", "HIP 61526"},
        {"Smithsonian Astrophysical Observation", "SAO 28443"},
    },
    visualMagnitude: 10.31,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.07995058),
        dec: Angle.Degrees(+53.10920582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119146"},
        {"Hipparcos Number", "HIP 66684"},
        {"Smithsonian Astrophysical Observation", "SAO 28835"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.04873454),
        dec: Angle.Degrees(+53.11038421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235590"},
        {"Hipparcos Number", "HIP 107050"},
        {"Smithsonian Astrophysical Observation", "SAO 33659"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.21544307),
        dec: Angle.Degrees(+53.11134518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194132"},
        {"Hipparcos Number", "HIP 100387"},
        {"Renson", "Renson 54180"},
        {"Smithsonian Astrophysical Observation", "SAO 32502"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.37576689),
        dec: Angle.Degrees(+53.11294786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83905"},
        {"Hipparcos Number", "HIP 47670"},
        {"Geneva Identification System", "GEN# +1.00083905"},
        {"Smithsonian Astrophysical Observation", "SAO 27360"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.80800689),
        dec: Angle.Degrees(+53.11418015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71952"},
        {"Hipparcos Number", "HIP 41894"},
        {"Geneva Identification System", "GEN# +1.00071952"},
        {"Smithsonian Astrophysical Observation", "SAO 26896"},
        {"Wilson Evans Batten Catalogue", "WEB 8063"},
    },
    visualMagnitude: 6.23,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.13932858),
        dec: Angle.Degrees(+53.11502806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22289",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3442 B"},
        {"Hipparcos Number", "HIP 22289"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.00617831),
        dec: Angle.Degrees(+53.11621278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177857"},
        {"Hipparcos Number", "HIP 93592"},
        {"Smithsonian Astrophysical Observation", "SAO 31356"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.90751063),
        dec: Angle.Degrees(+53.11638180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236070"},
        {"Hipparcos Number", "HIP 114623"},
        {"Smithsonian Astrophysical Observation", "SAO 35238"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.31156833),
        dec: Angle.Degrees(+53.12082071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22290",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3442 A"},
        {"Henry Draper", "HD 30167"},
        {"Hipparcos Number", "HIP 22290"},
        {"Smithsonian Astrophysical Observation", "SAO 24835"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.00717500),
        dec: Angle.Degrees(+53.12200192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71748"},
        {"Hipparcos Number", "HIP 41805"},
        {"Geneva Identification System", "GEN# +1.00071748"},
        {"Smithsonian Astrophysical Observation", "SAO 26887"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.85011261),
        dec: Angle.Degrees(+53.12220531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223900"},
        {"Hipparcos Number", "HIP 117800"},
        {"Smithsonian Astrophysical Observation", "SAO 35865"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.35240017),
        dec: Angle.Degrees(+53.12418083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86560"},
        {"Hipparcos Number", "HIP 49070"},
        {"Geneva Identification System", "GEN# +1.00086560"},
        {"Smithsonian Astrophysical Observation", "SAO 27473"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.23001413),
        dec: Angle.Degrees(+53.12455444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 170.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99680",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13560 AB"},
        {"Henry Draper", "HD 192679"},
        {"Hipparcos Number", "HIP 99680"},
        {"Geneva Identification System", "GEN# +1.00192679"},
        {"Smithsonian Astrophysical Observation", "SAO 32380"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.41956985),
        dec: Angle.Degrees(+53.12467632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 168.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148403"},
        {"Hipparcos Number", "HIP 80433"},
        {"Smithsonian Astrophysical Observation", "SAO 29936"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.27280452),
        dec: Angle.Degrees(+53.12649692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8654"},
        {"Hipparcos Number", "HIP 6725"},
        {"Smithsonian Astrophysical Observation", "SAO 22277"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.63461061),
        dec: Angle.Degrees(+53.13007936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210144"},
        {"Hipparcos Number", "HIP 109162"},
        {"Cincinnati Publication", "Ci 18 2885"},
        {"Cincinnati Publication 2", "Ci 20 1335"},
        {"Geneva Identification System", "GEN# +1.00210144"},
        {"Smithsonian Astrophysical Observation", "SAO 34067"},
        {"Wilson Evans Batten Catalogue", "WEB 19623"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.788,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.67632433),
        dec: Angle.Degrees(+53.13147765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -531.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -341.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23518",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23518"},
        {"Geneva Identification System", "GEN# +0.05200911"},
        {"Wilson Evans Batten Catalogue", "WEB 4580"},
    },
    visualMagnitude: 9.96,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.84430666),
        dec: Angle.Degrees(+53.13220642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1304.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1537.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158222"},
        {"Hipparcos Number", "HIP 85244"},
        {"Geneva Identification System", "GEN# +1.00158222"},
        {"Smithsonian Astrophysical Observation", "SAO 30377"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.28474854),
        dec: Angle.Degrees(+53.13254796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32805",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32805"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.58238919),
        dec: Angle.Degrees(+53.13306563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -300.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21937",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3392 A"},
        {"Henry Draper", "HD 29644"},
        {"Hipparcos Number", "HIP 21937"},
        {"Smithsonian Astrophysical Observation", "SAO 24778"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.74135753),
        dec: Angle.Degrees(+53.13841801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6112"},
        {"Hipparcos Number", "HIP 4918"},
        {"Smithsonian Astrophysical Observation", "SAO 21951"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.79109350),
        dec: Angle.Degrees(+53.14043205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41453"},
        {"Hipparcos Number", "HIP 29102"},
        {"Smithsonian Astrophysical Observation", "SAO 25582"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.07400390),
        dec: Angle.Degrees(+53.14210149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233763"},
        {"Hipparcos Number", "HIP 52480"},
        {"Smithsonian Astrophysical Observation", "SAO 27749"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.93783444),
        dec: Angle.Degrees(+53.14298147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19558"},
        {"Hipparcos Number", "HIP 14790"},
        {"Fundamental Katalog 5th Edition", "FK5 4292"},
        {"Geneva Identification System", "GEN# +1.00019558"},
        {"Smithsonian Astrophysical Observation", "SAO 23857"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.75079643),
        dec: Angle.Degrees(+53.14332522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234993"},
        {"Hipparcos Number", "HIP 97126"},
        {"Smithsonian Astrophysical Observation", "SAO 31945"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.10058972),
        dec: Angle.Degrees(+53.14702254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75065",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9602 AB"},
        {"Hipparcos Number", "HIP 75065"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.09229855),
        dec: Angle.Degrees(+53.14788738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235556"},
        {"Hipparcos Number", "HIP 106613"},
        {"Geneva Identification System", "GEN# +1.00235556"},
        {"Smithsonian Astrophysical Observation", "SAO 33558"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.91486560),
        dec: Angle.Degrees(+53.14854564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26113"},
        {"Hipparcos Number", "HIP 19503"},
        {"Geneva Identification System", "GEN# +1.00026113"},
        {"Smithsonian Astrophysical Observation", "SAO 24453"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.67494325),
        dec: Angle.Degrees(+53.15213192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222762"},
        {"Hipparcos Number", "HIP 116993"},
        {"Smithsonian Astrophysical Observation", "SAO 35700"},
    },
    visualMagnitude: 6.63,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.77359022),
        dec: Angle.Degrees(+53.15259950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143741"},
        {"Hipparcos Number", "HIP 78327"},
        {"Smithsonian Astrophysical Observation", "SAO 29741"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.90485108),
        dec: Angle.Degrees(+53.15287352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211071"},
        {"Hipparcos Number", "HIP 109713"},
        {"Fundamental Katalog 5th Edition", "FK5 5962"},
        {"Geneva Identification System", "GEN# +1.00211071"},
        {"Smithsonian Astrophysical Observation", "SAO 34192"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.34945490),
        dec: Angle.Degrees(+53.15405910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159203"},
        {"Hipparcos Number", "HIP 85669"},
        {"Smithsonian Astrophysical Observation", "SAO 30430"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.60590910),
        dec: Angle.Degrees(+53.15463626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31579"},
        {"Hipparcos Number", "HIP 23216"},
        {"Geneva Identification System", "GEN# +1.00031579"},
        {"Smithsonian Astrophysical Observation", "SAO 24943"},
        {"Wilson Evans Batten Catalogue", "WEB 4511"},
    },
    visualMagnitude: 6.09,
    bvColour: 1.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.94308870),
        dec: Angle.Degrees(+53.15547819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66940",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66940"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.771,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.78160445),
        dec: Angle.Degrees(+53.16030723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -156.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35864"},
        {"Hipparcos Number", "HIP 25808"},
        {"Geneva Identification System", "GEN# +1.00035864"},
        {"Smithsonian Astrophysical Observation", "SAO 25224"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.68770509),
        dec: Angle.Degrees(+53.16192998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12936",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2102 A"},
        {"Henry Draper", "HD 17063"},
        {"Hipparcos Number", "HIP 12936"},
        {"Smithsonian Astrophysical Observation", "SAO 23597"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.58828972),
        dec: Angle.Degrees(+53.16297144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234668"},
        {"Hipparcos Number", "HIP 90754"},
        {"Smithsonian Astrophysical Observation", "SAO 31021"},
    },
    visualMagnitude: 9.55,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.75103038),
        dec: Angle.Degrees(+53.16440390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191195"},
        {"Hipparcos Number", "HIP 99026"},
        {"Fundamental Katalog 5th Edition", "FK5 3613"},
        {"Geneva Identification System", "GEN# +1.00191195"},
        {"Smithsonian Astrophysical Observation", "SAO 32286"},
        {"Wilson Evans Batten Catalogue", "WEB 17603"},
    },
    visualMagnitude: 5.81,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.55682854),
        dec: Angle.Degrees(+53.16506746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 212.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 255.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235330"},
        {"Hipparcos Number", "HIP 102228"},
        {"Smithsonian Astrophysical Observation", "SAO 32822"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.71217962),
        dec: Angle.Degrees(+53.16663536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224837"},
        {"Hipparcos Number", "HIP 89"},
        {"Smithsonian Astrophysical Observation", "SAO 35993"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.27715178),
        dec: Angle.Degrees(+53.16694253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220806"},
        {"Hipparcos Number", "HIP 115689"},
        {"Smithsonian Astrophysical Observation", "SAO 35414"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.58571528),
        dec: Angle.Degrees(+53.16701872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58"},
        {"Hipparcos Number", "HIP 466"},
        {"Smithsonian Astrophysical Observation", "SAO 21074"},
        {"Wilson Evans Batten Catalogue", "WEB 75"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.39547600),
        dec: Angle.Degrees(+53.17169568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234465"},
        {"Hipparcos Number", "HIP 86264"},
        {"Smithsonian Astrophysical Observation", "SAO 30489"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.925,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.39874944),
        dec: Angle.Degrees(+53.17245374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232787"},
        {"Hipparcos Number", "HIP 15892"},
        {"Smithsonian Astrophysical Observation", "SAO 24013"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.17680374),
        dec: Angle.Degrees(+53.17278005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61381"},
        {"Hipparcos Number", "HIP 37487"},
        {"Smithsonian Astrophysical Observation", "SAO 26466"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.42827158),
        dec: Angle.Degrees(+53.17333248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202860"},
        {"Hipparcos Number", "HIP 105054"},
        {"Smithsonian Astrophysical Observation", "SAO 33278"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.19344046),
        dec: Angle.Degrees(+53.17391475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117449"},
        {"Hipparcos Number", "HIP 65802"},
        {"Smithsonian Astrophysical Observation", "SAO 28775"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.32452391),
        dec: Angle.Degrees(+53.17753985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233348"},
        {"Hipparcos Number", "HIP 34685"},
        {"Smithsonian Astrophysical Observation", "SAO 26198"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.74245810),
        dec: Angle.Degrees(+53.18262366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166381"},
        {"Hipparcos Number", "HIP 88784"},
        {"Smithsonian Astrophysical Observation", "SAO 30759"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.86031125),
        dec: Angle.Degrees(+53.18333322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234776"},
        {"Hipparcos Number", "HIP 93360"},
        {"Smithsonian Astrophysical Observation", "SAO 31325"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.24774950),
        dec: Angle.Degrees(+53.18422527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8425"},
        {"Hipparcos Number", "HIP 6583"},
        {"Smithsonian Astrophysical Observation", "SAO 22253"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.13765405),
        dec: Angle.Degrees(+53.18616065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172467"},
        {"Hipparcos Number", "HIP 91303"},
        {"Smithsonian Astrophysical Observation", "SAO 31075"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.36383652),
        dec: Angle.Degrees(+53.18635958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233931"},
        {"Hipparcos Number", "HIP 60416"},
        {"Smithsonian Astrophysical Observation", "SAO 28360"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.81220787),
        dec: Angle.Degrees(+53.18871977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10565"},
        {"Hipparcos Number", "HIP 8118"},
        {"Fundamental Katalog 5th Edition", "FK5 4155"},
        {"Smithsonian Astrophysical Observation", "SAO 22568"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.08899050),
        dec: Angle.Degrees(+53.18910998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106884"},
        {"Hipparcos Number", "HIP 59920"},
        {"Geneva Identification System", "GEN# +1.00106884"},
        {"Smithsonian Astrophysical Observation", "SAO 28327"},
        {"Wilson Evans Batten Catalogue", "WEB 10644"},
    },
    visualMagnitude: 5.80,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.37317610),
        dec: Angle.Degrees(+53.19144123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112904",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16323 A"},
        {"Henry Draper", "HD 216413"},
        {"Hipparcos Number", "HIP 112904"},
        {"Geneva Identification System", "GEN# +1.00216413"},
        {"Smithsonian Astrophysical Observation", "SAO 34885"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.95129346),
        dec: Angle.Degrees(+53.19144716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119169"},
        {"Hipparcos Number", "HIP 66705"},
        {"Smithsonian Astrophysical Observation", "SAO 28837"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.10224435),
        dec: Angle.Degrees(+53.19177291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6580",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6580"},
        {"Smithsonian Astrophysical Observation", "SAO 22252"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.13416931),
        dec: Angle.Degrees(+53.19324562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87645"},
        {"Hipparcos Number", "HIP 49629"},
        {"Geneva Identification System", "GEN# +1.00087645"},
        {"Smithsonian Astrophysical Observation", "SAO 27528"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.93400767),
        dec: Angle.Degrees(+53.19602203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235426"},
        {"Hipparcos Number", "HIP 103707"},
        {"Smithsonian Astrophysical Observation", "SAO 33065"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.22354567),
        dec: Angle.Degrees(+53.19752358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69602"},
        {"Hipparcos Number", "HIP 40849"},
        {"Smithsonian Astrophysical Observation", "SAO 26782"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.03026516),
        dec: Angle.Degrees(+53.19752921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223389"},
        {"Hipparcos Number", "HIP 117460"},
        {"Smithsonian Astrophysical Observation", "SAO 35797"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.24437135),
        dec: Angle.Degrees(+53.20222980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111528",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16098 AB"},
        {"Henry Draper", "HD 214222"},
        {"Hipparcos Number", "HIP 111528"},
        {"Geneva Identification System", "GEN# +1.00214222J"},
        {"Smithsonian Astrophysical Observation", "SAO 34600"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.92750948),
        dec: Angle.Degrees(+53.20389482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65898"},
        {"Hipparcos Number", "HIP 39432"},
        {"Smithsonian Astrophysical Observation", "SAO 26642"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.91505967),
        dec: Angle.Degrees(+53.20825918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95548"},
        {"Hipparcos Number", "HIP 53972"},
        {"Smithsonian Astrophysical Observation", "SAO 27878"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.62086793),
        dec: Angle.Degrees(+53.20862611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58119"},
        {"Hipparcos Number", "HIP 36172"},
        {"Smithsonian Astrophysical Observation", "SAO 26346"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.75878794),
        dec: Angle.Degrees(+53.21070055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91931"},
        {"Hipparcos Number", "HIP 52041"},
        {"Smithsonian Astrophysical Observation", "SAO 27716"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.49993879),
        dec: Angle.Degrees(+53.21108054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180395"},
        {"Hipparcos Number", "HIP 94475"},
        {"Geneva Identification System", "GEN# +1.00180395"},
        {"Smithsonian Astrophysical Observation", "SAO 31490"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.42124734),
        dec: Angle.Degrees(+53.21249108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209678"},
        {"Hipparcos Number", "HIP 108911"},
        {"Geneva Identification System", "GEN# +1.00209678"},
        {"Smithsonian Astrophysical Observation", "SAO 34012"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.92222849),
        dec: Angle.Degrees(+53.21253903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33654"},
        {"Hipparcos Number", "HIP 24451"},
        {"Fundamental Katalog 5th Edition", "FK5 2393"},
        {"Geneva Identification System", "GEN# +1.00033654"},
        {"Renson", "Renson 8590"},
        {"Smithsonian Astrophysical Observation", "SAO 25087"},
        {"Wilson Evans Batten Catalogue", "WEB 4736"},
    },
    visualMagnitude: 6.16,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.68447254),
        dec: Angle.Degrees(+53.21394817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219623"},
        {"Hipparcos Number", "HIP 114924"},
        {"Fundamental Katalog 5th Edition", "FK5 3863"},
        {"Geneva Identification System", "GEN# +1.00219623"},
        {"Smithsonian Astrophysical Observation", "SAO 35285"},
        {"Wilson Evans Batten Catalogue", "WEB 20363"},
    },
    visualMagnitude: 5.58,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.17580980),
        dec: Angle.Degrees(+53.21404995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -236.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13209"},
        {"Hipparcos Number", "HIP 10159"},
        {"Celescope Catalog", "CEL 214"},
        {"Geneva Identification System", "GEN# +1.00013209"},
        {"Smithsonian Astrophysical Observation", "SAO 23004"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.66121422),
        dec: Angle.Degrees(+53.21476743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234163"},
        {"Hipparcos Number", "HIP 71396"},
        {"Smithsonian Astrophysical Observation", "SAO 29215"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.00305690),
        dec: Angle.Degrees(+53.21553536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233744"},
        {"Hipparcos Number", "HIP 51695"},
        {"Smithsonian Astrophysical Observation", "SAO 27681"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.40408921),
        dec: Angle.Degrees(+53.21686233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144405"},
        {"Hipparcos Number", "HIP 78646"},
        {"Geneva Identification System", "GEN# +1.00144405"},
        {"Smithsonian Astrophysical Observation", "SAO 29772"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.81610524),
        dec: Angle.Degrees(+53.21694364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70313"},
        {"Hipparcos Number", "HIP 41152"},
        {"Fundamental Katalog 5th Edition", "FK5 2649"},
        {"Geneva Identification System", "GEN# +1.00070313"},
        {"Renson", "Renson 19400"},
        {"Smithsonian Astrophysical Observation", "SAO 26819"},
        {"Wilson Evans Batten Catalogue", "WEB 7965"},
    },
    visualMagnitude: 5.52,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.95220483),
        dec: Angle.Degrees(+53.21995142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38748"},
        {"Hipparcos Number", "HIP 27632"},
        {"Smithsonian Astrophysical Observation", "SAO 25410"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.74861128),
        dec: Angle.Degrees(+53.22108782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201543"},
        {"Hipparcos Number", "HIP 104345"},
        {"Celescope Catalog", "CEL 5249"},
        {"Smithsonian Astrophysical Observation", "SAO 33163"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.07508218),
        dec: Angle.Degrees(+53.22615160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188359"},
        {"Hipparcos Number", "HIP 97782"},
        {"Smithsonian Astrophysical Observation", "SAO 32069"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.04402838),
        dec: Angle.Degrees(+53.22645716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232737"},
        {"Hipparcos Number", "HIP 13894"},
        {"Smithsonian Astrophysical Observation", "SAO 23745"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.72772980),
        dec: Angle.Degrees(+53.22700920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44272"},
        {"Hipparcos Number", "HIP 30435"},
        {"Smithsonian Astrophysical Observation", "SAO 25703"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.98060267),
        dec: Angle.Degrees(+53.22801392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236215"},
        {"Hipparcos Number", "HIP 117335"},
        {"Smithsonian Astrophysical Observation", "SAO 35770"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.87690445),
        dec: Angle.Degrees(+53.23074571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154650"},
        {"Hipparcos Number", "HIP 83501"},
        {"Smithsonian Astrophysical Observation", "SAO 30225"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.98230989),
        dec: Angle.Degrees(+53.23121211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219902"},
        {"Hipparcos Number", "HIP 115116"},
        {"Smithsonian Astrophysical Observation", "SAO 35322"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.75127179),
        dec: Angle.Degrees(+53.23307914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138056"},
        {"Hipparcos Number", "HIP 75649"},
        {"Smithsonian Astrophysical Observation", "SAO 29532"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.83076091),
        dec: Angle.Degrees(+53.23385172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33201"},
        {"Hipparcos Number", "HIP 24179"},
        {"Geneva Identification System", "GEN# +1.00033201"},
        {"Smithsonian Astrophysical Observation", "SAO 25064"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.87526451),
        dec: Angle.Degrees(+53.23478245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17033"},
        {"Hipparcos Number", "HIP 12918"},
        {"Smithsonian Astrophysical Observation", "SAO 23594"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.52532994),
        dec: Angle.Degrees(+53.23578694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146870"},
        {"Hipparcos Number", "HIP 79685"},
        {"Fundamental Katalog 5th Edition", "FK5 5433"},
        {"Geneva Identification System", "GEN# +1.00146870"},
        {"Smithsonian Astrophysical Observation", "SAO 29858"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.94695571),
        dec: Angle.Degrees(+53.23682251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234025"},
        {"Hipparcos Number", "HIP 64742"},
        {"Smithsonian Astrophysical Observation", "SAO 28697"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.03545933),
        dec: Angle.Degrees(+53.23756541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19654"},
        {"Hipparcos Number", "HIP 14890"},
        {"Smithsonian Astrophysical Observation", "SAO 23872"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.04594568),
        dec: Angle.Degrees(+53.23825937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208563"},
        {"Hipparcos Number", "HIP 108233"},
        {"Geneva Identification System", "GEN# +1.00208563"},
        {"Smithsonian Astrophysical Observation", "SAO 33875"},
    },
    visualMagnitude: 6.68,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.89626899),
        dec: Angle.Degrees(+53.24321322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1265"},
        {"Hipparcos Number", "HIP 1357"},
        {"Smithsonian Astrophysical Observation", "SAO 21268"},
    },
    visualMagnitude: 7.75,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.25085379),
        dec: Angle.Degrees(+53.24327947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67562"},
        {"Hipparcos Number", "HIP 40071"},
        {"Fundamental Katalog 5th Edition", "FK5 4737"},
        {"Geneva Identification System", "GEN# +1.00067562"},
        {"Smithsonian Astrophysical Observation", "SAO 26716"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.79033975),
        dec: Angle.Degrees(+53.24526461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77728"},
        {"Hipparcos Number", "HIP 44688"},
        {"Smithsonian Astrophysical Observation", "SAO 27119"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.60207067),
        dec: Angle.Degrees(+53.24591034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217835"},
        {"Hipparcos Number", "HIP 113806"},
        {"Smithsonian Astrophysical Observation", "SAO 35093"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.69232024),
        dec: Angle.Degrees(+53.24634183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53025",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53025"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.73682708),
        dec: Angle.Degrees(+53.24801311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -222.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -189.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206763"},
        {"Hipparcos Number", "HIP 107189"},
        {"Celescope Catalog", "CEL 5373"},
        {"Geneva Identification System", "GEN# +1.00206763"},
        {"Smithsonian Astrophysical Observation", "SAO 33678"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.66470832),
        dec: Angle.Degrees(+53.25027759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233345"},
        {"Hipparcos Number", "HIP 34642"},
        {"Smithsonian Astrophysical Observation", "SAO 26190"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.62441645),
        dec: Angle.Degrees(+53.25236480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -241.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 372"},
        {"Hipparcos Number", "HIP 697"},
        {"Geneva Identification System", "GEN# +1.00000372"},
        {"Smithsonian Astrophysical Observation", "SAO 21127"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.14711178),
        dec: Angle.Degrees(+53.25410868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5127"},
        {"Hipparcos Number", "HIP 4215"},
        {"Smithsonian Astrophysical Observation", "SAO 21815"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.45205547),
        dec: Angle.Degrees(+53.25764829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78049"},
        {"Hipparcos Number", "HIP 44840"},
        {"Smithsonian Astrophysical Observation", "SAO 27132"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.03819534),
        dec: Angle.Degrees(+53.25906758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2253"},
        {"Hipparcos Number", "HIP 2109"},
        {"Smithsonian Astrophysical Observation", "SAO 21410"},
    },
    visualMagnitude: 8.98,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.69671531),
        dec: Angle.Degrees(+53.26115700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108721"},
        {"Hipparcos Number", "HIP 60919"},
        {"Smithsonian Astrophysical Observation", "SAO 28401"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.27545700),
        dec: Angle.Degrees(+53.26122816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120528"},
        {"Hipparcos Number", "HIP 67388"},
        {"Geneva Identification System", "GEN# +1.00120528"},
        {"Smithsonian Astrophysical Observation", "SAO 28894"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.16769321),
        dec: Angle.Degrees(+53.26142951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134586"},
        {"Hipparcos Number", "HIP 74094"},
        {"Geneva Identification System", "GEN# +1.00134586"},
        {"Smithsonian Astrophysical Observation", "SAO 29423"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.13868854),
        dec: Angle.Degrees(+53.26233818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236100"},
        {"Hipparcos Number", "HIP 115232"},
        {"Smithsonian Astrophysical Observation", "SAO 35334"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.09634822),
        dec: Angle.Degrees(+53.26254101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125273"},
        {"Hipparcos Number", "HIP 69772"},
        {"Geneva Identification System", "GEN# +1.00125273"},
        {"Renson", "Renson 35770"},
        {"Smithsonian Astrophysical Observation", "SAO 29079"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.18666351),
        dec: Angle.Degrees(+53.26356069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48940",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7598 AB"},
        {"Aitken 2", "ADS 7548"},
        {"Henry Draper", "HD 86309"},
        {"Hipparcos Number", "HIP 48940"},
        {"Smithsonian Astrophysical Observation", "SAO 27456"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.77313968),
        dec: Angle.Degrees(+53.26374742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68580"},
        {"Hipparcos Number", "HIP 40451"},
        {"Smithsonian Astrophysical Observation", "SAO 26741"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.88560139),
        dec: Angle.Degrees(+53.26742781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211149"},
        {"Hipparcos Number", "HIP 109759"},
        {"Geneva Identification System", "GEN# +1.00211149"},
        {"Smithsonian Astrophysical Observation", "SAO 34205"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.47280309),
        dec: Angle.Degrees(+53.26806595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18218",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2828 AB"},
        {"Henry Draper", "HD 24203"},
        {"Hipparcos Number", "HIP 18218"},
        {"Geneva Identification System", "GEN# +1.00024203"},
        {"Smithsonian Astrophysical Observation", "SAO 24278"},
        {"Wilson Evans Batten Catalogue", "WEB 3516"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.43200541),
        dec: Angle.Degrees(+53.27320209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234513"},
        {"Hipparcos Number", "HIP 87542"},
        {"Smithsonian Astrophysical Observation", "SAO 30625"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.26872483),
        dec: Angle.Degrees(+53.27606452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109"},
        {"Hipparcos Number", "HIP 506"},
        {"Smithsonian Astrophysical Observation", "SAO 21083"},
    },
    visualMagnitude: 8.66,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.51463805),
        dec: Angle.Degrees(+53.27691513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25292"},
        {"Hipparcos Number", "HIP 18966"},
        {"Geneva Identification System", "GEN# +1.00025292"},
        {"Smithsonian Astrophysical Observation", "SAO 24381"},
        {"Wilson Evans Batten Catalogue", "WEB 3645"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.96316372),
        dec: Angle.Degrees(+53.27771757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57487",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8304 A"},
        {"Henry Draper", "HD 102342"},
        {"Hipparcos Number", "HIP 57487"},
        {"Geneva Identification System", "GEN# +1.00102342"},
        {"Smithsonian Astrophysical Observation", "SAO 28143"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.75323921),
        dec: Angle.Degrees(+53.28533193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200817"},
        {"Hipparcos Number", "HIP 103956"},
        {"Fundamental Katalog 5th Edition", "FK5 3682"},
        {"Geneva Identification System", "GEN# +1.00200817"},
        {"Smithsonian Astrophysical Observation", "SAO 33098"},
        {"Wilson Evans Batten Catalogue", "WEB 18933"},
    },
    visualMagnitude: 5.93,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.94827016),
        dec: Angle.Degrees(+53.28582252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6644"},
        {"Hipparcos Number", "HIP 5324"},
        {"Smithsonian Astrophysical Observation", "SAO 22027"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.01906310),
        dec: Angle.Degrees(+53.28600230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57483",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8304 B"},
        {"Hipparcos Number", "HIP 57483"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.74869089),
        dec: Angle.Degrees(+53.28627385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233430"},
        {"Hipparcos Number", "HIP 37275"},
        {"Smithsonian Astrophysical Observation", "SAO 26445"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.81571879),
        dec: Angle.Degrees(+53.28751908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204614"},
        {"Hipparcos Number", "HIP 105990"},
        {"Celescope Catalog", "CEL 5319"},
        {"Geneva Identification System", "GEN# +1.00204614"},
        {"Smithsonian Astrophysical Observation", "SAO 33446"},
    },
    visualMagnitude: 7.18,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.99902193),
        dec: Angle.Degrees(+53.28928939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234576"},
        {"Hipparcos Number", "HIP 89073"},
        {"Smithsonian Astrophysical Observation", "SAO 30787"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.68819629),
        dec: Angle.Degrees(+53.29033071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120915"},
        {"Hipparcos Number", "HIP 67590"},
        {"Geneva Identification System", "GEN# +1.00120915"},
        {"Smithsonian Astrophysical Observation", "SAO 28903"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.74915118),
        dec: Angle.Degrees(+53.29041959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47107",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7440 B"},
        {"Hipparcos Number", "HIP 47107"},
    },
    visualMagnitude: 10.84,
    bvColour: 0.756,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.01425607),
        dec: Angle.Degrees(+53.29335518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17261",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2682 AB"},
        {"Henry Draper", "HD 232821"},
        {"Hipparcos Number", "HIP 17261"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.45761242),
        dec: Angle.Degrees(+53.29368689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210221"},
        {"Hipparcos Number", "HIP 109205"},
        {"Geneva Identification System", "GEN# +1.00210221"},
        {"Smithsonian Astrophysical Observation", "SAO 34076"},
        {"Wilson Evans Batten Catalogue", "WEB 19629"},
    },
    visualMagnitude: 6.17,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.85662016),
        dec: Angle.Degrees(+53.30744684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82740"},
        {"Hipparcos Number", "HIP 47084"},
        {"Smithsonian Astrophysical Observation", "SAO 27304"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.92714239),
        dec: Angle.Degrees(+53.29464342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232259"},
        {"Hipparcos Number", "HIP 3440"},
        {"Smithsonian Astrophysical Observation", "SAO 21664"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.98456648),
        dec: Angle.Degrees(+53.29580135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47979"},
        {"Hipparcos Number", "HIP 32261"},
        {"Geneva Identification System", "GEN# +1.00047979"},
        {"Smithsonian Astrophysical Observation", "SAO 25916"},
        {"Wilson Evans Batten Catalogue", "WEB 6502"},
    },
    visualMagnitude: 6.28,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.04781966),
        dec: Angle.Degrees(+53.29642733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -200.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168293"},
        {"Hipparcos Number", "HIP 89515"},
        {"Smithsonian Astrophysical Observation", "SAO 30855"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.00373114),
        dec: Angle.Degrees(+53.29661812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221513"},
        {"Hipparcos Number", "HIP 116182"},
        {"Smithsonian Astrophysical Observation", "SAO 35523"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.10335900),
        dec: Angle.Degrees(+53.29741281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232155"},
        {"Hipparcos Number", "HIP 1529"},
        {"Smithsonian Astrophysical Observation", "SAO 21294"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.76222657),
        dec: Angle.Degrees(+53.29820057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47113",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7440 A"},
        {"Henry Draper", "HD 82791"},
        {"Hipparcos Number", "HIP 47113"},
        {"Smithsonian Astrophysical Observation", "SAO 27308"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.02070288),
        dec: Angle.Degrees(+53.29828751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78107"},
        {"Hipparcos Number", "HIP 44861"},
        {"Smithsonian Astrophysical Observation", "SAO 27133"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.10759682),
        dec: Angle.Degrees(+53.30072761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116799"},
        {"Hipparcos Number", "HIP 65462"},
        {"Smithsonian Astrophysical Observation", "SAO 28750"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.25560800),
        dec: Angle.Degrees(+53.30083605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169885"},
        {"Hipparcos Number", "HIP 90146"},
        {"Geneva Identification System", "GEN# +1.00169885"},
        {"Renson", "Renson 47580"},
        {"Smithsonian Astrophysical Observation", "SAO 30943"},
        {"Wilson Evans Batten Catalogue", "WEB 15414"},
    },
    visualMagnitude: 6.35,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.94981191),
        dec: Angle.Degrees(+53.30086319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22279",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3434 AB"},
        {"Henry Draper", "HD 30136"},
        {"Hipparcos Number", "HIP 22279"},
        {"Geneva Identification System", "GEN# +1.00030136"},
        {"Smithsonian Astrophysical Observation", "SAO 24830"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.95633941),
        dec: Angle.Degrees(+53.30127712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217920"},
        {"Hipparcos Number", "HIP 113856"},
        {"Smithsonian Astrophysical Observation", "SAO 35105"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.86414516),
        dec: Angle.Degrees(+53.30210682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11735"},
        {"Hipparcos Number", "HIP 9054"},
        {"Smithsonian Astrophysical Observation", "SAO 22772"},
    },
    visualMagnitude: 7.09,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.15650578),
        dec: Angle.Degrees(+53.30456225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235379"},
        {"Hipparcos Number", "HIP 102888"},
        {"Smithsonian Astrophysical Observation", "SAO 32931"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.67200998),
        dec: Angle.Degrees(+53.30501667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233376"},
        {"Hipparcos Number", "HIP 35680"},
        {"Smithsonian Astrophysical Observation", "SAO 26296"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.43316834),
        dec: Angle.Degrees(+53.30520594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207417"},
        {"Hipparcos Number", "HIP 107560"},
        {"Smithsonian Astrophysical Observation", "SAO 33753"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.77232888),
        dec: Angle.Degrees(+53.30564412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117760"},
        {"Hipparcos Number", "HIP 65946"},
        {"Smithsonian Astrophysical Observation", "SAO 28781"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.79528486),
        dec: Angle.Degrees(+53.31035998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127029"},
        {"Hipparcos Number", "HIP 70674"},
        {"Geneva Identification System", "GEN# +1.00127029"},
        {"Smithsonian Astrophysical Observation", "SAO 29153"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.82774915),
        dec: Angle.Degrees(+53.31080217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 141.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235473"},
        {"Hipparcos Number", "HIP 105033"},
        {"Cincinnati Publication", "Ci 18 2765"},
        {"Smithsonian Astrophysical Observation", "SAO 33273"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.11831278),
        dec: Angle.Degrees(+53.31173574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -159.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -235.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57115",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57115"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.904,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.63208026),
        dec: Angle.Degrees(+53.31196836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -141.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123518"},
        {"Hipparcos Number", "HIP 68932"},
        {"Smithsonian Astrophysical Observation", "SAO 29009"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.67193099),
        dec: Angle.Degrees(+53.31219561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203319"},
        {"Hipparcos Number", "HIP 105299"},
        {"Geneva Identification System", "GEN# +1.00203319"},
        {"Smithsonian Astrophysical Observation", "SAO 33325"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.92017174),
        dec: Angle.Degrees(+53.31227671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225104"},
        {"Hipparcos Number", "HIP 280"},
        {"Geneva Identification System", "GEN# +1.00225104"},
        {"Smithsonian Astrophysical Observation", "SAO 21041"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.86626632),
        dec: Angle.Degrees(+53.31270092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134280"},
        {"Hipparcos Number", "HIP 73956"},
        {"Geneva Identification System", "GEN# +1.00134280"},
        {"Smithsonian Astrophysical Observation", "SAO 29409"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.71273759),
        dec: Angle.Degrees(+53.31584542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107466"},
        {"Hipparcos Number", "HIP 60225"},
        {"Geneva Identification System", "GEN# +1.00107466"},
        {"Smithsonian Astrophysical Observation", "SAO 28347"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.25220360),
        dec: Angle.Degrees(+53.31773586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233371"},
        {"Hipparcos Number", "HIP 35371"},
        {"Smithsonian Astrophysical Observation", "SAO 26265"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.59457783),
        dec: Angle.Degrees(+53.31874693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105320",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14876 AB"},
        {"Henry Draper", "HD 203379"},
        {"Hipparcos Number", "HIP 105320"},
        {"Celescope Catalog", "CEL 5298"},
        {"Geneva Identification System", "GEN# +1.00203379J"},
        {"Smithsonian Astrophysical Observation", "SAO 33332"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.97644395),
        dec: Angle.Degrees(+53.32211335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21028"},
        {"Hipparcos Number", "HIP 15986"},
        {"Geneva Identification System", "GEN# +1.00021028"},
        {"Smithsonian Astrophysical Observation", "SAO 24026"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.48180243),
        dec: Angle.Degrees(+53.32275469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138748"},
        {"Hipparcos Number", "HIP 76019"},
        {"Smithsonian Astrophysical Observation", "SAO 29558"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.90459728),
        dec: Angle.Degrees(+53.32488202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172943"},
        {"Hipparcos Number", "HIP 91528"},
        {"Smithsonian Astrophysical Observation", "SAO 31096"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.98105118),
        dec: Angle.Degrees(+53.32583720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27162",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4312 AB"},
        {"Henry Draper", "HD 37996"},
        {"Hipparcos Number", "HIP 27162"},
        {"Smithsonian Astrophysical Observation", "SAO 25355"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.36954252),
        dec: Angle.Degrees(+53.32719807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25348"},
        {"Hipparcos Number", "HIP 19008"},
        {"Geneva Identification System", "GEN# +1.00025348"},
        {"Smithsonian Astrophysical Observation", "SAO 24388"},
        {"Wilson Evans Batten Catalogue", "WEB 3654"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.09016788),
        dec: Angle.Degrees(+53.32905051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233563"},
        {"Hipparcos Number", "HIP 42689"},
        {"Smithsonian Astrophysical Observation", "SAO 26967"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.51512584),
        dec: Angle.Degrees(+53.33077657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76749"},
        {"Hipparcos Number", "HIP 44209"},
        {"Geneva Identification System", "GEN# +1.00076749"},
        {"Smithsonian Astrophysical Observation", "SAO 27078"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.07827969),
        dec: Angle.Degrees(+53.33108832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161054"},
        {"Hipparcos Number", "HIP 86485"},
        {"Smithsonian Astrophysical Observation", "SAO 30511"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.09685795),
        dec: Angle.Degrees(+53.33520839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86941"},
        {"Hipparcos Number", "HIP 49274"},
        {"Smithsonian Astrophysical Observation", "SAO 27497"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.87534565),
        dec: Angle.Degrees(+53.33531241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99238",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13435 AB"},
        {"Henry Draper", "HD 191687"},
        {"Hipparcos Number", "HIP 99238"},
        {"Smithsonian Astrophysical Observation", "SAO 32312"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.16905504),
        dec: Angle.Degrees(+53.33657129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222747"},
        {"Hipparcos Number", "HIP 116989"},
        {"Smithsonian Astrophysical Observation", "SAO 35697"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.76610291),
        dec: Angle.Degrees(+53.33881192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9604"},
        {"Hipparcos Number", "HIP 7399"},
        {"Celescope Catalog", "CEL 148"},
        {"Fundamental Katalog 5th Edition", "FK5 2102"},
        {"Geneva Identification System", "GEN# +1.00009604"},
        {"Smithsonian Astrophysical Observation", "SAO 22414"},
    },
    visualMagnitude: 6.86,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.85059780),
        dec: Angle.Degrees(+53.34557619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232452"},
        {"Hipparcos Number", "HIP 7002"},
        {"Smithsonian Astrophysical Observation", "SAO 22337"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.53033632),
        dec: Angle.Degrees(+53.34787643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234539"},
        {"Hipparcos Number", "HIP 88221"},
        {"Smithsonian Astrophysical Observation", "SAO 30700"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.24158264),
        dec: Angle.Degrees(+53.34802959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157977"},
        {"Hipparcos Number", "HIP 85107"},
        {"Smithsonian Astrophysical Observation", "SAO 30367"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.90315690),
        dec: Angle.Degrees(+53.34933832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35938"},
        {"Hipparcos Number", "HIP 25858"},
        {"Smithsonian Astrophysical Observation", "SAO 25227"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.79974976),
        dec: Angle.Degrees(+53.35080268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43175",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43175"},
    },
    visualMagnitude: 9.69,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.91359655),
        dec: Angle.Degrees(+53.35478523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25878"},
        {"Hipparcos Number", "HIP 19340"},
        {"Geneva Identification System", "GEN# +1.00025878"},
        {"Smithsonian Astrophysical Observation", "SAO 24431"},
        {"Wilson Evans Batten Catalogue", "WEB 3713"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.826,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.16144715),
        dec: Angle.Degrees(+53.36093735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204117"},
        {"Hipparcos Number", "HIP 105706"},
        {"Geneva Identification System", "GEN# +1.00204117"},
        {"Renson", "Renson 56850"},
        {"Smithsonian Astrophysical Observation", "SAO 33403"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.15266896),
        dec: Angle.Degrees(+53.36344903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83508"},
        {"Hipparcos Number", "HIP 47475"},
        {"Smithsonian Astrophysical Observation", "SAO 27334"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.16973128),
        dec: Angle.Degrees(+53.36490991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30339"},
        {"Hipparcos Number", "HIP 22429"},
        {"Geneva Identification System", "GEN# +1.00030339"},
        {"Smithsonian Astrophysical Observation", "SAO 24853"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.38869441),
        dec: Angle.Degrees(+53.36586160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165863"},
        {"Hipparcos Number", "HIP 88572"},
        {"Geneva Identification System", "GEN# +1.00165863"},
        {"Smithsonian Astrophysical Observation", "SAO 30738"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.27398320),
        dec: Angle.Degrees(+53.36632837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 95.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195505"},
        {"Hipparcos Number", "HIP 101085"},
        {"Smithsonian Astrophysical Observation", "SAO 32625"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.36422063),
        dec: Angle.Degrees(+53.36679654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181276"},
        {"Hipparcos Number", "HIP 94779"},
        {"Fundamental Katalog 5th Edition", "FK5 726"},
        {"Geneva Identification System", "GEN# +1.00181276"},
        {"Smithsonian Astrophysical Observation", "SAO 31537"},
        {"Wilson Evans Batten Catalogue", "WEB 16539"},
    },
    visualMagnitude: 3.80,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.27545794),
        dec: Angle.Degrees(+53.36816064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 122.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110581",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110581"},
    },
    visualMagnitude: 10.31,
    bvColour: 1.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.03251727),
        dec: Angle.Degrees(+53.36822955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97370"},
        {"Hipparcos Number", "HIP 54793"},
        {"Geneva Identification System", "GEN# +1.00097370"},
        {"Smithsonian Astrophysical Observation", "SAO 27954"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.27040281),
        dec: Angle.Degrees(+53.37152028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124215"},
        {"Hipparcos Number", "HIP 69254"},
        {"Smithsonian Astrophysical Observation", "SAO 29030"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.66279606),
        dec: Angle.Degrees(+53.37198495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65120"},
        {"Hipparcos Number", "HIP 39092"},
        {"Smithsonian Astrophysical Observation", "SAO 26607"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.95997370),
        dec: Angle.Degrees(+53.37307204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116148",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116148"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.99672426),
        dec: Angle.Degrees(+53.37393709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215607"},
        {"Hipparcos Number", "HIP 112361"},
        {"Smithsonian Astrophysical Observation", "SAO 34772"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.38463710),
        dec: Angle.Degrees(+53.37461972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235088"},
        {"Hipparcos Number", "HIP 98668"},
        {"Smithsonian Astrophysical Observation", "SAO 32225"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.948,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.61358982),
        dec: Angle.Degrees(+53.37646395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 166.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 144.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205950"},
        {"Hipparcos Number", "HIP 106726"},
        {"Renson", "Renson 57350"},
        {"Smithsonian Astrophysical Observation", "SAO 33578"},
    },
    visualMagnitude: 7.82,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.27743325),
        dec: Angle.Degrees(+53.37676243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232722"},
        {"Hipparcos Number", "HIP 13404"},
        {"Smithsonian Astrophysical Observation", "SAO 23670"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.948,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.13465738),
        dec: Angle.Degrees(+53.37735180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203502"},
        {"Hipparcos Number", "HIP 105381"},
        {"Smithsonian Astrophysical Observation", "SAO 33340"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.19014994),
        dec: Angle.Degrees(+53.37822463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215869"},
        {"Hipparcos Number", "HIP 112500"},
        {"Smithsonian Astrophysical Observation", "SAO 34818"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.82874074),
        dec: Angle.Degrees(+53.38184569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61184",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61184"},
    },
    visualMagnitude: 10.63,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.05145492),
        dec: Angle.Degrees(+53.38240076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54094",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54094"},
    },
    visualMagnitude: 10.02,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.02979212),
        dec: Angle.Degrees(+53.38248652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -171.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132406"},
        {"Hipparcos Number", "HIP 73146"},
        {"Cincinnati Publication", "Ci 18 1987"},
        {"Geneva Identification System", "GEN# +1.00132406"},
        {"Smithsonian Astrophysical Observation", "SAO 29349"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.22777221),
        dec: Angle.Degrees(+53.38285032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -281.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118113"},
        {"Hipparcos Number", "HIP 66154"},
        {"Smithsonian Astrophysical Observation", "SAO 28800"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.40649499),
        dec: Angle.Degrees(+53.38367339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51999"},
        {"Hipparcos Number", "HIP 33931"},
        {"Smithsonian Astrophysical Observation", "SAO 26110"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.61767592),
        dec: Angle.Degrees(+53.38377412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37867",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37867"},
    },
    visualMagnitude: 12.10,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.43267853),
        dec: Angle.Degrees(+53.38671575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -232.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -632.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2308",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 393 A"},
        {"Henry Draper", "HD 2536"},
        {"Hipparcos Number", "HIP 2308"},
        {"Smithsonian Astrophysical Observation", "SAO 21436"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.36397795),
        dec: Angle.Degrees(+53.38694394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49986"},
        {"Hipparcos Number", "HIP 33153"},
        {"Smithsonian Astrophysical Observation", "SAO 26028"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.53348853),
        dec: Angle.Degrees(+53.38794192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76904",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76904"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.54833336),
        dec: Angle.Degrees(+53.38799484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233978"},
        {"Hipparcos Number", "HIP 62259"},
        {"Smithsonian Astrophysical Observation", "SAO 28507"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.37791991),
        dec: Angle.Degrees(+53.38993586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46175",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7347 AB"},
        {"Henry Draper", "HD 80982"},
        {"Hipparcos Number", "HIP 46175"},
        {"Geneva Identification System", "GEN# +1.00080982J"},
        {"Smithsonian Astrophysical Observation", "SAO 27245"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.23866543),
        dec: Angle.Degrees(+53.39022030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181594"},
        {"Hipparcos Number", "HIP 94872"},
        {"Geneva Identification System", "GEN# +1.00181594"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.59656588),
        dec: Angle.Degrees(+53.39330742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105584"},
        {"Hipparcos Number", "HIP 59258"},
        {"Geneva Identification System", "GEN# +1.00105584"},
        {"Smithsonian Astrophysical Observation", "SAO 28262"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.33548592),
        dec: Angle.Degrees(+53.39476878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178207"},
        {"Hipparcos Number", "HIP 93713"},
        {"Geneva Identification System", "GEN# +1.00178207"},
        {"Smithsonian Astrophysical Observation", "SAO 31371"},
        {"Wilson Evans Batten Catalogue", "WEB 16283"},
    },
    visualMagnitude: 5.40,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.22987335),
        dec: Angle.Degrees(+53.39660317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69266",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69266"},
    },
    visualMagnitude: 10.05,
    bvColour: 1.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.70362892),
        dec: Angle.Degrees(+53.39693528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58496",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8378 AB"},
        {"Henry Draper", "HD 104148"},
        {"Hipparcos Number", "HIP 58496"},
        {"Geneva Identification System", "GEN# +1.00104148J"},
        {"Smithsonian Astrophysical Observation", "SAO 28210"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.95307135),
        dec: Angle.Degrees(+53.39776053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47355"},
        {"Hipparcos Number", "HIP 31989"},
        {"Fundamental Katalog 5th Edition", "FK5 4609"},
        {"Geneva Identification System", "GEN# +1.00047355"},
        {"Smithsonian Astrophysical Observation", "SAO 25878"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.26787608),
        dec: Angle.Degrees(+53.39846163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235083"},
        {"Hipparcos Number", "HIP 98581"},
        {"Geneva Identification System", "GEN# +1.00235083"},
        {"Smithsonian Astrophysical Observation", "SAO 32210"},
    },
    visualMagnitude: 10.19,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.36788718),
        dec: Angle.Degrees(+53.39881796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73017"},
        {"Hipparcos Number", "HIP 42372"},
        {"Geneva Identification System", "GEN# +1.00073017"},
        {"Smithsonian Astrophysical Observation", "SAO 26935"},
        {"Wilson Evans Batten Catalogue", "WEB 8144"},
    },
    visualMagnitude: 5.66,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.59274761),
        dec: Angle.Degrees(+53.40157520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174432"},
        {"Hipparcos Number", "HIP 92214"},
        {"Smithsonian Astrophysical Observation", "SAO 31174"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.90469946),
        dec: Angle.Degrees(+53.40172076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232674"},
        {"Hipparcos Number", "HIP 11960"},
        {"Smithsonian Astrophysical Observation", "SAO 23438"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.58092514),
        dec: Angle.Degrees(+53.40542346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100505",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13795 C"},
        {"Henry Draper", "HD 235207"},
        {"Hipparcos Number", "HIP 100505"},
        {"Smithsonian Astrophysical Observation", "SAO 32515"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.70043492),
        dec: Angle.Degrees(+53.40731278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169354"},
        {"Hipparcos Number", "HIP 89957"},
        {"Geneva Identification System", "GEN# +1.00169354"},
        {"Smithsonian Astrophysical Observation", "SAO 30914"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.31283866),
        dec: Angle.Degrees(+53.40819000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220616"},
        {"Hipparcos Number", "HIP 115576"},
        {"Smithsonian Astrophysical Observation", "SAO 35394"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.16829978),
        dec: Angle.Degrees(+53.41176386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234512"},
        {"Hipparcos Number", "HIP 87528"},
        {"Smithsonian Astrophysical Observation", "SAO 30622"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.23017186),
        dec: Angle.Degrees(+53.41386386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100507",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13795 AB"},
        {"Henry Draper", "HD 194354"},
        {"Hipparcos Number", "HIP 100507"},
        {"Smithsonian Astrophysical Observation", "SAO 32516"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.70641633),
        dec: Angle.Degrees(+53.41745778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59431",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8450 B"},
        {"Henry Draper", "HD 105963B"},
        {"Hipparcos Number", "HIP 59431"},
        {"Smithsonian Astrophysical Observation", "SAO 28286"},
        {"Wilson Evans Batten Catalogue", "WEB 10566"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.86232767),
        dec: Angle.Degrees(+53.41904898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -175.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -137.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157681"},
        {"Hipparcos Number", "HIP 84950"},
        {"Fundamental Katalog 5th Edition", "FK5 3381"},
        {"Geneva Identification System", "GEN# +1.00157681"},
        {"Smithsonian Astrophysical Observation", "SAO 30354"},
        {"Wilson Evans Batten Catalogue", "WEB 14348"},
    },
    visualMagnitude: 5.69,
    bvColour: 1.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.43895966),
        dec: Angle.Degrees(+53.42042212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59432",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8450 A"},
        {"Henry Draper", "HD 105963"},
        {"Hipparcos Number", "HIP 59432"},
        {"Geneva Identification System", "GEN# +1.00105963"},
        {"Smithsonian Astrophysical Observation", "SAO 28287"},
        {"Wilson Evans Batten Catalogue", "WEB 10565"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.86635655),
        dec: Angle.Degrees(+53.42182050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -164.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35741"},
        {"Hipparcos Number", "HIP 25749"},
        {"Geneva Identification System", "GEN# +1.00035741"},
        {"Smithsonian Astrophysical Observation", "SAO 25217"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.47167537),
        dec: Angle.Degrees(+53.43274127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139320"},
        {"Hipparcos Number", "HIP 76295"},
        {"Geneva Identification System", "GEN# +1.00139320"},
        {"Smithsonian Astrophysical Observation", "SAO 29581"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.78204530),
        dec: Angle.Degrees(+53.43308229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106478"},
        {"Hipparcos Number", "HIP 59708"},
        {"Fundamental Katalog 5th Edition", "FK5 1314"},
        {"Geneva Identification System", "GEN# +1.00106478"},
        {"Smithsonian Astrophysical Observation", "SAO 28309"},
        {"Wilson Evans Batten Catalogue", "WEB 10609"},
    },
    visualMagnitude: 6.18,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.68095986),
        dec: Angle.Degrees(+53.43467088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190715"},
        {"Hipparcos Number", "HIP 98787"},
        {"Smithsonian Astrophysical Observation", "SAO 32249"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.94345845),
        dec: Angle.Degrees(+53.43503671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38794"},
        {"Hipparcos Number", "HIP 27653"},
        {"Smithsonian Astrophysical Observation", "SAO 25414"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.82523980),
        dec: Angle.Degrees(+53.43662228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62938",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62938"},
    },
    visualMagnitude: 10.64,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.46872364),
        dec: Angle.Degrees(+53.43838996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233299"},
        {"Hipparcos Number", "HIP 33340"},
        {"Smithsonian Astrophysical Observation", "SAO 26043"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.00941240),
        dec: Angle.Degrees(+53.44010012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129207"},
        {"Hipparcos Number", "HIP 71656"},
        {"Geneva Identification System", "GEN# +1.00129207"},
        {"Smithsonian Astrophysical Observation", "SAO 29235"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.85137514),
        dec: Angle.Degrees(+53.44014071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7780",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7780"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.03409782),
        dec: Angle.Degrees(+53.44062801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28051"},
        {"Hipparcos Number", "HIP 20878"},
        {"Smithsonian Astrophysical Observation", "SAO 24633"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.11192183),
        dec: Angle.Degrees(+53.44151665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233999"},
        {"Hipparcos Number", "HIP 63304"},
        {"Smithsonian Astrophysical Observation", "SAO 28584"},
    },
    visualMagnitude: 9.70,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.59943590),
        dec: Angle.Degrees(+53.44192924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113862"},
        {"Hipparcos Number", "HIP 63912"},
        {"Geneva Identification System", "GEN# +1.00113862"},
        {"Smithsonian Astrophysical Observation", "SAO 28631"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.45266816),
        dec: Angle.Degrees(+53.44197121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164180"},
        {"Hipparcos Number", "HIP 87871"},
        {"Smithsonian Astrophysical Observation", "SAO 30656"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.24497470),
        dec: Angle.Degrees(+53.44377768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161318"},
        {"Hipparcos Number", "HIP 86622"},
        {"Geneva Identification System", "GEN# +1.00161318"},
        {"Smithsonian Astrophysical Observation", "SAO 30524"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.49329419),
        dec: Angle.Degrees(+53.44581256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60523",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60523"},
    },
    visualMagnitude: 10.77,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.10636368),
        dec: Angle.Degrees(+53.44832603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -133.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125120"},
        {"Hipparcos Number", "HIP 69692"},
        {"Smithsonian Astrophysical Observation", "SAO 29065"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.786,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.98419693),
        dec: Angle.Degrees(+53.44879010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80619",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80619"},
    },
    visualMagnitude: 10.34,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.92929236),
        dec: Angle.Degrees(+53.44946963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33267"},
        {"Hipparcos Number", "HIP 24211"},
        {"Geneva Identification System", "GEN# +1.00033267"},
        {"Smithsonian Astrophysical Observation", "SAO 25067"},
        {"Wilson Evans Batten Catalogue", "WEB 4702"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.98179052),
        dec: Angle.Degrees(+53.45210061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23229",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3573 AB"},
        {"Henry Draper", "HD 31578"},
        {"Hipparcos Number", "HIP 23229"},
        {"Smithsonian Astrophysical Observation", "SAO 24944"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.97411014),
        dec: Angle.Degrees(+53.45211703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43905"},
        {"Hipparcos Number", "HIP 30247"},
        {"Fundamental Katalog 5th Edition", "FK5 2484"},
        {"Geneva Identification System", "GEN# +1.00043905"},
        {"Smithsonian Astrophysical Observation", "SAO 25681"},
        {"Wilson Evans Batten Catalogue", "WEB 6014"},
    },
    visualMagnitude: 5.34,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.44211705),
        dec: Angle.Degrees(+53.45239515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222063"},
        {"Hipparcos Number", "HIP 116541"},
        {"Smithsonian Astrophysical Observation", "SAO 35600"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.27664974),
        dec: Angle.Degrees(+53.45278737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181593"},
        {"Hipparcos Number", "HIP 94865"},
        {"Geneva Identification System", "GEN# +1.00181593"},
        {"Smithsonian Astrophysical Observation", "SAO 31555"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.56782986),
        dec: Angle.Degrees(+53.45687854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71090"},
        {"Hipparcos Number", "HIP 41507"},
        {"Smithsonian Astrophysical Observation", "SAO 26849"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.98029973),
        dec: Angle.Degrees(+53.45727540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39430"},
        {"Hipparcos Number", "HIP 28023"},
        {"Smithsonian Astrophysical Observation", "SAO 25454"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.778,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.90646324),
        dec: Angle.Degrees(+53.45984246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33941"},
        {"Hipparcos Number", "HIP 24610"},
        {"Smithsonian Astrophysical Observation", "SAO 25104"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.17882841),
        dec: Angle.Degrees(+53.46465732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13892"},
        {"Hipparcos Number", "HIP 10636"},
        {"Smithsonian Astrophysical Observation", "SAO 23121"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.23051418),
        dec: Angle.Degrees(+53.46645713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196230"},
        {"Hipparcos Number", "HIP 101449"},
        {"Geneva Identification System", "GEN# +1.00196230"},
        {"Smithsonian Astrophysical Observation", "SAO 32690"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.41012854),
        dec: Angle.Degrees(+53.46811486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235631"},
        {"Hipparcos Number", "HIP 107709"},
        {"Smithsonian Astrophysical Observation", "SAO 33779"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.27939629),
        dec: Angle.Degrees(+53.46971960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3320"},
        {"Hipparcos Number", "HIP 2890"},
        {"Smithsonian Astrophysical Observation", "SAO 21559"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.15953864),
        dec: Angle.Degrees(+53.47214530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8273"},
        {"Hipparcos Number", "HIP 6465"},
        {"Smithsonian Astrophysical Observation", "SAO 22227"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.79218323),
        dec: Angle.Degrees(+53.47285486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117741",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117741"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.18331734),
        dec: Angle.Degrees(+53.47314448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21730",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3358 ABC"},
        {"Henry Draper", "HD 29316"},
        {"Hipparcos Number", "HIP 21730"},
        {"Geneva Identification System", "GEN# +1.00029316J"},
        {"Smithsonian Astrophysical Observation", "SAO 24744"},
        {"Wilson Evans Batten Catalogue", "WEB 4177"},
    },
    visualMagnitude: 5.36,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.99180673),
        dec: Angle.Degrees(+53.47323647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233666"},
        {"Hipparcos Number", "HIP 47599"},
        {"Geneva Identification System", "GEN# +1.00233666"},
        {"Smithsonian Astrophysical Observation", "SAO 27352"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.58108826),
        dec: Angle.Degrees(+53.47400115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46591"},
        {"Hipparcos Number", "HIP 31640"},
        {"Geneva Identification System", "GEN# +1.00046591"},
        {"Smithsonian Astrophysical Observation", "SAO 25839"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.826,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.31393069),
        dec: Angle.Degrees(+53.47544649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234101"},
        {"Hipparcos Number", "HIP 68553"},
        {"Smithsonian Astrophysical Observation", "SAO 28981"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.50161426),
        dec: Angle.Degrees(+53.47851352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1744"},
        {"Hipparcos Number", "HIP 1735"},
        {"Smithsonian Astrophysical Observation", "SAO 21327"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.48620364),
        dec: Angle.Degrees(+53.48088111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37394"},
        {"Hipparcos Number", "HIP 26779"},
        {"Cincinnati Publication", "Ci 20 341"},
        {"Geneva Identification System", "GEN# +1.00037394"},
        {"Smithsonian Astrophysical Observation", "SAO 25319"},
        {"Wilson Evans Batten Catalogue", "WEB 5281"},
    },
    visualMagnitude: 6.21,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.33472092),
        dec: Angle.Degrees(+53.48233045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -523.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203281"},
        {"Hipparcos Number", "HIP 105278"},
        {"Smithsonian Astrophysical Observation", "SAO 33317"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.85973665),
        dec: Angle.Degrees(+53.48277161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24094"},
        {"Hipparcos Number", "HIP 18151"},
        {"Geneva Identification System", "GEN# +1.00024094"},
        {"Smithsonian Astrophysical Observation", "SAO 24271"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.20409464),
        dec: Angle.Degrees(+53.48367278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105057"},
        {"Hipparcos Number", "HIP 58995"},
        {"Fundamental Katalog 5th Edition", "FK5 5068"},
        {"Geneva Identification System", "GEN# +1.00105057"},
        {"Smithsonian Astrophysical Observation", "SAO 28244"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.43919291),
        dec: Angle.Degrees(+53.48373773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88388"},
        {"Hipparcos Number", "HIP 50037"},
        {"Smithsonian Astrophysical Observation", "SAO 27557"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.23877124),
        dec: Angle.Degrees(+53.48415007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233225"},
        {"Hipparcos Number", "HIP 29795"},
        {"Smithsonian Astrophysical Observation", "SAO 25644"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.09770736),
        dec: Angle.Degrees(+53.48512255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14063"},
        {"Hipparcos Number", "HIP 10748"},
        {"Smithsonian Astrophysical Observation", "SAO 23160"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.56896530),
        dec: Angle.Degrees(+53.48585720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88327"},
        {"Hipparcos Number", "HIP 50004"},
        {"Geneva Identification System", "GEN# +1.00088327"},
        {"Smithsonian Astrophysical Observation", "SAO 27552"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.11987262),
        dec: Angle.Degrees(+53.48622409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20661"},
        {"Hipparcos Number", "HIP 15672"},
        {"Smithsonian Astrophysical Observation", "SAO 23978"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.47521723),
        dec: Angle.Degrees(+53.48781591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 152.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3192"},
        {"Hipparcos Number", "HIP 2795"},
        {"Smithsonian Astrophysical Observation", "SAO 21543"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.89705330),
        dec: Angle.Degrees(+53.48890665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79247"},
        {"Hipparcos Number", "HIP 45397"},
        {"Smithsonian Astrophysical Observation", "SAO 27183"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.936,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.77330306),
        dec: Angle.Degrees(+53.48975427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233153"},
        {"Hipparcos Number", "HIP 26801"},
        {"Cincinnati Publication", "Ci 20 342"},
        {"Geneva Identification System", "GEN# +1.00233153"},
        {"Smithsonian Astrophysical Observation", "SAO 25321"},
        {"Wilson Evans Batten Catalogue", "WEB 5285"},
    },
    visualMagnitude: 9.78,
    bvColour: 1.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.37802824),
        dec: Angle.Degrees(+53.49105798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -517.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27609"},
        {"Hipparcos Number", "HIP 20541"},
        {"Geneva Identification System", "GEN# +1.00027609"},
        {"Smithsonian Astrophysical Observation", "SAO 24585"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.02249672),
        dec: Angle.Degrees(+53.49539967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89194"},
        {"Hipparcos Number", "HIP 50499"},
        {"Smithsonian Astrophysical Observation", "SAO 27597"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.68329722),
        dec: Angle.Degrees(+53.49589778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81342",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81342"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.19016526),
        dec: Angle.Degrees(+53.49659681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224056"},
        {"Hipparcos Number", "HIP 117892"},
        {"Smithsonian Astrophysical Observation", "SAO 35882"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.70468633),
        dec: Angle.Degrees(+53.49728043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83394"},
        {"Hipparcos Number", "HIP 47437"},
        {"Smithsonian Astrophysical Observation", "SAO 27331"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.99625126),
        dec: Angle.Degrees(+53.49728305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -131.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91311"},
        {"Hipparcos Number", "HIP 51697"},
        {"Geneva Identification System", "GEN# +1.00091311"},
        {"Smithsonian Astrophysical Observation", "SAO 27682"},
        {"Wilson Evans Batten Catalogue", "WEB 9427"},
    },
    visualMagnitude: 6.52,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.43251255),
        dec: Angle.Degrees(+53.49745429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5251",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 915 A"},
        {"Henry Draper", "HD 6540"},
        {"Hipparcos Number", "HIP 5251"},
        {"Smithsonian Astrophysical Observation", "SAO 22021"},
        {"Wilson Evans Batten Catalogue", "WEB 1107"},
    },
    visualMagnitude: 6.31,
    bvColour: 1.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.78933996),
        dec: Angle.Degrees(+53.49819318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15071"},
        {"Hipparcos Number", "HIP 11426"},
        {"Geneva Identification System", "GEN# +1.00015071"},
        {"Smithsonian Astrophysical Observation", "SAO 23345"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.84609143),
        dec: Angle.Degrees(+53.50007525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167103"},
        {"Hipparcos Number", "HIP 89074"},
        {"Geneva Identification System", "GEN# +1.00167103"},
        {"Smithsonian Astrophysical Observation", "SAO 30788"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.68827267),
        dec: Angle.Degrees(+53.50032870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232451"},
        {"Hipparcos Number", "HIP 6986"},
        {"Smithsonian Astrophysical Observation", "SAO 22333"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.48047926),
        dec: Angle.Degrees(+53.50259176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32519"},
        {"Hipparcos Number", "HIP 23788"},
        {"Smithsonian Astrophysical Observation", "SAO 25016"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.67761153),
        dec: Angle.Degrees(+53.50321787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235169"},
        {"Hipparcos Number", "HIP 100049"},
        {"Smithsonian Astrophysical Observation", "SAO 32444"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.46985479),
        dec: Angle.Degrees(+53.50455336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233389"},
        {"Hipparcos Number", "HIP 36245"},
        {"Smithsonian Astrophysical Observation", "SAO 26349"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.95413525),
        dec: Angle.Degrees(+53.50474856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232596"},
        {"Hipparcos Number", "HIP 9792"},
        {"Smithsonian Astrophysical Observation", "SAO 22916"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.48396231),
        dec: Angle.Degrees(+53.50599727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14328",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2324 AP"},
        {"Henry Draper", "HD 18925"},
        {"Henry Draper 2", "HD 18926"},
        {"Hipparcos Number", "HIP 14328"},
        {"Fundamental Katalog 5th Edition", "FK5 108"},
        {"Geneva Identification System", "GEN# +1.00018925"},
        {"Smithsonian Astrophysical Observation", "SAO 23789"},
        {"Wilson Evans Batten Catalogue", "WEB 2801"},
    },
    visualMagnitude: 2.91,
    bvColour: 0.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.19912598),
        dec: Angle.Degrees(+53.50645031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234182"},
        {"Hipparcos Number", "HIP 72457"},
        {"Smithsonian Astrophysical Observation", "SAO 29292"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.25246381),
        dec: Angle.Degrees(+53.50827553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207118"},
        {"Hipparcos Number", "HIP 107402"},
        {"Smithsonian Astrophysical Observation", "SAO 33724"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.31053695),
        dec: Angle.Degrees(+53.51012906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145046"},
        {"Hipparcos Number", "HIP 78892"},
        {"Geneva Identification System", "GEN# +1.00145046"},
        {"Smithsonian Astrophysical Observation", "SAO 29800"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.58040937),
        dec: Angle.Degrees(+53.51526746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26985"},
        {"Hipparcos Number", "HIP 20108"},
        {"Geneva Identification System", "GEN# +1.00026985"},
        {"Smithsonian Astrophysical Observation", "SAO 24534"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.66600467),
        dec: Angle.Degrees(+53.51537872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37535"},
        {"Hipparcos Number", "HIP 26871"},
        {"Smithsonian Astrophysical Observation", "SAO 25326"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.58066394),
        dec: Angle.Degrees(+53.51556286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46703"},
        {"Hipparcos Number", "HIP 31695"},
        {"Geneva Identification System", "GEN# +1.00046703"},
        {"Smithsonian Astrophysical Observation", "SAO 25845"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.46843765),
        dec: Angle.Degrees(+53.51721948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126138"},
        {"Hipparcos Number", "HIP 70221"},
        {"Geneva Identification System", "GEN# +1.00126138"},
        {"Smithsonian Astrophysical Observation", "SAO 29117"},
    },
    visualMagnitude: 7.55,
    bvColour: -0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.49943621),
        dec: Angle.Degrees(+53.52117091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12686",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2059 A"},
        {"Henry Draper", "HD 16735"},
        {"Hipparcos Number", "HIP 12686"},
        {"Geneva Identification System", "GEN# +1.00016735"},
        {"Smithsonian Astrophysical Observation", "SAO 23556"},
        {"Wilson Evans Batten Catalogue", "WEB 2579"},
    },
    visualMagnitude: 5.85,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.74778071),
        dec: Angle.Degrees(+53.52618220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76922"},
        {"Hipparcos Number", "HIP 44300"},
        {"Geneva Identification System", "GEN# +1.00076922"},
        {"Smithsonian Astrophysical Observation", "SAO 27087"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.33988827),
        dec: Angle.Degrees(+53.52629010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 277"},
        {"Hipparcos Number", "HIP 623"},
        {"Geneva Identification System", "GEN# +1.00000277"},
        {"Smithsonian Astrophysical Observation", "SAO 21107"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.90593260),
        dec: Angle.Degrees(+53.52653764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232118"},
        {"Hipparcos Number", "HIP 793"},
        {"Smithsonian Astrophysical Observation", "SAO 21148"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.45821543),
        dec: Angle.Degrees(+53.52665750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232828"},
        {"Hipparcos Number", "HIP 17410"},
        {"Smithsonian Astrophysical Observation", "SAO 24183"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.94768611),
        dec: Angle.Degrees(+53.52765316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111115",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16008 AB"},
        {"Henry Draper", "HD 213495"},
        {"Hipparcos Number", "HIP 111115"},
        {"Smithsonian Astrophysical Observation", "SAO 34534"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.64820811),
        dec: Angle.Degrees(+53.52868074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147364"},
        {"Hipparcos Number", "HIP 79929"},
        {"Smithsonian Astrophysical Observation", "SAO 29883"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.71470844),
        dec: Angle.Degrees(+53.53351896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89305"},
        {"Hipparcos Number", "HIP 50553"},
        {"Geneva Identification System", "GEN# +1.00089305"},
        {"Smithsonian Astrophysical Observation", "SAO 27602"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.89306003),
        dec: Angle.Degrees(+53.53493790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -115.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234024"},
        {"Hipparcos Number", "HIP 64686"},
        {"Geneva Identification System", "GEN# +1.00234024"},
        {"Smithsonian Astrophysical Observation", "SAO 28693"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.86573585),
        dec: Angle.Degrees(+53.53662051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40649"},
        {"Hipparcos Number", "HIP 28664"},
        {"Geneva Identification System", "GEN# +1.00040649"},
        {"Smithsonian Astrophysical Observation", "SAO 25532"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.78841272),
        dec: Angle.Degrees(+53.54140319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148016"},
        {"Hipparcos Number", "HIP 80211"},
        {"Geneva Identification System", "GEN# +1.00148016"},
        {"Smithsonian Astrophysical Observation", "SAO 29918"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.61987540),
        dec: Angle.Degrees(+53.54183106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233831"},
        {"Hipparcos Number", "HIP 55809"},
        {"Smithsonian Astrophysical Observation", "SAO 28019"},
    },
    visualMagnitude: 10.50,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.54806107),
        dec: Angle.Degrees(+53.54426639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185263"},
        {"Hipparcos Number", "HIP 96359"},
        {"Geneva Identification System", "GEN# +1.00185263"},
        {"Smithsonian Astrophysical Observation", "SAO 31799"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.88248500),
        dec: Angle.Degrees(+53.54576599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194668"},
        {"Hipparcos Number", "HIP 100651"},
        {"Celescope Catalog", "CEL 5055"},
        {"Geneva Identification System", "GEN# +1.00194668"},
        {"Smithsonian Astrophysical Observation", "SAO 32534"},
        {"Wilson Evans Batten Catalogue", "WEB 18190"},
    },
    visualMagnitude: 6.49,
    bvColour: -0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.13481758),
        dec: Angle.Degrees(+53.55190298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103829"},
        {"Hipparcos Number", "HIP 58318"},
        {"Geneva Identification System", "GEN# +1.00103829"},
        {"Smithsonian Astrophysical Observation", "SAO 28203"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.37987048),
        dec: Angle.Degrees(+53.55421847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39550"},
        {"Hipparcos Number", "HIP 28096"},
        {"Geneva Identification System", "GEN# +1.00039550"},
        {"Smithsonian Astrophysical Observation", "SAO 25468"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.08514723),
        dec: Angle.Degrees(+53.55425440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234218"},
        {"Hipparcos Number", "HIP 74346"},
        {"Smithsonian Astrophysical Observation", "SAO 29438"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.91121250),
        dec: Angle.Degrees(+53.55501045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -138.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 129.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66730"},
        {"Hipparcos Number", "HIP 39752"},
        {"Geneva Identification System", "GEN# +1.00066730"},
        {"Smithsonian Astrophysical Observation", "SAO 26677"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.87473743),
        dec: Angle.Degrees(+53.55664262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24386"},
        {"Hipparcos Number", "HIP 18351"},
        {"Geneva Identification System", "GEN# +1.00024386"},
        {"Smithsonian Astrophysical Observation", "SAO 24296"},
        {"Wilson Evans Batten Catalogue", "WEB 3543"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.84616381),
        dec: Angle.Degrees(+53.55752454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167535"},
        {"Hipparcos Number", "HIP 89248"},
        {"Geneva Identification System", "GEN# +1.00167535"},
        {"Smithsonian Astrophysical Observation", "SAO 30812"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.18111203),
        dec: Angle.Degrees(+53.55764902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114171"},
        {"Hipparcos Number", "HIP 64098"},
        {"Geneva Identification System", "GEN# +1.00114171"},
        {"Smithsonian Astrophysical Observation", "SAO 28646"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.03118210),
        dec: Angle.Degrees(+53.56051280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120875"},
        {"Hipparcos Number", "HIP 67576"},
        {"Smithsonian Astrophysical Observation", "SAO 28902"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.70854553),
        dec: Angle.Degrees(+53.56051546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71779"},
        {"Hipparcos Number", "HIP 41832"},
        {"Geneva Identification System", "GEN# +1.00071779"},
        {"Smithsonian Astrophysical Observation", "SAO 26889"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.92072848),
        dec: Angle.Degrees(+53.56080784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10960",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10960"},
    },
    visualMagnitude: 10.31,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.30254204),
        dec: Angle.Degrees(+53.56094337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -274.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88609"},
        {"Hipparcos Number", "HIP 50173"},
        {"Geneva Identification System", "GEN# +1.00088609"},
        {"Smithsonian Astrophysical Observation", "SAO 27575"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.62075656),
        dec: Angle.Degrees(+53.56100786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18465",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18465"},
        {"Cincinnati Publication", "Ci 20 271"},
        {"Geneva Identification System", "GEN# +9.80175011"},
        {"Wilson Evans Batten Catalogue", "WEB 3559"},
    },
    visualMagnitude: 10.86,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.19623146),
        dec: Angle.Degrees(+53.56118489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 308.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -405.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201834"},
        {"Hipparcos Number", "HIP 104516"},
        {"Celescope Catalog", "CEL 5259"},
        {"Geneva Identification System", "GEN# +1.00201834"},
        {"Renson", "Renson 56290"},
        {"Smithsonian Astrophysical Observation", "SAO 33185"},
        {"Wilson Evans Batten Catalogue", "WEB 19022"},
    },
    visualMagnitude: 5.75,
    bvColour: -0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.56480272),
        dec: Angle.Degrees(+53.56310952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224611"},
        {"Hipparcos Number", "HIP 118259"},
        {"Smithsonian Astrophysical Observation", "SAO 35952"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.79974702),
        dec: Angle.Degrees(+53.56320489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7168"},
        {"Hipparcos Number", "HIP 5668"},
        {"Smithsonian Astrophysical Observation", "SAO 22092"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.21374573),
        dec: Angle.Degrees(+53.56403039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40829"},
        {"Hipparcos Number", "HIP 28755"},
        {"Smithsonian Astrophysical Observation", "SAO 25546"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.08364384),
        dec: Angle.Degrees(+53.56689594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37085"},
        {"Hipparcos Number", "HIP 26572"},
        {"Geneva Identification System", "GEN# +1.00037085"},
        {"Smithsonian Astrophysical Observation", "SAO 25299"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.73962997),
        dec: Angle.Degrees(+53.56959495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220732"},
        {"Hipparcos Number", "HIP 115656"},
        {"Geneva Identification System", "GEN# +1.00220732"},
        {"Smithsonian Astrophysical Observation", "SAO 35409"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.44151592),
        dec: Angle.Degrees(+53.57204125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100667"},
        {"Hipparcos Number", "HIP 56526"},
        {"Geneva Identification System", "GEN# +1.00100667"},
        {"Smithsonian Astrophysical Observation", "SAO 28065"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.85603760),
        dec: Angle.Degrees(+53.57392507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69682"},
        {"Hipparcos Number", "HIP 40878"},
        {"Geneva Identification System", "GEN# +1.00069682"},
        {"Renson", "Renson 19260"},
        {"Smithsonian Astrophysical Observation", "SAO 26788"},
        {"Wilson Evans Batten Catalogue", "WEB 7927"},
    },
    visualMagnitude: 6.50,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.12149726),
        dec: Angle.Degrees(+53.57435244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94397"},
        {"Hipparcos Number", "HIP 53358"},
        {"Smithsonian Astrophysical Observation", "SAO 27825"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.68261166),
        dec: Angle.Degrees(+53.57861325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232329"},
        {"Hipparcos Number", "HIP 4507"},
        {"Smithsonian Astrophysical Observation", "SAO 21879"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.43309155),
        dec: Angle.Degrees(+53.57875873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24639",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3845 B"},
        {"Henry Draper", "HD 233095"},
        {"Hipparcos Number", "HIP 24639"},
        {"Geneva Identification System", "GEN# +1.00034019B"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.30635194),
        dec: Angle.Degrees(+53.57880039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162131"},
        {"Hipparcos Number", "HIP 86982"},
        {"Smithsonian Astrophysical Observation", "SAO 30567"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.62627067),
        dec: Angle.Degrees(+53.57899083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122149"},
        {"Hipparcos Number", "HIP 68271"},
        {"Geneva Identification System", "GEN# +1.00122149"},
        {"Smithsonian Astrophysical Observation", "SAO 28953"},
        {"Wilson Evans Batten Catalogue", "WEB 11979"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.64912345),
        dec: Angle.Degrees(+53.57917773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206166"},
        {"Hipparcos Number", "HIP 106863"},
        {"Geneva Identification System", "GEN# +1.00206166"},
        {"Smithsonian Astrophysical Observation", "SAO 33618"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.65158934),
        dec: Angle.Degrees(+53.58027027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126675"},
        {"Hipparcos Number", "HIP 70499"},
        {"Geneva Identification System", "GEN# +1.00126675"},
        {"Smithsonian Astrophysical Observation", "SAO 29138"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.31561614),
        dec: Angle.Degrees(+53.58513121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234340"},
        {"Hipparcos Number", "HIP 81816"},
        {"Geneva Identification System", "GEN# +1.00234340"},
        {"Smithsonian Astrophysical Observation", "SAO 30061"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.66377954),
        dec: Angle.Degrees(+53.58520362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107323"},
        {"Hipparcos Number", "HIP 60158"},
        {"Smithsonian Astrophysical Observation", "SAO 28342"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.04795627),
        dec: Angle.Degrees(+53.58556350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24645",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3845 A"},
        {"Henry Draper", "HD 34019"},
        {"Hipparcos Number", "HIP 24645"},
        {"Geneva Identification System", "GEN# +1.00034019"},
        {"Smithsonian Astrophysical Observation", "SAO 25112"},
        {"Wilson Evans Batten Catalogue", "WEB 4768"},
    },
    visualMagnitude: 9.96,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.32370184),
        dec: Angle.Degrees(+53.58615854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91191"},
        {"Hipparcos Number", "HIP 51630"},
        {"Smithsonian Astrophysical Observation", "SAO 27677"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.21090166),
        dec: Angle.Degrees(+53.58685118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55155"},
        {"Hipparcos Number", "HIP 35027"},
        {"Geneva Identification System", "GEN# +1.00055155"},
        {"Smithsonian Astrophysical Observation", "SAO 26238"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.67670463),
        dec: Angle.Degrees(+53.58742871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48569",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48569"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.59143494),
        dec: Angle.Degrees(+53.58790616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233416"},
        {"Hipparcos Number", "HIP 36814"},
        {"Smithsonian Astrophysical Observation", "SAO 26410"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.57052972),
        dec: Angle.Degrees(+53.58888564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205397"},
        {"Hipparcos Number", "HIP 106416"},
        {"Geneva Identification System", "GEN# +1.00205397"},
        {"Smithsonian Astrophysical Observation", "SAO 33525"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.30367185),
        dec: Angle.Degrees(+53.59049103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35392"},
        {"Hipparcos Number", "HIP 25516"},
        {"Geneva Identification System", "GEN# +1.00035392"},
        {"Smithsonian Astrophysical Observation", "SAO 25201"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.85107004),
        dec: Angle.Degrees(+53.59107496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59670",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59670"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.54378841),
        dec: Angle.Degrees(+53.59124091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -310.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25551"},
        {"Hipparcos Number", "HIP 19135"},
        {"Geneva Identification System", "GEN# +1.00025551"},
        {"Smithsonian Astrophysical Observation", "SAO 24407"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.51806215),
        dec: Angle.Degrees(+53.59518873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100295",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13743 A"},
        {"Henry Draper", "HD 193944"},
        {"Hipparcos Number", "HIP 100295"},
        {"Geneva Identification System", "GEN# +1.00193944J"},
        {"Smithsonian Astrophysical Observation", "SAO 32491"},
        {"Wilson Evans Batten Catalogue", "WEB 18090"},
    },
    visualMagnitude: 6.23,
    bvColour: 1.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.12766031),
        dec: Angle.Degrees(+53.59568983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234202"},
        {"Hipparcos Number", "HIP 73548"},
        {"Smithsonian Astrophysical Observation", "SAO 29385"},
    },
    visualMagnitude: 9.86,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.47251265),
        dec: Angle.Degrees(+53.60032536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1778"},
        {"Hipparcos Number", "HIP 1762"},
        {"Geneva Identification System", "GEN# +1.00001778"},
        {"Smithsonian Astrophysical Observation", "SAO 21328"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.58182607),
        dec: Angle.Degrees(+53.60091962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232168"},
        {"Hipparcos Number", "HIP 1786"},
        {"Smithsonian Astrophysical Observation", "SAO 21333"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.67571663),
        dec: Angle.Degrees(+53.60552901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11697"},
        {"Hipparcos Number", "HIP 9024"},
        {"Smithsonian Astrophysical Observation", "SAO 22765"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.05513780),
        dec: Angle.Degrees(+53.60660824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112113"},
        {"Hipparcos Number", "HIP 62897"},
        {"Smithsonian Astrophysical Observation", "SAO 28549"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.35935006),
        dec: Angle.Degrees(+53.60721409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232525"},
        {"Hipparcos Number", "HIP 8242"},
        {"Celescope Catalog", "CEL 165"},
        {"Smithsonian Astrophysical Observation", "SAO 22607"},
        {"Wilson Evans Batten Catalogue", "WEB 1757"},
    },
    visualMagnitude: 8.84,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.53579010),
        dec: Angle.Degrees(+53.60774574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236009"},
        {"Hipparcos Number", "HIP 113463"},
        {"Smithsonian Astrophysical Observation", "SAO 35014"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.67594610),
        dec: Angle.Degrees(+53.61107279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26764"},
        {"Hipparcos Number", "HIP 19949"},
        {"Fundamental Katalog 5th Edition", "FK5 2310"},
        {"Geneva Identification System", "GEN# +1.00026764"},
        {"Smithsonian Astrophysical Observation", "SAO 24512"},
        {"Wilson Evans Batten Catalogue", "WEB 3807"},
    },
    visualMagnitude: 5.20,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.17960437),
        dec: Angle.Degrees(+53.61180318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236211"},
        {"Hipparcos Number", "HIP 117242"},
        {"Geneva Identification System", "GEN# +1.00236211"},
        {"Smithsonian Astrophysical Observation", "SAO 35748"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.59371785),
        dec: Angle.Degrees(+53.61266949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156481"},
        {"Hipparcos Number", "HIP 84358"},
        {"Smithsonian Astrophysical Observation", "SAO 30312"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.70043853),
        dec: Angle.Degrees(+53.61336939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233332"},
        {"Hipparcos Number", "HIP 34268"},
        {"Smithsonian Astrophysical Observation", "SAO 26148"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.55194200),
        dec: Angle.Degrees(+53.61694104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52755",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52755"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.80644069),
        dec: Angle.Degrees(+53.61779011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41965"},
        {"Hipparcos Number", "HIP 29335"},
        {"Smithsonian Astrophysical Observation", "SAO 25608"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.77135479),
        dec: Angle.Degrees(+53.61969084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234337"},
        {"Hipparcos Number", "HIP 81788"},
        {"Smithsonian Astrophysical Observation", "SAO 30056"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.57305474),
        dec: Angle.Degrees(+53.62196650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209992"},
        {"Hipparcos Number", "HIP 109096"},
        {"Geneva Identification System", "GEN# +1.00209992"},
        {"Smithsonian Astrophysical Observation", "SAO 34052"},
        {"Wilson Evans Batten Catalogue", "WEB 19616"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.49394752),
        dec: Angle.Degrees(+53.62336883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 981",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 148 AB"},
        {"Henry Draper", "HD 761"},
        {"Hipparcos Number", "HIP 981"},
        {"Geneva Identification System", "GEN# +1.00000761J"},
        {"Smithsonian Astrophysical Observation", "SAO 21202"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.03354264),
        dec: Angle.Degrees(+53.62391762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179093"},
        {"Hipparcos Number", "HIP 94006"},
        {"Geneva Identification System", "GEN# +1.00179093"},
        {"Smithsonian Astrophysical Observation", "SAO 31412"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.09287769),
        dec: Angle.Degrees(+53.62701847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131846"},
        {"Hipparcos Number", "HIP 72881"},
        {"Smithsonian Astrophysical Observation", "SAO 29327"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.44382054),
        dec: Angle.Degrees(+53.62744144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92387"},
        {"Hipparcos Number", "HIP 52294"},
        {"Geneva Identification System", "GEN# +1.00092387"},
        {"Smithsonian Astrophysical Observation", "SAO 27733"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.28005822),
        dec: Angle.Degrees(+53.62746368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114506"},
        {"Hipparcos Number", "HIP 64250"},
        {"Smithsonian Astrophysical Observation", "SAO 28660"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.745,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.53936474),
        dec: Angle.Degrees(+53.62778195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164986"},
        {"Hipparcos Number", "HIP 88212"},
        {"Smithsonian Astrophysical Observation", "SAO 30696"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.20752953),
        dec: Angle.Degrees(+53.62881174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12314"},
        {"Hipparcos Number", "HIP 9513"},
        {"Smithsonian Astrophysical Observation", "SAO 22860"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.59164933),
        dec: Angle.Degrees(+53.62883227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70919"},
        {"Hipparcos Number", "HIP 41429"},
        {"Geneva Identification System", "GEN# +1.00070919"},
        {"Smithsonian Astrophysical Observation", "SAO 26837"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.74786910),
        dec: Angle.Degrees(+53.62927620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232310"},
        {"Hipparcos Number", "HIP 4244"},
        {"Geneva Identification System", "GEN# +1.00232310"},
        {"Smithsonian Astrophysical Observation", "SAO 21823"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.53887410),
        dec: Angle.Degrees(+53.63240999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80475"},
        {"Hipparcos Number", "HIP 45935"},
        {"Smithsonian Astrophysical Observation", "SAO 27223"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.49475774),
        dec: Angle.Degrees(+53.63294785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234735"},
        {"Hipparcos Number", "HIP 92607"},
        {"Smithsonian Astrophysical Observation", "SAO 31227"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.04496012),
        dec: Angle.Degrees(+53.63375373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84645",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10469 AB"},
        {"Henry Draper", "HD 157103"},
        {"Hipparcos Number", "HIP 84645"},
        {"Geneva Identification System", "GEN# +1.00157103J"},
        {"Smithsonian Astrophysical Observation", "SAO 30332"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.56905253),
        dec: Angle.Degrees(+53.63503265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86662"},
        {"Hipparcos Number", "HIP 49133"},
        {"Smithsonian Astrophysical Observation", "SAO 27477"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.41493111),
        dec: Angle.Degrees(+53.63773318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10824",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1769 AB"},
        {"Henry Draper", "HD 14174"},
        {"Hipparcos Number", "HIP 10824"},
        {"Geneva Identification System", "GEN# +1.00014174J"},
        {"Smithsonian Astrophysical Observation", "SAO 23186"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.83438494),
        dec: Angle.Degrees(+53.63912801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132581"},
        {"Hipparcos Number", "HIP 73210"},
        {"Geneva Identification System", "GEN# +1.00132581"},
        {"Smithsonian Astrophysical Observation", "SAO 29358"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.919,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.43596208),
        dec: Angle.Degrees(+53.64674838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38117",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6369 A"},
        {"Henry Draper", "HD 233453"},
        {"Hipparcos Number", "HIP 38117"},
        {"Cincinnati Publication", "Ci 20 439"},
        {"Smithsonian Astrophysical Observation", "SAO 26516"},
        {"Wilson Evans Batten Catalogue", "WEB 7513"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.16535601),
        dec: Angle.Degrees(+53.64985681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -124.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -528.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235781"},
        {"Hipparcos Number", "HIP 110020"},
        {"Geneva Identification System", "GEN# +1.00235781"},
        {"Smithsonian Astrophysical Observation", "SAO 34264"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.24987438),
        dec: Angle.Degrees(+53.65027904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119822"},
        {"Hipparcos Number", "HIP 67033"},
        {"Geneva Identification System", "GEN# +1.00119822"},
        {"Smithsonian Astrophysical Observation", "SAO 28873"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.06381014),
        dec: Angle.Degrees(+53.65460782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192678"},
        {"Hipparcos Number", "HIP 99672"},
        {"Geneva Identification System", "GEN# +1.00192678"},
        {"Renson", "Renson 53740"},
        {"Smithsonian Astrophysical Observation", "SAO 32379"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.40147794),
        dec: Angle.Degrees(+53.65937691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98352"},
        {"Hipparcos Number", "HIP 55290"},
        {"Smithsonian Astrophysical Observation", "SAO 27987"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.85005168),
        dec: Angle.Degrees(+53.66160619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102013"},
        {"Hipparcos Number", "HIP 57272"},
        {"Geneva Identification System", "GEN# +1.00102013"},
        {"Smithsonian Astrophysical Observation", "SAO 28119"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.16599560),
        dec: Angle.Degrees(+53.66365134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160759"},
        {"Hipparcos Number", "HIP 86355"},
        {"Smithsonian Astrophysical Observation", "SAO 30495"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.69258957),
        dec: Angle.Degrees(+53.66599313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235886"},
        {"Hipparcos Number", "HIP 111488"},
        {"Smithsonian Astrophysical Observation", "SAO 34592"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.81683887),
        dec: Angle.Degrees(+53.66607590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232798"},
        {"Hipparcos Number", "HIP 16351"},
        {"Smithsonian Astrophysical Observation", "SAO 24070"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.66957931),
        dec: Angle.Degrees(+53.66670185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221124"},
        {"Hipparcos Number", "HIP 115899"},
        {"Geneva Identification System", "GEN# +1.00221124"},
        {"Smithsonian Astrophysical Observation", "SAO 35454"},
        {"Wilson Evans Batten Catalogue", "WEB 20497"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.21657182),
        dec: Angle.Degrees(+53.66680101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104107",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14626 AB"},
        {"Henry Draper", "HD 201113"},
        {"Hipparcos Number", "HIP 104107"},
        {"Smithsonian Astrophysical Observation", "SAO 33125"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.37843392),
        dec: Angle.Degrees(+53.66820252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233365"},
        {"Hipparcos Number", "HIP 35078"},
        {"Smithsonian Astrophysical Observation", "SAO 26246"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.81520319),
        dec: Angle.Degrees(+53.66825419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92095"},
        {"Hipparcos Number", "HIP 52136"},
        {"Fundamental Katalog 5th Edition", "FK5 2849"},
        {"Geneva Identification System", "GEN# +1.00092095"},
        {"Smithsonian Astrophysical Observation", "SAO 27724"},
        {"Wilson Evans Batten Catalogue", "WEB 9502"},
    },
    visualMagnitude: 5.55,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.77393431),
        dec: Angle.Degrees(+53.66849306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2221",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2221"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.03935224),
        dec: Angle.Degrees(+53.66926601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213702"},
        {"Hipparcos Number", "HIP 111239"},
        {"Geneva Identification System", "GEN# +1.00213702"},
        {"Smithsonian Astrophysical Observation", "SAO 34554"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.05768943),
        dec: Angle.Degrees(+53.66928284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29935",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4888 C"},
        {"Henry Draper", "HD 43227"},
        {"Hipparcos Number", "HIP 29935"},
        {"Geneva Identification System", "GEN# +1.00043227"},
        {"Smithsonian Astrophysical Observation", "SAO 25654"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.53237242),
        dec: Angle.Degrees(+53.67147395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224557"},
        {"Hipparcos Number", "HIP 118223"},
        {"Geneva Identification System", "GEN# +1.00224557"},
        {"Smithsonian Astrophysical Observation", "SAO 35943"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.70490441),
        dec: Angle.Degrees(+53.67218534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105536"},
        {"Hipparcos Number", "HIP 59240"},
        {"Smithsonian Astrophysical Observation", "SAO 28259"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.26400697),
        dec: Angle.Degrees(+53.67234710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218830"},
        {"Hipparcos Number", "HIP 114425"},
        {"Smithsonian Astrophysical Observation", "SAO 35194"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.60477258),
        dec: Angle.Degrees(+53.67266809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96709"},
        {"Hipparcos Number", "HIP 54508"},
        {"Smithsonian Astrophysical Observation", "SAO 27927"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.28107509),
        dec: Angle.Degrees(+53.67571605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90440"},
        {"Hipparcos Number", "HIP 51220"},
        {"Smithsonian Astrophysical Observation", "SAO 27650"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.93093674),
        dec: Angle.Degrees(+53.67831408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66068"},
        {"Henry Draper 2", "HD 66069"},
        {"Hipparcos Number", "HIP 39517"},
        {"Geneva Identification System", "GEN# +1.00066069"},
        {"Geneva Identification System 2", "GEN# +1.00066068"},
        {"Renson", "Renson 18200"},
        {"Smithsonian Astrophysical Observation", "SAO 26650"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.14977344),
        dec: Angle.Degrees(+53.67855100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235578"},
        {"Hipparcos Number", "HIP 106918"},
        {"Smithsonian Astrophysical Observation", "SAO 33629"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.80359075),
        dec: Angle.Degrees(+53.67914051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132142"},
        {"Hipparcos Number", "HIP 73005"},
        {"Cincinnati Publication", "Ci 20 898"},
        {"Geneva Identification System", "GEN# +1.00132142"},
        {"Smithsonian Astrophysical Observation", "SAO 29336"},
        {"Wilson Evans Batten Catalogue", "WEB 12523"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.785,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.79999963),
        dec: Angle.Degrees(+53.67918367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -970.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 478.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96294"},
        {"Hipparcos Number", "HIP 54328"},
        {"Geneva Identification System", "GEN# +1.00096294"},
        {"Smithsonian Astrophysical Observation", "SAO 27910"},
        {"Wilson Evans Batten Catalogue", "WEB 9811"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.70831501),
        dec: Angle.Degrees(+53.68064648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70823",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9282 AB"},
        {"Henry Draper", "HD 127351"},
        {"Hipparcos Number", "HIP 70823"},
        {"Smithsonian Astrophysical Observation", "SAO 29168"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.25218271),
        dec: Angle.Degrees(+53.68066928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234263"},
        {"Hipparcos Number", "HIP 77447"},
        {"Smithsonian Astrophysical Observation", "SAO 29678"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.17279446),
        dec: Angle.Degrees(+53.68085060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234964"},
        {"Hipparcos Number", "HIP 96761"},
        {"Geneva Identification System", "GEN# +1.00234964"},
        {"Smithsonian Astrophysical Observation", "SAO 31876"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.03186505),
        dec: Angle.Degrees(+53.68459425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137444"},
        {"Hipparcos Number", "HIP 75345"},
        {"Geneva Identification System", "GEN# +1.00137444"},
        {"Smithsonian Astrophysical Observation", "SAO 29511"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.94737259),
        dec: Angle.Degrees(+53.68563221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221538"},
        {"Hipparcos Number", "HIP 116196"},
        {"Fundamental Katalog 5th Edition", "FK5 3888"},
        {"Geneva Identification System", "GEN# +1.00221538"},
        {"Smithsonian Astrophysical Observation", "SAO 35526"},
        {"Wilson Evans Batten Catalogue", "WEB 20538"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.14579315),
        dec: Angle.Degrees(+53.68638628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12058",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1958 A"},
        {"Henry Draper", "HD 232678"},
        {"Hipparcos Number", "HIP 12058"},
        {"Smithsonian Astrophysical Observation", "SAO 23448"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.87575450),
        dec: Angle.Degrees(+53.68789708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26171",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26171"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.69277989),
        dec: Angle.Degrees(+53.69116951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154224"},
        {"Hipparcos Number", "HIP 83287"},
        {"Smithsonian Astrophysical Observation", "SAO 30202"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.31285439),
        dec: Angle.Degrees(+53.69240746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107455",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107455"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.46544164),
        dec: Angle.Degrees(+53.69294403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58001",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Phecda"},
        {"Henry Draper", "HD 103287"},
        {"Hipparcos Number", "HIP 58001"},
        {"Celescope Catalog", "CEL 4005"},
        {"Fundamental Katalog 5th Edition", "FK5 447"},
        {"Geneva Identification System", "GEN# +1.00103287"},
        {"Smithsonian Astrophysical Observation", "SAO 28179"},
        {"Wilson Evans Batten Catalogue", "WEB 10387"},
    },
    visualMagnitude: 2.41,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.45725536),
        dec: Angle.Degrees(+53.69473296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233788"},
        {"Hipparcos Number", "HIP 53504"},
        {"Smithsonian Astrophysical Observation", "SAO 27834"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.18480244),
        dec: Angle.Degrees(+53.69565781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222867"},
        {"Hipparcos Number", "HIP 117083"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.03804773),
        dec: Angle.Degrees(+53.69744640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234206"},
        {"Hipparcos Number", "HIP 73875"},
        {"Fundamental Katalog 5th Edition", "FK5 5339"},
        {"Geneva Identification System", "GEN# +1.00234206"},
        {"Smithsonian Astrophysical Observation", "SAO 29403"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.48240951),
        dec: Angle.Degrees(+53.69808215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109606",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109606"},
        {"Geneva Identification System", "GEN# +0.05203135"},
        {"Wilson Evans Batten Catalogue", "WEB 19695"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.04068018),
        dec: Angle.Degrees(+53.69879371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27291"},
        {"Hipparcos Number", "HIP 20332"},
        {"Geneva Identification System", "GEN# +1.00027291"},
        {"Smithsonian Astrophysical Observation", "SAO 24560"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.33974706),
        dec: Angle.Degrees(+53.70090342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195590"},
        {"Hipparcos Number", "HIP 101124"},
        {"Geneva Identification System", "GEN# +1.00195590"},
        {"Smithsonian Astrophysical Observation", "SAO 32632"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.47973920),
        dec: Angle.Degrees(+53.70448657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216438"},
        {"Hipparcos Number", "HIP 112912"},
        {"Celescope Catalog", "CEL 5536"},
        {"Geneva Identification System", "GEN# +1.00216438"},
        {"Smithsonian Astrophysical Observation", "SAO 34891"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.99273675),
        dec: Angle.Degrees(+53.70979298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33002"},
        {"Hipparcos Number", "HIP 24052"},
        {"Smithsonian Astrophysical Observation", "SAO 25058"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.53213675),
        dec: Angle.Degrees(+53.70979355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20436"},
        {"Hipparcos Number", "HIP 15492"},
        {"Geneva Identification System", "GEN# +1.00020436"},
        {"Smithsonian Astrophysical Observation", "SAO 23952"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.91014996),
        dec: Angle.Degrees(+53.71077261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1417",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 242 A"},
        {"Henry Draper", "HD 1335"},
        {"Hipparcos Number", "HIP 1417"},
        {"Geneva Identification System", "GEN# +1.00001335"},
        {"Smithsonian Astrophysical Observation", "SAO 21275"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.43677681),
        dec: Angle.Degrees(+53.71124384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235645"},
        {"Hipparcos Number", "HIP 107970"},
        {"Smithsonian Astrophysical Observation", "SAO 33823"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.11050712),
        dec: Angle.Degrees(+53.71202932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217349"},
        {"Hipparcos Number", "HIP 113512"},
        {"Smithsonian Astrophysical Observation", "SAO 35028"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.82784474),
        dec: Angle.Degrees(+53.71223179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224274"},
        {"Hipparcos Number", "HIP 118032"},
        {"Geneva Identification System", "GEN# +1.00224274"},
        {"Smithsonian Astrophysical Observation", "SAO 35908"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.12946749),
        dec: Angle.Degrees(+53.71260414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232263"},
        {"Hipparcos Number", "HIP 3507"},
        {"Smithsonian Astrophysical Observation", "SAO 21674"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.19038700),
        dec: Angle.Degrees(+53.71330632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79485",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79485"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.30922962),
        dec: Angle.Degrees(+53.71507524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55840",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55840"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.67372309),
        dec: Angle.Degrees(+53.71593800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 224.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 65.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221902"},
        {"Hipparcos Number", "HIP 116439"},
        {"Smithsonian Astrophysical Observation", "SAO 35578"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.92595554),
        dec: Angle.Degrees(+53.71621635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233553"},
        {"Hipparcos Number", "HIP 42393"},
        {"Smithsonian Astrophysical Observation", "SAO 26937"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.66765362),
        dec: Angle.Degrees(+53.72289117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235574"},
        {"Hipparcos Number", "HIP 106860"},
        {"Smithsonian Astrophysical Observation", "SAO 33616"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.64131738),
        dec: Angle.Degrees(+53.72302067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235301"},
        {"Hipparcos Number", "HIP 101786"},
        {"Smithsonian Astrophysical Observation", "SAO 32742"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.43143853),
        dec: Angle.Degrees(+53.72331573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72522"},
        {"Hipparcos Number", "HIP 42167"},
        {"Smithsonian Astrophysical Observation", "SAO 26919"},
        {"Wilson Evans Batten Catalogue", "WEB 8102"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.94389787),
        dec: Angle.Degrees(+53.72592809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116474"},
        {"Hipparcos Number", "HIP 65290"},
        {"Smithsonian Astrophysical Observation", "SAO 28729"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.72021717),
        dec: Angle.Degrees(+53.72686275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76893",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76893"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.719,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.50623346),
        dec: Angle.Degrees(+53.72863259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121409"},
        {"Hipparcos Number", "HIP 67848"},
        {"Geneva Identification System", "GEN# +1.00121409"},
        {"Smithsonian Astrophysical Observation", "SAO 28928"},
        {"Wilson Evans Batten Catalogue", "WEB 11928"},
    },
    visualMagnitude: 5.70,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.46267613),
        dec: Angle.Degrees(+53.72869210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66192",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Liesma"},
        {"Henry Draper", "HD 118203"},
        {"Hipparcos Number", "HIP 66192"},
        {"Smithsonian Astrophysical Observation", "SAO 28802"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.51093354),
        dec: Angle.Degrees(+53.72871964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234552"},
        {"Hipparcos Number", "HIP 88546"},
        {"Smithsonian Astrophysical Observation", "SAO 30732"},
    },
    visualMagnitude: 9.50,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.20666225),
        dec: Angle.Degrees(+53.72944989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6890"},
        {"Hipparcos Number", "HIP 5497"},
        {"Geneva Identification System", "GEN# +1.00006890"},
        {"Smithsonian Astrophysical Observation", "SAO 22054"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.59549531),
        dec: Angle.Degrees(+53.73316519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235399"},
        {"Hipparcos Number", "HIP 103245"},
        {"Smithsonian Astrophysical Observation", "SAO 32992"},
        {"Wilson Evans Batten Catalogue", "WEB 18760"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.75753378),
        dec: Angle.Degrees(+53.73349472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75633"},
        {"Hipparcos Number", "HIP 43640"},
        {"Geneva Identification System", "GEN# +1.00075633"},
        {"Smithsonian Astrophysical Observation", "SAO 27030"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.33051168),
        dec: Angle.Degrees(+53.73588898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233458"},
        {"Hipparcos Number", "HIP 38320"},
        {"Smithsonian Astrophysical Observation", "SAO 26533"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.76031570),
        dec: Angle.Degrees(+53.74162224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201794"},
        {"Hipparcos Number", "HIP 104477"},
        {"Geneva Identification System", "GEN# +1.00201794"},
        {"Smithsonian Astrophysical Observation", "SAO 33179"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.46669538),
        dec: Angle.Degrees(+53.74235122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11094"},
        {"Hipparcos Number", "HIP 8565"},
        {"Geneva Identification System", "GEN# +1.00011094"},
        {"Smithsonian Astrophysical Observation", "SAO 22663"},
        {"Wilson Evans Batten Catalogue", "WEB 1819"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.62196077),
        dec: Angle.Degrees(+53.74278514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233411"},
        {"Hipparcos Number", "HIP 36696"},
        {"Smithsonian Astrophysical Observation", "SAO 26400"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.22914835),
        dec: Angle.Degrees(+53.74304699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168601"},
        {"Hipparcos Number", "HIP 89643"},
        {"Geneva Identification System", "GEN# +1.00168601"},
        {"Smithsonian Astrophysical Observation", "SAO 30874"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.41147632),
        dec: Angle.Degrees(+53.74499548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202084"},
        {"Hipparcos Number", "HIP 104630"},
        {"Celescope Catalog", "CEL 5267"},
        {"Geneva Identification System", "GEN# +1.00202084"},
        {"Smithsonian Astrophysical Observation", "SAO 33203"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.91459361),
        dec: Angle.Degrees(+53.74623103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30610",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30610"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.793,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.49578029),
        dec: Angle.Degrees(+53.74771287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131445"},
        {"Hipparcos Number", "HIP 72686"},
        {"Geneva Identification System", "GEN# +1.00131445"},
        {"Smithsonian Astrophysical Observation", "SAO 29314"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.91900964),
        dec: Angle.Degrees(+53.74848758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135925"},
        {"Hipparcos Number", "HIP 74665"},
        {"Smithsonian Astrophysical Observation", "SAO 29462"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.87058184),
        dec: Angle.Degrees(+53.74912269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35422"},
        {"Hipparcos Number", "HIP 25535"},
        {"Smithsonian Astrophysical Observation", "SAO 25202"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.90418408),
        dec: Angle.Degrees(+53.75036076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64348"},
        {"Hipparcos Number", "HIP 38780"},
        {"Geneva Identification System", "GEN# +1.00064348"},
        {"Smithsonian Astrophysical Observation", "SAO 26577"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.06685692),
        dec: Angle.Degrees(+53.75072575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154956"},
        {"Hipparcos Number", "HIP 83648"},
        {"Geneva Identification System", "GEN# +1.00154956"},
        {"Smithsonian Astrophysical Observation", "SAO 30243"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.44809833),
        dec: Angle.Degrees(+53.75073075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 89.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121246"},
        {"Hipparcos Number", "HIP 67759"},
        {"Geneva Identification System", "GEN# +1.00121246"},
        {"Smithsonian Astrophysical Observation", "SAO 28920"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.874,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.22105723),
        dec: Angle.Degrees(+53.75117892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80438"},
        {"Hipparcos Number", "HIP 45918"},
        {"Smithsonian Astrophysical Observation", "SAO 27222"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.45136379),
        dec: Angle.Degrees(+53.75179924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23040",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3536 AB"},
        {"Henry Draper", "HD 31278"},
        {"Hipparcos Number", "HIP 23040"},
        {"Geneva Identification System", "GEN# +1.00031278J"},
        {"Renson", "Renson 8023"},
        {"Smithsonian Astrophysical Observation", "SAO 24929"},
        {"Wilson Evans Batten Catalogue", "WEB 4470"},
    },
    visualMagnitude: 4.43,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.32175175),
        dec: Angle.Degrees(+53.75208289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233959"},
        {"Hipparcos Number", "HIP 61611"},
        {"Smithsonian Astrophysical Observation", "SAO 28454"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.38589726),
        dec: Angle.Degrees(+53.75294120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -184.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 97.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232291"},
        {"Hipparcos Number", "HIP 3996"},
        {"Smithsonian Astrophysical Observation", "SAO 21771"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.83365453),
        dec: Angle.Degrees(+53.75327042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232874"},
        {"Hipparcos Number", "HIP 18834"},
        {"Geneva Identification System", "GEN# +1.00232874"},
        {"Smithsonian Astrophysical Observation", "SAO 24357"},
        {"Wilson Evans Batten Catalogue", "WEB 3627"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.56559358),
        dec: Angle.Degrees(+53.75327576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215471"},
        {"Hipparcos Number", "HIP 112277"},
        {"Smithsonian Astrophysical Observation", "SAO 34745"},
        {"Wilson Evans Batten Catalogue", "WEB 20035"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.12492399),
        dec: Angle.Degrees(+53.75646538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215837"},
        {"Hipparcos Number", "HIP 112478"},
        {"Celescope Catalog", "CEL 5523"},
        {"Geneva Identification System", "GEN# +1.00215837"},
        {"Smithsonian Astrophysical Observation", "SAO 34811"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.74944822),
        dec: Angle.Degrees(+53.75671215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119664"},
        {"Hipparcos Number", "HIP 66951"},
        {"Smithsonian Astrophysical Observation", "SAO 28863"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.83557228),
        dec: Angle.Degrees(+53.75700809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5984",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5984"},
        {"Smithsonian Astrophysical Observation", "SAO 22144"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.23895011),
        dec: Angle.Degrees(+53.75779670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233053"},
        {"Hipparcos Number", "HIP 23478"},
        {"Smithsonian Astrophysical Observation", "SAO 24969"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.69602156),
        dec: Angle.Degrees(+53.75890947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233852"},
        {"Hipparcos Number", "HIP 56874"},
        {"Smithsonian Astrophysical Observation", "SAO 28090"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.90091012),
        dec: Angle.Degrees(+53.76605692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84034"},
        {"Hipparcos Number", "HIP 47756"},
        {"Smithsonian Astrophysical Observation", "SAO 27367"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.03281980),
        dec: Angle.Degrees(+53.76677108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199332"},
        {"Hipparcos Number", "HIP 103188"},
        {"Smithsonian Astrophysical Observation", "SAO 32985"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.799,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.59096145),
        dec: Angle.Degrees(+53.76688835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187767"},
        {"Hipparcos Number", "HIP 97503"},
        {"Celescope Catalog", "CEL 4854"},
        {"Geneva Identification System", "GEN# +1.00187767"},
        {"Smithsonian Astrophysical Observation", "SAO 32025"},
    },
    visualMagnitude: 7.09,
    bvColour: -0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.26676628),
        dec: Angle.Degrees(+53.76747323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206790"},
        {"Hipparcos Number", "HIP 107211"},
        {"Geneva Identification System", "GEN# +2.71280001"},
        {"Smithsonian Astrophysical Observation", "SAO 33681"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.72154742),
        dec: Angle.Degrees(+53.76756765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7599"},
        {"Hipparcos Number", "HIP 5983"},
        {"Smithsonian Astrophysical Observation", "SAO 22145"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.24312806),
        dec: Angle.Degrees(+53.76821759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49136"},
        {"Hipparcos Number", "HIP 32770"},
        {"Smithsonian Astrophysical Observation", "SAO 25977"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.49036567),
        dec: Angle.Degrees(+53.76879232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183122"},
        {"Hipparcos Number", "HIP 95473"},
        {"Geneva Identification System", "GEN# +1.00183122"},
        {"Smithsonian Astrophysical Observation", "SAO 31644"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.30131881),
        dec: Angle.Degrees(+53.76885155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88638"},
        {"Hipparcos Number", "HIP 50180"},
        {"Geneva Identification System", "GEN# +1.00088638"},
        {"Smithsonian Astrophysical Observation", "SAO 27576"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.768,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.65021038),
        dec: Angle.Degrees(+53.77081180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -277.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147502"},
        {"Hipparcos Number", "HIP 79990"},
        {"Smithsonian Astrophysical Observation", "SAO 29892"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.92380717),
        dec: Angle.Degrees(+53.77181163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19660",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3044 AB"},
        {"Henry Draper", "HD 232908"},
        {"Hipparcos Number", "HIP 19660"},
    },
    visualMagnitude: 9.80,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.18839739),
        dec: Angle.Degrees(+53.77214399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232813"},
        {"Hipparcos Number", "HIP 16871"},
        {"Smithsonian Astrophysical Observation", "SAO 24123"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.27905638),
        dec: Angle.Degrees(+53.77237918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 136.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91562"},
        {"Hipparcos Number", "HIP 51845"},
        {"Smithsonian Astrophysical Observation", "SAO 27699"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.88014785),
        dec: Angle.Degrees(+53.77265145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7823"},
        {"Hipparcos Number", "HIP 6149"},
        {"Smithsonian Astrophysical Observation", "SAO 22174"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.73463521),
        dec: Angle.Degrees(+53.77442484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14723"},
        {"Hipparcos Number", "HIP 11213"},
        {"Geneva Identification System", "GEN# +1.00014723"},
        {"Smithsonian Astrophysical Observation", "SAO 23293"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.08514824),
        dec: Angle.Degrees(+53.77469021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45576"},
        {"Hipparcos Number", "HIP 31080"},
        {"Geneva Identification System", "GEN# +1.00045576"},
        {"Smithsonian Astrophysical Observation", "SAO 25782"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.83120072),
        dec: Angle.Degrees(+53.77526602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100469"},
        {"Hipparcos Number", "HIP 56426"},
        {"Smithsonian Astrophysical Observation", "SAO 28058"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.53358384),
        dec: Angle.Degrees(+53.77605766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232247"},
        {"Hipparcos Number", "HIP 3233"},
        {"Smithsonian Astrophysical Observation", "SAO 21618"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.28531169),
        dec: Angle.Degrees(+53.77608630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89389"},
        {"Hipparcos Number", "HIP 50606"},
        {"Geneva Identification System", "GEN# +1.00089389"},
        {"Smithsonian Astrophysical Observation", "SAO 27606"},
        {"Wilson Evans Batten Catalogue", "WEB 9281"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.06199812),
        dec: Angle.Degrees(+53.77926966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212827"},
        {"Hipparcos Number", "HIP 110721"},
        {"Geneva Identification System", "GEN# +1.00212827"},
        {"Smithsonian Astrophysical Observation", "SAO 34443"},
        {"Wilson Evans Batten Catalogue", "WEB 19838"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.49332337),
        dec: Angle.Degrees(+53.78159075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21607",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3334 AB"},
        {"Henry Draper", "HD 29149"},
        {"Hipparcos Number", "HIP 21607"},
        {"Smithsonian Astrophysical Observation", "SAO 24729"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.57908316),
        dec: Angle.Degrees(+53.78407175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189252"},
        {"Hipparcos Number", "HIP 98121"},
        {"Smithsonian Astrophysical Observation", "SAO 32129"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.13120534),
        dec: Angle.Degrees(+53.78451654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82473",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10238 AB"},
        {"Henry Draper", "HD 152578"},
        {"Hipparcos Number", "HIP 82473"},
        {"Geneva Identification System", "GEN# +1.00152578J"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.82699106),
        dec: Angle.Degrees(+53.78474116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232948"},
        {"Hipparcos Number", "HIP 20694"},
        {"Smithsonian Astrophysical Observation", "SAO 24602"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.49125487),
        dec: Angle.Degrees(+53.78537346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93134"},
        {"Hipparcos Number", "HIP 52692"},
        {"Smithsonian Astrophysical Observation", "SAO 27762"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.60995940),
        dec: Angle.Degrees(+53.78546380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102129"},
        {"Hipparcos Number", "HIP 57364"},
        {"Geneva Identification System", "GEN# +1.00102129"},
        {"Smithsonian Astrophysical Observation", "SAO 28126"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.40454128),
        dec: Angle.Degrees(+53.78619260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219289"},
        {"Hipparcos Number", "HIP 114704"},
        {"Smithsonian Astrophysical Observation", "SAO 35247"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.53107893),
        dec: Angle.Degrees(+53.78824408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235239"},
        {"Hipparcos Number", "HIP 100803"},
        {"Smithsonian Astrophysical Observation", "SAO 32583"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.58565509),
        dec: Angle.Degrees(+53.78998426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111293",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 9.12,
    bvColour: 1.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)32, 46.1600),
        dec: Angle.DegreesMinutesSeconds((int)+53, (int)47, 27.200)
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
    primaryId: "HIP 111053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235863"},
        {"Hipparcos Number", "HIP 111053"},
        {"Smithsonian Astrophysical Observation", "SAO 34520"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.46868011),
        dec: Angle.Degrees(+53.79180313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18268"},
        {"Hipparcos Number", "HIP 13845"},
        {"Geneva Identification System", "GEN# +1.00018268"},
        {"Smithsonian Astrophysical Observation", "SAO 23738"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.55560123),
        dec: Angle.Degrees(+53.79346406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129919"},
        {"Hipparcos Number", "HIP 71985"},
        {"Geneva Identification System", "GEN# +1.00129919"},
        {"Smithsonian Astrophysical Observation", "SAO 29256"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.83806391),
        dec: Angle.Degrees(+53.79385062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204791"},
        {"Hipparcos Number", "HIP 106073"},
        {"Geneva Identification System", "GEN# +1.00204791"},
        {"Smithsonian Astrophysical Observation", "SAO 33460"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.27789365),
        dec: Angle.Degrees(+53.79420125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 330"},
        {"Hipparcos Number", "HIP 656"},
        {"Geneva Identification System", "GEN# +1.00000330"},
        {"Smithsonian Astrophysical Observation", "SAO 21116"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.01924689),
        dec: Angle.Degrees(+53.79639636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209391"},
        {"Hipparcos Number", "HIP 108737"},
        {"Geneva Identification System", "GEN# +1.00209391"},
        {"Smithsonian Astrophysical Observation", "SAO 33981"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.40671984),
        dec: Angle.Degrees(+53.79713756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234799"},
        {"Hipparcos Number", "HIP 93802"},
        {"Geneva Identification System", "GEN# +1.00234799"},
        {"Smithsonian Astrophysical Observation", "SAO 31385"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.54912000),
        dec: Angle.Degrees(+53.79838028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111128"},
        {"Hipparcos Number", "HIP 62335"},
        {"Geneva Identification System", "GEN# +1.00111128"},
        {"Smithsonian Astrophysical Observation", "SAO 28512"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.61191250),
        dec: Angle.Degrees(+53.80075648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86782",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Alruba"},
        {"Henry Draper", "HD 161693"},
        {"Hipparcos Number", "HIP 86782"},
        {"Geneva Identification System", "GEN# +1.00161693"},
        {"Smithsonian Astrophysical Observation", "SAO 30538"},
        {"Wilson Evans Batten Catalogue", "WEB 14635"},
    },
    visualMagnitude: 5.75,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.99651272),
        dec: Angle.Degrees(+53.80175482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233637"},
        {"Hipparcos Number", "HIP 46473"},
        {"Smithsonian Astrophysical Observation", "SAO 27264"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.17372377),
        dec: Angle.Degrees(+53.80231053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17817"},
        {"Hipparcos Number", "HIP 13488"},
        {"Smithsonian Astrophysical Observation", "SAO 23680"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.41965799),
        dec: Angle.Degrees(+53.80285123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199546"},
        {"Hipparcos Number", "HIP 103304"},
        {"Geneva Identification System", "GEN# +1.00199546"},
        {"Smithsonian Astrophysical Observation", "SAO 32998"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.92605853),
        dec: Angle.Degrees(+53.80593645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235538"},
        {"Hipparcos Number", "HIP 106366"},
        {"Smithsonian Astrophysical Observation", "SAO 33517"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.14971521),
        dec: Angle.Degrees(+53.80651906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62121",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8650 A"},
        {"Henry Draper", "HD 233976"},
        {"Hipparcos Number", "HIP 62121"},
        {"Smithsonian Astrophysical Observation", "SAO 28495"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.97070991),
        dec: Angle.Degrees(+53.80832783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217768"},
        {"Hipparcos Number", "HIP 113764"},
        {"Geneva Identification System", "GEN# +1.00217768"},
        {"Smithsonian Astrophysical Observation", "SAO 35082"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.58464121),
        dec: Angle.Degrees(+53.80956339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126289"},
        {"Hipparcos Number", "HIP 70291"},
        {"Geneva Identification System", "GEN# +1.00126289"},
        {"Smithsonian Astrophysical Observation", "SAO 29125"},
        {"Wilson Evans Batten Catalogue", "WEB 12204"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.72049506),
        dec: Angle.Degrees(+53.81039501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102743"},
        {"Hipparcos Number", "HIP 57706"},
        {"Geneva Identification System", "GEN# +1.00102743"},
        {"Smithsonian Astrophysical Observation", "SAO 28156"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.801,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.51516081),
        dec: Angle.Degrees(+53.81041630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232971"},
        {"Hipparcos Number", "HIP 21127"},
        {"Smithsonian Astrophysical Observation", "SAO 24666"},
        {"Wilson Evans Batten Catalogue", "WEB 4063"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.92414263),
        dec: Angle.Degrees(+53.81278223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138555"},
        {"Hipparcos Number", "HIP 75932"},
        {"Smithsonian Astrophysical Observation", "SAO 29552"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.63421775),
        dec: Angle.Degrees(+53.81459378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110310",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15856 AB"},
        {"Henry Draper", "HD 212094"},
        {"Hipparcos Number", "HIP 110310"},
        {"Geneva Identification System", "GEN# +1.00212094J"},
        {"Smithsonian Astrophysical Observation", "SAO 34334"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.718,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.14703293),
        dec: Angle.Degrees(+53.81474014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2825"},
        {"Hipparcos Number", "HIP 2537"},
        {"Smithsonian Astrophysical Observation", "SAO 21496"},
        {"Wilson Evans Batten Catalogue", "WEB 466"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.04742586),
        dec: Angle.Degrees(+53.81511065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115163"},
        {"Hipparcos Number", "HIP 64604"},
        {"Smithsonian Astrophysical Observation", "SAO 28684"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.61935802),
        dec: Angle.Degrees(+53.81555359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212790"},
        {"Hipparcos Number", "HIP 110704"},
        {"Smithsonian Astrophysical Observation", "SAO 34439"},
        {"Wilson Evans Batten Catalogue", "WEB 19834"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.44282775),
        dec: Angle.Degrees(+53.81658748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232841"},
        {"Hipparcos Number", "HIP 17822"},
        {"Smithsonian Astrophysical Observation", "SAO 24238"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.19949949),
        dec: Angle.Degrees(+53.82157490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236269"},
        {"Hipparcos Number", "HIP 61"},
        {"Smithsonian Astrophysical Observation", "SAO 35985"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.17615726),
        dec: Angle.Degrees(+53.82218625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1966"},
        {"Hipparcos Number", "HIP 1918"},
        {"Geneva Identification System", "GEN# +1.00001966"},
        {"Smithsonian Astrophysical Observation", "SAO 21363"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.06036421),
        dec: Angle.Degrees(+53.82237970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232351"},
        {"Hipparcos Number", "HIP 4792"},
        {"Smithsonian Astrophysical Observation", "SAO 21927"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.38577808),
        dec: Angle.Degrees(+53.82324472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1167",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 181 AB"},
        {"Henry Draper", "HD 992"},
        {"Hipparcos Number", "HIP 1167"},
        {"Smithsonian Astrophysical Observation", "SAO 21235"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.64859535),
        dec: Angle.Degrees(+53.82756851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234712"},
        {"Hipparcos Number", "HIP 92174"},
        {"Smithsonian Astrophysical Observation", "SAO 31170"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.79173533),
        dec: Angle.Degrees(+53.82913903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202196"},
        {"Hipparcos Number", "HIP 104681"},
        {"Smithsonian Astrophysical Observation", "SAO 33216"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.07020547),
        dec: Angle.Degrees(+53.83151185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42105"},
        {"Hipparcos Number", "HIP 29422"},
        {"Geneva Identification System", "GEN# +1.00042105"},
        {"Smithsonian Astrophysical Observation", "SAO 25614"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.97911903),
        dec: Angle.Degrees(+53.83275454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40892"},
        {"Hipparcos Number", "HIP 28799"},
        {"Smithsonian Astrophysical Observation", "SAO 25552"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.20016405),
        dec: Angle.Degrees(+53.83350073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84816",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84816"},
    },
    visualMagnitude: 11.24,
    bvColour: 1.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.01458013),
        dec: Angle.Degrees(+53.83364705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -269.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234327"},
        {"Hipparcos Number", "HIP 81448"},
        {"Smithsonian Astrophysical Observation", "SAO 30025"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.52784715),
        dec: Angle.Degrees(+53.83875008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233575"},
        {"Hipparcos Number", "HIP 43382"},
        {"Smithsonian Astrophysical Observation", "SAO 27010"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.55138398),
        dec: Angle.Degrees(+53.83973048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60436"},
        {"Hipparcos Number", "HIP 37086"},
        {"Smithsonian Astrophysical Observation", "SAO 26430"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.31339006),
        dec: Angle.Degrees(+53.84085963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13137"},
        {"Hipparcos Number", "HIP 10115"},
        {"Fundamental Katalog 5th Edition", "FK5 2146"},
        {"Geneva Identification System", "GEN# +1.00013137"},
        {"Smithsonian Astrophysical Observation", "SAO 22993"},
        {"Wilson Evans Batten Catalogue", "WEB 2113"},
    },
    visualMagnitude: 6.31,
    bvColour: 0.948,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.53218824),
        dec: Angle.Degrees(+53.84320117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101779",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14094 A"},
        {"Henry Draper", "HD 235300"},
        {"Hipparcos Number", "HIP 101779"},
        {"Geneva Identification System", "GEN# +1.00235300"},
        {"Smithsonian Astrophysical Observation", "SAO 32740"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.41649060),
        dec: Angle.Degrees(+53.84363952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -217.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119801"},
        {"Hipparcos Number", "HIP 67020"},
        {"Smithsonian Astrophysical Observation", "SAO 28869"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.02420645),
        dec: Angle.Degrees(+53.84478182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214878"},
        {"Hipparcos Number", "HIP 111925"},
        {"Geneva Identification System", "GEN# +1.00214878"},
        {"Smithsonian Astrophysical Observation", "SAO 34682"},
        {"Wilson Evans Batten Catalogue", "WEB 19986"},
    },
    visualMagnitude: 5.94,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.07667029),
        dec: Angle.Degrees(+53.84597214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96125"},
        {"Hipparcos Number", "HIP 54251"},
        {"Smithsonian Astrophysical Observation", "SAO 27900"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.47507343),
        dec: Angle.Degrees(+53.85084118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15346"},
        {"Hipparcos Number", "HIP 11627"},
        {"Geneva Identification System", "GEN# +1.00015346"},
        {"Smithsonian Astrophysical Observation", "SAO 23381"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.50338758),
        dec: Angle.Degrees(+53.85232980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113696"},
        {"Hipparcos Number", "HIP 63805"},
        {"Smithsonian Astrophysical Observation", "SAO 28626"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.16670027),
        dec: Angle.Degrees(+53.85754717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223388"},
        {"Hipparcos Number", "HIP 117456"},
        {"Smithsonian Astrophysical Observation", "SAO 35796"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.23921829),
        dec: Angle.Degrees(+53.85841794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116170"},
        {"Hipparcos Number", "HIP 65131"},
        {"Fundamental Katalog 5th Edition", "FK5 5179"},
        {"Smithsonian Astrophysical Observation", "SAO 28723"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.20448843),
        dec: Angle.Degrees(+53.85947354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73366",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9474 A"},
        {"Henry Draper", "HD 132910"},
        {"Hipparcos Number", "HIP 73366"},
        {"Geneva Identification System", "GEN# +1.00132910"},
        {"Smithsonian Astrophysical Observation", "SAO 29372"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.89398654),
        dec: Angle.Degrees(+53.86020461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9384"},
        {"Hipparcos Number", "HIP 7257"},
        {"Smithsonian Astrophysical Observation", "SAO 22392"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.37871548),
        dec: Angle.Degrees(+53.86232775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71244"},
        {"Hipparcos Number", "HIP 41598"},
        {"Geneva Identification System", "GEN# +1.00071244"},
        {"Smithsonian Astrophysical Observation", "SAO 26860"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.21546098),
        dec: Angle.Degrees(+53.86235062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233774"},
        {"Hipparcos Number", "HIP 53041"},
        {"Smithsonian Astrophysical Observation", "SAO 27792"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.79144801),
        dec: Angle.Degrees(+53.86568156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25056"},
        {"Hipparcos Number", "HIP 18795"},
        {"Geneva Identification System", "GEN# +1.00025056"},
        {"Smithsonian Astrophysical Observation", "SAO 24350"},
        {"Wilson Evans Batten Catalogue", "WEB 3618"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.40550643),
        dec: Angle.Degrees(+53.86594415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10110"},
        {"Hipparcos Number", "HIP 7786"},
        {"Geneva Identification System", "GEN# +1.00010110"},
        {"Smithsonian Astrophysical Observation", "SAO 22493"},
        {"Wilson Evans Batten Catalogue", "WEB 1669"},
    },
    visualMagnitude: 6.35,
    bvColour: 1.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.05465447),
        dec: Angle.Degrees(+53.86828894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26020"},
        {"Hipparcos Number", "HIP 19450"},
        {"Geneva Identification System", "GEN# +1.00026020"},
        {"Smithsonian Astrophysical Observation", "SAO 24444"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.47642561),
        dec: Angle.Degrees(+53.86922929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73368",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9474 B"},
        {"Henry Draper", "HD 132909"},
        {"Hipparcos Number", "HIP 73368"},
        {"Geneva Identification System", "GEN# +1.00132909"},
        {"Smithsonian Astrophysical Observation", "SAO 29370"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.88799306),
        dec: Angle.Degrees(+53.87082826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142626"},
        {"Hipparcos Number", "HIP 77790"},
        {"Smithsonian Astrophysical Observation", "SAO 29701"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.835,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.26818940),
        dec: Angle.Degrees(+53.87147204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -177.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173664"},
        {"Hipparcos Number", "HIP 91843"},
        {"Geneva Identification System", "GEN# +1.00173664"},
        {"Smithsonian Astrophysical Observation", "SAO 31133"},
        {"Wilson Evans Batten Catalogue", "WEB 15805"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.87086600),
        dec: Angle.Degrees(+53.87179692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8483",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1436 A"},
        {"Henry Draper", "HD 232537"},
        {"Hipparcos Number", "HIP 8483"},
        {"Geneva Identification System", "GEN# +1.00232537"},
        {"Smithsonian Astrophysical Observation", "SAO 22650"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.33792464),
        dec: Angle.Degrees(+53.87497981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30326"},
        {"Hipparcos Number", "HIP 22420"},
        {"Smithsonian Astrophysical Observation", "SAO 24852"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.37377403),
        dec: Angle.Degrees(+53.87591132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8482",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1436 B"},
        {"Hipparcos Number", "HIP 8482"},
    },
    visualMagnitude: 11.51,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.33326261),
        dec: Angle.Degrees(+53.87665720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232856"},
        {"Hipparcos Number", "HIP 18375"},
        {"Smithsonian Astrophysical Observation", "SAO 24299"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.91472231),
        dec: Angle.Degrees(+53.87802278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107322"},
        {"Hipparcos Number", "HIP 60159"},
        {"Smithsonian Astrophysical Observation", "SAO 28343"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.05493459),
        dec: Angle.Degrees(+53.87823450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82978",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82978"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.35562539),
        dec: Angle.Degrees(+53.88260025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37395",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37395"},
    },
    visualMagnitude: 11.83,
    bvColour: 1.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.14883947),
        dec: Angle.Degrees(+53.88263442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -192.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -150.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91385",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11549 AB"},
        {"Henry Draper", "HD 172612"},
        {"Hipparcos Number", "HIP 91385"},
        {"Smithsonian Astrophysical Observation", "SAO 31079"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.58200886),
        dec: Angle.Degrees(+53.88508590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190508"},
        {"Hipparcos Number", "HIP 98692"},
        {"Geneva Identification System", "GEN# +1.00190508"},
        {"Smithsonian Astrophysical Observation", "SAO 32232"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.67493212),
        dec: Angle.Degrees(+53.88966128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100697"},
        {"Hipparcos Number", "HIP 56545"},
        {"Fundamental Katalog 5th Edition", "FK5 5023"},
        {"Smithsonian Astrophysical Observation", "SAO 28067"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.90958440),
        dec: Angle.Degrees(+53.88970341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87141"},
        {"Hipparcos Number", "HIP 49363"},
        {"Fundamental Katalog 5th Edition", "FK5 1259"},
        {"Geneva Identification System", "GEN# +1.00087141"},
        {"Smithsonian Astrophysical Observation", "SAO 27503"},
        {"Wilson Evans Batten Catalogue", "WEB 9126"},
    },
    visualMagnitude: 5.71,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.15143814),
        dec: Angle.Degrees(+53.89172560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11519"},
        {"Hipparcos Number", "HIP 8905"},
        {"Geneva Identification System", "GEN# +1.00011519"},
        {"Smithsonian Astrophysical Observation", "SAO 22732"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.66476139),
        dec: Angle.Degrees(+53.89183413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234536"},
        {"Hipparcos Number", "HIP 88141"},
        {"Smithsonian Astrophysical Observation", "SAO 30684"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.04446239),
        dec: Angle.Degrees(+53.89347414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121892"},
        {"Hipparcos Number", "HIP 68132"},
        {"Smithsonian Astrophysical Observation", "SAO 28940"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.21798407),
        dec: Angle.Degrees(+53.89403766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20275"},
        {"Hipparcos Number", "HIP 15350"},
        {"Smithsonian Astrophysical Observation", "SAO 23933"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.48469095),
        dec: Angle.Degrees(+53.89428763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2920",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Fulu"},
        {"Henry Draper", "HD 3360"},
        {"Hipparcos Number", "HIP 2920"},
        {"Fundamental Katalog 5th Edition", "FK5 17"},
        {"Geneva Identification System", "GEN# +1.00003360"},
        {"Smithsonian Astrophysical Observation", "SAO 21566"},
        {"Wilson Evans Batten Catalogue", "WEB 529"},
    },
    visualMagnitude: 3.69,
    bvColour: -0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.24277921),
        dec: Angle.Degrees(+53.89693161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70173",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9234 B"},
        {"Henry Draper", "HD 126049"},
        {"Henry Draper 2", "HD 126049B"},
        {"Hipparcos Number", "HIP 70173"},
        {"Smithsonian Astrophysical Observation", "SAO 29115"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.36407588),
        dec: Angle.Degrees(+53.89749106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70176",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9234 A"},
        {"Henry Draper", "HD 126049A"},
        {"Hipparcos Number", "HIP 70176"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.37082708),
        dec: Angle.Degrees(+53.89809366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60818"},
        {"Hipparcos Number", "HIP 37271"},
        {"Fundamental Katalog 5th Edition", "FK5 2590"},
        {"Geneva Identification System", "GEN# +1.00060818"},
        {"Smithsonian Astrophysical Observation", "SAO 26443"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.80195476),
        dec: Angle.Degrees(+53.90079086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235662"},
        {"Hipparcos Number", "HIP 108210"},
        {"Smithsonian Astrophysical Observation", "SAO 33873"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.83673073),
        dec: Angle.Degrees(+53.90289129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59379",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8447 AB"},
        {"Henry Draper", "HD 105860"},
        {"Hipparcos Number", "HIP 59379"},
        {"Smithsonian Astrophysical Observation", "SAO 28280"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.74094908),
        dec: Angle.Degrees(+53.90322929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232695"},
        {"Hipparcos Number", "HIP 12525"},
        {"Smithsonian Astrophysical Observation", "SAO 23527"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.29559542),
        dec: Angle.Degrees(+53.90353259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192456"},
        {"Hipparcos Number", "HIP 99573"},
        {"Smithsonian Astrophysical Observation", "SAO 32355"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.10997856),
        dec: Angle.Degrees(+53.90511938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232829"},
        {"Hipparcos Number", "HIP 17590"},
        {"Smithsonian Astrophysical Observation", "SAO 24202"},
    },
    visualMagnitude: 7.88,
    bvColour: 2.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.52590211),
        dec: Angle.Degrees(+53.90529755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198512"},
        {"Hipparcos Number", "HIP 102700"},
        {"Geneva Identification System", "GEN# +1.00198512"},
        {"Smithsonian Astrophysical Observation", "SAO 32906"},
        {"Wilson Evans Batten Catalogue", "WEB 18616"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.13656720),
        dec: Angle.Degrees(+53.90611270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215159"},
        {"Hipparcos Number", "HIP 112098"},
        {"Fundamental Katalog 5th Edition", "FK5 3817"},
        {"Geneva Identification System", "GEN# +1.00215159"},
        {"Smithsonian Astrophysical Observation", "SAO 34713"},
        {"Wilson Evans Batten Catalogue", "WEB 20006"},
    },
    visualMagnitude: 6.14,
    bvColour: 1.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.58671582),
        dec: Angle.Degrees(+53.90876835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122007"},
        {"Hipparcos Number", "HIP 68196"},
        {"Smithsonian Astrophysical Observation", "SAO 28947"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.42840202),
        dec: Angle.Degrees(+53.91010011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21148",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3274 AB"},
        {"Henry Draper", "HD 28446"},
        {"Hipparcos Number", "HIP 21148"},
        {"Fundamental Katalog 5th Edition", "FK5 165"},
        {"Geneva Identification System", "GEN# +1.00028446J"},
        {"Smithsonian Astrophysical Observation", "SAO 24672"},
        {"Wilson Evans Batten Catalogue", "WEB 4067"},
    },
    visualMagnitude: 5.78,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.00767912),
        dec: Angle.Degrees(+53.91084467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188055"},
        {"Hipparcos Number", "HIP 97636"},
        {"Smithsonian Astrophysical Observation", "SAO 32046"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.66149972),
        dec: Angle.Degrees(+53.91122260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232357"},
        {"Hipparcos Number", "HIP 4928"},
        {"Smithsonian Astrophysical Observation", "SAO 21952"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.80686025),
        dec: Angle.Degrees(+53.91335675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13544"},
        {"Hipparcos Number", "HIP 10391"},
        {"Celescope Catalog", "CEL 223"},
        {"Geneva Identification System", "GEN# +1.00013544"},
        {"Smithsonian Astrophysical Observation", "SAO 23052"},
    },
    visualMagnitude: 8.89,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.46597570),
        dec: Angle.Degrees(+53.91459352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8503",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1444 A"},
        {"Henry Draper", "HD 232538"},
        {"Hipparcos Number", "HIP 8503"},
        {"Celescope Catalog", "CEL 171"},
        {"Smithsonian Astrophysical Observation", "SAO 22655"},
        {"Wilson Evans Batten Catalogue", "WEB 1808"},
    },
    visualMagnitude: 9.01,
    bvColour: -0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.41498319),
        dec: Angle.Degrees(+53.91467908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83552"},
        {"Hipparcos Number", "HIP 47501"},
        {"Smithsonian Astrophysical Observation", "SAO 27337"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.26874067),
        dec: Angle.Degrees(+53.91574417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233568"},
        {"Hipparcos Number", "HIP 43016"},
        {"Geneva Identification System", "GEN# +1.00233568"},
        {"Smithsonian Astrophysical Observation", "SAO 26988"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.49322824),
        dec: Angle.Degrees(+53.91637436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6080",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1044 A"},
        {"Henry Draper", "HD 7721"},
        {"Hipparcos Number", "HIP 6080"},
        {"Smithsonian Astrophysical Observation", "SAO 22161"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.50585824),
        dec: Angle.Degrees(+53.91686013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235531"},
        {"Hipparcos Number", "HIP 106245"},
        {"Smithsonian Astrophysical Observation", "SAO 33494"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.79126939),
        dec: Angle.Degrees(+53.91736754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216328"},
        {"Hipparcos Number", "HIP 112846"},
        {"Celescope Catalog", "CEL 5532"},
        {"Geneva Identification System", "GEN# +1.00216328"},
        {"Smithsonian Astrophysical Observation", "SAO 34876"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.79296558),
        dec: Angle.Degrees(+53.91979495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21004"},
        {"Hipparcos Number", "HIP 15979"},
        {"Geneva Identification System", "GEN# +1.00021004"},
        {"Smithsonian Astrophysical Observation", "SAO 24024"},
        {"Wilson Evans Batten Catalogue", "WEB 3052"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.44938056),
        dec: Angle.Degrees(+53.92162363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139357"},
        {"Hipparcos Number", "HIP 76311"},
        {"Geneva Identification System", "GEN# +1.00139357"},
        {"Smithsonian Astrophysical Observation", "SAO 29583"},
        {"Wilson Evans Batten Catalogue", "WEB 12957"},
    },
    visualMagnitude: 5.97,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.81757086),
        dec: Angle.Degrees(+53.92213860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98273",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13197 AB"},
        {"Henry Draper", "HD 189572"},
        {"Hipparcos Number", "HIP 98273"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.51666494),
        dec: Angle.Degrees(+53.92488510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127028"},
        {"Hipparcos Number", "HIP 70667"},
        {"Smithsonian Astrophysical Observation", "SAO 29152"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.81606025),
        dec: Angle.Degrees(+53.92498589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13187",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2145 AB"},
        {"Henry Draper", "HD 232716"},
        {"Hipparcos Number", "HIP 13187"},
        {"Geneva Identification System", "GEN# +1.00232716J"},
        {"Smithsonian Astrophysical Observation", "SAO 23640"},
        {"Wilson Evans Batten Catalogue", "WEB 2651"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.42548991),
        dec: Angle.Degrees(+53.92710635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113437"},
        {"Hipparcos Number", "HIP 63664"},
        {"Smithsonian Astrophysical Observation", "SAO 28616"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.865,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.71876631),
        dec: Angle.Degrees(+53.92820810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136921"},
        {"Hipparcos Number", "HIP 75121"},
        {"Smithsonian Astrophysical Observation", "SAO 29493"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.26548568),
        dec: Angle.Degrees(+53.92848412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235973"},
        {"Hipparcos Number", "HIP 112760"},
        {"Smithsonian Astrophysical Observation", "SAO 34863"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.54065983),
        dec: Angle.Degrees(+53.92930175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92667"},
        {"Hipparcos Number", "HIP 52434"},
        {"Smithsonian Astrophysical Observation", "SAO 27746"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.78610201),
        dec: Angle.Degrees(+53.92978559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70547"},
        {"Hipparcos Number", "HIP 41267"},
        {"Geneva Identification System", "GEN# +1.00070547"},
        {"Smithsonian Astrophysical Observation", "SAO 26826"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.28964576),
        dec: Angle.Degrees(+53.93165079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219383"},
        {"Hipparcos Number", "HIP 114760"},
        {"Geneva Identification System", "GEN# +1.00219383"},
        {"Smithsonian Astrophysical Observation", "SAO 35258"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.69051115),
        dec: Angle.Degrees(+53.93305751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149731"},
        {"Hipparcos Number", "HIP 81103"},
        {"Smithsonian Astrophysical Observation", "SAO 29990"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.47876469),
        dec: Angle.Degrees(+53.93365592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208502"},
        {"Hipparcos Number", "HIP 108174"},
        {"Geneva Identification System", "GEN# +1.00208502"},
        {"Smithsonian Astrophysical Observation", "SAO 33865"},
        {"Wilson Evans Batten Catalogue", "WEB 19499"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.74830196),
        dec: Angle.Degrees(+53.93539119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 149.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 87.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234760"},
        {"Hipparcos Number", "HIP 93048"},
        {"Smithsonian Astrophysical Observation", "SAO 31287"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.30789046),
        dec: Angle.Degrees(+53.93589914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35059"},
        {"Hipparcos Number", "HIP 25315"},
        {"Geneva Identification System", "GEN# +1.00035059"},
        {"Smithsonian Astrophysical Observation", "SAO 25181"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.22902052),
        dec: Angle.Degrees(+53.93875634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84736"},
        {"Hipparcos Number", "HIP 48148"},
        {"Smithsonian Astrophysical Observation", "SAO 27386"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.22438861),
        dec: Angle.Degrees(+53.94062386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125577"},
        {"Hipparcos Number", "HIP 69928"},
        {"Smithsonian Astrophysical Observation", "SAO 29095"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.65695823),
        dec: Angle.Degrees(+53.94068301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17198"},
        {"Hipparcos Number", "HIP 13049"},
        {"Smithsonian Astrophysical Observation", "SAO 23611"},
        {"Wilson Evans Batten Catalogue", "WEB 2633"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.729,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.91142708),
        dec: Angle.Degrees(+53.94328803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212810"},
        {"Hipparcos Number", "HIP 110713"},
        {"Geneva Identification System", "GEN# +1.00212810"},
        {"Smithsonian Astrophysical Observation", "SAO 34441"},
        {"Wilson Evans Batten Catalogue", "WEB 19837"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.46968797),
        dec: Angle.Degrees(+53.94461038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1192"},
        {"Hipparcos Number", "HIP 1310"},
        {"Geneva Identification System", "GEN# +1.00001192"},
        {"Smithsonian Astrophysical Observation", "SAO 21261"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.10711665),
        dec: Angle.Degrees(+53.94564794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234831"},
        {"Hipparcos Number", "HIP 94359"},
        {"Smithsonian Astrophysical Observation", "SAO 31473"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.08934597),
        dec: Angle.Degrees(+53.94783110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102078"},
        {"Hipparcos Number", "HIP 57323"},
        {"Smithsonian Astrophysical Observation", "SAO 28124"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.30448966),
        dec: Angle.Degrees(+53.94802349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232834"},
        {"Hipparcos Number", "HIP 17706"},
        {"Smithsonian Astrophysical Observation", "SAO 24216"},
    },
    visualMagnitude: 10.28,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.88143404),
        dec: Angle.Degrees(+53.94927224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 192.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -183.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234491"},
        {"Hipparcos Number", "HIP 86959"},
        {"Smithsonian Astrophysical Observation", "SAO 30562"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.54366428),
        dec: Angle.Degrees(+53.94972585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170645"},
        {"Hipparcos Number", "HIP 90473"},
        {"Geneva Identification System", "GEN# +1.00170645"},
        {"Smithsonian Astrophysical Observation", "SAO 30985"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.91750008),
        dec: Angle.Degrees(+53.95103859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203356"},
        {"Hipparcos Number", "HIP 105309"},
        {"Geneva Identification System", "GEN# +1.00203356"},
        {"Smithsonian Astrophysical Observation", "SAO 33327"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.93724876),
        dec: Angle.Degrees(+53.95150630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85758",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85758"},
    },
    visualMagnitude: 9.99,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.85935910),
        dec: Angle.Degrees(+53.95202457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10636"},
        {"Hipparcos Number", "HIP 8182"},
        {"Geneva Identification System", "GEN# +1.00010636"},
        {"Wilson Evans Batten Catalogue", "WEB 1743"},
    },
    visualMagnitude: 9.89,
    bvColour: 1.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.29165696),
        dec: Angle.Degrees(+53.95239988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116512",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16864 AB"},
        {"Henry Draper", "HD 221999"},
        {"Hipparcos Number", "HIP 116512"},
        {"Smithsonian Astrophysical Observation", "SAO 35596"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.15528652),
        dec: Angle.Degrees(+53.95309044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113637"},
        {"Hipparcos Number", "HIP 63777"},
        {"Smithsonian Astrophysical Observation", "SAO 28624"},
        {"Wilson Evans Batten Catalogue", "WEB 11282"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.08316957),
        dec: Angle.Degrees(+53.95425628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87662",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10888 AB"},
        {"Henry Draper", "HD 234516"},
        {"Hipparcos Number", "HIP 87662"},
        {"Smithsonian Astrophysical Observation", "SAO 30634"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.57661927),
        dec: Angle.Degrees(+53.95535035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234558"},
        {"Hipparcos Number", "HIP 88626"},
        {"Smithsonian Astrophysical Observation", "SAO 30745"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.42936068),
        dec: Angle.Degrees(+53.95576106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232254"},
        {"Hipparcos Number", "HIP 3294"},
        {"Smithsonian Astrophysical Observation", "SAO 21635"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.50759980),
        dec: Angle.Degrees(+53.95920193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236250"},
        {"Hipparcos Number", "HIP 118036"},
        {"Fundamental Katalog 5th Edition", "FK5 6122"},
        {"Geneva Identification System", "GEN# +1.00236250"},
        {"Smithsonian Astrophysical Observation", "SAO 35910"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.14007876),
        dec: Angle.Degrees(+53.96017089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2773"},
        {"Hipparcos Number", "HIP 2503"},
        {"Smithsonian Astrophysical Observation", "SAO 21488"},
    },
    visualMagnitude: 7.58,
    bvColour: -0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.93431165),
        dec: Angle.Degrees(+53.96166426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117933"},
        {"Hipparcos Number", "HIP 66049"},
        {"Smithsonian Astrophysical Observation", "SAO 28792"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.12592296),
        dec: Angle.Degrees(+53.96220023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200803"},
        {"Hipparcos Number", "HIP 103946"},
        {"Smithsonian Astrophysical Observation", "SAO 33097"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.91191428),
        dec: Angle.Degrees(+53.96395465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44188"},
        {"Hipparcos Number", "HIP 30404"},
        {"Geneva Identification System", "GEN# +1.00044188"},
        {"Smithsonian Astrophysical Observation", "SAO 25700"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.89547221),
        dec: Angle.Degrees(+53.96637584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143915"},
        {"Hipparcos Number", "HIP 78410"},
        {"Smithsonian Astrophysical Observation", "SAO 29748"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.10341231),
        dec: Angle.Degrees(+53.96668854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94888",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12315 AB"},
        {"Henry Draper", "HD 181676"},
        {"Hipparcos Number", "HIP 94888"},
        {"Smithsonian Astrophysical Observation", "SAO 31563"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.64951215),
        dec: Angle.Degrees(+53.96825850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206383"},
        {"Hipparcos Number", "HIP 106980"},
        {"Celescope Catalog", "CEL 5364"},
        {"Geneva Identification System", "GEN# +1.00206383"},
        {"Smithsonian Astrophysical Observation", "SAO 33646"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.00498110),
        dec: Angle.Degrees(+53.96900931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183786"},
        {"Hipparcos Number", "HIP 95737"},
        {"Geneva Identification System", "GEN# +1.00183786"},
        {"Smithsonian Astrophysical Observation", "SAO 31688"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.09379955),
        dec: Angle.Degrees(+53.97031268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138554"},
        {"Hipparcos Number", "HIP 75930"},
        {"Fundamental Katalog 5th Edition", "FK5 5373"},
        {"Geneva Identification System", "GEN# +1.00138554"},
        {"Smithsonian Astrophysical Observation", "SAO 29551"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.62465787),
        dec: Angle.Degrees(+53.97141198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 88.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44147",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44147"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.85759532),
        dec: Angle.Degrees(+53.97159608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76594"},
        {"Hipparcos Number", "HIP 44140"},
        {"Smithsonian Astrophysical Observation", "SAO 27071"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.84881365),
        dec: Angle.Degrees(+53.97181937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232215"},
        {"Hipparcos Number", "HIP 2620"},
        {"Smithsonian Astrophysical Observation", "SAO 21515"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.31231925),
        dec: Angle.Degrees(+53.97327430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184071"},
        {"Hipparcos Number", "HIP 95878"},
        {"Geneva Identification System", "GEN# +1.00184071"},
        {"Smithsonian Astrophysical Observation", "SAO 31708"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.49342430),
        dec: Angle.Degrees(+53.97454773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206"},
        {"Hipparcos Number", "HIP 576"},
        {"Smithsonian Astrophysical Observation", "SAO 21098"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.74865205),
        dec: Angle.Degrees(+53.97486354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42271"},
        {"Hipparcos Number", "HIP 29491"},
        {"Smithsonian Astrophysical Observation", "SAO 25618"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.21978908),
        dec: Angle.Degrees(+53.97692525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22222"},
        {"Hipparcos Number", "HIP 16874"},
        {"Geneva Identification System", "GEN# +1.00022222"},
        {"Smithsonian Astrophysical Observation", "SAO 24124"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.28330943),
        dec: Angle.Degrees(+53.98330462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211030"},
        {"Hipparcos Number", "HIP 109669"},
        {"Geneva Identification System", "GEN# +1.00211030"},
        {"Smithsonian Astrophysical Observation", "SAO 34181"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.24498566),
        dec: Angle.Degrees(+53.98453931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66122",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66122"},
        {"Geneva Identification System", "GEN# +0.05401607"},
        {"Wilson Evans Batten Catalogue", "WEB 11685"},
    },
    visualMagnitude: 11.05,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.32546176),
        dec: Angle.Degrees(+53.98749197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24733"},
        {"Hipparcos Number", "HIP 18585"},
        {"Geneva Identification System", "GEN# +1.00024733"},
        {"Smithsonian Astrophysical Observation", "SAO 24324"},
        {"Wilson Evans Batten Catalogue", "WEB 3582"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.65917115),
        dec: Angle.Degrees(+53.98873615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235106"},
        {"Hipparcos Number", "HIP 99163"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.97999240),
        dec: Angle.Degrees(+53.98986470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90302"},
        {"Hipparcos Number", "HIP 51137"},
        {"Smithsonian Astrophysical Observation", "SAO 27644"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.69913553),
        dec: Angle.Degrees(+53.99380643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209375"},
        {"Hipparcos Number", "HIP 108731"},
        {"Smithsonian Astrophysical Observation", "SAO 33977"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.38421227),
        dec: Angle.Degrees(+53.99443001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208253"},
        {"Hipparcos Number", "HIP 108039"},
        {"Geneva Identification System", "GEN# +1.00208253"},
        {"Smithsonian Astrophysical Observation", "SAO 33835"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.33259525),
        dec: Angle.Degrees(+53.99721034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202923"},
        {"Hipparcos Number", "HIP 105064"},
        {"Celescope Catalog", "CEL 5286"},
        {"Geneva Identification System", "GEN# +1.00202923"},
        {"Smithsonian Astrophysical Observation", "SAO 33281"},
        {"Wilson Evans Batten Catalogue", "WEB 19085"},
    },
    visualMagnitude: 6.12,
    bvColour: 0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.25839686),
        dec: Angle.Degrees(+53.99759750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234660"},
        {"Hipparcos Number", "HIP 90580"},
        {"Smithsonian Astrophysical Observation", "SAO 31000"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.24797978),
        dec: Angle.Degrees(+53.99802822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234992"},
        {"Hipparcos Number", "HIP 97114"},
        {"Smithsonian Astrophysical Observation", "SAO 31941"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.05086778),
        dec: Angle.Degrees(+53.99869006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232819"},
        {"Hipparcos Number", "HIP 17200"},
        {"Smithsonian Astrophysical Observation", "SAO 24156"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.26197801),
        dec: Angle.Degrees(+54.00112940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233599"},
        {"Hipparcos Number", "HIP 44679"},
        {"Smithsonian Astrophysical Observation", "SAO 27117"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.58463408),
        dec: Angle.Degrees(+54.00333317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10852"},
        {"Hipparcos Number", "HIP 8357"},
        {"Celescope Catalog", "CEL 167"},
        {"Smithsonian Astrophysical Observation", "SAO 22627"},
    },
    visualMagnitude: 7.44,
    bvColour: -0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.92628208),
        dec: Angle.Degrees(+54.00451056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236108"},
        {"Hipparcos Number", "HIP 115421"},
        {"Smithsonian Astrophysical Observation", "SAO 35365"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.70662397),
        dec: Angle.Degrees(+54.00659817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25602"},
        {"Hipparcos Number", "HIP 19172"},
        {"Geneva Identification System", "GEN# +1.00025602"},
        {"Smithsonian Astrophysical Observation", "SAO 24411"},
        {"Wilson Evans Batten Catalogue", "WEB 3681"},
    },
    visualMagnitude: 6.31,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.65242780),
        dec: Angle.Degrees(+54.00888446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97115",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97115"},
        {"Smithsonian Astrophysical Observation", "SAO 31942"},
    },
    visualMagnitude: 9.87,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.05517848),
        dec: Angle.Degrees(+54.01096423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117032",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117032"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.87474387),
        dec: Angle.Degrees(+54.01347675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205222"},
        {"Hipparcos Number", "HIP 106322"},
        {"Geneva Identification System", "GEN# +1.00205222"},
        {"Smithsonian Astrophysical Observation", "SAO 33511"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.01614411),
        dec: Angle.Degrees(+54.01554881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221875"},
        {"Hipparcos Number", "HIP 116425"},
        {"Geneva Identification System", "GEN# +1.00221875"},
        {"Smithsonian Astrophysical Observation", "SAO 35573"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.87274720),
        dec: Angle.Degrees(+54.01587848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81104"},
        {"Hipparcos Number", "HIP 46239"},
        {"Smithsonian Astrophysical Observation", "SAO 27249"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.40784258),
        dec: Angle.Degrees(+54.01597407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9234"},
        {"Hipparcos Number", "HIP 7145"},
        {"Smithsonian Astrophysical Observation", "SAO 22364"},
        {"Wilson Evans Batten Catalogue", "WEB 1542"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.02285202),
        dec: Angle.Degrees(+54.01896745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236160"},
        {"Hipparcos Number", "HIP 116139"},
        {"Smithsonian Astrophysical Observation", "SAO 35518"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.98132036),
        dec: Angle.Degrees(+54.01945316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137928"},
        {"Hipparcos Number", "HIP 75587"},
        {"Geneva Identification System", "GEN# +1.00137928"},
        {"Smithsonian Astrophysical Observation", "SAO 29527"},
        {"Wilson Evans Batten Catalogue", "WEB 12881"},
    },
    visualMagnitude: 6.44,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.63405177),
        dec: Angle.Degrees(+54.02032734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236233"},
        {"Hipparcos Number", "HIP 117626"},
        {"Smithsonian Astrophysical Observation", "SAO 35839"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.83290957),
        dec: Angle.Degrees(+54.02100857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63208",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63208"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.25576362),
        dec: Angle.Degrees(+54.08481446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135400"},
        {"Hipparcos Number", "HIP 74424"},
        {"Smithsonian Astrophysical Observation", "SAO 29445"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.15406090),
        dec: Angle.Degrees(+54.02116167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79439"},
        {"Hipparcos Number", "HIP 45493"},
        {"Fundamental Katalog 5th Edition", "FK5 2734"},
        {"Geneva Identification System", "GEN# +1.00079439"},
        {"Renson", "Renson 22540"},
        {"Smithsonian Astrophysical Observation", "SAO 27191"},
        {"Wilson Evans Batten Catalogue", "WEB 8651"},
    },
    visualMagnitude: 4.80,
    bvColour: 0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.04699516),
        dec: Angle.Degrees(+54.02171207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169353"},
        {"Hipparcos Number", "HIP 89965"},
        {"Smithsonian Astrophysical Observation", "SAO 30916"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.33585199),
        dec: Angle.Degrees(+54.02263917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128998"},
        {"Hipparcos Number", "HIP 71573"},
        {"Fundamental Katalog 5th Edition", "FK5 3161"},
        {"Geneva Identification System", "GEN# +1.00128998"},
        {"Smithsonian Astrophysical Observation", "SAO 29227"},
        {"Wilson Evans Batten Catalogue", "WEB 12343"},
    },
    visualMagnitude: 5.83,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.56335468),
        dec: Angle.Degrees(+54.02338576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33553"},
        {"Hipparcos Number", "HIP 24406"},
        {"Smithsonian Astrophysical Observation", "SAO 25085"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.54183162),
        dec: Angle.Degrees(+54.02458477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95968",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12566 AB"},
        {"Henry Draper", "HD 184274"},
        {"Hipparcos Number", "HIP 95968"},
        {"Smithsonian Astrophysical Observation", "SAO 31733"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.73057922),
        dec: Angle.Degrees(+54.02664854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235586"},
        {"Hipparcos Number", "HIP 107012"},
        {"Smithsonian Astrophysical Observation", "SAO 33651"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.10124798),
        dec: Angle.Degrees(+54.02984968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220485"},
        {"Hipparcos Number", "HIP 115484"},
        {"Smithsonian Astrophysical Observation", "SAO 35378"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.91002962),
        dec: Angle.Degrees(+54.03096165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235324"},
        {"Hipparcos Number", "HIP 102140"},
        {"Smithsonian Astrophysical Observation", "SAO 32803"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.46170252),
        dec: Angle.Degrees(+54.03126203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235171"},
        {"Hipparcos Number", "HIP 100052"},
        {"Smithsonian Astrophysical Observation", "SAO 32446"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.47903104),
        dec: Angle.Degrees(+54.03163415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143031"},
        {"Hipparcos Number", "HIP 77970"},
        {"Geneva Identification System", "GEN# +1.00143031"},
        {"Smithsonian Astrophysical Observation", "SAO 29713"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.84649177),
        dec: Angle.Degrees(+54.03180387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38462"},
        {"Hipparcos Number", "HIP 27469"},
        {"Fundamental Katalog 5th Edition", "FK5 4533"},
        {"Geneva Identification System", "GEN# +1.00038462"},
        {"Smithsonian Astrophysical Observation", "SAO 25391"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.26276389),
        dec: Angle.Degrees(+54.03251774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38720"},
        {"Hipparcos Number", "HIP 27615"},
        {"Smithsonian Astrophysical Observation", "SAO 25405"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.70890432),
        dec: Angle.Degrees(+54.03260556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152612"},
        {"Hipparcos Number", "HIP 82484"},
        {"Smithsonian Astrophysical Observation", "SAO 30128"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.86369145),
        dec: Angle.Degrees(+54.03366407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56442"},
        {"Hipparcos Number", "HIP 35536"},
        {"Smithsonian Astrophysical Observation", "SAO 26282"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.00337384),
        dec: Angle.Degrees(+54.03639853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213720"},
        {"Hipparcos Number", "HIP 111247"},
        {"Geneva Identification System", "GEN# +1.00213720"},
        {"Smithsonian Astrophysical Observation", "SAO 34555"},
        {"Wilson Evans Batten Catalogue", "WEB 19902"},
    },
    visualMagnitude: 6.41,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.07786312),
        dec: Angle.Degrees(+54.03699711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206040"},
        {"Hipparcos Number", "HIP 106771"},
        {"Geneva Identification System", "GEN# +1.00206040"},
        {"Smithsonian Astrophysical Observation", "SAO 33596"},
        {"Wilson Evans Batten Catalogue", "WEB 19302"},
    },
    visualMagnitude: 6.16,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.41172383),
        dec: Angle.Degrees(+54.04219399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82502"},
        {"Hipparcos Number", "HIP 46962"},
        {"Smithsonian Astrophysical Observation", "SAO 27296"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.57879678),
        dec: Angle.Degrees(+54.04651215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33976",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5704 AB"},
        {"Henry Draper", "HD 52122"},
        {"Hipparcos Number", "HIP 33976"},
        {"Smithsonian Astrophysical Observation", "SAO 26117"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.75477003),
        dec: Angle.Degrees(+54.04879437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234403"},
        {"Hipparcos Number", "HIP 84003"},
        {"Smithsonian Astrophysical Observation", "SAO 30276"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.57205330),
        dec: Angle.Degrees(+54.05047664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11140"},
        {"Hipparcos Number", "HIP 8604"},
        {"Geneva Identification System", "GEN# +1.00011140"},
        {"Renson", "Renson 2750"},
        {"Smithsonian Astrophysical Observation", "SAO 22677"},
    },
    visualMagnitude: 8.59,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.74910186),
        dec: Angle.Degrees(+54.05060643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232968"},
        {"Hipparcos Number", "HIP 21068"},
        {"Smithsonian Astrophysical Observation", "SAO 24660"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.74408092),
        dec: Angle.Degrees(+54.05106275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234167"},
        {"Hipparcos Number", "HIP 71599"},
        {"Smithsonian Astrophysical Observation", "SAO 29230"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.64794592),
        dec: Angle.Degrees(+54.05835976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48402",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7545 AB"},
        {"Aitken 2", "ADS 7545"},
        {"Henry Draper", "HD 85235"},
        {"Hipparcos Number", "HIP 48402"},
        {"Geneva Identification System", "GEN# +1.00085235J"},
        {"Smithsonian Astrophysical Observation", "SAO 27408"},
        {"Wilson Evans Batten Catalogue", "WEB 9026"},
    },
    visualMagnitude: 4.55,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.02650069),
        dec: Angle.Degrees(+54.06428574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3051"},
        {"Hipparcos Number", "HIP 2697"},
        {"Smithsonian Astrophysical Observation", "SAO 21528"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.55279471),
        dec: Angle.Degrees(+54.06650188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79142"},
        {"Hipparcos Number", "HIP 45337"},
        {"Geneva Identification System", "GEN# +1.00079142"},
        {"Smithsonian Astrophysical Observation", "SAO 27175"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.59223512),
        dec: Angle.Degrees(+54.06899181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68789"},
        {"Hipparcos Number", "HIP 40536"},
        {"Smithsonian Astrophysical Observation", "SAO 26749"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.14843943),
        dec: Angle.Degrees(+54.07226376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232306"},
        {"Hipparcos Number", "HIP 4206"},
        {"Smithsonian Astrophysical Observation", "SAO 21812"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.41940508),
        dec: Angle.Degrees(+54.07407306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20918"},
        {"Hipparcos Number", "HIP 15903"},
        {"Smithsonian Astrophysical Observation", "SAO 24014"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.20656007),
        dec: Angle.Degrees(+54.07589326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17090"},
        {"Hipparcos Number", "HIP 12957"},
        {"Geneva Identification System", "GEN# +1.00017090"},
        {"Smithsonian Astrophysical Observation", "SAO 23599"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.64921581),
        dec: Angle.Degrees(+54.07772367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1044"},
        {"Hipparcos Number", "HIP 1202"},
        {"Geneva Identification System", "GEN# +1.00001044"},
        {"Smithsonian Astrophysical Observation", "SAO 21247"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.75793331),
        dec: Angle.Degrees(+54.07844872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18725",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18725"},
    },
    visualMagnitude: 10.40,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.17230623),
        dec: Angle.Degrees(+54.78659571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111405",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16073 AB"},
        {"Henry Draper", "HD 213990"},
        {"Hipparcos Number", "HIP 111405"},
        {"Geneva Identification System", "GEN# +1.00213990J"},
        {"Smithsonian Astrophysical Observation", "SAO 34577"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.54193351),
        dec: Angle.Degrees(+54.08529009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233511"},
        {"Hipparcos Number", "HIP 40778"},
        {"Cincinnati Publication", "Ci 20 469"},
        {"Geneva Identification System", "GEN# +1.00233511"},
        {"Smithsonian Astrophysical Observation", "SAO 26771"},
        {"Wilson Evans Batten Catalogue", "WEB 7915"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.84418936),
        dec: Angle.Degrees(+54.08753341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -628.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233392"},
        {"Hipparcos Number", "HIP 36380"},
        {"Smithsonian Astrophysical Observation", "SAO 26365"},
    },
    visualMagnitude: 9.68,
    bvColour: 1.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.31224011),
        dec: Angle.Degrees(+54.08768786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37995"},
        {"Hipparcos Number", "HIP 27177"},
        {"Geneva Identification System", "GEN# +1.00037995"},
        {"Smithsonian Astrophysical Observation", "SAO 25357"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.40049932),
        dec: Angle.Degrees(+54.08810823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57309"},
        {"Hipparcos Number", "HIP 35868"},
        {"Fundamental Katalog 5th Edition", "FK5 4666"},
        {"Geneva Identification System", "GEN# +1.00057309"},
        {"Smithsonian Astrophysical Observation", "SAO 26320"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.92336394),
        dec: Angle.Degrees(+54.09174745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235371"},
        {"Hipparcos Number", "HIP 102709"},
        {"Smithsonian Astrophysical Observation", "SAO 32910"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.17275078),
        dec: Angle.Degrees(+54.09229080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 149.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 216.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77971",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77971"},
    },
    visualMagnitude: 11.35,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.84827588),
        dec: Angle.Degrees(+54.09398720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -165.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14135"},
        {"Hipparcos Number", "HIP 10791"},
        {"Smithsonian Astrophysical Observation", "SAO 23177"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.73195523),
        dec: Angle.Degrees(+54.09561875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46217"},
        {"Hipparcos Number", "HIP 31433"},
        {"Geneva Identification System", "GEN# +1.00046217"},
        {"Smithsonian Astrophysical Observation", "SAO 25820"},
        {"Wilson Evans Batten Catalogue", "WEB 6289"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.79642161),
        dec: Angle.Degrees(+54.09625080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104881"},
        {"Hipparcos Number", "HIP 58887"},
        {"Geneva Identification System", "GEN# +1.00104881"},
        {"Smithsonian Astrophysical Observation", "SAO 28234"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.16420553),
        dec: Angle.Degrees(+54.09672411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63143",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8710 AB"},
        {"Henry Draper", "HD 112486"},
        {"Hipparcos Number", "HIP 63143"},
        {"Geneva Identification System", "GEN# +1.00112486J"},
        {"Smithsonian Astrophysical Observation", "SAO 28572"},
        {"Wilson Evans Batten Catalogue", "WEB 11195"},
    },
    visualMagnitude: 5.84,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.07350869),
        dec: Angle.Degrees(+54.09948306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234469"},
        {"Hipparcos Number", "HIP 86354"},
        {"Smithsonian Astrophysical Observation", "SAO 30496"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.68827897),
        dec: Angle.Degrees(+54.10215353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233310"},
        {"Hipparcos Number", "HIP 33637"},
        {"Smithsonian Astrophysical Observation", "SAO 26080"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.82011038),
        dec: Angle.Degrees(+54.10474459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96832"},
        {"Hipparcos Number", "HIP 54552"},
        {"Geneva Identification System", "GEN# +1.00096832"},
        {"Smithsonian Astrophysical Observation", "SAO 27932"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.866,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.44638098),
        dec: Angle.Degrees(+54.10659270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17210"},
        {"Hipparcos Number", "HIP 13054"},
        {"Smithsonian Astrophysical Observation", "SAO 23612"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.93936663),
        dec: Angle.Degrees(+54.10711962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209203"},
        {"Hipparcos Number", "HIP 108602"},
        {"Geneva Identification System", "GEN# +1.00209203"},
        {"Smithsonian Astrophysical Observation", "SAO 33955"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.00949487),
        dec: Angle.Degrees(+54.10761169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19195"},
        {"Hipparcos Number", "HIP 14517"},
        {"Smithsonian Astrophysical Observation", "SAO 23817"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.87132385),
        dec: Angle.Degrees(+54.11134789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9859"},
        {"Hipparcos Number", "HIP 7577"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.40067099),
        dec: Angle.Degrees(+54.11254549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47747"},
        {"Hipparcos Number", "HIP 32195"},
        {"Geneva Identification System", "GEN# +1.00047747"},
        {"Smithsonian Astrophysical Observation", "SAO 25901"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.81296920),
        dec: Angle.Degrees(+54.11296221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235541"},
        {"Hipparcos Number", "HIP 106405"},
        {"Smithsonian Astrophysical Observation", "SAO 33523"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.27079355),
        dec: Angle.Degrees(+54.11342721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71554"},
        {"Hipparcos Number", "HIP 41729"},
        {"Geneva Identification System", "GEN# +1.00071554"},
        {"Smithsonian Astrophysical Observation", "SAO 26876"},
    },
    visualMagnitude: 6.76,
    bvColour: -0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.64264582),
        dec: Angle.Degrees(+54.11918199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39715",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6578 AB"},
        {"Henry Draper", "HD 66610"},
        {"Hipparcos Number", "HIP 39715"},
        {"Smithsonian Astrophysical Observation", "SAO 26670"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.76865548),
        dec: Angle.Degrees(+54.11986612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2901"},
        {"Hipparcos Number", "HIP 2581"},
        {"Geneva Identification System", "GEN# +1.00002901"},
        {"Smithsonian Astrophysical Observation", "SAO 21506"},
        {"Wilson Evans Batten Catalogue", "WEB 474"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.19773113),
        dec: Angle.Degrees(+54.12003466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236023"},
        {"Hipparcos Number", "HIP 113716"},
        {"Smithsonian Astrophysical Observation", "SAO 35073"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.45990569),
        dec: Angle.Degrees(+54.12135728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82862"},
        {"Hipparcos Number", "HIP 47160"},
        {"Geneva Identification System", "GEN# +1.00082862"},
        {"Smithsonian Astrophysical Observation", "SAO 27310"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.14113505),
        dec: Angle.Degrees(+54.12208232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63332"},
        {"Hipparcos Number", "HIP 38325"},
        {"Geneva Identification System", "GEN# +1.00063332"},
        {"Smithsonian Astrophysical Observation", "SAO 26535"},
        {"Wilson Evans Batten Catalogue", "WEB 7540"},
    },
    visualMagnitude: 6.03,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.77396083),
        dec: Angle.Degrees(+54.12911093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
