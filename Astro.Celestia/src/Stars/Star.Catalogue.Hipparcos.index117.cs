using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_117() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15292"},
        {"Hipparcos Number", "HIP 11906"},
        {"Smithsonian Astrophysical Observation", "SAO 4672"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.41746375),
        dec: Angle.Degrees(+77.66698829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 121.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179215"},
        {"Hipparcos Number", "HIP 93439"},
        {"Smithsonian Astrophysical Observation", "SAO 9311"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.45460092),
        dec: Angle.Degrees(+77.67579242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8364"},
        {"Hipparcos Number", "HIP 6718"},
        {"Geneva Identification System", "GEN# +1.00008364"},
        {"Smithsonian Astrophysical Observation", "SAO 4402"},
        {"Wilson Evans Batten Catalogue", "WEB 1466"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.61856639),
        dec: Angle.Degrees(+77.67875709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8065",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8065"},
        {"Smithsonian Astrophysical Observation", "SAO 4469"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.91108030),
        dec: Angle.Degrees(+77.68016934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91298",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11584 AB"},
        {"Henry Draper", "HD 173831"},
        {"Hipparcos Number", "HIP 91298"},
        {"Smithsonian Astrophysical Observation", "SAO 9199"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.34965554),
        dec: Angle.Degrees(+77.68677253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73796"},
        {"Hipparcos Number", "HIP 43200"},
        {"Geneva Identification System", "GEN# +1.00073796"},
        {"Smithsonian Astrophysical Observation", "SAO 6635"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.00793141),
        dec: Angle.Degrees(+77.68904367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112247"},
        {"Hipparcos Number", "HIP 62850"},
        {"Smithsonian Astrophysical Observation", "SAO 7687"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.752,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.22242847),
        dec: Angle.Degrees(+77.68950600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -256.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94937"},
        {"Hipparcos Number", "HIP 53774"},
        {"Geneva Identification System", "GEN# +1.00094937"},
        {"Smithsonian Astrophysical Observation", "SAO 7258"},
        {"Wilson Evans Batten Catalogue", "WEB 9741"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.04333668),
        dec: Angle.Degrees(+77.69216424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -112.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81722"},
        {"Hipparcos Number", "HIP 46922"},
        {"Geneva Identification System", "GEN# +1.00081722"},
        {"Smithsonian Astrophysical Observation", "SAO 6887"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.45489167),
        dec: Angle.Degrees(+77.69257542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104619"},
        {"Hipparcos Number", "HIP 58737"},
        {"Smithsonian Astrophysical Observation", "SAO 7491"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.70955906),
        dec: Angle.Degrees(+77.69300998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143496"},
        {"Hipparcos Number", "HIP 77702"},
        {"Smithsonian Astrophysical Observation", "SAO 8359"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.97596070),
        dec: Angle.Degrees(+77.70829272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99255",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13524 A"},
        {"Henry Draper", "HD 192907"},
        {"Hipparcos Number", "HIP 99255"},
        {"Fundamental Katalog 5th Edition", "FK5 759"},
        {"Geneva Identification System", "GEN# +1.00192907"},
        {"Smithsonian Astrophysical Observation", "SAO 9665"},
        {"Wilson Evans Batten Catalogue", "WEB 17688"},
    },
    visualMagnitude: 4.38,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.22215174),
        dec: Angle.Degrees(+77.71136178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19845",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19845"},
    },
    visualMagnitude: 9.95,
    bvColour: 1.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.81463439),
        dec: Angle.Degrees(+77.73489581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15547",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2450 A"},
        {"Henry Draper", "HD 19978"},
        {"Hipparcos Number", "HIP 15547"},
        {"Fundamental Katalog 5th Edition", "FK5 115"},
        {"Geneva Identification System", "GEN# +1.00019978"},
        {"Renson", "Renson 4950"},
        {"Smithsonian Astrophysical Observation", "SAO 4875"},
        {"Wilson Evans Batten Catalogue", "WEB 2986"},
    },
    visualMagnitude: 5.44,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.08158506),
        dec: Angle.Degrees(+77.73490142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101161",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101161"},
        {"Smithsonian Astrophysical Observation", "SAO 9800"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.57602760),
        dec: Angle.Degrees(+77.73540219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78284",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78284"},
    },
    visualMagnitude: 10.63,
    bvColour: 0.762,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.75889274),
        dec: Angle.Degrees(+77.74242190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13589"},
        {"Hipparcos Number", "HIP 10750"},
        {"Smithsonian Astrophysical Observation", "SAO 4610"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.57513185),
        dec: Angle.Degrees(+77.74266176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151043"},
        {"Hipparcos Number", "HIP 81219"},
        {"Geneva Identification System", "GEN# +1.00151043"},
        {"Smithsonian Astrophysical Observation", "SAO 8571"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.83880848),
        dec: Angle.Degrees(+77.75519061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57588",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57588"},
        {"Smithsonian Astrophysical Observation", "SAO 7429"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.09927613),
        dec: Angle.Degrees(+77.76515646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -155.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208391"},
        {"Hipparcos Number", "HIP 107828"},
        {"Smithsonian Astrophysical Observation", "SAO 10179"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.67241193),
        dec: Angle.Degrees(+77.76850991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94860"},
        {"Hipparcos Number", "HIP 53761"},
        {"Fundamental Katalog 5th Edition", "FK5 413"},
        {"Geneva Identification System", "GEN# +1.00094860"},
        {"Smithsonian Astrophysical Observation", "SAO 7255"},
        {"Wilson Evans Batten Catalogue", "WEB 9737"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.98757809),
        dec: Angle.Degrees(+77.77022483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92290",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92290"},
        {"Smithsonian Astrophysical Observation", "SAO 9261"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.15115664),
        dec: Angle.Degrees(+77.77172043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35506",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35506"},
        {"Smithsonian Astrophysical Observation", "SAO 6136"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.93757865),
        dec: Angle.Degrees(+77.77345383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30841"},
        {"Hipparcos Number", "HIP 23318"},
        {"Geneva Identification System", "GEN# +1.00030841"},
        {"Smithsonian Astrophysical Observation", "SAO 5373"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.22522373),
        dec: Angle.Degrees(+77.77550443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60577"},
        {"Hipparcos Number", "HIP 37768"},
        {"Smithsonian Astrophysical Observation", "SAO 6287"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.16990778),
        dec: Angle.Degrees(+77.77817833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96572"},
        {"Hipparcos Number", "HIP 54571"},
        {"Smithsonian Astrophysical Observation", "SAO 7295"},
        {"Wilson Evans Batten Catalogue", "WEB 9847"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.50629476),
        dec: Angle.Degrees(+77.78683818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21116",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21116"},
        {"Smithsonian Astrophysical Observation", "SAO 5215"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.88840901),
        dec: Angle.Degrees(+77.78695152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49183",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49183"},
        {"Smithsonian Astrophysical Observation", "SAO 7027"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.56717374),
        dec: Angle.Degrees(+77.79041121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142105"},
        {"Hipparcos Number", "HIP 77055"},
        {"Fundamental Katalog 5th Edition", "FK5 590"},
        {"Geneva Identification System", "GEN# +1.00142105"},
        {"Smithsonian Astrophysical Observation", "SAO 8328"},
        {"Wilson Evans Batten Catalogue", "WEB 13071"},
    },
    visualMagnitude: 4.29,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.01443312),
        dec: Angle.Degrees(+77.79449901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53572",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53572"},
        {"Smithsonian Astrophysical Observation", "SAO 7243"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.40109606),
        dec: Angle.Degrees(+77.80214140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62385",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62385"},
        {"Smithsonian Astrophysical Observation", "SAO 7661"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.77916567),
        dec: Angle.Degrees(+77.81810208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221537"},
        {"Hipparcos Number", "HIP 116114"},
        {"Fundamental Katalog 5th Edition", "FK5 6081"},
        {"Geneva Identification System", "GEN# +1.00221537"},
        {"Smithsonian Astrophysical Observation", "SAO 10772"},
        {"Wilson Evans Batten Catalogue", "WEB 20525"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.91485471),
        dec: Angle.Degrees(+77.81964500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28330",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28330"},
        {"Smithsonian Astrophysical Observation", "SAO 5699"},
    },
    visualMagnitude: 10.48,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.79493109),
        dec: Angle.Degrees(+77.82068994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192763"},
        {"Hipparcos Number", "HIP 99169"},
        {"Geneva Identification System", "GEN# +1.00192763"},
        {"Smithsonian Astrophysical Observation", "SAO 9657"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.99498965),
        dec: Angle.Degrees(+77.82450374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73931"},
        {"Hipparcos Number", "HIP 43276"},
        {"Smithsonian Astrophysical Observation", "SAO 6641"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.24657272),
        dec: Angle.Degrees(+77.83207761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1901"},
        {"Hipparcos Number", "HIP 1923"},
        {"Geneva Identification System", "GEN# +1.00001901"},
        {"Smithsonian Astrophysical Observation", "SAO 4107"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.07112200),
        dec: Angle.Degrees(+77.83367157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216977"},
        {"Hipparcos Number", "HIP 113125"},
        {"Smithsonian Astrophysical Observation", "SAO 10548"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.63013319),
        dec: Angle.Degrees(+77.84265320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151698"},
        {"Hipparcos Number", "HIP 81528"},
        {"Geneva Identification System", "GEN# +1.00151698"},
        {"Smithsonian Astrophysical Observation", "SAO 8597"},
        {"Wilson Evans Batten Catalogue", "WEB 13772"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.78227813),
        dec: Angle.Degrees(+77.86922876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 92.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60403"},
        {"Hipparcos Number", "HIP 37681"},
        {"Smithsonian Astrophysical Observation", "SAO 6280"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.96261542),
        dec: Angle.Degrees(+77.87737556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152810"},
        {"Hipparcos Number", "HIP 82061"},
        {"Smithsonian Astrophysical Observation", "SAO 8624"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.43509183),
        dec: Angle.Degrees(+77.88961907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119272"},
        {"Hipparcos Number", "HIP 66502"},
        {"Geneva Identification System", "GEN# +1.00119272"},
        {"Smithsonian Astrophysical Observation", "SAO 7858"},
        {"Wilson Evans Batten Catalogue", "WEB 11738"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.48680590),
        dec: Angle.Degrees(+77.89076935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221405"},
        {"Hipparcos Number", "HIP 116023"},
        {"Geneva Identification System", "GEN# +1.00221405"},
        {"Smithsonian Astrophysical Observation", "SAO 10764"},
        {"Wilson Evans Batten Catalogue", "WEB 20515"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.64196273),
        dec: Angle.Degrees(+77.89406033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55403"},
        {"Hipparcos Number", "HIP 35771"},
        {"Geneva Identification System", "GEN# +1.00055403"},
        {"Smithsonian Astrophysical Observation", "SAO 6155"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.68583766),
        dec: Angle.Degrees(+77.89626801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13098"},
        {"Hipparcos Number", "HIP 10371"},
        {"Geneva Identification System", "GEN# +1.00013098"},
        {"Smithsonian Astrophysical Observation", "SAO 4597"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.41127178),
        dec: Angle.Degrees(+77.90528860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191699"},
        {"Hipparcos Number", "HIP 98673"},
        {"Smithsonian Astrophysical Observation", "SAO 9622"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.62755387),
        dec: Angle.Degrees(+77.90555801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43853"},
        {"Hipparcos Number", "HIP 30879"},
        {"Geneva Identification System", "GEN# +1.00043853"},
        {"Smithsonian Astrophysical Observation", "SAO 5848"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.22902512),
        dec: Angle.Degrees(+77.90734507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184084"},
        {"Hipparcos Number", "HIP 95297"},
        {"Smithsonian Astrophysical Observation", "SAO 9419"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.81220921),
        dec: Angle.Degrees(+77.90764319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12005"},
        {"Hipparcos Number", "HIP 9568"},
        {"Geneva Identification System", "GEN# +1.00012005"},
        {"Smithsonian Astrophysical Observation", "SAO 4555"},
        {"Wilson Evans Batten Catalogue", "WEB 2007"},
    },
    visualMagnitude: 6.04,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.73767498),
        dec: Angle.Degrees(+77.91627546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224203"},
        {"Hipparcos Number", "HIP 117973"},
        {"Smithsonian Astrophysical Observation", "SAO 10902"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.92281556),
        dec: Angle.Degrees(+77.91964045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38373"},
        {"Hipparcos Number", "HIP 28030"},
        {"Geneva Identification System", "GEN# +1.00038373"},
        {"Smithsonian Astrophysical Observation", "SAO 5683"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.91314089),
        dec: Angle.Degrees(+77.92416096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45190"},
        {"Hipparcos Number", "HIP 31584"},
        {"Smithsonian Astrophysical Observation", "SAO 5891"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.14872087),
        dec: Angle.Degrees(+77.92504322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35570"},
        {"Hipparcos Number", "HIP 26296"},
        {"Smithsonian Astrophysical Observation", "SAO 5569"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.00180903),
        dec: Angle.Degrees(+77.93227826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106048",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15054 AB"},
        {"Henry Draper", "HD 205395"},
        {"Hipparcos Number", "HIP 106048"},
        {"Smithsonian Astrophysical Observation", "SAO 10063"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.19652442),
        dec: Angle.Degrees(+77.93526941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85345"},
        {"Hipparcos Number", "HIP 48769"},
        {"Smithsonian Astrophysical Observation", "SAO 6998"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.20402603),
        dec: Angle.Degrees(+77.93821943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69220"},
        {"Hipparcos Number", "HIP 41213"},
        {"Smithsonian Astrophysical Observation", "SAO 6520"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.14943254),
        dec: Angle.Degrees(+77.93886405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5495",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5495"},
        {"Smithsonian Astrophysical Observation", "SAO 4337"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.58770277),
        dec: Angle.Degrees(+77.94575695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219522"},
        {"Hipparcos Number", "HIP 114722"},
        {"Smithsonian Astrophysical Observation", "SAO 10663"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.57852403),
        dec: Angle.Degrees(+77.94945762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112666",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112666"},
        {"Smithsonian Astrophysical Observation", "SAO 10511"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.24949717),
        dec: Angle.Degrees(+77.95303960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 236.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4666"},
        {"Hipparcos Number", "HIP 3964"},
        {"Geneva Identification System", "GEN# +1.00004666"},
        {"Smithsonian Astrophysical Observation", "SAO 4247"},
        {"Wilson Evans Batten Catalogue", "WEB 708"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.73351291),
        dec: Angle.Degrees(+77.95356004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43748"},
        {"Hipparcos Number", "HIP 30825"},
        {"Geneva Identification System", "GEN# +1.00043748"},
        {"Smithsonian Astrophysical Observation", "SAO 5846"},
        {"Wilson Evans Batten Catalogue", "WEB 6144"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.917,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.13957405),
        dec: Angle.Degrees(+77.95944197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154527"},
        {"Hipparcos Number", "HIP 82847"},
        {"Smithsonian Astrophysical Observation", "SAO 8673"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.96398489),
        dec: Angle.Degrees(+77.95968889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29898",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29898"},
        {"Smithsonian Astrophysical Observation", "SAO 5790"},
    },
    visualMagnitude: 9.46,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.42929273),
        dec: Angle.Degrees(+77.96321207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78588",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78588"},
        {"Smithsonian Astrophysical Observation", "SAO 8413"},
    },
    visualMagnitude: 10.06,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.69042621),
        dec: Angle.Degrees(+77.96554991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79262"},
        {"Hipparcos Number", "HIP 45760"},
        {"Geneva Identification System", "GEN# +1.00079262"},
        {"Smithsonian Astrophysical Observation", "SAO 6811"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.96865970),
        dec: Angle.Degrees(+77.96789154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7846",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1288 A"},
        {"Henry Draper", "HD 9899"},
        {"Hipparcos Number", "HIP 7846"},
        {"Fundamental Katalog 5th Edition", "FK5 4149"},
        {"Geneva Identification System", "GEN# +1.00009899"},
        {"Smithsonian Astrophysical Observation", "SAO 4461"},
    },
    visualMagnitude: 6.73,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.22100356),
        dec: Angle.Degrees(+77.96901023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34653"},
        {"Hipparcos Number", "HIP 25714"},
        {"Fundamental Katalog 5th Edition", "FK5 2404"},
        {"Geneva Identification System", "GEN# +1.00034653"},
        {"Smithsonian Astrophysical Observation", "SAO 5535"},
        {"Wilson Evans Batten Catalogue", "WEB 4989"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.35689151),
        dec: Angle.Degrees(+77.97754599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104736",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104736"},
        {"Smithsonian Astrophysical Observation", "SAO 9996"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.25073292),
        dec: Angle.Degrees(+77.99442945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45866"},
        {"Hipparcos Number", "HIP 31940"},
        {"Fundamental Katalog 5th Edition", "FK5 2507"},
        {"Geneva Identification System", "GEN# +1.00045866"},
        {"Smithsonian Astrophysical Observation", "SAO 5919"},
        {"Wilson Evans Batten Catalogue", "WEB 6419"},
    },
    visualMagnitude: 5.75,
    bvColour: 1.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.12015519),
        dec: Angle.Degrees(+77.99579710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77032",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77032"},
        {"Smithsonian Astrophysical Observation", "SAO 8326"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.92656928),
        dec: Angle.Degrees(+77.99590302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31509"},
        {"Hipparcos Number", "HIP 23803"},
        {"Fundamental Katalog 5th Edition", "FK5 4468"},
        {"Smithsonian Astrophysical Observation", "SAO 5412"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.73321009),
        dec: Angle.Degrees(+78.00519180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48506"},
        {"Hipparcos Number", "HIP 33156"},
        {"Geneva Identification System", "GEN# +1.00048506"},
        {"Smithsonian Astrophysical Observation", "SAO 5994"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.54621315),
        dec: Angle.Degrees(+78.00800062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21025"},
        {"Hipparcos Number", "HIP 16437"},
        {"Smithsonian Astrophysical Observation", "SAO 4916"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.92251328),
        dec: Angle.Degrees(+78.01441295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1007"},
        {"Hipparcos Number", "HIP 1216"},
        {"Smithsonian Astrophysical Observation", "SAO 4069"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.79626248),
        dec: Angle.Degrees(+78.01730962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215303"},
        {"Hipparcos Number", "HIP 111962"},
        {"Smithsonian Astrophysical Observation", "SAO 10461"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.18799315),
        dec: Angle.Degrees(+78.02208660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194191"},
        {"Hipparcos Number", "HIP 99871"},
        {"Smithsonian Astrophysical Observation", "SAO 9712"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.93017090),
        dec: Angle.Degrees(+78.02299945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64242",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64242"},
        {"Smithsonian Astrophysical Observation", "SAO 7767"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.49927892),
        dec: Angle.Degrees(+78.02765264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56195"},
        {"Hipparcos Number", "HIP 36100"},
        {"Smithsonian Astrophysical Observation", "SAO 6173"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.55405294),
        dec: Angle.Degrees(+78.04522402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98928",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98928"},
    },
    visualMagnitude: 10.58,
    bvColour: 0.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.30662045),
        dec: Angle.Degrees(+78.04533432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27500",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27500"},
        {"Smithsonian Astrophysical Observation", "SAO 5653"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.35362640),
        dec: Angle.Degrees(+78.05662435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89983",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89983"},
        {"Smithsonian Astrophysical Observation", "SAO 9103"},
    },
    visualMagnitude: 10.61,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.39142374),
        dec: Angle.Degrees(+78.05852082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186195"},
        {"Hipparcos Number", "HIP 96188"},
        {"Smithsonian Astrophysical Observation", "SAO 9472"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.37280317),
        dec: Angle.Degrees(+78.05911735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17510",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17510"},
        {"Smithsonian Astrophysical Observation", "SAO 4968"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.24291089),
        dec: Angle.Degrees(+78.06104825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7338",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7338"},
        {"Geneva Identification System", "GEN# +6.20030092"},
        {"Wilson Evans Batten Catalogue", "WEB 1576"},
    },
    visualMagnitude: 10.64,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.62796487),
        dec: Angle.Degrees(+78.06271016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 104.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120084"},
        {"Hipparcos Number", "HIP 66903"},
        {"Fundamental Katalog 5th Edition", "FK5 3090"},
        {"Geneva Identification System", "GEN# +1.00120084"},
        {"Smithsonian Astrophysical Observation", "SAO 7876"},
        {"Wilson Evans Batten Catalogue", "WEB 11795"},
    },
    visualMagnitude: 5.91,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.66409991),
        dec: Angle.Degrees(+78.06432575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26415"},
        {"Hipparcos Number", "HIP 20225"},
        {"Geneva Identification System", "GEN# +1.00026415"},
        {"Smithsonian Astrophysical Observation", "SAO 5153"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.01140745),
        dec: Angle.Degrees(+78.07960676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18366"},
        {"Hipparcos Number", "HIP 14294"},
        {"Geneva Identification System", "GEN# +1.00018366"},
        {"Smithsonian Astrophysical Observation", "SAO 4800"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.07053418),
        dec: Angle.Degrees(+78.08680317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68719",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68719"},
        {"Smithsonian Astrophysical Observation", "SAO 7941"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.01000820),
        dec: Angle.Degrees(+78.08724524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91425"},
        {"Hipparcos Number", "HIP 52006"},
        {"Geneva Identification System", "GEN# +1.00091425"},
        {"Smithsonian Astrophysical Observation", "SAO 7169"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.36721057),
        dec: Angle.Degrees(+78.08847719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48192"},
        {"Hipparcos Number", "HIP 33009"},
        {"Geneva Identification System", "GEN# +1.00048192"},
        {"Smithsonian Astrophysical Observation", "SAO 5988"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.17110052),
        dec: Angle.Degrees(+78.08848742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155246"},
        {"Hipparcos Number", "HIP 83184"},
        {"Smithsonian Astrophysical Observation", "SAO 8695"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.01880730),
        dec: Angle.Degrees(+78.09903972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2770"},
        {"Hipparcos Number", "HIP 2575"},
        {"Smithsonian Astrophysical Observation", "SAO 4138"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.18147837),
        dec: Angle.Degrees(+78.11167221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22828"},
        {"Hipparcos Number", "HIP 17810"},
        {"Geneva Identification System", "GEN# +1.00022828"},
    },
    visualMagnitude: 7.13,
    bvColour: -0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.16796801),
        dec: Angle.Degrees(+78.11931955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201908"},
        {"Hipparcos Number", "HIP 104105"},
        {"Fundamental Katalog 5th Edition", "FK5 795"},
        {"Geneva Identification System", "GEN# +1.00201908"},
        {"Smithsonian Astrophysical Observation", "SAO 9959"},
        {"Wilson Evans Batten Catalogue", "WEB 18963"},
    },
    visualMagnitude: 5.91,
    bvColour: -0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.37171122),
        dec: Angle.Degrees(+78.12632222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83550"},
        {"Hipparcos Number", "HIP 47884"},
        {"Geneva Identification System", "GEN# +1.00083550"},
        {"Smithsonian Astrophysical Observation", "SAO 6948"},
        {"Wilson Evans Batten Catalogue", "WEB 8957"},
    },
    visualMagnitude: 6.25,
    bvColour: 1.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.37899948),
        dec: Angle.Degrees(+78.13471252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56222",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56222"},
        {"Smithsonian Astrophysical Observation", "SAO 7369"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.88834118),
        dec: Angle.Degrees(+78.14025413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75544"},
        {"Hipparcos Number", "HIP 44060"},
        {"Fundamental Katalog 5th Edition", "FK5 4800"},
        {"Geneva Identification System", "GEN# +1.00075544"},
        {"Smithsonian Astrophysical Observation", "SAO 6692"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.59477826),
        dec: Angle.Degrees(+78.14574142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219766"},
        {"Hipparcos Number", "HIP 114883"},
        {"Geneva Identification System", "GEN# +1.00219766"},
        {"Smithsonian Astrophysical Observation", "SAO 10679"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.05825848),
        dec: Angle.Degrees(+78.15048793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183627"},
        {"Hipparcos Number", "HIP 95087"},
        {"Geneva Identification System", "GEN# +1.00183627"},
        {"Smithsonian Astrophysical Observation", "SAO 9403"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.17773103),
        dec: Angle.Degrees(+78.16009331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61307",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61307"},
        {"Smithsonian Astrophysical Observation", "SAO 7597"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.40595696),
        dec: Angle.Degrees(+78.16414402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74225"},
        {"Hipparcos Number", "HIP 43431"},
        {"Fundamental Katalog 5th Edition", "FK5 2692"},
        {"Geneva Identification System", "GEN# +1.00074225"},
        {"Smithsonian Astrophysical Observation", "SAO 6656"},
        {"Wilson Evans Batten Catalogue", "WEB 8370"},
    },
    visualMagnitude: 6.93,
    bvColour: 1.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.69416655),
        dec: Angle.Degrees(+78.16517276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108770",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108770"},
        {"Smithsonian Astrophysical Observation", "SAO 10235"},
    },
    visualMagnitude: 9.62,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.51101934),
        dec: Angle.Degrees(+78.16538615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44579"},
        {"Hipparcos Number", "HIP 31263"},
        {"Smithsonian Astrophysical Observation", "SAO 5877"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.35088771),
        dec: Angle.Degrees(+78.16849537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22621",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22621"},
        {"Smithsonian Astrophysical Observation", "SAO 5323"},
    },
    visualMagnitude: 9.48,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.00876652),
        dec: Angle.Degrees(+78.16856161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72819",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9445 AB"},
        {"Henry Draper", "HD 132698"},
        {"Hipparcos Number", "HIP 72819"},
        {"Smithsonian Astrophysical Observation", "SAO 8111"},
    },
    visualMagnitude: 6.52,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.26550333),
        dec: Angle.Degrees(+78.17666618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16051"},
        {"Hipparcos Number", "HIP 12535"},
        {"Smithsonian Astrophysical Observation", "SAO 4702"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.31716900),
        dec: Angle.Degrees(+78.17968561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46228",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46228"},
        {"Smithsonian Astrophysical Observation", "SAO 6842"},
    },
    visualMagnitude: 9.59,
    bvColour: 1.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.37569894),
        dec: Angle.Degrees(+78.18246529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19266"},
        {"Hipparcos Number", "HIP 15011"},
        {"Smithsonian Astrophysical Observation", "SAO 4843"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.37934138),
        dec: Angle.Degrees(+78.19087719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19667",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19667"},
        {"Smithsonian Astrophysical Observation", "SAO 5115"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.20160777),
        dec: Angle.Degrees(+78.19158626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11160"},
        {"Hipparcos Number", "HIP 8908"},
        {"Smithsonian Astrophysical Observation", "SAO 4509"},
    },
    visualMagnitude: 6.67,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.67144612),
        dec: Angle.Degrees(+78.19656306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33021",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33021"},
    },
    visualMagnitude: 10.97,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.18702601),
        dec: Angle.Degrees(+78.20273279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -209.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24545"},
        {"Hipparcos Number", "HIP 18913"},
        {"Fundamental Katalog 5th Edition", "FK5 2285"},
        {"Geneva Identification System", "GEN# +1.00024545"},
        {"Smithsonian Astrophysical Observation", "SAO 5062"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.79651077),
        dec: Angle.Degrees(+78.20280990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199798"},
        {"Hipparcos Number", "HIP 102992"},
        {"Smithsonian Astrophysical Observation", "SAO 9905"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.00029892),
        dec: Angle.Degrees(+78.20602329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57100"},
        {"Hipparcos Number", "HIP 36432"},
        {"Smithsonian Astrophysical Observation", "SAO 6199"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.749,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.46449042),
        dec: Angle.Degrees(+78.20653683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -138.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101997"},
        {"Hipparcos Number", "HIP 57312"},
        {"Smithsonian Astrophysical Observation", "SAO 7417"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.26763314),
        dec: Angle.Degrees(+78.22078235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62094"},
        {"Hipparcos Number", "HIP 38399"},
        {"Geneva Identification System", "GEN# +1.00062094"},
        {"Smithsonian Astrophysical Observation", "SAO 6324"},
        {"Wilson Evans Batten Catalogue", "WEB 7552"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.00006414),
        dec: Angle.Degrees(+78.22589831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108700"},
        {"Hipparcos Number", "HIP 60828"},
        {"Smithsonian Astrophysical Observation", "SAO 7571"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.01744108),
        dec: Angle.Degrees(+78.22688824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70470"},
        {"Hipparcos Number", "HIP 41755"},
        {"Fundamental Katalog 5th Edition", "FK5 2659"},
        {"Geneva Identification System", "GEN# +1.00070470"},
        {"Smithsonian Astrophysical Observation", "SAO 6549"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.71653213),
        dec: Angle.Degrees(+78.22849373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207803"},
        {"Hipparcos Number", "HIP 107459"},
        {"Smithsonian Astrophysical Observation", "SAO 10153"},
    },
    visualMagnitude: 7.17,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.47220260),
        dec: Angle.Degrees(+78.23291778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212937"},
        {"Hipparcos Number", "HIP 110550"},
        {"Geneva Identification System", "GEN# +1.00212937"},
        {"Smithsonian Astrophysical Observation", "SAO 10351"},
    },
    visualMagnitude: 6.77,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.92367369),
        dec: Angle.Degrees(+78.24329522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200119"},
        {"Hipparcos Number", "HIP 103170"},
        {"Smithsonian Astrophysical Observation", "SAO 9912"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.53051756),
        dec: Angle.Degrees(+78.25074054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55967"},
        {"Hipparcos Number", "HIP 36025"},
        {"Smithsonian Astrophysical Observation", "SAO 6169"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.35915778),
        dec: Angle.Degrees(+78.25418783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37006"},
        {"Hipparcos Number", "HIP 27225"},
        {"Geneva Identification System", "GEN# +1.00037006"},
        {"Smithsonian Astrophysical Observation", "SAO 5630"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.55016335),
        dec: Angle.Degrees(+78.25608444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 69.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40095",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40095"},
        {"Smithsonian Astrophysical Observation", "SAO 6429"},
    },
    visualMagnitude: 10.56,
    bvColour: 1.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.84867991),
        dec: Angle.Degrees(+78.25877833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71238",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71238"},
        {"Smithsonian Astrophysical Observation", "SAO 8053"},
    },
    visualMagnitude: 9.63,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.53158318),
        dec: Angle.Degrees(+78.26490995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95832",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12608 A"},
        {"Henry Draper", "HD 185497"},
        {"Hipparcos Number", "HIP 95832"},
        {"Smithsonian Astrophysical Observation", "SAO 9452"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.37512441),
        dec: Angle.Degrees(+78.26549232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95836",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12608 B"},
        {"Hipparcos Number", "HIP 95836"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.38006247),
        dec: Angle.Degrees(+78.26844673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8500",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8500"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.40321438),
        dec: Angle.Degrees(+78.27033332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43852"},
        {"Hipparcos Number", "HIP 30921"},
        {"Smithsonian Astrophysical Observation", "SAO 5853"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.34590251),
        dec: Angle.Degrees(+78.28539783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34531"},
        {"Hipparcos Number", "HIP 25653"},
        {"Geneva Identification System", "GEN# +1.00034531"},
        {"Smithsonian Astrophysical Observation", "SAO 5530"},
        {"Wilson Evans Batten Catalogue", "WEB 4975"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.19973934),
        dec: Angle.Degrees(+78.30058925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164428"},
        {"Hipparcos Number", "HIP 87293"},
        {"Geneva Identification System", "GEN# +1.00164428"},
        {"Smithsonian Astrophysical Observation", "SAO 8946"},
        {"Wilson Evans Batten Catalogue", "WEB 14728"},
    },
    visualMagnitude: 6.25,
    bvColour: 1.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.54208678),
        dec: Angle.Degrees(+78.30651595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97619"},
        {"Hipparcos Number", "HIP 55048"},
        {"Fundamental Katalog 5th Edition", "FK5 2896"},
        {"Geneva Identification System", "GEN# +1.00097619"},
        {"Smithsonian Astrophysical Observation", "SAO 7322"},
    },
    visualMagnitude: 6.89,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.03796400),
        dec: Angle.Degrees(+78.30898523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196268"},
        {"Hipparcos Number", "HIP 100966"},
        {"Smithsonian Astrophysical Observation", "SAO 9791"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.06183643),
        dec: Angle.Degrees(+78.32037517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35249"},
        {"Hipparcos Number", "HIP 26115"},
        {"Smithsonian Astrophysical Observation", "SAO 5558"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.53954887),
        dec: Angle.Degrees(+78.32289312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23036"},
        {"Hipparcos Number", "HIP 17990"},
        {"Geneva Identification System", "GEN# +1.00023036"},
        {"Smithsonian Astrophysical Observation", "SAO 4999"},
    },
    visualMagnitude: 8.10,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.67881527),
        dec: Angle.Degrees(+78.32898603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139404"},
        {"Hipparcos Number", "HIP 75826"},
        {"Smithsonian Astrophysical Observation", "SAO 8265"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.34962910),
        dec: Angle.Degrees(+78.33084284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85623",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85623"},
        {"Smithsonian Astrophysical Observation", "SAO 8831"},
    },
    visualMagnitude: 9.77,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.44866489),
        dec: Angle.Degrees(+78.33294104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5278",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5278"},
        {"Smithsonian Astrophysical Observation", "SAO 4326"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.87483012),
        dec: Angle.Degrees(+78.33537912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89342"},
        {"Hipparcos Number", "HIP 50879"},
        {"Smithsonian Astrophysical Observation", "SAO 7123"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.83694941),
        dec: Angle.Degrees(+78.34276404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29201"},
        {"Hipparcos Number", "HIP 22160"},
        {"Smithsonian Astrophysical Observation", "SAO 5288"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.51994737),
        dec: Angle.Degrees(+78.34386395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35783"},
        {"Hipparcos Number", "HIP 26486"},
        {"Cincinnati Publication", "Ci 18 693"},
        {"Geneva Identification System", "GEN# +1.00035783"},
        {"Smithsonian Astrophysical Observation", "SAO 5577"},
        {"Wilson Evans Batten Catalogue", "WEB 5220"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.50399975),
        dec: Angle.Degrees(+78.35918778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -259.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88513",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88513"},
        {"Smithsonian Astrophysical Observation", "SAO 9017"},
    },
    visualMagnitude: 9.58,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.11160609),
        dec: Angle.Degrees(+78.36333068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24969",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3840 AB"},
        {"Henry Draper", "HD 33440"},
        {"Hipparcos Number", "HIP 24969"},
        {"Smithsonian Astrophysical Observation", "SAO 5489"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.22023124),
        dec: Angle.Degrees(+78.37477593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25730"},
        {"Hipparcos Number", "HIP 19766"},
        {"Smithsonian Astrophysical Observation", "SAO 5123"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.57414480),
        dec: Angle.Degrees(+78.37481098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117376",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117376"},
        {"Smithsonian Astrophysical Observation", "SAO 10862"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.99165347),
        dec: Angle.Degrees(+78.37608282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19008"},
        {"Hipparcos Number", "HIP 14794"},
        {"Geneva Identification System", "GEN# +1.00019008"},
        {"Smithsonian Astrophysical Observation", "SAO 4836"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.76726983),
        dec: Angle.Degrees(+78.37674487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91937",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91937"},
        {"Fundamental Katalog 5th Edition", "FK5 5645"},
        {"Smithsonian Astrophysical Observation", "SAO 9243"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.12597730),
        dec: Angle.Degrees(+78.38372175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163859"},
        {"Hipparcos Number", "HIP 87055"},
        {"Geneva Identification System", "GEN# +1.00163859"},
        {"Smithsonian Astrophysical Observation", "SAO 8932"},
        {"Wilson Evans Batten Catalogue", "WEB 14686"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.83098498),
        dec: Angle.Degrees(+78.39089875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 177.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136401"},
        {"Hipparcos Number", "HIP 74408"},
        {"Smithsonian Astrophysical Observation", "SAO 8198"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.10326818),
        dec: Angle.Degrees(+78.39100870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84991",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84991"},
        {"Smithsonian Astrophysical Observation", "SAO 8791"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.57743097),
        dec: Angle.Degrees(+78.39370804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137527"},
        {"Hipparcos Number", "HIP 74880"},
        {"Smithsonian Astrophysical Observation", "SAO 8217"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.54748234),
        dec: Angle.Degrees(+78.39404571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58308",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58308"},
        {"Smithsonian Astrophysical Observation", "SAO 7462"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.35896357),
        dec: Angle.Degrees(+78.39425651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -214.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42702"},
        {"Hipparcos Number", "HIP 30358"},
        {"Geneva Identification System", "GEN# +1.00042702"},
        {"Smithsonian Astrophysical Observation", "SAO 5818"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.78015701),
        dec: Angle.Degrees(+78.39667234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122189"},
        {"Hipparcos Number", "HIP 67959"},
        {"Geneva Identification System", "GEN# +1.00122189"},
        {"Smithsonian Astrophysical Observation", "SAO 7912"},
        {"Wilson Evans Batten Catalogue", "WEB 11937"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.75941061),
        dec: Angle.Degrees(+78.39978825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135180"},
        {"Hipparcos Number", "HIP 73873"},
        {"Smithsonian Astrophysical Observation", "SAO 8170"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.47691320),
        dec: Angle.Degrees(+78.40705713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34188"},
        {"Hipparcos Number", "HIP 25416"},
        {"Geneva Identification System", "GEN# +1.00034188"},
        {"Smithsonian Astrophysical Observation", "SAO 5516"},
    },
    visualMagnitude: 6.68,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.54490164),
        dec: Angle.Degrees(+78.41455012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21014",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21014"},
        {"Smithsonian Astrophysical Observation", "SAO 5207"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.59449537),
        dec: Angle.Degrees(+78.42088662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80389"},
        {"Hipparcos Number", "HIP 46299"},
        {"Geneva Identification System", "GEN# +1.00080389"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.62438668),
        dec: Angle.Degrees(+78.42969063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80388"},
        {"Hipparcos Number", "HIP 46298"},
        {"Geneva Identification System", "GEN# +1.00080388"},
        {"Smithsonian Astrophysical Observation", "SAO 6845"},
        {"Wilson Evans Batten Catalogue", "WEB 8757"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.61945799),
        dec: Angle.Degrees(+78.43774279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59091",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59091"},
        {"Smithsonian Astrophysical Observation", "SAO 7505"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.76770392),
        dec: Angle.Degrees(+78.45108823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -130.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80503",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80503"},
        {"Smithsonian Astrophysical Observation", "SAO 8528"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.745,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.49825809),
        dec: Angle.Degrees(+78.46382735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100233"},
        {"Hipparcos Number", "HIP 56369"},
        {"Smithsonian Astrophysical Observation", "SAO 7377"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.32725881),
        dec: Angle.Degrees(+78.46594307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4429"},
        {"Hipparcos Number", "HIP 3796"},
        {"Smithsonian Astrophysical Observation", "SAO 4231"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.19415062),
        dec: Angle.Degrees(+78.46729832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20674"},
        {"Hipparcos Number", "HIP 16148"},
        {"Geneva Identification System", "GEN# +1.00020674"},
        {"Smithsonian Astrophysical Observation", "SAO 4904"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.01290714),
        dec: Angle.Degrees(+78.47884806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1631"},
        {"Hipparcos Number", "HIP 1724"},
        {"Smithsonian Astrophysical Observation", "SAO 4098"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.42560896),
        dec: Angle.Degrees(+78.47947165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217294"},
        {"Hipparcos Number", "HIP 113299"},
        {"Smithsonian Astrophysical Observation", "SAO 10562"},
        {"Wilson Evans Batten Catalogue", "WEB 20159"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.796,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.17442341),
        dec: Angle.Degrees(+78.49592147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -130.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127806"},
        {"Hipparcos Number", "HIP 70618"},
        {"Smithsonian Astrophysical Observation", "SAO 8023"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.67999855),
        dec: Angle.Degrees(+78.49871840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 86.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112599"},
        {"Hipparcos Number", "HIP 63061"},
        {"Smithsonian Astrophysical Observation", "SAO 7703"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.81276848),
        dec: Angle.Degrees(+78.49984402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44371",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44371"},
    },
    visualMagnitude: 12.33,
    bvColour: 0.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.54836110),
        dec: Angle.Degrees(+78.50041526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -155.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -592.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56273",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56273"},
        {"Smithsonian Astrophysical Observation", "SAO 7371"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.04956991),
        dec: Angle.Degrees(+78.50872780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35097",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35097"},
        {"Smithsonian Astrophysical Observation", "SAO 6113"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.87233036),
        dec: Angle.Degrees(+78.50907914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15380"},
        {"Hipparcos Number", "HIP 12045"},
        {"Smithsonian Astrophysical Observation", "SAO 4676"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.82163945),
        dec: Angle.Degrees(+78.51699878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112230",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16243 AB"},
        {"Henry Draper", "HD 215730"},
        {"Hipparcos Number", "HIP 112230"},
    },
    visualMagnitude: 7.32,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.96129368),
        dec: Angle.Degrees(+78.51825425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116910"},
        {"Hipparcos Number", "HIP 65285"},
        {"Smithsonian Astrophysical Observation", "SAO 7806"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.70452224),
        dec: Angle.Degrees(+78.54665090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223035"},
        {"Hipparcos Number", "HIP 117172"},
        {"Smithsonian Astrophysical Observation", "SAO 10851"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.33728357),
        dec: Angle.Degrees(+78.55786124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86812",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86812"},
        {"Smithsonian Astrophysical Observation", "SAO 8917"},
    },
    visualMagnitude: 9.62,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.07487129),
        dec: Angle.Degrees(+78.55806943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213494"},
        {"Hipparcos Number", "HIP 110863"},
        {"Geneva Identification System", "GEN# +1.00213494"},
        {"Smithsonian Astrophysical Observation", "SAO 10386"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.91610643),
        dec: Angle.Degrees(+78.56985780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115206",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115206"},
        {"Smithsonian Astrophysical Observation", "SAO 10703"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.01516708),
        dec: Angle.Degrees(+78.57206194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54839",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54839"},
        {"Smithsonian Astrophysical Observation", "SAO 7312"},
    },
    visualMagnitude: 10.36,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.40704623),
        dec: Angle.Degrees(+78.57275301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104957",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14845 A"},
        {"Henry Draper", "HD 203516"},
        {"Hipparcos Number", "HIP 104957"},
        {"Smithsonian Astrophysical Observation", "SAO 10010"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.89856735),
        dec: Angle.Degrees(+78.59819124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104964",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14845 B"},
        {"Hipparcos Number", "HIP 104964"},
        {"Smithsonian Astrophysical Observation", "SAO 10011"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.92337138),
        dec: Angle.Degrees(+78.60361915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16428"},
        {"Hipparcos Number", "HIP 12851"},
        {"Smithsonian Astrophysical Observation", "SAO 4716"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.30644661),
        dec: Angle.Degrees(+78.60774300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15589",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15589"},
        {"Smithsonian Astrophysical Observation", "SAO 4876"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.19442933),
        dec: Angle.Degrees(+78.61218439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189589"},
        {"Hipparcos Number", "HIP 97678"},
        {"Smithsonian Astrophysical Observation", "SAO 9562"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.76635868),
        dec: Angle.Degrees(+78.62425437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206362"},
        {"Hipparcos Number", "HIP 106583"},
        {"Smithsonian Astrophysical Observation", "SAO 10100"},
        {"Wilson Evans Batten Catalogue", "WEB 19282"},
    },
    visualMagnitude: 7.49,
    bvColour: 2.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.80335151),
        dec: Angle.Degrees(+78.62449429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4741"},
        {"Hipparcos Number", "HIP 4041"},
        {"Geneva Identification System", "GEN# +1.00004741"},
        {"Smithsonian Astrophysical Observation", "SAO 4251"},
        {"Wilson Evans Batten Catalogue", "WEB 723"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.95657932),
        dec: Angle.Degrees(+78.62577543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 158.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139492"},
        {"Hipparcos Number", "HIP 75847"},
        {"Wilson Evans Batten Catalogue", "WEB 12910"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.39443706),
        dec: Angle.Degrees(+78.63339959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7039",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7039"},
    },
    visualMagnitude: 10.84,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.68696910),
        dec: Angle.Degrees(+78.63497853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117566"},
        {"Hipparcos Number", "HIP 65595"},
        {"Fundamental Katalog 5th Edition", "FK5 3075"},
        {"Geneva Identification System", "GEN# +1.00117566"},
        {"Smithsonian Astrophysical Observation", "SAO 7821"},
        {"Wilson Evans Batten Catalogue", "WEB 11599"},
    },
    visualMagnitude: 5.74,
    bvColour: 0.769,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.73841524),
        dec: Angle.Degrees(+78.64379561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66671",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66671"},
    },
    visualMagnitude: 10.45,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.00780554),
        dec: Angle.Degrees(+78.65373611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202505"},
        {"Hipparcos Number", "HIP 104414"},
        {"Geneva Identification System", "GEN# +1.00202505"},
        {"Smithsonian Astrophysical Observation", "SAO 9976"},
        {"Wilson Evans Batten Catalogue", "WEB 19008"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.28171971),
        dec: Angle.Degrees(+78.66318178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17225"},
        {"Hipparcos Number", "HIP 13456"},
        {"Smithsonian Astrophysical Observation", "SAO 4745"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.31983089),
        dec: Angle.Degrees(+78.67066525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 144.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78748",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78748"},
        {"Smithsonian Astrophysical Observation", "SAO 8422"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.15817960),
        dec: Angle.Degrees(+78.67754745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165309"},
        {"Hipparcos Number", "HIP 87639"},
        {"Geneva Identification System", "GEN# +1.00165309"},
        {"Smithsonian Astrophysical Observation", "SAO 8965"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.52403173),
        dec: Angle.Degrees(+78.67957623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57724"},
        {"Hipparcos Number", "HIP 36715"},
        {"Fundamental Katalog 5th Edition", "FK5 4677"},
        {"Geneva Identification System", "GEN# +1.00057724"},
        {"Smithsonian Astrophysical Observation", "SAO 6213"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.27212081),
        dec: Angle.Degrees(+78.68712845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57544",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57544"},
        {"Geneva Identification System", "GEN# +9.80254029"},
        {"Geneva Identification System 2", "GEN# +6.10010445"},
        {"Wilson Evans Batten Catalogue", "WEB 10334"},
    },
    visualMagnitude: 10.80,
    bvColour: 1.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.91319098),
        dec: Angle.Degrees(+78.68999275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 743.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 480.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122343"},
        {"Hipparcos Number", "HIP 68029"},
        {"Fundamental Katalog 5th Edition", "FK5 5227"},
        {"Geneva Identification System", "GEN# +1.00122343"},
        {"Smithsonian Astrophysical Observation", "SAO 7917"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.95819826),
        dec: Angle.Degrees(+78.69488418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14288"},
        {"Hipparcos Number", "HIP 11247"},
        {"Smithsonian Astrophysical Observation", "SAO 4638"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.20335534),
        dec: Angle.Degrees(+78.69956811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14276",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14276"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.771,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.00666352),
        dec: Angle.Degrees(+78.70056476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 158.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73201",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73201"},
    },
    visualMagnitude: 11.07,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.41050135),
        dec: Angle.Degrees(+78.70066203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 147.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115676"},
        {"Hipparcos Number", "HIP 64646"},
        {"Smithsonian Astrophysical Observation", "SAO 7786"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.76401452),
        dec: Angle.Degrees(+78.70130787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57492",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57492"},
        {"Smithsonian Astrophysical Observation", "SAO 7425"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.76125538),
        dec: Angle.Degrees(+78.71643029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 286",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 286"},
        {"Smithsonian Astrophysical Observation", "SAO 4022"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.88130145),
        dec: Angle.Degrees(+78.71780714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16173",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16173"},
    },
    visualMagnitude: 10.42,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.09275236),
        dec: Angle.Degrees(+78.72434228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 194.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8065"},
        {"Hipparcos Number", "HIP 6522"},
        {"Geneva Identification System", "GEN# +1.00008065"},
        {"Smithsonian Astrophysical Observation", "SAO 4391"},
        {"Wilson Evans Batten Catalogue", "WEB 1438"},
    },
    visualMagnitude: 6.07,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.94506566),
        dec: Angle.Degrees(+78.72604828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62692"},
        {"Hipparcos Number", "HIP 38697"},
        {"Geneva Identification System", "GEN# +1.00062692"},
        {"Smithsonian Astrophysical Observation", "SAO 6343"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.84360052),
        dec: Angle.Degrees(+78.73776313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 487",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 487"},
        {"Smithsonian Astrophysical Observation", "SAO 4034"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.46242223),
        dec: Angle.Degrees(+78.73840785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132750"},
        {"Hipparcos Number", "HIP 72834"},
        {"Smithsonian Astrophysical Observation", "SAO 8115"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.31326416),
        dec: Angle.Degrees(+78.75157070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52881"},
        {"Hipparcos Number", "HIP 34952"},
        {"Fundamental Katalog 5th Edition", "FK5 2550"},
        {"Geneva Identification System", "GEN# +1.00052881"},
        {"Smithsonian Astrophysical Observation", "SAO 6102"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.47951914),
        dec: Angle.Degrees(+78.75238098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69703",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69703"},
        {"Smithsonian Astrophysical Observation", "SAO 7979"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.01004565),
        dec: Angle.Degrees(+78.76006481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89069"},
        {"Hipparcos Number", "HIP 50709"},
        {"Geneva Identification System", "GEN# +1.00089069"},
        {"Renson", "Renson 25500"},
        {"Smithsonian Astrophysical Observation", "SAO 7115"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.31677888),
        dec: Angle.Degrees(+78.76427467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63687",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63687"},
        {"Smithsonian Astrophysical Observation", "SAO 7735"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.77064004),
        dec: Angle.Degrees(+78.77586084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9803",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9803"},
        {"Smithsonian Astrophysical Observation", "SAO 4566"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.52637583),
        dec: Angle.Degrees(+78.78312934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213403"},
        {"Hipparcos Number", "HIP 110787"},
        {"Geneva Identification System", "GEN# +1.00213403"},
        {"Renson", "Renson 59170"},
        {"Smithsonian Astrophysical Observation", "SAO 10375"},
        {"Wilson Evans Batten Catalogue", "WEB 19847"},
    },
    visualMagnitude: 5.83,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.67685952),
        dec: Angle.Degrees(+78.78594317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43202"},
        {"Hipparcos Number", "HIP 30632"},
        {"Geneva Identification System", "GEN# +1.00043202"},
        {"Smithsonian Astrophysical Observation", "SAO 5829"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.55498540),
        dec: Angle.Degrees(+78.79542653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59048",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59048"},
        {"Smithsonian Astrophysical Observation", "SAO 7501"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.58982894),
        dec: Angle.Degrees(+78.81257029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198623"},
        {"Hipparcos Number", "HIP 102270"},
        {"Smithsonian Astrophysical Observation", "SAO 9866"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.83327383),
        dec: Angle.Degrees(+78.81551077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213798"},
        {"Hipparcos Number", "HIP 111056"},
        {"Fundamental Katalog 5th Edition", "FK5 1593"},
        {"Geneva Identification System", "GEN# +1.00213798"},
        {"Smithsonian Astrophysical Observation", "SAO 10402"},
        {"Wilson Evans Batten Catalogue", "WEB 19881"},
    },
    visualMagnitude: 5.45,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.47070072),
        dec: Angle.Degrees(+78.82433733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83003"},
        {"Hipparcos Number", "HIP 47601"},
        {"Geneva Identification System", "GEN# +1.00083003"},
        {"Smithsonian Astrophysical Observation", "SAO 6931"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.58545322),
        dec: Angle.Degrees(+78.82830315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83865",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83865"},
        {"Smithsonian Astrophysical Observation", "SAO 8727"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.09682360),
        dec: Angle.Degrees(+78.82880812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176559"},
        {"Hipparcos Number", "HIP 92408"},
        {"Geneva Identification System", "GEN# +1.00176559"},
        {"Smithsonian Astrophysical Observation", "SAO 9269"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.47789884),
        dec: Angle.Degrees(+78.83932013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 99.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67842",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67842"},
        {"Wilson Evans Batten Catalogue", "WEB 11917"},
    },
    visualMagnitude: 10.63,
    bvColour: 1.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.44963262),
        dec: Angle.Degrees(+78.85160984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -254.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 116.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209088"},
        {"Hipparcos Number", "HIP 108201"},
        {"Smithsonian Astrophysical Observation", "SAO 10199"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.82009169),
        dec: Angle.Degrees(+78.85210861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40032",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40032"},
        {"Smithsonian Astrophysical Observation", "SAO 6426"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.65434774),
        dec: Angle.Degrees(+78.85855237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109377",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15717 AB"},
        {"Hipparcos Number", "HIP 109377"},
        {"Smithsonian Astrophysical Observation", "SAO 10271"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.37368439),
        dec: Angle.Degrees(+78.86250310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212847"},
        {"Hipparcos Number", "HIP 110477"},
        {"Smithsonian Astrophysical Observation", "SAO 10345"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.67438951),
        dec: Angle.Degrees(+78.86608927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76973"},
        {"Hipparcos Number", "HIP 44769"},
        {"Smithsonian Astrophysical Observation", "SAO 6740"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.86651557),
        dec: Angle.Degrees(+78.87036015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11577",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11577"},
        {"Smithsonian Astrophysical Observation", "SAO 4653"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.797,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.30317856),
        dec: Angle.Degrees(+78.87466927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 130.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19597"},
        {"Hipparcos Number", "HIP 15296"},
        {"Geneva Identification System", "GEN# +1.00019597"},
        {"Smithsonian Astrophysical Observation", "SAO 4863"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.34006565),
        dec: Angle.Degrees(+78.87500082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56840"},
        {"Hipparcos Number", "HIP 36405"},
        {"Smithsonian Astrophysical Observation", "SAO 6196"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.36740192),
        dec: Angle.Degrees(+78.88082278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95033"},
        {"Hipparcos Number", "HIP 53889"},
        {"Geneva Identification System", "GEN# +1.00095033"},
        {"Smithsonian Astrophysical Observation", "SAO 7265"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.37894997),
        dec: Angle.Degrees(+78.88401358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216885"},
        {"Hipparcos Number", "HIP 113046"},
        {"Smithsonian Astrophysical Observation", "SAO 10535"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.41024071),
        dec: Angle.Degrees(+78.90187082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97002"},
        {"Hipparcos Number", "HIP 54770"},
        {"Geneva Identification System", "GEN# +1.00097002"},
        {"Smithsonian Astrophysical Observation", "SAO 7307"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.19553604),
        dec: Angle.Degrees(+78.90651814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11940"},
        {"Hipparcos Number", "HIP 9544"},
        {"Geneva Identification System", "GEN# +1.00011940"},
        {"Smithsonian Astrophysical Observation", "SAO 4549"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.66538769),
        dec: Angle.Degrees(+78.91140339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151623"},
        {"Hipparcos Number", "HIP 81428"},
        {"Geneva Identification System", "GEN# +1.00151623"},
        {"Smithsonian Astrophysical Observation", "SAO 8592"},
        {"Wilson Evans Batten Catalogue", "WEB 13762"},
    },
    visualMagnitude: 6.33,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.47003300),
        dec: Angle.Degrees(+78.91856343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88295"},
        {"Hipparcos Number", "HIP 50308"},
        {"Fundamental Katalog 5th Edition", "FK5 2820"},
        {"Geneva Identification System", "GEN# +1.00088295"},
        {"Smithsonian Astrophysical Observation", "SAO 7088"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.07162789),
        dec: Angle.Degrees(+78.94696308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25098"},
        {"Hipparcos Number", "HIP 19390"},
        {"Smithsonian Astrophysical Observation", "SAO 5095"},
    },
    visualMagnitude: 7.76,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.29815452),
        dec: Angle.Degrees(+78.95590043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74110"},
        {"Hipparcos Number", "HIP 43438"},
        {"Smithsonian Astrophysical Observation", "SAO 6653"},
        {"Wilson Evans Batten Catalogue", "WEB 8369"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.70653029),
        dec: Angle.Degrees(+78.96155400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149681"},
        {"Hipparcos Number", "HIP 80480"},
        {"Fundamental Katalog 5th Edition", "FK5 3305"},
        {"Geneva Identification System", "GEN# +1.00149681"},
        {"Smithsonian Astrophysical Observation", "SAO 8527"},
        {"Wilson Evans Batten Catalogue", "WEB 13620"},
    },
    visualMagnitude: 5.55,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.43136816),
        dec: Angle.Degrees(+78.96360053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 104.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176667"},
        {"Hipparcos Number", "HIP 92431"},
        {"Geneva Identification System", "GEN# +1.00176667"},
        {"Smithsonian Astrophysical Observation", "SAO 9273"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.55066406),
        dec: Angle.Degrees(+78.96600687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170152"},
        {"Hipparcos Number", "HIP 89586"},
        {"Smithsonian Astrophysical Observation", "SAO 9073"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.21670520),
        dec: Angle.Degrees(+78.96672448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122188"},
        {"Hipparcos Number", "HIP 67925"},
        {"Geneva Identification System", "GEN# +1.00122188"},
        {"Smithsonian Astrophysical Observation", "SAO 7908"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.66948391),
        dec: Angle.Degrees(+78.97507148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202900"},
        {"Hipparcos Number", "HIP 104609"},
        {"Smithsonian Astrophysical Observation", "SAO 9993"},
        {"Wilson Evans Batten Catalogue", "WEB 19035"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.86555363),
        dec: Angle.Degrees(+78.97540758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26758",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26758"},
        {"Smithsonian Astrophysical Observation", "SAO 5590"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.767,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.26555003),
        dec: Angle.Degrees(+78.97837483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44385"},
        {"Hipparcos Number", "HIP 31231"},
        {"Smithsonian Astrophysical Observation", "SAO 5874"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.26671689),
        dec: Angle.Degrees(+78.97956790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28256"},
        {"Hipparcos Number", "HIP 21558"},
        {"Geneva Identification System", "GEN# +1.00028256"},
        {"Smithsonian Astrophysical Observation", "SAO 5252"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.43147470),
        dec: Angle.Degrees(+78.98672154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121457"},
        {"Hipparcos Number", "HIP 67512"},
        {"Fundamental Katalog 5th Edition", "FK5 3105"},
        {"Geneva Identification System", "GEN# +1.00121457"},
        {"Smithsonian Astrophysical Observation", "SAO 7895"},
        {"Wilson Evans Batten Catalogue", "WEB 11873"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.50646944),
        dec: Angle.Degrees(+78.99568489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26531"},
        {"Hipparcos Number", "HIP 20405"},
        {"Smithsonian Astrophysical Observation", "SAO 5161"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.52913627),
        dec: Angle.Degrees(+79.00078811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220140"},
        {"Hipparcos Number", "HIP 115147"},
        {"Geneva Identification System", "GEN# +1.00220140"},
        {"Smithsonian Astrophysical Observation", "SAO 10697"},
        {"Wilson Evans Batten Catalogue", "WEB 20399"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.893,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.85840121),
        dec: Angle.Degrees(+79.00334432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 201.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36166",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36166"},
        {"Smithsonian Astrophysical Observation", "SAO 6176"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.74769155),
        dec: Angle.Degrees(+79.01130840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207871"},
        {"Hipparcos Number", "HIP 107473"},
        {"Smithsonian Astrophysical Observation", "SAO 10158"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.847,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.51936567),
        dec: Angle.Degrees(+79.01857310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38245",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38245"},
        {"Smithsonian Astrophysical Observation", "SAO 6312"},
    },
    visualMagnitude: 10.62,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.52291083),
        dec: Angle.Degrees(+79.02224747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110520"},
        {"Hipparcos Number", "HIP 61883"},
        {"Geneva Identification System", "GEN# +1.00110520"},
        {"Smithsonian Astrophysical Observation", "SAO 7632"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.21342562),
        dec: Angle.Degrees(+79.02478375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57193",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57193"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.804,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.90506562),
        dec: Angle.Degrees(+79.02518030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -239.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7851"},
        {"Hipparcos Number", "HIP 6385"},
        {"Smithsonian Astrophysical Observation", "SAO 4383"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.51043979),
        dec: Angle.Degrees(+79.02534052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25406"},
        {"Hipparcos Number", "HIP 19619"},
        {"Smithsonian Astrophysical Observation", "SAO 5109"},
    },
    visualMagnitude: 6.92,
    bvColour: 1.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.05666556),
        dec: Angle.Degrees(+79.03000545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71514",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71514"},
        {"Smithsonian Astrophysical Observation", "SAO 8062"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.38836140),
        dec: Angle.Degrees(+79.03419965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87224"},
        {"Hipparcos Number", "HIP 49748"},
        {"Smithsonian Astrophysical Observation", "SAO 7053"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.33286503),
        dec: Angle.Degrees(+79.04616097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25022",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25022"},
        {"Smithsonian Astrophysical Observation", "SAO 5490"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.36413286),
        dec: Angle.Degrees(+79.05089064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18980",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2914 A"},
        {"Hipparcos Number", "HIP 18980"},
        {"Smithsonian Astrophysical Observation", "SAO 5064"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.99580497),
        dec: Angle.Degrees(+79.05253096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73816",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73816"},
        {"Smithsonian Astrophysical Observation", "SAO 8168"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.30982294),
        dec: Angle.Degrees(+79.05957019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73803",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73803"},
    },
    visualMagnitude: 12.19,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.27295478),
        dec: Angle.Degrees(+79.06040841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169925"},
        {"Hipparcos Number", "HIP 89478"},
        {"Geneva Identification System", "GEN# +1.00169925"},
        {"Smithsonian Astrophysical Observation", "SAO 9066"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.89369147),
        dec: Angle.Degrees(+79.06489381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216897"},
        {"Hipparcos Number", "HIP 113053"},
        {"Smithsonian Astrophysical Observation", "SAO 10537"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.42612443),
        dec: Angle.Degrees(+79.07287393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13565",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13565"},
        {"Smithsonian Astrophysical Observation", "SAO 4751"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.68430232),
        dec: Angle.Degrees(+79.07349276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104389"},
        {"Hipparcos Number", "HIP 58619"},
        {"Smithsonian Astrophysical Observation", "SAO 7482"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.31763738),
        dec: Angle.Degrees(+79.08745873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5077",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5077"},
        {"Smithsonian Astrophysical Observation", "SAO 4313"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.24103661),
        dec: Angle.Degrees(+79.08765474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195806"},
        {"Hipparcos Number", "HIP 100670"},
        {"Smithsonian Astrophysical Observation", "SAO 9770"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.17319083),
        dec: Angle.Degrees(+79.09403448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72129"},
        {"Hipparcos Number", "HIP 42530"},
        {"Smithsonian Astrophysical Observation", "SAO 6600"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.05810517),
        dec: Angle.Degrees(+79.09758044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55853",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55853"},
        {"Smithsonian Astrophysical Observation", "SAO 7358"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.70455363),
        dec: Angle.Degrees(+79.09931211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45592"},
        {"Hipparcos Number", "HIP 31885"},
        {"Geneva Identification System", "GEN# +1.00045592"},
        {"Smithsonian Astrophysical Observation", "SAO 5910"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.98520706),
        dec: Angle.Degrees(+79.13024995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83727"},
        {"Hipparcos Number", "HIP 48017"},
        {"Fundamental Katalog 5th Edition", "FK5 2780"},
        {"Geneva Identification System", "GEN# +1.00083727"},
        {"Smithsonian Astrophysical Observation", "SAO 6956"},
        {"Wilson Evans Batten Catalogue", "WEB 8980"},
    },
    visualMagnitude: 6.09,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.82556901),
        dec: Angle.Degrees(+79.13673019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129561"},
        {"Hipparcos Number", "HIP 71376"},
        {"Smithsonian Astrophysical Observation", "SAO 8060"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.94780433),
        dec: Angle.Degrees(+79.14113510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7489",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1225 B"},
        {"Hipparcos Number", "HIP 7489"},
        {"Smithsonian Astrophysical Observation", "SAO 4439"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.10366706),
        dec: Angle.Degrees(+79.14830170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29146"},
        {"Hipparcos Number", "HIP 22188"},
        {"Geneva Identification System", "GEN# +1.00029146"},
        {"Smithsonian Astrophysical Observation", "SAO 5286"},
        {"Wilson Evans Batten Catalogue", "WEB 4267"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.59646097),
        dec: Angle.Degrees(+79.15142119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7492",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1225 A"},
        {"Henry Draper", "HD 9341"},
        {"Hipparcos Number", "HIP 7492"},
        {"Smithsonian Astrophysical Observation", "SAO 4440"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.10967311),
        dec: Angle.Degrees(+79.15479562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162424"},
        {"Hipparcos Number", "HIP 86413"},
        {"Geneva Identification System", "GEN# +1.00162424"},
        {"Smithsonian Astrophysical Observation", "SAO 8887"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.85613278),
        dec: Angle.Degrees(+79.16344569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49985"},
        {"Hipparcos Number", "HIP 33932"},
        {"Geneva Identification System", "GEN# +1.00049985"},
        {"Smithsonian Astrophysical Observation", "SAO 6031"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.61902437),
        dec: Angle.Degrees(+79.16460184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34096",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34096"},
        {"Smithsonian Astrophysical Observation", "SAO 6042"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.04810885),
        dec: Angle.Degrees(+79.16955494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41925",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41925"},
        {"Smithsonian Astrophysical Observation", "SAO 6556"},
    },
    visualMagnitude: 10.45,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.21669670),
        dec: Angle.Degrees(+79.17903264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13283"},
        {"Hipparcos Number", "HIP 10560"},
        {"Smithsonian Astrophysical Observation", "SAO 4601"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.98579843),
        dec: Angle.Degrees(+79.17918773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134880"},
        {"Hipparcos Number", "HIP 73689"},
        {"Smithsonian Astrophysical Observation", "SAO 8161"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.93550637),
        dec: Angle.Degrees(+79.18786806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151588"},
        {"Hipparcos Number", "HIP 81396"},
        {"Smithsonian Astrophysical Observation", "SAO 8588"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.35456884),
        dec: Angle.Degrees(+79.18813699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34329"},
        {"Hipparcos Number", "HIP 25607"},
        {"Smithsonian Astrophysical Observation", "SAO 5524"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.06276585),
        dec: Angle.Degrees(+79.19150660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3826"},
        {"Hipparcos Number", "HIP 3380"},
        {"Smithsonian Astrophysical Observation", "SAO 4189"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.74049682),
        dec: Angle.Degrees(+79.19644203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28995",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28995"},
        {"Smithsonian Astrophysical Observation", "SAO 5731"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.77211223),
        dec: Angle.Degrees(+79.19701692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140317"},
        {"Hipparcos Number", "HIP 76166"},
        {"Geneva Identification System", "GEN# +1.00140317"},
        {"Smithsonian Astrophysical Observation", "SAO 8284"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.35743966),
        dec: Angle.Degrees(+79.19757375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16324"},
        {"Hipparcos Number", "HIP 12805"},
        {"Smithsonian Astrophysical Observation", "SAO 4713"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.14262960),
        dec: Angle.Degrees(+79.19887579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151340"},
        {"Hipparcos Number", "HIP 81270"},
        {"Geneva Identification System", "GEN# +1.00151340"},
        {"Smithsonian Astrophysical Observation", "SAO 8580"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.98278633),
        dec: Angle.Degrees(+79.20489091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162092"},
        {"Hipparcos Number", "HIP 86267"},
        {"Geneva Identification System", "GEN# +1.00162092"},
        {"Smithsonian Astrophysical Observation", "SAO 8878"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.40282445),
        dec: Angle.Degrees(+79.21321264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110010"},
        {"Hipparcos Number", "HIP 61597"},
        {"Fundamental Katalog 5th Edition", "FK5 5112"},
        {"Geneva Identification System", "GEN# +1.00110010"},
        {"Smithsonian Astrophysical Observation", "SAO 7614"},
        {"Wilson Evans Batten Catalogue", "WEB 10957"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.33175023),
        dec: Angle.Degrees(+79.21544589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66239"},
        {"Hipparcos Number", "HIP 40210"},
        {"Smithsonian Astrophysical Observation", "SAO 6437"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.18613153),
        dec: Angle.Degrees(+79.22108196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171606"},
        {"Hipparcos Number", "HIP 90179"},
        {"Fundamental Katalog 5th Edition", "FK5 3467"},
        {"Geneva Identification System", "GEN# +1.00171606"},
        {"Smithsonian Astrophysical Observation", "SAO 9130"},
    },
    visualMagnitude: 6.54,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.03561291),
        dec: Angle.Degrees(+79.22254430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79826",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79826"},
        {"Smithsonian Astrophysical Observation", "SAO 8479"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.39545712),
        dec: Angle.Degrees(+79.22679656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25110",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3864 A"},
        {"Henry Draper", "HD 33564"},
        {"Hipparcos Number", "HIP 25110"},
        {"Fundamental Katalog 5th Edition", "FK5 191"},
        {"Geneva Identification System", "GEN# +1.00033564"},
        {"Smithsonian Astrophysical Observation", "SAO 5496"},
        {"Wilson Evans Batten Catalogue", "WEB 4869"},
    },
    visualMagnitude: 5.08,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.64073869),
        dec: Angle.Degrees(+79.23075701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 161.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219684"},
        {"Hipparcos Number", "HIP 114828"},
        {"Smithsonian Astrophysical Observation", "SAO 10677"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.90201317),
        dec: Angle.Degrees(+79.23287008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53971",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53971"},
    },
    visualMagnitude: 11.76,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.61806638),
        dec: Angle.Degrees(+79.23402865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -346.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116551",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116551"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.837,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.30716089),
        dec: Angle.Degrees(+79.25203238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 261.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2797",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2797"},
        {"Smithsonian Astrophysical Observation", "SAO 4153"},
        {"Wilson Evans Batten Catalogue", "WEB 503"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.90829835),
        dec: Angle.Degrees(+79.25914588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 176.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78584"},
        {"Hipparcos Number", "HIP 45563"},
        {"Geneva Identification System", "GEN# +1.00078584"},
        {"Smithsonian Astrophysical Observation", "SAO 6790"},
    },
    visualMagnitude: 8.17,
    bvColour: -0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.30001778),
        dec: Angle.Degrees(+79.28108969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197829"},
        {"Hipparcos Number", "HIP 101732"},
        {"Smithsonian Astrophysical Observation", "SAO 9838"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.30919970),
        dec: Angle.Degrees(+79.28841336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103754",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103754"},
        {"Cincinnati Publication", "Ci 18 2741"},
        {"Smithsonian Astrophysical Observation", "SAO 9943"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.36964444),
        dec: Angle.Degrees(+79.29548817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 187.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201087"},
        {"Hipparcos Number", "HIP 103602"},
        {"Smithsonian Astrophysical Observation", "SAO 9933"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.86621036),
        dec: Angle.Degrees(+79.30282494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158731"},
        {"Hipparcos Number", "HIP 84732"},
        {"Geneva Identification System", "GEN# +1.00158731"},
        {"Smithsonian Astrophysical Observation", "SAO 8782"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.81211689),
        dec: Angle.Degrees(+79.30543694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138321"},
        {"Hipparcos Number", "HIP 75215"},
        {"Smithsonian Astrophysical Observation", "SAO 8242"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.55518073),
        dec: Angle.Degrees(+79.32756666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26878",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4189 BC"},
        {"Hipparcos Number", "HIP 26878"},
    },
    visualMagnitude: 8.33,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.59928313),
        dec: Angle.Degrees(+79.32926547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41496"},
        {"Hipparcos Number", "HIP 29883"},
        {"Renson", "Renson 11103"},
        {"Smithsonian Astrophysical Observation", "SAO 5782"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.39210485),
        dec: Angle.Degrees(+79.32994011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26877",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4189 A"},
        {"Henry Draper", "HD 36258"},
        {"Hipparcos Number", "HIP 26877"},
        {"Smithsonian Astrophysical Observation", "SAO 5603"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.59395876),
        dec: Angle.Degrees(+79.33197279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9993"},
        {"Hipparcos Number", "HIP 7974"},
        {"Smithsonian Astrophysical Observation", "SAO 4464"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.60838541),
        dec: Angle.Degrees(+79.33204412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164372"},
        {"Hipparcos Number", "HIP 87199"},
        {"Geneva Identification System", "GEN# +1.00164372"},
        {"Smithsonian Astrophysical Observation", "SAO 8943"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.21618570),
        dec: Angle.Degrees(+79.33252950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126066"},
        {"Hipparcos Number", "HIP 69739"},
        {"Smithsonian Astrophysical Observation", "SAO 7983"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.11066833),
        dec: Angle.Degrees(+79.33679936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93979"},
        {"Hipparcos Number", "HIP 53339"},
        {"Smithsonian Astrophysical Observation", "SAO 7230"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.63597922),
        dec: Angle.Degrees(+79.34544876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76559"},
        {"Hipparcos Number", "HIP 44615"},
        {"Smithsonian Astrophysical Observation", "SAO 6726"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.36617742),
        dec: Angle.Degrees(+79.34634686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119197"},
        {"Hipparcos Number", "HIP 66393"},
        {"Smithsonian Astrophysical Observation", "SAO 7856"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.19105208),
        dec: Angle.Degrees(+79.35377386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79425",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79425"},
        {"Smithsonian Astrophysical Observation", "SAO 8461"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.14531389),
        dec: Angle.Degrees(+79.35620827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84747",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84747"},
        {"Smithsonian Astrophysical Observation", "SAO 8783"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.85204489),
        dec: Angle.Degrees(+79.37104043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26542"},
        {"Hipparcos Number", "HIP 20416"},
        {"Smithsonian Astrophysical Observation", "SAO 5163"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.59064922),
        dec: Angle.Degrees(+79.38123928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178684"},
        {"Hipparcos Number", "HIP 93162"},
        {"Smithsonian Astrophysical Observation", "SAO 9307"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.64446974),
        dec: Angle.Degrees(+79.38904689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5786"},
        {"Hipparcos Number", "HIP 4862"},
        {"Smithsonian Astrophysical Observation", "SAO 4297"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.62638146),
        dec: Angle.Degrees(+79.40331221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66373",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66373"},
        {"Smithsonian Astrophysical Observation", "SAO 7855"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.09570066),
        dec: Angle.Degrees(+79.40615852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14417",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2294 AB"},
        {"Henry Draper", "HD 18438"},
        {"Hipparcos Number", "HIP 14417"},
        {"Fundamental Katalog 5th Edition", "FK5 105"},
        {"Geneva Identification System", "GEN# +1.00018438J"},
        {"Smithsonian Astrophysical Observation", "SAO 4810"},
        {"Wilson Evans Batten Catalogue", "WEB 2812"},
    },
    visualMagnitude: 5.49,
    bvColour: 1.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.53313395),
        dec: Angle.Degrees(+79.41851027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90376",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90376"},
        {"Smithsonian Astrophysical Observation", "SAO 9140"},
        {"Wilson Evans Batten Catalogue", "WEB 15473"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.61971298),
        dec: Angle.Degrees(+79.42237979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 358.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197637"},
        {"Hipparcos Number", "HIP 101634"},
        {"Fundamental Katalog 5th Edition", "FK5 5812"},
        {"Geneva Identification System", "GEN# +1.00197637"},
        {"Smithsonian Astrophysical Observation", "SAO 9827"},
        {"Wilson Evans Batten Catalogue", "WEB 18360"},
    },
    visualMagnitude: 6.95,
    bvColour: -0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.00288410),
        dec: Angle.Degrees(+79.43037328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50794",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50794"},
        {"Smithsonian Astrophysical Observation", "SAO 7118"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.57235492),
        dec: Angle.Degrees(+79.43657688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188791"},
        {"Hipparcos Number", "HIP 97283"},
        {"Smithsonian Astrophysical Observation", "SAO 9545"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.57411423),
        dec: Angle.Degrees(+79.46026881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44280"},
        {"Hipparcos Number", "HIP 31222"},
        {"Geneva Identification System", "GEN# +1.00044280"},
        {"Smithsonian Astrophysical Observation", "SAO 5872"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.23472444),
        dec: Angle.Degrees(+79.46841659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50281",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7690 A"},
        {"Hipparcos Number", "HIP 50281"},
        {"Smithsonian Astrophysical Observation", "SAO 7086"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.99000144),
        dec: Angle.Degrees(+79.46944212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35200",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35200"},
        {"Smithsonian Astrophysical Observation", "SAO 6116"},
    },
    visualMagnitude: 9.49,
    bvColour: 1.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.11634414),
        dec: Angle.Degrees(+79.47914235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64486"},
        {"Hipparcos Number", "HIP 39538"},
        {"Fundamental Katalog 5th Edition", "FK5 2617"},
        {"Geneva Identification System", "GEN# +1.00064486"},
        {"Renson", "Renson 17690"},
        {"Smithsonian Astrophysical Observation", "SAO 6392"},
        {"Wilson Evans Batten Catalogue", "WEB 7727"},
    },
    visualMagnitude: 5.39,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.19660915),
        dec: Angle.Degrees(+79.47974268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31863"},
        {"Hipparcos Number", "HIP 24125"},
        {"Smithsonian Astrophysical Observation", "SAO 5436"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.72765223),
        dec: Angle.Degrees(+79.48144405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40527",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6646 A"},
        {"Henry Draper", "HD 67064"},
        {"Hipparcos Number", "HIP 40527"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.13006141),
        dec: Angle.Degrees(+79.50113697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153372"},
        {"Hipparcos Number", "HIP 82204"},
        {"Smithsonian Astrophysical Observation", "SAO 8634"},
        {"Wilson Evans Batten Catalogue", "WEB 13880"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.90942099),
        dec: Angle.Degrees(+79.50363775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40532",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6646 B"},
        {"Hipparcos Number", "HIP 40532"},
        {"Smithsonian Astrophysical Observation", "SAO 6461"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.13805215),
        dec: Angle.Degrees(+79.50671568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62807"},
        {"Hipparcos Number", "HIP 38813"},
        {"Smithsonian Astrophysical Observation", "SAO 6348"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.14787885),
        dec: Angle.Degrees(+79.51897596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101713",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101713"},
        {"Smithsonian Astrophysical Observation", "SAO 9835"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.26159109),
        dec: Angle.Degrees(+79.52951671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133085"},
        {"Hipparcos Number", "HIP 72908"},
        {"Smithsonian Astrophysical Observation", "SAO 8121"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.52208583),
        dec: Angle.Degrees(+79.53099254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21902"},
        {"Hipparcos Number", "HIP 17236"},
        {"Smithsonian Astrophysical Observation", "SAO 4958"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.36951982),
        dec: Angle.Degrees(+79.53528651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97632"},
        {"Hipparcos Number", "HIP 55082"},
        {"Fundamental Katalog 5th Edition", "FK5 4992"},
        {"Smithsonian Astrophysical Observation", "SAO 7325"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.16106772),
        dec: Angle.Degrees(+79.53623461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188281"},
        {"Hipparcos Number", "HIP 97079"},
        {"Smithsonian Astrophysical Observation", "SAO 9532"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.93012027),
        dec: Angle.Degrees(+79.53984588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221087"},
        {"Hipparcos Number", "HIP 115764"},
        {"Smithsonian Astrophysical Observation", "SAO 10739"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.80716646),
        dec: Angle.Degrees(+79.54192739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158012"},
        {"Hipparcos Number", "HIP 84364"},
        {"Geneva Identification System", "GEN# +1.00158012"},
        {"Smithsonian Astrophysical Observation", "SAO 8756"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.71532732),
        dec: Angle.Degrees(+79.54482098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208742"},
        {"Hipparcos Number", "HIP 107952"},
        {"Geneva Identification System", "GEN# +1.00208742"},
        {"Smithsonian Astrophysical Observation", "SAO 10190"},
        {"Wilson Evans Batten Catalogue", "WEB 19466"},
    },
    visualMagnitude: 6.51,
    bvColour: 1.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.05406202),
        dec: Angle.Degrees(+79.55173931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32439",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "23 H. Cam"},
        {"Henry Draper", "HD 46588"},
        {"Hipparcos Number", "HIP 32439"},
        {"Cincinnati Publication", "Ci 20 394"},
        {"Fundamental Katalog 5th Edition", "FK5 248"},
        {"Geneva Identification System", "GEN# +1.00046588"},
        {"Smithsonian Astrophysical Observation", "SAO 5946"},
        {"Wilson Evans Batten Catalogue", "WEB 6542"},
    },
    visualMagnitude: 5.44,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.56028979),
        dec: Angle.Degrees(+79.56627808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -603.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59200"},
        {"Hipparcos Number", "HIP 37367"},
        {"Smithsonian Astrophysical Observation", "SAO 6255"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.05767834),
        dec: Angle.Degrees(+79.56670074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47355",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47355"},
        {"Smithsonian Astrophysical Observation", "SAO 6910"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.73476358),
        dec: Angle.Degrees(+79.56852993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14343"},
        {"Hipparcos Number", "HIP 11341"},
        {"Smithsonian Astrophysical Observation", "SAO 4641"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.48018670),
        dec: Angle.Degrees(+79.57635862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104126"},
        {"Hipparcos Number", "HIP 58495"},
        {"Geneva Identification System", "GEN# +1.00104126"},
        {"Smithsonian Astrophysical Observation", "SAO 7473"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.95090139),
        dec: Angle.Degrees(+79.59528074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110961"},
        {"Hipparcos Number", "HIP 62092"},
        {"Geneva Identification System", "GEN# +1.00110961"},
        {"Smithsonian Astrophysical Observation", "SAO 7645"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.88461936),
        dec: Angle.Degrees(+79.59550873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45560"},
        {"Hipparcos Number", "HIP 31922"},
        {"Geneva Identification System", "GEN# +1.00045560"},
        {"Smithsonian Astrophysical Observation", "SAO 5911"},
        {"Wilson Evans Batten Catalogue", "WEB 6414"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.06919219),
        dec: Angle.Degrees(+79.59947697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184102"},
        {"Hipparcos Number", "HIP 95167"},
        {"Fundamental Katalog 5th Edition", "FK5 734"},
        {"Geneva Identification System", "GEN# +1.00184102"},
        {"Smithsonian Astrophysical Observation", "SAO 9414"},
        {"Wilson Evans Batten Catalogue", "WEB 16628"},
    },
    visualMagnitude: 6.06,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.41767071),
        dec: Angle.Degrees(+79.60289362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24894"},
        {"Hipparcos Number", "HIP 19289"},
        {"Smithsonian Astrophysical Observation", "SAO 5082"},
        {"Wilson Evans Batten Catalogue", "WEB 3705"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.01752449),
        dec: Angle.Degrees(+79.61669994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 199.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36737"},
        {"Hipparcos Number", "HIP 27209"},
        {"Geneva Identification System", "GEN# +1.00036737"},
        {"Smithsonian Astrophysical Observation", "SAO 5626"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.50867526),
        dec: Angle.Degrees(+79.62075393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172099"},
        {"Hipparcos Number", "HIP 90353"},
        {"Geneva Identification System", "GEN# +1.00172099"},
        {"Smithsonian Astrophysical Observation", "SAO 9139"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.53937217),
        dec: Angle.Degrees(+79.62847727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219235"},
        {"Hipparcos Number", "HIP 114534"},
        {"Smithsonian Astrophysical Observation", "SAO 10646"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.99150076),
        dec: Angle.Degrees(+79.63505134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211400"},
        {"Hipparcos Number", "HIP 109539"},
        {"Smithsonian Astrophysical Observation", "SAO 10281"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.83563917),
        dec: Angle.Degrees(+79.64072783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27134"},
        {"Hipparcos Number", "HIP 20865"},
        {"Geneva Identification System", "GEN# +1.00027134"},
        {"Smithsonian Astrophysical Observation", "SAO 5194"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.08418041),
        dec: Angle.Degrees(+79.64543111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180427"},
        {"Hipparcos Number", "HIP 93710"},
        {"Geneva Identification System", "GEN# +1.00180427"},
        {"Smithsonian Astrophysical Observation", "SAO 9326"},
        {"Wilson Evans Batten Catalogue", "WEB 16284"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.22833950),
        dec: Angle.Degrees(+79.64678656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37077",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37077"},
        {"Smithsonian Astrophysical Observation", "SAO 6241"},
    },
    visualMagnitude: 10.19,
    bvColour: 1.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.28993163),
        dec: Angle.Degrees(+79.64820201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194006"},
        {"Hipparcos Number", "HIP 99641"},
        {"Smithsonian Astrophysical Observation", "SAO 9699"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.33050655),
        dec: Angle.Degrees(+79.65157744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115299"},
        {"Hipparcos Number", "HIP 64440"},
        {"Smithsonian Astrophysical Observation", "SAO 7780"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.11833404),
        dec: Angle.Degrees(+79.65233601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28985"},
        {"Hipparcos Number", "HIP 22093"},
        {"Fundamental Katalog 5th Edition", "FK5 2346"},
        {"Geneva Identification System", "GEN# +1.00028985"},
        {"Smithsonian Astrophysical Observation", "SAO 5281"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.31068687),
        dec: Angle.Degrees(+79.65689678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43680"},
        {"Hipparcos Number", "HIP 30948"},
        {"Smithsonian Astrophysical Observation", "SAO 5847"},
        {"Wilson Evans Batten Catalogue", "WEB 6163"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.43453650),
        dec: Angle.Degrees(+79.65699814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -135.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129245"},
        {"Hipparcos Number", "HIP 71196"},
        {"Fundamental Katalog 5th Edition", "FK5 3159"},
        {"Geneva Identification System", "GEN# +1.00129245"},
        {"Smithsonian Astrophysical Observation", "SAO 8054"},
        {"Wilson Evans Batten Catalogue", "WEB 12307"},
    },
    visualMagnitude: 6.27,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.41091198),
        dec: Angle.Degrees(+79.66022308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84746"},
        {"Hipparcos Number", "HIP 48550"},
        {"Smithsonian Astrophysical Observation", "SAO 6986"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.52637628),
        dec: Angle.Degrees(+79.66167160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6798"},
        {"Hipparcos Number", "HIP 5626"},
        {"Fundamental Katalog 5th Edition", "FK5 41"},
        {"Geneva Identification System", "GEN# +1.00006798"},
        {"Smithsonian Astrophysical Observation", "SAO 4341"},
        {"Wilson Evans Batten Catalogue", "WEB 1264"},
    },
    visualMagnitude: 5.60,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.06878934),
        dec: Angle.Degrees(+79.67397492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53709",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7992 AB"},
        {"Henry Draper", "HD 94686"},
        {"Hipparcos Number", "HIP 53709"},
        {"Geneva Identification System", "GEN# +1.00094686J"},
        {"Smithsonian Astrophysical Observation", "SAO 7246"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.83664243),
        dec: Angle.Degrees(+79.67577693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103469"},
        {"Hipparcos Number", "HIP 58122"},
        {"Smithsonian Astrophysical Observation", "SAO 7454"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.81849270),
        dec: Angle.Degrees(+79.67596870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191994"},
        {"Hipparcos Number", "HIP 98666"},
        {"Smithsonian Astrophysical Observation", "SAO 9629"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.61049005),
        dec: Angle.Degrees(+79.68102793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12927"},
        {"Hipparcos Number", "HIP 10309"},
        {"Geneva Identification System", "GEN# +1.00012927"},
        {"Smithsonian Astrophysical Observation", "SAO 4594"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.20825793),
        dec: Angle.Degrees(+79.69148012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12881"},
        {"Hipparcos Number", "HIP 10285"},
        {"Geneva Identification System", "GEN# +1.00012881"},
        {"Renson", "Renson 3290"},
        {"Smithsonian Astrophysical Observation", "SAO 4592"},
        {"Wilson Evans Batten Catalogue", "WEB 2143"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.12245210),
        dec: Angle.Degrees(+79.69324653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11553"},
        {"Hipparcos Number", "HIP 9279"},
        {"Geneva Identification System", "GEN# +1.00011553"},
        {"Smithsonian Astrophysical Observation", "SAO 4527"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.936,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.82167438),
        dec: Angle.Degrees(+79.69870744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27172"},
        {"Hipparcos Number", "HIP 20896"},
        {"Geneva Identification System", "GEN# +1.00027172"},
        {"Smithsonian Astrophysical Observation", "SAO 5196"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.17610432),
        dec: Angle.Degrees(+79.70200408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 120276",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 120276"},
    },
    visualMagnitude: 12.51,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.51777580),
        dec: Angle.Degrees(+79.70628249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 159.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -135.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18064",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18064"},
    },
    visualMagnitude: 10.80,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.91227030),
        dec: Angle.Degrees(+79.70876476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -164.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43830",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43830"},
        {"Smithsonian Astrophysical Observation", "SAO 6674"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.90577762),
        dec: Angle.Degrees(+79.71330341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 760",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 102 AB"},
        {"Henry Draper", "HD 431"},
        {"Hipparcos Number", "HIP 760"},
        {"Geneva Identification System", "GEN# +1.00000431J"},
        {"Smithsonian Astrophysical Observation", "SAO 4048"},
        {"Wilson Evans Batten Catalogue", "WEB 126"},
    },
    visualMagnitude: 6.01,
    bvColour: 0.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.33262025),
        dec: Angle.Degrees(+79.71464113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 106.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96780",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96780"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.07257676),
        dec: Angle.Degrees(+79.71886625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 191.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 188.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15416"},
        {"Hipparcos Number", "HIP 12121"},
        {"Smithsonian Astrophysical Observation", "SAO 4679"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.03300225),
        dec: Angle.Degrees(+79.72907564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40337",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40337"},
    },
    visualMagnitude: 10.75,
    bvColour: 0.713,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.54199652),
        dec: Angle.Degrees(+79.72990382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -155.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93711",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93711"},
        {"Geneva Identification System", "GEN# +0.07900615"},
        {"Smithsonian Astrophysical Observation", "SAO 9327"},
        {"Wilson Evans Batten Catalogue", "WEB 16285"},
    },
    visualMagnitude: 9.72,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.22847920),
        dec: Angle.Degrees(+79.75466242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 194.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224363"},
        {"Hipparcos Number", "HIP 118068"},
        {"Geneva Identification System", "GEN# +1.00224363"},
        {"Smithsonian Astrophysical Observation", "SAO 10908"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.25896702),
        dec: Angle.Degrees(+79.75698433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28792"},
        {"Hipparcos Number", "HIP 22011"},
        {"Smithsonian Astrophysical Observation", "SAO 5275"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.96756507),
        dec: Angle.Degrees(+79.76323487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14159",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14159"},
        {"Smithsonian Astrophysical Observation", "SAO 4788"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.64244778),
        dec: Angle.Degrees(+79.76453842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139305"},
        {"Hipparcos Number", "HIP 75657"},
        {"Smithsonian Astrophysical Observation", "SAO 8261"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.85718255),
        dec: Angle.Degrees(+79.76532385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204338"},
        {"Hipparcos Number", "HIP 105337"},
        {"Smithsonian Astrophysical Observation", "SAO 10031"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.04651513),
        dec: Angle.Degrees(+79.76734812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14152"},
        {"Hipparcos Number", "HIP 11202"},
        {"Geneva Identification System", "GEN# +1.00014152"},
        {"Smithsonian Astrophysical Observation", "SAO 4630"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.06355923),
        dec: Angle.Degrees(+79.77069327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42172"},
        {"Hipparcos Number", "HIP 30242"},
        {"Geneva Identification System", "GEN# +1.00042172"},
        {"Smithsonian Astrophysical Observation", "SAO 5811"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.43170722),
        dec: Angle.Degrees(+79.78167111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184657"},
        {"Hipparcos Number", "HIP 95382"},
        {"Fundamental Katalog 5th Edition", "FK5 5706"},
        {"Geneva Identification System", "GEN# +1.00184657"},
        {"Smithsonian Astrophysical Observation", "SAO 9426"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.04964348),
        dec: Angle.Degrees(+79.78198189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24676"},
        {"Hipparcos Number", "HIP 19123"},
        {"Smithsonian Astrophysical Observation", "SAO 5071"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.50001041),
        dec: Angle.Degrees(+79.78678323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130235"},
        {"Hipparcos Number", "HIP 71624"},
        {"Fundamental Katalog 5th Edition", "FK5 5298"},
        {"Smithsonian Astrophysical Observation", "SAO 2431"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.73263875),
        dec: Angle.Degrees(+79.78740991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150706"},
        {"Hipparcos Number", "HIP 80902"},
        {"Fundamental Katalog 5th Edition", "FK5 5462"},
        {"Geneva Identification System", "GEN# +1.00150706"},
        {"Smithsonian Astrophysical Observation", "SAO 8557"},
        {"Wilson Evans Batten Catalogue", "WEB 13683"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.82195920),
        dec: Angle.Degrees(+79.78998852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172339"},
        {"Hipparcos Number", "HIP 90461"},
        {"Geneva Identification System", "GEN# +1.00172339"},
        {"Smithsonian Astrophysical Observation", "SAO 9145"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.88842533),
        dec: Angle.Degrees(+79.79477386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221100"},
        {"Hipparcos Number", "HIP 115773"},
        {"Smithsonian Astrophysical Observation", "SAO 10740"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.82640927),
        dec: Angle.Degrees(+79.79500212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105840",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105840"},
        {"Fundamental Katalog 5th Edition", "FK5 5889"},
        {"Geneva Identification System", "GEN# +0.07900708"},
        {"Smithsonian Astrophysical Observation", "SAO 10054"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.56432728),
        dec: Angle.Degrees(+79.80468333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88097",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88097"},
        {"Smithsonian Astrophysical Observation", "SAO 8992"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.88846769),
        dec: Angle.Degrees(+79.80762508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45586",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7249 AB"},
        {"Hipparcos Number", "HIP 45586"},
        {"Smithsonian Astrophysical Observation", "SAO 1480"},
    },
    visualMagnitude: 9.96,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.36716678),
        dec: Angle.Degrees(+79.81043480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110773",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110773"},
        {"Smithsonian Astrophysical Observation", "SAO 10376"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.914,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.63413100),
        dec: Angle.Degrees(+79.81531496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -176.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222461"},
        {"Hipparcos Number", "HIP 116751"},
        {"Smithsonian Astrophysical Observation", "SAO 10824"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.92419114),
        dec: Angle.Degrees(+79.82116557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223865"},
        {"Hipparcos Number", "HIP 117746"},
        {"Smithsonian Astrophysical Observation", "SAO 10882"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.19269833),
        dec: Angle.Degrees(+79.83480567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81283",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81283"},
        {"Smithsonian Astrophysical Observation", "SAO 8585"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.02896618),
        dec: Angle.Degrees(+79.83677522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77441"},
        {"Hipparcos Number", "HIP 45100"},
        {"Smithsonian Astrophysical Observation", "SAO 1456"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.82007439),
        dec: Angle.Degrees(+79.83768606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4796"},
        {"Hipparcos Number", "HIP 4090"},
        {"Renson", "Renson 1263"},
        {"Smithsonian Astrophysical Observation", "SAO 4253"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.12103486),
        dec: Angle.Degrees(+79.84047803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35029"},
        {"Hipparcos Number", "HIP 26103"},
        {"Smithsonian Astrophysical Observation", "SAO 5554"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.50961956),
        dec: Angle.Degrees(+79.85276679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63331"},
        {"Hipparcos Number", "HIP 39069"},
        {"Smithsonian Astrophysical Observation", "SAO 6363"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.90317921),
        dec: Angle.Degrees(+79.86150072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52096",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52096"},
        {"Smithsonian Astrophysical Observation", "SAO 1740"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.67929326),
        dec: Angle.Degrees(+79.87040107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219977"},
        {"Hipparcos Number", "HIP 115044"},
        {"Smithsonian Astrophysical Observation", "SAO 10689"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.50576354),
        dec: Angle.Degrees(+79.87431606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2299",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2299"},
        {"Smithsonian Astrophysical Observation", "SAO 4125"},
    },
    visualMagnitude: 10.48,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.33386222),
        dec: Angle.Degrees(+79.87833061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40068",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40068"},
        {"Cincinnati Publication", "Ci 20 455"},
        {"Geneva Identification System", "GEN# +0.08000245"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.77410236),
        dec: Angle.Degrees(+79.90910345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 136.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -366.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7238"},
        {"Hipparcos Number", "HIP 5947"},
        {"Geneva Identification System", "GEN# +1.00007238"},
        {"Smithsonian Astrophysical Observation", "SAO 4354"},
        {"Wilson Evans Batten Catalogue", "WEB 1353"},
    },
    visualMagnitude: 6.27,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.12932621),
        dec: Angle.Degrees(+79.90986944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26362",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26362"},
        {"Smithsonian Astrophysical Observation", "SAO 5567"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.21354351),
        dec: Angle.Degrees(+79.91165113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112986"},
        {"Hipparcos Number", "HIP 63232"},
        {"Smithsonian Astrophysical Observation", "SAO 2119"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.35134086),
        dec: Angle.Degrees(+79.91272249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100103"},
        {"Hipparcos Number", "HIP 56328"},
        {"Smithsonian Astrophysical Observation", "SAO 1889"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.21840574),
        dec: Angle.Degrees(+79.91658902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121366"},
        {"Hipparcos Number", "HIP 67423"},
        {"Geneva Identification System", "GEN# +1.00121366"},
        {"Smithsonian Astrophysical Observation", "SAO 2282"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.27911250),
        dec: Angle.Degrees(+79.92137816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111178"},
        {"Hipparcos Number", "HIP 62208"},
        {"Geneva Identification System", "GEN# +1.00111178"},
        {"Smithsonian Astrophysical Observation", "SAO 2083"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.25021675),
        dec: Angle.Degrees(+79.92365757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18651",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18651"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.868,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.88939231),
        dec: Angle.Degrees(+79.92479908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -148.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175938"},
        {"Hipparcos Number", "HIP 92040"},
        {"Fundamental Katalog 5th Edition", "FK5 3501"},
        {"Geneva Identification System", "GEN# +1.00175938"},
        {"Smithsonian Astrophysical Observation", "SAO 9256"},
        {"Wilson Evans Batten Catalogue", "WEB 15859"},
    },
    visualMagnitude: 6.40,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.40858706),
        dec: Angle.Degrees(+79.94250866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208774"},
        {"Hipparcos Number", "HIP 107940"},
        {"Smithsonian Astrophysical Observation", "SAO 10191"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.02519804),
        dec: Angle.Degrees(+79.95503327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15638",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15638"},
    },
    visualMagnitude: 11.21,
    bvColour: 1.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.33503020),
        dec: Angle.Degrees(+79.96656492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 410.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 284.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42089",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42089"},
        {"Smithsonian Astrophysical Observation", "SAO 1350"},
    },
    visualMagnitude: 10.06,
    bvColour: 1.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.68297467),
        dec: Angle.Degrees(+79.97443119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76695",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9769 AB"},
        {"Henry Draper", "HD 141652"},
        {"Hipparcos Number", "HIP 76695"},
        {"Smithsonian Astrophysical Observation", "SAO 2588"},
        {"Wilson Evans Batten Catalogue", "WEB 13018"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.91132935),
        dec: Angle.Degrees(+79.98311914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59365",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59365"},
        {"Smithsonian Astrophysical Observation", "SAO 1988"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.69418531),
        dec: Angle.Degrees(+79.98602382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125958"},
        {"Hipparcos Number", "HIP 69665"},
        {"Smithsonian Astrophysical Observation", "SAO 2355"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.87160213),
        dec: Angle.Degrees(+79.99920217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88127",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11061 B"},
        {"Henry Draper", "HD 166865"},
        {"Hipparcos Number", "HIP 88127"},
        {"Geneva Identification System", "GEN# +1.00166865"},
        {"Smithsonian Astrophysical Observation", "SAO 8994"},
        {"Wilson Evans Batten Catalogue", "WEB 14885"},
    },
    visualMagnitude: 6.11,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.01402261),
        dec: Angle.Degrees(+80.00052413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 130.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88136",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11061 A"},
        {"Henry Draper", "HD 166866"},
        {"Hipparcos Number", "HIP 88136"},
        {"Geneva Identification System", "GEN# +1.00166866"},
        {"Smithsonian Astrophysical Observation", "SAO 8996"},
        {"Wilson Evans Batten Catalogue", "WEB 14887"},
    },
    visualMagnitude: 5.74,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.03777781),
        dec: Angle.Degrees(+80.00379394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 124.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187233"},
        {"Hipparcos Number", "HIP 96548"},
        {"Smithsonian Astrophysical Observation", "SAO 9499"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.42800000),
        dec: Angle.Degrees(+80.00714070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74047"},
        {"Hipparcos Number", "HIP 43478"},
        {"Smithsonian Astrophysical Observation", "SAO 1397"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.83941868),
        dec: Angle.Degrees(+80.00882611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6473"},
        {"Hipparcos Number", "HIP 5412"},
        {"Smithsonian Astrophysical Observation", "SAO 4331"},
        {"Wilson Evans Batten Catalogue", "WEB 1181"},
    },
    visualMagnitude: 6.24,
    bvColour: 0.922,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.30122060),
        dec: Angle.Degrees(+80.01167654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107529"},
        {"Hipparcos Number", "HIP 60185"},
        {"Smithsonian Astrophysical Observation", "SAO 2021"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.13842530),
        dec: Angle.Degrees(+80.01583510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135573"},
        {"Hipparcos Number", "HIP 73923"},
        {"Smithsonian Astrophysical Observation", "SAO 2499"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.60168286),
        dec: Angle.Degrees(+80.01973460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74776"},
        {"Hipparcos Number", "HIP 43826"},
        {"Smithsonian Astrophysical Observation", "SAO 1412"},
    },
    visualMagnitude: 7.56,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.88904271),
        dec: Angle.Degrees(+80.03027531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80034",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10059 AB"},
        {"Hipparcos Number", "HIP 80034"},
        {"Smithsonian Astrophysical Observation", "SAO 2700"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.05775991),
        dec: Angle.Degrees(+80.04253963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2169"},
        {"Hipparcos Number", "HIP 2142"},
        {"Fundamental Katalog 5th Edition", "FK5 2023"},
        {"Geneva Identification System", "GEN# +1.00002169"},
        {"Smithsonian Astrophysical Observation", "SAO 4118"},
        {"Wilson Evans Batten Catalogue", "WEB 397"},
    },
    visualMagnitude: 6.53,
    bvColour: -0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.78045098),
        dec: Angle.Degrees(+80.05214787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211488"},
        {"Hipparcos Number", "HIP 109575"},
        {"Smithsonian Astrophysical Observation", "SAO 10286"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.95933206),
        dec: Angle.Degrees(+80.05748300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5195",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5195"},
        {"Smithsonian Astrophysical Observation", "SAO 4318"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.61091193),
        dec: Angle.Degrees(+80.08991439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17345"},
        {"Hipparcos Number", "HIP 13602"},
        {"Smithsonian Astrophysical Observation", "SAO 4753"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.82520842),
        dec: Angle.Degrees(+80.10660824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12395",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12395"},
        {"Smithsonian Astrophysical Observation", "SAO 4693"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.89771686),
        dec: Angle.Degrees(+80.10850540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4544",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4544"},
        {"Smithsonian Astrophysical Observation", "SAO 4273"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.54586627),
        dec: Angle.Degrees(+80.11391909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 200.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153448"},
        {"Hipparcos Number", "HIP 82175"},
        {"Geneva Identification System", "GEN# +1.00153448"},
        {"Smithsonian Astrophysical Observation", "SAO 2769"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.83871837),
        dec: Angle.Degrees(+80.11777823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59832",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8494 B"},
        {"Henry Draper", "HD 106798"},
        {"Hipparcos Number", "HIP 59832"},
        {"Geneva Identification System", "GEN# +1.00106798"},
        {"Smithsonian Astrophysical Observation", "SAO 2007"},
        {"Wilson Evans Batten Catalogue", "WEB 10632"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.03401116),
        dec: Angle.Degrees(+80.12194720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142297"},
        {"Hipparcos Number", "HIP 76973"},
        {"Geneva Identification System", "GEN# +1.00142297"},
        {"Smithsonian Astrophysical Observation", "SAO 2597"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.75670865),
        dec: Angle.Degrees(+80.12286364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59836",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8494 A"},
        {"Henry Draper", "HD 106799"},
        {"Hipparcos Number", "HIP 59836"},
        {"Geneva Identification System", "GEN# +1.00106799"},
        {"Smithsonian Astrophysical Observation", "SAO 2009"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.04857398),
        dec: Angle.Degrees(+80.12509703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42249"},
        {"Hipparcos Number", "HIP 30313"},
        {"Geneva Identification System", "GEN# +1.00042249"},
        {"Smithsonian Astrophysical Observation", "SAO 992"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.62648433),
        dec: Angle.Degrees(+80.12718268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79632"},
        {"Hipparcos Number", "HIP 46085"},
        {"Smithsonian Astrophysical Observation", "SAO 1503"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.96666437),
        dec: Angle.Degrees(+80.12760488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7850"},
        {"Hipparcos Number", "HIP 6420"},
        {"Smithsonian Astrophysical Observation", "SAO 4385"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.60418224),
        dec: Angle.Degrees(+80.12938364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19321"},
        {"Hipparcos Number", "HIP 15187"},
        {"Smithsonian Astrophysical Observation", "SAO 4852"},
    },
    visualMagnitude: 6.70,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.93925304),
        dec: Angle.Degrees(+80.13048631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158996"},
        {"Hipparcos Number", "HIP 84769"},
        {"Fundamental Katalog 5th Edition", "FK5 3384"},
        {"Geneva Identification System", "GEN# +1.00158996"},
        {"Smithsonian Astrophysical Observation", "SAO 2859"},
        {"Wilson Evans Batten Catalogue", "WEB 14312"},
    },
    visualMagnitude: 5.74,
    bvColour: 1.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.90436303),
        dec: Angle.Degrees(+80.13639898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6344",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6344"},
        {"Geneva Identification System", "GEN# +0.07900038"},
        {"Wilson Evans Batten Catalogue", "WEB 1411"},
    },
    visualMagnitude: 9.67,
    bvColour: 1.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.37480789),
        dec: Angle.Degrees(+80.15199391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 282.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103555",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103555"},
        {"Smithsonian Astrophysical Observation", "SAO 9932"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.70972041),
        dec: Angle.Degrees(+80.15707038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2971",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2971"},
        {"Smithsonian Astrophysical Observation", "SAO 4163"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.46145361),
        dec: Angle.Degrees(+80.15808811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176373"},
        {"Hipparcos Number", "HIP 92208"},
        {"Smithsonian Astrophysical Observation", "SAO 3118"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.88667669),
        dec: Angle.Degrees(+80.16036763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220973"},
        {"Hipparcos Number", "HIP 115693"},
        {"Smithsonian Astrophysical Observation", "SAO 10734"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.58855901),
        dec: Angle.Degrees(+80.16832272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111208",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111208"},
        {"Smithsonian Astrophysical Observation", "SAO 10416"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.869,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.94619714),
        dec: Angle.Degrees(+80.17618329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10841"},
        {"Hipparcos Number", "HIP 8712"},
        {"Smithsonian Astrophysical Observation", "SAO 4501"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.03417222),
        dec: Angle.Degrees(+80.19109151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31735",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31735"},
        {"Smithsonian Astrophysical Observation", "SAO 1035"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.59251065),
        dec: Angle.Degrees(+80.19583828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120103"},
        {"Hipparcos Number", "HIP 66809"},
        {"Geneva Identification System", "GEN# +1.00120103"},
        {"Smithsonian Astrophysical Observation", "SAO 2262"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.41644200),
        dec: Angle.Degrees(+80.20369495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94098"},
        {"Hipparcos Number", "HIP 53422"},
        {"Smithsonian Astrophysical Observation", "SAO 1785"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.92543686),
        dec: Angle.Degrees(+80.20432989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136078"},
        {"Hipparcos Number", "HIP 74138"},
        {"Smithsonian Astrophysical Observation", "SAO 2505"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.24871212),
        dec: Angle.Degrees(+80.20847443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160802"},
        {"Hipparcos Number", "HIP 85551"},
        {"Smithsonian Astrophysical Observation", "SAO 2889"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.25730116),
        dec: Angle.Degrees(+80.20948762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196156"},
        {"Hipparcos Number", "HIP 100746"},
    },
    visualMagnitude: 7.56,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.38966484),
        dec: Angle.Degrees(+80.22011621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36116",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36116"},
        {"Smithsonian Astrophysical Observation", "SAO 1167"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.59279462),
        dec: Angle.Degrees(+80.23091116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20055",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20055"},
        {"Smithsonian Astrophysical Observation", "SAO 671"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.50457243),
        dec: Angle.Degrees(+80.23680734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216991"},
        {"Hipparcos Number", "HIP 113066"},
        {"Smithsonian Astrophysical Observation", "SAO 10543"},
        {"Wilson Evans Batten Catalogue", "WEB 20128"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.48001293),
        dec: Angle.Degrees(+80.23996895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46550"},
        {"Hipparcos Number", "HIP 32503"},
        {"Smithsonian Astrophysical Observation", "SAO 1054"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.75481082),
        dec: Angle.Degrees(+80.24224330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23727",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23727"},
        {"Wilson Evans Batten Catalogue", "WEB 4632"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.51339636),
        dec: Angle.Degrees(+80.24784849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109646"},
        {"Hipparcos Number", "HIP 61351"},
        {"Geneva Identification System", "GEN# +1.00109646"},
        {"Smithsonian Astrophysical Observation", "SAO 2054"},
        {"Wilson Evans Batten Catalogue", "WEB 10919"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.56971574),
        dec: Angle.Degrees(+80.25057119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17717"},
        {"Hipparcos Number", "HIP 13934"},
        {"Geneva Identification System", "GEN# +1.00017717"},
        {"Smithsonian Astrophysical Observation", "SAO 469"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.712,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.88324449),
        dec: Angle.Degrees(+80.25087324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 157.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10292"},
        {"Hipparcos Number", "HIP 8244"},
        {"Smithsonian Astrophysical Observation", "SAO 277"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.53799553),
        dec: Angle.Degrees(+80.25369961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82993",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82993"},
        {"Smithsonian Astrophysical Observation", "SAO 2797"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.39950061),
        dec: Angle.Degrees(+80.25653147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37910"},
        {"Hipparcos Number", "HIP 27951"},
        {"Smithsonian Astrophysical Observation", "SAO 915"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.71519644),
        dec: Angle.Degrees(+80.26075934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13052",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13052"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.784,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.93802082),
        dec: Angle.Degrees(+80.26510655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 156.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -145.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62613"},
        {"Hipparcos Number", "HIP 38784"},
        {"Cincinnati Publication", "Ci 20 442"},
        {"Geneva Identification System", "GEN# +1.00062613"},
        {"Smithsonian Astrophysical Observation", "SAO 1254"},
        {"Wilson Evans Batten Catalogue", "WEB 7597"},
    },
    visualMagnitude: 6.55,
    bvColour: 0.719,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.07863116),
        dec: Angle.Degrees(+80.26532526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -475.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 89.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 221",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5 A"},
        {"Henry Draper", "HD 225020"},
        {"Hipparcos Number", "HIP 221"},
        {"Geneva Identification System", "GEN# +1.00225020"},
        {"Smithsonian Astrophysical Observation", "SAO 2"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.69321513),
        dec: Angle.Degrees(+80.28224146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163240"},
        {"Hipparcos Number", "HIP 86639"},
        {"Fundamental Katalog 5th Edition", "FK5 5554"},
        {"Geneva Identification System", "GEN# +1.00163240"},
        {"Smithsonian Astrophysical Observation", "SAO 2928"},
        {"Wilson Evans Batten Catalogue", "WEB 14610"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.54931583),
        dec: Angle.Degrees(+80.28243572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 227",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5 B"},
        {"Hipparcos Number", "HIP 227"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.70416774),
        dec: Angle.Degrees(+80.28651236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21407",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21407"},
        {"Smithsonian Astrophysical Observation", "SAO 718"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.92680659),
        dec: Angle.Degrees(+80.29136541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209111"},
        {"Hipparcos Number", "HIP 108133"},
        {"Fundamental Katalog 5th Edition", "FK5 3755"},
        {"Geneva Identification System", "GEN# +1.00209111"},
        {"Smithsonian Astrophysical Observation", "SAO 3658"},
    },
    visualMagnitude: 6.43,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.61059995),
        dec: Angle.Degrees(+80.30859438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22689"},
        {"Hipparcos Number", "HIP 17881"},
        {"Smithsonian Astrophysical Observation", "SAO 594"},
        {"Wilson Evans Batten Catalogue", "WEB 3435"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.37513156),
        dec: Angle.Degrees(+80.32243629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19643"},
        {"Hipparcos Number", "HIP 15463"},
        {"Geneva Identification System", "GEN# +1.00019643"},
        {"Smithsonian Astrophysical Observation", "SAO 526"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.85057894),
        dec: Angle.Degrees(+80.33393191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71090",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71090"},
        {"Smithsonian Astrophysical Observation", "SAO 2405"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.07390311),
        dec: Angle.Degrees(+80.34082799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104656",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104656"},
        {"Smithsonian Astrophysical Observation", "SAO 3527"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.99183593),
        dec: Angle.Degrees(+80.34279480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217691"},
        {"Hipparcos Number", "HIP 113499"},
        {"Fundamental Katalog 5th Edition", "FK5 3841"},
        {"Geneva Identification System", "GEN# +1.00217691"},
        {"Smithsonian Astrophysical Observation", "SAO 3825"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.78894260),
        dec: Angle.Degrees(+80.34394539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71065",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71065"},
        {"Smithsonian Astrophysical Observation", "SAO 2403"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.99996197),
        dec: Angle.Degrees(+80.34758954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149502"},
        {"Hipparcos Number", "HIP 80272"},
        {"Geneva Identification System", "GEN# +1.00149502"},
        {"Smithsonian Astrophysical Observation", "SAO 2707"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.78930179),
        dec: Angle.Degrees(+80.35127673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105190",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14916 AB"},
        {"Henry Draper", "HD 204129"},
        {"Hipparcos Number", "HIP 105190"},
        {"Geneva Identification System", "GEN# +1.00204129"},
        {"Smithsonian Astrophysical Observation", "SAO 3547"},
        {"Wilson Evans Batten Catalogue", "WEB 19104"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.62793268),
        dec: Angle.Degrees(+80.35320703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 160.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 107.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93945"},
        {"Hipparcos Number", "HIP 53368"},
        {"Smithsonian Astrophysical Observation", "SAO 1782"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.69757128),
        dec: Angle.Degrees(+80.35421698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41804"},
        {"Hipparcos Number", "HIP 30129"},
        {"Geneva Identification System", "GEN# +1.00041804"},
        {"Smithsonian Astrophysical Observation", "SAO 985"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.10203642),
        dec: Angle.Degrees(+80.35660676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216508"},
        {"Hipparcos Number", "HIP 112721"},
        {"Smithsonian Astrophysical Observation", "SAO 3798"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.41615918),
        dec: Angle.Degrees(+80.36771584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48938",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7583 AB"},
        {"Henry Draper", "HD 85471"},
        {"Hipparcos Number", "HIP 48938"},
        {"Smithsonian Astrophysical Observation", "SAO 1617"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.77050676),
        dec: Angle.Degrees(+80.37988901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36638"},
        {"Hipparcos Number", "HIP 27230"},
        {"Geneva Identification System", "GEN# +1.00036638"},
        {"Smithsonian Astrophysical Observation", "SAO 893"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.56205314),
        dec: Angle.Degrees(+80.39544437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85705"},
        {"Hipparcos Number", "HIP 49059"},
        {"Smithsonian Astrophysical Observation", "SAO 1619"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.15936972),
        dec: Angle.Degrees(+80.40244831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111781"},
        {"Hipparcos Number", "HIP 62542"},
        {"Geneva Identification System", "GEN# +1.00111781"},
        {"Smithsonian Astrophysical Observation", "SAO 2097"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.23013022),
        dec: Angle.Degrees(+80.40628220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26267"},
        {"Hipparcos Number", "HIP 20299"},
        {"Geneva Identification System", "GEN# +1.00026267"},
        {"Smithsonian Astrophysical Observation", "SAO 679"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.24196255),
        dec: Angle.Degrees(+80.41272137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17637"},
        {"Hipparcos Number", "HIP 13877"},
        {"Smithsonian Astrophysical Observation", "SAO 466"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.68522323),
        dec: Angle.Degrees(+80.41356333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92192"},
        {"Hipparcos Number", "HIP 52464"},
        {"Smithsonian Astrophysical Observation", "SAO 1758"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.87305872),
        dec: Angle.Degrees(+80.42709478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215867"},
        {"Hipparcos Number", "HIP 112246"},
        {"Smithsonian Astrophysical Observation", "SAO 3785"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.02640500),
        dec: Angle.Degrees(+80.43707043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75809",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9696 A"},
        {"Henry Draper", "HD 139777"},
        {"Hipparcos Number", "HIP 75809"},
        {"Geneva Identification System", "GEN# +1.00139777"},
        {"Smithsonian Astrophysical Observation", "SAO 2556"},
        {"Wilson Evans Batten Catalogue", "WEB 12904"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.29989331),
        dec: Angle.Degrees(+80.44834039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -225.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 107.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179091"},
        {"Hipparcos Number", "HIP 93159"},
        {"Smithsonian Astrophysical Observation", "SAO 3153"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.63587048),
        dec: Angle.Degrees(+80.44836688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75829",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9696 B"},
        {"Henry Draper", "HD 139813"},
        {"Hipparcos Number", "HIP 75829"},
        {"Geneva Identification System", "GEN# +1.00139813"},
        {"Smithsonian Astrophysical Observation", "SAO 2558"},
        {"Wilson Evans Batten Catalogue", "WEB 12908"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.803,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.35148709),
        dec: Angle.Degrees(+80.45001055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -217.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 105.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73795"},
        {"Hipparcos Number", "HIP 43401"},
        {"Smithsonian Astrophysical Observation", "SAO 1395"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.61072157),
        dec: Angle.Degrees(+80.46394600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193962"},
        {"Hipparcos Number", "HIP 99560"},
        {"Geneva Identification System", "GEN# +1.00193962"},
        {"Smithsonian Astrophysical Observation", "SAO 3356"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.06896568),
        dec: Angle.Degrees(+80.46795012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 81.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115337"},
        {"Hipparcos Number", "HIP 64437"},
        {"Fundamental Katalog 5th Edition", "FK5 3056"},
        {"Geneva Identification System", "GEN# +1.00115337J"},
        {"Smithsonian Astrophysical Observation", "SAO 2164"},
        {"Wilson Evans Batten Catalogue", "WEB 11389"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.10606335),
        dec: Angle.Degrees(+80.47128181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17169",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17169"},
        {"Smithsonian Astrophysical Observation", "SAO 581"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.16652032),
        dec: Angle.Degrees(+80.47567290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183456"},
        {"Hipparcos Number", "HIP 94801"},
        {"Smithsonian Astrophysical Observation", "SAO 3204"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.902,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.34231161),
        dec: Angle.Degrees(+80.47647329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188231"},
        {"Hipparcos Number", "HIP 96944"},
        {"Smithsonian Astrophysical Observation", "SAO 3272"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.61524730),
        dec: Angle.Degrees(+80.48507689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91075"},
        {"Hipparcos Number", "HIP 51883"},
        {"Fundamental Katalog 5th Edition", "FK5 2845"},
        {"Geneva Identification System", "GEN# +1.00091075"},
        {"Smithsonian Astrophysical Observation", "SAO 1735"},
        {"Wilson Evans Batten Catalogue", "WEB 9461"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.00841925),
        dec: Angle.Degrees(+80.49463792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69309"},
        {"Hipparcos Number", "HIP 41467"},
        {"Smithsonian Astrophysical Observation", "SAO 1334"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.87682971),
        dec: Angle.Degrees(+80.49963092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198327"},
        {"Hipparcos Number", "HIP 101960"},
        {"Smithsonian Astrophysical Observation", "SAO 3443"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.93034136),
        dec: Angle.Degrees(+80.49997755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62014"},
        {"Hipparcos Number", "HIP 38588"},
        {"Smithsonian Astrophysical Observation", "SAO 1247"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.52070273),
        dec: Angle.Degrees(+80.51533606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96547",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96547"},
        {"Smithsonian Astrophysical Observation", "SAO 3260"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.42612260),
        dec: Angle.Degrees(+80.51535622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50338",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50338"},
        {"Fundamental Katalog 5th Edition", "FK5 4913"},
        {"Smithsonian Astrophysical Observation", "SAO 1664"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.18695413),
        dec: Angle.Degrees(+80.52122259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205072"},
        {"Hipparcos Number", "HIP 105727"},
        {"Geneva Identification System", "GEN# +1.00205072"},
        {"Smithsonian Astrophysical Observation", "SAO 3568"},
        {"Wilson Evans Batten Catalogue", "WEB 19187"},
    },
    visualMagnitude: 5.97,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.20583722),
        dec: Angle.Degrees(+80.52485397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99759",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13708 AB"},
        {"Henry Draper", "HD 194375"},
        {"Hipparcos Number", "HIP 99759"},
        {"Smithsonian Astrophysical Observation", "SAO 3364"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.60864426),
        dec: Angle.Degrees(+80.53186540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25904"},
        {"Hipparcos Number", "HIP 20039"},
        {"Smithsonian Astrophysical Observation", "SAO 670"},
    },
    visualMagnitude: 6.39,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.46602609),
        dec: Angle.Degrees(+80.53576106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28941"},
        {"Hipparcos Number", "HIP 22154"},
        {"Fundamental Katalog 5th Edition", "FK5 4432"},
        {"Smithsonian Astrophysical Observation", "SAO 743"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.50367580),
        dec: Angle.Degrees(+80.54459357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80113"},
        {"Hipparcos Number", "HIP 46330"},
        {"Smithsonian Astrophysical Observation", "SAO 1513"},
        {"Wilson Evans Batten Catalogue", "WEB 8761"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.68920127),
        dec: Angle.Degrees(+80.54478053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51661"},
        {"Hipparcos Number", "HIP 34709"},
        {"Smithsonian Astrophysical Observation", "SAO 1134"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.82271957),
        dec: Angle.Degrees(+80.54498693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5534"},
        {"Hipparcos Number", "HIP 4704"},
        {"Fundamental Katalog 5th Edition", "FK5 2062"},
        {"Geneva Identification System", "GEN# +1.00005534"},
        {"Smithsonian Astrophysical Observation", "SAO 162"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.12327762),
        dec: Angle.Degrees(+80.54537407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199437"},
        {"Hipparcos Number", "HIP 102599"},
        {"Geneva Identification System", "GEN# +1.00199437"},
        {"Smithsonian Astrophysical Observation", "SAO 3467"},
        {"Wilson Evans Batten Catalogue", "WEB 18590"},
    },
    visualMagnitude: 5.36,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.88981878),
        dec: Angle.Degrees(+80.55235152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59504"},
        {"Hipparcos Number", "HIP 37581"},
        {"Smithsonian Astrophysical Observation", "SAO 1211"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.68394739),
        dec: Angle.Degrees(+80.55573637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223343"},
        {"Hipparcos Number", "HIP 117380"},
        {"Smithsonian Astrophysical Observation", "SAO 3971"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.99806986),
        dec: Angle.Degrees(+80.56493924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218765"},
        {"Hipparcos Number", "HIP 114194"},
        {"Smithsonian Astrophysical Observation", "SAO 3846"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.89657503),
        dec: Angle.Degrees(+80.56947063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44490"},
        {"Hipparcos Number", "HIP 31462"},
        {"Smithsonian Astrophysical Observation", "SAO 1026"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.86218359),
        dec: Angle.Degrees(+80.57321913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194422"},
        {"Hipparcos Number", "HIP 99779"},
        {"Geneva Identification System", "GEN# +1.00194422"},
        {"Smithsonian Astrophysical Observation", "SAO 3365"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.67228754),
        dec: Angle.Degrees(+80.57571841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101533"},
        {"Hipparcos Number", "HIP 57094"},
        {"Smithsonian Astrophysical Observation", "SAO 1920"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.56595663),
        dec: Angle.Degrees(+80.58070592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46417",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46417"},
        {"Cincinnati Publication", "Ci 20 519"},
        {"Geneva Identification System", "GEN# +0.08100297"},
        {"Smithsonian Astrophysical Observation", "SAO 1518"},
        {"Wilson Evans Batten Catalogue", "WEB 8771"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.98394716),
        dec: Angle.Degrees(+80.58129190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -437.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89414",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89414"},
        {"Smithsonian Astrophysical Observation", "SAO 3015"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.69930579),
        dec: Angle.Degrees(+80.58956715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29894",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29894"},
        {"Smithsonian Astrophysical Observation", "SAO 979"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.42126513),
        dec: Angle.Degrees(+80.59318221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69064",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69064"},
        {"Cincinnati Publication", "Ci 20 838"},
        {"Smithsonian Astrophysical Observation", "SAO 2339"},
        {"Wilson Evans Batten Catalogue", "WEB 12060"},
    },
    visualMagnitude: 10.31,
    bvColour: 1.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.05092982),
        dec: Angle.Degrees(+80.59859737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 208.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -543.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37463"},
        {"Hipparcos Number", "HIP 27719"},
        {"Smithsonian Astrophysical Observation", "SAO 906"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.04551503),
        dec: Angle.Degrees(+80.60890716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141218"},
        {"Hipparcos Number", "HIP 76450"},
        {"Fundamental Katalog 5th Edition", "FK5 3244"},
        {"Geneva Identification System", "GEN# +1.00141218"},
        {"Smithsonian Astrophysical Observation", "SAO 2576"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.20269875),
        dec: Angle.Degrees(+80.61437990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14500"},
        {"Hipparcos Number", "HIP 11483"},
        {"Fundamental Katalog 5th Edition", "FK5 4229"},
        {"Geneva Identification System", "GEN# +1.00014500"},
        {"Smithsonian Astrophysical Observation", "SAO 389"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.03342664),
        dec: Angle.Degrees(+80.61738446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111112"},
        {"Hipparcos Number", "HIP 62170"},
        {"Fundamental Katalog 5th Edition", "FK5 3017"},
        {"Geneva Identification System", "GEN# +1.00111112"},
        {"Renson", "Renson 32300"},
        {"Smithsonian Astrophysical Observation", "SAO 2080"},
        {"Wilson Evans Batten Catalogue", "WEB 11047"},
    },
    visualMagnitude: 6.33,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.10791915),
        dec: Angle.Degrees(+80.62112781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116633"},
        {"Hipparcos Number", "HIP 65064"},
        {"Smithsonian Astrophysical Observation", "SAO 2196"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.04756892),
        dec: Angle.Degrees(+80.62435216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54942"},
        {"Hipparcos Number", "HIP 35874"},
        {"Smithsonian Astrophysical Observation", "SAO 1159"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.94978054),
        dec: Angle.Degrees(+80.62629461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145742"},
        {"Hipparcos Number", "HIP 78424"},
        {"Geneva Identification System", "GEN# +1.00145742"},
        {"Smithsonian Astrophysical Observation", "SAO 2652"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.15303746),
        dec: Angle.Degrees(+80.62773813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103902"},
        {"Hipparcos Number", "HIP 58366"},
        {"Geneva Identification System", "GEN# +1.00103902"},
        {"Smithsonian Astrophysical Observation", "SAO 1957"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.52487429),
        dec: Angle.Degrees(+80.63211878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218737"},
        {"Hipparcos Number", "HIP 114178"},
        {"Smithsonian Astrophysical Observation", "SAO 3845"},
    },
    visualMagnitude: 7.88,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.83479344),
        dec: Angle.Degrees(+80.63754301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116960",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116960"},
    },
    visualMagnitude: 10.45,
    bvColour: 1.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.63010407),
        dec: Angle.Degrees(+80.63837878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 158.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29280"},
        {"Hipparcos Number", "HIP 22405"},
        {"Geneva Identification System", "GEN# +1.00029280"},
        {"Smithsonian Astrophysical Observation", "SAO 754"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.32275256),
        dec: Angle.Degrees(+80.65062924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4339",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4339"},
        {"Smithsonian Astrophysical Observation", "SAO 151"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.90320981),
        dec: Angle.Degrees(+80.66016180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12312"},
        {"Hipparcos Number", "HIP 9908"},
        {"Smithsonian Astrophysical Observation", "SAO 342"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.88417132),
        dec: Angle.Degrees(+80.66494012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1092",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1092"},
    },
    visualMagnitude: 11.14,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.40754280),
        dec: Angle.Degrees(+80.66533940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 250.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 182.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106882",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106882"},
        {"Smithsonian Astrophysical Observation", "SAO 3610"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.867,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.73404855),
        dec: Angle.Degrees(+80.67750303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 144.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 160.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39859",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39859"},
        {"Smithsonian Astrophysical Observation", "SAO 1286"},
    },
    visualMagnitude: 10.36,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.14231546),
        dec: Angle.Degrees(+80.68117907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136673"},
        {"Hipparcos Number", "HIP 74343"},
        {"Smithsonian Astrophysical Observation", "SAO 2513"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.90742774),
        dec: Angle.Degrees(+80.69511726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19461",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2963 AB"},
        {"Hipparcos Number", "HIP 19461"},
        {"Geneva Identification System", "GEN# +1.00025007J"},
        {"Smithsonian Astrophysical Observation", "SAO 650"},
    },
    visualMagnitude: 5.10,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.51160698),
        dec: Angle.Degrees(+80.69867409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213417"},
        {"Hipparcos Number", "HIP 110724"},
        {"Smithsonian Astrophysical Observation", "SAO 3746"},
    },
    visualMagnitude: 6.68,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.50068495),
        dec: Angle.Degrees(+80.70156136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208020"},
        {"Hipparcos Number", "HIP 107477"},
        {"Fundamental Katalog 5th Edition", "FK5 5921"},
        {"Geneva Identification System", "GEN# +1.00208020"},
        {"Smithsonian Astrophysical Observation", "SAO 3632"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.53836253),
        dec: Angle.Degrees(+80.70970501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47028",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47028"},
        {"Smithsonian Astrophysical Observation", "SAO 1544"},
    },
    visualMagnitude: 9.65,
    bvColour: 1.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.76521863),
        dec: Angle.Degrees(+80.71118987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149444"},
        {"Hipparcos Number", "HIP 80192"},
        {"Smithsonian Astrophysical Observation", "SAO 2703"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.57266855),
        dec: Angle.Degrees(+80.72542846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10956",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1754 AB"},
        {"Henry Draper", "HD 13714"},
        {"Hipparcos Number", "HIP 10956"},
        {"Smithsonian Astrophysical Observation", "SAO 372"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.27820305),
        dec: Angle.Degrees(+80.72664969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181178"},
        {"Hipparcos Number", "HIP 93839"},
        {"Smithsonian Astrophysical Observation", "SAO 3175"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.64937521),
        dec: Angle.Degrees(+80.72984359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100991"},
        {"Hipparcos Number", "HIP 56828"},
        {"Smithsonian Astrophysical Observation", "SAO 1908"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.74039072),
        dec: Angle.Degrees(+80.74354543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33688",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33688"},
        {"Smithsonian Astrophysical Observation", "SAO 1091"},
    },
    visualMagnitude: 9.93,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.98449318),
        dec: Angle.Degrees(+80.74949357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132610"},
        {"Hipparcos Number", "HIP 72581"},
        {"Smithsonian Astrophysical Observation", "SAO 2458"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.62355953),
        dec: Angle.Degrees(+80.74981694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181467"},
        {"Hipparcos Number", "HIP 93948"},
        {"Smithsonian Astrophysical Observation", "SAO 3178"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.93820471),
        dec: Angle.Degrees(+80.75368079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88140",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88140"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.733,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.04428347),
        dec: Angle.Degrees(+80.75629035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 170.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121778"},
        {"Hipparcos Number", "HIP 67592"},
        {"Smithsonian Astrophysical Observation", "SAO 2289"},
    },
    visualMagnitude: 6.67,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.75174017),
        dec: Angle.Degrees(+80.76792872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139951"},
        {"Hipparcos Number", "HIP 75874"},
        {"Fundamental Katalog 5th Edition", "FK5 5370"},
        {"Geneva Identification System", "GEN# +1.00139951"},
        {"Smithsonian Astrophysical Observation", "SAO 2562"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.47423910),
        dec: Angle.Degrees(+80.77103774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50153",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50153"},
        {"Smithsonian Astrophysical Observation", "SAO 1655"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.57501179),
        dec: Angle.Degrees(+80.77918303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30932"},
        {"Hipparcos Number", "HIP 23640"},
        {"Geneva Identification System", "GEN# +1.00030932"},
        {"Smithsonian Astrophysical Observation", "SAO 794"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.22188065),
        dec: Angle.Degrees(+80.78145975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113664",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16469 AB"},
        {"Henry Draper", "HD 217992"},
        {"Hipparcos Number", "HIP 113664"},
        {"Smithsonian Astrophysical Observation", "SAO 3830"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.31154175),
        dec: Angle.Degrees(+80.78172968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104197",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104197"},
    },
    visualMagnitude: 10.84,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.65568835),
        dec: Angle.Degrees(+80.79316809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 266.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 159.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128642"},
        {"Hipparcos Number", "HIP 70857"},
        {"Geneva Identification System", "GEN# +1.00128642"},
        {"Smithsonian Astrophysical Observation", "SAO 2392"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.774,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.34403747),
        dec: Angle.Degrees(+80.81017568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -132.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26836"},
        {"Hipparcos Number", "HIP 20776"},
        {"Fundamental Katalog 5th Edition", "FK5 2321"},
        {"Geneva Identification System", "GEN# +1.00026836"},
        {"Smithsonian Astrophysical Observation", "SAO 691"},
        {"Wilson Evans Batten Catalogue", "WEB 3982"},
    },
    visualMagnitude: 5.42,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.76206107),
        dec: Angle.Degrees(+80.82421018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77246"},
        {"Hipparcos Number", "HIP 45097"},
        {"Fundamental Katalog 5th Edition", "FK5 4819"},
        {"Geneva Identification System", "GEN# +1.00077246"},
        {"Smithsonian Astrophysical Observation", "SAO 1453"},
    },
    visualMagnitude: 6.37,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.80303189),
        dec: Angle.Degrees(+80.82894610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144800"},
        {"Hipparcos Number", "HIP 77992"},
        {"Smithsonian Astrophysical Observation", "SAO 2637"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.89278259),
        dec: Angle.Degrees(+80.83958353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111016",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111016"},
        {"Smithsonian Astrophysical Observation", "SAO 3755"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.36819140),
        dec: Angle.Degrees(+80.83985633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111008",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111008"},
    },
    visualMagnitude: 10.49,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.34886774),
        dec: Angle.Degrees(+80.84289246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28791"},
        {"Hipparcos Number", "HIP 22090"},
        {"Geneva Identification System", "GEN# +1.00028791"},
        {"Smithsonian Astrophysical Observation", "SAO 739"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.28428937),
        dec: Angle.Degrees(+80.85271544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104216"},
        {"Hipparcos Number", "HIP 58545"},
        {"Fundamental Katalog 5th Edition", "FK5 3957"},
        {"Geneva Identification System", "GEN# +1.00104216"},
        {"Smithsonian Astrophysical Observation", "SAO 1967"},
        {"Wilson Evans Batten Catalogue", "WEB 10451"},
    },
    visualMagnitude: 6.21,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.07851186),
        dec: Angle.Degrees(+80.85327729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155153"},
        {"Hipparcos Number", "HIP 82894"},
        {"Fundamental Katalog 5th Edition", "FK5 5495"},
        {"Geneva Identification System", "GEN# +1.00155153"},
        {"Smithsonian Astrophysical Observation", "SAO 2793"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.10059493),
        dec: Angle.Degrees(+80.85955290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6167",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1030 AB"},
        {"Henry Draper", "HD 7471"},
        {"Hipparcos Number", "HIP 6167"},
        {"Geneva Identification System", "GEN# +1.00007471J"},
        {"Smithsonian Astrophysical Observation", "SAO 218"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.77948365),
        dec: Angle.Degrees(+80.86179406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85221",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85221"},
        {"Smithsonian Astrophysical Observation", "SAO 2879"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.20998396),
        dec: Angle.Degrees(+80.86315033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43014"},
        {"Hipparcos Number", "HIP 30764"},
        {"Geneva Identification System", "GEN# +1.00043014"},
        {"Smithsonian Astrophysical Observation", "SAO 1003"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.96572846),
        dec: Angle.Degrees(+80.86745524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113435"},
        {"Hipparcos Number", "HIP 63444"},
        {"Geneva Identification System", "GEN# +1.00113435"},
        {"Smithsonian Astrophysical Observation", "SAO 2128"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.742,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.01054321),
        dec: Angle.Degrees(+80.87446381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27909"},
        {"Hipparcos Number", "HIP 21487"},
        {"Geneva Identification System", "GEN# +1.00027909"},
        {"Smithsonian Astrophysical Observation", "SAO 721"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.22091093),
        dec: Angle.Degrees(+80.88182342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8519",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1411 AB"},
        {"Henry Draper", "HD 10648"},
        {"Hipparcos Number", "HIP 8519"},
        {"Smithsonian Astrophysical Observation", "SAO 291"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.47135474),
        dec: Angle.Degrees(+80.88644746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6198",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1030 C"},
        {"Henry Draper", "HD 7505"},
        {"Hipparcos Number", "HIP 6198"},
        {"Geneva Identification System", "GEN# +1.00007505"},
        {"Smithsonian Astrophysical Observation", "SAO 221"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.87232349),
        dec: Angle.Degrees(+80.89419624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57508"},
        {"Hipparcos Number", "HIP 36858"},
        {"Smithsonian Astrophysical Observation", "SAO 1194"},
        {"Wilson Evans Batten Catalogue", "WEB 7322"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.66594150),
        dec: Angle.Degrees(+80.89668988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11150"},
        {"Hipparcos Number", "HIP 9014"},
        {"Geneva Identification System", "GEN# +1.00011150"},
        {"Smithsonian Astrophysical Observation", "SAO 312"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.01052483),
        dec: Angle.Degrees(+80.90864534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2293",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2293"},
    },
    visualMagnitude: 11.37,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.32196501),
        dec: Angle.Degrees(+80.91340034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 300.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 385.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48679"},
        {"Hipparcos Number", "HIP 33548"},
        {"Smithsonian Astrophysical Observation", "SAO 1083"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.57537706),
        dec: Angle.Degrees(+80.92843958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27133"},
        {"Hipparcos Number", "HIP 20957"},
        {"Smithsonian Astrophysical Observation", "SAO 701"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.40342120),
        dec: Angle.Degrees(+80.93170385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142795"},
        {"Hipparcos Number", "HIP 77102"},
        {"Smithsonian Astrophysical Observation", "SAO 2604"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.15209322),
        dec: Angle.Degrees(+80.93216890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109518"},
        {"Hipparcos Number", "HIP 61271"},
        {"Geneva Identification System", "GEN# +1.00109518"},
        {"Smithsonian Astrophysical Observation", "SAO 2052"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.936,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.34611095),
        dec: Angle.Degrees(+80.94483607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178588"},
        {"Hipparcos Number", "HIP 92908"},
        {"Smithsonian Astrophysical Observation", "SAO 3149"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.94906004),
        dec: Angle.Degrees(+80.94553381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96589"},
        {"Hipparcos Number", "HIP 54640"},
        {"Smithsonian Astrophysical Observation", "SAO 1831"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.774,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.75189034),
        dec: Angle.Degrees(+80.94889625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148781"},
        {"Hipparcos Number", "HIP 79829"},
        {"Geneva Identification System", "GEN# +1.00148781"},
        {"Smithsonian Astrophysical Observation", "SAO 2693"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.41436701),
        dec: Angle.Degrees(+80.94937746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24716"},
        {"Hipparcos Number", "HIP 19265"},
        {"Smithsonian Astrophysical Observation", "SAO 646"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.93883603),
        dec: Angle.Degrees(+80.97646941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11917"},
        {"Hipparcos Number", "HIP 9633"},
        {"Geneva Identification System", "GEN# +1.00011917"},
        {"Smithsonian Astrophysical Observation", "SAO 332"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.95189238),
        dec: Angle.Degrees(+81.00002931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42964",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42964"},
    },
    visualMagnitude: 12.81,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.36492082),
        dec: Angle.Degrees(+81.00285617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -158.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221468"},
        {"Hipparcos Number", "HIP 116026"},
        {"Geneva Identification System", "GEN# +1.00221468"},
        {"Smithsonian Astrophysical Observation", "SAO 3923"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.64473854),
        dec: Angle.Degrees(+81.00425858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202490"},
        {"Hipparcos Number", "HIP 104212"},
        {"Smithsonian Astrophysical Observation", "SAO 3514"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.70810121),
        dec: Angle.Degrees(+81.02039907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56123",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8181 A"},
        {"Henry Draper", "HD 99687"},
        {"Hipparcos Number", "HIP 56123"},
        {"Geneva Identification System", "GEN# +1.00099687"},
        {"Smithsonian Astrophysical Observation", "SAO 1876"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.57487301),
        dec: Angle.Degrees(+81.03723615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95544"},
        {"Hipparcos Number", "HIP 54203"},
        {"Geneva Identification System", "GEN# +1.00095544"},
        {"Smithsonian Astrophysical Observation", "SAO 1815"},
        {"Wilson Evans Batten Catalogue", "WEB 9796"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.33242834),
        dec: Angle.Degrees(+81.03929294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -214.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56118",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8181 B"},
        {"Hipparcos Number", "HIP 56118"},
        {"Smithsonian Astrophysical Observation", "SAO 1875"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.54947372),
        dec: Angle.Degrees(+81.04088970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44815",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7163 AB"},
        {"Henry Draper", "HD 76702"},
        {"Hipparcos Number", "HIP 44815"},
        {"Smithsonian Astrophysical Observation", "SAO 1442"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.99335165),
        dec: Angle.Degrees(+81.04120710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138366"},
        {"Hipparcos Number", "HIP 75078"},
        {"Geneva Identification System", "GEN# +1.00138366"},
        {"Smithsonian Astrophysical Observation", "SAO 2535"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.13362199),
        dec: Angle.Degrees(+81.04304023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65625"},
        {"Hipparcos Number", "HIP 40150"},
        {"Geneva Identification System", "GEN# +1.00065625"},
        {"Smithsonian Astrophysical Observation", "SAO 1295"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.98316493),
        dec: Angle.Degrees(+81.05205336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34506"},
        {"Hipparcos Number", "HIP 25924"},
        {"Fundamental Katalog 5th Edition", "FK5 4503"},
        {"Geneva Identification System", "GEN# +1.00034506"},
        {"Smithsonian Astrophysical Observation", "SAO 860"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.98423463),
        dec: Angle.Degrees(+81.05679433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17552"},
        {"Hipparcos Number", "HIP 13859"},
        {"Geneva Identification System", "GEN# +1.00017552"},
        {"Smithsonian Astrophysical Observation", "SAO 464"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.61150864),
        dec: Angle.Degrees(+81.05987750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91943",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91943"},
        {"Smithsonian Astrophysical Observation", "SAO 3111"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.13311446),
        dec: Angle.Degrees(+81.06541397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38725",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38725"},
        {"Smithsonian Astrophysical Observation", "SAO 1251"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.92438521),
        dec: Angle.Degrees(+81.07065443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56"},
        {"Hipparcos Number", "HIP 483"},
        {"Smithsonian Astrophysical Observation", "SAO 13"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.43904170),
        dec: Angle.Degrees(+81.07146901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89320",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89320"},
    },
    visualMagnitude: 11.15,
    bvColour: 1.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.37814484),
        dec: Angle.Degrees(+81.07592627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196925"},
        {"Hipparcos Number", "HIP 101082"},
        {"Geneva Identification System", "GEN# +1.00196925A"},
        {"Smithsonian Astrophysical Observation", "SAO 3413"},
        {"Wilson Evans Batten Catalogue", "WEB 18255"},
    },
    visualMagnitude: 5.96,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.36380725),
        dec: Angle.Degrees(+81.09073843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 221.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99945"},
        {"Hipparcos Number", "HIP 56253"},
        {"Fundamental Katalog 5th Edition", "FK5 3956"},
        {"Geneva Identification System", "GEN# +1.00099945"},
        {"Renson", "Renson 28760"},
        {"Smithsonian Astrophysical Observation", "SAO 1884"},
        {"Wilson Evans Batten Catalogue", "WEB 10115"},
    },
    visualMagnitude: 6.12,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.96282894),
        dec: Angle.Degrees(+81.12717398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -144.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101166",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101166"},
        {"Geneva Identification System", "GEN# +0.08000662"},
        {"Geneva Identification System 2", "GEN# +1.00196925B"},
        {"Smithsonian Astrophysical Observation", "SAO 3415"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.59019935),
        dec: Angle.Degrees(+81.13894746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 221.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109174",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109174"},
        {"Smithsonian Astrophysical Observation", "SAO 3695"},
    },
    visualMagnitude: 10.44,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.74316680),
        dec: Angle.Degrees(+81.14095039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147620"},
        {"Hipparcos Number", "HIP 79216"},
        {"Fundamental Katalog 5th Edition", "FK5 5425"},
        {"Geneva Identification System", "GEN# +1.00147620"},
        {"Smithsonian Astrophysical Observation", "SAO 2675"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.50784273),
        dec: Angle.Degrees(+81.14405174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26802",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26802"},
        {"Smithsonian Astrophysical Observation", "SAO 884"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.706,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.37952975),
        dec: Angle.Degrees(+81.14778283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201998"},
        {"Hipparcos Number", "HIP 103938"},
        {"Geneva Identification System", "GEN# +1.00201998"},
        {"Smithsonian Astrophysical Observation", "SAO 3504"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.90003543),
        dec: Angle.Degrees(+81.16085186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66724",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9003"},
        {"Hipparcos Number", "HIP 66724"},
        {"Smithsonian Astrophysical Observation", "SAO 2259"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.16037353),
        dec: Angle.Degrees(+81.18089045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89881"},
        {"Hipparcos Number", "HIP 51278"},
        {"Geneva Identification System", "GEN# +1.00089881"},
        {"Smithsonian Astrophysical Observation", "SAO 1703"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.10964113),
        dec: Angle.Degrees(+81.18744130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30338"},
        {"Hipparcos Number", "HIP 23265"},
        {"Fundamental Katalog 5th Edition", "FK5 3948"},
        {"Smithsonian Astrophysical Observation", "SAO 783"},
        {"Wilson Evans Batten Catalogue", "WEB 4519"},
    },
    visualMagnitude: 5.09,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.08632052),
        dec: Angle.Degrees(+81.19402107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63885",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63885"},
        {"Smithsonian Astrophysical Observation", "SAO 2143"},
    },
    visualMagnitude: 10.69,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.38532458),
        dec: Angle.Degrees(+81.19461485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31192",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31192"},
        {"Smithsonian Astrophysical Observation", "SAO 1014"},
    },
    visualMagnitude: 10.25,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.16597165),
        dec: Angle.Degrees(+81.21553575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176130"},
        {"Hipparcos Number", "HIP 91981"},
        {"Smithsonian Astrophysical Observation", "SAO 3114"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.21549023),
        dec: Angle.Degrees(+81.21819629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90102",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90102"},
        {"Smithsonian Astrophysical Observation", "SAO 3041"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.81623842),
        dec: Angle.Degrees(+81.22030351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -109.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 154.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89709",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89709"},
        {"Smithsonian Astrophysical Observation", "SAO 3024"},
    },
    visualMagnitude: 10.90,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.63326373),
        dec: Angle.Degrees(+81.22262721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 197.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24226"},
        {"Hipparcos Number", "HIP 18940"},
        {"Smithsonian Astrophysical Observation", "SAO 638"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.89522309),
        dec: Angle.Degrees(+81.22648121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203501"},
        {"Hipparcos Number", "HIP 104756"},
        {"Fundamental Katalog 5th Edition", "FK5 3964"},
        {"Geneva Identification System", "GEN# +1.00203501"},
        {"Smithsonian Astrophysical Observation", "SAO 3534"},
        {"Wilson Evans Batten Catalogue", "WEB 19056"},
    },
    visualMagnitude: 6.12,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.33997944),
        dec: Angle.Degrees(+81.23096071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82840",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82840"},
        {"Smithsonian Astrophysical Observation", "SAO 2791"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.93711050),
        dec: Angle.Degrees(+81.23921881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18548",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18548"},
    },
    visualMagnitude: 12.93,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.52281284),
        dec: Angle.Degrees(+81.23966456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55075"},
        {"Hipparcos Number", "HIP 36019"},
        {"Geneva Identification System", "GEN# +1.00055075"},
        {"Smithsonian Astrophysical Observation", "SAO 1164"},
        {"Wilson Evans Batten Catalogue", "WEB 7173"},
    },
    visualMagnitude: 6.30,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.34154368),
        dec: Angle.Degrees(+81.25753345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94790"},
        {"Hipparcos Number", "HIP 53819"},
        {"Smithsonian Astrophysical Observation", "SAO 1799"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.17272823),
        dec: Angle.Degrees(+81.25999782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58349",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58349"},
        {"Smithsonian Astrophysical Observation", "SAO 1956"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.833,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.49330240),
        dec: Angle.Degrees(+81.26408432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117911"},
        {"Hipparcos Number", "HIP 65672"},
        {"Fundamental Katalog 5th Edition", "FK5 5186"},
        {"Geneva Identification System", "GEN# +1.00117911"},
        {"Smithsonian Astrophysical Observation", "SAO 2218"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.98128712),
        dec: Angle.Degrees(+81.26523340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98322",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98322"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.64796758),
        dec: Angle.Degrees(+81.26967372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 198.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35655",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35655"},
        {"Smithsonian Astrophysical Observation", "SAO 1155"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.36301629),
        dec: Angle.Degrees(+81.27383809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75089"},
        {"Hipparcos Number", "HIP 44088"},
        {"Geneva Identification System", "GEN# +1.00075089"},
        {"Smithsonian Astrophysical Observation", "SAO 1421"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.70381638),
        dec: Angle.Degrees(+81.28534882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217200"},
        {"Hipparcos Number", "HIP 113165"},
        {"Geneva Identification System", "GEN# +1.00217200"},
        {"Smithsonian Astrophysical Observation", "SAO 3814"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.74828114),
        dec: Angle.Degrees(+81.29120530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12467"},
        {"Hipparcos Number", "HIP 10054"},
        {"Fundamental Katalog 5th Edition", "FK5 3943"},
        {"Geneva Identification System", "GEN# +1.00012467"},
        {"Smithsonian Astrophysical Observation", "SAO 344"},
        {"Wilson Evans Batten Catalogue", "WEB 2103"},
    },
    visualMagnitude: 6.05,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.35601743),
        dec: Angle.Degrees(+81.29592818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222821"},
        {"Hipparcos Number", "HIP 116974"},
        {"Smithsonian Astrophysical Observation", "SAO 3954"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.69164179),
        dec: Angle.Degrees(+81.30062703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87573",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87573"},
        {"Smithsonian Astrophysical Observation", "SAO 2970"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.35458474),
        dec: Angle.Degrees(+81.31148935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7388",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7388"},
        {"Smithsonian Astrophysical Observation", "SAO 250"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.81661070),
        dec: Angle.Degrees(+81.31280775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77002",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9798 A"},
        {"Henry Draper", "HD 142653"},
        {"Hipparcos Number", "HIP 77002"},
        {"Smithsonian Astrophysical Observation", "SAO 2599"},
        {"Wilson Evans Batten Catalogue", "WEB 13061"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.84427427),
        dec: Angle.Degrees(+81.31929499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81817"},
        {"Hipparcos Number", "HIP 47193"},
        {"Fundamental Katalog 5th Edition", "FK5 910"},
        {"Geneva Identification System", "GEN# +1.00081817"},
        {"Smithsonian Astrophysical Observation", "SAO 1551"},
        {"Wilson Evans Batten Catalogue", "WEB 8877"},
    },
    visualMagnitude: 4.28,
    bvColour: 1.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.27229969),
        dec: Angle.Degrees(+81.32642085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31529",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31529"},
        {"Smithsonian Astrophysical Observation", "SAO 1025"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.01511771),
        dec: Angle.Degrees(+81.32910104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 104.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62434"},
        {"Hipparcos Number", "HIP 38869"},
        {"Smithsonian Astrophysical Observation", "SAO 1255"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.31682948),
        dec: Angle.Degrees(+81.35229829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38126"},
        {"Hipparcos Number", "HIP 28249"},
        {"Geneva Identification System", "GEN# +1.00038126"},
        {"Smithsonian Astrophysical Observation", "SAO 920"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.881,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.54673429),
        dec: Angle.Degrees(+81.36396286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91157",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91157"},
        {"Smithsonian Astrophysical Observation", "SAO 3089"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.844,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.97160876),
        dec: Angle.Degrees(+81.36885512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 334.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10733"},
        {"Hipparcos Number", "HIP 8624"},
        {"Smithsonian Astrophysical Observation", "SAO 294"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.80984035),
        dec: Angle.Degrees(+81.37464793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2534"},
        {"Hipparcos Number", "HIP 2419"},
        {"Geneva Identification System", "GEN# +1.00002534"},
        {"Smithsonian Astrophysical Observation", "SAO 82"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.71114628),
        dec: Angle.Degrees(+81.37511450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223189"},
        {"Hipparcos Number", "HIP 117249"},
        {"Geneva Identification System", "GEN# +1.00223189"},
        {"Smithsonian Astrophysical Observation", "SAO 3969"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.62204417),
        dec: Angle.Degrees(+81.37806712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215318"},
        {"Henry Draper 2", "HD 215319"},
        {"Hipparcos Number", "HIP 111852"},
        {"Fundamental Katalog 5th Edition", "FK5 3966"},
        {"Geneva Identification System", "GEN# +1.00215318"},
        {"Smithsonian Astrophysical Observation", "SAO 3769"},
        {"Wilson Evans Batten Catalogue", "WEB 19980"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.757,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.85340873),
        dec: Angle.Degrees(+81.39205487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106765",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106765"},
        {"Smithsonian Astrophysical Observation", "SAO 3604"},
    },
    visualMagnitude: 10.13,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.40203619),
        dec: Angle.Degrees(+81.40073488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196787"},
        {"Hipparcos Number", "HIP 100965"},
        {"Fundamental Katalog 5th Edition", "FK5 3963"},
        {"Geneva Identification System", "GEN# +1.00196787A"},
        {"Smithsonian Astrophysical Observation", "SAO 3408"},
        {"Wilson Evans Batten Catalogue", "WEB 18237"},
    },
    visualMagnitude: 5.38,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.06022697),
        dec: Angle.Degrees(+81.42266925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26123"},
        {"Hipparcos Number", "HIP 20315"},
        {"Smithsonian Astrophysical Observation", "SAO 677"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.28042948),
        dec: Angle.Degrees(+81.42854292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13172",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13172"},
        {"Renson", "Renson 4160"},
        {"Smithsonian Astrophysical Observation", "SAO 437"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.35156549),
        dec: Angle.Degrees(+81.42932280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9653"},
        {"Hipparcos Number", "HIP 7813"},
        {"Smithsonian Astrophysical Observation", "SAO 263"},
    },
    visualMagnitude: 7.14,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.13193560),
        dec: Angle.Degrees(+81.42982274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196565"},
        {"Hipparcos Number", "HIP 100843"},
        {"Geneva Identification System", "GEN# +1.00196565"},
        {"Geneva Identification System 2", "GEN# +1.00196787C"},
        {"Smithsonian Astrophysical Observation", "SAO 3405"},
        {"Wilson Evans Batten Catalogue", "WEB 18221"},
    },
    visualMagnitude: 6.55,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.70162878),
        dec: Angle.Degrees(+81.43409780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16458"},
        {"Hipparcos Number", "HIP 13055"},
        {"Fundamental Katalog 5th Edition", "FK5 3945"},
        {"Geneva Identification System", "GEN# +1.00016458"},
        {"Smithsonian Astrophysical Observation", "SAO 433"},
        {"Wilson Evans Batten Catalogue", "WEB 2635"},
    },
    visualMagnitude: 5.80,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.94847766),
        dec: Angle.Degrees(+81.44866603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70959",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70959"},
        {"Smithsonian Astrophysical Observation", "SAO 2402"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.71348868),
        dec: Angle.Degrees(+81.45203413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99209",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99209"},
        {"Smithsonian Astrophysical Observation", "SAO 3349"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.11067355),
        dec: Angle.Degrees(+81.45665006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14844",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2348 A"},
        {"Henry Draper", "HD 18778"},
        {"Hipparcos Number", "HIP 14844"},
        {"Fundamental Katalog 5th Edition", "FK5 3946"},
        {"Geneva Identification System", "GEN# +1.00018778"},
        {"Renson", "Renson 4700"},
        {"Smithsonian Astrophysical Observation", "SAO 500"},
        {"Wilson Evans Batten Catalogue", "WEB 2866"},
    },
    visualMagnitude: 5.92,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.92855231),
        dec: Angle.Degrees(+81.47071191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60725",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60725"},
        {"Smithsonian Astrophysical Observation", "SAO 2041"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.68201764),
        dec: Angle.Degrees(+81.47397283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5880",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5880"},
        {"Geneva Identification System", "GEN# +0.08000032"},
        {"Smithsonian Astrophysical Observation", "SAO 208"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.87832014),
        dec: Angle.Degrees(+81.47973601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10144",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1659 AB"},
        {"Henry Draper", "HD 12543"},
        {"Hipparcos Number", "HIP 10144"},
        {"Smithsonian Astrophysical Observation", "SAO 345"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.62430027),
        dec: Angle.Degrees(+81.48201620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22742",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22742"},
    },
    visualMagnitude: 11.17,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.38790348),
        dec: Angle.Degrees(+81.48424869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29579"},
        {"Hipparcos Number", "HIP 22735"},
        {"Geneva Identification System", "GEN# +1.00029579"},
        {"Smithsonian Astrophysical Observation", "SAO 758"},
    },
    visualMagnitude: 9.42,
    bvColour: -0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.36423072),
        dec: Angle.Degrees(+81.49008391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89500"},
        {"Hipparcos Number", "HIP 51081"},
        {"Smithsonian Astrophysical Observation", "SAO 1690"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.55128483),
        dec: Angle.Degrees(+81.50626734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39861"},
        {"Hipparcos Number", "HIP 29269"},
        {"Smithsonian Astrophysical Observation", "SAO 952"},
        {"Wilson Evans Batten Catalogue", "WEB 5740"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.55475990),
        dec: Angle.Degrees(+81.51372745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -364.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10908",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10908"},
    },
    visualMagnitude: 11.94,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.09781608),
        dec: Angle.Degrees(+81.52944036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22991"},
        {"Hipparcos Number", "HIP 18209"},
        {"Geneva Identification System", "GEN# +1.00022991"},
        {"Smithsonian Astrophysical Observation", "SAO 602"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.919,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.40825293),
        dec: Angle.Degrees(+81.54846895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7340"},
        {"Hipparcos Number", "HIP 6090"},
        {"Fundamental Katalog 5th Edition", "FK5 4116"},
        {"Geneva Identification System", "GEN# +1.00007340"},
        {"Smithsonian Astrophysical Observation", "SAO 211"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.54752178),
        dec: Angle.Degrees(+81.56054611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92179"},
        {"Hipparcos Number", "HIP 52496"},
        {"Smithsonian Astrophysical Observation", "SAO 1760"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.99973164),
        dec: Angle.Degrees(+81.56778545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24163"},
        {"Hipparcos Number", "HIP 18936"},
        {"Geneva Identification System", "GEN# +1.00024163"},
        {"Smithsonian Astrophysical Observation", "SAO 637"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.87998772),
        dec: Angle.Degrees(+81.57678040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91328"},
        {"Hipparcos Number", "HIP 52078"},
        {"Smithsonian Astrophysical Observation", "SAO 1739"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.62220898),
        dec: Angle.Degrees(+81.58253823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189652"},
        {"Hipparcos Number", "HIP 97425"},
        {"Geneva Identification System", "GEN# +1.00189652"},
        {"Renson", "Renson 52600"},
        {"Smithsonian Astrophysical Observation", "SAO 3293"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.01858137),
        dec: Angle.Degrees(+81.58607884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83034"},
        {"Hipparcos Number", "HIP 47807"},
        {"Smithsonian Astrophysical Observation", "SAO 1573"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.19055993),
        dec: Angle.Degrees(+81.59947160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41392",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41392"},
        {"Smithsonian Astrophysical Observation", "SAO 1327"},
    },
    visualMagnitude: 9.66,
    bvColour: 1.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.66954089),
        dec: Angle.Degrees(+81.60198246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68832",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68832"},
        {"Smithsonian Astrophysical Observation", "SAO 2331"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.41092864),
        dec: Angle.Degrees(+81.60663279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122832"},
        {"Hipparcos Number", "HIP 68104"},
        {"Smithsonian Astrophysical Observation", "SAO 2308"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.14493287),
        dec: Angle.Degrees(+81.61412794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72818",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72818"},
        {"Smithsonian Astrophysical Observation", "SAO 2462"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.25990365),
        dec: Angle.Degrees(+81.61585449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26209"},
        {"Hipparcos Number", "HIP 20402"},
        {"Smithsonian Astrophysical Observation", "SAO 680"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.52474385),
        dec: Angle.Degrees(+81.63215971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30096"},
        {"Hipparcos Number", "HIP 23154"},
        {"Smithsonian Astrophysical Observation", "SAO 777"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.72337731),
        dec: Angle.Degrees(+81.63615009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15342"},
        {"Hipparcos Number", "HIP 12208"},
        {"Smithsonian Astrophysical Observation", "SAO 407"},
        {"Wilson Evans Batten Catalogue", "WEB 2506"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.29458699),
        dec: Angle.Degrees(+81.64333919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183359"},
        {"Hipparcos Number", "HIP 94603"},
        {"Geneva Identification System", "GEN# +1.00183359"},
        {"Smithsonian Astrophysical Observation", "SAO 3198"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.77779185),
        dec: Angle.Degrees(+81.64932900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87425",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87425"},
        {"Smithsonian Astrophysical Observation", "SAO 2966"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.98919226),
        dec: Angle.Degrees(+81.66188808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 102.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1165"},
        {"Hipparcos Number", "HIP 1347"},
        {"Smithsonian Astrophysical Observation", "SAO 44"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.855,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.21891882),
        dec: Angle.Degrees(+81.66369004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221021"},
        {"Hipparcos Number", "HIP 115695"},
        {"Fundamental Katalog 5th Edition", "FK5 6069"},
        {"Smithsonian Astrophysical Observation", "SAO 3906"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.59212154),
        dec: Angle.Degrees(+81.67821142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60062"},
        {"Hipparcos Number", "HIP 37961"},
        {"Smithsonian Astrophysical Observation", "SAO 1222"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.72025083),
        dec: Angle.Degrees(+81.68247319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104698"},
        {"Hipparcos Number", "HIP 58781"},
        {"Geneva Identification System", "GEN# +1.00104698"},
        {"Smithsonian Astrophysical Observation", "SAO 1973"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.83807167),
        dec: Angle.Degrees(+81.68829750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34712"},
        {"Hipparcos Number", "HIP 26160"},
        {"Smithsonian Astrophysical Observation", "SAO 867"},
        {"Wilson Evans Batten Catalogue", "WEB 5094"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.65460928),
        dec: Angle.Degrees(+81.69853129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -167.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33462",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33462"},
        {"Smithsonian Astrophysical Observation", "SAO 1078"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.34691878),
        dec: Angle.Degrees(+81.70110509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62379",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62379"},
        {"Smithsonian Astrophysical Observation", "SAO 2091"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.76490006),
        dec: Angle.Degrees(+81.70351646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78656",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78656"},
        {"Smithsonian Astrophysical Observation", "SAO 2659"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.86087200),
        dec: Angle.Degrees(+81.70566184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 76.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93178",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93178"},
        {"Smithsonian Astrophysical Observation", "SAO 3155"},
    },
    visualMagnitude: 9.85,
    bvColour: 1.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.69524272),
        dec: Angle.Degrees(+81.70625999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105943"},
        {"Hipparcos Number", "HIP 59384"},
        {"Geneva Identification System", "GEN# +1.00105943"},
        {"Smithsonian Astrophysical Observation", "SAO 1991"},
        {"Wilson Evans Batten Catalogue", "WEB 10561"},
    },
    visualMagnitude: 6.00,
    bvColour: 1.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.75037388),
        dec: Angle.Degrees(+81.70983674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64764"},
        {"Hipparcos Number", "HIP 39905"},
        {"Fundamental Katalog 5th Edition", "FK5 4733"},
        {"Smithsonian Astrophysical Observation", "SAO 1285"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.25604121),
        dec: Angle.Degrees(+81.71004055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45880",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45880"},
    },
    visualMagnitude: 11.93,
    bvColour: -0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.33008829),
        dec: Angle.Degrees(+81.72446693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96511"},
        {"Hipparcos Number", "HIP 54632"},
        {"Fundamental Katalog 5th Edition", "FK5 4988"},
        {"Geneva Identification System", "GEN# +1.00096511"},
        {"Smithsonian Astrophysical Observation", "SAO 1829"},
        {"Wilson Evans Batten Catalogue", "WEB 9856"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.73126615),
        dec: Angle.Degrees(+81.73210103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -179.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205521"},
        {"Hipparcos Number", "HIP 105906"},
        {"Geneva Identification System", "GEN# +1.00205521"},
        {"Smithsonian Astrophysical Observation", "SAO 3577"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.74117770),
        dec: Angle.Degrees(+81.74211468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 213.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 119.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42060"},
        {"Hipparcos Number", "HIP 30453"},
        {"Smithsonian Astrophysical Observation", "SAO 993"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.02143703),
        dec: Angle.Degrees(+81.74847811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65753"},
        {"Hipparcos Number", "HIP 40288"},
        {"Smithsonian Astrophysical Observation", "SAO 1299"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.40632890),
        dec: Angle.Degrees(+81.75780108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204169"},
        {"Hipparcos Number", "HIP 105074"},
        {"Smithsonian Astrophysical Observation", "SAO 3544"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.28793014),
        dec: Angle.Degrees(+81.76150508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2675",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2675"},
        {"Smithsonian Astrophysical Observation", "SAO 87"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.47171675),
        dec: Angle.Degrees(+81.77095992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10778",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10778"},
        {"Smithsonian Astrophysical Observation", "SAO 366"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.67804393),
        dec: Angle.Degrees(+81.78702923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -252.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37644"},
        {"Hipparcos Number", "HIP 28007"},
        {"Smithsonian Astrophysical Observation", "SAO 912"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.86848152),
        dec: Angle.Degrees(+81.78833533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184311"},
        {"Hipparcos Number", "HIP 94978"},
        {"Smithsonian Astrophysical Observation", "SAO 3219"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.90844305),
        dec: Angle.Degrees(+81.79608020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200802"},
        {"Hipparcos Number", "HIP 103243"},
        {"Geneva Identification System", "GEN# +1.00200802"},
        {"Smithsonian Astrophysical Observation", "SAO 3484"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.74827076),
        dec: Angle.Degrees(+81.80479480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219194"},
        {"Hipparcos Number", "HIP 114463"},
        {"Smithsonian Astrophysical Observation", "SAO 3856"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.72555601),
        dec: Angle.Degrees(+81.81685192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74855"},
        {"Hipparcos Number", "HIP 44044"},
        {"Smithsonian Astrophysical Observation", "SAO 1417"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.54853874),
        dec: Angle.Degrees(+81.82950672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223766"},
        {"Hipparcos Number", "HIP 117670"},
        {"Smithsonian Astrophysical Observation", "SAO 3987"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.95678098),
        dec: Angle.Degrees(+81.83684414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108554",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108554"},
        {"Smithsonian Astrophysical Observation", "SAO 3678"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.84514022),
        dec: Angle.Degrees(+81.84634312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218273"},
        {"Hipparcos Number", "HIP 113822"},
        {"Smithsonian Astrophysical Observation", "SAO 3835"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.73776052),
        dec: Angle.Degrees(+81.85594494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24126"},
        {"Hipparcos Number", "HIP 18954"},
        {"Cincinnati Publication", "Ci 18 539"},
        {"Smithsonian Astrophysical Observation", "SAO 636"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.93385744),
        dec: Angle.Degrees(+81.87516529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4843",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 830 A"},
        {"Henry Draper", "HD 5679"},
        {"Hipparcos Number", "HIP 4843"},
        {"Geneva Identification System", "GEN# +1.00005679A"},
        {"Smithsonian Astrophysical Observation", "SAO 168"},
        {"Wilson Evans Batten Catalogue", "WEB 932"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.57643552),
        dec: Angle.Degrees(+81.87558833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139213"},
        {"Hipparcos Number", "HIP 75407"},
        {"Geneva Identification System", "GEN# +1.00139213"},
        {"Smithsonian Astrophysical Observation", "SAO 2545"},
        {"Wilson Evans Batten Catalogue", "WEB 12863"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.11814530),
        dec: Angle.Degrees(+81.89495612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 197.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156073"},
        {"Hipparcos Number", "HIP 83199"},
        {"Smithsonian Astrophysical Observation", "SAO 2804"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.05462033),
        dec: Angle.Degrees(+81.89512920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215833"},
        {"Hipparcos Number", "HIP 112165"},
        {"Smithsonian Astrophysical Observation", "SAO 3781"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.76157746),
        dec: Angle.Degrees(+81.89617065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72817",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72817"},
        {"Smithsonian Astrophysical Observation", "SAO 2463"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.25765031),
        dec: Angle.Degrees(+81.89619508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43546",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43546"},
        {"Smithsonian Astrophysical Observation", "SAO 1396"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.896,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.03410079),
        dec: Angle.Degrees(+81.93344876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183381"},
        {"Hipparcos Number", "HIP 94563"},
        {"Smithsonian Astrophysical Observation", "SAO 3196"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.68415961),
        dec: Angle.Degrees(+81.93411523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217159"},
        {"Hipparcos Number", "HIP 113108"},
        {"Smithsonian Astrophysical Observation", "SAO 3812"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.58274530),
        dec: Angle.Degrees(+81.93500982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213047"},
        {"Hipparcos Number", "HIP 110472"},
        {"Geneva Identification System", "GEN# +1.00213047"},
        {"Smithsonian Astrophysical Observation", "SAO 3737"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.65684358),
        dec: Angle.Degrees(+81.93896324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 74.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11053"},
        {"Hipparcos Number", "HIP 8979"},
        {"Smithsonian Astrophysical Observation", "SAO 310"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.92661563),
        dec: Angle.Degrees(+81.95898770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6006"},
        {"Hipparcos Number", "HIP 5108"},
        {"Geneva Identification System", "GEN# +1.00006006"},
        {"Smithsonian Astrophysical Observation", "SAO 179"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.36788457),
        dec: Angle.Degrees(+81.96149349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4499"},
        {"Hipparcos Number", "HIP 3905"},
        {"Smithsonian Astrophysical Observation", "SAO 130"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.51938681),
        dec: Angle.Degrees(+81.96723562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26012"},
        {"Hipparcos Number", "HIP 20288"},
        {"Smithsonian Astrophysical Observation", "SAO 673"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.22589485),
        dec: Angle.Degrees(+81.97753988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74909",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74909"},
        {"Smithsonian Astrophysical Observation", "SAO 2531"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.63312640),
        dec: Angle.Degrees(+81.98718220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118478"},
        {"Hipparcos Number", "HIP 65919"},
        {"Renson", "Renson 34223"},
        {"Smithsonian Astrophysical Observation", "SAO 2232"},
    },
    visualMagnitude: 9.15,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.71202079),
        dec: Angle.Degrees(+81.99391981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108832"},
        {"Hipparcos Number", "HIP 60856"},
        {"Geneva Identification System", "GEN# +1.00108832"},
        {"Smithsonian Astrophysical Observation", "SAO 2045"},
        {"Wilson Evans Batten Catalogue", "WEB 10832"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.09451376),
        dec: Angle.Degrees(+81.99656332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4055",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4055"},
    },
    visualMagnitude: 10.49,
    bvColour: 0.817,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.98167608),
        dec: Angle.Degrees(+82.00674738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 211.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197910"},
        {"Hipparcos Number", "HIP 101550"},
        {"Smithsonian Astrophysical Observation", "SAO 3429"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.69165180),
        dec: Angle.Degrees(+82.01119874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204337"},
        {"Hipparcos Number", "HIP 105144"},
        {"Smithsonian Astrophysical Observation", "SAO 3551"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.49294149),
        dec: Angle.Degrees(+82.01889376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90713"},
        {"Hipparcos Number", "HIP 51788"},
        {"Smithsonian Astrophysical Observation", "SAO 1729"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.72640803),
        dec: Angle.Degrees(+82.02526283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82080",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10242 A"},
        {"Henry Draper", "HD 153751"},
        {"Hipparcos Number", "HIP 82080"},
        {"Fundamental Katalog 5th Edition", "FK5 912"},
        {"Geneva Identification System", "GEN# +1.00153751"},
        {"Smithsonian Astrophysical Observation", "SAO 2770"},
        {"Wilson Evans Batten Catalogue", "WEB 13862"},
    },
    visualMagnitude: 4.21,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.49233961),
        dec: Angle.Degrees(+82.03725071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147901"},
        {"Hipparcos Number", "HIP 79217"},
        {"Smithsonian Astrophysical Observation", "SAO 2677"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.51012174),
        dec: Angle.Degrees(+82.07895407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101149"},
        {"Hipparcos Number", "HIP 56916"},
        {"Geneva Identification System", "GEN# +1.00101149"},
        {"Smithsonian Astrophysical Observation", "SAO 1911"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.02064156),
        dec: Angle.Degrees(+82.08182739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148465"},
        {"Hipparcos Number", "HIP 79521"},
        {"Smithsonian Astrophysical Observation", "SAO 2685"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.41080695),
        dec: Angle.Degrees(+82.08794903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15419",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15419"},
        {"Smithsonian Astrophysical Observation", "SAO 519"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.68461474),
        dec: Angle.Degrees(+82.09651631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115926"},
        {"Hipparcos Number", "HIP 64641"},
        {"Smithsonian Astrophysical Observation", "SAO 2172"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.73555023),
        dec: Angle.Degrees(+82.09783470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5817"},
        {"Hipparcos Number", "HIP 4966"},
        {"Geneva Identification System", "GEN# +1.00005817"},
        {"Smithsonian Astrophysical Observation", "SAO 173"},
        {"Wilson Evans Batten Catalogue", "WEB 998"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.91466099),
        dec: Angle.Degrees(+82.10089846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -174.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29277",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29277"},
        {"Geneva Identification System", "GEN# +6.10010226"},
        {"Geneva Identification System 2", "GEN# +9.80222011"},
        {"Wilson Evans Batten Catalogue", "WEB 5746"},
    },
    visualMagnitude: 10.48,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.58180602),
        dec: Angle.Degrees(+82.11000311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1336.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45618"},
        {"Hipparcos Number", "HIP 32296"},
        {"Fundamental Katalog 5th Edition", "FK5 3950"},
        {"Geneva Identification System", "GEN# +1.00045618"},
        {"Renson", "Renson 12125"},
        {"Smithsonian Astrophysical Observation", "SAO 1043"},
        {"Wilson Evans Batten Catalogue", "WEB 6510"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.12624588),
        dec: Angle.Degrees(+82.11546495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19855"},
        {"Hipparcos Number", "HIP 15792"},
        {"Smithsonian Astrophysical Observation", "SAO 536"},
        {"Wilson Evans Batten Catalogue", "WEB 3018"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.87839549),
        dec: Angle.Degrees(+82.14990760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213809"},
        {"Hipparcos Number", "HIP 110906"},
        {"Smithsonian Astrophysical Observation", "SAO 3751"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.04572271),
        dec: Angle.Degrees(+82.15528979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54867",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54867"},
        {"Smithsonian Astrophysical Observation", "SAO 1839"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.51638769),
        dec: Angle.Degrees(+82.20362830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193532"},
        {"Hipparcos Number", "HIP 99107"},
        {"Geneva Identification System", "GEN# +1.00193532"},
        {"Smithsonian Astrophysical Observation", "SAO 3347"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.81658353),
        dec: Angle.Degrees(+82.21646502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72520"},
        {"Hipparcos Number", "HIP 43068"},
        {"Fundamental Katalog 5th Edition", "FK5 3953"},
        {"Geneva Identification System", "GEN# +1.00072520"},
        {"Smithsonian Astrophysical Observation", "SAO 1378"},
    },
    visualMagnitude: 6.86,
    bvColour: -0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.59487584),
        dec: Angle.Degrees(+82.23933232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24680",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24680"},
        {"Smithsonian Astrophysical Observation", "SAO 824"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.41900671),
        dec: Angle.Degrees(+82.24960794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140363"},
        {"Hipparcos Number", "HIP 75870"},
        {"Geneva Identification System", "GEN# +1.00140363"},
        {"Smithsonian Astrophysical Observation", "SAO 2564"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.46115621),
        dec: Angle.Degrees(+82.26363865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44982"},
        {"Hipparcos Number", "HIP 32015"},
        {"Geneva Identification System", "GEN# +1.00044982"},
        {"Smithsonian Astrophysical Observation", "SAO 1038"},
        {"Wilson Evans Batten Catalogue", "WEB 6456"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.32872449),
        dec: Angle.Degrees(+82.26771059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -152.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104088",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104088"},
        {"Smithsonian Astrophysical Observation", "SAO 3510"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.32226320),
        dec: Angle.Degrees(+82.28915945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36103",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36103"},
        {"Smithsonian Astrophysical Observation", "SAO 1162"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.56019826),
        dec: Angle.Degrees(+82.29661015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83332",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83332"},
        {"Smithsonian Astrophysical Observation", "SAO 2808"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.46307746),
        dec: Angle.Degrees(+82.30730931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171481"},
        {"Hipparcos Number", "HIP 89735"},
        {"Smithsonian Astrophysical Observation", "SAO 3029"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.69535070),
        dec: Angle.Degrees(+82.30832112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101828"},
        {"Hipparcos Number", "HIP 57261"},
        {"Geneva Identification System", "GEN# +1.00101828"},
        {"Smithsonian Astrophysical Observation", "SAO 1926"},
        {"Wilson Evans Batten Catalogue", "WEB 10298"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.14476935),
        dec: Angle.Degrees(+82.32135759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158770"},
        {"Hipparcos Number", "HIP 84347"},
        {"Smithsonian Astrophysical Observation", "SAO 2848"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.67536051),
        dec: Angle.Degrees(+82.33076852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21337",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21337"},
        {"Smithsonian Astrophysical Observation", "SAO 708"},
    },
    visualMagnitude: 9.52,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.68282947),
        dec: Angle.Degrees(+82.33841172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73680",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73680"},
        {"Smithsonian Astrophysical Observation", "SAO 2494"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.91149119),
        dec: Angle.Degrees(+82.34885001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143835"},
        {"Hipparcos Number", "HIP 77419"},
        {"Smithsonian Astrophysical Observation", "SAO 2618"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.08157130),
        dec: Angle.Degrees(+82.35292068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89734",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89734"},
    },
    visualMagnitude: 10.98,
    bvColour: 0.779,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.68921849),
        dec: Angle.Degrees(+82.35991677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 225.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81664",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10220 B"},
        {"Hipparcos Number", "HIP 81664"},
    },
    visualMagnitude: 10.55,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.23885875),
        dec: Angle.Degrees(+82.36139062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81667",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81667"},
        {"Smithsonian Astrophysical Observation", "SAO 2757"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.23937308),
        dec: Angle.Degrees(+82.36473553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82371"},
        {"Hipparcos Number", "HIP 47556"},
        {"Smithsonian Astrophysical Observation", "SAO 1560"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.43747090),
        dec: Angle.Degrees(+82.36508787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195850"},
        {"Hipparcos Number", "HIP 100321"},
        {"Geneva Identification System", "GEN# +1.00195850"},
        {"Smithsonian Astrophysical Observation", "SAO 3388"},
        {"Wilson Evans Batten Catalogue", "WEB 18094"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.18194342),
        dec: Angle.Degrees(+82.36815407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49625",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49625"},
        {"Smithsonian Astrophysical Observation", "SAO 1638"},
    },
    visualMagnitude: 10.47,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.91970810),
        dec: Angle.Degrees(+82.36934080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178738"},
        {"Hipparcos Number", "HIP 92738"},
        {"Fundamental Katalog 5th Edition", "FK5 3961"},
        {"Geneva Identification System", "GEN# +1.00178738"},
        {"Smithsonian Astrophysical Observation", "SAO 3146"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.47413784),
        dec: Angle.Degrees(+82.36997390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143416"},
        {"Hipparcos Number", "HIP 77211"},
        {"Smithsonian Astrophysical Observation", "SAO 2612"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.47126380),
        dec: Angle.Degrees(+82.37009346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219396"},
        {"Hipparcos Number", "HIP 114546"},
        {"Geneva Identification System", "GEN# +1.00219396"},
        {"Smithsonian Astrophysical Observation", "SAO 3865"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.03856506),
        dec: Angle.Degrees(+82.39440635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 84.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17099"},
        {"Hipparcos Number", "HIP 13637"},
        {"Smithsonian Astrophysical Observation", "SAO 451"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.90291379),
        dec: Angle.Degrees(+82.39992202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87386"},
        {"Hipparcos Number", "HIP 50034"},
        {"Smithsonian Astrophysical Observation", "SAO 1649"},
        {"Wilson Evans Batten Catalogue", "WEB 9198"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.23158399),
        dec: Angle.Degrees(+82.40097335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55966"},
        {"Hipparcos Number", "HIP 36547"},
        {"Fundamental Katalog 5th Edition", "FK5 3951"},
        {"Geneva Identification System", "GEN# +1.00055966"},
        {"Smithsonian Astrophysical Observation", "SAO 1179"},
        {"Wilson Evans Batten Catalogue", "WEB 7270"},
    },
    visualMagnitude: 4.92,
    bvColour: 1.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.76866761),
        dec: Angle.Degrees(+82.41156871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52996",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52996"},
        {"Smithsonian Astrophysical Observation", "SAO 1767"},
    },
    visualMagnitude: 10.67,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.61727511),
        dec: Angle.Degrees(+82.41671177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45635"},
        {"Hipparcos Number", "HIP 32363"},
        {"Smithsonian Astrophysical Observation", "SAO 1047"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.32296828),
        dec: Angle.Degrees(+82.41704207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7633",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7633"},
        {"Smithsonian Astrophysical Observation", "SAO 254"},
    },
    visualMagnitude: 10.77,
    bvColour: 0.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.58485868),
        dec: Angle.Degrees(+82.42526944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111937"},
        {"Hipparcos Number", "HIP 62574"},
        {"Fundamental Katalog 5th Edition", "FK5 5135"},
        {"Smithsonian Astrophysical Observation", "SAO 2100"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.31569898),
        dec: Angle.Degrees(+82.42990726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67934"},
        {"Hipparcos Number", "HIP 41208"},
        {"Fundamental Katalog 5th Edition", "FK5 3952"},
        {"Geneva Identification System", "GEN# +1.00067934"},
        {"Smithsonian Astrophysical Observation", "SAO 1319"},
        {"Wilson Evans Batten Catalogue", "WEB 7972"},
    },
    visualMagnitude: 6.28,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.13794451),
        dec: Angle.Degrees(+82.43082230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52029"},
        {"Hipparcos Number", "HIP 35159"},
        {"Smithsonian Astrophysical Observation", "SAO 1144"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.00194506),
        dec: Angle.Degrees(+82.44046532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190224"},
        {"Hipparcos Number", "HIP 97542"},
        {"Fundamental Katalog 5th Edition", "FK5 5749"},
        {"Smithsonian Astrophysical Observation", "SAO 3299"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.37917601),
        dec: Angle.Degrees(+82.45485628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39329"},
        {"Hipparcos Number", "HIP 29137"},
        {"Fundamental Katalog 5th Edition", "FK5 4560"},
        {"Smithsonian Astrophysical Observation", "SAO 944"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.19578591),
        dec: Angle.Degrees(+82.45845409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19918",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19918"},
        {"Smithsonian Astrophysical Observation", "SAO 660"},
    },
    visualMagnitude: 9.77,
    bvColour: 1.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.09328450),
        dec: Angle.Degrees(+82.46291038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24393",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3677 AB"},
        {"Hipparcos Number", "HIP 24393"},
        {"Smithsonian Astrophysical Observation", "SAO 814"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.49520231),
        dec: Angle.Degrees(+82.47937636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17687",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17687"},
        {"Smithsonian Astrophysical Observation", "SAO 588"},
    },
    visualMagnitude: 10.12,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.83051804),
        dec: Angle.Degrees(+82.48362622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21636",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21636"},
        {"Smithsonian Astrophysical Observation", "SAO 723"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.71262133),
        dec: Angle.Degrees(+82.48636760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167080"},
        {"Hipparcos Number", "HIP 87859"},
        {"Smithsonian Astrophysical Observation", "SAO 2979"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.21762841),
        dec: Angle.Degrees(+82.48641258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3440"},
        {"Hipparcos Number", "HIP 3132"},
        {"Fundamental Katalog 5th Edition", "FK5 3941"},
        {"Geneva Identification System", "GEN# +1.00003440"},
        {"Smithsonian Astrophysical Observation", "SAO 106"},
        {"Wilson Evans Batten Catalogue", "WEB 557"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.94897859),
        dec: Angle.Degrees(+82.49357470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133002"},
        {"Hipparcos Number", "HIP 72573"},
        {"Fundamental Katalog 5th Edition", "FK5 1644"},
        {"Geneva Identification System", "GEN# +1.00133002"},
        {"Smithsonian Astrophysical Observation", "SAO 2459"},
        {"Wilson Evans Batten Catalogue", "WEB 12477"},
    },
    visualMagnitude: 5.63,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.58178099),
        dec: Angle.Degrees(+82.51248701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 177.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -223.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31082"},
        {"Hipparcos Number", "HIP 23966"},
        {"Smithsonian Astrophysical Observation", "SAO 803"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.27320580),
        dec: Angle.Degrees(+82.51418041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105112",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14921 AB"},
        {"Henry Draper", "HD 204372"},
        {"Hipparcos Number", "HIP 105112"},
        {"Smithsonian Astrophysical Observation", "SAO 3550"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.39053262),
        dec: Angle.Degrees(+82.51734239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 78.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62971",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8375 A"},
        {"Henry Draper", "HD 112651"},
        {"Hipparcos Number", "HIP 62971"},
        {"Smithsonian Astrophysical Observation", "SAO 2112"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.55493453),
        dec: Angle.Degrees(+82.51772838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67215",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67215"},
        {"Smithsonian Astrophysical Observation", "SAO 2278"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.61187399),
        dec: Angle.Degrees(+82.52957314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199095"},
        {"Hipparcos Number", "HIP 102208"},
        {"Fundamental Katalog 5th Edition", "FK5 915"},
        {"Geneva Identification System", "GEN# +1.00199095"},
        {"Smithsonian Astrophysical Observation", "SAO 3458"},
        {"Wilson Evans Batten Catalogue", "WEB 18494"},
    },
    visualMagnitude: 5.75,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.64624921),
        dec: Angle.Degrees(+82.53110584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11770"},
        {"Hipparcos Number", "HIP 9615"},
        {"Smithsonian Astrophysical Observation", "SAO 331"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.744,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.89324270),
        dec: Angle.Degrees(+82.55184604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90089"},
        {"Hipparcos Number", "HIP 51502"},
        {"Fundamental Katalog 5th Edition", "FK5 911"},
        {"Geneva Identification System", "GEN# +1.00090089"},
        {"Smithsonian Astrophysical Observation", "SAO 1714"},
        {"Wilson Evans Batten Catalogue", "WEB 9399"},
    },
    visualMagnitude: 5.25,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.77091914),
        dec: Angle.Degrees(+82.55853791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114298",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16564 A"},
        {"Henry Draper", "HD 219014"},
        {"Hipparcos Number", "HIP 114298"},
        {"Smithsonian Astrophysical Observation", "SAO 3851"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.22756485),
        dec: Angle.Degrees(+82.58367421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160382"},
        {"Hipparcos Number", "HIP 85012"},
        {"Smithsonian Astrophysical Observation", "SAO 2875"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.62726900),
        dec: Angle.Degrees(+82.60041867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12806",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12806"},
    },
    visualMagnitude: 11.65,
    bvColour: 0.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.14645981),
        dec: Angle.Degrees(+82.60722597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71533"},
        {"Hipparcos Number", "HIP 42671"},
        {"Smithsonian Astrophysical Observation", "SAO 1362"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.45837462),
        dec: Angle.Degrees(+82.61100318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78437"},
        {"Hipparcos Number", "HIP 45771"},
        {"Smithsonian Astrophysical Observation", "SAO 1482"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.99430295),
        dec: Angle.Degrees(+82.61277872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148589"},
        {"Hipparcos Number", "HIP 79489"},
        {"Smithsonian Astrophysical Observation", "SAO 2686"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.31644229),
        dec: Angle.Degrees(+82.63180794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107902"},
        {"Hipparcos Number", "HIP 60344"},
        {"Smithsonian Astrophysical Observation", "SAO 2026"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.59057016),
        dec: Angle.Degrees(+82.65723431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210979"},
        {"Hipparcos Number", "HIP 109127"},
        {"Smithsonian Astrophysical Observation", "SAO 3694"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.55842739),
        dec: Angle.Degrees(+82.66073893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102822"},
        {"Hipparcos Number", "HIP 57811"},
        {"Smithsonian Astrophysical Observation", "SAO 1944"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.80734878),
        dec: Angle.Degrees(+82.66587818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51462",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51462"},
        {"Smithsonian Astrophysical Observation", "SAO 1712"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.66968985),
        dec: Angle.Degrees(+82.66851712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180499"},
        {"Hipparcos Number", "HIP 93312"},
        {"Geneva Identification System", "GEN# +1.00180499"},
        {"Smithsonian Astrophysical Observation", "SAO 3160"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.09506383),
        dec: Angle.Degrees(+82.67192358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17504",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17504"},
        {"Smithsonian Astrophysical Observation", "SAO 585"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.22238016),
        dec: Angle.Degrees(+82.67322265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79868"},
        {"Hipparcos Number", "HIP 46432"},
        {"Smithsonian Astrophysical Observation", "SAO 1514"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.03741475),
        dec: Angle.Degrees(+82.68841476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21499",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21499"},
        {"Smithsonian Astrophysical Observation", "SAO 715"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.25984993),
        dec: Angle.Degrees(+82.69024389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172434"},
        {"Hipparcos Number", "HIP 90082"},
        {"Smithsonian Astrophysical Observation", "SAO 3046"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.75744580),
        dec: Angle.Degrees(+82.70598675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74924"},
        {"Hipparcos Number", "HIP 44187"},
        {"Smithsonian Astrophysical Observation", "SAO 1422"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.01861473),
        dec: Angle.Degrees(+82.71945637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92162",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92162"},
        {"Smithsonian Astrophysical Observation", "SAO 3127"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.75744953),
        dec: Angle.Degrees(+82.72436437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 184.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 291.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159386"},
        {"Hipparcos Number", "HIP 84558"},
        {"Smithsonian Astrophysical Observation", "SAO 2857"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.28088075),
        dec: Angle.Degrees(+82.72784912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23276"},
        {"Hipparcos Number", "HIP 18557"},
        {"Smithsonian Astrophysical Observation", "SAO 613"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.58151750),
        dec: Angle.Degrees(+82.73365350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70155",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70155"},
        {"Smithsonian Astrophysical Observation", "SAO 2372"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.32061462),
        dec: Angle.Degrees(+82.74128201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95895"},
        {"Hipparcos Number", "HIP 54437"},
        {"Smithsonian Astrophysical Observation", "SAO 1821"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.07789370),
        dec: Angle.Degrees(+82.74312035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75370"},
        {"Hipparcos Number", "HIP 44402"},
        {"Geneva Identification System", "GEN# +1.00075370"},
        {"Smithsonian Astrophysical Observation", "SAO 1428"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.67844160),
        dec: Angle.Degrees(+82.74481836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28646",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4492 AB"},
        {"Henry Draper", "HD 38387"},
        {"Hipparcos Number", "HIP 28646"},
        {"Smithsonian Astrophysical Observation", "SAO 929"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.73658797),
        dec: Angle.Degrees(+82.75137337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120565"},
        {"Hipparcos Number", "HIP 66878"},
        {"Fundamental Katalog 5th Edition", "FK5 1643"},
        {"Geneva Identification System", "GEN# +1.00120565"},
        {"Smithsonian Astrophysical Observation", "SAO 2266"},
        {"Wilson Evans Batten Catalogue", "WEB 11791"},
    },
    visualMagnitude: 5.92,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.59559926),
        dec: Angle.Degrees(+82.75251097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73955",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73955"},
        {"Geneva Identification System", "GEN# +0.08300442"},
        {"Smithsonian Astrophysical Observation", "SAO 2502"},
    },
    visualMagnitude: 9.99,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.70843640),
        dec: Angle.Degrees(+82.75640801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95523",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95523"},
        {"Smithsonian Astrophysical Observation", "SAO 3234"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.45597239),
        dec: Angle.Degrees(+82.77335831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97677",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97677"},
        {"Smithsonian Astrophysical Observation", "SAO 3303"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.76366606),
        dec: Angle.Degrees(+82.79103598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89108"},
        {"Hipparcos Number", "HIP 50971"},
        {"Smithsonian Astrophysical Observation", "SAO 1681"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.17394894),
        dec: Angle.Degrees(+82.80167493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223079"},
        {"Hipparcos Number", "HIP 117166"},
        {"Geneva Identification System", "GEN# +1.00223079"},
        {"Smithsonian Astrophysical Observation", "SAO 3964"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.30857960),
        dec: Angle.Degrees(+82.80671273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58340",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58340"},
        {"Smithsonian Astrophysical Observation", "SAO 1955"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.45824465),
        dec: Angle.Degrees(+82.82092245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135756"},
        {"Hipparcos Number", "HIP 73671"},
        {"Smithsonian Astrophysical Observation", "SAO 2497"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.89349794),
        dec: Angle.Degrees(+82.82458941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9717",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9717"},
        {"Smithsonian Astrophysical Observation", "SAO 334"},
    },
    visualMagnitude: 9.80,
    bvColour: 1.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.24943650),
        dec: Angle.Degrees(+82.84337513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195984"},
        {"Hipparcos Number", "HIP 100301"},
        {"Geneva Identification System", "GEN# +1.00195984"},
        {"Smithsonian Astrophysical Observation", "SAO 3389"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.14012397),
        dec: Angle.Degrees(+82.84751709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7346",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7346"},
        {"Smithsonian Astrophysical Observation", "SAO 246"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.66610182),
        dec: Angle.Degrees(+82.84854834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 295.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 131.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116788",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116788"},
        {"Smithsonian Astrophysical Observation", "SAO 3945"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.04429925),
        dec: Angle.Degrees(+82.85049685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 227.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 106.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108456",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15571 A"},
        {"Henry Draper", "HD 209942"},
        {"Hipparcos Number", "HIP 108456"},
        {"Geneva Identification System", "GEN# +1.00209942"},
        {"Smithsonian Astrophysical Observation", "SAO 3673"},
        {"Wilson Evans Batten Catalogue", "WEB 19529"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.55638101),
        dec: Angle.Degrees(+82.86966645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -129.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108461",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15571 B"},
        {"Henry Draper", "HD 209943"},
        {"Hipparcos Number", "HIP 108461"},
        {"Geneva Identification System", "GEN# +1.00209943"},
        {"Smithsonian Astrophysical Observation", "SAO 3675"},
        {"Wilson Evans Batten Catalogue", "WEB 19531"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.58489565),
        dec: Angle.Degrees(+82.87115816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -132.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86874",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86874"},
        {"Smithsonian Astrophysical Observation", "SAO 2946"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.23430122),
        dec: Angle.Degrees(+82.87564945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71736",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71736"},
        {"Smithsonian Astrophysical Observation", "SAO 2444"},
    },
    visualMagnitude: 9.81,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.11803573),
        dec: Angle.Degrees(+82.90335822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18591"},
        {"Hipparcos Number", "HIP 14859"},
        {"Geneva Identification System", "GEN# +1.00018591"},
        {"Smithsonian Astrophysical Observation", "SAO 498"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.97114633),
        dec: Angle.Degrees(+82.90386560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19739",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19739"},
        {"Wilson Evans Batten Catalogue", "WEB 3766"},
    },
    visualMagnitude: 10.80,
    bvColour: 1.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.48112878),
        dec: Angle.Degrees(+82.91921119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -251.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81437"},
        {"Hipparcos Number", "HIP 47185"},
        {"Geneva Identification System", "GEN# +1.00081437"},
        {"Smithsonian Astrophysical Observation", "SAO 1547"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.24037581),
        dec: Angle.Degrees(+82.92540153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170151"},
        {"Hipparcos Number", "HIP 89026"},
        {"Smithsonian Astrophysical Observation", "SAO 3007"},
    },
    visualMagnitude: 7.43,
    bvColour: -0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.54234527),
        dec: Angle.Degrees(+82.93976369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143173"},
        {"Hipparcos Number", "HIP 77013"},
        {"Fundamental Katalog 5th Edition", "FK5 1645"},
        {"Geneva Identification System", "GEN# +1.00143173"},
        {"Smithsonian Astrophysical Observation", "SAO 2606"},
        {"Wilson Evans Batten Catalogue", "WEB 13062"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.86275599),
        dec: Angle.Degrees(+82.94726323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48354",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48354"},
        {"Smithsonian Astrophysical Observation", "SAO 1587"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.84821746),
        dec: Angle.Degrees(+82.95480213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -139.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -194.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100920",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100920"},
        {"Smithsonian Astrophysical Observation", "SAO 3411"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.92052621),
        dec: Angle.Degrees(+82.95731934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110285",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110285"},
        {"Smithsonian Astrophysical Observation", "SAO 3733"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.712,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.08604444),
        dec: Angle.Degrees(+82.97068287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 182.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225019"},
        {"Hipparcos Number", "HIP 217"},
        {"Smithsonian Astrophysical Observation", "SAO 1"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.67441616),
        dec: Angle.Degrees(+82.97320953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205083"},
        {"Hipparcos Number", "HIP 105499"},
        {"Geneva Identification System", "GEN# +1.00205083"},
        {"Smithsonian Astrophysical Observation", "SAO 3563"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.50508092),
        dec: Angle.Degrees(+82.97917199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223455"},
        {"Hipparcos Number", "HIP 117436"},
        {"Smithsonian Astrophysical Observation", "SAO 3975"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.18552826),
        dec: Angle.Degrees(+82.98256197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201597"},
        {"Hipparcos Number", "HIP 103508"},
        {"Fundamental Katalog 5th Edition", "FK5 5846"},
        {"Smithsonian Astrophysical Observation", "SAO 3498"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.56401666),
        dec: Angle.Degrees(+82.98719868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74466",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74466"},
    },
    visualMagnitude: 11.62,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.25138789),
        dec: Angle.Degrees(+83.03443300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -354.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 218.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217585"},
        {"Hipparcos Number", "HIP 113328"},
        {"Smithsonian Astrophysical Observation", "SAO 3822"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.26876465),
        dec: Angle.Degrees(+83.05267766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59664"},
        {"Hipparcos Number", "HIP 38061"},
        {"Geneva Identification System", "GEN# +1.00059664"},
        {"Smithsonian Astrophysical Observation", "SAO 1221"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.01034202),
        dec: Angle.Degrees(+83.06898773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107325",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107325"},
        {"Smithsonian Astrophysical Observation", "SAO 3631"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.07900133),
        dec: Angle.Degrees(+83.07833874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54529",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8066 A"},
        {"Hipparcos Number", "HIP 54529"},
        {"Smithsonian Astrophysical Observation", "SAO 1824"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.929,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.36885333),
        dec: Angle.Degrees(+83.09602469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67585"},
        {"Hipparcos Number", "HIP 41195"},
        {"Geneva Identification System", "GEN# +1.00067585"},
        {"Smithsonian Astrophysical Observation", "SAO 1318"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.09275293),
        dec: Angle.Degrees(+83.09714750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5312"},
        {"Hipparcos Number", "HIP 4617"},
        {"Smithsonian Astrophysical Observation", "SAO 157"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.81053373),
        dec: Angle.Degrees(+83.10292417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112519",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16294 A"},
        {"Henry Draper", "HD 216446"},
        {"Hipparcos Number", "HIP 112519"},
        {"Geneva Identification System", "GEN# +1.00216446"},
        {"Smithsonian Astrophysical Observation", "SAO 3794"},
        {"Wilson Evans Batten Catalogue", "WEB 20065"},
    },
    visualMagnitude: 4.77,
    bvColour: 1.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.87061429),
        dec: Angle.Degrees(+83.15371558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76114"},
        {"Hipparcos Number", "HIP 44805"},
        {"Smithsonian Astrophysical Observation", "SAO 1435"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.97224202),
        dec: Angle.Degrees(+83.17520639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172864"},
        {"Hipparcos Number", "HIP 90182"},
        {"Fundamental Katalog 5th Edition", "FK5 1646"},
        {"Geneva Identification System", "GEN# +1.00172864"},
        {"Smithsonian Astrophysical Observation", "SAO 3056"},
        {"Wilson Evans Batten Catalogue", "WEB 15420"},
    },
    visualMagnitude: 6.16,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.03825240),
        dec: Angle.Degrees(+83.17545653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196768"},
        {"Hipparcos Number", "HIP 100710"},
        {"Smithsonian Astrophysical Observation", "SAO 3404"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.26486464),
        dec: Angle.Degrees(+83.18279774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154098"},
        {"Hipparcos Number", "HIP 82027"},
        {"Smithsonian Astrophysical Observation", "SAO 2772"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.33817455),
        dec: Angle.Degrees(+83.18505320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224309"},
        {"Hipparcos Number", "HIP 118027"},
        {"Fundamental Katalog 5th Edition", "FK5 1650"},
        {"Geneva Identification System", "GEN# +1.00224309"},
        {"Smithsonian Astrophysical Observation", "SAO 3994"},
        {"Wilson Evans Batten Catalogue", "WEB 20754"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.11482470),
        dec: Angle.Degrees(+83.19110073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29830"},
        {"Hipparcos Number", "HIP 23206"},
        {"Smithsonian Astrophysical Observation", "SAO 775"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.90554619),
        dec: Angle.Degrees(+83.19608209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52935",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52935"},
        {"Smithsonian Astrophysical Observation", "SAO 1765"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.38556345),
        dec: Angle.Degrees(+83.20315188)
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
    primaryId: "HIP 116496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222169"},
        {"Hipparcos Number", "HIP 116496"},
        {"Smithsonian Astrophysical Observation", "SAO 3938"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.09935918),
        dec: Angle.Degrees(+83.20405830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94859"},
        {"Hipparcos Number", "HIP 53960"},
        {"Smithsonian Astrophysical Observation", "SAO 1803"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.59607561),
        dec: Angle.Degrees(+83.22203045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215971"},
        {"Hipparcos Number", "HIP 112172"},
        {"Smithsonian Astrophysical Observation", "SAO 3784"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.77026459),
        dec: Angle.Degrees(+83.27069010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80319",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80319"},
        {"Smithsonian Astrophysical Observation", "SAO 2715"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.97467002),
        dec: Angle.Degrees(+83.28275409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205418"},
        {"Hipparcos Number", "HIP 105644"},
        {"Smithsonian Astrophysical Observation", "SAO 3572"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.96831623),
        dec: Angle.Degrees(+83.28334256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3420",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3420"},
        {"Smithsonian Astrophysical Observation", "SAO 116"},
    },
    visualMagnitude: 10.62,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.89617347),
        dec: Angle.Degrees(+83.29815120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -263.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29548"},
        {"Hipparcos Number", "HIP 23010"},
        {"Smithsonian Astrophysical Observation", "SAO 766"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.24403628),
        dec: Angle.Degrees(+83.29944709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117655"},
        {"Hipparcos Number", "HIP 65429"},
        {"Geneva Identification System", "GEN# +1.00117655"},
        {"Smithsonian Astrophysical Observation", "SAO 2214"},
        {"Wilson Evans Batten Catalogue", "WEB 11548"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.16127341),
        dec: Angle.Degrees(+83.30829016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 92.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12175",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12175"},
        {"Smithsonian Astrophysical Observation", "SAO 403"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.21743589),
        dec: Angle.Degrees(+83.31622041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83339"},
        {"Hipparcos Number", "HIP 48154"},
        {"Fundamental Katalog 5th Edition", "FK5 4871"},
        {"Geneva Identification System", "GEN# +1.00083339"},
        {"Smithsonian Astrophysical Observation", "SAO 1579"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.23431054),
        dec: Angle.Degrees(+83.32959853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160034"},
        {"Hipparcos Number", "HIP 84702"},
        {"Geneva Identification System", "GEN# +1.00160034"},
        {"Smithsonian Astrophysical Observation", "SAO 2869"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.71702097),
        dec: Angle.Degrees(+83.33659096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 106.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26659"},
        {"Hipparcos Number", "HIP 20982"},
        {"Geneva Identification System", "GEN# +1.00026659"},
        {"Smithsonian Astrophysical Observation", "SAO 693"},
        {"Wilson Evans Batten Catalogue", "WEB 4034"},
    },
    visualMagnitude: 5.47,
    bvColour: 0.855,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.50249474),
        dec: Angle.Degrees(+83.34013144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 101.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187581"},
        {"Hipparcos Number", "HIP 96203"},
        {"Smithsonian Astrophysical Observation", "SAO 3255"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.43854745),
        dec: Angle.Degrees(+83.34230441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17953",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17953"},
        {"Smithsonian Astrophysical Observation", "SAO 591"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.57791043),
        dec: Angle.Degrees(+83.35696053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21537"},
        {"Hipparcos Number", "HIP 17392"},
        {"Smithsonian Astrophysical Observation", "SAO 583"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.87515770),
        dec: Angle.Degrees(+83.36024180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1479",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1479"},
        {"Smithsonian Astrophysical Observation", "SAO 48"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.60180663),
        dec: Angle.Degrees(+83.36750670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172668"},
        {"Hipparcos Number", "HIP 90054"},
        {"Smithsonian Astrophysical Observation", "SAO 3049"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.66546931),
        dec: Angle.Degrees(+83.36853436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107528"},
        {"Hipparcos Number", "HIP 60146"},
        {"Smithsonian Astrophysical Observation", "SAO 2019"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.01329276),
        dec: Angle.Degrees(+83.37398757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146637"},
        {"Hipparcos Number", "HIP 78379"},
        {"Geneva Identification System", "GEN# +1.00146637"},
        {"Smithsonian Astrophysical Observation", "SAO 2656"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.01050816),
        dec: Angle.Degrees(+83.40407785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25989",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3971 A"},
        {"Henry Draper", "HD 33971"},
        {"Hipparcos Number", "HIP 25989"},
        {"Smithsonian Astrophysical Observation", "SAO 856"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.19484684),
        dec: Angle.Degrees(+83.40432199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62572",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8682 A"},
        {"Henry Draper", "HD 112028"},
        {"Hipparcos Number", "HIP 62572"},
        {"Geneva Identification System", "GEN# +1.00112028"},
        {"Smithsonian Astrophysical Observation", "SAO 2102"},
        {"Wilson Evans Batten Catalogue", "WEB 11105"},
    },
    visualMagnitude: 5.38,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.30750199),
        dec: Angle.Degrees(+83.41285818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192478"},
        {"Hipparcos Number", "HIP 98350"},
        {"Smithsonian Astrophysical Observation", "SAO 3328"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.73274314),
        dec: Angle.Degrees(+83.41457218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62561",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8682 B"},
        {"Henry Draper", "HD 112014"},
        {"Hipparcos Number", "HIP 62561"},
        {"Geneva Identification System", "GEN# +1.00112014"},
        {"Renson", "Renson 32490"},
        {"Smithsonian Astrophysical Observation", "SAO 2101"},
        {"Wilson Evans Batten Catalogue", "WEB 11103"},
    },
    visualMagnitude: 5.92,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.27829680),
        dec: Angle.Degrees(+83.41779443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108199"},
        {"Hipparcos Number", "HIP 60476"},
        {"Geneva Identification System", "GEN# +1.00108199"},
        {"Smithsonian Astrophysical Observation", "SAO 2032"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.97264620),
        dec: Angle.Degrees(+83.42815623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58868",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58868"},
        {"Smithsonian Astrophysical Observation", "SAO 1974"},
    },
    visualMagnitude: 10.88,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.07920682),
        dec: Angle.Degrees(+83.43743719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -249.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 89.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114768",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114768"},
        {"Smithsonian Astrophysical Observation", "SAO 3878"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.72552138),
        dec: Angle.Degrees(+83.44646965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114786",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114786"},
        {"Smithsonian Astrophysical Observation", "SAO 3879"},
    },
    visualMagnitude: 9.75,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.77928978),
        dec: Angle.Degrees(+83.44686646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6552"},
        {"Hipparcos Number", "HIP 5592"},
        {"Geneva Identification System", "GEN# +1.00006552"},
        {"Smithsonian Astrophysical Observation", "SAO 192"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.93056745),
        dec: Angle.Degrees(+83.45698367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184146"},
        {"Hipparcos Number", "HIP 94604"},
        {"Fundamental Katalog 5th Edition", "FK5 3962"},
        {"Geneva Identification System", "GEN# +1.00184146"},
        {"Renson", "Renson 50820"},
        {"Smithsonian Astrophysical Observation", "SAO 3209"},
        {"Wilson Evans Batten Catalogue", "WEB 16487"},
    },
    visualMagnitude: 6.50,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.78295523),
        dec: Angle.Degrees(+83.46272941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65357",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65357"},
        {"Smithsonian Astrophysical Observation", "SAO 2211"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.92494026),
        dec: Angle.Degrees(+83.46298485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52801",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52801"},
        {"Smithsonian Astrophysical Observation", "SAO 1762"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.91975344),
        dec: Angle.Degrees(+83.47186318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85051"},
        {"Hipparcos Number", "HIP 49016"},
        {"Geneva Identification System", "GEN# +1.00085051"},
        {"Smithsonian Astrophysical Observation", "SAO 1615"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.99210947),
        dec: Angle.Degrees(+83.47589538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -123.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53225"},
        {"Hipparcos Number", "HIP 35813"},
        {"Smithsonian Astrophysical Observation", "SAO 1152"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.78899152),
        dec: Angle.Degrees(+83.48709618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209885"},
        {"Hipparcos Number", "HIP 108363"},
        {"Fundamental Katalog 5th Edition", "FK5 5939"},
        {"Geneva Identification System", "GEN# +1.00209885"},
        {"Smithsonian Astrophysical Observation", "SAO 3669"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.29080755),
        dec: Angle.Degrees(+83.49247058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106311"},
        {"Hipparcos Number", "HIP 59566"},
        {"Geneva Identification System", "GEN# +1.00106311"},
        {"Smithsonian Astrophysical Observation", "SAO 2001"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.23166146),
        dec: Angle.Degrees(+83.50322111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82720",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82720"},
        {"Smithsonian Astrophysical Observation", "SAO 2798"},
    },
    visualMagnitude: 9.73,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.61792839),
        dec: Angle.Degrees(+83.50610268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83448"},
        {"Hipparcos Number", "HIP 48236"},
        {"Geneva Identification System", "GEN# +1.00083448"},
        {"Smithsonian Astrophysical Observation", "SAO 1583"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.51330476),
        dec: Angle.Degrees(+83.51003839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20030"},
        {"Hipparcos Number", "HIP 16129"},
        {"Smithsonian Astrophysical Observation", "SAO 540"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.93806444),
        dec: Angle.Degrees(+83.52832332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212857"},
        {"Hipparcos Number", "HIP 110229"},
        {"Geneva Identification System", "GEN# +1.00212857"},
        {"Smithsonian Astrophysical Observation", "SAO 3731"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.92800672),
        dec: Angle.Degrees(+83.53357108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 298.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24374",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24374"},
        {"Smithsonian Astrophysical Observation", "SAO 808"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.44331347),
        dec: Angle.Degrees(+83.53995524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22677"},
        {"Hipparcos Number", "HIP 18300"},
        {"Smithsonian Astrophysical Observation", "SAO 599"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.69490608),
        dec: Angle.Degrees(+83.54500329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12918"},
        {"Hipparcos Number", "HIP 10623"},
        {"Fundamental Katalog 5th Edition", "FK5 1635"},
        {"Geneva Identification System", "GEN# +1.00012918"},
        {"Smithsonian Astrophysical Observation", "SAO 359"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.18862841),
        dec: Angle.Degrees(+83.56151865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18472"},
        {"Hipparcos Number", "HIP 14870"},
        {"Smithsonian Astrophysical Observation", "SAO 492"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.99315086),
        dec: Angle.Degrees(+83.57938577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211552"},
        {"Hipparcos Number", "HIP 109350"},
        {"Smithsonian Astrophysical Observation", "SAO 3706"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.30154022),
        dec: Angle.Degrees(+83.58190745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36989"},
        {"Hipparcos Number", "HIP 27993"},
        {"Smithsonian Astrophysical Observation", "SAO 905"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.80813090),
        dec: Angle.Degrees(+83.60967486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48974"},
        {"Hipparcos Number", "HIP 34235"},
        {"Geneva Identification System", "GEN# +1.00048974"},
        {"Smithsonian Astrophysical Observation", "SAO 1104"},
        {"Wilson Evans Batten Catalogue", "WEB 6855"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.45752759),
        dec: Angle.Degrees(+83.61268873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -221.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77448",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9853 AB"},
        {"Henry Draper", "HD 144463"},
        {"Hipparcos Number", "HIP 77448"},
        {"Smithsonian Astrophysical Observation", "SAO 2625"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.17717193),
        dec: Angle.Degrees(+83.61965924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197508"},
        {"Hipparcos Number", "HIP 101044"},
        {"Geneva Identification System", "GEN# +1.00197508"},
        {"Renson", "Renson 55070"},
        {"Smithsonian Astrophysical Observation", "SAO 3418"},
        {"Wilson Evans Batten Catalogue", "WEB 18249"},
    },
    visualMagnitude: 6.19,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.26174083),
        dec: Angle.Degrees(+83.62546296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2972"},
        {"Hipparcos Number", "HIP 2794"},
        {"Smithsonian Astrophysical Observation", "SAO 93"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.89673398),
        dec: Angle.Degrees(+83.63164599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110533"},
        {"Hipparcos Number", "HIP 61731"},
        {"Geneva Identification System", "GEN# +1.00110533"},
        {"Smithsonian Astrophysical Observation", "SAO 2067"},
        {"Wilson Evans Batten Catalogue", "WEB 10986"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.79627250),
        dec: Angle.Degrees(+83.64407107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -216.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91498",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91498"},
        {"Smithsonian Astrophysical Observation", "SAO 3106"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.90191566),
        dec: Angle.Degrees(+83.65103679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56414",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56414"},
        {"Smithsonian Astrophysical Observation", "SAO 1892"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.48762381),
        dec: Angle.Degrees(+83.67824194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10109",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10109"},
        {"Smithsonian Astrophysical Observation", "SAO 343"},
    },
    visualMagnitude: 10.66,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.51748917),
        dec: Angle.Degrees(+83.67939116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169839"},
        {"Hipparcos Number", "HIP 88707"},
        {"Geneva Identification System", "GEN# +1.00169839"},
        {"Smithsonian Astrophysical Observation", "SAO 3003"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.64477642),
        dec: Angle.Degrees(+83.68313728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216520"},
        {"Hipparcos Number", "HIP 112527"},
        {"Smithsonian Astrophysical Observation", "SAO 3796"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.867,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.88617881),
        dec: Angle.Degrees(+83.69674476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -152.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 116.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150075"},
        {"Hipparcos Number", "HIP 80005"},
        {"Smithsonian Astrophysical Observation", "SAO 2706"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.96830394),
        dec: Angle.Degrees(+83.69722101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159831"},
        {"Hipparcos Number", "HIP 84525"},
        {"Geneva Identification System", "GEN# +1.00159831"},
        {"Smithsonian Astrophysical Observation", "SAO 2865"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.18332280),
        dec: Angle.Degrees(+83.70027394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4853"},
        {"Hipparcos Number", "HIP 4283"},
        {"Fundamental Katalog 5th Edition", "FK5 3942"},
        {"Geneva Identification System", "GEN# +1.00004853"},
        {"Renson", "Renson 1280"},
        {"Smithsonian Astrophysical Observation", "SAO 143"},
        {"Wilson Evans Batten Catalogue", "WEB 767"},
    },
    visualMagnitude: 5.59,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.71984836),
        dec: Angle.Degrees(+83.70746159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70485",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70485"},
        {"Smithsonian Astrophysical Observation", "SAO 2385"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.26307052),
        dec: Angle.Degrees(+83.72496435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199712"},
        {"Hipparcos Number", "HIP 102366"},
        {"Smithsonian Astrophysical Observation", "SAO 3464"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.11314339),
        dec: Angle.Degrees(+83.73501665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80474"},
        {"Hipparcos Number", "HIP 46883"},
        {"Geneva Identification System", "GEN# +1.00080474"},
        {"Smithsonian Astrophysical Observation", "SAO 1525"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.31537534),
        dec: Angle.Degrees(+83.74163142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116481",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116481"},
        {"Smithsonian Astrophysical Observation", "SAO 3937"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.729,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.03774526),
        dec: Angle.Degrees(+83.75552936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 157.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43145"},
        {"Hipparcos Number", "HIP 31429"},
        {"Fundamental Katalog 5th Edition", "FK5 4598"},
        {"Smithsonian Astrophysical Observation", "SAO 1011"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.78678987),
        dec: Angle.Degrees(+83.76362729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38485",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38485"},
        {"Smithsonian Astrophysical Observation", "SAO 1234"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.22033203),
        dec: Angle.Degrees(+83.78099879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -135.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94686",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94686"},
        {"Smithsonian Astrophysical Observation", "SAO 3214"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.00274146),
        dec: Angle.Degrees(+83.79966386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26356"},
        {"Hipparcos Number", "HIP 20860"},
        {"Geneva Identification System", "GEN# +1.00026356"},
        {"Smithsonian Astrophysical Observation", "SAO 685"},
        {"Wilson Evans Batten Catalogue", "WEB 4003"},
    },
    visualMagnitude: 5.51,
    bvColour: -0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.05539751),
        dec: Angle.Degrees(+83.80776284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6447",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6447"},
        {"Smithsonian Astrophysical Observation", "SAO 228"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.70249595),
        dec: Angle.Degrees(+83.80917893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 191.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15036"},
        {"Hipparcos Number", "HIP 12232"},
        {"Fundamental Katalog 5th Edition", "FK5 3944"},
        {"Geneva Identification System", "GEN# +1.00015036"},
        {"Smithsonian Astrophysical Observation", "SAO 404"},
    },
    visualMagnitude: 6.67,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.36633030),
        dec: Angle.Degrees(+83.83453869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75499",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75499"},
        {"Smithsonian Astrophysical Observation", "SAO 2554"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.33403036),
        dec: Angle.Degrees(+83.84155371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138818"},
        {"Hipparcos Number", "HIP 74866"},
        {"Smithsonian Astrophysical Observation", "SAO 2534"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.48958045),
        dec: Angle.Degrees(+83.85947815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34360"},
        {"Hipparcos Number", "HIP 26407"},
        {"Smithsonian Astrophysical Observation", "SAO 866"},
    },
    visualMagnitude: 7.14,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.31269208),
        dec: Angle.Degrees(+83.86148978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16217"},
        {"Hipparcos Number", "HIP 13149"},
        {"Smithsonian Astrophysical Observation", "SAO 431"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.27618494),
        dec: Angle.Degrees(+83.87359026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73835"},
        {"Hipparcos Number", "HIP 43886"},
        {"Geneva Identification System", "GEN# +1.00073835"},
        {"Smithsonian Astrophysical Observation", "SAO 1404"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.10191005),
        dec: Angle.Degrees(+83.88765997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -142.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -114.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116736"},
        {"Hipparcos Number", "HIP 64901"},
        {"Geneva Identification System", "GEN# +1.00116736"},
        {"Smithsonian Astrophysical Observation", "SAO 2194"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.53607719),
        dec: Angle.Degrees(+83.89907995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20311",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20311"},
        {"Smithsonian Astrophysical Observation", "SAO 669"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.26692406),
        dec: Angle.Degrees(+83.90157500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32128",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32128"},
        {"Smithsonian Astrophysical Observation", "SAO 1036"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.64539382),
        dec: Angle.Degrees(+83.90425674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178564"},
        {"Hipparcos Number", "HIP 92336"},
        {"Smithsonian Astrophysical Observation", "SAO 3133"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.28425743),
        dec: Angle.Degrees(+83.90512543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116257"},
        {"Hipparcos Number", "HIP 64678"},
        {"Geneva Identification System", "GEN# +1.00116257"},
        {"Smithsonian Astrophysical Observation", "SAO 2183"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.84883808),
        dec: Angle.Degrees(+83.90558838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87534",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11006 AB"},
        {"Henry Draper", "HD 167101"},
        {"Hipparcos Number", "HIP 87534"},
        {"Smithsonian Astrophysical Observation", "SAO 2975"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.726,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.24571297),
        dec: Angle.Degrees(+83.90752355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86321"},
        {"Hipparcos Number", "HIP 49688"},
        {"Fundamental Katalog 5th Edition", "FK5 3955"},
        {"Geneva Identification System", "GEN# +1.00086321"},
        {"Smithsonian Astrophysical Observation", "SAO 1637"},
        {"Wilson Evans Batten Catalogue", "WEB 9162"},
    },
    visualMagnitude: 6.31,
    bvColour: 1.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.14332324),
        dec: Angle.Degrees(+83.91835727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161463"},
        {"Hipparcos Number", "HIP 85213"},
        {"Smithsonian Astrophysical Observation", "SAO 2888"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.18067962),
        dec: Angle.Degrees(+83.93586320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133872"},
        {"Hipparcos Number", "HIP 72687"},
        {"Smithsonian Astrophysical Observation", "SAO 2465"},
        {"Wilson Evans Batten Catalogue", "WEB 12498"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.91907038),
        dec: Angle.Degrees(+83.93747804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200545"},
        {"Hipparcos Number", "HIP 102781"},
        {"Geneva Identification System", "GEN# +1.00200545"},
        {"Smithsonian Astrophysical Observation", "SAO 3475"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.34226817),
        dec: Angle.Degrees(+83.94150592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 106.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126629"},
        {"Hipparcos Number", "HIP 69563"},
        {"Fundamental Katalog 5th Edition", "FK5 5257"},
        {"Smithsonian Astrophysical Observation", "SAO 2360"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.58868528),
        dec: Angle.Degrees(+83.94451849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100284",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100284"},
        {"Smithsonian Astrophysical Observation", "SAO 3395"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.11103732),
        dec: Angle.Degrees(+83.99949982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 145.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 286.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56311",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56311"},
        {"Fundamental Katalog 5th Edition", "FK5 5017"},
        {"Smithsonian Astrophysical Observation", "SAO 1886"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.17048974),
        dec: Angle.Degrees(+84.00383477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134879"},
        {"Hipparcos Number", "HIP 73119"},
        {"Fundamental Katalog 5th Edition", "FK5 5323"},
        {"Geneva Identification System", "GEN# +1.00134879"},
        {"Smithsonian Astrophysical Observation", "SAO 2478"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.16356881),
        dec: Angle.Degrees(+84.02712930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28167"},
        {"Hipparcos Number", "HIP 22166"},
        {"Smithsonian Astrophysical Observation", "SAO 736"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.53168936),
        dec: Angle.Degrees(+84.02984569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208306"},
        {"Hipparcos Number", "HIP 107334"},
        {"Fundamental Katalog 5th Edition", "FK5 3965"},
        {"Geneva Identification System", "GEN# +1.00208306"},
        {"Smithsonian Astrophysical Observation", "SAO 3636"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.09324890),
        dec: Angle.Degrees(+84.03846328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16276",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2486 A"},
        {"Henry Draper", "HD 20110"},
        {"Hipparcos Number", "HIP 16276"},
        {"Geneva Identification System", "GEN# +1.00020110"},
        {"Smithsonian Astrophysical Observation", "SAO 544"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.46225665),
        dec: Angle.Degrees(+84.03879961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1052",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1052"},
        {"Smithsonian Astrophysical Observation", "SAO 34"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.28519180),
        dec: Angle.Degrees(+84.04424719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 127.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16267",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2486 B"},
        {"Hipparcos Number", "HIP 16267"},
        {"Smithsonian Astrophysical Observation", "SAO 542"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.41313565),
        dec: Angle.Degrees(+84.04662385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117233",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117233"},
        {"Smithsonian Astrophysical Observation", "SAO 3968"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.55728731),
        dec: Angle.Degrees(+84.05347762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65299"},
        {"Hipparcos Number", "HIP 40559"},
        {"Fundamental Katalog 5th Edition", "FK5 1639"},
        {"Geneva Identification System", "GEN# +1.00065299"},
        {"Smithsonian Astrophysical Observation", "SAO 1300"},
        {"Wilson Evans Batten Catalogue", "WEB 7890"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.22484099),
        dec: Angle.Degrees(+84.05768861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20629",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20629"},
        {"Smithsonian Astrophysical Observation", "SAO 682"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.32696609),
        dec: Angle.Degrees(+84.08170734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39261"},
        {"Hipparcos Number", "HIP 29499"},
        {"Smithsonian Astrophysical Observation", "SAO 950"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.23564895),
        dec: Angle.Degrees(+84.09762255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88435",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88435"},
    },
    visualMagnitude: 11.21,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.83787595),
        dec: Angle.Degrees(+84.14739771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 141.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 486"},
        {"Hipparcos Number", "HIP 822"},
        {"Smithsonian Astrophysical Observation", "SAO 26"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.52181595),
        dec: Angle.Degrees(+84.15197251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30166",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4762 AB"},
        {"Henry Draper", "HD 40456"},
        {"Hipparcos Number", "HIP 30166"},
        {"Smithsonian Astrophysical Observation", "SAO 973"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.21084539),
        dec: Angle.Degrees(+84.17904139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76990"},
        {"Hipparcos Number", "HIP 45421"},
        {"Fundamental Katalog 5th Edition", "FK5 1640"},
        {"Geneva Identification System", "GEN# +1.00076990"},
        {"Smithsonian Astrophysical Observation", "SAO 1461"},
        {"Wilson Evans Batten Catalogue", "WEB 8641"},
    },
    visualMagnitude: 6.30,
    bvColour: 0.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.83848952),
        dec: Angle.Degrees(+84.18098826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56862"},
        {"Hipparcos Number", "HIP 37311"},
        {"Fundamental Katalog 5th Edition", "FK5 4688"},
        {"Smithsonian Astrophysical Observation", "SAO 1195"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.89777372),
        dec: Angle.Degrees(+84.19738778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89877",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89877"},
        {"Smithsonian Astrophysical Observation", "SAO 3044"},
    },
    visualMagnitude: 10.56,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.10582731),
        dec: Angle.Degrees(+84.20552486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 122.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 203.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24631",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24631"},
        {"Smithsonian Astrophysical Observation", "SAO 815"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.25771840),
        dec: Angle.Degrees(+84.21156329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42311",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42311"},
        {"Smithsonian Astrophysical Observation", "SAO 1347"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.40691499),
        dec: Angle.Degrees(+84.21245012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219748"},
        {"Hipparcos Number", "HIP 114697"},
        {"Smithsonian Astrophysical Observation", "SAO 3876"},
    },
    visualMagnitude: 7.83,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.51793577),
        dec: Angle.Degrees(+84.24240082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3433",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3433"},
        {"Smithsonian Astrophysical Observation", "SAO 115"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.95431578),
        dec: Angle.Degrees(+84.24525656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89571"},
        {"Hipparcos Number", "HIP 51384"},
        {"Smithsonian Astrophysical Observation", "SAO 1701"},
        {"Wilson Evans Batten Catalogue", "WEB 9382"},
    },
    visualMagnitude: 5.52,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.42586771),
        dec: Angle.Degrees(+84.25210531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -128.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204149"},
        {"Hipparcos Number", "HIP 104716"},
        {"Geneva Identification System", "GEN# +1.00204149"},
        {"Smithsonian Astrophysical Observation", "SAO 3541"},
        {"Wilson Evans Batten Catalogue", "WEB 19044"},
    },
    visualMagnitude: 6.90,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.18867516),
        dec: Angle.Degrees(+84.25866725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71079",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71079"},
        {"Smithsonian Astrophysical Observation", "SAO 2414"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.02890548),
        dec: Angle.Degrees(+84.30679219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8860",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8860"},
        {"Fundamental Katalog 5th Edition", "FK5 4171"},
        {"Smithsonian Astrophysical Observation", "SAO 299"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.49504229),
        dec: Angle.Degrees(+84.32999294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207897"},
        {"Hipparcos Number", "HIP 107038"},
        {"Smithsonian Astrophysical Observation", "SAO 3625"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.868,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.17809989),
        dec: Angle.Degrees(+84.33333718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 344.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217382"},
        {"Hipparcos Number", "HIP 113116"},
        {"Fundamental Katalog 5th Edition", "FK5 1649"},
        {"Geneva Identification System", "GEN# +1.00217382"},
        {"Smithsonian Astrophysical Observation", "SAO 3816"},
        {"Wilson Evans Batten Catalogue", "WEB 20133"},
    },
    visualMagnitude: 4.70,
    bvColour: 1.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.60160144),
        dec: Angle.Degrees(+84.34611856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84505",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84505"},
        {"Smithsonian Astrophysical Observation", "SAO 2867"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.13830534),
        dec: Angle.Degrees(+84.37803155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84076"},
        {"Hipparcos Number", "HIP 48675"},
        {"Smithsonian Astrophysical Observation", "SAO 1597"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.90476401),
        dec: Angle.Degrees(+84.37937566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90343"},
        {"Hipparcos Number", "HIP 51819"},
        {"Geneva Identification System", "GEN# +1.00090343"},
        {"Smithsonian Astrophysical Observation", "SAO 1722"},
        {"Wilson Evans Batten Catalogue", "WEB 9440"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.819,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.79646640),
        dec: Angle.Degrees(+84.39920504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63834"},
        {"Hipparcos Number", "HIP 40073"},
        {"Smithsonian Astrophysical Observation", "SAO 1278"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.79036947),
        dec: Angle.Degrees(+84.40731522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153939"},
        {"Hipparcos Number", "HIP 81625"},
        {"Smithsonian Astrophysical Observation", "SAO 2760"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.07813925),
        dec: Angle.Degrees(+84.45735080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26774"},
        {"Hipparcos Number", "HIP 21319"},
        {"Smithsonian Astrophysical Observation", "SAO 702"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.65073748),
        dec: Angle.Degrees(+84.47242625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38589",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38589"},
        {"Smithsonian Astrophysical Observation", "SAO 1235"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.52119764),
        dec: Angle.Degrees(+84.47741471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45391",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45391"},
        {"Smithsonian Astrophysical Observation", "SAO 1458"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.75211448),
        dec: Angle.Degrees(+84.47892185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7592",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7592"},
        {"Smithsonian Astrophysical Observation", "SAO 251"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.44201977),
        dec: Angle.Degrees(+84.48124685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83615"},
        {"Hipparcos Number", "HIP 48489"},
        {"Geneva Identification System", "GEN# +1.00083615"},
        {"Smithsonian Astrophysical Observation", "SAO 1588"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.32903228),
        dec: Angle.Degrees(+84.48230000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140625"},
        {"Hipparcos Number", "HIP 75529"},
        {"Smithsonian Astrophysical Observation", "SAO 2559"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.797,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.44521497),
        dec: Angle.Degrees(+84.50399624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 122.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212664"},
        {"Hipparcos Number", "HIP 109985"},
        {"Smithsonian Astrophysical Observation", "SAO 3725"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.14125015),
        dec: Angle.Degrees(+84.50445131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121623"},
        {"Hipparcos Number", "HIP 67134"},
        {"Fundamental Katalog 5th Edition", "FK5 5217"},
        {"Smithsonian Astrophysical Observation", "SAO 2280"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.38076214),
        dec: Angle.Degrees(+84.51332424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177806"},
        {"Hipparcos Number", "HIP 91876"},
        {"Smithsonian Astrophysical Observation", "SAO 3126"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.94765529),
        dec: Angle.Degrees(+84.54326624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195147"},
        {"Hipparcos Number", "HIP 99433"},
        {"Geneva Identification System", "GEN# +1.00195147"},
        {"Renson", "Renson 54397"},
        {"Smithsonian Astrophysical Observation", "SAO 3367"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.73167864),
        dec: Angle.Degrees(+84.54441655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149501"},
        {"Hipparcos Number", "HIP 79517"},
        {"Smithsonian Astrophysical Observation", "SAO 2695"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.39364339),
        dec: Angle.Degrees(+84.55190639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13419"},
        {"Hipparcos Number", "HIP 11164"},
        {"Smithsonian Astrophysical Observation", "SAO 371"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.91748477),
        dec: Angle.Degrees(+84.57090865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23304",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23304"},
    },
    visualMagnitude: 10.88,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.17942047),
        dec: Angle.Degrees(+84.57483715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144301"},
        {"Hipparcos Number", "HIP 77109"},
        {"Geneva Identification System", "GEN# +1.00144301"},
        {"Smithsonian Astrophysical Observation", "SAO 2615"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.16950208),
        dec: Angle.Degrees(+84.57921746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 113.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159251"},
        {"Hipparcos Number", "HIP 84008"},
        {"Geneva Identification System", "GEN# +1.00159251"},
        {"Smithsonian Astrophysical Observation", "SAO 2841"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.58570096),
        dec: Angle.Degrees(+84.59883658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5621"},
        {"Hipparcos Number", "HIP 4965"},
        {"Geneva Identification System", "GEN# +1.00005621"},
        {"Smithsonian Astrophysical Observation", "SAO 171"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.91411828),
        dec: Angle.Degrees(+84.60692182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89516",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89516"},
        {"Smithsonian Astrophysical Observation", "SAO 3031"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.00934228),
        dec: Angle.Degrees(+84.61148946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199625"},
        {"Hipparcos Number", "HIP 102104"},
        {"Smithsonian Astrophysical Observation", "SAO 3459"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.37502155),
        dec: Angle.Degrees(+84.61389337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14015",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14015"},
        {"Smithsonian Astrophysical Observation", "SAO 461"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.10480123),
        dec: Angle.Degrees(+84.64783857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170489"},
        {"Hipparcos Number", "HIP 88653"},
        {"Geneva Identification System", "GEN# +1.00170489"},
        {"Smithsonian Astrophysical Observation", "SAO 3005"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.49913414),
        dec: Angle.Degrees(+84.65585842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103047",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103047"},
        {"Smithsonian Astrophysical Observation", "SAO 3486"},
    },
    visualMagnitude: 10.98,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.16949520),
        dec: Angle.Degrees(+84.65887161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47547"},
        {"Hipparcos Number", "HIP 33952"},
        {"Geneva Identification System", "GEN# +1.00047547"},
        {"Smithsonian Astrophysical Observation", "SAO 1081"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.878,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.67621604),
        dec: Angle.Degrees(+84.66269248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193214"},
        {"Hipparcos Number", "HIP 98382"},
        {"Fundamental Katalog 5th Edition", "FK5 1647"},
        {"Geneva Identification System", "GEN# +1.00193214"},
        {"Smithsonian Astrophysical Observation", "SAO 3332"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.83365068),
        dec: Angle.Degrees(+84.66874674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33466",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33466"},
        {"Smithsonian Astrophysical Observation", "SAO 1068"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.35742996),
        dec: Angle.Degrees(+84.67059535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3161"},
        {"Hipparcos Number", "HIP 3006"},
        {"Geneva Identification System", "GEN# +1.00003161"},
        {"Smithsonian Astrophysical Observation", "SAO 102"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.56130273),
        dec: Angle.Degrees(+84.67502086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61278",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61278"},
        {"Smithsonian Astrophysical Observation", "SAO 2055"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.842,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.36375424),
        dec: Angle.Degrees(+84.67925233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -123.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42982",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6902 AB"},
        {"Hipparcos Number", "HIP 42982"},
        {"Smithsonian Astrophysical Observation", "SAO 1366"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.39724615),
        dec: Angle.Degrees(+84.69374234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -192.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141263"},
        {"Hipparcos Number", "HIP 75726"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.05453086),
        dec: Angle.Degrees(+84.69635180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75993"},
        {"Hipparcos Number", "HIP 45088"},
        {"Geneva Identification System", "GEN# +1.00075993"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.77136557),
        dec: Angle.Degrees(+84.69830602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
