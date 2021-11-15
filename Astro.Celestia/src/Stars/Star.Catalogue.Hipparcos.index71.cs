using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_71() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84748"},
        {"Hipparcos Number", "HIP 48036"},
        {"Geneva Identification System", "GEN# +1.00084748"},
        {"Smithsonian Astrophysical Observation", "SAO 98769"},
        {"Wilson Evans Batten Catalogue", "WEB 8985"},
    },
    visualMagnitude: 10.35,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.88954476),
        dec: Angle.Degrees(+11.42889439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138759"},
        {"Hipparcos Number", "HIP 76193"},
        {"Smithsonian Astrophysical Observation", "SAO 101617"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.45444268),
        dec: Angle.Degrees(+11.42934516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99196"},
        {"Hipparcos Number", "HIP 55716"},
        {"Fundamental Katalog 5th Edition", "FK5 2912"},
        {"Geneva Identification System", "GEN# +1.00099196"},
        {"Smithsonian Astrophysical Observation", "SAO 99598"},
        {"Wilson Evans Batten Catalogue", "WEB 10015"},
    },
    visualMagnitude: 5.80,
    bvColour: 1.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.24577834),
        dec: Angle.Degrees(+11.43030968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77847",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77847"},
        {"Smithsonian Astrophysical Observation", "SAO 101797"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.42017560),
        dec: Angle.Degrees(+11.43064908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130318"},
        {"Hipparcos Number", "HIP 72306"},
        {"Geneva Identification System", "GEN# +1.00130318"},
        {"Smithsonian Astrophysical Observation", "SAO 101210"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.79133284),
        dec: Angle.Degrees(+11.43087741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69056"},
        {"Hipparcos Number", "HIP 40452"},
        {"Geneva Identification System", "GEN# +1.00069056"},
        {"Smithsonian Astrophysical Observation", "SAO 97681"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.731,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.88884531),
        dec: Angle.Degrees(+11.43151587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -198.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -233.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33223",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5565 AB"},
        {"Henry Draper", "HD 50694"},
        {"Hipparcos Number", "HIP 33223"},
        {"Smithsonian Astrophysical Observation", "SAO 96268"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.70032463),
        dec: Angle.Degrees(+11.43239938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83084"},
        {"Hipparcos Number", "HIP 47143"},
        {"Geneva Identification System", "GEN# +1.00083084"},
        {"Smithsonian Astrophysical Observation", "SAO 98669"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.09144691),
        dec: Angle.Degrees(+11.43257995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90033",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90033"},
        {"Smithsonian Astrophysical Observation", "SAO 103645"},
        {"Wilson Evans Batten Catalogue", "WEB 15382"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.55949526),
        dec: Angle.Degrees(+11.43353697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78672",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9908 A"},
        {"Henry Draper", "HD 144064"},
        {"Hipparcos Number", "HIP 78672"},
        {"Smithsonian Astrophysical Observation", "SAO 101898"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.91517202),
        dec: Angle.Degrees(+11.43363133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39040",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39040"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.751,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.81581272),
        dec: Angle.Degrees(+11.43370571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7397",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7397"},
    },
    visualMagnitude: 11.82,
    bvColour: 1.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.83990134),
        dec: Angle.Degrees(+11.43444447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 119.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3434"},
        {"Hipparcos Number", "HIP 2936"},
        {"Smithsonian Astrophysical Observation", "SAO 92001"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.32417347),
        dec: Angle.Degrees(+11.43659254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123643"},
        {"Hipparcos Number", "HIP 69100"},
        {"Smithsonian Astrophysical Observation", "SAO 100867"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.17683389),
        dec: Angle.Degrees(+11.43697988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63758",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63758"},
    },
    visualMagnitude: 9.92,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.02745043),
        dec: Angle.Degrees(+11.43786363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182383"},
        {"Hipparcos Number", "HIP 95364"},
        {"Smithsonian Astrophysical Observation", "SAO 104790"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.01567590),
        dec: Angle.Degrees(+11.44108169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199103"},
        {"Hipparcos Number", "HIP 103203"},
        {"Smithsonian Astrophysical Observation", "SAO 106639"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.64437244),
        dec: Angle.Degrees(+11.44235043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72384",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72384"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.00399916),
        dec: Angle.Degrees(+11.44239470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176445"},
        {"Hipparcos Number", "HIP 93259"},
        {"Geneva Identification System", "GEN# +1.00176445"},
        {"Smithsonian Astrophysical Observation", "SAO 104329"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.96233104),
        dec: Angle.Degrees(+11.44485827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23987"},
        {"Hipparcos Number", "HIP 17904"},
        {"Geneva Identification System", "GEN# +1.00023987"},
        {"Smithsonian Astrophysical Observation", "SAO 93626"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.43425325),
        dec: Angle.Degrees(+11.44653782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73280"},
        {"Hipparcos Number", "HIP 42346"},
        {"Smithsonian Astrophysical Observation", "SAO 97981"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.49686426),
        dec: Angle.Degrees(+11.44968618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167028"},
        {"Hipparcos Number", "HIP 89265"},
        {"Smithsonian Astrophysical Observation", "SAO 103489"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.23844976),
        dec: Angle.Degrees(+11.45162102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16525",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16525"},
    },
    visualMagnitude: 10.64,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.18973371),
        dec: Angle.Degrees(+11.45313519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4461",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4461"},
        {"Smithsonian Astrophysical Observation", "SAO 92175"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.29892232),
        dec: Angle.Degrees(+11.45609127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127843"},
        {"Hipparcos Number", "HIP 71171"},
        {"Smithsonian Astrophysical Observation", "SAO 101076"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.33998067),
        dec: Angle.Degrees(+11.45781156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8127"},
        {"Hipparcos Number", "HIP 6298"},
        {"Smithsonian Astrophysical Observation", "SAO 92383"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.20406129),
        dec: Angle.Degrees(+11.45813806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 112.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36752",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36752"},
        {"Smithsonian Astrophysical Observation", "SAO 97017"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.38817007),
        dec: Angle.Degrees(+11.45876986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 252250"},
        {"Hipparcos Number", "HIP 29111"},
        {"Smithsonian Astrophysical Observation", "SAO 95277"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.881,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.08329052),
        dec: Angle.Degrees(+11.45953565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -285.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66479",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66479"},
        {"Smithsonian Astrophysical Observation", "SAO 100640"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.44335454),
        dec: Angle.Degrees(+11.46346201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115132",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115132"},
        {"Smithsonian Astrophysical Observation", "SAO 108540"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.80461346),
        dec: Angle.Degrees(+11.46549362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108367",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108367"},
        {"Smithsonian Astrophysical Observation", "SAO 107536"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.30553621),
        dec: Angle.Degrees(+11.46639719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7605"},
        {"Hipparcos Number", "HIP 5920"},
        {"Smithsonian Astrophysical Observation", "SAO 92338"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.03644505),
        dec: Angle.Degrees(+11.46723384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286561"},
        {"Hipparcos Number", "HIP 19427"},
        {"Smithsonian Astrophysical Observation", "SAO 93792"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.40876650),
        dec: Angle.Degrees(+11.46750775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66805",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66805"},
        {"Smithsonian Astrophysical Observation", "SAO 100665"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.41092953),
        dec: Angle.Degrees(+11.46815249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193490"},
        {"Hipparcos Number", "HIP 100262"},
        {"Smithsonian Astrophysical Observation", "SAO 105980"},
    },
    visualMagnitude: 6.63,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.04142121),
        dec: Angle.Degrees(+11.46940938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175335"},
        {"Hipparcos Number", "HIP 92796"},
        {"Smithsonian Astrophysical Observation", "SAO 104243"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.62857955),
        dec: Angle.Degrees(+11.46956204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90027",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11292 C"},
        {"Hipparcos Number", "HIP 90027"},
    },
    visualMagnitude: 10.20,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.54096152),
        dec: Angle.Degrees(+11.46963497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65780",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8917 AB"},
        {"Hipparcos Number", "HIP 65780"},
        {"Geneva Identification System", "GEN# +0.01202597"},
        {"Smithsonian Astrophysical Observation", "SAO 100590"},
        {"Wilson Evans Batten Catalogue", "WEB 11641"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.27594606),
        dec: Angle.Degrees(+11.47000288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -194.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -218.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187000"},
        {"Hipparcos Number", "HIP 97355"},
        {"Smithsonian Astrophysical Observation", "SAO 105252"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.81821388),
        dec: Angle.Degrees(+11.47373945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118133",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17125 A"},
        {"Henry Draper", "HD 224429"},
        {"Hipparcos Number", "HIP 118133"},
        {"Geneva Identification System", "GEN# +1.00224429"},
        {"Smithsonian Astrophysical Observation", "SAO 108931"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.44250216),
        dec: Angle.Degrees(+11.47440038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92801",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92801"},
    },
    visualMagnitude: 9.53,
    bvColour: 1.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.63806357),
        dec: Angle.Degrees(+11.47501846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134853"},
        {"Hipparcos Number", "HIP 74366"},
        {"Geneva Identification System", "GEN# +1.00134853"},
        {"Smithsonian Astrophysical Observation", "SAO 101424"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.95815454),
        dec: Angle.Degrees(+11.47513022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130290"},
        {"Hipparcos Number", "HIP 72285"},
        {"Geneva Identification System", "GEN# +1.00130290"},
        {"Smithsonian Astrophysical Observation", "SAO 101208"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.74131537),
        dec: Angle.Degrees(+11.47725631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202492"},
        {"Hipparcos Number", "HIP 104991"},
        {"Smithsonian Astrophysical Observation", "SAO 106975"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.96707424),
        dec: Angle.Degrees(+11.47878743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119824"},
        {"Hipparcos Number", "HIP 67120"},
        {"Smithsonian Astrophysical Observation", "SAO 100692"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.34551271),
        dec: Angle.Degrees(+11.47929652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77597",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77597"},
        {"Smithsonian Astrophysical Observation", "SAO 101768"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.63335787),
        dec: Angle.Degrees(+11.47946181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4884",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4884"},
        {"Smithsonian Astrophysical Observation", "SAO 92216"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.68590525),
        dec: Angle.Degrees(+11.48011202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112785",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112785"},
        {"Smithsonian Astrophysical Observation", "SAO 108210"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.60581463),
        dec: Angle.Degrees(+11.48039651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49243"},
        {"Hipparcos Number", "HIP 32595"},
        {"Smithsonian Astrophysical Observation", "SAO 96122"},
    },
    visualMagnitude: 7.99,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.00008434),
        dec: Angle.Degrees(+11.48291693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286661"},
        {"Hipparcos Number", "HIP 19970"},
        {"Smithsonian Astrophysical Observation", "SAO 93841"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.22815647),
        dec: Angle.Degrees(+11.48399042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54055",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54055"},
        {"Smithsonian Astrophysical Observation", "SAO 99420"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.91946769),
        dec: Angle.Degrees(+11.48503965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39681"},
        {"Hipparcos Number", "HIP 27933"},
        {"Smithsonian Astrophysical Observation", "SAO 94982"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.65262052),
        dec: Angle.Degrees(+11.48555782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160230"},
        {"Hipparcos Number", "HIP 86330"},
        {"Geneva Identification System", "GEN# +1.00160230"},
        {"Smithsonian Astrophysical Observation", "SAO 102984"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.59325923),
        dec: Angle.Degrees(+11.48585492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 230585"},
        {"Hipparcos Number", "HIP 93654"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.06176395),
        dec: Angle.Degrees(+11.48688927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -179.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216673"},
        {"Hipparcos Number", "HIP 113143"},
        {"Smithsonian Astrophysical Observation", "SAO 108247"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.67804942),
        dec: Angle.Degrees(+11.48800522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33944"},
        {"Hipparcos Number", "HIP 24416"},
        {"Smithsonian Astrophysical Observation", "SAO 94411"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.58024705),
        dec: Angle.Degrees(+11.48820008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149161"},
        {"Hipparcos Number", "HIP 81008"},
        {"Fundamental Katalog 5th Edition", "FK5 3310"},
        {"Geneva Identification System", "GEN# +1.00149161"},
        {"Smithsonian Astrophysical Observation", "SAO 102234"},
        {"Wilson Evans Batten Catalogue", "WEB 13701"},
    },
    visualMagnitude: 4.84,
    bvColour: 1.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.15165942),
        dec: Angle.Degrees(+11.48823391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -178.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63079",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8704 B"},
        {"Hipparcos Number", "HIP 63079"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.87101198),
        dec: Angle.Degrees(+11.48991338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146279"},
        {"Hipparcos Number", "HIP 79634"},
        {"Fundamental Katalog 5th Edition", "FK5 5431"},
        {"Geneva Identification System", "GEN# +1.00146279"},
        {"Smithsonian Astrophysical Observation", "SAO 102034"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.75531934),
        dec: Angle.Degrees(+11.49020866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18130"},
        {"Hipparcos Number", "HIP 13586"},
        {"Smithsonian Astrophysical Observation", "SAO 93182"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.75584481),
        dec: Angle.Degrees(+11.49155705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167945"},
        {"Hipparcos Number", "HIP 89600"},
        {"Smithsonian Astrophysical Observation", "SAO 103559"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.26848275),
        dec: Angle.Degrees(+11.49217747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108737"},
        {"Hipparcos Number", "HIP 60945"},
        {"Geneva Identification System", "GEN# +1.00108737"},
        {"Smithsonian Astrophysical Observation", "SAO 100126"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.38468172),
        dec: Angle.Degrees(+11.49249846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33234"},
        {"Hipparcos Number", "HIP 23980"},
        {"Geneva Identification System", "GEN# +1.00033234"},
        {"Smithsonian Astrophysical Observation", "SAO 94355"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.31089124),
        dec: Angle.Degrees(+11.49327175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198403"},
        {"Hipparcos Number", "HIP 102814"},
        {"Smithsonian Astrophysical Observation", "SAO 106539"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.44230903),
        dec: Angle.Degrees(+11.49492417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33221"},
        {"Hipparcos Number", "HIP 23977"},
        {"Geneva Identification System", "GEN# +1.00033221"},
        {"Smithsonian Astrophysical Observation", "SAO 94353"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.30236261),
        dec: Angle.Degrees(+11.49532124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63081",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8704 A"},
        {"Henry Draper", "HD 112278"},
        {"Hipparcos Number", "HIP 63081"},
        {"Geneva Identification System", "GEN# +1.00112278"},
        {"Smithsonian Astrophysical Observation", "SAO 100337"},
        {"Wilson Evans Batten Catalogue", "WEB 11185"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.87640799),
        dec: Angle.Degrees(+11.49588107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79479"},
        {"Hipparcos Number", "HIP 45363"},
        {"Smithsonian Astrophysical Observation", "SAO 98451"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.67081662),
        dec: Angle.Degrees(+11.49681570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18520",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2889 AB"},
        {"Henry Draper", "HD 24873"},
        {"Hipparcos Number", "HIP 18520"},
        {"Smithsonian Astrophysical Observation", "SAO 93690"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.39886305),
        dec: Angle.Degrees(+11.49697676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173610"},
        {"Hipparcos Number", "HIP 92052"},
        {"Smithsonian Astrophysical Observation", "SAO 104072"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.43203862),
        dec: Angle.Degrees(+11.49704146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39156"},
        {"Hipparcos Number", "HIP 27641"},
        {"Geneva Identification System", "GEN# +1.00039156"},
        {"Smithsonian Astrophysical Observation", "SAO 94924"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.828,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.76360080),
        dec: Angle.Degrees(+11.49886298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36048",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36048"},
        {"Smithsonian Astrophysical Observation", "SAO 96887"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.43824701),
        dec: Angle.Degrees(+11.49913311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21335",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3314 AB"},
        {"Henry Draper", "HD 29039"},
        {"Hipparcos Number", "HIP 21335"},
        {"Smithsonian Astrophysical Observation", "SAO 94016"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.68172328),
        dec: Angle.Degrees(+11.49936622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45614",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7285 A"},
        {"Henry Draper", "HD 80064"},
        {"Hipparcos Number", "HIP 45614"},
        {"Geneva Identification System", "GEN# +1.00080064"},
        {"Smithsonian Astrophysical Observation", "SAO 98476"},
        {"Wilson Evans Batten Catalogue", "WEB 8669"},
    },
    visualMagnitude: 6.40,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.46401667),
        dec: Angle.Degrees(+11.50115104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11217",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1831 AB"},
        {"Henry Draper", "HD 14888"},
        {"Hipparcos Number", "HIP 11217"},
        {"Smithsonian Astrophysical Observation", "SAO 92923"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.09420761),
        dec: Angle.Degrees(+11.50187170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37488"},
        {"Hipparcos Number", "HIP 26618"},
        {"Smithsonian Astrophysical Observation", "SAO 94731"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.86466284),
        dec: Angle.Degrees(+11.50298336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 261488"},
        {"Hipparcos Number", "HIP 31873"},
        {"Smithsonian Astrophysical Observation", "SAO 95960"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.93336705),
        dec: Angle.Degrees(+11.50564952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 287296"},
        {"Hipparcos Number", "HIP 23045"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.34824231),
        dec: Angle.Degrees(+11.50991495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221059"},
        {"Hipparcos Number", "HIP 115889"},
        {"Fundamental Katalog 5th Edition", "FK5 6075"},
        {"Geneva Identification System", "GEN# +1.00221059"},
        {"Smithsonian Astrophysical Observation", "SAO 108630"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.19159861),
        dec: Angle.Degrees(+11.51227903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153415"},
        {"Hipparcos Number", "HIP 83117"},
        {"Smithsonian Astrophysical Observation", "SAO 102506"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.77336575),
        dec: Angle.Degrees(+11.51307977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142553"},
        {"Hipparcos Number", "HIP 77922"},
        {"Smithsonian Astrophysical Observation", "SAO 101809"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.70433291),
        dec: Angle.Degrees(+11.51517128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74608",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74608"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.66609459),
        dec: Angle.Degrees(+11.51578121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221444"},
        {"Hipparcos Number", "HIP 116156"},
        {"Smithsonian Astrophysical Observation", "SAO 108663"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.03232624),
        dec: Angle.Degrees(+11.51621345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106209"},
        {"Hipparcos Number", "HIP 59592"},
        {"Geneva Identification System", "GEN# +1.00106209"},
        {"Smithsonian Astrophysical Observation", "SAO 99996"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.30868408),
        dec: Angle.Degrees(+11.51634383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27798"},
        {"Hipparcos Number", "HIP 20511"},
        {"Smithsonian Astrophysical Observation", "SAO 93904"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.93011900),
        dec: Angle.Degrees(+11.51694942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40020"},
        {"Hipparcos Number", "HIP 28139"},
        {"Fundamental Katalog 5th Edition", "FK5 2453"},
        {"Geneva Identification System", "GEN# +1.00040020"},
        {"Smithsonian Astrophysical Observation", "SAO 95027"},
        {"Wilson Evans Batten Catalogue", "WEB 5505"},
    },
    visualMagnitude: 5.89,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.20578119),
        dec: Angle.Degrees(+11.52119572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28067",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4520 AB"},
        {"Henry Draper", "HD 39907"},
        {"Hipparcos Number", "HIP 28067"},
        {"Smithsonian Astrophysical Observation", "SAO 95006"},
    },
    visualMagnitude: 7.55,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.00818723),
        dec: Angle.Degrees(+11.52187536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92434",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11735 AB"},
        {"Henry Draper", "HD 174485"},
        {"Hipparcos Number", "HIP 92434"},
        {"Wilson Evans Batten Catalogue", "WEB 15969"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.56229043),
        dec: Angle.Degrees(+11.52266423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179242"},
        {"Hipparcos Number", "HIP 94284"},
        {"Smithsonian Astrophysical Observation", "SAO 104570"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.85615711),
        dec: Angle.Degrees(+11.52330159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80496"},
        {"Hipparcos Number", "HIP 45809"},
        {"Smithsonian Astrophysical Observation", "SAO 98508"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.764,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.11678616),
        dec: Angle.Degrees(+11.52349026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -194.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100068"},
        {"Hipparcos Number", "HIP 56182"},
        {"Smithsonian Astrophysical Observation", "SAO 99640"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.74152616),
        dec: Angle.Degrees(+11.52375663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73667"},
        {"Hipparcos Number", "HIP 42499"},
        {"Cincinnati Publication", "Ci 20 479"},
        {"Geneva Identification System", "GEN# +1.00073667"},
        {"Smithsonian Astrophysical Observation", "SAO 98015"},
        {"Wilson Evans Batten Catalogue", "WEB 8183"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.832,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.96190355),
        dec: Angle.Degrees(+11.52388749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -109.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -499.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182058"},
        {"Hipparcos Number", "HIP 95227"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.61908312),
        dec: Angle.Degrees(+11.52693414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212597"},
        {"Hipparcos Number", "HIP 110676"},
        {"Geneva Identification System", "GEN# +1.00212597"},
        {"Smithsonian Astrophysical Observation", "SAO 107904"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.33048220),
        dec: Angle.Degrees(+11.52702067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141127"},
        {"Hipparcos Number", "HIP 77314"},
        {"Smithsonian Astrophysical Observation", "SAO 101736"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.76741246),
        dec: Angle.Degrees(+11.52804017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166685"},
        {"Hipparcos Number", "HIP 89128"},
        {"Geneva Identification System", "GEN# +1.00166685"},
        {"Smithsonian Astrophysical Observation", "SAO 103462"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.84922049),
        dec: Angle.Degrees(+11.52875411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35364"},
        {"Hipparcos Number", "HIP 25297"},
        {"Geneva Identification System", "GEN# +1.00035364"},
        {"Smithsonian Astrophysical Observation", "SAO 94530"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.17296674),
        dec: Angle.Degrees(+11.52964859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3674"},
        {"Hipparcos Number", "HIP 3119"},
        {"Geneva Identification System", "GEN# +1.00003674"},
        {"Smithsonian Astrophysical Observation", "SAO 92011"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.91921008),
        dec: Angle.Degrees(+11.53230972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 158.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2792"},
        {"Hipparcos Number", "HIP 2479"},
        {"Geneva Identification System", "GEN# +1.00002792"},
        {"Smithsonian Astrophysical Observation", "SAO 91941"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.87634042),
        dec: Angle.Degrees(+11.53231372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181383"},
        {"Hipparcos Number", "HIP 95002"},
        {"Geneva Identification System", "GEN# +1.00181383"},
        {"Smithsonian Astrophysical Observation", "SAO 104728"},
        {"Wilson Evans Batten Catalogue", "WEB 16593"},
    },
    visualMagnitude: 6.03,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.97100182),
        dec: Angle.Degrees(+11.53491074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6334",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1097 AB"},
        {"Henry Draper", "HD 8187"},
        {"Hipparcos Number", "HIP 6334"},
        {"Geneva Identification System", "GEN# +1.00008187"},
        {"Smithsonian Astrophysical Observation", "SAO 92388"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.33010492),
        dec: Angle.Degrees(+11.53674564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219187"},
        {"Hipparcos Number", "HIP 114676"},
        {"Smithsonian Astrophysical Observation", "SAO 108469"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.46761758),
        dec: Angle.Degrees(+11.54143832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16478",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2591 A"},
        {"Henry Draper", "HD 21915"},
        {"Hipparcos Number", "HIP 16478"},
        {"Smithsonian Astrophysical Observation", "SAO 93479"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.04968204),
        dec: Angle.Degrees(+11.54252545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46089"},
        {"Hipparcos Number", "HIP 31119"},
        {"Geneva Identification System", "GEN# +1.00046089"},
        {"Smithsonian Astrophysical Observation", "SAO 95788"},
        {"Wilson Evans Batten Catalogue", "WEB 6202"},
    },
    visualMagnitude: 5.22,
    bvColour: 0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.95120180),
        dec: Angle.Degrees(+11.54434340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109520"},
        {"Hipparcos Number", "HIP 61423"},
        {"Geneva Identification System", "GEN# +1.00109520"},
        {"Smithsonian Astrophysical Observation", "SAO 100162"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.79474499),
        dec: Angle.Degrees(+11.54774321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5244",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 920 A"},
        {"Henry Draper", "HD 6614"},
        {"Hipparcos Number", "HIP 5244"},
        {"Geneva Identification System", "GEN# +1.00006614"},
        {"Smithsonian Astrophysical Observation", "SAO 92255"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.76642659),
        dec: Angle.Degrees(+11.55208242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125548"},
        {"Hipparcos Number", "HIP 70032"},
        {"Smithsonian Astrophysical Observation", "SAO 100979"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.95187013),
        dec: Angle.Degrees(+11.55272869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14997",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14997"},
        {"Smithsonian Astrophysical Observation", "SAO 93343"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.712,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.32805354),
        dec: Angle.Degrees(+11.55365805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180263"},
        {"Hipparcos Number", "HIP 94650"},
        {"Smithsonian Astrophysical Observation", "SAO 104659"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.89560006),
        dec: Angle.Degrees(+11.55513788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 183.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -173.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114780"},
        {"Hipparcos Number", "HIP 64445"},
        {"Fundamental Katalog 5th Edition", "FK5 3053"},
        {"Geneva Identification System", "GEN# +1.00114780"},
        {"Smithsonian Astrophysical Observation", "SAO 100460"},
        {"Wilson Evans Batten Catalogue", "WEB 11391"},
    },
    visualMagnitude: 5.76,
    bvColour: 1.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.13729799),
        dec: Angle.Degrees(+11.55617035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83789"},
        {"Hipparcos Number", "HIP 47515"},
        {"Geneva Identification System", "GEN# +1.00083789"},
        {"Smithsonian Astrophysical Observation", "SAO 98710"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.29759199),
        dec: Angle.Degrees(+11.55762824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -218.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103778",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103778"},
        {"Fundamental Katalog 5th Edition", "FK5 5853"},
        {"Smithsonian Astrophysical Observation", "SAO 106764"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.44038384),
        dec: Angle.Degrees(+11.55785819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 355759"},
        {"Hipparcos Number", "HIP 97056"},
    },
    visualMagnitude: 10.66,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.87030635),
        dec: Angle.Degrees(+11.55902036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78661"},
        {"Hipparcos Number", "HIP 44984"},
        {"Geneva Identification System", "GEN# +1.00078661"},
        {"Smithsonian Astrophysical Observation", "SAO 98400"},
        {"Wilson Evans Batten Catalogue", "WEB 8592"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.44354427),
        dec: Angle.Degrees(+11.56452847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189282"},
        {"Hipparcos Number", "HIP 98342"},
        {"Geneva Identification System", "GEN# +9.00051017"},
        {"Geneva Identification System 2", "GEN# +9.00060017"},
        {"Smithsonian Astrophysical Observation", "SAO 105499"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.71355534),
        dec: Angle.Degrees(+11.56455829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73376",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73376"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.91815184),
        dec: Angle.Degrees(+11.56589372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197180"},
        {"Hipparcos Number", "HIP 102117"},
        {"Smithsonian Astrophysical Observation", "SAO 106388"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.42289180),
        dec: Angle.Degrees(+11.56620879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84722"},
        {"Hipparcos Number", "HIP 48029"},
        {"Geneva Identification System", "GEN# +1.00084722"},
        {"Smithsonian Astrophysical Observation", "SAO 98767"},
        {"Wilson Evans Batten Catalogue", "WEB 8982"},
    },
    visualMagnitude: 6.44,
    bvColour: 0.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.85831194),
        dec: Angle.Degrees(+11.56817726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107637"},
        {"Hipparcos Number", "HIP 60325"},
        {"Geneva Identification System", "GEN# +1.00107637"},
    },
    visualMagnitude: 9.97,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.53668450),
        dec: Angle.Degrees(+11.56858008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -159.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105200",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14839 AB"},
        {"Henry Draper", "HD 202908"},
        {"Hipparcos Number", "HIP 105200"},
        {"Geneva Identification System", "GEN# +1.00202908J"},
        {"Smithsonian Astrophysical Observation", "SAO 107015"},
        {"Wilson Evans Batten Catalogue", "WEB 19105"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.64522692),
        dec: Angle.Degrees(+11.56894348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77803"},
        {"Hipparcos Number", "HIP 44579"},
        {"Geneva Identification System", "GEN# +1.00077803"},
        {"Smithsonian Astrophysical Observation", "SAO 98344"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.23985166),
        dec: Angle.Degrees(+11.57256154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286705"},
        {"Hipparcos Number", "HIP 20393"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.49905418),
        dec: Angle.Degrees(+11.57302395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145229"},
        {"Hipparcos Number", "HIP 79165"},
        {"Geneva Identification System", "GEN# +1.00145229"},
        {"Smithsonian Astrophysical Observation", "SAO 101968"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.36119623),
        dec: Angle.Degrees(+11.57421532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 100.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1780",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1780"},
        {"Smithsonian Astrophysical Observation", "SAO 91869"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.65710689),
        dec: Angle.Degrees(+11.57704194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93993"},
        {"Hipparcos Number", "HIP 53039"},
        {"Smithsonian Astrophysical Observation", "SAO 99321"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.78565961),
        dec: Angle.Degrees(+11.57885397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63290",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63290"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.751,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.54771099),
        dec: Angle.Degrees(+11.57939923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120703"},
        {"Hipparcos Number", "HIP 67587"},
        {"Smithsonian Astrophysical Observation", "SAO 100737"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.73283305),
        dec: Angle.Degrees(+11.57999155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59180"},
        {"Hipparcos Number", "HIP 36374"},
        {"Smithsonian Astrophysical Observation", "SAO 96939"},
        {"Wilson Evans Batten Catalogue", "WEB 7240"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.30360832),
        dec: Angle.Degrees(+11.58123605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161240"},
        {"Hipparcos Number", "HIP 86774"},
        {"Smithsonian Astrophysical Observation", "SAO 103063"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.97668735),
        dec: Angle.Degrees(+11.58254466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212077"},
        {"Hipparcos Number", "HIP 110390"},
        {"Smithsonian Astrophysical Observation", "SAO 107856"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.39137116),
        dec: Angle.Degrees(+11.58823251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147836"},
        {"Hipparcos Number", "HIP 80310"},
        {"Smithsonian Astrophysical Observation", "SAO 102128"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.94656488),
        dec: Angle.Degrees(+11.59103863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99445"},
        {"Hipparcos Number", "HIP 55837"},
        {"Smithsonian Astrophysical Observation", "SAO 99607"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.66794646),
        dec: Angle.Degrees(+11.59309022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180868"},
        {"Hipparcos Number", "HIP 94834"},
        {"Fundamental Katalog 5th Edition", "FK5 725"},
        {"Geneva Identification System", "GEN# +1.00180868"},
        {"Smithsonian Astrophysical Observation", "SAO 104691"},
        {"Wilson Evans Batten Catalogue", "WEB 16552"},
    },
    visualMagnitude: 5.28,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.45416014),
        dec: Angle.Degrees(+11.59539126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155658"},
        {"Hipparcos Number", "HIP 84193"},
        {"Smithsonian Astrophysical Observation", "SAO 102648"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.15288337),
        dec: Angle.Degrees(+11.59593582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65948",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65948"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.79786165),
        dec: Angle.Degrees(+11.59697063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107256"},
        {"Hipparcos Number", "HIP 60126"},
        {"Geneva Identification System", "GEN# +1.00107256"},
        {"Smithsonian Astrophysical Observation", "SAO 100045"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.96610018),
        dec: Angle.Degrees(+11.59859383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137110"},
        {"Hipparcos Number", "HIP 75354"},
        {"Smithsonian Astrophysical Observation", "SAO 101523"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.97325209),
        dec: Angle.Degrees(+11.59863512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105365",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105365"},
        {"Renson", "Renson 56580"},
        {"Smithsonian Astrophysical Observation", "SAO 107047"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.12763562),
        dec: Angle.Degrees(+11.60016901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79453"},
        {"Hipparcos Number", "HIP 45345"},
        {"Smithsonian Astrophysical Observation", "SAO 98449"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.60706336),
        dec: Angle.Degrees(+11.60032143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139245"},
        {"Hipparcos Number", "HIP 76443"},
        {"Smithsonian Astrophysical Observation", "SAO 101646"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.18655723),
        dec: Angle.Degrees(+11.60106478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126584"},
        {"Hipparcos Number", "HIP 70569"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.755,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.52461583),
        dec: Angle.Degrees(+11.60122646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117030",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117030"},
        {"Smithsonian Astrophysical Observation", "SAO 108790"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.86299950),
        dec: Angle.Degrees(+11.60207356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139423"},
        {"Hipparcos Number", "HIP 76529"},
        {"Smithsonian Astrophysical Observation", "SAO 101655"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.44100437),
        dec: Angle.Degrees(+11.60337828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15983"},
        {"Hipparcos Number", "HIP 11971"},
        {"Fundamental Katalog 5th Edition", "FK5 4233"},
        {"Smithsonian Astrophysical Observation", "SAO 93006"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.60800580),
        dec: Angle.Degrees(+11.60488205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155411"},
        {"Hipparcos Number", "HIP 84050"},
        {"Geneva Identification System", "GEN# +1.00155411"},
        {"Smithsonian Astrophysical Observation", "SAO 102634"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.74734990),
        dec: Angle.Degrees(+11.60585024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178236"},
        {"Hipparcos Number", "HIP 93914"},
        {"Smithsonian Astrophysical Observation", "SAO 104495"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.84164682),
        dec: Angle.Degrees(+11.60590256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107752"},
        {"Hipparcos Number", "HIP 60387"},
        {"Geneva Identification System", "GEN# +1.00107752"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.809,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.71977568),
        dec: Angle.Degrees(+11.60716838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86575"},
        {"Hipparcos Number", "HIP 48988"},
        {"Smithsonian Astrophysical Observation", "SAO 98885"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.91943729),
        dec: Angle.Degrees(+11.60768001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190677"},
        {"Hipparcos Number", "HIP 98991"},
        {"Smithsonian Astrophysical Observation", "SAO 105673"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.44642572),
        dec: Angle.Degrees(+11.60880393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188189"},
        {"Hipparcos Number", "HIP 97897"},
        {"Smithsonian Astrophysical Observation", "SAO 105387"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.42468731),
        dec: Angle.Degrees(+11.60886091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1253",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1253"},
        {"Smithsonian Astrophysical Observation", "SAO 91802"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.92761164),
        dec: Angle.Degrees(+11.60966968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 242780"},
        {"Hipparcos Number", "HIP 24923"},
        {"Smithsonian Astrophysical Observation", "SAO 94471"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.765,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.10580114),
        dec: Angle.Degrees(+11.60985081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139285"},
        {"Hipparcos Number", "HIP 76471"},
        {"Geneva Identification System", "GEN# +1.00139285"},
        {"Smithsonian Astrophysical Observation", "SAO 101650"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.25870400),
        dec: Angle.Degrees(+11.61015706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72651",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72651"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.81089814),
        dec: Angle.Degrees(+11.61154359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91785"},
        {"Hipparcos Number", "HIP 51892"},
        {"Smithsonian Astrophysical Observation", "SAO 99198"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.02810250),
        dec: Angle.Degrees(+11.61453368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17650"},
        {"Hipparcos Number", "HIP 13228"},
        {"Geneva Identification System", "GEN# +1.00017650"},
        {"Smithsonian Astrophysical Observation", "SAO 93134"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.57616802),
        dec: Angle.Degrees(+11.61473684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152985"},
        {"Hipparcos Number", "HIP 82890"},
        {"Smithsonian Astrophysical Observation", "SAO 102483"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.09116725),
        dec: Angle.Degrees(+11.61585482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124349"},
        {"Hipparcos Number", "HIP 69421"},
        {"Smithsonian Astrophysical Observation", "SAO 100913"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.21144912),
        dec: Angle.Degrees(+11.62046571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69391",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69391"},
        {"Geneva Identification System", "GEN# +9.80065034"},
    },
    visualMagnitude: 11.46,
    bvColour: 1.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.07517014),
        dec: Angle.Degrees(+11.62054507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 143.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -342.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210502"},
        {"Hipparcos Number", "HIP 109471"},
        {"Fundamental Katalog 5th Edition", "FK5 3773"},
        {"Geneva Identification System", "GEN# +1.00210502"},
        {"Smithsonian Astrophysical Observation", "SAO 107712"},
        {"Wilson Evans Batten Catalogue", "WEB 19671"},
    },
    visualMagnitude: 5.78,
    bvColour: 1.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.65608471),
        dec: Angle.Degrees(+11.62467170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76351"},
        {"Hipparcos Number", "HIP 43851"},
        {"Geneva Identification System", "GEN# +1.00076351"},
        {"Smithsonian Astrophysical Observation", "SAO 98235"},
        {"Wilson Evans Batten Catalogue", "WEB 8435"},
    },
    visualMagnitude: 5.44,
    bvColour: 1.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.98148374),
        dec: Angle.Degrees(+11.62605826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178715"},
        {"Hipparcos Number", "HIP 94098"},
        {"Geneva Identification System", "GEN# +1.00178715"},
        {"Smithsonian Astrophysical Observation", "SAO 104534"},
        {"Wilson Evans Batten Catalogue", "WEB 16384"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.32668544),
        dec: Angle.Degrees(+11.62679938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97067"},
        {"Hipparcos Number", "HIP 54607"},
        {"Smithsonian Astrophysical Observation", "SAO 99479"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.63931965),
        dec: Angle.Degrees(+11.62702921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183915"},
        {"Hipparcos Number", "HIP 96024"},
        {"Geneva Identification System", "GEN# +1.00183915"},
        {"Smithsonian Astrophysical Observation", "SAO 104927"},
        {"Wilson Evans Batten Catalogue", "WEB 16820"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.85623763),
        dec: Angle.Degrees(+11.62794102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20278"},
        {"Hipparcos Number", "HIP 15206"},
        {"Geneva Identification System", "GEN# +5.20250158"},
        {"Smithsonian Astrophysical Observation", "SAO 93365"},
        {"Wilson Evans Batten Catalogue", "WEB 2929"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.01254201),
        dec: Angle.Degrees(+11.62848313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 194.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87271"},
        {"Hipparcos Number", "HIP 49328"},
        {"Fundamental Katalog 5th Edition", "FK5 4893"},
        {"Smithsonian Astrophysical Observation", "SAO 98931"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.03490886),
        dec: Angle.Degrees(+11.62850002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187923"},
        {"Hipparcos Number", "HIP 97767"},
        {"Cincinnati Publication", "Ci 20 1171"},
        {"Geneva Identification System", "GEN# +1.00187923"},
        {"Smithsonian Astrophysical Observation", "SAO 105348"},
        {"Wilson Evans Batten Catalogue", "WEB 17197"},
    },
    visualMagnitude: 6.16,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.01518068),
        dec: Angle.Degrees(+11.62913862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -345.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -333.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 254936"},
        {"Hipparcos Number", "HIP 29978"},
        {"Smithsonian Astrophysical Observation", "SAO 95514"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.66359793),
        dec: Angle.Degrees(+11.63133285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73849",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9498 AB"},
        {"Henry Draper", "HD 133708"},
        {"Hipparcos Number", "HIP 73849"},
        {"Smithsonian Astrophysical Observation", "SAO 101368"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.38944080),
        dec: Angle.Degrees(+11.63144642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208064"},
        {"Hipparcos Number", "HIP 108051"},
        {"Fundamental Katalog 5th Edition", "FK5 5933"},
        {"Smithsonian Astrophysical Observation", "SAO 107468"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.35376213),
        dec: Angle.Degrees(+11.63446538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81857"},
        {"Hipparcos Number", "HIP 46462"},
        {"Geneva Identification System", "GEN# +1.00081857"},
        {"Smithsonian Astrophysical Observation", "SAO 98593"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.13026948),
        dec: Angle.Degrees(+11.63509539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72075"},
        {"Hipparcos Number", "HIP 41792"},
        {"Smithsonian Astrophysical Observation", "SAO 97875"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.81736237),
        dec: Angle.Degrees(+11.63849404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79376",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79376"},
        {"Smithsonian Astrophysical Observation", "SAO 101997"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.779,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.00157810),
        dec: Angle.Degrees(+11.63932325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -233.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177747"},
        {"Hipparcos Number", "HIP 93757"},
        {"Geneva Identification System", "GEN# +1.00177747"},
        {"Smithsonian Astrophysical Observation", "SAO 104463"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.39304687),
        dec: Angle.Degrees(+11.64024944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197796"},
        {"Hipparcos Number", "HIP 102450"},
        {"Smithsonian Astrophysical Observation", "SAO 106459"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.39741211),
        dec: Angle.Degrees(+11.64124323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142797"},
        {"Hipparcos Number", "HIP 78052"},
        {"Smithsonian Astrophysical Observation", "SAO 101822"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.03763357),
        dec: Angle.Degrees(+11.64133585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4525"},
        {"Hipparcos Number", "HIP 3702"},
        {"Geneva Identification System", "GEN# +1.00004525"},
        {"Smithsonian Astrophysical Observation", "SAO 92084"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.87305786),
        dec: Angle.Degrees(+11.64231645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125785"},
        {"Hipparcos Number", "HIP 70174"},
        {"Geneva Identification System", "GEN# +1.00125785"},
        {"Smithsonian Astrophysical Observation", "SAO 100989"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.36712177),
        dec: Angle.Degrees(+11.64235371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43948",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43948"},
        {"Geneva Identification System", "GEN# +6.20030260"},
        {"Geneva Identification System 2", "GEN# +0.01201944"},
    },
    visualMagnitude: 10.60,
    bvColour: 1.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.26961503),
        dec: Angle.Degrees(+11.64775640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -317.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62751",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62751"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.856,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.86416373),
        dec: Angle.Degrees(+11.64835910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -150.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206030"},
        {"Hipparcos Number", "HIP 106902"},
        {"Geneva Identification System", "GEN# +1.00206030"},
        {"Smithsonian Astrophysical Observation", "SAO 107302"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.76476416),
        dec: Angle.Degrees(+11.64951603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71260",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71260"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.60523782),
        dec: Angle.Degrees(+11.65006656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170448"},
        {"Hipparcos Number", "HIP 90584"},
        {"Fundamental Katalog 5th Edition", "FK5 5621"},
        {"Geneva Identification System", "GEN# +1.00170448"},
        {"Smithsonian Astrophysical Observation", "SAO 103763"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.25821916),
        dec: Angle.Degrees(+11.65045565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204025"},
        {"Hipparcos Number", "HIP 105793"},
        {"Geneva Identification System", "GEN# +1.00204025"},
        {"Smithsonian Astrophysical Observation", "SAO 107128"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.38457787),
        dec: Angle.Degrees(+11.65048222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64945",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64945"},
        {"Geneva Identification System", "GEN# +0.01202581"},
        {"Smithsonian Astrophysical Observation", "SAO 100507"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.69144019),
        dec: Angle.Degrees(+11.65153594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43098"},
        {"Hipparcos Number", "HIP 29661"},
        {"Celescope Catalog", "CEL 1137"},
        {"Geneva Identification System", "GEN# +1.00043098"},
        {"Smithsonian Astrophysical Observation", "SAO 95441"},
    },
    visualMagnitude: 8.14,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.73234616),
        dec: Angle.Degrees(+11.65246248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81588",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81588"},
        {"Smithsonian Astrophysical Observation", "SAO 102300"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.93442335),
        dec: Angle.Degrees(+11.65430211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159969"},
        {"Hipparcos Number", "HIP 86212"},
        {"Smithsonian Astrophysical Observation", "SAO 102967"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.26317103),
        dec: Angle.Degrees(+11.65531305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29168",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4747 A"},
        {"Henry Draper", "HD 42071"},
        {"Hipparcos Number", "HIP 29168"},
        {"Smithsonian Astrophysical Observation", "SAO 95294"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.28981986),
        dec: Angle.Degrees(+11.65547535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126127"},
        {"Hipparcos Number", "HIP 70322"},
        {"Smithsonian Astrophysical Observation", "SAO 101001"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.82636584),
        dec: Angle.Degrees(+11.65627674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40863"},
        {"Hipparcos Number", "HIP 28586"},
        {"Smithsonian Astrophysical Observation", "SAO 95143"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.51958108),
        dec: Angle.Degrees(+11.65662007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69630"},
        {"Hipparcos Number", "HIP 40669"},
        {"Smithsonian Astrophysical Observation", "SAO 97716"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.53470347),
        dec: Angle.Degrees(+11.65692124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200354"},
        {"Hipparcos Number", "HIP 103858"},
        {"Smithsonian Astrophysical Observation", "SAO 106786"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.66784454),
        dec: Angle.Degrees(+11.65709020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81730",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81730"},
    },
    visualMagnitude: 11.15,
    bvColour: 1.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.40479043),
        dec: Angle.Degrees(+11.65794690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -384.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129336"},
        {"Hipparcos Number", "HIP 71837"},
        {"Fundamental Katalog 5th Edition", "FK5 1382"},
        {"Geneva Identification System", "GEN# +1.00129336"},
        {"Smithsonian Astrophysical Observation", "SAO 101152"},
        {"Wilson Evans Batten Catalogue", "WEB 12373"},
    },
    visualMagnitude: 5.55,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.43173137),
        dec: Angle.Degrees(+11.66093526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -159.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9080",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9080"},
        {"Geneva Identification System", "GEN# +9.80003028"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.785,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.23279858),
        dec: Angle.Degrees(+11.66352009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 383.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49840"},
        {"Hipparcos Number", "HIP 32858"},
        {"Geneva Identification System", "GEN# +1.00049840"},
        {"Smithsonian Astrophysical Observation", "SAO 96190"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.72647973),
        dec: Angle.Degrees(+11.66387285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19258"},
        {"Hipparcos Number", "HIP 14433"},
        {"Geneva Identification System", "GEN# +1.00019258"},
        {"Smithsonian Astrophysical Observation", "SAO 93275"},
        {"Wilson Evans Batten Catalogue", "WEB 2813"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.57130251),
        dec: Angle.Degrees(+11.66530934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29169",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4747 B"},
        {"Hipparcos Number", "HIP 29169"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.29075339),
        dec: Angle.Degrees(+11.66535757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28321"},
        {"Hipparcos Number", "HIP 20876"},
        {"Smithsonian Astrophysical Observation", "SAO 93951"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.09858647),
        dec: Angle.Degrees(+11.66594898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88988"},
        {"Hipparcos Number", "HIP 50297"},
        {"Smithsonian Astrophysical Observation", "SAO 99031"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.04265328),
        dec: Angle.Degrees(+11.66802695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50510"},
        {"Hipparcos Number", "HIP 33127"},
        {"Geneva Identification System", "GEN# +1.00050510"},
        {"Smithsonian Astrophysical Observation", "SAO 96249"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.48327747),
        dec: Angle.Degrees(+11.66837754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58187"},
        {"Hipparcos Number", "HIP 35987"},
        {"Geneva Identification System", "GEN# +1.00058187"},
        {"Smithsonian Astrophysical Observation", "SAO 96871"},
        {"Wilson Evans Batten Catalogue", "WEB 7165"},
    },
    visualMagnitude: 5.37,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.24245464),
        dec: Angle.Degrees(+11.66955984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100871"},
        {"Hipparcos Number", "HIP 56636"},
        {"Smithsonian Astrophysical Observation", "SAO 99693"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.17786066),
        dec: Angle.Degrees(+11.66984759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105183"},
        {"Hipparcos Number", "HIP 59067"},
        {"Geneva Identification System", "GEN# +1.00105183"},
        {"Geneva Identification System 2", "GEN# +6.20001056"},
        {"Wilson Evans Batten Catalogue", "WEB 10516"},
    },
    visualMagnitude: 11.07,
    bvColour: -0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.69683060),
        dec: Angle.Degrees(+11.67019827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104386",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104386"},
        {"Smithsonian Astrophysical Observation", "SAO 106870"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.738,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.20520178),
        dec: Angle.Degrees(+11.67108576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78394",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9872 ABC"},
        {"Henry Draper", "HD 143480"},
        {"Hipparcos Number", "HIP 78394"},
        {"Smithsonian Astrophysical Observation", "SAO 101864"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.06677539),
        dec: Angle.Degrees(+11.67163603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39783",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39783"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.94921962),
        dec: Angle.Degrees(+11.67168394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157297"},
        {"Hipparcos Number", "HIP 84965"},
        {"Geneva Identification System", "GEN# +1.00157297"},
        {"Smithsonian Astrophysical Observation", "SAO 102773"},
        {"Wilson Evans Batten Catalogue", "WEB 14350"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.48803076),
        dec: Angle.Degrees(+11.67231619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128751"},
        {"Hipparcos Number", "HIP 71582"},
        {"Smithsonian Astrophysical Observation", "SAO 101122"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.58226832),
        dec: Angle.Degrees(+11.67237918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134627"},
        {"Hipparcos Number", "HIP 74253"},
        {"Smithsonian Astrophysical Observation", "SAO 101412"},
        {"Wilson Evans Batten Catalogue", "WEB 12677"},
    },
    visualMagnitude: 6.89,
    bvColour: 1.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.63130492),
        dec: Angle.Degrees(+11.67357688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31168",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5170 A"},
        {"Henry Draper", "HD 46178"},
        {"Hipparcos Number", "HIP 31168"},
        {"Geneva Identification System", "GEN# +1.00046178"},
        {"Smithsonian Astrophysical Observation", "SAO 95803"},
        {"Wilson Evans Batten Catalogue", "WEB 6226"},
    },
    visualMagnitude: 6.08,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.09697283),
        dec: Angle.Degrees(+11.67360561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224673"},
        {"Hipparcos Number", "HIP 118318"},
        {"Smithsonian Astrophysical Observation", "SAO 108950"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.96374383),
        dec: Angle.Degrees(+11.67370866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221193"},
        {"Hipparcos Number", "HIP 115978"},
        {"Smithsonian Astrophysical Observation", "SAO 108645"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.46697129),
        dec: Angle.Degrees(+11.67900994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47608"},
        {"Hipparcos Number", "HIP 31887"},
        {"Smithsonian Astrophysical Observation", "SAO 95972"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.98752638),
        dec: Angle.Degrees(+11.68098268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41076"},
        {"Hipparcos Number", "HIP 28686"},
        {"Geneva Identification System", "GEN# +1.00041076"},
        {"Renson", "Renson 10980"},
        {"Smithsonian Astrophysical Observation", "SAO 95170"},
        {"Wilson Evans Batten Catalogue", "WEB 5610"},
    },
    visualMagnitude: 6.09,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.85322766),
        dec: Angle.Degrees(+11.68107706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7275"},
        {"Hipparcos Number", "HIP 5685"},
        {"Smithsonian Astrophysical Observation", "SAO 92318"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.28694136),
        dec: Angle.Degrees(+11.68267646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44965"},
        {"Hipparcos Number", "HIP 30542"},
        {"Geneva Identification System", "GEN# +1.00044965"},
        {"Smithsonian Astrophysical Observation", "SAO 95653"},
        {"Wilson Evans Batten Catalogue", "WEB 6085"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.30467985),
        dec: Angle.Degrees(+11.68374277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 260930"},
        {"Hipparcos Number", "HIP 31699"},
        {"Smithsonian Astrophysical Observation", "SAO 95925"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.47177906),
        dec: Angle.Degrees(+11.68470456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63953",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63953"},
        {"Smithsonian Astrophysical Observation", "SAO 100415"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.60192355),
        dec: Angle.Degrees(+11.68487962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -137.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187284"},
        {"Hipparcos Number", "HIP 97489"},
        {"Smithsonian Astrophysical Observation", "SAO 105290"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.22221813),
        dec: Angle.Degrees(+11.68510518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100450",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100450"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.55535090),
        dec: Angle.Degrees(+11.68558090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -145.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -221.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73691",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73691"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.93563693),
        dec: Angle.Degrees(+11.68592052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215459"},
        {"Hipparcos Number", "HIP 112332"},
        {"Geneva Identification System", "GEN# +1.00215459"},
        {"Smithsonian Astrophysical Observation", "SAO 108150"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.29341263),
        dec: Angle.Degrees(+11.68622337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160138"},
        {"Hipparcos Number", "HIP 86283"},
        {"Geneva Identification System", "GEN# +1.00160138"},
        {"Smithsonian Astrophysical Observation", "SAO 102979"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.45633835),
        dec: Angle.Degrees(+11.68801639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64983"},
        {"Hipparcos Number", "HIP 38843"},
        {"Smithsonian Astrophysical Observation", "SAO 97400"},
    },
    visualMagnitude: 7.73,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.23686855),
        dec: Angle.Degrees(+11.68835538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106104",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106104"},
        {"Smithsonian Astrophysical Observation", "SAO 107172"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.39397997),
        dec: Angle.Degrees(+11.68984723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58098",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58098"},
        {"Smithsonian Astrophysical Observation", "SAO 99862"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.73244012),
        dec: Angle.Degrees(+11.69479207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -112.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65394"},
        {"Hipparcos Number", "HIP 39006"},
        {"Geneva Identification System", "GEN# +1.00065394"},
        {"Smithsonian Astrophysical Observation", "SAO 97436"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.73892496),
        dec: Angle.Degrees(+11.69527000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170469"},
        {"Hipparcos Number", "HIP 90593"},
        {"Geneva Identification System", "GEN# +1.00170469"},
        {"Smithsonian Astrophysical Observation", "SAO 103765"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.29587436),
        dec: Angle.Degrees(+11.69554386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214203"},
        {"Hipparcos Number", "HIP 111601"},
        {"Geneva Identification System", "GEN# +1.00214203"},
        {"Smithsonian Astrophysical Observation", "SAO 108036"},
        {"Wilson Evans Batten Catalogue", "WEB 19949"},
    },
    visualMagnitude: 6.42,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.15140974),
        dec: Angle.Degrees(+11.69662147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61706",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61706"},
        {"Cincinnati Publication", "Ci 20 726"},
        {"Geneva Identification System", "GEN# +9.80060024"},
        {"Wilson Evans Batten Catalogue", "WEB 10979"},
    },
    visualMagnitude: 11.49,
    bvColour: 1.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.72137356),
        dec: Angle.Degrees(+11.69676063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1156.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -244.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73046"},
        {"Hipparcos Number", "HIP 42222"},
        {"Geneva Identification System", "GEN# +1.00073046"},
        {"Smithsonian Astrophysical Observation", "SAO 97961"},
    },
    visualMagnitude: 8.11,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.13079685),
        dec: Angle.Degrees(+11.70356922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191204"},
        {"Hipparcos Number", "HIP 99198"},
        {"Smithsonian Astrophysical Observation", "SAO 105735"},
    },
    visualMagnitude: 8.16,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.08210258),
        dec: Angle.Degrees(+11.70398737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158538"},
        {"Hipparcos Number", "HIP 85590"},
        {"Smithsonian Astrophysical Observation", "SAO 102852"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.36006924),
        dec: Angle.Degrees(+11.70470377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30210"},
        {"Hipparcos Number", "HIP 22157"},
        {"Celescope Catalog", "CEL 461"},
        {"Fundamental Katalog 5th Edition", "FK5 2353"},
        {"Geneva Identification System", "GEN# +5.20250112"},
        {"Renson", "Renson 7790"},
        {"Smithsonian Astrophysical Observation", "SAO 94111"},
        {"Wilson Evans Batten Catalogue", "WEB 4263"},
    },
    visualMagnitude: 5.35,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.50708664),
        dec: Angle.Degrees(+11.70560822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95216"},
        {"Hipparcos Number", "HIP 53737"},
        {"Fundamental Katalog 5th Edition", "FK5 2877"},
        {"Geneva Identification System", "GEN# +1.00095216"},
        {"Smithsonian Astrophysical Observation", "SAO 99392"},
        {"Wilson Evans Batten Catalogue", "WEB 9735"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.92177112),
        dec: Angle.Degrees(+11.70575777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -228.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71475"},
        {"Hipparcos Number", "HIP 41518"},
        {"Smithsonian Astrophysical Observation", "SAO 97838"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.01092455),
        dec: Angle.Degrees(+11.70644418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102468"},
        {"Hipparcos Number", "HIP 57543"},
        {"Smithsonian Astrophysical Observation", "SAO 99795"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.90774006),
        dec: Angle.Degrees(+11.70840634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17826",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2785 AB"},
        {"Henry Draper", "HD 23874"},
        {"Hipparcos Number", "HIP 17826"},
        {"Smithsonian Astrophysical Observation", "SAO 93616"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.21488370),
        dec: Angle.Degrees(+11.70881290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140456"},
        {"Hipparcos Number", "HIP 77001"},
        {"Smithsonian Astrophysical Observation", "SAO 101700"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.84283607),
        dec: Angle.Degrees(+11.71104411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101933",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101933"},
    },
    visualMagnitude: 11.78,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.84543081),
        dec: Angle.Degrees(+11.71249141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -246.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179987"},
        {"Hipparcos Number", "HIP 94524"},
        {"Smithsonian Astrophysical Observation", "SAO 104631"},
    },
    visualMagnitude: 6.77,
    bvColour: 1.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.57611516),
        dec: Angle.Degrees(+11.71277924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87182",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87182"},
        {"Smithsonian Astrophysical Observation", "SAO 103127"},
    },
    visualMagnitude: 9.54,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.17998381),
        dec: Angle.Degrees(+11.71444164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 207.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 251419"},
        {"Hipparcos Number", "HIP 28850"},
        {"Smithsonian Astrophysical Observation", "SAO 95216"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.34935424),
        dec: Angle.Degrees(+11.71566564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10639"},
        {"Hipparcos Number", "HIP 8099"},
        {"Smithsonian Astrophysical Observation", "SAO 92602"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.00182218),
        dec: Angle.Degrees(+11.71721195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65765",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65765"},
        {"Geneva Identification System", "GEN# +0.01202596"},
        {"Smithsonian Astrophysical Observation", "SAO 100587"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.25025418),
        dec: Angle.Degrees(+11.71790398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38982"},
        {"Hipparcos Number", "HIP 27543"},
        {"Geneva Identification System", "GEN# +1.00038982"},
        {"Smithsonian Astrophysical Observation", "SAO 94894"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.49126413),
        dec: Angle.Degrees(+11.71856765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205746"},
        {"Hipparcos Number", "HIP 106725"},
        {"Fundamental Katalog 5th Edition", "FK5 5908"},
        {"Smithsonian Astrophysical Observation", "SAO 107279"},
        {"Wilson Evans Batten Catalogue", "WEB 19296"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.27719932),
        dec: Angle.Degrees(+11.71947035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195020"},
        {"Hipparcos Number", "HIP 100981"},
        {"Geneva Identification System", "GEN# +1.00195020"},
        {"Renson", "Renson 54370"},
        {"Smithsonian Astrophysical Observation", "SAO 106139"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.11067786),
        dec: Angle.Degrees(+11.72066031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185293"},
        {"Hipparcos Number", "HIP 96580"},
        {"Wilson Evans Batten Catalogue", "WEB 16948"},
    },
    visualMagnitude: 10.01,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.50665907),
        dec: Angle.Degrees(+11.72176355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34387"},
        {"Hipparcos Number", "HIP 24657"},
        {"Smithsonian Astrophysical Observation", "SAO 94443"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.35933670),
        dec: Angle.Degrees(+11.72345513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69243"},
        {"Hipparcos Number", "HIP 40534"},
        {"Geneva Identification System", "GEN# +1.00069243"},
        {"Smithsonian Astrophysical Observation", "SAO 97694"},
        {"Wilson Evans Batten Catalogue", "WEB 7888"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.14093897),
        dec: Angle.Degrees(+11.72626832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1059",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1059"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.856,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.29875197),
        dec: Angle.Degrees(+11.72635707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52766"},
        {"Hipparcos Number", "HIP 33974"},
        {"Smithsonian Astrophysical Observation", "SAO 96417"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.74758850),
        dec: Angle.Degrees(+11.72639185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91167",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11484 AB"},
        {"Henry Draper", "HD 171728"},
        {"Hipparcos Number", "HIP 91167"},
        {"Smithsonian Astrophysical Observation", "SAO 103885"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.98778678),
        dec: Angle.Degrees(+11.72839832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113503",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16428 AB"},
        {"Henry Draper", "HD 217232"},
        {"Hipparcos Number", "HIP 113503"},
        {"Geneva Identification System", "GEN# +1.00217232"},
        {"Smithsonian Astrophysical Observation", "SAO 108307"},
        {"Wilson Evans Batten Catalogue", "WEB 20179"},
    },
    visualMagnitude: 5.76,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.79915676),
        dec: Angle.Degrees(+11.72894102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17149",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17149"},
        {"Smithsonian Astrophysical Observation", "SAO 93546"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.771,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.09055146),
        dec: Angle.Degrees(+11.73157121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28237"},
        {"Hipparcos Number", "HIP 20826"},
        {"Geneva Identification System", "GEN# +5.20250066"},
        {"Smithsonian Astrophysical Observation", "SAO 93945"},
        {"Wilson Evans Batten Catalogue", "WEB 3994"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.94170443),
        dec: Angle.Degrees(+11.73644954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 110.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21559"},
        {"Hipparcos Number", "HIP 16224"},
        {"Smithsonian Astrophysical Observation", "SAO 93450"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.25431476),
        dec: Angle.Degrees(+11.73850433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62648"},
        {"Hipparcos Number", "HIP 37852"},
        {"Smithsonian Astrophysical Observation", "SAO 97217"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.39279894),
        dec: Angle.Degrees(+11.74371332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218699"},
        {"Hipparcos Number", "HIP 114376"},
        {"Smithsonian Astrophysical Observation", "SAO 108436"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.47955881),
        dec: Angle.Degrees(+11.74526612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145228"},
        {"Hipparcos Number", "HIP 79166"},
        {"Geneva Identification System", "GEN# +1.00145228"},
        {"Smithsonian Astrophysical Observation", "SAO 101970"},
        {"Wilson Evans Batten Catalogue", "WEB 13386"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.36654083),
        dec: Angle.Degrees(+11.74788502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64868"},
        {"Hipparcos Number", "HIP 38802"},
        {"Smithsonian Astrophysical Observation", "SAO 97387"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.11564013),
        dec: Angle.Degrees(+11.74901513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33155"},
        {"Hipparcos Number", "HIP 23945"},
        {"Smithsonian Astrophysical Observation", "SAO 94347"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.19230933),
        dec: Angle.Degrees(+11.75226475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 287293"},
        {"Hipparcos Number", "HIP 22875"},
        {"Smithsonian Astrophysical Observation", "SAO 94207"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.80897093),
        dec: Angle.Degrees(+11.75465866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 257615"},
        {"Hipparcos Number", "HIP 30752"},
        {"Smithsonian Astrophysical Observation", "SAO 95705"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.92936766),
        dec: Angle.Degrees(+11.75568535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43465",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43465"},
        {"Geneva Identification System", "GEN# +2.26820081"},
        {"New General Catalogue", "NGC 2682 81"},
    },
    visualMagnitude: 10.03,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.79910477),
        dec: Angle.Degrees(+11.75615394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44173"},
        {"Hipparcos Number", "HIP 30169"},
        {"Celescope Catalog", "CEL 1186"},
        {"Geneva Identification System", "GEN# +1.00044173"},
        {"Smithsonian Astrophysical Observation", "SAO 95563"},
        {"Wilson Evans Batten Catalogue", "WEB 6002"},
    },
    visualMagnitude: 6.54,
    bvColour: -0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.21715989),
        dec: Angle.Degrees(+11.75623099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12291",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1999 AB"},
        {"Hipparcos Number", "HIP 12291"},
        {"Smithsonian Astrophysical Observation", "SAO 93032"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.58438202),
        dec: Angle.Degrees(+11.75908977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211304"},
        {"Hipparcos Number", "HIP 109942"},
        {"Smithsonian Astrophysical Observation", "SAO 107778"},
        {"Wilson Evans Batten Catalogue", "WEB 19738"},
    },
    visualMagnitude: 7.30,
    bvColour: -0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.00265573),
        dec: Angle.Degrees(+11.75996160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61944",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61944"},
        {"Smithsonian Astrophysical Observation", "SAO 100208"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.42494066),
        dec: Angle.Degrees(+11.76040393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 102.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172867"},
        {"Hipparcos Number", "HIP 91704"},
        {"Geneva Identification System", "GEN# +1.00172867"},
        {"Smithsonian Astrophysical Observation", "SAO 103998"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.52078058),
        dec: Angle.Degrees(+11.76124969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 250019"},
        {"Hipparcos Number", "HIP 28341"},
        {"Smithsonian Astrophysical Observation", "SAO 95089"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.83543832),
        dec: Angle.Degrees(+11.76261479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39662"},
        {"Hipparcos Number", "HIP 27924"},
        {"Geneva Identification System", "GEN# +1.00039662"},
        {"Smithsonian Astrophysical Observation", "SAO 94979"},
        {"Wilson Evans Batten Catalogue", "WEB 5467"},
    },
    visualMagnitude: 6.59,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.63437127),
        dec: Angle.Degrees(+11.76330120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107628",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15335 AB"},
        {"Henry Draper", "HD 207333"},
        {"Hipparcos Number", "HIP 107628"},
        {"Smithsonian Astrophysical Observation", "SAO 107400"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.00295462),
        dec: Angle.Degrees(+11.76619561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209977"},
        {"Hipparcos Number", "HIP 109181"},
        {"Geneva Identification System", "GEN# +1.00209977"},
        {"Smithsonian Astrophysical Observation", "SAO 107669"},
        {"Wilson Evans Batten Catalogue", "WEB 19625"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.76069730),
        dec: Angle.Degrees(+11.76775235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137269"},
        {"Hipparcos Number", "HIP 75441"},
        {"Geneva Identification System", "GEN# +1.00137269"},
        {"Smithsonian Astrophysical Observation", "SAO 101532"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.19232329),
        dec: Angle.Degrees(+11.76961043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77525",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77525"},
    },
    visualMagnitude: 10.54,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.43954979),
        dec: Angle.Degrees(+11.76993596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48199"},
        {"Hipparcos Number", "HIP 32142"},
        {"Smithsonian Astrophysical Observation", "SAO 96027"},
    },
    visualMagnitude: 7.87,
    bvColour: -0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.68201742),
        dec: Angle.Degrees(+11.77147678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48452"},
        {"Hipparcos Number", "HIP 32247"},
        {"Smithsonian Astrophysical Observation", "SAO 96052"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.99284171),
        dec: Angle.Degrees(+11.77184162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2955"},
        {"Hipparcos Number", "HIP 2590"},
        {"Smithsonian Astrophysical Observation", "SAO 91955"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.22188444),
        dec: Angle.Degrees(+11.77303465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33810",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5689 AB"},
        {"Henry Draper", "HD 52309"},
        {"Hipparcos Number", "HIP 33810"},
        {"Geneva Identification System", "GEN# +1.00052309"},
        {"Smithsonian Astrophysical Observation", "SAO 96385"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.29105679),
        dec: Angle.Degrees(+11.77463710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138713"},
        {"Hipparcos Number", "HIP 76169"},
        {"Geneva Identification System", "GEN# +1.00138713"},
        {"Smithsonian Astrophysical Observation", "SAO 101614"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.36316889),
        dec: Angle.Degrees(+11.77505023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17230"},
        {"Hipparcos Number", "HIP 12929"},
        {"Geneva Identification System", "GEN# +1.00017230"},
        {"Smithsonian Astrophysical Observation", "SAO 93097"},
        {"Wilson Evans Batten Catalogue", "WEB 2622"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.57133117),
        dec: Angle.Degrees(+11.77575063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 265.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -210.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50737",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50737"},
        {"Smithsonian Astrophysical Observation", "SAO 99079"},
    },
    visualMagnitude: 9.58,
    bvColour: 1.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.39844203),
        dec: Angle.Degrees(+11.77673128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8068"},
        {"Hipparcos Number", "HIP 6251"},
        {"Smithsonian Astrophysical Observation", "SAO 92373"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.05114832),
        dec: Angle.Degrees(+11.77873178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -151.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120104"},
        {"Hipparcos Number", "HIP 67264"},
        {"Smithsonian Astrophysical Observation", "SAO 100705"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.79667855),
        dec: Angle.Degrees(+11.78138708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201892"},
        {"Hipparcos Number", "HIP 104677"},
        {"Smithsonian Astrophysical Observation", "SAO 106913"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.05104524),
        dec: Angle.Degrees(+11.78154281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86559",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86559"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.783,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.33174776),
        dec: Angle.Degrees(+11.78174377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110585"},
        {"Hipparcos Number", "HIP 62042"},
        {"Geneva Identification System", "GEN# +1.00110585"},
        {"Smithsonian Astrophysical Observation", "SAO 100217"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.76032896),
        dec: Angle.Degrees(+11.78347878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183223"},
        {"Hipparcos Number", "HIP 95716"},
        {"Smithsonian Astrophysical Observation", "SAO 104868"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.02579524),
        dec: Angle.Degrees(+11.78356204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 287058"},
        {"Hipparcos Number", "HIP 22264"},
        {"Smithsonian Astrophysical Observation", "SAO 94124"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.90429909),
        dec: Angle.Degrees(+11.78667553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43491",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43491"},
        {"Geneva Identification System", "GEN# +2.26820170"},
        {"New General Catalogue", "NGC 2682 170"},
    },
    visualMagnitude: 9.69,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.87463223),
        dec: Angle.Degrees(+11.78802421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90918",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11438 AB"},
        {"Henry Draper", "HD 171168"},
        {"Hipparcos Number", "HIP 90918"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.19902302),
        dec: Angle.Degrees(+11.78943894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46075"},
        {"Hipparcos Number", "HIP 31107"},
        {"Geneva Identification System", "GEN# +1.00046075"},
        {"Smithsonian Astrophysical Observation", "SAO 95783"},
        {"Wilson Evans Batten Catalogue", "WEB 6200"},
    },
    visualMagnitude: 6.64,
    bvColour: -0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.91410314),
        dec: Angle.Degrees(+11.79229200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67322",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67322"},
        {"Smithsonian Astrophysical Observation", "SAO 100712"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.98327367),
        dec: Angle.Degrees(+11.79388873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98826",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13320 AB"},
        {"Henry Draper", "HD 190341"},
        {"Hipparcos Number", "HIP 98826"},
        {"Smithsonian Astrophysical Observation", "SAO 105633"},
    },
    visualMagnitude: 7.86,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.03854681),
        dec: Angle.Degrees(+11.79451937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107068"},
        {"Hipparcos Number", "HIP 60034"},
        {"Smithsonian Astrophysical Observation", "SAO 100032"},
        {"Wilson Evans Batten Catalogue", "WEB 10668"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.67874297),
        dec: Angle.Degrees(+11.79618383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109946",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109946"},
        {"Smithsonian Astrophysical Observation", "SAO 107779"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.00629589),
        dec: Angle.Degrees(+11.79619358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43020"},
        {"Hipparcos Number", "HIP 29620"},
        {"Geneva Identification System", "GEN# +1.00043020"},
        {"Smithsonian Astrophysical Observation", "SAO 95425"},
        {"Wilson Evans Batten Catalogue", "WEB 5829"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.62974342),
        dec: Angle.Degrees(+11.79697586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92600",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11769 AB"},
        {"Henry Draper", "HD 174832"},
        {"Hipparcos Number", "HIP 92600"},
        {"Smithsonian Astrophysical Observation", "SAO 104197"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.03123409),
        dec: Angle.Degrees(+11.79832137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51955"},
        {"Hipparcos Number", "HIP 33684"},
        {"Smithsonian Astrophysical Observation", "SAO 96360"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.96745702),
        dec: Angle.Degrees(+11.80201617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84902",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84902"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.27006504),
        dec: Angle.Degrees(+11.80365196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163441"},
        {"Hipparcos Number", "HIP 87769"},
        {"Geneva Identification System", "GEN# +1.00163441"},
        {"Smithsonian Astrophysical Observation", "SAO 103220"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.93892198),
        dec: Angle.Degrees(+11.80400189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106964"},
        {"Hipparcos Number", "HIP 59969"},
        {"Geneva Identification System", "GEN# +1.00106964"},
        {"Smithsonian Astrophysical Observation", "SAO 100026"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.48904193),
        dec: Angle.Degrees(+11.80410230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102988"},
        {"Hipparcos Number", "HIP 57821"},
        {"Geneva Identification System", "GEN# +1.00102988"},
        {"Smithsonian Astrophysical Observation", "SAO 99829"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.85355193),
        dec: Angle.Degrees(+11.80515473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -220.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218382"},
        {"Hipparcos Number", "HIP 114190"},
        {"Smithsonian Astrophysical Observation", "SAO 108412"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.87170846),
        dec: Angle.Degrees(+11.80673335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84561"},
        {"Hipparcos Number", "HIP 47959"},
        {"Geneva Identification System", "GEN# +1.00084561"},
        {"Smithsonian Astrophysical Observation", "SAO 98755"},
        {"Wilson Evans Batten Catalogue", "WEB 8969"},
    },
    visualMagnitude: 5.67,
    bvColour: 1.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.59723787),
        dec: Angle.Degrees(+11.81000106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42999"},
        {"Hipparcos Number", "HIP 29614"},
        {"Celescope Catalog", "CEL 1133"},
        {"Geneva Identification System", "GEN# +1.00042999"},
        {"Smithsonian Astrophysical Observation", "SAO 95423"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.61054745),
        dec: Angle.Degrees(+11.81360315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39456"},
        {"Hipparcos Number", "HIP 27820"},
        {"Geneva Identification System", "GEN# +1.00039456"},
        {"Smithsonian Astrophysical Observation", "SAO 94960"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.30246868),
        dec: Angle.Degrees(+11.81448920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31361",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31361"},
    },
    visualMagnitude: 11.84,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.64706032),
        dec: Angle.Degrees(+13.07908687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97473",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12962 AB"},
        {"Hipparcos Number", "HIP 97473"},
        {"Geneva Identification System", "GEN# +1.00187259"},
        {"Smithsonian Astrophysical Observation", "SAO 105282"},
        {"Wilson Evans Batten Catalogue", "WEB 17131"},
    },
    visualMagnitude: 5.75,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.17520021),
        dec: Angle.Degrees(+11.81592014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107157",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107157"},
    },
    visualMagnitude: 9.75,
    bvColour: 1.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.58654746),
        dec: Angle.Degrees(+11.81849533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47978",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47978"},
        {"Smithsonian Astrophysical Observation", "SAO 98762"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.69467490),
        dec: Angle.Degrees(+11.81942900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59683",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8472 AB"},
        {"Henry Draper", "HD 106400"},
        {"Hipparcos Number", "HIP 59683"},
        {"Geneva Identification System", "GEN# +1.00106400"},
        {"Smithsonian Astrophysical Observation", "SAO 100003"},
        {"Wilson Evans Batten Catalogue", "WEB 10606"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.58736578),
        dec: Angle.Degrees(+11.81953626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219500"},
        {"Hipparcos Number", "HIP 114870"},
        {"Smithsonian Astrophysical Observation", "SAO 108500"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.01211412),
        dec: Angle.Degrees(+11.82415941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100617"},
        {"Hipparcos Number", "HIP 56487"},
        {"Smithsonian Astrophysical Observation", "SAO 99674"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.70795973),
        dec: Angle.Degrees(+11.82531234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108560"},
        {"Hipparcos Number", "HIP 60842"},
        {"Geneva Identification System", "GEN# +1.00108560"},
        {"Smithsonian Astrophysical Observation", "SAO 100114"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.06204704),
        dec: Angle.Degrees(+11.82654867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96957",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12808 AB"},
        {"Hipparcos Number", "HIP 96957"},
        {"Geneva Identification System", "GEN# +1.00186203"},
        {"Smithsonian Astrophysical Observation", "SAO 105168"},
    },
    visualMagnitude: 5.28,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.64169697),
        dec: Angle.Degrees(+11.82660840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58321",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58321"},
        {"Cincinnati Publication", "Ci 20 672"},
        {"Geneva Identification System", "GEN# +9.80012012"},
    },
    visualMagnitude: 11.81,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.38837138),
        dec: Angle.Degrees(+11.82715958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -683.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 239.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73963",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73963"},
        {"Geneva Identification System", "GEN# +9.80066063"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.887,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.73127267),
        dec: Angle.Degrees(+11.82880967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -258.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3912",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 686 A"},
        {"Hipparcos Number", "HIP 3912"},
        {"Smithsonian Astrophysical Observation", "SAO 92108"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.54989215),
        dec: Angle.Degrees(+11.83013738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32908"},
        {"Hipparcos Number", "HIP 23804"},
        {"Celescope Catalog", "CEL 535"},
        {"Geneva Identification System", "GEN# +1.00032908"},
        {"Smithsonian Astrophysical Observation", "SAO 94329"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.73836215),
        dec: Angle.Degrees(+11.83041852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50467",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50467"},
    },
    visualMagnitude: 9.69,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.57379277),
        dec: Angle.Degrees(+11.83178217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64948",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64948"},
        {"Geneva Identification System", "GEN# +0.01202582"},
        {"Smithsonian Astrophysical Observation", "SAO 100508"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.69759575),
        dec: Angle.Degrees(+11.83293541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116995",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16951 AB"},
        {"Henry Draper", "HD 222718"},
        {"Hipparcos Number", "HIP 116995"},
        {"Smithsonian Astrophysical Observation", "SAO 108786"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.77513339),
        dec: Angle.Degrees(+11.83447478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4029",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4029"},
    },
    visualMagnitude: 10.33,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.90363840),
        dec: Angle.Degrees(+11.91775144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 176.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26609",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4247 AB"},
        {"Henry Draper", "HD 37477"},
        {"Hipparcos Number", "HIP 26609"},
        {"Smithsonian Astrophysical Observation", "SAO 94730"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.84952926),
        dec: Angle.Degrees(+11.83493339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37127"},
        {"Hipparcos Number", "HIP 26356"},
        {"Smithsonian Astrophysical Observation", "SAO 94699"},
    },
    visualMagnitude: 8.26,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.18789245),
        dec: Angle.Degrees(+11.83569915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1907"},
        {"Hipparcos Number", "HIP 1858"},
        {"Smithsonian Astrophysical Observation", "SAO 91874"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.86437399),
        dec: Angle.Degrees(+11.83644809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57626"},
        {"Hipparcos Number", "HIP 35758"},
        {"Smithsonian Astrophysical Observation", "SAO 96830"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.63794465),
        dec: Angle.Degrees(+11.83768371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2780",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 491 AB"},
        {"Henry Draper", "HD 3213"},
        {"Hipparcos Number", "HIP 2780"},
        {"Smithsonian Astrophysical Observation", "SAO 91986"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.86915504),
        dec: Angle.Degrees(+11.84049215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -138.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48298",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7539 A"},
        {"Henry Draper", "HD 85259"},
        {"Hipparcos Number", "HIP 48298"},
        {"Geneva Identification System", "GEN# +1.00085259"},
        {"Smithsonian Astrophysical Observation", "SAO 98806"},
    },
    visualMagnitude: 6.86,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.70532520),
        dec: Angle.Degrees(+11.84241822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98056"},
        {"Hipparcos Number", "HIP 55092"},
        {"Smithsonian Astrophysical Observation", "SAO 99534"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.19718285),
        dec: Angle.Degrees(+11.84304065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180585"},
        {"Hipparcos Number", "HIP 94741"},
        {"Renson", "Renson 50113"},
        {"Smithsonian Astrophysical Observation", "SAO 104674"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.18185073),
        dec: Angle.Degrees(+11.84475247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68158",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68158"},
        {"Smithsonian Astrophysical Observation", "SAO 100788"},
    },
    visualMagnitude: 10.78,
    bvColour: 0.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.30289983),
        dec: Angle.Degrees(+11.84673414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113311",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16389 AB"},
        {"Henry Draper", "HD 216900"},
        {"Hipparcos Number", "HIP 113311"},
        {"Geneva Identification System", "GEN# +1.00216900"},
        {"Smithsonian Astrophysical Observation", "SAO 108275"},
        {"Wilson Evans Batten Catalogue", "WEB 20161"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.21432071),
        dec: Angle.Degrees(+11.84834533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68155",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68155"},
        {"Smithsonian Astrophysical Observation", "SAO 100787"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.29885557),
        dec: Angle.Degrees(+11.85058408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205061"},
        {"Hipparcos Number", "HIP 106361"},
        {"Smithsonian Astrophysical Observation", "SAO 107217"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.13450540),
        dec: Angle.Degrees(+11.85071001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192168"},
        {"Hipparcos Number", "HIP 99623"},
        {"Smithsonian Astrophysical Observation", "SAO 105843"},
    },
    visualMagnitude: 6.51,
    bvColour: 1.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.26319358),
        dec: Angle.Degrees(+11.85100225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182901"},
        {"Hipparcos Number", "HIP 95586"},
        {"Geneva Identification System", "GEN# +1.00182901"},
        {"Smithsonian Astrophysical Observation", "SAO 104835"},
        {"Wilson Evans Batten Catalogue", "WEB 16717"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.63283667),
        dec: Angle.Degrees(+11.85100672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30558"},
        {"Hipparcos Number", "HIP 22386"},
        {"Geneva Identification System", "GEN# +1.00030558"},
        {"Smithsonian Astrophysical Observation", "SAO 94146"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.28788864),
        dec: Angle.Degrees(+11.85192066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171764"},
        {"Hipparcos Number", "HIP 91180"},
        {"Smithsonian Astrophysical Observation", "SAO 103889"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.02736754),
        dec: Angle.Degrees(+11.85378340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72074"},
        {"Hipparcos Number", "HIP 41790"},
        {"Geneva Identification System", "GEN# +1.00072074"},
        {"Smithsonian Astrophysical Observation", "SAO 97874"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.81293734),
        dec: Angle.Degrees(+11.85517898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286993"},
        {"Hipparcos Number", "HIP 21866"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.52234629),
        dec: Angle.Degrees(+11.85602926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133686"},
        {"Hipparcos Number", "HIP 73844"},
        {"Smithsonian Astrophysical Observation", "SAO 101367"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.37376068),
        dec: Angle.Degrees(+11.85717946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13584"},
        {"Hipparcos Number", "HIP 10310"},
        {"Geneva Identification System", "GEN# +1.00013584"},
        {"Smithsonian Astrophysical Observation", "SAO 92839"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.21031551),
        dec: Angle.Degrees(+11.85738743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44066",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Acubens"},
        {"Aitken", "ADS 7115 A"},
        {"Henry Draper", "HD 76756"},
        {"Hipparcos Number", "HIP 44066"},
        {"Fundamental Katalog 5th Edition", "FK5 337"},
        {"Geneva Identification System", "GEN# +1.00076756"},
        {"Renson", "Renson 21640"},
        {"Smithsonian Astrophysical Observation", "SAO 98267"},
        {"Wilson Evans Batten Catalogue", "WEB 8467"},
    },
    visualMagnitude: 4.26,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.62165408),
        dec: Angle.Degrees(+11.85777198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54878",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54878"},
        {"Smithsonian Astrophysical Observation", "SAO 99511"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.55548971),
        dec: Angle.Degrees(+11.85816084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82214"},
        {"Hipparcos Number", "HIP 46687"},
        {"Smithsonian Astrophysical Observation", "SAO 98622"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.77073444),
        dec: Angle.Degrees(+11.85859294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83784",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83784"},
        {"Smithsonian Astrophysical Observation", "SAO 102602"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.85714607),
        dec: Angle.Degrees(+11.86080030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15857",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15857"},
        {"Smithsonian Astrophysical Observation", "SAO 93417"},
    },
    visualMagnitude: 8.84,
    bvColour: 2.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.06420023),
        dec: Angle.Degrees(+11.86105886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172422"},
        {"Hipparcos Number", "HIP 91500"},
        {"Smithsonian Astrophysical Observation", "SAO 103961"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.90656907),
        dec: Angle.Degrees(+11.86106477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137854"},
        {"Hipparcos Number", "HIP 75714"},
        {"Geneva Identification System", "GEN# +1.00137854"},
        {"Smithsonian Astrophysical Observation", "SAO 101569"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.01890292),
        dec: Angle.Degrees(+11.86160230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101754"},
        {"Hipparcos Number", "HIP 57122"},
        {"Smithsonian Astrophysical Observation", "SAO 99748"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.66966490),
        dec: Angle.Degrees(+11.86398252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198270"},
        {"Hipparcos Number", "HIP 102721"},
        {"Smithsonian Astrophysical Observation", "SAO 106521"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.22038270),
        dec: Angle.Degrees(+11.86489863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145099"},
        {"Hipparcos Number", "HIP 79113"},
        {"Smithsonian Astrophysical Observation", "SAO 101960"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.21509654),
        dec: Angle.Degrees(+11.86648661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21731"},
        {"Hipparcos Number", "HIP 16338"},
        {"Smithsonian Astrophysical Observation", "SAO 93466"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.65253139),
        dec: Angle.Degrees(+11.86745685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94087",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12095 AB"},
        {"Henry Draper", "HD 178694"},
        {"Hipparcos Number", "HIP 94087"},
        {"Geneva Identification System", "GEN# +1.00178694J"},
        {"Smithsonian Astrophysical Observation", "SAO 104531"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.30504154),
        dec: Angle.Degrees(+11.86765599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55582"},
        {"Hipparcos Number", "HIP 34960"},
        {"Smithsonian Astrophysical Observation", "SAO 96657"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.50411835),
        dec: Angle.Degrees(+11.86803218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66080",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66080"},
        {"Smithsonian Astrophysical Observation", "SAO 100612"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.19394099),
        dec: Angle.Degrees(+11.86886021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69189",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69189"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.46516727),
        dec: Angle.Degrees(+11.86907353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205690"},
        {"Hipparcos Number", "HIP 106697"},
        {"Smithsonian Astrophysical Observation", "SAO 107275"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.18028729),
        dec: Angle.Degrees(+11.86950374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 244138"},
        {"Hipparcos Number", "HIP 25689"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.28496033),
        dec: Angle.Degrees(+11.87018678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17662"},
        {"Hipparcos Number", "HIP 13246"},
        {"Geneva Identification System", "GEN# +1.00017662"},
        {"Smithsonian Astrophysical Observation", "SAO 93137"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.813,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.62576755),
        dec: Angle.Degrees(+11.87036270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168498"},
        {"Hipparcos Number", "HIP 89798"},
        {"Smithsonian Astrophysical Observation", "SAO 103611"},
    },
    visualMagnitude: 7.60,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.89594323),
        dec: Angle.Degrees(+11.87048134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61297"},
        {"Hipparcos Number", "HIP 37256"},
        {"Smithsonian Astrophysical Observation", "SAO 97115"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.76827910),
        dec: Angle.Degrees(+11.87106781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163622"},
        {"Hipparcos Number", "HIP 87837"},
        {"Geneva Identification System", "GEN# +1.00163622"},
        {"Smithsonian Astrophysical Observation", "SAO 103232"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.17515692),
        dec: Angle.Degrees(+11.87237724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -139.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19698"},
        {"Hipparcos Number", "HIP 14764"},
        {"Geneva Identification System", "GEN# +1.00019698"},
        {"Smithsonian Astrophysical Observation", "SAO 93320"},
        {"Wilson Evans Batten Catalogue", "WEB 2856"},
    },
    visualMagnitude: 5.97,
    bvColour: -0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.66156390),
        dec: Angle.Degrees(+11.87269252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2000",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2000"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.34089026),
        dec: Angle.Degrees(+11.87398872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -116.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -154.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46109",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46109"},
    },
    visualMagnitude: 10.88,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.05170250),
        dec: Angle.Degrees(+11.87404688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169575"},
        {"Hipparcos Number", "HIP 90247"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.21632549),
        dec: Angle.Degrees(+11.87471671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102648"},
        {"Hipparcos Number", "HIP 57637"},
        {"Smithsonian Astrophysical Observation", "SAO 99810"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.28202630),
        dec: Angle.Degrees(+11.87653632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107461",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15300 AB"},
        {"Henry Draper", "HD 207033"},
        {"Hipparcos Number", "HIP 107461"},
        {"Geneva Identification System", "GEN# +1.00207033J"},
        {"Smithsonian Astrophysical Observation", "SAO 107382"},
        {"Wilson Evans Batten Catalogue", "WEB 19400"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.47560079),
        dec: Angle.Degrees(+11.87683179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104574"},
        {"Hipparcos Number", "HIP 58721"},
        {"Geneva Identification System", "GEN# +1.00104574"},
        {"Smithsonian Astrophysical Observation", "SAO 99920"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.66283206),
        dec: Angle.Degrees(+11.87748706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168131"},
        {"Hipparcos Number", "HIP 89665"},
        {"Geneva Identification System", "GEN# +1.00168131"},
        {"Smithsonian Astrophysical Observation", "SAO 103572"},
        {"Wilson Evans Batten Catalogue", "WEB 15274"},
    },
    visualMagnitude: 7.05,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.46704092),
        dec: Angle.Degrees(+11.87777118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7797",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7797"},
        {"Smithsonian Astrophysical Observation", "SAO 92564"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.08245791),
        dec: Angle.Degrees(+11.87843401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50225",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7696 AB"},
        {"Hipparcos Number", "HIP 50225"},
        {"Smithsonian Astrophysical Observation", "SAO 99026"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.79355917),
        dec: Angle.Degrees(+11.87888633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113349"},
        {"Hipparcos Number", "HIP 63676"},
        {"Geneva Identification System", "GEN# +1.00113349"},
        {"Smithsonian Astrophysical Observation", "SAO 100394"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.74780134),
        dec: Angle.Degrees(+11.88002729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151838"},
        {"Hipparcos Number", "HIP 82337"},
        {"Smithsonian Astrophysical Observation", "SAO 102408"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.36398880),
        dec: Angle.Degrees(+11.88205603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213996"},
        {"Hipparcos Number", "HIP 111473"},
        {"Geneva Identification System", "GEN# +1.00213996"},
        {"Smithsonian Astrophysical Observation", "SAO 108017"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.866,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.77444673),
        dec: Angle.Degrees(+11.88219945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -335.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -326.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9397"},
        {"Hipparcos Number", "HIP 7184"},
        {"Smithsonian Astrophysical Observation", "SAO 92496"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.13847988),
        dec: Angle.Degrees(+11.88259982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217889"},
        {"Hipparcos Number", "HIP 113880"},
        {"Geneva Identification System", "GEN# +1.00217889"},
        {"Smithsonian Astrophysical Observation", "SAO 108366"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.94076024),
        dec: Angle.Degrees(+11.88277007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167135"},
        {"Hipparcos Number", "HIP 89309"},
        {"Smithsonian Astrophysical Observation", "SAO 103497"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.35474902),
        dec: Angle.Degrees(+11.88428938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81013",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81013"},
        {"Geneva Identification System", "GEN# +0.01203035"},
        {"Smithsonian Astrophysical Observation", "SAO 102235"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.16432407),
        dec: Angle.Degrees(+11.88754680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189411"},
        {"Hipparcos Number", "HIP 98400"},
        {"Smithsonian Astrophysical Observation", "SAO 105510"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.89630161),
        dec: Angle.Degrees(+11.88939301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106283",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106283"},
        {"Smithsonian Astrophysical Observation", "SAO 107203"},
    },
    visualMagnitude: 9.54,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.90286442),
        dec: Angle.Degrees(+11.88974463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52833",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52833"},
        {"Smithsonian Astrophysical Observation", "SAO 99299"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.04811931),
        dec: Angle.Degrees(+11.89195675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75700"},
        {"Hipparcos Number", "HIP 43519"},
        {"Geneva Identification System", "GEN# +2.26820242"},
        {"Smithsonian Astrophysical Observation", "SAO 98178"},
        {"Wilson Evans Batten Catalogue", "WEB 8386"},
        {"New General Catalogue", "NGC 2682 242"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.95567479),
        dec: Angle.Degrees(+11.89414528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95164"},
        {"Hipparcos Number", "HIP 53716"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.85924126),
        dec: Angle.Degrees(+11.89573314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64706",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64706"},
        {"Geneva Identification System", "GEN# +0.01202576"},
        {"Smithsonian Astrophysical Observation", "SAO 100482"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.865,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.93082038),
        dec: Angle.Degrees(+11.89625690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -138.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 148.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122677"},
        {"Hipparcos Number", "HIP 68642"},
        {"Smithsonian Astrophysical Observation", "SAO 100830"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.76712006),
        dec: Angle.Degrees(+11.89777946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -136.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77226",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77226"},
        {"Smithsonian Astrophysical Observation", "SAO 101723"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.52052734),
        dec: Angle.Degrees(+11.89951194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -337.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -132.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62257",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62257"},
        {"Geneva Identification System", "GEN# +0.01202509"},
        {"Smithsonian Astrophysical Observation", "SAO 100238"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.37627826),
        dec: Angle.Degrees(+11.90324149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61630",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61630"},
    },
    visualMagnitude: 11.05,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.47972089),
        dec: Angle.Degrees(+11.90473366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -149.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -243.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35784",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35784"},
        {"Smithsonian Astrophysical Observation", "SAO 96835"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.71696540),
        dec: Angle.Degrees(+11.90489695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286436"},
        {"Hipparcos Number", "HIP 18564"},
        {"Geneva Identification System", "GEN# +6.20058010"},
    },
    visualMagnitude: 10.26,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.61336253),
        dec: Angle.Degrees(+11.90582171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112186"},
        {"Hipparcos Number", "HIP 62999"},
        {"Geneva Identification System", "GEN# +1.00112186"},
        {"Smithsonian Astrophysical Observation", "SAO 100328"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.63772318),
        dec: Angle.Degrees(+11.90692541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51330"},
        {"Hipparcos Number", "HIP 33465"},
        {"Geneva Identification System", "GEN# +1.00051330"},
        {"Smithsonian Astrophysical Observation", "SAO 96314"},
        {"Wilson Evans Batten Catalogue", "WEB 6730"},
    },
    visualMagnitude: 6.26,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.35661187),
        dec: Angle.Degrees(+11.90756140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116960"},
        {"Hipparcos Number", "HIP 65599"},
        {"Geneva Identification System", "GEN# +1.00116960"},
        {"Smithsonian Astrophysical Observation", "SAO 100569"},
    },
    visualMagnitude: 7.99,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.74558127),
        dec: Angle.Degrees(+11.90856621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184540"},
        {"Hipparcos Number", "HIP 96281"},
        {"Smithsonian Astrophysical Observation", "SAO 104988"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.65755949),
        dec: Angle.Degrees(+11.90934780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108137"},
        {"Hipparcos Number", "HIP 60607"},
        {"Geneva Identification System", "GEN# +1.00108137"},
        {"Smithsonian Astrophysical Observation", "SAO 100090"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.33663147),
        dec: Angle.Degrees(+11.90990802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145730"},
        {"Hipparcos Number", "HIP 79386"},
        {"Smithsonian Astrophysical Observation", "SAO 101998"},
        {"Wilson Evans Batten Catalogue", "WEB 13424"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.02931063),
        dec: Angle.Degrees(+11.91092432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286900"},
        {"Hipparcos Number", "HIP 21475"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.852,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.17164098),
        dec: Angle.Degrees(+11.91243315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 165.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4775",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 828 AB"},
        {"Henry Draper", "HD 5988"},
        {"Hipparcos Number", "HIP 4775"},
        {"Smithsonian Astrophysical Observation", "SAO 92207"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.34070004),
        dec: Angle.Degrees(+11.91270120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82694",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82694"},
        {"Geneva Identification System", "GEN# +6.10010642"},
        {"Wilson Evans Batten Catalogue", "WEB 13972"},
    },
    visualMagnitude: 10.75,
    bvColour: 1.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.55148651),
        dec: Angle.Degrees(+11.91391370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -544.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 315.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170544"},
        {"Hipparcos Number", "HIP 90625"},
        {"Geneva Identification System", "GEN# +1.00170544"},
        {"Smithsonian Astrophysical Observation", "SAO 103773"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.38212204),
        dec: Angle.Degrees(+11.91421463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148164"},
        {"Hipparcos Number", "HIP 80484"},
        {"Geneva Identification System", "GEN# +1.00148164"},
        {"Smithsonian Astrophysical Observation", "SAO 102157"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.43577730),
        dec: Angle.Degrees(+11.91906258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17496",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17496"},
        {"Cincinnati Publication", "Ci 18 503"},
        {"Geneva Identification System", "GEN# +0.01100514"},
        {"Smithsonian Astrophysical Observation", "SAO 93580"},
        {"Wilson Evans Batten Catalogue", "WEB 3315"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.21224201),
        dec: Angle.Degrees(+11.91969372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 315.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 126.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107865"},
        {"Hipparcos Number", "HIP 60460"},
        {"Geneva Identification System", "GEN# +1.00107865"},
        {"Smithsonian Astrophysical Observation", "SAO 100076"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.92730792),
        dec: Angle.Degrees(+11.92049121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116808",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116808"},
    },
    visualMagnitude: 9.54,
    bvColour: 1.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.11696523),
        dec: Angle.Degrees(+11.92220629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158716"},
        {"Hipparcos Number", "HIP 85666"},
        {"Geneva Identification System", "GEN# +1.00158716"},
        {"Smithsonian Astrophysical Observation", "SAO 102869"},
        {"Wilson Evans Batten Catalogue", "WEB 14454"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.59436211),
        dec: Angle.Degrees(+11.92398112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117768",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17079 A"},
        {"Henry Draper", "HD 223839"},
        {"Hipparcos Number", "HIP 117768"},
        {"Geneva Identification System", "GEN# +1.00223839"},
        {"Smithsonian Astrophysical Observation", "SAO 108883"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.24963334),
        dec: Angle.Degrees(+11.92437031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117764",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17079 B"},
        {"Henry Draper", "HD 223838"},
        {"Hipparcos Number", "HIP 117764"},
        {"Geneva Identification System", "GEN# +1.00223838"},
        {"Smithsonian Astrophysical Observation", "SAO 108882"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.24430239),
        dec: Angle.Degrees(+11.92550856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51985",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51985"},
    },
    visualMagnitude: 11.01,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.32221468),
        dec: Angle.Degrees(+11.92586534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -221.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37755",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37755"},
        {"Smithsonian Astrophysical Observation", "SAO 97208"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.14794394),
        dec: Angle.Degrees(+11.92748989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34549",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34549"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.36612075),
        dec: Angle.Degrees(+11.92764638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31269"},
        {"Hipparcos Number", "HIP 22831"},
        {"Celescope Catalog", "CEL 483"},
        {"Geneva Identification System", "GEN# +1.00031269"},
        {"Smithsonian Astrophysical Observation", "SAO 94196"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.68950469),
        dec: Angle.Degrees(+11.92877868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159082"},
        {"Hipparcos Number", "HIP 85826"},
        {"Geneva Identification System", "GEN# +1.00159082"},
        {"Renson", "Renson 44740"},
        {"Smithsonian Astrophysical Observation", "SAO 102897"},
        {"Wilson Evans Batten Catalogue", "WEB 14481"},
    },
    visualMagnitude: 6.42,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.06199676),
        dec: Angle.Degrees(+11.93000748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159005"},
        {"Hipparcos Number", "HIP 85789"},
        {"Smithsonian Astrophysical Observation", "SAO 102888"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.95551112),
        dec: Angle.Degrees(+11.93181229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76946"},
        {"Hipparcos Number", "HIP 44160"},
        {"Smithsonian Astrophysical Observation", "SAO 98280"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.91035438),
        dec: Angle.Degrees(+11.93184189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5843"},
        {"Hipparcos Number", "HIP 4687"},
        {"Geneva Identification System", "GEN# +1.00005843"},
        {"Smithsonian Astrophysical Observation", "SAO 92193"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.05483895),
        dec: Angle.Degrees(+11.93531398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176763"},
        {"Hipparcos Number", "HIP 93402"},
        {"Smithsonian Astrophysical Observation", "SAO 104364"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.34258878),
        dec: Angle.Degrees(+11.93655615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36649",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6154 AB"},
        {"Hipparcos Number", "HIP 36649"},
    },
    visualMagnitude: 13.64,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)32, 14.2700),
        dec: Angle.DegreesMinutesSeconds((int)+14, (int)05, 15.200)
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
    primaryId: "HIP 67673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120865"},
        {"Hipparcos Number", "HIP 67673"},
        {"Geneva Identification System", "GEN# +1.00120865"},
        {"Smithsonian Astrophysical Observation", "SAO 100742"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.96285794),
        dec: Angle.Degrees(+11.93714020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -149.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80773",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80773"},
        {"Smithsonian Astrophysical Observation", "SAO 102206"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.38486691),
        dec: Angle.Degrees(+11.93805418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147252"},
        {"Hipparcos Number", "HIP 80056"},
        {"Smithsonian Astrophysical Observation", "SAO 102093"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.10991875),
        dec: Angle.Degrees(+11.93823684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1226"},
        {"Hipparcos Number", "HIP 1326"},
        {"Smithsonian Astrophysical Observation", "SAO 91811"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.16586131),
        dec: Angle.Degrees(+11.93829650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130067"},
        {"Hipparcos Number", "HIP 72176"},
        {"Smithsonian Astrophysical Observation", "SAO 101194"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.43989293),
        dec: Angle.Degrees(+11.93971860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 287201"},
        {"Hipparcos Number", "HIP 22851"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.74461870),
        dec: Angle.Degrees(+11.94226321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78776"},
        {"Hipparcos Number", "HIP 45028"},
        {"Smithsonian Astrophysical Observation", "SAO 98408"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.57514334),
        dec: Angle.Degrees(+11.94235363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182572"},
        {"Hipparcos Number", "HIP 95447"},
        {"Cincinnati Publication", "Ci 20 1152"},
        {"Fundamental Katalog 5th Edition", "FK5 1503"},
        {"Geneva Identification System", "GEN# +1.00182572"},
        {"Smithsonian Astrophysical Observation", "SAO 104807"},
        {"Wilson Evans Batten Catalogue", "WEB 16687"},
    },
    visualMagnitude: 5.17,
    bvColour: 0.761,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.24070960),
        dec: Angle.Degrees(+11.94285122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 721.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 643.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10376",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10376"},
        {"Geneva Identification System", "GEN# +0.01100299"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.41940163),
        dec: Angle.Degrees(+11.94285682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 279.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3944"},
        {"Hipparcos Number", "HIP 3308"},
        {"Smithsonian Astrophysical Observation", "SAO 92036"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.53566316),
        dec: Angle.Degrees(+11.94540876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162468"},
        {"Hipparcos Number", "HIP 87335"},
        {"Geneva Identification System", "GEN# +1.00162468"},
        {"Smithsonian Astrophysical Observation", "SAO 103145"},
        {"Wilson Evans Batten Catalogue", "WEB 14735"},
    },
    visualMagnitude: 6.19,
    bvColour: 1.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.68170518),
        dec: Angle.Degrees(+11.94662907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208668"},
        {"Hipparcos Number", "HIP 108396"},
        {"Smithsonian Astrophysical Observation", "SAO 107541"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.40597004),
        dec: Angle.Degrees(+11.94729352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44843",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7200 AB"},
        {"Henry Draper", "HD 78376"},
        {"Hipparcos Number", "HIP 44843"},
        {"Smithsonian Astrophysical Observation", "SAO 98382"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.05256730),
        dec: Angle.Degrees(+11.94840043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 267211"},
        {"Hipparcos Number", "HIP 33561"},
        {"Smithsonian Astrophysical Observation", "SAO 96336"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.61025832),
        dec: Angle.Degrees(+11.94886321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185959"},
        {"Hipparcos Number", "HIP 96859"},
        {"Smithsonian Astrophysical Observation", "SAO 105143"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.31965380),
        dec: Angle.Degrees(+11.94886403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10440"},
        {"Hipparcos Number", "HIP 7935"},
        {"Smithsonian Astrophysical Observation", "SAO 92584"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.50215462),
        dec: Angle.Degrees(+11.95237789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204571"},
        {"Hipparcos Number", "HIP 106075"},
        {"Smithsonian Astrophysical Observation", "SAO 107170"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.29942607),
        dec: Angle.Degrees(+11.95305445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200123"},
        {"Hipparcos Number", "HIP 103730"},
        {"Geneva Identification System", "GEN# +1.00200123"},
        {"Smithsonian Astrophysical Observation", "SAO 106757"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.28928977),
        dec: Angle.Degrees(+11.95348541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58686"},
        {"Hipparcos Number", "HIP 36189"},
        {"Smithsonian Astrophysical Observation", "SAO 96908"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.78799793),
        dec: Angle.Degrees(+11.95500568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 357112"},
        {"Hipparcos Number", "HIP 99754"},
    },
    visualMagnitude: 11.39,
    bvColour: 1.948,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.60141778),
        dec: Angle.Degrees(+11.95711209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111164"},
        {"Hipparcos Number", "HIP 62394"},
        {"Geneva Identification System", "GEN# +1.00111164"},
        {"Smithsonian Astrophysical Observation", "SAO 100260"},
        {"Wilson Evans Batten Catalogue", "WEB 11078"},
    },
    visualMagnitude: 6.11,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.80673093),
        dec: Angle.Degrees(+11.95813254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80582"},
        {"Hipparcos Number", "HIP 45855"},
        {"Geneva Identification System", "GEN# +1.00080582"},
        {"Smithsonian Astrophysical Observation", "SAO 98515"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.23678755),
        dec: Angle.Degrees(+11.95867603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188527"},
        {"Hipparcos Number", "HIP 98026"},
        {"Geneva Identification System", "GEN# +1.00188527"},
        {"Smithsonian Astrophysical Observation", "SAO 105419"},
    },
    visualMagnitude: 7.77,
    bvColour: -0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.79768414),
        dec: Angle.Degrees(+11.95945967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23109"},
        {"Hipparcos Number", "HIP 17354"},
        {"Smithsonian Astrophysical Observation", "SAO 93563"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.71712304),
        dec: Angle.Degrees(+11.96040301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8256",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8256"},
        {"Smithsonian Astrophysical Observation", "SAO 92620"},
    },
    visualMagnitude: 10.41,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.57523795),
        dec: Angle.Degrees(+11.96196558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88593",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88593"},
    },
    visualMagnitude: 9.60,
    bvColour: 1.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.34005863),
        dec: Angle.Degrees(+11.96211093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121845"},
        {"Hipparcos Number", "HIP 68200"},
        {"Geneva Identification System", "GEN# +1.00121845"},
        {"Smithsonian Astrophysical Observation", "SAO 100793"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.43942833),
        dec: Angle.Degrees(+11.96235261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33240",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5571 AB"},
        {"Henry Draper", "HD 50722"},
        {"Hipparcos Number", "HIP 33240"},
        {"Smithsonian Astrophysical Observation", "SAO 96270"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.73735210),
        dec: Angle.Degrees(+11.96576101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286513"},
        {"Hipparcos Number", "HIP 19117"},
        {"Geneva Identification System", "GEN# +1.00286513"},
    },
    visualMagnitude: 10.06,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.47616727),
        dec: Angle.Degrees(+11.96612560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 216.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27361"},
        {"Hipparcos Number", "HIP 20174"},
        {"Geneva Identification System", "GEN# +1.00027361"},
        {"Smithsonian Astrophysical Observation", "SAO 93864"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.86902096),
        dec: Angle.Degrees(+11.96617591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118205"},
        {"Hipparcos Number", "HIP 66288"},
        {"Fundamental Katalog 5th Edition", "FK5 5197"},
        {"Geneva Identification System", "GEN# +1.00118205"},
        {"Smithsonian Astrophysical Observation", "SAO 100628"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.79115671),
        dec: Angle.Degrees(+11.96631938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49669",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Regulus"},
        {"Aitken", "ADS 7654 A"},
        {"Henry Draper", "HD 87901"},
        {"Hipparcos Number", "HIP 49669"},
        {"Fundamental Katalog 5th Edition", "FK5 380"},
        {"Geneva Identification System", "GEN# +1.00087901A"},
        {"Smithsonian Astrophysical Observation", "SAO 98967"},
        {"Wilson Evans Batten Catalogue", "WEB 9160"},
    },
    visualMagnitude: 1.36,
    bvColour: -0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.09358075),
        dec: Angle.Degrees(+11.96719513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -249.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166320"},
        {"Hipparcos Number", "HIP 88970"},
        {"Smithsonian Astrophysical Observation", "SAO 103437"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.40338144),
        dec: Angle.Degrees(+11.97015174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95381"},
        {"Hipparcos Number", "HIP 53829"},
        {"Smithsonian Astrophysical Observation", "SAO 99398"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.20017235),
        dec: Angle.Degrees(+11.97053587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74027",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9508 AB"},
        {"Hipparcos Number", "HIP 74027"},
        {"Smithsonian Astrophysical Observation", "SAO 101384"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.91998782),
        dec: Angle.Degrees(+11.97077996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102385",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102385"},
        {"Smithsonian Astrophysical Observation", "SAO 106441"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.19864457),
        dec: Angle.Degrees(+11.97121392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15029"},
        {"Hipparcos Number", "HIP 11309"},
        {"Cincinnati Publication", "Ci 18 312"},
        {"Geneva Identification System", "GEN# +1.00015029"},
        {"Smithsonian Astrophysical Observation", "SAO 92941"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.39171039),
        dec: Angle.Degrees(+11.97191409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -123.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -281.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99647"},
        {"Hipparcos Number", "HIP 55958"},
        {"Smithsonian Astrophysical Observation", "SAO 99616"},
    },
    visualMagnitude: 6.55,
    bvColour: 1.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.00864702),
        dec: Angle.Degrees(+11.97312854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82651",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Mahsati"},
        {"Henry Draper", "HD 152581"},
        {"Hipparcos Number", "HIP 82651"},
        {"Smithsonian Astrophysical Observation", "SAO 102455"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.43156541),
        dec: Angle.Degrees(+11.97378346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4482"},
        {"Hipparcos Number", "HIP 3675"},
        {"Fundamental Katalog 5th Edition", "FK5 2050"},
        {"Geneva Identification System", "GEN# +1.00004482"},
        {"Smithsonian Astrophysical Observation", "SAO 92080"},
        {"Wilson Evans Batten Catalogue", "WEB 652"},
    },
    visualMagnitude: 5.51,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.75594336),
        dec: Angle.Degrees(+11.97393464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10825",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10825"},
        {"Smithsonian Astrophysical Observation", "SAO 92887"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.83599267),
        dec: Angle.Degrees(+11.97495125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18595"},
        {"Hipparcos Number", "HIP 13966"},
        {"Smithsonian Astrophysical Observation", "SAO 93226"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.95990115),
        dec: Angle.Degrees(+11.97791576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27947"},
        {"Hipparcos Number", "HIP 20616"},
        {"Geneva Identification System", "GEN# +1.00027947"},
        {"Smithsonian Astrophysical Observation", "SAO 93919"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.25124467),
        dec: Angle.Degrees(+11.97796391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218611"},
        {"Hipparcos Number", "HIP 114326"},
        {"Smithsonian Astrophysical Observation", "SAO 108431"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.31642844),
        dec: Angle.Degrees(+11.97911527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -199.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113408"},
        {"Hipparcos Number", "HIP 63715"},
        {"Geneva Identification System", "GEN# +1.00113408"},
        {"Smithsonian Astrophysical Observation", "SAO 100397"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.85996217),
        dec: Angle.Degrees(+11.97992195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41473",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41473"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.887,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.88334773),
        dec: Angle.Degrees(+11.98207651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7575",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7575"},
        {"Smithsonian Astrophysical Observation", "SAO 92540"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.39210034),
        dec: Angle.Degrees(+11.98223055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58585",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58585"},
        {"Geneva Identification System", "GEN# +0.01202412"},
        {"Smithsonian Astrophysical Observation", "SAO 99906"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.21205077),
        dec: Angle.Degrees(+11.98333931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111657",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111657"},
        {"Geneva Identification System", "GEN# +9.80018062"},
    },
    visualMagnitude: 10.59,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.28703157),
        dec: Angle.Degrees(+11.98452738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -248.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -188.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98280"},
        {"Hipparcos Number", "HIP 55209"},
        {"Fundamental Katalog 5th Edition", "FK5 4993"},
        {"Geneva Identification System", "GEN# +1.00098280"},
        {"Smithsonian Astrophysical Observation", "SAO 99544"},
        {"Wilson Evans Batten Catalogue", "WEB 9948"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.58764893),
        dec: Angle.Degrees(+11.98462248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2767",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2767"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.732,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.81823350),
        dec: Angle.Degrees(+11.98625166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 244992"},
        {"Hipparcos Number", "HIP 26129"},
        {"Smithsonian Astrophysical Observation", "SAO 94658"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.57336415),
        dec: Angle.Degrees(+11.98886208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162808"},
        {"Hipparcos Number", "HIP 87479"},
        {"Geneva Identification System", "GEN# +1.00162808"},
        {"Smithsonian Astrophysical Observation", "SAO 103164"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.10666942),
        dec: Angle.Degrees(+11.99127426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7232"},
        {"Hipparcos Number", "HIP 5664"},
        {"Smithsonian Astrophysical Observation", "SAO 92313"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.19198567),
        dec: Angle.Degrees(+11.99185703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42401"},
        {"Hipparcos Number", "HIP 29321"},
        {"Celescope Catalog", "CEL 1105"},
        {"Geneva Identification System", "GEN# +1.00042401"},
        {"Smithsonian Astrophysical Observation", "SAO 95343"},
        {"Wilson Evans Batten Catalogue", "WEB 5759"},
    },
    visualMagnitude: 7.46,
    bvColour: -0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.74652841),
        dec: Angle.Degrees(+11.99486509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38797"},
        {"Hipparcos Number", "HIP 27453"},
        {"Celescope Catalog", "CEL 984"},
        {"Geneva Identification System", "GEN# +1.00038797"},
        {"Smithsonian Astrophysical Observation", "SAO 94875"},
    },
    visualMagnitude: 6.93,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.19714214),
        dec: Angle.Degrees(+11.99722537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286935"},
        {"Hipparcos Number", "HIP 21650"},
        {"Smithsonian Astrophysical Observation", "SAO 94050"},
    },
    visualMagnitude: 9.05,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.73363341),
        dec: Angle.Degrees(+11.99732409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69517",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9168 AB"},
        {"Henry Draper", "HD 124517"},
        {"Hipparcos Number", "HIP 69517"},
        {"Smithsonian Astrophysical Observation", "SAO 100922"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.45612150),
        dec: Angle.Degrees(+11.99781397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80903",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80903"},
        {"Geneva Identification System", "GEN# +0.01203028"},
        {"Wilson Evans Batten Catalogue", "WEB 13684"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.82482236),
        dec: Angle.Degrees(+11.99789417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286368"},
        {"Hipparcos Number", "HIP 18443"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.13855687),
        dec: Angle.Degrees(+11.99818869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179313"},
        {"Hipparcos Number", "HIP 94299"},
        {"Smithsonian Astrophysical Observation", "SAO 104575"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.91336013),
        dec: Angle.Degrees(+11.99869555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204278"},
        {"Hipparcos Number", "HIP 105923"},
        {"Smithsonian Astrophysical Observation", "SAO 107143"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.79718388),
        dec: Angle.Degrees(+11.99908017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138216"},
        {"Hipparcos Number", "HIP 75920"},
        {"Smithsonian Astrophysical Observation", "SAO 101585"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.59920112),
        dec: Angle.Degrees(+12.00000277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223961"},
        {"Hipparcos Number", "HIP 117839"},
        {"Smithsonian Astrophysical Observation", "SAO 108895"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.48421277),
        dec: Angle.Degrees(+12.00087941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81218",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81218"},
        {"Smithsonian Astrophysical Observation", "SAO 102254"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.83808295),
        dec: Angle.Degrees(+12.00250468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13921",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13921"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.83503478),
        dec: Angle.Degrees(+12.00282749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88627",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88627"},
        {"Smithsonian Astrophysical Observation", "SAO 103373"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.43042061),
        dec: Angle.Degrees(+12.00385593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37487"},
        {"Hipparcos Number", "HIP 26625"},
        {"Geneva Identification System", "GEN# +1.00037487"},
        {"Smithsonian Astrophysical Observation", "SAO 94732"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.88559317),
        dec: Angle.Degrees(+12.00398239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15489",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15489"},
        {"Smithsonian Astrophysical Observation", "SAO 93385"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.90820015),
        dec: Angle.Degrees(+12.00415223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13461",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13461"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.32890290),
        dec: Angle.Degrees(+12.00464515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59294"},
        {"Hipparcos Number", "HIP 36425"},
        {"Fundamental Katalog 5th Edition", "FK5 1193"},
        {"Geneva Identification System", "GEN# +1.00059294"},
        {"Smithsonian Astrophysical Observation", "SAO 96952"},
        {"Wilson Evans Batten Catalogue", "WEB 7250"},
    },
    visualMagnitude: 4.55,
    bvColour: 1.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.44909205),
        dec: Angle.Degrees(+12.00661101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22375"},
        {"Hipparcos Number", "HIP 16822"},
        {"Smithsonian Astrophysical Observation", "SAO 93510"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.11387872),
        dec: Angle.Degrees(+12.00731420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48122"},
        {"Hipparcos Number", "HIP 32090"},
        {"Geneva Identification System", "GEN# +1.00048122"},
        {"Smithsonian Astrophysical Observation", "SAO 96014"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.849,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.56653477),
        dec: Angle.Degrees(+12.00790330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162690"},
        {"Hipparcos Number", "HIP 87415"},
        {"Smithsonian Astrophysical Observation", "SAO 103157"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.96741628),
        dec: Angle.Degrees(+12.00803125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28968",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4693 AB"},
        {"Henry Draper", "HD 41617"},
        {"Hipparcos Number", "HIP 28968"},
        {"Smithsonian Astrophysical Observation", "SAO 95242"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.70143335),
        dec: Angle.Degrees(+12.01248057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 259916"},
        {"Hipparcos Number", "HIP 31375"},
        {"Smithsonian Astrophysical Observation", "SAO 95858"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.68102738),
        dec: Angle.Degrees(+12.01638568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11225"},
        {"Hipparcos Number", "HIP 8569"},
        {"Smithsonian Astrophysical Observation", "SAO 92656"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.62725273),
        dec: Angle.Degrees(+12.01638771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38445",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38445"},
        {"Smithsonian Astrophysical Observation", "SAO 97326"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.13971102),
        dec: Angle.Degrees(+12.01934741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103950",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103950"},
        {"Geneva Identification System", "GEN# +0.01104463"},
        {"Smithsonian Astrophysical Observation", "SAO 106809"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.93874392),
        dec: Angle.Degrees(+12.02216647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81738",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81738"},
        {"Smithsonian Astrophysical Observation", "SAO 102322"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.43084910),
        dec: Angle.Degrees(+12.02232873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179711"},
        {"Hipparcos Number", "HIP 94430"},
        {"Renson", "Renson 49892"},
        {"Smithsonian Astrophysical Observation", "SAO 104613"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.28945850),
        dec: Angle.Degrees(+12.02270105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132658"},
        {"Hipparcos Number", "HIP 73397"},
        {"Smithsonian Astrophysical Observation", "SAO 101319"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.99812570),
        dec: Angle.Degrees(+12.02393650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221179"},
        {"Hipparcos Number", "HIP 115969"},
        {"Smithsonian Astrophysical Observation", "SAO 108643"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.44312442),
        dec: Angle.Degrees(+12.02452721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104035",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14601 A"},
        {"Henry Draper", "HD 200689"},
        {"Hipparcos Number", "HIP 104035"},
        {"Smithsonian Astrophysical Observation", "SAO 106818"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.15737741),
        dec: Angle.Degrees(+12.02473833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38444",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38444"},
        {"Smithsonian Astrophysical Observation", "SAO 97325"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.13949034),
        dec: Angle.Degrees(+12.02479234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31254"},
        {"Hipparcos Number", "HIP 22823"},
        {"Celescope Catalog", "CEL 482"},
        {"Geneva Identification System", "GEN# +1.00031254"},
        {"Smithsonian Astrophysical Observation", "SAO 94192"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.67166196),
        dec: Angle.Degrees(+12.02581886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176092"},
        {"Hipparcos Number", "HIP 93116"},
        {"Smithsonian Astrophysical Observation", "SAO 104294"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.53271995),
        dec: Angle.Degrees(+12.02780141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6851"},
        {"Hipparcos Number", "HIP 5417"},
        {"Smithsonian Astrophysical Observation", "SAO 92279"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.31158245),
        dec: Angle.Degrees(+12.02894169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217164"},
        {"Hipparcos Number", "HIP 113448"},
        {"Geneva Identification System", "GEN# +1.00217164"},
        {"Smithsonian Astrophysical Observation", "SAO 108301"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.64766375),
        dec: Angle.Degrees(+12.02913313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 110.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181382"},
        {"Hipparcos Number", "HIP 94999"},
        {"Geneva Identification System", "GEN# +1.00181382"},
        {"Smithsonian Astrophysical Observation", "SAO 104726"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.96651874),
        dec: Angle.Degrees(+12.02947325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169111"},
        {"Hipparcos Number", "HIP 90052"},
        {"Geneva Identification System", "GEN# +1.00169111"},
        {"Smithsonian Astrophysical Observation", "SAO 103648"},
        {"Wilson Evans Batten Catalogue", "WEB 15389"},
    },
    visualMagnitude: 5.99,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.64713837),
        dec: Angle.Degrees(+12.02964433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16984"},
        {"Hipparcos Number", "HIP 12740"},
        {"Smithsonian Astrophysical Observation", "SAO 93077"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.95070798),
        dec: Angle.Degrees(+12.02971185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198683"},
        {"Hipparcos Number", "HIP 102968"},
        {"Geneva Identification System", "GEN# +1.00198683"},
        {"Smithsonian Astrophysical Observation", "SAO 106579"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.92979063),
        dec: Angle.Degrees(+12.03561841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64108"},
        {"Hipparcos Number", "HIP 38468"},
        {"Smithsonian Astrophysical Observation", "SAO 97328"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.19224825),
        dec: Angle.Degrees(+12.03567417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207828"},
        {"Hipparcos Number", "HIP 107903"},
        {"Geneva Identification System", "GEN# +1.00207828"},
        {"Smithsonian Astrophysical Observation", "SAO 107447"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.92773606),
        dec: Angle.Degrees(+12.03571529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111119",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111119"},
        {"Smithsonian Astrophysical Observation", "SAO 107965"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.65363819),
        dec: Angle.Degrees(+12.03595400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88356"},
        {"Hipparcos Number", "HIP 49925"},
        {"Geneva Identification System", "GEN# +1.00088356"},
        {"Smithsonian Astrophysical Observation", "SAO 98990"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.89727686),
        dec: Angle.Degrees(+12.03644715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30282",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4986 AB"},
        {"Henry Draper", "HD 44416"},
        {"Hipparcos Number", "HIP 30282"},
        {"Smithsonian Astrophysical Observation", "SAO 95590"},
    },
    visualMagnitude: 8.20,
    bvColour: -0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.54982949),
        dec: Angle.Degrees(+12.03880024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5599"},
        {"Hipparcos Number", "HIP 4515"},
        {"Smithsonian Astrophysical Observation", "SAO 92182"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.46974066),
        dec: Angle.Degrees(+12.03890185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155938"},
        {"Hipparcos Number", "HIP 84308"},
        {"Smithsonian Astrophysical Observation", "SAO 102669"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.54404526),
        dec: Angle.Degrees(+12.03968860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8842",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8842"},
    },
    visualMagnitude: 12.20,
    bvColour: 1.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.43001566),
        dec: Angle.Degrees(+12.03982378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 122.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16760",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16760"},
        {"Geneva Identification System", "GEN# +0.01100495"},
    },
    visualMagnitude: 10.49,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.91218660),
        dec: Angle.Degrees(+12.04045063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -340.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135247"},
        {"Hipparcos Number", "HIP 74528"},
        {"Smithsonian Astrophysical Observation", "SAO 101450"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.44055598),
        dec: Angle.Degrees(+12.04063821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1341"},
        {"Hipparcos Number", "HIP 1410"},
        {"Geneva Identification System", "GEN# +1.00001341"},
        {"Smithsonian Astrophysical Observation", "SAO 91824"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.41554344),
        dec: Angle.Degrees(+12.04242334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184130"},
        {"Hipparcos Number", "HIP 96120"},
        {"Geneva Identification System", "GEN# +1.00184130"},
        {"Smithsonian Astrophysical Observation", "SAO 104950"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.15522552),
        dec: Angle.Degrees(+12.04360369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 242126"},
        {"Hipparcos Number", "HIP 24548"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.99039758),
        dec: Angle.Degrees(+12.04491604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65632",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65632"},
    },
    visualMagnitude: 11.42,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.84531549),
        dec: Angle.Degrees(+12.04574988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -432.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95438"},
        {"Hipparcos Number", "HIP 53859"},
        {"Smithsonian Astrophysical Observation", "SAO 99401"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.27331813),
        dec: Angle.Degrees(+12.04654299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 144.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159736"},
        {"Hipparcos Number", "HIP 86107"},
        {"Fundamental Katalog 5th Edition", "FK5 5545"},
        {"Smithsonian Astrophysical Observation", "SAO 102948"},
    },
    visualMagnitude: 6.76,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.96161044),
        dec: Angle.Degrees(+12.04692216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101710",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14063 AB"},
        {"Henry Draper", "HD 196423"},
        {"Hipparcos Number", "HIP 101710"},
        {"Smithsonian Astrophysical Observation", "SAO 106305"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.24533549),
        dec: Angle.Degrees(+12.04904351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143708"},
        {"Hipparcos Number", "HIP 78506"},
        {"Geneva Identification System", "GEN# +1.00143708"},
        {"Smithsonian Astrophysical Observation", "SAO 101882"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.821,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.40489639),
        dec: Angle.Degrees(+12.05086031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14729",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14729"},
        {"Cincinnati Publication", "Ci 18 415"},
        {"Geneva Identification System", "GEN# +0.01100444"},
        {"Smithsonian Astrophysical Observation", "SAO 93316"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.56255166),
        dec: Angle.Degrees(+12.05088225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 245.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -153.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217163"},
        {"Hipparcos Number", "HIP 113444"},
        {"Geneva Identification System", "GEN# +1.00217163"},
        {"Smithsonian Astrophysical Observation", "SAO 108300"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.63971480),
        dec: Angle.Degrees(+12.05132301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47342",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47342"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.70618148),
        dec: Angle.Degrees(+12.05150129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -126.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76733",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9740 A"},
        {"Henry Draper", "HD 139862"},
        {"Hipparcos Number", "HIP 76733"},
        {"Geneva Identification System", "GEN# +1.00139862A"},
        {"Smithsonian Astrophysical Observation", "SAO 101673"},
        {"Wilson Evans Batten Catalogue", "WEB 13023"},
    },
    visualMagnitude: 6.22,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.04315137),
        dec: Angle.Degrees(+12.05295354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172543"},
        {"Hipparcos Number", "HIP 91559"},
        {"Smithsonian Astrophysical Observation", "SAO 103975"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.07825049),
        dec: Angle.Degrees(+12.05425317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80553",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10065 AB"},
        {"Hipparcos Number", "HIP 80553"},
        {"Smithsonian Astrophysical Observation", "SAO 102175"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.69519094),
        dec: Angle.Degrees(+12.05567990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103355"},
        {"Hipparcos Number", "HIP 58031"},
        {"Smithsonian Astrophysical Observation", "SAO 99852"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.52924614),
        dec: Angle.Degrees(+12.05693226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65631",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65631"},
        {"Smithsonian Astrophysical Observation", "SAO 100572"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.84199267),
        dec: Angle.Degrees(+12.05704215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175354"},
        {"Hipparcos Number", "HIP 92797"},
        {"Smithsonian Astrophysical Observation", "SAO 104245"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.62986419),
        dec: Angle.Degrees(+12.05720077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98514"},
        {"Hipparcos Number", "HIP 55351"},
        {"Smithsonian Astrophysical Observation", "SAO 99558"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.814,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.01854948),
        dec: Angle.Degrees(+12.05728950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195764"},
        {"Hipparcos Number", "HIP 101389"},
        {"Smithsonian Astrophysical Observation", "SAO 106219"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.22035002),
        dec: Angle.Degrees(+12.05729470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49676"},
        {"Hipparcos Number", "HIP 32776"},
        {"Smithsonian Astrophysical Observation", "SAO 96170"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.807,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.50909074),
        dec: Angle.Degrees(+12.05813815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32348"},
        {"Hipparcos Number", "HIP 23492"},
        {"Celescope Catalog", "CEL 516"},
        {"Geneva Identification System", "GEN# +1.00032348"},
        {"Smithsonian Astrophysical Observation", "SAO 94285"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.75670156),
        dec: Angle.Degrees(+12.05929373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95620",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12452 AB"},
        {"Henry Draper", "HD 182991"},
        {"Hipparcos Number", "HIP 95620"},
        {"Smithsonian Astrophysical Observation", "SAO 104842"},
        {"Wilson Evans Batten Catalogue", "WEB 16726"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.73646236),
        dec: Angle.Degrees(+12.06208775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 355657"},
        {"Hipparcos Number", "HIP 96852"},
        {"Geneva Identification System", "GEN# +1.00355657"},
        {"Smithsonian Astrophysical Observation", "SAO 105138"},
        {"Wilson Evans Batten Catalogue", "WEB 17001"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.30367807),
        dec: Angle.Degrees(+12.06243117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3032",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3032"},
        {"Smithsonian Astrophysical Observation", "SAO 92006"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.64168386),
        dec: Angle.Degrees(+12.06281043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 230332"},
        {"Hipparcos Number", "HIP 93251"},
        {"Smithsonian Astrophysical Observation", "SAO 104319"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.92560613),
        dec: Angle.Degrees(+12.06300810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167944"},
        {"Hipparcos Number", "HIP 89595"},
        {"Geneva Identification System", "GEN# +1.00167944"},
        {"Smithsonian Astrophysical Observation", "SAO 103557"},
        {"Wilson Evans Batten Catalogue", "WEB 15259"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.24804415),
        dec: Angle.Degrees(+12.06768878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286802"},
        {"Hipparcos Number", "HIP 20841"},
        {"Smithsonian Astrophysical Observation", "SAO 93946"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.99618401),
        dec: Angle.Degrees(+12.06780165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99921",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99921"},
    },
    visualMagnitude: 11.32,
    bvColour: 1.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.10309922),
        dec: Angle.Degrees(+12.07075606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58442",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58442"},
        {"Geneva Identification System", "GEN# +0.01202405"},
        {"Smithsonian Astrophysical Observation", "SAO 99892"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.76283874),
        dec: Angle.Degrees(+12.07123698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24179"},
        {"Hipparcos Number", "HIP 18049"},
        {"Smithsonian Astrophysical Observation", "SAO 93640"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.86240170),
        dec: Angle.Degrees(+12.07170393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31671",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31671"},
    },
    visualMagnitude: 11.15,
    bvColour: 0.753,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.41703536),
        dec: Angle.Degrees(+12.07282725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -353.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199083"},
        {"Hipparcos Number", "HIP 103195"},
        {"Smithsonian Astrophysical Observation", "SAO 106637"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.60725241),
        dec: Angle.Degrees(+12.07431935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208565"},
        {"Hipparcos Number", "HIP 108339"},
        {"Fundamental Katalog 5th Edition", "FK5 3751"},
        {"Geneva Identification System", "GEN# +1.00208565"},
        {"Smithsonian Astrophysical Observation", "SAO 107528"},
        {"Wilson Evans Batten Catalogue", "WEB 19513"},
    },
    visualMagnitude: 5.54,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.23495325),
        dec: Angle.Degrees(+12.07652564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26334"},
        {"Hipparcos Number", "HIP 19481"},
        {"Smithsonian Astrophysical Observation", "SAO 93799"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.741,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.59008263),
        dec: Angle.Degrees(+12.07739896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 168.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 89.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9986"},
        {"Hipparcos Number", "HIP 7585"},
        {"Geneva Identification System", "GEN# +1.00009986"},
        {"Smithsonian Astrophysical Observation", "SAO 92543"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.42002999),
        dec: Angle.Degrees(+12.07836601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 123.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92457"},
        {"Hipparcos Number", "HIP 52257"},
        {"Smithsonian Astrophysical Observation", "SAO 99245"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.15556142),
        dec: Angle.Degrees(+12.07867800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60821"},
        {"Hipparcos Number", "HIP 37053"},
        {"Geneva Identification System", "GEN# +1.00060821"},
        {"Smithsonian Astrophysical Observation", "SAO 97080"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.21627988),
        dec: Angle.Degrees(+12.07878509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67029",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67029"},
        {"Smithsonian Astrophysical Observation", "SAO 100683"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.05108860),
        dec: Angle.Degrees(+12.07883458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132446"},
        {"Hipparcos Number", "HIP 73307"},
        {"Geneva Identification System", "GEN# +1.00132446"},
        {"Smithsonian Astrophysical Observation", "SAO 101311"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.71927630),
        dec: Angle.Degrees(+12.07976808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6637"},
        {"Hipparcos Number", "HIP 5258"},
        {"Smithsonian Astrophysical Observation", "SAO 92257"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.80365571),
        dec: Angle.Degrees(+12.08031633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198459"},
        {"Hipparcos Number", "HIP 102852"},
        {"Smithsonian Astrophysical Observation", "SAO 106551"},
    },
    visualMagnitude: 8.47,
    bvColour: -0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.54959521),
        dec: Angle.Degrees(+12.08367434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75910",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75910"},
        {"Smithsonian Astrophysical Observation", "SAO 101584"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.58068165),
        dec: Angle.Degrees(+12.08478825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164138"},
        {"Hipparcos Number", "HIP 88080"},
        {"Geneva Identification System", "GEN# +1.00164138"},
        {"Smithsonian Astrophysical Observation", "SAO 103273"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.82712470),
        dec: Angle.Degrees(+12.08581245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82652"},
        {"Hipparcos Number", "HIP 46911"},
        {"Smithsonian Astrophysical Observation", "SAO 98641"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.42239420),
        dec: Angle.Degrees(+12.08734871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49565"},
        {"Hipparcos Number", "HIP 32710"},
        {"Geneva Identification System", "GEN# +1.00049565"},
        {"Smithsonian Astrophysical Observation", "SAO 96152"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.36723906),
        dec: Angle.Degrees(+12.08800831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11558",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11558"},
    },
    visualMagnitude: 12.00,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.22783627),
        dec: Angle.Degrees(+12.08895859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 81.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54223",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54223"},
        {"Smithsonian Astrophysical Observation", "SAO 99431"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.42028871),
        dec: Angle.Degrees(+12.08913944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90078",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90078"},
        {"Smithsonian Astrophysical Observation", "SAO 103657"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.74639016),
        dec: Angle.Degrees(+12.09057338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195410"},
        {"Hipparcos Number", "HIP 101195"},
        {"Smithsonian Astrophysical Observation", "SAO 106186"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.68521612),
        dec: Angle.Degrees(+12.09095673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106984",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106984"},
        {"Smithsonian Astrophysical Observation", "SAO 107314"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.02120410),
        dec: Angle.Degrees(+12.09244341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136903"},
        {"Hipparcos Number", "HIP 75282"},
        {"Geneva Identification System", "GEN# +1.00136903"},
        {"Smithsonian Astrophysical Observation", "SAO 101513"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.71924043),
        dec: Angle.Degrees(+12.09443865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53295"},
        {"Hipparcos Number", "HIP 34157"},
        {"Smithsonian Astrophysical Observation", "SAO 96461"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.24278447),
        dec: Angle.Degrees(+12.09461447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84951"},
        {"Hipparcos Number", "HIP 48161"},
        {"Geneva Identification System", "GEN# +1.00084951"},
        {"Smithsonian Astrophysical Observation", "SAO 98782"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.25018197),
        dec: Angle.Degrees(+12.09633435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -124.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111398"},
        {"Hipparcos Number", "HIP 62536"},
        {"Geneva Identification System", "GEN# +1.00111398"},
        {"Smithsonian Astrophysical Observation", "SAO 100279"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.21784272),
        dec: Angle.Degrees(+12.09671263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 234.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -140.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36262"},
        {"Hipparcos Number", "HIP 25844"},
        {"Geneva Identification System", "GEN# +1.00036262"},
        {"Smithsonian Astrophysical Observation", "SAO 94605"},
        {"Wilson Evans Batten Catalogue", "WEB 5016"},
    },
    visualMagnitude: 7.59,
    bvColour: -0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.75654384),
        dec: Angle.Degrees(+12.09676825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286647"},
        {"Hipparcos Number", "HIP 19886"},
    },
    visualMagnitude: 10.73,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.98816831),
        dec: Angle.Degrees(+12.09945010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286898"},
        {"Hipparcos Number", "HIP 21395"},
        {"Geneva Identification System", "GEN# +5.20251771"},
        {"Smithsonian Astrophysical Observation", "SAO 94023"},
        {"Wilson Evans Batten Catalogue", "WEB 4106"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.89124341),
        dec: Angle.Degrees(+12.10052439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37109"},
        {"Hipparcos Number", "HIP 26341"},
        {"Geneva Identification System", "GEN# +1.00037109"},
        {"Smithsonian Astrophysical Observation", "SAO 94696"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.13944775),
        dec: Angle.Degrees(+12.10074828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195944"},
        {"Hipparcos Number", "HIP 101482"},
        {"Smithsonian Astrophysical Observation", "SAO 106247"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.48786681),
        dec: Angle.Degrees(+12.10165132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88253",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88253"},
        {"Smithsonian Astrophysical Observation", "SAO 103303"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.32338820),
        dec: Angle.Degrees(+12.10540892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117809",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117809"},
    },
    visualMagnitude: 10.72,
    bvColour: 1.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.39798200),
        dec: Angle.Degrees(+12.10645431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86763",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86763"},
        {"Smithsonian Astrophysical Observation", "SAO 103060"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.93143925),
        dec: Angle.Degrees(+12.10667794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126864"},
        {"Hipparcos Number", "HIP 70723"},
        {"Smithsonian Astrophysical Observation", "SAO 101034"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.95357664),
        dec: Angle.Degrees(+12.10672443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4351"},
        {"Hipparcos Number", "HIP 3598"},
        {"Smithsonian Astrophysical Observation", "SAO 92069"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.51755315),
        dec: Angle.Degrees(+12.10734381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52339",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52339"},
        {"Geneva Identification System", "GEN# +9.80045002"},
    },
    visualMagnitude: 11.61,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.45231248),
        dec: Angle.Degrees(+12.10842527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -181.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 181.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35234",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35234"},
        {"Smithsonian Astrophysical Observation", "SAO 96718"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.22445993),
        dec: Angle.Degrees(+12.10906569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129248"},
        {"Hipparcos Number", "HIP 71794"},
        {"Geneva Identification System", "GEN# +1.00129248"},
        {"Smithsonian Astrophysical Observation", "SAO 101144"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.28059424),
        dec: Angle.Degrees(+12.11000507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74873"},
        {"Hipparcos Number", "HIP 43121"},
        {"Geneva Identification System", "GEN# +1.00074873"},
        {"Smithsonian Astrophysical Observation", "SAO 98117"},
        {"Wilson Evans Batten Catalogue", "WEB 8324"},
    },
    visualMagnitude: 5.89,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.73357081),
        dec: Angle.Degrees(+12.11007629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50159",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50159"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.58720783),
        dec: Angle.Degrees(+12.11179426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51786",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51786"},
        {"Smithsonian Astrophysical Observation", "SAO 99187"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.72083183),
        dec: Angle.Degrees(+12.11272394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13297"},
        {"Hipparcos Number", "HIP 10118"},
        {"Geneva Identification System", "GEN# +1.00013297"},
        {"Smithsonian Astrophysical Observation", "SAO 92819"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.53300303),
        dec: Angle.Degrees(+12.11390281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219781"},
        {"Hipparcos Number", "HIP 115066"},
        {"Smithsonian Astrophysical Observation", "SAO 108532"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.59784431),
        dec: Angle.Degrees(+12.11396942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -208.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55730"},
        {"Hipparcos Number", "HIP 35005"},
        {"Fundamental Katalog 5th Edition", "FK5 2559"},
        {"Geneva Identification System", "GEN# +1.00055730"},
        {"Smithsonian Astrophysical Observation", "SAO 96672"},
        {"Wilson Evans Batten Catalogue", "WEB 6999"},
    },
    visualMagnitude: 5.71,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.63604311),
        dec: Angle.Degrees(+12.11586588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121493"},
        {"Hipparcos Number", "HIP 67996"},
        {"Smithsonian Astrophysical Observation", "SAO 100773"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.86981008),
        dec: Angle.Degrees(+12.11638668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 229445"},
        {"Hipparcos Number", "HIP 92125"},
        {"Smithsonian Astrophysical Observation", "SAO 104085"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.65072305),
        dec: Angle.Degrees(+12.11701110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108614"},
        {"Hipparcos Number", "HIP 60871"},
        {"Geneva Identification System", "GEN# +1.00108614"},
        {"Smithsonian Astrophysical Observation", "SAO 100118"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.14335469),
        dec: Angle.Degrees(+12.11749052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84216",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84216"},
    },
    visualMagnitude: 10.75,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.22264295),
        dec: Angle.Degrees(+12.11880869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 256.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 129.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114589",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114589"},
        {"Geneva Identification System", "GEN# +9.80029013"},
    },
    visualMagnitude: 11.20,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.20937944),
        dec: Angle.Degrees(+12.11901323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -280.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14636",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14636"},
    },
    visualMagnitude: 10.54,
    bvColour: 0.866,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.27935593),
        dec: Angle.Degrees(+12.11962439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65343"},
        {"Hipparcos Number", "HIP 38989"},
        {"Fundamental Katalog 5th Edition", "FK5 4717"},
        {"Geneva Identification System", "GEN# +1.00065343"},
        {"Smithsonian Astrophysical Observation", "SAO 97433"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.69161103),
        dec: Angle.Degrees(+12.12070858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87212"},
        {"Hipparcos Number", "HIP 49300"},
        {"Smithsonian Astrophysical Observation", "SAO 98928"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.94393514),
        dec: Angle.Degrees(+12.12213164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127068"},
        {"Hipparcos Number", "HIP 70826"},
        {"Geneva Identification System", "GEN# +1.00127068"},
        {"Smithsonian Astrophysical Observation", "SAO 101044"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.25518779),
        dec: Angle.Degrees(+12.12213350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37376",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37376"},
        {"Geneva Identification System", "GEN# +0.01201631"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.08845887),
        dec: Angle.Degrees(+12.12255694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -287.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108822",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108822"},
    },
    visualMagnitude: 11.98,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.69346401),
        dec: Angle.Degrees(+12.12508993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -354.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5666"},
        {"Hipparcos Number", "HIP 4570"},
        {"Geneva Identification System", "GEN# +1.00005666"},
        {"Smithsonian Astrophysical Observation", "SAO 92187"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.61598551),
        dec: Angle.Degrees(+12.12559576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154796"},
        {"Hipparcos Number", "HIP 83767"},
        {"Geneva Identification System", "GEN# +1.00154796"},
        {"Smithsonian Astrophysical Observation", "SAO 102600"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.79546884),
        dec: Angle.Degrees(+12.12600946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109032"},
        {"Hipparcos Number", "HIP 61135"},
        {"Geneva Identification System", "GEN# +1.00109032"},
        {"Smithsonian Astrophysical Observation", "SAO 100140"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.91415030),
        dec: Angle.Degrees(+12.12784475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73197",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73197"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.39266761),
        dec: Angle.Degrees(+12.12807276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109597",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109597"},
        {"Smithsonian Astrophysical Observation", "SAO 107730"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.01899888),
        dec: Angle.Degrees(+12.12984150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 357219"},
        {"Hipparcos Number", "HIP 100204"},
        {"Smithsonian Astrophysical Observation", "SAO 105959"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.86280891),
        dec: Angle.Degrees(+12.13678959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204862"},
        {"Hipparcos Number", "HIP 106243"},
        {"Geneva Identification System", "GEN# +1.00204862"},
        {"Smithsonian Astrophysical Observation", "SAO 107195"},
        {"Wilson Evans Batten Catalogue", "WEB 19248"},
    },
    visualMagnitude: 6.10,
    bvColour: -0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.79007371),
        dec: Angle.Degrees(+12.13751309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9919"},
        {"Hipparcos Number", "HIP 7535"},
        {"Fundamental Katalog 5th Edition", "FK5 1046"},
        {"Geneva Identification System", "GEN# +1.00009919"},
        {"Renson", "Renson 2450"},
        {"Smithsonian Astrophysical Observation", "SAO 92536"},
        {"Wilson Evans Batten Catalogue", "WEB 1610"},
    },
    visualMagnitude: 5.54,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.27483902),
        dec: Angle.Degrees(+12.14151058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203186"},
        {"Hipparcos Number", "HIP 105360"},
        {"Geneva Identification System", "GEN# +1.00203186"},
        {"Smithsonian Astrophysical Observation", "SAO 107044"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.11050656),
        dec: Angle.Degrees(+12.14161425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91176",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91176"},
        {"Smithsonian Astrophysical Observation", "SAO 103888"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.01133083),
        dec: Angle.Degrees(+12.14263449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 229618"},
        {"Hipparcos Number", "HIP 92372"},
        {"Smithsonian Astrophysical Observation", "SAO 104143"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.37234057),
        dec: Angle.Degrees(+12.14464845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8018"},
        {"Hipparcos Number", "HIP 6216"},
        {"Geneva Identification System", "GEN# +1.00008018"},
        {"Smithsonian Astrophysical Observation", "SAO 92369"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.92830559),
        dec: Angle.Degrees(+12.14580704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225161"},
        {"Hipparcos Number", "HIP 316"},
        {"Smithsonian Astrophysical Observation", "SAO 91683"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.00099668),
        dec: Angle.Degrees(+12.14583388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50802",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50802"},
        {"Geneva Identification System", "GEN# +0.01202201"},
        {"Wilson Evans Batten Catalogue", "WEB 9300"},
    },
    visualMagnitude: 10.37,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.58612532),
        dec: Angle.Degrees(+12.14597746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -304.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50072",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50072"},
        {"Smithsonian Astrophysical Observation", "SAO 99011"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.34951454),
        dec: Angle.Degrees(+12.14604005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189887"},
        {"Hipparcos Number", "HIP 98626"},
        {"Smithsonian Astrophysical Observation", "SAO 105568"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.47889385),
        dec: Angle.Degrees(+12.14655122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106349"},
        {"Hipparcos Number", "HIP 59656"},
        {"Geneva Identification System", "GEN# +1.00106349"},
        {"Smithsonian Astrophysical Observation", "SAO 100002"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.51690943),
        dec: Angle.Degrees(+12.14742433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63497"},
        {"Hipparcos Number", "HIP 38207"},
        {"Smithsonian Astrophysical Observation", "SAO 97284"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.41743374),
        dec: Angle.Degrees(+12.14884724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56350",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56350"},
    },
    visualMagnitude: 12.34,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.26567893),
        dec: Angle.Degrees(+12.15392370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6660",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6660"},
    },
    visualMagnitude: 10.29,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.36848944),
        dec: Angle.Degrees(+12.15619476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -165.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -198.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46695",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46695"},
    },
    visualMagnitude: 11.26,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.78842990),
        dec: Angle.Degrees(+12.15650799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -190.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73202",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73202"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.41619837),
        dec: Angle.Degrees(+12.15751762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27860"},
        {"Hipparcos Number", "HIP 20558"},
        {"Smithsonian Astrophysical Observation", "SAO 93912"},
    },
    visualMagnitude: 6.42,
    bvColour: 1.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.06030427),
        dec: Angle.Degrees(+12.15804100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33241",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33241"},
        {"Wilson Evans Batten Catalogue", "WEB 6686"},
    },
    visualMagnitude: 10.58,
    bvColour: 1.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.73761755),
        dec: Angle.Degrees(+12.15901107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -373.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115373",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115373"},
        {"Geneva Identification System", "GEN# +9.80029025"},
    },
    visualMagnitude: 10.83,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.57504487),
        dec: Angle.Degrees(+12.15933307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 245.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84195"},
        {"Hipparcos Number", "HIP 47720"},
        {"Smithsonian Astrophysical Observation", "SAO 98734"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.93041127),
        dec: Angle.Degrees(+12.15980021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100383",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100383"},
    },
    visualMagnitude: 11.46,
    bvColour: 0.814,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.37309728),
        dec: Angle.Degrees(+12.15991991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58945",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58945"},
        {"Geneva Identification System", "GEN# +6.20030632"},
    },
    visualMagnitude: 11.12,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.29800884),
        dec: Angle.Degrees(+12.16044548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181026"},
        {"Hipparcos Number", "HIP 94870"},
        {"Smithsonian Astrophysical Observation", "SAO 104697"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.59419907),
        dec: Angle.Degrees(+12.16158700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184910"},
        {"Hipparcos Number", "HIP 96420"},
        {"Smithsonian Astrophysical Observation", "SAO 105034"},
    },
    visualMagnitude: 6.72,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.04853837),
        dec: Angle.Degrees(+12.16163891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83191",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83191"},
        {"Smithsonian Astrophysical Observation", "SAO 102520"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.03313994),
        dec: Angle.Degrees(+12.16194121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131043"},
        {"Hipparcos Number", "HIP 72637"},
        {"Smithsonian Astrophysical Observation", "SAO 101245"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.76187605),
        dec: Angle.Degrees(+12.16411317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240530"},
        {"Hipparcos Number", "HIP 23597"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.11071422),
        dec: Angle.Degrees(+12.16506712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120934"},
        {"Hipparcos Number", "HIP 67714"},
        {"Fundamental Katalog 5th Edition", "FK5 3104"},
        {"Geneva Identification System", "GEN# +1.00120934"},
        {"Smithsonian Astrophysical Observation", "SAO 100745"},
        {"Wilson Evans Batten Catalogue", "WEB 11909"},
    },
    visualMagnitude: 6.10,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.07662469),
        dec: Angle.Degrees(+12.16515892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71449",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9322 B"},
        {"Hipparcos Number", "HIP 71449"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.17707251),
        dec: Angle.Degrees(+12.16565321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54377"},
        {"Hipparcos Number", "HIP 34512"},
        {"Smithsonian Astrophysical Observation", "SAO 96562"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.27214037),
        dec: Angle.Degrees(+12.16675052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87097",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87097"},
        {"Smithsonian Astrophysical Observation", "SAO 103112"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.93751552),
        dec: Angle.Degrees(+12.16829615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173272"},
        {"Hipparcos Number", "HIP 91890"},
        {"Smithsonian Astrophysical Observation", "SAO 104035"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.98353676),
        dec: Angle.Degrees(+12.16876392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9764",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9764"},
        {"Geneva Identification System", "GEN# +0.01100275"},
    },
    visualMagnitude: 10.03,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.38195979),
        dec: Angle.Degrees(+12.16887073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143972"},
        {"Hipparcos Number", "HIP 78614"},
        {"Smithsonian Astrophysical Observation", "SAO 101892"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.74289092),
        dec: Angle.Degrees(+12.16918447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133052"},
        {"Hipparcos Number", "HIP 73569"},
        {"Smithsonian Astrophysical Observation", "SAO 101339"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.745,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.53082123),
        dec: Angle.Degrees(+12.16954551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71448",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9322 A"},
        {"Henry Draper", "HD 128460"},
        {"Hipparcos Number", "HIP 71448"},
        {"Smithsonian Astrophysical Observation", "SAO 101103"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.17662026),
        dec: Angle.Degrees(+12.16957488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58877"},
        {"Hipparcos Number", "HIP 36261"},
        {"Smithsonian Astrophysical Observation", "SAO 96919"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.99931264),
        dec: Angle.Degrees(+12.16959712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211016"},
        {"Hipparcos Number", "HIP 109772"},
        {"Geneva Identification System", "GEN# +1.00211016"},
        {"Smithsonian Astrophysical Observation", "SAO 107752"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.51312901),
        dec: Angle.Degrees(+12.17201058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38269"},
        {"Hipparcos Number", "HIP 27125"},
        {"Smithsonian Astrophysical Observation", "SAO 94832"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.28276281),
        dec: Angle.Degrees(+12.17336651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112447",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16261 A"},
        {"Henry Draper", "HD 215648"},
        {"Hipparcos Number", "HIP 112447"},
        {"Cincinnati Publication", "Ci 20 1381"},
        {"Geneva Identification System", "GEN# +1.00215648"},
        {"Smithsonian Astrophysical Observation", "SAO 108165"},
        {"Wilson Evans Batten Catalogue", "WEB 20055"},
    },
    visualMagnitude: 4.20,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.67267295),
        dec: Angle.Degrees(+12.17408381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 233.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -492.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188018"},
        {"Hipparcos Number", "HIP 97823"},
        {"Smithsonian Astrophysical Observation", "SAO 105368"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.18169141),
        dec: Angle.Degrees(+12.17457205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177700"},
        {"Hipparcos Number", "HIP 93750"},
        {"Smithsonian Astrophysical Observation", "SAO 104460"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.35565979),
        dec: Angle.Degrees(+12.17529046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42660",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42660"},
        {"Smithsonian Astrophysical Observation", "SAO 98049"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.42191578),
        dec: Angle.Degrees(+12.17569489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28449"},
        {"Hipparcos Number", "HIP 20960"},
        {"Geneva Identification System", "GEN# +1.00028449"},
        {"Smithsonian Astrophysical Observation", "SAO 93966"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.41957692),
        dec: Angle.Degrees(+12.17585670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100870"},
        {"Hipparcos Number", "HIP 56624"},
        {"Geneva Identification System", "GEN# +1.00100870"},
        {"Smithsonian Astrophysical Observation", "SAO 99690"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.16086984),
        dec: Angle.Degrees(+12.17727635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 246132"},
        {"Hipparcos Number", "HIP 26676"},
        {"Geneva Identification System", "GEN# +1.00246132"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.03988093),
        dec: Angle.Degrees(+12.17827427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 271.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66637"},
        {"Hipparcos Number", "HIP 39550"},
        {"Smithsonian Astrophysical Observation", "SAO 97540"},
        {"Wilson Evans Batten Catalogue", "WEB 7730"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.22528990),
        dec: Angle.Degrees(+12.17871382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42661",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42661"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.42373897),
        dec: Angle.Degrees(+12.17937191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61189",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61189"},
    },
    visualMagnitude: 11.02,
    bvColour: 1.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.06821339),
        dec: Angle.Degrees(+12.17939866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -268.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 249603"},
        {"Hipparcos Number", "HIP 28182"},
        {"Smithsonian Astrophysical Observation", "SAO 95041"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.779,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.31797313),
        dec: Angle.Degrees(+12.17960234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -137.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15942"},
        {"Hipparcos Number", "HIP 11941"},
        {"Geneva Identification System", "GEN# +1.00015942"},
        {"Smithsonian Astrophysical Observation", "SAO 93004"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.51471313),
        dec: Angle.Degrees(+12.18094738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 181.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47127"},
        {"Hipparcos Number", "HIP 31660"},
        {"Geneva Identification System", "GEN# +1.00047127"},
        {"Smithsonian Astrophysical Observation", "SAO 95907"},
        {"Wilson Evans Batten Catalogue", "WEB 6341"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.39143708),
        dec: Angle.Degrees(+12.18124820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -284.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9490",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1614 AB"},
        {"Henry Draper", "HD 12427"},
        {"Hipparcos Number", "HIP 9490"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.52476112),
        dec: Angle.Degrees(+12.18133839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39418",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6546 A"},
        {"Henry Draper", "HD 66348"},
        {"Hipparcos Number", "HIP 39418"},
        {"Smithsonian Astrophysical Observation", "SAO 97514"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.87003667),
        dec: Angle.Degrees(+12.18144160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -126.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106074",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15010 ABC"},
        {"Hipparcos Number", "HIP 106074"},
        {"Wilson Evans Batten Catalogue", "WEB 19226"},
    },
    visualMagnitude: 11.17,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.27894287),
        dec: Angle.Degrees(+12.18412213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 155.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -460.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158297"},
        {"Hipparcos Number", "HIP 85472"},
        {"Smithsonian Astrophysical Observation", "SAO 102838"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.753,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.00860137),
        dec: Angle.Degrees(+12.18537115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90823"},
        {"Hipparcos Number", "HIP 51360"},
        {"Geneva Identification System", "GEN# +1.00090823"},
        {"Smithsonian Astrophysical Observation", "SAO 99157"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.35693402),
        dec: Angle.Degrees(+12.18702281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36027",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36027"},
        {"Smithsonian Astrophysical Observation", "SAO 96882"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.36094185),
        dec: Angle.Degrees(+12.18813191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286554"},
        {"Hipparcos Number", "HIP 19316"},
        {"Geneva Identification System", "GEN# +5.20252014"},
    },
    visualMagnitude: 11.28,
    bvColour: 1.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.11081699),
        dec: Angle.Degrees(+12.19187175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217231"},
        {"Hipparcos Number", "HIP 113514"},
        {"Geneva Identification System", "GEN# +1.00217231"},
        {"Smithsonian Astrophysical Observation", "SAO 108311"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.83023401),
        dec: Angle.Degrees(+12.19271430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 334.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -153.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186122"},
        {"Hipparcos Number", "HIP 96931"},
        {"Geneva Identification System", "GEN# +1.00186122"},
        {"Renson", "Renson 51330"},
        {"Smithsonian Astrophysical Observation", "SAO 105156"},
        {"Wilson Evans Batten Catalogue", "WEB 17011"},
    },
    visualMagnitude: 6.33,
    bvColour: -0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.55338688),
        dec: Angle.Degrees(+12.19328167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168431"},
        {"Hipparcos Number", "HIP 89767"},
        {"Smithsonian Astrophysical Observation", "SAO 103602"},
        {"Wilson Evans Batten Catalogue", "WEB 15309"},
    },
    visualMagnitude: 7.10,
    bvColour: -0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.77496049),
        dec: Angle.Degrees(+12.19333051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222250"},
        {"Hipparcos Number", "HIP 116695"},
        {"Smithsonian Astrophysical Observation", "SAO 108746"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.72293626),
        dec: Angle.Degrees(+12.19451716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14306"},
        {"Hipparcos Number", "HIP 10796"},
        {"Smithsonian Astrophysical Observation", "SAO 92883"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.74214717),
        dec: Angle.Degrees(+12.19466250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109154",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109154"},
        {"Smithsonian Astrophysical Observation", "SAO 107666"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.65798115),
        dec: Angle.Degrees(+12.19674004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29589"},
        {"Hipparcos Number", "HIP 21735"},
        {"Celescope Catalog", "CEL 453"},
        {"Geneva Identification System", "GEN# +1.00029589"},
        {"Renson", "Renson 7600"},
        {"Smithsonian Astrophysical Observation", "SAO 94063"},
        {"Wilson Evans Batten Catalogue", "WEB 4180"},
    },
    visualMagnitude: 5.45,
    bvColour: -0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.01424281),
        dec: Angle.Degrees(+12.19764088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168179"},
        {"Hipparcos Number", "HIP 89676"},
        {"Smithsonian Astrophysical Observation", "SAO 103577"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.51040423),
        dec: Angle.Degrees(+12.19860563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100267"},
        {"Hipparcos Number", "HIP 56294"},
        {"Geneva Identification System", "GEN# +1.00100267"},
        {"Smithsonian Astrophysical Observation", "SAO 99652"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.09838416),
        dec: Angle.Degrees(+12.20445062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -116.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212076"},
        {"Hipparcos Number", "HIP 110386"},
        {"Fundamental Katalog 5th Edition", "FK5 843"},
        {"Geneva Identification System", "GEN# +1.00212076"},
        {"Smithsonian Astrophysical Observation", "SAO 107854"},
        {"Wilson Evans Batten Catalogue", "WEB 19796"},
    },
    visualMagnitude: 4.82,
    bvColour: -0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.37946377),
        dec: Angle.Degrees(+12.20517262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177810"},
        {"Hipparcos Number", "HIP 93773"},
        {"Geneva Identification System", "GEN# +1.00177810"},
        {"Smithsonian Astrophysical Observation", "SAO 104467"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.45076119),
        dec: Angle.Degrees(+12.20754868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12155",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12155"},
        {"Geneva Identification System", "GEN# +9.80076013"},
    },
    visualMagnitude: 11.73,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.16020383),
        dec: Angle.Degrees(+12.20820770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 233.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39740",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39740"},
        {"Smithsonian Astrophysical Observation", "SAO 97571"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.83150521),
        dec: Angle.Degrees(+12.20960181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29862"},
        {"Hipparcos Number", "HIP 21918"},
        {"Geneva Identification System", "GEN# +1.00029862"},
        {"Smithsonian Astrophysical Observation", "SAO 94079"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.70327240),
        dec: Angle.Degrees(+12.21031810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -227.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172693"},
        {"Hipparcos Number", "HIP 91622"},
        {"Geneva Identification System", "GEN# +1.00172693"},
        {"Smithsonian Astrophysical Observation", "SAO 103986"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.28253779),
        dec: Angle.Degrees(+12.21033367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64338",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64338"},
        {"Smithsonian Astrophysical Observation", "SAO 100450"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.81806124),
        dec: Angle.Degrees(+12.21221902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87358",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87358"},
        {"Smithsonian Astrophysical Observation", "SAO 103148"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.75441972),
        dec: Angle.Degrees(+12.21339136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65694"},
        {"Hipparcos Number", "HIP 39140"},
        {"Smithsonian Astrophysical Observation", "SAO 97462"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.08976172),
        dec: Angle.Degrees(+12.21370266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286425"},
        {"Hipparcos Number", "HIP 18752"},
    },
    visualMagnitude: 10.54,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.24939250),
        dec: Angle.Degrees(+12.21437594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105937",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105937"},
        {"Smithsonian Astrophysical Observation", "SAO 107145"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.82347196),
        dec: Angle.Degrees(+12.21465821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147528"},
        {"Hipparcos Number", "HIP 80182"},
        {"Geneva Identification System", "GEN# +1.00147528"},
        {"Smithsonian Astrophysical Observation", "SAO 102108"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.52928408),
        dec: Angle.Degrees(+12.21472341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286850"},
        {"Hipparcos Number", "HIP 21194"},
    },
    visualMagnitude: 10.93,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.16451381),
        dec: Angle.Degrees(+12.21677319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -150.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192955"},
        {"Hipparcos Number", "HIP 100010"},
        {"Smithsonian Astrophysical Observation", "SAO 105929"},
    },
    visualMagnitude: 8.45,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.34488284),
        dec: Angle.Degrees(+12.21798332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77709"},
        {"Hipparcos Number", "HIP 44539"},
        {"Smithsonian Astrophysical Observation", "SAO 98336"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.12416537),
        dec: Angle.Degrees(+12.21885571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99328"},
        {"Hipparcos Number", "HIP 55799"},
        {"Smithsonian Astrophysical Observation", "SAO 99602"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.49760451),
        dec: Angle.Degrees(+12.22236233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50261",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50261"},
        {"Smithsonian Astrophysical Observation", "SAO 99028"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.95093744),
        dec: Angle.Degrees(+12.22451209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78162",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78162"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.40565907),
        dec: Angle.Degrees(+12.22571787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93330",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11926 AB"},
        {"Henry Draper", "HD 176584"},
        {"Hipparcos Number", "HIP 93330"},
        {"Smithsonian Astrophysical Observation", "SAO 104344"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.14322818),
        dec: Angle.Degrees(+12.22618142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191295"},
        {"Hipparcos Number", "HIP 99250"},
        {"Geneva Identification System", "GEN# +9.00051032"},
        {"Geneva Identification System 2", "GEN# +9.00060032"},
        {"Smithsonian Astrophysical Observation", "SAO 105748"},
        {"Wilson Evans Batten Catalogue", "WEB 17685"},
    },
    visualMagnitude: 7.18,
    bvColour: -0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.20698281),
        dec: Angle.Degrees(+12.22841032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190869"},
        {"Hipparcos Number", "HIP 99056"},
        {"Smithsonian Astrophysical Observation", "SAO 105699"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.66578837),
        dec: Angle.Degrees(+12.23079584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113140",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113140"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.66958160),
        dec: Angle.Degrees(+12.23115636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70899"},
        {"Hipparcos Number", "HIP 41247"},
        {"Smithsonian Astrophysical Observation", "SAO 97801"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.948,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.23260696),
        dec: Angle.Degrees(+12.23616105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1174",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1174"},
        {"Smithsonian Astrophysical Observation", "SAO 91793"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.66359601),
        dec: Angle.Degrees(+12.23639889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172744"},
        {"Hipparcos Number", "HIP 91659"},
        {"Geneva Identification System", "GEN# +1.00172744"},
        {"Smithsonian Astrophysical Observation", "SAO 103989"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.36877818),
        dec: Angle.Degrees(+12.23653353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13826"},
        {"Hipparcos Number", "HIP 10472"},
        {"Geneva Identification System", "GEN# +1.00013826"},
        {"Smithsonian Astrophysical Observation", "SAO 92853"},
        {"Wilson Evans Batten Catalogue", "WEB 2196"},
    },
    visualMagnitude: 8.52,
    bvColour: 2.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.75017040),
        dec: Angle.Degrees(+12.23978264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213582"},
        {"Hipparcos Number", "HIP 111248"},
        {"Smithsonian Astrophysical Observation", "SAO 107983"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.08151017),
        dec: Angle.Degrees(+12.24035418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50059"},
        {"Hipparcos Number", "HIP 32969"},
        {"Smithsonian Astrophysical Observation", "SAO 96213"},
    },
    visualMagnitude: 8.50,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.00587749),
        dec: Angle.Degrees(+12.24094995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123725"},
        {"Hipparcos Number", "HIP 69136"},
        {"Smithsonian Astrophysical Observation", "SAO 100874"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.28748411),
        dec: Angle.Degrees(+12.24444184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64881",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64881"},
        {"Geneva Identification System", "GEN# +0.01302652"},
        {"Smithsonian Astrophysical Observation", "SAO 100503"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.49498817),
        dec: Angle.Degrees(+12.24481331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86898"},
        {"Hipparcos Number", "HIP 49158"},
        {"Geneva Identification System", "GEN# +1.00086898"},
        {"Smithsonian Astrophysical Observation", "SAO 98906"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.48302480),
        dec: Angle.Degrees(+12.24580358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164697"},
        {"Hipparcos Number", "HIP 88303"},
        {"Smithsonian Astrophysical Observation", "SAO 103313"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.49255842),
        dec: Angle.Degrees(+12.24866429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65104",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65104"},
        {"Geneva Identification System", "GEN# +0.01302657"},
        {"Smithsonian Astrophysical Observation", "SAO 100521"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.13079772),
        dec: Angle.Degrees(+12.24872616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -159.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110900",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15962"},
        {"Henry Draper", "HD 212989"},
        {"Hipparcos Number", "HIP 110900"},
        {"Geneva Identification System", "GEN# +1.00212989J"},
        {"Smithsonian Astrophysical Observation", "SAO 107935"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.03018264),
        dec: Angle.Degrees(+12.24873874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 196.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45216",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45216"},
        {"Smithsonian Astrophysical Observation", "SAO 98436"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.22658530),
        dec: Angle.Degrees(+12.24893302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178452"},
        {"Henry Draper 2", "HD 178453"},
        {"Hipparcos Number", "HIP 93992"},
        {"Smithsonian Astrophysical Observation", "SAO 104515"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.06009754),
        dec: Angle.Degrees(+12.25059215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11738"},
        {"Hipparcos Number", "HIP 8964"},
        {"Smithsonian Astrophysical Observation", "SAO 92696"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.86512650),
        dec: Angle.Degrees(+12.25083904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35880"},
        {"Hipparcos Number", "HIP 25609"},
        {"Smithsonian Astrophysical Observation", "SAO 94578"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.06685415),
        dec: Angle.Degrees(+12.25213503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139609"},
        {"Hipparcos Number", "HIP 76612"},
        {"Geneva Identification System", "GEN# +1.00139609"},
        {"Renson", "Renson 39726"},
        {"Smithsonian Astrophysical Observation", "SAO 101663"},
        {"Wilson Evans Batten Catalogue", "WEB 13005"},
    },
    visualMagnitude: 7.44,
    bvColour: -0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.68347586),
        dec: Angle.Degrees(+12.25325387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135246"},
        {"Hipparcos Number", "HIP 74526"},
        {"Smithsonian Astrophysical Observation", "SAO 101449"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.43825063),
        dec: Angle.Degrees(+12.25411940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172827"},
        {"Hipparcos Number", "HIP 91685"},
        {"Smithsonian Astrophysical Observation", "SAO 103995"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.45686390),
        dec: Angle.Degrees(+12.25558649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205354"},
        {"Hipparcos Number", "HIP 106513"},
        {"Geneva Identification System", "GEN# +1.00205354"},
        {"Smithsonian Astrophysical Observation", "SAO 107241"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.59835503),
        dec: Angle.Degrees(+12.25714423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -138.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15904",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15904"},
        {"Geneva Identification System", "GEN# +0.01100468"},
    },
    visualMagnitude: 10.76,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.20842976),
        dec: Angle.Degrees(+12.25777908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 566.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -493.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14611"},
        {"Hipparcos Number", "HIP 11019"},
        {"Geneva Identification System", "GEN# +1.00014611"},
        {"Smithsonian Astrophysical Observation", "SAO 92902"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.46885320),
        dec: Angle.Degrees(+12.25937303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17285"},
        {"Hipparcos Number", "HIP 12975"},
        {"Smithsonian Astrophysical Observation", "SAO 93098"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.72037550),
        dec: Angle.Degrees(+12.26067484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119865"},
        {"Hipparcos Number", "HIP 67150"},
        {"Geneva Identification System", "GEN# +1.00119865"},
        {"Smithsonian Astrophysical Observation", "SAO 100696"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.41537759),
        dec: Angle.Degrees(+12.26154714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224759"},
        {"Hipparcos Number", "HIP 36"},
        {"Smithsonian Astrophysical Observation", "SAO 108956"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.10327550),
        dec: Angle.Degrees(+12.26709303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93928"},
        {"Hipparcos Number", "HIP 53014"},
        {"Smithsonian Astrophysical Observation", "SAO 99317"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.905,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.68988910),
        dec: Angle.Degrees(+12.26756825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25978"},
        {"Hipparcos Number", "HIP 19223"},
        {"Geneva Identification System", "GEN# +1.00025978"},
        {"Smithsonian Astrophysical Observation", "SAO 93771"},
        {"Wilson Evans Batten Catalogue", "WEB 3689"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.79654969),
        dec: Angle.Degrees(+12.26823481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172009"},
        {"Hipparcos Number", "HIP 91295"},
        {"Geneva Identification System", "GEN# +1.00172009"},
        {"Smithsonian Astrophysical Observation", "SAO 103915"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.32543225),
        dec: Angle.Degrees(+12.26879811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -173.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40331",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40331"},
        {"Smithsonian Astrophysical Observation", "SAO 97668"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.52202181),
        dec: Angle.Degrees(+12.26909981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16353"},
        {"Hipparcos Number", "HIP 12252"},
        {"Geneva Identification System", "GEN# +1.00016353"},
        {"Smithsonian Astrophysical Observation", "SAO 93029"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.43888479),
        dec: Angle.Degrees(+12.26960750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143242"},
        {"Hipparcos Number", "HIP 78275"},
        {"Geneva Identification System", "GEN# +1.00143242"},
        {"Smithsonian Astrophysical Observation", "SAO 101847"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.73788438),
        dec: Angle.Degrees(+12.27021255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36104"},
        {"Hipparcos Number", "HIP 25742"},
        {"Geneva Identification System", "GEN# +1.00036104"},
        {"Smithsonian Astrophysical Observation", "SAO 94592"},
        {"Wilson Evans Batten Catalogue", "WEB 4998"},
    },
    visualMagnitude: 7.03,
    bvColour: -0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.44791805),
        dec: Angle.Degrees(+12.27064210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67917",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67917"},
        {"Smithsonian Astrophysical Observation", "SAO 100765"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.65615124),
        dec: Angle.Degrees(+12.27078029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204712"},
        {"Hipparcos Number", "HIP 106157"},
        {"Geneva Identification System", "GEN# +1.00204712"},
        {"Smithsonian Astrophysical Observation", "SAO 107179"},
        {"Wilson Evans Batten Catalogue", "WEB 19240"},
        {"New General Catalogue", "NGC 7078 1018"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.53545018),
        dec: Angle.Degrees(+12.27103763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -143.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43386"},
        {"Hipparcos Number", "HIP 29800"},
        {"Celescope Catalog", "CEL 1154"},
        {"Fundamental Katalog 5th Edition", "FK5 1169"},
        {"Geneva Identification System", "GEN# +1.00043386"},
        {"Smithsonian Astrophysical Observation", "SAO 95476"},
        {"Wilson Evans Batten Catalogue", "WEB 5887"},
    },
    visualMagnitude: 5.04,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.11070845),
        dec: Angle.Degrees(+12.27171030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 186.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114016"},
        {"Hipparcos Number", "HIP 64046"},
        {"Geneva Identification System", "GEN# +1.00114016"},
        {"Smithsonian Astrophysical Observation", "SAO 100424"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.89320599),
        dec: Angle.Degrees(+12.27347800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129154"},
        {"Hipparcos Number", "HIP 71757"},
        {"Smithsonian Astrophysical Observation", "SAO 101136"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.17081987),
        dec: Angle.Degrees(+12.27872701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57779",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8320 A"},
        {"Henry Draper", "HD 102910"},
        {"Hipparcos Number", "HIP 57779"},
        {"Fundamental Katalog 5th Edition", "FK5 2946"},
        {"Geneva Identification System", "GEN# +1.00102910A"},
        {"Renson", "Renson 29720"},
        {"Smithsonian Astrophysical Observation", "SAO 99827"},
        {"Wilson Evans Batten Catalogue", "WEB 10367"},
    },
    visualMagnitude: 6.37,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.73092864),
        dec: Angle.Degrees(+12.27897116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -136.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84428",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84428"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.91284710),
        dec: Angle.Degrees(+12.28131806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7193"},
        {"Hipparcos Number", "HIP 5631"},
        {"Geneva Identification System", "GEN# +1.00007193"},
        {"Smithsonian Astrophysical Observation", "SAO 92310"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.08000516),
        dec: Angle.Degrees(+12.28194637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58869",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58869"},
    },
    visualMagnitude: 11.07,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.08221635),
        dec: Angle.Degrees(+12.28280135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -283.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182491"},
        {"Hipparcos Number", "HIP 95406"},
        {"Smithsonian Astrophysical Observation", "SAO 104796"},
        {"Wilson Evans Batten Catalogue", "WEB 16679"},
    },
    visualMagnitude: 7.02,
    bvColour: 1.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.11461029),
        dec: Angle.Degrees(+12.28285357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13739"},
        {"Hipparcos Number", "HIP 10415"},
        {"Smithsonian Astrophysical Observation", "SAO 92847"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.55245646),
        dec: Angle.Degrees(+12.28392214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101676"},
        {"Hipparcos Number", "HIP 57080"},
        {"Geneva Identification System", "GEN# +1.00101676"},
        {"Smithsonian Astrophysical Observation", "SAO 99743"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.51647974),
        dec: Angle.Degrees(+12.28521965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85506",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85506"},
        {"Smithsonian Astrophysical Observation", "SAO 102844"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.11131271),
        dec: Angle.Degrees(+12.28559765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -115.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -273.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11802"},
        {"Hipparcos Number", "HIP 9016"},
        {"Smithsonian Astrophysical Observation", "SAO 92704"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.01481768),
        dec: Angle.Degrees(+12.28929412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39495",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6554 AB"},
        {"Henry Draper", "HD 66509"},
        {"Hipparcos Number", "HIP 39495"},
        {"Geneva Identification System", "GEN# +1.00066509J"},
        {"Smithsonian Astrophysical Observation", "SAO 97530"},
        {"Wilson Evans Batten Catalogue", "WEB 7721"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.845,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.09623348),
        dec: Angle.Degrees(+12.28994712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -147.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89179"},
        {"Hipparcos Number", "HIP 50396"},
        {"Smithsonian Astrophysical Observation", "SAO 99038"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.36059235),
        dec: Angle.Degrees(+12.29059593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30070",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4939 A"},
        {"Henry Draper", "HD 43983"},
        {"Hipparcos Number", "HIP 30070"},
        {"Celescope Catalog", "CEL 1175"},
        {"Smithsonian Astrophysical Observation", "SAO 95540"},
    },
    visualMagnitude: 7.65,
    bvColour: -0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.92142251),
        dec: Angle.Degrees(+12.29268375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12140"},
        {"Hipparcos Number", "HIP 9295"},
        {"Fundamental Katalog 5th Edition", "FK5 2136"},
        {"Geneva Identification System", "GEN# +1.00012140"},
        {"Smithsonian Astrophysical Observation", "SAO 92739"},
        {"Wilson Evans Batten Catalogue", "WEB 1951"},
    },
    visualMagnitude: 6.09,
    bvColour: 0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.85783536),
        dec: Angle.Degrees(+12.29495706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150280"},
        {"Hipparcos Number", "HIP 81571"},
        {"Geneva Identification System", "GEN# +1.00150280"},
        {"Smithsonian Astrophysical Observation", "SAO 102298"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.89424094),
        dec: Angle.Degrees(+12.29640113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7781"},
        {"Hipparcos Number", "HIP 6043"},
        {"Smithsonian Astrophysical Observation", "SAO 92351"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.40226467),
        dec: Angle.Degrees(+12.29642674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139375"},
        {"Hipparcos Number", "HIP 76492"},
        {"Geneva Identification System", "GEN# +1.00139375"},
        {"Smithsonian Astrophysical Observation", "SAO 101651"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.34839868),
        dec: Angle.Degrees(+12.30155396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36843",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6180 AB"},
        {"Henry Draper", "HD 60355"},
        {"Hipparcos Number", "HIP 36843"},
        {"Smithsonian Astrophysical Observation", "SAO 97033"},
    },
    visualMagnitude: 7.30,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.63334381),
        dec: Angle.Degrees(+12.30472473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154515"},
        {"Hipparcos Number", "HIP 83624"},
        {"Smithsonian Astrophysical Observation", "SAO 102587"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.35968591),
        dec: Angle.Degrees(+12.31030618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1646",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 281 AB"},
        {"Henry Draper", "HD 1634"},
        {"Hipparcos Number", "HIP 1646"},
        {"Smithsonian Astrophysical Observation", "SAO 91856"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.15926011),
        dec: Angle.Degrees(+12.31104578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29837"},
        {"Hipparcos Number", "HIP 21904"},
        {"Geneva Identification System", "GEN# +1.00029837"},
        {"Smithsonian Astrophysical Observation", "SAO 94077"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.755,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.65599105),
        dec: Angle.Degrees(+12.31112335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197684"},
        {"Hipparcos Number", "HIP 102390"},
        {"Geneva Identification System", "GEN# +1.00197684"},
        {"Smithsonian Astrophysical Observation", "SAO 106443"},
        {"Wilson Evans Batten Catalogue", "WEB 18535"},
    },
    visualMagnitude: 6.71,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.22740026),
        dec: Angle.Degrees(+12.31265600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115444",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16715 AB"},
        {"Henry Draper", "HD 220363"},
        {"Hipparcos Number", "HIP 115444"},
        {"Geneva Identification System", "GEN# +1.00220363J"},
        {"Smithsonian Astrophysical Observation", "SAO 108580"},
        {"Wilson Evans Batten Catalogue", "WEB 20442"},
    },
    visualMagnitude: 5.09,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.76898818),
        dec: Angle.Degrees(+12.31395190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80235"},
        {"Hipparcos Number", "HIP 45695"},
        {"Smithsonian Astrophysical Observation", "SAO 98489"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.73156563),
        dec: Angle.Degrees(+12.31779872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114381"},
        {"Hipparcos Number", "HIP 64248"},
        {"Geneva Identification System", "GEN# +1.00114381"},
        {"Smithsonian Astrophysical Observation", "SAO 100444"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.51969295),
        dec: Angle.Degrees(+12.32035225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189920"},
        {"Hipparcos Number", "HIP 98640"},
        {"Geneva Identification System", "GEN# +9.00051025"},
        {"Smithsonian Astrophysical Observation", "SAO 105571"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.52056595),
        dec: Angle.Degrees(+12.32209557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114015"},
        {"Hipparcos Number", "HIP 64038"},
        {"Smithsonian Astrophysical Observation", "SAO 100423"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.86646743),
        dec: Angle.Degrees(+12.32405065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -116.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13384"},
        {"Hipparcos Number", "HIP 10197"},
        {"Smithsonian Astrophysical Observation", "SAO 92827"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.78430574),
        dec: Angle.Degrees(+12.32518848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37969",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37969"},
    },
    visualMagnitude: 9.78,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.73972988),
        dec: Angle.Degrees(+12.32939263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 852"},
        {"Hipparcos Number", "HIP 1038"},
        {"Geneva Identification System", "GEN# +1.00000852"},
        {"Smithsonian Astrophysical Observation", "SAO 91776"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.25017042),
        dec: Angle.Degrees(+12.33095931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112139"},
        {"Hipparcos Number", "HIP 62961"},
        {"Geneva Identification System", "GEN# +1.00112139"},
        {"Smithsonian Astrophysical Observation", "SAO 100325"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.53142238),
        dec: Angle.Degrees(+12.33232669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112143",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112143"},
    },
    visualMagnitude: 11.53,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.72998241),
        dec: Angle.Degrees(+12.33333027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -132.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -133.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202631"},
        {"Hipparcos Number", "HIP 105055"},
        {"Smithsonian Astrophysical Observation", "SAO 106988"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.19890297),
        dec: Angle.Degrees(+12.33407457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21980",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3401 AB"},
        {"Henry Draper", "HD 286990"},
        {"Hipparcos Number", "HIP 21980"},
        {"Smithsonian Astrophysical Observation", "SAO 94088"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.87735132),
        dec: Angle.Degrees(+12.33449197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130838"},
        {"Hipparcos Number", "HIP 72555"},
        {"Geneva Identification System", "GEN# +1.00130838"},
        {"Smithsonian Astrophysical Observation", "SAO 101239"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.50262299),
        dec: Angle.Degrees(+12.33568278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 229414"},
        {"Hipparcos Number", "HIP 92067"},
        {"Geneva Identification System", "GEN# +1.00229414"},
        {"Wilson Evans Batten Catalogue", "WEB 15868"},
    },
    visualMagnitude: 10.07,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.47544015),
        dec: Angle.Degrees(+12.33616677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112919",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112919"},
    },
    visualMagnitude: 9.99,
    bvColour: 1.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.01232137),
        dec: Angle.Degrees(+12.33652963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26129"},
        {"Hipparcos Number", "HIP 19325"},
        {"Geneva Identification System", "GEN# +1.00026129"},
        {"Smithsonian Astrophysical Observation", "SAO 93780"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.12834643),
        dec: Angle.Degrees(+12.33871981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 154.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -336.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38559"},
        {"Hipparcos Number", "HIP 27315"},
        {"Smithsonian Astrophysical Observation", "SAO 94856"},
        {"Wilson Evans Batten Catalogue", "WEB 5371"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.79850163),
        dec: Angle.Degrees(+12.33959592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32160"},
        {"Hipparcos Number", "HIP 23382"},
        {"Geneva Identification System", "GEN# +1.00032160"},
        {"Smithsonian Astrophysical Observation", "SAO 94272"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.40309890),
        dec: Angle.Degrees(+12.34117543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114624"},
        {"Hipparcos Number", "HIP 64371"},
        {"Smithsonian Astrophysical Observation", "SAO 100453"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.90431604),
        dec: Angle.Degrees(+12.34143021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10106",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10106"},
    },
    visualMagnitude: 11.02,
    bvColour: 1.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.51297170),
        dec: Angle.Degrees(+12.34400799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134533"},
        {"Hipparcos Number", "HIP 74221"},
        {"Smithsonian Astrophysical Observation", "SAO 101410"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.51243312),
        dec: Angle.Degrees(+12.34407811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108577"},
        {"Hipparcos Number", "HIP 60846"},
        {"Geneva Identification System", "GEN# +1.00108577"},
        {"Smithsonian Astrophysical Observation", "SAO 100116"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.07045339),
        dec: Angle.Degrees(+12.34485827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82119",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82119"},
        {"Smithsonian Astrophysical Observation", "SAO 102377"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.936,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.63709763),
        dec: Angle.Degrees(+12.34487310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20717"},
        {"Hipparcos Number", "HIP 15565"},
        {"Geneva Identification System", "GEN# +1.00020717"},
        {"Smithsonian Astrophysical Observation", "SAO 93398"},
        {"Wilson Evans Batten Catalogue", "WEB 2991"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.14010537),
        dec: Angle.Degrees(+12.34656757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 136.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26749"},
        {"Hipparcos Number", "HIP 19767"},
        {"Geneva Identification System", "GEN# +1.00026749"},
        {"Smithsonian Astrophysical Observation", "SAO 93827"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.57537130),
        dec: Angle.Degrees(+12.34824549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 341.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58228",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58228"},
        {"Geneva Identification System", "GEN# +0.01302473"},
        {"Smithsonian Astrophysical Observation", "SAO 99877"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.13844764),
        dec: Angle.Degrees(+12.34841504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97834"},
        {"Hipparcos Number", "HIP 54969"},
        {"Smithsonian Astrophysical Observation", "SAO 99519"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.83959072),
        dec: Angle.Degrees(+12.34870259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31253"},
        {"Hipparcos Number", "HIP 22826"},
        {"Geneva Identification System", "GEN# +1.00031253"},
        {"Smithsonian Astrophysical Observation", "SAO 94193"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.68166562),
        dec: Angle.Degrees(+12.35229831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89450",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89450"},
    },
    visualMagnitude: 12.48,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.82726245),
        dec: Angle.Degrees(+12.35242558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142268"},
        {"Hipparcos Number", "HIP 77804"},
        {"Smithsonian Astrophysical Observation", "SAO 101793"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.30996389),
        dec: Angle.Degrees(+12.35311446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14175",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14175"},
    },
    visualMagnitude: 10.21,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.69351478),
        dec: Angle.Degrees(+12.35398828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 196.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80676"},
        {"Hipparcos Number", "HIP 45891"},
        {"Geneva Identification System", "GEN# +1.00080676"},
        {"Smithsonian Astrophysical Observation", "SAO 98522"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.35411088),
        dec: Angle.Degrees(+12.35645239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225107"},
        {"Hipparcos Number", "HIP 283"},
        {"Fundamental Katalog 5th Edition", "FK5 4006"},
        {"Geneva Identification System", "GEN# +1.00225107"},
        {"Smithsonian Astrophysical Observation", "SAO 91680"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.87715545),
        dec: Angle.Degrees(+12.35682896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190050"},
        {"Hipparcos Number", "HIP 98690"},
        {"Geneva Identification System", "GEN# +9.00060026"},
        {"Geneva Identification System 2", "GEN# +9.00051026"},
        {"Smithsonian Astrophysical Observation", "SAO 105583"},
    },
    visualMagnitude: 6.73,
    bvColour: 1.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.67198234),
        dec: Angle.Degrees(+12.35874536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171048"},
        {"Hipparcos Number", "HIP 90863"},
        {"Smithsonian Astrophysical Observation", "SAO 103818"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.03942074),
        dec: Angle.Degrees(+12.35900767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21914"},
        {"Hipparcos Number", "HIP 16497"},
        {"Geneva Identification System", "GEN# +1.00021914"},
        {"Smithsonian Astrophysical Observation", "SAO 93481"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.10674819),
        dec: Angle.Degrees(+12.36350477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71484",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71484"},
        {"Smithsonian Astrophysical Observation", "SAO 101109"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.27637524),
        dec: Angle.Degrees(+12.36491668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94460"},
        {"Hipparcos Number", "HIP 53315"},
        {"Smithsonian Astrophysical Observation", "SAO 99350"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.57291548),
        dec: Angle.Degrees(+12.37116574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40041"},
        {"Hipparcos Number", "HIP 28148"},
        {"Smithsonian Astrophysical Observation", "SAO 95029"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.22563004),
        dec: Angle.Degrees(+12.37235839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97108",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12848 A"},
        {"Henry Draper", "HD 186455"},
        {"Hipparcos Number", "HIP 97108"},
        {"Smithsonian Astrophysical Observation", "SAO 105193"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.02540329),
        dec: Angle.Degrees(+12.37254110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111744"},
        {"Hipparcos Number", "HIP 62745"},
        {"Geneva Identification System", "GEN# +1.00111744"},
        {"Smithsonian Astrophysical Observation", "SAO 100301"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.84720943),
        dec: Angle.Degrees(+12.37274526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72274",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72274"},
        {"Smithsonian Astrophysical Observation", "SAO 101206"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.70541231),
        dec: Angle.Degrees(+12.37349398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144905"},
        {"Hipparcos Number", "HIP 79028"},
        {"Geneva Identification System", "GEN# +1.00144905"},
        {"Smithsonian Astrophysical Observation", "SAO 101942"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.948,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.95431100),
        dec: Angle.Degrees(+12.37355512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115737"},
        {"Hipparcos Number", "HIP 64964"},
        {"Geneva Identification System", "GEN# +1.00115737"},
        {"Smithsonian Astrophysical Observation", "SAO 100510"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.73761862),
        dec: Angle.Degrees(+12.37366494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156777"},
        {"Hipparcos Number", "HIP 84723"},
        {"Smithsonian Astrophysical Observation", "SAO 102734"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.76558146),
        dec: Angle.Degrees(+12.37423535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91498"},
        {"Hipparcos Number", "HIP 51725"},
        {"Smithsonian Astrophysical Observation", "SAO 99185"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.53040438),
        dec: Angle.Degrees(+12.37444471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181333"},
        {"Hipparcos Number", "HIP 94982"},
        {"Geneva Identification System", "GEN# +1.00181333"},
        {"Smithsonian Astrophysical Observation", "SAO 104722"},
        {"Wilson Evans Batten Catalogue", "WEB 16590"},
    },
    visualMagnitude: 5.53,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.91393971),
        dec: Angle.Degrees(+12.37463918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47632"},
        {"Hipparcos Number", "HIP 31899"},
        {"Smithsonian Astrophysical Observation", "SAO 95976"},
    },
    visualMagnitude: 7.90,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.01504957),
        dec: Angle.Degrees(+12.37508761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63510",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63510"},
        {"Cincinnati Publication", "Ci 20 755"},
        {"Geneva Identification System", "GEN# +6.10010494"},
        {"Geneva Identification System 2", "GEN# +0.01302618"},
        {"Wilson Evans Batten Catalogue", "WEB 11241"},
    },
    visualMagnitude: 9.76,
    bvColour: 1.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.19563143),
        dec: Angle.Degrees(+12.37576387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -618.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187039"},
        {"Hipparcos Number", "HIP 97369"},
        {"Renson", "Renson 51550"},
        {"Smithsonian Astrophysical Observation", "SAO 105258"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.85414647),
        dec: Angle.Degrees(+12.37640237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60849",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60849"},
    },
    visualMagnitude: 12.55,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.07669622),
        dec: Angle.Degrees(+12.37708895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -183.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -127.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109067",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109067"},
        {"Geneva Identification System", "GEN# +0.01104725"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.41909620),
        dec: Angle.Degrees(+12.37770847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 200.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -420.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104381"},
        {"Hipparcos Number", "HIP 58616"},
        {"Geneva Identification System", "GEN# +1.00104381"},
        {"Smithsonian Astrophysical Observation", "SAO 99910"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.30745479),
        dec: Angle.Degrees(+12.37778072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19520"},
        {"Hipparcos Number", "HIP 14606"},
        {"Smithsonian Astrophysical Observation", "SAO 93298"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.15990797),
        dec: Angle.Degrees(+12.37829238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18117",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18117"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.10315165),
        dec: Angle.Degrees(+12.37883627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33489"},
        {"Hipparcos Number", "HIP 24143"},
        {"Smithsonian Astrophysical Observation", "SAO 94376"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.77519202),
        dec: Angle.Degrees(+12.37934807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13997"},
        {"Hipparcos Number", "HIP 10599"},
        {"Cincinnati Publication", "Ci 18 292"},
        {"Geneva Identification System", "GEN# +1.00013997"},
        {"Smithsonian Astrophysical Observation", "SAO 92865"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.11498914),
        dec: Angle.Degrees(+12.38029867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 226.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -220.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126764"},
        {"Hipparcos Number", "HIP 70666"},
        {"Geneva Identification System", "GEN# +1.00126764"},
        {"Smithsonian Astrophysical Observation", "SAO 101030"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.80974803),
        dec: Angle.Degrees(+12.38246291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30989"},
        {"Hipparcos Number", "HIP 22682"},
        {"Celescope Catalog", "CEL 479"},
        {"Geneva Identification System", "GEN# +1.00030989"},
        {"Smithsonian Astrophysical Observation", "SAO 94180"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.17122090),
        dec: Angle.Degrees(+12.38473124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81872"},
        {"Hipparcos Number", "HIP 46464"},
        {"Geneva Identification System", "GEN# +1.00081872"},
        {"Smithsonian Astrophysical Observation", "SAO 98594"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.13964301),
        dec: Angle.Degrees(+12.38534386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13669",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13669"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.839,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.00918750),
        dec: Angle.Degrees(+12.38709842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187220"},
        {"Hipparcos Number", "HIP 97451"},
        {"Smithsonian Astrophysical Observation", "SAO 105277"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.11706003),
        dec: Angle.Degrees(+12.38800736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9072"},
        {"Hipparcos Number", "HIP 6941"},
        {"Smithsonian Astrophysical Observation", "SAO 92460"},
    },
    visualMagnitude: 8.26,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.35440295),
        dec: Angle.Degrees(+12.38901021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11086"},
        {"Hipparcos Number", "HIP 8465"},
        {"Smithsonian Astrophysical Observation", "SAO 92646"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.29319939),
        dec: Angle.Degrees(+12.39030715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66009",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66009"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.99387394),
        dec: Angle.Degrees(+12.39158298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190092"},
        {"Hipparcos Number", "HIP 98710"},
        {"Geneva Identification System", "GEN# +1.00190092"},
        {"Smithsonian Astrophysical Observation", "SAO 105595"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.73579092),
        dec: Angle.Degrees(+12.39294152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166976"},
        {"Hipparcos Number", "HIP 89235"},
        {"Geneva Identification System", "GEN# +1.00166976"},
        {"Smithsonian Astrophysical Observation", "SAO 103481"},
        {"Wilson Evans Batten Catalogue", "WEB 15168"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.14869346),
        dec: Angle.Degrees(+12.39358349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150483"},
        {"Hipparcos Number", "HIP 81659"},
        {"Geneva Identification System", "GEN# +1.00150483"},
        {"Smithsonian Astrophysical Observation", "SAO 102314"},
        {"Wilson Evans Batten Catalogue", "WEB 13790"},
    },
    visualMagnitude: 6.08,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.21399582),
        dec: Angle.Degrees(+12.39505668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63316",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63316"},
        {"Geneva Identification System", "GEN# +0.01302610"},
        {"Smithsonian Astrophysical Observation", "SAO 100353"},
    },
    visualMagnitude: 9.60,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.63315793),
        dec: Angle.Degrees(+12.39506606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109516",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109516"},
    },
    visualMagnitude: 9.55,
    bvColour: 1.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.77585702),
        dec: Angle.Degrees(+12.39522172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286699"},
        {"Hipparcos Number", "HIP 20253"},
        {"Smithsonian Astrophysical Observation", "SAO 93875"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.10251262),
        dec: Angle.Degrees(+12.39703186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98172"},
        {"Hipparcos Number", "HIP 55167"},
        {"Geneva Identification System", "GEN# +1.00098172"},
        {"Smithsonian Astrophysical Observation", "SAO 99540"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.42823655),
        dec: Angle.Degrees(+12.39977314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81707"},
        {"Hipparcos Number", "HIP 46392"},
        {"Smithsonian Astrophysical Observation", "SAO 98580"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.90130138),
        dec: Angle.Degrees(+12.40037481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191788"},
        {"Hipparcos Number", "HIP 99471"},
        {"Smithsonian Astrophysical Observation", "SAO 105795"},
    },
    visualMagnitude: 8.81,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.82086236),
        dec: Angle.Degrees(+12.40356634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95845",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12515 AB"},
        {"Henry Draper", "HD 183512"},
        {"Hipparcos Number", "HIP 95845"},
        {"Smithsonian Astrophysical Observation", "SAO 104900"},
        {"Wilson Evans Batten Catalogue", "WEB 16781"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.39946852),
        dec: Angle.Degrees(+12.40435999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96235"},
        {"Hipparcos Number", "HIP 54252"},
        {"Smithsonian Astrophysical Observation", "SAO 99434"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.47723155),
        dec: Angle.Degrees(+12.40706766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47771",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47771"},
        {"Smithsonian Astrophysical Observation", "SAO 98741"},
    },
    visualMagnitude: 10.75,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.09385814),
        dec: Angle.Degrees(+12.40864005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34291"},
        {"Hipparcos Number", "HIP 24622"},
        {"Smithsonian Astrophysical Observation", "SAO 94436"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.21715156),
        dec: Angle.Degrees(+12.40941568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48841",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48841"},
        {"Smithsonian Astrophysical Observation", "SAO 98870"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.43715790),
        dec: Angle.Degrees(+12.41113370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10853"},
        {"Hipparcos Number", "HIP 8275"},
        {"Geneva Identification System", "GEN# +1.00010853"},
        {"Smithsonian Astrophysical Observation", "SAO 92623"},
        {"Wilson Evans Batten Catalogue", "WEB 1763"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.66124423),
        dec: Angle.Degrees(+12.41195514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38221"},
        {"Hipparcos Number", "HIP 27091"},
        {"Geneva Identification System", "GEN# +1.00038221"},
        {"Smithsonian Astrophysical Observation", "SAO 94819"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.17261465),
        dec: Angle.Degrees(+12.41538025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115382"},
        {"Hipparcos Number", "HIP 64794"},
        {"Geneva Identification System", "GEN# +1.00115382"},
        {"Smithsonian Astrophysical Observation", "SAO 100490"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.20134192),
        dec: Angle.Degrees(+12.41593136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -205.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92685"},
        {"Hipparcos Number", "HIP 52371"},
        {"Smithsonian Astrophysical Observation", "SAO 99256"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.56482370),
        dec: Angle.Degrees(+12.41812024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27390",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4386 A"},
        {"Henry Draper", "HD 38672"},
        {"Hipparcos Number", "HIP 27390"},
        {"Celescope Catalog", "CEL 972"},
        {"Geneva Identification System", "GEN# +1.00038672A"},
        {"Smithsonian Astrophysical Observation", "SAO 94868"},
        {"Wilson Evans Batten Catalogue", "WEB 5380"},
    },
    visualMagnitude: 6.68,
    bvColour: -0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.00865179),
        dec: Angle.Degrees(+12.41842571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112097"},
        {"Hipparcos Number", "HIP 62933"},
        {"Geneva Identification System", "GEN# +1.00112097"},
        {"Renson", "Renson 32520"},
        {"Smithsonian Astrophysical Observation", "SAO 100322"},
        {"Wilson Evans Batten Catalogue", "WEB 11160"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.45697842),
        dec: Angle.Degrees(+12.41850095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150905"},
        {"Hipparcos Number", "HIP 81884"},
        {"Smithsonian Astrophysical Observation", "SAO 102346"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.88907402),
        dec: Angle.Degrees(+12.41854419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39570"},
        {"Hipparcos Number", "HIP 27878"},
        {"Geneva Identification System", "GEN# +1.00039570"},
        {"Smithsonian Astrophysical Observation", "SAO 94968"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.49480606),
        dec: Angle.Degrees(+12.42006913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -260.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149028"},
        {"Hipparcos Number", "HIP 80936"},
        {"Geneva Identification System", "GEN# +1.00149028"},
        {"Smithsonian Astrophysical Observation", "SAO 102224"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.90468856),
        dec: Angle.Degrees(+12.42141260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42945",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42945"},
        {"Smithsonian Astrophysical Observation", "SAO 98095"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.31310077),
        dec: Angle.Degrees(+12.42212631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5542"},
        {"Hipparcos Number", "HIP 4480"},
        {"Smithsonian Astrophysical Observation", "SAO 92177"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.34020968),
        dec: Angle.Degrees(+12.42987835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131826"},
        {"Hipparcos Number", "HIP 73028"},
        {"Smithsonian Astrophysical Observation", "SAO 101286"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.86919587),
        dec: Angle.Degrees(+12.43087374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34877"},
        {"Hipparcos Number", "HIP 24993"},
        {"Geneva Identification System", "GEN# +1.00034877"},
        {"Smithsonian Astrophysical Observation", "SAO 94483"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.27629715),
        dec: Angle.Degrees(+12.43092085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 356994"},
        {"Hipparcos Number", "HIP 99554"},
        {"Smithsonian Astrophysical Observation", "SAO 105824"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.05427281),
        dec: Angle.Degrees(+12.43101953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116594"},
        {"Hipparcos Number", "HIP 65417"},
        {"Geneva Identification System", "GEN# +0.01302663"},
        {"Geneva Identification System 2", "GEN# +1.00116594"},
        {"Smithsonian Astrophysical Observation", "SAO 100553"},
        {"Wilson Evans Batten Catalogue", "WEB 11546"},
    },
    visualMagnitude: 6.44,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.12724147),
        dec: Angle.Degrees(+12.43174526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76446"},
        {"Hipparcos Number", "HIP 43897"},
        {"Smithsonian Astrophysical Observation", "SAO 98240"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.13800891),
        dec: Angle.Degrees(+12.43196506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15117",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15117"},
        {"Smithsonian Astrophysical Observation", "SAO 93357"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.73242796),
        dec: Angle.Degrees(+12.43243630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26767"},
        {"Hipparcos Number", "HIP 19786"},
        {"Geneva Identification System", "GEN# +5.20250018"},
        {"Smithsonian Astrophysical Observation", "SAO 93830"},
        {"Wilson Evans Batten Catalogue", "WEB 3772"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.61327492),
        dec: Angle.Degrees(+12.43534652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37033"},
        {"Hipparcos Number", "HIP 26306"},
        {"Geneva Identification System", "GEN# +1.00037033"},
        {"Smithsonian Astrophysical Observation", "SAO 94689"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.03552304),
        dec: Angle.Degrees(+12.43645841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219386"},
        {"Hipparcos Number", "HIP 114800"},
        {"Geneva Identification System", "GEN# +1.00219386"},
        {"Smithsonian Astrophysical Observation", "SAO 108493"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.82843070),
        dec: Angle.Degrees(+12.43766367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6834",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6834"},
    },
    visualMagnitude: 11.22,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.98713050),
        dec: Angle.Degrees(+12.43860394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196525"},
        {"Hipparcos Number", "HIP 101783"},
        {"Smithsonian Astrophysical Observation", "SAO 106320"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.42714067),
        dec: Angle.Degrees(+12.43870475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45538",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45538"},
    },
    visualMagnitude: 10.98,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.22235213),
        dec: Angle.Degrees(+12.43897800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10128"},
        {"Hipparcos Number", "HIP 7706"},
        {"Geneva Identification System", "GEN# +1.00010128"},
        {"Smithsonian Astrophysical Observation", "SAO 92554"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.79825880),
        dec: Angle.Degrees(+12.44035413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188836"},
        {"Hipparcos Number", "HIP 98144"},
        {"Geneva Identification System", "GEN# +1.00188836"},
        {"Smithsonian Astrophysical Observation", "SAO 105448"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.18463219),
        dec: Angle.Degrees(+12.44227367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65214",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65214"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.47615475),
        dec: Angle.Degrees(+12.44249105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11432"},
        {"Hipparcos Number", "HIP 8754"},
        {"Smithsonian Astrophysical Observation", "SAO 92671"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.15446022),
        dec: Angle.Degrees(+12.44289508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193968"},
        {"Hipparcos Number", "HIP 100498"},
        {"Smithsonian Astrophysical Observation", "SAO 106039"},
    },
    visualMagnitude: 6.74,
    bvColour: 1.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.68698852),
        dec: Angle.Degrees(+12.44339921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86360"},
        {"Hipparcos Number", "HIP 48883"},
        {"Fundamental Katalog 5th Edition", "FK5 2800"},
        {"Geneva Identification System", "GEN# +1.00086360"},
        {"Smithsonian Astrophysical Observation", "SAO 98876"},
        {"Wilson Evans Batten Catalogue", "WEB 9082"},
    },
    visualMagnitude: 5.26,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.55579541),
        dec: Angle.Degrees(+12.44483936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104057",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14607 A"},
        {"Henry Draper", "HD 200745"},
        {"Hipparcos Number", "HIP 104057"},
        {"Geneva Identification System", "GEN# +1.00200745"},
        {"Smithsonian Astrophysical Observation", "SAO 106819"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.21929441),
        dec: Angle.Degrees(+12.44487972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90524"},
        {"Hipparcos Number", "HIP 51184"},
        {"Geneva Identification System", "GEN# +1.00090524"},
        {"Smithsonian Astrophysical Observation", "SAO 99133"},
        {"Wilson Evans Batten Catalogue", "WEB 9356"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.82030234),
        dec: Angle.Degrees(+12.44508612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209920"},
        {"Hipparcos Number", "HIP 109147"},
        {"Renson", "Renson 58430"},
        {"Smithsonian Astrophysical Observation", "SAO 107664"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.64132898),
        dec: Angle.Degrees(+12.44524365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17093"},
        {"Hipparcos Number", "HIP 12832"},
        {"Geneva Identification System", "GEN# +1.00017093"},
        {"Smithsonian Astrophysical Observation", "SAO 93083"},
        {"Wilson Evans Batten Catalogue", "WEB 2609"},
    },
    visualMagnitude: 5.17,
    bvColour: 0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.23961417),
        dec: Angle.Degrees(+12.44596709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 124.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286987"},
        {"Hipparcos Number", "HIP 21973"},
        {"Geneva Identification System", "GEN# +1.00286987"},
        {"Smithsonian Astrophysical Observation", "SAO 94086"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.84048212),
        dec: Angle.Degrees(+12.44602828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16234"},
        {"Hipparcos Number", "HIP 12153"},
        {"Fundamental Katalog 5th Edition", "FK5 2179"},
        {"Geneva Identification System", "GEN# +1.00016234"},
        {"Smithsonian Astrophysical Observation", "SAO 93022"},
        {"Wilson Evans Batten Catalogue", "WEB 2496"},
    },
    visualMagnitude: 5.64,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.15728620),
        dec: Angle.Degrees(+12.44784628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 279.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59179"},
        {"Hipparcos Number", "HIP 36387"},
        {"Geneva Identification System", "GEN# +1.00059179"},
        {"Smithsonian Astrophysical Observation", "SAO 96940"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.32739976),
        dec: Angle.Degrees(+12.44883982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17293"},
        {"Hipparcos Number", "HIP 12985"},
        {"Smithsonian Astrophysical Observation", "SAO 93099"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.75095555),
        dec: Angle.Degrees(+12.44982602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17696",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17696"},
        {"Smithsonian Astrophysical Observation", "SAO 93600"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.84693190),
        dec: Angle.Degrees(+12.45003200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170543"},
        {"Hipparcos Number", "HIP 90624"},
        {"Smithsonian Astrophysical Observation", "SAO 103772"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.37832841),
        dec: Angle.Degrees(+12.45075495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68141",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9066 AB"},
        {"Hipparcos Number", "HIP 68141"},
        {"Smithsonian Astrophysical Observation", "SAO 100784"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.26571572),
        dec: Angle.Degrees(+12.45085748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211856"},
        {"Hipparcos Number", "HIP 110250"},
        {"Geneva Identification System", "GEN# +1.00211856"},
        {"Renson", "Renson 58810"},
        {"Smithsonian Astrophysical Observation", "SAO 107835"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.98062887),
        dec: Angle.Degrees(+12.45192738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39343",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6531 A"},
        {"Henry Draper", "HD 66117"},
        {"Hipparcos Number", "HIP 39343"},
        {"Smithsonian Astrophysical Observation", "SAO 97498"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.63652436),
        dec: Angle.Degrees(+12.45223952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124914"},
        {"Hipparcos Number", "HIP 69697"},
        {"Geneva Identification System", "GEN# +1.00124914"},
        {"Smithsonian Astrophysical Observation", "SAO 100946"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.99694622),
        dec: Angle.Degrees(+12.45451602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26583"},
        {"Hipparcos Number", "HIP 19649"},
        {"Smithsonian Astrophysical Observation", "SAO 93812"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.15652969),
        dec: Angle.Degrees(+12.45620802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44008",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44008"},
        {"Smithsonian Astrophysical Observation", "SAO 98255"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.42044119),
        dec: Angle.Degrees(+12.45692928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135148"},
        {"Hipparcos Number", "HIP 74491"},
        {"Geneva Identification System", "GEN# +1.00135148"},
    },
    visualMagnitude: 9.49,
    bvColour: 1.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.32280303),
        dec: Angle.Degrees(+12.45708712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 266093"},
        {"Hipparcos Number", "HIP 33204"},
        {"Smithsonian Astrophysical Observation", "SAO 96266"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.66545275),
        dec: Angle.Degrees(+12.45768227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104506",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104506"},
    },
    visualMagnitude: 9.67,
    bvColour: 1.904,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.53508020),
        dec: Angle.Degrees(+12.45825382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61398",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61398"},
        {"Smithsonian Astrophysical Observation", "SAO 100157"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.71981091),
        dec: Angle.Degrees(+12.45943358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211786"},
        {"Hipparcos Number", "HIP 110205"},
        {"Geneva Identification System", "GEN# +1.00211786"},
        {"Smithsonian Astrophysical Observation", "SAO 107828"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.85443256),
        dec: Angle.Degrees(+12.46003053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99054"},
        {"Hipparcos Number", "HIP 55654"},
        {"Geneva Identification System", "GEN# +1.00099054"},
        {"Smithsonian Astrophysical Observation", "SAO 99588"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.04121869),
        dec: Angle.Degrees(+12.46153793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102593",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102593"},
        {"Geneva Identification System", "GEN# +0.01104381"},
        {"Wilson Evans Batten Catalogue", "WEB 18588"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.86811571),
        dec: Angle.Degrees(+12.46406164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166143"},
        {"Hipparcos Number", "HIP 88893"},
        {"Smithsonian Astrophysical Observation", "SAO 103421"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.20272303),
        dec: Angle.Degrees(+12.46571540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112002"},
        {"Hipparcos Number", "HIP 62874"},
        {"Geneva Identification System", "GEN# +1.00112002"},
        {"Smithsonian Astrophysical Observation", "SAO 100318"},
        {"Wilson Evans Batten Catalogue", "WEB 11148"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.29366685),
        dec: Angle.Degrees(+12.46592464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155375"},
        {"Hipparcos Number", "HIP 84036"},
        {"Geneva Identification System", "GEN# +1.00155375"},
        {"Renson", "Renson 43920"},
        {"Smithsonian Astrophysical Observation", "SAO 102632"},
        {"Wilson Evans Batten Catalogue", "WEB 14199"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.69054747),
        dec: Angle.Degrees(+12.46701696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 252390"},
        {"Hipparcos Number", "HIP 29146"},
        {"Smithsonian Astrophysical Observation", "SAO 95291"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.23212141),
        dec: Angle.Degrees(+12.46707730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52619",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52619"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.41027499),
        dec: Angle.Degrees(+12.46728796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6460"},
        {"Hipparcos Number", "HIP 5117"},
        {"Smithsonian Astrophysical Observation", "SAO 92238"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.39225685),
        dec: Angle.Degrees(+12.46869953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51856",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51856"},
    },
    visualMagnitude: 11.57,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.92486170),
        dec: Angle.Degrees(+12.46916980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -219.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9010"},
        {"Hipparcos Number", "HIP 6906"},
        {"Smithsonian Astrophysical Observation", "SAO 92456"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.23089504),
        dec: Angle.Degrees(+12.46951809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183401"},
        {"Hipparcos Number", "HIP 95790"},
        {"Geneva Identification System", "GEN# +1.00183401A"},
        {"Smithsonian Astrophysical Observation", "SAO 104884"},
        {"Wilson Evans Batten Catalogue", "WEB 16768"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.24861339),
        dec: Angle.Degrees(+12.47069770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105866"},
        {"Hipparcos Number", "HIP 59400"},
        {"Geneva Identification System", "GEN# +1.00105866"},
        {"Smithsonian Astrophysical Observation", "SAO 99976"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.78330926),
        dec: Angle.Degrees(+12.47102690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90305",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90305"},
        {"Smithsonian Astrophysical Observation", "SAO 103699"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.38271765),
        dec: Angle.Degrees(+12.47150469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110584"},
        {"Hipparcos Number", "HIP 62045"},
        {"Smithsonian Astrophysical Observation", "SAO 100218"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.76658488),
        dec: Angle.Degrees(+12.47250996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16838",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16838"},
        {"Smithsonian Astrophysical Observation", "SAO 93513"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.814,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.17908708),
        dec: Angle.Degrees(+12.47440587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37158"},
        {"Hipparcos Number", "HIP 26377"},
        {"Geneva Identification System", "GEN# +1.00037158"},
        {"Smithsonian Astrophysical Observation", "SAO 94701"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.25120885),
        dec: Angle.Degrees(+12.47488734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194722"},
        {"Hipparcos Number", "HIP 100849"},
        {"Smithsonian Astrophysical Observation", "SAO 106106"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.71277199),
        dec: Angle.Degrees(+12.47565422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132740"},
        {"Hipparcos Number", "HIP 73437"},
        {"Smithsonian Astrophysical Observation", "SAO 101324"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.10001812),
        dec: Angle.Degrees(+12.47587706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143588"},
        {"Hipparcos Number", "HIP 78444"},
        {"Fundamental Katalog 5th Edition", "FK5 5413"},
        {"Geneva Identification System", "GEN# +1.00143588"},
        {"Smithsonian Astrophysical Observation", "SAO 101873"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.21489649),
        dec: Angle.Degrees(+12.47662751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43045"},
        {"Hipparcos Number", "HIP 29630"},
        {"Smithsonian Astrophysical Observation", "SAO 95427"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.65357854),
        dec: Angle.Degrees(+12.47715124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78097",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9850 AB"},
        {"Henry Draper", "HD 142910"},
        {"Hipparcos Number", "HIP 78097"},
        {"Smithsonian Astrophysical Observation", "SAO 101829"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.18981564),
        dec: Angle.Degrees(+12.47793465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28894",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4675 AB"},
        {"Henry Draper", "HD 41481"},
        {"Hipparcos Number", "HIP 28894"},
        {"Smithsonian Astrophysical Observation", "SAO 95225"},
    },
    visualMagnitude: 7.70,
    bvColour: -0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.50369155),
        dec: Angle.Degrees(+12.47936702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16008",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2531 AB"},
        {"Henry Draper", "HD 21261"},
        {"Hipparcos Number", "HIP 16008"},
        {"Smithsonian Astrophysical Observation", "SAO 93433"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.53671772),
        dec: Angle.Degrees(+12.48186692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72163",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72163"},
        {"Smithsonian Astrophysical Observation", "SAO 101189"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.40311497),
        dec: Angle.Degrees(+12.48381787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21142"},
        {"Hipparcos Number", "HIP 15928"},
        {"Smithsonian Astrophysical Observation", "SAO 93422"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.29406525),
        dec: Angle.Degrees(+12.48544928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4666",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4666"},
    },
    visualMagnitude: 11.89,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.98602579),
        dec: Angle.Degrees(+15.73713521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286363"},
        {"Hipparcos Number", "HIP 18322"},
    },
    visualMagnitude: 10.12,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.75567862),
        dec: Angle.Degrees(+12.48561161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 127.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108915"},
        {"Hipparcos Number", "HIP 61051"},
        {"Geneva Identification System", "GEN# +1.00108915"},
        {"Smithsonian Astrophysical Observation", "SAO 100134"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.70396691),
        dec: Angle.Degrees(+12.48674600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73349"},
        {"Hipparcos Number", "HIP 42375"},
        {"Smithsonian Astrophysical Observation", "SAO 97991"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.60301710),
        dec: Angle.Degrees(+12.48785487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183145"},
        {"Hipparcos Number", "HIP 95682"},
        {"Smithsonian Astrophysical Observation", "SAO 104863"},
        {"Wilson Evans Batten Catalogue", "WEB 16737"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.92564073),
        dec: Angle.Degrees(+12.48786479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90428"},
        {"Hipparcos Number", "HIP 51120"},
        {"Geneva Identification System", "GEN# +1.00090428"},
        {"Smithsonian Astrophysical Observation", "SAO 99122"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.66431352),
        dec: Angle.Degrees(+12.48862880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134305"},
        {"Hipparcos Number", "HIP 74109"},
        {"Renson", "Renson 38130"},
        {"Smithsonian Astrophysical Observation", "SAO 101402"},
        {"Wilson Evans Batten Catalogue", "WEB 12660"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.18698702),
        dec: Angle.Degrees(+12.48888946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25204"},
        {"Hipparcos Number", "HIP 18724"},
        {"Fundamental Katalog 5th Edition", "FK5 150"},
        {"Geneva Identification System", "GEN# +1.00025204"},
        {"Smithsonian Astrophysical Observation", "SAO 93719"},
        {"Wilson Evans Batten Catalogue", "WEB 3604"},
        {"Wilson Evans Batten Catalogue 2", "WEB 3603"},
    },
    visualMagnitude: 3.41,
    bvColour: -0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.17008591),
        dec: Angle.Degrees(+12.49037571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125875"},
        {"Hipparcos Number", "HIP 70216"},
        {"Smithsonian Astrophysical Observation", "SAO 100992"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.48384444),
        dec: Angle.Degrees(+12.49040020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154531"},
        {"Hipparcos Number", "HIP 83627"},
        {"Smithsonian Astrophysical Observation", "SAO 102588"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.36827478),
        dec: Angle.Degrees(+12.49235080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26857",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26857"},
        {"Cincinnati Publication", "Ci 20 344"},
        {"Geneva Identification System", "GEN# +6.10010213"},
        {"Wilson Evans Batten Catalogue", "WEB 5291"},
    },
    visualMagnitude: 11.56,
    bvColour: 1.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.53363564),
        dec: Angle.Degrees(+12.49315500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1999.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1570.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133372"},
        {"Hipparcos Number", "HIP 73688"},
        {"Smithsonian Astrophysical Observation", "SAO 101356"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.922,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.93423785),
        dec: Angle.Degrees(+12.49447606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56579",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56579"},
        {"Smithsonian Astrophysical Observation", "SAO 99684"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.99633850),
        dec: Angle.Degrees(+12.49866132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157296"},
        {"Hipparcos Number", "HIP 84962"},
        {"Smithsonian Astrophysical Observation", "SAO 102772"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.47810441),
        dec: Angle.Degrees(+12.49974995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82461",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82461"},
        {"Fundamental Katalog 5th Edition", "FK5 5490"},
        {"Smithsonian Astrophysical Observation", "SAO 102427"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.78206780),
        dec: Angle.Degrees(+12.50077929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91019",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91019"},
        {"Smithsonian Astrophysical Observation", "SAO 103854"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.51967613),
        dec: Angle.Degrees(+12.50382083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25605"},
        {"Hipparcos Number", "HIP 19003"},
        {"Smithsonian Astrophysical Observation", "SAO 93747"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.07802762),
        dec: Angle.Degrees(+12.50748815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23680"},
        {"Hipparcos Number", "HIP 17697"},
        {"Smithsonian Astrophysical Observation", "SAO 93601"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.85304833),
        dec: Angle.Degrees(+12.50828181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70464",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70464"},
    },
    visualMagnitude: 11.01,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.19654845),
        dec: Angle.Degrees(+12.50835355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286697"},
        {"Hipparcos Number", "HIP 20397"},
        {"Smithsonian Astrophysical Observation", "SAO 93891"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.50386921),
        dec: Angle.Degrees(+12.50892619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106747"},
        {"Hipparcos Number", "HIP 59857"},
        {"Geneva Identification System", "GEN# +1.00106747"},
        {"Smithsonian Astrophysical Observation", "SAO 100013"},
    },
    visualMagnitude: 9.71,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.13000137),
        dec: Angle.Degrees(+12.51008707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29388"},
        {"Hipparcos Number", "HIP 21589"},
        {"Celescope Catalog", "CEL 448"},
        {"Fundamental Katalog 5th Edition", "FK5 2342"},
        {"Geneva Identification System", "GEN# +5.20250104"},
        {"Renson", "Renson 7520"},
        {"Smithsonian Astrophysical Observation", "SAO 94044"},
        {"Wilson Evans Batten Catalogue", "WEB 4145"},
    },
    visualMagnitude: 4.27,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.53917371),
        dec: Angle.Degrees(+12.51087423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118180"},
        {"Hipparcos Number", "HIP 66275"},
        {"Geneva Identification System", "GEN# +1.00118180"},
        {"Smithsonian Astrophysical Observation", "SAO 100627"},
    },
    visualMagnitude: 6.56,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.75718068),
        dec: Angle.Degrees(+12.51395029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206658"},
        {"Hipparcos Number", "HIP 107246"},
        {"Geneva Identification System", "GEN# +1.00206658"},
        {"Smithsonian Astrophysical Observation", "SAO 107349"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.82654449),
        dec: Angle.Degrees(+12.51853413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102131",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14168 A"},
        {"Henry Draper", "HD 197179"},
        {"Hipparcos Number", "HIP 102131"},
        {"Geneva Identification System", "GEN# +1.00197179"},
        {"Smithsonian Astrophysical Observation", "SAO 106390"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.44157309),
        dec: Angle.Degrees(+12.51870837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46121",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46121"},
        {"Smithsonian Astrophysical Observation", "SAO 98550"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.08389602),
        dec: Angle.Degrees(+12.52001587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102132",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14168 B"},
        {"Hipparcos Number", "HIP 102132"},
    },
    visualMagnitude: 10.70,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.44171707),
        dec: Angle.Degrees(+12.52214079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84915"},
        {"Hipparcos Number", "HIP 48142"},
        {"Smithsonian Astrophysical Observation", "SAO 98778"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.21524261),
        dec: Angle.Degrees(+12.52229832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122152"},
        {"Hipparcos Number", "HIP 68379"},
        {"Smithsonian Astrophysical Observation", "SAO 100810"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.95293591),
        dec: Angle.Degrees(+12.52248201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24452",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3822 AB"},
        {"Henry Draper", "HD 34021"},
        {"Hipparcos Number", "HIP 24452"},
        {"Wilson Evans Batten Catalogue", "WEB 4738"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.68761268),
        dec: Angle.Degrees(+12.52541459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 287129"},
        {"Hipparcos Number", "HIP 22462"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.51626766),
        dec: Angle.Degrees(+12.52612612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94"},
        {"Hipparcos Number", "HIP 491"},
        {"Smithsonian Astrophysical Observation", "SAO 91705"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.46996926),
        dec: Angle.Degrees(+12.52743978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123496"},
        {"Hipparcos Number", "HIP 69013"},
        {"Smithsonian Astrophysical Observation", "SAO 100859"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.92339676),
        dec: Angle.Degrees(+12.52751345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55204"},
        {"Hipparcos Number", "HIP 34823"},
        {"Smithsonian Astrophysical Observation", "SAO 96623"},
    },
    visualMagnitude: 8.17,
    bvColour: -0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.11490191),
        dec: Angle.Degrees(+12.53265651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89924",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89924"},
    },
    visualMagnitude: 10.30,
    bvColour: 1.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.23495915),
        dec: Angle.Degrees(+12.53274056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -259.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168440"},
        {"Hipparcos Number", "HIP 89776"},
        {"Smithsonian Astrophysical Observation", "SAO 103605"},
        {"Wilson Evans Batten Catalogue", "WEB 15313"},
    },
    visualMagnitude: 7.49,
    bvColour: -0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.80906693),
        dec: Angle.Degrees(+12.53396968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95730",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12481 AB"},
        {"Henry Draper", "HD 231512"},
        {"Hipparcos Number", "HIP 95730"},
        {"Geneva Identification System", "GEN# +1.00231512J"},
        {"Smithsonian Astrophysical Observation", "SAO 104873"},
        {"Wilson Evans Batten Catalogue", "WEB 16752"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.06428045),
        dec: Angle.Degrees(+12.53600021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113752",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113752"},
        {"Smithsonian Astrophysical Observation", "SAO 108351"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.55095062),
        dec: Angle.Degrees(+12.53685487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171489"},
        {"Hipparcos Number", "HIP 91073"},
        {"Geneva Identification System", "GEN# +1.00171489"},
        {"Smithsonian Astrophysical Observation", "SAO 103864"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.64850142),
        dec: Angle.Degrees(+12.53888011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106785"},
        {"Hipparcos Number", "HIP 59880"},
        {"Geneva Identification System", "GEN# +1.00106785"},
        {"Smithsonian Astrophysical Observation", "SAO 100018"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.20402848),
        dec: Angle.Degrees(+12.53915990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49433",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49433"},
        {"Smithsonian Astrophysical Observation", "SAO 98940"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.37054245),
        dec: Angle.Degrees(+12.53931631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205127"},
        {"Hipparcos Number", "HIP 106397"},
        {"Smithsonian Astrophysical Observation", "SAO 107224"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.24635268),
        dec: Angle.Degrees(+12.53966503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93438",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11952 A"},
        {"Henry Draper", "HD 176873"},
        {"Hipparcos Number", "HIP 93438"},
        {"Smithsonian Astrophysical Observation", "SAO 104379"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.45250371),
        dec: Angle.Degrees(+12.54097560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33006"},
        {"Hipparcos Number", "HIP 23858"},
        {"Geneva Identification System", "GEN# +1.00033006"},
        {"Smithsonian Astrophysical Observation", "SAO 94335"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.778,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.91447683),
        dec: Angle.Degrees(+12.54119924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103489",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103489"},
        {"Smithsonian Astrophysical Observation", "SAO 106707"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.51056516),
        dec: Angle.Degrees(+12.54141076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198390"},
        {"Hipparcos Number", "HIP 102805"},
        {"Geneva Identification System", "GEN# +1.00198390"},
        {"Smithsonian Astrophysical Observation", "SAO 106536"},
        {"Wilson Evans Batten Catalogue", "WEB 18645"},
    },
    visualMagnitude: 6.01,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.40723273),
        dec: Angle.Degrees(+12.54489131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 97.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81234",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81234"},
        {"Smithsonian Astrophysical Observation", "SAO 102257"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.87091817),
        dec: Angle.Degrees(+12.54629650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209793"},
        {"Hipparcos Number", "HIP 109086"},
        {"Geneva Identification System", "GEN# +1.00209793"},
        {"Smithsonian Astrophysical Observation", "SAO 107657"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.46696313),
        dec: Angle.Degrees(+12.54644578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 206.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75156"},
        {"Hipparcos Number", "HIP 43251"},
        {"Geneva Identification System", "GEN# +1.00075156"},
        {"Smithsonian Astrophysical Observation", "SAO 98143"},
        {"Wilson Evans Batten Catalogue", "WEB 8339"},
    },
    visualMagnitude: 6.66,
    bvColour: 1.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.16478053),
        dec: Angle.Degrees(+12.54694020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30914",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5109 AB"},
        {"Henry Draper", "HD 45673"},
        {"Hipparcos Number", "HIP 30914"},
        {"Smithsonian Astrophysical Observation", "SAO 95737"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.32683672),
        dec: Angle.Degrees(+12.54759615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54630"},
        {"Hipparcos Number", "HIP 34604"},
        {"Fundamental Katalog 5th Edition", "FK5 4648"},
        {"Smithsonian Astrophysical Observation", "SAO 96580"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.51807138),
        dec: Angle.Degrees(+12.54811730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185860"},
        {"Hipparcos Number", "HIP 96809"},
        {"Smithsonian Astrophysical Observation", "SAO 105127"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.18336060),
        dec: Angle.Degrees(+12.54828376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80811"},
        {"Hipparcos Number", "HIP 45947"},
        {"Geneva Identification System", "GEN# +1.00080811"},
        {"Smithsonian Astrophysical Observation", "SAO 98528"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.55430946),
        dec: Angle.Degrees(+12.54957419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -125.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -195.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126380"},
        {"Hipparcos Number", "HIP 70461"},
        {"Smithsonian Astrophysical Observation", "SAO 101015"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.19370463),
        dec: Angle.Degrees(+12.55033539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166759"},
        {"Hipparcos Number", "HIP 89145"},
        {"Geneva Identification System", "GEN# +1.00166759"},
        {"Smithsonian Astrophysical Observation", "SAO 103464"},
    },
    visualMagnitude: 8.08,
    bvColour: -0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.90896675),
        dec: Angle.Degrees(+12.55044323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221759"},
        {"Hipparcos Number", "HIP 116361"},
        {"Geneva Identification System", "GEN# +1.00221759"},
        {"Smithsonian Astrophysical Observation", "SAO 108688"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.68170065),
        dec: Angle.Degrees(+12.55074354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43247"},
        {"Hipparcos Number", "HIP 29736"},
        {"Celescope Catalog", "CEL 1146"},
        {"Geneva Identification System", "GEN# +1.00043247"},
        {"Smithsonian Astrophysical Observation", "SAO 95457"},
        {"Wilson Evans Batten Catalogue", "WEB 5865"},
    },
    visualMagnitude: 5.44,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.93735931),
        dec: Angle.Degrees(+12.55107067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35956"},
        {"Hipparcos Number", "HIP 25662"},
        {"Geneva Identification System", "GEN# +1.00035956"},
        {"Smithsonian Astrophysical Observation", "SAO 94583"},
        {"Wilson Evans Batten Catalogue", "WEB 4979"},
    },
    visualMagnitude: 6.71,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.21491883),
        dec: Angle.Degrees(+12.55135347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -218.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71681"},
        {"Hipparcos Number", "HIP 41623"},
        {"Smithsonian Astrophysical Observation", "SAO 97848"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.28810573),
        dec: Angle.Degrees(+12.55200303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173816"},
        {"Hipparcos Number", "HIP 92146"},
        {"Smithsonian Astrophysical Observation", "SAO 104088"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.70841481),
        dec: Angle.Degrees(+12.55449875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106222",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106222"},
        {"Geneva Identification System", "GEN# +0.01104582"},
        {"Smithsonian Astrophysical Observation", "SAO 107190"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.728,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.73505572),
        dec: Angle.Degrees(+12.55537526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201584"},
        {"Hipparcos Number", "HIP 104507"},
        {"Smithsonian Astrophysical Observation", "SAO 106886"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.54028665),
        dec: Angle.Degrees(+12.55589630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36308"},
        {"Hipparcos Number", "HIP 25873"},
        {"Geneva Identification System", "GEN# +1.00036308"},
        {"Smithsonian Astrophysical Observation", "SAO 94610"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.814,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.84767850),
        dec: Angle.Degrees(+12.55642206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 172.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -136.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147058"},
        {"Hipparcos Number", "HIP 79952"},
        {"Geneva Identification System", "GEN# +1.00147058"},
        {"Smithsonian Astrophysical Observation", "SAO 102082"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.79539891),
        dec: Angle.Degrees(+12.55660457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98644"},
        {"Hipparcos Number", "HIP 55428"},
        {"Geneva Identification System", "GEN# +1.00098644"},
        {"Smithsonian Astrophysical Observation", "SAO 99570"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.26727996),
        dec: Angle.Degrees(+12.55769366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -167.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140933"},
        {"Hipparcos Number", "HIP 77214"},
        {"Smithsonian Astrophysical Observation", "SAO 101721"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.47801224),
        dec: Angle.Degrees(+12.55815627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141589"},
        {"Hipparcos Number", "HIP 77506"},
        {"Smithsonian Astrophysical Observation", "SAO 101758"},
        {"Wilson Evans Batten Catalogue", "WEB 13123"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.39155896),
        dec: Angle.Degrees(+12.55864447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7364",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1238 A"},
        {"Henry Draper", "HD 9656"},
        {"Hipparcos Number", "HIP 7364"},
        {"Smithsonian Astrophysical Observation", "SAO 92521"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.71505379),
        dec: Angle.Degrees(+12.55866655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63100",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63100"},
        {"Geneva Identification System", "GEN# +9.80060048"},
        {"Wilson Evans Batten Catalogue", "WEB 11188"},
    },
    visualMagnitude: 11.32,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.92115247),
        dec: Angle.Degrees(+12.55916584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -282.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -257.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11082",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11082"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.67118556),
        dec: Angle.Degrees(+12.55938620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7367",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1238 B"},
        {"Hipparcos Number", "HIP 7367"},
        {"Smithsonian Astrophysical Observation", "SAO 92522"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.71936618),
        dec: Angle.Degrees(+12.55961809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111629"},
        {"Hipparcos Number", "HIP 62673"},
        {"Geneva Identification System", "GEN# +1.00111629"},
        {"Smithsonian Astrophysical Observation", "SAO 100296"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.63825905),
        dec: Angle.Degrees(+12.56051810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86032",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Rasalhague"},
        {"Henry Draper", "HD 159561"},
        {"Hipparcos Number", "HIP 86032"},
        {"Fundamental Katalog 5th Edition", "FK5 656"},
        {"Geneva Identification System", "GEN# +1.00159561"},
        {"Smithsonian Astrophysical Observation", "SAO 102932"},
        {"Wilson Evans Batten Catalogue", "WEB 14516"},
    },
    visualMagnitude: 2.08,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.73335321),
        dec: Angle.Degrees(+12.56057584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 110.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -222.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72031",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72031"},
        {"Smithsonian Astrophysical Observation", "SAO 101174"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.01573636),
        dec: Angle.Degrees(+12.56135495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40686",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40686"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.59062475),
        dec: Angle.Degrees(+12.56200185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49383"},
        {"Hipparcos Number", "HIP 32660"},
        {"Geneva Identification System", "GEN# +1.00049383"},
        {"Smithsonian Astrophysical Observation", "SAO 96137"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.18555068),
        dec: Angle.Degrees(+12.56365461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115219",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115219"},
        {"Smithsonian Astrophysical Observation", "SAO 108550"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.811,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.06230314),
        dec: Angle.Degrees(+12.56391992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91842",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91842"},
        {"Smithsonian Astrophysical Observation", "SAO 104027"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.86897956),
        dec: Angle.Degrees(+12.56438238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34316"},
        {"Hipparcos Number", "HIP 24633"},
        {"Smithsonian Astrophysical Observation", "SAO 94439"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.27262508),
        dec: Angle.Degrees(+12.56551114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96218"},
        {"Hipparcos Number", "HIP 54241"},
        {"Geneva Identification System", "GEN# +1.00096218"},
        {"Smithsonian Astrophysical Observation", "SAO 99433"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.45774629),
        dec: Angle.Degrees(+12.56571943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27235"},
        {"Hipparcos Number", "HIP 20098"},
        {"Geneva Identification System", "GEN# +1.00027235"},
        {"Smithsonian Astrophysical Observation", "SAO 93853"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.63187292),
        dec: Angle.Degrees(+12.56670232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
