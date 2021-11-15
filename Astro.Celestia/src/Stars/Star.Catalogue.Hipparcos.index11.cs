using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_11() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3563"},
        {"Hipparcos Number", "HIP 2983"},
        {"Smithsonian Astrophysical Observation", "SAO 232119"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.48880849),
        dec: Angle.Degrees(-58.06188258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192134"},
        {"Hipparcos Number", "HIP 99910"},
        {"Smithsonian Astrophysical Observation", "SAO 246505"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.07133606),
        dec: Angle.Degrees(-58.06067720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88661"},
        {"Hipparcos Number", "HIP 49934"},
        {"Celescope Catalog", "CEL 3460"},
        {"Fundamental Katalog 5th Edition", "FK5 2819"},
        {"Geneva Identification System", "GEN# +1.00088661"},
        {"Smithsonian Astrophysical Observation", "SAO 237776"},
    },
    visualMagnitude: 5.70,
    bvColour: -0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.94363300),
        dec: Angle.Degrees(-58.06055982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91003"},
        {"Hipparcos Number", "HIP 51315"},
        {"Smithsonian Astrophysical Observation", "SAO 238104"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.22706571),
        dec: Angle.Degrees(-58.05550186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44627"},
        {"Hipparcos Number", "HIP 30034"},
        {"Geneva Identification System", "GEN# +1.00044627"},
        {"Smithsonian Astrophysical Observation", "SAO 234448"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.861,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.80374117),
        dec: Angle.Degrees(-58.05442142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111478"},
        {"Hipparcos Number", "HIP 62658"},
        {"Geneva Identification System", "GEN# +1.00111478"},
        {"Smithsonian Astrophysical Observation", "SAO 240300"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.58266700),
        dec: Angle.Degrees(-58.05400948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94898"},
        {"Hipparcos Number", "HIP 53470"},
        {"Geneva Identification System", "GEN# +1.00094898"},
        {"Smithsonian Astrophysical Observation", "SAO 238611"},
        {"Wilson Evans Batten Catalogue", "WEB 9706"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.06769976),
        dec: Angle.Degrees(-58.05304096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103842"},
        {"Hipparcos Number", "HIP 58294"},
        {"Smithsonian Astrophysical Observation", "SAO 239522"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.31908681),
        dec: Angle.Degrees(-58.05279079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57767"},
        {"Hipparcos Number", "HIP 35467"},
        {"Renson", "Renson 15770"},
        {"Smithsonian Astrophysical Observation", "SAO 235101"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.82541810),
        dec: Angle.Degrees(-58.05236020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4521"},
        {"Hipparcos Number", "HIP 3634"},
        {"Smithsonian Astrophysical Observation", "SAO 232180"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.64696209),
        dec: Angle.Degrees(-58.04853462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142876"},
        {"Hipparcos Number", "HIP 78361"},
        {"Smithsonian Astrophysical Observation", "SAO 243215"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.98398306),
        dec: Angle.Degrees(-58.04796441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88605"},
        {"Henry Draper 2", "HD 88606"},
        {"Hipparcos Number", "HIP 49907"},
        {"Geneva Identification System", "GEN# +1.00088605"},
        {"Geneva Identification System 2", "GEN# +1.00088606"},
        {"Smithsonian Astrophysical Observation", "SAO 237770"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.826,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.84593360),
        dec: Angle.Degrees(-58.04481270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218598"},
        {"Hipparcos Number", "HIP 114391"},
        {"Smithsonian Astrophysical Observation", "SAO 247763"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.51282440),
        dec: Angle.Degrees(-58.04212056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88292"},
        {"Hipparcos Number", "HIP 49723"},
        {"Celescope Catalog", "CEL 3448"},
        {"Geneva Identification System", "GEN# +1.00088292"},
        {"Smithsonian Astrophysical Observation", "SAO 237742"},
    },
    visualMagnitude: 7.50,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.27897566),
        dec: Angle.Degrees(-58.04048668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166681"},
        {"Hipparcos Number", "HIP 89447"},
        {"Geneva Identification System", "GEN# +1.00166681"},
        {"Smithsonian Astrophysical Observation", "SAO 245340"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.82003651),
        dec: Angle.Degrees(-58.03946523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145449"},
        {"Hipparcos Number", "HIP 79564"},
        {"Smithsonian Astrophysical Observation", "SAO 243468"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.52268271),
        dec: Angle.Degrees(-58.03909706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84600"},
        {"Hipparcos Number", "HIP 47763"},
        {"Smithsonian Astrophysical Observation", "SAO 237285"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.06709690),
        dec: Angle.Degrees(-58.03731487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102340"},
        {"Hipparcos Number", "HIP 57432"},
        {"Smithsonian Astrophysical Observation", "SAO 239366"},
    },
    visualMagnitude: 7.66,
    bvColour: -0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.61376037),
        dec: Angle.Degrees(-58.03108777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7645"},
        {"Hipparcos Number", "HIP 5868"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.81571519),
        dec: Angle.Degrees(-58.03100907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154813"},
        {"Hipparcos Number", "HIP 84063"},
        {"Geneva Identification System", "GEN# +1.00154813"},
        {"Smithsonian Astrophysical Observation", "SAO 244489"},
    },
    visualMagnitude: 6.77,
    bvColour: 1.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.78908898),
        dec: Angle.Degrees(-58.02548364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83432"},
        {"Hipparcos Number", "HIP 47128"},
        {"Smithsonian Astrophysical Observation", "SAO 237139"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.04817444),
        dec: Angle.Degrees(-58.02503743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27100"},
        {"Hipparcos Number", "HIP 19726"},
        {"Geneva Identification System", "GEN# +1.00027100"},
        {"Smithsonian Astrophysical Observation", "SAO 233441"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.41564836),
        dec: Angle.Degrees(-58.02203140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30177"},
        {"Hipparcos Number", "HIP 21850"},
        {"Geneva Identification System", "GEN# +1.00030177"},
        {"Smithsonian Astrophysical Observation", "SAO 233633"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.773,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.47625120),
        dec: Angle.Degrees(-58.02072762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23150"},
        {"Hipparcos Number", "HIP 17117"},
        {"Fundamental Katalog 5th Edition", "FK5 4332"},
        {"Smithsonian Astrophysical Observation", "SAO 233217"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.98920182),
        dec: Angle.Degrees(-58.01878639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210769"},
        {"Hipparcos Number", "HIP 109792"},
        {"Smithsonian Astrophysical Observation", "SAO 247369"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.58262113),
        dec: Angle.Degrees(-58.01871235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 130.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224471"},
        {"Hipparcos Number", "HIP 118173"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.57078227),
        dec: Angle.Degrees(-58.01808693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13667"},
        {"Hipparcos Number", "HIP 10210"},
        {"Smithsonian Astrophysical Observation", "SAO 232666"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.83247356),
        dec: Angle.Degrees(-58.01742107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34698",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34698"},
    },
    visualMagnitude: 10.20,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.80630572),
        dec: Angle.Degrees(-58.01675571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -308.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 165.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207989"},
        {"Hipparcos Number", "HIP 108177"},
        {"Smithsonian Astrophysical Observation", "SAO 247224"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.75366994),
        dec: Angle.Degrees(-58.01575831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31609",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31609"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.875,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.23776559),
        dec: Angle.Degrees(-58.01476853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -203.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2089"},
        {"Hipparcos Number", "HIP 1959"},
        {"Smithsonian Astrophysical Observation", "SAO 232030"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.19297488),
        dec: Angle.Degrees(-58.01425944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212709"},
        {"Hipparcos Number", "HIP 110866"},
        {"Smithsonian Astrophysical Observation", "SAO 247453"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.92429368),
        dec: Angle.Degrees(-58.01254604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57222"},
        {"Hipparcos Number", "HIP 35236"},
        {"Smithsonian Astrophysical Observation", "SAO 235072"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.22656138),
        dec: Angle.Degrees(-58.01105237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156768"},
        {"Hipparcos Number", "HIP 85049"},
        {"Geneva Identification System", "GEN# +1.00156768J"},
        {"Smithsonian Astrophysical Observation", "SAO 244678"},
    },
    visualMagnitude: 5.86,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.73011706),
        dec: Angle.Degrees(-58.01028930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10720"},
        {"Hipparcos Number", "HIP 8035"},
        {"Geneva Identification System", "GEN# +1.00010720A"},
        {"Smithsonian Astrophysical Observation", "SAO 232507"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.874,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.79679313),
        dec: Angle.Degrees(-58.00966878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -149.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -187.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73389"},
        {"Hipparcos Number", "HIP 42134"},
        {"Geneva Identification System", "GEN# +1.00073389"},
        {"Smithsonian Astrophysical Observation", "SAO 236106"},
        {"Wilson Evans Batten Catalogue", "WEB 8096"},
    },
    visualMagnitude: 4.84,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.83186765),
        dec: Angle.Degrees(-58.00929470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101930"},
        {"Hipparcos Number", "HIP 57172"},
        {"Geneva Identification System", "GEN# +1.00101930"},
        {"Smithsonian Astrophysical Observation", "SAO 239322"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.87539557),
        dec: Angle.Degrees(-58.00773148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 347.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190806"},
        {"Hipparcos Number", "HIP 99341"},
        {"Smithsonian Astrophysical Observation", "SAO 246464"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.44604611),
        dec: Angle.Degrees(-58.00696260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179140"},
        {"Hipparcos Number", "HIP 94570"},
        {"Geneva Identification System", "GEN# +1.00179140J"},
        {"Smithsonian Astrophysical Observation", "SAO 245983"},
        {"Wilson Evans Batten Catalogue", "WEB 16481"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.69776444),
        dec: Angle.Degrees(-58.00670835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -248.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24271"},
        {"Hipparcos Number", "HIP 17814"},
        {"Smithsonian Astrophysical Observation", "SAO 233286"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.18115642),
        dec: Angle.Degrees(-58.00486451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154708"},
        {"Hipparcos Number", "HIP 84017"},
        {"Geneva Identification System", "GEN# +1.00154708"},
        {"Renson", "Renson 43700"},
        {"Smithsonian Astrophysical Observation", "SAO 244478"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.61891477),
        dec: Angle.Degrees(-58.00475286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101723"},
        {"Hipparcos Number", "HIP 57076"},
        {"Geneva Identification System", "GEN# +1.00101723"},
        {"Smithsonian Astrophysical Observation", "SAO 239303"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.765,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.50524686),
        dec: Angle.Degrees(-58.00269104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45984"},
        {"Hipparcos Number", "HIP 30703"},
        {"Geneva Identification System", "GEN# +1.00045984"},
        {"Smithsonian Astrophysical Observation", "SAO 234519"},
        {"Wilson Evans Batten Catalogue", "WEB 6124"},
    },
    visualMagnitude: 5.82,
    bvColour: 1.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.76723213),
        dec: Angle.Degrees(-58.00210529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52854"},
        {"Hipparcos Number", "HIP 33639"},
        {"Smithsonian Astrophysical Observation", "SAO 234843"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.82986757),
        dec: Angle.Degrees(-58.00206655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212661"},
        {"Hipparcos Number", "HIP 110842"},
        {"Renson", "Renson 59000"},
        {"Smithsonian Astrophysical Observation", "SAO 247451"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.83837821),
        dec: Angle.Degrees(-58.00064067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160847"},
        {"Hipparcos Number", "HIP 86920"},
        {"Smithsonian Astrophysical Observation", "SAO 244998"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.40777359),
        dec: Angle.Degrees(-57.99950936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23398"},
        {"Hipparcos Number", "HIP 17269"},
        {"Geneva Identification System", "GEN# +1.00023398"},
        {"Smithsonian Astrophysical Observation", "SAO 233229"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.788,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.47704347),
        dec: Angle.Degrees(-57.99892262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 154.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211957"},
        {"Hipparcos Number", "HIP 110450"},
        {"Geneva Identification System", "GEN# +1.00211957"},
        {"Smithsonian Astrophysical Observation", "SAO 247425"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.57798811),
        dec: Angle.Degrees(-57.99885313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206805"},
        {"Hipparcos Number", "HIP 107523"},
        {"Geneva Identification System", "GEN# +1.00206805"},
        {"Smithsonian Astrophysical Observation", "SAO 247171"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.64888075),
        dec: Angle.Degrees(-57.99672994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170690"},
        {"Hipparcos Number", "HIP 91036"},
        {"Smithsonian Astrophysical Observation", "SAO 245552"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.56505424),
        dec: Angle.Degrees(-57.99367944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60435"},
        {"Hipparcos Number", "HIP 36537"},
        {"Geneva Identification System", "GEN# +1.00060435"},
        {"Renson", "Renson 16520"},
        {"Smithsonian Astrophysical Observation", "SAO 235263"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.73750637),
        dec: Angle.Degrees(-57.99123843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8744",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8744"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.12912501),
        dec: Angle.Degrees(-57.99008063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 230.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162296"},
        {"Hipparcos Number", "HIP 87608"},
        {"Smithsonian Astrophysical Observation", "SAO 245095"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.45264478),
        dec: Angle.Degrees(-57.98869986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42193"},
        {"Hipparcos Number", "HIP 28873"},
        {"Smithsonian Astrophysical Observation", "SAO 234307"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.43837940),
        dec: Angle.Degrees(-57.98837994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120401"},
        {"Hipparcos Number", "HIP 67563"},
        {"Geneva Identification System", "GEN# +1.00120401"},
        {"Smithsonian Astrophysical Observation", "SAO 241217"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.66892629),
        dec: Angle.Degrees(-57.98809413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109843"},
        {"Hipparcos Number", "HIP 61659"},
        {"Geneva Identification System", "GEN# +1.00109843"},
        {"Smithsonian Astrophysical Observation", "SAO 240107"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.60098405),
        dec: Angle.Degrees(-57.98789720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87920"},
        {"Hipparcos Number", "HIP 49505"},
        {"Smithsonian Astrophysical Observation", "SAO 237697"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.61839825),
        dec: Angle.Degrees(-57.98401222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84121"},
        {"Hipparcos Number", "HIP 47479"},
        {"Geneva Identification System", "GEN# +1.00084121J"},
        {"Smithsonian Astrophysical Observation", "SAO 237221"},
        {"Wilson Evans Batten Catalogue", "WEB 8908"},
    },
    visualMagnitude: 5.30,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.17751102),
        dec: Angle.Degrees(-57.98357162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184585"},
        {"Hipparcos Number", "HIP 96607"},
        {"Fundamental Katalog 5th Edition", "FK5 3566"},
        {"Geneva Identification System", "GEN# +1.00184585"},
        {"Smithsonian Astrophysical Observation", "SAO 246188"},
    },
    visualMagnitude: 6.19,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.60800087),
        dec: Angle.Degrees(-57.98318819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180473"},
        {"Hipparcos Number", "HIP 95013"},
        {"Renson", "Renson 50090"},
        {"Smithsonian Astrophysical Observation", "SAO 246029"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.99675545),
        dec: Angle.Degrees(-57.97978434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20855"},
        {"Hipparcos Number", "HIP 15434"},
        {"Geneva Identification System", "GEN# +1.00020855"},
        {"Smithsonian Astrophysical Observation", "SAO 233071"},
        {"Wilson Evans Batten Catalogue", "WEB 2968"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.72731103),
        dec: Angle.Degrees(-57.97920804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 116.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175675"},
        {"Hipparcos Number", "HIP 93262"},
        {"Smithsonian Astrophysical Observation", "SAO 245849"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.96637067),
        dec: Angle.Degrees(-57.97774722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8394"},
        {"Hipparcos Number", "HIP 6375"},
        {"Cincinnati Publication", "Ci 20 100"},
        {"Geneva Identification System", "GEN# +1.00008394"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.824,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.48747606),
        dec: Angle.Degrees(-57.97770925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 261.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 289.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70839"},
        {"Hipparcos Number", "HIP 40932"},
        {"Celescope Catalog", "CEL 2423"},
        {"Geneva Identification System", "GEN# +1.00070839"},
        {"Smithsonian Astrophysical Observation", "SAO 235917"},
        {"Wilson Evans Batten Catalogue", "WEB 7935"},
    },
    visualMagnitude: 5.96,
    bvColour: -0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.30042487),
        dec: Angle.Degrees(-57.97323049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93898"},
        {"Hipparcos Number", "HIP 52903"},
        {"Celescope Catalog", "CEL 3725"},
        {"Geneva Identification System", "GEN# +1.00093898"},
        {"Smithsonian Astrophysical Observation", "SAO 238510"},
    },
    visualMagnitude: 8.03,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.29746647),
        dec: Angle.Degrees(-57.96953775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79421"},
        {"Hipparcos Number", "HIP 45121"},
        {"Celescope Catalog", "CEL 3216"},
        {"Geneva Identification System", "GEN# +1.00079421J"},
        {"Smithsonian Astrophysical Observation", "SAO 236707"},
        {"Wilson Evans Batten Catalogue", "WEB 8608"},
    },
    visualMagnitude: 6.59,
    bvColour: -0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.88634845),
        dec: Angle.Degrees(-57.96842286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3698"},
        {"Hipparcos Number", "HIP 3084"},
        {"Geneva Identification System", "GEN# +1.00003698"},
        {"Smithsonian Astrophysical Observation", "SAO 232134"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.79683421),
        dec: Angle.Degrees(-57.96778762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32209"},
        {"Hipparcos Number", "HIP 23079"},
        {"Smithsonian Astrophysical Observation", "SAO 233766"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.49234888),
        dec: Angle.Degrees(-57.96740929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160358"},
        {"Hipparcos Number", "HIP 86704"},
        {"Smithsonian Astrophysical Observation", "SAO 244959"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.74044936),
        dec: Angle.Degrees(-57.96671954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80559"},
        {"Hipparcos Number", "HIP 45641"},
        {"Smithsonian Astrophysical Observation", "SAO 236829"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.54594693),
        dec: Angle.Degrees(-57.96636149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82988"},
        {"Hipparcos Number", "HIP 46889"},
        {"Celescope Catalog", "CEL 3326"},
        {"Smithsonian Astrophysical Observation", "SAO 237097"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.32233375),
        dec: Angle.Degrees(-57.96344770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222639"},
        {"Hipparcos Number", "HIP 116966"},
        {"Smithsonian Astrophysical Observation", "SAO 247992"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.64985722),
        dec: Angle.Degrees(-57.96166899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176522"},
        {"Hipparcos Number", "HIP 93629"},
        {"Geneva Identification System", "GEN# +1.00176522"},
        {"Smithsonian Astrophysical Observation", "SAO 245896"},
    },
    visualMagnitude: 6.30,
    bvColour: 0.857,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.00416655),
        dec: Angle.Degrees(-57.95997203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194627"},
        {"Hipparcos Number", "HIP 101091"},
        {"Cincinnati Publication", "Ci 20 1208"},
        {"Smithsonian Astrophysical Observation", "SAO 246606"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.38435815),
        dec: Angle.Degrees(-57.95754648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 286.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173187"},
        {"Hipparcos Number", "HIP 92201"},
        {"Smithsonian Astrophysical Observation", "SAO 245703"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.86920041),
        dec: Angle.Degrees(-57.95641767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154858"},
        {"Hipparcos Number", "HIP 84079"},
        {"Geneva Identification System", "GEN# +1.00154858"},
        {"Smithsonian Astrophysical Observation", "SAO 244493"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.84281131),
        dec: Angle.Degrees(-57.95559357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96088"},
        {"Hipparcos Number", "HIP 54082"},
        {"Celescope Catalog", "CEL 3790"},
        {"Geneva Identification System", "GEN# +1.00096088"},
        {"Smithsonian Astrophysical Observation", "SAO 238730"},
        {"Wilson Evans Batten Catalogue", "WEB 9780"},
    },
    visualMagnitude: 6.16,
    bvColour: -0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.00103542),
        dec: Angle.Degrees(-57.95533279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86269"},
        {"Hipparcos Number", "HIP 48665"},
        {"Geneva Identification System", "GEN# +1.00086269"},
    },
    visualMagnitude: 9.53,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)55, 30.1100),
        dec: Angle.DegreesMinutesSeconds((int)-57, (int)57, 14.400)
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
    primaryId: "HIP 50916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90289"},
        {"Hipparcos Number", "HIP 50916"},
        {"Geneva Identification System", "GEN# +1.00090289"},
        {"Smithsonian Astrophysical Observation", "SAO 238021"},
    },
    visualMagnitude: 6.34,
    bvColour: 1.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.96106527),
        dec: Angle.Degrees(-57.95390426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110971"},
        {"Hipparcos Number", "HIP 62333"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.60939187),
        dec: Angle.Degrees(-57.95048088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -206.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203727"},
        {"Hipparcos Number", "HIP 105838"},
        {"Smithsonian Astrophysical Observation", "SAO 247025"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.55502320),
        dec: Angle.Degrees(-57.94993421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37731",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37731"},
        {"Smithsonian Astrophysical Observation", "SAO 235474"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.07954439),
        dec: Angle.Degrees(-57.94606092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106308"},
        {"Hipparcos Number", "HIP 59649"},
        {"Celescope Catalog", "CEL 4070"},
        {"Geneva Identification System", "GEN# +1.00106308"},
        {"Smithsonian Astrophysical Observation", "SAO 239770"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.48880222),
        dec: Angle.Degrees(-57.94427856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4402"},
        {"Hipparcos Number", "HIP 3575"},
        {"Smithsonian Astrophysical Observation", "SAO 232174"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.42320122),
        dec: Angle.Degrees(-57.93921297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182859"},
        {"Hipparcos Number", "HIP 95877"},
        {"Smithsonian Astrophysical Observation", "SAO 246123"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.48874273),
        dec: Angle.Degrees(-57.93888043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3023",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3023"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.62643939),
        dec: Angle.Degrees(-57.93669175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 123.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94574",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94574"},
        {"Smithsonian Astrophysical Observation", "SAO 245984"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.70775289),
        dec: Angle.Degrees(-57.93573071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92693"},
        {"Henry Draper 2", "HD 92692"},
        {"Hipparcos Number", "HIP 52274"},
        {"Geneva Identification System", "GEN# +1.00092692"},
        {"Geneva Identification System 2", "GEN# +1.00092693"},
        {"Smithsonian Astrophysical Observation", "SAO 238341"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.22108366),
        dec: Angle.Degrees(-57.93560109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124924"},
        {"Hipparcos Number", "HIP 69898"},
        {"Geneva Identification System", "GEN# +1.00124924"},
        {"Smithsonian Astrophysical Observation", "SAO 241608"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.58539057),
        dec: Angle.Degrees(-57.93489732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174041"},
        {"Hipparcos Number", "HIP 92583"},
        {"Smithsonian Astrophysical Observation", "SAO 245756"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.98575487),
        dec: Angle.Degrees(-57.93468064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144480"},
        {"Hipparcos Number", "HIP 79153"},
        {"Fundamental Katalog 5th Edition", "FK5 3273"},
        {"Geneva Identification System", "GEN# +1.00144480"},
        {"Smithsonian Astrophysical Observation", "SAO 243368"},
        {"Wilson Evans Batten Catalogue", "WEB 13381"},
    },
    visualMagnitude: 5.57,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.32734737),
        dec: Angle.Degrees(-57.93417299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42647"},
        {"Hipparcos Number", "HIP 29097"},
        {"Geneva Identification System", "GEN# +1.00042647"},
        {"Smithsonian Astrophysical Observation", "SAO 234341"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.06619810),
        dec: Angle.Degrees(-57.93151388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92584",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92584"},
        {"Smithsonian Astrophysical Observation", "SAO 245757"},
    },
    visualMagnitude: 9.77,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)51, 57.8100),
        dec: Angle.DegreesMinutesSeconds((int)-57, (int)55, 44.700)
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
    primaryId: "HIP 3619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4496"},
        {"Hipparcos Number", "HIP 3619"},
        {"Smithsonian Astrophysical Observation", "SAO 232177"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.60537135),
        dec: Angle.Degrees(-57.92762582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40374",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40374"},
    },
    visualMagnitude: 11.70,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.64762383),
        dec: Angle.Degrees(-34.66580057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215728"},
        {"Hipparcos Number", "HIP 112606"},
        {"Smithsonian Astrophysical Observation", "SAO 247591"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.09856642),
        dec: Angle.Degrees(-57.92595955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188161"},
        {"Hipparcos Number", "HIP 98163"},
        {"Geneva Identification System", "GEN# +1.00188161"},
        {"Smithsonian Astrophysical Observation", "SAO 246348"},
    },
    visualMagnitude: 6.55,
    bvColour: 1.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.24043148),
        dec: Angle.Degrees(-57.92554682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176371"},
        {"Hipparcos Number", "HIP 93559"},
        {"Smithsonian Astrophysical Observation", "SAO 245885"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.84007908),
        dec: Angle.Degrees(-57.92398694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11809"},
        {"Hipparcos Number", "HIP 8870"},
        {"Smithsonian Astrophysical Observation", "SAO 232565"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.53683271),
        dec: Angle.Degrees(-57.91902139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107885"},
        {"Hipparcos Number", "HIP 60497"},
        {"Geneva Identification System", "GEN# +1.00107885"},
        {"Smithsonian Astrophysical Observation", "SAO 239918"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.04230935),
        dec: Angle.Degrees(-57.91821352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77583"},
        {"Hipparcos Number", "HIP 44266"},
        {"Smithsonian Astrophysical Observation", "SAO 236507"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.21378213),
        dec: Angle.Degrees(-57.91702973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89358"},
        {"Hipparcos Number", "HIP 50368"},
        {"Geneva Identification System", "GEN# +1.00089358"},
    },
    visualMagnitude: 10.64,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.25950318),
        dec: Angle.Degrees(-57.91302856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 870"},
        {"Hipparcos Number", "HIP 1031"},
        {"Geneva Identification System", "GEN# +1.00000870"},
        {"Smithsonian Astrophysical Observation", "SAO 231973"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.775,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.20991289),
        dec: Angle.Degrees(-57.91269485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -117.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145782"},
        {"Hipparcos Number", "HIP 79689"},
        {"Geneva Identification System", "GEN# +1.00145782"},
        {"Smithsonian Astrophysical Observation", "SAO 243509"},
        {"Wilson Evans Batten Catalogue", "WEB 13485"},
    },
    visualMagnitude: 5.61,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.95754643),
        dec: Angle.Degrees(-57.91222851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97746"},
        {"Hipparcos Number", "HIP 54862"},
        {"Geneva Identification System", "GEN# +1.00097746"},
        {"Smithsonian Astrophysical Observation", "SAO 238884"},
        {"Wilson Evans Batten Catalogue", "WEB 9900"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.50021172),
        dec: Angle.Degrees(-57.91091372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151967"},
        {"Hipparcos Number", "HIP 82672"},
        {"Geneva Identification System", "GEN# +1.00151967"},
        {"Smithsonian Astrophysical Observation", "SAO 244245"},
        {"Wilson Evans Batten Catalogue", "WEB 13958"},
    },
    visualMagnitude: 5.91,
    bvColour: 1.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.50168481),
        dec: Angle.Degrees(-57.90920925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71777"},
        {"Hipparcos Number", "HIP 41353"},
        {"Smithsonian Astrophysical Observation", "SAO 235978"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.55259177),
        dec: Angle.Degrees(-57.90406634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110006"},
        {"Hipparcos Number", "HIP 61769"},
        {"Cincinnati Publication", "Ci 20 727"},
        {"Geneva Identification System", "GEN# +1.00110006"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.89869903),
        dec: Angle.Degrees(-57.90171192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -423.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 85.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39978"},
        {"Hipparcos Number", "HIP 27752"},
        {"Geneva Identification System", "GEN# +1.00039978"},
        {"Smithsonian Astrophysical Observation", "SAO 234183"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.11200776),
        dec: Angle.Degrees(-57.90136381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104696"},
        {"Hipparcos Number", "HIP 58774"},
        {"Smithsonian Astrophysical Observation", "SAO 239614"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.81959798),
        dec: Angle.Degrees(-57.90070733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197567"},
        {"Hipparcos Number", "HIP 102573"},
        {"Smithsonian Astrophysical Observation", "SAO 246729"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.80211577),
        dec: Angle.Degrees(-57.90069302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87860"},
        {"Hipparcos Number", "HIP 49474"},
        {"Geneva Identification System", "GEN# +1.00087860"},
        {"Smithsonian Astrophysical Observation", "SAO 237691"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.51695433),
        dec: Angle.Degrees(-57.90042196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146323"},
        {"Hipparcos Number", "HIP 79932"},
        {"Geneva Identification System", "GEN# +2.60870132"},
        {"Geneva Identification System 2", "GEN# +2.60870155"},
        {"Smithsonian Astrophysical Observation", "SAO 243586"},
        {"Wilson Evans Batten Catalogue", "WEB 13529"},
        {"New General Catalogue", "NGC 6087 155"},
        {"New General Catalogue 2", "NGC 6087 132"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.71597381),
        dec: Angle.Degrees(-57.89978696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208149"},
        {"Hipparcos Number", "HIP 108281"},
        {"Geneva Identification System", "GEN# +1.00208149"},
        {"Renson", "Renson 57880"},
        {"Smithsonian Astrophysical Observation", "SAO 247230"},
    },
    visualMagnitude: 6.17,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.05849028),
        dec: Angle.Degrees(-57.89960642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112319"},
        {"Hipparcos Number", "HIP 63175"},
        {"Geneva Identification System", "GEN# +1.00112319"},
    },
    visualMagnitude: 10.15,
    bvColour: 2.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.14815957),
        dec: Angle.Degrees(-57.89917578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121705"},
        {"Hipparcos Number", "HIP 68286"},
        {"Geneva Identification System", "GEN# +1.00121705"},
        {"Smithsonian Astrophysical Observation", "SAO 241341"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.68418364),
        dec: Angle.Degrees(-57.89607032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57358"},
        {"Hipparcos Number", "HIP 35293"},
        {"Smithsonian Astrophysical Observation", "SAO 235076"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.36626652),
        dec: Angle.Degrees(-57.89385537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159990"},
        {"Hipparcos Number", "HIP 86528"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.24761797),
        dec: Angle.Degrees(-57.89348360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39977"},
        {"Hipparcos Number", "HIP 27762"},
        {"Smithsonian Astrophysical Observation", "SAO 234184"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.12657113),
        dec: Angle.Degrees(-57.88963561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71146"},
        {"Hipparcos Number", "HIP 41066"},
        {"Smithsonian Astrophysical Observation", "SAO 235938"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.69169709),
        dec: Angle.Degrees(-57.88863378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146448"},
        {"Hipparcos Number", "HIP 79973"},
        {"Geneva Identification System", "GEN# +2.60870008"},
        {"Smithsonian Astrophysical Observation", "SAO 243612"},
        {"New General Catalogue", "NGC 6087 8"},
    },
    visualMagnitude: 9.01,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.85475267),
        dec: Angle.Degrees(-57.88571526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213884"},
        {"Hipparcos Number", "HIP 111548"},
        {"Geneva Identification System", "GEN# +1.00213884"},
        {"Smithsonian Astrophysical Observation", "SAO 247505"},
    },
    visualMagnitude: 6.22,
    bvColour: 0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.97014594),
        dec: Angle.Degrees(-57.88372842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218939"},
        {"Hipparcos Number", "HIP 114583"},
        {"Smithsonian Astrophysical Observation", "SAO 247773"},
    },
    visualMagnitude: 9.60,
    bvColour: 1.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.19226774),
        dec: Angle.Degrees(-57.88333982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125240"},
        {"Hipparcos Number", "HIP 70044"},
        {"Geneva Identification System", "GEN# +1.00125240"},
        {"Smithsonian Astrophysical Observation", "SAO 241637"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.00351832),
        dec: Angle.Degrees(-57.88230822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21826"},
        {"Hipparcos Number", "HIP 16163"},
        {"Fundamental Katalog 5th Edition", "FK5 2245"},
        {"Smithsonian Astrophysical Observation", "SAO 233133"},
    },
    visualMagnitude: 6.69,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.07196418),
        dec: Angle.Degrees(-57.88219147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156767"},
        {"Hipparcos Number", "HIP 85050"},
        {"Geneva Identification System", "GEN# +1.00156767"},
        {"Smithsonian Astrophysical Observation", "SAO 244679"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.73124454),
        dec: Angle.Degrees(-57.88182770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46937"},
        {"Hipparcos Number", "HIP 31175"},
        {"Smithsonian Astrophysical Observation", "SAO 234567"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.12562332),
        dec: Angle.Degrees(-57.88159451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73065"},
        {"Hipparcos Number", "HIP 41981"},
        {"Smithsonian Astrophysical Observation", "SAO 236085"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.35338425),
        dec: Angle.Degrees(-57.88100580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 302084"},
        {"Hipparcos Number", "HIP 44540"},
        {"Smithsonian Astrophysical Observation", "SAO 236569"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.12999323),
        dec: Angle.Degrees(-57.88082991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99145"},
        {"Hipparcos Number", "HIP 55645"},
        {"Smithsonian Astrophysical Observation", "SAO 239033"},
    },
    visualMagnitude: 6.50,
    bvColour: 1.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.98559851),
        dec: Angle.Degrees(-57.88039388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196107"},
        {"Hipparcos Number", "HIP 101812"},
        {"Fundamental Katalog 5th Edition", "FK5 5814"},
        {"Geneva Identification System", "GEN# +1.00196107"},
        {"Smithsonian Astrophysical Observation", "SAO 246661"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.48333517),
        dec: Angle.Degrees(-57.87407174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198807"},
        {"Hipparcos Number", "HIP 103279"},
        {"Geneva Identification System", "GEN# +1.00198807"},
        {"Smithsonian Astrophysical Observation", "SAO 246791"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.84938004),
        dec: Angle.Degrees(-57.86766716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39284",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39284"},
    },
    visualMagnitude: 10.28,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.49576768),
        dec: Angle.Degrees(-57.86763431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201002"},
        {"Hipparcos Number", "HIP 104431"},
        {"Geneva Identification System", "GEN# +1.00201002"},
        {"Smithsonian Astrophysical Observation", "SAO 246887"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.31943158),
        dec: Angle.Degrees(-57.86567169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109777"},
        {"Hipparcos Number", "HIP 61626"},
        {"Celescope Catalog", "CEL 4134"},
        {"Geneva Identification System", "GEN# +1.00109777"},
        {"Smithsonian Astrophysical Observation", "SAO 240098"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.46306145),
        dec: Angle.Degrees(-57.86559931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92023"},
        {"Hipparcos Number", "HIP 51899"},
        {"Smithsonian Astrophysical Observation", "SAO 238236"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.871,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.04991594),
        dec: Angle.Degrees(-57.86293172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124689"},
        {"Hipparcos Number", "HIP 69779"},
        {"Geneva Identification System", "GEN# +1.00124689"},
        {"Smithsonian Astrophysical Observation", "SAO 241587"},
        {"Wilson Evans Batten Catalogue", "WEB 12150"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.23866225),
        dec: Angle.Degrees(-57.85429216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216349"},
        {"Hipparcos Number", "HIP 113022"},
        {"Smithsonian Astrophysical Observation", "SAO 247630"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.32555292),
        dec: Angle.Degrees(-57.85422141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166653"},
        {"Hipparcos Number", "HIP 89430"},
        {"Smithsonian Astrophysical Observation", "SAO 245335"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.78538672),
        dec: Angle.Degrees(-57.85413720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214163"},
        {"Hipparcos Number", "HIP 111712"},
        {"Smithsonian Astrophysical Observation", "SAO 247517"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.44078606),
        dec: Angle.Degrees(-57.85292256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78293"},
        {"Hipparcos Number", "HIP 44565"},
        {"Geneva Identification System", "GEN# +1.00078293J"},
        {"Smithsonian Astrophysical Observation", "SAO 236578"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.19998116),
        dec: Angle.Degrees(-57.85262854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82904",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82904"},
        {"Geneva Identification System", "GEN# +6.00224495"},
        {"Wilson Evans Batten Catalogue", "WEB 14019"},
    },
    visualMagnitude: 11.70,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)56, 30.1000),
        dec: Angle.DegreesMinutesSeconds((int)-57, (int)51, 09.100)
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
    primaryId: "HIP 66897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119073"},
        {"Hipparcos Number", "HIP 66897"},
        {"Smithsonian Astrophysical Observation", "SAO 241091"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.63818142),
        dec: Angle.Degrees(-57.85249927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117552"},
        {"Hipparcos Number", "HIP 66041"},
        {"Geneva Identification System", "GEN# +1.00117552"},
        {"Smithsonian Astrophysical Observation", "SAO 240928"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.08612152),
        dec: Angle.Degrees(-57.85193971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131905"},
        {"Hipparcos Number", "HIP 73288"},
        {"Smithsonian Astrophysical Observation", "SAO 242138"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.67147990),
        dec: Angle.Degrees(-57.85110683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94112"},
        {"Hipparcos Number", "HIP 53004"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.65084696),
        dec: Angle.Degrees(-57.85018693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106908"},
        {"Hipparcos Number", "HIP 59965"},
        {"Smithsonian Astrophysical Observation", "SAO 239820"},
    },
    visualMagnitude: 6.75,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.48044380),
        dec: Angle.Degrees(-57.85014940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202809"},
        {"Hipparcos Number", "HIP 105378"},
        {"Geneva Identification System", "GEN# +1.00202809"},
        {"Smithsonian Astrophysical Observation", "SAO 246972"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.16139535),
        dec: Angle.Degrees(-57.84878344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196263"},
        {"Hipparcos Number", "HIP 101892"},
        {"Smithsonian Astrophysical Observation", "SAO 246673"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.72648062),
        dec: Angle.Degrees(-57.84631207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121807"},
        {"Hipparcos Number", "HIP 68344"},
        {"Geneva Identification System", "GEN# +1.00121807"},
        {"Smithsonian Astrophysical Observation", "SAO 241350"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.85206723),
        dec: Angle.Degrees(-57.83806162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20286"},
        {"Hipparcos Number", "HIP 14975"},
        {"Geneva Identification System", "GEN# +2.12520004"},
        {"Geneva Identification System 2", "GEN# +1.00020286"},
        {"Smithsonian Astrophysical Observation", "SAO 233040"},
        {"New General Catalogue", "NGC 1252 4"},
    },
    visualMagnitude: 9.17,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.26067087),
        dec: Angle.Degrees(-57.83383850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99939"},
        {"Hipparcos Number", "HIP 56057"},
        {"Geneva Identification System", "GEN# +1.00099939"},
        {"Smithsonian Astrophysical Observation", "SAO 239111"},
        {"Wilson Evans Batten Catalogue", "WEB 10067"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.33830136),
        dec: Angle.Degrees(-57.83244505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123940"},
        {"Hipparcos Number", "HIP 69396"},
        {"Geneva Identification System", "GEN# +1.00123940"},
        {"Smithsonian Astrophysical Observation", "SAO 241526"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.09965318),
        dec: Angle.Degrees(-57.83189067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102921"},
        {"Hipparcos Number", "HIP 57762"},
        {"Geneva Identification System", "GEN# +1.00102921"},
        {"Smithsonian Astrophysical Observation", "SAO 239423"},
    },
    visualMagnitude: 8.24,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.68231014),
        dec: Angle.Degrees(-57.83096313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225158"},
        {"Hipparcos Number", "HIP 306"},
        {"Smithsonian Astrophysical Observation", "SAO 231912"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.97473996),
        dec: Angle.Degrees(-57.83035720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 150.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91870"},
        {"Hipparcos Number", "HIP 51801"},
        {"Smithsonian Astrophysical Observation", "SAO 238215"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.75892948),
        dec: Angle.Degrees(-57.82863576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90578"},
        {"Hipparcos Number", "HIP 51063"},
        {"Celescope Catalog", "CEL 3538"},
        {"Geneva Identification System", "GEN# +1.00090578"},
        {"Smithsonian Astrophysical Observation", "SAO 238057"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.50082140),
        dec: Angle.Degrees(-57.82694258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146261"},
        {"Hipparcos Number", "HIP 79891"},
        {"Geneva Identification System", "GEN# +2.60870013"},
        {"Smithsonian Astrophysical Observation", "SAO 243566"},
        {"New General Catalogue", "NGC 6087 13"},
    },
    visualMagnitude: 9.31,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.60369821),
        dec: Angle.Degrees(-57.82582259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20544"},
        {"Hipparcos Number", "HIP 15176"},
        {"Smithsonian Astrophysical Observation", "SAO 233054"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.88612658),
        dec: Angle.Degrees(-57.82164933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17812"},
        {"Hipparcos Number", "HIP 13154"},
        {"Smithsonian Astrophysical Observation", "SAO 232906"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.29079063),
        dec: Angle.Degrees(-57.82014563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14474"},
        {"Hipparcos Number", "HIP 10739"},
        {"Smithsonian Astrophysical Observation", "SAO 232703"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.55353867),
        dec: Angle.Degrees(-57.81944271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155465"},
        {"Hipparcos Number", "HIP 84394"},
        {"Smithsonian Astrophysical Observation", "SAO 244551"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.81088724),
        dec: Angle.Degrees(-57.81861181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134892"},
        {"Hipparcos Number", "HIP 74629"},
        {"Smithsonian Astrophysical Observation", "SAO 242341"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.73023039),
        dec: Angle.Degrees(-57.81795522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140406"},
        {"Hipparcos Number", "HIP 77242"},
        {"Smithsonian Astrophysical Observation", "SAO 242940"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.57881956),
        dec: Angle.Degrees(-57.81244206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22587"},
        {"Hipparcos Number", "HIP 16722"},
        {"Smithsonian Astrophysical Observation", "SAO 233172"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.78311880),
        dec: Angle.Degrees(-57.81037311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20037"},
        {"Hipparcos Number", "HIP 14765"},
        {"Geneva Identification System", "GEN# +2.12520013"},
        {"Geneva Identification System 2", "GEN# +1.00020037"},
        {"Smithsonian Astrophysical Observation", "SAO 233023"},
        {"New General Catalogue", "NGC 1252 13"},
    },
    visualMagnitude: 6.63,
    bvColour: 0.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.66350915),
        dec: Angle.Degrees(-57.80980313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15793"},
        {"Hipparcos Number", "HIP 11648"},
        {"Geneva Identification System", "GEN# +1.00015793"},
        {"Smithsonian Astrophysical Observation", "SAO 232795"},
        {"Wilson Evans Batten Catalogue", "WEB 2426"},
    },
    visualMagnitude: 6.76,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.56467912),
        dec: Angle.Degrees(-57.80949013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140681"},
        {"Hipparcos Number", "HIP 77383"},
        {"Geneva Identification System", "GEN# +1.00140681"},
        {"Smithsonian Astrophysical Observation", "SAO 242972"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.94946978),
        dec: Angle.Degrees(-57.80825815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26942"},
        {"Hipparcos Number", "HIP 19632"},
        {"Smithsonian Astrophysical Observation", "SAO 233433"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.09537007),
        dec: Angle.Degrees(-57.80657486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128963"},
        {"Hipparcos Number", "HIP 71885"},
        {"Renson", "Renson 36720"},
        {"Smithsonian Astrophysical Observation", "SAO 241918"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.54519884),
        dec: Angle.Degrees(-57.80586744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97805"},
        {"Hipparcos Number", "HIP 54896"},
        {"Celescope Catalog", "CEL 3859"},
        {"Geneva Identification System", "GEN# +1.00097805"},
        {"Smithsonian Astrophysical Observation", "SAO 238889"},
    },
    visualMagnitude: 7.77,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.60207447),
        dec: Angle.Degrees(-57.80118522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103102"},
        {"Hipparcos Number", "HIP 57871"},
        {"Smithsonian Astrophysical Observation", "SAO 239442"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.04300963),
        dec: Angle.Degrees(-57.80085902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212330"},
        {"Hipparcos Number", "HIP 110649"},
        {"Geneva Identification System", "GEN# +1.00212330"},
        {"Smithsonian Astrophysical Observation", "SAO 247441"},
        {"Wilson Evans Batten Catalogue", "WEB 19827"},
    },
    visualMagnitude: 5.31,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.23413615),
        dec: Angle.Degrees(-57.79661017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 180.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -331.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6521"},
        {"Hipparcos Number", "HIP 5094"},
        {"Geneva Identification System", "GEN# +1.00006521"},
        {"Smithsonian Astrophysical Observation", "SAO 232290"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.30939902),
        dec: Angle.Degrees(-57.79484786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163202"},
        {"Hipparcos Number", "HIP 87995"},
        {"Smithsonian Astrophysical Observation", "SAO 245143"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.61366776),
        dec: Angle.Degrees(-57.79277022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118225"},
        {"Hipparcos Number", "HIP 66402"},
        {"Smithsonian Astrophysical Observation", "SAO 240995"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.20473421),
        dec: Angle.Degrees(-57.79026742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165395"},
        {"Hipparcos Number", "HIP 88935"},
        {"Smithsonian Astrophysical Observation", "SAO 245266"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.30970270),
        dec: Angle.Degrees(-57.78656116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195784"},
        {"Hipparcos Number", "HIP 101640"},
        {"Smithsonian Astrophysical Observation", "SAO 246650"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.03052508),
        dec: Angle.Degrees(-57.78602555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9078"},
        {"Hipparcos Number", "HIP 6838"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.00276509),
        dec: Angle.Degrees(-57.78524070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41354"},
        {"Hipparcos Number", "HIP 28512"},
        {"Smithsonian Astrophysical Observation", "SAO 234258"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.27680803),
        dec: Angle.Degrees(-57.78415147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211262"},
        {"Hipparcos Number", "HIP 110051"},
        {"Geneva Identification System", "GEN# +1.00211262"},
        {"Smithsonian Astrophysical Observation", "SAO 247392"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.35604939),
        dec: Angle.Degrees(-57.78405131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224568"},
        {"Hipparcos Number", "HIP 118237"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.73805189),
        dec: Angle.Degrees(-57.78329151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67444"},
        {"Hipparcos Number", "HIP 39552"},
        {"Smithsonian Astrophysical Observation", "SAO 235736"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.23328244),
        dec: Angle.Degrees(-57.78003473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216753"},
        {"Hipparcos Number", "HIP 113287"},
        {"Smithsonian Astrophysical Observation", "SAO 247651"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.10745111),
        dec: Angle.Degrees(-57.77989002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54713"},
        {"Hipparcos Number", "HIP 34288"},
        {"Geneva Identification System", "GEN# +1.00054713"},
        {"Smithsonian Astrophysical Observation", "SAO 234930"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.62798351),
        dec: Angle.Degrees(-57.77845619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143474"},
        {"Hipparcos Number", "HIP 78662"},
        {"Geneva Identification System", "GEN# +1.00143474J"},
        {"Smithsonian Astrophysical Observation", "SAO 243279"},
        {"Wilson Evans Batten Catalogue", "WEB 13297"},
    },
    visualMagnitude: 4.63,
    bvColour: 0.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.88425437),
        dec: Angle.Degrees(-57.77487351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -118.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200677"},
        {"Hipparcos Number", "HIP 104260"},
        {"Smithsonian Astrophysical Observation", "SAO 246874"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.83194477),
        dec: Angle.Degrees(-57.77390013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80545"},
        {"Hipparcos Number", "HIP 45637"},
        {"Cincinnati Publication", "Ci 20 518"},
        {"Geneva Identification System", "GEN# +1.00080545"},
    },
    visualMagnitude: 9.52,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.53738985),
        dec: Angle.Degrees(-57.77002410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 472.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18796"},
        {"Hipparcos Number", "HIP 13898"},
        {"Smithsonian Astrophysical Observation", "SAO 232957"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.73775626),
        dec: Angle.Degrees(-57.76998238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114120"},
        {"Hipparcos Number", "HIP 64197"},
        {"Smithsonian Astrophysical Observation", "SAO 240600"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.35808011),
        dec: Angle.Degrees(-57.76963689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74957"},
        {"Hipparcos Number", "HIP 42885"},
        {"Geneva Identification System", "GEN# +1.00074957"},
        {"Smithsonian Astrophysical Observation", "SAO 236231"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.09993200),
        dec: Angle.Degrees(-57.76929848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 75.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214087"},
        {"Hipparcos Number", "HIP 111656"},
        {"Smithsonian Astrophysical Observation", "SAO 247513"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.28452529),
        dec: Angle.Degrees(-57.76832741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69431"},
        {"Hipparcos Number", "HIP 40310"},
        {"Smithsonian Astrophysical Observation", "SAO 235824"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.47143143),
        dec: Angle.Degrees(-57.76831212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76032"},
        {"Hipparcos Number", "HIP 43455"},
        {"Smithsonian Astrophysical Observation", "SAO 236329"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.76405391),
        dec: Angle.Degrees(-57.76820931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203167"},
        {"Hipparcos Number", "HIP 105567"},
        {"Geneva Identification System", "GEN# +1.00203167"},
        {"Smithsonian Astrophysical Observation", "SAO 247002"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.71568364),
        dec: Angle.Degrees(-57.76777793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55571"},
        {"Hipparcos Number", "HIP 34609"},
        {"Smithsonian Astrophysical Observation", "SAO 234986"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.52944042),
        dec: Angle.Degrees(-57.76773575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 69.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78027"},
        {"Hipparcos Number", "HIP 44453"},
        {"Smithsonian Astrophysical Observation", "SAO 236547"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.84633687),
        dec: Angle.Degrees(-57.76645945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89859"},
        {"Hipparcos Number", "HIP 50644"},
        {"Smithsonian Astrophysical Observation", "SAO 237946"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.14689962),
        dec: Angle.Degrees(-57.76627162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131802"},
        {"Hipparcos Number", "HIP 73230"},
        {"Geneva Identification System", "GEN# +1.00131802"},
        {"Smithsonian Astrophysical Observation", "SAO 242134"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.49766431),
        dec: Angle.Degrees(-57.76572861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96116"},
        {"Hipparcos Number", "HIP 54102"},
        {"Geneva Identification System", "GEN# +1.00096116"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.05672806),
        dec: Angle.Degrees(-57.76503944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51996"},
        {"Hipparcos Number", "HIP 33344"},
        {"Smithsonian Astrophysical Observation", "SAO 234795"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.01918161),
        dec: Angle.Degrees(-57.76453222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120194"},
        {"Hipparcos Number", "HIP 67465"},
        {"Geneva Identification System", "GEN# +1.00120194"},
        {"Smithsonian Astrophysical Observation", "SAO 241203"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.38183627),
        dec: Angle.Degrees(-57.75996010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144650"},
        {"Hipparcos Number", "HIP 79221"},
        {"Smithsonian Astrophysical Observation", "SAO 243385"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.52282242),
        dec: Angle.Degrees(-57.75973322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148218"},
        {"Hipparcos Number", "HIP 80788"},
        {"Geneva Identification System", "GEN# +1.00148218"},
        {"Smithsonian Astrophysical Observation", "SAO 243874"},
    },
    visualMagnitude: 6.09,
    bvColour: 1.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.43842678),
        dec: Angle.Degrees(-57.75631746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116252"},
        {"Hipparcos Number", "HIP 65351"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.90805448),
        dec: Angle.Degrees(-57.75460385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80706",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80706"},
    },
    visualMagnitude: 12.30,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.16424882),
        dec: Angle.Degrees(-57.74966763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -132.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28391"},
        {"Hipparcos Number", "HIP 20634"},
        {"Smithsonian Astrophysical Observation", "SAO 233514"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.33407872),
        dec: Angle.Degrees(-57.74630582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114250"},
        {"Hipparcos Number", "HIP 64277"},
        {"Geneva Identification System", "GEN# +1.00114250"},
        {"Smithsonian Astrophysical Observation", "SAO 240614"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.59390442),
        dec: Angle.Degrees(-57.74443285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104765"},
        {"Hipparcos Number", "HIP 58814"},
        {"Smithsonian Astrophysical Observation", "SAO 239623"},
    },
    visualMagnitude: 7.94,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.94561787),
        dec: Angle.Degrees(-57.74255773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105840"},
        {"Hipparcos Number", "HIP 59383"},
        {"Smithsonian Astrophysical Observation", "SAO 239725"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.74967332),
        dec: Angle.Degrees(-57.74240904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82279"},
        {"Hipparcos Number", "HIP 46492"},
        {"Geneva Identification System", "GEN# +1.00082279"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.23751036),
        dec: Angle.Degrees(-57.74215635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116720"},
        {"Hipparcos Number", "HIP 65569"},
        {"Geneva Identification System", "GEN# +1.00116720"},
        {"Smithsonian Astrophysical Observation", "SAO 240844"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.65191818),
        dec: Angle.Degrees(-57.74121223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101312"},
        {"Hipparcos Number", "HIP 56841"},
        {"Smithsonian Astrophysical Observation", "SAO 239261"},
    },
    visualMagnitude: 6.97,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.79448784),
        dec: Angle.Degrees(-57.73952775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205981"},
        {"Hipparcos Number", "HIP 107065"},
        {"Smithsonian Astrophysical Observation", "SAO 247135"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.26590135),
        dec: Angle.Degrees(-57.73816183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200424"},
        {"Hipparcos Number", "HIP 104129"},
        {"Smithsonian Astrophysical Observation", "SAO 246859"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.45257657),
        dec: Angle.Degrees(-57.73641385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117526"},
        {"Hipparcos Number", "HIP 66022"},
        {"Smithsonian Astrophysical Observation", "SAO 240924"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.03939045),
        dec: Angle.Degrees(-57.73452313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93306"},
        {"Hipparcos Number", "HIP 52588"},
        {"Smithsonian Astrophysical Observation", "SAO 238432"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.29508686),
        dec: Angle.Degrees(-57.73336683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31174"},
        {"Hipparcos Number", "HIP 22478"},
        {"Smithsonian Astrophysical Observation", "SAO 233705"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.54510042),
        dec: Angle.Degrees(-57.73208043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119225"},
        {"Hipparcos Number", "HIP 66960"},
        {"Smithsonian Astrophysical Observation", "SAO 241106"},
    },
    visualMagnitude: 8.75,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.86144979),
        dec: Angle.Degrees(-57.73179712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90475",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90475"},
    },
    visualMagnitude: 10.62,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.91972482),
        dec: Angle.Degrees(-57.72952073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161440"},
        {"Hipparcos Number", "HIP 87208"},
        {"Smithsonian Astrophysical Observation", "SAO 245049"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.25609181),
        dec: Angle.Degrees(-57.72850413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99218"},
        {"Hipparcos Number", "HIP 55675"},
        {"Smithsonian Astrophysical Observation", "SAO 239043"},
    },
    visualMagnitude: 8.89,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.11074907),
        dec: Angle.Degrees(-57.72783521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86161"},
        {"Hipparcos Number", "HIP 48617"},
        {"Geneva Identification System", "GEN# +1.00086161"},
        {"Smithsonian Astrophysical Observation", "SAO 237491"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.72047416),
        dec: Angle.Degrees(-57.72731091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17426"},
        {"Hipparcos Number", "HIP 12867"},
        {"Smithsonian Astrophysical Observation", "SAO 232881"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.35261823),
        dec: Angle.Degrees(-57.72547266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186563"},
        {"Hipparcos Number", "HIP 97441"},
        {"Geneva Identification System", "GEN# +1.00186563"},
        {"Smithsonian Astrophysical Observation", "SAO 246274"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.07103761),
        dec: Angle.Degrees(-57.72532175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24938"},
        {"Hipparcos Number", "HIP 18303"},
        {"Smithsonian Astrophysical Observation", "SAO 233325"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.69985961),
        dec: Angle.Degrees(-57.72494877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160435"},
        {"Hipparcos Number", "HIP 86728"},
        {"Geneva Identification System", "GEN# +1.00160435"},
        {"Smithsonian Astrophysical Observation", "SAO 244964"},
    },
    visualMagnitude: 6.85,
    bvColour: 2.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.82893355),
        dec: Angle.Degrees(-57.72395429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111570"},
        {"Hipparcos Number", "HIP 62699"},
        {"Geneva Identification System", "GEN# +1.00111570"},
        {"Smithsonian Astrophysical Observation", "SAO 240313"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.738,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.72521718),
        dec: Angle.Degrees(-57.72168737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6043"},
        {"Hipparcos Number", "HIP 4731"},
        {"Smithsonian Astrophysical Observation", "SAO 232259"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.19461741),
        dec: Angle.Degrees(-57.71909971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149667"},
        {"Hipparcos Number", "HIP 81561"},
        {"Geneva Identification System", "GEN# +1.00149667"},
        {"Smithsonian Astrophysical Observation", "SAO 244025"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.86694140),
        dec: Angle.Degrees(-57.71661118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109198"},
        {"Hipparcos Number", "HIP 61266"},
        {"Celescope Catalog", "CEL 4122"},
        {"Geneva Identification System", "GEN# +1.00109198"},
        {"Smithsonian Astrophysical Observation", "SAO 240054"},
    },
    visualMagnitude: 7.75,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.33571076),
        dec: Angle.Degrees(-57.71635755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196966"},
        {"Hipparcos Number", "HIP 102269"},
        {"Smithsonian Astrophysical Observation", "SAO 246704"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.83140212),
        dec: Angle.Degrees(-57.71633952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153716"},
        {"Hipparcos Number", "HIP 83535"},
        {"Fundamental Katalog 5th Edition", "FK5 3355"},
        {"Geneva Identification System", "GEN# +1.00153716"},
        {"Smithsonian Astrophysical Observation", "SAO 244401"},
        {"Wilson Evans Batten Catalogue", "WEB 14120"},
    },
    visualMagnitude: 5.73,
    bvColour: -0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.10302112),
        dec: Angle.Degrees(-57.71210729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121518"},
        {"Hipparcos Number", "HIP 68178"},
        {"Geneva Identification System", "GEN# +1.00121518"},
        {"Smithsonian Astrophysical Observation", "SAO 241324"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.726,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.36705703),
        dec: Angle.Degrees(-57.71110765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120560"},
        {"Hipparcos Number", "HIP 67659"},
        {"Geneva Identification System", "GEN# +1.00120560"},
        {"Smithsonian Astrophysical Observation", "SAO 241232"},
    },
    visualMagnitude: 9.35,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.93907513),
        dec: Angle.Degrees(-57.71097265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105875"},
        {"Hipparcos Number", "HIP 59409"},
        {"Smithsonian Astrophysical Observation", "SAO 239729"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.80813886),
        dec: Angle.Degrees(-57.71022216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139084"},
        {"Hipparcos Number", "HIP 76629"},
        {"Geneva Identification System", "GEN# +1.00139084"},
        {"Smithsonian Astrophysical Observation", "SAO 242791"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.817,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.74000974),
        dec: Angle.Degrees(-57.70733650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197790"},
        {"Hipparcos Number", "HIP 102696"},
        {"Geneva Identification System", "GEN# +1.00197790"},
        {"Smithsonian Astrophysical Observation", "SAO 246733"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.12839810),
        dec: Angle.Degrees(-57.70585337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9649",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9649"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.744,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.00552358),
        dec: Angle.Degrees(-57.70360640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 119.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 98.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87281"},
        {"Hipparcos Number", "HIP 49178"},
        {"Geneva Identification System", "GEN# +1.00087281"},
        {"Smithsonian Astrophysical Observation", "SAO 237626"},
    },
    visualMagnitude: 8.28,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.55770474),
        dec: Angle.Degrees(-57.70333878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106809"},
        {"Hipparcos Number", "HIP 59901"},
        {"Geneva Identification System", "GEN# +1.00106809"},
        {"Smithsonian Astrophysical Observation", "SAO 239807"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.835,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.28497610),
        dec: Angle.Degrees(-57.70242990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43976"},
        {"Hipparcos Number", "HIP 29724"},
        {"Geneva Identification System", "GEN# +1.00043976"},
        {"Smithsonian Astrophysical Observation", "SAO 234409"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.91183347),
        dec: Angle.Degrees(-57.70166464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20059"},
        {"Hipparcos Number", "HIP 14779"},
        {"Geneva Identification System", "GEN# +2.12520001"},
        {"Smithsonian Astrophysical Observation", "SAO 233025"},
        {"New General Catalogue", "NGC 1252 1"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.70825712),
        dec: Angle.Degrees(-57.70160899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206804"},
        {"Hipparcos Number", "HIP 107522"},
        {"Cincinnati Publication", "Ci 20 1308"},
        {"Geneva Identification System", "GEN# +1.00206804"},
        {"Smithsonian Astrophysical Observation", "SAO 247172"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.64868207),
        dec: Angle.Degrees(-57.70118154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -905.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5938"},
        {"Hipparcos Number", "HIP 4668"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.831,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.98706672),
        dec: Angle.Degrees(-57.70087442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5739"},
        {"Hipparcos Number", "HIP 4536"},
        {"Smithsonian Astrophysical Observation", "SAO 232243"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.52374455),
        dec: Angle.Degrees(-57.70050754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132985"},
        {"Hipparcos Number", "HIP 73749"},
        {"Geneva Identification System", "GEN# +1.00132985"},
        {"Smithsonian Astrophysical Observation", "SAO 242203"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.12433305),
        dec: Angle.Degrees(-57.69842129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212846"},
        {"Hipparcos Number", "HIP 110930"},
        {"Smithsonian Astrophysical Observation", "SAO 247459"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.12417979),
        dec: Angle.Degrees(-57.69774410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102461"},
        {"Hipparcos Number", "HIP 57512"},
        {"Fundamental Katalog 5th Edition", "FK5 2942"},
        {"Geneva Identification System", "GEN# +1.00102461"},
        {"Smithsonian Astrophysical Observation", "SAO 239373"},
        {"Wilson Evans Batten Catalogue", "WEB 10329"},
    },
    visualMagnitude: 5.42,
    bvColour: 1.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.82987104),
        dec: Angle.Degrees(-57.69654711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146271"},
        {"Hipparcos Number", "HIP 79907"},
        {"Geneva Identification System", "GEN# +2.60870001"},
        {"Smithsonian Astrophysical Observation", "SAO 243572"},
        {"New General Catalogue", "NGC 6087 1"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.65665719),
        dec: Angle.Degrees(-57.69612189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7082"},
        {"Hipparcos Number", "HIP 5477"},
        {"Fundamental Katalog 5th Edition", "FK5 2077"},
        {"Geneva Identification System", "GEN# +1.00007082"},
        {"Smithsonian Astrophysical Observation", "SAO 232324"},
    },
    visualMagnitude: 6.41,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.53073683),
        dec: Angle.Degrees(-57.69413983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -114.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102693"},
        {"Hipparcos Number", "HIP 57644"},
        {"Smithsonian Astrophysical Observation", "SAO 239392"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.30313672),
        dec: Angle.Degrees(-57.69156766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116023"},
        {"Hipparcos Number", "HIP 65233"},
        {"Smithsonian Astrophysical Observation", "SAO 240779"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.52581011),
        dec: Angle.Degrees(-57.68947648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82877"},
        {"Hipparcos Number", "HIP 46832"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.14330400),
        dec: Angle.Degrees(-57.68763010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12621"},
        {"Hipparcos Number", "HIP 9476"},
        {"Smithsonian Astrophysical Observation", "SAO 232607"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.47630359),
        dec: Angle.Degrees(-57.68714278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10745"},
        {"Hipparcos Number", "HIP 8058"},
        {"Smithsonian Astrophysical Observation", "SAO 232509"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.87927581),
        dec: Angle.Degrees(-57.68646295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5018",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5018"},
        {"Geneva Identification System", "GEN# +6.20145182"},
    },
    visualMagnitude: 11.56,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.07529584),
        dec: Angle.Degrees(-57.68599136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 236.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113280"},
        {"Hipparcos Number", "HIP 63725"},
        {"Smithsonian Astrophysical Observation", "SAO 240510"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.89217282),
        dec: Angle.Degrees(-57.68561916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14814"},
        {"Hipparcos Number", "HIP 10958"},
        {"Geneva Identification System", "GEN# +1.00014814"},
        {"Smithsonian Astrophysical Observation", "SAO 232727"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.28313323),
        dec: Angle.Degrees(-57.68546368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82779"},
        {"Hipparcos Number", "HIP 46790"},
        {"Smithsonian Astrophysical Observation", "SAO 237077"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.01826110),
        dec: Angle.Degrees(-57.68499523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91869"},
        {"Hipparcos Number", "HIP 51806"},
        {"Smithsonian Astrophysical Observation", "SAO 238217"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.861,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.76935457),
        dec: Angle.Degrees(-57.67712611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107696"},
        {"Hipparcos Number", "HIP 60379"},
        {"Celescope Catalog", "CEL 4100"},
        {"Geneva Identification System", "GEN# +1.00107696"},
        {"Renson", "Renson 31220"},
        {"Smithsonian Astrophysical Observation", "SAO 239901"},
        {"Wilson Evans Batten Catalogue", "WEB 10740"},
    },
    visualMagnitude: 5.38,
    bvColour: -0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.70613474),
        dec: Angle.Degrees(-57.67610097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75762"},
        {"Hipparcos Number", "HIP 43298"},
        {"Geneva Identification System", "GEN# +1.00075762"},
        {"Smithsonian Astrophysical Observation", "SAO 236310"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.31010769),
        dec: Angle.Degrees(-57.67482729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33147"},
        {"Hipparcos Number", "HIP 23635"},
        {"Smithsonian Astrophysical Observation", "SAO 233815"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.21157301),
        dec: Angle.Degrees(-57.67238565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199594"},
        {"Hipparcos Number", "HIP 103696"},
        {"Smithsonian Astrophysical Observation", "SAO 246822"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.18898106),
        dec: Angle.Degrees(-57.67115028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203260"},
        {"Hipparcos Number", "HIP 105609"},
        {"Smithsonian Astrophysical Observation", "SAO 247005"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.85405448),
        dec: Angle.Degrees(-57.66957047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16880"},
        {"Hipparcos Number", "HIP 12433"},
        {"Smithsonian Astrophysical Observation", "SAO 232854"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.00695469),
        dec: Angle.Degrees(-57.66799404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187214"},
        {"Hipparcos Number", "HIP 97761"},
        {"Geneva Identification System", "GEN# +1.00187214"},
        {"Smithsonian Astrophysical Observation", "SAO 246304"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.00069693),
        dec: Angle.Degrees(-57.66594269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163029"},
        {"Hipparcos Number", "HIP 87914"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.38174895),
        dec: Angle.Degrees(-57.66391076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -128.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17721"},
        {"Hipparcos Number", "HIP 13089"},
        {"Smithsonian Astrophysical Observation", "SAO 232900"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.06262778),
        dec: Angle.Degrees(-57.66192531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85137"},
        {"Hipparcos Number", "HIP 48068"},
        {"Smithsonian Astrophysical Observation", "SAO 237349"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.98493874),
        dec: Angle.Degrees(-57.66080553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85210"},
        {"Hipparcos Number", "HIP 48104"},
        {"Smithsonian Astrophysical Observation", "SAO 237362"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.11276619),
        dec: Angle.Degrees(-57.65858696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89802"},
        {"Hipparcos Number", "HIP 50614"},
        {"Celescope Catalog", "CEL 3511"},
        {"Geneva Identification System", "GEN# +1.00089802"},
        {"Smithsonian Astrophysical Observation", "SAO 237936"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.08138080),
        dec: Angle.Degrees(-57.65814082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87817"},
        {"Hipparcos Number", "HIP 49453"},
        {"Smithsonian Astrophysical Observation", "SAO 237686"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.45147526),
        dec: Angle.Degrees(-57.65784357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99144"},
        {"Hipparcos Number", "HIP 55646"},
        {"Geneva Identification System", "GEN# +1.00099144"},
        {"Smithsonian Astrophysical Observation", "SAO 239034"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.99194425),
        dec: Angle.Degrees(-57.65782135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111971"},
        {"Hipparcos Number", "HIP 62923"},
        {"Geneva Identification System", "GEN# +1.00111971"},
        {"Smithsonian Astrophysical Observation", "SAO 240355"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.42711662),
        dec: Angle.Degrees(-57.65660437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 79.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50127"},
        {"Hipparcos Number", "HIP 32610"},
        {"Smithsonian Astrophysical Observation", "SAO 234726"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.06587815),
        dec: Angle.Degrees(-57.65595705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86441"},
        {"Hipparcos Number", "HIP 48761"},
        {"Geneva Identification System", "GEN# +1.00086441"},
        {"Smithsonian Astrophysical Observation", "SAO 237521"},
        {"Wilson Evans Batten Catalogue", "WEB 9068"},
    },
    visualMagnitude: 7.51,
    bvColour: -0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.18856846),
        dec: Angle.Degrees(-57.65483281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15577"},
        {"Hipparcos Number", "HIP 11481"},
        {"Smithsonian Astrophysical Observation", "SAO 232781"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.02395315),
        dec: Angle.Degrees(-57.65120812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98013"},
        {"Hipparcos Number", "HIP 54991"},
        {"Smithsonian Astrophysical Observation", "SAO 238912"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.89891763),
        dec: Angle.Degrees(-57.65089621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75133"},
        {"Hipparcos Number", "HIP 42969"},
        {"Smithsonian Astrophysical Observation", "SAO 236247"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.37040285),
        dec: Angle.Degrees(-57.64805135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191800"},
        {"Hipparcos Number", "HIP 99784"},
        {"Smithsonian Astrophysical Observation", "SAO 246496"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.68679534),
        dec: Angle.Degrees(-57.64764738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86022"},
        {"Hipparcos Number", "HIP 48543"},
        {"Smithsonian Astrophysical Observation", "SAO 237471"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.50133442),
        dec: Angle.Degrees(-57.64658990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100528"},
        {"Hipparcos Number", "HIP 56393"},
        {"Smithsonian Astrophysical Observation", "SAO 239169"},
    },
    visualMagnitude: 7.87,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.41419620),
        dec: Angle.Degrees(-57.64510596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194330"},
        {"Hipparcos Number", "HIP 100934"},
        {"Geneva Identification System", "GEN# +1.00194330"},
        {"Smithsonian Astrophysical Observation", "SAO 246591"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.767,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.97597337),
        dec: Angle.Degrees(-57.64454722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22974"},
        {"Hipparcos Number", "HIP 16975"},
        {"Smithsonian Astrophysical Observation", "SAO 233198"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.58277213),
        dec: Angle.Degrees(-57.64132368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90772"},
        {"Hipparcos Number", "HIP 51192"},
        {"Celescope Catalog", "CEL 3544"},
        {"Geneva Identification System", "GEN# +3.25810001"},
        {"Smithsonian Astrophysical Observation", "SAO 238077"},
        {"Wilson Evans Batten Catalogue", "WEB 9357"},
    },
    visualMagnitude: 4.65,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.85199279),
        dec: Angle.Degrees(-57.63881373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158429"},
        {"Hipparcos Number", "HIP 85854"},
        {"Smithsonian Astrophysical Observation", "SAO 244824"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.17397182),
        dec: Angle.Degrees(-57.63831483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98982"},
        {"Hipparcos Number", "HIP 55566"},
        {"Celescope Catalog", "CEL 3890"},
        {"Smithsonian Astrophysical Observation", "SAO 239013"},
    },
    visualMagnitude: 7.81,
    bvColour: -0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.71649832),
        dec: Angle.Degrees(-57.63714231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84534"},
        {"Hipparcos Number", "HIP 47736"},
        {"Smithsonian Astrophysical Observation", "SAO 237274"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.97247594),
        dec: Angle.Degrees(-57.63679122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225033"},
        {"Hipparcos Number", "HIP 218"},
        {"Smithsonian Astrophysical Observation", "SAO 231905"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.67974974),
        dec: Angle.Degrees(-57.63363086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76113"},
        {"Hipparcos Number", "HIP 43499"},
        {"Celescope Catalog", "CEL 3017"},
        {"Geneva Identification System", "GEN# +1.00076113"},
        {"Smithsonian Astrophysical Observation", "SAO 236339"},
        {"Wilson Evans Batten Catalogue", "WEB 8383"},
    },
    visualMagnitude: 5.59,
    bvColour: -0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.90221780),
        dec: Angle.Degrees(-57.63361532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110177"},
        {"Hipparcos Number", "HIP 61873"},
        {"Smithsonian Astrophysical Observation", "SAO 240141"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.19472357),
        dec: Angle.Degrees(-57.63136927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202027"},
        {"Hipparcos Number", "HIP 104965"},
        {"Geneva Identification System", "GEN# +1.00202027"},
        {"Smithsonian Astrophysical Observation", "SAO 246927"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.92122388),
        dec: Angle.Degrees(-57.63131807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24135"},
        {"Hipparcos Number", "HIP 17725"},
        {"Smithsonian Astrophysical Observation", "SAO 233273"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.93293198),
        dec: Angle.Degrees(-57.63018449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178943"},
        {"Hipparcos Number", "HIP 94495"},
        {"Smithsonian Astrophysical Observation", "SAO 245981"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.49201873),
        dec: Angle.Degrees(-57.62779275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100637"},
        {"Hipparcos Number", "HIP 56442"},
        {"Smithsonian Astrophysical Observation", "SAO 239180"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.58516002),
        dec: Angle.Degrees(-57.62728067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220262"},
        {"Hipparcos Number", "HIP 115429"},
        {"Geneva Identification System", "GEN# +1.00220262"},
        {"Smithsonian Astrophysical Observation", "SAO 247846"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.72669506),
        dec: Angle.Degrees(-57.62497741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181591"},
        {"Hipparcos Number", "HIP 95394"},
        {"Geneva Identification System", "GEN# +1.00181591"},
        {"Smithsonian Astrophysical Observation", "SAO 246068"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.08494083),
        dec: Angle.Degrees(-57.62462384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201452"},
        {"Hipparcos Number", "HIP 104662"},
        {"Smithsonian Astrophysical Observation", "SAO 246899"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.00111718),
        dec: Angle.Degrees(-57.62381461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118520"},
        {"Hipparcos Number", "HIP 66575"},
        {"Geneva Identification System", "GEN# +1.00118520J"},
        {"Smithsonian Astrophysical Observation", "SAO 241026"},
    },
    visualMagnitude: 6.00,
    bvColour: 1.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.70401592),
        dec: Angle.Degrees(-57.62270235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183455"},
        {"Hipparcos Number", "HIP 96140"},
        {"Smithsonian Astrophysical Observation", "SAO 246149"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.22133122),
        dec: Angle.Degrees(-57.62257392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92382"},
        {"Hipparcos Number", "HIP 52087"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.775,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.65297454),
        dec: Angle.Degrees(-57.61923103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79420"},
        {"Hipparcos Number", "HIP 45119"},
        {"Celescope Catalog", "CEL 3215"},
        {"Geneva Identification System", "GEN# +1.00079420"},
        {"Smithsonian Astrophysical Observation", "SAO 236706"},
    },
    visualMagnitude: 7.57,
    bvColour: -0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.88454883),
        dec: Angle.Degrees(-57.61899217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86008"},
        {"Hipparcos Number", "HIP 48535"},
        {"Smithsonian Astrophysical Observation", "SAO 237469"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.48448982),
        dec: Angle.Degrees(-57.61811955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189971"},
        {"Hipparcos Number", "HIP 98983"},
        {"Renson", "Renson 52710"},
        {"Smithsonian Astrophysical Observation", "SAO 246427"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.42822653),
        dec: Angle.Degrees(-57.61743109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86136",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86136"},
    },
    visualMagnitude: 11.61,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.04085327),
        dec: Angle.Degrees(-57.61511538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91039"},
        {"Hipparcos Number", "HIP 51338"},
        {"Geneva Identification System", "GEN# +1.00091039"},
        {"Wilson Evans Batten Catalogue", "WEB 9376"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.29687808),
        dec: Angle.Degrees(-57.61340788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199691"},
        {"Hipparcos Number", "HIP 103750"},
        {"Smithsonian Astrophysical Observation", "SAO 246828"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.35942314),
        dec: Angle.Degrees(-57.61326648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118769"},
        {"Hipparcos Number", "HIP 66696"},
        {"Geneva Identification System", "GEN# +1.00118769"},
        {"Smithsonian Astrophysical Observation", "SAO 241049"},
        {"Wilson Evans Batten Catalogue", "WEB 11763"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.07769846),
        dec: Angle.Degrees(-57.61317475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206163"},
        {"Hipparcos Number", "HIP 107152"},
        {"Geneva Identification System", "GEN# +1.00206163"},
        {"Smithsonian Astrophysical Observation", "SAO 247138"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.756,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.56940833),
        dec: Angle.Degrees(-57.61299150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34091"},
        {"Hipparcos Number", "HIP 24171"},
        {"Geneva Identification System", "GEN# +1.00034091"},
        {"Smithsonian Astrophysical Observation", "SAO 233867"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.85661835),
        dec: Angle.Degrees(-57.61244862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143012"},
        {"Hipparcos Number", "HIP 78443"},
        {"Smithsonian Astrophysical Observation", "SAO 243239"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.21344114),
        dec: Angle.Degrees(-57.61117824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32507"},
        {"Hipparcos Number", "HIP 23252"},
        {"Smithsonian Astrophysical Observation", "SAO 233781"},
    },
    visualMagnitude: 8.04,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.05696492),
        dec: Angle.Degrees(-57.60778625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144860"},
        {"Hipparcos Number", "HIP 79298"},
        {"Smithsonian Astrophysical Observation", "SAO 243406"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.74712786),
        dec: Angle.Degrees(-57.60767238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90706"},
        {"Hipparcos Number", "HIP 51150"},
        {"Celescope Catalog", "CEL 3542"},
        {"Geneva Identification System", "GEN# +3.25810002"},
        {"Smithsonian Astrophysical Observation", "SAO 238072"},
        {"Wilson Evans Batten Catalogue", "WEB 9348"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.73194106),
        dec: Angle.Degrees(-57.60705065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53527"},
        {"Hipparcos Number", "HIP 33886"},
        {"Smithsonian Astrophysical Observation", "SAO 234874"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.898,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.50736409),
        dec: Angle.Degrees(-57.60205793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12707"},
        {"Hipparcos Number", "HIP 9549"},
        {"Geneva Identification System", "GEN# +1.00012707"},
        {"Smithsonian Astrophysical Observation", "SAO 232613"},
        {"Wilson Evans Batten Catalogue", "WEB 2002"},
    },
    visualMagnitude: 8.85,
    bvColour: -0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.67797921),
        dec: Angle.Degrees(-57.59484568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200462"},
        {"Hipparcos Number", "HIP 104150"},
        {"Smithsonian Astrophysical Observation", "SAO 246863"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.50813212),
        dec: Angle.Degrees(-57.59245347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151302"},
        {"Hipparcos Number", "HIP 82367"},
        {"Smithsonian Astrophysical Observation", "SAO 244169"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.45175039),
        dec: Angle.Degrees(-57.59070474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119256"},
        {"Hipparcos Number", "HIP 66975"},
        {"Geneva Identification System", "GEN# +1.00119256J"},
        {"Smithsonian Astrophysical Observation", "SAO 241111"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.90119664),
        dec: Angle.Degrees(-57.58994325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83312",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83312"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.855,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.39834692),
        dec: Angle.Degrees(-57.58776477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -253.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75746"},
        {"Hipparcos Number", "HIP 43292"},
        {"Geneva Identification System", "GEN# +1.00075746"},
        {"Smithsonian Astrophysical Observation", "SAO 236308"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.862,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.28377339),
        dec: Angle.Degrees(-57.58765342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24061",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24061"},
        {"Geneva Identification System", "GEN# -0.05700752"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.54694011),
        dec: Angle.Degrees(-57.58666567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5548"},
        {"Hipparcos Number", "HIP 4398"},
        {"Geneva Identification System", "GEN# +1.00005548"},
        {"Smithsonian Astrophysical Observation", "SAO 232229"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.09573326),
        dec: Angle.Degrees(-57.58611996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141648"},
        {"Hipparcos Number", "HIP 77786"},
        {"Smithsonian Astrophysical Observation", "SAO 243070"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.25351283),
        dec: Angle.Degrees(-57.58420796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95749"},
        {"Hipparcos Number", "HIP 53930"},
        {"Geneva Identification System", "GEN# +1.00095749"},
        {"Smithsonian Astrophysical Observation", "SAO 238704"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.53427591),
        dec: Angle.Degrees(-57.58323949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36905",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36905"},
        {"Smithsonian Astrophysical Observation", "SAO 235332"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.81700009),
        dec: Angle.Degrees(-57.58090080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120400"},
        {"Hipparcos Number", "HIP 67566"},
        {"Geneva Identification System", "GEN# +1.00120400"},
        {"Smithsonian Astrophysical Observation", "SAO 241219"},
        {"Wilson Evans Batten Catalogue", "WEB 11882"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.68456116),
        dec: Angle.Degrees(-57.58049802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151688"},
        {"Hipparcos Number", "HIP 82528"},
        {"Smithsonian Astrophysical Observation", "SAO 244208"},
    },
    visualMagnitude: 7.14,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.03748389),
        dec: Angle.Degrees(-57.58030646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80126"},
        {"Hipparcos Number", "HIP 45437"},
        {"Geneva Identification System", "GEN# +1.00080126"},
        {"Smithsonian Astrophysical Observation", "SAO 236777"},
    },
    visualMagnitude: 6.32,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.89470968),
        dec: Angle.Degrees(-57.57776219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74697"},
        {"Hipparcos Number", "HIP 42755"},
        {"Smithsonian Astrophysical Observation", "SAO 236216"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.69998821),
        dec: Angle.Degrees(-57.57758172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52063"},
        {"Hipparcos Number", "HIP 33371"},
        {"Geneva Identification System", "GEN# +1.00052063"},
        {"Smithsonian Astrophysical Observation", "SAO 234799"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.09684299),
        dec: Angle.Degrees(-57.57594236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -161.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102188"},
        {"Hipparcos Number", "HIP 57331"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.755,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.32300292),
        dec: Angle.Degrees(-57.57485717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -197.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198910"},
        {"Hipparcos Number", "HIP 103339"},
        {"Geneva Identification System", "GEN# +1.00198910"},
        {"Smithsonian Astrophysical Observation", "SAO 246796"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.04020500),
        dec: Angle.Degrees(-57.56987051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84676"},
        {"Hipparcos Number", "HIP 47826"},
        {"Smithsonian Astrophysical Observation", "SAO 237297"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.22370445),
        dec: Angle.Degrees(-57.56920832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211055"},
        {"Hipparcos Number", "HIP 109955"},
        {"Smithsonian Astrophysical Observation", "SAO 247382"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.03406340),
        dec: Angle.Degrees(-57.56804226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52541",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52541"},
    },
    visualMagnitude: 10.90,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.13887007),
        dec: Angle.Degrees(-57.56801746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146957"},
        {"Hipparcos Number", "HIP 80178"},
        {"Smithsonian Astrophysical Observation", "SAO 243689"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.51309016),
        dec: Angle.Degrees(-57.56747838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145417"},
        {"Hipparcos Number", "HIP 79537"},
        {"Cincinnati Publication", "Ci 20 971"},
        {"Geneva Identification System", "GEN# +1.00145417"},
        {"Smithsonian Astrophysical Observation", "SAO 243462"},
        {"Wilson Evans Batten Catalogue", "WEB 13463"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.815,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.45619759),
        dec: Angle.Degrees(-57.56708117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -853.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1410.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187807"},
        {"Hipparcos Number", "HIP 97993"},
        {"Geneva Identification System", "GEN# +1.00187807"},
        {"Smithsonian Astrophysical Observation", "SAO 246331"},
        {"Wilson Evans Batten Catalogue", "WEB 17250"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.72772983),
        dec: Angle.Degrees(-57.56687779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101701"},
        {"Hipparcos Number", "HIP 57054"},
        {"Smithsonian Astrophysical Observation", "SAO 239299"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.44820167),
        dec: Angle.Degrees(-57.56611202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91570"},
        {"Hipparcos Number", "HIP 51650"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.28670764),
        dec: Angle.Degrees(-57.56561076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93203"},
        {"Hipparcos Number", "HIP 52538"},
        {"Geneva Identification System", "GEN# +1.00093203"},
        {"Smithsonian Astrophysical Observation", "SAO 238416"},
        {"Wilson Evans Batten Catalogue", "WEB 9570"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.13624077),
        dec: Angle.Degrees(-57.56537504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101763"},
        {"Hipparcos Number", "HIP 57097"},
        {"Smithsonian Astrophysical Observation", "SAO 239306"},
    },
    visualMagnitude: 7.08,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.57016533),
        dec: Angle.Degrees(-57.56510753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117171"},
        {"Hipparcos Number", "HIP 65842"},
        {"Smithsonian Astrophysical Observation", "SAO 240888"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.45188320),
        dec: Angle.Degrees(-57.56407514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105271"},
        {"Hipparcos Number", "HIP 59114"},
        {"Smithsonian Astrophysical Observation", "SAO 239680"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.82733516),
        dec: Angle.Degrees(-57.56401449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153644"},
        {"Hipparcos Number", "HIP 83502"},
        {"Smithsonian Astrophysical Observation", "SAO 244394"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.98945590),
        dec: Angle.Degrees(-57.56305873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216138"},
        {"Hipparcos Number", "HIP 112865"},
        {"Smithsonian Astrophysical Observation", "SAO 247620"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.84476370),
        dec: Angle.Degrees(-57.55768708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91942"},
        {"Hipparcos Number", "HIP 51849"},
        {"Geneva Identification System", "GEN# +1.00091942"},
        {"Smithsonian Astrophysical Observation", "SAO 238222"},
        {"Wilson Evans Batten Catalogue", "WEB 9446"},
    },
    visualMagnitude: 4.45,
    bvColour: 1.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.89714422),
        dec: Angle.Degrees(-57.55763551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18711"},
        {"Hipparcos Number", "HIP 13823"},
        {"Smithsonian Astrophysical Observation", "SAO 232953"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.47709511),
        dec: Angle.Degrees(-57.55759038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78897"},
        {"Hipparcos Number", "HIP 44845"},
        {"Smithsonian Astrophysical Observation", "SAO 236650"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.05517827),
        dec: Angle.Degrees(-57.55573830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23708",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23708"},
        {"Geneva Identification System", "GEN# -0.05700737"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.44753216),
        dec: Angle.Degrees(-57.55412256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 118.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33409"},
        {"Hipparcos Number", "HIP 23779"},
        {"Geneva Identification System", "GEN# +1.00033409"},
        {"Smithsonian Astrophysical Observation", "SAO 233828"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.65652398),
        dec: Angle.Degrees(-57.55232833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94909"},
        {"Hipparcos Number", "HIP 53479"},
        {"Geneva Identification System", "GEN# +1.00094909A"},
        {"Smithsonian Astrophysical Observation", "SAO 238613"},
        {"Wilson Evans Batten Catalogue", "WEB 9708"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.10196455),
        dec: Angle.Degrees(-57.55135538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21413"},
        {"Hipparcos Number", "HIP 15867"},
        {"Geneva Identification System", "GEN# +1.00021413"},
        {"Smithsonian Astrophysical Observation", "SAO 233109"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.09793759),
        dec: Angle.Degrees(-57.55114960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202360"},
        {"Hipparcos Number", "HIP 105110"},
        {"Smithsonian Astrophysical Observation", "SAO 246946"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.37486813),
        dec: Angle.Degrees(-57.55071819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22804",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22804"},
        {"Smithsonian Astrophysical Observation", "SAO 233730"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.58559044),
        dec: Angle.Degrees(-57.55066502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55042",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Innes' star"},
        {"Henry Draper", "HD 304043"},
        {"Hipparcos Number", "HIP 55042"},
        {"Cincinnati Publication", "Ci 20 624"},
        {"Geneva Identification System", "GEN# +9.86192072"},
    },
    visualMagnitude: 11.66,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.01203145),
        dec: Angle.Degrees(-57.55053464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2465.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1179.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88068"},
        {"Hipparcos Number", "HIP 49606"},
        {"Geneva Identification System", "GEN# +1.00088068"},
        {"Renson", "Renson 25210"},
        {"Smithsonian Astrophysical Observation", "SAO 237713"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.87920964),
        dec: Angle.Degrees(-57.54993988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93444"},
        {"Hipparcos Number", "HIP 52661"},
        {"Geneva Identification System", "GEN# +1.00093444"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.825,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.52436746),
        dec: Angle.Degrees(-57.54754096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186152"},
        {"Hipparcos Number", "HIP 97252"},
        {"Geneva Identification System", "GEN# +1.00186152"},
        {"Smithsonian Astrophysical Observation", "SAO 246255"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.48078129),
        dec: Angle.Degrees(-57.54720079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56116"},
        {"Hipparcos Number", "HIP 34811"},
        {"Smithsonian Astrophysical Observation", "SAO 235011"},
    },
    visualMagnitude: 8.81,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.09536440),
        dec: Angle.Degrees(-57.54635658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74341"},
        {"Hipparcos Number", "HIP 42579"},
        {"Geneva Identification System", "GEN# +1.00074341J"},
        {"Smithsonian Astrophysical Observation", "SAO 236179"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.18146468),
        dec: Angle.Degrees(-57.54553217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160720"},
        {"Hipparcos Number", "HIP 86871"},
        {"Geneva Identification System", "GEN# +1.00160720J"},
        {"Smithsonian Astrophysical Observation", "SAO 244989"},
    },
    visualMagnitude: 5.97,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.23268300),
        dec: Angle.Degrees(-57.54551015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21473",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21473"},
        {"Geneva Identification System", "GEN# -0.05700680"},
        {"Smithsonian Astrophysical Observation", "SAO 233591"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.16815858),
        dec: Angle.Degrees(-57.54462979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73288"},
        {"Hipparcos Number", "HIP 42102"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.805,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.72752208),
        dec: Angle.Degrees(-57.54360464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80230"},
        {"Hipparcos Number", "HIP 45496"},
        {"Geneva Identification System", "GEN# +1.00080230"},
        {"Smithsonian Astrophysical Observation", "SAO 236787"},
        {"Wilson Evans Batten Catalogue", "WEB 8652"},
    },
    visualMagnitude: 4.34,
    bvColour: 1.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.05042678),
        dec: Angle.Degrees(-57.54143764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135672"},
        {"Hipparcos Number", "HIP 74953"},
        {"Smithsonian Astrophysical Observation", "SAO 242401"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.74148400),
        dec: Angle.Degrees(-57.54098011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47699"},
        {"Hipparcos Number", "HIP 31569"},
        {"Geneva Identification System", "GEN# +1.00047699"},
        {"Smithsonian Astrophysical Observation", "SAO 234607"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.11321072),
        dec: Angle.Degrees(-57.53938630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114274"},
        {"Hipparcos Number", "HIP 64287"},
        {"Smithsonian Astrophysical Observation", "SAO 240617"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.62825212),
        dec: Angle.Degrees(-57.53762364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129512"},
        {"Hipparcos Number", "HIP 72118"},
        {"Geneva Identification System", "GEN# +1.00129512"},
        {"Smithsonian Astrophysical Observation", "SAO 241968"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.29174642),
        dec: Angle.Degrees(-57.53675177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19153",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19153"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.58688208),
        dec: Angle.Degrees(-57.53463521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112701"},
        {"Hipparcos Number", "HIP 63395"},
        {"Geneva Identification System", "GEN# +1.00112701"},
        {"Smithsonian Astrophysical Observation", "SAO 240448"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.86264477),
        dec: Angle.Degrees(-57.53138153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109299"},
        {"Hipparcos Number", "HIP 61333"},
        {"Smithsonian Astrophysical Observation", "SAO 240064"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.50972580),
        dec: Angle.Degrees(-57.53129825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100478"},
        {"Hipparcos Number", "HIP 56365"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.856,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.31388263),
        dec: Angle.Degrees(-57.52782675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208523"},
        {"Hipparcos Number", "HIP 108472"},
        {"Smithsonian Astrophysical Observation", "SAO 247248"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.61486781),
        dec: Angle.Degrees(-57.52684518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19265"},
        {"Hipparcos Number", "HIP 14227"},
        {"Smithsonian Astrophysical Observation", "SAO 232976"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.86683827),
        dec: Angle.Degrees(-57.52519089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191095"},
        {"Hipparcos Number", "HIP 99453"},
        {"Geneva Identification System", "GEN# +1.00191095"},
        {"Smithsonian Astrophysical Observation", "SAO 246470"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.78089426),
        dec: Angle.Degrees(-57.52415476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169836"},
        {"Hipparcos Number", "HIP 90664"},
        {"Fundamental Katalog 5th Edition", "FK5 3464"},
        {"Geneva Identification System", "GEN# +1.00169836J"},
        {"Smithsonian Astrophysical Observation", "SAO 245510"},
    },
    visualMagnitude: 5.74,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.48615404),
        dec: Angle.Degrees(-57.52308279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38236",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38236"},
    },
    visualMagnitude: 10.93,
    bvColour: 1.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.49881945),
        dec: Angle.Degrees(-34.49590588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -145.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112782"},
        {"Hipparcos Number", "HIP 63438"},
        {"Geneva Identification System", "GEN# +1.00112782"},
        {"Smithsonian Astrophysical Observation", "SAO 240461"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.99427815),
        dec: Angle.Degrees(-57.52040897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83897"},
        {"Hipparcos Number", "HIP 47393"},
        {"Smithsonian Astrophysical Observation", "SAO 237194"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.84678703),
        dec: Angle.Degrees(-57.52038061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218148"},
        {"Hipparcos Number", "HIP 114091"},
        {"Smithsonian Astrophysical Observation", "SAO 247729"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.61783727),
        dec: Angle.Degrees(-57.51547791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156333"},
        {"Hipparcos Number", "HIP 84839"},
        {"Geneva Identification System", "GEN# +1.00156333"},
        {"Smithsonian Astrophysical Observation", "SAO 244636"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.09651116),
        dec: Angle.Degrees(-57.51026400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211726"},
        {"Hipparcos Number", "HIP 110311"},
        {"Geneva Identification System", "GEN# +1.00211726"},
        {"Smithsonian Astrophysical Observation", "SAO 247410"},
    },
    visualMagnitude: 6.41,
    bvColour: 1.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.15102417),
        dec: Angle.Degrees(-57.50976173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89756"},
        {"Hipparcos Number", "HIP 50576"},
        {"Geneva Identification System", "GEN# +1.00089756"},
        {"Smithsonian Astrophysical Observation", "SAO 237925"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.96980154),
        dec: Angle.Degrees(-57.50711283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118425"},
        {"Hipparcos Number", "HIP 66528"},
        {"Smithsonian Astrophysical Observation", "SAO 241016"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.54762839),
        dec: Angle.Degrees(-57.50595282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 814"},
        {"Hipparcos Number", "HIP 992"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.08222761),
        dec: Angle.Degrees(-57.50592437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220495"},
        {"Hipparcos Number", "HIP 115578"},
        {"Smithsonian Astrophysical Observation", "SAO 247862"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.18050911),
        dec: Angle.Degrees(-57.50582932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99768"},
        {"Hipparcos Number", "HIP 55971"},
        {"Smithsonian Astrophysical Observation", "SAO 239094"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.04702893),
        dec: Angle.Degrees(-57.50578626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112926"},
        {"Hipparcos Number", "HIP 63517"},
        {"Smithsonian Astrophysical Observation", "SAO 240475"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.23872171),
        dec: Angle.Degrees(-57.50496442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221819"},
        {"Hipparcos Number", "HIP 116444"},
        {"Geneva Identification System", "GEN# +1.00221819"},
        {"Smithsonian Astrophysical Observation", "SAO 247942"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.93594723),
        dec: Angle.Degrees(-57.50461186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104430"},
        {"Hipparcos Number", "HIP 58642"},
        {"Geneva Identification System", "GEN# +1.00104430"},
        {"Smithsonian Astrophysical Observation", "SAO 239589"},
        {"Wilson Evans Batten Catalogue", "WEB 10461"},
    },
    visualMagnitude: 6.16,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.37190077),
        dec: Angle.Degrees(-57.50373759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66529",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66529"},
    },
    visualMagnitude: 11.02,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.55193395),
        dec: Angle.Degrees(-57.50161329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172377"},
        {"Hipparcos Number", "HIP 91808"},
        {"Geneva Identification System", "GEN# +1.00172377"},
        {"Smithsonian Astrophysical Observation", "SAO 245648"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.745,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.79146483),
        dec: Angle.Degrees(-57.49918983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158112"},
        {"Hipparcos Number", "HIP 85697"},
        {"Smithsonian Astrophysical Observation", "SAO 244798"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.69152355),
        dec: Angle.Degrees(-57.49657849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127087"},
        {"Hipparcos Number", "HIP 71013"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.85009073),
        dec: Angle.Degrees(-57.49605482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221773"},
        {"Hipparcos Number", "HIP 116407"},
        {"Smithsonian Astrophysical Observation", "SAO 247938"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.83023855),
        dec: Angle.Degrees(-57.49501943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168318"},
        {"Hipparcos Number", "HIP 90046"},
        {"Smithsonian Astrophysical Observation", "SAO 245430"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.872,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.60559873),
        dec: Angle.Degrees(-57.49427045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209884"},
        {"Hipparcos Number", "HIP 109267"},
        {"Smithsonian Astrophysical Observation", "SAO 247319"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.05656331),
        dec: Angle.Degrees(-57.49234842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56216"},
        {"Hipparcos Number", "HIP 34855"},
        {"Geneva Identification System", "GEN# +1.00056216"},
        {"Smithsonian Astrophysical Observation", "SAO 235017"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.19307581),
        dec: Angle.Degrees(-57.49069461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58069"},
        {"Hipparcos Number", "HIP 35581"},
        {"Smithsonian Astrophysical Observation", "SAO 235122"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.14579185),
        dec: Angle.Degrees(-57.48917652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 675"},
        {"Hipparcos Number", "HIP 883"},
        {"Smithsonian Astrophysical Observation", "SAO 231959"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.69755040),
        dec: Angle.Degrees(-57.48628559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195210"},
        {"Hipparcos Number", "HIP 101366"},
        {"Smithsonian Astrophysical Observation", "SAO 246625"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.17488253),
        dec: Angle.Degrees(-57.48519441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95201"},
        {"Hipparcos Number", "HIP 53657"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.66065525),
        dec: Angle.Degrees(-57.48336946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 142.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8558"},
        {"Hipparcos Number", "HIP 6485"},
        {"Geneva Identification System", "GEN# +1.00008558"},
        {"Smithsonian Astrophysical Observation", "SAO 232406"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.83814154),
        dec: Angle.Degrees(-57.48065865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65852"},
        {"Hipparcos Number", "HIP 38904"},
        {"Celescope Catalog", "CEL 2120"},
        {"Geneva Identification System", "GEN# +1.00065852"},
        {"Smithsonian Astrophysical Observation", "SAO 235645"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.42700013),
        dec: Angle.Degrees(-57.47917721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74404"},
        {"Hipparcos Number", "HIP 42622"},
        {"Smithsonian Astrophysical Observation", "SAO 236185"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.29179208),
        dec: Angle.Degrees(-57.47843638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191487"},
        {"Hipparcos Number", "HIP 99626"},
        {"Geneva Identification System", "GEN# +1.00191487"},
        {"Smithsonian Astrophysical Observation", "SAO 246487"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.28267472),
        dec: Angle.Degrees(-57.47829894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222638"},
        {"Hipparcos Number", "HIP 116963"},
        {"Renson", "Renson 61030"},
        {"Smithsonian Astrophysical Observation", "SAO 247991"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.64148525),
        dec: Angle.Degrees(-57.47799398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122538"},
        {"Hipparcos Number", "HIP 68743"},
        {"Geneva Identification System", "GEN# +1.00122538"},
        {"Smithsonian Astrophysical Observation", "SAO 241412"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.07160495),
        dec: Angle.Degrees(-57.47373259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33262"},
        {"Hipparcos Number", "HIP 23693"},
        {"Fundamental Katalog 5th Edition", "FK5 189"},
        {"Geneva Identification System", "GEN# +1.00033262"},
        {"Smithsonian Astrophysical Observation", "SAO 233822"},
        {"Wilson Evans Batten Catalogue", "WEB 4621"},
    },
    visualMagnitude: 4.71,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.37787652),
        dec: Angle.Degrees(-57.47298928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 117.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 750"},
        {"Hipparcos Number", "HIP 934"},
        {"Geneva Identification System", "GEN# +1.00000750"},
        {"Smithsonian Astrophysical Observation", "SAO 231963"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.89853096),
        dec: Angle.Degrees(-57.47238652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 135.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112269"},
        {"Hipparcos Number", "HIP 63136"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.04736975),
        dec: Angle.Degrees(-57.47044569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -163.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149499"},
        {"Hipparcos Number", "HIP 81478"},
        {"Smithsonian Astrophysical Observation", "SAO 244010"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.62905677),
        dec: Angle.Degrees(-57.46985080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 116.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93662"},
        {"Hipparcos Number", "HIP 52797"},
        {"Geneva Identification System", "GEN# +1.00093662"},
        {"Smithsonian Astrophysical Observation", "SAO 238480"},
    },
    visualMagnitude: 6.29,
    bvColour: 1.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.91003927),
        dec: Angle.Degrees(-57.46741767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78724"},
        {"Hipparcos Number", "HIP 44757"},
        {"Geneva Identification System", "GEN# +1.00078724"},
        {"Smithsonian Astrophysical Observation", "SAO 236623"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.82792803),
        dec: Angle.Degrees(-57.46379524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4150"},
        {"Hipparcos Number", "HIP 3405"},
        {"Fundamental Katalog 5th Edition", "FK5 23"},
        {"Geneva Identification System", "GEN# +1.00004150A"},
        {"Renson", "Renson 1130"},
        {"Smithsonian Astrophysical Observation", "SAO 232162"},
        {"Wilson Evans Batten Catalogue", "WEB 602"},
    },
    visualMagnitude: 4.36,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.83851683),
        dec: Angle.Degrees(-57.46309763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198209"},
        {"Hipparcos Number", "HIP 102937"},
        {"Renson", "Renson 55180"},
        {"Smithsonian Astrophysical Observation", "SAO 246757"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.83427028),
        dec: Angle.Degrees(-57.46246651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70068"},
        {"Hipparcos Number", "HIP 40572"},
        {"Smithsonian Astrophysical Observation", "SAO 235861"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.24829858),
        dec: Angle.Degrees(-57.46232519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92504"},
        {"Henry Draper 2", "HD 92504A"},
        {"Hipparcos Number", "HIP 52182"},
        {"Celescope Catalog", "CEL 3624"},
        {"Geneva Identification System", "GEN# +1.00092504"},
        {"Smithsonian Astrophysical Observation", "SAO 238316"},
        {"Wilson Evans Batten Catalogue", "WEB 9508"},
    },
    visualMagnitude: 8.42,
    bvColour: -0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.90364985),
        dec: Angle.Degrees(-57.46129782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77491"},
        {"Hipparcos Number", "HIP 44206"},
        {"Smithsonian Astrophysical Observation", "SAO 236494"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.06917315),
        dec: Angle.Degrees(-57.46091788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150915"},
        {"Hipparcos Number", "HIP 82173"},
        {"Smithsonian Astrophysical Observation", "SAO 244136"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.83298897),
        dec: Angle.Degrees(-57.46079144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34285",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34285"},
        {"Geneva Identification System", "GEN# -0.05701139"},
        {"Wilson Evans Batten Catalogue", "WEB 6868"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.62105269),
        dec: Angle.Degrees(-57.45976841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 691.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25862"},
        {"Hipparcos Number", "HIP 18878"},
        {"Geneva Identification System", "GEN# +1.00025862"},
        {"Smithsonian Astrophysical Observation", "SAO 233376"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.70687496),
        dec: Angle.Degrees(-57.45947259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37629"},
        {"Hipparcos Number", "HIP 26323"},
        {"Smithsonian Astrophysical Observation", "SAO 234047"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.09030398),
        dec: Angle.Degrees(-57.45811661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215206"},
        {"Hipparcos Number", "HIP 112290"},
        {"Smithsonian Astrophysical Observation", "SAO 247562"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.16557751),
        dec: Angle.Degrees(-57.45785930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128214"},
        {"Hipparcos Number", "HIP 71526"},
        {"Geneva Identification System", "GEN# +1.00128214"},
        {"Smithsonian Astrophysical Observation", "SAO 241854"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.43581821),
        dec: Angle.Degrees(-57.45765498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120595"},
        {"Hipparcos Number", "HIP 67689"},
        {"Geneva Identification System", "GEN# +1.00120595J"},
        {"Smithsonian Astrophysical Observation", "SAO 241237"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.99664140),
        dec: Angle.Degrees(-57.45633221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115483"},
        {"Hipparcos Number", "HIP 64934"},
        {"Geneva Identification System", "GEN# +1.00115483"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.65152808),
        dec: Angle.Degrees(-57.45426907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139913"},
        {"Hipparcos Number", "HIP 77029"},
        {"Geneva Identification System", "GEN# +1.00139913"},
        {"Smithsonian Astrophysical Observation", "SAO 242871"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.91810255),
        dec: Angle.Degrees(-57.45203372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29015"},
        {"Hipparcos Number", "HIP 21056"},
        {"Geneva Identification System", "GEN# +1.00029015"},
        {"Smithsonian Astrophysical Observation", "SAO 233546"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.70176324),
        dec: Angle.Degrees(-57.45013235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148939"},
        {"Hipparcos Number", "HIP 81171"},
        {"Smithsonian Astrophysical Observation", "SAO 243958"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.68366897),
        dec: Angle.Degrees(-57.44967941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158947"},
        {"Hipparcos Number", "HIP 86083"},
        {"Smithsonian Astrophysical Observation", "SAO 244868"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.88284206),
        dec: Angle.Degrees(-57.44908459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57807"},
        {"Hipparcos Number", "HIP 35498"},
        {"Smithsonian Astrophysical Observation", "SAO 235104"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.88746927),
        dec: Angle.Degrees(-57.44895488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161192"},
        {"Hipparcos Number", "HIP 87088"},
        {"Geneva Identification System", "GEN# +1.00161192"},
        {"Smithsonian Astrophysical Observation", "SAO 245026"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.92553169),
        dec: Angle.Degrees(-57.44876869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118910"},
        {"Hipparcos Number", "HIP 66793"},
        {"Geneva Identification System", "GEN# +1.00118910"},
        {"Smithsonian Astrophysical Observation", "SAO 241069"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.34579302),
        dec: Angle.Degrees(-57.44786389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -138.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171515"},
        {"Hipparcos Number", "HIP 91409"},
        {"Geneva Identification System", "GEN# +1.00171515"},
        {"Smithsonian Astrophysical Observation", "SAO 245600"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.64318352),
        dec: Angle.Degrees(-57.44776000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166972"},
        {"Hipparcos Number", "HIP 89558"},
        {"Geneva Identification System", "GEN# +1.00166972"},
        {"Smithsonian Astrophysical Observation", "SAO 245359"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.11896423),
        dec: Angle.Degrees(-57.44707595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60271"},
        {"Hipparcos Number", "HIP 36477"},
        {"Smithsonian Astrophysical Observation", "SAO 235253"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.58802391),
        dec: Angle.Degrees(-57.44697429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 182.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34984"},
        {"Hipparcos Number", "HIP 24706"},
        {"Smithsonian Astrophysical Observation", "SAO 233920"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.49364198),
        dec: Angle.Degrees(-57.44522597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89533"},
        {"Hipparcos Number", "HIP 50468"},
        {"Geneva Identification System", "GEN# +1.00089533"},
        {"Smithsonian Astrophysical Observation", "SAO 237895"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.57414233),
        dec: Angle.Degrees(-57.44402529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205848"},
        {"Hipparcos Number", "HIP 106986"},
        {"Smithsonian Astrophysical Observation", "SAO 247125"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.02252187),
        dec: Angle.Degrees(-57.44190287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38303"},
        {"Hipparcos Number", "HIP 26772"},
        {"Renson", "Renson 10310"},
        {"Smithsonian Astrophysical Observation", "SAO 234092"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.30458133),
        dec: Angle.Degrees(-57.44120554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111090"},
        {"Hipparcos Number", "HIP 62416"},
        {"Smithsonian Astrophysical Observation", "SAO 240250"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.87554146),
        dec: Angle.Degrees(-57.44112083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49377"},
        {"Hipparcos Number", "HIP 32307"},
        {"Geneva Identification System", "GEN# +1.00049377"},
        {"Smithsonian Astrophysical Observation", "SAO 234688"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.17869446),
        dec: Angle.Degrees(-57.44043220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188623"},
        {"Hipparcos Number", "HIP 98364"},
        {"Geneva Identification System", "GEN# +1.00188623"},
        {"Smithsonian Astrophysical Observation", "SAO 246364"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.77119633),
        dec: Angle.Degrees(-57.44035998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133507"},
        {"Hipparcos Number", "HIP 73989"},
        {"Geneva Identification System", "GEN# +1.00133507"},
        {"Smithsonian Astrophysical Observation", "SAO 242230"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.81072792),
        dec: Angle.Degrees(-57.43964097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102279"},
        {"Hipparcos Number", "HIP 57404"},
        {"Smithsonian Astrophysical Observation", "SAO 239360"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.53213089),
        dec: Angle.Degrees(-57.43948222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156049"},
        {"Hipparcos Number", "HIP 84686"},
        {"Renson", "Renson 44020"},
        {"Smithsonian Astrophysical Observation", "SAO 244605"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.68800330),
        dec: Angle.Degrees(-57.43899412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130264"},
        {"Hipparcos Number", "HIP 72492"},
        {"Geneva Identification System", "GEN# +1.00130264"},
        {"Smithsonian Astrophysical Observation", "SAO 242033"},
        {"Wilson Evans Batten Catalogue", "WEB 12461"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.34833713),
        dec: Angle.Degrees(-57.43797753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17599"},
        {"Hipparcos Number", "HIP 12997"},
        {"Smithsonian Astrophysical Observation", "SAO 232892"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.78124379),
        dec: Angle.Degrees(-57.43764408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 89.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47951"},
        {"Hipparcos Number", "HIP 31664"},
        {"Smithsonian Astrophysical Observation", "SAO 234626"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.40701415),
        dec: Angle.Degrees(-57.43753866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120559"},
        {"Hipparcos Number", "HIP 67655"},
        {"Cincinnati Publication", "Ci 20 815"},
        {"Geneva Identification System", "GEN# +1.00120559"},
        {"Smithsonian Astrophysical Observation", "SAO 241230"},
        {"Wilson Evans Batten Catalogue", "WEB 11897"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.91996891),
        dec: Angle.Degrees(-57.43465194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -360.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -412.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65710"},
        {"Hipparcos Number", "HIP 38844"},
        {"Fundamental Katalog 5th Edition", "FK5 4716"},
        {"Geneva Identification System", "GEN# +1.00065710"},
        {"Smithsonian Astrophysical Observation", "SAO 235639"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.23909965),
        dec: Angle.Degrees(-57.43065728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29532"},
        {"Hipparcos Number", "HIP 21406"},
        {"Geneva Identification System", "GEN# +1.00029532"},
        {"Smithsonian Astrophysical Observation", "SAO 233586"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.92181419),
        dec: Angle.Degrees(-57.42615149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206576"},
        {"Hipparcos Number", "HIP 107377"},
        {"Smithsonian Astrophysical Observation", "SAO 247160"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.22637890),
        dec: Angle.Degrees(-57.42527573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 188.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214632"},
        {"Hipparcos Number", "HIP 111967"},
        {"Fundamental Katalog 5th Edition", "FK5 3816"},
        {"Geneva Identification System", "GEN# +1.00214632"},
        {"Smithsonian Astrophysical Observation", "SAO 247544"},
    },
    visualMagnitude: 5.98,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.20357013),
        dec: Angle.Degrees(-57.42230600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96968"},
        {"Hipparcos Number", "HIP 54499"},
        {"Geneva Identification System", "GEN# +1.00096968"},
        {"Smithsonian Astrophysical Observation", "SAO 238819"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.24696526),
        dec: Angle.Degrees(-57.41984957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138519"},
        {"Hipparcos Number", "HIP 76324"},
        {"Geneva Identification System", "GEN# +1.00138519"},
        {"Renson", "Renson 39440"},
        {"Smithsonian Astrophysical Observation", "SAO 242724"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.86152887),
        dec: Angle.Degrees(-57.41729301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15459"},
        {"Hipparcos Number", "HIP 11419"},
        {"Smithsonian Astrophysical Observation", "SAO 232775"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.80082430),
        dec: Angle.Degrees(-57.41491608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166816"},
        {"Hipparcos Number", "HIP 89504"},
        {"Geneva Identification System", "GEN# +1.00166816"},
        {"Smithsonian Astrophysical Observation", "SAO 245349"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.96813252),
        dec: Angle.Degrees(-57.41301259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157873"},
        {"Hipparcos Number", "HIP 85577"},
        {"Smithsonian Astrophysical Observation", "SAO 244780"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.32004696),
        dec: Angle.Degrees(-57.41175300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103400"},
        {"Hipparcos Number", "HIP 58041"},
        {"Geneva Identification System", "GEN# +1.00103400"},
        {"Smithsonian Astrophysical Observation", "SAO 239475"},
    },
    visualMagnitude: 6.05,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.54796472),
        dec: Angle.Degrees(-57.41019133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189123"},
        {"Hipparcos Number", "HIP 98574"},
        {"Smithsonian Astrophysical Observation", "SAO 246386"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.809,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.35008388),
        dec: Angle.Degrees(-57.41000380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -126.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217780"},
        {"Hipparcos Number", "HIP 113890"},
        {"Smithsonian Astrophysical Observation", "SAO 247704"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.96965649),
        dec: Angle.Degrees(-57.40979917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122537"},
        {"Hipparcos Number", "HIP 68741"},
        {"Geneva Identification System", "GEN# +1.00122537"},
        {"Smithsonian Astrophysical Observation", "SAO 241410"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.06434759),
        dec: Angle.Degrees(-57.40978221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133440"},
        {"Hipparcos Number", "HIP 73964"},
        {"Geneva Identification System", "GEN# +1.00133440"},
        {"Smithsonian Astrophysical Observation", "SAO 242225"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.73202774),
        dec: Angle.Degrees(-57.40897037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148904"},
        {"Hipparcos Number", "HIP 81154"},
        {"Smithsonian Astrophysical Observation", "SAO 243954"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.61834763),
        dec: Angle.Degrees(-57.40806564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138109"},
        {"Hipparcos Number", "HIP 76113"},
        {"Smithsonian Astrophysical Observation", "SAO 242668"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.17919607),
        dec: Angle.Degrees(-57.40774070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19424"},
        {"Hipparcos Number", "HIP 14341"},
        {"Geneva Identification System", "GEN# +1.00019424"},
        {"Smithsonian Astrophysical Observation", "SAO 232990"},
        {"Wilson Evans Batten Catalogue", "WEB 2803"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.23641855),
        dec: Angle.Degrees(-57.40672695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86616"},
        {"Hipparcos Number", "HIP 48850"},
        {"Geneva Identification System", "GEN# +1.00086616"},
        {"Smithsonian Astrophysical Observation", "SAO 237541"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.45646367),
        dec: Angle.Degrees(-57.40483279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161191"},
        {"Hipparcos Number", "HIP 87077"},
        {"Fundamental Katalog 5th Edition", "FK5 5562"},
        {"Smithsonian Astrophysical Observation", "SAO 245024"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.90703142),
        dec: Angle.Degrees(-57.40406452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5322"},
        {"Hipparcos Number", "HIP 4254"},
        {"Smithsonian Astrophysical Observation", "SAO 232222"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.56228381),
        dec: Angle.Degrees(-57.40311311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216824"},
        {"Hipparcos Number", "HIP 113330"},
        {"Smithsonian Astrophysical Observation", "SAO 247653"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.27410228),
        dec: Angle.Degrees(-57.40103895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49264"},
        {"Hipparcos Number", "HIP 32253"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.02770723),
        dec: Angle.Degrees(-57.40018687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98807"},
        {"Hipparcos Number", "HIP 55477"},
        {"Smithsonian Astrophysical Observation", "SAO 238995"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.41946188),
        dec: Angle.Degrees(-57.39962558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135902"},
        {"Hipparcos Number", "HIP 75054"},
        {"Smithsonian Astrophysical Observation", "SAO 242421"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.05435683),
        dec: Angle.Degrees(-57.39795064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183120"},
        {"Hipparcos Number", "HIP 95994"},
        {"Smithsonian Astrophysical Observation", "SAO 246135"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.78267053),
        dec: Angle.Degrees(-57.39704030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36441",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36441"},
        {"Smithsonian Astrophysical Observation", "SAO 235245"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.48854510),
        dec: Angle.Degrees(-57.39461781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50624"},
        {"Hipparcos Number", "HIP 32837"},
        {"Smithsonian Astrophysical Observation", "SAO 234746"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.67481766),
        dec: Angle.Degrees(-57.38643812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4860"},
        {"Hipparcos Number", "HIP 3894"},
        {"Smithsonian Astrophysical Observation", "SAO 232201"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.48449543),
        dec: Angle.Degrees(-57.38624867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7582"},
        {"Hipparcos Number", "HIP 5822"},
        {"Smithsonian Astrophysical Observation", "SAO 232353"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.67257661),
        dec: Angle.Degrees(-57.38395872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86199"},
        {"Hipparcos Number", "HIP 48643"},
        {"Renson", "Renson 24640"},
        {"Smithsonian Astrophysical Observation", "SAO 237497"},
    },
    visualMagnitude: 6.74,
    bvColour: -0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.77510755),
        dec: Angle.Degrees(-57.38294665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94331"},
        {"Hipparcos Number", "HIP 53137"},
        {"Smithsonian Astrophysical Observation", "SAO 238550"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.04559193),
        dec: Angle.Degrees(-57.38092706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213670"},
        {"Hipparcos Number", "HIP 111426"},
        {"Smithsonian Astrophysical Observation", "SAO 247492"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.61514182),
        dec: Angle.Degrees(-57.37905161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88438",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88438"},
    },
    visualMagnitude: 12.73,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.83989057),
        dec: Angle.Degrees(-57.37669770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114528"},
        {"Hipparcos Number", "HIP 64418"},
        {"Smithsonian Astrophysical Observation", "SAO 240644"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.04074393),
        dec: Angle.Degrees(-57.37669754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181848"},
        {"Hipparcos Number", "HIP 95479"},
        {"Smithsonian Astrophysical Observation", "SAO 246082"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.32283088),
        dec: Angle.Degrees(-57.37595618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43133",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43133"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.79035526),
        dec: Angle.Degrees(-57.37551832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89201"},
        {"Hipparcos Number", "HIP 50272"},
        {"Geneva Identification System", "GEN# +1.00089201"},
        {"Smithsonian Astrophysical Observation", "SAO 237850"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.96923094),
        dec: Angle.Degrees(-57.37503532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40890"},
        {"Hipparcos Number", "HIP 28251"},
        {"Smithsonian Astrophysical Observation", "SAO 234230"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.54845804),
        dec: Angle.Degrees(-57.37277625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206381"},
        {"Hipparcos Number", "HIP 107277"},
        {"Smithsonian Astrophysical Observation", "SAO 247148"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.94231660),
        dec: Angle.Degrees(-57.36829352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11539"},
        {"Hipparcos Number", "HIP 8680"},
        {"Geneva Identification System", "GEN# +1.00011539"},
        {"Smithsonian Astrophysical Observation", "SAO 232550"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.92424143),
        dec: Angle.Degrees(-57.36523121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104822"},
        {"Hipparcos Number", "HIP 58856"},
        {"Smithsonian Astrophysical Observation", "SAO 239631"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.06570415),
        dec: Angle.Degrees(-57.36451921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133886"},
        {"Hipparcos Number", "HIP 74169"},
        {"Geneva Identification System", "GEN# +1.00133886"},
        {"Smithsonian Astrophysical Observation", "SAO 242260"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.32307329),
        dec: Angle.Degrees(-57.36292675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7329"},
        {"Hipparcos Number", "HIP 5635"},
        {"Smithsonian Astrophysical Observation", "SAO 232335"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.09052768),
        dec: Angle.Degrees(-57.36240226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81769"},
        {"Hipparcos Number", "HIP 46224"},
        {"Celescope Catalog", "CEL 3289"},
        {"Geneva Identification System", "GEN# +1.00081769"},
        {"Smithsonian Astrophysical Observation", "SAO 236955"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.36312810),
        dec: Angle.Degrees(-57.36230179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26523"},
        {"Hipparcos Number", "HIP 19327"},
        {"Geneva Identification System", "GEN# +1.00026523"},
        {"Smithsonian Astrophysical Observation", "SAO 233413"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.864,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.13091331),
        dec: Angle.Degrees(-57.36059106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -190.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110810"},
        {"Hipparcos Number", "HIP 62229"},
        {"Smithsonian Astrophysical Observation", "SAO 240214"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.31096071),
        dec: Angle.Degrees(-57.35768284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -201.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -130.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98025"},
        {"Hipparcos Number", "HIP 55003"},
        {"Celescope Catalog", "CEL 3868"},
        {"Geneva Identification System", "GEN# +1.00098025"},
        {"Smithsonian Astrophysical Observation", "SAO 238914"},
    },
    visualMagnitude: 6.42,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.92818077),
        dec: Angle.Degrees(-57.35586929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35376"},
        {"Hipparcos Number", "HIP 24968"},
        {"Smithsonian Astrophysical Observation", "SAO 233938"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.21819435),
        dec: Angle.Degrees(-57.35405525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204273"},
        {"Hipparcos Number", "HIP 106105"},
        {"Smithsonian Astrophysical Observation", "SAO 247047"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.39809608),
        dec: Angle.Degrees(-57.35238888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57555"},
        {"Hipparcos Number", "HIP 35374"},
        {"Smithsonian Astrophysical Observation", "SAO 235087"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.61300695),
        dec: Angle.Degrees(-57.35180934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109776"},
        {"Hipparcos Number", "HIP 61625"},
        {"Smithsonian Astrophysical Observation", "SAO 240097"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.46060694),
        dec: Angle.Degrees(-57.34995481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87238"},
        {"Hipparcos Number", "HIP 49160"},
        {"Geneva Identification System", "GEN# +1.00087238"},
        {"Smithsonian Astrophysical Observation", "SAO 237621"},
    },
    visualMagnitude: 6.20,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.49204300),
        dec: Angle.Degrees(-57.34984456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8178"},
        {"Hipparcos Number", "HIP 6235"},
        {"Fundamental Katalog 5th Edition", "FK5 4120"},
        {"Geneva Identification System", "GEN# +1.00008178"},
        {"Smithsonian Astrophysical Observation", "SAO 232381"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.99275507),
        dec: Angle.Degrees(-57.34924884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122415"},
        {"Hipparcos Number", "HIP 68667"},
        {"Smithsonian Astrophysical Observation", "SAO 241401"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.84783423),
        dec: Angle.Degrees(-57.34911951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65015"},
        {"Hipparcos Number", "HIP 38549"},
        {"Smithsonian Astrophysical Observation", "SAO 235600"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.40983627),
        dec: Angle.Degrees(-57.34907766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130335"},
        {"Hipparcos Number", "HIP 72544"},
        {"Geneva Identification System", "GEN# +1.00130335"},
        {"Renson", "Renson 37110"},
        {"Smithsonian Astrophysical Observation", "SAO 242039"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.46934163),
        dec: Angle.Degrees(-57.34654392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13906"},
        {"Hipparcos Number", "HIP 10362"},
        {"Smithsonian Astrophysical Observation", "SAO 232679"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.38977735),
        dec: Angle.Degrees(-57.34495879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6247"},
        {"Hipparcos Number", "HIP 4864"},
        {"Smithsonian Astrophysical Observation", "SAO 232270"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.63521970),
        dec: Angle.Degrees(-57.34137617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 277.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 301965"},
        {"Hipparcos Number", "HIP 57799"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.77169263),
        dec: Angle.Degrees(-57.34063431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -145.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8224"},
        {"Hipparcos Number", "HIP 6271"},
        {"Geneva Identification System", "GEN# +1.00008224"},
        {"Smithsonian Astrophysical Observation", "SAO 232385"},
        {"Wilson Evans Batten Catalogue", "WEB 1402"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.11563775),
        dec: Angle.Degrees(-57.33873297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 174.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 88.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44407"},
        {"Hipparcos Number", "HIP 29939"},
        {"Smithsonian Astrophysical Observation", "SAO 234439"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.919,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.54323463),
        dec: Angle.Degrees(-57.33647151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77145"},
        {"Hipparcos Number", "HIP 44043"},
        {"Celescope Catalog", "CEL 3118"},
        {"Geneva Identification System", "GEN# +1.00077145"},
        {"Smithsonian Astrophysical Observation", "SAO 236454"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.53849262),
        dec: Angle.Degrees(-57.33623312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173508"},
        {"Hipparcos Number", "HIP 92333"},
        {"Smithsonian Astrophysical Observation", "SAO 245725"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.27900217),
        dec: Angle.Degrees(-57.33541096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46144"},
        {"Hipparcos Number", "HIP 30790"},
        {"Smithsonian Astrophysical Observation", "SAO 234524"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.04553228),
        dec: Angle.Degrees(-57.33530224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207715"},
        {"Hipparcos Number", "HIP 107998"},
        {"Fundamental Katalog 5th Edition", "FK5 5932"},
        {"Smithsonian Astrophysical Observation", "SAO 247212"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.20071430),
        dec: Angle.Degrees(-57.33468950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108118"},
        {"Hipparcos Number", "HIP 60639"},
        {"Celescope Catalog", "CEL 4103"},
        {"Geneva Identification System", "GEN# +1.00108118"},
        {"Smithsonian Astrophysical Observation", "SAO 239940"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.41383598),
        dec: Angle.Degrees(-57.33428071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31574"},
        {"Hipparcos Number", "HIP 22746"},
        {"Geneva Identification System", "GEN# +1.00031574"},
        {"Smithsonian Astrophysical Observation", "SAO 233727"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.40177102),
        dec: Angle.Degrees(-57.33202059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55105"},
        {"Hipparcos Number", "HIP 34417"},
        {"Geneva Identification System", "GEN# +1.00055105"},
        {"Smithsonian Astrophysical Observation", "SAO 234952"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.02770868),
        dec: Angle.Degrees(-57.33120462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164112"},
        {"Hipparcos Number", "HIP 88413"},
        {"Geneva Identification System", "GEN# +1.00164112"},
        {"Smithsonian Astrophysical Observation", "SAO 245197"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.77825607),
        dec: Angle.Degrees(-57.33119486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136537"},
        {"Hipparcos Number", "HIP 75349"},
        {"Fundamental Katalog 5th Edition", "FK5 3212"},
        {"Geneva Identification System", "GEN# +1.00136537"},
        {"Smithsonian Astrophysical Observation", "SAO 242471"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.96292859),
        dec: Angle.Degrees(-57.33063561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4958"},
        {"Hipparcos Number", "HIP 3952"},
        {"Smithsonian Astrophysical Observation", "SAO 232204"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.68701313),
        dec: Angle.Degrees(-57.32997889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218207"},
        {"Hipparcos Number", "HIP 114142"},
        {"Smithsonian Astrophysical Observation", "SAO 247734"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.74593351),
        dec: Angle.Degrees(-57.32772794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93619"},
        {"Hipparcos Number", "HIP 52762"},
        {"Celescope Catalog", "CEL 3707"},
        {"Geneva Identification System", "GEN# +1.00093619"},
        {"Smithsonian Astrophysical Observation", "SAO 238476"},
        {"Wilson Evans Batten Catalogue", "WEB 9603"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.82951586),
        dec: Angle.Degrees(-57.32542915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206429"},
        {"Hipparcos Number", "HIP 107299"},
        {"Fundamental Katalog 5th Edition", "FK5 3734"},
        {"Geneva Identification System", "GEN# +1.00206429"},
        {"Smithsonian Astrophysical Observation", "SAO 247151"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.99648605),
        dec: Angle.Degrees(-57.32511897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -116.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109950"},
        {"Hipparcos Number", "HIP 61744"},
        {"Geneva Identification System", "GEN# +1.00109950"},
        {"Smithsonian Astrophysical Observation", "SAO 240118"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.81566432),
        dec: Angle.Degrees(-57.32348184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116227"},
        {"Hipparcos Number", "HIP 65325"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.83493874),
        dec: Angle.Degrees(-57.32307497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 350",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 350"},
    },
    visualMagnitude: 10.37,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.09930910),
        dec: Angle.Degrees(-57.32287483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 74.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20234"},
        {"Hipparcos Number", "HIP 14930"},
        {"Fundamental Katalog 5th Edition", "FK5 118"},
        {"Geneva Identification System", "GEN# +1.00020234"},
        {"Smithsonian Astrophysical Observation", "SAO 233037"},
        {"Wilson Evans Batten Catalogue", "WEB 2884"},
        {"New General Catalogue", "NGC 1252 38"},
    },
    visualMagnitude: 5.71,
    bvColour: 2.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.13808292),
        dec: Angle.Degrees(-57.32158199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109930",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109930"},
    },
    visualMagnitude: 13.52,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.97777362),
        dec: Angle.Degrees(-57.31809297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53526"},
        {"Hipparcos Number", "HIP 33887"},
        {"Geneva Identification System", "GEN# +1.00053526"},
        {"Smithsonian Astrophysical Observation", "SAO 234873"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.51067754),
        dec: Angle.Degrees(-57.31575544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86990",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86990"},
        {"Cincinnati Publication", "Ci 20 1061"},
        {"Geneva Identification System", "GEN# +6.10010693"},
    },
    visualMagnitude: 10.75,
    bvColour: 1.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.64766164),
        dec: Angle.Degrees(-57.31575508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1119.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1352.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220779"},
        {"Hipparcos Number", "HIP 115754"},
        {"Smithsonian Astrophysical Observation", "SAO 247879"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.77266177),
        dec: Angle.Degrees(-57.31271692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91373"},
        {"Hipparcos Number", "HIP 51546"},
        {"Smithsonian Astrophysical Observation", "SAO 238150"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.91956165),
        dec: Angle.Degrees(-57.31206828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4401"},
        {"Hipparcos Number", "HIP 3573"},
        {"Smithsonian Astrophysical Observation", "SAO 232173"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.41435434),
        dec: Angle.Degrees(-57.31010603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107545"},
        {"Hipparcos Number", "HIP 60302"},
        {"Geneva Identification System", "GEN# +1.00107545"},
        {"Smithsonian Astrophysical Observation", "SAO 239877"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.47243703),
        dec: Angle.Degrees(-57.30816066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27556"},
        {"Hipparcos Number", "HIP 20030"},
        {"Smithsonian Astrophysical Observation", "SAO 233469"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.43800539),
        dec: Angle.Degrees(-57.30814812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146061"},
        {"Hipparcos Number", "HIP 79816"},
        {"Smithsonian Astrophysical Observation", "SAO 243536"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.34065178),
        dec: Angle.Degrees(-57.30569894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149784"},
        {"Hipparcos Number", "HIP 81611"},
        {"Smithsonian Astrophysical Observation", "SAO 244046"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.02546719),
        dec: Angle.Degrees(-57.30507522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107425"},
        {"Hipparcos Number", "HIP 60246"},
        {"Smithsonian Astrophysical Observation", "SAO 239867"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.30253361),
        dec: Angle.Degrees(-57.30389260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83958"},
        {"Hipparcos Number", "HIP 47424"},
        {"Celescope Catalog", "CEL 3358"},
        {"Geneva Identification System", "GEN# +1.00083958"},
        {"Smithsonian Astrophysical Observation", "SAO 237204"},
    },
    visualMagnitude: 8.84,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.94385895),
        dec: Angle.Degrees(-57.30347177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204651"},
        {"Hipparcos Number", "HIP 106338"},
        {"Smithsonian Astrophysical Observation", "SAO 247071"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.05311902),
        dec: Angle.Degrees(-57.30333480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65273"},
        {"Hipparcos Number", "HIP 38656"},
        {"Geneva Identification System", "GEN# +1.00065273"},
        {"Smithsonian Astrophysical Observation", "SAO 235615"},
        {"Wilson Evans Batten Catalogue", "WEB 7589"},
    },
    visualMagnitude: 5.62,
    bvColour: 1.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.72246913),
        dec: Angle.Degrees(-57.30288338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115436"},
        {"Hipparcos Number", "HIP 64910"},
        {"Smithsonian Astrophysical Observation", "SAO 240718"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.57521616),
        dec: Angle.Degrees(-57.30032515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77477"},
        {"Hipparcos Number", "HIP 44202"},
        {"Geneva Identification System", "GEN# +1.00077477"},
        {"Smithsonian Astrophysical Observation", "SAO 236493"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.06406162),
        dec: Angle.Degrees(-57.29869849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117428"},
        {"Hipparcos Number", "HIP 65966"},
        {"Smithsonian Astrophysical Observation", "SAO 240915"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.88124886),
        dec: Angle.Degrees(-57.29790697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124620"},
        {"Hipparcos Number", "HIP 69749"},
        {"Geneva Identification System", "GEN# +1.00124620J"},
        {"Smithsonian Astrophysical Observation", "SAO 241583"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.13326280),
        dec: Angle.Degrees(-57.29746061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118616"},
        {"Hipparcos Number", "HIP 66632"},
        {"Smithsonian Astrophysical Observation", "SAO 241039"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.86737338),
        dec: Angle.Degrees(-57.29695843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153075"},
        {"Hipparcos Number", "HIP 83229"},
        {"Geneva Identification System", "GEN# +1.00153075"},
        {"Smithsonian Astrophysical Observation", "SAO 244344"},
        {"Wilson Evans Batten Catalogue", "WEB 14066"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.13259856),
        dec: Angle.Degrees(-57.29637813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -165.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -298.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61436"},
        {"Hipparcos Number", "HIP 36980"},
        {"Smithsonian Astrophysical Observation", "SAO 235349"},
    },
    visualMagnitude: 6.64,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.01444450),
        dec: Angle.Degrees(-57.29603131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65968",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65968"},
    },
    visualMagnitude: 11.01,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.88409431),
        dec: Angle.Degrees(-57.29510416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88175"},
        {"Hipparcos Number", "HIP 49663"},
        {"Celescope Catalog", "CEL 3447"},
        {"Geneva Identification System", "GEN# +1.00088175"},
        {"Smithsonian Astrophysical Observation", "SAO 237723"},
    },
    visualMagnitude: 8.52,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.08288014),
        dec: Angle.Degrees(-57.28985197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180607"},
        {"Hipparcos Number", "HIP 95050"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.10448973),
        dec: Angle.Degrees(-57.28892809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126375"},
        {"Hipparcos Number", "HIP 70648"},
        {"Geneva Identification System", "GEN# +1.00126375"},
        {"Smithsonian Astrophysical Observation", "SAO 241720"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.75159972),
        dec: Angle.Degrees(-57.28836732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217435"},
        {"Hipparcos Number", "HIP 113696"},
        {"Smithsonian Astrophysical Observation", "SAO 247684"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.40583538),
        dec: Angle.Degrees(-57.28803904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110698"},
        {"Hipparcos Number", "HIP 62179"},
        {"Celescope Catalog", "CEL 4149"},
        {"Geneva Identification System", "GEN# +1.00110698J"},
        {"Smithsonian Astrophysical Observation", "SAO 240203"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.14580964),
        dec: Angle.Degrees(-57.28689428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22936"},
        {"Hipparcos Number", "HIP 16952"},
        {"Smithsonian Astrophysical Observation", "SAO 233194"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.52184718),
        dec: Angle.Degrees(-57.28533323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72404"},
        {"Hipparcos Number", "HIP 41680"},
        {"Celescope Catalog", "CEL 2583"},
        {"Geneva Identification System", "GEN# +1.00072404"},
        {"Smithsonian Astrophysical Observation", "SAO 236034"},
    },
    visualMagnitude: 9.12,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.45725944),
        dec: Angle.Degrees(-57.28337194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206428"},
        {"Hipparcos Number", "HIP 107300"},
        {"Geneva Identification System", "GEN# +1.00206428"},
        {"Smithsonian Astrophysical Observation", "SAO 247153"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.00208294),
        dec: Angle.Degrees(-57.28292464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47691",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47691"},
    },
    visualMagnitude: 11.11,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.85677465),
        dec: Angle.Degrees(-57.28212910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224505"},
        {"Hipparcos Number", "HIP 118197"},
        {"Fundamental Katalog 5th Edition", "FK5 3926"},
        {"Geneva Identification System", "GEN# +1.00224505"},
        {"Smithsonian Astrophysical Observation", "SAO 248085"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.789,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.62940932),
        dec: Angle.Degrees(-57.28079766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177001"},
        {"Hipparcos Number", "HIP 93794"},
        {"Smithsonian Astrophysical Observation", "SAO 245917"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.51791622),
        dec: Angle.Degrees(-57.27937477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 303940"},
        {"Hipparcos Number", "HIP 54834"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.39044630),
        dec: Angle.Degrees(-57.27837069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 240.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88484"},
        {"Hipparcos Number", "HIP 49840"},
        {"Smithsonian Astrophysical Observation", "SAO 237759"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.64460047),
        dec: Angle.Degrees(-57.27829855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139002"},
        {"Hipparcos Number", "HIP 76565"},
        {"Geneva Identification System", "GEN# +1.00139002"},
        {"Smithsonian Astrophysical Observation", "SAO 242781"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.827,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.55679958),
        dec: Angle.Degrees(-57.27530931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80577"},
        {"Hipparcos Number", "HIP 45659"},
        {"Smithsonian Astrophysical Observation", "SAO 236834"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.60390070),
        dec: Angle.Degrees(-57.27308497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118844"},
        {"Hipparcos Number", "HIP 66748"},
        {"Geneva Identification System", "GEN# +1.00118844"},
        {"Smithsonian Astrophysical Observation", "SAO 241062"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.20963191),
        dec: Angle.Degrees(-57.27296016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81054"},
        {"Hipparcos Number", "HIP 45867"},
        {"Smithsonian Astrophysical Observation", "SAO 236876"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.28829645),
        dec: Angle.Degrees(-57.27277929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94275"},
        {"Hipparcos Number", "HIP 53100"},
        {"Celescope Catalog", "CEL 3742"},
        {"Geneva Identification System", "GEN# +1.00094275"},
        {"Smithsonian Astrophysical Observation", "SAO 238540"},
    },
    visualMagnitude: 6.29,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.94554220),
        dec: Angle.Degrees(-57.27231455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69891"},
        {"Hipparcos Number", "HIP 40495"},
        {"Geneva Identification System", "GEN# +1.00069891"},
        {"Smithsonian Astrophysical Observation", "SAO 235847"},
    },
    visualMagnitude: 7.83,
    bvColour: -0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.02328827),
        dec: Angle.Degrees(-57.26926055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47446"},
        {"Hipparcos Number", "HIP 31442"},
        {"Smithsonian Astrophysical Observation", "SAO 234593"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.917,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.81380005),
        dec: Angle.Degrees(-57.26508638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127400"},
        {"Hipparcos Number", "HIP 71150"},
        {"Geneva Identification System", "GEN# +1.00127400"},
        {"Smithsonian Astrophysical Observation", "SAO 241785"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.28440712),
        dec: Angle.Degrees(-57.26505222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209121"},
        {"Hipparcos Number", "HIP 108832"},
        {"Smithsonian Astrophysical Observation", "SAO 247285"},
    },
    visualMagnitude: 9.90,
    bvColour: 1.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.71107022),
        dec: Angle.Degrees(-57.26380382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101375"},
        {"Hipparcos Number", "HIP 56871"},
        {"Smithsonian Astrophysical Observation", "SAO 239267"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.89573984),
        dec: Angle.Degrees(-57.26293175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175328"},
        {"Hipparcos Number", "HIP 93122"},
        {"Smithsonian Astrophysical Observation", "SAO 245830"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.55292531),
        dec: Angle.Degrees(-57.26173826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151697"},
        {"Hipparcos Number", "HIP 82531"},
        {"Geneva Identification System", "GEN# +1.00151697"},
        {"Smithsonian Astrophysical Observation", "SAO 244209"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.04702891),
        dec: Angle.Degrees(-57.26169035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120329"},
        {"Hipparcos Number", "HIP 67534"},
        {"Geneva Identification System", "GEN# +1.00120329"},
        {"Smithsonian Astrophysical Observation", "SAO 241208"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.56928198),
        dec: Angle.Degrees(-57.26119969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -297.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -321.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104646"},
        {"Hipparcos Number", "HIP 58756"},
        {"Smithsonian Astrophysical Observation", "SAO 239612"},
    },
    visualMagnitude: 6.69,
    bvColour: 1.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.75449993),
        dec: Angle.Degrees(-57.26013017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84152"},
        {"Hipparcos Number", "HIP 47498"},
        {"Geneva Identification System", "GEN# +1.00084152"},
        {"Smithsonian Astrophysical Observation", "SAO 237224"},
    },
    visualMagnitude: 5.80,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.25876248),
        dec: Angle.Degrees(-57.25944118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114998"},
        {"Hipparcos Number", "HIP 64667"},
        {"Celescope Catalog", "CEL 4220"},
        {"Smithsonian Astrophysical Observation", "SAO 240678"},
    },
    visualMagnitude: 7.80,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.82948531),
        dec: Angle.Degrees(-57.25883372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81851"},
        {"Hipparcos Number", "HIP 46268"},
        {"Smithsonian Astrophysical Observation", "SAO 236968"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.50168486),
        dec: Angle.Degrees(-57.25773785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23309",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23309"},
    },
    visualMagnitude: 10.02,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.19621515),
        dec: Angle.Degrees(-57.25725088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 72.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203497"},
        {"Hipparcos Number", "HIP 105719"},
        {"Geneva Identification System", "GEN# +1.00203497"},
        {"Smithsonian Astrophysical Observation", "SAO 247014"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.19087105),
        dec: Angle.Degrees(-57.25706309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92287"},
        {"Hipparcos Number", "HIP 52043"},
        {"Celescope Catalog", "CEL 3605"},
        {"Geneva Identification System", "GEN# +1.00092287"},
        {"Smithsonian Astrophysical Observation", "SAO 238278"},
        {"Wilson Evans Batten Catalogue", "WEB 9490"},
    },
    visualMagnitude: 5.89,
    bvColour: -0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.51109079),
        dec: Angle.Degrees(-57.25631096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96665"},
        {"Hipparcos Number", "HIP 54359"},
        {"Smithsonian Astrophysical Observation", "SAO 238792"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.81297896),
        dec: Angle.Degrees(-57.25544455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36970"},
        {"Hipparcos Number", "HIP 25914"},
        {"Smithsonian Astrophysical Observation", "SAO 234017"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.96114314),
        dec: Angle.Degrees(-57.25449713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28248"},
        {"Hipparcos Number", "HIP 20543"},
        {"Smithsonian Astrophysical Observation", "SAO 233504"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.02871196),
        dec: Angle.Degrees(-57.25317934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7679"},
        {"Hipparcos Number", "HIP 5879"},
        {"Smithsonian Astrophysical Observation", "SAO 232359"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.87425328),
        dec: Angle.Degrees(-57.25013997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156357"},
        {"Hipparcos Number", "HIP 84844"},
        {"Smithsonian Astrophysical Observation", "SAO 244637"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.11109649),
        dec: Angle.Degrees(-57.24809701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137582"},
        {"Hipparcos Number", "HIP 75843"},
        {"Geneva Identification System", "GEN# +1.00137582"},
        {"Smithsonian Astrophysical Observation", "SAO 242596"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.38797546),
        dec: Angle.Degrees(-57.24758324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2459"},
        {"Hipparcos Number", "HIP 2209"},
        {"Smithsonian Astrophysical Observation", "SAO 232050"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.98148537),
        dec: Angle.Degrees(-57.24470819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115651"},
        {"Hipparcos Number", "HIP 65017"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.821,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.91843533),
        dec: Angle.Degrees(-57.24325594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94367"},
        {"Hipparcos Number", "HIP 53154"},
        {"Celescope Catalog", "CEL 3750"},
        {"Fundamental Katalog 5th Edition", "FK5 2868"},
        {"Geneva Identification System", "GEN# +1.00094367"},
        {"Smithsonian Astrophysical Observation", "SAO 238557"},
        {"Wilson Evans Batten Catalogue", "WEB 9654"},
    },
    visualMagnitude: 5.26,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.12855279),
        dec: Angle.Degrees(-57.24041437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63493"},
        {"Hipparcos Number", "HIP 37900"},
        {"Smithsonian Astrophysical Observation", "SAO 235498"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.50894918),
        dec: Angle.Degrees(-57.23828316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219159"},
        {"Hipparcos Number", "HIP 114731"},
        {"Smithsonian Astrophysical Observation", "SAO 247791"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.62046797),
        dec: Angle.Degrees(-57.23703316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7588",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Achernar"},
        {"Henry Draper", "HD 10144"},
        {"Hipparcos Number", "HIP 7588"},
        {"Fundamental Katalog 5th Edition", "FK5 54"},
        {"Geneva Identification System", "GEN# +1.00010144"},
        {"Smithsonian Astrophysical Observation", "SAO 232481"},
        {"Wilson Evans Batten Catalogue", "WEB 1623"},
    },
    visualMagnitude: 0.45,
    bvColour: -0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.42813204),
        dec: Angle.Degrees(-57.23666007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148586"},
        {"Hipparcos Number", "HIP 80976"},
        {"Geneva Identification System", "GEN# +1.00148586"},
        {"Smithsonian Astrophysical Observation", "SAO 243918"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.764,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.03462735),
        dec: Angle.Degrees(-57.23548724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113725"},
        {"Hipparcos Number", "HIP 63966"},
        {"Smithsonian Astrophysical Observation", "SAO 240551"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.63345963),
        dec: Angle.Degrees(-57.23531018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25331",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25331"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.26307445),
        dec: Angle.Degrees(-57.23524872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75711"},
        {"Hipparcos Number", "HIP 43286"},
        {"Smithsonian Astrophysical Observation", "SAO 236306"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.26517413),
        dec: Angle.Degrees(-57.23370173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90980"},
        {"Hipparcos Number", "HIP 51307"},
        {"Geneva Identification System", "GEN# +1.00090980"},
        {"Smithsonian Astrophysical Observation", "SAO 238102"},
    },
    visualMagnitude: 6.69,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.20013750),
        dec: Angle.Degrees(-57.23305050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81483"},
        {"Hipparcos Number", "HIP 46071"},
        {"Smithsonian Astrophysical Observation", "SAO 236928"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.92254302),
        dec: Angle.Degrees(-57.23105512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187030"},
        {"Hipparcos Number", "HIP 97656"},
        {"Smithsonian Astrophysical Observation", "SAO 246297"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.70675119),
        dec: Angle.Degrees(-57.23056674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106958"},
        {"Hipparcos Number", "HIP 59990"},
        {"Smithsonian Astrophysical Observation", "SAO 239823"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.55273604),
        dec: Angle.Degrees(-57.22951882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122096"},
        {"Hipparcos Number", "HIP 68491"},
        {"Geneva Identification System", "GEN# +1.00122096"},
        {"Smithsonian Astrophysical Observation", "SAO 241371"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.32663139),
        dec: Angle.Degrees(-57.22865876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210143"},
        {"Hipparcos Number", "HIP 109405"},
        {"Smithsonian Astrophysical Observation", "SAO 247334"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.48249408),
        dec: Angle.Degrees(-57.22550114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -142.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186855"},
        {"Hipparcos Number", "HIP 97574"},
        {"Smithsonian Astrophysical Observation", "SAO 246285"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.48267127),
        dec: Angle.Degrees(-57.22121266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110534",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110534"},
        {"Cincinnati Publication", "Ci 20 1359"},
        {"Geneva Identification System", "GEN# +6.00108995"},
    },
    visualMagnitude: 10.82,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.88611328),
        dec: Angle.Degrees(-57.21971474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 586.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -376.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210741"},
        {"Hipparcos Number", "HIP 109770"},
        {"Smithsonian Astrophysical Observation", "SAO 247365"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.51080677),
        dec: Angle.Degrees(-57.21839546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110911"},
        {"Hipparcos Number", "HIP 62310"},
        {"Smithsonian Astrophysical Observation", "SAO 240227"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.51943930),
        dec: Angle.Degrees(-57.21698912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61741"},
        {"Hipparcos Number", "HIP 37116"},
        {"Renson", "Renson 16950"},
        {"Smithsonian Astrophysical Observation", "SAO 235369"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.39315235),
        dec: Angle.Degrees(-57.21674688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148013"},
        {"Hipparcos Number", "HIP 80678"},
        {"Geneva Identification System", "GEN# +1.00148013"},
        {"Smithsonian Astrophysical Observation", "SAO 243840"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.06850179),
        dec: Angle.Degrees(-57.21161551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60250"},
        {"Hipparcos Number", "HIP 36471"},
        {"Smithsonian Astrophysical Observation", "SAO 235250"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.57483248),
        dec: Angle.Degrees(-57.21053686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25704"},
        {"Hipparcos Number", "HIP 18802"},
        {"Cincinnati Publication", "Ci 20 277"},
        {"Geneva Identification System", "GEN# +1.00025704"},
        {"Smithsonian Astrophysical Observation", "SAO 233371"},
        {"Wilson Evans Batten Catalogue", "WEB 3619"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.43441294),
        dec: Angle.Degrees(-57.20783041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 347.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 413.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74680"},
        {"Hipparcos Number", "HIP 42749"},
        {"Geneva Identification System", "GEN# +1.00074680"},
        {"Smithsonian Astrophysical Observation", "SAO 236215"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.68726767),
        dec: Angle.Degrees(-57.20258452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31484"},
        {"Hipparcos Number", "HIP 22702"},
        {"Smithsonian Astrophysical Observation", "SAO 233724"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.23025268),
        dec: Angle.Degrees(-57.19964978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195983"},
        {"Hipparcos Number", "HIP 101717"},
        {"Smithsonian Astrophysical Observation", "SAO 246658"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.27483642),
        dec: Angle.Degrees(-57.19964519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90872"},
        {"Hipparcos Number", "HIP 51246"},
        {"Celescope Catalog", "CEL 3547"},
        {"Geneva Identification System", "GEN# +1.00090872"},
        {"Smithsonian Astrophysical Observation", "SAO 238086"},
    },
    visualMagnitude: 6.83,
    bvColour: -0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.01195489),
        dec: Angle.Degrees(-57.19846816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224464"},
        {"Hipparcos Number", "HIP 118169"},
        {"Geneva Identification System", "GEN# +1.00224464"},
        {"Smithsonian Astrophysical Observation", "SAO 248082"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.55412856),
        dec: Angle.Degrees(-57.19682202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 154.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174139"},
        {"Hipparcos Number", "HIP 92629"},
        {"Smithsonian Astrophysical Observation", "SAO 245768"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.11238285),
        dec: Angle.Degrees(-57.19611206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 398"},
        {"Hipparcos Number", "HIP 680"},
        {"Smithsonian Astrophysical Observation", "SAO 231940"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.10343088),
        dec: Angle.Degrees(-57.19508646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33230"},
        {"Hipparcos Number", "HIP 23679"},
        {"Smithsonian Astrophysical Observation", "SAO 233821"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.34791612),
        dec: Angle.Degrees(-57.19499114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13254"},
        {"Hipparcos Number", "HIP 9923"},
        {"Fundamental Katalog 5th Edition", "FK5 4194"},
        {"Smithsonian Astrophysical Observation", "SAO 232643"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.93276215),
        dec: Angle.Degrees(-57.19453416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18004"},
        {"Hipparcos Number", "HIP 13295"},
        {"Smithsonian Astrophysical Observation", "SAO 232916"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.78237633),
        dec: Angle.Degrees(-57.19253777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53279"},
        {"Hipparcos Number", "HIP 33807"},
        {"Geneva Identification System", "GEN# +1.00053279"},
        {"Smithsonian Astrophysical Observation", "SAO 234862"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.28522847),
        dec: Angle.Degrees(-57.19179292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93816",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93816"},
    },
    visualMagnitude: 11.32,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.58710310),
        dec: Angle.Degrees(-57.19102528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223237"},
        {"Hipparcos Number", "HIP 117378"},
        {"Smithsonian Astrophysical Observation", "SAO 248022"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.99438773),
        dec: Angle.Degrees(-57.19084606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28827"},
        {"Hipparcos Number", "HIP 20931"},
        {"Smithsonian Astrophysical Observation", "SAO 233537"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.32343899),
        dec: Angle.Degrees(-57.18774597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84809"},
        {"Hipparcos Number", "HIP 47893"},
        {"Celescope Catalog", "CEL 3380"},
        {"Geneva Identification System", "GEN# +1.00084809"},
        {"Renson", "Renson 24195"},
        {"Smithsonian Astrophysical Observation", "SAO 237314"},
        {"Wilson Evans Batten Catalogue", "WEB 8959"},
    },
    visualMagnitude: 6.47,
    bvColour: -0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.41932908),
        dec: Angle.Degrees(-57.18606020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121160"},
        {"Hipparcos Number", "HIP 67983"},
        {"Geneva Identification System", "GEN# +1.00121160"},
        {"Smithsonian Astrophysical Observation", "SAO 241292"},
    },
    visualMagnitude: 7.75,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.82989851),
        dec: Angle.Degrees(-57.18486770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120078"},
        {"Hipparcos Number", "HIP 67399"},
        {"Geneva Identification System", "GEN# +1.00120078"},
        {"Smithsonian Astrophysical Observation", "SAO 241189"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.19349043),
        dec: Angle.Degrees(-57.18199746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92643"},
        {"Hipparcos Number", "HIP 52247"},
        {"Geneva Identification System", "GEN# +1.00092643"},
        {"Smithsonian Astrophysical Observation", "SAO 238334"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.13394921),
        dec: Angle.Degrees(-57.18056708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -114.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112092"},
        {"Hipparcos Number", "HIP 63003"},
        {"Celescope Catalog", "CEL 4166"},
        {"Geneva Identification System", "GEN# +1.00112092"},
        {"Smithsonian Astrophysical Observation", "SAO 240366"},
        {"Wilson Evans Batten Catalogue", "WEB 11171"},
    },
    visualMagnitude: 4.03,
    bvColour: -0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.64857337),
        dec: Angle.Degrees(-57.17789116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194573"},
        {"Hipparcos Number", "HIP 101057"},
        {"Smithsonian Astrophysical Observation", "SAO 246603"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.29459630),
        dec: Angle.Degrees(-57.17762203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124893"},
        {"Hipparcos Number", "HIP 69883"},
        {"Geneva Identification System", "GEN# +1.00124893"},
        {"Smithsonian Astrophysical Observation", "SAO 241605"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.52339351),
        dec: Angle.Degrees(-57.17375906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171604"},
        {"Hipparcos Number", "HIP 91457"},
        {"Smithsonian Astrophysical Observation", "SAO 245604"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.80230983),
        dec: Angle.Degrees(-57.17362583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42664",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42664"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.43703198),
        dec: Angle.Degrees(-57.17161941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89844"},
        {"Hipparcos Number", "HIP 50646"},
        {"Celescope Catalog", "CEL 3514"},
        {"Geneva Identification System", "GEN# +1.00089844"},
        {"Smithsonian Astrophysical Observation", "SAO 237948"},
    },
    visualMagnitude: 7.76,
    bvColour: -0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.15439718),
        dec: Angle.Degrees(-57.16977914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112091"},
        {"Hipparcos Number", "HIP 63005"},
        {"Geneva Identification System", "GEN# +1.00112091"},
        {"Smithsonian Astrophysical Observation", "SAO 240367"},
        {"Wilson Evans Batten Catalogue", "WEB 11170"},
    },
    visualMagnitude: 5.08,
    bvColour: -0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.65383866),
        dec: Angle.Degrees(-57.16864387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80576"},
        {"Hipparcos Number", "HIP 45663"},
        {"Geneva Identification System", "GEN# +1.00080576"},
        {"Smithsonian Astrophysical Observation", "SAO 236835"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.61190458),
        dec: Angle.Degrees(-57.16806010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104125"},
        {"Hipparcos Number", "HIP 58465"},
        {"Geneva Identification System", "GEN# +1.00104125"},
        {"Smithsonian Astrophysical Observation", "SAO 239550"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.84907569),
        dec: Angle.Degrees(-57.16796196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19423"},
        {"Hipparcos Number", "HIP 14339"},
        {"Geneva Identification System", "GEN# +1.00019423"},
        {"Smithsonian Astrophysical Observation", "SAO 232989"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.22895300),
        dec: Angle.Degrees(-57.16621531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225133"},
        {"Hipparcos Number", "HIP 293"},
        {"Geneva Identification System", "GEN# +1.00225133"},
        {"Smithsonian Astrophysical Observation", "SAO 231910"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.91589999),
        dec: Angle.Degrees(-57.16443914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1639"},
        {"Hipparcos Number", "HIP 1627"},
        {"Smithsonian Astrophysical Observation", "SAO 232004"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.08399537),
        dec: Angle.Degrees(-57.16335692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29145"},
        {"Hipparcos Number", "HIP 21149"},
        {"Geneva Identification System", "GEN# +1.00029145"},
        {"Smithsonian Astrophysical Observation", "SAO 233552"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.00974938),
        dec: Angle.Degrees(-57.16232255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87804",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87804"},
    },
    visualMagnitude: 12.18,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.05161842),
        dec: Angle.Degrees(-57.16198400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36789"},
        {"Hipparcos Number", "HIP 25807"},
        {"Geneva Identification System", "GEN# +1.00036789"},
        {"Smithsonian Astrophysical Observation", "SAO 234009"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.68655250),
        dec: Angle.Degrees(-57.16003271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220217"},
        {"Hipparcos Number", "HIP 115405"},
        {"Smithsonian Astrophysical Observation", "SAO 247843"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.66662824),
        dec: Angle.Degrees(-57.15950692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125205"},
        {"Hipparcos Number", "HIP 70040"},
        {"Geneva Identification System", "GEN# +1.00125205"},
        {"Smithsonian Astrophysical Observation", "SAO 241635"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.97757497),
        dec: Angle.Degrees(-57.15754493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205193"},
        {"Hipparcos Number", "HIP 106624"},
        {"Smithsonian Astrophysical Observation", "SAO 247100"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.94606642),
        dec: Angle.Degrees(-57.15690916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39937"},
        {"Hipparcos Number", "HIP 27737"},
        {"Geneva Identification System", "GEN# +1.00039937"},
        {"Smithsonian Astrophysical Observation", "SAO 234181"},
        {"Wilson Evans Batten Catalogue", "WEB 5439"},
    },
    visualMagnitude: 5.93,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.08409189),
        dec: Angle.Degrees(-57.15600008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83185",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83185"},
    },
    visualMagnitude: 12.17,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.02195013),
        dec: Angle.Degrees(-57.15513702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100675"},
        {"Hipparcos Number", "HIP 56465"},
        {"Smithsonian Astrophysical Observation", "SAO 239184"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.65845277),
        dec: Angle.Degrees(-57.15253053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130436"},
        {"Hipparcos Number", "HIP 72587"},
        {"Smithsonian Astrophysical Observation", "SAO 242051"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.63328133),
        dec: Angle.Degrees(-57.15252683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5053",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5053"},
        {"Smithsonian Astrophysical Observation", "SAO 232285"},
    },
    visualMagnitude: 9.49,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.16758767),
        dec: Angle.Degrees(-57.15226611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30804"},
        {"Hipparcos Number", "HIP 22251"},
        {"Geneva Identification System", "GEN# +1.00030804"},
        {"Smithsonian Astrophysical Observation", "SAO 233684"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.84230876),
        dec: Angle.Degrees(-57.14925154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224299"},
        {"Hipparcos Number", "HIP 118050"},
        {"Smithsonian Astrophysical Observation", "SAO 248074"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.18206098),
        dec: Angle.Degrees(-57.14835078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142567"},
        {"Hipparcos Number", "HIP 78197"},
        {"Smithsonian Astrophysical Observation", "SAO 243171"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.52232628),
        dec: Angle.Degrees(-57.14754498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200474"},
        {"Hipparcos Number", "HIP 104152"},
        {"Geneva Identification System", "GEN# +1.00200474"},
        {"Smithsonian Astrophysical Observation", "SAO 246864"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.51602050),
        dec: Angle.Degrees(-57.14641157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 134.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -201.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136225"},
        {"Hipparcos Number", "HIP 75197"},
        {"Smithsonian Astrophysical Observation", "SAO 242445"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.50049836),
        dec: Angle.Degrees(-57.14526790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11220"},
        {"Hipparcos Number", "HIP 8428"},
        {"Smithsonian Astrophysical Observation", "SAO 232529"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.16496097),
        dec: Angle.Degrees(-57.14421511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13009"},
        {"Hipparcos Number", "HIP 9767"},
    },
    visualMagnitude: 9.69,
    bvColour: 1.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.39234220),
        dec: Angle.Degrees(-57.14416789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169613"},
        {"Hipparcos Number", "HIP 90570"},
        {"Smithsonian Astrophysical Observation", "SAO 245501"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.21954774),
        dec: Angle.Degrees(-57.14170596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8809"},
        {"Hipparcos Number", "HIP 6666"},
        {"Geneva Identification System", "GEN# +1.00008809"},
        {"Smithsonian Astrophysical Observation", "SAO 232421"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.38583151),
        dec: Angle.Degrees(-57.14083707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185472"},
        {"Hipparcos Number", "HIP 96935"},
        {"Geneva Identification System", "GEN# +1.00185472"},
        {"Smithsonian Astrophysical Observation", "SAO 246221"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.58031004),
        dec: Angle.Degrees(-57.14022367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139355"},
        {"Hipparcos Number", "HIP 76746"},
        {"Smithsonian Astrophysical Observation", "SAO 242812"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.07805466),
        dec: Angle.Degrees(-57.13895433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21721"},
        {"Hipparcos Number", "HIP 16105"},
        {"Smithsonian Astrophysical Observation", "SAO 233127"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.86336562),
        dec: Angle.Degrees(-57.13829050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106838"},
        {"Hipparcos Number", "HIP 59908"},
        {"Smithsonian Astrophysical Observation", "SAO 239812"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.32082546),
        dec: Angle.Degrees(-57.13778019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -155.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 304391"},
        {"Hipparcos Number", "HIP 56153"},
        {"Cincinnati Publication", "Ci 20 645"},
        {"Geneva Identification System", "GEN# +1.00304391"},
        {"Smithsonian Astrophysical Observation", "SAO 239129"},
        {"Wilson Evans Batten Catalogue", "WEB 10082"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.64839026),
        dec: Angle.Degrees(-57.13396199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -554.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71164"},
        {"Hipparcos Number", "HIP 41091"},
        {"Geneva Identification System", "GEN# +1.00071164"},
        {"Smithsonian Astrophysical Observation", "SAO 235940"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.74821429),
        dec: Angle.Degrees(-57.13389506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 110.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134102"},
        {"Hipparcos Number", "HIP 74250"},
        {"Smithsonian Astrophysical Observation", "SAO 242273"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.61826849),
        dec: Angle.Degrees(-57.13268561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82832"},
        {"Hipparcos Number", "HIP 46815"},
        {"Smithsonian Astrophysical Observation", "SAO 237081"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.10165954),
        dec: Angle.Degrees(-57.13229605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123113"},
        {"Hipparcos Number", "HIP 68992"},
        {"Geneva Identification System", "GEN# +1.00123113"},
        {"Smithsonian Astrophysical Observation", "SAO 241457"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.87004533),
        dec: Angle.Degrees(-57.12838227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92656",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92656"},
        {"Geneva Identification System", "GEN# +6.20145023"},
    },
    visualMagnitude: 12.11,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.21916429),
        dec: Angle.Degrees(-57.12516265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -245.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -769.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144262"},
        {"Hipparcos Number", "HIP 79035"},
        {"Geneva Identification System", "GEN# +1.00144262"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.98116908),
        dec: Angle.Degrees(-57.12362402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104231"},
        {"Hipparcos Number", "HIP 58528"},
        {"Smithsonian Astrophysical Observation", "SAO 239566"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.03936042),
        dec: Angle.Degrees(-57.11719894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90627"},
        {"Hipparcos Number", "HIP 51103"},
    },
    visualMagnitude: 9.47,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.60591749),
        dec: Angle.Degrees(-57.11534758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94626"},
        {"Hipparcos Number", "HIP 53323"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.60380683),
        dec: Angle.Degrees(-57.11519859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61084",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Gacrux"},
        {"Henry Draper", "HD 108903"},
        {"Hipparcos Number", "HIP 61084"},
        {"Fundamental Katalog 5th Edition", "FK5 468"},
        {"Geneva Identification System", "GEN# +1.00108903"},
        {"Smithsonian Astrophysical Observation", "SAO 240019"},
        {"Wilson Evans Batten Catalogue", "WEB 10875"},
    },
    visualMagnitude: 1.59,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.79137202),
        dec: Angle.Degrees(-57.11256922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -264.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140043"},
        {"Hipparcos Number", "HIP 77075"},
        {"Geneva Identification System", "GEN# +1.00140043"},
        {"Smithsonian Astrophysical Observation", "SAO 242887"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.07119648),
        dec: Angle.Degrees(-57.11246982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177103"},
        {"Hipparcos Number", "HIP 93838"},
        {"Geneva Identification System", "GEN# +1.00177103"},
        {"Smithsonian Astrophysical Observation", "SAO 245920"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.64792234),
        dec: Angle.Degrees(-57.11179184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127655"},
        {"Hipparcos Number", "HIP 71274"},
        {"Geneva Identification System", "GEN# +1.00127655"},
        {"Smithsonian Astrophysical Observation", "SAO 241805"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.65273069),
        dec: Angle.Degrees(-57.10977547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77525"},
        {"Hipparcos Number", "HIP 44242"},
        {"Celescope Catalog", "CEL 3145"},
        {"Geneva Identification System", "GEN# +1.00077525"},
        {"Smithsonian Astrophysical Observation", "SAO 236501"},
    },
    visualMagnitude: 8.54,
    bvColour: -0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.14424328),
        dec: Angle.Degrees(-57.10840343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157559"},
        {"Hipparcos Number", "HIP 85421"},
        {"Geneva Identification System", "GEN# +1.00157559"},
        {"Smithsonian Astrophysical Observation", "SAO 244751"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.82932281),
        dec: Angle.Degrees(-57.10424776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214648"},
        {"Hipparcos Number", "HIP 111969"},
        {"Smithsonian Astrophysical Observation", "SAO 247545"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.20806130),
        dec: Angle.Degrees(-57.10303810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25346"},
        {"Hipparcos Number", "HIP 18592"},
        {"Fundamental Katalog 5th Edition", "FK5 1109"},
        {"Geneva Identification System", "GEN# +1.00025346"},
        {"Smithsonian Astrophysical Observation", "SAO 233347"},
    },
    visualMagnitude: 6.05,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.67864137),
        dec: Angle.Degrees(-57.10238788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154876"},
        {"Hipparcos Number", "HIP 84077"},
        {"Geneva Identification System", "GEN# +1.00154876"},
        {"Smithsonian Astrophysical Observation", "SAO 244494"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.83900553),
        dec: Angle.Degrees(-57.10058269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73224"},
        {"Hipparcos Number", "HIP 42079"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.65003541),
        dec: Angle.Degrees(-57.09815984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168849"},
        {"Hipparcos Number", "HIP 90282"},
        {"Geneva Identification System", "GEN# +1.00168849"},
        {"Smithsonian Astrophysical Observation", "SAO 245452"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.31985889),
        dec: Angle.Degrees(-57.09546897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217740"},
        {"Hipparcos Number", "HIP 113868"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.89736862),
        dec: Angle.Degrees(-57.09514827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82919"},
        {"Hipparcos Number", "HIP 46847"},
        {"Celescope Catalog", "CEL 3322"},
        {"Geneva Identification System", "GEN# +1.00082919A"},
        {"Smithsonian Astrophysical Observation", "SAO 237090"},
        {"Wilson Evans Batten Catalogue", "WEB 8834"},
    },
    visualMagnitude: 7.14,
    bvColour: -0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.19564472),
        dec: Angle.Degrees(-57.09431334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150914"},
        {"Hipparcos Number", "HIP 82167"},
        {"Smithsonian Astrophysical Observation", "SAO 244135"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.82294003),
        dec: Angle.Degrees(-57.09332783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215248"},
        {"Hipparcos Number", "HIP 112320"},
        {"Smithsonian Astrophysical Observation", "SAO 247568"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.25655262),
        dec: Angle.Degrees(-57.09154182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215659"},
        {"Hipparcos Number", "HIP 112561"},
        {"Smithsonian Astrophysical Observation", "SAO 247585"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.96366253),
        dec: Angle.Degrees(-57.09065336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90434"},
        {"Hipparcos Number", "HIP 50996"},
        {"Celescope Catalog", "CEL 3532"},
        {"Geneva Identification System", "GEN# +1.00090434"},
        {"Smithsonian Astrophysical Observation", "SAO 238045"},
    },
    visualMagnitude: 8.21,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.25482772),
        dec: Angle.Degrees(-57.08649588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184517"},
        {"Hipparcos Number", "HIP 96575"},
        {"Smithsonian Astrophysical Observation", "SAO 246185"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.49485300),
        dec: Angle.Degrees(-57.08607673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124367"},
        {"Hipparcos Number", "HIP 69618"},
        {"Geneva Identification System", "GEN# +1.00124367"},
        {"Smithsonian Astrophysical Observation", "SAO 241563"},
        {"Wilson Evans Batten Catalogue", "WEB 12124"},
    },
    visualMagnitude: 5.03,
    bvColour: -0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.73818295),
        dec: Angle.Degrees(-57.08607539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3128"},
        {"Hipparcos Number", "HIP 2682"},
        {"Geneva Identification System", "GEN# +1.00003128"},
        {"Smithsonian Astrophysical Observation", "SAO 232088"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.49975381),
        dec: Angle.Degrees(-57.08515943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24812"},
        {"Hipparcos Number", "HIP 18229"},
        {"Smithsonian Astrophysical Observation", "SAO 233317"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.45323206),
        dec: Angle.Degrees(-57.08454850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155512"},
        {"Hipparcos Number", "HIP 84406"},
        {"Geneva Identification System", "GEN# +1.00155512"},
        {"Smithsonian Astrophysical Observation", "SAO 244554"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.84002480),
        dec: Angle.Degrees(-57.08432566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37227"},
        {"Hipparcos Number", "HIP 26066"},
        {"Geneva Identification System", "GEN# +1.00037227"},
        {"Smithsonian Astrophysical Observation", "SAO 234025"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.39362048),
        dec: Angle.Degrees(-57.08323492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153926"},
        {"Hipparcos Number", "HIP 83641"},
        {"Geneva Identification System", "GEN# +1.00153926"},
        {"Smithsonian Astrophysical Observation", "SAO 244420"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.40936191),
        dec: Angle.Degrees(-57.08315372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204886"},
        {"Hipparcos Number", "HIP 106448"},
        {"Smithsonian Astrophysical Observation", "SAO 247082"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.40750207),
        dec: Angle.Degrees(-57.08195967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172939"},
        {"Hipparcos Number", "HIP 92099"},
        {"Smithsonian Astrophysical Observation", "SAO 245692"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.55454709),
        dec: Angle.Degrees(-57.08153296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85251"},
        {"Hipparcos Number", "HIP 48121"},
        {"Geneva Identification System", "GEN# +1.00085251"},
        {"Smithsonian Astrophysical Observation", "SAO 237372"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.17150636),
        dec: Angle.Degrees(-57.07945482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91188"},
        {"Hipparcos Number", "HIP 51444"},
        {"Celescope Catalog", "CEL 3557"},
        {"Geneva Identification System", "GEN# +1.00091188"},
        {"Smithsonian Astrophysical Observation", "SAO 238130"},
    },
    visualMagnitude: 6.62,
    bvColour: -0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.59341028),
        dec: Angle.Degrees(-57.07738780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76047"},
        {"Hipparcos Number", "HIP 43462"},
        {"Smithsonian Astrophysical Observation", "SAO 236330"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.78707212),
        dec: Angle.Degrees(-57.07538967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138363"},
        {"Hipparcos Number", "HIP 76236"},
        {"Fundamental Katalog 5th Edition", "FK5 5377"},
        {"Smithsonian Astrophysical Observation", "SAO 242701"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.59474980),
        dec: Angle.Degrees(-57.07307133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28255"},
        {"Hipparcos Number", "HIP 20552"},
        {"Geneva Identification System", "GEN# +1.00028255J"},
        {"Wilson Evans Batten Catalogue", "WEB 3935"},
    },
    visualMagnitude: 6.28,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.05133135),
        dec: Angle.Degrees(-57.07115747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101187"},
        {"Hipparcos Number", "HIP 56763"},
        {"Geneva Identification System", "GEN# +1.00101187"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.55432671),
        dec: Angle.Degrees(-57.06809613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133904"},
        {"Hipparcos Number", "HIP 74177"},
        {"Smithsonian Astrophysical Observation", "SAO 242262"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.34687947),
        dec: Angle.Degrees(-57.06712067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96917"},
        {"Hipparcos Number", "HIP 54475"},
        {"Celescope Catalog", "CEL 3825"},
        {"Geneva Identification System", "GEN# +1.00096917"},
        {"Smithsonian Astrophysical Observation", "SAO 238815"},
        {"Wilson Evans Batten Catalogue", "WEB 9835"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.17759339),
        dec: Angle.Degrees(-57.06582362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90452"},
        {"Hipparcos Number", "HIP 51006"},
        {"Geneva Identification System", "GEN# +1.00090452"},
        {"Smithsonian Astrophysical Observation", "SAO 238048"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.29294835),
        dec: Angle.Degrees(-57.06382798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88029"},
        {"Hipparcos Number", "HIP 49579"},
        {"Smithsonian Astrophysical Observation", "SAO 237709"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.81094566),
        dec: Angle.Degrees(-57.06271361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115113"},
        {"Hipparcos Number", "HIP 64739"},
        {"Smithsonian Astrophysical Observation", "SAO 240693"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.02774812),
        dec: Angle.Degrees(-57.06158955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142101"},
        {"Hipparcos Number", "HIP 77973"},
        {"Geneva Identification System", "GEN# +1.00142101"},
        {"Smithsonian Astrophysical Observation", "SAO 243117"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.85213871),
        dec: Angle.Degrees(-57.05921275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -177.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113475"},
        {"Hipparcos Number", "HIP 63832"},
        {"Smithsonian Astrophysical Observation", "SAO 240527"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.23845838),
        dec: Angle.Degrees(-57.05579280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221552"},
        {"Hipparcos Number", "HIP 116270"},
        {"Geneva Identification System", "GEN# +1.00221552"},
        {"Smithsonian Astrophysical Observation", "SAO 247924"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.37587295),
        dec: Angle.Degrees(-57.05368542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97654"},
        {"Hipparcos Number", "HIP 54830"},
        {"Celescope Catalog", "CEL 3856"},
        {"Geneva Identification System", "GEN# +1.00097654"},
        {"Smithsonian Astrophysical Observation", "SAO 238874"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.37966304),
        dec: Angle.Degrees(-57.05176755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89739"},
        {"Hipparcos Number", "HIP 50577"},
        {"Geneva Identification System", "GEN# +1.00089739"},
        {"Smithsonian Astrophysical Observation", "SAO 237923"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.97113535),
        dec: Angle.Degrees(-57.05037133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107544"},
        {"Hipparcos Number", "HIP 60306"},
        {"Geneva Identification System", "GEN# +1.00107544"},
        {"Smithsonian Astrophysical Observation", "SAO 239878"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.48466922),
        dec: Angle.Degrees(-57.04880290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131187"},
        {"Hipparcos Number", "HIP 72936"},
        {"Geneva Identification System", "GEN# +1.00131187"},
        {"Smithsonian Astrophysical Observation", "SAO 242104"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.59721683),
        dec: Angle.Degrees(-57.04759839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102817"},
        {"Hipparcos Number", "HIP 57704"},
        {"Smithsonian Astrophysical Observation", "SAO 239413"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.51493878),
        dec: Angle.Degrees(-57.04701972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111149"},
        {"Hipparcos Number", "HIP 62436"},
        {"Smithsonian Astrophysical Observation", "SAO 240261"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.94315267),
        dec: Angle.Degrees(-57.04450121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214845"},
        {"Hipparcos Number", "HIP 112085"},
        {"Smithsonian Astrophysical Observation", "SAO 247551"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.53543585),
        dec: Angle.Degrees(-57.04003376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115013"},
        {"Hipparcos Number", "HIP 64684"},
        {"Smithsonian Astrophysical Observation", "SAO 240684"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.86186160),
        dec: Angle.Degrees(-57.03666801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85256",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85256"},
    },
    visualMagnitude: 11.40,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.32222132),
        dec: Angle.Degrees(-57.03561015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97580"},
        {"Hipparcos Number", "HIP 54790"},
        {"Celescope Catalog", "CEL 3854"},
        {"Geneva Identification System", "GEN# +1.00097580"},
        {"Smithsonian Astrophysical Observation", "SAO 238867"},
    },
    visualMagnitude: 8.77,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.25375443),
        dec: Angle.Degrees(-57.03518986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82668"},
        {"Hipparcos Number", "HIP 46701"},
        {"Fundamental Katalog 5th Edition", "FK5 361"},
        {"Geneva Identification System", "GEN# +1.00082668"},
        {"Smithsonian Astrophysical Observation", "SAO 237067"},
        {"Wilson Evans Batten Catalogue", "WEB 8809"},
    },
    visualMagnitude: 3.16,
    bvColour: 1.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.80564072),
        dec: Angle.Degrees(-57.03439160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158161"},
        {"Hipparcos Number", "HIP 85725"},
        {"Smithsonian Astrophysical Observation", "SAO 244802"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.77061922),
        dec: Angle.Degrees(-57.03354151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200676"},
        {"Hipparcos Number", "HIP 104256"},
        {"Geneva Identification System", "GEN# +1.00200676"},
        {"Smithsonian Astrophysical Observation", "SAO 246873"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.82287177),
        dec: Angle.Degrees(-57.03204746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116905"},
        {"Hipparcos Number", "HIP 65673"},
        {"Smithsonian Astrophysical Observation", "SAO 240859"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.98272704),
        dec: Angle.Degrees(-57.02975842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -190.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116340"},
        {"Hipparcos Number", "HIP 65391"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.02097180),
        dec: Angle.Degrees(-57.02913962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -130.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221551"},
        {"Hipparcos Number", "HIP 116263"},
        {"Smithsonian Astrophysical Observation", "SAO 247923"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.36066114),
        dec: Angle.Degrees(-57.02908448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128674"},
        {"Hipparcos Number", "HIP 71735"},
        {"Cincinnati Publication", "Ci 20 876"},
        {"Geneva Identification System", "GEN# +1.00128674A"},
        {"Smithsonian Astrophysical Observation", "SAO 241894"},
        {"Wilson Evans Batten Catalogue", "WEB 12357"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.11599680),
        dec: Angle.Degrees(-57.02878779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 395.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -316.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214708"},
        {"Hipparcos Number", "HIP 112005"},
        {"Smithsonian Astrophysical Observation", "SAO 247547"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.31447079),
        dec: Angle.Degrees(-57.02824483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4957"},
        {"Hipparcos Number", "HIP 3959"},
        {"Smithsonian Astrophysical Observation", "SAO 232206"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.71119877),
        dec: Angle.Degrees(-57.02676249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202548"},
        {"Hipparcos Number", "HIP 105220"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.68985949),
        dec: Angle.Degrees(-57.02622987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16124"},
        {"Hipparcos Number", "HIP 11882"},
        {"Renson", "Renson 4030"},
        {"Smithsonian Astrophysical Observation", "SAO 232815"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.31518530),
        dec: Angle.Degrees(-57.02588103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80177"},
        {"Hipparcos Number", "HIP 45477"},
        {"Smithsonian Astrophysical Observation", "SAO 236785"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.00572684),
        dec: Angle.Degrees(-57.02571290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223146"},
        {"Hipparcos Number", "HIP 117322"},
        {"Smithsonian Astrophysical Observation", "SAO 248019"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.769,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.84374024),
        dec: Angle.Degrees(-57.02374088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 147.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -157.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160483"},
        {"Hipparcos Number", "HIP 86747"},
        {"Geneva Identification System", "GEN# +1.00160483J"},
        {"Smithsonian Astrophysical Observation", "SAO 244967"},
    },
    visualMagnitude: 6.64,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.88788949),
        dec: Angle.Degrees(-57.02212370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207537"},
        {"Hipparcos Number", "HIP 107882"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.88119592),
        dec: Angle.Degrees(-57.01806867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 133.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138694"},
        {"Hipparcos Number", "HIP 76416"},
        {"Smithsonian Astrophysical Observation", "SAO 242749"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.11251866),
        dec: Angle.Degrees(-57.01429904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136899"},
        {"Hipparcos Number", "HIP 75523"},
        {"Geneva Identification System", "GEN# +1.00136899"},
        {"Smithsonian Astrophysical Observation", "SAO 242500"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.43761391),
        dec: Angle.Degrees(-57.01418097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135095"},
        {"Hipparcos Number", "HIP 74688"},
        {"Smithsonian Astrophysical Observation", "SAO 242359"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.95321561),
        dec: Angle.Degrees(-57.01393179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129143"},
        {"Hipparcos Number", "HIP 71966"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.78531956),
        dec: Angle.Degrees(-57.01147820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19780"},
        {"Hipparcos Number", "HIP 14588"},
        {"Geneva Identification System", "GEN# +2.12520035"},
        {"Smithsonian Astrophysical Observation", "SAO 233004"},
        {"New General Catalogue", "NGC 1252 35"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.09963173),
        dec: Angle.Degrees(-57.00991401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92850"},
        {"Hipparcos Number", "HIP 52358"},
        {"Celescope Catalog", "CEL 3650"},
        {"Geneva Identification System", "GEN# +1.00092850"},
        {"Smithsonian Astrophysical Observation", "SAO 238365"},
        {"Wilson Evans Batten Catalogue", "WEB 9529"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.50524229),
        dec: Angle.Degrees(-57.00904240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223764"},
        {"Hipparcos Number", "HIP 117726"},
        {"Smithsonian Astrophysical Observation", "SAO 248049"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.14212573),
        dec: Angle.Degrees(-57.00885483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157023"},
        {"Hipparcos Number", "HIP 85164"},
        {"Smithsonian Astrophysical Observation", "SAO 244702"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.05805296),
        dec: Angle.Degrees(-57.00757720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147375"},
        {"Hipparcos Number", "HIP 80415"},
        {"Smithsonian Astrophysical Observation", "SAO 243755"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.20104066),
        dec: Angle.Degrees(-57.00616764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 302225"},
        {"Hipparcos Number", "HIP 46395"},
        {"Smithsonian Astrophysical Observation", "SAO 237004"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.90815041),
        dec: Angle.Degrees(-57.00592174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6192"},
        {"Hipparcos Number", "HIP 4829"},
        {"Fundamental Katalog 5th Edition", "FK5 1027"},
        {"Geneva Identification System", "GEN# +1.00006192"},
        {"Smithsonian Astrophysical Observation", "SAO 232268"},
        {"Wilson Evans Batten Catalogue", "WEB 925"},
    },
    visualMagnitude: 6.12,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.50755785),
        dec: Angle.Degrees(-57.00242929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84808"},
        {"Hipparcos Number", "HIP 47903"},
        {"Geneva Identification System", "GEN# +1.00084808"},
        {"Smithsonian Astrophysical Observation", "SAO 237316"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.44296166),
        dec: Angle.Degrees(-57.00150932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44446"},
        {"Hipparcos Number", "HIP 29965"},
        {"Smithsonian Astrophysical Observation", "SAO 234444"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.61968315),
        dec: Angle.Degrees(-56.99998150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 980"},
        {"Hipparcos Number", "HIP 1114"},
        {"Geneva Identification System", "GEN# +1.00000980"},
        {"Smithsonian Astrophysical Observation", "SAO 231976"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.47070071),
        dec: Angle.Degrees(-56.99978872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 106.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27590"},
        {"Hipparcos Number", "HIP 20059"},
        {"Smithsonian Astrophysical Observation", "SAO 233474"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.52546331),
        dec: Angle.Degrees(-56.99710716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176354"},
        {"Hipparcos Number", "HIP 93547"},
        {"Fundamental Katalog 5th Edition", "FK5 3516"},
        {"Geneva Identification System", "GEN# +1.00176354"},
        {"Smithsonian Astrophysical Observation", "SAO 245882"},
        {"Wilson Evans Batten Catalogue", "WEB 16246"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.80092625),
        dec: Angle.Degrees(-56.99628944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -155.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149730"},
        {"Hipparcos Number", "HIP 81589"},
        {"Geneva Identification System", "GEN# +1.00149730"},
        {"Smithsonian Astrophysical Observation", "SAO 244037"},
    },
    visualMagnitude: 6.73,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.93639711),
        dec: Angle.Degrees(-56.99437530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105692"},
        {"Hipparcos Number", "HIP 59318"},
        {"Geneva Identification System", "GEN# +1.00105692"},
        {"Smithsonian Astrophysical Observation", "SAO 239714"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.754,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.53360097),
        dec: Angle.Degrees(-56.99002181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -153.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205863"},
        {"Hipparcos Number", "HIP 106993"},
        {"Smithsonian Astrophysical Observation", "SAO 247126"},
    },
    visualMagnitude: 9.61,
    bvColour: 1.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.03343960),
        dec: Angle.Degrees(-56.98975551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112593",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112593"},
        {"Smithsonian Astrophysical Observation", "SAO 247590"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.05640824),
        dec: Angle.Degrees(-56.98901376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82764"},
        {"Hipparcos Number", "HIP 46765"},
        {"Celescope Catalog", "CEL 3315"},
        {"Geneva Identification System", "GEN# +1.00082764"},
        {"Smithsonian Astrophysical Observation", "SAO 237074"},
    },
    visualMagnitude: 7.13,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.97353952),
        dec: Angle.Degrees(-56.98891970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122227"},
        {"Hipparcos Number", "HIP 68566"},
        {"Geneva Identification System", "GEN# +1.00122227"},
        {"Smithsonian Astrophysical Observation", "SAO 241378"},
    },
    visualMagnitude: 8.31,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.54792680),
        dec: Angle.Degrees(-56.98877740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18110"},
        {"Hipparcos Number", "HIP 13381"},
        {"Smithsonian Astrophysical Observation", "SAO 232923"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.05054462),
        dec: Angle.Degrees(-56.98871400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 139.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103101"},
        {"Hipparcos Number", "HIP 57870"},
        {"Geneva Identification System", "GEN# +1.00103101"},
        {"Smithsonian Astrophysical Observation", "SAO 239443"},
    },
    visualMagnitude: 5.56,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.04330796),
        dec: Angle.Degrees(-56.98782681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -106.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222258"},
        {"Hipparcos Number", "HIP 116734"},
        {"Smithsonian Astrophysical Observation", "SAO 247964"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.85081330),
        dec: Angle.Degrees(-56.98767898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33670"},
        {"Hipparcos Number", "HIP 23924"},
        {"Smithsonian Astrophysical Observation", "SAO 233841"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.745,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.12182471),
        dec: Angle.Degrees(-56.98761113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195209"},
        {"Hipparcos Number", "HIP 101363"},
        {"Smithsonian Astrophysical Observation", "SAO 246623"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.15945458),
        dec: Angle.Degrees(-56.98718793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12010",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12010"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.70344734),
        dec: Angle.Degrees(-56.98564971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41441"},
        {"Hipparcos Number", "HIP 28560"},
        {"Smithsonian Astrophysical Observation", "SAO 234261"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.42308062),
        dec: Angle.Degrees(-56.98532921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36816"},
        {"Hipparcos Number", "HIP 25835"},
        {"Smithsonian Astrophysical Observation", "SAO 234013"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.73457691),
        dec: Angle.Degrees(-56.98385548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181820"},
        {"Hipparcos Number", "HIP 95463"},
        {"Geneva Identification System", "GEN# +1.00181820"},
        {"Smithsonian Astrophysical Observation", "SAO 246078"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.28890896),
        dec: Angle.Degrees(-56.98348785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90816",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90816"},
        {"Smithsonian Astrophysical Observation", "SAO 245526"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.88840461),
        dec: Angle.Degrees(-56.98335667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158894"},
        {"Hipparcos Number", "HIP 86048"},
        {"Smithsonian Astrophysical Observation", "SAO 244864"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.77638427),
        dec: Angle.Degrees(-56.98135809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107125"},
        {"Hipparcos Number", "HIP 60085"},
        {"Geneva Identification System", "GEN# +1.00107125"},
        {"Smithsonian Astrophysical Observation", "SAO 239842"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.82266257),
        dec: Angle.Degrees(-56.97989170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91747"},
        {"Hipparcos Number", "HIP 51738"},
        {"Smithsonian Astrophysical Observation", "SAO 238196"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.56634971),
        dec: Angle.Degrees(-56.97956898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191869"},
        {"Henry Draper 2", "HD 191869A"},
        {"Hipparcos Number", "HIP 99803"},
        {"Smithsonian Astrophysical Observation", "SAO 246498"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.73387783),
        dec: Angle.Degrees(-56.97624609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176110"},
        {"Hipparcos Number", "HIP 93455"},
        {"Geneva Identification System", "GEN# +1.00176110"},
        {"Smithsonian Astrophysical Observation", "SAO 245870"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.49509872),
        dec: Angle.Degrees(-56.97173862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -147.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98521"},
        {"Hipparcos Number", "HIP 55289"},
        {"Smithsonian Astrophysical Observation", "SAO 238961"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.84630341),
        dec: Angle.Degrees(-56.97123302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103426"},
        {"Hipparcos Number", "HIP 58059"},
        {"Smithsonian Astrophysical Observation", "SAO 239480"},
    },
    visualMagnitude: 6.92,
    bvColour: 1.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.61113424),
        dec: Angle.Degrees(-56.96977042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93443"},
        {"Hipparcos Number", "HIP 52658"},
        {"Smithsonian Astrophysical Observation", "SAO 238451"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.51844709),
        dec: Angle.Degrees(-56.96614726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219886"},
        {"Hipparcos Number", "HIP 115192"},
        {"Smithsonian Astrophysical Observation", "SAO 247832"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.97841996),
        dec: Angle.Degrees(-56.96541604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125447"},
        {"Hipparcos Number", "HIP 70166"},
        {"Smithsonian Astrophysical Observation", "SAO 241656"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.34123747),
        dec: Angle.Degrees(-56.96484516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103910",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103910"},
        {"Geneva Identification System", "GEN# +9.86211059"},
    },
    visualMagnitude: 12.88,
    bvColour: 1.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.80970266),
        dec: Angle.Degrees(-56.96429043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -357.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 353.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47276",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47276"},
    },
    visualMagnitude: 10.45,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.52633500),
        dec: Angle.Degrees(-56.96370259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83678"},
        {"Hipparcos Number", "HIP 47275"},
        {"Geneva Identification System", "GEN# +1.00083678"},
        {"Smithsonian Astrophysical Observation", "SAO 237168"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.52311294),
        dec: Angle.Degrees(-56.96085232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10950"},
        {"Hipparcos Number", "HIP 8236"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.51068410),
        dec: Angle.Degrees(-56.95888982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114513"},
        {"Hipparcos Number", "HIP 64406"},
        {"Celescope Catalog", "CEL 4214"},
        {"Geneva Identification System", "GEN# +1.00114513"},
        {"Smithsonian Astrophysical Observation", "SAO 240642"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.00976608),
        dec: Angle.Degrees(-56.95726925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59305"},
        {"Hipparcos Number", "HIP 36085"},
        {"Geneva Identification System", "GEN# +1.00059305"},
        {"Smithsonian Astrophysical Observation", "SAO 235193"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.52562095),
        dec: Angle.Degrees(-56.95657958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204494"},
        {"Hipparcos Number", "HIP 106237"},
        {"Geneva Identification System", "GEN# +1.00204494"},
        {"Smithsonian Astrophysical Observation", "SAO 247059"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.77552427),
        dec: Angle.Degrees(-56.95595265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53"},
        {"Hipparcos Number", "HIP 445"},
        {"Smithsonian Astrophysical Observation", "SAO 231922"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.34012165),
        dec: Angle.Degrees(-56.95562054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197370"},
        {"Hipparcos Number", "HIP 102463"},
        {"Geneva Identification System", "GEN# +1.00197370"},
        {"Smithsonian Astrophysical Observation", "SAO 246720"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.45162058),
        dec: Angle.Degrees(-56.95346158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84462"},
        {"Hipparcos Number", "HIP 47700"},
        {"Celescope Catalog", "CEL 3370"},
        {"Geneva Identification System", "GEN# +1.00084462"},
        {"Smithsonian Astrophysical Observation", "SAO 237267"},
    },
    visualMagnitude: 7.73,
    bvColour: -0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.88479255),
        dec: Angle.Degrees(-56.95293379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66608"},
        {"Hipparcos Number", "HIP 39232"},
        {"Smithsonian Astrophysical Observation", "SAO 235689"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.35936477),
        dec: Angle.Degrees(-56.94904691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26834"},
        {"Hipparcos Number", "HIP 19570"},
        {"Smithsonian Astrophysical Observation", "SAO 233429"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.89265653),
        dec: Angle.Degrees(-56.94760831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19949"},
        {"Hipparcos Number", "HIP 14691"},
        {"Geneva Identification System", "GEN# +2.12520034"},
        {"Smithsonian Astrophysical Observation", "SAO 233016"},
        {"New General Catalogue", "NGC 1252 34"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.45109917),
        dec: Angle.Degrees(-56.94673224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12109"},
        {"Hipparcos Number", "HIP 9091"},
        {"Smithsonian Astrophysical Observation", "SAO 232584"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.28356464),
        dec: Angle.Degrees(-56.94623998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87030"},
        {"Hipparcos Number", "HIP 49052"},
        {"Geneva Identification System", "GEN# +1.00087030"},
        {"Smithsonian Astrophysical Observation", "SAO 237586"},
    },
    visualMagnitude: 6.50,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.14409087),
        dec: Angle.Degrees(-56.94616519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131440"},
        {"Hipparcos Number", "HIP 73073"},
        {"Smithsonian Astrophysical Observation", "SAO 242117"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.00855026),
        dec: Angle.Degrees(-56.94511216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51929"},
        {"Hipparcos Number", "HIP 33324"},
        {"Cincinnati Publication", "Ci 20 404"},
        {"Geneva Identification System", "GEN# +1.00051929"},
        {"Smithsonian Astrophysical Observation", "SAO 234792"},
        {"Wilson Evans Batten Catalogue", "WEB 6698"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.97176121),
        dec: Angle.Degrees(-56.94394927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 632.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41596"},
        {"Hipparcos Number", "HIP 28633"},
        {"Smithsonian Astrophysical Observation", "SAO 234272"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.67885788),
        dec: Angle.Degrees(-56.94299001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142171"},
        {"Hipparcos Number", "HIP 78019"},
        {"Smithsonian Astrophysical Observation", "SAO 243128"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.95934561),
        dec: Angle.Degrees(-56.93893411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149591"},
        {"Hipparcos Number", "HIP 81502"},
        {"Smithsonian Astrophysical Observation", "SAO 244018"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.852,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.70595414),
        dec: Angle.Degrees(-56.93756523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86268"},
        {"Hipparcos Number", "HIP 48667"},
        {"Smithsonian Astrophysical Observation", "SAO 237502"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.88479840),
        dec: Angle.Degrees(-56.93581033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149715"},
        {"Hipparcos Number", "HIP 81581"},
        {"Smithsonian Astrophysical Observation", "SAO 244033"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.91740349),
        dec: Angle.Degrees(-56.93479175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167918"},
        {"Hipparcos Number", "HIP 89910"},
        {"Geneva Identification System", "GEN# +1.00167918"},
        {"Smithsonian Astrophysical Observation", "SAO 245411"},
    },
    visualMagnitude: 7.80,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.19927433),
        dec: Angle.Degrees(-56.93307926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3658"},
        {"Hipparcos Number", "HIP 3041"},
        {"Geneva Identification System", "GEN# +1.00003658"},
        {"Smithsonian Astrophysical Observation", "SAO 232128"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.66598572),
        dec: Angle.Degrees(-56.93247865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130736"},
        {"Hipparcos Number", "HIP 72723"},
        {"Smithsonian Astrophysical Observation", "SAO 242071"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.02689282),
        dec: Angle.Degrees(-56.93172388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -115.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14602"},
        {"Hipparcos Number", "HIP 10840"},
        {"Smithsonian Astrophysical Observation", "SAO 232711"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.88063682),
        dec: Angle.Degrees(-56.93155492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66367"},
        {"Hipparcos Number", "HIP 39114"},
        {"Smithsonian Astrophysical Observation", "SAO 235670"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.04156072),
        dec: Angle.Degrees(-56.93083306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5994"},
        {"Hipparcos Number", "HIP 4697"},
        {"Geneva Identification System", "GEN# +1.00005994"},
        {"Smithsonian Astrophysical Observation", "SAO 232255"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.09137595),
        dec: Angle.Degrees(-56.93003091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126182"},
        {"Hipparcos Number", "HIP 70543"},
        {"Fundamental Katalog 5th Edition", "FK5 5274"},
        {"Smithsonian Astrophysical Observation", "SAO 241709"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.46368119),
        dec: Angle.Degrees(-56.92284684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182161"},
        {"Hipparcos Number", "HIP 95592"},
        {"Smithsonian Astrophysical Observation", "SAO 246099"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.64417096),
        dec: Angle.Degrees(-56.92194024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125087"},
        {"Hipparcos Number", "HIP 69980"},
        {"Geneva Identification System", "GEN# +1.00125087"},
        {"Smithsonian Astrophysical Observation", "SAO 241628"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.78937731),
        dec: Angle.Degrees(-56.92167816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14100"},
        {"Hipparcos Number", "HIP 10470"},
        {"Smithsonian Astrophysical Observation", "SAO 232684"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.74532019),
        dec: Angle.Degrees(-56.92104714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158220"},
        {"Hipparcos Number", "HIP 85751"},
        {"Geneva Identification System", "GEN# +1.00158220"},
        {"Smithsonian Astrophysical Observation", "SAO 244808"},
        {"Wilson Evans Batten Catalogue", "WEB 14470"},
    },
    visualMagnitude: 5.99,
    bvColour: -0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.84701749),
        dec: Angle.Degrees(-56.92095404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20352"},
        {"Hipparcos Number", "HIP 15045"},
        {"Geneva Identification System", "GEN# +2.12520033"},
        {"Smithsonian Astrophysical Observation", "SAO 233045"},
        {"New General Catalogue", "NGC 1252 33"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.47395297),
        dec: Angle.Degrees(-56.91939250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43598"},
        {"Hipparcos Number", "HIP 29555"},
        {"Smithsonian Astrophysical Observation", "SAO 234387"},
    },
    visualMagnitude: 6.77,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.41852711),
        dec: Angle.Degrees(-56.91832291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132984"},
        {"Hipparcos Number", "HIP 73740"},
        {"Geneva Identification System", "GEN# +1.00132984"},
        {"Smithsonian Astrophysical Observation", "SAO 242202"},
    },
    visualMagnitude: 7.40,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.09915505),
        dec: Angle.Degrees(-56.91698889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38719"},
        {"Hipparcos Number", "HIP 27062"},
        {"Geneva Identification System", "GEN# +1.00038719"},
        {"Renson", "Renson 10410"},
        {"Smithsonian Astrophysical Observation", "SAO 234115"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.08387132),
        dec: Angle.Degrees(-56.91611483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139312"},
        {"Hipparcos Number", "HIP 76734"},
        {"Smithsonian Astrophysical Observation", "SAO 242810"},
    },
    visualMagnitude: 6.63,
    bvColour: 1.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.04565267),
        dec: Angle.Degrees(-56.91452125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83916",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83916"},
    },
    visualMagnitude: 11.38,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.25390032),
        dec: Angle.Degrees(-56.91327096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175440"},
        {"Hipparcos Number", "HIP 93167"},
        {"Smithsonian Astrophysical Observation", "SAO 245833"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.66038555),
        dec: Angle.Degrees(-56.91268969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109927"},
        {"Hipparcos Number", "HIP 61716"},
        {"Geneva Identification System", "GEN# +1.00109927"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.75501863),
        dec: Angle.Degrees(-56.91055252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114458"},
        {"Hipparcos Number", "HIP 64370"},
        {"Smithsonian Astrophysical Observation", "SAO 240637"},
    },
    visualMagnitude: 6.79,
    bvColour: 1.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.90034480),
        dec: Angle.Degrees(-56.90897973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140203"},
        {"Hipparcos Number", "HIP 77146"},
        {"Smithsonian Astrophysical Observation", "SAO 242908"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.26772871),
        dec: Angle.Degrees(-56.90881720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138589"},
        {"Hipparcos Number", "HIP 76361"},
        {"Smithsonian Astrophysical Observation", "SAO 242732"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.94672796),
        dec: Angle.Degrees(-56.90387852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81138"},
        {"Hipparcos Number", "HIP 45911"},
        {"Geneva Identification System", "GEN# +1.00081138"},
        {"Smithsonian Astrophysical Observation", "SAO 236885"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.41719619),
        dec: Angle.Degrees(-56.90351566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144506"},
        {"Henry Draper 2", "HD 144507"},
        {"Hipparcos Number", "HIP 79144"},
        {"Geneva Identification System", "GEN# +1.00144506"},
        {"Smithsonian Astrophysical Observation", "SAO 243366"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.30925847),
        dec: Angle.Degrees(-56.90206996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94827"},
        {"Hipparcos Number", "HIP 53432"},
        {"Geneva Identification System", "GEN# +1.00094827"},
        {"Smithsonian Astrophysical Observation", "SAO 238605"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.96334949),
        dec: Angle.Degrees(-56.90048264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100148"},
        {"Hipparcos Number", "HIP 56176"},
        {"Geneva Identification System", "GEN# +1.00100148"},
        {"Smithsonian Astrophysical Observation", "SAO 239133"},
        {"Wilson Evans Batten Catalogue", "WEB 10091"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.72681777),
        dec: Angle.Degrees(-56.89885034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87700"},
        {"Hipparcos Number", "HIP 49393"},
        {"Geneva Identification System", "GEN# +1.00087700"},
        {"Smithsonian Astrophysical Observation", "SAO 237677"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.25767022),
        dec: Angle.Degrees(-56.89796114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163071"},
        {"Hipparcos Number", "HIP 87928"},
        {"Fundamental Katalog 5th Edition", "FK5 3426"},
        {"Geneva Identification System", "GEN# +1.00163071"},
        {"Smithsonian Astrophysical Observation", "SAO 245133"},
    },
    visualMagnitude: 6.26,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.42807533),
        dec: Angle.Degrees(-56.89622335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106218"},
        {"Hipparcos Number", "HIP 59603"},
        {"Smithsonian Astrophysical Observation", "SAO 239765"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.34325563),
        dec: Angle.Degrees(-56.89320660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123148"},
        {"Hipparcos Number", "HIP 69008"},
        {"Celescope Catalog", "CEL 4302"},
        {"Geneva Identification System", "GEN# +1.00123148"},
        {"Smithsonian Astrophysical Observation", "SAO 241462"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.91469909),
        dec: Angle.Degrees(-56.89109119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29899"},
        {"Hipparcos Number", "HIP 21692"},
        {"Geneva Identification System", "GEN# +1.00029899"},
        {"Smithsonian Astrophysical Observation", "SAO 233613"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.85601885),
        dec: Angle.Degrees(-56.88888787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155341"},
        {"Hipparcos Number", "HIP 84311"},
        {"Geneva Identification System", "GEN# +1.00155341"},
        {"Smithsonian Astrophysical Observation", "SAO 244539"},
    },
    visualMagnitude: 6.08,
    bvColour: 1.728,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.55585391),
        dec: Angle.Degrees(-56.88851206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127297"},
        {"Hipparcos Number", "HIP 71116"},
        {"Geneva Identification System", "GEN# +1.00127297"},
        {"Smithsonian Astrophysical Observation", "SAO 241777"},
        {"Wilson Evans Batten Catalogue", "WEB 12296"},
    },
    visualMagnitude: 6.71,
    bvColour: 0.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.13787800),
        dec: Angle.Degrees(-56.88769787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141017"},
        {"Hipparcos Number", "HIP 77505"},
        {"Geneva Identification System", "GEN# +1.00141017"},
        {"Smithsonian Astrophysical Observation", "SAO 243010"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.39010385),
        dec: Angle.Degrees(-56.88537994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147670"},
        {"Hipparcos Number", "HIP 80531"},
        {"Renson", "Renson 41666"},
        {"Smithsonian Astrophysical Observation", "SAO 243796"},
    },
    visualMagnitude: 7.83,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.59966322),
        dec: Angle.Degrees(-56.88450444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94330"},
        {"Hipparcos Number", "HIP 53136"},
        {"Celescope Catalog", "CEL 3746"},
        {"Geneva Identification System", "GEN# +1.00094330"},
        {"Smithsonian Astrophysical Observation", "SAO 238549"},
    },
    visualMagnitude: 8.69,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.04548034),
        dec: Angle.Degrees(-56.88232570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172781"},
        {"Hipparcos Number", "HIP 92021"},
        {"Geneva Identification System", "GEN# +1.00172781"},
        {"Smithsonian Astrophysical Observation", "SAO 245681"},
    },
    visualMagnitude: 6.22,
    bvColour: 1.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.34969323),
        dec: Angle.Degrees(-56.88191929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130980"},
        {"Hipparcos Number", "HIP 72842"},
        {"Smithsonian Astrophysical Observation", "SAO 242088"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.34088695),
        dec: Angle.Degrees(-56.88177520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21255"},
        {"Hipparcos Number", "HIP 15758"},
        {"Smithsonian Astrophysical Observation", "SAO 233099"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.76723755),
        dec: Angle.Degrees(-56.88084766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113706"},
        {"Hipparcos Number", "HIP 63962"},
        {"Smithsonian Astrophysical Observation", "SAO 240549"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.61429888),
        dec: Angle.Degrees(-56.87909661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220996"},
        {"Hipparcos Number", "HIP 115895"},
        {"Geneva Identification System", "GEN# +1.00220996"},
        {"Smithsonian Astrophysical Observation", "SAO 247894"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.20564373),
        dec: Angle.Degrees(-56.87840770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12287B"},
        {"Hipparcos Number", "HIP 9247"},
        {"Geneva Identification System", "GEN# -0.05700385"},
        {"Smithsonian Astrophysical Observation", "SAO 232591"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.72537764),
        dec: Angle.Degrees(-56.87614336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 136.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 127.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3317",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3317"},
        {"Geneva Identification System", "GEN# +6.20145171"},
    },
    visualMagnitude: 10.45,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.56807572),
        dec: Angle.Degrees(-56.87556696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216847"},
        {"Hipparcos Number", "HIP 113351"},
        {"Geneva Identification System", "GEN# +1.00216847"},
        {"Smithsonian Astrophysical Observation", "SAO 247655"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.34163380),
        dec: Angle.Degrees(-56.87522342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91626",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91626"},
        {"Geneva Identification System", "GEN# +6.20145018"},
    },
    visualMagnitude: 10.49,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.29786930),
        dec: Angle.Degrees(-56.87416639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44344"},
        {"Hipparcos Number", "HIP 29926"},
        {"Smithsonian Astrophysical Observation", "SAO 234436"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.49901445),
        dec: Angle.Degrees(-56.87234378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109577"},
        {"Hipparcos Number", "HIP 61516"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.796,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.05268627),
        dec: Angle.Degrees(-56.86996009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12287"},
        {"Hipparcos Number", "HIP 9243"},
        {"Geneva Identification System", "GEN# +1.00012287"},
        {"Smithsonian Astrophysical Observation", "SAO 232590"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.71103319),
        dec: Angle.Degrees(-56.86991378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 137.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 126.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83658"},
        {"Hipparcos Number", "HIP 47271"},
        {"Smithsonian Astrophysical Observation", "SAO 237165"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.51357899),
        dec: Angle.Degrees(-56.86712976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103922"},
        {"Hipparcos Number", "HIP 58356"},
        {"Fundamental Katalog 5th Edition", "FK5 5053"},
        {"Smithsonian Astrophysical Observation", "SAO 239529"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.50107114),
        dec: Angle.Degrees(-56.86499234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86572"},
        {"Hipparcos Number", "HIP 48827"},
        {"Smithsonian Astrophysical Observation", "SAO 237533"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.40636111),
        dec: Angle.Degrees(-56.86392473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96367"},
        {"Hipparcos Number", "HIP 54221"},
        {"Smithsonian Astrophysical Observation", "SAO 238759"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.41452174),
        dec: Angle.Degrees(-56.86300248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7097"},
        {"Hipparcos Number", "HIP 5488"},
        {"Geneva Identification System", "GEN# +1.00007097"},
        {"Smithsonian Astrophysical Observation", "SAO 232325"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.56509640),
        dec: Angle.Degrees(-56.86280594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37489",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37489"},
        {"Smithsonian Astrophysical Observation", "SAO 235420"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.43033474),
        dec: Angle.Degrees(-56.86122222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119044"},
        {"Hipparcos Number", "HIP 66879"},
        {"Smithsonian Astrophysical Observation", "SAO 241087"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.59576694),
        dec: Angle.Degrees(-56.86053253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103345"},
        {"Hipparcos Number", "HIP 58015"},
        {"Smithsonian Astrophysical Observation", "SAO 239471"},
    },
    visualMagnitude: 9.00,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.49057140),
        dec: Angle.Degrees(-56.86025157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70605"},
        {"Hipparcos Number", "HIP 40838"},
        {"Celescope Catalog", "CEL 2396"},
        {"Geneva Identification System", "GEN# +1.00070605"},
        {"Smithsonian Astrophysical Observation", "SAO 235895"},
    },
    visualMagnitude: 8.02,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.00709238),
        dec: Angle.Degrees(-56.85828831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39519",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39519"},
    },
    visualMagnitude: 10.31,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.15472077),
        dec: Angle.Degrees(-56.85785103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110132"},
        {"Hipparcos Number", "HIP 61845"},
        {"Smithsonian Astrophysical Observation", "SAO 240135"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.12494457),
        dec: Angle.Degrees(-56.85484455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143306"},
        {"Hipparcos Number", "HIP 78562"},
        {"Geneva Identification System", "GEN# +1.00143306"},
        {"Smithsonian Astrophysical Observation", "SAO 243265"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.61913351),
        dec: Angle.Degrees(-56.85416835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -145.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -120.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111289"},
        {"Hipparcos Number", "HIP 62538"},
        {"Geneva Identification System", "GEN# +1.00111289"},
        {"Smithsonian Astrophysical Observation", "SAO 240275"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.22153071),
        dec: Angle.Degrees(-56.85348443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46355"},
        {"Hipparcos Number", "HIP 30932"},
        {"Fundamental Katalog 5th Edition", "FK5 2498"},
        {"Geneva Identification System", "GEN# +1.00046355"},
        {"Smithsonian Astrophysical Observation", "SAO 234541"},
        {"Wilson Evans Batten Catalogue", "WEB 6161"},
    },
    visualMagnitude: 5.20,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.36891553),
        dec: Angle.Degrees(-56.85284448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1570"},
        {"Hipparcos Number", "HIP 1577"},
        {"Smithsonian Astrophysical Observation", "SAO 232002"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.93125297),
        dec: Angle.Degrees(-56.85150141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209807"},
        {"Hipparcos Number", "HIP 109227"},
        {"Geneva Identification System", "GEN# +1.00209807"},
        {"Smithsonian Astrophysical Observation", "SAO 247316"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.936,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.91456824),
        dec: Angle.Degrees(-56.85103664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119782"},
        {"Hipparcos Number", "HIP 67237"},
        {"Geneva Identification System", "GEN# +1.00119782"},
        {"Smithsonian Astrophysical Observation", "SAO 241156"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.856,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.67536714),
        dec: Angle.Degrees(-56.84966245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -170.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220572"},
        {"Hipparcos Number", "HIP 115620"},
        {"Geneva Identification System", "GEN# +1.00220572"},
        {"Smithsonian Astrophysical Observation", "SAO 247867"},
        {"Wilson Evans Batten Catalogue", "WEB 20463"},
    },
    visualMagnitude: 5.60,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.33072811),
        dec: Angle.Degrees(-56.84893507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13604"},
        {"Hipparcos Number", "HIP 10178"},
        {"Smithsonian Astrophysical Observation", "SAO 232663"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.72196758),
        dec: Angle.Degrees(-56.84780068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122988"},
        {"Hipparcos Number", "HIP 68942"},
        {"Smithsonian Astrophysical Observation", "SAO 241448"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.68779306),
        dec: Angle.Degrees(-56.84749556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114716",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114716"},
        {"Geneva Identification System", "GEN# +6.20145128"},
    },
    visualMagnitude: 11.99,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.56592592),
        dec: Angle.Degrees(-56.84719808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -414.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -256.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 120416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191466"},
        {"Hipparcos Number", "HIP 120416"},
        {"Smithsonian Astrophysical Observation", "SAO 246485"},
    },
    visualMagnitude: 8.71,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)12, 58.0800),
        dec: Angle.DegreesMinutesSeconds((int)-56, (int)50, 47.900)
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
    primaryId: "HIP 53478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94908"},
        {"Hipparcos Number", "HIP 53478"},
        {"Smithsonian Astrophysical Observation", "SAO 238612"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.10065350),
        dec: Angle.Degrees(-56.84499823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170339"},
        {"Hipparcos Number", "HIP 90878"},
        {"Smithsonian Astrophysical Observation", "SAO 245533"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.06423394),
        dec: Angle.Degrees(-56.83911179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 273"},
        {"Hipparcos Number", "HIP 605"},
        {"Smithsonian Astrophysical Observation", "SAO 231930"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.84185174),
        dec: Angle.Degrees(-56.83685592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112244"},
        {"Hipparcos Number", "HIP 63117"},
        {"Celescope Catalog", "CEL 4172"},
        {"Geneva Identification System", "GEN# +1.00112244"},
        {"Smithsonian Astrophysical Observation", "SAO 240385"},
        {"Wilson Evans Batten Catalogue", "WEB 11189"},
    },
    visualMagnitude: 5.34,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.98808228),
        dec: Angle.Degrees(-56.83580429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123434"},
        {"Hipparcos Number", "HIP 69153"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.34541469),
        dec: Angle.Degrees(-56.83556652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47"},
    },
    visualMagnitude: 10.78,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.13519236),
        dec: Angle.Degrees(-56.83524773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -145.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123752"},
        {"Hipparcos Number", "HIP 69330"},
        {"Smithsonian Astrophysical Observation", "SAO 241514"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.83839903),
        dec: Angle.Degrees(-56.83109142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215239"},
        {"Hipparcos Number", "HIP 112302"},
        {"Smithsonian Astrophysical Observation", "SAO 247564"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.20825418),
        dec: Angle.Degrees(-56.82701985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 302093"},
        {"Hipparcos Number", "HIP 44839"},
        {"Smithsonian Astrophysical Observation", "SAO 236645"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.03704016),
        dec: Angle.Degrees(-56.82616311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221738"},
        {"Hipparcos Number", "HIP 116387"},
        {"Fundamental Katalog 5th Edition", "FK5 3892"},
        {"Geneva Identification System", "GEN# +1.00221738"},
        {"Smithsonian Astrophysical Observation", "SAO 247933"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.75905525),
        dec: Angle.Degrees(-56.82531676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19660"},
        {"Hipparcos Number", "HIP 14510"},
        {"Smithsonian Astrophysical Observation", "SAO 232999"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.84080432),
        dec: Angle.Degrees(-56.82341216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160656"},
        {"Hipparcos Number", "HIP 86827"},
        {"Smithsonian Astrophysical Observation", "SAO 244982"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.12866073),
        dec: Angle.Degrees(-56.82267868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164749"},
        {"Hipparcos Number", "HIP 88666"},
        {"Smithsonian Astrophysical Observation", "SAO 245235"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.52249947),
        dec: Angle.Degrees(-56.82178428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159441"},
        {"Hipparcos Number", "HIP 86306"},
        {"Geneva Identification System", "GEN# +1.00159441"},
        {"Smithsonian Astrophysical Observation", "SAO 244895"},
        {"Wilson Evans Batten Catalogue", "WEB 14560"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.52347062),
        dec: Angle.Degrees(-56.82134835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47410"},
        {"Hipparcos Number", "HIP 31418"},
        {"Smithsonian Astrophysical Observation", "SAO 234591"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.76635971),
        dec: Angle.Degrees(-56.81734544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30895"},
        {"Hipparcos Number", "HIP 22302"},
        {"Fundamental Katalog 5th Edition", "FK5 4435"},
        {"Smithsonian Astrophysical Observation", "SAO 233690"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.04799996),
        dec: Angle.Degrees(-56.81727238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35651"},
        {"Hipparcos Number", "HIP 25149"},
        {"Smithsonian Astrophysical Observation", "SAO 233955"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.72417704),
        dec: Angle.Degrees(-56.81640848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39216"},
        {"Hipparcos Number", "HIP 27356"},
        {"Smithsonian Astrophysical Observation", "SAO 234142"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.90769748),
        dec: Angle.Degrees(-56.81638281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15051"},
        {"Hipparcos Number", "HIP 11145"},
        {"Smithsonian Astrophysical Observation", "SAO 232745"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.84955701),
        dec: Angle.Degrees(-56.81331752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142892"},
        {"Hipparcos Number", "HIP 78358"},
        {"Smithsonian Astrophysical Observation", "SAO 243216"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.97852059),
        dec: Angle.Degrees(-56.81130855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162380"},
        {"Hipparcos Number", "HIP 87648"},
        {"Smithsonian Astrophysical Observation", "SAO 245102"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.54584935),
        dec: Angle.Degrees(-56.80944371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189651"},
        {"Hipparcos Number", "HIP 98810"},
        {"Smithsonian Astrophysical Observation", "SAO 246414"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.00719958),
        dec: Angle.Degrees(-56.80740425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45366"},
        {"Hipparcos Number", "HIP 30405"},
        {"Smithsonian Astrophysical Observation", "SAO 234477"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.89828444),
        dec: Angle.Degrees(-56.80609967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221581"},
        {"Hipparcos Number", "HIP 116284"},
        {"Smithsonian Astrophysical Observation", "SAO 247926"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.40704755),
        dec: Angle.Degrees(-56.80339758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196802"},
        {"Hipparcos Number", "HIP 102179"},
        {"Smithsonian Astrophysical Observation", "SAO 246697"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.55605149),
        dec: Angle.Degrees(-56.80327009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111872"},
        {"Hipparcos Number", "HIP 62862"},
        {"Geneva Identification System", "GEN# +1.00111872"},
        {"Smithsonian Astrophysical Observation", "SAO 240346"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.26915634),
        dec: Angle.Degrees(-56.80227411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155299"},
        {"Hipparcos Number", "HIP 84288"},
        {"Geneva Identification System", "GEN# +1.00155299"},
        {"Smithsonian Astrophysical Observation", "SAO 244536"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.47126625),
        dec: Angle.Degrees(-56.80050491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5178",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5178"},
    },
    visualMagnitude: 11.20,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.55398637),
        dec: Angle.Degrees(-56.80034711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 162.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 161.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150185"},
        {"Hipparcos Number", "HIP 81801"},
        {"Smithsonian Astrophysical Observation", "SAO 244076"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.61652487),
        dec: Angle.Degrees(-56.80008675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148191"},
        {"Hipparcos Number", "HIP 80772"},
        {"Geneva Identification System", "GEN# +1.00148191"},
        {"Smithsonian Astrophysical Observation", "SAO 243867"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.37974252),
        dec: Angle.Degrees(-56.79877557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13519",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13519"},
        {"Smithsonian Astrophysical Observation", "SAO 232936"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.52691818),
        dec: Angle.Degrees(-56.79627779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15614"},
        {"Hipparcos Number", "HIP 11516"},
        {"Smithsonian Astrophysical Observation", "SAO 232785"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.12623497),
        dec: Angle.Degrees(-56.79407777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122897"},
        {"Hipparcos Number", "HIP 68876"},
        {"Smithsonian Astrophysical Observation", "SAO 241435"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.55105590),
        dec: Angle.Degrees(-56.78887231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105907"},
        {"Hipparcos Number", "HIP 59434"},
        {"Smithsonian Astrophysical Observation", "SAO 239732"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.86986597),
        dec: Angle.Degrees(-56.78763088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126436"},
        {"Hipparcos Number", "HIP 70676"},
        {"Smithsonian Astrophysical Observation", "SAO 241722"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.83164951),
        dec: Angle.Degrees(-56.78479683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14703"},
        {"Hipparcos Number", "HIP 10907"},
        {"Geneva Identification System", "GEN# +1.00014703"},
        {"Smithsonian Astrophysical Observation", "SAO 232722"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.948,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.09539434),
        dec: Angle.Degrees(-56.78408860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33229"},
        {"Hipparcos Number", "HIP 23672"},
        {"Geneva Identification System", "GEN# +1.00033229"},
        {"Smithsonian Astrophysical Observation", "SAO 233820"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.32862753),
        dec: Angle.Degrees(-56.78149686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98939"},
        {"Hipparcos Number", "HIP 55538"},
        {"Fundamental Katalog 5th Edition", "FK5 4999"},
        {"Smithsonian Astrophysical Observation", "SAO 239008"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.63245702),
        dec: Angle.Degrees(-56.78064193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58116"},
        {"Hipparcos Number", "HIP 35613"},
        {"Smithsonian Astrophysical Observation", "SAO 235131"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.22883854),
        dec: Angle.Degrees(-56.78019598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209100"},
        {"Hipparcos Number", "HIP 108870"},
        {"Cincinnati Publication", "Ci 20 1330"},
        {"Fundamental Katalog 5th Edition", "FK5 825"},
        {"Geneva Identification System", "GEN# +1.00209100"},
        {"Smithsonian Astrophysical Observation", "SAO 247287"},
        {"Wilson Evans Batten Catalogue", "WEB 19578"},
    },
    visualMagnitude: 4.69,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.82266498),
        dec: Angle.Degrees(-56.77980602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3959.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2538.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99022"},
        {"Hipparcos Number", "HIP 55581"},
        {"Fundamental Katalog 5th Edition", "FK5 2910"},
        {"Geneva Identification System", "GEN# +1.00099022"},
        {"Smithsonian Astrophysical Observation", "SAO 239017"},
    },
    visualMagnitude: 5.82,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.78402208),
        dec: Angle.Degrees(-56.77936853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106445"},
        {"Hipparcos Number", "HIP 59710"},
        {"Smithsonian Astrophysical Observation", "SAO 239786"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.69400719),
        dec: Angle.Degrees(-56.77906532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121678"},
        {"Hipparcos Number", "HIP 68255"},
        {"Geneva Identification System", "GEN# +1.00121678"},
        {"Smithsonian Astrophysical Observation", "SAO 241337"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.59979866),
        dec: Angle.Degrees(-56.77906252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -138.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184193"},
        {"Hipparcos Number", "HIP 96432"},
        {"Smithsonian Astrophysical Observation", "SAO 246179"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.07893498),
        dec: Angle.Degrees(-56.77842757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107789"},
        {"Hipparcos Number", "HIP 60432"},
        {"Smithsonian Astrophysical Observation", "SAO 239908"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.86141066),
        dec: Angle.Degrees(-56.77586865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107424"},
        {"Hipparcos Number", "HIP 60243"},
        {"Celescope Catalog", "CEL 4094"},
        {"Geneva Identification System", "GEN# +1.00107424"},
        {"Smithsonian Astrophysical Observation", "SAO 239866"},
    },
    visualMagnitude: 7.75,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.29595694),
        dec: Angle.Degrees(-56.77402794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223801"},
        {"Hipparcos Number", "HIP 117757"},
        {"Fundamental Katalog 5th Edition", "FK5 6116"},
        {"Geneva Identification System", "GEN# +1.00223801"},
        {"Smithsonian Astrophysical Observation", "SAO 248051"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.21473233),
        dec: Angle.Degrees(-56.77370875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217059"},
        {"Hipparcos Number", "HIP 113475"},
        {"Smithsonian Astrophysical Observation", "SAO 247664"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.70808729),
        dec: Angle.Degrees(-56.77336454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101945"},
        {"Hipparcos Number", "HIP 57188"},
        {"Smithsonian Astrophysical Observation", "SAO 239326"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.90189720),
        dec: Angle.Degrees(-56.77118366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127782"},
        {"Hipparcos Number", "HIP 71334"},
        {"Geneva Identification System", "GEN# +2.56620061"},
        {"Smithsonian Astrophysical Observation", "SAO 241815"},
        {"New General Catalogue", "NGC 5662 61"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.82191992),
        dec: Angle.Degrees(-56.77104331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75311"},
        {"Hipparcos Number", "HIP 43105"},
        {"Celescope Catalog", "CEL 2909"},
        {"Fundamental Katalog 5th Edition", "FK5 2695"},
        {"Geneva Identification System", "GEN# +1.00075311"},
        {"Smithsonian Astrophysical Observation", "SAO 236268"},
        {"Wilson Evans Batten Catalogue", "WEB 8320"},
    },
    visualMagnitude: 4.50,
    bvColour: -0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.67733004),
        dec: Angle.Degrees(-56.76979718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178152"},
        {"Hipparcos Number", "HIP 94209"},
        {"Smithsonian Astrophysical Observation", "SAO 245953"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.68863923),
        dec: Angle.Degrees(-56.76863662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119159"},
        {"Hipparcos Number", "HIP 66925"},
        {"Fundamental Katalog 5th Edition", "FK5 1356"},
        {"Geneva Identification System", "GEN# +1.00119159"},
        {"Smithsonian Astrophysical Observation", "SAO 241096"},
        {"Wilson Evans Batten Catalogue", "WEB 11797"},
    },
    visualMagnitude: 6.00,
    bvColour: -0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.73382472),
        dec: Angle.Degrees(-56.76795968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114168"},
        {"Hipparcos Number", "HIP 64223"},
        {"Celescope Catalog", "CEL 4207"},
        {"Geneva Identification System", "GEN# +1.00114168"},
        {"Smithsonian Astrophysical Observation", "SAO 240604"},
    },
    visualMagnitude: 8.60,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.43539379),
        dec: Angle.Degrees(-56.76787821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165235"},
        {"Hipparcos Number", "HIP 88853"},
        {"Smithsonian Astrophysical Observation", "SAO 245260"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.09456645),
        dec: Angle.Degrees(-56.76719533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95633"},
        {"Hipparcos Number", "HIP 53874"},
        {"Smithsonian Astrophysical Observation", "SAO 238697"},
    },
    visualMagnitude: 8.03,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.33234829),
        dec: Angle.Degrees(-56.76716048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71590"},
        {"Hipparcos Number", "HIP 41289"},
        {"Smithsonian Astrophysical Observation", "SAO 235966"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.36232577),
        dec: Angle.Degrees(-56.76480084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25268"},
        {"Hipparcos Number", "HIP 18536"},
        {"Smithsonian Astrophysical Observation", "SAO 233342"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.47747367),
        dec: Angle.Degrees(-56.76416775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87374",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87374"},
    },
    visualMagnitude: 12.29,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.78611615),
        dec: Angle.Degrees(-56.76279967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -131.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 300330"},
        {"Hipparcos Number", "HIP 48028"},
        {"Celescope Catalog", "CEL 3382"},
        {"Geneva Identification System", "GEN# +1.00300330"},
        {"Smithsonian Astrophysical Observation", "SAO 237342"},
    },
    visualMagnitude: 7.69,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.85231509),
        dec: Angle.Degrees(-56.76264616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167853"},
        {"Hipparcos Number", "HIP 89888"},
        {"Smithsonian Astrophysical Observation", "SAO 245404"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.12004122),
        dec: Angle.Degrees(-56.76170862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29359"},
        {"Hipparcos Number", "HIP 21303"},
        {"Geneva Identification System", "GEN# +1.00029359"},
        {"Smithsonian Astrophysical Observation", "SAO 233569"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.56981495),
        dec: Angle.Degrees(-56.75923128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77022"},
        {"Hipparcos Number", "HIP 43971"},
        {"Smithsonian Astrophysical Observation", "SAO 236443"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.31265657),
        dec: Angle.Degrees(-56.75879658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93563"},
        {"Hipparcos Number", "HIP 52742"},
        {"Celescope Catalog", "CEL 3701"},
        {"Geneva Identification System", "GEN# +1.00093563"},
        {"Smithsonian Astrophysical Observation", "SAO 238468"},
        {"Wilson Evans Batten Catalogue", "WEB 9601"},
    },
    visualMagnitude: 5.14,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.73956163),
        dec: Angle.Degrees(-56.75719080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132787"},
        {"Hipparcos Number", "HIP 73647"},
        {"Geneva Identification System", "GEN# +1.00132787"},
        {"Smithsonian Astrophysical Observation", "SAO 242191"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.81231319),
        dec: Angle.Degrees(-56.75714269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69517"},
        {"Hipparcos Number", "HIP 40363"},
        {"Smithsonian Astrophysical Observation", "SAO 235831"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.61979939),
        dec: Angle.Degrees(-56.75660537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80308"},
        {"Hipparcos Number", "HIP 45531"},
        {"Geneva Identification System", "GEN# +1.00080308"},
        {"Smithsonian Astrophysical Observation", "SAO 236804"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.18117103),
        dec: Angle.Degrees(-56.75011935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210286"},
        {"Hipparcos Number", "HIP 109504"},
        {"Smithsonian Astrophysical Observation", "SAO 247342"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.74801885),
        dec: Angle.Degrees(-56.74990241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54118"},
        {"Hipparcos Number", "HIP 34105"},
        {"Fundamental Katalog 5th Edition", "FK5 272"},
        {"Geneva Identification System", "GEN# +1.00054118"},
        {"Renson", "Renson 14860"},
        {"Smithsonian Astrophysical Observation", "SAO 234902"},
        {"Wilson Evans Batten Catalogue", "WEB 6841"},
    },
    visualMagnitude: 5.14,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.07632905),
        dec: Angle.Degrees(-56.74973130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158205"},
        {"Hipparcos Number", "HIP 85743"},
        {"Renson", "Renson 44500"},
        {"Smithsonian Astrophysical Observation", "SAO 244807"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.82787240),
        dec: Angle.Degrees(-56.74905131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88385"},
        {"Hipparcos Number", "HIP 49791"},
        {"Geneva Identification System", "GEN# +1.00088385"},
        {"Renson", "Renson 25310"},
        {"Smithsonian Astrophysical Observation", "SAO 237750"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.45612869),
        dec: Angle.Degrees(-56.74817014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188356"},
        {"Hipparcos Number", "HIP 98231"},
        {"Smithsonian Astrophysical Observation", "SAO 246353"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.43770275),
        dec: Angle.Degrees(-56.74659363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195913"},
        {"Hipparcos Number", "HIP 101695"},
        {"Smithsonian Astrophysical Observation", "SAO 246656"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.18950396),
        dec: Angle.Degrees(-56.74608434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113780"},
        {"Hipparcos Number", "HIP 64005"},
        {"Smithsonian Astrophysical Observation", "SAO 240557"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.73436291),
        dec: Angle.Degrees(-56.74404571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69454",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69454"},
    },
    visualMagnitude: 10.20,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.30206876),
        dec: Angle.Degrees(-56.74249371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 355.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 178.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198830"},
        {"Hipparcos Number", "HIP 103290"},
        {"Smithsonian Astrophysical Observation", "SAO 246793"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.89040050),
        dec: Angle.Degrees(-56.74193947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40313",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40313"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.47561977),
        dec: Angle.Degrees(-56.74023971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119599"},
        {"Hipparcos Number", "HIP 67137"},
        {"Smithsonian Astrophysical Observation", "SAO 241141"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.39122155),
        dec: Angle.Degrees(-56.73742241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100751",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Peacock"},
        {"Henry Draper", "HD 193924"},
        {"Hipparcos Number", "HIP 100751"},
        {"Fundamental Katalog 5th Edition", "FK5 764"},
        {"Geneva Identification System", "GEN# +1.00193924A"},
        {"Smithsonian Astrophysical Observation", "SAO 246574"},
        {"Wilson Evans Batten Catalogue", "WEB 18206"},
    },
    visualMagnitude: 1.94,
    bvColour: -0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.41187347),
        dec: Angle.Degrees(-56.73488071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91995"},
        {"Hipparcos Number", "HIP 51891"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.02705840),
        dec: Angle.Degrees(-56.73308592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8435"},
        {"Hipparcos Number", "HIP 6408"},
        {"Geneva Identification System", "GEN# +1.00008435"},
        {"Smithsonian Astrophysical Observation", "SAO 232399"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.57914492),
        dec: Angle.Degrees(-56.73136927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118489"},
        {"Hipparcos Number", "HIP 66553"},
        {"Geneva Identification System", "GEN# +1.00118489"},
        {"Smithsonian Astrophysical Observation", "SAO 241023"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.63931399),
        dec: Angle.Degrees(-56.73082895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78271"},
        {"Hipparcos Number", "HIP 44572"},
        {"Smithsonian Astrophysical Observation", "SAO 236579"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.22068634),
        dec: Angle.Degrees(-56.73039896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219249"},
        {"Hipparcos Number", "HIP 114790"},
        {"Geneva Identification System", "GEN# +1.00219249"},
        {"Smithsonian Astrophysical Observation", "SAO 247795"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.78925926),
        dec: Angle.Degrees(-56.72941983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 243.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 84.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103234"},
        {"Hipparcos Number", "HIP 57950"},
        {"Geneva Identification System", "GEN# +1.00103234"},
        {"Smithsonian Astrophysical Observation", "SAO 239459"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.28354291),
        dec: Angle.Degrees(-56.72722587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63382"},
        {"Hipparcos Number", "HIP 37854"},
        {"Geneva Identification System", "GEN# +1.00063382"},
        {"Smithsonian Astrophysical Observation", "SAO 235490"},
    },
    visualMagnitude: 6.10,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.39800467),
        dec: Angle.Degrees(-56.72259670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101637"},
        {"Hipparcos Number", "HIP 57018"},
        {"Smithsonian Astrophysical Observation", "SAO 239293"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.35496190),
        dec: Angle.Degrees(-56.72257583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187272"},
        {"Hipparcos Number", "HIP 97771"},
        {"Smithsonian Astrophysical Observation", "SAO 246306"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.02497274),
        dec: Angle.Degrees(-56.71960713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198422"},
        {"Hipparcos Number", "HIP 103052"},
        {"Smithsonian Astrophysical Observation", "SAO 246763"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.18276487),
        dec: Angle.Degrees(-56.71960240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189545"},
        {"Hipparcos Number", "HIP 98751"},
        {"Smithsonian Astrophysical Observation", "SAO 246410"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.86866247),
        dec: Angle.Degrees(-56.71905072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107250"},
        {"Hipparcos Number", "HIP 60153"},
        {"Celescope Catalog", "CEL 4091"},
        {"Geneva Identification System", "GEN# +1.00107250"},
        {"Smithsonian Astrophysical Observation", "SAO 239851"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.02624051),
        dec: Angle.Degrees(-56.71754093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93096"},
        {"Hipparcos Number", "HIP 52486"},
        {"Smithsonian Astrophysical Observation", "SAO 238391"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.95940675),
        dec: Angle.Degrees(-56.71738054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34230"},
        {"Hipparcos Number", "HIP 24267"},
        {"Smithsonian Astrophysical Observation", "SAO 233875"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.794,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.12268632),
        dec: Angle.Degrees(-56.71637371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73504"},
        {"Hipparcos Number", "HIP 42191"},
        {"Geneva Identification System", "GEN# +1.00073504"},
        {"Smithsonian Astrophysical Observation", "SAO 236117"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.04260198),
        dec: Angle.Degrees(-56.71225867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63203"},
        {"Hipparcos Number", "HIP 37763"},
        {"Smithsonian Astrophysical Observation", "SAO 235477"},
    },
    visualMagnitude: 8.31,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.16108503),
        dec: Angle.Degrees(-56.70880205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105786"},
        {"Hipparcos Number", "HIP 59363"},
        {"Smithsonian Astrophysical Observation", "SAO 239718"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.68694992),
        dec: Angle.Degrees(-56.70822444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208451"},
        {"Hipparcos Number", "HIP 108446"},
        {"Smithsonian Astrophysical Observation", "SAO 247245"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.52618556),
        dec: Angle.Degrees(-56.70571642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43633",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43633"},
        {"Smithsonian Astrophysical Observation", "SAO 236372"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.29304783),
        dec: Angle.Degrees(-56.70468640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95479"},
        {"Hipparcos Number", "HIP 53796"},
        {"Smithsonian Astrophysical Observation", "SAO 238681"},
    },
    visualMagnitude: 8.26,
    bvColour: -0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.09490654),
        dec: Angle.Degrees(-56.70274576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120797"},
        {"Hipparcos Number", "HIP 67791"},
        {"Geneva Identification System", "GEN# +1.00120797"},
        {"Smithsonian Astrophysical Observation", "SAO 241255"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.31536408),
        dec: Angle.Degrees(-56.69851843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215247"},
        {"Hipparcos Number", "HIP 112315"},
        {"Geneva Identification System", "GEN# +1.00215247"},
        {"Smithsonian Astrophysical Observation", "SAO 247566"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.24624034),
        dec: Angle.Degrees(-56.69493245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99116"},
        {"Hipparcos Number", "HIP 55633"},
        {"Geneva Identification System", "GEN# +1.00099116"},
        {"Smithsonian Astrophysical Observation", "SAO 239029"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.723,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.95808702),
        dec: Angle.Degrees(-56.69451793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 214.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -133.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143102"},
        {"Hipparcos Number", "HIP 78479"},
        {"Geneva Identification System", "GEN# +1.00143102"},
        {"Smithsonian Astrophysical Observation", "SAO 243248"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.30405369),
        dec: Angle.Degrees(-56.69431125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -200.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -252.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148662"},
        {"Hipparcos Number", "HIP 81021"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.20794781),
        dec: Angle.Degrees(-56.69236332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219301"},
        {"Hipparcos Number", "HIP 114810"},
        {"Geneva Identification System", "GEN# +1.00219301"},
        {"Smithsonian Astrophysical Observation", "SAO 247798"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.84772842),
        dec: Angle.Degrees(-56.69180624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75552"},
        {"Hipparcos Number", "HIP 43203"},
        {"Smithsonian Astrophysical Observation", "SAO 236288"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.01889938),
        dec: Angle.Degrees(-56.69155348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145740"},
        {"Hipparcos Number", "HIP 79669"},
        {"Smithsonian Astrophysical Observation", "SAO 243504"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.89563451),
        dec: Angle.Degrees(-56.68778236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119439"},
        {"Hipparcos Number", "HIP 67065"},
        {"Geneva Identification System", "GEN# +1.00119439"},
        {"Smithsonian Astrophysical Observation", "SAO 241126"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.15755372),
        dec: Angle.Degrees(-56.68570320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146020"},
        {"Hipparcos Number", "HIP 79794"},
        {"Smithsonian Astrophysical Observation", "SAO 243532"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.26753449),
        dec: Angle.Degrees(-56.68482583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154857"},
        {"Hipparcos Number", "HIP 84069"},
        {"Geneva Identification System", "GEN# +1.00154857"},
        {"Smithsonian Astrophysical Observation", "SAO 244491"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.81512202),
        dec: Angle.Degrees(-56.68066124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153386"},
        {"Hipparcos Number", "HIP 83380"},
        {"Geneva Identification System", "GEN# +1.00153386"},
        {"Smithsonian Astrophysical Observation", "SAO 244377"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.61783034),
        dec: Angle.Degrees(-56.67945798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97122"},
        {"Hipparcos Number", "HIP 54566"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.47929853),
        dec: Angle.Degrees(-56.67937287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24059"},
        {"Hipparcos Number", "HIP 17669"},
        {"Smithsonian Astrophysical Observation", "SAO 233268"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.75803089),
        dec: Angle.Degrees(-56.67887503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148045"},
        {"Hipparcos Number", "HIP 80696"},
        {"Geneva Identification System", "GEN# +1.00148045"},
        {"Smithsonian Astrophysical Observation", "SAO 243848"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.14595926),
        dec: Angle.Degrees(-56.67821441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136573"},
        {"Hipparcos Number", "HIP 75364"},
        {"Geneva Identification System", "GEN# +1.00136573"},
        {"Smithsonian Astrophysical Observation", "SAO 242473"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.01082076),
        dec: Angle.Degrees(-56.67611800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115776"},
        {"Hipparcos Number", "HIP 65094"},
        {"Smithsonian Astrophysical Observation", "SAO 240755"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.11814702),
        dec: Angle.Degrees(-56.67519741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117229"},
        {"Hipparcos Number", "HIP 65872"},
        {"Fundamental Katalog 5th Edition", "FK5 5191"},
        {"Smithsonian Astrophysical Observation", "SAO 240892"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.52710921),
        dec: Angle.Degrees(-56.67453566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146270"},
        {"Hipparcos Number", "HIP 79893"},
        {"Smithsonian Astrophysical Observation", "SAO 243569"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.61081087),
        dec: Angle.Degrees(-56.67294862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88384"},
        {"Hipparcos Number", "HIP 49790"},
        {"Geneva Identification System", "GEN# +1.00088384"},
        {"Smithsonian Astrophysical Observation", "SAO 237749"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.45598012),
        dec: Angle.Degrees(-56.67059812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
