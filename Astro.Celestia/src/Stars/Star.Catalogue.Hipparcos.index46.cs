using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_46() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143714"},
        {"Hipparcos Number", "HIP 78573"},
        {"Fundamental Katalog 5th Edition", "FK5 5416"},
        {"Smithsonian Astrophysical Observation", "SAO 159648"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.66036208),
        dec: Angle.Degrees(-18.17171590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140779"},
        {"Hipparcos Number", "HIP 77225"},
        {"Smithsonian Astrophysical Observation", "SAO 159483"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.51533865),
        dec: Angle.Degrees(-18.17128823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38738"},
        {"Hipparcos Number", "HIP 27307"},
        {"Smithsonian Astrophysical Observation", "SAO 150809"},
    },
    visualMagnitude: 8.09,
    bvColour: -0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.78213726),
        dec: Angle.Degrees(-18.16896796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139220"},
        {"Hipparcos Number", "HIP 76505"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.37445515),
        dec: Angle.Degrees(-18.16871023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23932",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23932"},
        {"Geneva Identification System", "GEN# +6.10010190"},
        {"Geneva Identification System 2", "GEN# +9.85777036"},
    },
    visualMagnitude: 10.28,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.14473389),
        dec: Angle.Degrees(-18.16864510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 503.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1400.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14165",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14165"},
    },
    visualMagnitude: 11.77,
    bvColour: 1.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.65752681),
        dec: Angle.Degrees(-18.16672240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 401.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 163.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44569"},
        {"Hipparcos Number", "HIP 30232"},
        {"Geneva Identification System", "GEN# +1.00044569"},
        {"Smithsonian Astrophysical Observation", "SAO 151410"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.40574030),
        dec: Angle.Degrees(-18.16644584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219604"},
        {"Hipparcos Number", "HIP 114970"},
        {"Smithsonian Astrophysical Observation", "SAO 165605"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.28775000),
        dec: Angle.Degrees(-18.16574637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97517"},
        {"Hipparcos Number", "HIP 54804"},
        {"Geneva Identification System", "GEN# +1.00097517"},
        {"Smithsonian Astrophysical Observation", "SAO 156539"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.29477689),
        dec: Angle.Degrees(-18.16481891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -341.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -194.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14975"},
        {"Hipparcos Number", "HIP 11219"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.859,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.09898244),
        dec: Angle.Degrees(-18.16241219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211464"},
        {"Hipparcos Number", "HIP 110063"},
        {"Fundamental Katalog 5th Edition", "FK5 5967"},
        {"Geneva Identification System", "GEN# +1.00211464"},
        {"Smithsonian Astrophysical Observation", "SAO 164985"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.38616958),
        dec: Angle.Degrees(-18.16189891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11019"},
        {"Hipparcos Number", "HIP 8373"},
        {"Smithsonian Astrophysical Observation", "SAO 148015"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.95922070),
        dec: Angle.Degrees(-18.16048228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172853"},
        {"Hipparcos Number", "HIP 91806"},
        {"Smithsonian Astrophysical Observation", "SAO 161759"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.79000646),
        dec: Angle.Degrees(-18.15970208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136366"},
        {"Hipparcos Number", "HIP 75110"},
        {"Geneva Identification System", "GEN# +1.00136366"},
        {"Smithsonian Astrophysical Observation", "SAO 159187"},
        {"Wilson Evans Batten Catalogue", "WEB 12810"},
    },
    visualMagnitude: 6.16,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.22367434),
        dec: Angle.Degrees(-18.15851255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193454"},
        {"Hipparcos Number", "HIP 100334"},
        {"Geneva Identification System", "GEN# +1.00193454"},
        {"Smithsonian Astrophysical Observation", "SAO 163472"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.22301320),
        dec: Angle.Degrees(-18.15610980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99652"},
        {"Hipparcos Number", "HIP 55934"},
        {"Smithsonian Astrophysical Observation", "SAO 156692"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.94761180),
        dec: Angle.Degrees(-18.15381390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7717"},
        {"Hipparcos Number", "HIP 5968"},
        {"Smithsonian Astrophysical Observation", "SAO 147706"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.18059504),
        dec: Angle.Degrees(-18.15365764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186665"},
        {"Hipparcos Number", "HIP 97296"},
        {"Geneva Identification System", "GEN# +1.00186665"},
        {"Smithsonian Astrophysical Observation", "SAO 162965"},
        {"Wilson Evans Batten Catalogue", "WEB 17092"},
    },
    visualMagnitude: 9.13,
    bvColour: 2.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.60862612),
        dec: Angle.Degrees(-18.15177482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167067"},
        {"Hipparcos Number", "HIP 89384"},
        {"Geneva Identification System", "GEN# +1.00167067"},
        {"Smithsonian Astrophysical Observation", "SAO 161205"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.60619845),
        dec: Angle.Degrees(-18.15092073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204028"},
        {"Hipparcos Number", "HIP 105844"},
        {"Smithsonian Astrophysical Observation", "SAO 164384"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.56904361),
        dec: Angle.Degrees(-18.14938688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191775"},
        {"Hipparcos Number", "HIP 99557"},
        {"Smithsonian Astrophysical Observation", "SAO 163331"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.06249518),
        dec: Angle.Degrees(-18.14572347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211188"},
        {"Hipparcos Number", "HIP 109918"},
        {"Geneva Identification System", "GEN# +1.00211188"},
        {"Smithsonian Astrophysical Observation", "SAO 164960"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.93510178),
        dec: Angle.Degrees(-18.14433255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 161.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -159.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54963",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54963"},
        {"Cincinnati Publication", "Ci 20 621"},
        {"Geneva Identification System", "GEN# -0.01703336A"},
        {"Wilson Evans Batten Catalogue", "WEB 9919"},
    },
    visualMagnitude: 10.02,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.83081702),
        dec: Angle.Degrees(-18.14405623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 294.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -717.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54966",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54966"},
        {"Geneva Identification System", "GEN# -0.01703337"},
        {"Wilson Evans Batten Catalogue", "WEB 9920"},
    },
    visualMagnitude: 9.97,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.83622206),
        dec: Angle.Degrees(-18.14332140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 319.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -708.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141515"},
        {"Hipparcos Number", "HIP 77554"},
        {"Geneva Identification System", "GEN# +1.00141515"},
        {"Smithsonian Astrophysical Observation", "SAO 159520"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.51327591),
        dec: Angle.Degrees(-18.14267136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68780"},
        {"Hipparcos Number", "HIP 40258"},
        {"Smithsonian Astrophysical Observation", "SAO 153994"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.33143086),
        dec: Angle.Degrees(-18.13951318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154148"},
        {"Hipparcos Number", "HIP 83539"},
        {"Geneva Identification System", "GEN# +1.00154148"},
        {"Smithsonian Astrophysical Observation", "SAO 160255"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.11190907),
        dec: Angle.Degrees(-18.13903350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88109"},
        {"Hipparcos Number", "HIP 49742"},
        {"Geneva Identification System", "GEN# +9.00050005"},
        {"Smithsonian Astrophysical Observation", "SAO 155771"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.31486669),
        dec: Angle.Degrees(-18.13890049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196777"},
        {"Hipparcos Number", "HIP 101984"},
        {"Fundamental Katalog 5th Edition", "FK5 773"},
        {"Geneva Identification System", "GEN# +1.00196777"},
        {"Smithsonian Astrophysical Observation", "SAO 163779"},
        {"Wilson Evans Batten Catalogue", "WEB 18434"},
    },
    visualMagnitude: 5.15,
    bvColour: 1.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.01232708),
        dec: Angle.Degrees(-18.13860630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12383"},
        {"Hipparcos Number", "HIP 9422"},
        {"Smithsonian Astrophysical Observation", "SAO 148154"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.26185718),
        dec: Angle.Degrees(-18.13692702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120452"},
        {"Hipparcos Number", "HIP 67494"},
        {"Fundamental Katalog 5th Edition", "FK5 510"},
        {"Geneva Identification System", "GEN# +1.00120452"},
        {"Smithsonian Astrophysical Observation", "SAO 158186"},
        {"Wilson Evans Batten Catalogue", "WEB 11870"},
    },
    visualMagnitude: 4.96,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.46810200),
        dec: Angle.Degrees(-18.13407618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52724"},
        {"Hipparcos Number", "HIP 33850"},
        {"Celescope Catalog", "CEL 1513"},
        {"Geneva Identification System", "GEN# +1.00052724"},
        {"Smithsonian Astrophysical Observation", "SAO 152252"},
    },
    visualMagnitude: 9.41,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.40121272),
        dec: Angle.Degrees(-18.13158912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24786",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3899 A"},
        {"Henry Draper", "HD 34721"},
        {"Hipparcos Number", "HIP 24786"},
        {"Geneva Identification System", "GEN# +1.00034721"},
        {"Smithsonian Astrophysical Observation", "SAO 150326"},
        {"Wilson Evans Batten Catalogue", "WEB 4792"},
    },
    visualMagnitude: 5.96,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.70931620),
        dec: Angle.Degrees(-18.13019946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 385.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82393",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82393"},
        {"Smithsonian Astrophysical Observation", "SAO 160121"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.53452871),
        dec: Angle.Degrees(-18.12955210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42327"},
        {"Hipparcos Number", "HIP 29178"},
        {"Geneva Identification System", "GEN# +1.00042327"},
        {"Smithsonian Astrophysical Observation", "SAO 151173"},
    },
    visualMagnitude: 6.36,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.33414900),
        dec: Angle.Degrees(-18.12633349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10520"},
        {"Hipparcos Number", "HIP 7952"},
        {"Smithsonian Astrophysical Observation", "SAO 147967"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.53265785),
        dec: Angle.Degrees(-18.12632216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58722"},
        {"Hipparcos Number", "HIP 36089"},
        {"Celescope Catalog", "CEL 1848"},
        {"Geneva Identification System", "GEN# +1.00058722"},
        {"Smithsonian Astrophysical Observation", "SAO 152868"},
    },
    visualMagnitude: 7.29,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.53064638),
        dec: Angle.Degrees(-18.12156515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33292"},
        {"Hipparcos Number", "HIP 23927"},
        {"Smithsonian Astrophysical Observation", "SAO 150172"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.13010524),
        dec: Angle.Degrees(-18.11967555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5932"},
        {"Hipparcos Number", "HIP 4721"},
        {"Geneva Identification System", "GEN# +1.00005932"},
        {"Smithsonian Astrophysical Observation", "SAO 147566"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.15984950),
        dec: Angle.Degrees(-18.11905435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154383"},
        {"Hipparcos Number", "HIP 83649"},
        {"Geneva Identification System", "GEN# +1.00154383"},
        {"Smithsonian Astrophysical Observation", "SAO 160270"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.45149443),
        dec: Angle.Degrees(-18.11612049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3057"},
        {"Hipparcos Number", "HIP 2660"},
        {"Smithsonian Astrophysical Observation", "SAO 147337"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.42104729),
        dec: Angle.Degrees(-18.11529818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103976",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14588 AB"},
        {"Henry Draper", "HD 200438"},
        {"Hipparcos Number", "HIP 103976"},
        {"Smithsonian Astrophysical Observation", "SAO 164111"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.00647945),
        dec: Angle.Degrees(-18.11208532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197187"},
        {"Hipparcos Number", "HIP 102217"},
        {"Geneva Identification System", "GEN# +1.00197187"},
        {"Smithsonian Astrophysical Observation", "SAO 163811"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.66571831),
        dec: Angle.Degrees(-18.10968424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2946"},
        {"Hipparcos Number", "HIP 2567"},
        {"Geneva Identification System", "GEN# +1.00002946"},
        {"Smithsonian Astrophysical Observation", "SAO 147327"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.749,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.14620354),
        dec: Angle.Degrees(-18.10916056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86065"},
        {"Hipparcos Number", "HIP 48680"},
        {"Smithsonian Astrophysical Observation", "SAO 155596"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.92797921),
        dec: Angle.Degrees(-18.10766885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -326.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 107.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87061",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10788 AB"},
        {"Henry Draper", "HD 161643"},
        {"Hipparcos Number", "HIP 87061"},
        {"Geneva Identification System", "GEN# +1.00161643J"},
        {"Smithsonian Astrophysical Observation", "SAO 160819"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.86287595),
        dec: Angle.Degrees(-18.10710767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202262"},
        {"Hipparcos Number", "HIP 104915"},
        {"Smithsonian Astrophysical Observation", "SAO 164250"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.78654986),
        dec: Angle.Degrees(-18.10390931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103906"},
        {"Hipparcos Number", "HIP 58341"},
        {"Smithsonian Astrophysical Observation", "SAO 157014"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.46316618),
        dec: Angle.Degrees(-18.10204952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49321",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7627 A"},
        {"Henry Draper", "HD 87344"},
        {"Hipparcos Number", "HIP 49321"},
        {"Geneva Identification System", "GEN# +1.00087344J"},
        {"Smithsonian Astrophysical Observation", "SAO 155704"},
    },
    visualMagnitude: 6.30,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.01178567),
        dec: Angle.Degrees(-18.10141491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184342"},
        {"Hipparcos Number", "HIP 96291"},
        {"Smithsonian Astrophysical Observation", "SAO 162787"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.68101144),
        dec: Angle.Degrees(-18.10120773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49319",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7627 C"},
        {"Henry Draper", "HD 87330"},
        {"Hipparcos Number", "HIP 49319"},
        {"Geneva Identification System", "GEN# +1.00087330"},
        {"Smithsonian Astrophysical Observation", "SAO 155702"},
    },
    visualMagnitude: 7.14,
    bvColour: -0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.00560280),
        dec: Angle.Degrees(-18.10104079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28366"},
        {"Hipparcos Number", "HIP 20828"},
        {"Smithsonian Astrophysical Observation", "SAO 149652"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.94687183),
        dec: Angle.Degrees(-18.10093995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88231",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88231"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.26398786),
        dec: Angle.Degrees(-18.10042775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126216"},
        {"Hipparcos Number", "HIP 70437"},
        {"Smithsonian Astrophysical Observation", "SAO 158544"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.14045060),
        dec: Angle.Degrees(-18.09958648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6894"},
        {"Hipparcos Number", "HIP 5424"},
        {"Geneva Identification System", "GEN# +1.00006894"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.32100863),
        dec: Angle.Degrees(-18.09925537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57185",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8281 AB"},
        {"Henry Draper", "HD 101898"},
        {"Hipparcos Number", "HIP 57185"},
        {"Smithsonian Astrophysical Observation", "SAO 156855"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.89866195),
        dec: Angle.Degrees(-18.09734402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220611"},
        {"Henry Draper 2", "HD 220612"},
        {"Hipparcos Number", "HIP 115614"},
        {"Geneva Identification System", "GEN# +1.00220611"},
        {"Smithsonian Astrophysical Observation", "SAO 165681"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.30035071),
        dec: Angle.Degrees(-18.09558508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67093",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67093"},
        {"Smithsonian Astrophysical Observation", "SAO 158140"},
    },
    visualMagnitude: 10.06,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.27715248),
        dec: Angle.Degrees(-18.09556708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -208.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192232"},
        {"Hipparcos Number", "HIP 99763"},
        {"Fundamental Katalog 5th Edition", "FK5 5782"},
        {"Geneva Identification System", "GEN# +1.00192232"},
        {"Smithsonian Astrophysical Observation", "SAO 163370"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.61609243),
        dec: Angle.Degrees(-18.09398780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162562"},
        {"Hipparcos Number", "HIP 87476"},
        {"Geneva Identification System", "GEN# +1.00162562"},
        {"Smithsonian Astrophysical Observation", "SAO 160879"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.09776923),
        dec: Angle.Degrees(-18.09009995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134812"},
        {"Hipparcos Number", "HIP 74412"},
        {"Geneva Identification System", "GEN# +1.00134812"},
        {"Smithsonian Astrophysical Observation", "SAO 159094"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.10935370),
        dec: Angle.Degrees(-18.08994484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57117"},
        {"Hipparcos Number", "HIP 35451"},
        {"Smithsonian Astrophysical Observation", "SAO 152716"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.78722040),
        dec: Angle.Degrees(-18.08982639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111259"},
        {"Hipparcos Number", "HIP 62460"},
        {"Smithsonian Astrophysical Observation", "SAO 157513"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.00946559),
        dec: Angle.Degrees(-18.08844154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -294.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169652"},
        {"Hipparcos Number", "HIP 90373"},
        {"Geneva Identification System", "GEN# +1.00169652"},
        {"Smithsonian Astrophysical Observation", "SAO 161468"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.61025263),
        dec: Angle.Degrees(-18.08622010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8864",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8864"},
        {"Smithsonian Astrophysical Observation", "SAO 148091"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.50797481),
        dec: Angle.Degrees(-18.08459789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215736"},
        {"Hipparcos Number", "HIP 112534"},
        {"Geneva Identification System", "GEN# +1.00215736"},
        {"Smithsonian Astrophysical Observation", "SAO 165296"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.90125829),
        dec: Angle.Degrees(-18.08194089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195364"},
        {"Hipparcos Number", "HIP 101249"},
        {"Geneva Identification System", "GEN# +1.00195364"},
        {"Smithsonian Astrophysical Observation", "SAO 163652"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.85205143),
        dec: Angle.Degrees(-18.08184093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 78.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68833",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68833"},
        {"Smithsonian Astrophysical Observation", "SAO 158339"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.41215132),
        dec: Angle.Degrees(-18.08081218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58344"},
        {"Hipparcos Number", "HIP 35944"},
        {"Smithsonian Astrophysical Observation", "SAO 152833"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.14572991),
        dec: Angle.Degrees(-18.08008822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46565"},
        {"Hipparcos Number", "HIP 31262"},
        {"Smithsonian Astrophysical Observation", "SAO 151637"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.34711332),
        dec: Angle.Degrees(-18.07664794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219879"},
        {"Hipparcos Number", "HIP 115144"},
        {"Fundamental Katalog 5th Edition", "FK5 3868"},
        {"Geneva Identification System", "GEN# +1.00219879"},
        {"Smithsonian Astrophysical Observation", "SAO 165628"},
        {"Wilson Evans Batten Catalogue", "WEB 20397"},
    },
    visualMagnitude: 5.96,
    bvColour: 1.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.85043968),
        dec: Angle.Degrees(-18.07539972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123037"},
        {"Hipparcos Number", "HIP 68830"},
        {"Geneva Identification System", "GEN# +1.00123037"},
        {"Smithsonian Astrophysical Observation", "SAO 158338"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.41057376),
        dec: Angle.Degrees(-18.07224374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24647"},
        {"Hipparcos Number", "HIP 18269"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.62255485),
        dec: Angle.Degrees(-18.07125538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71332"},
        {"Hipparcos Number", "HIP 41364"},
        {"Fundamental Katalog 5th Edition", "FK5 4758"},
        {"Smithsonian Astrophysical Observation", "SAO 154254"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.57436270),
        dec: Angle.Degrees(-18.07091948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64771"},
        {"Hipparcos Number", "HIP 38660"},
        {"Smithsonian Astrophysical Observation", "SAO 153581"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.73090584),
        dec: Angle.Degrees(-18.06996130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83671"},
        {"Hipparcos Number", "HIP 47420"},
        {"Geneva Identification System", "GEN# +1.00083671"},
        {"Smithsonian Astrophysical Observation", "SAO 155378"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.93679976),
        dec: Angle.Degrees(-18.06806077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65956",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65956"},
        {"Geneva Identification System", "GEN# -0.01703874"},
    },
    visualMagnitude: 9.95,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.84331243),
        dec: Angle.Degrees(-18.06670023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -130.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19674"},
        {"Hipparcos Number", "HIP 14674"},
        {"Fundamental Katalog 5th Edition", "FK5 4289"},
        {"Smithsonian Astrophysical Observation", "SAO 148798"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.39785202),
        dec: Angle.Degrees(-18.06558595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46308"},
        {"Hipparcos Number", "HIP 31131"},
        {"Smithsonian Astrophysical Observation", "SAO 151614"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.98190845),
        dec: Angle.Degrees(-18.06228241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8983"},
        {"Hipparcos Number", "HIP 6857"},
        {"Geneva Identification System", "GEN# +1.00008983"},
        {"Smithsonian Astrophysical Observation", "SAO 147823"},
        {"Wilson Evans Batten Catalogue", "WEB 1494"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.04902264),
        dec: Angle.Degrees(-18.06207328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5863"},
        {"Hipparcos Number", "HIP 4669"},
        {"Geneva Identification System", "GEN# +1.00005863"},
        {"Smithsonian Astrophysical Observation", "SAO 147559"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.99096580),
        dec: Angle.Degrees(-18.06173995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4585"},
        {"Hipparcos Number", "HIP 3717"},
        {"Geneva Identification System", "GEN# +1.00004585"},
        {"Smithsonian Astrophysical Observation", "SAO 147451"},
        {"Wilson Evans Batten Catalogue", "WEB 661"},
    },
    visualMagnitude: 5.70,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.93000731),
        dec: Angle.Degrees(-18.06142264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41017"},
        {"Hipparcos Number", "HIP 28565"},
        {"Geneva Identification System", "GEN# +1.00041017"},
        {"Smithsonian Astrophysical Observation", "SAO 151038"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.43463418),
        dec: Angle.Degrees(-18.06089845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12154"},
        {"Hipparcos Number", "HIP 9262"},
        {"Smithsonian Astrophysical Observation", "SAO 148140"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.76349357),
        dec: Angle.Degrees(-18.06057551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94544",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12191 A"},
        {"Henry Draper", "HD 179767"},
        {"Hipparcos Number", "HIP 94544"},
        {"Geneva Identification System", "GEN# +1.00179767"},
        {"Smithsonian Astrophysical Observation", "SAO 162351"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.63732067),
        dec: Angle.Degrees(-18.05973880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150365"},
        {"Hipparcos Number", "HIP 81695"},
        {"Geneva Identification System", "GEN# +1.00150365"},
        {"Renson", "Renson 42520"},
        {"Smithsonian Astrophysical Observation", "SAO 160044"},
        {"Wilson Evans Batten Catalogue", "WEB 13797"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.32772316),
        dec: Angle.Degrees(-18.05937859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216542"},
        {"Hipparcos Number", "HIP 113067"},
        {"Smithsonian Astrophysical Observation", "SAO 165364"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.49466711),
        dec: Angle.Degrees(-18.05919032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125907"},
        {"Hipparcos Number", "HIP 70288"},
        {"Smithsonian Astrophysical Observation", "SAO 158521"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.70863259),
        dec: Angle.Degrees(-18.05801753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134388"},
        {"Hipparcos Number", "HIP 74232"},
        {"Smithsonian Astrophysical Observation", "SAO 159063"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.54754763),
        dec: Angle.Degrees(-18.05704491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39025"},
        {"Hipparcos Number", "HIP 27476"},
        {"Smithsonian Astrophysical Observation", "SAO 150838"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.27507836),
        dec: Angle.Degrees(-18.05620458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40379"},
        {"Hipparcos Number", "HIP 28201"},
        {"Geneva Identification System", "GEN# +1.00040379"},
        {"Smithsonian Astrophysical Observation", "SAO 150972"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.38873433),
        dec: Angle.Degrees(-18.05519475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194743"},
        {"Hipparcos Number", "HIP 100931"},
        {"Smithsonian Astrophysical Observation", "SAO 163596"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.96356100),
        dec: Angle.Degrees(-18.05495443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26024"},
        {"Hipparcos Number", "HIP 19174"},
        {"Smithsonian Astrophysical Observation", "SAO 149377"},
    },
    visualMagnitude: 6.60,
    bvColour: 1.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.65375922),
        dec: Angle.Degrees(-18.05077235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109999"},
        {"Hipparcos Number", "HIP 61746"},
        {"Smithsonian Astrophysical Observation", "SAO 157420"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.82000435),
        dec: Angle.Degrees(-18.04981104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139763"},
        {"Hipparcos Number", "HIP 76779"},
        {"Smithsonian Astrophysical Observation", "SAO 159427"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.14362954),
        dec: Angle.Degrees(-18.04924579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 160.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 89.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17865",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17865"},
        {"Smithsonian Astrophysical Observation", "SAO 149188"},
    },
    visualMagnitude: 10.22,
    bvColour: 1.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.34812369),
        dec: Angle.Degrees(-18.04813557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50191"},
        {"Hipparcos Number", "HIP 32908"},
        {"Smithsonian Astrophysical Observation", "SAO 152017"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.84739039),
        dec: Angle.Degrees(-18.04670431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15855"},
        {"Hipparcos Number", "HIP 11825"},
        {"Smithsonian Astrophysical Observation", "SAO 148449"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.15077583),
        dec: Angle.Degrees(-18.04364510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75283"},
        {"Hipparcos Number", "HIP 43239"},
        {"Smithsonian Astrophysical Observation", "SAO 154646"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.12462313),
        dec: Angle.Degrees(-18.04302682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100521"},
        {"Hipparcos Number", "HIP 56417"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.761,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.50197363),
        dec: Angle.Degrees(-18.04295883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -186.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17347"},
        {"Hipparcos Number", "HIP 12951"},
        {"Smithsonian Astrophysical Observation", "SAO 148595"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.63997698),
        dec: Angle.Degrees(-18.04101130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156"},
        {"Hipparcos Number", "HIP 529"},
        {"Geneva Identification System", "GEN# +1.00000156"},
        {"Smithsonian Astrophysical Observation", "SAO 147084"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.60400514),
        dec: Angle.Degrees(-18.03825665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62954",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8699 A"},
        {"Henry Draper", "HD 112074"},
        {"Hipparcos Number", "HIP 62954"},
        {"Fundamental Katalog 5th Edition", "FK5 1334"},
        {"Geneva Identification System", "GEN# +1.00112074"},
        {"Renson", "Renson 32510"},
        {"Smithsonian Astrophysical Observation", "SAO 157580"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.50128011),
        dec: Angle.Degrees(-18.03762745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128171"},
        {"Hipparcos Number", "HIP 71380"},
        {"Geneva Identification System", "GEN# +1.00128171"},
        {"Smithsonian Astrophysical Observation", "SAO 158665"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.95179574),
        dec: Angle.Degrees(-18.03649241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198208"},
        {"Hipparcos Number", "HIP 102780"},
        {"Fundamental Katalog 5th Edition", "FK5 3663"},
        {"Geneva Identification System", "GEN# +1.00198208"},
        {"Smithsonian Astrophysical Observation", "SAO 163910"},
        {"Wilson Evans Batten Catalogue", "WEB 18636"},
    },
    visualMagnitude: 6.20,
    bvColour: 1.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.33559192),
        dec: Angle.Degrees(-18.03577344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62951",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8699 B"},
        {"Hipparcos Number", "HIP 62951"},
        {"Smithsonian Astrophysical Observation", "SAO 157579"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.49471435),
        dec: Angle.Degrees(-18.03500059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 97.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76636"},
        {"Hipparcos Number", "HIP 43925"},
        {"Smithsonian Astrophysical Observation", "SAO 154782"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.21073716),
        dec: Angle.Degrees(-18.03497465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62839"},
        {"Hipparcos Number", "HIP 37822"},
        {"Smithsonian Astrophysical Observation", "SAO 153354"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.32392211),
        dec: Angle.Degrees(-18.03496805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89884"},
        {"Hipparcos Number", "HIP 50764"},
        {"Geneva Identification System", "GEN# +1.00089884"},
        {"Smithsonian Astrophysical Observation", "SAO 155931"},
        {"Wilson Evans Batten Catalogue", "WEB 9293"},
    },
    visualMagnitude: 7.12,
    bvColour: -0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.49753437),
        dec: Angle.Degrees(-18.03446458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116986"},
        {"Hipparcos Number", "HIP 65652"},
        {"Smithsonian Astrophysical Observation", "SAO 157948"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.89934778),
        dec: Angle.Degrees(-18.03224141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5248"},
        {"Hipparcos Number", "HIP 4242"},
        {"Geneva Identification System", "GEN# +1.00005248"},
        {"Smithsonian Astrophysical Observation", "SAO 147508"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.816,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.53785717),
        dec: Angle.Degrees(-18.03190991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 132.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116259"},
        {"Hipparcos Number", "HIP 65275"},
        {"Geneva Identification System", "GEN# +1.00116259"},
        {"Smithsonian Astrophysical Observation", "SAO 157892"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.68211289),
        dec: Angle.Degrees(-18.03081138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -163.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142557"},
        {"Hipparcos Number", "HIP 78018"},
        {"Smithsonian Astrophysical Observation", "SAO 159580"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.95759041),
        dec: Angle.Degrees(-18.02964338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191112"},
        {"Hipparcos Number", "HIP 99247"},
        {"Smithsonian Astrophysical Observation", "SAO 163292"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.19989393),
        dec: Angle.Degrees(-18.02777222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140988"},
        {"Hipparcos Number", "HIP 77328"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.80977637),
        dec: Angle.Degrees(-18.02752852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46852"},
        {"Hipparcos Number", "HIP 31395"},
        {"Smithsonian Astrophysical Observation", "SAO 151663"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.71972507),
        dec: Angle.Degrees(-18.02734343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210707"},
        {"Hipparcos Number", "HIP 109634"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.13800915),
        dec: Angle.Degrees(-18.02717247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222547"},
        {"Hipparcos Number", "HIP 116889"},
        {"Geneva Identification System", "GEN# +1.00222547"},
        {"Smithsonian Astrophysical Observation", "SAO 165834"},
        {"Wilson Evans Batten Catalogue", "WEB 20621"},
    },
    visualMagnitude: 5.36,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.39380754),
        dec: Angle.Degrees(-18.02690134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165632"},
        {"Hipparcos Number", "HIP 88804"},
        {"Smithsonian Astrophysical Observation", "SAO 161091"},
    },
    visualMagnitude: 8.59,
    bvColour: 2.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.91893049),
        dec: Angle.Degrees(-18.02603304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223738"},
        {"Hipparcos Number", "HIP 117708"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.08308648),
        dec: Angle.Degrees(-18.02589311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73199"},
        {"Hipparcos Number", "HIP 42224"},
        {"Smithsonian Astrophysical Observation", "SAO 154451"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.13558571),
        dec: Angle.Degrees(-18.02228276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168863"},
        {"Hipparcos Number", "HIP 90055"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.66516824),
        dec: Angle.Degrees(-18.02046271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -136.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -222.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3017"},
        {"Hipparcos Number", "HIP 2619"},
        {"Geneva Identification System", "GEN# +1.00003017"},
        {"Smithsonian Astrophysical Observation", "SAO 147335"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.31166720),
        dec: Angle.Degrees(-18.01786240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14493"},
        {"Hipparcos Number", "HIP 10878"},
        {"Smithsonian Astrophysical Observation", "SAO 148336"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.99418761),
        dec: Angle.Degrees(-18.01564564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83978",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10370 AB"},
        {"Henry Draper", "HD 155063"},
        {"Hipparcos Number", "HIP 83978"},
        {"Smithsonian Astrophysical Observation", "SAO 160325"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.50303841),
        dec: Angle.Degrees(-18.01543826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134252"},
        {"Hipparcos Number", "HIP 74172"},
        {"Smithsonian Astrophysical Observation", "SAO 159052"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.33388612),
        dec: Angle.Degrees(-18.01485665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207612"},
        {"Hipparcos Number", "HIP 107824"},
        {"Smithsonian Astrophysical Observation", "SAO 164690"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.66329495),
        dec: Angle.Degrees(-18.01373701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74310",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74310"},
    },
    visualMagnitude: 11.14,
    bvColour: 1.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.83409809),
        dec: Angle.Degrees(-18.01214396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -150.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212657"},
        {"Hipparcos Number", "HIP 110758"},
        {"Smithsonian Astrophysical Observation", "SAO 165073"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.57560162),
        dec: Angle.Degrees(-18.01089372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -114.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74627"},
        {"Hipparcos Number", "HIP 42886"},
        {"Smithsonian Astrophysical Observation", "SAO 154594"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.10285548),
        dec: Angle.Degrees(-18.01026631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224224"},
        {"Hipparcos Number", "HIP 118006"},
        {"Smithsonian Astrophysical Observation", "SAO 165961"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.03308007),
        dec: Angle.Degrees(-18.00679640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127073"},
        {"Hipparcos Number", "HIP 70888"},
        {"Smithsonian Astrophysical Observation", "SAO 158601"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.44408871),
        dec: Angle.Degrees(-18.00550394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54546"},
        {"Hipparcos Number", "HIP 34458"},
        {"Smithsonian Astrophysical Observation", "SAO 152453"},
    },
    visualMagnitude: 8.62,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.14347854),
        dec: Angle.Degrees(-18.00529304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65882"},
        {"Hipparcos Number", "HIP 39136"},
        {"Smithsonian Astrophysical Observation", "SAO 153698"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.08063388),
        dec: Angle.Degrees(-18.00441913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64068",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8787 AB"},
        {"Henry Draper", "HD 114019"},
        {"Hipparcos Number", "HIP 64068"},
        {"Smithsonian Astrophysical Observation", "SAO 157736"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.95723091),
        dec: Angle.Degrees(-18.00437465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36018"},
        {"Hipparcos Number", "HIP 25573"},
        {"Geneva Identification System", "GEN# +1.00036018"},
        {"Smithsonian Astrophysical Observation", "SAO 150476"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.98693186),
        dec: Angle.Degrees(-18.00395114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148969"},
        {"Hipparcos Number", "HIP 80988"},
        {"Smithsonian Astrophysical Observation", "SAO 159967"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.09870755),
        dec: Angle.Degrees(-18.00291180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129829"},
        {"Hipparcos Number", "HIP 72134"},
        {"Geneva Identification System", "GEN# +1.00129829"},
        {"Smithsonian Astrophysical Observation", "SAO 158774"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.32803084),
        dec: Angle.Degrees(-18.00271693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -123.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79341",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79341"},
        {"Smithsonian Astrophysical Observation", "SAO 159759"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.88669047),
        dec: Angle.Degrees(-18.00050559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75601",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75601"},
        {"Smithsonian Astrophysical Observation", "SAO 159262"},
    },
    visualMagnitude: 9.67,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.69565446),
        dec: Angle.Degrees(-17.99902308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208867"},
        {"Hipparcos Number", "HIP 108562"},
        {"Smithsonian Astrophysical Observation", "SAO 164795"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.86541649),
        dec: Angle.Degrees(-17.99562812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11132"},
        {"Hipparcos Number", "HIP 8463"},
        {"Smithsonian Astrophysical Observation", "SAO 148031"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.28609218),
        dec: Angle.Degrees(-17.99408904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69247",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "NC 39"},
        {"Henry Draper", "HD 123884"},
        {"Hipparcos Number", "HIP 69247"},
        {"Geneva Identification System", "GEN# +1.00123884"},
        {"Renson", "Renson 35436"},
        {"Smithsonian Astrophysical Observation", "SAO 158396"},
        {"Wilson Evans Batten Catalogue", "WEB 12084"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.64076111),
        dec: Angle.Degrees(-17.99090800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45477"},
        {"Hipparcos Number", "HIP 30681"},
        {"Smithsonian Astrophysical Observation", "SAO 151516"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.71019052),
        dec: Angle.Degrees(-17.99020768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172545"},
        {"Hipparcos Number", "HIP 91667"},
        {"Fundamental Katalog 5th Edition", "FK5 5642"},
        {"Smithsonian Astrophysical Observation", "SAO 161727"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.40124958),
        dec: Angle.Degrees(-17.98777428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40477"},
        {"Hipparcos Number", "HIP 28259"},
        {"Smithsonian Astrophysical Observation", "SAO 150986"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.56208325),
        dec: Angle.Degrees(-17.98723343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206928"},
        {"Hipparcos Number", "HIP 107454"},
        {"Smithsonian Astrophysical Observation", "SAO 164632"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.46333701),
        dec: Angle.Degrees(-17.98720443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -178.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185904"},
        {"Hipparcos Number", "HIP 96921"},
        {"Smithsonian Astrophysical Observation", "SAO 162906"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.52729776),
        dec: Angle.Degrees(-17.98720152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155489"},
        {"Hipparcos Number", "HIP 84194"},
        {"Smithsonian Astrophysical Observation", "SAO 160361"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.15430951),
        dec: Angle.Degrees(-17.98704482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3419",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Diphda"},
        {"Henry Draper", "HD 4128"},
        {"Hipparcos Number", "HIP 3419"},
        {"Fundamental Katalog 5th Edition", "FK5 22"},
        {"Geneva Identification System", "GEN# +1.00004128"},
        {"Smithsonian Astrophysical Observation", "SAO 147420"},
        {"Wilson Evans Batten Catalogue", "WEB 604"},
    },
    visualMagnitude: 2.04,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.89678452),
        dec: Angle.Degrees(-17.98668410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 232.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202671"},
        {"Hipparcos Number", "HIP 105143"},
        {"Geneva Identification System", "GEN# +1.00202671"},
        {"Renson", "Renson 56480"},
        {"Smithsonian Astrophysical Observation", "SAO 164286"},
        {"Wilson Evans Batten Catalogue", "WEB 19097"},
    },
    visualMagnitude: 5.40,
    bvColour: -0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.48865236),
        dec: Angle.Degrees(-17.98513635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148438"},
        {"Hipparcos Number", "HIP 80712"},
        {"Smithsonian Astrophysical Observation", "SAO 159935"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.18963645),
        dec: Angle.Degrees(-17.98497490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89747"},
        {"Hipparcos Number", "HIP 50693"},
        {"Geneva Identification System", "GEN# +1.00089747"},
        {"Smithsonian Astrophysical Observation", "SAO 155920"},
    },
    visualMagnitude: 6.50,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.28324051),
        dec: Angle.Degrees(-17.98488815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52954",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52954"},
    },
    visualMagnitude: 10.49,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.45583576),
        dec: Angle.Degrees(-17.98336031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -112.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -160.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85059",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85059"},
    },
    visualMagnitude: 11.20,
    bvColour: 1.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.75589999),
        dec: Angle.Degrees(-17.98070168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84545",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10431 AB"},
        {"Henry Draper", "HD 156211"},
        {"Hipparcos Number", "HIP 84545"},
        {"Smithsonian Astrophysical Observation", "SAO 160421"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.742,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.25239581),
        dec: Angle.Degrees(-17.97907671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51073",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51073"},
        {"Geneva Identification System", "GEN# +9.85790019"},
    },
    visualMagnitude: 10.92,
    bvColour: 1.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.53327124),
        dec: Angle.Degrees(-17.97899080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -570.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 191.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152418"},
        {"Hipparcos Number", "HIP 82665"},
        {"Smithsonian Astrophysical Observation", "SAO 160151"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.48723448),
        dec: Angle.Degrees(-17.97641726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24045"},
        {"Hipparcos Number", "HIP 17852"},
        {"Geneva Identification System", "GEN# +1.00024045"},
        {"Smithsonian Astrophysical Observation", "SAO 149186"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.29863293),
        dec: Angle.Degrees(-17.97145736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31769",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31769"},
        {"Smithsonian Astrophysical Observation", "SAO 151740"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.66219743),
        dec: Angle.Degrees(-17.96921562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 730"},
        {"Hipparcos Number", "HIP 939"},
        {"Smithsonian Astrophysical Observation", "SAO 147137"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.90334595),
        dec: Angle.Degrees(-17.96890292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142112"},
        {"Hipparcos Number", "HIP 77808"},
        {"Geneva Identification System", "GEN# +1.00142112"},
        {"Smithsonian Astrophysical Observation", "SAO 159555"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.32154975),
        dec: Angle.Degrees(-17.96822188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13774"},
        {"Hipparcos Number", "HIP 10392"},
        {"Smithsonian Astrophysical Observation", "SAO 148280"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.46604272),
        dec: Angle.Degrees(-17.96783775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67164",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67164"},
    },
    visualMagnitude: 11.81,
    bvColour: 1.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.46209637),
        dec: Angle.Degrees(-17.96688325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -311.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -549.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24321",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24321"},
        {"Smithsonian Astrophysical Observation", "SAO 150241"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.29528550),
        dec: Angle.Degrees(-17.96278436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79731"},
        {"Hipparcos Number", "HIP 45408"},
        {"Smithsonian Astrophysical Observation", "SAO 155029"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.80260231),
        dec: Angle.Degrees(-17.96258942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189116"},
        {"Hipparcos Number", "HIP 98361"},
        {"Smithsonian Astrophysical Observation", "SAO 163155"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.76226095),
        dec: Angle.Degrees(-17.95943468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44442"},
        {"Hipparcos Number", "HIP 30184"},
        {"Smithsonian Astrophysical Observation", "SAO 151394"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.26182179),
        dec: Angle.Degrees(-17.95753520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154214"},
        {"Hipparcos Number", "HIP 83572"},
        {"Smithsonian Astrophysical Observation", "SAO 160265"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.20109055),
        dec: Angle.Degrees(-17.95749556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53917",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53917"},
    },
    visualMagnitude: 11.88,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.48812800),
        dec: Angle.Degrees(-17.95646754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41488"},
        {"Hipparcos Number", "HIP 28794"},
        {"Smithsonian Astrophysical Observation", "SAO 151086"},
    },
    visualMagnitude: 7.81,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.19313119),
        dec: Angle.Degrees(-17.95626719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30324",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Mirzam"},
        {"Henry Draper", "HD 44743"},
        {"Hipparcos Number", "HIP 30324"},
        {"Celescope Catalog", "CEL 1207"},
        {"Fundamental Katalog 5th Edition", "FK5 243"},
        {"Geneva Identification System", "GEN# +1.00044743"},
        {"Smithsonian Astrophysical Observation", "SAO 151428"},
        {"Wilson Evans Batten Catalogue", "WEB 6031"},
    },
    visualMagnitude: 1.98,
    bvColour: -0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.67494750),
        dec: Angle.Degrees(-17.95591658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187366"},
        {"Hipparcos Number", "HIP 97596"},
        {"Geneva Identification System", "GEN# +1.00187366"},
        {"Smithsonian Astrophysical Observation", "SAO 163025"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.55793332),
        dec: Angle.Degrees(-17.95387399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159699"},
        {"Hipparcos Number", "HIP 86196"},
        {"Smithsonian Astrophysical Observation", "SAO 160686"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.21994337),
        dec: Angle.Degrees(-17.95330787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103361"},
        {"Hipparcos Number", "HIP 58025"},
        {"Smithsonian Astrophysical Observation", "SAO 156973"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.51504906),
        dec: Angle.Degrees(-17.95259790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81568"},
        {"Hipparcos Number", "HIP 46259"},
        {"Geneva Identification System", "GEN# +1.00081568"},
        {"Smithsonian Astrophysical Observation", "SAO 155181"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.48674152),
        dec: Angle.Degrees(-17.94737758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84509",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84509"},
    },
    visualMagnitude: 10.09,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.14737259),
        dec: Angle.Degrees(-17.94639719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26279"},
        {"Hipparcos Number", "HIP 19360"},
        {"Geneva Identification System", "GEN# +1.00026279"},
        {"Smithsonian Astrophysical Observation", "SAO 149404"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.20806937),
        dec: Angle.Degrees(-17.94526836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223192"},
        {"Hipparcos Number", "HIP 117338"},
        {"Geneva Identification System", "GEN# +1.00223192"},
        {"Smithsonian Astrophysical Observation", "SAO 165883"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.88220367),
        dec: Angle.Degrees(-17.94255571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32758"},
        {"Hipparcos Number", "HIP 23618"},
        {"Geneva Identification System", "GEN# +1.00032758"},
        {"Smithsonian Astrophysical Observation", "SAO 150124"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.16956962),
        dec: Angle.Degrees(-17.94144663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108800"},
        {"Hipparcos Number", "HIP 61005"},
        {"Smithsonian Astrophysical Observation", "SAO 157327"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.54771235),
        dec: Angle.Degrees(-17.94131536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43594"},
        {"Hipparcos Number", "HIP 29785"},
        {"Smithsonian Astrophysical Observation", "SAO 151297"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.06786144),
        dec: Angle.Degrees(-17.93934964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87425"},
        {"Hipparcos Number", "HIP 49362"},
        {"Smithsonian Astrophysical Observation", "SAO 155710"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.14945292),
        dec: Angle.Degrees(-17.93927943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 787"},
        {"Hipparcos Number", "HIP 983"},
        {"Geneva Identification System", "GEN# +1.00000787"},
        {"Smithsonian Astrophysical Observation", "SAO 147144"},
        {"Wilson Evans Batten Catalogue", "WEB 174"},
    },
    visualMagnitude: 5.29,
    bvColour: 1.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.04145374),
        dec: Angle.Degrees(-17.93821766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9061"},
        {"Hipparcos Number", "HIP 6909"},
        {"Fundamental Katalog 5th Edition", "FK5 4136"},
        {"Geneva Identification System", "GEN# +1.00009061"},
        {"Smithsonian Astrophysical Observation", "SAO 147831"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.23930331),
        dec: Angle.Degrees(-17.93734287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119608"},
        {"Hipparcos Number", "HIP 67060"},
        {"Geneva Identification System", "GEN# +1.00119608"},
        {"Smithsonian Astrophysical Observation", "SAO 158132"},
        {"Wilson Evans Batten Catalogue", "WEB 11811"},
    },
    visualMagnitude: 7.50,
    bvColour: -0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.13048351),
        dec: Angle.Degrees(-17.93701331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144586"},
        {"Hipparcos Number", "HIP 78968"},
        {"Geneva Identification System", "GEN# +1.00144586"},
        {"Smithsonian Astrophysical Observation", "SAO 159707"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.81222176),
        dec: Angle.Degrees(-17.93598366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8447"},
        {"Hipparcos Number", "HIP 6487"},
        {"Fundamental Katalog 5th Edition", "FK5 2094"},
        {"Geneva Identification System", "GEN# +1.00008447"},
        {"Smithsonian Astrophysical Observation", "SAO 147773"},
        {"Wilson Evans Batten Catalogue", "WEB 1432"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.83951093),
        dec: Angle.Degrees(-17.93392486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31775",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31775"},
        {"Smithsonian Astrophysical Observation", "SAO 151741"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.66926521),
        dec: Angle.Degrees(-17.93185891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210033"},
        {"Hipparcos Number", "HIP 109244"},
        {"Smithsonian Astrophysical Observation", "SAO 164871"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.96850116),
        dec: Angle.Degrees(-17.93110426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65919"},
        {"Hipparcos Number", "HIP 39155"},
        {"Smithsonian Astrophysical Observation", "SAO 153704"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.12221158),
        dec: Angle.Degrees(-17.93010504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138459"},
        {"Hipparcos Number", "HIP 76117"},
        {"Smithsonian Astrophysical Observation", "SAO 159333"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.19670342),
        dec: Angle.Degrees(-17.92911528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108216"},
        {"Hipparcos Number", "HIP 60663"},
        {"Smithsonian Astrophysical Observation", "SAO 157282"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.49743567),
        dec: Angle.Degrees(-17.92901437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116928"},
        {"Hipparcos Number", "HIP 65614"},
        {"Smithsonian Astrophysical Observation", "SAO 157942"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.79519693),
        dec: Angle.Degrees(-17.92887782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60747"},
        {"Hipparcos Number", "HIP 36913"},
        {"Smithsonian Astrophysical Observation", "SAO 153105"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.84011902),
        dec: Angle.Degrees(-17.92748340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100766"},
        {"Hipparcos Number", "HIP 56555"},
        {"Smithsonian Astrophysical Observation", "SAO 156775"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.93637134),
        dec: Angle.Degrees(-17.92727562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85723"},
        {"Hipparcos Number", "HIP 48494"},
        {"Smithsonian Astrophysical Observation", "SAO 155572"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.34698532),
        dec: Angle.Degrees(-17.92613260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207007"},
        {"Hipparcos Number", "HIP 107509"},
        {"Smithsonian Astrophysical Observation", "SAO 164637"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.61439022),
        dec: Angle.Degrees(-17.92327722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -114.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199012"},
        {"Hipparcos Number", "HIP 103226"},
        {"Geneva Identification System", "GEN# +1.00199012"},
        {"Smithsonian Astrophysical Observation", "SAO 163975"},
        {"Wilson Evans Batten Catalogue", "WEB 18755"},
    },
    visualMagnitude: 5.78,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.69938483),
        dec: Angle.Degrees(-17.92285285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180539"},
        {"Hipparcos Number", "HIP 94819"},
        {"Geneva Identification System", "GEN# +1.00180539"},
        {"Smithsonian Astrophysical Observation", "SAO 162414"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.40422168),
        dec: Angle.Degrees(-17.92164056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46114"},
        {"Hipparcos Number", "HIP 31030"},
        {"Geneva Identification System", "GEN# +1.00046114"},
        {"Smithsonian Astrophysical Observation", "SAO 151587"},
        {"Wilson Evans Batten Catalogue", "WEB 6177"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.817,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.66496479),
        dec: Angle.Degrees(-17.92153719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -162.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -208.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188618"},
        {"Hipparcos Number", "HIP 98136"},
        {"Geneva Identification System", "GEN# +1.00188618"},
        {"Smithsonian Astrophysical Observation", "SAO 163123"},
        {"Wilson Evans Batten Catalogue", "WEB 17297"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.16867984),
        dec: Angle.Degrees(-17.92138199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50938"},
        {"Hipparcos Number", "HIP 33200"},
        {"Celescope Catalog", "CEL 1428"},
        {"Geneva Identification System", "GEN# +1.00050938"},
        {"Smithsonian Astrophysical Observation", "SAO 152085"},
    },
    visualMagnitude: 7.63,
    bvColour: -0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.64962687),
        dec: Angle.Degrees(-17.91720475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156169"},
        {"Hipparcos Number", "HIP 84526"},
        {"Fundamental Katalog 5th Edition", "FK5 5525"},
        {"Geneva Identification System", "GEN# +1.00156169"},
        {"Smithsonian Astrophysical Observation", "SAO 160418"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.18429438),
        dec: Angle.Degrees(-17.91458935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55825",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55825"},
        {"Wilson Evans Batten Catalogue", "WEB 10034"},
    },
    visualMagnitude: 11.78,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.62356267),
        dec: Angle.Degrees(-17.91433373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25231"},
        {"Hipparcos Number", "HIP 18665"},
        {"Smithsonian Astrophysical Observation", "SAO 149303"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.94381648),
        dec: Angle.Degrees(-17.91227220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175383"},
        {"Hipparcos Number", "HIP 92917"},
        {"Smithsonian Astrophysical Observation", "SAO 161992"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.97021998),
        dec: Angle.Degrees(-17.91098071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202150"},
        {"Hipparcos Number", "HIP 104863"},
        {"Smithsonian Astrophysical Observation", "SAO 164241"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.63112175),
        dec: Angle.Degrees(-17.90476989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50825"},
        {"Hipparcos Number", "HIP 33146"},
        {"Geneva Identification System", "GEN# +1.00050825"},
        {"Renson", "Renson 13960"},
        {"Smithsonian Astrophysical Observation", "SAO 152072"},
    },
    visualMagnitude: 8.17,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.52386600),
        dec: Angle.Degrees(-17.90372487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133354"},
        {"Hipparcos Number", "HIP 73753"},
        {"Smithsonian Astrophysical Observation", "SAO 159006"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.13605456),
        dec: Angle.Degrees(-17.90367893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133353"},
        {"Hipparcos Number", "HIP 73751"},
        {"Smithsonian Astrophysical Observation", "SAO 159004"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.12873602),
        dec: Angle.Degrees(-17.90361989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209240"},
        {"Hipparcos Number", "HIP 108784"},
        {"Fundamental Katalog 5th Edition", "FK5 3761"},
        {"Geneva Identification System", "GEN# +1.00209240"},
        {"Smithsonian Astrophysical Observation", "SAO 164827"},
        {"Wilson Evans Batten Catalogue", "WEB 19568"},
    },
    visualMagnitude: 6.28,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.54909407),
        dec: Angle.Degrees(-17.90332874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179722"},
        {"Hipparcos Number", "HIP 94534"},
        {"Geneva Identification System", "GEN# +1.00179722"},
        {"Smithsonian Astrophysical Observation", "SAO 162349"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.59229687),
        dec: Angle.Degrees(-17.90203552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141465"},
        {"Hipparcos Number", "HIP 77534"},
        {"Geneva Identification System", "GEN# +1.00141465"},
        {"Smithsonian Astrophysical Observation", "SAO 159518"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.46784399),
        dec: Angle.Degrees(-17.90193562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39378"},
        {"Hipparcos Number", "HIP 27665"},
        {"Smithsonian Astrophysical Observation", "SAO 150873"},
    },
    visualMagnitude: 8.18,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.86479369),
        dec: Angle.Degrees(-17.90178921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56336"},
        {"Hipparcos Number", "HIP 35156"},
        {"Geneva Identification System", "GEN# +1.00056336"},
        {"Renson", "Renson 15350"},
        {"Smithsonian Astrophysical Observation", "SAO 152633"},
    },
    visualMagnitude: 9.06,
    bvColour: -0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.99458439),
        dec: Angle.Degrees(-17.90172297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40620"},
        {"Hipparcos Number", "HIP 28336"},
        {"Smithsonian Astrophysical Observation", "SAO 150995"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.81876624),
        dec: Angle.Degrees(-17.90025668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 194.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168675"},
        {"Hipparcos Number", "HIP 89992"},
        {"Geneva Identification System", "GEN# +1.00168675"},
        {"Smithsonian Astrophysical Observation", "SAO 161383"},
        {"Wilson Evans Batten Catalogue", "WEB 15374"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.42964339),
        dec: Angle.Degrees(-17.89759478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208482"},
        {"Hipparcos Number", "HIP 108327"},
        {"Geneva Identification System", "GEN# +1.00208482"},
        {"Smithsonian Astrophysical Observation", "SAO 164756"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.19165888),
        dec: Angle.Degrees(-17.89705676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31507",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31507"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.97335542),
        dec: Angle.Degrees(-17.89687273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -220.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160641"},
        {"Hipparcos Number", "HIP 86605"},
        {"Geneva Identification System", "GEN# +1.00160641"},
        {"Renson", "Renson 45230"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.46492936),
        dec: Angle.Degrees(-17.89680090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1232"},
        {"Hipparcos Number", "HIP 1317"},
        {"Geneva Identification System", "GEN# +1.00001232"},
        {"Smithsonian Astrophysical Observation", "SAO 147194"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.14006714),
        dec: Angle.Degrees(-17.89575397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210190"},
        {"Hipparcos Number", "HIP 109330"},
        {"Smithsonian Astrophysical Observation", "SAO 164887"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.791,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.24412968),
        dec: Angle.Degrees(-17.89490807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 225.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 161.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80971"},
        {"Hipparcos Number", "HIP 45968"},
        {"Geneva Identification System", "GEN# +1.00080971"},
        {"Smithsonian Astrophysical Observation", "SAO 155129"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.62248155),
        dec: Angle.Degrees(-17.89397272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122371"},
        {"Hipparcos Number", "HIP 68538"},
        {"Smithsonian Astrophysical Observation", "SAO 158295"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.46383192),
        dec: Angle.Degrees(-17.89358515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221678"},
        {"Hipparcos Number", "HIP 116322"},
        {"Smithsonian Astrophysical Observation", "SAO 165771"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.53543684),
        dec: Angle.Degrees(-17.89229772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35943",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35943"},
    },
    visualMagnitude: 10.34,
    bvColour: 1.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.14284920),
        dec: Angle.Degrees(-17.89210865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10519"},
        {"Hipparcos Number", "HIP 7961"},
        {"Cincinnati Publication", "Ci 20 122"},
        {"Cincinnati Publication 2", "Ci 18 240"},
        {"Geneva Identification System", "GEN# +1.00010519"},
        {"Smithsonian Astrophysical Observation", "SAO 147969"},
        {"Wilson Evans Batten Catalogue", "WEB 1703"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.56072752),
        dec: Angle.Degrees(-17.88883494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 548.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128785"},
        {"Hipparcos Number", "HIP 71654"},
        {"Geneva Identification System", "GEN# +1.00128785"},
        {"Smithsonian Astrophysical Observation", "SAO 158702"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.84615889),
        dec: Angle.Degrees(-17.88797607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92215"},
        {"Hipparcos Number", "HIP 52084"},
        {"Geneva Identification System", "GEN# +1.00092215"},
        {"Smithsonian Astrophysical Observation", "SAO 156120"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.64131492),
        dec: Angle.Degrees(-17.88717791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3822"},
        {"Hipparcos Number", "HIP 3190"},
        {"Smithsonian Astrophysical Observation", "SAO 147397"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.16145433),
        dec: Angle.Degrees(-17.88682512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99970"},
        {"Hipparcos Number", "HIP 56103"},
        {"Smithsonian Astrophysical Observation", "SAO 156714"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.49799431),
        dec: Angle.Degrees(-17.88587579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32739"},
        {"Hipparcos Number", "HIP 23612"},
        {"Smithsonian Astrophysical Observation", "SAO 150122"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.15505343),
        dec: Angle.Degrees(-17.88512396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124107"},
        {"Hipparcos Number", "HIP 69362"},
        {"Smithsonian Astrophysical Observation", "SAO 158417"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.718,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.97120645),
        dec: Angle.Degrees(-17.88384203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7129"},
        {"Hipparcos Number", "HIP 5560"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.82403063),
        dec: Angle.Degrees(-17.88354936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54884"},
        {"Hipparcos Number", "HIP 34598"},
        {"Celescope Catalog", "CEL 1632"},
        {"Geneva Identification System", "GEN# +1.00054884"},
        {"Smithsonian Astrophysical Observation", "SAO 152490"},
    },
    visualMagnitude: 9.49,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.49265758),
        dec: Angle.Degrees(-17.88257709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113082"},
        {"Hipparcos Number", "HIP 63552"},
        {"Smithsonian Astrophysical Observation", "SAO 157657"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.34354429),
        dec: Angle.Degrees(-17.88204510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127522"},
        {"Hipparcos Number", "HIP 71098"},
        {"Fundamental Katalog 5th Edition", "FK5 5285"},
        {"Geneva Identification System", "GEN# +1.00127522"},
        {"Smithsonian Astrophysical Observation", "SAO 158625"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.09083676),
        dec: Angle.Degrees(-17.88120360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6355",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6355"},
        {"Smithsonian Astrophysical Observation", "SAO 147758"},
    },
    visualMagnitude: 10.21,
    bvColour: 1.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.40489485),
        dec: Angle.Degrees(-17.87951654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158542"},
        {"Hipparcos Number", "HIP 85689"},
        {"Geneva Identification System", "GEN# +1.00158542"},
        {"Smithsonian Astrophysical Observation", "SAO 160598"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.66875977),
        dec: Angle.Degrees(-17.87942323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22559"},
        {"Hipparcos Number", "HIP 16877"},
        {"Geneva Identification System", "GEN# +1.00022559"},
        {"Smithsonian Astrophysical Observation", "SAO 149070"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.29082881),
        dec: Angle.Degrees(-17.87649123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16854",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16854"},
        {"Smithsonian Astrophysical Observation", "SAO 149068"},
    },
    visualMagnitude: 10.17,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.22700577),
        dec: Angle.Degrees(-17.87529735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101040",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13887 D"},
        {"Henry Draper", "HD 194960"},
        {"Hipparcos Number", "HIP 101040"},
        {"Geneva Identification System", "GEN# +1.00194960"},
        {"Smithsonian Astrophysical Observation", "SAO 163617"},
        {"Wilson Evans Batten Catalogue", "WEB 18247"},
    },
    visualMagnitude: 6.55,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.25279180),
        dec: Angle.Degrees(-17.87511799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78975",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78975"},
        {"Smithsonian Astrophysical Observation", "SAO 159708"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.82261266),
        dec: Angle.Degrees(-17.87508004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27115"},
        {"Hipparcos Number", "HIP 19913"},
        {"Smithsonian Astrophysical Observation", "SAO 149500"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.07809244),
        dec: Angle.Degrees(-17.87494127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61650"},
        {"Hipparcos Number", "HIP 37313"},
        {"Fundamental Katalog 5th Edition", "FK5 4689"},
        {"Smithsonian Astrophysical Observation", "SAO 153209"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.90772447),
        dec: Angle.Degrees(-17.87153691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205150"},
        {"Hipparcos Number", "HIP 106470"},
        {"Smithsonian Astrophysical Observation", "SAO 164479"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.46958595),
        dec: Angle.Degrees(-17.86837497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78496"},
        {"Hipparcos Number", "HIP 44835"},
        {"Smithsonian Astrophysical Observation", "SAO 154931"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.03187915),
        dec: Angle.Degrees(-17.86740341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28172"},
        {"Hipparcos Number", "HIP 20695"},
        {"Smithsonian Astrophysical Observation", "SAO 149629"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.50223450),
        dec: Angle.Degrees(-17.86649768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18816"},
        {"Hipparcos Number", "HIP 14057"},
        {"Smithsonian Astrophysical Observation", "SAO 148715"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.27733805),
        dec: Angle.Degrees(-17.86581435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57391"},
        {"Hipparcos Number", "HIP 35560"},
        {"Smithsonian Astrophysical Observation", "SAO 152740"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.07754011),
        dec: Angle.Degrees(-17.86514764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36186",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6093 AB"},
        {"Henry Draper", "HD 58954"},
        {"Hipparcos Number", "HIP 36186"},
        {"Geneva Identification System", "GEN# +1.00058954J"},
        {"Smithsonian Astrophysical Observation", "SAO 152894"},
        {"Wilson Evans Batten Catalogue", "WEB 7205"},
    },
    visualMagnitude: 5.60,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.78329832),
        dec: Angle.Degrees(-17.86486511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62617"},
        {"Hipparcos Number", "HIP 37725"},
        {"Smithsonian Astrophysical Observation", "SAO 153328"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.06556836),
        dec: Angle.Degrees(-17.86393289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159589"},
        {"Hipparcos Number", "HIP 86142"},
        {"Geneva Identification System", "GEN# +1.00159589"},
        {"Smithsonian Astrophysical Observation", "SAO 160678"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.05548914),
        dec: Angle.Degrees(-17.86361088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143713"},
        {"Hipparcos Number", "HIP 78566"},
        {"Smithsonian Astrophysical Observation", "SAO 159647"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.64563494),
        dec: Angle.Degrees(-17.86290417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120052"},
        {"Hipparcos Number", "HIP 67288"},
        {"Geneva Identification System", "GEN# +1.00120052"},
        {"Smithsonian Astrophysical Observation", "SAO 158165"},
        {"Wilson Evans Batten Catalogue", "WEB 11838"},
    },
    visualMagnitude: 5.41,
    bvColour: 1.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.85564413),
        dec: Angle.Degrees(-17.85976354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193037"},
        {"Hipparcos Number", "HIP 100129"},
        {"Geneva Identification System", "GEN# +1.00193037"},
        {"Smithsonian Astrophysical Observation", "SAO 163434"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.68600480),
        dec: Angle.Degrees(-17.85533789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50117"},
        {"Hipparcos Number", "HIP 32868"},
        {"Geneva Identification System", "GEN# +1.00050117"},
        {"Smithsonian Astrophysical Observation", "SAO 152007"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.74329396),
        dec: Angle.Degrees(-17.85464403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 105.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104890"},
        {"Hipparcos Number", "HIP 58900"},
        {"Smithsonian Astrophysical Observation", "SAO 157075"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.18852200),
        dec: Angle.Degrees(-17.85100984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27424"},
        {"Hipparcos Number", "HIP 20134"},
        {"Renson", "Renson 7043"},
        {"Smithsonian Astrophysical Observation", "SAO 149535"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.75402858),
        dec: Angle.Degrees(-17.85091570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26602",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4254 AB"},
        {"Henry Draper", "HD 37643"},
        {"Hipparcos Number", "HIP 26602"},
        {"Geneva Identification System", "GEN# +1.00037643"},
        {"Smithsonian Astrophysical Observation", "SAO 150652"},
        {"Wilson Evans Batten Catalogue", "WEB 5246"},
    },
    visualMagnitude: 6.40,
    bvColour: -0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.81761707),
        dec: Angle.Degrees(-17.84941510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13229"},
        {"Hipparcos Number", "HIP 10007"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.22504315),
        dec: Angle.Degrees(-17.84796913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181577"},
        {"Hipparcos Number", "HIP 95168"},
        {"Geneva Identification System", "GEN# +1.00181577"},
        {"Smithsonian Astrophysical Observation", "SAO 162512"},
        {"Wilson Evans Batten Catalogue", "WEB 16624"},
    },
    visualMagnitude: 3.92,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.41823037),
        dec: Angle.Degrees(-17.84725155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215116"},
        {"Hipparcos Number", "HIP 112180"},
        {"Smithsonian Astrophysical Observation", "SAO 165249"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.81055698),
        dec: Angle.Degrees(-17.84527995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148351"},
        {"Hipparcos Number", "HIP 80655"},
        {"Geneva Identification System", "GEN# +1.00148351"},
        {"Smithsonian Astrophysical Observation", "SAO 159927"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.00194663),
        dec: Angle.Degrees(-17.84480253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199385"},
        {"Hipparcos Number", "HIP 103436"},
        {"Smithsonian Astrophysical Observation", "SAO 164007"},
    },
    visualMagnitude: 9.55,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.34222821),
        dec: Angle.Degrees(-17.84375608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48774"},
        {"Hipparcos Number", "HIP 32278"},
        {"Smithsonian Astrophysical Observation", "SAO 151861"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.08487861),
        dec: Angle.Degrees(-17.84322037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32377",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32377"},
        {"Smithsonian Astrophysical Observation", "SAO 151886"},
    },
    visualMagnitude: 9.56,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.36266921),
        dec: Angle.Degrees(-17.84196595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28387"},
        {"Hipparcos Number", "HIP 20839"},
        {"Smithsonian Astrophysical Observation", "SAO 149659"},
        {"Wilson Evans Batten Catalogue", "WEB 3999"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.99205449),
        dec: Angle.Degrees(-17.84099220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15042",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15042"},
    },
    visualMagnitude: 11.77,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.46460431),
        dec: Angle.Degrees(-17.84016941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -185.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159172"},
        {"Hipparcos Number", "HIP 85952"},
        {"Geneva Identification System", "GEN# +1.00159172"},
        {"Smithsonian Astrophysical Observation", "SAO 160642"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.49563634),
        dec: Angle.Degrees(-17.83625690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210094"},
        {"Hipparcos Number", "HIP 109271"},
        {"Geneva Identification System", "GEN# +1.00210094"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.06347598),
        dec: Angle.Degrees(-17.83578573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 163.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26591",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4254 F"},
        {"Henry Draper", "HD 37624"},
        {"Hipparcos Number", "HIP 26591"},
        {"Geneva Identification System", "GEN# +1.00037624"},
        {"Smithsonian Astrophysical Observation", "SAO 150650"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.78376513),
        dec: Angle.Degrees(-17.83134243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86782"},
        {"Hipparcos Number", "HIP 49042"},
        {"Smithsonian Astrophysical Observation", "SAO 155649"},
    },
    visualMagnitude: 8.69,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.09322096),
        dec: Angle.Degrees(-17.82985800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26605",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4254 E"},
        {"Hipparcos Number", "HIP 26605"},
        {"Smithsonian Astrophysical Observation", "SAO 150654"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.82074439),
        dec: Angle.Degrees(-17.82859389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31258"},
        {"Hipparcos Number", "HIP 22741"},
        {"Fundamental Katalog 5th Edition", "FK5 4449"},
        {"Geneva Identification System", "GEN# +1.00031258"},
        {"Smithsonian Astrophysical Observation", "SAO 149965"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.38407462),
        dec: Angle.Degrees(-17.82709999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159864"},
        {"Hipparcos Number", "HIP 86271"},
        {"Geneva Identification System", "GEN# +1.00159864"},
        {"Smithsonian Astrophysical Observation", "SAO 160702"},
        {"Wilson Evans Batten Catalogue", "WEB 14548"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.41291019),
        dec: Angle.Degrees(-17.82698631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29981"},
        {"Hipparcos Number", "HIP 21925"},
        {"Smithsonian Astrophysical Observation", "SAO 149840"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.71671826),
        dec: Angle.Degrees(-17.82683514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91528"},
        {"Hipparcos Number", "HIP 51704"},
        {"Geneva Identification System", "GEN# +1.00091528"},
        {"Smithsonian Astrophysical Observation", "SAO 156064"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.46478533),
        dec: Angle.Degrees(-17.82638046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -189.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117944",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17101 A"},
        {"Henry Draper", "HD 224135"},
        {"Hipparcos Number", "HIP 117944"},
        {"Smithsonian Astrophysical Observation", "SAO 165951"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.85658929),
        dec: Angle.Degrees(-17.82618673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 76.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2287",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 396 AB"},
        {"Henry Draper", "HD 2571"},
        {"Hipparcos Number", "HIP 2287"},
        {"Smithsonian Astrophysical Observation", "SAO 147301"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.30185335),
        dec: Angle.Degrees(-17.82515962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6427"},
        {"Hipparcos Number", "HIP 5076"},
        {"Geneva Identification System", "GEN# +1.00006427"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.23976983),
        dec: Angle.Degrees(-17.82430490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51010"},
        {"Hipparcos Number", "HIP 33234"},
    },
    visualMagnitude: 9.54,
    bvColour: -0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.72601076),
        dec: Angle.Degrees(-17.82395644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129295"},
        {"Hipparcos Number", "HIP 71892"},
        {"Geneva Identification System", "GEN# +1.00129295"},
        {"Smithsonian Astrophysical Observation", "SAO 158743"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.56668169),
        dec: Angle.Degrees(-17.82288602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30385"},
        {"Hipparcos Number", "HIP 22195"},
        {"Smithsonian Astrophysical Observation", "SAO 149874"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.61170812),
        dec: Angle.Degrees(-17.82277306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25985",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Arneb"},
        {"Aitken", "ADS 4146 A"},
        {"Henry Draper", "HD 36673"},
        {"Henry Draper 2", "HD 36673A"},
        {"Hipparcos Number", "HIP 25985"},
        {"Fundamental Katalog 5th Edition", "FK5 207"},
        {"Geneva Identification System", "GEN# +1.00036673"},
        {"Smithsonian Astrophysical Observation", "SAO 150547"},
        {"Wilson Evans Batten Catalogue", "WEB 5055"},
    },
    visualMagnitude: 2.58,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.18255798),
        dec: Angle.Degrees(-17.82229227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191596"},
        {"Hipparcos Number", "HIP 99468"},
        {"Smithsonian Astrophysical Observation", "SAO 163320"},
    },
    visualMagnitude: 9.45,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.81919925),
        dec: Angle.Degrees(-17.82224398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180515"},
        {"Hipparcos Number", "HIP 94811"},
        {"Smithsonian Astrophysical Observation", "SAO 162410"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.38112656),
        dec: Angle.Degrees(-17.82177937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16793"},
        {"Hipparcos Number", "HIP 12528"},
        {"Smithsonian Astrophysical Observation", "SAO 148544"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.30248132),
        dec: Angle.Degrees(-17.82133624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92079"},
        {"Hipparcos Number", "HIP 52018"},
        {"Smithsonian Astrophysical Observation", "SAO 156113"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.41365337),
        dec: Angle.Degrees(-17.82066111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152931"},
        {"Hipparcos Number", "HIP 82956"},
        {"Geneva Identification System", "GEN# +1.00152931"},
        {"Smithsonian Astrophysical Observation", "SAO 160183"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.28413335),
        dec: Angle.Degrees(-17.81912537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -144.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222574"},
        {"Hipparcos Number", "HIP 116901"},
        {"Geneva Identification System", "GEN# +1.00222574"},
        {"Smithsonian Astrophysical Observation", "SAO 165836"},
        {"Wilson Evans Batten Catalogue", "WEB 20622"},
    },
    visualMagnitude: 4.82,
    bvColour: 0.822,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.44082263),
        dec: Angle.Degrees(-17.81653327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29505"},
        {"Hipparcos Number", "HIP 21582"},
        {"Fundamental Katalog 5th Edition", "FK5 4416"},
        {"Smithsonian Astrophysical Observation", "SAO 149779"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.51779863),
        dec: Angle.Degrees(-17.81607786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39750",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39750"},
    },
    visualMagnitude: 11.74,
    bvColour: 1.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.86185674),
        dec: Angle.Degrees(-17.81451214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158420"},
        {"Hipparcos Number", "HIP 85632"},
        {"Geneva Identification System", "GEN# +1.00158420"},
        {"Smithsonian Astrophysical Observation", "SAO 160584"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.49333289),
        dec: Angle.Degrees(-17.81438022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7196"},
        {"Hipparcos Number", "HIP 5612"},
        {"Smithsonian Astrophysical Observation", "SAO 147666"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.99518410),
        dec: Angle.Degrees(-17.81407356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101027",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13887"},
        {"Henry Draper", "HD 194943"},
        {"Hipparcos Number", "HIP 101027"},
        {"Geneva Identification System", "GEN# +1.00194943J"},
        {"Smithsonian Astrophysical Observation", "SAO 163614"},
        {"Wilson Evans Batten Catalogue", "WEB 18245"},
    },
    visualMagnitude: 4.77,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.21509857),
        dec: Angle.Degrees(-17.81366828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19316"},
        {"Hipparcos Number", "HIP 14409"},
        {"Smithsonian Astrophysical Observation", "SAO 148762"},
    },
    visualMagnitude: 9.84,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.47087009),
        dec: Angle.Degrees(-17.81342682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205263"},
        {"Hipparcos Number", "HIP 106522"},
        {"Smithsonian Astrophysical Observation", "SAO 164489"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.63548768),
        dec: Angle.Degrees(-17.81330569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45889"},
        {"Hipparcos Number", "HIP 30918"},
        {"Smithsonian Astrophysical Observation", "SAO 151559"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.33883381),
        dec: Angle.Degrees(-17.81311991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209491"},
        {"Hipparcos Number", "HIP 108936"},
        {"Smithsonian Astrophysical Observation", "SAO 164841"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.04619283),
        dec: Angle.Degrees(-17.81243752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57844"},
        {"Hipparcos Number", "HIP 35741"},
        {"Geneva Identification System", "GEN# +1.00057844"},
        {"Smithsonian Astrophysical Observation", "SAO 152779"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.58568175),
        dec: Angle.Degrees(-17.81227590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221495"},
        {"Hipparcos Number", "HIP 116206"},
        {"Geneva Identification System", "GEN# +1.00221495"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.18213638),
        dec: Angle.Degrees(-17.81146362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113128",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113128"},
        {"Geneva Identification System", "GEN# -0.01806214"},
    },
    visualMagnitude: 10.33,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.64436018),
        dec: Angle.Degrees(-17.81111064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1980"},
        {"Hipparcos Number", "HIP 1899"},
        {"Geneva Identification System", "GEN# +1.00001980"},
        {"Smithsonian Astrophysical Observation", "SAO 147251"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.99792938),
        dec: Angle.Degrees(-17.81045389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31887"},
        {"Hipparcos Number", "HIP 23137"},
        {"Smithsonian Astrophysical Observation", "SAO 150045"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.68611200),
        dec: Angle.Degrees(-17.80687296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78998"},
        {"Hipparcos Number", "HIP 45070"},
        {"Geneva Identification System", "GEN# +1.00078998"},
        {"Smithsonian Astrophysical Observation", "SAO 154976"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.70061176),
        dec: Angle.Degrees(-17.80573421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140371"},
        {"Hipparcos Number", "HIP 77036"},
        {"Smithsonian Astrophysical Observation", "SAO 159463"},
    },
    visualMagnitude: 9.78,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.94847513),
        dec: Angle.Degrees(-17.80300536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177290"},
        {"Hipparcos Number", "HIP 93693"},
        {"Geneva Identification System", "GEN# +1.00177290"},
        {"Smithsonian Astrophysical Observation", "SAO 162160"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.19403796),
        dec: Angle.Degrees(-17.80163684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41241"},
        {"Hipparcos Number", "HIP 28655"},
        {"Smithsonian Astrophysical Observation", "SAO 151064"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.76719537),
        dec: Angle.Degrees(-17.80128609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96555"},
        {"Hipparcos Number", "HIP 54368"},
        {"Smithsonian Astrophysical Observation", "SAO 156475"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.85384589),
        dec: Angle.Degrees(-17.80097793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169990"},
        {"Hipparcos Number", "HIP 90494"},
        {"Geneva Identification System", "GEN# +1.00169990"},
        {"Smithsonian Astrophysical Observation", "SAO 161493"},
        {"Wilson Evans Batten Catalogue", "WEB 15499"},
    },
    visualMagnitude: 6.19,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.98533921),
        dec: Angle.Degrees(-17.80034975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214530"},
        {"Hipparcos Number", "HIP 111832"},
        {"Smithsonian Astrophysical Observation", "SAO 165216"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.77985944),
        dec: Angle.Degrees(-17.79854460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148746"},
        {"Hipparcos Number", "HIP 80881"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.72813910),
        dec: Angle.Degrees(-17.79784621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3402"},
        {"Hipparcos Number", "HIP 2895"},
        {"Smithsonian Astrophysical Observation", "SAO 147368"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.18210308),
        dec: Angle.Degrees(-17.79670280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196934"},
        {"Hipparcos Number", "HIP 102060"},
        {"Smithsonian Astrophysical Observation", "SAO 163790"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.24314313),
        dec: Angle.Degrees(-17.79569164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109273"},
        {"Hipparcos Number", "HIP 61308"},
        {"Smithsonian Astrophysical Observation", "SAO 157363"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.40960772),
        dec: Angle.Degrees(-17.79364951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 102.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7718",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1303 A"},
        {"Henry Draper", "HD 10186"},
        {"Hipparcos Number", "HIP 7718"},
        {"Geneva Identification System", "GEN# +1.00010186"},
        {"Renson", "Renson 2540"},
        {"Smithsonian Astrophysical Observation", "SAO 147935"},
        {"Wilson Evans Batten Catalogue", "WEB 1654"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.83790130),
        dec: Angle.Degrees(-17.79347893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125623"},
        {"Hipparcos Number", "HIP 70129"},
        {"Smithsonian Astrophysical Observation", "SAO 158502"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.25355980),
        dec: Angle.Degrees(-17.79312605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118984"},
        {"Hipparcos Number", "HIP 66749"},
        {"Geneva Identification System", "GEN# +1.00118984"},
        {"Smithsonian Astrophysical Observation", "SAO 158084"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.21144032),
        dec: Angle.Degrees(-17.79264643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222280"},
        {"Hipparcos Number", "HIP 116724"},
        {"Smithsonian Astrophysical Observation", "SAO 165814"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.83190197),
        dec: Angle.Degrees(-17.79129080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130989"},
        {"Hipparcos Number", "HIP 72677"},
        {"Geneva Identification System", "GEN# +1.00130989"},
        {"Smithsonian Astrophysical Observation", "SAO 158855"},
        {"Wilson Evans Batten Catalogue", "WEB 12495"},
    },
    visualMagnitude: 6.55,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.89568569),
        dec: Angle.Degrees(-17.79005507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -127.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220453"},
        {"Hipparcos Number", "HIP 115505"},
        {"Geneva Identification System", "GEN# +1.00220453"},
        {"Smithsonian Astrophysical Observation", "SAO 165670"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.96790078),
        dec: Angle.Degrees(-17.78947155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174400"},
        {"Hipparcos Number", "HIP 92493"},
        {"Smithsonian Astrophysical Observation", "SAO 161900"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.75336263),
        dec: Angle.Degrees(-17.78903263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196043"},
        {"Hipparcos Number", "HIP 101596"},
        {"Geneva Identification System", "GEN# +1.00196043"},
        {"Smithsonian Astrophysical Observation", "SAO 163707"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.85141336),
        dec: Angle.Degrees(-17.78813064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36828"},
        {"Hipparcos Number", "HIP 26073"},
        {"Smithsonian Astrophysical Observation", "SAO 150560"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.41482270),
        dec: Angle.Degrees(-17.78589599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222561"},
        {"Hipparcos Number", "HIP 116904"},
        {"Renson", "Renson 61020"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.44331034),
        dec: Angle.Degrees(-17.78346550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170655"},
        {"Hipparcos Number", "HIP 90788"},
        {"Smithsonian Astrophysical Observation", "SAO 161559"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.82817812),
        dec: Angle.Degrees(-17.78201293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92492",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92492"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.75008651),
        dec: Angle.Degrees(-17.78141964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17186"},
        {"Hipparcos Number", "HIP 12833"},
        {"Smithsonian Astrophysical Observation", "SAO 148581"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.24307358),
        dec: Angle.Degrees(-17.78114895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51850"},
        {"Hipparcos Number", "HIP 33541"},
        {"Smithsonian Astrophysical Observation", "SAO 152177"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.55811281),
        dec: Angle.Degrees(-17.77918355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13215"},
        {"Hipparcos Number", "HIP 9999"},
        {"Geneva Identification System", "GEN# +1.00013215"},
        {"Smithsonian Astrophysical Observation", "SAO 148237"},
    },
    visualMagnitude: 6.07,
    bvColour: 1.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.19028203),
        dec: Angle.Degrees(-17.77910445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110805"},
        {"Hipparcos Number", "HIP 62189"},
        {"Fundamental Katalog 5th Edition", "FK5 5128"},
        {"Smithsonian Astrophysical Observation", "SAO 157484"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.17852361),
        dec: Angle.Degrees(-17.77820719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141146"},
        {"Hipparcos Number", "HIP 77400"},
        {"Smithsonian Astrophysical Observation", "SAO 159502"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.01817872),
        dec: Angle.Degrees(-17.77513897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34513"},
        {"Hipparcos Number", "HIP 24649"},
        {"Geneva Identification System", "GEN# +1.00034513"},
        {"Smithsonian Astrophysical Observation", "SAO 150300"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.34292771),
        dec: Angle.Degrees(-17.77481377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157090"},
        {"Hipparcos Number", "HIP 84964"},
        {"Smithsonian Astrophysical Observation", "SAO 160494"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.48464505),
        dec: Angle.Degrees(-17.77467859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213652"},
        {"Hipparcos Number", "HIP 111333"},
        {"Smithsonian Astrophysical Observation", "SAO 165159"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.34182656),
        dec: Angle.Degrees(-17.77271228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22762",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22762"},
    },
    visualMagnitude: 10.90,
    bvColour: 1.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.45720690),
        dec: Angle.Degrees(-17.77185260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 408.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -644.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39854"},
        {"Hipparcos Number", "HIP 27917"},
        {"Smithsonian Astrophysical Observation", "SAO 150928"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.61777181),
        dec: Angle.Degrees(-17.77074419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99969"},
        {"Hipparcos Number", "HIP 56100"},
        {"Geneva Identification System", "GEN# +1.00099969"},
        {"Smithsonian Astrophysical Observation", "SAO 156713"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.49033723),
        dec: Angle.Degrees(-17.76918465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148198"},
        {"Hipparcos Number", "HIP 80570"},
        {"Geneva Identification System", "GEN# +1.00148198"},
        {"Smithsonian Astrophysical Observation", "SAO 159919"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.75689702),
        dec: Angle.Degrees(-17.76860590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135230"},
        {"Hipparcos Number", "HIP 74600"},
        {"Geneva Identification System", "GEN# +1.00135230"},
        {"Smithsonian Astrophysical Observation", "SAO 159122"},
        {"Wilson Evans Batten Catalogue", "WEB 12733"},
    },
    visualMagnitude: 6.18,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.64069691),
        dec: Angle.Degrees(-17.76853343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11123"},
        {"Hipparcos Number", "HIP 8455"},
        {"Smithsonian Astrophysical Observation", "SAO 148028"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.25581970),
        dec: Angle.Degrees(-17.76492192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138458"},
        {"Hipparcos Number", "HIP 76124"},
        {"Smithsonian Astrophysical Observation", "SAO 159334"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.812,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.21239828),
        dec: Angle.Degrees(-17.76449599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42927"},
        {"Hipparcos Number", "HIP 29488"},
        {"Geneva Identification System", "GEN# +1.00042927"},
        {"Smithsonian Astrophysical Observation", "SAO 151227"},
        {"Wilson Evans Batten Catalogue", "WEB 5798"},
    },
    visualMagnitude: 6.52,
    bvColour: -0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.19304708),
        dec: Angle.Degrees(-17.76324081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76994"},
        {"Hipparcos Number", "HIP 44113"},
        {"Smithsonian Astrophysical Observation", "SAO 154809"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.795,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.76575690),
        dec: Angle.Degrees(-17.76173241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177137"},
        {"Hipparcos Number", "HIP 93644"},
        {"Geneva Identification System", "GEN# +1.00177137"},
        {"Smithsonian Astrophysical Observation", "SAO 162153"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.03627823),
        dec: Angle.Degrees(-17.76068263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213281"},
        {"Hipparcos Number", "HIP 111122"},
        {"Smithsonian Astrophysical Observation", "SAO 165132"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.66161053),
        dec: Angle.Degrees(-17.76021300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58423",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8370 A"},
        {"Henry Draper", "HD 104028"},
        {"Hipparcos Number", "HIP 58423"},
        {"Smithsonian Astrophysical Observation", "SAO 157025"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.68932510),
        dec: Angle.Degrees(-17.75900012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -116.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66078",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8935 AB"},
        {"Henry Draper", "HD 117780"},
        {"Hipparcos Number", "HIP 66078"},
        {"Smithsonian Astrophysical Observation", "SAO 157996"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.19231776),
        dec: Angle.Degrees(-17.75896489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84792",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10465 AB"},
        {"Henry Draper", "HD 156717"},
        {"Hipparcos Number", "HIP 84792"},
        {"Geneva Identification System", "GEN# +1.00156717J"},
        {"Smithsonian Astrophysical Observation", "SAO 160462"},
    },
    visualMagnitude: 6.03,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.97230144),
        dec: Angle.Degrees(-17.75647881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69821",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9201 A"},
        {"Henry Draper", "HD 125046"},
        {"Hipparcos Number", "HIP 69821"},
        {"Smithsonian Astrophysical Observation", "SAO 158467"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.34366892),
        dec: Angle.Degrees(-17.75501227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143016"},
        {"Hipparcos Number", "HIP 78225"},
        {"Geneva Identification System", "GEN# +1.00143016"},
        {"Smithsonian Astrophysical Observation", "SAO 159611"},
        {"Wilson Evans Batten Catalogue", "WEB 13228"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.60240310),
        dec: Angle.Degrees(-17.75157790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -268.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -185.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168329"},
        {"Hipparcos Number", "HIP 89823"},
        {"Smithsonian Astrophysical Observation", "SAO 161338"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.95886675),
        dec: Angle.Degrees(-17.75079055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147778"},
        {"Hipparcos Number", "HIP 80378"},
        {"Smithsonian Astrophysical Observation", "SAO 159900"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.10831641),
        dec: Angle.Degrees(-17.74524197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13511"},
        {"Hipparcos Number", "HIP 10233"},
        {"Smithsonian Astrophysical Observation", "SAO 148264"},
    },
    visualMagnitude: 6.51,
    bvColour: 1.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.88946094),
        dec: Angle.Degrees(-17.74300337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150416"},
        {"Hipparcos Number", "HIP 81724"},
        {"Fundamental Katalog 5th Edition", "FK5 624"},
        {"Geneva Identification System", "GEN# +1.00150416"},
        {"Smithsonian Astrophysical Observation", "SAO 160046"},
        {"Wilson Evans Batten Catalogue", "WEB 13805"},
    },
    visualMagnitude: 4.91,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.39331786),
        dec: Angle.Degrees(-17.74216462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28892"},
        {"Hipparcos Number", "HIP 21181"},
        {"Smithsonian Astrophysical Observation", "SAO 149717"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.12070677),
        dec: Angle.Degrees(-17.74117468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3976"},
        {"Hipparcos Number", "HIP 3304"},
        {"Smithsonian Astrophysical Observation", "SAO 147405"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.53041412),
        dec: Angle.Degrees(-17.74065467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102859"},
        {"Hipparcos Number", "HIP 57744"},
        {"Smithsonian Astrophysical Observation", "SAO 156928"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.62144995),
        dec: Angle.Degrees(-17.74029149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -146.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27582"},
        {"Hipparcos Number", "HIP 20260"},
        {"Smithsonian Astrophysical Observation", "SAO 149557"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.14160404),
        dec: Angle.Degrees(-17.73992402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18475",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18475"},
        {"Smithsonian Astrophysical Observation", "SAO 149272"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.817,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.22156452),
        dec: Angle.Degrees(-17.73800819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 112.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19115"},
        {"Hipparcos Number", "HIP 14273"},
        {"Geneva Identification System", "GEN# +1.00019115"},
        {"Smithsonian Astrophysical Observation", "SAO 148743"},
        {"Wilson Evans Batten Catalogue", "WEB 2795"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.99967009),
        dec: Angle.Degrees(-17.73780619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123580"},
        {"Hipparcos Number", "HIP 69111"},
        {"Smithsonian Astrophysical Observation", "SAO 158381"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.21060516),
        dec: Angle.Degrees(-17.73628577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31571"},
        {"Hipparcos Number", "HIP 22944"},
        {"Smithsonian Astrophysical Observation", "SAO 150006"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.774,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.05250377),
        dec: Angle.Degrees(-17.73627174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116292"},
        {"Hipparcos Number", "HIP 65301"},
        {"Geneva Identification System", "GEN# +1.00116292"},
        {"Smithsonian Astrophysical Observation", "SAO 157899"},
        {"Wilson Evans Batten Catalogue", "WEB 11525"},
    },
    visualMagnitude: 5.36,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.75477211),
        dec: Angle.Degrees(-17.73520402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92134"},
        {"Hipparcos Number", "HIP 52035"},
        {"Geneva Identification System", "GEN# +1.00092134"},
        {"Smithsonian Astrophysical Observation", "SAO 156117"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.48035077),
        dec: Angle.Degrees(-17.73486112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121257"},
        {"Hipparcos Number", "HIP 67938"},
        {"Smithsonian Astrophysical Observation", "SAO 158227"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.70058866),
        dec: Angle.Degrees(-17.73398044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166165"},
        {"Hipparcos Number", "HIP 89025"},
        {"Smithsonian Astrophysical Observation", "SAO 161132"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.53989103),
        dec: Angle.Degrees(-17.73272409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92800"},
        {"Hipparcos Number", "HIP 52403"},
        {"Geneva Identification System", "GEN# +1.00092800"},
        {"Smithsonian Astrophysical Observation", "SAO 156172"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.66644388),
        dec: Angle.Degrees(-17.72923245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13568"},
        {"Hipparcos Number", "HIP 10263"},
        {"Smithsonian Astrophysical Observation", "SAO 148270"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.01682749),
        dec: Angle.Degrees(-17.72849560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50696",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50696"},
    },
    visualMagnitude: 11.23,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.28482307),
        dec: Angle.Degrees(-17.72749581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -455.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 99.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183089"},
        {"Hipparcos Number", "HIP 95746"},
        {"Smithsonian Astrophysical Observation", "SAO 162648"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.11433915),
        dec: Angle.Degrees(-17.72424307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109289"},
        {"Hipparcos Number", "HIP 61319"},
        {"Smithsonian Astrophysical Observation", "SAO 157364"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.851,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.44585910),
        dec: Angle.Degrees(-17.72201804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12010"},
        {"Hipparcos Number", "HIP 9123"},
        {"Smithsonian Astrophysical Observation", "SAO 148127"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.40231147),
        dec: Angle.Degrees(-17.72192769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37960"},
        {"Hipparcos Number", "HIP 26800"},
        {"Smithsonian Astrophysical Observation", "SAO 150699"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.37587068),
        dec: Angle.Degrees(-17.71527745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148860"},
        {"Hipparcos Number", "HIP 80940"},
        {"Geneva Identification System", "GEN# +1.00148860"},
        {"Smithsonian Astrophysical Observation", "SAO 159964"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.91130737),
        dec: Angle.Degrees(-17.71337966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46459"},
        {"Hipparcos Number", "HIP 31206"},
        {"Smithsonian Astrophysical Observation", "SAO 151629"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.19874041),
        dec: Angle.Degrees(-17.71005198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27399"},
        {"Hipparcos Number", "HIP 20114"},
        {"Smithsonian Astrophysical Observation", "SAO 149534"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.69489888),
        dec: Angle.Degrees(-17.70933131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155267"},
        {"Hipparcos Number", "HIP 84064"},
        {"Smithsonian Astrophysical Observation", "SAO 160344"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.79383120),
        dec: Angle.Degrees(-17.70883751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84423"},
        {"Hipparcos Number", "HIP 47817"},
        {"Smithsonian Astrophysical Observation", "SAO 155450"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.21487067),
        dec: Angle.Degrees(-17.70641289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101560"},
        {"Hipparcos Number", "HIP 57003"},
        {"Smithsonian Astrophysical Observation", "SAO 156832"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.29013399),
        dec: Angle.Degrees(-17.70523089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157201"},
        {"Hipparcos Number", "HIP 85018"},
        {"Geneva Identification System", "GEN# +1.00157201"},
        {"Smithsonian Astrophysical Observation", "SAO 160505"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.64729229),
        dec: Angle.Degrees(-17.70356190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9373"},
        {"Hipparcos Number", "HIP 7135"},
        {"Smithsonian Astrophysical Observation", "SAO 147864"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.98229916),
        dec: Angle.Degrees(-17.70141294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220477"},
        {"Hipparcos Number", "HIP 115526"},
        {"Smithsonian Astrophysical Observation", "SAO 165671"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.02117219),
        dec: Angle.Degrees(-17.70049691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1588"},
        {"Hipparcos Number", "HIP 1600"},
        {"Fundamental Katalog 5th Edition", "FK5 1007"},
        {"Geneva Identification System", "GEN# +1.00001588"},
        {"Smithsonian Astrophysical Observation", "SAO 147221"},
    },
    visualMagnitude: 6.73,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.01220748),
        dec: Angle.Degrees(-17.70041723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190455"},
        {"Hipparcos Number", "HIP 98970"},
        {"Smithsonian Astrophysical Observation", "SAO 163254"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.40377730),
        dec: Angle.Degrees(-17.70033900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24773"},
        {"Hipparcos Number", "HIP 18381"},
        {"Geneva Identification System", "GEN# +1.00024773"},
        {"Smithsonian Astrophysical Observation", "SAO 149259"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.93225428),
        dec: Angle.Degrees(-17.69897195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40409",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40409"},
        {"Smithsonian Astrophysical Observation", "SAO 154025"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.74120667),
        dec: Angle.Degrees(-17.69856388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21296"},
        {"Hipparcos Number", "HIP 15963"},
        {"Smithsonian Astrophysical Observation", "SAO 148955"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.39298814),
        dec: Angle.Degrees(-17.69846745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129942"},
        {"Hipparcos Number", "HIP 72186"},
        {"Smithsonian Astrophysical Observation", "SAO 158784"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.47072546),
        dec: Angle.Degrees(-17.69830644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54861"},
        {"Hipparcos Number", "HIP 34587"},
        {"Smithsonian Astrophysical Observation", "SAO 152486"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.46249452),
        dec: Angle.Degrees(-17.69594569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91032",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91032"},
        {"Geneva Identification System", "GEN# -0.01705238"},
        {"Smithsonian Astrophysical Observation", "SAO 161616"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.55170265),
        dec: Angle.Degrees(-17.69476961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217066"},
        {"Hipparcos Number", "HIP 113415"},
        {"Smithsonian Astrophysical Observation", "SAO 165410"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.53878256),
        dec: Angle.Degrees(-17.69328088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62702"},
        {"Hipparcos Number", "HIP 37772"},
        {"Smithsonian Astrophysical Observation", "SAO 153337"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.17980202),
        dec: Angle.Degrees(-17.69327019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123137"},
        {"Hipparcos Number", "HIP 68881"},
        {"Smithsonian Astrophysical Observation", "SAO 158348"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.792,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.56036607),
        dec: Angle.Degrees(-17.68851676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -236.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10312",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10312"},
        {"Geneva Identification System", "GEN# +6.10010088"},
        {"Geneva Identification System 2", "GEN# +9.85769090"},
    },
    visualMagnitude: 11.10,
    bvColour: 1.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.21128830),
        dec: Angle.Degrees(-17.68721593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 494.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 202.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9300"},
        {"Hipparcos Number", "HIP 7089"},
        {"Smithsonian Astrophysical Observation", "SAO 147855"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.82755808),
        dec: Angle.Degrees(-17.68552285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 172.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110108"},
        {"Hipparcos Number", "HIP 61804"},
        {"Smithsonian Astrophysical Observation", "SAO 157429"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.00046785),
        dec: Angle.Degrees(-17.68432572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55705",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8153 A"},
        {"Henry Draper", "HD 99211"},
        {"Hipparcos Number", "HIP 55705"},
        {"Fundamental Katalog 5th Edition", "FK5 431"},
        {"Geneva Identification System", "GEN# +1.00099211"},
        {"Smithsonian Astrophysical Observation", "SAO 156661"},
        {"Wilson Evans Batten Catalogue", "WEB 10012"},
    },
    visualMagnitude: 4.06,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.22076335),
        dec: Angle.Degrees(-17.68401748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30092",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4960 AB"},
        {"Henry Draper", "HD 44242"},
        {"Hipparcos Number", "HIP 30092"},
        {"Smithsonian Astrophysical Observation", "SAO 151366"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.99717170),
        dec: Angle.Degrees(-17.68362454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104627"},
        {"Hipparcos Number", "HIP 58745"},
        {"Smithsonian Astrophysical Observation", "SAO 157058"},
    },
    visualMagnitude: 9.45,
    bvColour: 1.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.72755664),
        dec: Angle.Degrees(-17.67956144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132280"},
        {"Hipparcos Number", "HIP 73290"},
        {"Smithsonian Astrophysical Observation", "SAO 158941"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.67485408),
        dec: Angle.Degrees(-17.67939907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1529"},
        {"Hipparcos Number", "HIP 1565"},
        {"Geneva Identification System", "GEN# +1.00001529"},
        {"Smithsonian Astrophysical Observation", "SAO 147216"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.818,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.87025008),
        dec: Angle.Degrees(-17.67889206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113610"},
        {"Hipparcos Number", "HIP 63840"},
        {"Geneva Identification System", "GEN# +1.00113610"},
        {"Smithsonian Astrophysical Observation", "SAO 157701"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.25880364),
        dec: Angle.Degrees(-17.67785525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168936"},
        {"Hipparcos Number", "HIP 90081"},
        {"Geneva Identification System", "GEN# +1.00168936"},
        {"Smithsonian Astrophysical Observation", "SAO 161408"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.75380571),
        dec: Angle.Degrees(-17.67703124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11985"},
        {"Hipparcos Number", "HIP 9105"},
        {"Smithsonian Astrophysical Observation", "SAO 148125"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.31710753),
        dec: Angle.Degrees(-17.67689393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114178"},
        {"Hipparcos Number", "HIP 64168"},
        {"Smithsonian Astrophysical Observation", "SAO 157752"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.26924684),
        dec: Angle.Degrees(-17.67649188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192153"},
        {"Hipparcos Number", "HIP 99710"},
        {"Geneva Identification System", "GEN# +1.00192153"},
        {"Smithsonian Astrophysical Observation", "SAO 163363"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.852,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.49845717),
        dec: Angle.Degrees(-17.67613222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183692"},
        {"Hipparcos Number", "HIP 96023"},
        {"Fundamental Katalog 5th Edition", "FK5 5719"},
        {"Smithsonian Astrophysical Observation", "SAO 162718"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.85590521),
        dec: Angle.Degrees(-17.67333893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54545"},
        {"Hipparcos Number", "HIP 34459"},
        {"Smithsonian Astrophysical Observation", "SAO 152452"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.14430994),
        dec: Angle.Degrees(-17.66923998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55343"},
        {"Hipparcos Number", "HIP 34765"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.95477069),
        dec: Angle.Degrees(-17.66637947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66783"},
        {"Hipparcos Number", "HIP 39513"},
        {"Smithsonian Astrophysical Observation", "SAO 153790"},
        {"Wilson Evans Batten Catalogue", "WEB 7724"},
    },
    visualMagnitude: 6.54,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.13547833),
        dec: Angle.Degrees(-17.66552575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139409"},
        {"Hipparcos Number", "HIP 76605"},
        {"Smithsonian Astrophysical Observation", "SAO 159409"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.67256559),
        dec: Angle.Degrees(-17.66478721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14728"},
        {"Hipparcos Number", "HIP 11033"},
        {"Fundamental Katalog 5th Edition", "FK5 1064"},
        {"Geneva Identification System", "GEN# +1.00014728"},
        {"Smithsonian Astrophysical Observation", "SAO 148356"},
        {"Wilson Evans Batten Catalogue", "WEB 2322"},
    },
    visualMagnitude: 5.89,
    bvColour: 1.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.52073828),
        dec: Angle.Degrees(-17.66202807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3144",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3144"},
        {"Smithsonian Astrophysical Observation", "SAO 147391"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.99359688),
        dec: Angle.Degrees(-17.66139958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160640"},
        {"Hipparcos Number", "HIP 86603"},
        {"Smithsonian Astrophysical Observation", "SAO 160754"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.46252861),
        dec: Angle.Degrees(-17.65946658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143375"},
        {"Hipparcos Number", "HIP 78426"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.15620362),
        dec: Angle.Degrees(-17.65748418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126616"},
        {"Hipparcos Number", "HIP 70644"},
        {"Smithsonian Astrophysical Observation", "SAO 158568"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.74451869),
        dec: Angle.Degrees(-17.65180725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5132"},
        {"Hipparcos Number", "HIP 4160"},
        {"Geneva Identification System", "GEN# +1.00005132"},
        {"Renson", "Renson 1360"},
        {"Smithsonian Astrophysical Observation", "SAO 147496"},
        {"Wilson Evans Batten Catalogue", "WEB 744"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.28243548),
        dec: Angle.Degrees(-17.65178787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8574",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8574"},
    },
    visualMagnitude: 9.92,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.64151829),
        dec: Angle.Degrees(-17.65006349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148999"},
        {"Hipparcos Number", "HIP 80998"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.811,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.13237888),
        dec: Angle.Degrees(-17.64905655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80083",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80083"},
        {"Cincinnati Publication", "Ci 20 980"},
    },
    visualMagnitude: 11.37,
    bvColour: 1.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.16994794),
        dec: Angle.Degrees(-17.64851714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -323.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -470.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63501",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63501"},
        {"Wilson Evans Batten Catalogue", "WEB 11240"},
    },
    visualMagnitude: 11.07,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.17187752),
        dec: Angle.Degrees(-17.64656793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20540"},
        {"Hipparcos Number", "HIP 15314"},
        {"Smithsonian Astrophysical Observation", "SAO 148885"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.39822172),
        dec: Angle.Degrees(-17.64525964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52806"},
        {"Hipparcos Number", "HIP 33881"},
        {"Fundamental Katalog 5th Edition", "FK5 4633"},
        {"Smithsonian Astrophysical Observation", "SAO 152260"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.48805241),
        dec: Angle.Degrees(-17.64427802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182455"},
        {"Hipparcos Number", "HIP 95484"},
        {"Smithsonian Astrophysical Observation", "SAO 162593"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.33822081),
        dec: Angle.Degrees(-17.64301888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88407"},
        {"Hipparcos Number", "HIP 49899"},
        {"Fundamental Katalog 5th Edition", "FK5 4907"},
        {"Geneva Identification System", "GEN# +1.00088407"},
        {"Smithsonian Astrophysical Observation", "SAO 155799"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.948,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.82297123),
        dec: Angle.Degrees(-17.63550536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54576"},
        {"Hipparcos Number", "HIP 34465"},
        {"Smithsonian Astrophysical Observation", "SAO 152454"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.15726253),
        dec: Angle.Degrees(-17.63473753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13044"},
        {"Hipparcos Number", "HIP 9896"},
        {"Smithsonian Astrophysical Observation", "SAO 148218"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.83309558),
        dec: Angle.Degrees(-17.63446093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133093"},
        {"Hipparcos Number", "HIP 73636"},
        {"Smithsonian Astrophysical Observation", "SAO 158992"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.77677364),
        dec: Angle.Degrees(-17.63285178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16252"},
        {"Hipparcos Number", "HIP 12102"},
        {"Geneva Identification System", "GEN# +1.00016252"},
        {"Smithsonian Astrophysical Observation", "SAO 148492"},
        {"Wilson Evans Batten Catalogue", "WEB 2491"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.98643195),
        dec: Angle.Degrees(-17.63266889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51981"},
        {"Hipparcos Number", "HIP 33596"},
        {"Celescope Catalog", "CEL 1471"},
        {"Geneva Identification System", "GEN# +1.00051981"},
        {"Smithsonian Astrophysical Observation", "SAO 152194"},
    },
    visualMagnitude: 8.23,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.69904711),
        dec: Angle.Degrees(-17.63214299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20090"},
        {"Hipparcos Number", "HIP 14986"},
        {"Smithsonian Astrophysical Observation", "SAO 148841"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.28860415),
        dec: Angle.Degrees(-17.63033116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34467",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 11.02,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)08, 38.8600),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)37, 49.100)
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
    primaryId: "HIP 68307",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68307"},
        {"Smithsonian Astrophysical Observation", "SAO 158272"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.73699539),
        dec: Angle.Degrees(-17.63013384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121867"},
        {"Hipparcos Number", "HIP 68268"},
        {"Smithsonian Astrophysical Observation", "SAO 158268"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.62619743),
        dec: Angle.Degrees(-17.62787206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63754",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8764 AB"},
        {"Henry Draper", "HD 113460"},
        {"Hipparcos Number", "HIP 63754"},
        {"Smithsonian Astrophysical Observation", "SAO 157692"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.807,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.01132206),
        dec: Angle.Degrees(-17.62456164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -146.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83572"},
        {"Hipparcos Number", "HIP 47363"},
        {"Geneva Identification System", "GEN# +1.00083572"},
        {"Smithsonian Astrophysical Observation", "SAO 155370"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.75054109),
        dec: Angle.Degrees(-17.62419027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95180"},
        {"Hipparcos Number", "HIP 53703"},
        {"Smithsonian Astrophysical Observation", "SAO 156368"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.81749181),
        dec: Angle.Degrees(-17.62321381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99006"},
        {"Hipparcos Number", "HIP 55607"},
        {"Smithsonian Astrophysical Observation", "SAO 156647"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.88169285),
        dec: Angle.Degrees(-17.62087683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214011"},
        {"Hipparcos Number", "HIP 111522"},
        {"Smithsonian Astrophysical Observation", "SAO 165177"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.91967037),
        dec: Angle.Degrees(-17.62007720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21816",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21816"},
        {"Smithsonian Astrophysical Observation", "SAO 149827"},
    },
    visualMagnitude: 10.12,
    bvColour: 1.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.32450168),
        dec: Angle.Degrees(-17.61946526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102736"},
        {"Hipparcos Number", "HIP 57665"},
        {"Smithsonian Astrophysical Observation", "SAO 156915"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.40896601),
        dec: Angle.Degrees(-17.61563692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9724",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9724"},
        {"Geneva Identification System", "GEN# -0.01800359"},
        {"Wilson Evans Batten Catalogue", "WEB 2043"},
    },
    visualMagnitude: 10.19,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.26683543),
        dec: Angle.Degrees(-17.61420901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1317.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -173.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26299"},
        {"Hipparcos Number", "HIP 19375"},
        {"Geneva Identification System", "GEN# +1.00026299"},
        {"Smithsonian Astrophysical Observation", "SAO 149406"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.25525965),
        dec: Angle.Degrees(-17.61325453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221484"},
        {"Hipparcos Number", "HIP 116200"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.15189161),
        dec: Angle.Degrees(-17.61238784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9486"},
        {"Hipparcos Number", "HIP 7212"},
        {"Smithsonian Astrophysical Observation", "SAO 147878"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.22463646),
        dec: Angle.Degrees(-17.61168944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90545"},
        {"Hipparcos Number", "HIP 51148"},
        {"Smithsonian Astrophysical Observation", "SAO 155989"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.73058696),
        dec: Angle.Degrees(-17.61100264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3354"},
        {"Hipparcos Number", "HIP 2861"},
        {"Geneva Identification System", "GEN# +1.00003354"},
        {"Smithsonian Astrophysical Observation", "SAO 147363"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.07019275),
        dec: Angle.Degrees(-17.61099686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86282"},
        {"Hipparcos Number", "HIP 48789"},
        {"Smithsonian Astrophysical Observation", "SAO 155614"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.26717539),
        dec: Angle.Degrees(-17.61077942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164738"},
        {"Hipparcos Number", "HIP 88439"},
        {"Smithsonian Astrophysical Observation", "SAO 161028"},
        {"Wilson Evans Batten Catalogue", "WEB 14955"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.84097870),
        dec: Angle.Degrees(-17.61008080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154779"},
        {"Hipparcos Number", "HIP 83854"},
        {"Fundamental Katalog 5th Edition", "FK5 1449"},
        {"Geneva Identification System", "GEN# +1.00154779"},
        {"Smithsonian Astrophysical Observation", "SAO 160305"},
        {"Wilson Evans Batten Catalogue", "WEB 14170"},
    },
    visualMagnitude: 5.98,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.06188469),
        dec: Angle.Degrees(-17.60896664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167433"},
        {"Hipparcos Number", "HIP 89511"},
        {"Geneva Identification System", "GEN# +1.00167433"},
        {"Smithsonian Astrophysical Observation", "SAO 161233"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.99124949),
        dec: Angle.Degrees(-17.60791362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35137"},
        {"Hipparcos Number", "HIP 25059"},
        {"Smithsonian Astrophysical Observation", "SAO 150379"},
    },
    visualMagnitude: 6.47,
    bvColour: 1.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.48044200),
        dec: Angle.Degrees(-17.60364666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215196"},
        {"Hipparcos Number", "HIP 112225"},
        {"Smithsonian Astrophysical Observation", "SAO 165253"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.94942564),
        dec: Angle.Degrees(-17.60056735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206144"},
        {"Hipparcos Number", "HIP 107027"},
        {"Geneva Identification System", "GEN# +1.00206144"},
        {"Smithsonian Astrophysical Observation", "SAO 164566"},
        {"Wilson Evans Batten Catalogue", "WEB 19335"},
    },
    visualMagnitude: 9.38,
    bvColour: -0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.13909362),
        dec: Angle.Degrees(-17.60013009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89760"},
        {"Hipparcos Number", "HIP 50701"},
        {"Smithsonian Astrophysical Observation", "SAO 155921"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.29443961),
        dec: Angle.Degrees(-17.59700797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73649",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73649"},
    },
    visualMagnitude: 11.77,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.82147279),
        dec: Angle.Degrees(-17.59521295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -272.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151192"},
        {"Hipparcos Number", "HIP 82120"},
        {"Geneva Identification System", "GEN# +1.00151192"},
        {"Smithsonian Astrophysical Observation", "SAO 160087"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.64244594),
        dec: Angle.Degrees(-17.59500386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 188.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212431"},
        {"Hipparcos Number", "HIP 110615"},
        {"Smithsonian Astrophysical Observation", "SAO 165047"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.14024994),
        dec: Angle.Degrees(-17.59309251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62735",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62735"},
    },
    visualMagnitude: 11.06,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.82747491),
        dec: Angle.Degrees(-17.58683938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -133.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70523"},
        {"Hipparcos Number", "HIP 40990"},
        {"Geneva Identification System", "GEN# +1.00070523"},
        {"Smithsonian Astrophysical Observation", "SAO 154159"},
        {"Wilson Evans Batten Catalogue", "WEB 7946"},
    },
    visualMagnitude: 5.71,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.47776027),
        dec: Angle.Degrees(-17.58630046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220064"},
        {"Hipparcos Number", "HIP 115287"},
        {"Smithsonian Astrophysical Observation", "SAO 165640"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.23670728),
        dec: Angle.Degrees(-17.58579911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32205"},
        {"Hipparcos Number", "HIP 23306"},
        {"Geneva Identification System", "GEN# +1.00032205"},
        {"Smithsonian Astrophysical Observation", "SAO 150077"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.18286185),
        dec: Angle.Degrees(-17.58507826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52986"},
        {"Hipparcos Number", "HIP 33951"},
        {"Celescope Catalog", "CEL 1525"},
        {"Geneva Identification System", "GEN# +1.00052986"},
        {"Smithsonian Astrophysical Observation", "SAO 152281"},
    },
    visualMagnitude: 7.45,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.67222858),
        dec: Angle.Degrees(-17.58148927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17194"},
        {"Hipparcos Number", "HIP 12839"},
        {"Geneva Identification System", "GEN# +1.00017194"},
        {"Smithsonian Astrophysical Observation", "SAO 148582"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.803,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.26199735),
        dec: Angle.Degrees(-17.58037440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208087"},
        {"Hipparcos Number", "HIP 108108"},
        {"Smithsonian Astrophysical Observation", "SAO 164731"},
    },
    visualMagnitude: 8.73,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.55150270),
        dec: Angle.Degrees(-17.57868148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215719"},
        {"Hipparcos Number", "HIP 112516"},
        {"Smithsonian Astrophysical Observation", "SAO 165291"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.86700773),
        dec: Angle.Degrees(-17.57838788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 402"},
        {"Hipparcos Number", "HIP 696"},
        {"Geneva Identification System", "GEN# +1.00000402"},
        {"Smithsonian Astrophysical Observation", "SAO 147103"},
    },
    visualMagnitude: 6.11,
    bvColour: 1.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.13953227),
        dec: Angle.Degrees(-17.57804019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141594"},
        {"Hipparcos Number", "HIP 77588"},
        {"Smithsonian Astrophysical Observation", "SAO 159526"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.61360925),
        dec: Angle.Degrees(-17.57695515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98267"},
        {"Hipparcos Number", "HIP 55199"},
        {"Smithsonian Astrophysical Observation", "SAO 156592"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.53427123),
        dec: Angle.Degrees(-17.57638951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138888"},
        {"Hipparcos Number", "HIP 76335"},
        {"Smithsonian Astrophysical Observation", "SAO 159369"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.88351757),
        dec: Angle.Degrees(-17.57379880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34704"},
        {"Hipparcos Number", "HIP 24781"},
        {"Geneva Identification System", "GEN# +1.00034704"},
        {"Smithsonian Astrophysical Observation", "SAO 150325"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.69299489),
        dec: Angle.Degrees(-17.57278101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101343"},
        {"Hipparcos Number", "HIP 56873"},
        {"Smithsonian Astrophysical Observation", "SAO 156817"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.824,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.90060952),
        dec: Angle.Degrees(-17.57112770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154921"},
        {"Hipparcos Number", "HIP 83920"},
        {"Smithsonian Astrophysical Observation", "SAO 160315"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.26879057),
        dec: Angle.Degrees(-17.56934080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92799"},
        {"Hipparcos Number", "HIP 52404"},
        {"Smithsonian Astrophysical Observation", "SAO 156173"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.66622682),
        dec: Angle.Degrees(-17.56889741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49865"},
        {"Hipparcos Number", "HIP 32750"},
        {"Smithsonian Astrophysical Observation", "SAO 151980"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.44659318),
        dec: Angle.Degrees(-17.56800300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2177"},
        {"Hipparcos Number", "HIP 2022"},
        {"Smithsonian Astrophysical Observation", "SAO 147267"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.41745277),
        dec: Angle.Degrees(-17.56772523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1433",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1433"},
        {"Smithsonian Astrophysical Observation", "SAO 147207"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.46848512),
        dec: Angle.Degrees(-17.56700423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9216"},
        {"Hipparcos Number", "HIP 7021"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.61683327),
        dec: Angle.Degrees(-17.56665789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202023"},
        {"Hipparcos Number", "HIP 104792"},
        {"Smithsonian Astrophysical Observation", "SAO 164228"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.44786182),
        dec: Angle.Degrees(-17.56577320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141028"},
        {"Hipparcos Number", "HIP 77343"},
    },
    visualMagnitude: 10.77,
    bvColour: 0.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.84313756),
        dec: Angle.Degrees(-17.56448314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127873"},
        {"Hipparcos Number", "HIP 71245"},
        {"Smithsonian Astrophysical Observation", "SAO 158646"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.55024003),
        dec: Angle.Degrees(-17.56331277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222002"},
        {"Hipparcos Number", "HIP 116532"},
        {"Smithsonian Astrophysical Observation", "SAO 165797"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.25790762),
        dec: Angle.Degrees(-17.56195520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218758"},
        {"Hipparcos Number", "HIP 114446"},
        {"Smithsonian Astrophysical Observation", "SAO 165533"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.66862085),
        dec: Angle.Degrees(-17.56124453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188407"},
        {"Hipparcos Number", "HIP 98054"},
        {"Geneva Identification System", "GEN# +1.00188407"},
        {"Smithsonian Astrophysical Observation", "SAO 163109"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.90593015),
        dec: Angle.Degrees(-17.56078111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147807"},
        {"Hipparcos Number", "HIP 80403"},
        {"Smithsonian Astrophysical Observation", "SAO 159903"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.17243607),
        dec: Angle.Degrees(-17.56075870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139363"},
        {"Hipparcos Number", "HIP 76572"},
        {"Smithsonian Astrophysical Observation", "SAO 159400"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.56865255),
        dec: Angle.Degrees(-17.56004363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51572"},
        {"Hipparcos Number", "HIP 33434"},
        {"Celescope Catalog", "CEL 1452"},
        {"Geneva Identification System", "GEN# +1.00051572"},
        {"Smithsonian Astrophysical Observation", "SAO 152155"},
    },
    visualMagnitude: 7.88,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.28735896),
        dec: Angle.Degrees(-17.55999878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 747"},
        {"Hipparcos Number", "HIP 955"},
        {"Smithsonian Astrophysical Observation", "SAO 147138"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.95060084),
        dec: Angle.Degrees(-17.55770035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32287"},
        {"Hipparcos Number", "HIP 23350"},
        {"Geneva Identification System", "GEN# +1.00032287"},
        {"Smithsonian Astrophysical Observation", "SAO 150082"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.32879209),
        dec: Angle.Degrees(-17.55769630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17449"},
        {"Hipparcos Number", "HIP 13025"},
        {"Smithsonian Astrophysical Observation", "SAO 148607"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.85685012),
        dec: Angle.Degrees(-17.55628726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13214"},
        {"Hipparcos Number", "HIP 9998"},
        {"Smithsonian Astrophysical Observation", "SAO 148236"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.18987863),
        dec: Angle.Degrees(-17.55355653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39482"},
        {"Hipparcos Number", "HIP 27720"},
        {"Geneva Identification System", "GEN# +1.00039482"},
        {"Smithsonian Astrophysical Observation", "SAO 150887"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.789,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.04769939),
        dec: Angle.Degrees(-17.55326214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 98.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98625",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 8.20,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)01, 52.5600),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)33, 11.300)
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
    primaryId: "HIP 112512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215709"},
        {"Hipparcos Number", "HIP 112512"},
        {"Geneva Identification System", "GEN# +1.00215709"},
        {"Smithsonian Astrophysical Observation", "SAO 165290"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.85462562),
        dec: Angle.Degrees(-17.55075410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10237"},
        {"Hipparcos Number", "HIP 7749"},
        {"Smithsonian Astrophysical Observation", "SAO 147940"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.94163946),
        dec: Angle.Degrees(-17.55030995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189679"},
        {"Hipparcos Number", "HIP 98623"},
        {"Smithsonian Astrophysical Observation", "SAO 163192"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.46575662),
        dec: Angle.Degrees(-17.55007854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73262",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73262"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.898,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.59201413),
        dec: Angle.Degrees(-17.54917550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -373.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60700"},
        {"Hipparcos Number", "HIP 36901"},
        {"Geneva Identification System", "GEN# +1.00060700"},
        {"Smithsonian Astrophysical Observation", "SAO 153099"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.80115081),
        dec: Angle.Degrees(-17.54854349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 148.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17545"},
        {"Hipparcos Number", "HIP 13091"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.07416444),
        dec: Angle.Degrees(-17.54815918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27904"},
        {"Hipparcos Number", "HIP 20499"},
        {"Smithsonian Astrophysical Observation", "SAO 149600"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.878,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.90016752),
        dec: Angle.Degrees(-17.54788716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4678"},
        {"Hipparcos Number", "HIP 3792"},
        {"Smithsonian Astrophysical Observation", "SAO 147459"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.18295418),
        dec: Angle.Degrees(-17.54708857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172965"},
        {"Hipparcos Number", "HIP 91865"},
        {"Smithsonian Astrophysical Observation", "SAO 161767"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.92866077),
        dec: Angle.Degrees(-17.54553474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 955"},
        {"Hipparcos Number", "HIP 1115"},
        {"Geneva Identification System", "GEN# +1.00000955"},
        {"Wilson Evans Batten Catalogue", "WEB 194"},
    },
    visualMagnitude: 7.39,
    bvColour: -0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.48163510),
        dec: Angle.Degrees(-17.54538026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173375"},
        {"Hipparcos Number", "HIP 92038"},
        {"Geneva Identification System", "GEN# +1.00173375"},
        {"Smithsonian Astrophysical Observation", "SAO 161794"},
        {"Wilson Evans Batten Catalogue", "WEB 15857"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.40439312),
        dec: Angle.Degrees(-17.54480116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50495",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50495"},
        {"Smithsonian Astrophysical Observation", "SAO 155886"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.66496051),
        dec: Angle.Degrees(-17.54265514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59803",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Gienah"},
        {"Henry Draper", "HD 106625"},
        {"Hipparcos Number", "HIP 59803"},
        {"Fundamental Katalog 5th Edition", "FK5 457"},
        {"Geneva Identification System", "GEN# +1.00106625"},
        {"Renson", "Renson 30850"},
        {"Smithsonian Astrophysical Observation", "SAO 157176"},
        {"Wilson Evans Batten Catalogue", "WEB 10626"},
    },
    visualMagnitude: 2.58,
    bvColour: -0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.95194937),
        dec: Angle.Degrees(-17.54198370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -159.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218650"},
        {"Hipparcos Number", "HIP 114372"},
        {"Smithsonian Astrophysical Observation", "SAO 165523"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.46589048),
        dec: Angle.Degrees(-17.54112088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171185"},
        {"Hipparcos Number", "HIP 91018"},
        {"Geneva Identification System", "GEN# +1.00171185"},
        {"Smithsonian Astrophysical Observation", "SAO 161610"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.50863901),
        dec: Angle.Degrees(-17.53984407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7809"},
        {"Hipparcos Number", "HIP 6032"},
        {"Smithsonian Astrophysical Observation", "SAO 147720"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.37158328),
        dec: Angle.Degrees(-17.53851990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105704"},
        {"Hipparcos Number", "HIP 59313"},
        {"Geneva Identification System", "GEN# +1.00105704"},
        {"Smithsonian Astrophysical Observation", "SAO 157120"},
    },
    visualMagnitude: 6.63,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.52434400),
        dec: Angle.Degrees(-17.53728101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89271"},
        {"Hipparcos Number", "HIP 50413"},
        {"Smithsonian Astrophysical Observation", "SAO 155875"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.40569018),
        dec: Angle.Degrees(-17.53679680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178340"},
        {"Hipparcos Number", "HIP 94061"},
        {"Smithsonian Astrophysical Observation", "SAO 162240"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.757,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.23701857),
        dec: Angle.Degrees(-17.53545002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -146.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48219"},
        {"Hipparcos Number", "HIP 32039"},
        {"Smithsonian Astrophysical Observation", "SAO 151797"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.39160777),
        dec: Angle.Degrees(-17.53361113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59570"},
        {"Hipparcos Number", "HIP 36436"},
        {"Smithsonian Astrophysical Observation", "SAO 152965"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.47516149),
        dec: Angle.Degrees(-17.53260268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9401"},
        {"Hipparcos Number", "HIP 7150"},
        {"Geneva Identification System", "GEN# +1.00009401"},
        {"Smithsonian Astrophysical Observation", "SAO 147867"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.04084424),
        dec: Angle.Degrees(-17.53206686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9847"},
        {"Hipparcos Number", "HIP 7446"},
        {"Cincinnati Publication", "Ci 18 216"},
        {"Geneva Identification System", "GEN# +1.00009847"},
        {"Smithsonian Astrophysical Observation", "SAO 147900"},
        {"Wilson Evans Batten Catalogue", "WEB 1594"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.712,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.97042741),
        dec: Angle.Degrees(-17.53197680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 277.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -201.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199947"},
        {"Hipparcos Number", "HIP 103703"},
        {"Smithsonian Astrophysical Observation", "SAO 164061"},
        {"Wilson Evans Batten Catalogue", "WEB 18876"},
    },
    visualMagnitude: 6.07,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.21576821),
        dec: Angle.Degrees(-17.53085532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38054"},
        {"Hipparcos Number", "HIP 26866"},
        {"Geneva Identification System", "GEN# +1.00038054"},
        {"Smithsonian Astrophysical Observation", "SAO 150716"},
    },
    visualMagnitude: 6.15,
    bvColour: 1.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.56036023),
        dec: Angle.Degrees(-17.53038891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16471"},
        {"Hipparcos Number", "HIP 12275"},
        {"Smithsonian Astrophysical Observation", "SAO 148515"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.52869568),
        dec: Angle.Degrees(-17.53009234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41590",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6832 B"},
        {"Henry Draper", "HD 71798"},
        {"Hipparcos Number", "HIP 41590"},
        {"Smithsonian Astrophysical Observation", "SAO 154298"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.18358221),
        dec: Angle.Degrees(-17.52937457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125550"},
        {"Hipparcos Number", "HIP 70078"},
        {"Smithsonian Astrophysical Observation", "SAO 158498"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.11496737),
        dec: Angle.Degrees(-17.52840991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222477"},
        {"Hipparcos Number", "HIP 116846"},
        {"Smithsonian Astrophysical Observation", "SAO 165827"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.26849638),
        dec: Angle.Degrees(-17.52729337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44182"},
        {"Hipparcos Number", "HIP 30071"},
        {"Celescope Catalog", "CEL 1181"},
        {"Geneva Identification System", "GEN# +1.00044182"},
        {"Smithsonian Astrophysical Observation", "SAO 151357"},
    },
    visualMagnitude: 7.25,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.92174320),
        dec: Angle.Degrees(-17.52621354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5421"},
        {"Hipparcos Number", "HIP 4359"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.96875681),
        dec: Angle.Degrees(-17.52573307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41589",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6832 A"},
        {"Hipparcos Number", "HIP 41589"},
        {"Smithsonian Astrophysical Observation", "SAO 154297"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.18308223),
        dec: Angle.Degrees(-17.52521571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57139"},
        {"Hipparcos Number", "HIP 35468"},
        {"Celescope Catalog", "CEL 1774"},
        {"Geneva Identification System", "GEN# +1.00057139"},
        {"Smithsonian Astrophysical Observation", "SAO 152723"},
    },
    visualMagnitude: 6.70,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.82673611),
        dec: Angle.Degrees(-17.52487866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23813"},
        {"Hipparcos Number", "HIP 17705"},
        {"Smithsonian Astrophysical Observation", "SAO 149173"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.87689110),
        dec: Angle.Degrees(-17.52390819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164619"},
        {"Hipparcos Number", "HIP 88368"},
        {"Geneva Identification System", "GEN# +1.00164619"},
        {"Smithsonian Astrophysical Observation", "SAO 161021"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.67624094),
        dec: Angle.Degrees(-17.52239646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20827"},
        {"Hipparcos Number", "HIP 15580"},
        {"Smithsonian Astrophysical Observation", "SAO 148911"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.18084730),
        dec: Angle.Degrees(-17.52136022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154147"},
        {"Hipparcos Number", "HIP 83544"},
        {"Geneva Identification System", "GEN# +1.00154147"},
        {"Smithsonian Astrophysical Observation", "SAO 160257"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.12238813),
        dec: Angle.Degrees(-17.49197535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108711",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15544 AB"},
        {"Henry Draper", "HD 209108"},
        {"Hipparcos Number", "HIP 108711"},
        {"Smithsonian Astrophysical Observation", "SAO 164816"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.32769299),
        dec: Angle.Degrees(-17.51656171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203429"},
        {"Hipparcos Number", "HIP 105546"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.841,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.64660220),
        dec: Angle.Degrees(-17.51602557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -231.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81899",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81899"},
        {"Smithsonian Astrophysical Observation", "SAO 160063"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.93076407),
        dec: Angle.Degrees(-17.51491045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135152"},
        {"Hipparcos Number", "HIP 74568"},
        {"Smithsonian Astrophysical Observation", "SAO 159115"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.53997838),
        dec: Angle.Degrees(-17.51462469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 78.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12685"},
        {"Hipparcos Number", "HIP 9639"},
        {"Smithsonian Astrophysical Observation", "SAO 148178"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.97452618),
        dec: Angle.Degrees(-17.51361926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131070"},
        {"Hipparcos Number", "HIP 72717"},
        {"Smithsonian Astrophysical Observation", "SAO 158862"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.00845381),
        dec: Angle.Degrees(-17.50992586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49415"},
        {"Hipparcos Number", "HIP 32557"},
        {"Celescope Catalog", "CEL 1387"},
        {"Geneva Identification System", "GEN# +1.00049415"},
        {"Smithsonian Astrophysical Observation", "SAO 151935"},
    },
    visualMagnitude: 7.05,
    bvColour: -0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.90132563),
        dec: Angle.Degrees(-17.50857082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43630"},
        {"Hipparcos Number", "HIP 29805"},
        {"Smithsonian Astrophysical Observation", "SAO 151302"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.13160170),
        dec: Angle.Degrees(-17.50631925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82093"},
        {"Hipparcos Number", "HIP 46533"},
        {"Geneva Identification System", "GEN# +1.00082093"},
        {"Renson", "Renson 23340"},
        {"Smithsonian Astrophysical Observation", "SAO 155233"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.36134452),
        dec: Angle.Degrees(-17.50529764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26361"},
        {"Hipparcos Number", "HIP 19421"},
        {"Geneva Identification System", "GEN# +1.00026361"},
        {"Smithsonian Astrophysical Observation", "SAO 149417"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.39171171),
        dec: Angle.Degrees(-17.50252215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213612"},
        {"Hipparcos Number", "HIP 111312"},
        {"Geneva Identification System", "GEN# +1.00213612"},
        {"Smithsonian Astrophysical Observation", "SAO 165156"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.827,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.25621349),
        dec: Angle.Degrees(-17.50138537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -189.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81060"},
        {"Hipparcos Number", "HIP 46004"},
        {"Smithsonian Astrophysical Observation", "SAO 155137"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.73517871),
        dec: Angle.Degrees(-17.49681327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105375"},
        {"Hipparcos Number", "HIP 59163"},
        {"Smithsonian Astrophysical Observation", "SAO 157097"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.99791841),
        dec: Angle.Degrees(-17.49660288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77735"},
        {"Hipparcos Number", "HIP 44478"},
        {"Smithsonian Astrophysical Observation", "SAO 154871"},
    },
    visualMagnitude: 6.58,
    bvColour: 1.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.93752591),
        dec: Angle.Degrees(-17.49656890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159011"},
        {"Hipparcos Number", "HIP 85875"},
        {"Smithsonian Astrophysical Observation", "SAO 160629"},
    },
    visualMagnitude: 6.81,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.24579742),
        dec: Angle.Degrees(-17.49597465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73322"},
        {"Hipparcos Number", "HIP 42281"},
        {"Geneva Identification System", "GEN# +1.00073322"},
        {"Smithsonian Astrophysical Observation", "SAO 154462"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.31503892),
        dec: Angle.Degrees(-17.49479172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -114.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186478"},
        {"Hipparcos Number", "HIP 97192"},
        {"Geneva Identification System", "GEN# +1.00186478"},
        {"Smithsonian Astrophysical Observation", "SAO 162947"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.30897739),
        dec: Angle.Degrees(-17.49064607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193227"},
        {"Hipparcos Number", "HIP 100231"},
        {"Smithsonian Astrophysical Observation", "SAO 163450"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.92935972),
        dec: Angle.Degrees(-17.48802901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94045"},
        {"Hipparcos Number", "HIP 53040"},
        {"Smithsonian Astrophysical Observation", "SAO 156272"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.933,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.78941414),
        dec: Angle.Degrees(-17.48664320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35088",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35088"},
    },
    visualMagnitude: 11.90,
    bvColour: 2.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.84558359),
        dec: Angle.Degrees(-17.48557258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5745"},
        {"Hipparcos Number", "HIP 4595"},
        {"Geneva Identification System", "GEN# +1.00005745"},
        {"Smithsonian Astrophysical Observation", "SAO 147553"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.70736058),
        dec: Angle.Degrees(-17.48480079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87809"},
        {"Hipparcos Number", "HIP 49556"},
        {"Geneva Identification System", "GEN# +1.00087809"},
        {"Smithsonian Astrophysical Observation", "SAO 155738"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.77366552),
        dec: Angle.Degrees(-17.48442888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7553",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7553"},
    },
    visualMagnitude: 9.81,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.32865368),
        dec: Angle.Degrees(-17.48435671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176328"},
        {"Hipparcos Number", "HIP 93319"},
        {"Geneva Identification System", "GEN# +1.00176328"},
        {"Smithsonian Astrophysical Observation", "SAO 162076"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.10686536),
        dec: Angle.Degrees(-17.48434830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162740"},
        {"Hipparcos Number", "HIP 87561"},
        {"Geneva Identification System", "GEN# +1.00162740"},
        {"Smithsonian Astrophysical Observation", "SAO 160886"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.32134598),
        dec: Angle.Degrees(-17.48363874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10958"},
        {"Hipparcos Number", "HIP 8318"},
        {"Smithsonian Astrophysical Observation", "SAO 148011"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.81579946),
        dec: Angle.Degrees(-17.48351001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125612"},
        {"Henry Draper 2", "HD 125612A"},
        {"Hipparcos Number", "HIP 70123"},
        {"Geneva Identification System", "GEN# +1.00125612"},
        {"Smithsonian Astrophysical Observation", "SAO 158501"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.22314214),
        dec: Angle.Degrees(-17.48136135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186968"},
        {"Hipparcos Number", "HIP 97419"},
        {"Geneva Identification System", "GEN# +1.00186968"},
        {"Smithsonian Astrophysical Observation", "SAO 162995"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.00148477),
        dec: Angle.Degrees(-17.47991434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29601",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4847 AB"},
        {"Henry Draper", "HD 43218"},
        {"Hipparcos Number", "HIP 29601"},
        {"Smithsonian Astrophysical Observation", "SAO 151254"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.57350008),
        dec: Angle.Degrees(-17.47984854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26360"},
        {"Hipparcos Number", "HIP 19414"},
        {"Geneva Identification System", "GEN# +1.00026360"},
        {"Smithsonian Astrophysical Observation", "SAO 149415"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.36732842),
        dec: Angle.Degrees(-17.47869178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148437"},
        {"Hipparcos Number", "HIP 80711"},
        {"Smithsonian Astrophysical Observation", "SAO 159933"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.18575869),
        dec: Angle.Degrees(-17.47750773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19404"},
        {"Hipparcos Number", "HIP 14460"},
        {"Geneva Identification System", "GEN# +1.00019404"},
        {"Smithsonian Astrophysical Observation", "SAO 148773"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.65689456),
        dec: Angle.Degrees(-17.47590014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201531"},
        {"Hipparcos Number", "HIP 104553"},
        {"Smithsonian Astrophysical Observation", "SAO 164194"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.68250834),
        dec: Angle.Degrees(-17.47561199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193743"},
        {"Hipparcos Number", "HIP 100471"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.61580714),
        dec: Angle.Degrees(-17.47547046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46909",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46909"},
    },
    visualMagnitude: 10.48,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.40574163),
        dec: Angle.Degrees(-17.47400826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 150.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6411"},
        {"Hipparcos Number", "HIP 5065"},
        {"Geneva Identification System", "GEN# +1.00006411"},
        {"Smithsonian Astrophysical Observation", "SAO 147596"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.20415250),
        dec: Angle.Degrees(-17.47380427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104551",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104551"},
    },
    visualMagnitude: 12.74,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.67693711),
        dec: Angle.Degrees(-17.47351734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26797"},
        {"Hipparcos Number", "HIP 19728"},
        {"Fundamental Katalog 5th Edition", "FK5 4385"},
        {"Geneva Identification System", "GEN# +1.00026797"},
        {"Smithsonian Astrophysical Observation", "SAO 149468"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.42847996),
        dec: Angle.Degrees(-17.47304675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161155"},
        {"Hipparcos Number", "HIP 86837"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.15448104),
        dec: Angle.Degrees(-17.47286781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115122"},
        {"Hipparcos Number", "HIP 64672"},
        {"Geneva Identification System", "GEN# +1.00115122"},
        {"Smithsonian Astrophysical Observation", "SAO 157818"},
        {"Wilson Evans Batten Catalogue", "WEB 11436"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.83652573),
        dec: Angle.Degrees(-17.47131660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86030"},
        {"Hipparcos Number", "HIP 48672"},
        {"Smithsonian Astrophysical Observation", "SAO 155595"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.89746450),
        dec: Angle.Degrees(-17.46943789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24671"},
        {"Hipparcos Number", "HIP 18301"},
        {"Smithsonian Astrophysical Observation", "SAO 149247"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.69582433),
        dec: Angle.Degrees(-17.46907055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200329"},
        {"Hipparcos Number", "HIP 103920"},
        {"Smithsonian Astrophysical Observation", "SAO 164100"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.83356680),
        dec: Angle.Degrees(-17.46868136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22470"},
        {"Hipparcos Number", "HIP 16803"},
        {"Fundamental Katalog 5th Edition", "FK5 1100"},
        {"Geneva Identification System", "GEN# +1.00022470"},
        {"Renson", "Renson 5710"},
        {"Smithsonian Astrophysical Observation", "SAO 149063"},
        {"Wilson Evans Batten Catalogue", "WEB 3198"},
    },
    visualMagnitude: 5.24,
    bvColour: -0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.07246744),
        dec: Angle.Degrees(-17.46704107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199750"},
        {"Hipparcos Number", "HIP 103618"},
        {"Smithsonian Astrophysical Observation", "SAO 164044"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.91082135),
        dec: Angle.Degrees(-17.46659933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155790"},
        {"Hipparcos Number", "HIP 84326"},
        {"Geneva Identification System", "GEN# +1.00155790"},
        {"Smithsonian Astrophysical Observation", "SAO 160393"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.59033105),
        dec: Angle.Degrees(-17.46603652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45765"},
        {"Hipparcos Number", "HIP 30836"},
        {"Geneva Identification System", "GEN# +1.00045765"},
        {"Smithsonian Astrophysical Observation", "SAO 151546"},
    },
    visualMagnitude: 5.76,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.15587229),
        dec: Angle.Degrees(-17.46603282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72174"},
        {"Hipparcos Number", "HIP 41752"},
        {"Smithsonian Astrophysical Observation", "SAO 154338"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.70717633),
        dec: Angle.Degrees(-17.46432689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27508"},
        {"Hipparcos Number", "HIP 20210"},
        {"Smithsonian Astrophysical Observation", "SAO 149547"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.97221759),
        dec: Angle.Degrees(-17.46411106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124461"},
        {"Hipparcos Number", "HIP 69548"},
        {"Smithsonian Astrophysical Observation", "SAO 158443"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.54858906),
        dec: Angle.Degrees(-17.46348211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202723"},
        {"Hipparcos Number", "HIP 105168"},
        {"Geneva Identification System", "GEN# +1.00202723"},
        {"Smithsonian Astrophysical Observation", "SAO 164289"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.56515251),
        dec: Angle.Degrees(-17.46227233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214028"},
        {"Hipparcos Number", "HIP 111539"},
        {"Fundamental Katalog 5th Edition", "FK5 3810"},
        {"Smithsonian Astrophysical Observation", "SAO 165178"},
        {"Wilson Evans Batten Catalogue", "WEB 19937"},
    },
    visualMagnitude: 6.39,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.95342640),
        dec: Angle.Degrees(-17.46031368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149734"},
        {"Hipparcos Number", "HIP 81393"},
        {"Smithsonian Astrophysical Observation", "SAO 160008"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.744,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.34608412),
        dec: Angle.Degrees(-17.46022802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123194"},
        {"Hipparcos Number", "HIP 68918"},
        {"Smithsonian Astrophysical Observation", "SAO 158354"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.63849050),
        dec: Angle.Degrees(-17.45617800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201057"},
        {"Hipparcos Number", "HIP 104297"},
        {"Geneva Identification System", "GEN# +1.00201057"},
        {"Smithsonian Astrophysical Observation", "SAO 164156"},
    },
    visualMagnitude: 6.18,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.93615261),
        dec: Angle.Degrees(-17.45578844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24271",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24271"},
        {"Fundamental Katalog 5th Edition", "FK5 4475"},
        {"Smithsonian Astrophysical Observation", "SAO 150229"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.13756632),
        dec: Angle.Degrees(-17.45457980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33857"},
        {"Hipparcos Number", "HIP 24268"},
        {"Smithsonian Astrophysical Observation", "SAO 150227"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.12388167),
        dec: Angle.Degrees(-17.45247943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70472",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70472"},
    },
    visualMagnitude: 10.71,
    bvColour: 1.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.20886448),
        dec: Angle.Degrees(-17.45244379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -436.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 80.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94838"},
        {"Hipparcos Number", "HIP 53509"},
        {"Geneva Identification System", "GEN# +1.00094838"},
        {"Smithsonian Astrophysical Observation", "SAO 156344"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.19089802),
        dec: Angle.Degrees(-17.45189237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -129.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14972"},
        {"Hipparcos Number", "HIP 11221"},
        {"Smithsonian Astrophysical Observation", "SAO 148376"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.10630024),
        dec: Angle.Degrees(-17.45075076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128888"},
        {"Hipparcos Number", "HIP 71699"},
        {"Smithsonian Astrophysical Observation", "SAO 158713"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.99947452),
        dec: Angle.Degrees(-17.45041129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27194"},
        {"Hipparcos Number", "HIP 19984"},
        {"Smithsonian Astrophysical Observation", "SAO 149511"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.29015296),
        dec: Angle.Degrees(-17.44903134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218679"},
        {"Hipparcos Number", "HIP 114396"},
        {"Smithsonian Astrophysical Observation", "SAO 165528"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.52391574),
        dec: Angle.Degrees(-17.44716725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160164"},
        {"Hipparcos Number", "HIP 86383"},
        {"Fundamental Katalog 5th Edition", "FK5 5548"},
        {"Geneva Identification System", "GEN# +1.00160164"},
        {"Smithsonian Astrophysical Observation", "SAO 160719"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.77201879),
        dec: Angle.Degrees(-17.44639774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87768"},
        {"Hipparcos Number", "HIP 49541"},
        {"Geneva Identification System", "GEN# +9.00050002"},
        {"Smithsonian Astrophysical Observation", "SAO 155734"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.72444163),
        dec: Angle.Degrees(-17.44418872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29302"},
        {"Hipparcos Number", "HIP 21445"},
        {"Geneva Identification System", "GEN# +1.00029302"},
        {"Smithsonian Astrophysical Observation", "SAO 149757"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.08015166),
        dec: Angle.Degrees(-17.44411207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175583"},
        {"Hipparcos Number", "HIP 92996"},
        {"Smithsonian Astrophysical Observation", "SAO 162010"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.18536824),
        dec: Angle.Degrees(-17.44408837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4299",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 771 AB"},
        {"Henry Draper", "HD 5339"},
        {"Hipparcos Number", "HIP 4299"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.77440096),
        dec: Angle.Degrees(-17.44283229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10437",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10437"},
        {"Smithsonian Astrophysical Observation", "SAO 148285"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.61903251),
        dec: Angle.Degrees(-17.44148292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137949"},
        {"Hipparcos Number", "HIP 75848"},
        {"Geneva Identification System", "GEN# +1.00137949"},
        {"Renson", "Renson 39240"},
        {"Smithsonian Astrophysical Observation", "SAO 159292"},
        {"Wilson Evans Batten Catalogue", "WEB 12909"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.39493321),
        dec: Angle.Degrees(-17.44095597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21066"},
        {"Hipparcos Number", "HIP 15775"},
        {"Fundamental Katalog 5th Edition", "FK5 2238"},
        {"Smithsonian Astrophysical Observation", "SAO 148933"},
    },
    visualMagnitude: 6.70,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.82225141),
        dec: Angle.Degrees(-17.43955628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71231"},
        {"Hipparcos Number", "HIP 41306"},
        {"Geneva Identification System", "GEN# +1.00071231"},
        {"Smithsonian Astrophysical Observation", "SAO 154240"},
    },
    visualMagnitude: 6.44,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.41403707),
        dec: Angle.Degrees(-17.43940312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12833"},
        {"Hipparcos Number", "HIP 9751"},
        {"Smithsonian Astrophysical Observation", "SAO 148192"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.34986561),
        dec: Angle.Degrees(-17.43715991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161101"},
        {"Hipparcos Number", "HIP 86807"},
        {"Geneva Identification System", "GEN# +1.00161101"},
        {"Smithsonian Astrophysical Observation", "SAO 160788"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.06997662),
        dec: Angle.Degrees(-17.43682478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82590"},
        {"Hipparcos Number", "HIP 46822"},
        {"Geneva Identification System", "GEN# +1.00082590"},
        {"Smithsonian Astrophysical Observation", "SAO 155275"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.12612386),
        dec: Angle.Degrees(-17.43544516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194959"},
        {"Hipparcos Number", "HIP 101036"},
        {"Geneva Identification System", "GEN# +1.00194959"},
        {"Smithsonian Astrophysical Observation", "SAO 163616"},
        {"Wilson Evans Batten Catalogue", "WEB 18246"},
    },
    visualMagnitude: 6.71,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.24573129),
        dec: Angle.Degrees(-17.43469080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43920",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7103"},
        {"Aitken 2", "ADS 7103 AB"},
        {"Henry Draper", "HD 76635"},
        {"Hipparcos Number", "HIP 43920"},
        {"Smithsonian Astrophysical Observation", "SAO 154781"},
    },
    visualMagnitude: 6.56,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.20715423),
        dec: Angle.Degrees(-17.43339054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90167"},
        {"Hipparcos Number", "HIP 50938"},
        {"Smithsonian Astrophysical Observation", "SAO 155960"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.05279757),
        dec: Angle.Degrees(-17.43297746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84256"},
        {"Hipparcos Number", "HIP 47711"},
        {"Smithsonian Astrophysical Observation", "SAO 155434"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.90846318),
        dec: Angle.Degrees(-17.43253044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218530"},
        {"Hipparcos Number", "HIP 114296"},
        {"Smithsonian Astrophysical Observation", "SAO 165513"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.22364831),
        dec: Angle.Degrees(-17.43154835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42691",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6944 AB"},
        {"Henry Draper", "HD 74202"},
        {"Hipparcos Number", "HIP 42691"},
        {"Smithsonian Astrophysical Observation", "SAO 154559"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.52473590),
        dec: Angle.Degrees(-17.42969151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36152"},
        {"Hipparcos Number", "HIP 25670"},
        {"Geneva Identification System", "GEN# +1.00036152"},
        {"Smithsonian Astrophysical Observation", "SAO 150490"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.24658227),
        dec: Angle.Degrees(-17.42905777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2129"},
        {"Hipparcos Number", "HIP 2003"},
        {"Smithsonian Astrophysical Observation", "SAO 147263"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.34571961),
        dec: Angle.Degrees(-17.42752458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114945"},
        {"Hipparcos Number", "HIP 64567"},
        {"Smithsonian Astrophysical Observation", "SAO 157804"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.51589345),
        dec: Angle.Degrees(-17.42653055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -153.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225186"},
        {"Hipparcos Number", "HIP 333"},
        {"Geneva Identification System", "GEN# +1.00225186"},
        {"Smithsonian Astrophysical Observation", "SAO 147062"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.06304747),
        dec: Angle.Degrees(-17.42485068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110806",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110806"},
    },
    visualMagnitude: 10.66,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.74387346),
        dec: Angle.Degrees(-17.42464863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 290.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 81.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80635"},
        {"Hipparcos Number", "HIP 45807"},
        {"Geneva Identification System", "GEN# +1.00080635"},
        {"Smithsonian Astrophysical Observation", "SAO 155104"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.729,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.11451866),
        dec: Angle.Degrees(-17.42463218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20694"},
        {"Hipparcos Number", "HIP 15458"},
        {"Geneva Identification System", "GEN# +1.00020694"},
        {"Smithsonian Astrophysical Observation", "SAO 148902"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.84195489),
        dec: Angle.Degrees(-17.42424184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93463"},
        {"Hipparcos Number", "HIP 52752"},
        {"Smithsonian Astrophysical Observation", "SAO 156226"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.79204933),
        dec: Angle.Degrees(-17.42394926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157668"},
        {"Hipparcos Number", "HIP 85253"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.825,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.31628012),
        dec: Angle.Degrees(-17.42175483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61258"},
        {"Hipparcos Number", "HIP 37132"},
        {"Smithsonian Astrophysical Observation", "SAO 153175"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.44833060),
        dec: Angle.Degrees(-17.42068236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29464"},
        {"Hipparcos Number", "HIP 21567"},
        {"Smithsonian Astrophysical Observation", "SAO 149775"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.44913977),
        dec: Angle.Degrees(-17.41976159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27097",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27097"},
        {"Smithsonian Astrophysical Observation", "SAO 150762"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.18708774),
        dec: Angle.Degrees(-17.41912049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145941"},
        {"Hipparcos Number", "HIP 79579"},
        {"Smithsonian Astrophysical Observation", "SAO 159798"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.55117024),
        dec: Angle.Degrees(-17.41755000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90596"},
        {"Hipparcos Number", "HIP 51185"},
        {"Smithsonian Astrophysical Observation", "SAO 155993"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.83186757),
        dec: Angle.Degrees(-17.41524406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164700"},
        {"Hipparcos Number", "HIP 88409"},
        {"Geneva Identification System", "GEN# +1.00164700"},
        {"Smithsonian Astrophysical Observation", "SAO 161024"},
        {"Wilson Evans Batten Catalogue", "WEB 14945"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.77526470),
        dec: Angle.Degrees(-17.41384919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58192"},
        {"Hipparcos Number", "HIP 35884"},
        {"Geneva Identification System", "GEN# +1.00058192"},
        {"Smithsonian Astrophysical Observation", "SAO 152819"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.97441705),
        dec: Angle.Degrees(-17.41338174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162885"},
        {"Hipparcos Number", "HIP 87625"},
        {"Smithsonian Astrophysical Observation", "SAO 160893"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.49537164),
        dec: Angle.Degrees(-17.41236949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103316"},
        {"Hipparcos Number", "HIP 57997"},
        {"Smithsonian Astrophysical Observation", "SAO 156970"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.44640943),
        dec: Angle.Degrees(-17.41116894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53487"},
        {"Hipparcos Number", "HIP 34123"},
        {"Celescope Catalog", "CEL 1553"},
        {"Geneva Identification System", "GEN# +1.00053487"},
        {"Smithsonian Astrophysical Observation", "SAO 152325"},
    },
    visualMagnitude: 8.72,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.13271593),
        dec: Angle.Degrees(-17.40826491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138887"},
        {"Hipparcos Number", "HIP 76329"},
        {"Smithsonian Astrophysical Observation", "SAO 159366"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.86809294),
        dec: Angle.Degrees(-17.40801331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20880",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20880"},
        {"Smithsonian Astrophysical Observation", "SAO 149667"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.11729935),
        dec: Angle.Degrees(-17.40295963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186369"},
        {"Hipparcos Number", "HIP 97134"},
        {"Smithsonian Astrophysical Observation", "SAO 162937"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.12834903),
        dec: Angle.Degrees(-17.40042671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143005"},
        {"Hipparcos Number", "HIP 78216"},
        {"Smithsonian Astrophysical Observation", "SAO 159609"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.58567521),
        dec: Angle.Degrees(-17.39867498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71768"},
        {"Hipparcos Number", "HIP 41563"},
        {"Smithsonian Astrophysical Observation", "SAO 154296"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.11876639),
        dec: Angle.Degrees(-17.39479808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112547"},
        {"Hipparcos Number", "HIP 63248"},
        {"Smithsonian Astrophysical Observation", "SAO 157620"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.39731866),
        dec: Angle.Degrees(-17.39473119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -182.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118160",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118160"},
    },
    visualMagnitude: 11.88,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.52171896),
        dec: Angle.Degrees(-17.39407144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 381.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16341"},
        {"Hipparcos Number", "HIP 12174"},
        {"Smithsonian Astrophysical Observation", "SAO 148502"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.718,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.21765327),
        dec: Angle.Degrees(-17.39383728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 165.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 65.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11562"},
        {"Hipparcos Number", "HIP 8803"},
        {"Geneva Identification System", "GEN# +1.00011562"},
        {"Smithsonian Astrophysical Observation", "SAO 148083"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.28533478),
        dec: Angle.Degrees(-17.39238807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -146.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13213"},
        {"Hipparcos Number", "HIP 9996"},
        {"Smithsonian Astrophysical Observation", "SAO 148235"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.18698685),
        dec: Angle.Degrees(-17.39131799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35015",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35015"},
        {"Geneva Identification System", "GEN# -0.01701866"},
        {"Wilson Evans Batten Catalogue", "WEB 7005"},
    },
    visualMagnitude: 10.33,
    bvColour: 3.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.64610831),
        dec: Angle.Degrees(-17.38863484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146741"},
        {"Hipparcos Number", "HIP 79895"},
        {"Geneva Identification System", "GEN# +1.00146741"},
        {"Smithsonian Astrophysical Observation", "SAO 159839"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.61297968),
        dec: Angle.Degrees(-17.38758477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 256"},
        {"Hipparcos Number", "HIP 602"},
        {"Geneva Identification System", "GEN# +1.00000256"},
        {"Smithsonian Astrophysical Observation", "SAO 147090"},
    },
    visualMagnitude: 6.20,
    bvColour: 0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.82613856),
        dec: Angle.Degrees(-17.38703103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206596"},
        {"Hipparcos Number", "HIP 107263"},
        {"Smithsonian Astrophysical Observation", "SAO 164605"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.88484792),
        dec: Angle.Degrees(-17.38687389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40589",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40589"},
        {"Smithsonian Astrophysical Observation", "SAO 154071"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.31163601),
        dec: Angle.Degrees(-17.38666572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208979"},
        {"Hipparcos Number", "HIP 108622"},
        {"Geneva Identification System", "GEN# +1.00208979"},
        {"Smithsonian Astrophysical Observation", "SAO 164803"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.07880940),
        dec: Angle.Degrees(-17.38627700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83211"},
        {"Hipparcos Number", "HIP 47146"},
        {"Smithsonian Astrophysical Observation", "SAO 155334"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.10626881),
        dec: Angle.Degrees(-17.38525918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7606"},
        {"Hipparcos Number", "HIP 5900"},
        {"Geneva Identification System", "GEN# +1.00007606"},
        {"Smithsonian Astrophysical Observation", "SAO 147701"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.94812823),
        dec: Angle.Degrees(-17.38458486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38441",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38441"},
    },
    visualMagnitude: 12.21,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.15214403),
        dec: Angle.Degrees(-17.38353197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89106",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89106"},
        {"Smithsonian Astrophysical Observation", "SAO 161152"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.79450128),
        dec: Angle.Degrees(-17.38351857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62647",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62647"},
        {"Cincinnati Publication", "Ci 20 743"},
        {"Geneva Identification System", "GEN# -0.01603543"},
    },
    visualMagnitude: 10.66,
    bvColour: 1.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.55203831),
        dec: Angle.Degrees(-17.38276418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -394.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 344.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75798",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75798"},
    },
    visualMagnitude: 10.53,
    bvColour: 1.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.28043419),
        dec: Angle.Degrees(-17.38184130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -216.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168571"},
        {"Hipparcos Number", "HIP 89946"},
        {"Geneva Identification System", "GEN# +1.00168571"},
        {"Smithsonian Astrophysical Observation", "SAO 161372"},
        {"Wilson Evans Batten Catalogue", "WEB 15360"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.28775911),
        dec: Angle.Degrees(-17.38157322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196979"},
        {"Hipparcos Number", "HIP 102085"},
        {"Smithsonian Astrophysical Observation", "SAO 163798"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.32977707),
        dec: Angle.Degrees(-17.37843286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194515"},
        {"Hipparcos Number", "HIP 100817"},
        {"Geneva Identification System", "GEN# +1.00194515"},
        {"Smithsonian Astrophysical Observation", "SAO 163575"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.63193511),
        dec: Angle.Degrees(-17.37766446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117537",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17031 AB"},
        {"Henry Draper", "HD 223510"},
        {"Hipparcos Number", "HIP 117537"},
        {"Smithsonian Astrophysical Observation", "SAO 165910"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.55287189),
        dec: Angle.Degrees(-17.37654295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167720"},
        {"Hipparcos Number", "HIP 89609"},
        {"Fundamental Katalog 5th Edition", "FK5 3454"},
        {"Geneva Identification System", "GEN# +1.00167720"},
        {"Smithsonian Astrophysical Observation", "SAO 161260"},
        {"Wilson Evans Batten Catalogue", "WEB 15264"},
    },
    visualMagnitude: 5.81,
    bvColour: 1.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.29845504),
        dec: Angle.Degrees(-17.37385188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158595"},
        {"Hipparcos Number", "HIP 85719"},
        {"Smithsonian Astrophysical Observation", "SAO 160604"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.73826250),
        dec: Angle.Degrees(-17.37340411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91803"},
        {"Hipparcos Number", "HIP 51863"},
        {"Smithsonian Astrophysical Observation", "SAO 156089"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.93708997),
        dec: Angle.Degrees(-17.37314337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23512",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23512"},
    },
    visualMagnitude: 11.71,
    bvColour: 1.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.83426652),
        dec: Angle.Degrees(-17.37245290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -226.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -447.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16750"},
        {"Hipparcos Number", "HIP 12482"},
        {"Smithsonian Astrophysical Observation", "SAO 148540"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.15933191),
        dec: Angle.Degrees(-17.37183200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17448"},
        {"Hipparcos Number", "HIP 13030"},
        {"Smithsonian Astrophysical Observation", "SAO 148608"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.86685714),
        dec: Angle.Degrees(-17.36939299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219116"},
        {"Hipparcos Number", "HIP 114648"},
        {"Geneva Identification System", "GEN# +1.00219116"},
        {"Smithsonian Astrophysical Observation", "SAO 165564"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.37595052),
        dec: Angle.Degrees(-17.36908598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67408"},
        {"Hipparcos Number", "HIP 39730"},
        {"Smithsonian Astrophysical Observation", "SAO 153860"},
    },
    visualMagnitude: 6.50,
    bvColour: 1.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.81680540),
        dec: Angle.Degrees(-17.36880923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40518",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40518"},
    },
    visualMagnitude: 10.53,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.09655764),
        dec: Angle.Degrees(-17.36782717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -181.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34617"},
        {"Hipparcos Number", "HIP 24721"},
        {"Smithsonian Astrophysical Observation", "SAO 150318"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.52934613),
        dec: Angle.Degrees(-17.36752374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73021"},
        {"Hipparcos Number", "HIP 42149"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.87256536),
        dec: Angle.Degrees(-17.36735727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -159.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122577"},
        {"Hipparcos Number", "HIP 68643"},
        {"Fundamental Katalog 5th Edition", "FK5 3116"},
        {"Smithsonian Astrophysical Observation", "SAO 158306"},
    },
    visualMagnitude: 6.32,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.76742450),
        dec: Angle.Degrees(-17.36698952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -185.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22836"},
        {"Hipparcos Number", "HIP 17082"},
        {"Fundamental Katalog 5th Edition", "FK5 4331"},
        {"Smithsonian Astrophysical Observation", "SAO 149085"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.90299424),
        dec: Angle.Degrees(-17.36504821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25342"},
        {"Hipparcos Number", "HIP 18755"},
        {"Smithsonian Astrophysical Observation", "SAO 149317"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.25707845),
        dec: Angle.Degrees(-17.36495265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46771"},
        {"Hipparcos Number", "HIP 31360"},
        {"Renson", "Renson 12540"},
        {"Smithsonian Astrophysical Observation", "SAO 151656"},
    },
    visualMagnitude: 8.76,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.64229459),
        dec: Angle.Degrees(-17.36447157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132150"},
        {"Hipparcos Number", "HIP 73238"},
        {"Smithsonian Astrophysical Observation", "SAO 158931"},
    },
    visualMagnitude: 6.64,
    bvColour: 1.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.52206306),
        dec: Angle.Degrees(-17.36421288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67836"},
        {"Hipparcos Number", "HIP 39925"},
        {"Smithsonian Astrophysical Observation", "SAO 153897"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.31141551),
        dec: Angle.Degrees(-17.36193158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76102"},
        {"Hipparcos Number", "HIP 43655"},
        {"Geneva Identification System", "GEN# +1.00076102"},
        {"Smithsonian Astrophysical Observation", "SAO 154721"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.40144500),
        dec: Angle.Degrees(-17.35925776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24670"},
        {"Hipparcos Number", "HIP 18298"},
        {"Smithsonian Astrophysical Observation", "SAO 149246"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.69052624),
        dec: Angle.Degrees(-17.35791321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164945"},
        {"Hipparcos Number", "HIP 88504"},
        {"Smithsonian Astrophysical Observation", "SAO 161037"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.08912656),
        dec: Angle.Degrees(-17.35345324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53174",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53174"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.16335050),
        dec: Angle.Degrees(-17.35259698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176609"},
        {"Hipparcos Number", "HIP 93444"},
        {"Geneva Identification System", "GEN# +1.00176609"},
        {"Smithsonian Astrophysical Observation", "SAO 162100"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.46009494),
        dec: Angle.Degrees(-17.35153746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118009"},
        {"Hipparcos Number", "HIP 66231"},
        {"Smithsonian Astrophysical Observation", "SAO 158012"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.60910247),
        dec: Angle.Degrees(-17.35114081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95562"},
        {"Hipparcos Number", "HIP 53893"},
        {"Renson", "Renson 27526"},
        {"Smithsonian Astrophysical Observation", "SAO 156408"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.41041602),
        dec: Angle.Degrees(-17.35108943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141593"},
        {"Hipparcos Number", "HIP 77590"},
        {"Smithsonian Astrophysical Observation", "SAO 159527"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.61952258),
        dec: Angle.Degrees(-17.34876674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189926"},
        {"Hipparcos Number", "HIP 98724"},
        {"Smithsonian Astrophysical Observation", "SAO 163210"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.77353109),
        dec: Angle.Degrees(-17.34821464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82102",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10197 AB"},
        {"Henry Draper", "HD 151148"},
        {"Hipparcos Number", "HIP 82102"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.56191390),
        dec: Angle.Degrees(-17.34669687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153608"},
        {"Hipparcos Number", "HIP 83278"},
        {"Geneva Identification System", "GEN# +1.00153608"},
        {"Smithsonian Astrophysical Observation", "SAO 160226"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.29749404),
        dec: Angle.Degrees(-17.34525325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202261"},
        {"Hipparcos Number", "HIP 104914"},
        {"Geneva Identification System", "GEN# +1.00202261"},
        {"Smithsonian Astrophysical Observation", "SAO 164249"},
    },
    visualMagnitude: 6.05,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.77758077),
        dec: Angle.Degrees(-17.34509006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59441"},
        {"Hipparcos Number", "HIP 36392"},
        {"Geneva Identification System", "GEN# +1.00059441"},
        {"Smithsonian Astrophysical Observation", "SAO 152944"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.33495381),
        dec: Angle.Degrees(-17.34492083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118942"},
        {"Hipparcos Number", "HIP 66717"},
        {"Geneva Identification System", "GEN# +1.00118942"},
        {"Smithsonian Astrophysical Observation", "SAO 158081"},
        {"Wilson Evans Batten Catalogue", "WEB 11768"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.13556231),
        dec: Angle.Degrees(-17.34369552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72423",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9387"},
        {"Aitken 2", "ADS 9387 AB"},
        {"Henry Draper", "HD 130412"},
        {"Hipparcos Number", "HIP 72423"},
        {"Smithsonian Astrophysical Observation", "SAO 158813"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.13210123),
        dec: Angle.Degrees(-17.34010698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77998"},
        {"Hipparcos Number", "HIP 44609"},
        {"Smithsonian Astrophysical Observation", "SAO 154894"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.744,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.33160007),
        dec: Angle.Degrees(-17.33957590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42597",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6932 AB"},
        {"Henry Draper", "HD 74021"},
        {"Hipparcos Number", "HIP 42597"},
        {"Smithsonian Astrophysical Observation", "SAO 154540"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.22571654),
        dec: Angle.Degrees(-17.33932451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225132"},
        {"Hipparcos Number", "HIP 301"},
        {"Fundamental Katalog 5th Edition", "FK5 905"},
        {"Geneva Identification System", "GEN# +1.00225132"},
        {"Smithsonian Astrophysical Observation", "SAO 147059"},
        {"Wilson Evans Batten Catalogue", "WEB 43"},
    },
    visualMagnitude: 4.55,
    bvColour: -0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.93488487),
        dec: Angle.Degrees(-17.33597002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154146"},
        {"Hipparcos Number", "HIP 83538"},
        {"Geneva Identification System", "GEN# +1.00154146"},
        {"Smithsonian Astrophysical Observation", "SAO 160256"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.10983396),
        dec: Angle.Degrees(-17.33513335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184772"},
        {"Hipparcos Number", "HIP 96462"},
        {"Smithsonian Astrophysical Observation", "SAO 162811"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.17392075),
        dec: Angle.Degrees(-17.33441253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194828"},
        {"Hipparcos Number", "HIP 100975"},
        {"Smithsonian Astrophysical Observation", "SAO 163603"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.09950587),
        dec: Angle.Degrees(-17.33361882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86950"},
        {"Hipparcos Number", "HIP 49129"},
        {"Smithsonian Astrophysical Observation", "SAO 155667"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.40672763),
        dec: Angle.Degrees(-17.33299954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2402"},
        {"Hipparcos Number", "HIP 2196"},
        {"Geneva Identification System", "GEN# +1.00002402"},
        {"Smithsonian Astrophysical Observation", "SAO 147287"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.93660234),
        dec: Angle.Degrees(-17.33149724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55213"},
        {"Hipparcos Number", "HIP 34725"},
        {"Celescope Catalog", "CEL 1653"},
        {"Geneva Identification System", "GEN# +1.00055213"},
        {"Smithsonian Astrophysical Observation", "SAO 152532"},
    },
    visualMagnitude: 6.66,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.85490913),
        dec: Angle.Degrees(-17.33113549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33291"},
        {"Hipparcos Number", "HIP 23931"},
        {"Geneva Identification System", "GEN# +1.00033291"},
        {"Smithsonian Astrophysical Observation", "SAO 150173"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.14320149),
        dec: Angle.Degrees(-17.32820400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119114"},
        {"Hipparcos Number", "HIP 66810"},
        {"Smithsonian Astrophysical Observation", "SAO 158090"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.41692046),
        dec: Angle.Degrees(-17.32480615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169804"},
        {"Hipparcos Number", "HIP 90432"},
        {"Smithsonian Astrophysical Observation", "SAO 161481"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.77328728),
        dec: Angle.Degrees(-17.32450381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36168"},
        {"Hipparcos Number", "HIP 25688"},
        {"Smithsonian Astrophysical Observation", "SAO 150493"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.28471022),
        dec: Angle.Degrees(-17.32104880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220515"},
        {"Hipparcos Number", "HIP 115553"},
        {"Geneva Identification System", "GEN# +1.00220515"},
        {"Smithsonian Astrophysical Observation", "SAO 165676"},
        {"Wilson Evans Batten Catalogue", "WEB 20454"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.10124824),
        dec: Angle.Degrees(-17.31909946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184253"},
        {"Hipparcos Number", "HIP 96236"},
        {"Smithsonian Astrophysical Observation", "SAO 162772"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.53783361),
        dec: Angle.Degrees(-17.31849506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30290"},
        {"Hipparcos Number", "HIP 22113"},
        {"Smithsonian Astrophysical Observation", "SAO 149865"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.39484880),
        dec: Angle.Degrees(-17.31716019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95282"},
        {"Hipparcos Number", "HIP 53759"},
        {"Smithsonian Astrophysical Observation", "SAO 156377"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.97726395),
        dec: Angle.Degrees(-17.31698490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162080"},
        {"Hipparcos Number", "HIP 87266"},
        {"Smithsonian Astrophysical Observation", "SAO 160844"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.48011543),
        dec: Angle.Degrees(-17.31399267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98885"},
        {"Hipparcos Number", "HIP 55551"},
        {"Smithsonian Astrophysical Observation", "SAO 156637"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.67788330),
        dec: Angle.Degrees(-17.31398196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150299"},
        {"Hipparcos Number", "HIP 81647"},
        {"Geneva Identification System", "GEN# +1.00150299"},
        {"Smithsonian Astrophysical Observation", "SAO 160036"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.17968947),
        dec: Angle.Degrees(-17.31387345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208866"},
        {"Hipparcos Number", "HIP 108560"},
        {"Geneva Identification System", "GEN# +1.00208866"},
        {"Smithsonian Astrophysical Observation", "SAO 164794"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.85756634),
        dec: Angle.Degrees(-17.31056328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200171"},
        {"Hipparcos Number", "HIP 103825"},
        {"Smithsonian Astrophysical Observation", "SAO 164076"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.59194694),
        dec: Angle.Degrees(-17.31049564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8751"},
        {"Hipparcos Number", "HIP 6698"},
        {"Smithsonian Astrophysical Observation", "SAO 147806"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.51415807),
        dec: Angle.Degrees(-17.31012111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158720"},
        {"Hipparcos Number", "HIP 85768"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.88191577),
        dec: Angle.Degrees(-17.30915809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5413"},
        {"Hipparcos Number", "HIP 4355"},
        {"Fundamental Katalog 5th Edition", "FK5 4082"},
        {"Smithsonian Astrophysical Observation", "SAO 147517"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.95794615),
        dec: Angle.Degrees(-17.30882462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159569"},
        {"Hipparcos Number", "HIP 86124"},
        {"Smithsonian Astrophysical Observation", "SAO 160674"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.01916440),
        dec: Angle.Degrees(-17.30622305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9831"},
        {"Hipparcos Number", "HIP 7431"},
        {"Geneva Identification System", "GEN# +1.00009831"},
        {"Smithsonian Astrophysical Observation", "SAO 147898"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.93378912),
        dec: Angle.Degrees(-17.30324959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50070"},
        {"Hipparcos Number", "HIP 32849"},
        {"Celescope Catalog", "CEL 1406"},
        {"Geneva Identification System", "GEN# +1.00050070"},
        {"Smithsonian Astrophysical Observation", "SAO 152002"},
    },
    visualMagnitude: 8.81,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.70273674),
        dec: Angle.Degrees(-17.30285813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73844"},
        {"Hipparcos Number", "HIP 42502"},
        {"Cincinnati Publication", "Ci 18 1017"},
        {"Geneva Identification System", "GEN# +1.00073844"},
        {"Smithsonian Astrophysical Observation", "SAO 154514"},
        {"Wilson Evans Batten Catalogue", "WEB 8184"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.97308984),
        dec: Angle.Degrees(-17.30260736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -152.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33081"},
        {"Hipparcos Number", "HIP 23816"},
        {"Geneva Identification System", "GEN# +1.00033081"},
        {"Smithsonian Astrophysical Observation", "SAO 150154"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.78610366),
        dec: Angle.Degrees(-17.29952197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -164.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67288"},
        {"Hipparcos Number", "HIP 39688"},
        {"Geneva Identification System", "GEN# +1.00067288"},
        {"Smithsonian Astrophysical Observation", "SAO 153848"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.767,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.66342364),
        dec: Angle.Degrees(-17.29730904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93397"},
        {"Hipparcos Number", "HIP 52737"},
        {"Geneva Identification System", "GEN# +1.00093397"},
        {"Renson", "Renson 27000"},
        {"Smithsonian Astrophysical Observation", "SAO 156221"},
    },
    visualMagnitude: 5.44,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.71693697),
        dec: Angle.Degrees(-17.29683026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56430"},
        {"Hipparcos Number", "HIP 35177"},
        {"Celescope Catalog", "CEL 1728"},
        {"Geneva Identification System", "GEN# +1.00056430"},
        {"Smithsonian Astrophysical Observation", "SAO 152642"},
    },
    visualMagnitude: 7.83,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.05414550),
        dec: Angle.Degrees(-17.29646110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72699",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72699"},
        {"Smithsonian Astrophysical Observation", "SAO 158858"},
    },
    visualMagnitude: 9.83,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.95380040),
        dec: Angle.Degrees(-17.29531424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207188"},
        {"Hipparcos Number", "HIP 107594"},
        {"Smithsonian Astrophysical Observation", "SAO 164653"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.90174028),
        dec: Angle.Degrees(-17.29474754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47868"},
        {"Hipparcos Number", "HIP 31900"},
        {"Geneva Identification System", "GEN# +1.00047868"},
        {"Smithsonian Astrophysical Observation", "SAO 151771"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.01746410),
        dec: Angle.Degrees(-17.29364418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49955"},
        {"Hipparcos Number", "HIP 32801"},
        {"Celescope Catalog", "CEL 1401"},
        {"Geneva Identification System", "GEN# +1.00049955"},
        {"Smithsonian Astrophysical Observation", "SAO 151990"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.56949863),
        dec: Angle.Degrees(-17.29192313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42326"},
        {"Hipparcos Number", "HIP 29175"},
        {"Geneva Identification System", "GEN# +1.00042326"},
        {"Renson", "Renson 11280"},
        {"Smithsonian Astrophysical Observation", "SAO 151171"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.32031250),
        dec: Angle.Degrees(-17.29160437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198446"},
        {"Hipparcos Number", "HIP 102913"},
        {"Smithsonian Astrophysical Observation", "SAO 163928"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.73815004),
        dec: Angle.Degrees(-17.29118047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62676"},
        {"Hipparcos Number", "HIP 37758"},
        {"Geneva Identification System", "GEN# +1.00062676"},
        {"Smithsonian Astrophysical Observation", "SAO 153335"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.15240112),
        dec: Angle.Degrees(-17.29070881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104691"},
        {"Hipparcos Number", "HIP 58778"},
        {"Smithsonian Astrophysical Observation", "SAO 157065"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.83243511),
        dec: Angle.Degrees(-17.28959327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16145"},
        {"Hipparcos Number", "HIP 12023"},
        {"Geneva Identification System", "GEN# +1.00016145"},
        {"Renson", "Renson 4060"},
        {"Smithsonian Astrophysical Observation", "SAO 148481"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.76744558),
        dec: Angle.Degrees(-17.28956675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33163"},
        {"Hipparcos Number", "HIP 23862"},
        {"Smithsonian Astrophysical Observation", "SAO 150165"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.92647973),
        dec: Angle.Degrees(-17.28855008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12776"},
        {"Hipparcos Number", "HIP 9701"},
        {"Smithsonian Astrophysical Observation", "SAO 148188"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.19442928),
        dec: Angle.Degrees(-17.28747921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100047",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100047"},
    },
    visualMagnitude: 11.03,
    bvColour: 1.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.46833970),
        dec: Angle.Degrees(-17.28505738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -312.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219568"},
        {"Hipparcos Number", "HIP 114938"},
        {"Smithsonian Astrophysical Observation", "SAO 165601"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.21082554),
        dec: Angle.Degrees(-17.28301518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17678"},
        {"Hipparcos Number", "HIP 13188"},
        {"Smithsonian Astrophysical Observation", "SAO 148629"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.42745003),
        dec: Angle.Degrees(-17.27983119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43895"},
        {"Hipparcos Number", "HIP 29928"},
        {"Smithsonian Astrophysical Observation", "SAO 151327"},
    },
    visualMagnitude: 8.69,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.51236728),
        dec: Angle.Degrees(-17.27877531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94310"},
        {"Hipparcos Number", "HIP 53206"},
        {"Geneva Identification System", "GEN# +1.00094310"},
        {"Smithsonian Astrophysical Observation", "SAO 156295"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.23630827),
        dec: Angle.Degrees(-17.27731509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -173.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 74.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69101"},
        {"Hipparcos Number", "HIP 40406"},
        {"Geneva Identification System", "GEN# +1.00069101"},
        {"Smithsonian Astrophysical Observation", "SAO 154023"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.73272847),
        dec: Angle.Degrees(-17.27613538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26625"},
        {"Hipparcos Number", "HIP 19601"},
        {"Smithsonian Astrophysical Observation", "SAO 149446"},
    },
    visualMagnitude: 6.41,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.00108195),
        dec: Angle.Degrees(-17.27460047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221181"},
        {"Hipparcos Number", "HIP 115976"},
        {"Smithsonian Astrophysical Observation", "SAO 165722"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.46061296),
        dec: Angle.Degrees(-17.27226465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -124.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110875",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15957 AB"},
        {"Henry Draper", "HD 212889"},
        {"Hipparcos Number", "HIP 110875"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.95678522),
        dec: Angle.Degrees(-17.27052378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204096"},
        {"Hipparcos Number", "HIP 105892"},
        {"Smithsonian Astrophysical Observation", "SAO 164392"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.68783364),
        dec: Angle.Degrees(-17.27009662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28882"},
        {"Hipparcos Number", "HIP 21180"},
        {"Smithsonian Astrophysical Observation", "SAO 149716"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.11049850),
        dec: Angle.Degrees(-17.26775683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187666"},
        {"Hipparcos Number", "HIP 97740"},
        {"Smithsonian Astrophysical Observation", "SAO 163051"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.93780797),
        dec: Angle.Degrees(-17.26745210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178316"},
        {"Hipparcos Number", "HIP 94049"},
        {"Wilson Evans Batten Catalogue", "WEB 16371"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.20818855),
        dec: Angle.Degrees(-17.26540378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110813",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Lionrock"},
        {"Henry Draper", "HD 212771"},
        {"Hipparcos Number", "HIP 110813"},
        {"Geneva Identification System", "GEN# +1.00212771"},
        {"Smithsonian Astrophysical Observation", "SAO 165086"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.882,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.76301886),
        dec: Angle.Degrees(-17.26340395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6847",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1171 B"},
        {"Henry Draper", "HD 8957B"},
        {"Hipparcos Number", "HIP 6847"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.02104211),
        dec: Angle.Degrees(-17.26288698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6849",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1171 A"},
        {"Henry Draper", "HD 8957"},
        {"Hipparcos Number", "HIP 6849"},
        {"Smithsonian Astrophysical Observation", "SAO 147822"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.02424967),
        dec: Angle.Degrees(-17.26155449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204762"},
        {"Hipparcos Number", "HIP 106251"},
        {"Smithsonian Astrophysical Observation", "SAO 164447"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.81260396),
        dec: Angle.Degrees(-17.25988013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36715"},
        {"Hipparcos Number", "HIP 26004"},
        {"Smithsonian Astrophysical Observation", "SAO 150550"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.25353709),
        dec: Angle.Degrees(-17.25808433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82060"},
        {"Hipparcos Number", "HIP 46514"},
        {"Smithsonian Astrophysical Observation", "SAO 155228"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.30955281),
        dec: Angle.Degrees(-17.25792416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204347"},
        {"Hipparcos Number", "HIP 106016"},
        {"Smithsonian Astrophysical Observation", "SAO 164416"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.09020092),
        dec: Angle.Degrees(-17.25782331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213985"},
        {"Hipparcos Number", "HIP 111506"},
        {"Geneva Identification System", "GEN# +1.00213985"},
        {"Smithsonian Astrophysical Observation", "SAO 165175"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.86463910),
        dec: Angle.Degrees(-17.25745430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162264"},
        {"Hipparcos Number", "HIP 87351"},
        {"Smithsonian Astrophysical Observation", "SAO 160855"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.73658311),
        dec: Angle.Degrees(-17.25702931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97505"},
        {"Hipparcos Number", "HIP 54799"},
        {"Smithsonian Astrophysical Observation", "SAO 156538"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.27768843),
        dec: Angle.Degrees(-17.25628387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142504"},
        {"Hipparcos Number", "HIP 77979"},
        {"Smithsonian Astrophysical Observation", "SAO 159575"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.86728023),
        dec: Angle.Degrees(-17.25625174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215875"},
        {"Hipparcos Number", "HIP 112624"},
        {"Renson", "Renson 59625"},
        {"Smithsonian Astrophysical Observation", "SAO 165309"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.14837927),
        dec: Angle.Degrees(-17.25598285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141635"},
        {"Hipparcos Number", "HIP 77607"},
    },
    visualMagnitude: 10.33,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.65765564),
        dec: Angle.Degrees(-17.25556212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33654",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33654"},
    },
    visualMagnitude: 10.01,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.87258084),
        dec: Angle.Degrees(-17.25512875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -263.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 181.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159892"},
        {"Hipparcos Number", "HIP 86281"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.45086743),
        dec: Angle.Degrees(-17.25205577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10185"},
        {"Hipparcos Number", "HIP 7715"},
        {"Smithsonian Astrophysical Observation", "SAO 147934"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.83005613),
        dec: Angle.Degrees(-17.25137274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17880"},
        {"Hipparcos Number", "HIP 13355"},
        {"Smithsonian Astrophysical Observation", "SAO 148642"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.95746551),
        dec: Angle.Degrees(-17.25114168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108204"},
        {"Hipparcos Number", "HIP 60653"},
        {"Smithsonian Astrophysical Observation", "SAO 157279"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.47632784),
        dec: Angle.Degrees(-17.24829304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -184.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138486"},
        {"Hipparcos Number", "HIP 76134"},
        {"Smithsonian Astrophysical Observation", "SAO 159336"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.24970745),
        dec: Angle.Degrees(-17.24699091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155427"},
        {"Hipparcos Number", "HIP 84149"},
        {"Smithsonian Astrophysical Observation", "SAO 160354"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.06386388),
        dec: Angle.Degrees(-17.24647608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55637"},
        {"Hipparcos Number", "HIP 34887"},
        {"Renson", "Renson 15127"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.27989356),
        dec: Angle.Degrees(-17.24558690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50303"},
        {"Hipparcos Number", "HIP 32963"},
        {"Celescope Catalog", "CEL 1411"},
        {"Geneva Identification System", "GEN# +1.00050303"},
        {"Smithsonian Astrophysical Observation", "SAO 152026"},
    },
    visualMagnitude: 8.30,
    bvColour: -0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.98564220),
        dec: Angle.Degrees(-17.24538721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95172",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12337 A"},
        {"Henry Draper", "HD 181576"},
        {"Hipparcos Number", "HIP 95172"},
        {"Smithsonian Astrophysical Observation", "SAO 162516"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.42370840),
        dec: Angle.Degrees(-17.24533061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199197"},
        {"Hipparcos Number", "HIP 103338"},
        {"Smithsonian Astrophysical Observation", "SAO 163996"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.03894706),
        dec: Angle.Degrees(-17.24314328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177913"},
        {"Hipparcos Number", "HIP 93906"},
        {"Smithsonian Astrophysical Observation", "SAO 162211"},
    },
    visualMagnitude: 7.64,
    bvColour: -0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.82733309),
        dec: Angle.Degrees(-17.24186213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40137"},
        {"Hipparcos Number", "HIP 28092"},
        {"Geneva Identification System", "GEN# +1.00040137"},
        {"Smithsonian Astrophysical Observation", "SAO 150956"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.07281099),
        dec: Angle.Degrees(-17.23988185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7496"},
        {"Hipparcos Number", "HIP 5830"},
        {"Geneva Identification System", "GEN# +1.00007496"},
        {"Smithsonian Astrophysical Observation", "SAO 147691"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.69389454),
        dec: Angle.Degrees(-17.23979304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75531"},
        {"Hipparcos Number", "HIP 43366"},
        {"Smithsonian Astrophysical Observation", "SAO 154671"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.49870452),
        dec: Angle.Degrees(-17.23943681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113502"},
        {"Hipparcos Number", "HIP 63775"},
        {"Geneva Identification System", "GEN# +1.00113502"},
        {"Smithsonian Astrophysical Observation", "SAO 157694"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.08001899),
        dec: Angle.Degrees(-17.23732505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221974"},
        {"Hipparcos Number", "HIP 116519"},
        {"Cincinnati Publication", "Ci 20 1440"},
        {"Geneva Identification System", "GEN# +1.00221974"},
        {"Smithsonian Astrophysical Observation", "SAO 165795"},
        {"Wilson Evans Batten Catalogue", "WEB 20576"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.904,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.18961795),
        dec: Angle.Degrees(-17.23681465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 446.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77879"},
        {"Hipparcos Number", "HIP 44556"},
        {"Geneva Identification System", "GEN# +1.00077879"},
        {"Smithsonian Astrophysical Observation", "SAO 154884"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.17334889),
        dec: Angle.Degrees(-17.23678981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4273"},
        {"Hipparcos Number", "HIP 3520"},
        {"Smithsonian Astrophysical Observation", "SAO 147429"},
    },
    visualMagnitude: 9.51,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.23728254),
        dec: Angle.Degrees(-17.23411322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9092"},
        {"Hipparcos Number", "HIP 6924"},
        {"Smithsonian Astrophysical Observation", "SAO 147834"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.30133791),
        dec: Angle.Degrees(-17.23327125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77744",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9815 AB"},
        {"Henry Draper", "HD 141959"},
        {"Hipparcos Number", "HIP 77744"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.09721975),
        dec: Angle.Degrees(-17.23322158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200761"},
        {"Hipparcos Number", "HIP 104139"},
        {"Fundamental Katalog 5th Edition", "FK5 1552"},
        {"Geneva Identification System", "GEN# +1.00200761"},
        {"Smithsonian Astrophysical Observation", "SAO 164132"},
        {"Wilson Evans Batten Catalogue", "WEB 18967"},
    },
    visualMagnitude: 4.08,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.48658082),
        dec: Angle.Degrees(-17.23271095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114242"},
        {"Hipparcos Number", "HIP 64198"},
        {"Smithsonian Astrophysical Observation", "SAO 157756"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.36253581),
        dec: Angle.Degrees(-17.23269103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171893"},
        {"Hipparcos Number", "HIP 91343"},
        {"Fundamental Katalog 5th Edition", "FK5 3479"},
        {"Geneva Identification System", "GEN# +1.00171893"},
        {"Smithsonian Astrophysical Observation", "SAO 161683"},
        {"Wilson Evans Batten Catalogue", "WEB 15695"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.46486430),
        dec: Angle.Degrees(-17.23128090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18836"},
        {"Hipparcos Number", "HIP 14073"},
        {"Geneva Identification System", "GEN# +1.00018836"},
        {"Smithsonian Astrophysical Observation", "SAO 148717"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.33409820),
        dec: Angle.Degrees(-17.23045392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63697"},
        {"Hipparcos Number", "HIP 38211"},
        {"Fundamental Katalog 5th Edition", "FK5 2607"},
        {"Geneva Identification System", "GEN# +1.00063697"},
        {"Smithsonian Astrophysical Observation", "SAO 153454"},
        {"Wilson Evans Batten Catalogue", "WEB 7529"},
    },
    visualMagnitude: 5.17,
    bvColour: 1.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.42153403),
        dec: Angle.Degrees(-17.22812300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35308"},
        {"Hipparcos Number", "HIP 25177"},
        {"Smithsonian Astrophysical Observation", "SAO 150391"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.78280574),
        dec: Angle.Degrees(-17.22391605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41627"},
        {"Hipparcos Number", "HIP 28866"},
        {"Smithsonian Astrophysical Observation", "SAO 151100"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.42212544),
        dec: Angle.Degrees(-17.22262415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206354"},
        {"Hipparcos Number", "HIP 107122"},
        {"Smithsonian Astrophysical Observation", "SAO 164583"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.49304066),
        dec: Angle.Degrees(-17.22190787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 230.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109159"},
        {"Hipparcos Number", "HIP 61218"},
        {"Geneva Identification System", "GEN# +1.00109159"},
        {"Smithsonian Astrophysical Observation", "SAO 157351"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.853,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.17206967),
        dec: Angle.Degrees(-17.22071365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81409"},
        {"Hipparcos Number", "HIP 46181"},
        {"Geneva Identification System", "GEN# +1.00081409"},
        {"Smithsonian Astrophysical Observation", "SAO 155163"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.24998254),
        dec: Angle.Degrees(-17.21871223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76122"},
        {"Hipparcos Number", "HIP 43664"},
        {"Geneva Identification System", "GEN# +1.00076122"},
        {"Renson", "Renson 21295"},
        {"Smithsonian Astrophysical Observation", "SAO 154724"},
        {"Wilson Evans Batten Catalogue", "WEB 8406"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.43699480),
        dec: Angle.Degrees(-17.21858274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10986"},
        {"Hipparcos Number", "HIP 8345"},
        {"Smithsonian Astrophysical Observation", "SAO 148012"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.90907116),
        dec: Angle.Degrees(-17.21812366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2554"},
        {"Hipparcos Number", "HIP 2274"},
        {"Geneva Identification System", "GEN# +1.00002554"},
        {"Smithsonian Astrophysical Observation", "SAO 147298"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.26687137),
        dec: Angle.Degrees(-17.21688833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51085"},
        {"Hipparcos Number", "HIP 33274"},
        {"Celescope Catalog", "CEL 1435"},
        {"Geneva Identification System", "GEN# +1.00051085"},
        {"Smithsonian Astrophysical Observation", "SAO 152102"},
    },
    visualMagnitude: 7.88,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.81698085),
        dec: Angle.Degrees(-17.21527751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57087"},
        {"Hipparcos Number", "HIP 35444"},
        {"Smithsonian Astrophysical Observation", "SAO 152709"},
    },
    visualMagnitude: 6.79,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.76538826),
        dec: Angle.Degrees(-17.21314045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105764"},
        {"Hipparcos Number", "HIP 59351"},
        {"Smithsonian Astrophysical Observation", "SAO 157125"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.62306553),
        dec: Angle.Degrees(-17.20996445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205769"},
        {"Hipparcos Number", "HIP 106805"},
        {"Smithsonian Astrophysical Observation", "SAO 164534"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.48462733),
        dec: Angle.Degrees(-17.20963347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193564"},
        {"Hipparcos Number", "HIP 100373"},
        {"Smithsonian Astrophysical Observation", "SAO 163491"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.34806942),
        dec: Angle.Degrees(-17.20914825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11834"},
        {"Hipparcos Number", "HIP 8999"},
        {"Smithsonian Astrophysical Observation", "SAO 148112"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.97379407),
        dec: Angle.Degrees(-17.20894047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171640"},
        {"Hipparcos Number", "HIP 91246"},
        {"Geneva Identification System", "GEN# +1.00171640"},
        {"Smithsonian Astrophysical Observation", "SAO 161658"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.17440808),
        dec: Angle.Degrees(-17.20682300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84802"},
        {"Hipparcos Number", "HIP 48009"},
        {"Smithsonian Astrophysical Observation", "SAO 155478"},
    },
    visualMagnitude: 6.72,
    bvColour: 1.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.80866586),
        dec: Angle.Degrees(-17.20591386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211278"},
        {"Hipparcos Number", "HIP 109960"},
        {"Smithsonian Astrophysical Observation", "SAO 164966"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.06895336),
        dec: Angle.Degrees(-17.20524652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6292"},
        {"Hipparcos Number", "HIP 4980"},
        {"Geneva Identification System", "GEN# +1.00006292"},
        {"Smithsonian Astrophysical Observation", "SAO 147588"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.95089336),
        dec: Angle.Degrees(-17.20057400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90418",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11345 AB"},
        {"Henry Draper", "HD 169757"},
        {"Hipparcos Number", "HIP 90418"},
        {"Smithsonian Astrophysical Observation", "SAO 161477"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.73314000),
        dec: Angle.Degrees(-17.19760351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59934"},
        {"Hipparcos Number", "HIP 36599"},
        {"Celescope Catalog", "CEL 1905"},
        {"Geneva Identification System", "GEN# +4.40040001"},
        {"Smithsonian Astrophysical Observation", "SAO 153011"},
        {"Wilson Evans Batten Catalogue", "WEB 7275"},
    },
    visualMagnitude: 8.05,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.90874810),
        dec: Angle.Degrees(-17.19754698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74366"},
        {"Hipparcos Number", "HIP 42784"},
        {"Geneva Identification System", "GEN# +1.00074366"},
        {"Smithsonian Astrophysical Observation", "SAO 154569"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.76194204),
        dec: Angle.Degrees(-17.19749171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135810"},
        {"Hipparcos Number", "HIP 74838"},
        {"Smithsonian Astrophysical Observation", "SAO 159156"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.41493038),
        dec: Angle.Degrees(-17.19700695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91743"},
        {"Hipparcos Number", "HIP 51830"},
        {"Smithsonian Astrophysical Observation", "SAO 156083"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.83261940),
        dec: Angle.Degrees(-17.19652679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13358"},
        {"Hipparcos Number", "HIP 10128"},
        {"Smithsonian Astrophysical Observation", "SAO 148250"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.56656953),
        dec: Angle.Degrees(-17.19617209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182110"},
        {"Hipparcos Number", "HIP 95343"},
        {"Smithsonian Astrophysical Observation", "SAO 162564"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.95389787),
        dec: Angle.Degrees(-17.19572950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190756"},
        {"Hipparcos Number", "HIP 99095"},
        {"Geneva Identification System", "GEN# +1.00190756"},
        {"Smithsonian Astrophysical Observation", "SAO 163272"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.76537679),
        dec: Angle.Degrees(-17.19505928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60945"},
        {"Hipparcos Number", "HIP 37001"},
        {"Celescope Catalog", "CEL 1945"},
        {"Geneva Identification System", "GEN# +1.00060945"},
        {"Smithsonian Astrophysical Observation", "SAO 153129"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.06947124),
        dec: Angle.Degrees(-17.19205534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56952"},
        {"Hipparcos Number", "HIP 35375"},
        {"Geneva Identification System", "GEN# +1.00056952"},
        {"Smithsonian Astrophysical Observation", "SAO 152697"},
        {"Wilson Evans Batten Catalogue", "WEB 7060"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.61744902),
        dec: Angle.Degrees(-17.18993420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145059"},
        {"Hipparcos Number", "HIP 79169"},
        {"Geneva Identification System", "GEN# +1.00145059"},
        {"Smithsonian Astrophysical Observation", "SAO 159743"},
        {"Wilson Evans Batten Catalogue", "WEB 13385"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.37544818),
        dec: Angle.Degrees(-17.18781336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77072"},
        {"Hipparcos Number", "HIP 44159"},
        {"Renson", "Renson 21725"},
        {"Smithsonian Astrophysical Observation", "SAO 154813"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.90602784),
        dec: Angle.Degrees(-17.18585063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 890"},
        {"Hipparcos Number", "HIP 1065"},
        {"Geneva Identification System", "GEN# +1.00000890"},
        {"Smithsonian Astrophysical Observation", "SAO 147153"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.30692856),
        dec: Angle.Degrees(-17.18471195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28116"},
        {"Hipparcos Number", "HIP 20651"},
        {"Smithsonian Astrophysical Observation", "SAO 149619"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.37811704),
        dec: Angle.Degrees(-17.18336668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87247"},
        {"Hipparcos Number", "HIP 49258"},
        {"Geneva Identification System", "GEN# +1.00087247"},
        {"Smithsonian Astrophysical Observation", "SAO 155692"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.83502712),
        dec: Angle.Degrees(-17.18233489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121221"},
        {"Hipparcos Number", "HIP 67896"},
        {"Smithsonian Astrophysical Observation", "SAO 158225"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.58913341),
        dec: Angle.Degrees(-17.18010550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10491"},
        {"Hipparcos Number", "HIP 7934"},
        {"Smithsonian Astrophysical Observation", "SAO 147964"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.49812505),
        dec: Angle.Degrees(-17.17882188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61726"},
        {"Hipparcos Number", "HIP 37361"},
        {"Smithsonian Astrophysical Observation", "SAO 153221"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.901,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.03491125),
        dec: Angle.Degrees(-17.17470543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36596",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36596"},
        {"Geneva Identification System", "GEN# +4.40040005"},
    },
    visualMagnitude: 10.97,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.90765372),
        dec: Angle.Degrees(-17.17364635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39293",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39293"},
    },
    visualMagnitude: 11.34,
    bvColour: 1.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.51502881),
        dec: Angle.Degrees(-17.17215970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -345.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 138.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21877"},
        {"Hipparcos Number", "HIP 16384"},
        {"Geneva Identification System", "GEN# +1.00021877"},
        {"Renson", "Renson 5490"},
        {"Smithsonian Astrophysical Observation", "SAO 149005"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.76011232),
        dec: Angle.Degrees(-17.16781347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24316"},
        {"Hipparcos Number", "HIP 18056"},
        {"Smithsonian Astrophysical Observation", "SAO 149212"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.88603301),
        dec: Angle.Degrees(-17.16633032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216455"},
        {"Hipparcos Number", "HIP 113015"},
        {"Geneva Identification System", "GEN# +1.00216455J"},
        {"Smithsonian Astrophysical Observation", "SAO 165356"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.31335461),
        dec: Angle.Degrees(-17.16516357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197818"},
        {"Hipparcos Number", "HIP 102521"},
        {"Fundamental Katalog 5th Edition", "FK5 5831"},
        {"Geneva Identification System", "GEN# +1.00197818"},
        {"Smithsonian Astrophysical Observation", "SAO 163868"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.64295307),
        dec: Angle.Degrees(-17.16275361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15231"},
        {"Hipparcos Number", "HIP 11398"},
        {"Smithsonian Astrophysical Observation", "SAO 148393"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.71342220),
        dec: Angle.Degrees(-17.16172294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208068"},
        {"Hipparcos Number", "HIP 108095"},
        {"Geneva Identification System", "GEN# +1.00208068"},
        {"Smithsonian Astrophysical Observation", "SAO 164727"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.51579225),
        dec: Angle.Degrees(-17.16141186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 128.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110401",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110401"},
        {"Geneva Identification System", "GEN# -0.01706500"},
    },
    visualMagnitude: 10.68,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.42965543),
        dec: Angle.Degrees(-17.16079405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 374.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -238.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149685"},
        {"Hipparcos Number", "HIP 81366"},
        {"Smithsonian Astrophysical Observation", "SAO 160004"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.25110841),
        dec: Angle.Degrees(-17.16001370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217204"},
        {"Hipparcos Number", "HIP 113504"},
        {"Geneva Identification System", "GEN# +1.00217204"},
        {"Smithsonian Astrophysical Observation", "SAO 165421"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.80233487),
        dec: Angle.Degrees(-17.15947706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164358"},
        {"Hipparcos Number", "HIP 88258"},
        {"Fundamental Katalog 5th Edition", "FK5 1470"},
        {"Geneva Identification System", "GEN# +1.00164358"},
        {"Smithsonian Astrophysical Observation", "SAO 160998"},
        {"Wilson Evans Batten Catalogue", "WEB 14910"},
    },
    visualMagnitude: 6.27,
    bvColour: 1.763,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.34634319),
        dec: Angle.Degrees(-17.15685222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16470"},
        {"Hipparcos Number", "HIP 12274"},
        {"Smithsonian Astrophysical Observation", "SAO 148513"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.51435765),
        dec: Angle.Degrees(-17.15606903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165687"},
        {"Hipparcos Number", "HIP 88816"},
        {"Geneva Identification System", "GEN# +1.00165687"},
        {"Smithsonian Astrophysical Observation", "SAO 161093"},
        {"Wilson Evans Batten Catalogue", "WEB 15048"},
    },
    visualMagnitude: 5.52,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.95168241),
        dec: Angle.Degrees(-17.15430069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174467"},
        {"Hipparcos Number", "HIP 92521"},
        {"Smithsonian Astrophysical Observation", "SAO 161909"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.83284231),
        dec: Angle.Degrees(-17.15428346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84523",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84523"},
        {"Smithsonian Astrophysical Observation", "SAO 160417"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.17681255),
        dec: Angle.Degrees(-17.15318067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168552"},
        {"Hipparcos Number", "HIP 89933"},
        {"Geneva Identification System", "GEN# +1.00168552"},
        {"Smithsonian Astrophysical Observation", "SAO 161368"},
        {"Wilson Evans Batten Catalogue", "WEB 15357"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.25123491),
        dec: Angle.Degrees(-17.15170630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84522",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84522"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.17208924),
        dec: Angle.Degrees(-17.15160380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103632"},
        {"Hipparcos Number", "HIP 58188"},
        {"Fundamental Katalog 5th Edition", "FK5 1309"},
        {"Geneva Identification System", "GEN# +1.00103632"},
        {"Smithsonian Astrophysical Observation", "SAO 156988"},
        {"Wilson Evans Batten Catalogue", "WEB 10416"},
    },
    visualMagnitude: 5.17,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.00409802),
        dec: Angle.Degrees(-17.15080863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109547"},
        {"Hipparcos Number", "HIP 61460"},
        {"Geneva Identification System", "GEN# +1.00109547"},
        {"Smithsonian Astrophysical Observation", "SAO 157381"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.91426207),
        dec: Angle.Degrees(-17.15028596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17288",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2706 AB"},
        {"Henry Draper", "HD 23121"},
        {"Hipparcos Number", "HIP 17288"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.51714092),
        dec: Angle.Degrees(-17.14586681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111446"},
        {"Hipparcos Number", "HIP 62584"},
        {"Smithsonian Astrophysical Observation", "SAO 157533"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.36261183),
        dec: Angle.Degrees(-17.14573880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161116"},
        {"Hipparcos Number", "HIP 86822"},
        {"Geneva Identification System", "GEN# +1.00161116"},
        {"Smithsonian Astrophysical Observation", "SAO 160790"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.10942143),
        dec: Angle.Degrees(-17.14572007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61957"},
        {"Hipparcos Number", "HIP 37439"},
        {"Celescope Catalog", "CEL 1977"},
        {"Geneva Identification System", "GEN# +1.00061957"},
        {"Smithsonian Astrophysical Observation", "SAO 153246"},
    },
    visualMagnitude: 8.00,
    bvColour: -0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.29165428),
        dec: Angle.Degrees(-17.14499110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23559"},
        {"Hipparcos Number", "HIP 17562"},
        {"Geneva Identification System", "GEN# +1.00023559"},
        {"Smithsonian Astrophysical Observation", "SAO 149154"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.41399692),
        dec: Angle.Degrees(-17.14346483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 138.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34447"},
        {"Hipparcos Number", "HIP 24618"},
        {"Geneva Identification System", "GEN# +1.00034447"},
        {"Smithsonian Astrophysical Observation", "SAO 150295"},
        {"Wilson Evans Batten Catalogue", "WEB 4765"},
    },
    visualMagnitude: 6.55,
    bvColour: -0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.20109543),
        dec: Angle.Degrees(-17.14235156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158661"},
        {"Hipparcos Number", "HIP 85734"},
        {"Geneva Identification System", "GEN# +1.00158661"},
        {"Smithsonian Astrophysical Observation", "SAO 160608"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.80346823),
        dec: Angle.Degrees(-17.14214565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87808"},
        {"Hipparcos Number", "HIP 49569"},
        {"Fundamental Katalog 5th Edition", "FK5 2813"},
        {"Geneva Identification System", "GEN# +9.00050010"},
        {"Smithsonian Astrophysical Observation", "SAO 155739"},
        {"Wilson Evans Batten Catalogue", "WEB 9144"},
    },
    visualMagnitude: 5.59,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.78954048),
        dec: Angle.Degrees(-17.14159635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62203"},
        {"Hipparcos Number", "HIP 37537"},
        {"Smithsonian Astrophysical Observation", "SAO 153275"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.55654600),
        dec: Angle.Degrees(-17.11454478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138810"},
        {"Hipparcos Number", "HIP 76287"},
        {"Smithsonian Astrophysical Observation", "SAO 159358"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.74831377),
        dec: Angle.Degrees(-17.13877707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195363"},
        {"Hipparcos Number", "HIP 101244"},
        {"Smithsonian Astrophysical Observation", "SAO 163650"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.83453482),
        dec: Angle.Degrees(-17.13863732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223032"},
        {"Hipparcos Number", "HIP 117225"},
        {"Smithsonian Astrophysical Observation", "SAO 165870"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.51932049),
        dec: Angle.Degrees(-17.13604547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106161"},
        {"Hipparcos Number", "HIP 59573"},
        {"Smithsonian Astrophysical Observation", "SAO 157152"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.23965580),
        dec: Angle.Degrees(-17.13565626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144805"},
        {"Hipparcos Number", "HIP 79061"},
        {"Smithsonian Astrophysical Observation", "SAO 159727"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.796,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.07089805),
        dec: Angle.Degrees(-17.13480008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115642"},
        {"Hipparcos Number", "HIP 64944"},
        {"Geneva Identification System", "GEN# +1.00115642"},
        {"Smithsonian Astrophysical Observation", "SAO 157846"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.68899746),
        dec: Angle.Degrees(-17.13370587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101985"},
        {"Hipparcos Number", "HIP 57236"},
        {"Smithsonian Astrophysical Observation", "SAO 156863"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.03744369),
        dec: Angle.Degrees(-17.13331703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97182"},
        {"Hipparcos Number", "HIP 54649"},
        {"Smithsonian Astrophysical Observation", "SAO 156516"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.78548281),
        dec: Angle.Degrees(-17.13239852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30666"},
        {"Hipparcos Number", "HIP 22374"},
        {"Smithsonian Astrophysical Observation", "SAO 149906"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.24622377),
        dec: Angle.Degrees(-17.12964371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39265"},
        {"Hipparcos Number", "HIP 27606"},
        {"Smithsonian Astrophysical Observation", "SAO 150861"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.67241532),
        dec: Angle.Degrees(-17.12893031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75423",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75423"},
    },
    visualMagnitude: 11.62,
    bvColour: 0.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.19144217),
        dec: Angle.Degrees(-17.12710528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -324.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -195.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16288"},
        {"Hipparcos Number", "HIP 12140"},
        {"Smithsonian Astrophysical Observation", "SAO 148498"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.10994319),
        dec: Angle.Degrees(-17.12584362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68837"},
        {"Hipparcos Number", "HIP 40287"},
        {"Smithsonian Astrophysical Observation", "SAO 153999"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.40348704),
        dec: Angle.Degrees(-17.12479364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107524",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107524"},
    },
    visualMagnitude: 10.91,
    bvColour: 0.752,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.65621393),
        dec: Angle.Degrees(-17.12270361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 156.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196413"},
        {"Hipparcos Number", "HIP 101799"},
        {"Smithsonian Astrophysical Observation", "SAO 163746"},
    },
    visualMagnitude: 7.09,
    bvColour: -0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.45380584),
        dec: Angle.Degrees(-17.12241263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25311",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25311"},
        {"Smithsonian Astrophysical Observation", "SAO 150419"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.20688750),
        dec: Angle.Degrees(-17.11563738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60639"},
        {"Hipparcos Number", "HIP 36881"},
        {"Smithsonian Astrophysical Observation", "SAO 153094"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.72836783),
        dec: Angle.Degrees(-17.11429224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199143"},
        {"Hipparcos Number", "HIP 103311"},
        {"Geneva Identification System", "GEN# +1.00199143"},
        {"Smithsonian Astrophysical Observation", "SAO 163989"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.94849197),
        dec: Angle.Degrees(-17.11402614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14613"},
        {"Hipparcos Number", "HIP 10962"},
        {"Smithsonian Astrophysical Observation", "SAO 148344"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.30518047),
        dec: Angle.Degrees(-17.11244031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140919"},
        {"Hipparcos Number", "HIP 77297"},
        {"Smithsonian Astrophysical Observation", "SAO 159489"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.71759559),
        dec: Angle.Degrees(-17.10868643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20806",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3239 AB"},
        {"Henry Draper", "HD 28338"},
        {"Hipparcos Number", "HIP 20806"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.88274262),
        dec: Angle.Degrees(-17.10865643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191322"},
        {"Hipparcos Number", "HIP 99349"},
        {"Smithsonian Astrophysical Observation", "SAO 163304"},
    },
    visualMagnitude: 9.01,
    bvColour: -0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.47072619),
        dec: Angle.Degrees(-17.10729036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34012"},
        {"Hipparcos Number", "HIP 24354"},
        {"Geneva Identification System", "GEN# +1.00034012"},
        {"Smithsonian Astrophysical Observation", "SAO 150253"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.38685717),
        dec: Angle.Degrees(-17.10646323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179447"},
        {"Hipparcos Number", "HIP 94435"},
        {"Smithsonian Astrophysical Observation", "SAO 162324"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.31361380),
        dec: Angle.Degrees(-17.10573316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167284"},
        {"Hipparcos Number", "HIP 89444"},
        {"Smithsonian Astrophysical Observation", "SAO 161218"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.81488688),
        dec: Angle.Degrees(-17.10479983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93260"},
        {"Hipparcos Number", "HIP 52641"},
        {"Smithsonian Astrophysical Observation", "SAO 156203"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.46801750),
        dec: Angle.Degrees(-17.10074654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223140"},
        {"Hipparcos Number", "HIP 117305"},
        {"Smithsonian Astrophysical Observation", "SAO 165877"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.78083638),
        dec: Angle.Degrees(-17.09943253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51546"},
        {"Hipparcos Number", "HIP 33426"},
        {"Smithsonian Astrophysical Observation", "SAO 152150"},
    },
    visualMagnitude: 6.92,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.26316841),
        dec: Angle.Degrees(-17.09854283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137242"},
        {"Hipparcos Number", "HIP 75506"},
        {"Smithsonian Astrophysical Observation", "SAO 159247"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.35740788),
        dec: Angle.Degrees(-17.09419493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114482"},
        {"Hipparcos Number", "HIP 64326"},
        {"Geneva Identification System", "GEN# +1.00114482"},
        {"Smithsonian Astrophysical Observation", "SAO 157772"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.77223817),
        dec: Angle.Degrees(-17.08977381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142943"},
        {"Hipparcos Number", "HIP 78193"},
        {"Geneva Identification System", "GEN# +1.00142943"},
        {"Smithsonian Astrophysical Observation", "SAO 159605"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.49085536),
        dec: Angle.Degrees(-17.08972788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4718",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 834 C"},
        {"Henry Draper", "HD 5921"},
        {"Hipparcos Number", "HIP 4718"},
        {"Geneva Identification System", "GEN# +1.00005921"},
        {"Smithsonian Astrophysical Observation", "SAO 147565"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.14569677),
        dec: Angle.Degrees(-17.08772895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7751"},
        {"Hipparcos Number", "HIP 5987"},
        {"Geneva Identification System", "GEN# +1.00007751"},
        {"Smithsonian Astrophysical Observation", "SAO 147710"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.24927970),
        dec: Angle.Degrees(-17.08673184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49980"},
        {"Hipparcos Number", "HIP 32809"},
        {"Geneva Identification System", "GEN# +1.00049980"},
        {"Smithsonian Astrophysical Observation", "SAO 151992"},
    },
    visualMagnitude: 5.77,
    bvColour: 1.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.59072133),
        dec: Angle.Degrees(-17.08455798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22455"},
        {"Hipparcos Number", "HIP 16792"},
        {"Smithsonian Astrophysical Observation", "SAO 149060"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.03343140),
        dec: Angle.Degrees(-17.08393079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147136"},
        {"Hipparcos Number", "HIP 80072"},
        {"Smithsonian Astrophysical Observation", "SAO 159868"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.14354745),
        dec: Angle.Degrees(-17.08170006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218061"},
        {"Hipparcos Number", "HIP 113998"},
        {"Fundamental Katalog 5th Edition", "FK5 3846"},
        {"Geneva Identification System", "GEN# +1.00218061"},
        {"Smithsonian Astrophysical Observation", "SAO 165481"},
    },
    visualMagnitude: 6.15,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.30366025),
        dec: Angle.Degrees(-17.07915256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51481"},
        {"Hipparcos Number", "HIP 33414"},
        {"Celescope Catalog", "CEL 1448"},
        {"Geneva Identification System", "GEN# +1.00051481"},
        {"Smithsonian Astrophysical Observation", "SAO 152145"},
    },
    visualMagnitude: 8.44,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.23168888),
        dec: Angle.Degrees(-17.07870123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197144"},
        {"Hipparcos Number", "HIP 102178"},
        {"Smithsonian Astrophysical Observation", "SAO 163808"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.55423457),
        dec: Angle.Degrees(-17.07868212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4027",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4027"},
        {"Smithsonian Astrophysical Observation", "SAO 147482"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.90021730),
        dec: Angle.Degrees(-17.07835560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109319"},
        {"Hipparcos Number", "HIP 61325"},
        {"Smithsonian Astrophysical Observation", "SAO 157366"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.47944496),
        dec: Angle.Degrees(-17.07822593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186780"},
        {"Hipparcos Number", "HIP 97351"},
        {"Geneva Identification System", "GEN# +1.00186780"},
        {"Smithsonian Astrophysical Observation", "SAO 162980"},
        {"Wilson Evans Batten Catalogue", "WEB 17108"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.753,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.78757002),
        dec: Angle.Degrees(-17.07811181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4711",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 834 AB"},
        {"Henry Draper", "HD 5910"},
        {"Hipparcos Number", "HIP 4711"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.13177497),
        dec: Angle.Degrees(-17.07675713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91208"},
        {"Hipparcos Number", "HIP 51533"},
        {"Geneva Identification System", "GEN# +1.00091208"},
        {"Smithsonian Astrophysical Observation", "SAO 156036"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.88816258),
        dec: Angle.Degrees(-17.07655230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120024"},
        {"Hipparcos Number", "HIP 67274"},
        {"Smithsonian Astrophysical Observation", "SAO 158162"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.81677557),
        dec: Angle.Degrees(-17.07601710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126918"},
        {"Hipparcos Number", "HIP 70801"},
        {"Smithsonian Astrophysical Observation", "SAO 158588"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.19236231),
        dec: Angle.Degrees(-17.07561467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4988"},
        {"Hipparcos Number", "HIP 4037"},
        {"Geneva Identification System", "GEN# +1.00004988"},
        {"Smithsonian Astrophysical Observation", "SAO 147484"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.94223572),
        dec: Angle.Degrees(-17.07422340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168352"},
        {"Hipparcos Number", "HIP 89831"},
        {"Geneva Identification System", "GEN# +2.66130015"},
        {"Smithsonian Astrophysical Observation", "SAO 161340"},
        {"Wilson Evans Batten Catalogue", "WEB 15330"},
        {"New General Catalogue", "NGC 6613 15"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.97402040),
        dec: Angle.Degrees(-17.07279362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186892"},
        {"Hipparcos Number", "HIP 97393"},
        {"Geneva Identification System", "GEN# +1.00186892"},
        {"Smithsonian Astrophysical Observation", "SAO 162989"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.91704792),
        dec: Angle.Degrees(-17.07077806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37569"},
        {"Hipparcos Number", "HIP 26552"},
        {"Smithsonian Astrophysical Observation", "SAO 150646"},
    },
    visualMagnitude: 7.98,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.69267137),
        dec: Angle.Degrees(-17.07070537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59631"},
        {"Hipparcos Number", "HIP 36464"},
        {"Smithsonian Astrophysical Observation", "SAO 152971"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.54703178),
        dec: Angle.Degrees(-17.06778776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207891"},
        {"Hipparcos Number", "HIP 107991"},
        {"Smithsonian Astrophysical Observation", "SAO 164705"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.17344659),
        dec: Angle.Degrees(-17.06670726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196557"},
        {"Hipparcos Number", "HIP 101879"},
        {"Smithsonian Astrophysical Observation", "SAO 163760"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.67701582),
        dec: Angle.Degrees(-17.06524573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27298"},
        {"Hipparcos Number", "HIP 20057"},
        {"Smithsonian Astrophysical Observation", "SAO 149522"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.50761285),
        dec: Angle.Degrees(-17.06385434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6816"},
        {"Hipparcos Number", "HIP 5368"},
        {"Smithsonian Astrophysical Observation", "SAO 147633"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.16207228),
        dec: Angle.Degrees(-17.06362783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133709"},
        {"Hipparcos Number", "HIP 73928"},
        {"Smithsonian Astrophysical Observation", "SAO 159024"},
    },
    visualMagnitude: 9.65,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.61440412),
        dec: Angle.Degrees(-17.06349452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22353",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22353"},
        {"Smithsonian Astrophysical Observation", "SAO 149904"},
    },
    visualMagnitude: 9.89,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.18503462),
        dec: Angle.Degrees(-17.06203341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37608",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6315 AB"},
        {"Henry Draper", "HD 62351"},
        {"Hipparcos Number", "HIP 37608"},
        {"Geneva Identification System", "GEN# +1.00062351J"},
        {"Smithsonian Astrophysical Observation", "SAO 153301"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.813,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.74560765),
        dec: Angle.Degrees(-17.06167656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1608",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1608"},
        {"Geneva Identification System", "GEN# +6.10050007"},
    },
    visualMagnitude: 11.67,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.03456191),
        dec: Angle.Degrees(-17.06135622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 135.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218445"},
        {"Hipparcos Number", "HIP 114244"},
        {"Smithsonian Astrophysical Observation", "SAO 165507"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.706,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.06633633),
        dec: Angle.Degrees(-17.05912984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168368"},
        {"Hipparcos Number", "HIP 89842"},
        {"Geneva Identification System", "GEN# +2.66130038"},
        {"Smithsonian Astrophysical Observation", "SAO 161347"},
        {"Wilson Evans Batten Catalogue", "WEB 15334"},
        {"New General Catalogue", "NGC 6613 38"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.01233111),
        dec: Angle.Degrees(-17.05892600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65587"},
        {"Hipparcos Number", "HIP 39003"},
        {"Smithsonian Astrophysical Observation", "SAO 153662"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.72882421),
        dec: Angle.Degrees(-17.05721247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51309"},
        {"Hipparcos Number", "HIP 33347"},
        {"Celescope Catalog", "CEL 1443"},
        {"Fundamental Katalog 5th Edition", "FK5 2536"},
        {"Geneva Identification System", "GEN# +5.11210026"},
        {"Smithsonian Astrophysical Observation", "SAO 152126"},
        {"Wilson Evans Batten Catalogue", "WEB 6700"},
    },
    visualMagnitude: 4.36,
    bvColour: -0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.03427636),
        dec: Angle.Degrees(-17.05424675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43152",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6999 AB"},
        {"Henry Draper", "HD 75098"},
        {"Henry Draper 2", "HD 75099"},
        {"Hipparcos Number", "HIP 43152"},
        {"Smithsonian Astrophysical Observation", "SAO 154636"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.83948881),
        dec: Angle.Degrees(-17.05285288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89777"},
        {"Hipparcos Number", "HIP 50713"},
        {"Cincinnati Publication", "Ci 20 576"},
        {"Geneva Identification System", "GEN# +1.00089777"},
        {"Smithsonian Astrophysical Observation", "SAO 155923"},
        {"Wilson Evans Batten Catalogue", "WEB 9291"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.779,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.32111300),
        dec: Angle.Degrees(-17.04900554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -459.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 119.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20408",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20408"},
        {"Smithsonian Astrophysical Observation", "SAO 149587"},
    },
    visualMagnitude: 9.87,
    bvColour: 1.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.54694262),
        dec: Angle.Degrees(-17.04515412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181289"},
        {"Hipparcos Number", "HIP 95063"},
        {"Smithsonian Astrophysical Observation", "SAO 162487"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.13262018),
        dec: Angle.Degrees(-17.04443348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222331"},
        {"Hipparcos Number", "HIP 116754"},
        {"Smithsonian Astrophysical Observation", "SAO 165817"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.783,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.93451080),
        dec: Angle.Degrees(-17.04032815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8061"},
        {"Hipparcos Number", "HIP 6227"},
        {"Smithsonian Astrophysical Observation", "SAO 147740"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.95746820),
        dec: Angle.Degrees(-17.03806464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20139"},
        {"Hipparcos Number", "HIP 15029"},
        {"Smithsonian Astrophysical Observation", "SAO 148847"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.41814969),
        dec: Angle.Degrees(-17.03452373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65903"},
        {"Hipparcos Number", "HIP 39156"},
        {"Smithsonian Astrophysical Observation", "SAO 153703"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.12603254),
        dec: Angle.Degrees(-17.03382914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12628"},
        {"Hipparcos Number", "HIP 9594"},
        {"Geneva Identification System", "GEN# +1.00012628"},
        {"Smithsonian Astrophysical Observation", "SAO 148173"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.85578213),
        dec: Angle.Degrees(-17.03301839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6885",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6885"},
    },
    visualMagnitude: 11.11,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.16841081),
        dec: Angle.Degrees(-17.03237976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 141.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85165"},
        {"Hipparcos Number", "HIP 48210"},
        {"Smithsonian Astrophysical Observation", "SAO 155518"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.43249683),
        dec: Angle.Degrees(-17.03189081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1498",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1498"},
        {"Smithsonian Astrophysical Observation", "SAO 147210"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.67315035),
        dec: Angle.Degrees(-17.03125843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94270"},
        {"Hipparcos Number", "HIP 53172"},
        {"Geneva Identification System", "GEN# +1.00094270"},
        {"Wilson Evans Batten Catalogue", "WEB 9658"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.16383039),
        dec: Angle.Degrees(-17.02995614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -120.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43516"},
        {"Hipparcos Number", "HIP 29750"},
        {"Geneva Identification System", "GEN# +1.00043516"},
        {"Smithsonian Astrophysical Observation", "SAO 151290"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.98227537),
        dec: Angle.Degrees(-17.02934366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67514",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67514"},
        {"Smithsonian Astrophysical Observation", "SAO 158189"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.50998940),
        dec: Angle.Degrees(-17.02702543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124006"},
        {"Hipparcos Number", "HIP 69314"},
        {"Smithsonian Astrophysical Observation", "SAO 158409"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.80937124),
        dec: Angle.Degrees(-17.02495488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138282"},
        {"Hipparcos Number", "HIP 76022"},
        {"Geneva Identification System", "GEN# +1.00138282"},
        {"Smithsonian Astrophysical Observation", "SAO 159315"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.91286487),
        dec: Angle.Degrees(-17.02312797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74492"},
        {"Hipparcos Number", "HIP 42844"},
        {"Geneva Identification System", "GEN# +1.00074492A"},
        {"Smithsonian Astrophysical Observation", "SAO 154581"},
        {"Wilson Evans Batten Catalogue", "WEB 8279"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.95792824),
        dec: Angle.Degrees(-17.02022256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -137.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147473"},
        {"Hipparcos Number", "HIP 80240"},
        {"Geneva Identification System", "GEN# +1.00147473"},
        {"Smithsonian Astrophysical Observation", "SAO 159888"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.72324640),
        dec: Angle.Degrees(-17.01912633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10460"},
        {"Hipparcos Number", "HIP 7913"},
        {"Smithsonian Astrophysical Observation", "SAO 147963"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.42648793),
        dec: Angle.Degrees(-17.01784967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38100"},
        {"Hipparcos Number", "HIP 26896"},
        {"Smithsonian Astrophysical Observation", "SAO 150725"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.64476573),
        dec: Angle.Degrees(-17.01776986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199542"},
        {"Hipparcos Number", "HIP 103521"},
        {"Smithsonian Astrophysical Observation", "SAO 164024"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.58891536),
        dec: Angle.Degrees(-17.01714689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101694"},
        {"Hipparcos Number", "HIP 57078"},
        {"Geneva Identification System", "GEN# +1.00101694"},
        {"Smithsonian Astrophysical Observation", "SAO 156839"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.51088131),
        dec: Angle.Degrees(-17.01661548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88563"},
        {"Hipparcos Number", "HIP 49998"},
        {"Smithsonian Astrophysical Observation", "SAO 155815"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.11162303),
        dec: Angle.Degrees(-17.01652892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -231.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139061"},
        {"Hipparcos Number", "HIP 76431"},
        {"Geneva Identification System", "GEN# +1.00139061"},
        {"Smithsonian Astrophysical Observation", "SAO 159379"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.14972779),
        dec: Angle.Degrees(-17.01505119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47404"},
        {"Hipparcos Number", "HIP 31683"},
        {"Smithsonian Astrophysical Observation", "SAO 151726"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.755,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.43150451),
        dec: Angle.Degrees(-17.01306598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201807"},
        {"Hipparcos Number", "HIP 104706"},
        {"Smithsonian Astrophysical Observation", "SAO 164215"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.14587420),
        dec: Angle.Degrees(-17.01194409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45916"},
        {"Hipparcos Number", "HIP 30942"},
        {"Smithsonian Astrophysical Observation", "SAO 151561"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.40793687),
        dec: Angle.Degrees(-17.01136105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172680"},
        {"Hipparcos Number", "HIP 91714"},
        {"Smithsonian Astrophysical Observation", "SAO 161738"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.54242729),
        dec: Angle.Degrees(-17.01109471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194156"},
        {"Hipparcos Number", "HIP 100650"},
        {"Smithsonian Astrophysical Observation", "SAO 163538"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.752,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.13200180),
        dec: Angle.Degrees(-17.01082816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24669"},
        {"Hipparcos Number", "HIP 18306"},
        {"Geneva Identification System", "GEN# +1.00024669"},
        {"Smithsonian Astrophysical Observation", "SAO 149249"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.70650139),
        dec: Angle.Degrees(-17.00998020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195494"},
        {"Hipparcos Number", "HIP 101331"},
        {"Smithsonian Astrophysical Observation", "SAO 163660"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.06706458),
        dec: Angle.Degrees(-17.00883993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -153.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45876",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45876"},
        {"Geneva Identification System", "GEN# -0.01602761"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.31552970),
        dec: Angle.Degrees(-17.00606579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 197.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72282"},
        {"Hipparcos Number", "HIP 41797"},
        {"Smithsonian Astrophysical Observation", "SAO 154355"},
    },
    visualMagnitude: 8.85,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.82958932),
        dec: Angle.Degrees(-17.00540431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113667"},
        {"Hipparcos Number", "HIP 63872"},
        {"Smithsonian Astrophysical Observation", "SAO 157705"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.36178313),
        dec: Angle.Degrees(-17.00437108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73561"},
        {"Hipparcos Number", "HIP 42377"},
        {"Geneva Identification System", "GEN# +1.00073561"},
        {"Smithsonian Astrophysical Observation", "SAO 154484"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.60680378),
        dec: Angle.Degrees(-17.00375655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138648"},
        {"Hipparcos Number", "HIP 76203"},
        {"Geneva Identification System", "GEN# +1.00138648"},
        {"Smithsonian Astrophysical Observation", "SAO 159349"},
        {"Wilson Evans Batten Catalogue", "WEB 12940"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.48689119),
        dec: Angle.Degrees(-17.00149091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -323.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5643",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5643"},
        {"Wilson Evans Batten Catalogue", "WEB 1270"},
    },
    visualMagnitude: 12.10,
    bvColour: 1.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.12459256),
        dec: Angle.Degrees(-17.00053959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1210.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 646.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45498"},
        {"Hipparcos Number", "HIP 30693"},
        {"Smithsonian Astrophysical Observation", "SAO 151517"},
    },
    visualMagnitude: 8.16,
    bvColour: -0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.74524678),
        dec: Angle.Degrees(-16.99943963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91581",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91581"},
        {"Geneva Identification System", "GEN# -0.01705283"},
    },
    visualMagnitude: 10.66,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.13784983),
        dec: Angle.Degrees(-16.99933780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -254.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21702"},
        {"Hipparcos Number", "HIP 16259"},
        {"Geneva Identification System", "GEN# +1.00021702"},
        {"Smithsonian Astrophysical Observation", "SAO 148986"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.38704225),
        dec: Angle.Degrees(-16.99884613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 320",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 320"},
    },
    visualMagnitude: 12.14,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.02126840),
        dec: Angle.Degrees(-16.99764075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215916"},
        {"Hipparcos Number", "HIP 112651"},
        {"Smithsonian Astrophysical Observation", "SAO 165313"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.22443859),
        dec: Angle.Degrees(-16.99527207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221706"},
        {"Hipparcos Number", "HIP 116352"},
        {"Cincinnati Publication", "Ci 18 3089"},
        {"Geneva Identification System", "GEN# +1.00221706"},
        {"Smithsonian Astrophysical Observation", "SAO 165777"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.65281491),
        dec: Angle.Degrees(-16.99354549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 141.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 127.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10281"},
        {"Hipparcos Number", "HIP 7788"},
        {"Smithsonian Astrophysical Observation", "SAO 147945"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.06460497),
        dec: Angle.Degrees(-16.98881122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171347"},
        {"Hipparcos Number", "HIP 91112"},
        {"Geneva Identification System", "GEN# +1.00171347"},
        {"Smithsonian Astrophysical Observation", "SAO 161631"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.78284541),
        dec: Angle.Degrees(-16.98553224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11729",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11729"},
        {"Cincinnati Publication", "Ci 20 170"},
        {"Cincinnati Publication 2", "Ci 18 326"},
        {"Geneva Identification System", "GEN# -0.01700484"},
        {"Smithsonian Astrophysical Observation", "SAO 148438"},
        {"Wilson Evans Batten Catalogue", "WEB 2435"},
    },
    visualMagnitude: 10.46,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.85633782),
        dec: Angle.Degrees(-16.98459138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 400.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44396"},
        {"Hipparcos Number", "HIP 30171"},
        {"Geneva Identification System", "GEN# +1.00044396"},
        {"Smithsonian Astrophysical Observation", "SAO 151389"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.801,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.23063639),
        dec: Angle.Degrees(-16.98442407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -176.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76462",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9714 A"},
        {"Henry Draper", "HD 139119"},
        {"Henry Draper 2", "HD 139119A"},
        {"Hipparcos Number", "HIP 76462"},
    },
    visualMagnitude: 12.91,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)36, 57.3500),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)58, 48.700)
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
    primaryId: "HIP 67403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120284"},
        {"Hipparcos Number", "HIP 67403"},
        {"Smithsonian Astrophysical Observation", "SAO 158177"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.21154850),
        dec: Angle.Degrees(-16.98010380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15599"},
        {"Hipparcos Number", "HIP 11632"},
        {"Fundamental Katalog 5th Edition", "FK5 4232"},
        {"Geneva Identification System", "GEN# +1.00015599"},
        {"Smithsonian Astrophysical Observation", "SAO 148427"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.52439936),
        dec: Angle.Degrees(-16.97764742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35505"},
        {"Hipparcos Number", "HIP 25280"},
        {"Geneva Identification System", "GEN# +1.00035505"},
        {"Smithsonian Astrophysical Observation", "SAO 150416"},
    },
    visualMagnitude: 5.64,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.11861918),
        dec: Angle.Degrees(-16.97574213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103039",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103039"},
    },
    visualMagnitude: 11.41,
    bvColour: 1.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.13835215),
        dec: Angle.Degrees(-16.97481280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -306.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18305"},
        {"Hipparcos Number", "HIP 13667"},
        {"Geneva Identification System", "GEN# +1.00018305"},
        {"Smithsonian Astrophysical Observation", "SAO 148675"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.98863731),
        dec: Angle.Degrees(-16.97412449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78954"},
        {"Hipparcos Number", "HIP 45055"},
        {"Geneva Identification System", "GEN# +1.00078954"},
        {"Smithsonian Astrophysical Observation", "SAO 154974"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.64602002),
        dec: Angle.Degrees(-16.97245474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180196"},
        {"Hipparcos Number", "HIP 94706"},
        {"Wilson Evans Batten Catalogue", "WEB 16514"},
    },
    visualMagnitude: 10.78,
    bvColour: 1.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.06016886),
        dec: Angle.Degrees(-16.97138268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5349"},
        {"Hipparcos Number", "HIP 4310"},
        {"Cincinnati Publication", "Ci 18 121"},
        {"Smithsonian Astrophysical Observation", "SAO 147511"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.79943524),
        dec: Angle.Degrees(-16.97108089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -130.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -196.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191577"},
        {"Hipparcos Number", "HIP 99455"},
        {"Smithsonian Astrophysical Observation", "SAO 163317"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.78721110),
        dec: Angle.Degrees(-16.96840027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56284",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56284"},
    },
    visualMagnitude: 11.45,
    bvColour: 1.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.07873348),
        dec: Angle.Degrees(-16.96813919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 169.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -234.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108797",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15562 AB"},
        {"Henry Draper", "HD 209278"},
        {"Hipparcos Number", "HIP 108797"},
        {"Geneva Identification System", "GEN# +1.00209278J"},
        {"Smithsonian Astrophysical Observation", "SAO 164830"},
        {"Wilson Evans Batten Catalogue", "WEB 19571"},
    },
    visualMagnitude: 6.39,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.60935510),
        dec: Angle.Degrees(-16.96483342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134590"},
        {"Hipparcos Number", "HIP 74299"},
        {"Smithsonian Astrophysical Observation", "SAO 159074"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.79855521),
        dec: Angle.Degrees(-16.96459677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126898"},
        {"Hipparcos Number", "HIP 70795"},
        {"Geneva Identification System", "GEN# +1.00126898"},
        {"Smithsonian Astrophysical Observation", "SAO 158586"},
        {"Wilson Evans Batten Catalogue", "WEB 12264"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.17359186),
        dec: Angle.Degrees(-16.96419674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14670"},
        {"Hipparcos Number", "HIP 10998"},
        {"Smithsonian Astrophysical Observation", "SAO 148351"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.42988441),
        dec: Angle.Degrees(-16.96358299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29670"},
        {"Hipparcos Number", "HIP 21715"},
        {"Smithsonian Astrophysical Observation", "SAO 149808"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.93295270),
        dec: Angle.Degrees(-16.96309114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13286"},
        {"Hipparcos Number", "HIP 10063"},
        {"Smithsonian Astrophysical Observation", "SAO 148242"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.38386576),
        dec: Angle.Degrees(-16.96287427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41649"},
        {"Hipparcos Number", "HIP 28877"},
        {"Smithsonian Astrophysical Observation", "SAO 151104"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.45139797),
        dec: Angle.Degrees(-16.95938407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11853"},
        {"Hipparcos Number", "HIP 9010"},
        {"Smithsonian Astrophysical Observation", "SAO 148113"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.00075114),
        dec: Angle.Degrees(-16.95895577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201481"},
        {"Hipparcos Number", "HIP 104524"},
        {"Smithsonian Astrophysical Observation", "SAO 164189"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.59365852),
        dec: Angle.Degrees(-16.95852012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91369"},
        {"Hipparcos Number", "HIP 51614"},
        {"Geneva Identification System", "GEN# +1.00091369"},
        {"Smithsonian Astrophysical Observation", "SAO 156047"},
        {"Wilson Evans Batten Catalogue", "WEB 9416"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.17155215),
        dec: Angle.Degrees(-16.95851436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108881"},
        {"Hipparcos Number", "HIP 61047"},
        {"Smithsonian Astrophysical Observation", "SAO 157331"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.67917852),
        dec: Angle.Degrees(-16.95641407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59985"},
        {"Hipparcos Number", "HIP 36621"},
        {"Geneva Identification System", "GEN# +4.40040015"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.96585273),
        dec: Angle.Degrees(-16.95638878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105779"},
        {"Hipparcos Number", "HIP 59357"},
        {"Smithsonian Astrophysical Observation", "SAO 157127"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.66286453),
        dec: Angle.Degrees(-16.95617877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -237.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104059",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104059"},
        {"Cincinnati Publication", "Ci 20 1257"},
        {"Geneva Identification System", "GEN# +6.10220769"},
    },
    visualMagnitude: 11.45,
    bvColour: 1.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.22474842),
        dec: Angle.Degrees(-16.95391715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -914.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2035.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87514"},
        {"Hipparcos Number", "HIP 49409"},
        {"Geneva Identification System", "GEN# +1.00087514"},
        {"Smithsonian Astrophysical Observation", "SAO 155715"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.806,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.29641261),
        dec: Angle.Degrees(-16.95386277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65846"},
        {"Hipparcos Number", "HIP 39115"},
        {"Smithsonian Astrophysical Observation", "SAO 153689"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.04282484),
        dec: Angle.Degrees(-16.95341283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106932"},
        {"Hipparcos Number", "HIP 59964"},
        {"Smithsonian Astrophysical Observation", "SAO 157194"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.47854121),
        dec: Angle.Degrees(-16.95268328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76027"},
        {"Hipparcos Number", "HIP 43623"},
        {"Smithsonian Astrophysical Observation", "SAO 154714"},
    },
    visualMagnitude: 6.43,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.27227715),
        dec: Angle.Degrees(-16.95234812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140721"},
        {"Hipparcos Number", "HIP 77203"},
        {"Geneva Identification System", "GEN# +1.00140721"},
        {"Smithsonian Astrophysical Observation", "SAO 159481"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.46030210),
        dec: Angle.Degrees(-16.95071677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112"},
    },
    visualMagnitude: 10.76,
    bvColour: 1.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.35691658),
        dec: Angle.Degrees(-16.94782618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 299.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -255.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95532"},
        {"Hipparcos Number", "HIP 53886"},
        {"Geneva Identification System", "GEN# +1.00095532"},
        {"Smithsonian Astrophysical Observation", "SAO 156406"},
        {"Wilson Evans Batten Catalogue", "WEB 9755"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.37102961),
        dec: Angle.Degrees(-16.94599264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144569"},
        {"Hipparcos Number", "HIP 78956"},
        {"Geneva Identification System", "GEN# +1.00144569"},
        {"Smithsonian Astrophysical Observation", "SAO 159704"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.76950050),
        dec: Angle.Degrees(-16.94321766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46066"},
        {"Hipparcos Number", "HIP 31004"},
        {"Geneva Identification System", "GEN# +1.00046066"},
        {"Smithsonian Astrophysical Observation", "SAO 151580"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.59962070),
        dec: Angle.Degrees(-16.94301096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172984"},
        {"Hipparcos Number", "HIP 91884"},
        {"Smithsonian Astrophysical Observation", "SAO 161772"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.96516594),
        dec: Angle.Degrees(-16.94153935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16993"},
        {"Hipparcos Number", "HIP 12697"},
        {"Smithsonian Astrophysical Observation", "SAO 148566"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.77482144),
        dec: Angle.Degrees(-16.93686664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54765"},
        {"Hipparcos Number", "HIP 34553"},
        {"Celescope Catalog", "CEL 1622"},
        {"Geneva Identification System", "GEN# +1.00054765"},
        {"Smithsonian Astrophysical Observation", "SAO 152475"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.37610845),
        dec: Angle.Degrees(-16.93642457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
