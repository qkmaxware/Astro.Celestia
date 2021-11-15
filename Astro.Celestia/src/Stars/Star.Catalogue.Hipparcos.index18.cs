using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_18() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146501"},
        {"Hipparcos Number", "HIP 79940"},
        {"Geneva Identification System", "GEN# +1.00146501"},
        {"Smithsonian Astrophysical Observation", "SAO 226641"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.76101661),
        dec: Angle.Degrees(-49.40634666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90798"},
        {"Hipparcos Number", "HIP 51245"},
        {"Geneva Identification System", "GEN# +1.00090798"},
        {"Smithsonian Astrophysical Observation", "SAO 222081"},
    },
    visualMagnitude: 6.10,
    bvColour: 1.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.00866133),
        dec: Angle.Degrees(-49.40569161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81806",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81806"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.63075995),
        dec: Angle.Degrees(-49.40540461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68674",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68674"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.87116923),
        dec: Angle.Degrees(-49.40524276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58089"},
        {"Hipparcos Number", "HIP 35670"},
        {"Smithsonian Astrophysical Observation", "SAO 218670"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.39896915),
        dec: Angle.Degrees(-49.40518739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142117"},
        {"Hipparcos Number", "HIP 77934"},
        {"Geneva Identification System", "GEN# +1.00142117"},
        {"Smithsonian Astrophysical Observation", "SAO 226353"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.73763897),
        dec: Angle.Degrees(-49.40264041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82712"},
        {"Hipparcos Number", "HIP 46793"},
        {"Geneva Identification System", "GEN# +1.00082712"},
        {"Smithsonian Astrophysical Observation", "SAO 221261"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.02235210),
        dec: Angle.Degrees(-49.40200793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103077"},
        {"Hipparcos Number", "HIP 57861"},
        {"Geneva Identification System", "GEN# +1.00103077"},
        {"Smithsonian Astrophysical Observation", "SAO 223078"},
    },
    visualMagnitude: 6.99,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.01724236),
        dec: Angle.Degrees(-49.40114231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110143"},
        {"Hipparcos Number", "HIP 61840"},
        {"Geneva Identification System", "GEN# +1.00110143"},
        {"Smithsonian Astrophysical Observation", "SAO 223586"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.09171823),
        dec: Angle.Degrees(-49.40038580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224421"},
        {"Hipparcos Number", "HIP 118134"},
        {"Geneva Identification System", "GEN# +1.00224421"},
        {"Renson", "Renson 61500"},
        {"Smithsonian Astrophysical Observation", "SAO 231870"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.44499143),
        dec: Angle.Degrees(-49.40018292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63306",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63306"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.60430839),
        dec: Angle.Degrees(-49.39967149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202704"},
        {"Hipparcos Number", "HIP 105272"},
        {"Smithsonian Astrophysical Observation", "SAO 230627"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.85103130),
        dec: Angle.Degrees(-49.39844991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72254"},
        {"Hipparcos Number", "HIP 41658"},
        {"Smithsonian Astrophysical Observation", "SAO 220006"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.40882718),
        dec: Angle.Degrees(-49.39683943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61228",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61228"},
    },
    visualMagnitude: 10.47,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.19607930),
        dec: Angle.Degrees(-49.39590100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14352"},
        {"Hipparcos Number", "HIP 10696"},
        {"Smithsonian Astrophysical Observation", "SAO 215856"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.42483008),
        dec: Angle.Degrees(-49.39576475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 136.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 100.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31229"},
        {"Hipparcos Number", "HIP 22572"},
        {"Geneva Identification System", "GEN# +1.00031229"},
        {"Smithsonian Astrophysical Observation", "SAO 217044"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.86668923),
        dec: Angle.Degrees(-49.39559655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 79.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149077"},
        {"Hipparcos Number", "HIP 81172"},
        {"Geneva Identification System", "GEN# +1.00149077"},
        {"Smithsonian Astrophysical Observation", "SAO 226914"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.69038843),
        dec: Angle.Degrees(-49.39558651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135538"},
        {"Hipparcos Number", "HIP 74831"},
        {"Geneva Identification System", "GEN# +1.00135538"},
        {"Smithsonian Astrophysical Observation", "SAO 225620"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.39550475),
        dec: Angle.Degrees(-49.39320622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -192.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96224"},
        {"Hipparcos Number", "HIP 54185"},
        {"Geneva Identification System", "GEN# +1.00096224"},
        {"Smithsonian Astrophysical Observation", "SAO 222548"},
    },
    visualMagnitude: 6.11,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.26726476),
        dec: Angle.Degrees(-49.39232585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61219",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61219"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.17733661),
        dec: Angle.Degrees(-49.38957833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177077"},
        {"Hipparcos Number", "HIP 93760"},
        {"Geneva Identification System", "GEN# +1.00177077"},
        {"Smithsonian Astrophysical Observation", "SAO 229480"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.41148496),
        dec: Angle.Degrees(-49.38917539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96804"},
        {"Hipparcos Number", "HIP 54438"},
        {"Smithsonian Astrophysical Observation", "SAO 222591"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.08284625),
        dec: Angle.Degrees(-49.38855430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48632"},
        {"Hipparcos Number", "HIP 32054"},
        {"Geneva Identification System", "GEN# +1.00048632"},
        {"Smithsonian Astrophysical Observation", "SAO 218132"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.45850301),
        dec: Angle.Degrees(-49.38620933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4228"},
        {"Hipparcos Number", "HIP 3459"},
        {"Geneva Identification System", "GEN# +1.00004228"},
        {"Smithsonian Astrophysical Observation", "SAO 215215"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.05984552),
        dec: Angle.Degrees(-49.38589162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88663",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88663"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.51912553),
        dec: Angle.Degrees(-49.38525676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152411"},
        {"Hipparcos Number", "HIP 82826"},
        {"Smithsonian Astrophysical Observation", "SAO 227436"},
    },
    visualMagnitude: 9.02,
    bvColour: -0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.89232308),
        dec: Angle.Degrees(-49.38382875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198620"},
        {"Hipparcos Number", "HIP 103107"},
        {"Smithsonian Astrophysical Observation", "SAO 230418"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.35788165),
        dec: Angle.Degrees(-49.38282401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116862"},
        {"Hipparcos Number", "HIP 65630"},
        {"Geneva Identification System", "GEN# +1.00116862"},
        {"Smithsonian Astrophysical Observation", "SAO 224151"},
        {"Wilson Evans Batten Catalogue", "WEB 11609"},
    },
    visualMagnitude: 6.27,
    bvColour: -0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.83608555),
        dec: Angle.Degrees(-49.38128450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30119"},
        {"Hipparcos Number", "HIP 21879"},
        {"Smithsonian Astrophysical Observation", "SAO 216946"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.55662419),
        dec: Angle.Degrees(-49.38063610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37106"},
        {"Hipparcos Number", "HIP 26050"},
        {"Geneva Identification System", "GEN# +1.00037106"},
        {"Smithsonian Astrophysical Observation", "SAO 217400"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.36166407),
        dec: Angle.Degrees(-49.37759303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64289"},
        {"Hipparcos Number", "HIP 38297"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.69563985),
        dec: Angle.Degrees(-49.37514976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 152.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35604"},
        {"Hipparcos Number", "HIP 25196"},
        {"Fundamental Katalog 5th Edition", "FK5 4496"},
        {"Smithsonian Astrophysical Observation", "SAO 217317"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.86149304),
        dec: Angle.Degrees(-49.37493527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127017"},
        {"Hipparcos Number", "HIP 70936"},
        {"Geneva Identification System", "GEN# +1.00127017"},
        {"Smithsonian Astrophysical Observation", "SAO 224975"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.61865520),
        dec: Angle.Degrees(-49.37249811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 297669"},
        {"Hipparcos Number", "HIP 48770"},
    },
    visualMagnitude: 10.50,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.20603414),
        dec: Angle.Degrees(-49.37195834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201326"},
        {"Hipparcos Number", "HIP 104545"},
        {"Smithsonian Astrophysical Observation", "SAO 230557"},
    },
    visualMagnitude: 9.67,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.65451958),
        dec: Angle.Degrees(-49.37135458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22866"},
        {"Hipparcos Number", "HIP 16970"},
        {"Geneva Identification System", "GEN# +1.00022866"},
        {"Smithsonian Astrophysical Observation", "SAO 216420"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.56937615),
        dec: Angle.Degrees(-49.36838932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125444"},
        {"Hipparcos Number", "HIP 70124"},
        {"Smithsonian Astrophysical Observation", "SAO 224848"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.22998088),
        dec: Angle.Degrees(-49.36663810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142905"},
        {"Hipparcos Number", "HIP 78301"},
        {"Smithsonian Astrophysical Observation", "SAO 226419"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.82581296),
        dec: Angle.Degrees(-49.36640687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212708"},
        {"Hipparcos Number", "HIP 110843"},
        {"Cincinnati Publication", "Ci 20 1361"},
        {"Geneva Identification System", "GEN# +1.00212708"},
        {"Smithsonian Astrophysical Observation", "SAO 231145"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.85160006),
        dec: Angle.Degrees(-49.36514752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 337.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -330.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47250"},
        {"Hipparcos Number", "HIP 31425"},
        {"Smithsonian Astrophysical Observation", "SAO 218039"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.77639182),
        dec: Angle.Degrees(-49.36379820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 148.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18241"},
        {"Hipparcos Number", "HIP 13508"},
        {"Smithsonian Astrophysical Observation", "SAO 216088"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.49705810),
        dec: Angle.Degrees(-49.36170639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 98.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91416",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91416"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.66399350),
        dec: Angle.Degrees(-49.36162704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103856"},
        {"Hipparcos Number", "HIP 58301"},
        {"Geneva Identification System", "GEN# +1.00103856"},
        {"Smithsonian Astrophysical Observation", "SAO 223130"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.33562442),
        dec: Angle.Degrees(-49.36009360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -171.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86878"},
        {"Hipparcos Number", "HIP 49022"},
        {"Smithsonian Astrophysical Observation", "SAO 221683"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.01626911),
        dec: Angle.Degrees(-49.36007531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1973"},
        {"Hipparcos Number", "HIP 1880"},
        {"Smithsonian Astrophysical Observation", "SAO 215079"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.93202706),
        dec: Angle.Degrees(-49.35773869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35379",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35379"},
    },
    visualMagnitude: 9.57,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.62146008),
        dec: Angle.Degrees(-49.35738001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74969"},
        {"Hipparcos Number", "HIP 42942"},
        {"Celescope Catalog", "CEL 2861"},
        {"Smithsonian Astrophysical Observation", "SAO 220400"},
    },
    visualMagnitude: 8.18,
    bvColour: -0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.29895153),
        dec: Angle.Degrees(-49.35614841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83446"},
        {"Hipparcos Number", "HIP 47175"},
        {"Celescope Catalog", "CEL 3343"},
        {"Fundamental Katalog 5th Edition", "FK5 2768"},
        {"Geneva Identification System", "GEN# +1.00083446"},
        {"Smithsonian Astrophysical Observation", "SAO 221344"},
        {"Wilson Evans Batten Catalogue", "WEB 8871"},
    },
    visualMagnitude: 4.34,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.20690420),
        dec: Angle.Degrees(-49.35512860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -130.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117368"},
        {"Hipparcos Number", "HIP 65917"},
        {"Smithsonian Astrophysical Observation", "SAO 224204"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.69840643),
        dec: Angle.Degrees(-49.35502491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54870",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54870"},
    },
    visualMagnitude: 10.67,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.52038922),
        dec: Angle.Degrees(-49.35301614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224735"},
        {"Hipparcos Number", "HIP 22"},
        {"Smithsonian Astrophysical Observation", "SAO 231887"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.07013593),
        dec: Angle.Degrees(-49.35226686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170984"},
        {"Hipparcos Number", "HIP 91091"},
        {"Smithsonian Astrophysical Observation", "SAO 229119"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.71260182),
        dec: Angle.Degrees(-49.35208493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220249"},
        {"Hipparcos Number", "HIP 115413"},
        {"Smithsonian Astrophysical Observation", "SAO 231575"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.68518392),
        dec: Angle.Degrees(-49.35141656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 131.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199818"},
        {"Hipparcos Number", "HIP 103743"},
        {"Fundamental Katalog 5th Edition", "FK5 5850"},
        {"Geneva Identification System", "GEN# +1.00199818"},
        {"Smithsonian Astrophysical Observation", "SAO 230482"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.34252755),
        dec: Angle.Degrees(-49.35137688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189080"},
        {"Hipparcos Number", "HIP 98482"},
        {"Fundamental Katalog 5th Edition", "FK5 3595"},
        {"Geneva Identification System", "GEN# +1.00189080"},
        {"Smithsonian Astrophysical Observation", "SAO 229973"},
    },
    visualMagnitude: 6.18,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.10582208),
        dec: Angle.Degrees(-49.35093932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15756",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15756"},
    },
    visualMagnitude: 10.90,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.75722642),
        dec: Angle.Degrees(-49.35066113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -209.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220482"},
        {"Hipparcos Number", "HIP 115561"},
        {"Smithsonian Astrophysical Observation", "SAO 231594"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.12515175),
        dec: Angle.Degrees(-49.34761502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84348",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84348"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.67528754),
        dec: Angle.Degrees(-49.34703775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167825"},
        {"Hipparcos Number", "HIP 89797"},
        {"Geneva Identification System", "GEN# +1.00167825"},
        {"Smithsonian Astrophysical Observation", "SAO 228904"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.89183811),
        dec: Angle.Degrees(-49.34702160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95596"},
        {"Hipparcos Number", "HIP 53877"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.835,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.34090295),
        dec: Angle.Degrees(-49.34560631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165471"},
        {"Hipparcos Number", "HIP 88883"},
        {"Geneva Identification System", "GEN# +1.00165471"},
        {"Smithsonian Astrophysical Observation", "SAO 228735"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.18324802),
        dec: Angle.Degrees(-49.34534058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185303"},
        {"Hipparcos Number", "HIP 96812"},
        {"Smithsonian Astrophysical Observation", "SAO 229809"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.18747312),
        dec: Angle.Degrees(-49.34345553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157626"},
        {"Hipparcos Number", "HIP 85392"},
        {"Smithsonian Astrophysical Observation", "SAO 227969"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.73447374),
        dec: Angle.Degrees(-49.34264596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7923"},
        {"Hipparcos Number", "HIP 6074"},
        {"Smithsonian Astrophysical Observation", "SAO 215445"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.49327977),
        dec: Angle.Degrees(-49.34117601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137787"},
        {"Hipparcos Number", "HIP 75878"},
        {"Smithsonian Astrophysical Observation", "SAO 225835"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.748,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.48243029),
        dec: Angle.Degrees(-49.33995742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183009"},
        {"Hipparcos Number", "HIP 95861"},
        {"Smithsonian Astrophysical Observation", "SAO 229714"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.45227729),
        dec: Angle.Degrees(-49.33977979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159235"},
        {"Hipparcos Number", "HIP 86134"},
        {"Smithsonian Astrophysical Observation", "SAO 228166"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.03848056),
        dec: Angle.Degrees(-49.33850884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66766",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66766"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.26791267),
        dec: Angle.Degrees(-49.33638751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102467",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102467"},
    },
    visualMagnitude: 10.83,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.45782729),
        dec: Angle.Degrees(-49.33569634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44862"},
        {"Hipparcos Number", "HIP 30228"},
        {"Smithsonian Astrophysical Observation", "SAO 217881"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.39763022),
        dec: Angle.Degrees(-49.33531629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102465",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102465"},
    },
    visualMagnitude: 13.51,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.45304393),
        dec: Angle.Degrees(-49.33471373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 131.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196390"},
        {"Hipparcos Number", "HIP 101905"},
        {"Geneva Identification System", "GEN# +1.00196390"},
        {"Smithsonian Astrophysical Observation", "SAO 230307"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.76104626),
        dec: Angle.Degrees(-49.33145890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -145.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13618"},
        {"Hipparcos Number", "HIP 10226"},
        {"Smithsonian Astrophysical Observation", "SAO 215809"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.87053412),
        dec: Angle.Degrees(-49.33145847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87359",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87359"},
    },
    visualMagnitude: 10.41,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.75817271),
        dec: Angle.Degrees(-49.33049721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120257"},
        {"Hipparcos Number", "HIP 67452"},
        {"Smithsonian Astrophysical Observation", "SAO 224457"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.35209136),
        dec: Angle.Degrees(-49.33021035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20233"},
        {"Hipparcos Number", "HIP 14991"},
        {"Smithsonian Astrophysical Observation", "SAO 216217"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.30479791),
        dec: Angle.Degrees(-49.32937692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61060",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61060"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.72506345),
        dec: Angle.Degrees(-49.32895636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18469"},
        {"Hipparcos Number", "HIP 13697"},
        {"Smithsonian Astrophysical Observation", "SAO 216104"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.09934414),
        dec: Angle.Degrees(-49.32752556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55912"},
        {"Hipparcos Number", "HIP 34816"},
        {"Smithsonian Astrophysical Observation", "SAO 218535"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.10505527),
        dec: Angle.Degrees(-49.32704563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107663"},
        {"Hipparcos Number", "HIP 60360"},
        {"Geneva Identification System", "GEN# +1.00107663"},
        {"Smithsonian Astrophysical Observation", "SAO 223389"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.65229071),
        dec: Angle.Degrees(-49.32612013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29029"},
        {"Hipparcos Number", "HIP 21131"},
        {"Geneva Identification System", "GEN# +1.00029029"},
        {"Smithsonian Astrophysical Observation", "SAO 216860"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.94639583),
        dec: Angle.Degrees(-49.32143428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 327.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205566"},
        {"Hipparcos Number", "HIP 106777"},
        {"Smithsonian Astrophysical Observation", "SAO 230760"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.42598653),
        dec: Angle.Degrees(-49.32110938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69115",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69115"},
    },
    visualMagnitude: 10.90,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.21842389),
        dec: Angle.Degrees(-49.32067099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119511"},
        {"Hipparcos Number", "HIP 67068"},
        {"Geneva Identification System", "GEN# +1.00119511"},
        {"Smithsonian Astrophysical Observation", "SAO 224388"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.18321444),
        dec: Angle.Degrees(-49.29932170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153828"},
        {"Hipparcos Number", "HIP 83524"},
        {"Renson", "Renson 43430"},
        {"Smithsonian Astrophysical Observation", "SAO 227592"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.04369734),
        dec: Angle.Degrees(-49.32062547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103302"},
        {"Hipparcos Number", "HIP 57987"},
        {"Geneva Identification System", "GEN# +1.00103302"},
        {"Renson", "Renson 29780"},
        {"Smithsonian Astrophysical Observation", "SAO 223091"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.40918279),
        dec: Angle.Degrees(-49.32052365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102691"},
        {"Hipparcos Number", "HIP 57647"},
        {"Smithsonian Astrophysical Observation", "SAO 223040"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.31347344),
        dec: Angle.Degrees(-49.31559003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178228"},
        {"Hipparcos Number", "HIP 94172"},
        {"Smithsonian Astrophysical Observation", "SAO 229529"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.54759310),
        dec: Angle.Degrees(-49.31403087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110968"},
        {"Hipparcos Number", "HIP 62321"},
        {"Smithsonian Astrophysical Observation", "SAO 223658"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.56800155),
        dec: Angle.Degrees(-49.31198045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177741"},
        {"Hipparcos Number", "HIP 94007"},
        {"Smithsonian Astrophysical Observation", "SAO 229509"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.10068899),
        dec: Angle.Degrees(-49.31069683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71821",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71821"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.37906873),
        dec: Angle.Degrees(-49.31033422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121091"},
        {"Hipparcos Number", "HIP 67915"},
        {"Smithsonian Astrophysical Observation", "SAO 224524"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.65193083),
        dec: Angle.Degrees(-49.30960365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151551"},
        {"Hipparcos Number", "HIP 82413"},
        {"Smithsonian Astrophysical Observation", "SAO 227280"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.62433263),
        dec: Angle.Degrees(-49.30701048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186755"},
        {"Hipparcos Number", "HIP 97463"},
        {"Smithsonian Astrophysical Observation", "SAO 229873"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.15017772),
        dec: Angle.Degrees(-49.30535010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 102.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 297731"},
        {"Hipparcos Number", "HIP 49155"},
    },
    visualMagnitude: 11.01,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.48221319),
        dec: Angle.Degrees(-49.30384417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98765"},
        {"Hipparcos Number", "HIP 55452"},
        {"Smithsonian Astrophysical Observation", "SAO 222736"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.35523453),
        dec: Angle.Degrees(-49.30383648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173308"},
        {"Hipparcos Number", "HIP 92165"},
        {"Smithsonian Astrophysical Observation", "SAO 229272"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.77076585),
        dec: Angle.Degrees(-49.30327266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 297396"},
        {"Hipparcos Number", "HIP 45533"},
    },
    visualMagnitude: 10.22,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.20196292),
        dec: Angle.Degrees(-49.30163117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -214.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 113.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103088"},
        {"Hipparcos Number", "HIP 57872"},
        {"Smithsonian Astrophysical Observation", "SAO 223079"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.04362161),
        dec: Angle.Degrees(-49.30040971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33498"},
        {"Hipparcos Number", "HIP 23901"},
        {"Renson", "Renson 8520"},
        {"Smithsonian Astrophysical Observation", "SAO 217196"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.02910453),
        dec: Angle.Degrees(-49.29719021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214356"},
        {"Hipparcos Number", "HIP 111788"},
        {"Smithsonian Astrophysical Observation", "SAO 231230"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.63888888),
        dec: Angle.Degrees(-49.29436315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31833",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31833"},
    },
    visualMagnitude: 11.48,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.83296401),
        dec: Angle.Degrees(-49.29355378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 294.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90000"},
        {"Hipparcos Number", "HIP 50780"},
        {"Geneva Identification System", "GEN# +1.00090000"},
        {"Smithsonian Astrophysical Observation", "SAO 221995"},
    },
    visualMagnitude: 7.56,
    bvColour: -0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.53715200),
        dec: Angle.Degrees(-49.29353895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50622"},
        {"Hipparcos Number", "HIP 32913"},
        {"Smithsonian Astrophysical Observation", "SAO 218258"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.86527231),
        dec: Angle.Degrees(-49.29351244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28513"},
        {"Hipparcos Number", "HIP 20792"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.83245485),
        dec: Angle.Degrees(-49.29309556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149495"},
        {"Hipparcos Number", "HIP 81414"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.41010684),
        dec: Angle.Degrees(-49.29159793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1381"},
        {"Hipparcos Number", "HIP 1430"},
        {"Smithsonian Astrophysical Observation", "SAO 215040"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.46389136),
        dec: Angle.Degrees(-49.29063693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78895"},
        {"Hipparcos Number", "HIP 44902"},
        {"Smithsonian Astrophysical Observation", "SAO 220894"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.22050663),
        dec: Angle.Degrees(-49.29000278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61521",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61521"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.07118104),
        dec: Angle.Degrees(-49.29000148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79072"},
        {"Hipparcos Number", "HIP 45014"},
        {"Celescope Catalog", "CEL 3200"},
        {"Geneva Identification System", "GEN# +1.00079072"},
        {"Smithsonian Astrophysical Observation", "SAO 220916"},
    },
    visualMagnitude: 7.02,
    bvColour: -0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.52573065),
        dec: Angle.Degrees(-49.28977223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74070"},
        {"Hipparcos Number", "HIP 42481"},
        {"Smithsonian Astrophysical Observation", "SAO 220245"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.91933153),
        dec: Angle.Degrees(-49.28787483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20686"},
        {"Hipparcos Number", "HIP 15339"},
        {"Geneva Identification System", "GEN# +1.00020686"},
        {"Smithsonian Astrophysical Observation", "SAO 216249"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.45520604),
        dec: Angle.Degrees(-49.28539133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46085"},
        {"Hipparcos Number", "HIP 30853"},
        {"Smithsonian Astrophysical Observation", "SAO 217955"},
    },
    visualMagnitude: 8.02,
    bvColour: -0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.17989679),
        dec: Angle.Degrees(-49.28527877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 297667"},
        {"Hipparcos Number", "HIP 48867"},
    },
    visualMagnitude: 10.62,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.50379963),
        dec: Angle.Degrees(-49.28521345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156746"},
        {"Hipparcos Number", "HIP 84956"},
        {"Smithsonian Astrophysical Observation", "SAO 227861"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.46208047),
        dec: Angle.Degrees(-49.28488273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -126.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14617",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14617"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.785,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.20087862),
        dec: Angle.Degrees(-49.28447586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 241.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68608"},
        {"Hipparcos Number", "HIP 40059"},
        {"Celescope Catalog", "CEL 2216"},
        {"Geneva Identification System", "GEN# +2.25470005"},
        {"Smithsonian Astrophysical Observation", "SAO 219559"},
        {"Wilson Evans Batten Catalogue", "WEB 7816"},
        {"New General Catalogue", "NGC 2547 5"},
    },
    visualMagnitude: 7.89,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.74815794),
        dec: Angle.Degrees(-49.28441926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75849",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75849"},
    },
    visualMagnitude: 10.95,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.39611743),
        dec: Angle.Degrees(-49.28387249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165698"},
        {"Hipparcos Number", "HIP 88989"},
        {"Smithsonian Astrophysical Observation", "SAO 228750"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.45176948),
        dec: Angle.Degrees(-49.28245125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38890"},
        {"Hipparcos Number", "HIP 27237"},
        {"Geneva Identification System", "GEN# +1.00038890"},
        {"Smithsonian Astrophysical Observation", "SAO 217524"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.59421391),
        dec: Angle.Degrees(-49.28165948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 648"},
        {"Hipparcos Number", "HIP 862"},
    },
    visualMagnitude: 9.94,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.65641131),
        dec: Angle.Degrees(-49.28139379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92501"},
        {"Hipparcos Number", "HIP 52204"},
        {"Fundamental Katalog 5th Edition", "FK5 2854"},
        {"Smithsonian Astrophysical Observation", "SAO 222239"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.99243234),
        dec: Angle.Degrees(-49.27972004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122921"},
        {"Hipparcos Number", "HIP 68863"},
        {"Smithsonian Astrophysical Observation", "SAO 224670"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.51253219),
        dec: Angle.Degrees(-49.27931882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215406"},
        {"Hipparcos Number", "HIP 112390"},
        {"Smithsonian Astrophysical Observation", "SAO 231279"},
    },
    visualMagnitude: 9.74,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.44936403),
        dec: Angle.Degrees(-49.27883700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7293"},
        {"Hipparcos Number", "HIP 5633"},
        {"Smithsonian Astrophysical Observation", "SAO 215411"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.08596773),
        dec: Angle.Degrees(-49.27672509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122075"},
        {"Hipparcos Number", "HIP 68448"},
        {"Smithsonian Astrophysical Observation", "SAO 224612"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.19294390),
        dec: Angle.Degrees(-49.27486117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81237"},
        {"Hipparcos Number", "HIP 45986"},
        {"Smithsonian Astrophysical Observation", "SAO 221115"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.67828457),
        dec: Angle.Degrees(-49.27399336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123798"},
        {"Hipparcos Number", "HIP 69302"},
        {"Geneva Identification System", "GEN# +1.00123798"},
        {"Smithsonian Astrophysical Observation", "SAO 224748"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.77045122),
        dec: Angle.Degrees(-49.27309680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133421"},
        {"Hipparcos Number", "HIP 73899"},
        {"Geneva Identification System", "GEN# +1.00133421"},
        {"Smithsonian Astrophysical Observation", "SAO 225442"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.54732702),
        dec: Angle.Degrees(-49.27188885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -160.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160416"},
        {"Hipparcos Number", "HIP 86652"},
        {"Geneva Identification System", "GEN# +1.00160416"},
        {"Smithsonian Astrophysical Observation", "SAO 228302"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.57244047),
        dec: Angle.Degrees(-49.27087450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67821"},
        {"Hipparcos Number", "HIP 39759"},
        {"Smithsonian Astrophysical Observation", "SAO 219448"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.88978226),
        dec: Angle.Degrees(-49.27034582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90797"},
        {"Hipparcos Number", "HIP 51242"},
        {"Geneva Identification System", "GEN# +1.00090797"},
        {"Smithsonian Astrophysical Observation", "SAO 222080"},
    },
    visualMagnitude: 8.32,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.99427829),
        dec: Angle.Degrees(-49.26971978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68397"},
        {"Hipparcos Number", "HIP 39988"},
        {"Geneva Identification System", "GEN# +2.25470007"},
        {"Smithsonian Astrophysical Observation", "SAO 219530"},
        {"Wilson Evans Batten Catalogue", "WEB 7797"},
        {"New General Catalogue", "NGC 2547 7"},
    },
    visualMagnitude: 8.14,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.49677664),
        dec: Angle.Degrees(-49.26971846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73190",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73190"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.38399031),
        dec: Angle.Degrees(-49.26773544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91719"},
        {"Hipparcos Number", "HIP 51755"},
        {"Smithsonian Astrophysical Observation", "SAO 222159"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.62206932),
        dec: Angle.Degrees(-49.26551820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110952",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110952"},
    },
    visualMagnitude: 10.59,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.19395539),
        dec: Angle.Degrees(-49.26517143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 189.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65553"},
        {"Hipparcos Number", "HIP 38847"},
        {"Smithsonian Astrophysical Observation", "SAO 219194"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.24660834),
        dec: Angle.Degrees(-49.26495545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10092"},
        {"Hipparcos Number", "HIP 7579"},
        {"Smithsonian Astrophysical Observation", "SAO 215587"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.40308023),
        dec: Angle.Degrees(-49.26460374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 102.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204077"},
        {"Hipparcos Number", "HIP 105980"},
        {"Smithsonian Astrophysical Observation", "SAO 230698"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.933,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.95212159),
        dec: Angle.Degrees(-49.26321278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173892"},
        {"Hipparcos Number", "HIP 92433"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.733,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.55979204),
        dec: Angle.Degrees(-49.26304895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -181.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8913"},
        {"Hipparcos Number", "HIP 6749"},
        {"Smithsonian Astrophysical Observation", "SAO 215508"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.71994216),
        dec: Angle.Degrees(-49.26203867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105136"},
        {"Hipparcos Number", "HIP 59040"},
        {"Smithsonian Astrophysical Observation", "SAO 223219"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.56847748),
        dec: Angle.Degrees(-49.25882187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81097"},
        {"Hipparcos Number", "HIP 45930"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.47434286),
        dec: Angle.Degrees(-49.25816714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113739"},
        {"Hipparcos Number", "HIP 63963"},
        {"Geneva Identification System", "GEN# +1.00113739"},
        {"Smithsonian Astrophysical Observation", "SAO 223901"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.61624467),
        dec: Angle.Degrees(-49.25419041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157454"},
        {"Hipparcos Number", "HIP 85300"},
        {"Smithsonian Astrophysical Observation", "SAO 227941"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.46706746),
        dec: Angle.Degrees(-49.25317198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15206"},
        {"Hipparcos Number", "HIP 11288"},
        {"Smithsonian Astrophysical Observation", "SAO 215896"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.35215146),
        dec: Angle.Degrees(-49.25247621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129183"},
        {"Hipparcos Number", "HIP 71932"},
        {"Smithsonian Astrophysical Observation", "SAO 225138"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.67933574),
        dec: Angle.Degrees(-49.24998612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92141"},
        {"Hipparcos Number", "HIP 51989"},
        {"Smithsonian Astrophysical Observation", "SAO 222201"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.33080174),
        dec: Angle.Degrees(-49.24740661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12041"},
        {"Hipparcos Number", "HIP 9083"},
        {"Smithsonian Astrophysical Observation", "SAO 215713"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.23869676),
        dec: Angle.Degrees(-49.24600023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30551"},
        {"Hipparcos Number", "HIP 22170"},
        {"Geneva Identification System", "GEN# +1.00030551"},
        {"Smithsonian Astrophysical Observation", "SAO 216987"},
        {"Wilson Evans Batten Catalogue", "WEB 4264"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.53964211),
        dec: Angle.Degrees(-49.24594096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134120"},
        {"Hipparcos Number", "HIP 74217"},
        {"Smithsonian Astrophysical Observation", "SAO 225494"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.49529607),
        dec: Angle.Degrees(-49.24590912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159439"},
        {"Hipparcos Number", "HIP 86227"},
        {"Smithsonian Astrophysical Observation", "SAO 228194"},
    },
    visualMagnitude: 6.92,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.31966652),
        dec: Angle.Degrees(-49.24495697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65818"},
        {"Hipparcos Number", "HIP 38957"},
        {"Celescope Catalog", "CEL 2121"},
        {"Geneva Identification System", "GEN# +1.00065818J"},
        {"Smithsonian Astrophysical Observation", "SAO 219226"},
        {"Wilson Evans Batten Catalogue", "WEB 7635"},
    },
    visualMagnitude: 4.47,
    bvColour: -0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.56018303),
        dec: Angle.Degrees(-49.24492865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93317"},
        {"Hipparcos Number", "HIP 52612"},
        {"Smithsonian Astrophysical Observation", "SAO 222301"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.38491905),
        dec: Angle.Degrees(-49.24136451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63402"},
        {"Hipparcos Number", "HIP 37932"},
        {"Smithsonian Astrophysical Observation", "SAO 218982"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.60040665),
        dec: Angle.Degrees(-49.24114595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140903"},
        {"Hipparcos Number", "HIP 77415"},
        {"Smithsonian Astrophysical Observation", "SAO 226219"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.07195166),
        dec: Angle.Degrees(-49.23874279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68478"},
        {"Hipparcos Number", "HIP 40016"},
        {"Celescope Catalog", "CEL 2207"},
        {"Geneva Identification System", "GEN# +2.25470002"},
        {"Smithsonian Astrophysical Observation", "SAO 219538"},
        {"Wilson Evans Batten Catalogue", "WEB 7805"},
        {"New General Catalogue", "NGC 2547 2"},
    },
    visualMagnitude: 6.46,
    bvColour: -0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.58571945),
        dec: Angle.Degrees(-49.23735993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189791"},
        {"Hipparcos Number", "HIP 98794"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.98030162),
        dec: Angle.Degrees(-49.23569393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69282"},
        {"Hipparcos Number", "HIP 40336"},
        {"Celescope Catalog", "CEL 2268"},
        {"Geneva Identification System", "GEN# +1.00069282"},
        {"Smithsonian Astrophysical Observation", "SAO 219646"},
    },
    visualMagnitude: 8.21,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.53707844),
        dec: Angle.Degrees(-49.23444420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78355"},
        {"Hipparcos Number", "HIP 44658"},
        {"Geneva Identification System", "GEN# +1.00078355"},
        {"Smithsonian Astrophysical Observation", "SAO 220846"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.49225506),
        dec: Angle.Degrees(-49.23429810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88386",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88386"},
    },
    visualMagnitude: 9.49,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.73031520),
        dec: Angle.Degrees(-49.23265291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7829",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7829"},
    },
    visualMagnitude: 10.16,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.18321792),
        dec: Angle.Degrees(-49.23205869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 292.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 146.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91904"},
        {"Hipparcos Number", "HIP 51870"},
        {"Smithsonian Astrophysical Observation", "SAO 222183"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.96521002),
        dec: Angle.Degrees(-49.23108174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143546"},
        {"Hipparcos Number", "HIP 78639"},
        {"Fundamental Katalog 5th Edition", "FK5 3266"},
        {"Geneva Identification System", "GEN# +1.00143546"},
        {"Smithsonian Astrophysical Observation", "SAO 226466"},
        {"Wilson Evans Batten Catalogue", "WEB 13290"},
    },
    visualMagnitude: 4.65,
    bvColour: 0.902,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.80358419),
        dec: Angle.Degrees(-49.22972074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202158"},
        {"Hipparcos Number", "HIP 104976"},
        {"Smithsonian Astrophysical Observation", "SAO 230601"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.93989323),
        dec: Angle.Degrees(-49.22883825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75535"},
        {"Hipparcos Number", "HIP 43244"},
        {"Geneva Identification System", "GEN# +1.00075535"},
        {"Smithsonian Astrophysical Observation", "SAO 220510"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.15371180),
        dec: Angle.Degrees(-49.22865672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149643"},
        {"Hipparcos Number", "HIP 81467"},
        {"Smithsonian Astrophysical Observation", "SAO 226983"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.58691049),
        dec: Angle.Degrees(-49.22583369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 297430"},
        {"Hipparcos Number", "HIP 46179"},
    },
    visualMagnitude: 10.18,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.24746577),
        dec: Angle.Degrees(-49.22515651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 174.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89103"},
        {"Hipparcos Number", "HIP 50248"},
        {"Geneva Identification System", "GEN# +1.00089103"},
        {"Renson", "Renson 25530"},
        {"Smithsonian Astrophysical Observation", "SAO 221912"},
    },
    visualMagnitude: 7.79,
    bvColour: -0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.89352454),
        dec: Angle.Degrees(-49.22416283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115820"},
        {"Hipparcos Number", "HIP 65089"},
        {"Geneva Identification System", "GEN# +1.00115820"},
        {"Smithsonian Astrophysical Observation", "SAO 224070"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.11183833),
        dec: Angle.Degrees(-49.22361928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42169"},
        {"Hipparcos Number", "HIP 28962"},
        {"Geneva Identification System", "GEN# +1.00042169"},
        {"Smithsonian Astrophysical Observation", "SAO 217721"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.67977459),
        dec: Angle.Degrees(-49.22236726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 97.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40430",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40430"},
        {"Geneva Identification System", "GEN# -0.04803636"},
        {"Smithsonian Astrophysical Observation", "SAO 219684"},
        {"Wilson Evans Batten Catalogue", "WEB 7878"},
    },
    visualMagnitude: 9.50,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.82914427),
        dec: Angle.Degrees(-49.22217677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47539"},
        {"Hipparcos Number", "HIP 31588"},
        {"Geneva Identification System", "GEN# +1.00047539"},
        {"Smithsonian Astrophysical Observation", "SAO 218061"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.15440083),
        dec: Angle.Degrees(-49.22132076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179832"},
        {"Hipparcos Number", "HIP 94726"},
        {"Smithsonian Astrophysical Observation", "SAO 229583"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.12499536),
        dec: Angle.Degrees(-49.22024897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109156",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109156"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.66514292),
        dec: Angle.Degrees(-49.21755422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139828"},
        {"Hipparcos Number", "HIP 76924"},
        {"Smithsonian Astrophysical Observation", "SAO 226085"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.60723339),
        dec: Angle.Degrees(-49.21753682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106217"},
        {"Hipparcos Number", "HIP 59598"},
        {"Smithsonian Astrophysical Observation", "SAO 223286"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.33105365),
        dec: Angle.Degrees(-49.21586921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221419"},
        {"Hipparcos Number", "HIP 116173"},
        {"Renson", "Renson 60680"},
        {"Smithsonian Astrophysical Observation", "SAO 231652"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.08894666),
        dec: Angle.Degrees(-49.21544609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60575"},
        {"Hipparcos Number", "HIP 36681"},
        {"Smithsonian Astrophysical Observation", "SAO 218788"},
    },
    visualMagnitude: 8.66,
    bvColour: -0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.19095712),
        dec: Angle.Degrees(-49.21201891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151598"},
        {"Hipparcos Number", "HIP 82431"},
        {"Geneva Identification System", "GEN# +1.00151598"},
        {"Smithsonian Astrophysical Observation", "SAO 227290"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.69548249),
        dec: Angle.Degrees(-49.21077668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90260"},
        {"Hipparcos Number", "HIP 50931"},
        {"Smithsonian Astrophysical Observation", "SAO 222027"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.02802168),
        dec: Angle.Degrees(-49.20908422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36678",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36678"},
        {"Smithsonian Astrophysical Observation", "SAO 218787"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.18759626),
        dec: Angle.Degrees(-49.20840177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67612"},
        {"Hipparcos Number", "HIP 39679"},
        {"Geneva Identification System", "GEN# +1.00067612"},
        {"Smithsonian Astrophysical Observation", "SAO 219424"},
    },
    visualMagnitude: 8.23,
    bvColour: -0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.63500084),
        dec: Angle.Degrees(-49.20206223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28819",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28819"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.25998985),
        dec: Angle.Degrees(-49.20082713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155975"},
        {"Hipparcos Number", "HIP 84583"},
        {"Geneva Identification System", "GEN# +1.00155975"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.34753527),
        dec: Angle.Degrees(-49.19892013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110058"},
        {"Hipparcos Number", "HIP 61782"},
        {"Smithsonian Astrophysical Observation", "SAO 223581"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.94259598),
        dec: Angle.Degrees(-49.19872732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 958"},
        {"Hipparcos Number", "HIP 1097"},
        {"Smithsonian Astrophysical Observation", "SAO 215008"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.42681662),
        dec: Angle.Degrees(-49.19840935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202717"},
        {"Hipparcos Number", "HIP 105281"},
        {"Smithsonian Astrophysical Observation", "SAO 230629"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.86851598),
        dec: Angle.Degrees(-49.19763401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158908"},
        {"Hipparcos Number", "HIP 85984"},
        {"Smithsonian Astrophysical Observation", "SAO 228129"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.60109936),
        dec: Angle.Degrees(-49.19700654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160534"},
        {"Hipparcos Number", "HIP 86708"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.75532582),
        dec: Angle.Degrees(-49.19615766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7554",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7554"},
    },
    visualMagnitude: 10.39,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.33490489),
        dec: Angle.Degrees(-49.19594129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 497.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 113.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222413"},
        {"Hipparcos Number", "HIP 116813"},
        {"Smithsonian Astrophysical Observation", "SAO 231730"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.12341158),
        dec: Angle.Degrees(-49.19543876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118106"},
        {"Hipparcos Number", "HIP 66342"},
        {"Smithsonian Astrophysical Observation", "SAO 224268"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.94500414),
        dec: Angle.Degrees(-49.19395775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85890",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85890"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.28670841),
        dec: Angle.Degrees(-49.19188415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96279"},
        {"Hipparcos Number", "HIP 54206"},
        {"Smithsonian Astrophysical Observation", "SAO 222553"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.35324658),
        dec: Angle.Degrees(-49.18928639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50098"},
        {"Hipparcos Number", "HIP 32683"},
        {"Smithsonian Astrophysical Observation", "SAO 218224"},
    },
    visualMagnitude: 8.06,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.27280616),
        dec: Angle.Degrees(-49.18913960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57693"},
        {"Hipparcos Number", "HIP 35513"},
        {"Smithsonian Astrophysical Observation", "SAO 218648"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.95985940),
        dec: Angle.Degrees(-49.18684215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 97.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55862"},
        {"Hipparcos Number", "HIP 34803"},
        {"Geneva Identification System", "GEN# +1.00055862"},
        {"Smithsonian Astrophysical Observation", "SAO 218531"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.06791129),
        dec: Angle.Degrees(-49.18604829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69730"},
        {"Hipparcos Number", "HIP 40490"},
        {"Celescope Catalog", "CEL 2300"},
        {"Geneva Identification System", "GEN# +1.00069730"},
        {"Smithsonian Astrophysical Observation", "SAO 219702"},
    },
    visualMagnitude: 8.30,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.00614570),
        dec: Angle.Degrees(-49.18528280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1871"},
        {"Hipparcos Number", "HIP 1801"},
        {"Smithsonian Astrophysical Observation", "SAO 215072"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.70954004),
        dec: Angle.Degrees(-49.18476547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26405"},
        {"Hipparcos Number", "HIP 19300"},
        {"Smithsonian Astrophysical Observation", "SAO 216665"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.05984788),
        dec: Angle.Degrees(-49.18238404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105690"},
        {"Hipparcos Number", "HIP 59315"},
        {"Geneva Identification System", "GEN# +1.00105690"},
        {"Smithsonian Astrophysical Observation", "SAO 223254"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.52751381),
        dec: Angle.Degrees(-49.18059169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -149.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69514"},
        {"Hipparcos Number", "HIP 40427"},
        {"Celescope Catalog", "CEL 2289"},
        {"Geneva Identification System", "GEN# +1.00069514"},
        {"Smithsonian Astrophysical Observation", "SAO 219681"},
    },
    visualMagnitude: 8.06,
    bvColour: -0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.81532589),
        dec: Angle.Degrees(-49.18017179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133178"},
        {"Hipparcos Number", "HIP 73789"},
        {"Smithsonian Astrophysical Observation", "SAO 225421"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.23225474),
        dec: Angle.Degrees(-49.17838224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63913",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63913"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.45478524),
        dec: Angle.Degrees(-49.17745728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38580"},
        {"Hipparcos Number", "HIP 27055"},
        {"Smithsonian Astrophysical Observation", "SAO 217505"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.06431210),
        dec: Angle.Degrees(-49.17350132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207880"},
        {"Hipparcos Number", "HIP 108070"},
        {"Geneva Identification System", "GEN# +1.00207880"},
        {"Smithsonian Astrophysical Observation", "SAO 230888"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.43213240),
        dec: Angle.Degrees(-49.17316871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 113.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71187",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71187"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.39064272),
        dec: Angle.Degrees(-49.17172132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36300"},
        {"Hipparcos Number", "HIP 25604"},
        {"Geneva Identification System", "GEN# +1.00036300"},
        {"Smithsonian Astrophysical Observation", "SAO 217349"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.05745102),
        dec: Angle.Degrees(-49.15512316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 105.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29560"},
        {"Hipparcos Number", "HIP 21481"},
        {"Smithsonian Astrophysical Observation", "SAO 216897"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.19612863),
        dec: Angle.Degrees(-49.17148279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114007"},
        {"Hipparcos Number", "HIP 64105"},
        {"Smithsonian Astrophysical Observation", "SAO 223923"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.05891816),
        dec: Angle.Degrees(-49.17128603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30849"},
        {"Hipparcos Number", "HIP 22340"},
        {"Geneva Identification System", "GEN# +1.00030849"},
        {"Renson", "Renson 7970"},
        {"Smithsonian Astrophysical Observation", "SAO 217008"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.16049890),
        dec: Angle.Degrees(-49.16995866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46026"},
        {"Hipparcos Number", "HIP 30813"},
        {"Smithsonian Astrophysical Observation", "SAO 217953"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.11195574),
        dec: Angle.Degrees(-49.16734419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101479"},
        {"Hipparcos Number", "HIP 56939"},
        {"Smithsonian Astrophysical Observation", "SAO 222946"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.09450796),
        dec: Angle.Degrees(-49.16677585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94556"},
        {"Hipparcos Number", "HIP 53302"},
        {"Smithsonian Astrophysical Observation", "SAO 222408"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.52696989),
        dec: Angle.Degrees(-49.16543091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68496"},
        {"Hipparcos Number", "HIP 40024"},
        {"Geneva Identification System", "GEN# +2.25470006"},
        {"Smithsonian Astrophysical Observation", "SAO 219541"},
        {"Wilson Evans Batten Catalogue", "WEB 7807"},
        {"New General Catalogue", "NGC 2547 6"},
    },
    visualMagnitude: 7.93,
    bvColour: -0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.61354692),
        dec: Angle.Degrees(-49.16415400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68836",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68836"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.42456604),
        dec: Angle.Degrees(-49.16275102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75313",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75313"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.736,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.80585854),
        dec: Angle.Degrees(-49.16272541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119632"},
        {"Hipparcos Number", "HIP 67131"},
        {"Geneva Identification System", "GEN# +1.00119632"},
        {"Smithsonian Astrophysical Observation", "SAO 224398"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.37876125),
        dec: Angle.Degrees(-49.16187304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71386"},
        {"Hipparcos Number", "HIP 41261"},
        {"Geneva Identification System", "GEN# +1.00071386J"},
        {"Smithsonian Astrophysical Observation", "SAO 219900"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.777,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.26725014),
        dec: Angle.Degrees(-49.15973529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22165"},
        {"Hipparcos Number", "HIP 16468"},
        {"Smithsonian Astrophysical Observation", "SAO 216370"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.02328699),
        dec: Angle.Degrees(-49.15893504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94243"},
        {"Hipparcos Number", "HIP 53106"},
        {"Geneva Identification System", "GEN# +1.00094243"},
        {"Smithsonian Astrophysical Observation", "SAO 222385"},
    },
    visualMagnitude: 6.56,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.97204482),
        dec: Angle.Degrees(-49.15744084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200767"},
        {"Hipparcos Number", "HIP 104253"},
        {"Geneva Identification System", "GEN# +1.00200767"},
        {"Smithsonian Astrophysical Observation", "SAO 230529"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.81607993),
        dec: Angle.Degrees(-49.15652840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112853",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112853"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.80810415),
        dec: Angle.Degrees(-49.15594877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72838"},
        {"Hipparcos Number", "HIP 41938"},
        {"Geneva Identification System", "GEN# +1.00072838"},
        {"Smithsonian Astrophysical Observation", "SAO 220087"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.23487079),
        dec: Angle.Degrees(-49.15507615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23344"},
        {"Hipparcos Number", "HIP 17302"},
        {"Smithsonian Astrophysical Observation", "SAO 216452"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.55624268),
        dec: Angle.Degrees(-49.15165589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32743"},
        {"Hipparcos Number", "HIP 23482"},
        {"Geneva Identification System", "GEN# +1.00032743"},
        {"Smithsonian Astrophysical Observation", "SAO 217140"},
        {"Wilson Evans Batten Catalogue", "WEB 4571"},
    },
    visualMagnitude: 5.37,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.70302244),
        dec: Angle.Degrees(-49.15147328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59659"},
        {"Hipparcos Number", "HIP 36312"},
        {"Smithsonian Astrophysical Observation", "SAO 218751"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.12534264),
        dec: Angle.Degrees(-49.14980405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106504"},
        {"Hipparcos Number", "HIP 59751"},
        {"Smithsonian Astrophysical Observation", "SAO 223306"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.79758069),
        dec: Angle.Degrees(-49.14926985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16755"},
        {"Hipparcos Number", "HIP 12383"},
        {"Smithsonian Astrophysical Observation", "SAO 215994"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.85439246),
        dec: Angle.Degrees(-49.14832219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147633"},
        {"Hipparcos Number", "HIP 80448"},
        {"Smithsonian Astrophysical Observation", "SAO 226738"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.32364141),
        dec: Angle.Degrees(-49.14764348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52279"},
        {"Hipparcos Number", "HIP 33510"},
        {"Smithsonian Astrophysical Observation", "SAO 218354"},
    },
    visualMagnitude: 7.38,
    bvColour: -0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.48734265),
        dec: Angle.Degrees(-49.14678902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28119"},
        {"Hipparcos Number", "HIP 20516"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.94278208),
        dec: Angle.Degrees(-49.14551478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219075"},
        {"Hipparcos Number", "HIP 114659"},
        {"Smithsonian Astrophysical Observation", "SAO 231501"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.40595230),
        dec: Angle.Degrees(-49.14493965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116836"},
        {"Hipparcos Number", "HIP 65606"},
        {"Smithsonian Astrophysical Observation", "SAO 224149"},
    },
    visualMagnitude: 6.31,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.77666572),
        dec: Angle.Degrees(-49.14369544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168218"},
        {"Hipparcos Number", "HIP 89952"},
        {"Geneva Identification System", "GEN# +1.00168218"},
        {"Smithsonian Astrophysical Observation", "SAO 228938"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.29921768),
        dec: Angle.Degrees(-49.14345892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 577"},
        {"Hipparcos Number", "HIP 831"},
        {"Smithsonian Astrophysical Observation", "SAO 214988"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.53868415),
        dec: Angle.Degrees(-49.14331204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34"},
        {"Hipparcos Number", "HIP 435"},
        {"Geneva Identification System", "GEN# +1.00000034"},
        {"Smithsonian Astrophysical Observation", "SAO 214958"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.31357538),
        dec: Angle.Degrees(-49.14221463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104122"},
        {"Hipparcos Number", "HIP 58475"},
        {"Geneva Identification System", "GEN# +1.00104122"},
        {"Smithsonian Astrophysical Observation", "SAO 223152"},
    },
    visualMagnitude: 7.39,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.86780461),
        dec: Angle.Degrees(-49.14030461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24937"},
        {"Hipparcos Number", "HIP 18374"},
        {"Smithsonian Astrophysical Observation", "SAO 216555"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.91461152),
        dec: Angle.Degrees(-49.13853528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100708"},
        {"Hipparcos Number", "HIP 56497"},
        {"Geneva Identification System", "GEN# +1.00100708"},
        {"Smithsonian Astrophysical Observation", "SAO 222883"},
        {"Wilson Evans Batten Catalogue", "WEB 10153"},
    },
    visualMagnitude: 5.50,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.73751871),
        dec: Angle.Degrees(-49.13694740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -172.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 188.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52902"},
        {"Hipparcos Number", "HIP 33728"},
        {"Geneva Identification System", "GEN# +1.00052902"},
        {"Smithsonian Astrophysical Observation", "SAO 218381"},
    },
    visualMagnitude: 6.56,
    bvColour: 0.882,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.09841972),
        dec: Angle.Degrees(-49.13500356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91160",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91160"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.97150872),
        dec: Angle.Degrees(-49.13334599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88573",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88573"},
    },
    visualMagnitude: 11.12,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.27671129),
        dec: Angle.Degrees(-49.13276839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3405"},
        {"Hipparcos Number", "HIP 2888"},
        {"Geneva Identification System", "GEN# +1.00003405"},
        {"Smithsonian Astrophysical Observation", "SAO 215165"},
        {"Wilson Evans Batten Catalogue", "WEB 520"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.15680392),
        dec: Angle.Degrees(-49.13200111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 385.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -132.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83220"},
        {"Hipparcos Number", "HIP 47048"},
        {"Geneva Identification System", "GEN# +1.00083220"},
        {"Smithsonian Astrophysical Observation", "SAO 221307"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.81948686),
        dec: Angle.Degrees(-49.13030269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3359"},
        {"Hipparcos Number", "HIP 2848"},
        {"Geneva Identification System", "GEN# +1.00003359"},
        {"Smithsonian Astrophysical Observation", "SAO 215161"},
        {"Wilson Evans Batten Catalogue", "WEB 510"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.01693123),
        dec: Angle.Degrees(-49.12780855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 387.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -133.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76425"},
        {"Hipparcos Number", "HIP 43712"},
        {"Celescope Catalog", "CEL 3063"},
        {"Geneva Identification System", "GEN# +1.00076425"},
        {"Smithsonian Astrophysical Observation", "SAO 220643"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.53818811),
        dec: Angle.Degrees(-49.12737408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84818"},
        {"Hipparcos Number", "HIP 47952"},
        {"Smithsonian Astrophysical Observation", "SAO 221481"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.57110907),
        dec: Angle.Degrees(-49.12607085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82100"},
        {"Hipparcos Number", "HIP 46434"},
        {"Geneva Identification System", "GEN# +1.00082100"},
        {"Smithsonian Astrophysical Observation", "SAO 221192"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.05138517),
        dec: Angle.Degrees(-49.12406426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32313"},
        {"Hipparcos Number", "HIP 23211"},
        {"Geneva Identification System", "GEN# +1.00032313"},
        {"Smithsonian Astrophysical Observation", "SAO 217103"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.92351331),
        dec: Angle.Degrees(-49.12370952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26958"},
        {"Hipparcos Number", "HIP 19716"},
        {"Smithsonian Astrophysical Observation", "SAO 216707"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.36826385),
        dec: Angle.Degrees(-49.12189927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106939"},
        {"Hipparcos Number", "HIP 59978"},
        {"Smithsonian Astrophysical Observation", "SAO 223341"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.50625263),
        dec: Angle.Degrees(-49.12078914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81348"},
        {"Hipparcos Number", "HIP 46039"},
        {"Geneva Identification System", "GEN# +1.00081348"},
        {"Smithsonian Astrophysical Observation", "SAO 221123"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.84479055),
        dec: Angle.Degrees(-49.12014075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66022"},
        {"Hipparcos Number", "HIP 39054"},
        {"Smithsonian Astrophysical Observation", "SAO 219255"},
    },
    visualMagnitude: 8.68,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.84595456),
        dec: Angle.Degrees(-49.11990204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93513"},
        {"Hipparcos Number", "HIP 52734"},
        {"Smithsonian Astrophysical Observation", "SAO 222326"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.70990003),
        dec: Angle.Degrees(-49.11956959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207315"},
        {"Hipparcos Number", "HIP 107736"},
        {"Geneva Identification System", "GEN# +1.00207315"},
        {"Smithsonian Astrophysical Observation", "SAO 230853"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.36400497),
        dec: Angle.Degrees(-49.11845267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195267"},
        {"Hipparcos Number", "HIP 101338"},
        {"Smithsonian Astrophysical Observation", "SAO 230260"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.08156645),
        dec: Angle.Degrees(-49.11582130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13241"},
        {"Hipparcos Number", "HIP 9941"},
        {"Smithsonian Astrophysical Observation", "SAO 215779"},
    },
    visualMagnitude: 8.80,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.99422548),
        dec: Angle.Degrees(-49.11512173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151772"},
        {"Hipparcos Number", "HIP 82515"},
        {"Geneva Identification System", "GEN# +1.00151772"},
        {"Smithsonian Astrophysical Observation", "SAO 227314"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.96980543),
        dec: Angle.Degrees(-49.11498036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121502"},
        {"Hipparcos Number", "HIP 68131"},
        {"Smithsonian Astrophysical Observation", "SAO 224559"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.789,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.21399192),
        dec: Angle.Degrees(-49.11248640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43579"},
        {"Hipparcos Number", "HIP 29608"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.58966929),
        dec: Angle.Degrees(-49.11247592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142823"},
        {"Hipparcos Number", "HIP 78266"},
        {"Renson", "Renson 40500"},
        {"Smithsonian Astrophysical Observation", "SAO 226416"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.71725625),
        dec: Angle.Degrees(-49.11198164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87784"},
        {"Hipparcos Number", "HIP 49471"},
        {"Smithsonian Astrophysical Observation", "SAO 221772"},
    },
    visualMagnitude: 9.17,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.51197825),
        dec: Angle.Degrees(-49.10881140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149400"},
        {"Hipparcos Number", "HIP 81344"},
        {"Smithsonian Astrophysical Observation", "SAO 226956"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.19613213),
        dec: Angle.Degrees(-49.10851799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224751"},
        {"Hipparcos Number", "HIP 29"},
        {"Smithsonian Astrophysical Observation", "SAO 231891"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.09213106),
        dec: Angle.Degrees(-49.10795505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127530"},
        {"Hipparcos Number", "HIP 71176"},
        {"Geneva Identification System", "GEN# +1.00127530"},
        {"Smithsonian Astrophysical Observation", "SAO 225014"},
    },
    visualMagnitude: 8.27,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.35083547),
        dec: Angle.Degrees(-49.10758773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191237"},
        {"Hipparcos Number", "HIP 99451"},
        {"Geneva Identification System", "GEN# +1.00191237"},
        {"Smithsonian Astrophysical Observation", "SAO 230085"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.77559138),
        dec: Angle.Degrees(-49.10497605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96170"},
        {"Hipparcos Number", "HIP 54159"},
        {"Smithsonian Astrophysical Observation", "SAO 222545"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.18616461),
        dec: Angle.Degrees(-49.10436240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44666"},
        {"Hipparcos Number", "HIP 30132"},
        {"Smithsonian Astrophysical Observation", "SAO 217867"},
    },
    visualMagnitude: 6.81,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.11231671),
        dec: Angle.Degrees(-49.10431625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12620",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12620"},
        {"Smithsonian Astrophysical Observation", "SAO 216015"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.55570689),
        dec: Angle.Degrees(-49.10147313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97495"},
        {"Hipparcos Number", "HIP 54746"},
        {"Fundamental Katalog 5th Edition", "FK5 1291"},
        {"Geneva Identification System", "GEN# +1.00097495"},
        {"Renson", "Renson 28110"},
        {"Smithsonian Astrophysical Observation", "SAO 222639"},
        {"Wilson Evans Batten Catalogue", "WEB 9882"},
    },
    visualMagnitude: 5.37,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.13810684),
        dec: Angle.Degrees(-49.10107805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59565",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59565"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.22467040),
        dec: Angle.Degrees(-49.10095448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2547"},
        {"Hipparcos Number", "HIP 2261"},
        {"Geneva Identification System", "GEN# +1.00002547"},
        {"Smithsonian Astrophysical Observation", "SAO 215107"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.20728388),
        dec: Angle.Degrees(-49.09927688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202026"},
        {"Hipparcos Number", "HIP 104907"},
        {"Smithsonian Astrophysical Observation", "SAO 230591"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.75885893),
        dec: Angle.Degrees(-49.09753965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79622"},
        {"Hipparcos Number", "HIP 45264"},
        {"Geneva Identification System", "GEN# +1.00079622"},
        {"Smithsonian Astrophysical Observation", "SAO 220964"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.37981165),
        dec: Angle.Degrees(-49.09445591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86758",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86758"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.91314767),
        dec: Angle.Degrees(-49.09156057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133631"},
        {"Hipparcos Number", "HIP 74006"},
        {"Geneva Identification System", "GEN# +1.00133631"},
        {"Smithsonian Astrophysical Observation", "SAO 225456"},
    },
    visualMagnitude: 5.77,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.85805467),
        dec: Angle.Degrees(-49.08863539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1494"},
        {"Hipparcos Number", "HIP 1516"},
        {"Smithsonian Astrophysical Observation", "SAO 215049"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.73076624),
        dec: Angle.Degrees(-49.08688954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197201"},
        {"Hipparcos Number", "HIP 102349"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.06041930),
        dec: Angle.Degrees(-49.08620948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41295"},
        {"Hipparcos Number", "HIP 28552"},
        {"Smithsonian Astrophysical Observation", "SAO 217681"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.41150871),
        dec: Angle.Degrees(-49.08509411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222197"},
        {"Hipparcos Number", "HIP 116673"},
        {"Smithsonian Astrophysical Observation", "SAO 231712"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.66799887),
        dec: Angle.Degrees(-49.08480202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39823"},
        {"Hipparcos Number", "HIP 27760"},
        {"Geneva Identification System", "GEN# +1.00039823"},
        {"Smithsonian Astrophysical Observation", "SAO 217591"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.12496060),
        dec: Angle.Degrees(-49.08438057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24100"},
        {"Hipparcos Number", "HIP 17768"},
        {"Geneva Identification System", "GEN# +1.00024100"},
        {"Smithsonian Astrophysical Observation", "SAO 216496"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.06125951),
        dec: Angle.Degrees(-49.08231614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190805"},
        {"Hipparcos Number", "HIP 99260"},
        {"Geneva Identification System", "GEN# +1.00190805"},
        {"Smithsonian Astrophysical Observation", "SAO 230065"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.24104175),
        dec: Angle.Degrees(-49.07830508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196401"},
        {"Hipparcos Number", "HIP 101913"},
        {"Smithsonian Astrophysical Observation", "SAO 230308"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.77767802),
        dec: Angle.Degrees(-49.07593274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142"},
        {"Henry Draper 2", "HD 142A"},
        {"Hipparcos Number", "HIP 522"},
        {"Cincinnati Publication", "Ci 20 7"},
        {"Geneva Identification System", "GEN# +1.00000142"},
        {"Smithsonian Astrophysical Observation", "SAO 214963"},
        {"Wilson Evans Batten Catalogue", "WEB 90"},
    },
    visualMagnitude: 5.70,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.57776340),
        dec: Angle.Degrees(-49.07509405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 575.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145972"},
        {"Hipparcos Number", "HIP 79710"},
        {"Geneva Identification System", "GEN# +1.00145972"},
        {"Smithsonian Astrophysical Observation", "SAO 226611"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.01605942),
        dec: Angle.Degrees(-49.07475674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57303"},
        {"Hipparcos Number", "HIP 35357"},
        {"Smithsonian Astrophysical Observation", "SAO 218621"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.709,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.54660556),
        dec: Angle.Degrees(-49.07326816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9362"},
        {"Hipparcos Number", "HIP 7083"},
        {"Fundamental Katalog 5th Edition", "FK5 1044"},
        {"Geneva Identification System", "GEN# +1.00009362"},
        {"Smithsonian Astrophysical Observation", "SAO 215536"},
        {"Wilson Evans Batten Catalogue", "WEB 1527"},
    },
    visualMagnitude: 3.93,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.81242306),
        dec: Angle.Degrees(-49.07307701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 138.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 154.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106799",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106799"},
    },
    visualMagnitude: 10.61,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.47756687),
        dec: Angle.Degrees(-49.07007073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169767"},
        {"Hipparcos Number", "HIP 90568"},
        {"Geneva Identification System", "GEN# +1.00169767"},
        {"Smithsonian Astrophysical Observation", "SAO 229047"},
        {"Wilson Evans Batten Catalogue", "WEB 15509"},
    },
    visualMagnitude: 4.10,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.20723319),
        dec: Angle.Degrees(-49.07003097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 137.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -229.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102150"},
        {"Hipparcos Number", "HIP 57322"},
        {"Geneva Identification System", "GEN# +1.00102150"},
        {"Smithsonian Astrophysical Observation", "SAO 222997"},
    },
    visualMagnitude: 6.26,
    bvColour: 1.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.30273465),
        dec: Angle.Degrees(-49.06986940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100192"},
        {"Hipparcos Number", "HIP 56210"},
        {"Smithsonian Astrophysical Observation", "SAO 222840"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.84991415),
        dec: Angle.Degrees(-49.06838966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109963"},
        {"Hipparcos Number", "HIP 61733"},
        {"Smithsonian Astrophysical Observation", "SAO 223573"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.80181216),
        dec: Angle.Degrees(-49.06642312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183074"},
        {"Hipparcos Number", "HIP 95891"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.53459557),
        dec: Angle.Degrees(-49.06594946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217656"},
        {"Hipparcos Number", "HIP 113815"},
        {"Smithsonian Astrophysical Observation", "SAO 231408"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.72227072),
        dec: Angle.Degrees(-49.06385265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125570"},
        {"Hipparcos Number", "HIP 70194"},
        {"Smithsonian Astrophysical Observation", "SAO 224859"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.42983197),
        dec: Angle.Degrees(-49.06151896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92061",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92061"},
    },
    visualMagnitude: 11.49,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.46109423),
        dec: Angle.Degrees(-49.06126299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83719"},
        {"Hipparcos Number", "HIP 47359"},
        {"Celescope Catalog", "CEL 3353"},
        {"Geneva Identification System", "GEN# +1.00083719"},
        {"Smithsonian Astrophysical Observation", "SAO 221370"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.74230152),
        dec: Angle.Degrees(-49.06105274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110258",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110258"},
        {"Geneva Identification System", "GEN# +6.20145104"},
    },
    visualMagnitude: 10.93,
    bvColour: 1.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.00576494),
        dec: Angle.Degrees(-49.06058414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 255.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -167.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34060"},
        {"Hipparcos Number", "HIP 24222"},
        {"Geneva Identification System", "GEN# +1.00034060"},
        {"Renson", "Renson 8670"},
        {"Smithsonian Astrophysical Observation", "SAO 217234"},
    },
    visualMagnitude: 7.84,
    bvColour: -0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.01372224),
        dec: Angle.Degrees(-49.06026949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49852"},
        {"Hipparcos Number", "HIP 32579"},
        {"Geneva Identification System", "GEN# +1.00049852"},
        {"Smithsonian Astrophysical Observation", "SAO 218206"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.96671098),
        dec: Angle.Degrees(-49.06023028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81290"},
        {"Hipparcos Number", "HIP 46011"},
        {"Geneva Identification System", "GEN# +1.00081290"},
        {"Smithsonian Astrophysical Observation", "SAO 221119"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.75864964),
        dec: Angle.Degrees(-49.05852267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119631"},
        {"Hipparcos Number", "HIP 67128"},
        {"Smithsonian Astrophysical Observation", "SAO 224395"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.37321713),
        dec: Angle.Degrees(-49.05753904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92949"},
        {"Hipparcos Number", "HIP 52420"},
        {"Smithsonian Astrophysical Observation", "SAO 222274"},
        {"Wilson Evans Batten Catalogue", "WEB 17144"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.75433441),
        dec: Angle.Degrees(-49.05712452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151246"},
        {"Hipparcos Number", "HIP 82269"},
        {"Smithsonian Astrophysical Observation", "SAO 227240"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.15003484),
        dec: Angle.Degrees(-49.05674221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155238"},
        {"Hipparcos Number", "HIP 84207"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.20709046),
        dec: Angle.Degrees(-49.05504457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128617"},
        {"Hipparcos Number", "HIP 71658"},
        {"Geneva Identification System", "GEN# +1.00128617"},
        {"Smithsonian Astrophysical Observation", "SAO 225091"},
        {"Wilson Evans Batten Catalogue", "WEB 12350"},
    },
    visualMagnitude: 6.37,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.85267655),
        dec: Angle.Degrees(-49.05501516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -189.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43295"},
        {"Hipparcos Number", "HIP 29498"},
        {"Smithsonian Astrophysical Observation", "SAO 217786"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.23321727),
        dec: Angle.Degrees(-49.05472940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 167.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13780"},
        {"Hipparcos Number", "HIP 10314"},
        {"Geneva Identification System", "GEN# +1.00013780"},
        {"Smithsonian Astrophysical Observation", "SAO 215821"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.21406683),
        dec: Angle.Degrees(-49.05458328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210657"},
        {"Hipparcos Number", "HIP 109673"},
        {"Smithsonian Astrophysical Observation", "SAO 231031"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.837,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.25306000),
        dec: Angle.Degrees(-49.05370177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61947"},
        {"Hipparcos Number", "HIP 37276"},
        {"Smithsonian Astrophysical Observation", "SAO 218872"},
    },
    visualMagnitude: 6.97,
    bvColour: -0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.82001187),
        dec: Angle.Degrees(-49.05140511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70951"},
        {"Hipparcos Number", "HIP 41053"},
        {"Celescope Catalog", "CEL 2444"},
        {"Geneva Identification System", "GEN# +1.00070951"},
        {"Smithsonian Astrophysical Observation", "SAO 219851"},
    },
    visualMagnitude: 7.77,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.65322334),
        dec: Angle.Degrees(-49.05132256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120962"},
        {"Hipparcos Number", "HIP 67841"},
        {"Smithsonian Astrophysical Observation", "SAO 224513"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.44949523),
        dec: Angle.Degrees(-49.05110197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69624"},
        {"Hipparcos Number", "HIP 40446"},
        {"Celescope Catalog", "CEL 2293"},
        {"Geneva Identification System", "GEN# +1.00069624"},
        {"Smithsonian Astrophysical Observation", "SAO 219692"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.87597385),
        dec: Angle.Degrees(-49.05015981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69304"},
        {"Hipparcos Number", "HIP 40346"},
        {"Smithsonian Astrophysical Observation", "SAO 219654"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.56708389),
        dec: Angle.Degrees(-49.04947021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37277",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37277"},
        {"Smithsonian Astrophysical Observation", "SAO 218873"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.82189261),
        dec: Angle.Degrees(-49.04751240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32589"},
        {"Hipparcos Number", "HIP 23390"},
        {"Smithsonian Astrophysical Observation", "SAO 217127"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.41880717),
        dec: Angle.Degrees(-49.04679286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25097"},
        {"Hipparcos Number", "HIP 18484"},
        {"Smithsonian Astrophysical Observation", "SAO 216575"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.26423703),
        dec: Angle.Degrees(-49.04525937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141257"},
        {"Hipparcos Number", "HIP 77577"},
        {"Smithsonian Astrophysical Observation", "SAO 226260"},
    },
    visualMagnitude: 6.89,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.57284733),
        dec: Angle.Degrees(-49.04031438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185795"},
        {"Hipparcos Number", "HIP 97021"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.77525744),
        dec: Angle.Degrees(-49.03990404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99275"},
        {"Hipparcos Number", "HIP 55709"},
        {"Smithsonian Astrophysical Observation", "SAO 222777"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.23963533),
        dec: Angle.Degrees(-49.03940219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93307",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93307"},
    },
    visualMagnitude: 11.36,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.07386319),
        dec: Angle.Degrees(-49.03888688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183469"},
        {"Hipparcos Number", "HIP 96084"},
        {"Smithsonian Astrophysical Observation", "SAO 229732"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.02676289),
        dec: Angle.Degrees(-49.03864685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59342",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59342"},
    },
    visualMagnitude: 10.62,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.59407634),
        dec: Angle.Degrees(-49.03852130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70670",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70670"},
    },
    visualMagnitude: 10.62,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.81934178),
        dec: Angle.Degrees(-49.03762777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68451"},
        {"Hipparcos Number", "HIP 40011"},
        {"Celescope Catalog", "CEL 2205"},
        {"Geneva Identification System", "GEN# +2.25470004"},
        {"Smithsonian Astrophysical Observation", "SAO 219536"},
        {"Wilson Evans Batten Catalogue", "WEB 7803"},
        {"New General Catalogue", "NGC 2547 4"},
    },
    visualMagnitude: 7.32,
    bvColour: -0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.56704037),
        dec: Angle.Degrees(-49.03493088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113345"},
        {"Hipparcos Number", "HIP 63736"},
        {"Smithsonian Astrophysical Observation", "SAO 223873"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.91818265),
        dec: Angle.Degrees(-49.03377232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99433"},
        {"Hipparcos Number", "HIP 55798"},
        {"Smithsonian Astrophysical Observation", "SAO 222791"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.49419758),
        dec: Angle.Degrees(-49.02851165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223910"},
        {"Hipparcos Number", "HIP 117814"},
        {"Smithsonian Astrophysical Observation", "SAO 231833"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.41517841),
        dec: Angle.Degrees(-49.02556756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -152.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139930"},
        {"Hipparcos Number", "HIP 76971"},
        {"Smithsonian Astrophysical Observation", "SAO 226094"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.75217629),
        dec: Angle.Degrees(-49.02468545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65774"},
        {"Hipparcos Number", "HIP 38936"},
        {"Smithsonian Astrophysical Observation", "SAO 219222"},
    },
    visualMagnitude: 8.78,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.50373400),
        dec: Angle.Degrees(-49.02006072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95521"},
        {"Hipparcos Number", "HIP 53837"},
        {"Geneva Identification System", "GEN# +1.00095521"},
        {"Smithsonian Astrophysical Observation", "SAO 222501"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.20978471),
        dec: Angle.Degrees(-49.01969110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121638"},
        {"Hipparcos Number", "HIP 68207"},
        {"Smithsonian Astrophysical Observation", "SAO 224572"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.45234093),
        dec: Angle.Degrees(-49.01898857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36804"},
        {"Hipparcos Number", "HIP 25903"},
        {"Smithsonian Astrophysical Observation", "SAO 217384"},
    },
    visualMagnitude: 7.44,
    bvColour: -0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.93266312),
        dec: Angle.Degrees(-49.01849101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121899"},
        {"Hipparcos Number", "HIP 68359"},
        {"Geneva Identification System", "GEN# +1.00121899"},
        {"Smithsonian Astrophysical Observation", "SAO 224595"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.89497410),
        dec: Angle.Degrees(-49.01739277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92260"},
        {"Hipparcos Number", "HIP 52053"},
        {"Smithsonian Astrophysical Observation", "SAO 222212"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.55143122),
        dec: Angle.Degrees(-49.01669102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58446"},
        {"Hipparcos Number", "HIP 35816"},
        {"Smithsonian Astrophysical Observation", "SAO 218686"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.79901342),
        dec: Angle.Degrees(-49.01500784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67847"},
        {"Hipparcos Number", "HIP 39773"},
        {"Geneva Identification System", "GEN# +2.25470003"},
        {"Smithsonian Astrophysical Observation", "SAO 219451"},
        {"New General Catalogue", "NGC 2547 3"},
    },
    visualMagnitude: 6.66,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.92416285),
        dec: Angle.Degrees(-49.01048516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102202"},
        {"Hipparcos Number", "HIP 57359"},
        {"Smithsonian Astrophysical Observation", "SAO 223002"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.38822529),
        dec: Angle.Degrees(-49.00968496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -115.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126002"},
        {"Hipparcos Number", "HIP 70427"},
        {"Smithsonian Astrophysical Observation", "SAO 224897"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.11408961),
        dec: Angle.Degrees(-49.00719541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104990"},
        {"Hipparcos Number", "HIP 58956"},
        {"Smithsonian Astrophysical Observation", "SAO 223207"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.33442626),
        dec: Angle.Degrees(-49.00703259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204961"},
        {"Hipparcos Number", "HIP 106440"},
        {"Cincinnati Publication", "Ci 20 1290"},
        {"Geneva Identification System", "GEN# +1.00204961"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.39173448),
        dec: Angle.Degrees(-49.00701800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -818.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9067"},
        {"Hipparcos Number", "HIP 6861"},
        {"Geneva Identification System", "GEN# +1.00009067"},
        {"Smithsonian Astrophysical Observation", "SAO 215517"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.788,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.07861643),
        dec: Angle.Degrees(-49.00585150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22810"},
        {"Hipparcos Number", "HIP 16922"},
        {"Smithsonian Astrophysical Observation", "SAO 216414"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.44030759),
        dec: Angle.Degrees(-49.00553758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82984"},
        {"Hipparcos Number", "HIP 46914"},
        {"Celescope Catalog", "CEL 3328"},
        {"Geneva Identification System", "GEN# +1.00082984"},
        {"Smithsonian Astrophysical Observation", "SAO 221288"},
        {"Wilson Evans Batten Catalogue", "WEB 8844"},
    },
    visualMagnitude: 5.12,
    bvColour: -0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.43566625),
        dec: Angle.Degrees(-49.00509320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95471"},
        {"Hipparcos Number", "HIP 53808"},
        {"Smithsonian Astrophysical Observation", "SAO 222498"},
    },
    visualMagnitude: 9.03,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.14027160),
        dec: Angle.Degrees(-49.00508952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177388"},
        {"Hipparcos Number", "HIP 93857"},
        {"Smithsonian Astrophysical Observation", "SAO 229492"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.71841044),
        dec: Angle.Degrees(-49.00218199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56644",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56644"},
        {"Geneva Identification System", "GEN# -0.04806657"},
        {"Wilson Evans Batten Catalogue", "WEB 10184"},
    },
    visualMagnitude: 10.90,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.22810516),
        dec: Angle.Degrees(-49.00162947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40220"},
        {"Hipparcos Number", "HIP 27953"},
        {"Smithsonian Astrophysical Observation", "SAO 217616"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.71542106),
        dec: Angle.Degrees(-49.00104080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138347"},
        {"Hipparcos Number", "HIP 76171"},
        {"Smithsonian Astrophysical Observation", "SAO 225891"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.37124893),
        dec: Angle.Degrees(-49.00068796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65362"},
        {"Hipparcos Number", "HIP 38758"},
        {"Celescope Catalog", "CEL 2104"},
        {"Geneva Identification System", "GEN# +1.00065362"},
        {"Smithsonian Astrophysical Observation", "SAO 219167"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.01905596),
        dec: Angle.Degrees(-49.00037778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66615",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66615"},
        {"Smithsonian Astrophysical Observation", "SAO 224312"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.81659696),
        dec: Angle.Degrees(-48.99963025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118651"},
        {"Hipparcos Number", "HIP 66611"},
        {"Smithsonian Astrophysical Observation", "SAO 224311"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.81036462),
        dec: Angle.Degrees(-48.99743142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 297581"},
        {"Hipparcos Number", "HIP 48012"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.81550937),
        dec: Angle.Degrees(-48.99655665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20731"},
        {"Hipparcos Number", "HIP 15387"},
        {"Smithsonian Astrophysical Observation", "SAO 216253"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.59926668),
        dec: Angle.Degrees(-48.99649245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1739"},
        {"Hipparcos Number", "HIP 1705"},
        {"Smithsonian Astrophysical Observation", "SAO 215060"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.36527446),
        dec: Angle.Degrees(-48.99645315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219221"},
        {"Hipparcos Number", "HIP 114761"},
        {"Geneva Identification System", "GEN# +1.00219221"},
        {"Smithsonian Astrophysical Observation", "SAO 231507"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.69710445),
        dec: Angle.Degrees(-48.99608715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134179"},
        {"Hipparcos Number", "HIP 74242"},
        {"Geneva Identification System", "GEN# +1.00134179"},
        {"Smithsonian Astrophysical Observation", "SAO 225501"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.58252330),
        dec: Angle.Degrees(-48.99587563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218437"},
        {"Hipparcos Number", "HIP 114272"},
        {"Smithsonian Astrophysical Observation", "SAO 231452"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.16604251),
        dec: Angle.Degrees(-48.99494798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108462"},
        {"Hipparcos Number", "HIP 60817"},
        {"Smithsonian Astrophysical Observation", "SAO 223453"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.98590823),
        dec: Angle.Degrees(-48.99400241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53325"},
        {"Hipparcos Number", "HIP 33900"},
        {"Smithsonian Astrophysical Observation", "SAO 218400"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.54176552),
        dec: Angle.Degrees(-48.99384193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175145"},
        {"Hipparcos Number", "HIP 92977"},
        {"Geneva Identification System", "GEN# +1.00175145"},
        {"Smithsonian Astrophysical Observation", "SAO 229384"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.836,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.13350374),
        dec: Angle.Degrees(-48.99217129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77434"},
        {"Hipparcos Number", "HIP 44243"},
        {"Geneva Identification System", "GEN# +5.12050001"},
        {"Smithsonian Astrophysical Observation", "SAO 220752"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.15469281),
        dec: Angle.Degrees(-48.99114892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208168"},
        {"Hipparcos Number", "HIP 108250"},
        {"Smithsonian Astrophysical Observation", "SAO 230901"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.95781543),
        dec: Angle.Degrees(-48.98985461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90941"},
        {"Hipparcos Number", "HIP 51322"},
        {"Smithsonian Astrophysical Observation", "SAO 222089"},
    },
    visualMagnitude: 7.78,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.24624816),
        dec: Angle.Degrees(-48.98867132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66971"},
        {"Hipparcos Number", "HIP 39431"},
        {"Geneva Identification System", "GEN# +1.00066971"},
        {"Smithsonian Astrophysical Observation", "SAO 219365"},
    },
    visualMagnitude: 9.05,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.90695021),
        dec: Angle.Degrees(-48.98808184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25494"},
        {"Hipparcos Number", "HIP 18728"},
        {"Smithsonian Astrophysical Observation", "SAO 216597"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.17975390),
        dec: Angle.Degrees(-48.98662799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39488"},
        {"Hipparcos Number", "HIP 27572"},
        {"Geneva Identification System", "GEN# +1.00039488"},
        {"Smithsonian Astrophysical Observation", "SAO 217566"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.914,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.59779981),
        dec: Angle.Degrees(-48.98640073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77421"},
        {"Hipparcos Number", "HIP 44232"},
        {"Geneva Identification System", "GEN# +5.12050002"},
        {"Smithsonian Astrophysical Observation", "SAO 220747"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.13018975),
        dec: Angle.Degrees(-48.98447655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66210"},
        {"Hipparcos Number", "HIP 39122"},
        {"Celescope Catalog", "CEL 2133"},
        {"Geneva Identification System", "GEN# +1.00066210"},
        {"Smithsonian Astrophysical Observation", "SAO 219283"},
        {"Wilson Evans Batten Catalogue", "WEB 7673"},
    },
    visualMagnitude: 6.01,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.06132736),
        dec: Angle.Degrees(-48.98161594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175650"},
        {"Hipparcos Number", "HIP 93184"},
        {"Smithsonian Astrophysical Observation", "SAO 229409"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.71013762),
        dec: Angle.Degrees(-48.98085642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41186"},
        {"Hipparcos Number", "HIP 28492"},
        {"Geneva Identification System", "GEN# +1.00041186"},
        {"Smithsonian Astrophysical Observation", "SAO 217673"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.21962392),
        dec: Angle.Degrees(-48.97992126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191602"},
        {"Hipparcos Number", "HIP 99616"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.24246398),
        dec: Angle.Degrees(-48.97972492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33650"},
        {"Hipparcos Number", "HIP 23978"},
        {"Smithsonian Astrophysical Observation", "SAO 217204"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.30351783),
        dec: Angle.Degrees(-48.97945820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137540"},
        {"Hipparcos Number", "HIP 75754"},
        {"Geneva Identification System", "GEN# +1.00137540"},
        {"Smithsonian Astrophysical Observation", "SAO 225817"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.13347126),
        dec: Angle.Degrees(-48.97890550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215456"},
        {"Hipparcos Number", "HIP 112414"},
        {"Fundamental Katalog 5th Edition", "FK5 6008"},
        {"Geneva Identification System", "GEN# +1.00215456"},
        {"Smithsonian Astrophysical Observation", "SAO 231285"},
    },
    visualMagnitude: 6.63,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.53270684),
        dec: Angle.Degrees(-48.97870481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 207.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80664"},
        {"Hipparcos Number", "HIP 45724"},
        {"Smithsonian Astrophysical Observation", "SAO 221066"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.82555235),
        dec: Angle.Degrees(-48.97790046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26809"},
        {"Hipparcos Number", "HIP 19609"},
        {"Geneva Identification System", "GEN# +1.00026809"},
        {"Smithsonian Astrophysical Observation", "SAO 216691"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.02894546),
        dec: Angle.Degrees(-48.97681626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188985"},
        {"Hipparcos Number", "HIP 98431"},
        {"Geneva Identification System", "GEN# +1.00188985"},
        {"Smithsonian Astrophysical Observation", "SAO 229966"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.99311570),
        dec: Angle.Degrees(-48.97534153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31945"},
        {"Hipparcos Number", "HIP 23034"},
        {"Smithsonian Astrophysical Observation", "SAO 217078"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.29971479),
        dec: Angle.Degrees(-48.97340161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117036"},
        {"Hipparcos Number", "HIP 65742"},
        {"Geneva Identification System", "GEN# +1.00117036"},
        {"Smithsonian Astrophysical Observation", "SAO 224164"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.13776147),
        dec: Angle.Degrees(-48.97192443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109529",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109529"},
    },
    visualMagnitude: 10.64,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.80219729),
        dec: Angle.Degrees(-48.97058261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200766"},
        {"Hipparcos Number", "HIP 104251"},
        {"Geneva Identification System", "GEN# +1.00200766"},
        {"Smithsonian Astrophysical Observation", "SAO 230528"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.81409259),
        dec: Angle.Degrees(-48.97027893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219722"},
        {"Hipparcos Number", "HIP 115086"},
        {"Smithsonian Astrophysical Observation", "SAO 231540"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.64810316),
        dec: Angle.Degrees(-48.96864365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100609"},
        {"Hipparcos Number", "HIP 56437"},
        {"Smithsonian Astrophysical Observation", "SAO 222875"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.56176894),
        dec: Angle.Degrees(-48.96802991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182933"},
        {"Hipparcos Number", "HIP 95828"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.35877332),
        dec: Angle.Degrees(-48.96442758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -191.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 329920"},
        {"Hipparcos Number", "HIP 77378"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.93501470),
        dec: Angle.Degrees(-48.96404211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19817"},
        {"Hipparcos Number", "HIP 14656"},
        {"Geneva Identification System", "GEN# +1.00019817"},
        {"Renson", "Renson 4900"},
        {"Smithsonian Astrophysical Observation", "SAO 216189"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.34199988),
        dec: Angle.Degrees(-48.96276465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179434"},
        {"Hipparcos Number", "HIP 94593"},
        {"Smithsonian Astrophysical Observation", "SAO 229574"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.75319885),
        dec: Angle.Degrees(-48.96265777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110304"},
        {"Hipparcos Number", "HIP 61932"},
        {"Geneva Identification System", "GEN# +1.00110304J"},
        {"Smithsonian Astrophysical Observation", "SAO 223603"},
        {"Wilson Evans Batten Catalogue", "WEB 11010"},
    },
    visualMagnitude: 2.20,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.38002079),
        dec: Angle.Degrees(-48.95988553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -187.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223067"},
        {"Hipparcos Number", "HIP 117250"},
        {"Smithsonian Astrophysical Observation", "SAO 231772"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.62939847),
        dec: Angle.Degrees(-48.95820394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166490"},
        {"Hipparcos Number", "HIP 89310"},
        {"Smithsonian Astrophysical Observation", "SAO 228814"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.35765950),
        dec: Angle.Degrees(-48.95752803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114971"},
        {"Hipparcos Number", "HIP 64623"},
        {"Geneva Identification System", "GEN# +1.00114971"},
        {"Smithsonian Astrophysical Observation", "SAO 224000"},
        {"Wilson Evans Batten Catalogue", "WEB 11430"},
    },
    visualMagnitude: 5.84,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.68067991),
        dec: Angle.Degrees(-48.95680509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42853"},
        {"Hipparcos Number", "HIP 29285"},
        {"Geneva Identification System", "GEN# +1.00042853"},
        {"Smithsonian Astrophysical Observation", "SAO 217757"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.61648250),
        dec: Angle.Degrees(-48.95635782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71721"},
        {"Hipparcos Number", "HIP 41402"},
        {"Geneva Identification System", "GEN# +1.00071721"},
        {"Smithsonian Astrophysical Observation", "SAO 219935"},
    },
    visualMagnitude: 7.36,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.69035030),
        dec: Angle.Degrees(-48.95620014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85606"},
        {"Hipparcos Number", "HIP 48362"},
        {"Smithsonian Astrophysical Observation", "SAO 221549"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.89026329),
        dec: Angle.Degrees(-48.95399256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104792"},
        {"Hipparcos Number", "HIP 58840"},
        {"Smithsonian Astrophysical Observation", "SAO 223200"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.02223543),
        dec: Angle.Degrees(-48.95264599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86865"},
        {"Hipparcos Number", "HIP 49014"},
        {"Geneva Identification System", "GEN# +1.00086865"},
        {"Smithsonian Astrophysical Observation", "SAO 221680"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.98765176),
        dec: Angle.Degrees(-48.95160988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5311"},
        {"Hipparcos Number", "HIP 4261"},
        {"Geneva Identification System", "GEN# +1.00005311"},
        {"Smithsonian Astrophysical Observation", "SAO 215285"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.59875355),
        dec: Angle.Degrees(-48.94825905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66598",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66598"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.77006959),
        dec: Angle.Degrees(-48.94821137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174781"},
        {"Hipparcos Number", "HIP 92820"},
        {"Smithsonian Astrophysical Observation", "SAO 229361"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.69142368),
        dec: Angle.Degrees(-48.94771500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37260"},
        {"Hipparcos Number", "HIP 26164"},
        {"Renson", "Renson 9970"},
        {"Smithsonian Astrophysical Observation", "SAO 217408"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.66847984),
        dec: Angle.Degrees(-48.94753934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203935"},
        {"Hipparcos Number", "HIP 105897"},
        {"Smithsonian Astrophysical Observation", "SAO 230689"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.71307645),
        dec: Angle.Degrees(-48.94733671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98870"},
        {"Hipparcos Number", "HIP 55516"},
        {"Geneva Identification System", "GEN# +1.00098870"},
        {"Smithsonian Astrophysical Observation", "SAO 222749"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.755,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.56179579),
        dec: Angle.Degrees(-48.94533685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111915"},
        {"Hipparcos Number", "HIP 62867"},
        {"Fundamental Katalog 5th Edition", "FK5 3024"},
        {"Geneva Identification System", "GEN# +1.00111915"},
        {"Smithsonian Astrophysical Observation", "SAO 223731"},
        {"Wilson Evans Batten Catalogue", "WEB 11145"},
    },
    visualMagnitude: 4.33,
    bvColour: 1.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.27906907),
        dec: Angle.Degrees(-48.94325313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217380"},
        {"Hipparcos Number", "HIP 113643"},
        {"Smithsonian Astrophysical Observation", "SAO 231390"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.23305745),
        dec: Angle.Degrees(-48.94314674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40362"},
        {"Hipparcos Number", "HIP 28037"},
        {"Smithsonian Astrophysical Observation", "SAO 217628"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.93136263),
        dec: Angle.Degrees(-48.94281529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6579"},
        {"Hipparcos Number", "HIP 5153"},
        {"Smithsonian Astrophysical Observation", "SAO 215362"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.48993963),
        dec: Angle.Degrees(-48.94112725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200856"},
        {"Hipparcos Number", "HIP 104313"},
        {"Geneva Identification System", "GEN# +1.00200856"},
        {"Smithsonian Astrophysical Observation", "SAO 230536"},
    },
    visualMagnitude: 6.70,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.97432842),
        dec: Angle.Degrees(-48.94001436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162913"},
        {"Hipparcos Number", "HIP 87789"},
        {"Geneva Identification System", "GEN# +1.00162913"},
        {"Smithsonian Astrophysical Observation", "SAO 228548"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.99675932),
        dec: Angle.Degrees(-48.93940136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63244",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63244"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.38910613),
        dec: Angle.Degrees(-48.93677706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223875"},
        {"Hipparcos Number", "HIP 117799"},
        {"Smithsonian Astrophysical Observation", "SAO 231828"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.34466525),
        dec: Angle.Degrees(-48.93633576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28174"},
        {"Hipparcos Number", "HIP 20559"},
        {"Smithsonian Astrophysical Observation", "SAO 216784"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.06366159),
        dec: Angle.Degrees(-48.93587340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 127",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 127"},
    },
    visualMagnitude: 10.86,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.41208753),
        dec: Angle.Degrees(-48.93516169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -188.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3220"},
        {"Hipparcos Number", "HIP 2747"},
        {"Smithsonian Astrophysical Observation", "SAO 215151"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.76193151),
        dec: Angle.Degrees(-48.93468281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161068"},
        {"Hipparcos Number", "HIP 86943"},
        {"Smithsonian Astrophysical Observation", "SAO 228385"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.48673711),
        dec: Angle.Degrees(-48.93430090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18389"},
        {"Hipparcos Number", "HIP 13624"},
        {"Smithsonian Astrophysical Observation", "SAO 216099"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.86901270),
        dec: Angle.Degrees(-48.93309440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145597"},
        {"Hipparcos Number", "HIP 79571"},
        {"Smithsonian Astrophysical Observation", "SAO 226588"},
    },
    visualMagnitude: 6.75,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.53249551),
        dec: Angle.Degrees(-48.93275188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55526"},
        {"Hipparcos Number", "HIP 34670"},
        {"Fundamental Katalog 5th Edition", "FK5 2554"},
        {"Geneva Identification System", "GEN# +1.00055526"},
        {"Smithsonian Astrophysical Observation", "SAO 218513"},
        {"Smithsonian Astrophysical Observation 2", "SAO 218514"},
        {"Wilson Evans Batten Catalogue", "WEB 6933"},
    },
    visualMagnitude: 5.12,
    bvColour: 1.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.69791141),
        dec: Angle.Degrees(-48.93257706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 196.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88554"},
        {"Hipparcos Number", "HIP 49918"},
        {"Geneva Identification System", "GEN# +1.00088554"},
        {"Smithsonian Astrophysical Observation", "SAO 221848"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.88443988),
        dec: Angle.Degrees(-48.93249239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151019"},
        {"Hipparcos Number", "HIP 82159"},
        {"Smithsonian Astrophysical Observation", "SAO 227196"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.76890007),
        dec: Angle.Degrees(-48.93150121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120038"},
        {"Hipparcos Number", "HIP 67350"},
        {"Smithsonian Astrophysical Observation", "SAO 224439"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.854,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.05960189),
        dec: Angle.Degrees(-48.92935737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190857"},
        {"Hipparcos Number", "HIP 99275"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.27961441),
        dec: Angle.Degrees(-48.92625490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106869"},
        {"Hipparcos Number", "HIP 59926"},
        {"Geneva Identification System", "GEN# +1.00106869"},
        {"Smithsonian Astrophysical Observation", "SAO 223335"},
        {"Wilson Evans Batten Catalogue", "WEB 10647"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.38376950),
        dec: Angle.Degrees(-48.92548888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -263.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102577"},
        {"Hipparcos Number", "HIP 57584"},
        {"Smithsonian Astrophysical Observation", "SAO 223034"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.06685467),
        dec: Angle.Degrees(-48.92523279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74273"},
        {"Hipparcos Number", "HIP 42614"},
        {"Celescope Catalog", "CEL 2779"},
        {"Geneva Identification System", "GEN# +1.00074273"},
        {"Smithsonian Astrophysical Observation", "SAO 220282"},
        {"Wilson Evans Batten Catalogue", "WEB 8227"},
    },
    visualMagnitude: 5.90,
    bvColour: -0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.27218464),
        dec: Angle.Degrees(-48.92268900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83369",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83369"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.58473202),
        dec: Angle.Degrees(-48.92079338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83280"},
        {"Hipparcos Number", "HIP 47077"},
        {"Smithsonian Astrophysical Observation", "SAO 221322"},
    },
    visualMagnitude: 8.37,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.91635471),
        dec: Angle.Degrees(-48.92064116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35893"},
        {"Hipparcos Number", "HIP 25349"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.32777314),
        dec: Angle.Degrees(-48.92026710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153507"},
        {"Hipparcos Number", "HIP 83371"},
        {"Smithsonian Astrophysical Observation", "SAO 227563"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.59051662),
        dec: Angle.Degrees(-48.91856683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39177"},
        {"Hipparcos Number", "HIP 27408"},
        {"Smithsonian Astrophysical Observation", "SAO 217547"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.05530149),
        dec: Angle.Degrees(-48.91856603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84290"},
        {"Hipparcos Number", "HIP 47641"},
        {"Smithsonian Astrophysical Observation", "SAO 221421"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.69779706),
        dec: Angle.Degrees(-48.91732979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54843"},
        {"Hipparcos Number", "HIP 34398"},
        {"Geneva Identification System", "GEN# +1.00054843"},
        {"Smithsonian Astrophysical Observation", "SAO 218477"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.895,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.98196094),
        dec: Angle.Degrees(-48.91713952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64050",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64050"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.89957065),
        dec: Angle.Degrees(-48.91642409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63154"},
        {"Hipparcos Number", "HIP 37808"},
        {"Smithsonian Astrophysical Observation", "SAO 218957"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.28403844),
        dec: Angle.Degrees(-48.91533845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22287"},
        {"Hipparcos Number", "HIP 16553"},
        {"Smithsonian Astrophysical Observation", "SAO 216381"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.29009541),
        dec: Angle.Degrees(-48.91497560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25315"},
        {"Hipparcos Number", "HIP 18624"},
        {"Smithsonian Astrophysical Observation", "SAO 216589"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.78503157),
        dec: Angle.Degrees(-48.91472939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66463"},
        {"Hipparcos Number", "HIP 39231"},
        {"Celescope Catalog", "CEL 2142"},
        {"Geneva Identification System", "GEN# +1.00066463J"},
        {"Smithsonian Astrophysical Observation", "SAO 219317"},
    },
    visualMagnitude: 8.49,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.35918889),
        dec: Angle.Degrees(-48.91327039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108309"},
        {"Hipparcos Number", "HIP 60729"},
        {"Cincinnati Publication", "Ci 20 708"},
        {"Smithsonian Astrophysical Observation", "SAO 223443"},
        {"Wilson Evans Batten Catalogue", "WEB 10804"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.70296553),
        dec: Angle.Degrees(-48.91299818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -642.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141194"},
        {"Hipparcos Number", "HIP 77541"},
        {"Geneva Identification System", "GEN# +1.00141194"},
        {"Smithsonian Astrophysical Observation", "SAO 226254"},
        {"Wilson Evans Batten Catalogue", "WEB 13128"},
    },
    visualMagnitude: 5.86,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.48967022),
        dec: Angle.Degrees(-48.91238226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101433"},
        {"Hipparcos Number", "HIP 56918"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.02948733),
        dec: Angle.Degrees(-48.91046162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66192"},
        {"Hipparcos Number", "HIP 39111"},
        {"Geneva Identification System", "GEN# +1.00066192"},
        {"Smithsonian Astrophysical Observation", "SAO 219274"},
    },
    visualMagnitude: 7.36,
    bvColour: -0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.02324515),
        dec: Angle.Degrees(-48.90544665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26168"},
        {"Hipparcos Number", "HIP 19142"},
        {"Smithsonian Astrophysical Observation", "SAO 216644"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.895,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.54466342),
        dec: Angle.Degrees(-48.90373397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12618"},
        {"Hipparcos Number", "HIP 9510"},
        {"Smithsonian Astrophysical Observation", "SAO 215743"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.58684892),
        dec: Angle.Degrees(-48.90324568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145862"},
        {"Hipparcos Number", "HIP 79665"},
        {"Smithsonian Astrophysical Observation", "SAO 226602"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.86874773),
        dec: Angle.Degrees(-48.90274850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70746"},
        {"Hipparcos Number", "HIP 40957"},
        {"Celescope Catalog", "CEL 2421"},
        {"Geneva Identification System", "GEN# +1.00070746"},
        {"Smithsonian Astrophysical Observation", "SAO 219831"},
    },
    visualMagnitude: 8.59,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.37469440),
        dec: Angle.Degrees(-48.90073431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93093"},
        {"Hipparcos Number", "HIP 52503"},
        {"Geneva Identification System", "GEN# +1.00093093"},
        {"Smithsonian Astrophysical Observation", "SAO 222282"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.03011465),
        dec: Angle.Degrees(-48.89672646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220609"},
        {"Hipparcos Number", "HIP 115628"},
        {"Geneva Identification System", "GEN# +1.00220609"},
        {"Smithsonian Astrophysical Observation", "SAO 231601"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.35582740),
        dec: Angle.Degrees(-48.89379708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58877",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58877"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.14270295),
        dec: Angle.Degrees(-48.89240675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125365"},
        {"Hipparcos Number", "HIP 70067"},
        {"Smithsonian Astrophysical Observation", "SAO 224839"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.07625627),
        dec: Angle.Degrees(-48.89219989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210330"},
        {"Hipparcos Number", "HIP 109484"},
        {"Smithsonian Astrophysical Observation", "SAO 231011"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.70305584),
        dec: Angle.Degrees(-48.89062131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13516"},
        {"Hipparcos Number", "HIP 10149"},
        {"Geneva Identification System", "GEN# +1.00013516"},
        {"Smithsonian Astrophysical Observation", "SAO 215801"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.64428586),
        dec: Angle.Degrees(-48.88965056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83169"},
        {"Hipparcos Number", "HIP 47024"},
        {"Geneva Identification System", "GEN# +1.00083169"},
        {"Smithsonian Astrophysical Observation", "SAO 221304"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.75285616),
        dec: Angle.Degrees(-48.88950525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63547",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63547"},
    },
    visualMagnitude: 10.59,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.32421214),
        dec: Angle.Degrees(-48.88857095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154486"},
        {"Hipparcos Number", "HIP 83849"},
        {"Fundamental Katalog 5th Edition", "FK5 3361"},
        {"Smithsonian Astrophysical Observation", "SAO 227648"},
    },
    visualMagnitude: 6.93,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.03459665),
        dec: Angle.Degrees(-48.88370858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133399"},
        {"Hipparcos Number", "HIP 73881"},
        {"Geneva Identification System", "GEN# +1.00133399"},
        {"Smithsonian Astrophysical Observation", "SAO 225439"},
        {"Wilson Evans Batten Catalogue", "WEB 12619"},
    },
    visualMagnitude: 6.48,
    bvColour: -0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.51007058),
        dec: Angle.Degrees(-48.88336790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50336"},
        {"Hipparcos Number", "HIP 32787"},
        {"Smithsonian Astrophysical Observation", "SAO 218239"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.54443393),
        dec: Angle.Degrees(-48.88156491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58826"},
        {"Hipparcos Number", "HIP 35961"},
        {"Smithsonian Astrophysical Observation", "SAO 218709"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.19653519),
        dec: Angle.Degrees(-48.87927390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98479"},
        {"Hipparcos Number", "HIP 55275"},
        {"Smithsonian Astrophysical Observation", "SAO 222713"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.80978340),
        dec: Angle.Degrees(-48.87821288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199887"},
        {"Hipparcos Number", "HIP 103774"},
        {"Smithsonian Astrophysical Observation", "SAO 230485"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.42886706),
        dec: Angle.Degrees(-48.87816337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152966"},
        {"Hipparcos Number", "HIP 83116"},
        {"Geneva Identification System", "GEN# +1.00152966"},
        {"Smithsonian Astrophysical Observation", "SAO 227518"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.77320262),
        dec: Angle.Degrees(-48.87512564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17900"},
        {"Hipparcos Number", "HIP 13270"},
        {"Geneva Identification System", "GEN# +1.00017900"},
        {"Smithsonian Astrophysical Observation", "SAO 216067"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.67937588),
        dec: Angle.Degrees(-48.87353758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23228"},
        {"Hipparcos Number", "HIP 17216"},
        {"Smithsonian Astrophysical Observation", "SAO 216442"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.31208973),
        dec: Angle.Degrees(-48.87343121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155035"},
        {"Hipparcos Number", "HIP 84105"},
        {"Geneva Identification System", "GEN# +1.00155035"},
        {"Smithsonian Astrophysical Observation", "SAO 227699"},
    },
    visualMagnitude: 5.94,
    bvColour: 1.786,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.91114525),
        dec: Angle.Degrees(-48.87338828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127446"},
        {"Hipparcos Number", "HIP 71145"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.24972398),
        dec: Angle.Degrees(-48.87199533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66255"},
        {"Hipparcos Number", "HIP 39153"},
        {"Celescope Catalog", "CEL 2134"},
        {"Geneva Identification System", "GEN# +1.00066255"},
        {"Renson", "Renson 18250"},
        {"Smithsonian Astrophysical Observation", "SAO 219292"},
    },
    visualMagnitude: 6.13,
    bvColour: -0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.12068883),
        dec: Angle.Degrees(-48.87177402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7058",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7058"},
    },
    visualMagnitude: 10.18,
    bvColour: 1.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.74538030),
        dec: Angle.Degrees(-48.87079578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -348.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -208.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 273975"},
        {"Hipparcos Number", "HIP 24742"},
        {"Geneva Identification System", "GEN# +1.00273975"},
        {"Wilson Evans Batten Catalogue", "WEB 4789"},
    },
    visualMagnitude: 10.67,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.58132074),
        dec: Angle.Degrees(-48.86968828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 184.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -238.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64526"},
        {"Hipparcos Number", "HIP 38402"},
        {"Celescope Catalog", "CEL 2071"},
        {"Geneva Identification System", "GEN# +1.00064526"},
        {"Smithsonian Astrophysical Observation", "SAO 219085"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.01486567),
        dec: Angle.Degrees(-48.86829074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193507"},
        {"Hipparcos Number", "HIP 100485"},
        {"Smithsonian Astrophysical Observation", "SAO 230176"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.65120836),
        dec: Angle.Degrees(-48.86544959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12877"},
        {"Hipparcos Number", "HIP 9699"},
        {"Smithsonian Astrophysical Observation", "SAO 215759"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.18867142),
        dec: Angle.Degrees(-48.86282357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21607"},
        {"Hipparcos Number", "HIP 16084"},
        {"Geneva Identification System", "GEN# +1.00021607"},
        {"Smithsonian Astrophysical Observation", "SAO 216327"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.889,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.80080767),
        dec: Angle.Degrees(-48.86240472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131923"},
        {"Hipparcos Number", "HIP 73241"},
        {"Fundamental Katalog 5th Edition", "FK5 3178"},
        {"Geneva Identification System", "GEN# +1.00131923"},
        {"Smithsonian Astrophysical Observation", "SAO 225327"},
        {"Smithsonian Astrophysical Observation 2", "SAO 225328"},
        {"Wilson Evans Batten Catalogue", "WEB 12551"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.53672527),
        dec: Angle.Degrees(-48.86219210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -337.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87265"},
        {"Hipparcos Number", "HIP 49201"},
        {"Smithsonian Astrophysical Observation", "SAO 221720"},
    },
    visualMagnitude: 7.58,
    bvColour: -0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.63607228),
        dec: Angle.Degrees(-48.86205635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176691"},
        {"Hipparcos Number", "HIP 93618"},
        {"Smithsonian Astrophysical Observation", "SAO 229466"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.706,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.96992460),
        dec: Angle.Degrees(-48.86090059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212308"},
        {"Hipparcos Number", "HIP 110599"},
        {"Smithsonian Astrophysical Observation", "SAO 231120"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.09243180),
        dec: Angle.Degrees(-48.85977734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161379"},
        {"Hipparcos Number", "HIP 87092"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.847,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.93128254),
        dec: Angle.Degrees(-48.85664038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -203.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206442"},
        {"Hipparcos Number", "HIP 107262"},
        {"Smithsonian Astrophysical Observation", "SAO 230811"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.88415331),
        dec: Angle.Degrees(-48.85577598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60662",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60662"},
        {"Geneva Identification System", "GEN# -0.04807414"},
    },
    visualMagnitude: 10.73,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.49636728),
        dec: Angle.Degrees(-48.85393382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -595.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204747"},
        {"Hipparcos Number", "HIP 106345"},
        {"Smithsonian Astrophysical Observation", "SAO 230725"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.06572229),
        dec: Angle.Degrees(-48.85351879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19013"},
        {"Hipparcos Number", "HIP 14093"},
        {"Smithsonian Astrophysical Observation", "SAO 216140"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.43694982),
        dec: Angle.Degrees(-48.85350139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4343"},
        {"Hipparcos Number", "HIP 3548"},
        {"Smithsonian Astrophysical Observation", "SAO 215225"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.33419574),
        dec: Angle.Degrees(-48.83614785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166949"},
        {"Hipparcos Number", "HIP 89460"},
        {"Smithsonian Astrophysical Observation", "SAO 228845"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.86115625),
        dec: Angle.Degrees(-48.85163090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97312"},
        {"Hipparcos Number", "HIP 54670"},
        {"Smithsonian Astrophysical Observation", "SAO 222629"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.86434198),
        dec: Angle.Degrees(-48.85159679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11742"},
        {"Hipparcos Number", "HIP 8862"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.49724966),
        dec: Angle.Degrees(-48.85013579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66156",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66156"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.40949083),
        dec: Angle.Degrees(-48.84947217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58598",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58598"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.24195803),
        dec: Angle.Degrees(-48.84928400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127276"},
        {"Hipparcos Number", "HIP 71068"},
        {"Geneva Identification System", "GEN# +1.00127276"},
        {"Smithsonian Astrophysical Observation", "SAO 224999"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.00745343),
        dec: Angle.Degrees(-48.84901520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207157"},
        {"Hipparcos Number", "HIP 107658"},
        {"Smithsonian Astrophysical Observation", "SAO 230847"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.712,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.10343551),
        dec: Angle.Degrees(-48.84794281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81946"},
        {"Hipparcos Number", "HIP 46364"},
        {"Celescope Catalog", "CEL 3303"},
        {"Geneva Identification System", "GEN# +1.00081946"},
        {"Smithsonian Astrophysical Observation", "SAO 221181"},
    },
    visualMagnitude: 7.76,
    bvColour: -0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.81081799),
        dec: Angle.Degrees(-48.84626023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99935"},
        {"Hipparcos Number", "HIP 56065"},
        {"Smithsonian Astrophysical Observation", "SAO 222818"},
    },
    visualMagnitude: 9.44,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.36045187),
        dec: Angle.Degrees(-48.84571746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208467"},
        {"Hipparcos Number", "HIP 108410"},
        {"Smithsonian Astrophysical Observation", "SAO 230914"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.43038648),
        dec: Angle.Degrees(-48.84511184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223701"},
        {"Hipparcos Number", "HIP 117682"},
        {"Smithsonian Astrophysical Observation", "SAO 231817"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.98970719),
        dec: Angle.Degrees(-48.84464991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7359"},
        {"Hipparcos Number", "HIP 5672"},
        {"Smithsonian Astrophysical Observation", "SAO 215415"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.22144531),
        dec: Angle.Degrees(-48.84312896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102348"},
        {"Hipparcos Number", "HIP 57458"},
        {"Smithsonian Astrophysical Observation", "SAO 223021"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.67660809),
        dec: Angle.Degrees(-48.84309749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208831"},
        {"Hipparcos Number", "HIP 108620"},
        {"Renson", "Renson 58060"},
        {"Smithsonian Astrophysical Observation", "SAO 230932"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.06762379),
        dec: Angle.Degrees(-48.84153162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54236"},
        {"Henry Draper 2", "HD 54236A"},
        {"Hipparcos Number", "HIP 34208"},
        {"Smithsonian Astrophysical Observation", "SAO 218446"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.39606763),
        dec: Angle.Degrees(-48.84003398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127110"},
        {"Hipparcos Number", "HIP 70977"},
        {"Geneva Identification System", "GEN# +1.00127110"},
        {"Smithsonian Astrophysical Observation", "SAO 224981"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.75929403),
        dec: Angle.Degrees(-48.83599275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30242"},
        {"Hipparcos Number", "HIP 21971"},
        {"Smithsonian Astrophysical Observation", "SAO 216957"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.83757845),
        dec: Angle.Degrees(-48.83434870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157532"},
        {"Hipparcos Number", "HIP 85337"},
        {"Smithsonian Astrophysical Observation", "SAO 227952"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.58378581),
        dec: Angle.Degrees(-48.83413308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206629"},
        {"Hipparcos Number", "HIP 107358"},
        {"Smithsonian Astrophysical Observation", "SAO 230818"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.17381858),
        dec: Angle.Degrees(-48.83396161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20830"},
        {"Hipparcos Number", "HIP 15459"},
        {"Smithsonian Astrophysical Observation", "SAO 216259"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.84240179),
        dec: Angle.Degrees(-48.83183564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212057"},
        {"Hipparcos Number", "HIP 110467"},
        {"Smithsonian Astrophysical Observation", "SAO 231102"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.64316243),
        dec: Angle.Degrees(-48.83162225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61391"},
        {"Hipparcos Number", "HIP 37043"},
        {"Fundamental Katalog 5th Edition", "FK5 2591"},
        {"Geneva Identification System", "GEN# +1.00061391"},
        {"Smithsonian Astrophysical Observation", "SAO 218841"},
        {"Wilson Evans Batten Catalogue", "WEB 7350"},
    },
    visualMagnitude: 5.69,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.18302388),
        dec: Angle.Degrees(-48.83016970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192673"},
        {"Hipparcos Number", "HIP 100074"},
        {"Smithsonian Astrophysical Observation", "SAO 230136"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.54398242),
        dec: Angle.Degrees(-48.83015835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25741"},
        {"Hipparcos Number", "HIP 18874"},
        {"Smithsonian Astrophysical Observation", "SAO 216615"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.68768590),
        dec: Angle.Degrees(-48.82941796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143885"},
        {"Hipparcos Number", "HIP 78791"},
        {"Smithsonian Astrophysical Observation", "SAO 226487"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.27293225),
        dec: Angle.Degrees(-48.82767297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52061"},
        {"Hipparcos Number", "HIP 33446"},
        {"Smithsonian Astrophysical Observation", "SAO 218333"},
    },
    visualMagnitude: 8.59,
    bvColour: -0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.30955327),
        dec: Angle.Degrees(-48.82739157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132122"},
        {"Hipparcos Number", "HIP 73336"},
        {"Geneva Identification System", "GEN# +1.00132122"},
        {"Smithsonian Astrophysical Observation", "SAO 225341"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.79427788),
        dec: Angle.Degrees(-48.82606395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136859"},
        {"Hipparcos Number", "HIP 75451"},
        {"Smithsonian Astrophysical Observation", "SAO 225749"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.757,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.21486583),
        dec: Angle.Degrees(-48.82532031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120676"},
        {"Hipparcos Number", "HIP 67695"},
        {"Smithsonian Astrophysical Observation", "SAO 224493"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.00386117),
        dec: Angle.Degrees(-48.82274253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72660",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72660"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.84903499),
        dec: Angle.Degrees(-48.81902730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100555"},
        {"Hipparcos Number", "HIP 56413"},
        {"Geneva Identification System", "GEN# +1.00100555"},
        {"Smithsonian Astrophysical Observation", "SAO 222870"},
        {"Wilson Evans Batten Catalogue", "WEB 10138"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.726,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.48716531),
        dec: Angle.Degrees(-48.81893849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -272.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114854"},
        {"Hipparcos Number", "HIP 64558"},
        {"Smithsonian Astrophysical Observation", "SAO 223988"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.49518271),
        dec: Angle.Degrees(-48.81751268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212328"},
        {"Hipparcos Number", "HIP 110604"},
        {"Smithsonian Astrophysical Observation", "SAO 231121"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.11451896),
        dec: Angle.Degrees(-48.81563463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42979",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42979"},
        {"New General Catalogue", "NGC 2670 13"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.39046191),
        dec: Angle.Degrees(-48.81526336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166776"},
        {"Hipparcos Number", "HIP 89405"},
        {"Smithsonian Astrophysical Observation", "SAO 228836"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.67996277),
        dec: Angle.Degrees(-48.81336364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15709"},
        {"Hipparcos Number", "HIP 11626"},
        {"Smithsonian Astrophysical Observation", "SAO 215923"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.49688212),
        dec: Angle.Degrees(-48.81316450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110458"},
        {"Hipparcos Number", "HIP 62012"},
        {"Geneva Identification System", "GEN# +1.00110458"},
        {"Smithsonian Astrophysical Observation", "SAO 223614"},
        {"Wilson Evans Batten Catalogue", "WEB 11027"},
    },
    visualMagnitude: 4.66,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.64817140),
        dec: Angle.Degrees(-48.81303493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -123.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59618"},
        {"Hipparcos Number", "HIP 36299"},
        {"Smithsonian Astrophysical Observation", "SAO 218750"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.07821840),
        dec: Angle.Degrees(-48.81288825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27815"},
        {"Hipparcos Number", "HIP 20309"},
        {"Geneva Identification System", "GEN# +1.00027815"},
        {"Smithsonian Astrophysical Observation", "SAO 216758"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.26582052),
        dec: Angle.Degrees(-48.81128105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128377"},
        {"Hipparcos Number", "HIP 71552"},
        {"Smithsonian Astrophysical Observation", "SAO 225074"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.51581059),
        dec: Angle.Degrees(-48.80995130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224834"},
        {"Hipparcos Number", "HIP 88"},
        {"Geneva Identification System", "GEN# +1.00224834"},
        {"Smithsonian Astrophysical Observation", "SAO 231895"},
    },
    visualMagnitude: 5.71,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.26915958),
        dec: Angle.Degrees(-48.80985919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16158"},
        {"Hipparcos Number", "HIP 11936"},
        {"Smithsonian Astrophysical Observation", "SAO 215946"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.50596753),
        dec: Angle.Degrees(-48.80950317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148690"},
        {"Hipparcos Number", "HIP 80973"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.02604842),
        dec: Angle.Degrees(-48.80907561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10019"},
        {"Hipparcos Number", "HIP 7514"},
        {"Fundamental Katalog 5th Edition", "FK5 4146"},
        {"Geneva Identification System", "GEN# +1.00010019"},
        {"Smithsonian Astrophysical Observation", "SAO 215581"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.20138429),
        dec: Angle.Degrees(-48.80397896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114614",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114614"},
        {"Geneva Identification System", "GEN# +6.20145127"},
    },
    visualMagnitude: 10.78,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.28770751),
        dec: Angle.Degrees(-48.80391939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 163.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131227"},
        {"Hipparcos Number", "HIP 72906"},
        {"Smithsonian Astrophysical Observation", "SAO 225280"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.51230131),
        dec: Angle.Degrees(-48.80382159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2834"},
        {"Hipparcos Number", "HIP 2472"},
        {"Fundamental Katalog 5th Edition", "FK5 15"},
        {"Geneva Identification System", "GEN# +1.00002834"},
        {"Smithsonian Astrophysical Observation", "SAO 215131"},
        {"Wilson Evans Batten Catalogue", "WEB 452"},
    },
    visualMagnitude: 4.76,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.85356695),
        dec: Angle.Degrees(-48.80356171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 140.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118633"},
        {"Hipparcos Number", "HIP 66603"},
        {"Smithsonian Astrophysical Observation", "SAO 224309"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.79241431),
        dec: Angle.Degrees(-48.80250545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107266"},
        {"Hipparcos Number", "HIP 60151"},
        {"Smithsonian Astrophysical Observation", "SAO 223360"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.02052174),
        dec: Angle.Degrees(-48.80225959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219074"},
        {"Hipparcos Number", "HIP 114655"},
        {"Smithsonian Astrophysical Observation", "SAO 231498"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.39097842),
        dec: Angle.Degrees(-48.80001898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129181"},
        {"Hipparcos Number", "HIP 71933"},
        {"Geneva Identification System", "GEN# +1.00129181"},
        {"Smithsonian Astrophysical Observation", "SAO 225140"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.68166683),
        dec: Angle.Degrees(-48.79954062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95718"},
        {"Hipparcos Number", "HIP 53939"},
        {"Smithsonian Astrophysical Observation", "SAO 222509"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.55056984),
        dec: Angle.Degrees(-48.79844772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203107"},
        {"Hipparcos Number", "HIP 105477"},
        {"Smithsonian Astrophysical Observation", "SAO 230650"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.45630487),
        dec: Angle.Degrees(-48.79643624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106242"},
        {"Hipparcos Number", "HIP 59612"},
        {"Smithsonian Astrophysical Observation", "SAO 223290"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.37682064),
        dec: Angle.Degrees(-48.79616757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19491"},
        {"Hipparcos Number", "HIP 14415"},
        {"Smithsonian Astrophysical Observation", "SAO 216167"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.52377186),
        dec: Angle.Degrees(-48.79616678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144969"},
        {"Hipparcos Number", "HIP 79279"},
        {"Geneva Identification System", "GEN# +1.00144969"},
        {"Smithsonian Astrophysical Observation", "SAO 226558"},
        {"Wilson Evans Batten Catalogue", "WEB 13403"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.778,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.70479435),
        dec: Angle.Degrees(-48.79492110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168907"},
        {"Hipparcos Number", "HIP 90236"},
        {"Geneva Identification System", "GEN# +1.00168907"},
        {"Smithsonian Astrophysical Observation", "SAO 228990"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.16835642),
        dec: Angle.Degrees(-48.79222941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119629"},
        {"Hipparcos Number", "HIP 67125"},
        {"Geneva Identification System", "GEN# +1.00119629"},
        {"Smithsonian Astrophysical Observation", "SAO 224394"},
        {"Wilson Evans Batten Catalogue", "WEB 11819"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.36436765),
        dec: Angle.Degrees(-48.79172929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -143.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5275"},
        {"Hipparcos Number", "HIP 4232"},
        {"Geneva Identification System", "GEN# +1.00005275"},
        {"Smithsonian Astrophysical Observation", "SAO 215283"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.49601017),
        dec: Angle.Degrees(-48.79137617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76355",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76355"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.92394571),
        dec: Angle.Degrees(-48.79128112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130879"},
        {"Hipparcos Number", "HIP 72741"},
        {"Smithsonian Astrophysical Observation", "SAO 225255"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.07389663),
        dec: Angle.Degrees(-48.79085272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81995",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81995"},
    },
    visualMagnitude: 10.69,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.25537627),
        dec: Angle.Degrees(-48.79065937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18776"},
        {"Hipparcos Number", "HIP 13930"},
        {"Smithsonian Astrophysical Observation", "SAO 216126"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.87341468),
        dec: Angle.Degrees(-48.79063499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64723",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64723"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.99137637),
        dec: Angle.Degrees(-48.78938112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152298"},
        {"Hipparcos Number", "HIP 82772"},
        {"Smithsonian Astrophysical Observation", "SAO 227408"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.74116999),
        dec: Angle.Degrees(-48.78830020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147958"},
        {"Hipparcos Number", "HIP 80583"},
        {"Smithsonian Astrophysical Observation", "SAO 226771"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.80073724),
        dec: Angle.Degrees(-48.78783533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98359"},
        {"Hipparcos Number", "HIP 55208"},
        {"Geneva Identification System", "GEN# +1.00098359"},
        {"Smithsonian Astrophysical Observation", "SAO 222707"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.58265144),
        dec: Angle.Degrees(-48.78745544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88644"},
        {"Hipparcos Number", "HIP 49976"},
        {"Smithsonian Astrophysical Observation", "SAO 221856"},
    },
    visualMagnitude: 8.34,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.04304736),
        dec: Angle.Degrees(-48.78722062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189835"},
        {"Hipparcos Number", "HIP 98834"},
        {"Geneva Identification System", "GEN# +1.00189835"},
        {"Smithsonian Astrophysical Observation", "SAO 230019"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.05655286),
        dec: Angle.Degrees(-48.78672750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116717"},
        {"Hipparcos Number", "HIP 65551"},
        {"Smithsonian Astrophysical Observation", "SAO 224138"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.56970553),
        dec: Angle.Degrees(-48.78654334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27343"},
        {"Hipparcos Number", "HIP 19941"},
        {"Smithsonian Astrophysical Observation", "SAO 216734"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.15547327),
        dec: Angle.Degrees(-48.78546494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -130.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180960"},
        {"Hipparcos Number", "HIP 95113"},
        {"Smithsonian Astrophysical Observation", "SAO 229630"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.24103914),
        dec: Angle.Degrees(-48.78447169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196876"},
        {"Hipparcos Number", "HIP 102163"},
        {"Smithsonian Astrophysical Observation", "SAO 230327"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.51234032),
        dec: Angle.Degrees(-48.78337323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123797"},
        {"Hipparcos Number", "HIP 69299"},
        {"Geneva Identification System", "GEN# +2.54600109"},
        {"Geneva Identification System 2", "GEN# +2.54600157"},
        {"Smithsonian Astrophysical Observation", "SAO 224747"},
        {"Wilson Evans Batten Catalogue", "WEB 12087"},
        {"New General Catalogue", "NGC 5460 109"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.917,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.76056947),
        dec: Angle.Degrees(-48.78227564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178425"},
        {"Hipparcos Number", "HIP 94231"},
        {"Smithsonian Astrophysical Observation", "SAO 229535"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.871,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.73792160),
        dec: Angle.Degrees(-48.77885719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10240"},
        {"Hipparcos Number", "HIP 7702"},
        {"Geneva Identification System", "GEN# +1.00010240"},
        {"Smithsonian Astrophysical Observation", "SAO 215601"},
        {"Wilson Evans Batten Catalogue", "WEB 1646"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.78382377),
        dec: Angle.Degrees(-48.77557641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194503"},
        {"Hipparcos Number", "HIP 100946"},
        {"Smithsonian Astrophysical Observation", "SAO 230221"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.00253688),
        dec: Angle.Degrees(-48.77446860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201476"},
        {"Hipparcos Number", "HIP 104627"},
        {"Smithsonian Astrophysical Observation", "SAO 230568"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.91075793),
        dec: Angle.Degrees(-48.77353574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79349"},
        {"Hipparcos Number", "HIP 45130"},
        {"Smithsonian Astrophysical Observation", "SAO 220942"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.92943334),
        dec: Angle.Degrees(-48.77322485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45035"},
        {"Hipparcos Number", "HIP 30320"},
        {"Smithsonian Astrophysical Observation", "SAO 217891"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.65466132),
        dec: Angle.Degrees(-48.77297186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83445"},
        {"Hipparcos Number", "HIP 47184"},
        {"Celescope Catalog", "CEL 3344"},
        {"Smithsonian Astrophysical Observation", "SAO 221346"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.23042758),
        dec: Angle.Degrees(-48.77210798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117148"},
        {"Hipparcos Number", "HIP 65804"},
        {"Smithsonian Astrophysical Observation", "SAO 224176"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.33150072),
        dec: Angle.Degrees(-48.77118803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195369"},
        {"Hipparcos Number", "HIP 101380"},
        {"Smithsonian Astrophysical Observation", "SAO 230264"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.20963796),
        dec: Angle.Degrees(-48.77061189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197985"},
        {"Hipparcos Number", "HIP 102751"},
        {"Geneva Identification System", "GEN# +1.00197985"},
        {"Smithsonian Astrophysical Observation", "SAO 230386"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.28975129),
        dec: Angle.Degrees(-48.76903745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -129.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101522"},
        {"Hipparcos Number", "HIP 56972"},
        {"Smithsonian Astrophysical Observation", "SAO 222952"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.17985628),
        dec: Angle.Degrees(-48.76895060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6897"},
        {"Hipparcos Number", "HIP 5380"},
        {"Smithsonian Astrophysical Observation", "SAO 215380"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.20763074),
        dec: Angle.Degrees(-48.76725538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75212"},
        {"Hipparcos Number", "HIP 43104"},
        {"Celescope Catalog", "CEL 2900"},
        {"Geneva Identification System", "GEN# +2.26700002"},
        {"Smithsonian Astrophysical Observation", "SAO 220446"},
        {"New General Catalogue", "NGC 2670 2"},
    },
    visualMagnitude: 8.38,
    bvColour: -0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.67658360),
        dec: Angle.Degrees(-48.76647900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89426"},
        {"Hipparcos Number", "HIP 50449"},
        {"Smithsonian Astrophysical Observation", "SAO 221944"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.51761907),
        dec: Angle.Degrees(-48.76647741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167956"},
        {"Hipparcos Number", "HIP 89840"},
        {"Smithsonian Astrophysical Observation", "SAO 228910"},
    },
    visualMagnitude: 6.56,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.00715104),
        dec: Angle.Degrees(-48.76517487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150135"},
        {"Hipparcos Number", "HIP 81696"},
        {"Geneva Identification System", "GEN# +2.61930002"},
        {"Smithsonian Astrophysical Observation", "SAO 227048"},
        {"Wilson Evans Batten Catalogue", "WEB 13795"},
        {"New General Catalogue", "NGC 6193 2"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.33101299),
        dec: Angle.Degrees(-48.76320515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210601"},
        {"Hipparcos Number", "HIP 109639"},
        {"Geneva Identification System", "GEN# +1.00210601"},
        {"Smithsonian Astrophysical Observation", "SAO 231027"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.14984189),
        dec: Angle.Degrees(-48.76297397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150136"},
        {"Hipparcos Number", "HIP 81702"},
        {"Geneva Identification System", "GEN# +2.61930001"},
        {"Smithsonian Astrophysical Observation", "SAO 227049"},
        {"Wilson Evans Batten Catalogue", "WEB 13796"},
        {"New General Catalogue", "NGC 6193 1"},
    },
    visualMagnitude: 5.57,
    bvColour: 0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.33506617),
        dec: Angle.Degrees(-48.76296994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10358"},
        {"Hipparcos Number", "HIP 7778"},
        {"Smithsonian Astrophysical Observation", "SAO 215607"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.02662877),
        dec: Angle.Degrees(-48.76118922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214292"},
        {"Hipparcos Number", "HIP 111737"},
        {"Smithsonian Astrophysical Observation", "SAO 231224"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.51574990),
        dec: Angle.Degrees(-48.75929297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72150",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72150"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.827,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.35958277),
        dec: Angle.Degrees(-48.75910893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150041"},
        {"Hipparcos Number", "HIP 81651"},
        {"Geneva Identification System", "GEN# +2.61930019"},
        {"Smithsonian Astrophysical Observation", "SAO 227038"},
        {"Smithsonian Astrophysical Observation 2", "SAO 227039"},
        {"Wilson Evans Batten Catalogue", "WEB 13788"},
        {"New General Catalogue", "NGC 6193 19"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.18575769),
        dec: Angle.Degrees(-48.75615984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145410"},
        {"Hipparcos Number", "HIP 79470"},
        {"Smithsonian Astrophysical Observation", "SAO 226574"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.27570204),
        dec: Angle.Degrees(-48.75558055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83368"},
        {"Hipparcos Number", "HIP 47145"},
        {"Celescope Catalog", "CEL 3340"},
        {"Geneva Identification System", "GEN# +1.00083368J"},
        {"Renson", "Renson 23770"},
        {"Smithsonian Astrophysical Observation", "SAO 221339"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.10588902),
        dec: Angle.Degrees(-48.75116061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 330036"},
        {"Hipparcos Number", "HIP 77662"},
    },
    visualMagnitude: 10.97,
    bvColour: 0.799,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.81638625),
        dec: Angle.Degrees(-48.74959149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72539"},
        {"Hipparcos Number", "HIP 41803"},
        {"Celescope Catalog", "CEL 2603"},
        {"Geneva Identification System", "GEN# +1.00072539"},
        {"Smithsonian Astrophysical Observation", "SAO 220046"},
    },
    visualMagnitude: 7.97,
    bvColour: -0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.84299969),
        dec: Angle.Degrees(-48.74915403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77594"},
        {"Hipparcos Number", "HIP 44340"},
        {"Geneva Identification System", "GEN# +1.00077594"},
        {"Smithsonian Astrophysical Observation", "SAO 220766"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.44635911),
        dec: Angle.Degrees(-48.74890790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189006"},
        {"Hipparcos Number", "HIP 98449"},
        {"Geneva Identification System", "GEN# +1.00189006"},
        {"Smithsonian Astrophysical Observation", "SAO 229969"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.04882471),
        dec: Angle.Degrees(-48.74836021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135055"},
        {"Hipparcos Number", "HIP 74636"},
        {"Smithsonian Astrophysical Observation", "SAO 225572"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.75215388),
        dec: Angle.Degrees(-48.74734038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149744"},
        {"Hipparcos Number", "HIP 81517"},
        {"Smithsonian Astrophysical Observation", "SAO 226996"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.75792482),
        dec: Angle.Degrees(-48.74717248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148104"},
        {"Hipparcos Number", "HIP 80671"},
        {"Smithsonian Astrophysical Observation", "SAO 226787"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.05365961),
        dec: Angle.Degrees(-48.74633639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134482"},
        {"Hipparcos Number", "HIP 74380"},
        {"Geneva Identification System", "GEN# +1.00134482"},
        {"Smithsonian Astrophysical Observation", "SAO 225526"},
        {"Wilson Evans Batten Catalogue", "WEB 12694"},
    },
    visualMagnitude: 5.70,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.99068761),
        dec: Angle.Degrees(-48.74357642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103840"},
        {"Hipparcos Number", "HIP 58290"},
        {"Geneva Identification System", "GEN# +1.00103840"},
        {"Smithsonian Astrophysical Observation", "SAO 223129"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.31561846),
        dec: Angle.Degrees(-48.74347111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -106.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16009",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16009"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.914,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.54456070),
        dec: Angle.Degrees(-48.74275697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49973",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49973"},
        {"Geneva Identification System", "GEN# -0.01703088"},
    },
    visualMagnitude: 9.93,
    bvColour: 1.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.03530939),
        dec: Angle.Degrees(-18.61772775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -498.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5632"},
        {"Hipparcos Number", "HIP 4484"},
        {"Smithsonian Astrophysical Observation", "SAO 215299"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.36336996),
        dec: Angle.Degrees(-48.74271397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44594"},
        {"Hipparcos Number", "HIP 30104"},
        {"Fundamental Katalog 5th Edition", "FK5 2486"},
        {"Geneva Identification System", "GEN# +1.00044594"},
        {"Smithsonian Astrophysical Observation", "SAO 217861"},
        {"Wilson Evans Batten Catalogue", "WEB 5989"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.02469907),
        dec: Angle.Degrees(-48.74044338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 235.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -267.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103510"},
        {"Hipparcos Number", "HIP 58109"},
        {"Smithsonian Astrophysical Observation", "SAO 223110"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.76049978),
        dec: Angle.Degrees(-48.74011132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75845",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75845"},
    },
    visualMagnitude: 11.88,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.38918874),
        dec: Angle.Degrees(-48.73944602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69278",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69278"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.72779276),
        dec: Angle.Degrees(-48.73855863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134481"},
        {"Hipparcos Number", "HIP 74376"},
        {"Celescope Catalog", "CEL 4347"},
        {"Fundamental Katalog 5th Edition", "FK5 1398"},
        {"Geneva Identification System", "GEN# +1.00134481A"},
        {"Geneva Identification System 2", "GEN# +1.00134481"},
        {"Smithsonian Astrophysical Observation", "SAO 225525"},
        {"Wilson Evans Batten Catalogue", "WEB 12691"},
    },
    visualMagnitude: 3.88,
    bvColour: -0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.98400434),
        dec: Angle.Degrees(-48.73770212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14812"},
        {"Hipparcos Number", "HIP 11011"},
        {"Smithsonian Astrophysical Observation", "SAO 215874"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.45390239),
        dec: Angle.Degrees(-48.73744973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140619"},
        {"Hipparcos Number", "HIP 77278"},
        {"Smithsonian Astrophysical Observation", "SAO 226174"},
    },
    visualMagnitude: 6.76,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.66819467),
        dec: Angle.Degrees(-48.73678986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104197"},
        {"Hipparcos Number", "HIP 58507"},
        {"Smithsonian Astrophysical Observation", "SAO 223159"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.98009422),
        dec: Angle.Degrees(-48.73641391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 110.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137731"},
        {"Hipparcos Number", "HIP 75840"},
        {"Geneva Identification System", "GEN# +1.00137731"},
        {"Smithsonian Astrophysical Observation", "SAO 225827"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.767,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.38624441),
        dec: Angle.Degrees(-48.73581508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103032"},
        {"Hipparcos Number", "HIP 57833"},
        {"Smithsonian Astrophysical Observation", "SAO 223072"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.90257178),
        dec: Angle.Degrees(-48.73532029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19948"},
        {"Hipparcos Number", "HIP 14749"},
        {"Geneva Identification System", "GEN# +1.00019948"},
        {"Smithsonian Astrophysical Observation", "SAO 216197"},
    },
    visualMagnitude: 6.11,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.61348238),
        dec: Angle.Degrees(-48.73409558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29414"},
        {"Hipparcos Number", "HIP 21391"},
        {"Smithsonian Astrophysical Observation", "SAO 216887"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.88150130),
        dec: Angle.Degrees(-48.73258919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18710"},
        {"Hipparcos Number", "HIP 13876"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.936,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.67744846),
        dec: Angle.Degrees(-48.73240196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124484"},
        {"Hipparcos Number", "HIP 69652"},
        {"Smithsonian Astrophysical Observation", "SAO 224795"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.82335641),
        dec: Angle.Degrees(-48.73078071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52901"},
        {"Hipparcos Number", "HIP 33732"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.10797787),
        dec: Angle.Degrees(-48.73035562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18240"},
        {"Hipparcos Number", "HIP 13514"},
        {"Geneva Identification System", "GEN# +1.00018240"},
        {"Smithsonian Astrophysical Observation", "SAO 216089"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.51132632),
        dec: Angle.Degrees(-48.72687171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -172.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104532"},
        {"Hipparcos Number", "HIP 58691"},
        {"Geneva Identification System", "GEN# +1.00104532"},
        {"Smithsonian Astrophysical Observation", "SAO 223179"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.55724327),
        dec: Angle.Degrees(-48.72487135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -191.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88917"},
        {"Hipparcos Number", "HIP 50137"},
        {"Geneva Identification System", "GEN# +1.00088917"},
        {"Smithsonian Astrophysical Observation", "SAO 221889"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.53225393),
        dec: Angle.Degrees(-48.72447210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115875"},
        {"Hipparcos Number", "HIP 65136"},
        {"Smithsonian Astrophysical Observation", "SAO 224077"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.21515710),
        dec: Angle.Degrees(-48.72210527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75045",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75045"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.02471109),
        dec: Angle.Degrees(-48.72178200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51799"},
        {"Hipparcos Number", "HIP 33357"},
        {"Geneva Identification System", "GEN# +1.00051799"},
        {"Smithsonian Astrophysical Observation", "SAO 218324"},
        {"Wilson Evans Batten Catalogue", "WEB 6704"},
    },
    visualMagnitude: 4.94,
    bvColour: 1.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.06662140),
        dec: Angle.Degrees(-48.72116448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171648"},
        {"Hipparcos Number", "HIP 91406"},
        {"Smithsonian Astrophysical Observation", "SAO 229162"},
    },
    visualMagnitude: 6.54,
    bvColour: 1.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.63166151),
        dec: Angle.Degrees(-48.72070507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109396"},
        {"Hipparcos Number", "HIP 61372"},
        {"Smithsonian Astrophysical Observation", "SAO 223525"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.64905051),
        dec: Angle.Degrees(-48.72011502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209551"},
        {"Hipparcos Number", "HIP 109047"},
        {"Fundamental Katalog 5th Edition", "FK5 5951"},
        {"Geneva Identification System", "GEN# +1.00209551"},
        {"Smithsonian Astrophysical Observation", "SAO 230972"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.35988462),
        dec: Angle.Degrees(-48.71854359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202501"},
        {"Hipparcos Number", "HIP 105133"},
        {"Fundamental Katalog 5th Edition", "FK5 1557"},
        {"Geneva Identification System", "GEN# +1.00202501"},
        {"Smithsonian Astrophysical Observation", "SAO 230614"},
    },
    visualMagnitude: 6.54,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.46900310),
        dec: Angle.Degrees(-48.71805467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206025"},
        {"Hipparcos Number", "HIP 107039"},
        {"Geneva Identification System", "GEN# +1.00206025"},
        {"Smithsonian Astrophysical Observation", "SAO 230786"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.17864887),
        dec: Angle.Degrees(-48.71612200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67165",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67165"},
    },
    visualMagnitude: 11.15,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.46204514),
        dec: Angle.Degrees(-48.71547807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77385"},
        {"Hipparcos Number", "HIP 44215"},
        {"Geneva Identification System", "GEN# +1.00077385"},
        {"Smithsonian Astrophysical Observation", "SAO 220743"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.09391239),
        dec: Angle.Degrees(-48.71444620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176641"},
        {"Hipparcos Number", "HIP 93599"},
        {"Smithsonian Astrophysical Observation", "SAO 229464"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.91834209),
        dec: Angle.Degrees(-48.71178571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155554"},
        {"Hipparcos Number", "HIP 84359"},
        {"Geneva Identification System", "GEN# +1.00155554"},
        {"Smithsonian Astrophysical Observation", "SAO 227737"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.70263951),
        dec: Angle.Degrees(-48.70825899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49235"},
        {"Hipparcos Number", "HIP 32328"},
        {"Smithsonian Astrophysical Observation", "SAO 218165"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.22727129),
        dec: Angle.Degrees(-48.70796414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216719"},
        {"Hipparcos Number", "HIP 113232"},
        {"Smithsonian Astrophysical Observation", "SAO 231359"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.95825169),
        dec: Angle.Degrees(-48.70787178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202413"},
        {"Hipparcos Number", "HIP 105088"},
        {"Smithsonian Astrophysical Observation", "SAO 230610"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.32373913),
        dec: Angle.Degrees(-48.70734649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36275"},
        {"Hipparcos Number", "HIP 25568"},
        {"Smithsonian Astrophysical Observation", "SAO 217345"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.97792074),
        dec: Angle.Degrees(-48.70403837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123247"},
        {"Hipparcos Number", "HIP 69011"},
        {"Geneva Identification System", "GEN# +2.54600003"},
        {"Geneva Identification System 2", "GEN# +2.54600066"},
        {"Smithsonian Astrophysical Observation", "SAO 224703"},
        {"New General Catalogue", "NGC 5460 3"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.92015867),
        dec: Angle.Degrees(-48.70395858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181349"},
        {"Hipparcos Number", "HIP 95230"},
        {"Smithsonian Astrophysical Observation", "SAO 229644"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.63064309),
        dec: Angle.Degrees(-48.69945650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19183"},
        {"Hipparcos Number", "HIP 14220"},
        {"Smithsonian Astrophysical Observation", "SAO 216153"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.84484508),
        dec: Angle.Degrees(-48.69939952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44245"},
        {"Hipparcos Number", "HIP 29946"},
        {"Fundamental Katalog 5th Edition", "FK5 4571"},
        {"Smithsonian Astrophysical Observation", "SAO 217836"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.56700372),
        dec: Angle.Degrees(-48.69897966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107478"},
        {"Hipparcos Number", "HIP 60262"},
        {"Smithsonian Astrophysical Observation", "SAO 223374"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.34963153),
        dec: Angle.Degrees(-48.69886839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62581"},
        {"Hipparcos Number", "HIP 37548"},
        {"Smithsonian Astrophysical Observation", "SAO 218916"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.59654261),
        dec: Angle.Degrees(-48.69864195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149189"},
        {"Hipparcos Number", "HIP 81229"},
        {"Geneva Identification System", "GEN# +1.00149189"},
        {"Smithsonian Astrophysical Observation", "SAO 226930"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.85566356),
        dec: Angle.Degrees(-48.69799886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -131.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126760"},
        {"Hipparcos Number", "HIP 70822"},
        {"Geneva Identification System", "GEN# +1.00126760"},
        {"Smithsonian Astrophysical Observation", "SAO 224952"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.24915345),
        dec: Angle.Degrees(-48.69689183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83463"},
        {"Hipparcos Number", "HIP 47192"},
        {"Celescope Catalog", "CEL 3345"},
        {"Geneva Identification System", "GEN# +1.00083463"},
        {"Smithsonian Astrophysical Observation", "SAO 221349"},
    },
    visualMagnitude: 8.84,
    bvColour: -0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.26930696),
        dec: Angle.Degrees(-48.69687588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156275"},
        {"Hipparcos Number", "HIP 84717"},
        {"Celescope Catalog", "CEL 4501"},
        {"Geneva Identification System", "GEN# +1.00156275"},
        {"Smithsonian Astrophysical Observation", "SAO 227815"},
    },
    visualMagnitude: 7.89,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.75910251),
        dec: Angle.Degrees(-48.69653744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81921"},
        {"Hipparcos Number", "HIP 46348"},
        {"Celescope Catalog", "CEL 3300"},
        {"Geneva Identification System", "GEN# +1.00081921"},
        {"Smithsonian Astrophysical Observation", "SAO 221177"},
    },
    visualMagnitude: 6.81,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.74559820),
        dec: Angle.Degrees(-48.69409289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211002"},
        {"Hipparcos Number", "HIP 109875"},
        {"Smithsonian Astrophysical Observation", "SAO 231048"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.81065532),
        dec: Angle.Degrees(-48.69397560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72876",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72876"},
    },
    visualMagnitude: 10.89,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.42657073),
        dec: Angle.Degrees(-18.34453219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 164.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121057"},
        {"Hipparcos Number", "HIP 67893"},
        {"Geneva Identification System", "GEN# +1.00121057"},
        {"Smithsonian Astrophysical Observation", "SAO 224519"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.58397290),
        dec: Angle.Degrees(-48.69272848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105416"},
        {"Hipparcos Number", "HIP 59184"},
        {"Geneva Identification System", "GEN# +1.00105416"},
        {"Smithsonian Astrophysical Observation", "SAO 223235"},
        {"Wilson Evans Batten Catalogue", "WEB 10529"},
    },
    visualMagnitude: 5.34,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.06137370),
        dec: Angle.Degrees(-48.69247036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76854",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76854"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.39138861),
        dec: Angle.Degrees(-48.69093329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55031",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55031"},
    },
    visualMagnitude: 12.30,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.98525455),
        dec: Angle.Degrees(-48.69069347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34570"},
        {"Hipparcos Number", "HIP 24541"},
        {"Geneva Identification System", "GEN# +1.00034570"},
        {"Smithsonian Astrophysical Observation", "SAO 217260"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.97922707),
        dec: Angle.Degrees(-48.69043766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71673"},
        {"Hipparcos Number", "HIP 41383"},
        {"Smithsonian Astrophysical Observation", "SAO 219926"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.63963306),
        dec: Angle.Degrees(-48.69040137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42191"},
        {"Hipparcos Number", "HIP 28972"},
        {"Geneva Identification System", "GEN# +1.00042191"},
        {"Smithsonian Astrophysical Observation", "SAO 217723"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.71567952),
        dec: Angle.Degrees(-48.68966481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75104"},
        {"Hipparcos Number", "HIP 43017"},
        {"Geneva Identification System", "GEN# +2.26700001"},
        {"Smithsonian Astrophysical Observation", "SAO 220424"},
        {"New General Catalogue", "NGC 2670 1"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.49621980),
        dec: Angle.Degrees(-48.68708488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64578"},
        {"Hipparcos Number", "HIP 38425"},
        {"Celescope Catalog", "CEL 2073"},
        {"Geneva Identification System", "GEN# +1.00064578"},
        {"Smithsonian Astrophysical Observation", "SAO 219090"},
    },
    visualMagnitude: 8.74,
    bvColour: -0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.07575355),
        dec: Angle.Degrees(-48.68534061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68161"},
        {"Hipparcos Number", "HIP 39919"},
        {"Geneva Identification System", "GEN# +1.00068161"},
        {"Geneva Identification System 2", "GEN# +2.25470001"},
        {"Renson", "Renson 18840"},
        {"Smithsonian Astrophysical Observation", "SAO 219493"},
        {"Wilson Evans Batten Catalogue", "WEB 7780"},
        {"New General Catalogue", "NGC 2547 1"},
    },
    visualMagnitude: 5.66,
    bvColour: -0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.28964371),
        dec: Angle.Degrees(-48.68440955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 957"},
        {"Hipparcos Number", "HIP 1101"},
        {"Fundamental Katalog 5th Edition", "FK5 2011"},
        {"Smithsonian Astrophysical Observation", "SAO 215009"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.43792976),
        dec: Angle.Degrees(-48.68413239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22948"},
        {"Hipparcos Number", "HIP 17014"},
        {"Smithsonian Astrophysical Observation", "SAO 216426"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.72080186),
        dec: Angle.Degrees(-48.68368984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86057",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86057"},
        {"Geneva Identification System", "GEN# -0.04811837"},
    },
    visualMagnitude: 10.13,
    bvColour: 1.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.80642798),
        dec: Angle.Degrees(-48.68197409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 456.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6264",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6264"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.08612937),
        dec: Angle.Degrees(-48.68185414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214367"},
        {"Hipparcos Number", "HIP 111784"},
        {"Smithsonian Astrophysical Observation", "SAO 231228"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.63087768),
        dec: Angle.Degrees(-48.68061726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165666"},
        {"Hipparcos Number", "HIP 88959"},
        {"Geneva Identification System", "GEN# +1.00165666"},
        {"Smithsonian Astrophysical Observation", "SAO 228744"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.38368252),
        dec: Angle.Degrees(-48.68017656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 297631"},
        {"Hipparcos Number", "HIP 48634"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.75550910),
        dec: Angle.Degrees(-48.67876964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119"},
        {"Hipparcos Number", "HIP 500"},
    },
    visualMagnitude: 9.57,
    bvColour: 1.812,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.50012278),
        dec: Angle.Degrees(-48.67872936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33180"},
        {"Hipparcos Number", "HIP 23717"},
        {"Smithsonian Astrophysical Observation", "SAO 217177"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.48148599),
        dec: Angle.Degrees(-48.67806163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183928"},
        {"Hipparcos Number", "HIP 96237"},
        {"Smithsonian Astrophysical Observation", "SAO 229743"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.53794063),
        dec: Angle.Degrees(-48.67734790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222969"},
        {"Hipparcos Number", "HIP 117187"},
        {"Geneva Identification System", "GEN# +1.00222969"},
        {"Smithsonian Astrophysical Observation", "SAO 231763"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.40554535),
        dec: Angle.Degrees(-48.67710734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -154.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8188"},
        {"Hipparcos Number", "HIP 6262"},
        {"Geneva Identification System", "GEN# +1.00008188"},
        {"Smithsonian Astrophysical Observation", "SAO 215464"},
        {"Wilson Evans Batten Catalogue", "WEB 1399"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.08268243),
        dec: Angle.Degrees(-48.67655056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71364"},
        {"Hipparcos Number", "HIP 41249"},
        {"Geneva Identification System", "GEN# +1.00071364"},
        {"Smithsonian Astrophysical Observation", "SAO 219897"},
    },
    visualMagnitude: 8.33,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.23494592),
        dec: Angle.Degrees(-48.67581217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178150"},
        {"Hipparcos Number", "HIP 94147"},
        {"Geneva Identification System", "GEN# +1.00178150"},
        {"Smithsonian Astrophysical Observation", "SAO 229527"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.822,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.45857019),
        dec: Angle.Degrees(-48.67373451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52988",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52988"},
    },
    visualMagnitude: 10.80,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.59966981),
        dec: Angle.Degrees(-48.67344315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199119"},
        {"Hipparcos Number", "HIP 103395"},
        {"Smithsonian Astrophysical Observation", "SAO 230448"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.21237853),
        dec: Angle.Degrees(-48.67144139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74885"},
        {"Hipparcos Number", "HIP 42914"},
        {"Geneva Identification System", "GEN# +1.00074885"},
        {"Smithsonian Astrophysical Observation", "SAO 220385"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.763,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.17627208),
        dec: Angle.Degrees(-48.67124584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197901"},
        {"Hipparcos Number", "HIP 102697"},
        {"Smithsonian Astrophysical Observation", "SAO 230376"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.13000493),
        dec: Angle.Degrees(-48.66978355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17302"},
        {"Hipparcos Number", "HIP 12829"},
        {"Smithsonian Astrophysical Observation", "SAO 216030"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.23573159),
        dec: Angle.Degrees(-48.66973329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11568"},
        {"Hipparcos Number", "HIP 8733"},
        {"Smithsonian Astrophysical Observation", "SAO 215688"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.09285389),
        dec: Angle.Degrees(-48.66913042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170388"},
        {"Hipparcos Number", "HIP 90823"},
        {"Geneva Identification System", "GEN# +1.00170388"},
        {"Smithsonian Astrophysical Observation", "SAO 229089"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.92200804),
        dec: Angle.Degrees(-48.66776197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111236"},
        {"Hipparcos Number", "HIP 62486"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.07567995),
        dec: Angle.Degrees(-48.66650173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103176"},
        {"Hipparcos Number", "HIP 57915"},
        {"Smithsonian Astrophysical Observation", "SAO 223080"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.18154257),
        dec: Angle.Degrees(-48.66502812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 297579"},
        {"Hipparcos Number", "HIP 48101"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.10999753),
        dec: Angle.Degrees(-48.66094415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156885"},
        {"Hipparcos Number", "HIP 85011"},
        {"Smithsonian Astrophysical Observation", "SAO 227876"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.62736870),
        dec: Angle.Degrees(-48.65939813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223600"},
        {"Hipparcos Number", "HIP 117605"},
        {"Fundamental Katalog 5th Edition", "FK5 3915"},
        {"Smithsonian Astrophysical Observation", "SAO 231806"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.75418856),
        dec: Angle.Degrees(-48.65935466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103855"},
        {"Hipparcos Number", "HIP 58310"},
        {"Geneva Identification System", "GEN# +1.00103855"},
        {"Smithsonian Astrophysical Observation", "SAO 223131"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.36137818),
        dec: Angle.Degrees(-48.65854214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129821"},
        {"Hipparcos Number", "HIP 72228"},
        {"Smithsonian Astrophysical Observation", "SAO 225177"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.57574863),
        dec: Angle.Degrees(-48.65500503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76482",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76482"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.31066238),
        dec: Angle.Degrees(-48.65480387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80229",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80229"},
        {"Cincinnati Publication", "Ci 20 983"},
    },
    visualMagnitude: 11.82,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.67281906),
        dec: Angle.Degrees(-48.65438229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -588.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -483.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81517"},
        {"Hipparcos Number", "HIP 46132"},
        {"Geneva Identification System", "GEN# +1.00081517"},
        {"Smithsonian Astrophysical Observation", "SAO 221140"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.11352065),
        dec: Angle.Degrees(-48.65370508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62420",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62420"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.88371811),
        dec: Angle.Degrees(-48.65306955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 330319"},
        {"Hipparcos Number", "HIP 78758"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.19981298),
        dec: Angle.Degrees(-48.65083270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211369"},
        {"Hipparcos Number", "HIP 110066"},
        {"Smithsonian Astrophysical Observation", "SAO 231069"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.41352404),
        dec: Angle.Degrees(-48.65023722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 204.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153221"},
        {"Hipparcos Number", "HIP 83216"},
        {"Geneva Identification System", "GEN# +1.00153221"},
        {"Smithsonian Astrophysical Observation", "SAO 227542"},
        {"Wilson Evans Batten Catalogue", "WEB 14067"},
    },
    visualMagnitude: 5.98,
    bvColour: 0.883,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.11239709),
        dec: Angle.Degrees(-48.64756342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9527"},
        {"Hipparcos Number", "HIP 7185"},
        {"Smithsonian Astrophysical Observation", "SAO 215546"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.922,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.13870894),
        dec: Angle.Degrees(-48.64534286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98339",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98339"},
        {"Geneva Identification System", "GEN# -0.01805550"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.70720888),
        dec: Angle.Degrees(-18.20287242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65515"},
        {"Hipparcos Number", "HIP 38833"},
        {"Smithsonian Astrophysical Observation", "SAO 219190"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.20367794),
        dec: Angle.Degrees(-48.64494703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 297725"},
        {"Hipparcos Number", "HIP 49248"},
    },
    visualMagnitude: 10.38,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.80113483),
        dec: Angle.Degrees(-48.64338536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222577"},
        {"Hipparcos Number", "HIP 116909"},
        {"Smithsonian Astrophysical Observation", "SAO 231742"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.47557193),
        dec: Angle.Degrees(-48.64267688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160415"},
        {"Hipparcos Number", "HIP 86647"},
        {"Geneva Identification System", "GEN# +1.00160415"},
        {"Smithsonian Astrophysical Observation", "SAO 228301"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.56115749),
        dec: Angle.Degrees(-48.64230142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64014"},
        {"Hipparcos Number", "HIP 38186"},
        {"Celescope Catalog", "CEL 2055"},
        {"Geneva Identification System", "GEN# +1.00064014"},
        {"Smithsonian Astrophysical Observation", "SAO 219043"},
    },
    visualMagnitude: 9.35,
    bvColour: -0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.37038915),
        dec: Angle.Degrees(-48.64115650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2801"},
        {"Hipparcos Number", "HIP 2446"},
        {"Smithsonian Astrophysical Observation", "SAO 215126"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.77378636),
        dec: Angle.Degrees(-48.64099363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34693"},
        {"Hipparcos Number", "HIP 24617"},
        {"Geneva Identification System", "GEN# +1.00034693"},
        {"Smithsonian Astrophysical Observation", "SAO 217269"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.20090125),
        dec: Angle.Degrees(-48.64073724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96660"},
        {"Hipparcos Number", "HIP 54380"},
        {"Smithsonian Astrophysical Observation", "SAO 222583"},
    },
    visualMagnitude: 6.44,
    bvColour: 1.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.89227103),
        dec: Angle.Degrees(-48.64003833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137157"},
        {"Hipparcos Number", "HIP 75569"},
        {"Geneva Identification System", "GEN# +1.00137157"},
        {"Smithsonian Astrophysical Observation", "SAO 225770"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.56874764),
        dec: Angle.Degrees(-48.63849653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126487"},
        {"Hipparcos Number", "HIP 70672"},
        {"Smithsonian Astrophysical Observation", "SAO 224930"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.82253880),
        dec: Angle.Degrees(-48.63615309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112456"},
        {"Hipparcos Number", "HIP 63229"},
        {"Smithsonian Astrophysical Observation", "SAO 223786"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.33999186),
        dec: Angle.Degrees(-48.63598152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194418"},
        {"Hipparcos Number", "HIP 100901"},
        {"Smithsonian Astrophysical Observation", "SAO 230217"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.87912487),
        dec: Angle.Degrees(-48.63576626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179931"},
        {"Hipparcos Number", "HIP 94753"},
        {"Geneva Identification System", "GEN# +1.00179931"},
        {"Smithsonian Astrophysical Observation", "SAO 229589"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.20799962),
        dec: Angle.Degrees(-48.63360247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221737"},
        {"Hipparcos Number", "HIP 116377"},
        {"Geneva Identification System", "GEN# +1.00221737"},
        {"Smithsonian Astrophysical Observation", "SAO 231674"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.723,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.73486147),
        dec: Angle.Degrees(-48.63161627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 242.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 329905"},
        {"Hipparcos Number", "HIP 77391"},
        {"Geneva Identification System", "GEN# +1.00329905"},
        {"Wilson Evans Batten Catalogue", "WEB 13106"},
    },
    visualMagnitude: 10.45,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.97880022),
        dec: Angle.Degrees(-48.63012698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97026"},
        {"Hipparcos Number", "HIP 54535"},
        {"Smithsonian Astrophysical Observation", "SAO 222599"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.40690301),
        dec: Angle.Degrees(-48.62985091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12086"},
        {"Hipparcos Number", "HIP 9108"},
        {"Smithsonian Astrophysical Observation", "SAO 215716"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.33058817),
        dec: Angle.Degrees(-48.62798094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111653"},
        {"Hipparcos Number", "HIP 62742"},
        {"Smithsonian Astrophysical Observation", "SAO 223712"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.84195162),
        dec: Angle.Degrees(-48.62659458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56715",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56715"},
        {"Geneva Identification System", "GEN# -0.04707000"},
    },
    visualMagnitude: 10.81,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.42393182),
        dec: Angle.Degrees(-48.62309534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -518.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -151.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11567"},
        {"Hipparcos Number", "HIP 8731"},
        {"Smithsonian Astrophysical Observation", "SAO 215687"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.08621404),
        dec: Angle.Degrees(-48.62131620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199212"},
        {"Hipparcos Number", "HIP 103451"},
        {"Smithsonian Astrophysical Observation", "SAO 230453"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.38147239),
        dec: Angle.Degrees(-48.62025234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92948"},
        {"Hipparcos Number", "HIP 52426"},
        {"Smithsonian Astrophysical Observation", "SAO 222275"},
    },
    visualMagnitude: 8.23,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.77000687),
        dec: Angle.Degrees(-48.61951049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130718"},
        {"Hipparcos Number", "HIP 72658"},
        {"Smithsonian Astrophysical Observation", "SAO 225241"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.84400172),
        dec: Angle.Degrees(-48.61941624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157555"},
        {"Hipparcos Number", "HIP 85342"},
        {"Geneva Identification System", "GEN# +1.00157555"},
        {"Smithsonian Astrophysical Observation", "SAO 227954"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.59340367),
        dec: Angle.Degrees(-48.61485438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64344"},
        {"Hipparcos Number", "HIP 38338"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.79489512),
        dec: Angle.Degrees(-48.61429408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12333"},
        {"Hipparcos Number", "HIP 9316"},
        {"Geneva Identification System", "GEN# +1.00012333"},
        {"Smithsonian Astrophysical Observation", "SAO 215729"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.728,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.92027222),
        dec: Angle.Degrees(-48.61378916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 226.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139261"},
        {"Hipparcos Number", "HIP 76645"},
        {"Smithsonian Astrophysical Observation", "SAO 226015"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.812,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.77665736),
        dec: Angle.Degrees(-48.61376254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141944"},
        {"Hipparcos Number", "HIP 77857"},
        {"Smithsonian Astrophysical Observation", "SAO 226343"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.47278262),
        dec: Angle.Degrees(-48.61212143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110983"},
        {"Hipparcos Number", "HIP 62326"},
        {"Geneva Identification System", "GEN# +1.00110983"},
        {"Smithsonian Astrophysical Observation", "SAO 223660"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.59408454),
        dec: Angle.Degrees(-48.61161463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9543"},
        {"Hipparcos Number", "HIP 7191"},
        {"Smithsonian Astrophysical Observation", "SAO 215548"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.16197906),
        dec: Angle.Degrees(-48.61108004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7922"},
        {"Hipparcos Number", "HIP 6079"},
        {"Smithsonian Astrophysical Observation", "SAO 215446"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.50282464),
        dec: Angle.Degrees(-48.60773181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141502"},
        {"Hipparcos Number", "HIP 77684"},
        {"Geneva Identification System", "GEN# +1.00141502"},
        {"Smithsonian Astrophysical Observation", "SAO 226293"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.89189440),
        dec: Angle.Degrees(-48.60639753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200904"},
        {"Hipparcos Number", "HIP 104335"},
    },
    visualMagnitude: 10.63,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.02985464),
        dec: Angle.Degrees(-48.60450817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112851"},
        {"Hipparcos Number", "HIP 63464"},
        {"Smithsonian Astrophysical Observation", "SAO 223827"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.07016099),
        dec: Angle.Degrees(-48.60370207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61715"},
        {"Hipparcos Number", "HIP 37174"},
        {"Geneva Identification System", "GEN# +1.00061715"},
        {"Smithsonian Astrophysical Observation", "SAO 218852"},
        {"Wilson Evans Batten Catalogue", "WEB 7368"},
    },
    visualMagnitude: 5.68,
    bvColour: 0.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.57588221),
        dec: Angle.Degrees(-48.60144811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109296"},
        {"Hipparcos Number", "HIP 61327"},
        {"Smithsonian Astrophysical Observation", "SAO 223515"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.48123765),
        dec: Angle.Degrees(-48.60138861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13397"},
        {"Hipparcos Number", "HIP 10080"},
        {"Geneva Identification System", "GEN# +1.00013397"},
        {"Smithsonian Astrophysical Observation", "SAO 215792"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.40891902),
        dec: Angle.Degrees(-48.59910124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216435"},
        {"Hipparcos Number", "HIP 113044"},
        {"Geneva Identification System", "GEN# +1.00216435"},
        {"Smithsonian Astrophysical Observation", "SAO 231343"},
    },
    visualMagnitude: 6.03,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.40725124),
        dec: Angle.Degrees(-48.59808759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 216.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90138",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90138"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.92181909),
        dec: Angle.Degrees(-48.59803771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166271"},
        {"Hipparcos Number", "HIP 89210"},
        {"Smithsonian Astrophysical Observation", "SAO 228794"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.08788742),
        dec: Angle.Degrees(-48.59436774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4738"},
        {"Hipparcos Number", "HIP 3802"},
        {"Geneva Identification System", "GEN# +1.00004738"},
        {"Smithsonian Astrophysical Observation", "SAO 215243"},
        {"Wilson Evans Batten Catalogue", "WEB 674"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.20958218),
        dec: Angle.Degrees(-48.59357671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194351"},
        {"Hipparcos Number", "HIP 100872"},
        {"Geneva Identification System", "GEN# +1.00194351"},
        {"Smithsonian Astrophysical Observation", "SAO 230214"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.79615233),
        dec: Angle.Degrees(-48.59313707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27552"},
        {"Hipparcos Number", "HIP 20107"},
        {"Smithsonian Astrophysical Observation", "SAO 216744"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.65980353),
        dec: Angle.Degrees(-48.59074975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157522"},
        {"Hipparcos Number", "HIP 85326"},
        {"Geneva Identification System", "GEN# +1.00157522"},
        {"Smithsonian Astrophysical Observation", "SAO 227948"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.55498531),
        dec: Angle.Degrees(-48.59034912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2028"},
        {"Hipparcos Number", "HIP 1920"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.06363472),
        dec: Angle.Degrees(-48.58875975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116491",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116491"},
        {"Geneva Identification System", "GEN# +6.20145139"},
    },
    visualMagnitude: 10.09,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.07660426),
        dec: Angle.Degrees(-48.58801079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -125.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192777"},
        {"Hipparcos Number", "HIP 100132"},
        {"Smithsonian Astrophysical Observation", "SAO 230142"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.68797369),
        dec: Angle.Degrees(-48.58785175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122159"},
        {"Hipparcos Number", "HIP 68485"},
        {"Geneva Identification System", "GEN# +1.00122159J"},
        {"Smithsonian Astrophysical Observation", "SAO 224619"},
    },
    visualMagnitude: 8.57,
    bvColour: -0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.31364096),
        dec: Angle.Degrees(-48.58705648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48709"},
        {"Hipparcos Number", "HIP 32071"},
        {"Smithsonian Astrophysical Observation", "SAO 218136"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.51805980),
        dec: Angle.Degrees(-48.58352347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136807"},
        {"Hipparcos Number", "HIP 75427"},
        {"Celescope Catalog", "CEL 4369"},
        {"Geneva Identification System", "GEN# +1.00136807J"},
        {"Smithsonian Astrophysical Observation", "SAO 225744"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.14981008),
        dec: Angle.Degrees(-48.58199774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62955",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62955"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.50293501),
        dec: Angle.Degrees(-48.58178820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113117"},
        {"Hipparcos Number", "HIP 63606"},
        {"Geneva Identification System", "GEN# +1.00113117"},
        {"Smithsonian Astrophysical Observation", "SAO 223852"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.53146979),
        dec: Angle.Degrees(-48.58156838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185973"},
        {"Hipparcos Number", "HIP 97093"},
        {"Geneva Identification System", "GEN# +1.00185973"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.98628999),
        dec: Angle.Degrees(-48.58099204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144554"},
        {"Hipparcos Number", "HIP 79092"},
        {"Smithsonian Astrophysical Observation", "SAO 226531"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.16580540),
        dec: Angle.Degrees(-48.57833243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219205"},
        {"Hipparcos Number", "HIP 114753"},
        {"Geneva Identification System", "GEN# +1.00219205"},
        {"Smithsonian Astrophysical Observation", "SAO 231505"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.67533163),
        dec: Angle.Degrees(-48.57802105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124309"},
        {"Hipparcos Number", "HIP 69542"},
        {"Fundamental Katalog 5th Edition", "FK5 5256"},
        {"Smithsonian Astrophysical Observation", "SAO 224777"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.54200524),
        dec: Angle.Degrees(-48.57745579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143153"},
        {"Hipparcos Number", "HIP 78440"},
        {"Smithsonian Astrophysical Observation", "SAO 226439"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.20851781),
        dec: Angle.Degrees(-48.57700422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73187"},
        {"Hipparcos Number", "HIP 42107"},
        {"Smithsonian Astrophysical Observation", "SAO 220142"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.75120523),
        dec: Angle.Degrees(-48.57532827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144812"},
        {"Hipparcos Number", "HIP 79207"},
        {"Geneva Identification System", "GEN# +1.00144812"},
        {"Smithsonian Astrophysical Observation", "SAO 226544"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.49644653),
        dec: Angle.Degrees(-48.57442542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5738"},
        {"Hipparcos Number", "HIP 4560"},
        {"Geneva Identification System", "GEN# +1.00005738"},
        {"Smithsonian Astrophysical Observation", "SAO 215307"},
        {"Wilson Evans Batten Catalogue", "WEB 832"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.58107862),
        dec: Angle.Degrees(-48.57338228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77020"},
        {"Hipparcos Number", "HIP 44024"},
        {"Geneva Identification System", "GEN# +1.00077020"},
        {"Smithsonian Astrophysical Observation", "SAO 220703"},
    },
    visualMagnitude: 5.88,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.48155402),
        dec: Angle.Degrees(-48.57293357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198158"},
        {"Hipparcos Number", "HIP 102859"},
        {"Smithsonian Astrophysical Observation", "SAO 230397"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.57641459),
        dec: Angle.Degrees(-48.57273591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80075"},
        {"Hipparcos Number", "HIP 45470"},
        {"Smithsonian Astrophysical Observation", "SAO 221008"},
    },
    visualMagnitude: 9.74,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.98182874),
        dec: Angle.Degrees(-48.57074949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45159"},
        {"Hipparcos Number", "HIP 30374"},
        {"Smithsonian Astrophysical Observation", "SAO 217901"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.80717558),
        dec: Angle.Degrees(-48.56983878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172063"},
        {"Hipparcos Number", "HIP 91582"},
        {"Geneva Identification System", "GEN# +1.00172063"},
        {"Smithsonian Astrophysical Observation", "SAO 229181"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.756,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.13931324),
        dec: Angle.Degrees(-48.56797489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 330929"},
        {"Hipparcos Number", "HIP 81123"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.52393131),
        dec: Angle.Degrees(-48.56769093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133939"},
        {"Hipparcos Number", "HIP 74128"},
        {"Geneva Identification System", "GEN# +1.00133939"},
        {"Smithsonian Astrophysical Observation", "SAO 225484"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.23847255),
        dec: Angle.Degrees(-48.56541526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190016"},
        {"Hipparcos Number", "HIP 98927"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.30256831),
        dec: Angle.Degrees(-48.56518778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89121"},
        {"Hipparcos Number", "HIP 50254"},
        {"Geneva Identification System", "GEN# +1.00089121"},
        {"Smithsonian Astrophysical Observation", "SAO 221915"},
        {"Wilson Evans Batten Catalogue", "WEB 9231"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.92099508),
        dec: Angle.Degrees(-48.56487973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49758"},
        {"Hipparcos Number", "HIP 32538"},
        {"Smithsonian Astrophysical Observation", "SAO 218197"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.84493757),
        dec: Angle.Degrees(-48.56366191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116226"},
        {"Hipparcos Number", "HIP 65303"},
        {"Fundamental Katalog 5th Edition", "FK5 3068"},
        {"Geneva Identification System", "GEN# +1.00116226"},
        {"Smithsonian Astrophysical Observation", "SAO 224096"},
        {"Wilson Evans Batten Catalogue", "WEB 11524"},
    },
    visualMagnitude: 6.37,
    bvColour: -0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.76086574),
        dec: Angle.Degrees(-48.56278579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155589"},
        {"Hipparcos Number", "HIP 84371"},
        {"Smithsonian Astrophysical Observation", "SAO 227740"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.73781985),
        dec: Angle.Degrees(-48.56018604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213796"},
        {"Hipparcos Number", "HIP 111465"},
        {"Smithsonian Astrophysical Observation", "SAO 231202"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.74576727),
        dec: Angle.Degrees(-48.55789509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73286B"},
        {"Hipparcos Number", "HIP 42156"},
        {"Smithsonian Astrophysical Observation", "SAO 220160"},
    },
    visualMagnitude: 10.48,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.90461748),
        dec: Angle.Degrees(-48.55218896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84552"},
        {"Hipparcos Number", "HIP 47793"},
        {"Celescope Catalog", "CEL 3375"},
        {"Geneva Identification System", "GEN# +1.00084552"},
        {"Smithsonian Astrophysical Observation", "SAO 221446"},
        {"Wilson Evans Batten Catalogue", "WEB 8948"},
    },
    visualMagnitude: 6.70,
    bvColour: -0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.15565318),
        dec: Angle.Degrees(-48.54888590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84787",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Inquill"},
        {"Henry Draper", "HD 156411"},
        {"Hipparcos Number", "HIP 84787"},
        {"Geneva Identification System", "GEN# +1.00156411"},
        {"Smithsonian Astrophysical Observation", "SAO 227825"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.96429319),
        dec: Angle.Degrees(-48.54880892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -209.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73286"},
        {"Hipparcos Number", "HIP 42154"},
        {"Smithsonian Astrophysical Observation", "SAO 220158"},
    },
    visualMagnitude: 8.19,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.90239211),
        dec: Angle.Degrees(-48.54831671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219343"},
        {"Hipparcos Number", "HIP 114824"},
        {"Smithsonian Astrophysical Observation", "SAO 231519"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.89761114),
        dec: Angle.Degrees(-48.54790504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196236"},
        {"Hipparcos Number", "HIP 101815"},
        {"Smithsonian Astrophysical Observation", "SAO 230303"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.49345758),
        dec: Angle.Degrees(-48.54567838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85412",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85412"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.80644586),
        dec: Angle.Degrees(-48.54433574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46836"},
        {"Hipparcos Number", "HIP 31223"},
        {"Geneva Identification System", "GEN# +1.00046836"},
        {"Smithsonian Astrophysical Observation", "SAO 218012"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.24038552),
        dec: Angle.Degrees(-48.54421709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -124.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64249"},
        {"Hipparcos Number", "HIP 38290"},
        {"Celescope Catalog", "CEL 2063"},
        {"Geneva Identification System", "GEN# +1.00064249"},
        {"Smithsonian Astrophysical Observation", "SAO 219062"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.66942718),
        dec: Angle.Degrees(-48.54305296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31895",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Nosaxa"},
        {"Henry Draper", "HD 48265"},
        {"Hipparcos Number", "HIP 31895"},
        {"Geneva Identification System", "GEN# +1.00048265"},
        {"Smithsonian Astrophysical Observation", "SAO 218115"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.00709846),
        dec: Angle.Degrees(-48.54202825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109787"},
        {"Hipparcos Number", "HIP 61622"},
        {"Geneva Identification System", "GEN# +1.00109787"},
        {"Smithsonian Astrophysical Observation", "SAO 223560"},
        {"Wilson Evans Batten Catalogue", "WEB 10961"},
    },
    visualMagnitude: 3.85,
    bvColour: 0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.42636588),
        dec: Angle.Degrees(-48.54128816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -186.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166651"},
        {"Hipparcos Number", "HIP 89363"},
        {"Geneva Identification System", "GEN# +1.00166651"},
        {"Smithsonian Astrophysical Observation", "SAO 228826"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.53271530),
        dec: Angle.Degrees(-48.54027150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191868"},
        {"Hipparcos Number", "HIP 99735"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.55069219),
        dec: Angle.Degrees(-48.53972930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20967",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20967"},
    },
    visualMagnitude: 11.29,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.43303066),
        dec: Angle.Degrees(-48.53831725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 241.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -304.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29930"},
        {"Hipparcos Number", "HIP 21771"},
        {"Geneva Identification System", "GEN# +1.00029930"},
        {"Smithsonian Astrophysical Observation", "SAO 216928"},
    },
    visualMagnitude: 6.90,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.14257290),
        dec: Angle.Degrees(-48.53829908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187314"},
        {"Hipparcos Number", "HIP 97721"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.88840644),
        dec: Angle.Degrees(-48.53826322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94592"},
        {"Hipparcos Number", "HIP 53328"},
        {"Smithsonian Astrophysical Observation", "SAO 222413"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.61717528),
        dec: Angle.Degrees(-48.53736665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132785"},
        {"Hipparcos Number", "HIP 73605"},
        {"Geneva Identification System", "GEN# +1.00132785"},
        {"Smithsonian Astrophysical Observation", "SAO 225394"},
        {"Wilson Evans Batten Catalogue", "WEB 12587"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.68293693),
        dec: Angle.Degrees(-48.53660959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89424",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89424"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.75775139),
        dec: Angle.Degrees(-48.53436911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131658"},
        {"Hipparcos Number", "HIP 73120"},
        {"Geneva Identification System", "GEN# +1.00131658"},
        {"Smithsonian Astrophysical Observation", "SAO 225309"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.16852057),
        dec: Angle.Degrees(-48.53357545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58018"},
        {"Hipparcos Number", "HIP 35652"},
        {"Geneva Identification System", "GEN# +1.00058018"},
        {"Smithsonian Astrophysical Observation", "SAO 218667"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.34606914),
        dec: Angle.Degrees(-48.53292662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213010"},
        {"Hipparcos Number", "HIP 111027"},
        {"Geneva Identification System", "GEN# +1.00213010"},
        {"Smithsonian Astrophysical Observation", "SAO 231157"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.38822364),
        dec: Angle.Degrees(-48.53006648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 135.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68511",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68511"},
    },
    visualMagnitude: 11.19,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.38714649),
        dec: Angle.Degrees(-48.52841934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24426"},
        {"Hipparcos Number", "HIP 18011"},
        {"Geneva Identification System", "GEN# +1.00024426"},
        {"Smithsonian Astrophysical Observation", "SAO 216522"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.74886349),
        dec: Angle.Degrees(-48.52712089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58017"},
        {"Hipparcos Number", "HIP 35648"},
        {"Geneva Identification System", "GEN# +1.00058017"},
        {"Smithsonian Astrophysical Observation", "SAO 218666"},
    },
    visualMagnitude: 6.83,
    bvColour: -0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.34237633),
        dec: Angle.Degrees(-48.52711555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158907"},
        {"Hipparcos Number", "HIP 85975"},
        {"Geneva Identification System", "GEN# +1.00158907"},
        {"Smithsonian Astrophysical Observation", "SAO 228126"},
    },
    visualMagnitude: 6.32,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.57037807),
        dec: Angle.Degrees(-48.52688385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 273832"},
        {"Hipparcos Number", "HIP 24296"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.20503288),
        dec: Angle.Degrees(-48.52669689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200625"},
        {"Hipparcos Number", "HIP 104163"},
        {"Geneva Identification System", "GEN# +1.00200625"},
        {"Smithsonian Astrophysical Observation", "SAO 230519"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.57134663),
        dec: Angle.Degrees(-48.52621179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112747"},
        {"Hipparcos Number", "HIP 63409"},
        {"Smithsonian Astrophysical Observation", "SAO 223812"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.88673730),
        dec: Angle.Degrees(-48.52618999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112746"},
        {"Hipparcos Number", "HIP 63403"},
        {"Smithsonian Astrophysical Observation", "SAO 223813"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.89132948),
        dec: Angle.Degrees(-48.52531791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186452"},
        {"Hipparcos Number", "HIP 97324"},
        {"Wilson Evans Batten Catalogue", "WEB 17100"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.67607368),
        dec: Angle.Degrees(-48.52500476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -336.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90812",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90812"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.87370252),
        dec: Angle.Degrees(-48.52471872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114155"},
        {"Hipparcos Number", "HIP 64199"},
        {"Geneva Identification System", "GEN# +1.00114155"},
        {"Smithsonian Astrophysical Observation", "SAO 223937"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.36490873),
        dec: Angle.Degrees(-48.52463613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88003"},
        {"Hipparcos Number", "HIP 49603"},
        {"Fundamental Katalog 5th Edition", "FK5 4901"},
        {"Geneva Identification System", "GEN# +1.00088003"},
        {"Smithsonian Astrophysical Observation", "SAO 221791"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.87311339),
        dec: Angle.Degrees(-48.52460953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27323",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27323"},
        {"Geneva Identification System", "GEN# -0.04801982"},
    },
    visualMagnitude: 9.74,
    bvColour: 1.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.82580489),
        dec: Angle.Degrees(-48.52435607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -320.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20414"},
        {"Hipparcos Number", "HIP 15133"},
        {"Smithsonian Astrophysical Observation", "SAO 216232"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.77843702),
        dec: Angle.Degrees(-48.52207939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106441"},
        {"Hipparcos Number", "HIP 59709"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.68713530),
        dec: Angle.Degrees(-48.52193201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221635"},
        {"Hipparcos Number", "HIP 116314"},
        {"Smithsonian Astrophysical Observation", "SAO 231667"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.49744147),
        dec: Angle.Degrees(-48.52182008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168032"},
        {"Hipparcos Number", "HIP 89869"},
        {"Smithsonian Astrophysical Observation", "SAO 228919"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.08614776),
        dec: Angle.Degrees(-48.51969675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118090"},
        {"Hipparcos Number", "HIP 66330"},
        {"Smithsonian Astrophysical Observation", "SAO 224267"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.90425772),
        dec: Angle.Degrees(-48.51759001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27365"},
        {"Hipparcos Number", "HIP 19966"},
        {"Geneva Identification System", "GEN# +1.00027365"},
        {"Smithsonian Astrophysical Observation", "SAO 216735"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.21972264),
        dec: Angle.Degrees(-48.51576861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84643"},
        {"Hipparcos Number", "HIP 47859"},
        {"Geneva Identification System", "GEN# +1.00084643"},
        {"Smithsonian Astrophysical Observation", "SAO 221461"},
        {"Wilson Evans Batten Catalogue", "WEB 8954"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.31784807),
        dec: Angle.Degrees(-48.51540401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57897"},
        {"Hipparcos Number", "HIP 35607"},
        {"Smithsonian Astrophysical Observation", "SAO 218662"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.21584696),
        dec: Angle.Degrees(-48.51412881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83266"},
        {"Hipparcos Number", "HIP 47074"},
        {"Geneva Identification System", "GEN# +1.00083266"},
        {"Renson", "Renson 23750"},
        {"Smithsonian Astrophysical Observation", "SAO 221320"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.90923509),
        dec: Angle.Degrees(-48.51360065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150535"},
        {"Hipparcos Number", "HIP 81915"},
        {"Geneva Identification System", "GEN# +1.00150535"},
        {"Smithsonian Astrophysical Observation", "SAO 227116"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.98001144),
        dec: Angle.Degrees(-48.51158232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182506"},
        {"Hipparcos Number", "HIP 95643"},
        {"Smithsonian Astrophysical Observation", "SAO 229681"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.82380231),
        dec: Angle.Degrees(-48.51127955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36987"},
        {"Hipparcos Number", "HIP 25983"},
        {"Smithsonian Astrophysical Observation", "SAO 217391"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.17863918),
        dec: Angle.Degrees(-48.50955548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32825",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32825"},
    },
    visualMagnitude: 11.95,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.64663167),
        dec: Angle.Degrees(-48.50950653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3186",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3186"},
    },
    visualMagnitude: 11.10,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.13775024),
        dec: Angle.Degrees(-48.50918772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 215.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135884"},
        {"Hipparcos Number", "HIP 74993"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.86380857),
        dec: Angle.Degrees(-48.50822279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120357"},
        {"Hipparcos Number", "HIP 67524"},
        {"Geneva Identification System", "GEN# +1.00120357"},
        {"Smithsonian Astrophysical Observation", "SAO 224474"},
    },
    visualMagnitude: 9.14,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.52802286),
        dec: Angle.Degrees(-48.50821653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88633",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88633"},
        {"Geneva Identification System", "GEN# +6.20145010"},
    },
    visualMagnitude: 11.31,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.45014684),
        dec: Angle.Degrees(-48.50756928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -125.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74285",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74285"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.72262445),
        dec: Angle.Degrees(-48.50727321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33894"},
        {"Hipparcos Number", "HIP 24126"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.73850644),
        dec: Angle.Degrees(-48.50709578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212997"},
        {"Hipparcos Number", "HIP 111011"},
        {"Smithsonian Astrophysical Observation", "SAO 231155"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.34899086),
        dec: Angle.Degrees(-48.50610273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175674"},
        {"Hipparcos Number", "HIP 93188"},
        {"Geneva Identification System", "GEN# +1.00175674J"},
        {"Smithsonian Astrophysical Observation", "SAO 229410"},
        {"Wilson Evans Batten Catalogue", "WEB 16151"},
    },
    visualMagnitude: 6.63,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.72081849),
        dec: Angle.Degrees(-48.50591349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79901"},
        {"Hipparcos Number", "HIP 45395"},
        {"Smithsonian Astrophysical Observation", "SAO 220995"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.76627706),
        dec: Angle.Degrees(-48.50376706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9002"},
        {"Hipparcos Number", "HIP 6810"},
        {"Smithsonian Astrophysical Observation", "SAO 215514"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.90651305),
        dec: Angle.Degrees(-48.50302070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151913"},
        {"Hipparcos Number", "HIP 82567"},
        {"Smithsonian Astrophysical Observation", "SAO 227330"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.16961358),
        dec: Angle.Degrees(-48.50244638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27845"},
        {"Hipparcos Number", "HIP 20331"},
        {"Geneva Identification System", "GEN# +1.00027845"},
        {"Smithsonian Astrophysical Observation", "SAO 216762"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.33969195),
        dec: Angle.Degrees(-48.49899814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -174.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67621"},
        {"Hipparcos Number", "HIP 39691"},
        {"Celescope Catalog", "CEL 2164"},
        {"Geneva Identification System", "GEN# +1.00067621"},
        {"Smithsonian Astrophysical Observation", "SAO 219427"},
        {"Wilson Evans Batten Catalogue", "WEB 7748"},
    },
    visualMagnitude: 6.34,
    bvColour: -0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.67338693),
        dec: Angle.Degrees(-48.49741254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123796"},
        {"Hipparcos Number", "HIP 69297"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.75604486),
        dec: Angle.Degrees(-48.49688209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84492"},
        {"Hipparcos Number", "HIP 47759"},
        {"Smithsonian Astrophysical Observation", "SAO 221441"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.05342240),
        dec: Angle.Degrees(-48.49641081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98802"},
        {"Hipparcos Number", "HIP 55479"},
        {"Smithsonian Astrophysical Observation", "SAO 222743"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.43790347),
        dec: Angle.Degrees(-48.49557684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216656"},
        {"Hipparcos Number", "HIP 113190"},
        {"Geneva Identification System", "GEN# +1.00216656J"},
        {"Smithsonian Astrophysical Observation", "SAO 231353"},
        {"Wilson Evans Batten Catalogue", "WEB 20146"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.81747479),
        dec: Angle.Degrees(-48.49188625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -226.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76138"},
        {"Hipparcos Number", "HIP 43579"},
        {"Smithsonian Astrophysical Observation", "SAO 220604"},
    },
    visualMagnitude: 8.53,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.12260875),
        dec: Angle.Degrees(-48.49166982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15205"},
        {"Hipparcos Number", "HIP 11297"},
        {"Smithsonian Astrophysical Observation", "SAO 215897"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.36510101),
        dec: Angle.Degrees(-48.49104112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12962"},
        {"Hipparcos Number", "HIP 9757"},
        {"Smithsonian Astrophysical Observation", "SAO 215765"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.37237880),
        dec: Angle.Degrees(-48.49058995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49718",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49718"},
    },
    visualMagnitude: 11.21,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.26252598),
        dec: Angle.Degrees(-48.49050208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70930"},
        {"Hipparcos Number", "HIP 41039"},
        {"Celescope Catalog", "CEL 2443"},
        {"Geneva Identification System", "GEN# +1.00070930"},
        {"Smithsonian Astrophysical Observation", "SAO 219848"},
        {"Wilson Evans Batten Catalogue", "WEB 7951"},
    },
    visualMagnitude: 4.79,
    bvColour: -0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.63207774),
        dec: Angle.Degrees(-48.49039742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86715"},
        {"Hipparcos Number", "HIP 48932"},
        {"Geneva Identification System", "GEN# +1.00086715"},
        {"Smithsonian Astrophysical Observation", "SAO 221659"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.74183108),
        dec: Angle.Degrees(-48.49017406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4055"},
        {"Hipparcos Number", "HIP 3332"},
        {"Smithsonian Astrophysical Observation", "SAO 215202"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.62373048),
        dec: Angle.Degrees(-48.48642243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81588"},
        {"Hipparcos Number", "HIP 46166"},
        {"Geneva Identification System", "GEN# +1.00081588"},
        {"Renson", "Renson 23190"},
        {"Smithsonian Astrophysical Observation", "SAO 221143"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.22680822),
        dec: Angle.Degrees(-48.48539548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178149"},
        {"Hipparcos Number", "HIP 94151"},
        {"Geneva Identification System", "GEN# +1.00178149"},
        {"Smithsonian Astrophysical Observation", "SAO 229528"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.46956334),
        dec: Angle.Degrees(-48.48460716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -459.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113053"},
        {"Hipparcos Number", "HIP 63578"},
        {"Smithsonian Astrophysical Observation", "SAO 223848"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.42600487),
        dec: Angle.Degrees(-48.48451453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209672"},
        {"Hipparcos Number", "HIP 109134"},
        {"Smithsonian Astrophysical Observation", "SAO 230981"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.59482247),
        dec: Angle.Degrees(-48.48372203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101349"},
        {"Hipparcos Number", "HIP 56857"},
        {"Geneva Identification System", "GEN# +1.00101349"},
        {"Smithsonian Astrophysical Observation", "SAO 222934"},
        {"Wilson Evans Batten Catalogue", "WEB 10239"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.85725930),
        dec: Angle.Degrees(-48.48156249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -163.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25074"},
        {"Hipparcos Number", "HIP 18469"},
        {"Geneva Identification System", "GEN# +1.00025074"},
        {"Smithsonian Astrophysical Observation", "SAO 216570"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.21399539),
        dec: Angle.Degrees(-48.47833792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26481"},
        {"Hipparcos Number", "HIP 19380"},
        {"Renson", "Renson 6720"},
        {"Smithsonian Astrophysical Observation", "SAO 216670"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.27799551),
        dec: Angle.Degrees(-48.47609417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47330"},
        {"Hipparcos Number", "HIP 31464"},
        {"Smithsonian Astrophysical Observation", "SAO 218044"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.86438433),
        dec: Angle.Degrees(-48.47598028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -142.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48487"},
        {"Hipparcos Number", "HIP 31990"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.26861168),
        dec: Angle.Degrees(-48.47593634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 148.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123226"},
        {"Hipparcos Number", "HIP 69005"},
        {"Geneva Identification System", "GEN# +2.54600013"},
        {"Smithsonian Astrophysical Observation", "SAO 224700"},
        {"New General Catalogue", "NGC 5460 13"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.90649899),
        dec: Angle.Degrees(-48.47112932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95427"},
        {"Hipparcos Number", "HIP 53779"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.05430844),
        dec: Angle.Degrees(-48.47062078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158890"},
        {"Hipparcos Number", "HIP 85968"},
        {"Smithsonian Astrophysical Observation", "SAO 228124"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.54868879),
        dec: Angle.Degrees(-48.46856960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179814"},
        {"Hipparcos Number", "HIP 94709"},
        {"Geneva Identification System", "GEN# +1.00179814"},
        {"Smithsonian Astrophysical Observation", "SAO 229582"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.07371672),
        dec: Angle.Degrees(-48.46623358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216655"},
        {"Hipparcos Number", "HIP 113191"},
        {"Geneva Identification System", "GEN# +1.00216655"},
        {"Smithsonian Astrophysical Observation", "SAO 231354"},
        {"Wilson Evans Batten Catalogue", "WEB 20145"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.81810812),
        dec: Angle.Degrees(-48.46594607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -226.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119070"},
        {"Hipparcos Number", "HIP 66854"},
        {"Geneva Identification System", "GEN# +1.00119070"},
        {"Smithsonian Astrophysical Observation", "SAO 224348"},
        {"Wilson Evans Batten Catalogue", "WEB 11786"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.51528438),
        dec: Angle.Degrees(-48.46544417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -172.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -148.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115173"},
        {"Hipparcos Number", "HIP 64746"},
        {"Smithsonian Astrophysical Observation", "SAO 224018"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.04303579),
        dec: Angle.Degrees(-48.46500230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121746"},
        {"Hipparcos Number", "HIP 68265"},
        {"Geneva Identification System", "GEN# +1.00121746"},
        {"Smithsonian Astrophysical Observation", "SAO 224581"},
        {"Wilson Evans Batten Catalogue", "WEB 11974"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.61683863),
        dec: Angle.Degrees(-48.46474973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84570",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84570"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.32630473),
        dec: Angle.Degrees(-48.46376358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113703"},
        {"Hipparcos Number", "HIP 63945"},
        {"Geneva Identification System", "GEN# +1.00113703A"},
        {"Smithsonian Astrophysical Observation", "SAO 223900"},
        {"Wilson Evans Batten Catalogue", "WEB 11299"},
    },
    visualMagnitude: 4.71,
    bvColour: -0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.56970994),
        dec: Angle.Degrees(-48.46325358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30953"},
        {"Hipparcos Number", "HIP 22427"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.732,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.38794237),
        dec: Angle.Degrees(-48.46297697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 86.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68657"},
        {"Hipparcos Number", "HIP 40077"},
        {"Celescope Catalog", "CEL 2217"},
        {"Geneva Identification System", "GEN# +1.00068657"},
        {"Smithsonian Astrophysical Observation", "SAO 219565"},
        {"Wilson Evans Batten Catalogue", "WEB 7820"},
    },
    visualMagnitude: 5.83,
    bvColour: -0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.79501934),
        dec: Angle.Degrees(-48.46200365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148974"},
        {"Hipparcos Number", "HIP 81125"},
        {"Geneva Identification System", "GEN# +1.00148974"},
        {"Smithsonian Astrophysical Observation", "SAO 226897"},
        {"Wilson Evans Batten Catalogue", "WEB 13715"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.52526509),
        dec: Angle.Degrees(-48.46148725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78187"},
        {"Hipparcos Number", "HIP 44597"},
        {"Smithsonian Astrophysical Observation", "SAO 220823"},
    },
    visualMagnitude: 8.87,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.28061864),
        dec: Angle.Degrees(-48.46044777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111519"},
        {"Hipparcos Number", "HIP 62655"},
        {"Geneva Identification System", "GEN# +1.00111519"},
        {"Renson", "Renson 32366"},
        {"Smithsonian Astrophysical Observation", "SAO 223698"},
    },
    visualMagnitude: 6.26,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.58136431),
        dec: Angle.Degrees(-48.45955963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100703",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100703"},
        {"Smithsonian Astrophysical Observation", "SAO 163543"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.24487602),
        dec: Angle.Degrees(-17.84732317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172996"},
        {"Hipparcos Number", "HIP 92033"},
        {"Smithsonian Astrophysical Observation", "SAO 229246"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.39125668),
        dec: Angle.Degrees(-48.45945275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85831",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85831"},
    },
    visualMagnitude: 11.15,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.07392494),
        dec: Angle.Degrees(-48.45944352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -193.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41824"},
        {"Hipparcos Number", "HIP 28796"},
        {"Geneva Identification System", "GEN# +1.00041824"},
        {"Smithsonian Astrophysical Observation", "SAO 217708"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.712,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.19488806),
        dec: Angle.Degrees(-48.45824742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95777"},
        {"Hipparcos Number", "HIP 53989"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.66422105),
        dec: Angle.Degrees(-48.45741723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 102.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203257"},
        {"Hipparcos Number", "HIP 105560"},
        {"Smithsonian Astrophysical Observation", "SAO 230656"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.68868359),
        dec: Angle.Degrees(-48.45702516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -156.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137312"},
        {"Hipparcos Number", "HIP 75620"},
        {"Smithsonian Astrophysical Observation", "SAO 225790"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.76736095),
        dec: Angle.Degrees(-48.45562569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33858"},
        {"Hipparcos Number", "HIP 24111"},
        {"Renson", "Renson 8620"},
        {"Smithsonian Astrophysical Observation", "SAO 217221"},
    },
    visualMagnitude: 7.73,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.68045615),
        dec: Angle.Degrees(-48.45547236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151400"},
        {"Hipparcos Number", "HIP 82338"},
        {"Smithsonian Astrophysical Observation", "SAO 227259"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.36369688),
        dec: Angle.Degrees(-48.45235355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74130"},
        {"Hipparcos Number", "HIP 42526"},
        {"Geneva Identification System", "GEN# +1.00074130"},
        {"Smithsonian Astrophysical Observation", "SAO 220258"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.05212764),
        dec: Angle.Degrees(-48.44616166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87540"},
        {"Hipparcos Number", "HIP 49338"},
        {"Fundamental Katalog 5th Edition", "FK5 2810"},
        {"Geneva Identification System", "GEN# +1.00087540"},
        {"Smithsonian Astrophysical Observation", "SAO 221749"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.08641997),
        dec: Angle.Degrees(-48.44582727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29279"},
        {"Hipparcos Number", "HIP 21302"},
        {"Smithsonian Astrophysical Observation", "SAO 216877"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.56909351),
        dec: Angle.Degrees(-48.44277692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172417"},
        {"Hipparcos Number", "HIP 91742"},
        {"Geneva Identification System", "GEN# +1.00172417"},
        {"Smithsonian Astrophysical Observation", "SAO 229211"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.784,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.62342631),
        dec: Angle.Degrees(-48.44242950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78582"},
        {"Hipparcos Number", "HIP 44759"},
        {"Smithsonian Astrophysical Observation", "SAO 220871"},
    },
    visualMagnitude: 9.16,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.83374969),
        dec: Angle.Degrees(-48.44098554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110577"},
        {"Hipparcos Number", "HIP 62088"},
        {"Smithsonian Astrophysical Observation", "SAO 223624"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.87778905),
        dec: Angle.Degrees(-48.44031451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144228"},
        {"Hipparcos Number", "HIP 78938"},
        {"Smithsonian Astrophysical Observation", "SAO 226507"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.71614533),
        dec: Angle.Degrees(-48.44026157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90918"},
        {"Hipparcos Number", "HIP 51314"},
        {"Smithsonian Astrophysical Observation", "SAO 222087"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.22075914),
        dec: Angle.Degrees(-48.44016103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212539"},
        {"Hipparcos Number", "HIP 110736"},
        {"Geneva Identification System", "GEN# +1.00212539"},
        {"Wilson Evans Batten Catalogue", "WEB 19840"},
    },
    visualMagnitude: 11.06,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.52272377),
        dec: Angle.Degrees(-48.43852672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114315"},
        {"Hipparcos Number", "HIP 64291"},
        {"Smithsonian Astrophysical Observation", "SAO 223953"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.64366072),
        dec: Angle.Degrees(-48.43835331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152965"},
        {"Hipparcos Number", "HIP 83110"},
        {"Smithsonian Astrophysical Observation", "SAO 227515"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.74365130),
        dec: Angle.Degrees(-48.43812641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194701"},
        {"Hipparcos Number", "HIP 101053"},
        {"Smithsonian Astrophysical Observation", "SAO 230233"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.27488668),
        dec: Angle.Degrees(-48.43681610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101202"},
        {"Hipparcos Number", "HIP 56781"},
        {"Geneva Identification System", "GEN# +1.00101202"},
        {"Smithsonian Astrophysical Observation", "SAO 222927"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.61760060),
        dec: Angle.Degrees(-48.43600258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183180"},
        {"Hipparcos Number", "HIP 95925"},
        {"Smithsonian Astrophysical Observation", "SAO 229720"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.63154542),
        dec: Angle.Degrees(-48.43594559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41091"},
        {"Hipparcos Number", "HIP 28441"},
        {"Smithsonian Astrophysical Observation", "SAO 217666"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.08039706),
        dec: Angle.Degrees(-48.43522262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206344"},
        {"Hipparcos Number", "HIP 107208"},
        {"Smithsonian Astrophysical Observation", "SAO 230802"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.71146694),
        dec: Angle.Degrees(-48.43286548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 956"},
        {"Hipparcos Number", "HIP 1106"},
        {"Smithsonian Astrophysical Observation", "SAO 215010"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.44398208),
        dec: Angle.Degrees(-48.43272110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71587"},
        {"Hipparcos Number", "HIP 41346"},
        {"Geneva Identification System", "GEN# +1.00071587"},
        {"Smithsonian Astrophysical Observation", "SAO 219917"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.53292603),
        dec: Angle.Degrees(-48.43206222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31862"},
        {"Hipparcos Number", "HIP 22986"},
        {"Geneva Identification System", "GEN# +1.00031862"},
        {"Smithsonian Astrophysical Observation", "SAO 217075"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.18924685),
        dec: Angle.Degrees(-48.43045751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 79.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112706",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112706"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.36474436),
        dec: Angle.Degrees(-48.42957066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16373"},
        {"Hipparcos Number", "HIP 12104"},
        {"Smithsonian Astrophysical Observation", "SAO 215960"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.99219265),
        dec: Angle.Degrees(-48.42296086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144316"},
        {"Hipparcos Number", "HIP 78991"},
        {"Renson", "Renson 40880"},
        {"Smithsonian Astrophysical Observation", "SAO 226514"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.85457829),
        dec: Angle.Degrees(-48.42239942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154900"},
        {"Hipparcos Number", "HIP 84029"},
    },
    visualMagnitude: 9.98,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.66366086),
        dec: Angle.Degrees(-48.42210486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22496"},
        {"Hipparcos Number", "HIP 16711"},
        {"Cincinnati Publication", "Ci 20 244"},
        {"Geneva Identification System", "GEN# +1.00022496"},
        {"Smithsonian Astrophysical Observation", "SAO 216392"},
        {"Wilson Evans Batten Catalogue", "WEB 3183"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.75243400),
        dec: Angle.Degrees(-48.41988884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 404.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 307.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220014"},
        {"Hipparcos Number", "HIP 115275"},
        {"Geneva Identification System", "GEN# +1.00220014"},
        {"Smithsonian Astrophysical Observation", "SAO 231559"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.849,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.21700236),
        dec: Angle.Degrees(-48.41960683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -196.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89371"},
        {"Hipparcos Number", "HIP 50415"},
        {"Smithsonian Astrophysical Observation", "SAO 221937"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.40887686),
        dec: Angle.Degrees(-48.41794705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12103",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 11.18,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)35, 56.9500),
        dec: Angle.DegreesMinutesSeconds((int)-48, (int)25, 01.000)
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
    primaryId: "HIP 10368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13851"},
        {"Hipparcos Number", "HIP 10368"},
        {"Smithsonian Astrophysical Observation", "SAO 215823"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.40156795),
        dec: Angle.Degrees(-48.41690206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106589"},
        {"Hipparcos Number", "HIP 59793"},
        {"Geneva Identification System", "GEN# +1.00106589"},
        {"Smithsonian Astrophysical Observation", "SAO 223311"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.90388877),
        dec: Angle.Degrees(-48.41645798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -303.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 106.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72837"},
        {"Hipparcos Number", "HIP 41942"},
        {"Geneva Identification System", "GEN# +1.00072837"},
        {"Smithsonian Astrophysical Observation", "SAO 220092"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.25872076),
        dec: Angle.Degrees(-48.41563093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196986"},
        {"Hipparcos Number", "HIP 102210"},
        {"Smithsonian Astrophysical Observation", "SAO 230332"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.65250649),
        dec: Angle.Degrees(-48.41511428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86523"},
        {"Hipparcos Number", "HIP 48835"},
        {"Geneva Identification System", "GEN# +1.00086523J"},
        {"Smithsonian Astrophysical Observation", "SAO 221644"},
        {"Wilson Evans Batten Catalogue", "WEB 9076"},
    },
    visualMagnitude: 6.06,
    bvColour: -0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.42752387),
        dec: Angle.Degrees(-48.41407030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43675"},
        {"Hipparcos Number", "HIP 29647"},
        {"Smithsonian Astrophysical Observation", "SAO 217805"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.70585122),
        dec: Angle.Degrees(-48.40974416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83996"},
        {"Hipparcos Number", "HIP 47471"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.15078129),
        dec: Angle.Degrees(-48.40902951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44444"},
        {"Hipparcos Number", "HIP 30044"},
        {"Geneva Identification System", "GEN# +1.00044444"},
        {"Smithsonian Astrophysical Observation", "SAO 217848"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.82724015),
        dec: Angle.Degrees(-48.40897238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68809"},
        {"Hipparcos Number", "HIP 40137"},
        {"Smithsonian Astrophysical Observation", "SAO 219581"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.95745844),
        dec: Angle.Degrees(-48.40816297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68655",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68655"},
    },
    visualMagnitude: 10.33,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.80152147),
        dec: Angle.Degrees(-48.40779279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43650",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43650"},
    },
    visualMagnitude: 12.28,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.37192312),
        dec: Angle.Degrees(-48.40555243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194532"},
        {"Hipparcos Number", "HIP 100956"},
        {"Smithsonian Astrophysical Observation", "SAO 230224"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.801,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.03568651),
        dec: Angle.Degrees(-48.40397775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176862"},
        {"Hipparcos Number", "HIP 93682"},
        {"Geneva Identification System", "GEN# +1.00176862"},
        {"Smithsonian Astrophysical Observation", "SAO 229472"},
    },
    visualMagnitude: 6.66,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.16636701),
        dec: Angle.Degrees(-48.40383668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104342"},
        {"Hipparcos Number", "HIP 58582"},
        {"Smithsonian Astrophysical Observation", "SAO 223168"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.20495178),
        dec: Angle.Degrees(-48.40335478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -138.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96910"},
        {"Hipparcos Number", "HIP 54497"},
        {"Geneva Identification System", "GEN# +1.00096910"},
        {"Renson", "Renson 27960"},
        {"Smithsonian Astrophysical Observation", "SAO 222597"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.24214768),
        dec: Angle.Degrees(-48.40287771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32373"},
        {"Hipparcos Number", "HIP 23260"},
        {"Smithsonian Astrophysical Observation", "SAO 217109"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.07596386),
        dec: Angle.Degrees(-48.40217942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43652",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43652"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.37608731),
        dec: Angle.Degrees(-48.40079003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221098"},
        {"Hipparcos Number", "HIP 115940"},
        {"Geneva Identification System", "GEN# +1.00221098"},
        {"Renson", "Renson 60620"},
        {"Smithsonian Astrophysical Observation", "SAO 231625"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.35709287),
        dec: Angle.Degrees(-48.40004433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161415"},
        {"Hipparcos Number", "HIP 87106"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.781,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.96868167),
        dec: Angle.Degrees(-48.39782110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38955"},
        {"Hipparcos Number", "HIP 27275"},
        {"Smithsonian Astrophysical Observation", "SAO 217528"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.70488743),
        dec: Angle.Degrees(-48.39641448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128471"},
        {"Hipparcos Number", "HIP 71594"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.63776880),
        dec: Angle.Degrees(-48.39638386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98556"},
        {"Hipparcos Number", "HIP 55330"},
        {"Smithsonian Astrophysical Observation", "SAO 222721"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.95894789),
        dec: Angle.Degrees(-48.39633874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27476"},
        {"Hipparcos Number", "HIP 20050"},
        {"Geneva Identification System", "GEN# +1.00027476"},
        {"Smithsonian Astrophysical Observation", "SAO 216738"},
    },
    visualMagnitude: 8.74,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.49653667),
        dec: Angle.Degrees(-48.39590994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215495"},
        {"Hipparcos Number", "HIP 112423"},
        {"Smithsonian Astrophysical Observation", "SAO 231286"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.57878010),
        dec: Angle.Degrees(-48.39002473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16105"},
        {"Hipparcos Number", "HIP 11908"},
        {"Smithsonian Astrophysical Observation", "SAO 215942"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.42177120),
        dec: Angle.Degrees(-48.38979690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113331"},
        {"Hipparcos Number", "HIP 63728"},
        {"Smithsonian Astrophysical Observation", "SAO 223872"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.89737285),
        dec: Angle.Degrees(-48.38749946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67762"},
        {"Hipparcos Number", "HIP 39738"},
        {"Geneva Identification System", "GEN# +1.00067762"},
        {"Smithsonian Astrophysical Observation", "SAO 219444"},
        {"Wilson Evans Batten Catalogue", "WEB 7754"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.83106328),
        dec: Angle.Degrees(-48.38661486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -141.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 202.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147457"},
        {"Hipparcos Number", "HIP 80376"},
        {"Smithsonian Astrophysical Observation", "SAO 226718"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.10553673),
        dec: Angle.Degrees(-48.38399903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126524"},
        {"Hipparcos Number", "HIP 70691"},
        {"Smithsonian Astrophysical Observation", "SAO 224932"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.87937619),
        dec: Angle.Degrees(-48.38367065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105500"},
        {"Hipparcos Number", "HIP 59222"},
        {"Smithsonian Astrophysical Observation", "SAO 223239"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.19359114),
        dec: Angle.Degrees(-48.38213371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173947"},
        {"Hipparcos Number", "HIP 92459"},
        {"Smithsonian Astrophysical Observation", "SAO 229309"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.63596213),
        dec: Angle.Degrees(-48.37923002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68125",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68125"},
    },
    visualMagnitude: 10.95,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.20114797),
        dec: Angle.Degrees(-48.37734652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65930"},
        {"Hipparcos Number", "HIP 39013"},
        {"Celescope Catalog", "CEL 2125"},
        {"Geneva Identification System", "GEN# +1.00065930J"},
        {"Smithsonian Astrophysical Observation", "SAO 219244"},
        {"Wilson Evans Batten Catalogue", "WEB 7649"},
    },
    visualMagnitude: 6.84,
    bvColour: -0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.75306445),
        dec: Angle.Degrees(-48.37632145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121484"},
        {"Hipparcos Number", "HIP 68117"},
        {"Smithsonian Astrophysical Observation", "SAO 224557"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.18895571),
        dec: Angle.Degrees(-48.37587121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28768"},
        {"Hipparcos Number", "HIP 20961"},
        {"Smithsonian Astrophysical Observation", "SAO 216834"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.42030407),
        dec: Angle.Degrees(-48.37237918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98555"},
        {"Hipparcos Number", "HIP 55333"},
        {"Smithsonian Astrophysical Observation", "SAO 222722"},
    },
    visualMagnitude: 8.64,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.96682402),
        dec: Angle.Degrees(-48.37219761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25771"},
        {"Hipparcos Number", "HIP 18894"},
        {"Fundamental Katalog 5th Edition", "FK5 4364"},
        {"Smithsonian Astrophysical Observation", "SAO 216618"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.74920939),
        dec: Angle.Degrees(-48.36882014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210235"},
        {"Hipparcos Number", "HIP 109419"},
        {"Smithsonian Astrophysical Observation", "SAO 231008"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.53071562),
        dec: Angle.Degrees(-48.36696091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11081"},
        {"Hipparcos Number", "HIP 8364"},
        {"Smithsonian Astrophysical Observation", "SAO 215658"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.94363206),
        dec: Angle.Degrees(-48.36451319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50965"},
        {"Hipparcos Number", "HIP 33028"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.22724206),
        dec: Angle.Degrees(-48.36165732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 119.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174474"},
        {"Hipparcos Number", "HIP 92676"},
        {"Geneva Identification System", "GEN# +1.00174474"},
        {"Smithsonian Astrophysical Observation", "SAO 229342"},
        {"Wilson Evans Batten Catalogue", "WEB 16029"},
    },
    visualMagnitude: 6.17,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.25984231),
        dec: Angle.Degrees(-48.36072714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168651"},
        {"Hipparcos Number", "HIP 90105"},
        {"Geneva Identification System", "GEN# +1.00168651"},
        {"Smithsonian Astrophysical Observation", "SAO 228963"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.82041202),
        dec: Angle.Degrees(-48.36068032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76161"},
        {"Hipparcos Number", "HIP 43589"},
        {"Celescope Catalog", "CEL 3025"},
        {"Geneva Identification System", "GEN# +1.00076161"},
        {"Smithsonian Astrophysical Observation", "SAO 220609"},
        {"Wilson Evans Batten Catalogue", "WEB 8401"},
    },
    visualMagnitude: 5.92,
    bvColour: -0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.16090445),
        dec: Angle.Degrees(-48.35909798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170336"},
        {"Hipparcos Number", "HIP 90787"},
        {"Smithsonian Astrophysical Observation", "SAO 229081"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.82648595),
        dec: Angle.Degrees(-48.35771103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94674",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94674"},
    },
    visualMagnitude: 10.46,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.97420030),
        dec: Angle.Degrees(-48.35742608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63255"},
        {"Hipparcos Number", "HIP 37865"},
        {"Smithsonian Astrophysical Observation", "SAO 218966"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.42921091),
        dec: Angle.Degrees(-48.35492776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89394"},
        {"Hipparcos Number", "HIP 50436"},
        {"Smithsonian Astrophysical Observation", "SAO 221940"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.46910096),
        dec: Angle.Degrees(-48.35347851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76663",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76663"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.82405821),
        dec: Angle.Degrees(-48.35268347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15891"},
        {"Hipparcos Number", "HIP 11756"},
        {"Smithsonian Astrophysical Observation", "SAO 215934"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.91704034),
        dec: Angle.Degrees(-48.35227935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93751"},
        {"Hipparcos Number", "HIP 52858"},
        {"Geneva Identification System", "GEN# +1.00093751"},
        {"Smithsonian Astrophysical Observation", "SAO 222343"},
        {"Wilson Evans Batten Catalogue", "WEB 9622"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.14648963),
        dec: Angle.Degrees(-48.35060835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -152.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90796",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90796"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.84242694),
        dec: Angle.Degrees(-48.34942659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1900"},
        {"Hipparcos Number", "HIP 1824"},
        {"Smithsonian Astrophysical Observation", "SAO 215076"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.77222908),
        dec: Angle.Degrees(-48.34892650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80381"},
        {"Hipparcos Number", "HIP 45604"},
        {"Smithsonian Astrophysical Observation", "SAO 221036"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.43522974),
        dec: Angle.Degrees(-48.34720201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26392"},
        {"Hipparcos Number", "HIP 19294"},
        {"Geneva Identification System", "GEN# +1.00026392"},
        {"Smithsonian Astrophysical Observation", "SAO 216664"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.04820948),
        dec: Angle.Degrees(-48.34568175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191851"},
        {"Hipparcos Number", "HIP 99721"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.52547762),
        dec: Angle.Degrees(-48.34462701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75676"},
        {"Hipparcos Number", "HIP 43318"},
        {"Geneva Identification System", "GEN# +1.00075676"},
        {"Smithsonian Astrophysical Observation", "SAO 220535"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.37376977),
        dec: Angle.Degrees(-48.34227435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162551"},
        {"Hipparcos Number", "HIP 87635"},
        {"Smithsonian Astrophysical Observation", "SAO 228523"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.51755036),
        dec: Angle.Degrees(-48.34186578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104069"},
        {"Hipparcos Number", "HIP 58446"},
        {"Smithsonian Astrophysical Observation", "SAO 223150"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.76422986),
        dec: Angle.Degrees(-48.34145873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188556"},
        {"Hipparcos Number", "HIP 98260"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.49469438),
        dec: Angle.Degrees(-48.34105905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153678"},
        {"Hipparcos Number", "HIP 83438"},
        {"Smithsonian Astrophysical Observation", "SAO 227579"},
    },
    visualMagnitude: 6.75,
    bvColour: 1.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.80499256),
        dec: Angle.Degrees(-48.33685494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90133"},
        {"Hipparcos Number", "HIP 50866"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.79908574),
        dec: Angle.Degrees(-48.33480254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19990"},
        {"Hipparcos Number", "HIP 14785"},
        {"Smithsonian Astrophysical Observation", "SAO 216202"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.71993284),
        dec: Angle.Degrees(-48.33444781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 120132",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 120132"},
        {"Geneva Identification System", "GEN# +6.20145006"},
    },
    visualMagnitude: 12.26,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.04146403),
        dec: Angle.Degrees(-48.33386742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94893"},
        {"Hipparcos Number", "HIP 53484"},
        {"Geneva Identification System", "GEN# +1.00094893"},
        {"Smithsonian Astrophysical Observation", "SAO 222439"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.12302167),
        dec: Angle.Degrees(-48.33200606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109286",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109286"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.09758691),
        dec: Angle.Degrees(-48.33021807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191682"},
        {"Hipparcos Number", "HIP 99637"},
        {"Smithsonian Astrophysical Observation", "SAO 230104"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.32225475),
        dec: Angle.Degrees(-48.33014563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58112"},
        {"Hipparcos Number", "HIP 35683"},
        {"Geneva Identification System", "GEN# +1.00058112"},
        {"Smithsonian Astrophysical Observation", "SAO 218672"},
    },
    visualMagnitude: 8.43,
    bvColour: -0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.44762565),
        dec: Angle.Degrees(-48.32896108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30292"},
        {"Hipparcos Number", "HIP 22006"},
        {"Geneva Identification System", "GEN# +1.00030292"},
        {"Smithsonian Astrophysical Observation", "SAO 216967"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.95658458),
        dec: Angle.Degrees(-48.32764221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 276.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205592"},
        {"Hipparcos Number", "HIP 106793"},
        {"Smithsonian Astrophysical Observation", "SAO 230763"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.45749896),
        dec: Angle.Degrees(-48.32649882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66765"},
        {"Hipparcos Number", "HIP 39371"},
        {"Celescope Catalog", "CEL 2152"},
        {"Geneva Identification System", "GEN# +1.00066765"},
        {"Smithsonian Astrophysical Observation", "SAO 219347"},
        {"Wilson Evans Batten Catalogue", "WEB 7708"},
    },
    visualMagnitude: 6.64,
    bvColour: -0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.73216753),
        dec: Angle.Degrees(-48.32501421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29486",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29486"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.18525843),
        dec: Angle.Degrees(-48.32466753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145702"},
        {"Hipparcos Number", "HIP 79602"},
        {"Smithsonian Astrophysical Observation", "SAO 226592"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.64583730),
        dec: Angle.Degrees(-48.32437360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125721"},
        {"Hipparcos Number", "HIP 70270"},
        {"Geneva Identification System", "GEN# +1.00125721J"},
        {"Smithsonian Astrophysical Observation", "SAO 224870"},
        {"Wilson Evans Batten Catalogue", "WEB 12200"},
    },
    visualMagnitude: 6.10,
    bvColour: -0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.66133262),
        dec: Angle.Degrees(-48.31984596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108419",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108419"},
    },
    visualMagnitude: 11.70,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.45970593),
        dec: Angle.Degrees(-17.78490080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -329.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151082"},
        {"Hipparcos Number", "HIP 82189"},
        {"Geneva Identification System", "GEN# +1.00151082"},
        {"Smithsonian Astrophysical Observation", "SAO 227205"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.86718653),
        dec: Angle.Degrees(-48.31943974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3340"},
        {"Hipparcos Number", "HIP 2835"},
        {"Smithsonian Astrophysical Observation", "SAO 215160"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.98865370),
        dec: Angle.Degrees(-48.31938437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201318"},
        {"Hipparcos Number", "HIP 104529"},
        {"Geneva Identification System", "GEN# +1.00201318"},
        {"Smithsonian Astrophysical Observation", "SAO 230556"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.61833736),
        dec: Angle.Degrees(-48.31871876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118932"},
        {"Hipparcos Number", "HIP 66777"},
        {"Smithsonian Astrophysical Observation", "SAO 224331"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.29964635),
        dec: Angle.Degrees(-48.31839891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76659",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76659"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.81761069),
        dec: Angle.Degrees(-48.31808741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136352"},
        {"Hipparcos Number", "HIP 75181"},
        {"Cincinnati Publication", "Ci 20 926"},
        {"Geneva Identification System", "GEN# +1.00136352"},
        {"Smithsonian Astrophysical Observation", "SAO 225697"},
        {"Wilson Evans Batten Catalogue", "WEB 12827"},
    },
    visualMagnitude: 5.65,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.45655596),
        dec: Angle.Degrees(-48.31695913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1622.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -275.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107233"},
        {"Hipparcos Number", "HIP 60134"},
        {"Geneva Identification System", "GEN# +1.00107233"},
        {"Smithsonian Astrophysical Observation", "SAO 223356"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.98166741),
        dec: Angle.Degrees(-48.31647639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99367"},
        {"Hipparcos Number", "HIP 55768"},
        {"Smithsonian Astrophysical Observation", "SAO 222787"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.41104369),
        dec: Angle.Degrees(-48.31644554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213230"},
        {"Hipparcos Number", "HIP 111142"},
        {"Smithsonian Astrophysical Observation", "SAO 231172"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.74514492),
        dec: Angle.Degrees(-48.31570825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215560"},
        {"Hipparcos Number", "HIP 112458"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.70172563),
        dec: Angle.Degrees(-48.31491689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 329893"},
        {"Hipparcos Number", "HIP 77136"},
    },
    visualMagnitude: 9.57,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.24102755),
        dec: Angle.Degrees(-48.31432676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193870"},
        {"Hipparcos Number", "HIP 100653"},
        {"Smithsonian Astrophysical Observation", "SAO 230189"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.13752023),
        dec: Angle.Degrees(-48.31424576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41494"},
        {"Hipparcos Number", "HIP 28650"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.74966924),
        dec: Angle.Degrees(-48.31354027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14792"},
        {"Hipparcos Number", "HIP 10983"},
        {"Smithsonian Astrophysical Observation", "SAO 215872"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.39062374),
        dec: Angle.Degrees(-48.31221324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160754"},
        {"Hipparcos Number", "HIP 86790"},
        {"Geneva Identification System", "GEN# +1.00160754"},
        {"Smithsonian Astrophysical Observation", "SAO 228345"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.01703122),
        dec: Angle.Degrees(-48.31209917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138128"},
        {"Hipparcos Number", "HIP 76053"},
        {"Smithsonian Astrophysical Observation", "SAO 225870"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.97907271),
        dec: Angle.Degrees(-48.31171146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30999"},
        {"Hipparcos Number", "HIP 22444"},
        {"Geneva Identification System", "GEN# +1.00030999"},
        {"Smithsonian Astrophysical Observation", "SAO 217027"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.44706181),
        dec: Angle.Degrees(-48.31137362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112347"},
        {"Hipparcos Number", "HIP 63176"},
        {"Smithsonian Astrophysical Observation", "SAO 223772"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.15018068),
        dec: Angle.Degrees(-48.30993013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108068"},
        {"Hipparcos Number", "HIP 60592"},
        {"Smithsonian Astrophysical Observation", "SAO 223425"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.28695782),
        dec: Angle.Degrees(-48.30911332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206584"},
        {"Hipparcos Number", "HIP 107338"},
        {"Geneva Identification System", "GEN# +1.00206584"},
        {"Smithsonian Astrophysical Observation", "SAO 230816"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.10112067),
        dec: Angle.Degrees(-48.30781863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88223"},
        {"Hipparcos Number", "HIP 49720"},
        {"Geneva Identification System", "GEN# +1.00088223"},
        {"Smithsonian Astrophysical Observation", "SAO 221809"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.27393767),
        dec: Angle.Degrees(-48.30659921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214066"},
        {"Hipparcos Number", "HIP 111610"},
        {"Smithsonian Astrophysical Observation", "SAO 231213"},
    },
    visualMagnitude: 6.65,
    bvColour: 1.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.16233278),
        dec: Angle.Degrees(-48.30604716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30259"},
        {"Hipparcos Number", "HIP 21992"},
        {"Geneva Identification System", "GEN# +1.00030259"},
        {"Smithsonian Astrophysical Observation", "SAO 216963"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.90235401),
        dec: Angle.Degrees(-48.30443233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56265"},
        {"Hipparcos Number", "HIP 34958"},
        {"Geneva Identification System", "GEN# +1.00056265"},
        {"Smithsonian Astrophysical Observation", "SAO 218557"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.49517883),
        dec: Angle.Degrees(-48.30226747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4392"},
        {"Hipparcos Number", "HIP 3578"},
        {"Geneva Identification System", "GEN# +1.00004392"},
        {"Smithsonian Astrophysical Observation", "SAO 215230"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.42468671),
        dec: Angle.Degrees(-48.30116131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177406"},
        {"Hipparcos Number", "HIP 93862"},
        {"Fundamental Katalog 5th Edition", "FK5 3523"},
        {"Geneva Identification System", "GEN# +1.00177406"},
        {"Smithsonian Astrophysical Observation", "SAO 229493"},
    },
    visualMagnitude: 5.95,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.73164713),
        dec: Angle.Degrees(-48.29911462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120593"},
        {"Hipparcos Number", "HIP 67645"},
        {"Geneva Identification System", "GEN# +1.00120593"},
        {"Smithsonian Astrophysical Observation", "SAO 224486"},
        {"Wilson Evans Batten Catalogue", "WEB 11896"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.89486121),
        dec: Angle.Degrees(-48.29868119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -114.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210588"},
        {"Hipparcos Number", "HIP 109625"},
        {"Smithsonian Astrophysical Observation", "SAO 231026"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.10834320),
        dec: Angle.Degrees(-48.29562634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8093"},
        {"Hipparcos Number", "HIP 6200"},
        {"Smithsonian Astrophysical Observation", "SAO 215459"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.87930753),
        dec: Angle.Degrees(-48.29467461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29654"},
        {"Hipparcos Number", "HIP 21562"},
        {"Smithsonian Astrophysical Observation", "SAO 216906"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.43532909),
        dec: Angle.Degrees(-48.29429096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120592"},
        {"Hipparcos Number", "HIP 67639"},
        {"Geneva Identification System", "GEN# +1.00120592"},
        {"Smithsonian Astrophysical Observation", "SAO 224485"},
        {"Wilson Evans Batten Catalogue", "WEB 11893"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.88520040),
        dec: Angle.Degrees(-48.29316498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50621"},
        {"Hipparcos Number", "HIP 32918"},
        {"Geneva Identification System", "GEN# +1.00050621"},
        {"Smithsonian Astrophysical Observation", "SAO 218261"},
    },
    visualMagnitude: 6.42,
    bvColour: 1.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.88568011),
        dec: Angle.Degrees(-48.29272906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90066",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90066"},
    },
    visualMagnitude: 9.67,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.69849076),
        dec: Angle.Degrees(-48.29179748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
