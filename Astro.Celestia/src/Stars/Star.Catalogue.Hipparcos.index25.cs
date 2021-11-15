using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_25() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219155"},
        {"Hipparcos Number", "HIP 114712"},
        {"Smithsonian Astrophysical Observation", "SAO 231502"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.54304589),
        dec: Angle.Degrees(-41.71425509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13889"},
        {"Hipparcos Number", "HIP 10413"},
        {"Geneva Identification System", "GEN# +1.00013889"},
        {"Smithsonian Astrophysical Observation", "SAO 215828"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.54454634),
        dec: Angle.Degrees(-41.71261580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -173.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198104"},
        {"Hipparcos Number", "HIP 102792"},
        {"Geneva Identification System", "GEN# +1.00198104"},
        {"Smithsonian Astrophysical Observation", "SAO 230393"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.37121161),
        dec: Angle.Degrees(-41.71156078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143792"},
        {"Hipparcos Number", "HIP 78712"},
        {"Fundamental Katalog 5th Edition", "FK5 5419"},
        {"Geneva Identification System", "GEN# +1.00143792"},
        {"Smithsonian Astrophysical Observation", "SAO 226472"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.03340477),
        dec: Angle.Degrees(-41.71097255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104805"},
        {"Hipparcos Number", "HIP 58837"},
        {"Smithsonian Astrophysical Observation", "SAO 223199"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.01885401),
        dec: Angle.Degrees(-41.70926948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174407"},
        {"Hipparcos Number", "HIP 92608"},
        {"Smithsonian Astrophysical Observation", "SAO 229334"},
    },
    visualMagnitude: 6.47,
    bvColour: 1.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.04977293),
        dec: Angle.Degrees(-41.70912112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125541"},
        {"Hipparcos Number", "HIP 70149"},
        {"Geneva Identification System", "GEN# +1.00125541"},
        {"Smithsonian Astrophysical Observation", "SAO 224854"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.29814380),
        dec: Angle.Degrees(-41.70687289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66039"},
        {"Hipparcos Number", "HIP 39102"},
        {"Geneva Identification System", "GEN# +1.00066039"},
        {"Smithsonian Astrophysical Observation", "SAO 219266"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.99490484),
        dec: Angle.Degrees(-41.70392874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64827"},
        {"Hipparcos Number", "HIP 38584"},
        {"Celescope Catalog", "CEL 2089"},
        {"Geneva Identification System", "GEN# +1.00064827"},
        {"Smithsonian Astrophysical Observation", "SAO 219122"},
    },
    visualMagnitude: 6.85,
    bvColour: -0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.50922265),
        dec: Angle.Degrees(-41.70293783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94355"},
        {"Hipparcos Number", "HIP 53194"},
        {"Smithsonian Astrophysical Observation", "SAO 222397"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.20349434),
        dec: Angle.Degrees(-41.70214355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203755"},
        {"Hipparcos Number", "HIP 105788"},
        {"Smithsonian Astrophysical Observation", "SAO 230678"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.36809139),
        dec: Angle.Degrees(-41.70204676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159576"},
        {"Hipparcos Number", "HIP 86236"},
        {"Smithsonian Astrophysical Observation", "SAO 228205"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.34427580),
        dec: Angle.Degrees(-41.70023222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111565"},
        {"Hipparcos Number", "HIP 62670"},
        {"Smithsonian Astrophysical Observation", "SAO 223701"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.63203183),
        dec: Angle.Degrees(-41.69638525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175530"},
        {"Hipparcos Number", "HIP 93075"},
        {"Smithsonian Astrophysical Observation", "SAO 229403"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.39624066),
        dec: Angle.Degrees(-41.69548147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116423",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116423"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.86976866),
        dec: Angle.Degrees(-41.69504161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133781"},
        {"Hipparcos Number", "HIP 74022"},
        {"Smithsonian Astrophysical Observation", "SAO 225461"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.91006632),
        dec: Angle.Degrees(-41.69372984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215627"},
        {"Hipparcos Number", "HIP 112492"},
        {"Geneva Identification System", "GEN# +1.00215627"},
        {"Smithsonian Astrophysical Observation", "SAO 231296"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.78789855),
        dec: Angle.Degrees(-41.69186331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160323"},
        {"Hipparcos Number", "HIP 86547"},
        {"Celescope Catalog", "CEL 4552"},
        {"Smithsonian Astrophysical Observation", "SAO 228283"},
    },
    visualMagnitude: 8.53,
    bvColour: -0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.29683053),
        dec: Angle.Degrees(-41.69170112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208183"},
        {"Hipparcos Number", "HIP 108229"},
        {"Smithsonian Astrophysical Observation", "SAO 230899"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.88107631),
        dec: Angle.Degrees(-41.69132503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132783"},
        {"Hipparcos Number", "HIP 73579"},
        {"Smithsonian Astrophysical Observation", "SAO 225391"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.58999039),
        dec: Angle.Degrees(-41.69055000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11724"},
        {"Hipparcos Number", "HIP 8868"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.53255782),
        dec: Angle.Degrees(-41.68970457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86548",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86548"},
        {"Smithsonian Astrophysical Observation", "SAO 228284"},
    },
    visualMagnitude: 10.45,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.30151063),
        dec: Angle.Degrees(-41.68930935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43973",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43973"},
        {"Smithsonian Astrophysical Observation", "SAO 136435"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.32080551),
        dec: Angle.Degrees(-09.46266235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -221.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -158.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97722"},
        {"Hipparcos Number", "HIP 54874"},
        {"Smithsonian Astrophysical Observation", "SAO 222658"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.53195537),
        dec: Angle.Degrees(-41.68822356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181269"},
        {"Hipparcos Number", "HIP 95162"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.41161197),
        dec: Angle.Degrees(-41.68768166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120307"},
        {"Hipparcos Number", "HIP 67464"},
        {"Geneva Identification System", "GEN# +1.00120307"},
        {"Smithsonian Astrophysical Observation", "SAO 224469"},
        {"Wilson Evans Batten Catalogue", "WEB 11863"},
    },
    visualMagnitude: 3.41,
    bvColour: -0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.37623920),
        dec: Angle.Degrees(-41.68765971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58399"},
        {"Hipparcos Number", "HIP 35860"},
        {"Smithsonian Astrophysical Observation", "SAO 218688"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.89766064),
        dec: Angle.Degrees(-41.68700306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52785"},
        {"Hipparcos Number", "HIP 33744"},
        {"Smithsonian Astrophysical Observation", "SAO 218380"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.14720599),
        dec: Angle.Degrees(-41.68066040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16930"},
        {"Hipparcos Number", "HIP 12558"},
        {"Smithsonian Astrophysical Observation", "SAO 216006"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.37930469),
        dec: Angle.Degrees(-41.67918056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72958"},
        {"Hipparcos Number", "HIP 42033"},
        {"Smithsonian Astrophysical Observation", "SAO 220113"},
    },
    visualMagnitude: 6.74,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.51807049),
        dec: Angle.Degrees(-41.67890969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32271",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32271"},
    },
    visualMagnitude: 11.11,
    bvColour: 0.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.05956642),
        dec: Angle.Degrees(-41.67537818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 207.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 120.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169898"},
        {"Hipparcos Number", "HIP 90558"},
        {"Smithsonian Astrophysical Observation", "SAO 229051"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.18367917),
        dec: Angle.Degrees(-41.67479099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213255"},
        {"Hipparcos Number", "HIP 111137"},
        {"Smithsonian Astrophysical Observation", "SAO 231173"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.72156892),
        dec: Angle.Degrees(-41.67450387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125891"},
        {"Hipparcos Number", "HIP 70335"},
        {"Smithsonian Astrophysical Observation", "SAO 224887"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.85660976),
        dec: Angle.Degrees(-41.67389930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198940"},
        {"Hipparcos Number", "HIP 103257"},
    },
    visualMagnitude: 9.68,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.77812434),
        dec: Angle.Degrees(-41.67208609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45331"},
        {"Hipparcos Number", "HIP 30504"},
        {"Smithsonian Astrophysical Observation", "SAO 217911"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.18472317),
        dec: Angle.Degrees(-41.67049113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193922"},
        {"Hipparcos Number", "HIP 100642"},
        {"Smithsonian Astrophysical Observation", "SAO 230190"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.10563375),
        dec: Angle.Degrees(-41.66905642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89461"},
        {"Hipparcos Number", "HIP 50480"},
        {"Geneva Identification System", "GEN# +1.00089461"},
        {"Renson", "Renson 25680"},
        {"Smithsonian Astrophysical Observation", "SAO 221948"},
    },
    visualMagnitude: 5.97,
    bvColour: -0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.61777521),
        dec: Angle.Degrees(-41.66849763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146882"},
        {"Hipparcos Number", "HIP 80046"},
        {"Smithsonian Astrophysical Observation", "SAO 226669"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.08543283),
        dec: Angle.Degrees(-41.66802306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33982"},
        {"Hipparcos Number", "HIP 24224"},
        {"Smithsonian Astrophysical Observation", "SAO 217232"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.01552655),
        dec: Angle.Degrees(-41.66797114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 104.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84673"},
        {"Hipparcos Number", "HIP 47898"},
    },
    visualMagnitude: 7.49,
    bvColour: -0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.43293065),
        dec: Angle.Degrees(-41.66698060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112631"},
        {"Hipparcos Number", "HIP 63327"},
        {"Smithsonian Astrophysical Observation", "SAO 223798"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.65590460),
        dec: Angle.Degrees(-41.66601109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97310"},
        {"Hipparcos Number", "HIP 54680"},
        {"Smithsonian Astrophysical Observation", "SAO 222631"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.89592098),
        dec: Angle.Degrees(-41.66436719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171421"},
        {"Hipparcos Number", "HIP 91232"},
        {"Smithsonian Astrophysical Observation", "SAO 229141"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.15240120),
        dec: Angle.Degrees(-41.66400001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 323684"},
        {"Hipparcos Number", "HIP 85533"},
    },
    visualMagnitude: 10.45,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.19193338),
        dec: Angle.Degrees(-41.66351458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -183.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129141"},
        {"Hipparcos Number", "HIP 71880"},
        {"Smithsonian Astrophysical Observation", "SAO 225135"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.959,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.53856253),
        dec: Angle.Degrees(-41.66146537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75871"},
        {"Hipparcos Number", "HIP 43464"},
        {"Celescope Catalog", "CEL 3000"},
        {"Geneva Identification System", "GEN# +1.00075871"},
        {"Smithsonian Astrophysical Observation", "SAO 220575"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.79624904),
        dec: Angle.Degrees(-41.66126369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160876"},
        {"Hipparcos Number", "HIP 86799"},
        {"Celescope Catalog", "CEL 4559"},
        {"Geneva Identification System", "GEN# +1.00160876"},
        {"Smithsonian Astrophysical Observation", "SAO 228351"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.05254440),
        dec: Angle.Degrees(-41.66124932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43452"},
        {"Hipparcos Number", "HIP 29593"},
        {"Geneva Identification System", "GEN# +1.00043452"},
        {"Smithsonian Astrophysical Observation", "SAO 217794"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.54990301),
        dec: Angle.Degrees(-41.66064655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28766"},
        {"Hipparcos Number", "HIP 21004"},
        {"Smithsonian Astrophysical Observation", "SAO 216839"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.56431076),
        dec: Angle.Degrees(-41.65975422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142821"},
        {"Hipparcos Number", "HIP 78215"},
        {"Geneva Identification System", "GEN# +1.00142821"},
        {"Smithsonian Astrophysical Observation", "SAO 226409"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.58229684),
        dec: Angle.Degrees(-41.65959528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3737"},
        {"Hipparcos Number", "HIP 3127"},
        {"Geneva Identification System", "GEN# +1.00003737"},
        {"Smithsonian Astrophysical Observation", "SAO 215184"},
        {"Wilson Evans Batten Catalogue", "WEB 556"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.93651028),
        dec: Angle.Degrees(-41.65936635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137376"},
        {"Hipparcos Number", "HIP 75628"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.78469497),
        dec: Angle.Degrees(-41.65876146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64902"},
        {"Hipparcos Number", "HIP 38618"},
        {"Smithsonian Astrophysical Observation", "SAO 219131"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.61433653),
        dec: Angle.Degrees(-41.65817625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12041",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12041"},
        {"Geneva Identification System", "GEN# -0.01000514"},
        {"Smithsonian Astrophysical Observation", "SAO 129990"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.80252845),
        dec: Angle.Degrees(-09.41696158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170502"},
        {"Hipparcos Number", "HIP 90821"},
        {"Smithsonian Astrophysical Observation", "SAO 229093"},
    },
    visualMagnitude: 8.17,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.91104143),
        dec: Angle.Degrees(-41.65767461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97609"},
        {"Hipparcos Number", "HIP 54831"},
        {"Geneva Identification System", "GEN# +1.00097609"},
        {"Smithsonian Astrophysical Observation", "SAO 222650"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.38343885),
        dec: Angle.Degrees(-41.65748535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148675"},
        {"Hipparcos Number", "HIP 80932"},
        {"Smithsonian Astrophysical Observation", "SAO 226849"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.89120736),
        dec: Angle.Degrees(-41.65640582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71106"},
        {"Hipparcos Number", "HIP 41164"},
        {"Smithsonian Astrophysical Observation", "SAO 219872"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.98038441),
        dec: Angle.Degrees(-41.65633260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6351",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6351"},
        {"Geneva Identification System", "GEN# +6.10010057"},
        {"Geneva Identification System 2", "GEN# -0.04200469"},
    },
    visualMagnitude: 10.15,
    bvColour: 1.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.39010873),
        dec: Angle.Degrees(-41.65529478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1238.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -455.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40379",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40379"},
    },
    visualMagnitude: 13.49,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.66419594),
        dec: Angle.Degrees(-41.65392405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194050"},
        {"Hipparcos Number", "HIP 100715"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.27117127),
        dec: Angle.Degrees(-41.65301502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137992"},
        {"Hipparcos Number", "HIP 75950"},
        {"Geneva Identification System", "GEN# +1.00137992"},
        {"Smithsonian Astrophysical Observation", "SAO 225852"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.68837773),
        dec: Angle.Degrees(-41.65265055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211700"},
        {"Hipparcos Number", "HIP 110235"},
        {"Smithsonian Astrophysical Observation", "SAO 231083"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.94649099),
        dec: Angle.Degrees(-41.65234573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 109.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37654"},
        {"Hipparcos Number", "HIP 26496"},
        {"Smithsonian Astrophysical Observation", "SAO 217440"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.893,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.52988808),
        dec: Angle.Degrees(-41.65100398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170774"},
        {"Hipparcos Number", "HIP 90941"},
        {"Smithsonian Astrophysical Observation", "SAO 229107"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.26066247),
        dec: Angle.Degrees(-41.65077450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89998"},
        {"Hipparcos Number", "HIP 50799"},
        {"Fundamental Katalog 5th Edition", "FK5 1268"},
        {"Geneva Identification System", "GEN# +1.00089998"},
        {"Smithsonian Astrophysical Observation", "SAO 221998"},
        {"Wilson Evans Batten Catalogue", "WEB 9298"},
    },
    visualMagnitude: 4.82,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.58169175),
        dec: Angle.Degrees(-41.65010791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145984"},
        {"Hipparcos Number", "HIP 79673"},
        {"Geneva Identification System", "GEN# +1.00145984"},
        {"Smithsonian Astrophysical Observation", "SAO 226608"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.90486800),
        dec: Angle.Degrees(-41.64958690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218389"},
        {"Hipparcos Number", "HIP 114232"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.02168494),
        dec: Angle.Degrees(-41.64898512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155895"},
        {"Hipparcos Number", "HIP 84473"},
        {"Smithsonian Astrophysical Observation", "SAO 227767"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.03991490),
        dec: Angle.Degrees(-41.64762301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10625"},
        {"Hipparcos Number", "HIP 7996"},
        {"Smithsonian Astrophysical Observation", "SAO 215624"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.67828366),
        dec: Angle.Degrees(-41.64730664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158967"},
        {"Hipparcos Number", "HIP 85959"},
        {"Smithsonian Astrophysical Observation", "SAO 228128"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.51962619),
        dec: Angle.Degrees(-41.64715848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60729"},
        {"Hipparcos Number", "HIP 36800"},
        {"Smithsonian Astrophysical Observation", "SAO 218804"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.52574418),
        dec: Angle.Degrees(-41.64566210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114076"},
        {"Hipparcos Number", "HIP 64125"},
        {"Cincinnati Publication", "Ci 20 759"},
        {"Geneva Identification System", "GEN# +1.00114076"},
        {"Smithsonian Astrophysical Observation", "SAO 223928"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.811,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.14320823),
        dec: Angle.Degrees(-41.64397780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -568.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75636",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75636"},
    },
    visualMagnitude: 10.33,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.79384596),
        dec: Angle.Degrees(-41.64252119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65656"},
        {"Hipparcos Number", "HIP 38924"},
        {"Celescope Catalog", "CEL 2117"},
        {"Geneva Identification System", "GEN# +1.00065656"},
        {"Smithsonian Astrophysical Observation", "SAO 219212"},
    },
    visualMagnitude: 7.54,
    bvColour: -0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.47722043),
        dec: Angle.Degrees(-41.64122764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43787"},
        {"Hipparcos Number", "HIP 29772"},
        {"Smithsonian Astrophysical Observation", "SAO 217820"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.03490765),
        dec: Angle.Degrees(-41.64116238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -131.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21473"},
        {"Hipparcos Number", "HIP 16015"},
        {"Geneva Identification System", "GEN# +1.00021473"},
        {"Smithsonian Astrophysical Observation", "SAO 216316"},
        {"Wilson Evans Batten Catalogue", "WEB 3059"},
    },
    visualMagnitude: 6.33,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.54903801),
        dec: Angle.Degrees(-41.63700538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45554"},
        {"Hipparcos Number", "HIP 30626"},
        {"Smithsonian Astrophysical Observation", "SAO 217924"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.53959906),
        dec: Angle.Degrees(-41.63689898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149726"},
        {"Hipparcos Number", "HIP 81479"},
        {"Geneva Identification System", "GEN# +1.00149726"},
        {"Smithsonian Astrophysical Observation", "SAO 226991"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.63016350),
        dec: Angle.Degrees(-41.63524051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12631"},
        {"Hipparcos Number", "HIP 9555"},
        {"Smithsonian Astrophysical Observation", "SAO 215746"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.69293052),
        dec: Angle.Degrees(-41.63471181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120960"},
        {"Hipparcos Number", "HIP 67817"},
        {"Smithsonian Astrophysical Observation", "SAO 224511"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.38450682),
        dec: Angle.Degrees(-41.63433019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206193"},
        {"Hipparcos Number", "HIP 107096"},
        {"Renson", "Renson 57430"},
        {"Smithsonian Astrophysical Observation", "SAO 230795"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.38899449),
        dec: Angle.Degrees(-41.63295862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202176"},
        {"Hipparcos Number", "HIP 104948"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.87910033),
        dec: Angle.Degrees(-41.62969134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59197"},
        {"Hipparcos Number", "HIP 36167"},
        {"Celescope Catalog", "CEL 1861"},
        {"Geneva Identification System", "GEN# +1.00059197"},
        {"Smithsonian Astrophysical Observation", "SAO 218729"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.74771678),
        dec: Angle.Degrees(-41.62911200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 273211"},
        {"Hipparcos Number", "HIP 24471"},
        {"Geneva Identification System", "GEN# +1.00273211"},
        {"Wilson Evans Batten Catalogue", "WEB 4740"},
    },
    visualMagnitude: 11.06,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.78231157),
        dec: Angle.Degrees(-41.62829591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211202"},
        {"Hipparcos Number", "HIP 109973"},
        {"Geneva Identification System", "GEN# +1.00211202"},
        {"Smithsonian Astrophysical Observation", "SAO 231063"},
        {"Wilson Evans Batten Catalogue", "WEB 19742"},
    },
    visualMagnitude: 5.11,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.11070233),
        dec: Angle.Degrees(-41.62720198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46041"},
        {"Hipparcos Number", "HIP 30889"},
        {"Smithsonian Astrophysical Observation", "SAO 217957"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.26566271),
        dec: Angle.Degrees(-41.62597820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90226",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90226"},
    },
    visualMagnitude: 10.90,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.14583114),
        dec: Angle.Degrees(-41.62573758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -140.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148338"},
        {"Hipparcos Number", "HIP 80746"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.29041602),
        dec: Angle.Degrees(-41.62484303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151564"},
        {"Hipparcos Number", "HIP 82378"},
        {"Celescope Catalog", "CEL 4430"},
        {"Geneva Identification System", "GEN# +1.00151564"},
        {"Smithsonian Astrophysical Observation", "SAO 227278"},
        {"Wilson Evans Batten Catalogue", "WEB 13907"},
        {"New General Catalogue", "NGC 6231 302"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.50601841),
        dec: Angle.Degrees(-41.62124226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183484"},
        {"Hipparcos Number", "HIP 96048"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.93524171),
        dec: Angle.Degrees(-41.61849094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81970"},
        {"Hipparcos Number", "HIP 46406"},
        {"Smithsonian Astrophysical Observation", "SAO 221185"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.95058818),
        dec: Angle.Degrees(-41.61754161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72834"},
        {"Hipparcos Number", "HIP 41984"},
        {"Geneva Identification System", "GEN# +1.00072834"},
        {"Smithsonian Astrophysical Observation", "SAO 220098"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.36677645),
        dec: Angle.Degrees(-41.61635113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -139.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154569"},
        {"Hipparcos Number", "HIP 83845"},
        {"Smithsonian Astrophysical Observation", "SAO 227651"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.02346770),
        dec: Angle.Degrees(-41.61464329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171616"},
        {"Hipparcos Number", "HIP 91336"},
        {"Geneva Identification System", "GEN# +1.00171616"},
        {"Smithsonian Astrophysical Observation", "SAO 229154"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.43347592),
        dec: Angle.Degrees(-41.61414425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224937"},
        {"Hipparcos Number", "HIP 151"},
        {"Geneva Identification System", "GEN# +1.00224937J"},
        {"Smithsonian Astrophysical Observation", "SAO 231903"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.48458240),
        dec: Angle.Degrees(-41.61373674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213915"},
        {"Hipparcos Number", "HIP 111500"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.85790194),
        dec: Angle.Degrees(-41.61170263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53222"},
        {"Hipparcos Number", "HIP 33912"},
        {"Smithsonian Astrophysical Observation", "SAO 218394"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.56994059),
        dec: Angle.Degrees(-41.61114317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213096"},
        {"Hipparcos Number", "HIP 111047"},
        {"Smithsonian Astrophysical Observation", "SAO 231162"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.44617364),
        dec: Angle.Degrees(-41.61080077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151003"},
        {"Hipparcos Number", "HIP 82121"},
        {"Celescope Catalog", "CEL 4425"},
        {"Geneva Identification System", "GEN# +1.00151003"},
        {"Smithsonian Astrophysical Observation", "SAO 227190"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.64248521),
        dec: Angle.Degrees(-41.61069564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186133"},
        {"Hipparcos Number", "HIP 97131"},
        {"Smithsonian Astrophysical Observation", "SAO 229843"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.11550138),
        dec: Angle.Degrees(-41.60911788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21705"},
        {"Hipparcos Number", "HIP 16189"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.13902587),
        dec: Angle.Degrees(-41.60849343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32678"},
        {"Hipparcos Number", "HIP 23488"},
        {"Smithsonian Astrophysical Observation", "SAO 217136"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.73854367),
        dec: Angle.Degrees(-41.60752813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222741"},
        {"Hipparcos Number", "HIP 117026"},
        {"Geneva Identification System", "GEN# +1.00222741"},
        {"Smithsonian Astrophysical Observation", "SAO 231752"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.85080526),
        dec: Angle.Degrees(-41.60465010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 106.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79226"},
        {"Hipparcos Number", "HIP 45118"},
        {"Smithsonian Astrophysical Observation", "SAO 220936"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.88315903),
        dec: Angle.Degrees(-41.60395416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220353"},
        {"Hipparcos Number", "HIP 115459"},
        {"Fundamental Katalog 5th Edition", "FK5 6068"},
        {"Geneva Identification System", "GEN# +1.00220353"},
        {"Smithsonian Astrophysical Observation", "SAO 231583"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.82708054),
        dec: Angle.Degrees(-41.60123876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223605"},
        {"Hipparcos Number", "HIP 117606"},
        {"Smithsonian Astrophysical Observation", "SAO 231807"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.76186240),
        dec: Angle.Degrees(-41.59993077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 324492"},
        {"Hipparcos Number", "HIP 87658"},
    },
    visualMagnitude: 11.13,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.56587648),
        dec: Angle.Degrees(-41.59819626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -203.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11879"},
        {"Hipparcos Number", "HIP 8989"},
        {"Smithsonian Astrophysical Observation", "SAO 215702"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.95720056),
        dec: Angle.Degrees(-41.59367425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 148.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -229.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3552"},
        {"Hipparcos Number", "HIP 2997"},
        {"Geneva Identification System", "GEN# +1.00003552"},
        {"Smithsonian Astrophysical Observation", "SAO 215173"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.52641555),
        dec: Angle.Degrees(-41.59224002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38989"},
        {"Hipparcos Number", "HIP 27344"},
        {"Geneva Identification System", "GEN# +1.00038989"},
        {"Smithsonian Astrophysical Observation", "SAO 217537"},
        {"Wilson Evans Batten Catalogue", "WEB 5374"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.87286085),
        dec: Angle.Degrees(-41.59018313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113778"},
        {"Hipparcos Number", "HIP 63972"},
        {"Fundamental Katalog 5th Edition", "FK5 3044"},
        {"Geneva Identification System", "GEN# +1.00113778"},
        {"Smithsonian Astrophysical Observation", "SAO 223905"},
    },
    visualMagnitude: 5.59,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.64603079),
        dec: Angle.Degrees(-41.58840727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7885"},
        {"Hipparcos Number", "HIP 6070"},
        {"Geneva Identification System", "GEN# +1.00007885"},
        {"Smithsonian Astrophysical Observation", "SAO 215444"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.822,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.47575286),
        dec: Angle.Degrees(-41.58806129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 133.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97249"},
        {"Hipparcos Number", "HIP 54647"},
        {"Geneva Identification System", "GEN# +1.00097249"},
        {"Smithsonian Astrophysical Observation", "SAO 222620"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.76949193),
        dec: Angle.Degrees(-41.58744532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -183.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65891"},
        {"Hipparcos Number", "HIP 39026"},
        {"Geneva Identification System", "GEN# +1.00065891"},
        {"Smithsonian Astrophysical Observation", "SAO 219238"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.77934449),
        dec: Angle.Degrees(-41.58724927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 262.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30847"},
        {"Hipparcos Number", "HIP 22397"},
        {"Smithsonian Astrophysical Observation", "SAO 217013"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.30781028),
        dec: Angle.Degrees(-41.58692107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86111"},
        {"Hipparcos Number", "HIP 48662"},
        {"Geneva Identification System", "GEN# +1.00086111"},
        {"Smithsonian Astrophysical Observation", "SAO 221606"},
        {"Wilson Evans Batten Catalogue", "WEB 9054"},
    },
    visualMagnitude: 6.69,
    bvColour: 3.761,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.85880823),
        dec: Angle.Degrees(-41.58689247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117521"},
        {"Hipparcos Number", "HIP 65964"},
        {"Smithsonian Astrophysical Observation", "SAO 224217"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.87216962),
        dec: Angle.Degrees(-41.58530138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216186"},
        {"Hipparcos Number", "HIP 112860"},
        {"Smithsonian Astrophysical Observation", "SAO 231327"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.83488238),
        dec: Angle.Degrees(-41.58191356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100525"},
        {"Hipparcos Number", "HIP 56407"},
        {"Smithsonian Astrophysical Observation", "SAO 222868"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.46871114),
        dec: Angle.Degrees(-41.58178741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222508"},
        {"Hipparcos Number", "HIP 116880"},
        {"Geneva Identification System", "GEN# +1.00222508"},
        {"Smithsonian Astrophysical Observation", "SAO 231740"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.36848551),
        dec: Angle.Degrees(-41.58027847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223065"},
        {"Hipparcos Number", "HIP 117254"},
        {"Cincinnati Publication", "Ci 20 1451"},
        {"Geneva Identification System", "GEN# +1.00223065"},
        {"Smithsonian Astrophysical Observation", "SAO 231773"},
        {"Wilson Evans Batten Catalogue", "WEB 20659"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.63622304),
        dec: Angle.Degrees(-41.57979742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 255.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -856.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73810"},
        {"Hipparcos Number", "HIP 42398"},
        {"Celescope Catalog", "CEL 2737"},
        {"Geneva Identification System", "GEN# +1.00073810"},
        {"Smithsonian Astrophysical Observation", "SAO 220229"},
    },
    visualMagnitude: 9.02,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.67985847),
        dec: Angle.Degrees(-41.57973497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34952"},
        {"Hipparcos Number", "HIP 24818"},
        {"Smithsonian Astrophysical Observation", "SAO 217283"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.79741017),
        dec: Angle.Degrees(-41.57942390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218668"},
        {"Hipparcos Number", "HIP 114413"},
        {"Smithsonian Astrophysical Observation", "SAO 231466"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.56676088),
        dec: Angle.Degrees(-41.57840998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170041"},
        {"Hipparcos Number", "HIP 90614"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.35205806),
        dec: Angle.Degrees(-41.57811612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42931"},
        {"Hipparcos Number", "HIP 29374"},
        {"Geneva Identification System", "GEN# +1.00042931"},
        {"Smithsonian Astrophysical Observation", "SAO 217766"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.87535326),
        dec: Angle.Degrees(-41.57791739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -281.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220916"},
        {"Hipparcos Number", "HIP 115826"},
        {"Geneva Identification System", "GEN# +1.00220916"},
        {"Smithsonian Astrophysical Observation", "SAO 231616"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.98373385),
        dec: Angle.Degrees(-41.57633792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 260.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147669"},
        {"Hipparcos Number", "HIP 80428"},
        {"Smithsonian Astrophysical Observation", "SAO 226737"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.25233877),
        dec: Angle.Degrees(-41.57607539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115852"},
        {"Hipparcos Number", "HIP 65087"},
        {"Smithsonian Astrophysical Observation", "SAO 224072"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.10996574),
        dec: Angle.Degrees(-41.57605311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132839"},
        {"Hipparcos Number", "HIP 73595"},
        {"Smithsonian Astrophysical Observation", "SAO 225397"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.64488548),
        dec: Angle.Degrees(-41.57364966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95160"},
        {"Hipparcos Number", "HIP 53663"},
        {"Smithsonian Astrophysical Observation", "SAO 222463"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.68137481),
        dec: Angle.Degrees(-41.57040273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197469"},
        {"Hipparcos Number", "HIP 102434"},
        {"Smithsonian Astrophysical Observation", "SAO 230352"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.34833999),
        dec: Angle.Degrees(-41.57032964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88481"},
        {"Hipparcos Number", "HIP 49901"},
        {"Smithsonian Astrophysical Observation", "SAO 221843"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.82756439),
        dec: Angle.Degrees(-41.56657869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138255"},
        {"Hipparcos Number", "HIP 76095"},
        {"Smithsonian Astrophysical Observation", "SAO 225882"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.11773538),
        dec: Angle.Degrees(-41.56461873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222119"},
        {"Hipparcos Number", "HIP 116623"},
        {"Smithsonian Astrophysical Observation", "SAO 231708"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.51125252),
        dec: Angle.Degrees(-41.56452061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29303"},
        {"Hipparcos Number", "HIP 21368"},
        {"Geneva Identification System", "GEN# +1.00029303"},
        {"Smithsonian Astrophysical Observation", "SAO 216883"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.76875151),
        dec: Angle.Degrees(-41.56368047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171924"},
        {"Hipparcos Number", "HIP 91463"},
        {"Geneva Identification System", "GEN# +1.00171924"},
        {"Smithsonian Astrophysical Observation", "SAO 229168"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.81698922),
        dec: Angle.Degrees(-41.56362164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12868",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12868"},
        {"Geneva Identification System", "GEN# -0.04200917"},
        {"Wilson Evans Batten Catalogue", "WEB 2615"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.762,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.35582112),
        dec: Angle.Degrees(-41.56336241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -146.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -126.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209537"},
        {"Hipparcos Number", "HIP 109022"},
        {"Smithsonian Astrophysical Observation", "SAO 230971"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.29677714),
        dec: Angle.Degrees(-41.56293843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139161"},
        {"Hipparcos Number", "HIP 76560"},
        {"Smithsonian Astrophysical Observation", "SAO 226005"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.54183343),
        dec: Angle.Degrees(-41.56004053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119041"},
        {"Hipparcos Number", "HIP 66812"},
        {"Smithsonian Astrophysical Observation", "SAO 224340"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.41994527),
        dec: Angle.Degrees(-41.55989671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107711",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107711"},
        {"Geneva Identification System", "GEN# +6.20145089"},
    },
    visualMagnitude: 11.52,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.29637525),
        dec: Angle.Degrees(-41.55787029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 948.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -471.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42196",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42196"},
    },
    visualMagnitude: 11.00,
    bvColour: 1.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.06007344),
        dec: Angle.Degrees(-41.55748321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -244.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 109.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47475"},
        {"Hipparcos Number", "HIP 31603"},
        {"Geneva Identification System", "GEN# +1.00047475"},
        {"Smithsonian Astrophysical Observation", "SAO 218060"},
    },
    visualMagnitude: 6.36,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.21364301),
        dec: Angle.Degrees(-41.55715503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156741"},
        {"Hipparcos Number", "HIP 84911"},
        {"Smithsonian Astrophysical Observation", "SAO 227852"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.741,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.29596082),
        dec: Angle.Degrees(-41.55689203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4918"},
        {"Hipparcos Number", "HIP 3955"},
        {"Smithsonian Astrophysical Observation", "SAO 215261"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.69576073),
        dec: Angle.Degrees(-41.55572881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179981"},
        {"Hipparcos Number", "HIP 94719"},
        {"Smithsonian Astrophysical Observation", "SAO 229587"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.10319445),
        dec: Angle.Degrees(-41.55554251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77902"},
        {"Hipparcos Number", "HIP 44487"},
        {"Geneva Identification System", "GEN# +1.00077902"},
        {"Smithsonian Astrophysical Observation", "SAO 220796"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.96375454),
        dec: Angle.Degrees(-41.55538135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44687"},
        {"Hipparcos Number", "HIP 30192"},
        {"Smithsonian Astrophysical Observation", "SAO 217872"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.27770531),
        dec: Angle.Degrees(-41.55364151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16590"},
        {"Hipparcos Number", "HIP 12285"},
        {"Smithsonian Astrophysical Observation", "SAO 215979"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.56313425),
        dec: Angle.Degrees(-41.55330733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203432"},
        {"Hipparcos Number", "HIP 105606"},
        {"Geneva Identification System", "GEN# +1.00203432"},
        {"Smithsonian Astrophysical Observation", "SAO 230659"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.741,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.84425942),
        dec: Angle.Degrees(-41.55216330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -144.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193789"},
        {"Hipparcos Number", "HIP 100578"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.94847612),
        dec: Angle.Degrees(-41.54876080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73269"},
        {"Hipparcos Number", "HIP 42181"},
        {"Smithsonian Astrophysical Observation", "SAO 220164"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.00538780),
        dec: Angle.Degrees(-41.54831190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108278"},
        {"Hipparcos Number", "HIP 60717"},
        {"Geneva Identification System", "GEN# +1.00108278"},
        {"Smithsonian Astrophysical Observation", "SAO 223440"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.64782385),
        dec: Angle.Degrees(-41.54572107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100190"},
        {"Hipparcos Number", "HIP 56215"},
        {"Smithsonian Astrophysical Observation", "SAO 222838"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.85351678),
        dec: Angle.Degrees(-41.54530849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -102.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6141"},
        {"Hipparcos Number", "HIP 4827"},
        {"Smithsonian Astrophysical Observation", "SAO 215333"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.50096915),
        dec: Angle.Degrees(-41.54450842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12349"},
        {"Hipparcos Number", "HIP 9350"},
        {"Geneva Identification System", "GEN# +1.00012349"},
        {"Smithsonian Astrophysical Observation", "SAO 215731"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.02540857),
        dec: Angle.Degrees(-41.54341271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215072"},
        {"Hipparcos Number", "HIP 112186"},
        {"Geneva Identification System", "GEN# +1.00215072"},
        {"Smithsonian Astrophysical Observation", "SAO 231262"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.82365533),
        dec: Angle.Degrees(-41.54340994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127463"},
        {"Hipparcos Number", "HIP 71123"},
        {"Smithsonian Astrophysical Observation", "SAO 225006"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.16148524),
        dec: Angle.Degrees(-41.54258733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11630"},
        {"Hipparcos Number", "HIP 8808"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.30093232),
        dec: Angle.Degrees(-41.54106160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205531"},
        {"Hipparcos Number", "HIP 106722"},
        {"Geneva Identification System", "GEN# +1.00205531"},
        {"Smithsonian Astrophysical Observation", "SAO 230756"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.26736645),
        dec: Angle.Degrees(-41.53732287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65616"},
        {"Hipparcos Number", "HIP 38909"},
        {"Smithsonian Astrophysical Observation", "SAO 219208"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.44640006),
        dec: Angle.Degrees(-41.53571409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61762"},
        {"Hipparcos Number", "HIP 37250"},
        {"Geneva Identification System", "GEN# +1.00061762"},
        {"Smithsonian Astrophysical Observation", "SAO 218864"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.75346214),
        dec: Angle.Degrees(-41.53560881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71998"},
        {"Hipparcos Number", "HIP 41594"},
        {"Celescope Catalog", "CEL 2551"},
        {"Geneva Identification System", "GEN# +1.00071998"},
        {"Smithsonian Astrophysical Observation", "SAO 219975"},
    },
    visualMagnitude: 8.60,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.19940067),
        dec: Angle.Degrees(-41.53347858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209756"},
        {"Hipparcos Number", "HIP 109159"},
        {"Smithsonian Astrophysical Observation", "SAO 230984"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.67218731),
        dec: Angle.Degrees(-41.53328547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100836"},
        {"Hipparcos Number", "HIP 56585"},
        {"Smithsonian Astrophysical Observation", "SAO 222896"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.02014788),
        dec: Angle.Degrees(-41.53252955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43900"},
        {"Hipparcos Number", "HIP 29818"},
        {"Smithsonian Astrophysical Observation", "SAO 217825"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.874,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.19241873),
        dec: Angle.Degrees(-41.53182938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23011"},
        {"Hipparcos Number", "HIP 17114"},
        {"Smithsonian Astrophysical Observation", "SAO 216432"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.98379851),
        dec: Angle.Degrees(-41.53140075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6534"},
        {"Hipparcos Number", "HIP 5135"},
        {"Geneva Identification System", "GEN# +1.00006534"},
        {"Smithsonian Astrophysical Observation", "SAO 215361"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.44399830),
        dec: Angle.Degrees(-41.52951304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174232"},
        {"Hipparcos Number", "HIP 92525"},
        {"Geneva Identification System", "GEN# +1.00174232"},
        {"Smithsonian Astrophysical Observation", "SAO 229324"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.84532924),
        dec: Angle.Degrees(-41.52792156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16864",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16864"},
        {"Smithsonian Astrophysical Observation", "SAO 216403"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.773,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.25541318),
        dec: Angle.Degrees(-41.52783831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 173.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 79.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189584"},
        {"Hipparcos Number", "HIP 98672"},
        {"Smithsonian Astrophysical Observation", "SAO 230004"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.62728987),
        dec: Angle.Degrees(-41.52735581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72139"},
        {"Hipparcos Number", "HIP 41656"},
        {"Celescope Catalog", "CEL 2566"},
        {"Geneva Identification System", "GEN# +1.00072139"},
        {"Smithsonian Astrophysical Observation", "SAO 219998"},
    },
    visualMagnitude: 8.10,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.40475911),
        dec: Angle.Degrees(-41.52487520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195521"},
        {"Hipparcos Number", "HIP 101432"},
        {"Geneva Identification System", "GEN# +1.00195521"},
        {"Smithsonian Astrophysical Observation", "SAO 230268"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.34562482),
        dec: Angle.Degrees(-41.52433433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -181.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71204"},
        {"Hipparcos Number", "HIP 41198"},
        {"Smithsonian Astrophysical Observation", "SAO 219878"},
    },
    visualMagnitude: 7.81,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.10140287),
        dec: Angle.Degrees(-41.52383143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7246"},
        {"Hipparcos Number", "HIP 5619"},
        {"Smithsonian Astrophysical Observation", "SAO 215408"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.03693890),
        dec: Angle.Degrees(-41.52243010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85898"},
        {"Hipparcos Number", "HIP 48533"},
        {"Smithsonian Astrophysical Observation", "SAO 221585"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.48234217),
        dec: Angle.Degrees(-41.52226920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68102",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68102"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.14007489),
        dec: Angle.Degrees(-41.52151903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63425B"},
        {"Hipparcos Number", "HIP 37985"},
        {"Smithsonian Astrophysical Observation", "SAO 218993"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.78065939),
        dec: Angle.Degrees(-41.51750922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127971"},
        {"Hipparcos Number", "HIP 71353"},
        {"Geneva Identification System", "GEN# +1.00127971J"},
        {"Smithsonian Astrophysical Observation", "SAO 225046"},
        {"Wilson Evans Batten Catalogue", "WEB 12320"},
    },
    visualMagnitude: 5.88,
    bvColour: -0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.88124123),
        dec: Angle.Degrees(-41.51738017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116645",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116645"},
        {"Geneva Identification System", "GEN# +6.20145142"},
    },
    visualMagnitude: 11.95,
    bvColour: 1.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.57190246),
        dec: Angle.Degrees(-41.51722214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 210.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -198.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159258"},
        {"Hipparcos Number", "HIP 86091"},
        {"Smithsonian Astrophysical Observation", "SAO 228164"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.90185064),
        dec: Angle.Degrees(-41.51640902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74867"},
        {"Hipparcos Number", "HIP 42932"},
        {"Celescope Catalog", "CEL 2850"},
        {"Geneva Identification System", "GEN# +1.00074867"},
        {"Smithsonian Astrophysical Observation", "SAO 220389"},
    },
    visualMagnitude: 8.73,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.25845536),
        dec: Angle.Degrees(-41.51619835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72348"},
        {"Hipparcos Number", "HIP 41746"},
        {"Smithsonian Astrophysical Observation", "SAO 220026"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.69353057),
        dec: Angle.Degrees(-41.51504719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89301"},
        {"Hipparcos Number", "HIP 50380"},
        {"Smithsonian Astrophysical Observation", "SAO 221932"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.30482708),
        dec: Angle.Degrees(-41.51453998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37919"},
        {"Hipparcos Number", "HIP 26657"},
        {"Smithsonian Astrophysical Observation", "SAO 217465"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.98370966),
        dec: Angle.Degrees(-41.51421015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 324487"},
        {"Hipparcos Number", "HIP 87307"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.59268496),
        dec: Angle.Degrees(-41.51303944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185652"},
        {"Hipparcos Number", "HIP 96910"},
        {"Smithsonian Astrophysical Observation", "SAO 229819"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.50056758),
        dec: Angle.Degrees(-41.51130405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73550"},
        {"Hipparcos Number", "HIP 42295"},
        {"Geneva Identification System", "GEN# +1.00073550"},
        {"Smithsonian Astrophysical Observation", "SAO 220193"},
    },
    visualMagnitude: 9.01,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.34761386),
        dec: Angle.Degrees(-41.50969233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 327109"},
        {"Hipparcos Number", "HIP 84204"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.19351727),
        dec: Angle.Degrees(-41.50936038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98494"},
        {"Hipparcos Number", "HIP 55298"},
        {"Geneva Identification System", "GEN# +1.00098494"},
        {"Smithsonian Astrophysical Observation", "SAO 222717"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.86818232),
        dec: Angle.Degrees(-41.50828673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9488"},
        {"Hipparcos Number", "HIP 7164"},
        {"Geneva Identification System", "GEN# +1.00009488"},
        {"Smithsonian Astrophysical Observation", "SAO 215542"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.08755766),
        dec: Angle.Degrees(-41.50595283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89216"},
        {"Hipparcos Number", "HIP 50328"},
        {"Smithsonian Astrophysical Observation", "SAO 221926"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.16428619),
        dec: Angle.Degrees(-41.50573908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78133",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78133"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.31129049),
        dec: Angle.Degrees(-41.50560994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199018"},
        {"Hipparcos Number", "HIP 103291"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.89486032),
        dec: Angle.Degrees(-41.50513069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138741"},
        {"Hipparcos Number", "HIP 76327"},
        {"Geneva Identification System", "GEN# +1.00138741"},
        {"Smithsonian Astrophysical Observation", "SAO 225943"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.86694747),
        dec: Angle.Degrees(-41.50472432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108934"},
        {"Hipparcos Number", "HIP 61101"},
        {"Smithsonian Astrophysical Observation", "SAO 223484"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.82838213),
        dec: Angle.Degrees(-41.50466269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192756"},
        {"Hipparcos Number", "HIP 100075"},
        {"Smithsonian Astrophysical Observation", "SAO 230139"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.54408078),
        dec: Angle.Degrees(-41.50383602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63425"},
        {"Hipparcos Number", "HIP 37983"},
        {"Celescope Catalog", "CEL 2030"},
        {"Geneva Identification System", "GEN# +1.00063425A"},
        {"Smithsonian Astrophysical Observation", "SAO 218992"},
        {"Wilson Evans Batten Catalogue", "WEB 7494"},
    },
    visualMagnitude: 6.93,
    bvColour: -0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.77997441),
        dec: Angle.Degrees(-41.50374024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6577"},
        {"Hipparcos Number", "HIP 5168"},
        {"Geneva Identification System", "GEN# +1.00006577"},
        {"Smithsonian Astrophysical Observation", "SAO 215364"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.813,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.52583481),
        dec: Angle.Degrees(-41.50099219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157387"},
        {"Hipparcos Number", "HIP 85222"},
        {"Geneva Identification System", "GEN# +1.00157387"},
        {"Smithsonian Astrophysical Observation", "SAO 227925"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.21109982),
        dec: Angle.Degrees(-41.50057408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116835"},
        {"Hipparcos Number", "HIP 65593"},
        {"Geneva Identification System", "GEN# +1.00116835"},
        {"Smithsonian Astrophysical Observation", "SAO 224148"},
    },
    visualMagnitude: 5.69,
    bvColour: 1.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.73384964),
        dec: Angle.Degrees(-41.49756484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76719",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76719"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.99051687),
        dec: Angle.Degrees(-41.49747782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93298"},
        {"Hipparcos Number", "HIP 52624"},
        {"Smithsonian Astrophysical Observation", "SAO 222302"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.42654047),
        dec: Angle.Degrees(-41.49741640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11112"},
        {"Hipparcos Number", "HIP 8398"},
        {"Geneva Identification System", "GEN# +1.00011112"},
        {"Smithsonian Astrophysical Observation", "SAO 215660"},
        {"Wilson Evans Batten Catalogue", "WEB 1786"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.08442078),
        dec: Angle.Degrees(-41.49543661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 413.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 153.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108403"},
        {"Hipparcos Number", "HIP 60773"},
        {"Smithsonian Astrophysical Observation", "SAO 223448"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.85440855),
        dec: Angle.Degrees(-41.49450853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -126.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134268"},
        {"Hipparcos Number", "HIP 74244"},
        {"Geneva Identification System", "GEN# +1.00134268"},
        {"Smithsonian Astrophysical Observation", "SAO 225505"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.58888059),
        dec: Angle.Degrees(-41.49418263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134874"},
        {"Hipparcos Number", "HIP 74519"},
        {"Celescope Catalog", "CEL 4352"},
        {"Geneva Identification System", "GEN# +1.00134874"},
        {"Renson", "Renson 38270"},
        {"Smithsonian Astrophysical Observation", "SAO 225551"},
    },
    visualMagnitude: 7.67,
    bvColour: -0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.41371547),
        dec: Angle.Degrees(-41.49382993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8651"},
        {"Hipparcos Number", "HIP 6592"},
        {"Fundamental Katalog 5th Edition", "FK5 2095"},
        {"Geneva Identification System", "GEN# +1.00008651"},
        {"Smithsonian Astrophysical Observation", "SAO 215492"},
        {"Wilson Evans Batten Catalogue", "WEB 1445"},
    },
    visualMagnitude: 5.42,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.16988858),
        dec: Angle.Degrees(-41.49245885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135345"},
        {"Henry Draper 2", "HD 135346"},
        {"Hipparcos Number", "HIP 74707"},
        {"Celescope Catalog", "CEL 4357"},
        {"Geneva Identification System", "GEN# +1.00135345"},
        {"Geneva Identification System 2", "GEN# +1.00135346"},
        {"Smithsonian Astrophysical Observation", "SAO 225600"},
        {"Wilson Evans Batten Catalogue", "WEB 12746"},
    },
    visualMagnitude: 5.15,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.01679847),
        dec: Angle.Degrees(-41.49114318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47266"},
        {"Hipparcos Number", "HIP 31491"},
        {"Smithsonian Astrophysical Observation", "SAO 218045"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.93595815),
        dec: Angle.Degrees(-41.48983512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216054"},
        {"Hipparcos Number", "HIP 112763"},
        {"Cincinnati Publication", "Ci 20 1383"},
        {"Geneva Identification System", "GEN# +1.00216054"},
        {"Smithsonian Astrophysical Observation", "SAO 231323"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.741,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.54505133),
        dec: Angle.Degrees(-41.48959849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -365.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -209.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224850"},
        {"Hipparcos Number", "HIP 102"},
        {"Geneva Identification System", "GEN# +1.00224850"},
        {"Smithsonian Astrophysical Observation", "SAO 231898"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.32043200),
        dec: Angle.Degrees(-41.48735570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163745"},
        {"Hipparcos Number", "HIP 88109"},
        {"Geneva Identification System", "GEN# +1.00163745"},
        {"Smithsonian Astrophysical Observation", "SAO 228606"},
    },
    visualMagnitude: 6.51,
    bvColour: -0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.92020230),
        dec: Angle.Degrees(-41.48704539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6767"},
        {"Hipparcos Number", "HIP 5300"},
        {"Fundamental Katalog 5th Edition", "FK5 1031"},
        {"Geneva Identification System", "GEN# +1.00006767J"},
        {"Smithsonian Astrophysical Observation", "SAO 215374"},
        {"Wilson Evans Batten Catalogue", "WEB 1134"},
    },
    visualMagnitude: 5.21,
    bvColour: 0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.94927201),
        dec: Angle.Degrees(-41.48693516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26364"},
        {"Hipparcos Number", "HIP 19311"},
        {"Smithsonian Astrophysical Observation", "SAO 216662"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.729,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.09588616),
        dec: Angle.Degrees(-41.48234050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10238"},
        {"Hipparcos Number", "HIP 7714"},
        {"Geneva Identification System", "GEN# +1.00010238"},
        {"Smithsonian Astrophysical Observation", "SAO 215602"},
    },
    visualMagnitude: 10.32,
    bvColour: -0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.82399560),
        dec: Angle.Degrees(-41.48124551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217842"},
        {"Hipparcos Number", "HIP 113902"},
        {"Geneva Identification System", "GEN# +1.00217842"},
        {"Smithsonian Astrophysical Observation", "SAO 231419"},
    },
    visualMagnitude: 5.79,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.99845700),
        dec: Angle.Degrees(-41.47903194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192394"},
        {"Hipparcos Number", "HIP 99907"},
        {"Smithsonian Astrophysical Observation", "SAO 230127"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.06184687),
        dec: Angle.Degrees(-41.47849600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28824"},
        {"Hipparcos Number", "HIP 21043"},
        {"Fundamental Katalog 5th Edition", "FK5 4409"},
        {"Smithsonian Astrophysical Observation", "SAO 216846"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.67152258),
        dec: Angle.Degrees(-41.47689635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61076"},
        {"Hipparcos Number", "HIP 36938"},
        {"Smithsonian Astrophysical Observation", "SAO 218822"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.89938957),
        dec: Angle.Degrees(-41.47544950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155604"},
        {"Hipparcos Number", "HIP 84334"},
        {"Smithsonian Astrophysical Observation", "SAO 227736"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.62507138),
        dec: Angle.Degrees(-41.47348125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24936"},
        {"Hipparcos Number", "HIP 18407"},
        {"Smithsonian Astrophysical Observation", "SAO 216557"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.03212424),
        dec: Angle.Degrees(-41.47236130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80542"},
        {"Hipparcos Number", "HIP 45705"},
        {"Geneva Identification System", "GEN# +1.00080542"},
        {"Smithsonian Astrophysical Observation", "SAO 221055"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.76847111),
        dec: Angle.Degrees(-41.46822391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62739"},
        {"Hipparcos Number", "HIP 37659"},
        {"Smithsonian Astrophysical Observation", "SAO 218931"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.91270189),
        dec: Angle.Degrees(-41.46767343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49558"},
        {"Hipparcos Number", "HIP 32502"},
        {"Smithsonian Astrophysical Observation", "SAO 218187"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.74903302),
        dec: Angle.Degrees(-41.46671525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30831"},
        {"Hipparcos Number", "HIP 22377"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.25987598),
        dec: Angle.Degrees(-41.46609658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -129.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77364",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77364"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.88806089),
        dec: Angle.Degrees(-41.46606865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69126"},
        {"Hipparcos Number", "HIP 40300"},
        {"Smithsonian Astrophysical Observation", "SAO 219628"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.44429302),
        dec: Angle.Degrees(-41.46589719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93385"},
        {"Hipparcos Number", "HIP 52676"},
        {"Geneva Identification System", "GEN# +1.00093385"},
        {"Smithsonian Astrophysical Observation", "SAO 222310"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.56313871),
        dec: Angle.Degrees(-41.46423656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67922",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67922"},
    },
    visualMagnitude: 11.26,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.66342718),
        dec: Angle.Degrees(-41.46273110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134928"},
        {"Hipparcos Number", "HIP 74549"},
        {"Geneva Identification System", "GEN# +1.00134928A"},
        {"Smithsonian Astrophysical Observation", "SAO 225555"},
        {"Wilson Evans Batten Catalogue", "WEB 12721"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.49577749),
        dec: Angle.Degrees(-41.46238999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -270.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -238.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180804"},
        {"Hipparcos Number", "HIP 94989"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.93117566),
        dec: Angle.Degrees(-41.46086178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122757"},
        {"Hipparcos Number", "HIP 68786"},
        {"Smithsonian Astrophysical Observation", "SAO 224659"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.19277626),
        dec: Angle.Degrees(-41.46071670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120735"},
        {"Hipparcos Number", "HIP 67704"},
        {"Smithsonian Astrophysical Observation", "SAO 224500"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.03273798),
        dec: Angle.Degrees(-41.45923484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184732"},
        {"Hipparcos Number", "HIP 96545"},
        {"Smithsonian Astrophysical Observation", "SAO 229780"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.41408529),
        dec: Angle.Degrees(-41.45819265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134929"},
        {"Hipparcos Number", "HIP 74550"},
        {"Geneva Identification System", "GEN# +1.00134929"},
        {"Smithsonian Astrophysical Observation", "SAO 225556"},
        {"Wilson Evans Batten Catalogue", "WEB 12722"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.833,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.49648197),
        dec: Angle.Degrees(-41.45773011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -280.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -242.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151683"},
        {"Hipparcos Number", "HIP 82424"},
        {"Geneva Identification System", "GEN# +1.00151683"},
        {"Smithsonian Astrophysical Observation", "SAO 227294"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.67503288),
        dec: Angle.Degrees(-41.45656684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51622",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51622"},
        {"Geneva Identification System", "GEN# -0.04006102"},
    },
    visualMagnitude: 11.11,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.19834217),
        dec: Angle.Degrees(-41.45557580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96600"},
        {"Hipparcos Number", "HIP 54355"},
        {"Smithsonian Astrophysical Observation", "SAO 222579"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.80348132),
        dec: Angle.Degrees(-41.45552979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158685"},
        {"Hipparcos Number", "HIP 85848"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.14789449),
        dec: Angle.Degrees(-41.45448672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78618",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78618"},
    },
    visualMagnitude: 11.79,
    bvColour: 1.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.75010738),
        dec: Angle.Degrees(-41.45275100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84903"},
        {"Hipparcos Number", "HIP 48019"},
        {"Geneva Identification System", "GEN# +1.00084903"},
        {"Smithsonian Astrophysical Observation", "SAO 221490"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.83007126),
        dec: Angle.Degrees(-41.45115594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54353",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54353"},
        {"Smithsonian Astrophysical Observation", "SAO 222578"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)07, 12.2700),
        dec: Angle.DegreesMinutesSeconds((int)-41, (int)26, 59.500)
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
    primaryId: "HIP 93322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176103"},
        {"Hipparcos Number", "HIP 93322"},
        {"Smithsonian Astrophysical Observation", "SAO 229433"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.11637079),
        dec: Angle.Degrees(-41.44748971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119937"},
        {"Hipparcos Number", "HIP 67259"},
        {"Smithsonian Astrophysical Observation", "SAO 224418"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.79087671),
        dec: Angle.Degrees(-41.44415678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -181.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161841"},
        {"Hipparcos Number", "HIP 87257"},
        {"Celescope Catalog", "CEL 4572"},
        {"Geneva Identification System", "GEN# +1.00161841"},
        {"Renson", "Renson 45680"},
        {"Smithsonian Astrophysical Observation", "SAO 228459"},
    },
    visualMagnitude: 7.57,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.44540556),
        dec: Angle.Degrees(-41.44232631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161931"},
        {"Hipparcos Number", "HIP 87298"},
        {"Smithsonian Astrophysical Observation", "SAO 228467"},
    },
    visualMagnitude: 8.34,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.56329006),
        dec: Angle.Degrees(-41.44166791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117441"},
        {"Hipparcos Number", "HIP 65932"},
        {"Smithsonian Astrophysical Observation", "SAO 224210"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.74678813),
        dec: Angle.Degrees(-41.44154593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33114"},
        {"Hipparcos Number", "HIP 23731"},
        {"Smithsonian Astrophysical Observation", "SAO 217176"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.52916976),
        dec: Angle.Degrees(-41.44148202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220261"},
        {"Hipparcos Number", "HIP 115399"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.65395449),
        dec: Angle.Degrees(-41.44136198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80775"},
        {"Hipparcos Number", "HIP 45800"},
        {"Smithsonian Astrophysical Observation", "SAO 221076"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.07882576),
        dec: Angle.Degrees(-41.44077478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212387"},
        {"Hipparcos Number", "HIP 110632"},
        {"Smithsonian Astrophysical Observation", "SAO 231124"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.16856889),
        dec: Angle.Degrees(-41.44049816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212386"},
        {"Hipparcos Number", "HIP 110629"},
        {"Geneva Identification System", "GEN# +1.00212386"},
        {"Smithsonian Astrophysical Observation", "SAO 231123"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.16295992),
        dec: Angle.Degrees(-41.44025544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 144.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172283"},
        {"Hipparcos Number", "HIP 91631"},
        {"Geneva Identification System", "GEN# +1.00172283"},
        {"Smithsonian Astrophysical Observation", "SAO 229193"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.30921642),
        dec: Angle.Degrees(-41.43989275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171966"},
        {"Hipparcos Number", "HIP 91481"},
        {"Smithsonian Astrophysical Observation", "SAO 229170"},
    },
    visualMagnitude: 8.87,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.86689965),
        dec: Angle.Degrees(-41.43958028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224338"},
        {"Hipparcos Number", "HIP 118074"},
        {"Smithsonian Astrophysical Observation", "SAO 231861"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.27733978),
        dec: Angle.Degrees(-41.43878687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172914"},
        {"Hipparcos Number", "HIP 91956"},
        {"Geneva Identification System", "GEN# +1.00172914"},
        {"Smithsonian Astrophysical Observation", "SAO 229241"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.16430192),
        dec: Angle.Degrees(-41.43521056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83612"},
        {"Hipparcos Number", "HIP 47326"},
        {"Smithsonian Astrophysical Observation", "SAO 221361"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.64983490),
        dec: Angle.Degrees(-41.43506782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43599",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43599"},
    },
    visualMagnitude: 10.55,
    bvColour: 0.745,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.19734476),
        dec: Angle.Degrees(-41.43455110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213333"},
        {"Hipparcos Number", "HIP 111183"},
        {"Smithsonian Astrophysical Observation", "SAO 231179"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.84941721),
        dec: Angle.Degrees(-41.43312329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165000"},
        {"Hipparcos Number", "HIP 88628"},
        {"Geneva Identification System", "GEN# +1.00165000"},
        {"Smithsonian Astrophysical Observation", "SAO 228690"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.43390763),
        dec: Angle.Degrees(-41.43180603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130490"},
        {"Hipparcos Number", "HIP 72539"},
        {"Smithsonian Astrophysical Observation", "SAO 225217"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.46227416),
        dec: Angle.Degrees(-41.43142835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76128"},
        {"Hipparcos Number", "HIP 43601"},
        {"Fundamental Katalog 5th Edition", "FK5 4794"},
        {"Smithsonian Astrophysical Observation", "SAO 220607"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.19902530),
        dec: Angle.Degrees(-41.43037411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211847"},
        {"Hipparcos Number", "HIP 110340"},
        {"Geneva Identification System", "GEN# +1.00211847"},
        {"Smithsonian Astrophysical Observation", "SAO 231092"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.23206764),
        dec: Angle.Degrees(-41.43013541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50078"},
        {"Hipparcos Number", "HIP 32718"},
        {"Geneva Identification System", "GEN# +1.00050078"},
        {"Smithsonian Astrophysical Observation", "SAO 218227"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.39003903),
        dec: Angle.Degrees(-41.42928511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 110.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 323468"},
        {"Hipparcos Number", "HIP 85293"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.43423697),
        dec: Angle.Degrees(-41.42922278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93641",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93641"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.03163797),
        dec: Angle.Degrees(-41.42830465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74883"},
        {"Hipparcos Number", "HIP 42939"},
        {"Celescope Catalog", "CEL 2855"},
        {"Geneva Identification System", "GEN# +1.00074883"},
        {"Smithsonian Astrophysical Observation", "SAO 220393"},
    },
    visualMagnitude: 8.78,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.29303788),
        dec: Angle.Degrees(-41.42723496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109241"},
        {"Hipparcos Number", "HIP 61280"},
        {"Geneva Identification System", "GEN# +1.00109241"},
        {"Renson", "Renson 31670"},
        {"Smithsonian Astrophysical Observation", "SAO 223511"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.37016294),
        dec: Angle.Degrees(-41.41403465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85045"},
        {"Hipparcos Number", "HIP 48085"},
        {"Smithsonian Astrophysical Observation", "SAO 221498"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.04964366),
        dec: Angle.Degrees(-41.42713512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56410"},
        {"Hipparcos Number", "HIP 35054"},
        {"Geneva Identification System", "GEN# +1.00056410"},
        {"Smithsonian Astrophysical Observation", "SAO 218568"},
        {"Wilson Evans Batten Catalogue", "WEB 7010"},
    },
    visualMagnitude: 5.95,
    bvColour: -0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.73812657),
        dec: Angle.Degrees(-41.42641755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78705"},
        {"Hipparcos Number", "HIP 44850"},
        {"Smithsonian Astrophysical Observation", "SAO 220885"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.07079379),
        dec: Angle.Degrees(-41.42599935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122532"},
        {"Hipparcos Number", "HIP 68673"},
        {"Fundamental Katalog 5th Edition", "FK5 1364"},
        {"Geneva Identification System", "GEN# +1.00122532"},
        {"Renson", "Renson 35150"},
        {"Smithsonian Astrophysical Observation", "SAO 224641"},
        {"Wilson Evans Batten Catalogue", "WEB 12021"},
    },
    visualMagnitude: 6.08,
    bvColour: -0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.86455937),
        dec: Angle.Degrees(-41.42330453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184213"},
        {"Hipparcos Number", "HIP 96336"},
        {"Smithsonian Astrophysical Observation", "SAO 229753"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.79288021),
        dec: Angle.Degrees(-41.42326860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103365"},
        {"Hipparcos Number", "HIP 58020"},
        {"Smithsonian Astrophysical Observation", "SAO 223095"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.50799503),
        dec: Angle.Degrees(-41.42202844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135760"},
        {"Hipparcos Number", "HIP 74890"},
        {"Smithsonian Astrophysical Observation", "SAO 225633"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.57260420),
        dec: Angle.Degrees(-41.42027542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -123.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217871"},
        {"Hipparcos Number", "HIP 113924"},
        {"Smithsonian Astrophysical Observation", "SAO 231422"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.05096292),
        dec: Angle.Degrees(-41.42026316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114473"},
        {"Hipparcos Number", "HIP 64337"},
        {"Smithsonian Astrophysical Observation", "SAO 223965"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.81677006),
        dec: Angle.Degrees(-41.41969783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176168"},
        {"Hipparcos Number", "HIP 93346"},
        {"Geneva Identification System", "GEN# +1.00176168"},
        {"Smithsonian Astrophysical Observation", "SAO 229435"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.19648501),
        dec: Angle.Degrees(-41.41787487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189631"},
        {"Hipparcos Number", "HIP 98689"},
        {"Geneva Identification System", "GEN# +1.00189631"},
        {"Smithsonian Astrophysical Observation", "SAO 230007"},
        {"Wilson Evans Batten Catalogue", "WEB 17471"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.66999229),
        dec: Angle.Degrees(-41.41777847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204368"},
        {"Hipparcos Number", "HIP 106077"},
        {"Smithsonian Astrophysical Observation", "SAO 230708"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.30773712),
        dec: Angle.Degrees(-41.41590283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69020"},
        {"Hipparcos Number", "HIP 40264"},
        {"Smithsonian Astrophysical Observation", "SAO 219619"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.34127442),
        dec: Angle.Degrees(-41.41423305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164272"},
        {"Hipparcos Number", "HIP 88320"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.56461586),
        dec: Angle.Degrees(-41.41416567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215104"},
        {"Hipparcos Number", "HIP 112203"},
        {"Fundamental Katalog 5th Edition", "FK5 3818"},
        {"Geneva Identification System", "GEN# +1.00215104"},
        {"Smithsonian Astrophysical Observation", "SAO 231265"},
        {"Wilson Evans Batten Catalogue", "WEB 20022"},
    },
    visualMagnitude: 4.84,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.87486957),
        dec: Angle.Degrees(-41.41411843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207765"},
        {"Hipparcos Number", "HIP 107963"},
        {"Fundamental Katalog 5th Edition", "FK5 3746"},
        {"Smithsonian Astrophysical Observation", "SAO 230875"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.08946574),
        dec: Angle.Degrees(-41.41260573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214790"},
        {"Hipparcos Number", "HIP 112001"},
        {"Smithsonian Astrophysical Observation", "SAO 231250"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.767,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.29414226),
        dec: Angle.Degrees(-41.41146236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 139.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103248",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103248"},
        {"Geneva Identification System", "GEN# -0.04114294"},
        {"Smithsonian Astrophysical Observation", "SAO 230436"},
    },
    visualMagnitude: 9.57,
    bvColour: -0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.75957066),
        dec: Angle.Degrees(-41.41094891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74841"},
        {"Hipparcos Number", "HIP 42925"},
        {"Smithsonian Astrophysical Observation", "SAO 220384"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.21891959),
        dec: Angle.Degrees(-41.40793624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153105"},
        {"Hipparcos Number", "HIP 83132"},
        {"Geneva Identification System", "GEN# +1.00153105"},
        {"Smithsonian Astrophysical Observation", "SAO 227527"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.83317709),
        dec: Angle.Degrees(-41.40516656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164155"},
        {"Hipparcos Number", "HIP 88293"},
        {"Smithsonian Astrophysical Observation", "SAO 228633"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.45090641),
        dec: Angle.Degrees(-41.40513690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95336"},
        {"Hipparcos Number", "HIP 53760"},
        {"Smithsonian Astrophysical Observation", "SAO 222482"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.98637637),
        dec: Angle.Degrees(-41.40499575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108727"},
        {"Hipparcos Number", "HIP 60961"},
        {"Smithsonian Astrophysical Observation", "SAO 223465"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.45185719),
        dec: Angle.Degrees(-41.40239641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224097"},
        {"Hipparcos Number", "HIP 117922"},
        {"Smithsonian Astrophysical Observation", "SAO 231845"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.77118673),
        dec: Angle.Degrees(-41.40154933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119250"},
        {"Hipparcos Number", "HIP 66924"},
        {"Geneva Identification System", "GEN# +1.00119250"},
        {"Smithsonian Astrophysical Observation", "SAO 224359"},
    },
    visualMagnitude: 5.96,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.72942795),
        dec: Angle.Degrees(-41.40095140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 324642"},
        {"Hipparcos Number", "HIP 87755"},
    },
    visualMagnitude: 10.73,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.87892124),
        dec: Angle.Degrees(-41.40051584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -191.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194876"},
        {"Hipparcos Number", "HIP 101094"},
        {"Geneva Identification System", "GEN# +1.00194876"},
        {"Smithsonian Astrophysical Observation", "SAO 230239"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.39588562),
        dec: Angle.Degrees(-41.39974592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99334"},
        {"Hipparcos Number", "HIP 55760"},
        {"Geneva Identification System", "GEN# +1.00099334"},
        {"Smithsonian Astrophysical Observation", "SAO 222784"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.38109458),
        dec: Angle.Degrees(-41.39788455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129015"},
        {"Hipparcos Number", "HIP 71818"},
        {"Smithsonian Astrophysical Observation", "SAO 225122"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.36737230),
        dec: Angle.Degrees(-41.39787652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202175"},
        {"Hipparcos Number", "HIP 104942"},
        {"Smithsonian Astrophysical Observation", "SAO 230600"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.86813181),
        dec: Angle.Degrees(-41.39575541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68264",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68264"},
        {"Smithsonian Astrophysical Observation", "SAO 224584"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.61605314),
        dec: Angle.Degrees(-41.39566122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114022"},
        {"Hipparcos Number", "HIP 64102"},
        {"Smithsonian Astrophysical Observation", "SAO 223924"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.05158628),
        dec: Angle.Degrees(-41.39472090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127548"},
        {"Hipparcos Number", "HIP 71157"},
        {"Smithsonian Astrophysical Observation", "SAO 225013"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.30270922),
        dec: Angle.Degrees(-41.39281883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18055"},
        {"Hipparcos Number", "HIP 13414"},
        {"Smithsonian Astrophysical Observation", "SAO 216081"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.18142033),
        dec: Angle.Degrees(-41.39199816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209084"},
        {"Hipparcos Number", "HIP 108751"},
        {"Smithsonian Astrophysical Observation", "SAO 230948"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.45082422),
        dec: Angle.Degrees(-41.39113420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98175"},
        {"Hipparcos Number", "HIP 55126"},
        {"Geneva Identification System", "GEN# +1.00098175"},
        {"Renson", "Renson 28330"},
        {"Smithsonian Astrophysical Observation", "SAO 222694"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.29451930),
        dec: Angle.Degrees(-41.39053680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -119.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2749"},
        {"Hipparcos Number", "HIP 2417"},
        {"Smithsonian Astrophysical Observation", "SAO 215123"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.70440873),
        dec: Angle.Degrees(-41.39014399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26928"},
        {"Hipparcos Number", "HIP 19724"},
        {"Smithsonian Astrophysical Observation", "SAO 216706"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.40800860),
        dec: Angle.Degrees(-41.38884605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 324639"},
        {"Hipparcos Number", "HIP 87977"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.56905740),
        dec: Angle.Degrees(-41.38851644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14575"},
        {"Hipparcos Number", "HIP 10896"},
        {"Smithsonian Astrophysical Observation", "SAO 215865"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.06085617),
        dec: Angle.Degrees(-41.38812351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67113",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67113"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.33620261),
        dec: Angle.Degrees(-41.38752159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13361"},
        {"Hipparcos Number", "HIP 10061"},
        {"Geneva Identification System", "GEN# +1.00013361"},
        {"Smithsonian Astrophysical Observation", "SAO 215787"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.37572214),
        dec: Angle.Degrees(-41.38738440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212411"},
        {"Hipparcos Number", "HIP 110646"},
        {"Smithsonian Astrophysical Observation", "SAO 231126"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.21607797),
        dec: Angle.Degrees(-41.38729120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107998B"},
        {"Hipparcos Number", "HIP 60548"},
        {"Smithsonian Astrophysical Observation", "SAO 223416"},
    },
    visualMagnitude: 8.90,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.18480446),
        dec: Angle.Degrees(-41.38657057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62738"},
        {"Hipparcos Number", "HIP 37668"},
        {"Celescope Catalog", "CEL 2001"},
        {"Renson", "Renson 17274"},
        {"Smithsonian Astrophysical Observation", "SAO 218934"},
    },
    visualMagnitude: 8.73,
    bvColour: -0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.93078650),
        dec: Angle.Degrees(-41.38594742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200702"},
        {"Hipparcos Number", "HIP 104177"},
        {"Fundamental Katalog 5th Edition", "FK5 3684"},
        {"Geneva Identification System", "GEN# +1.00200702"},
        {"Smithsonian Astrophysical Observation", "SAO 230523"},
        {"Wilson Evans Batten Catalogue", "WEB 18973"},
    },
    visualMagnitude: 5.55,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.60623928),
        dec: Angle.Degrees(-41.38593603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68795",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68795"},
    },
    visualMagnitude: 10.80,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.23835300),
        dec: Angle.Degrees(-40.93351942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200733"},
        {"Hipparcos Number", "HIP 104195"},
        {"Fundamental Katalog 5th Edition", "FK5 5857"},
        {"Geneva Identification System", "GEN# +1.00200733"},
        {"Smithsonian Astrophysical Observation", "SAO 230526"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.65379514),
        dec: Angle.Degrees(-41.38452627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107998"},
        {"Hipparcos Number", "HIP 60549"},
        {"Smithsonian Astrophysical Observation", "SAO 223417"},
    },
    visualMagnitude: 6.24,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.18654487),
        dec: Angle.Degrees(-41.38411951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2405"},
        {"Hipparcos Number", "HIP 2185"},
        {"Geneva Identification System", "GEN# +1.00002405"},
        {"Smithsonian Astrophysical Observation", "SAO 215101"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.90674184),
        dec: Angle.Degrees(-41.38208761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52756"},
        {"Hipparcos Number", "HIP 33736"},
        {"Geneva Identification System", "GEN# +1.00052756"},
        {"Smithsonian Astrophysical Observation", "SAO 218379"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.899,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.12318748),
        dec: Angle.Degrees(-41.38033117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 216.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20200"},
        {"Hipparcos Number", "HIP 14995"},
        {"Smithsonian Astrophysical Observation", "SAO 216215"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.31569549),
        dec: Angle.Degrees(-41.37981449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210918"},
        {"Hipparcos Number", "HIP 109821"},
        {"Cincinnati Publication", "Ci 20 1347"},
        {"Geneva Identification System", "GEN# +1.00210918"},
        {"Smithsonian Astrophysical Observation", "SAO 231045"},
        {"Wilson Evans Batten Catalogue", "WEB 19723"},
    },
    visualMagnitude: 6.23,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.65920556),
        dec: Angle.Degrees(-41.37974331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 570.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -791.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161877"},
        {"Hipparcos Number", "HIP 87277"},
        {"Celescope Catalog", "CEL 4573"},
        {"Geneva Identification System", "GEN# +1.00161877"},
        {"Smithsonian Astrophysical Observation", "SAO 228462"},
    },
    visualMagnitude: 7.94,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.49535734),
        dec: Angle.Degrees(-41.37954060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78956"},
        {"Hipparcos Number", "HIP 44980"},
        {"Smithsonian Astrophysical Observation", "SAO 220906"},
    },
    visualMagnitude: 9.06,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.43894768),
        dec: Angle.Degrees(-41.37811110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23471"},
        {"Hipparcos Number", "HIP 17411"},
        {"Smithsonian Astrophysical Observation", "SAO 216457"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.94927995),
        dec: Angle.Degrees(-41.37028976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21899"},
        {"Hipparcos Number", "HIP 16310"},
        {"Fundamental Katalog 5th Edition", "FK5 2248"},
        {"Geneva Identification System", "GEN# +1.00021899"},
        {"Smithsonian Astrophysical Observation", "SAO 216350"},
        {"Wilson Evans Batten Catalogue", "WEB 3112"},
    },
    visualMagnitude: 6.12,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.55661496),
        dec: Angle.Degrees(-41.36951768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -172.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6533"},
        {"Hipparcos Number", "HIP 5130"},
        {"Geneva Identification System", "GEN# +1.00006533"},
        {"Smithsonian Astrophysical Observation", "SAO 215359"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.41738988),
        dec: Angle.Degrees(-41.36939522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130877"},
        {"Hipparcos Number", "HIP 72714"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.99686125),
        dec: Angle.Degrees(-41.36884409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15322"},
        {"Hipparcos Number", "HIP 11393"},
        {"Smithsonian Astrophysical Observation", "SAO 215904"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.69339500),
        dec: Angle.Degrees(-41.36686977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110859"},
        {"Hipparcos Number", "HIP 62242"},
        {"Fundamental Katalog 5th Edition", "FK5 5130"},
        {"Smithsonian Astrophysical Observation", "SAO 223645"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.34906735),
        dec: Angle.Degrees(-41.36572692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7143"},
        {"Hipparcos Number", "HIP 5548"},
        {"Smithsonian Astrophysical Observation", "SAO 215400"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.78978505),
        dec: Angle.Degrees(-41.36571720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131435"},
        {"Hipparcos Number", "HIP 72986"},
        {"Geneva Identification System", "GEN# +1.00131435"},
        {"Smithsonian Astrophysical Observation", "SAO 225289"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.72878637),
        dec: Angle.Degrees(-41.36456081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -136.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15783",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15783"},
        {"Smithsonian Astrophysical Observation", "SAO 216291"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.85173115),
        dec: Angle.Degrees(-41.36412469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15612"},
        {"Hipparcos Number", "HIP 11596"},
        {"Smithsonian Astrophysical Observation", "SAO 215919"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.822,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.37487671),
        dec: Angle.Degrees(-41.36360193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 211.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107249"},
        {"Hipparcos Number", "HIP 60138"},
        {"Smithsonian Astrophysical Observation", "SAO 223357"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.99233107),
        dec: Angle.Degrees(-41.35966452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86630"},
        {"Hipparcos Number", "HIP 48919"},
        {"Geneva Identification System", "GEN# +1.00086630"},
        {"Smithsonian Astrophysical Observation", "SAO 221656"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.68839209),
        dec: Angle.Degrees(-41.35953493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166114"},
        {"Hipparcos Number", "HIP 89099"},
        {"Fundamental Katalog 5th Edition", "FK5 3444"},
        {"Geneva Identification System", "GEN# +1.00166114"},
        {"Smithsonian Astrophysical Observation", "SAO 228778"},
        {"Wilson Evans Batten Catalogue", "WEB 15126"},
    },
    visualMagnitude: 5.86,
    bvColour: 0.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.77306755),
        dec: Angle.Degrees(-41.35902019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203088"},
        {"Hipparcos Number", "HIP 105427"},
        {"Smithsonian Astrophysical Observation", "SAO 230646"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.33223697),
        dec: Angle.Degrees(-41.35492325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188243"},
        {"Hipparcos Number", "HIP 98081"},
        {"Smithsonian Astrophysical Observation", "SAO 229931"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.99684586),
        dec: Angle.Degrees(-41.35253418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14055",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14055"},
        {"Smithsonian Astrophysical Observation", "SAO 216136"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.26598309),
        dec: Angle.Degrees(-41.35152153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76872"},
        {"Hipparcos Number", "HIP 44002"},
        {"Celescope Catalog", "CEL 3105"},
        {"Smithsonian Astrophysical Observation", "SAO 220697"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.39644435),
        dec: Angle.Degrees(-41.35103021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80854"},
        {"Hipparcos Number", "HIP 45843"},
        {"Smithsonian Astrophysical Observation", "SAO 221086"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.19659333),
        dec: Angle.Degrees(-41.35099273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175218"},
        {"Hipparcos Number", "HIP 92947"},
        {"Smithsonian Astrophysical Observation", "SAO 229382"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.05787245),
        dec: Angle.Degrees(-41.34958692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128616"},
        {"Hipparcos Number", "HIP 71637"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.744,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.78828160),
        dec: Angle.Degrees(-41.34941531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56440",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56440"},
    },
    visualMagnitude: 11.27,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.57470456),
        dec: Angle.Degrees(-41.34929056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119416"},
        {"Hipparcos Number", "HIP 67009"},
        {"Smithsonian Astrophysical Observation", "SAO 224374"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.98909447),
        dec: Angle.Degrees(-41.34890051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211088"},
        {"Hipparcos Number", "HIP 109908"},
        {"Fundamental Katalog 5th Edition", "FK5 3777"},
        {"Geneva Identification System", "GEN# +1.00211088"},
        {"Smithsonian Astrophysical Observation", "SAO 231055"},
        {"Wilson Evans Batten Catalogue", "WEB 19731"},
    },
    visualMagnitude: 4.79,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.90368669),
        dec: Angle.Degrees(-41.34675029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168256"},
        {"Hipparcos Number", "HIP 89906"},
        {"Geneva Identification System", "GEN# +1.00168256"},
        {"Smithsonian Astrophysical Observation", "SAO 228936"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.919,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.18805716),
        dec: Angle.Degrees(-41.34637624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89042"},
        {"Hipparcos Number", "HIP 50237"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.85629916),
        dec: Angle.Degrees(-41.34504739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5272"},
        {"Hipparcos Number", "HIP 4230"},
        {"Smithsonian Astrophysical Observation", "SAO 215282"},
    },
    visualMagnitude: 9.53,
    bvColour: 1.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.49054962),
        dec: Angle.Degrees(-41.34496000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39997"},
        {"Hipparcos Number", "HIP 27891"},
        {"Geneva Identification System", "GEN# +1.00039997"},
        {"Smithsonian Astrophysical Observation", "SAO 217608"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.52670071),
        dec: Angle.Degrees(-41.34406233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25004"},
        {"Hipparcos Number", "HIP 18450"},
        {"Geneva Identification System", "GEN# +1.00025004"},
        {"Smithsonian Astrophysical Observation", "SAO 216565"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.15138561),
        dec: Angle.Degrees(-41.34379460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 91.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128066"},
        {"Hipparcos Number", "HIP 71399"},
        {"Geneva Identification System", "GEN# +1.00128066"},
        {"Smithsonian Astrophysical Observation", "SAO 225053"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.00638572),
        dec: Angle.Degrees(-41.34317135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224387"},
        {"Hipparcos Number", "HIP 118109"},
        {"Smithsonian Astrophysical Observation", "SAO 231867"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.37797022),
        dec: Angle.Degrees(-41.34302309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169183"},
        {"Henry Draper 2", "HD 169051"},
        {"Hipparcos Number", "HIP 90286"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.33157750),
        dec: Angle.Degrees(-41.34177781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 323450"},
        {"Hipparcos Number", "HIP 85206"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.17142164),
        dec: Angle.Degrees(-41.34161157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92057"},
        {"Hipparcos Number", "HIP 51963"},
        {"Smithsonian Astrophysical Observation", "SAO 222194"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.24177461),
        dec: Angle.Degrees(-41.34113214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58825",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58825"},
    },
    visualMagnitude: 9.53,
    bvColour: 1.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.97175344),
        dec: Angle.Degrees(-41.33988214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135877"},
        {"Hipparcos Number", "HIP 74956"},
        {"Geneva Identification System", "GEN# +1.00135877"},
        {"Smithsonian Astrophysical Observation", "SAO 225649"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.75727701),
        dec: Angle.Degrees(-41.33949553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157518"},
        {"Hipparcos Number", "HIP 85284"},
        {"Smithsonian Astrophysical Observation", "SAO 227942"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.39847250),
        dec: Angle.Degrees(-41.33901140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22323"},
        {"Hipparcos Number", "HIP 16638"},
        {"Geneva Identification System", "GEN# +1.00022323"},
        {"Smithsonian Astrophysical Observation", "SAO 216386"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.51847917),
        dec: Angle.Degrees(-41.33871107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35826"},
        {"Hipparcos Number", "HIP 25362"},
        {"Smithsonian Astrophysical Observation", "SAO 217328"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.36910245),
        dec: Angle.Degrees(-41.33850310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19669"},
        {"Hipparcos Number", "HIP 14604"},
        {"Smithsonian Astrophysical Observation", "SAO 216177"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.14177970),
        dec: Angle.Degrees(-41.33800220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40504"},
        {"Hipparcos Number", "HIP 28183"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.32151906),
        dec: Angle.Degrees(-41.33786160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125565"},
        {"Hipparcos Number", "HIP 70171"},
        {"Smithsonian Astrophysical Observation", "SAO 224858"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.34909495),
        dec: Angle.Degrees(-41.33745401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173772"},
        {"Hipparcos Number", "HIP 92310"},
        {"Geneva Identification System", "GEN# +1.00173772"},
        {"Smithsonian Astrophysical Observation", "SAO 229300"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.21391011),
        dec: Angle.Degrees(-41.33694165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166596"},
        {"Hipparcos Number", "HIP 89290"},
        {"Geneva Identification System", "GEN# +1.00166596"},
        {"Renson", "Renson 46900"},
        {"Smithsonian Astrophysical Observation", "SAO 228815"},
        {"Wilson Evans Batten Catalogue", "WEB 15178"},
    },
    visualMagnitude: 5.47,
    bvColour: -0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.30291529),
        dec: Angle.Degrees(-41.33609648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85406"},
        {"Hipparcos Number", "HIP 48274"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.62597656),
        dec: Angle.Degrees(-41.33189492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27432"},
        {"Hipparcos Number", "HIP 20054"},
        {"Smithsonian Astrophysical Observation", "SAO 216736"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.50512353),
        dec: Angle.Degrees(-41.32861897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141762"},
        {"Hipparcos Number", "HIP 77742"},
        {"Geneva Identification System", "GEN# +1.00141762"},
        {"Smithsonian Astrophysical Observation", "SAO 226315"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.08615637),
        dec: Angle.Degrees(-41.32623806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204959"},
        {"Henry Draper 2", "HD 204959A"},
        {"Hipparcos Number", "HIP 106411"},
    },
    visualMagnitude: 9.70,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.29355658),
        dec: Angle.Degrees(-41.32466571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38537"},
        {"Hipparcos Number", "HIP 27085"},
        {"Smithsonian Astrophysical Observation", "SAO 217504"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.14104923),
        dec: Angle.Degrees(-41.32415922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93435"},
        {"Hipparcos Number", "HIP 52706"},
        {"Geneva Identification System", "GEN# +1.00093435"},
        {"Smithsonian Astrophysical Observation", "SAO 222317"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.808,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.65220397),
        dec: Angle.Degrees(-41.32317360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110593"},
        {"Hipparcos Number", "HIP 62086"},
        {"Geneva Identification System", "GEN# +1.00110593"},
        {"Smithsonian Astrophysical Observation", "SAO 223625"},
        {"Wilson Evans Batten Catalogue", "WEB 11037"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.87676345),
        dec: Angle.Degrees(-41.32180501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26135"},
        {"Hipparcos Number", "HIP 19158"},
        {"Smithsonian Astrophysical Observation", "SAO 216643"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.60591392),
        dec: Angle.Degrees(-41.32151772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30985"},
        {"Hipparcos Number", "HIP 22488"},
        {"Geneva Identification System", "GEN# +1.00030985"},
        {"Smithsonian Astrophysical Observation", "SAO 217032"},
        {"Wilson Evans Batten Catalogue", "WEB 4337"},
    },
    visualMagnitude: 6.06,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.56743031),
        dec: Angle.Degrees(-41.32100968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80188"},
        {"Hipparcos Number", "HIP 45551"},
        {"Smithsonian Astrophysical Observation", "SAO 221025"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.25673382),
        dec: Angle.Degrees(-41.31967170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73526"},
        {"Hipparcos Number", "HIP 42282"},
        {"Geneva Identification System", "GEN# +1.00073526"},
        {"Smithsonian Astrophysical Observation", "SAO 220191"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.31887786),
        dec: Angle.Degrees(-41.31949492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 161.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153616"},
        {"Hipparcos Number", "HIP 83379"},
        {"Smithsonian Astrophysical Observation", "SAO 227570"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.61665950),
        dec: Angle.Degrees(-41.31876703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137778"},
        {"Hipparcos Number", "HIP 75722"},
        {"Cincinnati Publication", "Ci 18 2065"},
        {"Geneva Identification System", "GEN# +1.00137778"},
        {"Smithsonian Astrophysical Observation", "SAO 140552"},
        {"Wilson Evans Batten Catalogue", "WEB 12893"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.868,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.05067543),
        dec: Angle.Degrees(-09.35699504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -355.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21058"},
        {"Hipparcos Number", "HIP 15703"},
        {"Smithsonian Astrophysical Observation", "SAO 216280"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.702,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.56960910),
        dec: Angle.Degrees(-41.31570270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 97.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135913"},
        {"Hipparcos Number", "HIP 74970"},
        {"Geneva Identification System", "GEN# +1.00135913"},
        {"Smithsonian Astrophysical Observation", "SAO 225653"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.80164873),
        dec: Angle.Degrees(-41.31518075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175815"},
        {"Hipparcos Number", "HIP 93193"},
        {"Smithsonian Astrophysical Observation", "SAO 229414"},
    },
    visualMagnitude: 8.38,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.73347667),
        dec: Angle.Degrees(-41.31380586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128286"},
        {"Hipparcos Number", "HIP 71496"},
        {"Smithsonian Astrophysical Observation", "SAO 225064"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.31516922),
        dec: Angle.Degrees(-41.31277441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64549"},
        {"Hipparcos Number", "HIP 38471"},
        {"Smithsonian Astrophysical Observation", "SAO 219098"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.19397424),
        dec: Angle.Degrees(-41.31267215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24058"},
        {"Hipparcos Number", "HIP 17770"},
        {"Geneva Identification System", "GEN# +1.00024058"},
        {"Smithsonian Astrophysical Observation", "SAO 216495"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.06596228),
        dec: Angle.Degrees(-41.31087479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146652"},
        {"Hipparcos Number", "HIP 79944"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.77944719),
        dec: Angle.Degrees(-41.30988469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66624"},
        {"Hipparcos Number", "HIP 39360"},
        {"Celescope Catalog", "CEL 2150"},
        {"Geneva Identification System", "GEN# +1.00066624"},
        {"Renson", "Renson 18410"},
        {"Smithsonian Astrophysical Observation", "SAO 219339"},
        {"Wilson Evans Batten Catalogue", "WEB 7706"},
    },
    visualMagnitude: 5.52,
    bvColour: -0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.68662049),
        dec: Angle.Degrees(-41.30986539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30052"},
        {"Hipparcos Number", "HIP 21887"},
        {"Smithsonian Astrophysical Observation", "SAO 216943"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.57670641),
        dec: Angle.Degrees(-41.30886834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148138"},
        {"Hipparcos Number", "HIP 80629"},
        {"Geneva Identification System", "GEN# +1.00148138"},
        {"Smithsonian Astrophysical Observation", "SAO 226785"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.95401286),
        dec: Angle.Degrees(-41.30826944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9950"},
        {"Hipparcos Number", "HIP 7484"},
        {"Smithsonian Astrophysical Observation", "SAO 215578"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.09640186),
        dec: Angle.Degrees(-41.30795259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111739"},
        {"Hipparcos Number", "HIP 62770"},
        {"Smithsonian Astrophysical Observation", "SAO 223716"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.94097535),
        dec: Angle.Degrees(-41.30758331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208994"},
        {"Hipparcos Number", "HIP 108698"},
        {"Smithsonian Astrophysical Observation", "SAO 230939"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.28820230),
        dec: Angle.Degrees(-41.30649436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123091"},
        {"Hipparcos Number", "HIP 68924"},
        {"Smithsonian Astrophysical Observation", "SAO 224682"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.875,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.65809798),
        dec: Angle.Degrees(-41.30622029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66317",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66317"},
    },
    visualMagnitude: 12.39,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.87706674),
        dec: Angle.Degrees(-41.30568468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45292",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45292"},
        {"Wilson Evans Batten Catalogue", "WEB 8629"},
    },
    visualMagnitude: 11.31,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.45336557),
        dec: Angle.Degrees(-09.31899197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119675"},
        {"Hipparcos Number", "HIP 67119"},
        {"Smithsonian Astrophysical Observation", "SAO 224399"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.34538683),
        dec: Angle.Degrees(-41.30318939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 326463"},
        {"Hipparcos Number", "HIP 83025"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.49516082),
        dec: Angle.Degrees(-41.30022009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16851"},
        {"Hipparcos Number", "HIP 12502"},
        {"Geneva Identification System", "GEN# +1.00016851"},
        {"Smithsonian Astrophysical Observation", "SAO 216002"},
        {"Wilson Evans Batten Catalogue", "WEB 2559"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.21582873),
        dec: Angle.Degrees(-41.29986428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26533",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26533"},
        {"Smithsonian Astrophysical Observation", "SAO 217449"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.738,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.65609388),
        dec: Angle.Degrees(-41.29962077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212685"},
        {"Hipparcos Number", "HIP 110808"},
        {"Smithsonian Astrophysical Observation", "SAO 231142"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.74625482),
        dec: Angle.Degrees(-41.29819061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224748"},
        {"Hipparcos Number", "HIP 27"},
        {"Smithsonian Astrophysical Observation", "SAO 231889"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.08546976),
        dec: Angle.Degrees(-41.29753696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 135.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37718"},
        {"Hipparcos Number", "HIP 26531"},
        {"Geneva Identification System", "GEN# +1.00037718"},
        {"Smithsonian Astrophysical Observation", "SAO 217448"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.65197774),
        dec: Angle.Degrees(-41.29645070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197440"},
        {"Hipparcos Number", "HIP 102417"},
        {"Smithsonian Astrophysical Observation", "SAO 230349"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.30712096),
        dec: Angle.Degrees(-41.29624630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17277"},
        {"Hipparcos Number", "HIP 12842"},
        {"Geneva Identification System", "GEN# +1.00017277"},
        {"Smithsonian Astrophysical Observation", "SAO 216029"},
        {"Wilson Evans Batten Catalogue", "WEB 2611"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.26827880),
        dec: Angle.Degrees(-41.29479593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51994"},
        {"Hipparcos Number", "HIP 33487"},
        {"Smithsonian Astrophysical Observation", "SAO 218337"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.41273713),
        dec: Angle.Degrees(-41.29449945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67906"},
        {"Hipparcos Number", "HIP 39845"},
        {"Geneva Identification System", "GEN# +1.00067906"},
        {"Smithsonian Astrophysical Observation", "SAO 219463"},
    },
    visualMagnitude: 9.10,
    bvColour: -0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.10919579),
        dec: Angle.Degrees(-41.29407184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102383"},
        {"Hipparcos Number", "HIP 57479"},
        {"Smithsonian Astrophysical Observation", "SAO 223025"},
    },
    visualMagnitude: 9.21,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.73404670),
        dec: Angle.Degrees(-41.29278649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122756"},
        {"Hipparcos Number", "HIP 68782"},
        {"Geneva Identification System", "GEN# +1.00122756"},
        {"Smithsonian Astrophysical Observation", "SAO 224657"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.17676157),
        dec: Angle.Degrees(-41.28618439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153157"},
        {"Hipparcos Number", "HIP 83155"},
        {"Smithsonian Astrophysical Observation", "SAO 227531"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.89819597),
        dec: Angle.Degrees(-41.28558836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115279"},
        {"Hipparcos Number", "HIP 64791"},
        {"Smithsonian Astrophysical Observation", "SAO 224025"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.19277386),
        dec: Angle.Degrees(-41.28300203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43418"},
        {"Hipparcos Number", "HIP 29585"},
        {"Smithsonian Astrophysical Observation", "SAO 217792"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.50988671),
        dec: Angle.Degrees(-41.28259750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161346"},
        {"Hipparcos Number", "HIP 87023"},
        {"Fundamental Katalog 5th Edition", "FK5 5560"},
        {"Smithsonian Astrophysical Observation", "SAO 228408"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.72137867),
        dec: Angle.Degrees(-41.28183896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25936"},
        {"Hipparcos Number", "HIP 19035"},
        {"Geneva Identification System", "GEN# +1.00025936"},
        {"Smithsonian Astrophysical Observation", "SAO 216628"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.16447702),
        dec: Angle.Degrees(-41.28148937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23519"},
        {"Hipparcos Number", "HIP 17441"},
        {"Geneva Identification System", "GEN# +1.00023519"},
        {"Smithsonian Astrophysical Observation", "SAO 216460"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.05430575),
        dec: Angle.Degrees(-41.27948076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74804"},
        {"Hipparcos Number", "HIP 42908"},
        {"Celescope Catalog", "CEL 2843"},
        {"Geneva Identification System", "GEN# +5.11970001"},
        {"Smithsonian Astrophysical Observation", "SAO 220381"},
        {"Wilson Evans Batten Catalogue", "WEB 8291"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.16803885),
        dec: Angle.Degrees(-41.27722559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93675"},
        {"Hipparcos Number", "HIP 52843"},
        {"Smithsonian Astrophysical Observation", "SAO 222339"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.07749024),
        dec: Angle.Degrees(-41.27675490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42391"},
        {"Hipparcos Number", "HIP 29122"},
        {"Geneva Identification System", "GEN# +1.00042391"},
        {"Smithsonian Astrophysical Observation", "SAO 217732"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.877,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.11766204),
        dec: Angle.Degrees(-41.27349813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76074",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76074"},
        {"Cincinnati Publication", "Ci 20 934"},
        {"Geneva Identification System", "GEN# -0.04009712"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.05768961),
        dec: Angle.Degrees(-41.27308564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1177.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1028.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176498"},
        {"Hipparcos Number", "HIP 93495"},
        {"Geneva Identification System", "GEN# +1.00176498"},
        {"Smithsonian Astrophysical Observation", "SAO 229451"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.60774372),
        dec: Angle.Degrees(-41.27213171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132960"},
        {"Hipparcos Number", "HIP 73653"},
        {"Celescope Catalog", "CEL 4335"},
        {"Geneva Identification System", "GEN# +1.00132960"},
        {"Smithsonian Astrophysical Observation", "SAO 225404"},
    },
    visualMagnitude: 7.40,
    bvColour: -0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.83697582),
        dec: Angle.Degrees(-41.27152168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20542"},
        {"Hipparcos Number", "HIP 15252"},
        {"Geneva Identification System", "GEN# +1.00020542"},
        {"Smithsonian Astrophysical Observation", "SAO 216239"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.18580844),
        dec: Angle.Degrees(-41.27079073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 324189"},
        {"Hipparcos Number", "HIP 86801"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.06040724),
        dec: Angle.Degrees(-41.27078647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8365",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8365"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.94410266),
        dec: Angle.Degrees(-41.27005699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110098"},
        {"Hipparcos Number", "HIP 61810"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.01466113),
        dec: Angle.Degrees(-41.26988997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8535"},
        {"Hipparcos Number", "HIP 6511"},
        {"Geneva Identification System", "GEN# +1.00008535"},
        {"Smithsonian Astrophysical Observation", "SAO 215484"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.90496208),
        dec: Angle.Degrees(-41.26963005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208016"},
        {"Hipparcos Number", "HIP 108128"},
        {"Smithsonian Astrophysical Observation", "SAO 230895"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.59249685),
        dec: Angle.Degrees(-41.26601408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13742"},
        {"Hipparcos Number", "HIP 10311"},
        {"Smithsonian Astrophysical Observation", "SAO 215817"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.21051956),
        dec: Angle.Degrees(-41.26523348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55348"},
        {"Hipparcos Number", "HIP 34659"},
        {"Smithsonian Astrophysical Observation", "SAO 218505"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.66500496),
        dec: Angle.Degrees(-41.26508417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178146"},
        {"Hipparcos Number", "HIP 94086"},
        {"Smithsonian Astrophysical Observation", "SAO 229522"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.30522359),
        dec: Angle.Degrees(-41.26429799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29509"},
        {"Hipparcos Number", "HIP 21490"},
        {"Smithsonian Astrophysical Observation", "SAO 216895"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.22993774),
        dec: Angle.Degrees(-41.26155210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130133"},
        {"Hipparcos Number", "HIP 72352"},
        {"Geneva Identification System", "GEN# +1.00130133"},
        {"Smithsonian Astrophysical Observation", "SAO 225187"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.92216516),
        dec: Angle.Degrees(-41.25949445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118680"},
        {"Hipparcos Number", "HIP 66604"},
        {"Smithsonian Astrophysical Observation", "SAO 224313"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.79648252),
        dec: Angle.Degrees(-41.25802005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214832"},
        {"Hipparcos Number", "HIP 112023"},
        {"Smithsonian Astrophysical Observation", "SAO 231252"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.35718765),
        dec: Angle.Degrees(-41.25713747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5646"},
        {"Hipparcos Number", "HIP 4493"},
        {"Smithsonian Astrophysical Observation", "SAO 215300"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.39484252),
        dec: Angle.Degrees(-41.25642081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21113"},
        {"Hipparcos Number", "HIP 15752"},
        {"Smithsonian Astrophysical Observation", "SAO 216287"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.73357829),
        dec: Angle.Degrees(-41.25586786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154550"},
        {"Hipparcos Number", "HIP 83843"},
        {"Geneva Identification System", "GEN# +1.00154550"},
        {"Smithsonian Astrophysical Observation", "SAO 227652"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.02154542),
        dec: Angle.Degrees(-41.25569184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4292"},
        {"Hipparcos Number", "HIP 3524"},
        {"Smithsonian Astrophysical Observation", "SAO 215222"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.24550149),
        dec: Angle.Degrees(-41.25568620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7197",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7197"},
    },
    visualMagnitude: 10.48,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.18801163),
        dec: Angle.Degrees(-41.25554189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9526"},
        {"Hipparcos Number", "HIP 7199"},
        {"Smithsonian Astrophysical Observation", "SAO 215549"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.19482379),
        dec: Angle.Degrees(-41.25510189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178226"},
        {"Hipparcos Number", "HIP 94116"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.769,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.38594187),
        dec: Angle.Degrees(-41.25451944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77258"},
        {"Hipparcos Number", "HIP 44191"},
        {"Fundamental Katalog 5th Edition", "FK5 1234"},
        {"Geneva Identification System", "GEN# +1.00077258"},
        {"Renson", "Renson 21810"},
        {"Smithsonian Astrophysical Observation", "SAO 220730"},
        {"Wilson Evans Batten Catalogue", "WEB 8486"},
    },
    visualMagnitude: 4.45,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.02266724),
        dec: Angle.Degrees(-41.25373789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129767"},
        {"Hipparcos Number", "HIP 72169"},
        {"Geneva Identification System", "GEN# +1.00129767"},
        {"Smithsonian Astrophysical Observation", "SAO 225172"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.42401857),
        dec: Angle.Degrees(-41.25273523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63399",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63399"},
    },
    visualMagnitude: 11.71,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.87731214),
        dec: Angle.Degrees(-41.25228390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -361.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18169"},
        {"Hipparcos Number", "HIP 13492"},
        {"Geneva Identification System", "GEN# +1.00018169"},
        {"Smithsonian Astrophysical Observation", "SAO 216084"},
        {"Wilson Evans Batten Catalogue", "WEB 2694"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.43225466),
        dec: Angle.Degrees(-41.25214578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203409"},
        {"Hipparcos Number", "HIP 105590"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.80353884),
        dec: Angle.Degrees(-41.25149387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201369"},
        {"Hipparcos Number", "HIP 104530"},
        {"Smithsonian Astrophysical Observation", "SAO 230558"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.61895758),
        dec: Angle.Degrees(-41.25087173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7884"},
        {"Hipparcos Number", "HIP 6066"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.46193110),
        dec: Angle.Degrees(-41.25047794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -121.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25512"},
        {"Hipparcos Number", "HIP 18775"},
        {"Smithsonian Astrophysical Observation", "SAO 216601"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.33641528),
        dec: Angle.Degrees(-41.25037679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47517"},
        {"Hipparcos Number", "HIP 31620"},
        {"Smithsonian Astrophysical Observation", "SAO 218062"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.26119352),
        dec: Angle.Degrees(-41.24992266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34517"},
        {"Hipparcos Number", "HIP 24559"},
        {"Smithsonian Astrophysical Observation", "SAO 217258"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.04188790),
        dec: Angle.Degrees(-41.24923131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8925"},
        {"Hipparcos Number", "HIP 6781"},
        {"Smithsonian Astrophysical Observation", "SAO 215509"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.80532419),
        dec: Angle.Degrees(-41.24854706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27994"},
        {"Hipparcos Number", "HIP 20479"},
        {"Smithsonian Astrophysical Observation", "SAO 216772"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.84095210),
        dec: Angle.Degrees(-41.24852743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103051"},
        {"Hipparcos Number", "HIP 57847"},
        {"Geneva Identification System", "GEN# +1.00103051"},
        {"Smithsonian Astrophysical Observation", "SAO 223075"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.94575647),
        dec: Angle.Degrees(-41.24745082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222655"},
        {"Hipparcos Number", "HIP 116970"},
        {"Geneva Identification System", "GEN# +1.00222655"},
        {"Smithsonian Astrophysical Observation", "SAO 231748"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.67565424),
        dec: Angle.Degrees(-41.24726487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -124.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147435"},
        {"Hipparcos Number", "HIP 80307"},
        {"Smithsonian Astrophysical Observation", "SAO 226715"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.93858458),
        dec: Angle.Degrees(-41.24708182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107772",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107772"},
    },
    visualMagnitude: 10.56,
    bvColour: 1.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.49989796),
        dec: Angle.Degrees(-41.24560413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -243.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 232.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79153"},
        {"Hipparcos Number", "HIP 45086"},
        {"Smithsonian Astrophysical Observation", "SAO 220927"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.76847869),
        dec: Angle.Degrees(-41.24548997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71857"},
        {"Hipparcos Number", "HIP 41517"},
        {"Celescope Catalog", "CEL 2542"},
        {"Smithsonian Astrophysical Observation", "SAO 219962"},
    },
    visualMagnitude: 7.67,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.00534650),
        dec: Angle.Degrees(-41.24543135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48225"},
        {"Hipparcos Number", "HIP 31937"},
        {"Smithsonian Astrophysical Observation", "SAO 218118"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.10888343),
        dec: Angle.Degrees(-41.24139133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84369"},
        {"Hipparcos Number", "HIP 47724"},
        {"Smithsonian Astrophysical Observation", "SAO 221428"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.93560452),
        dec: Angle.Degrees(-41.24047031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103508"},
        {"Hipparcos Number", "HIP 58101"},
        {"Smithsonian Astrophysical Observation", "SAO 223107"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.74597123),
        dec: Angle.Degrees(-41.23954301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67948"},
        {"Hipparcos Number", "HIP 39862"},
        {"Smithsonian Astrophysical Observation", "SAO 219471"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.14824223),
        dec: Angle.Degrees(-41.23874274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4189",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4189"},
        {"Geneva Identification System", "GEN# +6.20145177"},
    },
    visualMagnitude: 11.92,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.34933515),
        dec: Angle.Degrees(-41.23799485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -198.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74271"},
        {"Hipparcos Number", "HIP 42651"},
        {"Smithsonian Astrophysical Observation", "SAO 220288"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.38811478),
        dec: Angle.Degrees(-41.23745629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17061"},
        {"Hipparcos Number", "HIP 12693"},
        {"Smithsonian Astrophysical Observation", "SAO 216018"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.76280666),
        dec: Angle.Degrees(-41.23721182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126001"},
        {"Hipparcos Number", "HIP 70392"},
        {"Geneva Identification System", "GEN# +1.00126001"},
        {"Smithsonian Astrophysical Observation", "SAO 224895"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.02943079),
        dec: Angle.Degrees(-41.23720810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11064"},
        {"Hipparcos Number", "HIP 8367"},
        {"Smithsonian Astrophysical Observation", "SAO 215656"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.94467713),
        dec: Angle.Degrees(-41.23651917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126799"},
        {"Hipparcos Number", "HIP 70803"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.20184906),
        dec: Angle.Degrees(-41.23514701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109423"},
        {"Hipparcos Number", "HIP 61391"},
        {"Smithsonian Astrophysical Observation", "SAO 223529"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.898,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.70372875),
        dec: Angle.Degrees(-41.23477160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -239.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42699"},
        {"Hipparcos Number", "HIP 29268"},
        {"Smithsonian Astrophysical Observation", "SAO 217754"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.55226839),
        dec: Angle.Degrees(-41.23439518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124740"},
        {"Hipparcos Number", "HIP 69734"},
        {"Geneva Identification System", "GEN# +1.00124740"},
        {"Renson", "Renson 35690"},
        {"Smithsonian Astrophysical Observation", "SAO 224807"},
    },
    visualMagnitude: 7.86,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.10144020),
        dec: Angle.Degrees(-41.23321540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17343"},
        {"Hipparcos Number", "HIP 12885"},
        {"Smithsonian Astrophysical Observation", "SAO 216040"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.40633452),
        dec: Angle.Degrees(-41.23243407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154091"},
        {"Hipparcos Number", "HIP 83598"},
        {"Smithsonian Astrophysical Observation", "SAO 227608"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.30415744),
        dec: Angle.Degrees(-41.23181221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21246"},
        {"Hipparcos Number", "HIP 15845"},
        {"Smithsonian Astrophysical Observation", "SAO 216297"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.02661118),
        dec: Angle.Degrees(-41.23176505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105521"},
        {"Hipparcos Number", "HIP 59232"},
        {"Geneva Identification System", "GEN# +1.00105521"},
        {"Smithsonian Astrophysical Observation", "SAO 223242"},
        {"Wilson Evans Batten Catalogue", "WEB 10536"},
    },
    visualMagnitude: 5.51,
    bvColour: -0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.22749200),
        dec: Angle.Degrees(-41.23158452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79881"},
        {"Hipparcos Number", "HIP 45415"},
        {"Smithsonian Astrophysical Observation", "SAO 220997"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.81689754),
        dec: Angle.Degrees(-41.23064485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151804"},
        {"Hipparcos Number", "HIP 82493"},
        {"Celescope Catalog", "CEL 4431"},
        {"Geneva Identification System", "GEN# +1.00151804"},
        {"Smithsonian Astrophysical Observation", "SAO 227313"},
        {"Wilson Evans Batten Catalogue", "WEB 13926"},
        {"New General Catalogue", "NGC 6231 303"},
    },
    visualMagnitude: 5.23,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.89050874),
        dec: Angle.Degrees(-41.23053288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20389"},
        {"Hipparcos Number", "HIP 15149"},
        {"Smithsonian Astrophysical Observation", "SAO 216231"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.81905894),
        dec: Angle.Degrees(-41.23026620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29267"},
        {"Hipparcos Number", "HIP 21330"},
        {"Smithsonian Astrophysical Observation", "SAO 216880"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.66856067),
        dec: Angle.Degrees(-41.22976758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206837"},
        {"Hipparcos Number", "HIP 107453"},
        {"Geneva Identification System", "GEN# +1.00206837"},
        {"Smithsonian Astrophysical Observation", "SAO 230830"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.731,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.45824041),
        dec: Angle.Degrees(-41.22972325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196277"},
        {"Hipparcos Number", "HIP 101787"},
        {"Geneva Identification System", "GEN# +1.00196277"},
        {"Smithsonian Astrophysical Observation", "SAO 230302"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.43277149),
        dec: Angle.Degrees(-41.22750952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197031"},
        {"Hipparcos Number", "HIP 102204"},
        {"Geneva Identification System", "GEN# +1.00197031"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.62521522),
        dec: Angle.Degrees(-41.22626999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174562"},
        {"Hipparcos Number", "HIP 92661"},
        {"Smithsonian Astrophysical Observation", "SAO 229345"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.23225446),
        dec: Angle.Degrees(-41.22614877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35485",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35485"},
    },
    visualMagnitude: 11.07,
    bvColour: 0.742,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.86519285),
        dec: Angle.Degrees(-41.22518795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 188.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210193"},
        {"Hipparcos Number", "HIP 109381"},
        {"Geneva Identification System", "GEN# +1.00210193"},
        {"Smithsonian Astrophysical Observation", "SAO 231001"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.39370333),
        dec: Angle.Degrees(-41.22471729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 158.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155872"},
        {"Hipparcos Number", "HIP 84463"},
        {"Smithsonian Astrophysical Observation", "SAO 227761"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.01678710),
        dec: Angle.Degrees(-41.22438993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24649"},
        {"Hipparcos Number", "HIP 18187"},
        {"Fundamental Katalog 5th Edition", "FK5 4352"},
        {"Geneva Identification System", "GEN# +1.00024649"},
        {"Smithsonian Astrophysical Observation", "SAO 216539"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.36331070),
        dec: Angle.Degrees(-41.22286801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 65.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150954"},
        {"Hipparcos Number", "HIP 82094"},
        {"Geneva Identification System", "GEN# +1.00150954"},
        {"Smithsonian Astrophysical Observation", "SAO 227177"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.54618416),
        dec: Angle.Degrees(-41.22108741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21582"},
        {"Hipparcos Number", "HIP 16097"},
        {"Smithsonian Astrophysical Observation", "SAO 216326"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.84064820),
        dec: Angle.Degrees(-41.22072449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42058"},
        {"Hipparcos Number", "HIP 28952"},
        {"Geneva Identification System", "GEN# +1.00042058"},
        {"Smithsonian Astrophysical Observation", "SAO 217719"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.66419558),
        dec: Angle.Degrees(-41.22001351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27842"},
        {"Hipparcos Number", "HIP 20385"},
        {"Geneva Identification System", "GEN# +1.00027842"},
        {"Smithsonian Astrophysical Observation", "SAO 216765"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.47736273),
        dec: Angle.Degrees(-41.22000927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170981"},
        {"Hipparcos Number", "HIP 91021"},
        {"Smithsonian Astrophysical Observation", "SAO 229115"},
    },
    visualMagnitude: 8.12,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.52243809),
        dec: Angle.Degrees(-41.21586732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33473B"},
        {"Hipparcos Number", "HIP 23923"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.12116870),
        dec: Angle.Degrees(-41.21486032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 276.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33473"},
        {"Hipparcos Number", "HIP 23926"},
        {"Geneva Identification System", "GEN# +1.00033473"},
        {"Smithsonian Astrophysical Observation", "SAO 217198"},
        {"Wilson Evans Batten Catalogue", "WEB 4666"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.12485202),
        dec: Angle.Degrees(-41.21436998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 283.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126622"},
        {"Hipparcos Number", "HIP 70707"},
        {"Smithsonian Astrophysical Observation", "SAO 224942"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.92432040),
        dec: Angle.Degrees(-41.21373100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114921"},
        {"Hipparcos Number", "HIP 64585"},
        {"Geneva Identification System", "GEN# +1.00114921"},
        {"Smithsonian Astrophysical Observation", "SAO 223992"},
        {"Wilson Evans Batten Catalogue", "WEB 11426"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.56822293),
        dec: Angle.Degrees(-41.21176053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206303"},
        {"Hipparcos Number", "HIP 107155"},
        {"Geneva Identification System", "GEN# +1.00206303"},
        {"Smithsonian Astrophysical Observation", "SAO 230799"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.58387464),
        dec: Angle.Degrees(-41.20924332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 324016"},
        {"Hipparcos Number", "HIP 86156"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.09222657),
        dec: Angle.Degrees(-41.20815114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53631"},
        {"Hipparcos Number", "HIP 34053"},
        {"Smithsonian Astrophysical Observation", "SAO 218417"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.95961823),
        dec: Angle.Degrees(-41.20689583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3850"},
        {"Hipparcos Number", "HIP 3205"},
        {"Smithsonian Astrophysical Observation", "SAO 215189"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.20555010),
        dec: Angle.Degrees(-41.20664816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23786"},
        {"Hipparcos Number", "HIP 17597"},
        {"Geneva Identification System", "GEN# +1.00023786"},
        {"Smithsonian Astrophysical Observation", "SAO 216477"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.53968947),
        dec: Angle.Degrees(-41.20626284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21692"},
        {"Hipparcos Number", "HIP 16184"},
        {"Smithsonian Astrophysical Observation", "SAO 216340"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.12257495),
        dec: Angle.Degrees(-41.20544501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 156.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171207"},
        {"Hipparcos Number", "HIP 91126"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.81929404),
        dec: Angle.Degrees(-41.20381963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116664",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116664"},
        {"Geneva Identification System", "GEN# -0.01006147"},
    },
    visualMagnitude: 11.45,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.63702012),
        dec: Angle.Degrees(-09.31872059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81986"},
        {"Hipparcos Number", "HIP 46409"},
        {"Smithsonian Astrophysical Observation", "SAO 221186"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.96161065),
        dec: Angle.Degrees(-41.20033320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94798"},
        {"Hipparcos Number", "HIP 53451"},
        {"Smithsonian Astrophysical Observation", "SAO 222431"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.01393402),
        dec: Angle.Degrees(-41.20014312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75224"},
        {"Hipparcos Number", "HIP 43146"},
        {"Smithsonian Astrophysical Observation", "SAO 220460"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.81995431),
        dec: Angle.Degrees(-41.19776224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57829"},
        {"Hipparcos Number", "HIP 35627"},
        {"Smithsonian Astrophysical Observation", "SAO 218661"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.887,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.27116302),
        dec: Angle.Degrees(-41.19731642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113523"},
        {"Hipparcos Number", "HIP 63820"},
        {"Geneva Identification System", "GEN# +1.00113523"},
        {"Smithsonian Astrophysical Observation", "SAO 223881"},
    },
    visualMagnitude: 6.24,
    bvColour: 1.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.20103515),
        dec: Angle.Degrees(-41.19628181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70699"},
        {"Hipparcos Number", "HIP 40971"},
        {"Celescope Catalog", "CEL 2417"},
        {"Geneva Identification System", "GEN# +1.00070699"},
        {"Smithsonian Astrophysical Observation", "SAO 219827"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.42019218),
        dec: Angle.Degrees(-41.19503618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36330"},
        {"Hipparcos Number", "HIP 25676"},
        {"Smithsonian Astrophysical Observation", "SAO 217356"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.25778967),
        dec: Angle.Degrees(-41.19485857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 103.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219531"},
        {"Hipparcos Number", "HIP 114937"},
        {"Geneva Identification System", "GEN# +1.00219531"},
        {"Smithsonian Astrophysical Observation", "SAO 231533"},
    },
    visualMagnitude: 6.49,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.20770882),
        dec: Angle.Degrees(-41.19443278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83877"},
        {"Hipparcos Number", "HIP 47445"},
        {"Smithsonian Astrophysical Observation", "SAO 221392"},
    },
    visualMagnitude: 8.55,
    bvColour: -0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.04211665),
        dec: Angle.Degrees(-41.19340498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115773"},
        {"Hipparcos Number", "HIP 65046"},
        {"Geneva Identification System", "GEN# +1.00115773"},
        {"Smithsonian Astrophysical Observation", "SAO 224066"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.99396293),
        dec: Angle.Degrees(-41.19069489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -328.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9193"},
        {"Hipparcos Number", "HIP 6976"},
        {"Geneva Identification System", "GEN# +1.00009193"},
        {"Smithsonian Astrophysical Observation", "SAO 215528"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.45580609),
        dec: Angle.Degrees(-41.18821503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71544"},
        {"Hipparcos Number", "HIP 41372"},
        {"Celescope Catalog", "CEL 2512"},
        {"Geneva Identification System", "GEN# +1.00071544"},
        {"Smithsonian Astrophysical Observation", "SAO 219918"},
    },
    visualMagnitude: 7.85,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.60268925),
        dec: Angle.Degrees(-41.18723595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33017",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33017"},
        {"Smithsonian Astrophysical Observation", "SAO 218275"},
    },
    visualMagnitude: 9.56,
    bvColour: 1.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.19607053),
        dec: Angle.Degrees(-41.18595365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185137"},
        {"Hipparcos Number", "HIP 96694"},
        {"Smithsonian Astrophysical Observation", "SAO 229796"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.87007016),
        dec: Angle.Degrees(-41.18575005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122111"},
        {"Hipparcos Number", "HIP 68439"},
        {"Smithsonian Astrophysical Observation", "SAO 224613"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.16856080),
        dec: Angle.Degrees(-41.18514029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111869"},
        {"Hipparcos Number", "HIP 62843"},
        {"Geneva Identification System", "GEN# +1.00111869"},
        {"Smithsonian Astrophysical Observation", "SAO 223728"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.18634240),
        dec: Angle.Degrees(-41.18449645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156604"},
        {"Hipparcos Number", "HIP 84842"},
        {"Fundamental Katalog 5th Edition", "FK5 5529"},
        {"Smithsonian Astrophysical Observation", "SAO 227836"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.10337530),
        dec: Angle.Degrees(-41.18421037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206038"},
        {"Hipparcos Number", "HIP 107021"},
        {"Smithsonian Astrophysical Observation", "SAO 230784"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.12232367),
        dec: Angle.Degrees(-41.18399024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219192"},
        {"Hipparcos Number", "HIP 114730"},
        {"Smithsonian Astrophysical Observation", "SAO 231503"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.61302449),
        dec: Angle.Degrees(-41.18153121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15428"},
        {"Hipparcos Number", "HIP 11454"},
        {"Smithsonian Astrophysical Observation", "SAO 215908"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.94303639),
        dec: Angle.Degrees(-41.18153004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12948"},
        {"Hipparcos Number", "HIP 9776"},
        {"Smithsonian Astrophysical Observation", "SAO 215766"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.43016519),
        dec: Angle.Degrees(-41.18071139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7767"},
        {"Hipparcos Number", "HIP 5962"},
        {"Smithsonian Astrophysical Observation", "SAO 215435"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.17533225),
        dec: Angle.Degrees(-41.18045453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82711"},
        {"Hipparcos Number", "HIP 46818"},
        {"Geneva Identification System", "GEN# +1.00082711"},
        {"Smithsonian Astrophysical Observation", "SAO 221266"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.11284152),
        dec: Angle.Degrees(-41.18001581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122980"},
        {"Hipparcos Number", "HIP 68862"},
        {"Geneva Identification System", "GEN# +1.00122980"},
        {"Smithsonian Astrophysical Observation", "SAO 224673"},
        {"Wilson Evans Batten Catalogue", "WEB 12037"},
    },
    visualMagnitude: 4.36,
    bvColour: -0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.51160840),
        dec: Angle.Degrees(-41.17958035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134218"},
        {"Hipparcos Number", "HIP 74220"},
        {"Celescope Catalog", "CEL 4344"},
        {"Geneva Identification System", "GEN# +1.00134218"},
        {"Smithsonian Astrophysical Observation", "SAO 225499"},
    },
    visualMagnitude: 7.50,
    bvColour: -0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.50259104),
        dec: Angle.Degrees(-41.17938141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204783"},
        {"Hipparcos Number", "HIP 106327"},
        {"Fundamental Katalog 5th Edition", "FK5 3719"},
        {"Geneva Identification System", "GEN# +1.00204783"},
        {"Smithsonian Astrophysical Observation", "SAO 230726"},
        {"Wilson Evans Batten Catalogue", "WEB 19256"},
    },
    visualMagnitude: 5.29,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.02442135),
        dec: Angle.Degrees(-41.17933640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199770"},
        {"Hipparcos Number", "HIP 103689"},
        {"Smithsonian Astrophysical Observation", "SAO 230478"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.16979062),
        dec: Angle.Degrees(-41.17909799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24047"},
        {"Hipparcos Number", "HIP 17765"},
        {"Smithsonian Astrophysical Observation", "SAO 216494"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.04774261),
        dec: Angle.Degrees(-41.17795494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174450"},
        {"Hipparcos Number", "HIP 92621"},
        {"Smithsonian Astrophysical Observation", "SAO 229338"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.08443423),
        dec: Angle.Degrees(-41.17716463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51595",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51595"},
    },
    visualMagnitude: 12.35,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.09098686),
        dec: Angle.Degrees(-41.17645234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90584"},
        {"Hipparcos Number", "HIP 51126"},
        {"Smithsonian Astrophysical Observation", "SAO 222055"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.67103315),
        dec: Angle.Degrees(-41.17632851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162616"},
        {"Hipparcos Number", "HIP 87611"},
        {"Smithsonian Astrophysical Observation", "SAO 228525"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.46338037),
        dec: Angle.Degrees(-41.17569249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214016"},
        {"Hipparcos Number", "HIP 111561"},
        {"Geneva Identification System", "GEN# +1.00214016"},
        {"Smithsonian Astrophysical Observation", "SAO 231208"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.02236572),
        dec: Angle.Degrees(-41.17475195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71967"},
        {"Hipparcos Number", "HIP 41576"},
        {"Celescope Catalog", "CEL 2550"},
        {"Geneva Identification System", "GEN# +1.00071967"},
        {"Smithsonian Astrophysical Observation", "SAO 219972"},
    },
    visualMagnitude: 7.52,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.15404289),
        dec: Angle.Degrees(-41.17430206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28837"},
        {"Hipparcos Number", "HIP 21063"},
        {"Geneva Identification System", "GEN# +1.00028837"},
        {"Smithsonian Astrophysical Observation", "SAO 216847"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.72216548),
        dec: Angle.Degrees(-41.17420932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158799"},
        {"Hipparcos Number", "HIP 85889"},
        {"Celescope Catalog", "CEL 4527"},
        {"Geneva Identification System", "GEN# +1.00158799"},
        {"Smithsonian Astrophysical Observation", "SAO 228110"},
        {"Wilson Evans Batten Catalogue", "WEB 14494"},
    },
    visualMagnitude: 5.84,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.28077941),
        dec: Angle.Degrees(-41.17305756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142132"},
        {"Hipparcos Number", "HIP 77888"},
        {"Geneva Identification System", "GEN# +1.00142132"},
        {"Smithsonian Astrophysical Observation", "SAO 226351"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.60229098),
        dec: Angle.Degrees(-41.17286105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132283"},
        {"Hipparcos Number", "HIP 73367"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.89197297),
        dec: Angle.Degrees(-41.17182893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12157"},
        {"Hipparcos Number", "HIP 9209"},
        {"Smithsonian Astrophysical Observation", "SAO 215718"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.61646856),
        dec: Angle.Degrees(-41.17001960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56378"},
        {"Hipparcos Number", "HIP 35040"},
        {"Celescope Catalog", "CEL 1713"},
        {"Geneva Identification System", "GEN# +1.00056378"},
        {"Smithsonian Astrophysical Observation", "SAO 218566"},
    },
    visualMagnitude: 7.56,
    bvColour: -0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.71109465),
        dec: Angle.Degrees(-41.16875956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55093",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55093"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.19951500),
        dec: Angle.Degrees(-41.16736552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13940"},
        {"Hipparcos Number", "HIP 10440"},
        {"Fundamental Katalog 5th Edition", "FK5 1060"},
        {"Geneva Identification System", "GEN# +1.00013940"},
        {"Smithsonian Astrophysical Observation", "SAO 215831"},
        {"Wilson Evans Batten Catalogue", "WEB 2185"},
    },
    visualMagnitude: 5.91,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.63317374),
        dec: Angle.Degrees(-41.16670109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138690"},
        {"Hipparcos Number", "HIP 76297"},
        {"Celescope Catalog", "CEL 4382"},
        {"Geneva Identification System", "GEN# +1.00138690"},
        {"Smithsonian Astrophysical Observation", "SAO 225938"},
        {"Wilson Evans Batten Catalogue", "WEB 12953"},
    },
    visualMagnitude: 2.80,
    bvColour: -0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.78525156),
        dec: Angle.Degrees(-41.16669497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62278"},
        {"Hipparcos Number", "HIP 37462"},
        {"Celescope Catalog", "CEL 1982"},
        {"Geneva Identification System", "GEN# +1.00062278"},
        {"Smithsonian Astrophysical Observation", "SAO 218902"},
    },
    visualMagnitude: 7.40,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.34121053),
        dec: Angle.Degrees(-41.16478132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37610"},
        {"Hipparcos Number", "HIP 26465"},
        {"Geneva Identification System", "GEN# +1.00037610"},
        {"Smithsonian Astrophysical Observation", "SAO 217437"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.44908922),
        dec: Angle.Degrees(-41.16312741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173411"},
        {"Hipparcos Number", "HIP 92158"},
        {"Geneva Identification System", "GEN# +1.00173411"},
        {"Smithsonian Astrophysical Observation", "SAO 229276"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.929,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.74956191),
        dec: Angle.Degrees(-41.16242328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84582"},
        {"Hipparcos Number", "HIP 47844"},
        {"Smithsonian Astrophysical Observation", "SAO 221454"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.28445826),
        dec: Angle.Degrees(-41.16153968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16603"},
        {"Hipparcos Number", "HIP 12290"},
        {"Smithsonian Astrophysical Observation", "SAO 215980"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.58295557),
        dec: Angle.Degrees(-41.16153531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75367",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75367"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.01782300),
        dec: Angle.Degrees(-41.16152964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20722"},
        {"Hipparcos Number", "HIP 15421"},
        {"Geneva Identification System", "GEN# +1.00020722"},
        {"Smithsonian Astrophysical Observation", "SAO 216256"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.68667108),
        dec: Angle.Degrees(-41.16002954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74514"},
        {"Hipparcos Number", "HIP 42772"},
        {"Smithsonian Astrophysical Observation", "SAO 220324"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.73235031),
        dec: Angle.Degrees(-41.15859752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58800"},
        {"Hipparcos Number", "HIP 36015"},
        {"Geneva Identification System", "GEN# +1.00058800"},
        {"Smithsonian Astrophysical Observation", "SAO 218713"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.32923461),
        dec: Angle.Degrees(-41.15772382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144897"},
        {"Hipparcos Number", "HIP 79197"},
        {"Geneva Identification System", "GEN# +1.00144897"},
        {"Renson", "Renson 41060"},
        {"Smithsonian Astrophysical Observation", "SAO 226549"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.46326820),
        dec: Angle.Degrees(-41.15769607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41352"},
        {"Hipparcos Number", "HIP 28631"},
        {"Smithsonian Astrophysical Observation", "SAO 217689"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.67320318),
        dec: Angle.Degrees(-41.15729772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68302"},
        {"Hipparcos Number", "HIP 39994"},
        {"Smithsonian Astrophysical Observation", "SAO 219520"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.51337521),
        dec: Angle.Degrees(-41.15635240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33227"},
        {"Hipparcos Number", "HIP 23801"},
        {"Smithsonian Astrophysical Observation", "SAO 217180"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.71804118),
        dec: Angle.Degrees(-41.15604520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184142"},
        {"Hipparcos Number", "HIP 96303"},
        {"Geneva Identification System", "GEN# +1.00184142"},
        {"Smithsonian Astrophysical Observation", "SAO 229749"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.71453550),
        dec: Angle.Degrees(-41.15507064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90625"},
        {"Hipparcos Number", "HIP 51164"},
        {"Geneva Identification System", "GEN# +1.00090625"},
        {"Smithsonian Astrophysical Observation", "SAO 222058"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.76708908),
        dec: Angle.Degrees(-41.15380731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41612"},
        {"Hipparcos Number", "HIP 28745"},
        {"Smithsonian Astrophysical Observation", "SAO 217699"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.06069614),
        dec: Angle.Degrees(-41.15367515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217307"},
        {"Hipparcos Number", "HIP 113592"},
        {"Smithsonian Astrophysical Observation", "SAO 231387"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.10079643),
        dec: Angle.Degrees(-41.15112248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152408"},
        {"Henry Draper 2", "HD 152408A"},
        {"Hipparcos Number", "HIP 82775"},
        {"Celescope Catalog", "CEL 4451"},
        {"Geneva Identification System", "GEN# +1.00152408"},
        {"Smithsonian Astrophysical Observation", "SAO 227425"},
        {"Wilson Evans Batten Catalogue", "WEB 13992"},
        {"New General Catalogue", "NGC 6231 327"},
    },
    visualMagnitude: 5.78,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.74377203),
        dec: Angle.Degrees(-41.15085448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18022"},
        {"Hipparcos Number", "HIP 13396"},
        {"Smithsonian Astrophysical Observation", "SAO 216077"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.10237837),
        dec: Angle.Degrees(-41.15083124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116483"},
        {"Hipparcos Number", "HIP 65432"},
        {"Smithsonian Astrophysical Observation", "SAO 224119"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.16338370),
        dec: Angle.Degrees(-41.15030264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188849"},
        {"Hipparcos Number", "HIP 98340"},
        {"Smithsonian Astrophysical Observation", "SAO 229961"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.71054948),
        dec: Angle.Degrees(-41.14952562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114338"},
        {"Hipparcos Number", "HIP 64281"},
        {"Smithsonian Astrophysical Observation", "SAO 223952"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.61085926),
        dec: Angle.Degrees(-41.14667936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191187"},
        {"Hipparcos Number", "HIP 99383"},
        {"Smithsonian Astrophysical Observation", "SAO 230080"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.57680970),
        dec: Angle.Degrees(-41.14633130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220139"},
        {"Hipparcos Number", "HIP 115337"},
        {"Smithsonian Astrophysical Observation", "SAO 231563"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.42007837),
        dec: Angle.Degrees(-41.14346807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10415"},
        {"Hipparcos Number", "HIP 7827"},
        {"Smithsonian Astrophysical Observation", "SAO 215613"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.17546444),
        dec: Angle.Degrees(-41.14327275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115111"},
        {"Hipparcos Number", "HIP 64699"},
        {"Fundamental Katalog 5th Edition", "FK5 5169"},
        {"Geneva Identification System", "GEN# +1.00115111"},
        {"Smithsonian Astrophysical Observation", "SAO 224014"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.90560456),
        dec: Angle.Degrees(-41.14129384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90296"},
        {"Hipparcos Number", "HIP 50962"},
        {"Smithsonian Astrophysical Observation", "SAO 222030"},
    },
    visualMagnitude: 8.15,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.14307741),
        dec: Angle.Degrees(-41.14114344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181647"},
        {"Hipparcos Number", "HIP 95286"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.78180319),
        dec: Angle.Degrees(-41.13954047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106489"},
        {"Hipparcos Number", "HIP 59726"},
        {"Geneva Identification System", "GEN# +1.00106489"},
        {"Smithsonian Astrophysical Observation", "SAO 223305"},
        {"Wilson Evans Batten Catalogue", "WEB 10612"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.74018101),
        dec: Angle.Degrees(-41.13923314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -313.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83042"},
        {"Hipparcos Number", "HIP 46980"},
        {"Smithsonian Astrophysical Observation", "SAO 221298"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.62868411),
        dec: Angle.Degrees(-41.13744474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210782"},
        {"Hipparcos Number", "HIP 109725"},
        {"Smithsonian Astrophysical Observation", "SAO 231038"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.40527226),
        dec: Angle.Degrees(-41.13664904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73205",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73205"},
    },
    visualMagnitude: 11.76,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.42814751),
        dec: Angle.Degrees(-41.13607691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -250.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -159.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209802"},
        {"Hipparcos Number", "HIP 109177"},
        {"Geneva Identification System", "GEN# +1.00209802"},
        {"Smithsonian Astrophysical Observation", "SAO 230985"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.948,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.75403286),
        dec: Angle.Degrees(-41.13314138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95009"},
        {"Hipparcos Number", "HIP 53574"},
        {"Geneva Identification System", "GEN# +1.00095009"},
        {"Smithsonian Astrophysical Observation", "SAO 222452"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.40611940),
        dec: Angle.Degrees(-41.13205015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45834"},
        {"Hipparcos Number", "HIP 30759"},
        {"Smithsonian Astrophysical Observation", "SAO 217940"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.914,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.95001872),
        dec: Angle.Degrees(-41.13177197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 99.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46774"},
        {"Hipparcos Number", "HIP 31248"},
        {"Smithsonian Astrophysical Observation", "SAO 218013"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.31709368),
        dec: Angle.Degrees(-41.13094784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185032"},
        {"Hipparcos Number", "HIP 96650"},
        {"Smithsonian Astrophysical Observation", "SAO 229792"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.75491469),
        dec: Angle.Degrees(-41.12805889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150093"},
        {"Hipparcos Number", "HIP 81645"},
        {"Geneva Identification System", "GEN# +1.00150093"},
        {"Smithsonian Astrophysical Observation", "SAO 227043"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.17692617),
        dec: Angle.Degrees(-41.12694980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166701"},
        {"Hipparcos Number", "HIP 89335"},
        {"Fundamental Katalog 5th Edition", "FK5 5606"},
        {"Smithsonian Astrophysical Observation", "SAO 228821"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.42013113),
        dec: Angle.Degrees(-41.12670685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66726"},
        {"Hipparcos Number", "HIP 39385"},
        {"Smithsonian Astrophysical Observation", "SAO 219346"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.78001316),
        dec: Angle.Degrees(-41.12607177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75081"},
        {"Hipparcos Number", "HIP 43073"},
        {"Celescope Catalog", "CEL 2885"},
        {"Geneva Identification System", "GEN# +1.00075081"},
        {"Smithsonian Astrophysical Observation", "SAO 220432"},
    },
    visualMagnitude: 6.21,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.59905651),
        dec: Angle.Degrees(-41.12540265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206276"},
        {"Hipparcos Number", "HIP 107143"},
        {"Geneva Identification System", "GEN# +1.00206276"},
        {"Smithsonian Astrophysical Observation", "SAO 230798"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.54159600),
        dec: Angle.Degrees(-41.12422092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 238.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -293.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184287"},
        {"Hipparcos Number", "HIP 96361"},
        {"Smithsonian Astrophysical Observation", "SAO 229757"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.88281710),
        dec: Angle.Degrees(-41.12111673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145191"},
        {"Hipparcos Number", "HIP 79320"},
        {"Fundamental Katalog 5th Edition", "FK5 3278"},
        {"Geneva Identification System", "GEN# +1.00145191"},
        {"Smithsonian Astrophysical Observation", "SAO 226564"},
    },
    visualMagnitude: 5.86,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.82403118),
        dec: Angle.Degrees(-41.11949816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137888"},
        {"Hipparcos Number", "HIP 75891"},
        {"Geneva Identification System", "GEN# +1.00137888"},
        {"Smithsonian Astrophysical Observation", "SAO 225841"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.51783524),
        dec: Angle.Degrees(-41.11943758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150573"},
        {"Hipparcos Number", "HIP 81903"},
        {"Geneva Identification System", "GEN# +1.00150573"},
        {"Smithsonian Astrophysical Observation", "SAO 227118"},
    },
    visualMagnitude: 6.21,
    bvColour: 0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.94043203),
        dec: Angle.Degrees(-41.11914006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 647"},
        {"Hipparcos Number", "HIP 861"},
        {"Smithsonian Astrophysical Observation", "SAO 214991"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.65280052),
        dec: Angle.Degrees(-41.11858278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200130"},
        {"Hipparcos Number", "HIP 103885"},
        {"Smithsonian Astrophysical Observation", "SAO 230496"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.74368398),
        dec: Angle.Degrees(-41.11837661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10560"},
        {"Hipparcos Number", "HIP 7940"},
        {"Geneva Identification System", "GEN# +1.00010560"},
        {"Renson", "Renson 2604"},
        {"Smithsonian Astrophysical Observation", "SAO 215620"},
        {"Wilson Evans Batten Catalogue", "WEB 1696"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.51220394),
        dec: Angle.Degrees(-41.11801705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42503"},
        {"Hipparcos Number", "HIP 29159"},
        {"Smithsonian Astrophysical Observation", "SAO 217738"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.26069548),
        dec: Angle.Degrees(-41.11796064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94223"},
        {"Hipparcos Number", "HIP 53107"},
        {"Smithsonian Astrophysical Observation", "SAO 222383"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.97668042),
        dec: Angle.Degrees(-41.11649019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88673",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88673"},
    },
    visualMagnitude: 11.70,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.53565328),
        dec: Angle.Degrees(-41.11627008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170571"},
        {"Hipparcos Number", "HIP 90854"},
        {"Smithsonian Astrophysical Observation", "SAO 229098"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.00991784),
        dec: Angle.Degrees(-41.11547097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186150"},
        {"Hipparcos Number", "HIP 97137"},
        {"Smithsonian Astrophysical Observation", "SAO 229844"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.13456729),
        dec: Angle.Degrees(-41.11530960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95716"},
        {"Hipparcos Number", "HIP 53940"},
        {"Smithsonian Astrophysical Observation", "SAO 222508"},
    },
    visualMagnitude: 6.48,
    bvColour: 1.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.55766001),
        dec: Angle.Degrees(-41.11406717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101788"},
        {"Hipparcos Number", "HIP 57127"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.68456570),
        dec: Angle.Degrees(-41.11340517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150591"},
        {"Hipparcos Number", "HIP 81914"},
        {"Celescope Catalog", "CEL 4423"},
        {"Geneva Identification System", "GEN# +1.00150591"},
        {"Smithsonian Astrophysical Observation", "SAO 227123"},
        {"Wilson Evans Batten Catalogue", "WEB 13833"},
    },
    visualMagnitude: 6.14,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.97535885),
        dec: Angle.Degrees(-41.11329362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74040"},
        {"Hipparcos Number", "HIP 42508"},
        {"Smithsonian Astrophysical Observation", "SAO 220247"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.00351255),
        dec: Angle.Degrees(-41.11242241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179813"},
        {"Hipparcos Number", "HIP 94668"},
        {"Geneva Identification System", "GEN# +1.00179813"},
        {"Smithsonian Astrophysical Observation", "SAO 229581"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.95737103),
        dec: Angle.Degrees(-41.10973898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124938"},
        {"Hipparcos Number", "HIP 69830"},
        {"Smithsonian Astrophysical Observation", "SAO 224819"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.37191126),
        dec: Angle.Degrees(-41.10913129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77165"},
        {"Hipparcos Number", "HIP 44146"},
        {"Geneva Identification System", "GEN# +1.00077165"},
        {"Smithsonian Astrophysical Observation", "SAO 220721"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.85531802),
        dec: Angle.Degrees(-41.10808180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38488"},
        {"Hipparcos Number", "HIP 27048"},
        {"Geneva Identification System", "GEN# +1.00038488"},
        {"Smithsonian Astrophysical Observation", "SAO 217502"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.03814748),
        dec: Angle.Degrees(-41.10609326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95964"},
        {"Hipparcos Number", "HIP 54052"},
        {"Geneva Identification System", "GEN# +1.00095964"},
        {"Smithsonian Astrophysical Observation", "SAO 222529"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.841,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.91204109),
        dec: Angle.Degrees(-41.10554177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39654"},
        {"Hipparcos Number", "HIP 27700"},
        {"Smithsonian Astrophysical Observation", "SAO 217583"},
    },
    visualMagnitude: 6.71,
    bvColour: 1.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.98072408),
        dec: Angle.Degrees(-41.10531507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219263"},
        {"Hipparcos Number", "HIP 114775"},
        {"Fundamental Katalog 5th Edition", "FK5 3859"},
        {"Geneva Identification System", "GEN# +1.00219263"},
        {"Smithsonian Astrophysical Observation", "SAO 231512"},
        {"Wilson Evans Batten Catalogue", "WEB 20347"},
    },
    visualMagnitude: 5.77,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.74389520),
        dec: Angle.Degrees(-41.10512524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 110.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21962",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21962"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.847,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.81230173),
        dec: Angle.Degrees(-41.10493958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -135.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40557"},
        {"Hipparcos Number", "HIP 28207"},
        {"Smithsonian Astrophysical Observation", "SAO 217641"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.39987517),
        dec: Angle.Degrees(-41.10484985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154109"},
        {"Hipparcos Number", "HIP 83607"},
        {"Geneva Identification System", "GEN# +1.00154109"},
        {"Smithsonian Astrophysical Observation", "SAO 227611"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.33374082),
        dec: Angle.Degrees(-41.10463370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185971"},
        {"Hipparcos Number", "HIP 97062"},
        {"Smithsonian Astrophysical Observation", "SAO 229834"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.88239007),
        dec: Angle.Degrees(-41.10035381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 327254"},
        {"Hipparcos Number", "HIP 84440"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.95378110),
        dec: Angle.Degrees(-41.09907734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89836"},
        {"Hipparcos Number", "HIP 50703"},
        {"Smithsonian Astrophysical Observation", "SAO 221980"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.30136681),
        dec: Angle.Degrees(-41.09865810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110769",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110769"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.62195417),
        dec: Angle.Degrees(-41.09736151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216742"},
        {"Hipparcos Number", "HIP 113240"},
        {"Fundamental Katalog 5th Edition", "FK5 6028"},
        {"Smithsonian Astrophysical Observation", "SAO 231360"},
    },
    visualMagnitude: 6.72,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.97633018),
        dec: Angle.Degrees(-41.09681223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225121"},
        {"Hipparcos Number", "HIP 295"},
        {"Geneva Identification System", "GEN# +1.00225121"},
        {"Smithsonian Astrophysical Observation", "SAO 214944"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.91866516),
        dec: Angle.Degrees(-41.09585606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1646"},
        {"Hipparcos Number", "HIP 1648"},
        {"Smithsonian Astrophysical Observation", "SAO 215057"},
    },
    visualMagnitude: 9.60,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.16421152),
        dec: Angle.Degrees(-41.09530584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30516"},
        {"Hipparcos Number", "HIP 22198"},
        {"Smithsonian Astrophysical Observation", "SAO 216988"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.61563845),
        dec: Angle.Degrees(-41.09223225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80467"},
        {"Hipparcos Number", "HIP 45672"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.66377348),
        dec: Angle.Degrees(-41.09148893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81398"},
        {"Hipparcos Number", "HIP 46095"},
        {"Geneva Identification System", "GEN# +1.00081398"},
        {"Smithsonian Astrophysical Observation", "SAO 221135"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.00180439),
        dec: Angle.Degrees(-41.08544325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132199"},
        {"Hipparcos Number", "HIP 73333"},
        {"Fundamental Katalog 5th Edition", "FK5 5330"},
        {"Smithsonian Astrophysical Observation", "SAO 225345"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.78931471),
        dec: Angle.Degrees(-41.08424435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123971"},
        {"Hipparcos Number", "HIP 69354"},
        {"Smithsonian Astrophysical Observation", "SAO 224758"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.93239946),
        dec: Angle.Degrees(-41.08330524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219885"},
        {"Hipparcos Number", "HIP 115175"},
        {"Geneva Identification System", "GEN# +1.00219885"},
        {"Smithsonian Astrophysical Observation", "SAO 231550"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.92509017),
        dec: Angle.Degrees(-41.08321913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199245"},
        {"Hipparcos Number", "HIP 103440"},
        {"Smithsonian Astrophysical Observation", "SAO 230454"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.34688796),
        dec: Angle.Degrees(-41.08195671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24903"},
        {"Hipparcos Number", "HIP 18389"},
        {"Smithsonian Astrophysical Observation", "SAO 216553"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.96006978),
        dec: Angle.Degrees(-41.08015284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152246"},
        {"Hipparcos Number", "HIP 82685"},
        {"Celescope Catalog", "CEL 4444"},
        {"Geneva Identification System", "GEN# +1.00152246"},
        {"Smithsonian Astrophysical Observation", "SAO 227381"},
        {"New General Catalogue", "NGC 6231 320"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.52207544),
        dec: Angle.Degrees(-41.07947271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222987"},
        {"Hipparcos Number", "HIP 117199"},
        {"Geneva Identification System", "GEN# +1.00222987"},
        {"Smithsonian Astrophysical Observation", "SAO 231766"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.46118655),
        dec: Angle.Degrees(-41.07779533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198717"},
        {"Hipparcos Number", "HIP 103119"},
        {"Smithsonian Astrophysical Observation", "SAO 230421"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.39515737),
        dec: Angle.Degrees(-41.07497988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45983"},
        {"Hipparcos Number", "HIP 30849"},
        {"Geneva Identification System", "GEN# +1.00045983"},
        {"Smithsonian Astrophysical Observation", "SAO 217951"},
    },
    visualMagnitude: 6.32,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.17664773),
        dec: Angle.Degrees(-41.07491108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78645"},
        {"Hipparcos Number", "HIP 44834"},
        {"Geneva Identification System", "GEN# +1.00078645"},
        {"Smithsonian Astrophysical Observation", "SAO 220881"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.03117203),
        dec: Angle.Degrees(-41.07445762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44293"},
        {"Hipparcos Number", "HIP 30024"},
        {"Geneva Identification System", "GEN# +1.00044293"},
        {"Renson", "Renson 11760"},
        {"Smithsonian Astrophysical Observation", "SAO 217843"},
    },
    visualMagnitude: 7.76,
    bvColour: -0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.77275970),
        dec: Angle.Degrees(-41.07440200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147417"},
        {"Hipparcos Number", "HIP 80305"},
        {"Smithsonian Astrophysical Observation", "SAO 226714"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.91636852),
        dec: Angle.Degrees(-41.07402780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104192",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104192"},
        {"Geneva Identification System", "GEN# +6.20145071"},
    },
    visualMagnitude: 11.09,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.64598896),
        dec: Angle.Degrees(-41.07341426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34530"},
        {"Hipparcos Number", "HIP 24564"},
        {"Geneva Identification System", "GEN# +1.00034530"},
        {"Smithsonian Astrophysical Observation", "SAO 217259"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.822,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.04811955),
        dec: Angle.Degrees(-41.07299507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148429"},
        {"Hipparcos Number", "HIP 80792"},
        {"Smithsonian Astrophysical Observation", "SAO 226818"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.44523575),
        dec: Angle.Degrees(-41.07146359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70531"},
        {"Hipparcos Number", "HIP 40906"},
        {"Celescope Catalog", "CEL 2402"},
        {"Geneva Identification System", "GEN# +1.00070531"},
        {"Smithsonian Astrophysical Observation", "SAO 219813"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.20968210),
        dec: Angle.Degrees(-41.07094398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74115"},
        {"Hipparcos Number", "HIP 42559"},
        {"Celescope Catalog", "CEL 2761"},
        {"Smithsonian Astrophysical Observation", "SAO 220260"},
    },
    visualMagnitude: 8.20,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.13606110),
        dec: Angle.Degrees(-41.07041155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14057"},
        {"Hipparcos Number", "HIP 10507"},
        {"Geneva Identification System", "GEN# +1.00014057"},
        {"Smithsonian Astrophysical Observation", "SAO 215838"},
        {"Wilson Evans Batten Catalogue", "WEB 2205"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.85493600),
        dec: Angle.Degrees(-41.06903261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47425",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47425"},
        {"Geneva Identification System", "GEN# -0.04005404"},
    },
    visualMagnitude: 10.72,
    bvColour: 1.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.94490302),
        dec: Angle.Degrees(-41.06842435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -526.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 356.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111324"},
        {"Hipparcos Number", "HIP 62532"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.21426877),
        dec: Angle.Degrees(-41.06824642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92230"},
        {"Hipparcos Number", "HIP 52054"},
        {"Smithsonian Astrophysical Observation", "SAO 222211"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.55432397),
        dec: Angle.Degrees(-41.06795264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133340"},
        {"Hipparcos Number", "HIP 73826"},
        {"Geneva Identification System", "GEN# +1.00133340"},
        {"Smithsonian Astrophysical Observation", "SAO 225435"},
        {"Wilson Evans Batten Catalogue", "WEB 12613"},
    },
    visualMagnitude: 5.13,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.32978505),
        dec: Angle.Degrees(-41.06723379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170483"},
        {"Hipparcos Number", "HIP 90814"},
        {"Geneva Identification System", "GEN# +1.00170483"},
        {"Smithsonian Astrophysical Observation", "SAO 229091"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.87622351),
        dec: Angle.Degrees(-41.06573136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92472"},
        {"Hipparcos Number", "HIP 52200"},
        {"Geneva Identification System", "GEN# +1.00092472"},
        {"Smithsonian Astrophysical Observation", "SAO 222236"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.97653059),
        dec: Angle.Degrees(-41.06490962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51368"},
        {"Hipparcos Number", "HIP 33256"},
        {"Smithsonian Astrophysical Observation", "SAO 218308"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.78043321),
        dec: Angle.Degrees(-41.06481488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30202"},
        {"Hipparcos Number", "HIP 21998"},
        {"Geneva Identification System", "GEN# +1.00030202"},
        {"Smithsonian Astrophysical Observation", "SAO 216961"},
    },
    visualMagnitude: 6.24,
    bvColour: 1.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.93443179),
        dec: Angle.Degrees(-41.06481341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78020"},
        {"Hipparcos Number", "HIP 44550"},
        {"Smithsonian Astrophysical Observation", "SAO 220807"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.16002064),
        dec: Angle.Degrees(-41.06471726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169427"},
        {"Hipparcos Number", "HIP 90371"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.60270207),
        dec: Angle.Degrees(-41.06455896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31573"},
        {"Hipparcos Number", "HIP 22859"},
        {"Smithsonian Astrophysical Observation", "SAO 217064"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.77017668),
        dec: Angle.Degrees(-41.06433248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174152"},
        {"Hipparcos Number", "HIP 92487"},
        {"Geneva Identification System", "GEN# +1.00174152J"},
        {"Smithsonian Astrophysical Observation", "SAO 229318"},
        {"Wilson Evans Batten Catalogue", "WEB 15982"},
    },
    visualMagnitude: 6.50,
    bvColour: -0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.74436344),
        dec: Angle.Degrees(-41.06267808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174152B"},
        {"Hipparcos Number", "HIP 92490"},
        {"Smithsonian Astrophysical Observation", "SAO 229319"},
    },
    visualMagnitude: 9.27,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.74807413),
        dec: Angle.Degrees(-41.06241783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135730"},
        {"Hipparcos Number", "HIP 74875"},
        {"Geneva Identification System", "GEN# +1.00135730"},
        {"Renson", "Renson 38560"},
        {"Smithsonian Astrophysical Observation", "SAO 225631"},
        {"Wilson Evans Batten Catalogue", "WEB 12769"},
    },
    visualMagnitude: 6.30,
    bvColour: 0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.53911005),
        dec: Angle.Degrees(-41.06113317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195568"},
        {"Hipparcos Number", "HIP 101454"},
    },
    visualMagnitude: 9.97,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.42633942),
        dec: Angle.Degrees(-41.06090083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138940"},
        {"Hipparcos Number", "HIP 76442"},
        {"Geneva Identification System", "GEN# +1.00138940"},
        {"Smithsonian Astrophysical Observation", "SAO 225972"},
    },
    visualMagnitude: 7.61,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.18341705),
        dec: Angle.Degrees(-41.06042458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134974"},
        {"Hipparcos Number", "HIP 74565"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.53149437),
        dec: Angle.Degrees(-41.05998026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148645"},
        {"Hipparcos Number", "HIP 80908"},
        {"Smithsonian Astrophysical Observation", "SAO 226846"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.83909579),
        dec: Angle.Degrees(-41.05918715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107576"},
        {"Hipparcos Number", "HIP 60310"},
        {"Smithsonian Astrophysical Observation", "SAO 223382"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.49932382),
        dec: Angle.Degrees(-41.05897785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97944"},
        {"Hipparcos Number", "HIP 54982"},
        {"Smithsonian Astrophysical Observation", "SAO 222676"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.87192013),
        dec: Angle.Degrees(-41.05720490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83000"},
        {"Hipparcos Number", "HIP 46959"},
        {"Smithsonian Astrophysical Observation", "SAO 221293"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.57428990),
        dec: Angle.Degrees(-41.05619765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59218"},
        {"Hipparcos Number", "HIP 36190"},
        {"Smithsonian Astrophysical Observation", "SAO 218733"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.78917170),
        dec: Angle.Degrees(-41.05553843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109040"},
        {"Hipparcos Number", "HIP 61162"},
        {"Smithsonian Astrophysical Observation", "SAO 223494"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.99666938),
        dec: Angle.Degrees(-41.05508902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113846",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113846"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.82539532),
        dec: Angle.Degrees(-41.05367034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101127"},
        {"Hipparcos Number", "HIP 56744"},
        {"Fundamental Katalog 5th Edition", "FK5 5025"},
        {"Smithsonian Astrophysical Observation", "SAO 222921"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.51638775),
        dec: Angle.Degrees(-41.05300065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202790"},
        {"Hipparcos Number", "HIP 105283"},
        {"Geneva Identification System", "GEN# +1.00202790"},
        {"Smithsonian Astrophysical Observation", "SAO 230630"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.87135979),
        dec: Angle.Degrees(-41.05276199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32290"},
        {"Hipparcos Number", "HIP 23244"},
        {"Smithsonian Astrophysical Observation", "SAO 217106"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.03231300),
        dec: Angle.Degrees(-41.04792043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205772"},
        {"Hipparcos Number", "HIP 106871"},
        {"Smithsonian Astrophysical Observation", "SAO 230768"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.67272453),
        dec: Angle.Degrees(-41.04783120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31026"},
        {"Hipparcos Number", "HIP 22506"},
        {"Geneva Identification System", "GEN# +1.00031026"},
        {"Smithsonian Astrophysical Observation", "SAO 217033"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.64755452),
        dec: Angle.Degrees(-41.04762684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 69.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56244",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56244"},
    },
    visualMagnitude: 11.55,
    bvColour: 1.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.94611808),
        dec: Angle.Degrees(-41.04685396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -715.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 170.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78926"},
        {"Hipparcos Number", "HIP 44959"},
        {"Smithsonian Astrophysical Observation", "SAO 220901"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.39251084),
        dec: Angle.Degrees(-41.04606163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95858"},
        {"Hipparcos Number", "HIP 54018"},
        {"Geneva Identification System", "GEN# +1.00095858A"},
        {"Smithsonian Astrophysical Observation", "SAO 222523"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.76799890),
        dec: Angle.Degrees(-41.04580896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107757"},
        {"Hipparcos Number", "HIP 60405"},
        {"Smithsonian Astrophysical Observation", "SAO 223398"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.78094568),
        dec: Angle.Degrees(-41.04538361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34836"},
        {"Hipparcos Number", "HIP 24751"},
        {"Smithsonian Astrophysical Observation", "SAO 217279"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.61027029),
        dec: Angle.Degrees(-41.04435545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 494"},
        {"Hipparcos Number", "HIP 762"},
        {"Geneva Identification System", "GEN# +1.00000494"},
        {"Smithsonian Astrophysical Observation", "SAO 214982"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.34694824),
        dec: Angle.Degrees(-41.04420522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 136.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -135.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39297"},
        {"Hipparcos Number", "HIP 27522"},
        {"Smithsonian Astrophysical Observation", "SAO 217558"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.41409198),
        dec: Angle.Degrees(-41.04286800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142078"},
        {"Hipparcos Number", "HIP 77871"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.53186971),
        dec: Angle.Degrees(-41.04072553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158531"},
        {"Hipparcos Number", "HIP 85782"},
        {"Celescope Catalog", "CEL 4523"},
        {"Geneva Identification System", "GEN# +1.00158531J"},
        {"Smithsonian Astrophysical Observation", "SAO 228078"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.92748061),
        dec: Angle.Degrees(-41.03953657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75835"},
        {"Hipparcos Number", "HIP 43447"},
        {"Smithsonian Astrophysical Observation", "SAO 220564"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.73347181),
        dec: Angle.Degrees(-41.03809984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140078"},
        {"Hipparcos Number", "HIP 76992"},
        {"Smithsonian Astrophysical Observation", "SAO 226113"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.80744703),
        dec: Angle.Degrees(-41.03803757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181453"},
        {"Hipparcos Number", "HIP 95220"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.58859758),
        dec: Angle.Degrees(-41.03294222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77683"},
        {"Hipparcos Number", "HIP 44404"},
        {"Geneva Identification System", "GEN# +1.00077683"},
        {"Smithsonian Astrophysical Observation", "SAO 220774"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.847,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.68397027),
        dec: Angle.Degrees(-41.03147016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21658"},
        {"Hipparcos Number", "HIP 16160"},
        {"Smithsonian Astrophysical Observation", "SAO 216336"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.05707219),
        dec: Angle.Degrees(-41.03104263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 197.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 153.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56640"},
        {"Hipparcos Number", "HIP 35151"},
        {"Geneva Identification System", "GEN# +1.00056640"},
        {"Smithsonian Astrophysical Observation", "SAO 218579"},
        {"Wilson Evans Batten Catalogue", "WEB 7026"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.98606824),
        dec: Angle.Degrees(-41.03054149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -250.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 217.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33760"},
        {"Hipparcos Number", "HIP 24089"},
        {"Smithsonian Astrophysical Observation", "SAO 217215"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.892,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.62471840),
        dec: Angle.Degrees(-41.02798355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154589"},
        {"Hipparcos Number", "HIP 83858"},
        {"Geneva Identification System", "GEN# +1.00154589"},
        {"Smithsonian Astrophysical Observation", "SAO 227660"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.07203974),
        dec: Angle.Degrees(-41.02449431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129364"},
        {"Hipparcos Number", "HIP 71986"},
        {"Geneva Identification System", "GEN# +1.00129364"},
        {"Smithsonian Astrophysical Observation", "SAO 225147"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.83977723),
        dec: Angle.Degrees(-41.02423717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187311"},
        {"Hipparcos Number", "HIP 97680"},
        {"Geneva Identification System", "GEN# +1.00187311"},
        {"Smithsonian Astrophysical Observation", "SAO 229892"},
        {"Wilson Evans Batten Catalogue", "WEB 17180"},
    },
    visualMagnitude: 10.24,
    bvColour: -0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.76958889),
        dec: Angle.Degrees(-41.02322128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109536"},
        {"Hipparcos Number", "HIP 61468"},
        {"Fundamental Katalog 5th Edition", "FK5 3005"},
        {"Geneva Identification System", "GEN# +1.00109536"},
        {"Renson", "Renson 31780"},
        {"Smithsonian Astrophysical Observation", "SAO 223542"},
        {"Wilson Evans Batten Catalogue", "WEB 10939"},
    },
    visualMagnitude: 5.12,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.94006062),
        dec: Angle.Degrees(-41.02194744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98036"},
        {"Hipparcos Number", "HIP 55045"},
        {"Smithsonian Astrophysical Observation", "SAO 222684"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.03182844),
        dec: Angle.Degrees(-41.02162175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6290"},
        {"Hipparcos Number", "HIP 4935"},
        {"Geneva Identification System", "GEN# +1.00006290"},
        {"Smithsonian Astrophysical Observation", "SAO 215346"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.82717938),
        dec: Angle.Degrees(-41.02110416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68367"},
        {"Hipparcos Number", "HIP 40020"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.59914103),
        dec: Angle.Degrees(-41.02110383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120989"},
        {"Hipparcos Number", "HIP 67831"},
    },
    visualMagnitude: 9.48,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.42131121),
        dec: Angle.Degrees(-41.02054318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114164"},
        {"Hipparcos Number", "HIP 64188"},
        {"Smithsonian Astrophysical Observation", "SAO 223935"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.33112790),
        dec: Angle.Degrees(-41.01938817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139022"},
        {"Hipparcos Number", "HIP 76476"},
        {"Fundamental Katalog 5th Edition", "FK5 5380"},
        {"Smithsonian Astrophysical Observation", "SAO 225989"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.29541609),
        dec: Angle.Degrees(-41.01875489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190649"},
        {"Hipparcos Number", "HIP 99139"},
        {"Geneva Identification System", "GEN# +1.00190649"},
        {"Smithsonian Astrophysical Observation", "SAO 230051"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.90394042),
        dec: Angle.Degrees(-41.01864971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -279.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32372"},
        {"Hipparcos Number", "HIP 23316"},
        {"Smithsonian Astrophysical Observation", "SAO 217113"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.21601147),
        dec: Angle.Degrees(-41.01855908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101614"},
        {"Hipparcos Number", "HIP 57021"},
        {"Geneva Identification System", "GEN# +1.00101614"},
        {"Smithsonian Astrophysical Observation", "SAO 222962"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.35880947),
        dec: Angle.Degrees(-41.01795988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 165.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130225"},
        {"Hipparcos Number", "HIP 72398"},
        {"Geneva Identification System", "GEN# +1.00130225"},
        {"Smithsonian Astrophysical Observation", "SAO 225198"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.03770263),
        dec: Angle.Degrees(-41.01713320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89738",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89738"},
    },
    visualMagnitude: 10.67,
    bvColour: 0.833,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.71302692),
        dec: Angle.Degrees(-41.01320631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140617"},
        {"Hipparcos Number", "HIP 77230"},
        {"Geneva Identification System", "GEN# +1.00140617"},
        {"Smithsonian Astrophysical Observation", "SAO 226167"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.53651434),
        dec: Angle.Degrees(-41.01254231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 326941"},
        {"Hipparcos Number", "HIP 83848"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.03197663),
        dec: Angle.Degrees(-41.01252392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120487"},
        {"Hipparcos Number", "HIP 67558"},
        {"Smithsonian Astrophysical Observation", "SAO 224479"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.64811368),
        dec: Angle.Degrees(-41.00836985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12190",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12190"},
        {"Smithsonian Astrophysical Observation", "SAO 130017"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.25432283),
        dec: Angle.Degrees(-09.10211022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 136.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69906"},
        {"Hipparcos Number", "HIP 40612"},
        {"Smithsonian Astrophysical Observation", "SAO 219737"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.37224090),
        dec: Angle.Degrees(-41.00798826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203585"},
        {"Hipparcos Number", "HIP 105696"},
        {"Geneva Identification System", "GEN# +1.00203585"},
        {"Renson", "Renson 56690"},
        {"Smithsonian Astrophysical Observation", "SAO 230667"},
        {"Wilson Evans Batten Catalogue", "WEB 19181"},
    },
    visualMagnitude: 5.76,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.10332831),
        dec: Angle.Degrees(-41.00669489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88139"},
        {"Hipparcos Number", "HIP 49710"},
        {"Smithsonian Astrophysical Observation", "SAO 221804"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.22723600),
        dec: Angle.Degrees(-41.00497161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134233"},
        {"Hipparcos Number", "HIP 74230"},
        {"Smithsonian Astrophysical Observation", "SAO 225502"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.54493935),
        dec: Angle.Degrees(-41.00451686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216363"},
        {"Hipparcos Number", "HIP 112982"},
        {"Geneva Identification System", "GEN# +1.00216363"},
        {"Smithsonian Astrophysical Observation", "SAO 231338"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.20845560),
        dec: Angle.Degrees(-41.00368129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52574"},
        {"Hipparcos Number", "HIP 33683"},
        {"Smithsonian Astrophysical Observation", "SAO 218374"},
    },
    visualMagnitude: 7.02,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.96165426),
        dec: Angle.Degrees(-41.00174203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48904"},
        {"Hipparcos Number", "HIP 32241"},
        {"Smithsonian Astrophysical Observation", "SAO 218160"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.96443661),
        dec: Angle.Degrees(-40.99986096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -139.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5836"},
        {"Hipparcos Number", "HIP 4625"},
        {"Geneva Identification System", "GEN# +1.00005836"},
        {"Smithsonian Astrophysical Observation", "SAO 215314"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.84814916),
        dec: Angle.Degrees(-40.99891306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112287"},
        {"Hipparcos Number", "HIP 63124"},
        {"Smithsonian Astrophysical Observation", "SAO 223766"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.00759174),
        dec: Angle.Degrees(-40.99684968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35287"},
        {"Hipparcos Number", "HIP 25043"},
        {"Geneva Identification System", "GEN# +1.00035287"},
        {"Smithsonian Astrophysical Observation", "SAO 217305"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.43857783),
        dec: Angle.Degrees(-40.99438158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103522",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103522"},
        {"Smithsonian Astrophysical Observation", "SAO 230465"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.59533908),
        dec: Angle.Degrees(-40.99331577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2010"},
        {"Hipparcos Number", "HIP 1911"},
        {"Smithsonian Astrophysical Observation", "SAO 215081"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.04507366),
        dec: Angle.Degrees(-40.99307928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169855"},
        {"Hipparcos Number", "HIP 90545"},
        {"Smithsonian Astrophysical Observation", "SAO 229048"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.13518596),
        dec: Angle.Degrees(-40.99240302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70764"},
        {"Hipparcos Number", "HIP 41006"},
        {"Celescope Catalog", "CEL 2430"},
        {"Smithsonian Astrophysical Observation", "SAO 219839"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.53410265),
        dec: Angle.Degrees(-40.99155748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218544"},
        {"Hipparcos Number", "HIP 114328"},
        {"Smithsonian Astrophysical Observation", "SAO 231460"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.31888651),
        dec: Angle.Degrees(-40.99120045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51684"},
        {"Hipparcos Number", "HIP 33375"},
        {"Geneva Identification System", "GEN# +1.00051684"},
        {"Renson", "Renson 14220"},
        {"Smithsonian Astrophysical Observation", "SAO 218321"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.12457382),
        dec: Angle.Degrees(-40.99031838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112714"},
        {"Hipparcos Number", "HIP 63371"},
        {"Smithsonian Astrophysical Observation", "SAO 223807"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.77926430),
        dec: Angle.Degrees(-40.99027643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129490"},
        {"Hipparcos Number", "HIP 72033"},
        {"Smithsonian Astrophysical Observation", "SAO 225151"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.01816461),
        dec: Angle.Degrees(-40.98946559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59894"},
        {"Hipparcos Number", "HIP 36474"},
        {"Geneva Identification System", "GEN# +1.00059894"},
        {"Smithsonian Astrophysical Observation", "SAO 218764"},
    },
    visualMagnitude: 6.55,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.57739469),
        dec: Angle.Degrees(-40.98917348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192372"},
        {"Hipparcos Number", "HIP 99904"},
        {"Smithsonian Astrophysical Observation", "SAO 230126"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.05017087),
        dec: Angle.Degrees(-40.98800661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208574"},
        {"Hipparcos Number", "HIP 108454"},
        {"Smithsonian Astrophysical Observation", "SAO 230917"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.729,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.55693861),
        dec: Angle.Degrees(-40.98773666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75989"},
        {"Hipparcos Number", "HIP 43528"},
        {"Celescope Catalog", "CEL 3014"},
        {"Geneva Identification System", "GEN# +1.00075989"},
        {"Renson", "Renson 21250"},
        {"Smithsonian Astrophysical Observation", "SAO 220592"},
    },
    visualMagnitude: 6.49,
    bvColour: -0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.98167158),
        dec: Angle.Degrees(-40.98659824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112659"},
        {"Hipparcos Number", "HIP 63335"},
        {"Smithsonian Astrophysical Observation", "SAO 223800"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.67993329),
        dec: Angle.Degrees(-40.98550767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210192"},
        {"Hipparcos Number", "HIP 109383"},
        {"Smithsonian Astrophysical Observation", "SAO 231003"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.39949517),
        dec: Angle.Degrees(-40.98547506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146458"},
        {"Hipparcos Number", "HIP 79866"},
        {"Smithsonian Astrophysical Observation", "SAO 226637"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.54010052),
        dec: Angle.Degrees(-40.98498778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19337"},
        {"Hipparcos Number", "HIP 14361"},
        {"Fundamental Katalog 5th Edition", "FK5 4282"},
        {"Geneva Identification System", "GEN# +1.00019337"},
        {"Smithsonian Astrophysical Observation", "SAO 216162"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.32601199),
        dec: Angle.Degrees(-40.98423390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117917"},
        {"Hipparcos Number", "HIP 66207"},
        {"Smithsonian Astrophysical Observation", "SAO 224252"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.55236925),
        dec: Angle.Degrees(-40.98390182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64825"},
        {"Hipparcos Number", "HIP 38577"},
        {"Celescope Catalog", "CEL 2085"},
        {"Geneva Identification System", "GEN# +1.00064825"},
        {"Smithsonian Astrophysical Observation", "SAO 219116"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.48901096),
        dec: Angle.Degrees(-40.98387005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76111"},
        {"Hipparcos Number", "HIP 43594"},
        {"Smithsonian Astrophysical Observation", "SAO 220603"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.17290040),
        dec: Angle.Degrees(-40.98346669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225043"},
        {"Hipparcos Number", "HIP 222"},
        {"Smithsonian Astrophysical Observation", "SAO 214942"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.69448089),
        dec: Angle.Degrees(-40.98317970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28641"},
        {"Hipparcos Number", "HIP 20925"},
        {"Smithsonian Astrophysical Observation", "SAO 216827"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.712,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.29767408),
        dec: Angle.Degrees(-40.98293447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 324773"},
        {"Hipparcos Number", "HIP 88300"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.48502030),
        dec: Angle.Degrees(-40.98163167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89997"},
        {"Hipparcos Number", "HIP 50813"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.61264656),
        dec: Angle.Degrees(-40.98101322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99908"},
        {"Hipparcos Number", "HIP 56060"},
        {"Smithsonian Astrophysical Observation", "SAO 222816"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.34501874),
        dec: Angle.Degrees(-40.97969227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116103",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116103"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.87591277),
        dec: Angle.Degrees(-40.97891215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207011"},
        {"Hipparcos Number", "HIP 107565"},
        {"Smithsonian Astrophysical Observation", "SAO 230839"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.78908556),
        dec: Angle.Degrees(-40.97680801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26853"},
        {"Hipparcos Number", "HIP 19682"},
        {"Smithsonian Astrophysical Observation", "SAO 216701"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.24850287),
        dec: Angle.Degrees(-40.97639793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102802"},
        {"Hipparcos Number", "HIP 57702"},
        {"Smithsonian Astrophysical Observation", "SAO 223048"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.50829522),
        dec: Angle.Degrees(-40.97570535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45501"},
        {"Hipparcos Number", "HIP 30593"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.44304590),
        dec: Angle.Degrees(-40.97548143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194049"},
        {"Hipparcos Number", "HIP 100706"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.25809795),
        dec: Angle.Degrees(-40.97363106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93316"},
        {"Hipparcos Number", "HIP 52636"},
        {"Smithsonian Astrophysical Observation", "SAO 222305"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.46073526),
        dec: Angle.Degrees(-40.97339245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186832"},
        {"Hipparcos Number", "HIP 97455"},
        {"Geneva Identification System", "GEN# +1.00186832"},
        {"Smithsonian Astrophysical Observation", "SAO 229877"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.12797759),
        dec: Angle.Degrees(-40.97322898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160352"},
        {"Hipparcos Number", "HIP 86557"},
        {"Smithsonian Astrophysical Observation", "SAO 228286"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.32806864),
        dec: Angle.Degrees(-40.97277785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151211"},
        {"Hipparcos Number", "HIP 82227"},
        {"Geneva Identification System", "GEN# +1.00151211"},
        {"Smithsonian Astrophysical Observation", "SAO 227232"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.97257760),
        dec: Angle.Degrees(-40.97272437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196600"},
        {"Hipparcos Number", "HIP 101972"},
        {"Fundamental Katalog 5th Edition", "FK5 5817"},
        {"Geneva Identification System", "GEN# +1.00196600"},
        {"Smithsonian Astrophysical Observation", "SAO 230315"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.97776902),
        dec: Angle.Degrees(-40.97212038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172110"},
        {"Hipparcos Number", "HIP 91551"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.04835049),
        dec: Angle.Degrees(-40.97206882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8283"},
        {"Hipparcos Number", "HIP 6343"},
        {"Smithsonian Astrophysical Observation", "SAO 215471"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.37243833),
        dec: Angle.Degrees(-40.97149953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94983"},
        {"Hipparcos Number", "HIP 53562"},
        {"Renson", "Renson 27390"},
        {"Smithsonian Astrophysical Observation", "SAO 222448"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.35167262),
        dec: Angle.Degrees(-40.96970627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11818"},
        {"Hipparcos Number", "HIP 8932"},
        {"Smithsonian Astrophysical Observation", "SAO 215700"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.74264890),
        dec: Angle.Degrees(-40.96869318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17910"},
        {"Hipparcos Number", "HIP 13293"},
        {"Smithsonian Astrophysical Observation", "SAO 216069"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.77592173),
        dec: Angle.Degrees(-40.96321916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106667"},
        {"Hipparcos Number", "HIP 59826"},
        {"Smithsonian Astrophysical Observation", "SAO 223318"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.02567718),
        dec: Angle.Degrees(-40.96260815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90974"},
        {"Hipparcos Number", "HIP 51357"},
        {"Smithsonian Astrophysical Observation", "SAO 222093"},
    },
    visualMagnitude: 7.52,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.35184434),
        dec: Angle.Degrees(-40.96250285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112766",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112766"},
        {"Geneva Identification System", "GEN# -0.04115048"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.55829301),
        dec: Angle.Degrees(-40.96161046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115836"},
        {"Hipparcos Number", "HIP 65082"},
        {"Smithsonian Astrophysical Observation", "SAO 224071"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.09961058),
        dec: Angle.Degrees(-40.95955917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17461"},
        {"Hipparcos Number", "HIP 12965"},
        {"Geneva Identification System", "GEN# +1.00017461"},
        {"Smithsonian Astrophysical Observation", "SAO 216044"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.68890111),
        dec: Angle.Degrees(-40.95906876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39149"},
        {"Hipparcos Number", "HIP 27437"},
        {"Smithsonian Astrophysical Observation", "SAO 217548"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.14741790),
        dec: Angle.Degrees(-40.95774234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40867"},
        {"Hipparcos Number", "HIP 28382"},
        {"Smithsonian Astrophysical Observation", "SAO 217655"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.93224422),
        dec: Angle.Degrees(-40.95736762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8534"},
        {"Hipparcos Number", "HIP 6515"},
        {"Smithsonian Astrophysical Observation", "SAO 215486"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.91964682),
        dec: Angle.Degrees(-40.95584279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148170"},
        {"Hipparcos Number", "HIP 80653"},
        {"Smithsonian Astrophysical Observation", "SAO 226788"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.99710534),
        dec: Angle.Degrees(-40.95555586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220026"},
        {"Hipparcos Number", "HIP 115274"},
        {"Smithsonian Astrophysical Observation", "SAO 231560"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.21716626),
        dec: Angle.Degrees(-40.95523423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93936"},
        {"Hipparcos Number", "HIP 52971"},
        {"Geneva Identification System", "GEN# +1.00093936"},
        {"Smithsonian Astrophysical Observation", "SAO 222367"},
        {"Wilson Evans Batten Catalogue", "WEB 9636"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.50888493),
        dec: Angle.Degrees(-40.95477604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125284"},
        {"Hipparcos Number", "HIP 70013"},
        {"Smithsonian Astrophysical Observation", "SAO 224836"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.88575222),
        dec: Angle.Degrees(-40.95311822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105834"},
        {"Hipparcos Number", "HIP 59387"},
        {"Smithsonian Astrophysical Observation", "SAO 223265"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.75178770),
        dec: Angle.Degrees(-40.95215188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12617"},
        {"Hipparcos Number", "HIP 9553"},
        {"Geneva Identification System", "GEN# +1.00012617"},
        {"Smithsonian Astrophysical Observation", "SAO 215745"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.68711919),
        dec: Angle.Degrees(-40.95072149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 178.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52852"},
        {"Hipparcos Number", "HIP 33776"},
        {"Smithsonian Astrophysical Observation", "SAO 218384"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.21252248),
        dec: Angle.Degrees(-40.94943938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103974"},
        {"Hipparcos Number", "HIP 58388"},
        {"Geneva Identification System", "GEN# +1.00103974"},
        {"Smithsonian Astrophysical Observation", "SAO 223139"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.58471964),
        dec: Angle.Degrees(-40.94731252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146707"},
        {"Hipparcos Number", "HIP 79970"},
        {"Geneva Identification System", "GEN# +1.00146707"},
        {"Smithsonian Astrophysical Observation", "SAO 226653"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.84593139),
        dec: Angle.Degrees(-40.94411825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36060"},
        {"Hipparcos Number", "HIP 25488"},
        {"Fundamental Katalog 5th Edition", "FK5 1149"},
        {"Geneva Identification System", "GEN# +1.00036060"},
        {"Renson", "Renson 9300"},
        {"Smithsonian Astrophysical Observation", "SAO 217340"},
        {"Wilson Evans Batten Catalogue", "WEB 4945"},
    },
    visualMagnitude: 5.86,
    bvColour: 0.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.77215841),
        dec: Angle.Degrees(-40.94377328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 108.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111855"},
        {"Hipparcos Number", "HIP 62836"},
        {"Smithsonian Astrophysical Observation", "SAO 223727"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.14288420),
        dec: Angle.Degrees(-40.94097194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2724"},
        {"Hipparcos Number", "HIP 2388"},
        {"Geneva Identification System", "GEN# +1.00002724"},
        {"Smithsonian Astrophysical Observation", "SAO 215120"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.61594916),
        dec: Angle.Degrees(-40.93962515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25588"},
        {"Hipparcos Number", "HIP 18822"},
        {"Smithsonian Astrophysical Observation", "SAO 216609"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.50831013),
        dec: Angle.Degrees(-40.93769419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43312",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43312"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.35241363),
        dec: Angle.Degrees(-40.93634148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182631"},
        {"Hipparcos Number", "HIP 95648"},
        {"Smithsonian Astrophysical Observation", "SAO 229685"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.84265303),
        dec: Angle.Degrees(-40.93624510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121701"},
        {"Hipparcos Number", "HIP 68220"},
        {"Smithsonian Astrophysical Observation", "SAO 224576"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.49291404),
        dec: Angle.Degrees(-40.93617730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96724"},
        {"Hipparcos Number", "HIP 54404"},
        {"Smithsonian Astrophysical Observation", "SAO 222588"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.99282365),
        dec: Angle.Degrees(-40.93612473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219088"},
        {"Hipparcos Number", "HIP 114652"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.38288719),
        dec: Angle.Degrees(-40.93582317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62713"},
        {"Hipparcos Number", "HIP 37664"},
        {"Fundamental Katalog 5th Edition", "FK5 2603"},
        {"Geneva Identification System", "GEN# +1.00062713"},
        {"Smithsonian Astrophysical Observation", "SAO 218932"},
        {"Wilson Evans Batten Catalogue", "WEB 7446"},
    },
    visualMagnitude: 5.12,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.92428224),
        dec: Angle.Degrees(-40.93332961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 131.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -171.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37003"},
        {"Hipparcos Number", "HIP 26065"},
        {"Geneva Identification System", "GEN# +1.00037003"},
        {"Smithsonian Astrophysical Observation", "SAO 217398"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.38327418),
        dec: Angle.Degrees(-40.93285822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56262"},
        {"Hipparcos Number", "HIP 35001"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.62265903),
        dec: Angle.Degrees(-40.93264888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133322"},
        {"Hipparcos Number", "HIP 73814"},
    },
    visualMagnitude: 9.99,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.30162201),
        dec: Angle.Degrees(-40.93118034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 130.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186419"},
        {"Hipparcos Number", "HIP 97261"},
        {"Smithsonian Astrophysical Observation", "SAO 229858"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.50655305),
        dec: Angle.Degrees(-40.92750478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136483"},
        {"Hipparcos Number", "HIP 75234"},
        {"Geneva Identification System", "GEN# +1.00136483"},
        {"Smithsonian Astrophysical Observation", "SAO 225707"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.60576902),
        dec: Angle.Degrees(-40.92669280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216641"},
        {"Hipparcos Number", "HIP 113171"},
        {"Smithsonian Astrophysical Observation", "SAO 231351"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.75021036),
        dec: Angle.Degrees(-40.92637364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213515"},
        {"Hipparcos Number", "HIP 111283"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.16490783),
        dec: Angle.Degrees(-40.91735597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46365"},
        {"Hipparcos Number", "HIP 31056"},
        {"Geneva Identification System", "GEN# +1.00046365"},
        {"Smithsonian Astrophysical Observation", "SAO 217986"},
    },
    visualMagnitude: 6.19,
    bvColour: 1.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.74958026),
        dec: Angle.Degrees(-40.91627990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63988"},
        {"Hipparcos Number", "HIP 38224"},
        {"Celescope Catalog", "CEL 2056"},
        {"Geneva Identification System", "GEN# +1.00063988"},
        {"Smithsonian Astrophysical Observation", "SAO 219045"},
    },
    visualMagnitude: 7.08,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.46758300),
        dec: Angle.Degrees(-40.91455936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221883"},
        {"Hipparcos Number", "HIP 116480"},
        {"Smithsonian Astrophysical Observation", "SAO 231684"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.02536485),
        dec: Angle.Degrees(-40.91326281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33453"},
        {"Hipparcos Number", "HIP 23921"},
        {"Geneva Identification System", "GEN# +1.00033453"},
        {"Smithsonian Astrophysical Observation", "SAO 217197"},
    },
    visualMagnitude: 8.04,
    bvColour: -0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.11023108),
        dec: Angle.Degrees(-40.91245427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60608"},
        {"Hipparcos Number", "HIP 36759"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.39576576),
        dec: Angle.Degrees(-40.91165777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35571",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 11.40,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)20, 30.1800),
        dec: Angle.DegreesMinutesSeconds((int)-40, (int)54, 40.300)
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
    primaryId: "HIP 32206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48815"},
        {"Hipparcos Number", "HIP 32206"},
        {"Smithsonian Astrophysical Observation", "SAO 218151"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.83885226),
        dec: Angle.Degrees(-40.90895759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95761"},
        {"Hipparcos Number", "HIP 53982"},
        {"Geneva Identification System", "GEN# +1.00095761"},
        {"Smithsonian Astrophysical Observation", "SAO 222512"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.64558706),
        dec: Angle.Degrees(-40.90821821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32047"},
        {"Hipparcos Number", "HIP 23120"},
        {"Smithsonian Astrophysical Observation", "SAO 217090"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.63273962),
        dec: Angle.Degrees(-40.90713345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192815"},
        {"Hipparcos Number", "HIP 100096"},
        {"Smithsonian Astrophysical Observation", "SAO 230141"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.60117452),
        dec: Angle.Degrees(-40.90559695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192509"},
        {"Hipparcos Number", "HIP 99957"},
        {"Geneva Identification System", "GEN# +1.00192509"},
        {"Smithsonian Astrophysical Observation", "SAO 230131"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.20994701),
        dec: Angle.Degrees(-40.90545896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29176"},
        {"Hipparcos Number", "HIP 21271"},
        {"Smithsonian Astrophysical Observation", "SAO 216873"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.45279152),
        dec: Angle.Degrees(-40.90464878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195284"},
        {"Hipparcos Number", "HIP 101292"},
        {"Smithsonian Astrophysical Observation", "SAO 230257"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.709,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.96945760),
        dec: Angle.Degrees(-40.90138948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -120.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65849"},
        {"Hipparcos Number", "HIP 39007"},
        {"Smithsonian Astrophysical Observation", "SAO 219234"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.74415197),
        dec: Angle.Degrees(-40.90103841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124483"},
        {"Hipparcos Number", "HIP 69625"},
        {"Smithsonian Astrophysical Observation", "SAO 224794"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.75616206),
        dec: Angle.Degrees(-40.90063280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128788"},
        {"Hipparcos Number", "HIP 71708"},
        {"Geneva Identification System", "GEN# +1.00128788"},
        {"Smithsonian Astrophysical Observation", "SAO 225101"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.02094547),
        dec: Angle.Degrees(-40.90060784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86955"},
        {"Hipparcos Number", "HIP 49079"},
        {"Smithsonian Astrophysical Observation", "SAO 221696"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.24998661),
        dec: Angle.Degrees(-40.89873152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136206"},
        {"Hipparcos Number", "HIP 75100"},
        {"Geneva Identification System", "GEN# +1.00136206"},
        {"Smithsonian Astrophysical Observation", "SAO 225680"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.19571935),
        dec: Angle.Degrees(-40.89786309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118379"},
        {"Hipparcos Number", "HIP 66447"},
        {"Smithsonian Astrophysical Observation", "SAO 224281"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.32417610),
        dec: Angle.Degrees(-40.89782765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22664"},
        {"Hipparcos Number", "HIP 16867"},
        {"Smithsonian Astrophysical Observation", "SAO 216404"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.26570373),
        dec: Angle.Degrees(-40.89717430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54475"},
        {"Hipparcos Number", "HIP 34339"},
        {"Celescope Catalog", "CEL 1600"},
        {"Geneva Identification System", "GEN# +1.00054475"},
        {"Smithsonian Astrophysical Observation", "SAO 218465"},
        {"Wilson Evans Batten Catalogue", "WEB 6878"},
    },
    visualMagnitude: 5.80,
    bvColour: -0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.77952459),
        dec: Angle.Degrees(-40.89329560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 547"},
        {"Hipparcos Number", "HIP 791"},
        {"Geneva Identification System", "GEN# +1.00000547"},
        {"Smithsonian Astrophysical Observation", "SAO 214986"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.45189211),
        dec: Angle.Degrees(-40.89264320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 135.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3525"},
        {"Hipparcos Number", "HIP 2984"},
        {"Geneva Identification System", "GEN# +1.00003525"},
        {"Smithsonian Astrophysical Observation", "SAO 215172"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.48922486),
        dec: Angle.Degrees(-40.88964195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149606"},
        {"Hipparcos Number", "HIP 81407"},
        {"Geneva Identification System", "GEN# +1.00149606"},
        {"Smithsonian Astrophysical Observation", "SAO 226972"},
        {"Wilson Evans Batten Catalogue", "WEB 13757"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.40168767),
        dec: Angle.Degrees(-40.88712309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -375.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -384.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209526"},
        {"Hipparcos Number", "HIP 109006"},
        {"Smithsonian Astrophysical Observation", "SAO 230970"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.26079446),
        dec: Angle.Degrees(-40.88358716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123501"},
        {"Hipparcos Number", "HIP 69125"},
        {"Smithsonian Astrophysical Observation", "SAO 224724"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.25122105),
        dec: Angle.Degrees(-40.88268326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44804"},
        {"Hipparcos Number", "HIP 30260"},
        {"Geneva Identification System", "GEN# +1.00044804"},
        {"Smithsonian Astrophysical Observation", "SAO 217882"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.48691731),
        dec: Angle.Degrees(-40.88076027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56892",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56892"},
    },
    visualMagnitude: 11.95,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.94263192),
        dec: Angle.Degrees(-40.87916621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120253"},
        {"Hipparcos Number", "HIP 67424"},
        {"Geneva Identification System", "GEN# +1.00120253"},
        {"Smithsonian Astrophysical Observation", "SAO 224456"},
        {"Wilson Evans Batten Catalogue", "WEB 11860"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.892,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.28405467),
        dec: Angle.Degrees(-40.87889612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -249.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167026"},
        {"Hipparcos Number", "HIP 89442"},
        {"Smithsonian Astrophysical Observation", "SAO 228847"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.81253571),
        dec: Angle.Degrees(-40.87706642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185280"},
        {"Hipparcos Number", "HIP 96766"},
        {"Geneva Identification System", "GEN# +1.00185280"},
        {"Renson", "Renson 51180"},
        {"Smithsonian Astrophysical Observation", "SAO 229807"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.04706740),
        dec: Angle.Degrees(-40.87555938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88569"},
        {"Hipparcos Number", "HIP 49949"},
        {"Smithsonian Astrophysical Observation", "SAO 221849"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.96529567),
        dec: Angle.Degrees(-40.87437671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 327248"},
        {"Hipparcos Number", "HIP 84721"},
    },
    visualMagnitude: 10.63,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.76515689),
        dec: Angle.Degrees(-40.87390643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106304"},
        {"Hipparcos Number", "HIP 59644"},
        {"Geneva Identification System", "GEN# +1.00106304"},
        {"Smithsonian Astrophysical Observation", "SAO 223295"},
        {"Wilson Evans Batten Catalogue", "WEB 10597"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.47345750),
        dec: Angle.Degrees(-40.87323845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158381"},
        {"Hipparcos Number", "HIP 85698"},
        {"Geneva Identification System", "GEN# +1.00158381"},
        {"Smithsonian Astrophysical Observation", "SAO 228054"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.69420575),
        dec: Angle.Degrees(-40.87224658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54918",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54918"},
    },
    visualMagnitude: 11.94,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.69911877),
        dec: Angle.Degrees(-40.87205518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73217"},
        {"Hipparcos Number", "HIP 42163"},
        {"Geneva Identification System", "GEN# +1.00073217"},
        {"Smithsonian Astrophysical Observation", "SAO 220157"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.93250831),
        dec: Angle.Degrees(-40.86836410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13387"},
        {"Hipparcos Number", "HIP 10096"},
        {"Geneva Identification System", "GEN# +1.00013387"},
        {"Smithsonian Astrophysical Observation", "SAO 215793"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.45179984),
        dec: Angle.Degrees(-40.86644598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86976"},
        {"Hipparcos Number", "HIP 49084"},
        {"Geneva Identification System", "GEN# +1.00086976"},
        {"Renson", "Renson 24850"},
        {"Smithsonian Astrophysical Observation", "SAO 221697"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.26555355),
        dec: Angle.Degrees(-40.86641816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102903"},
        {"Hipparcos Number", "HIP 57764"},
        {"Smithsonian Astrophysical Observation", "SAO 223054"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.68627972),
        dec: Angle.Degrees(-40.86569166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143022"},
        {"Hipparcos Number", "HIP 78324"},
        {"Geneva Identification System", "GEN# +1.00143022"},
        {"Smithsonian Astrophysical Observation", "SAO 226427"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.87872590),
        dec: Angle.Degrees(-40.86511630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87731"},
        {"Hipparcos Number", "HIP 49470"},
        {"Smithsonian Astrophysical Observation", "SAO 221769"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.919,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.50010231),
        dec: Angle.Degrees(-40.86480046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61891",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61891"},
    },
    visualMagnitude: 11.22,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.23838325),
        dec: Angle.Degrees(-40.86190433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124961"},
        {"Hipparcos Number", "HIP 69845"},
        {"Geneva Identification System", "GEN# +1.00124961"},
        {"Smithsonian Astrophysical Observation", "SAO 224822"},
    },
    visualMagnitude: 7.87,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.41346409),
        dec: Angle.Degrees(-40.86168067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133220"},
        {"Hipparcos Number", "HIP 73764"},
        {"Geneva Identification System", "GEN# +1.00133220"},
        {"Smithsonian Astrophysical Observation", "SAO 225422"},
    },
    visualMagnitude: 6.29,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.17875658),
        dec: Angle.Degrees(-40.86124206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197094"},
        {"Hipparcos Number", "HIP 102227"},
        {"Smithsonian Astrophysical Observation", "SAO 230334"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.70969470),
        dec: Angle.Degrees(-40.86055137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85369"},
        {"Hipparcos Number", "HIP 48262"},
        {"Smithsonian Astrophysical Observation", "SAO 221529"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.58061108),
        dec: Angle.Degrees(-40.85974750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161378"},
        {"Hipparcos Number", "HIP 87040"},
        {"Celescope Catalog", "CEL 4566"},
        {"Geneva Identification System", "GEN# +1.00161378"},
        {"Smithsonian Astrophysical Observation", "SAO 228410"},
    },
    visualMagnitude: 7.91,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.77506406),
        dec: Angle.Degrees(-40.85936192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64901"},
        {"Hipparcos Number", "HIP 38610"},
        {"Celescope Catalog", "CEL 2091"},
        {"Geneva Identification System", "GEN# +1.00064901"},
        {"Renson", "Renson 17810"},
        {"Smithsonian Astrophysical Observation", "SAO 219128"},
    },
    visualMagnitude: 8.55,
    bvColour: -0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.59190333),
        dec: Angle.Degrees(-40.85739382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121528"},
        {"Hipparcos Number", "HIP 68127"},
        {"Geneva Identification System", "GEN# +1.00121528"},
        {"Smithsonian Astrophysical Observation", "SAO 224563"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.20254636),
        dec: Angle.Degrees(-40.85662862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84977"},
        {"Hipparcos Number", "HIP 48053"},
        {"Smithsonian Astrophysical Observation", "SAO 221493"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.93208782),
        dec: Angle.Degrees(-40.85482865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27254"},
        {"Hipparcos Number", "HIP 19929"},
        {"Smithsonian Astrophysical Observation", "SAO 216729"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.13538975),
        dec: Angle.Degrees(-40.85380764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9142"},
        {"Hipparcos Number", "HIP 6928"},
        {"Geneva Identification System", "GEN# +1.00009142"},
        {"Smithsonian Astrophysical Observation", "SAO 215520"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.31597375),
        dec: Angle.Degrees(-40.85220817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113388"},
        {"Hipparcos Number", "HIP 63740"},
        {"Smithsonian Astrophysical Observation", "SAO 223874"},
    },
    visualMagnitude: 6.93,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.94741012),
        dec: Angle.Degrees(-40.85115544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70194"},
        {"Hipparcos Number", "HIP 40746"},
        {"Smithsonian Astrophysical Observation", "SAO 219778"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.76491639),
        dec: Angle.Degrees(-40.85007679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154644"},
        {"Hipparcos Number", "HIP 83879"},
        {"Smithsonian Astrophysical Observation", "SAO 227668"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.16073471),
        dec: Angle.Degrees(-40.84984323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108144"},
        {"Hipparcos Number", "HIP 60630"},
        {"Geneva Identification System", "GEN# +1.00108144"},
        {"Smithsonian Astrophysical Observation", "SAO 223430"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.38971181),
        dec: Angle.Degrees(-40.84841307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -234.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 159.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9192"},
        {"Hipparcos Number", "HIP 6973"},
        {"Geneva Identification System", "GEN# +1.00009192"},
        {"Smithsonian Astrophysical Observation", "SAO 215527"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.44207876),
        dec: Angle.Degrees(-40.84619295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 176.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221549"},
        {"Hipparcos Number", "HIP 116241"},
        {"Smithsonian Astrophysical Observation", "SAO 231659"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.29958100),
        dec: Angle.Degrees(-40.84537570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127152"},
        {"Hipparcos Number", "HIP 70966"},
        {"Geneva Identification System", "GEN# +1.00127152"},
        {"Smithsonian Astrophysical Observation", "SAO 224982"},
    },
    visualMagnitude: 6.39,
    bvColour: 1.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.73594786),
        dec: Angle.Degrees(-40.84511153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14681"},
        {"Hipparcos Number", "HIP 10948"},
        {"Smithsonian Astrophysical Observation", "SAO 215868"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.25339233),
        dec: Angle.Degrees(-40.84330605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182946"},
        {"Hipparcos Number", "HIP 95789"},
        {"Geneva Identification System", "GEN# +1.00182946"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.24730206),
        dec: Angle.Degrees(-40.84262586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140421"},
        {"Hipparcos Number", "HIP 77144"},
        {"Smithsonian Astrophysical Observation", "SAO 226147"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.25769324),
        dec: Angle.Degrees(-40.84186362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128819"},
        {"Hipparcos Number", "HIP 71724"},
        {"Geneva Identification System", "GEN# +1.00128819J"},
        {"Smithsonian Astrophysical Observation", "SAO 225106"},
    },
    visualMagnitude: 6.65,
    bvColour: -0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.07358197),
        dec: Angle.Degrees(-40.84164159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15064"},
        {"Hipparcos Number", "HIP 11231"},
        {"Geneva Identification System", "GEN# +1.00015064"},
        {"Smithsonian Astrophysical Observation", "SAO 215892"},
        {"Wilson Evans Batten Catalogue", "WEB 2353"},
    },
    visualMagnitude: 6.17,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.14044388),
        dec: Angle.Degrees(-40.84072432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 228.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 109.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150742"},
        {"Hipparcos Number", "HIP 81972"},
        {"Celescope Catalog", "CEL 4424"},
        {"Fundamental Katalog 5th Edition", "FK5 3329"},
        {"Geneva Identification System", "GEN# +1.00150742J"},
        {"Smithsonian Astrophysical Observation", "SAO 227146"},
        {"Wilson Evans Batten Catalogue", "WEB 13840"},
    },
    visualMagnitude: 5.64,
    bvColour: -0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.17750890),
        dec: Angle.Degrees(-40.83962254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107185"},
        {"Hipparcos Number", "HIP 60103"},
        {"Smithsonian Astrophysical Observation", "SAO 223352"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.88777197),
        dec: Angle.Degrees(-40.83904808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67425",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67425"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.28423724),
        dec: Angle.Degrees(-40.83788987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148674"},
        {"Hipparcos Number", "HIP 80928"},
        {"Smithsonian Astrophysical Observation", "SAO 226848"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.87749954),
        dec: Angle.Degrees(-40.83724125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77957"},
        {"Hipparcos Number", "HIP 44522"},
        {"Smithsonian Astrophysical Observation", "SAO 220801"},
    },
    visualMagnitude: 9.32,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.06627981),
        dec: Angle.Degrees(-40.83591254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120411"},
        {"Hipparcos Number", "HIP 67522"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.52625866),
        dec: Angle.Degrees(-40.83574600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182776"},
        {"Hipparcos Number", "HIP 95714"},
        {"Smithsonian Astrophysical Observation", "SAO 229695"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.02311075),
        dec: Angle.Degrees(-40.83467648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193869"},
        {"Hipparcos Number", "HIP 100604"},
        {"Smithsonian Astrophysical Observation", "SAO 230187"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.01378985),
        dec: Angle.Degrees(-40.83357737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124176"},
        {"Hipparcos Number", "HIP 69429"},
        {"Geneva Identification System", "GEN# +1.00124176"},
        {"Smithsonian Astrophysical Observation", "SAO 224767"},
    },
    visualMagnitude: 6.75,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.22964186),
        dec: Angle.Degrees(-40.83346650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29253"},
        {"Hipparcos Number", "HIP 21320"},
        {"Smithsonian Astrophysical Observation", "SAO 216878"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.65129119),
        dec: Angle.Degrees(-40.83296991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9732"},
        {"Hipparcos Number", "HIP 7336"},
        {"Smithsonian Astrophysical Observation", "SAO 215568"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.62331713),
        dec: Angle.Degrees(-40.83153542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223677"},
        {"Hipparcos Number", "HIP 117659"},
        {"Smithsonian Astrophysical Observation", "SAO 231814"},
    },
    visualMagnitude: 6.65,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.92937984),
        dec: Angle.Degrees(-40.82752849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69253"},
        {"Hipparcos Number", "HIP 40366"},
        {"Celescope Catalog", "CEL 2269"},
        {"Geneva Identification System", "GEN# +1.00069253"},
        {"Smithsonian Astrophysical Observation", "SAO 219651"},
        {"Wilson Evans Batten Catalogue", "WEB 7872"},
    },
    visualMagnitude: 6.62,
    bvColour: -0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.62358673),
        dec: Angle.Degrees(-40.82588088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86211"},
        {"Hipparcos Number", "HIP 48706"},
        {"Fundamental Katalog 5th Edition", "FK5 2795"},
        {"Geneva Identification System", "GEN# +1.00086211"},
        {"Smithsonian Astrophysical Observation", "SAO 221617"},
    },
    visualMagnitude: 6.39,
    bvColour: 1.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.02229845),
        dec: Angle.Degrees(-40.82450401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219693"},
        {"Hipparcos Number", "HIP 115054"},
        {"Geneva Identification System", "GEN# +1.00219693"},
        {"Smithsonian Astrophysical Observation", "SAO 231539"},
        {"Wilson Evans Batten Catalogue", "WEB 20383"},
    },
    visualMagnitude: 5.54,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.54077554),
        dec: Angle.Degrees(-40.82406346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 127.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82911",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "OAO 1653-40"},
        {"Henry Draper", "HD 152667"},
        {"Hipparcos Number", "HIP 82911"},
        {"Celescope Catalog", "CEL 4461"},
        {"Geneva Identification System", "GEN# +1.00152667"},
        {"Smithsonian Astrophysical Observation", "SAO 227473"},
        {"Wilson Evans Batten Catalogue", "WEB 14017"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.14990852),
        dec: Angle.Degrees(-40.82345259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83812"},
        {"Hipparcos Number", "HIP 47428"},
        {"Smithsonian Astrophysical Observation", "SAO 221382"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.94823098),
        dec: Angle.Degrees(-40.82260303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174844"},
        {"Hipparcos Number", "HIP 92777"},
        {"Smithsonian Astrophysical Observation", "SAO 229360"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.58681875),
        dec: Angle.Degrees(-40.82247861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139900"},
        {"Hipparcos Number", "HIP 76907"},
        {"Geneva Identification System", "GEN# +1.00139900"},
        {"Smithsonian Astrophysical Observation", "SAO 226086"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.775,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.56267256),
        dec: Angle.Degrees(-40.82226597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -169.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -154.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146817"},
        {"Hipparcos Number", "HIP 80013"},
        {"Geneva Identification System", "GEN# +1.00146817"},
        {"Smithsonian Astrophysical Observation", "SAO 226665"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.99816843),
        dec: Angle.Degrees(-40.81795585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185186"},
        {"Hipparcos Number", "HIP 96703"},
        {"Smithsonian Astrophysical Observation", "SAO 229801"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.88948916),
        dec: Angle.Degrees(-40.81747610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217841"},
        {"Hipparcos Number", "HIP 113899"},
        {"Smithsonian Astrophysical Observation", "SAO 231418"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.99568320),
        dec: Angle.Degrees(-40.81739973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217807"},
        {"Hipparcos Number", "HIP 113877"},
        {"Smithsonian Astrophysical Observation", "SAO 231415"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.92702122),
        dec: Angle.Degrees(-40.81703852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31605"},
        {"Hipparcos Number", "HIP 22882"},
        {"Smithsonian Astrophysical Observation", "SAO 217065"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.83072008),
        dec: Angle.Degrees(-40.81614491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180750"},
        {"Hipparcos Number", "HIP 94980"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.91236416),
        dec: Angle.Degrees(-40.81570027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122373"},
        {"Hipparcos Number", "HIP 68591"},
        {"Smithsonian Astrophysical Observation", "SAO 224628"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.62549875),
        dec: Angle.Degrees(-40.81529842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105053"},
        {"Hipparcos Number", "HIP 58991"},
        {"Fundamental Katalog 5th Edition", "FK5 5067"},
        {"Smithsonian Astrophysical Observation", "SAO 223212"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.848,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.42821097),
        dec: Angle.Degrees(-40.81455208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189388"},
        {"Hipparcos Number", "HIP 98579"},
        {"Geneva Identification System", "GEN# +1.00189388"},
        {"Smithsonian Astrophysical Observation", "SAO 229993"},
    },
    visualMagnitude: 6.31,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.36149409),
        dec: Angle.Degrees(-40.81423965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159654"},
        {"Hipparcos Number", "HIP 86269"},
        {"Geneva Identification System", "GEN# +1.00159654"},
        {"Smithsonian Astrophysical Observation", "SAO 228211"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.702,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.40651039),
        dec: Angle.Degrees(-40.81353702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187954"},
        {"Hipparcos Number", "HIP 97947"},
        {"Smithsonian Astrophysical Observation", "SAO 229921"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.57844465),
        dec: Angle.Degrees(-40.81304027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109749"},
        {"Henry Draper 2", "HD 109749A"},
        {"Hipparcos Number", "HIP 61595"},
        {"Geneva Identification System", "GEN# +1.00109749"},
        {"Smithsonian Astrophysical Observation", "SAO 223556"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.31874900),
        dec: Angle.Degrees(-40.81210314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -157.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91292"},
        {"Hipparcos Number", "HIP 51541"},
        {"Smithsonian Astrophysical Observation", "SAO 222118"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.90775833),
        dec: Angle.Degrees(-40.81097431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203006"},
        {"Hipparcos Number", "HIP 105382"},
        {"Fundamental Katalog 5th Edition", "FK5 802"},
        {"Geneva Identification System", "GEN# +1.00203006"},
        {"Renson", "Renson 56550"},
        {"Smithsonian Astrophysical Observation", "SAO 230644"},
        {"Wilson Evans Batten Catalogue", "WEB 19139"},
    },
    visualMagnitude: 4.80,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.18993153),
        dec: Angle.Degrees(-40.80950852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13312",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13312"},
        {"Smithsonian Astrophysical Observation", "SAO 216071"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.83242361),
        dec: Angle.Degrees(-40.80930272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130903"},
        {"Hipparcos Number", "HIP 72710"},
        {"Geneva Identification System", "GEN# +1.00130903"},
        {"Smithsonian Astrophysical Observation", "SAO 225253"},
    },
    visualMagnitude: 7.94,
    bvColour: -0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.99006114),
        dec: Angle.Degrees(-40.80582504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189104"},
        {"Hipparcos Number", "HIP 98432"},
        {"Geneva Identification System", "GEN# +1.00189104"},
        {"Smithsonian Astrophysical Observation", "SAO 229970"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.99753622),
        dec: Angle.Degrees(-40.80577008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61711"},
        {"Hipparcos Number", "HIP 37241"},
        {"Smithsonian Astrophysical Observation", "SAO 218859"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.72472669),
        dec: Angle.Degrees(-40.80572359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 324318"},
        {"Hipparcos Number", "HIP 86914"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.38841258),
        dec: Angle.Degrees(-40.80362928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -212.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -202.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171545"},
        {"Hipparcos Number", "HIP 91292"},
        {"Fundamental Katalog 5th Edition", "FK5 5637"},
        {"Smithsonian Astrophysical Observation", "SAO 229150"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.31530279),
        dec: Angle.Degrees(-40.80357114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68197",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68197"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.43328577),
        dec: Angle.Degrees(-40.80039632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172756"},
        {"Hipparcos Number", "HIP 91874"},
        {"Smithsonian Astrophysical Observation", "SAO 229229"},
    },
    visualMagnitude: 7.96,
    bvColour: -0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.94527737),
        dec: Angle.Degrees(-40.79949244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19976",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19976"},
    },
    visualMagnitude: 10.48,
    bvColour: 1.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.25762234),
        dec: Angle.Degrees(-40.79907627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 244.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 79.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117574",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117574"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.65881406),
        dec: Angle.Degrees(-40.79761951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126402"},
        {"Hipparcos Number", "HIP 70586"},
        {"Smithsonian Astrophysical Observation", "SAO 224924"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.58276279),
        dec: Angle.Degrees(-40.79759496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194184"},
        {"Hipparcos Number", "HIP 100764"},
        {"Geneva Identification System", "GEN# +1.00194184"},
        {"Smithsonian Astrophysical Observation", "SAO 230197"},
        {"Wilson Evans Batten Catalogue", "WEB 18211"},
    },
    visualMagnitude: 6.08,
    bvColour: 1.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.45003566),
        dec: Angle.Degrees(-40.79597302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52899"},
        {"Hipparcos Number", "HIP 33803"},
        {"Celescope Catalog", "CEL 1514"},
        {"Geneva Identification System", "GEN# +1.00052899"},
        {"Smithsonian Astrophysical Observation", "SAO 218385"},
    },
    visualMagnitude: 7.36,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.27363377),
        dec: Angle.Degrees(-40.79497408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39795"},
        {"Hipparcos Number", "HIP 27790"},
        {"Smithsonian Astrophysical Observation", "SAO 217593"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.21154501),
        dec: Angle.Degrees(-40.79043181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128320"},
        {"Hipparcos Number", "HIP 71506"},
        {"Smithsonian Astrophysical Observation", "SAO 225066"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.34829394),
        dec: Angle.Degrees(-40.78937477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135876"},
        {"Hipparcos Number", "HIP 74950"},
        {"Celescope Catalog", "CEL 4362"},
        {"Geneva Identification System", "GEN# +1.00135876"},
        {"Smithsonian Astrophysical Observation", "SAO 225647"},
        {"Wilson Evans Batten Catalogue", "WEB 12787"},
    },
    visualMagnitude: 5.59,
    bvColour: -0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.73495651),
        dec: Angle.Degrees(-40.78816875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64758"},
        {"Hipparcos Number", "HIP 38552"},
        {"Smithsonian Astrophysical Observation", "SAO 219113"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.41262590),
        dec: Angle.Degrees(-40.78741602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86249"},
        {"Hipparcos Number", "HIP 48718"},
        {"Geneva Identification System", "GEN# +1.00086249"},
        {"Wilson Evans Batten Catalogue", "WEB 9059"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.05256351),
        dec: Angle.Degrees(-40.78679446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -141.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142384"},
        {"Hipparcos Number", "HIP 78027"},
        {"Smithsonian Astrophysical Observation", "SAO 226374"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.98524012),
        dec: Angle.Degrees(-40.78639582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71489"},
        {"Hipparcos Number", "HIP 41347"},
        {"Smithsonian Astrophysical Observation", "SAO 219913"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.53543757),
        dec: Angle.Degrees(-40.78627247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65638"},
        {"Hipparcos Number", "HIP 38925"},
        {"Smithsonian Astrophysical Observation", "SAO 219210"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.47829592),
        dec: Angle.Degrees(-40.78436106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179118"},
        {"Hipparcos Number", "HIP 94420"},
        {"Smithsonian Astrophysical Observation", "SAO 229557"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.26909660),
        dec: Angle.Degrees(-40.78397633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198753"},
        {"Hipparcos Number", "HIP 103142"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.807,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.46781658),
        dec: Angle.Degrees(-40.78373753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -130.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81017"},
        {"Hipparcos Number", "HIP 45926"},
        {"Smithsonian Astrophysical Observation", "SAO 221101"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.46555531),
        dec: Angle.Degrees(-40.77862635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182668"},
        {"Hipparcos Number", "HIP 95667"},
        {"Smithsonian Astrophysical Observation", "SAO 229688"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.89293063),
        dec: Angle.Degrees(-40.77854406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64521"},
        {"Hipparcos Number", "HIP 38448"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.14959724),
        dec: Angle.Degrees(-40.77762514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111403"},
        {"Hipparcos Number", "HIP 62580"},
        {"Smithsonian Astrophysical Observation", "SAO 223688"},
    },
    visualMagnitude: 6.89,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.34363326),
        dec: Angle.Degrees(-40.77528615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73460"},
        {"Hipparcos Number", "HIP 42262"},
        {"Celescope Catalog", "CEL 2705"},
        {"Geneva Identification System", "GEN# +1.00073460"},
        {"Smithsonian Astrophysical Observation", "SAO 220184"},
    },
    visualMagnitude: 8.75,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.26432078),
        dec: Angle.Degrees(-40.77516566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147434"},
        {"Hipparcos Number", "HIP 80308"},
        {"Geneva Identification System", "GEN# +2.61240005"},
        {"New General Catalogue", "NGC 6124 5"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.94209119),
        dec: Angle.Degrees(-40.77511469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173181"},
        {"Hipparcos Number", "HIP 92063"},
        {"Smithsonian Astrophysical Observation", "SAO 229254"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.46543932),
        dec: Angle.Degrees(-40.77314904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162189"},
        {"Hipparcos Number", "HIP 87390"},
        {"Geneva Identification System", "GEN# +1.00162189"},
        {"Smithsonian Astrophysical Observation", "SAO 228489"},
    },
    visualMagnitude: 5.94,
    bvColour: 1.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.88572115),
        dec: Angle.Degrees(-40.77232768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47537"},
        {"Hipparcos Number", "HIP 31636"},
        {"Smithsonian Astrophysical Observation", "SAO 218063"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.30652024),
        dec: Angle.Degrees(-40.77059636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23136"},
        {"Hipparcos Number", "HIP 17204"},
        {"Smithsonian Astrophysical Observation", "SAO 216439"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.28926364),
        dec: Angle.Degrees(-40.76839495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215317"},
        {"Hipparcos Number", "HIP 112301"},
        {"Smithsonian Astrophysical Observation", "SAO 231272"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.20505952),
        dec: Angle.Degrees(-40.76799467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168124"},
        {"Hipparcos Number", "HIP 89843"},
        {"Smithsonian Astrophysical Observation", "SAO 228920"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.772,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.01570323),
        dec: Angle.Degrees(-40.76614770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170589"},
        {"Hipparcos Number", "HIP 90856"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.01817565),
        dec: Angle.Degrees(-40.76580295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159109"},
        {"Hipparcos Number", "HIP 86010"},
        {"Smithsonian Astrophysical Observation", "SAO 228144"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.67440821),
        dec: Angle.Degrees(-40.76499628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81171"},
        {"Hipparcos Number", "HIP 45996"},
        {"Geneva Identification System", "GEN# +1.00081171"},
        {"Smithsonian Astrophysical Observation", "SAO 221114"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.70785477),
        dec: Angle.Degrees(-40.76494940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35246"},
        {"Hipparcos Number", "HIP 25021"},
        {"Smithsonian Astrophysical Observation", "SAO 217300"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.35948104),
        dec: Angle.Degrees(-40.76427782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86050"},
        {"Hipparcos Number", "HIP 48637"},
        {"Geneva Identification System", "GEN# +1.00086050"},
        {"Smithsonian Astrophysical Observation", "SAO 221601"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.76070229),
        dec: Angle.Degrees(-40.75957546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -305.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 128.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64947",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64947"},
    },
    visualMagnitude: 10.59,
    bvColour: 0.729,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.69492428),
        dec: Angle.Degrees(-40.75944853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -236.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68512"},
        {"Hipparcos Number", "HIP 40070"},
        {"Smithsonian Astrophysical Observation", "SAO 219552"},
    },
    visualMagnitude: 6.69,
    bvColour: 1.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.78098721),
        dec: Angle.Degrees(-40.75835072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110090"},
        {"Hipparcos Number", "HIP 61807"},
        {"Smithsonian Astrophysical Observation", "SAO 223584"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.00578436),
        dec: Angle.Degrees(-40.75683231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193437"},
        {"Hipparcos Number", "HIP 100422"},
        {"Smithsonian Astrophysical Observation", "SAO 230169"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.45023091),
        dec: Angle.Degrees(-40.75561443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126135"},
        {"Hipparcos Number", "HIP 70455"},
        {"Geneva Identification System", "GEN# +1.00126135"},
        {"Smithsonian Astrophysical Observation", "SAO 224905"},
    },
    visualMagnitude: 6.97,
    bvColour: -0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.18305122),
        dec: Angle.Degrees(-40.75511231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27053"},
        {"Hipparcos Number", "HIP 19806"},
        {"Smithsonian Astrophysical Observation", "SAO 216719"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.70596396),
        dec: Angle.Degrees(-40.75467710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112587",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112587"},
    },
    visualMagnitude: 10.63,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.04056612),
        dec: Angle.Degrees(-40.75378757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49557"},
        {"Hipparcos Number", "HIP 32505"},
        {"Smithsonian Astrophysical Observation", "SAO 218188"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.75730483),
        dec: Angle.Degrees(-40.75368303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19209",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19209"},
    },
    visualMagnitude: 10.94,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.76546103),
        dec: Angle.Degrees(-40.75334675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 320.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 323432"},
        {"Hipparcos Number", "HIP 85167"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.07203129),
        dec: Angle.Degrees(-40.75304757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65966"},
        {"Hipparcos Number", "HIP 39066"},
        {"Smithsonian Astrophysical Observation", "SAO 219252"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.89286567),
        dec: Angle.Degrees(-40.75260855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136334"},
        {"Hipparcos Number", "HIP 75164"},
        {"Geneva Identification System", "GEN# +1.00136334"},
        {"Smithsonian Astrophysical Observation", "SAO 225695"},
    },
    visualMagnitude: 6.21,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.39714378),
        dec: Angle.Degrees(-40.74941653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131418"},
        {"Hipparcos Number", "HIP 72975"},
        {"Smithsonian Astrophysical Observation", "SAO 225288"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.70379860),
        dec: Angle.Degrees(-40.74726632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71216"},
        {"Hipparcos Number", "HIP 41212"},
        {"Celescope Catalog", "CEL 2476"},
        {"Geneva Identification System", "GEN# +1.00071216"},
        {"Smithsonian Astrophysical Observation", "SAO 219883"},
        {"Wilson Evans Batten Catalogue", "WEB 7976"},
    },
    visualMagnitude: 7.11,
    bvColour: -0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.14702662),
        dec: Angle.Degrees(-40.74703442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158128"},
        {"Hipparcos Number", "HIP 85574"},
        {"Geneva Identification System", "GEN# +1.00158128"},
        {"Renson", "Renson 44450"},
        {"Smithsonian Astrophysical Observation", "SAO 228017"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.31509094),
        dec: Angle.Degrees(-40.74686953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16475"},
        {"Hipparcos Number", "HIP 12215"},
        {"Geneva Identification System", "GEN# +1.00016475"},
        {"Smithsonian Astrophysical Observation", "SAO 215967"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.32422051),
        dec: Angle.Degrees(-40.74662884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102136"},
        {"Hipparcos Number", "HIP 57321"},
        {"Geneva Identification System", "GEN# +1.00102136"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.779,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.29793766),
        dec: Angle.Degrees(-40.74606206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -151.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36415"},
        {"Hipparcos Number", "HIP 25728"},
        {"Smithsonian Astrophysical Observation", "SAO 217360"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.40677367),
        dec: Angle.Degrees(-40.74286210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67528"},
        {"Hipparcos Number", "HIP 39696"},
        {"Geneva Identification System", "GEN# +1.00067528"},
        {"Smithsonian Astrophysical Observation", "SAO 219421"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.69723432),
        dec: Angle.Degrees(-40.74258188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17323"},
        {"Hipparcos Number", "HIP 12875"},
        {"Geneva Identification System", "GEN# +1.00017323"},
        {"Smithsonian Astrophysical Observation", "SAO 216037"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.38514345),
        dec: Angle.Degrees(-40.74188846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179138"},
        {"Hipparcos Number", "HIP 94431"},
        {"Smithsonian Astrophysical Observation", "SAO 229559"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.30158688),
        dec: Angle.Degrees(-40.74131204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221928"},
        {"Hipparcos Number", "HIP 116504"},
        {"Smithsonian Astrophysical Observation", "SAO 231691"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.12166348),
        dec: Angle.Degrees(-40.73904452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63117"},
        {"Hipparcos Number", "HIP 37841"},
        {"Smithsonian Astrophysical Observation", "SAO 218960"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.36793080),
        dec: Angle.Degrees(-40.73885645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143941"},
        {"Hipparcos Number", "HIP 78765"},
        {"Smithsonian Astrophysical Observation", "SAO 226488"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.761,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.21146722),
        dec: Angle.Degrees(-40.73765213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65315"},
        {"Hipparcos Number", "HIP 38795"},
        {"Celescope Catalog", "CEL 2106"},
        {"Geneva Identification System", "GEN# +1.00065315"},
        {"Smithsonian Astrophysical Observation", "SAO 219169"},
        {"Wilson Evans Batten Catalogue", "WEB 7600"},
    },
    visualMagnitude: 6.78,
    bvColour: -0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.10055412),
        dec: Angle.Degrees(-40.73618197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20240",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20240"},
        {"Geneva Identification System", "GEN# -0.00900872"},
    },
    visualMagnitude: 9.81,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.05948337),
        dec: Angle.Degrees(-09.03704071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42753"},
        {"Hipparcos Number", "HIP 29289"},
        {"Smithsonian Astrophysical Observation", "SAO 217756"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.62675371),
        dec: Angle.Degrees(-40.73491320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144119"},
        {"Hipparcos Number", "HIP 78860"},
        {"Smithsonian Astrophysical Observation", "SAO 226498"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.46887645),
        dec: Angle.Degrees(-40.73408419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137598"},
        {"Hipparcos Number", "HIP 75749"},
        {"Smithsonian Astrophysical Observation", "SAO 225819"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.12288682),
        dec: Angle.Degrees(-40.73346735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16717"},
        {"Hipparcos Number", "HIP 12385"},
        {"Geneva Identification System", "GEN# +1.00016717"},
        {"Smithsonian Astrophysical Observation", "SAO 215992"},
        {"Wilson Evans Batten Catalogue", "WEB 2536"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.86015819),
        dec: Angle.Degrees(-40.73338542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54953",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54953"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.80581894),
        dec: Angle.Degrees(-40.73277111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168980"},
        {"Hipparcos Number", "HIP 90201"},
        {"Smithsonian Astrophysical Observation", "SAO 228986"},
    },
    visualMagnitude: 8.31,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.07688287),
        dec: Angle.Degrees(-40.73202540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12387"},
        {"Hipparcos Number", "HIP 9381"},
        {"Cincinnati Publication", "Ci 20 139"},
        {"Cincinnati Publication 2", "Ci 18 268"},
        {"Geneva Identification System", "GEN# +1.00012387"},
        {"Smithsonian Astrophysical Observation", "SAO 215734"},
        {"Wilson Evans Batten Catalogue", "WEB 1970"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.13244282),
        dec: Angle.Degrees(-40.73020092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 440.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -430.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117561"},
        {"Hipparcos Number", "HIP 65996"},
        {"Smithsonian Astrophysical Observation", "SAO 224223"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.96356093),
        dec: Angle.Degrees(-40.72957984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161252"},
        {"Hipparcos Number", "HIP 86965"},
        {"Geneva Identification System", "GEN# +1.00161252"},
        {"Smithsonian Astrophysical Observation", "SAO 228395"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.57296905),
        dec: Angle.Degrees(-40.72911575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -189.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3033"},
        {"Hipparcos Number", "HIP 2631"},
        {"Geneva Identification System", "GEN# +1.00003033"},
        {"Smithsonian Astrophysical Observation", "SAO 215141"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.34923893),
        dec: Angle.Degrees(-40.72858921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163744"},
        {"Hipparcos Number", "HIP 88098"},
        {"Smithsonian Astrophysical Observation", "SAO 228604"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.88856748),
        dec: Angle.Degrees(-40.72851856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127649"},
        {"Hipparcos Number", "HIP 71198"},
        {"Fundamental Katalog 5th Edition", "FK5 5288"},
        {"Geneva Identification System", "GEN# +1.00127649"},
        {"Smithsonian Astrophysical Observation", "SAO 225021"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.41943635),
        dec: Angle.Degrees(-40.72820369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36877",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36877"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.71727677),
        dec: Angle.Degrees(-40.72781533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12268"},
        {"Hipparcos Number", "HIP 9296"},
        {"Geneva Identification System", "GEN# +1.00012268"},
        {"Smithsonian Astrophysical Observation", "SAO 215725"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.928,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.85868414),
        dec: Angle.Degrees(-40.72713927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55754",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55754"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.35952428),
        dec: Angle.Degrees(-40.72657322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195567"},
        {"Hipparcos Number", "HIP 101450"},
        {"Smithsonian Astrophysical Observation", "SAO 230272"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.782,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.41206463),
        dec: Angle.Degrees(-40.72601521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18708"},
        {"Hipparcos Number", "HIP 13908"},
        {"Geneva Identification System", "GEN# +1.00018708"},
        {"Smithsonian Astrophysical Observation", "SAO 216122"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.78385816),
        dec: Angle.Degrees(-40.72336251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151965"},
        {"Hipparcos Number", "HIP 82554"},
        {"Celescope Catalog", "CEL 4433"},
        {"Geneva Identification System", "GEN# +1.00151965"},
        {"Renson", "Renson 43000"},
        {"Smithsonian Astrophysical Observation", "SAO 227332"},
    },
    visualMagnitude: 6.35,
    bvColour: -0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.11426283),
        dec: Angle.Degrees(-40.72310509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187805"},
        {"Hipparcos Number", "HIP 97890"},
        {"Smithsonian Astrophysical Observation", "SAO 229917"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.38991712),
        dec: Angle.Degrees(-40.72306639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223908"},
        {"Hipparcos Number", "HIP 117808"},
        {"Smithsonian Astrophysical Observation", "SAO 231830"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.39618974),
        dec: Angle.Degrees(-40.72021951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134426"},
        {"Hipparcos Number", "HIP 74302"},
        {"Geneva Identification System", "GEN# +1.00134426"},
        {"Smithsonian Astrophysical Observation", "SAO 225514"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.80759338),
        dec: Angle.Degrees(-40.71589773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223122"},
        {"Hipparcos Number", "HIP 117289"},
        {"Smithsonian Astrophysical Observation", "SAO 231778"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.73260700),
        dec: Angle.Degrees(-40.71359950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194369"},
        {"Hipparcos Number", "HIP 100835"},
        {"Smithsonian Astrophysical Observation", "SAO 230208"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.68257434),
        dec: Angle.Degrees(-40.71287210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10301"},
        {"Hipparcos Number", "HIP 7760"},
        {"Smithsonian Astrophysical Observation", "SAO 215606"},
    },
    visualMagnitude: 9.85,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.97703389),
        dec: Angle.Degrees(-40.71085150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78832"},
        {"Hipparcos Number", "HIP 44910"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.23164504),
        dec: Angle.Degrees(-40.71057013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78202"},
        {"Hipparcos Number", "HIP 44624"},
        {"Smithsonian Astrophysical Observation", "SAO 220829"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.902,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.40257645),
        dec: Angle.Degrees(-40.71030898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187453"},
        {"Hipparcos Number", "HIP 97743"},
        {"Smithsonian Astrophysical Observation", "SAO 229901"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.94245797),
        dec: Angle.Degrees(-40.70834879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201904"},
        {"Hipparcos Number", "HIP 104800"},
        {"Smithsonian Astrophysical Observation", "SAO 230584"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.914,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.46784405),
        dec: Angle.Degrees(-40.70786215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37717"},
        {"Hipparcos Number", "HIP 26545"},
        {"Geneva Identification System", "GEN# +1.00037717"},
        {"Smithsonian Astrophysical Observation", "SAO 217450"},
        {"Wilson Evans Batten Catalogue", "WEB 5233"},
    },
    visualMagnitude: 5.81,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.68136124),
        dec: Angle.Degrees(-40.70735801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113220"},
        {"Hipparcos Number", "HIP 63648"},
        {"Smithsonian Astrophysical Observation", "SAO 223858"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.67513491),
        dec: Angle.Degrees(-40.70562812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12749",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12749"},
        {"Cincinnati Publication", "Ci 20 181"},
        {"Geneva Identification System", "GEN# +6.10141132"},
    },
    visualMagnitude: 11.92,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.97021936),
        dec: Angle.Degrees(-08.82753956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 617.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -754.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142431"},
        {"Hipparcos Number", "HIP 78042"},
        {"Geneva Identification System", "GEN# +1.00142431"},
        {"Smithsonian Astrophysical Observation", "SAO 226375"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.02142928),
        dec: Angle.Degrees(-40.70471199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172641"},
        {"Hipparcos Number", "HIP 91807"},
        {"Geneva Identification System", "GEN# +1.00172641"},
        {"Smithsonian Astrophysical Observation", "SAO 229223"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.79106791),
        dec: Angle.Degrees(-40.70354913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203495"},
        {"Hipparcos Number", "HIP 105638"},
    },
    visualMagnitude: 12.37,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.95318062),
        dec: Angle.Degrees(-40.70142179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63868"},
        {"Hipparcos Number", "HIP 38165"},
        {"Celescope Catalog", "CEL 2050"},
        {"Geneva Identification System", "GEN# +1.00063868"},
        {"Smithsonian Astrophysical Observation", "SAO 219029"},
        {"Wilson Evans Batten Catalogue", "WEB 7521"},
    },
    visualMagnitude: 6.53,
    bvColour: -0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.30963083),
        dec: Angle.Degrees(-40.70107679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204303"},
        {"Hipparcos Number", "HIP 106045"},
        {"Geneva Identification System", "GEN# +1.00204303"},
        {"Smithsonian Astrophysical Observation", "SAO 230705"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.19214684),
        dec: Angle.Degrees(-40.70022133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13947"},
        {"Hipparcos Number", "HIP 10455"},
        {"Smithsonian Astrophysical Observation", "SAO 215834"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.68694146),
        dec: Angle.Degrees(-40.69991380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90115"},
        {"Hipparcos Number", "HIP 50873"},
        {"Fundamental Katalog 5th Edition", "FK5 4924"},
        {"Smithsonian Astrophysical Observation", "SAO 222010"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.82140426),
        dec: Angle.Degrees(-40.69548483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11940",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11940"},
    },
    visualMagnitude: 10.72,
    bvColour: 0.762,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.51439690),
        dec: Angle.Degrees(-40.69426596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 135.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 161.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50808"},
        {"Hipparcos Number", "HIP 33023"},
        {"Smithsonian Astrophysical Observation", "SAO 218276"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.20506391),
        dec: Angle.Degrees(-40.69310104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138956"},
        {"Hipparcos Number", "HIP 76449"},
        {"Smithsonian Astrophysical Observation", "SAO 225975"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.731,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.20109757),
        dec: Angle.Degrees(-40.69188744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
