using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_4() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203881"},
        {"Hipparcos Number", "HIP 106044"},
        {"Fundamental Katalog 5th Edition", "FK5 3712"},
        {"Geneva Identification System", "GEN# +1.00203881"},
        {"Smithsonian Astrophysical Observation", "SAO 255003"},
        {"Wilson Evans Batten Catalogue", "WEB 19220"},
    },
    visualMagnitude: 5.47,
    bvColour: 1.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.18661378),
        dec: Angle.Degrees(-69.50527320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5190"},
        {"Hipparcos Number", "HIP 4084"},
        {"Geneva Identification System", "GEN# +1.00005190"},
        {"Smithsonian Astrophysical Observation", "SAO 248269"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.10213860),
        dec: Angle.Degrees(-69.50359643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85194"},
        {"Hipparcos Number", "HIP 47992"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.72753283),
        dec: Angle.Degrees(-69.50341036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5208"},
        {"Hipparcos Number", "HIP 4088"},
        {"Geneva Identification System", "GEN# +1.00005208"},
        {"Smithsonian Astrophysical Observation", "SAO 248271"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.11818630),
        dec: Angle.Degrees(-69.50273658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63928"},
        {"Hipparcos Number", "HIP 37895"},
        {"Smithsonian Astrophysical Observation", "SAO 249962"},
    },
    visualMagnitude: 8.70,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.50273706),
        dec: Angle.Degrees(-69.49801380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31474",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31474"},
    },
    visualMagnitude: 11.24,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.89091750),
        dec: Angle.Degrees(-69.49201695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 182.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 173.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204507"},
        {"Hipparcos Number", "HIP 106376"},
        {"Geneva Identification System", "GEN# +1.00204507"},
        {"Smithsonian Astrophysical Observation", "SAO 255017"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.17172010),
        dec: Angle.Degrees(-69.48979459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85473",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85473"},
    },
    visualMagnitude: 11.91,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.00877283),
        dec: Angle.Degrees(-69.33946439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41158"},
        {"Hipparcos Number", "HIP 28179"},
        {"Geneva Identification System", "GEN# +1.00041158"},
        {"Smithsonian Astrophysical Observation", "SAO 249403"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.30889179),
        dec: Angle.Degrees(-69.47808548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 74.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108073"},
        {"Hipparcos Number", "HIP 60627"},
        {"Celescope Catalog", "CEL 4102"},
        {"Geneva Identification System", "GEN# +1.00108073"},
        {"Smithsonian Astrophysical Observation", "SAO 251894"},
    },
    visualMagnitude: 7.86,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.37696761),
        dec: Angle.Degrees(-69.47667900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108073B"},
        {"Hipparcos Number", "HIP 60629"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.38622057),
        dec: Angle.Degrees(-69.47526879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164075"},
        {"Hipparcos Number", "HIP 88594"},
        {"Geneva Identification System", "GEN# +1.00164075"},
        {"Smithsonian Astrophysical Observation", "SAO 254127"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.34166603),
        dec: Angle.Degrees(-69.47469562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215505"},
        {"Hipparcos Number", "HIP 112525"},
        {"Geneva Identification System", "GEN# +1.00215505"},
        {"Smithsonian Astrophysical Observation", "SAO 255315"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.88477745),
        dec: Angle.Degrees(-69.47455250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37722"},
        {"Hipparcos Number", "HIP 26167"},
        {"Geneva Identification System", "GEN# +1.00037722"},
        {"Smithsonian Astrophysical Observation", "SAO 249318"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.68284788),
        dec: Angle.Degrees(-69.47185392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102776",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102776"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.32798121),
        dec: Angle.Degrees(-69.47159506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -196.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38335",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38335"},
    },
    visualMagnitude: 10.87,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.78453763),
        dec: Angle.Degrees(-69.46617978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207429"},
        {"Hipparcos Number", "HIP 107950"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.04859207),
        dec: Angle.Degrees(-69.46431508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 311316"},
        {"Hipparcos Number", "HIP 40599"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.33132834),
        dec: Angle.Degrees(-69.46417625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 268654"},
        {"Hipparcos Number", "HIP 22392"},
        {"Geneva Identification System", "GEN# +1.00268654"},
    },
    visualMagnitude: 10.50,
    bvColour: 0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.30164537),
        dec: Angle.Degrees(-69.45653062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30083"},
        {"Hipparcos Number", "HIP 21635"},
        {"Smithsonian Astrophysical Observation", "SAO 249074"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.70740129),
        dec: Angle.Degrees(-69.45417495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127453"},
        {"Hipparcos Number", "HIP 71314"},
        {"Geneva Identification System", "GEN# +1.00127453"},
        {"Renson", "Renson 36240"},
        {"Smithsonian Astrophysical Observation", "SAO 252795"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.74995670),
        dec: Angle.Degrees(-69.45317638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216825"},
        {"Hipparcos Number", "HIP 113388"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.46138640),
        dec: Angle.Degrees(-69.45201226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195573"},
        {"Hipparcos Number", "HIP 101699"},
        {"Smithsonian Astrophysical Observation", "SAO 254825"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.20445187),
        dec: Angle.Degrees(-69.45062939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134300"},
        {"Hipparcos Number", "HIP 74495"},
        {"Smithsonian Astrophysical Observation", "SAO 253054"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.34177102),
        dec: Angle.Degrees(-69.45035101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204556"},
        {"Hipparcos Number", "HIP 106392"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.871,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.23433489),
        dec: Angle.Degrees(-69.44956383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93210"},
        {"Hipparcos Number", "HIP 52477"},
        {"Geneva Identification System", "GEN# +1.00093210"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.92853790),
        dec: Angle.Degrees(-69.44867181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24259"},
        {"Hipparcos Number", "HIP 17633"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.67374935),
        dec: Angle.Degrees(-69.44590301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48322"},
        {"Hipparcos Number", "HIP 31611"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.24465720),
        dec: Angle.Degrees(-69.44422392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212806"},
        {"Hipparcos Number", "HIP 110999"},
        {"Smithsonian Astrophysical Observation", "SAO 255228"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.32621305),
        dec: Angle.Degrees(-69.43785072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93739"},
        {"Hipparcos Number", "HIP 52785"},
        {"Geneva Identification System", "GEN# +1.00093739"},
        {"Smithsonian Astrophysical Observation", "SAO 251127"},
    },
    visualMagnitude: 6.35,
    bvColour: -0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.87756549),
        dec: Angle.Degrees(-69.43773364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185189"},
        {"Hipparcos Number", "HIP 97042"},
        {"Smithsonian Astrophysical Observation", "SAO 254631"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.83354426),
        dec: Angle.Degrees(-69.43740468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222551"},
        {"Hipparcos Number", "HIP 116927"},
        {"Geneva Identification System", "GEN# +1.00222551"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.51167200),
        dec: Angle.Degrees(-69.43699433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192273"},
        {"Hipparcos Number", "HIP 100170"},
    },
    visualMagnitude: 8.84,
    bvColour: -0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.77635786),
        dec: Angle.Degrees(-69.43512605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40856"},
        {"Hipparcos Number", "HIP 28016"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.88994657),
        dec: Angle.Degrees(-69.43359856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100531",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100531"},
    },
    visualMagnitude: 11.67,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.76708873),
        dec: Angle.Degrees(-69.43275501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3463"},
        {"Hipparcos Number", "HIP 2887"},
        {"Geneva Identification System", "GEN# +1.00003463"},
        {"Smithsonian Astrophysical Observation", "SAO 248226"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.14997001),
        dec: Angle.Degrees(-69.43238252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14355"},
        {"Hipparcos Number", "HIP 10548"},
        {"Geneva Identification System", "GEN# +1.00014355"},
        {"Smithsonian Astrophysical Observation", "SAO 248522"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.96446980),
        dec: Angle.Degrees(-69.43217892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 159.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14835"},
        {"Hipparcos Number", "HIP 10882"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.01398246),
        dec: Angle.Degrees(-69.43145757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193027"},
        {"Hipparcos Number", "HIP 100525"},
        {"Smithsonian Astrophysical Observation", "SAO 254780"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.75509162),
        dec: Angle.Degrees(-69.42840240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156448"},
        {"Hipparcos Number", "HIP 85093"},
        {"Smithsonian Astrophysical Observation", "SAO 253888"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.87336483),
        dec: Angle.Degrees(-69.42359496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99454"},
        {"Hipparcos Number", "HIP 55771"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.41449925),
        dec: Angle.Degrees(-69.41836649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81295"},
        {"Hipparcos Number", "HIP 45852"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.22326502),
        dec: Angle.Degrees(-69.41650000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51492"},
        {"Hipparcos Number", "HIP 32953"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.95581500),
        dec: Angle.Degrees(-69.41595768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152904"},
        {"Hipparcos Number", "HIP 83327"},
        {"Smithsonian Astrophysical Observation", "SAO 253767"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.45841492),
        dec: Angle.Degrees(-69.40995596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180284"},
        {"Hipparcos Number", "HIP 95151"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.38975186),
        dec: Angle.Degrees(-69.40865643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149556"},
        {"Hipparcos Number", "HIP 81676"},
        {"Smithsonian Astrophysical Observation", "SAO 253647"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.27055817),
        dec: Angle.Degrees(-69.40790872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180808"},
        {"Hipparcos Number", "HIP 95315"},
        {"Smithsonian Astrophysical Observation", "SAO 254545"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.88040470),
        dec: Angle.Degrees(-69.40761167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110311"},
        {"Hipparcos Number", "HIP 61981"},
        {"Geneva Identification System", "GEN# +1.00110311"},
        {"Smithsonian Astrophysical Observation", "SAO 251996"},
        {"Wilson Evans Batten Catalogue", "WEB 11022"},
    },
    visualMagnitude: 6.31,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.52097535),
        dec: Angle.Degrees(-69.40755080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31722"},
        {"Hipparcos Number", "HIP 22656"},
        {"Geneva Identification System", "GEN# +1.00031722"},
        {"Smithsonian Astrophysical Observation", "SAO 249134"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.10066036),
        dec: Angle.Degrees(-69.40394263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202693"},
        {"Hipparcos Number", "HIP 105442"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.35179267),
        dec: Angle.Degrees(-69.40373971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120404"},
        {"Hipparcos Number", "HIP 67664"},
        {"Fundamental Katalog 5th Edition", "FK5 3099"},
        {"Geneva Identification System", "GEN# +1.00120404"},
        {"Smithsonian Astrophysical Observation", "SAO 252481"},
    },
    visualMagnitude: 5.73,
    bvColour: 1.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.94759834),
        dec: Angle.Degrees(-69.40124669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28032"},
        {"Hipparcos Number", "HIP 20223"},
        {"Smithsonian Astrophysical Observation", "SAO 249000"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.99830676),
        dec: Angle.Degrees(-69.39864183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141862"},
        {"Hipparcos Number", "HIP 78051"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.03474966),
        dec: Angle.Degrees(-69.39482193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104568"},
        {"Hipparcos Number", "HIP 58709"},
        {"Geneva Identification System", "GEN# +1.00104568"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.62268973),
        dec: Angle.Degrees(-69.39415936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111251"},
        {"Hipparcos Number", "HIP 62558"},
        {"Geneva Identification System", "GEN# +1.00111251"},
        {"Smithsonian Astrophysical Observation", "SAO 252037"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.27033048),
        dec: Angle.Degrees(-69.39239742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39829",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39829"},
    },
    visualMagnitude: 12.38,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.06136102),
        dec: Angle.Degrees(-69.39154209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28602"},
        {"Hipparcos Number", "HIP 20620"},
        {"Smithsonian Astrophysical Observation", "SAO 249022"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.27553369),
        dec: Angle.Degrees(-69.38954641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171847"},
        {"Hipparcos Number", "HIP 91760"},
        {"Geneva Identification System", "GEN# +1.00171847"},
        {"Smithsonian Astrophysical Observation", "SAO 254339"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.67375694),
        dec: Angle.Degrees(-69.38702979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168741"},
        {"Hipparcos Number", "HIP 90429"},
        {"Smithsonian Astrophysical Observation", "SAO 254242"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.76465484),
        dec: Angle.Degrees(-69.38106614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130798"},
        {"Hipparcos Number", "HIP 72909"},
        {"Smithsonian Astrophysical Observation", "SAO 252941"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.52250771),
        dec: Angle.Degrees(-69.37307290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96974",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96974"},
    },
    visualMagnitude: 11.66,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.68149365),
        dec: Angle.Degrees(-69.37192065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -367.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206481"},
        {"Hipparcos Number", "HIP 107443"},
        {"Geneva Identification System", "GEN# +1.00206481"},
        {"Smithsonian Astrophysical Observation", "SAO 255064"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.43359851),
        dec: Angle.Degrees(-69.36369314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92315"},
        {"Hipparcos Number", "HIP 51991"},
        {"Renson", "Renson 26570"},
        {"Smithsonian Astrophysical Observation", "SAO 251037"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.33572524),
        dec: Angle.Degrees(-69.36257682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219560"},
        {"Hipparcos Number", "HIP 115026"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.44877852),
        dec: Angle.Degrees(-69.36186513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115952"},
        {"Hipparcos Number", "HIP 65259"},
        {"Geneva Identification System", "GEN# +1.00115952"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.61644774),
        dec: Angle.Degrees(-69.36112936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87803"},
        {"Hipparcos Number", "HIP 49354"},
        {"Smithsonian Astrophysical Observation", "SAO 250803"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.13140004),
        dec: Angle.Degrees(-69.35564548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91985"},
        {"Hipparcos Number", "HIP 51810"},
        {"Smithsonian Astrophysical Observation", "SAO 251025"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.77589498),
        dec: Angle.Degrees(-69.35143381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84603"},
        {"Hipparcos Number", "HIP 47663"},
        {"Geneva Identification System", "GEN# +1.00084603"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.77518599),
        dec: Angle.Degrees(-69.35037184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 258.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -162.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32858"},
        {"Hipparcos Number", "HIP 23276"},
        {"Geneva Identification System", "GEN# +1.00032858"},
        {"Smithsonian Astrophysical Observation", "SAO 249166"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.11700716),
        dec: Angle.Degrees(-69.35024427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11882"},
        {"Hipparcos Number", "HIP 8849"},
        {"Smithsonian Astrophysical Observation", "SAO 248459"},
    },
    visualMagnitude: 9.46,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.45896179),
        dec: Angle.Degrees(-69.34986527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112369"},
        {"Hipparcos Number", "HIP 63238"},
        {"Geneva Identification System", "GEN# +1.00112369"},
        {"Smithsonian Astrophysical Observation", "SAO 252104"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.36688741),
        dec: Angle.Degrees(-69.34428674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88316",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88316"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.816,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.54327252),
        dec: Angle.Degrees(-69.33998944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -327.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186483"},
        {"Hipparcos Number", "HIP 97580"},
        {"Smithsonian Astrophysical Observation", "SAO 254656"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.51050027),
        dec: Angle.Degrees(-69.33913334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184358"},
        {"Hipparcos Number", "HIP 96686"},
        {"Geneva Identification System", "GEN# +1.00184358"},
        {"Smithsonian Astrophysical Observation", "SAO 254617"},
        {"Wilson Evans Batten Catalogue", "WEB 16960"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.85033112),
        dec: Angle.Degrees(-69.33788886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21722"},
        {"Hipparcos Number", "HIP 15968"},
        {"Fundamental Katalog 5th Edition", "FK5 2243"},
        {"Geneva Identification System", "GEN# +1.00021722"},
        {"Smithsonian Astrophysical Observation", "SAO 248804"},
        {"Wilson Evans Batten Catalogue", "WEB 3049"},
    },
    visualMagnitude: 5.96,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.40105611),
        dec: Angle.Degrees(-69.33659399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90121"},
        {"Hipparcos Number", "HIP 50741"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.41996895),
        dec: Angle.Degrees(-69.33308483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58141"},
        {"Hipparcos Number", "HIP 35403"},
        {"Smithsonian Astrophysical Observation", "SAO 249821"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.65462558),
        dec: Angle.Degrees(-69.32718891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99301"},
        {"Hipparcos Number", "HIP 55688"},
    },
    visualMagnitude: 9.94,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.15602417),
        dec: Angle.Degrees(-69.32630708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147465"},
        {"Hipparcos Number", "HIP 80606"},
        {"Smithsonian Astrophysical Observation", "SAO 253549"},
    },
    visualMagnitude: 6.68,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.87320788),
        dec: Angle.Degrees(-69.32597467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90103"},
        {"Hipparcos Number", "HIP 50734"},
        {"Geneva Identification System", "GEN# +1.00090103"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.39822510),
        dec: Angle.Degrees(-69.32159311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 118.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34276"},
        {"Hipparcos Number", "HIP 24090"},
        {"Smithsonian Astrophysical Observation", "SAO 249214"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.62511773),
        dec: Angle.Degrees(-69.32039113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168951"},
        {"Hipparcos Number", "HIP 90514"},
        {"Smithsonian Astrophysical Observation", "SAO 254249"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.03088026),
        dec: Angle.Degrees(-69.31433626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12646"},
        {"Hipparcos Number", "HIP 9407"},
        {"Smithsonian Astrophysical Observation", "SAO 248479"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.21056325),
        dec: Angle.Degrees(-69.31290487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21426"},
        {"Hipparcos Number", "HIP 15730"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.66345003),
        dec: Angle.Degrees(-69.31245456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125605"},
        {"Hipparcos Number", "HIP 70367"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.95569155),
        dec: Angle.Degrees(-69.31222148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148222"},
        {"Hipparcos Number", "HIP 80962"},
        {"Renson", "Renson 41880"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.98305383),
        dec: Angle.Degrees(-69.30958624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6452",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6452"},
    },
    visualMagnitude: 12.35,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.72591122),
        dec: Angle.Degrees(-69.30873441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 256.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 118.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140644"},
        {"Hipparcos Number", "HIP 77509"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.39478073),
        dec: Angle.Degrees(-69.30818304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2354"},
        {"Hipparcos Number", "HIP 2106"},
        {"Smithsonian Astrophysical Observation", "SAO 248186"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.67463754),
        dec: Angle.Degrees(-69.30705534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81320"},
        {"Hipparcos Number", "HIP 45862"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.26819383),
        dec: Angle.Degrees(-69.30447373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24882"},
        {"Hipparcos Number", "HIP 18107"},
        {"Smithsonian Astrophysical Observation", "SAO 248899"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.06713971),
        dec: Angle.Degrees(-69.30192123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181795"},
        {"Hipparcos Number", "HIP 95644"},
        {"Geneva Identification System", "GEN# +1.00181795"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.812,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.82546817),
        dec: Angle.Degrees(-69.30168517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214663"},
        {"Hipparcos Number", "HIP 112061"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.46169120),
        dec: Angle.Degrees(-69.29861178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49531"},
        {"Hipparcos Number", "HIP 32178"},
        {"Smithsonian Astrophysical Observation", "SAO 249634"},
    },
    visualMagnitude: 8.90,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.77773284),
        dec: Angle.Degrees(-69.29780651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118325"},
        {"Hipparcos Number", "HIP 66555"},
        {"Smithsonian Astrophysical Observation", "SAO 252390"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.64831056),
        dec: Angle.Degrees(-69.29426252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209721"},
        {"Hipparcos Number", "HIP 109284"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.791,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.09368944),
        dec: Angle.Degrees(-69.28649616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -192.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46369"},
        {"Hipparcos Number", "HIP 30704"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.76965079),
        dec: Angle.Degrees(-69.28631758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214069"},
        {"Hipparcos Number", "HIP 111725"},
        {"Geneva Identification System", "GEN# +1.00214069"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.47116320),
        dec: Angle.Degrees(-69.28292405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9568"},
        {"Hipparcos Number", "HIP 7101"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.87825091),
        dec: Angle.Degrees(-69.28166174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151836"},
        {"Hipparcos Number", "HIP 82804"},
        {"Smithsonian Astrophysical Observation", "SAO 253729"},
    },
    visualMagnitude: 7.25,
    bvColour: -0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.84518395),
        dec: Angle.Degrees(-69.27976384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74388"},
        {"Hipparcos Number", "HIP 42442"},
        {"Renson", "Renson 20700"},
        {"Smithsonian Astrophysical Observation", "SAO 250296"},
    },
    visualMagnitude: 6.99,
    bvColour: -0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.81017166),
        dec: Angle.Degrees(-69.27394463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92468"},
        {"Hipparcos Number", "HIP 52068"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.60633034),
        dec: Angle.Degrees(-69.27363661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212920"},
        {"Hipparcos Number", "HIP 111073"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.52944991),
        dec: Angle.Degrees(-69.27093878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82126"},
        {"Hipparcos Number", "HIP 46287"},
        {"Geneva Identification System", "GEN# +1.00082126"},
        {"Smithsonian Astrophysical Observation", "SAO 250582"},
        {"Wilson Evans Batten Catalogue", "WEB 8756"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.59247979),
        dec: Angle.Degrees(-69.26958759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224954"},
        {"Hipparcos Number", "HIP 160"},
        {"Geneva Identification System", "GEN# +1.00224954"},
        {"Smithsonian Astrophysical Observation", "SAO 255627"},
    },
    visualMagnitude: 8.68,
    bvColour: -0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.51171520),
        dec: Angle.Degrees(-69.26920741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152564"},
        {"Hipparcos Number", "HIP 83150"},
        {"Geneva Identification System", "GEN# +1.00152564"},
        {"Renson", "Renson 43220"},
        {"Smithsonian Astrophysical Observation", "SAO 253756"},
    },
    visualMagnitude: 5.79,
    bvColour: -0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.89159236),
        dec: Angle.Degrees(-69.26813178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219943"},
        {"Hipparcos Number", "HIP 115276"},
        {"Smithsonian Astrophysical Observation", "SAO 255465"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.21904598),
        dec: Angle.Degrees(-69.26769816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203373"},
        {"Hipparcos Number", "HIP 105790"},
        {"Geneva Identification System", "GEN# +1.00203373"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.837,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.37102288),
        dec: Angle.Degrees(-69.26544772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -227.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19940"},
        {"Hipparcos Number", "HIP 14547"},
        {"Geneva Identification System", "GEN# +1.00019940"},
        {"Smithsonian Astrophysical Observation", "SAO 248742"},
    },
    visualMagnitude: 6.12,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.95416193),
        dec: Angle.Degrees(-69.26495674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 269982"},
        {"Hipparcos Number", "HIP 26745"},
        {"Geneva Identification System", "GEN# +1.00269982"},
    },
    visualMagnitude: 10.80,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.24086364),
        dec: Angle.Degrees(-69.25865250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42720"},
        {"Hipparcos Number", "HIP 28926"},
        {"Smithsonian Astrophysical Observation", "SAO 249452"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.58498171),
        dec: Angle.Degrees(-69.25825587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100990"},
        {"Hipparcos Number", "HIP 56634"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.17138938),
        dec: Angle.Degrees(-69.25089747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 309911"},
        {"Hipparcos Number", "HIP 49620"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.90356393),
        dec: Angle.Degrees(-69.24770053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118913"},
        {"Hipparcos Number", "HIP 66888"},
        {"Geneva Identification System", "GEN# +1.00118913"},
        {"Renson", "Renson 34340"},
        {"Smithsonian Astrophysical Observation", "SAO 252417"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.61255515),
        dec: Angle.Degrees(-69.24690023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43868"},
        {"Hipparcos Number", "HIP 29477"},
        {"Smithsonian Astrophysical Observation", "SAO 249481"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.16249455),
        dec: Angle.Degrees(-69.24012200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200574"},
        {"Hipparcos Number", "HIP 104352"},
        {"Renson", "Renson 55910"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.10503593),
        dec: Angle.Degrees(-69.23371459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163281"},
        {"Hipparcos Number", "HIP 88236"},
        {"Geneva Identification System", "GEN# +1.00163281"},
        {"Smithsonian Astrophysical Observation", "SAO 254102"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.27525614),
        dec: Angle.Degrees(-69.23360113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17072"},
        {"Hipparcos Number", "HIP 12485"},
        {"Geneva Identification System", "GEN# +1.00017072"},
        {"Smithsonian Astrophysical Observation", "SAO 248626"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.16662061),
        dec: Angle.Degrees(-69.23297460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117445"},
        {"Hipparcos Number", "HIP 66057"},
        {"Smithsonian Astrophysical Observation", "SAO 252353"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.13654287),
        dec: Angle.Degrees(-69.23169319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112984"},
        {"Hipparcos Number", "HIP 63599"},
        {"Smithsonian Astrophysical Observation", "SAO 252131"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.49713952),
        dec: Angle.Degrees(-69.22929462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81593"},
        {"Hipparcos Number", "HIP 45993"},
        {"Smithsonian Astrophysical Observation", "SAO 250560"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.70289470),
        dec: Angle.Degrees(-69.22018718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106881"},
        {"Hipparcos Number", "HIP 59959"},
        {"Geneva Identification System", "GEN# +1.00106881"},
        {"Smithsonian Astrophysical Observation", "SAO 251833"},
    },
    visualMagnitude: 8.59,
    bvColour: -0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.46517798),
        dec: Angle.Degrees(-69.21950692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137551"},
        {"Hipparcos Number", "HIP 75993"},
        {"Renson", "Renson 39110"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.79298306),
        dec: Angle.Degrees(-69.21921417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132067"},
        {"Hipparcos Number", "HIP 73492"},
        {"Smithsonian Astrophysical Observation", "SAO 252987"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.30464243),
        dec: Angle.Degrees(-69.21858983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177590"},
        {"Hipparcos Number", "HIP 94240"},
        {"Smithsonian Astrophysical Observation", "SAO 254477"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.75374860),
        dec: Angle.Degrees(-69.21813872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101546"},
        {"Hipparcos Number", "HIP 56956"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.13467021),
        dec: Angle.Degrees(-69.21520618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177273"},
        {"Hipparcos Number", "HIP 94121"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.39255134),
        dec: Angle.Degrees(-69.21175281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60882",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60882"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.16251177),
        dec: Angle.Degrees(-69.21153485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142021"},
        {"Hipparcos Number", "HIP 78127"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.29298422),
        dec: Angle.Degrees(-69.21066070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 268757"},
        {"Hipparcos Number", "HIP 22794"},
        {"Geneva Identification System", "GEN# +1.00268757"},
    },
    visualMagnitude: 10.16,
    bvColour: 1.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.55938679),
        dec: Angle.Degrees(-69.21012248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93649"},
        {"Hipparcos Number", "HIP 52730"},
        {"Fundamental Katalog 5th Edition", "FK5 2861"},
        {"Geneva Identification System", "GEN# +1.00093649"},
        {"Smithsonian Astrophysical Observation", "SAO 251121"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.70037254),
        dec: Angle.Degrees(-69.20979312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138799"},
        {"Hipparcos Number", "HIP 76626"},
        {"Geneva Identification System", "GEN# +1.00138799"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.854,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.72604230),
        dec: Angle.Degrees(-69.20899610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -159.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190899"},
        {"Hipparcos Number", "HIP 99544"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.02348691),
        dec: Angle.Degrees(-69.20844490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79743"},
        {"Hipparcos Number", "HIP 45135"},
        {"Geneva Identification System", "GEN# +1.00079743"},
        {"Smithsonian Astrophysical Observation", "SAO 250480"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.94931382),
        dec: Angle.Degrees(-69.20340080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137714"},
        {"Hipparcos Number", "HIP 76067"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.02557917),
        dec: Angle.Degrees(-69.17331927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16334"},
        {"Hipparcos Number", "HIP 11896"},
        {"Smithsonian Astrophysical Observation", "SAO 248599"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.37252935),
        dec: Angle.Degrees(-69.19914719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104479"},
        {"Hipparcos Number", "HIP 58662"},
        {"Smithsonian Astrophysical Observation", "SAO 251688"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.43567195),
        dec: Angle.Degrees(-69.19786689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222259"},
        {"Hipparcos Number", "HIP 116748"},
        {"Smithsonian Astrophysical Observation", "SAO 255538"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.91395712),
        dec: Angle.Degrees(-69.19558694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206077"},
        {"Hipparcos Number", "HIP 107219"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.74314035),
        dec: Angle.Degrees(-69.19502987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222350"},
        {"Hipparcos Number", "HIP 116793"},
        {"Smithsonian Astrophysical Observation", "SAO 255543"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.05800587),
        dec: Angle.Degrees(-69.19464873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22909"},
        {"Hipparcos Number", "HIP 16775"},
        {"Smithsonian Astrophysical Observation", "SAO 248852"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.97079365),
        dec: Angle.Degrees(-69.19301276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104600"},
        {"Hipparcos Number", "HIP 58720"},
        {"Celescope Catalog", "CEL 4041"},
        {"Fundamental Katalog 5th Edition", "FK5 2966"},
        {"Geneva Identification System", "GEN# +1.00104600"},
        {"Smithsonian Astrophysical Observation", "SAO 251699"},
        {"Wilson Evans Batten Catalogue", "WEB 10470"},
    },
    visualMagnitude: 5.89,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.65731961),
        dec: Angle.Degrees(-69.19227106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179009"},
        {"Hipparcos Number", "HIP 94724"},
        {"Geneva Identification System", "GEN# +1.00179009"},
        {"Renson", "Renson 49760"},
        {"Smithsonian Astrophysical Observation", "SAO 254508"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.11916883),
        dec: Angle.Degrees(-69.19075492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86388"},
        {"Hipparcos Number", "HIP 48641"},
        {"Smithsonian Astrophysical Observation", "SAO 250750"},
    },
    visualMagnitude: 6.73,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.77381591),
        dec: Angle.Degrees(-69.18905000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188748"},
        {"Hipparcos Number", "HIP 98621"},
        {"Geneva Identification System", "GEN# +1.00188748"},
        {"Smithsonian Astrophysical Observation", "SAO 254705"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.46533977),
        dec: Angle.Degrees(-69.18760859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 223.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -137.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95637"},
        {"Hipparcos Number", "HIP 53825"},
        {"Geneva Identification System", "GEN# +1.00095637"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.18655455),
        dec: Angle.Degrees(-69.18625379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18186"},
        {"Hipparcos Number", "HIP 13299"},
        {"Smithsonian Astrophysical Observation", "SAO 248668"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.79238257),
        dec: Angle.Degrees(-69.18510157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102837"},
        {"Hipparcos Number", "HIP 57760"},
        {"Smithsonian Astrophysical Observation", "SAO 251608"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.67732173),
        dec: Angle.Degrees(-69.18413827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172113"},
        {"Hipparcos Number", "HIP 91896"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.01126872),
        dec: Angle.Degrees(-69.17752506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112368"},
        {"Hipparcos Number", "HIP 63234"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.35912979),
        dec: Angle.Degrees(-69.17624789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90672",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90672"},
    },
    visualMagnitude: 12.33,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.50903209),
        dec: Angle.Degrees(-68.87627552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199760"},
        {"Hipparcos Number", "HIP 103917"},
        {"Smithsonian Astrophysical Observation", "SAO 254924"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.82529883),
        dec: Angle.Degrees(-69.17109413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33487"},
        {"Hipparcos Number", "HIP 23641"},
        {"Geneva Identification System", "GEN# +1.00033487"},
        {"Smithsonian Astrophysical Observation", "SAO 249184"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.787,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.22287719),
        dec: Angle.Degrees(-69.16888348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117444"},
        {"Hipparcos Number", "HIP 66050"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.12643045),
        dec: Angle.Degrees(-69.16384531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188097"},
        {"Hipparcos Number", "HIP 98332"},
        {"Fundamental Katalog 5th Edition", "FK5 3589"},
        {"Geneva Identification System", "GEN# +1.00188097"},
        {"Renson", "Renson 51930"},
        {"Smithsonian Astrophysical Observation", "SAO 254693"},
        {"Wilson Evans Batten Catalogue", "WEB 17345"},
    },
    visualMagnitude: 5.74,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.67157464),
        dec: Angle.Degrees(-69.16371251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44864"},
        {"Hipparcos Number", "HIP 29954"},
        {"Geneva Identification System", "GEN# +1.00044864"},
        {"Smithsonian Astrophysical Observation", "SAO 249506"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.58638028),
        dec: Angle.Degrees(-69.16222172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17374"},
        {"Hipparcos Number", "HIP 12715"},
        {"Smithsonian Astrophysical Observation", "SAO 248634"},
    },
    visualMagnitude: 6.66,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.85235629),
        dec: Angle.Degrees(-69.16003745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77389"},
        {"Hipparcos Number", "HIP 44025"},
        {"Geneva Identification System", "GEN# +1.00077389"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.48218591),
        dec: Angle.Degrees(-69.15856834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7069"},
        {"Hipparcos Number", "HIP 5418"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.31277465),
        dec: Angle.Degrees(-69.15474118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127203"},
        {"Hipparcos Number", "HIP 71183"},
        {"Smithsonian Astrophysical Observation", "SAO 252785"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.37451499),
        dec: Angle.Degrees(-69.15270290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66659"},
        {"Hipparcos Number", "HIP 39060"},
    },
    visualMagnitude: 9.09,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.86587981),
        dec: Angle.Degrees(-69.15206081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198971"},
        {"Hipparcos Number", "HIP 103503"},
        {"Smithsonian Astrophysical Observation", "SAO 254907"},
    },
    visualMagnitude: 6.85,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.54856036),
        dec: Angle.Degrees(-69.14615131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181042"},
        {"Hipparcos Number", "HIP 95391"},
        {"Smithsonian Astrophysical Observation", "SAO 254553"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.07608680),
        dec: Angle.Degrees(-69.14279254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65692"},
        {"Hipparcos Number", "HIP 38641"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.68988904),
        dec: Angle.Degrees(-69.14053776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83901"},
        {"Hipparcos Number", "HIP 47281"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.52899256),
        dec: Angle.Degrees(-69.13918100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109668"},
        {"Hipparcos Number", "HIP 61585"},
        {"Celescope Catalog", "CEL 4131"},
        {"Fundamental Katalog 5th Edition", "FK5 474"},
        {"Geneva Identification System", "GEN# +1.00109668"},
        {"Smithsonian Astrophysical Observation", "SAO 251974"},
        {"Wilson Evans Batten Catalogue", "WEB 10956"},
    },
    visualMagnitude: 2.69,
    bvColour: -0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.29618208),
        dec: Angle.Degrees(-69.13553358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144755"},
        {"Hipparcos Number", "HIP 79427"},
        {"Smithsonian Astrophysical Observation", "SAO 253455"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.14867199),
        dec: Angle.Degrees(-69.13338499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135397"},
        {"Hipparcos Number", "HIP 74966"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.78864289),
        dec: Angle.Degrees(-69.13077084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119022"},
        {"Hipparcos Number", "HIP 66941"},
        {"Geneva Identification System", "GEN# +1.00119022"},
        {"Smithsonian Astrophysical Observation", "SAO 252423"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.78644732),
        dec: Angle.Degrees(-69.12758181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4826"},
        {"Hipparcos Number", "HIP 3828"},
        {"Smithsonian Astrophysical Observation", "SAO 248260"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.28231025),
        dec: Angle.Degrees(-69.12664211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105119"},
        {"Hipparcos Number", "HIP 59030"},
        {"Geneva Identification System", "GEN# +1.00105119"},
        {"Smithsonian Astrophysical Observation", "SAO 251735"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.53644674),
        dec: Angle.Degrees(-69.12554035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94522"},
        {"Hipparcos Number", "HIP 53205"},
        {"Smithsonian Astrophysical Observation", "SAO 251163"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.23129863),
        dec: Angle.Degrees(-69.12162008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27306"},
        {"Hipparcos Number", "HIP 19706"},
        {"Smithsonian Astrophysical Observation", "SAO 248967"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.32478978),
        dec: Angle.Degrees(-69.12075368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27987"},
        {"Hipparcos Number", "HIP 20201"},
        {"Smithsonian Astrophysical Observation", "SAO 248998"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.94406542),
        dec: Angle.Degrees(-69.12045548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76613"},
        {"Hipparcos Number", "HIP 43617"},
        {"Geneva Identification System", "GEN# +1.00076613"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.25252032),
        dec: Angle.Degrees(-69.11913647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -116.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107463"},
        {"Henry Draper 2", "HD 107464"},
        {"Hipparcos Number", "HIP 60278"},
        {"Geneva Identification System", "GEN# +1.00107463"},
        {"Smithsonian Astrophysical Observation", "SAO 251863"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.39689107),
        dec: Angle.Degrees(-69.11033423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213222"},
        {"Hipparcos Number", "HIP 111230"},
        {"Fundamental Katalog 5th Edition", "FK5 3801"},
        {"Geneva Identification System", "GEN# +1.00213222"},
        {"Smithsonian Astrophysical Observation", "SAO 255241"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.03693891),
        dec: Angle.Degrees(-69.10780919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 124.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216497"},
        {"Hipparcos Number", "HIP 113176"},
        {"Geneva Identification System", "GEN# +1.00216497"},
        {"Smithsonian Astrophysical Observation", "SAO 255350"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.76571310),
        dec: Angle.Degrees(-69.10420361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1582"},
        {"Hipparcos Number", "HIP 1572"},
        {"Geneva Identification System", "GEN# +1.00001582"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.90202857),
        dec: Angle.Degrees(-69.10282386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86659"},
        {"Hipparcos Number", "HIP 48782"},
        {"Geneva Identification System", "GEN# +1.00086659"},
        {"Smithsonian Astrophysical Observation", "SAO 250761"},
        {"Wilson Evans Batten Catalogue", "WEB 9071"},
    },
    visualMagnitude: 6.18,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.24932341),
        dec: Angle.Degrees(-69.10182530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89018"},
        {"Hipparcos Number", "HIP 50087"},
        {"Smithsonian Astrophysical Observation", "SAO 250882"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.39017048),
        dec: Angle.Degrees(-69.09939344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3912"},
        {"Hipparcos Number", "HIP 3194"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.17825058),
        dec: Angle.Degrees(-69.09821097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183555"},
        {"Hipparcos Number", "HIP 96354"},
        {"Smithsonian Astrophysical Observation", "SAO 254600"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.86680301),
        dec: Angle.Degrees(-69.09484647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156000"},
        {"Hipparcos Number", "HIP 84867"},
        {"Smithsonian Astrophysical Observation", "SAO 253872"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.18034553),
        dec: Angle.Degrees(-69.09459781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183505"},
        {"Hipparcos Number", "HIP 96345"},
        {"Geneva Identification System", "GEN# +1.00183505"},
        {"Smithsonian Astrophysical Observation", "SAO 254599"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.81930942),
        dec: Angle.Degrees(-69.09297072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -176.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223529"},
        {"Hipparcos Number", "HIP 117568"},
        {"Smithsonian Astrophysical Observation", "SAO 255582"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.63879371),
        dec: Angle.Degrees(-69.09268623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10940"},
        {"Hipparcos Number", "HIP 8155"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.21820542),
        dec: Angle.Degrees(-69.09047490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128678"},
        {"Hipparcos Number", "HIP 71856"},
        {"Smithsonian Astrophysical Observation", "SAO 252846"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.47635133),
        dec: Angle.Degrees(-69.08907055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5379"},
        {"Hipparcos Number", "HIP 4256"},
        {"Geneva Identification System", "GEN# +1.00005379"},
        {"Smithsonian Astrophysical Observation", "SAO 248278"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.57208946),
        dec: Angle.Degrees(-69.08671082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125389"},
        {"Hipparcos Number", "HIP 70239"},
        {"Geneva Identification System", "GEN# +1.00125389"},
        {"Smithsonian Astrophysical Observation", "SAO 252717"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.57123695),
        dec: Angle.Degrees(-69.08516220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29672"},
        {"Hipparcos Number", "HIP 21351"},
        {"Geneva Identification System", "GEN# +1.00029672"},
        {"Smithsonian Astrophysical Observation", "SAO 249061"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.72110343),
        dec: Angle.Degrees(-69.08337145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17071"},
        {"Hipparcos Number", "HIP 12481"},
        {"Geneva Identification System", "GEN# +1.00017071"},
        {"Smithsonian Astrophysical Observation", "SAO 248625"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.15681930),
        dec: Angle.Degrees(-69.08317079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146131"},
        {"Hipparcos Number", "HIP 80007"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.97659416),
        dec: Angle.Degrees(-69.08207979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170691"},
        {"Hipparcos Number", "HIP 91221"},
        {"Geneva Identification System", "GEN# +1.00170691"},
        {"Smithsonian Astrophysical Observation", "SAO 254297"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.12101371),
        dec: Angle.Degrees(-69.08172247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8593"},
        {"Hipparcos Number", "HIP 6446"},
        {"Geneva Identification System", "GEN# +1.00008593"},
        {"Smithsonian Astrophysical Observation", "SAO 248375"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.69955993),
        dec: Angle.Degrees(-69.08026781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24675"},
        {"Hipparcos Number", "HIP 17964"},
        {"Smithsonian Astrophysical Observation", "SAO 248895"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.60573341),
        dec: Angle.Degrees(-69.07892068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30491"},
        {"Hipparcos Number", "HIP 21901"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.65028893),
        dec: Angle.Degrees(-69.07830714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94080"},
        {"Hipparcos Number", "HIP 52952"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.45176478),
        dec: Angle.Degrees(-69.07748417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221231"},
        {"Hipparcos Number", "HIP 116063"},
        {"Smithsonian Astrophysical Observation", "SAO 255503"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.76064388),
        dec: Angle.Degrees(-69.07644072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 182.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44578"},
        {"Hipparcos Number", "HIP 29812"},
        {"Smithsonian Astrophysical Observation", "SAO 249501"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.17457223),
        dec: Angle.Degrees(-69.07612331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194441"},
        {"Hipparcos Number", "HIP 101159"},
        {"Smithsonian Astrophysical Observation", "SAO 254800"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.57256698),
        dec: Angle.Degrees(-69.06912302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1437"},
        {"Hipparcos Number", "HIP 1450"},
        {"Geneva Identification System", "GEN# +1.00001437"},
        {"Smithsonian Astrophysical Observation", "SAO 248157"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.898,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.51169322),
        dec: Angle.Degrees(-69.06173695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71007"},
        {"Hipparcos Number", "HIP 40864"},
        {"Smithsonian Astrophysical Observation", "SAO 250199"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.08109681),
        dec: Angle.Degrees(-69.06130524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106275"},
        {"Hipparcos Number", "HIP 59639"},
        {"Geneva Identification System", "GEN# +1.00106275"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.892,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.46750195),
        dec: Angle.Degrees(-69.06072942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -211.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 113.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61950"},
        {"Hipparcos Number", "HIP 37007"},
        {"Smithsonian Astrophysical Observation", "SAO 249895"},
    },
    visualMagnitude: 6.88,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.08027256),
        dec: Angle.Degrees(-69.05657595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151571"},
        {"Hipparcos Number", "HIP 82649"},
        {"Smithsonian Astrophysical Observation", "SAO 253723"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.42239329),
        dec: Angle.Degrees(-69.05461895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87598",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87598"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.41255464),
        dec: Angle.Degrees(-69.05052024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217647"},
        {"Hipparcos Number", "HIP 113870"},
        {"Smithsonian Astrophysical Observation", "SAO 255389"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.89812127),
        dec: Angle.Degrees(-69.04885662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122036"},
        {"Hipparcos Number", "HIP 68557"},
        {"Geneva Identification System", "GEN# +1.00122036"},
        {"Smithsonian Astrophysical Observation", "SAO 252558"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.51789062),
        dec: Angle.Degrees(-69.04084779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2850"},
        {"Hipparcos Number", "HIP 2445"},
        {"Smithsonian Astrophysical Observation", "SAO 248200"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.77359525),
        dec: Angle.Degrees(-69.03843596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171744"},
        {"Hipparcos Number", "HIP 91709"},
        {"Renson", "Renson 48110"},
        {"Smithsonian Astrophysical Observation", "SAO 254333"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.54006243),
        dec: Angle.Degrees(-69.03841270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95122"},
        {"Hipparcos Number", "HIP 53556"},
        {"Celescope Catalog", "CEL 3767"},
        {"Smithsonian Astrophysical Observation", "SAO 251195"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.33424913),
        dec: Angle.Degrees(-69.03806214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171702"},
        {"Hipparcos Number", "HIP 91694"},
        {"Smithsonian Astrophysical Observation", "SAO 254331"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.47209498),
        dec: Angle.Degrees(-69.03333443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218632"},
        {"Hipparcos Number", "HIP 114460"},
        {"Geneva Identification System", "GEN# +1.00218632"},
        {"Smithsonian Astrophysical Observation", "SAO 255422"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.753,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.71487449),
        dec: Angle.Degrees(-69.03176391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -224.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110717"},
        {"Hipparcos Number", "HIP 62209"},
        {"Geneva Identification System", "GEN# +1.00110717"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.25209939),
        dec: Angle.Degrees(-69.02996816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87492",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87492"},
        {"Geneva Identification System", "GEN# -0.06802963"},
    },
    visualMagnitude: 9.60,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.14958998),
        dec: Angle.Degrees(-69.02921667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82273",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Atria"},
        {"Henry Draper", "HD 150798"},
        {"Hipparcos Number", "HIP 82273"},
        {"Fundamental Katalog 5th Edition", "FK5 625"},
        {"Geneva Identification System", "GEN# +1.00150798"},
        {"Smithsonian Astrophysical Observation", "SAO 253700"},
        {"Wilson Evans Batten Catalogue", "WEB 13888"},
    },
    visualMagnitude: 1.91,
    bvColour: 1.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.16610742),
        dec: Angle.Degrees(-69.02763503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143344"},
        {"Hipparcos Number", "HIP 78757"},
    },
    visualMagnitude: 10.47,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.19749041),
        dec: Angle.Degrees(-69.02679282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188770"},
        {"Hipparcos Number", "HIP 98618"},
        {"Smithsonian Astrophysical Observation", "SAO 254706"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.46245191),
        dec: Angle.Degrees(-69.02306689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77275"},
        {"Hipparcos Number", "HIP 43974"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.32677031),
        dec: Angle.Degrees(-69.02129393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127614"},
        {"Hipparcos Number", "HIP 71388"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.97252251),
        dec: Angle.Degrees(-69.02060163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207869"},
        {"Hipparcos Number", "HIP 108193"},
        {"Geneva Identification System", "GEN# +1.00207869"},
        {"Smithsonian Astrophysical Observation", "SAO 255100"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.79464281),
        dec: Angle.Degrees(-69.02000983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -157.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -249.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159776"},
        {"Hipparcos Number", "HIP 86641"},
        {"Smithsonian Astrophysical Observation", "SAO 253999"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.55252980),
        dec: Angle.Degrees(-69.01957371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22625"},
        {"Hipparcos Number", "HIP 16592"},
        {"Geneva Identification System", "GEN# +1.00022625"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.39887076),
        dec: Angle.Degrees(-69.01673537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 86.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192417"},
        {"Hipparcos Number", "HIP 100225"},
        {"Geneva Identification System", "GEN# +1.00192417"},
        {"Smithsonian Astrophysical Observation", "SAO 254771"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.90814198),
        dec: Angle.Degrees(-69.01505330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202503"},
        {"Hipparcos Number", "HIP 105328"},
        {"Smithsonian Astrophysical Observation", "SAO 254975"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.02099439),
        dec: Angle.Degrees(-69.01079880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140340"},
        {"Hipparcos Number", "HIP 77386"},
        {"Renson", "Renson 39880"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.95913059),
        dec: Angle.Degrees(-69.00878881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121102"},
        {"Hipparcos Number", "HIP 68060"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.02811500),
        dec: Angle.Degrees(-69.00577208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 270086"},
        {"Hipparcos Number", "HIP 27142"},
        {"Celescope Catalog", "CEL 978"},
        {"Geneva Identification System", "GEN# +1.00270086"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.31922376),
        dec: Angle.Degrees(-68.99777184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112150"},
        {"Hipparcos Number", "HIP 63085"},
        {"Geneva Identification System", "GEN# +1.00112150"},
        {"Smithsonian Astrophysical Observation", "SAO 252090"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.88906714),
        dec: Angle.Degrees(-68.99756374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133404"},
        {"Hipparcos Number", "HIP 74077"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.06974657),
        dec: Angle.Degrees(-68.99728949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28524"},
        {"Hipparcos Number", "HIP 20585"},
        {"Fundamental Katalog 5th Edition", "FK5 4404"},
        {"Smithsonian Astrophysical Observation", "SAO 249018"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.13528136),
        dec: Angle.Degrees(-68.99366878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70854"},
        {"Hipparcos Number", "HIP 40794"},
        {"Geneva Identification System", "GEN# +1.00070854"},
        {"Smithsonian Astrophysical Observation", "SAO 250192"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.88399267),
        dec: Angle.Degrees(-68.99246994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 250.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68767"},
        {"Hipparcos Number", "HIP 39897"},
        {"Smithsonian Astrophysical Observation", "SAO 250138"},
    },
    visualMagnitude: 7.22,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.23629883),
        dec: Angle.Degrees(-68.99164762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118229"},
        {"Hipparcos Number", "HIP 66474"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.42480604),
        dec: Angle.Degrees(-68.97414664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66488",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66488"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.45522485),
        dec: Angle.Degrees(-68.97376767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215969"},
        {"Hipparcos Number", "HIP 112814"},
        {"Smithsonian Astrophysical Observation", "SAO 255332"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.69523395),
        dec: Angle.Degrees(-68.97348941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91057"},
        {"Hipparcos Number", "HIP 51273"},
        {"Smithsonian Astrophysical Observation", "SAO 250972"},
    },
    visualMagnitude: 8.89,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.10001019),
        dec: Angle.Degrees(-68.97212529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182588"},
        {"Hipparcos Number", "HIP 95950"},
        {"Geneva Identification System", "GEN# +1.00182588"},
        {"Smithsonian Astrophysical Observation", "SAO 254589"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.68585479),
        dec: Angle.Degrees(-68.97209505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 129.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91441"},
        {"Hipparcos Number", "HIP 51514"},
    },
    visualMagnitude: 7.94,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.81302918),
        dec: Angle.Degrees(-68.96890947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122403"},
        {"Hipparcos Number", "HIP 68762"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.11164185),
        dec: Angle.Degrees(-68.96806709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190183"},
        {"Hipparcos Number", "HIP 99237"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.16688640),
        dec: Angle.Degrees(-68.96783911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102012"},
        {"Hipparcos Number", "HIP 57210"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.96715634),
        dec: Angle.Degrees(-68.96700864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133346"},
        {"Hipparcos Number", "HIP 74046"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.98647541),
        dec: Angle.Degrees(-68.95861614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187424"},
        {"Hipparcos Number", "HIP 98003"},
        {"Smithsonian Astrophysical Observation", "SAO 254682"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.74971758),
        dec: Angle.Degrees(-68.95541604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52120"},
        {"Hipparcos Number", "HIP 33172"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.56739575),
        dec: Angle.Degrees(-68.95530044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65909"},
        {"Hipparcos Number", "HIP 38756"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.01247143),
        dec: Angle.Degrees(-68.95472335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131803"},
        {"Hipparcos Number", "HIP 73374"},
    },
    visualMagnitude: 8.02,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.91600433),
        dec: Angle.Degrees(-68.95203077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128022"},
        {"Hipparcos Number", "HIP 71555"},
        {"Smithsonian Astrophysical Observation", "SAO 252826"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.52264041),
        dec: Angle.Degrees(-68.95089939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46976"},
        {"Hipparcos Number", "HIP 31012"},
        {"Smithsonian Astrophysical Observation", "SAO 249573"},
    },
    visualMagnitude: 7.93,
    bvColour: -0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.61553790),
        dec: Angle.Degrees(-68.94772511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26088"},
        {"Hipparcos Number", "HIP 18861"},
        {"Smithsonian Astrophysical Observation", "SAO 248935"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.65350690),
        dec: Angle.Degrees(-68.94721024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86741",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86741"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.86513416),
        dec: Angle.Degrees(-68.93733076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -158.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67624"},
        {"Hipparcos Number", "HIP 39455"},
        {"Fundamental Katalog 5th Edition", "FK5 2628"},
        {"Smithsonian Astrophysical Observation", "SAO 250099"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.97189284),
        dec: Angle.Degrees(-68.93687370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130021"},
        {"Hipparcos Number", "HIP 72518"},
        {"Geneva Identification System", "GEN# +1.00130021"},
        {"Smithsonian Astrophysical Observation", "SAO 252900"},
        {"Wilson Evans Batten Catalogue", "WEB 12465"},
    },
    visualMagnitude: 6.50,
    bvColour: -0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.40442270),
        dec: Angle.Degrees(-68.93615786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83835"},
        {"Hipparcos Number", "HIP 47238"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.41920303),
        dec: Angle.Degrees(-68.93323575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9897"},
        {"Hipparcos Number", "HIP 7322"},
        {"Smithsonian Astrophysical Observation", "SAO 248403"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.57531578),
        dec: Angle.Degrees(-68.93300269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126301"},
        {"Hipparcos Number", "HIP 70734"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.99045493),
        dec: Angle.Degrees(-68.93233640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128827"},
        {"Hipparcos Number", "HIP 71940"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.70319065),
        dec: Angle.Degrees(-68.93191007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115992"},
        {"Hipparcos Number", "HIP 65272"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.66008654),
        dec: Angle.Degrees(-68.92720179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77945"},
        {"Hipparcos Number", "HIP 44298"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.33242982),
        dec: Angle.Degrees(-68.92668867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12993",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12993"},
    },
    visualMagnitude: 11.22,
    bvColour: 1.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.76984125),
        dec: Angle.Degrees(-68.92604967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -584.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140910"},
        {"Hipparcos Number", "HIP 77638"},
        {"Smithsonian Astrophysical Observation", "SAO 253309"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.74687751),
        dec: Angle.Degrees(-68.92247798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1023"},
        {"Hipparcos Number", "HIP 1142"},
        {"Geneva Identification System", "GEN# +1.00001023"},
        {"Smithsonian Astrophysical Observation", "SAO 248140"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.57700172),
        dec: Angle.Degrees(-68.91865951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80128"},
        {"Hipparcos Number", "HIP 45315"},
        {"Geneva Identification System", "GEN# +1.00080128"},
        {"Smithsonian Astrophysical Observation", "SAO 250507"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.53429535),
        dec: Angle.Degrees(-68.91746315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114370"},
        {"Hipparcos Number", "HIP 64385"},
        {"Geneva Identification System", "GEN# +1.00114370"},
        {"Smithsonian Astrophysical Observation", "SAO 252184"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.93867418),
        dec: Angle.Degrees(-68.91692714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196784"},
        {"Hipparcos Number", "HIP 102326"},
        {"Geneva Identification System", "GEN# +1.00196784"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.98165862),
        dec: Angle.Degrees(-68.91449477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148221"},
        {"Hipparcos Number", "HIP 80947"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.93059009),
        dec: Angle.Degrees(-68.91322306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193872"},
        {"Hipparcos Number", "HIP 100878"},
        {"Smithsonian Astrophysical Observation", "SAO 254793"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.81217770),
        dec: Angle.Degrees(-68.90810192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 269857"},
        {"Hipparcos Number", "HIP 26338"},
        {"Geneva Identification System", "GEN# +1.00269857"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.13489808),
        dec: Angle.Degrees(-68.90046577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111676"},
        {"Hipparcos Number", "HIP 62801"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.03425516),
        dec: Angle.Degrees(-68.90028860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65496"},
        {"Hipparcos Number", "HIP 38576"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.48215744),
        dec: Angle.Degrees(-68.90002385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -125.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 173.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206210"},
        {"Hipparcos Number", "HIP 107287"},
        {"Smithsonian Astrophysical Observation", "SAO 255056"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.97168519),
        dec: Angle.Degrees(-68.89872305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8241"},
        {"Hipparcos Number", "HIP 6221"},
        {"Geneva Identification System", "GEN# +1.00008241"},
        {"Smithsonian Astrophysical Observation", "SAO 248360"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.93874208),
        dec: Angle.Degrees(-68.89849097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 119.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91423"},
        {"Hipparcos Number", "HIP 51508"},
        {"Smithsonian Astrophysical Observation", "SAO 250999"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.78096221),
        dec: Angle.Degrees(-68.89725737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138170"},
        {"Hipparcos Number", "HIP 76279"},
        {"Smithsonian Astrophysical Observation", "SAO 253214"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.70940212),
        dec: Angle.Degrees(-68.88907932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220805"},
        {"Hipparcos Number", "HIP 115805"},
        {"Smithsonian Astrophysical Observation", "SAO 255491"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.91673309),
        dec: Angle.Degrees(-68.88820692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18756"},
        {"Hipparcos Number", "HIP 13742"},
        {"Geneva Identification System", "GEN# +1.00018756"},
        {"Smithsonian Astrophysical Observation", "SAO 248694"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.23071909),
        dec: Angle.Degrees(-68.88467700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176865"},
        {"Hipparcos Number", "HIP 93953"},
        {"Smithsonian Astrophysical Observation", "SAO 254465"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.94757449),
        dec: Angle.Degrees(-68.88367382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120948"},
        {"Hipparcos Number", "HIP 67969"},
        {"Smithsonian Astrophysical Observation", "SAO 252516"},
    },
    visualMagnitude: 8.24,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.79187297),
        dec: Angle.Degrees(-68.88203724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7788"},
        {"Hipparcos Number", "HIP 5896"},
        {"Cincinnati Publication", "Ci 20 91"},
        {"Geneva Identification System", "GEN# +1.00007788"},
        {"Wilson Evans Batten Catalogue", "WEB 1340"},
    },
    visualMagnitude: 4.25,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.93956391),
        dec: Angle.Degrees(-68.87623708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 411.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 127.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 269541"},
        {"Hipparcos Number", "HIP 25448"},
        {"Geneva Identification System", "GEN# +1.00269541"},
    },
    visualMagnitude: 10.48,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.64533902),
        dec: Angle.Degrees(-68.86870606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169241"},
        {"Hipparcos Number", "HIP 90623"},
        {"Smithsonian Astrophysical Observation", "SAO 254257"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.37585028),
        dec: Angle.Degrees(-68.86654611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73207"},
        {"Hipparcos Number", "HIP 41902"},
        {"Smithsonian Astrophysical Observation", "SAO 250265"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.16167783),
        dec: Angle.Degrees(-68.86446799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13282"},
        {"Hipparcos Number", "HIP 9853"},
        {"Smithsonian Astrophysical Observation", "SAO 248496"},
    },
    visualMagnitude: 10.41,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.68950032),
        dec: Angle.Degrees(-68.86108166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103021"},
        {"Hipparcos Number", "HIP 57814"},
        {"Geneva Identification System", "GEN# +1.00103021"},
        {"Smithsonian Astrophysical Observation", "SAO 251614"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.83700756),
        dec: Angle.Degrees(-68.86087809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42709",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42709"},
    },
    visualMagnitude: 11.18,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.56018513),
        dec: Angle.Degrees(-68.86035766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 181.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125631"},
        {"Hipparcos Number", "HIP 70368"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.95689849),
        dec: Angle.Degrees(-68.85881195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204826"},
        {"Hipparcos Number", "HIP 106537"},
        {"Geneva Identification System", "GEN# +1.00204826"},
        {"Smithsonian Astrophysical Observation", "SAO 255026"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.66023735),
        dec: Angle.Degrees(-68.85417940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1126"},
        {"Hipparcos Number", "HIP 1217"},
        {"Smithsonian Astrophysical Observation", "SAO 248142"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.80100309),
        dec: Angle.Degrees(-68.84952038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154140"},
        {"Hipparcos Number", "HIP 83925"},
        {"Smithsonian Astrophysical Observation", "SAO 253810"},
    },
    visualMagnitude: 6.59,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.29312812),
        dec: Angle.Degrees(-68.84667674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153164"},
        {"Hipparcos Number", "HIP 83446"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.81826769),
        dec: Angle.Degrees(-68.84390955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43107"},
        {"Hipparcos Number", "HIP 29134"},
        {"Fundamental Katalog 5th Edition", "FK5 1166"},
        {"Geneva Identification System", "GEN# +1.00043107"},
        {"Smithsonian Astrophysical Observation", "SAO 249461"},
        {"Wilson Evans Batten Catalogue", "WEB 5712"},
    },
    visualMagnitude: 5.06,
    bvColour: -0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.18476724),
        dec: Angle.Degrees(-68.84345717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131356"},
        {"Hipparcos Number", "HIP 73152"},
        {"Geneva Identification System", "GEN# +1.00131356"},
        {"Smithsonian Astrophysical Observation", "SAO 252962"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.745,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.25288265),
        dec: Angle.Degrees(-68.83969106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218572"},
        {"Hipparcos Number", "HIP 114416"},
        {"Geneva Identification System", "GEN# +1.00218572"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.58525519),
        dec: Angle.Degrees(-68.83967261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 318.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109165"},
        {"Hipparcos Number", "HIP 61275"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.35602088),
        dec: Angle.Degrees(-68.83763207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55151"},
        {"Hipparcos Number", "HIP 34270"},
        {"Geneva Identification System", "GEN# +1.00055151"},
        {"Smithsonian Astrophysical Observation", "SAO 249740"},
    },
    visualMagnitude: 6.47,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.55959722),
        dec: Angle.Degrees(-68.83757671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169384"},
        {"Hipparcos Number", "HIP 90675"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.52052216),
        dec: Angle.Degrees(-68.83606943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109152"},
        {"Hipparcos Number", "HIP 61268"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.33937296),
        dec: Angle.Degrees(-68.83584942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109449"},
        {"Hipparcos Number", "HIP 61446"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.88329962),
        dec: Angle.Degrees(-68.83246016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45021"},
        {"Hipparcos Number", "HIP 30037"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.81251392),
        dec: Angle.Degrees(-68.83157887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 79.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110716"},
        {"Hipparcos Number", "HIP 62212"},
        {"Geneva Identification System", "GEN# +1.00110716"},
        {"Smithsonian Astrophysical Observation", "SAO 252012"},
    },
    visualMagnitude: 6.16,
    bvColour: 0.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.25860848),
        dec: Angle.Degrees(-68.83074797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86530"},
        {"Hipparcos Number", "HIP 48705"},
        {"Smithsonian Astrophysical Observation", "SAO 250755"},
    },
    visualMagnitude: 8.97,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.01784063),
        dec: Angle.Degrees(-68.82911572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217831"},
        {"Hipparcos Number", "HIP 113969"},
        {"Fundamental Katalog 5th Edition", "FK5 3843"},
        {"Geneva Identification System", "GEN# +1.00217831"},
        {"Renson", "Renson 60050"},
        {"Smithsonian Astrophysical Observation", "SAO 255395"},
        {"Wilson Evans Batten Catalogue", "WEB 20239"},
    },
    visualMagnitude: 5.53,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.21728516),
        dec: Angle.Degrees(-68.82037973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7693"},
        {"Hipparcos Number", "HIP 5842"},
        {"Cincinnati Publication", "Ci 20 89"},
        {"Geneva Identification System", "GEN# +1.00007693"},
        {"Smithsonian Astrophysical Observation", "SAO 248342"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.75133430),
        dec: Angle.Degrees(-68.81909440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 416.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 75.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208562"},
        {"Hipparcos Number", "HIP 108600"},
        {"Smithsonian Astrophysical Observation", "SAO 255121"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.00183396),
        dec: Angle.Degrees(-68.81529918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86404"},
        {"Hipparcos Number", "HIP 48650"},
        {"Geneva Identification System", "GEN# +1.00086404"},
        {"Smithsonian Astrophysical Observation", "SAO 250751"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.81150650),
        dec: Angle.Degrees(-68.81485936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145672"},
        {"Hipparcos Number", "HIP 79803"},
        {"Smithsonian Astrophysical Observation", "SAO 253482"},
    },
    visualMagnitude: 9.11,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.31242142),
        dec: Angle.Degrees(-68.81430037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104554"},
        {"Hipparcos Number", "HIP 58696"},
        {"Smithsonian Astrophysical Observation", "SAO 251694"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.58206128),
        dec: Angle.Degrees(-68.81406757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29994"},
        {"Hipparcos Number", "HIP 21599"},
        {"Smithsonian Astrophysical Observation", "SAO 249073"},
    },
    visualMagnitude: 8.10,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.55498269),
        dec: Angle.Degrees(-68.81168349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122"},
        {"Hipparcos Number", "HIP 494"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.47971363),
        dec: Angle.Degrees(-68.81162782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126954"},
        {"Hipparcos Number", "HIP 71062"},
        {"Geneva Identification System", "GEN# +1.00126954"},
        {"Smithsonian Astrophysical Observation", "SAO 252770"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.98289927),
        dec: Angle.Degrees(-68.80918779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -159.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -183.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215702"},
        {"Hipparcos Number", "HIP 112657"},
        {"Smithsonian Astrophysical Observation", "SAO 255322"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.23170613),
        dec: Angle.Degrees(-68.80576088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150187"},
        {"Hipparcos Number", "HIP 81968"},
        {"Smithsonian Astrophysical Observation", "SAO 253678"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.16862230),
        dec: Angle.Degrees(-68.80461860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45987"},
        {"Hipparcos Number", "HIP 30516"},
        {"Geneva Identification System", "GEN# +1.00045987"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.21548042),
        dec: Angle.Degrees(-68.80310789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142158"},
        {"Hipparcos Number", "HIP 78172"},
    },
    visualMagnitude: 9.06,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.42668314),
        dec: Angle.Degrees(-68.80219235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173935"},
        {"Hipparcos Number", "HIP 92722"},
        {"Smithsonian Astrophysical Observation", "SAO 254401"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.41555135),
        dec: Angle.Degrees(-68.79811040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123709"},
        {"Hipparcos Number", "HIP 69387"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.05706681),
        dec: Angle.Degrees(-68.79810923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102305"},
        {"Hipparcos Number", "HIP 57403"},
        {"Geneva Identification System", "GEN# +1.00102305"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.899,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.53206018),
        dec: Angle.Degrees(-68.79720420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113153"},
        {"Hipparcos Number", "HIP 63689"},
        {"Geneva Identification System", "GEN# +1.00113153"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.77456225),
        dec: Angle.Degrees(-68.79516246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116106"},
        {"Hipparcos Number", "HIP 65329"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.85252181),
        dec: Angle.Degrees(-68.79194854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197569"},
        {"Hipparcos Number", "HIP 102725"},
        {"Geneva Identification System", "GEN# +1.00197569"},
        {"Smithsonian Astrophysical Observation", "SAO 254870"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.23522208),
        dec: Angle.Degrees(-68.79110468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27633"},
        {"Hipparcos Number", "HIP 19919"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.10925877),
        dec: Angle.Degrees(-68.78752345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216668"},
        {"Hipparcos Number", "HIP 113290"},
        {"Smithsonian Astrophysical Observation", "SAO 255354"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.11064618),
        dec: Angle.Degrees(-68.78377957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96569"},
        {"Hipparcos Number", "HIP 54276"},
        {"Fundamental Katalog 5th Edition", "FK5 4980"},
        {"Geneva Identification System", "GEN# +1.00096569"},
        {"Smithsonian Astrophysical Observation", "SAO 251265"},
        {"Wilson Evans Batten Catalogue", "WEB 9806"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.702,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.54843494),
        dec: Angle.Degrees(-68.78194432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11424"},
        {"Hipparcos Number", "HIP 8505"},
        {"Smithsonian Astrophysical Observation", "SAO 248445"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.42265193),
        dec: Angle.Degrees(-68.77948543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 269788"},
        {"Hipparcos Number", "HIP 26181"},
        {"Geneva Identification System", "GEN# +1.00269788"},
    },
    visualMagnitude: 9.99,
    bvColour: 1.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.72358515),
        dec: Angle.Degrees(-68.77764041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197635"},
        {"Hipparcos Number", "HIP 102773"},
        {"Fundamental Katalog 5th Edition", "FK5 3660"},
        {"Geneva Identification System", "GEN# +1.00197635"},
        {"Smithsonian Astrophysical Observation", "SAO 254871"},
        {"Wilson Evans Batten Catalogue", "WEB 18632"},
    },
    visualMagnitude: 5.41,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.32614627),
        dec: Angle.Degrees(-68.77640032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118621"},
        {"Hipparcos Number", "HIP 66701"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.09372040),
        dec: Angle.Degrees(-68.77518842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 269128"},
        {"Hipparcos Number", "HIP 24080"},
        {"Geneva Identification System", "GEN# +1.00269128"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.59494287),
        dec: Angle.Degrees(-68.77328266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14399"},
        {"Hipparcos Number", "HIP 10587"},
        {"Smithsonian Astrophysical Observation", "SAO 248525"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.07977605),
        dec: Angle.Degrees(-68.76863584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -188.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61312"},
        {"Hipparcos Number", "HIP 36735"},
        {"Smithsonian Astrophysical Observation", "SAO 249881"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.34087991),
        dec: Angle.Degrees(-68.76849931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109832"},
        {"Hipparcos Number", "HIP 61684"},
        {"Geneva Identification System", "GEN# +1.00109832"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.67848295),
        dec: Angle.Degrees(-68.76361480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158258"},
        {"Hipparcos Number", "HIP 85943"},
        {"Smithsonian Astrophysical Observation", "SAO 253958"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.48221778),
        dec: Angle.Degrees(-68.76297218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129445"},
        {"Hipparcos Number", "HIP 72203"},
        {"Geneva Identification System", "GEN# +1.00129445"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.756,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.51410001),
        dec: Angle.Degrees(-68.76260612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -198.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188164"},
        {"Hipparcos Number", "HIP 98346"},
        {"Geneva Identification System", "GEN# +1.00188164"},
        {"Renson", "Renson 51970"},
        {"Smithsonian Astrophysical Observation", "SAO 254696"},
        {"Wilson Evans Batten Catalogue", "WEB 17349"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.72052643),
        dec: Angle.Degrees(-68.76240414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152653"},
        {"Hipparcos Number", "HIP 83193"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.03792115),
        dec: Angle.Degrees(-68.76143088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 143.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 260.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149649"},
        {"Hipparcos Number", "HIP 81709"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.948,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.34588114),
        dec: Angle.Degrees(-68.75966353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175986"},
        {"Hipparcos Number", "HIP 93574"},
        {"Geneva Identification System", "GEN# +1.00175986J"},
        {"Smithsonian Astrophysical Observation", "SAO 254446"},
    },
    visualMagnitude: 5.89,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.87367886),
        dec: Angle.Degrees(-68.75553290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109200"},
        {"Hipparcos Number", "HIP 61291"},
        {"Cincinnati Publication", "Ci 20 715"},
        {"Geneva Identification System", "GEN# +1.00109200"},
        {"Smithsonian Astrophysical Observation", "SAO 251953"},
        {"Wilson Evans Batten Catalogue", "WEB 10907"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.836,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.38442385),
        dec: Angle.Degrees(-68.75504919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -545.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -311.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79041"},
        {"Hipparcos Number", "HIP 44786"},
        {"Celescope Catalog", "CEL 3196"},
        {"Geneva Identification System", "GEN# +1.00079041"},
        {"Smithsonian Astrophysical Observation", "SAO 250455"},
    },
    visualMagnitude: 7.53,
    bvColour: -0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.91507227),
        dec: Angle.Degrees(-68.75483851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94008"},
        {"Hipparcos Number", "HIP 52914"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.33479595),
        dec: Angle.Degrees(-68.74661698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209468"},
        {"Hipparcos Number", "HIP 109135"},
        {"Geneva Identification System", "GEN# +1.00209468"},
        {"Smithsonian Astrophysical Observation", "SAO 255143"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.59504901),
        dec: Angle.Degrees(-68.74136182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 120415",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 120415"},
    },
    visualMagnitude: 10.86,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)20, 04.6400),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)22, 23.400)
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
    primaryId: "HIP 71359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127575"},
        {"Hipparcos Number", "HIP 71359"},
        {"Geneva Identification System", "GEN# +1.00127575"},
        {"Renson", "Renson 36280"},
        {"Smithsonian Astrophysical Observation", "SAO 252805"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.89628199),
        dec: Angle.Degrees(-68.73911920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3775"},
        {"Hipparcos Number", "HIP 3096"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.85767044),
        dec: Angle.Degrees(-68.73827080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59719"},
        {"Hipparcos Number", "HIP 36063"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.896,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.47785431),
        dec: Angle.Degrees(-68.73700451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76492"},
        {"Hipparcos Number", "HIP 43563"},
        {"Smithsonian Astrophysical Observation", "SAO 250364"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.07854892),
        dec: Angle.Degrees(-68.73357244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108435"},
        {"Hipparcos Number", "HIP 60825"},
        {"Geneva Identification System", "GEN# +1.00108435"},
        {"Smithsonian Astrophysical Observation", "SAO 251918"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.01122571),
        dec: Angle.Degrees(-68.73221923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -153.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124155"},
        {"Hipparcos Number", "HIP 69610"},
        {"Geneva Identification System", "GEN# +1.00124155"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.69934703),
        dec: Angle.Degrees(-68.73170772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214501"},
        {"Hipparcos Number", "HIP 111948"},
        {"Smithsonian Astrophysical Observation", "SAO 255278"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.15026312),
        dec: Angle.Degrees(-68.72658923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133638"},
        {"Hipparcos Number", "HIP 74192"},
        {"Geneva Identification System", "GEN# +1.00133638"},
        {"Smithsonian Astrophysical Observation", "SAO 253029"},
    },
    visualMagnitude: 6.84,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.40245491),
        dec: Angle.Degrees(-68.72134637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149239"},
        {"Hipparcos Number", "HIP 81493"},
    },
    visualMagnitude: 7.23,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.67605088),
        dec: Angle.Degrees(-68.72080019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116302"},
        {"Hipparcos Number", "HIP 65439"},
        {"Geneva Identification System", "GEN# +1.00116302"},
        {"Smithsonian Astrophysical Observation", "SAO 252297"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.17151010),
        dec: Angle.Degrees(-68.71994637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111109"},
        {"Hipparcos Number", "HIP 62461"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.01018832),
        dec: Angle.Degrees(-68.71987537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 268729"},
        {"Hipparcos Number", "HIP 22758"},
        {"Geneva Identification System", "GEN# +1.00268729"},
    },
    visualMagnitude: 10.98,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.43033786),
        dec: Angle.Degrees(-68.71480094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47252"},
        {"Hipparcos Number", "HIP 31134"},
        {"Cincinnati Publication", "Ci 20 392"},
        {"Geneva Identification System", "GEN# +1.00047252"},
        {"Smithsonian Astrophysical Observation", "SAO 249582"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.781,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.98676986),
        dec: Angle.Degrees(-68.70877081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -450.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210473"},
        {"Hipparcos Number", "HIP 109708"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.33262491),
        dec: Angle.Degrees(-68.70391900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26733"},
        {"Hipparcos Number", "HIP 19324"},
        {"Geneva Identification System", "GEN# +1.00026733"},
        {"Smithsonian Astrophysical Observation", "SAO 248952"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.12757092),
        dec: Angle.Degrees(-68.70222944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27997"},
        {"Hipparcos Number", "HIP 20224"},
        {"Renson", "Renson 7170"},
        {"Smithsonian Astrophysical Observation", "SAO 248999"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.00028746),
        dec: Angle.Degrees(-68.70078216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 311295"},
        {"Hipparcos Number", "HIP 39781"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.94112531),
        dec: Angle.Degrees(-68.69453027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80671"},
        {"Hipparcos Number", "HIP 45571"},
        {"Geneva Identification System", "GEN# +1.00080671"},
        {"Smithsonian Astrophysical Observation", "SAO 250526"},
        {"Wilson Evans Batten Catalogue", "WEB 8661"},
    },
    visualMagnitude: 5.38,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.32250201),
        dec: Angle.Degrees(-68.68957252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -109.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40579",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40579"},
    },
    visualMagnitude: 11.39,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.27936798),
        dec: Angle.Degrees(-68.68565423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196987"},
        {"Hipparcos Number", "HIP 102406"},
        {"Geneva Identification System", "GEN# +1.00196987"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.719,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.28597048),
        dec: Angle.Degrees(-68.68497173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127537"},
        {"Hipparcos Number", "HIP 71341"},
        {"Geneva Identification System", "GEN# +1.00127537"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.84121150),
        dec: Angle.Degrees(-68.68455645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77887"},
        {"Hipparcos Number", "HIP 44283"},
        {"Geneva Identification System", "GEN# +1.00077887"},
        {"Smithsonian Astrophysical Observation", "SAO 250421"},
    },
    visualMagnitude: 5.89,
    bvColour: 1.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.28536477),
        dec: Angle.Degrees(-68.68391841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206615"},
        {"Hipparcos Number", "HIP 107503"},
        {"Smithsonian Astrophysical Observation", "SAO 255066"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.59972126),
        dec: Angle.Degrees(-68.68388631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88473"},
        {"Hipparcos Number", "HIP 49764"},
        {"Geneva Identification System", "GEN# +1.00088473J"},
        {"Smithsonian Astrophysical Observation", "SAO 250844"},
    },
    visualMagnitude: 5.80,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.37583168),
        dec: Angle.Degrees(-68.68283264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219797"},
        {"Hipparcos Number", "HIP 115164"},
        {"Smithsonian Astrophysical Observation", "SAO 255458"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.91716599),
        dec: Angle.Degrees(-68.67965948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135382"},
        {"Hipparcos Number", "HIP 74946"},
        {"Fundamental Katalog 5th Edition", "FK5 560"},
        {"Geneva Identification System", "GEN# +1.00135382"},
        {"Renson", "Renson 38430"},
        {"Smithsonian Astrophysical Observation", "SAO 253097"},
        {"Wilson Evans Batten Catalogue", "WEB 12786"},
    },
    visualMagnitude: 2.87,
    bvColour: 0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.72787007),
        dec: Angle.Degrees(-68.67946723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156108"},
        {"Hipparcos Number", "HIP 84904"},
        {"Smithsonian Astrophysical Observation", "SAO 253875"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.27828690),
        dec: Angle.Degrees(-68.67382902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95086"},
        {"Hipparcos Number", "HIP 53524"},
        {"Smithsonian Astrophysical Observation", "SAO 251193"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.26286436),
        dec: Angle.Degrees(-68.66737837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75863"},
        {"Hipparcos Number", "HIP 43226"},
        {"Smithsonian Astrophysical Observation", "SAO 250334"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.07909447),
        dec: Angle.Degrees(-68.66541521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15008"},
        {"Hipparcos Number", "HIP 11001"},
        {"Fundamental Katalog 5th Edition", "FK5 1065"},
        {"Geneva Identification System", "GEN# +1.00015008"},
        {"Smithsonian Astrophysical Observation", "SAO 248545"},
        {"Wilson Evans Batten Catalogue", "WEB 2313"},
    },
    visualMagnitude: 4.08,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.43759585),
        dec: Angle.Degrees(-68.65942390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162000"},
        {"Hipparcos Number", "HIP 87667"},
        {"Geneva Identification System", "GEN# +1.00162000"},
        {"Smithsonian Astrophysical Observation", "SAO 254065"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.60544903),
        dec: Angle.Degrees(-68.65780740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195418"},
        {"Hipparcos Number", "HIP 101617"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.91704398),
        dec: Angle.Degrees(-68.65691741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131843"},
        {"Hipparcos Number", "HIP 73384"},
        {"Geneva Identification System", "GEN# +1.00131843"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.94421437),
        dec: Angle.Degrees(-68.65640704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105138"},
        {"Hipparcos Number", "HIP 59046"},
        {"Geneva Identification System", "GEN# +1.00105138"},
        {"Smithsonian Astrophysical Observation", "SAO 251737"},
    },
    visualMagnitude: 6.23,
    bvColour: 1.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.58305555),
        dec: Angle.Degrees(-68.65140083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142032"},
        {"Hipparcos Number", "HIP 78119"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.27197506),
        dec: Angle.Degrees(-68.65078837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194190"},
        {"Hipparcos Number", "HIP 101029"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.22233663),
        dec: Angle.Degrees(-68.65019381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160468"},
        {"Hipparcos Number", "HIP 86930"},
        {"Geneva Identification System", "GEN# +1.00160468"},
        {"Renson", "Renson 45180"},
        {"Smithsonian Astrophysical Observation", "SAO 254013"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.43436957),
        dec: Angle.Degrees(-68.64764623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200285"},
        {"Hipparcos Number", "HIP 104183"},
        {"Smithsonian Astrophysical Observation", "SAO 254936"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.62272341),
        dec: Angle.Degrees(-68.64590014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186016"},
        {"Hipparcos Number", "HIP 97347"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.77731558),
        dec: Angle.Degrees(-68.64360728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154526"},
        {"Hipparcos Number", "HIP 84090"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.87235787),
        dec: Angle.Degrees(-68.64315966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202849"},
        {"Hipparcos Number", "HIP 105509"},
        {"Smithsonian Astrophysical Observation", "SAO 254985"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.54965802),
        dec: Angle.Degrees(-68.64181324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105483"},
        {"Hipparcos Number", "HIP 59221"},
        {"Geneva Identification System", "GEN# +1.00105483"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.18750207),
        dec: Angle.Degrees(-68.63943700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15508"},
        {"Hipparcos Number", "HIP 11364"},
        {"Smithsonian Astrophysical Observation", "SAO 248564"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.59715319),
        dec: Angle.Degrees(-68.63537619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 310376"},
        {"Hipparcos Number", "HIP 54226"},
        {"Wilson Evans Batten Catalogue", "WEB 9797"},
    },
    visualMagnitude: 11.49,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.42711925),
        dec: Angle.Degrees(-68.63284459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 311154"},
        {"Hipparcos Number", "HIP 59665"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.53369927),
        dec: Angle.Degrees(-68.63222934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5488"},
        {"Hipparcos Number", "HIP 4324"},
        {"Geneva Identification System", "GEN# +1.00005488"},
        {"Smithsonian Astrophysical Observation", "SAO 248282"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.84247943),
        dec: Angle.Degrees(-68.62787891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190765"},
        {"Hipparcos Number", "HIP 99481"},
        {"Smithsonian Astrophysical Observation", "SAO 254739"},
    },
    visualMagnitude: 8.55,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.84705244),
        dec: Angle.Degrees(-68.62601083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36584"},
        {"Hipparcos Number", "HIP 25482"},
        {"Geneva Identification System", "GEN# +1.00036584"},
        {"Smithsonian Astrophysical Observation", "SAO 249281"},
        {"Wilson Evans Batten Catalogue", "WEB 4939"},
    },
    visualMagnitude: 6.02,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.74925231),
        dec: Angle.Degrees(-68.62249571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134710"},
        {"Hipparcos Number", "HIP 74664"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.86615413),
        dec: Angle.Degrees(-68.62030044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122361"},
        {"Hipparcos Number", "HIP 68733"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.04501405),
        dec: Angle.Degrees(-68.61746927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68221"},
        {"Hipparcos Number", "HIP 39683"},
        {"Smithsonian Astrophysical Observation", "SAO 250112"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.64760135),
        dec: Angle.Degrees(-68.61741982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68520"},
        {"Hipparcos Number", "HIP 39794"},
        {"Geneva Identification System", "GEN# +1.00068520"},
        {"Smithsonian Astrophysical Observation", "SAO 250128"},
        {"Wilson Evans Batten Catalogue", "WEB 7763"},
    },
    visualMagnitude: 4.35,
    bvColour: -0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.98266997),
        dec: Angle.Degrees(-68.61713647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72473"},
        {"Hipparcos Number", "HIP 41577"},
        {"Geneva Identification System", "GEN# +1.00072473"},
        {"Smithsonian Astrophysical Observation", "SAO 250243"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.15485360),
        dec: Angle.Degrees(-68.61681790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59995"},
        {"Hipparcos Number", "HIP 36182"},
        {"Geneva Identification System", "GEN# +1.00059995"},
        {"Smithsonian Astrophysical Observation", "SAO 249857"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.77332514),
        dec: Angle.Degrees(-68.61564331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 91.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136158"},
        {"Hipparcos Number", "HIP 75320"},
        {"Geneva Identification System", "GEN# +1.00136158"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.83625485),
        dec: Angle.Degrees(-68.61558380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138115"},
        {"Hipparcos Number", "HIP 76230"},
        {"Geneva Identification System", "GEN# +1.00138115"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.57603084),
        dec: Angle.Degrees(-68.61366600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15900"},
        {"Hipparcos Number", "HIP 11621"},
        {"Smithsonian Astrophysical Observation", "SAO 248578"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.47515781),
        dec: Angle.Degrees(-68.61078456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30363"},
        {"Hipparcos Number", "HIP 21828"},
        {"Geneva Identification System", "GEN# +1.00030363"},
        {"Smithsonian Astrophysical Observation", "SAO 249084"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.39459136),
        dec: Angle.Degrees(-68.60764208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99631"},
        {"Hipparcos Number", "HIP 55847"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.69196465),
        dec: Angle.Degrees(-68.60647081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84016"},
        {"Hipparcos Number", "HIP 47350"},
        {"Smithsonian Astrophysical Observation", "SAO 250654"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.72503824),
        dec: Angle.Degrees(-68.60603347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112787"},
        {"Hipparcos Number", "HIP 63482"},
        {"Geneva Identification System", "GEN# +1.00112787"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.11110268),
        dec: Angle.Degrees(-68.60512301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141767"},
        {"Hipparcos Number", "HIP 77982"},
        {"Fundamental Katalog 5th Edition", "FK5 3253"},
        {"Geneva Identification System", "GEN# +1.00141767"},
        {"Smithsonian Astrophysical Observation", "SAO 253342"},
        {"Wilson Evans Batten Catalogue", "WEB 13188"},
    },
    visualMagnitude: 5.11,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.87338903),
        dec: Angle.Degrees(-68.60298616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45819"},
        {"Hipparcos Number", "HIP 30440"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.99294725),
        dec: Angle.Degrees(-68.60091456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14754",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14754"},
        {"Geneva Identification System", "GEN# -0.06900177"},
    },
    visualMagnitude: 11.39,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.62898313),
        dec: Angle.Degrees(-68.60068834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202289"},
        {"Hipparcos Number", "HIP 105191"},
        {"Smithsonian Astrophysical Observation", "SAO 254967"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.63170374),
        dec: Angle.Degrees(-68.60061957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100714"},
        {"Hipparcos Number", "HIP 56462"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.65056453),
        dec: Angle.Degrees(-68.59934564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194859"},
        {"Hipparcos Number", "HIP 101354"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.11759142),
        dec: Angle.Degrees(-68.59852410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3260"},
        {"Hipparcos Number", "HIP 2731"},
        {"Smithsonian Astrophysical Observation", "SAO 248216"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.72253882),
        dec: Angle.Degrees(-68.59681194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35230"},
        {"Hipparcos Number", "HIP 24671"},
        {"Fundamental Katalog 5th Edition", "FK5 4480"},
        {"Geneva Identification System", "GEN# +1.00035230"},
        {"Smithsonian Astrophysical Observation", "SAO 249241"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.863,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.39814677),
        dec: Angle.Degrees(-68.59314215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131565"},
        {"Hipparcos Number", "HIP 73244"},
        {"Geneva Identification System", "GEN# +1.00131565"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.54078701),
        dec: Angle.Degrees(-68.59065168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -175.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41795",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41795"},
    },
    visualMagnitude: 10.69,
    bvColour: 1.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.82535466),
        dec: Angle.Degrees(-68.58938950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47879",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47879"},
    },
    visualMagnitude: 11.24,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.36930994),
        dec: Angle.Degrees(-68.58548359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104634"},
        {"Hipparcos Number", "HIP 58739"},
        {"Geneva Identification System", "GEN# +1.00104634"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.71282600),
        dec: Angle.Degrees(-68.58487390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32762"},
        {"Hipparcos Number", "HIP 23225"},
        {"Geneva Identification System", "GEN# +1.00032762"},
        {"Renson", "Renson 8380"},
        {"Smithsonian Astrophysical Observation", "SAO 249164"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.96733759),
        dec: Angle.Degrees(-68.58202828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135196"},
        {"Hipparcos Number", "HIP 74869"},
    },
    visualMagnitude: 7.88,
    bvColour: -0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.50106389),
        dec: Angle.Degrees(-68.58153889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90481",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90481"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.93867827),
        dec: Angle.Degrees(-68.58065522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34560",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34560"},
    },
    visualMagnitude: 11.06,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.38517335),
        dec: Angle.Degrees(-68.57233021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113558"},
        {"Hipparcos Number", "HIP 63925"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.49869368),
        dec: Angle.Degrees(-68.57169169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1506"},
        {"Hipparcos Number", "HIP 1508"},
        {"Geneva Identification System", "GEN# +1.00001506"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.69221376),
        dec: Angle.Degrees(-68.56919945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157511"},
        {"Hipparcos Number", "HIP 85563"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.28255606),
        dec: Angle.Degrees(-68.56889573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196804"},
        {"Hipparcos Number", "HIP 102323"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.97658489),
        dec: Angle.Degrees(-68.56876383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122831"},
        {"Hipparcos Number", "HIP 68960"},
        {"Geneva Identification System", "GEN# +1.00122831"},
        {"Wilson Evans Batten Catalogue", "WEB 12050"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.75644835),
        dec: Angle.Degrees(-68.56874959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119530"},
        {"Hipparcos Number", "HIP 67189"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.53913556),
        dec: Angle.Degrees(-68.56589583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5261",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5261"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.80776414),
        dec: Angle.Degrees(-68.56553671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212331"},
        {"Hipparcos Number", "HIP 110709"},
        {"Smithsonian Astrophysical Observation", "SAO 255215"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.45415526),
        dec: Angle.Degrees(-68.56448090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137067"},
        {"Hipparcos Number", "HIP 75737"},
        {"Renson", "Renson 38930"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.08760024),
        dec: Angle.Degrees(-68.55956012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5254",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5254"},
    },
    visualMagnitude: 10.92,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.79549240),
        dec: Angle.Degrees(-68.55953955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112691"},
        {"Hipparcos Number", "HIP 63427"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.96869773),
        dec: Angle.Degrees(-68.55813518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182290"},
        {"Hipparcos Number", "HIP 95815"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.33136145),
        dec: Angle.Degrees(-68.55490995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93650",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93650"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.05986048),
        dec: Angle.Degrees(-68.55249995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91273"},
        {"Hipparcos Number", "HIP 51421"},
    },
    visualMagnitude: 7.97,
    bvColour: -0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.52849446),
        dec: Angle.Degrees(-68.55203553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121"},
        {"Hipparcos Number", "HIP 488"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.46256763),
        dec: Angle.Degrees(-68.55128874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103611"},
        {"Hipparcos Number", "HIP 58166"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.93053225),
        dec: Angle.Degrees(-68.54942245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30969"},
        {"Hipparcos Number", "HIP 22213"},
        {"Geneva Identification System", "GEN# +1.00030969"},
        {"Smithsonian Astrophysical Observation", "SAO 249109"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.65634793),
        dec: Angle.Degrees(-68.54613912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150705"},
        {"Hipparcos Number", "HIP 82231"},
        {"Smithsonian Astrophysical Observation", "SAO 253695"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.00199235),
        dec: Angle.Degrees(-68.54432673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145081"},
        {"Hipparcos Number", "HIP 79553"},
        {"Smithsonian Astrophysical Observation", "SAO 253462"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.49629925),
        dec: Angle.Degrees(-68.54352597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94410"},
        {"Hipparcos Number", "HIP 53122"},
        {"Geneva Identification System", "GEN# +1.00094410"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.01083431),
        dec: Angle.Degrees(-68.54338146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124316"},
        {"Hipparcos Number", "HIP 69688"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.97929286),
        dec: Angle.Degrees(-68.54028682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76808"},
        {"Hipparcos Number", "HIP 43733"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.60268612),
        dec: Angle.Degrees(-68.53877621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146295"},
        {"Hipparcos Number", "HIP 80071"},
        {"Smithsonian Astrophysical Observation", "SAO 253505"},
    },
    visualMagnitude: 7.20,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.14206866),
        dec: Angle.Degrees(-68.53662109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102585"},
        {"Hipparcos Number", "HIP 57577"},
        {"Geneva Identification System", "GEN# +1.00102585"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.04719524),
        dec: Angle.Degrees(-68.53562225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21223"},
        {"Hipparcos Number", "HIP 15614"},
        {"Geneva Identification System", "GEN# +1.00021223"},
        {"Renson", "Renson 5300"},
        {"Smithsonian Astrophysical Observation", "SAO 248785"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.25993402),
        dec: Angle.Degrees(-68.53355812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 81.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1108"},
        {"Hipparcos Number", "HIP 1206"},
        {"Geneva Identification System", "GEN# +1.00001108"},
        {"Smithsonian Astrophysical Observation", "SAO 248141"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.76898965),
        dec: Angle.Degrees(-68.53023276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172240"},
        {"Hipparcos Number", "HIP 91968"},
        {"Geneva Identification System", "GEN# +1.00172240"},
        {"Smithsonian Astrophysical Observation", "SAO 254355"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.18591133),
        dec: Angle.Degrees(-68.52955148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44822",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44822"},
    },
    visualMagnitude: 11.28,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.01074287),
        dec: Angle.Degrees(-68.52877769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116424"},
        {"Hipparcos Number", "HIP 65503"},
        {"Smithsonian Astrophysical Observation", "SAO 252305"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.38054760),
        dec: Angle.Degrees(-68.52808324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79076"},
        {"Hipparcos Number", "HIP 44819"},
        {"Smithsonian Astrophysical Observation", "SAO 250457"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.00419025),
        dec: Angle.Degrees(-68.52751100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18777"},
        {"Hipparcos Number", "HIP 13777"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.32987838),
        dec: Angle.Degrees(-68.52610545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 146.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124134"},
        {"Hipparcos Number", "HIP 69589"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.66316869),
        dec: Angle.Degrees(-68.52403675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159116"},
        {"Hipparcos Number", "HIP 86334"},
        {"Smithsonian Astrophysical Observation", "SAO 253984"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.60683198),
        dec: Angle.Degrees(-68.52280640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129750"},
        {"Hipparcos Number", "HIP 72377"},
        {"Renson", "Renson 37000"},
        {"Smithsonian Astrophysical Observation", "SAO 252883"},
    },
    visualMagnitude: 7.13,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.98811913),
        dec: Angle.Degrees(-68.51961766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117653"},
        {"Hipparcos Number", "HIP 66170"},
        {"Geneva Identification System", "GEN# +1.00117653"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.44850230),
        dec: Angle.Degrees(-68.51896137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -118.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50924"},
        {"Hipparcos Number", "HIP 32736"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.42045301),
        dec: Angle.Degrees(-68.51707140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87787",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87787"},
    },
    visualMagnitude: 10.45,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.99180655),
        dec: Angle.Degrees(-68.51533442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62038"},
        {"Hipparcos Number", "HIP 37056"},
        {"Smithsonian Astrophysical Observation", "SAO 249898"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.23038086),
        dec: Angle.Degrees(-68.51063491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52418"},
        {"Hipparcos Number", "HIP 33306"},
        {"Smithsonian Astrophysical Observation", "SAO 249686"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.92062580),
        dec: Angle.Degrees(-68.50581473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120786"},
        {"Hipparcos Number", "HIP 67869"},
        {"Smithsonian Astrophysical Observation", "SAO 252505"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.51669204),
        dec: Angle.Degrees(-68.50546441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84375"},
        {"Hipparcos Number", "HIP 47549"},
        {"Celescope Catalog", "CEL 3362"},
        {"Fundamental Katalog 5th Edition", "FK5 2778"},
        {"Geneva Identification System", "GEN# +1.00084375"},
        {"Smithsonian Astrophysical Observation", "SAO 250668"},
    },
    visualMagnitude: 7.11,
    bvColour: -0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.40550818),
        dec: Angle.Degrees(-68.50499927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122249"},
        {"Hipparcos Number", "HIP 68678"},
    },
    visualMagnitude: 7.59,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.87956182),
        dec: Angle.Degrees(-68.50371748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219324"},
        {"Hipparcos Number", "HIP 114861"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.98885278),
        dec: Angle.Degrees(-68.50308366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142437"},
        {"Hipparcos Number", "HIP 78299"},
        {"Geneva Identification System", "GEN# +1.00142437"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.82043517),
        dec: Angle.Degrees(-68.50200906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114655"},
        {"Hipparcos Number", "HIP 64521"},
        {"Renson", "Renson 33130"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.36665057),
        dec: Angle.Degrees(-68.49896056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138593"},
        {"Hipparcos Number", "HIP 76495"},
        {"Geneva Identification System", "GEN# +1.00138593"},
        {"Wilson Evans Batten Catalogue", "WEB 12983"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.35494190),
        dec: Angle.Degrees(-68.49887327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90856"},
        {"Hipparcos Number", "HIP 51169"},
    },
    visualMagnitude: 8.25,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.77764589),
        dec: Angle.Degrees(-68.49847770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115286"},
        {"Hipparcos Number", "HIP 64876"},
        {"Geneva Identification System", "GEN# +1.00115286"},
        {"Smithsonian Astrophysical Observation", "SAO 252245"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.48105323),
        dec: Angle.Degrees(-68.49564383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192137"},
        {"Hipparcos Number", "HIP 100063"},
        {"Smithsonian Astrophysical Observation", "SAO 254767"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.51309933),
        dec: Angle.Degrees(-68.48949982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78913"},
        {"Hipparcos Number", "HIP 44734"},
        {"Geneva Identification System", "GEN# +1.00078913"},
        {"Smithsonian Astrophysical Observation", "SAO 250447"},
        {"Wilson Evans Batten Catalogue", "WEB 8554"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.72823031),
        dec: Angle.Degrees(-68.48948161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107946"},
        {"Hipparcos Number", "HIP 60554"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.19972061),
        dec: Angle.Degrees(-68.48100558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101966"},
        {"Hipparcos Number", "HIP 57189"},
        {"Geneva Identification System", "GEN# +1.00101966"},
        {"Smithsonian Astrophysical Observation", "SAO 251556"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.90255579),
        dec: Angle.Degrees(-68.47872425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21328"},
        {"Hipparcos Number", "HIP 15681"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.50667835),
        dec: Angle.Degrees(-68.47500453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35183"},
        {"Hipparcos Number", "HIP 24652"},
        {"Geneva Identification System", "GEN# +2.19010007"},
        {"Geneva Identification System 2", "GEN# +9.00080007"},
        {"New General Catalogue", "NGC 1901 7"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.34596324),
        dec: Angle.Degrees(-68.47200145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205312"},
        {"Hipparcos Number", "HIP 106791"},
        {"Smithsonian Astrophysical Observation", "SAO 255037"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.45480858),
        dec: Angle.Degrees(-68.46851668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154826"},
        {"Hipparcos Number", "HIP 84245"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.32125709),
        dec: Angle.Degrees(-68.46671484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152324"},
        {"Hipparcos Number", "HIP 83030"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.50819357),
        dec: Angle.Degrees(-68.45943826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91851"},
        {"Hipparcos Number", "HIP 51731"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.54567120),
        dec: Angle.Degrees(-68.45934402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3968"},
        {"Hipparcos Number", "HIP 3238"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.30124327),
        dec: Angle.Degrees(-68.45781835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -159.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19862"},
        {"Hipparcos Number", "HIP 14513"},
        {"Smithsonian Astrophysical Observation", "SAO 248738"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.85648239),
        dec: Angle.Degrees(-68.45241204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100753"},
        {"Hipparcos Number", "HIP 56495"},
        {"Celescope Catalog", "CEL 3918"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.73059106),
        dec: Angle.Degrees(-68.45235409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 310545"},
        {"Hipparcos Number", "HIP 56075"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.40571372),
        dec: Angle.Degrees(-68.44366387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73743"},
        {"Hipparcos Number", "HIP 42143"},
        {"Smithsonian Astrophysical Observation", "SAO 250278"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.86042759),
        dec: Angle.Degrees(-68.44294752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31562"},
        {"Hipparcos Number", "HIP 22567"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.85883840),
        dec: Angle.Degrees(-68.43997229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23004"},
        {"Hipparcos Number", "HIP 16857"},
        {"Geneva Identification System", "GEN# +1.00023004"},
        {"Smithsonian Astrophysical Observation", "SAO 248854"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.23428800),
        dec: Angle.Degrees(-68.43814751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143549"},
        {"Hipparcos Number", "HIP 78848"},
        {"Geneva Identification System", "GEN# +1.00143549"},
        {"Smithsonian Astrophysical Observation", "SAO 253414"},
    },
    visualMagnitude: 7.71,
    bvColour: -0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.43377821),
        dec: Angle.Degrees(-68.43555293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98394"},
        {"Hipparcos Number", "HIP 55195"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.51472276),
        dec: Angle.Degrees(-68.43533131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108003"},
        {"Hipparcos Number", "HIP 60576"},
        {"Geneva Identification System", "GEN# +1.00108003"},
        {"Renson", "Renson 31330"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.24828774),
        dec: Angle.Degrees(-68.43504190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182709"},
        {"Hipparcos Number", "HIP 95999"},
        {"Fundamental Katalog 5th Edition", "FK5 3557"},
        {"Geneva Identification System", "GEN# +1.00182709"},
        {"Smithsonian Astrophysical Observation", "SAO 254590"},
    },
    visualMagnitude: 5.98,
    bvColour: 1.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.79559581),
        dec: Angle.Degrees(-68.43388713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191604"},
        {"Hipparcos Number", "HIP 99850"},
        {"Fundamental Katalog 5th Edition", "FK5 5785"},
        {"Smithsonian Astrophysical Observation", "SAO 254759"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.87165989),
        dec: Angle.Degrees(-68.43248920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222760"},
        {"Hipparcos Number", "HIP 117058"},
        {"Smithsonian Astrophysical Observation", "SAO 255553"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.96836570),
        dec: Angle.Degrees(-68.42944562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42650",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42650"},
    },
    visualMagnitude: 11.03,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.38672128),
        dec: Angle.Degrees(-68.42824308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -112.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 164.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189774"},
        {"Hipparcos Number", "HIP 99047"},
        {"Smithsonian Astrophysical Observation", "SAO 254724"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.63915475),
        dec: Angle.Degrees(-68.42739334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111232"},
        {"Hipparcos Number", "HIP 62534"},
        {"Geneva Identification System", "GEN# +1.00111232"},
        {"Wilson Evans Batten Catalogue", "WEB 11100"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.21545908),
        dec: Angle.Degrees(-68.42542528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 112.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140909"},
        {"Hipparcos Number", "HIP 77620"},
    },
    visualMagnitude: 8.99,
    bvColour: -0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.69443021),
        dec: Angle.Degrees(-68.42502796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198928"},
        {"Hipparcos Number", "HIP 103468"},
        {"Smithsonian Astrophysical Observation", "SAO 254905"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.44442982),
        dec: Angle.Degrees(-68.42468721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177389"},
        {"Hipparcos Number", "HIP 94150"},
        {"Geneva Identification System", "GEN# +1.00177389"},
        {"Smithsonian Astrophysical Observation", "SAO 254475"},
        {"Wilson Evans Batten Catalogue", "WEB 16400"},
    },
    visualMagnitude: 5.31,
    bvColour: 0.901,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.46925968),
        dec: Angle.Degrees(-68.42434424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 154.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50519"},
        {"Hipparcos Number", "HIP 32604"},
        {"Smithsonian Astrophysical Observation", "SAO 249651"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.03722418),
        dec: Angle.Degrees(-68.42380827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85612"},
        {"Hipparcos Number", "HIP 48223"},
        {"Smithsonian Astrophysical Observation", "SAO 250714"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.905,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.47909101),
        dec: Angle.Degrees(-68.41950992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216507"},
        {"Hipparcos Number", "HIP 113168"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.74814384),
        dec: Angle.Degrees(-68.41864635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147801"},
        {"Hipparcos Number", "HIP 80733"},
        {"Smithsonian Astrophysical Observation", "SAO 253561"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.23889337),
        dec: Angle.Degrees(-68.41794718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124531"},
        {"Hipparcos Number", "HIP 69803"},
    },
    visualMagnitude: 8.43,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.29090465),
        dec: Angle.Degrees(-68.40706828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86010"},
        {"Hipparcos Number", "HIP 48452"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.18470720),
        dec: Angle.Degrees(-68.40303606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3600"},
        {"Hipparcos Number", "HIP 2985"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.48987267),
        dec: Angle.Degrees(-68.40005029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177643"},
        {"Hipparcos Number", "HIP 94228"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.72578146),
        dec: Angle.Degrees(-68.39979961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214732"},
        {"Hipparcos Number", "HIP 112080"},
        {"Smithsonian Astrophysical Observation", "SAO 255289"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.52871454),
        dec: Angle.Degrees(-68.39904841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223148"},
        {"Hipparcos Number", "HIP 117324"},
        {"Fundamental Katalog 5th Edition", "FK5 3911"},
        {"Geneva Identification System", "GEN# +1.00223148"},
        {"Smithsonian Astrophysical Observation", "SAO 255567"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.84700678),
        dec: Angle.Degrees(-68.39388632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126908"},
        {"Hipparcos Number", "HIP 71028"},
        {"Smithsonian Astrophysical Observation", "SAO 252769"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.90478095),
        dec: Angle.Degrees(-68.39365374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12087"},
        {"Hipparcos Number", "HIP 8995"},
        {"Geneva Identification System", "GEN# +1.00012087"},
        {"Smithsonian Astrophysical Observation", "SAO 248466"},
        {"Wilson Evans Batten Catalogue", "WEB 1892"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.96945333),
        dec: Angle.Degrees(-68.39188931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130721"},
        {"Hipparcos Number", "HIP 72850"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.35301019),
        dec: Angle.Degrees(-68.39155159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14421"},
        {"Hipparcos Number", "HIP 10609"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.14292472),
        dec: Angle.Degrees(-68.39128656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185655"},
        {"Hipparcos Number", "HIP 97196"},
        {"Geneva Identification System", "GEN# +1.00185655"},
    },
    visualMagnitude: 10.11,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.31475190),
        dec: Angle.Degrees(-68.38951599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 133.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70308",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70308"},
    },
    visualMagnitude: 10.25,
    bvColour: 1.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.77626176),
        dec: Angle.Degrees(-68.38207621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -238.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217809"},
        {"Hipparcos Number", "HIP 113953"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.15620250),
        dec: Angle.Degrees(-68.37920843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209002"},
        {"Hipparcos Number", "HIP 108847"},
        {"Geneva Identification System", "GEN# +1.00209002"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.74020903),
        dec: Angle.Degrees(-68.37455169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194972"},
        {"Hipparcos Number", "HIP 101397"},
        {"Smithsonian Astrophysical Observation", "SAO 254811"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.23875636),
        dec: Angle.Degrees(-68.37195733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181019"},
        {"Hipparcos Number", "HIP 95369"},
        {"Geneva Identification System", "GEN# +1.00181019"},
        {"Smithsonian Astrophysical Observation", "SAO 254551"},
    },
    visualMagnitude: 6.33,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.02297340),
        dec: Angle.Degrees(-68.37107984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224853"},
        {"Hipparcos Number", "HIP 103"},
        {"Smithsonian Astrophysical Observation", "SAO 255622"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.32214393),
        dec: Angle.Degrees(-68.37102958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139756"},
        {"Hipparcos Number", "HIP 77090"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.11392469),
        dec: Angle.Degrees(-68.36736373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94262"},
        {"Hipparcos Number", "HIP 53023"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.72677451),
        dec: Angle.Degrees(-68.36246619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81933"},
        {"Hipparcos Number", "HIP 46205"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.31527931),
        dec: Angle.Degrees(-68.36220451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69578"},
        {"Hipparcos Number", "HIP 40208"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.18185050),
        dec: Angle.Degrees(-68.35778943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38096",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38096"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.09608190),
        dec: Angle.Degrees(-68.35434987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109448"},
        {"Hipparcos Number", "HIP 61447"},
        {"Geneva Identification System", "GEN# +1.00109448"},
        {"Smithsonian Astrophysical Observation", "SAO 251959"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.88346392),
        dec: Angle.Degrees(-68.35089853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217728"},
        {"Hipparcos Number", "HIP 113911"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.01733379),
        dec: Angle.Degrees(-68.34811695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210966"},
        {"Hipparcos Number", "HIP 109988"},
        {"Smithsonian Astrophysical Observation", "SAO 255182"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.14997824),
        dec: Angle.Degrees(-68.34628395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25549"},
        {"Hipparcos Number", "HIP 18577"},
        {"Smithsonian Astrophysical Observation", "SAO 248920"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.64748646),
        dec: Angle.Degrees(-68.34374819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142172"},
        {"Hipparcos Number", "HIP 78182"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.45067322),
        dec: Angle.Degrees(-68.33909774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70821"},
        {"Hipparcos Number", "HIP 40784"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.85796716),
        dec: Angle.Degrees(-68.33709959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21618"},
        {"Hipparcos Number", "HIP 15910"},
        {"Geneva Identification System", "GEN# +1.00021618"},
        {"Smithsonian Astrophysical Observation", "SAO 248802"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.21932037),
        dec: Angle.Degrees(-68.33464065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104173"},
        {"Hipparcos Number", "HIP 58499"},
    },
    visualMagnitude: 8.05,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.95395167),
        dec: Angle.Degrees(-68.33444061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94805"},
        {"Hipparcos Number", "HIP 53381"},
        {"Smithsonian Astrophysical Observation", "SAO 251176"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.75549051),
        dec: Angle.Degrees(-68.33120146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210097"},
        {"Hipparcos Number", "HIP 109475"},
        {"Smithsonian Astrophysical Observation", "SAO 255160"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.66385149),
        dec: Angle.Degrees(-68.32892055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 106.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104878"},
        {"Hipparcos Number", "HIP 58884"},
        {"Geneva Identification System", "GEN# +1.00104878"},
        {"Smithsonian Astrophysical Observation", "SAO 251720"},
        {"Wilson Evans Batten Catalogue", "WEB 10488"},
    },
    visualMagnitude: 5.34,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.16227840),
        dec: Angle.Degrees(-68.32889673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97971"},
        {"Hipparcos Number", "HIP 54931"},
        {"Smithsonian Astrophysical Observation", "SAO 251332"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.72803236),
        dec: Angle.Degrees(-68.32790544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146350"},
        {"Hipparcos Number", "HIP 80090"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.21303568),
        dec: Angle.Degrees(-68.32486908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183827"},
        {"Hipparcos Number", "HIP 96444"},
        {"Smithsonian Astrophysical Observation", "SAO 254603"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.12366293),
        dec: Angle.Degrees(-68.32373468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88267"},
        {"Hipparcos Number", "HIP 49646"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.00727899),
        dec: Angle.Degrees(-68.32373288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32246"},
        {"Hipparcos Number", "HIP 22945"},
        {"Smithsonian Astrophysical Observation", "SAO 249153"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.05444943),
        dec: Angle.Degrees(-68.32320022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155303"},
        {"Hipparcos Number", "HIP 84462"},
        {"Smithsonian Astrophysical Observation", "SAO 253848"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.01206408),
        dec: Angle.Degrees(-68.32168226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79449"},
        {"Hipparcos Number", "HIP 45024"},
        {"Fundamental Katalog 5th Edition", "FK5 4818"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.56985464),
        dec: Angle.Degrees(-68.31922725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80454",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80454"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.863,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.33846735),
        dec: Angle.Degrees(-68.31911513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -133.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -239.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103749"},
        {"Hipparcos Number", "HIP 58244"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.18393503),
        dec: Angle.Degrees(-68.31515962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 270305"},
        {"Hipparcos Number", "HIP 27868"},
        {"Geneva Identification System", "GEN# +1.00270305"},
    },
    visualMagnitude: 11.74,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.45710582),
        dec: Angle.Degrees(-68.31315565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211317"},
        {"Hipparcos Number", "HIP 110161"},
        {"Geneva Identification System", "GEN# +1.00211317"},
        {"Smithsonian Astrophysical Observation", "SAO 255192"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.70666850),
        dec: Angle.Degrees(-68.31264139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -187.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185078"},
        {"Hipparcos Number", "HIP 96952"},
        {"Smithsonian Astrophysical Observation", "SAO 254629"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.63458954),
        dec: Angle.Degrees(-68.30930399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136672"},
        {"Hipparcos Number", "HIP 75565"},
        {"Geneva Identification System", "GEN# +1.00136672"},
        {"Smithsonian Astrophysical Observation", "SAO 253155"},
        {"Wilson Evans Batten Catalogue", "WEB 12876"},
    },
    visualMagnitude: 5.89,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.56053440),
        dec: Angle.Degrees(-68.30918936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 123.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107567"},
        {"Hipparcos Number", "HIP 60329"},
        {"Geneva Identification System", "GEN# +1.00107567"},
        {"Smithsonian Astrophysical Observation", "SAO 251868"},
    },
    visualMagnitude: 5.73,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.55014315),
        dec: Angle.Degrees(-68.30719873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134940"},
        {"Hipparcos Number", "HIP 74751"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.15437071),
        dec: Angle.Degrees(-68.30336092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104751"},
        {"Hipparcos Number", "HIP 58804"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.91988534),
        dec: Angle.Degrees(-68.30315631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13087"},
        {"Hipparcos Number", "HIP 9721"},
        {"Smithsonian Astrophysical Observation", "SAO 248492"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.25636359),
        dec: Angle.Degrees(-68.30086219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177409"},
        {"Hipparcos Number", "HIP 94154"},
        {"Geneva Identification System", "GEN# +1.00177409"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.47629067),
        dec: Angle.Degrees(-68.29958856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 155.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87969"},
        {"Hipparcos Number", "HIP 49457"},
        {"Smithsonian Astrophysical Observation", "SAO 250813"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.46448892),
        dec: Angle.Degrees(-68.29809407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149671"},
        {"Hipparcos Number", "HIP 81710"},
        {"Geneva Identification System", "GEN# +1.00149671"},
        {"Smithsonian Astrophysical Observation", "SAO 253649"},
        {"Wilson Evans Batten Catalogue", "WEB 13800"},
    },
    visualMagnitude: 5.89,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.34637667),
        dec: Angle.Degrees(-68.29609440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187914"},
        {"Hipparcos Number", "HIP 98202"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.32995814),
        dec: Angle.Degrees(-68.29244111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219025"},
        {"Hipparcos Number", "HIP 114678"},
        {"Smithsonian Astrophysical Observation", "SAO 255433"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.46962331),
        dec: Angle.Degrees(-68.29131845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80214"},
        {"Hipparcos Number", "HIP 45365"},
        {"Celescope Catalog", "CEL 3246"},
        {"Geneva Identification System", "GEN# +1.00080214"},
    },
    visualMagnitude: 8.97,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.67673082),
        dec: Angle.Degrees(-68.28397379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77527"},
        {"Hipparcos Number", "HIP 44110"},
        {"Geneva Identification System", "GEN# +1.00077527"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.75925846),
        dec: Angle.Degrees(-68.28315358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136433"},
        {"Hipparcos Number", "HIP 75452"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.21694293),
        dec: Angle.Degrees(-68.28085597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224953"},
        {"Hipparcos Number", "HIP 169"},
        {"Geneva Identification System", "GEN# +1.00224953"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.53502093),
        dec: Angle.Degrees(-68.28020594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 207.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -231.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153389"},
        {"Hipparcos Number", "HIP 83556"},
        {"Smithsonian Astrophysical Observation", "SAO 253783"},
    },
    visualMagnitude: 6.47,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.14043478),
        dec: Angle.Degrees(-68.27864298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90355"},
        {"Hipparcos Number", "HIP 50889"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.87454373),
        dec: Angle.Degrees(-68.27797538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111108"},
        {"Hipparcos Number", "HIP 62464"},
        {"Smithsonian Astrophysical Observation", "SAO 252031"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.01254456),
        dec: Angle.Degrees(-68.27615943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98587"},
        {"Hipparcos Number", "HIP 55297"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.86422275),
        dec: Angle.Degrees(-68.27521621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85212"},
        {"Hipparcos Number", "HIP 48015"},
        {"Geneva Identification System", "GEN# +1.00085212"},
        {"Smithsonian Astrophysical Observation", "SAO 250699"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.81906860),
        dec: Angle.Degrees(-68.27353332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62402"},
        {"Hipparcos Number", "HIP 37208"},
        {"Smithsonian Astrophysical Observation", "SAO 249913"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.64809442),
        dec: Angle.Degrees(-68.27054306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215630"},
        {"Hipparcos Number", "HIP 112605"},
        {"Smithsonian Astrophysical Observation", "SAO 255319"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.09477863),
        dec: Angle.Degrees(-68.27009882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49339"},
        {"Hipparcos Number", "HIP 32108"},
    },
    visualMagnitude: 8.93,
    bvColour: -0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.60772011),
        dec: Angle.Degrees(-68.26860549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62760"},
        {"Hipparcos Number", "HIP 37384"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.841,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.10843716),
        dec: Angle.Degrees(-68.26841199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16978"},
        {"Hipparcos Number", "HIP 12394"},
        {"Fundamental Katalog 5th Edition", "FK5 95"},
        {"Geneva Identification System", "GEN# +1.00016978"},
        {"Smithsonian Astrophysical Observation", "SAO 248621"},
        {"Wilson Evans Batten Catalogue", "WEB 2540"},
    },
    visualMagnitude: 4.12,
    bvColour: -0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.89676530),
        dec: Angle.Degrees(-68.26694760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112149"},
        {"Hipparcos Number", "HIP 63077"},
        {"Geneva Identification System", "GEN# +1.00112149"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.86934495),
        dec: Angle.Degrees(-68.26563702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105822"},
        {"Hipparcos Number", "HIP 59389"},
        {"Smithsonian Astrophysical Observation", "SAO 251776"},
    },
    visualMagnitude: 6.48,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.75507582),
        dec: Angle.Degrees(-68.26093422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187396"},
        {"Hipparcos Number", "HIP 97975"},
        {"Smithsonian Astrophysical Observation", "SAO 254681"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.67559324),
        dec: Angle.Degrees(-68.25890935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181064"},
        {"Hipparcos Number", "HIP 95383"},
        {"Smithsonian Astrophysical Observation", "SAO 254554"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.05197242),
        dec: Angle.Degrees(-68.25884638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10482"},
        {"Hipparcos Number", "HIP 7758"},
        {"Smithsonian Astrophysical Observation", "SAO 248415"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.97631027),
        dec: Angle.Degrees(-68.25801993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18713"},
        {"Hipparcos Number", "HIP 13709"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.12841721),
        dec: Angle.Degrees(-68.25693101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93633"},
        {"Hipparcos Number", "HIP 52722"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.68385044),
        dec: Angle.Degrees(-68.25549926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96868"},
        {"Hipparcos Number", "HIP 54408"},
        {"Geneva Identification System", "GEN# +1.00096868"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.00075809),
        dec: Angle.Degrees(-68.25405054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215249"},
        {"Hipparcos Number", "HIP 112387"},
        {"Geneva Identification System", "GEN# +1.00215249"},
        {"Smithsonian Astrophysical Observation", "SAO 255308"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.43627099),
        dec: Angle.Degrees(-68.25396041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10081"},
        {"Hipparcos Number", "HIP 7473"},
        {"Renson", "Renson 2510"},
        {"Smithsonian Astrophysical Observation", "SAO 248408"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.06285812),
        dec: Angle.Degrees(-68.25149546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54733"},
        {"Hipparcos Number", "HIP 34126"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.14639126),
        dec: Angle.Degrees(-68.24857274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92176"},
        {"Hipparcos Number", "HIP 51932"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.13264195),
        dec: Angle.Degrees(-68.24179535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29738"},
        {"Hipparcos Number", "HIP 21416"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.94635406),
        dec: Angle.Degrees(-68.23807957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120863"},
        {"Hipparcos Number", "HIP 67910"},
        {"Geneva Identification System", "GEN# +1.00120863"},
        {"Smithsonian Astrophysical Observation", "SAO 252507"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.63978626),
        dec: Angle.Degrees(-68.23736710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121340"},
        {"Hipparcos Number", "HIP 68181"},
        {"Geneva Identification System", "GEN# +1.00121340"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.37052750),
        dec: Angle.Degrees(-68.23555788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98170"},
        {"Hipparcos Number", "HIP 55064"},
        {"Geneva Identification System", "GEN# +1.00098170"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.09121621),
        dec: Angle.Degrees(-68.23039370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166841"},
        {"Hipparcos Number", "HIP 89674"},
        {"Fundamental Katalog 5th Edition", "FK5 3452"},
        {"Geneva Identification System", "GEN# +1.00166841J"},
        {"Smithsonian Astrophysical Observation", "SAO 254196"},
    },
    visualMagnitude: 6.32,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.50398642),
        dec: Angle.Degrees(-68.22921619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203244"},
        {"Hipparcos Number", "HIP 105712"},
        {"Geneva Identification System", "GEN# +1.00203244"},
        {"Smithsonian Astrophysical Observation", "SAO 254993"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.723,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.16841880),
        dec: Angle.Degrees(-68.22824529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 140.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 169.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 269320"},
        {"Hipparcos Number", "HIP 24763"},
    },
    visualMagnitude: 11.09,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.63494469),
        dec: Angle.Degrees(-68.22590028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199935"},
        {"Hipparcos Number", "HIP 104000"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.05972786),
        dec: Angle.Degrees(-68.21401493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208233"},
        {"Hipparcos Number", "HIP 108422"},
        {"Geneva Identification System", "GEN# +1.00208233"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.767,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.46417253),
        dec: Angle.Degrees(-68.21371714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27102"},
        {"Hipparcos Number", "HIP 19585"},
        {"Smithsonian Astrophysical Observation", "SAO 248963"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.96090739),
        dec: Angle.Degrees(-68.21173751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75116"},
        {"Hipparcos Number", "HIP 42850"},
        {"Geneva Identification System", "GEN# +1.00075116"},
        {"Smithsonian Astrophysical Observation", "SAO 250315"},
    },
    visualMagnitude: 6.33,
    bvColour: 1.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.97635905),
        dec: Angle.Degrees(-68.21164561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94495"},
        {"Hipparcos Number", "HIP 53190"},
        {"Smithsonian Astrophysical Observation", "SAO 251161"},
    },
    visualMagnitude: 6.70,
    bvColour: 1.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.19366915),
        dec: Angle.Degrees(-68.21038528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83531"},
        {"Hipparcos Number", "HIP 47083"},
        {"Smithsonian Astrophysical Observation", "SAO 250634"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.92299174),
        dec: Angle.Degrees(-68.21029276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199475"},
        {"Hipparcos Number", "HIP 103752"},
        {"Geneva Identification System", "GEN# +1.00199475"},
        {"Smithsonian Astrophysical Observation", "SAO 254918"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.36679488),
        dec: Angle.Degrees(-68.20960595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217031"},
        {"Hipparcos Number", "HIP 113497"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.78686206),
        dec: Angle.Degrees(-68.20789411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128293"},
        {"Hipparcos Number", "HIP 71668"},
        {"Geneva Identification System", "GEN# +1.00128293"},
        {"Smithsonian Astrophysical Observation", "SAO 252835"},
        {"Wilson Evans Batten Catalogue", "WEB 12352"},
    },
    visualMagnitude: 6.73,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.88196865),
        dec: Angle.Degrees(-68.20337323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98134"},
        {"Hipparcos Number", "HIP 55046"},
        {"Smithsonian Astrophysical Observation", "SAO 251336"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.03386556),
        dec: Angle.Degrees(-68.19838587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22264"},
        {"Hipparcos Number", "HIP 16330"},
        {"Smithsonian Astrophysical Observation", "SAO 248823"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.62894596),
        dec: Angle.Degrees(-68.19823768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 945"},
        {"Hipparcos Number", "HIP 1091"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.40438190),
        dec: Angle.Degrees(-68.19764825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96933"},
        {"Hipparcos Number", "HIP 54436"},
        {"Smithsonian Astrophysical Observation", "SAO 251282"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.07668951),
        dec: Angle.Degrees(-68.19553459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125835"},
        {"Hipparcos Number", "HIP 70492"},
        {"Fundamental Katalog 5th Edition", "FK5 530"},
        {"Geneva Identification System", "GEN# +1.00125835"},
        {"Smithsonian Astrophysical Observation", "SAO 252735"},
        {"Wilson Evans Batten Catalogue", "WEB 12227"},
    },
    visualMagnitude: 5.56,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.27641298),
        dec: Angle.Degrees(-68.19532385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5784"},
        {"Hipparcos Number", "HIP 4527"},
        {"Geneva Identification System", "GEN# +1.00005784"},
        {"Smithsonian Astrophysical Observation", "SAO 248292"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.49488874),
        dec: Angle.Degrees(-68.19313474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11788"},
        {"Hipparcos Number", "HIP 8788"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.25355580),
        dec: Angle.Degrees(-68.18756219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3922"},
        {"Hipparcos Number", "HIP 3199"},
        {"Geneva Identification System", "GEN# +1.00003922"},
        {"Smithsonian Astrophysical Observation", "SAO 248233"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.19227404),
        dec: Angle.Degrees(-68.18644358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133811"},
        {"Hipparcos Number", "HIP 74248"},
        {"Renson", "Renson 37980"},
    },
    visualMagnitude: 8.86,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.60136473),
        dec: Angle.Degrees(-68.18382888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82801"},
        {"Hipparcos Number", "HIP 46667"},
        {"Geneva Identification System", "GEN# +1.00082801"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.72580685),
        dec: Angle.Degrees(-68.18295668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205254"},
        {"Hipparcos Number", "HIP 106750"},
        {"Smithsonian Astrophysical Observation", "SAO 255035"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.36147358),
        dec: Angle.Degrees(-68.17911973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116423"},
        {"Hipparcos Number", "HIP 65498"},
        {"Geneva Identification System", "GEN# +1.00116423"},
        {"Renson", "Renson 33580"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.36039510),
        dec: Angle.Degrees(-68.17754778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9231"},
        {"Hipparcos Number", "HIP 6886"},
        {"Smithsonian Astrophysical Observation", "SAO 248387"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.17390875),
        dec: Angle.Degrees(-68.17505257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23578"},
        {"Hipparcos Number", "HIP 17249"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.40709100),
        dec: Angle.Degrees(-68.16935666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 310071"},
        {"Hipparcos Number", "HIP 52048"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.53363980),
        dec: Angle.Degrees(-68.16753236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5176"},
        {"Hipparcos Number", "HIP 4081"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.08645780),
        dec: Angle.Degrees(-68.16724928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159367"},
        {"Hipparcos Number", "HIP 86442"},
        {"Renson", "Renson 44840"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.94122556),
        dec: Angle.Degrees(-68.16492869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50164",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50164"},
        {"Cincinnati Publication", "Ci 20 570"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.59070367),
        dec: Angle.Degrees(-68.16194024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -307.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 319.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3035"},
        {"Hipparcos Number", "HIP 2592"},
        {"Smithsonian Astrophysical Observation", "SAO 248209"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.22313916),
        dec: Angle.Degrees(-68.16135661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16504"},
        {"Hipparcos Number", "HIP 12051"},
        {"Geneva Identification System", "GEN# +1.00016504"},
        {"Renson", "Renson 4100"},
        {"Smithsonian Astrophysical Observation", "SAO 248607"},
    },
    visualMagnitude: 9.05,
    bvColour: -0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.84034980),
        dec: Angle.Degrees(-68.16111549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103080"},
        {"Hipparcos Number", "HIP 57849"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.95883261),
        dec: Angle.Degrees(-68.16108546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20889"},
        {"Hipparcos Number", "HIP 15331"},
        {"Geneva Identification System", "GEN# +1.00020889"},
        {"Smithsonian Astrophysical Observation", "SAO 248775"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.43430896),
        dec: Angle.Degrees(-68.15988551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113590"},
        {"Hipparcos Number", "HIP 63935"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.54465126),
        dec: Angle.Degrees(-68.15952671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187316"},
        {"Hipparcos Number", "HIP 97939"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.56195774),
        dec: Angle.Degrees(-68.15912278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87138"},
        {"Hipparcos Number", "HIP 49034"},
        {"Geneva Identification System", "GEN# +1.00087138"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.06291296),
        dec: Angle.Degrees(-68.14993545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17439"},
        {"Hipparcos Number", "HIP 12766"},
        {"Geneva Identification System", "GEN# +1.00017439"},
        {"Smithsonian Astrophysical Observation", "SAO 248638"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.01709808),
        dec: Angle.Degrees(-68.14823003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119863"},
        {"Hipparcos Number", "HIP 67345"},
        {"Fundamental Katalog 5th Edition", "FK5 5218"},
        {"Smithsonian Astrophysical Observation", "SAO 252454"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.04666647),
        dec: Angle.Degrees(-68.14607012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212907"},
        {"Hipparcos Number", "HIP 111057"},
        {"Smithsonian Astrophysical Observation", "SAO 255232"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.47169509),
        dec: Angle.Degrees(-68.14282742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123171"},
        {"Hipparcos Number", "HIP 69120"},
        {"Smithsonian Astrophysical Observation", "SAO 252620"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.23344517),
        dec: Angle.Degrees(-68.14043792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77493"},
        {"Hipparcos Number", "HIP 44099"},
        {"Celescope Catalog", "CEL 3132"},
        {"Geneva Identification System", "GEN# +1.00077493"},
        {"Smithsonian Astrophysical Observation", "SAO 250412"},
    },
    visualMagnitude: 6.93,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.73252448),
        dec: Angle.Degrees(-68.13927597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119559"},
        {"Hipparcos Number", "HIP 67205"},
        {"Geneva Identification System", "GEN# +1.00119559"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.784,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.57336652),
        dec: Angle.Degrees(-68.13877781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -262.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196446"},
        {"Hipparcos Number", "HIP 102133"},
        {"Smithsonian Astrophysical Observation", "SAO 254851"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.44331847),
        dec: Angle.Degrees(-68.13509917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175716"},
        {"Hipparcos Number", "HIP 93454"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.49209643),
        dec: Angle.Degrees(-68.13454543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35026"},
        {"Hipparcos Number", "HIP 24569"},
        {"Geneva Identification System", "GEN# +2.19010001"},
        {"Geneva Identification System 2", "GEN# +9.00080001"},
        {"Smithsonian Astrophysical Observation", "SAO 249234"},
        {"New General Catalogue", "NGC 1901 1"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.06225326),
        dec: Angle.Degrees(-68.13346885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140908"},
        {"Hipparcos Number", "HIP 77618"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.68849862),
        dec: Angle.Degrees(-68.13208315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93507"},
        {"Hipparcos Number", "HIP 52637"},
        {"Renson", "Renson 27020"},
        {"Smithsonian Astrophysical Observation", "SAO 251108"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.46102740),
        dec: Angle.Degrees(-68.13043005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46605"},
        {"Hipparcos Number", "HIP 30868"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.20868754),
        dec: Angle.Degrees(-68.13029537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137822"},
        {"Hipparcos Number", "HIP 76093"},
        {"Smithsonian Astrophysical Observation", "SAO 253198"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.11259346),
        dec: Angle.Degrees(-68.13007773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90456"},
        {"Hipparcos Number", "HIP 50945"},
        {"Smithsonian Astrophysical Observation", "SAO 250946"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.06097256),
        dec: Angle.Degrees(-68.12959184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111479"},
        {"Hipparcos Number", "HIP 62682"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.66632790),
        dec: Angle.Degrees(-68.12950417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210563"},
        {"Hipparcos Number", "HIP 109734"},
        {"Smithsonian Astrophysical Observation", "SAO 255175"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.42968462),
        dec: Angle.Degrees(-68.12638353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132791"},
        {"Hipparcos Number", "HIP 73778"},
    },
    visualMagnitude: 9.41,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.20400046),
        dec: Angle.Degrees(-68.12607270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129534"},
        {"Hipparcos Number", "HIP 72258"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.64488271),
        dec: Angle.Degrees(-68.12204003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81223"},
        {"Hipparcos Number", "HIP 45845"},
        {"Geneva Identification System", "GEN# +1.00081223"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.20271780),
        dec: Angle.Degrees(-68.12177871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -102.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 85.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145243"},
        {"Hipparcos Number", "HIP 79611"},
        {"Geneva Identification System", "GEN# +1.00145243"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.68312625),
        dec: Angle.Degrees(-68.11989967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47192"},
        {"Hipparcos Number", "HIP 31123"},
        {"Geneva Identification System", "GEN# +1.00047192"},
        {"Smithsonian Astrophysical Observation", "SAO 249580"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.96279772),
        dec: Angle.Degrees(-68.11957057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 270296"},
        {"Hipparcos Number", "HIP 27819"},
        {"Geneva Identification System", "GEN# +1.00270296"},
    },
    visualMagnitude: 11.57,
    bvColour: 0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.29177950),
        dec: Angle.Degrees(-68.11860194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142735"},
        {"Hipparcos Number", "HIP 78441"},
    },
    visualMagnitude: 8.76,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.21076761),
        dec: Angle.Degrees(-68.11634762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88922",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88922"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.883,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.27498011),
        dec: Angle.Degrees(-68.11278222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -212.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128021"},
        {"Hipparcos Number", "HIP 71537"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.47613760),
        dec: Angle.Degrees(-68.10869166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64485"},
        {"Hipparcos Number", "HIP 38169"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.31254170),
        dec: Angle.Degrees(-68.10843571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110879"},
        {"Hipparcos Number", "HIP 62322"},
        {"Celescope Catalog", "CEL 4152"},
        {"Geneva Identification System", "GEN# +1.00110879"},
        {"Smithsonian Astrophysical Observation", "SAO 252019"},
        {"Wilson Evans Batten Catalogue", "WEB 11066"},
    },
    visualMagnitude: 3.04,
    bvColour: -0.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.57029013),
        dec: Angle.Degrees(-68.10809405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224915"},
        {"Hipparcos Number", "HIP 140"},
        {"Smithsonian Astrophysical Observation", "SAO 255626"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.45267471),
        dec: Angle.Degrees(-68.10481108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28109"},
        {"Hipparcos Number", "HIP 20295"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.23790641),
        dec: Angle.Degrees(-68.10261766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150550"},
        {"Hipparcos Number", "HIP 82147"},
        {"Smithsonian Astrophysical Observation", "SAO 253689"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.73137046),
        dec: Angle.Degrees(-68.10204497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203531"},
        {"Hipparcos Number", "HIP 105842"},
    },
    visualMagnitude: 8.87,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.56517960),
        dec: Angle.Degrees(-68.10014335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77656"},
        {"Hipparcos Number", "HIP 44177"},
        {"Smithsonian Astrophysical Observation", "SAO 250416"},
    },
    visualMagnitude: 7.53,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.97666486),
        dec: Angle.Degrees(-68.09349490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128038"},
        {"Hipparcos Number", "HIP 71543"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.49282451),
        dec: Angle.Degrees(-68.09312644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85986"},
        {"Hipparcos Number", "HIP 48442"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.15616074),
        dec: Angle.Degrees(-68.09283670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64180",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64180"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.30666280),
        dec: Angle.Degrees(-68.09275374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118848"},
        {"Hipparcos Number", "HIP 66816"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.43237177),
        dec: Angle.Degrees(-68.09219916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111466"},
        {"Hipparcos Number", "HIP 62677"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.64953316),
        dec: Angle.Degrees(-68.09128222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134605"},
        {"Hipparcos Number", "HIP 74624"},
        {"Geneva Identification System", "GEN# +1.00134605"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.71357210),
        dec: Angle.Degrees(-68.08881850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33486"},
        {"Hipparcos Number", "HIP 23663"},
        {"Geneva Identification System", "GEN# +1.00033486"},
        {"Smithsonian Astrophysical Observation", "SAO 249185"},
    },
    visualMagnitude: 7.86,
    bvColour: -0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.27771367),
        dec: Angle.Degrees(-68.08644223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14793"},
        {"Hipparcos Number", "HIP 10862"},
        {"Geneva Identification System", "GEN# +1.00014793"},
        {"Smithsonian Astrophysical Observation", "SAO 248535"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.94604645),
        dec: Angle.Degrees(-68.08442587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207258"},
        {"Hipparcos Number", "HIP 107826"},
        {"Smithsonian Astrophysical Observation", "SAO 255088"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.66865531),
        dec: Angle.Degrees(-68.08396845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38942"},
        {"Hipparcos Number", "HIP 26995"},
        {"Fundamental Katalog 5th Edition", "FK5 4526"},
        {"Smithsonian Astrophysical Observation", "SAO 249341"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.90615562),
        dec: Angle.Degrees(-68.08138309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102969"},
        {"Hipparcos Number", "HIP 57783"},
        {"Smithsonian Astrophysical Observation", "SAO 251610"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.73475749),
        dec: Angle.Degrees(-68.08076458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128163"},
        {"Hipparcos Number", "HIP 71610"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.68347248),
        dec: Angle.Degrees(-68.07842652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224434"},
        {"Hipparcos Number", "HIP 118145"},
        {"Smithsonian Astrophysical Observation", "SAO 255611"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.47664074),
        dec: Angle.Degrees(-68.07655603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36650"},
        {"Hipparcos Number", "HIP 25547"},
        {"Geneva Identification System", "GEN# +1.00036650"},
        {"Smithsonian Astrophysical Observation", "SAO 249285"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.92881296),
        dec: Angle.Degrees(-68.07420336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148081"},
        {"Hipparcos Number", "HIP 80858"},
        {"Smithsonian Astrophysical Observation", "SAO 253579"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.67257442),
        dec: Angle.Degrees(-68.07185728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199868"},
        {"Hipparcos Number", "HIP 103953"},
        {"Geneva Identification System", "GEN# +1.00199868"},
        {"Smithsonian Astrophysical Observation", "SAO 254927"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.94486557),
        dec: Angle.Degrees(-68.07179366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57199"},
        {"Hipparcos Number", "HIP 35052"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.73483135),
        dec: Angle.Degrees(-68.07083428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -128.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31532"},
        {"Hipparcos Number", "HIP 22563"},
        {"Smithsonian Astrophysical Observation", "SAO 249125"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.83693907),
        dec: Angle.Degrees(-68.06979921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8298"},
        {"Hipparcos Number", "HIP 6266"},
        {"Smithsonian Astrophysical Observation", "SAO 248367"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.09084872),
        dec: Angle.Degrees(-68.06966576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88847"},
        {"Hipparcos Number", "HIP 49987"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.07842896),
        dec: Angle.Degrees(-68.06804823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158081"},
        {"Hipparcos Number", "HIP 85849"},
        {"Smithsonian Astrophysical Observation", "SAO 253950"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.15007127),
        dec: Angle.Degrees(-68.06762622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89976"},
        {"Hipparcos Number", "HIP 50659"},
    },
    visualMagnitude: 7.67,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.18906184),
        dec: Angle.Degrees(-68.06557245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206182"},
        {"Hipparcos Number", "HIP 107264"},
        {"Fundamental Katalog 5th Edition", "FK5 5917"},
        {"Smithsonian Astrophysical Observation", "SAO 255055"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.89021353),
        dec: Angle.Degrees(-68.06477320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212805"},
        {"Hipparcos Number", "HIP 110990"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.29015572),
        dec: Angle.Degrees(-68.06278282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214343"},
        {"Hipparcos Number", "HIP 111862"},
        {"Smithsonian Astrophysical Observation", "SAO 255272"},
    },
    visualMagnitude: 6.90,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.87656752),
        dec: Angle.Degrees(-68.06033790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89049"},
        {"Hipparcos Number", "HIP 50108"},
        {"Smithsonian Astrophysical Observation", "SAO 250884"},
    },
    visualMagnitude: 6.73,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.45522436),
        dec: Angle.Degrees(-68.05982909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123507"},
        {"Hipparcos Number", "HIP 69264"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.69587250),
        dec: Angle.Degrees(-68.05897907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -151.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100324"},
        {"Hipparcos Number", "HIP 56252"},
        {"Geneva Identification System", "GEN# +1.00100324"},
        {"Smithsonian Astrophysical Observation", "SAO 251446"},
        {"Wilson Evans Batten Catalogue", "WEB 10112"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.96124141),
        dec: Angle.Degrees(-68.05793762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223056"},
        {"Hipparcos Number", "HIP 117263"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.64582915),
        dec: Angle.Degrees(-68.05615848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85256"},
        {"Hipparcos Number", "HIP 48040"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.855,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.89976655),
        dec: Angle.Degrees(-68.05554292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5558",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5558"},
        {"Smithsonian Astrophysical Observation", "SAO 248335"},
    },
    visualMagnitude: 9.59,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.82039522),
        dec: Angle.Degrees(-68.04854122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106855",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106855"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.63247148),
        dec: Angle.Degrees(-68.04791461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 173.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40810"},
        {"Hipparcos Number", "HIP 28026"},
        {"Smithsonian Astrophysical Observation", "SAO 249398"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.90940967),
        dec: Angle.Degrees(-68.04698430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 78.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124672"},
        {"Hipparcos Number", "HIP 69867"},
        {"Geneva Identification System", "GEN# +1.00124672"},
        {"Smithsonian Astrophysical Observation", "SAO 252686"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.46508528),
        dec: Angle.Degrees(-68.04675579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -114.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115285"},
        {"Hipparcos Number", "HIP 64871"},
        {"Geneva Identification System", "GEN# +1.00115285"},
        {"Renson", "Renson 33310"},
        {"Smithsonian Astrophysical Observation", "SAO 252244"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.45120959),
        dec: Angle.Degrees(-68.04012732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220649"},
        {"Hipparcos Number", "HIP 115694"},
        {"Smithsonian Astrophysical Observation", "SAO 255482"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.58936884),
        dec: Angle.Degrees(-68.03315921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149157"},
        {"Hipparcos Number", "HIP 81435"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.50041239),
        dec: Angle.Degrees(-68.03156214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -173.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -167.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32972"},
        {"Hipparcos Number", "HIP 23374"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.38656239),
        dec: Angle.Degrees(-68.02876988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223765"},
        {"Hipparcos Number", "HIP 117732"},
        {"Smithsonian Astrophysical Observation", "SAO 255590"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.15902206),
        dec: Angle.Degrees(-68.02371623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209653"},
        {"Hipparcos Number", "HIP 109214"},
        {"Geneva Identification System", "GEN# +1.00209653"},
        {"Smithsonian Astrophysical Observation", "SAO 255146"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.87637290),
        dec: Angle.Degrees(-68.02335188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -238.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59144"},
        {"Hipparcos Number", "HIP 35847"},
        {"Smithsonian Astrophysical Observation", "SAO 249846"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.86878402),
        dec: Angle.Degrees(-68.02163548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30759"},
        {"Hipparcos Number", "HIP 22088"},
        {"Smithsonian Astrophysical Observation", "SAO 249100"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.28214509),
        dec: Angle.Degrees(-68.02133259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88952",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88952"},
        {"Smithsonian Astrophysical Observation", "SAO 254148"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.35883368),
        dec: Angle.Degrees(-68.02106658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139280"},
        {"Hipparcos Number", "HIP 76863"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.43830822),
        dec: Angle.Degrees(-68.01888177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82349"},
        {"Hipparcos Number", "HIP 46423"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.99150089),
        dec: Angle.Degrees(-68.01461938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65428"},
        {"Hipparcos Number", "HIP 38565"},
        {"Smithsonian Astrophysical Observation", "SAO 250004"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.44113419),
        dec: Angle.Degrees(-68.00948254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2989"},
        {"Hipparcos Number", "HIP 2556"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.928,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.11891430),
        dec: Angle.Degrees(-68.00764433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 69.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121365"},
        {"Hipparcos Number", "HIP 68183"},
        {"Smithsonian Astrophysical Observation", "SAO 252529"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.37507656),
        dec: Angle.Degrees(-68.00570947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36277"},
        {"Hipparcos Number", "HIP 25330"},
        {"Geneva Identification System", "GEN# +1.00036277"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.893,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.26251852),
        dec: Angle.Degrees(-68.00314262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139853"},
        {"Hipparcos Number", "HIP 77127"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.22575274),
        dec: Angle.Degrees(-68.00232006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181551"},
        {"Hipparcos Number", "HIP 95539"},
        {"Smithsonian Astrophysical Observation", "SAO 254566"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.49856157),
        dec: Angle.Degrees(-67.99953700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28865"},
        {"Hipparcos Number", "HIP 20823"},
        {"Smithsonian Astrophysical Observation", "SAO 249033"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.92923306),
        dec: Angle.Degrees(-67.99861447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75522"},
        {"Hipparcos Number", "HIP 43056"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.807,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.57931320),
        dec: Angle.Degrees(-67.99297000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 137.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -167.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 268625"},
        {"Hipparcos Number", "HIP 22492"},
        {"Geneva Identification System", "GEN# +1.00268625"},
    },
    visualMagnitude: 10.92,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.58020230),
        dec: Angle.Degrees(-67.98654737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132127"},
        {"Hipparcos Number", "HIP 73494"},
        {"Geneva Identification System", "GEN# +1.00132127J"},
        {"Smithsonian Astrophysical Observation", "SAO 252988"},
    },
    visualMagnitude: 6.99,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.31346791),
        dec: Angle.Degrees(-67.98328276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8665"},
        {"Hipparcos Number", "HIP 6495"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.85762490),
        dec: Angle.Degrees(-67.98302134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6712"},
        {"Hipparcos Number", "HIP 5179"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.55783863),
        dec: Angle.Degrees(-67.98001430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207766"},
        {"Hipparcos Number", "HIP 108116"},
        {"Smithsonian Astrophysical Observation", "SAO 255096"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.56708371),
        dec: Angle.Degrees(-67.97198991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142550"},
        {"Hipparcos Number", "HIP 78337"},
        {"Geneva Identification System", "GEN# +1.00142550"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.816,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.93603959),
        dec: Angle.Degrees(-67.97130225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16034"},
        {"Hipparcos Number", "HIP 11712"},
        {"Geneva Identification System", "GEN# +1.00016034"},
        {"Smithsonian Astrophysical Observation", "SAO 248587"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.883,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.79681157),
        dec: Angle.Degrees(-67.96785625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56240"},
        {"Hipparcos Number", "HIP 34686"},
        {"Smithsonian Astrophysical Observation", "SAO 249772"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.74896153),
        dec: Angle.Degrees(-67.96136992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106849"},
        {"Hipparcos Number", "HIP 59929"},
        {"Geneva Identification System", "GEN# +1.00106849"},
        {"Smithsonian Astrophysical Observation", "SAO 251830"},
        {"Wilson Evans Batten Catalogue", "WEB 10646"},
    },
    visualMagnitude: 4.06,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.39431802),
        dec: Angle.Degrees(-67.96067161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -231.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112383"},
        {"Hipparcos Number", "HIP 63236"},
        {"Geneva Identification System", "GEN# +1.00112383"},
        {"Smithsonian Astrophysical Observation", "SAO 252105"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.35936744),
        dec: Angle.Degrees(-67.96066515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57623"},
        {"Hipparcos Number", "HIP 35228"},
        {"Fundamental Katalog 5th Edition", "FK5 281"},
        {"Geneva Identification System", "GEN# +1.00057623"},
        {"Smithsonian Astrophysical Observation", "SAO 249809"},
        {"Wilson Evans Batten Catalogue", "WEB 7038"},
    },
    visualMagnitude: 3.97,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.20762844),
        dec: Angle.Degrees(-67.95717248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169744"},
        {"Hipparcos Number", "HIP 90815"},
        {"Renson", "Renson 47514"},
        {"Smithsonian Astrophysical Observation", "SAO 254268"},
    },
    visualMagnitude: 8.00,
    bvColour: -0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.88482847),
        dec: Angle.Degrees(-67.95499183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45160"},
        {"Hipparcos Number", "HIP 30128"},
        {"Smithsonian Astrophysical Observation", "SAO 249521"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.10049728),
        dec: Angle.Degrees(-67.94562211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11733"},
        {"Hipparcos Number", "HIP 8751"},
        {"Geneva Identification System", "GEN# +1.00011733"},
        {"Smithsonian Astrophysical Observation", "SAO 248455"},
        {"Wilson Evans Batten Catalogue", "WEB 1845"},
    },
    visualMagnitude: 6.77,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.14474520),
        dec: Angle.Degrees(-67.94448963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223412"},
        {"Hipparcos Number", "HIP 117499"},
        {"Smithsonian Astrophysical Observation", "SAO 255577"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.40796886),
        dec: Angle.Degrees(-67.94399119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 250.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183316"},
        {"Hipparcos Number", "HIP 96226"},
        {"Geneva Identification System", "GEN# +1.00183316"},
        {"Smithsonian Astrophysical Observation", "SAO 254593"},
        {"Wilson Evans Batten Catalogue", "WEB 16864"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.51431480),
        dec: Angle.Degrees(-67.94243555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77757"},
        {"Hipparcos Number", "HIP 44241"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.862,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.14361263),
        dec: Angle.Degrees(-67.94129710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145689"},
        {"Hipparcos Number", "HIP 79797"},
        {"Geneva Identification System", "GEN# +1.00145689"},
        {"Smithsonian Astrophysical Observation", "SAO 253481"},
        {"Wilson Evans Batten Catalogue", "WEB 13507"},
    },
    visualMagnitude: 5.95,
    bvColour: 0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.27284183),
        dec: Angle.Degrees(-67.94107968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210287"},
        {"Hipparcos Number", "HIP 109580"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.97133992),
        dec: Angle.Degrees(-67.94034004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55478"},
        {"Hipparcos Number", "HIP 34386"},
        {"Smithsonian Astrophysical Observation", "SAO 249747"},
    },
    visualMagnitude: 8.00,
    bvColour: -0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.94571191),
        dec: Angle.Degrees(-67.93688241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128020"},
        {"Hipparcos Number", "HIP 71530"},
        {"Cincinnati Publication", "Ci 20 871"},
        {"Fundamental Katalog 5th Edition", "FK5 3156"},
        {"Geneva Identification System", "GEN# +1.00128020"},
        {"Smithsonian Astrophysical Observation", "SAO 252824"},
        {"Wilson Evans Batten Catalogue", "WEB 12337"},
    },
    visualMagnitude: 6.03,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.44498594),
        dec: Angle.Degrees(-67.93132799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -348.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -281.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156545"},
        {"Hipparcos Number", "HIP 85095"},
        {"Geneva Identification System", "GEN# +1.00156545"},
        {"Smithsonian Astrophysical Observation", "SAO 253891"},
    },
    visualMagnitude: 8.89,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.87515554),
        dec: Angle.Degrees(-67.92910516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114702"},
        {"Hipparcos Number", "HIP 64545"},
        {"Smithsonian Astrophysical Observation", "SAO 252208"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.44152547),
        dec: Angle.Degrees(-67.92609730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96812"},
        {"Hipparcos Number", "HIP 54310"},
        {"Smithsonian Astrophysical Observation", "SAO 251271"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.65697813),
        dec: Angle.Degrees(-67.92409128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81881"},
        {"Hipparcos Number", "HIP 46177"},
        {"Geneva Identification System", "GEN# +1.00081881"},
        {"Smithsonian Astrophysical Observation", "SAO 250573"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.23930341),
        dec: Angle.Degrees(-67.92179112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 114.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200505"},
        {"Hipparcos Number", "HIP 104299"},
        {"Geneva Identification System", "GEN# +1.00200505"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.93997560),
        dec: Angle.Degrees(-67.92003933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 211.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6115",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6115"},
    },
    visualMagnitude: 11.63,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.62755064),
        dec: Angle.Degrees(-67.91797716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53501"},
        {"Hipparcos Number", "HIP 33682"},
        {"Geneva Identification System", "GEN# +1.00053501"},
        {"Smithsonian Astrophysical Observation", "SAO 249704"},
        {"Wilson Evans Batten Catalogue", "WEB 6768"},
    },
    visualMagnitude: 5.18,
    bvColour: 1.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.96074141),
        dec: Angle.Degrees(-67.91701197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 234.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101703"},
        {"Hipparcos Number", "HIP 57032"},
        {"Geneva Identification System", "GEN# +1.00101703"},
        {"Smithsonian Astrophysical Observation", "SAO 251543"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.40750206),
        dec: Angle.Degrees(-67.91437831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222204"},
        {"Hipparcos Number", "HIP 116704"},
        {"Smithsonian Astrophysical Observation", "SAO 255533"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.75476686),
        dec: Angle.Degrees(-67.91173668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95996"},
        {"Hipparcos Number", "HIP 54012"},
        {"Smithsonian Astrophysical Observation", "SAO 251237"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.73528289),
        dec: Angle.Degrees(-67.90914110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144833"},
        {"Hipparcos Number", "HIP 79422"},
        {"Geneva Identification System", "GEN# +1.00144833"},
        {"Smithsonian Astrophysical Observation", "SAO 253457"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.14020722),
        dec: Angle.Degrees(-67.90589842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97960",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97960"},
    },
    visualMagnitude: 11.63,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.62235706),
        dec: Angle.Degrees(-67.90470210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -287.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -175.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217830"},
        {"Hipparcos Number", "HIP 113964"},
        {"Smithsonian Astrophysical Observation", "SAO 255394"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.19422008),
        dec: Angle.Degrees(-67.90300016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -112.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33233",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33233"},
        {"Smithsonian Astrophysical Observation", "SAO 249678"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.72175169),
        dec: Angle.Degrees(-67.89947976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1199"},
        {"Hipparcos Number", "HIP 1278"},
        {"Smithsonian Astrophysical Observation", "SAO 248146"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.00821960),
        dec: Angle.Degrees(-67.89937847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106554"},
        {"Hipparcos Number", "HIP 59792"},
        {"Geneva Identification System", "GEN# +1.00106554"},
        {"Smithsonian Astrophysical Observation", "SAO 251815"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.90347764),
        dec: Angle.Degrees(-67.89489261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114911"},
        {"Henry Draper 2", "HD 114911A"},
        {"Hipparcos Number", "HIP 64661"},
        {"Fundamental Katalog 5th Edition", "FK5 493"},
        {"Geneva Identification System", "GEN# +1.00114911"},
        {"Smithsonian Astrophysical Observation", "SAO 252224"},
        {"Wilson Evans Batten Catalogue", "WEB 11435"},
    },
    visualMagnitude: 4.79,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.81249082),
        dec: Angle.Degrees(-67.89456330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88704"},
        {"Hipparcos Number", "HIP 49892"},
        {"Smithsonian Astrophysical Observation", "SAO 250858"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.80317980),
        dec: Angle.Degrees(-67.89236552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33579"},
        {"Hipparcos Number", "HIP 23718"},
        {"Geneva Identification System", "GEN# +1.00033579"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.48128611),
        dec: Angle.Degrees(-67.88637029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131003"},
        {"Hipparcos Number", "HIP 72966"},
        {"Smithsonian Astrophysical Observation", "SAO 252949"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.68310845),
        dec: Angle.Degrees(-67.88390359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118821"},
        {"Hipparcos Number", "HIP 66794"},
        {"Geneva Identification System", "GEN# +1.00118821"},
        {"Smithsonian Astrophysical Observation", "SAO 252411"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.35885968),
        dec: Angle.Degrees(-67.88170645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29137"},
        {"Hipparcos Number", "HIP 20998"},
        {"Cincinnati Publication", "Ci 20 297"},
        {"Geneva Identification System", "GEN# +1.00029137"},
        {"Smithsonian Astrophysical Observation", "SAO 249044"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.54537255),
        dec: Angle.Degrees(-67.87857286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 212.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 421.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134939"},
        {"Hipparcos Number", "HIP 74744"},
        {"Smithsonian Astrophysical Observation", "SAO 253077"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.13246801),
        dec: Angle.Degrees(-67.87812687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218497"},
        {"Hipparcos Number", "HIP 114367"},
        {"Geneva Identification System", "GEN# +1.00218497"},
        {"Smithsonian Astrophysical Observation", "SAO 255418"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.43638552),
        dec: Angle.Degrees(-67.87615966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4457"},
        {"Hipparcos Number", "HIP 3579"},
        {"Geneva Identification System", "GEN# +1.00004457"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.905,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.42912919),
        dec: Angle.Degrees(-67.87477429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19565"},
        {"Hipparcos Number", "HIP 14325"},
        {"Smithsonian Astrophysical Observation", "SAO 248727"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.19298909),
        dec: Angle.Degrees(-67.86955192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116865"},
        {"Hipparcos Number", "HIP 65719"},
        {"Geneva Identification System", "GEN# +1.00116865"},
        {"Smithsonian Astrophysical Observation", "SAO 252318"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.09796826),
        dec: Angle.Degrees(-67.86944631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34143"},
        {"Hipparcos Number", "HIP 24026"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.45271027),
        dec: Angle.Degrees(-67.86847909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118374"},
        {"Hipparcos Number", "HIP 66565"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.67873740),
        dec: Angle.Degrees(-67.86571960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81652",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81652"},
        {"Geneva Identification System", "GEN# -0.06703184"},
    },
    visualMagnitude: 10.75,
    bvColour: -0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.19613875),
        dec: Angle.Degrees(-67.86503906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 270119"},
        {"Hipparcos Number", "HIP 27186"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.42979101),
        dec: Angle.Degrees(-67.86445153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41802"},
        {"Hipparcos Number", "HIP 28563"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.43077603),
        dec: Angle.Degrees(-67.86423102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 269344"},
        {"Hipparcos Number", "HIP 24823"},
        {"Geneva Identification System", "GEN# +1.00269344"},
    },
    visualMagnitude: 9.77,
    bvColour: 1.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.82037291),
        dec: Angle.Degrees(-67.86358028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22772"},
        {"Hipparcos Number", "HIP 16730"},
        {"Geneva Identification System", "GEN# +1.00022772"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.81226921),
        dec: Angle.Degrees(-67.86282327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13463",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13463"},
    },
    visualMagnitude: 10.41,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.34868583),
        dec: Angle.Degrees(-67.86029682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 236.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 150.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207882"},
        {"Hipparcos Number", "HIP 108191"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.79116505),
        dec: Angle.Degrees(-67.85963555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112938"},
        {"Hipparcos Number", "HIP 63567"},
        {"Geneva Identification System", "GEN# +1.00112938"},
        {"Smithsonian Astrophysical Observation", "SAO 252128"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.39768336),
        dec: Angle.Degrees(-67.85642835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159558"},
        {"Hipparcos Number", "HIP 86510"},
        {"Fundamental Katalog 5th Edition", "FK5 3401"},
        {"Geneva Identification System", "GEN# +1.00159558"},
        {"Smithsonian Astrophysical Observation", "SAO 253990"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.18570532),
        dec: Angle.Degrees(-67.85412144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75051"},
        {"Hipparcos Number", "HIP 42820"},
        {"Smithsonian Astrophysical Observation", "SAO 250312"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.87931077),
        dec: Angle.Degrees(-67.85226772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163696"},
        {"Hipparcos Number", "HIP 88383"},
        {"Geneva Identification System", "GEN# +1.00163696"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.72561868),
        dec: Angle.Degrees(-67.85216052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104539"},
        {"Hipparcos Number", "HIP 58690"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.55695614),
        dec: Angle.Degrees(-67.85196702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105018"},
        {"Hipparcos Number", "HIP 58972"},
        {"Geneva Identification System", "GEN# +1.00105018"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.37870349),
        dec: Angle.Degrees(-67.85154422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172466"},
        {"Hipparcos Number", "HIP 92058"},
        {"Fundamental Katalog 5th Edition", "FK5 5647"},
        {"Smithsonian Astrophysical Observation", "SAO 254357"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.45001328),
        dec: Angle.Degrees(-67.85062673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121708"},
        {"Hipparcos Number", "HIP 68366"},
        {"Smithsonian Astrophysical Observation", "SAO 252541"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.91930336),
        dec: Angle.Degrees(-67.84697414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49306"},
        {"Hipparcos Number", "HIP 32106"},
        {"Geneva Identification System", "GEN# +1.00049306"},
        {"Smithsonian Astrophysical Observation", "SAO 249631"},
    },
    visualMagnitude: 6.72,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.60656973),
        dec: Angle.Degrees(-67.84319035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33117"},
        {"Hipparcos Number", "HIP 23466"},
        {"Geneva Identification System", "GEN# +1.00033117"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.936,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.67436311),
        dec: Angle.Degrees(-67.84314678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8944"},
        {"Hipparcos Number", "HIP 6703"},
        {"Smithsonian Astrophysical Observation", "SAO 248383"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.816,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.53872018),
        dec: Angle.Degrees(-67.84233961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 118.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14141"},
        {"Hipparcos Number", "HIP 10418"},
        {"Geneva Identification System", "GEN# +1.00014141"},
        {"Smithsonian Astrophysical Observation", "SAO 248518"},
        {"Wilson Evans Batten Catalogue", "WEB 2180"},
    },
    visualMagnitude: 5.57,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.56042796),
        dec: Angle.Degrees(-67.84155199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88591"},
        {"Hipparcos Number", "HIP 49835"},
        {"Smithsonian Astrophysical Observation", "SAO 250853"},
    },
    visualMagnitude: 7.10,
    bvColour: -0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.62452253),
        dec: Angle.Degrees(-67.84132973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121662"},
        {"Hipparcos Number", "HIP 68341"},
        {"Smithsonian Astrophysical Observation", "SAO 252538"},
    },
    visualMagnitude: 7.43,
    bvColour: -0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.83893231),
        dec: Angle.Degrees(-67.84062719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142157"},
        {"Hipparcos Number", "HIP 78149"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.36883036),
        dec: Angle.Degrees(-67.83858520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129777"},
        {"Hipparcos Number", "HIP 72380"},
        {"Geneva Identification System", "GEN# +1.00129777"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.99190259),
        dec: Angle.Degrees(-67.83832882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -102.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155055"},
        {"Hipparcos Number", "HIP 84336"},
        {"Smithsonian Astrophysical Observation", "SAO 253833"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.62679737),
        dec: Angle.Degrees(-67.83765444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214761"},
        {"Hipparcos Number", "HIP 112094"},
        {"Smithsonian Astrophysical Observation", "SAO 255290"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.57109813),
        dec: Angle.Degrees(-67.83346614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55"},
        {"Hipparcos Number", "HIP 436"},
        {"Cincinnati Publication", "Ci 20 5"},
        {"Geneva Identification System", "GEN# +1.00000055"},
        {"Wilson Evans Batten Catalogue", "WEB 71"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.32445343),
        dec: Angle.Degrees(-67.83122670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -117.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -560.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187978"},
        {"Hipparcos Number", "HIP 98228"},
        {"Geneva Identification System", "GEN# +1.00187978"},
        {"Smithsonian Astrophysical Observation", "SAO 254692"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.42471271),
        dec: Angle.Degrees(-67.82759857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49854"},
        {"Hipparcos Number", "HIP 32336"},
        {"Geneva Identification System", "GEN# +1.00049854"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.24657718),
        dec: Angle.Degrees(-67.82599492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112472"},
        {"Hipparcos Number", "HIP 63279"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.50835587),
        dec: Angle.Degrees(-67.82386622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98292"},
        {"Hipparcos Number", "HIP 55140"},
        {"Fundamental Katalog 5th Edition", "FK5 2903"},
        {"Geneva Identification System", "GEN# +1.00098292J"},
        {"Smithsonian Astrophysical Observation", "SAO 251341"},
    },
    visualMagnitude: 6.06,
    bvColour: 1.753,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.32925694),
        dec: Angle.Degrees(-67.82349927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60769"},
        {"Hipparcos Number", "HIP 36552"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.78227809),
        dec: Angle.Degrees(-67.82058435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74541"},
        {"Hipparcos Number", "HIP 42557"},
        {"Geneva Identification System", "GEN# +1.00074541"},
        {"Wilson Evans Batten Catalogue", "WEB 8211"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.11902943),
        dec: Angle.Degrees(-67.82032977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107668"},
        {"Hipparcos Number", "HIP 60376"},
        {"Geneva Identification System", "GEN# +1.00107668"},
        {"Smithsonian Astrophysical Observation", "SAO 251874"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.70050365),
        dec: Angle.Degrees(-67.81410485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60862",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60862"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.11655005),
        dec: Angle.Degrees(-67.81017279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84630",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84630"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.51942267),
        dec: Angle.Degrees(-67.80927013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165843"},
        {"Hipparcos Number", "HIP 89316"},
        {"Smithsonian Astrophysical Observation", "SAO 254173"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.36880831),
        dec: Angle.Degrees(-67.80855918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90986",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90986"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.38456828),
        dec: Angle.Degrees(-67.80400952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40769",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40769"},
    },
    visualMagnitude: 12.01,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.81620378),
        dec: Angle.Degrees(-67.80351096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 137.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -209.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113919"},
        {"Hipparcos Number", "HIP 64117"},
        {"Smithsonian Astrophysical Observation", "SAO 252163"},
    },
    visualMagnitude: 6.34,
    bvColour: 1.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.11599927),
        dec: Angle.Degrees(-67.79676243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67252"},
        {"Hipparcos Number", "HIP 39321"},
        {"Smithsonian Astrophysical Observation", "SAO 250089"},
    },
    visualMagnitude: 8.57,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.59293706),
        dec: Angle.Degrees(-67.79491417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105893"},
        {"Hipparcos Number", "HIP 59430"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.86131785),
        dec: Angle.Degrees(-67.78888933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14577"},
        {"Hipparcos Number", "HIP 10742"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.56043750),
        dec: Angle.Degrees(-67.78860503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98966"},
        {"Hipparcos Number", "HIP 55532"},
        {"Geneva Identification System", "GEN# +1.00098966"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.62050442),
        dec: Angle.Degrees(-67.78713660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151055"},
        {"Hipparcos Number", "HIP 82392"},
    },
    visualMagnitude: 8.25,
    bvColour: 2.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.52751798),
        dec: Angle.Degrees(-67.78279405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56560"},
        {"Hipparcos Number", "HIP 34805"},
        {"Geneva Identification System", "GEN# +1.00056560"},
        {"Smithsonian Astrophysical Observation", "SAO 249780"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.07219223),
        dec: Angle.Degrees(-67.78225260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 198.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -202.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153203"},
        {"Hipparcos Number", "HIP 83426"},
    },
    visualMagnitude: 8.80,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.77652932),
        dec: Angle.Degrees(-67.77381734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65969"},
        {"Hipparcos Number", "HIP 38809"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.13818040),
        dec: Angle.Degrees(-67.77289584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 82.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90088"},
        {"Hipparcos Number", "HIP 50740"},
    },
    visualMagnitude: 8.95,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.40750165),
        dec: Angle.Degrees(-67.77203464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156277"},
        {"Hipparcos Number", "HIP 84969"},
        {"Fundamental Katalog 5th Edition", "FK5 3374"},
        {"Geneva Identification System", "GEN# +1.00156277"},
        {"Smithsonian Astrophysical Observation", "SAO 253882"},
        {"Wilson Evans Batten Catalogue", "WEB 14351"},
    },
    visualMagnitude: 4.76,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.49806157),
        dec: Angle.Degrees(-67.77064960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222550"},
        {"Hipparcos Number", "HIP 116924"},
        {"Geneva Identification System", "GEN# +1.00222550"},
        {"Smithsonian Astrophysical Observation", "SAO 255547"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.50410582),
        dec: Angle.Degrees(-67.77057609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15415"},
        {"Hipparcos Number", "HIP 11302"},
        {"Geneva Identification System", "GEN# +1.00015415"},
        {"Smithsonian Astrophysical Observation", "SAO 248560"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.37347514),
        dec: Angle.Degrees(-67.76876221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102544"},
        {"Hipparcos Number", "HIP 57553"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.94486722),
        dec: Angle.Degrees(-67.76525213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178768"},
        {"Hipparcos Number", "HIP 94599"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.76723331),
        dec: Angle.Degrees(-67.76272586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125119"},
        {"Hipparcos Number", "HIP 70076"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.10211252),
        dec: Angle.Degrees(-67.75861671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194189"},
        {"Hipparcos Number", "HIP 101006"},
        {"Geneva Identification System", "GEN# +1.00194189"},
        {"Smithsonian Astrophysical Observation", "SAO 254796"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.17225513),
        dec: Angle.Degrees(-67.75821562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109372"},
        {"Hipparcos Number", "HIP 61404"},
        {"Geneva Identification System", "GEN# +1.00109372"},
        {"Smithsonian Astrophysical Observation", "SAO 251957"},
    },
    visualMagnitude: 6.11,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.72693180),
        dec: Angle.Degrees(-67.75688853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150408"},
        {"Hipparcos Number", "HIP 82078"},
        {"Smithsonian Astrophysical Observation", "SAO 253685"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.48730572),
        dec: Angle.Degrees(-67.75011677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190125"},
        {"Hipparcos Number", "HIP 99174"},
        {"Geneva Identification System", "GEN# +1.00190125"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.01327562),
        dec: Angle.Degrees(-67.74703185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113607"},
        {"Hipparcos Number", "HIP 63946"},
        {"Geneva Identification System", "GEN# +1.00113607"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.57650878),
        dec: Angle.Degrees(-67.74662597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14287"},
        {"Hipparcos Number", "HIP 10513"},
        {"Geneva Identification System", "GEN# +1.00014287"},
        {"Smithsonian Astrophysical Observation", "SAO 248521"},
        {"Wilson Evans Batten Catalogue", "WEB 2208"},
    },
    visualMagnitude: 5.67,
    bvColour: 1.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.86899336),
        dec: Angle.Degrees(-67.74633515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2228"},
        {"Hipparcos Number", "HIP 2013"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.38577634),
        dec: Angle.Degrees(-67.74515397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110152"},
        {"Hipparcos Number", "HIP 61882"},
        {"Smithsonian Astrophysical Observation", "SAO 251992"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.21229597),
        dec: Angle.Degrees(-67.74005807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96250"},
        {"Hipparcos Number", "HIP 54140"},
        {"Geneva Identification System", "GEN# +1.00096250"},
        {"Renson", "Renson 27730"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.13764090),
        dec: Angle.Degrees(-67.73654030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218511"},
        {"Hipparcos Number", "HIP 114361"},
        {"Geneva Identification System", "GEN# +1.00218511"},
        {"Smithsonian Astrophysical Observation", "SAO 255417"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.42266900),
        dec: Angle.Degrees(-67.73230130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -316.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -215.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100282"},
        {"Hipparcos Number", "HIP 56227"},
        {"Geneva Identification System", "GEN# +1.00100282"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.89591690),
        dec: Angle.Degrees(-67.73183615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80937"},
        {"Hipparcos Number", "HIP 45713"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.78403430),
        dec: Angle.Degrees(-67.73178401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79719"},
        {"Hipparcos Number", "HIP 45155"},
        {"Geneva Identification System", "GEN# +1.00079719"},
        {"Smithsonian Astrophysical Observation", "SAO 250481"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.98811560),
        dec: Angle.Degrees(-67.72171722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2353"},
        {"Hipparcos Number", "HIP 2111"},
        {"Geneva Identification System", "GEN# +1.00002353"},
        {"Smithsonian Astrophysical Observation", "SAO 248188"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.70292401),
        dec: Angle.Degrees(-67.72140657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 112.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86255"},
        {"Hipparcos Number", "HIP 48567"},
        {"Geneva Identification System", "GEN# +1.00086255"},
        {"Smithsonian Astrophysical Observation", "SAO 250745"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.58802954),
        dec: Angle.Degrees(-67.72065530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223163"},
        {"Hipparcos Number", "HIP 117331"},
        {"Geneva Identification System", "GEN# +1.00223163"},
        {"Smithsonian Astrophysical Observation", "SAO 255568"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.87158925),
        dec: Angle.Degrees(-67.72016291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126862"},
        {"Hipparcos Number", "HIP 71002"},
        {"Geneva Identification System", "GEN# +1.00126862"},
        {"Smithsonian Astrophysical Observation", "SAO 252767"},
    },
    visualMagnitude: 5.84,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.81827528),
        dec: Angle.Degrees(-67.71705401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31249"},
        {"Hipparcos Number", "HIP 22372"},
        {"Fundamental Katalog 5th Edition", "FK5 4441"},
        {"Geneva Identification System", "GEN# +1.00031249"},
        {"Smithsonian Astrophysical Observation", "SAO 249120"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.24104298),
        dec: Angle.Degrees(-67.71395117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2001"},
        {"Hipparcos Number", "HIP 1876"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.92264691),
        dec: Angle.Degrees(-67.71379658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4664"},
        {"Hipparcos Number", "HIP 3707"},
        {"Smithsonian Astrophysical Observation", "SAO 248253"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.89939698),
        dec: Angle.Degrees(-67.71069970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134038"},
        {"Hipparcos Number", "HIP 74347"},
        {"Geneva Identification System", "GEN# +1.00134038"},
        {"Smithsonian Astrophysical Observation", "SAO 253046"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.91166492),
        dec: Angle.Degrees(-67.70999891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39282"},
        {"Hipparcos Number", "HIP 27216"},
        {"Renson", "Renson 10540"},
        {"Smithsonian Astrophysical Observation", "SAO 249353"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.52377107),
        dec: Angle.Degrees(-67.70968110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26469"},
        {"Hipparcos Number", "HIP 19154"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.58760632),
        dec: Angle.Degrees(-67.70539531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49692"},
        {"Hipparcos Number", "HIP 32272"},
        {"Smithsonian Astrophysical Observation", "SAO 249637"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.05987492),
        dec: Angle.Degrees(-67.70262870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91407"},
        {"Hipparcos Number", "HIP 51507"},
        {"Smithsonian Astrophysical Observation", "SAO 250998"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.78104924),
        dec: Angle.Degrees(-67.70238746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11083"},
        {"Hipparcos Number", "HIP 8263"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.60930890),
        dec: Angle.Degrees(-67.69963280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198843"},
        {"Hipparcos Number", "HIP 103412"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.29059779),
        dec: Angle.Degrees(-67.69892477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14747"},
        {"Hipparcos Number", "HIP 10842"},
        {"Geneva Identification System", "GEN# +1.00014747"},
        {"Smithsonian Astrophysical Observation", "SAO 248532"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.88992295),
        dec: Angle.Degrees(-67.69771784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -310.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197792"},
        {"Hipparcos Number", "HIP 102828"},
        {"Smithsonian Astrophysical Observation", "SAO 254875"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.48280002),
        dec: Angle.Degrees(-67.69746918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160963"},
        {"Hipparcos Number", "HIP 87142"},
        {"Geneva Identification System", "GEN# +1.00160963"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.06652146),
        dec: Angle.Degrees(-67.69585524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102534"},
        {"Hipparcos Number", "HIP 57547"},
        {"Smithsonian Astrophysical Observation", "SAO 251593"},
    },
    visualMagnitude: 6.75,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.92248178),
        dec: Angle.Degrees(-67.69226753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70704"},
        {"Hipparcos Number", "HIP 40736"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.72446614),
        dec: Angle.Degrees(-67.69173290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214539"},
        {"Hipparcos Number", "HIP 111966"},
        {"Geneva Identification System", "GEN# +1.00214539"},
        {"Smithsonian Astrophysical Observation", "SAO 255281"},
    },
    visualMagnitude: 7.26,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.20013013),
        dec: Angle.Degrees(-67.68849982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151404"},
        {"Hipparcos Number", "HIP 82539"},
        {"Geneva Identification System", "GEN# +1.00151404"},
        {"Smithsonian Astrophysical Observation", "SAO 253718"},
    },
    visualMagnitude: 6.33,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.07409716),
        dec: Angle.Degrees(-67.68151371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80927"},
        {"Hipparcos Number", "HIP 45704"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.75804402),
        dec: Angle.Degrees(-67.67946802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80603"},
        {"Hipparcos Number", "HIP 45566"},
        {"Smithsonian Astrophysical Observation", "SAO 250524"},
    },
    visualMagnitude: 6.79,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.30677164),
        dec: Angle.Degrees(-67.67645336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10607"},
        {"Hipparcos Number", "HIP 7869"},
        {"Geneva Identification System", "GEN# +1.00010607"},
        {"Wilson Evans Batten Catalogue", "WEB 1679"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.30916847),
        dec: Angle.Degrees(-67.67585758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 320.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -452.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39921",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39921"},
    },
    visualMagnitude: 10.32,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.29723735),
        dec: Angle.Degrees(-67.67470905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173975"},
        {"Hipparcos Number", "HIP 92719"},
        {"Smithsonian Astrophysical Observation", "SAO 254402"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.39503012),
        dec: Angle.Degrees(-67.67238579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118475"},
        {"Hipparcos Number", "HIP 66618"},
        {"Geneva Identification System", "GEN# +1.00118475"},
        {"Smithsonian Astrophysical Observation", "SAO 252395"},
        {"Wilson Evans Batten Catalogue", "WEB 11751"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.83291243),
        dec: Angle.Degrees(-67.67035714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 251.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -190.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174583"},
        {"Hipparcos Number", "HIP 92975"},
        {"Smithsonian Astrophysical Observation", "SAO 254409"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.12608708),
        dec: Angle.Degrees(-67.67001520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103403"},
        {"Hipparcos Number", "HIP 58024"},
        {"Geneva Identification System", "GEN# +1.00103403"},
        {"Smithsonian Astrophysical Observation", "SAO 251631"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.51378672),
        dec: Angle.Degrees(-67.66952931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -242.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 65.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69173"},
        {"Hipparcos Number", "HIP 40076"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.79477570),
        dec: Angle.Degrees(-67.66783165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87073"},
        {"Hipparcos Number", "HIP 49015"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.98863459),
        dec: Angle.Degrees(-67.66665349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201831"},
        {"Hipparcos Number", "HIP 104971"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.93341640),
        dec: Angle.Degrees(-67.66493849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101102",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101102"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.41321698),
        dec: Angle.Degrees(-67.66330631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 180.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -134.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106410",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106410"},
        {"Smithsonian Astrophysical Observation", "SAO 255021"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.29258491),
        dec: Angle.Degrees(-67.66263175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85049"},
        {"Hipparcos Number", "HIP 47958"},
        {"Smithsonian Astrophysical Observation", "SAO 250691"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.59334894),
        dec: Angle.Degrees(-67.66207495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108572"},
        {"Hipparcos Number", "HIP 60907"},
        {"Smithsonian Astrophysical Observation", "SAO 251927"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.23573098),
        dec: Angle.Degrees(-67.66069863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134982"},
        {"Hipparcos Number", "HIP 74753"},
    },
    visualMagnitude: 8.99,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.15796954),
        dec: Angle.Degrees(-67.66068665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124239"},
        {"Hipparcos Number", "HIP 69643"},
        {"Smithsonian Astrophysical Observation", "SAO 252663"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.80918674),
        dec: Angle.Degrees(-67.65829262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120913"},
        {"Hipparcos Number", "HIP 67942"},
        {"Geneva Identification System", "GEN# +1.00120913"},
        {"Smithsonian Astrophysical Observation", "SAO 252511"},
    },
    visualMagnitude: 5.74,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.70473728),
        dec: Angle.Degrees(-67.65206440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105336",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105336"},
        {"Cincinnati Publication", "Ci 20 1274"},
    },
    visualMagnitude: 10.90,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.04356389),
        dec: Angle.Degrees(-67.65177667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -429.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 87.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11977"},
        {"Hipparcos Number", "HIP 8928"},
        {"Fundamental Katalog 5th Edition", "FK5 69"},
        {"Geneva Identification System", "GEN# +1.00011977"},
        {"Smithsonian Astrophysical Observation", "SAO 248460"},
        {"Wilson Evans Batten Catalogue", "WEB 1877"},
    },
    visualMagnitude: 4.68,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.73339519),
        dec: Angle.Degrees(-67.64748114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 73.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103339"},
        {"Hipparcos Number", "HIP 57995"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.43375916),
        dec: Angle.Degrees(-67.64684388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130967"},
        {"Hipparcos Number", "HIP 72942"},
        {"Geneva Identification System", "GEN# +1.00130967"},
        {"Smithsonian Astrophysical Observation", "SAO 252946"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.61947012),
        dec: Angle.Degrees(-67.64600580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83112"},
        {"Hipparcos Number", "HIP 46851"},
        {"Smithsonian Astrophysical Observation", "SAO 250618"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.21468574),
        dec: Angle.Degrees(-67.64267706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129128"},
        {"Hipparcos Number", "HIP 72051"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.06643035),
        dec: Angle.Degrees(-67.64252908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141261"},
        {"Hipparcos Number", "HIP 77755"},
        {"Geneva Identification System", "GEN# +1.00141261"},
        {"Smithsonian Astrophysical Observation", "SAO 253319"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.15013000),
        dec: Angle.Degrees(-67.63956517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137549"},
        {"Hipparcos Number", "HIP 75954"},
        {"Smithsonian Astrophysical Observation", "SAO 253189"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.69432465),
        dec: Angle.Degrees(-67.63954261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122454"},
        {"Hipparcos Number", "HIP 68773"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.14923372),
        dec: Angle.Degrees(-67.63861925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145707"},
        {"Hipparcos Number", "HIP 79795"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.26796250),
        dec: Angle.Degrees(-67.63527639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225018"},
        {"Hipparcos Number", "HIP 208"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.64992943),
        dec: Angle.Degrees(-67.63428107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107773"},
        {"Hipparcos Number", "HIP 60417"},
        {"Cincinnati Publication", "Ci 20 700"},
        {"Geneva Identification System", "GEN# +1.00107773"},
        {"Smithsonian Astrophysical Observation", "SAO 251877"},
        {"Wilson Evans Batten Catalogue", "WEB 10743"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.887,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.81266771),
        dec: Angle.Degrees(-67.63217115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -751.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 257.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215122"},
        {"Hipparcos Number", "HIP 112296"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.18862464),
        dec: Angle.Degrees(-67.63107505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102477"},
        {"Hipparcos Number", "HIP 57510"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.82071831),
        dec: Angle.Degrees(-67.62706521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1841"},
        {"Hipparcos Number", "HIP 1764"},
        {"Smithsonian Astrophysical Observation", "SAO 248172"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.58291853),
        dec: Angle.Degrees(-67.62657169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203336"},
        {"Hipparcos Number", "HIP 105742"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.26086426),
        dec: Angle.Degrees(-67.62330779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115498"},
        {"Hipparcos Number", "HIP 64986"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.79876798),
        dec: Angle.Degrees(-67.62293267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112254"},
        {"Hipparcos Number", "HIP 63177"},
        {"Geneva Identification System", "GEN# +1.00112254"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.15810618),
        dec: Angle.Degrees(-67.62135264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78346"},
        {"Hipparcos Number", "HIP 44494"},
        {"Smithsonian Astrophysical Observation", "SAO 250430"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.97433408),
        dec: Angle.Degrees(-67.62087731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101162"},
        {"Hipparcos Number", "HIP 56727"},
        {"Fundamental Katalog 5th Edition", "FK5 2930"},
        {"Geneva Identification System", "GEN# +1.00101162"},
        {"Smithsonian Astrophysical Observation", "SAO 251501"},
    },
    visualMagnitude: 5.94,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.45211345),
        dec: Angle.Degrees(-67.62035361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184308"},
        {"Hipparcos Number", "HIP 96624"},
        {"Smithsonian Astrophysical Observation", "SAO 254614"},
    },
    visualMagnitude: 9.44,
    bvColour: -0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.69063245),
        dec: Angle.Degrees(-67.61902861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127317"},
        {"Hipparcos Number", "HIP 71216"},
        {"Geneva Identification System", "GEN# +1.00127317"},
        {"Smithsonian Astrophysical Observation", "SAO 252787"},
        {"Wilson Evans Batten Catalogue", "WEB 12308"},
    },
    visualMagnitude: 6.94,
    bvColour: -0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.45720053),
        dec: Angle.Degrees(-67.61763233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17566"},
        {"Hipparcos Number", "HIP 12876"},
        {"Fundamental Katalog 5th Edition", "FK5 2191"},
        {"Geneva Identification System", "GEN# +1.00017566"},
        {"Smithsonian Astrophysical Observation", "SAO 248644"},
        {"Wilson Evans Batten Catalogue", "WEB 2617"},
    },
    visualMagnitude: 4.83,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.38555249),
        dec: Angle.Degrees(-67.61672400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21766"},
        {"Hipparcos Number", "HIP 16022"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.57861784),
        dec: Angle.Degrees(-67.61629911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61929"},
        {"Hipparcos Number", "HIP 37032"},
        {"Geneva Identification System", "GEN# +1.00061929"},
        {"Smithsonian Astrophysical Observation", "SAO 249896"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.14936525),
        dec: Angle.Degrees(-67.61317673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200086"},
        {"Hipparcos Number", "HIP 104070"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.26218853),
        dec: Angle.Degrees(-67.61299475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216462"},
        {"Hipparcos Number", "HIP 113138"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.66582462),
        dec: Angle.Degrees(-67.61202680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161568"},
        {"Hipparcos Number", "HIP 87403"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.92089986),
        dec: Angle.Degrees(-67.60732708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46920"},
        {"Hipparcos Number", "HIP 31021"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.63953435),
        dec: Angle.Degrees(-67.60272332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85193"},
        {"Hipparcos Number", "HIP 48022"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.83880413),
        dec: Angle.Degrees(-67.60229174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 96.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198163"},
        {"Hipparcos Number", "HIP 103031"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.11074620),
        dec: Angle.Degrees(-67.59924805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193366"},
        {"Hipparcos Number", "HIP 100624"},
        {"Smithsonian Astrophysical Observation", "SAO 254782"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.05998815),
        dec: Angle.Degrees(-67.59737564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206653"},
        {"Hipparcos Number", "HIP 107525"},
        {"Geneva Identification System", "GEN# +1.00206653"},
        {"Renson", "Renson 57500"},
        {"Smithsonian Astrophysical Observation", "SAO 255067"},
    },
    visualMagnitude: 7.21,
    bvColour: -0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.65786371),
        dec: Angle.Degrees(-67.59629588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85943"},
        {"Hipparcos Number", "HIP 48426"},
        {"Smithsonian Astrophysical Observation", "SAO 250735"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.08548393),
        dec: Angle.Degrees(-67.59620696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224319"},
        {"Hipparcos Number", "HIP 118062"},
        {"Geneva Identification System", "GEN# +1.00224319"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.25439029),
        dec: Angle.Degrees(-67.59448013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 154.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12335"},
        {"Hipparcos Number", "HIP 9182"},
        {"Smithsonian Astrophysical Observation", "SAO 248473"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.55339961),
        dec: Angle.Degrees(-67.58818338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158913"},
        {"Hipparcos Number", "HIP 86220"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.29299820),
        dec: Angle.Degrees(-67.58757028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143662"},
        {"Hipparcos Number", "HIP 78896"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.58828954),
        dec: Angle.Degrees(-67.58706840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45292"},
        {"Hipparcos Number", "HIP 30201"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.31044562),
        dec: Angle.Degrees(-67.58312269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47044"},
        {"Hipparcos Number", "HIP 31074"},
        {"Smithsonian Astrophysical Observation", "SAO 249577"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.81415001),
        dec: Angle.Degrees(-67.58091963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62117",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62117"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.96523599),
        dec: Angle.Degrees(-67.58074148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1533"},
        {"Hipparcos Number", "HIP 1536"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.78114188),
        dec: Angle.Degrees(-67.57844601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133871"},
        {"Hipparcos Number", "HIP 74263"},
        {"Geneva Identification System", "GEN# +1.00133871"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.807,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.65401244),
        dec: Angle.Degrees(-67.57661207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34650"},
        {"Hipparcos Number", "HIP 24366"},
        {"Smithsonian Astrophysical Observation", "SAO 249223"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.41213159),
        dec: Angle.Degrees(-67.57565810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100174"},
        {"Hipparcos Number", "HIP 56174"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.72359426),
        dec: Angle.Degrees(-67.57501768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3774"},
        {"Hipparcos Number", "HIP 3104"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.88568326),
        dec: Angle.Degrees(-67.57432533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93944"},
        {"Hipparcos Number", "HIP 52879"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.21794487),
        dec: Angle.Degrees(-67.57358081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84033"},
        {"Hipparcos Number", "HIP 47378"},
        {"Smithsonian Astrophysical Observation", "SAO 250655"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.79066896),
        dec: Angle.Degrees(-67.57249162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28633"},
        {"Hipparcos Number", "HIP 20688"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.47050749),
        dec: Angle.Degrees(-67.57216848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 270288"},
        {"Hipparcos Number", "HIP 27755"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.11814632),
        dec: Angle.Degrees(-67.57188930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117400"},
        {"Hipparcos Number", "HIP 66012"},
        {"Geneva Identification System", "GEN# +1.00117400"},
        {"Smithsonian Astrophysical Observation", "SAO 252344"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.00739632),
        dec: Angle.Degrees(-67.57139570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10271"},
        {"Hipparcos Number", "HIP 7623"},
        {"Geneva Identification System", "GEN# +1.00010271"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.54878142),
        dec: Angle.Degrees(-67.57016872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99280"},
        {"Hipparcos Number", "HIP 55684"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.14659702),
        dec: Angle.Degrees(-67.56947085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114280"},
        {"Hipparcos Number", "HIP 64329"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.78068547),
        dec: Angle.Degrees(-67.56528996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169328"},
        {"Hipparcos Number", "HIP 90629"},
        {"Smithsonian Astrophysical Observation", "SAO 254260"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.38963000),
        dec: Angle.Degrees(-67.56455349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151282"},
        {"Hipparcos Number", "HIP 82488"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.88772712),
        dec: Angle.Degrees(-67.56100024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27101"},
        {"Hipparcos Number", "HIP 19594"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.99044025),
        dec: Angle.Degrees(-67.55808458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114142"},
        {"Hipparcos Number", "HIP 64258"},
        {"Geneva Identification System", "GEN# +1.00114142"},
        {"Smithsonian Astrophysical Observation", "SAO 252174"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.55493327),
        dec: Angle.Degrees(-67.55157149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16840"},
        {"Hipparcos Number", "HIP 12312"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.63896910),
        dec: Angle.Degrees(-67.54424672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33742",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33742"},
    },
    visualMagnitude: 9.48,
    bvColour: 1.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.14578739),
        dec: Angle.Degrees(-67.54392828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217030"},
        {"Hipparcos Number", "HIP 113492"},
        {"Geneva Identification System", "GEN# +1.00217030"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.76740032),
        dec: Angle.Degrees(-67.54360972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38773",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38773"},
    },
    visualMagnitude: 11.04,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.05365812),
        dec: Angle.Degrees(-67.54349227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177325"},
        {"Hipparcos Number", "HIP 94102"},
        {"Smithsonian Astrophysical Observation", "SAO 254472"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.34144069),
        dec: Angle.Degrees(-67.54025932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109506"},
        {"Hipparcos Number", "HIP 61489"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.97542183),
        dec: Angle.Degrees(-67.53875080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107358"},
        {"Hipparcos Number", "HIP 60215"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.21330175),
        dec: Angle.Degrees(-67.53763458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115846"},
        {"Hipparcos Number", "HIP 65181"},
        {"Geneva Identification System", "GEN# +1.00115846"},
        {"Smithsonian Astrophysical Observation", "SAO 252276"},
    },
    visualMagnitude: 7.03,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.36979023),
        dec: Angle.Degrees(-67.53685624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170540"},
        {"Hipparcos Number", "HIP 91122"},
        {"Geneva Identification System", "GEN# +1.00170540"},
        {"Smithsonian Astrophysical Observation", "SAO 254291"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.81429499),
        dec: Angle.Degrees(-67.53649443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122118"},
        {"Hipparcos Number", "HIP 68582"},
        {"Smithsonian Astrophysical Observation", "SAO 252570"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.59814379),
        dec: Angle.Degrees(-67.53525494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4766"},
        {"Hipparcos Number", "HIP 3780"},
        {"Geneva Identification System", "GEN# +1.00004766"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.14450524),
        dec: Angle.Degrees(-67.53163727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 112.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74480"},
        {"Hipparcos Number", "HIP 42520"},
    },
    visualMagnitude: 8.15,
    bvColour: -0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.03988470),
        dec: Angle.Degrees(-67.53047432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89974"},
        {"Hipparcos Number", "HIP 50667"},
        {"Smithsonian Astrophysical Observation", "SAO 250928"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.20480215),
        dec: Angle.Degrees(-67.52577274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87989"},
        {"Hipparcos Number", "HIP 49472"},
        {"Smithsonian Astrophysical Observation", "SAO 250815"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.51360174),
        dec: Angle.Degrees(-67.52353765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18121"},
        {"Hipparcos Number", "HIP 13274"},
        {"Smithsonian Astrophysical Observation", "SAO 248663"},
    },
    visualMagnitude: 6.57,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.71751861),
        dec: Angle.Degrees(-67.52238590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107566"},
        {"Hipparcos Number", "HIP 60320"},
        {"Fundamental Katalog 5th Edition", "FK5 2990"},
        {"Geneva Identification System", "GEN# +1.00107566"},
        {"Renson", "Renson 31170"},
        {"Smithsonian Astrophysical Observation", "SAO 251866"},
        {"Wilson Evans Batten Catalogue", "WEB 10727"},
    },
    visualMagnitude: 5.15,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.53077773),
        dec: Angle.Degrees(-67.52209279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94494"},
        {"Hipparcos Number", "HIP 53192"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.20090852),
        dec: Angle.Degrees(-67.52144395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189309"},
        {"Hipparcos Number", "HIP 98800"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.99478835),
        dec: Angle.Degrees(-67.52139004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91570",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91570"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.09275024),
        dec: Angle.Degrees(-67.52128829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89975"},
        {"Hipparcos Number", "HIP 50670"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.20797797),
        dec: Angle.Degrees(-67.52063060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152443"},
        {"Hipparcos Number", "HIP 83066"},
        {"Smithsonian Astrophysical Observation", "SAO 253751"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.59965223),
        dec: Angle.Degrees(-67.52060941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20171"},
        {"Hipparcos Number", "HIP 14745"},
        {"Smithsonian Astrophysical Observation", "SAO 248752"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.60504767),
        dec: Angle.Degrees(-67.50615131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121810"},
        {"Hipparcos Number", "HIP 68412"},
        {"Smithsonian Astrophysical Observation", "SAO 252547"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.07219670),
        dec: Angle.Degrees(-67.50569407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79866"},
        {"Hipparcos Number", "HIP 45222"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.23603406),
        dec: Angle.Degrees(-67.50270672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72588",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 8.52,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)50, 32.5200),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)30, 03.600)
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
    primaryId: "HIP 72583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130233"},
        {"Hipparcos Number", "HIP 72583"},
        {"Geneva Identification System", "GEN# +1.00130233"},
        {"Smithsonian Astrophysical Observation", "SAO 252908"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.62625473),
        dec: Angle.Degrees(-67.49761711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5687"},
        {"Hipparcos Number", "HIP 4460"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.29823897),
        dec: Angle.Degrees(-67.49629775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161296"},
        {"Hipparcos Number", "HIP 87292"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.54039644),
        dec: Angle.Degrees(-67.49173409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -298.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70575",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70575"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.53620955),
        dec: Angle.Degrees(-67.49037568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212728"},
        {"Hipparcos Number", "HIP 110935"},
        {"Fundamental Katalog 5th Edition", "FK5 1587"},
        {"Geneva Identification System", "GEN# +1.00212728"},
        {"Smithsonian Astrophysical Observation", "SAO 255227"},
    },
    visualMagnitude: 5.56,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.15600483),
        dec: Angle.Degrees(-67.48888731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 151.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75865",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75865"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)29, 48.3100),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)29, 16.100)
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
    primaryId: "HIP 70572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126026"},
        {"Hipparcos Number", "HIP 70572"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.53085515),
        dec: Angle.Degrees(-67.48761658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9265"},
        {"Hipparcos Number", "HIP 6918"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.27130029),
        dec: Angle.Degrees(-67.48578624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149840"},
        {"Hipparcos Number", "HIP 81779"},
        {"Fundamental Katalog 5th Edition", "FK5 5477"},
        {"Smithsonian Astrophysical Observation", "SAO 253657"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.55084536),
        dec: Angle.Degrees(-67.48531615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137384"},
        {"Hipparcos Number", "HIP 75873"},
        {"Geneva Identification System", "GEN# +1.00137384"},
        {"Smithsonian Astrophysical Observation", "SAO 253183"},
    },
    visualMagnitude: 7.36,
    bvColour: -0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.46477122),
        dec: Angle.Degrees(-67.48500234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138521"},
        {"Hipparcos Number", "HIP 76454"},
    },
    visualMagnitude: 8.06,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.21948797),
        dec: Angle.Degrees(-67.48467127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134897"},
        {"Henry Draper 2", "HD 134898"},
        {"Hipparcos Number", "HIP 74724"},
        {"Geneva Identification System", "GEN# +1.00134898"},
        {"Geneva Identification System 2", "GEN# +1.00134897"},
        {"Renson", "Renson 38280"},
        {"Renson 2", "Renson 38290"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.06490612),
        dec: Angle.Degrees(-67.48461355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147816"},
        {"Hipparcos Number", "HIP 80726"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.22082910),
        dec: Angle.Degrees(-67.48345568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135737"},
        {"Hipparcos Number", "HIP 75091"},
        {"Geneva Identification System", "GEN# +1.00135737J"},
        {"Smithsonian Astrophysical Observation", "SAO 253115"},
        {"Wilson Evans Batten Catalogue", "WEB 12804"},
    },
    visualMagnitude: 6.27,
    bvColour: -0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.16899793),
        dec: Angle.Degrees(-67.48150132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96902"},
        {"Hipparcos Number", "HIP 54421"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.04406038),
        dec: Angle.Degrees(-67.47865998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87460"},
        {"Hipparcos Number", "HIP 49192"},
        {"Geneva Identification System", "GEN# +1.00087460"},
        {"Renson", "Renson 25090"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.59855977),
        dec: Angle.Degrees(-67.47222582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219644"},
        {"Hipparcos Number", "HIP 115062"},
        {"Fundamental Katalog 5th Edition", "FK5 3864"},
        {"Geneva Identification System", "GEN# +1.00219644"},
        {"Smithsonian Astrophysical Observation", "SAO 255455"},
    },
    visualMagnitude: 6.15,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.58329624),
        dec: Angle.Degrees(-67.47122023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 269697"},
        {"Hipparcos Number", "HIP 25892"},
        {"Geneva Identification System", "GEN# +1.00269697"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.91008449),
        dec: Angle.Degrees(-67.46988055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119050"},
        {"Hipparcos Number", "HIP 66939"},
        {"Smithsonian Astrophysical Observation", "SAO 252424"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.78158917),
        dec: Angle.Degrees(-67.46753211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114356"},
        {"Hipparcos Number", "HIP 64372"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.90458204),
        dec: Angle.Degrees(-67.46610746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43376"},
        {"Hipparcos Number", "HIP 29290"},
        {"Smithsonian Astrophysical Observation", "SAO 249466"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.62729083),
        dec: Angle.Degrees(-67.46461207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191308"},
        {"Hipparcos Number", "HIP 99692"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.45426580),
        dec: Angle.Degrees(-67.45842787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103443"},
        {"Hipparcos Number", "HIP 58062"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.62171592),
        dec: Angle.Degrees(-67.45651220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65427"},
        {"Hipparcos Number", "HIP 38574"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.47633514),
        dec: Angle.Degrees(-67.45518851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191993"},
        {"Hipparcos Number", "HIP 99994"},
        {"Geneva Identification System", "GEN# +1.00191993"},
        {"Smithsonian Astrophysical Observation", "SAO 254763"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.28960098),
        dec: Angle.Degrees(-67.45511105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105615"},
        {"Hipparcos Number", "HIP 59281"},
        {"Geneva Identification System", "GEN# +1.00105615"},
        {"Smithsonian Astrophysical Observation", "SAO 251768"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.40914621),
        dec: Angle.Degrees(-67.45414122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178563"},
        {"Hipparcos Number", "HIP 94515"},
        {"Smithsonian Astrophysical Observation", "SAO 254497"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.54735007),
        dec: Angle.Degrees(-67.45389442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148868"},
        {"Hipparcos Number", "HIP 81273"},
        {"Geneva Identification System", "GEN# +1.00148868"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.98975812),
        dec: Angle.Degrees(-67.45221996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62282"},
        {"Hipparcos Number", "HIP 37164"},
        {"Geneva Identification System", "GEN# +1.00062282"},
        {"Smithsonian Astrophysical Observation", "SAO 249910"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.55909421),
        dec: Angle.Degrees(-67.44780200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5496",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5496"},
        {"Geneva Identification System", "GEN# -0.06800041"},
    },
    visualMagnitude: 9.80,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.59293817),
        dec: Angle.Degrees(-67.44634604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 389.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 571.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 268719"},
        {"Hipparcos Number", "HIP 22885"},
        {"Geneva Identification System", "GEN# +1.00268719"},
    },
    visualMagnitude: 11.20,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.84000634),
        dec: Angle.Degrees(-67.43645975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119874"},
        {"Hipparcos Number", "HIP 67341"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.789,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.03491953),
        dec: Angle.Degrees(-67.43575324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150026"},
        {"Hipparcos Number", "HIP 81873"},
        {"Geneva Identification System", "GEN# +1.00150026"},
        {"Smithsonian Astrophysical Observation", "SAO 253673"},
        {"Wilson Evans Batten Catalogue", "WEB 13830"},
    },
    visualMagnitude: 6.02,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.84213946),
        dec: Angle.Degrees(-67.43231072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63832"},
        {"Hipparcos Number", "HIP 37904"},
        {"Smithsonian Astrophysical Observation", "SAO 249959"},
    },
    visualMagnitude: 7.75,
    bvColour: -0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.51287017),
        dec: Angle.Degrees(-67.43198856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80980"},
        {"Hipparcos Number", "HIP 45738"},
        {"Smithsonian Astrophysical Observation", "SAO 250537"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.87161306),
        dec: Angle.Degrees(-67.43122087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7858"},
        {"Hipparcos Number", "HIP 5943"},
        {"Fundamental Katalog 5th Edition", "FK5 2086"},
        {"Geneva Identification System", "GEN# +1.00007858"},
        {"Smithsonian Astrophysical Observation", "SAO 248347"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.12042232),
        dec: Angle.Degrees(-67.43109197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 130.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127574"},
        {"Hipparcos Number", "HIP 71343"},
        {"Smithsonian Astrophysical Observation", "SAO 252802"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.84867179),
        dec: Angle.Degrees(-67.43051499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -142.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25047"},
        {"Hipparcos Number", "HIP 18249"},
        {"Smithsonian Astrophysical Observation", "SAO 248904"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.54221551),
        dec: Angle.Degrees(-67.42387021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42629"},
        {"Hipparcos Number", "HIP 28931"},
        {"Smithsonian Astrophysical Observation", "SAO 249450"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.59806800),
        dec: Angle.Degrees(-67.42116471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195684"},
        {"Hipparcos Number", "HIP 101705"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.22683637),
        dec: Angle.Degrees(-67.41938284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22527"},
        {"Hipparcos Number", "HIP 16540"},
        {"Geneva Identification System", "GEN# +1.00022527"},
        {"Smithsonian Astrophysical Observation", "SAO 248836"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.24878887),
        dec: Angle.Degrees(-67.41930700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117359"},
        {"Hipparcos Number", "HIP 65986"},
        {"Geneva Identification System", "GEN# +1.00117359"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.93567392),
        dec: Angle.Degrees(-67.41698012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 122.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8889"},
        {"Hipparcos Number", "HIP 6677"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.41633480),
        dec: Angle.Degrees(-67.41562115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75071"},
        {"Hipparcos Number", "HIP 42836"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.92142510),
        dec: Angle.Degrees(-67.41495624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145785"},
        {"Hipparcos Number", "HIP 79817"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.35706944),
        dec: Angle.Degrees(-67.41368112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126152"},
        {"Hipparcos Number", "HIP 70624"},
        {"Geneva Identification System", "GEN# +1.00126152"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.70339954),
        dec: Angle.Degrees(-67.41298791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98053"},
        {"Hipparcos Number", "HIP 54980"},
    },
    visualMagnitude: 9.31,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.86896397),
        dec: Angle.Degrees(-67.40994586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -166.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3121"},
        {"Hipparcos Number", "HIP 2662"},
        {"Smithsonian Astrophysical Observation", "SAO 248213"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.43242386),
        dec: Angle.Degrees(-67.40894157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30449"},
        {"Hipparcos Number", "HIP 21916"},
        {"Smithsonian Astrophysical Observation", "SAO 249089"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.69925559),
        dec: Angle.Degrees(-67.40679591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192219"},
        {"Hipparcos Number", "HIP 100078"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.55516596),
        dec: Angle.Degrees(-67.40601524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78169"},
        {"Hipparcos Number", "HIP 44420"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.75186501),
        dec: Angle.Degrees(-67.40516714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 269594"},
        {"Hipparcos Number", "HIP 25615"},
        {"Geneva Identification System", "GEN# +1.00269594"},
    },
    visualMagnitude: 10.59,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.08471727),
        dec: Angle.Degrees(-67.40508900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129127"},
        {"Hipparcos Number", "HIP 72046"},
        {"Smithsonian Astrophysical Observation", "SAO 252863"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.05097000),
        dec: Angle.Degrees(-67.40382654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
