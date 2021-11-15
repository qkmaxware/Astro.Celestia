using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_85() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41994"},
        {"Hipparcos Number", "HIP 29188"},
        {"Smithsonian Astrophysical Observation", "SAO 78041"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.36064840),
        dec: Angle.Degrees(+27.19389668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153897"},
        {"Hipparcos Number", "HIP 83274"},
        {"Geneva Identification System", "GEN# +1.00153897"},
        {"Renson", "Renson 43460"},
        {"Smithsonian Astrophysical Observation", "SAO 84765"},
        {"Wilson Evans Batten Catalogue", "WEB 14075"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.29012836),
        dec: Angle.Degrees(+27.19667246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84077"},
        {"Hipparcos Number", "HIP 47672"},
        {"Smithsonian Astrophysical Observation", "SAO 80982"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.81093324),
        dec: Angle.Degrees(+27.19746922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24970"},
        {"Hipparcos Number", "HIP 18621"},
        {"Geneva Identification System", "GEN# +1.00024970"},
        {"Smithsonian Astrophysical Observation", "SAO 76365"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.77270585),
        dec: Angle.Degrees(+27.19748316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113938"},
        {"Hipparcos Number", "HIP 63989"},
        {"Smithsonian Astrophysical Observation", "SAO 82654"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.69600862),
        dec: Angle.Degrees(+27.20014358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70968",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70968"},
    },
    visualMagnitude: 10.46,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.73914806),
        dec: Angle.Degrees(+27.20065489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109618",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109618"},
        {"Smithsonian Astrophysical Observation", "SAO 90319"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.08987674),
        dec: Angle.Degrees(+27.20229398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31294"},
        {"Hipparcos Number", "HIP 22903"},
        {"Smithsonian Astrophysical Observation", "SAO 76841"},
        {"Wilson Evans Batten Catalogue", "WEB 4443"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.89419286),
        dec: Angle.Degrees(+27.20248640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191312"},
        {"Hipparcos Number", "HIP 99197"},
        {"Smithsonian Astrophysical Observation", "SAO 88234"},
    },
    visualMagnitude: 7.87,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.08031789),
        dec: Angle.Degrees(+27.20525834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153061"},
        {"Hipparcos Number", "HIP 82873"},
        {"Smithsonian Astrophysical Observation", "SAO 84701"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.04388057),
        dec: Angle.Degrees(+27.20578144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 250448"},
        {"Hipparcos Number", "HIP 28584"},
        {"Smithsonian Astrophysical Observation", "SAO 77864"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.51493273),
        dec: Angle.Degrees(+27.20675100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 336089"},
        {"Hipparcos Number", "HIP 90447"},
        {"Geneva Identification System", "GEN# +1.00336089"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.82678136),
        dec: Angle.Degrees(+27.20897936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5382"},
        {"Hipparcos Number", "HIP 4366"},
        {"Fundamental Katalog 5th Edition", "FK5 2059"},
        {"Geneva Identification System", "GEN# +1.00005382"},
        {"Smithsonian Astrophysical Observation", "SAO 74373"},
        {"Wilson Evans Batten Catalogue", "WEB 780"},
    },
    visualMagnitude: 6.08,
    bvColour: 0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.99384283),
        dec: Angle.Degrees(+27.20935396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43624"},
        {"Hipparcos Number", "HIP 29955"},
        {"Geneva Identification System", "GEN# +1.00043624"},
        {"Smithsonian Astrophysical Observation", "SAO 78196"},
        {"Wilson Evans Batten Catalogue", "WEB 5938"},
    },
    visualMagnitude: 6.66,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.58660196),
        dec: Angle.Degrees(+27.21031345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191474"},
        {"Hipparcos Number", "HIP 99274"},
        {"Smithsonian Astrophysical Observation", "SAO 88254"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.27751846),
        dec: Angle.Degrees(+27.21080442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204079"},
        {"Hipparcos Number", "HIP 105791"},
        {"Geneva Identification System", "GEN# +1.00204079"},
        {"Smithsonian Astrophysical Observation", "SAO 89701"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.828,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.37124758),
        dec: Angle.Degrees(+27.21108272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -149.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -164.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90567"},
        {"Hipparcos Number", "HIP 51235"},
        {"Geneva Identification System", "GEN# +1.00090567"},
        {"Smithsonian Astrophysical Observation", "SAO 81362"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.98013617),
        dec: Angle.Degrees(+27.21128616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77444"},
        {"Hipparcos Number", "HIP 44438"},
        {"Smithsonian Astrophysical Observation", "SAO 80598"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.81274385),
        dec: Angle.Degrees(+27.21133350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171830"},
        {"Hipparcos Number", "HIP 91152"},
        {"Fundamental Katalog 5th Edition", "FK5 5634"},
        {"Smithsonian Astrophysical Observation", "SAO 86226"},
        {"Wilson Evans Batten Catalogue", "WEB 15654"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.94203170),
        dec: Angle.Degrees(+27.21154835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138231"},
        {"Hipparcos Number", "HIP 75880"},
        {"Smithsonian Astrophysical Observation", "SAO 83853"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.48857958),
        dec: Angle.Degrees(+27.21214150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195835"},
        {"Hipparcos Number", "HIP 101381"},
        {"Smithsonian Astrophysical Observation", "SAO 88820"},
        {"Wilson Evans Batten Catalogue", "WEB 18318"},
    },
    visualMagnitude: 6.89,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.21320211),
        dec: Angle.Degrees(+27.21216372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 338266"},
        {"Hipparcos Number", "HIP 95387"},
        {"Geneva Identification System", "GEN# +1.00338266"},
        {"Renson", "Renson 50500"},
        {"Smithsonian Astrophysical Observation", "SAO 87162"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.07180366),
        dec: Angle.Degrees(+27.21468804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208750"},
        {"Hipparcos Number", "HIP 108423"},
        {"Geneva Identification System", "GEN# +1.00208750"},
        {"Smithsonian Astrophysical Observation", "SAO 90137"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.46379933),
        dec: Angle.Degrees(+27.21551307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7894",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7894"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.39066763),
        dec: Angle.Degrees(+27.21790380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69897"},
        {"Hipparcos Number", "HIP 40843"},
        {"Fundamental Katalog 5th Edition", "FK5 1217"},
        {"Geneva Identification System", "GEN# +1.00069897"},
        {"Smithsonian Astrophysical Observation", "SAO 80104"},
        {"Wilson Evans Batten Catalogue", "WEB 7923"},
    },
    visualMagnitude: 5.13,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.01613464),
        dec: Angle.Degrees(+27.21862138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -376.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115877",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115877"},
        {"Smithsonian Astrophysical Observation", "SAO 91289"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.14972314),
        dec: Angle.Degrees(+27.21975908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74260"},
        {"Hipparcos Number", "HIP 42852"},
        {"Smithsonian Astrophysical Observation", "SAO 80385"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.98006504),
        dec: Angle.Degrees(+27.22410763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34860",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5871 AB"},
        {"Henry Draper", "HD 55130"},
        {"Hipparcos Number", "HIP 34860"},
        {"Geneva Identification System", "GEN# +1.00055130"},
        {"Smithsonian Astrophysical Observation", "SAO 79170"},
        {"Wilson Evans Batten Catalogue", "WEB 6966"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.20449197),
        dec: Angle.Degrees(+27.22506034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184761"},
        {"Hipparcos Number", "HIP 96313"},
        {"Smithsonian Astrophysical Observation", "SAO 87388"},
        {"Wilson Evans Batten Catalogue", "WEB 16887"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.74554324),
        dec: Angle.Degrees(+27.22525224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141269"},
        {"Hipparcos Number", "HIP 77324"},
        {"Smithsonian Astrophysical Observation", "SAO 84001"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.79866973),
        dec: Angle.Degrees(+27.22533392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99107"},
        {"Hipparcos Number", "HIP 55680"},
        {"Smithsonian Astrophysical Observation", "SAO 81807"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.13258755),
        dec: Angle.Degrees(+27.22624656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119944"},
        {"Hipparcos Number", "HIP 67168"},
        {"Geneva Identification System", "GEN# +1.00119944"},
        {"Smithsonian Astrophysical Observation", "SAO 82987"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.46753094),
        dec: Angle.Degrees(+27.22638864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81130",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81130"},
    },
    visualMagnitude: 10.62,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.53287551),
        dec: Angle.Degrees(+27.22741156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 246878"},
        {"Hipparcos Number", "HIP 27071"},
        {"Smithsonian Astrophysical Observation", "SAO 77479"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.11552506),
        dec: Angle.Degrees(+27.22992108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54644",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54644"},
        {"Smithsonian Astrophysical Observation", "SAO 81709"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.76258460),
        dec: Angle.Degrees(+27.23085858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158166"},
        {"Hipparcos Number", "HIP 85361"},
        {"Geneva Identification System", "GEN# +1.00158166"},
        {"Smithsonian Astrophysical Observation", "SAO 85093"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.64874951),
        dec: Angle.Degrees(+27.23095129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9816"},
        {"Hipparcos Number", "HIP 7482"},
        {"Geneva Identification System", "GEN# +1.00009816"},
        {"Smithsonian Astrophysical Observation", "SAO 74816"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.08929343),
        dec: Angle.Degrees(+27.23331948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98263",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13176 C"},
        {"Henry Draper", "HD 189236"},
        {"Hipparcos Number", "HIP 98263"},
        {"Smithsonian Astrophysical Observation", "SAO 87992"},
    },
    visualMagnitude: 7.98,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.49716130),
        dec: Angle.Degrees(+27.23339441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62752",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8686 AB"},
        {"Henry Draper", "HD 111782"},
        {"Hipparcos Number", "HIP 62752"},
        {"Geneva Identification System", "GEN# +1.00111782J"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.86547108),
        dec: Angle.Degrees(+27.23378865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184998"},
        {"Hipparcos Number", "HIP 96414"},
        {"Geneva Identification System", "GEN# +1.00184998"},
        {"Smithsonian Astrophysical Observation", "SAO 87429"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.02763196),
        dec: Angle.Degrees(+27.23402946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51823",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51823"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.81136516),
        dec: Angle.Degrees(+27.23487702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7287",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7287"},
    },
    visualMagnitude: 11.03,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.47211684),
        dec: Angle.Degrees(+27.23627661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 486.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -210.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 337297"},
        {"Hipparcos Number", "HIP 93247"},
        {"Smithsonian Astrophysical Observation", "SAO 86671"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.90833474),
        dec: Angle.Degrees(+27.23763564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12954"},
        {"Hipparcos Number", "HIP 9897"},
        {"Smithsonian Astrophysical Observation", "SAO 75153"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.83593788),
        dec: Angle.Degrees(+27.23765018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107537",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107537"},
        {"Smithsonian Astrophysical Observation", "SAO 89983"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.70408718),
        dec: Angle.Degrees(+27.23804521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 241665"},
        {"Hipparcos Number", "HIP 24370"},
        {"Smithsonian Astrophysical Observation", "SAO 77040"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.43809258),
        dec: Angle.Degrees(+27.24008567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176870"},
        {"Hipparcos Number", "HIP 93386"},
        {"Geneva Identification System", "GEN# +1.00176870"},
        {"Smithsonian Astrophysical Observation", "SAO 86703"},
    },
    visualMagnitude: 8.27,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.30641134),
        dec: Angle.Degrees(+27.24103642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86981",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86981"},
        {"Smithsonian Astrophysical Observation", "SAO 85398"},
    },
    visualMagnitude: 9.74,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.62528143),
        dec: Angle.Degrees(+27.24575935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8747"},
        {"Hipparcos Number", "HIP 6736"},
        {"Smithsonian Astrophysical Observation", "SAO 74721"},
        {"Wilson Evans Batten Catalogue", "WEB 1470"},
    },
    visualMagnitude: 6.75,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.68242416),
        dec: Angle.Degrees(+27.24670400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188172"},
        {"Hipparcos Number", "HIP 97844"},
        {"Geneva Identification System", "GEN# +1.00188172"},
        {"Smithsonian Astrophysical Observation", "SAO 87865"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.25108087),
        dec: Angle.Degrees(+27.24986852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98248",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13176 AB"},
        {"Henry Draper", "HD 189214"},
        {"Hipparcos Number", "HIP 98248"},
        {"Smithsonian Astrophysical Observation", "SAO 87988"},
    },
    visualMagnitude: 7.56,
    bvColour: -0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.47688973),
        dec: Angle.Degrees(+27.25202702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 262389"},
        {"Hipparcos Number", "HIP 32209"},
    },
    visualMagnitude: 10.92,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.84807429),
        dec: Angle.Degrees(+27.25233497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56513"},
        {"Hipparcos Number", "HIP 35377"},
        {"Cincinnati Publication", "Ci 18 876"},
        {"Geneva Identification System", "GEN# +1.00056513"},
        {"Smithsonian Astrophysical Observation", "SAO 79264"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.61985651),
        dec: Angle.Degrees(+27.25323579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 156.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -157.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3322"},
        {"Hipparcos Number", "HIP 2865"},
        {"Geneva Identification System", "GEN# +1.00003322"},
        {"Renson", "Renson 900"},
        {"Smithsonian Astrophysical Observation", "SAO 74136"},
        {"Wilson Evans Batten Catalogue", "WEB 517"},
    },
    visualMagnitude: 6.51,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.08370140),
        dec: Angle.Degrees(+27.25479152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283749"},
        {"Hipparcos Number", "HIP 21478"},
        {"Geneva Identification System", "GEN# +1.00283749"},
        {"Smithsonian Astrophysical Observation", "SAO 76671"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.18575047),
        dec: Angle.Degrees(+27.25541829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19832"},
        {"Hipparcos Number", "HIP 14893"},
        {"Celescope Catalog", "CEL 304"},
        {"Geneva Identification System", "GEN# +1.00019832"},
        {"Renson", "Renson 4910"},
        {"Smithsonian Astrophysical Observation", "SAO 75788"},
        {"Wilson Evans Batten Catalogue", "WEB 2874"},
    },
    visualMagnitude: 5.78,
    bvColour: -0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.05932746),
        dec: Angle.Degrees(+27.25701296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202696"},
        {"Hipparcos Number", "HIP 105056"},
        {"Smithsonian Astrophysical Observation", "SAO 89576"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.22467822),
        dec: Angle.Degrees(+27.25803456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174963"},
        {"Hipparcos Number", "HIP 92598"},
        {"Geneva Identification System", "GEN# +1.00174963"},
        {"Smithsonian Astrophysical Observation", "SAO 86520"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.02909685),
        dec: Angle.Degrees(+27.26016627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56416",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56416"},
        {"Geneva Identification System", "GEN# +0.02802014"},
        {"Smithsonian Astrophysical Observation", "SAO 81878"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.49515661),
        dec: Angle.Degrees(+27.26020273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15349"},
        {"Hipparcos Number", "HIP 11554"},
        {"Smithsonian Astrophysical Observation", "SAO 75393"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.21814265),
        dec: Angle.Degrees(+27.26069952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13209",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Bharani"},
        {"Aitken", "ADS 2159 A"},
        {"Henry Draper", "HD 17573"},
        {"Hipparcos Number", "HIP 13209"},
        {"Fundamental Katalog 5th Edition", "FK5 100"},
        {"Geneva Identification System", "GEN# +1.00017573A"},
        {"Smithsonian Astrophysical Observation", "SAO 75596"},
        {"Wilson Evans Batten Catalogue", "WEB 2655"},
    },
    visualMagnitude: 3.61,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.49578911),
        dec: Angle.Degrees(+27.26079044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181330"},
        {"Hipparcos Number", "HIP 94937"},
        {"Smithsonian Astrophysical Observation", "SAO 87061"},
        {"Wilson Evans Batten Catalogue", "WEB 16576"},
    },
    visualMagnitude: 6.77,
    bvColour: 1.865,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.77357247),
        dec: Angle.Degrees(+27.26131196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53243",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53243"},
        {"Smithsonian Astrophysical Observation", "SAO 81566"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.35785678),
        dec: Angle.Degrees(+27.26356831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68381",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68381"},
        {"Smithsonian Astrophysical Observation", "SAO 83120"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.95849923),
        dec: Angle.Degrees(+27.26374341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7964"},
        {"Hipparcos Number", "HIP 6193"},
        {"Fundamental Katalog 5th Edition", "FK5 45"},
        {"Geneva Identification System", "GEN# +1.00007964"},
        {"Smithsonian Astrophysical Observation", "SAO 74637"},
        {"Wilson Evans Batten Catalogue", "WEB 1390"},
    },
    visualMagnitude: 4.74,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.86657455),
        dec: Angle.Degrees(+27.26408682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49046",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49046"},
    },
    visualMagnitude: 11.24,
    bvColour: 1.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.11135010),
        dec: Angle.Degrees(+27.26683388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 116.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33765",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5671 AB"},
        {"Henry Draper", "HD 267648"},
        {"Hipparcos Number", "HIP 33765"},
        {"Smithsonian Astrophysical Observation", "SAO 78962"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.18764849),
        dec: Angle.Degrees(+27.26781712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108283"},
        {"Hipparcos Number", "HIP 60697"},
        {"Fundamental Katalog 5th Edition", "FK5 2997"},
        {"Geneva Identification System", "GEN# +5.21110125"},
        {"Renson", "Renson 31440"},
        {"Smithsonian Astrophysical Observation", "SAO 82310"},
        {"Wilson Evans Batten Catalogue", "WEB 10793"},
    },
    visualMagnitude: 4.92,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.60030726),
        dec: Angle.Degrees(+27.26826273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224615"},
        {"Hipparcos Number", "HIP 118267"},
        {"Smithsonian Astrophysical Observation", "SAO 91635"},
        {"Wilson Evans Batten Catalogue", "WEB 20786"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.82369287),
        dec: Angle.Degrees(+27.27003108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126268"},
        {"Hipparcos Number", "HIP 70372"},
        {"Smithsonian Astrophysical Observation", "SAO 83325"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.96782420),
        dec: Angle.Degrees(+27.27080384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200860"},
        {"Hipparcos Number", "HIP 104094"},
        {"Smithsonian Astrophysical Observation", "SAO 89443"},
        {"Wilson Evans Batten Catalogue", "WEB 18961"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.34405198),
        dec: Angle.Degrees(+27.27097236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -165.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -150.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66900",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66900"},
        {"Geneva Identification System", "GEN# +0.02802252"},
        {"Smithsonian Astrophysical Observation", "SAO 82958"},
    },
    visualMagnitude: 9.70,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.64688106),
        dec: Angle.Degrees(+27.27124927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76265",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76265"},
        {"Smithsonian Astrophysical Observation", "SAO 83892"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.66480222),
        dec: Angle.Degrees(+27.27142642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40460"},
        {"Hipparcos Number", "HIP 28417"},
        {"Geneva Identification System", "GEN# +1.00040460"},
        {"Smithsonian Astrophysical Observation", "SAO 77819"},
        {"Wilson Evans Batten Catalogue", "WEB 5554"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.02519398),
        dec: Angle.Degrees(+27.27237095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17760"},
        {"Hipparcos Number", "HIP 13356"},
        {"Smithsonian Astrophysical Observation", "SAO 75605"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.96138480),
        dec: Angle.Degrees(+27.27390640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137760"},
        {"Hipparcos Number", "HIP 75610"},
        {"Smithsonian Astrophysical Observation", "SAO 83825"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.72815517),
        dec: Angle.Degrees(+27.27698746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283697"},
        {"Hipparcos Number", "HIP 20964"},
        {"Geneva Identification System", "GEN# +1.00283697"},
        {"Smithsonian Astrophysical Observation", "SAO 76629"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.42943674),
        dec: Angle.Degrees(+27.27715766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31568",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5234 AB"},
        {"Henry Draper", "HD 46780"},
        {"Hipparcos Number", "HIP 31568"},
        {"Geneva Identification System", "GEN# +1.00046780J"},
        {"Smithsonian Astrophysical Observation", "SAO 78540"},
        {"Wilson Evans Batten Catalogue", "WEB 6313"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.10940934),
        dec: Angle.Degrees(+27.27862005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 340795"},
        {"Hipparcos Number", "HIP 101982"},
        {"Geneva Identification System", "GEN# +1.00340795"},
        {"Smithsonian Astrophysical Observation", "SAO 88982"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.00699063),
        dec: Angle.Degrees(+27.27928392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105805"},
        {"Hipparcos Number", "HIP 59364"},
        {"Geneva Identification System", "GEN# +5.21110010"},
        {"Smithsonian Astrophysical Observation", "SAO 82166"},
        {"Wilson Evans Batten Catalogue", "WEB 10559"},
    },
    visualMagnitude: 6.01,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.69209512),
        dec: Angle.Degrees(+27.28152850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 250285"},
        {"Hipparcos Number", "HIP 28528"},
        {"Smithsonian Astrophysical Observation", "SAO 77845"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.32608128),
        dec: Angle.Degrees(+27.28162613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1083"},
        {"Hipparcos Number", "HIP 1215"},
        {"Geneva Identification System", "GEN# +1.00001083"},
        {"Smithsonian Astrophysical Observation", "SAO 73842"},
        {"Wilson Evans Batten Catalogue", "WEB 219"},
    },
    visualMagnitude: 6.35,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.79397762),
        dec: Angle.Degrees(+27.28347715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156966"},
        {"Hipparcos Number", "HIP 84744"},
        {"Geneva Identification System", "GEN# +1.00156966"},
        {"Smithsonian Astrophysical Observation", "SAO 85005"},
        {"Wilson Evans Batten Catalogue", "WEB 14307"},
    },
    visualMagnitude: 6.80,
    bvColour: 1.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.85029389),
        dec: Angle.Degrees(+27.28385668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192261"},
        {"Hipparcos Number", "HIP 99617"},
        {"Smithsonian Astrophysical Observation", "SAO 88360"},
    },
    visualMagnitude: 7.80,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.24389065),
        dec: Angle.Degrees(+27.28442755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93762",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12032 AB"},
        {"Henry Draper", "HD 177936"},
        {"Hipparcos Number", "HIP 93762"},
        {"Smithsonian Astrophysical Observation", "SAO 86795"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.41320545),
        dec: Angle.Degrees(+27.28521416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5279",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5279"},
        {"Smithsonian Astrophysical Observation", "SAO 74501"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.87909902),
        dec: Angle.Degrees(+27.28547800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50816"},
        {"Hipparcos Number", "HIP 33331"},
        {"Fundamental Katalog 5th Edition", "FK5 4629"},
        {"Smithsonian Astrophysical Observation", "SAO 78876"},
    },
    visualMagnitude: 7.21,
    bvColour: -0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.98417107),
        dec: Angle.Degrees(+27.28587948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91753"},
        {"Hipparcos Number", "HIP 51893"},
        {"Smithsonian Astrophysical Observation", "SAO 81432"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.03211228),
        dec: Angle.Degrees(+27.28642504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118743"},
        {"Hipparcos Number", "HIP 66538"},
        {"Geneva Identification System", "GEN# +1.00118743"},
        {"Smithsonian Astrophysical Observation", "SAO 82918"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.58920132),
        dec: Angle.Degrees(+27.28711522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 254362"},
        {"Hipparcos Number", "HIP 29866"},
        {"Smithsonian Astrophysical Observation", "SAO 78180"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.33349140),
        dec: Angle.Degrees(+27.29066511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69999",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69999"},
        {"Geneva Identification System", "GEN# +0.02702364"},
    },
    visualMagnitude: 10.36,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.85898700),
        dec: Angle.Degrees(+27.29078678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -230.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58683"},
        {"Hipparcos Number", "HIP 36243"},
        {"Cincinnati Publication", "Ci 18 888"},
        {"Geneva Identification System", "GEN# +1.00058683"},
        {"Smithsonian Astrophysical Observation", "SAO 79402"},
        {"Wilson Evans Batten Catalogue", "WEB 7218"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.925,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.95381943),
        dec: Angle.Degrees(+27.29273451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38009"},
        {"Hipparcos Number", "HIP 27016"},
        {"Geneva Identification System", "GEN# +1.00038009"},
        {"Smithsonian Astrophysical Observation", "SAO 77466"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.95418051),
        dec: Angle.Degrees(+27.29606871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94055"},
        {"Hipparcos Number", "HIP 53092"},
        {"Geneva Identification System", "GEN# +1.00094055"},
        {"Smithsonian Astrophysical Observation", "SAO 81557"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.92778550),
        dec: Angle.Degrees(+27.29666479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79782",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79782"},
        {"Smithsonian Astrophysical Observation", "SAO 84284"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.23112155),
        dec: Angle.Degrees(+27.29679662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58578"},
        {"Hipparcos Number", "HIP 36197"},
        {"Geneva Identification System", "GEN# +1.00058578"},
        {"Smithsonian Astrophysical Observation", "SAO 79394"},
        {"Wilson Evans Batten Catalogue", "WEB 7207"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.82014313),
        dec: Angle.Degrees(+27.29875405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201669"},
        {"Hipparcos Number", "HIP 104517"},
        {"Smithsonian Astrophysical Observation", "SAO 89502"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.56634449),
        dec: Angle.Degrees(+27.29970000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106999"},
        {"Hipparcos Number", "HIP 59988"},
        {"Geneva Identification System", "GEN# +5.21110052"},
        {"Renson", "Renson 30950"},
        {"Smithsonian Astrophysical Observation", "SAO 82227"},
        {"Wilson Evans Batten Catalogue", "WEB 10662"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.54679651),
        dec: Angle.Degrees(+27.30055882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141811"},
        {"Hipparcos Number", "HIP 77553"},
    },
    visualMagnitude: 10.43,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.51195769),
        dec: Angle.Degrees(+27.30144423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158038"},
        {"Hipparcos Number", "HIP 85294"},
        {"Geneva Identification System", "GEN# +1.00158038"},
        {"Smithsonian Astrophysical Observation", "SAO 85078"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.43915582),
        dec: Angle.Degrees(+27.30348425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 265730"},
        {"Hipparcos Number", "HIP 33149"},
        {"Smithsonian Astrophysical Observation", "SAO 78845"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.53114589),
        dec: Angle.Degrees(+27.30468639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94474",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94474"},
        {"Wilson Evans Batten Catalogue", "WEB 16469"},
    },
    visualMagnitude: 9.87,
    bvColour: 2.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.41529016),
        dec: Angle.Degrees(+27.30611018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57958",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57958"},
        {"Smithsonian Astrophysical Observation", "SAO 82031"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.31435561),
        dec: Angle.Degrees(+27.30761015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107611"},
        {"Hipparcos Number", "HIP 60304"},
        {"Geneva Identification System", "GEN# +5.21110086"},
        {"Smithsonian Astrophysical Observation", "SAO 82269"},
        {"Wilson Evans Batten Catalogue", "WEB 10724"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.48404806),
        dec: Angle.Degrees(+27.30953058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92557"},
        {"Hipparcos Number", "HIP 52330"},
        {"Smithsonian Astrophysical Observation", "SAO 81474"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.40515615),
        dec: Angle.Degrees(+27.30971462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80876",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80876"},
    },
    visualMagnitude: 12.07,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.70702675),
        dec: Angle.Degrees(+27.31433589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -207.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -472.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 341011"},
        {"Hipparcos Number", "HIP 102559"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.75453796),
        dec: Angle.Degrees(+27.31586050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153698"},
        {"Hipparcos Number", "HIP 83172"},
        {"Geneva Identification System", "GEN# +1.00153698"},
        {"Smithsonian Astrophysical Observation", "SAO 84745"},
        {"Wilson Evans Batten Catalogue", "WEB 14057"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.97052139),
        dec: Angle.Degrees(+27.31592836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72753",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72753"},
    },
    visualMagnitude: 10.27,
    bvColour: 1.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.09552337),
        dec: Angle.Degrees(+27.31655815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -250.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39949"},
        {"Hipparcos Number", "HIP 28164"},
        {"Geneva Identification System", "GEN# +1.00039949"},
        {"Smithsonian Astrophysical Observation", "SAO 77753"},
        {"Wilson Evans Batten Catalogue", "WEB 5512"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.27315379),
        dec: Angle.Degrees(+27.31668648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210944"},
        {"Hipparcos Number", "HIP 109700"},
        {"Geneva Identification System", "GEN# +1.00210944"},
        {"Smithsonian Astrophysical Observation", "SAO 90329"},
        {"Wilson Evans Batten Catalogue", "WEB 19707"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.30624659),
        dec: Angle.Degrees(+27.31884828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23226",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3587 B"},
        {"Hipparcos Number", "HIP 23226"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.97111633),
        dec: Angle.Degrees(+27.32053250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177595"},
        {"Hipparcos Number", "HIP 93662"},
        {"Smithsonian Astrophysical Observation", "SAO 86766"},
        {"Wilson Evans Batten Catalogue", "WEB 16275"},
    },
    visualMagnitude: 7.12,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.08883462),
        dec: Angle.Degrees(+27.32073872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95589",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12447 AB"},
        {"Henry Draper", "HD 183032"},
        {"Hipparcos Number", "HIP 95589"},
        {"Geneva Identification System", "GEN# +1.00183032"},
        {"Smithsonian Astrophysical Observation", "SAO 87213"},
        {"Wilson Evans Batten Catalogue", "WEB 16720"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.64043581),
        dec: Angle.Degrees(+27.32245810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 102.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 87.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110745"},
        {"Hipparcos Number", "HIP 62129"},
        {"Geneva Identification System", "GEN# +1.00110745"},
        {"Smithsonian Astrophysical Observation", "SAO 82463"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.99735287),
        dec: Angle.Degrees(+27.32509174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23228",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3587 A"},
        {"Henry Draper", "HD 31806"},
        {"Hipparcos Number", "HIP 23228"},
        {"Smithsonian Astrophysical Observation", "SAO 76880"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.97391326),
        dec: Angle.Degrees(+27.32565720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36643"},
        {"Hipparcos Number", "HIP 26134"},
        {"Geneva Identification System", "GEN# +1.00036643"},
        {"Smithsonian Astrophysical Observation", "SAO 77266"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.58957296),
        dec: Angle.Degrees(+27.33049614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188525"},
        {"Hipparcos Number", "HIP 97969"},
        {"Geneva Identification System", "GEN# +1.00188525"},
        {"Smithsonian Astrophysical Observation", "SAO 87914"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.66394280),
        dec: Angle.Degrees(+27.33072629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191614"},
        {"Hipparcos Number", "HIP 99342"},
        {"Geneva Identification System", "GEN# +1.00191614"},
        {"Smithsonian Astrophysical Observation", "SAO 88273"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.44912930),
        dec: Angle.Degrees(+27.33150800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200546"},
        {"Hipparcos Number", "HIP 103919"},
        {"Smithsonian Astrophysical Observation", "SAO 89413"},
        {"Wilson Evans Batten Catalogue", "WEB 18923"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.802,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.83299183),
        dec: Angle.Degrees(+27.33158358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147308"},
        {"Hipparcos Number", "HIP 80026"},
        {"Geneva Identification System", "GEN# +1.00147308"},
        {"Smithsonian Astrophysical Observation", "SAO 84308"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.03847491),
        dec: Angle.Degrees(+27.33330958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90932"},
        {"Hipparcos Number", "HIP 51440"},
        {"Geneva Identification System", "GEN# +1.00090932"},
        {"Smithsonian Astrophysical Observation", "SAO 81388"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.58975976),
        dec: Angle.Degrees(+27.33581272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223662"},
        {"Hipparcos Number", "HIP 117639"},
        {"Smithsonian Astrophysical Observation", "SAO 91543"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.86544419),
        dec: Angle.Degrees(+27.33611427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81442",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81442"},
        {"Smithsonian Astrophysical Observation", "SAO 84494"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.50841506),
        dec: Angle.Degrees(+27.33692058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183988"},
        {"Hipparcos Number", "HIP 95998"},
        {"Smithsonian Astrophysical Observation", "SAO 87309"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.79371542),
        dec: Angle.Degrees(+27.33746082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63588",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63588"},
        {"Geneva Identification System", "GEN# +0.02802174"},
    },
    visualMagnitude: 10.70,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.46469505),
        dec: Angle.Degrees(+27.33757171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75995",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75995"},
        {"Smithsonian Astrophysical Observation", "SAO 83863"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.79630316),
        dec: Angle.Degrees(+27.33888987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147981"},
        {"Hipparcos Number", "HIP 80325"},
        {"Smithsonian Astrophysical Observation", "SAO 84352"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.98925336),
        dec: Angle.Degrees(+27.33908751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102494"},
        {"Hipparcos Number", "HIP 57563"},
        {"Geneva Identification System", "GEN# +1.00102494"},
        {"Smithsonian Astrophysical Observation", "SAO 81996"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.871,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.98495996),
        dec: Angle.Degrees(+27.34058324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39644"},
        {"Hipparcos Number", "HIP 27982"},
        {"Geneva Identification System", "GEN# +1.00039644"},
        {"Smithsonian Astrophysical Observation", "SAO 77711"},
        {"Wilson Evans Batten Catalogue", "WEB 5484"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.76557321),
        dec: Angle.Degrees(+27.34216728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163265"},
        {"Hipparcos Number", "HIP 87636"},
        {"Geneva Identification System", "GEN# +1.00163265"},
        {"Smithsonian Astrophysical Observation", "SAO 85526"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.52125995),
        dec: Angle.Degrees(+27.34280072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72409"},
        {"Hipparcos Number", "HIP 41999"},
        {"Geneva Identification System", "GEN# +1.00072409"},
        {"Smithsonian Astrophysical Observation", "SAO 80251"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.40864154),
        dec: Angle.Degrees(+27.34499615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 282933"},
        {"Hipparcos Number", "HIP 17592"},
    },
    visualMagnitude: 9.61,
    bvColour: 1.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.52808017),
        dec: Angle.Degrees(+27.34623421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117204"},
        {"Hipparcos Number", "HIP 65732"},
        {"Geneva Identification System", "GEN# +1.00117204"},
        {"Smithsonian Astrophysical Observation", "SAO 82857"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.11511268),
        dec: Angle.Degrees(+27.34774906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27482"},
        {"Hipparcos Number", "HIP 20324"},
        {"Geneva Identification System", "GEN# +1.00027482"},
        {"Smithsonian Astrophysical Observation", "SAO 76563"},
    },
    visualMagnitude: 7.21,
    bvColour: 2.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.31356936),
        dec: Angle.Degrees(+27.35025799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20250",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3137 A"},
        {"Henry Draper", "HD 27382"},
        {"Hipparcos Number", "HIP 20250"},
        {"Geneva Identification System", "GEN# +1.00027382"},
        {"Smithsonian Astrophysical Observation", "SAO 76558"},
        {"Wilson Evans Batten Catalogue", "WEB 3867"},
    },
    visualMagnitude: 4.97,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.08847817),
        dec: Angle.Degrees(+27.35094069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66146",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66146"},
        {"Geneva Identification System", "GEN# +0.02802237"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.38478835),
        dec: Angle.Degrees(+27.35173658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50632"},
        {"Hipparcos Number", "HIP 33268"},
        {"Smithsonian Astrophysical Observation", "SAO 78862"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.80717678),
        dec: Angle.Degrees(+27.35301583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85771"},
        {"Hipparcos Number", "HIP 48605"},
        {"Smithsonian Astrophysical Observation", "SAO 81079"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.68259799),
        dec: Angle.Degrees(+27.35307834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82649"},
        {"Hipparcos Number", "HIP 46939"},
        {"Geneva Identification System", "GEN# +1.00082649"},
        {"Smithsonian Astrophysical Observation", "SAO 80906"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.49903300),
        dec: Angle.Degrees(+27.35314264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212441"},
        {"Hipparcos Number", "HIP 110562"},
        {"Smithsonian Astrophysical Observation", "SAO 90471"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.96391079),
        dec: Angle.Degrees(+27.35435638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13836"},
        {"Hipparcos Number", "HIP 10510"},
        {"Cincinnati Publication", "Ci 18 290"},
        {"Fundamental Katalog 5th Edition", "FK5 4207"},
        {"Geneva Identification System", "GEN# +1.00013836"},
        {"Geneva Identification System 2", "GEN# +9.80035037"},
        {"Smithsonian Astrophysical Observation", "SAO 75232"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.86312275),
        dec: Angle.Degrees(+27.35759790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 286.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -138.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4904"},
        {"Hipparcos Number", "HIP 3994"},
        {"Smithsonian Astrophysical Observation", "SAO 74319"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.83088708),
        dec: Angle.Degrees(+27.35776383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216026"},
        {"Hipparcos Number", "HIP 112680"},
        {"Smithsonian Astrophysical Observation", "SAO 90805"},
        {"Wilson Evans Batten Catalogue", "WEB 20083"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.26895987),
        dec: Angle.Degrees(+27.35797253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14480"},
        {"Hipparcos Number", "HIP 10942"},
        {"Smithsonian Astrophysical Observation", "SAO 75295"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.23524570),
        dec: Angle.Degrees(+27.35983244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135723"},
        {"Hipparcos Number", "HIP 74685"},
        {"Smithsonian Astrophysical Observation", "SAO 83734"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.95021477),
        dec: Angle.Degrees(+27.36174451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98153"},
        {"Hipparcos Number", "HIP 55170"},
        {"Geneva Identification System", "GEN# +1.00098153"},
        {"Smithsonian Astrophysical Observation", "SAO 81756"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.43462187),
        dec: Angle.Degrees(+27.36224795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63433"},
        {"Hipparcos Number", "HIP 38228"},
        {"Geneva Identification System", "GEN# +1.00063433"},
        {"Smithsonian Astrophysical Observation", "SAO 79729"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.47944668),
        dec: Angle.Degrees(+27.36321021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38689"},
        {"Hipparcos Number", "HIP 27456"},
        {"Geneva Identification System", "GEN# +1.00038689"},
        {"Smithsonian Astrophysical Observation", "SAO 77588"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.20412840),
        dec: Angle.Degrees(+27.36377348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150087"},
        {"Hipparcos Number", "HIP 81417"},
        {"Geneva Identification System", "GEN# +1.00150087"},
        {"Smithsonian Astrophysical Observation", "SAO 84492"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.42318036),
        dec: Angle.Degrees(+27.36448593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13200"},
        {"Hipparcos Number", "HIP 10074"},
        {"Smithsonian Astrophysical Observation", "SAO 75172"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.40196963),
        dec: Angle.Degrees(+27.36842033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 335538"},
        {"Hipparcos Number", "HIP 88521"},
    },
    visualMagnitude: 10.68,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.15515020),
        dec: Angle.Degrees(+27.37438687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147487"},
        {"Hipparcos Number", "HIP 80118"},
        {"Geneva Identification System", "GEN# +1.00147487"},
        {"Smithsonian Astrophysical Observation", "SAO 84323"},
        {"Wilson Evans Batten Catalogue", "WEB 13563"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.31498884),
        dec: Angle.Degrees(+27.37515615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 170.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145313"},
        {"Hipparcos Number", "HIP 79154"},
        {"Geneva Identification System", "GEN# +1.00145313"},
        {"Smithsonian Astrophysical Observation", "SAO 84217"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.33055417),
        dec: Angle.Degrees(+27.37562120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31520"},
        {"Hipparcos Number", "HIP 23056"},
        {"Geneva Identification System", "GEN# +5.20250148"},
        {"Smithsonian Astrophysical Observation", "SAO 76857"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.41972796),
        dec: Angle.Degrees(+27.37604958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 135.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -126.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198527"},
        {"Hipparcos Number", "HIP 102847"},
        {"Smithsonian Astrophysical Observation", "SAO 89185"},
        {"Wilson Evans Batten Catalogue", "WEB 18656"},
    },
    visualMagnitude: 7.18,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.52280861),
        dec: Angle.Degrees(+27.37768311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106103"},
        {"Hipparcos Number", "HIP 59527"},
        {"Geneva Identification System", "GEN# +5.21110019"},
        {"Smithsonian Astrophysical Observation", "SAO 82186"},
        {"Wilson Evans Batten Catalogue", "WEB 10583"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.10376031),
        dec: Angle.Degrees(+27.38012065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52202"},
        {"Hipparcos Number", "HIP 33833"},
        {"Smithsonian Astrophysical Observation", "SAO 78976"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.35218748),
        dec: Angle.Degrees(+27.38026837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96903",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12798 AB"},
        {"Henry Draper", "HD 186179"},
        {"Hipparcos Number", "HIP 96903"},
        {"Smithsonian Astrophysical Observation", "SAO 87584"},
        {"Wilson Evans Batten Catalogue", "WEB 17004"},
    },
    visualMagnitude: 6.67,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.46924147),
        dec: Angle.Degrees(+27.38215155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184384"},
        {"Hipparcos Number", "HIP 96165"},
        {"Cincinnati Publication", "Ci 18 2551"},
        {"Geneva Identification System", "GEN# +1.00184384"},
        {"Smithsonian Astrophysical Observation", "SAO 87345"},
        {"Wilson Evans Batten Catalogue", "WEB 16849"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.29639539),
        dec: Angle.Degrees(+27.38365626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -157.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43927"},
        {"Hipparcos Number", "HIP 30101"},
        {"Smithsonian Astrophysical Observation", "SAO 78234"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.01874264),
        dec: Angle.Degrees(+27.38501304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16090",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16090"},
    },
    visualMagnitude: 11.78,
    bvColour: 1.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.81004171),
        dec: Angle.Degrees(+27.38588004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122405"},
        {"Hipparcos Number", "HIP 68478"},
        {"Fundamental Katalog 5th Edition", "FK5 517"},
        {"Geneva Identification System", "GEN# +1.00122405"},
        {"Renson", "Renson 35090"},
        {"Smithsonian Astrophysical Observation", "SAO 83130"},
        {"Wilson Evans Batten Catalogue", "WEB 11998"},
    },
    visualMagnitude: 6.23,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.29388659),
        dec: Angle.Degrees(+27.38654762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82191"},
        {"Hipparcos Number", "HIP 46704"},
        {"Geneva Identification System", "GEN# +1.00082191"},
        {"Renson", "Renson 23370"},
        {"Smithsonian Astrophysical Observation", "SAO 80877"},
        {"Wilson Evans Batten Catalogue", "WEB 8810"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.82252732),
        dec: Angle.Degrees(+27.38729978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 335745"},
        {"Hipparcos Number", "HIP 89155"},
        {"Smithsonian Astrophysical Observation", "SAO 85817"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.93724835),
        dec: Angle.Degrees(+27.38742139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107294",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15260 D"},
        {"Hipparcos Number", "HIP 107294"},
        {"Cincinnati Publication", "Ci 18 2821"},
        {"Smithsonian Astrophysical Observation", "SAO 89936"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.98866673),
        dec: Angle.Degrees(+27.39038703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -238.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -159.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108225",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15451 AB"},
        {"Henry Draper", "HD 208416"},
        {"Hipparcos Number", "HIP 108225"},
        {"Smithsonian Astrophysical Observation", "SAO 90100"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.87457490),
        dec: Angle.Degrees(+27.39325700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110883"},
        {"Hipparcos Number", "HIP 62213"},
        {"Geneva Identification System", "GEN# +1.00110883"},
        {"Smithsonian Astrophysical Observation", "SAO 82471"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.26388873),
        dec: Angle.Degrees(+27.39345173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81940"},
        {"Hipparcos Number", "HIP 46548"},
        {"Geneva Identification System", "GEN# +1.00081940"},
        {"Smithsonian Astrophysical Observation", "SAO 80856"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.39698270),
        dec: Angle.Degrees(+27.39385444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90256",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11334 AB"},
        {"Henry Draper", "HD 169718"},
        {"Hipparcos Number", "HIP 90256"},
        {"Geneva Identification System", "GEN# +1.00169718J"},
        {"Smithsonian Astrophysical Observation", "SAO 86019"},
        {"Wilson Evans Batten Catalogue", "WEB 15441"},
    },
    visualMagnitude: 6.27,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.24358491),
        dec: Angle.Degrees(+27.39481834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102418"},
        {"Hipparcos Number", "HIP 57517"},
        {"Geneva Identification System", "GEN# +1.00102418"},
        {"Smithsonian Astrophysical Observation", "SAO 81992"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.83384881),
        dec: Angle.Degrees(+27.39732111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87970",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10942 A"},
        {"Henry Draper", "HD 164042"},
        {"Hipparcos Number", "HIP 87970"},
        {"Smithsonian Astrophysical Observation", "SAO 85596"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.54307761),
        dec: Angle.Degrees(+27.39740253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57568",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57568"},
        {"Smithsonian Astrophysical Observation", "SAO 81997"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.00010339),
        dec: Angle.Degrees(+27.39949048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129210"},
        {"Hipparcos Number", "HIP 71751"},
        {"Smithsonian Astrophysical Observation", "SAO 83462"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.14541372),
        dec: Angle.Degrees(+27.40017476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20938"},
        {"Hipparcos Number", "HIP 15794"},
        {"Smithsonian Astrophysical Observation", "SAO 75907"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.88583978),
        dec: Angle.Degrees(+27.40196620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69349"},
        {"Hipparcos Number", "HIP 40619"},
        {"Smithsonian Astrophysical Observation", "SAO 80069"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.38506341),
        dec: Angle.Degrees(+27.40232739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92882"},
        {"Hipparcos Number", "HIP 52491"},
        {"Smithsonian Astrophysical Observation", "SAO 81494"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.97095942),
        dec: Angle.Degrees(+27.40235258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -208.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137705"},
        {"Hipparcos Number", "HIP 75591"},
        {"Geneva Identification System", "GEN# +1.00137705"},
        {"Smithsonian Astrophysical Observation", "SAO 83822"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.65110376),
        dec: Angle.Degrees(+27.40333746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28354"},
        {"Hipparcos Number", "HIP 20933"},
        {"Fundamental Katalog 5th Edition", "FK5 2331"},
        {"Geneva Identification System", "GEN# +1.00028354"},
        {"Smithsonian Astrophysical Observation", "SAO 76627"},
        {"Wilson Evans Batten Catalogue", "WEB 4023"},
    },
    visualMagnitude: 6.53,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.33261127),
        dec: Angle.Degrees(+27.40429387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177935"},
        {"Hipparcos Number", "HIP 93758"},
        {"Smithsonian Astrophysical Observation", "SAO 86794"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.40398653),
        dec: Angle.Degrees(+27.40734897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 336669"},
        {"Hipparcos Number", "HIP 91614"},
        {"Smithsonian Astrophysical Observation", "SAO 86317"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.706,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.25693845),
        dec: Angle.Degrees(+27.40737031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102080"},
        {"Hipparcos Number", "HIP 57300"},
        {"Geneva Identification System", "GEN# +1.00102080"},
        {"Smithsonian Astrophysical Observation", "SAO 81969"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.24317920),
        dec: Angle.Degrees(+27.40747489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -139.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186378"},
        {"Hipparcos Number", "HIP 97006"},
        {"Smithsonian Astrophysical Observation", "SAO 87618"},
        {"Wilson Evans Batten Catalogue", "WEB 17021"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.74644154),
        dec: Angle.Degrees(+27.40850194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195071"},
        {"Hipparcos Number", "HIP 100961"},
        {"Smithsonian Astrophysical Observation", "SAO 88713"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.04336615),
        dec: Angle.Degrees(+27.41193136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 339991"},
        {"Hipparcos Number", "HIP 100343"},
        {"Smithsonian Astrophysical Observation", "SAO 88556"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.24777164),
        dec: Angle.Degrees(+27.41286820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126307"},
        {"Hipparcos Number", "HIP 70385"},
        {"Geneva Identification System", "GEN# +1.00126307"},
        {"Smithsonian Astrophysical Observation", "SAO 83329"},
        {"Wilson Evans Batten Catalogue", "WEB 12216"},
    },
    visualMagnitude: 6.39,
    bvColour: 1.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.00826487),
        dec: Angle.Degrees(+27.41318794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89239"},
        {"Hipparcos Number", "HIP 50459"},
        {"Geneva Identification System", "GEN# +1.00089239"},
        {"Renson", "Renson 25610"},
        {"Smithsonian Astrophysical Observation", "SAO 81278"},
        {"Wilson Evans Batten Catalogue", "WEB 9260"},
    },
    visualMagnitude: 6.53,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.54387855),
        dec: Angle.Degrees(+27.41545461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204007"},
        {"Hipparcos Number", "HIP 105738"},
        {"Smithsonian Astrophysical Observation", "SAO 89692"},
    },
    visualMagnitude: 6.99,
    bvColour: -0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.24896983),
        dec: Angle.Degrees(+27.41800995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133231"},
        {"Hipparcos Number", "HIP 73596"},
        {"Smithsonian Astrophysical Observation", "SAO 83628"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.65109154),
        dec: Angle.Degrees(+27.41816873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50052",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7685 AB"},
        {"Henry Draper", "HD 88533"},
        {"Hipparcos Number", "HIP 50052"},
        {"Geneva Identification System", "GEN# +1.00088533"},
        {"Smithsonian Astrophysical Observation", "SAO 81238"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.736,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.28711840),
        dec: Angle.Degrees(+27.41990017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -126.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55067",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8111 AB"},
        {"Hipparcos Number", "HIP 55067"},
        {"Smithsonian Astrophysical Observation", "SAO 81748"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.10597891),
        dec: Angle.Degrees(+27.42177838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146537"},
        {"Hipparcos Number", "HIP 79686"},
        {"Geneva Identification System", "GEN# +1.00146537"},
        {"Smithsonian Astrophysical Observation", "SAO 84269"},
        {"Wilson Evans Batten Catalogue", "WEB 13486"},
    },
    visualMagnitude: 6.14,
    bvColour: 1.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.94727071),
        dec: Angle.Degrees(+27.42217655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79929"},
        {"Hipparcos Number", "HIP 45595"},
        {"Geneva Identification System", "GEN# +1.00079929"},
        {"Smithsonian Astrophysical Observation", "SAO 80741"},
        {"Wilson Evans Batten Catalogue", "WEB 8666"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.39952693),
        dec: Angle.Degrees(+27.42219486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 338440"},
        {"Hipparcos Number", "HIP 96114"},
        {"Smithsonian Astrophysical Observation", "SAO 87334"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.12738692),
        dec: Angle.Degrees(+27.42259976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108519"},
        {"Hipparcos Number", "HIP 60805"},
        {"Geneva Identification System", "GEN# +5.21110140"},
        {"Smithsonian Astrophysical Observation", "SAO 82322"},
        {"Wilson Evans Batten Catalogue", "WEB 10820"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.94301934),
        dec: Angle.Degrees(+27.42281218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134680"},
        {"Hipparcos Number", "HIP 74247"},
        {"Smithsonian Astrophysical Observation", "SAO 83698"},
        {"Wilson Evans Batten Catalogue", "WEB 12676"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.59479048),
        dec: Angle.Degrees(+27.42372892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190736"},
        {"Hipparcos Number", "HIP 98952"},
        {"Geneva Identification System", "GEN# +1.00190736"},
        {"Smithsonian Astrophysical Observation", "SAO 88174"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.35791670),
        dec: Angle.Degrees(+27.42434671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213210"},
        {"Hipparcos Number", "HIP 111002"},
        {"Geneva Identification System", "GEN# +1.00213210"},
        {"Smithsonian Astrophysical Observation", "SAO 90545"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.33314433),
        dec: Angle.Degrees(+27.42802634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41708"},
        {"Hipparcos Number", "HIP 29074"},
        {"Geneva Identification System", "GEN# +1.00041708"},
        {"Smithsonian Astrophysical Observation", "SAO 78000"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.99602995),
        dec: Angle.Degrees(+27.42845793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198702"},
        {"Hipparcos Number", "HIP 102946"},
        {"Smithsonian Astrophysical Observation", "SAO 89214"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.85739128),
        dec: Angle.Degrees(+27.42876078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42634"},
        {"Hipparcos Number", "HIP 29510"},
        {"Smithsonian Astrophysical Observation", "SAO 78108"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.25252447),
        dec: Angle.Degrees(+27.43190189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44920",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44920"},
        {"Geneva Identification System", "GEN# +6.20030025"},
        {"Wilson Evans Batten Catalogue", "WEB 8584"},
    },
    visualMagnitude: 10.26,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.26423051),
        dec: Angle.Degrees(+27.43215677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -231.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59898"},
        {"Hipparcos Number", "HIP 36718"},
        {"Smithsonian Astrophysical Observation", "SAO 79493"},
    },
    visualMagnitude: 9.24,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.28621742),
        dec: Angle.Degrees(+27.43392641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34799",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34799"},
        {"Smithsonian Astrophysical Observation", "SAO 79155"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.05558789),
        dec: Angle.Degrees(+27.43622778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17924",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17924"},
        {"Geneva Identification System", "GEN# +9.80038016"},
    },
    visualMagnitude: 12.28,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.49330172),
        dec: Angle.Degrees(+27.43929183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 192.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -221.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111696",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16121 AB"},
        {"Henry Draper", "HD 214422"},
        {"Hipparcos Number", "HIP 111696"},
        {"Wilson Evans Batten Catalogue", "WEB 19960"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.39655715),
        dec: Angle.Degrees(+27.43960354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59745",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59745"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.78212090),
        dec: Angle.Degrees(+27.44209314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37537"},
        {"Hipparcos Number", "HIP 26708"},
        {"Geneva Identification System", "GEN# +1.00037537"},
        {"Smithsonian Astrophysical Observation", "SAO 77379"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.13522212),
        dec: Angle.Degrees(+27.44278366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44435"},
        {"Hipparcos Number", "HIP 30349"},
        {"Geneva Identification System", "GEN# +1.00044435"},
        {"Smithsonian Astrophysical Observation", "SAO 78295"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.75138937),
        dec: Angle.Degrees(+27.44375321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 336780"},
        {"Hipparcos Number", "HIP 92037"},
        {"Smithsonian Astrophysical Observation", "SAO 86409"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.39983832),
        dec: Angle.Degrees(+27.44411237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101015"},
        {"Hipparcos Number", "HIP 56704"},
        {"Geneva Identification System", "GEN# +1.00101015"},
        {"Smithsonian Astrophysical Observation", "SAO 81907"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.39527229),
        dec: Angle.Degrees(+27.44554798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -153.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66162",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8944 A"},
        {"Hipparcos Number", "HIP 66162"},
        {"Smithsonian Astrophysical Observation", "SAO 82880"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.43511185),
        dec: Angle.Degrees(+27.45018653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105488",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105488"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.49004702),
        dec: Angle.Degrees(+27.45251318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 204.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 153.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 267477"},
        {"Hipparcos Number", "HIP 33696"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.02004421),
        dec: Angle.Degrees(+27.45273459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119477"},
        {"Hipparcos Number", "HIP 66930"},
        {"Geneva Identification System", "GEN# +1.00119477"},
        {"Smithsonian Astrophysical Observation", "SAO 82960"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.74776604),
        dec: Angle.Degrees(+27.45304457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115075",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115075"},
        {"Smithsonian Astrophysical Observation", "SAO 91160"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.61908552),
        dec: Angle.Degrees(+27.45305630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115613"},
        {"Hipparcos Number", "HIP 64879"},
        {"Geneva Identification System", "GEN# +1.00115613"},
        {"Smithsonian Astrophysical Observation", "SAO 82762"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.48911391),
        dec: Angle.Degrees(+27.45345735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197605"},
        {"Hipparcos Number", "HIP 102327"},
        {"Geneva Identification System", "GEN# +1.00197605"},
        {"Smithsonian Astrophysical Observation", "SAO 89062"},
        {"Wilson Evans Batten Catalogue", "WEB 18525"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.98155709),
        dec: Angle.Degrees(+27.45452000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81454",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81454"},
        {"Smithsonian Astrophysical Observation", "SAO 84496"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.54501684),
        dec: Angle.Degrees(+27.45520463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109483"},
        {"Hipparcos Number", "HIP 61402"},
        {"Geneva Identification System", "GEN# +5.21110192"},
        {"Smithsonian Astrophysical Observation", "SAO 82392"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.72626007),
        dec: Angle.Degrees(+27.45565105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94679",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12239 AB"},
        {"Henry Draper", "HD 180553"},
        {"Hipparcos Number", "HIP 94679"},
        {"Geneva Identification System", "GEN# +1.00180553"},
        {"Smithsonian Astrophysical Observation", "SAO 87005"},
        {"Wilson Evans Batten Catalogue", "WEB 16506"},
    },
    visualMagnitude: 6.54,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.98733249),
        dec: Angle.Degrees(+27.45593547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102650",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14312 AB"},
        {"Henry Draper", "HD 198226"},
        {"Hipparcos Number", "HIP 102650"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.02605490),
        dec: Angle.Degrees(+27.45713451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101428",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "NC 52"},
        {"Henry Draper", "HD 195919"},
        {"Hipparcos Number", "HIP 101428"},
        {"Geneva Identification System", "GEN# +1.00195919"},
        {"Smithsonian Astrophysical Observation", "SAO 88828"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.32597651),
        dec: Angle.Degrees(+27.45736773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50433"},
        {"Hipparcos Number", "HIP 33190"},
        {"Smithsonian Astrophysical Observation", "SAO 78848"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.61307052),
        dec: Angle.Degrees(+27.45844055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187921"},
        {"Hipparcos Number", "HIP 97717"},
        {"Geneva Identification System", "GEN# +1.00187921"},
        {"Smithsonian Astrophysical Observation", "SAO 87829"},
        {"Wilson Evans Batten Catalogue", "WEB 17189"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.87878066),
        dec: Angle.Degrees(+27.46024688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112728",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112728"},
        {"Smithsonian Astrophysical Observation", "SAO 90813"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.43455632),
        dec: Angle.Degrees(+27.58796843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11119"},
        {"Hipparcos Number", "HIP 8528"},
        {"Geneva Identification System", "GEN# +1.00011119"},
        {"Smithsonian Astrophysical Observation", "SAO 74960"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.49616604),
        dec: Angle.Degrees(+27.46463408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35130",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35130"},
        {"Smithsonian Astrophysical Observation", "SAO 79219"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.94361842),
        dec: Angle.Degrees(+27.46972993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34222",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34222"},
        {"Geneva Identification System", "GEN# +0.12701311"},
        {"Geneva Identification System 2", "GEN# +0.02701311A"},
        {"Wilson Evans Batten Catalogue", "WEB 6853"},
    },
    visualMagnitude: 10.14,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.42614918),
        dec: Angle.Degrees(+27.47106422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63333",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8721 AB"},
        {"Henry Draper", "HD 112753"},
        {"Hipparcos Number", "HIP 63333"},
        {"Geneva Identification System", "GEN# +1.00112753"},
        {"Smithsonian Astrophysical Observation", "SAO 82592"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.67073468),
        dec: Angle.Degrees(+27.47487064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -125.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61545",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61545"},
        {"Geneva Identification System", "GEN# +0.02802137"},
    },
    visualMagnitude: 10.89,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.16496570),
        dec: Angle.Degrees(+27.47494223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -217.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -186.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48344"},
        {"Hipparcos Number", "HIP 32265"},
        {"Smithsonian Astrophysical Observation", "SAO 78685"},
    },
    visualMagnitude: 8.01,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.05018911),
        dec: Angle.Degrees(+27.47988567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173909"},
        {"Hipparcos Number", "HIP 92138"},
        {"Smithsonian Astrophysical Observation", "SAO 86430"},
        {"Wilson Evans Batten Catalogue", "WEB 15888"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.69086913),
        dec: Angle.Degrees(+27.48036865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39888",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6612 A"},
        {"Henry Draper", "HD 67402"},
        {"Hipparcos Number", "HIP 39888"},
        {"Geneva Identification System", "GEN# +1.00067402"},
        {"Smithsonian Astrophysical Observation", "SAO 79974"},
        {"Wilson Evans Batten Catalogue", "WEB 7775"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.20669423),
        dec: Angle.Degrees(+27.48045958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12535"},
        {"Hipparcos Number", "HIP 9608"},
        {"Smithsonian Astrophysical Observation", "SAO 75112"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.88670808),
        dec: Angle.Degrees(+27.48202026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128494"},
        {"Hipparcos Number", "HIP 71428"},
        {"Geneva Identification System", "GEN# +1.00128494"},
        {"Smithsonian Astrophysical Observation", "SAO 83431"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.10058101),
        dec: Angle.Degrees(+27.48510535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65023"},
        {"Hipparcos Number", "HIP 38903"},
        {"Smithsonian Astrophysical Observation", "SAO 79822"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.42379882),
        dec: Angle.Degrees(+27.48835496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3094",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3094"},
        {"Smithsonian Astrophysical Observation", "SAO 74173"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.84562053),
        dec: Angle.Degrees(+27.48961464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55440",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55440"},
        {"Fundamental Katalog 5th Edition", "FK5 4997"},
        {"Geneva Identification System", "GEN# +0.02801993"},
        {"Smithsonian Astrophysical Observation", "SAO 81787"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.29755007),
        dec: Angle.Degrees(+27.49026200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219936"},
        {"Hipparcos Number", "HIP 115159"},
        {"Geneva Identification System", "GEN# +1.00219936"},
        {"Smithsonian Astrophysical Observation", "SAO 91170"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.90252463),
        dec: Angle.Degrees(+27.49069423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64516",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64516"},
        {"Smithsonian Astrophysical Observation", "SAO 82724"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.34934833),
        dec: Angle.Degrees(+27.49181355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121710"},
        {"Hipparcos Number", "HIP 68103"},
        {"Geneva Identification System", "GEN# +1.00121710"},
        {"Smithsonian Astrophysical Observation", "SAO 83084"},
        {"Wilson Evans Batten Catalogue", "WEB 11955"},
    },
    visualMagnitude: 5.02,
    bvColour: 1.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.14234407),
        dec: Angle.Degrees(+27.49219844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121213"},
        {"Hipparcos Number", "HIP 67812"},
        {"Geneva Identification System", "GEN# +1.00121213"},
        {"Smithsonian Astrophysical Observation", "SAO 83063"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.37791743),
        dec: Angle.Degrees(+27.49475814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131411"},
        {"Hipparcos Number", "HIP 72796"},
        {"Geneva Identification System", "GEN# +1.00131411"},
        {"Smithsonian Astrophysical Observation", "SAO 83565"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.19505807),
        dec: Angle.Degrees(+27.49845149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61809",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61809"},
        {"Wilson Evans Batten Catalogue", "WEB 10998"},
    },
    visualMagnitude: 11.80,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.01344335),
        dec: Angle.Degrees(+27.49895907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90748"},
        {"Hipparcos Number", "HIP 51340"},
        {"Geneva Identification System", "GEN# +1.00090748"},
        {"Smithsonian Astrophysical Observation", "SAO 81375"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.30350987),
        dec: Angle.Degrees(+27.49905731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217230"},
        {"Hipparcos Number", "HIP 113481"},
        {"Smithsonian Astrophysical Observation", "SAO 90913"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.72878947),
        dec: Angle.Degrees(+27.49961685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59033",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59033"},
        {"Geneva Identification System", "GEN# +0.02802078"},
        {"Wilson Evans Batten Catalogue", "WEB 10514"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.55062773),
        dec: Angle.Degrees(+27.49967768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -233.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84874",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84874"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.19074450),
        dec: Angle.Degrees(+27.50044861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199440"},
        {"Hipparcos Number", "HIP 103353"},
        {"Smithsonian Astrophysical Observation", "SAO 89303"},
        {"Wilson Evans Batten Catalogue", "WEB 18788"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.09708637),
        dec: Angle.Degrees(+27.50395843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203171"},
        {"Hipparcos Number", "HIP 105317"},
        {"Geneva Identification System", "GEN# +1.00203171"},
        {"Smithsonian Astrophysical Observation", "SAO 89626"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.95380509),
        dec: Angle.Degrees(+27.50455656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38980"},
        {"Hipparcos Number", "HIP 27605"},
        {"Geneva Identification System", "GEN# +1.00038980"},
        {"Smithsonian Astrophysical Observation", "SAO 77619"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.66565783),
        dec: Angle.Degrees(+27.50507910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 339862"},
        {"Hipparcos Number", "HIP 100066"},
        {"Geneva Identification System", "GEN# +1.00339862"},
        {"Smithsonian Astrophysical Observation", "SAO 88485"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.52018203),
        dec: Angle.Degrees(+27.50545817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190447"},
        {"Hipparcos Number", "HIP 98799"},
        {"Smithsonian Astrophysical Observation", "SAO 88143"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.99323044),
        dec: Angle.Degrees(+27.50665163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6754",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6754"},
        {"Smithsonian Astrophysical Observation", "SAO 74726"},
        {"Wilson Evans Batten Catalogue", "WEB 1474"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.72541711),
        dec: Angle.Degrees(+27.50717769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118204"},
        {"Hipparcos Number", "HIP 66258"},
        {"Geneva Identification System", "GEN# +1.00118204"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.70555361),
        dec: Angle.Degrees(+27.50938681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25894"},
        {"Hipparcos Number", "HIP 19219"},
        {"Smithsonian Astrophysical Observation", "SAO 76462"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.79136701),
        dec: Angle.Degrees(+27.50941717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 339248"},
        {"Hipparcos Number", "HIP 98311"},
        {"Smithsonian Astrophysical Observation", "SAO 88006"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.63441538),
        dec: Angle.Degrees(+27.50949447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122796"},
        {"Hipparcos Number", "HIP 68672"},
        {"Geneva Identification System", "GEN# +1.00122796"},
        {"Smithsonian Astrophysical Observation", "SAO 83148"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.86394001),
        dec: Angle.Degrees(+27.50995451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 737"},
        {"Hipparcos Number", "HIP 952"},
        {"Geneva Identification System", "GEN# +1.00000737"},
        {"Smithsonian Astrophysical Observation", "SAO 73799"},
        {"Wilson Evans Batten Catalogue", "WEB 172"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.94074786),
        dec: Angle.Degrees(+27.51025579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130215"},
        {"Hipparcos Number", "HIP 72200"},
        {"Geneva Identification System", "GEN# +1.00130215"},
        {"Smithsonian Astrophysical Observation", "SAO 83509"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.51275206),
        dec: Angle.Degrees(+27.51244732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189475"},
        {"Hipparcos Number", "HIP 98371"},
        {"Smithsonian Astrophysical Observation", "SAO 88017"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.78782084),
        dec: Angle.Degrees(+27.51262224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101353",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13980 AB"},
        {"Henry Draper", "HD 195790"},
        {"Hipparcos Number", "HIP 101353"},
        {"Smithsonian Astrophysical Observation", "SAO 88816"},
        {"Wilson Evans Batten Catalogue", "WEB 18310"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.847,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.11216113),
        dec: Angle.Degrees(+27.51425421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222390"},
        {"Hipparcos Number", "HIP 116777"},
        {"Geneva Identification System", "GEN# +1.00222390"},
        {"Smithsonian Astrophysical Observation", "SAO 91410"},
        {"Wilson Evans Batten Catalogue", "WEB 20606"},
    },
    visualMagnitude: 6.66,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.00439610),
        dec: Angle.Degrees(+27.51492439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57901",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57901"},
        {"Geneva Identification System", "GEN# +9.80121027"},
    },
    visualMagnitude: 12.30,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.13616195),
        dec: Angle.Degrees(+27.51512633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -898.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -350.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83700",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83700"},
        {"Smithsonian Astrophysical Observation", "SAO 84842"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.59364138),
        dec: Angle.Degrees(+27.51630872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193772"},
        {"Hipparcos Number", "HIP 100354"},
        {"Geneva Identification System", "GEN# +1.00193772"},
        {"Renson", "Renson 54090"},
        {"Smithsonian Astrophysical Observation", "SAO 88562"},
    },
    visualMagnitude: 8.64,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.29445232),
        dec: Angle.Degrees(+27.51717219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141246"},
        {"Hipparcos Number", "HIP 77316"},
        {"Smithsonian Astrophysical Observation", "SAO 83999"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.804,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.76881083),
        dec: Angle.Degrees(+27.52047616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25824"},
        {"Hipparcos Number", "HIP 19186"},
        {"Smithsonian Astrophysical Observation", "SAO 76459"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.68225844),
        dec: Angle.Degrees(+27.52216355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 265091"},
        {"Hipparcos Number", "HIP 32973"},
        {"Smithsonian Astrophysical Observation", "SAO 78815"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.02267247),
        dec: Angle.Degrees(+27.52278060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86460"},
        {"Hipparcos Number", "HIP 48961"},
        {"Cincinnati Publication", "Ci 18 1185"},
        {"Geneva Identification System", "GEN# +1.00086460"},
        {"Smithsonian Astrophysical Observation", "SAO 81124"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.81701073),
        dec: Angle.Degrees(+27.52321351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -330.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70402"},
        {"Hipparcos Number", "HIP 41071"},
        {"Geneva Identification System", "GEN# +1.00070402"},
        {"Smithsonian Astrophysical Observation", "SAO 80138"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.70103389),
        dec: Angle.Degrees(+27.52383368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111700",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111700"},
        {"Smithsonian Astrophysical Observation", "SAO 90657"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.40742414),
        dec: Angle.Degrees(+27.52432210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50451",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7715 AB"},
        {"Henry Draper", "HD 89223"},
        {"Hipparcos Number", "HIP 50451"},
        {"Smithsonian Astrophysical Observation", "SAO 81277"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.52307588),
        dec: Angle.Degrees(+27.52447074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92371"},
        {"Hipparcos Number", "HIP 52240"},
        {"Smithsonian Astrophysical Observation", "SAO 81463"},
        {"Wilson Evans Batten Catalogue", "WEB 9516"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.08824407),
        dec: Angle.Degrees(+27.52527209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39607",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6569 AB"},
        {"Henry Draper", "HD 66684"},
        {"Hipparcos Number", "HIP 39607"},
        {"Geneva Identification System", "GEN# +1.00066684J"},
        {"Smithsonian Astrophysical Observation", "SAO 79928"},
        {"Wilson Evans Batten Catalogue", "WEB 7738"},
    },
    visualMagnitude: 6.21,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.40439059),
        dec: Angle.Degrees(+27.52976278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89912",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11275 A"},
        {"Henry Draper", "HD 168874"},
        {"Hipparcos Number", "HIP 89912"},
        {"Geneva Identification System", "GEN# +1.00168874"},
        {"Smithsonian Astrophysical Observation", "SAO 85952"},
        {"Wilson Evans Batten Catalogue", "WEB 15352"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.20512065),
        dec: Angle.Degrees(+27.53007321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 106.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173493"},
        {"Hipparcos Number", "HIP 91934"},
        {"Geneva Identification System", "GEN# +1.00173493"},
        {"Smithsonian Astrophysical Observation", "SAO 86391"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.12160699),
        dec: Angle.Degrees(+27.53136427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 334025"},
        {"Hipparcos Number", "HIP 99836"},
        {"Geneva Identification System", "GEN# +1.00334025"},
        {"Smithsonian Astrophysical Observation", "SAO 88412"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.84551437),
        dec: Angle.Degrees(+27.53329520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283691"},
        {"Hipparcos Number", "HIP 21333"},
        {"Geneva Identification System", "GEN# +1.00283691"},
        {"Smithsonian Astrophysical Observation", "SAO 76656"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.67696005),
        dec: Angle.Degrees(+27.53456013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192405"},
        {"Hipparcos Number", "HIP 99677"},
        {"Geneva Identification System", "GEN# +1.00192405"},
        {"Smithsonian Astrophysical Observation", "SAO 88379"},
        {"Wilson Evans Batten Catalogue", "WEB 17874"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.41608666),
        dec: Angle.Degrees(+27.53514495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44858",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44858"},
        {"Geneva Identification System", "GEN# +0.02801697"},
        {"Smithsonian Astrophysical Observation", "SAO 80654"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.09960152),
        dec: Angle.Degrees(+27.53526587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56198",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8192 AB"},
        {"Henry Draper", "HD 100083"},
        {"Hipparcos Number", "HIP 56198"},
        {"Smithsonian Astrophysical Observation", "SAO 81864"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.80141327),
        dec: Angle.Degrees(+27.53620789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284069"},
        {"Hipparcos Number", "HIP 23570"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.01513537),
        dec: Angle.Degrees(+27.53770895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111812"},
        {"Hipparcos Number", "HIP 62763"},
        {"Fundamental Katalog 5th Edition", "FK5 1332"},
        {"Geneva Identification System", "GEN# +1.00111812"},
        {"Smithsonian Astrophysical Observation", "SAO 82537"},
        {"Wilson Evans Batten Catalogue", "WEB 11128"},
    },
    visualMagnitude: 4.93,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.92469926),
        dec: Angle.Degrees(+27.54073393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20579"},
        {"Hipparcos Number", "HIP 15487"},
        {"Smithsonian Astrophysical Observation", "SAO 75860"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.90659685),
        dec: Angle.Degrees(+27.54258856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44864",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44864"},
        {"Geneva Identification System", "GEN# +0.02801698"},
        {"Smithsonian Astrophysical Observation", "SAO 80655"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.11329281),
        dec: Angle.Degrees(+27.54295083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 73.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130537"},
        {"Hipparcos Number", "HIP 72376"},
        {"Smithsonian Astrophysical Observation", "SAO 83530"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.98664025),
        dec: Angle.Degrees(+27.54613188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87517",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87517"},
        {"Smithsonian Astrophysical Observation", "SAO 85503"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.20823878),
        dec: Angle.Degrees(+27.54786078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 339861"},
        {"Hipparcos Number", "HIP 100120"},
        {"Geneva Identification System", "GEN# +1.00339861"},
        {"Smithsonian Astrophysical Observation", "SAO 88497"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.65538947),
        dec: Angle.Degrees(+27.55027938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62576",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8674 A"},
        {"Henry Draper", "HD 111469"},
        {"Hipparcos Number", "HIP 62576"},
        {"Geneva Identification System", "GEN# +1.00111469A"},
        {"Smithsonian Astrophysical Observation", "SAO 82515"},
        {"Wilson Evans Batten Catalogue", "WEB 11106"},
    },
    visualMagnitude: 5.76,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.32296815),
        dec: Angle.Degrees(+27.55232611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58898"},
        {"Hipparcos Number", "HIP 36325"},
        {"Smithsonian Astrophysical Observation", "SAO 79414"},
    },
    visualMagnitude: 6.36,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.16621622),
        dec: Angle.Degrees(+27.55287954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201859"},
        {"Hipparcos Number", "HIP 104607"},
        {"Geneva Identification System", "GEN# +1.00201859"},
        {"Smithsonian Astrophysical Observation", "SAO 89515"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.85926287),
        dec: Angle.Degrees(+27.55355979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11672"},
        {"Hipparcos Number", "HIP 8937"},
        {"Smithsonian Astrophysical Observation", "SAO 75019"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.77096151),
        dec: Angle.Degrees(+27.55418516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 259488"},
        {"Hipparcos Number", "HIP 31319"},
        {"Smithsonian Astrophysical Observation", "SAO 78504"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.52062197),
        dec: Angle.Degrees(+27.55482633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114092"},
        {"Hipparcos Number", "HIP 64077"},
        {"Geneva Identification System", "GEN# +1.00114092"},
        {"Smithsonian Astrophysical Observation", "SAO 82665"},
        {"Wilson Evans Batten Catalogue", "WEB 11327"},
    },
    visualMagnitude: 6.20,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.97358344),
        dec: Angle.Degrees(+27.55610799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33252"},
        {"Hipparcos Number", "HIP 24046"},
        {"Geneva Identification System", "GEN# +1.00033252"},
        {"Smithsonian Astrophysical Observation", "SAO 76998"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.51558529),
        dec: Angle.Degrees(+27.55672199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 197.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78277"},
        {"Hipparcos Number", "HIP 44823"},
        {"Geneva Identification System", "GEN# +1.00078277"},
        {"Smithsonian Astrophysical Observation", "SAO 80653"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.01167554),
        dec: Angle.Degrees(+27.55914623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59561",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59561"},
        {"Geneva Identification System", "GEN# +5.21110020"},
        {"Smithsonian Astrophysical Observation", "SAO 82187"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.21848089),
        dec: Angle.Degrees(+27.56010662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71292"},
        {"Hipparcos Number", "HIP 41487"},
        {"Smithsonian Astrophysical Observation", "SAO 80198"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.91269542),
        dec: Angle.Degrees(+27.56181469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40297"},
        {"Hipparcos Number", "HIP 28327"},
        {"Geneva Identification System", "GEN# +1.00040297"},
        {"Smithsonian Astrophysical Observation", "SAO 77804"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.77349967),
        dec: Angle.Degrees(+27.56185019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165505"},
        {"Hipparcos Number", "HIP 88580"},
        {"Smithsonian Astrophysical Observation", "SAO 85715"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.29153536),
        dec: Angle.Degrees(+27.56437112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159968"},
        {"Hipparcos Number", "HIP 86153"},
        {"Geneva Identification System", "GEN# +1.00159968"},
        {"Smithsonian Astrophysical Observation", "SAO 85239"},
        {"Wilson Evans Batten Catalogue", "WEB 14531"},
    },
    visualMagnitude: 6.37,
    bvColour: 1.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.08926229),
        dec: Angle.Degrees(+27.56680721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101856"},
        {"Hipparcos Number", "HIP 57167"},
        {"Geneva Identification System", "GEN# +1.00101856"},
        {"Smithsonian Astrophysical Observation", "SAO 81956"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.86516274),
        dec: Angle.Degrees(+27.56843959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120567"},
        {"Hipparcos Number", "HIP 67484"},
        {"Geneva Identification System", "GEN# +1.00120567"},
        {"Smithsonian Astrophysical Observation", "SAO 83016"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.43783136),
        dec: Angle.Degrees(+27.56911363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15631"},
        {"Hipparcos Number", "HIP 11741"},
        {"Geneva Identification System", "GEN# +1.00015631"},
        {"Smithsonian Astrophysical Observation", "SAO 75419"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.88340082),
        dec: Angle.Degrees(+27.56927561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18929"},
        {"Hipparcos Number", "HIP 14233"},
        {"Smithsonian Astrophysical Observation", "SAO 75710"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.87603914),
        dec: Angle.Degrees(+27.56961115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41056"},
        {"Hipparcos Number", "HIP 28723"},
        {"Geneva Identification System", "GEN# +1.00041056"},
        {"Smithsonian Astrophysical Observation", "SAO 77909"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.00421717),
        dec: Angle.Degrees(+27.57050820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54967",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8105 AB"},
        {"Henry Draper", "HD 97799"},
        {"Hipparcos Number", "HIP 54967"},
        {"Smithsonian Astrophysical Observation", "SAO 81740"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.83744038),
        dec: Angle.Degrees(+27.57099748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16410",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2582 B"},
        {"Henry Draper", "HD 21743B"},
        {"Hipparcos Number", "HIP 16410"},
        {"Smithsonian Astrophysical Observation", "SAO 75969"},
        {"Wilson Evans Batten Catalogue", "WEB 3137"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.83278591),
        dec: Angle.Degrees(+27.57185735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16411",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2582 A"},
        {"Henry Draper", "HD 21743"},
        {"Henry Draper 2", "HD 21743A"},
        {"Hipparcos Number", "HIP 16411"},
        {"Smithsonian Astrophysical Observation", "SAO 75970"},
        {"Wilson Evans Batten Catalogue", "WEB 3136"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.83636356),
        dec: Angle.Degrees(+27.57188129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69864",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69864"},
        {"Geneva Identification System", "GEN# +0.02802312"},
        {"Smithsonian Astrophysical Observation", "SAO 83276"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.45721784),
        dec: Angle.Degrees(+27.57209631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28500",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4589 A"},
        {"Henry Draper", "HD 40589"},
        {"Hipparcos Number", "HIP 28500"},
        {"Geneva Identification System", "GEN# +1.00040589J"},
        {"Smithsonian Astrophysical Observation", "SAO 77837"},
        {"Wilson Evans Batten Catalogue", "WEB 5570"},
    },
    visualMagnitude: 6.04,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.25189136),
        dec: Angle.Degrees(+27.57236700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85292"},
        {"Hipparcos Number", "HIP 48358"},
        {"Smithsonian Astrophysical Observation", "SAO 81049"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.87666428),
        dec: Angle.Degrees(+27.57326162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224345"},
        {"Hipparcos Number", "HIP 118067"},
        {"Smithsonian Astrophysical Observation", "SAO 91598"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.25826006),
        dec: Angle.Degrees(+27.57373692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220346"},
        {"Hipparcos Number", "HIP 115422"},
        {"Smithsonian Astrophysical Observation", "SAO 91223"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.70914242),
        dec: Angle.Degrees(+27.57445303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117095",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117095"},
        {"Smithsonian Astrophysical Observation", "SAO 91459"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.07231881),
        dec: Angle.Degrees(+27.57536732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103330",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14440 A"},
        {"Henry Draper", "HD 199375"},
        {"Hipparcos Number", "HIP 103330"},
        {"Smithsonian Astrophysical Observation", "SAO 89297"},
        {"Wilson Evans Batten Catalogue", "WEB 18778"},
    },
    visualMagnitude: 6.66,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.00907254),
        dec: Angle.Degrees(+27.57551582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2924"},
        {"Hipparcos Number", "HIP 2565"},
        {"Geneva Identification System", "GEN# +1.00002924"},
        {"Smithsonian Astrophysical Observation", "SAO 74083"},
        {"Wilson Evans Batten Catalogue", "WEB 471"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.14402839),
        dec: Angle.Degrees(+27.58077717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73750",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73750"},
        {"Smithsonian Astrophysical Observation", "SAO 83646"},
    },
    visualMagnitude: 10.29,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.12583067),
        dec: Angle.Degrees(+27.58538230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119686"},
        {"Hipparcos Number", "HIP 67028"},
        {"Geneva Identification System", "GEN# +1.00119686"},
        {"Smithsonian Astrophysical Observation", "SAO 82975"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.04392367),
        dec: Angle.Degrees(+27.58552900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116632",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116632"},
        {"Smithsonian Astrophysical Observation", "SAO 91391"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.53671586),
        dec: Angle.Degrees(+27.58768385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69538",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69538"},
        {"Geneva Identification System", "GEN# +0.02802304"},
        {"Smithsonian Astrophysical Observation", "SAO 83236"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.52969112),
        dec: Angle.Degrees(+27.58810038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65577",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65577"},
    },
    visualMagnitude: 11.23,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.67305945),
        dec: Angle.Degrees(+27.58903750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152748"},
        {"Hipparcos Number", "HIP 82686"},
        {"Geneva Identification System", "GEN# +1.00152748"},
        {"Smithsonian Astrophysical Observation", "SAO 84679"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.52269612),
        dec: Angle.Degrees(+27.59104477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84027",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84027"},
        {"Wilson Evans Batten Catalogue", "WEB 14197"},
    },
    visualMagnitude: 9.74,
    bvColour: 1.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.65447060),
        dec: Angle.Degrees(+27.59165289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131862"},
        {"Hipparcos Number", "HIP 73006"},
        {"Smithsonian Astrophysical Observation", "SAO 83582"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.80198522),
        dec: Angle.Degrees(+27.59256490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22269"},
        {"Hipparcos Number", "HIP 16791"},
        {"Smithsonian Astrophysical Observation", "SAO 76016"},
        {"Wilson Evans Batten Catalogue", "WEB 3197"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.02031042),
        dec: Angle.Degrees(+27.59320486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143175"},
        {"Hipparcos Number", "HIP 78188"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.47337051),
        dec: Angle.Degrees(+27.59450077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74669"},
        {"Hipparcos Number", "HIP 43048"},
        {"Geneva Identification System", "GEN# +1.00074669"},
        {"Smithsonian Astrophysical Observation", "SAO 80409"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.55966200),
        dec: Angle.Degrees(+27.59499181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198199"},
        {"Henry Draper 2", "HD 335258"},
        {"Hipparcos Number", "HIP 102640"},
        {"Geneva Identification System", "GEN# +1.00198199"},
        {"Smithsonian Astrophysical Observation", "SAO 89134"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.96863388),
        dec: Angle.Degrees(+27.59547958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215348"},
        {"Hipparcos Number", "HIP 112250"},
        {"Smithsonian Astrophysical Observation", "SAO 90749"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.03741794),
        dec: Angle.Degrees(+27.59739545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25823"},
        {"Hipparcos Number", "HIP 19171"},
        {"Geneva Identification System", "GEN# +1.00025823"},
        {"Renson", "Renson 6560"},
        {"Smithsonian Astrophysical Observation", "SAO 76455"},
        {"Wilson Evans Batten Catalogue", "WEB 3684"},
    },
    visualMagnitude: 5.18,
    bvColour: -0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.65165830),
        dec: Angle.Degrees(+27.60002519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219779"},
        {"Hipparcos Number", "HIP 115057"},
        {"Geneva Identification System", "GEN# +1.00219779"},
        {"Smithsonian Astrophysical Observation", "SAO 91157"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.56359021),
        dec: Angle.Degrees(+27.60039506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205287"},
        {"Hipparcos Number", "HIP 106446"},
        {"Fundamental Katalog 5th Edition", "FK5 5904"},
        {"Smithsonian Astrophysical Observation", "SAO 89799"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.39876740),
        dec: Angle.Degrees(+27.60269605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219800"},
        {"Hipparcos Number", "HIP 115077"},
        {"Smithsonian Astrophysical Observation", "SAO 91161"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.62043903),
        dec: Angle.Degrees(+27.60391980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33605"},
        {"Hipparcos Number", "HIP 24272"},
        {"Smithsonian Astrophysical Observation", "SAO 77030"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.14207949),
        dec: Angle.Degrees(+27.60426543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60357",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60357"},
        {"Wilson Evans Batten Catalogue", "WEB 10738"},
    },
    visualMagnitude: 10.89,
    bvColour: 1.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.64236941),
        dec: Angle.Degrees(+27.60478283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -142.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64141",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64141"},
        {"Geneva Identification System", "GEN# +0.02802189"},
        {"Smithsonian Astrophysical Observation", "SAO 82674"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.17987798),
        dec: Angle.Degrees(+27.60705030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20825"},
        {"Hipparcos Number", "HIP 15696"},
        {"Geneva Identification System", "GEN# +1.00020825"},
        {"Smithsonian Astrophysical Observation", "SAO 75892"},
        {"Wilson Evans Batten Catalogue", "WEB 3008"},
    },
    visualMagnitude: 5.55,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.54954371),
        dec: Angle.Degrees(+27.60757659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204414"},
        {"Hipparcos Number", "HIP 105966"},
        {"Fundamental Katalog 5th Edition", "FK5 3715"},
        {"Geneva Identification System", "GEN# +1.00204414"},
        {"Smithsonian Astrophysical Observation", "SAO 89720"},
        {"Wilson Evans Batten Catalogue", "WEB 19211"},
    },
    visualMagnitude: 5.39,
    bvColour: 0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.91679163),
        dec: Angle.Degrees(+27.60854356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25626"},
        {"Hipparcos Number", "HIP 19068"},
        {"Geneva Identification System", "GEN# +1.00025626"},
        {"Smithsonian Astrophysical Observation", "SAO 76435"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.30102938),
        dec: Angle.Degrees(+27.60978674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25484",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4032 AB"},
        {"Henry Draper", "HD 35586"},
        {"Hipparcos Number", "HIP 25484"},
        {"Geneva Identification System", "GEN# +1.00035586J"},
        {"Smithsonian Astrophysical Observation", "SAO 77177"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.75548588),
        dec: Angle.Degrees(+27.61026362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1219",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1219"},
        {"Smithsonian Astrophysical Observation", "SAO 73843"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.80340770),
        dec: Angle.Degrees(+27.61199357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39357"},
        {"Hipparcos Number", "HIP 27830"},
        {"Fundamental Katalog 5th Edition", "FK5 1158"},
        {"Geneva Identification System", "GEN# +1.00039357"},
        {"Smithsonian Astrophysical Observation", "SAO 77675"},
        {"Wilson Evans Batten Catalogue", "WEB 5451"},
    },
    visualMagnitude: 4.56,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.33184814),
        dec: Angle.Degrees(+27.61228536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106972",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106972"},
    },
    visualMagnitude: 11.62,
    bvColour: 1.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.97580829),
        dec: Angle.Degrees(+27.61262152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 280.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -230.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42906"},
        {"Hipparcos Number", "HIP 29628"},
        {"Smithsonian Astrophysical Observation", "SAO 78128"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.64882764),
        dec: Angle.Degrees(+27.61376388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145803"},
        {"Hipparcos Number", "HIP 79365"},
        {"Smithsonian Astrophysical Observation", "SAO 84243"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.96878839),
        dec: Angle.Degrees(+27.61394046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34522",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34522"},
    },
    visualMagnitude: 11.42,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.29989123),
        dec: Angle.Degrees(+27.61435856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25229"},
        {"Hipparcos Number", "HIP 18779"},
        {"Smithsonian Astrophysical Observation", "SAO 76396"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.35419648),
        dec: Angle.Degrees(+27.61475358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155180"},
        {"Hipparcos Number", "HIP 83903"},
        {"Smithsonian Astrophysical Observation", "SAO 84875"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.22442721),
        dec: Angle.Degrees(+27.62217927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59509"},
        {"Hipparcos Number", "HIP 36581"},
        {"Geneva Identification System", "GEN# +1.00059509"},
        {"Smithsonian Astrophysical Observation", "SAO 79464"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.85586195),
        dec: Angle.Degrees(+27.62252463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113996"},
        {"Hipparcos Number", "HIP 64022"},
        {"Fundamental Katalog 5th Edition", "FK5 3045"},
        {"Geneva Identification System", "GEN# +1.00113996"},
        {"Smithsonian Astrophysical Observation", "SAO 82659"},
        {"Wilson Evans Batten Catalogue", "WEB 11316"},
    },
    visualMagnitude: 4.80,
    bvColour: 1.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.79461606),
        dec: Angle.Degrees(+27.62490672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139837"},
        {"Hipparcos Number", "HIP 76674"},
        {"Smithsonian Astrophysical Observation", "SAO 83932"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.729,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.85513006),
        dec: Angle.Degrees(+27.62617904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101586"},
        {"Hipparcos Number", "HIP 57024"},
        {"Geneva Identification System", "GEN# +1.00101586"},
        {"Smithsonian Astrophysical Observation", "SAO 81943"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.37973834),
        dec: Angle.Degrees(+27.62694042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219478"},
        {"Hipparcos Number", "HIP 114846"},
        {"Smithsonian Astrophysical Observation", "SAO 91131"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.94512540),
        dec: Angle.Degrees(+27.62965552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9310",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9310"},
        {"Smithsonian Astrophysical Observation", "SAO 75074"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.90447000),
        dec: Angle.Degrees(+27.63045810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45988",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45988"},
    },
    visualMagnitude: 10.72,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.68261953),
        dec: Angle.Degrees(+27.63221703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124019"},
        {"Hipparcos Number", "HIP 69230"},
        {"Geneva Identification System", "GEN# +1.00124019"},
        {"Smithsonian Astrophysical Observation", "SAO 83204"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.61216671),
        dec: Angle.Degrees(+27.63270776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45427"},
        {"Hipparcos Number", "HIP 30823"},
        {"Smithsonian Astrophysical Observation", "SAO 78410"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.13394318),
        dec: Angle.Degrees(+27.63462390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57927"},
        {"Hipparcos Number", "HIP 35941"},
        {"Geneva Identification System", "GEN# +1.00057927"},
        {"Smithsonian Astrophysical Observation", "SAO 79366"},
        {"Wilson Evans Batten Catalogue", "WEB 7158"},
    },
    visualMagnitude: 5.77,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.13935024),
        dec: Angle.Degrees(+27.63781901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78777",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78777"},
        {"Smithsonian Astrophysical Observation", "SAO 84184"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.23910920),
        dec: Angle.Degrees(+27.63880453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72549",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72549"},
    },
    visualMagnitude: 10.50,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.48431303),
        dec: Angle.Degrees(+27.63937437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157966"},
        {"Hipparcos Number", "HIP 85264"},
        {"Smithsonian Astrophysical Observation", "SAO 85071"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.33801301),
        dec: Angle.Degrees(+27.64000527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14665"},
        {"Hipparcos Number", "HIP 11079"},
        {"Smithsonian Astrophysical Observation", "SAO 75319"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.66301895),
        dec: Angle.Degrees(+27.64134550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82174",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82174"},
    },
    visualMagnitude: 10.27,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.83392398),
        dec: Angle.Degrees(+27.64260294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3970"},
        {"Hipparcos Number", "HIP 3331"},
        {"Geneva Identification System", "GEN# +1.00003970"},
        {"Renson", "Renson 1080"},
        {"Smithsonian Astrophysical Observation", "SAO 74215"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.62062101),
        dec: Angle.Degrees(+27.64293680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89190",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11155 AB"},
        {"Henry Draper", "HD 167007"},
        {"Hipparcos Number", "HIP 89190"},
        {"Smithsonian Astrophysical Observation", "SAO 85818"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.02817940),
        dec: Angle.Degrees(+27.64330029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 241105"},
        {"Hipparcos Number", "HIP 24035"},
        {"Cincinnati Publication", "Ci 18 663"},
        {"Geneva Identification System", "GEN# +5.20250152"},
        {"Geneva Identification System 2", "GEN# +1.00241105"},
        {"Smithsonian Astrophysical Observation", "SAO 76996"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.50306378),
        dec: Angle.Degrees(+27.64340005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 207.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65889",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65889"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.804,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.59734303),
        dec: Angle.Degrees(+27.64424877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -186.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146830"},
        {"Hipparcos Number", "HIP 79811"},
        {"Smithsonian Astrophysical Observation", "SAO 84288"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.32962630),
        dec: Angle.Degrees(+27.64481400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94073",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12097 A"},
        {"Henry Draper", "HD 337658"},
        {"Hipparcos Number", "HIP 94073"},
        {"Smithsonian Astrophysical Observation", "SAO 86867"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.25993697),
        dec: Angle.Degrees(+27.64488160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153497"},
        {"Hipparcos Number", "HIP 83096"},
        {"Smithsonian Astrophysical Observation", "SAO 84736"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.69533392),
        dec: Angle.Degrees(+27.64500354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161019"},
        {"Hipparcos Number", "HIP 86627"},
        {"Geneva Identification System", "GEN# +1.00161019"},
        {"Smithsonian Astrophysical Observation", "SAO 85334"},
        {"Wilson Evans Batten Catalogue", "WEB 14608"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.50664766),
        dec: Angle.Degrees(+27.64509390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 335590"},
        {"Hipparcos Number", "HIP 88725"},
        {"Smithsonian Astrophysical Observation", "SAO 85739"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.70399704),
        dec: Angle.Degrees(+27.64519785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126734"},
        {"Hipparcos Number", "HIP 70609"},
        {"Geneva Identification System", "GEN# +1.00126734"},
        {"Smithsonian Astrophysical Observation", "SAO 83357"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.64546480),
        dec: Angle.Degrees(+27.64521330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 242630"},
        {"Hipparcos Number", "HIP 24896"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.04385974),
        dec: Angle.Degrees(+27.64621137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108175",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108175"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.75120531),
        dec: Angle.Degrees(+27.64832256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121149"},
        {"Hipparcos Number", "HIP 67772"},
        {"Geneva Identification System", "GEN# +1.00121149"},
        {"Smithsonian Astrophysical Observation", "SAO 83053"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.26882861),
        dec: Angle.Degrees(+27.64858752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 103.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196297"},
        {"Hipparcos Number", "HIP 101604"},
        {"Smithsonian Astrophysical Observation", "SAO 88875"},
    },
    visualMagnitude: 8.07,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.87137976),
        dec: Angle.Degrees(+27.64888676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46334",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46334"},
        {"Smithsonian Astrophysical Observation", "SAO 80836"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.69741363),
        dec: Angle.Degrees(+27.64918538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 731",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 731"},
    },
    visualMagnitude: 11.65,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.26145881),
        dec: Angle.Degrees(+27.65123946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 223.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 146.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30934",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30934"},
    },
    visualMagnitude: 9.99,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.38453202),
        dec: Angle.Degrees(+27.65429293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 340643"},
        {"Hipparcos Number", "HIP 101837"},
        {"Smithsonian Astrophysical Observation", "SAO 88938"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.56461752),
        dec: Angle.Degrees(+27.65543042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197194"},
        {"Hipparcos Number", "HIP 102086"},
        {"Smithsonian Astrophysical Observation", "SAO 89010"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.33504928),
        dec: Angle.Degrees(+27.65601513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5705"},
        {"Hipparcos Number", "HIP 4608"},
        {"Smithsonian Astrophysical Observation", "SAO 74415"},
        {"Wilson Evans Batten Catalogue", "WEB 852"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.76262924),
        dec: Angle.Degrees(+27.65711844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75913",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9677 A"},
        {"Henry Draper", "HD 138305"},
        {"Hipparcos Number", "HIP 75913"},
        {"Smithsonian Astrophysical Observation", "SAO 83857"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.58479882),
        dec: Angle.Degrees(+27.65825832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14876"},
        {"Hipparcos Number", "HIP 11239"},
        {"Smithsonian Astrophysical Observation", "SAO 75343"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.16684711),
        dec: Angle.Degrees(+27.65953338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 337174"},
        {"Hipparcos Number", "HIP 93001"},
        {"Smithsonian Astrophysical Observation", "SAO 86608"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.19287106),
        dec: Angle.Degrees(+27.66047113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57298",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57298"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.23610310),
        dec: Angle.Degrees(+27.66179830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36859"},
        {"Hipparcos Number", "HIP 26291"},
        {"Geneva Identification System", "GEN# +1.00036859"},
        {"Smithsonian Astrophysical Observation", "SAO 77295"},
        {"Wilson Evans Batten Catalogue", "WEB 5164"},
    },
    visualMagnitude: 6.27,
    bvColour: 1.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.98132170),
        dec: Angle.Degrees(+27.66242330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 337777"},
        {"Hipparcos Number", "HIP 94444"},
        {"Smithsonian Astrophysical Observation", "SAO 86946"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.32125695),
        dec: Angle.Degrees(+27.66869327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158416"},
        {"Hipparcos Number", "HIP 85475"},
        {"Smithsonian Astrophysical Observation", "SAO 85116"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.01207563),
        dec: Angle.Degrees(+27.66925409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48638"},
        {"Hipparcos Number", "HIP 32389"},
        {"Smithsonian Astrophysical Observation", "SAO 78710"},
        {"Wilson Evans Batten Catalogue", "WEB 6532"},
    },
    visualMagnitude: 6.70,
    bvColour: 1.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.39624738),
        dec: Angle.Degrees(+27.67324853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69461",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69461"},
        {"Geneva Identification System", "GEN# +0.02802302"},
        {"Smithsonian Astrophysical Observation", "SAO 83229"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.31685883),
        dec: Angle.Degrees(+27.67453134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225292"},
        {"Hipparcos Number", "HIP 410"},
        {"Fundamental Katalog 5th Edition", "FK5 2003"},
        {"Geneva Identification System", "GEN# +1.00225292"},
        {"Smithsonian Astrophysical Observation", "SAO 73733"},
        {"Wilson Evans Batten Catalogue", "WEB 63"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.25472644),
        dec: Angle.Degrees(+27.67479979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65841",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65841"},
        {"Geneva Identification System", "GEN# +0.02802231"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.44887766),
        dec: Angle.Degrees(+27.67500497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105927",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105927"},
    },
    visualMagnitude: 11.46,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.81098385),
        dec: Angle.Degrees(+27.68025204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -165.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117511",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17030 AB"},
        {"Henry Draper", "HD 223486"},
        {"Hipparcos Number", "HIP 117511"},
        {"Smithsonian Astrophysical Observation", "SAO 91524"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.46031735),
        dec: Angle.Degrees(+27.68075147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211784"},
        {"Hipparcos Number", "HIP 110185"},
        {"Geneva Identification System", "GEN# +1.00211784"},
        {"Smithsonian Astrophysical Observation", "SAO 90414"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.78071015),
        dec: Angle.Degrees(+27.68189900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84504",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84504"},
        {"Smithsonian Astrophysical Observation", "SAO 84966"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.13666356),
        dec: Angle.Degrees(+27.68323151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215306"},
        {"Hipparcos Number", "HIP 112226"},
        {"Geneva Identification System", "GEN# +1.00215306"},
        {"Smithsonian Astrophysical Observation", "SAO 90743"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.95366444),
        dec: Angle.Degrees(+27.68384984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14949"},
        {"Hipparcos Number", "HIP 11282"},
        {"Geneva Identification System", "GEN# +1.00014949"},
        {"Smithsonian Astrophysical Observation", "SAO 75352"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.32857895),
        dec: Angle.Degrees(+27.68386811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38998"},
        {"Hipparcos Number", "HIP 27613"},
        {"Geneva Identification System", "GEN# +1.00038998"},
        {"Smithsonian Astrophysical Observation", "SAO 77621"},
        {"Wilson Evans Batten Catalogue", "WEB 5421"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.70078123),
        dec: Angle.Degrees(+27.68594176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19165"},
        {"Hipparcos Number", "HIP 14405"},
        {"Geneva Identification System", "GEN# +1.00019165"},
        {"Smithsonian Astrophysical Observation", "SAO 75730"},
        {"Wilson Evans Batten Catalogue", "WEB 2811"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.44974744),
        dec: Angle.Degrees(+27.68658310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29883"},
        {"Hipparcos Number", "HIP 21988"},
        {"Cincinnati Publication", "Ci 18 608"},
        {"Geneva Identification System", "GEN# +1.00029883"},
        {"Smithsonian Astrophysical Observation", "SAO 76728"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.89750181),
        dec: Angle.Degrees(+27.68804625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -265.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206013"},
        {"Hipparcos Number", "HIP 106852"},
        {"Smithsonian Astrophysical Observation", "SAO 89868"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.62878093),
        dec: Angle.Degrees(+27.68851997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115665",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16748 C"},
        {"Henry Draper", "HD 220724"},
        {"Hipparcos Number", "HIP 115665"},
        {"Geneva Identification System", "GEN# +1.00220724"},
        {"Smithsonian Astrophysical Observation", "SAO 91257"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.49382213),
        dec: Angle.Degrees(+27.69014055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64646"},
        {"Hipparcos Number", "HIP 38749"},
        {"Smithsonian Astrophysical Observation", "SAO 79802"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.99635934),
        dec: Angle.Degrees(+27.69302735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169886"},
        {"Hipparcos Number", "HIP 90310"},
        {"Geneva Identification System", "GEN# +1.00169886"},
        {"Smithsonian Astrophysical Observation", "SAO 86032"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.39459799),
        dec: Angle.Degrees(+27.69372104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 115.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113826",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113826"},
        {"Smithsonian Astrophysical Observation", "SAO 90971"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.75825890),
        dec: Angle.Degrees(+27.69525144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85672"},
        {"Hipparcos Number", "HIP 48541"},
        {"Smithsonian Astrophysical Observation", "SAO 81072"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.49656377),
        dec: Angle.Degrees(+27.69546527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32480"},
        {"Hipparcos Number", "HIP 23614"},
        {"Geneva Identification System", "GEN# +1.00032480"},
        {"Smithsonian Astrophysical Observation", "SAO 76941"},
        {"Wilson Evans Batten Catalogue", "WEB 4603"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.15811247),
        dec: Angle.Degrees(+27.69612305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 337778"},
        {"Hipparcos Number", "HIP 94405"},
        {"Smithsonian Astrophysical Observation", "SAO 86938"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.21657000),
        dec: Angle.Degrees(+27.69767564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187255"},
        {"Hipparcos Number", "HIP 97426"},
        {"Celescope Catalog", "CEL 4846"},
        {"Geneva Identification System", "GEN# +1.00187255"},
        {"Smithsonian Astrophysical Observation", "SAO 87734"},
        {"Wilson Evans Batten Catalogue", "WEB 17121"},
    },
    visualMagnitude: 7.57,
    bvColour: -0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.01806463),
        dec: Angle.Degrees(+27.70282698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109202",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109202"},
        {"Smithsonian Astrophysical Observation", "SAO 90242"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.82948374),
        dec: Angle.Degrees(+27.70391903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9099"},
        {"Hipparcos Number", "HIP 6997"},
        {"Smithsonian Astrophysical Observation", "SAO 74756"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.51997850),
        dec: Angle.Degrees(+27.70512156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186075"},
        {"Hipparcos Number", "HIP 96863"},
        {"Geneva Identification System", "GEN# +1.00186075"},
        {"Smithsonian Astrophysical Observation", "SAO 87571"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.33905280),
        dec: Angle.Degrees(+27.70530569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16908"},
        {"Hipparcos Number", "HIP 12719"},
        {"Fundamental Katalog 5th Edition", "FK5 94"},
        {"Geneva Identification System", "GEN# +1.00016908"},
        {"Smithsonian Astrophysical Observation", "SAO 75532"},
        {"Wilson Evans Batten Catalogue", "WEB 2586"},
    },
    visualMagnitude: 4.65,
    bvColour: -0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.86296031),
        dec: Angle.Degrees(+27.70717078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115666",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16748 AB"},
        {"Henry Draper", "HD 220723"},
        {"Hipparcos Number", "HIP 115666"},
        {"Smithsonian Astrophysical Observation", "SAO 91258"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.49885172),
        dec: Angle.Degrees(+27.70717190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149241"},
        {"Hipparcos Number", "HIP 80993"},
        {"Smithsonian Astrophysical Observation", "SAO 84443"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.11200577),
        dec: Angle.Degrees(+27.70944055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3885",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 683 AB"},
        {"Hipparcos Number", "HIP 3885"},
    },
    visualMagnitude: 5.55,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.47128657),
        dec: Angle.Degrees(+27.71031105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2541",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2541"},
        {"Smithsonian Astrophysical Observation", "SAO 74077"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.08482761),
        dec: Angle.Degrees(+27.71185065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 337518"},
        {"Hipparcos Number", "HIP 93817"},
        {"Smithsonian Astrophysical Observation", "SAO 86811"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.58902899),
        dec: Angle.Degrees(+27.71377132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -202.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3067",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3067"},
        {"Smithsonian Astrophysical Observation", "SAO 74167"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.73000221),
        dec: Angle.Degrees(+27.71515455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39746"},
        {"Hipparcos Number", "HIP 28033"},
        {"Geneva Identification System", "GEN# +1.00039746"},
        {"Smithsonian Astrophysical Observation", "SAO 77724"},
        {"Wilson Evans Batten Catalogue", "WEB 5489"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.91776151),
        dec: Angle.Degrees(+27.71565560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223289"},
        {"Hipparcos Number", "HIP 117393"},
        {"Geneva Identification System", "GEN# +1.00223289"},
        {"Smithsonian Astrophysical Observation", "SAO 91497"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.04928761),
        dec: Angle.Degrees(+27.71576294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187851"},
        {"Hipparcos Number", "HIP 97681"},
        {"Celescope Catalog", "CEL 4860"},
        {"Geneva Identification System", "GEN# +1.00187851"},
        {"Smithsonian Astrophysical Observation", "SAO 87816"},
        {"Wilson Evans Batten Catalogue", "WEB 17182"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.76974381),
        dec: Angle.Degrees(+27.71691781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174414"},
        {"Hipparcos Number", "HIP 92343"},
        {"Smithsonian Astrophysical Observation", "SAO 86464"},
        {"Wilson Evans Batten Catalogue", "WEB 15945"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.30574728),
        dec: Angle.Degrees(+27.72014161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 338772"},
        {"Hipparcos Number", "HIP 97102"},
        {"Smithsonian Astrophysical Observation", "SAO 87644"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.01314529),
        dec: Angle.Degrees(+27.72082358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13609",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2215 A"},
        {"Henry Draper", "HD 18104"},
        {"Hipparcos Number", "HIP 13609"},
        {"Smithsonian Astrophysical Observation", "SAO 75638"},
    },
    visualMagnitude: 6.84,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.84171633),
        dec: Angle.Degrees(+27.72242075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86974",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10786 A"},
        {"Henry Draper", "HD 161797"},
        {"Henry Draper 2", "HD 161797A"},
        {"Hipparcos Number", "HIP 86974"},
        {"Cincinnati Publication", "Ci 20 1065"},
        {"Fundamental Katalog 5th Edition", "FK5 667"},
        {"Geneva Identification System", "GEN# +1.00161797A"},
        {"Smithsonian Astrophysical Observation", "SAO 85397"},
        {"Wilson Evans Batten Catalogue", "WEB 14673"},
    },
    visualMagnitude: 3.42,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.61549553),
        dec: Angle.Degrees(+27.72249917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -291.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -750.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106811",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106811"},
        {"Cincinnati Publication", "Ci 20 1299"},
        {"Geneva Identification System", "GEN# +0.02704120"},
        {"Wilson Evans Batten Catalogue", "WEB 19310"},
    },
    visualMagnitude: 9.83,
    bvColour: 1.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.50030674),
        dec: Angle.Degrees(+27.72392564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 472.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21685"},
        {"Hipparcos Number", "HIP 16378"},
        {"Geneva Identification System", "GEN# +1.00021685"},
        {"Smithsonian Astrophysical Observation", "SAO 75962"},
        {"Wilson Evans Batten Catalogue", "WEB 3130"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.75319974),
        dec: Angle.Degrees(+27.72435763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108807",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108807"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.63366676),
        dec: Angle.Degrees(+27.72471261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199056"},
        {"Hipparcos Number", "HIP 103134"},
        {"Smithsonian Astrophysical Observation", "SAO 89254"},
    },
    visualMagnitude: 8.91,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.43493187),
        dec: Angle.Degrees(+27.72618189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123339"},
        {"Hipparcos Number", "HIP 68903"},
        {"Geneva Identification System", "GEN# +1.00123339"},
        {"Smithsonian Astrophysical Observation", "SAO 83166"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.60599381),
        dec: Angle.Degrees(+27.72641238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113032",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113032"},
        {"Smithsonian Astrophysical Observation", "SAO 90856"},
    },
    visualMagnitude: 10.69,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.37032235),
        dec: Angle.Degrees(+27.72753258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185982"},
        {"Hipparcos Number", "HIP 96814"},
        {"Geneva Identification System", "GEN# +1.00185982"},
        {"Smithsonian Astrophysical Observation", "SAO 87559"},
        {"Wilson Evans Batten Catalogue", "WEB 16992"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.18885103),
        dec: Angle.Degrees(+27.72972831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89629"},
        {"Hipparcos Number", "HIP 50686"},
        {"Smithsonian Astrophysical Observation", "SAO 81305"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.916,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.26512140),
        dec: Angle.Degrees(+27.73031313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108976"},
        {"Hipparcos Number", "HIP 61074"},
        {"Geneva Identification System", "GEN# +5.21110162"},
        {"Smithsonian Astrophysical Observation", "SAO 82348"},
        {"Wilson Evans Batten Catalogue", "WEB 10874"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.76294218),
        dec: Angle.Degrees(+27.73035966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174733"},
        {"Hipparcos Number", "HIP 92479"},
        {"Geneva Identification System", "GEN# +1.00174733"},
        {"Smithsonian Astrophysical Observation", "SAO 86501"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.71117073),
        dec: Angle.Degrees(+27.73057298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44451"},
        {"Hipparcos Number", "HIP 30354"},
        {"Smithsonian Astrophysical Observation", "SAO 78299"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.77419464),
        dec: Angle.Degrees(+27.73127427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38084"},
        {"Hipparcos Number", "HIP 27063"},
        {"Smithsonian Astrophysical Observation", "SAO 77478"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.08817523),
        dec: Angle.Degrees(+27.73148079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21700"},
        {"Hipparcos Number", "HIP 16386"},
        {"Geneva Identification System", "GEN# +1.00021700"},
        {"Smithsonian Astrophysical Observation", "SAO 75964"},
        {"Wilson Evans Batten Catalogue", "WEB 3131"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.76435587),
        dec: Angle.Degrees(+27.73161431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187462"},
        {"Hipparcos Number", "HIP 97509"},
        {"Geneva Identification System", "GEN# +1.00187462"},
        {"Smithsonian Astrophysical Observation", "SAO 87766"},
        {"Wilson Evans Batten Catalogue", "WEB 17145"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.28543324),
        dec: Angle.Degrees(+27.73222024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -216.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1699",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 295 A"},
        {"Henry Draper", "HD 1688"},
        {"Hipparcos Number", "HIP 1699"},
        {"Smithsonian Astrophysical Observation", "SAO 73916"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.844,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.33903037),
        dec: Angle.Degrees(+27.73362994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124883"},
        {"Hipparcos Number", "HIP 69661"},
        {"Geneva Identification System", "GEN# +1.00124883"},
        {"Renson", "Renson 35700"},
        {"Smithsonian Astrophysical Observation", "SAO 83254"},
        {"Wilson Evans Batten Catalogue", "WEB 12130"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.85991473),
        dec: Angle.Degrees(+27.73407530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115339"},
        {"Hipparcos Number", "HIP 64761"},
        {"Cincinnati Publication", "Ci 18 1710"},
        {"Geneva Identification System", "GEN# +1.00115339"},
        {"Smithsonian Astrophysical Observation", "SAO 82746"},
        {"Wilson Evans Batten Catalogue", "WEB 11446"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.08279336),
        dec: Angle.Degrees(+27.73529151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -364.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86659",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86659"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.59222156),
        dec: Angle.Degrees(+27.73532163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210646"},
        {"Hipparcos Number", "HIP 109531"},
        {"Smithsonian Astrophysical Observation", "SAO 90303"},
        {"Wilson Evans Batten Catalogue", "WEB 19677"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.81125777),
        dec: Angle.Degrees(+27.73665784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60889"},
        {"Hipparcos Number", "HIP 37131"},
        {"Smithsonian Astrophysical Observation", "SAO 79557"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.44506529),
        dec: Angle.Degrees(+27.73908485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143291"},
        {"Hipparcos Number", "HIP 78241"},
        {"Cincinnati Publication", "Ci 20 956"},
        {"Geneva Identification System", "GEN# +1.00143291"},
        {"Smithsonian Astrophysical Observation", "SAO 84112"},
        {"Wilson Evans Batten Catalogue", "WEB 13233"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.757,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.63557861),
        dec: Angle.Degrees(+27.73927537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -775.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 296.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184402"},
        {"Hipparcos Number", "HIP 96173"},
        {"Smithsonian Astrophysical Observation", "SAO 87352"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.32897248),
        dec: Angle.Degrees(+27.73967059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106814"},
        {"Hipparcos Number", "HIP 59889"},
        {"Geneva Identification System", "GEN# +5.21110043"},
        {"Smithsonian Astrophysical Observation", "SAO 82215"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.23589281),
        dec: Angle.Degrees(+27.73975556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94718"},
        {"Hipparcos Number", "HIP 53471"},
        {"Cincinnati Publication", "Ci 20 597"},
        {"Geneva Identification System", "GEN# +1.00094718"},
        {"Smithsonian Astrophysical Observation", "SAO 81588"},
        {"Wilson Evans Batten Catalogue", "WEB 9704"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.06946782),
        dec: Angle.Degrees(+27.73991795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -451.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -132.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17125",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17125"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.01278519),
        dec: Angle.Degrees(+27.74062177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84320"},
        {"Hipparcos Number", "HIP 47847"},
        {"Geneva Identification System", "GEN# +1.00084320"},
        {"Smithsonian Astrophysical Observation", "SAO 81000"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.29374276),
        dec: Angle.Degrees(+27.74152030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55843",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55843"},
    },
    visualMagnitude: 10.89,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.67677786),
        dec: Angle.Degrees(+27.74288696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217229"},
        {"Hipparcos Number", "HIP 113486"},
        {"Geneva Identification System", "GEN# +1.00217229"},
        {"Smithsonian Astrophysical Observation", "SAO 90914"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.74374412),
        dec: Angle.Degrees(+27.74586422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110882"},
        {"Hipparcos Number", "HIP 62218"},
        {"Geneva Identification System", "GEN# +1.00110882"},
        {"Smithsonian Astrophysical Observation", "SAO 82472"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.27031989),
        dec: Angle.Degrees(+27.74709335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 74.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4868",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 857 A"},
        {"Henry Draper", "HD 6093"},
        {"Hipparcos Number", "HIP 4868"},
        {"Geneva Identification System", "GEN# +1.00006093"},
        {"Smithsonian Astrophysical Observation", "SAO 74443"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.64821189),
        dec: Angle.Degrees(+27.74793166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283843"},
        {"Hipparcos Number", "HIP 22409"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.33339774),
        dec: Angle.Degrees(+27.74835804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136528"},
        {"Hipparcos Number", "HIP 75058"},
        {"Geneva Identification System", "GEN# +1.00136528"},
        {"Smithsonian Astrophysical Observation", "SAO 83770"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.07341366),
        dec: Angle.Degrees(+27.74970675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33915",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33915"},
    },
    visualMagnitude: 10.78,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.57393661),
        dec: Angle.Degrees(+27.75152823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189849"},
        {"Hipparcos Number", "HIP 98543"},
        {"Fundamental Katalog 5th Edition", "FK5 1523"},
        {"Geneva Identification System", "GEN# +1.00189849"},
        {"Renson", "Renson 52650"},
        {"Smithsonian Astrophysical Observation", "SAO 88071"},
        {"Wilson Evans Batten Catalogue", "WEB 17413"},
    },
    visualMagnitude: 4.66,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.27504217),
        dec: Angle.Degrees(+27.75356392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148097"},
        {"Hipparcos Number", "HIP 80409"},
        {"Geneva Identification System", "GEN# +1.00148097"},
        {"Renson", "Renson 41830"},
        {"Smithsonian Astrophysical Observation", "SAO 84361"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.19027265),
        dec: Angle.Degrees(+27.75410180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113033",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113033"},
        {"Cincinnati Publication", "Ci 20 1388"},
    },
    visualMagnitude: 11.46,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.37155114),
        dec: Angle.Degrees(+27.75540941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 502.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -186.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 340900"},
        {"Hipparcos Number", "HIP 102199"},
        {"Smithsonian Astrophysical Observation", "SAO 89034"},
        {"Wilson Evans Batten Catalogue", "WEB 18493"},
    },
    visualMagnitude: 8.85,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.61450463),
        dec: Angle.Degrees(+27.75625220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10095"},
        {"Hipparcos Number", "HIP 7708"},
        {"Geneva Identification System", "GEN# +1.00010095"},
        {"Smithsonian Astrophysical Observation", "SAO 74853"},
        {"Wilson Evans Batten Catalogue", "WEB 1649"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.80949533),
        dec: Angle.Degrees(+27.75655114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87357",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87357"},
        {"Smithsonian Astrophysical Observation", "SAO 85470"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.74965321),
        dec: Angle.Degrees(+27.75719620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83098"},
        {"Hipparcos Number", "HIP 47173"},
        {"Smithsonian Astrophysical Observation", "SAO 80925"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.20406681),
        dec: Angle.Degrees(+27.75854153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218562"},
        {"Hipparcos Number", "HIP 114279"},
        {"Smithsonian Astrophysical Observation", "SAO 91039"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.19291223),
        dec: Angle.Degrees(+27.75859887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86358"},
        {"Hipparcos Number", "HIP 48895"},
        {"Geneva Identification System", "GEN# +1.00086358"},
        {"Smithsonian Astrophysical Observation", "SAO 81120"},
        {"Wilson Evans Batten Catalogue", "WEB 9084"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.60881468),
        dec: Angle.Degrees(+27.75906843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -116.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22669"},
        {"Hipparcos Number", "HIP 17090"},
        {"Smithsonian Astrophysical Observation", "SAO 76057"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.91411375),
        dec: Angle.Degrees(+27.75935441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283744"},
        {"Hipparcos Number", "HIP 21531"},
    },
    visualMagnitude: 10.46,
    bvColour: 0.738,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.35084730),
        dec: Angle.Degrees(+27.75985397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80551",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80551"},
        {"Smithsonian Astrophysical Observation", "SAO 84379"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.68811466),
        dec: Angle.Degrees(+27.76037329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193704"},
        {"Hipparcos Number", "HIP 100316"},
        {"Smithsonian Astrophysical Observation", "SAO 88547"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.17633599),
        dec: Angle.Degrees(+27.76179249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212830"},
        {"Hipparcos Number", "HIP 110783"},
        {"Smithsonian Astrophysical Observation", "SAO 90509"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.65198002),
        dec: Angle.Degrees(+27.76266495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86423",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86423"},
    },
    visualMagnitude: 11.07,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.87791843),
        dec: Angle.Degrees(+27.76270912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -198.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62462",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62462"},
        {"Geneva Identification System", "GEN# +8.00280119"},
    },
    visualMagnitude: 11.40,
    bvColour: 1.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.01101932),
        dec: Angle.Degrees(+27.76426788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -194.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -383.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44115",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44115"},
    },
    visualMagnitude: 11.85,
    bvColour: 1.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.77373676),
        dec: Angle.Degrees(+36.44310313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -376.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -398.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54146",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54146"},
        {"Smithsonian Astrophysical Observation", "SAO 81653"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.14889983),
        dec: Angle.Degrees(+27.76534935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34259"},
        {"Hipparcos Number", "HIP 24647"},
        {"Smithsonian Astrophysical Observation", "SAO 77080"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.33615981),
        dec: Angle.Degrees(+27.76538859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24648",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 9.39,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)17, 21.6000),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)45, 59.300)
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
    primaryId: "HIP 63048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112257"},
        {"Hipparcos Number", "HIP 63048"},
        {"Geneva Identification System", "GEN# +1.00112257"},
        {"Smithsonian Astrophysical Observation", "SAO 82565"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.78446588),
        dec: Angle.Degrees(+27.76653616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81535",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81535"},
        {"Smithsonian Astrophysical Observation", "SAO 84515"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.80403375),
        dec: Angle.Degrees(+27.76710759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56453",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56453"},
        {"Smithsonian Astrophysical Observation", "SAO 81882"},
        {"Wilson Evans Batten Catalogue", "WEB 10146"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.62682498),
        dec: Angle.Degrees(+27.76807283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36215"},
        {"Hipparcos Number", "HIP 25871"},
        {"Geneva Identification System", "GEN# +1.00036215"},
        {"Smithsonian Astrophysical Observation", "SAO 77224"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.84472469),
        dec: Angle.Degrees(+27.76914999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37738"},
        {"Hipparcos Number", "HIP 26852"},
        {"Fundamental Katalog 5th Edition", "FK5 4521"},
        {"Smithsonian Astrophysical Observation", "SAO 77415"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.51086993),
        dec: Angle.Degrees(+27.77070358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33657"},
        {"Hipparcos Number", "HIP 24304"},
        {"Smithsonian Astrophysical Observation", "SAO 77034"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.23091478),
        dec: Angle.Degrees(+27.77381881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100947"},
        {"Hipparcos Number", "HIP 56672"},
        {"Geneva Identification System", "GEN# +1.00100947"},
        {"Smithsonian Astrophysical Observation", "SAO 81903"},
        {"Wilson Evans Batten Catalogue", "WEB 10188"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.30779224),
        dec: Angle.Degrees(+27.77392524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85440"},
        {"Hipparcos Number", "HIP 48433"},
        {"Smithsonian Astrophysical Observation", "SAO 81061"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.878,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.11954998),
        dec: Angle.Degrees(+27.77409258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91348"},
        {"Hipparcos Number", "HIP 51664"},
        {"Geneva Identification System", "GEN# +1.00091348"},
        {"Smithsonian Astrophysical Observation", "SAO 81408"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.749,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.32059429),
        dec: Angle.Degrees(+27.77532796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23460"},
        {"Hipparcos Number", "HIP 17613"},
        {"Smithsonian Astrophysical Observation", "SAO 76170"},
    },
    visualMagnitude: 9.24,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.59758272),
        dec: Angle.Degrees(+27.77578516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192913"},
        {"Henry Draper 2", "HD 192913A"},
        {"Hipparcos Number", "HIP 99927"},
        {"Geneva Identification System", "GEN# +1.00192913"},
        {"Renson", "Renson 53840"},
        {"Smithsonian Astrophysical Observation", "SAO 88444"},
        {"Wilson Evans Batten Catalogue", "WEB 17975"},
    },
    visualMagnitude: 6.65,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.11331731),
        dec: Angle.Degrees(+27.77606655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91842"},
        {"Hipparcos Number", "HIP 51953"},
        {"Geneva Identification System", "GEN# +1.00091842"},
        {"Smithsonian Astrophysical Observation", "SAO 81434"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.19555629),
        dec: Angle.Degrees(+27.77636429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61835",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61835"},
        {"Geneva Identification System", "GEN# +0.02802142"},
    },
    visualMagnitude: 10.80,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.07401987),
        dec: Angle.Degrees(+27.77636804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127577"},
        {"Hipparcos Number", "HIP 71016"},
        {"Smithsonian Astrophysical Observation", "SAO 83390"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.85874183),
        dec: Angle.Degrees(+27.77775403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40311",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6662 A"},
        {"Henry Draper", "HD 68542"},
        {"Hipparcos Number", "HIP 40311"},
        {"Geneva Identification System", "GEN# +1.00068542"},
        {"Renson", "Renson 18990"},
        {"Smithsonian Astrophysical Observation", "SAO 80025"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.47299644),
        dec: Angle.Degrees(+27.77861171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116052",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116052"},
        {"Smithsonian Astrophysical Observation", "SAO 91313"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.796,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.72696648),
        dec: Angle.Degrees(+27.77877545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -136.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -132.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4963"},
        {"Hipparcos Number", "HIP 4050"},
        {"Geneva Identification System", "GEN# +1.00004963"},
        {"Smithsonian Astrophysical Observation", "SAO 74324"},
        {"Wilson Evans Batten Catalogue", "WEB 725"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.97642959),
        dec: Angle.Degrees(+27.77945384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118075",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118075"},
        {"Smithsonian Astrophysical Observation", "SAO 91600"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.719,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.28271192),
        dec: Angle.Degrees(+27.77971732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28225"},
        {"Hipparcos Number", "HIP 20864"},
        {"Geneva Identification System", "GEN# +1.00028225"},
        {"Smithsonian Astrophysical Observation", "SAO 76619"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.07461228),
        dec: Angle.Degrees(+27.78069492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56601",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8231 AB"},
        {"Henry Draper", "HD 100808"},
        {"Hipparcos Number", "HIP 56601"},
        {"Geneva Identification System", "GEN# +1.00100808J"},
        {"Smithsonian Astrophysical Observation", "SAO 81893"},
        {"Wilson Evans Batten Catalogue", "WEB 10175"},
    },
    visualMagnitude: 5.80,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.07475383),
        dec: Angle.Degrees(+27.78130214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55180"},
        {"Hipparcos Number", "HIP 34885"},
        {"Geneva Identification System", "GEN# +1.00055180"},
        {"Smithsonian Astrophysical Observation", "SAO 79180"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.27751895),
        dec: Angle.Degrees(+27.78259257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79394"},
        {"Hipparcos Number", "HIP 45359"},
        {"Smithsonian Astrophysical Observation", "SAO 80711"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.64952876),
        dec: Angle.Degrees(+27.78387709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111348"},
        {"Hipparcos Number", "HIP 62499"},
        {"Geneva Identification System", "GEN# +1.00111348"},
        {"Smithsonian Astrophysical Observation", "SAO 82507"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.10716020),
        dec: Angle.Degrees(+27.78392848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111608",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16103 A"},
        {"Henry Draper", "HD 214265"},
        {"Hipparcos Number", "HIP 111608"},
        {"Smithsonian Astrophysical Observation", "SAO 90640"},
        {"Wilson Evans Batten Catalogue", "WEB 19950"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.15922805),
        dec: Angle.Degrees(+27.78418034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66216"},
        {"Hipparcos Number", "HIP 39424"},
        {"Fundamental Katalog 5th Edition", "FK5 305"},
        {"Geneva Identification System", "GEN# +1.00066216"},
        {"Smithsonian Astrophysical Observation", "SAO 79896"},
        {"Wilson Evans Batten Catalogue", "WEB 7712"},
    },
    visualMagnitude: 4.94,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.87957982),
        dec: Angle.Degrees(+27.79441794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57791"},
        {"Hipparcos Number", "HIP 35891"},
        {"Geneva Identification System", "GEN# +1.00057791"},
        {"Smithsonian Astrophysical Observation", "SAO 79358"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.98565693),
        dec: Angle.Degrees(+27.79462068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87082",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87082"},
        {"Cincinnati Publication", "Ci 18 2368"},
        {"Geneva Identification System", "GEN# +0.02702891"},
        {"Smithsonian Astrophysical Observation", "SAO 85416"},
        {"Wilson Evans Batten Catalogue", "WEB 14694"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.91358450),
        dec: Angle.Degrees(+27.79508072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -132.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -212.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58207"},
        {"Hipparcos Number", "HIP 36046"},
        {"Fundamental Katalog 5th Edition", "FK5 282"},
        {"Geneva Identification System", "GEN# +1.00058207"},
        {"Smithsonian Astrophysical Observation", "SAO 79374"},
        {"Wilson Evans Batten Catalogue", "WEB 7182"},
    },
    visualMagnitude: 3.78,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.43198371),
        dec: Angle.Degrees(+27.79828561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -121.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107946",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15401 AB"},
        {"Henry Draper", "HD 207931"},
        {"Hipparcos Number", "HIP 107946"},
        {"Smithsonian Astrophysical Observation", "SAO 90057"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.03724487),
        dec: Angle.Degrees(+27.80059857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63199",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63199"},
        {"Geneva Identification System", "GEN# +0.02802169"},
        {"Smithsonian Astrophysical Observation", "SAO 82578"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.21642322),
        dec: Angle.Degrees(+27.80274577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211432"},
        {"Hipparcos Number", "HIP 109977"},
        {"Geneva Identification System", "GEN# +1.00211432"},
        {"Smithsonian Astrophysical Observation", "SAO 90379"},
        {"Wilson Evans Batten Catalogue", "WEB 19744"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.12356919),
        dec: Angle.Degrees(+27.80404024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11928"},
        {"Hipparcos Number", "HIP 9132"},
        {"Geneva Identification System", "GEN# +1.00011928"},
        {"Smithsonian Astrophysical Observation", "SAO 75048"},
        {"Wilson Evans Batten Catalogue", "WEB 1918"},
    },
    visualMagnitude: 5.84,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.43223051),
        dec: Angle.Degrees(+27.80452380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 335488"},
        {"Hipparcos Number", "HIP 88218"},
        {"Smithsonian Astrophysical Observation", "SAO 85638"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.24011221),
        dec: Angle.Degrees(+27.80495823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105310",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105310"},
        {"Renson", "Renson 56570"},
        {"Smithsonian Astrophysical Observation", "SAO 89623"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.93791794),
        dec: Angle.Degrees(+27.80606531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 333489"},
        {"Hipparcos Number", "HIP 98735"},
        {"Smithsonian Astrophysical Observation", "SAO 88124"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.81221645),
        dec: Angle.Degrees(+27.80656492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200391"},
        {"Hipparcos Number", "HIP 103833"},
        {"Geneva Identification System", "GEN# +1.00200391"},
        {"Smithsonian Astrophysical Observation", "SAO 89396"},
        {"Wilson Evans Batten Catalogue", "WEB 18903"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.60770637),
        dec: Angle.Degrees(+27.80732971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121131"},
        {"Hipparcos Number", "HIP 67773"},
        {"Cincinnati Publication", "Ci 20 820"},
        {"Geneva Identification System", "GEN# +1.00121131"},
        {"Smithsonian Astrophysical Observation", "SAO 83052"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.815,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.27142792),
        dec: Angle.Degrees(+27.80774150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 239.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -395.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12526",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12526"},
        {"Smithsonian Astrophysical Observation", "SAO 75517"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.29647294),
        dec: Angle.Degrees(+27.80799799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192806"},
        {"Hipparcos Number", "HIP 99874"},
        {"Geneva Identification System", "GEN# +1.00192806"},
        {"Smithsonian Astrophysical Observation", "SAO 88428"},
        {"Wilson Evans Batten Catalogue", "WEB 17963"},
    },
    visualMagnitude: 4.50,
    bvColour: 1.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.94232258),
        dec: Angle.Degrees(+27.81422850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142355"},
        {"Hipparcos Number", "HIP 77796"},
        {"Smithsonian Astrophysical Observation", "SAO 84057"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.28526893),
        dec: Angle.Degrees(+27.81447055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48782"},
        {"Hipparcos Number", "HIP 32448"},
        {"Smithsonian Astrophysical Observation", "SAO 78719"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.58554941),
        dec: Angle.Degrees(+27.81618752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188995"},
        {"Hipparcos Number", "HIP 98168"},
        {"Smithsonian Astrophysical Observation", "SAO 87968"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.24866146),
        dec: Angle.Degrees(+27.81630851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191293"},
        {"Hipparcos Number", "HIP 99186"},
        {"Smithsonian Astrophysical Observation", "SAO 88227"},
    },
    visualMagnitude: 8.56,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.03876045),
        dec: Angle.Degrees(+27.81635237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19600"},
        {"Hipparcos Number", "HIP 14719"},
        {"Celescope Catalog", "CEL 303"},
        {"Geneva Identification System", "GEN# +1.00019600"},
        {"Smithsonian Astrophysical Observation", "SAO 75762"},
        {"Wilson Evans Batten Catalogue", "WEB 2852"},
    },
    visualMagnitude: 6.42,
    bvColour: 0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.53678290),
        dec: Angle.Degrees(+27.81988947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283636"},
        {"Hipparcos Number", "HIP 20528"},
        {"Geneva Identification System", "GEN# +1.00283636"},
    },
    visualMagnitude: 10.97,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.97977290),
        dec: Angle.Degrees(+27.82264621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 335489"},
        {"Hipparcos Number", "HIP 88244"},
        {"Smithsonian Astrophysical Observation", "SAO 85645"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.29279572),
        dec: Angle.Degrees(+27.82487853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90878"},
        {"Hipparcos Number", "HIP 51406"},
        {"Geneva Identification System", "GEN# +1.00090878"},
        {"Smithsonian Astrophysical Observation", "SAO 81383"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.49413879),
        dec: Angle.Degrees(+27.82568730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105197",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105197"},
    },
    visualMagnitude: 9.97,
    bvColour: 1.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.64035880),
        dec: Angle.Degrees(+27.82907771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38341",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38341"},
        {"Smithsonian Astrophysical Observation", "SAO 79745"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.80539148),
        dec: Angle.Degrees(+27.83142600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195432"},
        {"Hipparcos Number", "HIP 101172"},
        {"Geneva Identification System", "GEN# +1.00195432"},
        {"Smithsonian Astrophysical Observation", "SAO 88774"},
        {"Wilson Evans Batten Catalogue", "WEB 18275"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.60520296),
        dec: Angle.Degrees(+27.83277581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79772",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79772"},
        {"Smithsonian Astrophysical Observation", "SAO 84283"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.21373150),
        dec: Angle.Degrees(+27.83384147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12861"},
        {"Hipparcos Number", "HIP 9840"},
        {"Smithsonian Astrophysical Observation", "SAO 75145"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.64981129),
        dec: Angle.Degrees(+27.83397498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31328"},
        {"Hipparcos Number", "HIP 22920"},
        {"Smithsonian Astrophysical Observation", "SAO 76843"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.98272481),
        dec: Angle.Degrees(+27.83559452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128579"},
        {"Hipparcos Number", "HIP 71468"},
        {"Geneva Identification System", "GEN# +1.00128579"},
        {"Smithsonian Astrophysical Observation", "SAO 83438"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.23794262),
        dec: Angle.Degrees(+27.83625920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40075",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40075"},
    },
    visualMagnitude: 11.41,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.79363657),
        dec: Angle.Degrees(+27.83737112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 336301"},
        {"Hipparcos Number", "HIP 90786"},
        {"Smithsonian Astrophysical Observation", "SAO 86154"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.82702840),
        dec: Angle.Degrees(+27.83945314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11650"},
        {"Hipparcos Number", "HIP 8926"},
        {"Geneva Identification System", "GEN# +1.00011650"},
        {"Smithsonian Astrophysical Observation", "SAO 75017"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.73229655),
        dec: Angle.Degrees(+27.84182981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 248356"},
        {"Hipparcos Number", "HIP 27686"},
        {"Smithsonian Astrophysical Observation", "SAO 77639"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.91745190),
        dec: Angle.Degrees(+27.84185512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8043",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8043"},
        {"Geneva Identification System", "GEN# +0.02700273"},
    },
    visualMagnitude: 10.40,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.81504023),
        dec: Angle.Degrees(+27.84218426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 550.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88313"},
        {"Hipparcos Number", "HIP 49924"},
        {"Smithsonian Astrophysical Observation", "SAO 81222"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.89675108),
        dec: Angle.Degrees(+27.84275936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64549",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64549"},
        {"Geneva Identification System", "GEN# +0.02802199"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.46258752),
        dec: Angle.Degrees(+27.84308217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 79.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107288",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15267 AB"},
        {"Henry Draper", "HD 206792"},
        {"Hipparcos Number", "HIP 107288"},
        {"Geneva Identification System", "GEN# +1.00206792J"},
        {"Smithsonian Astrophysical Observation", "SAO 89934"},
        {"Wilson Evans Batten Catalogue", "WEB 19375"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.97605233),
        dec: Angle.Degrees(+27.84688199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87286"},
        {"Hipparcos Number", "HIP 49356"},
        {"Geneva Identification System", "GEN# +1.00087286"},
        {"Smithsonian Astrophysical Observation", "SAO 81165"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.13946261),
        dec: Angle.Degrees(+27.84722617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34147"},
        {"Hipparcos Number", "HIP 24579"},
        {"Smithsonian Astrophysical Observation", "SAO 77069"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.10138976),
        dec: Angle.Degrees(+27.85237302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78670",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78670"},
    },
    visualMagnitude: 10.48,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.90809932),
        dec: Angle.Degrees(+27.85355254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109812",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109812"},
        {"Geneva Identification System", "GEN# +6.20030206"},
    },
    visualMagnitude: 10.33,
    bvColour: 1.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.63147589),
        dec: Angle.Degrees(+27.85389824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -216.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 533.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172382"},
        {"Hipparcos Number", "HIP 91435"},
        {"Geneva Identification System", "GEN# +1.00172382"},
        {"Smithsonian Astrophysical Observation", "SAO 86281"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.70819855),
        dec: Angle.Degrees(+27.85798796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157565"},
        {"Hipparcos Number", "HIP 85039"},
        {"Geneva Identification System", "GEN# +1.00157565"},
        {"Smithsonian Astrophysical Observation", "SAO 85050"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.70014247),
        dec: Angle.Degrees(+27.85927448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41639"},
        {"Hipparcos Number", "HIP 29044"},
        {"Smithsonian Astrophysical Observation", "SAO 77987"},
    },
    visualMagnitude: 8.48,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.91622650),
        dec: Angle.Degrees(+27.85987985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43148"},
        {"Hipparcos Number", "HIP 29749"},
        {"Smithsonian Astrophysical Observation", "SAO 78149"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.97824103),
        dec: Angle.Degrees(+27.86182861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221904"},
        {"Hipparcos Number", "HIP 116464"},
        {"Smithsonian Astrophysical Observation", "SAO 91368"},
    },
    visualMagnitude: 7.37,
    bvColour: -0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.98140885),
        dec: Angle.Degrees(+27.86493460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94218"},
        {"Hipparcos Number", "HIP 53195"},
        {"Geneva Identification System", "GEN# +1.00094218"},
        {"Smithsonian Astrophysical Observation", "SAO 81561"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.20360772),
        dec: Angle.Degrees(+27.86514335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117872",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117872"},
        {"Smithsonian Astrophysical Observation", "SAO 91569"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.64014242),
        dec: Angle.Degrees(+27.86569456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195408"},
        {"Hipparcos Number", "HIP 101152"},
        {"Smithsonian Astrophysical Observation", "SAO 88771"},
    },
    visualMagnitude: 7.82,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.55695673),
        dec: Angle.Degrees(+27.86610238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6988"},
        {"Hipparcos Number", "HIP 5526"},
        {"Geneva Identification System", "GEN# +1.00006988"},
        {"Smithsonian Astrophysical Observation", "SAO 74535"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.68046110),
        dec: Angle.Degrees(+27.86794763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187237"},
        {"Hipparcos Number", "HIP 97420"},
        {"Geneva Identification System", "GEN# +1.00187237"},
        {"Smithsonian Astrophysical Observation", "SAO 87733"},
        {"Wilson Evans Batten Catalogue", "WEB 17120"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.00369884),
        dec: Angle.Degrees(+27.86898992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 222.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19145"},
        {"Hipparcos Number", "HIP 14386"},
        {"Smithsonian Astrophysical Observation", "SAO 75726"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.39675479),
        dec: Angle.Degrees(+27.86964854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196022"},
        {"Hipparcos Number", "HIP 101460"},
        {"Geneva Identification System", "GEN# +2.69400038"},
        {"Renson", "Renson 54650"},
        {"Smithsonian Astrophysical Observation", "SAO 88842"},
        {"New General Catalogue", "NGC 6940 38"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.43872513),
        dec: Angle.Degrees(+27.87242967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154257"},
        {"Hipparcos Number", "HIP 83449"},
        {"Smithsonian Astrophysical Observation", "SAO 84796"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.82726687),
        dec: Angle.Degrees(+27.87248057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95576"},
        {"Hipparcos Number", "HIP 53932"},
        {"Smithsonian Astrophysical Observation", "SAO 81635"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.53552536),
        dec: Angle.Degrees(+27.87316791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149753"},
        {"Hipparcos Number", "HIP 81253"},
        {"Smithsonian Astrophysical Observation", "SAO 84473"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.93667027),
        dec: Angle.Degrees(+27.87317392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50824",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50824"},
        {"Smithsonian Astrophysical Observation", "SAO 81320"},
    },
    visualMagnitude: 9.71,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.66976953),
        dec: Angle.Degrees(+27.87373883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204388"},
        {"Hipparcos Number", "HIP 105956"},
        {"Smithsonian Astrophysical Observation", "SAO 89719"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.87675219),
        dec: Angle.Degrees(+27.87406826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114710"},
        {"Hipparcos Number", "HIP 64394"},
        {"Cincinnati Publication", "Ci 20 765"},
        {"Fundamental Katalog 5th Edition", "FK5 492"},
        {"Geneva Identification System", "GEN# +1.00114710"},
        {"Smithsonian Astrophysical Observation", "SAO 82706"},
        {"Wilson Evans Batten Catalogue", "WEB 11381"},
    },
    visualMagnitude: 4.23,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.97051117),
        dec: Angle.Degrees(+27.87603769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -801.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 882.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120421"},
        {"Hipparcos Number", "HIP 67397"},
        {"Geneva Identification System", "GEN# +1.00120421"},
        {"Smithsonian Astrophysical Observation", "SAO 83007"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.18819540),
        dec: Angle.Degrees(+27.88129817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151733"},
        {"Hipparcos Number", "HIP 82240"},
        {"Geneva Identification System", "GEN# +1.00151733"},
        {"Smithsonian Astrophysical Observation", "SAO 84615"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.02820548),
        dec: Angle.Degrees(+27.88178812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158639"},
        {"Hipparcos Number", "HIP 85572"},
        {"Smithsonian Astrophysical Observation", "SAO 85137"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.30862554),
        dec: Angle.Degrees(+27.88180740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185151"},
        {"Hipparcos Number", "HIP 96467"},
        {"Geneva Identification System", "GEN# +1.00185151"},
        {"Smithsonian Astrophysical Observation", "SAO 87451"},
        {"Wilson Evans Batten Catalogue", "WEB 16925"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.17740238),
        dec: Angle.Degrees(+27.88417267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84"},
        {"Smithsonian Astrophysical Observation", "SAO 91657"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.852,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.25180722),
        dec: Angle.Degrees(+27.88634368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 225.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12211"},
        {"Hipparcos Number", "HIP 9383"},
        {"Geneva Identification System", "GEN# +1.00012211J"},
        {"Smithsonian Astrophysical Observation", "SAO 75082"},
        {"Wilson Evans Batten Catalogue", "WEB 1971"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.14050023),
        dec: Angle.Degrees(+27.88870252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 264208"},
        {"Hipparcos Number", "HIP 32694"},
        {"Smithsonian Astrophysical Observation", "SAO 78772"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.31536443),
        dec: Angle.Degrees(+27.88892810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62965",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62965"},
        {"Geneva Identification System", "GEN# +0.02802164A"},
    },
    visualMagnitude: 10.59,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.54283870),
        dec: Angle.Degrees(+27.88909466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 340531"},
        {"Hipparcos Number", "HIP 101497"},
        {"Geneva Identification System", "GEN# +2.69400070"},
        {"New General Catalogue", "NGC 6940 70"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.52673729),
        dec: Angle.Degrees(+27.89100444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 260262"},
        {"Hipparcos Number", "HIP 31578"},
        {"Smithsonian Astrophysical Observation", "SAO 78541"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.13558451),
        dec: Angle.Degrees(+27.89123911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 253774"},
        {"Hipparcos Number", "HIP 29668"},
        {"Geneva Identification System", "GEN# +1.00253774"},
        {"Smithsonian Astrophysical Observation", "SAO 78134"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.75017818),
        dec: Angle.Degrees(+27.89172711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71093"},
        {"Hipparcos Number", "HIP 41377"},
        {"Fundamental Katalog 5th Edition", "FK5 2656"},
        {"Geneva Identification System", "GEN# +1.00071093"},
        {"Smithsonian Astrophysical Observation", "SAO 80181"},
        {"Wilson Evans Batten Catalogue", "WEB 8002"},
    },
    visualMagnitude: 5.58,
    bvColour: 1.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.61553314),
        dec: Angle.Degrees(+27.89386239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -114.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86221",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86221"},
        {"Cincinnati Publication", "Ci 18 2346"},
        {"Smithsonian Astrophysical Observation", "SAO 85257"},
        {"Wilson Evans Batten Catalogue", "WEB 14542"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.29511155),
        dec: Angle.Degrees(+27.89585313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 249.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142572"},
        {"Hipparcos Number", "HIP 77880"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.56337517),
        dec: Angle.Degrees(+27.89646815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73218",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73218"},
    },
    visualMagnitude: 10.77,
    bvColour: 1.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.45899995),
        dec: Angle.Degrees(+27.89685365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55870"},
        {"Hipparcos Number", "HIP 35152"},
        {"Geneva Identification System", "GEN# +1.00055870"},
        {"Smithsonian Astrophysical Observation", "SAO 79221"},
        {"Wilson Evans Batten Catalogue", "WEB 7025"},
    },
    visualMagnitude: 5.75,
    bvColour: 1.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.98823076),
        dec: Angle.Degrees(+27.89742666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30912"},
        {"Hipparcos Number", "HIP 22697"},
        {"Fundamental Katalog 5th Edition", "FK5 2365"},
        {"Geneva Identification System", "GEN# +1.00030912"},
        {"Smithsonian Astrophysical Observation", "SAO 76802"},
        {"Wilson Evans Batten Catalogue", "WEB 4387"},
    },
    visualMagnitude: 5.97,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.19619789),
        dec: Angle.Degrees(+27.89757233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17470",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2735 A"},
        {"Henry Draper", "HD 23245"},
        {"Hipparcos Number", "HIP 17470"},
        {"Geneva Identification System", "GEN# +1.00023245"},
        {"Smithsonian Astrophysical Observation", "SAO 76122"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.15505930),
        dec: Angle.Degrees(+27.89763436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77557"},
        {"Hipparcos Number", "HIP 44512"},
        {"Geneva Identification System", "GEN# +1.00077557"},
        {"Smithsonian Astrophysical Observation", "SAO 80609"},
        {"Wilson Evans Batten Catalogue", "WEB 8526"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.04111617),
        dec: Angle.Degrees(+27.89830962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46088",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7344 AB"},
        {"Henry Draper", "HD 81027"},
        {"Hipparcos Number", "HIP 46088"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.97728623),
        dec: Angle.Degrees(+27.89857892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130268"},
        {"Hipparcos Number", "HIP 72236"},
        {"Geneva Identification System", "GEN# +1.00130268"},
        {"Smithsonian Astrophysical Observation", "SAO 83512"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.59400492),
        dec: Angle.Degrees(+27.90037544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -156.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30190"},
        {"Hipparcos Number", "HIP 22207"},
        {"Fundamental Katalog 5th Edition", "FK5 4433"},
        {"Smithsonian Astrophysical Observation", "SAO 76743"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.63755622),
        dec: Angle.Degrees(+27.90072462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65273",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65273"},
        {"Geneva Identification System", "GEN# +0.02802221"},
        {"Smithsonian Astrophysical Observation", "SAO 82811"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.66532076),
        dec: Angle.Degrees(+27.90228619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100775"},
        {"Hipparcos Number", "HIP 56584"},
        {"Geneva Identification System", "GEN# +1.00100775"},
        {"Smithsonian Astrophysical Observation", "SAO 81892"},
        {"Wilson Evans Batten Catalogue", "WEB 10172"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.01369442),
        dec: Angle.Degrees(+27.90257809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77190"},
        {"Hipparcos Number", "HIP 44342"},
        {"Geneva Identification System", "GEN# +1.00077190"},
        {"Smithsonian Astrophysical Observation", "SAO 80585"},
        {"Wilson Evans Batten Catalogue", "WEB 8502"},
    },
    visualMagnitude: 6.07,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.45367284),
        dec: Angle.Degrees(+27.90278284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59331"},
        {"Hipparcos Number", "HIP 36509"},
        {"Geneva Identification System", "GEN# +1.00059331"},
        {"Smithsonian Astrophysical Observation", "SAO 79447"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.66502841),
        dec: Angle.Degrees(+27.90883826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175443"},
        {"Hipparcos Number", "HIP 92768"},
        {"Geneva Identification System", "GEN# +1.00175443"},
        {"Smithsonian Astrophysical Observation", "SAO 86558"},
        {"Wilson Evans Batten Catalogue", "WEB 16052"},
    },
    visualMagnitude: 5.64,
    bvColour: 1.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.55521736),
        dec: Angle.Degrees(+27.90970126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110183"},
        {"Hipparcos Number", "HIP 61817"},
        {"Geneva Identification System", "GEN# +1.00110183"},
        {"Smithsonian Astrophysical Observation", "SAO 82430"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.02885221),
        dec: Angle.Degrees(+27.90997391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5140"},
        {"Hipparcos Number", "HIP 4199"},
        {"Smithsonian Astrophysical Observation", "SAO 74343"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.40433541),
        dec: Angle.Degrees(+27.91002530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181631"},
        {"Hipparcos Number", "HIP 95033"},
        {"Smithsonian Astrophysical Observation", "SAO 87087"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.03746516),
        dec: Angle.Degrees(+27.91007396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36993"},
        {"Hipparcos Number", "HIP 26351"},
        {"Celescope Catalog", "CEL 849"},
        {"Geneva Identification System", "GEN# +1.00036993"},
        {"Smithsonian Astrophysical Observation", "SAO 77314"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.16583383),
        dec: Angle.Degrees(+27.91176325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45569",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45569"},
        {"Smithsonian Astrophysical Observation", "SAO 80737"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.31668928),
        dec: Angle.Degrees(+27.91184412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60448",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60448"},
    },
    visualMagnitude: 11.33,
    bvColour: 1.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.89501684),
        dec: Angle.Degrees(+27.91294709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -137.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 120.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79552"},
        {"Hipparcos Number", "HIP 45430"},
        {"Smithsonian Astrophysical Observation", "SAO 80723"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.88611194),
        dec: Angle.Degrees(+27.91484701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36429",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6119 A"},
        {"Henry Draper", "HD 59148"},
        {"Hipparcos Number", "HIP 36429"},
        {"Geneva Identification System", "GEN# +1.00059148"},
        {"Smithsonian Astrophysical Observation", "SAO 79434"},
        {"Wilson Evans Batten Catalogue", "WEB 7249"},
    },
    visualMagnitude: 5.01,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.45325480),
        dec: Angle.Degrees(+27.91619925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74439",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74439"},
        {"Geneva Identification System", "GEN# +0.02802411"},
        {"Smithsonian Astrophysical Observation", "SAO 83716"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.19132197),
        dec: Angle.Degrees(+27.92089225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -131.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17482",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2735 B"},
        {"Henry Draper", "HD 23257"},
        {"Hipparcos Number", "HIP 17482"},
        {"Geneva Identification System", "GEN# +1.00023257"},
        {"Smithsonian Astrophysical Observation", "SAO 76124"},
        {"Wilson Evans Batten Catalogue", "WEB 3313"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.18708122),
        dec: Angle.Degrees(+27.92146034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 157.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -160.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183384"},
        {"Hipparcos Number", "HIP 95729"},
        {"Smithsonian Astrophysical Observation", "SAO 87250"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.06010900),
        dec: Angle.Degrees(+27.92147631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45433",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7260 CD"},
        {"Hipparcos Number", "HIP 45433"},
    },
    visualMagnitude: 10.21,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.88876862),
        dec: Angle.Degrees(+27.92217924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172866"},
        {"Hipparcos Number", "HIP 91642"},
        {"Smithsonian Astrophysical Observation", "SAO 86323"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.33021643),
        dec: Angle.Degrees(+27.92509615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29224"},
        {"Hipparcos Number", "HIP 21510"},
        {"Smithsonian Astrophysical Observation", "SAO 76675"},
        {"Wilson Evans Batten Catalogue", "WEB 4128"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.28781289),
        dec: Angle.Degrees(+27.92576108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180583"},
        {"Hipparcos Number", "HIP 94685"},
        {"Geneva Identification System", "GEN# +1.00180583"},
        {"Renson", "Renson 50100"},
        {"Smithsonian Astrophysical Observation", "SAO 87008"},
        {"Wilson Evans Batten Catalogue", "WEB 16511"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.99786092),
        dec: Angle.Degrees(+27.92630021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79368",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79368"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.98054496),
        dec: Angle.Degrees(+27.92657002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135145"},
        {"Hipparcos Number", "HIP 74442"},
        {"Geneva Identification System", "GEN# +1.00135145A"},
        {"Smithsonian Astrophysical Observation", "SAO 83717"},
        {"Wilson Evans Batten Catalogue", "WEB 12704"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.19889053),
        dec: Angle.Degrees(+27.92686749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -131.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76219"},
        {"Hipparcos Number", "HIP 43834"},
        {"Fundamental Katalog 5th Edition", "FK5 2705"},
        {"Geneva Identification System", "GEN# +1.00076219"},
        {"Smithsonian Astrophysical Observation", "SAO 80511"},
        {"Wilson Evans Batten Catalogue", "WEB 8432"},
    },
    visualMagnitude: 5.23,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.91537004),
        dec: Angle.Degrees(+27.92756265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183560"},
        {"Hipparcos Number", "HIP 95796"},
        {"Geneva Identification System", "GEN# +1.00183560"},
        {"Smithsonian Astrophysical Observation", "SAO 87268"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.27635223),
        dec: Angle.Degrees(+27.92959725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66139"},
        {"Hipparcos Number", "HIP 39393"},
        {"Geneva Identification System", "GEN# +1.00066139"},
        {"Smithsonian Astrophysical Observation", "SAO 79891"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.79944650),
        dec: Angle.Degrees(+27.93184157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155878"},
        {"Hipparcos Number", "HIP 84239"},
        {"Geneva Identification System", "GEN# +1.00155878"},
        {"Smithsonian Astrophysical Observation", "SAO 84928"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.28948832),
        dec: Angle.Degrees(+27.93222096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42710",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42710"},
    },
    visualMagnitude: 11.46,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.56435742),
        dec: Angle.Degrees(+27.93348322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76157",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76157"},
    },
    visualMagnitude: 10.95,
    bvColour: 1.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.32087355),
        dec: Angle.Degrees(+27.93407097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 260222"},
        {"Hipparcos Number", "HIP 31561"},
    },
    visualMagnitude: 12.56,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.09214085),
        dec: Angle.Degrees(+27.93433291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41418"},
        {"Hipparcos Number", "HIP 28920"},
        {"Renson", "Renson 11087"},
        {"Smithsonian Astrophysical Observation", "SAO 77957"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.56512408),
        dec: Angle.Degrees(+27.93471409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8571",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8571"},
        {"Smithsonian Astrophysical Observation", "SAO 74970"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.63391820),
        dec: Angle.Degrees(+27.93496514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9429"},
        {"Hipparcos Number", "HIP 7226"},
        {"Smithsonian Astrophysical Observation", "SAO 74782"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.28322254),
        dec: Angle.Degrees(+27.94114490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15885",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15885"},
        {"Smithsonian Astrophysical Observation", "SAO 75916"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.15120452),
        dec: Angle.Degrees(+27.94183490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120049"},
        {"Hipparcos Number", "HIP 67229"},
        {"Geneva Identification System", "GEN# +1.00120049"},
        {"Renson", "Renson 34610"},
        {"Smithsonian Astrophysical Observation", "SAO 82992"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.64486872),
        dec: Angle.Degrees(+27.94263756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 332612"},
        {"Hipparcos Number", "HIP 97012"},
        {"Geneva Identification System", "GEN# +1.00332612"},
        {"Smithsonian Astrophysical Observation", "SAO 87620"},
        {"Wilson Evans Batten Catalogue", "WEB 17022"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.76024706),
        dec: Angle.Degrees(+27.94333911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61523"},
        {"Hipparcos Number", "HIP 37407"},
        {"Smithsonian Astrophysical Observation", "SAO 79602"},
    },
    visualMagnitude: 9.14,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.20739023),
        dec: Angle.Degrees(+27.94538232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4652",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4652"},
    },
    visualMagnitude: 11.94,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.94358554),
        dec: Angle.Degrees(+27.94570035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 337653"},
        {"Hipparcos Number", "HIP 93933"},
        {"Smithsonian Astrophysical Observation", "SAO 86839"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.90424891),
        dec: Angle.Degrees(+27.94642780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6071",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6071"},
        {"Smithsonian Astrophysical Observation", "SAO 74615"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.48578017),
        dec: Angle.Degrees(+27.94788957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16718",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16718"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.77527819),
        dec: Angle.Degrees(+27.94807412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55206",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55206"},
    },
    visualMagnitude: 10.64,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.56770003),
        dec: Angle.Degrees(+27.95548632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83807"},
        {"Hipparcos Number", "HIP 47548"},
        {"Geneva Identification System", "GEN# +1.00083807"},
        {"Smithsonian Astrophysical Observation", "SAO 80969"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.40140802),
        dec: Angle.Degrees(+27.95590845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17039",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2659 A"},
        {"Henry Draper", "HD 22604"},
        {"Hipparcos Number", "HIP 17039"},
        {"Smithsonian Astrophysical Observation", "SAO 76048"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.79512047),
        dec: Angle.Degrees(+27.95651577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34762"},
        {"Hipparcos Number", "HIP 24984"},
        {"Geneva Identification System", "GEN# +1.00034762"},
        {"Smithsonian Astrophysical Observation", "SAO 77121"},
        {"Wilson Evans Batten Catalogue", "WEB 4840"},
    },
    visualMagnitude: 6.35,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.24726681),
        dec: Angle.Degrees(+27.95729708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66073",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66073"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.17447594),
        dec: Angle.Degrees(+27.95829982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 340434"},
        {"Hipparcos Number", "HIP 101198"},
        {"Smithsonian Astrophysical Observation", "SAO 88781"},
        {"Wilson Evans Batten Catalogue", "WEB 18280"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.68998865),
        dec: Angle.Degrees(+27.95857899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114524",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114524"},
        {"Smithsonian Astrophysical Observation", "SAO 91078"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.94601034),
        dec: Angle.Degrees(+27.95904416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95947",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Albereo"},
        {"Common Name 2", "Albireo"},
        {"Aitken", "ADS 12540 A"},
        {"Hipparcos Number", "HIP 95947"},
        {"Fundamental Katalog 5th Edition", "FK5 732"},
        {"Geneva Identification System", "GEN# +1.00183912"},
        {"Smithsonian Astrophysical Observation", "SAO 87301"},
        {"Wilson Evans Batten Catalogue", "WEB 16802"},
    },
    visualMagnitude: 3.05,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.68035529),
        dec: Angle.Degrees(+27.95969480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26709"},
        {"Hipparcos Number", "HIP 19792"},
        {"Fundamental Katalog 5th Edition", "FK5 4387"},
        {"Geneva Identification System", "GEN# +1.00026709"},
        {"Smithsonian Astrophysical Observation", "SAO 76511"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.63181573),
        dec: Angle.Degrees(+27.95980162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180316"},
        {"Hipparcos Number", "HIP 94592"},
        {"Geneva Identification System", "GEN# +1.00180316"},
        {"Smithsonian Astrophysical Observation", "SAO 86982"},
        {"Wilson Evans Batten Catalogue", "WEB 16485"},
    },
    visualMagnitude: 6.91,
    bvColour: -0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.74518596),
        dec: Angle.Degrees(+27.96108433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91545"},
        {"Hipparcos Number", "HIP 51781"},
        {"Geneva Identification System", "GEN# +1.00091545"},
        {"Smithsonian Astrophysical Observation", "SAO 81423"},
        {"Wilson Evans Batten Catalogue", "WEB 9430"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.70801034),
        dec: Angle.Degrees(+27.96178403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 152.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104349"},
        {"Hipparcos Number", "HIP 58606"},
        {"Geneva Identification System", "GEN# +1.00104349"},
        {"Smithsonian Astrophysical Observation", "SAO 82100"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.27154431),
        dec: Angle.Degrees(+27.96216074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67414",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67414"},
        {"Smithsonian Astrophysical Observation", "SAO 83009"},
    },
    visualMagnitude: 10.65,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.24878261),
        dec: Angle.Degrees(+27.96283282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192384"},
        {"Hipparcos Number", "HIP 99673"},
        {"Smithsonian Astrophysical Observation", "SAO 88378"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.40154117),
        dec: Angle.Degrees(+27.96312157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4268"},
        {"Hipparcos Number", "HIP 3546"},
        {"Geneva Identification System", "GEN# +1.00004268"},
        {"Smithsonian Astrophysical Observation", "SAO 74243"},
        {"Wilson Evans Batten Catalogue", "WEB 627"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.32736600),
        dec: Angle.Degrees(+27.96355368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93137"},
        {"Hipparcos Number", "HIP 52623"},
        {"Renson", "Renson 26880"},
        {"Smithsonian Astrophysical Observation", "SAO 81503"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.42579414),
        dec: Angle.Degrees(+27.96505856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95951",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12540 B"},
        {"Henry Draper", "HD 183914"},
        {"Hipparcos Number", "HIP 95951"},
        {"Geneva Identification System", "GEN# +1.00183914"},
        {"Smithsonian Astrophysical Observation", "SAO 87302"},
        {"Wilson Evans Batten Catalogue", "WEB 16806"},
    },
    visualMagnitude: 5.12,
    bvColour: -0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.68915293),
        dec: Angle.Degrees(+27.96527890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118507"},
        {"Hipparcos Number", "HIP 66409"},
        {"Geneva Identification System", "GEN# +1.00118507"},
        {"Smithsonian Astrophysical Observation", "SAO 82904"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.22615924),
        dec: Angle.Degrees(+27.96558479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 65.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209858"},
        {"Hipparcos Number", "HIP 109090"},
        {"Geneva Identification System", "GEN# +1.00209858"},
        {"Smithsonian Astrophysical Observation", "SAO 90220"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.47510953),
        dec: Angle.Degrees(+27.96750629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -193.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27629",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4474 A"},
        {"Henry Draper", "HD 39004"},
        {"Hipparcos Number", "HIP 27629"},
        {"Geneva Identification System", "GEN# +1.00039004"},
        {"Smithsonian Astrophysical Observation", "SAO 77625"},
        {"Wilson Evans Batten Catalogue", "WEB 5426"},
    },
    visualMagnitude: 5.60,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.74213255),
        dec: Angle.Degrees(+27.96783335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35486",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35486"},
        {"Smithsonian Astrophysical Observation", "SAO 79283"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.86571944),
        dec: Angle.Degrees(+27.96837129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221713"},
        {"Hipparcos Number", "HIP 116343"},
        {"Smithsonian Astrophysical Observation", "SAO 91353"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.61623972),
        dec: Angle.Degrees(+27.96862849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47176",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47176"},
        {"Smithsonian Astrophysical Observation", "SAO 80926"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.816,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.20881942),
        dec: Angle.Degrees(+27.97312355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -172.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93765"},
        {"Hipparcos Number", "HIP 52959"},
        {"Fundamental Katalog 5th Edition", "FK5 2863"},
        {"Geneva Identification System", "GEN# +1.00093765"},
        {"Smithsonian Astrophysical Observation", "SAO 81542"},
        {"Wilson Evans Batten Catalogue", "WEB 9635"},
    },
    visualMagnitude: 6.05,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.47388998),
        dec: Angle.Degrees(+27.97387214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116724"},
        {"Hipparcos Number", "HIP 65467"},
        {"Geneva Identification System", "GEN# +1.00116724"},
        {"Smithsonian Astrophysical Observation", "SAO 82826"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.27887327),
        dec: Angle.Degrees(+27.97955162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46277"},
        {"Hipparcos Number", "HIP 31287"},
        {"Geneva Identification System", "GEN# +1.00046277"},
        {"Smithsonian Astrophysical Observation", "SAO 78496"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.42267035),
        dec: Angle.Degrees(+27.98018254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110788"},
        {"Hipparcos Number", "HIP 62158"},
        {"Geneva Identification System", "GEN# +1.00110788"},
        {"Smithsonian Astrophysical Observation", "SAO 82465"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.08557283),
        dec: Angle.Degrees(+27.98197485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49759",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49759"},
        {"Smithsonian Astrophysical Observation", "SAO 81209"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.35801001),
        dec: Angle.Degrees(+27.98271888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87006",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10792 A"},
        {"Hipparcos Number", "HIP 87006"},
        {"Renson", "Renson 45690"},
        {"Smithsonian Astrophysical Observation", "SAO 85405"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.67624809),
        dec: Angle.Degrees(+27.98308614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7685"},
        {"Hipparcos Number", "HIP 5991"},
        {"Smithsonian Astrophysical Observation", "SAO 74603"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.26470760),
        dec: Angle.Degrees(+27.98462397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182443"},
        {"Hipparcos Number", "HIP 95330"},
        {"Smithsonian Astrophysical Observation", "SAO 87149"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.91566922),
        dec: Angle.Degrees(+27.98525307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44391"},
        {"Hipparcos Number", "HIP 30331"},
        {"Geneva Identification System", "GEN# +1.00044391"},
        {"Smithsonian Astrophysical Observation", "SAO 78291"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.69949016),
        dec: Angle.Degrees(+27.98668599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96737"},
        {"Hipparcos Number", "HIP 54492"},
        {"Smithsonian Astrophysical Observation", "SAO 81695"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.23481430),
        dec: Angle.Degrees(+27.98750504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215163"},
        {"Hipparcos Number", "HIP 112152"},
        {"Smithsonian Astrophysical Observation", "SAO 90731"},
    },
    visualMagnitude: 7.33,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.74149442),
        dec: Angle.Degrees(+27.98865196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164079"},
        {"Hipparcos Number", "HIP 87982"},
        {"Geneva Identification System", "GEN# +1.00164079"},
        {"Smithsonian Astrophysical Observation", "SAO 85598"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.58321350),
        dec: Angle.Degrees(+27.98909726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86000",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86000"},
        {"Smithsonian Astrophysical Observation", "SAO 85220"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.65726026),
        dec: Angle.Degrees(+27.98951028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35414",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35414"},
        {"Smithsonian Astrophysical Observation", "SAO 79270"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.67736384),
        dec: Angle.Degrees(+27.99178379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163949"},
        {"Hipparcos Number", "HIP 87920"},
        {"Geneva Identification System", "GEN# +1.00163949J"},
        {"Smithsonian Astrophysical Observation", "SAO 85581"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.39487275),
        dec: Angle.Degrees(+27.99221606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112233"},
        {"Hipparcos Number", "HIP 63025"},
        {"Geneva Identification System", "GEN# +1.00112233"},
        {"Smithsonian Astrophysical Observation", "SAO 82561"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.73688889),
        dec: Angle.Degrees(+27.99287209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208641"},
        {"Hipparcos Number", "HIP 108357"},
        {"Geneva Identification System", "GEN# +1.00208641"},
        {"Smithsonian Astrophysical Observation", "SAO 90123"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.27800353),
        dec: Angle.Degrees(+27.99371557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140253"},
        {"Hipparcos Number", "HIP 76855"},
        {"Smithsonian Astrophysical Observation", "SAO 83949"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.40106053),
        dec: Angle.Degrees(+27.99531492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213507"},
        {"Hipparcos Number", "HIP 111185"},
        {"Smithsonian Astrophysical Observation", "SAO 90566"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.86205372),
        dec: Angle.Degrees(+27.99582004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 256902"},
        {"Hipparcos Number", "HIP 30618"},
        {"Geneva Identification System", "GEN# +1.00256902"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.52051179),
        dec: Angle.Degrees(+27.99903134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128591"},
        {"Hipparcos Number", "HIP 71472"},
        {"Smithsonian Astrophysical Observation", "SAO 83439"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.25899970),
        dec: Angle.Degrees(+27.99943605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113333",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113333"},
        {"Geneva Identification System", "GEN# +0.02704445A"},
    },
    visualMagnitude: 9.93,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.27969222),
        dec: Angle.Degrees(+28.00209701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 351.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78194"},
        {"Hipparcos Number", "HIP 44784"},
        {"Smithsonian Astrophysical Observation", "SAO 80646"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.91429539),
        dec: Angle.Degrees(+28.00587823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83340"},
        {"Hipparcos Number", "HIP 47311"},
        {"Geneva Identification System", "GEN# +1.00083340"},
        {"Smithsonian Astrophysical Observation", "SAO 80941"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.61509629),
        dec: Angle.Degrees(+28.00600923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43537"},
        {"Hipparcos Number", "HIP 29927"},
        {"Geneva Identification System", "GEN# +1.00043537"},
        {"Smithsonian Astrophysical Observation", "SAO 78191"},
        {"Wilson Evans Batten Catalogue", "WEB 5930"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.49949967),
        dec: Angle.Degrees(+28.00681543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202521"},
        {"Hipparcos Number", "HIP 104960"},
        {"Smithsonian Astrophysical Observation", "SAO 89569"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.90254683),
        dec: Angle.Degrees(+28.00911564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70979",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70979"},
        {"Smithsonian Astrophysical Observation", "SAO 83386"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.76470182),
        dec: Angle.Degrees(+28.00985577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17008"},
        {"Hipparcos Number", "HIP 12799"},
        {"Geneva Identification System", "GEN# +1.00017008"},
        {"Renson", "Renson 4314"},
        {"Smithsonian Astrophysical Observation", "SAO 75543"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.12487354),
        dec: Angle.Degrees(+28.01506819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113092",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16352 A"},
        {"Henry Draper", "HD 216632"},
        {"Hipparcos Number", "HIP 113092"},
        {"Geneva Identification System", "GEN# +1.00216632"},
        {"Smithsonian Astrophysical Observation", "SAO 90864"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.54754055),
        dec: Angle.Degrees(+28.01660283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5535",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5535"},
        {"Smithsonian Astrophysical Observation", "SAO 74539"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.74286835),
        dec: Angle.Degrees(+28.02022698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221852"},
        {"Hipparcos Number", "HIP 116424"},
        {"Smithsonian Astrophysical Observation", "SAO 91363"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.87074004),
        dec: Angle.Degrees(+28.02081211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54217",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54217"},
        {"Smithsonian Astrophysical Observation", "SAO 81663"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.768,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.39733198),
        dec: Angle.Degrees(+28.02110667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283738"},
        {"Hipparcos Number", "HIP 21699"},
        {"Smithsonian Astrophysical Observation", "SAO 76690"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.88451178),
        dec: Angle.Degrees(+28.02167350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8806",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8806"},
        {"Smithsonian Astrophysical Observation", "SAO 74998"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.29745092),
        dec: Angle.Degrees(+28.02206812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46553"},
        {"Hipparcos Number", "HIP 31434"},
        {"Fundamental Katalog 5th Edition", "FK5 2504"},
        {"Geneva Identification System", "GEN# +1.00046553"},
        {"Smithsonian Astrophysical Observation", "SAO 78524"},
        {"Wilson Evans Batten Catalogue", "WEB 6290"},
    },
    visualMagnitude: 5.26,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.80025751),
        dec: Angle.Degrees(+28.02234399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56072",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56072"},
        {"Geneva Identification System", "GEN# +0.02802008"},
        {"Smithsonian Astrophysical Observation", "SAO 81849"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.39843527),
        dec: Angle.Degrees(+28.08991395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 340062"},
        {"Hipparcos Number", "HIP 100641"},
        {"Smithsonian Astrophysical Observation", "SAO 88634"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.10403766),
        dec: Angle.Degrees(+28.02515298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71812",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71812"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.33917471),
        dec: Angle.Degrees(+28.02555486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156987"},
        {"Hipparcos Number", "HIP 84743"},
        {"Smithsonian Astrophysical Observation", "SAO 85006"},
        {"Wilson Evans Batten Catalogue", "WEB 14308"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.84947844),
        dec: Angle.Degrees(+28.02594570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37826",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Pollux"},
        {"Aitken", "ADS 6335 A"},
        {"Henry Draper", "HD 62509"},
        {"Hipparcos Number", "HIP 37826"},
        {"Cincinnati Publication", "Ci 20 437"},
        {"Fundamental Katalog 5th Edition", "FK5 295"},
        {"Geneva Identification System", "GEN# +1.00062509"},
        {"Smithsonian Astrophysical Observation", "SAO 79666"},
        {"Wilson Evans Batten Catalogue", "WEB 7472"},
    },
    visualMagnitude: 1.16,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.33068263),
        dec: Angle.Degrees(+28.02631031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -625.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24019",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3730 A"},
        {"Henry Draper", "HD 33204"},
        {"Hipparcos Number", "HIP 24019"},
        {"Fundamental Katalog 5th Edition", "FK5 1141"},
        {"Geneva Identification System", "GEN# +5.20250131"},
        {"Renson", "Renson 8470"},
        {"Smithsonian Astrophysical Observation", "SAO 76990"},
        {"Wilson Evans Batten Catalogue", "WEB 4680"},
    },
    visualMagnitude: 5.93,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.43773063),
        dec: Angle.Degrees(+28.03060835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44796"},
        {"Hipparcos Number", "HIP 30525"},
        {"Smithsonian Astrophysical Observation", "SAO 78334"},
    },
    visualMagnitude: 8.13,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.24753340),
        dec: Angle.Degrees(+28.03208233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 249119"},
        {"Hipparcos Number", "HIP 28020"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.90031784),
        dec: Angle.Degrees(+28.03212785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24020",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3730 BC"},
        {"Hipparcos Number", "HIP 24020"},
        {"Geneva Identification System", "GEN# +5.20250132J"},
        {"Smithsonian Astrophysical Observation", "SAO 76991"},
        {"Wilson Evans Batten Catalogue", "WEB 4683"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.43932461),
        dec: Angle.Degrees(+28.03376598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69344",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9150 AB"},
        {"Henry Draper", "HD 124216"},
        {"Hipparcos Number", "HIP 69344"},
        {"Smithsonian Astrophysical Observation", "SAO 83213"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.89025541),
        dec: Angle.Degrees(+28.03672596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3858"},
        {"Hipparcos Number", "HIP 3251"},
        {"Geneva Identification System", "GEN# +1.00003858"},
        {"Smithsonian Astrophysical Observation", "SAO 74198"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.35578594),
        dec: Angle.Degrees(+28.04265423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209180"},
        {"Hipparcos Number", "HIP 108664"},
        {"Smithsonian Astrophysical Observation", "SAO 90168"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.21571577),
        dec: Angle.Degrees(+28.04745785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60061",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60061"},
        {"Geneva Identification System", "GEN# +5.21110059"},
        {"Smithsonian Astrophysical Observation", "SAO 82236"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.748,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.75401186),
        dec: Angle.Degrees(+28.04828741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -182.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106678"},
        {"Hipparcos Number", "HIP 59824"},
        {"Geneva Identification System", "GEN# +5.21110035"},
        {"Smithsonian Astrophysical Observation", "SAO 82208"},
        {"Wilson Evans Batten Catalogue", "WEB 10628"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.01048998),
        dec: Angle.Degrees(+28.04869056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36665"},
        {"Hipparcos Number", "HIP 26162"},
        {"Celescope Catalog", "CEL 791"},
        {"Geneva Identification System", "GEN# +1.00036665"},
        {"Smithsonian Astrophysical Observation", "SAO 77268"},
        {"Wilson Evans Batten Catalogue", "WEB 5097"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.66291728),
        dec: Angle.Degrees(+28.05105583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115435",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115435"},
        {"Fundamental Katalog 5th Edition", "FK5 6066"},
        {"Smithsonian Astrophysical Observation", "SAO 91224"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.73944701),
        dec: Angle.Degrees(+28.05133663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93410",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93410"},
    },
    visualMagnitude: 12.08,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.36332762),
        dec: Angle.Degrees(+29.28258689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64107"},
        {"Hipparcos Number", "HIP 38525"},
        {"Smithsonian Astrophysical Observation", "SAO 79772"},
    },
    visualMagnitude: 6.92,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.33776816),
        dec: Angle.Degrees(+28.05202293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8069",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8069"},
    },
    visualMagnitude: 11.73,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.91754583),
        dec: Angle.Degrees(+28.05270629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 275.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79141",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79141"},
        {"Smithsonian Astrophysical Observation", "SAO 84215"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.30536268),
        dec: Angle.Degrees(+28.05422846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101841"},
        {"Hipparcos Number", "HIP 57160"},
        {"Geneva Identification System", "GEN# +1.00101841"},
        {"Smithsonian Astrophysical Observation", "SAO 81955"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.84525757),
        dec: Angle.Degrees(+28.05515716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8067",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8067"},
    },
    visualMagnitude: 10.61,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.91248793),
        dec: Angle.Degrees(+28.05599931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 254.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137003"},
        {"Hipparcos Number", "HIP 75275"},
        {"Geneva Identification System", "GEN# +1.00137003"},
        {"Smithsonian Astrophysical Observation", "SAO 83797"},
        {"Wilson Evans Batten Catalogue", "WEB 12842"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.69171780),
        dec: Angle.Degrees(+28.05703832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 340293"},
        {"Hipparcos Number", "HIP 100902"},
        {"Smithsonian Astrophysical Observation", "SAO 88702"},
        {"Wilson Evans Batten Catalogue", "WEB 18232"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.88783628),
        dec: Angle.Degrees(+28.05760122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199169"},
        {"Hipparcos Number", "HIP 103200"},
        {"Fundamental Katalog 5th Edition", "FK5 786"},
        {"Geneva Identification System", "GEN# +1.00199169"},
        {"Smithsonian Astrophysical Observation", "SAO 89272"},
        {"Wilson Evans Batten Catalogue", "WEB 18747"},
    },
    visualMagnitude: 5.03,
    bvColour: 1.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.64015502),
        dec: Angle.Degrees(+28.05763154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 340294"},
        {"Hipparcos Number", "HIP 100908"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.89472527),
        dec: Angle.Degrees(+28.05989862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2435"},
        {"Hipparcos Number", "HIP 2231"},
        {"Smithsonian Astrophysical Observation", "SAO 74022"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.06945321),
        dec: Angle.Degrees(+28.06050771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104797"},
        {"Hipparcos Number", "HIP 58838"},
        {"Geneva Identification System", "GEN# +1.00104797"},
        {"Smithsonian Astrophysical Observation", "SAO 82121"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.02127965),
        dec: Angle.Degrees(+28.06061491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71132"},
        {"Hipparcos Number", "HIP 41394"},
        {"Smithsonian Astrophysical Observation", "SAO 80183"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.67055930),
        dec: Angle.Degrees(+28.06353480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283690"},
        {"Hipparcos Number", "HIP 21353"},
        {"Geneva Identification System", "GEN# +5.20250098"},
        {"Smithsonian Astrophysical Observation", "SAO 76659"},
        {"Wilson Evans Batten Catalogue", "WEB 4101"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.72477860),
        dec: Angle.Degrees(+28.06453327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119081"},
        {"Hipparcos Number", "HIP 66725"},
        {"Geneva Identification System", "GEN# +1.00119081"},
        {"Smithsonian Astrophysical Observation", "SAO 82944"},
        {"Wilson Evans Batten Catalogue", "WEB 11771"},
        {"New General Catalogue", "NGC 5272 78"},
    },
    visualMagnitude: 6.22,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.16301341),
        dec: Angle.Degrees(+28.06514059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112887"},
        {"Hipparcos Number", "HIP 63405"},
        {"Geneva Identification System", "GEN# +1.00112887"},
        {"Smithsonian Astrophysical Observation", "SAO 82595"},
        {"Wilson Evans Batten Catalogue", "WEB 11223"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.88724048),
        dec: Angle.Degrees(+28.06567696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50392",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50392"},
        {"Smithsonian Astrophysical Observation", "SAO 81272"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.34634892),
        dec: Angle.Degrees(+28.06570348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -220.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100839",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13865 AB"},
        {"Henry Draper", "HD 194805"},
        {"Hipparcos Number", "HIP 100839"},
        {"Smithsonian Astrophysical Observation", "SAO 88684"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.69298744),
        dec: Angle.Degrees(+28.06788334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219361"},
        {"Hipparcos Number", "HIP 114774"},
        {"Geneva Identification System", "GEN# +1.00219361"},
        {"Smithsonian Astrophysical Observation", "SAO 91118"},
        {"Wilson Evans Batten Catalogue", "WEB 20348"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.74120334),
        dec: Angle.Degrees(+28.07086616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91260",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91260"},
    },
    visualMagnitude: 11.40,
    bvColour: 0.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.22688999),
        dec: Angle.Degrees(+28.07264388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192204"},
        {"Hipparcos Number", "HIP 99594"},
        {"Smithsonian Astrophysical Observation", "SAO 88357"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.17962192),
        dec: Angle.Degrees(+28.07434709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17851"},
        {"Hipparcos Number", "HIP 13423"},
        {"Smithsonian Astrophysical Observation", "SAO 75617"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.21574162),
        dec: Angle.Degrees(+28.07664837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2075"},
        {"Hipparcos Number", "HIP 1990"},
        {"Smithsonian Astrophysical Observation", "SAO 73965"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.29581868),
        dec: Angle.Degrees(+28.07732429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71762"},
        {"Hipparcos Number", "HIP 41700"},
        {"Smithsonian Astrophysical Observation", "SAO 80214"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.54157733),
        dec: Angle.Degrees(+28.08135857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 339971"},
        {"Hipparcos Number", "HIP 100275"},
        {"Geneva Identification System", "GEN# +1.00339971"},
        {"Smithsonian Astrophysical Observation", "SAO 88537"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.08814925),
        dec: Angle.Degrees(+28.08139648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109306"},
        {"Hipparcos Number", "HIP 61302"},
        {"Geneva Identification System", "GEN# +5.21110184"},
        {"Renson", "Renson 31710"},
        {"Smithsonian Astrophysical Observation", "SAO 82380"},
        {"Wilson Evans Batten Catalogue", "WEB 10909"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.40402978),
        dec: Angle.Degrees(+28.08147699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113881",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Scheat"},
        {"Aitken", "ADS 16483 A"},
        {"Henry Draper", "HD 217906"},
        {"Hipparcos Number", "HIP 113881"},
        {"Fundamental Katalog 5th Edition", "FK5 870"},
        {"Geneva Identification System", "GEN# +1.00217906"},
        {"Smithsonian Astrophysical Observation", "SAO 90981"},
        {"Wilson Evans Batten Catalogue", "WEB 20229"},
    },
    visualMagnitude: 2.44,
    bvColour: 1.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.94305575),
        dec: Angle.Degrees(+28.08245462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 187.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 137.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90287",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11338 A"},
        {"Henry Draper", "HD 169818"},
        {"Hipparcos Number", "HIP 90287"},
        {"Smithsonian Astrophysical Observation", "SAO 86027"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.33489462),
        dec: Angle.Degrees(+28.08305836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109157"},
        {"Hipparcos Number", "HIP 61198"},
        {"Geneva Identification System", "GEN# +5.21110173"},
        {"Smithsonian Astrophysical Observation", "SAO 82366"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.841,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.11453716),
        dec: Angle.Degrees(+28.08491381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -120.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73746",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73746"},
    },
    visualMagnitude: 10.47,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.11202653),
        dec: Angle.Degrees(+28.08690643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182618"},
        {"Hipparcos Number", "HIP 95400"},
        {"Geneva Identification System", "GEN# +1.00182618"},
        {"Smithsonian Astrophysical Observation", "SAO 87165"},
        {"Wilson Evans Batten Catalogue", "WEB 16677"},
    },
    visualMagnitude: 6.53,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.09391490),
        dec: Angle.Degrees(+28.08758395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154616"},
        {"Hipparcos Number", "HIP 83631"},
        {"Smithsonian Astrophysical Observation", "SAO 84822"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.37640610),
        dec: Angle.Degrees(+28.08801194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196928"},
        {"Hipparcos Number", "HIP 101941"},
        {"Smithsonian Astrophysical Observation", "SAO 88970"},
        {"Wilson Evans Batten Catalogue", "WEB 18424"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.87402054),
        dec: Angle.Degrees(+28.08856792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34453"},
        {"Hipparcos Number", "HIP 24776"},
        {"Renson", "Renson 8792"},
        {"Smithsonian Astrophysical Observation", "SAO 77093"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.67643958),
        dec: Angle.Degrees(+28.09063718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103247",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14424 AB"},
        {"Henry Draper", "HD 199221"},
        {"Hipparcos Number", "HIP 103247"},
        {"Geneva Identification System", "GEN# +1.00199221"},
        {"Smithsonian Astrophysical Observation", "SAO 89278"},
        {"Wilson Evans Batten Catalogue", "WEB 18758"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.75971475),
        dec: Angle.Degrees(+28.09067592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 113.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83568",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10332 A"},
        {"Henry Draper", "HD 154510"},
        {"Hipparcos Number", "HIP 83568"},
        {"Smithsonian Astrophysical Observation", "SAO 84810"},
        {"Wilson Evans Batten Catalogue", "WEB 14129"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.19081748),
        dec: Angle.Degrees(+28.09103765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207298"},
        {"Hipparcos Number", "HIP 107579"},
        {"Smithsonian Astrophysical Observation", "SAO 89996"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.82975957),
        dec: Angle.Degrees(+28.09177301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39096"},
        {"Hipparcos Number", "HIP 27676"},
        {"Geneva Identification System", "GEN# +1.00039096"},
        {"Smithsonian Astrophysical Observation", "SAO 77638"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.88740792),
        dec: Angle.Degrees(+28.09216322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161884"},
        {"Hipparcos Number", "HIP 87025"},
        {"Renson", "Renson 45710"},
        {"Smithsonian Astrophysical Observation", "SAO 85407"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.72321667),
        dec: Angle.Degrees(+28.09472346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86090"},
        {"Hipparcos Number", "HIP 48777"},
        {"Geneva Identification System", "GEN# +1.00086090"},
        {"Smithsonian Astrophysical Observation", "SAO 81097"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.23088956),
        dec: Angle.Degrees(+28.09645039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102868"},
        {"Hipparcos Number", "HIP 57761"},
        {"Geneva Identification System", "GEN# +1.00102868"},
        {"Smithsonian Astrophysical Observation", "SAO 82012"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.68225244),
        dec: Angle.Degrees(+28.09679060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54484",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54484"},
    },
    visualMagnitude: 10.73,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.20214882),
        dec: Angle.Degrees(+28.09731253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 244957"},
        {"Hipparcos Number", "HIP 26196"},
        {"Geneva Identification System", "GEN# +9.80098013"},
    },
    visualMagnitude: 10.08,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.75294948),
        dec: Angle.Degrees(+28.09917215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 214.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -271.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188258"},
        {"Hipparcos Number", "HIP 97867"},
        {"Geneva Identification System", "GEN# +1.00188258"},
        {"Smithsonian Astrophysical Observation", "SAO 87877"},
        {"Wilson Evans Batten Catalogue", "WEB 17218"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.31643364),
        dec: Angle.Degrees(+28.09959803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188015"},
        {"Hipparcos Number", "HIP 97769"},
        {"Geneva Identification System", "GEN# +1.00188015"},
        {"Smithsonian Astrophysical Observation", "SAO 87842"},
        {"Wilson Evans Batten Catalogue", "WEB 17198"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.01878278),
        dec: Angle.Degrees(+28.10059804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173471"},
        {"Hipparcos Number", "HIP 91922"},
        {"Geneva Identification System", "GEN# +1.00173471"},
        {"Smithsonian Astrophysical Observation", "SAO 86388"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.08936272),
        dec: Angle.Degrees(+28.10141877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200270"},
        {"Hipparcos Number", "HIP 103770"},
        {"Geneva Identification System", "GEN# +1.00200270"},
        {"Smithsonian Astrophysical Observation", "SAO 89378"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.42358753),
        dec: Angle.Degrees(+28.10148031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 242954"},
        {"Hipparcos Number", "HIP 25112"},
        {"Smithsonian Astrophysical Observation", "SAO 77130"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.64497306),
        dec: Angle.Degrees(+28.10184777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27159"},
        {"Hipparcos Number", "HIP 20090"},
        {"Geneva Identification System", "GEN# +1.00027159"},
        {"Smithsonian Astrophysical Observation", "SAO 76540"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.61368537),
        dec: Angle.Degrees(+28.10321434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115929"},
        {"Hipparcos Number", "HIP 65039"},
        {"Geneva Identification System", "GEN# +1.00115929"},
        {"Smithsonian Astrophysical Observation", "SAO 82787"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.97359329),
        dec: Angle.Degrees(+28.10470228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 246162"},
        {"Hipparcos Number", "HIP 26754"},
        {"Wilson Evans Batten Catalogue", "WEB 5278"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.26027736),
        dec: Angle.Degrees(+28.10640903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30944"},
        {"Hipparcos Number", "HIP 22711"},
        {"Geneva Identification System", "GEN# +1.00030944"},
        {"Smithsonian Astrophysical Observation", "SAO 76805"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.25330205),
        dec: Angle.Degrees(+28.10695625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113562"},
        {"Hipparcos Number", "HIP 63772"},
        {"Geneva Identification System", "GEN# +1.00113562"},
        {"Smithsonian Astrophysical Observation", "SAO 82635"},
        {"Wilson Evans Batten Catalogue", "WEB 11280"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.07529989),
        dec: Angle.Degrees(+28.10707463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193795"},
        {"Hipparcos Number", "HIP 100363"},
        {"Geneva Identification System", "GEN# +1.00193795"},
        {"Smithsonian Astrophysical Observation", "SAO 88563"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.31366650),
        dec: Angle.Degrees(+28.10723499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -163.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110044",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110044"},
        {"Smithsonian Astrophysical Observation", "SAO 90394"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.33741487),
        dec: Angle.Degrees(+28.10750790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108466"},
        {"Hipparcos Number", "HIP 60789"},
        {"Geneva Identification System", "GEN# +5.21110137"},
        {"Smithsonian Astrophysical Observation", "SAO 82319"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.88706552),
        dec: Angle.Degrees(+28.10903242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10126"},
        {"Hipparcos Number", "HIP 7733"},
        {"Cincinnati Publication", "Ci 20 116"},
        {"Cincinnati Publication 2", "Ci 18 229"},
        {"Geneva Identification System", "GEN# +1.00010126"},
        {"Smithsonian Astrophysical Observation", "SAO 74857"},
        {"Wilson Evans Batten Catalogue", "WEB 1660"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.733,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.89851037),
        dec: Angle.Degrees(+28.11067481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 500.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 144.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96450",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96450"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.13640462),
        dec: Angle.Degrees(+28.11090454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173367"},
        {"Hipparcos Number", "HIP 91861"},
        {"Smithsonian Astrophysical Observation", "SAO 86376"},
        {"Wilson Evans Batten Catalogue", "WEB 15815"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.92247597),
        dec: Angle.Degrees(+28.11112266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 339850"},
        {"Hipparcos Number", "HIP 100020"},
        {"Smithsonian Astrophysical Observation", "SAO 88475"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.39597738),
        dec: Angle.Degrees(+28.11164244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110916",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110916"},
    },
    visualMagnitude: 11.00,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.06706833),
        dec: Angle.Degrees(+28.11192962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 223.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 251840"},
        {"Hipparcos Number", "HIP 29051"},
        {"Geneva Identification System", "GEN# +1.00251840"},
        {"Smithsonian Astrophysical Observation", "SAO 77988"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.93079401),
        dec: Angle.Degrees(+28.11409577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75190",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75190"},
    },
    visualMagnitude: 11.46,
    bvColour: 1.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.47944914),
        dec: Angle.Degrees(+28.11573958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -423.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93433",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93433"},
        {"Smithsonian Astrophysical Observation", "SAO 86718"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.42856166),
        dec: Angle.Degrees(+28.11642396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59037"},
        {"Hipparcos Number", "HIP 36393"},
        {"Geneva Identification System", "GEN# +1.00059037"},
        {"Smithsonian Astrophysical Observation", "SAO 79427"},
        {"Wilson Evans Batten Catalogue", "WEB 7242"},
    },
    visualMagnitude: 5.07,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.33526392),
        dec: Angle.Degrees(+28.11840380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78140"},
        {"Hipparcos Number", "HIP 44763"},
        {"Geneva Identification System", "GEN# +1.00078140"},
        {"Renson", "Renson 22130"},
        {"Smithsonian Astrophysical Observation", "SAO 80640"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.84768713),
        dec: Angle.Degrees(+28.12054138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76374",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76374"},
    },
    visualMagnitude: 11.63,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.97743224),
        dec: Angle.Degrees(+28.12077795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102646"},
        {"Hipparcos Number", "HIP 57643"},
        {"Geneva Identification System", "GEN# +1.00102646"},
        {"Smithsonian Astrophysical Observation", "SAO 82004"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.933,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.30140980),
        dec: Angle.Degrees(+28.12140496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104093",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104093"},
    },
    visualMagnitude: 12.04,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.33273587),
        dec: Angle.Degrees(+28.12141736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284065"},
        {"Hipparcos Number", "HIP 23721"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.49858107),
        dec: Angle.Degrees(+28.12143314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152306"},
        {"Hipparcos Number", "HIP 82485"},
        {"Geneva Identification System", "GEN# +1.00152306"},
        {"Smithsonian Astrophysical Observation", "SAO 84648"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.86440618),
        dec: Angle.Degrees(+28.12176622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215944"},
        {"Hipparcos Number", "HIP 112614"},
        {"Geneva Identification System", "GEN# +1.00215944"},
        {"Smithsonian Astrophysical Observation", "SAO 90799"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.12402605),
        dec: Angle.Degrees(+28.12185418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56964"},
        {"Hipparcos Number", "HIP 35565"},
        {"Geneva Identification System", "GEN# +1.00056964"},
        {"Smithsonian Astrophysical Observation", "SAO 79295"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.09520614),
        dec: Angle.Degrees(+28.12221417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57324",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57324"},
        {"Smithsonian Astrophysical Observation", "SAO 81971"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.30617629),
        dec: Angle.Degrees(+28.12335009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173088"},
        {"Hipparcos Number", "HIP 91734"},
        {"Smithsonian Astrophysical Observation", "SAO 86340"},
    },
    visualMagnitude: 7.65,
    bvColour: -0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.60074246),
        dec: Angle.Degrees(+28.12489690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40441"},
        {"Hipparcos Number", "HIP 28416"},
        {"Geneva Identification System", "GEN# +1.00040441"},
        {"Smithsonian Astrophysical Observation", "SAO 77818"},
        {"Wilson Evans Batten Catalogue", "WEB 5553"},
    },
    visualMagnitude: 6.69,
    bvColour: 1.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.02053195),
        dec: Angle.Degrees(+28.12577889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53722",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53722"},
        {"Smithsonian Astrophysical Observation", "SAO 81609"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.87264941),
        dec: Angle.Degrees(+28.12580958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190885"},
        {"Hipparcos Number", "HIP 99018"},
        {"Smithsonian Astrophysical Observation", "SAO 88197"},
        {"Wilson Evans Batten Catalogue", "WEB 17598"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.53378599),
        dec: Angle.Degrees(+28.12592115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18972",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2944 D"},
        {"Henry Draper", "HD 25487"},
        {"Hipparcos Number", "HIP 18972"},
        {"Smithsonian Astrophysical Observation", "SAO 76418"},
        {"Wilson Evans Batten Catalogue", "WEB 3648"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.97631596),
        dec: Angle.Degrees(+28.12601607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137688"},
        {"Hipparcos Number", "HIP 75583"},
        {"Geneva Identification System", "GEN# +1.00137688"},
        {"Smithsonian Astrophysical Observation", "SAO 83821"},
        {"Wilson Evans Batten Catalogue", "WEB 12880"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.62561666),
        dec: Angle.Degrees(+28.12757351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143706"},
        {"Hipparcos Number", "HIP 78468"},
    },
    visualMagnitude: 10.95,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.27566308),
        dec: Angle.Degrees(+28.12923807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111861"},
        {"Hipparcos Number", "HIP 62798"},
        {"Geneva Identification System", "GEN# +1.00111861"},
        {"Smithsonian Astrophysical Observation", "SAO 82542"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.02234039),
        dec: Angle.Degrees(+28.12933662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13644",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13644"},
    },
    visualMagnitude: 11.05,
    bvColour: 1.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.92113476),
        dec: Angle.Degrees(+28.13023272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 271.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -149.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28447"},
        {"Hipparcos Number", "HIP 21010"},
        {"Geneva Identification System", "GEN# +1.00028447"},
        {"Smithsonian Astrophysical Observation", "SAO 76634"},
        {"Wilson Evans Batten Catalogue", "WEB 4041"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.58318492),
        dec: Angle.Degrees(+28.13177220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 139.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24229"},
        {"Hipparcos Number", "HIP 18119"},
        {"Smithsonian Astrophysical Observation", "SAO 76288"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.11540832),
        dec: Angle.Degrees(+28.13387064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159027"},
        {"Hipparcos Number", "HIP 85732"},
        {"Smithsonian Astrophysical Observation", "SAO 85173"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.79796888),
        dec: Angle.Degrees(+28.13641242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152877"},
        {"Hipparcos Number", "HIP 82765"},
        {"Geneva Identification System", "GEN# +1.00152877"},
        {"Smithsonian Astrophysical Observation", "SAO 84688"},
        {"Wilson Evans Batten Catalogue", "WEB 13991"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.72993736),
        dec: Angle.Degrees(+28.13705100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64887",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64887"},
        {"Geneva Identification System", "GEN# +0.02802209"},
        {"Smithsonian Astrophysical Observation", "SAO 82764"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.51821040),
        dec: Angle.Degrees(+28.14464581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18129"},
        {"Hipparcos Number", "HIP 13615"},
        {"Smithsonian Astrophysical Observation", "SAO 75640"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.85600052),
        dec: Angle.Degrees(+28.14569226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74159",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9526 AB"},
        {"Hipparcos Number", "HIP 74159"},
        {"Smithsonian Astrophysical Observation", "SAO 83689"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.29081858),
        dec: Angle.Degrees(+28.14672961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24365"},
        {"Hipparcos Number", "HIP 18208"},
        {"Geneva Identification System", "GEN# +1.00024365"},
        {"Smithsonian Astrophysical Observation", "SAO 76304"},
        {"Wilson Evans Batten Catalogue", "WEB 3511"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.40699384),
        dec: Angle.Degrees(+28.14814044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109448",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109448"},
        {"Smithsonian Astrophysical Observation", "SAO 90286"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.59430051),
        dec: Angle.Degrees(+28.14934798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128719"},
        {"Hipparcos Number", "HIP 71522"},
        {"Smithsonian Astrophysical Observation", "SAO 83445"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.783,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.42653246),
        dec: Angle.Degrees(+28.14953720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -163.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60300",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60300"},
        {"Geneva Identification System", "GEN# +0.02802108"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.883,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.46764644),
        dec: Angle.Degrees(+28.14993629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85262",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85262"},
        {"Smithsonian Astrophysical Observation", "SAO 85072"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.752,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.33610961),
        dec: Angle.Degrees(+28.15382336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202365"},
        {"Hipparcos Number", "HIP 104867"},
        {"Smithsonian Astrophysical Observation", "SAO 89558"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.64257945),
        dec: Angle.Degrees(+28.15473417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202090"},
        {"Hipparcos Number", "HIP 104734"},
        {"Smithsonian Astrophysical Observation", "SAO 89534"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.24664117),
        dec: Angle.Degrees(+28.15494548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141527"},
        {"Hipparcos Number", "HIP 77442"},
        {"Geneva Identification System", "GEN# +1.00141527"},
        {"Smithsonian Astrophysical Observation", "SAO 84015"},
        {"Wilson Evans Batten Catalogue", "WEB 13113"},
    },
    visualMagnitude: 5.89,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.14340120),
        dec: Angle.Degrees(+28.15677692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128904"},
        {"Hipparcos Number", "HIP 71612"},
        {"Geneva Identification System", "GEN# +1.00128904"},
        {"Smithsonian Astrophysical Observation", "SAO 83451"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.69082990),
        dec: Angle.Degrees(+28.15690495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215162"},
        {"Hipparcos Number", "HIP 112155"},
        {"Smithsonian Astrophysical Observation", "SAO 90732"},
        {"Wilson Evans Batten Catalogue", "WEB 20016"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.74556852),
        dec: Angle.Degrees(+28.15713427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107213"},
        {"Hipparcos Number", "HIP 60098"},
        {"Geneva Identification System", "GEN# +5.21110066"},
        {"Smithsonian Astrophysical Observation", "SAO 82244"},
        {"Wilson Evans Batten Catalogue", "WEB 10683"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.87358760),
        dec: Angle.Degrees(+28.15722194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -202.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176230"},
        {"Hipparcos Number", "HIP 93111"},
        {"Smithsonian Astrophysical Observation", "SAO 86632"},
        {"Wilson Evans Batten Catalogue", "WEB 16129"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.51973560),
        dec: Angle.Degrees(+28.16109651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68384",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68384"},
        {"Smithsonian Astrophysical Observation", "SAO 83123"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.98199069),
        dec: Angle.Degrees(+28.16122297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74811"},
        {"Hipparcos Number", "HIP 43129"},
        {"Geneva Identification System", "GEN# +1.00074811"},
        {"Smithsonian Astrophysical Observation", "SAO 80423"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.78046255),
        dec: Angle.Degrees(+28.16193907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2799",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2799"},
        {"Smithsonian Astrophysical Observation", "SAO 74124"},
    },
    visualMagnitude: 9.94,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.91046918),
        dec: Angle.Degrees(+28.16242032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55370",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55370"},
        {"Smithsonian Astrophysical Observation", "SAO 81780"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.774,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.06604974),
        dec: Angle.Degrees(+28.16292852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2389"},
        {"Hipparcos Number", "HIP 2200"},
        {"Smithsonian Astrophysical Observation", "SAO 74015"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.95233075),
        dec: Angle.Degrees(+28.17388112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86680"},
        {"Hipparcos Number", "HIP 49060"},
        {"Geneva Identification System", "GEN# +1.00086680"},
        {"Smithsonian Astrophysical Observation", "SAO 81137"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.16631422),
        dec: Angle.Degrees(+28.17398213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -136.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94307"},
        {"Hipparcos Number", "HIP 53247"},
        {"Smithsonian Astrophysical Observation", "SAO 81567"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.36193220),
        dec: Angle.Degrees(+28.17410287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167942"},
        {"Hipparcos Number", "HIP 89543"},
        {"Smithsonian Astrophysical Observation", "SAO 85880"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.06375745),
        dec: Angle.Degrees(+28.17526629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24602"},
        {"Hipparcos Number", "HIP 18386"},
        {"Smithsonian Astrophysical Observation", "SAO 76322"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.95176226),
        dec: Angle.Degrees(+28.17591775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53744"},
        {"Hipparcos Number", "HIP 34367"},
        {"Geneva Identification System", "GEN# +1.00053744"},
        {"Smithsonian Astrophysical Observation", "SAO 79066"},
        {"Wilson Evans Batten Catalogue", "WEB 6886"},
    },
    visualMagnitude: 6.47,
    bvColour: -0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.85367604),
        dec: Angle.Degrees(+28.17669553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223018"},
        {"Hipparcos Number", "HIP 117196"},
        {"Geneva Identification System", "GEN# +1.00223018"},
        {"Smithsonian Astrophysical Observation", "SAO 91472"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.45326416),
        dec: Angle.Degrees(+28.17719034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56895",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8258 A"},
        {"Hipparcos Number", "HIP 56895"},
        {"Smithsonian Astrophysical Observation", "SAO 81928"},
        {"Wilson Evans Batten Catalogue", "WEB 10246"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.95541659),
        dec: Angle.Degrees(+28.17805330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64630",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64630"},
        {"Geneva Identification System", "GEN# +0.02802202"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.70863694),
        dec: Angle.Degrees(+28.17861131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65933"},
        {"Hipparcos Number", "HIP 39308"},
        {"Smithsonian Astrophysical Observation", "SAO 79880"},
    },
    visualMagnitude: 8.96,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.55793503),
        dec: Angle.Degrees(+28.18422487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38941",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38941"},
        {"Smithsonian Astrophysical Observation", "SAO 79825"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.51846000),
        dec: Angle.Degrees(+28.18455877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159926"},
        {"Hipparcos Number", "HIP 86130"},
        {"Smithsonian Astrophysical Observation", "SAO 85236"},
        {"Wilson Evans Batten Catalogue", "WEB 14527"},
    },
    visualMagnitude: 6.40,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.03375242),
        dec: Angle.Degrees(+28.18501951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27741"},
        {"Hipparcos Number", "HIP 20512"},
        {"Geneva Identification System", "GEN# +1.00027741"},
        {"Smithsonian Astrophysical Observation", "SAO 76586"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.93294502),
        dec: Angle.Degrees(+28.18660409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -127.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40110"},
        {"Hipparcos Number", "HIP 28244"},
        {"Geneva Identification System", "GEN# +1.00040110"},
        {"Smithsonian Astrophysical Observation", "SAO 77777"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.53093219),
        dec: Angle.Degrees(+28.18688126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53189",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53189"},
    },
    visualMagnitude: 10.05,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.19258161),
        dec: Angle.Degrees(+28.18769954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24505"},
        {"Hipparcos Number", "HIP 18320"},
        {"Geneva Identification System", "GEN# +1.00024505"},
        {"Smithsonian Astrophysical Observation", "SAO 76315"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.74930169),
        dec: Angle.Degrees(+28.18824099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177782"},
        {"Hipparcos Number", "HIP 93712"},
        {"Smithsonian Astrophysical Observation", "SAO 86785"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.22854374),
        dec: Angle.Degrees(+28.18824537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67094",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67094"},
        {"Geneva Identification System", "GEN# +0.02802257"},
        {"Smithsonian Astrophysical Observation", "SAO 82984"},
        {"New General Catalogue", "NGC 5272 1568"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.28059845),
        dec: Angle.Degrees(+28.18841036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185241"},
        {"Hipparcos Number", "HIP 96504"},
        {"Smithsonian Astrophysical Observation", "SAO 87461"},
        {"Wilson Evans Batten Catalogue", "WEB 16934"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.29022525),
        dec: Angle.Degrees(+28.18854832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46433",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46433"},
        {"Smithsonian Astrophysical Observation", "SAO 80846"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.04393333),
        dec: Angle.Degrees(+28.18935626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34160"},
        {"Hipparcos Number", "HIP 24593"},
        {"Smithsonian Astrophysical Observation", "SAO 77072"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.13565850),
        dec: Angle.Degrees(+28.19009306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170050"},
        {"Hipparcos Number", "HIP 90362"},
        {"Smithsonian Astrophysical Observation", "SAO 86052"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.58515296),
        dec: Angle.Degrees(+28.19028145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103151"},
        {"Hipparcos Number", "HIP 57922"},
        {"Geneva Identification System", "GEN# +1.00103151"},
        {"Smithsonian Astrophysical Observation", "SAO 82025"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.19485888),
        dec: Angle.Degrees(+28.19154818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53414"},
        {"Hipparcos Number", "HIP 34264"},
        {"Smithsonian Astrophysical Observation", "SAO 79053"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.54499446),
        dec: Angle.Degrees(+28.19195753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11801",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11801"},
        {"Smithsonian Astrophysical Observation", "SAO 75424"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.05639176),
        dec: Angle.Degrees(+28.19198737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121106"},
        {"Hipparcos Number", "HIP 67762"},
        {"Geneva Identification System", "GEN# +1.00121106"},
        {"Smithsonian Astrophysical Observation", "SAO 83049"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.22401957),
        dec: Angle.Degrees(+28.19289367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58074",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58074"},
        {"Geneva Identification System", "GEN# +0.02802059"},
    },
    visualMagnitude: 11.16,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.64858017),
        dec: Angle.Degrees(+28.19433817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47731"},
        {"Hipparcos Number", "HIP 32019"},
        {"Geneva Identification System", "GEN# +1.00047731"},
        {"Smithsonian Astrophysical Observation", "SAO 78636"},
        {"Wilson Evans Batten Catalogue", "WEB 6457"},
    },
    visualMagnitude: 6.45,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.33707287),
        dec: Angle.Degrees(+28.19664431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2909"},
        {"Hipparcos Number", "HIP 2563"},
        {"Cincinnati Publication", "Ci 18 61"},
        {"Geneva Identification System", "GEN# +1.00002909"},
        {"Smithsonian Astrophysical Observation", "SAO 74082"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.14137394),
        dec: Angle.Degrees(+28.19747447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 193.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205539"},
        {"Hipparcos Number", "HIP 106595"},
        {"Geneva Identification System", "GEN# +1.00205539"},
        {"Smithsonian Astrophysical Observation", "SAO 89815"},
        {"Wilson Evans Batten Catalogue", "WEB 19285"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.82926831),
        dec: Angle.Degrees(+28.19768744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 138.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62424",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62424"},
    },
    visualMagnitude: 11.05,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.89621193),
        dec: Angle.Degrees(+28.19867884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -186.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 93.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175940"},
        {"Hipparcos Number", "HIP 92986"},
        {"Smithsonian Astrophysical Observation", "SAO 86605"},
        {"Wilson Evans Batten Catalogue", "WEB 16104"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.15821779),
        dec: Angle.Degrees(+28.19877954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63432"},
        {"Hipparcos Number", "HIP 38231"},
        {"Geneva Identification System", "GEN# +1.00063432"},
        {"Smithsonian Astrophysical Observation", "SAO 79730"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.48759205),
        dec: Angle.Degrees(+28.19878472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218113"},
        {"Hipparcos Number", "HIP 113992"},
        {"Smithsonian Astrophysical Observation", "SAO 90995"},
        {"Wilson Evans Batten Catalogue", "WEB 20243"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.27490291),
        dec: Angle.Degrees(+28.20206774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66890",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8998 AB"},
        {"Henry Draper", "HD 119391"},
        {"Hipparcos Number", "HIP 66890"},
        {"Smithsonian Astrophysical Observation", "SAO 82956"},
        {"New General Catalogue", "NGC 5272 1343"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.61710691),
        dec: Angle.Degrees(+28.20245498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19762",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "V773 Tau D"},
        {"Henry Draper", "HD 283447"},
        {"Hipparcos Number", "HIP 19762"},
        {"Geneva Identification System", "GEN# +1.00283447"},
    },
    visualMagnitude: 10.71,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.55382961),
        dec: Angle.Degrees(+28.20347466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105602"},
        {"Hipparcos Number", "HIP 59270"},
        {"Geneva Identification System", "GEN# +1.00105602"},
        {"Smithsonian Astrophysical Observation", "SAO 82155"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.36522811),
        dec: Angle.Degrees(+28.20506030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113958"},
        {"Hipparcos Number", "HIP 63993"},
        {"Geneva Identification System", "GEN# +1.00113958"},
        {"Smithsonian Astrophysical Observation", "SAO 82655"},
        {"Wilson Evans Batten Catalogue", "WEB 11311"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.70798818),
        dec: Angle.Degrees(+28.20690016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159626"},
        {"Hipparcos Number", "HIP 85996"},
        {"Smithsonian Astrophysical Observation", "SAO 85218"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.63690266),
        dec: Angle.Degrees(+28.20855064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214824"},
        {"Hipparcos Number", "HIP 111937"},
        {"Geneva Identification System", "GEN# +1.00214824"},
        {"Smithsonian Astrophysical Observation", "SAO 90693"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.11272273),
        dec: Angle.Degrees(+28.21176674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45721"},
        {"Hipparcos Number", "HIP 31001"},
        {"Geneva Identification System", "GEN# +1.00045721"},
        {"Smithsonian Astrophysical Observation", "SAO 78440"},
        {"Wilson Evans Batten Catalogue", "WEB 6173"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.59170762),
        dec: Angle.Degrees(+28.21213046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130408"},
        {"Hipparcos Number", "HIP 72326"},
        {"Smithsonian Astrophysical Observation", "SAO 83520"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.84921630),
        dec: Angle.Degrees(+28.21261308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 152.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160953"},
        {"Hipparcos Number", "HIP 86577"},
        {"Smithsonian Astrophysical Observation", "SAO 85319"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.39878140),
        dec: Angle.Degrees(+28.21295106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34304",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34304"},
        {"Smithsonian Astrophysical Observation", "SAO 79058"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.68719247),
        dec: Angle.Degrees(+28.21475536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167472"},
        {"Hipparcos Number", "HIP 89362"},
        {"Geneva Identification System", "GEN# +1.00167472"},
        {"Smithsonian Astrophysical Observation", "SAO 85848"},
        {"Wilson Evans Batten Catalogue", "WEB 15197"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.53221160),
        dec: Angle.Degrees(+28.21648458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 246178"},
        {"Hipparcos Number", "HIP 26765"},
        {"Smithsonian Astrophysical Observation", "SAO 77387"},
    },
    visualMagnitude: 10.46,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.27686754),
        dec: Angle.Degrees(+28.21771421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153414"},
        {"Hipparcos Number", "HIP 83063"},
        {"Smithsonian Astrophysical Observation", "SAO 84731"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.58667745),
        dec: Angle.Degrees(+28.21893395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64097",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64097"},
        {"Geneva Identification System", "GEN# +0.02802188"},
        {"Smithsonian Astrophysical Observation", "SAO 82669"},
    },
    visualMagnitude: 10.45,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.03090733),
        dec: Angle.Degrees(+28.21906815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191279"},
        {"Hipparcos Number", "HIP 99183"},
        {"Geneva Identification System", "GEN# +1.00191279"},
        {"Smithsonian Astrophysical Observation", "SAO 88228"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.03710901),
        dec: Angle.Degrees(+28.22064187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55879",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55879"},
        {"Smithsonian Astrophysical Observation", "SAO 81834"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.80197604),
        dec: Angle.Degrees(+28.22369198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33787"},
        {"Hipparcos Number", "HIP 24389"},
        {"Smithsonian Astrophysical Observation", "SAO 77041"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.48699655),
        dec: Angle.Degrees(+28.22408884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 946",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 946"},
        {"Smithsonian Astrophysical Observation", "SAO 73798"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.91580225),
        dec: Angle.Degrees(+28.22513882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219514"},
        {"Hipparcos Number", "HIP 114872"},
        {"Smithsonian Astrophysical Observation", "SAO 91135"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.01681198),
        dec: Angle.Degrees(+28.22734250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40779",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40779"},
        {"Smithsonian Astrophysical Observation", "SAO 80092"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.84873786),
        dec: Angle.Degrees(+28.22758216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162526"},
        {"Hipparcos Number", "HIP 87299"},
        {"Smithsonian Astrophysical Observation", "SAO 85461"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.56716597),
        dec: Angle.Degrees(+28.23182504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155092"},
        {"Hipparcos Number", "HIP 83862"},
        {"Fundamental Katalog 5th Edition", "FK5 5511"},
        {"Geneva Identification System", "GEN# +1.00155092"},
        {"Smithsonian Astrophysical Observation", "SAO 84868"},
        {"Wilson Evans Batten Catalogue", "WEB 14176"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.08882962),
        dec: Angle.Degrees(+28.23405353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -133.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112248"},
        {"Hipparcos Number", "HIP 63039"},
        {"Geneva Identification System", "GEN# +1.00112248"},
        {"Smithsonian Astrophysical Observation", "SAO 82564"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.76551886),
        dec: Angle.Degrees(+28.23412675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96437",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96437"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.09778188),
        dec: Angle.Degrees(+28.23425352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93436",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93436"},
        {"Smithsonian Astrophysical Observation", "SAO 86719"},
    },
    visualMagnitude: 9.84,
    bvColour: 1.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.44415904),
        dec: Angle.Degrees(+28.23685814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89791",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89791"},
        {"Smithsonian Astrophysical Observation", "SAO 85924"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.86393453),
        dec: Angle.Degrees(+28.23774993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87407",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10851 AB"},
        {"Hipparcos Number", "HIP 87407"},
        {"Smithsonian Astrophysical Observation", "SAO 85483"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.93901646),
        dec: Angle.Degrees(+28.23775146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112886"},
        {"Hipparcos Number", "HIP 63407"},
        {"Geneva Identification System", "GEN# +1.00112886"},
        {"Smithsonian Astrophysical Observation", "SAO 82596"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.88888857),
        dec: Angle.Degrees(+28.23890933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -114.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151069"},
        {"Hipparcos Number", "HIP 81927"},
        {"Smithsonian Astrophysical Observation", "SAO 84571"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.00795663),
        dec: Angle.Degrees(+28.24135345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 333327"},
        {"Hipparcos Number", "HIP 98386"},
        {"Geneva Identification System", "GEN# +1.00333327"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.85166123),
        dec: Angle.Degrees(+28.24159106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88476"},
        {"Hipparcos Number", "HIP 50019"},
        {"Fundamental Katalog 5th Edition", "FK5 4908"},
        {"Geneva Identification System", "GEN# +1.00088476"},
        {"Smithsonian Astrophysical Observation", "SAO 81233"},
        {"Wilson Evans Batten Catalogue", "WEB 9195"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.17731104),
        dec: Angle.Degrees(+28.24204058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283978"},
        {"Hipparcos Number", "HIP 23343"},
        {"Geneva Identification System", "GEN# +1.00283978"},
        {"Smithsonian Astrophysical Observation", "SAO 76894"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.31855291),
        dec: Angle.Degrees(+28.24345583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95365",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12404 A"},
        {"Hipparcos Number", "HIP 95365"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.01635206),
        dec: Angle.Degrees(+28.24429520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88070",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88070"},
        {"Smithsonian Astrophysical Observation", "SAO 85608"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.80610543),
        dec: Angle.Degrees(+28.24433457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 335483"},
        {"Hipparcos Number", "HIP 103821"},
        {"Smithsonian Astrophysical Observation", "SAO 89392"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.58602664),
        dec: Angle.Degrees(+28.24474507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222317"},
        {"Hipparcos Number", "HIP 116740"},
        {"Cincinnati Publication", "Ci 18 3102"},
        {"Geneva Identification System", "GEN# +1.00222317"},
        {"Smithsonian Astrophysical Observation", "SAO 91405"},
        {"Wilson Evans Batten Catalogue", "WEB 20600"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.87821294),
        dec: Angle.Degrees(+28.24595359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 303.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 227.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167216"},
        {"Hipparcos Number", "HIP 89275"},
        {"Geneva Identification System", "GEN# +1.00167216"},
        {"Smithsonian Astrophysical Observation", "SAO 85834"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.25962315),
        dec: Angle.Degrees(+28.24635874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 110.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 434"},
        {"Hipparcos Number", "HIP 728"},
        {"Renson", "Renson 70"},
        {"Smithsonian Astrophysical Observation", "SAO 73772"},
        {"Wilson Evans Batten Catalogue", "WEB 122"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.25065511),
        dec: Angle.Degrees(+28.24755645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219477"},
        {"Hipparcos Number", "HIP 114844"},
        {"Fundamental Katalog 5th Edition", "FK5 3861"},
        {"Geneva Identification System", "GEN# +1.00219477"},
        {"Smithsonian Astrophysical Observation", "SAO 91130"},
        {"Wilson Evans Batten Catalogue", "WEB 20355"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.833,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.94284091),
        dec: Angle.Degrees(+28.24790461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86902",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86902"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.789,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.34711131),
        dec: Angle.Degrees(+28.24797394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -180.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198726"},
        {"Hipparcos Number", "HIP 102949"},
        {"Geneva Identification System", "GEN# +1.00198726"},
        {"Smithsonian Astrophysical Observation", "SAO 89216"},
        {"Wilson Evans Batten Catalogue", "WEB 18679"},
    },
    visualMagnitude: 5.66,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.86764739),
        dec: Angle.Degrees(+28.25051868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225036"},
        {"Hipparcos Number", "HIP 228"},
        {"Smithsonian Astrophysical Observation", "SAO 73712"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.71015217),
        dec: Angle.Degrees(+28.25189113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188058"},
        {"Hipparcos Number", "HIP 97788"},
        {"Smithsonian Astrophysical Observation", "SAO 87851"},
        {"Wilson Evans Batten Catalogue", "WEB 17203"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.06553903),
        dec: Angle.Degrees(+28.25218949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87930",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10936 AB"},
        {"Henry Draper", "HD 163969"},
        {"Hipparcos Number", "HIP 87930"},
        {"Smithsonian Astrophysical Observation", "SAO 85588"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.43374531),
        dec: Angle.Degrees(+28.25364502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173702"},
        {"Hipparcos Number", "HIP 92031"},
        {"Smithsonian Astrophysical Observation", "SAO 86407"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.37816979),
        dec: Angle.Degrees(+28.25672310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167215"},
        {"Hipparcos Number", "HIP 89270"},
        {"Geneva Identification System", "GEN# +1.00167215"},
        {"Smithsonian Astrophysical Observation", "SAO 85832"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.24752028),
        dec: Angle.Degrees(+28.25732582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 113.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18172"},
        {"Hipparcos Number", "HIP 13659"},
        {"Smithsonian Astrophysical Observation", "SAO 75648"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.97155608),
        dec: Angle.Degrees(+28.25740544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75716"},
        {"Hipparcos Number", "HIP 43575"},
        {"Geneva Identification System", "GEN# +1.00075716"},
        {"Smithsonian Astrophysical Observation", "SAO 80476"},
        {"Wilson Evans Batten Catalogue", "WEB 8398"},
    },
    visualMagnitude: 6.25,
    bvColour: 1.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.11916908),
        dec: Angle.Degrees(+28.25917608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31435"},
        {"Hipparcos Number", "HIP 23022"},
        {"Smithsonian Astrophysical Observation", "SAO 76854"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.26329734),
        dec: Angle.Degrees(+28.26040597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 248411"},
        {"Hipparcos Number", "HIP 27699"},
        {"Geneva Identification System", "GEN# +1.00248411"},
        {"Smithsonian Astrophysical Observation", "SAO 77645"},
    },
    visualMagnitude: 9.20,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.97646308),
        dec: Angle.Degrees(+28.26186773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31852",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5289 AB"},
        {"Henry Draper", "HD 47395"},
        {"Hipparcos Number", "HIP 31852"},
        {"Geneva Identification System", "GEN# +1.00047395"},
        {"Smithsonian Astrophysical Observation", "SAO 78593"},
        {"Wilson Evans Batten Catalogue", "WEB 6402"},
    },
    visualMagnitude: 6.02,
    bvColour: -0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.88801566),
        dec: Angle.Degrees(+28.26315774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184172"},
        {"Hipparcos Number", "HIP 96083"},
        {"Smithsonian Astrophysical Observation", "SAO 87325"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.02463746),
        dec: Angle.Degrees(+28.26680406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133330"},
        {"Hipparcos Number", "HIP 73635"},
        {"Geneva Identification System", "GEN# +1.00133330"},
        {"Smithsonian Astrophysical Observation", "SAO 83632"},
        {"Wilson Evans Batten Catalogue", "WEB 12590"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.77653825),
        dec: Angle.Degrees(+28.26723584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108381"},
        {"Hipparcos Number", "HIP 60742"},
        {"Fundamental Katalog 5th Edition", "FK5 2999"},
        {"Geneva Identification System", "GEN# +5.21110129"},
        {"Smithsonian Astrophysical Observation", "SAO 82313"},
        {"Wilson Evans Batten Catalogue", "WEB 10805"},
    },
    visualMagnitude: 4.35,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.73469831),
        dec: Angle.Degrees(+28.26861975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191671"},
        {"Hipparcos Number", "HIP 99361"},
        {"Smithsonian Astrophysical Observation", "SAO 88280"},
        {"Wilson Evans Batten Catalogue", "WEB 17731"},
    },
    visualMagnitude: 7.50,
    bvColour: -0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.50989007),
        dec: Angle.Degrees(+28.26911331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9714"},
        {"Hipparcos Number", "HIP 7421"},
        {"Geneva Identification System", "GEN# +1.00009714"},
        {"Smithsonian Astrophysical Observation", "SAO 74812"},
    },
    visualMagnitude: 6.89,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.90944105),
        dec: Angle.Degrees(+28.26959851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197263"},
        {"Hipparcos Number", "HIP 102127"},
        {"Geneva Identification System", "GEN# +1.00197263"},
        {"Smithsonian Astrophysical Observation", "SAO 89022"},
        {"Wilson Evans Batten Catalogue", "WEB 18472"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.43500391),
        dec: Angle.Degrees(+28.26972767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18928"},
        {"Hipparcos Number", "HIP 14232"},
        {"Geneva Identification System", "GEN# +1.00018928"},
        {"Smithsonian Astrophysical Observation", "SAO 75709"},
        {"Wilson Evans Batten Catalogue", "WEB 2789"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.87547130),
        dec: Angle.Degrees(+28.26995604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92522",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92522"},
    },
    visualMagnitude: 10.85,
    bvColour: 0.831,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.83690361),
        dec: Angle.Degrees(+28.27174847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186943"},
        {"Hipparcos Number", "HIP 97281"},
        {"Geneva Identification System", "GEN# +1.00186943"},
        {"Wilson Evans Batten Catalogue", "WEB 17089"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.56642405),
        dec: Angle.Degrees(+28.27197961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 267319"},
        {"Hipparcos Number", "HIP 33662"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.89543015),
        dec: Angle.Degrees(+28.27233633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143223"},
        {"Hipparcos Number", "HIP 78209"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.55544811),
        dec: Angle.Degrees(+28.27274248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33034"},
        {"Hipparcos Number", "HIP 23933"},
        {"Smithsonian Astrophysical Observation", "SAO 76978"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.14724348),
        dec: Angle.Degrees(+28.27345830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111"},
        {"Hipparcos Number", "HIP 502"},
        {"Smithsonian Astrophysical Observation", "SAO 73738"},
    },
    visualMagnitude: 6.62,
    bvColour: 1.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.50224247),
        dec: Angle.Degrees(+28.27696051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54456",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54456"},
        {"Smithsonian Astrophysical Observation", "SAO 81690"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.12597895),
        dec: Angle.Degrees(+28.27819616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106502",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106502"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.847,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.57566822),
        dec: Angle.Degrees(+28.27902610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 164.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 119.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2583",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 455 A"},
        {"Henry Draper", "HD 2942"},
        {"Hipparcos Number", "HIP 2583"},
        {"Geneva Identification System", "GEN# +1.00002942A"},
        {"Smithsonian Astrophysical Observation", "SAO 74090"},
        {"Wilson Evans Batten Catalogue", "WEB 475"},
    },
    visualMagnitude: 6.26,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.20454088),
        dec: Angle.Degrees(+28.28022584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94700",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12246 AB"},
        {"Henry Draper", "HD 180638"},
        {"Hipparcos Number", "HIP 94700"},
        {"Geneva Identification System", "GEN# +1.00180638J"},
        {"Renson", "Renson 50120"},
        {"Smithsonian Astrophysical Observation", "SAO 87013"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.04850670),
        dec: Angle.Degrees(+28.28064278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 334750"},
        {"Hipparcos Number", "HIP 101527"},
        {"New General Catalogue", "NGC 6940 120"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.63765768),
        dec: Angle.Degrees(+28.28095572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 258187"},
        {"Hipparcos Number", "HIP 30987"},
    },
    visualMagnitude: 11.01,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.54869436),
        dec: Angle.Degrees(+28.28262767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117263"},
        {"Hipparcos Number", "HIP 65757"},
        {"Geneva Identification System", "GEN# +1.00117263"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.20935461),
        dec: Angle.Degrees(+28.28590093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54525",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54525"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.34952946),
        dec: Angle.Degrees(+28.28595095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90249",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90249"},
    },
    visualMagnitude: 12.01,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.21945080),
        dec: Angle.Degrees(+28.28932630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -182.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70781",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9277 B"},
        {"Henry Draper", "HD 127043"},
        {"Hipparcos Number", "HIP 70781"},
        {"Geneva Identification System", "GEN# +1.00127043"},
        {"Smithsonian Astrophysical Observation", "SAO 83373"},
        {"Wilson Evans Batten Catalogue", "WEB 12261"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.13074078),
        dec: Angle.Degrees(+28.28946855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90188",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90188"},
        {"Smithsonian Astrophysical Observation", "SAO 86008"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.04844010),
        dec: Angle.Degrees(+28.29023750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70786",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9277 A"},
        {"Henry Draper", "HD 127067"},
        {"Hipparcos Number", "HIP 70786"},
        {"Geneva Identification System", "GEN# +1.00127067"},
        {"Smithsonian Astrophysical Observation", "SAO 83374"},
        {"Wilson Evans Batten Catalogue", "WEB 12262"},
    },
    visualMagnitude: 7.12,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.13868147),
        dec: Angle.Degrees(+28.29053945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23415",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3613 AB"},
        {"Henry Draper", "HD 32111"},
        {"Hipparcos Number", "HIP 23415"},
        {"Smithsonian Astrophysical Observation", "SAO 76906"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.49000225),
        dec: Angle.Degrees(+28.29115767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68315",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68315"},
        {"Smithsonian Astrophysical Observation", "SAO 83109"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.76569510),
        dec: Angle.Degrees(+28.29154374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68459"},
        {"Hipparcos Number", "HIP 40278"},
        {"Smithsonian Astrophysical Observation", "SAO 80018"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.37948266),
        dec: Angle.Degrees(+28.29186597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80338"},
        {"Hipparcos Number", "HIP 45767"},
        {"Smithsonian Astrophysical Observation", "SAO 80766"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.99128921),
        dec: Angle.Degrees(+28.29248334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60923",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60923"},
        {"Geneva Identification System", "GEN# +5.21110148"},
        {"Smithsonian Astrophysical Observation", "SAO 82332"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.28700312),
        dec: Angle.Degrees(+28.29418728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73080"},
        {"Hipparcos Number", "HIP 42294"},
        {"Geneva Identification System", "GEN# +1.00073080"},
        {"Smithsonian Astrophysical Observation", "SAO 80292"},
        {"Wilson Evans Batten Catalogue", "WEB 8123"},
    },
    visualMagnitude: 6.63,
    bvColour: 0.833,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.34208178),
        dec: Angle.Degrees(+28.29451898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106330"},
        {"Hipparcos Number", "HIP 59640"},
        {"Geneva Identification System", "GEN# +5.21110026"},
        {"Smithsonian Astrophysical Observation", "SAO 82198"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.46907247),
        dec: Angle.Degrees(+28.29454665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93003",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93003"},
        {"Smithsonian Astrophysical Observation", "SAO 86610"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.19477885),
        dec: Angle.Degrees(+28.29456897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105034"},
        {"Hipparcos Number", "HIP 58985"},
        {"Geneva Identification System", "GEN# +1.00105034"},
        {"Smithsonian Astrophysical Observation", "SAO 82130"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.40877886),
        dec: Angle.Degrees(+28.29474550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 163.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171520"},
        {"Hipparcos Number", "HIP 91026"},
        {"Smithsonian Astrophysical Observation", "SAO 86202"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.53145644),
        dec: Angle.Degrees(+28.29497825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41100"},
        {"Hipparcos Number", "HIP 28748"},
        {"Fundamental Katalog 5th Edition", "FK5 4553"},
        {"Geneva Identification System", "GEN# +1.00041100"},
        {"Smithsonian Astrophysical Observation", "SAO 77917"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.06763731),
        dec: Angle.Degrees(+28.30094000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283572"},
        {"Hipparcos Number", "HIP 20388"},
        {"Smithsonian Astrophysical Observation", "SAO 76567"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.798,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.49517718),
        dec: Angle.Degrees(+28.30187293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 244147"},
        {"Hipparcos Number", "HIP 25755"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.49645910),
        dec: Angle.Degrees(+28.30252410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173170"},
        {"Hipparcos Number", "HIP 91776"},
        {"Geneva Identification System", "GEN# +1.00173170"},
        {"Smithsonian Astrophysical Observation", "SAO 86350"},
    },
    visualMagnitude: 7.69,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.71697768),
        dec: Angle.Degrees(+28.30279522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172311"},
        {"Hipparcos Number", "HIP 91387"},
        {"Smithsonian Astrophysical Observation", "SAO 86268"},
        {"Wilson Evans Batten Catalogue", "WEB 15705"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.58316480),
        dec: Angle.Degrees(+28.30327670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52008",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52008"},
    },
    visualMagnitude: 10.55,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.37864374),
        dec: Angle.Degrees(+28.30563634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9972",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9972"},
    },
    visualMagnitude: 10.62,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.09894193),
        dec: Angle.Degrees(+28.30577171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 241.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -300.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108706",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108706"},
    },
    visualMagnitude: 11.99,
    bvColour: 1.718,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.30365718),
        dec: Angle.Degrees(+28.30681743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 372.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22964"},
        {"Hipparcos Number", "HIP 17299"},
        {"Smithsonian Astrophysical Observation", "SAO 76085"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.54183808),
        dec: Angle.Degrees(+28.30695678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190228"},
        {"Hipparcos Number", "HIP 98714"},
        {"Geneva Identification System", "GEN# +1.00190228"},
        {"Smithsonian Astrophysical Observation", "SAO 88118"},
        {"Wilson Evans Batten Catalogue", "WEB 17485"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.793,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.75293126),
        dec: Angle.Degrees(+28.30702660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37201",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37201"},
        {"Smithsonian Astrophysical Observation", "SAO 79569"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.63314396),
        dec: Angle.Degrees(+28.30977290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98501"},
        {"Hipparcos Number", "HIP 55361"},
        {"Smithsonian Astrophysical Observation", "SAO 81778"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.04160589),
        dec: Angle.Degrees(+28.31041753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9971",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9971"},
        {"Smithsonian Astrophysical Observation", "SAO 75160"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.818,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.09903331),
        dec: Angle.Degrees(+28.31151752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 226.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -303.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222632"},
        {"Hipparcos Number", "HIP 116946"},
        {"Smithsonian Astrophysical Observation", "SAO 91432"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.57785892),
        dec: Angle.Degrees(+28.31383633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30675"},
        {"Hipparcos Number", "HIP 22527"},
        {"Geneva Identification System", "GEN# +1.00030675"},
        {"Smithsonian Astrophysical Observation", "SAO 76784"},
        {"Wilson Evans Batten Catalogue", "WEB 4348"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.71666597),
        dec: Angle.Degrees(+28.31410571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1361",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1361"},
        {"Smithsonian Astrophysical Observation", "SAO 73869"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.26259854),
        dec: Angle.Degrees(+28.31431339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61034"},
        {"Hipparcos Number", "HIP 37194"},
        {"Smithsonian Astrophysical Observation", "SAO 79566"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.61307774),
        dec: Angle.Degrees(+28.31722639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49449"},
        {"Hipparcos Number", "HIP 32737"},
        {"Smithsonian Astrophysical Observation", "SAO 78776"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.42178714),
        dec: Angle.Degrees(+28.31774016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109164",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15638 A"},
        {"Henry Draper", "HD 209994"},
        {"Hipparcos Number", "HIP 109164"},
        {"Smithsonian Astrophysical Observation", "SAO 90233"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.68331117),
        dec: Angle.Degrees(+28.31808002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112734"},
        {"Hipparcos Number", "HIP 63320"},
        {"Geneva Identification System", "GEN# +1.00112734"},
        {"Renson", "Renson 32783"},
        {"Smithsonian Astrophysical Observation", "SAO 82589"},
        {"Wilson Evans Batten Catalogue", "WEB 11215"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.64122945),
        dec: Angle.Degrees(+28.31954218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52764",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52764"},
        {"Smithsonian Astrophysical Observation", "SAO 81519"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.82999078),
        dec: Angle.Degrees(+28.32042368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153207"},
        {"Hipparcos Number", "HIP 82933"},
        {"Smithsonian Astrophysical Observation", "SAO 84711"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.21848030),
        dec: Angle.Degrees(+28.32165688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106253",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106253"},
        {"Geneva Identification System", "GEN# +0.02704087"},
        {"Smithsonian Astrophysical Observation", "SAO 89775"},
    },
    visualMagnitude: 9.78,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.82381259),
        dec: Angle.Degrees(+28.32185522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66480",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8977 AB"},
        {"Hipparcos Number", "HIP 66480"},
        {"Smithsonian Astrophysical Observation", "SAO 82913"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.44440660),
        dec: Angle.Degrees(+28.32321823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -132.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200468"},
        {"Hipparcos Number", "HIP 103874"},
        {"Smithsonian Astrophysical Observation", "SAO 89404"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.71150733),
        dec: Angle.Degrees(+28.32337715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38658"},
        {"Hipparcos Number", "HIP 27447"},
        {"Geneva Identification System", "GEN# +1.00038658"},
        {"Smithsonian Astrophysical Observation", "SAO 77582"},
        {"Wilson Evans Batten Catalogue", "WEB 5389"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.17222988),
        dec: Angle.Degrees(+28.32459506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114914"},
        {"Hipparcos Number", "HIP 64518"},
        {"Geneva Identification System", "GEN# +1.00114914"},
        {"Smithsonian Astrophysical Observation", "SAO 82726"},
        {"Wilson Evans Batten Catalogue", "WEB 11405"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.35525932),
        dec: Angle.Degrees(+28.32514853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1699"},
        {"Hipparcos Number", "HIP 1704"},
        {"Geneva Identification System", "GEN# +1.00001699"},
        {"Smithsonian Astrophysical Observation", "SAO 73918"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.35700589),
        dec: Angle.Degrees(+28.32616929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121319"},
        {"Hipparcos Number", "HIP 67878"},
        {"Geneva Identification System", "GEN# +1.00121319"},
        {"Smithsonian Astrophysical Observation", "SAO 83066"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.53866762),
        dec: Angle.Degrees(+28.32788824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186884"},
        {"Hipparcos Number", "HIP 97257"},
        {"Smithsonian Astrophysical Observation", "SAO 87686"},
        {"Wilson Evans Batten Catalogue", "WEB 17082"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.49196700),
        dec: Angle.Degrees(+28.32813552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110371",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15863 AF"},
        {"Henry Draper", "HD 212097"},
        {"Hipparcos Number", "HIP 110371"},
        {"Geneva Identification System", "GEN# +1.00212097"},
        {"Smithsonian Astrophysical Observation", "SAO 90440"},
        {"Wilson Evans Batten Catalogue", "WEB 19793"},
    },
    visualMagnitude: 4.78,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.33053166),
        dec: Angle.Degrees(+28.33051592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43587",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Copernicus"},
        {"Henry Draper", "HD 75732"},
        {"Hipparcos Number", "HIP 43587"},
        {"Cincinnati Publication", "Ci 20 494"},
        {"Geneva Identification System", "GEN# +1.00075732A"},
        {"Smithsonian Astrophysical Observation", "SAO 80478"},
        {"Wilson Evans Batten Catalogue", "WEB 8400"},
    },
    visualMagnitude: 5.96,
    bvColour: 0.869,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.15055377),
        dec: Angle.Degrees(+28.33138843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -485.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -234.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 259083"},
        {"Hipparcos Number", "HIP 31219"},
        {"Smithsonian Astrophysical Observation", "SAO 78478"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.23172485),
        dec: Angle.Degrees(+28.33401348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89947",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11280 AB"},
        {"Henry Draper", "HD 168955"},
        {"Hipparcos Number", "HIP 89947"},
        {"Smithsonian Astrophysical Observation", "SAO 85958"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.28789277),
        dec: Angle.Degrees(+28.33422759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14028",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14028"},
        {"Smithsonian Astrophysical Observation", "SAO 75680"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.15786800),
        dec: Angle.Degrees(+28.33500256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16301"},
        {"Hipparcos Number", "HIP 12255"},
        {"Smithsonian Astrophysical Observation", "SAO 75480"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.45129484),
        dec: Angle.Degrees(+28.33518792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36440"},
        {"Hipparcos Number", "HIP 25997"},
        {"Smithsonian Astrophysical Observation", "SAO 77243"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.23289672),
        dec: Angle.Degrees(+28.33612778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104447",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104447"},
        {"Smithsonian Astrophysical Observation", "SAO 89490"},
    },
    visualMagnitude: 9.45,
    bvColour: -0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.36891192),
        dec: Angle.Degrees(+28.33617004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19646"},
        {"Hipparcos Number", "HIP 14766"},
        {"Smithsonian Astrophysical Observation", "SAO 75772"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.66420898),
        dec: Angle.Degrees(+28.33733747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121725"},
        {"Hipparcos Number", "HIP 68112"},
        {"Geneva Identification System", "GEN# +1.00121725"},
        {"Smithsonian Astrophysical Observation", "SAO 83086"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.17147121),
        dec: Angle.Degrees(+28.33803928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81614",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81614"},
        {"Smithsonian Astrophysical Observation", "SAO 84528"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.03810735),
        dec: Angle.Degrees(+28.33922305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151994"},
        {"Hipparcos Number", "HIP 82354"},
        {"Smithsonian Astrophysical Observation", "SAO 84626"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.40954706),
        dec: Angle.Degrees(+28.34176576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208174"},
        {"Hipparcos Number", "HIP 108084"},
        {"Cincinnati Publication", "Ci 18 2848"},
        {"Fundamental Katalog 5th Edition", "FK5 5934"},
        {"Geneva Identification System", "GEN# +1.00208174"},
        {"Renson", "Renson 57883"},
        {"Smithsonian Astrophysical Observation", "SAO 90085"},
        {"Wilson Evans Batten Catalogue", "WEB 19486"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.47829514),
        dec: Angle.Degrees(+28.34220959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -160.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -114.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220511"},
        {"Hipparcos Number", "HIP 115533"},
        {"Geneva Identification System", "GEN# +1.00220511"},
        {"Smithsonian Astrophysical Observation", "SAO 91235"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.04456490),
        dec: Angle.Degrees(+28.34342523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104701",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14748 AB"},
        {"Henry Draper", "HD 202015"},
        {"Hipparcos Number", "HIP 104701"},
        {"Smithsonian Astrophysical Observation", "SAO 89529"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.12961061),
        dec: Angle.Degrees(+28.34420532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94195",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94195"},
        {"Geneva Identification System", "GEN# +0.02803225"},
        {"Smithsonian Astrophysical Observation", "SAO 86895"},
        {"Wilson Evans Batten Catalogue", "WEB 16408"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.65328506),
        dec: Angle.Degrees(+28.34789061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186309"},
        {"Hipparcos Number", "HIP 96966"},
        {"Geneva Identification System", "GEN# +1.00186309"},
        {"Smithsonian Astrophysical Observation", "SAO 87605"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.65093946),
        dec: Angle.Degrees(+28.34811391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209598"},
        {"Hipparcos Number", "HIP 108928"},
        {"Smithsonian Astrophysical Observation", "SAO 90201"},
        {"Wilson Evans Batten Catalogue", "WEB 19593"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.99793276),
        dec: Angle.Degrees(+28.34841454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30482"},
        {"Hipparcos Number", "HIP 22400"},
        {"Smithsonian Astrophysical Observation", "SAO 76772"},
        {"Wilson Evans Batten Catalogue", "WEB 4321"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.779,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.31559464),
        dec: Angle.Degrees(+28.35084921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 253434"},
        {"Hipparcos Number", "HIP 29554"},
        {"Smithsonian Astrophysical Observation", "SAO 78117"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.41366667),
        dec: Angle.Degrees(+28.35588694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15713",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15713"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.60215026),
        dec: Angle.Degrees(+28.35589165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114556"},
        {"Hipparcos Number", "HIP 64313"},
        {"Geneva Identification System", "GEN# +1.00114556"},
        {"Renson", "Renson 33100"},
        {"Smithsonian Astrophysical Observation", "SAO 82694"},
        {"Wilson Evans Batten Catalogue", "WEB 11367"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.72316300),
        dec: Angle.Degrees(+28.35634289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82000",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10194 AB"},
        {"Henry Draper", "HD 151237"},
        {"Hipparcos Number", "HIP 82000"},
        {"Geneva Identification System", "GEN# +1.00151237"},
        {"Smithsonian Astrophysical Observation", "SAO 84577"},
        {"Wilson Evans Batten Catalogue", "WEB 13845"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.27183532),
        dec: Angle.Degrees(+28.35785518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74538",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74538"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.765,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.47052508),
        dec: Angle.Degrees(+28.35874697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72599",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72599"},
    },
    visualMagnitude: 10.67,
    bvColour: 0.831,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.65355370),
        dec: Angle.Degrees(+28.35913098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110524"},
        {"Hipparcos Number", "HIP 62017"},
        {"Fundamental Katalog 5th Edition", "FK5 5119"},
        {"Geneva Identification System", "GEN# +1.00110524"},
        {"Smithsonian Astrophysical Observation", "SAO 82449"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.66267357),
        dec: Angle.Degrees(+28.35987572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195231"},
        {"Hipparcos Number", "HIP 101054"},
        {"Geneva Identification System", "GEN# +1.00195231"},
        {"Smithsonian Astrophysical Observation", "SAO 88742"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.27860288),
        dec: Angle.Degrees(+28.36084284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 334747"},
        {"Hipparcos Number", "HIP 101519"},
        {"Geneva Identification System", "GEN# +2.69400100"},
        {"New General Catalogue", "NGC 6940 100"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.59551185),
        dec: Angle.Degrees(+28.36151374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16513",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16513"},
        {"Smithsonian Astrophysical Observation", "SAO 75983"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.15724782),
        dec: Angle.Degrees(+28.36584691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204934"},
        {"Hipparcos Number", "HIP 106241"},
        {"Smithsonian Astrophysical Observation", "SAO 89771"},
        {"Wilson Evans Batten Catalogue", "WEB 19246"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.78763675),
        dec: Angle.Degrees(+28.36627483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 332601"},
        {"Hipparcos Number", "HIP 97002"},
    },
    visualMagnitude: 9.60,
    bvColour: 1.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.73468696),
        dec: Angle.Degrees(+28.36755503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46891",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7426 A"},
        {"Henry Draper", "HD 82523"},
        {"Hipparcos Number", "HIP 46891"},
        {"Fundamental Katalog 5th Edition", "FK5 2760"},
        {"Geneva Identification System", "GEN# +1.00082523A"},
        {"Smithsonian Astrophysical Observation", "SAO 80900"},
        {"Wilson Evans Batten Catalogue", "WEB 8838"},
    },
    visualMagnitude: 6.50,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.32632739),
        dec: Angle.Degrees(+28.36801811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88678"},
        {"Hipparcos Number", "HIP 50145"},
        {"Smithsonian Astrophysical Observation", "SAO 81246"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.55016317),
        dec: Angle.Degrees(+28.36898386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4798"},
        {"Hipparcos Number", "HIP 3914"},
        {"Smithsonian Astrophysical Observation", "SAO 74301"},
        {"Wilson Evans Batten Catalogue", "WEB 697"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.56147971),
        dec: Angle.Degrees(+28.36904615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32279",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5386 AB"},
        {"Henry Draper", "HD 262665"},
        {"Hipparcos Number", "HIP 32279"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.08505334),
        dec: Angle.Degrees(+28.36907034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 261182"},
        {"Hipparcos Number", "HIP 31856"},
        {"Smithsonian Astrophysical Observation", "SAO 78595"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.89589024),
        dec: Angle.Degrees(+28.36973172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223332"},
        {"Hipparcos Number", "HIP 117423"},
        {"Geneva Identification System", "GEN# +1.00223332"},
        {"Smithsonian Astrophysical Observation", "SAO 91503"},
        {"Wilson Evans Batten Catalogue", "WEB 20680"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.14598004),
        dec: Angle.Degrees(+28.37104451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3075",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3075"},
        {"Smithsonian Astrophysical Observation", "SAO 74170"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.74972816),
        dec: Angle.Degrees(+28.37166977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90402"},
        {"Hipparcos Number", "HIP 51134"},
        {"Geneva Identification System", "GEN# +1.00090402"},
        {"Smithsonian Astrophysical Observation", "SAO 81343"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.69408130),
        dec: Angle.Degrees(+28.37437391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
