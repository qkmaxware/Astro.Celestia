using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_109() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70253"},
        {"Hipparcos Number", "HIP 41153"},
        {"Geneva Identification System", "GEN# +1.00070253"},
        {"Smithsonian Astrophysical Observation", "SAO 26815"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.95422739),
        dec: Angle.Degrees(+57.41710142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238794"},
        {"Hipparcos Number", "HIP 88163"},
        {"Smithsonian Astrophysical Observation", "SAO 30691"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.09610293),
        dec: Angle.Degrees(+57.41799481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43924"},
        {"Hipparcos Number", "HIP 30294"},
        {"Smithsonian Astrophysical Observation", "SAO 25685"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.58518845),
        dec: Angle.Degrees(+57.41823511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85945"},
        {"Hipparcos Number", "HIP 48802"},
        {"Geneva Identification System", "GEN# +1.00085945"},
        {"Smithsonian Astrophysical Observation", "SAO 27438"},
        {"Wilson Evans Batten Catalogue", "WEB 9073"},
    },
    visualMagnitude: 5.97,
    bvColour: 0.895,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.30654965),
        dec: Angle.Degrees(+57.41835080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237720"},
        {"Hipparcos Number", "HIP 41745"},
        {"Smithsonian Astrophysical Observation", "SAO 26877"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.68689523),
        dec: Angle.Degrees(+57.41985452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16617"},
        {"Hipparcos Number", "HIP 12609"},
        {"Smithsonian Astrophysical Observation", "SAO 23539"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.52863004),
        dec: Angle.Degrees(+57.42041188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28734"},
        {"Hipparcos Number", "HIP 21369"},
        {"Fundamental Katalog 5th Edition", "FK5 4412"},
        {"Geneva Identification System", "GEN# +1.00028734"},
        {"Smithsonian Astrophysical Observation", "SAO 24695"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.77223085),
        dec: Angle.Degrees(+57.42063106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83115"},
        {"Hipparcos Number", "HIP 47297"},
        {"Smithsonian Astrophysical Observation", "SAO 27319"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.58530837),
        dec: Angle.Degrees(+57.42470544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114573"},
        {"Hipparcos Number", "HIP 64273"},
        {"Smithsonian Astrophysical Observation", "SAO 28665"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.59049556),
        dec: Angle.Degrees(+57.42599330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75855"},
        {"Hipparcos Number", "HIP 43784"},
        {"Smithsonian Astrophysical Observation", "SAO 27041"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.76726745),
        dec: Angle.Degrees(+57.42694627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238952"},
        {"Hipparcos Number", "HIP 92653"},
        {"Smithsonian Astrophysical Observation", "SAO 31240"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.20435542),
        dec: Angle.Degrees(+57.42923774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102101",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102101"},
        {"Geneva Identification System", "GEN# +0.05602471"},
        {"Wilson Evans Batten Catalogue", "WEB 18468"},
    },
    visualMagnitude: 10.27,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.36689750),
        dec: Angle.Degrees(+57.42929757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 207.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238740"},
        {"Hipparcos Number", "HIP 86513"},
        {"Smithsonian Astrophysical Observation", "SAO 30520"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.20258804),
        dec: Angle.Degrees(+57.43512834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74326"},
        {"Hipparcos Number", "HIP 43021"},
        {"Geneva Identification System", "GEN# +1.00074326"},
        {"Smithsonian Astrophysical Observation", "SAO 26986"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.50475651),
        dec: Angle.Degrees(+57.43513676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236733"},
        {"Hipparcos Number", "HIP 6747"},
        {"Smithsonian Astrophysical Observation", "SAO 22280"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.71369234),
        dec: Angle.Degrees(+57.43695562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14826"},
        {"Henry Draper 2", "HD 14826B"},
        {"Hipparcos Number", "HIP 11284"},
        {"Geneva Identification System", "GEN# +1.00014826A"},
        {"Geneva Identification System 2", "GEN# +1.00014826B"},
        {"Smithsonian Astrophysical Observation", "SAO 23309"},
        {"Wilson Evans Batten Catalogue", "WEB 2362"},
    },
    visualMagnitude: 8.54,
    bvColour: 2.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.34108967),
        dec: Angle.Degrees(+57.43726163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24298"},
        {"Hipparcos Number", "HIP 18314"},
        {"Geneva Identification System", "GEN# +1.00024298"},
        {"Smithsonian Astrophysical Observation", "SAO 24287"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.73366934),
        dec: Angle.Degrees(+57.44118944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13573",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13573"},
        {"Geneva Identification System", "GEN# +0.05600739"},
        {"Wilson Evans Batten Catalogue", "WEB 2701"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.71160823),
        dec: Angle.Degrees(+57.44328321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163010"},
        {"Hipparcos Number", "HIP 87317"},
        {"Smithsonian Astrophysical Observation", "SAO 30607"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.63064860),
        dec: Angle.Degrees(+57.44347647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75783",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9672 A"},
        {"Henry Draper", "HD 138367"},
        {"Hipparcos Number", "HIP 75783"},
        {"Geneva Identification System", "GEN# +1.00138367"},
        {"Smithsonian Astrophysical Observation", "SAO 29542"},
        {"Wilson Evans Batten Catalogue", "WEB 12902"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.21754038),
        dec: Angle.Degrees(+57.44477883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -260.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 164.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114406",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16560 AB"},
        {"Henry Draper", "HD 218803"},
        {"Hipparcos Number", "HIP 114406"},
        {"Smithsonian Astrophysical Observation", "SAO 35193"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.53960040),
        dec: Angle.Degrees(+57.44840796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24717"},
        {"Hipparcos Number", "HIP 18602"},
        {"Smithsonian Astrophysical Observation", "SAO 24325"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.70760613),
        dec: Angle.Degrees(+57.45097654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223173"},
        {"Hipparcos Number", "HIP 117299"},
        {"Geneva Identification System", "GEN# +1.00223173"},
        {"Smithsonian Astrophysical Observation", "SAO 35761"},
        {"Wilson Evans Batten Catalogue", "WEB 20665"},
    },
    visualMagnitude: 5.55,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.75797734),
        dec: Angle.Degrees(+57.45137702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93595",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12019 A"},
        {"Henry Draper", "HD 178001"},
        {"Hipparcos Number", "HIP 93595"},
        {"Geneva Identification System", "GEN# +1.00178001A"},
        {"Renson", "Renson 49600"},
        {"Wilson Evans Batten Catalogue", "WEB 16258"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.91473764),
        dec: Angle.Degrees(+57.45717259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93598",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12019 B"},
        {"Hipparcos Number", "HIP 93598"},
        {"Geneva Identification System", "GEN# +1.00178001B"},
        {"Renson", "Renson 49610"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.91933409),
        dec: Angle.Degrees(+57.45877382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26553"},
        {"Hipparcos Number", "HIP 19823"},
        {"Fundamental Katalog 5th Edition", "FK5 2304"},
        {"Geneva Identification System", "GEN# +1.00026553"},
        {"Renson", "Renson 6760"},
        {"Smithsonian Astrophysical Observation", "SAO 24495"},
        {"Wilson Evans Batten Catalogue", "WEB 3786"},
    },
    visualMagnitude: 6.06,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.75749346),
        dec: Angle.Degrees(+57.46036262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140064"},
        {"Hipparcos Number", "HIP 76627"},
        {"Smithsonian Astrophysical Observation", "SAO 29607"},
        {"Wilson Evans Batten Catalogue", "WEB 13009"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.72748925),
        dec: Angle.Degrees(+57.46180365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225274"},
        {"Hipparcos Number", "HIP 408"},
        {"Geneva Identification System", "GEN# +1.00225274"},
        {"Smithsonian Astrophysical Observation", "SAO 21066"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.24502692),
        dec: Angle.Degrees(+57.46874679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10384",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10384"},
    },
    visualMagnitude: 11.02,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.43131254),
        dec: Angle.Degrees(+57.46938518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35232"},
        {"Hipparcos Number", "HIP 25474"},
        {"Smithsonian Astrophysical Observation", "SAO 25197"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.71308446),
        dec: Angle.Degrees(+57.47052481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237162"},
        {"Hipparcos Number", "HIP 17080"},
        {"Smithsonian Astrophysical Observation", "SAO 24143"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.774,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.89855874),
        dec: Angle.Degrees(+57.47319659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87033"},
        {"Hipparcos Number", "HIP 49323"},
        {"Geneva Identification System", "GEN# +1.00087033"},
        {"Smithsonian Astrophysical Observation", "SAO 27499"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.02207706),
        dec: Angle.Degrees(+57.47415768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104239"},
        {"Hipparcos Number", "HIP 58543"},
        {"Geneva Identification System", "GEN# +1.00104239"},
        {"Smithsonian Astrophysical Observation", "SAO 28218"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.851,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.07374617),
        dec: Angle.Degrees(+57.47475497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -109.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239827"},
        {"Hipparcos Number", "HIP 108724"},
        {"Smithsonian Astrophysical Observation", "SAO 33979"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.36668560),
        dec: Angle.Degrees(+57.48017058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79675"},
        {"Hipparcos Number", "HIP 45610"},
        {"Geneva Identification System", "GEN# +1.00079675"},
        {"Smithsonian Astrophysical Observation", "SAO 27201"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.45419248),
        dec: Angle.Degrees(+57.48060927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239729"},
        {"Hipparcos Number", "HIP 106937"},
        {"Geneva Identification System", "GEN# +4.35370477"},
        {"Smithsonian Astrophysical Observation", "SAO 33637"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.86420069),
        dec: Angle.Degrees(+57.48356950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38582",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38582"},
    },
    visualMagnitude: 10.71,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.50309720),
        dec: Angle.Degrees(+57.48445478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175823"},
        {"Hipparcos Number", "HIP 92731"},
        {"Geneva Identification System", "GEN# +1.00175823"},
        {"Smithsonian Astrophysical Observation", "SAO 31252"},
        {"Wilson Evans Batten Catalogue", "WEB 16047"},
    },
    visualMagnitude: 6.24,
    bvColour: 1.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.44286073),
        dec: Angle.Degrees(+57.48659538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106890",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15184 C"},
        {"Hipparcos Number", "HIP 106890"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.74539056),
        dec: Angle.Degrees(+57.48740974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106886",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15184 AB"},
        {"Henry Draper", "HD 206267"},
        {"Hipparcos Number", "HIP 106886"},
        {"Celescope Catalog", "CEL 5359"},
        {"Fundamental Katalog 5th Edition", "FK5 813"},
        {"Geneva Identification System", "GEN# +4.35370466J"},
        {"Smithsonian Astrophysical Observation", "SAO 33626"},
        {"Wilson Evans Batten Catalogue", "WEB 19318"},
    },
    visualMagnitude: 5.74,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.74008434),
        dec: Angle.Degrees(+57.48904968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152084"},
        {"Hipparcos Number", "HIP 82232"},
        {"Geneva Identification System", "GEN# +1.00152084"},
        {"Smithsonian Astrophysical Observation", "SAO 30104"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.00379376),
        dec: Angle.Degrees(+57.48930192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237963"},
        {"Hipparcos Number", "HIP 53892"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.763,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.40623248),
        dec: Angle.Degrees(+57.49078656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239954"},
        {"Hipparcos Number", "HIP 110819"},
        {"Smithsonian Astrophysical Observation", "SAO 34462"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.77681885),
        dec: Angle.Degrees(+57.49199673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106884",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15184 D"},
        {"Hipparcos Number", "HIP 106884"},
        {"Geneva Identification System", "GEN# +1.40206267"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.73634213),
        dec: Angle.Degrees(+57.49421774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27748"},
        {"Hipparcos Number", "HIP 20690"},
        {"Geneva Identification System", "GEN# +1.00027748"},
        {"Smithsonian Astrophysical Observation", "SAO 24601"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.47894271),
        dec: Angle.Degrees(+57.49527140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83588"},
        {"Hipparcos Number", "HIP 47547"},
        {"Smithsonian Astrophysical Observation", "SAO 27342"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.851,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.40065274),
        dec: Angle.Degrees(+57.49637704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55186",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55186"},
    },
    visualMagnitude: 10.54,
    bvColour: 1.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.48678318),
        dec: Angle.Degrees(+57.49738078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224014"},
        {"Hipparcos Number", "HIP 117863"},
        {"Fundamental Katalog 5th Edition", "FK5 899"},
        {"Geneva Identification System", "GEN# +1.00224014"},
        {"Smithsonian Astrophysical Observation", "SAO 35879"},
        {"Wilson Evans Batten Catalogue", "WEB 20732"},
    },
    visualMagnitude: 4.51,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.59598888),
        dec: Angle.Degrees(+57.49939052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154689"},
        {"Hipparcos Number", "HIP 83467"},
        {"Smithsonian Astrophysical Observation", "SAO 30222"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.89183770),
        dec: Angle.Degrees(+57.49971322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47831",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47831"},
    },
    visualMagnitude: 10.31,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.24633584),
        dec: Angle.Degrees(+57.50235701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205196"},
        {"Hipparcos Number", "HIP 106285"},
        {"Geneva Identification System", "GEN# +4.35370401"},
        {"Smithsonian Astrophysical Observation", "SAO 33506"},
        {"Wilson Evans Batten Catalogue", "WEB 19254"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.91004778),
        dec: Angle.Degrees(+57.50259837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94631"},
        {"Hipparcos Number", "HIP 53481"},
        {"Geneva Identification System", "GEN# +1.00094631"},
        {"Smithsonian Astrophysical Observation", "SAO 27831"},
        {"Wilson Evans Batten Catalogue", "WEB 9707"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.11178734),
        dec: Angle.Degrees(+57.50303530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158788"},
        {"Hipparcos Number", "HIP 85444"},
        {"Geneva Identification System", "GEN# +1.00158788"},
        {"Smithsonian Astrophysical Observation", "SAO 30401"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.92119324),
        dec: Angle.Degrees(+57.51046472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16495"},
        {"Hipparcos Number", "HIP 12516"},
        {"Smithsonian Astrophysical Observation", "SAO 23523"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.26664594),
        dec: Angle.Degrees(+57.51080723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238254"},
        {"Hipparcos Number", "HIP 66215"},
        {"Smithsonian Astrophysical Observation", "SAO 28805"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.57068634),
        dec: Angle.Degrees(+57.51142452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146657"},
        {"Hipparcos Number", "HIP 79582"},
        {"Smithsonian Astrophysical Observation", "SAO 29851"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.56198784),
        dec: Angle.Degrees(+57.51339556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10729",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1753 A"},
        {"Henry Draper", "HD 13994"},
        {"Hipparcos Number", "HIP 10729"},
        {"Geneva Identification System", "GEN# +1.00013994A"},
        {"Smithsonian Astrophysical Observation", "SAO 23149"},
        {"Wilson Evans Batten Catalogue", "WEB 2262"},
    },
    visualMagnitude: 5.99,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.51916463),
        dec: Angle.Degrees(+57.51632574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3496"},
        {"Hipparcos Number", "HIP 3034"},
        {"Smithsonian Astrophysical Observation", "SAO 21589"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.64782427),
        dec: Angle.Degrees(+57.51691319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140024"},
        {"Hipparcos Number", "HIP 76609"},
        {"Smithsonian Astrophysical Observation", "SAO 29605"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.67621089),
        dec: Angle.Degrees(+57.52073023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188665"},
        {"Hipparcos Number", "HIP 97870"},
        {"Celescope Catalog", "CEL 4873"},
        {"Geneva Identification System", "GEN# +1.00188665"},
        {"Smithsonian Astrophysical Observation", "SAO 32085"},
        {"Wilson Evans Batten Catalogue", "WEB 17220"},
    },
    visualMagnitude: 5.14,
    bvColour: -0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.32237872),
        dec: Angle.Degrees(+57.52346329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178659"},
        {"Hipparcos Number", "HIP 93804"},
        {"Smithsonian Astrophysical Observation", "SAO 31388"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.55261061),
        dec: Angle.Degrees(+57.52483143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239392"},
        {"Hipparcos Number", "HIP 100538"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.79194948),
        dec: Angle.Degrees(+57.52601242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43485",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7033 AB"},
        {"Henry Draper", "HD 75230"},
        {"Hipparcos Number", "HIP 43485"},
        {"Smithsonian Astrophysical Observation", "SAO 27015"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.85913647),
        dec: Angle.Degrees(+57.52724822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237917"},
        {"Hipparcos Number", "HIP 52074"},
        {"Smithsonian Astrophysical Observation", "SAO 27719"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.61443233),
        dec: Angle.Degrees(+57.52760935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239819"},
        {"Hipparcos Number", "HIP 108541"},
        {"Smithsonian Astrophysical Observation", "SAO 33942"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.82365685),
        dec: Angle.Degrees(+57.53509436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115529",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16731 AB"},
        {"Henry Draper", "HD 220562"},
        {"Hipparcos Number", "HIP 115529"},
        {"Celescope Catalog", "CEL 5611"},
        {"Geneva Identification System", "GEN# +1.00220562J"},
        {"Smithsonian Astrophysical Observation", "SAO 35386"},
        {"Wilson Evans Batten Catalogue", "WEB 20451"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.03294042),
        dec: Angle.Degrees(+57.53551507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49270",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7616 AB"},
        {"Henry Draper", "HD 86911"},
        {"Hipparcos Number", "HIP 49270"},
        {"Smithsonian Astrophysical Observation", "SAO 27495"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.797,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.85930297),
        dec: Angle.Degrees(+57.53574631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8115",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1359 AB"},
        {"Henry Draper", "HD 10543"},
        {"Hipparcos Number", "HIP 8115"},
        {"Geneva Identification System", "GEN# +1.00010543"},
        {"Smithsonian Astrophysical Observation", "SAO 22566"},
        {"Wilson Evans Batten Catalogue", "WEB 1735"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.07464115),
        dec: Angle.Degrees(+57.53666151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11898",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1937 A"},
        {"Henry Draper", "HD 15690"},
        {"Hipparcos Number", "HIP 11898"},
        {"Geneva Identification System", "GEN# +2.09570213"},
        {"Smithsonian Astrophysical Observation", "SAO 23426"},
        {"Wilson Evans Batten Catalogue", "WEB 2461"},
        {"New General Catalogue", "NGC 957 213"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.38661308),
        dec: Angle.Degrees(+57.53743348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205330"},
        {"Hipparcos Number", "HIP 106358"},
        {"Smithsonian Astrophysical Observation", "SAO 33519"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.12444231),
        dec: Angle.Degrees(+57.53837965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74048"},
        {"Hipparcos Number", "HIP 42875"},
        {"Geneva Identification System", "GEN# +1.00074048"},
        {"Smithsonian Astrophysical Observation", "SAO 26976"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.06338852),
        dec: Angle.Degrees(+57.53955878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11902",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1937 B"},
        {"Hipparcos Number", "HIP 11902"},
        {"Geneva Identification System", "GEN# +2.09570116"},
        {"Smithsonian Astrophysical Observation", "SAO 23427"},
        {"Wilson Evans Batten Catalogue", "WEB 2464"},
        {"New General Catalogue", "NGC 957 116"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.39081982),
        dec: Angle.Degrees(+57.54357567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34787"},
        {"Hipparcos Number", "HIP 25197"},
        {"Fundamental Katalog 5th Edition", "FK5 2402"},
        {"Geneva Identification System", "GEN# +1.00034787"},
        {"Smithsonian Astrophysical Observation", "SAO 25161"},
        {"Wilson Evans Batten Catalogue", "WEB 4883"},
    },
    visualMagnitude: 5.24,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.86594376),
        dec: Angle.Degrees(+57.54453138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60114",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60114"},
    },
    visualMagnitude: 10.02,
    bvColour: 1.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.92132074),
        dec: Angle.Degrees(+57.54967745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60272"},
        {"Hipparcos Number", "HIP 37061"},
        {"Geneva Identification System", "GEN# +1.00060272"},
        {"Smithsonian Astrophysical Observation", "SAO 26424"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.797,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.24214367),
        dec: Angle.Degrees(+57.55010235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -187.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103093",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103093"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.32685748),
        dec: Angle.Degrees(+57.55329850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -155.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159870"},
        {"Hipparcos Number", "HIP 85923"},
        {"Geneva Identification System", "GEN# +1.00159870"},
        {"Renson", "Renson 44990"},
        {"Smithsonian Astrophysical Observation", "SAO 30464"},
        {"Wilson Evans Batten Catalogue", "WEB 14500"},
    },
    visualMagnitude: 6.15,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.38167294),
        dec: Angle.Degrees(+57.55870857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114633"},
        {"Hipparcos Number", "HIP 64309"},
        {"Geneva Identification System", "GEN# +1.00114633"},
        {"Smithsonian Astrophysical Observation", "SAO 28669"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.71574080),
        dec: Angle.Degrees(+57.56037188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106774",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15160 AB"},
        {"Henry Draper", "HD 206081"},
        {"Hipparcos Number", "HIP 106774"},
        {"Geneva Identification System", "GEN# +4.35370452J"},
        {"Smithsonian Astrophysical Observation", "SAO 33601"},
    },
    visualMagnitude: 8.25,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.42055058),
        dec: Angle.Degrees(+57.56042715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128717"},
        {"Hipparcos Number", "HIP 71425"},
        {"Geneva Identification System", "GEN# +1.00128717"},
        {"Smithsonian Astrophysical Observation", "SAO 29217"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.08919838),
        dec: Angle.Degrees(+57.56049552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56299",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56299"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.12715329),
        dec: Angle.Degrees(+57.56146012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -332.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105732",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14964 AB"},
        {"Henry Draper", "HD 239659"},
        {"Hipparcos Number", "HIP 105732"},
        {"Geneva Identification System", "GEN# +1.00239659J"},
        {"Smithsonian Astrophysical Observation", "SAO 33412"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.22907368),
        dec: Angle.Degrees(+57.56285632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50551"},
        {"Hipparcos Number", "HIP 33444"},
        {"Geneva Identification System", "GEN# +1.00050551"},
        {"Smithsonian Astrophysical Observation", "SAO 26050"},
        {"Wilson Evans Batten Catalogue", "WEB 6721"},
    },
    visualMagnitude: 6.03,
    bvColour: 1.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.30468454),
        dec: Angle.Degrees(+57.56324900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4202"},
        {"Hipparcos Number", "HIP 3542"},
        {"Smithsonian Astrophysical Observation", "SAO 21676"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.31465978),
        dec: Angle.Degrees(+57.56507514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105522",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14926 AB"},
        {"Henry Draper", "HD 203802"},
        {"Hipparcos Number", "HIP 105522"},
        {"Geneva Identification System", "GEN# +1.00203802"},
        {"Smithsonian Astrophysical Observation", "SAO 33367"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.58508785),
        dec: Angle.Degrees(+57.56516356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22830"},
        {"Hipparcos Number", "HIP 17361"},
        {"Geneva Identification System", "GEN# +1.00022830"},
        {"Smithsonian Astrophysical Observation", "SAO 24175"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.75118515),
        dec: Angle.Degrees(+57.56556831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57225"},
        {"Hipparcos Number", "HIP 35867"},
        {"Geneva Identification System", "GEN# +1.00057225"},
        {"Smithsonian Astrophysical Observation", "SAO 26319"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.92101577),
        dec: Angle.Degrees(+57.57730853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208003"},
        {"Hipparcos Number", "HIP 107872"},
        {"Smithsonian Astrophysical Observation", "SAO 33809"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.84141955),
        dec: Angle.Degrees(+57.57856985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198084"},
        {"Hipparcos Number", "HIP 102431"},
        {"Fundamental Katalog 5th Edition", "FK5 782"},
        {"Geneva Identification System", "GEN# +1.00198084"},
        {"Smithsonian Astrophysical Observation", "SAO 32862"},
        {"Wilson Evans Batten Catalogue", "WEB 18550"},
    },
    visualMagnitude: 4.52,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.33831928),
        dec: Angle.Degrees(+57.58029799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -235.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50926"},
        {"Hipparcos Number", "HIP 33581"},
        {"Geneva Identification System", "GEN# +1.00050926"},
        {"Smithsonian Astrophysical Observation", "SAO 26071"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.65905260),
        dec: Angle.Degrees(+57.58351778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20772",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3203 A"},
        {"Henry Draper", "HD 27855"},
        {"Hipparcos Number", "HIP 20772"},
        {"Fundamental Katalog 5th Edition", "FK5 2324"},
        {"Geneva Identification System", "GEN# +1.00027855"},
        {"Smithsonian Astrophysical Observation", "SAO 24615"},
        {"Wilson Evans Batten Catalogue", "WEB 3983"},
    },
    visualMagnitude: 6.28,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.75360139),
        dec: Angle.Degrees(+57.58533041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 663"},
        {"Hipparcos Number", "HIP 902"},
        {"Smithsonian Astrophysical Observation", "SAO 21178"},
    },
    visualMagnitude: 6.68,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.78289623),
        dec: Angle.Degrees(+57.58791462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18868"},
        {"Hipparcos Number", "HIP 14308"},
        {"Geneva Identification System", "GEN# +1.00018868"},
        {"Smithsonian Astrophysical Observation", "SAO 23785"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.14396216),
        dec: Angle.Degrees(+57.59065223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145181"},
        {"Hipparcos Number", "HIP 78908"},
        {"Smithsonian Astrophysical Observation", "SAO 29803"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.61279344),
        dec: Angle.Degrees(+57.59363150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3347",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 587 A"},
        {"Henry Draper", "HD 3941"},
        {"Hipparcos Number", "HIP 3347"},
        {"Smithsonian Astrophysical Observation", "SAO 21645"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.66249932),
        dec: Angle.Degrees(+57.59626143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5569",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 973 AB"},
        {"Henry Draper", "HD 236644"},
        {"Hipparcos Number", "HIP 5569"},
        {"Celescope Catalog", "CEL 126"},
        {"Smithsonian Astrophysical Observation", "SAO 22073"},
        {"Wilson Evans Batten Catalogue", "WEB 1243"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.85805884),
        dec: Angle.Degrees(+57.59679104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112500"},
        {"Hipparcos Number", "HIP 63153"},
        {"Geneva Identification System", "GEN# +1.00112500"},
        {"Smithsonian Astrophysical Observation", "SAO 28575"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.11033330),
        dec: Angle.Degrees(+57.60025601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105197"},
        {"Hipparcos Number", "HIP 59061"},
        {"Geneva Identification System", "GEN# +1.00105197"},
        {"Smithsonian Astrophysical Observation", "SAO 28250"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.68525089),
        dec: Angle.Degrees(+57.60059133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113224",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113224"},
        {"Geneva Identification System", "GEN# +0.05602903"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.94081298),
        dec: Angle.Degrees(+57.60192514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106617"},
        {"Hipparcos Number", "HIP 59794"},
        {"Smithsonian Astrophysical Observation", "SAO 28317"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.90932299),
        dec: Angle.Degrees(+57.60725705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215188"},
        {"Hipparcos Number", "HIP 112093"},
        {"Geneva Identification System", "GEN# +1.00215188"},
        {"Smithsonian Astrophysical Observation", "SAO 34712"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.56544735),
        dec: Angle.Degrees(+57.60814473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237056"},
        {"Hipparcos Number", "HIP 14166"},
        {"Geneva Identification System", "GEN# +1.00237056"},
        {"Smithsonian Astrophysical Observation", "SAO 23776"},
        {"Wilson Evans Batten Catalogue", "WEB 2784"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.65786189),
        dec: Angle.Degrees(+57.61279756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126186"},
        {"Hipparcos Number", "HIP 70223"},
        {"Smithsonian Astrophysical Observation", "SAO 29118"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.862,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.50617235),
        dec: Angle.Degrees(+57.61456320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96688"},
        {"Hipparcos Number", "HIP 54509"},
        {"Smithsonian Astrophysical Observation", "SAO 27926"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.28439383),
        dec: Angle.Degrees(+57.61792392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202107"},
        {"Hipparcos Number", "HIP 104605"},
        {"Celescope Catalog", "CEL 5266"},
        {"Geneva Identification System", "GEN# +1.00202107"},
        {"Smithsonian Astrophysical Observation", "SAO 33201"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.85073915),
        dec: Angle.Degrees(+57.62041855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72151",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72151"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.753,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.36761124),
        dec: Angle.Degrees(+57.62050484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -181.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 96.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236565"},
        {"Hipparcos Number", "HIP 4107"},
        {"Smithsonian Astrophysical Observation", "SAO 21792"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.16979228),
        dec: Angle.Degrees(+57.62415007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24461",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24461"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.73555088),
        dec: Angle.Degrees(+57.62618264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50970"},
        {"Hipparcos Number", "HIP 33598"},
        {"Geneva Identification System", "GEN# +1.00050970"},
        {"Smithsonian Astrophysical Observation", "SAO 26072"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.71304078),
        dec: Angle.Degrees(+57.62747834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113264"},
        {"Hipparcos Number", "HIP 63575"},
        {"Geneva Identification System", "GEN# +1.00113264"},
        {"Smithsonian Astrophysical Observation", "SAO 28605"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.42073161),
        dec: Angle.Degrees(+57.62853386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237307"},
        {"Hipparcos Number", "HIP 21943"},
        {"Smithsonian Astrophysical Observation", "SAO 24774"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.75112496),
        dec: Angle.Degrees(+57.63085557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7636"},
        {"Hipparcos Number", "HIP 6027"},
        {"Celescope Catalog", "CEL 133"},
        {"Geneva Identification System", "GEN# +1.00007636"},
        {"Smithsonian Astrophysical Observation", "SAO 22154"},
        {"Wilson Evans Batten Catalogue", "WEB 1362"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.35953945),
        dec: Angle.Degrees(+57.63207880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151406"},
        {"Hipparcos Number", "HIP 81916"},
        {"Geneva Identification System", "GEN# +1.00151406"},
        {"Smithsonian Astrophysical Observation", "SAO 30071"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.98214919),
        dec: Angle.Degrees(+57.63538726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57820",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Aniara"},
        {"Henry Draper", "HD 102956"},
        {"Hipparcos Number", "HIP 57820"},
        {"Geneva Identification System", "GEN# +1.00102956"},
        {"Smithsonian Astrophysical Observation", "SAO 28161"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.84384947),
        dec: Angle.Degrees(+57.64077649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182190"},
        {"Hipparcos Number", "HIP 95038"},
        {"Geneva Identification System", "GEN# +1.00182190"},
        {"Smithsonian Astrophysical Observation", "SAO 31587"},
        {"Wilson Evans Batten Catalogue", "WEB 16599"},
    },
    visualMagnitude: 5.91,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.06668355),
        dec: Angle.Degrees(+57.64511743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10227",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1685 A"},
        {"Henry Draper", "HD 13267"},
        {"Hipparcos Number", "HIP 10227"},
        {"Celescope Catalog", "CEL 217"},
        {"Geneva Identification System", "GEN# +1.00013267J"},
        {"Smithsonian Astrophysical Observation", "SAO 23011"},
        {"Wilson Evans Batten Catalogue", "WEB 2134"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.87164306),
        dec: Angle.Degrees(+57.64554793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219651"},
        {"Hipparcos Number", "HIP 114940"},
        {"Celescope Catalog", "CEL 5590"},
        {"Smithsonian Astrophysical Observation", "SAO 35288"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.21454574),
        dec: Angle.Degrees(+57.64792922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236555"},
        {"Hipparcos Number", "HIP 3984"},
        {"Smithsonian Astrophysical Observation", "SAO 21770"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.80838334),
        dec: Angle.Degrees(+57.64831597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132560"},
        {"Hipparcos Number", "HIP 73175"},
        {"Geneva Identification System", "GEN# +1.00132560"},
        {"Smithsonian Astrophysical Observation", "SAO 29354"},
        {"Wilson Evans Batten Catalogue", "WEB 12540"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.33610753),
        dec: Angle.Degrees(+57.64920870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55574"},
        {"Hipparcos Number", "HIP 35235"},
        {"Geneva Identification System", "GEN# +1.00055574"},
        {"Smithsonian Astrophysical Observation", "SAO 26254"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.22653900),
        dec: Angle.Degrees(+57.65136123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190397"},
        {"Hipparcos Number", "HIP 98611"},
        {"Celescope Catalog", "CEL 4919"},
        {"Geneva Identification System", "GEN# +1.00190397"},
        {"Smithsonian Astrophysical Observation", "SAO 32219"},
    },
    visualMagnitude: 7.71,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.43972923),
        dec: Angle.Degrees(+57.65179296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90469"},
        {"Hipparcos Number", "HIP 51253"},
        {"Smithsonian Astrophysical Observation", "SAO 27654"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.04003130),
        dec: Angle.Degrees(+57.65313677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238047"},
        {"Hipparcos Number", "HIP 57773"},
        {"Geneva Identification System", "GEN# +1.00238047"},
        {"Smithsonian Astrophysical Observation", "SAO 28159"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.71064403),
        dec: Angle.Degrees(+57.65483880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134607"},
        {"Hipparcos Number", "HIP 74074"},
        {"Fundamental Katalog 5th Edition", "FK5 5344"},
        {"Smithsonian Astrophysical Observation", "SAO 29421"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.06297082),
        dec: Angle.Degrees(+57.65708717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209124"},
        {"Hipparcos Number", "HIP 108553"},
        {"Celescope Catalog", "CEL 5417"},
        {"Geneva Identification System", "GEN# +1.00209124"},
        {"Smithsonian Astrophysical Observation", "SAO 33943"},
        {"Wilson Evans Batten Catalogue", "WEB 19542"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.84526264),
        dec: Angle.Degrees(+57.65854796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1535"},
        {"Hipparcos Number", "HIP 1586"},
        {"Smithsonian Astrophysical Observation", "SAO 21302"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.95886254),
        dec: Angle.Degrees(+57.65975532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110923",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15972 I"},
        {"Henry Draper", "HD 213209"},
        {"Hipparcos Number", "HIP 110923"},
        {"Geneva Identification System", "GEN# +1.00213209"},
        {"Smithsonian Astrophysical Observation", "SAO 34489"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.09997290),
        dec: Angle.Degrees(+57.66184664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18391"},
        {"Hipparcos Number", "HIP 13962"},
        {"Geneva Identification System", "GEN# +1.00018391"},
        {"Smithsonian Astrophysical Observation", "SAO 23749"},
        {"Wilson Evans Batten Catalogue", "WEB 2755"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.916,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.95300978),
        dec: Angle.Degrees(+57.66324613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239829"},
        {"Hipparcos Number", "HIP 108749"},
        {"Smithsonian Astrophysical Observation", "SAO 33986"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.44268265),
        dec: Angle.Degrees(+57.66381303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80423"},
        {"Hipparcos Number", "HIP 45933"},
        {"Smithsonian Astrophysical Observation", "SAO 27221"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.48861208),
        dec: Angle.Degrees(+57.66517891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1965"},
        {"Hipparcos Number", "HIP 1930"},
        {"Smithsonian Astrophysical Observation", "SAO 21367"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.08179212),
        dec: Angle.Degrees(+57.66688543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224624"},
        {"Hipparcos Number", "HIP 118276"},
        {"Celescope Catalog", "CEL 5737"},
        {"Geneva Identification System", "GEN# +1.00224624"},
        {"Smithsonian Astrophysical Observation", "SAO 35959"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.86615635),
        dec: Angle.Degrees(+57.67094612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180161"},
        {"Hipparcos Number", "HIP 94346"},
        {"Cincinnati Publication", "Ci 20 1139"},
        {"Geneva Identification System", "GEN# +1.00180161"},
        {"Smithsonian Astrophysical Observation", "SAO 31474"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.804,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.04633448),
        dec: Angle.Degrees(+57.67098903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 217.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 408.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21248"},
        {"Hipparcos Number", "HIP 16185"},
        {"Geneva Identification System", "GEN# +1.00021248"},
        {"Smithsonian Astrophysical Observation", "SAO 24051"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.12271146),
        dec: Angle.Degrees(+57.67177096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17145"},
        {"Hipparcos Number", "HIP 13022"},
        {"Geneva Identification System", "GEN# +1.00017145"},
        {"Smithsonian Astrophysical Observation", "SAO 23607"},
        {"Wilson Evans Batten Catalogue", "WEB 2628"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.85102991),
        dec: Angle.Degrees(+57.67711202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111093"},
        {"Hipparcos Number", "HIP 62317"},
        {"Smithsonian Astrophysical Observation", "SAO 28510"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.55929778),
        dec: Angle.Degrees(+57.67839685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14956"},
        {"Hipparcos Number", "HIP 11391"},
        {"Geneva Identification System", "GEN# +1.00014956"},
        {"Smithsonian Astrophysical Observation", "SAO 23335"},
        {"Wilson Evans Batten Catalogue", "WEB 2377"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.69039903),
        dec: Angle.Degrees(+57.67918262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85472"},
        {"Hipparcos Number", "HIP 48537"},
        {"Geneva Identification System", "GEN# +1.00085472"},
        {"Smithsonian Astrophysical Observation", "SAO 27421"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.798,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.49131598),
        dec: Angle.Degrees(+57.68393090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22297"},
        {"Hipparcos Number", "HIP 16976"},
        {"Smithsonian Astrophysical Observation", "SAO 24132"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.58327662),
        dec: Angle.Degrees(+57.68630655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112623"},
        {"Hipparcos Number", "HIP 63222"},
        {"Smithsonian Astrophysical Observation", "SAO 28578"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.31704902),
        dec: Angle.Degrees(+57.69171393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239960"},
        {"Hipparcos Number", "HIP 110893"},
        {"Cincinnati Publication", "Ci 20 1366"},
        {"Cincinnati Publication 2", "Ci 18 2922"},
        {"Geneva Identification System", "GEN# +0.05602783"},
        {"Wilson Evans Batten Catalogue", "WEB 19855"},
    },
    visualMagnitude: 9.59,
    bvColour: 1.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.00174003),
        dec: Angle.Degrees(+57.69702005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -870.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -471.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11769",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1911 A"},
        {"Henry Draper", "HD 15497"},
        {"Hipparcos Number", "HIP 11769"},
        {"Geneva Identification System", "GEN# +1.00015497J"},
        {"Smithsonian Astrophysical Observation", "SAO 23403"},
        {"Wilson Evans Batten Catalogue", "WEB 2441"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.97240216),
        dec: Angle.Degrees(+57.69764407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3374",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 592 AB"},
        {"Henry Draper", "HD 236505"},
        {"Hipparcos Number", "HIP 3374"},
        {"Smithsonian Astrophysical Observation", "SAO 21648"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.72377995),
        dec: Angle.Degrees(+57.69971381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54269"},
        {"Hipparcos Number", "HIP 34750"},
        {"Geneva Identification System", "GEN# +1.00054269"},
        {"Smithsonian Astrophysical Observation", "SAO 26200"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.91149759),
        dec: Angle.Degrees(+57.70014817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53209",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7957 AB"},
        {"Henry Draper", "HD 237944"},
        {"Hipparcos Number", "HIP 53209"},
        {"Smithsonian Astrophysical Observation", "SAO 27812"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.25433955),
        dec: Angle.Degrees(+57.70219181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180610"},
        {"Hipparcos Number", "HIP 94490"},
        {"Geneva Identification System", "GEN# +1.00180610"},
        {"Smithsonian Astrophysical Observation", "SAO 31497"},
        {"Wilson Evans Batten Catalogue", "WEB 16471"},
    },
    visualMagnitude: 5.00,
    bvColour: 1.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.47985288),
        dec: Angle.Degrees(+57.70525514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21884",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21884"},
    },
    visualMagnitude: 11.37,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.56710257),
        dec: Angle.Degrees(+57.70882819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -531.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237640"},
        {"Hipparcos Number", "HIP 38136"},
        {"Smithsonian Astrophysical Observation", "SAO 26518"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.23292821),
        dec: Angle.Degrees(+57.70976409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211320"},
        {"Hipparcos Number", "HIP 109841"},
        {"Geneva Identification System", "GEN# +1.00211320"},
        {"Smithsonian Astrophysical Observation", "SAO 34223"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.69890379),
        dec: Angle.Degrees(+57.71068189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 113.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12867"},
        {"Hipparcos Number", "HIP 9936"},
        {"Geneva Identification System", "GEN# +1.00012867"},
        {"Smithsonian Astrophysical Observation", "SAO 22949"},
        {"Wilson Evans Batten Catalogue", "WEB 2084"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.97370753),
        dec: Angle.Degrees(+57.71263774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129425"},
        {"Hipparcos Number", "HIP 71718"},
        {"Geneva Identification System", "GEN# +1.00129425"},
        {"Smithsonian Astrophysical Observation", "SAO 29239"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.04444435),
        dec: Angle.Degrees(+57.71315429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25226"},
        {"Hipparcos Number", "HIP 18932"},
        {"Smithsonian Astrophysical Observation", "SAO 24374"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.87054660),
        dec: Angle.Degrees(+57.71360398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112915",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16326 AB"},
        {"Henry Draper", "HD 216448"},
        {"Hipparcos Number", "HIP 112915"},
        {"Geneva Identification System", "GEN# +1.00216448"},
        {"Smithsonian Astrophysical Observation", "SAO 34895"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.00272477),
        dec: Angle.Degrees(+57.71744423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -219.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16012"},
        {"Hipparcos Number", "HIP 12150"},
        {"Celescope Catalog", "CEL 288"},
        {"Geneva Identification System", "GEN# +1.00016012"},
        {"Smithsonian Astrophysical Observation", "SAO 23461"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.14827937),
        dec: Angle.Degrees(+57.72063257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236737"},
        {"Hipparcos Number", "HIP 6775"},
        {"Smithsonian Astrophysical Observation", "SAO 22283"},
        {"Wilson Evans Batten Catalogue", "WEB 1479"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.77461690),
        dec: Angle.Degrees(+57.72181397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238305"},
        {"Hipparcos Number", "HIP 68230"},
        {"Smithsonian Astrophysical Observation", "SAO 28950"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.51467153),
        dec: Angle.Degrees(+57.72706770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15964"},
        {"Hipparcos Number", "HIP 12127"},
        {"Geneva Identification System", "GEN# +1.00015964"},
        {"Smithsonian Astrophysical Observation", "SAO 23454"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.05658183),
        dec: Angle.Degrees(+57.72809681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111840"},
        {"Hipparcos Number", "HIP 62738"},
        {"Smithsonian Astrophysical Observation", "SAO 28538"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.83161343),
        dec: Angle.Degrees(+57.73162959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236507"},
        {"Hipparcos Number", "HIP 3388"},
        {"Smithsonian Astrophysical Observation", "SAO 21652"},
    },
    visualMagnitude: 9.76,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.76834351),
        dec: Angle.Degrees(+57.73337493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17088"},
        {"Hipparcos Number", "HIP 12972"},
        {"Geneva Identification System", "GEN# +1.00017088"},
        {"Smithsonian Astrophysical Observation", "SAO 23601"},
        {"Wilson Evans Batten Catalogue", "WEB 2624"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.71437660),
        dec: Angle.Degrees(+57.73380274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206773"},
        {"Hipparcos Number", "HIP 107164"},
        {"Celescope Catalog", "CEL 5372"},
        {"Geneva Identification System", "GEN# +4.35370750"},
        {"Smithsonian Astrophysical Observation", "SAO 33677"},
        {"Wilson Evans Batten Catalogue", "WEB 19357"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.60078011),
        dec: Angle.Degrees(+57.73606495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207049"},
        {"Hipparcos Number", "HIP 107330"},
        {"Smithsonian Astrophysical Observation", "SAO 33710"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.08965945),
        dec: Angle.Degrees(+57.73731503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69548"},
        {"Hipparcos Number", "HIP 40875"},
        {"Geneva Identification System", "GEN# +1.00069548"},
        {"Smithsonian Astrophysical Observation", "SAO 26784"},
        {"Wilson Evans Batten Catalogue", "WEB 7926"},
    },
    visualMagnitude: 5.89,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.10832165),
        dec: Angle.Degrees(+57.74324466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236875"},
        {"Hipparcos Number", "HIP 8313"},
        {"Smithsonian Astrophysical Observation", "SAO 22617"},
        {"Wilson Evans Batten Catalogue", "WEB 1771"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.80304985),
        dec: Angle.Degrees(+57.74497660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237249"},
        {"Hipparcos Number", "HIP 20353"},
        {"Smithsonian Astrophysical Observation", "SAO 24559"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.38796076),
        dec: Angle.Degrees(+57.74512664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188167"},
        {"Hipparcos Number", "HIP 97653"},
        {"Smithsonian Astrophysical Observation", "SAO 32052"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.69955113),
        dec: Angle.Degrees(+57.74619205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137703"},
        {"Hipparcos Number", "HIP 75431"},
        {"Geneva Identification System", "GEN# +1.00137703"},
        {"Smithsonian Astrophysical Observation", "SAO 29518"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.16325255),
        dec: Angle.Degrees(+57.74941391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239367"},
        {"Hipparcos Number", "HIP 99908"},
        {"Smithsonian Astrophysical Observation", "SAO 32420"},
    },
    visualMagnitude: 9.60,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.06370950),
        dec: Angle.Degrees(+57.75027260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134209"},
        {"Hipparcos Number", "HIP 73882"},
        {"Smithsonian Astrophysical Observation", "SAO 29406"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.51071663),
        dec: Angle.Degrees(+57.75138064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 81.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7260",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7260"},
        {"Wilson Evans Batten Catalogue", "WEB 1563"},
    },
    visualMagnitude: 9.59,
    bvColour: 2.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.38622078),
        dec: Angle.Degrees(+57.75151517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237340"},
        {"Hipparcos Number", "HIP 23471"},
        {"Smithsonian Astrophysical Observation", "SAO 24966"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.68467733),
        dec: Angle.Degrees(+57.75326079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238419"},
        {"Hipparcos Number", "HIP 73468"},
        {"Smithsonian Astrophysical Observation", "SAO 29382"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.22972112),
        dec: Angle.Degrees(+57.75353944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6417"},
        {"Hipparcos Number", "HIP 5161"},
        {"Celescope Catalog", "CEL 117"},
        {"Geneva Identification System", "GEN# +1.00006417"},
        {"Smithsonian Astrophysical Observation", "SAO 22000"},
        {"Wilson Evans Batten Catalogue", "WEB 1076"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.51646851),
        dec: Angle.Degrees(+57.75648184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197639"},
        {"Hipparcos Number", "HIP 102187"},
        {"Smithsonian Astrophysical Observation", "SAO 32815"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.57877783),
        dec: Angle.Degrees(+57.75786537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222886"},
        {"Hipparcos Number", "HIP 117104"},
        {"Smithsonian Astrophysical Observation", "SAO 35723"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.10231179),
        dec: Angle.Degrees(+57.75903411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7548",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7548"},
        {"Geneva Identification System", "GEN# +0.05700342"},
        {"Wilson Evans Batten Catalogue", "WEB 1613"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.30841902),
        dec: Angle.Degrees(+57.75922285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13716"},
        {"Hipparcos Number", "HIP 10527"},
        {"Celescope Catalog", "CEL 231"},
        {"Geneva Identification System", "GEN# +1.00013716"},
        {"Smithsonian Astrophysical Observation", "SAO 23094"},
        {"Wilson Evans Batten Catalogue", "WEB 2210"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.91419900),
        dec: Angle.Degrees(+57.76332247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80934",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10109 AB"},
        {"Henry Draper", "HD 149430"},
        {"Hipparcos Number", "HIP 80934"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.90341145),
        dec: Angle.Degrees(+57.76418991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236600"},
        {"Hipparcos Number", "HIP 4813"},
        {"Smithsonian Astrophysical Observation", "SAO 21932"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.44504696),
        dec: Angle.Degrees(+57.76476909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200593"},
        {"Hipparcos Number", "HIP 103790"},
        {"Smithsonian Astrophysical Observation", "SAO 33076"},
    },
    visualMagnitude: 7.19,
    bvColour: -0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.47863107),
        dec: Angle.Degrees(+57.76529136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182440"},
        {"Hipparcos Number", "HIP 95143"},
        {"Smithsonian Astrophysical Observation", "SAO 31604"},
        {"Wilson Evans Batten Catalogue", "WEB 16616"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.35570263),
        dec: Angle.Degrees(+57.76670954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23476"},
        {"Hipparcos Number", "HIP 17790"},
        {"Geneva Identification System", "GEN# +1.00023476"},
        {"Smithsonian Astrophysical Observation", "SAO 24229"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.12467310),
        dec: Angle.Degrees(+57.76762299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48389"},
        {"Hipparcos Number", "HIP 32470"},
        {"Geneva Identification System", "GEN# +1.00048389"},
        {"Smithsonian Astrophysical Observation", "SAO 25945"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.65685938),
        dec: Angle.Degrees(+57.76911576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -154.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185239"},
        {"Hipparcos Number", "HIP 96306"},
        {"Geneva Identification System", "GEN# +1.00185239"},
        {"Smithsonian Astrophysical Observation", "SAO 31794"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.71632941),
        dec: Angle.Degrees(+57.77257197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217475"},
        {"Hipparcos Number", "HIP 113557"},
        {"Geneva Identification System", "GEN# +1.00217475"},
        {"Smithsonian Astrophysical Observation", "SAO 35037"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.00405991),
        dec: Angle.Degrees(+57.77289102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66138"},
        {"Hipparcos Number", "HIP 39572"},
        {"Geneva Identification System", "GEN# +1.00066138"},
        {"Smithsonian Astrophysical Observation", "SAO 26658"},
        {"Wilson Evans Batten Catalogue", "WEB 7735"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.29371081),
        dec: Angle.Degrees(+57.77325406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42527"},
        {"Hipparcos Number", "HIP 29639"},
        {"Smithsonian Astrophysical Observation", "SAO 25633"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.69249069),
        dec: Angle.Degrees(+57.77470031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150116"},
        {"Hipparcos Number", "HIP 81248"},
        {"Smithsonian Astrophysical Observation", "SAO 30011"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.92180949),
        dec: Angle.Degrees(+57.78120016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107949"},
        {"Hipparcos Number", "HIP 60484"},
        {"Smithsonian Astrophysical Observation", "SAO 28365"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.99468867),
        dec: Angle.Degrees(+57.78416222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26793",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26793"},
    },
    visualMagnitude: 9.98,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.35879092),
        dec: Angle.Degrees(+57.78976179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238685"},
        {"Hipparcos Number", "HIP 85166"},
        {"Smithsonian Astrophysical Observation", "SAO 30373"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.06819318),
        dec: Angle.Degrees(+57.79171123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107480",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15318 A"},
        {"Hipparcos Number", "HIP 107480"},
        {"Geneva Identification System", "GEN# +4.35370778"},
        {"Smithsonian Astrophysical Observation", "SAO 33737"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.54610716),
        dec: Angle.Degrees(+57.79270142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146326"},
        {"Hipparcos Number", "HIP 79426"},
        {"Smithsonian Astrophysical Observation", "SAO 29843"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.14637383),
        dec: Angle.Degrees(+57.79500657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239451"},
        {"Hipparcos Number", "HIP 101458"},
        {"Smithsonian Astrophysical Observation", "SAO 32701"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.43667972),
        dec: Angle.Degrees(+57.79761043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107481",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15318 B"},
        {"Hipparcos Number", "HIP 107481"},
        {"Geneva Identification System", "GEN# +4.35370779"},
        {"Smithsonian Astrophysical Observation", "SAO 33738"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.54852485),
        dec: Angle.Degrees(+57.79803730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191609"},
        {"Hipparcos Number", "HIP 99152"},
        {"Celescope Catalog", "CEL 4944"},
        {"Geneva Identification System", "GEN# +1.00191609"},
        {"Smithsonian Astrophysical Observation", "SAO 32303"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.93958822),
        dec: Angle.Degrees(+57.79995190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106919",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106919"},
        {"Geneva Identification System", "GEN# +4.35370721"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.80867965),
        dec: Angle.Degrees(+57.80133076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57311",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57311"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.26719387),
        dec: Angle.Degrees(+57.80177611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172022"},
        {"Hipparcos Number", "HIP 91052"},
        {"Geneva Identification System", "GEN# +1.00172022"},
        {"Smithsonian Astrophysical Observation", "SAO 31058"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.60965126),
        dec: Angle.Degrees(+57.80183514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237421"},
        {"Hipparcos Number", "HIP 27350"},
        {"Smithsonian Astrophysical Observation", "SAO 25374"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.89172368),
        dec: Angle.Degrees(+57.80198707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7733"},
        {"Hipparcos Number", "HIP 6093"},
        {"Smithsonian Astrophysical Observation", "SAO 22165"},
    },
    visualMagnitude: 6.39,
    bvColour: 1.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.55788373),
        dec: Angle.Degrees(+57.80316871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16843"},
        {"Hipparcos Number", "HIP 12791"},
        {"Smithsonian Astrophysical Observation", "SAO 23575"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.09884266),
        dec: Angle.Degrees(+57.80319641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239305"},
        {"Hipparcos Number", "HIP 98748"},
        {"Smithsonian Astrophysical Observation", "SAO 32245"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.884,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.85776791),
        dec: Angle.Degrees(+57.80789559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189818"},
        {"Hipparcos Number", "HIP 98360"},
        {"Celescope Catalog", "CEL 4900"},
        {"Geneva Identification System", "GEN# +1.00189818"},
        {"Smithsonian Astrophysical Observation", "SAO 32173"},
        {"Wilson Evans Batten Catalogue", "WEB 17355"},
    },
    visualMagnitude: 7.32,
    bvColour: -0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.75668605),
        dec: Angle.Degrees(+57.80948015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16494"},
        {"Hipparcos Number", "HIP 12513"},
        {"Smithsonian Astrophysical Observation", "SAO 23521"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.26022237),
        dec: Angle.Degrees(+57.81082059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236677"},
        {"Hipparcos Number", "HIP 5904"},
        {"Smithsonian Astrophysical Observation", "SAO 22135"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.96269556),
        dec: Angle.Degrees(+57.81212371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237867"},
        {"Hipparcos Number", "HIP 49715"},
        {"Smithsonian Astrophysical Observation", "SAO 27533"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.853,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.25591654),
        dec: Angle.Degrees(+57.81214899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177326"},
        {"Hipparcos Number", "HIP 93347"},
        {"Geneva Identification System", "GEN# +1.00177326"},
        {"Smithsonian Astrophysical Observation", "SAO 31327"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.20120143),
        dec: Angle.Degrees(+57.81298098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152152"},
        {"Hipparcos Number", "HIP 82249"},
        {"Smithsonian Astrophysical Observation", "SAO 30107"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.06934713),
        dec: Angle.Degrees(+57.81370935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240426"},
        {"Hipparcos Number", "HIP 117633"},
        {"Smithsonian Astrophysical Observation", "SAO 35842"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.84326731),
        dec: Angle.Degrees(+57.81404449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176408"},
        {"Hipparcos Number", "HIP 92997"},
        {"Fundamental Katalog 5th Edition", "FK5 3513"},
        {"Geneva Identification System", "GEN# +1.00176408"},
        {"Smithsonian Astrophysical Observation", "SAO 31284"},
        {"Wilson Evans Batten Catalogue", "WEB 16106"},
    },
    visualMagnitude: 5.67,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.18783092),
        dec: Angle.Degrees(+57.81499531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239683"},
        {"Hipparcos Number", "HIP 106134"},
        {"Geneva Identification System", "GEN# +4.35370677"},
        {"Smithsonian Astrophysical Observation", "SAO 33474"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.47277728),
        dec: Angle.Degrees(+57.81588664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14026"},
        {"Hipparcos Number", "HIP 10751"},
        {"Geneva Identification System", "GEN# +1.00014026"},
        {"Smithsonian Astrophysical Observation", "SAO 23154"},
        {"Wilson Evans Batten Catalogue", "WEB 2265"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.57700135),
        dec: Angle.Degrees(+57.81593758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3821",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Achird"},
        {"Aitken", "ADS 671 A"},
        {"Henry Draper", "HD 4614"},
        {"Henry Draper 2", "HD 4614A"},
        {"Hipparcos Number", "HIP 3821"},
        {"Cincinnati Publication", "Ci 20 56"},
        {"Geneva Identification System", "GEN# +1.00004614A"},
        {"Smithsonian Astrophysical Observation", "SAO 21732"},
        {"Wilson Evans Batten Catalogue", "WEB 675"},
    },
    visualMagnitude: 3.46,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.27125262),
        dec: Angle.Degrees(+57.81654770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1087.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -559.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5944"},
        {"Hipparcos Number", "HIP 4811"},
        {"Geneva Identification System", "GEN# +1.00005944"},
        {"Smithsonian Astrophysical Observation", "SAO 21931"},
        {"Wilson Evans Batten Catalogue", "WEB 917"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.44081197),
        dec: Angle.Degrees(+57.81670190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158653"},
        {"Hipparcos Number", "HIP 85394"},
        {"Smithsonian Astrophysical Observation", "SAO 30396"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.75116357),
        dec: Angle.Degrees(+57.81678648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16243"},
        {"Hipparcos Number", "HIP 12322"},
        {"Geneva Identification System", "GEN# +1.00016243"},
        {"Smithsonian Astrophysical Observation", "SAO 23488"},
        {"Wilson Evans Batten Catalogue", "WEB 2525"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.65867164),
        dec: Angle.Degrees(+57.81699044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167738"},
        {"Hipparcos Number", "HIP 89287"},
        {"Smithsonian Astrophysical Observation", "SAO 30824"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.28878726),
        dec: Angle.Degrees(+57.81768411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173700"},
        {"Hipparcos Number", "HIP 91823"},
        {"Geneva Identification System", "GEN# +1.00173700"},
        {"Smithsonian Astrophysical Observation", "SAO 31134"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.82540746),
        dec: Angle.Degrees(+57.81868405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15316"},
        {"Hipparcos Number", "HIP 11625"},
        {"Fundamental Katalog 5th Edition", "FK5 4231"},
        {"Geneva Identification System", "GEN# +1.00015316"},
        {"Smithsonian Astrophysical Observation", "SAO 23374"},
        {"Wilson Evans Batten Catalogue", "WEB 2422"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.49398821),
        dec: Angle.Degrees(+57.82071533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22694",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22694"},
    },
    visualMagnitude: 10.16,
    bvColour: 1.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.19343591),
        dec: Angle.Degrees(+57.82072768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115677"},
        {"Hipparcos Number", "HIP 64842"},
        {"Geneva Identification System", "GEN# +1.00115677"},
        {"Smithsonian Astrophysical Observation", "SAO 28707"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.38227374),
        dec: Angle.Degrees(+57.82178312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8834"},
        {"Hipparcos Number", "HIP 6871"},
        {"Smithsonian Astrophysical Observation", "SAO 22302"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.10668423),
        dec: Angle.Degrees(+57.82203773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210643"},
        {"Hipparcos Number", "HIP 109425"},
        {"Geneva Identification System", "GEN# +1.00210643"},
        {"Smithsonian Astrophysical Observation", "SAO 34127"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.54370862),
        dec: Angle.Degrees(+57.82221397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39878",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6604 AB"},
        {"Henry Draper", "HD 66976"},
        {"Hipparcos Number", "HIP 39878"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.18371851),
        dec: Angle.Degrees(+57.82928309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31358",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31358"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.63517351),
        dec: Angle.Degrees(+57.82958599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 180.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219288"},
        {"Hipparcos Number", "HIP 114680"},
        {"Geneva Identification System", "GEN# +1.00219288"},
        {"Smithsonian Astrophysical Observation", "SAO 35244"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.47573033),
        dec: Angle.Degrees(+57.83694894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237185"},
        {"Hipparcos Number", "HIP 18042"},
        {"Smithsonian Astrophysical Observation", "SAO 24260"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.84380837),
        dec: Angle.Degrees(+57.83824608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222514"},
        {"Hipparcos Number", "HIP 116843"},
        {"Geneva Identification System", "GEN# +1.00222514"},
        {"Renson", "Renson 61010"},
        {"Smithsonian Astrophysical Observation", "SAO 35665"},
        {"Wilson Evans Batten Catalogue", "WEB 20614"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.25339408),
        dec: Angle.Degrees(+57.83874428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149412"},
        {"Hipparcos Number", "HIP 80906"},
        {"Geneva Identification System", "GEN# +1.00149412"},
        {"Smithsonian Astrophysical Observation", "SAO 29975"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.83368276),
        dec: Angle.Degrees(+57.83903984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81238",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81238"},
        {"Wilson Evans Batten Catalogue", "WEB 13731"},
    },
    visualMagnitude: 11.83,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.88171060),
        dec: Angle.Degrees(+57.83979123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174879"},
        {"Hipparcos Number", "HIP 92369"},
        {"Smithsonian Astrophysical Observation", "SAO 31187"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.36525280),
        dec: Angle.Degrees(+57.83987440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110662",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15927 AB"},
        {"Hipparcos Number", "HIP 110662"},
        {"Geneva Identification System", "GEN# +0.05702525J"},
        {"Smithsonian Astrophysical Observation", "SAO 34427"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.26527001),
        dec: Angle.Degrees(+57.84159517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14434",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14434"},
        {"Geneva Identification System", "GEN# +0.05700687"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.916,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.57261692),
        dec: Angle.Degrees(+57.84432941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40828"},
        {"Hipparcos Number", "HIP 28804"},
        {"Smithsonian Astrophysical Observation", "SAO 25550"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.22333796),
        dec: Angle.Degrees(+57.84436056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14646"},
        {"Hipparcos Number", "HIP 11175"},
        {"Geneva Identification System", "GEN# +1.00014646"},
        {"Smithsonian Astrophysical Observation", "SAO 23282"},
        {"Wilson Evans Batten Catalogue", "WEB 2345"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.97112143),
        dec: Angle.Degrees(+57.84867346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238126"},
        {"Hipparcos Number", "HIP 61013"},
    },
    visualMagnitude: 10.33,
    bvColour: 0.936,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.56280349),
        dec: Angle.Degrees(+57.84981266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19488",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19488"},
        {"Geneva Identification System", "GEN# +0.05700778"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.745,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.61939728),
        dec: Angle.Degrees(+57.85135587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171910"},
        {"Hipparcos Number", "HIP 91005"},
        {"Smithsonian Astrophysical Observation", "SAO 31053"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.47367835),
        dec: Angle.Degrees(+57.85154670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207620"},
        {"Hipparcos Number", "HIP 107660"},
        {"Smithsonian Astrophysical Observation", "SAO 33774"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.10551552),
        dec: Angle.Degrees(+57.85451026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115562",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115562"},
        {"Geneva Identification System", "GEN# +0.05702735"},
        {"Wilson Evans Batten Catalogue", "WEB 20456"},
    },
    visualMagnitude: 10.03,
    bvColour: 1.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.12742531),
        dec: Angle.Degrees(+57.85499554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -282.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237010"},
        {"Hipparcos Number", "HIP 13290"},
        {"Geneva Identification System", "GEN# +0.05700647"},
    },
    visualMagnitude: 9.01,
    bvColour: 2.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.76644677),
        dec: Angle.Degrees(+57.85553713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238441"},
        {"Hipparcos Number", "HIP 74767"},
        {"Smithsonian Astrophysical Observation", "SAO 29468"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.20932082),
        dec: Angle.Degrees(+57.85555807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161161"},
        {"Hipparcos Number", "HIP 86493"},
        {"Smithsonian Astrophysical Observation", "SAO 30514"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.12834057),
        dec: Angle.Degrees(+57.85761117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36317"},
        {"Hipparcos Number", "HIP 26147"},
        {"Smithsonian Astrophysical Observation", "SAO 25258"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.61826606),
        dec: Angle.Degrees(+57.85943385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26755"},
        {"Hipparcos Number", "HIP 19983"},
        {"Geneva Identification System", "GEN# +1.00026755"},
        {"Smithsonian Astrophysical Observation", "SAO 24514"},
        {"Wilson Evans Batten Catalogue", "WEB 3811"},
    },
    visualMagnitude: 5.72,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.28363443),
        dec: Angle.Degrees(+57.86047655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156205"},
        {"Hipparcos Number", "HIP 84213"},
        {"Smithsonian Astrophysical Observation", "SAO 30298"},
        {"Wilson Evans Batten Catalogue", "WEB 14220"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.21792423),
        dec: Angle.Degrees(+57.86261020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14404"},
        {"Hipparcos Number", "HIP 10995"},
        {"Geneva Identification System", "GEN# +1.00014404"},
        {"Smithsonian Astrophysical Observation", "SAO 23234"},
        {"Wilson Evans Batten Catalogue", "WEB 2308"},
    },
    visualMagnitude: 7.78,
    bvColour: 2.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.42671019),
        dec: Angle.Degrees(+57.86282116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83285"},
        {"Hipparcos Number", "HIP 47390"},
        {"Smithsonian Astrophysical Observation", "SAO 27328"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.83767043),
        dec: Angle.Degrees(+57.86301088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107465"},
        {"Hipparcos Number", "HIP 60212"},
        {"Geneva Identification System", "GEN# +1.00107465"},
        {"Smithsonian Astrophysical Observation", "SAO 28346"},
        {"Wilson Evans Batten Catalogue", "WEB 10708"},
    },
    visualMagnitude: 5.54,
    bvColour: 1.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.21179250),
        dec: Angle.Degrees(+57.86428953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91854"},
        {"Hipparcos Number", "HIP 52019"},
        {"Smithsonian Astrophysical Observation", "SAO 27713"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.788,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.41602527),
        dec: Angle.Degrees(+57.86503777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173605"},
        {"Hipparcos Number", "HIP 91773"},
        {"Geneva Identification System", "GEN# +1.00173605"},
        {"Smithsonian Astrophysical Observation", "SAO 31123"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.70548417),
        dec: Angle.Degrees(+57.86517463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 124.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126659"},
        {"Hipparcos Number", "HIP 70476"},
        {"Smithsonian Astrophysical Observation", "SAO 29135"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.23365610),
        dec: Angle.Degrees(+57.86696419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11866"},
        {"Hipparcos Number", "HIP 9190"},
        {"Geneva Identification System", "GEN# +1.00011866"},
        {"Smithsonian Astrophysical Observation", "SAO 22799"},
        {"Wilson Evans Batten Catalogue", "WEB 1932"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.58297264),
        dec: Angle.Degrees(+57.86754613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21794"},
        {"Hipparcos Number", "HIP 16602"},
        {"Fundamental Katalog 5th Edition", "FK5 2252"},
        {"Geneva Identification System", "GEN# +1.00021794"},
        {"Smithsonian Astrophysical Observation", "SAO 24098"},
        {"Wilson Evans Batten Catalogue", "WEB 3167"},
    },
    visualMagnitude: 6.37,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.42180546),
        dec: Angle.Degrees(+57.86863580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237860"},
        {"Hipparcos Number", "HIP 49227"},
        {"Smithsonian Astrophysical Observation", "SAO 27489"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.73269669),
        dec: Angle.Degrees(+57.86878230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23152"},
        {"Hipparcos Number", "HIP 17570"},
        {"Smithsonian Astrophysical Observation", "SAO 24191"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.44429081),
        dec: Angle.Degrees(+57.87040586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 122.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103681"},
        {"Hipparcos Number", "HIP 58225"},
        {"Geneva Identification System", "GEN# +1.00103681"},
        {"Smithsonian Astrophysical Observation", "SAO 28194"},
        {"Wilson Evans Batten Catalogue", "WEB 10421"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.12597236),
        dec: Angle.Degrees(+57.87159400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236628"},
        {"Hipparcos Number", "HIP 5255"},
        {"Smithsonian Astrophysical Observation", "SAO 22018"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.764,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.79533307),
        dec: Angle.Degrees(+57.87210426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -141.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20524"},
        {"Hipparcos Number", "HIP 15596"},
        {"Smithsonian Astrophysical Observation", "SAO 23967"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.21431489),
        dec: Angle.Degrees(+57.87467879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96708"},
        {"Hipparcos Number", "HIP 54517"},
        {"Geneva Identification System", "GEN# +1.00096708"},
        {"Smithsonian Astrophysical Observation", "SAO 27928"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.31434874),
        dec: Angle.Degrees(+57.87638438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159330"},
        {"Hipparcos Number", "HIP 85692"},
        {"Smithsonian Astrophysical Observation", "SAO 30434"},
        {"Wilson Evans Batten Catalogue", "WEB 14461"},
    },
    visualMagnitude: 6.22,
    bvColour: 1.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.68150060),
        dec: Angle.Degrees(+57.87685725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29371"},
        {"Hipparcos Number", "HIP 21790"},
        {"Renson", "Renson 7500"},
        {"Smithsonian Astrophysical Observation", "SAO 24751"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.20639137),
        dec: Angle.Degrees(+57.87964058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237557"},
        {"Hipparcos Number", "HIP 33199"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.64975668),
        dec: Angle.Degrees(+57.88270722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119963"},
        {"Hipparcos Number", "HIP 67085"},
        {"Smithsonian Astrophysical Observation", "SAO 28876"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.24811820),
        dec: Angle.Degrees(+57.88497049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239932"},
        {"Hipparcos Number", "HIP 110414"},
        {"Geneva Identification System", "GEN# +1.00239932"},
        {"Smithsonian Astrophysical Observation", "SAO 34362"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.48618290),
        dec: Angle.Degrees(+57.88642996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238236"},
        {"Hipparcos Number", "HIP 65638"},
        {"Smithsonian Astrophysical Observation", "SAO 28760"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.85482381),
        dec: Angle.Degrees(+57.88782583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238663"},
        {"Hipparcos Number", "HIP 84081"},
        {"Smithsonian Astrophysical Observation", "SAO 30288"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.84309840),
        dec: Angle.Degrees(+57.88802439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168760"},
        {"Hipparcos Number", "HIP 89670"},
        {"Smithsonian Astrophysical Observation", "SAO 30878"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.48223239),
        dec: Angle.Degrees(+57.89088242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144977"},
        {"Hipparcos Number", "HIP 78818"},
        {"Smithsonian Astrophysical Observation", "SAO 29793"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.35453611),
        dec: Angle.Degrees(+57.89097057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239560"},
        {"Hipparcos Number", "HIP 103961"},
        {"Smithsonian Astrophysical Observation", "SAO 33103"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.96324826),
        dec: Angle.Degrees(+57.89169300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77993",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77993"},
    },
    visualMagnitude: 10.51,
    bvColour: 1.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.90726346),
        dec: Angle.Degrees(+57.89187226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50838"},
        {"Hipparcos Number", "HIP 33551"},
        {"Geneva Identification System", "GEN# +1.00050838"},
        {"Smithsonian Astrophysical Observation", "SAO 26069"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.59309311),
        dec: Angle.Degrees(+57.89429865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237888"},
        {"Hipparcos Number", "HIP 50597"},
        {"Smithsonian Astrophysical Observation", "SAO 27604"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.04894557),
        dec: Angle.Degrees(+57.89785706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106265",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15063 AB"},
        {"Henry Draper", "HD 239693"},
        {"Hipparcos Number", "HIP 106265"},
        {"Geneva Identification System", "GEN# +4.35370686J"},
        {"Smithsonian Astrophysical Observation", "SAO 33504"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.85812057),
        dec: Angle.Degrees(+57.89903446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76559",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76559"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.54104045),
        dec: Angle.Degrees(+57.89971426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13982"},
        {"Hipparcos Number", "HIP 10718"},
        {"Fundamental Katalog 5th Edition", "FK5 2157"},
        {"Geneva Identification System", "GEN# +1.00013982"},
        {"Smithsonian Astrophysical Observation", "SAO 23143"},
        {"Wilson Evans Batten Catalogue", "WEB 2259"},
    },
    visualMagnitude: 5.75,
    bvColour: 1.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.49925395),
        dec: Angle.Degrees(+57.89980835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19557"},
        {"Hipparcos Number", "HIP 14827"},
        {"Geneva Identification System", "GEN# +1.00019557"},
        {"Smithsonian Astrophysical Observation", "SAO 23858"},
        {"Wilson Evans Batten Catalogue", "WEB 2862"},
    },
    visualMagnitude: 7.48,
    bvColour: 2.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.85552031),
        dec: Angle.Degrees(+57.90312376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79702"},
        {"Hipparcos Number", "HIP 45628"},
        {"Geneva Identification System", "GEN# +1.00079702"},
        {"Smithsonian Astrophysical Observation", "SAO 27203"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.50570461),
        dec: Angle.Degrees(+57.90557999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221568"},
        {"Hipparcos Number", "HIP 116210"},
        {"Celescope Catalog", "CEL 5628"},
        {"Geneva Identification System", "GEN# +1.00221568"},
        {"Renson", "Renson 60730"},
        {"Smithsonian Astrophysical Observation", "SAO 35532"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.19842881),
        dec: Angle.Degrees(+57.90558497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238278"},
        {"Hipparcos Number", "HIP 67019"},
        {"Smithsonian Astrophysical Observation", "SAO 28872"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.02335001),
        dec: Angle.Degrees(+57.90583775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238224"},
        {"Hipparcos Number", "HIP 65327"},
        {"Geneva Identification System", "GEN# +1.00238224"},
        {"Smithsonian Astrophysical Observation", "SAO 28733"},
        {"Wilson Evans Batten Catalogue", "WEB 11532"},
    },
    visualMagnitude: 9.69,
    bvColour: 1.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.84648954),
        dec: Angle.Degrees(+57.90615850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 127.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29401"},
        {"Hipparcos Number", "HIP 21812"},
        {"Smithsonian Astrophysical Observation", "SAO 24757"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.28203190),
        dec: Angle.Degrees(+57.91210753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47174",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7447 ABC"},
        {"Henry Draper", "HD 237822"},
        {"Hipparcos Number", "HIP 47174"},
        {"Geneva Identification System", "GEN# +1.00237822J"},
        {"Smithsonian Astrophysical Observation", "SAO 27312"},
        {"Wilson Evans Batten Catalogue", "WEB 8873"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.20521918),
        dec: Angle.Degrees(+57.91214244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 248.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -312.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121318"},
        {"Hipparcos Number", "HIP 67792"},
        {"Smithsonian Astrophysical Observation", "SAO 28923"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.31568169),
        dec: Angle.Degrees(+57.91359263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31549"},
        {"Hipparcos Number", "HIP 23257"},
        {"Smithsonian Astrophysical Observation", "SAO 24946"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.06846261),
        dec: Angle.Degrees(+57.91359865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131219"},
        {"Hipparcos Number", "HIP 72554"},
        {"Smithsonian Astrophysical Observation", "SAO 29301"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.49717113),
        dec: Angle.Degrees(+57.91431138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237846"},
        {"Hipparcos Number", "HIP 48444"},
        {"Geneva Identification System", "GEN# +1.00237846"},
        {"Smithsonian Astrophysical Observation", "SAO 27413"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.835,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.16117416),
        dec: Angle.Degrees(+57.91630130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85928"},
        {"Hipparcos Number", "HIP 48788"},
        {"Geneva Identification System", "GEN# +1.00085928"},
        {"Smithsonian Astrophysical Observation", "SAO 27437"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.26644596),
        dec: Angle.Degrees(+57.91729769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47316",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47316"},
        {"Geneva Identification System", "GEN# +9.80195034"},
    },
    visualMagnitude: 11.80,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.62473086),
        dec: Angle.Degrees(+57.92065803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -202.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -195.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170849"},
        {"Hipparcos Number", "HIP 90503"},
        {"Geneva Identification System", "GEN# +1.00170849"},
        {"Smithsonian Astrophysical Observation", "SAO 30994"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.01807204),
        dec: Angle.Degrees(+57.92222291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140117"},
        {"Hipparcos Number", "HIP 76651"},
        {"Geneva Identification System", "GEN# +1.00140117"},
        {"Smithsonian Astrophysical Observation", "SAO 29609"},
        {"Wilson Evans Batten Catalogue", "WEB 13013"},
    },
    visualMagnitude: 6.45,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.78968608),
        dec: Angle.Degrees(+57.92441688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196421"},
        {"Hipparcos Number", "HIP 101530"},
        {"Celescope Catalog", "CEL 5122"},
        {"Geneva Identification System", "GEN# +1.00196421"},
        {"Smithsonian Astrophysical Observation", "SAO 32708"},
        {"Wilson Evans Batten Catalogue", "WEB 18348"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.63907427),
        dec: Angle.Degrees(+57.92791462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15620"},
        {"Hipparcos Number", "HIP 11841"},
        {"Geneva Identification System", "GEN# +1.00015620"},
        {"Smithsonian Astrophysical Observation", "SAO 23414"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.791,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.22032045),
        dec: Angle.Degrees(+57.92935144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52068"},
        {"Hipparcos Number", "HIP 33996"},
        {"Smithsonian Astrophysical Observation", "SAO 26116"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.80919312),
        dec: Angle.Degrees(+57.93000300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12993"},
        {"Hipparcos Number", "HIP 10024"},
        {"Celescope Catalog", "CEL 208"},
        {"Geneva Identification System", "GEN# +1.00012993"},
        {"Smithsonian Astrophysical Observation", "SAO 22966"},
        {"Wilson Evans Batten Catalogue", "WEB 2099"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.26032102),
        dec: Angle.Degrees(+57.93220375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102403"},
        {"Hipparcos Number", "HIP 57518"},
        {"Smithsonian Astrophysical Observation", "SAO 28146"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.83530112),
        dec: Angle.Degrees(+57.93395546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237911"},
        {"Hipparcos Number", "HIP 51881"},
        {"Smithsonian Astrophysical Observation", "SAO 27701"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.00328154),
        dec: Angle.Degrees(+57.93631842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79125",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9944 A"},
        {"Henry Draper", "HD 145674"},
        {"Hipparcos Number", "HIP 79125"},
        {"Geneva Identification System", "GEN# +1.00145674"},
        {"Smithsonian Astrophysical Observation", "SAO 29823"},
        {"Wilson Evans Batten Catalogue", "WEB 13376"},
    },
    visualMagnitude: 6.33,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.26215069),
        dec: Angle.Degrees(+57.93780185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238371"},
        {"Hipparcos Number", "HIP 71283"},
        {"Smithsonian Astrophysical Observation", "SAO 29207"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.66866915),
        dec: Angle.Degrees(+57.93942348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204067"},
        {"Hipparcos Number", "HIP 105642"},
        {"Smithsonian Astrophysical Observation", "SAO 33389"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.96168547),
        dec: Angle.Degrees(+57.94029855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109497",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15706 A"},
        {"Henry Draper", "HD 210760"},
        {"Hipparcos Number", "HIP 109497"},
        {"Geneva Identification System", "GEN# +1.00210760"},
        {"Smithsonian Astrophysical Observation", "SAO 34141"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.72871630),
        dec: Angle.Degrees(+57.94135176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104482"},
        {"Hipparcos Number", "HIP 58676"},
        {"Smithsonian Astrophysical Observation", "SAO 28224"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.47550405),
        dec: Angle.Degrees(+57.94346721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239847"},
        {"Hipparcos Number", "HIP 109063"},
        {"Geneva Identification System", "GEN# +1.00239847"},
        {"Smithsonian Astrophysical Observation", "SAO 34047"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.41204972),
        dec: Angle.Degrees(+57.94412875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238629"},
        {"Hipparcos Number", "HIP 82949"},
        {"Smithsonian Astrophysical Observation", "SAO 30174"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.26182884),
        dec: Angle.Degrees(+57.94448138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95340"},
        {"Hipparcos Number", "HIP 53888"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.37415516),
        dec: Angle.Degrees(+57.94950020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54775"},
        {"Hipparcos Number", "HIP 34925"},
        {"Smithsonian Astrophysical Observation", "SAO 26221"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.40514905),
        dec: Angle.Degrees(+57.95458141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92634"},
        {"Hipparcos Number", "HIP 52428"},
        {"Smithsonian Astrophysical Observation", "SAO 27745"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.77100286),
        dec: Angle.Degrees(+57.95590020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129580"},
        {"Hipparcos Number", "HIP 71782"},
        {"Cincinnati Publication", "Ci 18 1939"},
        {"Smithsonian Astrophysical Observation", "SAO 29244"},
        {"Wilson Evans Batten Catalogue", "WEB 12366"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.844,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.25291684),
        dec: Angle.Degrees(+57.95819514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 138.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -162.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238470"},
        {"Hipparcos Number", "HIP 76081"},
        {"Smithsonian Astrophysical Observation", "SAO 29563"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.07567891),
        dec: Angle.Degrees(+57.96299966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39029"},
        {"Hipparcos Number", "HIP 27838"},
        {"Smithsonian Astrophysical Observation", "SAO 25430"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.35813949),
        dec: Angle.Degrees(+57.96366730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11837"},
        {"Hipparcos Number", "HIP 9168"},
        {"Geneva Identification System", "GEN# +1.00011837"},
        {"Smithsonian Astrophysical Observation", "SAO 22790"},
        {"Wilson Evans Batten Catalogue", "WEB 1924"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.51294535),
        dec: Angle.Degrees(+57.96377576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239106"},
        {"Hipparcos Number", "HIP 95852"},
        {"Smithsonian Astrophysical Observation", "SAO 31706"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.42512409),
        dec: Angle.Degrees(+57.96584929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53740"},
        {"Hipparcos Number", "HIP 34563"},
        {"Geneva Identification System", "GEN# +1.00053740"},
        {"Smithsonian Astrophysical Observation", "SAO 26177"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.39243189),
        dec: Angle.Degrees(+57.96596552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142739"},
        {"Hipparcos Number", "HIP 77807"},
        {"Smithsonian Astrophysical Observation", "SAO 29703"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.842,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.31641610),
        dec: Angle.Degrees(+57.96630630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -227.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11657"},
        {"Hipparcos Number", "HIP 9018"},
        {"Geneva Identification System", "GEN# +1.00011657"},
        {"Smithsonian Astrophysical Observation", "SAO 22761"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.03140172),
        dec: Angle.Degrees(+57.96721624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156051"},
        {"Hipparcos Number", "HIP 84129"},
        {"Fundamental Katalog 5th Edition", "FK5 5517"},
        {"Geneva Identification System", "GEN# +1.00156051"},
        {"Smithsonian Astrophysical Observation", "SAO 30291"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.97799025),
        dec: Angle.Degrees(+57.96747339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1727"},
        {"Hipparcos Number", "HIP 1730"},
        {"Smithsonian Astrophysical Observation", "SAO 21325"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.46412869),
        dec: Angle.Degrees(+57.96829458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101391"},
        {"Hipparcos Number", "HIP 56944"},
        {"Geneva Identification System", "GEN# +1.00101391"},
        {"Renson", "Renson 29210"},
        {"Smithsonian Astrophysical Observation", "SAO 28093"},
        {"Wilson Evans Batten Catalogue", "WEB 10251"},
    },
    visualMagnitude: 6.35,
    bvColour: -0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.11433318),
        dec: Angle.Degrees(+57.97037360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238677"},
        {"Hipparcos Number", "HIP 84837"},
        {"Smithsonian Astrophysical Observation", "SAO 30348"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.09081421),
        dec: Angle.Degrees(+57.97431000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236409"},
        {"Hipparcos Number", "HIP 2092"},
        {"Smithsonian Astrophysical Observation", "SAO 21399"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.60003697),
        dec: Angle.Degrees(+57.97473255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24141"},
        {"Hipparcos Number", "HIP 18217"},
        {"Fundamental Katalog 5th Edition", "FK5 1105"},
        {"Geneva Identification System", "GEN# +1.00024141"},
        {"Renson", "Renson 6180"},
        {"Smithsonian Astrophysical Observation", "SAO 24276"},
        {"Wilson Evans Batten Catalogue", "WEB 3515"},
    },
    visualMagnitude: 5.80,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.42996876),
        dec: Angle.Degrees(+57.97536931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116018",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116018"},
        {"Geneva Identification System", "GEN# +0.05702750"},
    },
    visualMagnitude: 8.91,
    bvColour: 2.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.61407069),
        dec: Angle.Degrees(+57.97603324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9900"},
        {"Hipparcos Number", "HIP 7617"},
        {"Fundamental Katalog 5th Edition", "FK5 2108"},
        {"Geneva Identification System", "GEN# +1.00009900"},
        {"Smithsonian Astrophysical Observation", "SAO 22456"},
        {"Wilson Evans Batten Catalogue", "WEB 1629"},
    },
    visualMagnitude: 5.55,
    bvColour: 1.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.53151544),
        dec: Angle.Degrees(+57.97764488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166780"},
        {"Hipparcos Number", "HIP 88877"},
        {"Geneva Identification System", "GEN# +1.00166780"},
        {"Smithsonian Astrophysical Observation", "SAO 30770"},
        {"Wilson Evans Batten Catalogue", "WEB 15071"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.16200585),
        dec: Angle.Degrees(+57.97970445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6249"},
        {"Hipparcos Number", "HIP 5029"},
        {"Celescope Catalog", "CEL 114"},
        {"Geneva Identification System", "GEN# +1.00006249"},
        {"Smithsonian Astrophysical Observation", "SAO 21976"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.10234384),
        dec: Angle.Degrees(+57.98112862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240339"},
        {"Hipparcos Number", "HIP 116538"},
        {"Smithsonian Astrophysical Observation", "SAO 35599"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.26599677),
        dec: Angle.Degrees(+57.98118794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46193"},
        {"Hipparcos Number", "HIP 31479"},
        {"Geneva Identification System", "GEN# +1.00046193"},
        {"Smithsonian Astrophysical Observation", "SAO 25824"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.89645522),
        dec: Angle.Degrees(+57.98624622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24758"},
        {"Hipparcos Number", "HIP 18632"},
        {"Smithsonian Astrophysical Observation", "SAO 24328"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.82383247),
        dec: Angle.Degrees(+57.98717751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110280",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110280"},
        {"Geneva Identification System", "GEN# +2.72610136"},
        {"New General Catalogue", "NGC 7261 136"},
    },
    visualMagnitude: 10.49,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.07277280),
        dec: Angle.Degrees(+57.99200847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88424"},
        {"Hipparcos Number", "HIP 50079"},
        {"Fundamental Katalog 5th Edition", "FK5 4910"},
        {"Smithsonian Astrophysical Observation", "SAO 27564"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.37002276),
        dec: Angle.Degrees(+57.99375157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5343"},
        {"Hipparcos Number", "HIP 4383"},
        {"Geneva Identification System", "GEN# +1.00005343"},
        {"Smithsonian Astrophysical Observation", "SAO 21846"},
        {"Wilson Evans Batten Catalogue", "WEB 783"},
    },
    visualMagnitude: 6.20,
    bvColour: 1.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.05386154),
        dec: Angle.Degrees(+57.99659583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35163",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35163"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.98652637),
        dec: Angle.Degrees(+57.99743097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -151.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209481"},
        {"Hipparcos Number", "HIP 108772"},
        {"Celescope Catalog", "CEL 5421"},
        {"Geneva Identification System", "GEN# +1.00209481"},
        {"Smithsonian Astrophysical Observation", "SAO 33990"},
        {"Wilson Evans Batten Catalogue", "WEB 19567"},
    },
    visualMagnitude: 5.55,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.51906636),
        dec: Angle.Degrees(+58.00037041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237029"},
        {"Hipparcos Number", "HIP 13668"},
        {"Smithsonian Astrophysical Observation", "SAO 23706"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.00204603),
        dec: Angle.Degrees(+58.00049904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168129"},
        {"Hipparcos Number", "HIP 89415"},
        {"Smithsonian Astrophysical Observation", "SAO 30838"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.70459596),
        dec: Angle.Degrees(+58.00260414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3809",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 671 H"},
        {"Henry Draper", "HD 236533"},
        {"Hipparcos Number", "HIP 3809"},
        {"Smithsonian Astrophysical Observation", "SAO 21730"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.24102325),
        dec: Angle.Degrees(+58.00727034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168889"},
        {"Hipparcos Number", "HIP 89715"},
        {"Smithsonian Astrophysical Observation", "SAO 30887"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.64097212),
        dec: Angle.Degrees(+58.00825962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110581"},
        {"Hipparcos Number", "HIP 62010"},
        {"Smithsonian Astrophysical Observation", "SAO 28485"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.63731115),
        dec: Angle.Degrees(+58.00865948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238083"},
        {"Hipparcos Number", "HIP 59450"},
        {"Smithsonian Astrophysical Observation", "SAO 28289"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.91682707),
        dec: Angle.Degrees(+58.00973872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122864"},
        {"Hipparcos Number", "HIP 68607"},
        {"Smithsonian Astrophysical Observation", "SAO 28987"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.65213240),
        dec: Angle.Degrees(+58.01043515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237006"},
        {"Hipparcos Number", "HIP 13151"},
        {"Geneva Identification System", "GEN# +1.00237006"},
        {"Smithsonian Astrophysical Observation", "SAO 23631"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.28684829),
        dec: Angle.Degrees(+58.01345731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238320"},
        {"Hipparcos Number", "HIP 68746"},
        {"Smithsonian Astrophysical Observation", "SAO 28998"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.07879792),
        dec: Angle.Degrees(+58.01532458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54240"},
        {"Hipparcos Number", "HIP 34734"},
        {"Geneva Identification System", "GEN# +1.00054240"},
        {"Smithsonian Astrophysical Observation", "SAO 26199"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.87453841),
        dec: Angle.Degrees(+58.01532517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -134.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2935",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 515 AB"},
        {"Henry Draper", "HD 3377"},
        {"Hipparcos Number", "HIP 2935"},
        {"Smithsonian Astrophysical Observation", "SAO 21571"},
    },
    visualMagnitude: 7.39,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.31808930),
        dec: Angle.Degrees(+58.01621970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186760"},
        {"Hipparcos Number", "HIP 97033"},
        {"Geneva Identification System", "GEN# +1.00186760"},
        {"Smithsonian Astrophysical Observation", "SAO 31923"},
        {"Wilson Evans Batten Catalogue", "WEB 17027"},
    },
    visualMagnitude: 6.29,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.80949004),
        dec: Angle.Degrees(+58.01675205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 128.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 628"},
        {"Hipparcos Number", "HIP 874"},
        {"Smithsonian Astrophysical Observation", "SAO 21170"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.68806989),
        dec: Angle.Degrees(+58.01831644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13929"},
        {"Hipparcos Number", "HIP 10690"},
        {"Geneva Identification System", "GEN# +1.00013929"},
        {"Renson", "Renson 3570"},
        {"Smithsonian Astrophysical Observation", "SAO 23133"},
        {"Wilson Evans Batten Catalogue", "WEB 2252"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.39124573),
        dec: Angle.Degrees(+58.02000633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10806"},
        {"Hipparcos Number", "HIP 8321"},
        {"Fundamental Katalog 5th Edition", "FK5 4164"},
        {"Smithsonian Astrophysical Observation", "SAO 22620"},
    },
    visualMagnitude: 6.76,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.82477256),
        dec: Angle.Degrees(+58.02123651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141020"},
        {"Hipparcos Number", "HIP 77037"},
        {"Smithsonian Astrophysical Observation", "SAO 29634"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.94845325),
        dec: Angle.Degrees(+58.02422711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15449"},
        {"Hipparcos Number", "HIP 11733"},
        {"Geneva Identification System", "GEN# +1.00015449"},
        {"Smithsonian Astrophysical Observation", "SAO 23394"},
        {"Wilson Evans Batten Catalogue", "WEB 2436"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.86266799),
        dec: Angle.Degrees(+58.02480505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183339"},
        {"Hipparcos Number", "HIP 95520"},
        {"Fundamental Katalog 5th Edition", "FK5 1507"},
        {"Geneva Identification System", "GEN# +1.00183339"},
        {"Renson", "Renson 50640"},
        {"Smithsonian Astrophysical Observation", "SAO 31652"},
        {"Wilson Evans Batten Catalogue", "WEB 16705"},
    },
    visualMagnitude: 6.60,
    bvColour: -0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.44486270),
        dec: Angle.Degrees(+58.02730984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238264"},
        {"Hipparcos Number", "HIP 66591"},
        {"Smithsonian Astrophysical Observation", "SAO 28830"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.75432376),
        dec: Angle.Degrees(+58.02735759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102194"},
        {"Hipparcos Number", "HIP 57383"},
        {"Geneva Identification System", "GEN# +1.00102194"},
        {"Smithsonian Astrophysical Observation", "SAO 28129"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.47144856),
        dec: Angle.Degrees(+58.02749912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -163.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85425"},
        {"Hipparcos Number", "HIP 48510"},
        {"Geneva Identification System", "GEN# +1.00085425"},
        {"Smithsonian Astrophysical Observation", "SAO 27417"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.40221182),
        dec: Angle.Degrees(+58.02858646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17290"},
        {"Hipparcos Number", "HIP 13142"},
        {"Geneva Identification System", "GEN# +1.00017290"},
        {"Smithsonian Astrophysical Observation", "SAO 23629"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.25836158),
        dec: Angle.Degrees(+58.02905934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 135.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -135.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240237"},
        {"Hipparcos Number", "HIP 114840"},
        {"Smithsonian Astrophysical Observation", "SAO 35269"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.92593495),
        dec: Angle.Degrees(+58.04325280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114535"},
        {"Hipparcos Number", "HIP 64249"},
        {"Smithsonian Astrophysical Observation", "SAO 28661"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.52825394),
        dec: Angle.Degrees(+58.04500025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110276"},
        {"Hipparcos Number", "HIP 61837"},
        {"Geneva Identification System", "GEN# +1.00110276"},
        {"Smithsonian Astrophysical Observation", "SAO 28472"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.08713661),
        dec: Angle.Degrees(+58.04610796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55700"},
        {"Hipparcos Number", "HIP 35283"},
        {"Geneva Identification System", "GEN# +1.00055700"},
        {"Smithsonian Astrophysical Observation", "SAO 26257"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.33403753),
        dec: Angle.Degrees(+58.04948016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65449"},
        {"Hipparcos Number", "HIP 39285"},
        {"Smithsonian Astrophysical Observation", "SAO 26627"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.49967650),
        dec: Angle.Degrees(+58.04950368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79721"},
        {"Hipparcos Number", "HIP 45630"},
        {"Smithsonian Astrophysical Observation", "SAO 27204"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.51877006),
        dec: Angle.Degrees(+58.05328309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202391"},
        {"Hipparcos Number", "HIP 104739"},
        {"Smithsonian Astrophysical Observation", "SAO 33235"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.27198768),
        dec: Angle.Degrees(+58.05382831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130893"},
        {"Hipparcos Number", "HIP 72409"},
        {"Geneva Identification System", "GEN# +1.00130893"},
        {"Smithsonian Astrophysical Observation", "SAO 29289"},
        {"Wilson Evans Batten Catalogue", "WEB 12447"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.08805509),
        dec: Angle.Degrees(+58.05733874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239679"},
        {"Hipparcos Number", "HIP 106008"},
        {"Smithsonian Astrophysical Observation", "SAO 33451"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.05912918),
        dec: Angle.Degrees(+58.05784027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236451"},
        {"Hipparcos Number", "HIP 2494"},
        {"Smithsonian Astrophysical Observation", "SAO 21484"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.91650208),
        dec: Angle.Degrees(+58.05890811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239868"},
        {"Hipparcos Number", "HIP 109358"},
        {"Geneva Identification System", "GEN# +1.00239868"},
        {"Smithsonian Astrophysical Observation", "SAO 34113"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.33866416),
        dec: Angle.Degrees(+58.06201224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39410"},
        {"Hipparcos Number", "HIP 28071"},
        {"Smithsonian Astrophysical Observation", "SAO 25460"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.02342738),
        dec: Angle.Degrees(+58.06584435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 352",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 352"},
        {"Cincinnati Publication", "Ci 20 1"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.11010195),
        dec: Angle.Degrees(+58.06878245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 436.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199626"},
        {"Hipparcos Number", "HIP 103317"},
        {"Smithsonian Astrophysical Observation", "SAO 33002"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.98110578),
        dec: Angle.Degrees(+58.07000484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237692"},
        {"Hipparcos Number", "HIP 40712"},
        {"Smithsonian Astrophysical Observation", "SAO 26762"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.65073129),
        dec: Angle.Degrees(+58.07178297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240326"},
        {"Hipparcos Number", "HIP 116212"},
        {"Smithsonian Astrophysical Observation", "SAO 35533"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.20044400),
        dec: Angle.Degrees(+58.07192477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222794"},
        {"Hipparcos Number", "HIP 117029"},
        {"Cincinnati Publication", "Ci 20 1447"},
        {"Geneva Identification System", "GEN# +1.00222794"},
        {"Smithsonian Astrophysical Observation", "SAO 35706"},
        {"Wilson Evans Batten Catalogue", "WEB 20636"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.86088613),
        dec: Angle.Degrees(+58.07912795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 390.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 481.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240447"},
        {"Hipparcos Number", "HIP 117947"},
        {"Smithsonian Astrophysical Observation", "SAO 35896"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.86047692),
        dec: Angle.Degrees(+58.07916393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10332",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10332"},
        {"Wilson Evans Batten Catalogue", "WEB 2159"},
    },
    visualMagnitude: 11.42,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.28120925),
        dec: Angle.Degrees(+58.07996584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125272"},
        {"Hipparcos Number", "HIP 69738"},
        {"Geneva Identification System", "GEN# +1.00125272"},
        {"Smithsonian Astrophysical Observation", "SAO 29078"},
        {"Wilson Evans Batten Catalogue", "WEB 12144"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.10973673),
        dec: Angle.Degrees(+58.08283253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -146.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 122.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66059",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66059"},
    },
    visualMagnitude: 11.18,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.14160039),
        dec: Angle.Degrees(+58.08311329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215835"},
        {"Hipparcos Number", "HIP 112470"},
        {"Geneva Identification System", "GEN# +2.73800002"},
        {"Smithsonian Astrophysical Observation", "SAO 34810"},
        {"Wilson Evans Batten Catalogue", "WEB 20057"},
        {"New General Catalogue", "NGC 7380 2"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.72547438),
        dec: Angle.Degrees(+58.08432277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239927"},
        {"Hipparcos Number", "HIP 110294"},
        {"Geneva Identification System", "GEN# +2.72610098"},
        {"Smithsonian Astrophysical Observation", "SAO 34332"},
        {"New General Catalogue", "NGC 7261 98"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.10725823),
        dec: Angle.Degrees(+58.08479834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239914"},
        {"Hipparcos Number", "HIP 110056"},
        {"Geneva Identification System", "GEN# +1.00239914"},
        {"Smithsonian Astrophysical Observation", "SAO 34279"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.36770407),
        dec: Angle.Degrees(+58.08548763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19530"},
        {"Hipparcos Number", "HIP 14800"},
        {"Smithsonian Astrophysical Observation", "SAO 23855"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.78744096),
        dec: Angle.Degrees(+58.08850169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224116"},
        {"Hipparcos Number", "HIP 117930"},
        {"Geneva Identification System", "GEN# +1.00224116"},
        {"Smithsonian Astrophysical Observation", "SAO 35891"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.81229253),
        dec: Angle.Degrees(+58.08891173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 75.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112469",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112469"},
    },
    visualMagnitude: 10.00,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)46, 53.9400),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)05, 24.200)
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
    primaryId: "HIP 31872",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5276 AB"},
        {"Henry Draper", "HD 46963"},
        {"Hipparcos Number", "HIP 31872"},
        {"Smithsonian Astrophysical Observation", "SAO 25861"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.93159799),
        dec: Angle.Degrees(+58.09511961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116610",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16881 AB"},
        {"Henry Draper", "HD 222153"},
        {"Hipparcos Number", "HIP 116610"},
        {"Celescope Catalog", "CEL 5642"},
        {"Smithsonian Astrophysical Observation", "SAO 35618"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.47402870),
        dec: Angle.Degrees(+58.09539308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86884"},
        {"Hipparcos Number", "HIP 49246"},
        {"Geneva Identification System", "GEN# +1.00086884"},
        {"Smithsonian Astrophysical Observation", "SAO 27491"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.80029108),
        dec: Angle.Degrees(+58.09813368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -174.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -136.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31152"},
        {"Hipparcos Number", "HIP 23004"},
        {"Smithsonian Astrophysical Observation", "SAO 24924"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.21952630),
        dec: Angle.Degrees(+58.09939199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99725",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99725"},
        {"Geneva Identification System", "GEN# +0.05702161"},
    },
    visualMagnitude: 9.75,
    bvColour: 1.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.53226054),
        dec: Angle.Degrees(+58.10538403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46317"},
        {"Hipparcos Number", "HIP 31552"},
        {"Geneva Identification System", "GEN# +1.00046317"},
        {"Smithsonian Astrophysical Observation", "SAO 25832"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.06248972),
        dec: Angle.Degrees(+58.10726180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 123.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -197.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218892"},
        {"Hipparcos Number", "HIP 114465"},
        {"Smithsonian Astrophysical Observation", "SAO 35202"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.72950400),
        dec: Angle.Degrees(+58.10835077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89651"},
        {"Hipparcos Number", "HIP 50809"},
        {"Smithsonian Astrophysical Observation", "SAO 27624"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.60203531),
        dec: Angle.Degrees(+58.10940196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34189"},
        {"Hipparcos Number", "HIP 24801"},
        {"Smithsonian Astrophysical Observation", "SAO 25123"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.75533238),
        dec: Angle.Degrees(+58.10985640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11875"},
        {"Hipparcos Number", "HIP 9215"},
        {"Geneva Identification System", "GEN# +1.00011875"},
        {"Smithsonian Astrophysical Observation", "SAO 22802"},
        {"Wilson Evans Batten Catalogue", "WEB 1935"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.62376075),
        dec: Angle.Degrees(+58.11212520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124794"},
        {"Hipparcos Number", "HIP 69502"},
        {"Smithsonian Astrophysical Observation", "SAO 29052"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.43016118),
        dec: Angle.Degrees(+58.11514139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104905"},
        {"Hipparcos Number", "HIP 58913"},
        {"Smithsonian Astrophysical Observation", "SAO 28236"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.21260166),
        dec: Angle.Degrees(+58.11538896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10387"},
        {"Hipparcos Number", "HIP 8019"},
        {"Geneva Identification System", "GEN# +1.00010387"},
        {"Smithsonian Astrophysical Observation", "SAO 22535"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.74057013),
        dec: Angle.Degrees(+58.11583391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34233"},
        {"Hipparcos Number", "HIP 24836"},
        {"Geneva Identification System", "GEN# +1.00034233"},
        {"Smithsonian Astrophysical Observation", "SAO 25125"},
        {"Wilson Evans Batten Catalogue", "WEB 4811"},
    },
    visualMagnitude: 6.13,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.86604282),
        dec: Angle.Degrees(+58.11740918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73942",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73942"},
    },
    visualMagnitude: 9.79,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.64780454),
        dec: Angle.Degrees(+58.11977783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150826"},
        {"Hipparcos Number", "HIP 81612"},
        {"Geneva Identification System", "GEN# +1.00150826"},
        {"Smithsonian Astrophysical Observation", "SAO 30041"},
        {"Wilson Evans Batten Catalogue", "WEB 13783"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.03163895),
        dec: Angle.Degrees(+58.12021478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75298"},
        {"Hipparcos Number", "HIP 43525"},
        {"Geneva Identification System", "GEN# +1.00075298"},
        {"Smithsonian Astrophysical Observation", "SAO 27017"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.97568915),
        dec: Angle.Degrees(+58.12669997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237620"},
        {"Hipparcos Number", "HIP 36344"},
        {"Smithsonian Astrophysical Observation", "SAO 26358"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.20858937),
        dec: Angle.Degrees(+58.12835972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81772"},
        {"Hipparcos Number", "HIP 46575"},
        {"Geneva Identification System", "GEN# +1.00081772"},
        {"Renson", "Renson 23220"},
        {"Smithsonian Astrophysical Observation", "SAO 27270"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.46922071),
        dec: Angle.Degrees(+58.12910783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237982"},
        {"Hipparcos Number", "HIP 55006"},
        {"Smithsonian Astrophysical Observation", "SAO 27966"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.93751664),
        dec: Angle.Degrees(+58.12997509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12750"},
        {"Hipparcos Number", "HIP 9857"},
        {"Geneva Identification System", "GEN# +1.00012750"},
        {"Smithsonian Astrophysical Observation", "SAO 22924"},
        {"Wilson Evans Batten Catalogue", "WEB 2067"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.70315518),
        dec: Angle.Degrees(+58.13731335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239712"},
        {"Hipparcos Number", "HIP 106716"},
        {"Geneva Identification System", "GEN# +4.35370710"},
        {"Smithsonian Astrophysical Observation", "SAO 33581"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.24853065),
        dec: Angle.Degrees(+58.14018540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13658"},
        {"Hipparcos Number", "HIP 10489"},
        {"Geneva Identification System", "GEN# +1.00013658"},
    },
    visualMagnitude: 8.78,
    bvColour: 2.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.80540593),
        dec: Angle.Degrees(+58.14231089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81357"},
        {"Hipparcos Number", "HIP 46377"},
        {"Geneva Identification System", "GEN# +1.00081357"},
        {"Smithsonian Astrophysical Observation", "SAO 27259"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.84961690),
        dec: Angle.Degrees(+58.14283914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6486",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1105 AB"},
        {"Henry Draper", "HD 8272"},
        {"Hipparcos Number", "HIP 6486"},
        {"Smithsonian Astrophysical Observation", "SAO 22230"},
        {"Wilson Evans Batten Catalogue", "WEB 1429"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.83863463),
        dec: Angle.Degrees(+58.14321418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 132.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2493",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 429 AB"},
        {"Henry Draper", "HD 236450"},
        {"Hipparcos Number", "HIP 2493"},
        {"Smithsonian Astrophysical Observation", "SAO 21483"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.91002008),
        dec: Angle.Degrees(+58.14366077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179141"},
        {"Hipparcos Number", "HIP 93968"},
        {"Smithsonian Astrophysical Observation", "SAO 31410"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.99967425),
        dec: Angle.Degrees(+58.14403717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 181.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238402"},
        {"Hipparcos Number", "HIP 72813"},
        {"Geneva Identification System", "GEN# +1.00238402"},
        {"Smithsonian Astrophysical Observation", "SAO 29323"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.23551163),
        dec: Angle.Degrees(+58.14569435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112558",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112558"},
        {"Geneva Identification System", "GEN# +2.73800004"},
        {"Wilson Evans Batten Catalogue", "WEB 20069"},
        {"Wilson Evans Batten Catalogue 2", "WEB 20060"},
        {"New General Catalogue", "NGC 7380 4"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.95655729),
        dec: Angle.Degrees(+58.14709139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215588"},
        {"Hipparcos Number", "HIP 112324"},
        {"Fundamental Katalog 5th Edition", "FK5 3822"},
        {"Geneva Identification System", "GEN# +1.00215588"},
        {"Smithsonian Astrophysical Observation", "SAO 34761"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.26541656),
        dec: Angle.Degrees(+58.14738318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -137.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238015"},
        {"Hipparcos Number", "HIP 56459"},
        {"Smithsonian Astrophysical Observation", "SAO 28059"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.64110559),
        dec: Angle.Degrees(+58.15586474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9974"},
        {"Hipparcos Number", "HIP 7681"},
        {"Geneva Identification System", "GEN# +1.00009974"},
        {"Wilson Evans Batten Catalogue", "WEB 1643"},
    },
    visualMagnitude: 10.67,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.73180032),
        dec: Angle.Degrees(+58.15630156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63034",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8702 A"},
        {"Henry Draper", "HD 112311"},
        {"Hipparcos Number", "HIP 63034"},
        {"Smithsonian Astrophysical Observation", "SAO 28561"},
        {"Wilson Evans Batten Catalogue", "WEB 11177"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.74832694),
        dec: Angle.Degrees(+58.16044191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63028",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8702 B"},
        {"Henry Draper", "HD 112311B"},
        {"Hipparcos Number", "HIP 63028"},
    },
    visualMagnitude: 9.85,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.73852099),
        dec: Angle.Degrees(+58.16090425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214088"},
        {"Hipparcos Number", "HIP 111436"},
        {"Smithsonian Astrophysical Observation", "SAO 34580"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.63540149),
        dec: Angle.Degrees(+58.16300129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45410"},
        {"Hipparcos Number", "HIP 31039"},
        {"Geneva Identification System", "GEN# +1.00045410"},
        {"Smithsonian Astrophysical Observation", "SAO 25771"},
        {"Wilson Evans Batten Catalogue", "WEB 6178"},
    },
    visualMagnitude: 5.86,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.69642228),
        dec: Angle.Degrees(+58.16345682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -338.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66297"},
        {"Hipparcos Number", "HIP 39643"},
        {"Renson", "Renson 18290"},
        {"Smithsonian Astrophysical Observation", "SAO 26663"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.51603578),
        dec: Angle.Degrees(+58.16397355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238028"},
        {"Hipparcos Number", "HIP 56844"},
        {"Geneva Identification System", "GEN# +1.00238028"},
        {"Smithsonian Astrophysical Observation", "SAO 28086"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.81113829),
        dec: Angle.Degrees(+58.16435614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188664"},
        {"Hipparcos Number", "HIP 97862"},
        {"Smithsonian Astrophysical Observation", "SAO 32084"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.29871937),
        dec: Angle.Degrees(+58.16490171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144955"},
        {"Hipparcos Number", "HIP 78812"},
        {"Smithsonian Astrophysical Observation", "SAO 29792"},
        {"Wilson Evans Batten Catalogue", "WEB 13324"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.33777205),
        dec: Angle.Degrees(+58.16624901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239661"},
        {"Hipparcos Number", "HIP 105758"},
        {"Smithsonian Astrophysical Observation", "SAO 33418"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.30107457),
        dec: Angle.Degrees(+58.16682107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219855"},
        {"Hipparcos Number", "HIP 115076"},
        {"Celescope Catalog", "CEL 5595"},
        {"Geneva Identification System", "GEN# +1.00219855"},
        {"Renson", "Renson 60360"},
        {"Smithsonian Astrophysical Observation", "SAO 35314"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.62007627),
        dec: Angle.Degrees(+58.16693398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72655"},
        {"Hipparcos Number", "HIP 42256"},
        {"Smithsonian Astrophysical Observation", "SAO 26923"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.24240484),
        dec: Angle.Degrees(+58.16716975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15220",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2427 AB"},
        {"Hipparcos Number", "HIP 15220"},
        {"Cincinnati Publication", "Ci 20 214"},
        {"Geneva Identification System", "GEN# +9.80174041"},
    },
    visualMagnitude: 10.53,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.05558125),
        dec: Angle.Degrees(+58.16816990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 431.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -324.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19592"},
        {"Hipparcos Number", "HIP 14852"},
        {"Smithsonian Astrophysical Observation", "SAO 23863"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.95540763),
        dec: Angle.Degrees(+58.17653349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237107"},
        {"Hipparcos Number", "HIP 15294"},
        {"Smithsonian Astrophysical Observation", "SAO 23925"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.33052090),
        dec: Angle.Degrees(+58.17781142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236764"},
        {"Hipparcos Number", "HIP 7092"},
        {"Smithsonian Astrophysical Observation", "SAO 22351"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.84962425),
        dec: Angle.Degrees(+58.18063520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70918"},
        {"Hipparcos Number", "HIP 41468"},
        {"Geneva Identification System", "GEN# +1.00070918"},
        {"Smithsonian Astrophysical Observation", "SAO 26840"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.88052735),
        dec: Angle.Degrees(+58.18776764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237467"},
        {"Hipparcos Number", "HIP 29252"},
        {"Smithsonian Astrophysical Observation", "SAO 25598"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.52067582),
        dec: Angle.Degrees(+58.19574391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216912"},
        {"Hipparcos Number", "HIP 113255"},
        {"Celescope Catalog", "CEL 5544"},
        {"Geneva Identification System", "GEN# +1.00216912"},
        {"Smithsonian Astrophysical Observation", "SAO 34967"},
    },
    visualMagnitude: 7.06,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.01397612),
        dec: Angle.Degrees(+58.19583915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205510"},
        {"Hipparcos Number", "HIP 106457"},
        {"Geneva Identification System", "GEN# +1.00205510"},
        {"Renson", "Renson 57260"},
        {"Smithsonian Astrophysical Observation", "SAO 33529"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.42379250),
        dec: Angle.Degrees(+58.19586665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236797"},
        {"Hipparcos Number", "HIP 7453"},
        {"Smithsonian Astrophysical Observation", "SAO 22422"},
        {"Wilson Evans Batten Catalogue", "WEB 1596"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.00642458),
        dec: Angle.Degrees(+58.19632036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223150"},
        {"Hipparcos Number", "HIP 117281"},
        {"Geneva Identification System", "GEN# +1.00223150"},
        {"Smithsonian Astrophysical Observation", "SAO 35756"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.71952235),
        dec: Angle.Degrees(+58.19655978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16702"},
        {"Hipparcos Number", "HIP 12685"},
        {"Geneva Identification System", "GEN# +1.00016702"},
        {"Smithsonian Astrophysical Observation", "SAO 23552"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.74452403),
        dec: Angle.Degrees(+58.19779503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238403"},
        {"Hipparcos Number", "HIP 72854"},
        {"Smithsonian Astrophysical Observation", "SAO 29325"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.36769730),
        dec: Angle.Degrees(+58.19814875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210745"},
        {"Hipparcos Number", "HIP 109492"},
        {"Fundamental Katalog 5th Edition", "FK5 836"},
        {"Geneva Identification System", "GEN# +1.00210745"},
        {"Smithsonian Astrophysical Observation", "SAO 34137"},
        {"Wilson Evans Batten Catalogue", "WEB 19675"},
    },
    visualMagnitude: 3.39,
    bvColour: 1.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.71359131),
        dec: Angle.Degrees(+58.20124992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48307",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7533 AB"},
        {"Henry Draper", "HD 84981"},
        {"Hipparcos Number", "HIP 48307"},
        {"Smithsonian Astrophysical Observation", "SAO 27399"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)50, 54.2100),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)12, 05.900)
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
    primaryId: "HIP 11291",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1832 AB"},
        {"Henry Draper", "HD 14825"},
        {"Hipparcos Number", "HIP 11291"},
        {"Renson", "Renson 3700"},
        {"Smithsonian Astrophysical Observation", "SAO 23311"},
        {"Wilson Evans Batten Catalogue", "WEB 2361"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.35798818),
        dec: Angle.Degrees(+58.20264504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100678"},
        {"Hipparcos Number", "HIP 56538"},
        {"Smithsonian Astrophysical Observation", "SAO 28066"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.89430664),
        dec: Angle.Degrees(+58.20307419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12150"},
        {"Hipparcos Number", "HIP 9436"},
        {"Geneva Identification System", "GEN# +1.00012150"},
        {"Smithsonian Astrophysical Observation", "SAO 22841"},
        {"Wilson Evans Batten Catalogue", "WEB 1977"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.29378020),
        dec: Angle.Degrees(+58.20350833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74258"},
        {"Hipparcos Number", "HIP 42995"},
        {"Geneva Identification System", "GEN# +1.00074258"},
        {"Smithsonian Astrophysical Observation", "SAO 26983"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.44703648),
        dec: Angle.Degrees(+58.20414358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238588"},
        {"Hipparcos Number", "HIP 81439"},
        {"Smithsonian Astrophysical Observation", "SAO 30027"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.50538232),
        dec: Angle.Degrees(+58.20479150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115458"},
        {"Hipparcos Number", "HIP 64744"},
        {"Smithsonian Astrophysical Observation", "SAO 28699"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.04018694),
        dec: Angle.Degrees(+58.20649016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 97.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11838",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11838"},
    },
    visualMagnitude: 10.39,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.20652313),
        dec: Angle.Degrees(+58.20718788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237899"},
        {"Hipparcos Number", "HIP 51181"},
    },
    visualMagnitude: 10.63,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.80857319),
        dec: Angle.Degrees(+58.20796397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6229",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1073 C"},
        {"Henry Draper", "HD 7902"},
        {"Hipparcos Number", "HIP 6229"},
        {"Geneva Identification System", "GEN# +2.04570131"},
        {"Smithsonian Astrophysical Observation", "SAO 22187"},
        {"Wilson Evans Batten Catalogue", "WEB 1395"},
        {"New General Catalogue", "NGC 457 131"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.96557259),
        dec: Angle.Degrees(+58.20814743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237193"},
        {"Hipparcos Number", "HIP 18325"},
        {"Geneva Identification System", "GEN# +1.00237193"},
        {"Smithsonian Astrophysical Observation", "SAO 24288"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.77272670),
        dec: Angle.Degrees(+58.20916613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117299"},
        {"Hipparcos Number", "HIP 65690"},
        {"Geneva Identification System", "GEN# +1.00117299"},
        {"Smithsonian Astrophysical Observation", "SAO 28767"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.02266390),
        dec: Angle.Degrees(+58.20928880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110964",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110964"},
        {"Wilson Evans Batten Catalogue", "WEB 19868"},
    },
    visualMagnitude: 11.21,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.20871694),
        dec: Angle.Degrees(+58.21095088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 698"},
        {"Hipparcos Number", "HIP 940"},
        {"Geneva Identification System", "GEN# +1.00000698"},
        {"Smithsonian Astrophysical Observation", "SAO 21190"},
        {"Wilson Evans Batten Catalogue", "WEB 165"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.90477726),
        dec: Angle.Degrees(+58.21183567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9420",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9420"},
        {"Smithsonian Astrophysical Observation", "SAO 22838"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.26010163),
        dec: Angle.Degrees(+58.21253374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63769"},
        {"Hipparcos Number", "HIP 38560"},
        {"Geneva Identification System", "GEN# +1.00063769"},
        {"Smithsonian Astrophysical Observation", "SAO 26554"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.43114557),
        dec: Angle.Degrees(+58.21383227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87816",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10937 B"},
        {"Hipparcos Number", "HIP 87816"},
        {"Wilson Evans Batten Catalogue", "WEB 14825"},
    },
    visualMagnitude: 10.99,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)56, 22.0700),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)12, 53.000)
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
    primaryId: "HIP 54990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97763"},
        {"Hipparcos Number", "HIP 54990"},
        {"Geneva Identification System", "GEN# +1.00097763"},
        {"Smithsonian Astrophysical Observation", "SAO 27965"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.89859598),
        dec: Angle.Degrees(+58.21495792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236464"},
        {"Hipparcos Number", "HIP 2667"},
        {"Geneva Identification System", "GEN# +0.05700102"},
        {"Smithsonian Astrophysical Observation", "SAO 21519"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.45372138),
        dec: Angle.Degrees(+58.21535779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87820",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10937 A"},
        {"Hipparcos Number", "HIP 87820"},
        {"Geneva Identification System", "GEN# +0.05801772S"},
        {"Wilson Evans Batten Catalogue", "WEB 14824"},
    },
    visualMagnitude: 10.00,
    bvColour: 2.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.09720263),
        dec: Angle.Degrees(+58.21852569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76216"},
        {"Hipparcos Number", "HIP 43984"},
        {"Fundamental Katalog 5th Edition", "FK5 4799"},
        {"Smithsonian Astrophysical Observation", "SAO 27056"},
        {"Wilson Evans Batten Catalogue", "WEB 8454"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.35496959),
        dec: Angle.Degrees(+58.21878963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58745"},
        {"Hipparcos Number", "HIP 36488"},
        {"Smithsonian Astrophysical Observation", "SAO 26375"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.61637953),
        dec: Angle.Degrees(+58.22058995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28666",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4604 AB"},
        {"Henry Draper", "HD 237449"},
        {"Hipparcos Number", "HIP 28666"},
        {"Smithsonian Astrophysical Observation", "SAO 25531"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.795,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.78984720),
        dec: Angle.Degrees(+58.22337624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93068",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11897 AB"},
        {"Henry Draper", "HD 176560"},
        {"Hipparcos Number", "HIP 93068"},
        {"Geneva Identification System", "GEN# +1.00176560J"},
        {"Renson", "Renson 49270"},
        {"Smithsonian Astrophysical Observation", "SAO 31292"},
        {"Wilson Evans Batten Catalogue", "WEB 16120"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.36858877),
        dec: Angle.Degrees(+58.22491647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207086"},
        {"Hipparcos Number", "HIP 107355"},
        {"Smithsonian Astrophysical Observation", "SAO 33717"},
    },
    visualMagnitude: 6.80,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.16205825),
        dec: Angle.Degrees(+58.22563967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39151"},
        {"Hipparcos Number", "HIP 27903"},
        {"Smithsonian Astrophysical Observation", "SAO 25440"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.56794395),
        dec: Angle.Degrees(+58.22767403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6242",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1073 A"},
        {"Henry Draper", "HD 7927"},
        {"Henry Draper 2", "HD 7927A"},
        {"Hipparcos Number", "HIP 6242"},
        {"Geneva Identification System", "GEN# +2.04570136"},
        {"Smithsonian Astrophysical Observation", "SAO 22191"},
        {"Wilson Evans Batten Catalogue", "WEB 1396"},
        {"New General Catalogue", "NGC 457 136"},
    },
    visualMagnitude: 4.95,
    bvColour: 0.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.02049027),
        dec: Angle.Degrees(+58.23161610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105798",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14974 AB"},
        {"Henry Draper", "HD 204321"},
        {"Hipparcos Number", "HIP 105798"},
        {"Smithsonian Astrophysical Observation", "SAO 33422"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.39016424),
        dec: Angle.Degrees(+58.23460006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61411",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61411"},
    },
    visualMagnitude: 11.21,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.75381640),
        dec: Angle.Degrees(+58.23531357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6170",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6170"},
        {"Geneva Identification System", "GEN# +2.04570128"},
        {"Wilson Evans Batten Catalogue", "WEB 1386"},
        {"New General Catalogue", "NGC 457 128"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.78573525),
        dec: Angle.Degrees(+58.23763098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109495"},
        {"Hipparcos Number", "HIP 61371"},
        {"Renson", "Renson 31750"},
        {"Smithsonian Astrophysical Observation", "SAO 28430"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.64860068),
        dec: Angle.Degrees(+58.23766559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238136"},
        {"Hipparcos Number", "HIP 61407"},
        {"Smithsonian Astrophysical Observation", "SAO 28433"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.74460208),
        dec: Angle.Degrees(+58.23785360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148978"},
        {"Hipparcos Number", "HIP 80689"},
        {"Smithsonian Astrophysical Observation", "SAO 29960"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.12331278),
        dec: Angle.Degrees(+58.23854077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239748"},
        {"Hipparcos Number", "HIP 107272"},
        {"Celescope Catalog", "CEL 5375"},
        {"Geneva Identification System", "GEN# +1.00239748"},
        {"Geneva Identification System 2", "GEN# +4.35371055"},
        {"Smithsonian Astrophysical Observation", "SAO 33696"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.92209352),
        dec: Angle.Degrees(+58.23981188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27816"},
        {"Hipparcos Number", "HIP 20754"},
        {"Geneva Identification System", "GEN# +1.00027816"},
        {"Smithsonian Astrophysical Observation", "SAO 24613"},
        {"Wilson Evans Batten Catalogue", "WEB 3980"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.70668223),
        dec: Angle.Degrees(+58.24075413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113999",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16503 AB"},
        {"Henry Draper", "HD 218195"},
        {"Hipparcos Number", "HIP 113999"},
        {"Geneva Identification System", "GEN# +1.00218195J"},
        {"Smithsonian Astrophysical Observation", "SAO 35134"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.30390132),
        dec: Angle.Degrees(+58.24149086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148755"},
        {"Hipparcos Number", "HIP 80566"},
        {"Smithsonian Astrophysical Observation", "SAO 29946"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.74042285),
        dec: Angle.Degrees(+58.24375658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107179",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107179"},
        {"Geneva Identification System", "GEN# +0.05702376"},
        {"Geneva Identification System 2", "GEN# +4.35371044"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.64001168),
        dec: Angle.Degrees(+58.24423317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236723"},
        {"Hipparcos Number", "HIP 6637"},
        {"Smithsonian Astrophysical Observation", "SAO 22259"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.28588004),
        dec: Angle.Degrees(+58.24538413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106956",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15205 A"},
        {"Henry Draper", "HD 239731"},
        {"Hipparcos Number", "HIP 106956"},
        {"Geneva Identification System", "GEN# +4.35371025"},
        {"Smithsonian Astrophysical Observation", "SAO 33643"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.93516043),
        dec: Angle.Degrees(+58.24556601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67224"},
        {"Hipparcos Number", "HIP 39995"},
        {"Geneva Identification System", "GEN# +1.00067224"},
        {"Smithsonian Astrophysical Observation", "SAO 26701"},
        {"Wilson Evans Batten Catalogue", "WEB 7798"},
    },
    visualMagnitude: 5.91,
    bvColour: 1.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.51583214),
        dec: Angle.Degrees(+58.24842270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91526",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11577 AB"},
        {"Henry Draper", "HD 173051"},
        {"Hipparcos Number", "HIP 91526"},
        {"Smithsonian Astrophysical Observation", "SAO 31097"},
        {"Wilson Evans Batten Catalogue", "WEB 15734"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.97324044),
        dec: Angle.Degrees(+58.24877666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189127"},
        {"Hipparcos Number", "HIP 98044"},
        {"Geneva Identification System", "GEN# +1.00189127"},
        {"Smithsonian Astrophysical Observation", "SAO 32116"},
        {"Wilson Evans Batten Catalogue", "WEB 17270"},
    },
    visualMagnitude: 6.10,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.84184872),
        dec: Angle.Degrees(+58.25037613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236650"},
        {"Hipparcos Number", "HIP 5609"},
        {"Renson", "Renson 1777"},
        {"Smithsonian Astrophysical Observation", "SAO 22083"},
        {"Wilson Evans Batten Catalogue", "WEB 1255"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.98056927),
        dec: Angle.Degrees(+58.25111894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238289"},
        {"Hipparcos Number", "HIP 67413"},
        {"Smithsonian Astrophysical Observation", "SAO 28897"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.24767355),
        dec: Angle.Degrees(+58.25418930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240166"},
        {"Hipparcos Number", "HIP 113755"},
        {"Smithsonian Astrophysical Observation", "SAO 35080"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.55344335),
        dec: Angle.Degrees(+58.25474477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -162.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -264.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198537"},
        {"Hipparcos Number", "HIP 102673"},
        {"Smithsonian Astrophysical Observation", "SAO 32907"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.08682399),
        dec: Angle.Degrees(+58.25692016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239614"},
        {"Hipparcos Number", "HIP 104843"},
        {"Smithsonian Astrophysical Observation", "SAO 33253"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.57764675),
        dec: Angle.Degrees(+58.25838959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87694"},
        {"Hipparcos Number", "HIP 49672"},
        {"Smithsonian Astrophysical Observation", "SAO 27530"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.10478784),
        dec: Angle.Degrees(+58.26081326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239100"},
        {"Hipparcos Number", "HIP 95766"},
        {"Smithsonian Astrophysical Observation", "SAO 31693"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.16523493),
        dec: Angle.Degrees(+58.26102837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237731"},
        {"Hipparcos Number", "HIP 42454"},
        {"Smithsonian Astrophysical Observation", "SAO 26941"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.82994247),
        dec: Angle.Degrees(+58.26191642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6676"},
        {"Hipparcos Number", "HIP 5361"},
        {"Celescope Catalog", "CEL 120"},
        {"Geneva Identification System", "GEN# +1.00006676"},
        {"Smithsonian Astrophysical Observation", "SAO 22032"},
        {"Wilson Evans Batten Catalogue", "WEB 1164"},
    },
    visualMagnitude: 5.77,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.13936547),
        dec: Angle.Degrees(+58.26347937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238294"},
        {"Hipparcos Number", "HIP 67697"},
        {"Smithsonian Astrophysical Observation", "SAO 28915"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.929,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.00748829),
        dec: Angle.Degrees(+58.26730951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238434"},
        {"Hipparcos Number", "HIP 74504"},
        {"Smithsonian Astrophysical Observation", "SAO 29448"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.38115622),
        dec: Angle.Degrees(+58.26744612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155305"},
        {"Hipparcos Number", "HIP 83765"},
        {"Smithsonian Astrophysical Observation", "SAO 30257"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.79270785),
        dec: Angle.Degrees(+58.26891030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179557"},
        {"Hipparcos Number", "HIP 94125"},
        {"Geneva Identification System", "GEN# +1.00179557"},
        {"Smithsonian Astrophysical Observation", "SAO 31434"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.40651262),
        dec: Angle.Degrees(+58.27518169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 75.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211403"},
        {"Hipparcos Number", "HIP 109876"},
        {"Geneva Identification System", "GEN# +1.00211403"},
        {"Smithsonian Astrophysical Observation", "SAO 34235"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.81450805),
        dec: Angle.Degrees(+58.27545403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220116"},
        {"Hipparcos Number", "HIP 115244"},
        {"Celescope Catalog", "CEL 5602"},
        {"Geneva Identification System", "GEN# +1.00220116"},
        {"Smithsonian Astrophysical Observation", "SAO 35340"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.14294947),
        dec: Angle.Degrees(+58.27762779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237614"},
        {"Hipparcos Number", "HIP 35917"},
    },
    visualMagnitude: 10.45,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.06517220),
        dec: Angle.Degrees(+58.28442076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66871"},
        {"Hipparcos Number", "HIP 39871"},
        {"Smithsonian Astrophysical Observation", "SAO 26685"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.16684262),
        dec: Angle.Degrees(+58.28625828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195787"},
        {"Hipparcos Number", "HIP 101184"},
        {"Smithsonian Astrophysical Observation", "SAO 32645"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.64408362),
        dec: Angle.Degrees(+58.28751118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239663"},
        {"Hipparcos Number", "HIP 105794"},
        {"Smithsonian Astrophysical Observation", "SAO 33421"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.38573070),
        dec: Angle.Degrees(+58.28866474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8159"},
        {"Hipparcos Number", "HIP 6399"},
        {"Geneva Identification System", "GEN# +1.00008159"},
        {"Smithsonian Astrophysical Observation", "SAO 22219"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.54733167),
        dec: Angle.Degrees(+58.28957654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6171",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6171"},
        {"Geneva Identification System", "GEN# +2.04570085"},
        {"New General Catalogue", "NGC 457 85"},
    },
    visualMagnitude: 10.69,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.78772777),
        dec: Angle.Degrees(+58.29056460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7285"},
        {"Hipparcos Number", "HIP 5789"},
        {"Smithsonian Astrophysical Observation", "SAO 22115"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.56624668),
        dec: Angle.Degrees(+58.29399678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47586"},
        {"Hipparcos Number", "HIP 32165"},
        {"Smithsonian Astrophysical Observation", "SAO 25892"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.74607096),
        dec: Angle.Degrees(+58.29434387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104812",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14784 AB"},
        {"Henry Draper", "HD 202519"},
        {"Hipparcos Number", "HIP 104812"},
        {"Smithsonian Astrophysical Observation", "SAO 33251"},
        {"Wilson Evans Batten Catalogue", "WEB 19061"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.52046486),
        dec: Angle.Degrees(+58.29720114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43124"},
        {"Hipparcos Number", "HIP 29950"},
        {"Smithsonian Astrophysical Observation", "SAO 25653"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.57140121),
        dec: Angle.Degrees(+58.29951092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238417"},
        {"Hipparcos Number", "HIP 73363"},
        {"Smithsonian Astrophysical Observation", "SAO 29375"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.88487860),
        dec: Angle.Degrees(+58.29961056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103828"},
        {"Hipparcos Number", "HIP 58303"},
        {"Smithsonian Astrophysical Observation", "SAO 28201"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.34449555),
        dec: Angle.Degrees(+58.29988073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -102.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22508"},
        {"Hipparcos Number", "HIP 17139"},
        {"Smithsonian Astrophysical Observation", "SAO 24148"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.05444533),
        dec: Angle.Degrees(+58.30079292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4012",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4012"},
        {"Cincinnati Publication", "Ci 20 60"},
    },
    visualMagnitude: 10.66,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.86707054),
        dec: Angle.Degrees(+58.30104220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1566.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 405.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236697"},
        {"Hipparcos Number", "HIP 6231"},
        {"Geneva Identification System", "GEN# +0.05700258"},
        {"Smithsonian Astrophysical Observation", "SAO 22188"},
        {"New General Catalogue", "NGC 457 25"},
    },
    visualMagnitude: 8.69,
    bvColour: 2.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.97341572),
        dec: Angle.Degrees(+58.30854206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70"},
        {"Hipparcos Number", "HIP 475"},
        {"Geneva Identification System", "GEN# +1.00000070"},
        {"Smithsonian Astrophysical Observation", "SAO 21077"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.42333268),
        dec: Angle.Degrees(+58.31365552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -162.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17581"},
        {"Hipparcos Number", "HIP 13347"},
        {"Geneva Identification System", "GEN# +1.00017581"},
        {"Renson", "Renson 4400"},
        {"Smithsonian Astrophysical Observation", "SAO 23662"},
        {"Wilson Evans Batten Catalogue", "WEB 2674"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.94131740),
        dec: Angle.Degrees(+58.31429743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205038"},
        {"Hipparcos Number", "HIP 106186"},
        {"Smithsonian Astrophysical Observation", "SAO 33481"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.60875007),
        dec: Angle.Degrees(+58.31613981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239337"},
        {"Hipparcos Number", "HIP 99269"},
        {"Smithsonian Astrophysical Observation", "SAO 32317"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.26130590),
        dec: Angle.Degrees(+58.31828701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237349"},
        {"Hipparcos Number", "HIP 23658"},
        {"Smithsonian Astrophysical Observation", "SAO 24994"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.26665069),
        dec: Angle.Degrees(+58.31996467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237616"},
        {"Hipparcos Number", "HIP 36001"},
        {"Smithsonian Astrophysical Observation", "SAO 26331"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.29331987),
        dec: Angle.Degrees(+58.32024838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180005"},
        {"Hipparcos Number", "HIP 94277"},
        {"Geneva Identification System", "GEN# +1.00180005"},
        {"Smithsonian Astrophysical Observation", "SAO 31464"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.83902583),
        dec: Angle.Degrees(+58.32220748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238765"},
        {"Hipparcos Number", "HIP 87310"},
        {"Smithsonian Astrophysical Observation", "SAO 30606"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.60233158),
        dec: Angle.Degrees(+58.32589770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16808"},
        {"Hipparcos Number", "HIP 12769"},
        {"Geneva Identification System", "GEN# +1.00016808"},
        {"Smithsonian Astrophysical Observation", "SAO 23569"},
        {"Wilson Evans Batten Catalogue", "WEB 2593"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.02822939),
        dec: Angle.Degrees(+58.32627562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203376"},
        {"Hipparcos Number", "HIP 105275"},
        {"Smithsonian Astrophysical Observation", "SAO 33322"},
        {"Wilson Evans Batten Catalogue", "WEB 19120"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.85439336),
        dec: Angle.Degrees(+58.32649569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238937"},
        {"Hipparcos Number", "HIP 92069"},
        {"Smithsonian Astrophysical Observation", "SAO 31159"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.48011258),
        dec: Angle.Degrees(+58.32700027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9352"},
        {"Henry Draper 2", "HD 9353"},
        {"Hipparcos Number", "HIP 7251"},
        {"Geneva Identification System", "GEN# +1.00009352"},
        {"Smithsonian Astrophysical Observation", "SAO 22389"},
        {"Wilson Evans Batten Catalogue", "WEB 1558"},
    },
    visualMagnitude: 5.69,
    bvColour: 1.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.35711597),
        dec: Angle.Degrees(+58.32734523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237052"},
        {"Hipparcos Number", "HIP 14094"},
        {"Geneva Identification System", "GEN# +1.00237052"},
        {"Smithsonian Astrophysical Observation", "SAO 23768"},
        {"Wilson Evans Batten Catalogue", "WEB 2774"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.44128867),
        dec: Angle.Degrees(+58.32768265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1143"},
        {"Hipparcos Number", "HIP 1267"},
        {"Smithsonian Astrophysical Observation", "SAO 21258"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.97081136),
        dec: Angle.Degrees(+58.32931864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127147"},
        {"Hipparcos Number", "HIP 70709"},
        {"Geneva Identification System", "GEN# +1.00127147"},
        {"Smithsonian Astrophysical Observation", "SAO 29160"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.92782237),
        dec: Angle.Degrees(+58.33446940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193031"},
        {"Hipparcos Number", "HIP 99814"},
        {"Smithsonian Astrophysical Observation", "SAO 32395"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.78501259),
        dec: Angle.Degrees(+58.33462520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61577"},
        {"Hipparcos Number", "HIP 37630"},
        {"Smithsonian Astrophysical Observation", "SAO 26479"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.83254661),
        dec: Angle.Degrees(+58.33538203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237259"},
        {"Hipparcos Number", "HIP 20691"},
        {"Smithsonian Astrophysical Observation", "SAO 24600"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.48266207),
        dec: Angle.Degrees(+58.33630221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2543",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 443 AB"},
        {"Henry Draper", "HD 2851"},
        {"Hipparcos Number", "HIP 2543"},
        {"Geneva Identification System", "GEN# +1.00002851J"},
        {"Smithsonian Astrophysical Observation", "SAO 21498"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.09075830),
        dec: Angle.Degrees(+58.33864189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1727",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1727"},
        {"Geneva Identification System", "GEN# +8.01580017"},
    },
    visualMagnitude: 10.91,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.43958512),
        dec: Angle.Degrees(+58.33954239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208142"},
        {"Hipparcos Number", "HIP 107969"},
        {"Geneva Identification System", "GEN# +1.00208142"},
        {"Smithsonian Astrophysical Observation", "SAO 33829"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.10615461),
        dec: Angle.Degrees(+58.34359708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45181",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45181"},
    },
    visualMagnitude: 10.18,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.10557636),
        dec: Angle.Degrees(+58.34422000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236824"},
        {"Hipparcos Number", "HIP 7868"},
        {"Smithsonian Astrophysical Observation", "SAO 22508"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.30767827),
        dec: Angle.Degrees(+58.34529337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19288"},
        {"Hipparcos Number", "HIP 14620"},
        {"Geneva Identification System", "GEN# +1.00019288"},
        {"Smithsonian Astrophysical Observation", "SAO 23832"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.21094027),
        dec: Angle.Degrees(+58.34787739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 916",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 916"},
    },
    visualMagnitude: 9.50,
    bvColour: 1.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.83702751),
        dec: Angle.Degrees(+58.34986270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 233.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238711"},
        {"Hipparcos Number", "HIP 85709"},
        {"Smithsonian Astrophysical Observation", "SAO 30436"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.71790706),
        dec: Angle.Degrees(+58.35344857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157223"},
        {"Hipparcos Number", "HIP 84664"},
        {"Geneva Identification System", "GEN# +1.00157223"},
        {"Smithsonian Astrophysical Observation", "SAO 30337"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.62550854),
        dec: Angle.Degrees(+58.35854589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239789"},
        {"Hipparcos Number", "HIP 108026"},
        {"Geneva Identification System", "GEN# +1.00239789"},
        {"Smithsonian Astrophysical Observation", "SAO 33833"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.27135603),
        dec: Angle.Degrees(+58.36034433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18123"},
        {"Hipparcos Number", "HIP 13771"},
        {"Geneva Identification System", "GEN# +1.00018123"},
        {"Smithsonian Astrophysical Observation", "SAO 23723"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.30639970),
        dec: Angle.Degrees(+58.36123644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 152.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -302.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5813"},
        {"Hipparcos Number", "HIP 4713"},
        {"Geneva Identification System", "GEN# +1.00005813"},
        {"Smithsonian Astrophysical Observation", "SAO 21914"},
        {"Wilson Evans Batten Catalogue", "WEB 888"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.13646180),
        dec: Angle.Degrees(+58.36413569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113158",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16367 AB"},
        {"Henry Draper", "HD 240114"},
        {"Hipparcos Number", "HIP 113158"},
        {"Smithsonian Astrophysical Observation", "SAO 34948"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.72047133),
        dec: Angle.Degrees(+58.36536900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105535"},
        {"Hipparcos Number", "HIP 59237"},
        {"Smithsonian Astrophysical Observation", "SAO 28258"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.25098905),
        dec: Angle.Degrees(+58.36579345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187317"},
        {"Hipparcos Number", "HIP 97277"},
        {"Geneva Identification System", "GEN# +1.00187317"},
        {"Smithsonian Astrophysical Observation", "SAO 31984"},
        {"Wilson Evans Batten Catalogue", "WEB 17084"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.55904520),
        dec: Angle.Degrees(+58.36674068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110913"},
        {"Hipparcos Number", "HIP 62202"},
        {"Smithsonian Astrophysical Observation", "SAO 28502"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.23095307),
        dec: Angle.Degrees(+58.36748884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75229"},
        {"Hipparcos Number", "HIP 43492"},
        {"Smithsonian Astrophysical Observation", "SAO 27016"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.87668263),
        dec: Angle.Degrees(+58.36801973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237405"},
        {"Hipparcos Number", "HIP 26461"},
        {"Smithsonian Astrophysical Observation", "SAO 25279"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.43603235),
        dec: Angle.Degrees(+58.36873564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94011"},
        {"Hipparcos Number", "HIP 53127"},
        {"Smithsonian Astrophysical Observation", "SAO 27804"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.01884941),
        dec: Angle.Degrees(+58.37014027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -249.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112798"},
        {"Hipparcos Number", "HIP 63308"},
        {"Smithsonian Astrophysical Observation", "SAO 28586"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.61172726),
        dec: Angle.Degrees(+58.37373604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238052"},
        {"Hipparcos Number", "HIP 57889"},
        {"Fundamental Katalog 5th Edition", "FK5 5045"},
        {"Smithsonian Astrophysical Observation", "SAO 28173"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.09242746),
        dec: Angle.Degrees(+58.37933188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105896"},
        {"Hipparcos Number", "HIP 59408"},
        {"Geneva Identification System", "GEN# +1.00105896"},
        {"Smithsonian Astrophysical Observation", "SAO 28284"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.80115264),
        dec: Angle.Degrees(+58.38095724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63311",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63311"},
        {"Smithsonian Astrophysical Observation", "SAO 28588"},
    },
    visualMagnitude: 10.46,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.61930103),
        dec: Angle.Degrees(+58.38144332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67448"},
        {"Hipparcos Number", "HIP 40067"},
        {"Smithsonian Astrophysical Observation", "SAO 26713"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.77046321),
        dec: Angle.Degrees(+58.38144697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156559"},
        {"Hipparcos Number", "HIP 84352"},
        {"Geneva Identification System", "GEN# +1.00156559"},
        {"Smithsonian Astrophysical Observation", "SAO 30313"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.68258412),
        dec: Angle.Degrees(+58.38396411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208834"},
        {"Hipparcos Number", "HIP 108355"},
        {"Smithsonian Astrophysical Observation", "SAO 33904"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.27232426),
        dec: Angle.Degrees(+58.38642499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125259"},
        {"Hipparcos Number", "HIP 69721"},
        {"Smithsonian Astrophysical Observation", "SAO 29076"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.07276890),
        dec: Angle.Degrees(+58.38942079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30166"},
        {"Hipparcos Number", "HIP 22339"},
        {"Smithsonian Astrophysical Observation", "SAO 24840"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.16021138),
        dec: Angle.Degrees(+58.38986536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237980"},
        {"Hipparcos Number", "HIP 54972"},
        {"Smithsonian Astrophysical Observation", "SAO 27963"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.84525409),
        dec: Angle.Degrees(+58.40168591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79927"},
        {"Hipparcos Number", "HIP 45718"},
        {"Smithsonian Astrophysical Observation", "SAO 27207"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.80052651),
        dec: Angle.Degrees(+58.40317385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -161.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -130.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110988",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15987 C"},
        {"Henry Draper", "HD 213307"},
        {"Hipparcos Number", "HIP 110988"},
        {"Geneva Identification System", "GEN# +1.00213307"},
        {"Smithsonian Astrophysical Observation", "SAO 34506"},
        {"Wilson Evans Batten Catalogue", "WEB 19874"},
    },
    visualMagnitude: 6.31,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.28845910),
        dec: Angle.Degrees(+58.40408865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15752"},
        {"Hipparcos Number", "HIP 11953"},
        {"Geneva Identification System", "GEN# +1.00015752"},
        {"Smithsonian Astrophysical Observation", "SAO 23434"},
        {"Wilson Evans Batten Catalogue", "WEB 2470"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.54768913),
        dec: Angle.Degrees(+58.40549454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108844"},
        {"Hipparcos Number", "HIP 60978"},
        {"Fundamental Katalog 5th Edition", "FK5 467"},
        {"Geneva Identification System", "GEN# +1.00108844"},
        {"Renson", "Renson 31590"},
        {"Smithsonian Astrophysical Observation", "SAO 28405"},
        {"Wilson Evans Batten Catalogue", "WEB 10855"},
    },
    visualMagnitude: 5.37,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.48916244),
        dec: Angle.Degrees(+58.40552660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 88.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35307",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35307"},
    },
    visualMagnitude: 11.91,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.40100933),
        dec: Angle.Degrees(+58.40577942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212136"},
        {"Hipparcos Number", "HIP 110314"},
        {"Geneva Identification System", "GEN# +1.00212136"},
        {"Smithsonian Astrophysical Observation", "SAO 34338"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.16155598),
        dec: Angle.Degrees(+58.40985302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89846"},
        {"Hipparcos Number", "HIP 50900"},
        {"Geneva Identification System", "GEN# +1.00089846"},
        {"Smithsonian Astrophysical Observation", "SAO 27630"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.91053489),
        dec: Angle.Degrees(+58.41031941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101892"},
        {"Hipparcos Number", "HIP 57209"},
        {"Geneva Identification System", "GEN# +1.00101892"},
        {"Smithsonian Astrophysical Observation", "SAO 28115"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.96219201),
        dec: Angle.Degrees(+58.41107106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208714"},
        {"Hipparcos Number", "HIP 108287"},
        {"Geneva Identification System", "GEN# +1.00208714"},
        {"Smithsonian Astrophysical Observation", "SAO 33890"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.07986496),
        dec: Angle.Degrees(+58.41224088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6745"},
        {"Hipparcos Number", "HIP 5419"},
        {"Smithsonian Astrophysical Observation", "SAO 22036"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.31341655),
        dec: Angle.Degrees(+58.41328215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110991",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15987 A"},
        {"Henry Draper", "HD 213306"},
        {"Hipparcos Number", "HIP 110991"},
        {"Celescope Catalog", "CEL 5480"},
        {"Fundamental Katalog 5th Edition", "FK5 847"},
        {"Geneva Identification System", "GEN# +1.00213306"},
        {"Smithsonian Astrophysical Observation", "SAO 34508"},
        {"Wilson Evans Batten Catalogue", "WEB 19873"},
    },
    visualMagnitude: 4.07,
    bvColour: 0.778,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.29269975),
        dec: Angle.Degrees(+58.41518990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198343"},
        {"Hipparcos Number", "HIP 102558"},
        {"Geneva Identification System", "GEN# +1.00198343"},
        {"Smithsonian Astrophysical Observation", "SAO 32890"},
    },
    visualMagnitude: 6.68,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.75442469),
        dec: Angle.Degrees(+58.41677752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30679",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5036 A"},
        {"Henry Draper", "HD 44708"},
        {"Hipparcos Number", "HIP 30679"},
        {"Geneva Identification System", "GEN# +1.00044708A"},
        {"Smithsonian Astrophysical Observation", "SAO 25733"},
        {"Wilson Evans Batten Catalogue", "WEB 6118"},
    },
    visualMagnitude: 5.21,
    bvColour: 1.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.70366348),
        dec: Angle.Degrees(+58.41741346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70211",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70211"},
    },
    visualMagnitude: 11.91,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.47491820),
        dec: Angle.Degrees(+58.41765400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -138.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -170.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49269"},
        {"Hipparcos Number", "HIP 32890"},
        {"Geneva Identification System", "GEN# +1.00049269"},
        {"Smithsonian Astrophysical Observation", "SAO 25985"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.79629798),
        dec: Angle.Degrees(+58.41769832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30661",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5036 C"},
        {"Henry Draper", "HD 44647"},
        {"Hipparcos Number", "HIP 30661"},
        {"Geneva Identification System", "GEN# +1.00044647"},
        {"Geneva Identification System 2", "GEN# +1.00044708C"},
        {"Smithsonian Astrophysical Observation", "SAO 25732"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.65307555),
        dec: Angle.Degrees(+58.41838905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238913"},
        {"Hipparcos Number", "HIP 91371"},
        {"Smithsonian Astrophysical Observation", "SAO 31080"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.792,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.52469012),
        dec: Angle.Degrees(+58.41844990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 275.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 88.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38285"},
        {"Hipparcos Number", "HIP 27414"},
        {"Smithsonian Astrophysical Observation", "SAO 25378"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.08037846),
        dec: Angle.Degrees(+58.41999186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213224"},
        {"Hipparcos Number", "HIP 110925"},
        {"Geneva Identification System", "GEN# +1.00213224"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.10813011),
        dec: Angle.Degrees(+58.42229331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33449",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5586 AB"},
        {"Henry Draper", "HD 50522"},
        {"Hipparcos Number", "HIP 33449"},
        {"Geneva Identification System", "GEN# +1.00050522"},
        {"Smithsonian Astrophysical Observation", "SAO 26051"},
        {"Wilson Evans Batten Catalogue", "WEB 6726"},
    },
    visualMagnitude: 4.35,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.31916052),
        dec: Angle.Degrees(+58.42305973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128091"},
        {"Hipparcos Number", "HIP 71129"},
        {"Geneva Identification System", "GEN# +1.00128091"},
        {"Smithsonian Astrophysical Observation", "SAO 29193"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.19727671),
        dec: Angle.Degrees(+58.42328315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12953"},
        {"Hipparcos Number", "HIP 9990"},
        {"Geneva Identification System", "GEN# +1.00012953"},
        {"Smithsonian Astrophysical Observation", "SAO 22959"},
        {"Wilson Evans Batten Catalogue", "WEB 2092"},
    },
    visualMagnitude: 5.66,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.16908619),
        dec: Angle.Degrees(+58.42360489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39555",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6548 AB"},
        {"Henry Draper", "HD 66045"},
        {"Hipparcos Number", "HIP 39555"},
        {"Smithsonian Astrophysical Observation", "SAO 26652"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.24296341),
        dec: Angle.Degrees(+58.42395632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1213",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1213"},
        {"Geneva Identification System", "GEN# +0.05700042"},
        {"Wilson Evans Batten Catalogue", "WEB 221"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.807,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.79089934),
        dec: Angle.Degrees(+58.42429592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44473"},
        {"Hipparcos Number", "HIP 30578"},
        {"Geneva Identification System", "GEN# +1.00044473"},
        {"Smithsonian Astrophysical Observation", "SAO 25717"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.40955686),
        dec: Angle.Degrees(+58.42559635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214369"},
        {"Hipparcos Number", "HIP 111592"},
        {"Geneva Identification System", "GEN# +1.00214369"},
        {"Smithsonian Astrophysical Observation", "SAO 34614"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.795,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.11486071),
        dec: Angle.Degrees(+58.42610395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215286"},
        {"Hipparcos Number", "HIP 112141"},
        {"Smithsonian Astrophysical Observation", "SAO 34728"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.72936415),
        dec: Angle.Degrees(+58.42654403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65278",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65278"},
    },
    visualMagnitude: 10.87,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.68570968),
        dec: Angle.Degrees(+58.42679106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236535"},
        {"Hipparcos Number", "HIP 3819"},
        {"Smithsonian Astrophysical Observation", "SAO 21734"},
        {"Wilson Evans Batten Catalogue", "WEB 677"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.26240999),
        dec: Angle.Degrees(+58.42930739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238008"},
        {"Hipparcos Number", "HIP 56259"},
        {"Smithsonian Astrophysical Observation", "SAO 28047"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.98116025),
        dec: Angle.Degrees(+58.43081278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141173"},
        {"Hipparcos Number", "HIP 77110"},
        {"Fundamental Katalog 5th Edition", "FK5 5394"},
        {"Geneva Identification System", "GEN# +1.00141173"},
        {"Smithsonian Astrophysical Observation", "SAO 29643"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.17551741),
        dec: Angle.Degrees(+58.43353422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43112",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43112"},
    },
    visualMagnitude: 10.46,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.70434110),
        dec: Angle.Degrees(+58.43454701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236894"},
        {"Hipparcos Number", "HIP 8725"},
        {"Geneva Identification System", "GEN# +1.00236894"},
        {"Smithsonian Astrophysical Observation", "SAO 22694"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.05712603),
        dec: Angle.Degrees(+58.43509016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 518",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 61 AB"},
        {"Henry Draper", "HD 123"},
        {"Hipparcos Number", "HIP 518"},
        {"Geneva Identification System", "GEN# +1.00000123"},
        {"Smithsonian Astrophysical Observation", "SAO 21085"},
        {"Wilson Evans Batten Catalogue", "WEB 85"},
    },
    visualMagnitude: 5.98,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.56474395),
        dec: Angle.Degrees(+58.43668966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 247.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84142"},
        {"Hipparcos Number", "HIP 47840"},
        {"Smithsonian Astrophysical Observation", "SAO 27371"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.26552860),
        dec: Angle.Degrees(+58.43921247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236948"},
        {"Hipparcos Number", "HIP 9928"},
        {"Smithsonian Astrophysical Observation", "SAO 22945"},
        {"Wilson Evans Batten Catalogue", "WEB 2081"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.95200540),
        dec: Angle.Degrees(+58.44354254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64454",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8821 BC"},
        {"Hipparcos Number", "HIP 64454"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.837,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.16752866),
        dec: Angle.Degrees(+58.44468819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78404",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78404"},
    },
    visualMagnitude: 11.19,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.08998885),
        dec: Angle.Degrees(+58.44520190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64451",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8821 A"},
        {"Henry Draper", "HD 114913"},
        {"Hipparcos Number", "HIP 64451"},
        {"Geneva Identification System", "GEN# +1.00114913"},
        {"Smithsonian Astrophysical Observation", "SAO 28673"},
        {"Wilson Evans Batten Catalogue", "WEB 11393"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.15655315),
        dec: Angle.Degrees(+58.44906380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80102",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80102"},
    },
    visualMagnitude: 12.79,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.27396495),
        dec: Angle.Degrees(+58.45077265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10898"},
        {"Hipparcos Number", "HIP 8415"},
        {"Geneva Identification System", "GEN# +1.00010898"},
        {"Smithsonian Astrophysical Observation", "SAO 22639"},
        {"Wilson Evans Batten Catalogue", "WEB 1793"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.14596356),
        dec: Angle.Degrees(+58.45783640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237222"},
        {"Hipparcos Number", "HIP 19447"},
        {"Smithsonian Astrophysical Observation", "SAO 24442"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.47174185),
        dec: Angle.Degrees(+58.46000511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11870",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1933 AB"},
        {"Henry Draper", "HD 15641"},
        {"Hipparcos Number", "HIP 11870"},
        {"Smithsonian Astrophysical Observation", "SAO 23419"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.28606070),
        dec: Angle.Degrees(+58.46226087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154081"},
        {"Hipparcos Number", "HIP 83168"},
        {"Geneva Identification System", "GEN# +1.00154081"},
        {"Smithsonian Astrophysical Observation", "SAO 30196"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.95870705),
        dec: Angle.Degrees(+58.46255286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237268"},
        {"Hipparcos Number", "HIP 20938"},
        {"Smithsonian Astrophysical Observation", "SAO 24643"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.34302735),
        dec: Angle.Degrees(+58.46551740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11093"},
        {"Hipparcos Number", "HIP 8586"},
        {"Smithsonian Astrophysical Observation", "SAO 22669"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.71453633),
        dec: Angle.Degrees(+58.46756619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179556"},
        {"Hipparcos Number", "HIP 94132"},
        {"Smithsonian Astrophysical Observation", "SAO 31438"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.42615471),
        dec: Angle.Degrees(+58.46838915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20787"},
        {"Hipparcos Number", "HIP 15818"},
        {"Geneva Identification System", "GEN# +1.00020787"},
        {"Smithsonian Astrophysical Observation", "SAO 23999"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.94629080),
        dec: Angle.Degrees(+58.46944049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237865"},
        {"Hipparcos Number", "HIP 49467"},
    },
    visualMagnitude: 9.77,
    bvColour: 1.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.48323830),
        dec: Angle.Degrees(+58.47078267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103675"},
        {"Hipparcos Number", "HIP 58216"},
        {"Smithsonian Astrophysical Observation", "SAO 28193"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.09371671),
        dec: Angle.Degrees(+58.47646158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146990"},
        {"Hipparcos Number", "HIP 79697"},
        {"Geneva Identification System", "GEN# +1.00146990"},
        {"Smithsonian Astrophysical Observation", "SAO 29861"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.97730556),
        dec: Angle.Degrees(+58.47894317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238878"},
        {"Hipparcos Number", "HIP 90463"},
        {"Smithsonian Astrophysical Observation", "SAO 30986"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.89221241),
        dec: Angle.Degrees(+58.47936655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215907"},
        {"Hipparcos Number", "HIP 112508"},
        {"Celescope Catalog", "CEL 5526"},
        {"Geneva Identification System", "GEN# +1.00215907"},
        {"Renson", "Renson 59630"},
        {"Smithsonian Astrophysical Observation", "SAO 34824"},
        {"Wilson Evans Batten Catalogue", "WEB 20063"},
    },
    visualMagnitude: 6.33,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.84679175),
        dec: Angle.Degrees(+58.48301254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98618"},
        {"Hipparcos Number", "HIP 55459"},
        {"Geneva Identification System", "GEN# +1.00098618"},
        {"Smithsonian Astrophysical Observation", "SAO 27996"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.37093239),
        dec: Angle.Degrees(+58.48429125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240153"},
        {"Hipparcos Number", "HIP 113577"},
        {"Smithsonian Astrophysical Observation", "SAO 35046"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.07585595),
        dec: Angle.Degrees(+58.48558369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 583"},
        {"Hipparcos Number", "HIP 848"},
        {"Geneva Identification System", "GEN# +1.00000583"},
        {"Smithsonian Astrophysical Observation", "SAO 21161"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.60083995),
        dec: Angle.Degrees(+58.48950539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239393"},
        {"Hipparcos Number", "HIP 100564"},
        {"Smithsonian Astrophysical Observation", "SAO 32523"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.87650662),
        dec: Angle.Degrees(+58.49247368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3688",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3688"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.81923668),
        dec: Angle.Degrees(+58.49256983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237148"},
        {"Hipparcos Number", "HIP 16412"},
        {"Geneva Identification System", "GEN# +1.00237148"},
        {"Smithsonian Astrophysical Observation", "SAO 24072"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.83662242),
        dec: Angle.Degrees(+58.49397494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124793"},
        {"Hipparcos Number", "HIP 69494"},
        {"Smithsonian Astrophysical Observation", "SAO 29050"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.41987699),
        dec: Angle.Degrees(+58.49678011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121879"},
        {"Hipparcos Number", "HIP 68089"},
        {"Smithsonian Astrophysical Observation", "SAO 28939"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.11203218),
        dec: Angle.Degrees(+58.49835836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239738"},
        {"Hipparcos Number", "HIP 107123"},
        {"Geneva Identification System", "GEN# +1.00239738"},
        {"Geneva Identification System 2", "GEN# +4.35371036"},
        {"Smithsonian Astrophysical Observation", "SAO 33670"},
    },
    visualMagnitude: 8.80,
    bvColour: -0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.49389476),
        dec: Angle.Degrees(+58.50007013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239776"},
        {"Hipparcos Number", "HIP 107730"},
        {"Smithsonian Astrophysical Observation", "SAO 33789"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.35124537),
        dec: Angle.Degrees(+58.50133509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239777"},
        {"Hipparcos Number", "HIP 107732"},
        {"Smithsonian Astrophysical Observation", "SAO 33790"},
    },
    visualMagnitude: 10.54,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.35673106),
        dec: Angle.Degrees(+58.50267687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136577"},
        {"Hipparcos Number", "HIP 74935"},
        {"Smithsonian Astrophysical Observation", "SAO 29479"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.68961654),
        dec: Angle.Degrees(+58.50344231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240262"},
        {"Hipparcos Number", "HIP 115229"},
        {"Smithsonian Astrophysical Observation", "SAO 35335"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.08698335),
        dec: Angle.Degrees(+58.51688942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240039"},
        {"Hipparcos Number", "HIP 112278"},
        {"Smithsonian Astrophysical Observation", "SAO 34750"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.13080754),
        dec: Angle.Degrees(+58.51950182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201047"},
        {"Hipparcos Number", "HIP 104038"},
        {"Smithsonian Astrophysical Observation", "SAO 33116"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.16544846),
        dec: Angle.Degrees(+58.52057844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9291",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9291"},
    },
    visualMagnitude: 12.21,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.84648007),
        dec: Angle.Degrees(+58.52160775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 321.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -195.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26581"},
        {"Hipparcos Number", "HIP 19861"},
        {"Geneva Identification System", "GEN# +1.00026581"},
        {"Smithsonian Astrophysical Observation", "SAO 24499"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.88417010),
        dec: Angle.Degrees(+58.52280199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 186.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -218.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238600"},
        {"Hipparcos Number", "HIP 81862"},
        {"Smithsonian Astrophysical Observation", "SAO 30064"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.901,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.80801734),
        dec: Angle.Degrees(+58.52444653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -230.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59307"},
        {"Hipparcos Number", "HIP 36695"},
        {"Smithsonian Astrophysical Observation", "SAO 26397"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.22156431),
        dec: Angle.Degrees(+58.52520841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238410"},
        {"Hipparcos Number", "HIP 73176"},
        {"Smithsonian Astrophysical Observation", "SAO 29355"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.33656480),
        dec: Angle.Degrees(+58.52556198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239162"},
        {"Hipparcos Number", "HIP 96582"},
        {"Smithsonian Astrophysical Observation", "SAO 31842"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.51433083),
        dec: Angle.Degrees(+58.52583571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215209"},
        {"Hipparcos Number", "HIP 112108"},
        {"Smithsonian Astrophysical Observation", "SAO 34720"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.61063548),
        dec: Angle.Degrees(+58.52589245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53227"},
        {"Hipparcos Number", "HIP 34389"},
        {"Geneva Identification System", "GEN# +1.00053227"},
        {"Renson", "Renson 14640"},
        {"Smithsonian Astrophysical Observation", "SAO 26162"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.95799281),
        dec: Angle.Degrees(+58.52833400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239419"},
        {"Hipparcos Number", "HIP 100854"},
        {"Smithsonian Astrophysical Observation", "SAO 32600"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.73721272),
        dec: Angle.Degrees(+58.52836832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84762",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10487 AB"},
        {"Henry Draper", "HD 157410"},
        {"Hipparcos Number", "HIP 84762"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.88233401),
        dec: Angle.Degrees(+58.52918162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11716",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11716"},
    },
    visualMagnitude: 9.88,
    bvColour: 1.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.80720316),
        dec: Angle.Degrees(+58.53150197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 398",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 36 A"},
        {"Henry Draper", "HD 225257"},
        {"Hipparcos Number", "HIP 398"},
        {"Smithsonian Astrophysical Observation", "SAO 21062"},
        {"Wilson Evans Batten Catalogue", "WEB 58"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.22902690),
        dec: Angle.Degrees(+58.53217392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180024"},
        {"Hipparcos Number", "HIP 94288"},
        {"Smithsonian Astrophysical Observation", "SAO 31467"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.87569879),
        dec: Angle.Degrees(+58.53384555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212566"},
        {"Hipparcos Number", "HIP 110561"},
        {"Geneva Identification System", "GEN# +1.00212566"},
        {"Smithsonian Astrophysical Observation", "SAO 34405"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.95905407),
        dec: Angle.Degrees(+58.53452258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120874"},
        {"Hipparcos Number", "HIP 67548"},
        {"Geneva Identification System", "GEN# +1.00120874"},
        {"Smithsonian Astrophysical Observation", "SAO 28901"},
        {"Wilson Evans Batten Catalogue", "WEB 11879"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.61569712),
        dec: Angle.Degrees(+58.53942814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213232"},
        {"Hipparcos Number", "HIP 110933"},
        {"Geneva Identification System", "GEN# +1.00213232"},
        {"Renson", "Renson 59100"},
        {"Smithsonian Astrophysical Observation", "SAO 34493"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.14374930),
        dec: Angle.Degrees(+58.53994319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83205"},
        {"Hipparcos Number", "HIP 47364"},
        {"Smithsonian Astrophysical Observation", "SAO 27325"},
        {"Wilson Evans Batten Catalogue", "WEB 8896"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.75308289),
        dec: Angle.Degrees(+58.54817932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115990",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16795 AB"},
        {"Henry Draper", "HD 221253"},
        {"Hipparcos Number", "HIP 115990"},
        {"Celescope Catalog", "CEL 5623"},
        {"Geneva Identification System", "GEN# +1.00221253J"},
        {"Smithsonian Astrophysical Observation", "SAO 35478"},
        {"Wilson Evans Batten Catalogue", "WEB 20511"},
    },
    visualMagnitude: 4.89,
    bvColour: -0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.50799782),
        dec: Angle.Degrees(+58.54890978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124319"},
        {"Hipparcos Number", "HIP 69295"},
        {"Smithsonian Astrophysical Observation", "SAO 29033"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.75555792),
        dec: Angle.Degrees(+58.54912267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26455",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4197 AB"},
        {"Henry Draper", "HD 36754"},
        {"Hipparcos Number", "HIP 26455"},
        {"Fundamental Katalog 5th Edition", "FK5 4511"},
        {"Smithsonian Astrophysical Observation", "SAO 25278"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.41747680),
        dec: Angle.Degrees(+58.54922679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236995"},
        {"Hipparcos Number", "HIP 12840"},
        {"Geneva Identification System", "GEN# +1.00236995"},
        {"Smithsonian Astrophysical Observation", "SAO 23582"},
        {"Wilson Evans Batten Catalogue", "WEB 2612"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.26460915),
        dec: Angle.Degrees(+58.55126790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2329"},
        {"Hipparcos Number", "HIP 2191"},
        {"Geneva Identification System", "GEN# +1.00002329"},
        {"Smithsonian Astrophysical Observation", "SAO 21415"},
        {"Wilson Evans Batten Catalogue", "WEB 408"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.91880012),
        dec: Angle.Degrees(+58.55390797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114160",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114160"},
        {"Wilson Evans Batten Catalogue", "WEB 20275"},
    },
    visualMagnitude: 9.77,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.79202634),
        dec: Angle.Degrees(+58.55420938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97386",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97386"},
    },
    visualMagnitude: 12.67,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.90103407),
        dec: Angle.Degrees(+58.55561932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154355"},
        {"Hipparcos Number", "HIP 83305"},
        {"Geneva Identification System", "GEN# +1.00154355"},
        {"Smithsonian Astrophysical Observation", "SAO 30209"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.37985305),
        dec: Angle.Degrees(+58.55640030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105440"},
        {"Hipparcos Number", "HIP 59188"},
        {"Geneva Identification System", "GEN# +1.00105440"},
        {"Smithsonian Astrophysical Observation", "SAO 28255"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.07604728),
        dec: Angle.Degrees(+58.55673758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25906"},
        {"Hipparcos Number", "HIP 19408"},
        {"Geneva Identification System", "GEN# +1.00025906"},
        {"Smithsonian Astrophysical Observation", "SAO 24437"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.35189664),
        dec: Angle.Degrees(+58.56014860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13476"},
        {"Hipparcos Number", "HIP 10379"},
        {"Geneva Identification System", "GEN# +1.00013476"},
        {"Smithsonian Astrophysical Observation", "SAO 23044"},
        {"Wilson Evans Batten Catalogue", "WEB 2172"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.42338097),
        dec: Angle.Degrees(+58.56058745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5235"},
        {"Hipparcos Number", "HIP 4284"},
        {"Wilson Evans Batten Catalogue", "WEB 764"},
    },
    visualMagnitude: 9.60,
    bvColour: 2.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.72439770),
        dec: Angle.Degrees(+58.56365151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217944"},
        {"Hipparcos Number", "HIP 113852"},
        {"Geneva Identification System", "GEN# +1.00217944"},
        {"Smithsonian Astrophysical Observation", "SAO 35103"},
        {"Wilson Evans Batten Catalogue", "WEB 20225"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.898,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.83887885),
        dec: Angle.Degrees(+58.56387586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144284"},
        {"Hipparcos Number", "HIP 78527"},
        {"Cincinnati Publication", "Ci 20 961"},
        {"Fundamental Katalog 5th Edition", "FK5 598"},
        {"Geneva Identification System", "GEN# +1.00144284"},
        {"Smithsonian Astrophysical Observation", "SAO 29765"},
        {"Wilson Evans Batten Catalogue", "WEB 13275"},
    },
    visualMagnitude: 4.01,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.47376560),
        dec: Angle.Degrees(+58.56443739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -320.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 334.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3933"},
        {"Hipparcos Number", "HIP 3329"},
        {"Smithsonian Astrophysical Observation", "SAO 21641"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.893,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.61171549),
        dec: Angle.Degrees(+58.57007242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16653"},
        {"Hipparcos Number", "HIP 12649"},
        {"Smithsonian Astrophysical Observation", "SAO 23543"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.62582185),
        dec: Angle.Degrees(+58.57259407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238197"},
        {"Hipparcos Number", "HIP 64185"},
        {"Smithsonian Astrophysical Observation", "SAO 28651"},
    },
    visualMagnitude: 9.82,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.31833376),
        dec: Angle.Degrees(+58.57582793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -221.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -253.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14528"},
        {"Hipparcos Number", "HIP 11093"},
        {"Geneva Identification System", "GEN# +1.00014528"},
        {"Smithsonian Astrophysical Observation", "SAO 23261"},
    },
    visualMagnitude: 9.69,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.71546893),
        dec: Angle.Degrees(+58.58651389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184467"},
        {"Hipparcos Number", "HIP 95995"},
        {"Cincinnati Publication", "Ci 20 1157"},
        {"Geneva Identification System", "GEN# +1.00184467"},
        {"Smithsonian Astrophysical Observation", "SAO 31745"},
        {"Wilson Evans Batten Catalogue", "WEB 16815"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.859,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.78560166),
        dec: Angle.Degrees(+58.58697665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -510.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -397.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83491"},
        {"Hipparcos Number", "HIP 47496"},
        {"Smithsonian Astrophysical Observation", "SAO 27335"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.24528246),
        dec: Angle.Degrees(+58.58931348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236378"},
        {"Hipparcos Number", "HIP 1590"},
        {"Smithsonian Astrophysical Observation", "SAO 21304"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.97019511),
        dec: Angle.Degrees(+58.59222660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32547"},
        {"Hipparcos Number", "HIP 23836"},
        {"Geneva Identification System", "GEN# +1.00032547"},
        {"Smithsonian Astrophysical Observation", "SAO 25027"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.86882412),
        dec: Angle.Degrees(+58.59278773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28368",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28368"},
    },
    visualMagnitude: 10.25,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.90726509),
        dec: Angle.Degrees(+58.59362838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -248.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237244"},
        {"Hipparcos Number", "HIP 20251"},
        {"Smithsonian Astrophysical Observation", "SAO 24543"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.774,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.09328483),
        dec: Angle.Degrees(+58.59433356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154063"},
        {"Hipparcos Number", "HIP 83160"},
        {"Geneva Identification System", "GEN# +1.00154063"},
        {"Smithsonian Astrophysical Observation", "SAO 30194"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.92779587),
        dec: Angle.Degrees(+58.59768238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27649"},
        {"Hipparcos Number", "HIP 20615"},
        {"Smithsonian Astrophysical Observation", "SAO 24590"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.24191658),
        dec: Angle.Degrees(+58.59827391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239938"},
        {"Hipparcos Number", "HIP 110459"},
        {"Smithsonian Astrophysical Observation", "SAO 34374"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.61211843),
        dec: Angle.Degrees(+58.60071512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19089"},
        {"Hipparcos Number", "HIP 14482"},
        {"Smithsonian Astrophysical Observation", "SAO 23810"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.73867390),
        dec: Angle.Degrees(+58.60082867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238386"},
        {"Hipparcos Number", "HIP 71993"},
        {"Smithsonian Astrophysical Observation", "SAO 29257"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.85127302),
        dec: Angle.Degrees(+58.60122323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50761"},
        {"Hipparcos Number", "HIP 33542"},
        {"Smithsonian Astrophysical Observation", "SAO 26067"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.55944785),
        dec: Angle.Degrees(+58.60216200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44536"},
        {"Hipparcos Number", "HIP 30605"},
        {"Geneva Identification System", "GEN# +1.00044536"},
        {"Smithsonian Astrophysical Observation", "SAO 25719"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.49230327),
        dec: Angle.Degrees(+58.60323104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214394"},
        {"Hipparcos Number", "HIP 111595"},
        {"Smithsonian Astrophysical Observation", "SAO 34616"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.12686122),
        dec: Angle.Degrees(+58.60455357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72113"},
        {"Hipparcos Number", "HIP 42019"},
        {"Fundamental Katalog 5th Edition", "FK5 2668"},
        {"Geneva Identification System", "GEN# +1.00072113"},
        {"Smithsonian Astrophysical Observation", "SAO 26907"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.47954751),
        dec: Angle.Degrees(+58.60731324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105091",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14832 A"},
        {"Henry Draper", "HD 203025"},
        {"Hipparcos Number", "HIP 105091"},
        {"Geneva Identification System", "GEN# +1.00203025J"},
        {"Smithsonian Astrophysical Observation", "SAO 33288"},
        {"Wilson Evans Batten Catalogue", "WEB 19089"},
        {"Wilson Evans Batten Catalogue 2", "WEB 19088"},
    },
    visualMagnitude: 6.42,
    bvColour: 0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.32830925),
        dec: Angle.Degrees(+58.61149119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177040"},
        {"Hipparcos Number", "HIP 93240"},
        {"Smithsonian Astrophysical Observation", "SAO 31308"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.87920116),
        dec: Angle.Degrees(+58.61177311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115749"},
        {"Hipparcos Number", "HIP 64884"},
        {"Smithsonian Astrophysical Observation", "SAO 28712"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.50081583),
        dec: Angle.Degrees(+58.61224767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237021"},
        {"Hipparcos Number", "HIP 13472"},
        {"Smithsonian Astrophysical Observation", "SAO 23677"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.37628016),
        dec: Angle.Degrees(+58.61229958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111250",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111250"},
        {"Wilson Evans Batten Catalogue", "WEB 19904"},
    },
    visualMagnitude: 10.58,
    bvColour: 2.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.11182764),
        dec: Angle.Degrees(+58.61827166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88016"},
        {"Hipparcos Number", "HIP 49843"},
        {"Smithsonian Astrophysical Observation", "SAO 27546"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.65678332),
        dec: Angle.Degrees(+58.61833864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127760"},
        {"Hipparcos Number", "HIP 70971"},
        {"Geneva Identification System", "GEN# +1.00127760"},
        {"Smithsonian Astrophysical Observation", "SAO 29179"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.75091032),
        dec: Angle.Degrees(+58.61918405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24678"},
        {"Hipparcos Number", "HIP 18567"},
        {"Geneva Identification System", "GEN# +1.00024678"},
        {"Smithsonian Astrophysical Observation", "SAO 24320"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.62268568),
        dec: Angle.Degrees(+58.61947219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105259",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14864 A"},
        {"Henry Draper", "HD 203338"},
        {"Hipparcos Number", "HIP 105259"},
        {"Smithsonian Astrophysical Observation", "SAO 33318"},
        {"Wilson Evans Batten Catalogue", "WEB 19118"},
    },
    visualMagnitude: 5.51,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.81538311),
        dec: Angle.Degrees(+58.62350994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240049"},
        {"Hipparcos Number", "HIP 112370"},
        {"Smithsonian Astrophysical Observation", "SAO 34777"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.40143516),
        dec: Angle.Degrees(+58.62569374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165459"},
        {"Hipparcos Number", "HIP 88349"},
        {"Geneva Identification System", "GEN# +1.00165459"},
        {"Smithsonian Astrophysical Observation", "SAO 30711"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.62814638),
        dec: Angle.Degrees(+58.62720729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7963",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1334 A"},
        {"Henry Draper", "HD 10293"},
        {"Hipparcos Number", "HIP 7963"},
        {"Geneva Identification System", "GEN# +1.00010293A"},
        {"Geneva Identification System 2", "GEN# +1.10010293"},
        {"Smithsonian Astrophysical Observation", "SAO 22520"},
        {"Wilson Evans Batten Catalogue", "WEB 1706"},
    },
    visualMagnitude: 6.35,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.57369215),
        dec: Angle.Degrees(+58.62775870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25438",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25438"},
        {"Smithsonian Astrophysical Observation", "SAO 25191"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.60272129),
        dec: Angle.Degrees(+58.63156640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240457"},
        {"Hipparcos Number", "HIP 118124"},
        {"Smithsonian Astrophysical Observation", "SAO 35923"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.39944085),
        dec: Angle.Degrees(+58.63226607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82306"},
        {"Hipparcos Number", "HIP 46895"},
        {"Smithsonian Astrophysical Observation", "SAO 27290"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.35507386),
        dec: Angle.Degrees(+58.63341590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236595"},
        {"Hipparcos Number", "HIP 4680"},
        {"Smithsonian Astrophysical Observation", "SAO 21905"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.03911826),
        dec: Angle.Degrees(+58.63572192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13865"},
        {"Hipparcos Number", "HIP 10660"},
        {"Geneva Identification System", "GEN# +1.00013865"},
        {"Smithsonian Astrophysical Observation", "SAO 23123"},
        {"Wilson Evans Batten Catalogue", "WEB 2242"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.29947418),
        dec: Angle.Degrees(+58.63619819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30792"},
        {"Hipparcos Number", "HIP 22795"},
        {"Smithsonian Astrophysical Observation", "SAO 24897"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.56182153),
        dec: Angle.Degrees(+58.63706663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7559",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1262 A"},
        {"Henry Draper", "HD 9812"},
        {"Hipparcos Number", "HIP 7559"},
        {"Geneva Identification System", "GEN# +1.10009812"},
        {"Smithsonian Astrophysical Observation", "SAO 22441"},
        {"Wilson Evans Batten Catalogue", "WEB 1618"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.34528904),
        dec: Angle.Degrees(+58.63741134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162317"},
        {"Hipparcos Number", "HIP 87020"},
        {"Fundamental Katalog 5th Edition", "FK5 5559"},
        {"Smithsonian Astrophysical Observation", "SAO 30574"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.71527591),
        dec: Angle.Degrees(+58.63870183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7566",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1262 B"},
        {"Henry Draper", "HD 236805"},
        {"Hipparcos Number", "HIP 7566"},
        {"Smithsonian Astrophysical Observation", "SAO 22442"},
        {"Wilson Evans Batten Catalogue", "WEB 1620"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.35907141),
        dec: Angle.Degrees(+58.63907089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106197",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106197"},
    },
    visualMagnitude: 10.47,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.66442557),
        dec: Angle.Degrees(+58.64131480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214541"},
        {"Hipparcos Number", "HIP 111702"},
        {"Smithsonian Astrophysical Observation", "SAO 34636"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.41818449),
        dec: Angle.Degrees(+58.64336161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32567",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32567"},
        {"Wilson Evans Batten Catalogue", "WEB 6571"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.93726422),
        dec: Angle.Degrees(+58.64408309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -477.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237153"},
        {"Hipparcos Number", "HIP 16678"},
        {"Geneva Identification System", "GEN# +1.00237153"},
        {"Smithsonian Astrophysical Observation", "SAO 24107"},
        {"Wilson Evans Batten Catalogue", "WEB 3178"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.812,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.65680355),
        dec: Angle.Degrees(+58.64536213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10861",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10861"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.857,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.94580162),
        dec: Angle.Degrees(+58.64668133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10653",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10653"},
        {"Geneva Identification System", "GEN# +0.05700530"},
        {"Smithsonian Astrophysical Observation", "SAO 23122"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.28078246),
        dec: Angle.Degrees(+58.64866090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223165"},
        {"Hipparcos Number", "HIP 117301"},
        {"Fundamental Katalog 5th Edition", "FK5 3909"},
        {"Geneva Identification System", "GEN# +1.00223165"},
        {"Smithsonian Astrophysical Observation", "SAO 35763"},
        {"Wilson Evans Batten Catalogue", "WEB 20666"},
    },
    visualMagnitude: 4.88,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.76411116),
        dec: Angle.Degrees(+58.65185164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158485"},
        {"Hipparcos Number", "HIP 85317"},
        {"Fundamental Katalog 5th Edition", "FK5 3390"},
        {"Geneva Identification System", "GEN# +1.00158485"},
        {"Smithsonian Astrophysical Observation", "SAO 30387"},
        {"Wilson Evans Batten Catalogue", "WEB 14405"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.52019525),
        dec: Angle.Degrees(+58.65186189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237190"},
        {"Hipparcos Number", "HIP 18260"},
        {"Smithsonian Astrophysical Observation", "SAO 24282"},
        {"Wilson Evans Batten Catalogue", "WEB 3528"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.59070627),
        dec: Angle.Degrees(+58.65333432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222218"},
        {"Hipparcos Number", "HIP 116650"},
        {"Geneva Identification System", "GEN# +1.00222218"},
        {"Smithsonian Astrophysical Observation", "SAO 35631"},
        {"Wilson Evans Batten Catalogue", "WEB 20591"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.59236268),
        dec: Angle.Degrees(+58.65406971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199120"},
        {"Hipparcos Number", "HIP 103035"},
        {"Smithsonian Astrophysical Observation", "SAO 32959"},
        {"Wilson Evans Batten Catalogue", "WEB 18705"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.919,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.12183638),
        dec: Angle.Degrees(+58.65509911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151712"},
        {"Hipparcos Number", "HIP 82049"},
        {"Smithsonian Astrophysical Observation", "SAO 30083"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.40397776),
        dec: Angle.Degrees(+58.65539472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41097"},
        {"Hipparcos Number", "HIP 28959"},
        {"Smithsonian Astrophysical Observation", "SAO 25566"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.67642954),
        dec: Angle.Degrees(+58.65816979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205396"},
        {"Hipparcos Number", "HIP 106383"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.20672658),
        dec: Angle.Degrees(+58.65822606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30208"},
        {"Hipparcos Number", "HIP 22378"},
        {"Smithsonian Astrophysical Observation", "SAO 24845"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.26142839),
        dec: Angle.Degrees(+58.65880522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25361"},
        {"Hipparcos Number", "HIP 19057"},
        {"Geneva Identification System", "GEN# +1.00025361"},
        {"Smithsonian Astrophysical Observation", "SAO 24392"},
        {"Wilson Evans Batten Catalogue", "WEB 3662"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.24359709),
        dec: Angle.Degrees(+58.65977865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216248"},
        {"Hipparcos Number", "HIP 112772"},
        {"Geneva Identification System", "GEN# +1.00216248"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.57763936),
        dec: Angle.Degrees(+58.66049498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169352"},
        {"Hipparcos Number", "HIP 89901"},
        {"Geneva Identification System", "GEN# +1.00169352"},
        {"Smithsonian Astrophysical Observation", "SAO 30912"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.17529732),
        dec: Angle.Degrees(+58.66053128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29130"},
        {"Hipparcos Number", "HIP 21627"},
        {"Smithsonian Astrophysical Observation", "SAO 24730"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.65377313),
        dec: Angle.Degrees(+58.66238098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33356"},
        {"Hipparcos Number", "HIP 24328"},
        {"Geneva Identification System", "GEN# +1.00033356"},
        {"Smithsonian Astrophysical Observation", "SAO 25071"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.31095473),
        dec: Angle.Degrees(+58.66327727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111918"},
        {"Hipparcos Number", "HIP 62781"},
        {"Geneva Identification System", "GEN# +1.00111918"},
        {"Smithsonian Astrophysical Observation", "SAO 28543"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.97684457),
        dec: Angle.Degrees(+58.66338872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237948"},
        {"Hipparcos Number", "HIP 53376"},
        {"Smithsonian Astrophysical Observation", "SAO 27826"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.74037494),
        dec: Angle.Degrees(+58.66425343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31646"},
        {"Hipparcos Number", "HIP 23329"},
        {"Geneva Identification System", "GEN# +1.00031646"},
        {"Smithsonian Astrophysical Observation", "SAO 24949"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.27900964),
        dec: Angle.Degrees(+58.66588542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 470"},
        {"Hipparcos Number", "HIP 763"},
        {"Celescope Catalog", "CEL 32"},
        {"Geneva Identification System", "GEN# +1.00000470"},
        {"Smithsonian Astrophysical Observation", "SAO 21137"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.34695373),
        dec: Angle.Degrees(+58.66590161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95499"},
        {"Hipparcos Number", "HIP 53951"},
        {"Fundamental Katalog 5th Edition", "FK5 4972"},
        {"Smithsonian Astrophysical Observation", "SAO 27877"},
    },
    visualMagnitude: 6.63,
    bvColour: 1.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.57362075),
        dec: Angle.Degrees(+58.66645982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113269",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113269"},
    },
    visualMagnitude: 11.35,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.04804879),
        dec: Angle.Degrees(+58.66715968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237339"},
        {"Hipparcos Number", "HIP 23254"},
        {"Smithsonian Astrophysical Observation", "SAO 24945"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.06011907),
        dec: Angle.Degrees(+58.66771124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236648"},
        {"Hipparcos Number", "HIP 5602"},
        {"Smithsonian Astrophysical Observation", "SAO 22080"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.96265115),
        dec: Angle.Degrees(+58.66890103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2779",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 487 B"},
        {"Hipparcos Number", "HIP 2779"},
        {"Smithsonian Astrophysical Observation", "SAO 21540"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.86912488),
        dec: Angle.Degrees(+58.67468807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208453"},
        {"Hipparcos Number", "HIP 108131"},
        {"Smithsonian Astrophysical Observation", "SAO 33856"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.60680803),
        dec: Angle.Degrees(+58.67474445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35450"},
        {"Hipparcos Number", "HIP 25620"},
        {"Smithsonian Astrophysical Observation", "SAO 25206"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.10104374),
        dec: Angle.Degrees(+58.67505926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238514"},
        {"Hipparcos Number", "HIP 77648"},
        {"Smithsonian Astrophysical Observation", "SAO 29693"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.78394084),
        dec: Angle.Degrees(+58.67800131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2778",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 487 A"},
        {"Henry Draper", "HD 3163"},
        {"Hipparcos Number", "HIP 2778"},
        {"Smithsonian Astrophysical Observation", "SAO 21539"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.86384124),
        dec: Angle.Degrees(+58.67850573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71711",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9342 AB"},
        {"Henry Draper", "HD 129407"},
        {"Hipparcos Number", "HIP 71711"},
        {"Smithsonian Astrophysical Observation", "SAO 29238"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.02970571),
        dec: Angle.Degrees(+58.67931162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -112.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 132.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110869"},
        {"Hipparcos Number", "HIP 62175"},
        {"Geneva Identification System", "GEN# +1.00110869"},
        {"Smithsonian Astrophysical Observation", "SAO 28501"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.12177074),
        dec: Angle.Degrees(+58.69086299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -213.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240001"},
        {"Hipparcos Number", "HIP 111467"},
        {"Geneva Identification System", "GEN# +1.00240001"},
        {"Smithsonian Astrophysical Observation", "SAO 34588"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.75029062),
        dec: Angle.Degrees(+58.69166324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20930"},
        {"Hipparcos Number", "HIP 15943"},
        {"Smithsonian Astrophysical Observation", "SAO 24017"},
        {"Wilson Evans Batten Catalogue", "WEB 3043"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.32606344),
        dec: Angle.Degrees(+58.69450358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137555"},
        {"Hipparcos Number", "HIP 75353"},
        {"Smithsonian Astrophysical Observation", "SAO 29512"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.96963611),
        dec: Angle.Degrees(+58.69741214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238686"},
        {"Hipparcos Number", "HIP 85163"},
        {"Smithsonian Astrophysical Observation", "SAO 30374"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.05544557),
        dec: Angle.Degrees(+58.69866966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99531"},
        {"Hipparcos Number", "HIP 55923"},
        {"Geneva Identification System", "GEN# +1.00099531"},
        {"Smithsonian Astrophysical Observation", "SAO 28025"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.92292756),
        dec: Angle.Degrees(+58.70220418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174931"},
        {"Hipparcos Number", "HIP 92376"},
        {"Smithsonian Astrophysical Observation", "SAO 31189"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.38023755),
        dec: Angle.Degrees(+58.70255315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239486"},
        {"Hipparcos Number", "HIP 102202"},
        {"Smithsonian Astrophysical Observation", "SAO 32820"},
    },
    visualMagnitude: 8.63,
    bvColour: 2.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.62266471),
        dec: Angle.Degrees(+58.70270130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175610"},
        {"Hipparcos Number", "HIP 92652"},
        {"Smithsonian Astrophysical Observation", "SAO 31239"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.17854840),
        dec: Angle.Degrees(+58.70332077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64883"},
        {"Hipparcos Number", "HIP 39055"},
        {"Smithsonian Astrophysical Observation", "SAO 26600"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.84695431),
        dec: Angle.Degrees(+58.70458898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90972",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11465 A"},
        {"Henry Draper", "HD 171848"},
        {"Hipparcos Number", "HIP 90972"},
        {"Smithsonian Astrophysical Observation", "SAO 31047"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.35147064),
        dec: Angle.Degrees(+58.70645688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237709"},
        {"Hipparcos Number", "HIP 41481"},
        {"Smithsonian Astrophysical Observation", "SAO 26841"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.89986376),
        dec: Angle.Degrees(+58.70677891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93224"},
        {"Hipparcos Number", "HIP 52749"},
        {"Smithsonian Astrophysical Observation", "SAO 27766"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.77749203),
        dec: Angle.Degrees(+58.70916836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37609",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6285 A"},
        {"Henry Draper", "HD 61497"},
        {"Hipparcos Number", "HIP 37609"},
        {"Fundamental Katalog 5th Edition", "FK5 292"},
        {"Geneva Identification System", "GEN# +1.00061497A"},
        {"Smithsonian Astrophysical Observation", "SAO 26474"},
        {"Wilson Evans Batten Catalogue", "WEB 7434"},
    },
    visualMagnitude: 4.93,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.75190700),
        dec: Angle.Degrees(+58.71048707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78768"},
        {"Hipparcos Number", "HIP 45186"},
        {"Smithsonian Astrophysical Observation", "SAO 27168"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.11542132),
        dec: Angle.Degrees(+58.71155512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148238"},
        {"Hipparcos Number", "HIP 80284"},
        {"Fundamental Katalog 5th Edition", "FK5 5444"},
        {"Smithsonian Astrophysical Observation", "SAO 29925"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.83736541),
        dec: Angle.Degrees(+58.71383300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79353"},
        {"Hipparcos Number", "HIP 45480"},
        {"Smithsonian Astrophysical Observation", "SAO 27188"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.01367239),
        dec: Angle.Degrees(+58.71436646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12061"},
        {"Hipparcos Number", "HIP 9356"},
        {"Geneva Identification System", "GEN# +1.00012061"},
        {"Smithsonian Astrophysical Observation", "SAO 22829"},
        {"Wilson Evans Batten Catalogue", "WEB 1965"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.05900691),
        dec: Angle.Degrees(+58.71770849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20762"},
        {"Hipparcos Number", "HIP 15795"},
        {"Smithsonian Astrophysical Observation", "SAO 23996"},
    },
    visualMagnitude: 6.58,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.88667652),
        dec: Angle.Degrees(+58.72206578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238807"},
        {"Hipparcos Number", "HIP 88476"},
        {"Smithsonian Astrophysical Observation", "SAO 30727"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.98212310),
        dec: Angle.Degrees(+58.72415913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240080"},
        {"Hipparcos Number", "HIP 112780"},
        {"Smithsonian Astrophysical Observation", "SAO 34866"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.59521480),
        dec: Angle.Degrees(+58.73014932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218187"},
        {"Hipparcos Number", "HIP 113993"},
        {"Smithsonian Astrophysical Observation", "SAO 35133"},
        {"Wilson Evans Batten Catalogue", "WEB 20244"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.27635372),
        dec: Angle.Degrees(+58.73240653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19591"},
        {"Hipparcos Number", "HIP 14865"},
        {"Smithsonian Astrophysical Observation", "SAO 23865"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.98693642),
        dec: Angle.Degrees(+58.73378693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175987"},
        {"Hipparcos Number", "HIP 92793"},
        {"Geneva Identification System", "GEN# +1.00175987"},
        {"Smithsonian Astrophysical Observation", "SAO 31264"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.62686725),
        dec: Angle.Degrees(+58.73581008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238005"},
        {"Hipparcos Number", "HIP 56047"},
        {"Geneva Identification System", "GEN# +1.00238005"},
        {"Smithsonian Astrophysical Observation", "SAO 28032"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.30604454),
        dec: Angle.Degrees(+58.73593424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204827"},
        {"Hipparcos Number", "HIP 106059"},
        {"Geneva Identification System", "GEN# +4.35371240"},
        {"Smithsonian Astrophysical Observation", "SAO 33461"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.806,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.24067644),
        dec: Angle.Degrees(+58.73979549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111907"},
        {"Hipparcos Number", "HIP 62771"},
        {"Smithsonian Astrophysical Observation", "SAO 28542"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.94580018),
        dec: Angle.Degrees(+58.74002913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117690",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117690"},
        {"Geneva Identification System", "GEN# +0.05702823"},
        {"Wilson Evans Batten Catalogue", "WEB 20712"},
    },
    visualMagnitude: 9.94,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.02931631),
        dec: Angle.Degrees(+58.74172660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181627"},
        {"Hipparcos Number", "HIP 94829"},
        {"Renson", "Renson 50303"},
        {"Smithsonian Astrophysical Observation", "SAO 31551"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.43766270),
        dec: Angle.Degrees(+58.74437208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4797"},
        {"Hipparcos Number", "HIP 3954"},
        {"Smithsonian Astrophysical Observation", "SAO 21762"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.69341245),
        dec: Angle.Degrees(+58.74443325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71026"},
        {"Hipparcos Number", "HIP 41536"},
        {"Smithsonian Astrophysical Observation", "SAO 26850"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.05857203),
        dec: Angle.Degrees(+58.74470531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163945"},
        {"Hipparcos Number", "HIP 87716"},
        {"Smithsonian Astrophysical Observation", "SAO 30643"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.76769567),
        dec: Angle.Degrees(+58.74602020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222853"},
        {"Hipparcos Number", "HIP 117071"},
        {"Celescope Catalog", "CEL 5657"},
        {"Geneva Identification System", "GEN# +1.00222853"},
        {"Renson", "Renson 61130"},
        {"Smithsonian Astrophysical Observation", "SAO 35714"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.99696432),
        dec: Angle.Degrees(+58.74653037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198654"},
        {"Hipparcos Number", "HIP 102741"},
        {"Cincinnati Publication", "Ci 18 2699"},
        {"Geneva Identification System", "GEN# +1.00198654"},
        {"Smithsonian Astrophysical Observation", "SAO 32917"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.27686224),
        dec: Angle.Degrees(+58.74691369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 135.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 100.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45742"},
        {"Hipparcos Number", "HIP 31215"},
        {"Smithsonian Astrophysical Observation", "SAO 25799"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.22167917),
        dec: Angle.Degrees(+58.74738686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22710"},
        {"Hipparcos Number", "HIP 17286"},
        {"Smithsonian Astrophysical Observation", "SAO 24162"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.51224117),
        dec: Angle.Degrees(+58.74854404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198679"},
        {"Hipparcos Number", "HIP 102775"},
        {"Celescope Catalog", "CEL 5179"},
        {"Smithsonian Astrophysical Observation", "SAO 32922"},
    },
    visualMagnitude: 6.88,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.32920846),
        dec: Angle.Degrees(+58.74874488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44493",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7157 AB"},
        {"Henry Draper", "HD 237773"},
        {"Hipparcos Number", "HIP 44493"},
        {"Smithsonian Astrophysical Observation", "SAO 27102"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.97417229),
        dec: Angle.Degrees(+58.74908191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64866",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8851 AB"},
        {"Henry Draper", "HD 115720"},
        {"Hipparcos Number", "HIP 64866"},
        {"Geneva Identification System", "GEN# +1.00115720J"},
        {"Smithsonian Astrophysical Observation", "SAO 28710"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.43464532),
        dec: Angle.Degrees(+58.75054627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237772"},
        {"Hipparcos Number", "HIP 44457"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.85555996),
        dec: Angle.Degrees(+58.75110655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125139"},
        {"Hipparcos Number", "HIP 69667"},
        {"Geneva Identification System", "GEN# +1.00125139"},
        {"Smithsonian Astrophysical Observation", "SAO 29063"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.90067776),
        dec: Angle.Degrees(+58.75140430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237095"},
        {"Hipparcos Number", "HIP 15184"},
        {"Smithsonian Astrophysical Observation", "SAO 23899"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.93219583),
        dec: Angle.Degrees(+58.75257005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3924"},
        {"Hipparcos Number", "HIP 3334"},
        {"Geneva Identification System", "GEN# +1.00003924"},
        {"Smithsonian Astrophysical Observation", "SAO 21642"},
        {"Wilson Evans Batten Catalogue", "WEB 590"},
    },
    visualMagnitude: 6.18,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.62920567),
        dec: Angle.Degrees(+58.75343124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236549"},
        {"Hipparcos Number", "HIP 3958"},
        {"Smithsonian Astrophysical Observation", "SAO 21763"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.69820008),
        dec: Angle.Degrees(+58.75423176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81953"},
        {"Hipparcos Number", "HIP 46700"},
        {"Fundamental Katalog 5th Edition", "FK5 4846"},
        {"Smithsonian Astrophysical Observation", "SAO 27277"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.80538863),
        dec: Angle.Degrees(+58.75655204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86217"},
        {"Hipparcos Number", "HIP 48945"},
        {"Smithsonian Astrophysical Observation", "SAO 27452"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.78042986),
        dec: Angle.Degrees(+58.75658815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19342"},
        {"Hipparcos Number", "HIP 14653"},
        {"Geneva Identification System", "GEN# +1.00019342"},
        {"Renson", "Renson 4830"},
        {"Smithsonian Astrophysical Observation", "SAO 23838"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.34024660),
        dec: Angle.Degrees(+58.75699453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240299"},
        {"Hipparcos Number", "HIP 115721"},
        {"Geneva Identification System", "GEN# +1.00240299"},
        {"Smithsonian Astrophysical Observation", "SAO 35420"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.66892982),
        dec: Angle.Degrees(+58.75727470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 130.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206080"},
        {"Hipparcos Number", "HIP 106770"},
        {"Geneva Identification System", "GEN# +4.35371289"},
        {"Smithsonian Astrophysical Observation", "SAO 33602"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.41154339),
        dec: Angle.Degrees(+58.75836024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237646"},
        {"Hipparcos Number", "HIP 38602"},
        {"Smithsonian Astrophysical Observation", "SAO 26558"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.55598290),
        dec: Angle.Degrees(+58.75946648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 153.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236624"},
        {"Hipparcos Number", "HIP 5221"},
        {"Smithsonian Astrophysical Observation", "SAO 22010"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.69101496),
        dec: Angle.Degrees(+58.76048117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91780",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91780"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.72859841),
        dec: Angle.Degrees(+58.76140907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -133.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99232"},
        {"Hipparcos Number", "HIP 55792"},
        {"Geneva Identification System", "GEN# +1.00099232"},
        {"Smithsonian Astrophysical Observation", "SAO 28015"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.46148615),
        dec: Angle.Degrees(+58.76233347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8992"},
        {"Hipparcos Number", "HIP 6985"},
        {"Geneva Identification System", "GEN# +1.00008992"},
        {"Smithsonian Astrophysical Observation", "SAO 22328"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.883,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.47472917),
        dec: Angle.Degrees(+58.76246826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16584",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2592 B"},
        {"Henry Draper", "HD 237150"},
        {"Hipparcos Number", "HIP 16584"},
        {"Geneva Identification System", "GEN# +1.00237150"},
        {"Geneva Identification System 2", "GEN# +1.20021769"},
        {"Smithsonian Astrophysical Observation", "SAO 24092"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.37426054),
        dec: Angle.Degrees(+58.76287954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16587",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2592 A"},
        {"Henry Draper", "HD 21769"},
        {"Hipparcos Number", "HIP 16587"},
        {"Geneva Identification System", "GEN# +1.00021769A"},
        {"Renson", "Renson 5440"},
        {"Smithsonian Astrophysical Observation", "SAO 24093"},
        {"Wilson Evans Batten Catalogue", "WEB 3164"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.38412463),
        dec: Angle.Degrees(+58.76535110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17734"},
        {"Hipparcos Number", "HIP 13446"},
        {"Smithsonian Astrophysical Observation", "SAO 23675"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.29106601),
        dec: Angle.Degrees(+58.76555763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222885"},
        {"Hipparcos Number", "HIP 117101"},
        {"Celescope Catalog", "CEL 5658"},
        {"Geneva Identification System", "GEN# +1.00222885"},
        {"Smithsonian Astrophysical Observation", "SAO 35722"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.09275718),
        dec: Angle.Degrees(+58.76617309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108861"},
        {"Hipparcos Number", "HIP 60992"},
        {"Geneva Identification System", "GEN# +1.00108861"},
        {"Smithsonian Astrophysical Observation", "SAO 28408"},
        {"Wilson Evans Batten Catalogue", "WEB 10859"},
    },
    visualMagnitude: 6.07,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.51760070),
        dec: Angle.Degrees(+58.76780973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240223"},
        {"Hipparcos Number", "HIP 114563"},
        {"Celescope Catalog", "CEL 5576"},
        {"Geneva Identification System", "GEN# +1.00240223"},
        {"Smithsonian Astrophysical Observation", "SAO 35228"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.09167141),
        dec: Angle.Degrees(+58.76784842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23650"},
        {"Hipparcos Number", "HIP 17887"},
        {"Geneva Identification System", "GEN# +1.00023650"},
        {"Smithsonian Astrophysical Observation", "SAO 24246"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.39537969),
        dec: Angle.Degrees(+58.76828000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 876",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 129 AB"},
        {"Henry Draper", "HD 627"},
        {"Hipparcos Number", "HIP 876"},
        {"Geneva Identification System", "GEN# +1.00000627J"},
        {"Smithsonian Astrophysical Observation", "SAO 21171"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.69315961),
        dec: Angle.Degrees(+58.76951990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240322"},
        {"Hipparcos Number", "HIP 116134"},
        {"Geneva Identification System", "GEN# +1.00240322"},
        {"Smithsonian Astrophysical Observation", "SAO 35517"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.96706249),
        dec: Angle.Degrees(+58.76972902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98488"},
        {"Hipparcos Number", "HIP 55383"},
        {"Geneva Identification System", "GEN# +1.00098488"},
        {"Smithsonian Astrophysical Observation", "SAO 27993"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.11342333),
        dec: Angle.Degrees(+58.77587903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107259",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Herschel's Garnet Star"},
        {"Common Name 2", "Erakis"},
        {"Aitken", "ADS 15271 A"},
        {"Henry Draper", "HD 206936"},
        {"Hipparcos Number", "HIP 107259"},
        {"Smithsonian Astrophysical Observation", "SAO 33693"},
        {"Wilson Evans Batten Catalogue", "WEB 19372"},
    },
    visualMagnitude: 4.23,
    bvColour: 2.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.87689561),
        dec: Angle.Degrees(+58.78005308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240338"},
        {"Hipparcos Number", "HIP 116483"},
        {"Geneva Identification System", "GEN# +1.00240338"},
        {"Smithsonian Astrophysical Observation", "SAO 35589"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.04218810),
        dec: Angle.Degrees(+58.78180620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209811"},
        {"Hipparcos Number", "HIP 108948"},
        {"Smithsonian Astrophysical Observation", "SAO 34024"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.08350812),
        dec: Angle.Degrees(+58.78201268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13022"},
        {"Hipparcos Number", "HIP 10060"},
        {"Geneva Identification System", "GEN# +1.00013022"},
        {"Smithsonian Astrophysical Observation", "SAO 22972"},
        {"Wilson Evans Batten Catalogue", "WEB 2108"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.37529823),
        dec: Angle.Degrees(+58.78376428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38128"},
        {"Hipparcos Number", "HIP 27314"},
        {"Smithsonian Astrophysical Observation", "SAO 25366"},
    },
    visualMagnitude: 6.56,
    bvColour: 1.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.79285231),
        dec: Angle.Degrees(+58.78551331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191737"},
        {"Hipparcos Number", "HIP 99207"},
        {"Geneva Identification System", "GEN# +1.00191737"},
        {"Smithsonian Astrophysical Observation", "SAO 32313"},
        {"Wilson Evans Batten Catalogue", "WEB 17669"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.10608282),
        dec: Angle.Degrees(+58.78731084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236947"},
        {"Hipparcos Number", "HIP 9886"},
        {"Geneva Identification System", "GEN# +0.05800373"},
        {"Geneva Identification System 2", "GEN# +1.00236947"},
        {"Smithsonian Astrophysical Observation", "SAO 22936"},
    },
    visualMagnitude: 8.61,
    bvColour: 2.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.80023348),
        dec: Angle.Degrees(+58.78775319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20046",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3098 AB"},
        {"Henry Draper", "HD 26839"},
        {"Hipparcos Number", "HIP 20046"},
        {"Smithsonian Astrophysical Observation", "SAO 24521"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.48212542),
        dec: Angle.Degrees(+58.79076522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236855"},
        {"Hipparcos Number", "HIP 8165"},
        {"Smithsonian Astrophysical Observation", "SAO 22582"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.25231728),
        dec: Angle.Degrees(+58.79129576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237809"},
        {"Hipparcos Number", "HIP 46260"},
        {"Smithsonian Astrophysical Observation", "SAO 27250"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.49181182),
        dec: Angle.Degrees(+58.79155055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238502"},
        {"Hipparcos Number", "HIP 77085"},
        {"Smithsonian Astrophysical Observation", "SAO 29640"},
    },
    visualMagnitude: 9.95,
    bvColour: 1.793,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.09272126),
        dec: Angle.Degrees(+58.79270613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136494"},
        {"Hipparcos Number", "HIP 74886"},
        {"Smithsonian Astrophysical Observation", "SAO 29475"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.56628907),
        dec: Angle.Degrees(+58.79400044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236504"},
        {"Hipparcos Number", "HIP 3366"},
        {"Smithsonian Astrophysical Observation", "SAO 21647"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.70678766),
        dec: Angle.Degrees(+58.79692772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13412"},
        {"Hipparcos Number", "HIP 10331"},
        {"Geneva Identification System", "GEN# +4.31020034"},
        {"Renson", "Renson 3500"},
        {"Smithsonian Astrophysical Observation", "SAO 23034"},
        {"Wilson Evans Batten Catalogue", "WEB 2158"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.27814521),
        dec: Angle.Degrees(+58.79938463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90156",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11336 AB"},
        {"Henry Draper", "HD 170073"},
        {"Hipparcos Number", "HIP 90156"},
        {"Geneva Identification System", "GEN# +1.00170073J"},
        {"Smithsonian Astrophysical Observation", "SAO 30949"},
        {"Wilson Evans Batten Catalogue", "WEB 15416"},
    },
    visualMagnitude: 4.98,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.97770388),
        dec: Angle.Degrees(+58.80058520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113890"},
        {"Hipparcos Number", "HIP 63900"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.43350369),
        dec: Angle.Degrees(+58.80065758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161015"},
        {"Hipparcos Number", "HIP 86428"},
        {"Smithsonian Astrophysical Observation", "SAO 30504"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.89169038),
        dec: Angle.Degrees(+58.80330949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72168"},
        {"Hipparcos Number", "HIP 42063"},
        {"Smithsonian Astrophysical Observation", "SAO 26912"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.60794422),
        dec: Angle.Degrees(+58.80365701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168341"},
        {"Hipparcos Number", "HIP 89475"},
        {"Smithsonian Astrophysical Observation", "SAO 30852"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.88710955),
        dec: Angle.Degrees(+58.80461034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216533"},
        {"Hipparcos Number", "HIP 112969"},
        {"Geneva Identification System", "GEN# +1.00216533"},
        {"Renson", "Renson 59810"},
        {"Smithsonian Astrophysical Observation", "SAO 34915"},
        {"Wilson Evans Batten Catalogue", "WEB 20115"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.17454294),
        dec: Angle.Degrees(+58.80645134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193630"},
        {"Hipparcos Number", "HIP 100081"},
        {"Smithsonian Astrophysical Observation", "SAO 32456"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.55794299),
        dec: Angle.Degrees(+58.80923379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7284"},
        {"Hipparcos Number", "HIP 5784"},
        {"Geneva Identification System", "GEN# +1.00007284"},
        {"Smithsonian Astrophysical Observation", "SAO 22113"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.54367268),
        dec: Angle.Degrees(+58.81244629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196118"},
        {"Hipparcos Number", "HIP 101348"},
        {"Smithsonian Astrophysical Observation", "SAO 32675"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.10327317),
        dec: Angle.Degrees(+58.81328290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199850"},
        {"Hipparcos Number", "HIP 103421"},
        {"Smithsonian Astrophysical Observation", "SAO 33019"},
    },
    visualMagnitude: 7.94,
    bvColour: -0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.30431900),
        dec: Angle.Degrees(+58.81673507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103461",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14493 AB"},
        {"Henry Draper", "HD 199937"},
        {"Hipparcos Number", "HIP 103461"},
        {"Smithsonian Astrophysical Observation", "SAO 33027"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.41950480),
        dec: Angle.Degrees(+58.82205253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42974"},
        {"Hipparcos Number", "HIP 29876"},
        {"Smithsonian Astrophysical Observation", "SAO 25646"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.36037062),
        dec: Angle.Degrees(+58.82652079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46316"},
        {"Hipparcos Number", "HIP 31551"},
        {"Smithsonian Astrophysical Observation", "SAO 25830"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.06152282),
        dec: Angle.Degrees(+58.82723966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57055",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57055"},
    },
    visualMagnitude: 11.69,
    bvColour: 1.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.45383714),
        dec: Angle.Degrees(+58.82771130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -415.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237742"},
        {"Hipparcos Number", "HIP 42986"},
        {"Smithsonian Astrophysical Observation", "SAO 26981"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.41377055),
        dec: Angle.Degrees(+58.83012046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238397"},
        {"Hipparcos Number", "HIP 72530"},
        {"Smithsonian Astrophysical Observation", "SAO 29300"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.43844082),
        dec: Angle.Degrees(+58.83012304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 100.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17234"},
        {"Hipparcos Number", "HIP 13098"},
        {"Geneva Identification System", "GEN# +1.00017234"},
        {"Smithsonian Astrophysical Observation", "SAO 23621"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.10308543),
        dec: Angle.Degrees(+58.83196939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12400"},
        {"Hipparcos Number", "HIP 9597"},
        {"Geneva Identification System", "GEN# +1.00012400"},
        {"Renson", "Renson 3150"},
        {"Smithsonian Astrophysical Observation", "SAO 22876"},
        {"Wilson Evans Batten Catalogue", "WEB 2017"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.85837621),
        dec: Angle.Degrees(+58.83210428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59223"},
        {"Hipparcos Number", "HIP 36656"},
        {"Smithsonian Astrophysical Observation", "SAO 26392"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.09274617),
        dec: Angle.Degrees(+58.83320363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190961"},
        {"Hipparcos Number", "HIP 98846"},
        {"Geneva Identification System", "GEN# +1.00190961"},
        {"Smithsonian Astrophysical Observation", "SAO 32263"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.09944275),
        dec: Angle.Degrees(+58.83458883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30934"},
        {"Hipparcos Number", "HIP 22887"},
        {"Smithsonian Astrophysical Observation", "SAO 24907"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.84230879),
        dec: Angle.Degrees(+58.83606865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210220"},
        {"Hipparcos Number", "HIP 109190"},
        {"Fundamental Katalog 5th Edition", "FK5 3770"},
        {"Geneva Identification System", "GEN# +1.00210220"},
        {"Smithsonian Astrophysical Observation", "SAO 34072"},
        {"Wilson Evans Batten Catalogue", "WEB 19628"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.877,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.79021802),
        dec: Angle.Degrees(+58.84077239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16293"},
        {"Hipparcos Number", "HIP 12369"},
        {"Smithsonian Astrophysical Observation", "SAO 23496"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.80442026),
        dec: Angle.Degrees(+58.84328951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22601"},
        {"Hipparcos Number", "HIP 17211"},
        {"Fundamental Katalog 5th Edition", "FK5 4334"},
        {"Geneva Identification System", "GEN# +1.00022601"},
        {"Smithsonian Astrophysical Observation", "SAO 24155"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.29956739),
        dec: Angle.Degrees(+58.84508619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60115",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60115"},
        {"Geneva Identification System", "GEN# +9.80197054"},
    },
    visualMagnitude: 11.87,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.92440673),
        dec: Angle.Degrees(+58.84576564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -352.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213231"},
        {"Hipparcos Number", "HIP 110937"},
        {"Geneva Identification System", "GEN# +1.00213231"},
        {"Smithsonian Astrophysical Observation", "SAO 34495"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.16270399),
        dec: Angle.Degrees(+58.84579081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189276"},
        {"Hipparcos Number", "HIP 98073"},
        {"Fundamental Katalog 5th Edition", "FK5 3591"},
        {"Geneva Identification System", "GEN# +1.00189276"},
        {"Smithsonian Astrophysical Observation", "SAO 32122"},
        {"Wilson Evans Batten Catalogue", "WEB 17284"},
    },
    visualMagnitude: 4.98,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.98078459),
        dec: Angle.Degrees(+58.84601982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119582"},
        {"Hipparcos Number", "HIP 66894"},
        {"Smithsonian Astrophysical Observation", "SAO 28859"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.63650380),
        dec: Angle.Degrees(+58.84911073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210479"},
        {"Hipparcos Number", "HIP 109337"},
        {"Smithsonian Astrophysical Observation", "SAO 34108"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.25101460),
        dec: Angle.Degrees(+58.85202303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137587"},
        {"Hipparcos Number", "HIP 75366"},
        {"Smithsonian Astrophysical Observation", "SAO 29513"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.01754437),
        dec: Angle.Degrees(+58.85300398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238860"},
        {"Hipparcos Number", "HIP 89974"},
        {"Fundamental Katalog 5th Edition", "FK5 5616"},
        {"Smithsonian Astrophysical Observation", "SAO 30925"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.36536815),
        dec: Angle.Degrees(+58.85544146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -129.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 209.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237121"},
        {"Hipparcos Number", "HIP 15584"},
        {"Geneva Identification System", "GEN# +1.00237121"},
        {"Smithsonian Astrophysical Observation", "SAO 23964"},
        {"Wilson Evans Batten Catalogue", "WEB 2993"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.18668928),
        dec: Angle.Degrees(+58.85556927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23129"},
        {"Hipparcos Number", "HIP 17568"},
        {"Smithsonian Astrophysical Observation", "SAO 24190"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.43579302),
        dec: Angle.Degrees(+58.85608201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3764"},
        {"Hipparcos Number", "HIP 3229"},
        {"Smithsonian Astrophysical Observation", "SAO 21616"},
    },
    visualMagnitude: 8.61,
    bvColour: -0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.27249561),
        dec: Angle.Degrees(+58.85843239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150202"},
        {"Hipparcos Number", "HIP 81284"},
        {"Smithsonian Astrophysical Observation", "SAO 30015"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.02991662),
        dec: Angle.Degrees(+58.85852155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32142"},
        {"Hipparcos Number", "HIP 23605"},
        {"Smithsonian Astrophysical Observation", "SAO 24989"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.13737352),
        dec: Angle.Degrees(+58.86100090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12928"},
        {"Hipparcos Number", "HIP 9980"},
        {"Celescope Catalog", "CEL 205"},
        {"Geneva Identification System", "GEN# +1.00012928"},
        {"Smithsonian Astrophysical Observation", "SAO 22956"},
        {"Wilson Evans Batten Catalogue", "WEB 2089"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.12889932),
        dec: Angle.Degrees(+58.86529390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83313"},
        {"Hipparcos Number", "HIP 47410"},
        {"Smithsonian Astrophysical Observation", "SAO 27330"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.91380430),
        dec: Angle.Degrees(+58.86565225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123300"},
        {"Hipparcos Number", "HIP 68792"},
        {"Geneva Identification System", "GEN# +1.00123300"},
        {"Smithsonian Astrophysical Observation", "SAO 29003"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.21576106),
        dec: Angle.Degrees(+58.86746059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -178.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68529",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9088 AB"},
        {"Henry Draper", "HD 238312"},
        {"Hipparcos Number", "HIP 68529"},
        {"Smithsonian Astrophysical Observation", "SAO 28979"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.43803657),
        dec: Angle.Degrees(+58.86831272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110762"},
        {"Hipparcos Number", "HIP 62101"},
        {"Smithsonian Astrophysical Observation", "SAO 28492"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.90516453),
        dec: Angle.Degrees(+58.86972450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77818"},
        {"Hipparcos Number", "HIP 44766"},
        {"Geneva Identification System", "GEN# +1.00077818"},
        {"Smithsonian Astrophysical Observation", "SAO 27127"},
        {"Wilson Evans Batten Catalogue", "WEB 8558"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.85882941),
        dec: Angle.Degrees(+58.87527341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14947"},
        {"Hipparcos Number", "HIP 11394"},
        {"Geneva Identification System", "GEN# +1.00014947"},
        {"Smithsonian Astrophysical Observation", "SAO 23334"},
        {"Wilson Evans Batten Catalogue", "WEB 2376"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.69578823),
        dec: Angle.Degrees(+58.87586869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217850"},
        {"Hipparcos Number", "HIP 113789"},
        {"Smithsonian Astrophysical Observation", "SAO 35089"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.791,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.65278190),
        dec: Angle.Degrees(+58.87618634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216412"},
        {"Hipparcos Number", "HIP 112889"},
        {"Smithsonian Astrophysical Observation", "SAO 34884"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.91356125),
        dec: Angle.Degrees(+58.87858902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21389"},
        {"Hipparcos Number", "HIP 16281"},
        {"Geneva Identification System", "GEN# +1.00021389"},
        {"Smithsonian Astrophysical Observation", "SAO 24061"},
        {"Wilson Evans Batten Catalogue", "WEB 3104"},
    },
    visualMagnitude: 4.55,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.47810837),
        dec: Angle.Degrees(+58.87875244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75615"},
        {"Hipparcos Number", "HIP 43665"},
        {"Geneva Identification System", "GEN# +1.00075615"},
        {"Smithsonian Astrophysical Observation", "SAO 27032"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.43889716),
        dec: Angle.Degrees(+58.88262936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98315"},
        {"Hipparcos Number", "HIP 55267"},
        {"Geneva Identification System", "GEN# +1.00098315"},
        {"Smithsonian Astrophysical Observation", "SAO 27983"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.78627565),
        dec: Angle.Degrees(+58.88686037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216927"},
        {"Hipparcos Number", "HIP 113263"},
        {"Geneva Identification System", "GEN# +1.00216927"},
        {"Smithsonian Astrophysical Observation", "SAO 34973"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.821,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.03563613),
        dec: Angle.Degrees(+58.88752605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14311"},
        {"Hipparcos Number", "HIP 10936"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.21812405),
        dec: Angle.Degrees(+58.88863549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12701",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2058 A"},
        {"Henry Draper", "HD 16718"},
        {"Hipparcos Number", "HIP 12701"},
        {"Celescope Catalog", "CEL 292"},
        {"Geneva Identification System", "GEN# +1.00016718"},
        {"Smithsonian Astrophysical Observation", "SAO 23554"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.78858321),
        dec: Angle.Degrees(+58.88944210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70834",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70834"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.833,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.28370805),
        dec: Angle.Degrees(+58.88945081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203375"},
        {"Hipparcos Number", "HIP 105279"},
        {"Smithsonian Astrophysical Observation", "SAO 33324"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.86169462),
        dec: Angle.Degrees(+58.89120134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96950"},
        {"Hipparcos Number", "HIP 54617"},
        {"Smithsonian Astrophysical Observation", "SAO 27935"},
        {"Wilson Evans Batten Catalogue", "WEB 9851"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.66419467),
        dec: Angle.Degrees(+58.89354909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104674",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104674"},
        {"Smithsonian Astrophysical Observation", "SAO 33220"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.04012069),
        dec: Angle.Degrees(+58.89356765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239475"},
        {"Hipparcos Number", "HIP 101978"},
        {"Smithsonian Astrophysical Observation", "SAO 32786"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.807,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.99648383),
        dec: Angle.Degrees(+58.89420780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239522"},
        {"Hipparcos Number", "HIP 103146"},
        {"Smithsonian Astrophysical Observation", "SAO 32982"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.47699975),
        dec: Angle.Degrees(+58.89540953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238233"},
        {"Hipparcos Number", "HIP 65537"},
        {"Geneva Identification System", "GEN# +1.00238233"},
        {"Smithsonian Astrophysical Observation", "SAO 28756"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.53298287),
        dec: Angle.Degrees(+58.89878875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97140"},
        {"Hipparcos Number", "HIP 54687"},
        {"Geneva Identification System", "GEN# +1.00097140"},
        {"Smithsonian Astrophysical Observation", "SAO 27941"},
        {"Wilson Evans Batten Catalogue", "WEB 9870"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.93168823),
        dec: Angle.Degrees(+58.89973332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121408"},
        {"Hipparcos Number", "HIP 67814"},
        {"Smithsonian Astrophysical Observation", "SAO 28927"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.38035240),
        dec: Angle.Degrees(+58.90191367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239605"},
        {"Hipparcos Number", "HIP 104676"},
        {"Geneva Identification System", "GEN# +1.00239605"},
        {"Smithsonian Astrophysical Observation", "SAO 33221"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.04450211),
        dec: Angle.Degrees(+58.90348756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90092",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90092"},
        {"Wilson Evans Batten Catalogue", "WEB 15400"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.77257267),
        dec: Angle.Degrees(+58.90360257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95866"},
        {"Hipparcos Number", "HIP 54142"},
        {"Smithsonian Astrophysical Observation", "SAO 27891"},
        {"Wilson Evans Batten Catalogue", "WEB 9785"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.851,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.14079649),
        dec: Angle.Degrees(+58.90390136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36968",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36968"},
    },
    visualMagnitude: 10.93,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.98837563),
        dec: Angle.Degrees(+58.90609172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53750",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8001 A"},
        {"Henry Draper", "HD 95098"},
        {"Hipparcos Number", "HIP 53750"},
        {"Geneva Identification System", "GEN# +1.00095098"},
        {"Smithsonian Astrophysical Observation", "SAO 27861"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.95617874),
        dec: Angle.Degrees(+58.90650444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82172"},
        {"Hipparcos Number", "HIP 46842"},
        {"Smithsonian Astrophysical Observation", "SAO 27283"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.17995635),
        dec: Angle.Degrees(+58.90779670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6147"},
        {"Hipparcos Number", "HIP 4961"},
        {"Smithsonian Astrophysical Observation", "SAO 21956"},
        {"Wilson Evans Batten Catalogue", "WEB 995"},
    },
    visualMagnitude: 6.75,
    bvColour: 1.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.90421340),
        dec: Angle.Degrees(+58.90925342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29534"},
        {"Hipparcos Number", "HIP 21903"},
        {"Smithsonian Astrophysical Observation", "SAO 24769"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.65427837),
        dec: Angle.Degrees(+58.90928590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72407",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72407"},
        {"Geneva Identification System", "GEN# +0.05901609"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.07919936),
        dec: Angle.Degrees(+58.90986914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -269.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143187"},
        {"Hipparcos Number", "HIP 78017"},
        {"Geneva Identification System", "GEN# +1.00143187"},
        {"Smithsonian Astrophysical Observation", "SAO 29723"},
        {"Wilson Evans Batten Catalogue", "WEB 13193"},
    },
    visualMagnitude: 6.31,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.95690735),
        dec: Angle.Degrees(+58.91170971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53754",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8001 B"},
        {"Henry Draper", "HD 237960"},
        {"Hipparcos Number", "HIP 53754"},
        {"Geneva Identification System", "GEN# +1.00237960"},
        {"Smithsonian Astrophysical Observation", "SAO 27862"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.96713299),
        dec: Angle.Degrees(+58.91409085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35074"},
        {"Hipparcos Number", "HIP 25379"},
        {"Smithsonian Astrophysical Observation", "SAO 25188"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.44991984),
        dec: Angle.Degrees(+58.91499428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51564",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51564"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.99288482),
        dec: Angle.Degrees(+58.91731663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55944"},
        {"Hipparcos Number", "HIP 35398"},
        {"Geneva Identification System", "GEN# +1.00055944"},
        {"Smithsonian Astrophysical Observation", "SAO 26264"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.65102279),
        dec: Angle.Degrees(+58.91873942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201934"},
        {"Hipparcos Number", "HIP 104518"},
        {"Smithsonian Astrophysical Observation", "SAO 33188"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.56899406),
        dec: Angle.Degrees(+58.91948377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112096"},
        {"Hipparcos Number", "HIP 62869"},
        {"Geneva Identification System", "GEN# +1.00112096"},
        {"Smithsonian Astrophysical Observation", "SAO 28548"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.28061911),
        dec: Angle.Degrees(+58.92073751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2328",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 399 AB"},
        {"Henry Draper", "HD 236426"},
        {"Hipparcos Number", "HIP 2328"},
        {"Smithsonian Astrophysical Observation", "SAO 21440"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.43616388),
        dec: Angle.Degrees(+58.92392721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101548"},
        {"Hipparcos Number", "HIP 57020"},
        {"Geneva Identification System", "GEN# +1.10101548"},
        {"Smithsonian Astrophysical Observation", "SAO 28095"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.35843032),
        dec: Angle.Degrees(+58.92397537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -200.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25140"},
        {"Hipparcos Number", "HIP 18880"},
        {"Geneva Identification System", "GEN# +1.00025140"},
        {"Smithsonian Astrophysical Observation", "SAO 24363"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.72020048),
        dec: Angle.Degrees(+58.92447889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203266"},
        {"Hipparcos Number", "HIP 105222"},
        {"Smithsonian Astrophysical Observation", "SAO 33311"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.70769648),
        dec: Angle.Degrees(+58.92608938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238087"},
        {"Hipparcos Number", "HIP 59496"},
        {"Geneva Identification System", "GEN# +1.00238087"},
        {"Wilson Evans Batten Catalogue", "WEB 10577"},
    },
    visualMagnitude: 10.05,
    bvColour: 1.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.02126673),
        dec: Angle.Degrees(+58.92639872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214764"},
        {"Hipparcos Number", "HIP 111829"},
        {"Geneva Identification System", "GEN# +1.00214764"},
        {"Smithsonian Astrophysical Observation", "SAO 34659"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.77206863),
        dec: Angle.Degrees(+58.92748793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155069"},
        {"Hipparcos Number", "HIP 83654"},
        {"Smithsonian Astrophysical Observation", "SAO 30250"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.793,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.46721350),
        dec: Angle.Degrees(+58.92791361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57019",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57019"},
        {"Geneva Identification System", "GEN# +1.20101548"},
        {"Smithsonian Astrophysical Observation", "SAO 28094"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.35627495),
        dec: Angle.Degrees(+58.93237327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -198.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78397",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9891 AB"},
        {"Henry Draper", "HD 143988"},
        {"Hipparcos Number", "HIP 78397"},
        {"Smithsonian Astrophysical Observation", "SAO 29752"},
    },
    visualMagnitude: 8.25,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.07616940),
        dec: Angle.Degrees(+58.93415633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41597"},
        {"Hipparcos Number", "HIP 29246"},
        {"Geneva Identification System", "GEN# +1.00041597"},
        {"Smithsonian Astrophysical Observation", "SAO 25597"},
        {"Wilson Evans Batten Catalogue", "WEB 5735"},
    },
    visualMagnitude: 5.35,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.49581101),
        dec: Angle.Degrees(+58.93564864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192952"},
        {"Hipparcos Number", "HIP 99778"},
        {"Smithsonian Astrophysical Observation", "SAO 32389"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.66626017),
        dec: Angle.Degrees(+58.93919321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239956"},
        {"Hipparcos Number", "HIP 110834"},
        {"Geneva Identification System", "GEN# +1.00239956"},
        {"Smithsonian Astrophysical Observation", "SAO 34467"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.82152484),
        dec: Angle.Degrees(+58.94189132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63811"},
        {"Hipparcos Number", "HIP 38590"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.53002266),
        dec: Angle.Degrees(+58.94416309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6562",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1112 C"},
        {"Henry Draper", "HD 8372"},
        {"Hipparcos Number", "HIP 6562"},
        {"Smithsonian Astrophysical Observation", "SAO 22240"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.08376056),
        dec: Angle.Degrees(+58.94644495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106539"},
        {"Hipparcos Number", "HIP 59744"},
        {"Smithsonian Astrophysical Observation", "SAO 28312"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.78083365),
        dec: Angle.Degrees(+58.94780832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25132"},
        {"Hipparcos Number", "HIP 18871"},
        {"Geneva Identification System", "GEN# +1.00025132"},
        {"Smithsonian Astrophysical Observation", "SAO 24360"},
        {"Wilson Evans Batten Catalogue", "WEB 3632"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.68217215),
        dec: Angle.Degrees(+58.94930740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86129"},
        {"Hipparcos Number", "HIP 48905"},
        {"Smithsonian Astrophysical Observation", "SAO 27445"},
    },
    visualMagnitude: 6.72,
    bvColour: 1.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.64240227),
        dec: Angle.Degrees(+58.95196248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117845"},
        {"Hipparcos Number", "HIP 65971"},
        {"Geneva Identification System", "GEN# +1.00117845"},
        {"Smithsonian Astrophysical Observation", "SAO 28788"},
        {"Wilson Evans Batten Catalogue", "WEB 11668"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.89088869),
        dec: Angle.Degrees(+58.95286729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239923"},
        {"Hipparcos Number", "HIP 110200"},
        {"Geneva Identification System", "GEN# +1.00239923"},
        {"Smithsonian Astrophysical Observation", "SAO 34312"},
        {"Wilson Evans Batten Catalogue", "WEB 19777"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.816,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.83724739),
        dec: Angle.Degrees(+58.95315546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98737",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98737"},
        {"Wilson Evans Batten Catalogue", "WEB 17490"},
    },
    visualMagnitude: 12.04,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.81520827),
        dec: Angle.Degrees(+58.95457289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238586"},
        {"Hipparcos Number", "HIP 81364"},
        {"Smithsonian Astrophysical Observation", "SAO 30021"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.24658829),
        dec: Angle.Degrees(+58.95738594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68193"},
        {"Hipparcos Number", "HIP 40368"},
        {"Smithsonian Astrophysical Observation", "SAO 26733"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.62639170),
        dec: Angle.Degrees(+58.95757061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90163"},
        {"Hipparcos Number", "HIP 51064"},
        {"Fundamental Katalog 5th Edition", "FK5 4926"},
        {"Smithsonian Astrophysical Observation", "SAO 27638"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.51063309),
        dec: Angle.Degrees(+58.95820079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23278"},
        {"Hipparcos Number", "HIP 17661"},
        {"Smithsonian Astrophysical Observation", "SAO 24209"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.73823591),
        dec: Angle.Degrees(+58.96078642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14142"},
        {"Hipparcos Number", "HIP 10829"},
        {"Geneva Identification System", "GEN# +1.00014142"},
        {"Smithsonian Astrophysical Observation", "SAO 23183"},
    },
    visualMagnitude: 8.35,
    bvColour: 2.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.84115997),
        dec: Angle.Degrees(+58.96120815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110408"},
        {"Hipparcos Number", "HIP 61911"},
        {"Geneva Identification System", "GEN# +1.00110408"},
        {"Smithsonian Astrophysical Observation", "SAO 28478"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.31846924),
        dec: Angle.Degrees(+58.96215054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223421"},
        {"Hipparcos Number", "HIP 117472"},
        {"Celescope Catalog", "CEL 5685"},
        {"Geneva Identification System", "GEN# +1.00223421"},
        {"Smithsonian Astrophysical Observation", "SAO 35798"},
        {"Wilson Evans Batten Catalogue", "WEB 20690"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.29952997),
        dec: Angle.Degrees(+58.96322242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38831"},
        {"Hipparcos Number", "HIP 27731"},
        {"Geneva Identification System", "GEN# +1.00038831"},
        {"Smithsonian Astrophysical Observation", "SAO 25419"},
        {"Wilson Evans Batten Catalogue", "WEB 5438"},
    },
    visualMagnitude: 6.14,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.07189908),
        dec: Angle.Degrees(+58.96413909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75458",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Edasich"},
        {"Henry Draper", "HD 137759"},
        {"Hipparcos Number", "HIP 75458"},
        {"Fundamental Katalog 5th Edition", "FK5 571"},
        {"Geneva Identification System", "GEN# +1.00137759"},
        {"Smithsonian Astrophysical Observation", "SAO 29520"},
        {"Wilson Evans Batten Catalogue", "WEB 12868"},
    },
    visualMagnitude: 3.29,
    bvColour: 1.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.23243370),
        dec: Angle.Degrees(+58.96602354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39092"},
        {"Hipparcos Number", "HIP 27882"},
        {"Smithsonian Astrophysical Observation", "SAO 25435"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.50119364),
        dec: Angle.Degrees(+58.96727244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222366"},
        {"Hipparcos Number", "HIP 116743"},
        {"Geneva Identification System", "GEN# +1.00222366"},
        {"Smithsonian Astrophysical Observation", "SAO 35650"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.864,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.89573033),
        dec: Angle.Degrees(+58.97041816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32343"},
        {"Hipparcos Number", "HIP 23734"},
        {"Celescope Catalog", "CEL 526"},
        {"Geneva Identification System", "GEN# +1.00032343"},
        {"Smithsonian Astrophysical Observation", "SAO 25001"},
        {"Wilson Evans Batten Catalogue", "WEB 4630"},
    },
    visualMagnitude: 5.22,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.53524887),
        dec: Angle.Degrees(+58.97239085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4292",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 748 A"},
        {"Henry Draper", "HD 5234"},
        {"Hipparcos Number", "HIP 4292"},
        {"Geneva Identification System", "GEN# +1.00005234"},
        {"Smithsonian Astrophysical Observation", "SAO 21832"},
        {"Wilson Evans Batten Catalogue", "WEB 770"},
    },
    visualMagnitude: 4.83,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.75080422),
        dec: Angle.Degrees(+58.97279657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166579"},
        {"Hipparcos Number", "HIP 88799"},
        {"Geneva Identification System", "GEN# +1.00166579"},
        {"Smithsonian Astrophysical Observation", "SAO 30765"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.90267541),
        dec: Angle.Degrees(+58.97536943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 130.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38127"},
        {"Hipparcos Number", "HIP 27322"},
        {"Geneva Identification System", "GEN# +1.00038127"},
        {"Smithsonian Astrophysical Observation", "SAO 25367"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.82260628),
        dec: Angle.Degrees(+58.97538446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103539",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103539"},
        {"Smithsonian Astrophysical Observation", "SAO 33043"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.65074983),
        dec: Angle.Degrees(+58.97608424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57421"},
        {"Hipparcos Number", "HIP 35954"},
        {"Geneva Identification System", "GEN# +1.00057421"},
        {"Smithsonian Astrophysical Observation", "SAO 26325"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.17532974),
        dec: Angle.Degrees(+58.97649639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16556"},
        {"Hipparcos Number", "HIP 12572"},
        {"Geneva Identification System", "GEN# +1.00016556"},
        {"Smithsonian Astrophysical Observation", "SAO 23534"},
        {"Wilson Evans Batten Catalogue", "WEB 2566"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.42008454),
        dec: Angle.Degrees(+58.97744549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238262"},
        {"Hipparcos Number", "HIP 66564"},
        {"Smithsonian Astrophysical Observation", "SAO 28828"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.936,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.67728332),
        dec: Angle.Degrees(+58.98114461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21088",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Stein 2051A"},
        {"Common Name 2", "Stein 2051"},
        {"Hipparcos Number", "HIP 21088"},
    },
    visualMagnitude: 10.82,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.79185895),
        dec: Angle.Degrees(+58.98205252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1300.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2048.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239646"},
        {"Hipparcos Number", "HIP 105587"},
        {"Smithsonian Astrophysical Observation", "SAO 33379"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.79317206),
        dec: Angle.Degrees(+58.98335265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218468"},
        {"Hipparcos Number", "HIP 114186"},
        {"Smithsonian Astrophysical Observation", "SAO 35156"},
        {"Wilson Evans Batten Catalogue", "WEB 20277"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.85831866),
        dec: Angle.Degrees(+58.98974375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240372"},
        {"Hipparcos Number", "HIP 117009"},
        {"Geneva Identification System", "GEN# +1.00240372"},
        {"Smithsonian Astrophysical Observation", "SAO 35703"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.763,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.80550265),
        dec: Angle.Degrees(+58.99057513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121104"},
        {"Hipparcos Number", "HIP 67672"},
        {"Smithsonian Astrophysical Observation", "SAO 28913"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.96089509),
        dec: Angle.Degrees(+58.99114905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125657"},
        {"Hipparcos Number", "HIP 69942"},
        {"Smithsonian Astrophysical Observation", "SAO 29097"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.69280256),
        dec: Angle.Degrees(+58.99739812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196904"},
        {"Hipparcos Number", "HIP 101770"},
        {"Geneva Identification System", "GEN# +1.00196904"},
        {"Smithsonian Astrophysical Observation", "SAO 32745"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.38711966),
        dec: Angle.Degrees(+59.00288979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123155"},
        {"Hipparcos Number", "HIP 68730"},
        {"Smithsonian Astrophysical Observation", "SAO 28996"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.04129118),
        dec: Angle.Degrees(+59.00716481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240016"},
        {"Hipparcos Number", "HIP 111848"},
        {"Smithsonian Astrophysical Observation", "SAO 34663"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.84395698),
        dec: Angle.Degrees(+59.00716660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216411"},
        {"Hipparcos Number", "HIP 112881"},
        {"Geneva Identification System", "GEN# +1.00216411"},
        {"Smithsonian Astrophysical Observation", "SAO 34881"},
        {"Wilson Evans Batten Catalogue", "WEB 20104"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.89075456),
        dec: Angle.Degrees(+59.00855885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43378"},
        {"Hipparcos Number", "HIP 30060"},
        {"Fundamental Katalog 5th Edition", "FK5 237"},
        {"Geneva Identification System", "GEN# +1.00043378"},
        {"Smithsonian Astrophysical Observation", "SAO 25665"},
        {"Wilson Evans Batten Catalogue", "WEB 5976"},
    },
    visualMagnitude: 4.44,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.90579498),
        dec: Angle.Degrees(+59.01090518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102587"},
        {"Hipparcos Number", "HIP 57614"},
        {"Smithsonian Astrophysical Observation", "SAO 28154"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.19763376),
        dec: Angle.Degrees(+59.01207122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238511"},
        {"Hipparcos Number", "HIP 77557"},
        {"Smithsonian Astrophysical Observation", "SAO 29686"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.52425360),
        dec: Angle.Degrees(+59.01304631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105546"},
        {"Hipparcos Number", "HIP 59239"},
        {"Geneva Identification System", "GEN# +1.00105546"},
        {"Smithsonian Astrophysical Observation", "SAO 28260"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.26148527),
        dec: Angle.Degrees(+59.01825957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166639"},
        {"Hipparcos Number", "HIP 88830"},
        {"Smithsonian Astrophysical Observation", "SAO 30767"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.99110230),
        dec: Angle.Degrees(+59.02079515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32357"},
        {"Hipparcos Number", "HIP 23743"},
        {"Geneva Identification System", "GEN# +1.00032357"},
        {"Smithsonian Astrophysical Observation", "SAO 25003"},
        {"Wilson Evans Batten Catalogue", "WEB 4633"},
    },
    visualMagnitude: 6.08,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.55058067),
        dec: Angle.Degrees(+59.02140336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213758"},
        {"Hipparcos Number", "HIP 111266"},
        {"Geneva Identification System", "GEN# +1.00213758"},
        {"Smithsonian Astrophysical Observation", "SAO 34559"},
        {"Wilson Evans Batten Catalogue", "WEB 19907"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.12737543),
        dec: Angle.Degrees(+59.02704315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69446",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69446"},
    },
    visualMagnitude: 10.97,
    bvColour: 1.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.26644450),
        dec: Angle.Degrees(+59.02893202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73614"},
        {"Hipparcos Number", "HIP 42693"},
        {"Geneva Identification System", "GEN# +1.00073614"},
        {"Smithsonian Astrophysical Observation", "SAO 26966"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.52607514),
        dec: Angle.Degrees(+59.02941499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33102"},
        {"Hipparcos Number", "HIP 24195"},
        {"Smithsonian Astrophysical Observation", "SAO 25063"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.92101120),
        dec: Angle.Degrees(+59.03062530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159023"},
        {"Hipparcos Number", "HIP 85522"},
        {"Geneva Identification System", "GEN# +1.00159023"},
        {"Smithsonian Astrophysical Observation", "SAO 30416"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.16422474),
        dec: Angle.Degrees(+59.03532613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150944"},
        {"Hipparcos Number", "HIP 81656"},
        {"Geneva Identification System", "GEN# +1.00150944"},
        {"Smithsonian Astrophysical Observation", "SAO 30047"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.20660156),
        dec: Angle.Degrees(+59.03568178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 139.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48319",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7534 A"},
        {"Henry Draper", "HD 84999"},
        {"Hipparcos Number", "HIP 48319"},
        {"Fundamental Katalog 5th Edition", "FK5 368"},
        {"Geneva Identification System", "GEN# +1.00084999"},
        {"Smithsonian Astrophysical Observation", "SAO 27401"},
        {"Wilson Evans Batten Catalogue", "WEB 9009"},
    },
    visualMagnitude: 3.78,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.74871542),
        dec: Angle.Degrees(+59.03910437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -294.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -151.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162970"},
        {"Hipparcos Number", "HIP 87291"},
        {"Geneva Identification System", "GEN# +1.00162970"},
        {"Smithsonian Astrophysical Observation", "SAO 30604"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.54042419),
        dec: Angle.Degrees(+59.04020789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238385"},
        {"Hipparcos Number", "HIP 71959"},
        {"Smithsonian Astrophysical Observation", "SAO 29253"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.76815630),
        dec: Angle.Degrees(+59.04206571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89446"},
        {"Hipparcos Number", "HIP 50683"},
        {"Smithsonian Astrophysical Observation", "SAO 27612"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.25576191),
        dec: Angle.Degrees(+59.04527878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7844"},
        {"Hipparcos Number", "HIP 6181"},
        {"Smithsonian Astrophysical Observation", "SAO 22178"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.82677375),
        dec: Angle.Degrees(+59.04664013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65301"},
        {"Hipparcos Number", "HIP 39221"},
        {"Geneva Identification System", "GEN# +1.00065301"},
        {"Smithsonian Astrophysical Observation", "SAO 26618"},
        {"Wilson Evans Batten Catalogue", "WEB 7690"},
    },
    visualMagnitude: 5.78,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.33644785),
        dec: Angle.Degrees(+59.04731836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94191"},
        {"Hipparcos Number", "HIP 53237"},
        {"Geneva Identification System", "GEN# +1.00094191"},
        {"Smithsonian Astrophysical Observation", "SAO 27814"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.34628572),
        dec: Angle.Degrees(+59.04957646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236579"},
        {"Hipparcos Number", "HIP 4397"},
        {"Geneva Identification System", "GEN# +1.00236579"},
        {"Smithsonian Astrophysical Observation", "SAO 21851"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.09572836),
        dec: Angle.Degrees(+59.05028080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203627"},
        {"Hipparcos Number", "HIP 105420"},
        {"Geneva Identification System", "GEN# +1.00203627"},
        {"Smithsonian Astrophysical Observation", "SAO 33349"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.29389846),
        dec: Angle.Degrees(+59.05141687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10107"},
        {"Hipparcos Number", "HIP 7812"},
        {"Geneva Identification System", "GEN# +1.00010107"},
        {"Smithsonian Astrophysical Observation", "SAO 22496"},
    },
    visualMagnitude: 6.97,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.12903781),
        dec: Angle.Degrees(+59.05286960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63123"},
        {"Hipparcos Number", "HIP 38279"},
        {"Geneva Identification System", "GEN# +1.00063123"},
        {"Smithsonian Astrophysical Observation", "SAO 26527"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.64110087),
        dec: Angle.Degrees(+59.05306722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237801"},
        {"Hipparcos Number", "HIP 45877"},
        {"Smithsonian Astrophysical Observation", "SAO 27216"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.32314702),
        dec: Angle.Degrees(+59.05331714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135244"},
        {"Hipparcos Number", "HIP 74316"},
        {"Smithsonian Astrophysical Observation", "SAO 29439"},
        {"Wilson Evans Batten Catalogue", "WEB 12687"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.85050202),
        dec: Angle.Degrees(+59.05389255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236667"},
        {"Hipparcos Number", "HIP 5755"},
        {"Smithsonian Astrophysical Observation", "SAO 22110"},
        {"Wilson Evans Batten Catalogue", "WEB 1312"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.46959536),
        dec: Angle.Degrees(+59.05509843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75487"},
        {"Hipparcos Number", "HIP 43624"},
        {"Geneva Identification System", "GEN# +1.00075487"},
        {"Smithsonian Astrophysical Observation", "SAO 27026"},
        {"Wilson Evans Batten Catalogue", "WEB 8402"},
    },
    visualMagnitude: 6.35,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.27470567),
        dec: Angle.Degrees(+59.05614282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82257",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82257"},
        {"Geneva Identification System", "GEN# +9.80226029"},
    },
    visualMagnitude: 12.24,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.10618044),
        dec: Angle.Degrees(+59.05701864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 139.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -292.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239758"},
        {"Hipparcos Number", "HIP 107353"},
        {"Geneva Identification System", "GEN# +4.35371331"},
        {"Smithsonian Astrophysical Observation", "SAO 33715"},
        {"Wilson Evans Batten Catalogue", "WEB 19388"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.14172015),
        dec: Angle.Degrees(+59.05714928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1334"},
        {"Hipparcos Number", "HIP 1428"},
        {"Fundamental Katalog 5th Edition", "FK5 4032"},
        {"Geneva Identification System", "GEN# +1.00001334"},
        {"Smithsonian Astrophysical Observation", "SAO 21277"},
        {"Wilson Evans Batten Catalogue", "WEB 258"},
    },
    visualMagnitude: 7.71,
    bvColour: -0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.45990066),
        dec: Angle.Degrees(+59.05758956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238164"},
        {"Hipparcos Number", "HIP 62667"},
        {"Smithsonian Astrophysical Observation", "SAO 28532"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.61889267),
        dec: Angle.Degrees(+59.05777652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80863",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80863"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.826,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.68424682),
        dec: Angle.Degrees(+59.06070883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93074"},
        {"Hipparcos Number", "HIP 52663"},
        {"Smithsonian Astrophysical Observation", "SAO 27759"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.53213093),
        dec: Angle.Degrees(+59.06088665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54099"},
        {"Hipparcos Number", "HIP 34703"},
        {"Smithsonian Astrophysical Observation", "SAO 26197"},
        {"Wilson Evans Batten Catalogue", "WEB 6936"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.81369105),
        dec: Angle.Degrees(+59.06461663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84203",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84203"},
    },
    visualMagnitude: 9.92,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.18794972),
        dec: Angle.Degrees(+59.06564896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -319.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 357.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16310"},
        {"Hipparcos Number", "HIP 12379"},
        {"Geneva Identification System", "GEN# +1.00016310"},
        {"Smithsonian Astrophysical Observation", "SAO 23497"},
        {"Wilson Evans Batten Catalogue", "WEB 2535"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.84595563),
        dec: Angle.Degrees(+59.06651656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119347"},
        {"Hipparcos Number", "HIP 66774"},
        {"Smithsonian Astrophysical Observation", "SAO 28851"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.847,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.29316965),
        dec: Angle.Degrees(+59.06733707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -218.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 90.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238138"},
        {"Hipparcos Number", "HIP 61410"},
        {"Smithsonian Astrophysical Observation", "SAO 28434"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.929,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.75174414),
        dec: Angle.Degrees(+59.06938046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123046"},
        {"Hipparcos Number", "HIP 68676"},
        {"Smithsonian Astrophysical Observation", "SAO 28992"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.87819001),
        dec: Angle.Degrees(+59.06952052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73469"},
        {"Hipparcos Number", "HIP 42645"},
        {"Geneva Identification System", "GEN# +1.00073469"},
        {"Smithsonian Astrophysical Observation", "SAO 26961"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.35460123),
        dec: Angle.Degrees(+59.07126442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64600",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64600"},
    },
    visualMagnitude: 11.21,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.60809183),
        dec: Angle.Degrees(+59.07184701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -650.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239566"},
        {"Hipparcos Number", "HIP 104021"},
        {"Smithsonian Astrophysical Observation", "SAO 33113"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.11480201),
        dec: Angle.Degrees(+59.07251071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238656"},
        {"Hipparcos Number", "HIP 83741"},
        {"Smithsonian Astrophysical Observation", "SAO 30255"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.72551071),
        dec: Angle.Degrees(+59.07538442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122299"},
        {"Hipparcos Number", "HIP 68331"},
        {"Smithsonian Astrophysical Observation", "SAO 28961"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.81920368),
        dec: Angle.Degrees(+59.07772526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240485"},
        {"Hipparcos Number", "HIP 268"},
        {"Smithsonian Astrophysical Observation", "SAO 21039"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.84180567),
        dec: Angle.Degrees(+59.07861165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18077"},
        {"Hipparcos Number", "HIP 13729"},
        {"Smithsonian Astrophysical Observation", "SAO 23716"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.20432881),
        dec: Angle.Degrees(+59.07956783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210905"},
        {"Hipparcos Number", "HIP 109585"},
        {"Geneva Identification System", "GEN# +1.00210905"},
        {"Smithsonian Astrophysical Observation", "SAO 34158"},
        {"Wilson Evans Batten Catalogue", "WEB 19691"},
    },
    visualMagnitude: 6.29,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.98642744),
        dec: Angle.Degrees(+59.08438564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 130.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 79.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38102",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6363 A"},
        {"Henry Draper", "HD 62667"},
        {"Hipparcos Number", "HIP 38102"},
        {"Geneva Identification System", "GEN# +1.00062667"},
        {"Smithsonian Astrophysical Observation", "SAO 26511"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.12015918),
        dec: Angle.Degrees(+59.08485166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18076"},
        {"Hipparcos Number", "HIP 13736"},
        {"Geneva Identification System", "GEN# +1.00018076"},
        {"Smithsonian Astrophysical Observation", "SAO 23717"},
        {"Wilson Evans Batten Catalogue", "WEB 2722"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.21812835),
        dec: Angle.Degrees(+59.08893371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144654"},
        {"Hipparcos Number", "HIP 78676"},
        {"Smithsonian Astrophysical Observation", "SAO 29780"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.92309608),
        dec: Angle.Degrees(+59.08965074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104164"},
        {"Hipparcos Number", "HIP 58503"},
        {"Smithsonian Astrophysical Observation", "SAO 28212"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.96210081),
        dec: Angle.Degrees(+59.09170118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2387"},
        {"Hipparcos Number", "HIP 2223"},
        {"Smithsonian Astrophysical Observation", "SAO 21421"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.04949296),
        dec: Angle.Degrees(+59.09215850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103318",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14458 AB"},
        {"Henry Draper", "HD 199645"},
        {"Hipparcos Number", "HIP 103318"},
        {"Smithsonian Astrophysical Observation", "SAO 33003"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.98312609),
        dec: Angle.Degrees(+59.09331150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69805"},
        {"Hipparcos Number", "HIP 40976"},
        {"Smithsonian Astrophysical Observation", "SAO 26793"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.42720103),
        dec: Angle.Degrees(+59.09453568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239196"},
        {"Hipparcos Number", "HIP 97098"},
        {"Smithsonian Astrophysical Observation", "SAO 31943"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.99549707),
        dec: Angle.Degrees(+59.09521052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238481"},
        {"Hipparcos Number", "HIP 76332"},
        {"Smithsonian Astrophysical Observation", "SAO 29587"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.88084714),
        dec: Angle.Degrees(+59.09730231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60982"},
        {"Hipparcos Number", "HIP 37386"},
        {"Smithsonian Astrophysical Observation", "SAO 26455"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.11645835),
        dec: Angle.Degrees(+59.09780049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101090"},
        {"Hipparcos Number", "HIP 56777"},
        {"Geneva Identification System", "GEN# +1.00101090"},
        {"Smithsonian Astrophysical Observation", "SAO 28084"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.60830764),
        dec: Angle.Degrees(+59.09921943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237081"},
        {"Hipparcos Number", "HIP 14789"},
        {"Smithsonian Astrophysical Observation", "SAO 23851"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.74937858),
        dec: Angle.Degrees(+59.10116260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11317"},
        {"Hipparcos Number", "HIP 8791"},
        {"Geneva Identification System", "GEN# +1.00011317"},
        {"Smithsonian Astrophysical Observation", "SAO 22704"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.25938388),
        dec: Angle.Degrees(+59.10212861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8237",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8237"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.51175411),
        dec: Angle.Degrees(+59.10218077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105883",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105883"},
        {"Celescope Catalog", "CEL 5315"},
        {"Geneva Identification System", "GEN# +0.05802265"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.67276485),
        dec: Angle.Degrees(+59.10400703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15000"},
        {"Hipparcos Number", "HIP 11429"},
        {"Geneva Identification System", "GEN# +1.00015000"},
        {"Smithsonian Astrophysical Observation", "SAO 23340"},
        {"Wilson Evans Batten Catalogue", "WEB 2385"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.85465533),
        dec: Angle.Degrees(+59.10582421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 119.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106530",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15113 A"},
        {"Henry Draper", "HD 239706"},
        {"Hipparcos Number", "HIP 106530"},
        {"Geneva Identification System", "GEN# +1.00239706"},
        {"Smithsonian Astrophysical Observation", "SAO 33547"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.64521822),
        dec: Angle.Degrees(+59.10660990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47700"},
        {"Hipparcos Number", "HIP 32230"},
        {"Smithsonian Astrophysical Observation", "SAO 25907"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.92479240),
        dec: Angle.Degrees(+59.10796588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
