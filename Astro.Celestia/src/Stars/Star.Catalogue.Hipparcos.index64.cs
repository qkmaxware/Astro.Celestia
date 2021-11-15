using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_64() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82821"},
        {"Hipparcos Number", "HIP 46984"},
        {"Smithsonian Astrophysical Observation", "SAO 117775"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.63861322),
        dec: Angle.Degrees(+03.55791945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 109.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106679"},
        {"Hipparcos Number", "HIP 59829"},
        {"Smithsonian Astrophysical Observation", "SAO 119297"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.03010193),
        dec: Angle.Degrees(+03.55999346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36809"},
        {"Hipparcos Number", "HIP 26138"},
        {"Smithsonian Astrophysical Observation", "SAO 112907"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.60241946),
        dec: Angle.Degrees(+03.56139949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108958"},
        {"Hipparcos Number", "HIP 61088"},
        {"Smithsonian Astrophysical Observation", "SAO 119446"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.80371283),
        dec: Angle.Degrees(+03.56250779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51204",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7779 AB"},
        {"Henry Draper", "HD 90572"},
        {"Hipparcos Number", "HIP 51204"},
        {"Geneva Identification System", "GEN# +1.00090572"},
        {"Smithsonian Astrophysical Observation", "SAO 118314"},
        {"Wilson Evans Batten Catalogue", "WEB 9360"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.87619430),
        dec: Angle.Degrees(+03.56359953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -129.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100370",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100370"},
    },
    visualMagnitude: 11.03,
    bvColour: 1.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.33139523),
        dec: Angle.Degrees(+03.56588611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76448"},
        {"Hipparcos Number", "HIP 43876"},
        {"Geneva Identification System", "GEN# +1.00076448"},
        {"Smithsonian Astrophysical Observation", "SAO 117280"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.07673858),
        dec: Angle.Degrees(+03.56834289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200453"},
        {"Hipparcos Number", "HIP 103924"},
        {"Smithsonian Astrophysical Observation", "SAO 126495"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.84551684),
        dec: Angle.Degrees(+03.57015205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224496"},
        {"Hipparcos Number", "HIP 118185"},
        {"Smithsonian Astrophysical Observation", "SAO 128503"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.59830917),
        dec: Angle.Degrees(+03.57071390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35067"},
        {"Hipparcos Number", "HIP 25072"},
        {"Geneva Identification System", "GEN# +1.00035067"},
        {"Smithsonian Astrophysical Observation", "SAO 112679"},
        {"Wilson Evans Batten Catalogue", "WEB 4862"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.52307391),
        dec: Angle.Degrees(+03.57163415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111239"},
        {"Hipparcos Number", "HIP 62443"},
        {"Fundamental Katalog 5th Edition", "FK5 1330"},
        {"Geneva Identification System", "GEN# +1.00111239"},
        {"Smithsonian Astrophysical Observation", "SAO 119596"},
        {"Wilson Evans Batten Catalogue", "WEB 11086"},
    },
    visualMagnitude: 6.42,
    bvColour: 1.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.96423902),
        dec: Angle.Degrees(+03.57272118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15389"},
        {"Hipparcos Number", "HIP 11538"},
        {"Smithsonian Astrophysical Observation", "SAO 110555"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.18606337),
        dec: Angle.Degrees(+03.57283947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218442"},
        {"Hipparcos Number", "HIP 114228"},
        {"Smithsonian Astrophysical Observation", "SAO 127985"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.00724137),
        dec: Angle.Degrees(+03.57309258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104884"},
        {"Hipparcos Number", "HIP 58895"},
        {"Fundamental Katalog 5th Edition", "FK5 5064"},
        {"Smithsonian Astrophysical Observation", "SAO 119207"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.17918417),
        dec: Angle.Degrees(+03.57317473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19516",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19516"},
    },
    visualMagnitude: 10.48,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.71332163),
        dec: Angle.Degrees(+03.57426995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87112",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87112"},
        {"Smithsonian Astrophysical Observation", "SAO 122756"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.98292817),
        dec: Angle.Degrees(+03.57469615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17737"},
        {"Hipparcos Number", "HIP 8971"},
        {"Smithsonian Astrophysical Observation", "SAO 110782"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.90124215),
        dec: Angle.Degrees(+03.57793706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10279",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10279"},
        {"Cincinnati Publication", "Ci 20 153"},
        {"Geneva Identification System", "GEN# +0.00200348"},
        {"Wilson Evans Batten Catalogue", "WEB 2145"},
    },
    visualMagnitude: 10.04,
    bvColour: 1.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.09173956),
        dec: Angle.Degrees(+03.58012318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1761.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1852.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113624",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113624"},
        {"Smithsonian Astrophysical Observation", "SAO 127895"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.18151363),
        dec: Angle.Degrees(+03.58108783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 241842"},
        {"Hipparcos Number", "HIP 24368"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.43059095),
        dec: Angle.Degrees(+03.58118910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57291"},
        {"Hipparcos Number", "HIP 35595"},
        {"Geneva Identification System", "GEN# +1.00057291"},
        {"Smithsonian Astrophysical Observation", "SAO 115301"},
        {"Wilson Evans Batten Catalogue", "WEB 7091"},
    },
    visualMagnitude: 6.88,
    bvColour: -0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.18201074),
        dec: Angle.Degrees(+03.58167614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107301",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15265 AB"},
        {"Henry Draper", "HD 206736"},
        {"Hipparcos Number", "HIP 107301"},
        {"Smithsonian Astrophysical Observation", "SAO 127024"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.00265363),
        dec: Angle.Degrees(+03.58183643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52401",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7896 A"},
        {"Aitken 2", "ADS 7896 AB"},
        {"Henry Draper", "HD 92749"},
        {"Hipparcos Number", "HIP 52401"},
        {"Smithsonian Astrophysical Observation", "SAO 118443"},
        {"Wilson Evans Batten Catalogue", "WEB 9535"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.65636223),
        dec: Angle.Degrees(+03.58302440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204174"},
        {"Hipparcos Number", "HIP 105890"},
        {"Smithsonian Astrophysical Observation", "SAO 126798"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.68374387),
        dec: Angle.Degrees(+03.58639387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30545"},
        {"Hipparcos Number", "HIP 22354"},
        {"Geneva Identification System", "GEN# +1.00030545"},
        {"Smithsonian Astrophysical Observation", "SAO 112098"},
        {"Wilson Evans Batten Catalogue", "WEB 4308"},
    },
    visualMagnitude: 6.04,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.18594025),
        dec: Angle.Degrees(+03.58856374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10641"},
        {"Hipparcos Number", "HIP 8090"},
        {"Smithsonian Astrophysical Observation", "SAO 110093"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.96629254),
        dec: Angle.Degrees(+03.59000012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93982"},
        {"Hipparcos Number", "HIP 53026"},
        {"Smithsonian Astrophysical Observation", "SAO 118530"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.73761560),
        dec: Angle.Degrees(+03.59067272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158807"},
        {"Hipparcos Number", "HIP 85731"},
        {"Smithsonian Astrophysical Observation", "SAO 122462"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.79705420),
        dec: Angle.Degrees(+03.59187968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52285",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52285"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.25810927),
        dec: Angle.Degrees(+03.59660422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 132.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -133.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62704",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62704"},
        {"Fundamental Katalog 5th Edition", "FK5 5137"},
        {"Smithsonian Astrophysical Observation", "SAO 119625"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.74325918),
        dec: Angle.Degrees(+03.59831995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33603",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5648 AB"},
        {"Henry Draper", "HD 51814"},
        {"Hipparcos Number", "HIP 33603"},
        {"Fundamental Katalog 5th Edition", "FK5 2540"},
        {"Geneva Identification System", "GEN# +1.00051814J"},
        {"Smithsonian Astrophysical Observation", "SAO 114722"},
        {"Wilson Evans Batten Catalogue", "WEB 6757"},
    },
    visualMagnitude: 5.96,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.73761182),
        dec: Angle.Degrees(+03.60236429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112975"},
        {"Hipparcos Number", "HIP 63487"},
        {"Smithsonian Astrophysical Observation", "SAO 119712"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.12589144),
        dec: Angle.Degrees(+03.60412695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102249",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102249"},
        {"Smithsonian Astrophysical Observation", "SAO 126131"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.77499978),
        dec: Angle.Degrees(+03.60447273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158333"},
        {"Hipparcos Number", "HIP 85517"},
        {"Geneva Identification System", "GEN# +1.00158333"},
        {"Smithsonian Astrophysical Observation", "SAO 122413"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.14882752),
        dec: Angle.Degrees(+03.60560632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43"},
        {"Hipparcos Number", "HIP 448"},
        {"Geneva Identification System", "GEN# +1.00000043"},
        {"Smithsonian Astrophysical Observation", "SAO 109004"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.34271288),
        dec: Angle.Degrees(+03.60610712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220267"},
        {"Hipparcos Number", "HIP 115383"},
        {"Smithsonian Astrophysical Observation", "SAO 128144"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.60293911),
        dec: Angle.Degrees(+03.60613645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199084"},
        {"Hipparcos Number", "HIP 103217"},
        {"Smithsonian Astrophysical Observation", "SAO 126358"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.67916140),
        dec: Angle.Degrees(+03.60794742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15443",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15443"},
    },
    visualMagnitude: 11.26,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.77136146),
        dec: Angle.Degrees(+03.60857465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40124",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40124"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.93988374),
        dec: Angle.Degrees(+03.60860735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136904"},
        {"Hipparcos Number", "HIP 75298"},
        {"Smithsonian Astrophysical Observation", "SAO 120971"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.77056643),
        dec: Angle.Degrees(+03.61338221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7804"},
        {"Hipparcos Number", "HIP 6061"},
        {"Fundamental Katalog 5th Edition", "FK5 1034"},
        {"Geneva Identification System", "GEN# +1.00007804"},
        {"Smithsonian Astrophysical Observation", "SAO 109793"},
        {"Wilson Evans Batten Catalogue", "WEB 1368"},
    },
    visualMagnitude: 5.13,
    bvColour: 0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.44993370),
        dec: Angle.Degrees(+03.61452038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35730"},
        {"Hipparcos Number", "HIP 25477"},
        {"Celescope Catalog", "CEL 705"},
        {"Geneva Identification System", "GEN# +1.00035730"},
        {"Renson", "Renson 9230"},
        {"Smithsonian Astrophysical Observation", "SAO 112777"},
        {"Wilson Evans Batten Catalogue", "WEB 4936"},
    },
    visualMagnitude: 7.20,
    bvColour: -0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.72614892),
        dec: Angle.Degrees(+03.61467359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23279",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3597 B"},
        {"Henry Draper", "HD 32039"},
        {"Hipparcos Number", "HIP 23279"},
        {"Geneva Identification System", "GEN# +1.00032039"},
        {"Smithsonian Astrophysical Observation", "SAO 112304"},
        {"Wilson Evans Batten Catalogue", "WEB 4525"},
    },
    visualMagnitude: 7.03,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.13553594),
        dec: Angle.Degrees(+03.61482801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23287",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3597 A"},
        {"Henry Draper", "HD 32040"},
        {"Hipparcos Number", "HIP 23287"},
        {"Geneva Identification System", "GEN# +1.00032040J"},
        {"Smithsonian Astrophysical Observation", "SAO 112305"},
        {"Wilson Evans Batten Catalogue", "WEB 4526"},
    },
    visualMagnitude: 6.65,
    bvColour: -0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.14136380),
        dec: Angle.Degrees(+03.61581537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181334"},
        {"Hipparcos Number", "HIP 95019"},
        {"Smithsonian Astrophysical Observation", "SAO 124512"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.856,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.00702764),
        dec: Angle.Degrees(+03.61614164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95345"},
        {"Hipparcos Number", "HIP 53807"},
        {"Fundamental Katalog 5th Edition", "FK5 1284"},
        {"Geneva Identification System", "GEN# +1.00095345"},
        {"Smithsonian Astrophysical Observation", "SAO 118610"},
        {"Wilson Evans Batten Catalogue", "WEB 9748"},
    },
    visualMagnitude: 4.84,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.14016441),
        dec: Angle.Degrees(+03.61753351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91547"},
        {"Hipparcos Number", "HIP 51753"},
        {"Smithsonian Astrophysical Observation", "SAO 118373"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.60837470),
        dec: Angle.Degrees(+03.61793039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114573",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114573"},
        {"Smithsonian Astrophysical Observation", "SAO 128033"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.15073378),
        dec: Angle.Degrees(+03.61813347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99029"},
        {"Hipparcos Number", "HIP 55638"},
        {"Smithsonian Astrophysical Observation", "SAO 118830"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.785,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.96591578),
        dec: Angle.Degrees(+03.61920230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100851",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100851"},
    },
    visualMagnitude: 11.04,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.72056240),
        dec: Angle.Degrees(+03.62056387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98471"},
        {"Hipparcos Number", "HIP 55324"},
        {"Fundamental Katalog 5th Edition", "FK5 4996"},
        {"Geneva Identification System", "GEN# +1.00098471"},
        {"Smithsonian Astrophysical Observation", "SAO 118792"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.93547503),
        dec: Angle.Degrees(+03.62105634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126827"},
        {"Hipparcos Number", "HIP 70718"},
        {"Smithsonian Astrophysical Observation", "SAO 120474"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.94479583),
        dec: Angle.Degrees(+03.62142808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101092"},
        {"Hipparcos Number", "HIP 56747"},
        {"Smithsonian Astrophysical Observation", "SAO 118959"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.52123107),
        dec: Angle.Degrees(+03.62190291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89603"},
        {"Hipparcos Number", "HIP 50634"},
        {"Smithsonian Astrophysical Observation", "SAO 118240"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.12885059),
        dec: Angle.Degrees(+03.62250743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 244042"},
        {"Hipparcos Number", "HIP 25591"},
        {"Smithsonian Astrophysical Observation", "SAO 112796"},
        {"Wilson Evans Batten Catalogue", "WEB 4969"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.04019438),
        dec: Angle.Degrees(+03.62316225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 258337"},
        {"Hipparcos Number", "HIP 30930"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.36749235),
        dec: Angle.Degrees(+03.62383621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61887"},
        {"Hipparcos Number", "HIP 37478"},
        {"Geneva Identification System", "GEN# +1.00061887"},
        {"Smithsonian Astrophysical Observation", "SAO 115813"},
        {"Wilson Evans Batten Catalogue", "WEB 7413"},
    },
    visualMagnitude: 5.95,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.39648613),
        dec: Angle.Degrees(+03.62482750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121134"},
        {"Hipparcos Number", "HIP 67811"},
        {"Geneva Identification System", "GEN# +1.00121134"},
        {"Smithsonian Astrophysical Observation", "SAO 120154"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.37437898),
        dec: Angle.Degrees(+03.62688408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222464"},
        {"Hipparcos Number", "HIP 116836"},
        {"Fundamental Katalog 5th Edition", "FK5 6095"},
        {"Smithsonian Astrophysical Observation", "SAO 128322"},
    },
    visualMagnitude: 9.07,
    bvColour: -0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.21209557),
        dec: Angle.Degrees(+03.62719861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116866",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116866"},
        {"Smithsonian Astrophysical Observation", "SAO 128330"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.32641454),
        dec: Angle.Degrees(+03.63013361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14174",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14174"},
        {"Smithsonian Astrophysical Observation", "SAO 110929"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.69210311),
        dec: Angle.Degrees(+03.63068833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215512"},
        {"Hipparcos Number", "HIP 112376"},
        {"Geneva Identification System", "GEN# +1.00215512"},
        {"Smithsonian Astrophysical Observation", "SAO 127740"},
    },
    visualMagnitude: 7.89,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.40829765),
        dec: Angle.Degrees(+03.63115241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82352",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82352"},
        {"Geneva Identification System", "GEN# +0.00303281"},
        {"Wilson Evans Batten Catalogue", "WEB 13903"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.948,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.39954207),
        dec: Angle.Degrees(+03.63174841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104367"},
        {"Hipparcos Number", "HIP 58610"},
        {"Geneva Identification System", "GEN# +1.00104367"},
        {"Smithsonian Astrophysical Observation", "SAO 119169"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.29206275),
        dec: Angle.Degrees(+03.63237502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139359"},
        {"Hipparcos Number", "HIP 76523"},
        {"Smithsonian Astrophysical Observation", "SAO 121097"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.41747808),
        dec: Angle.Degrees(+03.63465659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22177",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22177"},
        {"Geneva Identification System", "GEN# +5.20252119"},
    },
    visualMagnitude: 10.92,
    bvColour: 1.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.57807963),
        dec: Angle.Degrees(+03.63630430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54080",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8043 AB"},
        {"Henry Draper", "HD 95899"},
        {"Hipparcos Number", "HIP 54080"},
        {"Smithsonian Astrophysical Observation", "SAO 118638"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.99546724),
        dec: Angle.Degrees(+03.63877571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38661"},
        {"Hipparcos Number", "HIP 27352"},
        {"Geneva Identification System", "GEN# +1.00038661"},
        {"Smithsonian Astrophysical Observation", "SAO 113143"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.89267662),
        dec: Angle.Degrees(+03.64006176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169365"},
        {"Hipparcos Number", "HIP 90195"},
        {"Geneva Identification System", "GEN# +1.00169365"},
        {"Renson", "Renson 47467"},
        {"Smithsonian Astrophysical Observation", "SAO 123434"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.06584109),
        dec: Angle.Degrees(+03.64110832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3915"},
        {"Hipparcos Number", "HIP 3276"},
        {"Smithsonian Astrophysical Observation", "SAO 109375"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.44202632),
        dec: Angle.Degrees(+03.64269654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70339"},
        {"Hipparcos Number", "HIP 40955"},
        {"Geneva Identification System", "GEN# +1.00070339"},
        {"Smithsonian Astrophysical Observation", "SAO 116667"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.37237265),
        dec: Angle.Degrees(+03.64451487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198167"},
        {"Hipparcos Number", "HIP 102680"},
        {"Smithsonian Astrophysical Observation", "SAO 126227"},
    },
    visualMagnitude: 6.78,
    bvColour: -0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.10233322),
        dec: Angle.Degrees(+03.64903377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30544"},
        {"Hipparcos Number", "HIP 22343"},
        {"Geneva Identification System", "GEN# +1.00030544"},
        {"Smithsonian Astrophysical Observation", "SAO 112096"},
        {"Wilson Evans Batten Catalogue", "WEB 4307"},
    },
    visualMagnitude: 7.32,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.16430009),
        dec: Angle.Degrees(+03.64927616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60678"},
        {"Hipparcos Number", "HIP 36947"},
        {"Smithsonian Astrophysical Observation", "SAO 115676"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.94685076),
        dec: Angle.Degrees(+03.64954031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182131"},
        {"Hipparcos Number", "HIP 95283"},
        {"Smithsonian Astrophysical Observation", "SAO 124568"},
    },
    visualMagnitude: 9.47,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.77340964),
        dec: Angle.Degrees(+03.65018875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38901"},
        {"Hipparcos Number", "HIP 27482"},
        {"Geneva Identification System", "GEN# +1.00038901"},
        {"Smithsonian Astrophysical Observation", "SAO 113172"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.29004863),
        dec: Angle.Degrees(+03.65134426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60306"},
        {"Hipparcos Number", "HIP 36785"},
        {"Smithsonian Astrophysical Observation", "SAO 115636"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.48903291),
        dec: Angle.Degrees(+03.65138846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89971"},
        {"Hipparcos Number", "HIP 50865"},
        {"Smithsonian Astrophysical Observation", "SAO 118270"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.79561694),
        dec: Angle.Degrees(+03.65177745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143809"},
        {"Hipparcos Number", "HIP 78557"},
        {"Geneva Identification System", "GEN# +1.00143809"},
        {"Smithsonian Astrophysical Observation", "SAO 121323"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.59352563),
        dec: Angle.Degrees(+03.65209928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102853",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102853"},
        {"Geneva Identification System", "GEN# +0.00304437"},
        {"Smithsonian Astrophysical Observation", "SAO 126272"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.55290350),
        dec: Angle.Degrees(+03.65233933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101444"},
        {"Hipparcos Number", "HIP 56955"},
        {"Geneva Identification System", "GEN# +1.00101444"},
        {"Smithsonian Astrophysical Observation", "SAO 118984"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.765,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.12816799),
        dec: Angle.Degrees(+03.65431914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 153.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104181"},
        {"Hipparcos Number", "HIP 58510"},
        {"Celescope Catalog", "CEL 4029"},
        {"Fundamental Katalog 5th Edition", "FK5 2960"},
        {"Geneva Identification System", "GEN# +1.00104181"},
        {"Smithsonian Astrophysical Observation", "SAO 119156"},
        {"Wilson Evans Batten Catalogue", "WEB 10446"},
    },
    visualMagnitude: 5.36,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.98718202),
        dec: Angle.Degrees(+03.65521716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76868"},
        {"Hipparcos Number", "HIP 44105"},
        {"Geneva Identification System", "GEN# +1.00076868"},
        {"Smithsonian Astrophysical Observation", "SAO 117318"},
        {"Wilson Evans Batten Catalogue", "WEB 8472"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.74721292),
        dec: Angle.Degrees(+03.65611766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105426"},
        {"Hipparcos Number", "HIP 59187"},
        {"Smithsonian Astrophysical Observation", "SAO 119237"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.07547222),
        dec: Angle.Degrees(+03.65843328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118022"},
        {"Hipparcos Number", "HIP 66200"},
        {"Fundamental Katalog 5th Edition", "FK5 1351"},
        {"Geneva Identification System", "GEN# +1.00118022"},
        {"Renson", "Renson 34020"},
        {"Smithsonian Astrophysical Observation", "SAO 120004"},
        {"Wilson Evans Batten Catalogue", "WEB 11691"},
    },
    visualMagnitude: 4.92,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.53293870),
        dec: Angle.Degrees(+03.65902506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127743"},
        {"Hipparcos Number", "HIP 71141"},
        {"Geneva Identification System", "GEN# +1.00127743"},
        {"Smithsonian Astrophysical Observation", "SAO 120520"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.24042455),
        dec: Angle.Degrees(+03.65940263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170973"},
        {"Hipparcos Number", "HIP 90858"},
        {"Geneva Identification System", "GEN# +1.00170973"},
        {"Renson", "Renson 47890"},
        {"Smithsonian Astrophysical Observation", "SAO 123610"},
        {"Wilson Evans Batten Catalogue", "WEB 15579"},
    },
    visualMagnitude: 6.41,
    bvColour: -0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.02867924),
        dec: Angle.Degrees(+03.65959509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152974"},
        {"Hipparcos Number", "HIP 82913"},
        {"Geneva Identification System", "GEN# +1.00152974"},
        {"Smithsonian Astrophysical Observation", "SAO 121952"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.16058944),
        dec: Angle.Degrees(+03.66165780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140934"},
        {"Hipparcos Number", "HIP 77240"},
        {"Geneva Identification System", "GEN# +1.00140934"},
        {"Smithsonian Astrophysical Observation", "SAO 121183"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.56837850),
        dec: Angle.Degrees(+03.66224576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191516"},
        {"Hipparcos Number", "HIP 99375"},
        {"Geneva Identification System", "GEN# +1.00191516"},
        {"Smithsonian Astrophysical Observation", "SAO 125516"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.55189653),
        dec: Angle.Degrees(+03.66349790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152717"},
        {"Hipparcos Number", "HIP 82761"},
        {"Smithsonian Astrophysical Observation", "SAO 121939"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.72122078),
        dec: Angle.Degrees(+03.66527183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195672"},
        {"Hipparcos Number", "HIP 101355"},
        {"Smithsonian Astrophysical Observation", "SAO 125922"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.13011596),
        dec: Angle.Degrees(+03.66561970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10795"},
        {"Hipparcos Number", "HIP 8211"},
        {"Smithsonian Astrophysical Observation", "SAO 110112"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.43267574),
        dec: Angle.Degrees(+03.66724627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85338",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85338"},
    },
    visualMagnitude: 10.70,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.58984714),
        dec: Angle.Degrees(+03.66994547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -151.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87048"},
        {"Hipparcos Number", "HIP 49213"},
        {"Smithsonian Astrophysical Observation", "SAO 118068"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.67847622),
        dec: Angle.Degrees(+03.67017848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4370",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4370"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.00610210),
        dec: Angle.Degrees(+03.67168444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190636"},
        {"Hipparcos Number", "HIP 98984"},
        {"Smithsonian Astrophysical Observation", "SAO 125433"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.42820723),
        dec: Angle.Degrees(+03.67263557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72361"},
        {"Hipparcos Number", "HIP 41886"},
        {"Smithsonian Astrophysical Observation", "SAO 116871"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.11629857),
        dec: Angle.Degrees(+03.67352030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125309"},
        {"Hipparcos Number", "HIP 69914"},
        {"Smithsonian Astrophysical Observation", "SAO 120388"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.62426290),
        dec: Angle.Degrees(+03.67459770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38922",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38922"},
    },
    visualMagnitude: 10.30,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.47519971),
        dec: Angle.Degrees(+03.67551817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20791"},
        {"Hipparcos Number", "HIP 15619"},
        {"Geneva Identification System", "GEN# +1.00020791"},
        {"Smithsonian Astrophysical Observation", "SAO 111142"},
        {"Wilson Evans Batten Catalogue", "WEB 2995"},
    },
    visualMagnitude: 5.70,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.27821082),
        dec: Angle.Degrees(+03.67568149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223989"},
        {"Hipparcos Number", "HIP 117858"},
        {"Smithsonian Astrophysical Observation", "SAO 128454"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.58101350),
        dec: Angle.Degrees(+03.67799404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111020",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111020"},
        {"Smithsonian Astrophysical Observation", "SAO 127547"},
    },
    visualMagnitude: 9.74,
    bvColour: 1.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.38252923),
        dec: Angle.Degrees(+03.67844299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18359"},
        {"Hipparcos Number", "HIP 13762"},
        {"Geneva Identification System", "GEN# +1.00018359"},
        {"Smithsonian Astrophysical Observation", "SAO 110866"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.28990039),
        dec: Angle.Degrees(+03.67874821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125978"},
        {"Hipparcos Number", "HIP 70272"},
        {"Geneva Identification System", "GEN# +1.00125978"},
        {"Smithsonian Astrophysical Observation", "SAO 120419"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.66238958),
        dec: Angle.Degrees(+03.67893157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48717"},
        {"Hipparcos Number", "HIP 32318"},
        {"Geneva Identification System", "GEN# +1.00048717"},
        {"Smithsonian Astrophysical Observation", "SAO 114355"},
        {"Wilson Evans Batten Catalogue", "WEB 6518"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.20655204),
        dec: Angle.Degrees(+03.67990328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193082"},
        {"Hipparcos Number", "HIP 100092"},
        {"Smithsonian Astrophysical Observation", "SAO 125660"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.58242543),
        dec: Angle.Degrees(+03.68073238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20469"},
        {"Hipparcos Number", "HIP 15333"},
        {"Smithsonian Astrophysical Observation", "SAO 111106"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.43884119),
        dec: Angle.Degrees(+03.68157460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38001"},
        {"Hipparcos Number", "HIP 26898"},
        {"Smithsonian Astrophysical Observation", "SAO 113057"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.65361826),
        dec: Angle.Degrees(+03.68189486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43304",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7022 A"},
        {"Henry Draper", "HD 75318"},
        {"Hipparcos Number", "HIP 43304"},
        {"Cincinnati Publication", "Ci 18 1034"},
        {"Smithsonian Astrophysical Observation", "SAO 117167"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.33903029),
        dec: Angle.Degrees(+03.68398172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -273.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9371"},
        {"Hipparcos Number", "HIP 7156"},
        {"Smithsonian Astrophysical Observation", "SAO 109952"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.06219789),
        dec: Angle.Degrees(+03.68516191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11037"},
        {"Hipparcos Number", "HIP 8404"},
        {"Fundamental Katalog 5th Edition", "FK5 2121"},
        {"Geneva Identification System", "GEN# +1.00011037"},
        {"Smithsonian Astrophysical Observation", "SAO 110138"},
        {"Wilson Evans Batten Catalogue", "WEB 1787"},
    },
    visualMagnitude: 5.91,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.10843265),
        dec: Angle.Degrees(+03.68540364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33866"},
        {"Hipparcos Number", "HIP 24336"},
        {"Geneva Identification System", "GEN# +1.00033866"},
        {"Smithsonian Astrophysical Observation", "SAO 112529"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.35442218),
        dec: Angle.Degrees(+03.68704787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62860"},
        {"Hipparcos Number", "HIP 37912"},
        {"Geneva Identification System", "GEN# +1.00062860"},
        {"Smithsonian Astrophysical Observation", "SAO 115902"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.53917187),
        dec: Angle.Degrees(+03.68752672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70643",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9265 AB"},
        {"Henry Draper", "HD 126698"},
        {"Hipparcos Number", "HIP 70643"},
        {"Smithsonian Astrophysical Observation", "SAO 120466"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.74371667),
        dec: Angle.Degrees(+03.68756645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115709"},
        {"Hipparcos Number", "HIP 64954"},
        {"Fundamental Katalog 5th Edition", "FK5 5174"},
        {"Geneva Identification System", "GEN# +1.00115709"},
        {"Smithsonian Astrophysical Observation", "SAO 119867"},
        {"Wilson Evans Batten Catalogue", "WEB 11480"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.71314235),
        dec: Angle.Degrees(+03.68766942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30573"},
        {"Hipparcos Number", "HIP 22367"},
        {"Geneva Identification System", "GEN# +1.00030573"},
        {"Smithsonian Astrophysical Observation", "SAO 112100"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.23443223),
        dec: Angle.Degrees(+03.68973404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87740"},
        {"Hipparcos Number", "HIP 49571"},
        {"Smithsonian Astrophysical Observation", "SAO 118115"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.79269944),
        dec: Angle.Degrees(+03.68980962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215475"},
        {"Hipparcos Number", "HIP 112347"},
        {"Smithsonian Astrophysical Observation", "SAO 127735"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.34055612),
        dec: Angle.Degrees(+03.68990216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49641"},
        {"Hipparcos Number", "HIP 32713"},
        {"Smithsonian Astrophysical Observation", "SAO 114472"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.37272176),
        dec: Angle.Degrees(+03.69174369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24714",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3880 AB"},
        {"Henry Draper", "HD 34501"},
        {"Hipparcos Number", "HIP 24714"},
        {"Smithsonian Astrophysical Observation", "SAO 112605"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.51471468),
        dec: Angle.Degrees(+03.69176114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87151",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87151"},
        {"Smithsonian Astrophysical Observation", "SAO 122767"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.08489032),
        dec: Angle.Degrees(+03.69295480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167766"},
        {"Hipparcos Number", "HIP 89568"},
        {"Smithsonian Astrophysical Observation", "SAO 123316"},
        {"Wilson Evans Batten Catalogue", "WEB 15252"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.15389776),
        dec: Angle.Degrees(+03.69310718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183265"},
        {"Hipparcos Number", "HIP 95767"},
        {"Smithsonian Astrophysical Observation", "SAO 124669"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.16814976),
        dec: Angle.Degrees(+03.69398306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165828"},
        {"Hipparcos Number", "HIP 88819"},
        {"Smithsonian Astrophysical Observation", "SAO 123148"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.95793824),
        dec: Angle.Degrees(+03.69438497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202464"},
        {"Hipparcos Number", "HIP 104996"},
        {"Smithsonian Astrophysical Observation", "SAO 126664"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.98110375),
        dec: Angle.Degrees(+03.69649598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187205"},
        {"Hipparcos Number", "HIP 97465"},
        {"Wilson Evans Batten Catalogue", "WEB 17130"},
    },
    visualMagnitude: 9.68,
    bvColour: 1.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.15509317),
        dec: Angle.Degrees(+03.69709291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108562"},
        {"Hipparcos Number", "HIP 60843"},
        {"Smithsonian Astrophysical Observation", "SAO 119418"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.06820626),
        dec: Angle.Degrees(+03.69710363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19946",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19946"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.783,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.16941395),
        dec: Angle.Degrees(+03.69890739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94400"},
        {"Hipparcos Number", "HIP 53286"},
        {"Geneva Identification System", "GEN# +1.00094400"},
        {"Smithsonian Astrophysical Observation", "SAO 118567"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.47397214),
        dec: Angle.Degrees(+03.70150685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3061",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3061"},
    },
    visualMagnitude: 11.66,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.71198250),
        dec: Angle.Degrees(+03.70480928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 197.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 89.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107473"},
        {"Hipparcos Number", "HIP 60249"},
        {"Geneva Identification System", "GEN# +1.00107473"},
        {"Smithsonian Astrophysical Observation", "SAO 119347"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.30901337),
        dec: Angle.Degrees(+03.70778521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134438"},
        {"Hipparcos Number", "HIP 74202"},
        {"Smithsonian Astrophysical Observation", "SAO 120873"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.44788438),
        dec: Angle.Degrees(+03.70841734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96956"},
        {"Hipparcos Number", "HIP 54565"},
        {"Smithsonian Astrophysical Observation", "SAO 118697"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.47785238),
        dec: Angle.Degrees(+03.71055043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10337"},
        {"Hipparcos Number", "HIP 7860"},
        {"Smithsonian Astrophysical Observation", "SAO 110055"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.27808138),
        dec: Angle.Degrees(+03.71363494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -109.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 107.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220512"},
        {"Hipparcos Number", "HIP 115544"},
        {"Smithsonian Astrophysical Observation", "SAO 128160"},
        {"Wilson Evans Batten Catalogue", "WEB 20452"},
    },
    visualMagnitude: 6.62,
    bvColour: 1.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.06861756),
        dec: Angle.Degrees(+03.71558102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105682",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14942 AB"},
        {"Henry Draper", "HD 203789"},
        {"Hipparcos Number", "HIP 105682"},
        {"Geneva Identification System", "GEN# +1.00203789J"},
        {"Smithsonian Astrophysical Observation", "SAO 126772"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.08228208),
        dec: Angle.Degrees(+03.71689096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32145"},
        {"Hipparcos Number", "HIP 23328"},
        {"Geneva Identification System", "GEN# +1.00032145"},
        {"Renson", "Renson 8190"},
        {"Smithsonian Astrophysical Observation", "SAO 112316"},
    },
    visualMagnitude: 7.25,
    bvColour: -0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.27509403),
        dec: Angle.Degrees(+03.71733923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204980"},
        {"Hipparcos Number", "HIP 106332"},
        {"Smithsonian Astrophysical Observation", "SAO 126870"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.03556819),
        dec: Angle.Degrees(+03.71770624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39399"},
        {"Hipparcos Number", "HIP 27759"},
        {"Smithsonian Astrophysical Observation", "SAO 113221"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.12321958),
        dec: Angle.Degrees(+03.71825869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127032"},
        {"Hipparcos Number", "HIP 70816"},
        {"Smithsonian Astrophysical Observation", "SAO 120489"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.23524662),
        dec: Angle.Degrees(+03.71956371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115753"},
        {"Hipparcos Number", "HIP 64983"},
        {"Smithsonian Astrophysical Observation", "SAO 119872"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.77791672),
        dec: Angle.Degrees(+03.72285325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144065"},
        {"Hipparcos Number", "HIP 78695"},
        {"Fundamental Katalog 5th Edition", "FK5 5418"},
        {"Smithsonian Astrophysical Observation", "SAO 121340"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.97036390),
        dec: Angle.Degrees(+03.72723490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65320",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65320"},
    },
    visualMagnitude: 9.66,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.81553490),
        dec: Angle.Degrees(+03.72977947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93101"},
        {"Hipparcos Number", "HIP 52591"},
        {"Smithsonian Astrophysical Observation", "SAO 118474"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.30618287),
        dec: Angle.Degrees(+03.73001126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163132"},
        {"Hipparcos Number", "HIP 87675"},
        {"Smithsonian Astrophysical Observation", "SAO 122909"},
    },
    visualMagnitude: 6.57,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.61806111),
        dec: Angle.Degrees(+03.73219683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12031",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12031"},
        {"Geneva Identification System", "GEN# +6.20001024"},
        {"Geneva Identification System 2", "GEN# +6.10161376"},
        {"Wilson Evans Batten Catalogue", "WEB 2479"},
    },
    visualMagnitude: 12.41,
    bvColour: -0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.78144144),
        dec: Angle.Degrees(+03.73243056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125181"},
        {"Hipparcos Number", "HIP 69851"},
        {"Geneva Identification System", "GEN# +1.00125181"},
        {"Smithsonian Astrophysical Observation", "SAO 120385"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.43034834),
        dec: Angle.Degrees(+03.73293143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136098"},
        {"Hipparcos Number", "HIP 74932"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.67898622),
        dec: Angle.Degrees(+03.73553560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206186"},
        {"Hipparcos Number", "HIP 107003"},
        {"Smithsonian Astrophysical Observation", "SAO 126975"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.06786914),
        dec: Angle.Degrees(+03.73705429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105885",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105885"},
        {"Geneva Identification System", "GEN# +6.20030070"},
        {"Wilson Evans Batten Catalogue", "WEB 19203"},
    },
    visualMagnitude: 10.50,
    bvColour: 1.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.67697943),
        dec: Angle.Degrees(+03.73727114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11828",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1941 AB"},
        {"Henry Draper", "HD 15805"},
        {"Hipparcos Number", "HIP 11828"},
        {"Smithsonian Astrophysical Observation", "SAO 110600"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.16327092),
        dec: Angle.Degrees(+03.73860392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163402"},
        {"Hipparcos Number", "HIP 87786"},
        {"Smithsonian Astrophysical Observation", "SAO 122924"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.98583622),
        dec: Angle.Degrees(+03.73930627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95344"},
        {"Hipparcos Number", "HIP 53814"},
        {"Smithsonian Astrophysical Observation", "SAO 118612"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.15607412),
        dec: Angle.Degrees(+03.73945160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177789"},
        {"Hipparcos Number", "HIP 93795"},
        {"Smithsonian Astrophysical Observation", "SAO 124261"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.52011796),
        dec: Angle.Degrees(+03.73960530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220319"},
        {"Hipparcos Number", "HIP 115412"},
        {"Geneva Identification System", "GEN# +1.00220319"},
        {"Smithsonian Astrophysical Observation", "SAO 128148"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.68396741),
        dec: Angle.Degrees(+03.74011767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83543",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83543"},
        {"Geneva Identification System", "GEN# +9.80019011"},
    },
    visualMagnitude: 11.12,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.12024178),
        dec: Angle.Degrees(+03.74048963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -216.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -155.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224305"},
        {"Hipparcos Number", "HIP 118053"},
        {"Smithsonian Astrophysical Observation", "SAO 128486"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.19117689),
        dec: Angle.Degrees(+03.74162268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213858"},
        {"Hipparcos Number", "HIP 111413"},
        {"Smithsonian Astrophysical Observation", "SAO 127608"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.58063789),
        dec: Angle.Degrees(+03.74261263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55412"},
        {"Hipparcos Number", "HIP 34873"},
        {"Geneva Identification System", "GEN# +1.00055412"},
        {"Smithsonian Astrophysical Observation", "SAO 115082"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.23364635),
        dec: Angle.Degrees(+03.74408713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133314"},
        {"Hipparcos Number", "HIP 73678"},
        {"Smithsonian Astrophysical Observation", "SAO 120816"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.90834706),
        dec: Angle.Degrees(+03.74823235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33110"},
        {"Hipparcos Number", "HIP 23899"},
        {"Smithsonian Astrophysical Observation", "SAO 112452"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.02658709),
        dec: Angle.Degrees(+03.74858536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170137"},
        {"Hipparcos Number", "HIP 90487"},
        {"Geneva Identification System", "GEN# +1.00170137"},
        {"Smithsonian Astrophysical Observation", "SAO 123513"},
        {"Wilson Evans Batten Catalogue", "WEB 15496"},
    },
    visualMagnitude: 6.07,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.95967451),
        dec: Angle.Degrees(+03.74858969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24537",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3847 AB"},
        {"Henry Draper", "HD 34211"},
        {"Hipparcos Number", "HIP 24537"},
        {"Smithsonian Astrophysical Observation", "SAO 112580"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.96864179),
        dec: Angle.Degrees(+03.74886249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141492"},
        {"Hipparcos Number", "HIP 77485"},
        {"Smithsonian Astrophysical Observation", "SAO 121205"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.32354705),
        dec: Angle.Degrees(+03.74913734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29005"},
        {"Hipparcos Number", "HIP 21299"},
        {"Smithsonian Astrophysical Observation", "SAO 111898"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.56242439),
        dec: Angle.Degrees(+03.74968187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64429"},
        {"Hipparcos Number", "HIP 38581"},
        {"Smithsonian Astrophysical Observation", "SAO 116087"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.49955018),
        dec: Angle.Degrees(+03.74992992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72179",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72179"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.45384716),
        dec: Angle.Degrees(+03.75080575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92164",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92164"},
        {"Geneva Identification System", "GEN# +0.00303799"},
        {"Smithsonian Astrophysical Observation", "SAO 123913"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.75831322),
        dec: Angle.Degrees(+03.75100301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115629"},
        {"Hipparcos Number", "HIP 64917"},
        {"Smithsonian Astrophysical Observation", "SAO 119861"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.59312967),
        dec: Angle.Degrees(+03.75239920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203506"},
        {"Hipparcos Number", "HIP 105536"},
        {"Smithsonian Astrophysical Observation", "SAO 126741"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.61851040),
        dec: Angle.Degrees(+03.75328840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87745",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87745"},
        {"Geneva Identification System", "GEN# +6.20030324"},
        {"Wilson Evans Batten Catalogue", "WEB 14810"},
    },
    visualMagnitude: 10.12,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.85344454),
        dec: Angle.Degrees(+03.75444348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17615",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17615"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.60660461),
        dec: Angle.Degrees(+03.75457293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138249"},
        {"Hipparcos Number", "HIP 75976"},
        {"Smithsonian Astrophysical Observation", "SAO 121037"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.73895154),
        dec: Angle.Degrees(+03.75537892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75232"},
        {"Hipparcos Number", "HIP 43271"},
        {"Geneva Identification System", "GEN# +1.00075232"},
        {"Smithsonian Astrophysical Observation", "SAO 117157"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.22744806),
        dec: Angle.Degrees(+03.75578138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2829"},
        {"Hipparcos Number", "HIP 2500"},
        {"Geneva Identification System", "GEN# +1.00002829"},
        {"Smithsonian Astrophysical Observation", "SAO 109253"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.92616950),
        dec: Angle.Degrees(+03.75626549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138248"},
        {"Hipparcos Number", "HIP 75969"},
        {"Smithsonian Astrophysical Observation", "SAO 121036"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.72530226),
        dec: Angle.Degrees(+03.75727232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155028"},
        {"Hipparcos Number", "HIP 83913"},
        {"Smithsonian Astrophysical Observation", "SAO 122127"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.24791624),
        dec: Angle.Degrees(+03.75956385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44638"},
        {"Hipparcos Number", "HIP 30341"},
        {"Smithsonian Astrophysical Observation", "SAO 113795"},
        {"Wilson Evans Batten Catalogue", "WEB 6036"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.73126863),
        dec: Angle.Degrees(+03.76078144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1969"},
        {"Hipparcos Number", "HIP 1894"},
        {"Smithsonian Astrophysical Observation", "SAO 109180"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.98767670),
        dec: Angle.Degrees(+03.76102513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184279"},
        {"Hipparcos Number", "HIP 96196"},
        {"Geneva Identification System", "GEN# +1.00184279"},
        {"Smithsonian Astrophysical Observation", "SAO 124788"},
        {"Wilson Evans Batten Catalogue", "WEB 16857"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.40383033),
        dec: Angle.Degrees(+03.76133443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44700"},
        {"Hipparcos Number", "HIP 30382"},
        {"Celescope Catalog", "CEL 1210"},
        {"Geneva Identification System", "GEN# +1.00044700"},
        {"Smithsonian Astrophysical Observation", "SAO 113801"},
        {"Wilson Evans Batten Catalogue", "WEB 6042"},
    },
    visualMagnitude: 6.41,
    bvColour: -0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.82704150),
        dec: Angle.Degrees(+03.76451254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94179"},
        {"Hipparcos Number", "HIP 53142"},
        {"Smithsonian Astrophysical Observation", "SAO 118551"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.06484547),
        dec: Angle.Degrees(+03.76565727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183087"},
        {"Hipparcos Number", "HIP 95689"},
        {"Smithsonian Astrophysical Observation", "SAO 124650"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.94967128),
        dec: Angle.Degrees(+03.76594231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103804",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14551 AB"},
        {"Henry Draper", "HD 200210"},
        {"Hipparcos Number", "HIP 103804"},
        {"Smithsonian Astrophysical Observation", "SAO 126480"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.50853675),
        dec: Angle.Degrees(+03.76610210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14362",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14362"},
        {"Smithsonian Astrophysical Observation", "SAO 110953"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.32682272),
        dec: Angle.Degrees(+03.76672444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36777"},
        {"Hipparcos Number", "HIP 26126"},
        {"Celescope Catalog", "CEL 793"},
        {"Geneva Identification System", "GEN# +1.00036777J"},
        {"Smithsonian Astrophysical Observation", "SAO 112904"},
        {"Wilson Evans Batten Catalogue", "WEB 5090"},
    },
    visualMagnitude: 5.32,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.56995870),
        dec: Angle.Degrees(+03.76693355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154478"},
        {"Hipparcos Number", "HIP 83638"},
        {"Smithsonian Astrophysical Observation", "SAO 122066"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.39467452),
        dec: Angle.Degrees(+03.76751172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13285"},
        {"Hipparcos Number", "HIP 10099"},
        {"Smithsonian Astrophysical Observation", "SAO 110378"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.46391878),
        dec: Angle.Degrees(+03.76936092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117148",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117148"},
        {"Smithsonian Astrophysical Observation", "SAO 128360"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.24472553),
        dec: Angle.Degrees(+03.77099811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154359"},
        {"Hipparcos Number", "HIP 83579"},
        {"Smithsonian Astrophysical Observation", "SAO 122051"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.22110834),
        dec: Angle.Degrees(+03.77171167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9537"},
        {"Hipparcos Number", "HIP 7281"},
        {"Geneva Identification System", "GEN# +1.00009537"},
        {"Smithsonian Astrophysical Observation", "SAO 109974"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.43940844),
        dec: Angle.Degrees(+03.77215239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146562"},
        {"Hipparcos Number", "HIP 79769"},
        {"Smithsonian Astrophysical Observation", "SAO 121469"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.20753231),
        dec: Angle.Degrees(+03.77285485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80213",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80213"},
        {"Smithsonian Astrophysical Observation", "SAO 121551"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.62147153),
        dec: Angle.Degrees(+03.77303500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39253"},
        {"Hipparcos Number", "HIP 27667"},
        {"Smithsonian Astrophysical Observation", "SAO 113211"},
    },
    visualMagnitude: 8.64,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.86598958),
        dec: Angle.Degrees(+03.77420359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117153",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117153"},
    },
    visualMagnitude: 10.47,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.26343758),
        dec: Angle.Degrees(+03.77493359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 189.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 75.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192874"},
        {"Hipparcos Number", "HIP 99988"},
        {"Smithsonian Astrophysical Observation", "SAO 125645"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.26069963),
        dec: Angle.Degrees(+03.77583729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35538",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5990 AB"},
        {"Henry Draper", "HD 57132"},
        {"Hipparcos Number", "HIP 35538"},
        {"Smithsonian Astrophysical Observation", "SAO 115280"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.01090477),
        dec: Angle.Degrees(+03.77682656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64103",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "NC 35"},
        {"Henry Draper", "HD 114094"},
        {"Hipparcos Number", "HIP 64103"},
        {"Geneva Identification System", "GEN# +1.00114094"},
        {"Wilson Evans Batten Catalogue", "WEB 11331"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.702,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.05548782),
        dec: Angle.Degrees(+03.77695791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -275.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208776"},
        {"Hipparcos Number", "HIP 108473"},
        {"Fundamental Katalog 5th Edition", "FK5 5941"},
        {"Geneva Identification System", "GEN# +1.00208776"},
        {"Smithsonian Astrophysical Observation", "SAO 127201"},
        {"Wilson Evans Batten Catalogue", "WEB 19532"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.61900554),
        dec: Angle.Degrees(+03.77724024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -248.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -133.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37824"},
        {"Hipparcos Number", "HIP 26795"},
        {"Geneva Identification System", "GEN# +1.00037824"},
        {"Smithsonian Astrophysical Observation", "SAO 113040"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.36153444),
        dec: Angle.Degrees(+03.77802427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135928"},
        {"Hipparcos Number", "HIP 74846"},
        {"Smithsonian Astrophysical Observation", "SAO 120934"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.42700788),
        dec: Angle.Degrees(+03.77807506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182766"},
        {"Hipparcos Number", "HIP 95550"},
        {"Geneva Identification System", "GEN# +1.00182766"},
        {"Smithsonian Astrophysical Observation", "SAO 124621"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.52536930),
        dec: Angle.Degrees(+03.77864245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79032"},
        {"Hipparcos Number", "HIP 45124"},
        {"Smithsonian Astrophysical Observation", "SAO 117484"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.90159449),
        dec: Angle.Degrees(+03.77866382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165195"},
        {"Hipparcos Number", "HIP 88527"},
        {"Geneva Identification System", "GEN# +1.00165195"},
        {"Smithsonian Astrophysical Observation", "SAO 123093"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.16703574),
        dec: Angle.Degrees(+03.77929045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176055"},
        {"Hipparcos Number", "HIP 93128"},
        {"Smithsonian Astrophysical Observation", "SAO 124106"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.58341924),
        dec: Angle.Degrees(+03.77979647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170274"},
        {"Hipparcos Number", "HIP 90536"},
        {"Geneva Identification System", "GEN# +1.00170274"},
        {"Smithsonian Astrophysical Observation", "SAO 123529"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.10023173),
        dec: Angle.Degrees(+03.77983978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99905"},
        {"Hipparcos Number", "HIP 56073"},
        {"Smithsonian Astrophysical Observation", "SAO 118891"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.39931839),
        dec: Angle.Degrees(+03.77989785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19170",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19170"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.65107737),
        dec: Angle.Degrees(+03.78098595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 241533"},
        {"Hipparcos Number", "HIP 24208"},
        {"Smithsonian Astrophysical Observation", "SAO 112510"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.96935181),
        dec: Angle.Degrees(+03.78246546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25114"},
        {"Hipparcos Number", "HIP 18645"},
        {"Smithsonian Astrophysical Observation", "SAO 111545"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.86493017),
        dec: Angle.Degrees(+03.78392227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6922",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1178 AB"},
        {"Henry Draper", "HD 9048"},
        {"Hipparcos Number", "HIP 6922"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.28163784),
        dec: Angle.Degrees(+03.78540219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173073"},
        {"Hipparcos Number", "HIP 91838"},
        {"Smithsonian Astrophysical Observation", "SAO 123846"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.86013611),
        dec: Angle.Degrees(+03.78580488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7491",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1260 AB"},
        {"Henry Draper", "HD 9862"},
        {"Hipparcos Number", "HIP 7491"},
        {"Geneva Identification System", "GEN# +1.00009862J"},
        {"Renson", "Renson 2430"},
        {"Smithsonian Astrophysical Observation", "SAO 110007"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.10957143),
        dec: Angle.Degrees(+03.78580950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7448"},
        {"Hipparcos Number", "HIP 5821"},
        {"Smithsonian Astrophysical Observation", "SAO 109752"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.802,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.67184779),
        dec: Angle.Degrees(+03.78658679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67662"},
        {"Hipparcos Number", "HIP 39924"},
        {"Smithsonian Astrophysical Observation", "SAO 116403"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.30352790),
        dec: Angle.Degrees(+03.78789273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3618",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3618"},
    },
    visualMagnitude: 10.74,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.60138400),
        dec: Angle.Degrees(+03.78830509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -171.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218635"},
        {"Hipparcos Number", "HIP 114357"},
        {"Smithsonian Astrophysical Observation", "SAO 128004"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.41209698),
        dec: Angle.Degrees(+03.78847222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32839"},
        {"Hipparcos Number", "HIP 23728"},
        {"Smithsonian Astrophysical Observation", "SAO 112418"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.52184913),
        dec: Angle.Degrees(+03.78849889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171852"},
        {"Hipparcos Number", "HIP 91259"},
        {"Smithsonian Astrophysical Observation", "SAO 123697"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.899,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.22527708),
        dec: Angle.Degrees(+03.78987778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4016"},
        {"Hipparcos Number", "HIP 3357"},
        {"Smithsonian Astrophysical Observation", "SAO 109396"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.68092694),
        dec: Angle.Degrees(+03.79037919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17070",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17070"},
        {"Smithsonian Astrophysical Observation", "SAO 111330"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.87773468),
        dec: Angle.Degrees(+03.79277287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162811"},
        {"Hipparcos Number", "HIP 87511"},
        {"Smithsonian Astrophysical Observation", "SAO 122866"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.19697892),
        dec: Angle.Degrees(+03.79415749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69224"},
        {"Hipparcos Number", "HIP 40500"},
        {"Smithsonian Astrophysical Observation", "SAO 116559"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.03126336),
        dec: Angle.Degrees(+03.79654089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1393"},
        {"Hipparcos Number", "HIP 1455"},
        {"Geneva Identification System", "GEN# +1.00001393"},
        {"Smithsonian Astrophysical Observation", "SAO 109127"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.53293640),
        dec: Angle.Degrees(+03.79675855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187079"},
        {"Hipparcos Number", "HIP 97412"},
        {"Smithsonian Astrophysical Observation", "SAO 125077"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.98067616),
        dec: Angle.Degrees(+03.79701018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183734"},
        {"Hipparcos Number", "HIP 95961"},
        {"Smithsonian Astrophysical Observation", "SAO 124715"},
        {"Wilson Evans Batten Catalogue", "WEB 16804"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.71017475),
        dec: Angle.Degrees(+03.79717536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14774"},
        {"Hipparcos Number", "HIP 11117"},
        {"Smithsonian Astrophysical Observation", "SAO 110504"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.75217301),
        dec: Angle.Degrees(+03.79860745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 109.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191861"},
        {"Hipparcos Number", "HIP 99522"},
        {"Smithsonian Astrophysical Observation", "SAO 125551"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.96915835),
        dec: Angle.Degrees(+03.80153592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200964"},
        {"Hipparcos Number", "HIP 104202"},
        {"Smithsonian Astrophysical Observation", "SAO 126546"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.66577859),
        dec: Angle.Degrees(+03.80299636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95046",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12324 AB"},
        {"Henry Draper", "HD 181416"},
        {"Hipparcos Number", "HIP 95046"},
        {"Smithsonian Astrophysical Observation", "SAO 124519"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.08440173),
        dec: Angle.Degrees(+03.80307338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161941"},
        {"Hipparcos Number", "HIP 87150"},
        {"Geneva Identification System", "GEN# +1.00161941"},
        {"Smithsonian Astrophysical Observation", "SAO 122766"},
        {"Wilson Evans Batten Catalogue", "WEB 14702"},
    },
    visualMagnitude: 6.22,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.08430782),
        dec: Angle.Degrees(+03.80419752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59228"},
        {"Hipparcos Number", "HIP 36361"},
        {"Geneva Identification System", "GEN# +1.00059228"},
        {"Smithsonian Astrophysical Observation", "SAO 115509"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.27047823),
        dec: Angle.Degrees(+03.80527757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8850"},
        {"Hipparcos Number", "HIP 6783"},
        {"Smithsonian Astrophysical Observation", "SAO 109899"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.81931350),
        dec: Angle.Degrees(+03.80551945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143709"},
        {"Hipparcos Number", "HIP 78529"},
        {"Smithsonian Astrophysical Observation", "SAO 121320"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.47592976),
        dec: Angle.Degrees(+03.80832388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3082"},
        {"Hipparcos Number", "HIP 2686"},
        {"Smithsonian Astrophysical Observation", "SAO 109281"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.53130476),
        dec: Angle.Degrees(+03.80890167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19294"},
        {"Hipparcos Number", "HIP 14438"},
        {"Smithsonian Astrophysical Observation", "SAO 110968"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.59389772),
        dec: Angle.Degrees(+03.81011710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217019"},
        {"Hipparcos Number", "HIP 113360"},
        {"Fundamental Katalog 5th Edition", "FK5 3834"},
        {"Geneva Identification System", "GEN# +1.00217019"},
        {"Smithsonian Astrophysical Observation", "SAO 127860"},
        {"Wilson Evans Batten Catalogue", "WEB 20166"},
    },
    visualMagnitude: 6.28,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.38651971),
        dec: Angle.Degrees(+03.81016446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6602"},
        {"Hipparcos Number", "HIP 5230"},
        {"Smithsonian Astrophysical Observation", "SAO 109682"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.72045590),
        dec: Angle.Degrees(+03.81127295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46301"},
        {"Hipparcos Number", "HIP 31197"},
        {"Geneva Identification System", "GEN# +1.00046301"},
        {"Smithsonian Astrophysical Observation", "SAO 114031"},
        {"Wilson Evans Batten Catalogue", "WEB 6231"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.17790627),
        dec: Angle.Degrees(+03.81452948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85705",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10603 AB"},
        {"Henry Draper", "HD 158735"},
        {"Hipparcos Number", "HIP 85705"},
        {"Smithsonian Astrophysical Observation", "SAO 122454"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.71153152),
        dec: Angle.Degrees(+03.81632305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17726"},
        {"Hipparcos Number", "HIP 13278"},
        {"Smithsonian Astrophysical Observation", "SAO 110783"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.72357146),
        dec: Angle.Degrees(+03.81684820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5094"},
        {"Hipparcos Number", "HIP 4123"},
        {"Smithsonian Astrophysical Observation", "SAO 109519"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.21036912),
        dec: Angle.Degrees(+03.81766566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111484"},
        {"Hipparcos Number", "HIP 62596"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.39527984),
        dec: Angle.Degrees(+03.81822048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204864"},
        {"Hipparcos Number", "HIP 106258"},
        {"Smithsonian Astrophysical Observation", "SAO 126862"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.82881931),
        dec: Angle.Degrees(+03.81836834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110605",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15905 AB"},
        {"Henry Draper", "HD 212472"},
        {"Hipparcos Number", "HIP 110605"},
        {"Smithsonian Astrophysical Observation", "SAO 127509"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.11444667),
        dec: Angle.Degrees(+03.81843154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113889",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Fumalsamakah"},
        {"Henry Draper", "HD 217891"},
        {"Hipparcos Number", "HIP 113889"},
        {"Fundamental Katalog 5th Edition", "FK5 1602"},
        {"Geneva Identification System", "GEN# +1.00217891"},
        {"Smithsonian Astrophysical Observation", "SAO 127934"},
        {"Wilson Evans Batten Catalogue", "WEB 20230"},
    },
    visualMagnitude: 4.48,
    bvColour: -0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.96919380),
        dec: Angle.Degrees(+03.82006998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14992",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14992"},
        {"Geneva Identification System", "GEN# +0.00300443"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.30606354),
        dec: Angle.Degrees(+03.82165617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 273.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -225.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79320"},
        {"Hipparcos Number", "HIP 45257"},
        {"Smithsonian Astrophysical Observation", "SAO 117510"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.35338456),
        dec: Angle.Degrees(+03.82458853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35133"},
        {"Hipparcos Number", "HIP 25139"},
        {"Smithsonian Astrophysical Observation", "SAO 112694"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.69734741),
        dec: Angle.Degrees(+03.82490404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2235"},
        {"Hipparcos Number", "HIP 2080"},
        {"Geneva Identification System", "GEN# +1.00002235"},
        {"Smithsonian Astrophysical Observation", "SAO 109206"},
    },
    visualMagnitude: 6.90,
    bvColour: -0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.56869008),
        dec: Angle.Degrees(+03.82575470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27093",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4329 A"},
        {"Henry Draper", "HD 38270"},
        {"Hipparcos Number", "HIP 27093"},
        {"Smithsonian Astrophysical Observation", "SAO 113093"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.18107525),
        dec: Angle.Degrees(+03.83142632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76835",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76835"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.31616380),
        dec: Angle.Degrees(+03.83547251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46323",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46323"},
    },
    visualMagnitude: 10.63,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.67606207),
        dec: Angle.Degrees(+03.83572879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -172.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20956",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20956"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.758,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.39827307),
        dec: Angle.Degrees(+03.83864888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25606"},
        {"Hipparcos Number", "HIP 18983"},
        {"Smithsonian Astrophysical Observation", "SAO 111589"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.00855562),
        dec: Angle.Degrees(+03.84066968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64109"},
        {"Hipparcos Number", "HIP 38434"},
        {"Geneva Identification System", "GEN# +1.00064109"},
        {"Smithsonian Astrophysical Observation", "SAO 116059"},
    },
    visualMagnitude: 7.99,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.09432545),
        dec: Angle.Degrees(+03.84315679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120201"},
        {"Hipparcos Number", "HIP 67317"},
        {"Geneva Identification System", "GEN# +1.00120201"},
        {"Smithsonian Astrophysical Observation", "SAO 120117"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.97907439),
        dec: Angle.Degrees(+03.84651207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25412"},
        {"Hipparcos Number", "HIP 18850"},
        {"Smithsonian Astrophysical Observation", "SAO 111573"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.62173305),
        dec: Angle.Degrees(+03.84724773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9546",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9546"},
        {"Fundamental Katalog 5th Edition", "FK5 4186"},
        {"Smithsonian Astrophysical Observation", "SAO 110298"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.67246473),
        dec: Angle.Degrees(+03.84736037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90554"},
        {"Hipparcos Number", "HIP 51190"},
        {"Smithsonian Astrophysical Observation", "SAO 118313"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.85057784),
        dec: Angle.Degrees(+03.84861415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151269"},
        {"Hipparcos Number", "HIP 82108"},
        {"Geneva Identification System", "GEN# +1.00151269"},
        {"Smithsonian Astrophysical Observation", "SAO 121847"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.57424587),
        dec: Angle.Degrees(+03.84945561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101608"},
        {"Hipparcos Number", "HIP 57028"},
        {"Smithsonian Astrophysical Observation", "SAO 118994"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.38939102),
        dec: Angle.Degrees(+03.85050883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174643"},
        {"Hipparcos Number", "HIP 92533"},
        {"Smithsonian Astrophysical Observation", "SAO 123976"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.85434925),
        dec: Angle.Degrees(+03.85115866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13859"},
        {"Hipparcos Number", "HIP 10480"},
        {"Smithsonian Astrophysical Observation", "SAO 110427"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.78246617),
        dec: Angle.Degrees(+03.85144669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12533",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12533"},
        {"Smithsonian Astrophysical Observation", "SAO 110685"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.31078731),
        dec: Angle.Degrees(+03.85422759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212335"},
        {"Hipparcos Number", "HIP 110527"},
        {"Geneva Identification System", "GEN# +1.00212335"},
        {"Smithsonian Astrophysical Observation", "SAO 127497"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.87450871),
        dec: Angle.Degrees(+03.85489354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35762"},
        {"Hipparcos Number", "HIP 25493"},
        {"Celescope Catalog", "CEL 710"},
        {"Geneva Identification System", "GEN# +1.00035762"},
        {"Smithsonian Astrophysical Observation", "SAO 112781"},
        {"Wilson Evans Batten Catalogue", "WEB 4943"},
    },
    visualMagnitude: 6.74,
    bvColour: -0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.78459486),
        dec: Angle.Degrees(+03.85554923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102761"},
        {"Hipparcos Number", "HIP 57694"},
        {"Smithsonian Astrophysical Observation", "SAO 119072"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.48561130),
        dec: Angle.Degrees(+03.85591095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35638"},
        {"Hipparcos Number", "HIP 25435"},
        {"Geneva Identification System", "GEN# +1.00035638"},
        {"Smithsonian Astrophysical Observation", "SAO 112761"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.59598486),
        dec: Angle.Degrees(+03.85650607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20790"},
        {"Hipparcos Number", "HIP 15628"},
        {"Geneva Identification System", "GEN# +1.00020790"},
        {"Smithsonian Astrophysical Observation", "SAO 111144"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.30834428),
        dec: Angle.Degrees(+03.85690286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92536",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 9.90,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)51, 26.7700),
        dec: Angle.DegreesMinutesSeconds((int)+03, (int)51, 26.300)
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
    primaryId: "HIP 44703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78113"},
        {"Hipparcos Number", "HIP 44703"},
        {"Smithsonian Astrophysical Observation", "SAO 117426"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.63417216),
        dec: Angle.Degrees(+03.85993036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99329"},
        {"Hipparcos Number", "HIP 55791"},
        {"Geneva Identification System", "GEN# +1.00099329"},
        {"Smithsonian Astrophysical Observation", "SAO 118851"},
        {"Wilson Evans Batten Catalogue", "WEB 10026"},
    },
    visualMagnitude: 6.35,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.45876249),
        dec: Angle.Degrees(+03.86019417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 224",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 224"},
        {"Smithsonian Astrophysical Observation", "SAO 108984"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.69625192),
        dec: Angle.Degrees(+03.86040514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33315"},
        {"Hipparcos Number", "HIP 23997"},
        {"Smithsonian Astrophysical Observation", "SAO 112472"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.38123385),
        dec: Angle.Degrees(+03.86071185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2855"},
        {"Hipparcos Number", "HIP 2521"},
        {"Smithsonian Astrophysical Observation", "SAO 109257"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.98898559),
        dec: Angle.Degrees(+03.86240628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41165"},
        {"Hipparcos Number", "HIP 28689"},
        {"Smithsonian Astrophysical Observation", "SAO 113406"},
        {"Wilson Evans Batten Catalogue", "WEB 5611"},
    },
    visualMagnitude: 7.10,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.85867561),
        dec: Angle.Degrees(+03.86261794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55852",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55852"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.70501189),
        dec: Angle.Degrees(+03.86449153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15872",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15872"},
        {"Smithsonian Astrophysical Observation", "SAO 111168"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.11253071),
        dec: Angle.Degrees(+03.86464186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134370"},
        {"Hipparcos Number", "HIP 74182"},
        {"Geneva Identification System", "GEN# +1.00134370"},
        {"Smithsonian Astrophysical Observation", "SAO 120870"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.36673751),
        dec: Angle.Degrees(+03.86585851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39987"},
        {"Hipparcos Number", "HIP 28087"},
        {"Geneva Identification System", "GEN# +1.00039987"},
        {"Smithsonian Astrophysical Observation", "SAO 113279"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.06029831),
        dec: Angle.Degrees(+03.86696381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79108"},
        {"Hipparcos Number", "HIP 45167"},
        {"Geneva Identification System", "GEN# +1.00079108"},
        {"Smithsonian Astrophysical Observation", "SAO 117492"},
        {"Wilson Evans Batten Catalogue", "WEB 8615"},
    },
    visualMagnitude: 6.14,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.05379452),
        dec: Angle.Degrees(+03.86698952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69393",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9153 AB"},
        {"Henry Draper", "HD 124259"},
        {"Hipparcos Number", "HIP 69393"},
        {"Smithsonian Astrophysical Observation", "SAO 120341"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.09062042),
        dec: Angle.Degrees(+03.86723904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3073",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3073"},
    },
    visualMagnitude: 10.79,
    bvColour: 0.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.74773404),
        dec: Angle.Degrees(+03.86727689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107069"},
        {"Hipparcos Number", "HIP 60037"},
        {"Smithsonian Astrophysical Observation", "SAO 119321"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.68133619),
        dec: Angle.Degrees(+03.86774267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110261"},
        {"Hipparcos Number", "HIP 61881"},
        {"Geneva Identification System", "GEN# +1.00110261"},
        {"Smithsonian Astrophysical Observation", "SAO 119529"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.20818550),
        dec: Angle.Degrees(+03.86977421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130744"},
        {"Hipparcos Number", "HIP 72529"},
        {"Smithsonian Astrophysical Observation", "SAO 120682"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.43458993),
        dec: Angle.Degrees(+03.87083095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117285"},
        {"Hipparcos Number", "HIP 65791"},
        {"Smithsonian Astrophysical Observation", "SAO 119951"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.30677712),
        dec: Angle.Degrees(+03.87143208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42406"},
        {"Hipparcos Number", "HIP 29298"},
        {"Smithsonian Astrophysical Observation", "SAO 113544"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.65309696),
        dec: Angle.Degrees(+03.87172195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 242703"},
        {"Hipparcos Number", "HIP 24846"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.89551443),
        dec: Angle.Degrees(+03.87389443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65660",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65660"},
        {"Renson", "Renson 33790"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.93660524),
        dec: Angle.Degrees(+03.87407283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21925"},
        {"Hipparcos Number", "HIP 16479"},
        {"Smithsonian Astrophysical Observation", "SAO 111242"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.05005751),
        dec: Angle.Degrees(+03.87705181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8876"},
        {"Hipparcos Number", "HIP 6805"},
        {"Smithsonian Astrophysical Observation", "SAO 109904"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.89440448),
        dec: Angle.Degrees(+03.87770457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153324"},
        {"Hipparcos Number", "HIP 83093"},
        {"Smithsonian Astrophysical Observation", "SAO 121972"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.68605612),
        dec: Angle.Degrees(+03.88004201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47282",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47282"},
        {"Geneva Identification System", "GEN# +9.80048024"},
    },
    visualMagnitude: 11.95,
    bvColour: 1.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.53172173),
        dec: Angle.Degrees(+03.88388473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -134.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -189.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215257"},
        {"Hipparcos Number", "HIP 112229"},
        {"Cincinnati Publication", "Ci 18 2960"},
        {"Geneva Identification System", "GEN# +1.00215257"},
        {"Smithsonian Astrophysical Observation", "SAO 127714"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.96095790),
        dec: Angle.Degrees(+03.88603384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 150.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 331.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2212"},
        {"Hipparcos Number", "HIP 2052"},
        {"Smithsonian Astrophysical Observation", "SAO 109202"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.50760582),
        dec: Angle.Degrees(+03.88822133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12848",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12848"},
    },
    visualMagnitude: 10.83,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.29747870),
        dec: Angle.Degrees(+03.88974017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73373",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73373"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.91555684),
        dec: Angle.Degrees(+03.89129816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69952",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9215 AB"},
        {"Henry Draper", "HD 125377"},
        {"Hipparcos Number", "HIP 69952"},
        {"Smithsonian Astrophysical Observation", "SAO 120392"},
        {"Wilson Evans Batten Catalogue", "WEB 12164"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.71966640),
        dec: Angle.Degrees(+03.89249664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85569"},
        {"Hipparcos Number", "HIP 48459"},
        {"Smithsonian Astrophysical Observation", "SAO 117965"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.21161962),
        dec: Angle.Degrees(+03.89337664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90863"},
        {"Hipparcos Number", "HIP 51370"},
        {"Smithsonian Astrophysical Observation", "SAO 118332"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.38130236),
        dec: Angle.Degrees(+03.89556058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51645"},
        {"Hipparcos Number", "HIP 33545"},
        {"Smithsonian Astrophysical Observation", "SAO 114701"},
        {"Wilson Evans Batten Catalogue", "WEB 6745"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.57301302),
        dec: Angle.Degrees(+03.89580223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206262"},
        {"Hipparcos Number", "HIP 107046"},
        {"Smithsonian Astrophysical Observation", "SAO 126985"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.20095974),
        dec: Angle.Degrees(+03.89690219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120936"},
        {"Hipparcos Number", "HIP 67721"},
        {"Smithsonian Astrophysical Observation", "SAO 120144"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.09564662),
        dec: Angle.Degrees(+03.89770367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121391"},
        {"Hipparcos Number", "HIP 67955"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.74681572),
        dec: Angle.Degrees(+03.89791402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51072",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7773 BC"},
        {"Hipparcos Number", "HIP 51072"},
        {"Smithsonian Astrophysical Observation", "SAO 118298"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.53227723),
        dec: Angle.Degrees(+03.90072708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26691"},
        {"Hipparcos Number", "HIP 19714"},
        {"Smithsonian Astrophysical Observation", "SAO 111670"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.754,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.35171355),
        dec: Angle.Degrees(+03.90221640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43047"},
        {"Hipparcos Number", "HIP 29594"},
        {"Celescope Catalog", "CEL 1132"},
        {"Geneva Identification System", "GEN# +1.00043047"},
        {"Smithsonian Astrophysical Observation", "SAO 113615"},
    },
    visualMagnitude: 7.32,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.55238994),
        dec: Angle.Degrees(+03.90227415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9854",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9854"},
        {"Smithsonian Astrophysical Observation", "SAO 110343"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.718,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.69404111),
        dec: Angle.Degrees(+03.90411123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47058",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7444 A"},
        {"Henry Draper", "HD 82994"},
        {"Hipparcos Number", "HIP 47058"},
        {"Geneva Identification System", "GEN# +1.00082994"},
        {"Smithsonian Astrophysical Observation", "SAO 117792"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.85525162),
        dec: Angle.Degrees(+03.90538103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149413"},
        {"Hipparcos Number", "HIP 81152"},
        {"Smithsonian Astrophysical Observation", "SAO 121702"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.61773222),
        dec: Angle.Degrees(+03.90618868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5848",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5848"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.75548735),
        dec: Angle.Degrees(+03.90618889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225127"},
        {"Hipparcos Number", "HIP 294"},
        {"Fundamental Katalog 5th Edition", "FK5 4007"},
        {"Geneva Identification System", "GEN# +1.00225127"},
        {"Smithsonian Astrophysical Observation", "SAO 108992"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.91715645),
        dec: Angle.Degrees(+03.90700467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72450",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72450"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.23136636),
        dec: Angle.Degrees(+03.90810605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70209",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70209"},
        {"Wilson Evans Batten Catalogue", "WEB 12191"},
    },
    visualMagnitude: 11.16,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.46472839),
        dec: Angle.Degrees(+03.90941206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202657"},
        {"Hipparcos Number", "HIP 105077"},
        {"Smithsonian Astrophysical Observation", "SAO 126679"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.30047788),
        dec: Angle.Degrees(+03.91212921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16346",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16346"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.66072515),
        dec: Angle.Degrees(+03.91634406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76039"},
        {"Hipparcos Number", "HIP 43668"},
        {"Smithsonian Astrophysical Observation", "SAO 117239"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.44822705),
        dec: Angle.Degrees(+03.91642594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8329",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8329"},
        {"Smithsonian Astrophysical Observation", "SAO 110127"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.84215440),
        dec: Angle.Degrees(+03.91725335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133394"},
        {"Hipparcos Number", "HIP 73709"},
        {"Geneva Identification System", "GEN# +1.00133394"},
        {"Smithsonian Astrophysical Observation", "SAO 120820"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.00309570),
        dec: Angle.Degrees(+03.91810490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42827",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42827"},
        {"Smithsonian Astrophysical Observation", "SAO 117056"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.89626605),
        dec: Angle.Degrees(+03.91931772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138760"},
        {"Hipparcos Number", "HIP 76212"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.52471074),
        dec: Angle.Degrees(+03.91933504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201687"},
        {"Hipparcos Number", "HIP 104577"},
        {"Smithsonian Astrophysical Observation", "SAO 126600"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.76296663),
        dec: Angle.Degrees(+03.91961077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77212"},
        {"Hipparcos Number", "HIP 44287"},
        {"Smithsonian Astrophysical Observation", "SAO 117346"},
    },
    visualMagnitude: 9.75,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.29256012),
        dec: Angle.Degrees(+03.92497378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2192"},
        {"Hipparcos Number", "HIP 2046"},
        {"Smithsonian Astrophysical Observation", "SAO 109199"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.48565741),
        dec: Angle.Degrees(+03.92527395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163862"},
        {"Hipparcos Number", "HIP 87974"},
        {"Smithsonian Astrophysical Observation", "SAO 122969"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.56562359),
        dec: Angle.Degrees(+03.92850827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9156",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9156"},
    },
    visualMagnitude: 10.78,
    bvColour: 1.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.48353959),
        dec: Angle.Degrees(+03.93063128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -114.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134169"},
        {"Hipparcos Number", "HIP 74079"},
        {"Geneva Identification System", "GEN# +1.00134169"},
        {"Smithsonian Astrophysical Observation", "SAO 120858"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.07523987),
        dec: Angle.Degrees(+03.93063198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117965"},
        {"Hipparcos Number", "HIP 66173"},
        {"Geneva Identification System", "GEN# +1.00117965"},
        {"Smithsonian Astrophysical Observation", "SAO 119999"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.45739063),
        dec: Angle.Degrees(+03.93069085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86987"},
        {"Hipparcos Number", "HIP 49180"},
        {"Smithsonian Astrophysical Observation", "SAO 118063"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.56413497),
        dec: Angle.Degrees(+03.93084752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60501",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60501"},
        {"Wilson Evans Batten Catalogue", "WEB 10760"},
    },
    visualMagnitude: 10.70,
    bvColour: 1.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.04994791),
        dec: Angle.Degrees(+03.93097120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -132.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155121"},
        {"Hipparcos Number", "HIP 83948"},
        {"Geneva Identification System", "GEN# +1.00155121"},
        {"Smithsonian Astrophysical Observation", "SAO 122134"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.819,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.39081171),
        dec: Angle.Degrees(+03.93244254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51075",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7773 A"},
        {"Henry Draper", "HD 90386"},
        {"Hipparcos Number", "HIP 51075"},
        {"Smithsonian Astrophysical Observation", "SAO 118299"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.53833753),
        dec: Angle.Degrees(+03.93253256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48434"},
        {"Hipparcos Number", "HIP 32226"},
        {"Geneva Identification System", "GEN# +1.00048434"},
        {"Smithsonian Astrophysical Observation", "SAO 114324"},
        {"Wilson Evans Batten Catalogue", "WEB 6496"},
    },
    visualMagnitude: 5.88,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.91102453),
        dec: Angle.Degrees(+03.93253483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52869",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52869"},
        {"Smithsonian Astrophysical Observation", "SAO 118510"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.17644081),
        dec: Angle.Degrees(+03.93260251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47483"},
        {"Hipparcos Number", "HIP 31812"},
        {"Geneva Identification System", "GEN# +1.00047483"},
        {"Renson", "Renson 12730"},
        {"Smithsonian Astrophysical Observation", "SAO 114203"},
        {"Wilson Evans Batten Catalogue", "WEB 6390"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.76681512),
        dec: Angle.Degrees(+03.93496031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114000"},
        {"Hipparcos Number", "HIP 64041"},
        {"Geneva Identification System", "GEN# +1.00114000"},
        {"Smithsonian Astrophysical Observation", "SAO 119776"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.87665127),
        dec: Angle.Degrees(+03.93723077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98698"},
        {"Hipparcos Number", "HIP 55460"},
        {"Smithsonian Astrophysical Observation", "SAO 118807"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.37196594),
        dec: Angle.Degrees(+03.93744299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129392"},
        {"Hipparcos Number", "HIP 71886"},
        {"Smithsonian Astrophysical Observation", "SAO 120608"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.54673268),
        dec: Angle.Degrees(+03.93866297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72736",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72736"},
        {"Smithsonian Astrophysical Observation", "SAO 120704"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.06039120),
        dec: Angle.Degrees(+03.93879385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86065",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10643 AB"},
        {"Henry Draper", "HD 159562"},
        {"Hipparcos Number", "HIP 86065"},
        {"Smithsonian Astrophysical Observation", "SAO 122538"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.83441818),
        dec: Angle.Degrees(+03.93946715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9488",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9488"},
        {"Cincinnati Publication", "Ci 20 140"},
        {"Wilson Evans Batten Catalogue", "WEB 1993"},
    },
    visualMagnitude: 10.48,
    bvColour: 1.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.51404598),
        dec: Angle.Degrees(+03.94109509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -338.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -325.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100762"},
        {"Hipparcos Number", "HIP 56569"},
        {"Smithsonian Astrophysical Observation", "SAO 118937"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.95558908),
        dec: Angle.Degrees(+03.94324881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56794"},
        {"Hipparcos Number", "HIP 35400"},
        {"Smithsonian Astrophysical Observation", "SAO 115235"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.65284435),
        dec: Angle.Degrees(+03.94640125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6"},
    },
    visualMagnitude: 12.31,
    bvColour: 1.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.01814144),
        dec: Angle.Degrees(+03.94648893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 226.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113813"},
        {"Hipparcos Number", "HIP 63939"},
        {"Smithsonian Astrophysical Observation", "SAO 119762"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.55850690),
        dec: Angle.Degrees(+03.94667099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187645"},
        {"Hipparcos Number", "HIP 97668"},
        {"Geneva Identification System", "GEN# +1.00187645"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.73220710),
        dec: Angle.Degrees(+03.94701438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 219.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126441"},
        {"Hipparcos Number", "HIP 70504"},
        {"Geneva Identification System", "GEN# +1.00126441"},
        {"Smithsonian Astrophysical Observation", "SAO 120446"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.33721050),
        dec: Angle.Degrees(+03.94803675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70013"},
        {"Hipparcos Number", "HIP 40818"},
        {"Geneva Identification System", "GEN# +1.00070013J"},
        {"Smithsonian Astrophysical Observation", "SAO 116630"},
        {"Wilson Evans Batten Catalogue", "WEB 7919"},
    },
    visualMagnitude: 6.04,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.95770100),
        dec: Angle.Degrees(+03.94808579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80733"},
        {"Hipparcos Number", "HIP 45900"},
        {"Smithsonian Astrophysical Observation", "SAO 117617"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.37118342),
        dec: Angle.Degrees(+03.94832805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53566"},
        {"Hipparcos Number", "HIP 34214"},
        {"Geneva Identification System", "GEN# +1.00053566"},
        {"Smithsonian Astrophysical Observation", "SAO 114900"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.40959917),
        dec: Angle.Degrees(+03.94941129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91886"},
        {"Hipparcos Number", "HIP 51941"},
        {"Smithsonian Astrophysical Observation", "SAO 118395"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.17144405),
        dec: Angle.Degrees(+03.94980665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 246067"},
        {"Hipparcos Number", "HIP 26617"},
        {"Geneva Identification System", "GEN# +1.00246067"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.86369143),
        dec: Angle.Degrees(+03.95133420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 255.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -243.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98068"},
        {"Hipparcos Number", "HIP 55102"},
        {"Smithsonian Astrophysical Observation", "SAO 118762"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.22491322),
        dec: Angle.Degrees(+03.95381365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199024"},
        {"Hipparcos Number", "HIP 103171"},
        {"Smithsonian Astrophysical Observation", "SAO 126350"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.53127274),
        dec: Angle.Degrees(+03.95455971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26885"},
        {"Hipparcos Number", "HIP 19831"},
        {"Smithsonian Astrophysical Observation", "SAO 111692"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.78563008),
        dec: Angle.Degrees(+03.95743160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42205",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42205"},
        {"Smithsonian Astrophysical Observation", "SAO 116938"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.08499005),
        dec: Angle.Degrees(+03.95751394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29713",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4863 A"},
        {"Henry Draper", "HD 43286"},
        {"Hipparcos Number", "HIP 29713"},
        {"Celescope Catalog", "CEL 1144"},
        {"Geneva Identification System", "GEN# +1.00043286A"},
        {"Smithsonian Astrophysical Observation", "SAO 113645"},
        {"Wilson Evans Batten Catalogue", "WEB 5855"},
    },
    visualMagnitude: 7.02,
    bvColour: -0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.87602423),
        dec: Angle.Degrees(+03.95820413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78536"},
        {"Hipparcos Number", "HIP 44906"},
        {"Smithsonian Astrophysical Observation", "SAO 117454"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.22463744),
        dec: Angle.Degrees(+03.95917431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14937",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14937"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.15144582),
        dec: Angle.Degrees(+03.96107080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124550"},
        {"Hipparcos Number", "HIP 69544"},
        {"Smithsonian Astrophysical Observation", "SAO 120356"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.54581707),
        dec: Angle.Degrees(+03.96302423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115274"},
        {"Hipparcos Number", "HIP 64733"},
        {"Geneva Identification System", "GEN# +1.00115274"},
        {"Smithsonian Astrophysical Observation", "SAO 119841"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.01633309),
        dec: Angle.Degrees(+03.96417267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170247"},
        {"Hipparcos Number", "HIP 90528"},
        {"Geneva Identification System", "GEN# +1.00170247"},
        {"Smithsonian Astrophysical Observation", "SAO 123525"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.08380925),
        dec: Angle.Degrees(+03.96581420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32516",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32516"},
    },
    visualMagnitude: 10.68,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.78916654),
        dec: Angle.Degrees(+03.96709528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86148"},
        {"Hipparcos Number", "HIP 48772"},
        {"Smithsonian Astrophysical Observation", "SAO 118007"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.20797051),
        dec: Angle.Degrees(+03.96792798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38724"},
        {"Hipparcos Number", "HIP 27385"},
        {"Renson", "Renson 10420"},
        {"Smithsonian Astrophysical Observation", "SAO 113151"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.99774711),
        dec: Angle.Degrees(+03.96853879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46748"},
        {"Hipparcos Number", "HIP 31443"},
        {"Geneva Identification System", "GEN# +1.00046748"},
        {"Smithsonian Astrophysical Observation", "SAO 114094"},
        {"Wilson Evans Batten Catalogue", "WEB 6292"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.81392189),
        dec: Angle.Degrees(+03.96889235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106267"},
        {"Hipparcos Number", "HIP 59627"},
        {"Geneva Identification System", "GEN# +1.00106267"},
        {"Smithsonian Astrophysical Observation", "SAO 119274"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.41044377),
        dec: Angle.Degrees(+03.97163176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87213"},
        {"Hipparcos Number", "HIP 49288"},
        {"Smithsonian Astrophysical Observation", "SAO 118081"},
        {"Wilson Evans Batten Catalogue", "WEB 9118"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.904,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.91182728),
        dec: Angle.Degrees(+03.97188013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154797"},
        {"Hipparcos Number", "HIP 83796"},
        {"Geneva Identification System", "GEN# +1.00154797"},
        {"Smithsonian Astrophysical Observation", "SAO 122102"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.87800714),
        dec: Angle.Degrees(+03.97314876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107515",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107515"},
    },
    visualMagnitude: 10.06,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.62971437),
        dec: Angle.Degrees(+03.97326059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209642"},
        {"Hipparcos Number", "HIP 108998"},
        {"Smithsonian Astrophysical Observation", "SAO 127271"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.21655874),
        dec: Angle.Degrees(+03.97489244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55915",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55915"},
        {"Geneva Identification System", "GEN# +0.00402470"},
    },
    visualMagnitude: 10.65,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.91091146),
        dec: Angle.Degrees(+03.97661615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66845",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66845"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.49010372),
        dec: Angle.Degrees(+03.97900735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200565"},
        {"Hipparcos Number", "HIP 103983"},
        {"Geneva Identification System", "GEN# +1.00200565"},
        {"Smithsonian Astrophysical Observation", "SAO 126508"},
        {"Wilson Evans Batten Catalogue", "WEB 18939"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.02390023),
        dec: Angle.Degrees(+03.98105702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -155.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66582",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66582"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.73301931),
        dec: Angle.Degrees(+03.98115790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34581"},
        {"Hipparcos Number", "HIP 24774"},
        {"Smithsonian Astrophysical Observation", "SAO 112618"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.67223536),
        dec: Angle.Degrees(+03.98155995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193518"},
        {"Hipparcos Number", "HIP 100285"},
        {"Geneva Identification System", "GEN# +1.00193518"},
        {"Smithsonian Astrophysical Observation", "SAO 125693"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.11056721),
        dec: Angle.Degrees(+03.98369131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115964",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115964"},
    },
    visualMagnitude: 11.24,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.41940333),
        dec: Angle.Degrees(+03.98418736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43776"},
        {"Hipparcos Number", "HIP 29948"},
        {"Smithsonian Astrophysical Observation", "SAO 113704"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.57006349),
        dec: Angle.Degrees(+03.98453438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133727"},
        {"Hipparcos Number", "HIP 73874"},
        {"Geneva Identification System", "GEN# +1.00133727"},
        {"Smithsonian Astrophysical Observation", "SAO 120833"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.47753633),
        dec: Angle.Degrees(+03.98749684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60620"},
        {"Hipparcos Number", "HIP 36933"},
        {"Smithsonian Astrophysical Observation", "SAO 115670"},
    },
    visualMagnitude: 7.42,
    bvColour: -0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.88827941),
        dec: Angle.Degrees(+03.98759230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194389"},
        {"Hipparcos Number", "HIP 100721"},
        {"Smithsonian Astrophysical Observation", "SAO 125784"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.30492441),
        dec: Angle.Degrees(+03.98896235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 116.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40573"},
        {"Hipparcos Number", "HIP 28398"},
        {"Smithsonian Astrophysical Observation", "SAO 113337"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.97333309),
        dec: Angle.Degrees(+03.99100837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189284"},
        {"Hipparcos Number", "HIP 98374"},
        {"Smithsonian Astrophysical Observation", "SAO 125305"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.79394016),
        dec: Angle.Degrees(+03.99251769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77693",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77693"},
        {"Smithsonian Astrophysical Observation", "SAO 121224"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.93605304),
        dec: Angle.Degrees(+03.99293476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88964",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11111 AB"},
        {"Henry Draper", "HD 166233"},
        {"Hipparcos Number", "HIP 88964"},
        {"Geneva Identification System", "GEN# +1.00166233J"},
        {"Smithsonian Astrophysical Observation", "SAO 123187"},
        {"Wilson Evans Batten Catalogue", "WEB 15089"},
    },
    visualMagnitude: 5.71,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.39110031),
        dec: Angle.Degrees(+03.99328654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188442"},
        {"Hipparcos Number", "HIP 98015"},
        {"Smithsonian Astrophysical Observation", "SAO 125232"},
        {"Wilson Evans Batten Catalogue", "WEB 17259"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.77451801),
        dec: Angle.Degrees(+03.99563848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14352",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14352"},
        {"Smithsonian Astrophysical Observation", "SAO 110949"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.27148322),
        dec: Angle.Degrees(+03.99723076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101615",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101615"},
        {"Smithsonian Astrophysical Observation", "SAO 125998"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.91114453),
        dec: Angle.Degrees(+03.99764301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 260830"},
        {"Hipparcos Number", "HIP 31641"},
        {"Wilson Evans Batten Catalogue", "WEB 6337"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.31591378),
        dec: Angle.Degrees(+03.99816238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132008"},
        {"Hipparcos Number", "HIP 73143"},
        {"Smithsonian Astrophysical Observation", "SAO 120753"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.22279335),
        dec: Angle.Degrees(+04.00033983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38145"},
        {"Hipparcos Number", "HIP 27004"},
        {"Geneva Identification System", "GEN# +1.00038145"},
        {"Smithsonian Astrophysical Observation", "SAO 113083"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.92595491),
        dec: Angle.Degrees(+04.00426150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67392"},
        {"Hipparcos Number", "HIP 39786"},
        {"Smithsonian Astrophysical Observation", "SAO 116376"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.95746789),
        dec: Angle.Degrees(+04.00596972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125505"},
        {"Hipparcos Number", "HIP 70025"},
        {"Smithsonian Astrophysical Observation", "SAO 120403"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.93455166),
        dec: Angle.Degrees(+04.00623577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27118",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4333 A"},
        {"Henry Draper", "HD 38309"},
        {"Hipparcos Number", "HIP 27118"},
        {"Geneva Identification System", "GEN# +1.00038309"},
        {"Smithsonian Astrophysical Observation", "SAO 113099"},
        {"Wilson Evans Batten Catalogue", "WEB 5337"},
    },
    visualMagnitude: 6.09,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.25749324),
        dec: Angle.Degrees(+04.00819399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74314",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74314"},
    },
    visualMagnitude: 10.95,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.84010859),
        dec: Angle.Degrees(+04.00872654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26924"},
        {"Hipparcos Number", "HIP 19857"},
        {"Smithsonian Astrophysical Observation", "SAO 111697"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.86277664),
        dec: Angle.Degrees(+04.00938156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208530"},
        {"Hipparcos Number", "HIP 108321"},
        {"Smithsonian Astrophysical Observation", "SAO 127180"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.17152796),
        dec: Angle.Degrees(+04.01073495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215861"},
        {"Hipparcos Number", "HIP 112577"},
        {"Smithsonian Astrophysical Observation", "SAO 127769"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.02473822),
        dec: Angle.Degrees(+04.01118571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81325"},
        {"Hipparcos Number", "HIP 46183"},
        {"Geneva Identification System", "GEN# +1.00081325"},
        {"Smithsonian Astrophysical Observation", "SAO 117674"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.25226842),
        dec: Angle.Degrees(+04.01131801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34959"},
        {"Hipparcos Number", "HIP 25011"},
        {"Celescope Catalog", "CEL 641"},
        {"Geneva Identification System", "GEN# +1.00034959"},
        {"Renson", "Renson 8930"},
        {"Smithsonian Astrophysical Observation", "SAO 112660"},
        {"Wilson Evans Batten Catalogue", "WEB 4844"},
    },
    visualMagnitude: 6.49,
    bvColour: -0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.33044910),
        dec: Angle.Degrees(+04.01197792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189413"},
        {"Hipparcos Number", "HIP 98417"},
        {"Smithsonian Astrophysical Observation", "SAO 125319"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.94937569),
        dec: Angle.Degrees(+04.01205034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32431"},
        {"Hipparcos Number", "HIP 23508"},
        {"Smithsonian Astrophysical Observation", "SAO 112364"},
    },
    visualMagnitude: 8.10,
    bvColour: -0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.82125777),
        dec: Angle.Degrees(+04.01554760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69196",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9134 AB"},
        {"Henry Draper", "HD 123861"},
        {"Hipparcos Number", "HIP 69196"},
        {"Smithsonian Astrophysical Observation", "SAO 120319"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.48852340),
        dec: Angle.Degrees(+04.01577878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165628"},
        {"Hipparcos Number", "HIP 88729"},
        {"Smithsonian Astrophysical Observation", "SAO 123129"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.71193906),
        dec: Angle.Degrees(+04.01786051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9410",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9410"},
        {"Cincinnati Publication", "Ci 20 138"},
        {"Geneva Identification System", "GEN# +9.80071048"},
    },
    visualMagnitude: 11.57,
    bvColour: 0.731,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.22343529),
        dec: Angle.Degrees(+04.01913678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -412.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150906"},
        {"Hipparcos Number", "HIP 81913"},
        {"Smithsonian Astrophysical Observation", "SAO 121819"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.97369674),
        dec: Angle.Degrees(+04.01942149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85856"},
        {"Hipparcos Number", "HIP 48609"},
        {"Smithsonian Astrophysical Observation", "SAO 117985"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.69796591),
        dec: Angle.Degrees(+04.02302648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53203"},
        {"Hipparcos Number", "HIP 34106"},
        {"Geneva Identification System", "GEN# +1.00053203"},
        {"Smithsonian Astrophysical Observation", "SAO 114865"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.08167042),
        dec: Angle.Degrees(+04.02383096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60892",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60892"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.18606020),
        dec: Angle.Degrees(+04.02415470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66512"},
        {"Hipparcos Number", "HIP 39471"},
        {"Smithsonian Astrophysical Observation", "SAO 116295"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.01356519),
        dec: Angle.Degrees(+04.02575491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146047"},
        {"Hipparcos Number", "HIP 79563"},
        {"Geneva Identification System", "GEN# +1.00146047"},
        {"Smithsonian Astrophysical Observation", "SAO 121440"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.52112784),
        dec: Angle.Degrees(+04.02749468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69016",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69016"},
    },
    visualMagnitude: 10.87,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.92811315),
        dec: Angle.Degrees(+04.03066362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198317"},
        {"Hipparcos Number", "HIP 102774"},
        {"Smithsonian Astrophysical Observation", "SAO 126253"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.32717256),
        dec: Angle.Degrees(+04.03166336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92425"},
        {"Hipparcos Number", "HIP 52243"},
        {"Smithsonian Astrophysical Observation", "SAO 118426"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.10803952),
        dec: Angle.Degrees(+04.03185799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66714"},
        {"Hipparcos Number", "HIP 39553"},
        {"Geneva Identification System", "GEN# +1.00066714"},
        {"Smithsonian Astrophysical Observation", "SAO 116312"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.23415173),
        dec: Angle.Degrees(+04.03243270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52542",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7912 AB"},
        {"Henry Draper", "HD 93018"},
        {"Hipparcos Number", "HIP 52542"},
        {"Smithsonian Astrophysical Observation", "SAO 118463"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.13920360),
        dec: Angle.Degrees(+04.03384902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172806"},
        {"Hipparcos Number", "HIP 91705"},
        {"Smithsonian Astrophysical Observation", "SAO 123819"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.52599576),
        dec: Angle.Degrees(+04.03436944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216452"},
        {"Hipparcos Number", "HIP 112993"},
        {"Smithsonian Astrophysical Observation", "SAO 127818"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.25303938),
        dec: Angle.Degrees(+04.03569233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148572"},
        {"Hipparcos Number", "HIP 80720"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.20732836),
        dec: Angle.Degrees(+04.03656232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103408"},
        {"Hipparcos Number", "HIP 58061"},
        {"Smithsonian Astrophysical Observation", "SAO 119107"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.61999638),
        dec: Angle.Degrees(+04.03702386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118431"},
        {"Hipparcos Number", "HIP 66406"},
        {"Smithsonian Astrophysical Observation", "SAO 120032"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.21210659),
        dec: Angle.Degrees(+04.03757058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221854"},
        {"Hipparcos Number", "HIP 116433"},
        {"Smithsonian Astrophysical Observation", "SAO 128271"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.90229441),
        dec: Angle.Degrees(+04.03846100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -144.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151219"},
        {"Hipparcos Number", "HIP 82081"},
        {"Geneva Identification System", "GEN# +1.00151219"},
        {"Smithsonian Astrophysical Observation", "SAO 121845"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.49164236),
        dec: Angle.Degrees(+04.04183664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36295",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36295"},
        {"Smithsonian Astrophysical Observation", "SAO 115487"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.06781053),
        dec: Angle.Degrees(+04.04216300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61417",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61417"},
        {"Smithsonian Astrophysical Observation", "SAO 119483"},
    },
    visualMagnitude: 9.99,
    bvColour: 1.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.78126435),
        dec: Angle.Degrees(+04.04230707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15169",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15169"},
        {"Smithsonian Astrophysical Observation", "SAO 111079"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.88095028),
        dec: Angle.Degrees(+04.04387501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86134"},
        {"Hipparcos Number", "HIP 48750"},
        {"Smithsonian Astrophysical Observation", "SAO 118003"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.15420796),
        dec: Angle.Degrees(+04.04436563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61234"},
        {"Hipparcos Number", "HIP 37185"},
        {"Geneva Identification System", "GEN# +1.00061234"},
        {"Smithsonian Astrophysical Observation", "SAO 115730"},
    },
    visualMagnitude: 8.94,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.60141728),
        dec: Angle.Degrees(+04.04465330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129518"},
        {"Hipparcos Number", "HIP 71939"},
        {"Smithsonian Astrophysical Observation", "SAO 120615"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.70241948),
        dec: Angle.Degrees(+04.04563178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109570",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109570"},
    },
    visualMagnitude: 9.95,
    bvColour: 1.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.93705474),
        dec: Angle.Degrees(+04.04573931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221471"},
        {"Hipparcos Number", "HIP 116179"},
        {"Smithsonian Astrophysical Observation", "SAO 128233"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.10226802),
        dec: Angle.Degrees(+04.04753681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98989",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98989"},
        {"Geneva Identification System", "GEN# +9.80024003"},
    },
    visualMagnitude: 10.46,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.43497990),
        dec: Angle.Degrees(+04.04841056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -133.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -171.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18271"},
        {"Hipparcos Number", "HIP 13682"},
        {"Smithsonian Astrophysical Observation", "SAO 110852"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.05854419),
        dec: Angle.Degrees(+04.04845166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12670",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12670"},
    },
    visualMagnitude: 10.98,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.69748948),
        dec: Angle.Degrees(+04.05042386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56764"},
        {"Hipparcos Number", "HIP 35380"},
        {"Smithsonian Astrophysical Observation", "SAO 115232"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.62872650),
        dec: Angle.Degrees(+04.05051211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18197",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18197"},
    },
    visualMagnitude: 10.79,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.38617077),
        dec: Angle.Degrees(+04.05082706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102782"},
        {"Hipparcos Number", "HIP 57708"},
        {"Smithsonian Astrophysical Observation", "SAO 119073"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.52313576),
        dec: Angle.Degrees(+04.05092841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174884"},
        {"Hipparcos Number", "HIP 92648"},
        {"Smithsonian Astrophysical Observation", "SAO 123998"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.16794059),
        dec: Angle.Degrees(+04.05326981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105967"},
        {"Hipparcos Number", "HIP 59451"},
        {"Geneva Identification System", "GEN# +1.00105967"},
        {"Renson", "Renson 30630"},
        {"Smithsonian Astrophysical Observation", "SAO 119262"},
        {"Wilson Evans Batten Catalogue", "WEB 10569"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.91764604),
        dec: Angle.Degrees(+04.05588647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 243803"},
        {"Hipparcos Number", "HIP 25467"},
        {"Smithsonian Astrophysical Observation", "SAO 112772"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.69105371),
        dec: Angle.Degrees(+04.05614326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4979"},
        {"Hipparcos Number", "HIP 4056"},
        {"Geneva Identification System", "GEN# +1.00004979"},
        {"Smithsonian Astrophysical Observation", "SAO 109513"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.98428777),
        dec: Angle.Degrees(+04.06030957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188427"},
        {"Hipparcos Number", "HIP 98007"},
        {"Cincinnati Publication", "Ci 18 2597"},
        {"Geneva Identification System", "GEN# +1.00188427"},
        {"Smithsonian Astrophysical Observation", "SAO 125227"},
        {"Wilson Evans Batten Catalogue", "WEB 17255"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.75709911),
        dec: Angle.Degrees(+04.06273950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -276.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -249.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103695"},
        {"Hipparcos Number", "HIP 58224"},
        {"Geneva Identification System", "GEN# +1.00103695"},
        {"Smithsonian Astrophysical Observation", "SAO 119122"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.12470190),
        dec: Angle.Degrees(+04.06374197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11332",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11332"},
        {"Smithsonian Astrophysical Observation", "SAO 110528"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.45742085),
        dec: Angle.Degrees(+04.06400788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90676",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11399 A"},
        {"Henry Draper", "HD 170580"},
        {"Hipparcos Number", "HIP 90676"},
        {"Fundamental Katalog 5th Edition", "FK5 3469"},
        {"Geneva Identification System", "GEN# +1.00170580A"},
        {"Smithsonian Astrophysical Observation", "SAO 123571"},
        {"Wilson Evans Batten Catalogue", "WEB 15531"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.52133439),
        dec: Angle.Degrees(+04.06536743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138442"},
        {"Hipparcos Number", "HIP 76058"},
        {"Smithsonian Astrophysical Observation", "SAO 121048"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.00005707),
        dec: Angle.Degrees(+04.06607442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -123.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114781"},
        {"Hipparcos Number", "HIP 64453"},
        {"Geneva Identification System", "GEN# +1.00114781"},
        {"Smithsonian Astrophysical Observation", "SAO 119815"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.16681175),
        dec: Angle.Degrees(+04.06828005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216178"},
        {"Hipparcos Number", "HIP 112802"},
        {"Smithsonian Astrophysical Observation", "SAO 127794"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.65973566),
        dec: Angle.Degrees(+04.06836133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54262",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54262"},
    },
    visualMagnitude: 10.36,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.51499506),
        dec: Angle.Degrees(+04.06947698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101686",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101686"},
    },
    visualMagnitude: 10.33,
    bvColour: 1.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.16879358),
        dec: Angle.Degrees(+04.06972445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29208"},
        {"Hipparcos Number", "HIP 21424"},
        {"Geneva Identification System", "GEN# +1.00029208"},
        {"Smithsonian Astrophysical Observation", "SAO 111912"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.99769636),
        dec: Angle.Degrees(+04.07076528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62161"},
        {"Hipparcos Number", "HIP 37584"},
        {"Geneva Identification System", "GEN# +1.00062161"},
        {"Smithsonian Astrophysical Observation", "SAO 115831"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.69163791),
        dec: Angle.Degrees(+04.07087280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18393",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18393"},
        {"Smithsonian Astrophysical Observation", "SAO 111505"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.98594510),
        dec: Angle.Degrees(+04.07111614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61721"},
        {"Hipparcos Number", "HIP 37405"},
        {"Cincinnati Publication", "Ci 18 921"},
        {"Smithsonian Astrophysical Observation", "SAO 115795"},
    },
    visualMagnitude: 6.51,
    bvColour: 1.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.20428882),
        dec: Angle.Degrees(+04.07204226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 250825"},
        {"Hipparcos Number", "HIP 28627"},
        {"Geneva Identification System", "GEN# +1.00250825"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.65801334),
        dec: Angle.Degrees(+04.07351756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197463"},
        {"Hipparcos Number", "HIP 102302"},
        {"Smithsonian Astrophysical Observation", "SAO 126142"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.92469807),
        dec: Angle.Degrees(+04.07837331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84594",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84594"},
        {"Geneva Identification System", "GEN# +9.80019019"},
    },
    visualMagnitude: 10.92,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.39416180),
        dec: Angle.Degrees(+04.07869354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -194.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -228.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17544"},
        {"Hipparcos Number", "HIP 13137"},
        {"Smithsonian Astrophysical Observation", "SAO 110769"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.24220523),
        dec: Angle.Degrees(+04.08005446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52078"},
        {"Hipparcos Number", "HIP 33689"},
        {"Smithsonian Astrophysical Observation", "SAO 114749"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.98845210),
        dec: Angle.Degrees(+04.08324024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155881"},
        {"Hipparcos Number", "HIP 84316"},
        {"Smithsonian Astrophysical Observation", "SAO 122199"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.56260317),
        dec: Angle.Degrees(+04.08559020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4176",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 732"},
        {"Henry Draper", "HD 5143"},
        {"Hipparcos Number", "HIP 4176"},
        {"Geneva Identification System", "GEN# +1.00005143J"},
        {"Smithsonian Astrophysical Observation", "SAO 109522"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.33130321),
        dec: Angle.Degrees(+04.08629898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201022"},
        {"Hipparcos Number", "HIP 104224"},
        {"Smithsonian Astrophysical Observation", "SAO 126549"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.73012903),
        dec: Angle.Degrees(+04.08679919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 265467"},
        {"Hipparcos Number", "HIP 32974"},
        {"Smithsonian Astrophysical Observation", "SAO 114538"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.03768437),
        dec: Angle.Degrees(+04.08701420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73800",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73800"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.24904793),
        dec: Angle.Degrees(+04.08779519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -368.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 123.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147679"},
        {"Hipparcos Number", "HIP 80274"},
        {"Smithsonian Astrophysical Observation", "SAO 121557"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.79038528),
        dec: Angle.Degrees(+04.08841880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97709",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13019 A"},
        {"Henry Draper", "HD 187734"},
        {"Henry Draper 2", "HD 187734A"},
        {"Hipparcos Number", "HIP 97709"},
        {"Smithsonian Astrophysical Observation", "SAO 125141"},
    },
    visualMagnitude: 6.47,
    bvColour: 1.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.86184303),
        dec: Angle.Degrees(+04.08864671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156131"},
        {"Hipparcos Number", "HIP 84432"},
        {"Smithsonian Astrophysical Observation", "SAO 122215"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.92468963),
        dec: Angle.Degrees(+04.08882727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14135",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Menkar"},
        {"Henry Draper", "HD 18884"},
        {"Hipparcos Number", "HIP 14135"},
        {"Fundamental Katalog 5th Edition", "FK5 107"},
        {"Geneva Identification System", "GEN# +1.00018884"},
        {"Smithsonian Astrophysical Observation", "SAO 110920"},
        {"Wilson Evans Batten Catalogue", "WEB 2779"},
    },
    visualMagnitude: 2.54,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.56991279),
        dec: Angle.Degrees(+04.08992539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113744"},
        {"Hipparcos Number", "HIP 63902"},
        {"Geneva Identification System", "GEN# +1.00113744"},
        {"Smithsonian Astrophysical Observation", "SAO 119761"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.43796290),
        dec: Angle.Degrees(+04.09073635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166990"},
        {"Hipparcos Number", "HIP 89283"},
        {"Smithsonian Astrophysical Observation", "SAO 123260"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.28042596),
        dec: Angle.Degrees(+04.09121152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17916",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17916"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.46948590),
        dec: Angle.Degrees(+04.09152653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -128.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3193"},
        {"Hipparcos Number", "HIP 2765"},
        {"Smithsonian Astrophysical Observation", "SAO 109296"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.81517468),
        dec: Angle.Degrees(+04.09335841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18988",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18988"},
    },
    visualMagnitude: 11.06,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.02985756),
        dec: Angle.Degrees(+04.09502511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71954"},
        {"Hipparcos Number", "HIP 41705"},
        {"Smithsonian Astrophysical Observation", "SAO 116831"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.56847171),
        dec: Angle.Degrees(+04.09535491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39497"},
        {"Hipparcos Number", "HIP 27816"},
        {"Smithsonian Astrophysical Observation", "SAO 113232"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.28830881),
        dec: Angle.Degrees(+04.09675940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210391"},
        {"Hipparcos Number", "HIP 109413"},
        {"Geneva Identification System", "GEN# +1.00210391"},
        {"Smithsonian Astrophysical Observation", "SAO 127338"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.50353448),
        dec: Angle.Degrees(+04.09872086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159445"},
        {"Hipparcos Number", "HIP 86003"},
        {"Smithsonian Astrophysical Observation", "SAO 122522"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.66051740),
        dec: Angle.Degrees(+04.09917703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104279"},
        {"Hipparcos Number", "HIP 58564"},
        {"Smithsonian Astrophysical Observation", "SAO 119163"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.13341581),
        dec: Angle.Degrees(+04.10002795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84165",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84165"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.09358479),
        dec: Angle.Degrees(+04.10017925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38650"},
        {"Hipparcos Number", "HIP 27345"},
        {"Celescope Catalog", "CEL 970"},
        {"Geneva Identification System", "GEN# +1.00038650"},
        {"Smithsonian Astrophysical Observation", "SAO 113142"},
    },
    visualMagnitude: 7.65,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.87485259),
        dec: Angle.Degrees(+04.10020053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140324"},
        {"Hipparcos Number", "HIP 76963"},
        {"Geneva Identification System", "GEN# +1.00140324"},
        {"Smithsonian Astrophysical Observation", "SAO 121145"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.72698076),
        dec: Angle.Degrees(+04.10203649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99633",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99633"},
        {"Smithsonian Astrophysical Observation", "SAO 125585"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.31190866),
        dec: Angle.Degrees(+04.10592031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58249"},
        {"Hipparcos Number", "HIP 35986"},
        {"Geneva Identification System", "GEN# +1.00058249"},
        {"Smithsonian Astrophysical Observation", "SAO 115407"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.23947104),
        dec: Angle.Degrees(+04.10605242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176604"},
        {"Hipparcos Number", "HIP 93364"},
        {"Smithsonian Astrophysical Observation", "SAO 124154"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.25477460),
        dec: Angle.Degrees(+04.10725218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23344",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23344"},
        {"Geneva Identification System", "GEN# +0.00300740"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.31888161),
        dec: Angle.Degrees(+04.11063912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 154.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -146.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91535"},
        {"Hipparcos Number", "HIP 51742"},
        {"Smithsonian Astrophysical Observation", "SAO 118371"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.57680056),
        dec: Angle.Degrees(+04.11140855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122367"},
        {"Hipparcos Number", "HIP 68506"},
        {"Geneva Identification System", "GEN# +1.00122367"},
        {"Smithsonian Astrophysical Observation", "SAO 120230"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.35648170),
        dec: Angle.Degrees(+04.11499266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214683"},
        {"Hipparcos Number", "HIP 111888"},
        {"Smithsonian Astrophysical Observation", "SAO 127672"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.96109214),
        dec: Angle.Degrees(+04.11585215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 178.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 108.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184832"},
        {"Hipparcos Number", "HIP 96421"},
        {"Smithsonian Astrophysical Observation", "SAO 124834"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.04914479),
        dec: Angle.Degrees(+04.11951304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37490"},
        {"Hipparcos Number", "HIP 26594"},
        {"Celescope Catalog", "CEL 898"},
        {"Fundamental Katalog 5th Edition", "FK5 2423"},
        {"Geneva Identification System", "GEN# +1.00037490"},
        {"Smithsonian Astrophysical Observation", "SAO 113001"},
        {"Wilson Evans Batten Catalogue", "WEB 5244"},
    },
    visualMagnitude: 4.50,
    bvColour: -0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.79644123),
        dec: Angle.Degrees(+04.12146667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23143"},
        {"Hipparcos Number", "HIP 17353"},
        {"Geneva Identification System", "GEN# +1.00023143"},
        {"Smithsonian Astrophysical Observation", "SAO 111368"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.71531520),
        dec: Angle.Degrees(+04.12243468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20587",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20587"},
        {"Geneva Identification System", "GEN# +0.00300601"},
        {"Wilson Evans Batten Catalogue", "WEB 3944"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.13737766),
        dec: Angle.Degrees(+04.12337651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16086"},
        {"Hipparcos Number", "HIP 12034"},
        {"Geneva Identification System", "GEN# +1.00016086"},
        {"Smithsonian Astrophysical Observation", "SAO 110627"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.79327439),
        dec: Angle.Degrees(+04.12386977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 196.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68119",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68119"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.19036344),
        dec: Angle.Degrees(+04.12851258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50266",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50266"},
        {"Smithsonian Astrophysical Observation", "SAO 118190"},
    },
    visualMagnitude: 9.53,
    bvColour: 1.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.95865866),
        dec: Angle.Degrees(+04.12861193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9573"},
        {"Hipparcos Number", "HIP 7307"},
        {"Smithsonian Astrophysical Observation", "SAO 109982"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.51629986),
        dec: Angle.Degrees(+04.12880910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8668",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8668"},
        {"Smithsonian Astrophysical Observation", "SAO 110178"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.91135728),
        dec: Angle.Degrees(+04.12881263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37942",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6360 AB"},
        {"Henry Draper", "HD 62968"},
        {"Hipparcos Number", "HIP 37942"},
        {"Smithsonian Astrophysical Observation", "SAO 115910"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.64732236),
        dec: Angle.Degrees(+04.13059806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116012"},
        {"Hipparcos Number", "HIP 65121"},
        {"Cincinnati Publication", "Ci 18 1722"},
        {"Cincinnati Publication 2", "Ci 20 773"},
        {"Geneva Identification System", "GEN# +1.00116012"},
        {"Smithsonian Astrophysical Observation", "SAO 119891"},
        {"Wilson Evans Batten Catalogue", "WEB 11502"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.18363162),
        dec: Angle.Degrees(+04.13245654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -507.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 202.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 680"},
        {"Hipparcos Number", "HIP 900"},
        {"Geneva Identification System", "GEN# +1.00000680"},
        {"Smithsonian Astrophysical Observation", "SAO 109052"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.77350337),
        dec: Angle.Degrees(+04.13310730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31709"},
        {"Hipparcos Number", "HIP 23103"},
        {"Fundamental Katalog 5th Edition", "FK5 4454"},
        {"Smithsonian Astrophysical Observation", "SAO 112277"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.55876706),
        dec: Angle.Degrees(+04.13393982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100415"},
        {"Hipparcos Number", "HIP 56378"},
        {"Fundamental Katalog 5th Edition", "FK5 5018"},
        {"Smithsonian Astrophysical Observation", "SAO 118920"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.35328311),
        dec: Angle.Degrees(+04.13417701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55574",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8145 AB"},
        {"Henry Draper", "HD 98914"},
        {"Hipparcos Number", "HIP 55574"},
        {"Smithsonian Astrophysical Observation", "SAO 118820"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.76101154),
        dec: Angle.Degrees(+04.13806909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 246001"},
        {"Hipparcos Number", "HIP 26575"},
        {"Smithsonian Astrophysical Observation", "SAO 112997"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.74908287),
        dec: Angle.Degrees(+04.13867877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17330",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17330"},
        {"Smithsonian Astrophysical Observation", "SAO 111364"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.64378601),
        dec: Angle.Degrees(+04.13962464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21186",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21186"},
        {"Geneva Identification System", "GEN# +6.20030231"},
        {"Wilson Evans Batten Catalogue", "WEB 4072"},
    },
    visualMagnitude: 11.03,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.12672641),
        dec: Angle.Degrees(+04.13993098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -162.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157999"},
        {"Hipparcos Number", "HIP 85355"},
        {"Fundamental Katalog 5th Edition", "FK5 1459"},
        {"Geneva Identification System", "GEN# +1.00157999"},
        {"Smithsonian Astrophysical Observation", "SAO 122387"},
        {"Wilson Evans Batten Catalogue", "WEB 14413"},
    },
    visualMagnitude: 4.34,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.62866503),
        dec: Angle.Degrees(+04.14034239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66713"},
        {"Hipparcos Number", "HIP 39544"},
        {"Geneva Identification System", "GEN# +1.00066713"},
        {"Smithsonian Astrophysical Observation", "SAO 116311"},
    },
    visualMagnitude: 7.74,
    bvColour: -0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.21552170),
        dec: Angle.Degrees(+04.14144364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201097"},
        {"Hipparcos Number", "HIP 104259"},
        {"Geneva Identification System", "GEN# +1.00201097"},
        {"Smithsonian Astrophysical Observation", "SAO 126554"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.82935434),
        dec: Angle.Degrees(+04.14168872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127618"},
        {"Hipparcos Number", "HIP 71085"},
        {"Smithsonian Astrophysical Observation", "SAO 120516"},
        {"Wilson Evans Batten Catalogue", "WEB 12292"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.05409889),
        dec: Angle.Degrees(+04.14232542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211699"},
        {"Hipparcos Number", "HIP 110163"},
        {"Geneva Identification System", "GEN# +1.00211699"},
        {"Smithsonian Astrophysical Observation", "SAO 127444"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.71358652),
        dec: Angle.Degrees(+04.14315652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3764",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3764"},
        {"Smithsonian Astrophysical Observation", "SAO 109472"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.08870960),
        dec: Angle.Degrees(+04.14327377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111166"},
        {"Hipparcos Number", "HIP 62401"},
        {"Wilson Evans Batten Catalogue", "WEB 11077"},
    },
    visualMagnitude: 11.98,
    bvColour: 4.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.82668889),
        dec: Angle.Degrees(+04.14488313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47962"},
        {"Hipparcos Number", "HIP 32006"},
        {"Geneva Identification System", "GEN# +1.00047962"},
        {"Smithsonian Astrophysical Observation", "SAO 114272"},
        {"Wilson Evans Batten Catalogue", "WEB 6450"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.30893745),
        dec: Angle.Degrees(+04.14490937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22557"},
        {"Hipparcos Number", "HIP 16925"},
        {"Geneva Identification System", "GEN# +1.00022557"},
        {"Smithsonian Astrophysical Observation", "SAO 111304"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.45786633),
        dec: Angle.Degrees(+04.14543075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104624"},
        {"Hipparcos Number", "HIP 58744"},
        {"Smithsonian Astrophysical Observation", "SAO 119183"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.72244169),
        dec: Angle.Degrees(+04.14613295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76241"},
        {"Hipparcos Number", "HIP 43773"},
        {"Geneva Identification System", "GEN# +1.00076241"},
        {"Smithsonian Astrophysical Observation", "SAO 117260"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.74182377),
        dec: Angle.Degrees(+04.14716805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132035"},
        {"Hipparcos Number", "HIP 73148"},
        {"Geneva Identification System", "GEN# +1.00132035"},
        {"Smithsonian Astrophysical Observation", "SAO 120754"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.23303981),
        dec: Angle.Degrees(+04.15056308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160609"},
        {"Hipparcos Number", "HIP 86511"},
        {"Smithsonian Astrophysical Observation", "SAO 122634"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.18725652),
        dec: Angle.Degrees(+04.15099903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16155",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2556 C"},
        {"Henry Draper", "HD 21497"},
        {"Hipparcos Number", "HIP 16155"},
        {"Smithsonian Astrophysical Observation", "SAO 111209"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.04547800),
        dec: Angle.Degrees(+04.15217113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19979",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19979"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.27795602),
        dec: Angle.Degrees(+04.15230801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39325",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6532 AB"},
        {"Aitken 2", "ADS 6532"},
        {"Henry Draper", "HD 66177"},
        {"Hipparcos Number", "HIP 39325"},
        {"Smithsonian Astrophysical Observation", "SAO 116263"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.709,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.60847379),
        dec: Angle.Degrees(+04.15232730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59062"},
        {"Hipparcos Number", "HIP 36310"},
        {"Geneva Identification System", "GEN# +1.00059062"},
        {"Smithsonian Astrophysical Observation", "SAO 115494"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.775,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.10763016),
        dec: Angle.Degrees(+04.15328165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -148.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45339"},
        {"Hipparcos Number", "HIP 30690"},
        {"Smithsonian Astrophysical Observation", "SAO 113894"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.73426808),
        dec: Angle.Degrees(+04.15362913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20343",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20343"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.37675974),
        dec: Angle.Degrees(+04.15689042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208632"},
        {"Hipparcos Number", "HIP 108389"},
        {"Geneva Identification System", "GEN# +1.00208632"},
        {"Smithsonian Astrophysical Observation", "SAO 127190"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.37905170),
        dec: Angle.Degrees(+04.15777131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41380"},
        {"Hipparcos Number", "HIP 28814"},
        {"Fundamental Katalog 5th Edition", "FK5 230"},
        {"Geneva Identification System", "GEN# +1.00041380"},
        {"Smithsonian Astrophysical Observation", "SAO 113430"},
        {"Wilson Evans Batten Catalogue", "WEB 5637"},
    },
    visualMagnitude: 5.63,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.24316628),
        dec: Angle.Degrees(+04.15867686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201436"},
        {"Hipparcos Number", "HIP 104442"},
        {"Smithsonian Astrophysical Observation", "SAO 126582"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.35043567),
        dec: Angle.Degrees(+04.16196794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168224"},
        {"Hipparcos Number", "HIP 89718"},
        {"Smithsonian Astrophysical Observation", "SAO 123346"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.64709928),
        dec: Angle.Degrees(+04.16221756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215707"},
        {"Hipparcos Number", "HIP 112485"},
        {"Smithsonian Astrophysical Observation", "SAO 127758"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.76597353),
        dec: Angle.Degrees(+04.16247242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213948"},
        {"Hipparcos Number", "HIP 111466"},
        {"Smithsonian Astrophysical Observation", "SAO 127613"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.74948757),
        dec: Angle.Degrees(+04.16277890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 544"},
        {"Hipparcos Number", "HIP 806"},
        {"Smithsonian Astrophysical Observation", "SAO 109043"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.48796018),
        dec: Angle.Degrees(+04.16612269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3326",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 588"},
        {"Aitken 2", "ADS 588 AB"},
        {"Henry Draper", "HD 3972"},
        {"Hipparcos Number", "HIP 3326"},
        {"Geneva Identification System", "GEN# +1.00003972J"},
        {"Smithsonian Astrophysical Observation", "SAO 109392"},
        {"Wilson Evans Batten Catalogue", "WEB 589"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.59672229),
        dec: Angle.Degrees(+04.16667497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12264",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12264"},
        {"Smithsonian Astrophysical Observation", "SAO 110652"},
    },
    visualMagnitude: 9.49,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.47488575),
        dec: Angle.Degrees(+04.16929690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139896"},
        {"Hipparcos Number", "HIP 76780"},
        {"Fundamental Katalog 5th Edition", "FK5 5386"},
        {"Geneva Identification System", "GEN# +1.00139896"},
        {"Smithsonian Astrophysical Observation", "SAO 121121"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.14639976),
        dec: Angle.Degrees(+04.17034845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160783"},
        {"Hipparcos Number", "HIP 86581"},
        {"Smithsonian Astrophysical Observation", "SAO 122647"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.40804511),
        dec: Angle.Degrees(+04.17105034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82606"},
        {"Hipparcos Number", "HIP 46871"},
        {"Geneva Identification System", "GEN# +1.00082606"},
        {"Smithsonian Astrophysical Observation", "SAO 117766"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.27319106),
        dec: Angle.Degrees(+04.17159931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50435"},
        {"Hipparcos Number", "HIP 33089"},
        {"Smithsonian Astrophysical Observation", "SAO 114568"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.37557917),
        dec: Angle.Degrees(+04.17400380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97044",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12825 A"},
        {"Henry Draper", "HD 186278"},
        {"Hipparcos Number", "HIP 97044"},
        {"Smithsonian Astrophysical Observation", "SAO 124987"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.83785972),
        dec: Angle.Degrees(+04.17441689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223238"},
        {"Hipparcos Number", "HIP 117367"},
        {"Cincinnati Publication", "Ci 18 3121"},
        {"Geneva Identification System", "GEN# +1.00223238"},
        {"Smithsonian Astrophysical Observation", "SAO 128385"},
        {"Wilson Evans Batten Catalogue", "WEB 20675"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.96749718),
        dec: Angle.Degrees(+04.17555321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 349.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 242548"},
        {"Hipparcos Number", "HIP 24762"},
        {"Smithsonian Astrophysical Observation", "SAO 112612"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.63278349),
        dec: Angle.Degrees(+04.17606514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54355"},
        {"Hipparcos Number", "HIP 34463"},
        {"Smithsonian Astrophysical Observation", "SAO 114976"},
    },
    visualMagnitude: 7.02,
    bvColour: 1.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.15359634),
        dec: Angle.Degrees(+04.17618059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21740",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21740"},
    },
    visualMagnitude: 10.46,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.02384177),
        dec: Angle.Degrees(+04.17631611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122849"},
        {"Hipparcos Number", "HIP 68731"},
        {"Smithsonian Astrophysical Observation", "SAO 120266"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.04139689),
        dec: Angle.Degrees(+04.17826606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128004"},
        {"Hipparcos Number", "HIP 71259"},
        {"Smithsonian Astrophysical Observation", "SAO 120538"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.59382606),
        dec: Angle.Degrees(+04.17831801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125411"},
        {"Hipparcos Number", "HIP 69966"},
        {"Smithsonian Astrophysical Observation", "SAO 120394"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.75622197),
        dec: Angle.Degrees(+04.17976121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148816"},
        {"Hipparcos Number", "HIP 80837"},
        {"Cincinnati Publication", "Ci 20 998"},
        {"Geneva Identification System", "GEN# +1.00148816"},
        {"Smithsonian Astrophysical Observation", "SAO 121653"},
        {"Wilson Evans Batten Catalogue", "WEB 13672"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.61963885),
        dec: Angle.Degrees(+04.18160865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -432.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1392.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22939"},
        {"Hipparcos Number", "HIP 17206"},
        {"Smithsonian Astrophysical Observation", "SAO 111351"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.29107189),
        dec: Angle.Degrees(+04.18581066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44907"},
        {"Hipparcos Number", "HIP 30489"},
        {"Celescope Catalog", "CEL 1222"},
        {"Geneva Identification System", "GEN# +1.00044907"},
        {"Renson", "Renson 11890"},
        {"Smithsonian Astrophysical Observation", "SAO 113830"},
    },
    visualMagnitude: 7.32,
    bvColour: -0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.13514383),
        dec: Angle.Degrees(+04.18658723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67636",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67636"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.792,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.87849401),
        dec: Angle.Degrees(+04.18673783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194544"},
        {"Hipparcos Number", "HIP 100786"},
        {"Smithsonian Astrophysical Observation", "SAO 125803"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.51919990),
        dec: Angle.Degrees(+04.18814270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63209",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63209"},
    },
    visualMagnitude: 9.98,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.26259645),
        dec: Angle.Degrees(+04.19053239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179152"},
        {"Hipparcos Number", "HIP 94268"},
        {"Geneva Identification System", "GEN# +1.00179152"},
        {"Smithsonian Astrophysical Observation", "SAO 124360"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.718,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.81397963),
        dec: Angle.Degrees(+04.19110362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43913"},
        {"Hipparcos Number", "HIP 30009"},
        {"Celescope Catalog", "CEL 1169"},
        {"Smithsonian Astrophysical Observation", "SAO 113718"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.74358246),
        dec: Angle.Degrees(+04.19131359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199560"},
        {"Hipparcos Number", "HIP 103472"},
        {"Smithsonian Astrophysical Observation", "SAO 126414"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.45361409),
        dec: Angle.Degrees(+04.19548750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59037",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59037"},
        {"Smithsonian Astrophysical Observation", "SAO 119218"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.55880021),
        dec: Angle.Degrees(+04.19552039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10775",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1772"},
        {"Aitken 2", "ADS 1772 A"},
        {"Henry Draper", "HD 14280"},
        {"Hipparcos Number", "HIP 10775"},
        {"Geneva Identification System", "GEN# +1.00014280"},
        {"Smithsonian Astrophysical Observation", "SAO 110465"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.719,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.67044295),
        dec: Angle.Degrees(+04.19617211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6464"},
        {"Hipparcos Number", "HIP 5133"},
        {"Smithsonian Astrophysical Observation", "SAO 109664"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.42458011),
        dec: Angle.Degrees(+04.19864419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53944",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53944"},
    },
    visualMagnitude: 9.79,
    bvColour: 1.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.56593335),
        dec: Angle.Degrees(+04.19922652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166232"},
        {"Hipparcos Number", "HIP 88974"},
        {"Smithsonian Astrophysical Observation", "SAO 123193"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.41277390),
        dec: Angle.Degrees(+04.19927208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108213"},
        {"Hipparcos Number", "HIP 60655"},
        {"Smithsonian Astrophysical Observation", "SAO 119391"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.47842403),
        dec: Angle.Degrees(+04.19974413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65716"},
        {"Hipparcos Number", "HIP 39116"},
        {"Smithsonian Astrophysical Observation", "SAO 116217"},
    },
    visualMagnitude: 10.07,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.04877951),
        dec: Angle.Degrees(+04.20040397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92951",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11853 B"},
        {"Henry Draper", "HD 175639"},
        {"Hipparcos Number", "HIP 92951"},
        {"Geneva Identification System", "GEN# +1.00175639"},
        {"Smithsonian Astrophysical Observation", "SAO 124070"},
        {"Wilson Evans Batten Catalogue", "WEB 16097"},
    },
    visualMagnitude: 4.98,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.06088696),
        dec: Angle.Degrees(+04.20205672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92946",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11853 A"},
        {"Henry Draper", "HD 175638"},
        {"Hipparcos Number", "HIP 92946"},
        {"Fundamental Katalog 5th Edition", "FK5 709"},
        {"Geneva Identification System", "GEN# +1.00175638A"},
        {"Smithsonian Astrophysical Observation", "SAO 124068"},
        {"Wilson Evans Batten Catalogue", "WEB 16096"},
    },
    visualMagnitude: 4.62,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.05483475),
        dec: Angle.Degrees(+04.20352956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36217"},
        {"Hipparcos Number", "HIP 25785"},
        {"Geneva Identification System", "GEN# +1.00036217"},
        {"Smithsonian Astrophysical Observation", "SAO 112837"},
    },
    visualMagnitude: 6.21,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.58297186),
        dec: Angle.Degrees(+04.20485626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5694"},
        {"Hipparcos Number", "HIP 4582"},
        {"Geneva Identification System", "GEN# +1.00005694"},
        {"Smithsonian Astrophysical Observation", "SAO 109568"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.67673012),
        dec: Angle.Degrees(+04.20579338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81634",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10149 B"},
        {"Henry Draper", "HD 150379"},
        {"Hipparcos Number", "HIP 81634"},
        {"Geneva Identification System", "GEN# +1.00150379A"},
        {"Renson", "Renson 42540"},
        {"Smithsonian Astrophysical Observation", "SAO 121774"},
        {"Wilson Evans Batten Catalogue", "WEB 13785"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.14646013),
        dec: Angle.Degrees(+04.20722707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55731"},
        {"Hipparcos Number", "HIP 34980"},
        {"Smithsonian Astrophysical Observation", "SAO 115116"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.55936704),
        dec: Angle.Degrees(+04.20736393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98711"},
        {"Hipparcos Number", "HIP 55467"},
        {"Geneva Identification System", "GEN# +1.00098711"},
        {"Smithsonian Astrophysical Observation", "SAO 118808"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.39132277),
        dec: Angle.Degrees(+04.20832501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53648",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53648"},
        {"Smithsonian Astrophysical Observation", "SAO 118595"},
    },
    visualMagnitude: 9.50,
    bvColour: 1.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.63974447),
        dec: Angle.Degrees(+04.20933033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20580"},
        {"Hipparcos Number", "HIP 15427"},
        {"Smithsonian Astrophysical Observation", "SAO 111116"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.70945972),
        dec: Angle.Degrees(+04.20955225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182221"},
        {"Hipparcos Number", "HIP 95318"},
        {"Smithsonian Astrophysical Observation", "SAO 124576"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.88630341),
        dec: Angle.Degrees(+04.20986270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44602"},
        {"Hipparcos Number", "HIP 30328"},
        {"Celescope Catalog", "CEL 1203"},
        {"Geneva Identification System", "GEN# +1.00044602"},
        {"Smithsonian Astrophysical Observation", "SAO 113790"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.68853665),
        dec: Angle.Degrees(+04.21042253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20884"},
        {"Hipparcos Number", "HIP 15687"},
        {"Smithsonian Astrophysical Observation", "SAO 111155"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.52109306),
        dec: Angle.Degrees(+04.21057358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45376",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7257 AB"},
        {"Henry Draper", "HD 79556"},
        {"Hipparcos Number", "HIP 45376"},
        {"Smithsonian Astrophysical Observation", "SAO 117533"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.71424773),
        dec: Angle.Degrees(+04.21067897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33900"},
        {"Hipparcos Number", "HIP 24363"},
        {"Geneva Identification System", "GEN# +1.00033900"},
        {"Smithsonian Astrophysical Observation", "SAO 112538"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.40787481),
        dec: Angle.Degrees(+04.21117676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38900"},
        {"Hipparcos Number", "HIP 27480"},
        {"Celescope Catalog", "CEL 992"},
        {"Geneva Identification System", "GEN# +1.00038900"},
        {"Smithsonian Astrophysical Observation", "SAO 113171"},
    },
    visualMagnitude: 7.81,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.28243671),
        dec: Angle.Degrees(+04.21249997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117698"},
        {"Hipparcos Number", "HIP 66002"},
        {"Smithsonian Astrophysical Observation", "SAO 119983"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.97711582),
        dec: Angle.Degrees(+04.21343393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84821"},
        {"Hipparcos Number", "HIP 48063"},
        {"Smithsonian Astrophysical Observation", "SAO 117917"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.96365778),
        dec: Angle.Degrees(+04.21593224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69479"},
        {"Henry Draper 2", "HD 69480"},
        {"Hipparcos Number", "HIP 40597"},
        {"Fundamental Katalog 5th Edition", "FK5 1216"},
        {"Geneva Identification System", "GEN# +1.00069479"},
        {"Geneva Identification System 2", "GEN# +1.00069480"},
        {"Smithsonian Astrophysical Observation", "SAO 116582"},
        {"Wilson Evans Batten Catalogue", "WEB 7894"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.32694655),
        dec: Angle.Degrees(+04.21915375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111434",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16069 B"},
        {"Hipparcos Number", "HIP 111434"},
        {"Smithsonian Astrophysical Observation", "SAO 127610"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.63384494),
        dec: Angle.Degrees(+04.21935158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81641",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10149 A"},
        {"Henry Draper", "HD 150378"},
        {"Hipparcos Number", "HIP 81641"},
        {"Geneva Identification System", "GEN# +1.00150378"},
        {"Smithsonian Astrophysical Observation", "SAO 121776"},
        {"Wilson Evans Batten Catalogue", "WEB 13784"},
    },
    visualMagnitude: 5.77,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.16119601),
        dec: Angle.Degrees(+04.21981484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109287"},
        {"Hipparcos Number", "HIP 61304"},
        {"Smithsonian Astrophysical Observation", "SAO 119470"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.40429519),
        dec: Angle.Degrees(+04.22053874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11295"},
        {"Hipparcos Number", "HIP 8605"},
        {"Smithsonian Astrophysical Observation", "SAO 110167"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.75408571),
        dec: Angle.Degrees(+04.22069009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54166"},
        {"Hipparcos Number", "HIP 34406"},
        {"Smithsonian Astrophysical Observation", "SAO 114953"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.00076914),
        dec: Angle.Degrees(+04.22199575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68680",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68680"},
        {"Smithsonian Astrophysical Observation", "SAO 120259"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.88103940),
        dec: Angle.Degrees(+04.22214811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111433",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16069 A"},
        {"Henry Draper", "HD 213892"},
        {"Hipparcos Number", "HIP 111433"},
        {"Smithsonian Astrophysical Observation", "SAO 127609"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.63158281),
        dec: Angle.Degrees(+04.22238985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40603"},
        {"Hipparcos Number", "HIP 28414"},
        {"Smithsonian Astrophysical Observation", "SAO 113342"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.01818078),
        dec: Angle.Degrees(+04.22270741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138714"},
        {"Hipparcos Number", "HIP 76187"},
        {"Smithsonian Astrophysical Observation", "SAO 121059"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.42095817),
        dec: Angle.Degrees(+04.22463962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218059"},
        {"Hipparcos Number", "HIP 113980"},
        {"Geneva Identification System", "GEN# +1.00218059"},
        {"Smithsonian Astrophysical Observation", "SAO 127957"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.25029753),
        dec: Angle.Degrees(+04.22579562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 153.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -161.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93932",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93932"},
        {"Geneva Identification System", "GEN# +2.67550001"},
        {"New General Catalogue", "NGC 6755 1"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.90392084),
        dec: Angle.Degrees(+04.22697089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5023",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5023"},
        {"Geneva Identification System", "GEN# +6.20001011"},
        {"Renson", "Renson 1630"},
    },
    visualMagnitude: 12.06,
    bvColour: -0.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.09028551),
        dec: Angle.Degrees(+04.22702985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85429",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85429"},
    },
    visualMagnitude: 12.34,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.85806362),
        dec: Angle.Degrees(+04.22751687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126865"},
        {"Hipparcos Number", "HIP 70737"},
        {"Smithsonian Astrophysical Observation", "SAO 120478"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.99246833),
        dec: Angle.Degrees(+04.22956407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223233"},
        {"Hipparcos Number", "HIP 117359"},
        {"Smithsonian Astrophysical Observation", "SAO 128384"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.93678591),
        dec: Angle.Degrees(+04.22997168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13249"},
        {"Hipparcos Number", "HIP 10084"},
        {"Geneva Identification System", "GEN# +1.00013249"},
        {"Smithsonian Astrophysical Observation", "SAO 110374"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.41655040),
        dec: Angle.Degrees(+04.23274745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133745"},
        {"Hipparcos Number", "HIP 73877"},
        {"Geneva Identification System", "GEN# +1.00133745"},
        {"Smithsonian Astrophysical Observation", "SAO 120835"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.49281359),
        dec: Angle.Degrees(+04.23348043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108370",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108370"},
        {"Smithsonian Astrophysical Observation", "SAO 127187"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.31977001),
        dec: Angle.Degrees(+04.23430363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216539"},
        {"Hipparcos Number", "HIP 113041"},
        {"Smithsonian Astrophysical Observation", "SAO 127823"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.39738808),
        dec: Angle.Degrees(+04.23432288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210239"},
        {"Hipparcos Number", "HIP 109322"},
        {"Geneva Identification System", "GEN# +1.00210239"},
        {"Smithsonian Astrophysical Observation", "SAO 127324"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.21814234),
        dec: Angle.Degrees(+04.23599344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76494"},
        {"Hipparcos Number", "HIP 43902"},
        {"Geneva Identification System", "GEN# +1.00076494"},
        {"Smithsonian Astrophysical Observation", "SAO 117287"},
        {"Wilson Evans Batten Catalogue", "WEB 8442"},
    },
    visualMagnitude: 6.13,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.15432348),
        dec: Angle.Degrees(+04.23658550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112061"},
        {"Hipparcos Number", "HIP 62917"},
        {"Smithsonian Astrophysical Observation", "SAO 119649"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.41726087),
        dec: Angle.Degrees(+04.23787756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37775"},
        {"Hipparcos Number", "HIP 26767"},
        {"Smithsonian Astrophysical Observation", "SAO 113032"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.29043257),
        dec: Angle.Degrees(+04.23995499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173954"},
        {"Hipparcos Number", "HIP 92254"},
        {"Fundamental Katalog 5th Edition", "FK5 3494"},
        {"Geneva Identification System", "GEN# +1.00173954"},
        {"Smithsonian Astrophysical Observation", "SAO 123928"},
    },
    visualMagnitude: 6.20,
    bvColour: 1.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.01111795),
        dec: Angle.Degrees(+04.24138735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86147"},
        {"Hipparcos Number", "HIP 48768"},
        {"Geneva Identification System", "GEN# +1.00086147"},
        {"Smithsonian Astrophysical Observation", "SAO 118006"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.20296286),
        dec: Angle.Degrees(+04.24219638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -181.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 243002"},
        {"Hipparcos Number", "HIP 25054"},
    },
    visualMagnitude: 10.61,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.46406856),
        dec: Angle.Degrees(+04.24297854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83391",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83391"},
    },
    visualMagnitude: 10.84,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.65397957),
        dec: Angle.Degrees(+04.24301626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 245897"},
        {"Hipparcos Number", "HIP 26522"},
        {"Smithsonian Astrophysical Observation", "SAO 112988"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.60954867),
        dec: Angle.Degrees(+04.24533310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53188",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53188"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.18963236),
        dec: Angle.Degrees(+04.24619562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87946",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87946"},
    },
    visualMagnitude: 10.64,
    bvColour: 1.733,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.48720059),
        dec: Angle.Degrees(+04.24778434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97255",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12882 A"},
        {"Henry Draper", "HD 186704"},
        {"Hipparcos Number", "HIP 97255"},
        {"Geneva Identification System", "GEN# +1.00186704"},
        {"Smithsonian Astrophysical Observation", "SAO 125036"},
        {"Wilson Evans Batten Catalogue", "WEB 17076"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.48874776),
        dec: Angle.Degrees(+04.24849718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92885"},
        {"Hipparcos Number", "HIP 52471"},
        {"Geneva Identification System", "GEN# +1.00092885"},
        {"Smithsonian Astrophysical Observation", "SAO 118454"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.89544862),
        dec: Angle.Degrees(+04.25076038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201735"},
        {"Hipparcos Number", "HIP 104603"},
        {"Smithsonian Astrophysical Observation", "SAO 126604"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.84458128),
        dec: Angle.Degrees(+04.25080222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1160"},
        {"Henry Draper 2", "HD 1160A"},
        {"Hipparcos Number", "HIP 1272"},
        {"Fundamental Katalog 5th Edition", "FK5 4027"},
        {"Smithsonian Astrophysical Observation", "SAO 109094"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.98870839),
        dec: Angle.Degrees(+04.25114921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122406"},
        {"Hipparcos Number", "HIP 68514"},
        {"Geneva Identification System", "GEN# +1.00122406"},
        {"Smithsonian Astrophysical Observation", "SAO 120235"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.39378960),
        dec: Angle.Degrees(+04.25284530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94003",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94003"},
        {"New General Catalogue", "NGC 6755 27"},
    },
    visualMagnitude: 10.68,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.08534189),
        dec: Angle.Degrees(+04.25290775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142229"},
        {"Hipparcos Number", "HIP 77810"},
        {"Geneva Identification System", "GEN# +1.00142229"},
        {"Smithsonian Astrophysical Observation", "SAO 121238"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.33342021),
        dec: Angle.Degrees(+04.25317413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45760"},
        {"Hipparcos Number", "HIP 30926"},
        {"Celescope Catalog", "CEL 1263"},
        {"Smithsonian Astrophysical Observation", "SAO 113943"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.36044432),
        dec: Angle.Degrees(+04.25327168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41277",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41277"},
        {"Geneva Identification System", "GEN# +6.20030522"},
    },
    visualMagnitude: 10.39,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.32058874),
        dec: Angle.Degrees(+04.25378213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165542"},
        {"Hipparcos Number", "HIP 88693"},
        {"Smithsonian Astrophysical Observation", "SAO 123123"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.59036291),
        dec: Angle.Degrees(+04.25384563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64917"},
        {"Hipparcos Number", "HIP 38793"},
        {"Smithsonian Astrophysical Observation", "SAO 116143"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.09505843),
        dec: Angle.Degrees(+04.25411593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213437"},
        {"Hipparcos Number", "HIP 111163"},
        {"Geneva Identification System", "GEN# +1.00213437"},
        {"Smithsonian Astrophysical Observation", "SAO 127573"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.81057670),
        dec: Angle.Degrees(+04.25468975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145745"},
        {"Hipparcos Number", "HIP 79418"},
        {"Smithsonian Astrophysical Observation", "SAO 121425"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.12073673),
        dec: Angle.Degrees(+04.25543668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179989"},
        {"Hipparcos Number", "HIP 94555"},
        {"Geneva Identification System", "GEN# +1.00179989"},
        {"Smithsonian Astrophysical Observation", "SAO 124429"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.66247303),
        dec: Angle.Degrees(+04.25600559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180721"},
        {"Hipparcos Number", "HIP 94806"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.36668539),
        dec: Angle.Degrees(+04.25614300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6356",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6356"},
        {"Smithsonian Astrophysical Observation", "SAO 109825"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.40831382),
        dec: Angle.Degrees(+04.25750687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19699"},
        {"Hipparcos Number", "HIP 14746"},
        {"Smithsonian Astrophysical Observation", "SAO 111024"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.60646355),
        dec: Angle.Degrees(+04.25818789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214884"},
        {"Hipparcos Number", "HIP 112007"},
        {"Smithsonian Astrophysical Observation", "SAO 127687"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.32127820),
        dec: Angle.Degrees(+04.25842230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114513",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114513"},
        {"Smithsonian Astrophysical Observation", "SAO 128021"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.91479807),
        dec: Angle.Degrees(+04.25848245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156950"},
        {"Hipparcos Number", "HIP 84828"},
        {"Smithsonian Astrophysical Observation", "SAO 122288"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.06083032),
        dec: Angle.Degrees(+04.26187778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18284",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18284"},
    },
    visualMagnitude: 11.24,
    bvColour: 1.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.65378748),
        dec: Angle.Degrees(+04.26218614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79657",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9980 AB"},
        {"Henry Draper", "HD 146265"},
        {"Hipparcos Number", "HIP 79657"},
        {"Smithsonian Astrophysical Observation", "SAO 121453"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.81912456),
        dec: Angle.Degrees(+04.26291262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179742"},
        {"Hipparcos Number", "HIP 94459"},
        {"Geneva Identification System", "GEN# +1.00179742"},
        {"Smithsonian Astrophysical Observation", "SAO 124406"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.38964077),
        dec: Angle.Degrees(+04.26403511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175726"},
        {"Hipparcos Number", "HIP 92984"},
        {"Geneva Identification System", "GEN# +1.00175726"},
        {"Smithsonian Astrophysical Observation", "SAO 124077"},
    },
    visualMagnitude: 6.71,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.15489096),
        dec: Angle.Degrees(+04.26533443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92895",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Kaveh"},
        {"Henry Draper", "HD 175541"},
        {"Hipparcos Number", "HIP 92895"},
        {"Cincinnati Publication", "Ci 18 2473"},
        {"Geneva Identification System", "GEN# +1.00175541"},
        {"Smithsonian Astrophysical Observation", "SAO 124054"},
        {"Wilson Evans Batten Catalogue", "WEB 16085"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.869,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.92036782),
        dec: Angle.Degrees(+04.26554316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81489"},
        {"Hipparcos Number", "HIP 46270"},
        {"Smithsonian Astrophysical Observation", "SAO 117687"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.50997535),
        dec: Angle.Degrees(+04.26662795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128110"},
        {"Hipparcos Number", "HIP 71317"},
        {"Smithsonian Astrophysical Observation", "SAO 120542"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.75546745),
        dec: Angle.Degrees(+04.26920390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34136"},
        {"Hipparcos Number", "HIP 24483"},
        {"Smithsonian Astrophysical Observation", "SAO 112567"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.80085481),
        dec: Angle.Degrees(+04.27035625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211231"},
        {"Hipparcos Number", "HIP 109910"},
        {"Geneva Identification System", "GEN# +1.00211231"},
        {"Smithsonian Astrophysical Observation", "SAO 127416"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.91106716),
        dec: Angle.Degrees(+04.27141252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214075"},
        {"Hipparcos Number", "HIP 111526"},
        {"Smithsonian Astrophysical Observation", "SAO 127623"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.92605660),
        dec: Angle.Degrees(+04.27141302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199852"},
        {"Hipparcos Number", "HIP 103623"},
        {"Smithsonian Astrophysical Observation", "SAO 126443"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.92622648),
        dec: Angle.Degrees(+04.27270434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122169"},
        {"Hipparcos Number", "HIP 68392"},
        {"Geneva Identification System", "GEN# +1.00122169"},
        {"Smithsonian Astrophysical Observation", "SAO 120214"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.01286442),
        dec: Angle.Degrees(+04.27327903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224563"},
        {"Hipparcos Number", "HIP 118235"},
        {"Smithsonian Astrophysical Observation", "SAO 128509"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.73425473),
        dec: Angle.Degrees(+04.27351665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94815",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94815"},
    },
    visualMagnitude: 10.65,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.39950289),
        dec: Angle.Degrees(+04.27426931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68284"},
        {"Hipparcos Number", "HIP 40136"},
        {"Geneva Identification System", "GEN# +1.00068284"},
        {"Smithsonian Astrophysical Observation", "SAO 116465"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.95664517),
        dec: Angle.Degrees(+04.27441582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177702"},
        {"Hipparcos Number", "HIP 93764"},
        {"Geneva Identification System", "GEN# +1.00177702"},
        {"Smithsonian Astrophysical Observation", "SAO 124254"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.42908002),
        dec: Angle.Degrees(+04.27850250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57530",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57530"},
    },
    visualMagnitude: 11.13,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.87098052),
        dec: Angle.Degrees(+04.27878685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59697",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59697"},
        {"Smithsonian Astrophysical Observation", "SAO 119283"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.62911647),
        dec: Angle.Degrees(+04.27970986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205910"},
        {"Hipparcos Number", "HIP 106838"},
        {"Smithsonian Astrophysical Observation", "SAO 126950"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.59778103),
        dec: Angle.Degrees(+04.28068334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28190"},
        {"Hipparcos Number", "HIP 20778"},
        {"Smithsonian Astrophysical Observation", "SAO 111828"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.76463350),
        dec: Angle.Degrees(+04.28098431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43518",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43518"},
        {"Fundamental Katalog 5th Edition", "FK5 4792"},
        {"Smithsonian Astrophysical Observation", "SAO 117206"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.95369345),
        dec: Angle.Degrees(+04.28140481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47812",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47812"},
    },
    visualMagnitude: 10.96,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.20091608),
        dec: Angle.Degrees(+04.28170347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211115"},
        {"Hipparcos Number", "HIP 109837"},
        {"Smithsonian Astrophysical Observation", "SAO 127404"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.69551178),
        dec: Angle.Degrees(+04.28243044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43317"},
        {"Hipparcos Number", "HIP 29739"},
        {"Celescope Catalog", "CEL 1151"},
        {"Fundamental Katalog 5th Edition", "FK5 2478"},
        {"Geneva Identification System", "GEN# +1.00043317"},
        {"Smithsonian Astrophysical Observation", "SAO 113653"},
        {"Wilson Evans Batten Catalogue", "WEB 5869"},
    },
    visualMagnitude: 6.63,
    bvColour: -0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.94590033),
        dec: Angle.Degrees(+04.28364625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83590"},
        {"Hipparcos Number", "HIP 47415"},
        {"Smithsonian Astrophysical Observation", "SAO 117832"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.92470024),
        dec: Angle.Degrees(+04.28456300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187899"},
        {"Hipparcos Number", "HIP 97791"},
        {"Smithsonian Astrophysical Observation", "SAO 125157"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.07873260),
        dec: Angle.Degrees(+04.28581338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126052"},
        {"Hipparcos Number", "HIP 70299"},
        {"Smithsonian Astrophysical Observation", "SAO 120422"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.75641662),
        dec: Angle.Degrees(+04.28599012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13624"},
        {"Hipparcos Number", "HIP 10327"},
        {"Geneva Identification System", "GEN# +1.00013624"},
        {"Smithsonian Astrophysical Observation", "SAO 110409"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.26025217),
        dec: Angle.Degrees(+04.28619697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117611"},
        {"Hipparcos Number", "HIP 65959"},
        {"Smithsonian Astrophysical Observation", "SAO 119977"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.85165143),
        dec: Angle.Degrees(+04.28695646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109840"},
        {"Hipparcos Number", "HIP 61628"},
        {"Smithsonian Astrophysical Observation", "SAO 119502"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.46600133),
        dec: Angle.Degrees(+04.28868321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125660"},
        {"Hipparcos Number", "HIP 70110"},
        {"Geneva Identification System", "GEN# +1.00125660"},
        {"Smithsonian Astrophysical Observation", "SAO 120409"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.19552147),
        dec: Angle.Degrees(+04.28963062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80444"},
        {"Hipparcos Number", "HIP 45761"},
        {"Smithsonian Astrophysical Observation", "SAO 117593"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.97129602),
        dec: Angle.Degrees(+04.29030028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110468"},
        {"Hipparcos Number", "HIP 61991"},
        {"Smithsonian Astrophysical Observation", "SAO 119542"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.56764667),
        dec: Angle.Degrees(+04.29258931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215977"},
        {"Hipparcos Number", "HIP 112658"},
        {"Geneva Identification System", "GEN# +1.00215977"},
        {"Smithsonian Astrophysical Observation", "SAO 127779"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.23379773),
        dec: Angle.Degrees(+04.29294846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103569",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14499 AB"},
        {"Henry Draper", "HD 199766"},
        {"Hipparcos Number", "HIP 103569"},
        {"Geneva Identification System", "GEN# +1.00199766"},
        {"Smithsonian Astrophysical Observation", "SAO 126428"},
        {"Wilson Evans Batten Catalogue", "WEB 18843"},
    },
    visualMagnitude: 5.30,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.76892895),
        dec: Angle.Degrees(+04.29384672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -150.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3228"},
        {"Hipparcos Number", "HIP 2781"},
        {"Geneva Identification System", "GEN# +1.00003228"},
        {"Smithsonian Astrophysical Observation", "SAO 109297"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.86928976),
        dec: Angle.Degrees(+04.29466823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103571",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14499 C"},
        {"Henry Draper", "HD 199766C"},
        {"Hipparcos Number", "HIP 103571"},
        {"Geneva Identification System", "GEN# +1.00199766C"},
        {"Smithsonian Astrophysical Observation", "SAO 126429"},
        {"Wilson Evans Batten Catalogue", "WEB 18845"},
    },
    visualMagnitude: 5.24,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.77157032),
        dec: Angle.Degrees(+04.29497561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -150.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97660"},
        {"Hipparcos Number", "HIP 54886"},
        {"Smithsonian Astrophysical Observation", "SAO 118737"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.57666984),
        dec: Angle.Degrees(+04.29604349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171089"},
        {"Hipparcos Number", "HIP 90910"},
        {"Geneva Identification System", "GEN# +1.00171089"},
        {"Smithsonian Astrophysical Observation", "SAO 123619"},
        {"Wilson Evans Batten Catalogue", "WEB 15590"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.796,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.16063939),
        dec: Angle.Degrees(+04.29641692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5655"},
        {"Hipparcos Number", "HIP 4557"},
        {"Geneva Identification System", "GEN# +1.00005655"},
        {"Smithsonian Astrophysical Observation", "SAO 109564"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.57832961),
        dec: Angle.Degrees(+04.29661180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124460"},
        {"Hipparcos Number", "HIP 69498"},
        {"Geneva Identification System", "GEN# +1.00124460"},
        {"Smithsonian Astrophysical Observation", "SAO 120351"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.42500757),
        dec: Angle.Degrees(+04.29674782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26092"},
        {"Hipparcos Number", "HIP 19280"},
        {"Smithsonian Astrophysical Observation", "SAO 111616"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.97286855),
        dec: Angle.Degrees(+04.29733912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141207"},
        {"Hipparcos Number", "HIP 77384"},
        {"Smithsonian Astrophysical Observation", "SAO 121193"},
        {"Wilson Evans Batten Catalogue", "WEB 13105"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.95138355),
        dec: Angle.Degrees(+04.29835727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89775"},
        {"Hipparcos Number", "HIP 50749"},
        {"Smithsonian Astrophysical Observation", "SAO 118252"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.43344235),
        dec: Angle.Degrees(+04.30015064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20203"},
        {"Hipparcos Number", "HIP 15115"},
        {"Fundamental Katalog 5th Edition", "FK5 4298"},
        {"Smithsonian Astrophysical Observation", "SAO 111071"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.73205098),
        dec: Angle.Degrees(+04.30019590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92857"},
        {"Hipparcos Number", "HIP 52455"},
        {"Geneva Identification System", "GEN# +1.00092857"},
        {"Smithsonian Astrophysical Observation", "SAO 118451"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.85048944),
        dec: Angle.Degrees(+04.30180567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188653"},
        {"Hipparcos Number", "HIP 98096"},
        {"Geneva Identification System", "GEN# +1.00188653"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.712,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.03716445),
        dec: Angle.Degrees(+04.30490550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -128.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -158.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59321",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59321"},
        {"Geneva Identification System", "GEN# +0.00502592"},
        {"Smithsonian Astrophysical Observation", "SAO 119251"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.54841658),
        dec: Angle.Degrees(+04.30872260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -332.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184571"},
        {"Hipparcos Number", "HIP 96318"},
        {"Geneva Identification System", "GEN# +1.00184571"},
        {"Smithsonian Astrophysical Observation", "SAO 124817"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.75758690),
        dec: Angle.Degrees(+04.31139574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208144"},
        {"Hipparcos Number", "HIP 108112"},
        {"Geneva Identification System", "GEN# +1.00208144"},
        {"Smithsonian Astrophysical Observation", "SAO 127145"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.55943035),
        dec: Angle.Degrees(+04.31158906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62787"},
        {"Hipparcos Number", "HIP 37883"},
        {"Smithsonian Astrophysical Observation", "SAO 115895"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.46873388),
        dec: Angle.Degrees(+04.31165148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9855"},
        {"Hipparcos Number", "HIP 7476"},
        {"Fundamental Katalog 5th Edition", "FK5 4145"},
        {"Smithsonian Astrophysical Observation", "SAO 110004"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.07058909),
        dec: Angle.Degrees(+04.31432409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93878"},
        {"Hipparcos Number", "HIP 52985"},
        {"Smithsonian Astrophysical Observation", "SAO 118524"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.58030710),
        dec: Angle.Degrees(+04.31494952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116662",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16892 AB"},
        {"Hipparcos Number", "HIP 116662"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.62715947),
        dec: Angle.Degrees(+04.31668198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26064"},
        {"Hipparcos Number", "HIP 19266"},
        {"Smithsonian Astrophysical Observation", "SAO 111613"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.93960207),
        dec: Angle.Degrees(+04.31970087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 241659"},
        {"Hipparcos Number", "HIP 24289"},
        {"Geneva Identification System", "GEN# +1.00241659"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.18815523),
        dec: Angle.Degrees(+04.32128764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 229.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134883"},
        {"Hipparcos Number", "HIP 74390"},
        {"Smithsonian Astrophysical Observation", "SAO 120888"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.04745190),
        dec: Angle.Degrees(+04.32232957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98156"},
        {"Hipparcos Number", "HIP 55158"},
        {"Geneva Identification System", "GEN# +1.00098156"},
        {"Smithsonian Astrophysical Observation", "SAO 118765"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.39605317),
        dec: Angle.Degrees(+04.32296229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56724",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56724"},
        {"Smithsonian Astrophysical Observation", "SAO 118958"},
    },
    visualMagnitude: 9.37,
    bvColour: 1.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.45020605),
        dec: Angle.Degrees(+04.32329971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8051",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8051"},
        {"Geneva Identification System", "GEN# +9.80003014"},
        {"Geneva Identification System 2", "GEN# +6.10010070"},
        {"Wilson Evans Batten Catalogue", "WEB 1724"},
    },
    visualMagnitude: 10.93,
    bvColour: 1.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.83510906),
        dec: Angle.Degrees(+04.32351508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -420.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -763.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19449",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19449"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.47557368),
        dec: Angle.Degrees(+04.32362602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9880",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9880"},
    },
    visualMagnitude: 12.25,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.78700572),
        dec: Angle.Degrees(+04.32462269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67252",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67252"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.787,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.76327606),
        dec: Angle.Degrees(+04.32846922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107990"},
        {"Hipparcos Number", "HIP 60533"},
        {"Smithsonian Astrophysical Observation", "SAO 119378"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.13572254),
        dec: Angle.Degrees(+04.33122549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213342"},
        {"Hipparcos Number", "HIP 111124"},
        {"Smithsonian Astrophysical Observation", "SAO 127563"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.66858477),
        dec: Angle.Degrees(+04.33182368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45911"},
        {"Hipparcos Number", "HIP 31015"},
        {"Geneva Identification System", "GEN# +1.00045911J"},
        {"Smithsonian Astrophysical Observation", "SAO 113973"},
        {"Wilson Evans Batten Catalogue", "WEB 6175"},
    },
    visualMagnitude: 7.35,
    bvColour: -0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.62173606),
        dec: Angle.Degrees(+04.33245609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161186"},
        {"Hipparcos Number", "HIP 86779"},
        {"Smithsonian Astrophysical Observation", "SAO 122679"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.98663192),
        dec: Angle.Degrees(+04.33291067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63435"},
        {"Hipparcos Number", "HIP 38140"},
        {"Geneva Identification System", "GEN# +1.00063435"},
        {"Smithsonian Astrophysical Observation", "SAO 115966"},
        {"Wilson Evans Batten Catalogue", "WEB 7517"},
    },
    visualMagnitude: 6.55,
    bvColour: 0.786,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.24579975),
        dec: Angle.Degrees(+04.33370373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142683"},
        {"Hipparcos Number", "HIP 78011"},
        {"Smithsonian Astrophysical Observation", "SAO 121268"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.94666050),
        dec: Angle.Degrees(+04.33415987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74393"},
        {"Hipparcos Number", "HIP 42854"},
        {"Geneva Identification System", "GEN# +1.00074393"},
        {"Smithsonian Astrophysical Observation", "SAO 117069"},
        {"Wilson Evans Batten Catalogue", "WEB 8281"},
    },
    visualMagnitude: 6.37,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.99911135),
        dec: Angle.Degrees(+04.33457298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132796"},
        {"Hipparcos Number", "HIP 73466"},
        {"Smithsonian Astrophysical Observation", "SAO 120793"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.22805086),
        dec: Angle.Degrees(+04.33558350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160233"},
        {"Hipparcos Number", "HIP 86349"},
        {"Geneva Identification System", "GEN# +1.00160233"},
        {"Smithsonian Astrophysical Observation", "SAO 122594"},
        {"Wilson Evans Batten Catalogue", "WEB 14569"},
    },
    visualMagnitude: 9.10,
    bvColour: -0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.66929928),
        dec: Angle.Degrees(+04.33602555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20410",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20410"},
    },
    visualMagnitude: 11.94,
    bvColour: 1.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.55489799),
        dec: Angle.Degrees(+04.33760645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -192.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2391",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2391"},
        {"Geneva Identification System", "GEN# +6.20156016"},
    },
    visualMagnitude: 12.25,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.62177068),
        dec: Angle.Degrees(+04.33904103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38237"},
        {"Hipparcos Number", "HIP 27076"},
        {"Smithsonian Astrophysical Observation", "SAO 113092"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.12751577),
        dec: Angle.Degrees(+04.33919861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220762"},
        {"Hipparcos Number", "HIP 115692"},
        {"Geneva Identification System", "GEN# +1.00220762"},
        {"Smithsonian Astrophysical Observation", "SAO 128180"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.58755660),
        dec: Angle.Degrees(+04.33951937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103987"},
        {"Hipparcos Number", "HIP 58403"},
        {"Smithsonian Astrophysical Observation", "SAO 119142"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.62638100),
        dec: Angle.Degrees(+04.34025841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75109"},
        {"Hipparcos Number", "HIP 43211"},
        {"Smithsonian Astrophysical Observation", "SAO 117137"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.03837812),
        dec: Angle.Degrees(+04.34032442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52013",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52013"},
    },
    visualMagnitude: 10.91,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.40174012),
        dec: Angle.Degrees(+04.34196916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221574"},
        {"Hipparcos Number", "HIP 116240"},
        {"Smithsonian Astrophysical Observation", "SAO 128244"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.29598908),
        dec: Angle.Degrees(+04.34230857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85217"},
        {"Hipparcos Number", "HIP 48273"},
        {"Geneva Identification System", "GEN# +1.00085217"},
        {"Smithsonian Astrophysical Observation", "SAO 117937"},
        {"Wilson Evans Batten Catalogue", "WEB 9005"},
    },
    visualMagnitude: 6.24,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.62570398),
        dec: Angle.Degrees(+04.34377417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -150.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203440"},
        {"Hipparcos Number", "HIP 105500"},
        {"Fundamental Katalog 5th Edition", "FK5 5884"},
        {"Smithsonian Astrophysical Observation", "SAO 126735"},
    },
    visualMagnitude: 6.69,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.50709702),
        dec: Angle.Degrees(+04.34562578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137394"},
        {"Hipparcos Number", "HIP 75524"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.43844332),
        dec: Angle.Degrees(+04.34696349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183937"},
        {"Hipparcos Number", "HIP 96054"},
        {"Smithsonian Astrophysical Observation", "SAO 124739"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.96407389),
        dec: Angle.Degrees(+04.34829550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71517",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71517"},
    },
    visualMagnitude: 10.46,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.39391794),
        dec: Angle.Degrees(+04.34899430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71497",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71497"},
    },
    visualMagnitude: 10.59,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.32671018),
        dec: Angle.Degrees(+04.34909374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -232.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -129.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216842"},
        {"Hipparcos Number", "HIP 113275"},
        {"Smithsonian Astrophysical Observation", "SAO 127848"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.749,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.06145957),
        dec: Angle.Degrees(+04.35042812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130306"},
        {"Hipparcos Number", "HIP 72321"},
        {"Geneva Identification System", "GEN# +1.00130306"},
        {"Smithsonian Astrophysical Observation", "SAO 120665"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.84177309),
        dec: Angle.Degrees(+04.35184951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18883"},
        {"Hipparcos Number", "HIP 14143"},
        {"Geneva Identification System", "GEN# +1.00018883"},
        {"Smithsonian Astrophysical Observation", "SAO 110921"},
        {"Wilson Evans Batten Catalogue", "WEB 2782"},
    },
    visualMagnitude: 5.62,
    bvColour: -0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.59378383),
        dec: Angle.Degrees(+04.35287042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95191"},
        {"Hipparcos Number", "HIP 53730"},
        {"Smithsonian Astrophysical Observation", "SAO 118606"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.89448963),
        dec: Angle.Degrees(+04.35384839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168501"},
        {"Hipparcos Number", "HIP 89833"},
        {"Geneva Identification System", "GEN# +1.00168501"},
        {"Smithsonian Astrophysical Observation", "SAO 123366"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.98093856),
        dec: Angle.Degrees(+04.35395218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117102",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117102"},
    },
    visualMagnitude: 10.88,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.09468522),
        dec: Angle.Degrees(+04.35475807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21555"},
        {"Hipparcos Number", "HIP 16201"},
        {"Geneva Identification System", "GEN# +1.00021555"},
        {"Smithsonian Astrophysical Observation", "SAO 111212"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.17929547),
        dec: Angle.Degrees(+04.35713624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74944"},
        {"Hipparcos Number", "HIP 43136"},
        {"Smithsonian Astrophysical Observation", "SAO 117119"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.79360016),
        dec: Angle.Degrees(+04.35800085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59585"},
        {"Hipparcos Number", "HIP 36518"},
        {"Smithsonian Astrophysical Observation", "SAO 115541"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.68892903),
        dec: Angle.Degrees(+04.35820745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113079"},
        {"Hipparcos Number", "HIP 63531"},
        {"Celescope Catalog", "CEL 4191"},
        {"Geneva Identification System", "GEN# +1.00113079"},
        {"Smithsonian Astrophysical Observation", "SAO 119717"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.28387532),
        dec: Angle.Degrees(+04.35863676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217247"},
        {"Hipparcos Number", "HIP 113513"},
        {"Geneva Identification System", "GEN# +1.00217247"},
        {"Smithsonian Astrophysical Observation", "SAO 127880"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.82863070),
        dec: Angle.Degrees(+04.35871157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49063"},
        {"Hipparcos Number", "HIP 32478"},
        {"Geneva Identification System", "GEN# +1.00049063"},
        {"Smithsonian Astrophysical Observation", "SAO 114397"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.68082671),
        dec: Angle.Degrees(+04.35969851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30234"},
        {"Hipparcos Number", "HIP 22146"},
        {"Fundamental Katalog 5th Edition", "FK5 4431"},
        {"Smithsonian Astrophysical Observation", "SAO 112051"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.48441100),
        dec: Angle.Degrees(+04.36001145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110898"},
        {"Hipparcos Number", "HIP 62240"},
        {"Geneva Identification System", "GEN# +1.00110898"},
        {"Smithsonian Astrophysical Observation", "SAO 119571"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.34692620),
        dec: Angle.Degrees(+04.36050811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -225.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10258",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10258"},
        {"Smithsonian Astrophysical Observation", "SAO 110399"},
    },
    visualMagnitude: 9.70,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.99193898),
        dec: Angle.Degrees(+04.36179382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -146.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149787"},
        {"Hipparcos Number", "HIP 81351"},
        {"Smithsonian Astrophysical Observation", "SAO 121727"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.21155555),
        dec: Angle.Degrees(+04.36259816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186228"},
        {"Hipparcos Number", "HIP 97015"},
        {"Smithsonian Astrophysical Observation", "SAO 124977"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.76301576),
        dec: Angle.Degrees(+04.36363706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105634",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14933 AB"},
        {"Henry Draper", "HD 203701"},
        {"Hipparcos Number", "HIP 105634"},
        {"Smithsonian Astrophysical Observation", "SAO 126763"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.93156214),
        dec: Angle.Degrees(+04.36503395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80890"},
        {"Hipparcos Number", "HIP 45959"},
        {"Smithsonian Astrophysical Observation", "SAO 117629"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.59335932),
        dec: Angle.Degrees(+04.36563481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160823"},
        {"Hipparcos Number", "HIP 86611"},
        {"Geneva Identification System", "GEN# +1.00160823"},
        {"Smithsonian Astrophysical Observation", "SAO 122652"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.48267173),
        dec: Angle.Degrees(+04.36681907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164284"},
        {"Hipparcos Number", "HIP 88149"},
        {"Geneva Identification System", "GEN# +1.00164284"},
        {"Geneva Identification System 2", "GEN# +5.13590005"},
        {"Smithsonian Astrophysical Observation", "SAO 123005"},
        {"Wilson Evans Batten Catalogue", "WEB 14894"},
    },
    visualMagnitude: 4.79,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.06582324),
        dec: Angle.Degrees(+04.36864674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130951"},
        {"Hipparcos Number", "HIP 72619"},
        {"Smithsonian Astrophysical Observation", "SAO 120694"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.71635021),
        dec: Angle.Degrees(+04.37251551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28086"},
        {"Hipparcos Number", "HIP 20698"},
        {"Smithsonian Astrophysical Observation", "SAO 111814"},
    },
    visualMagnitude: 6.37,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.50556292),
        dec: Angle.Degrees(+04.37348976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162178"},
        {"Hipparcos Number", "HIP 87247"},
        {"Geneva Identification System", "GEN# +1.00162178"},
        {"Smithsonian Astrophysical Observation", "SAO 122796"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.39931814),
        dec: Angle.Degrees(+04.37670928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70280"},
        {"Hipparcos Number", "HIP 40933"},
        {"Smithsonian Astrophysical Observation", "SAO 116663"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.30374062),
        dec: Angle.Degrees(+04.37759225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68172"},
        {"Hipparcos Number", "HIP 40097"},
        {"Geneva Identification System", "GEN# +1.00068172"},
        {"Smithsonian Astrophysical Observation", "SAO 116453"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.86253319),
        dec: Angle.Degrees(+04.38047336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3167"},
        {"Hipparcos Number", "HIP 2736"},
        {"Smithsonian Astrophysical Observation", "SAO 109291"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.827,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.73942158),
        dec: Angle.Degrees(+04.38188851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -172.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175703"},
        {"Hipparcos Number", "HIP 92974"},
        {"Geneva Identification System", "GEN# +1.00175703"},
        {"Smithsonian Astrophysical Observation", "SAO 124076"},
    },
    visualMagnitude: 8.38,
    bvColour: 2.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.12474370),
        dec: Angle.Degrees(+04.38790098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12252"},
        {"Hipparcos Number", "HIP 9368"},
        {"Geneva Identification System", "GEN# +1.00012252"},
        {"Smithsonian Astrophysical Observation", "SAO 110272"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.09080104),
        dec: Angle.Degrees(+04.38949224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61933"},
        {"Hipparcos Number", "HIP 37500"},
        {"Smithsonian Astrophysical Observation", "SAO 115815"},
    },
    visualMagnitude: 8.69,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.44706247),
        dec: Angle.Degrees(+04.39079991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209472"},
        {"Hipparcos Number", "HIP 108901"},
        {"Geneva Identification System", "GEN# +1.00209472"},
        {"Smithsonian Astrophysical Observation", "SAO 127260"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.89775273),
        dec: Angle.Degrees(+04.39120939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7748"},
        {"Hipparcos Number", "HIP 6018"},
        {"Geneva Identification System", "GEN# +1.00007748"},
        {"Smithsonian Astrophysical Observation", "SAO 109786"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.33464867),
        dec: Angle.Degrees(+04.39197773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110785",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15935"},
        {"Aitken 2", "ADS 15935 A"},
        {"Henry Draper", "HD 212754"},
        {"Henry Draper 2", "HD 212754A"},
        {"Hipparcos Number", "HIP 110785"},
        {"Geneva Identification System", "GEN# +1.00212754"},
        {"Smithsonian Astrophysical Observation", "SAO 127529"},
        {"Wilson Evans Batten Catalogue", "WEB 19846"},
    },
    visualMagnitude: 5.76,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.65507484),
        dec: Angle.Degrees(+04.39363758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 286.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107662",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107662"},
        {"Smithsonian Astrophysical Observation", "SAO 127071"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.11481575),
        dec: Angle.Degrees(+04.39595158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60850",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8563 AB"},
        {"Henry Draper", "HD 108561"},
        {"Hipparcos Number", "HIP 60850"},
        {"Smithsonian Astrophysical Observation", "SAO 119420"},
        {"Wilson Evans Batten Catalogue", "WEB 10828"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.07684838),
        dec: Angle.Degrees(+04.39660230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3502"},
        {"Hipparcos Number", "HIP 3000"},
        {"Smithsonian Astrophysical Observation", "SAO 109330"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.53334289),
        dec: Angle.Degrees(+04.39681268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91201",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91201"},
        {"Geneva Identification System", "GEN# +0.00403804"},
    },
    visualMagnitude: 9.53,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.06639896),
        dec: Angle.Degrees(+04.39824642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42529",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42529"},
        {"Fundamental Katalog 5th Edition", "FK5 4778"},
        {"Smithsonian Astrophysical Observation", "SAO 117007"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.05628549),
        dec: Angle.Degrees(+04.39969253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188107"},
        {"Hipparcos Number", "HIP 97877"},
        {"Geneva Identification System", "GEN# +1.00188107"},
        {"Smithsonian Astrophysical Observation", "SAO 125182"},
        {"Wilson Evans Batten Catalogue", "WEB 17221"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.34416448),
        dec: Angle.Degrees(+04.40039286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116621"},
        {"Hipparcos Number", "HIP 65442"},
        {"Smithsonian Astrophysical Observation", "SAO 119916"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.17742189),
        dec: Angle.Degrees(+04.40203408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207202"},
        {"Hipparcos Number", "HIP 107568"},
        {"Smithsonian Astrophysical Observation", "SAO 127059"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.79305794),
        dec: Angle.Degrees(+04.40300209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41855"},
        {"Hipparcos Number", "HIP 29043"},
        {"Smithsonian Astrophysical Observation", "SAO 113479"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.91615529),
        dec: Angle.Degrees(+04.40379325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33636"},
        {"Hipparcos Number", "HIP 24205"},
        {"Geneva Identification System", "GEN# +1.00033636"},
        {"Smithsonian Astrophysical Observation", "SAO 112506"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.94309668),
        dec: Angle.Degrees(+04.40387325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 180.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -137.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69280",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9139 AB"},
        {"Henry Draper", "HD 124035"},
        {"Hipparcos Number", "HIP 69280"},
        {"Smithsonian Astrophysical Observation", "SAO 120329"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.73213252),
        dec: Angle.Degrees(+04.40454572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -135.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202510"},
        {"Hipparcos Number", "HIP 105011"},
        {"Geneva Identification System", "GEN# +1.00202510"},
        {"Smithsonian Astrophysical Observation", "SAO 126667"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.04128589),
        dec: Angle.Degrees(+04.40532957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5297",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 929 AB"},
        {"Henry Draper", "HD 6698"},
        {"Hipparcos Number", "HIP 5297"},
        {"Smithsonian Astrophysical Observation", "SAO 109692"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.94338709),
        dec: Angle.Degrees(+04.41445120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195533"},
        {"Hipparcos Number", "HIP 101279"},
        {"Geneva Identification System", "GEN# +1.00195533"},
        {"Renson", "Renson 54490"},
        {"Smithsonian Astrophysical Observation", "SAO 125900"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.93185822),
        dec: Angle.Degrees(+04.41571781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108849"},
        {"Hipparcos Number", "HIP 61022"},
        {"Geneva Identification System", "GEN# +1.00108849"},
        {"Smithsonian Astrophysical Observation", "SAO 119433"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.58765838),
        dec: Angle.Degrees(+04.41649854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108454"},
        {"Hipparcos Number", "HIP 60799"},
        {"Smithsonian Astrophysical Observation", "SAO 119410"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.91368084),
        dec: Angle.Degrees(+04.41750273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118510"},
        {"Hipparcos Number", "HIP 66446"},
        {"Fundamental Katalog 5th Edition", "FK5 5199"},
        {"Geneva Identification System", "GEN# +1.00118510"},
        {"Smithsonian Astrophysical Observation", "SAO 120035"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.31584878),
        dec: Angle.Degrees(+04.41755497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164759"},
        {"Hipparcos Number", "HIP 88353"},
        {"Cincinnati Publication", "Ci 18 2387"},
        {"Smithsonian Astrophysical Observation", "SAO 123055"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.866,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.63857642),
        dec: Angle.Degrees(+04.41909101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -128.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -245.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79238",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79238"},
    },
    visualMagnitude: 11.17,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.56958308),
        dec: Angle.Degrees(+04.41954962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12412",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12412"},
        {"Smithsonian Astrophysical Observation", "SAO 110668"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.94872856),
        dec: Angle.Degrees(+04.42091289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70806",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70806"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.20798508),
        dec: Angle.Degrees(+04.42140886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45151"},
        {"Hipparcos Number", "HIP 30606"},
        {"Celescope Catalog", "CEL 1230"},
        {"Geneva Identification System", "GEN# +1.00045151"},
        {"Smithsonian Astrophysical Observation", "SAO 113873"},
    },
    visualMagnitude: 7.89,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.49251971),
        dec: Angle.Degrees(+04.42148142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205735"},
        {"Hipparcos Number", "HIP 106731"},
        {"Smithsonian Astrophysical Observation", "SAO 126929"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.30125796),
        dec: Angle.Degrees(+04.42238884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39051"},
        {"Hipparcos Number", "HIP 27560"},
        {"Fundamental Katalog 5th Edition", "FK5 2439"},
        {"Geneva Identification System", "GEN# +1.00039051"},
        {"Smithsonian Astrophysical Observation", "SAO 113186"},
        {"Wilson Evans Batten Catalogue", "WEB 5411"},
    },
    visualMagnitude: 5.96,
    bvColour: 1.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.55441800),
        dec: Angle.Degrees(+04.42349901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11890",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11890"},
        {"Smithsonian Astrophysical Observation", "SAO 110611"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.33171872),
        dec: Angle.Degrees(+04.42469732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154931"},
        {"Hipparcos Number", "HIP 83863"},
        {"Geneva Identification System", "GEN# +1.00154931"},
        {"Smithsonian Astrophysical Observation", "SAO 122112"},
        {"Wilson Evans Batten Catalogue", "WEB 14175"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.08934981),
        dec: Angle.Degrees(+04.42498471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -202.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101196"},
        {"Hipparcos Number", "HIP 56808"},
        {"Smithsonian Astrophysical Observation", "SAO 118968"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.68581025),
        dec: Angle.Degrees(+04.42653206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143553"},
        {"Hipparcos Number", "HIP 78442"},
        {"Fundamental Katalog 5th Edition", "FK5 3262"},
        {"Geneva Identification System", "GEN# +1.00143553"},
        {"Smithsonian Astrophysical Observation", "SAO 121315"},
        {"Wilson Evans Batten Catalogue", "WEB 13261"},
    },
    visualMagnitude: 5.82,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.21316189),
        dec: Angle.Degrees(+04.42718026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 75.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12540",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2050 AB"},
        {"Henry Draper", "HD 16763"},
        {"Hipparcos Number", "HIP 12540"},
        {"Renson", "Renson 4230"},
        {"Smithsonian Astrophysical Observation", "SAO 110688"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.34002121),
        dec: Angle.Degrees(+04.42793018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104137",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104137"},
    },
    visualMagnitude: 12.13,
    bvColour: 1.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.48462631),
        dec: Angle.Degrees(+04.42842441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 135.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -169.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5629",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5629"},
    },
    visualMagnitude: 11.35,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.07156156),
        dec: Angle.Degrees(+04.42854084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7120"},
        {"Hipparcos Number", "HIP 5573"},
        {"Geneva Identification System", "GEN# +1.00007120"},
        {"Smithsonian Astrophysical Observation", "SAO 109720"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.86627320),
        dec: Angle.Degrees(+04.42936698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161750"},
        {"Hipparcos Number", "HIP 87048"},
        {"Geneva Identification System", "GEN# +1.00161750"},
        {"Smithsonian Astrophysical Observation", "SAO 122743"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.79160450),
        dec: Angle.Degrees(+04.42938809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11452",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1865 AB"},
        {"Henry Draper", "HD 15285"},
        {"Hipparcos Number", "HIP 11452"},
        {"Cincinnati Publication", "Ci 18 319"},
        {"Geneva Identification System", "GEN# +1.00015285"},
        {"Smithsonian Astrophysical Observation", "SAO 110540"},
        {"Wilson Evans Batten Catalogue", "WEB 2391"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.94087890),
        dec: Angle.Degrees(+04.43156925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 240.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98470"},
        {"Hipparcos Number", "HIP 55327"},
        {"Smithsonian Astrophysical Observation", "SAO 118793"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.94707234),
        dec: Angle.Degrees(+04.43171730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76632"},
        {"Hipparcos Number", "HIP 43988"},
        {"Smithsonian Astrophysical Observation", "SAO 117296"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.756,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.36884306),
        dec: Angle.Degrees(+04.43181564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -120.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111062",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15988 AB"},
        {"Henry Draper", "HD 213235"},
        {"Hipparcos Number", "HIP 111062"},
        {"Geneva Identification System", "GEN# +1.00213235"},
        {"Smithsonian Astrophysical Observation", "SAO 127551"},
        {"Wilson Evans Batten Catalogue", "WEB 19884"},
    },
    visualMagnitude: 5.51,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.49145207),
        dec: Angle.Degrees(+04.43205725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -151.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142329"},
        {"Hipparcos Number", "HIP 77860"},
        {"Smithsonian Astrophysical Observation", "SAO 121244"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.48300710),
        dec: Angle.Degrees(+04.43417250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166499"},
        {"Hipparcos Number", "HIP 89081"},
        {"Smithsonian Astrophysical Observation", "SAO 123217"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.70792802),
        dec: Angle.Degrees(+04.43424856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37591"},
        {"Hipparcos Number", "HIP 26644"},
        {"Celescope Catalog", "CEL 901"},
        {"Geneva Identification System", "GEN# +1.00037591"},
        {"Smithsonian Astrophysical Observation", "SAO 113012"},
    },
    visualMagnitude: 8.00,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.93849492),
        dec: Angle.Degrees(+04.43458815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6555",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6555"},
        {"Smithsonian Astrophysical Observation", "SAO 109863"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.06349050),
        dec: Angle.Degrees(+04.43461990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175516"},
        {"Hipparcos Number", "HIP 92888"},
        {"Geneva Identification System", "GEN# +1.00175516"},
        {"Smithsonian Astrophysical Observation", "SAO 124051"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.89173630),
        dec: Angle.Degrees(+04.43541671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23442"},
        {"Hipparcos Number", "HIP 17537"},
        {"Smithsonian Astrophysical Observation", "SAO 111395"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.32305296),
        dec: Angle.Degrees(+04.43787825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60503"},
        {"Hipparcos Number", "HIP 36884"},
        {"Smithsonian Astrophysical Observation", "SAO 115660"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.74793381),
        dec: Angle.Degrees(+04.43952080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17762"},
        {"Hipparcos Number", "HIP 13306"},
        {"Geneva Identification System", "GEN# +1.00017762"},
        {"Smithsonian Astrophysical Observation", "SAO 110786"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.80593911),
        dec: Angle.Degrees(+04.44046714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 121.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79555"},
        {"Hipparcos Number", "HIP 45383"},
        {"Cincinnati Publication", "Ci 18 1091"},
        {"Geneva Identification System", "GEN# +1.00079555"},
        {"Smithsonian Astrophysical Observation", "SAO 117534"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.72385240),
        dec: Angle.Degrees(+04.44289009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58432"},
        {"Hipparcos Number", "HIP 36049"},
        {"Smithsonian Astrophysical Observation", "SAO 115429"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.43889245),
        dec: Angle.Degrees(+04.44615658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13510",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13510"},
    },
    visualMagnitude: 11.57,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.50046508),
        dec: Angle.Degrees(+04.44831556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115779",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16763 AB"},
        {"Henry Draper", "HD 220889"},
        {"Hipparcos Number", "HIP 115779"},
        {"Smithsonian Astrophysical Observation", "SAO 128191"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.83728271),
        dec: Angle.Degrees(+04.45025634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52719",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52719"},
        {"Smithsonian Astrophysical Observation", "SAO 118489"},
    },
    visualMagnitude: 9.45,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.67367626),
        dec: Angle.Degrees(+04.45101872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152014"},
        {"Hipparcos Number", "HIP 82429"},
        {"Smithsonian Astrophysical Observation", "SAO 121900"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.68814043),
        dec: Angle.Degrees(+04.45151806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219638"},
        {"Hipparcos Number", "HIP 114983"},
        {"Smithsonian Astrophysical Observation", "SAO 128089"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.32803323),
        dec: Angle.Degrees(+04.45169993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133927"},
        {"Hipparcos Number", "HIP 73971"},
        {"Geneva Identification System", "GEN# +1.00133927"},
        {"Smithsonian Astrophysical Observation", "SAO 120843"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.74728853),
        dec: Angle.Degrees(+04.45464336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195104"},
        {"Hipparcos Number", "HIP 101059"},
        {"Geneva Identification System", "GEN# +1.00195104"},
        {"Smithsonian Astrophysical Observation", "SAO 125857"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.29869205),
        dec: Angle.Degrees(+04.45653529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60141",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60141"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.99642918),
        dec: Angle.Degrees(+04.45711935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -132.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214336"},
        {"Hipparcos Number", "HIP 111671"},
        {"Geneva Identification System", "GEN# +1.00214336"},
        {"Smithsonian Astrophysical Observation", "SAO 127637"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.756,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.33545548),
        dec: Angle.Degrees(+04.45841215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96680"},
        {"Hipparcos Number", "HIP 54440"},
        {"Geneva Identification System", "GEN# +1.00096680"},
        {"Smithsonian Astrophysical Observation", "SAO 118681"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.08416532),
        dec: Angle.Degrees(+04.45845857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77587"},
        {"Hipparcos Number", "HIP 44469"},
        {"Smithsonian Astrophysical Observation", "SAO 117380"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.90422446),
        dec: Angle.Degrees(+04.45894798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63798"},
        {"Hipparcos Number", "HIP 38303"},
        {"Geneva Identification System", "GEN# +1.00063798"},
        {"Smithsonian Astrophysical Observation", "SAO 116016"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.71294838),
        dec: Angle.Degrees(+04.45939601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217578"},
        {"Hipparcos Number", "HIP 113699"},
        {"Geneva Identification System", "GEN# +1.00217578"},
        {"Smithsonian Astrophysical Observation", "SAO 127907"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.41395464),
        dec: Angle.Degrees(+04.46140417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87991",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87991"},
        {"Geneva Identification System", "GEN# +0.00403562"},
        {"Wilson Evans Batten Catalogue", "WEB 14858"},
    },
    visualMagnitude: 9.80,
    bvColour: 1.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.60190714),
        dec: Angle.Degrees(+04.46161267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8864"},
        {"Hipparcos Number", "HIP 6800"},
        {"Smithsonian Astrophysical Observation", "SAO 109902"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.87281720),
        dec: Angle.Degrees(+04.46199176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79800",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79800"},
        {"Smithsonian Astrophysical Observation", "SAO 121473"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.29411826),
        dec: Angle.Degrees(+04.46347034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18855",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18855"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.63536511),
        dec: Angle.Degrees(+04.46443052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27571"},
        {"Hipparcos Number", "HIP 20321"},
        {"Smithsonian Astrophysical Observation", "SAO 111766"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.30201026),
        dec: Angle.Degrees(+04.46543808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40492"},
        {"Hipparcos Number", "HIP 28337"},
        {"Geneva Identification System", "GEN# +1.00040492"},
        {"Smithsonian Astrophysical Observation", "SAO 113325"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.81875138),
        dec: Angle.Degrees(+04.46589617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43539",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7055 AB"},
        {"Henry Draper", "HD 75768"},
        {"Hipparcos Number", "HIP 43539"},
        {"Smithsonian Astrophysical Observation", "SAO 117208"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.01416894),
        dec: Angle.Degrees(+04.46613849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223504"},
        {"Hipparcos Number", "HIP 117530"},
        {"Smithsonian Astrophysical Observation", "SAO 128410"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.858,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.53622303),
        dec: Angle.Degrees(+04.46694620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209275"},
        {"Hipparcos Number", "HIP 108769"},
        {"Smithsonian Astrophysical Observation", "SAO 127245"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.51069787),
        dec: Angle.Degrees(+04.46916765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78564",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78564"},
        {"Smithsonian Astrophysical Observation", "SAO 121329"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.62591948),
        dec: Angle.Degrees(+04.47062786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168931"},
        {"Hipparcos Number", "HIP 90022"},
        {"Smithsonian Astrophysical Observation", "SAO 123394"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.53555536),
        dec: Angle.Degrees(+04.47090045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109781",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109781"},
        {"Smithsonian Astrophysical Observation", "SAO 127397"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.54852741),
        dec: Angle.Degrees(+04.47132350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160312"},
        {"Hipparcos Number", "HIP 86387"},
        {"Geneva Identification System", "GEN# +1.00160312"},
        {"Smithsonian Astrophysical Observation", "SAO 122608"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.77739451),
        dec: Angle.Degrees(+04.47391053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22452"},
        {"Hipparcos Number", "HIP 16845"},
        {"Geneva Identification System", "GEN# +1.00022452"},
        {"Smithsonian Astrophysical Observation", "SAO 111289"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.19593719),
        dec: Angle.Degrees(+04.47437487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76465",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76465"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.24957341),
        dec: Angle.Degrees(+04.47723571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141795"},
        {"Hipparcos Number", "HIP 77622"},
        {"Fundamental Katalog 5th Edition", "FK5 588"},
        {"Geneva Identification System", "GEN# +1.00141795"},
        {"Renson", "Renson 40250"},
        {"Smithsonian Astrophysical Observation", "SAO 121218"},
        {"Wilson Evans Batten Catalogue", "WEB 13133"},
    },
    visualMagnitude: 3.71,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.70371344),
        dec: Angle.Degrees(+04.47757980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 127.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97891"},
        {"Hipparcos Number", "HIP 54998"},
        {"Geneva Identification System", "GEN# +1.00097891"},
        {"Smithsonian Astrophysical Observation", "SAO 118753"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.91235186),
        dec: Angle.Degrees(+04.47802942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34929"},
        {"Hipparcos Number", "HIP 24989"},
        {"Geneva Identification System", "GEN# +1.00034929"},
        {"Smithsonian Astrophysical Observation", "SAO 112657"},
    },
    visualMagnitude: 8.40,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.26353537),
        dec: Angle.Degrees(+04.47805912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3819"},
        {"Hipparcos Number", "HIP 3208"},
        {"Geneva Identification System", "GEN# +1.00003819"},
        {"Smithsonian Astrophysical Observation", "SAO 109365"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.20803083),
        dec: Angle.Degrees(+04.47836575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181366"},
        {"Hipparcos Number", "HIP 95026"},
        {"Smithsonian Astrophysical Observation", "SAO 124515"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.02582106),
        dec: Angle.Degrees(+04.48040868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88365",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88365"},
        {"Cincinnati Publication", "Ci 18 2392"},
    },
    visualMagnitude: 10.69,
    bvColour: 0.712,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.66251447),
        dec: Angle.Degrees(+04.48111043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -215.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117244"},
        {"Hipparcos Number", "HIP 65766"},
        {"Smithsonian Astrophysical Observation", "SAO 119947"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.25492179),
        dec: Angle.Degrees(+04.48129032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97503"},
        {"Hipparcos Number", "HIP 54810"},
        {"Cincinnati Publication", "Ci 18 1368"},
        {"Geneva Identification System", "GEN# +1.00097503"},
        {"Smithsonian Astrophysical Observation", "SAO 118726"},
        {"Wilson Evans Batten Catalogue", "WEB 9889"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.30591296),
        dec: Angle.Degrees(+04.48242437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -317.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191656"},
        {"Hipparcos Number", "HIP 99432"},
        {"Smithsonian Astrophysical Observation", "SAO 125528"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.72757097),
        dec: Angle.Degrees(+04.48323074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100194",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100194"},
    },
    visualMagnitude: 10.52,
    bvColour: 1.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.84446243),
        dec: Angle.Degrees(+04.48558004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64938"},
        {"Hipparcos Number", "HIP 38794"},
        {"Geneva Identification System", "GEN# +1.00064938"},
        {"Smithsonian Astrophysical Observation", "SAO 116145"},
        {"Wilson Evans Batten Catalogue", "WEB 7599"},
    },
    visualMagnitude: 6.16,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.09962936),
        dec: Angle.Degrees(+04.48558456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129470"},
        {"Hipparcos Number", "HIP 71915"},
        {"Smithsonian Astrophysical Observation", "SAO 120614"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.64541487),
        dec: Angle.Degrees(+04.48680451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162648"},
        {"Hipparcos Number", "HIP 87430"},
        {"Smithsonian Astrophysical Observation", "SAO 122846"},
        {"Wilson Evans Batten Catalogue", "WEB 14746"},
    },
    visualMagnitude: 6.70,
    bvColour: 1.736,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.00029372),
        dec: Angle.Degrees(+04.48729802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203457"},
        {"Hipparcos Number", "HIP 105512"},
        {"Smithsonian Astrophysical Observation", "SAO 126739"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.55380698),
        dec: Angle.Degrees(+04.48856834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101494",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101494"},
        {"Smithsonian Astrophysical Observation", "SAO 125963"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.51373009),
        dec: Angle.Degrees(+04.48966128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160141"},
        {"Hipparcos Number", "HIP 86316"},
        {"Smithsonian Astrophysical Observation", "SAO 122586"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.54671146),
        dec: Angle.Degrees(+04.49129527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127888"},
        {"Hipparcos Number", "HIP 71205"},
        {"Smithsonian Astrophysical Observation", "SAO 120528"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.42838222),
        dec: Angle.Degrees(+04.49447695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64409",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64409"},
        {"Smithsonian Astrophysical Observation", "SAO 119811"},
    },
    visualMagnitude: 9.63,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.01639283),
        dec: Angle.Degrees(+04.49452961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115254",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115254"},
        {"Smithsonian Astrophysical Observation", "SAO 128131"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.16524224),
        dec: Angle.Degrees(+04.49683367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46885"},
        {"Hipparcos Number", "HIP 31523"},
        {"Geneva Identification System", "GEN# +1.00046885"},
        {"Smithsonian Astrophysical Observation", "SAO 114115"},
        {"Wilson Evans Batten Catalogue", "WEB 6310"},
    },
    visualMagnitude: 6.55,
    bvColour: -0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.00044307),
        dec: Angle.Degrees(+04.49804766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35316"},
        {"Hipparcos Number", "HIP 25255"},
        {"Smithsonian Astrophysical Observation", "SAO 112717"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.02022286),
        dec: Angle.Degrees(+04.50029998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18345"},
        {"Hipparcos Number", "HIP 13756"},
        {"Fundamental Katalog 5th Edition", "FK5 2206"},
        {"Geneva Identification System", "GEN# +1.00018345"},
        {"Smithsonian Astrophysical Observation", "SAO 110865"},
        {"Wilson Evans Batten Catalogue", "WEB 2723"},
    },
    visualMagnitude: 6.15,
    bvColour: 1.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.26901296),
        dec: Angle.Degrees(+04.50097062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43070",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43070"},
        {"Smithsonian Astrophysical Observation", "SAO 117101"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.59567809),
        dec: Angle.Degrees(+04.50170032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10662",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10662"},
        {"Smithsonian Astrophysical Observation", "SAO 110450"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.30411343),
        dec: Angle.Degrees(+04.50344209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38118"},
        {"Hipparcos Number", "HIP 26986"},
        {"Smithsonian Astrophysical Observation", "SAO 113079"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.88841300),
        dec: Angle.Degrees(+04.50489591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215511"},
        {"Hipparcos Number", "HIP 112371"},
        {"Geneva Identification System", "GEN# +1.00215511"},
        {"Smithsonian Astrophysical Observation", "SAO 127739"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.40182937),
        dec: Angle.Degrees(+04.50600021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87973"},
        {"Hipparcos Number", "HIP 49692"},
        {"Smithsonian Astrophysical Observation", "SAO 118129"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.16315812),
        dec: Angle.Degrees(+04.50917041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43823"},
        {"Hipparcos Number", "HIP 29969"},
        {"Geneva Identification System", "GEN# +1.00043823"},
        {"Smithsonian Astrophysical Observation", "SAO 113709"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.794,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.63356030),
        dec: Angle.Degrees(+04.50975814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170699"},
        {"Hipparcos Number", "HIP 90728"},
        {"Geneva Identification System", "GEN# +1.00170699"},
        {"Smithsonian Astrophysical Observation", "SAO 123585"},
        {"Wilson Evans Batten Catalogue", "WEB 15540"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.67156048),
        dec: Angle.Degrees(+04.51084627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4352",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4352"},
        {"Smithsonian Astrophysical Observation", "SAO 109535"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.95111760),
        dec: Angle.Degrees(+04.51147009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55211",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55211"},
        {"Smithsonian Astrophysical Observation", "SAO 118772"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.59146787),
        dec: Angle.Degrees(+04.51147226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105307"},
        {"Hipparcos Number", "HIP 59134"},
        {"Smithsonian Astrophysical Observation", "SAO 119227"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.88680203),
        dec: Angle.Degrees(+04.51318690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28940",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28940"},
        {"Cincinnati Publication", "Ci 20 368"},
    },
    visualMagnitude: 10.88,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.62459470),
        dec: Angle.Degrees(+04.51339100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 153.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -788.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83085"},
        {"Hipparcos Number", "HIP 47111"},
        {"Smithsonian Astrophysical Observation", "SAO 117798"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.01838262),
        dec: Angle.Degrees(+04.51447192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65221"},
        {"Hipparcos Number", "HIP 38920"},
        {"Smithsonian Astrophysical Observation", "SAO 116176"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.46829905),
        dec: Angle.Degrees(+04.51718822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115104"},
        {"Hipparcos Number", "HIP 64645"},
        {"Smithsonian Astrophysical Observation", "SAO 119829"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.76209542),
        dec: Angle.Degrees(+04.51750521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210155"},
        {"Hipparcos Number", "HIP 109279"},
        {"Smithsonian Astrophysical Observation", "SAO 127312"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.07491282),
        dec: Angle.Degrees(+04.51795028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90194"},
        {"Hipparcos Number", "HIP 50983"},
        {"Smithsonian Astrophysical Observation", "SAO 118283"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.21682710),
        dec: Angle.Degrees(+04.51847166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7023"},
        {"Hipparcos Number", "HIP 5520"},
        {"Smithsonian Astrophysical Observation", "SAO 109717"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.67306901),
        dec: Angle.Degrees(+04.51997761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46485"},
        {"Hipparcos Number", "HIP 31303"},
        {"Geneva Identification System", "GEN# +2.22440387"},
        {"Smithsonian Astrophysical Observation", "SAO 114056"},
        {"Wilson Evans Batten Catalogue", "WEB 6258"},
        {"New General Catalogue", "NGC 2244 387"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.46232326),
        dec: Angle.Degrees(+04.52544787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106529"},
        {"Hipparcos Number", "HIP 59755"},
        {"Smithsonian Astrophysical Observation", "SAO 119285"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.80826472),
        dec: Angle.Degrees(+04.52557813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -125.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186935"},
        {"Hipparcos Number", "HIP 97342"},
        {"Geneva Identification System", "GEN# +1.00186935"},
        {"Smithsonian Astrophysical Observation", "SAO 125060"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.76073407),
        dec: Angle.Degrees(+04.52855241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174794"},
        {"Hipparcos Number", "HIP 92605"},
        {"Smithsonian Astrophysical Observation", "SAO 123994"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.04351200),
        dec: Angle.Degrees(+04.52893615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214546"},
        {"Hipparcos Number", "HIP 111807"},
        {"Fundamental Katalog 5th Edition", "FK5 3815"},
        {"Geneva Identification System", "GEN# +1.00214546"},
        {"Smithsonian Astrophysical Observation", "SAO 127658"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.70846246),
        dec: Angle.Degrees(+04.53021196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129922"},
        {"Hipparcos Number", "HIP 72126"},
        {"Smithsonian Astrophysical Observation", "SAO 120639"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.31102621),
        dec: Angle.Degrees(+04.53224289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -123.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 123.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77162",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9772 AB"},
        {"Henry Draper", "HD 140751"},
        {"Hipparcos Number", "HIP 77162"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.33421396),
        dec: Angle.Degrees(+04.53247385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103301",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14430 AB"},
        {"Henry Draper", "HD 199223"},
        {"Hipparcos Number", "HIP 103301"},
        {"Geneva Identification System", "GEN# +1.00199223"},
        {"Smithsonian Astrophysical Observation", "SAO 126373"},
        {"Wilson Evans Batten Catalogue", "WEB 18774"},
    },
    visualMagnitude: 6.04,
    bvColour: 0.824,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.91934351),
        dec: Angle.Degrees(+04.53269568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192029"},
        {"Hipparcos Number", "HIP 99600"},
        {"Smithsonian Astrophysical Observation", "SAO 125572"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.19113749),
        dec: Angle.Degrees(+04.53286244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85634"},
        {"Hipparcos Number", "HIP 48475"},
        {"Geneva Identification System", "GEN# +1.00085634"},
        {"Smithsonian Astrophysical Observation", "SAO 117969"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.29620068),
        dec: Angle.Degrees(+04.53356923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162810"},
        {"Hipparcos Number", "HIP 87507"},
        {"Smithsonian Astrophysical Observation", "SAO 122865"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.18797936),
        dec: Angle.Degrees(+04.53545627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107428"},
        {"Hipparcos Number", "HIP 60224"},
        {"Smithsonian Astrophysical Observation", "SAO 119344"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.25075248),
        dec: Angle.Degrees(+04.53787792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92413"},
        {"Hipparcos Number", "HIP 52238"},
        {"Smithsonian Astrophysical Observation", "SAO 118425"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.08599238),
        dec: Angle.Degrees(+04.54011354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69109",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69109"},
        {"Cincinnati Publication", "Ci 20 834"},
        {"Geneva Identification System", "GEN# +9.80064048"},
    },
    visualMagnitude: 11.07,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.20921779),
        dec: Angle.Degrees(+04.54098479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 290.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -397.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25275"},
        {"Hipparcos Number", "HIP 18761"},
        {"Smithsonian Astrophysical Observation", "SAO 111562"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.27816384),
        dec: Angle.Degrees(+04.54129187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66050"},
        {"Hipparcos Number", "HIP 39280"},
        {"Smithsonian Astrophysical Observation", "SAO 116254"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.48170066),
        dec: Angle.Degrees(+04.54145904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33037"},
        {"Hipparcos Number", "HIP 23846"},
        {"Smithsonian Astrophysical Observation", "SAO 112438"},
    },
    visualMagnitude: 7.98,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.89956680),
        dec: Angle.Degrees(+04.54178148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27089"},
        {"Hipparcos Number", "HIP 19971"},
        {"Smithsonian Astrophysical Observation", "SAO 111716"},
        {"Wilson Evans Batten Catalogue", "WEB 3809"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.22874618),
        dec: Angle.Degrees(+04.54268757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 170.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177514"},
        {"Hipparcos Number", "HIP 93706"},
        {"Smithsonian Astrophysical Observation", "SAO 124237"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.22025457),
        dec: Angle.Degrees(+04.54279959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43083"},
        {"Hipparcos Number", "HIP 29618"},
        {"Smithsonian Astrophysical Observation", "SAO 113618"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.922,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.62543341),
        dec: Angle.Degrees(+04.54310368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7055",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7055"},
        {"Smithsonian Astrophysical Observation", "SAO 109938"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.73989057),
        dec: Angle.Degrees(+04.54352657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56235",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56235"},
    },
    visualMagnitude: 9.66,
    bvColour: 1.852,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.92048268),
        dec: Angle.Degrees(+04.54434812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130007"},
        {"Hipparcos Number", "HIP 72170"},
        {"Smithsonian Astrophysical Observation", "SAO 120645"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.43105500),
        dec: Angle.Degrees(+04.54483106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 264865"},
        {"Hipparcos Number", "HIP 32802"},
        {"Smithsonian Astrophysical Observation", "SAO 114490"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.57302773),
        dec: Angle.Degrees(+04.54657367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120437"},
        {"Hipparcos Number", "HIP 67442"},
        {"Geneva Identification System", "GEN# +1.00120437"},
        {"Smithsonian Astrophysical Observation", "SAO 120125"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.32944309),
        dec: Angle.Degrees(+04.54679059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136139"},
        {"Hipparcos Number", "HIP 74951"},
        {"Geneva Identification System", "GEN# +1.00136139"},
        {"Smithsonian Astrophysical Observation", "SAO 120943"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.73974921),
        dec: Angle.Degrees(+04.55064107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43888"},
        {"Hipparcos Number", "HIP 30000"},
        {"Smithsonian Astrophysical Observation", "SAO 113714"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.71668395),
        dec: Angle.Degrees(+04.55412042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59563"},
        {"Hipparcos Number", "HIP 36503"},
        {"Smithsonian Astrophysical Observation", "SAO 115535"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.65141028),
        dec: Angle.Degrees(+04.55433061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172675"},
        {"Hipparcos Number", "HIP 91645"},
        {"Geneva Identification System", "GEN# +1.00172675"},
        {"Smithsonian Astrophysical Observation", "SAO 123808"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.33465893),
        dec: Angle.Degrees(+04.55825375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3929",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3929"},
    },
    visualMagnitude: 10.56,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.61191869),
        dec: Angle.Degrees(+04.55911183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83757",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83757"},
    },
    visualMagnitude: 10.76,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.77224462),
        dec: Angle.Degrees(+04.56023575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -142.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58370"},
        {"Hipparcos Number", "HIP 36031"},
        {"Smithsonian Astrophysical Observation", "SAO 115423"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.36767591),
        dec: Angle.Degrees(+04.56212615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205129"},
        {"Hipparcos Number", "HIP 106412"},
        {"Smithsonian Astrophysical Observation", "SAO 126884"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.29606724),
        dec: Angle.Degrees(+04.56317861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138217"},
        {"Hipparcos Number", "HIP 75936"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.64686752),
        dec: Angle.Degrees(+04.56453150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86742",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Cebalrai"},
        {"Henry Draper", "HD 161096"},
        {"Hipparcos Number", "HIP 86742"},
        {"Fundamental Katalog 5th Edition", "FK5 665"},
        {"Geneva Identification System", "GEN# +1.00161096"},
        {"Smithsonian Astrophysical Observation", "SAO 122671"},
        {"Wilson Evans Batten Catalogue", "WEB 14628"},
    },
    visualMagnitude: 2.76,
    bvColour: 1.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.86823714),
        dec: Angle.Degrees(+04.56691684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 158.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32073"},
        {"Hipparcos Number", "HIP 23310"},
        {"Smithsonian Astrophysical Observation", "SAO 112308"},
    },
    visualMagnitude: 6.69,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.19667837),
        dec: Angle.Degrees(+04.56772541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132525"},
        {"Hipparcos Number", "HIP 73350"},
        {"Geneva Identification System", "GEN# +1.00132525"},
        {"Smithsonian Astrophysical Observation", "SAO 120774"},
        {"Wilson Evans Batten Catalogue", "WEB 12560"},
    },
    visualMagnitude: 5.91,
    bvColour: 1.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.84631129),
        dec: Angle.Degrees(+04.56777277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165477"},
        {"Hipparcos Number", "HIP 88661"},
        {"Geneva Identification System", "GEN# +1.00165477A"},
        {"Smithsonian Astrophysical Observation", "SAO 123119"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.51654106),
        dec: Angle.Degrees(+04.56835860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90293"},
        {"Hipparcos Number", "HIP 51032"},
        {"Smithsonian Astrophysical Observation", "SAO 118293"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.39051756),
        dec: Angle.Degrees(+04.57190784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34112",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5747 A"},
        {"Henry Draper", "HD 53202"},
        {"Hipparcos Number", "HIP 34112"},
        {"Smithsonian Astrophysical Observation", "SAO 114866"},
    },
    visualMagnitude: 7.46,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.09435664),
        dec: Angle.Degrees(+04.57211099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101146",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101146"},
        {"Geneva Identification System", "GEN# +9.80024017"},
    },
    visualMagnitude: 11.47,
    bvColour: 0.874,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.53586948),
        dec: Angle.Degrees(+04.57259092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -205.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -425.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21109",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Hoggar"},
        {"Henry Draper", "HD 28678"},
        {"Hipparcos Number", "HIP 21109"},
        {"Smithsonian Astrophysical Observation", "SAO 111871"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.85605428),
        dec: Angle.Degrees(+04.57531865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214786"},
        {"Hipparcos Number", "HIP 111938"},
        {"Smithsonian Astrophysical Observation", "SAO 127678"},
    },
    visualMagnitude: 6.81,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.11314855),
        dec: Angle.Degrees(+04.57531925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 106.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148668"},
        {"Hipparcos Number", "HIP 80777"},
        {"Geneva Identification System", "GEN# +1.00148668"},
        {"Smithsonian Astrophysical Observation", "SAO 121641"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.39444491),
        dec: Angle.Degrees(+04.57600227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55680"},
        {"Hipparcos Number", "HIP 34965"},
        {"Fundamental Katalog 5th Edition", "FK5 4652"},
        {"Geneva Identification System", "GEN# +1.00055680"},
        {"Smithsonian Astrophysical Observation", "SAO 115108"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.51374365),
        dec: Angle.Degrees(+04.57800323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74156"},
        {"Hipparcos Number", "HIP 42723"},
        {"Geneva Identification System", "GEN# +1.00074156"},
        {"Smithsonian Astrophysical Observation", "SAO 117040"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.60461506),
        dec: Angle.Degrees(+04.57858485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -200.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99894",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Chechia"},
        {"Henry Draper", "HD 192699"},
        {"Hipparcos Number", "HIP 99894"},
        {"Fundamental Katalog 5th Edition", "FK5 3623"},
        {"Geneva Identification System", "GEN# +1.00192699"},
        {"Smithsonian Astrophysical Observation", "SAO 125628"},
    },
    visualMagnitude: 6.44,
    bvColour: 0.867,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.02511695),
        dec: Angle.Degrees(+04.58091965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32719"},
        {"Hipparcos Number", "HIP 23681"},
        {"Smithsonian Astrophysical Observation", "SAO 112405"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.35164295),
        dec: Angle.Degrees(+04.58170132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184489"},
        {"Hipparcos Number", "HIP 96285"},
        {"Cincinnati Publication", "Ci 18 2556"},
        {"Cincinnati Publication 2", "Ci 20 1159"},
        {"Geneva Identification System", "GEN# +1.00184489"},
        {"Smithsonian Astrophysical Observation", "SAO 124806"},
        {"Wilson Evans Batten Catalogue", "WEB 16876"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.66472043),
        dec: Angle.Degrees(+04.58175785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 524.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 312.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18831",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18831"},
        {"Smithsonian Astrophysical Observation", "SAO 111571"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.55322372),
        dec: Angle.Degrees(+04.58391877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64958",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64958"},
    },
    visualMagnitude: 10.71,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.72529491),
        dec: Angle.Degrees(+04.58434619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195126"},
        {"Hipparcos Number", "HIP 101069"},
        {"Smithsonian Astrophysical Observation", "SAO 125859"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.33718196),
        dec: Angle.Degrees(+04.58840796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147641"},
        {"Hipparcos Number", "HIP 80252"},
        {"Smithsonian Astrophysical Observation", "SAO 121556"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.75659328),
        dec: Angle.Degrees(+04.59028263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101621"},
        {"Hipparcos Number", "HIP 57034"},
        {"Geneva Identification System", "GEN# +1.00101621"},
        {"Smithsonian Astrophysical Observation", "SAO 118995"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.40923196),
        dec: Angle.Degrees(+04.59055300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12195"},
        {"Hipparcos Number", "HIP 9330"},
        {"Geneva Identification System", "GEN# +1.00012195"},
        {"Smithsonian Astrophysical Observation", "SAO 110262"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.95343261),
        dec: Angle.Degrees(+04.59189832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171264"},
        {"Hipparcos Number", "HIP 90993"},
        {"Geneva Identification System", "GEN# +1.00171264"},
        {"Smithsonian Astrophysical Observation", "SAO 123642"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.41947322),
        dec: Angle.Degrees(+04.59238320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30419",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5012 A"},
        {"Henry Draper", "HD 44769"},
        {"Hipparcos Number", "HIP 30419"},
        {"Celescope Catalog", "CEL 1212"},
        {"Fundamental Katalog 5th Edition", "FK5 244"},
        {"Geneva Identification System", "GEN# +1.00044769A"},
        {"Smithsonian Astrophysical Observation", "SAO 113810"},
        {"Wilson Evans Batten Catalogue", "WEB 6051"},
    },
    visualMagnitude: 4.39,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.94207368),
        dec: Angle.Degrees(+04.59283881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48845"},
        {"Hipparcos Number", "HIP 32387"},
        {"Smithsonian Astrophysical Observation", "SAO 114371"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.38790370),
        dec: Angle.Degrees(+04.59413093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30422",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5012 B"},
        {"Henry Draper", "HD 44770"},
        {"Hipparcos Number", "HIP 30422"},
        {"Geneva Identification System", "GEN# +1.00044770"},
        {"Smithsonian Astrophysical Observation", "SAO 113811"},
        {"Wilson Evans Batten Catalogue", "WEB 6052"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.94373665),
        dec: Angle.Degrees(+04.59586651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7447"},
        {"Hipparcos Number", "HIP 5828"},
        {"Smithsonian Astrophysical Observation", "SAO 109754"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.68698554),
        dec: Angle.Degrees(+04.59683805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12446",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12446"},
    },
    visualMagnitude: 10.85,
    bvColour: 1.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.05929369),
        dec: Angle.Degrees(+04.59885384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104899",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104899"},
        {"Smithsonian Astrophysical Observation", "SAO 126648"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.72828703),
        dec: Angle.Degrees(+04.59940407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218058"},
        {"Hipparcos Number", "HIP 113976"},
        {"Smithsonian Astrophysical Observation", "SAO 127953"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.23820006),
        dec: Angle.Degrees(+04.59993314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166283"},
        {"Hipparcos Number", "HIP 88983"},
        {"Smithsonian Astrophysical Observation", "SAO 123195"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.43657756),
        dec: Angle.Degrees(+04.60310898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15537"},
        {"Hipparcos Number", "HIP 11637"},
        {"Geneva Identification System", "GEN# +1.00015537"},
        {"Smithsonian Astrophysical Observation", "SAO 110575"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.53269984),
        dec: Angle.Degrees(+04.60477871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25113"},
        {"Hipparcos Number", "HIP 18650"},
        {"Smithsonian Astrophysical Observation", "SAO 111546"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.88808568),
        dec: Angle.Degrees(+04.60667891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2392"},
        {"Hipparcos Number", "HIP 2195"},
        {"Smithsonian Astrophysical Observation", "SAO 109220"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.93105078),
        dec: Angle.Degrees(+04.60714066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47382"},
        {"Hipparcos Number", "HIP 31749"},
        {"Geneva Identification System", "GEN# +1.00047382"},
        {"Smithsonian Astrophysical Observation", "SAO 114183"},
        {"Wilson Evans Batten Catalogue", "WEB 6372"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.61932869),
        dec: Angle.Degrees(+04.60718472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174698"},
        {"Hipparcos Number", "HIP 92562"},
        {"Geneva Identification System", "GEN# +1.00174698"},
        {"Smithsonian Astrophysical Observation", "SAO 123981"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.92750774),
        dec: Angle.Degrees(+04.60835031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212753"},
        {"Hipparcos Number", "HIP 110776"},
        {"Geneva Identification System", "GEN# +1.00212753"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.821,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.63911531),
        dec: Angle.Degrees(+04.60957063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 223.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 82.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56394"},
        {"Hipparcos Number", "HIP 35239"},
        {"Smithsonian Astrophysical Observation", "SAO 115197"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.23322527),
        dec: Angle.Degrees(+04.60980166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22586",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22586"},
        {"Smithsonian Astrophysical Observation", "SAO 112151"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.90966882),
        dec: Angle.Degrees(+04.61039183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176400"},
        {"Hipparcos Number", "HIP 93274"},
        {"Smithsonian Astrophysical Observation", "SAO 124136"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.99556090),
        dec: Angle.Degrees(+04.61085580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88547"},
        {"Hipparcos Number", "HIP 50027"},
        {"Geneva Identification System", "GEN# +1.00088547"},
        {"Smithsonian Astrophysical Observation", "SAO 118164"},
        {"Wilson Evans Batten Catalogue", "WEB 9196"},
    },
    visualMagnitude: 5.77,
    bvColour: 1.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.20163836),
        dec: Angle.Degrees(+04.61469047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89242"},
        {"Hipparcos Number", "HIP 50429"},
        {"Geneva Identification System", "GEN# +1.00089242"},
        {"Smithsonian Astrophysical Observation", "SAO 118205"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.45306509),
        dec: Angle.Degrees(+04.61838309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157088"},
        {"Hipparcos Number", "HIP 84899"},
        {"Smithsonian Astrophysical Observation", "SAO 122300"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.26055851),
        dec: Angle.Degrees(+04.61896374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169669"},
        {"Hipparcos Number", "HIP 90315"},
        {"Geneva Identification System", "GEN# +1.00169669"},
        {"Smithsonian Astrophysical Observation", "SAO 123461"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.41740375),
        dec: Angle.Degrees(+04.61913796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51344",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51344"},
        {"Smithsonian Astrophysical Observation", "SAO 118329"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.30943045),
        dec: Angle.Degrees(+04.62004214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180029"},
        {"Hipparcos Number", "HIP 94567"},
        {"Geneva Identification System", "GEN# +1.00180029"},
        {"Renson", "Renson 49955"},
        {"Smithsonian Astrophysical Observation", "SAO 124431"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.69099797),
        dec: Angle.Degrees(+04.62006626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50843"},
        {"Hipparcos Number", "HIP 33253"},
        {"Smithsonian Astrophysical Observation", "SAO 114615"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.77961809),
        dec: Angle.Degrees(+04.62376049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47360"},
        {"Hipparcos Number", "HIP 31739"},
        {"Geneva Identification System", "GEN# +1.00047360"},
        {"Smithsonian Astrophysical Observation", "SAO 114181"},
        {"Wilson Evans Batten Catalogue", "WEB 6371"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.59630796),
        dec: Angle.Degrees(+04.62415253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88194"},
        {"Hipparcos Number", "HIP 49824"},
        {"Smithsonian Astrophysical Observation", "SAO 118143"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.56419140),
        dec: Angle.Degrees(+04.62597459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14031"},
        {"Hipparcos Number", "HIP 10596"},
        {"Geneva Identification System", "GEN# +1.00014031"},
        {"Smithsonian Astrophysical Observation", "SAO 110440"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.10989065),
        dec: Angle.Degrees(+04.62609916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224251"},
        {"Hipparcos Number", "HIP 118013"},
        {"Smithsonian Astrophysical Observation", "SAO 128478"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.07492548),
        dec: Angle.Degrees(+04.62656706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131066"},
        {"Hipparcos Number", "HIP 72661"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.85340270),
        dec: Angle.Degrees(+04.62660290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170783"},
        {"Hipparcos Number", "HIP 90761"},
        {"Geneva Identification System", "GEN# +1.00170783"},
        {"Smithsonian Astrophysical Observation", "SAO 123594"},
        {"Wilson Evans Batten Catalogue", "WEB 15549"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.76854068),
        dec: Angle.Degrees(+04.62697746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85505",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85505"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.10896668),
        dec: Angle.Degrees(+04.62790459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -159.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29299"},
        {"Hipparcos Number", "HIP 21501"},
        {"Smithsonian Astrophysical Observation", "SAO 111923"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.26675631),
        dec: Angle.Degrees(+04.62912338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17128",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17128"},
        {"Geneva Identification System", "GEN# +5.20250134"},
        {"Smithsonian Astrophysical Observation", "SAO 111336"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.02964582),
        dec: Angle.Degrees(+04.63033553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 132.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221599"},
        {"Hipparcos Number", "HIP 116257"},
        {"Smithsonian Astrophysical Observation", "SAO 128246"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.34620836),
        dec: Angle.Degrees(+04.63935929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38732"},
        {"Hipparcos Number", "HIP 27396"},
        {"Smithsonian Astrophysical Observation", "SAO 113154"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.03315676),
        dec: Angle.Degrees(+04.64123667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42862",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42862"},
        {"Smithsonian Astrophysical Observation", "SAO 117072"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.01523088),
        dec: Angle.Degrees(+04.64146048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68568",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68568"},
    },
    visualMagnitude: 10.45,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.55690340),
        dec: Angle.Degrees(+04.64373203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91256"},
        {"Hipparcos Number", "HIP 51592"},
        {"Smithsonian Astrophysical Observation", "SAO 118354"},
        {"Wilson Evans Batten Catalogue", "WEB 9414"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.07709298),
        dec: Angle.Degrees(+04.64527517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93330"},
        {"Hipparcos Number", "HIP 52705"},
        {"Smithsonian Astrophysical Observation", "SAO 118488"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.63918241),
        dec: Angle.Degrees(+04.64595697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -213.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -151.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115273"},
        {"Hipparcos Number", "HIP 64726"},
        {"Geneva Identification System", "GEN# +1.00115273"},
        {"Smithsonian Astrophysical Observation", "SAO 119838"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.99692724),
        dec: Angle.Degrees(+04.64674522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -135.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138103"},
        {"Hipparcos Number", "HIP 75864"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.43774076),
        dec: Angle.Degrees(+04.64710851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138059"},
        {"Hipparcos Number", "HIP 75844"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.38854363),
        dec: Angle.Degrees(+04.64787178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89633"},
        {"Hipparcos Number", "HIP 50656"},
        {"Geneva Identification System", "GEN# +1.00089633"},
        {"Smithsonian Astrophysical Observation", "SAO 118243"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.17383303),
        dec: Angle.Degrees(+04.64893443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -161.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83425"},
        {"Hipparcos Number", "HIP 47310"},
        {"Fundamental Katalog 5th Edition", "FK5 1249"},
        {"Geneva Identification System", "GEN# +1.00083425"},
        {"Smithsonian Astrophysical Observation", "SAO 117821"},
        {"Wilson Evans Batten Catalogue", "WEB 8892"},
    },
    visualMagnitude: 4.68,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.61410460),
        dec: Angle.Degrees(+04.64941422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -165.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21934"},
        {"Hipparcos Number", "HIP 16488"},
        {"Smithsonian Astrophysical Observation", "SAO 111244"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.08021110),
        dec: Angle.Degrees(+04.65024877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 134.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6142",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1060 AB"},
        {"Henry Draper", "HD 7919"},
        {"Hipparcos Number", "HIP 6142"},
        {"Smithsonian Astrophysical Observation", "SAO 109800"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.71826569),
        dec: Angle.Degrees(+04.65379772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68227",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68227"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.50674052),
        dec: Angle.Degrees(+04.65478344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165401"},
        {"Hipparcos Number", "HIP 88622"},
        {"Geneva Identification System", "GEN# +1.00165401"},
        {"Smithsonian Astrophysical Observation", "SAO 123112"},
        {"Wilson Evans Batten Catalogue", "WEB 15008"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.40614302),
        dec: Angle.Degrees(+04.65795549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -322.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105245",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105245"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.76370749),
        dec: Angle.Degrees(+04.65854138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99867",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13591 AB"},
        {"Henry Draper", "HD 192624"},
        {"Hipparcos Number", "HIP 99867"},
        {"Smithsonian Astrophysical Observation", "SAO 125621"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.92672736),
        dec: Angle.Degrees(+04.66183374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157880"},
        {"Hipparcos Number", "HIP 85296"},
        {"Smithsonian Astrophysical Observation", "SAO 122375"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.44784558),
        dec: Angle.Degrees(+04.66190663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46484"},
        {"Hipparcos Number", "HIP 31305"},
        {"Geneva Identification System", "GEN# +2.22440389"},
        {"Smithsonian Astrophysical Observation", "SAO 114058"},
        {"Wilson Evans Batten Catalogue", "WEB 6262"},
        {"New General Catalogue", "NGC 2244 389"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.47670798),
        dec: Angle.Degrees(+04.66238880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11455"},
        {"Hipparcos Number", "HIP 8765"},
        {"Smithsonian Astrophysical Observation", "SAO 110195"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.19822732),
        dec: Angle.Degrees(+04.66303015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34340"},
        {"Hipparcos Number", "HIP 24625"},
        {"Smithsonian Astrophysical Observation", "SAO 112589"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.22640449),
        dec: Angle.Degrees(+04.66377148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87160"},
        {"Hipparcos Number", "HIP 49254"},
        {"Smithsonian Astrophysical Observation", "SAO 118078"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.81562080),
        dec: Angle.Degrees(+04.66379341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129448"},
        {"Hipparcos Number", "HIP 71912"},
        {"Smithsonian Astrophysical Observation", "SAO 120613"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.63612998),
        dec: Angle.Degrees(+04.66407129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74685"},
        {"Hipparcos Number", "HIP 42981"},
        {"Smithsonian Astrophysical Observation", "SAO 117095"},
    },
    visualMagnitude: 6.45,
    bvColour: 1.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.39516396),
        dec: Angle.Degrees(+04.66456464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7747"},
        {"Hipparcos Number", "HIP 6017"},
        {"Geneva Identification System", "GEN# +1.00007747"},
        {"Smithsonian Astrophysical Observation", "SAO 109785"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.33471442),
        dec: Angle.Degrees(+04.66484517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44789",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44789"},
        {"Smithsonian Astrophysical Observation", "SAO 117442"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.948,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.92511829),
        dec: Angle.Degrees(+04.66491723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 264111"},
        {"Hipparcos Number", "HIP 32581"},
        {"Geneva Identification System", "GEN# +1.00264111"},
        {"Renson", "Renson 13310"},
        {"Smithsonian Astrophysical Observation", "SAO 114427"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.97440843),
        dec: Angle.Degrees(+04.66690339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204390"},
        {"Hipparcos Number", "HIP 105996"},
        {"Smithsonian Astrophysical Observation", "SAO 126813"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.01455467),
        dec: Angle.Degrees(+04.66729450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52438",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7900 AB"},
        {"Henry Draper", "HD 92812"},
        {"Hipparcos Number", "HIP 52438"},
        {"Smithsonian Astrophysical Observation", "SAO 118446"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.79007699),
        dec: Angle.Degrees(+04.66767315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66222",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66222"},
        {"Geneva Identification System", "GEN# +0.00502767"},
        {"Smithsonian Astrophysical Observation", "SAO 120011"},
        {"Wilson Evans Batten Catalogue", "WEB 11698"},
    },
    visualMagnitude: 9.95,
    bvColour: 1.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.58921648),
        dec: Angle.Degrees(+04.66770016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 153.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87937",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Barnard's star"},
        {"Common Name 2", "Barnard Star"},
        {"Hipparcos Number", "HIP 87937"},
        {"Cincinnati Publication", "Ci 20 1069"},
        {"Geneva Identification System", "GEN# +0.00403561"},
        {"Wilson Evans Batten Catalogue", "WEB 14849"},
    },
    visualMagnitude: 9.54,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.45402305),
        dec: Angle.Degrees(+04.66828815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -797.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10326.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25837",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4117 AB"},
        {"Henry Draper", "HD 36310"},
        {"Hipparcos Number", "HIP 25837"},
        {"Celescope Catalog", "CEL 746"},
        {"Geneva Identification System", "GEN# +1.00036310J"},
        {"Smithsonian Astrophysical Observation", "SAO 112857"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.74061425),
        dec: Angle.Degrees(+04.66872852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31412"},
        {"Hipparcos Number", "HIP 22919"},
        {"Geneva Identification System", "GEN# +1.00031412"},
        {"Smithsonian Astrophysical Observation", "SAO 112219"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.98251174),
        dec: Angle.Degrees(+04.67087296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 134.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -183.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57628"},
        {"Hipparcos Number", "HIP 35736"},
        {"Geneva Identification System", "GEN# +1.00057628"},
        {"Smithsonian Astrophysical Observation", "SAO 115343"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.57207121),
        dec: Angle.Degrees(+04.67204815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42675"},
        {"Hipparcos Number", "HIP 29440"},
        {"Celescope Catalog", "CEL 1120"},
        {"Geneva Identification System", "GEN# +1.00042675"},
        {"Renson", "Renson 11410"},
        {"Smithsonian Astrophysical Observation", "SAO 113584"},
    },
    visualMagnitude: 7.46,
    bvColour: -0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.05121033),
        dec: Angle.Degrees(+04.67376322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90279",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90279"},
        {"Geneva Identification System", "GEN# +0.00403735"},
        {"Smithsonian Astrophysical Observation", "SAO 123455"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.31165239),
        dec: Angle.Degrees(+04.67399207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164576"},
        {"Hipparcos Number", "HIP 88285"},
        {"Smithsonian Astrophysical Observation", "SAO 123037"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.42737084),
        dec: Angle.Degrees(+04.67785280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218515"},
        {"Hipparcos Number", "HIP 114266"},
        {"Smithsonian Astrophysical Observation", "SAO 127991"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.14504537),
        dec: Angle.Degrees(+04.67800685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126753"},
        {"Hipparcos Number", "HIP 70669"},
        {"Wilson Evans Batten Catalogue", "WEB 12245"},
    },
    visualMagnitude: 10.00,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.81830756),
        dec: Angle.Degrees(+04.67807825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205782"},
        {"Hipparcos Number", "HIP 106755"},
        {"Geneva Identification System", "GEN# +1.00205782"},
        {"Smithsonian Astrophysical Observation", "SAO 126933"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.37132640),
        dec: Angle.Degrees(+04.68245818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119216"},
        {"Hipparcos Number", "HIP 66832"},
        {"Smithsonian Astrophysical Observation", "SAO 120071"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.45583152),
        dec: Angle.Degrees(+04.68384103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -116.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24676",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3873 AB"},
        {"Henry Draper", "HD 34456"},
        {"Hipparcos Number", "HIP 24676"},
        {"Smithsonian Astrophysical Observation", "SAO 112602"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.41252088),
        dec: Angle.Degrees(+04.68384468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136777"},
        {"Hipparcos Number", "HIP 75231"},
        {"Smithsonian Astrophysical Observation", "SAO 120962"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.59960775),
        dec: Angle.Degrees(+04.68398218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218201"},
        {"Hipparcos Number", "HIP 114069"},
        {"Geneva Identification System", "GEN# +1.00218201"},
        {"Smithsonian Astrophysical Observation", "SAO 127966"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.53709835),
        dec: Angle.Degrees(+04.68670026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 248.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
